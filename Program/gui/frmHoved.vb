Imports System.Reflection

Public Class frmHoved
    Public Shared login As Login

    Private caller As Form

    Sub New(ByRef caller As Object, ByVal login As Login)
        Me.caller = caller

        If (login IsNot Nothing) Then
            frmHoved.login = login
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

    Private Sub createButton(ByVal tabIndex As Integer, ByVal text As String, ByVal form As String)
        Dim btn As Button = New Button
        With btn
            .Text = text
            .Dock = DockStyle.Top
            .TabIndex = tabIndex
        End With

        AddHandler btn.Click, Function(senderObj, args) openForm(form)

        pnHoved.Controls.Add(btn)
    End Sub

    Private Function openForm(ByVal form As String) As Boolean
        Dim f As Form

        Select Case form
            Case "frmBrukerbehandling"
                f = New frmBrukerbehandling
            Case "frmEndreBruker"
                f = New frmEndreBruker
            Case "frmKunderegistrering"
                f = New frmKunderegistrering
            Case "frmEndreKunde"
                f = New frmEndreKunde
            Case "frmProduktRegistrering"
                f = New frmProduktRegistrering
            Case "frmEndreProdukt"
                f = New frmEndreProdukt
            Case "frmUtleieregistrering"
                f = New frmUtleieregistrering
            Case "frmEndreUtleie"
                f = New frmEndreUtleie
            Case "frmPakkeregistrering"
                f = New frmPakkeregistrering
            Case "frmEndrePakke"
                f = New frmEndrePakke
            Case "frmStatistikk"
                f = New frmStatistikk
            Case Else
                f = Nothing
        End Select

        Try
            f.ShowDialog()
        Catch ex As Exception
        End Try

        Return True
    End Function

    Private Sub addBrukerbehandling()
        createButton(1, "&Brukerbehandling", "frmBrukerbehandling")
    End Sub

    Private Sub addEndreBruker()
        createButton(2, "Endre b&ruker", "frmEndreBruker")
    End Sub

    Private Sub addKunderegistrering()
        createButton(3, "&Kunderegistrering", "frmKunderegistrering")
    End Sub

    Private Sub addEndreKunde()
        createButton(4, "Endre k&unde", "frmEndreKunde")
    End Sub

    Private Sub addProduktRegistrering()
        createButton(5, "&Produktregistrering", "frmProduktRegistrering")
    End Sub

    Private Sub addEndreProdukt()
        createButton(6, "Endre pr&odukt", "frmEndreProdukt")
    End Sub

    Private Sub addUtleieRegistrering()
        createButton(7, "&Utleieregistrering", "frmUtleieregistrering")
    End Sub

    Private Sub addEndreUtleie()
        createButton(8, "Endre u&tleie", "frmEndreUtleie")
    End Sub

    Private Sub addPakkeregistrering()
        createButton(9, "P&akkeregistrering", "frmPakkeregistrering")
    End Sub

    Private Sub addEndrePakke()
        createButton(10, "Endre pa&kke", "frmEndrePakke")
    End Sub

    Private Sub addStatistikk()
        createButton(11, "&Statistikk", "frmStatistikk")
    End Sub

    Private Sub frmHoved_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        caller.Close()
    End Sub

    Private Sub tsmiLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiLogout.Click
        caller.Show()
        Me.Dispose()
    End Sub

    Private Sub tsmiBrukermanual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiBrukermanual.Click
        System.Diagnostics.Process.Start("http://sportutleie.wikidot.com/")
    End Sub
End Class