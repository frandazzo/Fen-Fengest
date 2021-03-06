
/****** Oggetto:  Table [dbo].[App_Documents]    Data script: 12/03/2014 18:45:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[App_Documents](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Subject] [nvarchar](250) COLLATE Latin1_General_CI_AS NULL,
	[DocDate] [datetime] NULL,
	[DocYear] [int] NULL,
	[ScopeID] [int] NULL,
	[Responsable] [nvarchar](150) COLLATE Latin1_General_CI_AS NULL,
	[OperatorID] [int] NULL,
	[DestinationList] [nvarchar](max) COLLATE Latin1_General_CI_AS NULL,
	[AttachmentList] [nvarchar](max) COLLATE Latin1_General_CI_AS NULL,
	[DocVersus] [int] NULL,
	[DocTypeID] [int] NULL,
	[Priority] [int] NULL,
	[DocBody] [varbinary](max) NULL,
	[CreatedBy] [nvarchar](50) COLLATE Latin1_General_CI_AS NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedBy] [nvarchar](50) COLLATE Latin1_General_CI_AS NULL,
	[ModifiedOn] [datetime] NULL,
	[Protocol] [nvarchar](50) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_App_Documents] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[App_Destinations](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DocumentID] [int] NULL,
	[ContactID] [int] NULL,
 CONSTRAINT [PK_App_Destinations] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO


CREATE TABLE [dbo].[App_Attachments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DocumentId] [int] NULL,
	[Path] [nvarchar](max) COLLATE Latin1_General_CI_AS NULL,
	[FileName] [nvarchar](max) COLLATE Latin1_General_CI_AS NULL,
	[Notes] [nvarchar](max) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_App_Attachments] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO


SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[App_Documents]  WITH CHECK ADD  CONSTRAINT [FK_App_Documents_App_DocScope] FOREIGN KEY([ScopeID])
REFERENCES [dbo].[App_DocScope] ([ID])
GO
ALTER TABLE [dbo].[App_Documents] CHECK CONSTRAINT [FK_App_Documents_App_DocScope]
GO
ALTER TABLE [dbo].[App_Documents]  WITH CHECK ADD  CONSTRAINT [FK_App_Documents_App_DocType] FOREIGN KEY([DocTypeID])
REFERENCES [dbo].[App_DocType] ([ID])
GO
ALTER TABLE [dbo].[App_Documents] CHECK CONSTRAINT [FK_App_Documents_App_DocType]
GO
ALTER TABLE [dbo].[App_Documents]  WITH CHECK ADD  CONSTRAINT [FK_App_Documents_App_Operators] FOREIGN KEY([OperatorID])
REFERENCES [dbo].[App_Operators] ([ID])
GO
ALTER TABLE [dbo].[App_Documents] CHECK CONSTRAINT [FK_App_Documents_App_Operators]
GO


ALTER TABLE [dbo].[App_Destinations]  WITH CHECK ADD  CONSTRAINT [FK_App_Destinations_App_Customers] FOREIGN KEY([ContactID])
REFERENCES [dbo].[DB_UTENTE] ([ID])
GO
ALTER TABLE [dbo].[App_Destinations] CHECK CONSTRAINT [FK_App_Destinations_App_Customers]
GO
ALTER TABLE [dbo].[App_Destinations]  WITH CHECK ADD  CONSTRAINT [FK_App_Destinations_App_Documents] FOREIGN KEY([DocumentID])
REFERENCES [dbo].[App_Documents] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[App_Destinations] CHECK CONSTRAINT [FK_App_Destinations_App_Documents]
GO


ALTER TABLE [dbo].[App_Attachments]  WITH CHECK ADD  CONSTRAINT [FK_App_Attachments_App_Documents] FOREIGN KEY([DocumentId])
REFERENCES [dbo].[App_Documents] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[App_Attachments] CHECK CONSTRAINT [FK_App_Attachments_App_Documents]