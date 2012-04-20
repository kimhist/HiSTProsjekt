Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Sql
    Private server As String
    Private database As String
    Private username As String
    Private password As String
    Private connString As String

    Private conn As New MySqlConnection

    'Lager en konstuktør for en tilkobling
    Public Sub New(ByVal server As String, ByVal database As String, ByVal username As String, ByVal password As String)
        Me.server = server
        Me.database = database
        Me.username = username
        Me.password = password
        connString = "Server=" & server & "database=" & database & "Uid=" & username & "Pwd=" & password
    End Sub

    'Sjekker tilkoblingen til databasen
    Public Function kobleTilOK() As Boolean
        Dim svar As Boolean
        conn.ConnectionString = connString
        Try
            conn.Open()
            svar = True
            conn.Close()
        Catch myError As MySqlException
            svar = False
        Finally
            conn.Dispose()
        End Try
        Return svar
    End Function

    'Funksjonen foretar en spørring
    Private Function Query(ByVal sql As String) As DataTable
        Dim myData As New DataTable

        Try
            conn.Open()

            Dim myCommand As New MySqlCommand
            Dim myAdapter As New MySqlDataAdapter

            myCommand.Connection = conn
            myCommand.CommandText = sql

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)

            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Tilkobling til databasen har feilet " & myerror.Message)
        Finally
            conn.Dispose()
        End Try

        Return myData
    End Function



End Class
