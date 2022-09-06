using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cuenta
    {
        public string? titular;
        public decimal cantidad;

        public Cuenta(string? titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }


    }
}
