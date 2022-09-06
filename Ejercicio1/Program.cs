namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int numeroMaximo = 0;
            int numeroMinimo = 0;
            float promedio;
            int acumulador = 0;
            bool banderaMinMax = true;
            int limiteIteraciones = 5;

            for( int i = 0 ; i < limiteIteraciones ; i++ )
            {
                Console.WriteLine("Ingrese un numero: ");
                string? numeroString = Console.ReadLine();
                bool esNumero = int.TryParse(numeroString, out numeroIngresado);

                if( esNumero )
                {
                    if( banderaMinMax )
                    {
                        numeroMinimo = numeroIngresado;
                        numeroMaximo = numeroIngresado;
                        banderaMinMax = false;
                    }
                    else
                    {
                        if( numeroMinimo > numeroIngresado )
                        {
                            numeroMinimo = numeroIngresado;
                        }
                        else
                        {
                            if( numeroMaximo < numeroIngresado )
                            {
                                numeroMaximo = numeroIngresado;
                            }
                        }
                    }
                    acumulador += numeroIngresado;
                }
            }
            promedio = (float)acumulador / limiteIteraciones;

            Console.WriteLine("El numero minimo es {0}, el numero maximo es {1} y el promedio es {2}", numeroMinimo, numeroMaximo, promedio);
        }
    }
}