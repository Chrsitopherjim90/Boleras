using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lib_repositorios.Implementaciones
{
    public class JugadoresEquiposAplicacion : IEmpleados_JugadoresEquiposAplicacion
    {
        private IConexion? IConexion = null;

        public Empleados_JugadoresEquiposAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public Empleados_JugadoresEquipos? Borrar(Empleados_JugadoresEquipos? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Operaciones
            entidad._Dueño = null;
            entidad._Mascota = null;

            this.IConexion!.Empleados_JugadoresEquipos!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Empleados_JugadoresEquipos? Guardar(Empleados_JugadoresEquipos? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");

            // Operaciones
            entidad._Dueño = null;
            entidad._Mascota = null;

            this.IConexion!.Empleados_JugadoresEquipos!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Empleados_JugadoresEquipos> Listar()
        {
            return this.IConexion!.Empleados_JugadoresEquipos!.Take(20).ToList();
        }

        public Empleados_JugadoresEquipos? Modificar(Empleados_JugadoresEquipos? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Operaciones
            entidad._Dueño = null;
            entidad._Mascota = null;

            var entry = this.IConexion!.Entry<Empleados_JugadoresEquipos>(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }
    }
}
