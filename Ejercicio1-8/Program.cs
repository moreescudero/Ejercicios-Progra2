namespace Ejercicio1_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la altura de su triangulo rectangulo: ");
            string? numeroIngresado = Console.ReadLine();
            bool esNumerica = int.TryParse(numeroIngresado, out int numero);

            if(esNumerica && numero > 0 )
            {
                string? trianguloRectangulo = "*";
                for(int i = 0; i < numero; i++)
                {
                    Console.WriteLine("{0}", trianguloRectangulo);
                    trianguloRectangulo += "**";
                }
            }
        }
    }
}