using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Sushi
{

    public class SeguridadBL
    {
        Contexto _contexto;

        public SeguridadBL()
        {
            _contexto = new Contexto();
        }

        public bool Autorizar(string usuario, string contraseña)
        {
            var usuarios = _contexto.Usuarios.ToList();


            foreach (var usuarioDB in usuarios)
            {
                if (usuario == usuarioDB.Nombre && contraseña == usuarioDB.Contraseña);
                {
                    return true;
                }
            }
            return false;
        }
    }
    public class Usuarios
    {
        public string contraseña;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
    }
}