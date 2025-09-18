using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IJuegosAplicacion
    {
        void Configurar(string StringConexion);
        List<Juegos> Listar();
        Juegos? Guardar(Juegos? entidad);
        Juegos? Modificar(Juegos? entidad);
        Juegos? Borrar(Juegos? entidad);
    }
}