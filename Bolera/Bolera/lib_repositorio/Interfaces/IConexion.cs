using lib_dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace lib_repositorios.Interfaces
{
    public interface IConexion
    {
        string? StringConexion { get; set; }

        DbSet<Clientes>? Clientes { get; set; }
        DbSet<Empleados>? Empleados{ get; set; }
        DbSet<Pagos>? Pagos { get; set; }
        DbSet<Pistas>? Pistas { get; set; }
        DbSet<Reservas>? Reservas { get; set; }
        DbSet<RolEmpleados>? RolEmpleados { get; set; }
        DbSet<Empleados_RolEmpleados>? Empleados_RolEmpleados { get; set; }
        DbSet<JuegosDetalles>? JuegosDetalles { get; set; }
        DbSet<Juegos>? Juegos { get; set; }
        DbSet<Equipos>? Equipos { get; set; }
        DbSet<JugadoresEquipos>? JugadoresEquipos { get; set; }
        DbSet<Torneos>? Torneos { get; set; }
        DbSet<TorneosEquipos>? TorneosEquipos { get; set; }
        DbSet<Premios>? Premios { get; set; }
        DbSet<Proveedores>? Proveedores { get; set; }
        DbSet<Productos>? Productos { get; set; }
        DbSet<Inventarios>? Inventarios { get; set; }
        DbSet<Ventas>? Ventas { get; set; }
        DbSet<DetallesVentas>? DetallesVentas { get; set; }
        DbSet<Facturas>? Facturas { get; set; }


        DbSet<Empleados_RolEmpleados>? Empleados_RolEmpleados { get; set; }
        DbSet<Empleados_RolEmpleados>? Empleados_RolEmpleados { get; set; }
        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }
}