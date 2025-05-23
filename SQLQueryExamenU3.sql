create database Productos

use Productos

create table Producto (
    IdProducto int primary key identity(1,1),
    Nombre nvarchar(100) not null,
    Descripcion nvarchar(255),
    Categoria nvarchar(50),
    Precio decimal(10, 2) not null,
    Cantidad int not null,
    FechaRegistro datetime default GETDATE()
);

insert into Producto (Nombre, Descripcion, Categoria, Precio, Cantidad)
values 
('Laptop Lenovo', 'Laptop de 15 pulgadas con 8GB RAM', 'Electr�nica', 950.00, 10),
('Mouse Logitech', 'Mouse inal�mbrico con receptor USB', 'Accesorios', 25.50, 50),
('Monitor LG', 'Monitor 24 pulgadas Full HD', 'Electr�nica', 180.75, 20),
('Teclado Redragon', 'Teclado mec�nico retroiluminado', 'Accesorios', 45.99, 35),
('Silla Gamer', 'Silla ergon�mica ajustable', 'Muebles', 220.00, 15),
('Impresora HP', 'Impresora multifunci�n con WiFi', 'Oficina', 130.00, 12);

select * from Producto
