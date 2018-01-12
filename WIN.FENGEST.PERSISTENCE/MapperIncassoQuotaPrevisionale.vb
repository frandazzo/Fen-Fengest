Public Class MapperIncassoQuotaPrevisionale
    Inherits MapperIncassoQuotaAssociativa


    Protected Overrides Function FindByKeyStatement() As String
        Return "Select * from DB_DOCUMENTO_CONTABILE where Id = @Id and TIPO_DOCUMENTO = 'IQP'"
    End Function

    Public Sub New()
        'MyBase.Cache = New PersistentObjectCache(True)
    End Sub
    '#Region "Istruzioni Sql"
    '    Protected Overrides Function FindAllStatement() As String 
    '        Return "Select * from DB_DOCUMENTO_CONTABILE"
    '    End Function
    '    Protected Overrides Function FindByKeyStatement() As String
    '        Return "Select * from DB_DOCUMENTO_CONTABILE where Id = @Id and TIPO_DOCUMENTO = 'IQP'"
    '    End Function
    '    Protected Overrides Function InsertStatement() As String
    '        Return "Insert into DB_DOCUMENTO_CONTABILE (ID, DATA_REGISTRAZIONE, DATA_DOCUMENTO, NOTE_DOC, TIPO_DOCUMENTO, DATA_INIZIO_COMP, DATA_FINE_COMP, IMPORTO, VALUTA, ID_AZIENDA, ID_SETTORE, CreatedBy, CreatedOn) values (@Id, @Drg, @Ddc, @Not, @Tdc, @Di, @Df, @Imp, @Val, @Az, @Ids, @CRby, @CRon)"
    '    End Function
    '    Protected Overrides Function UpdateStatement() As String
    '        Return "UPDATE DB_DOCUMENTO_CONTABILE SET DATA_REGISTRAZIONE = @Drg, " _
    '              & "DATA_DOCUMENTO = @Ddc, NOTE_DOC = @Not, TIPO_DOCUMENTO = @Tdc, " _
    '              & "DATA_INIZIO_COMP = @Di, DATA_FINE_COMP = @Df, IMPORTO = @Imp, " _
    '              & "VALUTA = @Val, ID_AZIENDA = @Az, ID_SETTORE = @Ids, ModifiedBy = @MOby, ModifiedOn = @MOon   WHERE (Id =@Id) "
    '    End Function
    '    Protected Overrides Function DeleteStatement() As String
    '        Return "Delete from DB_DOCUMENTO_CONTABILE where Id = @Id"
    '    End Function
    '    Protected Overrides Function FindNextKeyStatement() As String
    '        Return "Select Max(Id) from DB_DOCUMENTO_CONTABILE"
    '    End Function
    '#End Region


    Protected Overrides Function CreateNewObject() As AbstractPersistenceObject
        Return New IncassoQuotaPrevisionale
    End Function

    Public Overrides Function FindObjectByIdReloadingCache(ByVal Id As Integer) As AbstractPersistenceObject

        Return DirectCast(MyBase.FindByKeyReloadingCache(New Key(Id)), IncassoQuotaPrevisionale)

    End Function


    Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

        Return DirectCast(MyBase.FindByKey(New Key(Id)), IncassoQuotaPrevisionale)

    End Function

    Protected Overrides Sub BuildObject(ByVal Item As AbstractPersistenceObject, ByVal Key As Key, ByVal rs As System.Collections.Hashtable)
        MyBase.BuildObject(Item, Key, rs)

        Dim Incasso As IncassoQuotaPrevisionale = DirectCast(Item, IncassoQuotaPrevisionale)

        Dim Di As DateTime = IIf(rs("DATA_INIZIO_COMP") IsNot Nothing, rs("DATA_INIZIO_COMP"), DateTime.MinValue)
        Dim Df As DateTime = IIf(rs("DATA_FINE_COMP") IsNot Nothing, rs("DATA_FINE_COMP"), DateTime.MinValue)
        Dim Imp As Double = IIf(rs("IMPORTO") IsNot Nothing, rs("IMPORTO"), 0)
        Dim valuta As Moneta.Valuta = IIf(rs("VALUTA") IsNot Nothing, rs("VALUTA"), Moneta.Valuta.Euro)
        Dim Id_Azienda As Int32 = IIf(rs("ID_AZIENDA") IsNot Nothing, rs("ID_AZIENDA"), -1)
        Dim ID_SETTORE As Int32 = IIf(rs("ID_SETTORE") IsNot Nothing, rs("ID_SETTORE"), -1)

        Dim MapperSettore As MapperSettore = PersistenceMapperRegistry.Instance.GetMapperByName("MapperSettore")
        Dim MapperEnte As MapperEnteBilaterale = PersistenceMapperRegistry.Instance.GetMapperByName("MapperEnteBilaterale")
        Dim MapperAziende As MapperAzienda = PersistenceMapperRegistry.Instance.GetMapperByName("MapperAzienda")

        Dim SETTORE As Settore = MapperSettore.FindObjectById(ID_SETTORE)
        Dim Azienda As Azienda = New AziendaNonSpecificata

        Select Case SETTORE.TipologiaSettore
            Case DOMAIN.FEDERATIONARTIFACTS.Settore.TipoSettore.Edili
                Azienda = MapperEnte.FindObjectById(Id_Azienda)
            Case DOMAIN.FEDERATIONARTIFACTS.Settore.TipoSettore.ImpiantiFissi
                Azienda = MapperAziende.FindObjectById(Id_Azienda)
        End Select

        Dim competenza As AbstractPeriodo
        If Di = DateTime.MinValue Or Df = DateTime.MinValue Then
            competenza = New PeriodoNullo
        Else
            competenza = New CompositePeriodo(New DataRange(Di, Df), Azienda.UnitaDiCompetenza)
        End If

        Incasso.Competenza = competenza
        Incasso.SetSoggettoEsecutore(Azienda)
        Incasso.SetSettore(SETTORE)
        Incasso.SetValuta(valuta)
        Incasso.SetImporto(New Moneta(Imp, valuta))
        Incasso.SetPosted()
        'devo aggiungere la lista delle posizioni e impostare il pagamento come registrato.
        Dim list As VirtualLazyList = New LazyLoadPosizioniPagamento(Incasso)
        Incasso.SetItems(list)
        Item = Incasso
        JournalingDataLoader.ReadJournalingParameters(Item, rs)
    End Sub


    'Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
    '    Try
    '        MyBase.LoadUpdateCommandParameters(Item, Cmd)
    '        Dim Documento As IncassoQuotaPrevisionale = DirectCast(Item, IncassoQuotaPrevisionale)

    '        Dim param As IDbDataParameter = Cmd.CreateParameter
    '        param.ParameterName = "@Tdc"
    '        param.Value = Documento.TipoDocumento
    '        Cmd.Parameters.Add(param)


    '        param = Cmd.CreateParameter
    '        param.ParameterName = "@Di"
    '        If Not TypeOf (Documento.Competenza) Is PeriodoNullo Then
    '            param.Value = Documento.Competenza.GetDataRange.Start
    '        Else
    '            param.Value = DBNull.Value
    '        End If
    '        Cmd.Parameters.Add(param)

    '        param = Cmd.CreateParameter
    '        param.ParameterName = "@Df"
    '        If Not TypeOf (Documento.Competenza) Is PeriodoNullo Then
    '            param.Value = Documento.Competenza.GetDataRange.Finish
    '        Else
    '            param.Value = DBNull.Value
    '        End If
    '        Cmd.Parameters.Add(param)

    '        param = Cmd.CreateParameter
    '        param.ParameterName = "@Imp"
    '        param.Value = Documento.Importo.Importo
    '        Cmd.Parameters.Add(param)

    '        param = Cmd.CreateParameter
    '        param.ParameterName = "@Val"
    '        param.Value = Documento.Importo.GetValuta
    '        Cmd.Parameters.Add(param)


    '        param = Cmd.CreateParameter
    '        param.ParameterName = "@Az"
    '        If Documento.SoggettoEsecutore.IdAzienda > 0 Then
    '            param.Value = Documento.SoggettoEsecutore.IdAzienda
    '        Else
    '            Throw New Exception("Impossibile caricare il parametro Soggetto esecutore per il comando di inserimento di un oggetto Pagamento. L'id del soggetto non è valido.")
    '        End If
    '        Cmd.Parameters.Add(param)

    '        param = Cmd.CreateParameter
    '        param.ParameterName = "@Ids"
    '        param.Value = Documento.Settore.Id
    '        Cmd.Parameters.Add(param)

    '        JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)


    '    Catch ex As Exception
    '        Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto Referente." & vbCrLf & ex.Message)
    '    End Try
    'End Sub

    'Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
    '    Try
    '        MyBase.LoadUpdateCommandParameters(Item, Cmd)
    '        Dim Documento As IncassoQuotaPrevisionale = DirectCast(Item, IncassoQuotaPrevisionale)

    '        Dim param As IDbDataParameter = Cmd.CreateParameter
    '        param.ParameterName = "@Tdc"
    '        param.Value = Documento.TipoDocumento
    '        Cmd.Parameters.Add(param)


    '        param = Cmd.CreateParameter
    '        param.ParameterName = "@Di"
    '        If Not TypeOf (Documento.Competenza) Is PeriodoNullo Then
    '            param.Value = Documento.Competenza.GetDataRange.Start
    '        Else
    '            param.Value = DBNull.Value
    '        End If
    '        Cmd.Parameters.Add(param)

    '        param = Cmd.CreateParameter
    '        param.ParameterName = "@Df"
    '        If Not TypeOf (Documento.Competenza) Is PeriodoNullo Then
    '            param.Value = Documento.Competenza.GetDataRange.Finish
    '        Else
    '            param.Value = DBNull.Value
    '        End If
    '        Cmd.Parameters.Add(param)

    '        param = Cmd.CreateParameter
    '        param.ParameterName = "@Imp"
    '        param.Value = Documento.Importo.Importo
    '        Cmd.Parameters.Add(param)

    '        param = Cmd.CreateParameter
    '        param.ParameterName = "@Val"
    '        param.Value = Documento.Importo.GetValuta
    '        Cmd.Parameters.Add(param)


    '        param = Cmd.CreateParameter
    '        param.ParameterName = "@Az"
    '        If Documento.SoggettoEsecutore.IdAzienda > 0 Then
    '            param.Value = Documento.SoggettoEsecutore.IdAzienda
    '        Else
    '            Throw New Exception("Impossibile caricare il parametro Soggetto esecutore per il comando di inserimento di un oggetto Pagamento. L'id del soggetto non è valido.")
    '        End If
    '        Cmd.Parameters.Add(param)

    '        param = Cmd.CreateParameter
    '        param.ParameterName = "@Ids"
    '        param.Value = Documento.Settore.Id
    '        Cmd.Parameters.Add(param)

    '        JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)


    '    Catch ex As Exception
    '        Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto Referente." & vbCrLf & ex.Message)
    '    End Try
    'End Sub
End Class
