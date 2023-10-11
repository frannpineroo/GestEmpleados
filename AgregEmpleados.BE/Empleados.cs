using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgregEmpleados.BE
{
    public class Empleados
    {
        public string Nombre { get; set; }
        public decimal Edad { get; set; }
        public decimal Salario { get; set; }
        
        public string Agregar()
        {
            string respuesta = Nombre
                               + " - "
                               + Edad
                               + " - "
                               + Salario.ToString();
            return respuesta;
        }
    }
}
