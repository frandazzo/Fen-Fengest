/*
   mercoledì 6 gennaio 201612:33:56
   Utente: RegUsr
   Server: NOESIS6\NOESIS
   Database: FengestDB
   Applicazione: 
*/

/* Per evitare potenziali problemi di perdita di dati, si consiglia di esaminare dettagliatamente lo script prima di eseguirlo al di fuori del contesto di Progettazione database.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.DB_CANTIERE ADD
	Zona nvarchar(150) NULL,
	Provincia nvarchar(150) NULL,
	Comune nvarchar(150) NULL,
	Importo float(53) NULL
GO
COMMIT
