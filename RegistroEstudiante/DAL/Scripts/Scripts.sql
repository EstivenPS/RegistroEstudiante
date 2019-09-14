Create Database EstudiantesDB
Go
Use EstudiantesDB
Go
Create Table Estudiantes
(
	EstudianteId int primary key identity(1,1),
	Matricula varchar(9),
	Nombres varchar(30),
	Apellidos varchar(30),
	Cedula varchar(13),
	Telefono varchar(13),
	Celular varchar(13),
	Email varchar(50),
	FechaNacimiento date,
	Sexo int,
	Balance decimal(9,2)
);
Go
Use EstudiantesDB
Go
Create Table Inscripciones
(
	InscripcionId int primary key identity(1,1),
	Fecha date,
	EstudianteId int foreign key references Estudiantes(EstudianteId),
	Comentarios varchar(max),
	Monto decimal(9,2),
	Deposito decimal(9,2),
	Balance decimal(9,2)
);
