USE [cinemakino]
GO
/****** Object:  Table [dbo].[date]    Script Date: 23/10/2024 07:28:36 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[date](
	[Year] [int] NOT NULL,
	[Month] [int] NOT NULL,
	[Day] [int] NOT NULL,
	[Hour] [int] NOT NULL,
	[Minute] [char](10) NOT NULL,
	[FuncionID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[funcion]    Script Date: 23/10/2024 07:28:36 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[funcion](
	[FuncionId] [int] IDENTITY(1,1) NOT NULL,
	[movietitle] [nvarchar](255) NOT NULL,
	[moviegenres] [nvarchar](255) NOT NULL,
	[seat] [int] NOT NULL,
	[price] [nchar](10) NOT NULL,
	[cinemaroom] [int] NOT NULL,
	[userID] [nvarchar](50) NULL,
 CONSTRAINT [PK__movies__42EB372E4ADB25E6] PRIMARY KEY CLUSTERED 
(
	[FuncionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[time]    Script Date: 23/10/2024 07:28:36 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[time](
	[ID] [int] NOT NULL,
	[Hour] [int] NULL,
	[Minute] [int] NULL,
	[Second] [int] NULL,
	[Millisecond] [int] NULL,
	[Microsecond] [int] NULL,
	[Ticks] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 23/10/2024 07:28:36 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[ID] [nvarchar](50) NOT NULL,
	[firstname] [nvarchar](100) NULL,
	[lastname] [nvarchar](100) NULL,
	[email] [nvarchar](255) NULL,
	[phone] [nvarchar](20) NULL,
	[gender] [nvarchar](30) NULL,
 CONSTRAINT [PK__users__3214EC27B8270A2B] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[date]  WITH CHECK ADD  CONSTRAINT [FK_date_funcion] FOREIGN KEY([FuncionID])
REFERENCES [dbo].[funcion] ([FuncionId])
GO
ALTER TABLE [dbo].[date] CHECK CONSTRAINT [FK_date_funcion]
GO
ALTER TABLE [dbo].[funcion]  WITH CHECK ADD  CONSTRAINT [FK_funcion_users] FOREIGN KEY([userID])
REFERENCES [dbo].[users] ([ID])
GO
ALTER TABLE [dbo].[funcion] CHECK CONSTRAINT [FK_funcion_users]
GO
