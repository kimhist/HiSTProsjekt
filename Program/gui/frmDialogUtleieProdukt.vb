Public Class frmDialogUtleieProdukt
    Dim oppkobling As New Sql()
    Public produkt As UtleieProdukt

    Private Sub btnAvbryt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvbryt.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub frmDialogUtleieProdukt_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnNavnLeggTil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavnLeggTil.Click
        leggTil(cbNavnProduktNavn)
    End Sub

    Private Sub btnIdLeggTil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIdLeggTil.Click
        leggTil(cbIdProduktId)
    End Sub

    Private Sub leggTil(ByRef comboBox As ComboBox)
        If (comboBox.SelectedItem Is Nothing) Then
            MessageBox.Show("Velg produkt!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            comboBox.Select()
        Else
            Dim selected As ComboBoxValue = comboBox.SelectedItem

            Try
                Dim myData As New DataTable
                myData = oppkobling.Query("SELECT beskrivelse FROM produkt WHERE produkt_id = """ & selected.ID & """")
                Dim rad As DataRow = myData.Rows.Item(0)

                produkt = New UtleieProdukt(selected.ID, selected.Name, rad("beskrivelse"))
                Me.DialogResult = DialogResult.OK
            Catch
                Me.DialogResult = DialogResult.Abort
            End Try
        End If
    End Sub

    Private Sub cbNavnProduktNavn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbNavnProduktNavn.SelectedIndexChanged
        Dim selected As ComboBoxValue = cbNavnProduktNavn.SelectedItem

        If (selected IsNot Nothing) Then
            Dim myData As New DataTable
            myData = oppkobling.Query("SELECT beskrivelse FROM produkt WHERE produkt_id = """ & selected.ID & """")
            Dim rad As DataRow = myData.Rows.Item(0)
            txtNavnProduktId.Text = selected.ID
            txtNavnProduktBeskrivelse.Text = rad("beskrivelse")
        End If
    End Sub

    Private Sub cbIdProduktId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbIdProduktId.SelectedIndexChanged
        Dim selected As ComboBoxValue = cbIdProduktId.SelectedItem

        If (selected IsNot Nothing) Then
            Dim myData As New DataTable
            myData = oppkobling.Query("SELECT beskrivelse FROM produkt WHERE produkt_id = """ & selected.ID & """")
            Dim rad As DataRow = myData.Rows.Item(0)
            txtIdProduktNavn.Text = selected.Name
            txtIdProduktBeskrivelse.Text = rad("beskrivelse")
        End If
    End Sub

    Private Sub frmDialogUtleieProdukt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        End Try
    End Sub
End Class