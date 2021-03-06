USE [FengestDB]
GO
/****** Oggetto:  Table [dbo].[DB_SMSPROVIDERDATA]    Data script: 03/23/2015 07:53:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DB_SMSPROVIDERDATA](
	[ID] [int] NOT NULL,
	[Username] [nvarchar](50) COLLATE Latin1_General_CI_AS NULL,
	[Password] [nvarchar](50) COLLATE Latin1_General_CI_AS NULL,
	[ProviderName] [nvarchar](50) COLLATE Latin1_General_CI_AS NULL,
	[SmsOption1] [nvarchar](50) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_DB_SMSPROVIDERDATA] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
