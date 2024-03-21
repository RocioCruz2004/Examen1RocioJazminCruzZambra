using SistemasVentas.BSS;
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
    public partial class EmpleadoListarVista : Form
    {
        public EmpleadoListarVista()
        {
            InitializeComponent();
        }
        empleadoBss bss = new empleadoBss();
        private void button2_Click(object sender, EventArgs e)
        {
            EmpleadoInsertarVista fr = new EmpleadoInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.listarEmpeladoBss();
            }
        }

        private void EmpleadoListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.listarEmpeladoBss();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdEmpleadolSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EmpleadoEditarVista fr = new EmpleadoEditarVista(IdEmpleadolSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.listarEmpeladoBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdEmpleadoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminarlo? ", "Eliminando",
                                            MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.eliminarEmpleadoBss(IdEmpleadoSeleccionado);
                dataGridView1.DataSource = bss.listarEmpeladoBss();
            }
        }
    }
}
