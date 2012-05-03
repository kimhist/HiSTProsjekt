Public Class frmUtleieregistrering
    Private id As Integer
    Private oppkobling As New Sql()

    Private Sub frmUtleieregistrering_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        oppkobling.kobleFra()
        Me.Dispose()
    End Sub

    Sub New()
        InitializeComponent()
    End Sub

    Sub New(ByVal id As Integer)
        InitializeComponent()

        If (id <> 0) Then
            Me.id = id
        End If
    End Sub

    Sub init()
        If (id <> 0) Then
            Dim myData As New DataTable
            myData = oppkobling.Query("SELECT datoFra, datoTil, merknader, kunde FROM bestilling WHERE bestilling_id = """ & id & """")
            Dim rad As DataRow = myData.Rows.Item(0)

            txtMerknader.Text = rad("merknader")
            dtpFra.Text = rad("datoFra")
            dtpTil.Text = rad("datoTil")

            Dim selected As ComboBoxValue
            For Each selected In cbKundeNavn.Items
                If (selected.ID = rad("kunde")) Then
                    cbKundeNavn.SelectedItem = selected
                    Exit For
                End If
            Next selected
        End If

        Dim myData2 As New DataTable
        myData2 = oppkobling.Query("SELECT bestillingsprodukt.produkt_id, navn, beskrivelse FROM bestillingsprodukt, produkt WHERE bestillingsprodukt.produkt_id = produkt.produkt_id AND bestillingsprodukt.bestilling_id = """ & id & """")
        Dim rad2 As DataRow
        For Each rad2 In myData2.Rows
            addProdukt(rad2("produkt_id"), rad2("navn"), rad2("beskrivelse"))
        Next rad2
    End Sub

    Private Sub addProdukt(ByVal id As String, ByVal navn As String, ByVal beskrivelse As String)
        Dim item As ListViewItem
        For Each item In lvProdukt.Items
            Dim _id As String = item.SubItems.Item(0).Text

            If (_id = id) Then
                Return
            End If
        Next item

        Dim str(2) As String
        str(0) = id
        str(1) = navn
        str(2) = beskrivelse
        Dim itm As ListViewItem = New ListViewItem(str)
        lvProdukt.Items.Add(itm)

        For Each column As ColumnHeader In Me.lvProdukt.Columns
            column.Width = -2
        Next column
    End Sub

    Private Sub initListViewProdukt()
        lvProdukt.Columns.Add("Id")
        lvProdukt.Columns.Add("Navn")
        lvProdukt.Columns.Add("Beskrivelse")

        For Each column As ColumnHeader In Me.lvProdukt.Columns
            column.Width = -2
        Next column
    End Sub

    Private Sub initKunder()
        Dim myData As New DataTable
        myData = oppkobling.Query("SELECT kunde.person_id, fornavn, etternavn FROM kunde, person WHERE kunde.person_id = person.person_id")

        cbKundeNavn.Items.Clear()
        Dim rad As DataRow
        For Each rad In myData.Rows
            cbKundeNavn.Items.Add(New ComboBoxValue(rad("person_id"), rad("etternavn") & ", " & rad("fornavn"), rad("person_id")))
        Next rad
    End Sub

    Private Sub cbKundeNavn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbKundeNavn.SelectedIndexChanged
        Dim selected As ComboBoxValue = cbKundeNavn.SelectedItem

        If (selected IsNot Nothing) Then
            Dim myData As New DataTable
            myData = oppkobling.Query("SELECT adresse, hoyde, vekt, skoNr FROM kunde, person WHERE kunde.person_id = person.person_id AND kunde.person_id = """ & selected.ID & """")
            Dim rad As DataRow = myData.Rows.Item(0)
            txtKundeAdresse.Text = rad("adresse")
            txtKundeHoyde.Text = rad("hoyde")
            txtKundeVekt.Text = rad("vekt")
            txtKundeSkonr.Text = rad("skoNr")
        End If
    End Sub

    Private Sub frmUtleieregistrering_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            oppkobling.kobleTil()
        Catch ex As Exception
            MessageBox.Show("Kunne ikke koble til database", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.Abort
        End Try

        initKunder()
        initListViewProdukt()
        init()
    End Sub

    Private Sub btnProduktFjern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduktFjern.Click
        Dim item As ListViewItem
        For Each item In lvProdukt.SelectedItems
            lvProdukt.Items.Remove(item)
        Next item
    End Sub

    Private Sub btnKundeEndre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKundeEndre.Click
        Dim selected As ComboBoxValue = cbKundeNavn.SelectedItem

        If (selected IsNot Nothing) Then
            Dim dialog As New frmKunderegistrering(selected.ID)

            If (dialog.ShowDialog() = DialogResult.OK) Then
                initKunder()

                Dim item As ComboBoxValue
                For Each item In cbKundeNavn.Items
                    If (item.ID = selected.ID) Then
                        cbKundeNavn.SelectedItem = item
                        Exit For
                    End If
                Next item
            End If
        Else

        End If
    End Sub

    Private Sub btnKundeOpprett_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKundeOpprett.Click
        Dim dialog As New frmKunderegistrering

        If (dialog.ShowDialog() = DialogResult.OK) Then
            initKunder()

            Dim item As ComboBoxValue
            For Each item In cbKundeNavn.Items
                If (item.ID = dialog.id) Then
                    cbKundeNavn.SelectedItem = item
                    Exit For
                End If
            Next item
        End If
    End Sub

    Private Sub btnProduktLeggTil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduktLeggTil.Click
        Dim dialog As New frmDialogUtleieProdukt

        If (dialog.ShowDialog() = DialogResult.OK) Then
            addProdukt(dialog.produkt.id, dialog.produkt.navn, dialog.produkt.beskrivelse)
        End If
    End Sub

    Private Sub btnAvbryt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvbryt.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnLagre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLagre.Click
        If (valid()) Then
            Dim updatedId As Integer = id

            Dim selectedKundeId As ComboBoxValue = cbKundeNavn.SelectedItem
            Dim kundeId As String = selectedKundeId.ID

            Dim selgerId As String = frmHoved.login.getPersonId

            If (id <> 0) Then
                oppkobling.Query("UPDATE bestilling SET datoFra = """ & dtpFra.Text & """, datoTil = """ & dtpTil.Text & """, merknader = """ & txtMerknader.Text & """, kunde = """ & kundeId & """ WHERE bestilling_id = """ & updatedId & """")
            Else
                updatedId = oppkobling.executeQuery("INSERT INTO bestilling (datoFra, datoTil, merknader, selger, kunde) VALUES (""" & dtpFra.Text & """, """ & dtpTil.Text & """, """ & txtMerknader.Text & """, """ & selgerId & """, """ & kundeId & """)")
            End If

            If (updatedId = 0) Then
                MessageBox.Show("Kunne ikke lagre til databasen", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DialogResult = DialogResult.Abort
            Else
                oppkobling.executeQuery("DELETE FROM bestillingsprodukt WHERE bestilling_id = """ & updatedId & """")

                Dim item As ListViewItem
                For Each item In lvProdukt.Items
                    Dim _id As String = item.SubItems.Item(0).Text

                    Try
                        oppkobling.executeQuery("INSERT INTO bestillingsprodukt (bestilling_id, produkt_id) VALUES (""" & updatedId & """, """ & _id & """)")
                    Catch ex As Exception
                    End Try
                Next item

                Me.DialogResult = DialogResult.OK
            End If
        End If
    End Sub

    Private Function valid() As Boolean
        If (cbKundeNavn.SelectedItem Is Nothing) Then
            MessageBox.Show("Velg kunde!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbKundeNavn.Focus()
            Return False
        End If

        If (lvProdukt.Items.Count = 0) Then
            MessageBox.Show("Legg til minst ett produkt!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnProduktLeggTil.Focus()
            Return False
        End If

        Return True
    End Function
End Class