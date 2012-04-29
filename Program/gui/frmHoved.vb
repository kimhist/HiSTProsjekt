Public Class frmHoved
    Private caller As Form
    Private login As Login

    Sub New(ByRef caller As Object, ByVal login As Login)
        Me.caller = caller

        If (login IsNot Nothing) Then
            Me.login = login
            InitializeComponent()
        Else
            Throw New Exception
        End If
    End Sub

    Private Sub frmHoved_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmHoved_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        caller.Close()
    End Sub
End Class