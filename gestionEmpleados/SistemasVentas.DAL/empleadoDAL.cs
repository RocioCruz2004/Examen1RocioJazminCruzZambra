using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class empleadoDAL
    {
        public DataTable listarEmpleadoDal()
        {
            string consulta = "SELECT * FROM EMPLEADO";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void insertarEmpleadoDal(Empleado empleado)
        {
            string consulta = "INSERT INTO EMPLEADO VALUES (" + empleado.idPersona + " , " +
                                                            " '" + empleado.puesto + "' , " +
                                                            " " + empleado.salario + " , " +
                                                            " '" + empleado.fechaContratacion + "')";
            Conexion.Ejecutar(consulta);
        }

        public Empleado obtenerEmpleadoId(int id)
        {
            string consulta = "SELECT * FROM EMPLEADO WHERE IDEMPLEADO = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "tabla");
            Empleado empleado = new Empleado();
            if (tabla.Rows.Count > 0)
            {
                empleado.idEmpleado = Convert.ToInt32(tabla.Rows[0]["idempleado"]);
                empleado.idPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                empleado.puesto = tabla.Rows[0]["puesto"].ToString();
                empleado.salario = Convert.ToDecimal( tabla.Rows[0]["salario"]);

            }
            return empleado;
        }

        public void editarEmpleadoDal(Empleado empleado)
        {
            string consulta = "UPDATE EMPLEADO SET idpersona= "+empleado.idPersona+" ," +
                                                  "puesto= '"+empleado.puesto+"' ," +
                                                  "salario= " + empleado.salario + " ," +
                                                  "fechaContratacion= '" + empleado.fechaContratacion + "' " +
                              "WHERE IDEMPLEADO=" + empleado.idEmpleado;
            Conexion.Ejecutar(consulta);
        }
        public void eliminarEmpleadoDal (int id)
        {
            string consulta = "DELETE FROM EMPLEADO WHERE IDEMPLEADO = " + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
