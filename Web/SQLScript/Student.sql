USE [JiaJiao]
GO

/****** Object:  Table [dbo].[Student]    Script Date: 04/29/2014 17:31:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Student](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StuName] [nvarchar](50) NULL,
	[StuEmail] [nvarchar](50) NULL,
	[StuTel] [nvarchar](50) NULL,
	[StuAddress] [nvarchar](50) NULL,
	[RoleId] [int] NULL,
	[CreateTime] [datetime] NULL,
	[UpdteTime] [datetime] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


