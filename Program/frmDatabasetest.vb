Public Class frmDatabasetest


    Private Sub btnTest_Click(sender As System.Object, e As System.EventArgs) Handles btnTest.Click
        Dim oppkobling As New Sql

        Try
            oppkobling.kobleTil()
            MsgBox("Oppkoblingen gikk veldig bra")
        Catch ex As Exception
            MsgBox("Oppkoblingen var ikke vellykket")
        Finally
            oppkobling.kobleFra()
        End Try
    End Sub

    Private Sub btnSQL_Click(sender As System.Object, e As System.EventArgs) Handles btnSQL.Click
        Dim oppkobling As New Sql

        Try
            oppkobling.kobleTil()

            Dim myData As New DataTable
            myData = oppkobling.Query("SELECT * FROM person")
            Dim tempRad As DataRow
            Dim pid, fodt, fornavn, etternavn, adresse, tlf, postnr As String

            For Each tempRad In myData.Rows
                pid = tempRad("person_id")
                fodt = tempRad("fodt")
                fornavn = tempRad("fornavn")
                etternavn = tempRad("etternavn")
                adresse = tempRad("adresse")
                tlf = tempRad("telefonNr")
                postnr = tempRad("postnr")
                lstUtskrift.Items.Add(pid & " " & fornavn & " " & etternavn)
            Next tempRad
        Catch ex As Exception
            MsgBox("Oppkoblingen var ikke vellykket, prøv igjen senere")
        End Try
    End Sub
End Class