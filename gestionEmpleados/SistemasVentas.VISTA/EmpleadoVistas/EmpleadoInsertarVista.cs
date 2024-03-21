using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionEmpleados.VISTA.EmpleadoVistas
{
    public partial class EmpleadoInsertarVista : Form
    {
        public EmpleadoInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdUsuarioSeleccionado = 0;
        empleadoBss bss = new empleadoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            EmpleadoListarVista usv = new EmpleadoListarVista();
            if (usv.ShowDialog() == DialogResult.OK)
            {
                Empleado empleado = bss.obtenerEmpleadoId(IdUsuarioSeleccionado);
                textBox1.Text = empleado.idPersona.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Empleado ur = new Empleado();
            ur.idEmpleado = IdUsuarioSeleccionado;
            ur.puesto = textBox1.Text;
            ur.salario = Convert.ToDecimal(textBox2.Text);
            ur.fechaContratacion= dateTimePicker1.Value;

            bss.insertarEmpleadoBss(ur);
            MessageBox.Show("Se guardo correctamente!");
        }
    }
}
