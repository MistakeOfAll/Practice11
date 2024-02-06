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
('Laptop', 1000, '��', 10),
('Smartphone', 500, '��', 20),
('Headphones', 50, '��', 30),
('Tablet', 800, '��', 15),
('Smartwatch', 200, '��', 25),
('Camera', 600, '��', 12),
('Printer', 300, '��', 18),
('Monitor', 400, '��', 22),
('Keyboard', 30, '��', 40),
('Mouse', 20, '��', 50),
('Speaker', 70, '��', 35),
('Router', 80, '��', 28),
('External Hard Drive', 120, '��', 17),
('USB Flash Drive', 10, '��', 60),
('Microphone', 90, '��', 33),
('Webcam', 40, '��', 45),
('Game Console', 350, '��', 13),
('E-reader', 150, '��', 23),
('Power Bank', 25, '��', 55),
('Fitness Tracker', 75, '��', 27);