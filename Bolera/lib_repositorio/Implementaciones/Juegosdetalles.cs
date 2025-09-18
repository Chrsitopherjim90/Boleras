using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lib_repositorios.Implementaciones
{
    public class JuegosdetallesAplicacion : IEmpleados_JuegosdetallesAplicacion
    {
        private IConexion? IConexion = null;

        public Empleados_JuegosdetallesAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public Empleados_Juegosdetalles? Borrar(Empleados_Juegosdetalles? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Operaciones
            entidad._Dueño = null;
            entidad._Mascota = null;

            this.IConexion!.Empleados_Juegosdetalles!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Empleados_Juegosdetalles? Guardar(Empleados_Juegosdetalles? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");

            // Operaciones
            entidad._Dueño = null;
            entidad._Mascota = null;

            this.IConexion!.Empleados_Juegosdetalles!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Empleados_Juegosdetalles> Listar()
        {
            return this.IConexion!.Empleados_Juegosdetalles!.Take(20).ToList();
        }

        public Empleados_Juegosdetalles? Modificar(Empleados_Juegosdetalles? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Operaciones
            entidad._Dueño = null;
            entidad._Mascota = null;

            var entry = this.IConexion!.Entry<Empleados_Juegosdetalles>(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }
    }
}
