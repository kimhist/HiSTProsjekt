Public Class frmHoved
    Private caller As Form
    Private login As Login

    Sub New(ByRef caller As Object, ByVal login As Login)
        Me.caller = caller

        If (login IsNot Nothing) Then
            Me.login = login
            InitializeComponent()
            init()
        Else
            Throw New Exception
        End If
    End Sub

    Private Sub init()
        addStatistikk()
        addEndrePakke()
        addPakkeregistrering()

        Select Case login.getStilling()
            Case "Daglig leder"
                addEndreUtleie()
                addUtleieRegistrering()
                addEndreProdukt()
                addProduktRegistrering()
                addEndreKunde()
                addKunderegistrering()
                addEndreBruker()
                addBrukerbehandling()
            Case "Selger"
                addEndreUtleie()
                addUtleieRegistrering()
                addEndreKunde()
                addKunderegistrering()
            Case "Lagerarbeider"
                addEndreProdukt()
                addProduktRegistrering()
        End Select
    End Sub

    Private Sub createButton(ByVal tabIndex As Integer, ByVal text As String, ByVal form As Form)
        Dim btn As Button = New Button
        With btn
            .Text = text
            .Dock = DockStyle.Top
            .TabIndex = tabIndex
        End With

        AddHandler btn.Click, Function(senderObj, args) openForm(form)

        pnHoved.Controls.Add(btn)
    End Sub

    Private Function openForm(ByRef form As Form) As Boolean
        form.ShowDialog()
        Return True
    End Function

    Private Sub addBrukerbehandling()
        createButton(1, "Brukerbehandling", New frmBrukerbehandling)
    End Sub

    Private Sub addEndreBruker()
        createButton(2, "Endre bruker", New frmEndreBruker)
    End Sub

    Private Sub addKunderegistrering()
        createButton(3, "Kunderegistrering", New frmKunderegistrering)
    End Sub

    Private Sub addEndreKunde()
        createButton(4, "Endre kunde", New frmEndreKunde)
    End Sub

    Private Sub addProduktRegistrering()
        createButton(5, "Produktregistrering", New frmProduktRegistrering)
    End Sub

    Private Sub addEndreProdukt()
        createButton(6, "Endre produkt", New frmEndreProdukt)
    End Sub

    Private Sub addUtleieRegistrering()
        createButton(7, "Utleieregistrering", New frmUtleieregistrering)
    End Sub

    Private Sub addEndreUtleie()
        createButton(8, "Endre utleie", New frmEndreUtleie)
    End Sub

    Private Sub addPakkeregistrering()
        createButton(9, "Pakkeregistrering", New frmPakkeregistrering)
    End Sub

    Private Sub addEndrePakke()
        createButton(10, "Endre pakke", New frmEndrePakke)
    End Sub

    Private Sub addStatistikk()
        createButton(11, "Statistikk", New frmStatistikk)
    End Sub

    Private Sub frmHoved_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        caller.Close()
    End Sub

    Private Sub tsmiLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiLogout.Click
        caller.Show()
        Me.Dispose()
    End Sub
End Class