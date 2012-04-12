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
        Me.lblNavn = New System.Windows.Forms.Label()
        Me.lblBeskrivelse = New System.Windows.Forms.Label()
        Me.lblGruppe = New System.Windows.Forms.Label()
        Me.txtNavn = New System.Windows.Forms.TextBox()
        Me.txtBeskrivelse = New System.Windows.Forms.TextBox()
        Me.cbProduktgruppe = New System.Windows.Forms.ComboBox()
        Me.gbPriser = New System.Windows.Forms.GroupBox()
        Me.lbPriser = New System.Windows.Forms.ListBox()
        Me.btnLagre = New System.Windows.Forms.Button()
        Me.btnAvbryt = New System.Windows.Forms.Button()
        Me.gbPriser.SuspendLayout()
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
        Me.lblNavn.Text = "Navn"
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
        Me.lblBeskrivelse.Text = "Beskrivelse"
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
        Me.lblGruppe.Text = "Produktgruppe"
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
        Me.gbPriser.Controls.Add(Me.lbPriser)
        Me.gbPriser.Location = New System.Drawing.Point(18, 108)
        Me.gbPriser.Name = "gbPriser"
        Me.gbPriser.Size = New System.Drawing.Size(250, 108)
        Me.gbPriser.TabIndex = 6
        Me.gbPriser.TabStop = False
        Me.gbPriser.Text = "Priser"
        '
        'lbPriser
        '
        Me.lbPriser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbPriser.FormattingEnabled = True
        Me.lbPriser.Location = New System.Drawing.Point(3, 16)
        Me.lbPriser.Name = "lbPriser"
        Me.lbPriser.Size = New System.Drawing.Size(244, 89)
        Me.lbPriser.TabIndex = 7
        '
        'btnLagre
        '
        Me.btnLagre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLagre.Location = New System.Drawing.Point(193, 235)
        Me.btnLagre.Name = "btnLagre"
        Me.btnLagre.Size = New System.Drawing.Size(75, 23)
        Me.btnLagre.TabIndex = 9
        Me.btnLagre.Text = "Lagre"
        Me.btnLagre.UseVisualStyleBackColor = True
        '
        'btnAvbryt
        '
        Me.btnAvbryt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAvbryt.Location = New System.Drawing.Point(15, 235)
        Me.btnAvbryt.Name = "btnAvbryt"
        Me.btnAvbryt.Size = New System.Drawing.Size(75, 23)
        Me.btnAvbryt.TabIndex = 8
        Me.btnAvbryt.Text = "Avbryt"
        Me.btnAvbryt.UseVisualStyleBackColor = True
        '
        'frmProduktRegistrering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 267)
        Me.Controls.Add(Me.btnAvbryt)
        Me.Controls.Add(Me.btnLagre)
        Me.Controls.Add(Me.gbPriser)
        Me.Controls.Add(Me.cbProduktgruppe)
        Me.Controls.Add(Me.txtBeskrivelse)
        Me.Controls.Add(Me.txtNavn)
        Me.Controls.Add(Me.lblGruppe)
        Me.Controls.Add(Me.lblBeskrivelse)
        Me.Controls.Add(Me.lblNavn)
        Me.Name = "frmProduktRegistrering"
        Me.Text = "Produktregistrering"
        Me.gbPriser.ResumeLayout(False)
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
    Friend WithEvents lbPriser As System.Windows.Forms.ListBox
    Friend WithEvents btnLagre As System.Windows.Forms.Button
    Friend WithEvents btnAvbryt As System.Windows.Forms.Button
End Class
