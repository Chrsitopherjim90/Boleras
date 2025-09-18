using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib_dominio.Entidades;

namespace ut_presentacion.Nucleo
{
    public class EntidadesNucleo
    {
        public static Empleados? Empleados()
        {
            var entidad = new Empleados();
            entidad.Nombre = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Apellido = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");

            return entidad;
        }

        public static RolEmpleados? RolEmpleados()
        {
            var entidad = new RolEmpleados();
            entidad.Nombre = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");

            return entidad;
        }

        public static Reservas? Reservas()
        {
            var entidad = new Reservas();
            entidad.Cliente = 1;
            entidad.Pista = 2;
            entidad.FechaReserva = "Pruebas"+ DateTime.Now.ToString("yyyyMMddhhmmss");
            

            return entidad;
        }
    }
}
