using BL.Sushi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        CategoriasBL _categorias;
        TiposBL _tiposBL;

        public FormFoodMenu()
        {
            InitializeComponent();
            _FoodMenu = new FoodMenuBL();
            listaFoodMenuBindingSource.DataSource = _FoodMenu.ObtenerFoodMenu();

            _categorias = new CategoriasBL();
             listaCategoriasBindingSource.DataSource = _categorias.ObtenerCategorias();

            _tiposBL = new TiposBL();
             listaTiposBindingSource.DataSource = _tiposBL.ObtenerTipos();

        }



        private void listaFoodMenuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaFoodMenuBindingSource.EndEdit();
            var foodmenu = (FoodMenu)listaFoodMenuBindingSource.Current;

            if(fotoPictureBox.Image != null)
            {
                foodmenu.Foto = Program.imageToByArray(fotoPictureBox.Image);
            }
            else
            {
                foodmenu.Foto = null;
            }

            var resultado = _FoodMenu.GuardarFoodMenu(foodmenu);

            if (resultado.Exitoso == true)
            {
                listaFoodMenuBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Producto Guardado");
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

        private void menuTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fotoLabel_Click(object sender, EventArgs e)
        {

        }

        private void fotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void FormFoodMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var foodmenu = (FoodMenu)listaFoodMenuBindingSource.Current;
            if (foodmenu != null)
            {

                openFileDialog1.ShowDialog();
                var archivo = openFileDialog1.FileName;

                if (archivo != " ")
                {
                    var fileInfo = new FileInfo(archivo);
                    var filestream = fileInfo.OpenRead();

                    fotoPictureBox.Image = Image.FromStream(filestream);
                }
            }
            else
            {
                MessageBox.Show("Cree una comida para el menu antes de agregarle una imagen");
            }
        }






        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void categoriaIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tiposBLBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}



        
