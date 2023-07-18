using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Abstraccion
{
    public class Diseniador : Empleado
    {
        public override decimal CalcularSalario()
        {
           
            decimal resultado = Salario + (Salario * 1/100 *Antiguedad);
            return resultado;
        }
    }
}
