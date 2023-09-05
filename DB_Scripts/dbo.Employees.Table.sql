USE [SysDevDB]
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 06/09/2023 7:36:12 am ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employees](
	[employeeid] [uniqueidentifier] NOT NULL,
	[last_name] [nvarchar](max) NOT NULL,
	[first_name] [nvarchar](max) NOT NULL,
	[middle_name] [nvarchar](max) NOT NULL,
	[datehired] [datetime2](7) NOT NULL,
	[isactive] [bit] NOT NULL,
	[imagepath] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[employeeid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


