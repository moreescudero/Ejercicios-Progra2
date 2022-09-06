namespace Ejercicio2_Aux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroFactorial;

            Console.WriteLine("Ingrese el numero sobre el que desea aplicar factorial: ");
            string? numeroIngresado = Console.ReadLine();
            bool esNumerica = int.TryParse(numeroIngresado, out numeroFactorial);

            if(esNumerica)
            {
                int resultado = CalcularFactorial(numeroFactorial);
                Console.WriteLine("El resultado es {0}", resultado);
            }
        }

        static int CalcularFactorial(int numero)
        {
            int resultado = 1;

            for(int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}