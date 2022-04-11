--1
CREATE PROCEDURE dbo.AddProducer 
    @name NVARCHAR(50),
    @country NVARCHAR(30) = 'Россия'  
AS
    INSERT INTO Producers(Name, Country)
	SELECT @name, @country 
--
EXEC AddProducer 'Irbis'
--

--2
CREATE PROCEDURE dbo.IncreasePrice 
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

--
DECLARE @rows INT;
 EXEC IncreasePrice -300, 'смартфон', @rows OUTPUT
 SELECT @rows
--

--3
CREATE PROCEDURE dbo.AddOrder 
    @login VARCHAR(20)
AS
BEGIN
    INSERT INTO Orders(IdCustomer, DateOfOrder)
	SELECT IdCustomer, GETDATE()
	FROM Customers
	WHERE  Login = @login;
	PRINT SCOPE_IDENTITY()
END

--
EXEC AddOrder jsm
--

--4
ALTER PROCEDURE dbo.AddOrderWithContent 
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

--
EXEC AddOrderWithContent elonmusksu, 1, 2
--

--5
CREATE PROCEDURE dbo.AddOrUpdateProducer
    @name NVARCHAR(50),
    @country NVARCHAR(30) = 'Россия'  
AS
	IF (exists (SELECT * FROM Producers
	WHERE @name = Name))
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
--
EXEC AddOrUpdateProducer 'Irbis', '123'
--

--6
ALTER PROCEDURE dbo.DeleteOrder 
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

--
DECLARE @rows INT;
 EXEC DeleteOrder 20, @rows OUTPUT
 SELECT @rows
--