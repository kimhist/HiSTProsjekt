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
            myData = oppkobling.Query("SELECT datoFra, merknader, kunde FROM bestilling WHERE bestilling_id = """ & id & """")
            Dim rad As DataRow = myData.Rows.Item(0)

            txtMerknader.Text = rad("merknader")
            dtpFra.Text = rad("datoFra")

            Dim selected As ComboBoxValue
            For Each selected In cbKundeNavn.Items
                If (selected.ID = rad("kunde")) Then
                    cbKundeNavn.SelectedItem = selected
                    Exit For
                End If
            Next selected
        End If

        Dim myData2 As New DataTable
        myData2 = oppkobling.Query("SELECT navn, beskrivelse FROM bestillingsprodukt, produkt WHERE bestillingsprodukt.produkt_id = produkt.produkt_id AND bestillingsprodukt.produkt_id = """ & id & """")
        Dim rad2 As DataRow
        For Each rad2 In myData2.Rows
            addProdukt(rad2("navn"), rad2("beskrivelse"))
        Next rad2
    End Sub

    Private Sub addProdukt(ByVal navn As String, ByVal beskrivelse As String)

    End Sub

    Private Sub initListViewProdukt()
        lvProdukt.Columns.Add("Navn")
        lvProdukt.Columns.Add("Beskrivelse")

        For Each column As ColumnHeader In Me.lvProdukt.Columns
            column.Width = -2
        Next
    End Sub

    Private Sub initKunder()
        Dim myData As New DataTable
        myData = oppkobling.Query("SELECT kunde.person_id, fornavn, etternavn FROM kunde, person WHERE kunde.person_id = person.person_id")

        Dim rad As DataRow
        For Each rad In myData.Rows
            cbKundeNavn.Items.Add(New ComboBoxValue(rad("person_id"), rad("etternavn") & ", " & rad("fornavn"), rad("person_id")))
        Next rad
    End Sub

    Private Sub cbKundeNavn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbKundeNavn.SelectedIndexChanged
        Dim selected As ComboBoxValue = cbKundeNavn.SelectedItem

        Dim myData As New DataTable
        myData = oppkobling.Query("SELECT adresse, hoyde, vekt, skoNr FROM kunde, person WHERE kunde.person_id = person.person_id AND kunde.person_id = """ & selected.ID & """")
        Dim rad As DataRow = myData.Rows.Item(0)
        txtKundeAdresse.Text = rad("adresse")
        txtKundeHoyde.Text = rad("hoyde")
        txtKundeVekt.Text = rad("vekt")
        txtKundeSkonr.Text = rad("skoNr")
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
End Class