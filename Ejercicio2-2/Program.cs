using Biblioteca;

namespace Ejercicio2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            int acumuladorSuma = 0;

            do
            {
                Console.WriteLine("Ingrese un numero para sumar: ");
                string? numeroIngresado = Console.ReadLine();
                bool esNumerica = int.TryParse(numeroIngresado, out int numero);

                if (esNumerica)
                {
                    acumuladorSuma += numero;
                    Console.WriteLine("¿Desea continuar? (S/N): ");
                    string? respuesta = Console.ReadLine();
                    continuar = Validador.ValidarRespuesta(respuesta);
                }

            } while (continuar);

            Console.WriteLine("El resultado de la suma es: {0}", acumuladorSuma);
        }
    }
}