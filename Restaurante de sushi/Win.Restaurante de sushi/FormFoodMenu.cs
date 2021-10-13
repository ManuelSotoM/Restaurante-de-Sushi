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
    public partial class FormFoodMenu : Form
    {
        FoodMenuBL _FoodMenu;
        public FormFoodMenu()
        {
            InitializeComponent();
            _FoodMenu = new FoodMenuBL();
            listaFoodMenuBindingSource.DataSource = _FoodMenu.ObtenerFoodMenu();
        }
    }
}
