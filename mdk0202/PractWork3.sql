--1
SELECT *
  FROM Products

--2
SELECT TOP 3 [Name], [Surname]
FROM Customers

--3
SELECT DISTINCT Country
FROM Producers
ORDER BY Country

--4
SELECT Country
FROM Producers
GROUP BY Country

--5
SELECT [IdProduct] AS [Код товара]
      ,[Model] AS Модель
      ,[Price] AS Цена
      ,[Price]*0.2 AS НДС
  FROM Products

--6
SELECT *, CASE
WHEN [Year]>=2020 THEN 'Новинки'
WHEN [Year]<=2019 AND [Year]>=2016 THEN 'В продаже'
ELSE 'Раритет' 
END AS Категория
FROM Products
ORDER BY [Year]  DESC

--7
SELECT [Login], Phone
FROM Customers
WHERE Phone IS NOT NULL

--8
SELECT *
FROM Products
WHERE Model LIKE '%iPhone%'

--9
SELECT MIN(Price) AS [Минимальная цена], MAX(Price) AS [Максимальная цена], AVG(Price) AS [Средняя цена]
FROM Products

--10
SELECT Country, COUNT(*) AS Количество
FROM Producers
GROUP BY Country
HAVING COUNT(*) > 1