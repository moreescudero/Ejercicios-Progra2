using Biblioteca;
using System;
using System.Collections.Generic;

namespace EjercicioClase5_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar;
            int llave;
            Dictionary<int, Producto> maquinaExpendedora = new Dictionary<int, Producto>();
            Stack<Producto> papasFritas = new Stack<Producto>();
            Stack<Producto> alfajores = new Stack<Producto>();
            Stack<Producto> chicles = new Stack<Producto>();

            float num = MetodosIngreso.IngresarFloat("dame un num owo", 10, 0);

            maquinaExpendedora.Add(1, new Producto("Coca Cola", 100));
            maquinaExpendedora.Add(2, new Producto("Pepsi", 90));
            maquinaExpendedora.Add(3, new Producto("7 Up", 85));
            maquinaExpendedora.Add(4, new Producto("Sprite", 90));
            maquinaExpendedora.Add(5, new Producto("Fanta", 99));
            maquinaExpendedora.Add(6, new Producto("Mirinda", 90));
            maquinaExpendedora.Add(7, new Producto("Brahma", 110));
            maquinaExpendedora.Add(8, new Producto("Heineken", 120));
            maquinaExpendedora.Add(9, new Producto("Manaos", 85));
            maquinaExpendedora.Add(10, new Producto("Corona", 150));

            do
            {
                foreach (KeyValuePair<int, Producto> item in maquinaExpendedora)
                {
                    Console.WriteLine("{0} - {1} - ${2}", item.Key, item.Value.Nombre, item.Value.Precio);
                }
                Console.WriteLine("Ingrese el numero de la bebida que desea comprar: ");
                string? numeroIngresado = Console.ReadLine();
                bool esNumerica = int.TryParse(numeroIngresado, out llave);

                if(esNumerica)
                {
                    Console.WriteLine(maquinaExpendedora[llave].Nombre);
                    maquinaExpendedora.Remove(llave);

                    Console.WriteLine("¿Desea sacar otra bebida? (S/N)");
                    string? respuesta = Console.ReadLine();
                    if (respuesta == "S" || respuesta == "s")
                    {
                        continuar = true;
                    }
                    else
                    {
                        continuar = false;
                    }
                }
                else
                {
                    Console.WriteLine("Error!");
                    continuar = false;
                }

            } while (continuar);
        }
    }
}