Create Database EstudianteDB
Go
Use EstudianteDB
Go
Create Table Estudiantes
(
	EstudianteId int identity,
	Matricula varchar(9),
	Nombres varchar(30),
	Apellido varchar(30),
	Cedula varchar(13),
	Telefono varchar(14),
	Celular varchar(14),
	Email varchar(50),
	FechaNacimiento date,
	Sexo int,
	Balance money
);
