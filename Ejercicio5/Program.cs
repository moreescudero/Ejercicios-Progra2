namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroTope;
           
            Console.WriteLine("Ingrese un numero para calcular los centros numericos: ");
            string? numeroString = Console.ReadLine();
            bool esNumero = int.TryParse(numeroString, out numeroTope);

            if (esNumero)
            {
                for (int centro = 2; centro < numeroTope; centro++)
                {
                    int acumuladorPrimerLista = 0;

                    for (int i = 0; i < centro; i++)
                    {
                        acumuladorPrimerLista += i;  
                    }

                    int acumuladorSegundaLista = 0;

                    for(int j = centro + 1; j <= acumuladorPrimerLista; j++)
                    {
                        if((acumuladorPrimerLista == acumuladorSegundaLista) || (acumuladorSegundaLista > acumuladorPrimerLista))
                        {
                            break;
                        }
                        acumuladorSegundaLista += j;
                    }

                    if(acumuladorPrimerLista == acumuladorSegundaLista)
                    {
                        Console.WriteLine("El numero centro es: {0}", centro);
                    }
                }
            }
        }
    }
}