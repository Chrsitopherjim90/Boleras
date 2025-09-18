using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface ITorneosEquiposAplicacion
    {
        void Configurar(string StringConexion);
        List<TorneosEquipos> Listar();
        TorneosEquipos? Guardar(TorneosEquipos? entidad);
        TorneosEquipos? Modificar(TorneosEquipos? entidad);
        TorneosEquipos? Borrar(TorneosEquipos? entidad);
    }
}