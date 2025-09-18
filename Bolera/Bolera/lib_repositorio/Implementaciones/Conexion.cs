using lib_dominio.Entidades;
using lib_repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lib_repositorios.Implementaciones
{
    public partial class Conexion : DbContext, IConexion
    {
        public string? StringConexion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConexion!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Clientes>? Clientes { get; set; }
        public DbSet<Empleados>? Empleados{ get; set; }
        public DbSet<Empleados_RolEmpleados>? Empleados_RolEmpleados { get; set; }
        public DbSet<Pagos>? Pagos { get; set; }
        public DbSet<RolEmpleados? RolEmpleados { get; set; }
    }
}
