using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Inventarios
    {
        public int IdInventario { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public int IdProveedor{ get; set; }
        public DateTime FechaActualizacion { get; set; }
        [ForeignKey("IdProducto")] public Productos? _IdProducto { get; set; }
        [ForeignKey("IdProveedor")] public Proveedores? _IdProveedor { get; set; }
    }
}
