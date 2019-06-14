use master
go
create database DB_TPC_Rubinstein_v2
go
use DB_TPC_Rubinstein
go

drop database DB_TPC_Rubinstein_v2


go
create table Proveedores( 
    IdProveedor int not null primary key identity(1,1),
    CUIL varchar(50) not null,
    RazonSocial varchar(50) not null,
    Direccion varchar (60) not null,
    Localidad varchar(60) not null,
    Contacto varchar(60) not null,
    Telefono varchar(60) not null,
    Mail varchar(60) not null
)
go
create table Clientes( 
    IdCliente int not null primary key identity(1,1),
    CUIL varchar(50) not null,
    RazonSocial varchar(50) not null,
    Direccion varchar (60) not null,
    Localidad varchar(60) not null,
    Contacto varchar(60) not null,
    Telefono varchar(60) not null,
    Mail varchar(60) not null
)



Select * from Contacto
Select * from Proveedor
