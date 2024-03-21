using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionEmpleados.MODELOS
{
    public class empleado
    {
        public int idEmpleado {  get; set; }
        public int idPersona { get; set; }
        public string puesto { get; set; }
        public decimal salario { get; set;}
        public DateTime fechaContratacion { get; set; }
    }
}
