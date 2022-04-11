--1
SELECT        OrderContents.IdOrder
			, OrderContents.IdProduct
			, Products.Model
			, Producers.[Name] AS Producer
			, Products.Price
			, OrderContents.Quantity
			, Products.Price * OrderContents.Quantity AS Cost
FROM OrderContents INNER JOIN
     Products ON OrderContents.IdProduct = Products.IdProduct INNER JOIN
     Producers ON Products.IdProducer = Producers.IdProducer

--2
SELECT        Orders.IdOrder, Orders.DateOfOrder, SUM(OrderContents.Quantity * Products.Price) AS Cost
FROM            Orders INNER JOIN
                         OrderContents ON Orders.IdOrder = OrderContents.IdOrder INNER JOIN
                         Products ON OrderContents.IdProduct = Products.IdProduct
GROUP BY Orders.IdOrder, Orders.DateOfOrder

--3
SELECT        Producers.IdProducer, Producers.Name, COUNT(Products.IdProduct) AS [Count]
FROM            Producers LEFT JOIN
                         Products ON Producers.IdProducer = Products.IdProducer
GROUP BY Producers.IdProducer, Producers.Name

--4
SELECT *
FROM Products
WHERE IdProduct NOT IN (SELECT DISTINCT IdProduct
						FROM OrderContents)

--5
SELECT        Products.IdProduct
			, Products.IdProducer
			, Products.Model
			, Products.Price
			, Products.Year
			, Products.Type
			, SUM(OrderContents.Quantity) AS Sales
FROM            Products LEFT JOIN
                         OrderContents ON Products.IdProduct = OrderContents.IdProduct
GROUP BY Products.IdProduct
			, Products.IdProducer
			, Products.Model
			, Products.Price
			, Products.Year
			, Products.Type
HAVING SUM(OrderContents.Quantity) < 5 OR SUM(OrderContents.Quantity) IS NULL

--6
SELECT COUNT(*) AS Количество, 'Общее количество товаров' AS Уточнение
FROM Products
UNION 
SELECT COUNT(*), 'Количество товаров дешевле 10000'
FROM Products
WHERE Price < 10000
UNION 
SELECT COUNT(*), 'Количество товаров русских производителей'
FROM            Products INNER JOIN
                         Producers ON Products.IdProducer = Producers.IdProducer
WHERE Producers.Country = 'Россия'