using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IRolEmpleadosAplicacion
    {
        void Configurar(string StringConexion);
        List<RolEmpleados> Listar();
        RolEmpleados? Guardar(RolEmpleados? entidad);
        RolEmpleados? Modificar(RolEmpleados? entidad);
        RolEmpleados? Borrar(RolEmpleados? entidad);
    }
}
