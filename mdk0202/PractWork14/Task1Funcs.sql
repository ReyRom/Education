USE [pcs9114]
GO
/****** Object:  UserDefinedFunction [dbo].[GetAddress]    Script Date: 26.02.2022 12:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  UserDefinedFunction [dbo].[GetCost]    Script Date: 26.02.2022 12:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  UserDefinedFunction [dbo].[GetProductInfo]    Script Date: 26.02.2022 12:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetProductInfo]
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
GO
/****** Object:  UserDefinedFunction [dbo].[GetOrder]    Script Date: 26.02.2022 12:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetOrder]
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
GO
/****** Object:  UserDefinedFunction [dbo].[GetProducers]    Script Date: 26.02.2022 12:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  UserDefinedFunction [dbo].[GetProductsByType]    Script Date: 26.02.2022 12:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
