-- Crear la base de datos
CREATE DATABASE db_boleras;
GO
USE db_boleras;
GO

-- Tabla de roles de empleados
CREATE TABLE RolEmpleados (
    IdRol INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50) NOT NULL
);

-- Métodos de pago
CREATE TABLE Pagos (
    IdPago INT PRIMARY KEY IDENTITY(1,1),
    Metodo NVARCHAR(50) NOT NULL
);

-- Empleados
CREATE TABLE Empleados (
    IdEmpleado INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    RolId INT NOT NULL,
    FOREIGN KEY (RolId) REFERENCES RolEmpleados(IdRol)
);

-- Clientes
CREATE TABLE Clientes (
    IdCliente INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    Telefono NVARCHAR(20),
    Correo NVARCHAR(100)
);

-- Pistas de bolos
CREATE TABLE Pistas (
    IdPista INT PRIMARY KEY IDENTITY(1,1),
    NumeroPista INT NOT NULL,
    Estado NVARCHAR(20) NOT NULL
);

-- Reservas
CREATE TABLE Reservas (
    IdReserva INT PRIMARY KEY IDENTITY(1,1),
    IdCliente INT NOT NULL,
    IdPista INT NOT NULL,
    FechaReserva DATETIME NOT NULL,
    FOREIGN KEY (IdCliente) REFERENCES Clientes(IdCliente),
    FOREIGN KEY (IdPista) REFERENCES Pistas(IdPista)
);

-- Juegos
CREATE TABLE Juegos (
    IdJuego INT PRIMARY KEY IDENTITY(1,1),
    IdReserva INT NOT NULL,
    FechaJuego DATETIME NOT NULL,
    FOREIGN KEY (IdReserva) REFERENCES Reservas(IdReserva)
);

-- Detalles de juegos
CREATE TABLE JuegosDetalles (
    IdDetalle INT PRIMARY KEY IDENTITY(1,1),
    IdJuego INT NOT NULL,
    Frame INT NOT NULL,
    Lanzamiento1 INT,
    Lanzamiento2 INT,
    FOREIGN KEY (IdJuego) REFERENCES Juegos(IdJuego)
);

-- Equipos
CREATE TABLE Equipos (
    IdEquipo INT PRIMARY KEY IDENTITY(1,1),
    NombreEquipo NVARCHAR(100) NOT NULL
);

-- Relación Jugadores - Equipos
CREATE TABLE JugadoresEquipos (
    IdJugadorEquipo INT PRIMARY KEY IDENTITY(1,1),
    IdCliente INT NOT NULL,
    IdEquipo INT NOT NULL,
    FOREIGN KEY (IdCliente) REFERENCES Clientes(IdCliente),
    FOREIGN KEY (IdEquipo) REFERENCES Equipos(IdEquipo)
);

-- Torneos
CREATE TABLE Torneos (
    IdTorneo INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    FechaInicio DATE,
    FechaFin DATE
);

-- Relación Torneos - Equipos
CREATE TABLE TorneosEquipos (
    IdTorneoEquipo INT PRIMARY KEY IDENTITY(1,1),
    IdTorneo INT NOT NULL,
    IdEquipo INT NOT NULL,
    FOREIGN KEY (IdTorneo) REFERENCES Torneos(IdTorneo),
    FOREIGN KEY (IdEquipo) REFERENCES Equipos(IdEquipo)
);

-- Premios (se mueve aquí porque depende de Torneos)
CREATE TABLE Premios (
    IdPremio INT PRIMARY KEY IDENTITY(1,1),
    IdTorneo INT NOT NULL,
    Descripcion NVARCHAR(200),
    Monto DECIMAL(10,2),
    FOREIGN KEY (IdTorneo) REFERENCES Torneos(IdTorneo)
);

-- Proveedores
CREATE TABLE Proveedores (
    IdProveedor INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Telefono NVARCHAR(20)
);

-- Productos
CREATE TABLE Productos (
    IdProducto INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Stock INT NOT NULL,
    IdProveedor INT NOT NULL,
    FOREIGN KEY (IdProveedor) REFERENCES Proveedores(IdProveedor)
);

-- Inventarios
CREATE TABLE Inventarios (
    IdInventario INT PRIMARY KEY IDENTITY(1,1),
    IdProducto INT NOT NULL,
    Cantidad INT NOT NULL,
    FechaActualizacion DATETIME NOT NULL,
    IdProveedor INT NOT NULL,
    FOREIGN KEY (IdProducto) REFERENCES Productos(IdProducto),
    FOREIGN KEY (IdProveedor) REFERENCES Proveedores(IdProveedor)
);

-- Ventas
CREATE TABLE Ventas (
    IdVenta INT PRIMARY KEY IDENTITY(1,1),
    IdCliente INT NOT NULL,
    IdEmpleado INT NOT NULL,
    FechaVenta DATETIME NOT NULL,
    FOREIGN KEY (IdCliente) REFERENCES Clientes(IdCliente),
    FOREIGN KEY (IdEmpleado) REFERENCES Empleados(IdEmpleado)
);

-- Detalles de ventas
CREATE TABLE DetallesVentas (
    IdDetalleVenta INT PRIMARY KEY IDENTITY(1,1),
    IdVenta INT NOT NULL,
    IdProducto INT NOT NULL,
    Cantidad INT NOT NULL,
    PrecioUnitario DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (IdVenta) REFERENCES Ventas(IdVenta),
    FOREIGN KEY (IdProducto) REFERENCES Productos(IdProducto)
);

-- Facturas
CREATE TABLE Facturas (
    IdFactura INT PRIMARY KEY IDENTITY(1,1),
    IdReserva INT NULL,
    IdVenta INT NULL,
    IdPago INT NOT NULL,
    Total DECIMAL(10,2) NOT NULL,
    FechaFactura DATETIME NOT NULL,
    FOREIGN KEY (IdReserva) REFERENCES Reservas(IdReserva),
    FOREIGN KEY (IdVenta) REFERENCES Ventas(IdVenta),
    FOREIGN KEY (IdPago) REFERENCES Pagos(IdPago)
);