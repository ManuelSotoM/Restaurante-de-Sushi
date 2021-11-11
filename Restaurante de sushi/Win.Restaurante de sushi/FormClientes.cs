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

namespace Win.Restaurante_de_sushi
{
    public partial class FormClientes : Form
    {
        ClientesBL _clientes;

        public FormClientes()
        {
            InitializeComponent();
            _clientes = new ClientesBL();
            listaClientesBindingSource.DataSource = _clientes.ObtenerClientes();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void FormClientes_Load_1(object sender, EventArgs e)
        {

        }

        private void clientesBLBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void clientesBLBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void listaClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaClientesBindingSource.EndEdit();
            var cliente = (Cliente)listaClientesBindingSource.Current;

            var resultado = _clientes.GuardarCliente(cliente);

            if (resultado.Exitoso == true)
            {
                listaClientesBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Producto Guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
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
     
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            

            DeshabilitarHabilitarBotones(false);
        }
    }
}
