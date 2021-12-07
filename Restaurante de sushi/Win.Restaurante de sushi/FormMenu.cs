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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();

            toolStripStatusLabel1.Text = "Usuario :ADRIAN PIneda;";
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formfoodmenu = new FormFoodMenu();
            formfoodmenu.MdiParent = this;
            formfoodmenu.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formclientes = new FormClientes();
            formclientes.MdiParent = this;
            formclientes.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new FormFactura();
            formFactura.MdiParent = this;
            formFactura.Show();
        }

        private void reporteDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteFoodMenu = new FormReporteFoodMenu();
            formReporteFoodMenu.MdiParent = this;
            formReporteFoodMenu.Show();
        }

        private void reporteDeVentaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formReporteFacturas = new FormReporteFacturas();
            formReporteFacturas.MdiParent = this;
            formReporteFacturas.Show();
        }
    }
}