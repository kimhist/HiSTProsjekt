Public Class Login
    Private person_id As Integer
    Private brukernavn As String
    Private stilling As String

    Sub New(ByVal brukernavn As String, ByVal passord As String)
        Dim oppkobling As New Sql()

        Try
            If (String.Equals(brukernavn, "") Or String.Equals(passord, "")) Then
                Throw New Exception
            End If

            oppkobling.kobleTil()

            Dim myData As New DataTable
            myData = oppkobling.Query("SELECT person_id, stillingNavn FROM bruker, stilling WHERE bruker.stilling_id = stilling.stilling_id AND brukernavn = """ & brukernavn & """ AND passord = """ & passord & """")

            Dim rad As DataRow = myData.Rows.Item(0)
            Me.person_id = rad("person_id")
            Me.stilling = rad("stillingNavn")
        Catch ex As Exception
            Throw New LoginFailedException
        Finally
            oppkobling.kobleFra()
        End Try
    End Sub

    Public Function getPersonId() As Integer
        Return Me.person_id
    End Function

    Public Function getBrukernavn() As String
        Return Me.brukernavn
    End Function

    Public Function getStilling() As String
        Return Me.stilling
    End Function
End Class

Class LoginFailedException
    Inherits Exception
End Class