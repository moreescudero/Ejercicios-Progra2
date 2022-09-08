using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona
    {
        string? nombre;
        DateTime fechaDeNacimiento;
        int dni;

        public Persona(string? nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string Nombre
        {
            get { return nombre;  }
            set { nombre = value; }
        }

        public DateTime FechaDeNacimiento
        {
            get { return fechaDeNacimiento; }
            set { fechaDeNacimiento = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        private int CalcularEdad()
        {
            DateTime ahora = DateTime.Now;
            return (ahora - FechaDeNacimiento).Days / 365; ;
        }

        private string EsMayorDeEdad(int edad)
        {
            if(edad >= 18)
            {
                return "Es mayor de edad";
            }
            return "Es menor de edad";
        }

        public string Mostrar()
        {
            int edad = CalcularEdad();
            string? mensaje = "Nombre: " + Nombre + "\nFecha nacimiento: " + FechaDeNacimiento.ToString("d") + "\nDNI: " + Dni + "\nEdad: " + edad + "\n" + EsMayorDeEdad(edad);

            return mensaje;
        }
    }
}
