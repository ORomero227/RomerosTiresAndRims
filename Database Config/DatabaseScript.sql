USE [RomerosTiresAndRimsDB]
GO
/****** Object:  Table [dbo].[tblClients]    Script Date: 1/27/2024 6:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblClients](
	[Client_Id] [uniqueidentifier] NOT NULL,
	[FirstName] [varchar](20) NOT NULL,
	[Paternal_LastName] [varchar](20) NOT NULL,
	[Maternal_LastName] [varchar](20) NOT NULL,
	[Physical_Address] [varchar](30) NOT NULL,
	[Mailing_Address] [varchar](30) NOT NULL,
	[City] [varchar](20) NOT NULL,
	[ZipCode] [varchar](10) NOT NULL,
	[Birth_Date] [date] NOT NULL,
	[Cellular_Number] [varchar](20) NOT NULL,
	[Email] [varchar](30) NOT NULL,
	[Company_Name] [varchar](40) NOT NULL,
	[Company_City] [varchar](30) NOT NULL,
	[Client_Fee] [decimal](18, 0) NOT NULL,
	[Seller_Id] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_tblCustomers] PRIMARY KEY CLUSTERED 
(
	[Client_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSellers]    Script Date: 1/27/2024 6:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSellers](
	[Seller_Id] [uniqueidentifier] NOT NULL,
	[FirstName] [varchar](20) NOT NULL,
	[Paternal_LastName] [varchar](20) NOT NULL,
	[Maternal_LastName] [varchar](20) NOT NULL,
	[Physical_Address] [varchar](30) NOT NULL,
	[Mailing_Address] [varchar](30) NOT NULL,
	[City] [varchar](20) NOT NULL,
	[ZipCode] [varchar](10) NOT NULL,
	[Cellular_Number] [varchar](20) NOT NULL,
	[Email] [varchar](30) NOT NULL,
	[Department] [varchar](20) NOT NULL,
	[Specialization] [varchar](20) NOT NULL,
	[Hiring_Date] [date] NOT NULL,
	[Username] [varchar](30) NOT NULL,
	[Password] [varchar](30) NOT NULL,
 CONSTRAINT [PK_tblSellers] PRIMARY KEY CLUSTERED 
(
	[Seller_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblClients]  WITH CHECK ADD  CONSTRAINT [FK_tblCustomers_tblSellers] FOREIGN KEY([Seller_Id])
REFERENCES [dbo].[tblSellers] ([Seller_Id])
GO
ALTER TABLE [dbo].[tblClients] CHECK CONSTRAINT [FK_tblCustomers_tblSellers]
GO
