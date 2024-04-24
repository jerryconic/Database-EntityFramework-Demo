CREATE DATABASE db01;
GO

USE db01;
CREATE TABLE dbo.Customer(
	cust_id nchar(10) PRIMARY KEY,
	cust_name nchar(10),
	addr nchar(10),
	phone nchar(10)
);

CREATE TABLE dbo.Product(
	product_id int PRIMARY KEY,
	product_name nvarchar(20),
	price int
);