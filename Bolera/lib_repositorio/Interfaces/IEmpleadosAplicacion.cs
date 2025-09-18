using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IEmpleadossAplicacion
    {
        void Configurar(string StringConexion);
        List<Empleadoss> Listar();
        Empleadoss? Guardar(Empleadoss? entidad);
        Empleadoss? Modificar(Empleadoss? entidad);
        Empleadoss? Borrar(Empleadoss? entidad);
    }
}