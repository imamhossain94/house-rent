USE [House Rent Second]
GO

/****** Object:  Table [dbo].[Admin]    Script Date: 7/18/2021 11:04:55 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Admin](
	[Name] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[DOB] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
	[Themes] [varchar](50) NULL,
	[Image] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


