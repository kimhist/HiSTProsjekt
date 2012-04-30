Public Class frmEndreProdukt

    Private Sub frmEndreProdukt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oppkobling As New Sql()

        Try
            oppkobling.kobleTil()

            Dim myData As New DataTable
            myData = oppkobling.Query("SELECT produkt_id, navn FROM produkt ORDER BY navn ASC")

            Dim rad As DataRow
            For Each rad In myData.Rows
                cbNavnProduktNavn.Items.Add(New ComboBoxValue(rad("produkt_id"), rad("navn"), rad("navn")))
            Next rad

            Dim myData2 As New DataTable
            myData2 = oppkobling.Query("SELECT produkt_id, navn FROM produkt ORDER BY produkt_id ASC")

            Dim rad2 As DataRow
            For Each rad2 In myData2.Rows
                cbIdProduktId.Items.Add(New ComboBoxValue(rad2("produkt_id"), rad2("produkt_id"), rad2("navn")))
            Next rad2
        Catch ex As Exception
            MessageBox.Show("Fikk ikke hentet inn eksisterende produkt", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.Abort
        Finally
            oppkobling.kobleFra()
        End Try
    End Sub

    Private Sub cbNavnProduktNavn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbNavnProduktNavn.SelectedIndexChanged
        Dim selected As ComboBoxValue = cbNavnProduktNavn.SelectedItem
        txtNavnProduktId.Text = selected.ID
    End Sub

    Private Sub cbIdProduktId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbIdProduktId.SelectedIndexChanged
        Dim selected As ComboBoxValue = cbIdProduktId.SelectedItem
        txtIdProduktNavn.Text = selected.Name
    End Sub

    Private Sub btnNavnEndre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavnEndre.Click
        If (cbNavnProduktNavn.SelectedItem IsNot Nothing) Then
            Dim selected As ComboBoxValue = cbNavnProduktNavn.SelectedItem
            Dim id As Integer = selected.ID
            Dim produktregistrering As New frmProduktRegistrering(id)
            produktregistrering.ShowDialog()
        Else
            MessageBox.Show("Velg produkt", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbNavnProduktNavn.Focus()
        End If
    End Sub

    Private Sub btnIdEndre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIdEndre.Click
        If (cbIdProduktId.SelectedItem IsNot Nothing) Then
            Dim selected As ComboBoxValue = cbIdProduktId.SelectedItem
            Dim id As Integer = selected.ID
            Dim produktregistrering As New frmProduktRegistrering(id)
            produktregistrering.ShowDialog()
        Else
            MessageBox.Show("Velg produkt", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbIdProduktId.Focus()
        End If
    End Sub

    Private Sub frmEndreProdukt_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class