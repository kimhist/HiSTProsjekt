<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblBrukernavn = New System.Windows.Forms.Label()
        Me.lblPassord = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnLagre = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFornavn
        '
        Me.lblFornavn.AutoSize = True
        Me.lblFornavn.Location = New System.Drawing.Point(28, 15)
        Me.lblFornavn.Name = "lblFornavn"
        Me.lblFornavn.Size = New System.Drawing.Size(46, 13)
        Me.lblFornavn.TabIndex = 1
        Me.lblFornavn.Text = "&Fornavn"
        '
        'lblEtternavn
        '
        Me.lblEtternavn.AutoSize = True
        Me.lblEtternavn.Location = New System.Drawing.Point(28, 42)
        Me.lblEtternavn.Name = "lblEtternavn"
        Me.lblEtternavn.Size = New System.Drawing.Size(53, 13)
        Me.lblEtternavn.TabIndex = 3
        Me.lblEtternavn.Text = "&Etternavn"
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Location = New System.Drawing.Point(29, 68)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(45, 13)
        Me.lblAdresse.TabIndex = 5
        Me.lblAdresse.Text = "&Adresse"
        '
        'lblTelefonnr
        '
        Me.lblTelefonnr.AutoSize = True
        Me.lblTelefonnr.Location = New System.Drawing.Point(28, 94)
        Me.lblTelefonnr.Name = "lblTelefonnr"
        Me.lblTelefonnr.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefonnr.TabIndex = 7
        Me.lblTelefonnr.Text = "&Telefonnr"
        '
        'lblFodt
        '
        Me.lblFodt.AutoSize = True
        Me.lblFodt.Location = New System.Drawing.Point(29, 123)
        Me.lblFodt.Name = "lblFodt"
        Me.lblFodt.Size = New System.Drawing.Size(28, 13)
        Me.lblFodt.TabIndex = 9
        Me.lblFodt.Text = "F&ødt"
        '
        'txtFornavn
        '
        Me.txtFornavn.Location = New System.Drawing.Point(146, 12)
        Me.txtFornavn.Name = "txtFornavn"
        Me.txtFornavn.Size = New System.Drawing.Size(149, 20)
        Me.txtFornavn.TabIndex = 2
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(146, 39)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(149, 20)
        Me.txtAdresse.TabIndex = 4
        '
        'txtTelefon
        '
        Me.txtTelefon.Location = New System.Drawing.Point(146, 65)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(149, 20)
        Me.txtTelefon.TabIndex = 6
        '
        'txtFodt
        '
        Me.txtFodt.Location = New System.Drawing.Point(146, 91)
        Me.txtFodt.Name = "txtFodt"
        Me.txtFodt.Size = New System.Drawing.Size(149, 20)
        Me.txtFodt.TabIndex = 8
        '
        'lblStilling
        '
        Me.lblStilling.AutoSize = True
        Me.lblStilling.Location = New System.Drawing.Point(28, 194)
        Me.lblStilling.Name = "lblStilling"
        Me.lblStilling.Size = New System.Drawing.Size(37, 13)
        Me.lblStilling.TabIndex = 11
        Me.lblStilling.Text = "&Stilling"
        '
        'cbStilling
        '
        Me.cbStilling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStilling.FormattingEnabled = True
        Me.cbStilling.Items.AddRange(New Object() {"Lagerarbeider", "Selger", "Sekretær", "Daglig leder"})
        Me.cbStilling.Location = New System.Drawing.Point(146, 191)
        Me.cbStilling.Name = "cbStilling"
        Me.cbStilling.Size = New System.Drawing.Size(149, 21)
        Me.cbStilling.TabIndex = 12
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(146, 117)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(149, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'lblBrukernavn
        '
        Me.lblBrukernavn.AutoSize = True
        Me.lblBrukernavn.Location = New System.Drawing.Point(29, 221)
        Me.lblBrukernavn.Name = "lblBrukernavn"
        Me.lblBrukernavn.Size = New System.Drawing.Size(62, 13)
        Me.lblBrukernavn.TabIndex = 13
        Me.lblBrukernavn.Text = "&Brukernavn"
        '
        'lblPassord
        '
        Me.lblPassord.AutoSize = True
        Me.lblPassord.Location = New System.Drawing.Point(29, 247)
        Me.lblPassord.Name = "lblPassord"
        Me.lblPassord.Size = New System.Drawing.Size(45, 13)
        Me.lblPassord.TabIndex = 15
        Me.lblPassord.Text = "&Passord"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(146, 218)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(149, 20)
        Me.TextBox1.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(146, 244)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(149, 20)
        Me.TextBox2.TabIndex = 16
        '
        'btnLagre
        '
        Me.btnLagre.Location = New System.Drawing.Point(220, 296)
        Me.btnLagre.Name = "btnLagre"
        Me.btnLagre.Size = New System.Drawing.Size(75, 23)
        Me.btnLagre.TabIndex = 17
        Me.btnLagre.Text = "&Lagre"
        Me.btnLagre.UseVisualStyleBackColor = True
        '
        'frmBrukerbehandling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 331)
        Me.Controls.Add(Me.btnLagre)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblPassord)
        Me.Controls.Add(Me.lblBrukernavn)
        Me.Controls.Add(Me.DateTimePicker1)
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
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBrukernavn As System.Windows.Forms.Label
    Friend WithEvents lblPassord As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnLagre As System.Windows.Forms.Button
End Class
