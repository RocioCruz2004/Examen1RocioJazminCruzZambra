using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class PersonaDAL
    {
        public DataTable listarPersonasDal()
        {
            string consulta = "SELECT * FROM PERSONA";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void insertarPersonasDal(Persona persona )
        {
            string consulta = "INSERT INTO PERSONA VALUES('"+persona.nombre+"',"+
                                                            "'" + persona.apellido+"', "+
                                                            "'Activo')";
            Conexion.Ejecutar(consulta);
                                                            
        }

        public Persona obtenerPersonaId(int id)
        {
            string consulta = "SELECT * FROM PERSONA WHERE IDPERSONA=" + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "tabla");
            Persona persona = new Persona();
            if (tabla.Rows.Count > 0)
            {
                persona.idPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                persona.nombre = tabla.Rows[0]["nombre"].ToString();
                persona.apellido = tabla.Rows[0]["apellido"].ToString();
                persona.estado = tabla.Rows[0]["estado"].ToString();
            }
            return persona;
        }

        public void editarPersonaDal (Persona p)
        {
            string consulta = "UPDATE PERSONA SET nombre='" + p.nombre + "' ," +
                                                         "apellido= '" + p.apellido + "' " +
                                "WHERE IDPERSONA=" + p.idPersona;
            Conexion.Ejecutar(consulta);
        }

        public void eliminarPersonaDal(int id)
        {
            string consulta = "DELETE FROM PERSONA WHERE IDPERSONA=" + id;
            Conexion.Ejecutar (consulta);
        }
    }
}
