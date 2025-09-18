using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IDetallesVentasAplicacion
    {
        void Configurar(string StringConexion);
        List<DetallesVentas> Listar();
        DetallesVentas? Guardar(DetallesVentas? entidad);
        DetallesVentas? Modificar(DetallesVentas? entidad);
        DetallesVentas? Borrar(DetallesVentas? entidad);
    }
}