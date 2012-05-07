Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Sql
    Public Class ConnectionException
        Inherits Exception
    End Class

    Private server As String
    Private database As String
    Private username As String
    Private password As String
    Private con As MySqlConnection

    'Bruker default konfigurasjonen til tilkobling
    Sub New()
        Me.New("mysql.stud.aitel.hist.no", "ib-gr2", "ib-gr2", "M9w2rFye")
    End Sub

    'Lager en konstuktør for en tilkobling
    Sub New(ByVal server As String, ByVal database As String, ByVal username As String, ByVal password As String)
        Me.server = server
        Me.database = database
        Me.username = username
        Me.password = password

        con = New MySqlConnection("Server=" & server & ";Database=" & database & ";User Id=" & username & ";Password=" & password + ";")
    End Sub

    'Oppretter en tilkobling til databasen
    Public Sub kobleTil()
        Try
            con.Open()
        Catch ex As MySqlException
            Throw New ConnectionException
        End Try
    End Sub

    'Kobler fra databasen
    Public Sub kobleFra()
        Try
            con.Close()
            con.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Public Function executeQuery(ByVal sql As String) As Integer
        Try
            If Not (con.State = ConnectionState.Open) Then
                kobleTil()
            End If

            Dim myData As New DataTable
            Dim myCommand As New MySqlCommand
            Dim myAdapter As New MySqlDataAdapter
            myCommand.Connection = con
            myCommand.CommandText = sql & ";Select LAST_INSERT_ID();"

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)

            Return myData.Rows.Item(0)("LAST_INSERT_ID()")
        Catch ex As MySqlException
            MessageBox.Show("Tilkobling til databasen har feilet " & ex.Message)
        End Try

        Return 0
    End Function

    'Utfører en spørring mot databasen
    Public Function Query(ByVal sql As String) As DataTable
        Dim myData As New DataTable

        Try
            If Not (con.State = ConnectionState.Open) Then
                kobleTil()
            End If

            Dim myCommand As New MySqlCommand
            Dim myAdapter As New MySqlDataAdapter

            myCommand.Connection = con
            myCommand.CommandText = sql

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
        Catch ex As MySqlException
            MessageBox.Show("Tilkobling til databasen har feilet " & ex.Message)
        End Try

        Return myData
    End Function
End Class
