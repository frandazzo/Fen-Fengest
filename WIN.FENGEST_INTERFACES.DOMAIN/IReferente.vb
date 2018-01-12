Public Interface IReferente
   Inherits IPersona
   ReadOnly Property IdReferente() As Int32
   Property Conto() As IConto
   Property UltimoRistorno() As IDocumento
End Interface
