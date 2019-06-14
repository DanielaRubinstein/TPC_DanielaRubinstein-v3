use master
go
create database DB_TPC_Rubinstein
go
use DB_TPC_Rubinstein
go

drop database DB_TPC_Rubinstein

go
--create table Pais(
--IdPais int not null primary key identity(1,1),
--Descripcion varchar(50) not null,
--)
--go
--create table Provincia(
--IdProvincia int not null primary key identity(1,1),
--Descripcion varchar(50) not null,
--)
--go
--create table Localidad(
--IdLocalidad int not null primary key identity(1,1),
--CP varchar(15) not null,
--Descripcion varchar(50) not null,
--)
go
create table Direccion(
IdDireccion int not null primary key identity(1,1),
Calle varchar(60) not null, 
NroCalle int not null,
Piso int null, --PB
Departamento varchar(10) null, 
Localidad varchar(90) not null
--IdLocalidad int not null foreign key references Localidad(IdLocalidad),
--IdProvincia int not null foreign key references Provincia(IdProvincia),
--IdPais int not null foreign key references Pais(IdPais),
)
go
create table Telefono(
IdTelefono int not null primary key identity(1,1),
Telefono varchar(30) not null
)
--go
--create table TipoTelefono(
--IdTipoTelefono int not null primary key identity(1,1),
--Descripcion varchar(30) not null,
--)
go
create table Contacto(
IdContacto int not null primary key identity(1,1),
Nombre varchar(50) not null, 
Sector varchar(30)not null, 
IdTelefono int not null foreign key references Telefono(IdTelefono),
--IdTipoTelefono int not null foreign key references TipoTelefono(IdTipoTelefono),
Mail varchar(60) not null
)
go
create table Proveedor( 
    IdProveedor int not null primary key identity(1,1),
    CUIL varchar(50) not null,
    RazonSocial varchar(50) not null,
    IdDireccion int not null foreign key references Direccion(IdDireccion),
    IdContacto int null foreign key references Contacto(IdContacto)
)
go
create table Cliente( 
    IdCliente int not null primary key identity(1,1),
    CUIL varchar(50) not null,
    RazonSocial varchar(50) not null,
    IdDireccion int not null foreign key references Direccion(IdDireccion),
    IdContacto int null foreign key references Contacto(IdContacto)
)
go
create table Contacto_x_Proveedor(
IdProveedor int not null foreign key references Proveedor (IdProveedor),
IdContacto int not null foreign key references Contacto(IdContacto),
primary key(IdProveedor, IdContacto)
)
go
create table Telefono_x_Contacto(
IdContacto int not null foreign key references Contacto(IdContacto),
IdTelefono int not null foreign key references Telefono(IdTelefono),
primary key (IdContacto,IdTelefono)
)

insert into Telefono(Telefono)values('4777-0999')
insert into Telefono(Telefono)values('4777-0900')

insert into Direccion (Calle, NroCalle,Piso ,Departamento , Localidad) values ('Posta', 4000,2,'D','Belgrano')
insert into Direccion (Calle, NroCalle,Piso ,Departamento , Localidad) values ('Cabildo', 5000,3,'E','Belgrano')

insert into Contacto (Nombre,Sector, IdTelefono,Mail) values('Daniela Buchin', 'Gerente tienda ninios', 1,'dbuchin@falabella.com.ar')
insert into Contacto (Nombre,Sector, IdTelefono,Mail) values('Ricardo Alonso', 'CEO', 2,'ralonso@falabella.com.ar')
insert into Proveedor (CUIL,RazonSocial,IdDireccion,IdContacto) values ('3333333','Falabella',1,1)
insert into Proveedor (CUIL,RazonSocial,IdDireccion,IdContacto) values ('44444','Tsu',2,2)
insert into Proveedor (CUIL,RazonSocial,IdDireccion) values ('222','Guru',2)
insert into Contacto(Nombre, Sector,IdTelefono,Mail) values ('Juan Gonzalez','Programador',)

Select * from Contacto
Select * from Proveedor

select Nombre, Sector ,Mail from Contacto
inner join Proveedor on Contacto.IdContacto = Proveedor.IdContacto
where Proveedor.RazonSocial = 'Falabella'