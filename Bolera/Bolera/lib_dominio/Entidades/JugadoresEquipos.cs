using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class JugadoresEquipos
    {
        public int IdDetalle { get; set; }
        public int IdJuego { get; set; }
        public int Frame { get; set; }
        public int Lanzamiento1 { get; set; }
        public int Lanzamiento2 { get; set; }


        [ForeignKey("IdJuego")] public Juegos? _IdJuego { get; set; }
       
    }
}
