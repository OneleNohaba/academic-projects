USE [Library]
GO

ALTER TABLE [dbo].[archive] DROP CONSTRAINT [DF__archive__datetim__46E78A0C]
GO

/****** Object:  Table [dbo].[archive]    Script Date: 2024/10/28 16:15:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[archive]') AND type in (N'U'))
DROP TABLE [dbo].[archive]
GO

/****** Object:  Table [dbo].[archive]    Script Date: 2024/10/28 16:15:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[archive](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[file_Name] [varchar](150) NOT NULL,
	[desc] [varchar](max) NULL,
	[location] [varchar](max) NOT NULL,
	[datetime_created] [datetime] NOT NULL,
 CONSTRAINT [PK_archive] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[archive] ADD  DEFAULT (getdate()) FOR [datetime_created]
GO


