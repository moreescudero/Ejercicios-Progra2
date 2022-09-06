namespace Ejercicio2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anio, mes, dia;

            Console.WriteLine("Calcular dias vividos");
            Console.WriteLine("Ingrese su dia de nacimiento: ");
            string? diaIngresado = Console.ReadLine();
            bool diaNumerica = int.TryParse(diaIngresado, out dia);
            Console.WriteLine("Ingrese su mes de nacimiento: ");
            string? mesIngresado = Console.ReadLine();
            bool mesNumerica = int.TryParse(mesIngresado, out mes);
            Console.WriteLine("Ingrese su año de nacimiento: ");
            string? anioIngresado = Console.ReadLine();
            bool anioNumerica = int.TryParse(anioIngresado, out anio);

            if(diaNumerica && mesNumerica && anioNumerica )
            {
                DateTime fechaNacimiento = new DateTime(anio, mes, dia);
                decimal dias = CalcularDiasVividos(fechaNacimiento);
                Console.WriteLine(dias);
            }

        }

        static decimal CalcularDiasVividos(DateTime fecha)
        {
            DateTime ahora = DateTime.Now;
            decimal diasVividos = ahora.Year - fecha.Year;
            diasVividos *= (decimal)365.25;
            decimal meses = ahora.Month - fecha.Month;
            meses *= (decimal)30.4375;
            diasVividos += meses;
            diasVividos += ahora.Day - fecha.Day;

            return diasVividos;
        }
    }
}