Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class OpenDocumentoCommand
   Inherits OpenCommand
   Private m_TipoDocumento As String = ""


    Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
        Return New ControlDocumentView
    End Function
    Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
        Return New ControlDocumentView(Id, m_TipoDocumento)
    End Function



    Protected Overrides Function ObjectToOpenName() As String
        Return "Documento"
    End Function

    <Secure(Area:="Documenti", Alias:="Visualizzazione", Macroarea:="Amministrazione")> _
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
        SecurityManager.Instance.Check()
        Control.AddLinkCommand("ViewDocumento", New OpenDocumentoCommand)
        Control.AddLinkCommand("CreateNewPagamento", New OpenNewPagamentoCommand)
        Control.AddLinkCommand("CreateNewPagamentoInps", New OpenNewPagamentoInpsCommand)
        Control.AddLinkCommand("CreateNewPagamentoPrevisionale", New OpenNewPagamentoPrevisionaleCommand)
        Control.AddLinkCommand("CreateNewPagamentoVertenza", New OpenNewPagamentoVertenzaCommand)
        Control.AddLinkCommand("CreateNewRistorno", New OpenNewRistorno)
        Control.AddLinkCommand("ViewReferente", New OpenAnagraficaReferenteCommand)
        Control.AddLinkCommand("ViewInps", New OpenInpsCommand)
        Control.AddLinkCommand("ViewVertenza", New OpenVertenzaCommand)
        Control.AddLinkCommand("ViewEnte", New OpenEnteCommand)
        Control.AddLinkCommand("ViewUtente", New OpenAnagraficaUtenteCommand)
        Control.AddLinkCommand("ViewAzienda", New OpenAnagraficaAziendaCommand)
        Control.AddLinkCommand("ViewReportIncassiQuote", New OpenRptIQ)

    End Sub

    'Public Overloads Overrides Sub Execute(ByVal WithParameter As System.Collections.Hashtable)
    '   'Se richiamo questo metodo di questo comando vuol dire che  ho un id
    '   'e che deve essere presentato l'offetto
    '   Dim id As Int32
    '   Try
    '      id = WithParameter.Item("Id")
    '      m_TipoDocumento = WithParameter.Item("TipoDocumento")
    '   Catch ex As Exception
    '      Throw New Exception("Impossibile eseguire il comando di apertura " & ObjectToOpenName() & " poichè non esiste un identificativo.")
    '   End Try
    '   Open(id)
    'End Sub



    Public Overloads Overrides Sub Execute(ByVal WithParameter As System.Collections.Hashtable)
        'Se richiamo questo metodo di questo comando vuol dire che  ho un id
        'e che deve essere presentato l'offetto
        Dim id As Int32
        Dim clearCache As Boolean = False
        Try
            id = WithParameter.Item("Id")
            m_TipoDocumento = WithParameter.Item("TipoDocumento")
            If WithParameter.ContainsKey("ClearCache") Then
                clearCache = WithParameter.Item("ClearCache")
            End If
        Catch ex As Exception
            Throw New Exception("Impossibile eseguire il comando di apertura " & ObjectToOpenName() & " poichè non esiste un identificativo.")
        End Try
        Open(id, clearCache)
    End Sub


    Protected Overloads Sub Open(ByVal Id As Int32, ByVal ClearCache As Boolean)
        Dim control As BrowserControl = CreateTargetControl(Id, ClearCache)
        Forward(control)
    End Sub


    Protected Overloads Function CreateTargetControl(ByVal Id As Int32, ByVal ClearCache As Boolean) As BrowserControl

        MyBase.m_IdObjectToOpen = Id
        Dim control As BrowserControl = DoCreateTargetControl(Id, ClearCache)
        SetTargetControlReceviers(control)
        Return control


    End Function

    Protected Overloads Function DoCreateTargetControl(ByVal Id As Int32, ByVal ClearCache As Boolean) As PRESENTATION.BrowserControl
        Return New ControlDocumentView(Id, m_TipoDocumento, ClearCache)
    End Function




End Class
