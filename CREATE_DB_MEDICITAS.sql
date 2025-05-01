create database BD_MediCitas
use BD_MediCitas

create table Paciente(
	IDPaciente NVARCHAR(4) PRIMARY KEY,
	Nombre NVARCHAR(50) NOT NULL,
	Direccion NVARCHAR(40) NOT NULL,
	Telefono NVARCHAR(15) NOT NULL,
	Genero NVARCHAR(40) NOT NULL,
	FechaNacimiento DATE NOT NULL
)

INSERT INTO Paciente (IDPaciente, Nombre, Direccion, Telefono, Genero, FechaNacimiento)
VALUES 
('P001', 'Ana María Pérez', 'Calle 123 #45-67', '3111111111', 'Femenino', '1990-05-12'),
('P002', 'Carlos Gómez', 'Carrera 10 #20-30', '3002222222', 'Masculino', '1985-11-23'),
('P003', 'Laura Martínez', 'Calle 50 #80-90', '3103333333', 'Femenino', '1992-02-15'),
('P004', 'Juan Rodríguez', 'Avenida 5 #10-15', '3124444444', 'Masculino', '1995-09-05'),
('P005', 'Sofía Ramírez', 'Carrera 25 #56-78', '3125555555', 'Femenino', '1993-07-20'),
('P006', 'Miguel Torres', 'Calle 90 #12-34', '3136666666', 'Masculino', '1988-03-14'),
('P007', 'Elena Castro', 'Avenida 15 #45-67', '3147777777', 'Femenino', '1990-12-01'),
('P008', 'Diego Morales', 'Diagonal 30 #50-60', '3158888888', 'Masculino', '1995-08-30'),
('P009', 'Camila López', 'Calle 44 #78-89', '3161111222', 'Femenino', '1996-11-15'),
('P010', 'Javier Méndez', 'Carrera 12 #34-56', '3173333444', 'Masculino', '1982-05-08'),
('P011', 'Adriana Gómez', 'Avenida 20 #11-25', '3184444555', 'Femenino', '1999-01-10'),
('P012', 'Rodrigo Salazar', 'Diagonal 8 #22-33', '3195555666', 'Masculino', '1977-10-25'),
('P013', 'Paula Restrepo', 'Carrera 7 #54-21', '3126666777', 'Femenino', '1994-04-03'),
('P014', 'Fernando Ríos', 'Calle 80 #13-45', '3137777888', 'Masculino', '1990-02-17'),
('P015', 'Lucía Vargas', 'Carrera 15 #67-89', '3148888999', 'Femenino', '1986-09-12'),
('P016', 'Ricardo Peña', 'Avenida 6 #45-30', '3159999000', 'Masculino', '1981-12-25'),
('P017', 'Sara Castillo', 'Calle 77 #23-12', '3161212121', 'Femenino', '1997-03-11'),
('P018', 'Tomás Herrera', 'Carrera 40 #22-56', '3171313131', 'Masculino', '1989-07-21');

create table Medico (
	IDMedico NVARCHAR(4) PRIMARY KEY,
	Nombre NVARCHAR(50) NOT NULL,
	Especialidad NVARCHAR(40) NOT NULL,
	Telefono NVARCHAR(15) NOT NULL,
	Genero NVARCHAR(40) NOT NULL,
	FechaNacimiento DATE NOT NULL,
	HorarioAtencion TIME NOT NULL /*para casos de atención en distintos días pero siempre con los mismos horarios*/
)

INSERT INTO Medico (IDMedico, Nombre, Especialidad, Telefono, Genero, FechaNacimiento, HorarioAtencion)
VALUES 
('M001', 'Dr. Luis Fernández', 'Cardiología', '3205555555', 'Masculino', '1975-03-20', '08:00:00'),
('M002', 'Dra. Marta López', 'Pediatría', '3216666666', 'Femenino', '1980-07-10', '09:00:00'),
('M003', 'Dr. Andrés Sánchez', 'Dermatología', '3227777777', 'Masculino', '1983-01-29', '10:00:00'),
('M004', 'Dra. Carolina Díaz', 'Neurología', '3238888888', 'Femenino', '1978-04-18', '11:00:00'),
('M005', 'Dr. Eduardo Pérez', 'Neurología', '3249999999', 'Masculino', '1970-12-05', '13:00:00'),
('M006', 'Dra. Valeria Ortiz', 'Pediatría', '3251010101', 'Femenino', '1982-06-15', '14:00:00'),
('M007', 'Dra. Natalia Torres', 'Cardiología', '3263030303', 'Femenino', '1975-08-15', '15:00:00'),
('M008', 'Dr. Oscar Martínez', 'Pediatría', '3274040404', 'Masculino', '1983-09-20', '08:30:00'),
('M009', 'Dra. Gabriela Muñoz', 'Neurología', '3285050505', 'Femenino', '1979-03-05', '10:00:00'),
('M010', 'Dr. Alejandro Gómez', 'Dermatología', '3296060606', 'Masculino', '1987-06-25', '09:00:00'),
('M011', 'Dra. Sofía Vargas', 'Medicina General', '3307070707', 'Femenino', '1985-12-10', '14:00:00'),
('M012', 'Dr. Juan Moreno', 'Neurología', '3318080808', 'Masculino', '1976-02-19', '12:00:00'),
('M013', 'Dra. Carolina Paredes', 'Cardiología', '3329090909', 'Femenino', '1981-11-11', '11:30:00'),
('M014', 'Dr. Diego Álvarez', 'Pediatría', '3331010101', 'Masculino', '1989-01-28', '13:00:00'),
('M015', 'Dra. Mariana Sánchez', 'Dermatología', '3341111111', 'Femenino', '1982-08-08', '16:00:00'),
('M016', 'Dr. Sergio Gutiérrez', 'Medicina General', '3351212121', 'Masculino', '1974-05-15', '10:30:00');

create table Cita (
	IDCita NVARCHAR(4) PRIMARY KEY,
	DescripcionCita NVARCHAR(60) NOT NULL,
	Estado NVARCHAR(20) NOT NULL,
	FechayHora DATETIME NOT NULL,
	IDPaciente NVARCHAR(4) NOT NULL,
	IDMedico NVARCHAR(4) NOT NULL,
	CONSTRAINT FK_IDPaciente_Cita FOREIGN KEY (IDPaciente) REFERENCES Paciente(IDPaciente),
	CONSTRAINT FK_IDMedico_Cita FOREIGN KEY (IDMedico) REFERENCES Medico(IDMedico)
)

INSERT INTO Cita (IDCita, DescripcionCita, Estado, FechayHora, IDPaciente, IDMedico)
VALUES 
('C001', 'Consulta General', 'Completada', '2024-09-22T08:30:00', 'P001', 'M001'),
('C002', 'Chequeo Cardiología', 'Pendiente', '2024-09-23T09:00:00', 'P002', 'M001'),
('C003', 'Control Pediátrico', 'Completada', '2024-09-21T10:15:00', 'P003', 'M002'),
('C004', 'Consulta Dermatológica', 'Pendiente', '2024-09-25T11:00:00', 'P004', 'M003'),
('C005', 'Control Cardiología', 'Pendiente', '2024-10-01T08:00:00', 'P009', 'M007'),
('C006', 'Chequeo Neurológico', 'Pendiente', '2024-10-02T09:30:00', 'P010', 'M009'),
('C007', 'Consulta Pediátrica', 'Completada', '2024-10-03T10:00:00', 'P011', 'M008'),
('C008', 'Revisión Dermatológica', 'Completada', '2024-10-04T11:00:00', 'P012', 'M010'),
('C009', 'Consulta General', 'Pendiente', '2024-10-05T12:30:00', 'P013', 'M011'),
('C010', 'Chequeo Cardiológico', 'Pendiente', '2024-10-06T14:00:00', 'P007', 'M002'),
('C011', 'Consulta Pediátrica', 'Pendiente', '2024-10-07T15:30:00', 'P013', 'M014'),
('C012', 'Revisión Neurológica', 'Completada', '2024-10-08T16:00:00', 'P016', 'M012'),
('C013', 'Consulta General', 'Pendiente', '2024-10-09T13:00:00', 'P017', 'M016'),
('C014', 'Chequeo Dermatológico', 'Pendiente', '2024-10-10T08:30:00', 'P018', 'M015');


create table HistorialMedico (
	IDHistorial NVARCHAR(4) PRIMARY KEY,
	Diagnostico NVARCHAR(50) NOT NULL,
	Tratamiento NVARCHAR(50) NOT NULL,
	FechaConsulta DATE NOT NULL,
	IDPaciente NVARCHAR(4) NOT NULL,
	IDMedico NVARCHAR(4) NOT NULL,
	CONSTRAINT FK_IDPaciente_Historial FOREIGN KEY (IDPaciente) REFERENCES Paciente(IDPaciente),
	CONSTRAINT FK_IDMedico_Historial FOREIGN KEY (IDMedico) REFERENCES Medico(IDMedico)
)

INSERT INTO HistorialMedico (IDHistorial, Diagnostico, Tratamiento, FechaConsulta, IDPaciente, IDMedico)
VALUES 
('H001', 'Hipertensión', 'Medicamento antihipertensivo', '2024-09-22', 'P001', 'M001'),
('H002', 'Arritmia', 'Estudio electrofisiológico', '2024-09-23', 'P002', 'M001'),
('H003', 'Bronquitis', 'Antibióticos', '2024-09-21', 'P003', 'M002'),
('H004', 'Acné Severo', 'Tratamiento tópico', '2024-09-25', 'P004', 'M003'),
('H005', 'Arritmia Supraventricular', 'Medicamento antiarrítmico', '2024-10-01', 'P009', 'M007'),
('H006', 'Migraña Crónica', 'Triptanos', '2024-10-02', 'P010', 'M009'),
('H007', 'Asma Moderada', 'Inhalador broncodilatador', '2024-10-03', 'P011', 'M008'),
('H008', 'Psoriasis', 'Crema corticosteroide', '2024-10-04', 'P012', 'M010'),
('H009', 'Gastritis', 'Omeprazol', '2024-10-05', 'P013', 'M011'),
('H010', 'Hipertensión', 'Losartán', '2024-10-06', 'P014', 'M013'),
('H011', 'Otitis Media', 'Antibióticos', '2024-10-07', 'P015', 'M014'),
('H012', 'Epilepsia Controlada', 'Anticonvulsivos', '2024-10-08', 'P016', 'M012'),
('H013', 'Colesterol Alto', 'Estatinas', '2024-10-09', 'P017', 'M016'),
('H014', 'Dermatitis Atópica', 'Hidratantes tópicos', '2024-10-10', 'P018', 'M015');

create table tbl_usuario(
	idUsuario INT PRIMARY KEY IDENTITY(1,1),
	email NVARCHAR(100) NOT NULL,
	contrasena NVARCHAR(255) NOT NULL,
	rol NVARCHAR(50) NOT NULL
);

INSERT INTO tbl_usuario (email, contrasena, rol)
VALUES 
('ana.perez@example.com', 'contrasena123', 'paciente'),
('carlos.gomez@example.com', 'seguro456', 'paciente'),
('luis.fernandez@example.com', 'doctor789', 'medico'),
('marta.lopez@example.com', 'medico321', 'medico');

--TRIGGER PARA HISTORIAL
create trigger TG_HistorialMedico
on Cita
for insert
as 
begin
	-- Insertar los datos en HistorialMedico a partir de la nueva fila en Cita
    INSERT INTO HistorialMedico (IDHistorial, Diagnostico, Tratamiento, FechaConsulta, IDPaciente, IDMedico)
    SELECT 
        -- IDHistorial puede generarse automáticamente si lo prefieres o puedes asignarlo de alguna otra forma
        'H' + RIGHT('000' + CAST((SELECT COUNT(*) + 1 FROM HistorialMedico) AS NVARCHAR(3)), 3), 
        '', -- Diagnóstico vacío
        '', -- Tratamiento vacío
        CAST(i.FechayHora AS DATE), -- Fecha de la cita
        i.IDPaciente, -- ID del Paciente
        i.IDMedico -- ID del Médico
    FROM INSERTED i;
end

--PROCEDIMIENTOS ALMACENADOS
--------------------------------------------------//--------------------------------------------------------------------
-- Procedimiento para obtener todos los pacientes
CREATE PROCEDURE SP_Paciente_Index
AS
BEGIN
    SELECT * FROM Paciente;
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

-- Procedimiento para insertar un nuevo paciente
CREATE PROCEDURE SP_Paciente_Create
    @IDPaciente NVARCHAR(4),
    @Nombre NVARCHAR(50),
    @Direccion NVARCHAR(40),
    @Telefono NVARCHAR(15),
    @Genero NVARCHAR(40),
    @FechaNacimiento DATE
AS
BEGIN
    INSERT INTO Paciente (IDPaciente, Nombre, Direccion, Telefono, Genero, FechaNacimiento)
    VALUES (@IDPaciente, @Nombre, @Direccion, @Telefono, @Genero, @FechaNacimiento);
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

-- Procedimiento para actualizar los datos de un paciente
CREATE PROCEDURE SP_Paciente_Update
    @IDPaciente NVARCHAR(4),
    @Nombre NVARCHAR(50),
    @Direccion NVARCHAR(40),
    @Telefono NVARCHAR(15),
    @Genero NVARCHAR(40),
    @FechaNacimiento DATE
AS
BEGIN
    UPDATE Paciente
    SET Nombre = @Nombre,
        Direccion = @Direccion,
        Telefono = @Telefono,
        Genero = @Genero,
        FechaNacimiento = @FechaNacimiento
    WHERE IDPaciente = @IDPaciente;
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

-- Procedimiento para eliminar un paciente
CREATE PROCEDURE SP_Paciente_Delete
    @IDPaciente NVARCHAR(4)
AS
BEGIN
    DELETE FROM Paciente WHERE IDPaciente = @IDPaciente;
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

-- Procedimiento para obtener un paciente por ID
CREATE PROCEDURE SP_Paciente_Read
    @IDPaciente NVARCHAR(4)
AS
BEGIN
    SELECT * FROM Paciente WHERE IDPaciente = @IDPaciente;
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

--------------------------------------------------//--------------------------------------------------------------------
-- Procedimiento para obtener todos los médicos
CREATE PROCEDURE SP_Medico_Index
AS
BEGIN
    SELECT * FROM Medico;
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

-- Procedimiento para insertar un nuevo médico
CREATE PROCEDURE SP_Medico_Create
    @IDMedico NVARCHAR(4),
    @Nombre NVARCHAR(50),
    @Especialidad NVARCHAR(40),
    @Telefono NVARCHAR(15),
    @Genero NVARCHAR(40),
    @FechaNacimiento DATE,
    @HorarioAtencion TIME
AS
BEGIN
    INSERT INTO Medico (IDMedico, Nombre, Especialidad, Telefono, Genero, FechaNacimiento, HorarioAtencion)
    VALUES (@IDMedico, @Nombre, @Especialidad, @Telefono, @Genero, @FechaNacimiento, @HorarioAtencion);
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

-- Procedimiento para actualizar los datos de un médico
CREATE PROCEDURE SP_Medico_Update
    @IDMedico NVARCHAR(4),
    @Nombre NVARCHAR(50),
    @Especialidad NVARCHAR(40),
    @Telefono NVARCHAR(15),
    @Genero NVARCHAR(40),
    @FechaNacimiento DATE,
    @HorarioAtencion TIME
AS
BEGIN
    UPDATE Medico
    SET Nombre = @Nombre,
        Especialidad = @Especialidad,
        Telefono = @Telefono,
        Genero = @Genero,
        FechaNacimiento = @FechaNacimiento,
        HorarioAtencion = @HorarioAtencion
    WHERE IDMedico = @IDMedico;
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

-- Procedimiento para eliminar un médico
CREATE PROCEDURE SP_Medico_Delete
    @IDMedico NVARCHAR(4)
AS
BEGIN
    DELETE FROM Medico WHERE IDMedico = @IDMedico;
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

-- Procedimiento para obtener un médico por ID
CREATE PROCEDURE SP_Medico_Read
    @IDMedico NVARCHAR(4)
AS
BEGIN
    SELECT * FROM Medico WHERE IDMedico = @IDMedico;
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO
--------------------------------------------------//--------------------------------------------------------------------
-- Procedimiento para obtener todas las citas
CREATE PROCEDURE SP_Cita_Index
AS
BEGIN
    SELECT * FROM Cita;
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

-- Procedimiento para insertar una nueva cita
CREATE PROCEDURE SP_Cita_Create
    @IDCita NVARCHAR(4),
    @DescripcionCita NVARCHAR(60),
    @Estado NVARCHAR(20),
    @FechayHora DATETIME,
    @IDPaciente NVARCHAR(4),
    @IDMedico NVARCHAR(4)
AS
BEGIN
    INSERT INTO Cita (IDCita, DescripcionCita, Estado, FechayHora, IDPaciente, IDMedico)
    VALUES (@IDCita, @DescripcionCita, @Estado, @FechayHora, @IDPaciente, @IDMedico);
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

-- Procedimiento para actualizar una cita
CREATE PROCEDURE SP_Cita_Update
    @IDCita NVARCHAR(4),
    @DescripcionCita NVARCHAR(60),
    @Estado NVARCHAR(20),
    @FechayHora DATETIME,
    @IDPaciente NVARCHAR(4),
    @IDMedico NVARCHAR(4)
AS
BEGIN
    UPDATE Cita
    SET DescripcionCita = @DescripcionCita,
        Estado = @Estado,
        FechayHora = @FechayHora,
        IDPaciente = @IDPaciente,
        IDMedico = @IDMedico
    WHERE IDCita = @IDCita;
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

-- Procedimiento para eliminar una cita
CREATE PROCEDURE SP_Cita_Delete
    @IDCita NVARCHAR(4)
AS
BEGIN
    DELETE FROM Cita WHERE IDCita = @IDCita;
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

-- Procedimiento para obtener una cita por ID
CREATE PROCEDURE SP_Cita_Read
    @IDCita NVARCHAR(4)
AS
BEGIN
    SELECT * FROM Cita WHERE IDCita = @IDCita;
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

--------------------------------------------------//--------------------------------------------------------------------

-- Procedimiento para obtener todo el historial médico
CREATE PROCEDURE SP_HistorialMedico_Index
AS
BEGIN
    SELECT * FROM HistorialMedico;
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

-- Procedimiento para insertar un nuevo historial médico
CREATE PROCEDURE SP_HistorialMedico_Create
    @IDHistorial NVARCHAR(4),
    @Diagnostico NVARCHAR(50),
    @Tratamiento NVARCHAR(50),
    @FechaConsulta DATE,
    @IDPaciente NVARCHAR(4),
    @IDMedico NVARCHAR(4)
AS
BEGIN
    INSERT INTO HistorialMedico (IDHistorial, Diagnostico, Tratamiento, FechaConsulta, IDPaciente, IDMedico)
    VALUES (@IDHistorial, @Diagnostico, @Tratamiento, @FechaConsulta, @IDPaciente, @IDMedico);
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

-- Procedimiento para actualizar un historial médico
CREATE PROCEDURE SP_HistorialMedico_Update
    @IDHistorial NVARCHAR(4),
    @Diagnostico NVARCHAR(50),
    @Tratamiento NVARCHAR(50),
    @FechaConsulta DATE,
    @IDPaciente NVARCHAR(4),
    @IDMedico NVARCHAR(4)
AS
BEGIN
    UPDATE HistorialMedico
    SET Diagnostico = @Diagnostico,
        Tratamiento = @Tratamiento,
        FechaConsulta = @FechaConsulta,
        IDPaciente = @IDPaciente,
        IDMedico = @IDMedico
    WHERE IDHistorial = @IDHistorial;
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

-- Procedimiento para eliminar un historial médico
CREATE PROCEDURE SP_HistorialMedico_Delete
    @IDHistorial NVARCHAR(4)
AS
BEGIN
    DELETE FROM HistorialMedico WHERE IDHistorial = @IDHistorial;
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

-- Procedimiento para obtener un historial médico por ID
CREATE PROCEDURE SP_HistorialMedico_Read
    @IDHistorial NVARCHAR(4)
AS
BEGIN
    SELECT * FROM HistorialMedico WHERE IDHistorial = @IDHistorial;
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

-- Procedimiento para obtener el historial médico de un paciente por su ID
CREATE PROCEDURE SP_HistorialMedico_ByPacienteID
    @IDPaciente NVARCHAR(4)
AS
BEGIN
    SELECT H.IDHistorial, H.Diagnostico, H.Tratamiento, H.FechaConsulta, H.IDPaciente, H.IDMedico
    FROM HistorialMedico H
    WHERE H.IDPaciente = @IDPaciente;
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

--------------------------------------------------//--------------------------------------------------------------------
-- Procedimiento para obtener todos los usuarios
CREATE PROCEDURE SP_Usuario_Index
AS
BEGIN
    SELECT * FROM tbl_usuario;
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

-- Procedimiento para insertar un nuevo usuario
CREATE PROCEDURE SP_Usuario_Create
    @Email NVARCHAR(100),
    @Contrasena NVARCHAR(255),
    @Rol NVARCHAR(50)
AS
BEGIN
    INSERT INTO tbl_usuario (email, contrasena, rol)
    VALUES (@Email, @Contrasena, @Rol);
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

-- Procedimiento para actualizar un usuario
CREATE PROCEDURE SP_Usuario_Update
    @IDUsuario INT,
    @Email NVARCHAR(100),
    @Contrasena NVARCHAR(255),
    @Rol NVARCHAR(50)
AS
BEGIN
    UPDATE tbl_usuario
    SET email = @Email,
        contrasena = @Contrasena,
        rol = @Rol
    WHERE idUsuario = @IDUsuario;
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

-- Procedimiento para eliminar un usuario
CREATE PROCEDURE SP_Usuario_Delete
    @IDUsuario INT
AS
BEGIN
    DELETE FROM tbl_usuario WHERE idUsuario = @IDUsuario;
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

-- Procedimiento para validar un usuario por email y contraseña
create PROCEDURE SP_ValidarUsuario
    @Email NVARCHAR(100),
    @Contrasena NVARCHAR(255),
	@Rol NVARCHAR (100)
AS
BEGIN
    SELECT email, contrasena , rol FROM tbl_usuario 
    WHERE email = @Email AND contrasena = @Contrasena AND rol = @Rol;
END;
---Retorna el identificador de la tabla
Select Scope_identity()
GO

select * from dbo.tbl_usuario 
select * from Medico
select * from Paciente
select * from HistorialMedico
select * from Cita
