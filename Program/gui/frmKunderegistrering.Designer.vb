﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKunderegistrering
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKunderegistrering))
        Me.btnAvbryt = New System.Windows.Forms.Button()
        Me.btnLagre = New System.Windows.Forms.Button()
        Me.txtSkonummer = New System.Windows.Forms.TextBox()
        Me.txtVekt = New System.Windows.Forms.TextBox()
        Me.lblSkonr = New System.Windows.Forms.Label()
        Me.lblVekt = New System.Windows.Forms.Label()
        Me.dtpFodt = New System.Windows.Forms.DateTimePicker()
        Me.lblHoyde = New System.Windows.Forms.Label()
        Me.txtTelefon = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.txtEtternavn = New System.Windows.Forms.TextBox()
        Me.txtFornavn = New System.Windows.Forms.TextBox()
        Me.lblFodt = New System.Windows.Forms.Label()
        Me.lblTelefonnr = New System.Windows.Forms.Label()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.lblEtternavn = New System.Windows.Forms.Label()
        Me.lblFornavn = New System.Windows.Forms.Label()
        Me.txtHoyde = New System.Windows.Forms.TextBox()
        Me.txtPostnr = New System.Windows.Forms.TextBox()
        Me.lblPostnr = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        'btnLagre
        '
        Me.btnLagre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLagre.Image = Global.Program.My.Resources.Resources.confirm
        Me.btnLagre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLagre.Location = New System.Drawing.Point(242, 277)
        Me.btnLagre.Name = "btnLagre"
        Me.btnLagre.Size = New System.Drawing.Size(58, 23)
        Me.btnLagre.TabIndex = 19
        Me.btnLagre.Text = "&Lagre"
        Me.btnLagre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLagre.UseVisualStyleBackColor = True
        '
        'txtSkonummer
        '
        Me.txtSkonummer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSkonummer.Location = New System.Drawing.Point(124, 244)
        Me.txtSkonummer.Name = "txtSkonummer"
        Me.txtSkonummer.Size = New System.Drawing.Size(176, 20)
        Me.txtSkonummer.TabIndex = 17
        '
        'txtVekt
        '
        Me.txtVekt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVekt.Location = New System.Drawing.Point(124, 218)
        Me.txtVekt.Name = "txtVekt"
        Me.txtVekt.Size = New System.Drawing.Size(176, 20)
        Me.txtVekt.TabIndex = 15
        '
        'lblSkonr
        '
        Me.lblSkonr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSkonr.AutoSize = True
        Me.lblSkonr.Location = New System.Drawing.Point(15, 247)
        Me.lblSkonr.Name = "lblSkonr"
        Me.lblSkonr.Size = New System.Drawing.Size(63, 13)
        Me.lblSkonr.TabIndex = 16
        Me.lblSkonr.Text = "&Skonummer"
        '
        'lblVekt
        '
        Me.lblVekt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVekt.AutoSize = True
        Me.lblVekt.Location = New System.Drawing.Point(15, 221)
        Me.lblVekt.Name = "lblVekt"
        Me.lblVekt.Size = New System.Drawing.Size(29, 13)
        Me.lblVekt.TabIndex = 14
        Me.lblVekt.Text = "&Vekt"
        '
        'dtpFodt
        '
        Me.dtpFodt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFodt.CustomFormat = "yyyy-MM-dd"
        Me.dtpFodt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFodt.Location = New System.Drawing.Point(124, 145)
        Me.dtpFodt.Name = "dtpFodt"
        Me.dtpFodt.Size = New System.Drawing.Size(176, 20)
        Me.dtpFodt.TabIndex = 11
        '
        'lblHoyde
        '
        Me.lblHoyde.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHoyde.AutoSize = True
        Me.lblHoyde.Location = New System.Drawing.Point(15, 194)
        Me.lblHoyde.Name = "lblHoyde"
        Me.lblHoyde.Size = New System.Drawing.Size(38, 13)
        Me.lblHoyde.TabIndex = 12
        Me.lblHoyde.Text = "&Høyde"
        '
        'txtTelefon
        '
        Me.txtTelefon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefon.Location = New System.Drawing.Point(124, 119)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(176, 20)
        Me.txtTelefon.TabIndex = 9
        '
        'txtAdresse
        '
        Me.txtAdresse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAdresse.Location = New System.Drawing.Point(124, 66)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(176, 20)
        Me.txtAdresse.TabIndex = 5
        '
        'txtEtternavn
        '
        Me.txtEtternavn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEtternavn.Location = New System.Drawing.Point(124, 40)
        Me.txtEtternavn.Name = "txtEtternavn"
        Me.txtEtternavn.Size = New System.Drawing.Size(176, 20)
        Me.txtEtternavn.TabIndex = 3
        '
        'txtFornavn
        '
        Me.txtFornavn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFornavn.Location = New System.Drawing.Point(124, 14)
        Me.txtFornavn.Name = "txtFornavn"
        Me.txtFornavn.Size = New System.Drawing.Size(176, 20)
        Me.txtFornavn.TabIndex = 1
        '
        'lblFodt
        '
        Me.lblFodt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFodt.AutoSize = True
        Me.lblFodt.Location = New System.Drawing.Point(15, 151)
        Me.lblFodt.Name = "lblFodt"
        Me.lblFodt.Size = New System.Drawing.Size(28, 13)
        Me.lblFodt.TabIndex = 10
        Me.lblFodt.Text = "F&ødt"
        '
        'lblTelefonnr
        '
        Me.lblTelefonnr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTelefonnr.AutoSize = True
        Me.lblTelefonnr.Location = New System.Drawing.Point(15, 122)
        Me.lblTelefonnr.Name = "lblTelefonnr"
        Me.lblTelefonnr.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefonnr.TabIndex = 8
        Me.lblTelefonnr.Text = "&Telefonnr"
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
        Me.lblAdresse.TabIndex = 4
        Me.lblAdresse.Text = "A&dresse"
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
        Me.lblEtternavn.TabIndex = 2
        Me.lblEtternavn.Text = "&Etternavn"
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
        Me.lblFornavn.TabIndex = 0
        Me.lblFornavn.Text = "&Fornavn"
        '
        'txtHoyde
        '
        Me.txtHoyde.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoyde.Location = New System.Drawing.Point(124, 192)
        Me.txtHoyde.Name = "txtHoyde"
        Me.txtHoyde.Size = New System.Drawing.Size(176, 20)
        Me.txtHoyde.TabIndex = 13
        '
        'txtPostnr
        '
        Me.txtPostnr.Location = New System.Drawing.Point(124, 93)
        Me.txtPostnr.Name = "txtPostnr"
        Me.txtPostnr.Size = New System.Drawing.Size(176, 20)
        Me.txtPostnr.TabIndex = 7
        '
        'lblPostnr
        '
        Me.lblPostnr.AutoSize = True
        Me.lblPostnr.Location = New System.Drawing.Point(15, 96)
        Me.lblPostnr.Name = "lblPostnr"
        Me.lblPostnr.Size = New System.Drawing.Size(65, 13)
        Me.lblPostnr.TabIndex = 6
        Me.lblPostnr.Text = "&Postnummer"
        '
        'frmKunderegistrering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 310)
        Me.Controls.Add(Me.lblPostnr)
        Me.Controls.Add(Me.txtPostnr)
        Me.Controls.Add(Me.txtHoyde)
        Me.Controls.Add(Me.btnAvbryt)
        Me.Controls.Add(Me.btnLagre)
        Me.Controls.Add(Me.txtSkonummer)
        Me.Controls.Add(Me.txtVekt)
        Me.Controls.Add(Me.lblSkonr)
        Me.Controls.Add(Me.lblVekt)
        Me.Controls.Add(Me.dtpFodt)
        Me.Controls.Add(Me.lblHoyde)
        Me.Controls.Add(Me.txtTelefon)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.txtEtternavn)
        Me.Controls.Add(Me.txtFornavn)
        Me.Controls.Add(Me.lblFodt)
        Me.Controls.Add(Me.lblTelefonnr)
        Me.Controls.Add(Me.lblAdresse)
        Me.Controls.Add(Me.lblEtternavn)
        Me.Controls.Add(Me.lblFornavn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmKunderegistrering"
        Me.Text = "Kunderegistrering"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAvbryt As System.Windows.Forms.Button
    Friend WithEvents btnLagre As System.Windows.Forms.Button
    Friend WithEvents txtSkonummer As System.Windows.Forms.TextBox
    Friend WithEvents txtVekt As System.Windows.Forms.TextBox
    Friend WithEvents lblSkonr As System.Windows.Forms.Label
    Friend WithEvents lblVekt As System.Windows.Forms.Label
    Friend WithEvents dtpFodt As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHoyde As System.Windows.Forms.Label
    Friend WithEvents txtTelefon As System.Windows.Forms.TextBox
    Friend WithEvents txtAdresse As System.Windows.Forms.TextBox
    Friend WithEvents txtEtternavn As System.Windows.Forms.TextBox
    Friend WithEvents txtFornavn As System.Windows.Forms.TextBox
    Friend WithEvents lblFodt As System.Windows.Forms.Label
    Friend WithEvents lblTelefonnr As System.Windows.Forms.Label
    Friend WithEvents lblAdresse As System.Windows.Forms.Label
    Friend WithEvents lblEtternavn As System.Windows.Forms.Label
    Friend WithEvents lblFornavn As System.Windows.Forms.Label
    Friend WithEvents txtHoyde As System.Windows.Forms.TextBox
    Friend WithEvents txtPostnr As System.Windows.Forms.TextBox
    Friend WithEvents lblPostnr As System.Windows.Forms.Label
End Class
