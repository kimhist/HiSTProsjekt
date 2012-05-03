Public Class frmKunderegistrering
    Public id As Integer
    Private oppkobling As New Sql()

    Private Sub frmKunderegistrering_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Sub New()
        InitializeComponent()
    End Sub

    Sub New(ByVal id As Integer)
        If (id <> 0) Then
            Me.id = id
        End If
        InitializeComponent()
    End Sub

    Private Sub btnLagre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLagre.Click
        If (valid()) Then
            Dim updatedId As Integer = id

            If (id <> 0) Then
                oppkobling.Query("UPDATE person SET fodt = """ & dtpFodt.Text & """, fornavn = """ & txtFornavn.Text & """, etternavn = """ & txtEtternavn.Text & """, adresse = """ & txtAdresse.Text & """, telefonNr = """ & txtTelefon.Text & """, postNr = """ & txtPostnr.Text & """ WHERE person_id = """ & id & """")
                oppkobling.Query("UPDATE kunde SET hoyde = """ & txtHoyde.Text & """, vekt = """ & txtVekt.Text & """, skoNr = """ & txtSkonummer.Text & """ WHERE person_id = """ & id & """")
                Me.DialogResult = DialogResult.OK
            Else
                updatedId = oppkobling.executeQuery("INSERT INTO person (fodt, fornavn, etternavn, adresse, telefonNr, postnr) VALUES (""" & dtpFodt.Text & """, """ & txtFornavn.Text & """, """ & txtEtternavn.Text & """, """ & txtAdresse.Text & """, """ & txtTelefon.Text & """, """ & txtPostnr.Text & """)")

                If (updatedId = 0) Then
                    MessageBox.Show("Kunne ikke lagre til databasen", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.DialogResult = DialogResult.Abort
                Else
                    oppkobling.executeQuery("INSERT INTO kunde (person_id, hoyde, vekt, skoNr) VALUES (""" & updatedId & """, """ & txtHoyde.Text & """, """ & txtVekt.Text & """, """ & txtSkonummer.Text & """)")
                    id = updatedId
                    Me.DialogResult = DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Function valid() As Boolean
        If (IsNumeric(txtFornavn.Text) Or String.Equals(txtFornavn.Text, "")) Then
            MessageBox.Show("Skriv inn fornavn!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFornavn.Focus()
            Return False
        End If

        If (IsNumeric(txtEtternavn.Text) Or String.Equals(txtEtternavn.Text, "")) Then
            MessageBox.Show("Skriv inn etternavn!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEtternavn.Focus()
            Return False
        End If

        If (Not IsNumeric(txtSkonummer.Text) Or Not (Convert.ToInt32(txtSkonummer.Text) > 0 And Convert.ToInt32(txtSkonummer.Text) <= 99)) Then
            MessageBox.Show("Skriv inn skonummer!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSkonummer.Focus()
            Return False
        End If

        If (Not IsNumeric(txtVekt.Text) Or Not (Convert.ToInt32(txtVekt.Text) > 0 And Convert.ToInt32(txtVekt.Text) <= 999)) Then
            MessageBox.Show("Skriv inn vekt!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtVekt.Focus()
            Return False
        End If

        If (Not IsNumeric(txtHoyde.Text) Or Not (Convert.ToInt32(txtHoyde.Text) > 0 And Convert.ToInt32(txtHoyde.Text) <= 999)) Then
            MessageBox.Show("Skriv inn høyde!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtHoyde.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnAvbryt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvbryt.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub init()
        If (id <> 0) Then
            Dim myData As New DataTable
            myData = oppkobling.Query("SELECT * FROM kunde, person WHERE kunde.person_id = person.person_id AND kunde.person_id = """ & id & """")
            Dim rad As DataRow = myData.Rows.Item(0)

            txtFornavn.Text = rad("fornavn")
            txtEtternavn.Text = rad("etternavn")
            txtAdresse.Text = rad("adresse")
            txtPostnr.Text = rad("postnr")
            txtTelefon.Text = rad("telefonNr")
            dtpFodt.Text = rad("fodt")

            txtHoyde.Text = rad("hoyde")
            txtVekt.Text = rad("vekt")
            txtSkonummer.Text = rad("skoNr")
        End If
    End Sub

    Private Sub frmKunderegistrering_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            oppkobling.kobleTil()
        Catch ex As Exception
            MessageBox.Show("Kunne ikke koble til database", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.Abort
        End Try

        init()
    End Sub
End Class