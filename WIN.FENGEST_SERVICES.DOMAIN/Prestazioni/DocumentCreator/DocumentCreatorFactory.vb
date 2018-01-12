Public Class DocumentCreatorFactory
   Public Shared Function GetAdapter(ByVal FileModello As String) As IDocumentCreatorAdapter
      If Not My.Computer.FileSystem.FileExists(FileModello) Then
         Return New DummyAdapter
      End If

        Dim filename As String = My.Computer.FileSystem.GetFileInfo(FileModello).Name

        If filename = My.Settings.Ds21_PDF Or filename = My.Settings.Ds21_PDF_OLD Then
            Return New PdfCompilerAdapter
        ElseIf filename = My.Settings.ASSEGNO_PER_PRESTAZIONI Then
            Return New PdfCompilerAssegnoFamiliareAdapter
        ElseIf filename = My.Settings.ASSEGGNO_INCLUSIONE Then
            Return New PdfCompilerASSEGGNO_INCLUSIONE
        ElseIf filename = My.Settings.ANFGESTSEP Then
            Return New PdfCompilerANFGESTSEP
        ElseIf filename = My.Settings.ASSEGNI_FAMIGLIA_NUMEROSA Then
            Return New PdfCompilerASSEGNI_FAMIGLIA_NUMEROSA
        ElseIf filename = My.Settings.ASSEGNO_FAMILIARE Then
            Return New PdfCompilerASSEGNO_FAMILIARE
        ElseIf filename = My.Settings.CONGEDO_PARENTALE Then
            Return New PdfCompilerCONGEDO_PARENTALE
        ElseIf filename = My.Settings.CURE_TERMALI Then
            Return New PdfCompilerCURE_TERMALI
        ElseIf filename = My.Settings.DICHIRAZIONE_MALATTIA Then
            Return New PdfCompilerDICHIRAZIONE_MALATTIA
        ElseIf filename = My.Settings.DISOCCUPAZIONE_REQUISITI_RIDOTTI Then
            Return New PdfCompilerDISOCCUPAZIONE_REQUISITI_RIDOTTI
        ElseIf filename = My.Settings.MATERNITA_OBBLIGATORIA Then
            Return New PdfCompilerMATERNITA_OBBLIGATORIA
        ElseIf filename = My.Settings.MODELLO_DETRAZIONI Then
            Return New PdfCompilerMODELLO_DETRAZIONI
        ElseIf filename = My.Settings.MODELLO_HANDICAP Then
            Return New PdfCompilerMODELLO_HANDICAP
        ElseIf filename = My.Settings.PERMANENZA_DS Then
            Return New PdfCompilerPERMANENZA_DS
        ElseIf filename = My.Settings.Setting10 Then
            Return New PdfCompilerSetting10
        ElseIf filename = My.Settings.Setting11 Then
            Return New PdfCompilerSetting11
        ElseIf filename = My.Settings.Setting12 Then
            Return New PdfCompilerSetting12
        ElseIf filename = My.Settings.Setting13 Then
            Return New PdfCompilerSetting13
        ElseIf filename = My.Settings.Setting18 Then
            Return New PdfCompilerSetting18
        ElseIf filename = My.Settings.Setting19 Then
            Return New PdfCompilerSetting19
        ElseIf filename = My.Settings.Setting3 Then
            Return New PdfCompilerSetting3
        ElseIf filename = My.Settings.Setting4 Then
            Return New PdfCompilerSetting4
        ElseIf filename = My.Settings.Setting6 Then
            Return New PdfCompilerSetting6
        ElseIf filename = "bolzano.pdf" Then
            Return New PdfCompilerDelega
        Else
            Return New GenericCreatorAdapter
        End If


   End Function
End Class
