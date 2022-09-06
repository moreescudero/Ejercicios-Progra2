using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Validador
    {
        public static bool ValidarRespuesta(string? respuesta)
        {
            if(respuesta == "S" || respuesta == "s")
            {
                return true;
            }
            return false;
        }
        public static bool Validar(int valor, int min, int max)
        {
            if(valor > min && valor < max)
            {
                return true;
            }
            return false;
        }
    }
}
