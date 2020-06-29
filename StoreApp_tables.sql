

--creating new tables

--create Customer table

create table Customer(custID INT NOT NULL, FirstName NVARCHAR(20) NOT NULL, LastName NVARCHAR(20) NOT NULL,
Sex NCHAR(1) NOT NULL, PRIMARY KEY(custID));


--create Product table
create table Product(ProdID INT NOT NULL, Name NVARCHAR(15) NOT NULL, PRIMARY KEY(ProdID));

--Order table
create table Orders(OrderID INT NOT NULL, CustID INT NOT NULL, PRIMARY KEY(OrderID), FOREIGN KEY(CustID) REFERENCES Customer(custID));


--create order_details table
create table Order_Details(OrderID INT NOT NULL, ProdID INT NOT NULL, QTY INT DEFAULT 1, FOREIGN KEY(OrderID) REFERENCES Orders(OrderID),
FOREIGN KEY(ProdID) REFERENCES Product(ProdID));

--Store table
create table Store(StoreID INT NOT NULL, ProdID INT NOT NULL, Location NVARCHAR(20) NOT NULL,
PRIMARY KEY(StoreID), FOREIGN KEY(ProdID) REFERENCES Product(ProdID));

--inventory stocked
create table Inventory_Stocked(StoreID INT NOT NULL, ProdID INT NOT NULL,
Stock INT DEFAULT 0, FOREIGN KEY(StoreID) REFERENCES Store(StoreID), FOREIGN KEY(ProdID) REFERENCES Product(ProdID));


--INSERTING VALLUES IN THE TABLES

--Inserting into Customer
insert into Customer
values(1, 'Jacob', 'Smith', 'M'),
(2, 'Michael', 'Madison', 'M'),
(3, 'Ethan', 'Elizabeth', 'F'),
(4, 'Dylan', 'Elizabeth', 'F'),
(5, 'Diana', 'McCarthy', 'F'),
(6, 'Raul', 'Gomez', 'M');

--Inserting into Product
insert into Product
values(100, 'Sony TV'),
(200, 'HDMI cable'),
(300, 'Iphone 10'),
(400, 'Mac book pro'),
(500, 'Ipod'),
(600, 'Batteries'),
(700, 'Couch'),
(800, 'Mattres');

--inserting into Order table
insert into Orders
values(1000,1),(1002, 2),(1003,4),(1004, 5), (1005,1), (1006,3), (1007,4);

--inserting into Order_details
insert into Order_Details
values(1000, 200, 10), (1004, 500, 23), (1006, 400, 2), (1000, 500, 7),
(1005, 300, 56), (1005, 700, 4);

--inserting into store
insert into Store
values(80, 400, 'California'), (85, 800, 'New York'), (90, 300, 'California'),
(95, 100, 'Seattle'), (105, 300, 'Seattle'), (110, 600, 'London'),
(115, 200, 'Chicago');

--inserting into Inventory_stocked
insert into Inventory_Stocked
values(95, 300, 67), (85, 700, 34), (90, 500, 12),(110, 600,9), (80, 400, 2),
(105, 200, 5), (95, 100, 10);

