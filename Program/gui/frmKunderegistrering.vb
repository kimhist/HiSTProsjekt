Public Class frmKunderegistrering
    Private id As Integer

    Private Sub frmKunderegistrering_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Sub New()
        InitializeComponent()
    End Sub

    Sub New(ByVal id As Integer)
        If (id <> 0) Then
            Me.id = id
        End If
        InitializeComponent()
    End Sub

    Private Sub btnLagre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLagre.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnAvbryt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvbryt.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class