using Biblioteca;

namespace Ejercicio2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            do
            {
                Console.WriteLine("Ingrese el primer numero: ");
                string? primerNumeroIngresado = Console.ReadLine();
                bool esNumericaPrimera = int.TryParse(primerNumeroIngresado, out int primerNumero);
                Console.WriteLine("Ingrese el segundo numero: ");
                string? segundoNumeroIngresado = Console.ReadLine();
                bool esNumericaSegunda = int.TryParse(segundoNumeroIngresado, out int segundoNumero);
                Console.WriteLine("Ingrese la operacion matematica que desea realizar (+,-,*,/): ");
                string? operacionIngresada = Console.ReadLine();

                int resultado = Calculadora.Calcular(primerNumero, segundoNumero, operacionIngresada);
                Console.WriteLine("El resultado es: {0}", resultado);
                Console.WriteLine("¿Desea continuar? (S/N): ");
                string? respuesta = Console.ReadLine();
                continuar = Validador.ValidarRespuesta(respuesta);

            } while (continuar);

        }
    }
}