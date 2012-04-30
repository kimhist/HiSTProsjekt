Public Class frmBrukerbehandling
    Private person_id As Integer
    Private oppkobling As New Sql()

    Sub New()
        InitializeComponent()
    End Sub

    Sub New(ByVal bruker As Bruker)
        If (bruker IsNot Nothing) Then
            person_id = bruker.person_id
            InitializeComponent()

            Try
                oppkobling.kobleTil()
            Catch ex As Exception
                MessageBox.Show("Kunne ikke koble til database", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DialogResult = DialogResult.Abort
            End Try

            init()
        End If
    End Sub

    Private Sub init()
        If (person_id <> 0) Then
            Dim myData As New DataTable
            myData = oppkobling.Query("SELECT * FROM bruker, person, stilling WHERE bruker.person_id = person.person_id AND bruker.stilling_id = stilling.stilling_id AND bruker.person_id = """ & person_id & """")
            Dim rad As DataRow = myData.Rows.Item(0)

            txtFornavn.Text = rad("fornavn")
            txtEtternavn.Text = rad("etternavn")
            txtAdresse.Text = rad("adresse")
            txtTelefon.Text = rad("telefonNr")
            txtPostnr.Text = rad("postnr")
            ' Født her
            txtBrukernavn.Text = rad("brukernavn")
            txtPassord.Text = rad("passord")
        End If
    End Sub

    Private Sub btnAvbryt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvbryt.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnLagre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLagre.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub frmBrukerbehandling_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        oppkobling.kobleFra()
        Me.Dispose()
    End Sub
End Class