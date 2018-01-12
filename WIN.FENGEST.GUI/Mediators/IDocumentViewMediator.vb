Public Interface IDocumentViewMediator
   ''' <summary>
   ''' Metodo per preparare il caricamento di un tipo documento.
   ''' Definisce il layout del documento in base al tipo documento visualizzato
   ''' </summary>
   ''' <param name="Control"></param>
   ''' <param name="DocumentType"></param>
   ''' <remarks></remarks>
   Sub DefineDocumentViewLayout(ByVal Control As BrowserControl, ByVal DocumentType As String)
   ''' <summary>
   ''' Metodo per caricare i dati specifici di un tipo documento. 
   ''' Imposta le proprietà specifiche di ogni tipologia di documento richiedendole al controller concreto
   ''' </summary>
   ''' <param name="Control"></param>
   ''' <param name="Controller"></param>
   ''' <remarks></remarks>
   Sub GetSpecificDocumentProperties(ByVal Control As BrowserControl, ByVal Controller As AbstractController)
   ''' <summary>
   ''' Metodo che rinfresca la griglia delle posizioni per il tipo documento specifico
   ''' </summary>
   ''' <param name="Control"></param>
   ''' <param name="controller"></param>
   ''' <remarks></remarks>
   Sub RefeshItemsGrid(ByVal Control As BrowserControl, ByVal controller As AbstractController)
   ''' <summary>
   ''' Metodo per caricare i dati specifici di una posizione documento. 
   ''' Imposta le proprietà specifiche di ogni tipologia di posizione documento richiedendole al controller concreto
   ''' </summary>
   ''' <param name="Control"></param>
   ''' <param name="controller"></param>
   ''' <remarks></remarks>
   Sub GetSpecificItemProperties(ByVal Control As BrowserControl, ByVal controller As AbstractController)
   ''' <summary>
   ''' Metodo per aggiornare una posizione documento. Imposta le proprieta per il documento sul controller concreto. 
   ''' </summary>
   ''' <param name="FrmItem"></param>
   ''' <param name="controller"></param>
   ''' <remarks></remarks>
   Sub SetItemProperties(ByVal FrmItem As System.Windows.Forms.Form, ByVal controller As AbstractController)
   ''' <summary>
   ''' Definisce il layout della maschera per la creazione di una nuova posizione documento
   ''' </summary>
   ''' <param name="Control"></param>
   ''' <param name="controller"></param>
   ''' <remarks></remarks>
   Sub DefineNewItemViewLayout(ByVal Control As BrowserControl, ByVal controller As AbstractController)
   ''' <summary>
   ''' Metodo per l'aggiunta di una nuova posizione al tipo documento specifico
   ''' </summary>
   ''' <param name="FrmItem"></param>
   ''' <param name="controller"></param>
   ''' <remarks></remarks>
   Sub AddNewItem(ByVal FrmItem As System.Windows.Forms.Form, ByVal controller As AbstractController)
   ''' <summary>
   ''' Metodo che consente di visualizzare il dettaglio delle posizioni documento
   ''' </summary>
   ''' <remarks></remarks>
   Sub ViewItemDetail(ByVal Controller As AbstractController)
   ''' <summary>
   ''' Definisce il layout della maschera per la visualizzazione e aggiornamento di una nuova posizione documento
   ''' </summary>
   ''' <param name="Control"></param>
   ''' <param name="controller"></param>
   ''' <remarks></remarks>
   Sub DefineItemViewLayout(ByVal Control As BrowserControl, ByVal controller As AbstractController)
End Interface
