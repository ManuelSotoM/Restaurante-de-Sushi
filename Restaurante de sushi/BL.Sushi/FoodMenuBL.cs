using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Sushi
{
    public class FoodMenuBL
    {
        Contexto _contexto;
        public BindingList<foodmenu> ListaFoodMenu { get; set; }
      

        public FoodMenuBL()
        {
            _contexto = new Contexto();
            ListaFoodMenu = new BindingList<foodmenu>();
        }
        public BindingList<foodmenu> ObtenerFoodMenu()
        {
            _contexto.FoodMenu.Load();
            ListaFoodMenu = _contexto.FoodMenu.Local.ToBindingList();
            return ListaFoodMenu;
        }


        public Resultado GuardarFoodMenu(foodmenu foodmenu)
        {
            var resultado = Validar(foodmenu);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            if (foodmenu.Precio == 0)
            {
                foodmenu.Precio = ListaFoodMenu.Max(item => item.Precio) + 1;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }
        public void AgregarFoodMenu()
        {
            var nuevoFoodMenu = new foodmenu();
            ListaFoodMenu.Add(nuevoFoodMenu);
        }
        public bool EliminarFoodMenu(double precio)
        {
            foreach (var foodmenu in ListaFoodMenu)
            {
                if (foodmenu.Precio == precio)
                {
                    ListaFoodMenu.Remove(foodmenu);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }
        private Resultado Validar(foodmenu foodmenu)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(foodmenu.Menu) == true)
            {
                resultado.Mensaje = "Ingrese un Menu ";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(foodmenu.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una descripcion ";
                resultado.Exitoso = false;
            }


            if (foodmenu.Precio < 0)
            {
                resultado.Mensaje = "El precio debe ser mayor que 0 ";
                resultado.Exitoso = false;
            }


            if (foodmenu.Calificacion < 0)
            {
                resultado.Mensaje = "La calificacion debe ser mayor que 0 ";
                resultado.Exitoso = false;
            }
            return resultado;


        }

        public class foodmenu
        {

            public int Id { get; set; }
            public string Menu { get; set; }
            public string Descripcion { get; set; }
            public double Precio { get; set; }
            public int Calificacion { get; set; }
            public bool Activo { get; set; }
        }
        public class Resultado
        {
            public bool Exitoso { get; set; }
            public string Mensaje { get; set; }
        }
    }
}

    


