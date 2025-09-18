using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib_dominio.Entidades;

namespace ut_presentacion.Nucleo
{
    public class EntidadesNucleo
    {
        public static Empleados? Empleados()
        {
            var entidad = new Empleados();
            entidad.Nombre = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Apellido = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.RolId = 1;
            return entidad;
        }

        public static RolEmpleados? RolEmpleados()
        {
            var entidad = new RolEmpleados();
            entidad.Nombre = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            return entidad;
        }

        public static Reservas? Reservas()
        {
            var entidad = new Reservas();
            entidad.Cliente = 1;
            entidad.Pista = 2;
            entidad.FechaReserva = DateTime.Now;
            return entidad;
        }

        public static Clientes? Clientes()
        {
            var entidad = new Clientes();
            entidad.Nombre = "Prueba-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Apellido = "Demo";
            entidad.Telefono = "3001234567";
            return entidad;
        }

        public static Pistas? Pistas()
        {
            var entidad = new Pistas();
            entidad.NumeroPista = 1;
            entidad.Estado = "Disponible";
            return entidad;
        }

        public static Juegos? Juegos()
        {
            var entidad = new Juegos();
            entidad.IdReserva = 1;
            entidad.FechaJuego = DateTime.Now;
            return entidad;
        }

        public static JuegoDetalles? JuegoDetalles()
        {
            var entidad = new JuegoDetalles();
            entidad.IdJuego = 1;
            entidad.Frame = 1;
            entidad.Lanzamiento1 = 7;
            entidad.Lanzamiento2 = 2;
            return entidad;
        }

        public static Equipos? Equipos()
        {
            var entidad = new Equipos();
            entidad.NombreEquipo = "Equipo-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            return entidad;
        }

        public static JugadoresEquipos? JugadoresEquipos()
        {
            var entidad = new JugadoresEquipos();
            entidad.IdCliente = 1;
            entidad.IdEquipo = 1;
            return entidad;
        }

        public static Torneos? Torneos()
        {
            var entidad = new Torneos();
            entidad.Nombre = "Torneo-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.FechaInicio = DateTime.Now;
            entidad.FechaFin = DateTime.Now.AddDays(3);
            return entidad;
        }

        public static TorneosEquipos? TorneosEquipos()
        {
            var entidad = new TorneosEquipos();
            entidad.IdTorneo = 1;
            entidad.IdEquipo = 1;
            return entidad;
        }

        public static Premios? Premios()
        {
            var entidad = new Premios();
            entidad.IdTorneo = 1;
            entidad.Descripcion = "Premio-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Monto = 500.00m;
            return entidad;
        }

        public static Proveedores? Proveedores()
        {
            var entidad = new Proveedores();
            entidad.Nombre = "Proveedor-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Telefono = "3112345678";
            return entidad;
        }

        public static Productos? Productos()
        {
            var entidad = new Productos();
            entidad.Nombre = "Producto-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Precio = 2500m;
            entidad.Stock = 50;
            entidad.IdProveedor = 1;
            return entidad;
        }

        public static Inventarios? Inventarios()
        {
            var entidad = new Inventarios();
            entidad.IdProducto = 1;
            entidad.IdProveedor = 1;
            entidad.Cantidad = 20;
            entidad.FechaActualizacion = DateTime.Now;
            return entidad;
        }

        public static Ventas? Ventas()
        {
            var entidad = new Ventas();
            entidad.IdCliente = 1;
            entidad.IdEmpleado = 1;
            entidad.FechaVenta = DateTime.Now;
            return entidad;
        }

        public static DetalleVentas? DetalleVentas()
        {
            var entidad = new DetalleVentas();
            entidad.IdVenta = 1;
            entidad.IdProducto = 1;
            entidad.Cantidad = 3;
            entidad.PrecioUnitario = 2000m;
            return entidad;
        }

        public static Facturas? Facturas()
        {
            var entidad = new Facturas();
            entidad.IdReserva = 1;
            entidad.IdPago = 1;
            entidad.Total = 10000m;
            entidad.FechaFactura = DateTime.Now;
            return entidad;
        }

        public static Pagos? Pagos()
        {
            var entidad = new Pagos();
            entidad.Metodo = "Efectivo";
            return entidad;
        }

        public static MantenimientosPistas? MantenimientosPistas()
        {
            var entidad = new MantenimientosPistas();
            entidad.IdPista = 1;
            entidad.IdEmpleado = 1;
            entidad.FechaMantenimiento = DateTime.Now;
            entidad.Descripcion = "Chequeo general";
            return entidad;
        }
    }
}

