namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorNumerosPerfectos = 0;
            int limiteNumeros = 8129;
            int acumuladorDivisores;

            for(int i = 2; i < limiteNumeros; i++)
            {
                acumuladorDivisores = 0;
                for(int j = 1; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        acumuladorDivisores += j;
                    }
                }

                if(acumuladorDivisores == i && contadorNumerosPerfectos < 4)
                {
                    Console.WriteLine("{0}", i);
                    contadorNumerosPerfectos++;
                }
            }

        }
    }
}