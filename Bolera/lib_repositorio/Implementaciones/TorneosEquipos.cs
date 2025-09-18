using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lib_repositorios.Implementaciones
{
    public class  TorneosEquiposAplicacion : IEmpleados_ TorneosEquiposAplicacion
    {
        private IConexion? IConexion = null;

        public Empleados_ TorneosEquiposAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public Empleados_ TorneosEquipos? Borrar(Empleados_ TorneosEquipos? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Operaciones
            entidad._Dueño = null;
            entidad._Mascota = null;

            this.IConexion!.Empleados_ TorneosEquipos!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Empleados_ TorneosEquipos? Guardar(Empleados_ TorneosEquipos? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");

            // Operaciones
            entidad._Dueño = null;
            entidad._Mascota = null;

            this.IConexion!.Empleados_ TorneosEquipos!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Empleados_ TorneosEquipos> Listar()
        {
            return this.IConexion!.Empleados_ TorneosEquipos!.Take(20).ToList();
        }

        public Empleados_ TorneosEquipos? Modificar(Empleados_ TorneosEquipos? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Operaciones
            entidad._Dueño = null;
            entidad._Mascota = null;

            var entry = this.IConexion!.Entry<Empleados_ TorneosEquipos>(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }
    }
}
