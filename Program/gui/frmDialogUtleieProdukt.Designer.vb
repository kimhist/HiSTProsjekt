<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialogUtleieProdukt
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
        Me.btnAvbryt = New System.Windows.Forms.Button()
        Me.btnIdLeggTil = New System.Windows.Forms.Button()
        Me.gbSokId = New System.Windows.Forms.GroupBox()
        Me.lblIdProduktBeskrivelse = New System.Windows.Forms.Label()
        Me.txtIdProduktBeskrivelse = New System.Windows.Forms.TextBox()
        Me.txtIdProduktNavn = New System.Windows.Forms.TextBox()
        Me.lblIdProduktNavn = New System.Windows.Forms.Label()
        Me.cbIdProduktId = New System.Windows.Forms.ComboBox()
        Me.lblIdProduktid = New System.Windows.Forms.Label()
        Me.gbSokNavn = New System.Windows.Forms.GroupBox()
        Me.lblNavnProduktBeskrivelse = New System.Windows.Forms.Label()
        Me.txtNavnProduktBeskrivelse = New System.Windows.Forms.TextBox()
        Me.btnNavnLeggTil = New System.Windows.Forms.Button()
        Me.txtNavnProduktId = New System.Windows.Forms.TextBox()
        Me.lblNavnProduktId = New System.Windows.Forms.Label()
        Me.cbNavnProduktNavn = New System.Windows.Forms.ComboBox()
        Me.lblNavnProduktNavn = New System.Windows.Forms.Label()
        Me.gbSokId.SuspendLayout()
        Me.gbSokNavn.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAvbryt
        '
        Me.btnAvbryt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAvbryt.Image = Global.Program.My.Resources.Resources.cancel
        Me.btnAvbryt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAvbryt.Location = New System.Drawing.Point(12, 354)
        Me.btnAvbryt.Name = "btnAvbryt"
        Me.btnAvbryt.Size = New System.Drawing.Size(61, 23)
        Me.btnAvbryt.TabIndex = 16
        Me.btnAvbryt.Text = "&Avbryt"
        Me.btnAvbryt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAvbryt.UseVisualStyleBackColor = True
        '
        'btnIdLeggTil
        '
        Me.btnIdLeggTil.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIdLeggTil.Image = Global.Program.My.Resources.Resources.confirm
        Me.btnIdLeggTil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIdLeggTil.Location = New System.Drawing.Point(216, 124)
        Me.btnIdLeggTil.Name = "btnIdLeggTil"
        Me.btnIdLeggTil.Size = New System.Drawing.Size(64, 23)
        Me.btnIdLeggTil.TabIndex = 15
        Me.btnIdLeggTil.Text = "L&egg til"
        Me.btnIdLeggTil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIdLeggTil.UseVisualStyleBackColor = True
        '
        'gbSokId
        '
        Me.gbSokId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbSokId.Controls.Add(Me.lblIdProduktBeskrivelse)
        Me.gbSokId.Controls.Add(Me.txtIdProduktBeskrivelse)
        Me.gbSokId.Controls.Add(Me.txtIdProduktNavn)
        Me.gbSokId.Controls.Add(Me.lblIdProduktNavn)
        Me.gbSokId.Controls.Add(Me.cbIdProduktId)
        Me.gbSokId.Controls.Add(Me.btnIdLeggTil)
        Me.gbSokId.Controls.Add(Me.lblIdProduktid)
        Me.gbSokId.Location = New System.Drawing.Point(12, 182)
        Me.gbSokId.Name = "gbSokId"
        Me.gbSokId.Size = New System.Drawing.Size(286, 153)
        Me.gbSokId.TabIndex = 8
        Me.gbSokId.TabStop = False
        Me.gbSokId.Text = "Produktsøk på id"
        '
        'lblIdProduktBeskrivelse
        '
        Me.lblIdProduktBeskrivelse.AutoSize = True
        Me.lblIdProduktBeskrivelse.Location = New System.Drawing.Point(15, 73)
        Me.lblIdProduktBeskrivelse.Name = "lblIdProduktBeskrivelse"
        Me.lblIdProduktBeskrivelse.Size = New System.Drawing.Size(61, 13)
        Me.lblIdProduktBeskrivelse.TabIndex = 13
        Me.lblIdProduktBeskrivelse.Text = "Beskrivelse"
        '
        'txtIdProduktBeskrivelse
        '
        Me.txtIdProduktBeskrivelse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdProduktBeskrivelse.Enabled = False
        Me.txtIdProduktBeskrivelse.Location = New System.Drawing.Point(96, 70)
        Me.txtIdProduktBeskrivelse.Multiline = True
        Me.txtIdProduktBeskrivelse.Name = "txtIdProduktBeskrivelse"
        Me.txtIdProduktBeskrivelse.Size = New System.Drawing.Size(184, 48)
        Me.txtIdProduktBeskrivelse.TabIndex = 14
        '
        'txtIdProduktNavn
        '
        Me.txtIdProduktNavn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdProduktNavn.Enabled = False
        Me.txtIdProduktNavn.Location = New System.Drawing.Point(96, 44)
        Me.txtIdProduktNavn.Name = "txtIdProduktNavn"
        Me.txtIdProduktNavn.Size = New System.Drawing.Size(184, 20)
        Me.txtIdProduktNavn.TabIndex = 12
        '
        'lblIdProduktNavn
        '
        Me.lblIdProduktNavn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIdProduktNavn.AutoSize = True
        Me.lblIdProduktNavn.Location = New System.Drawing.Point(15, 47)
        Me.lblIdProduktNavn.Name = "lblIdProduktNavn"
        Me.lblIdProduktNavn.Size = New System.Drawing.Size(33, 13)
        Me.lblIdProduktNavn.TabIndex = 11
        Me.lblIdProduktNavn.Text = "Navn"
        '
        'cbIdProduktId
        '
        Me.cbIdProduktId.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbIdProduktId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbIdProduktId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbIdProduktId.FormattingEnabled = True
        Me.cbIdProduktId.Location = New System.Drawing.Point(96, 17)
        Me.cbIdProduktId.Name = "cbIdProduktId"
        Me.cbIdProduktId.Size = New System.Drawing.Size(184, 21)
        Me.cbIdProduktId.TabIndex = 10
        '
        'lblIdProduktid
        '
        Me.lblIdProduktid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIdProduktid.AutoSize = True
        Me.lblIdProduktid.Location = New System.Drawing.Point(15, 20)
        Me.lblIdProduktid.Name = "lblIdProduktid"
        Me.lblIdProduktid.Size = New System.Drawing.Size(16, 13)
        Me.lblIdProduktid.TabIndex = 9
        Me.lblIdProduktid.Text = "&Id"
        '
        'gbSokNavn
        '
        Me.gbSokNavn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbSokNavn.Controls.Add(Me.lblNavnProduktBeskrivelse)
        Me.gbSokNavn.Controls.Add(Me.txtNavnProduktBeskrivelse)
        Me.gbSokNavn.Controls.Add(Me.btnNavnLeggTil)
        Me.gbSokNavn.Controls.Add(Me.txtNavnProduktId)
        Me.gbSokNavn.Controls.Add(Me.lblNavnProduktId)
        Me.gbSokNavn.Controls.Add(Me.cbNavnProduktNavn)
        Me.gbSokNavn.Controls.Add(Me.lblNavnProduktNavn)
        Me.gbSokNavn.Location = New System.Drawing.Point(12, 12)
        Me.gbSokNavn.Name = "gbSokNavn"
        Me.gbSokNavn.Size = New System.Drawing.Size(286, 152)
        Me.gbSokNavn.TabIndex = 0
        Me.gbSokNavn.TabStop = False
        Me.gbSokNavn.Text = "Produktsøk på navn"
        '
        'lblNavnProduktBeskrivelse
        '
        Me.lblNavnProduktBeskrivelse.AutoSize = True
        Me.lblNavnProduktBeskrivelse.Location = New System.Drawing.Point(15, 77)
        Me.lblNavnProduktBeskrivelse.Name = "lblNavnProduktBeskrivelse"
        Me.lblNavnProduktBeskrivelse.Size = New System.Drawing.Size(61, 13)
        Me.lblNavnProduktBeskrivelse.TabIndex = 5
        Me.lblNavnProduktBeskrivelse.Text = "Beskrivelse"
        '
        'txtNavnProduktBeskrivelse
        '
        Me.txtNavnProduktBeskrivelse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNavnProduktBeskrivelse.Enabled = False
        Me.txtNavnProduktBeskrivelse.Location = New System.Drawing.Point(96, 74)
        Me.txtNavnProduktBeskrivelse.Multiline = True
        Me.txtNavnProduktBeskrivelse.Name = "txtNavnProduktBeskrivelse"
        Me.txtNavnProduktBeskrivelse.Size = New System.Drawing.Size(184, 43)
        Me.txtNavnProduktBeskrivelse.TabIndex = 6
        '
        'btnNavnLeggTil
        '
        Me.btnNavnLeggTil.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNavnLeggTil.Image = Global.Program.My.Resources.Resources.confirm
        Me.btnNavnLeggTil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavnLeggTil.Location = New System.Drawing.Point(216, 123)
        Me.btnNavnLeggTil.Name = "btnNavnLeggTil"
        Me.btnNavnLeggTil.Size = New System.Drawing.Size(64, 23)
        Me.btnNavnLeggTil.TabIndex = 7
        Me.btnNavnLeggTil.Text = "&Legg til"
        Me.btnNavnLeggTil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNavnLeggTil.UseVisualStyleBackColor = True
        '
        'txtNavnProduktId
        '
        Me.txtNavnProduktId.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNavnProduktId.Enabled = False
        Me.txtNavnProduktId.Location = New System.Drawing.Point(96, 47)
        Me.txtNavnProduktId.Name = "txtNavnProduktId"
        Me.txtNavnProduktId.Size = New System.Drawing.Size(184, 20)
        Me.txtNavnProduktId.TabIndex = 4
        '
        'lblNavnProduktId
        '
        Me.lblNavnProduktId.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNavnProduktId.AutoSize = True
        Me.lblNavnProduktId.Location = New System.Drawing.Point(15, 50)
        Me.lblNavnProduktId.Name = "lblNavnProduktId"
        Me.lblNavnProduktId.Size = New System.Drawing.Size(16, 13)
        Me.lblNavnProduktId.TabIndex = 3
        Me.lblNavnProduktId.Text = "Id"
        '
        'cbNavnProduktNavn
        '
        Me.cbNavnProduktNavn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbNavnProduktNavn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbNavnProduktNavn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbNavnProduktNavn.FormattingEnabled = True
        Me.cbNavnProduktNavn.Location = New System.Drawing.Point(96, 20)
        Me.cbNavnProduktNavn.Name = "cbNavnProduktNavn"
        Me.cbNavnProduktNavn.Size = New System.Drawing.Size(184, 21)
        Me.cbNavnProduktNavn.TabIndex = 2
        '
        'lblNavnProduktNavn
        '
        Me.lblNavnProduktNavn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNavnProduktNavn.AutoSize = True
        Me.lblNavnProduktNavn.Location = New System.Drawing.Point(15, 23)
        Me.lblNavnProduktNavn.Name = "lblNavnProduktNavn"
        Me.lblNavnProduktNavn.Size = New System.Drawing.Size(33, 13)
        Me.lblNavnProduktNavn.TabIndex = 1
        Me.lblNavnProduktNavn.Text = "&Navn"
        '
        'frmDialogUtleieProdukt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 385)
        Me.Controls.Add(Me.gbSokId)
        Me.Controls.Add(Me.gbSokNavn)
        Me.Controls.Add(Me.btnAvbryt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmDialogUtleieProdukt"
        Me.Text = "Legg til produkt"
        Me.gbSokId.ResumeLayout(False)
        Me.gbSokId.PerformLayout()
        Me.gbSokNavn.ResumeLayout(False)
        Me.gbSokNavn.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAvbryt As System.Windows.Forms.Button
    Friend WithEvents btnIdLeggTil As System.Windows.Forms.Button
    Friend WithEvents gbSokId As System.Windows.Forms.GroupBox
    Friend WithEvents txtIdProduktNavn As System.Windows.Forms.TextBox
    Friend WithEvents lblIdProduktNavn As System.Windows.Forms.Label
    Friend WithEvents cbIdProduktId As System.Windows.Forms.ComboBox
    Friend WithEvents lblIdProduktid As System.Windows.Forms.Label
    Friend WithEvents gbSokNavn As System.Windows.Forms.GroupBox
    Friend WithEvents btnNavnLeggTil As System.Windows.Forms.Button
    Friend WithEvents txtNavnProduktId As System.Windows.Forms.TextBox
    Friend WithEvents lblNavnProduktId As System.Windows.Forms.Label
    Friend WithEvents cbNavnProduktNavn As System.Windows.Forms.ComboBox
    Friend WithEvents lblNavnProduktNavn As System.Windows.Forms.Label
    Friend WithEvents lblIdProduktBeskrivelse As System.Windows.Forms.Label
    Friend WithEvents txtIdProduktBeskrivelse As System.Windows.Forms.TextBox
    Friend WithEvents lblNavnProduktBeskrivelse As System.Windows.Forms.Label
    Friend WithEvents txtNavnProduktBeskrivelse As System.Windows.Forms.TextBox
End Class
