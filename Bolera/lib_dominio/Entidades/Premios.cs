using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Premios
    {
        public int IdPremio { get; set; }
        public int IdTorneo { get; set; }
        public int RolEmpleado { get; set; }
        public string? Descripcion { get; set; }
        public decimal Monto { get; set; }
        [ForeignKey("IdTorneo")] public Torneos? _IdTorneo { get; set; }
    }
}
