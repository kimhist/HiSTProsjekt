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
        Me.btnLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogin.Image = Global.Program.My.Resources.Resources.confirm
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.Location = New System.Drawing.Point(193, 63)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(72, 23)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "&Logg inn"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblBrukernavn
        '
        Me.lblBrukernavn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBrukernavn.AutoSize = True
        Me.lblBrukernavn.Location = New System.Drawing.Point(16, 15)
        Me.lblBrukernavn.Name = "lblBrukernavn"
        Me.lblBrukernavn.Size = New System.Drawing.Size(62, 13)
        Me.lblBrukernavn.TabIndex = 0
        Me.lblBrukernavn.Text = "&Brukernavn"
        '
        'lblPassord
        '
        Me.lblPassord.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPassord.AutoSize = True
        Me.lblPassord.Location = New System.Drawing.Point(16, 41)
        Me.lblPassord.Name = "lblPassord"
        Me.lblPassord.Size = New System.Drawing.Size(45, 13)
        Me.lblPassord.TabIndex = 2
        Me.lblPassord.Text = "&Passord"
        '
        'txtBrukernavn
        '
        Me.txtBrukernavn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBrukernavn.Location = New System.Drawing.Point(112, 12)
        Me.txtBrukernavn.Name = "txtBrukernavn"
        Me.txtBrukernavn.Size = New System.Drawing.Size(153, 20)
        Me.txtBrukernavn.TabIndex = 1
        '
        'txtPassord
        '
        Me.txtPassord.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassord.Location = New System.Drawing.Point(112, 38)
        Me.txtPassord.Name = "txtPassord"
        Me.txtPassord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassord.Size = New System.Drawing.Size(153, 20)
        Me.txtPassord.TabIndex = 3
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 98)
        Me.Controls.Add(Me.txtPassord)
        Me.Controls.Add(Me.txtBrukernavn)
        Me.Controls.Add(Me.lblPassord)
        Me.Controls.Add(Me.lblBrukernavn)
        Me.Controls.Add(Me.btnLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
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
