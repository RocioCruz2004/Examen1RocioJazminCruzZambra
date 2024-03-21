using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.BSS
{
    public class PersonaBss
    {
        PersonaDAL dal = new PersonaDAL();
        public DataTable listarPersonaBss()
        {
            return dal.listarPersonasDal();
        }
        public void insertarPersonasBss(Persona persona)
        { 
            dal.insertarPersonasDal(persona);
        }
        public Persona obtenerIdBss (int id)
        {
            return dal.obtenerPersonaId(id);
        }

        public void editarPersonaBss (Persona p)
        {
            dal.editarPersonaDal(p);
        }
        public void eliminarPersonaBss (int id)
        {
            dal.eliminarPersonaDal(id);
        }
    }
}
