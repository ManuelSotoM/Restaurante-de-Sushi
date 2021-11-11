using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL.Sushi
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto> 
    {
        protected override void Seed(Contexto contexto)
        {

            var usuarioAdmin = new Usuarios();
            usuarioAdmin.Nombre = "REYDESUSHI";
            usuarioAdmin.contraseña = "sushiper";

            contexto.Usuarios.Add(usuarioAdmin);

            var categoria1 = new Categoria();
            categoria1.Descripcion = "Mar";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Tierra";
            contexto.Categorias.Add(categoria2);

            var tipo1 = new Tipo();
            tipo1.Descripcion = "Mediterranio";
            contexto.Tipos.Add(tipo1);

            base.Seed(contexto);
        }

    }

}