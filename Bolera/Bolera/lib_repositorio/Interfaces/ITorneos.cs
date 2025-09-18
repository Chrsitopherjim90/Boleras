using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface ITorneosAplicacion
    {
        void Configurar(string StringConexion);
        List<Torneos> Listar();
        Torneos? Guardar(Torneos? entidad);
        Torneos? Modificar(Torneos? entidad);
        Torneos? Borrar(Torneos? entidad);
    }
}