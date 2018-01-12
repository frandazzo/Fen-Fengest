
/****** Oggetto:  Table [dbo].[App_LastProtocols]    Data script: 12/03/2014 19:09:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[App_LastProtocols](
	[Year] [int] NOT NULL,
	[Protocol] [int] NULL,
 CONSTRAINT [PK_App_LastProtocols] PRIMARY KEY CLUSTERED 
(
	[Year] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
