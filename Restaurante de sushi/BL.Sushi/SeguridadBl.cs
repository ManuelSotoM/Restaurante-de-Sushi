using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Sushi
{
    public class SeguridadBL
    {
        public bool Autorizar(string usuario, string contraseña)
        {
            if (usuario == "REYDESUSHI" && contraseña == "sushiper")
            {
                return true;
            }
            else
            {
                if (usuario == "CAPITANDELMAR" && contraseña == "sushiper2")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
