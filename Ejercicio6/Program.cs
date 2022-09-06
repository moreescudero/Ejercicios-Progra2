namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anioInicio;
            int anioFin;

            Console.WriteLine("Ingrese un anio de inicio: ");
            string? anioInicioString = Console.ReadLine();
            bool esNumeroInicio = int.TryParse(anioInicioString, out anioInicio);
           
            Console.WriteLine("Ingrese un anio de inicio: ");
            string? anioFinString = Console.ReadLine();
            bool esNumeroFin = int.TryParse(anioFinString, out anioFin);

            if ((esNumeroFin == true) && (esNumeroInicio == true))
            {
                for (int i = anioInicio; i < anioFin; i++)
                {
                    if (i % 4 == 0)
                    {
                        Console.WriteLine("{0}", i);
                    }
                }
            }

        }
    }
}