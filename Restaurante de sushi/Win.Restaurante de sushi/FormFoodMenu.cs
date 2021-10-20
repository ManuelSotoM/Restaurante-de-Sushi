using BL.Sushi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BL.Sushi.FoodMenuBL;

namespace Win.Restaurante_de_sushi
{
    public partial class FormFoodMenu : Form
    {
        FoodMenuBL _FoodMenu;


        public FormFoodMenu()
        {
            InitializeComponent();
            _FoodMenu = new FoodMenuBL();
            listaFoodMenuBindingSource.DataSource = _FoodMenu.ObtenerFoodMenu();
        }



        private void listaFoodMenuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaFoodMenuBindingSource.EndEdit();
            var foodmenu = (FoodMenu)listaFoodMenuBindingSource.Current;

            var resultado = _FoodMenu.GuardarFoodMenu(foodmenu);

            if (resultado.Exitoso == true)
            {
                listaFoodMenuBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _FoodMenu.AgregarFoodMenu();
            listaFoodMenuBindingSource.MoveLast();
            DeshabilitarHabilitarBotones(false);
        }
        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }




        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (precioTextBox.Text != " ")
            { 
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {

                var precio = Convert.ToInt32(precioTextBox.Text);
                Eliminar(precio);
            }
        }
    }

        private void Eliminar(int precio)
        {
            
            var resultado = _FoodMenu.EliminarFoodMenu(precio);
            if (resultado == true)
            {
                listaFoodMenuBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el producto");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }
    }
}



        
