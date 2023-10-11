using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados.BE
{
    public class ListaEmpleados
    {
        public Empleado[] Lista { get; set; } = new Empleado[10];

        int fila = 0;

        public void AgregEmpleado(Empleado nuevo)
        {
            Lista[fila] = nuevo;
            fila = fila + 1;
        }

        public string Listar()
        {
            string respuesta = "";

            foreach (Empleado item in Lista)
            {
                if (item == null)
                {
                    break;
                }
                respuesta = respuesta + item.Listar() + "\r\n";
            }

            return respuesta;
        }

        public Empleado BuscEmpleado(string Nombre)
        {
            Empleado Emp = new Empleado();
            foreach (Empleado item in Lista)
            {
                if (item == null)
                {
                    break;
                }
                if (item.Nombre == Nombre) 
                {
                    Emp = item;
                    break;
                }
            }
            return Emp;
        }
    }
}

