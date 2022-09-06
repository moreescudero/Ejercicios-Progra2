using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Calculadora
    {
        public static int Calcular(int primerNumero, int segundoNumero, string? operacionMatematica)
        {
            int resultado = 0;
            switch(operacionMatematica)
            {
                case "+":
                    resultado = primerNumero + segundoNumero;
                    break;
                case "-":
                    resultado = primerNumero - segundoNumero;
                    break;
                case "*":
                    resultado = primerNumero * segundoNumero;
                    break;
                case "/":
                    if(Calculadora.Validar(segundoNumero))
                    {
                        resultado = primerNumero / segundoNumero;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero. ");
                    }
                    break;
                default:
                    Console.WriteLine("Operacion matematica invalida. ");
                    break;

            }
            return resultado;
        }

        private static bool Validar(int numero)
        {
            if(numero != 0)
            {
                return true;
            }
            return false;
        }

    }
}
