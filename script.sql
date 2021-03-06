USE [admin]
GO
/****** Object:  Table [dbo].[users]    Script Date: 4/10/2016 2:29:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[passwd] [varchar](255) NULL,
	[email] [varchar](60) NULL,
	[profile] [varchar](50) NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL
) ON [PRIMARY]

GO
