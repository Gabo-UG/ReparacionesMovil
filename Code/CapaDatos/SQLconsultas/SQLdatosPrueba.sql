-- Insertar datos en Cliente
INSERT INTO Cliente (Nombre, Direccion, Telefono, Correo) VALUES
('Juan Pérez', 'Calle Falsa 123', '555-1234', 'juan.perez@example.com'),
('Ana Gómez', 'Avenida Siempre Viva 742', '555-5678', 'ana.gomez@example.com'),
('Carlos Rodríguez', 'Boulevard del Libertador 456', '555-8765', 'carlos.rodriguez@example.com'),
('Laura Martínez', 'Calle Real 789', '555-4321', 'laura.martinez@example.com'),
('Luis Fernández', 'Plaza Mayor 1', '555-6789', 'luis.fernandez@example.com');

-- Insertar datos en Tecnico
INSERT INTO Tecnico (Nombre, Especialidad, Telefono, Correo) VALUES
('Pedro López', 'Electrónica', '555-2345', 'pedro.lopez@example.com'),
('Marta Ruiz', 'Mecánica', '555-3456', 'marta.ruiz@example.com'),
('José Morales', 'Programación', '555-4567', 'jose.morales@example.com'),
('Sofia Díaz', 'Redes', '555-5678', 'sofia.diaz@example.com'),
('Mario Gómez', 'Hardware', '555-6789', 'mario.gomez@example.com');

-- Insertar datos en Equipo
INSERT INTO Equipo (Tipo, NumeroSerie, FechaIngreso, Estado, ClienteID) VALUES
('Computadora', 'SN123456', '2024-01-10', 'En reparación', 1),
('Impresora', 'SN789012', '2024-02-15', 'Operativo', 2),
('Teléfono', 'SN345678', '2024-03-20', 'En reparación', 3),
('Tablet', 'SN901234', '2024-04-25', 'Operativo', 4),
('Cámara', 'SN567890', '2024-05-30', 'En reparación', 5);

-- Insertar datos en Repuesto
INSERT INTO Repuesto (Nombre, Codigo, Precio, Iva, Total) VALUES
('Memoria RAM 8GB', 'RAM8GB', 100.00, 21.00, 121.00),
('Disco Duro 1TB', 'HDD1TB', 80.00, 16.80, 96.80),
('Teclado USB', 'KBUSB', 25.00, 5.25, 30.25),
('Ratón Óptico', 'MOUSE', 15.00, 3.15, 18.15),
('Monitor 24"', 'MON24', 200.00, 42.00, 242.00);

-- Insertar datos en Servicio
INSERT INTO Servicio (Nombre, Categoria, Codigo, Precio, Iva, Total) VALUES
('Reparación de Computadora', 'Mantenimiento', 'REPCOMP', 150.00, 31.50, 181.50),
('Instalación de Impresora', 'Instalación', 'INSTIMP', 50.00, 10.50, 60.50),
('Configuración de Red', 'Consultoría', 'CONFRED', 200.00, 42.00, 242.00),
('Actualización de Sistema Operativo', 'Actualización', 'ACTOS', 120.00, 25.20, 145.20),
('Reparación de Teléfono', 'Mantenimiento', 'REPTEL', 75.00, 15.75, 90.75);

-- Insertar datos en Reparacion
INSERT INTO Reparacion (ClienteID, EquipoID, TecnicoID, Diagnostico, FechaIngreso, FechaEntrega, CostoTotal) VALUES
(1, 1, 1, 'Fallo en la placa madre', '2024-01-10', NULL, NULL),
(2, 2, 2, 'Problema con el cabezal', '2024-02-15', NULL, NULL),
(3, 3, 3, 'Software corrupto', '2024-03-20', NULL, NULL),
(4, 4, 4, 'Batería defectuosa', '2024-04-25', NULL, NULL),
(5, 5, 5, 'Error en el objetivo', '2024-05-30', NULL, NULL);

-- Insertar datos en ReparacionDetalle
INSERT INTO ReparacionDetalle (ReparacionID, Tipo, ItemID) VALUES
(1, 'Repuesto', 1),
(2, 'Servicio', 1),
(3, 'Repuesto', 2),
(4, 'Servicio', 3),
(5, 'Repuesto', 3);

-- Insertar datos en Usuario
INSERT INTO Usuario (NombreUsuario, Contrasena) VALUES
('admin', 'admin123'),
('usuario1', 'pass123'),
('usuario2', 'pass456'),
('usuario3', 'pass789'),
('usuario4', 'pass000');

-- Visualizar datos en Cliente
SELECT * FROM Cliente;

-- Visualizar datos en Tecnico
SELECT * FROM Tecnico;

-- Visualizar datos en Equipo
SELECT * FROM Equipo;

-- Visualizar datos en Repuesto
SELECT * FROM Repuesto;

-- Visualizar datos en Servicio
SELECT * FROM Servicio;

-- Visualizar datos en Reparacion
SELECT * FROM Reparacion;

-- Visualizar datos en ReparacionDetalle
SELECT * FROM ReparacionDetalle;

-- Visualizar datos en Usuario
SELECT * FROM Usuario;
