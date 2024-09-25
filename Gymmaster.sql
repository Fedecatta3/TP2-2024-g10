-- Crear base de datos
CREATE DATABASE GymMaster;
GO

-- Usar la base de datos recién creada
USE GymMaster;
GO

-- Crear tabla Rol
CREATE TABLE Rol (
    id_rol INT PRIMARY KEY IDENTITY(1,1),
    descripcion NVARCHAR(100) NOT NULL
);
GO

-- Crear tabla Usuario
CREATE TABLE Usuario (
    id_usuario INT PRIMARY KEY IDENTITY(1,1),
    id_rol INT FOREIGN KEY REFERENCES Rol(id_rol),
    nombre NVARCHAR(100) NOT NULL,
    email NVARCHAR(100) NOT NULL,
    telefono NVARCHAR(50),
    dni NVARCHAR(20),
    fecha_nacimiento DATE,
    estado BIT NOT NULL
);
GO

-- Alterar la tabla Usuario para agregar la columna contraseña
ALTER TABLE Usuario
ADD contraseña NVARCHAR(255);
GO

select * from usuario


-- Crear tabla Horario
CREATE TABLE Horario (
    id_horario INT PRIMARY KEY IDENTITY(1,1),
    id_usuario INT FOREIGN KEY REFERENCES Usuario(id_usuario),
    diaSemana NVARCHAR(10),
    horaInicio TIME,
    horaFin TIME,
    estado BIT
);
GO

-- Crear tabla PlanEntrenamiento
CREATE TABLE PlanEntrenamiento (
    id_plan INT PRIMARY KEY IDENTITY(1,1),
    nombre NVARCHAR(100) NOT NULL,
    fechaInicio DATE,
    fechaFin DATE,
    cantSeries INT,
    total INT,
    estado BIT NOT NULL
);
GO

-- Crear tabla Ejercicio
CREATE TABLE Ejercicio (
    id_ejercicio INT PRIMARY KEY IDENTITY(1,1),
    nombre NVARCHAR(100) NOT NULL,
    repeticiones INT,
    tiempo INT
);
GO

-- Crear tabla Plan_Ejercicio
CREATE TABLE Plan_Ejercicio (
    id_plan INT FOREIGN KEY REFERENCES PlanEntrenamiento(id_plan),
    id_ejercicio INT FOREIGN KEY REFERENCES Ejercicio(id_ejercicio),
    PRIMARY KEY (id_plan, id_ejercicio)
);
GO

-- Crear tabla Alumno
CREATE TABLE Alumno (
    id_alumno INT PRIMARY KEY IDENTITY(1,1),
    id_usuario INT FOREIGN KEY REFERENCES Usuario(id_usuario),
    id_membresia INT,
    id_plan INT FOREIGN KEY REFERENCES PlanEntrenamiento(id_plan),
    nombre NVARCHAR(100) NOT NULL,
    apellido NVARCHAR(100) NOT NULL,
    email NVARCHAR(100),
    telefono NVARCHAR(50),
    foto NVARCHAR(MAX),
    dni NVARCHAR(20),
    fecha_nacimiento DATE,
    contacto_emergencia NVARCHAR(100),
    sexo NVARCHAR(10),
    observaciones NVARCHAR(MAX),
    estado BIT NOT NULL
);
GO

-- Crear tabla Membresia
CREATE TABLE Membresia (
    id_membresia INT PRIMARY KEY IDENTITY(1,1),
    nombre NVARCHAR(100) NOT NULL,
    duracion INT,
    fecha_creacion DATE,
    costo DECIMAL(10, 2),
    estado BIT NOT NULL
);
GO

-- Crear tabla Usuario_Plan
CREATE TABLE Usuario_Plan (
    id_usuario INT FOREIGN KEY REFERENCES Usuario(id_usuario),
    id_plan INT FOREIGN KEY REFERENCES PlanEntrenamiento(id_plan),
    PRIMARY KEY (id_usuario, id_plan)
);
GO

-- Crear tabla MedioDePago
CREATE TABLE MedioDePago (
    id_medioPago INT PRIMARY KEY IDENTITY(1,1),
    nombre NVARCHAR(100) NOT NULL,
    comision DECIMAL(5, 2),
    fechaCreacion DATE,
    estado BIT NOT NULL
);
GO

-- Crear tabla Pago
CREATE TABLE Pago (
    id_pago INT PRIMARY KEY IDENTITY(1,1),
    id_usuario INT FOREIGN KEY REFERENCES Usuario(id_usuario),
    id_alumno INT FOREIGN KEY REFERENCES Alumno(id_alumno),
    id_medioPago INT FOREIGN KEY REFERENCES MedioDePago(id_medioPago),
    fecha DATE,
    cantidad DECIMAL(10, 2),
    total DECIMAL(10, 2)
);
GO

-- Crear tabla PagoDetalle
CREATE TABLE PagoDetalle (
    id_pagoDetalle INT PRIMARY KEY IDENTITY(1,1),
    id_pago INT FOREIGN KEY REFERENCES Pago(id_pago),
    id_membresia INT FOREIGN KEY REFERENCES Membresia(id_membresia),
    periodo INT,
    monto DECIMAL(10, 2)
);
GO



-- AGREGA CAMPO APELLIDO, NUEVOS USUARIOS Y ROLES
ALTER TABLE Usuario
ADD apellido NVARCHAR(100) NOT NULL;

INSERT INTO Rol (descripcion)
VALUES ('Propietario'), ('Administrador'), ('Coach');
SELECT * FROM rol

INSERT INTO Usuario (id_rol, nombre, email, telefono, dni, fecha_nacimiento, estado, contraseña, apellido)
VALUES (1, 'Gimnasio', 'gymmaster@gmail.com', '3794556789', '12345678', '2010-05-20', 1, 'propietario', 'Gymmaster');
SELECT * FROM Usuario

-- NUEVA TABLA PARA ADMINISTRAR LOS PERMISOS
CREATE TABLE Permiso(
    id_permiso INT PRIMARY KEY IDENTITY(1,1),
    id_rol INT REFERENCES ROL(id_rol),
    nombreMenu NVARCHAR(100) NOT NULL,
);

-- ASIGNACION DE VISTAS PARA CADA ROL
INSERT INTO Permiso(id_rol, nombreMenu)
VALUES (1, 'menuUsuarios'),
       (1, 'menuMantenimiento'),
       (1, 'menuReportes'),
       (1, 'menuBackUp');

INSERT INTO Permiso(id_rol, nombreMenu)
VALUES (2, 'menuUsuarios'),
       (2, 'menuAlumnos'),
       (2, 'menuPagos');

INSERT INTO Permiso(id_rol, nombreMenu)
VALUES (3, 'menuAlumnos'),
       (3, 'menuPlanes');

-- NUEVO ADMIN Y COACH
INSERT INTO Usuario (id_rol, nombre, email, telefono, dni, fecha_nacimiento, estado, contraseña, apellido)
VALUES (2, 'Juan', 'juanperez@gmail.com', '3794442314', '44444444', '2000-10-15', 1, 'administrador', 'Perez');

INSERT INTO Usuario (id_rol, nombre, email, telefono, dni, fecha_nacimiento, estado, contraseña, apellido)
VALUES (3, 'Pablo', 'pablogomez@gmail.com', '3794114567', '55555555', '2005-03-30', 1, 'profesor', 'Gomez');

SELECT * FROM Usuario

-- PROCEDIMIENTOS PARA REGISTRAR / EDITAR Y ELIMINAR UN USUARIO
CREATE PROC SP_REGISTRARUSUARIO(
   @id_rol int,
   @nombre varchar(100),
   @email varchar(100),
   @telefono varchar(50),
   @dni varchar(20),
   @fecha_nacimiento date,
   @estado bit,
   @contraseña varchar(255),
   @apellido varchar(100),
   
   -- parametros de salida
   @idUsuarioResultado int output,
   @mensaje varchar(500) output
)
as
begin

  set @idUsuarioResultado = 0
  set @mensaje = ''

  if not exists (select * from Usuario where dni = @dni)
     begin
        insert into Usuario (id_rol, nombre, email, telefono, dni, fecha_nacimiento, estado, contraseña, apellido)
        values (@id_rol, @nombre, @email, @telefono, @dni, @fecha_nacimiento, @estado, @contraseña, @apellido)

        set @idUsuarioResultado = SCOPE_IDENTITY() 
     end
  else
     set @mensaje = 'Ya existe un usuario registrado con el mismo DNI'

end

go

CREATE PROC SP_EDITARUSUARIO(
   @id_usuario int,
   @id_rol int,
   @nombre varchar(100),
   @email varchar(100),
   @telefono varchar(50),
   @dni varchar(20),
   @fecha_nacimiento date,
   @estado bit,
   @contraseña varchar(255),
   @apellido varchar(100),
   
   -- parametros de salida
   @respuesta bit output,
   @mensaje varchar(500) output
)
as
begin

  set @respuesta = 0
  set @mensaje = ''

  if not exists (select * from Usuario where dni = @dni and id_usuario != @id_usuario)
     begin
        update Usuario set
        id_rol = @id_rol,
        nombre = @nombre,
        email = @email,
        telefono = @telefono,
        dni = @dni,
        fecha_nacimiento = @fecha_nacimiento,
        estado = @estado,
        contraseña = @contraseña,
        apellido = @apellido
      
        where id_usuario = @id_usuario

        set @respuesta = 1
     end
  else
     set @mensaje = 'Ya existe un usuario registrado con el mismo DNI'

end