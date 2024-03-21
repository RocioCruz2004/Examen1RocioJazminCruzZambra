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
    public partial class PersonaEditarVista : Form
    {
        //inyeccion de dependencias: pasar los objetos que quiero editar
        Persona p = new Persona();
        PersonaBss bss = new PersonaBss();
        int idx = 0;
        public PersonaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void PersonaEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.obtenerIdBss(idx);
            textBox1.Text = p.nombre;
            textBox2.Text = p.apellido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            p.nombre = textBox1.Text;
            p.apellido = textBox2.Text;

            bss.editarPersonaBss(p);
            MessageBox.Show("Se guardó correctamente!");
        }
    }
}
