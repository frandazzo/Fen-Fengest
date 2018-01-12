Public Class ControllerTipoComunicazione
   Inherits AbstractCodificheController

   Public Overrides Sub LoadByDescrizione(ByVal Descrizione As String)

      m_current = Nothing
      LoadAll()
      For Each elem As TipoComunicazione In Me.DomainObjectList
         If elem.Descrizione = Descrizione Then m_current = elem
      Next
      If m_current Is Nothing Then m_current = New TipoComunicazione

   End Sub

   Friend Function GetCausaleComunicazione(ByVal DescrizioneTipoComunicazione As String) As TipoComunicazione
      Me.LoadByDescrizione(DescrizioneTipoComunicazione)
      Return Current()
   End Function


   Private Function Current() As TipoComunicazione
      Return DirectCast(m_current, TipoComunicazione)
   End Function
   Public Overrides Sub CreateNew()
      m_current = New TipoComunicazione
   End Sub
   Public Overloads Overrides Sub CreateNew(ByVal Descrizione As String)

      m_current = New TipoComunicazione
      Current.Descrizione = Descrizione
      Save()

   End Sub
   ''' <summary>
   ''' Metodo che restituisce la lista delle descrizioni delle causali
   ''' </summary>
   ''' <returns></returns>
   ''' <remarks></remarks>

   Public Overrides Function GetCategoryObject() As String
      Return "TipoComunicazione"
   End Function

   'Public Function GetIdByDescrizione(ByVal Descrizione As String) As String
   '   Try
   '      LoadByDescrizione(Descrizione)
   '      Return Current.Id
   '   Catch ex As Exception
   '      Throw New Exception(ex.Message)
   '   End Try
   'End Function

   Friend Overrides Function GetCausaleById(ByVal Id As String) As AbstractPersistenceObject

      If Id = "" Then Id = -1
      If Id = -1 Then Return New TipoComunicazione
      Me.LoadById(Id)
      Return Current()

    End Function

    Protected Overrides Sub DoUpdate()

        'recupero l'oggetto per verificare che la sua descrizione è sms
        Dim tipo As TipoComunicazione = Ps.GetObjectReloadingCache("TipoComunicazione", m_current.Id)
        If tipo.Descrizione.ToUpper = "SMS" Then
            Throw New Exception("Questa causale non può essere modificata!")
        End If
        'RegistratoreElementi.Instance.Save(m_current, GetCategoryObject)
        Ps.UpdateObject(Me.GetCategoryObject, m_current)

    End Sub

   Public Overrides Function GetListaCausali() As System.Collections.ArrayList

      Dim list As New ArrayList
      LoadAll()
      For Each elem As TipoComunicazione In Me.DomainObjectList
         list.Add(elem.Descrizione)
      Next
      list.Sort()
      Return list

   End Function

    Sub CheckIfExistSmsTipoOrCreateIt()
        Dim l As IList = Ps.GetAllObjects("TipoComunicazione")

        For Each elem As TipoComunicazione In l
            If elem.Descrizione.ToUpper = "SMS" Then
                Return
            End If
        Next

        'visto che non cè lo creo
        Me.CreateNew("SMS")

    End Sub

End Class
