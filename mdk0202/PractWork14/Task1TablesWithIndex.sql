USE [pcs9114]
GO
/****** Object:  Table [dbo].[Games1]    Script Date: 26.02.2022 12:45:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Games1](
	[IdGame] [int] NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[Platform] [varchar](10) NOT NULL,
	[Year] [smallint] NULL,
	[Genre] [varchar](50) NOT NULL,
	[Publisher] [varchar](100) NULL,
	[Price] [decimal](7, 2) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Games2]    Script Date: 26.02.2022 12:45:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Games2](
	[IdGame] [int] NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[Platform] [varchar](10) NOT NULL,
	[Year] [smallint] NULL,
	[Genre] [varchar](50) NOT NULL,
	[Publisher] [varchar](100) NULL,
	[Price] [decimal](7, 2) NOT NULL,
 CONSTRAINT [PK_Games2] PRIMARY KEY CLUSTERED 
(
	[IdGame] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Games3]    Script Date: 26.02.2022 12:45:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Games3](
	[IdGame] [int] NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[Platform] [varchar](10) NOT NULL,
	[Year] [smallint] NULL,
	[Genre] [varchar](50) NOT NULL,
	[Publisher] [varchar](100) NULL,
	[Price] [decimal](7, 2) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Index [ClusteredIndex-20220224-102845]    Script Date: 26.02.2022 12:45:23 ******/
CREATE CLUSTERED INDEX [ClusteredIndex-20220224-102845] ON [dbo].[Games3]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Games4]    Script Date: 26.02.2022 12:45:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Games4](
	[IdGame] [int] NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[Platform] [varchar](10) NOT NULL,
	[Year] [smallint] NULL,
	[Genre] [varchar](50) NOT NULL,
	[Publisher] [varchar](100) NULL,
	[Price] [decimal](7, 2) NOT NULL,
 CONSTRAINT [PK_Games4] PRIMARY KEY CLUSTERED 
(
	[IdGame] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Games5]    Script Date: 26.02.2022 12:45:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Games5](
	[IdGame] [int] NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[Platform] [varchar](10) NOT NULL,
	[Year] [smallint] NULL,
	[Genre] [varchar](50) NOT NULL,
	[Publisher] [varchar](100) NULL,
	[Price] [decimal](7, 2) NOT NULL,
 CONSTRAINT [PK_Games5] PRIMARY KEY CLUSTERED 
(
	[IdGame] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Games6]    Script Date: 26.02.2022 12:45:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Games6](
	[IdGame] [int] NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[Platform] [varchar](10) NOT NULL,
	[Year] [smallint] NULL,
	[Genre] [varchar](50) NOT NULL,
	[Publisher] [varchar](100) NULL,
	[Price] [decimal](7, 2) NOT NULL,
 CONSTRAINT [PK_Games6] PRIMARY KEY CLUSTERED 
(
	[IdGame] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Games7]    Script Date: 26.02.2022 12:45:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Games7](
	[IdGame] [int] NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[Platform] [varchar](10) NOT NULL,
	[Year] [smallint] NULL,
	[Genre] [varchar](50) NOT NULL,
	[Publisher] [varchar](100) NULL,
	[Price] [decimal](7, 2) NOT NULL,
 CONSTRAINT [PK_Games7] PRIMARY KEY CLUSTERED 
(
	[IdGame] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Games8]    Script Date: 26.02.2022 12:45:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Games8](
	[IdGame] [int] NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[Platform] [varchar](10) NOT NULL,
	[Year] [smallint] NULL,
	[Genre] [varchar](50) NOT NULL,
	[Publisher] [varchar](100) NULL,
	[Price] [decimal](7, 2) NOT NULL,
 CONSTRAINT [PK_Games8] PRIMARY KEY CLUSTERED 
(
	[IdGame] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [UQ_NonClusteredIndex_games4]    Script Date: 26.02.2022 12:45:23 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NonClusteredIndex_games4] ON [dbo].[Games4]
(
	[Name] ASC,
	[Platform] ASC,
	[Price] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [NonClusteredIndex_games5]    Script Date: 26.02.2022 12:45:23 ******/
CREATE NONCLUSTERED INDEX [NonClusteredIndex_games5] ON [dbo].[Games5]
(
	[Name] ASC
)
INCLUDE([Platform],[Price]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [NonClusteredIndex_Name_Games7]    Script Date: 26.02.2022 12:45:23 ******/
CREATE NONCLUSTERED INDEX [NonClusteredIndex_Name_Games7] ON [dbo].[Games7]
(
	[Name] ASC
)
WHERE ([Price]>=(100) AND [Price]<=(1000))
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [NonClusteredIndex_Name_Games8]    Script Date: 26.02.2022 12:45:23 ******/
CREATE NONCLUSTERED INDEX [NonClusteredIndex_Name_Games8] ON [dbo].[Games8]
(
	[Name] ASC
)
INCLUDE([Price]) 
WHERE ([Price]>=(100) AND [Price]<=(1000))
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [NonClusteredColumnStoreIndex_Name_Games6]    Script Date: 26.02.2022 12:45:23 ******/
CREATE NONCLUSTERED COLUMNSTORE INDEX [NonClusteredColumnStoreIndex_Name_Games6] ON [dbo].[Games6]
(
	[Name]
)WITH (DROP_EXISTING = OFF, COMPRESSION_DELAY = 0, DATA_COMPRESSION = COLUMNSTORE) ON [PRIMARY]
GO
