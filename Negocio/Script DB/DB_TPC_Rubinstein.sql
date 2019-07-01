use master
go
create database DB_TPC_Rubinstein_v2
go
use DB_TPC_Rubinstein_v2
go

drop database DB_TPC_Rubinstein_v2

drop table Clientes

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
    Mail varchar(60) not null,
    Estado bit not null
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
Estado bit not null,
Imagen varchar(200) null
)
go
create table FACTURAS(
IdFactura int not null primary key identity(1,1),
Fecha DATETIME not null,
IdCliente int not null foreign key references CLIENTES(IdCliente),
CondicionVenta varchar(30) not null,
Total money not null
)
go
create table DETALLES_DE_FACTURA(
IdDetalle int not null primary key identity(1,1),
IdProducto int not null foreign key references PRODUCTOS(IdProducto),
IdFactura int not null foreign key references FACTURAS(IdFactura),
Cantidad int not null,
Precio money not null,
)





--SELECTS
Select * from Clientes
Select * from Proveedores
select * from Productos

select RazonSocial from Proveedores where Estado=1

Select IdProducto,Descripcion,Marca,Categoria,Proveedores.RazonSocial,StockMinimo,StockActual,PrecioNeto,Impuesto,PrecioFinal, CostoNeto, CostoSinIva, productos.Estado from PRODUCTOS
inner join Proveedores on Productos.IdProveedor = Proveedores.IdProveedor where productos.Estado = 1


--INSERTS
insert into Productos (Descripcion,Marca,Categoria,StockMinimo,StockActual,PrecioNeto,Impuesto,PrecioFinal,CostoNeto,CostoSinIva,IdProveedor,Estado,Imagen) 
values ('producto1','producto1','producto1',1,1,1,1,1,1,1,1,1,'https://media.brandalley.com/img_rayons/1600x1600/2019/03/22/258/3119258_2.jpg')

insert into Proveedores (CUIL,RazonSocial,Direccion,Localidad,Contacto,Telefono,Mail,Estado,Imagen) 
values ('3','prueba3','prueba3','prueba3','prueba3','3','prueba3',1,'')
insert into Proveedores (CUIL,RazonSocial,Direccion,Localidad,Contacto,Telefono,Mail,Estado,Imagen) 
values ('4','proveedor4','proveedor4','proveedor4','proveedor4','4','proveedor4',1,'')



--UPDATES
