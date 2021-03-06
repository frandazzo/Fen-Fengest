
/****** Oggetto:  Table [dbo].[App_DocType]    Data script: 12/03/2014 18:27:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[App_DocType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DocTypeName] [nvarchar](50) COLLATE Latin1_General_CI_AS NULL,
	[ProtocolCode] [nvarchar](50) COLLATE Latin1_General_CI_AS NULL,
	[Color] [int] NULL,
	[CreatedBy] [nvarchar](50) COLLATE Latin1_General_CI_AS NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedBy] [nvarchar](50) COLLATE Latin1_General_CI_AS NULL,
	[ModifiedOn] [datetime] NULL,
	[NotDeletable] [bit] NULL,
 CONSTRAINT [PK_App_DocType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
