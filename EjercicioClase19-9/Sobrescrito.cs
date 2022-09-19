using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase19_9
{
    public class Sobrescrito
    {
        public override string ToString()
        {
            return "¡Este es mi metodo ToString sobrecargado!";
        }

        public override bool Equals(object? obj)
        {
            Sobrescrito sobrescrito = obj as Sobrescrito;
            if(sobrescrito is not null)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}
