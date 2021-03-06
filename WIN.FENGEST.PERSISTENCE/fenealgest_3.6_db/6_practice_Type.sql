USE [FengestDB]
GO
/****** Oggetto:  Table [dbo].[DB_PRACTICE_TYPE]    Data script: 03/10/2015 18:37:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DB_PRACTICE_TYPE](
	[ID] [int] NOT NULL,
	[Description] [nvarchar](80) COLLATE Latin1_General_CI_AS NULL,
	[JollyUser] [int] NULL,
	[RestrictedPermissions] [bit] NULL,
	[ControlUser] [int] NULL,
	[IntegrationUser] [int] NULL,
	[DocumentationVerifiedUser] [int] NULL,
	[CloseUser] [int] NULL,
	[RejectedUser] [int] NULL,
 CONSTRAINT [PK_DB_PRACTICE_TYPE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
