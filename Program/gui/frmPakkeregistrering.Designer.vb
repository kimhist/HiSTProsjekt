<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPakkeregistrering
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPakkeregistrering))
        Me.btnAvbryt = New System.Windows.Forms.Button()
        Me.btnLagre = New System.Windows.Forms.Button()
        Me.gbProdukt = New System.Windows.Forms.GroupBox()
        Me.scProduktButtons = New System.Windows.Forms.SplitContainer()
        Me.btnProduktFjern = New System.Windows.Forms.Button()
        Me.btnProduktLeggTil = New System.Windows.Forms.Button()
        Me.lbProdukt = New System.Windows.Forms.ListBox()
        Me.txtRabatt = New System.Windows.Forms.TextBox()
        Me.txtNavn = New System.Windows.Forms.TextBox()
        Me.lblBeskrivelse = New System.Windows.Forms.Label()
        Me.lblRabatt = New System.Windows.Forms.Label()
        Me.lblNavn = New System.Windows.Forms.Label()
        Me.txtBeskrivelse = New System.Windows.Forms.TextBox()
        Me.gbProdukt.SuspendLayout()
        CType(Me.scProduktButtons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scProduktButtons.Panel1.SuspendLayout()
        Me.scProduktButtons.Panel2.SuspendLayout()
        Me.scProduktButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAvbryt
        '
        Me.btnAvbryt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAvbryt.Image = Global.Program.My.Resources.Resources.cancel
        Me.btnAvbryt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAvbryt.Location = New System.Drawing.Point(13, 330)
        Me.btnAvbryt.Name = "btnAvbryt"
        Me.btnAvbryt.Size = New System.Drawing.Size(61, 23)
        Me.btnAvbryt.TabIndex = 9
        Me.btnAvbryt.Text = "&Avbryt"
        Me.btnAvbryt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAvbryt.UseVisualStyleBackColor = True
        '
        'btnLagre
        '
        Me.btnLagre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLagre.Image = Global.Program.My.Resources.Resources.confirm
        Me.btnLagre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLagre.Location = New System.Drawing.Point(213, 330)
        Me.btnLagre.Name = "btnLagre"
        Me.btnLagre.Size = New System.Drawing.Size(59, 23)
        Me.btnLagre.TabIndex = 10
        Me.btnLagre.Text = "&Lagre"
        Me.btnLagre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLagre.UseVisualStyleBackColor = True
        '
        'gbProdukt
        '
        Me.gbProdukt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbProdukt.Controls.Add(Me.scProduktButtons)
        Me.gbProdukt.Controls.Add(Me.lbProdukt)
        Me.gbProdukt.Location = New System.Drawing.Point(18, 108)
        Me.gbProdukt.Name = "gbProdukt"
        Me.gbProdukt.Size = New System.Drawing.Size(250, 201)
        Me.gbProdukt.TabIndex = 6
        Me.gbProdukt.TabStop = False
        Me.gbProdukt.Text = "Produkt"
        '
        'scProduktButtons
        '
        Me.scProduktButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.scProduktButtons.Location = New System.Drawing.Point(3, 173)
        Me.scProduktButtons.Name = "scProduktButtons"
        '
        'scProduktButtons.Panel1
        '
        Me.scProduktButtons.Panel1.Controls.Add(Me.btnProduktFjern)
        '
        'scProduktButtons.Panel2
        '
        Me.scProduktButtons.Panel2.Controls.Add(Me.btnProduktLeggTil)
        Me.scProduktButtons.Size = New System.Drawing.Size(244, 25)
        Me.scProduktButtons.SplitterDistance = 122
        Me.scProduktButtons.TabIndex = 7
        Me.scProduktButtons.TabStop = False
        '
        'btnProduktFjern
        '
        Me.btnProduktFjern.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnProduktFjern.Location = New System.Drawing.Point(0, 0)
        Me.btnProduktFjern.Name = "btnProduktFjern"
        Me.btnProduktFjern.Size = New System.Drawing.Size(122, 25)
        Me.btnProduktFjern.TabIndex = 7
        Me.btnProduktFjern.Text = "&Fjern produkt"
        Me.btnProduktFjern.UseVisualStyleBackColor = True
        '
        'btnProduktLeggTil
        '
        Me.btnProduktLeggTil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnProduktLeggTil.Location = New System.Drawing.Point(0, 0)
        Me.btnProduktLeggTil.Name = "btnProduktLeggTil"
        Me.btnProduktLeggTil.Size = New System.Drawing.Size(118, 25)
        Me.btnProduktLeggTil.TabIndex = 8
        Me.btnProduktLeggTil.Text = "L&egg til produkt"
        Me.btnProduktLeggTil.UseVisualStyleBackColor = True
        '
        'lbProdukt
        '
        Me.lbProdukt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbProdukt.FormattingEnabled = True
        Me.lbProdukt.Location = New System.Drawing.Point(6, 17)
        Me.lbProdukt.Name = "lbProdukt"
        Me.lbProdukt.Size = New System.Drawing.Size(238, 147)
        Me.lbProdukt.TabIndex = 6
        '
        'txtRabatt
        '
        Me.txtRabatt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRabatt.Location = New System.Drawing.Point(122, 38)
        Me.txtRabatt.Name = "txtRabatt"
        Me.txtRabatt.Size = New System.Drawing.Size(146, 20)
        Me.txtRabatt.TabIndex = 3
        '
        'txtNavn
        '
        Me.txtNavn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNavn.Location = New System.Drawing.Point(122, 12)
        Me.txtNavn.Name = "txtNavn"
        Me.txtNavn.Size = New System.Drawing.Size(146, 20)
        Me.txtNavn.TabIndex = 1
        '
        'lblBeskrivelse
        '
        Me.lblBeskrivelse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBeskrivelse.AutoSize = True
        Me.lblBeskrivelse.Location = New System.Drawing.Point(15, 67)
        Me.lblBeskrivelse.Name = "lblBeskrivelse"
        Me.lblBeskrivelse.Size = New System.Drawing.Size(61, 13)
        Me.lblBeskrivelse.TabIndex = 4
        Me.lblBeskrivelse.Text = "&Beskrivelse"
        '
        'lblRabatt
        '
        Me.lblRabatt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRabatt.AutoSize = True
        Me.lblRabatt.Location = New System.Drawing.Point(15, 41)
        Me.lblRabatt.Name = "lblRabatt"
        Me.lblRabatt.Size = New System.Drawing.Size(39, 13)
        Me.lblRabatt.TabIndex = 2
        Me.lblRabatt.Text = "&Rabatt"
        '
        'lblNavn
        '
        Me.lblNavn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNavn.AutoSize = True
        Me.lblNavn.Location = New System.Drawing.Point(15, 15)
        Me.lblNavn.Name = "lblNavn"
        Me.lblNavn.Size = New System.Drawing.Size(33, 13)
        Me.lblNavn.TabIndex = 0
        Me.lblNavn.Text = "&Navn"
        '
        'txtBeskrivelse
        '
        Me.txtBeskrivelse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBeskrivelse.Location = New System.Drawing.Point(122, 64)
        Me.txtBeskrivelse.Name = "txtBeskrivelse"
        Me.txtBeskrivelse.Size = New System.Drawing.Size(146, 20)
        Me.txtBeskrivelse.TabIndex = 5
        '
        'frmPakkeregistrering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 362)
        Me.Controls.Add(Me.txtBeskrivelse)
        Me.Controls.Add(Me.gbProdukt)
        Me.Controls.Add(Me.btnAvbryt)
        Me.Controls.Add(Me.btnLagre)
        Me.Controls.Add(Me.txtRabatt)
        Me.Controls.Add(Me.txtNavn)
        Me.Controls.Add(Me.lblBeskrivelse)
        Me.Controls.Add(Me.lblRabatt)
        Me.Controls.Add(Me.lblNavn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPakkeregistrering"
        Me.Text = "Pakkeregistrering"
        Me.gbProdukt.ResumeLayout(False)
        Me.scProduktButtons.Panel1.ResumeLayout(False)
        Me.scProduktButtons.Panel2.ResumeLayout(False)
        CType(Me.scProduktButtons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scProduktButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAvbryt As System.Windows.Forms.Button
    Friend WithEvents btnLagre As System.Windows.Forms.Button
    Friend WithEvents gbProdukt As System.Windows.Forms.GroupBox
    Friend WithEvents scProduktButtons As System.Windows.Forms.SplitContainer
    Friend WithEvents btnProduktFjern As System.Windows.Forms.Button
    Friend WithEvents btnProduktLeggTil As System.Windows.Forms.Button
    Friend WithEvents lbProdukt As System.Windows.Forms.ListBox
    Friend WithEvents txtRabatt As System.Windows.Forms.TextBox
    Friend WithEvents txtNavn As System.Windows.Forms.TextBox
    Friend WithEvents lblBeskrivelse As System.Windows.Forms.Label
    Friend WithEvents lblRabatt As System.Windows.Forms.Label
    Friend WithEvents lblNavn As System.Windows.Forms.Label
    Friend WithEvents txtBeskrivelse As System.Windows.Forms.TextBox
End Class
