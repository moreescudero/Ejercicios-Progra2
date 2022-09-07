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
            Dictionary<int, Stack<Producto>> maquinaExpendedora = new Dictionary<int, Stack<Producto>>();
            Stack<Producto> papasFritas = new Stack<Producto>();
            Stack<Producto> alfajores = new Stack<Producto>();
            Stack<Producto> chicles = new Stack<Producto>();

            papasFritas.Push(new Producto("Papitas", 200));
            papasFritas.Push(new Producto("Papitas", 200));
            papasFritas.Push(new Producto("Papitas", 200));
            papasFritas.Push(new Producto("Papitas", 200));

            alfajores.Push(new Producto("Alfajor", 200));
            alfajores.Push(new Producto("Alfajor", 200));
            alfajores.Push(new Producto("Alfajor", 200));
            alfajores.Push(new Producto("Alfajor", 200));
        
            chicles.Push(new Producto("Chicle", 100));
            chicles.Push(new Producto("Chicle", 100));
            chicles.Push(new Producto("Chicle", 100));
            chicles.Push(new Producto("Chicle", 100));


            maquinaExpendedora.Add(1, papasFritas);
            maquinaExpendedora.Add(2, alfajores);
            maquinaExpendedora.Add(3, chicles);

            do
            {
                foreach (KeyValuePair<int, Stack<Producto>> item in maquinaExpendedora)
                {
                    Console.WriteLine("{0} - {1} - ${2} - {3}", item.Key, item.Value.Peek().Nombre, item.Value.Peek().Precio, item.Value.Count);
                }

                llave = MetodosIngreso.IngresarInt("Ingrese el numero del producto que desea comprar:", 4, 0);
                
                if (maquinaExpendedora[llave].Count > 0)
                {
                    Console.WriteLine(maquinaExpendedora[llave].Peek().Nombre);
                    maquinaExpendedora[llave].Pop();

                    string? respuesta = MetodosIngreso.IngresarString("¿Desea sacar otra producto? (S/N)");

                    if (respuesta == "S" || respuesta == "s")
                    {   
                        if(maquinaExpendedora[llave].Count == 0)
                        {
                            maquinaExpendedora.Remove(llave);
                        }
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