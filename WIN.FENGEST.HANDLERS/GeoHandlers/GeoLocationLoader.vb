Public Class GeoLocationController
   Protected Shared m_Instance As GeoLocationController
   Protected m_GeoLocationHandler As GeoLocationHandler
   'Private Shared m_ResetEvent As System.Threading.ManualResetEvent = New System.Threading.ManualResetEvent(True)
   Public Shared Function Instance() As GeoLocationController
      'm_ResetEvent.WaitOne()
      If m_Instance Is Nothing Then
         'm_ResetEvent.Reset()
         m_Instance = New GeoLocationController
      End If
      Return m_Instance
   End Function

   Friend Function GetGeoHandler() As GeoLocationHandler
      Return Me.m_GeoLocationHandler
   End Function
#Region "Metodi per il calcolo del CF"
   ''' <summary>
   ''' Metodo che calcola il codice fiscale
   ''' </summary>
   ''' <param name="nome"></param>
   ''' <param name="cognome"></param>
   ''' <param name="Sesso">Parametri ammessi: "MASCHIO" , "FEMMINA"</param>
   ''' <param name="DataNascita"></param>
   ''' <param name="NomeComuneNascita"></param>
   ''' <param name="NomeNazionalita"></param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Function CalcolaCodiceFiscale(ByVal Nome As String, ByVal Cognome As String, ByVal Sesso As String, _
                                         ByVal DataNascita As Date, ByVal NomeComuneNascita As String, ByVal NomeNazionalita As String) As String

      Dim nazione As Nazione = New NazioneNulla
      Dim comune As Comune = New ComuneNullo
      Dim sex As Int32 = 1
      If Sesso = "MASCHIO" Then
         sex = 1
      ElseIf Sesso = "FEMMINA" Then
         sex = 2
      Else
         Throw New Exception("Valore non valido per il sesso")
      End If

      If NomeNazionalita <> "ITALIA" Then
         nazione = Me.m_GeoLocationHandler.GetNazioneByName(NomeNazionalita)
         Return CodiceFiscaleCalculator.CalcolaCodiceFiscale(Nome, Cognome, DataNascita, sex, nazione.CodiceFiscale, "")
      Else
         comune = Me.m_GeoLocationHandler.GetComuneByName(NomeComuneNascita)
         Return CodiceFiscaleCalculator.CalcolaCodiceFiscale(Nome, Cognome, DataNascita, sex, "", comune.CodiceFiscale)
      End If

   End Function

   Public Function CalcolaDatiFiscali(ByVal codiceFiscale As String) As DatiFiscali


      Return CodiceFiscaleCalculator.GetDatiFiscali(codiceFiscale, New GeoPersistenceService)


   End Function
#End Region


#Region "Metodi wrap dell'oggetto Geo"
   Public Function GetListaNazioni() As IList

      Return m_GeoLocationHandler.GetListaNomiNazioni
   End Function
   Public Function GetListaProvincie() As IList

      Return m_GeoLocationHandler.GetListaNomiProvincie
   End Function
   'Public Function GetListaComuni() As IList

   '   Return m_GeoLocationHandler.GetListaNomiComuni
   'End Function

   'Public Function GetListaOggettiComune() As IList

   '   Return m_GeoLocationHandler.GetComuni
   'End Function

   Public Function GetListaRegioni() As IList

      Return m_GeoLocationHandler.GetListaNomiRegioni
   End Function


    Public Function GetSiglaProvinciaByNomeProvincia(ByVal NomeProvincia As String) As String
        Dim prov As Provincia = m_GeoLocationHandler.GetProvinciaByName(NomeProvincia)
        Return prov.Sigla
    End Function


   Public Function GetNomeProvinciaByNomeComune(ByVal NomeComune As String) As String
      Dim com As Comune = m_GeoLocationHandler.GetComuneByName(NomeComune)
      Return m_GeoLocationHandler.GetProvinciaById(com.IdProvincia).Descrizione
   End Function
   'Public Function GetNomeNazioneByNomeNazione(ByVal NomeNazione As String) As String
   '   Dim naz As Nazione = m_GeoLocationHandler.GetNazioneByName(NomeNazione)
   '   Return m_GeoLocationHandler.GetProvinciaById(naz.Id).
   'End Function

   Public Function GetListaComuniPerProvincia(ByVal NomeProvincia As String) As IList
      Return m_GeoLocationHandler.GetNomiComuniPerProvincia(NomeProvincia)
   End Function
   Public Function GetCapForComune(ByVal NomeComune As String)
      Dim com As Comune = m_GeoLocationHandler.GetComuneByName(NomeComune)
      Return com.CAP
    End Function
    Public Function ExistComune(ByVal NomeComune As String) As Boolean
        Dim com As Comune = m_GeoLocationHandler.GetComuneByName(NomeComune)
        If com.Id = -1 Then
            Return False
        End If
        Return True
    End Function

    Public Function ExistNazione(ByVal NomeNazione As String) As Boolean
        Dim com As Nazione = m_GeoLocationHandler.GetNazioneByName(NomeNazione)
        If com.Id = -1 Then
            Return False
        End If
        Return True
    End Function


#End Region




#Region "Metodi per il caricamento dell'oggetto GeoHandler"
   Private Shared Function LoadComuni() As Hashtable

      Dim m_Comuni As New Hashtable
      For Each com As Comune In GetComuni()
         m_Comuni.Add(com.Descrizione, com)
      Next
      Return m_Comuni

   End Function
   Private Shared Function LoadRegioni() As Hashtable

      Dim m_Regioni As New Hashtable
      For Each Reg As Regione In GetRegioni()
         m_Regioni.Add(Reg.Descrizione, Reg)
      Next
      Return m_Regioni

   End Function
   Private Shared Function LoadProvincie() As Hashtable

      Dim m_Provincie As New Hashtable
      For Each prov As Provincia In GetProvincie()
         m_Provincie.Add(prov.Descrizione, prov)
      Next
      Return m_Provincie

   End Function
   Private Shared Function LoadNazioni() As Hashtable

      Dim m_Nazioni As New Hashtable
      For Each Naz As Nazione In GetNazioni()
         m_Nazioni.Add(Naz.Descrizione, Naz)
      Next
      Return m_Nazioni

   End Function
   Protected Sub New()
      LoadGeoLocatonHandler()
      'm_ResetEvent.Set()
   End Sub

   Private Sub Initialize()

   End Sub
   Private Sub LoadGeoLocatonHandler()
      If m_GeoLocationHandler Is Nothing Then
         
         'm_GeoLocationHandler = New GeoLocationHandler(LoadNazioni, LoadRegioni, LoadProvincie, LoadComuni)
         m_GeoLocationHandler = New GeoLocationHandler(New GeoPersistenceService)
      End If
   End Sub
   Private Shared Function GetComuni() As System.Collections.IList
      ' Dim time As Integer = Environment.TickCount
      ' Debug.WriteLine(time)
      Return DataAccessServices.Instance.PersistenceFacade.GetAllObjects("Comune")
      ' Debug.WriteLine((Environment.TickCount - time).ToString)
   End Function
   Private Shared Function GetNazioni() As System.Collections.IList
      Return DataAccessServices.Instance.PersistenceFacade.GetAllObjects("Nazione")
   End Function
   Private Shared Function GetProvincie() As System.Collections.IList
      Return DataAccessServices.Instance.PersistenceFacade.GetAllObjects("Provincia")
   End Function
   Private Shared Function GetRegioni() As System.Collections.IList
      Return DataAccessServices.Instance.PersistenceFacade.GetAllObjects("Regione")
   End Function
#End Region

End Class
