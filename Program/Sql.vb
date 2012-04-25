Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Sql
    Private server As String
    Private database As String
    Private username As String
    Private password As String
    Private con As MySqlConnection

    'Lager en konstuktør for en tilkobling
    Sub New(ByVal server As String, ByVal database As String, ByVal username As String, ByVal password As String)
        Me.server = server
        Me.database = database
        Me.username = username
        Me.password = password

        con = New MySqlConnection("Server=" & server & ";Database=" & database & ";User Id=" & username & ";Password=" & password + ";")
    End Sub

    'Sjekker tilkoblingen til databasen
    Public Function kobleTil() As Boolean
        Try
            con.Open()
            Return True
        Catch ex As MySqlException
            con.Dispose()
            Return False
        End Try
    End Function

    'Kobler fra databasen
    Public Sub kobleFra()
        Try
            con.Close()
            con.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    'Funksjonen foretar en spørring
    Public Function Query(ByVal sql As String) As DataTable
        Dim myData As New DataTable

        Try
            con.Open()

            Dim myCommand As New MySqlCommand
            Dim myAdapter As New MySqlDataAdapter

            myCommand.Connection = con
            myCommand.CommandText = sql

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)

            con.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Tilkobling til databasen har feilet " & myerror.Message)
        Finally
            con.Dispose()
        End Try

        Return myData
    End Function
End Class
