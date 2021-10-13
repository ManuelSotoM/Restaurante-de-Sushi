using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Sushi
{
   public class FoodMenuBL
    {
        public BindingList<FoodMenu> ListaFoodMenu { get; set; }

        public FoodMenuBL()

        
        {
            ListaFoodMenu = new BindingList<FoodMenu>();

            var FoodMenu1 = new FoodMenu();
            FoodMenu1.Menu = "Sushi Roll";
            FoodMenu1.Descripcion = "es un estilo de maki sushi que surgió en Estados Unidos, se caracteriza porque en lugar de estar recubierto por el alga nori, es el arroz el que envuelve el resto de ingredientes, es decir, es un rollo de sushi invertido";
            FoodMenu1.Precio= 25;
            FoodMenu1.Calificacion = 2;
            FoodMenu1.Activo = true;

            ListaFoodMenu.Add(FoodMenu1);
            var FoodMenu2 = new FoodMenu();
            FoodMenu2.Menu = "Sashimi";
            FoodMenu2.Descripcion = "El sashimi es un plato de origen japonés compuesto por pescados crudos o mariscos, finamente cortados,";
            FoodMenu2.Precio = 19;
            FoodMenu2.Calificacion = 3;
            FoodMenu2.Activo = true;

            ListaFoodMenu.Add(FoodMenu2);
            var FoodMenu3 = new FoodMenu();
            FoodMenu3.Menu = "Salad";
            FoodMenu3.Descripcion = " un plato que combina hortalizas frías (como lechuga, rúcula o espinaca)";
            FoodMenu3.Precio = 9;
            FoodMenu3.Calificacion = 2;
            FoodMenu3.Activo = true;

            ListaFoodMenu.Add(FoodMenu3);
        }
        public BindingList<FoodMenu> ObtenerFoodMenu()
        {
            return ListaFoodMenu;
        }
    }
        public class FoodMenu
    {
        public  string Menu { get; set; }
        public string Descripcion { get; set; }
        public  double Precio  { get; set; }
        public int Calificacion { get; set; }
        public bool Activo { get; set; }


    }
}
