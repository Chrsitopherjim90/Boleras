using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IJuegosdetallesAplicacion
    {
        void Configurar(string StringConexion);
        List<Juegosdetalles> Listar();
        Juegosdetalles? Guardar(Juegosdetalles? entidad);
        Juegosdetalles? Modificar(Juegosdetalles? entidad);
        Juegosdetalles? Borrar(Juegosdetalles? entidad);
    }
}