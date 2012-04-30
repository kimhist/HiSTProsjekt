Public Class UtleieProdukt
    Public id As Integer
    Public navn As String
    Public beskrivelse As String

    Sub New(ByVal id As Integer, ByVal navn As String, ByVal beskrivelse As String)
        Me.id = id
        Me.navn = navn
        Me.beskrivelse = beskrivelse
    End Sub
End Class
