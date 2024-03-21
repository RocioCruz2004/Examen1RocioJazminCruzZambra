using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.DAL;
using SistemasVentas.Modelos;

namespace SistemasVentas.BSS
{
    public class empleadoBss
    {
        empleadoDAL dal = new empleadoDAL();
        public DataTable listarEmpeladoBss()
        {
            return dal.listarEmpleadoDal();
        }
        public void insertarEmpleadoBss(Empleado empleado)
        {
            dal.insertarEmpleadoDal(empleado);
        }

        public Empleado obtenerEmpleadoId (int id)
        {
            return dal.obtenerEmpleadoId(id);
        }

        public void editarEmpleadoBss (Empleado empleado)
        {
            dal.editarEmpleadoDal (empleado);
        }
        public void eliminarEmpleadoBss (int id)
        {
            dal.eliminarEmpleadoDal(id);
        }
    }
}
