using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lib_repositorios.Implementaciones
{
    public class ProveedoresAplicacion : IEmpleados_ProveedoresAplicacion
    {
        private IConexion? IConexion = null;

        public Empleados_ProveedoresAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public Empleados_Proveedores? Borrar(Empleados_Proveedores? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Operaciones
            entidad._Dueño = null;
            entidad._Mascota = null;

            this.IConexion!.Empleados_Proveedores!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Empleados_Proveedores? Guardar(Empleados_Proveedores? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");

            // Operaciones
            entidad._Dueño = null;
            entidad._Mascota = null;

            this.IConexion!.Empleados_Proveedores!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Empleados_Proveedores> Listar()
        {
            return this.IConexion!.Empleados_Proveedores!.Take(20).ToList();
        }

        public Empleados_Proveedores? Modificar(Empleados_Proveedores? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Operaciones
            entidad._Dueño = null;
            entidad._Mascota = null;

            var entry = this.IConexion!.Entry<Empleados_Proveedores>(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }
    }
}
