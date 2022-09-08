using Biblioteca;

namespace Ejercicio3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Vos cuantas primaveras tenes?");

            Persona primerPersona = new Persona("Morena", new DateTime(2001,6,15), 9999999);
            Persona segundaPersona = new Persona("Matias", new DateTime(1998, 11, 10), 1010101);
            Persona tercerPersona = new Persona("Mishka", new DateTime(2016, 11, 30), 3333333);

            Persona[] personas = { primerPersona, segundaPersona, tercerPersona };

            foreach(Persona persona in personas)
            {
                Console.WriteLine(persona.Mostrar() + "\n");
            }
        }
    }
}