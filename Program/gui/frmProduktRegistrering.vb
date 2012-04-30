Public Class frmProduktRegistrering
    Private id As Integer
    Private oppkobling As New Sql()

    Sub New()
        InitializeComponent()
    End Sub

    Sub New(ByVal id As Integer)
        InitializeComponent()

        If (id <> 0) Then
            Me.id = id
        End If
    End Sub

    Private Sub initProduktGruppe()
        Dim myData As New DataTable
        myData = oppkobling.Query("SELECT pGruppe_id, gNavn FROM produktgruppe")

        Dim rad As DataRow
        For Each rad In myData.Rows
            cbProduktgruppe.Items.Add(New ComboBoxValue(rad("pGruppe_id"), rad("gNavn"), rad("gNavn")))
        Next rad
    End Sub

    Private Sub init()
        If (id <> 0) Then
            Dim myData As New DataTable
            myData = oppkobling.Query("SELECT * FROM produkt, produktgruppe WHERE produkt.pGruppe_id = produktgruppe.pGruppe_id AND produkt.produkt_id = """ & id & """")
            Dim rad As DataRow = myData.Rows.Item(0)

            txtNavn.Text = rad("navn")
            txtBeskrivelse.Text = rad("beskrivelse")

            Dim selected As ComboBoxValue
            For Each selected In cbProduktgruppe.Items
                If (selected.ID = rad("pGruppe_id")) Then
                    cbProduktgruppe.SelectedItem = selected
                    Exit For
                End If
            Next selected

            Dim myData2 As New DataTable
            myData2 = oppkobling.Query("SELECT * FROM pris WHERE produkt_id = """ & id & """")
            Dim rad2 As DataRow
            For Each rad2 In myData2.Rows
                addPris(rad2("pris"), rad2("varighet"))
            Next rad2
        End If
    End Sub

    Private Sub addPris(ByVal pris As String, ByVal varighet As String)
        If Not IsNumeric(pris) Or Not IsNumeric(varighet) Then
            MessageBox.Show("Pris må bestå av tall!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim item As ListViewItem
        For Each item In lvPriser.Items
            Dim _pris As String = item.SubItems.Item(0).Text
            Dim _varighet As String = item.SubItems.Item(1).Text

            If (_pris = pris And _varighet = varighet) Then
                Return
            End If
        Next item

        Dim str(2) As String
        str(0) = pris
        str(1) = varighet
        Dim itm As ListViewItem = New ListViewItem(str)
        lvPriser.Items.Add(itm)

        For Each column As ColumnHeader In Me.lvPriser.Columns
            column.Width = -2
        Next
    End Sub

    Private Sub initListViewPriser()
        lvPriser.Columns.Add("Pris")
        lvPriser.Columns.Add("Varighet")

        For Each column As ColumnHeader In Me.lvPriser.Columns
            column.Width = -2
        Next
    End Sub

    Private Sub btnLagre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLagre.Click
        If (valid()) Then
            Dim selectedGruppeId As ComboBoxValue = cbProduktgruppe.SelectedItem
            Dim gruppeId As String = selectedGruppeId.ID
            Dim updatedId As Integer = id

            If (id <> 0) Then
                oppkobling.Query("UPDATE produkt SET navn = """ & txtNavn.Text & """, beskrivelse = """ & txtBeskrivelse.Text & """, pGruppe_id = """ & gruppeId & """")
            Else
                updatedId = oppkobling.executeQuery("INSERT INTO produkt (navn, beskrivelse, pGruppe_id) VALUES (""" & txtNavn.Text & """, """ & txtBeskrivelse.Text & """, """ & gruppeId & """)")
            End If

            If (updatedId = 0) Then
                MessageBox.Show("Kunne ikke lagre til databasen", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DialogResult = DialogResult.Abort
            Else
                oppkobling.executeQuery("DELETE FROM pris WHERE produkt_id = """ & updatedId & """")

                Dim item As ListViewItem
                For Each item In lvPriser.Items
                    Dim _pris As String = item.SubItems.Item(0).Text
                    Dim _varighet As String = item.SubItems.Item(1).Text

                    Try
                        oppkobling.executeQuery("INSERT INTO pris (produkt_id, pris, varighet) VALUES (""" & updatedId & """, """ & _pris & """, """ & _varighet & """)")
                    Catch ex As Exception

                    End Try
                Next item

                Me.DialogResult = DialogResult.OK
            End If
        End If
    End Sub

    Private Function valid() As Boolean
        If (IsNumeric(txtNavn.Text) Or String.Equals(txtNavn.Text, "")) Then
            MessageBox.Show("Skriv inn navn!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNavn.Focus()
            Return False
        End If

        If (IsNumeric(txtBeskrivelse.Text) Or String.Equals(txtBeskrivelse.Text, "")) Then
            MessageBox.Show("Skriv inn beskrivelse!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBeskrivelse.Focus()
            Return False
        End If

        If (cbProduktgruppe.SelectedItem Is Nothing) Then
            MessageBox.Show("Velg produktgruppe!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbProduktgruppe.Focus()
            Return False
        End If

        If (lvPriser.Items.Count = 0) Then
            MessageBox.Show("Legg til minst én pris!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnPrisLeggTil.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub frmProduktRegistrering_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            oppkobling.kobleTil()
        Catch ex As Exception
            MessageBox.Show("Kunne ikke koble til database", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.Abort
        End Try

        initProduktGruppe()
        initListViewPriser()

        init()
    End Sub

    Private Sub btnPriserFjern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPriserFjern.Click
        Dim item As ListViewItem
        For Each item In lvPriser.SelectedItems
            lvPriser.Items.Remove(item)
        Next item
    End Sub

    Private Sub btnPrisLeggTil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrisLeggTil.Click
        Dim dialog As New frmDialogProduktPris

        If (dialog.ShowDialog() = DialogResult.OK) Then
            addPris(dialog.pris.pris, dialog.pris.varighet)
        End If
    End Sub

    Private Sub frmProduktRegistrering_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        oppkobling.kobleFra()
        Me.Dispose()
    End Sub

    Private Sub btnAvbryt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvbryt.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class