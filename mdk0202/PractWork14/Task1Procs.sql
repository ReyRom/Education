USE [pcs9114]
GO
/****** Object:  StoredProcedure [dbo].[AddOrder]    Script Date: 26.02.2022 12:42:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddOrder] 
    @login VARCHAR(20)
AS
BEGIN
    INSERT INTO Orders(IdCustomer, DateOfOrder)
	SELECT IdCustomer, GETDATE()
	FROM Customers
	WHERE  Login = @login;
	PRINT SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[AddOrderWithContent]    Script Date: 26.02.2022 12:42:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddOrderWithContent] 
    @login VARCHAR(20),
	@idProduct INT,
	@quantity INT
AS
BEGIN
    INSERT INTO Orders(IdCustomer, DateOfOrder)
	SELECT IdCustomer, GETDATE()
	FROM Customers
	WHERE  Login = @login;
	DECLARE @idOrder int
	SET @idOrder = SCOPE_IDENTITY();

	INSERT INTO OrderContents(IdOrder, IdProduct, Quantity)
	VALUES (@idOrder, @idProduct, @quantity);

SELECT        Orders.IdOrder
			, Orders.DateOfOrder
			, Customers.Login
			, Producers.Name AS Producer
			, Products.Model
			, Products.Price
			, OrderContents.Quantity
			, Products.Price * OrderContents.Quantity AS Cost
FROM            Customers INNER JOIN
                         Orders ON Customers.IdCustomer = Orders.IdCustomer INNER JOIN
                         OrderContents ON Orders.IdOrder = OrderContents.IdOrder INNER JOIN
                         Producers INNER JOIN
                         Products ON Producers.IdProducer = Products.IdProducer ON OrderContents.IdProduct = Products.IdProduct
	WHERE Orders.IdOrder = @idOrder;
END
GO
/****** Object:  StoredProcedure [dbo].[AddOrUpdateProducer]    Script Date: 26.02.2022 12:42:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddOrUpdateProducer]
    @name NVARCHAR(50),
    @country NVARCHAR(30) = 'Россия'  
AS
	IF (@name NOT IN (SELECT Name
					FROM Producers))
	BEGIN
		INSERT INTO Producers(Name, Country)
		SELECT @name, @country 
	END
	ELSE
	BEGIN
		UPDATE Producers
		SET Country = @country
		WHERE Name = @name
	END
GO
/****** Object:  StoredProcedure [dbo].[AddProducer]    Script Date: 26.02.2022 12:42:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddProducer] 
    @name NVARCHAR(50),
    @country NVARCHAR(30) = 'Россия'  
AS
    INSERT INTO Producers(Name, Country)
	SELECT @name, @country 
GO
/****** Object:  StoredProcedure [dbo].[DeleteOrder]    Script Date: 26.02.2022 12:42:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteOrder] 
    @idOrder INT,
    @rowCount INT OUTPUT 
AS
BEGIN  
	DELETE
	FROM OrderContents
	WHERE IdOrder = @idOrder;
	SET @rowCount = @@RowCount;

	DELETE
	FROM Orders
	WHERE IdOrder = @idOrder;
	
END
GO
/****** Object:  StoredProcedure [dbo].[IncreasePrice]    Script Date: 26.02.2022 12:42:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IncreasePrice] 
    @markup DECIMAL(7, 2),
	@type NVARCHAR(10)= 'ноутбук',
    @rowCount int OUTPUT 
AS
BEGIN
    UPDATE Products
	SET Price = Price + @markup
	WHERE Type = @type;
	SET @rowCount = @@RowCount;
END
GO
