using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class MetodosIngreso
    {
        public static int IngresarInt(string? mensaje)
        {
            int numero = 0;
            bool esNumerica;
            string? numeroIngresado;
            do
            {
                Console.WriteLine(mensaje);
                numeroIngresado = Console.ReadLine();
                esNumerica = EsNumerica(numeroIngresado);
                if(esNumerica)
                {
                    int.TryParse(numeroIngresado, out numero);
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            } while (!esNumerica);

            return numero;
        }
        public static int IngresarInt(string? mensaje, int maximo, int minimo)
        {
            int i = IngresarInt(mensaje);
            while(i < minimo && i > maximo)
            {
                Console.WriteLine("ERROR");
                i = IngresarInt(mensaje);
            }
            return i;
        }

        private static bool EsNumerica(string? numIngresado)
        {
            return int.TryParse(numIngresado, out int numero);
        }
    }
}
