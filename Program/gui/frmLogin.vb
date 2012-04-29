Public Class frmLogin

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        attemptLogin()
    End Sub

    Private Sub attemptLogin()
        Try
            Dim login As Login = New Login(txtBrukernavn.Text, txtPassord.Text)

            Dim hoved As frmHoved = New frmHoved(Me, login)
            hoved.Show()
            Me.Hide()
        Catch ex As LoginFailedException
            MessageBox.Show("Pålogging mislykket", "Pålogging", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtBrukernavn_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBrukernavn.KeyDown, txtPassord.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            attemptLogin()
        End If
    End Sub
End Class
