Public Class frmEndreBruker
    Private brukere As New ArrayList

    Private Sub frmEndreBruker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oppkobling As New Sql()

        Try
            oppkobling.kobleTil()

            Dim myData As New DataTable
            myData = oppkobling.Query("SELECT bruker.person_id, brukernavn, stillingNavn, fornavn, etternavn FROM bruker, person, stilling WHERE bruker.person_id = person.person_id AND bruker.stilling_id = stilling.stilling_id ORDER BY etternavn ASC")

            Dim rad As DataRow
            For Each rad In myData.Rows
                brukere.Add(New Bruker(CInt(rad("person_id")), rad("brukernavn"), rad("stillingNavn"), rad("fornavn"), rad("etternavn")))
            Next rad

            Dim bruker As Bruker
            For Each bruker In brukere
                cbNavn.Items.Add(bruker)
            Next
        Catch ex As Exception
            MessageBox.Show("Fikk ikke hentet inn eksisterende brukere", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.Abort
        Finally
            oppkobling.kobleFra()
        End Try
    End Sub

    Private Sub cbNavn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbNavn.SelectedIndexChanged
        Dim bruker As Bruker = cbNavn.SelectedItem
        txtBrukernavn.Text = bruker.brukernavn
    End Sub

    Private Sub btnEndre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEndre.Click
        If (cbNavn.SelectedItem IsNot Nothing) Then
            Dim bruker As Bruker = cbNavn.SelectedItem
            Dim brukerbehandling As New frmBrukerbehandling(bruker)
            brukerbehandling.ShowDialog()
        Else
            MessageBox.Show("Velg bruker", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub frmEndreBruker_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class