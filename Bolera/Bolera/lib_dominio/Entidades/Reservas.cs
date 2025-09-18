using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public int IdCliente { get; set; }
        public int IdPista { get; set; }
        public int idCliente { get; set; }
        public DateTime FechaReserva { get; set; }
        [ForeignKey("IdPista")] public Pistas? _IdPista { get; set; }
        [ForeignKey("IdCliente")] public Clientes? _IdCliente { get; set; }
    }
}
