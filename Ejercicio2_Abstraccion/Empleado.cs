using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Abstraccion
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }

        public int Antiguedad { get; set; }

        public decimal Salario { get; set; }



        public abstract decimal CalcularSalario();
    }
}
