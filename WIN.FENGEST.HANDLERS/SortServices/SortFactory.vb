Public Class SortFactory
   ''' <summary>
   ''' Restituisce il corretto servizio di riordinamento
   ''' </summary>
   ''' <param name="PropertyName"></param>
   ''' <param name="Descending"></param>
   ''' <param name="ObjType">Valori ammessi: "Itemcontabile", "DtoItemContabile", "Utenti", "Deleghe"</param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Shared Function GetItemComparer(ByVal PropertyName As String, Optional ByVal Descending As Boolean = False, Optional ByVal ObjType As String = "ItemContabile") As IComparer
      'If VerifyProperty(PropertyName) = "#" Then Return New ItemNullComparer
      Select Case ObjType
         Case "ItemContabile"
            Return New ItemsComparer(PropertyName, Descending)
            'End Select
         Case "DtoItemContabile"
            Return New ItemsDTOComparer(PropertyName, Descending)
            'End Select

         Case "QuotaDTOComparer"
            Return New QuotaDTOComparer(PropertyName, Descending)


         Case "DTOLavoratoreLibero"
            Return New LavoratoreLiberoComparer(PropertyName, Descending)
         Case "IscrittiDTO"
            Return New IscrittoDTOComparer(PropertyName, Descending)
         Case "NonIscrittiDTO"
            Return New NonIscrittoDTOComparer(PropertyName, Descending)
         Case "DelegheDTO"
            Return New DelegheDTOComparer(PropertyName, Descending)
         Case "Deleghe"
            Return New DelegheComparer(PropertyName, Descending)
         Case "Utenti"
            Return New UtenteComparer(PropertyName, Descending)
         Case "OfferteLavoro"
            Return New OffertaLavoroComparer(PropertyName, Descending)
         Case "Prestazioni"
            Return New PrestazioniComparer(PropertyName, Descending)
         Case "PrestazioniDTO"
            Return New PrestazioneDTOComparer(PropertyName, Descending)
         Case "Vertenze"
            Return New VertenzeComparer(PropertyName, Descending)
         Case "VertenzeDTO"
            Return New VertenzaDTOComparer(PropertyName, Descending)
         Case "ElectronicDocument"
            Return New ElectronicDocumentComparer(PropertyName, Descending)
         Case Else
            Throw New ArgumentOutOfRangeException
      End Select

   End Function


   'Private Shared Function VerifyProperty(ByVal PropertyName As String) As String
   '   Select Case PropertyName
   '      Case "Note"
   '         Return ""
   '      Case "Referente"
   '         Return ""
   '      Case "Utente"
   '         Return ""
   '      Case "Conto"
   '         Return ""
   '      Case "DataRegistrazione"
   '         Return ""
   '      Case "DataDocumento"
   '         Return ""
   '      Case "DocumentoPadre"
   '         Return ""
   '      Case "SoggettoEsecutore"
   '         Return ""
   '      Case "Congruita"
   '         Return ""
   '      Case "PagamentoReferente"
   '         Return ""
   '      Case "AziendaImpiego"
   '         Return ""
   '      Case "ContrattoApplicato"
   '         Return ""
   '      Case "LivelloInquadramento"
   '         Return ""
   '      Case "OreLavorate"
   '         Return ""
   '      Case "OreMalattia"
   '         Return ""
   '      Case "QuotaMedia"
   '         Return ""
   '      Case "ImportoRistorno"
   '         Return ""
   '      Case "ImpRist"
   '         Return ""
   '      Case "ImportoPosizione"
   '         Return ""
   '      Case "Importo"
   '         Return ""
   '      Case "Prestazione"
   '         Return ""
   '      Case "TipoPrestazione"
   '         Return ""
   '      Case "TipoDocumento"
   '         Return ""
   '      Case "Competenza"
   '         Return ""
   '      Case "CompleteName"
   '         Return ""
   '      Case "CodiceFiscale"
   '         Return ""
   '      Case "IdUtente"
   '         Return ""
   '      Case "NomeAzienda"
   '         Return ""
   '      Case "DataNascita"
   '         Return ""
   '      Case "NomeStato"
   '         Return ""
   '      Case Else
   '         Return "#"
   '   End Select
   'End Function
End Class
