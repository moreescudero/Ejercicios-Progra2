namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado(); // esta mal
            string? continuar;

            do
            {
                Console.WriteLine("Ingrese el nombre del empleado: ");
                string? nombreIngresado = Console.ReadLine();

                Console.WriteLine("Ingrese las horas trabajadas del empleado: ");
                string? horasIngresadas = Console.ReadLine();
                bool esNumericaHoras = int.TryParse(horasIngresadas, out int horasTrabajadas);

                Console.WriteLine("Ingrese la antiguedad del empleado: ");
                string? antiguedadIngresada = Console.ReadLine();   
                bool esNumericaAntiguedad = int.TryParse(antiguedadIngresada, out int antiguedad);

                Console.WriteLine("Ingrese el valor de las horas del empleado: ");
                string? valorIngresado = Console.ReadLine();
                bool esNumericaValor = int.TryParse(valorIngresado, out int valorHoras);

                Console.WriteLine("¿Desea agregar otro empleado? (si/no): ");
                continuar = Console.ReadLine();

            } while (continuar == "si");
            

        }
    }
}