using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase5_9
{
    public class Producto
    {
        private string? nombre;
        private float precio;
        private int codigoProducto = 1000;
        public Producto(string? nombre, float precio)
        {
            this.nombre = nombre;
            this.precio = precio;
            codigoProducto = AsignarCodigo(codigoProducto);
        }

        public string Nombre
        {
            get
            {
                if(nombre is not null)
                {
                    return nombre;
                }
                else
                {
                    Console.WriteLine("ERROR >:@");
                    return "ERROR";
                }
            }
        }

        public float Precio
        {
            get
            {
                return precio;
            }
        }

        public int CodigoProducto
        {
            get
            {
                return codigoProducto;
            }
        }

        private static int AsignarCodigo(int codigo)
        {
            return codigo++;
        }
    }
}
