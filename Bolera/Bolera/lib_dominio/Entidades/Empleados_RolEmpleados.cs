using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Empleados_RolEmpleados
    {
        public int Id { get; set; }
        public int Empleado { get; set; }
        public int RolEmpleado { get; set; }

        [ForeignKey("Empleado")] public Empleados? _Empleado { get; set; }
        [ForeignKey("RolEmpleado")] public RolEmpleados? _RolEmpleado { get; set; }
    }
}