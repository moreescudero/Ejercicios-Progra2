using Biblioteca;

namespace Ejericio2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcionCalcular;
            double resultado;

            Console.WriteLine("1- Cuadrado");
            Console.WriteLine("2- Triangulo");
            Console.WriteLine("3- Circulo");
            Console.WriteLine("Ingrese un numero segun lo que desee calcular: ");
            string? numeroIngresado = Console.ReadLine();
            bool esNumerica = int.TryParse(numeroIngresado, out opcionCalcular);

            if(esNumerica && opcionCalcular < 4 && opcionCalcular > 0)
            {
                switch (opcionCalcular)
                {
                    case 1:
                        double longitud;
                        Console.WriteLine("Ingrese la longitud del cuadrado: ");
                        string? longitudIngresada = Console.ReadLine();
                        bool longitudNumerica = double.TryParse(longitudIngresada, out longitud);
                        if (longitudNumerica)
                        {
                            resultado = CalculadoraDeArea.CalcularAreaCuadrado(longitud);
                            Console.WriteLine("El area del cuadrado es {0}", resultado);
                        }
                        break;
                    case 2:
                        double altura;
                        double baseTriangulo;
                        Console.WriteLine("Ingrese el altura del triangulo: ");
                        string? alturaIngresada = Console.ReadLine();
                        bool alturaNumerica = double.TryParse(alturaIngresada, out altura);
                        Console.WriteLine("Ingrese la base del triangulo: ");
                        string? baseIngresada = Console.ReadLine();
                        bool baseNumerica = double.TryParse(baseIngresada, out baseTriangulo);
                        if(baseNumerica && alturaNumerica)
                        {
                            resultado = CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo, altura);
                            Console.WriteLine("El area del triangulo es {0}", resultado);
                        }

                        break;
                    default:
                        double radio;
                        Console.WriteLine("Ingrese el radio del circulo: ");
                        string? radioIngresado = Console.ReadLine();
                        bool radioNumerico = double.TryParse(radioIngresado, out radio);
                        if (radioNumerico)
                        {
                            resultado = CalculadoraDeArea.CalcularAreaCirculo(radio);
                            Console.WriteLine("El area del circulo es {0}", resultado);
                        }
                        break;
                }
            }

        }
    }
}