using Biblioteca;

namespace Ejercicio2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anio, mes, dia;

            Console.WriteLine("Calcular dias vividos");
            dia = MetodosIngreso.IngresarInt("Ingrese su dia de nacimiento: ");
            mes = MetodosIngreso.IngresarInt("Ingrese su mes de nacimiento: ");
            anio = MetodosIngreso.IngresarInt("Ingrese su año de nacimiento: ");

            DateTime fechaNacimiento = new DateTime(anio, mes, dia);
            decimal dias = CalcularDiasVividos(fechaNacimiento);
            Console.WriteLine(dias);
        }

        static decimal CalcularDiasVividos(DateTime fecha)
        {
            DateTime ahora = DateTime.Now;
            int diasVividos = (ahora - fecha).Days;

            return diasVividos;
        }
    }
}