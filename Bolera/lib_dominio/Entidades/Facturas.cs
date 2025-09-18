using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Facturas
    {
        public int IdFactura { get; set; }
        public int IdReserva { get; set; }
        public int IdVenta { get; set; }
        public int IdPago { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaFactura { get; set; }
        [ForeignKey("IdReserva")] public Reservas? _IdReserva { get; set; }
        [ForeignKey("IdVenta")] public Ventas? _IdVenta { get; set; }
        [ForeignKey("IdPago")] public Pagos? _IdPago { get; set; }
    }
}
