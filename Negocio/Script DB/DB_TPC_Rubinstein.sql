use master
go
create database DB_TPC_Rubinstein_v2
go
use DB_TPC_Rubinstein_v2
go

drop database DB_TPC_Rubinstein_v2

drop table Productos

go
create table Proveedores( 
    IdProveedor int not null primary key identity(1,1),
    CUIL varchar(50) not null,
    RazonSocial varchar(50) not null,
    Direccion varchar (60) not null,
    Localidad varchar(60) not null,
    Contacto varchar(60) not null,
    Telefono varchar(60) not null,
    Mail varchar(60) not null,
    Estado bit not null
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
go
create table Productos(
IdProducto int not null primary key identity(1,1),
Descripcion varchar (60) not null,
Marca varchar (30) not null,
Categoria varchar (30) not null,
StockMinimo int not null, 
StockActual int not null,
PrecioNeto money not null,
Impuesto money not null,
PrecioFinal money not null,
CostoNeto money not null,
CostoSinIva money not null,
IdProveedor int not null foreign key references Proveedores(IdProveedor),
Estado bit not null
)

--SELECTS
Select * from Contactos
Select * from Proveedores
select * from Productos

select RazonSocial from Proveedores where Estado=1

Select IdProducto,Descripcion,Marca,Categoria,Proveedores.RazonSocial,StockMinimo,StockActual,PrecioNeto,Impuesto,PrecioFinal, CostoNeto, CostoSinIva, productos.Estado from PRODUCTOS
inner join Proveedores on Productos.IdProveedor = Proveedores.IdProveedor where productos.Estado = 1


--INSERTS
insert into Productos (Descripcion,Marca,Categoria,StockMinimo,StockActual,PrecioNeto,Impuesto,PrecioFinal,CostoNeto,CostoSinIva,IdProveedor,Estado) 
values ('producto1','producto1','producto1',1,1,1,1,1,1,1,1,1)

insert into Proveedores (CUIL,RazonSocial,Direccion,Localidad,Contacto,Telefono,Mail,Estado) 
values ('3','prueba3','prueba3','prueba3','prueba3','3','prueba3',1)
insert into Proveedores (CUIL,RazonSocial,Direccion,Localidad,Contacto,Telefono,Mail,Estado) 
values ('4','proveedor4','proveedor4','proveedor4','proveedor4','4','proveedor4',1)



--UPDATES
