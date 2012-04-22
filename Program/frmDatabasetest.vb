Public Class frmDatabasetest


    Private Sub btnTest_Click(sender As System.Object, e As System.EventArgs) Handles btnTest.Click
        Dim oppkobling As New Sql("db.stud.aitel.hist.no", "database", "brukernavn", "passord")



    End Sub
End Class