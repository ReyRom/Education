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
SELECT [IdProduct] AS [��� ������]
      ,[Model] AS ������
      ,[Price] AS ����
      ,[Price]*0.2 AS ���
  FROM Products

--6
SELECT *, CASE
WHEN [Year]>=2020 THEN '�������'
WHEN [Year]<=2019 AND [Year]>=2016 THEN '� �������'
ELSE '�������' 
END AS ���������
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
SELECT MIN(Price) AS [����������� ����], MAX(Price) AS [������������ ����], AVG(Price) AS [������� ����]
FROM Products

--10
SELECT Country, COUNT(*) AS ����������
FROM Producers
GROUP BY Country
HAVING COUNT(*) > 1