Public Class frmDialogVedlikehold
    Public merknader As String
    Public UtAvDrift As Boolean

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        merknader = txtMerknader.Text
        UtAvDrift = cbUtAvDrift.Enabled
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub frmDialogVedlikehold_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class