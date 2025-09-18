using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class DetalleVentas
    {
        public int IdDetalleVenta { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        [ForeignKey("IdVenta")] public Ventas? _IdVenta { get; set; }
        [ForeignKey("IdProducto")] public Productos? _IdProducto { get; set; }
    }
}
