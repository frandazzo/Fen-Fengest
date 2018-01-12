Public Class OptionController
   Inherits AbstractController


   

   Private Function Current() As WordTagger
      Return DirectCast(MyBase.m_current, WordTagger)
   End Function





#Region "Metodi CRUD"
   Public Overrides Function GetCategoryObject() As String
      Return "WordTagger"
   End Function
   ''' <summary>
   ''' Crea un'istanza vuota dell'oggetto
   ''' </summary>
   ''' <remarks></remarks>
   Public Overrides Sub CreateNew()
      Dim tagger As New WordTagger
   End Sub

   Public Function SearchTaggerUtenti() As IList

      Dim qry As Query = Ps.CreateNewQuery("MapperWordTagger")
      qry.AddWhereClause(Criteria.Equal("TIPO", "1"))
      Return qry.Execute(Ps)

    End Function

    Public Function SearchTaggerAziende() As IList

        Dim qry As Query = Ps.CreateNewQuery("MapperWordTagger")
        qry.AddWhereClause(Criteria.Equal("TIPO", "5"))
        Return qry.Execute(Ps)

    End Function

   Public Function SearchTaggerSegreteria() As IList

      Dim qry As Query = Ps.CreateNewQuery("MapperWordTagger")
      qry.AddWhereClause(Criteria.Equal("TIPO", "2"))
      Return qry.Execute(Ps)

   End Function

   Public Function SearchTaggerData() As IList

      Dim qry As Query = Ps.CreateNewQuery("MapperWordTagger")
      qry.AddWhereClause(Criteria.Equal("TIPO", "3"))
      Return qry.Execute(Ps)

   End Function


   Public Function SearchTaggerOperatoreCorrente() As IList

      Dim qry As Query = Ps.CreateNewQuery("MapperWordTagger")
      qry.AddWhereClause(Criteria.Equal("TIPO", "4"))
      Return qry.Execute(Ps)

   End Function




   'Public Function GetListTags() As IList

   '   Dim list As New ArrayList
   '   Dim temp As New ArrayList
   '   Dim qry As Query = Ps.CreateNewQuery("MapperWordTagger")
   '   qry.AddWhereClause(Criteria.Equal("TIPO", "1"))
   '   temp = qry.Execute(Ps)

   '   For Each elem As WordTagger In temp
   '      list.Add(elem.ValoreTag)
   '   Next
   '   Return list
   'End Function



#End Region


End Class

