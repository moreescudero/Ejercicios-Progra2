using Biblioteca;

namespace Ejercicio2_1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadNumeros = 10;
            int numeroMinimo = -100;
            int numeroMaximo = 100;
            int numMinimoIngresado = 101;
            int numMaximoIngresado = -101;
            bool banderaMinimoMaximo = true;
            bool esCorrecto = false;
            int acumulador = 0;

            for(int i = 0; i < cantidadNumeros; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese un numero entero entre -100 y 100: ");
                    string? numeroIngresado = Console.ReadLine();
                    bool esNumerica = int.TryParse(numeroIngresado, out int numero);
                    if (esNumerica)
                    {
                        esCorrecto = Validador.Validar(numero, numeroMinimo, numeroMaximo);
                        if(!esCorrecto)
                        {
                            Console.WriteLine("ERROR");
                        }
                        else
                        {
                            acumulador += numero;
                            if(banderaMinimoMaximo)
                            {
                                numMaximoIngresado = numero;
                                numMinimoIngresado = numero;
                                banderaMinimoMaximo = false;
                            }
                            if(numMaximoIngresado < numero)
                            {
                                numMaximoIngresado = numero;
                            }
                            else if(numMinimoIngresado > numero)
                            {
                                numMinimoIngresado = numero;
                            
                            }
                        }
                    }
                } while (!esCorrecto);

            }
            float promedioTotal = (float)acumulador / cantidadNumeros;

            Console.WriteLine("El numero minimo es {0}, el numero maximo es {1} y el promedio es {2}", numMinimoIngresado, numMaximoIngresado, promedioTotal);

        }
    }
}