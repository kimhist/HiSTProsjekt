Public Class Bruker
    Public person_id As Integer
    Public brukernavn As String
    Public stilling As String
    Public fornavn As String
    Public etternavn As String

    Sub New(ByVal personId As Integer, ByVal brukernavn As String, ByVal stilling As String, ByVal fornavn As String, ByVal etternavn As String)
        Me.person_id = personId
        Me.brukernavn = brukernavn
        Me.stilling = stilling
        Me.fornavn = fornavn
        Me.etternavn = etternavn
    End Sub

    Public ReadOnly Property ID() As Integer
        Get
            Return person_id
        End Get
    End Property


    Public ReadOnly Property Name() As String
        Get
            Return etternavn & ", " & fornavn
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return etternavn & ", " & fornavn
    End Function
End Class
