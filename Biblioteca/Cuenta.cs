using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cuenta
    {
        private string? titular;
        private decimal cantidad;

        public Cuenta(string? titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Titular
        {
            get
            {
                if(titular is not null)
                {
                    return titular;
                }
                else
                {
                    return "ERROR TITULAR";
                }
            }
        }

        public decimal Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }

        public string Mostrar()
        {
            string? retorno;

            retorno = "La razon social es: " + titular + " \nMonto actual: $" + cantidad ;

            return retorno;
        }

        public bool Ingresar(decimal ingreso)
        {
            bool retorno = false;

            if(ingreso > 0)
            {
                Cantidad += ingreso;
                retorno = true;
            }

            return retorno;
        }

        public bool Retirar(decimal extraccion)
        {
            bool retorno = false;

            if (extraccion > 0)
            {
                Cantidad -= extraccion;
                retorno = true;
            }
            return retorno;
        }
    }
}
