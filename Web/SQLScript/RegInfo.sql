USE [JiaJiao]
GO

/****** Object:  Table [dbo].[RegInfo]    Script Date: 04/29/2014 17:31:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RegInfo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TeacherId] [int] NULL,
	[DayId] [int] NULL,
	[StuId] [nchar](10) NULL,
	[CreateTime] [datetime] NULL,
	[UpdateTime] [datetime] NULL,
 CONSTRAINT [PK_RegInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


