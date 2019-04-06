CREATE DATABASE dealer_ship;
use dealer_ship;

CREATE TABLE product ( 
Id int primary key Identity,
brand varchar(50) not null,
price decimal (10, 2) not null, 
stock int not null
);

SELECT * FROM product;

DROP TABLE product;