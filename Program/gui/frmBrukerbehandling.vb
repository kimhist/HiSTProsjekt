Public Class frmBrukerbehandling

    Private Sub btnAvbryt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvbryt.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnLagre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLagre.Click
        Me.DialogResult = DialogResult.OK
    End Sub
End Class