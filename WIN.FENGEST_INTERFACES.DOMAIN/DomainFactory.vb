Public Class DomainFactory
   Public Shared Function GetDelegaNulla() As IDelega
      Dim asm As Reflection.Assembly
      Try
         Dim path As String = My.Application.Info.DirectoryPath
         asm = System.Reflection.Assembly.LoadFrom(path & "\WIN.FENGEST_SERVICES.DOMAIN.dll")
         Dim DelegaNulla As IDelega = asm.CreateInstance("WIN.DOMAIN.FED_SERVICES.DelegaNulla")
         asm = Nothing
         Return DelegaNulla
      Catch ex As Exception
         Throw New Exception("Impossibile creare una istanza di delega nulla" & vbCrLf & ex.Message)
      End Try
   End Function
    'Public Shared Function GetPrestazioneNulla() As IPrestazione
    '   Dim asm As Reflection.Assembly
    '   Try
    '      Dim path As String = My.Application.Info.DirectoryPath
    '      asm = System.Reflection.Assembly.LoadFrom(path & "\WIN.FENGEST_SERVICES.DOMAIN.dll")
    '      Dim PrestazioneNulla As IPrestazione = asm.CreateInstance("WIN.DOMAIN.FED_SERVICES.PrestazioneNulla")
    '      asm = Nothing
    '      Return PrestazioneNulla
    '   Catch ex As Exception
    '      Throw New Exception("Impossibile creare una istanza di prestazione nulla" & vbCrLf & ex.Message)
    '   End Try
    'End Function
   Public Shared Function GetVertenzaNulla() As IDocumento
      Dim asm As Reflection.Assembly
      Try
         Dim path As String = My.Application.Info.DirectoryPath
         asm = System.Reflection.Assembly.LoadFrom(path & "\WIN.FENGEST_SERVICES.DOMAIN.dll")
         Dim VertenzaNulla As IDocumento = asm.CreateInstance("WIN.DOMAIN.FED_SERVICES.VertenzaNulla")
         asm = Nothing
         Return VertenzaNulla
      Catch ex As Exception
         Throw New Exception("Impossibile creare una istanza di vertenza nulla" & vbCrLf & ex.Message)
      End Try
   End Function




   Public Shared Function GetContoNullo() As IConto
      Dim asm As Reflection.Assembly
      Try
         Dim path As String = My.Application.Info.DirectoryPath
         asm = System.Reflection.Assembly.LoadFrom(path & "\WIN.FENGEST_FINANCIAL.DOMAIN.dll")
         Dim ContoNullo As IConto = asm.CreateInstance("WIN.DOMAIN.FINANCIAL.ContoNullo")
         asm = Nothing
         Return ContoNullo
      Catch ex As Exception
         Throw New Exception("Impossibile creare una istanza di conto nulla" & vbCrLf & ex.Message)
      End Try
   End Function
   Public Shared Function GetDocumentoNullo() As IDocumento
      Dim asm As Reflection.Assembly
      Try
         Dim path As String = My.Application.Info.DirectoryPath
         asm = System.Reflection.Assembly.LoadFrom(path & "\WIN.FENGEST_FINANCIAL.DOMAIN.dll")
         Dim DocNullo As IDocumento = asm.CreateInstance("WIN.DOMAIN.FINANCIAL.DocumentoNullo")
         asm = Nothing
         Return DocNullo
      Catch ex As Exception
         Throw New Exception("Impossibile creare una istanza di conto nulla" & vbCrLf & ex.Message)
      End Try
   End Function
End Class
