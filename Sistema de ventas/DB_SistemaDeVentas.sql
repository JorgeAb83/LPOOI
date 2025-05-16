create table Medidas(
IdMedida int primary key identity(1,1),
Nombre varchar(50) not null,
Abreviatura varchar(4) not null,--und - kg
Equivalente varchar(4) not null,--und - g
Valor int not null --1, 1000
)
go

create table Categorias(
IdCategoria int primary key identity(1,1),
Nombre varchar(50) not null,
IdMedida int references Medidas(IdMedida),
Activo bit default 1
)
go

create table Productos(
IdProducto int primary key identity(1,1),
IdCategoria int references Categorias(IdCategoria),
Codigo varchar(50) not null,
Descripcion varchar(150) not null,
PrecioCompra decimal(10,2) not null,
PrecioVenta decimal(10,2) not null,
Cantidad int not null,
Activo bit default 1
)
go

create table Roles(
IdRol int primary key identity(1,1),
Nombre varchar(50) not null,
)
go

create table Usuarios(
IdUsuario  int primary key identity(1,1),
IdRol int references Roles(IdRol),
NombreCompleto varchar(50) not null,
Correo varchar(50) not null,
NombreUsuario varchar(50) not null unique,
Clave varchar(100) not null,
ImagenUsuario VARBINARY(MAX),
ResetearClave bit default 1,
Activo bit default 1
)
go

create table CorrelativoVentas(
Serie varchar(3) not null, --001
Numero int not null, --1,2,3 --- 000001
Activo bit default 1,
primary key(Serie,Numero)
)
go

create table Ventas(
IdVenta int primary key identity(1,1),
NumeroVenta varchar(10), --001-000005
IdUsuarioRegistro int references Usuarios(IdUsuario),
NombreCliente varchar(60),
PrecioTotal decimal(10,2) not null,
PagoCon decimal(10,2),
Cambio decimal(10,2),
FechaRegistro datetime default getdate(),
Activo bit default 1
)
go

create table DetalleVentas(
IdDetalleVenta int primary key identity(1,1),
IdVenta int references Ventas(IdVenta),
IdProducto int references Productos(IdProducto),
Cantidad int,
PrecioVenta decimal(10,2),
PrecioTotal decimal(10,2)
)
go

create table Negocios(
IdNegocio int primary key identity(1,1),
RazonSocial varchar(100),
CUIT varchar(20),
Direccion varchar(100),
Celular varchar(10),
Correo varchar(30),
SimboloMoneda varchar(5),
Logo VARBINARY(MAX)
)
go

create table Menus(
IdMenu int primary key identity(1,1),
NombreMenu varchar(50) not null,
IdMenuPadre int default 0 not null
)
go

create table MenuRoles(
IdMenuRol int primary key identity(1,1),
IdMenu int references Menus(IdMenu),
IdRol int references Roles(IdRol),
Activo bit default 1
)
