using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Productos
    {
        public int IdProducto { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int IdProveedor { get; set; }
        public string? Nombre { get; set; }
        [ForeignKey("IdProveedor")] public Proveedores? _IdProveedor { get; set; }
    }
}
