--1
alter VIEW Products_View
AS
SELECT		  Products.IdProduct
			, CONCAT_WS(' ', Products.Type, Producers.Name, Products.Model) AS ProductInfo
			, Products.Price
FROM            Products INNER JOIN
                         Producers ON Products.IdProducer = Producers.IdProducer;


--2

alter VIEW Orders_View
AS
SELECT        Orders.IdOrder, Orders.DateOfOrder, Customers.Login, Customers.Surname +' '+ Customers.Name AS Fullname
FROM            Orders INNER JOIN
                         Customers ON Orders.IdCustomer = Customers.IdCustomer;

--3
CREATE VIEW Smartphones_View
AS
SELECT        Products.*
FROM            Products
WHERE Type = 'смартфон'
WITH CHECK OPTION;

--4
alter VIEW YearOrders_View
AS
SELECT			Orders_View.IdOrder
				, Orders_View.DateOfOrder
				, Orders_View.Login
				, Orders_View.Fullname
				, Products_View.ProductInfo
				, Products_View.Price
				, OrderContents.Quantity
				, Products_View.Price * OrderContents.Quantity AS Cost
FROM            Orders_View INNER JOIN
                         OrderContents ON Orders_View.IdOrder = OrderContents.IdOrder INNER JOIN
                         Products_View ON OrderContents.IdProduct = Products_View.IdProduct
WHERE YEAR(DateOfOrder) = YEAR(GETDATE())


--5

Create VIEW ProductsSales_View
AS
SELECT        Products_View.IdProduct
			, Products_View.ProductInfo
			, Products_View.Price
			, SUM(OrderContents.Quantity) AS Quantity
			, SUM(OrderContents.Quantity*Products_View.Price) AS [Sum]
FROM            Products_View INNER JOIN
                         OrderContents ON Products_View.IdProduct = OrderContents.IdProduct
GROUP BY  Products_View.IdProduct, Products_View.ProductInfo, Products_View.Price

--6

INSERT INTO ProductsM10000(IdProduct, Model, Price)
SELECT IdProduct, Model, Price
FROM Products
WHERE Price > 10000

INSERT INTO ProductsL10000(IdProduct, Model, Price)
SELECT IdProduct, Model, Price
FROM Products
WHERE Price < 10000

CREATE VIEW AllProducts_View
AS
SELECT *
FROM ProductsL10000
UNION ALL
SELECT *
FROM ProductsM10000