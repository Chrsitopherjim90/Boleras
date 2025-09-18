using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lib_repositorios.Implementaciones
{
    public class PistasAplicacion : IEmpleados_PistasAplicacion
    {
        private IConexion? IConexion = null;

        public Empleados_PistasAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public Empleados_Pistas? Borrar(Empleados_Pistas? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Operaciones
            entidad._Dueño = null;
            entidad._Mascota = null;

            this.IConexion!.Empleados_Pistas!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Empleados_Pistas? Guardar(Empleados_Pistas? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");

            // Operaciones
            entidad._Dueño = null;
            entidad._Mascota = null;

            this.IConexion!.Empleados_Pistas!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Empleados_Pistas> Listar()
        {
            return this.IConexion!.Empleados_Pistas!.Take(20).ToList();
        }

        public Empleados_Pistas? Modificar(Empleados_Pistas? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");

            // Operaciones
            entidad._Dueño = null;
            entidad._Mascota = null;

            var entry = this.IConexion!.Entry<Empleados_Pistas>(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }
    }
}
