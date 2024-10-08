#-- Creates database

CREATE DATABASE IF NOT EXISTS CLinicaSePrice;
USE CLinicaSePrice;

#--	Executes drop sentences
DROP TABLE IF EXISTS users;
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

#--	Inserts startup data into database

INSERT INTO users(Username, FirstName, LastName, Pass, Phone, Email, Birthdate, UserRole) 
VALUES
('tester', 'Usuario', 'Prueba', '123456', '5465465', 'ml@jaja.com', '1945-12-30', 'Admin');