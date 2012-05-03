Public Class frmEndreUtleie
    Dim oppkobling As New Sql()

    Private Sub frmEndreUtleie_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        oppkobling.kobleFra()
        Me.Dispose()
    End Sub

    Private Sub frmEndreUtleie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            oppkobling.kobleTil()
            initUtleie()
        Catch ex As Exception
            MessageBox.Show("Fikk ikke hentet inn eksisterende bestillinger", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.Abort
        End Try
    End Sub

    Private Sub initUtleie()
        Dim myData As New DataTable
        myData = oppkobling.Query("SELECT bestilling_id FROM bestilling ORDER BY bestilling_id ASC")

        cbProduktId.Items.Clear()
        Dim rad As DataRow
        For Each rad In myData.Rows
            cbProduktId.Items.Add(New ComboBoxValue(rad("bestilling_id"), rad("bestilling_id"), rad("bestilling_id")))
        Next rad
    End Sub

    Private Sub cbNavnProduktNavn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbProduktId.SelectedIndexChanged
        Dim selected As ComboBoxValue = cbProduktId.SelectedItem

        If (selected IsNot Nothing) Then
            Dim myData As New DataTable
            myData = oppkobling.Query("SELECT datoFra, datoTil, fornavn, etternavn FROM bestilling, person WHERE bestilling.kunde = person.person_id AND bestilling_id = """ & selected.ID & """")
            Dim rad As DataRow = myData.Rows.Item(0)
            dtpFra.Text = rad("datoFra")
            dtpTil.Text = rad("datoTil")
            txtKunde.Text = rad("etternavn") & ", " & rad("fornavn")
        End If
    End Sub

    Private Sub btnEndre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEndre.Click
        If (cbProduktId.SelectedItem IsNot Nothing) Then
            Dim selected As ComboBoxValue = cbProduktId.SelectedItem
            Dim id As Integer = selected.ID
            Dim utleieRegistrering As New frmUtleieregistrering(id)


            If (utleieRegistrering.ShowDialog() = DialogResult.OK) Then
                initUtleie()

                Dim item As ComboBoxValue
                For Each item In cbProduktId.Items
                    If (item.ID = selected.ID) Then
                        cbProduktId.SelectedItem = item
                        Exit For
                    End If
                Next item
            End If

        Else
            MessageBox.Show("Velg utleie", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbProduktId.Focus()
        End If
    End Sub

    Private Sub cbProduktId_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbProduktId.KeyDown
        If e.KeyCode = Keys.Enter And cbProduktId.SelectedItem IsNot Nothing Then
            e.SuppressKeyPress = True
            btnEndre_Click(sender, e)
        End If
    End Sub
End Class