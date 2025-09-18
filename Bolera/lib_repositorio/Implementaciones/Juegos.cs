using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lib_repositorios.Implementaciones
{
    public class JuegosAplicacion : IEmpleados_JuegosAplicacion
    {
        private IConexion? IConexion = null;

        public Empleados_JuegosAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public Empleados_Juegos? Borrar(Empleados_Juegos? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Operaciones
            entidad._Dueño = null;
            entidad._Mascota = null;

            this.IConexion!.Empleados_Juegos!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Empleados_Juegos? Guardar(Empleados_Juegos? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");

            // Operaciones
            entidad._Dueño = null;
            entidad._Mascota = null;

            this.IConexion!.Empleados_Juegos!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Empleados_Juegos> Listar()
        {
            return this.IConexion!.Empleados_Juegos!.Take(20).ToList();
        }

        public Empleados_Juegos? Modificar(Empleados_Juegos? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Operaciones
            entidad._Dueño = null;
            entidad._Mascota = null;

            var entry = this.IConexion!.Entry<Empleados_Juegos>(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }
    }
}
