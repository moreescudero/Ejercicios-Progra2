using Biblioteca;

namespace Ejercicio3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string? titular = MetodosIngreso.IngresarString("Ingrese la razon social:");
            decimal cantidad = MetodosIngreso.IngresarDecimal("Ingrese el monto actual de la cuneta:");

            Cuenta cuenta = new Cuenta(titular, cantidad);
            bool continuar = true;
            bool funciono;
            do
            {
                funciono = false;
                int opcion = MetodosIngreso.IngresarInt("1- Ingresar dinero\n2- Extraer dinero\n3- Mostrar informacion\n4- Salir", 5, 0);
                switch(opcion)
                {
                    case 1:
                        decimal ingreso = MetodosIngreso.IngresarDecimal("Monto que desea ingresar:");
                        funciono = cuenta.Ingresar(ingreso);
                        break;
                    case 2:
                        decimal extraccion = MetodosIngreso.IngresarDecimal("Monto que desea retirar:");
                        funciono = cuenta.Retirar(extraccion);
                        break;
                    case 3:
                        string? mensaje = cuenta.Mostrar();
                        Console.WriteLine(mensaje);
                        break;
                    default:
                        Console.WriteLine("Saliendo del programa uwu");
                        continuar = false;
                        break;
                }
            } while (continuar);

        }
    }
}