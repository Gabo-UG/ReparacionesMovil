-- Procedimientos para la tabla Cliente

-- Insertar Cliente
CREATE PROCEDURE InsertarCliente
    @Nombre NVARCHAR(100),
    @Direccion NVARCHAR(100),
    @Telefono NVARCHAR(20),
    @Correo NVARCHAR(100)
AS
BEGIN
    INSERT INTO Cliente (Nombre, Direccion, Telefono, Correo)
    VALUES (@Nombre, @Direccion, @Telefono, @Correo);
END
GO

-- Actualizar Cliente
CREATE PROCEDURE ActualizarCliente
    @ClienteID INT,
    @Nombre NVARCHAR(100),
    @Direccion NVARCHAR(100),
    @Telefono NVARCHAR(20),
    @Correo NVARCHAR(100)
AS
BEGIN
    UPDATE Cliente
    SET Nombre = @Nombre, Direccion = @Direccion, Telefono = @Telefono, Correo = @Correo
    WHERE ClienteID = @ClienteID;
END
GO

-- Eliminar Cliente
CREATE PROCEDURE EliminarCliente
    @ClienteID INT
AS
BEGIN
    DELETE FROM Cliente
    WHERE ClienteID = @ClienteID;
END
GO

-- Seleccionar todos los Clientes
CREATE PROCEDURE SeleccionarClientes
AS
BEGIN
    SELECT * FROM Cliente;
END
GO

-- Seleccionar Cliente por ID
CREATE PROCEDURE SeleccionarClientePorID
    @ClienteID INT
AS
BEGIN
    SELECT * FROM Cliente
    WHERE ClienteID = @ClienteID;
END
GO

-- Procedimientos para la tabla Tecnico

-- Insertar Tecnico
CREATE PROCEDURE InsertarTecnico
    @Nombre NVARCHAR(100),
    @Especialidad NVARCHAR(100),
    @Telefono NVARCHAR(20),
    @Correo NVARCHAR(100)
AS
BEGIN
    INSERT INTO Tecnico (Nombre, Especialidad, Telefono, Correo)
    VALUES (@Nombre, @Especialidad, @Telefono, @Correo);
END
GO

-- Actualizar Tecnico
CREATE PROCEDURE ActualizarTecnico
    @TecnicoID INT,
    @Nombre NVARCHAR(100),
    @Especialidad NVARCHAR(100),
    @Telefono NVARCHAR(20),
    @Correo NVARCHAR(100)
AS
BEGIN
    UPDATE Tecnico
    SET Nombre = @Nombre, Especialidad = @Especialidad, Telefono = @Telefono, Correo = @Correo
    WHERE TecnicoID = @TecnicoID;
END
GO

-- Eliminar Tecnico
CREATE PROCEDURE EliminarTecnico
    @TecnicoID INT
AS
BEGIN
    DELETE FROM Tecnico
    WHERE TecnicoID = @TecnicoID;
END
GO

-- Seleccionar todos los Tecnicos
CREATE PROCEDURE SeleccionarTecnicos
AS
BEGIN
    SELECT * FROM Tecnico;
END
GO

-- Seleccionar Tecnico por ID
CREATE PROCEDURE SeleccionarTecnicoPorID
    @TecnicoID INT
AS
BEGIN
    SELECT * FROM Tecnico
    WHERE TecnicoID = @TecnicoID;
END
GO

-- Procedimientos para la tabla Equipo

-- Insertar Equipo
CREATE PROCEDURE InsertarEquipo
    @Tipo NVARCHAR(100),
    @NumeroSerie NVARCHAR(100),
    @FechaIngreso DATE,
    @Estado NVARCHAR(50),
    @ClienteID INT
AS
BEGIN
    INSERT INTO Equipo (Tipo, NumeroSerie, FechaIngreso, Estado, ClienteID)
    VALUES (@Tipo, @NumeroSerie, @FechaIngreso, @Estado, @ClienteID);
END
GO

-- Actualizar Equipo
CREATE PROCEDURE ActualizarEquipo
    @EquipoID INT,
    @Tipo NVARCHAR(100),
    @NumeroSerie NVARCHAR(100),
    @FechaIngreso DATE,
    @Estado NVARCHAR(50),
    @ClienteID INT
AS
BEGIN
    UPDATE Equipo
    SET Tipo = @Tipo, NumeroSerie = @NumeroSerie, FechaIngreso = @FechaIngreso, Estado = @Estado, ClienteID = @ClienteID
    WHERE EquipoID = @EquipoID;
END
GO

-- Eliminar Equipo
CREATE PROCEDURE EliminarEquipo
    @EquipoID INT
AS
BEGIN
    DELETE FROM Equipo
    WHERE EquipoID = @EquipoID;
END
GO

-- Seleccionar todos los Equipos
CREATE PROCEDURE SeleccionarEquipos
AS
BEGIN
    SELECT * FROM Equipo;
END
GO

-- Seleccionar Equipo por ID
CREATE PROCEDURE SeleccionarEquipoPorID
    @EquipoID INT
AS
BEGIN
    SELECT * FROM Equipo
    WHERE EquipoID = @EquipoID;
END
GO

-- Procedimientos para la tabla Repuesto

-- Insertar Repuesto
CREATE PROCEDURE InsertarRepuesto
    @Nombre NVARCHAR(100),
    @Codigo NVARCHAR(50),
    @Precio DECIMAL(18, 2),
    @Iva DECIMAL(18, 2),
    @Total DECIMAL(18, 2)
AS
BEGIN
    INSERT INTO Repuesto (Nombre, Codigo, Precio, Iva, Total)
    VALUES (@Nombre, @Codigo, @Precio, @Iva, @Total);
END
GO

-- Actualizar Repuesto
CREATE PROCEDURE ActualizarRepuesto
    @RepuestoID INT,
    @Nombre NVARCHAR(100),
    @Codigo NVARCHAR(50),
    @Precio DECIMAL(18, 2),
    @Iva DECIMAL(18, 2),
    @Total DECIMAL(18, 2)
AS
BEGIN
    UPDATE Repuesto
    SET Nombre = @Nombre, Codigo = @Codigo, Precio = @Precio, Iva = @Iva, Total = @Total
    WHERE RepuestoID = @RepuestoID;
END
GO

-- Eliminar Repuesto
CREATE PROCEDURE EliminarRepuesto
    @RepuestoID INT
AS
BEGIN
    DELETE FROM Repuesto
    WHERE RepuestoID = @RepuestoID;
END
GO

-- Seleccionar todos los Repuestos
CREATE PROCEDURE SeleccionarRepuestos
AS
BEGIN
    SELECT * FROM Repuesto;
END
GO

-- Seleccionar Repuesto por ID
CREATE PROCEDURE SeleccionarRepuestoPorID
    @RepuestoID INT
AS
BEGIN
    SELECT * FROM Repuesto
    WHERE RepuestoID = @RepuestoID;
END
GO

-- Procedimientos para la tabla Servicio

-- Insertar Servicio
CREATE PROCEDURE InsertarServicio
    @Nombre NVARCHAR(100),
    @Categoria NVARCHAR(100),
    @Codigo NVARCHAR(50),
    @Precio DECIMAL(18, 2),
    @Iva DECIMAL(18, 2),
    @Total DECIMAL(18, 2)
AS
BEGIN
    INSERT INTO Servicio (Nombre, Categoria, Codigo, Precio, Iva, Total)
    VALUES (@Nombre, @Categoria, @Codigo, @Precio, @Iva, @Total);
END
GO

-- Actualizar Servicio
CREATE PROCEDURE ActualizarServicio
    @ServicioID INT,
    @Nombre NVARCHAR(100),
    @Categoria NVARCHAR(100),
    @Codigo NVARCHAR(50),
    @Precio DECIMAL(18, 2),
    @Iva DECIMAL(18, 2),
    @Total DECIMAL(18, 2)
AS
BEGIN
    UPDATE Servicio
    SET Nombre = @Nombre, Categoria = @Categoria, Codigo = @Codigo, Precio = @Precio, Iva = @Iva, Total = @Total
    WHERE ServicioID = @ServicioID;
END
GO

-- Eliminar Servicio
CREATE PROCEDURE EliminarServicio
    @ServicioID INT
AS
BEGIN
    DELETE FROM Servicio
    WHERE ServicioID = @ServicioID;
END
GO

-- Seleccionar todos los Servicios
CREATE PROCEDURE SeleccionarServicios
AS
BEGIN
    SELECT * FROM Servicio;
END
GO

-- Seleccionar Servicio por ID
CREATE PROCEDURE SeleccionarServicioPorID
    @ServicioID INT
AS
BEGIN
    SELECT * FROM Servicio
    WHERE ServicioID = @ServicioID;
END
GO

-- Procedimientos para la tabla Reparacion

-- Insertar Reparacion
CREATE PROCEDURE InsertarReparacion
    @ClienteID INT,
    @EquipoID INT,
    @TecnicoID INT,
    @Diagnostico NVARCHAR(MAX),
    @FechaIngreso DATE,
    @FechaEntrega DATE = NULL,
    @CostoTotal DECIMAL(10, 2) = NULL
AS
BEGIN
    INSERT INTO Reparacion (ClienteID, EquipoID, TecnicoID, Diagnostico, FechaIngreso, FechaEntrega, CostoTotal)
    VALUES (@ClienteID, @EquipoID, @TecnicoID, @Diagnostico, @FechaIngreso, @FechaEntrega, @CostoTotal);
END
GO

-- Actualizar Reparacion
CREATE PROCEDURE ActualizarReparacion
    @ReparacionID INT,
    @ClienteID INT,
    @EquipoID INT,
    @TecnicoID INT,
    @Diagnostico NVARCHAR(MAX),
    @FechaIngreso DATE,
    @FechaEntrega DATE = NULL,
    @CostoTotal DECIMAL(10, 2) = NULL
AS
BEGIN
    UPDATE Reparacion
    SET ClienteID = @ClienteID, EquipoID = @EquipoID, TecnicoID = @TecnicoID, Diagnostico = @Diagnostico, 
        FechaIngreso = @FechaIngreso, FechaEntrega = @FechaEntrega, CostoTotal = @CostoTotal
    WHERE ReparacionID = @ReparacionID;
END
GO

-- Eliminar Reparacion
CREATE PROCEDURE EliminarReparacion
    @ReparacionID INT
AS
BEGIN
    DELETE FROM Reparacion
    WHERE ReparacionID = @ReparacionID;
END
GO

-- Seleccionar todas las Reparaciones
CREATE PROCEDURE SeleccionarReparaciones
AS
BEGIN
    SELECT * FROM Reparacion;
END
GO

-- Seleccionar Reparacion por ID
CREATE PROCEDURE SeleccionarReparacionPorID
    @ReparacionID INT
AS
BEGIN
    SELECT * FROM Reparacion
    WHERE ReparacionID = @ReparacionID;
END
GO

-- Procedimientos para la tabla ReparacionDetalle

-- Insertar ReparacionDetalle
CREATE PROCEDURE InsertarReparacionDetalle
    @ReparacionID INT,
    @Tipo NVARCHAR(50),
    @ItemID INT
AS
BEGIN
    INSERT INTO ReparacionDetalle (ReparacionID, Tipo, ItemID)
    VALUES (@ReparacionID, @Tipo, @ItemID);
END
GO

-- Actualizar ReparacionDetalle
CREATE PROCEDURE ActualizarReparacionDetalle
    @ReparacionDetalleID INT,
    @ReparacionID INT,
    @Tipo NVARCHAR(50),
    @ItemID INT
AS
BEGIN
    UPDATE ReparacionDetalle
    SET ReparacionID = @ReparacionID, Tipo = @Tipo, ItemID = @ItemID
    WHERE ReparacionDetalleID = @ReparacionDetalleID;
END
GO

-- Eliminar ReparacionDetalle
CREATE PROCEDURE EliminarReparacionDetalle
    @ReparacionDetalleID INT
AS
BEGIN
    DELETE FROM ReparacionDetalle
    WHERE ReparacionDetalleID = @ReparacionDetalleID;
END
GO

-- Seleccionar todos los ReparacionDetalles
CREATE PROCEDURE SeleccionarReparacionDetalles
AS
BEGIN
    SELECT * FROM ReparacionDetalle;
END
GO

-- Seleccionar ReparacionDetalle por ID
CREATE PROCEDURE SeleccionarReparacionDetallePorID
    @ReparacionDetalleID INT
AS
BEGIN
    SELECT * FROM ReparacionDetalle
    WHERE ReparacionDetalleID = @ReparacionDetalleID;
END
GO

-- Procedimientos para la tabla Usuario

-- Insertar Usuario
CREATE PROCEDURE InsertarUsuario
    @NombreUsuario NVARCHAR(50),
    @Contrasena NVARCHAR(50)
AS
BEGIN
    INSERT INTO Usuario (NombreUsuario, Contrasena)
    VALUES (@NombreUsuario, @Contrasena);
END
GO

-- Actualizar Usuario
CREATE PROCEDURE ActualizarUsuario
    @UsuarioID INT,
    @NombreUsuario NVARCHAR(50),
    @Contrasena NVARCHAR(50)
AS
BEGIN
    UPDATE Usuario
    SET NombreUsuario = @NombreUsuario, Contrasena = @Contrasena
    WHERE UsuarioID = @UsuarioID;
END
GO

-- Eliminar Usuario
CREATE PROCEDURE EliminarUsuario
    @UsuarioID INT
AS
BEGIN
    DELETE FROM Usuario
    WHERE UsuarioID = @UsuarioID;
END
GO

-- Seleccionar todos los Usuarios
CREATE PROCEDURE SeleccionarUsuarios
AS
BEGIN
    SELECT * FROM Usuario;
END
GO

-- Seleccionar Usuario por ID
CREATE PROCEDURE SeleccionarUsuarioPorID
    @UsuarioID INT
AS
BEGIN
    SELECT * FROM Usuario
    WHERE UsuarioID = @UsuarioID;
END
GO



--- faltantes 

-- Procedimientos para la tabla Cliente

-- Procedimiento almacenado para obtener todos los clientes
CREATE PROCEDURE ObtenerClientes
AS
BEGIN
    SELECT * FROM Cliente;
END
GO

-- Procedimiento almacenado para obtener todos los técnicos
CREATE PROCEDURE ObtenerTecnicos
AS
BEGIN
    SELECT * FROM Tecnico;
END
GO

-- Procedimiento almacenado para obtener todos los repuestos
CREATE PROCEDURE ObtenerRepuestos
AS
BEGIN
    SELECT * FROM Repuesto;
END
GO
-- Procedimiento almacenado para obtener todos los servicios
CREATE PROCEDURE ObtenerServicios
AS
BEGIN
    SELECT * FROM Servicio;
END
GO

-- Procedimiento almacenado para consultar todas las reparaciones
CREATE PROCEDURE ConsultarTodasLasReparaciones
AS
BEGIN
    SELECT * FROM Reparacion;
END
GO

-- Procedimiento almacenado para obtener todos los equipos
CREATE PROCEDURE ObtenerEquipos
AS
BEGIN
    SELECT * FROM Equipo;
END
GO


-- Seleccionar Cliente por ID (corregido)
CREATE PROCEDURE ObtenerClientePorID
    @ClienteID INT
AS
BEGIN
    SELECT * FROM Cliente
    WHERE ClienteID = @ClienteID;
END
GO

-- Procedimientos para la tabla Tecnico

-- Seleccionar Tecnico por ID (corregido)
CREATE PROCEDURE ObtenerTecnicoPorID
    @TecnicoID INT
AS
BEGIN
    SELECT * FROM Tecnico
    WHERE TecnicoID = @TecnicoID;
END
GO

-- Procedimientos para la tabla Equipo

-- Seleccionar Equipo por Número de Serie
CREATE PROCEDURE ObtenerEquipoPorNumeroSerie
    @NumeroSerie NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Equipo
    WHERE NumeroSerie = @NumeroSerie;
END
GO

-- Seleccionar Equipos por Cliente
CREATE PROCEDURE ObtenerEquiposPorCliente
    @ClienteID INT
AS
BEGIN
    SELECT * FROM Equipo
    WHERE ClienteID = @ClienteID;
END
GO

-- Seleccionar Equipos por Correo (suponiendo que se refiere al correo del cliente asociado)
CREATE PROCEDURE ObtenerEquipoPorCorreo
    @Correo NVARCHAR(100)
AS
BEGIN
    SELECT e.* 
    FROM Equipo e
    INNER JOIN Cliente c ON e.ClienteID = c.ClienteID
    WHERE c.Correo = @Correo;
END
GO

-- Procedimientos para la tabla Servicio

-- Seleccionar Servicio por ID (corregido)
CREATE PROCEDURE ObtenerServicioPorID
    @ServicioID INT
AS
BEGIN
    SELECT * FROM Servicio
    WHERE ServicioID = @ServicioID;
END
GO

-- Procedimientos para la tabla Repuesto

-- Seleccionar Repuesto por ID (corregido)
CREATE PROCEDURE ObtenerRepuestoPorID
    @RepuestoID INT
AS
BEGIN
    SELECT * FROM Repuesto
    WHERE RepuestoID = @RepuestoID;
END
GO

-- Procedimientos para la tabla Reparacion
-- Crear el tipo de tabla para los detalles de reparación
CREATE TYPE DetalleReparacion AS TABLE (
    Tipo NVARCHAR(50),
    ItemID INT
);
GO

-- Procedimiento almacenado para insertar reparación con detalles
CREATE PROCEDURE InsertarReparacionConDetalles
    @ClienteID INT,
    @EquipoID INT,
    @TecnicoID INT,
    @Diagnostico NVARCHAR(MAX),
    @FechaIngreso DATE,
    @FechaEntrega DATE = NULL,
    @CostoTotal DECIMAL(10, 2) = NULL,
    @Detalles DetalleReparacion READONLY
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Insertar la reparación
        DECLARE @ReparacionID INT;
        INSERT INTO Reparacion (ClienteID, EquipoID, TecnicoID, Diagnostico, FechaIngreso, FechaEntrega, CostoTotal)
        VALUES (@ClienteID, @EquipoID, @TecnicoID, @Diagnostico, @FechaIngreso, @FechaEntrega, @CostoTotal);

        SET @ReparacionID = SCOPE_IDENTITY();

        -- Insertar los detalles de la reparación
        INSERT INTO ReparacionDetalle (ReparacionID, Tipo, ItemID)
        SELECT @ReparacionID, Tipo, ItemID
        FROM @Detalles;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END
GO
