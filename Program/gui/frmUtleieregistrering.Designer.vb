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
        Me.dtpTil = New System.Windows.Forms.DateTimePicker()
        Me.lblTil = New System.Windows.Forms.Label()
        Me.txtMerknader = New System.Windows.Forms.TextBox()
        Me.lblMerknader = New System.Windows.Forms.Label()
        Me.btnAvbryt = New System.Windows.Forms.Button()
        Me.gbKunde = New System.Windows.Forms.GroupBox()
        Me.txtKundeSkonr = New System.Windows.Forms.TextBox()
        Me.scKundeButtons = New System.Windows.Forms.SplitContainer()
        Me.btnKundeEndre = New System.Windows.Forms.Button()
        Me.btnKundeOpprett = New System.Windows.Forms.Button()
        Me.cbKundeNavn = New System.Windows.Forms.ComboBox()
        Me.lblKundeSkonr = New System.Windows.Forms.Label()
        Me.lblKundeAdresse = New System.Windows.Forms.Label()
        Me.txtKundeAdresse = New System.Windows.Forms.TextBox()
        Me.txtKundeVekt = New System.Windows.Forms.TextBox()
        Me.lblKundeNavn = New System.Windows.Forms.Label()
        Me.lblKundeHoyde = New System.Windows.Forms.Label()
        Me.lblKundeVekt = New System.Windows.Forms.Label()
        Me.txtKundeHoyde = New System.Windows.Forms.TextBox()
        Me.dtpFra = New System.Windows.Forms.DateTimePicker()
        Me.lblFra = New System.Windows.Forms.Label()
        Me.btnLagre = New System.Windows.Forms.Button()
        Me.gbProdukt = New System.Windows.Forms.GroupBox()
        Me.lvProdukt = New System.Windows.Forms.ListView()
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
        Me.scMain.Panel1.Controls.Add(Me.dtpTil)
        Me.scMain.Panel1.Controls.Add(Me.lblTil)
        Me.scMain.Panel1.Controls.Add(Me.txtMerknader)
        Me.scMain.Panel1.Controls.Add(Me.lblMerknader)
        Me.scMain.Panel1.Controls.Add(Me.btnAvbryt)
        Me.scMain.Panel1.Controls.Add(Me.gbKunde)
        Me.scMain.Panel1.Controls.Add(Me.dtpFra)
        Me.scMain.Panel1.Controls.Add(Me.lblFra)
        Me.scMain.Panel1MinSize = 300
        '
        'scMain.Panel2
        '
        Me.scMain.Panel2.Controls.Add(Me.btnLagre)
        Me.scMain.Panel2.Controls.Add(Me.gbProdukt)
        Me.scMain.Panel2MinSize = 300
        Me.scMain.Size = New System.Drawing.Size(660, 386)
        Me.scMain.SplitterDistance = 327
        Me.scMain.TabIndex = 0
        Me.scMain.TabStop = False
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
        'lblTil
        '
        Me.lblTil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTil.AutoSize = True
        Me.lblTil.Location = New System.Drawing.Point(15, 41)
        Me.lblTil.Name = "lblTil"
        Me.lblTil.Size = New System.Drawing.Size(18, 13)
        Me.lblTil.TabIndex = 2
        Me.lblTil.Text = "&Til"
        '
        'txtMerknader
        '
        Me.txtMerknader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMerknader.Location = New System.Drawing.Point(106, 62)
        Me.txtMerknader.Name = "txtMerknader"
        Me.txtMerknader.Size = New System.Drawing.Size(208, 20)
        Me.txtMerknader.TabIndex = 5
        '
        'lblMerknader
        '
        Me.lblMerknader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMerknader.AutoSize = True
        Me.lblMerknader.Location = New System.Drawing.Point(15, 65)
        Me.lblMerknader.Name = "lblMerknader"
        Me.lblMerknader.Size = New System.Drawing.Size(58, 13)
        Me.lblMerknader.TabIndex = 4
        Me.lblMerknader.Text = "&Merknader"
        '
        'btnAvbryt
        '
        Me.btnAvbryt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAvbryt.Image = Global.Program.My.Resources.Resources.cancel
        Me.btnAvbryt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAvbryt.Location = New System.Drawing.Point(12, 350)
        Me.btnAvbryt.Name = "btnAvbryt"
        Me.btnAvbryt.Size = New System.Drawing.Size(59, 23)
        Me.btnAvbryt.TabIndex = 19
        Me.btnAvbryt.Text = "A&vbryt"
        Me.btnAvbryt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAvbryt.UseVisualStyleBackColor = True
        '
        'gbKunde
        '
        Me.gbKunde.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbKunde.Controls.Add(Me.txtKundeSkonr)
        Me.gbKunde.Controls.Add(Me.scKundeButtons)
        Me.gbKunde.Controls.Add(Me.cbKundeNavn)
        Me.gbKunde.Controls.Add(Me.lblKundeSkonr)
        Me.gbKunde.Controls.Add(Me.lblKundeAdresse)
        Me.gbKunde.Controls.Add(Me.txtKundeAdresse)
        Me.gbKunde.Controls.Add(Me.txtKundeVekt)
        Me.gbKunde.Controls.Add(Me.lblKundeNavn)
        Me.gbKunde.Controls.Add(Me.lblKundeHoyde)
        Me.gbKunde.Controls.Add(Me.lblKundeVekt)
        Me.gbKunde.Controls.Add(Me.txtKundeHoyde)
        Me.gbKunde.Location = New System.Drawing.Point(12, 115)
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
        Me.scKundeButtons.TabIndex = 14
        Me.scKundeButtons.TabStop = False
        '
        'btnKundeEndre
        '
        Me.btnKundeEndre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnKundeEndre.Location = New System.Drawing.Point(0, 0)
        Me.btnKundeEndre.Name = "btnKundeEndre"
        Me.btnKundeEndre.Size = New System.Drawing.Size(147, 27)
        Me.btnKundeEndre.TabIndex = 9
        Me.btnKundeEndre.Text = "&Endre"
        Me.btnKundeEndre.UseVisualStyleBackColor = True
        '
        'btnKundeOpprett
        '
        Me.btnKundeOpprett.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnKundeOpprett.Location = New System.Drawing.Point(0, 0)
        Me.btnKundeOpprett.Name = "btnKundeOpprett"
        Me.btnKundeOpprett.Size = New System.Drawing.Size(145, 27)
        Me.btnKundeOpprett.TabIndex = 10
        Me.btnKundeOpprett.Text = "&Opprett ny"
        Me.btnKundeOpprett.UseVisualStyleBackColor = True
        '
        'cbKundeNavn
        '
        Me.cbKundeNavn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbKundeNavn.FormattingEnabled = True
        Me.cbKundeNavn.Location = New System.Drawing.Point(94, 19)
        Me.cbKundeNavn.Name = "cbKundeNavn"
        Me.cbKundeNavn.Size = New System.Drawing.Size(198, 21)
        Me.cbKundeNavn.TabIndex = 7
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
        Me.lblKundeAdresse.TabIndex = 8
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
        Me.txtKundeAdresse.TabIndex = 9
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
        Me.lblKundeNavn.TabIndex = 6
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
        'lblFra
        '
        Me.lblFra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFra.AutoSize = True
        Me.lblFra.Location = New System.Drawing.Point(15, 15)
        Me.lblFra.Name = "lblFra"
        Me.lblFra.Size = New System.Drawing.Size(22, 13)
        Me.lblFra.TabIndex = 0
        Me.lblFra.Text = "&Fra"
        '
        'btnLagre
        '
        Me.btnLagre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLagre.Image = Global.Program.My.Resources.Resources.confirm
        Me.btnLagre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLagre.Location = New System.Drawing.Point(258, 350)
        Me.btnLagre.Name = "btnLagre"
        Me.btnLagre.Size = New System.Drawing.Size(58, 23)
        Me.btnLagre.TabIndex = 20
        Me.btnLagre.Text = "&Lagre"
        Me.btnLagre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLagre.UseVisualStyleBackColor = True
        '
        'gbProdukt
        '
        Me.gbProdukt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbProdukt.Controls.Add(Me.lvProdukt)
        Me.gbProdukt.Controls.Add(Me.scProduktButtons)
        Me.gbProdukt.Location = New System.Drawing.Point(12, 6)
        Me.gbProdukt.Name = "gbProdukt"
        Me.gbProdukt.Size = New System.Drawing.Size(304, 321)
        Me.gbProdukt.TabIndex = 6
        Me.gbProdukt.TabStop = False
        Me.gbProdukt.Text = "Produkt"
        '
        'lvProdukt
        '
        Me.lvProdukt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvProdukt.FullRowSelect = True
        Me.lvProdukt.GridLines = True
        Me.lvProdukt.Location = New System.Drawing.Point(3, 16)
        Me.lvProdukt.Name = "lvProdukt"
        Me.lvProdukt.Size = New System.Drawing.Size(298, 275)
        Me.lvProdukt.TabIndex = 2
        Me.lvProdukt.TabStop = False
        Me.lvProdukt.UseCompatibleStateImageBehavior = False
        Me.lvProdukt.View = System.Windows.Forms.View.Details
        '
        'scProduktButtons
        '
        Me.scProduktButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.scProduktButtons.Location = New System.Drawing.Point(3, 291)
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
        Me.ClientSize = New System.Drawing.Size(660, 386)
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
    Friend WithEvents dtpFra As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFra As System.Windows.Forms.Label
    Friend WithEvents gbKunde As System.Windows.Forms.GroupBox
    Friend WithEvents scKundeButtons As System.Windows.Forms.SplitContainer
    Friend WithEvents btnKundeEndre As System.Windows.Forms.Button
    Friend WithEvents btnKundeOpprett As System.Windows.Forms.Button
    Friend WithEvents gbProdukt As System.Windows.Forms.GroupBox
    Friend WithEvents txtKundeAdresse As System.Windows.Forms.TextBox
    Friend WithEvents lblKundeAdresse As System.Windows.Forms.Label
    Friend WithEvents cbKundeNavn As System.Windows.Forms.ComboBox
    Friend WithEvents lblKundeNavn As System.Windows.Forms.Label
    Friend WithEvents txtKundeVekt As System.Windows.Forms.TextBox
    Friend WithEvents lblKundeVekt As System.Windows.Forms.Label
    Friend WithEvents txtKundeHoyde As System.Windows.Forms.TextBox
    Friend WithEvents lblKundeHoyde As System.Windows.Forms.Label
    Friend WithEvents txtKundeSkonr As System.Windows.Forms.TextBox
    Friend WithEvents lblKundeSkonr As System.Windows.Forms.Label
    Friend WithEvents scProduktButtons As System.Windows.Forms.SplitContainer
    Friend WithEvents btnProduktFjern As System.Windows.Forms.Button
    Friend WithEvents btnProduktLeggTil As System.Windows.Forms.Button
    Friend WithEvents btnLagre As System.Windows.Forms.Button
    Friend WithEvents btnAvbryt As System.Windows.Forms.Button
    Friend WithEvents txtMerknader As System.Windows.Forms.TextBox
    Friend WithEvents lblMerknader As System.Windows.Forms.Label
    Friend WithEvents lvProdukt As System.Windows.Forms.ListView
    Friend WithEvents dtpTil As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTil As System.Windows.Forms.Label
End Class
