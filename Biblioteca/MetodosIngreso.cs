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
            int numero = IngresarInt(mensaje);
            while(numero < minimo || numero > maximo)
            {
                Console.WriteLine("ERROR");
                numero = IngresarInt(mensaje);
            }
            return numero;
        }
        
        
        public static float IngresarFloat(string? mensaje)
        {
            float numero = 0;
            bool esNumerica;
            string? numeroIngresado;
            do
            {
                Console.WriteLine(mensaje);
                numeroIngresado = Console.ReadLine();
                esNumerica = EsNumerica(numeroIngresado);
                if(esNumerica)
                {
                    float.TryParse(numeroIngresado, out numero);
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            } while (!esNumerica);

            return numero;
        }
        public static float IngresarFloat(string? mensaje, int maximo, int minimo)
        {
            float numero = IngresarFloat(mensaje);
            while(numero < minimo || numero > maximo)
            {
                Console.WriteLine("ERROR");
                numero = IngresarFloat(mensaje);
            }
            return numero;
        }

        private static bool EsNumerica(string? numIngresado)
        {
            return float.TryParse(numIngresado, out float numero);
        }

        private static bool ValidarLetra(string? letra)
        {
            bool retorno = false;

            if (letra is not null)
            {
                for (int i = 0; i < letra.Length; i++)
                {
                    if (char.IsLetter(letra[i]))
                    {
                        retorno = true;
                    }
                    else
                    {
                        retorno = false;
                        break;
                    }
                }
            }

            return retorno;
        }
        
        private static bool ValidarAlfaNumerica(string? letra)
        {
            bool retorno = false;

            if (letra is not null)
            {
                for (int i = 0; i < letra.Length; i++)
                {
                    if (char.IsLetterOrDigit(letra[i]))
                    {
                        retorno = true;
                    }
                    else
                    {
                        retorno = false;
                        break;
                    }
                }
            }

            return retorno;
        }

        
        public static string IngresarAlfaNumerica(string? mensaje)
        {
            string? palabra;
            do
            {
                Console.WriteLine(mensaje);
                palabra = Console.ReadLine();
                if (!ValidarAlfaNumerica(palabra))
                {
                    Console.WriteLine("ERROR");
                }
            } while (!ValidarAlfaNumerica(palabra));

            return palabra;
        }

        
        public static string IngresarString(string? mensaje)
        {
            string? palabra;
            do
            {
                Console.WriteLine(mensaje);
                palabra = Console.ReadLine();
                if(!ValidarLetra(palabra))
                {
                    Console.WriteLine("ERROR");
                }
            } while (!ValidarLetra(palabra));

            return palabra;
        }
    }
}
