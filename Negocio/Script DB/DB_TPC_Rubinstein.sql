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
insert into Proveedores (CUIL,RazonSocial,Direccion,Localidad,Contacto,Telefono,Mail,Estado) 
values ('2333345','Tsu','Cabildo 2345','Belgrano','Fernando Ruiz','45479849','fruiz@tsu.com.ar',1)
insert into Proveedores (CUIL,RazonSocial,Direccion,Localidad,Contacto,Telefono,Mail,Estado) 
values ('2144490','Hush Puppies','Agustin Alvarez 450','Vicente Lopez','Pilar Mendez','15983900','pmendez@hpuppies.com',1)
insert into Proveedores (CUIL,RazonSocial,Direccion,Localidad,Contacto,Telefono,Mail,Estado) 
values ('2300021','Importadora Sud','Entre Rios 223','San Isidro','Juan Platz','1109894952','jplatz@import.com.ar',0)

insert into Clientes(CUIL,RazonSocial,Direccion,Localidad,Contacto,Telefono,Mail,Estado)
values('28333045','Zapateria Gonzalez','Pueyrredon 1333','Palermo','Belen Diaz','1123490879','Zapateriagon@gmail.com',1)
insert into Clientes(CUIL,RazonSocial,Direccion,Localidad,Contacto,Telefono,Mail,Estado)
values('3200944','Valeria Artz','Melendez 3455','Don Torcuato','Valeria','1167894500','valeartz@gmail.com',1)
insert into Clientes(CUIL,RazonSocial,Direccion,Localidad,Contacto,Telefono,Mail,Estado)
values('20403000','Miguel Felicce','Triunvirato 302','Tortuguitas','Miguel','02320492049','miguelfelicce@gmail.com',0)

insert into Productos (Descripcion,Marca,Categoria,StockMinimo,StockActual,PrecioNeto,Impuesto,PrecioFinal,CostoNeto,CostoSinIva,IdProveedor,Estado,Imagen) 
values ('Zapatilla Old Skool Madder','Vans','Mujer',1,3,4049,21,4900,1200,1452,1,1,'https://media.brandalley.com/img_rayons/1600x1600/2019/03/22/258/3119258_2.jpg')
insert into Productos(Descripcion,Marca,Categoria,StockMinimo,StockActual,PrecioNeto,Impuesto,PrecioFinal,CostoNeto,CostoSinIva,IdProveedor,Estado,Imagen)
values('Zapatilla Heathrow Vulc','DC','Unisex',0,0,4500,21,5500,1200,1452,1,1,'https://www.xtremeinn.com/f/13673/136737881/dc-shoes-heathrow-vulc-se.jpg')
insert into Productos(Descripcion,Marca,Categoria,StockMinimo,StockActual,PrecioNeto,Impuesto,PrecioFinal,CostoNeto,CostoSinIva,IdProveedor,Estado,Imagen)
values('Zapatilla Sk8 Led Zeppelin','Vans','Hombre',1,3,6000,21,7260,1800,2178,2,1,'https://images.vans.com/is/image/VansEU/VN0A38GET5Z-HERO?$PDP-FULL-IMAGE$')





--UPDATES

