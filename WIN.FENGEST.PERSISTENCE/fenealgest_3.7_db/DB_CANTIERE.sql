USE [FengestDB]
GO
/****** Oggetto:  Table [dbo].[DB_CANTIERE]    Data script: 12/29/2015 17:14:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DB_CANTIERE](
	[ID] [int] NOT NULL,
	[Id_Azienda] [int] NULL,
	[Descrizione] [nvarchar](500) COLLATE Latin1_General_CI_AS NULL,
	[DataFine] [datetime] NULL,
	[Notes] [nvarchar](max) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_DB_CANTIERE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[DB_CANTIERE]  WITH CHECK ADD  CONSTRAINT [FK_DB_CANTIERE_DB_AZIENDA] FOREIGN KEY([Id_Azienda])
REFERENCES [dbo].[DB_AZIENDA] ([ID])
GO
ALTER TABLE [dbo].[DB_CANTIERE] CHECK CONSTRAINT [FK_DB_CANTIERE_DB_AZIENDA]