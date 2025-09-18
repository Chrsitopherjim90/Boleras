using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IJugadoresEquiposAplicacion
    {
        void Configurar(string StringConexion);
        List<JugadoresEquipos> Listar();
        JugadoresEquipos? Guardar(JugadoresEquipos? entidad);
        JugadoresEquipos? Modificar(JugadoresEquipos? entidad);
        JugadoresEquipos? Borrar(JugadoresEquipos? entidad);
    }
}