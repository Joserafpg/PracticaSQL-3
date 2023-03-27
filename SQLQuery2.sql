create database Escuela

use Escuela

create table Alumnos(
Codigo int IDENTITY (1,1) NOT NULL PRIMARY KEY,
Cedula varchar (50),
Nombre varchar (50),
Telefono varchar (50),
Direccion text,
Fecha_nacimiento nvarchar(50),
)

create table Usuario(
Id_usuario int identity (1,1) NOT NULL PRIMARY KEY,
Nombre varchar (15),
Contraseña varchar(50),
Consultar bit,
Registrar bit,
Su bit
)

insert into Alumnos (Cedula, Nombre, Telefono, Direccion, Fecha_nacimiento)
values ('031-56310-0','Yunior Beltran','809-123-4563','Santiago','6/19/2006')

insert into Usuario (Nombre,Contraseña,Consultar,Registrar,Su)
values('Yunior','1234','1','1','1')

drop database Estudiantes;
drop table Alumnos

delete from Alumnos;

Select * from Alumnos

Select * from Usuario

