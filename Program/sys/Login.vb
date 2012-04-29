Public Class Login
    Private person_id As Integer
    Private brukernavn As String
    Private passord As String

    Sub New(ByVal brukernavn As String, ByVal passord As String)
        Dim oppkobling As New Sql

        Throw New LoginFailedException
    End Sub
End Class

Class LoginFailedException
    Inherits Exception
End Class

