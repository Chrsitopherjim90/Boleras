using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Juegos
    {
        public int IdJuego { get; set; }
        public int IdReserva { get; set; }
        public DateTime FechaJuego { get; set; }
        [ForeignKey("IdReserva")] public Reservas? _IdReservas { get; set; }
    }
}
