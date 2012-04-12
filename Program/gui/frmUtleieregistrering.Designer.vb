<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtleieregistrering
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
        Me.scMain = New System.Windows.Forms.SplitContainer()
        Me.gbKunde = New System.Windows.Forms.GroupBox()
        Me.scKunde = New System.Windows.Forms.SplitContainer()
        Me.txtKundeSkonr = New System.Windows.Forms.TextBox()
        Me.lblKundeSkonr = New System.Windows.Forms.Label()
        Me.txtKundeVekt = New System.Windows.Forms.TextBox()
        Me.lblKundeVekt = New System.Windows.Forms.Label()
        Me.txtKundeHoyde = New System.Windows.Forms.TextBox()
        Me.lblKundeHoyde = New System.Windows.Forms.Label()
        Me.txtKundeAdresse = New System.Windows.Forms.TextBox()
        Me.lblKundeAdresse = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblKundeNavn = New System.Windows.Forms.Label()
        Me.scKundeButtons = New System.Windows.Forms.SplitContainer()
        Me.btnKundeEndre = New System.Windows.Forms.Button()
        Me.btnKundeOpprett = New System.Windows.Forms.Button()
        Me.dtpTil = New System.Windows.Forms.DateTimePicker()
        Me.dtpFra = New System.Windows.Forms.DateTimePicker()
        Me.lblTil = New System.Windows.Forms.Label()
        Me.lblFra = New System.Windows.Forms.Label()
        Me.gbProdukt = New System.Windows.Forms.GroupBox()
        Me.scProdukt = New System.Windows.Forms.SplitContainer()
        Me.lbProdukt = New System.Windows.Forms.ListBox()
        Me.scProduktButtons = New System.Windows.Forms.SplitContainer()
        Me.btnProduktFjern = New System.Windows.Forms.Button()
        Me.btnProduktLeggTil = New System.Windows.Forms.Button()
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scMain.Panel1.SuspendLayout()
        Me.scMain.Panel2.SuspendLayout()
        Me.scMain.SuspendLayout()
        Me.gbKunde.SuspendLayout()
        CType(Me.scKunde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scKunde.Panel1.SuspendLayout()
        Me.scKunde.Panel2.SuspendLayout()
        Me.scKunde.SuspendLayout()
        CType(Me.scKundeButtons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scKundeButtons.Panel1.SuspendLayout()
        Me.scKundeButtons.Panel2.SuspendLayout()
        Me.scKundeButtons.SuspendLayout()
        Me.gbProdukt.SuspendLayout()
        CType(Me.scProdukt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scProdukt.Panel1.SuspendLayout()
        Me.scProdukt.Panel2.SuspendLayout()
        Me.scProdukt.SuspendLayout()
        CType(Me.scProduktButtons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scProduktButtons.Panel1.SuspendLayout()
        Me.scProduktButtons.Panel2.SuspendLayout()
        Me.scProduktButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'scMain
        '
        Me.scMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scMain.Location = New System.Drawing.Point(0, 0)
        Me.scMain.Name = "scMain"
        '
        'scMain.Panel1
        '
        Me.scMain.Panel1.Controls.Add(Me.gbKunde)
        Me.scMain.Panel1.Controls.Add(Me.dtpTil)
        Me.scMain.Panel1.Controls.Add(Me.dtpFra)
        Me.scMain.Panel1.Controls.Add(Me.lblTil)
        Me.scMain.Panel1.Controls.Add(Me.lblFra)
        Me.scMain.Panel1MinSize = 300
        '
        'scMain.Panel2
        '
        Me.scMain.Panel2.Controls.Add(Me.gbProdukt)
        Me.scMain.Panel2MinSize = 300
        Me.scMain.Size = New System.Drawing.Size(604, 590)
        Me.scMain.SplitterDistance = 300
        Me.scMain.TabIndex = 0
        '
        'gbKunde
        '
        Me.gbKunde.Controls.Add(Me.scKunde)
        Me.gbKunde.Location = New System.Drawing.Point(12, 88)
        Me.gbKunde.Name = "gbKunde"
        Me.gbKunde.Size = New System.Drawing.Size(285, 226)
        Me.gbKunde.TabIndex = 8
        Me.gbKunde.TabStop = False
        Me.gbKunde.Text = "Kunde"
        '
        'scKunde
        '
        Me.scKunde.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scKunde.Location = New System.Drawing.Point(3, 16)
        Me.scKunde.Name = "scKunde"
        Me.scKunde.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scKunde.Panel1
        '
        Me.scKunde.Panel1.Controls.Add(Me.txtKundeSkonr)
        Me.scKunde.Panel1.Controls.Add(Me.lblKundeSkonr)
        Me.scKunde.Panel1.Controls.Add(Me.txtKundeVekt)
        Me.scKunde.Panel1.Controls.Add(Me.lblKundeVekt)
        Me.scKunde.Panel1.Controls.Add(Me.txtKundeHoyde)
        Me.scKunde.Panel1.Controls.Add(Me.lblKundeHoyde)
        Me.scKunde.Panel1.Controls.Add(Me.txtKundeAdresse)
        Me.scKunde.Panel1.Controls.Add(Me.lblKundeAdresse)
        Me.scKunde.Panel1.Controls.Add(Me.ComboBox1)
        Me.scKunde.Panel1.Controls.Add(Me.lblKundeNavn)
        '
        'scKunde.Panel2
        '
        Me.scKunde.Panel2.Controls.Add(Me.scKundeButtons)
        Me.scKunde.Size = New System.Drawing.Size(279, 207)
        Me.scKunde.SplitterDistance = 173
        Me.scKunde.TabIndex = 0
        '
        'txtKundeSkonr
        '
        Me.txtKundeSkonr.Enabled = False
        Me.txtKundeSkonr.Location = New System.Drawing.Point(91, 139)
        Me.txtKundeSkonr.Name = "txtKundeSkonr"
        Me.txtKundeSkonr.Size = New System.Drawing.Size(86, 20)
        Me.txtKundeSkonr.TabIndex = 9
        '
        'lblKundeSkonr
        '
        Me.lblKundeSkonr.AutoSize = True
        Me.lblKundeSkonr.Location = New System.Drawing.Point(18, 142)
        Me.lblKundeSkonr.Name = "lblKundeSkonr"
        Me.lblKundeSkonr.Size = New System.Drawing.Size(63, 13)
        Me.lblKundeSkonr.TabIndex = 8
        Me.lblKundeSkonr.Text = "Skonummer"
        '
        'txtKundeVekt
        '
        Me.txtKundeVekt.Enabled = False
        Me.txtKundeVekt.Location = New System.Drawing.Point(91, 113)
        Me.txtKundeVekt.Name = "txtKundeVekt"
        Me.txtKundeVekt.Size = New System.Drawing.Size(86, 20)
        Me.txtKundeVekt.TabIndex = 7
        '
        'lblKundeVekt
        '
        Me.lblKundeVekt.AutoSize = True
        Me.lblKundeVekt.Location = New System.Drawing.Point(18, 116)
        Me.lblKundeVekt.Name = "lblKundeVekt"
        Me.lblKundeVekt.Size = New System.Drawing.Size(29, 13)
        Me.lblKundeVekt.TabIndex = 6
        Me.lblKundeVekt.Text = "Vekt"
        '
        'txtKundeHoyde
        '
        Me.txtKundeHoyde.Enabled = False
        Me.txtKundeHoyde.Location = New System.Drawing.Point(91, 87)
        Me.txtKundeHoyde.Name = "txtKundeHoyde"
        Me.txtKundeHoyde.Size = New System.Drawing.Size(86, 20)
        Me.txtKundeHoyde.TabIndex = 5
        '
        'lblKundeHoyde
        '
        Me.lblKundeHoyde.AutoSize = True
        Me.lblKundeHoyde.Location = New System.Drawing.Point(18, 90)
        Me.lblKundeHoyde.Name = "lblKundeHoyde"
        Me.lblKundeHoyde.Size = New System.Drawing.Size(38, 13)
        Me.lblKundeHoyde.TabIndex = 4
        Me.lblKundeHoyde.Text = "Høyde"
        '
        'txtKundeAdresse
        '
        Me.txtKundeAdresse.Enabled = False
        Me.txtKundeAdresse.Location = New System.Drawing.Point(91, 40)
        Me.txtKundeAdresse.Name = "txtKundeAdresse"
        Me.txtKundeAdresse.Size = New System.Drawing.Size(181, 20)
        Me.txtKundeAdresse.TabIndex = 3
        '
        'lblKundeAdresse
        '
        Me.lblKundeAdresse.AutoSize = True
        Me.lblKundeAdresse.Location = New System.Drawing.Point(18, 43)
        Me.lblKundeAdresse.Name = "lblKundeAdresse"
        Me.lblKundeAdresse.Size = New System.Drawing.Size(45, 13)
        Me.lblKundeAdresse.TabIndex = 2
        Me.lblKundeAdresse.Text = "Adresse"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(91, 13)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(181, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'lblKundeNavn
        '
        Me.lblKundeNavn.AutoSize = True
        Me.lblKundeNavn.Location = New System.Drawing.Point(18, 16)
        Me.lblKundeNavn.Name = "lblKundeNavn"
        Me.lblKundeNavn.Size = New System.Drawing.Size(33, 13)
        Me.lblKundeNavn.TabIndex = 0
        Me.lblKundeNavn.Text = "Navn"
        '
        'scKundeButtons
        '
        Me.scKundeButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scKundeButtons.Location = New System.Drawing.Point(0, 0)
        Me.scKundeButtons.Name = "scKundeButtons"
        '
        'scKundeButtons.Panel1
        '
        Me.scKundeButtons.Panel1.Controls.Add(Me.btnKundeEndre)
        '
        'scKundeButtons.Panel2
        '
        Me.scKundeButtons.Panel2.Controls.Add(Me.btnKundeOpprett)
        Me.scKundeButtons.Size = New System.Drawing.Size(279, 30)
        Me.scKundeButtons.SplitterDistance = 139
        Me.scKundeButtons.TabIndex = 0
        '
        'btnKundeEndre
        '
        Me.btnKundeEndre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnKundeEndre.Location = New System.Drawing.Point(0, 0)
        Me.btnKundeEndre.Name = "btnKundeEndre"
        Me.btnKundeEndre.Size = New System.Drawing.Size(139, 30)
        Me.btnKundeEndre.TabIndex = 1
        Me.btnKundeEndre.Text = "Endre"
        Me.btnKundeEndre.UseVisualStyleBackColor = True
        '
        'btnKundeOpprett
        '
        Me.btnKundeOpprett.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnKundeOpprett.Location = New System.Drawing.Point(0, 0)
        Me.btnKundeOpprett.Name = "btnKundeOpprett"
        Me.btnKundeOpprett.Size = New System.Drawing.Size(136, 30)
        Me.btnKundeOpprett.TabIndex = 1
        Me.btnKundeOpprett.Text = "Opprett"
        Me.btnKundeOpprett.UseVisualStyleBackColor = True
        '
        'dtpTil
        '
        Me.dtpTil.Location = New System.Drawing.Point(106, 36)
        Me.dtpTil.Name = "dtpTil"
        Me.dtpTil.Size = New System.Drawing.Size(181, 20)
        Me.dtpTil.TabIndex = 7
        '
        'dtpFra
        '
        Me.dtpFra.Location = New System.Drawing.Point(106, 10)
        Me.dtpFra.Name = "dtpFra"
        Me.dtpFra.Size = New System.Drawing.Size(181, 20)
        Me.dtpFra.TabIndex = 6
        '
        'lblTil
        '
        Me.lblTil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTil.AutoSize = True
        Me.lblTil.Location = New System.Drawing.Point(15, 39)
        Me.lblTil.Name = "lblTil"
        Me.lblTil.Size = New System.Drawing.Size(18, 13)
        Me.lblTil.TabIndex = 5
        Me.lblTil.Text = "Til"
        '
        'lblFra
        '
        Me.lblFra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFra.AutoSize = True
        Me.lblFra.Location = New System.Drawing.Point(15, 15)
        Me.lblFra.Name = "lblFra"
        Me.lblFra.Size = New System.Drawing.Size(22, 13)
        Me.lblFra.TabIndex = 4
        Me.lblFra.Text = "Fra"
        '
        'gbProdukt
        '
        Me.gbProdukt.Controls.Add(Me.scProdukt)
        Me.gbProdukt.Location = New System.Drawing.Point(15, 15)
        Me.gbProdukt.Name = "gbProdukt"
        Me.gbProdukt.Size = New System.Drawing.Size(269, 209)
        Me.gbProdukt.TabIndex = 6
        Me.gbProdukt.TabStop = False
        Me.gbProdukt.Text = "Produkt"
        '
        'scProdukt
        '
        Me.scProdukt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scProdukt.Location = New System.Drawing.Point(3, 16)
        Me.scProdukt.Name = "scProdukt"
        Me.scProdukt.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scProdukt.Panel1
        '
        Me.scProdukt.Panel1.Controls.Add(Me.lbProdukt)
        '
        'scProdukt.Panel2
        '
        Me.scProdukt.Panel2.Controls.Add(Me.scProduktButtons)
        Me.scProdukt.Size = New System.Drawing.Size(263, 190)
        Me.scProdukt.SplitterDistance = 159
        Me.scProdukt.TabIndex = 1
        '
        'lbProdukt
        '
        Me.lbProdukt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbProdukt.FormattingEnabled = True
        Me.lbProdukt.Location = New System.Drawing.Point(0, 0)
        Me.lbProdukt.Name = "lbProdukt"
        Me.lbProdukt.Size = New System.Drawing.Size(263, 159)
        Me.lbProdukt.TabIndex = 1
        '
        'scProduktButtons
        '
        Me.scProduktButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scProduktButtons.Location = New System.Drawing.Point(0, 0)
        Me.scProduktButtons.Name = "scProduktButtons"
        '
        'scProduktButtons.Panel1
        '
        Me.scProduktButtons.Panel1.Controls.Add(Me.btnProduktFjern)
        '
        'scProduktButtons.Panel2
        '
        Me.scProduktButtons.Panel2.Controls.Add(Me.btnProduktLeggTil)
        Me.scProduktButtons.Size = New System.Drawing.Size(263, 27)
        Me.scProduktButtons.SplitterDistance = 131
        Me.scProduktButtons.TabIndex = 1
        '
        'btnProduktFjern
        '
        Me.btnProduktFjern.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnProduktFjern.Location = New System.Drawing.Point(0, 0)
        Me.btnProduktFjern.Name = "btnProduktFjern"
        Me.btnProduktFjern.Size = New System.Drawing.Size(131, 27)
        Me.btnProduktFjern.TabIndex = 1
        Me.btnProduktFjern.Text = "Fjern"
        Me.btnProduktFjern.UseVisualStyleBackColor = True
        '
        'btnProduktLeggTil
        '
        Me.btnProduktLeggTil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnProduktLeggTil.Location = New System.Drawing.Point(0, 0)
        Me.btnProduktLeggTil.Name = "btnProduktLeggTil"
        Me.btnProduktLeggTil.Size = New System.Drawing.Size(128, 27)
        Me.btnProduktLeggTil.TabIndex = 1
        Me.btnProduktLeggTil.Text = "Legg til"
        Me.btnProduktLeggTil.UseVisualStyleBackColor = True
        '
        'frmUtleieregistrering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 590)
        Me.Controls.Add(Me.scMain)
        Me.Name = "frmUtleieregistrering"
        Me.Text = "Utleieregistrering"
        Me.scMain.Panel1.ResumeLayout(False)
        Me.scMain.Panel1.PerformLayout()
        Me.scMain.Panel2.ResumeLayout(False)
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMain.ResumeLayout(False)
        Me.gbKunde.ResumeLayout(False)
        Me.scKunde.Panel1.ResumeLayout(False)
        Me.scKunde.Panel1.PerformLayout()
        Me.scKunde.Panel2.ResumeLayout(False)
        CType(Me.scKunde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scKunde.ResumeLayout(False)
        Me.scKundeButtons.Panel1.ResumeLayout(False)
        Me.scKundeButtons.Panel2.ResumeLayout(False)
        CType(Me.scKundeButtons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scKundeButtons.ResumeLayout(False)
        Me.gbProdukt.ResumeLayout(False)
        Me.scProdukt.Panel1.ResumeLayout(False)
        Me.scProdukt.Panel2.ResumeLayout(False)
        CType(Me.scProdukt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scProdukt.ResumeLayout(False)
        Me.scProduktButtons.Panel1.ResumeLayout(False)
        Me.scProduktButtons.Panel2.ResumeLayout(False)
        CType(Me.scProduktButtons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scProduktButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents scMain As System.Windows.Forms.SplitContainer
    Friend WithEvents dtpTil As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFra As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTil As System.Windows.Forms.Label
    Friend WithEvents lblFra As System.Windows.Forms.Label
    Friend WithEvents gbKunde As System.Windows.Forms.GroupBox
    Friend WithEvents scKunde As System.Windows.Forms.SplitContainer
    Friend WithEvents scKundeButtons As System.Windows.Forms.SplitContainer
    Friend WithEvents btnKundeEndre As System.Windows.Forms.Button
    Friend WithEvents btnKundeOpprett As System.Windows.Forms.Button
    Friend WithEvents gbProdukt As System.Windows.Forms.GroupBox
    Friend WithEvents scProdukt As System.Windows.Forms.SplitContainer
    Friend WithEvents scProduktButtons As System.Windows.Forms.SplitContainer
    Friend WithEvents btnProduktFjern As System.Windows.Forms.Button
    Friend WithEvents btnProduktLeggTil As System.Windows.Forms.Button
    Friend WithEvents lbProdukt As System.Windows.Forms.ListBox
    Friend WithEvents txtKundeAdresse As System.Windows.Forms.TextBox
    Friend WithEvents lblKundeAdresse As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblKundeNavn As System.Windows.Forms.Label
    Friend WithEvents txtKundeVekt As System.Windows.Forms.TextBox
    Friend WithEvents lblKundeVekt As System.Windows.Forms.Label
    Friend WithEvents txtKundeHoyde As System.Windows.Forms.TextBox
    Friend WithEvents lblKundeHoyde As System.Windows.Forms.Label
    Friend WithEvents txtKundeSkonr As System.Windows.Forms.TextBox
    Friend WithEvents lblKundeSkonr As System.Windows.Forms.Label
End Class
