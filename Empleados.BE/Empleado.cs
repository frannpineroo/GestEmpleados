using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados.BE
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public decimal Edad { get; set;}
        public decimal Salario { get; set; }

        // metodo para listar empleados
        public string Listar()
        {
            string respuesta = Nombre 
                               + " - " 
                               + Edad.ToString() 
                               + " - " 
                               + "$"
                               + Salario.ToString();
            return respuesta;
        }

    }
}
