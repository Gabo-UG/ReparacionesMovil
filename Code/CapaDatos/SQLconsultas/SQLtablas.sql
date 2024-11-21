-- Crear la tabla Cliente
CREATE TABLE Cliente (
    ClienteID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Direccion NVARCHAR(100),
    Telefono NVARCHAR(20),
    Correo NVARCHAR(100)
);

-- Crear la tabla Tecnico
CREATE TABLE Tecnico (
    TecnicoID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Especialidad NVARCHAR(100),
    Telefono NVARCHAR(20),
    Correo NVARCHAR(100)
);

-- Crear la tabla Equipo
CREATE TABLE Equipo (
    EquipoID INT PRIMARY KEY IDENTITY,
    Tipo NVARCHAR(100),
    NumeroSerie NVARCHAR(100),
    FechaIngreso DATE,
    Estado NVARCHAR(50),
    ClienteID INT,
    FOREIGN KEY (ClienteID) REFERENCES Cliente(ClienteID)
);

-- Crear la tabla Repuesto
CREATE TABLE Repuesto (
    RepuestoID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Codigo NVARCHAR(50),
    Precio DECIMAL(18, 2),
    Iva DECIMAL(18, 2),
    Total DECIMAL(18, 2)
);

-- Crear la tabla Servicio
CREATE TABLE Servicio (
    ServicioID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Categoria NVARCHAR(100),
    Codigo NVARCHAR(50),
    Precio DECIMAL(18, 2),
    Iva DECIMAL(18, 2),
    Total DECIMAL(18, 2)
);

-- Crear la tabla Reparacion
CREATE TABLE Reparacion (
    ReparacionID INT PRIMARY KEY IDENTITY,
    ClienteID INT NOT NULL,
    EquipoID INT NOT NULL,
    TecnicoID INT NOT NULL,
    Diagnostico NVARCHAR(MAX),
    FechaIngreso DATE NOT NULL,
    FechaEntrega DATE NULL,
    CostoTotal DECIMAL(10, 2) NULL,
    FOREIGN KEY (ClienteID) REFERENCES Cliente(ClienteID),
    FOREIGN KEY (EquipoID) REFERENCES Equipo(EquipoID),
    FOREIGN KEY (TecnicoID) REFERENCES Tecnico(TecnicoID)
);

-- Crear la tabla ReparacionDetalle
CREATE TABLE ReparacionDetalle (
    ReparacionDetalleID INT PRIMARY KEY IDENTITY(1,1),
    ReparacionID INT NOT NULL,
    Tipo NVARCHAR(50) NOT NULL,
    ItemID INT NOT NULL,
    FOREIGN KEY (ReparacionID) REFERENCES Reparacion(ReparacionID)
);

-- Crear la tabla Usuario
CREATE TABLE Usuario(
    UsuarioID INT PRIMARY KEY IDENTITY(1,1),
    NombreUsuario NVARCHAR(50) NOT NULL,
    Contrasena NVARCHAR(50) NOT NULL
);


