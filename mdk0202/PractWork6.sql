--1
DECLARE @sale int
set @sale = RAND()*15+5
SELECT *, @sale as Sale, CAST(Price*(1-0.01*@sale)AS decimal(8,2)) AS Discount
FROM Products
WHERE IdProduct = 4

--2
UPDATE Products
SET Price = ROUND(Price,-1)

--3
SELECT YEAR(DateOfOrder) AS [Year], MONTH(DateOfOrder) AS [Month], COUNT(*) AS [Count]
FROM Orders
GROUP BY YEAR(DateOfOrder), MONTH(DateOfOrder)
ORDER BY YEAR(DateOfOrder) DESC, MONTH(DateOfOrder) DESC

--4
UPDATE Products
SET Price = Price*0.9
FROM Products
WHERE Products.IdProduct NOT IN (SELECT DISTINCT IdProduct
								FROM OrderContents  INNER JOIN
								Orders ON OrderContents.IdOrder = Orders.IdOrder
								WHERE DATEPART(QUARTER, DateOfOrder) = DATEPART(QUARTER, GETDATE()) AND YEAR(DateOfOrder) = YEAR(GETDATE())
								)

--5
SELECT        IdCustomer, UPPER(Surname+' '+LEFT(Name, 1)+'.') AS FullName
FROM            Customers

--6
UPDATE Customers
SET [Login] = REPLACE(TRIM(Login), ' ', '_')

--7
SELECT        IdCustomer, Login, Surname, Name, Address, Email, ISNULL(Phone,'-') AS Phone
FROM            Customers

--8
SELECT        IdProducer, Name, NULLIF(Country, 'Россия')AS Country
FROM            Producers

--9
SELECT        Producers.Name, STRING_AGG(Products.Model, ', ') AS Models
FROM            Products INNER JOIN
                         Producers ON Products.IdProducer = Producers.IdProducer
GROUP BY Producers.Name

--10
SELECT        OrderContents.IdOrder, STRING_AGG(CONCAT_WS(' ', Producers.Name, Products.Model), ', ') AS [Producers Models]
FROM            Products INNER JOIN
                         Producers ON Products.IdProducer = Producers.IdProducer INNER JOIN
                         OrderContents ON Products.IdProduct = OrderContents.IdProduct
GROUP BY OrderContents.IdOrder