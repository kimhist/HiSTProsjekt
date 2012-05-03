Public Class frmEndreProdukt
    Dim oppkobling As New Sql()

    Private Sub frmEndreProdukt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            oppkobling.kobleTil()
            initProduktNavn()
            initProduktId()
        Catch ex As Exception
            MessageBox.Show("Fikk ikke hentet inn eksisterende produkt", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.Abort
        End Try
    End Sub

    Private Sub initProduktNavn()
        Dim myData As New DataTable
        myData = oppkobling.Query("SELECT produkt_id, navn FROM produkt ORDER BY navn ASC")

        cbNavnProduktNavn.Items.Clear()
        Dim rad As DataRow
        For Each rad In myData.Rows
            cbNavnProduktNavn.Items.Add(New ComboBoxValue(rad("produkt_id"), rad("navn"), rad("navn")))
        Next rad
    End Sub

    Private Sub initProduktId()
        Dim myData As New DataTable
        myData = oppkobling.Query("SELECT produkt_id, navn FROM produkt ORDER BY produkt_id ASC")

        cbIdProduktId.Items.Clear()
        Dim rad As DataRow
        For Each rad In myData.Rows
            cbIdProduktId.Items.Add(New ComboBoxValue(rad("produkt_id"), rad("produkt_id"), rad("navn")))
        Next rad
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
            Dim produktregistrering As New frmProduktRegistrering(selected.ID)

            If (produktregistrering.ShowDialog() = DialogResult.OK) Then
                initProduktNavn()

                Dim item As ComboBoxValue
                For Each item In cbNavnProduktNavn.Items
                    If (item.ID = selected.ID) Then
                        cbNavnProduktNavn.SelectedItem = item
                        Exit For
                    End If
                Next item
            End If
        Else
            MessageBox.Show("Velg produkt", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbNavnProduktNavn.Focus()
        End If
    End Sub

    Private Sub btnIdEndre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIdEndre.Click
        If (cbIdProduktId.SelectedItem IsNot Nothing) Then
            Dim selected As ComboBoxValue = cbIdProduktId.SelectedItem
            Dim produktregistrering As New frmProduktRegistrering(selected.ID)

            If (produktregistrering.ShowDialog() = DialogResult.OK) Then
                initProduktId()

                Dim item As ComboBoxValue
                For Each item In cbIdProduktId.Items
                    If (item.ID = selected.ID) Then
                        cbIdProduktId.SelectedItem = item
                        Exit For
                    End If
                Next item
            End If
        Else
            MessageBox.Show("Velg produkt", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbIdProduktId.Focus()
        End If
    End Sub

    Private Sub frmEndreProdukt_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        oppkobling.kobleFra()
        Me.Dispose()
    End Sub

    Private Sub cbNavnProduktNavn_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbNavnProduktNavn.KeyDown
        If e.KeyCode = Keys.Enter And cbNavnProduktNavn.SelectedItem IsNot Nothing Then
            e.SuppressKeyPress = True
            btnNavnEndre_Click(sender, e)
        End If
    End Sub

    Private Sub cbIdProduktId_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbIdProduktId.KeyDown
        If e.KeyCode = Keys.Enter And cbIdProduktId.SelectedItem IsNot Nothing Then
            e.SuppressKeyPress = True
            btnIdEndre_Click(sender, e)
        End If
    End Sub
End Class