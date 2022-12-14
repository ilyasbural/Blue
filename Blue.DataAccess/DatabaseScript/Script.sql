USE [BLUE]
GO
/****** Object:  Table [dbo].[CITY]    Script Date: 12/14/2022 11:32:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CITY](
	[ID] [uniqueidentifier] NOT NULL,
	[NAME] [nvarchar](50) NULL,
	[REGISTER DATE] [date] NULL,
	[UPDATE DATE] [date] NULL,
	[IS ACTIVE] [bit] NULL,
 CONSTRAINT [PK_CITY] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DISTRICT]    Script Date: 12/14/2022 11:32:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DISTRICT](
	[CITY] [uniqueidentifier] NULL,
	[ID] [uniqueidentifier] NOT NULL,
	[NAME] [nvarchar](50) NULL,
	[REGISTER DATE] [date] NULL,
	[UPDATE DATE] [date] NULL,
	[IS ACTIVE] [bit] NULL,
 CONSTRAINT [PK_DISTRICT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FURNITURE]    Script Date: 12/14/2022 11:32:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FURNITURE](
	[ID] [uniqueidentifier] NOT NULL,
	[NAME] [nvarchar](50) NULL,
	[REGISTER DATE] [date] NULL,
	[UPDATE DATE] [date] NULL,
	[IS ACTIVE] [bit] NULL,
 CONSTRAINT [PK_FURNITURE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MANAGEMENT]    Script Date: 12/14/2022 11:32:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MANAGEMENT](
	[ID] [uniqueidentifier] NOT NULL,
	[EMAIL] [varchar](50) NULL,
	[PASSWORD] [nvarchar](50) NULL,
	[REGISTER DATE] [date] NULL,
	[UPDATE DATE] [date] NULL,
	[IS ACTIVE] [bit] NULL,
 CONSTRAINT [PK_MANAGEMENT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PICTURE]    Script Date: 12/14/2022 11:32:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PICTURE](
	[ID] [uniqueidentifier] NOT NULL,
	[NAME] [varchar](50) NULL,
	[REGISTER DATE] [date] NULL,
	[UPDATE DATE] [date] NULL,
	[IS ACTIVE] [bit] NULL,
 CONSTRAINT [PK_PICTURE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRICE]    Script Date: 12/14/2022 11:32:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRICE](
	[ID] [uniqueidentifier] NOT NULL,
	[NAME] [nvarchar](50) NULL,
	[REGISTER DATE] [date] NULL,
	[UPDATE DATE] [date] NULL,
	[IS ACTIVE] [bit] NULL,
 CONSTRAINT [PK_PRICE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[REAL ESTATE]    Script Date: 12/14/2022 11:32:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[REAL ESTATE](
	[CITY] [uniqueidentifier] NULL,
	[DISTRICT] [uniqueidentifier] NULL,
	[FURNITURE] [uniqueidentifier] NULL,
	[PRICE] [uniqueidentifier] NULL,
	[SIZE] [uniqueidentifier] NULL,
	[TYPE] [uniqueidentifier] NULL,
	[WARMING] [uniqueidentifier] NULL,
	[ID] [uniqueidentifier] NOT NULL,
	[TITLE] [nvarchar](50) NULL,
	[REGISTER DATE] [datetime] NULL,
	[UPDATE DATE] [datetime] NULL,
	[IS ACTIVE] [bit] NULL,
 CONSTRAINT [PK_REAL ESTATE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[REAL ESTATE DETAIL]    Script Date: 12/14/2022 11:32:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[REAL ESTATE DETAIL](
	[ID] [uniqueidentifier] NOT NULL,
	[DESCRIPTION] [nvarchar](500) NULL,
	[REGISTER DATE] [date] NULL,
	[UPDATE DATE] [date] NULL,
	[IS ACTIVE] [bit] NULL,
 CONSTRAINT [PK_REAL ESTATE DETAIL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SIZE]    Script Date: 12/14/2022 11:32:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SIZE](
	[ID] [uniqueidentifier] NOT NULL,
	[NAME] [nvarchar](50) NULL,
	[REGISTER DATE] [date] NULL,
	[UPDATE DATE] [date] NULL,
	[IS ACTIVE] [bit] NULL,
 CONSTRAINT [PK_SIZE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TYPE]    Script Date: 12/14/2022 11:32:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TYPE](
	[ID] [uniqueidentifier] NOT NULL,
	[NAME] [nvarchar](50) NULL,
	[REGISTER DATE] [datetime] NULL,
	[UPDATE DATE] [datetime] NULL,
	[IS ACTIVE] [bit] NULL,
 CONSTRAINT [PK_REAL ESTATE TYPE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WARMING]    Script Date: 12/14/2022 11:32:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WARMING](
	[ID] [uniqueidentifier] NOT NULL,
	[NAME] [nvarchar](50) NULL,
	[REGISTER DATE] [date] NULL,
	[UPDATE DATE] [date] NULL,
	[IS ACTIVE] [bit] NULL,
 CONSTRAINT [PK_WARMING] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DISTRICT]  WITH CHECK ADD  CONSTRAINT [FK_DISTRICT_CITY] FOREIGN KEY([CITY])
REFERENCES [dbo].[CITY] ([ID])
GO
ALTER TABLE [dbo].[DISTRICT] CHECK CONSTRAINT [FK_DISTRICT_CITY]
GO
ALTER TABLE [dbo].[REAL ESTATE]  WITH CHECK ADD  CONSTRAINT [FK_REAL ESTATE_CITY] FOREIGN KEY([CITY])
REFERENCES [dbo].[CITY] ([ID])
GO
ALTER TABLE [dbo].[REAL ESTATE] CHECK CONSTRAINT [FK_REAL ESTATE_CITY]
GO
ALTER TABLE [dbo].[REAL ESTATE]  WITH CHECK ADD  CONSTRAINT [FK_REAL ESTATE_DISTRICT] FOREIGN KEY([DISTRICT])
REFERENCES [dbo].[DISTRICT] ([ID])
GO
ALTER TABLE [dbo].[REAL ESTATE] CHECK CONSTRAINT [FK_REAL ESTATE_DISTRICT]
GO
ALTER TABLE [dbo].[REAL ESTATE]  WITH CHECK ADD  CONSTRAINT [FK_REAL ESTATE_FURNITURE] FOREIGN KEY([FURNITURE])
REFERENCES [dbo].[FURNITURE] ([ID])
GO
ALTER TABLE [dbo].[REAL ESTATE] CHECK CONSTRAINT [FK_REAL ESTATE_FURNITURE]
GO
ALTER TABLE [dbo].[REAL ESTATE]  WITH CHECK ADD  CONSTRAINT [FK_REAL ESTATE_PRICE] FOREIGN KEY([PRICE])
REFERENCES [dbo].[PRICE] ([ID])
GO
ALTER TABLE [dbo].[REAL ESTATE] CHECK CONSTRAINT [FK_REAL ESTATE_PRICE]
GO
ALTER TABLE [dbo].[REAL ESTATE]  WITH CHECK ADD  CONSTRAINT [FK_REAL ESTATE_REAL ESTATE TYPE] FOREIGN KEY([TYPE])
REFERENCES [dbo].[TYPE] ([ID])
GO
ALTER TABLE [dbo].[REAL ESTATE] CHECK CONSTRAINT [FK_REAL ESTATE_REAL ESTATE TYPE]
GO
ALTER TABLE [dbo].[REAL ESTATE]  WITH CHECK ADD  CONSTRAINT [FK_REAL ESTATE_SIZE] FOREIGN KEY([SIZE])
REFERENCES [dbo].[SIZE] ([ID])
GO
ALTER TABLE [dbo].[REAL ESTATE] CHECK CONSTRAINT [FK_REAL ESTATE_SIZE]
GO
ALTER TABLE [dbo].[REAL ESTATE]  WITH CHECK ADD  CONSTRAINT [FK_REAL ESTATE_WARMING] FOREIGN KEY([WARMING])
REFERENCES [dbo].[WARMING] ([ID])
GO
ALTER TABLE [dbo].[REAL ESTATE] CHECK CONSTRAINT [FK_REAL ESTATE_WARMING]
GO
ALTER TABLE [dbo].[REAL ESTATE DETAIL]  WITH CHECK ADD  CONSTRAINT [FK_REAL ESTATE DETAIL_REAL ESTATE] FOREIGN KEY([ID])
REFERENCES [dbo].[REAL ESTATE] ([ID])
GO
ALTER TABLE [dbo].[REAL ESTATE DETAIL] CHECK CONSTRAINT [FK_REAL ESTATE DETAIL_REAL ESTATE]
GO
