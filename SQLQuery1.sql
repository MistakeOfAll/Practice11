use master
go
create database HardwareStore
go
use HardwareStore
go
create table Product
(
	ProductID int primary key identity,
    ProductName nvarchar(100) not null,
    Price int not null,
	Unit nvarchar (20),
    StockQuantity int not null
);

insert into Product values
('Laptop', 1000, 'רע', 10),
('Smartphone', 500, 'רע', 20),
('Headphones', 50, 'רע', 30),
('Tablet', 800, 'רע', 15),
('Smartwatch', 200, 'רע', 25),
('Camera', 600, 'רע', 12),
('Printer', 300, 'רע', 18),
('Monitor', 400, 'רע', 22),
('Keyboard', 30, 'רע', 40),
('Mouse', 20, 'רע', 50),
('Speaker', 70, 'רע', 35),
('Router', 80, 'רע', 28),
('External Hard Drive', 120, 'רע', 17),
('USB Flash Drive', 10, 'רע', 60),
('Microphone', 90, 'רע', 33),
('Webcam', 40, 'רע', 45),
('Game Console', 350, 'רע', 13),
('E-reader', 150, 'רע', 23),
('Power Bank', 25, 'רע', 55),
('Fitness Tracker', 75, 'רע', 27);