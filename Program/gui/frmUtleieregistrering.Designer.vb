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
        Me.txtKundeSkonr = New System.Windows.Forms.TextBox()
        Me.scKundeButtons = New System.Windows.Forms.SplitContainer()
        Me.btnKundeEndre = New System.Windows.Forms.Button()
        Me.btnKundeOpprett = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblKundeSkonr = New System.Windows.Forms.Label()
        Me.lblKundeAdresse = New System.Windows.Forms.Label()
        Me.txtKundeAdresse = New System.Windows.Forms.TextBox()
        Me.txtKundeVekt = New System.Windows.Forms.TextBox()
        Me.lblKundeNavn = New System.Windows.Forms.Label()
        Me.lblKundeHoyde = New System.Windows.Forms.Label()
        Me.lblKundeVekt = New System.Windows.Forms.Label()
        Me.txtKundeHoyde = New System.Windows.Forms.TextBox()
        Me.dtpTil = New System.Windows.Forms.DateTimePicker()
        Me.dtpFra = New System.Windows.Forms.DateTimePicker()
        Me.lblTil = New System.Windows.Forms.Label()
        Me.lblFra = New System.Windows.Forms.Label()
        Me.gbProdukt = New System.Windows.Forms.GroupBox()
        Me.lbProdukt = New System.Windows.Forms.ListBox()
        Me.scProduktButtons = New System.Windows.Forms.SplitContainer()
        Me.btnProduktFjern = New System.Windows.Forms.Button()
        Me.btnProduktLeggTil = New System.Windows.Forms.Button()
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scMain.Panel1.SuspendLayout()
        Me.scMain.Panel2.SuspendLayout()
        Me.scMain.SuspendLayout()
        Me.gbKunde.SuspendLayout()
        CType(Me.scKundeButtons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scKundeButtons.Panel1.SuspendLayout()
        Me.scKundeButtons.Panel2.SuspendLayout()
        Me.scKundeButtons.SuspendLayout()
        Me.gbProdukt.SuspendLayout()
        CType(Me.scProduktButtons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scProduktButtons.Panel1.SuspendLayout()
        Me.scProduktButtons.Panel2.SuspendLayout()
        Me.scProduktButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'scMain
        '
        Me.scMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.scMain.Size = New System.Drawing.Size(660, 560)
        Me.scMain.SplitterDistance = 327
        Me.scMain.TabIndex = 0
        Me.scMain.TabStop = False
        '
        'gbKunde
        '
        Me.gbKunde.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbKunde.Controls.Add(Me.txtKundeSkonr)
        Me.gbKunde.Controls.Add(Me.scKundeButtons)
        Me.gbKunde.Controls.Add(Me.ComboBox1)
        Me.gbKunde.Controls.Add(Me.lblKundeSkonr)
        Me.gbKunde.Controls.Add(Me.lblKundeAdresse)
        Me.gbKunde.Controls.Add(Me.txtKundeAdresse)
        Me.gbKunde.Controls.Add(Me.txtKundeVekt)
        Me.gbKunde.Controls.Add(Me.lblKundeNavn)
        Me.gbKunde.Controls.Add(Me.lblKundeHoyde)
        Me.gbKunde.Controls.Add(Me.lblKundeVekt)
        Me.gbKunde.Controls.Add(Me.txtKundeHoyde)
        Me.gbKunde.Location = New System.Drawing.Point(12, 88)
        Me.gbKunde.Name = "gbKunde"
        Me.gbKunde.Size = New System.Drawing.Size(302, 212)
        Me.gbKunde.TabIndex = 8
        Me.gbKunde.TabStop = False
        Me.gbKunde.Text = "Kunde"
        '
        'txtKundeSkonr
        '
        Me.txtKundeSkonr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKundeSkonr.Enabled = False
        Me.txtKundeSkonr.Location = New System.Drawing.Point(94, 145)
        Me.txtKundeSkonr.Name = "txtKundeSkonr"
        Me.txtKundeSkonr.Size = New System.Drawing.Size(91, 20)
        Me.txtKundeSkonr.TabIndex = 13
        '
        'scKundeButtons
        '
        Me.scKundeButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.scKundeButtons.Location = New System.Drawing.Point(3, 182)
        Me.scKundeButtons.Name = "scKundeButtons"
        '
        'scKundeButtons.Panel1
        '
        Me.scKundeButtons.Panel1.Controls.Add(Me.btnKundeEndre)
        '
        'scKundeButtons.Panel2
        '
        Me.scKundeButtons.Panel2.Controls.Add(Me.btnKundeOpprett)
        Me.scKundeButtons.Size = New System.Drawing.Size(296, 27)
        Me.scKundeButtons.SplitterDistance = 147
        Me.scKundeButtons.TabIndex = 0
        Me.scKundeButtons.TabStop = False
        '
        'btnKundeEndre
        '
        Me.btnKundeEndre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnKundeEndre.Location = New System.Drawing.Point(0, 0)
        Me.btnKundeEndre.Name = "btnKundeEndre"
        Me.btnKundeEndre.Size = New System.Drawing.Size(147, 27)
        Me.btnKundeEndre.TabIndex = 14
        Me.btnKundeEndre.Text = "&Endre"
        Me.btnKundeEndre.UseVisualStyleBackColor = True
        '
        'btnKundeOpprett
        '
        Me.btnKundeOpprett.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnKundeOpprett.Location = New System.Drawing.Point(0, 0)
        Me.btnKundeOpprett.Name = "btnKundeOpprett"
        Me.btnKundeOpprett.Size = New System.Drawing.Size(145, 27)
        Me.btnKundeOpprett.TabIndex = 15
        Me.btnKundeOpprett.Text = "&Opprett ny"
        Me.btnKundeOpprett.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(94, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(198, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'lblKundeSkonr
        '
        Me.lblKundeSkonr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKundeSkonr.AutoSize = True
        Me.lblKundeSkonr.Location = New System.Drawing.Point(21, 148)
        Me.lblKundeSkonr.Name = "lblKundeSkonr"
        Me.lblKundeSkonr.Size = New System.Drawing.Size(63, 13)
        Me.lblKundeSkonr.TabIndex = 12
        Me.lblKundeSkonr.Text = "Skonummer"
        '
        'lblKundeAdresse
        '
        Me.lblKundeAdresse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKundeAdresse.AutoSize = True
        Me.lblKundeAdresse.Location = New System.Drawing.Point(21, 49)
        Me.lblKundeAdresse.Name = "lblKundeAdresse"
        Me.lblKundeAdresse.Size = New System.Drawing.Size(45, 13)
        Me.lblKundeAdresse.TabIndex = 6
        Me.lblKundeAdresse.Text = "Adresse"
        '
        'txtKundeAdresse
        '
        Me.txtKundeAdresse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKundeAdresse.Enabled = False
        Me.txtKundeAdresse.Location = New System.Drawing.Point(94, 46)
        Me.txtKundeAdresse.Name = "txtKundeAdresse"
        Me.txtKundeAdresse.Size = New System.Drawing.Size(198, 20)
        Me.txtKundeAdresse.TabIndex = 7
        '
        'txtKundeVekt
        '
        Me.txtKundeVekt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKundeVekt.Enabled = False
        Me.txtKundeVekt.Location = New System.Drawing.Point(94, 119)
        Me.txtKundeVekt.Name = "txtKundeVekt"
        Me.txtKundeVekt.Size = New System.Drawing.Size(91, 20)
        Me.txtKundeVekt.TabIndex = 11
        '
        'lblKundeNavn
        '
        Me.lblKundeNavn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKundeNavn.AutoSize = True
        Me.lblKundeNavn.Location = New System.Drawing.Point(21, 22)
        Me.lblKundeNavn.Name = "lblKundeNavn"
        Me.lblKundeNavn.Size = New System.Drawing.Size(33, 13)
        Me.lblKundeNavn.TabIndex = 4
        Me.lblKundeNavn.Text = "&Navn"
        '
        'lblKundeHoyde
        '
        Me.lblKundeHoyde.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKundeHoyde.AutoSize = True
        Me.lblKundeHoyde.Location = New System.Drawing.Point(21, 96)
        Me.lblKundeHoyde.Name = "lblKundeHoyde"
        Me.lblKundeHoyde.Size = New System.Drawing.Size(38, 13)
        Me.lblKundeHoyde.TabIndex = 8
        Me.lblKundeHoyde.Text = "Høyde"
        '
        'lblKundeVekt
        '
        Me.lblKundeVekt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKundeVekt.AutoSize = True
        Me.lblKundeVekt.Location = New System.Drawing.Point(21, 122)
        Me.lblKundeVekt.Name = "lblKundeVekt"
        Me.lblKundeVekt.Size = New System.Drawing.Size(29, 13)
        Me.lblKundeVekt.TabIndex = 10
        Me.lblKundeVekt.Text = "Vekt"
        '
        'txtKundeHoyde
        '
        Me.txtKundeHoyde.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKundeHoyde.Enabled = False
        Me.txtKundeHoyde.Location = New System.Drawing.Point(94, 93)
        Me.txtKundeHoyde.Name = "txtKundeHoyde"
        Me.txtKundeHoyde.Size = New System.Drawing.Size(91, 20)
        Me.txtKundeHoyde.TabIndex = 9
        '
        'dtpTil
        '
        Me.dtpTil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpTil.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpTil.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTil.Location = New System.Drawing.Point(106, 36)
        Me.dtpTil.Name = "dtpTil"
        Me.dtpTil.Size = New System.Drawing.Size(208, 20)
        Me.dtpTil.TabIndex = 3
        '
        'dtpFra
        '
        Me.dtpFra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFra.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpFra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFra.Location = New System.Drawing.Point(106, 10)
        Me.dtpFra.Name = "dtpFra"
        Me.dtpFra.Size = New System.Drawing.Size(208, 20)
        Me.dtpFra.TabIndex = 1
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
        Me.lblTil.TabIndex = 2
        Me.lblTil.Text = "&Til"
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
        Me.lblFra.TabIndex = 0
        Me.lblFra.Text = "&Fra"
        '
        'gbProdukt
        '
        Me.gbProdukt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbProdukt.Controls.Add(Me.lbProdukt)
        Me.gbProdukt.Controls.Add(Me.scProduktButtons)
        Me.gbProdukt.Location = New System.Drawing.Point(12, 6)
        Me.gbProdukt.Name = "gbProdukt"
        Me.gbProdukt.Size = New System.Drawing.Size(304, 294)
        Me.gbProdukt.TabIndex = 6
        Me.gbProdukt.TabStop = False
        Me.gbProdukt.Text = "Produkt"
        '
        'lbProdukt
        '
        Me.lbProdukt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbProdukt.FormattingEnabled = True
        Me.lbProdukt.Location = New System.Drawing.Point(6, 19)
        Me.lbProdukt.Name = "lbProdukt"
        Me.lbProdukt.Size = New System.Drawing.Size(292, 238)
        Me.lbProdukt.TabIndex = 16
        '
        'scProduktButtons
        '
        Me.scProduktButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.scProduktButtons.Location = New System.Drawing.Point(3, 264)
        Me.scProduktButtons.Name = "scProduktButtons"
        '
        'scProduktButtons.Panel1
        '
        Me.scProduktButtons.Panel1.Controls.Add(Me.btnProduktFjern)
        '
        'scProduktButtons.Panel2
        '
        Me.scProduktButtons.Panel2.Controls.Add(Me.btnProduktLeggTil)
        Me.scProduktButtons.Size = New System.Drawing.Size(298, 27)
        Me.scProduktButtons.SplitterDistance = 147
        Me.scProduktButtons.TabIndex = 1
        Me.scProduktButtons.TabStop = False
        '
        'btnProduktFjern
        '
        Me.btnProduktFjern.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProduktFjern.Location = New System.Drawing.Point(0, 0)
        Me.btnProduktFjern.Name = "btnProduktFjern"
        Me.btnProduktFjern.Size = New System.Drawing.Size(147, 27)
        Me.btnProduktFjern.TabIndex = 17
        Me.btnProduktFjern.Text = "&Fjern"
        Me.btnProduktFjern.UseVisualStyleBackColor = True
        '
        'btnProduktLeggTil
        '
        Me.btnProduktLeggTil.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProduktLeggTil.Location = New System.Drawing.Point(0, 0)
        Me.btnProduktLeggTil.Name = "btnProduktLeggTil"
        Me.btnProduktLeggTil.Size = New System.Drawing.Size(147, 27)
        Me.btnProduktLeggTil.TabIndex = 18
        Me.btnProduktLeggTil.Text = "&Legg til"
        Me.btnProduktLeggTil.UseVisualStyleBackColor = True
        '
        'frmUtleieregistrering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 560)
        Me.Controls.Add(Me.scMain)
        Me.Name = "frmUtleieregistrering"
        Me.Text = "Utleieregistrering"
        Me.scMain.Panel1.ResumeLayout(False)
        Me.scMain.Panel1.PerformLayout()
        Me.scMain.Panel2.ResumeLayout(False)
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMain.ResumeLayout(False)
        Me.gbKunde.ResumeLayout(False)
        Me.gbKunde.PerformLayout()
        Me.scKundeButtons.Panel1.ResumeLayout(False)
        Me.scKundeButtons.Panel2.ResumeLayout(False)
        CType(Me.scKundeButtons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scKundeButtons.ResumeLayout(False)
        Me.gbProdukt.ResumeLayout(False)
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
    Friend WithEvents scKundeButtons As System.Windows.Forms.SplitContainer
    Friend WithEvents btnKundeEndre As System.Windows.Forms.Button
    Friend WithEvents btnKundeOpprett As System.Windows.Forms.Button
    Friend WithEvents gbProdukt As System.Windows.Forms.GroupBox
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
    Friend WithEvents lbProdukt As System.Windows.Forms.ListBox
    Friend WithEvents scProduktButtons As System.Windows.Forms.SplitContainer
    Friend WithEvents btnProduktFjern As System.Windows.Forms.Button
    Friend WithEvents btnProduktLeggTil As System.Windows.Forms.Button
End Class
