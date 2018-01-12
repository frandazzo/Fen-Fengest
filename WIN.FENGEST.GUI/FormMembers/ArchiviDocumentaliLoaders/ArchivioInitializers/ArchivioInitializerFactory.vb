Public Class ArchivioInitializerFactory
   Public Shared Function GetInizializatore(ByVal Type As FrmArchivioDocumentale.TypeOfTargetArchivio)
      Select Case Type
         Case FrmArchivioDocumentale.TypeOfTargetArchivio.Aziende
            Return New InizializzatoreArchivioAzienda
         Case FrmArchivioDocumentale.TypeOfTargetArchivio.Segreteria
            Return New InizializzatoreArchivioSegreteria
         Case FrmArchivioDocumentale.TypeOfTargetArchivio.Utenti
            Return New InizializatoreArchivioUtenti
         Case Else
            Throw New ArgumentException("Tipo inizializzatore archivio documenti")
      End Select
   End Function
End Class
