namespace Ejercicio2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseTriangulo;
            double altura;

            Console.WriteLine("Sacar la hipotenusa");
            Console.WriteLine("Ingrese la base:");
            string? baseIngresada = Console.ReadLine();
            bool baseNumerica = double.TryParse(baseIngresada, out baseTriangulo);
            Console.WriteLine("Ingrese la altura:");
            string? alturaIngresada = Console.ReadLine();
            bool alturaNumerica = double.TryParse(alturaIngresada, out altura);

            if(alturaNumerica && baseNumerica)
            {
                double resultado = Math.Sqrt((Math.Pow(baseTriangulo, 2)) +(Math.Pow(altura, 2)));
                Console.WriteLine("La hipotenusa del triangulo con base de {0} y altura de {1} es {2}", baseTriangulo,altura,resultado);
            }

        }
    }
}