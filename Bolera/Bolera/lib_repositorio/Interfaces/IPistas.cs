using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IPistasAplicacion
    {
        void Configurar(string StringConexion);
        List<Pistas> Listar();
        Pistas? Guardar(Pistas? entidad);
        Pistas? Modificar(Pistas? entidad);
        Pistas? Borrar(Pistas? entidad);
    }
}