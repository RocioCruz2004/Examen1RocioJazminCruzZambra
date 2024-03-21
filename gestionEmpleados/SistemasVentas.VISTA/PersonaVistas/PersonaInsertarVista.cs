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

namespace SistemasVentas.VISTA.PersonaVistas
{
    public partial class PersonaInsertarVista : Form
    {
        public PersonaInsertarVista()
        {
            InitializeComponent();
        }

        private void PersonaInsertarVista_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        PersonaBss bss = new PersonaBss();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.nombre=textBox1.Text;
            p.apellido=textBox2.Text;

            bss.insertarPersonasBss(p);
            MessageBox.Show("Se guardó correctamente la persona");
        }
    }
}
