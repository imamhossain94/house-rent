USE [House Rent Second]
GO

/****** Object:  Table [dbo].[UserTables]    Script Date: 7/18/2021 11:05:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserTables](
	[ID] [int] NULL,
	[Flat] [varchar](50) NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[UserEmail] [varchar](50) NULL,
	[ContactNo] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
	[JoiningMonth] [varchar](50) NULL,
	[DOB] [varchar](50) NULL,
	[UserImage] [image] NULL,
	[Name] [varchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


