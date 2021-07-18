USE [House Rent]
GO

/****** Object:  Table [dbo].[RecordTab]    Script Date: 7/18/2021 8:57:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RecordTab](
	[S_No] [int] NULL,
	[U_Name] [varchar](50) NULL,
	[Month] [varchar](50) NULL,
	[Year] [varchar](50) NULL,
	[HouseRent] [varchar](50) NULL,
	[ElectricBill] [varchar](50) NULL,
	[GasBill] [varchar](50) NULL,
	[WaterBill] [varchar](50) NULL,
	[TotalRent] [varchar](50) NULL,
	[ReceivedAmmount] [varchar](50) NULL,
	[DueAmmount] [varchar](50) NULL,
	[Name] [varchar](50) NULL
) ON [PRIMARY]
GO


