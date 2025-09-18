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
        public DbSet<Clientes>? Clientes { get; set; }
        public DbSet<Empleados>? Empleados { get; set; }
        public DbSet<Empleados_RolEmpleados>? Empleados_RolEmpleados { get; set; }
        public DbSet<Pagos>? Pagos { get; set; }
        public DbSet<RolEmpleados>? RolEmpleados { get; set; }
        public DbSet<Pistas>? Pistas { get; set; }
        public DbSet<Reservas>? Reservas { get; set; }

        public DbSet<Juegos>? Juegos { get; set; }
        public DbSet<JuegosDetalles>? JuegosDetalles { get; set; }

        public DbSet<Equipos>? Equipos { get; set; }
        public DbSet<JugadoresEquipos>? JugadoresEquipos { get; set; }

  
        public DbSet<Torneos>? Torneos { get; set; }
        public DbSet<TorneosEquipos>? TorneosEquipos { get; set; }
        public DbSet<Premios>? Premios { get; set; }

        public DbSet<Proveedores>? Proveedores { get; set; }
        public DbSet<Productos>? Productos { get; set; }
        public DbSet<Inventarios>? Inventarios { get; set; }

        public DbSet<Ventas>? Ventas { get; set; }
        public DbSet<DetallesVentas>? DetallesVentas { get; set; }

        public DbSet<Facturas>? Facturas { get; set; }
    }
}
