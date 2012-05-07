<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduktRegistrering
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduktRegistrering))
        Me.lblNavn = New System.Windows.Forms.Label()
        Me.lblBeskrivelse = New System.Windows.Forms.Label()
        Me.lblGruppe = New System.Windows.Forms.Label()
        Me.txtNavn = New System.Windows.Forms.TextBox()
        Me.txtBeskrivelse = New System.Windows.Forms.TextBox()
        Me.cbProduktgruppe = New System.Windows.Forms.ComboBox()
        Me.gbPriser = New System.Windows.Forms.GroupBox()
        Me.lvPriser = New System.Windows.Forms.ListView()
        Me.scPriserButtons = New System.Windows.Forms.SplitContainer()
        Me.btnPriserFjern = New System.Windows.Forms.Button()
        Me.btnPrisLeggTil = New System.Windows.Forms.Button()
        Me.cbVedlikehold = New System.Windows.Forms.CheckBox()
        Me.btnAvbryt = New System.Windows.Forms.Button()
        Me.btnLagre = New System.Windows.Forms.Button()
        Me.gbPriser.SuspendLayout()
        CType(Me.scPriserButtons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scPriserButtons.Panel1.SuspendLayout()
        Me.scPriserButtons.Panel2.SuspendLayout()
        Me.scPriserButtons.SuspendLayout()
        Me.SuspendLayout()
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
        'lblBeskrivelse
        '
        Me.lblBeskrivelse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBeskrivelse.AutoSize = True
        Me.lblBeskrivelse.Location = New System.Drawing.Point(15, 41)
        Me.lblBeskrivelse.Name = "lblBeskrivelse"
        Me.lblBeskrivelse.Size = New System.Drawing.Size(61, 13)
        Me.lblBeskrivelse.TabIndex = 2
        Me.lblBeskrivelse.Text = "&Beskrivelse"
        '
        'lblGruppe
        '
        Me.lblGruppe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGruppe.AutoSize = True
        Me.lblGruppe.Location = New System.Drawing.Point(15, 67)
        Me.lblGruppe.Name = "lblGruppe"
        Me.lblGruppe.Size = New System.Drawing.Size(77, 13)
        Me.lblGruppe.TabIndex = 4
        Me.lblGruppe.Text = "&Produktgruppe"
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
        'txtBeskrivelse
        '
        Me.txtBeskrivelse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBeskrivelse.Location = New System.Drawing.Point(122, 38)
        Me.txtBeskrivelse.Name = "txtBeskrivelse"
        Me.txtBeskrivelse.Size = New System.Drawing.Size(146, 20)
        Me.txtBeskrivelse.TabIndex = 3
        '
        'cbProduktgruppe
        '
        Me.cbProduktgruppe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbProduktgruppe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbProduktgruppe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProduktgruppe.FormattingEnabled = True
        Me.cbProduktgruppe.Location = New System.Drawing.Point(122, 67)
        Me.cbProduktgruppe.Name = "cbProduktgruppe"
        Me.cbProduktgruppe.Size = New System.Drawing.Size(146, 21)
        Me.cbProduktgruppe.TabIndex = 5
        '
        'gbPriser
        '
        Me.gbPriser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbPriser.Controls.Add(Me.lvPriser)
        Me.gbPriser.Controls.Add(Me.scPriserButtons)
        Me.gbPriser.Location = New System.Drawing.Point(18, 141)
        Me.gbPriser.Name = "gbPriser"
        Me.gbPriser.Size = New System.Drawing.Size(250, 164)
        Me.gbPriser.TabIndex = 7
        Me.gbPriser.TabStop = False
        Me.gbPriser.Text = "Priser"
        '
        'lvPriser
        '
        Me.lvPriser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvPriser.FullRowSelect = True
        Me.lvPriser.GridLines = True
        Me.lvPriser.Location = New System.Drawing.Point(3, 16)
        Me.lvPriser.Name = "lvPriser"
        Me.lvPriser.Size = New System.Drawing.Size(244, 120)
        Me.lvPriser.TabIndex = 1
        Me.lvPriser.TabStop = False
        Me.lvPriser.UseCompatibleStateImageBehavior = False
        Me.lvPriser.View = System.Windows.Forms.View.Details
        '
        'scPriserButtons
        '
        Me.scPriserButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.scPriserButtons.Location = New System.Drawing.Point(3, 136)
        Me.scPriserButtons.Name = "scPriserButtons"
        '
        'scPriserButtons.Panel1
        '
        Me.scPriserButtons.Panel1.Controls.Add(Me.btnPriserFjern)
        '
        'scPriserButtons.Panel2
        '
        Me.scPriserButtons.Panel2.Controls.Add(Me.btnPrisLeggTil)
        Me.scPriserButtons.Size = New System.Drawing.Size(244, 25)
        Me.scPriserButtons.SplitterDistance = 122
        Me.scPriserButtons.TabIndex = 0
        Me.scPriserButtons.TabStop = False
        '
        'btnPriserFjern
        '
        Me.btnPriserFjern.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPriserFjern.Location = New System.Drawing.Point(0, 0)
        Me.btnPriserFjern.Name = "btnPriserFjern"
        Me.btnPriserFjern.Size = New System.Drawing.Size(122, 25)
        Me.btnPriserFjern.TabIndex = 8
        Me.btnPriserFjern.Text = "&Fjern pris"
        Me.btnPriserFjern.UseVisualStyleBackColor = True
        '
        'btnPrisLeggTil
        '
        Me.btnPrisLeggTil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPrisLeggTil.Location = New System.Drawing.Point(0, 0)
        Me.btnPrisLeggTil.Name = "btnPrisLeggTil"
        Me.btnPrisLeggTil.Size = New System.Drawing.Size(118, 25)
        Me.btnPrisLeggTil.TabIndex = 9
        Me.btnPrisLeggTil.Text = "L&egg til pris"
        Me.btnPrisLeggTil.UseVisualStyleBackColor = True
        '
        'cbVedlikehold
        '
        Me.cbVedlikehold.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbVedlikehold.Location = New System.Drawing.Point(14, 92)
        Me.cbVedlikehold.Name = "cbVedlikehold"
        Me.cbVedlikehold.Size = New System.Drawing.Size(122, 24)
        Me.cbVedlikehold.TabIndex = 6
        Me.cbVedlikehold.Text = "Hos &vedlikehold"
        Me.cbVedlikehold.UseVisualStyleBackColor = True
        '
        'btnAvbryt
        '
        Me.btnAvbryt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAvbryt.Image = Global.Program.My.Resources.Resources.cancel
        Me.btnAvbryt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAvbryt.Location = New System.Drawing.Point(13, 324)
        Me.btnAvbryt.Name = "btnAvbryt"
        Me.btnAvbryt.Size = New System.Drawing.Size(61, 23)
        Me.btnAvbryt.TabIndex = 10
        Me.btnAvbryt.Text = "&Avbryt"
        Me.btnAvbryt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAvbryt.UseVisualStyleBackColor = True
        '
        'btnLagre
        '
        Me.btnLagre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLagre.Image = Global.Program.My.Resources.Resources.confirm
        Me.btnLagre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLagre.Location = New System.Drawing.Point(213, 324)
        Me.btnLagre.Name = "btnLagre"
        Me.btnLagre.Size = New System.Drawing.Size(59, 23)
        Me.btnLagre.TabIndex = 11
        Me.btnLagre.Text = "&Lagre"
        Me.btnLagre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLagre.UseVisualStyleBackColor = True
        '
        'frmProduktRegistrering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 356)
        Me.Controls.Add(Me.cbVedlikehold)
        Me.Controls.Add(Me.btnAvbryt)
        Me.Controls.Add(Me.btnLagre)
        Me.Controls.Add(Me.gbPriser)
        Me.Controls.Add(Me.cbProduktgruppe)
        Me.Controls.Add(Me.txtBeskrivelse)
        Me.Controls.Add(Me.txtNavn)
        Me.Controls.Add(Me.lblGruppe)
        Me.Controls.Add(Me.lblBeskrivelse)
        Me.Controls.Add(Me.lblNavn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProduktRegistrering"
        Me.Text = "Produktregistrering"
        Me.gbPriser.ResumeLayout(False)
        Me.scPriserButtons.Panel1.ResumeLayout(False)
        Me.scPriserButtons.Panel2.ResumeLayout(False)
        CType(Me.scPriserButtons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scPriserButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNavn As System.Windows.Forms.Label
    Friend WithEvents lblBeskrivelse As System.Windows.Forms.Label
    Friend WithEvents lblGruppe As System.Windows.Forms.Label
    Friend WithEvents txtNavn As System.Windows.Forms.TextBox
    Friend WithEvents txtBeskrivelse As System.Windows.Forms.TextBox
    Friend WithEvents cbProduktgruppe As System.Windows.Forms.ComboBox
    Friend WithEvents gbPriser As System.Windows.Forms.GroupBox
    Friend WithEvents btnLagre As System.Windows.Forms.Button
    Friend WithEvents btnAvbryt As System.Windows.Forms.Button
    Friend WithEvents scPriserButtons As System.Windows.Forms.SplitContainer
    Friend WithEvents btnPriserFjern As System.Windows.Forms.Button
    Friend WithEvents btnPrisLeggTil As System.Windows.Forms.Button
    Friend WithEvents lvPriser As System.Windows.Forms.ListView
    Friend WithEvents cbVedlikehold As System.Windows.Forms.CheckBox
End Class
