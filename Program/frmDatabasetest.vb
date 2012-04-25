Public Class frmDatabasetest


    Private Sub btnTest_Click(sender As System.Object, e As System.EventArgs) Handles btnTest.Click
        Dim oppkobling As New Sql("mysql.stud.aitel.hist.no", "ib-gr2", "ib-gr2", "M9w2rFye")

        If oppkobling.kobleTilOK Then
            MsgBox("Oppkoblingen gikk veldig bra")
        Else
            MsgBox("Oppkoblingen var ikke vellykket")
        End If
    End Sub

    Private Sub btnSQL_Click(sender As System.Object, e As System.EventArgs) Handles btnSQL.Click
        Dim oppkobling As New Sql("mysql.stud.aitel.hist.no", "ib-gr2", "ib-gr2", "M9w2rFye")

        'Sjekker om oppkobling er ok
        If oppkobling.kobleTilOK Then
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

        Else
            MsgBox("Oppkoblingen var ikke vellykket, prøv igjen senere.....")
        End If
        oppkobling.kobleFra()

    End Sub
End Class