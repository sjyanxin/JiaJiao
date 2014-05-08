USE [JiaJiao]
GO

/****** Object:  Table [dbo].[Teacher]    Script Date: 05/08/2014 10:52:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Teacher](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TeacherName] [nvarchar](50) NULL,
	[Image] [nvarchar](500) NULL,
	[TeacherTel] [nvarchar](50) NULL,
	[TeacherEmail] [nvarchar](50) NULL,
	[TeacherAddress] [nvarchar](50) NULL,
	[TeacherDescribe] [nvarchar](50) NULL,
	[RoleId] [int] NULL,
	[CreateTime] [datetime] NULL,
	[UpdateTime] [datetime] NULL,
	
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


