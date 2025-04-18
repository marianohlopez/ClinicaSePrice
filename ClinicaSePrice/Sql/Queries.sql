#-- Creates database

CREATE DATABASE IF NOT EXISTS CLinicaSePrice;

USE CLinicaSePrice;

SET FOREIGN_KEY_CHECKS = 0;
#--	Executes drop sentences
DROP TABLE IF EXISTS users;
DROP TABLE IF EXISTS Especialidades;
DROP TABLE IF EXISTS Medicos;
DROP TABLE IF EXISTS Pacientes;
DROP TABLE IF EXISTS Estudios;
DROP TABLE IF EXISTS Horarios_Turnos;
DROP TABLE IF EXISTS Turnos_Reservados;
DROP TABLE IF EXISTS insumos;
DROP PROCEDURE IF EXISTS Login;
#-------------------------------------------------

#--	Creates all needed tables

CREATE TABLE IF NOT EXISTS users(
	ID int AUTO_INCREMENT,
	Username varchar (20) UNIQUE KEY NOT NULL,
	FirstName VARCHAR (20) NOT NULL,
	LastName varchar (20) NOT NULL,
	Pass varchar (15) NOT NULL,
	Phone varchar (20) DEFAULT NULL,
	Email varchar(50) NOT NULL, 
	Birthdate date,
	UserRole varchar(20) DEFAULT 'Admin',
	ActiveUser boolean DEFAULT TRUE,
	CONSTRAINT userPK PRIMARY KEY (ID)
);

CREATE TABLE IF NOT EXISTS insumos(
	ID INT AUTO_INCREMENT PRIMARY KEY,
	Name varchar (20) UNIQUE KEY NOT NULL,
	Amount INT DEFAULT 0,
	ReStock boolean DEFAULT TRUE
);

CREATE TABLE IF NOT EXISTS Especialidades (
  ID INT AUTO_INCREMENT PRIMARY KEY,
  Especialidad VARCHAR(100)
);

CREATE TABLE IF NOT EXISTS Medicos (
  ID INT AUTO_INCREMENT PRIMARY KEY,
  Nombre VARCHAR(100),
  Apellido VARCHAR(100),
  ID_Especialidad INT,
  FOREIGN KEY (ID_Especialidad) REFERENCES Especialidades(ID)
);

CREATE TABLE IF NOT EXISTS Pacientes (
  ID INT AUTO_INCREMENT PRIMARY KEY,
  Nombre VARCHAR(100),
  Apellido VARCHAR(100),
  DNI VARCHAR(10),
  Telefono VARCHAR(15)
);

CREATE TABLE IF NOT EXISTS Estudios (
ID INT AUTO_INCREMENT PRIMARY KEY,
PacienteID INT NOT NULL,
EspecialidadID VARCHAR(100),
FechaEstudio DATE,
SeccionID VARCHAR(5),
EstadoEstudio BOOLEAN DEFAULT 1,
FOREIGN KEY (PacienteID) REFERENCES Pacientes(ID)
);

CREATE TABLE IF NOT EXISTS Horarios_Turnos (
  ID INT AUTO_INCREMENT PRIMARY KEY,
  ID_Medico INT,
  Dia_Semana VARCHAR(50),
  Hora_Inicio TIME,
  Hora_Fin TIME,
  FOREIGN KEY (ID_Medico) REFERENCES Medicos(ID)
);

CREATE TABLE IF NOT EXISTS Turnos_Reservados (
  ID INT AUTO_INCREMENT PRIMARY KEY,
  ID_Medico INT,
  Fecha_Turno DATE,
  Hora_Turno TIME,
  ID_Paciente INT,
  FOREIGN KEY (ID_Medico) REFERENCES Medicos(ID),
  FOREIGN KEY (ID_Paciente) REFERENCES Pacientes(ID),
  Acreditado BOOLEAN DEFAULT 0		
);

#--	Inserts startup data into database

INSERT INTO users(Username, FirstName, LastName, Pass, Phone, Email, Birthdate, UserRole) 
VALUES
('tester', 'Usuario', 'Prueba', '123456', '5465465', 'ml@jaja.com', '1945-12-30', 'Admin');

INSERT INTO Especialidades (Especialidad)
VALUES 
  ('Cardiología'),
  ('Dermatología'),
  ('Neurología'),
  ('Radiografía'),
  ('Tomografía'),
  ('Laboratorio'),
  ('Resonancia');

INSERT INTO Medicos (Nombre, Apellido, ID_Especialidad)
VALUES 
  ('Juan', 'Pérez', 1),
  ('María', 'López', 2),
  ('Pedro', 'Gómez', 3),
  ('Radiografía', 'Especialista', 4),
  ('Tomografía', 'Especialista', 5),
  ('Laboratorio', 'Especialista', 6),
  ('Resonancia', 'Especialista', 7);

INSERT INTO Pacientes (Nombre, Apellido, DNI, Telefono)
VALUES 
  ('Ana', 'Martínez', '12345678', '555-1234'),
  ('Luis', 'García', '87654321', '555-5678');

INSERT INTO Estudios (PacienteID, EspecialidadID, FechaEstudio, SeccionID, EstadoEstudio)
VALUES 
    (1, 'Radiografía(RX)', CURDATE(), 'A1', 1), 
    (2, 'Tomografía(TC)', CURDATE(), 'B2', 1), 
    (1, 'Tomografía(TC)', CURDATE(), 'A3', 1), 
    (2, 'Radiografía(RX)', CURDATE(), 'B1', 1);
  
INSERT INTO Horarios_Turnos (ID_Medico, Dia_Semana, Hora_Inicio, Hora_Fin)
VALUES 
  (1, 'Lunes', '08:00', '12:00'),
  (1, 'Miércoles', '10:00', '14:00'),
  (2, 'Martes', '09:00', '13:00'),
  (2, 'Jueves', '09:00', '13:00'),
  (3, 'Lunes', '10:00', '15:00'),
  (3, 'Viernes', '10:00', '15:00');

INSERT INTO insumos (Name)
VALUES 
  ('Algodon'),
  ('Gasas'),
  ('Alcohol'),
  ('Mascarillas'),
  ('Guantes'),
  ('Jeringas'),
  ('Agujas'),
  ('Apositos');

