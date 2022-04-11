--1.1
USE [master]
GO

/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [pcs9114]    Script Date: 26.02.2022 8:33:54 ******/
CREATE LOGIN [pcs9114] 
WITH PASSWORD=N'TNzOae1hWDK/K/tLmE/sbIOIPNj77+Qn4TswhF5yvQQ='
	, DEFAULT_DATABASE=[pcs9114]
	, DEFAULT_LANGUAGE=[русский]
	, CHECK_EXPIRATION=OFF
	, CHECK_POLICY=OFF
GO
ALTER LOGIN [pcs9114] DISABLE
GO

--1.2
CREATE LOGIN [pcsLogin14] 
WITH PASSWORD=N'Password!'
	, CHECK_EXPIRATION=OFF
	, CHECK_POLICY=OFF
GO

--1.3
sp_addlogin 'pcsLogin14', 'Password!'
GO

--1.4
sp_addsrvrolemember 'pcsLogin14', 'securityadmin'
GO

--2

EXEC sp_adduser 'test1', 'pcsUser1'
EXEC sp_droprolemember 'db_owner', 'pcsUser1';

EXEC sp_adduser 'test2', 'pcsUser2'
EXEC sp_droprolemember 'db_datawriter', 'pcsUser2'
EXEC sp_droprolemember 'db_datareader', 'pcsUser2'

--3

CREATE USER pcsUser3
FOR LOGIN test3;

GRANT DELETE, INSERT
ON Products
TO pcsUser3;


CREATE USER pcsUser4
FOR LOGIN test4;

GRANT SELECT
ON Customers
TO pcsUser4;

GRANT UPDATE
ON Customers(Email, Address)
TO pcsUser4;

--4
exec sp_droprolemember 'db_datawriter', 'pcsUser2';

DENY SELECT
ON Customers
TO pcsUser2;

DENY UPDATE
ON Customers(Email)
TO pcsUser4;
