using System.Text;

namespace Ejercicio2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool esNumerica;
            int numero;
            do
            {
                Console.WriteLine("Ingrese un entero: ");
                string? numeroIngresado = Console.ReadLine();
                esNumerica = int.TryParse(numeroIngresado, out numero);

            } while (!esNumerica);

            string? tabla = Multiplicador(numero);
            Console.WriteLine(tabla);

        } 

        static string Multiplicador(int numeroIngresado)
        {
            StringBuilder tabla = new StringBuilder();
            tabla.Insert(tabla.Length, "La tabla del " + numeroIngresado +"\n");
            for (int i = 1; i < 10; i++)
            {
                tabla.Insert(tabla.Length, numeroIngresado + " x " + i + " = " + numeroIngresado*i + "\n");
            }
            return tabla.ToString();
        }

    }
}