using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVistas;
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
    public partial class EmpleadoEditarVista : Form
    {
        Empleado empleado = new Empleado();
        empleadoBss bss = new empleadoBss();
        int idx = 0;
        public EmpleadoEditarVista(int id)
        {
            InitializeComponent();
            idx = id;
        }
        public static int IdEmpleadoSeleccionada = 0;
        empleadoBss bsse = new empleadoBss();

        private void button1_Click(object sender, EventArgs e)
        {
            PersonaListarVista ulv = new PersonaListarVista();
            if (ulv.ShowDialog() == DialogResult.OK)
            {
                Empleado empleado = bsse.obtenerEmpleadoId(IdEmpleadoSeleccionada);
                textBox1.Text = empleado.idEmpleado.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            empleado.idEmpleado = IdEmpleadoSeleccionada;
            empleado.puesto = textBox2.Text;
            empleado.salario = Convert.ToDecimal(textBox3.Text);
            empleado.fechaContratacion = dateTimePicker1.Value;

            bsse.editarEmpleadoBss(empleado);
            MessageBox.Show("Se editó correctamente!");
        }

        private void EmpleadoEditarVista_Load(object sender, EventArgs e)
        {
            empleado = bsse.obtenerEmpleadoId(idx);
            textBox1.Text = empleado.idEmpleado.ToString();
            textBox2.Text = empleado.puesto;
            textBox3.Text = empleado.salario.ToString();
            dateTimePicker1.Value = empleado.fechaContratacion;
        }
    }
}
