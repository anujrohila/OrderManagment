USE [OrderManagement]
GO
/****** Object:  Table [dbo].[tbl_AdminLogin]    Script Date: 22-01-2015 17:57:14 ******/
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
/****** Object:  Table [dbo].[tblAdminLogin]    Script Date: 22-01-2015 17:57:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblAdminLogin](
	[AdminId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](256) NULL,
	[RegisterDate] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tblAdminLogin] PRIMARY KEY CLUSTERED 
(
	[AdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCity]    Script Date: 22-01-2015 17:57:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCity](
	[CityId] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [varchar](50) NULL,
 CONSTRAINT [PK_tblCity] PRIMARY KEY CLUSTERED 
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblEmployee]    Script Date: 22-01-2015 17:57:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEmployee](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[JobTitle] [varchar](50) NULL,
	[MobileNo] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[OrganizationId] [int] NULL,
	[IsPrimary] [bit] NULL,
	[CreationOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[IsActive] [bit] NULL,
	[DeviceId] [varchar](256) NULL,
	[DeviceType] [varchar](50) NULL,
	[DeviceToken] [varchar](500) NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_tblEmployee] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblFavouriteOrganization]    Script Date: 22-01-2015 17:57:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFavouriteOrganization](
	[FavouriteId] [int] IDENTITY(1,1) NOT NULL,
	[FavOrganizationId] [int] NULL,
	[UserId] [int] NULL,
	[CreationOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
 CONSTRAINT [PK_tblFavouriteOrganization] PRIMARY KEY CLUSTERED 
(
	[FavouriteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblOrder]    Script Date: 22-01-2015 17:57:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOrder](
	[OrderId] [int] NOT NULL,
	[OrderDateTime] [datetime] NULL,
	[RequesterLoginId] [int] NULL,
	[RequesterOrganizationId] [int] NULL,
	[RecieverOrganizationId] [int] NULL,
	[StatusId] [int] NULL,
	[LastStatusDateTime] [datetime] NULL,
	[IsHandleByEmployeeId] [int] NULL,
 CONSTRAINT [PK_tblOrder] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblOrderItems]    Script Date: 22-01-2015 17:57:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblOrderItems](
	[ItemId] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NULL,
	[ItemName] [varchar](50) NULL,
	[Quantity] [float] NULL,
	[QuantityType] [varchar](50) NULL,
	[Prority] [int] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_tblOrderItems] PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblOrderStatus]    Script Date: 22-01-2015 17:57:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblOrderStatus](
	[StatusId] [int] IDENTITY(1,1) NOT NULL,
	[StatusName] [varchar](50) NULL,
 CONSTRAINT [PK_tblOrderStatus] PRIMARY KEY CLUSTERED 
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblOrganization]    Script Date: 22-01-2015 17:57:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblOrganization](
	[OrganizationId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[JobTitle] [varchar](50) NULL,
	[CityId] [int] NULL,
	[OrganizationName] [varchar](100) NULL,
	[Address] [varchar](500) NULL,
	[MobileNo] [varchar](50) NULL,
	[Latitute] [varchar](50) NULL,
	[Logitute] [varchar](50) NULL,
	[MapAddress] [varchar](500) NULL,
	[EmailAddress] [varchar](50) NULL,
	[OrganizationWebsite] [varchar](50) NULL,
	[CreationOn] [datetime] NULL,
	[ModificationOn] [datetime] NULL,
	[IsActive] [bit] NULL,
	[IsWorkingStatus] [bit] NULL,
	[IsWorkingStatusMessge] [varchar](500) NULL,
 CONSTRAINT [PK_tblOrganization] PRIMARY KEY CLUSTERED 
(
	[OrganizationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPayment]    Script Date: 22-01-2015 17:57:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPayment](
	[PaymentId] [int] NOT NULL,
	[OrganizationId] [int] NULL,
	[Amount] [nchar](10) NULL,
	[NoofDays] [int] NULL,
	[CreationDate] [datetime] NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_tblPayment] PRIMARY KEY CLUSTERED 
(
	[PaymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblSMSQueue]    Script Date: 22-01-2015 17:57:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblSMSQueue](
	[RowId] [int] IDENTITY(1,1) NOT NULL,
	[MobileNo] [varchar](50) NULL,
	[Message] [varchar](500) NULL,
	[CreationDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblMobileSMSQueue] PRIMARY KEY CLUSTERED 
(
	[RowId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_AdminLogin] ON 

INSERT [dbo].[tbl_AdminLogin] ([AdminLoginId], [FirstName], [LastName], [UserName], [Password], [RegisterDate], [IsActive]) VALUES (1, N'Anuj', N'Rohila', N'admin', N'abc123', CAST(0x0000A3FF00000000 AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[tbl_AdminLogin] OFF
SET IDENTITY_INSERT [dbo].[tblAdminLogin] ON 

INSERT [dbo].[tblAdminLogin] ([AdminId], [FirstName], [LastName], [UserName], [Password], [RegisterDate], [IsActive]) VALUES (1, N'Anuj', N'Rohila', N'admin', N'abc123', CAST(0x0000A3FF00000000 AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[tblAdminLogin] OFF
SET IDENTITY_INSERT [dbo].[tblCity] ON 

INSERT [dbo].[tblCity] ([CityId], [CityName]) VALUES (1, N'Surat')
SET IDENTITY_INSERT [dbo].[tblCity] OFF
SET IDENTITY_INSERT [dbo].[tblEmployee] ON 

INSERT [dbo].[tblEmployee] ([EmployeeId], [FirstName], [LastName], [JobTitle], [MobileNo], [Password], [OrganizationId], [IsPrimary], [CreationOn], [ModifiedOn], [IsActive], [DeviceId], [DeviceType], [DeviceToken], [IsDeleted]) VALUES (4, N'sdf', N'dsfsd', NULL, N'9510292597', N'3b9497', 6, 1, CAST(0x0000A427011E86CE AS DateTime), NULL, 1, NULL, NULL, NULL, 1)
INSERT [dbo].[tblEmployee] ([EmployeeId], [FirstName], [LastName], [JobTitle], [MobileNo], [Password], [OrganizationId], [IsPrimary], [CreationOn], [ModifiedOn], [IsActive], [DeviceId], [DeviceType], [DeviceToken], [IsDeleted]) VALUES (5, N'asdas', N'dasd', NULL, N'7359464467', N'dasda', 7, 1, CAST(0x0000A42800CC7643 AS DateTime), NULL, 1, NULL, NULL, NULL, 0)
INSERT [dbo].[tblEmployee] ([EmployeeId], [FirstName], [LastName], [JobTitle], [MobileNo], [Password], [OrganizationId], [IsPrimary], [CreationOn], [ModifiedOn], [IsActive], [DeviceId], [DeviceType], [DeviceToken], [IsDeleted]) VALUES (8, N'asdasd', N'asdasd', NULL, N'9510292597', N'asdfg', 10, 1, CAST(0x0000A4280118D922 AS DateTime), NULL, 1, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tblEmployee] OFF
SET IDENTITY_INSERT [dbo].[tblOrderStatus] ON 

INSERT [dbo].[tblOrderStatus] ([StatusId], [StatusName]) VALUES (1, N'Pending')
INSERT [dbo].[tblOrderStatus] ([StatusId], [StatusName]) VALUES (2, N'Open')
INSERT [dbo].[tblOrderStatus] ([StatusId], [StatusName]) VALUES (3, N'Process')
INSERT [dbo].[tblOrderStatus] ([StatusId], [StatusName]) VALUES (4, N'Packed')
INSERT [dbo].[tblOrderStatus] ([StatusId], [StatusName]) VALUES (5, N'Deliver')
INSERT [dbo].[tblOrderStatus] ([StatusId], [StatusName]) VALUES (6, N'Recieve')
INSERT [dbo].[tblOrderStatus] ([StatusId], [StatusName]) VALUES (7, N'Complete')
SET IDENTITY_INSERT [dbo].[tblOrderStatus] OFF
SET IDENTITY_INSERT [dbo].[tblOrganization] ON 

INSERT [dbo].[tblOrganization] ([OrganizationId], [FirstName], [LastName], [JobTitle], [CityId], [OrganizationName], [Address], [MobileNo], [Latitute], [Logitute], [MapAddress], [EmailAddress], [OrganizationWebsite], [CreationOn], [ModificationOn], [IsActive], [IsWorkingStatus], [IsWorkingStatusMessge]) VALUES (6, N'sdf', N'dsfsd', NULL, 1, N'dsf', NULL, N'fdsf', NULL, NULL, NULL, NULL, NULL, CAST(0x0000A427011E86CE AS DateTime), NULL, 1, NULL, NULL)
INSERT [dbo].[tblOrganization] ([OrganizationId], [FirstName], [LastName], [JobTitle], [CityId], [OrganizationName], [Address], [MobileNo], [Latitute], [Logitute], [MapAddress], [EmailAddress], [OrganizationWebsite], [CreationOn], [ModificationOn], [IsActive], [IsWorkingStatus], [IsWorkingStatusMessge]) VALUES (7, N'asdas', N'dasd', NULL, 1, N'asd', NULL, N'asdas', NULL, NULL, NULL, NULL, NULL, CAST(0x0000A42800CC7643 AS DateTime), NULL, 1, NULL, NULL)
INSERT [dbo].[tblOrganization] ([OrganizationId], [FirstName], [LastName], [JobTitle], [CityId], [OrganizationName], [Address], [MobileNo], [Latitute], [Logitute], [MapAddress], [EmailAddress], [OrganizationWebsite], [CreationOn], [ModificationOn], [IsActive], [IsWorkingStatus], [IsWorkingStatusMessge]) VALUES (10, N'asdasd', N'asdasd', NULL, 1, N'asd', NULL, N'9510292597', NULL, NULL, NULL, NULL, NULL, CAST(0x0000A4280118D922 AS DateTime), NULL, 1, 1, N'Available')
SET IDENTITY_INSERT [dbo].[tblOrganization] OFF
SET IDENTITY_INSERT [dbo].[tblSMSQueue] ON 

INSERT [dbo].[tblSMSQueue] ([RowId], [MobileNo], [Message], [CreationDateTime]) VALUES (1, N'asdas', N'Register successsfully.', CAST(0x0000A42800CC9D2F AS DateTime))
INSERT [dbo].[tblSMSQueue] ([RowId], [MobileNo], [Message], [CreationDateTime]) VALUES (2, N'9510292597', N'Register successsfully.', CAST(0x0000A42801073DA5 AS DateTime))
INSERT [dbo].[tblSMSQueue] ([RowId], [MobileNo], [Message], [CreationDateTime]) VALUES (3, N'9510292597', N'Register successsfully.', CAST(0x0000A42801167F9C AS DateTime))
INSERT [dbo].[tblSMSQueue] ([RowId], [MobileNo], [Message], [CreationDateTime]) VALUES (4, N'9510292597', N'Register successsfully.', CAST(0x0000A4280118DA33 AS DateTime))
SET IDENTITY_INSERT [dbo].[tblSMSQueue] OFF
ALTER TABLE [dbo].[tblEmployee]  WITH CHECK ADD  CONSTRAINT [FK_tblEmployee_tblEmployee] FOREIGN KEY([OrganizationId])
REFERENCES [dbo].[tblOrganization] ([OrganizationId])
GO
ALTER TABLE [dbo].[tblEmployee] CHECK CONSTRAINT [FK_tblEmployee_tblEmployee]
GO
ALTER TABLE [dbo].[tblOrder]  WITH CHECK ADD  CONSTRAINT [FK_tblOrder_tblOrderStatus] FOREIGN KEY([StatusId])
REFERENCES [dbo].[tblOrderStatus] ([StatusId])
GO
ALTER TABLE [dbo].[tblOrder] CHECK CONSTRAINT [FK_tblOrder_tblOrderStatus]
GO
ALTER TABLE [dbo].[tblOrderItems]  WITH CHECK ADD  CONSTRAINT [FK_tblOrderItems_tblOrder] FOREIGN KEY([OrderId])
REFERENCES [dbo].[tblOrder] ([OrderId])
GO
ALTER TABLE [dbo].[tblOrderItems] CHECK CONSTRAINT [FK_tblOrderItems_tblOrder]
GO
ALTER TABLE [dbo].[tblOrganization]  WITH CHECK ADD  CONSTRAINT [FK_tblOrganization_tblCity] FOREIGN KEY([CityId])
REFERENCES [dbo].[tblCity] ([CityId])
GO
ALTER TABLE [dbo].[tblOrganization] CHECK CONSTRAINT [FK_tblOrganization_tblCity]
GO
ALTER TABLE [dbo].[tblPayment]  WITH CHECK ADD  CONSTRAINT [FK_tblPayment_tblOrganization] FOREIGN KEY([OrganizationId])
REFERENCES [dbo].[tblOrganization] ([OrganizationId])
GO
ALTER TABLE [dbo].[tblPayment] CHECK CONSTRAINT [FK_tblPayment_tblOrganization]
GO
