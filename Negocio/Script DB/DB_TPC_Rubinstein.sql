use master
go
create database DB_TPC_Rubinstein
go
use DB_TPC_Rubinstein
go

drop database DB_TPC_Rubinstein

go
create table Pais(
IdPais int not null primary key identity(1,1),
Descripcion varchar(50) not null,
)
go
create table Provincia(
IdProvincia int not null primary key identity(1,1),
Descripcion varchar(50) not null,
)
go
create table Localidad(
IdLocalidad int not null primary key identity(1,1),
CP varchar(15) not null,
Descripcion varchar(50) not null,
)
go
create table Direccion(
IdDireccion int not null primary key identity(1,1),
Calle varchar(60) not null, 
NroCalle int not null,
Piso int null, --PB
Departamento int null, 
IdLocalidad int not null foreign key references Localidad(IdLocalidad),
IdProvincia int not null foreign key references Provincia(IdProvincia),
IdPais int not null foreign key references Pais(IdPais),
)
go
create table Telefono(
IdTelefono int not null primary key identity(1,1),
Telefono varchar(30) not null
)
go
create table TipoTelefono(
IdTipoTelefono int not null primary key identity(1,1),
Descripcion varchar(30) not null,
)
go
create table Contacto(
IdContacto int not null primary key identity(1,1),
Nombre varchar(50) not null, 
Sector varchar(30)not null, 
IdTelefono int not null foreign key references Telefono(IdTelefono),
IdTipoTelefono int not null foreign key references TipoTelefono(IdTipoTelefono),
Mail varchar(60) not null
)
go
create table Proveedor( 
    IdProveedor int not null primary key identity(1,1),
    CUIL varchar(50) not null,
    RazonSocial varchar(50) not null,
    IdDireccion int not null foreign key references Direccion(IdDireccion),
    IdContacto int not null foreign key references Contacto(IdContacto)
)
go
create table Cliente( 
    IdCliente int not null primary key identity(1,1),
    CUIL varchar(50) not null,
    RazonSocial varchar(50) not null,
    IdDireccion int not null foreign key references Direccion(IdDireccion),
    IdContacto int not null foreign key references Contacto(IdContacto)
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

