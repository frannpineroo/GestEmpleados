using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empleados.BE;

namespace AgregEmpleados
{
    public partial class Form1 : Form
    {
        ListaEmpleados lista = new ListaEmpleados();
        public Form1()
        {
            InitializeComponent();
        }

        public void buttAgregar_Click(object sender, EventArgs e)
        {
            //instanciar objeto empleado de la clase Empleado
            Empleado empleado;

            //inicializar el objeto empleado
            empleado = new Empleado();

            empleado.Nombre = txtNombre.Text;
            empleado.Edad = Convert.ToDecimal (txtEdad.Text);
            empleado.Salario = Convert.ToDecimal (txtSalario.Text);

            lista.AgregEmpleado(empleado);

            lblListado.Text = lista.Listar();
        }

        private void buttBuscar_Click(object sender, EventArgs e)
        {
            Empleado empleado = lista.BuscEmpleado(txtNombre.Text);
            lblListado.Text = empleado.Listar();
        }
    }
}
