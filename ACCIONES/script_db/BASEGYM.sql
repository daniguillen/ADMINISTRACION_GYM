create database GymBase
go 
use GymBase
go 
create TABLE NIVEL(
ID INT PRIMARY KEY CHECK (ID BETWEEN 1 AND 3),
Nivel_Acceso varchar(50),
)
GO
CREATE TABLE DIA(
ID INT NOT NULL PRIMARY KEY CHECK (ID BETWEEN 1 AND 7),
NOMBRE_DIA VARCHAR(20) NOT NULL UNIQUE
)
GO
CREATE TABLE PLANES(
ID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
CUOTA MONEY,
TIPO_PLAN VARCHAR(10) NOT NULL,
DESCRIPCION VARCHAR(500) not null,
)
GO
create table USUARIO
(
ID INT identity (1,1) primary key, 
MAIL VARCHAR(100) NOT NULL unique,
PASWORD nVARCHAR(100) NOT NULL,
IDNIVEL INT NOT NULL FOREIGN KEY REFERENCES NIVEL(ID),


)
GO
CREATE TABLE ESTABLECIMIENTO(
ID INT identity (1,1) PRIMARY KEY,
CUIT INT NOT NULL,
DESCRIPCION VARCHAR(200) ,
DIRECCION VARCHAR (200),
NOMBRE VARCHAR (200),
)
GO
CREATE TABLE DIFICULTAD(
ID INT PRIMARY KEY,
DESCRIPCION VARCHAR (100))
GO
CREATE TABLE GRUPO_MUSCULAR(
ID INT IDENTITY (1,1) PRIMARY KEY,
DESCRIPCION VARCHAR(100))
GO
CREATE TABLE TIPO_EJERCICIO(
ID INT IDENTITY (1,1) PRIMARY KEY,
DESCRIPCION VARCHAR(100))
GO
CREATE TABLE EJERCICIO(
ID INT IDENTITY (1,1) PRIMARY KEY,
DESCRIPCION VARCHAR(1000),
NOMBRE VARCHAR (100) NOT NULL,
REPETICIONES INT NOT NULL,
ID_DIFICULTAD INT FOREIGN KEY REFERENCES DIFICULTAD(ID),
VIDEO NVARCHAR(1000) NOT NULL,
ID_TIPO INT NOT NULL REFERENCES TIPO_EJERCICIO(ID),
ID_GRUPO_MUSCULAR INT NOT NULL REFERENCES GRUPO_MUSCULAR(ID)
)	

GO
CREATE TABLE SEXO(
ID INT PRIMARY KEY,
TIPO VARCHAR (20)
)

GO
CREATE TABLE RUTINA(
ID INT PRIMARY KEY IDENTITY (1,1) ,
NOMBRE VARCHAR(50) NOT NULL,
DESCRIPCION VARCHAR(300),
PERSONAL BIT NOT NULL DEFAULT 0,
ESTADO BIT NOT NULL DEFAULT 1,

)
GO
CREATE TABLE RUTINA_EJERCICIO (
    ID INT  PRIMARY KEY IDENTITY(1,1),
    ID_RUTINA INT NOT NULL REFERENCES RUTINA(ID),
    ID_EJERCICIO INT NOT NULL FOREIGN KEY REFERENCES EJERCICIO(ID),
	ID_DIA INT NOT NULL FOREIGN KEY REFERENCES DIA(ID),
	HORARIO INT NOT NULL CHECK(HORARIO BETWEEN 6 AND 22)
)
GO
CREATE TABLE PERSONA
(
ID INT IDENTITY (1,1)PRIMARY KEY,
ID_USUARIO INT NOT NULL FOREIGN KEY REFERENCES USUARIO(ID),
APELLIDO VARCHAR(100)NOT NULL,
NOMBRE VARCHAR(100) NOT NULL,
APTO_FISICO NVARCHAR(1000),
CELULAR VARCHAR(50)NOT NULL,
DIRECCION NVARCHAR (500)NOT NULL,
DNI VARCHAR(50) NOT NULL UNIQUE,
FECHA_INGRESO DATETIME NOT NULL,
FECHA_BAJA DATETIME,
FECHA_NACIMIENTO DATETIME NOT NULL,
FOTO NVARCHAR(1000),
IDPLANES INT NOT NULL FOREIGN KEY REFERENCES PLANES(ID),
SEXO INT FOREIGN KEY REFERENCES SEXO(ID),
TEL_EMERGENCIA VARCHAR(50) NOT NULL,
ID_ESTABLECIMIENTO INT NOT NULL FOREIGN KEY REFERENCES ESTABLECIMIENTO(ID),
ESTADO BIT NOT NULL DEFAULT 1, 
ID_RUTINA INT FOREIGN KEY REFERENCES RUTINA (ID),
)
;

create table Historial(
    id int primary key identity(1,1),
    Id_Persona int foreign key references Persona (id) not null, 
    ID_Planes int not null,
    Pago money not null,
    FechaPago DATETIME DEFAULT GETDATE() NOT NULL,
    DescripcionNota varchar (100)
);
create table Mensajes(
    id int primary key identity(1,1),
    DescripcionNota varchar (200),
    FechaMensaje DATETIME DEFAULT GETDATE() NOT NULL,
);


-- Insertar valores en NIVEL

INSERT INTO NIVEL (ID, Nivel_Acceso)
VALUES 
(1, 'USUARIO'),
(2, 'INSTRUCTOR'),
(3, 'ADMINISTRADOR');
GO
INSERT INTO DIA (ID, NOMBRE_DIA)
VALUES 
(1, 'LUNES'),
(2, 'MARTES'),
(3, 'MIERCOLES'),
(4, 'JUEVES'),
(5, 'VIERNES'),
(6, 'SABADO'),
(7, 'DOMINGO');
GO

INSERT INTO SEXO(ID, TIPO)
VALUES
(1, 'MASCULINO'),
(2, 'FEMININO'),
(3, 'BINARIO'),
(4, 'S/D');
GO
-- Insertar valores en PLANES
INSERT INTO PLANES ( CUOTA, TIPO_PLAN, DESCRIPCION)
VALUES 
( 50.00, 'Básico', 'Plan básico con acceso a todos los equipos del gimnasio'),
( 70.00, 'Estándar', 'Plan estándar con clases grupales adicionales'),
( 90.00, 'Premium', 'Plan premium con entrenador personal y guía nutricional'),
( 00.00, 'Empleado', 'Beneficio para empleados');
GO

-- Insertar valores en USUARIO
INSERT INTO USUARIO (MAIL, PASWORD, IDNIVEL )
VALUES 
('usuario1@example.com', 'contraseña1',1 ),
('usuario2@example.com', 'contraseña2',1),
('usuario3@example.com', 'contraseña3',1),
('usuario4@example.com', 'contraseña4',1),
('usuario5@example.com', 'contraseña5',1),
('usuario6@example.com', 'contraseña6',1),
('usuario7@example.com', 'contraseña7',1),
('usuario8@example.com', 'contraseña8',1),
('usuario9@example.com', 'contraseña9',1),
('usuario10@example.com', 'contraseña10',1),
('usuario11@example.com', 'contraseña11',1),
('usuario12@example.com', 'contraseña12',1),
('usuario13@example.com', 'contraseña13',1),
('usuario14@example.com', 'contraseña14',1),
('usuario15@example.com', 'contraseña15',1),
('usuario16@example.com', 'contraseña16',1),
('usuario17@example.com', 'contraseña17',1),
('usuario18@example.com', 'contraseña18',2),
('usuario19@example.com', 'contraseña19',2),
('usuario20@example.com', 'contraseña20',2),
('usuario21@example.com', 'contraseña21',2),
('usuario22@example.com', 'contraseña22',2),
('usuario23@example.com', 'contraseña23',2),
('usuario24@example.com', 'contraseña24',2),
('usuario25@example.com', 'contraseña25',2),
('usuario26@example.com', 'contraseña26',2),
('usuario27@example.com', 'contraseña27',2),
('usuario28@example.com', 'contraseña28',3),
('usuario29@example.com', 'contraseña29',3),
('usuario30@example.com', 'contraseña30',3);
GO

-- Insertar valores en ESTABLECIMIENTO
INSERT INTO ESTABLECIMIENTO (CUIT, DESCRIPCION, DIRECCION, NOMBRE)
VALUES 
(123456789, 'Gimnasio Principal', 'Calle Principal 123, Ciudad', 'Gimnasio Atila'),
(987654321, 'Gimnasio Sucursal Norte', 'Calle Norte 456, Pueblo', 'Gimnasio Afrika');
GO

-- Insertar valores en DIFICULTAD
INSERT INTO DIFICULTAD (ID, DESCRIPCION)
VALUES 
(1,'Fácil'),
(2,'Medio'),
(3,'Difícil');
GO

-- Insertar valores en GRUPO_MUSCULAR
INSERT INTO GRUPO_MUSCULAR (DESCRIPCION)
VALUES 
('Pecho'),
('Espalda'),
('Piernas'),
('Brazos'),
('Hombros'),
('Abdominales');
GO

-- Insertar valores en TIPO_EJERCICIO
INSERT INTO TIPO_EJERCICIO (DESCRIPCION)
VALUES 
('Entrenamiento de fuerza'),
('Cardio'),
('Flexibilidad'),
('Equilibrio');
GO

-- Insertar valores en EJERCICIO
INSERT INTO EJERCICIO (DESCRIPCION, NOMBRE, REPETICIONES, ID_DIFICULTAD, VIDEO, ID_TIPO, ID_GRUPO_MUSCULAR)
VALUES 
-- Grupo Muscular 1: Pecho
('Descripción de Press de Banca', 'Press de Banca', 10, 2, 'pressbanca.mp4', 1, 1),
('Descripción de Aperturas con mancuernas', 'Aperturas con mancuernas', 12, 2, 'aperturas.mp4', 1, 1),
('Descripción de Fondos', 'Fondos', 15, 3, 'fondos.mp4', 1, 1),
('Descripción de Press inclinado', 'Press inclinado', 10, 2, 'pressinclinado.mp4', 1, 1),
('Descripción de Press declinado', 'Press declinado', 10, 2, 'pressdeclinado.mp4', 1, 1),
('Descripción de Peck Deck', 'Peck Deck', 12, 2, 'peckdeck.mp4', 1, 1),
('Descripción de Press con mancuernas', 'Press con mancuernas', 10, 2, 'pressmancuernas.mp4', 1, 1),
('Descripción de Cruce de cables', 'Cruce de cables', 15, 2, 'crucecables.mp4', 1, 1),
('Descripción de Press de banca agarre cerrado', 'Press de banca agarre cerrado', 10, 3, 'presscerrado.mp4', 1, 1),
('Descripción de Push Ups', 'Push Ups', 20, 1, 'pushups.mp4', 1, 1),
-- Grupo Muscular 2: Espalda
('Descripción de Peso Muerto', 'Peso Muerto', 8, 3, 'pesomuerto.mp4', 1, 2),
('Descripción de Remo con barra', 'Remo con barra', 12, 3, 'remobarra.mp4', 1, 2),
('Descripción de Jalón al pecho', 'Jalón al pecho', 15, 2, 'jalonpecho.mp4', 1, 2),
('Descripción de Pull Ups', 'Pull Ups', 10, 3, 'pullups.mp4', 1, 2),
('Descripción de Remo con mancuernas', 'Remo con mancuernas', 12, 2, 'remomancuernas.mp4', 1, 2),
('Descripción de Remo en máquina', 'Remo en máquina', 15, 2, 'remomaquina.mp4', 1, 2),
('Descripción de Jalón tras nuca', 'Jalón tras nuca', 12, 3, 'jalonnuca.mp4', 1, 2),
('Descripción de Peso muerto rumano', 'Peso muerto rumano', 10, 3, 'pesoromano.mp4', 1, 2),
('Descripción de Hiperextensiones', 'Hiperextensiones', 15, 1, 'hiperextensiones.mp4', 1, 2),
('Descripción de Dominadas asistidas', 'Dominadas asistidas', 12, 2, 'dominadasasistidas.mp4', 1, 2),
-- Grupo Muscular 3: Piernas
('Descripción de Sentadilla', 'Sentadilla', 15, 3, 'sentadilla.mp4', 1, 3),
('Descripción de Prensa de pierna', 'Prensa de pierna', 12, 2, 'prensapierna.mp4', 1, 3),
('Descripción de Extensiones de pierna', 'Extensiones de pierna', 15, 1, 'extensionpierna.mp4', 1, 3),
('Descripción de Curl de pierna', 'Curl de pierna', 12, 2, 'curlpierna.mp4', 1, 3),
('Descripción de Peso muerto sumo', 'Peso muerto sumo', 10, 3, 'pesosumo.mp4', 1, 3),
('Descripción de Zancadas', 'Zancadas', 12, 2, 'zancadas.mp4', 1, 3),
('Descripción de Sentadilla búlgara', 'Sentadilla búlgara', 10, 3, 'sentabúlgara.mp4', 1, 3),
('Descripción de Peso muerto a una pierna', 'Peso muerto a una pierna', 12, 3, 'peso1pierna.mp4', 1, 3),
('Descripción de Elevación de talones', 'Elevación de talones', 20, 1, 'elevacióntalones.mp4', 1, 3),
('Descripción de Hack Squat', 'Hack Squat', 12, 2, 'hacksquat.mp4', 1, 3),
-- Grupo Muscular 4: Biceps
('Descripción de Curl de Bíceps', 'Curl de Bíceps', 12, 1, 'curlbiceps.mp4', 1, 4),
('Descripción de Curl con barra', 'Curl con barra', 10, 2, 'curlbarra.mp4', 1, 4),
('Descripción de Curl martillo', 'Curl martillo', 15, 1, 'curlmartillo.mp4', 1, 4),
('Descripción de Curl en predicador', 'Curl en predicador', 12, 2, 'curlpredicador.mp4', 1, 4),
('Descripción de Curl concentrado', 'Curl concentrado', 10, 2, 'curlconcentrado.mp4', 1, 4),
('Descripción de Curl con polea baja', 'Curl con polea baja', 12, 2, 'curlpolea.mp4', 1, 4),
('Descripción de Curl spider', 'Curl spider', 10, 2, 'curlspider.mp4', 1, 4),
('Descripción de Curl con mancuerna en banco inclinado', 'Curl con mancuerna en banco inclinado', 15, 1, 'curlinclinadomp4', 1, 4),
('Descripción de Curl Zottman', 'Curl Zottman', 12, 2, 'curlzottman.mp4', 1, 4),
('Descripción de Curl con cuerda en polea', 'Curl con cuerda en polea', 10, 2, 'curlcuerda.mp4', 1, 4),
-- Grupo Muscular 5:Hombros
('Descripción de Press de Hombros', 'Press de Hombros', 10, 2, 'presshombros.mp4', 1, 5),
('Descripción de Elevaciones laterales', 'Elevaciones laterales', 12, 1, 'elevlaterales.mp4', 1, 5),
('Descripción de Elevaciones frontales', 'Elevaciones frontales', 15, 1, 'elevfrontales.mp4', 1, 5),
('Descripción de Pájaros', 'Pájaros', 12, 2, 'pajaros.mp4', 1, 5),
('Descripción de Press militar', 'Press militar', 10, 3, 'pressmilitar.mp4', 1, 5),
('Descripción de Remo al mentón', 'Remo al mentón', 15, 2, 'remoalmenton.mp4', 1, 5),
('Descripción de Press Arnold', 'Press Arnold', 12, 2, 'pressarnold.mp4', 1, 5),
('Descripción de Elevaciones posteriores', 'Elevaciones posteriores', 15, 2, 'elevposteriores.mp4', 1, 5),
('Descripción de Encogimientos', 'Encogimientos', 20, 1, 'encogimientos.mp4', 1, 5),
('Descripción de Face Pulls', 'Face Pulls', 12, 2, 'facepulls.mp4', 1, 5),
-- Grupo Muscular 6:Abdomen
('Descripción de Abdominales', 'Abdominales', 20, 1, 'abdominales.mp4', 3, 6),
('Descripción de Plancha', 'Plancha', 30, 2, 'plancha.mp4', 3, 6),
('Descripción de Elevación de piernas', 'Elevación de piernas', 15, 1, 'elevpiernas.mp4', 3, 6),
('Descripción de Crunch', 'Crunch', 20, 1, 'crunch.mp4', 3, 6),
('Descripción de Bicicleta', 'Bicicleta', 20, 1, 'bicicleta.mp4', 3, 6),
('Descripción de Russian Twist', 'Russian Twist', 15, 2, 'russiantwist.mp4', 3, 6),
('Descripción de Mountain Climbers', 'Mountain Climbers', 20, 2, 'mountainclimbers.mp4', 3, 6),
('Descripción de Elevación de rodillas', 'Elevación de rodillas', 15, 2, 'elevrodillas.mp4', 3, 6),
('Descripción de Crunch inverso', 'Crunch inverso', 20, 1, 'crunchinverso.mp4', 3, 6),
('Descripción de Ab Wheel Rollout', 'Ab Wheel Rollout', 15, 3, 'abwheel.mp4', 3, 6);

GO

-- Insertar valores en PERSONA
INSERT INTO PERSONA (ID_USUARIO, APELLIDO, NOMBRE, APTO_FISICO, CELULAR, DIRECCION, DNI, FECHA_INGRESO, FECHA_NACIMIENTO, FOTO, IDPLANES, SEXO, TEL_EMERGENCIA, ID_ESTABLECIMIENTO, ESTADO)
VALUES 
(1, 'Pérez', 'Juan', 'Apto', '123-456-7890', 'Calle Principal 123', '12345677', '2022-01-01', '1990-01-01', 'foto1.jpg', 1, 1, '123-456-7891', 1, 1),
(2, 'Gómez', 'María', 'Apto', '234-567-8901', 'Calle Norte 456', '23456789', '2022-02-01', '1992-02-02', 'foto2.jpg', 2, 1, '234-567-8902', 2, 1),
(3, 'Rodríguez', 'Carlos', 'Apto', '345-678-9012', 'Calle Este 789', '34567892', '2022-03-01', '1988-03-03', 'foto3.jpg', 3, 1, '345-678-9013', 1, 1),
(4, 'Fernández', 'Lucía', 'Apto', '456-789-0123', 'Calle Sur 101', '45678903', '2022-04-01', '1991-04-04', 'foto4.jpg', 1, 1, '456-789-0124', 2, 1),
(5, 'López', 'Marta', 'Apto', '567-890-1234', 'Avenida Central 202', '56789013', '2022-05-01', '1987-05-05', 'foto5.jpg', 2, 2, '567-890-1235', 1, 1),
(6, 'Martínez', 'Jorge', 'Apto', '678-901-2345', 'Calle Oeste 303', '67890123', '2022-06-01', '1993-06-06', 'foto6.jpg', 3, 2, '678-901-2346', 2, 1),
(7, 'Sánchez', 'Ana', 'Apto', '789-012-3456', 'Calle Norte 404', '78901234', '2022-07-01', '1989-07-07', 'foto7.jpg', 1, 1, '789-012-3457', 1, 1),
(8, 'Ramírez', 'Luis', 'Apto', '890-123-4567', 'Calle Este 505', '89012345', '2022-08-01', '1990-08-08', 'foto8.jpg', 2, 1, '890-123-4568', 2, 1),
(9, 'Hernández', 'Laura', 'Apto', '901-234-5678', 'Calle Sur 606', '90123456', '2022-09-01', '1994-09-09', 'foto9.jpg', 3, 2, '901-234-5679', 1, 1),
(10, 'García', 'Miguel', 'Apto', '012-345-6789', 'Avenida Principal 707', '01234567', '2022-10-01', '1985-10-10', 'foto10.jpg', 1, 3, '012-345-6790', 2, 1),
(11, 'Ruiz', 'Sofía', 'Apto', '123-456-7890', 'Calle Oeste 808', '22222222', '2022-11-01', '1991-11-11', 'foto11.jpg', 2, 4, '123-456-7891', 1, 1),
(12, 'Torres', 'Alberto', 'Apto', '234-567-8901', 'Calle Norte 909', '33333333', '2022-12-01', '1988-12-12', 'foto12.jpg', 3, 1, '234-567-8902', 2, 1),
(13, 'Ramón', 'Carmen', 'Apto', '345-678-9012', 'Calle Sur 1010', '34567890', '2023-01-01', '1992-01-13', 'foto13.jpg', 1, 1, '345-678-9013', 1, 1),
(14, 'Moreno', 'Javier', 'Apto', '456-789-0123', 'Avenida Central 1111', '45678901', '2023-02-01', '1990-02-14', 'foto14.jpg', 2, 1, '456-789-0124', 2, 1),
(15, 'Rojas', 'Isabel', 'Apto', '567-890-1234', 'Calle Oeste 1212', '56789012', '2023-03-01', '1989-03-15', 'foto15.jpg', 3, 2, '567-890-1235', 1, 1),
(16, 'Flores', 'Pedro', 'Apto', '678-901-2345', 'Calle Norte 1313', '67890124', '2023-04-01', '1988-04-16', 'foto16.jpg', 1, 1, '678-901-2346', 2, 1),
(17, 'Vargas', 'Elena', 'Apto', '789-012-3456', 'Calle Este 1414', '78901235', '2023-05-01', '1993-05-17', 'foto17.jpg', 2, 2, '789-012-3457', 1, 1),
(18, 'Díaz', 'Felipe', 'Apto', '890-123-4567', 'Calle Sur 1515', '89012346', '2023-06-01', '1991-06-18', 'foto18.jpg', 3, 1, '890-123-4568', 2, 1),
(19, 'Álvarez', 'Raquel', 'Apto', '901-234-5678', 'Avenida Principal 1616', '90123457', '2023-07-01', '1994-07-19', 'foto19.jpg', 1, 2, '901-234-5679', 1, 1),
(20, 'Romero', 'Tomás', 'Apto', '012-345-6789', 'Calle Oeste 1717', '01234561', '2023-08-01', '1985-08-20', 'foto20.jpg', 2, 2, '012-345-6790', 2, 1),
(21, 'Navarro', 'Carla', 'Apto', '123-456-7890', 'Calle Norte 1818', '99999999', '2023-09-01', '1991-09-21', 'foto21.jpg', 3, 1, '123-456-7891', 1, 1),
(22, 'Molina', 'Pablo', 'Apto', '234-567-8901', 'Calle Este 1919', '23456787', '2023-10-01', '1988-10-22', 'foto22.jpg', 1, 2, '234-567-8902', 2, 1),
(23, 'Silva', 'Beatriz', 'Apto', '345-678-9012', 'Calle Sur 2020', '34567897', '2023-11-01', '1992-11-23', 'foto23.jpg', 2, 2, '345-678-9013', 1, 1),
(24, 'Cruz', 'Andrés', 'Apto', '456-789-0123', 'Avenida Central 2121', '45678908', '2023-12-01', '1990-12-24', 'foto24.jpg', 3, 1, '456-789-0124', 2, 1),
(25, 'Ortega', 'Sandra', 'Apto', '567-890-1234', 'Calle Oeste 2222', '56789018', '2024-01-01', '1989-01-25', 'foto25.jpg', 1, 2, '567-890-1235', 1, 1),
(26, 'Castro', 'David', 'Apto', '678-901-2345', 'Calle Norte 2323', '67890129', '2024-02-01', '1993-02-26', 'foto26.jpg', 2, 1, '678-901-2346', 2, 1),
(27, 'Ramos', 'Verónica', 'Apto', '789-012-3456', 'Calle Este 2424', '78901230', '2024-03-01', '1990-03-27', 'foto27.jpg', 3, 2, '789-012-3457', 1, 1),
(28, 'Reyes', 'Francisco', 'Apto', '890-123-4567', 'Calle Sur 2525', '89012340', '2024-04-01', '1991-04-28', 'foto28.jpg', 1, 1, '890-123-4568', 2, 1),
(29, 'Jiménez', 'Sonia', 'Apto', '901-234-5678', 'Avenida Principal 2626', '90123450', '2024-05-01', '1994-05-29', 'foto29.jpg', 2, 2, '901-234-5679', 1, 1),
(30, 'Serrano', 'Alfredo', 'Apto', '012-345-6789', 'Calle Oeste 2727', '01234565', '2024-06-01', '1985-06-30', 'foto30.jpg', 3, 1, '012-345-6790', 2, 1);
GO

-- Insertar valores en RUTINA


INSERT INTO RUTINA ( NOMBRE,DESCRIPCION, PERSONAL, ESTADO)
VALUES('Pecho', 'Rutina enfocada en ejercicios de pecho', 0, 1),
('Espalda', 'Rutina enfocada en ejercicios de espalda', 0, 1),
('Piernas', 'Rutina enfocada en ejercicios de piernas', 0, 1),
('Bíceps', 'Rutina enfocada en ejercicios de bíceps', 0, 1),
('Hombros', 'Rutina enfocada en ejercicios de hombros', 0, 1),
('Abdomen', 'Rutina enfocada en ejercicios de abdomen', 0, 1);
GO

INSERT INTO RUTINA_EJERCICIO (ID_RUTINA,ID_DIA, ID_EJERCICIO, HORARIO)
VALUES
--Pecho
(1, 1, 1, 7),
(1, 1, 2, 7),
-- Espalda
(2, 2, 11, 7),
(2, 2, 14, 7),
-- Piernas
(3, 3, 22, 7), 
(3, 3, 25, 7),
-- Bíceps
(4, 4, 33, 7), 
(4, 4, 34, 7),
-- Hombros
(5, 5, 42, 7),
(5, 5, 47, 7),
-- Abdomen
(6, 6, 56, 7), 
(6, 6, 57, 7);
GO
create or alter procedure SP_Nuevo_cliente (
@mail varchar(100), 
@pasword nvarchar(100), 
@apellido varchar(100), 
@nombre varchar(100), 
@aptofisico nvarchar(100), 
@celular varchar(100), 
@direccion nvarchar(100), 
@dni varchar(100), 
@fecha_nacimiento datetime,
@foto nvarchar(100), 
@idplan int,
@sexo int,
@tel_emergencia varchar(100), 
@id_establecimiento int,
@id_rutina int
)
as begin

insert into USUARIO (MAIL, PASWORD, IDNIVEL) values (@mail,@pasword, 1)
declare @ID_usuario int;
select @ID_usuario=SCOPE_IDENTITY() FROM USUARIO

insert into PERSONA (ID_USUARIO, APELLIDO, NOMBRE, APTO_FISICO, CELULAR, DIRECCION, dni, FECHA_INGRESO, FECHA_NACIMIENTO, foto, IDPLANES, SEXO, TEL_EMERGENCIA, ID_ESTABLECIMIENTO, ID_RUTINA)
values (@ID_usuario,@apellido,@nombre,@aptofisico,@celular,@direccion,@dni,GETDATE(),@fecha_nacimiento,@foto,@idplan,@sexo,@tel_emergencia,@id_establecimiento,1)
end

GO

CREATE OR ALTER PROCEDURE SP_Modificar_Cliente (
    @ID INT,
    @PASS NVARCHAR(100), 
    @MAIL VARCHAR(100), 
    @Nombre VARCHAR(100), 
    @Apellido VARCHAR(100), 
    @Direccion VARCHAR(100), 
    @FechaNacimiento DATETIME,
    @Sexo INT,
    @Foto NVARCHAR(100), 
    @DNI VARCHAR(100), 
    @AptoFisico NVARCHAR(100), 
    @TelEmergencia VARCHAR(100), 
    @Celular VARCHAR(100), 
	@FechaIngreso DATETIME,
    @IDPlanes INT,
    @IDEstablecimiento INT,
    @Estado INT,
    @IDRutina INT
)
AS
BEGIN
    UPDATE PERSONA
    SET 
        APELLIDO = @Apellido,
        NOMBRE = @Nombre,
        APTO_FISICO = @AptoFisico,
        CELULAR = @Celular,
        DIRECCION = @Direccion,
        DNI = @DNI,
        FECHA_INGRESO = GETDATE(),
        FECHA_NACIMIENTO = @FechaNacimiento,
        FOTO = @Foto,
        IDPLANES = @IDPlanes,
        SEXO = @Sexo,
        TEL_EMERGENCIA = @TelEmergencia,
        ID_ESTABLECIMIENTO = @IDEstablecimiento,
        ESTADO = @Estado,
        ID_RUTINA = @IDRutina
    WHERE ID = @ID;
    UPDATE USUARIO
    SET 
        PASWORD = @PASS
    WHERE MAIL = @MAIL
END;