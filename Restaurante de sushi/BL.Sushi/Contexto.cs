using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Sushi.FoodMenuBL;

namespace BL.Sushi
{
    public class Contexto : DbContext
    {


        public Contexto() : base(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDBFilename=" +
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\SushiDB.mdf")
        {

        }
         protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());//Agrega Datos de inicio a la base de datos despues de eliminar
        }


        public DbSet<FoodMenu> foodmenu { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}