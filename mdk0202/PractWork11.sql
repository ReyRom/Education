--1

ALTER TRIGGER [dbo].[trDeleteCustomer]
ON [dbo].[Customers]
AFTER DELETE
AS 
INSERT INTO DeletedCustomers([IdCustomer], [Login], [Surname], [Name], [Email], [Address], [Phone], [DateOfDelete])
SELECT [IdCustomer], [Login], [Surname], [Name], [Email], [Address], [Phone], GETDATE()
FROM deleted

--2
ALTER TRIGGER [dbo].[trDeleteProduct]
ON [dbo].[Products]
INSTEAD OF DELETE
AS 
UPDATE Products
SET [isDeleted] = 1
WHERE [IdProduct] IN(SELECT [IdProduct] FROM deleted)

--3
ALTER TRIGGER [dbo].[trAfterChangeCount]
ON [dbo].[OrderContents]
AFTER INSERT
AS 
	UPDATE Products
	SET [Count] = [Count]-Quantity
	FROM Products
	JOIN inserted ON Products.IdProduct = inserted.IdProduct

--4
ALTER TRIGGER [dbo].[trChangeCount]
ON [dbo].[OrderContents]
INSTEAD OF INSERT
AS 
BEGIN
DECLARE @q SMALLINT;
DECLARE @c SMALLINT;
SELECT @q = Quantity, @c = [Count]
FROM Products JOIN inserted
ON Products.IdProduct = inserted.IdProduct;

IF (@q<=@c)
BEGIN 
	INSERT INTO OrderContents(IdOrder, IdProduct, Quantity)
	SELECT IdOrder,IdProduct, @q
	FROM inserted;
	UPDATE Products
	SET [Count] = [Count]-@q
	FROM Products
	JOIN inserted ON Products.IdProduct = inserted.IdProduct
END
ELSE
BEGIN
	RAISERROR('Недостаточное количество товаров', 18, 1);
	ROLLBACK;
END
END

--5

ALTER TRIGGER [dbo].[trLogDeleteOrders]
ON [dbo].[Orders]
AFTER DELETE
AS 
INSERT INTO Logs ([Table], Operation, [Date], [User])
SELECT 'Заказы', 'Удален заказ ' + CAST(IdOrder AS VARCHAR(10)), GETDATE(), USER
FROM deleted
--

ALTER TRIGGER [dbo].[trLogInsertOrders]
ON [dbo].[Orders]
AFTER INSERT
AS 
INSERT INTO Logs ([Table], Operation, [Date], [User])
SELECT 'Заказы', 'Добавлен заказ ' + CAST(IdOrder AS VARCHAR(10)), GETDATE(), USER
FROM inserted
--

ALTER TRIGGER [dbo].[trLogUpdateOrders]
ON [dbo].[Orders]
AFTER UPDATE
AS 
INSERT INTO Logs ([Table], Operation, [Date], [User])
SELECT 'Заказы', 'Обновлен заказ ' + CAST(IdOrder AS VARCHAR(10)), GETDATE(), USER
FROM inserted
--

ALTER TRIGGER [dbo].[trLogDeleteProduct]
ON [dbo].[Products]
AFTER DELETE
AS 
INSERT INTO Logs ([Table], Operation, [Date], [User])
SELECT 'Товары', 'Удален товар ' + Model, GETDATE(), USER
FROM deleted
--

ALTER TRIGGER [dbo].[trLogInsertProduct]
ON [dbo].[Products]
AFTER INSERT
AS 
INSERT INTO Logs ([Table], Operation, [Date], [User])
SELECT 'Товары', 'Добавлен товар ' + Model, GETDATE(), USER
FROM inserted
--

ALTER TRIGGER [dbo].[trLogUpdateProduct]
ON [dbo].[Products]
AFTER UPDATE
AS 
INSERT INTO Logs ([Table], Operation, [Date], [User])
SELECT 'Товары', 'Обновлен товар ' + Model, GETDATE(), USER
FROM inserted

--6
ALTER TRIGGER [dbo].[trDeleteOrders]
ON [dbo].[Orders]
AFTER DELETE
AS 
DELETE
FROM Customers
WHERE Customers.IdCustomer NOT IN(SELECT DISTINCT IdCustomer
								FROM Orders)

