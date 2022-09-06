using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public class Empleado
    {
        public int antiguedad;
        public int horasTrabajadas;
        public float valorHora;
        public string? nombre;

        public Empleado(int antiguedad, int horasTrabajadas, float valorHora, string? nombre)
        {
            this.antiguedad = antiguedad;
            this.horasTrabajadas = horasTrabajadas;
            this.valorHora = valorHora;
            this.nombre = nombre;
        }
    }
}
