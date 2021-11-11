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
    }
}