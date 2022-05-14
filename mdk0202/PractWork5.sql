--1
SELECT        Producers.Name, Products.Model, Products.Type, Products.Year, Products.Price
INTO          tempDML
FROM          Products INNER JOIN
                       Producers ON Products.IdProducer = Producers.IdProducer

--2
DELETE
FROM tempDML
WHERE Model LIKE '%iPhone%'

--3
UPDATE tempDML
SET Price = CASE Name
	WHEN 'DEXP' THEN Price + 100
	WHEN 'Samsung' THEN Price * 0.9
	ELSE Price
	END

--4
UPDATE TOP (3) tempDML
SET Price = DEFAULT

--5
DELETE
FROM Orders
WHERE IdOrder NOT IN (SELECT DISTINCT IdOrder 
						FROM OrderContents)

--6
UPDATE Products
SET Price = Price + 100
FROM Products INNER JOIN
     Producers ON Products.IdProducer =
	 Producers.IdProducer
WHERE Country = 'Россия'