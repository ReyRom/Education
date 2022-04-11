USE [pcs9114]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([IdCustomer], [Login], [Surname], [Name], [Email], [Address], [Phone]) VALUES (1, N'elonmusksu', N'Musk', N'Elon', N'elonmusk@tesla.com', N'Даллас', NULL)
INSERT [dbo].[Customers] ([IdCustomer], [Login], [Surname], [Name], [Email], [Address], [Phone]) VALUES (2, N'MedvedevRussia', N'Медведев', N'Дмитрий', N'medvedev@gov.ru', N'Москва', NULL)
INSERT [dbo].[Customers] ([IdCustomer], [Login], [Surname], [Name], [Email], [Address], [Phone]) VALUES (3, N'jsm', N'Маломан', N'Юлия', N'jsm.arcotel@gmail.com', N'Архангельск', NULL)
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([IdOrder], [IdCustomer], [DateOfOrder]) VALUES (1, 1, CAST(N'2022-01-27T10:57:00' AS SmallDateTime))
INSERT [dbo].[Orders] ([IdOrder], [IdCustomer], [DateOfOrder]) VALUES (2, 3, CAST(N'2022-01-27T10:58:00' AS SmallDateTime))
INSERT [dbo].[Orders] ([IdOrder], [IdCustomer], [DateOfOrder]) VALUES (3, 3, CAST(N'2022-01-27T14:18:00' AS SmallDateTime))
INSERT [dbo].[Orders] ([IdOrder], [IdCustomer], [DateOfOrder]) VALUES (9, 2, CAST(N'2022-02-03T11:42:00' AS SmallDateTime))
INSERT [dbo].[Orders] ([IdOrder], [IdCustomer], [DateOfOrder]) VALUES (13, 3, CAST(N'2022-02-19T13:11:00' AS SmallDateTime))
INSERT [dbo].[Orders] ([IdOrder], [IdCustomer], [DateOfOrder]) VALUES (21, 1, CAST(N'2022-02-19T14:05:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Producers] ON 

INSERT [dbo].[Producers] ([IdProducer], [Name], [Country]) VALUES (1, N'DEXP', N'Россия')
INSERT [dbo].[Producers] ([IdProducer], [Name], [Country]) VALUES (2, N'Apple', N'США')
INSERT [dbo].[Producers] ([IdProducer], [Name], [Country]) VALUES (3, N'Microsoft', N'США')
INSERT [dbo].[Producers] ([IdProducer], [Name], [Country]) VALUES (4, N'Samsung', N'Ю. Корея')
INSERT [dbo].[Producers] ([IdProducer], [Name], [Country]) VALUES (5, N'ИРБИС', N'Россия')
INSERT [dbo].[Producers] ([IdProducer], [Name], [Country]) VALUES (6, N'Irbis', N'USA')
SET IDENTITY_INSERT [dbo].[Producers] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([IdProduct], [IdProducer], [Model], [Price], [Year], [Type], [Weight], [Description], [IsDeleted], [Count]) VALUES (1, 1, N'A440', CAST(2211.00 AS Decimal(7, 2)), 2021, N'смартфон', CAST(0.110 AS Decimal(4, 3)), NULL, 0, 82)
INSERT [dbo].[Products] ([IdProduct], [IdProducer], [Model], [Price], [Year], [Type], [Weight], [Description], [IsDeleted], [Count]) VALUES (2, 1, N'BL160', CAST(5046.00 AS Decimal(7, 2)), 2021, N'смартфон', NULL, NULL, 0, 100)
INSERT [dbo].[Products] ([IdProduct], [IdProducer], [Model], [Price], [Year], [Type], [Weight], [Description], [IsDeleted], [Count]) VALUES (4, 2, N'iPhone SE', CAST(32091.90 AS Decimal(7, 2)), 2020, N'смартфон', NULL, NULL, 0, 100)
INSERT [dbo].[Products] ([IdProduct], [IdProducer], [Model], [Price], [Year], [Type], [Weight], [Description], [IsDeleted], [Count]) VALUES (5, 1, N'Ursus EX111', CAST(13236.00 AS Decimal(7, 2)), 2021, N'планшет', NULL, NULL, 0, 100)
INSERT [dbo].[Products] ([IdProduct], [IdProducer], [Model], [Price], [Year], [Type], [Weight], [Description], [IsDeleted], [Count]) VALUES (6, 4, N'Galaxy A10', CAST(7791.90 AS Decimal(7, 2)), 2019, N'смартфон', NULL, NULL, 0, 96)
INSERT [dbo].[Products] ([IdProduct], [IdProducer], [Model], [Price], [Year], [Type], [Weight], [Description], [IsDeleted], [Count]) VALUES (7, 2, N'iPhone 5', CAST(9420.00 AS Decimal(7, 2)), 2012, N'смартфон', NULL, NULL, 0, 100)
INSERT [dbo].[Products] ([IdProduct], [IdProducer], [Model], [Price], [Year], [Type], [Weight], [Description], [IsDeleted], [Count]) VALUES (9, 2, N'iPhone 10', CAST(49699.00 AS Decimal(7, 2)), 2019, N'смартфон', NULL, NULL, 0, 100)
INSERT [dbo].[Products] ([IdProduct], [IdProducer], [Model], [Price], [Year], [Type], [Weight], [Description], [IsDeleted], [Count]) VALUES (11, 2, N'iPhone 3', CAST(4000.00 AS Decimal(7, 2)), 2008, N'смартфон', NULL, NULL, 0, 100)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
INSERT [dbo].[OrderContents] ([IdOrder], [IdProduct], [Quantity]) VALUES (1, 1, 1)
INSERT [dbo].[OrderContents] ([IdOrder], [IdProduct], [Quantity]) VALUES (1, 2, 1)
INSERT [dbo].[OrderContents] ([IdOrder], [IdProduct], [Quantity]) VALUES (1, 4, 1)
INSERT [dbo].[OrderContents] ([IdOrder], [IdProduct], [Quantity]) VALUES (1, 5, 1)
INSERT [dbo].[OrderContents] ([IdOrder], [IdProduct], [Quantity]) VALUES (2, 1, 3)
INSERT [dbo].[OrderContents] ([IdOrder], [IdProduct], [Quantity]) VALUES (2, 2, 1)
INSERT [dbo].[OrderContents] ([IdOrder], [IdProduct], [Quantity]) VALUES (2, 4, 2)
INSERT [dbo].[OrderContents] ([IdOrder], [IdProduct], [Quantity]) VALUES (2, 5, 1)
INSERT [dbo].[OrderContents] ([IdOrder], [IdProduct], [Quantity]) VALUES (3, 1, 4)
INSERT [dbo].[OrderContents] ([IdOrder], [IdProduct], [Quantity]) VALUES (9, 1, 2)
INSERT [dbo].[OrderContents] ([IdOrder], [IdProduct], [Quantity]) VALUES (21, 1, 2)
GO
INSERT [dbo].[DeletedCustomers] ([IdCustomer], [Login], [Surname], [Name], [Email], [Address], [Phone], [DateOfDelete]) VALUES (4, N'roma1nv1ctus', N'Садовский', N'Роман', N'srv@patrakeevka.ru', NULL, NULL, CAST(N'2022-01-27T11:28:00' AS SmallDateTime))
INSERT [dbo].[DeletedCustomers] ([IdCustomer], [Login], [Surname], [Name], [Email], [Address], [Phone], [DateOfDelete]) VALUES (5, N'roma1nv1ctus', N'Садовский', N'Роман', N's03roman@mail.ru', NULL, N'89965021592', CAST(N'2022-02-05T10:33:00' AS SmallDateTime))
INSERT [dbo].[DeletedCustomers] ([IdCustomer], [Login], [Surname], [Name], [Email], [Address], [Phone], [DateOfDelete]) VALUES (6, N'SSS_DF', N'Салазаров', N'Денис', N'ds@salz.de', N'Сызрань', N'89965021592', CAST(N'2022-02-19T13:54:00' AS SmallDateTime))
INSERT [dbo].[DeletedCustomers] ([IdCustomer], [Login], [Surname], [Name], [Email], [Address], [Phone], [DateOfDelete]) VALUES (7, N'reyrom', N'Садовский', N'Роман', N'sadroman@gmail.com', N'Архангельск', NULL, CAST(N'2022-02-26T09:07:00' AS SmallDateTime))
INSERT [dbo].[DeletedCustomers] ([IdCustomer], [Login], [Surname], [Name], [Email], [Address], [Phone], [DateOfDelete]) VALUES (8, N'meckbaig', N'Бородяев', N'Семен', N'sema228@yandex.ru', N'Талаги', NULL, CAST(N'2022-02-26T09:09:00' AS SmallDateTime))
GO
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Заказы', N'Добавлен заказ 9', CAST(N'2022-02-03T11:42:07.107' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар A440', CAST(N'2022-02-03T11:44:19.017' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Заказы', N'Добавлен заказ 10', CAST(N'2022-02-05T10:34:23.043' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Заказы', N'Добавлен заказ 12', CAST(N'2022-02-05T10:34:29.837' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Заказы', N'Удален заказ 12', CAST(N'2022-02-05T10:34:36.030' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Заказы', N'Удален заказ 10', CAST(N'2022-02-05T10:34:36.030' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар Ursus EX111', CAST(N'2022-02-05T10:42:28.740' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар BL160', CAST(N'2022-02-05T10:42:28.740' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар A440', CAST(N'2022-02-05T10:42:28.740' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар Galaxy A10', CAST(N'2022-02-05T11:01:43.583' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар Ursus EX111', CAST(N'2022-02-05T11:01:43.583' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар iPhone SE', CAST(N'2022-02-05T11:01:43.583' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар BL160', CAST(N'2022-02-05T11:01:43.583' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар A440', CAST(N'2022-02-05T11:01:43.583' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар Ursus EX111', CAST(N'2022-02-05T11:21:16.157' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар iPhone SE', CAST(N'2022-02-05T11:21:16.157' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар BL160', CAST(N'2022-02-05T11:21:16.157' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар A440', CAST(N'2022-02-05T11:21:16.157' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар iPhone 5', CAST(N'2022-02-05T11:24:22.180' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар Ursus EX111', CAST(N'2022-02-05T11:26:08.227' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар iPhone SE', CAST(N'2022-02-05T11:26:08.227' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар BL160', CAST(N'2022-02-05T11:26:08.227' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар A440', CAST(N'2022-02-05T11:26:08.227' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар iPhone 5', CAST(N'2022-02-05T11:30:28.180' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар Galaxy A10', CAST(N'2022-02-05T11:30:28.180' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар iPhone 5', CAST(N'2022-02-08T08:40:27.767' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар Galaxy A10', CAST(N'2022-02-08T08:40:27.767' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Добавлен товар iPhone 10', CAST(N'2022-02-10T10:05:09.407' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар Ursus EX111', CAST(N'2022-02-19T12:59:13.920' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар Ursus EX111', CAST(N'2022-02-19T13:00:24.480' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар iPhone 10', CAST(N'2022-02-19T13:09:32.470' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар iPhone 5', CAST(N'2022-02-19T13:09:32.470' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар Galaxy A10', CAST(N'2022-02-19T13:09:32.470' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар iPhone SE', CAST(N'2022-02-19T13:09:32.470' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар BL160', CAST(N'2022-02-19T13:09:32.470' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар A440', CAST(N'2022-02-19T13:09:32.470' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Заказы', N'Добавлен заказ 13', CAST(N'2022-02-19T13:11:02.970' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Заказы', N'Добавлен заказ 14', CAST(N'2022-02-19T13:25:10.213' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар Galaxy A10', CAST(N'2022-02-19T13:25:10.220' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Заказы', N'Добавлен заказ 15', CAST(N'2022-02-19T13:28:53.723' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар Galaxy A10', CAST(N'2022-02-19T13:28:53.740' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Заказы', N'Добавлен заказ 16', CAST(N'2022-02-19T13:29:27.523' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар A440', CAST(N'2022-02-19T13:29:27.537' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Заказы', N'Добавлен заказ 17', CAST(N'2022-02-19T13:30:54.913' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар A440', CAST(N'2022-02-19T13:30:54.930' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Заказы', N'Добавлен заказ 18', CAST(N'2022-02-19T13:35:05.593' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар A440', CAST(N'2022-02-19T13:35:05.593' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Заказы', N'Добавлен заказ 19', CAST(N'2022-02-19T13:38:48.270' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар A440', CAST(N'2022-02-19T13:38:48.280' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Заказы', N'Добавлен заказ 20', CAST(N'2022-02-19T13:39:06.707' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар A440', CAST(N'2022-02-19T13:39:06.727' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Заказы', N'Удален заказ 15', CAST(N'2022-02-19T13:53:32.333' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Заказы', N'Удален заказ 16', CAST(N'2022-02-19T13:55:34.133' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Заказы', N'Удален заказ 14', CAST(N'2022-02-19T13:56:28.817' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Заказы', N'Удален заказ 17', CAST(N'2022-02-19T13:57:24.410' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Заказы', N'Удален заказ 18', CAST(N'2022-02-19T14:01:11.587' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Заказы', N'Добавлен заказ 21', CAST(N'2022-02-19T14:05:12.080' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Обновлен товар A440', CAST(N'2022-02-19T14:05:12.080' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Заказы', N'Удален заказ 19', CAST(N'2022-02-19T14:07:10.023' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Заказы', N'Удален заказ 20', CAST(N'2022-02-19T14:07:58.630' AS DateTime), N'dbo')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Добавлен товар iPhone 3', CAST(N'2022-02-26T09:20:36.977' AS DateTime), N'pcsUser3')
INSERT [dbo].[Logs] ([Table], [Operation], [Date], [User]) VALUES (N'Товары', N'Добавлен товар iPhone 5', CAST(N'2022-02-05T11:23:17.130' AS DateTime), N'dbo')
GO
