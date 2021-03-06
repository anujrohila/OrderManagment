USE [ARohilaDatabase]
GO
/****** Object:  Table [dbo].[tbl_AdminLogin]    Script Date: 13-01-2015 14:36:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_AdminLogin](
	[AdminLoginId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](256) NULL,
	[RegisterDate] [datetime] NULL,
	[IsActive] [tinyint] NULL,
 CONSTRAINT [PK_tbl_AdminLogin] PRIMARY KEY CLUSTERED 
(
	[AdminLoginId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Category]    Script Date: 13-01-2015 14:36:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CatgeoryName] [varchar](200) NULL,
	[AliasName] [varchar](50) NULL,
	[Description] [varchar](max) NULL,
	[CreationDateTime] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tbl_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Tags]    Script Date: 13-01-2015 14:36:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Tags](
	[TagId] [int] IDENTITY(1,1) NOT NULL,
	[TagName] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_Tags] PRIMARY KEY CLUSTERED 
(
	[TagId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_AdminLogin] ON 

INSERT [dbo].[tbl_AdminLogin] ([AdminLoginId], [FirstName], [LastName], [UserName], [Password], [RegisterDate], [IsActive]) VALUES (1, N'Anuj', N'Rohila', N'admin', N'abc123', CAST(0x0000A3FF00000000 AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[tbl_AdminLogin] OFF
SET IDENTITY_INSERT [dbo].[tbl_Category] ON 

INSERT [dbo].[tbl_Category] ([CategoryId], [CatgeoryName], [AliasName], [Description], [CreationDateTime], [IsActive]) VALUES (1, N'Mobile', N'mob', N'Mobile Devices', CAST(0x0000A3FF00000000 AS DateTime), 1)
INSERT [dbo].[tbl_Category] ([CategoryId], [CatgeoryName], [AliasName], [Description], [CreationDateTime], [IsActive]) VALUES (2, N'Laptop', N'lap', N'Laptop Devices', CAST(0x0000A3FF00000000 AS DateTime), 0)
INSERT [dbo].[tbl_Category] ([CategoryId], [CatgeoryName], [AliasName], [Description], [CreationDateTime], [IsActive]) VALUES (3, N'Television', N'tel', N'Television Devices', CAST(0x0000A3FF00000000 AS DateTime), 1)
INSERT [dbo].[tbl_Category] ([CategoryId], [CatgeoryName], [AliasName], [Description], [CreationDateTime], [IsActive]) VALUES (4, N'Home Maker', N'home', N'Home Maker Devices', CAST(0x0000A3FF00000000 AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[tbl_Category] OFF
