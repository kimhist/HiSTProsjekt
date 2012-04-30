Public Class frmDialogProduktPris
    Public pris As Pris

    Private Sub btnLagre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLagre.Click
        If Not IsNumeric(txtPris.Text) Or Not IsNumeric(txtVarighet.Text) Then
            MessageBox.Show("Skriv inn tall", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            pris = New Pris(Convert.ToSingle(txtPris.Text), Convert.ToInt32(txtVarighet.Text))
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub btnAvbryt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvbryt.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub frmDialogProduktPris_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class