namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroAElevar;
            int potenciaAlCuadrado = 2;
            int potenciaAlCubo = 3;
            bool banderaMenorACero;

            do
            {
                banderaMenorACero = true;
                Console.WriteLine("Ingrese un numero: ");
                string? numeroIngresado = Console.ReadLine();
                bool esNumero = int.TryParse(numeroIngresado, out numeroAElevar);
                if( numeroAElevar <= 0 || esNumero == false )
                {
                    Console.WriteLine("ERROR, reingrese numero");
                    banderaMenorACero = false;
                }
            } while ( banderaMenorACero == false );

            double numeroAlCuadrado = Math.Pow(numeroAElevar, potenciaAlCuadrado);
            double numeroAlCubo = Math.Pow(numeroAElevar, potenciaAlCubo);

            Console.WriteLine("El cuadrado de {0} es {1} y el cubo es {2}", numeroAElevar, numeroAlCuadrado, numeroAlCubo);
            
            
        }
    }
}