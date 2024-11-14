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


CREATE PROC SP_ELIMINARUSUARIO(
   @id_usuario int,
   
   -- parametros de salida
   @respuesta bit output,
   @mensaje varchar(500) output
)
as
begin

  set @respuesta = 0
  set @mensaje = ''
  declare @eliminado bit = 1
	
  IF EXISTS (select * from Alumno a INNER JOIN Usuario u ON u.id_usuario = a.id_usuario WHERE u.id_usuario = @id_usuario)
  BEGIN
     set @eliminado = 0
     set @respuesta = 0
     set @mensaje = 'El usuario no se puede eliminar porque tiene alumnos asignados.'
  END

  IF (@eliminado = 1)
  BEGIN
     -- Eliminación lógica, se actualiza el campo 'estado' a 0 (inactivo)
      UPDATE Usuario SET estado = 0 WHERE id_usuario = @id_usuario

      SET @respuesta = 1
      SET @mensaje = 'El usuario ha sido eliminado correctamente.'
  END

end



CREATE PROC SP_RESTAURARUSUARIO(
   @id_usuario int,
   
   -- parametros de salida
   @respuesta bit output,
   @mensaje varchar(500) output
)
as
begin

  set @respuesta = 0
  set @mensaje = ''

  BEGIN
     UPDATE Usuario SET estado = 1 WHERE id_usuario = @id_usuario;

      SET @respuesta = 1
      SET @mensaje = 'Usuario restaurado correctamente.';
  END

end

CREATE PROCEDURE SP_OBTENERUSUARIO(
   @id_usuario INT
)
AS
BEGIN
   SET NOCOUNT ON;  -- Evitar el conteo de filas afectadas

   SELECT 
      u.id_usuario,
      u.nombre,
      u.apellido,
      u.email,
      u.telefono,
      u.dni,
      u.fecha_nacimiento,
      u.estado,
      u.id_rol,
      r.descripcion AS descripcion_rol  -- Agregar descripción del rol
   FROM 
      Usuario u
   INNER JOIN 
      Rol r ON u.id_rol = r.id_rol  -- Hacer el JOIN con la tabla Rol
   WHERE 
      u.id_usuario = @id_usuario;
END



-- Insertar datos en la tabla Membresia
INSERT INTO Membresia (nombre, duracion, fecha_creacion, costo, estado)
VALUES 
('Mensual', 30, GETDATE(), 50.00, 1),
('Trimestral', 90, GETDATE(), 120.00, 1),
('Anual', 365, GETDATE(), 450.00, 1);

-- Insertar datos en la tabla PlanEntrenamiento
INSERT INTO PlanEntrenamiento (nombre, fechaInicio, fechaFin, cantSeries, total, estado)
VALUES 
('Plan de Fuerza', '2024-01-01', '2024-03-31', 12, 240, 1),
('Plan de Resistencia', '2024-01-15', '2024-04-15', 10, 200, 1);

-- Insertar datos en la tabla Ejercicio
INSERT INTO Ejercicio (nombre, repeticiones, tiempo)
VALUES 
('Sentadillas', 15, 30),
('Flexiones', 12, 20),
('Dominadas', 10, 15),
('Correr', 0, 1800); -- 1800 segundos = 30 minutos

-- Insertar datos en la tabla Plan_Ejercicio
INSERT INTO Plan_Ejercicio (id_plan, id_ejercicio)
VALUES 
(1, 1), -- Plan de Fuerza con Sentadillas
(1, 2), -- Plan de Fuerza con Flexiones
(2, 3), -- Plan de Resistencia con Dominadas
(2, 4); -- Plan de Resistencia con Correr

-- Insertar datos en la tabla Alumno
INSERT INTO Alumno (id_usuario, id_membresia, id_plan, nombre, apellido, email, telefono, foto, dni, fecha_nacimiento, contacto_emergencia, sexo, observaciones, estado)
VALUES 
(1, 1, 1, 'Juan', 'Pérez', 'juan@example.com', '123456789', NULL, '12345678', '1990-01-01', '555-1234', 'Masculino', NULL, 1),
(2, 2, 2, 'María', 'González', 'maria@example.com', '987654321', NULL, '87654321', '1992-02-02', '555-5678', 'Femenino', NULL, 1),
(3, 1, 1, 'Pedro', 'López', 'pedro@example.com', '456789123', NULL, '23456789', '1985-03-03', '555-8765', 'Masculino', NULL, 1),
(4, 3, 2, 'Ana', 'Ramírez', 'ana@example.com', '321654987', NULL, '34567890', '1988-04-04', '555-4321', 'Femenino', NULL, 1);



CREATE PROCEDURE SP_LISTARMEMBRESIAS
AS
BEGIN
    SELECT id_membresia, nombre, duracion, fecha_creacion, costo, estado
    FROM Membresia
END


INSERT INTO MedioDePago (nombre, comision, fechaCreacion, estado)
VALUES ('Tarjeta de Crédito', 2.50, GETDATE(), 1),
       ('Transferencia Bancaria', 0.00, GETDATE(), 1),
       ('Paypal', 3.00, GETDATE(), 1),
       ('Efectivo', 0.00, GETDATE(), 1);



CREATE PROCEDURE SP_LISTARMEDIOSPAGO
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id_medioPago, nombre, comision, fechaCreacion, estado
    FROM MedioDePago
    WHERE estado = 1;  -- Asumiendo que "estado" es un bit para activos/inactivos
END
GO


CREATE PROCEDURE SP_LISTAR_EJERCICIOS
AS
BEGIN
    SELECT * FROM Ejercicio;
END;


/*MODIFICACION TABLA HORARIO*/

DELETE Horario

CREATE PROCEDURE SP_InsertarHorario
    @id_usuario INT,
    @diaSemana NVARCHAR(10),
    @horaInicio TIME,
    @horaFin TIME,
    @estado BIT,

	@respuesta INT OUTPUT,
    @mensaje NVARCHAR(500) OUTPUT
AS
BEGIN
	BEGIN TRY
		INSERT INTO Horario (id_usuario, diaSemana, horaInicio, horaFin, estado)
		VALUES (@id_usuario, @diaSemana, @horaInicio, @horaFin, @estado);
		SET @respuesta = 1;
        SET @mensaje = 'Horaro agregado exitosamente.';
	END TRY
    BEGIN CATCH
        SET @respuesta = 0;
        SET @mensaje = ERROR_MESSAGE();
    END CATCH
END

CREATE PROCEDURE SP_EliminarHorario
    @id_horario INT,
    @mensaje NVARCHAR(500) OUTPUT
AS
BEGIN
    BEGIN TRY
        DELETE FROM Horario WHERE id_horario = @id_horario;
        SET @mensaje = 'Horario eliminado exitosamente.';
    END TRY
    BEGIN CATCH
        SET @mensaje = ERROR_MESSAGE();
    END CATCH
END

SELECT * FROM Horario


/*MODIFICACION PROCEDIMIENTO AGREGAR EJERCICIO*/

DROP PROCEDURE SP_AGREGAR_EJERCICIO

CREATE PROCEDURE SP_AGREGAR_EJERCICIO
    @nombre NVARCHAR(100),
    @repeticiones INT,
    @tiempo INT,
    @respuesta INT OUTPUT,
    @mensaje NVARCHAR(500) OUTPUT
AS
BEGIN
    BEGIN TRY
	-- Verificar si ya existe un ejercicio con el mismo nombre, repeticiones y tiempo
        IF EXISTS (SELECT 1 FROM Ejercicio WHERE nombre = @nombre AND repeticiones = @repeticiones AND tiempo = @tiempo)
        BEGIN
            SET @respuesta = 0;
            SET @mensaje = 'Ya existe un ejercicio con el mismo nombre, repeticiones y tiempo.';
            RETURN;
        END
	
	-- Si no se encuentra duplicado, proceder a agregar el nuevo ejercicio
        INSERT INTO Ejercicio (nombre, repeticiones, tiempo)
        VALUES (@nombre, @repeticiones, @tiempo);
        SET @respuesta = 1;
        SET @mensaje = 'Ejercicio agregado exitosamente.';

    END TRY
    BEGIN CATCH
        SET @respuesta = 0;
        SET @mensaje = ERROR_MESSAGE();
    END CATCH
END;


/*PROCEDIMIENTOS PARA EDITAR - ELIMINAR UN EJERCICIO*/
CREATE PROCEDURE SP_EDITAR_EJERCICIO
    @id_ejercicio INT,
    @nombre NVARCHAR(100),
    @repeticiones INT,
    @tiempo INT,
    @respuesta INT OUTPUT,
    @mensaje NVARCHAR(500) OUTPUT
AS
BEGIN
    BEGIN TRY
        -- Verificar si existe el ejercicio con el ID dado
        IF NOT EXISTS (SELECT 1 FROM Ejercicio WHERE id_ejercicio = @id_ejercicio)
        BEGIN
            SET @respuesta = 0;
            SET @mensaje = 'El ejercicio no existe.';
            RETURN;
        END

        -- Actualizar el ejercicio
        UPDATE Ejercicio
        SET nombre = @nombre,
            repeticiones = @repeticiones,
            tiempo = @tiempo
        WHERE id_ejercicio = @id_ejercicio;

        SET @respuesta = 1;
        SET @mensaje = 'Ejercicio actualizado exitosamente.';
    END TRY
    BEGIN CATCH
        SET @respuesta = 0;
        SET @mensaje = ERROR_MESSAGE();
    END CATCH
END;

CREATE PROCEDURE SP_ELIMINAR_EJERCICIO
    @id_ejercicio INT,
    @respuesta INT OUTPUT,
    @mensaje NVARCHAR(500) OUTPUT
AS
BEGIN
    BEGIN TRY
        -- Verificar si el ejercicio está asociado a algún plan
        IF EXISTS (SELECT 1 FROM Plan_Ejercicio WHERE id_ejercicio = @id_ejercicio)
        BEGIN
            SET @respuesta = 0;
            SET @mensaje = 'No se puede eliminar el ejercicio porque está asociado a uno o más planes de entrenamiento.';
            RETURN;
        END

        -- Si no está asociado, eliminar el ejercicio
        DELETE FROM Ejercicio
        WHERE id_ejercicio = @id_ejercicio;

        -- Validar si la eliminación fue exitosa
        IF @@ROWCOUNT > 0
        BEGIN
            SET @respuesta = 1;
            SET @mensaje = 'Ejercicio eliminado exitosamente.';
        END
        ELSE
        BEGIN
            SET @respuesta = 0;
            SET @mensaje = 'No se encontró el ejercicio para eliminar.';
        END
    END TRY
    BEGIN CATCH
        -- Capturar cualquier error durante la ejecución
        SET @respuesta = 0;
        SET @mensaje = ERROR_MESSAGE();
    END CATCH
END;


/*PROCEDIMIENTOS PARA AGREGAR - EDITAR - ELIMINAR - RESTAURAR UN PLAN*/

ALTER TABLE PlanEntrenamiento
DROP COLUMN total;

select * from PlanEntrenamiento

CREATE PROCEDURE SP_AGREGAR_PLAN_ENTRENAMIENTO
    @nombre NVARCHAR(100),
    @fechaInicio DATE,
    @fechaFin DATE,
    @cantSeries INT,
	@estado BIT,
    @respuesta INT OUTPUT,
    @mensaje NVARCHAR(500) OUTPUT
AS
BEGIN
    BEGIN TRY
        -- Verificar si ya existe un plan con el mismo nombre
        IF EXISTS (SELECT 1 FROM PlanEntrenamiento WHERE nombre = @nombre AND fechaInicio = @fechaInicio AND fechaFin = @fechaFin AND cantSeries = @cantSeries)
        BEGIN
            SET @respuesta = 0;
            SET @mensaje = 'Ya existe un plan de entrenamiento con la misma informacion.';
            RETURN;
        END

        -- Insertar el nuevo plan de entrenamiento
        INSERT INTO PlanEntrenamiento (nombre, fechaInicio, fechaFin, cantSeries, estado)
        VALUES (@nombre, @fechaInicio, @fechaFin, @cantSeries, @estado);

        SET @respuesta = SCOPE_IDENTITY();
        SET @mensaje = 'Plan de entrenamiento agregado exitosamente.';
    END TRY
    BEGIN CATCH
        SET @respuesta = 0;
        SET @mensaje = ERROR_MESSAGE();
    END CATCH
END;


CREATE PROCEDURE SP_EDITAR_PLAN_ENTRENAMIENTO
    @id_plan INT,
    @nombre NVARCHAR(100),
    @fechaInicio DATE,
    @fechaFin DATE,
    @cantSeries INT,
	@estado BIT,
    @respuesta INT OUTPUT,
    @mensaje NVARCHAR(500) OUTPUT
AS
BEGIN
    BEGIN TRY
        -- Verificar si existe el plan con el ID dado
        IF NOT EXISTS (SELECT 1 FROM PlanEntrenamiento WHERE id_plan = @id_plan)
        BEGIN
            SET @respuesta = 0;
            SET @mensaje = 'El plan de entrenamiento no existe.';
            RETURN;
        END

        -- Actualizar el plan de entrenamiento
        UPDATE PlanEntrenamiento
        SET nombre = @nombre,
            fechaInicio = @fechaInicio,
            fechaFin = @fechaFin,
            cantSeries = @cantSeries,
			estado = @estado
        WHERE id_plan = @id_plan;

        SET @respuesta = @id_plan;
        SET @mensaje = 'Plan de entrenamiento actualizado exitosamente.';
    END TRY
    BEGIN CATCH
        SET @respuesta = 0;
        SET @mensaje = ERROR_MESSAGE();
    END CATCH
END;


CREATE PROCEDURE SP_ELIMINAR_PLAN_ENTRENAMIENTO
    @id_plan INT,
    @respuesta INT OUTPUT,
    @mensaje NVARCHAR(500) OUTPUT
AS
BEGIN
    BEGIN TRY
        -- Verificar si existe el plan con el ID dado
        IF NOT EXISTS (SELECT 1 FROM PlanEntrenamiento WHERE id_plan = @id_plan)
        BEGIN
            SET @respuesta = 0;
            SET @mensaje = 'El plan de entrenamiento no existe.';
            RETURN;
        END

        -- Verificar si hay alumnos asociados al plan
        IF EXISTS (SELECT 1 FROM Alumno WHERE id_plan = @id_plan AND estado = 1)
        BEGIN
            SET @respuesta = 0;
            SET @mensaje = 'No se puede eliminar el plan de entrenamiento porque hay alumnos asociados.';
            RETURN;
        END

        -- Cambiar el estado del plan de entrenamiento a 0 (eliminación lógica)
        UPDATE PlanEntrenamiento
        SET estado = 0
        WHERE id_plan = @id_plan;

        SET @respuesta = 1;
        SET @mensaje = 'Plan de entrenamiento eliminado exitosamente.';
    END TRY
    BEGIN CATCH
        SET @respuesta = 0;
        SET @mensaje = ERROR_MESSAGE();
    END CATCH
END;


CREATE PROCEDURE SP_RESTAURAR_PLAN_ENTRENAMIENTO
    @id_plan INT,
    @respuesta INT OUTPUT,
    @mensaje NVARCHAR(500) OUTPUT
AS
BEGIN
    BEGIN TRY
        -- Verificar si existe el plan de entrenamiento y ha sido eliminado lógicamente
        IF NOT EXISTS (SELECT 1 FROM PlanEntrenamiento WHERE id_plan = @id_plan AND estado = 0)
        BEGIN
            SET @respuesta = 0;
            SET @mensaje = 'El plan de entrenamiento no existe o ya está activo.';
            RETURN;
        END

        -- Restaurar el plan de entrenamiento (cambiar el estado a 1)
        UPDATE PlanEntrenamiento
        SET estado = 1
        WHERE id_plan = @id_plan;

        SET @respuesta = 1;
        SET @mensaje = 'Plan de entrenamiento restaurado exitosamente.';
    END TRY
    BEGIN CATCH
        SET @respuesta = 0;
        SET @mensaje = ERROR_MESSAGE();
    END CATCH
END;


CREATE PROCEDURE SP_OBTENER_PLAN_ENTRENAMIENTO_PORID(
   @id_plan INT
)
AS
BEGIN
   SET NOCOUNT ON;  -- Evitar el conteo de filas afectadas

   SELECT 
      id_plan,
	  nombre,
	  fechaInicio,
	  fechaFin,
	  cantSeries,
	  estado
   FROM 
      PlanEntrenamiento 
   WHERE 
      id_plan = @id_plan;
END



/*PROCEDIMIENTOS ALMACENADOS PARA LAS TABLA 'PLAN_EJERCICIO', 'USUARIO_PLAN'*/
CREATE PROCEDURE SP_ASOCIAR_PLAN_EJERCICIO
    @id_plan INT,
    @id_ejercicio INT
AS
BEGIN
    BEGIN TRY
        -- Insertar la relación entre el plan y el ejercicio
        INSERT INTO Plan_Ejercicio (id_plan, id_ejercicio)
        VALUES (@id_plan, @id_ejercicio);
    END TRY
    BEGIN CATCH
        -- Manejar cualquier error
        PRINT ERROR_MESSAGE();
    END CATCH
END;

CREATE PROCEDURE SP_ELIMINAR_PLAN_EJERCICIO
    @id_plan INT
AS
BEGIN
    DELETE FROM Plan_Ejercicio
    WHERE id_plan = @id_plan;
END;



CREATE PROCEDURE SP_ASOCIAR_USUARIO_PLAN
    @id_usuario INT,
    @id_plan INT
AS
BEGIN
    BEGIN TRY
        -- Insertar la relación entre el usuario y el plan
        INSERT INTO Usuario_Plan (id_usuario, id_plan)
        VALUES (@id_usuario, @id_plan);
    END TRY
    BEGIN CATCH
        -- Manejar cualquier error
        PRINT ERROR_MESSAGE();
    END CATCH
END;

CREATE PROCEDURE SP_ELIMINAR_USUARIO_PLAN
    @id_plan INT
AS
BEGIN
    DELETE FROM Usuario_Plan
    WHERE id_plan = @id_plan;
END;


select * from plan_ejercicio
select * from Usuario_Plan

/*MODIFICACION PROCEDIMIENTO LISTAR PLAN ENTRENAMIENTO*/

DROP PROCEDURE SP_LISTAR_PLAN_ENTRENAMIENTO

CREATE PROCEDURE SP_LISTAR_PLAN_ENTRENAMIENTO
AS
BEGIN
    SELECT * FROM PlanEntrenamiento
END

/*PROCEDIMIENTOS PARA LISTAR LAS ASOCIACIONES DE COACHS Y EJERCICIOS AL PLAN*/
CREATE PROCEDURE SP_LISTAR_EJERCICIOS_POR_PLAN
    @id_plan INT
AS
BEGIN
    SELECT e.id_ejercicio, e.nombre, e.repeticiones, e.tiempo
    FROM Ejercicio e
    INNER JOIN Plan_Ejercicio pe ON e.id_ejercicio = pe.id_ejercicio
    WHERE pe.id_plan = @id_plan;
END;


CREATE PROCEDURE SP_LISTAR_COACHS_POR_PLAN
    @id_plan INT
AS
BEGIN
    SELECT u.id_usuario, u.nombre, u.apellido, u.dni, u.email, u.fecha_nacimiento, u.telefono
    FROM Usuario u
    INNER JOIN Usuario_Plan up ON u.id_usuario = up.id_usuario
    WHERE up.id_plan = @id_plan;
END;


/*MODIFICACION PROCEDIMIENTO LISTAR ALUMNOS*/
CREATE PROCEDURE SP_ListarAlumnos
AS
BEGIN
    SELECT A.*
    FROM 
        Alumno A
    INNER JOIN 
        Usuario U ON A.id_usuario = U.id_usuario
    LEFT JOIN 
        Membresia M ON A.id_membresia = M.id_membresia
    LEFT JOIN 
        PlanEntrenamiento P ON A.id_plan = P.id_plan
    ORDER BY 
        A.id_alumno;
END;

select * from alumno 
select * from usuario 

INSERT INTO Alumno (id_usuario, id_membresia, id_plan, nombre, apellido, email, telefono, foto, dni, fecha_nacimiento, contacto_emergencia, sexo, observaciones, estado)
VALUES 
(3, 1, 1, 'Thomas', 'Lopez', 'thomas@example.com', '3795667890', NULL, '00900899', '1990-01-01', '555-1234', 'Masculino', NULL, 1),
(3, 2, 2, 'Tamara', 'González', 'tamara@example.com', '987654321', NULL, '90879678', '1992-02-02', '555-5678', 'Femenino', NULL, 1);



-- PROCEDIMIENTOS PARA REGISTRAR / EDITAR Y ELIMINAR UN ALUMNO

CREATE PROCEDURE SP_REGISTRARALUMNO
    @id_usuario INT,
    @id_membresia INT,
    @id_plan INT,

    @nombre NVARCHAR(100),
    @apellido NVARCHAR(100),
    @email NVARCHAR(100),
    @telefono NVARCHAR(50),
    @foto NVARCHAR(MAX),
    @dni NVARCHAR(20),
    @fecha_nacimiento DATE,
    @contacto_emergencia NVARCHAR(100),
    @sexo NVARCHAR(10),
    @observaciones NVARCHAR(MAX),
    @estado BIT,

	-- parametros de salida
   @idUsuarioResultado int output,
   @mensaje varchar(500) output
AS
BEGIN
	set @idUsuarioResultado = 0
	set @mensaje = ''

	IF NOT EXISTS (select * from Alumno where dni = @dni)
		BEGIN
			INSERT INTO Alumno (id_usuario, id_membresia, id_plan, nombre, apellido, email, telefono, foto, dni, fecha_nacimiento, contacto_emergencia, sexo, observaciones, estado)
			VALUES (@id_usuario, @id_membresia, @id_plan, @nombre, @apellido, @email, @telefono, @foto, @dni, @fecha_nacimiento, @contacto_emergencia, @sexo, @observaciones, @estado);
	
			set @idUsuarioResultado = SCOPE_IDENTITY() 
			set @mensaje = 'Alumno registrado exitosamente!'
		END
	ELSE
		set @mensaje = 'Ya existe un alumno registrado con el mismo DNI'

END

-- PROCEDIMIENTO PARA FILTRAR LOS PLANES ASOCIADO A UN COACH
CREATE PROCEDURE SP_LISTAR_PLAN_POR_COACHS
    @id_usuario INT
AS
BEGIN
    SELECT p.id_plan, p.nombre, p.fechaInicio, p.fechaFin, p.cantSeries, p.estado
    FROM PlanEntrenamiento p
    INNER JOIN Usuario_Plan up ON p.id_plan = up.id_plan
    WHERE up.id_usuario = @id_usuario;
END;


-- PROCEDIMIENTO PARA REGISTRAR UN PAGO

-- AGREGAR CAMPO 'RECARGO'
ALTER TABLE Pago
ADD recargo DECIMAL(10, 2);

CREATE PROCEDURE SP_REGISTRAR_PAGO
    @id_usuario INT,
    @id_alumno INT,
    @id_medioPago INT,
    @fecha DATE,
    @cantidad DECIMAL(10, 2),
    @total DECIMAL(10, 2),
	@recargo DECIMAL(10,2),
    @id_pago INT OUTPUT
AS
BEGIN
    INSERT INTO Pago (id_usuario, id_alumno, id_medioPago, fecha, cantidad, total, recargo)
    VALUES (@id_usuario, @id_alumno, @id_medioPago, @fecha, @cantidad, @total, @recargo);
    
    SET @id_pago = SCOPE_IDENTITY(); -- Obtener el id_pago generado
END;

CREATE PROCEDURE SP_REGISTRAR_PAGO_DETALLE
    @id_pago INT,
    @id_membresia INT,
    @periodo INT,
    @monto DECIMAL(10, 2)
AS
BEGIN
    INSERT INTO PagoDetalle (id_pago, id_membresia, periodo, monto)
    VALUES (@id_pago, @id_membresia, @periodo, @monto);
END;


-- PROCEDIMIENTOS PARA AGREGAR - EDITAR UNA MEMBRESIA
CREATE PROCEDURE SP_AGREGAR_MEMBRESIA
    @nombre NVARCHAR(100),
    @duracion INT,
    @fecha_creacion DATE,
	@costo DECIMAL(10,2),
	@estado BIT,

    @respuesta INT OUTPUT,
    @mensaje NVARCHAR(500) OUTPUT
AS
BEGIN
    BEGIN TRY
	-- Verificar si ya existe una membresia con la misma informacion
        IF EXISTS (SELECT 1 FROM Membresia WHERE nombre = @nombre AND duracion = @duracion AND costo = @costo)
        BEGIN
            SET @respuesta = 0;
            SET @mensaje = 'Ya existe una membresia con la misma informacion.';
            RETURN;
        END
	
	-- Si no se encuentra duplicado, proceder a agregar la nueva membresia
        INSERT INTO Membresia (nombre, duracion, fecha_creacion, costo, estado)
        VALUES (@nombre, @duracion, @fecha_creacion, @costo, @estado);

        SET @respuesta = 1;
        SET @mensaje = 'Membresia agregada exitosamente!';

    END TRY
    BEGIN CATCH
        SET @respuesta = 0;
        SET @mensaje = ERROR_MESSAGE();
    END CATCH
END;


CREATE PROCEDURE SP_EDITAR_MEMBRESIA
    @id_membresia INT,
	@nombre NVARCHAR(100),
    @duracion INT,
    @fecha_creacion DATE,
	@costo DECIMAL(10,2),
	@estado BIT,

    @respuesta INT OUTPUT,
    @mensaje NVARCHAR(500) OUTPUT
AS
BEGIN
    BEGIN TRY
        -- Verificar si existe la membresia con el ID dado
        IF NOT EXISTS (SELECT 1 FROM Membresia WHERE id_membresia = @id_membresia)
        BEGIN
            SET @respuesta = 0;
            SET @mensaje = 'La membresia no existe.';
            RETURN;
        END

        -- Actualizar membresia
        UPDATE  Membresia
        SET nombre = @nombre,
            duracion = @duracion,
            fecha_creacion = @fecha_creacion,
			costo = @costo,
			estado = @estado
        WHERE id_membresia = @id_membresia;

        SET @respuesta = 1;
        SET @mensaje = 'Membresia actualizada exitosamente.';
    END TRY
    BEGIN CATCH
        SET @respuesta = 0;
        SET @mensaje = ERROR_MESSAGE();
    END CATCH
END;

-- PROCEDIMIENTOS PARA AGREGAR - EDITAR UN MEDIO DE PAGO
CREATE PROCEDURE SP_AGREGAR_MEDIOPAGO
    @nombre NVARCHAR(100),
    @comision DECIMAL(5,2),
    @fechaCreacion DATE,
	@estado BIT,

    @respuesta INT OUTPUT,
    @mensaje NVARCHAR(500) OUTPUT
AS
BEGIN
    BEGIN TRY
	-- Verificar si ya existe un medio de pago con la misma informacion
        IF EXISTS (SELECT 1 FROM MedioDePago WHERE nombre = @nombre AND comision = @comision)
        BEGIN
            SET @respuesta = 0;
            SET @mensaje = 'Ya existe un medio de pago con la misma informacion.';
            RETURN;
        END
	
	-- Si no se encuentra duplicado, proceder a agregar la nueva membresia
        INSERT INTO MedioDePago (nombre, comision, fechaCreacion, estado)
        VALUES (@nombre, @comision, @fechaCreacion, @estado);

        SET @respuesta = 1;
        SET @mensaje = 'Medio de pago agregado exitosamente!';

    END TRY
    BEGIN CATCH
        SET @respuesta = 0;
        SET @mensaje = ERROR_MESSAGE();
    END CATCH
END;

CREATE PROCEDURE SP_EDITAR_MEDIOPAGO
    @id_medioPago INT,
	@nombre NVARCHAR(100),
    @comision DECIMAL(5,2),
    @fechaCreacion DATE,
	@estado BIT,

    @respuesta INT OUTPUT,
    @mensaje NVARCHAR(500) OUTPUT
AS
BEGIN
    BEGIN TRY
        -- Verificar si existe el medio de pago con el ID dado
        IF NOT EXISTS (SELECT 1 FROM MedioDePago WHERE id_medioPago = @id_medioPago)
        BEGIN
            SET @respuesta = 0;
            SET @mensaje = 'El medio de pago no existe.';
            RETURN;
        END

        -- Actualizar medio de pago
        UPDATE  MedioDePago
        SET nombre = @nombre,
            comision = @comision,
            fechaCreacion = @fechaCreacion,
			estado = @estado
        WHERE id_medioPago = @id_medioPago;

        SET @respuesta = 1;
        SET @mensaje = 'Medio de pago actualizado exitosamente.';
    END TRY
    BEGIN CATCH
        SET @respuesta = 0;
        SET @mensaje = ERROR_MESSAGE();
    END CATCH
END;

-- PERMISO PARA QUE UN ADM LISTE LOS PLANES
INSERT INTO Permiso(id_rol, nombreMenu)
VALUES (2, 'menuPlanes');


-- PROCEDIMIENTO PARA VERIFICAR SI EL ALUMNO ADEUDA CUOTA (DEVUELVE LA CANT DE MESES ADEUDADOS)
CREATE PROCEDURE SP_VerificarCuotaAlumno
    @id_alumno INT,
    @cuotaAlDia VARCHAR(10) OUTPUT,
    @mesesAdeudados INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ultimaFechaPago DATE;
    DECLARE @duracionMembresia INT;
    DECLARE @fechaCubierta DATE;
    
    -- Obtener la última fecha de pago y la duración de la membresía del alumno
    SELECT @ultimaFechaPago = MAX(p.fecha),
           @duracionMembresia = m.duracion
    FROM Pago p
    JOIN Alumno a ON p.id_alumno = a.id_alumno
    JOIN Membresia m ON a.id_membresia = m.id_membresia
    WHERE a.id_alumno = @id_alumno
    GROUP BY m.duracion;
    
    -- Calcular la fecha hasta dónde alcanza la membresía
    SET @fechaCubierta = DATEADD(DAY, @duracionMembresia, @ultimaFechaPago);
    
    -- Verificar si la fecha cubierta es mayor o igual a la fecha actual
    IF @fechaCubierta >= GETDATE()
    BEGIN
        SET @cuotaAlDia = 'Si';
        SET @mesesAdeudados = 0;
    END
    ELSE
    BEGIN
        SET @cuotaAlDia = 'No';
        
        -- Calcular la cantidad de meses adeudados
        SET @mesesAdeudados = DATEDIFF(MONTH, @fechaCubierta, GETDATE());
    END
END;

-- PROCEDIMIENTOS PARA LA BAJA, ALTA Y MODIFICACION DE UN ALUMNO

CREATE PROC SP_ELIMINARALUMNO(
   @id_alumno int,
   
   -- parametros de salida
   @respuesta bit output,
   @mensaje varchar(500) output
)
as
  set @respuesta = 0
  set @mensaje = ''

begin

     -- Eliminación lógica, se actualiza el campo 'estado' a 0 (inactivo)
      UPDATE Alumno SET estado = 0 WHERE id_alumno = @id_alumno

      SET @respuesta = 1
      SET @mensaje = 'El alumno ha sido dado de baja correctamente!'

end


CREATE PROC SP_RESTAURARALUMNO(
   @id_alumno int,
   
   -- parametros de salida
   @respuesta bit output,
   @mensaje varchar(500) output
)
as
  set @respuesta = 0
  set @mensaje = ''

begin

     -- Restauracion lógica, se actualiza el campo 'estado' a 1 (activo)
      UPDATE Alumno SET estado = 1 WHERE id_alumno = @id_alumno

      SET @respuesta = 1
      SET @mensaje = 'El alumno ha sido dado de alta correctamente!'

end


CREATE PROCEDURE SP_EDITARALUMNO
	@id_alumno INT,
    @id_usuario INT,
    @id_membresia INT,
    @id_plan INT,

    @nombre NVARCHAR(100),
    @apellido NVARCHAR(100),
    @email NVARCHAR(100),
    @telefono NVARCHAR(50),
    @foto NVARCHAR(MAX),
    @dni NVARCHAR(20),
    @fecha_nacimiento DATE,
    @contacto_emergencia NVARCHAR(100),
    @sexo NVARCHAR(10),
    @observaciones NVARCHAR(MAX),
    @estado BIT,

	-- parametros de salida
   @respuesta bit output,
   @mensaje varchar(500) output
AS
BEGIN
  set @respuesta = 0
  set @mensaje = ''

	IF NOT EXISTS (select * from Alumno where dni = @dni AND id_alumno != @id_alumno)
		BEGIN
			UPDATE Alumno SET
			id_usuario = @id_usuario,
			id_membresia = @id_membresia,
			id_plan = @id_plan,
			nombre = @nombre,
			apellido = @apellido,
			email = @email,
			telefono = @telefono,
			foto = @foto,
			dni = @dni,
			fecha_nacimiento = @fecha_nacimiento,
			contacto_emergencia = @contacto_emergencia,
			sexo = @sexo,
			observaciones = @observaciones,
			estado = @estado
			WHERE id_alumno = @id_alumno
			
	
			set @respuesta = 1 
			set @mensaje = 'Alumno actualizado exitosamente!'
		END
	ELSE
		set @mensaje = 'Ya existe un alumno registrado con el mismo DNI'

END




-- PROCEDIMIENTOS PARA LISTAR PAGOS Y SUS DETALLES
CREATE PROCEDURE SP_LISTAR_PAGOS
AS
BEGIN
    SELECT id_pago, id_usuario, id_alumno, id_medioPago, fecha, cantidad, total, recargo
    FROM Pago;
END;


CREATE PROCEDURE SP_LISTAR_DETALLES_PAGO
    @id_pago INT
AS
BEGIN
    SELECT id_pagoDetalle, id_pago, id_membresia, periodo, monto
    FROM PagoDetalle
    WHERE id_pago = @id_pago;
END;



-- PROCEDIMIENTOS PARA REPORTES

-- Alumnos activos con membresia, plan y coach
CREATE PROCEDURE SP_REPORTE_ALUMNOSACTIVOS
AS
BEGIN
    SELECT 
        a.nombre + ' ' + a.apellido AS Alumno,
        a.dni,
        a.fecha_nacimiento,
        a.sexo,
        a.email,
        a.telefono,
        m.nombre AS Membresia, 
        p.nombre AS PlanEntrenamiento,
        u.nombre + ' ' + u.apellido AS CoachAcargo
    FROM 
        Alumno a
        JOIN Membresia m ON a.id_membresia = m.id_membresia
        JOIN PlanEntrenamiento p ON a.id_plan = p.id_plan
        JOIN Usuario u ON u.id_usuario = a.id_usuario 
    WHERE 
        a.estado = 1;
END;
GO


-- Coachs con cantidad de alumnos y planes
CREATE PROCEDURE SP_REPORTE_COACHS
AS
BEGIN
    SELECT 
        u.nombre + ' ' + u.apellido AS Coach,
        u.dni,
        u.fecha_nacimiento,
        u.email,
        u.telefono,
        COUNT(DISTINCT a.id_alumno) AS CantidadAlumnos,
		COUNT(DISTINCT up.id_plan) AS CantidadPlanesEntrenamiento
    FROM 
        Usuario u
        JOIN Alumno a ON a.id_usuario = u.id_usuario
		JOIN Usuario_Plan up ON up.id_usuario = u.id_usuario
    WHERE 
        u.id_rol = 3 
    GROUP BY 
        u.nombre, u.apellido, u.dni, u.fecha_nacimiento, u.email, u.telefono;
END;
GO



-- Ingresos totales especificando año / mes 
CREATE PROCEDURE SP_REPORTE_TOTALINGRESOSMENSUALES
AS
BEGIN
    SELECT 
        YEAR(p.fecha) AS Año, 
        MONTH(p.fecha) AS Mes, 
        COUNT(p.id_pago) AS CantPagosMensuales, 
        SUM(p.total) AS TotalIngresos
    FROM 
        Pago p
    GROUP BY 
        YEAR(p.fecha), MONTH(p.fecha)
    ORDER BY 
        Año, Mes;
END;
GO


-- Reporte de planes de entrenamiento activos con cant de alumnos, cant coachs
CREATE PROCEDURE SP_REPORTE_DETALLEPLANESENTRENAMIENTO
AS
BEGIN
    SELECT 
        P.nombre AS PlanEntrenamiento,
        P.cantSeries,
        P.fechaInicio,
        P.fechaFin,
        COUNT(DISTINCT A.id_alumno) AS CantidadAlumnos,
        COUNT(DISTINCT up.id_usuario) AS CantidadCoachsAsociados,
        COUNT(DISTINCT pe.id_ejercicio) AS CantidadEjercicios
    FROM 
        PlanEntrenamiento P
        LEFT JOIN Alumno A ON P.id_plan = A.id_plan
        LEFT JOIN Usuario_Plan up ON up.id_plan = P.id_plan 
        LEFT JOIN Usuario u ON u.id_usuario = up.id_usuario 
        LEFT JOIN Plan_Ejercicio pe ON pe.id_plan = P.id_plan
        LEFT JOIN Ejercicio e ON e.id_ejercicio = pe.id_ejercicio
    WHERE 
        P.estado = 1 
    GROUP BY 
        P.nombre, P.fechaInicio, P.fechaFin, P.cantSeries, P.estado
    ORDER BY 
        CantidadAlumnos DESC;
END;
GO


-- Medios de pagos con su total de ingreso y cantidad de transacciones (POR FECHA)
CREATE PROCEDURE SP_REPORTE_OBTENERINGRESOSPORMEDIOPAGO
    @desde DATE,
    @hasta DATE
AS
BEGIN
    SELECT 
        MP.nombre AS MedioDePago,
        SUM(P.total) AS TotalRecaudado,
        COUNT(P.id_pago) AS CantidadTransacciones
    FROM 
        Pago P
        INNER JOIN MedioDePago MP ON P.id_medioPago = MP.id_medioPago
    WHERE 
        P.fecha BETWEEN @desde AND @hasta
    GROUP BY  
        MP.nombre
    ORDER BY 
        TotalRecaudado DESC;
END;
GO

-- Detalle pagos por alumnos (POR FECHA)
CREATE PROCEDURE SP_REPORTE_PAGOSPORALUMNO
    @desde DATE,
    @hasta DATE
AS
BEGIN
    SELECT  
        al.nombre + ' ' + al.apellido AS Alumno,
        p.fecha,
        p.total,
        mp.nombre AS MedioDePago, 
        m.nombre AS Membresia
    FROM 
        PagoDetalle pd
        JOIN Pago p ON pd.id_pago = p.id_pago
        JOIN Alumno al ON p.id_alumno = al.id_alumno
        JOIN MedioDePago mp ON p.id_medioPago = mp.id_medioPago
        JOIN Membresia m ON m.id_membresia = pd.id_membresia
    WHERE 
        p.fecha BETWEEN @desde AND @hasta
    ORDER BY 
        p.id_pago, pd.periodo;
END;
GO



-- Total de ingresos por membresia (POR FECHA)
CREATE PROCEDURE SP_REPORTE_INGRESOSPORMEMBRESIA
    @desde DATE,
    @hasta DATE
AS
BEGIN
    SELECT 
        m.nombre AS Membresia,
        m.duracion,
        SUM(pd.monto) AS Ingreso
    FROM 
        PagoDetalle pd
        JOIN Membresia m ON pd.id_membresia = m.id_membresia
        JOIN Pago p ON p.id_pago = pd.id_pago
    WHERE 
        p.fecha BETWEEN @desde AND @hasta
    GROUP BY 
        m.nombre, m.duracion;
END;
GO


-- CUOTAS ADEUDADAS Y FUTURAS DE ALUMNOS
CREATE PROCEDURE SP_ObtenerFechasAdeudadas
    @id_alumno INT
AS
BEGIN
   SET NOCOUNT ON;

    -- CTE para obtener la última fecha de pago del alumno y la duración de su membresía
    ;WITH UltimaFecha AS (
        SELECT 
            a.id_alumno,
            m.duracion,
            MAX(p.fecha) AS ultimaFechaPago
        FROM 
            Alumno a
        JOIN 
            Membresia m ON a.id_membresia = m.id_membresia
        LEFT JOIN 
            Pago p ON a.id_alumno = p.id_alumno
        WHERE 
            a.id_alumno = @id_alumno
        GROUP BY 
            a.id_alumno, m.duracion
    ),
    FechasAdeudadas AS (
        -- Generar fechas de pago a partir de la última fecha de pago
        SELECT 
            u.id_alumno,
            DATEADD(DAY, (ROW_NUMBER() OVER (ORDER BY (SELECT NULL))) * u.duracion, u.ultimaFechaPago) AS fecha_adeudada
        FROM 
            UltimaFecha u
        CROSS APPLY 
            (SELECT 1 UNION ALL SELECT 2 UNION ALL SELECT 3 UNION ALL SELECT 4 
             UNION ALL SELECT 5 UNION ALL SELECT 6 UNION ALL SELECT 7 UNION ALL SELECT 8
             UNION ALL SELECT 9 UNION ALL SELECT 10 UNION ALL SELECT 11 UNION ALL SELECT 12) AS n(n)
    )
    -- Selecciona las fechas de pago vencidas y la correspondiente al mes actual
    SELECT 
        a.id_alumno,
        a.nombre,
        a.apellido,
		a.dni,
        f.fecha_adeudada,
		m.nombre AS nombreMembresia,
		m.costo
    FROM 
        FechasAdeudadas f
    JOIN 
        Alumno a ON f.id_alumno = a.id_alumno
    JOIN 
        UltimaFecha u ON u.id_alumno = a.id_alumno
	JOIN 
		Membresia m ON m.id_membresia = a.id_membresia
    WHERE 
        -- Solo fechas vencidas o la del próximo pago dentro del mes actual
        f.fecha_adeudada <= GETDATE() -- Filtra solo las fechas de pago vencidas
        OR (MONTH(f.fecha_adeudada) = MONTH(GETDATE()) AND YEAR(f.fecha_adeudada) = YEAR(GETDATE())) -- Y la fecha correspondiente al mes actual
    ORDER BY 
        f.fecha_adeudada;

END;

