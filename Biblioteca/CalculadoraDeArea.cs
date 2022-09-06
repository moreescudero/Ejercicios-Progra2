using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            return Math.Pow(longitudLado, 2);
        }

        public static double CalcularAreaTriangulo(double baseArea, double altura)
        {
            return baseArea * altura;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * (Math.Pow(radio, 2));
        }
    }
}
