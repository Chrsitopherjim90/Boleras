using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IPremiosAplicacion
    {
        void Configurar(string StringConexion);
        List<Premios> Listar();
        Premios? Guardar(Premios? entidad);
        Premios? Modificar(Premios? entidad);
        Premios? Borrar(Premios? entidad);
    }
}