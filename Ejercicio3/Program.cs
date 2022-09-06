namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroTope;
            string? continuar;
            int contadorDivisores = 0;

            do
            {
                
                Console.WriteLine("Ingrese un numero: ");
                string? numeroIngresado = Console.ReadLine();
                bool esNumero = int.TryParse(numeroIngresado, out numeroTope);
                
                while(esNumero == false)
                {
                    Console.WriteLine("ERROR, si desea salir del programa ingrese 'salir', sino presione cualquier tecla: ");
                    string? salir = Console.ReadLine();

                    if(salir == "salir")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Por favor ingrese un numero: ");
                        numeroIngresado = Console.ReadLine();
                        esNumero = int.TryParse(numeroIngresado, out numeroTope);
                    }
                }
                for(int i = 1; i <= numeroTope; i++)
                {
                    contadorDivisores = 0;
                    for(int j = 1; j <= numeroTope; j++)
                    {
                        if(i % j == 0)
                        {
                            contadorDivisores++;
                        }
                    }
                    if(contadorDivisores == 2)
                    {
                        Console.WriteLine("{0}", i);
                    }
                }

                Console.WriteLine("¿Desea ingresar otro numero? (si/no): ");
                continuar = Console.ReadLine();

            } while (continuar == "si");
        }
    }
}