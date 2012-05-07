Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmStatistikk
    Private oppkobling As New Sql()

    Private Sub frmStatistikk_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        oppkobling.kobleFra()
        Me.Dispose()
    End Sub

    Private Sub frmStatistikk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpTil.Value = Now
        Dim fra As Date = dtpTil.Value
        Dim ts As TimeSpan = New TimeSpan(365, 0, 0, 0)
        fra = fra.Subtract(ts)

        dtpFra.Value = fra

        updateAvanse()
    End Sub

    Private Sub updateProsentfordeling()
        chProsentfordeling.Series.Item(0).Points.Clear()

        Dim myData As New DataTable
        myData = oppkobling.Query("SELECT COUNT(bestilling.bestilling_id) AS `count`, gNavn FROM bestilling, bestillingsprodukt, produkt, produktgruppe WHERE bestilling.bestilling_id = bestillingsprodukt.bestilling_id AND bestillingsprodukt.produkt_id = produkt.produkt_id AND produkt.pGruppe_id = produktgruppe.pGruppe_id AND datoFra >= """ & dtpFra.Text & """ AND datoFra <= """ & dtpTil.Text & """ GROUP BY produkt.pGruppe_id")

        Dim sum As Integer = 0
        Dim rad As DataRow
        For Each rad In myData.Rows
            sum += rad("count")
        Next rad

        For Each rad In myData.Rows
            Dim count As Integer = rad("count")
            Dim produktGruppe As String = rad("gNavn")

            chProsentfordeling.Series.Item(0).Points.AddXY(produktGruppe & ", " & ((count / sum) * 100).ToString("0.#") & "%", count)
        Next rad
    End Sub

    Private Sub date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFra.ValueChanged, dtpTil.ValueChanged
        Try
            updateProsentfordeling()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub updateAvanse()
        chAvanse.Series.Item(0).Points.Clear()

        Dim myData As New DataTable
        myData = oppkobling.Query("SELECT fornavn, etternavn, SUM(sum) AS `sum` FROM bestilling, person WHERE bestilling.selger = person.person_id GROUP BY bestilling.selger ORDER BY sum DESC")

        Dim i As Integer
        For i = 0 To myData.Rows.Count - 1
            chAvanse.Series.Item(0).Points.Add(New DataPoint() With {.AxisLabel = myData.Rows.Item(i)("etternavn") & ", " & myData.Rows.Item(i)("fornavn"), .XValue = (i + 1), .YValues = {Convert.ToDouble(myData.Rows.Item(i)("sum"))}})
        Next i
    End Sub
End Class