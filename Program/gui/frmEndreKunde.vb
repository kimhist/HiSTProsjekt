Public Class frmEndreKunde
    Dim oppkobling As New Sql()

    Private Sub frmEndreKunde_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        oppkobling.kobleFra()
        Me.Dispose()
    End Sub

    Private Sub frmEndreKunde_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            oppkobling.kobleTil()
            initKunder()
        Catch ex As Exception
            MessageBox.Show("Fikk ikke hentet inn eksisterende bestillinger", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.Abort
        End Try
    End Sub

    Private Sub initKunder()
        Dim myData As New DataTable
        myData = oppkobling.Query("SELECT kunde.person_id, fornavn, etternavn FROM person, kunde WHERE kunde.person_id = person.person_id ORDER BY etternavn, fornavn ASC")

        cbNavn.Items.Clear()
        Dim rad As DataRow
        For Each rad In myData.Rows
            cbNavn.Items.Add(New ComboBoxValue(rad("person_id"), rad("etternavn") & ", " & rad("fornavn"), rad("person_id")))
        Next rad
    End Sub

    Private Sub btnEndre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEndre.Click
        If (cbNavn.SelectedItem IsNot Nothing) Then
            Dim selected As ComboBoxValue = cbNavn.SelectedItem
            Dim dialog As New frmKunderegistrering(selected.ID)


            If (dialog.ShowDialog() = DialogResult.OK) Then
                initKunder()

                Dim item As ComboBoxValue
                For Each item In cbNavn.Items
                    If (item.ID = selected.ID) Then
                        cbNavn.SelectedItem = item
                        Exit For
                    End If
                Next item
            End If

        Else
            MessageBox.Show("Velg kunde", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbNavn.Focus()
        End If
    End Sub

    Private Sub cbNavn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbNavn.SelectedIndexChanged
        Dim selected As ComboBoxValue = cbNavn.SelectedItem

        If (selected IsNot Nothing) Then
            txtId.Text = selected.ID
        End If
    End Sub
End Class