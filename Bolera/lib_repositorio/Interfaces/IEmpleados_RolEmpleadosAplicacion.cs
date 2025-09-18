using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IEmpleados_RolEmpleadosAplicacion
    {
        void Configurar(string StringConexion);
        List<Empleados_RolEmpleados> Listar();
        Empleados_RolEmpleados? Guardar(Empleados_RolEmpleados? entidad);
        Empleados_RolEmpleados? Modificar(Empleados_RolEmpleados? entidad);
        Empleados_RolEmpleados? Borrar(Empleados_RolEmpleados? entidad);
    }
}