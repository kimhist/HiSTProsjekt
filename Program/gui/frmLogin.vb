Public Class frmLogin
    Private DEFAULT_BRUKERNAVN As String = "test"
    Private DEFAULT_PASSORD As String = "passord"

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        attemptLogin()
    End Sub

    Private Sub attemptLogin()
        Try
            Dim login As Login = New Login(txtBrukernavn.Text, txtPassord.Text)

            Dim hoved As frmHoved = New frmHoved(Me, login)
            reset()
            hoved.Show()
            Me.Hide()
        Catch ex As LoginFailedException
            MessageBox.Show("Pålogging mislykket", "Pålogging", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBrukernavn.KeyDown, txtPassord.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            attemptLogin()
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.Leave
        reset()
    End Sub

    Private Sub reset()
        txtBrukernavn.Focus()
        txtBrukernavn.Text = Me.DEFAULT_BRUKERNAVN
        txtPassord.Text = Me.DEFAULT_PASSORD
    End Sub

    Private Sub frmLogin_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        reset()
    End Sub

    Private Sub frmLogin_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class
