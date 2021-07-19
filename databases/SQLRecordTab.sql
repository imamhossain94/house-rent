USE [House Rent Second]
GO

/****** Object:  Table [dbo].[RecordTab]    Script Date: 7/18/2021 11:05:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RecordTab](
	[S_No] [int] NULL,
	[U_Name] [varchar](50) NULL,
	[Month] [varchar](50) NULL,
	[Year] [varchar](50) NULL,
	[HouseRent] [int] NULL,
	[ElectricBill] [int] NULL,
	[GasBill] [int] NULL,
	[WaterBill] [int] NULL,
	[TotalRent] [int] NULL,
	[ReceivedAmmount] [int] NULL,
	[DueAmmount] [int] NULL,
	[Name] [varchar](50) NULL
) ON [PRIMARY]
GO


