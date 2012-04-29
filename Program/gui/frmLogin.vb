Public Class frmLogin

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            Dim login As Login = New Login(txtBrukernavn.Text, txtPassord.Text)
        Catch ex As LoginFailedException
            MessageBox.Show("Pålogging mislykket", "Feil", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
