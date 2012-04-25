Public Class frmDatabasetest


    Private Sub btnTest_Click(sender As System.Object, e As System.EventArgs) Handles btnTest.Click
        Dim oppkobling As New Sql("mysql.stud.aitel.hist.no", "ib-gr2", "ib-gr2", "M9w2rFye")

        If oppkobling.kobleTil Then
            MsgBox("Oppkoblingen gikk veldig bra")
        Else
            MsgBox("Oppkoblingen var ikke vellykket")
        End If
    End Sub
End Class