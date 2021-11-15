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
    public partial class FormReporteFoodMenu : Form
    {
        public FormReporteFoodMenu()
        {
            InitializeComponent();

            var _FoodMenuBL = new FoodMenuBL();          
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _FoodMenuBL.ObtenerFoodMenu();

            var reporte = new ReporteFoodMenu();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
