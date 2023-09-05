USE [SysDevDB]
GO

/****** Object:  Table [dbo].[Branches]    Script Date: 06/09/2023 7:37:46 am ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Branches](
	[branchid] [uniqueidentifier] NOT NULL,
	[branchname] [nvarchar](max) NOT NULL,
	[branchcode] [nvarchar](max) NOT NULL,
	[address] [nvarchar](max) NOT NULL,
	[barangay] [nvarchar](max) NOT NULL,
	[city] [nvarchar](max) NOT NULL,
	[permitnumber] [nvarchar](max) NOT NULL,
	[branch_manager] [nvarchar](max) NOT NULL,
	[dateopened] [datetime2](7) NOT NULL,
	[isactive] [bit] NOT NULL,
 CONSTRAINT [PK_Branches] PRIMARY KEY CLUSTERED 
(
	[branchid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


