using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Ventas
    {
        public int IdVenta { get; set; }
        public int IdCliente{ get; set; }
        public int IdEmpleado { get; set; }
        public DateTime FechaVenta { get; set; }
        [ForeignKey("IdCliente")] public Clientes? _IdCliente { get; set; }
        [ForeignKey("IdEmpleado")] public Empleados? _IdEmpleado { get; set; }
    }
}
