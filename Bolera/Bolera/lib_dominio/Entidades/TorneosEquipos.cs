using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class TorneosEquipos
    {
        public int IdTorneoEquipo { get; set; }
        public int IdTorneo { get; set; }
        public int IdEquipo { get; set; }

        [ForeignKey("IdTorneo")] public Torneos? _IdTorneo { get; set; }
        [ForeignKey("IdEquipo")] public Equipos? _IdEquipo { get; set; }
    }
}
