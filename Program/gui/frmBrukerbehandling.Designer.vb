﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrukerbehandling
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
        Me.lblFornavn = New System.Windows.Forms.Label()
        Me.lblEtternavn = New System.Windows.Forms.Label()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.lblTelefonnr = New System.Windows.Forms.Label()
        Me.lblFodt = New System.Windows.Forms.Label()
        Me.txtFornavn = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.txtTelefon = New System.Windows.Forms.TextBox()
        Me.txtFodt = New System.Windows.Forms.TextBox()
        Me.lblStilling = New System.Windows.Forms.Label()
        Me.cbStilling = New System.Windows.Forms.ComboBox()
        Me.dtFodt = New System.Windows.Forms.DateTimePicker()
        Me.lblBrukernavn = New System.Windows.Forms.Label()
        Me.lblPassord = New System.Windows.Forms.Label()
        Me.txtBrukernavn = New System.Windows.Forms.TextBox()
        Me.txtPassord = New System.Windows.Forms.TextBox()
        Me.btnLagre = New System.Windows.Forms.Button()
        Me.btnAvbryt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFornavn
        '
        Me.lblFornavn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFornavn.AutoSize = True
        Me.lblFornavn.Location = New System.Drawing.Point(15, 15)
        Me.lblFornavn.Name = "lblFornavn"
        Me.lblFornavn.Size = New System.Drawing.Size(46, 13)
        Me.lblFornavn.TabIndex = 1
        Me.lblFornavn.Text = "&Fornavn"
        '
        'lblEtternavn
        '
        Me.lblEtternavn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEtternavn.AutoSize = True
        Me.lblEtternavn.Location = New System.Drawing.Point(15, 43)
        Me.lblEtternavn.Name = "lblEtternavn"
        Me.lblEtternavn.Size = New System.Drawing.Size(53, 13)
        Me.lblEtternavn.TabIndex = 3
        Me.lblEtternavn.Text = "&Etternavn"
        '
        'lblAdresse
        '
        Me.lblAdresse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Location = New System.Drawing.Point(15, 69)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(45, 13)
        Me.lblAdresse.TabIndex = 5
        Me.lblAdresse.Text = "A&dresse"
        '
        'lblTelefonnr
        '
        Me.lblTelefonnr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTelefonnr.AutoSize = True
        Me.lblTelefonnr.Location = New System.Drawing.Point(15, 95)
        Me.lblTelefonnr.Name = "lblTelefonnr"
        Me.lblTelefonnr.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefonnr.TabIndex = 7
        Me.lblTelefonnr.Text = "&Telefonnr"
        '
        'lblFodt
        '
        Me.lblFodt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFodt.AutoSize = True
        Me.lblFodt.Location = New System.Drawing.Point(15, 124)
        Me.lblFodt.Name = "lblFodt"
        Me.lblFodt.Size = New System.Drawing.Size(28, 13)
        Me.lblFodt.TabIndex = 9
        Me.lblFodt.Text = "F&ødt"
        '
        'txtFornavn
        '
        Me.txtFornavn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFornavn.Location = New System.Drawing.Point(124, 14)
        Me.txtFornavn.Name = "txtFornavn"
        Me.txtFornavn.Size = New System.Drawing.Size(170, 20)
        Me.txtFornavn.TabIndex = 2
        '
        'txtAdresse
        '
        Me.txtAdresse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAdresse.Location = New System.Drawing.Point(124, 40)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(170, 20)
        Me.txtAdresse.TabIndex = 4
        '
        'txtTelefon
        '
        Me.txtTelefon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefon.Location = New System.Drawing.Point(124, 66)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(170, 20)
        Me.txtTelefon.TabIndex = 6
        '
        'txtFodt
        '
        Me.txtFodt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFodt.Location = New System.Drawing.Point(124, 92)
        Me.txtFodt.Name = "txtFodt"
        Me.txtFodt.Size = New System.Drawing.Size(170, 20)
        Me.txtFodt.TabIndex = 8
        '
        'lblStilling
        '
        Me.lblStilling.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStilling.AutoSize = True
        Me.lblStilling.Location = New System.Drawing.Point(15, 194)
        Me.lblStilling.Name = "lblStilling"
        Me.lblStilling.Size = New System.Drawing.Size(37, 13)
        Me.lblStilling.TabIndex = 11
        Me.lblStilling.Text = "&Stilling"
        '
        'cbStilling
        '
        Me.cbStilling.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbStilling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStilling.FormattingEnabled = True
        Me.cbStilling.Items.AddRange(New Object() {"Lagerarbeider", "Selger", "Sekretær", "Daglig leder"})
        Me.cbStilling.Location = New System.Drawing.Point(124, 191)
        Me.cbStilling.Name = "cbStilling"
        Me.cbStilling.Size = New System.Drawing.Size(170, 21)
        Me.cbStilling.TabIndex = 12
        '
        'dtFodt
        '
        Me.dtFodt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFodt.Location = New System.Drawing.Point(124, 118)
        Me.dtFodt.Name = "dtFodt"
        Me.dtFodt.Size = New System.Drawing.Size(170, 20)
        Me.dtFodt.TabIndex = 10
        '
        'lblBrukernavn
        '
        Me.lblBrukernavn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBrukernavn.AutoSize = True
        Me.lblBrukernavn.Location = New System.Drawing.Point(15, 221)
        Me.lblBrukernavn.Name = "lblBrukernavn"
        Me.lblBrukernavn.Size = New System.Drawing.Size(62, 13)
        Me.lblBrukernavn.TabIndex = 13
        Me.lblBrukernavn.Text = "&Brukernavn"
        '
        'lblPassord
        '
        Me.lblPassord.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPassord.AutoSize = True
        Me.lblPassord.Location = New System.Drawing.Point(15, 247)
        Me.lblPassord.Name = "lblPassord"
        Me.lblPassord.Size = New System.Drawing.Size(45, 13)
        Me.lblPassord.TabIndex = 15
        Me.lblPassord.Text = "&Passord"
        '
        'txtBrukernavn
        '
        Me.txtBrukernavn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBrukernavn.Location = New System.Drawing.Point(124, 218)
        Me.txtBrukernavn.Name = "txtBrukernavn"
        Me.txtBrukernavn.Size = New System.Drawing.Size(170, 20)
        Me.txtBrukernavn.TabIndex = 14
        '
        'txtPassord
        '
        Me.txtPassord.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassord.Location = New System.Drawing.Point(124, 244)
        Me.txtPassord.Name = "txtPassord"
        Me.txtPassord.Size = New System.Drawing.Size(170, 20)
        Me.txtPassord.TabIndex = 16
        '
        'btnLagre
        '
        Me.btnLagre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLagre.Image = Global.Program.My.Resources.Resources.confirm
        Me.btnLagre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLagre.Location = New System.Drawing.Point(241, 277)
        Me.btnLagre.Name = "btnLagre"
        Me.btnLagre.Size = New System.Drawing.Size(58, 23)
        Me.btnLagre.TabIndex = 17
        Me.btnLagre.Text = "&Lagre"
        Me.btnLagre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLagre.UseVisualStyleBackColor = True
        '
        'btnAvbryt
        '
        Me.btnAvbryt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAvbryt.Image = Global.Program.My.Resources.Resources.cancel
        Me.btnAvbryt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAvbryt.Location = New System.Drawing.Point(10, 277)
        Me.btnAvbryt.Name = "btnAvbryt"
        Me.btnAvbryt.Size = New System.Drawing.Size(59, 23)
        Me.btnAvbryt.TabIndex = 18
        Me.btnAvbryt.Text = "&Avbryt"
        Me.btnAvbryt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAvbryt.UseVisualStyleBackColor = True
        '
        'frmBrukerbehandling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 312)
        Me.Controls.Add(Me.btnAvbryt)
        Me.Controls.Add(Me.btnLagre)
        Me.Controls.Add(Me.txtPassord)
        Me.Controls.Add(Me.txtBrukernavn)
        Me.Controls.Add(Me.lblPassord)
        Me.Controls.Add(Me.lblBrukernavn)
        Me.Controls.Add(Me.dtFodt)
        Me.Controls.Add(Me.cbStilling)
        Me.Controls.Add(Me.lblStilling)
        Me.Controls.Add(Me.txtFodt)
        Me.Controls.Add(Me.txtTelefon)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.txtFornavn)
        Me.Controls.Add(Me.lblFodt)
        Me.Controls.Add(Me.lblTelefonnr)
        Me.Controls.Add(Me.lblAdresse)
        Me.Controls.Add(Me.lblEtternavn)
        Me.Controls.Add(Me.lblFornavn)
        Me.Name = "frmBrukerbehandling"
        Me.Text = "Brukerbehandling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFornavn As System.Windows.Forms.Label
    Friend WithEvents lblEtternavn As System.Windows.Forms.Label
    Friend WithEvents lblAdresse As System.Windows.Forms.Label
    Friend WithEvents lblTelefonnr As System.Windows.Forms.Label
    Friend WithEvents lblFodt As System.Windows.Forms.Label
    Friend WithEvents txtFornavn As System.Windows.Forms.TextBox
    Friend WithEvents txtAdresse As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefon As System.Windows.Forms.TextBox
    Friend WithEvents txtFodt As System.Windows.Forms.TextBox
    Friend WithEvents lblStilling As System.Windows.Forms.Label
    Friend WithEvents cbStilling As System.Windows.Forms.ComboBox
    Friend WithEvents dtFodt As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBrukernavn As System.Windows.Forms.Label
    Friend WithEvents lblPassord As System.Windows.Forms.Label
    Friend WithEvents txtBrukernavn As System.Windows.Forms.TextBox
    Friend WithEvents txtPassord As System.Windows.Forms.TextBox
    Friend WithEvents btnLagre As System.Windows.Forms.Button
    Friend WithEvents btnAvbryt As System.Windows.Forms.Button
End Class