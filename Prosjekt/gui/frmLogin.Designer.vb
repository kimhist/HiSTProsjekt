<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblBrukernavn = New System.Windows.Forms.Label()
        Me.lblPassord = New System.Windows.Forms.Label()
        Me.txtBrukernavn = New System.Windows.Forms.TextBox()
        Me.txtPassord = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(221, 178)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(71, 23)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Logg inn"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblBrukernavn
        '
        Me.lblBrukernavn.AutoSize = True
        Me.lblBrukernavn.Location = New System.Drawing.Point(12, 65)
        Me.lblBrukernavn.Name = "lblBrukernavn"
        Me.lblBrukernavn.Size = New System.Drawing.Size(62, 13)
        Me.lblBrukernavn.TabIndex = 1
        Me.lblBrukernavn.Text = "Brukernavn"
        '
        'lblPassord
        '
        Me.lblPassord.AutoSize = True
        Me.lblPassord.Location = New System.Drawing.Point(12, 99)
        Me.lblPassord.Name = "lblPassord"
        Me.lblPassord.Size = New System.Drawing.Size(45, 13)
        Me.lblPassord.TabIndex = 2
        Me.lblPassord.Text = "Passord"
        '
        'txtBrukernavn
        '
        Me.txtBrukernavn.Location = New System.Drawing.Point(157, 62)
        Me.txtBrukernavn.Name = "txtBrukernavn"
        Me.txtBrukernavn.Size = New System.Drawing.Size(135, 20)
        Me.txtBrukernavn.TabIndex = 0
        '
        'txtPassord
        '
        Me.txtPassord.Location = New System.Drawing.Point(157, 96)
        Me.txtPassord.Name = "txtPassord"
        Me.txtPassord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassord.Size = New System.Drawing.Size(135, 20)
        Me.txtPassord.TabIndex = 1
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 213)
        Me.Controls.Add(Me.txtPassord)
        Me.Controls.Add(Me.txtBrukernavn)
        Me.Controls.Add(Me.lblPassord)
        Me.Controls.Add(Me.lblBrukernavn)
        Me.Controls.Add(Me.btnLogin)
        Me.Name = "frmLogin"
        Me.Text = "Pålogging"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lblBrukernavn As System.Windows.Forms.Label
    Friend WithEvents lblPassord As System.Windows.Forms.Label
    Friend WithEvents txtBrukernavn As System.Windows.Forms.TextBox
    Friend WithEvents txtPassord As System.Windows.Forms.TextBox

End Class
