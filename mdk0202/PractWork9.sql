--1
CREATE FUNCTION [dbo].[GetAddress]
(
    @idOrder int
)
RETURNS nvarchar(100)
AS
BEGIN

declare @addres nvarchar(100)

SELECT @addres = Customers.Address
FROM            Customers INNER JOIN
                         Orders ON Customers.IdCustomer = Orders.IdCustomer
WHERE Orders.IdOrder = @idOrder
    RETURN  UPPER(@addres)
END

--
SELECT        IdOrder, IdCustomer, DateOfOrder, dbo.GetAddress(IdOrder) AS Address
FROM            Orders
--


--2 

alter FUNCTION [dbo].[GetOrder]
(
    @idOrder int
)
RETURNS TABLE AS RETURN
(
SELECT OrderContents.IdProduct, Producers.Name, Products.Model, Products.Price, OrderContents.Quantity, Products.Price*OrderContents.Quantity as Cost
FROM OrderContents INNER JOIN
                         Products ON OrderContents.IdProduct = Products.IdProduct INNER JOIN
                         Producers ON Products.IdProducer = Producers.IdProducer
WHERE OrderContents.IdOrder = @idOrder
)

--
SELECT *
FROM dbo.GetOrder(2);
--

--3

ALTER FUNCTION [dbo].[GetProductInfo]
(
    @idProduct int

)
RETURNS nvarchar(150)
AS
BEGIN
declare @productInfo nvarchar(150)

SELECT        @productInfo = Products.Type + ' ' + Products.Model + ' ' + Producers.Name
FROM            Products INNER JOIN
                         Producers ON Products.IdProducer = Producers.IdProducer
WHERE        (Products.IdProduct = @idProduct)
    RETURN  @productInfo
END

--
SELECT        IdOrder, dbo.GetProductInfo(IdProduct) AS ProductInfo, Quantity
FROM            OrderContents
--

--4
CREATE FUNCTION [dbo].[GetProductsByType]
(
	@min int,
	@max int,
    @type nvarchar(10) = 'смартфон'
)
RETURNS TABLE AS RETURN
(
SELECT *
FROM Products
WHERE Price >= @min AND Price <= @max AND Type = @type
)

--
SELECT *
FROM dbo.GetProductsByType(2000, 20000, 'планшет')
--

--5
CREATE FUNCTION [dbo].[GetCost]
(
    @idOrder int
)
RETURNS decimal(7,2)
AS
BEGIN
DECLARE @cost decimal(7,2)
SELECT @cost = SUM(OrderContents.Quantity*Products.Price)
FROM OrderContents INNER JOIN
     Products ON OrderContents.IdProduct = Products.IdProduct
GROUP BY IdOrder
HAVING IdOrder = @idOrder
RETURN @cost
END

--
SELECT *, dbo.GetCost(IdOrder) AS Cost
FROM Orders
--

--6
CREATE FUNCTION [dbo].[GetProducers]
(
)
RETURNS TABLE AS RETURN
(
SELECT        Producers.Name, COUNT(IdProduct) AS ModelsCount
FROM            Producers INNER JOIN
                         Products ON Producers.IdProducer = Products.IdProducer
GROUP BY Producers.Name
)

--
SELECT *
FROM [dbo].[GetProducers]()
--