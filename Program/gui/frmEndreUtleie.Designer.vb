<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEndreUtleie
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
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblFra = New System.Windows.Forms.Label()
        Me.lblTil = New System.Windows.Forms.Label()
        Me.lblKunde = New System.Windows.Forms.Label()
        Me.dtpTil = New System.Windows.Forms.DateTimePicker()
        Me.dtpFra = New System.Windows.Forms.DateTimePicker()
        Me.txtKunde = New System.Windows.Forms.TextBox()
        Me.btnEndre = New System.Windows.Forms.Button()
        Me.cbProduktId = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblId
        '
        Me.lblId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(15, 15)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(16, 13)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "&Id"
        '
        'lblFra
        '
        Me.lblFra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFra.AutoSize = True
        Me.lblFra.Location = New System.Drawing.Point(15, 61)
        Me.lblFra.Name = "lblFra"
        Me.lblFra.Size = New System.Drawing.Size(22, 13)
        Me.lblFra.TabIndex = 2
        Me.lblFra.Text = "Fra"
        '
        'lblTil
        '
        Me.lblTil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTil.AutoSize = True
        Me.lblTil.Location = New System.Drawing.Point(15, 87)
        Me.lblTil.Name = "lblTil"
        Me.lblTil.Size = New System.Drawing.Size(18, 13)
        Me.lblTil.TabIndex = 3
        Me.lblTil.Text = "Til"
        '
        'lblKunde
        '
        Me.lblKunde.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKunde.AutoSize = True
        Me.lblKunde.Location = New System.Drawing.Point(15, 111)
        Me.lblKunde.Name = "lblKunde"
        Me.lblKunde.Size = New System.Drawing.Size(38, 13)
        Me.lblKunde.TabIndex = 4
        Me.lblKunde.Text = "Kunde"
        '
        'dtpTil
        '
        Me.dtpTil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpTil.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpTil.Enabled = False
        Me.dtpTil.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTil.Location = New System.Drawing.Point(59, 81)
        Me.dtpTil.Name = "dtpTil"
        Me.dtpTil.Size = New System.Drawing.Size(208, 20)
        Me.dtpTil.TabIndex = 6
        '
        'dtpFra
        '
        Me.dtpFra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFra.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpFra.Enabled = False
        Me.dtpFra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFra.Location = New System.Drawing.Point(59, 55)
        Me.dtpFra.Name = "dtpFra"
        Me.dtpFra.Size = New System.Drawing.Size(208, 20)
        Me.dtpFra.TabIndex = 5
        '
        'txtKunde
        '
        Me.txtKunde.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKunde.Enabled = False
        Me.txtKunde.Location = New System.Drawing.Point(59, 108)
        Me.txtKunde.Name = "txtKunde"
        Me.txtKunde.Size = New System.Drawing.Size(208, 20)
        Me.txtKunde.TabIndex = 7
        '
        'btnEndre
        '
        Me.btnEndre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEndre.Location = New System.Drawing.Point(192, 144)
        Me.btnEndre.Name = "btnEndre"
        Me.btnEndre.Size = New System.Drawing.Size(75, 23)
        Me.btnEndre.TabIndex = 8
        Me.btnEndre.Text = "&Endre"
        Me.btnEndre.UseVisualStyleBackColor = True
        '
        'cbProduktId
        '
        Me.cbProduktId.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbProduktId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbProduktId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProduktId.FormattingEnabled = True
        Me.cbProduktId.Location = New System.Drawing.Point(59, 12)
        Me.cbProduktId.Name = "cbProduktId"
        Me.cbProduktId.Size = New System.Drawing.Size(208, 21)
        Me.cbProduktId.TabIndex = 9
        '
        'frmEndreUtleie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 179)
        Me.Controls.Add(Me.cbProduktId)
        Me.Controls.Add(Me.btnEndre)
        Me.Controls.Add(Me.txtKunde)
        Me.Controls.Add(Me.dtpTil)
        Me.Controls.Add(Me.dtpFra)
        Me.Controls.Add(Me.lblKunde)
        Me.Controls.Add(Me.lblTil)
        Me.Controls.Add(Me.lblFra)
        Me.Controls.Add(Me.lblId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmEndreUtleie"
        Me.Text = "Endre utleie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblFra As System.Windows.Forms.Label
    Friend WithEvents lblTil As System.Windows.Forms.Label
    Friend WithEvents lblKunde As System.Windows.Forms.Label
    Friend WithEvents dtpTil As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFra As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtKunde As System.Windows.Forms.TextBox
    Friend WithEvents btnEndre As System.Windows.Forms.Button
    Friend WithEvents cbProduktId As System.Windows.Forms.ComboBox
End Class
