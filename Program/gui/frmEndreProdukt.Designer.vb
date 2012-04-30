<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEndreProdukt
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
        Me.gbSokNavn = New System.Windows.Forms.GroupBox()
        Me.btnNavnSlett = New System.Windows.Forms.Button()
        Me.btnNavnEndre = New System.Windows.Forms.Button()
        Me.txtNavnProduktId = New System.Windows.Forms.TextBox()
        Me.lblNavnProduktId = New System.Windows.Forms.Label()
        Me.cbNavnProduktNavn = New System.Windows.Forms.ComboBox()
        Me.lblNavnProduktNavn = New System.Windows.Forms.Label()
        Me.gbSokId = New System.Windows.Forms.GroupBox()
        Me.btnIdSlett = New System.Windows.Forms.Button()
        Me.btnIdEndre = New System.Windows.Forms.Button()
        Me.txtIdProduktNavn = New System.Windows.Forms.TextBox()
        Me.lblIdProduktNavn = New System.Windows.Forms.Label()
        Me.cbIdProduktId = New System.Windows.Forms.ComboBox()
        Me.lblIdProduktid = New System.Windows.Forms.Label()
        Me.gbSokNavn.SuspendLayout()
        Me.gbSokId.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSokNavn
        '
        Me.gbSokNavn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbSokNavn.Controls.Add(Me.btnNavnSlett)
        Me.gbSokNavn.Controls.Add(Me.btnNavnEndre)
        Me.gbSokNavn.Controls.Add(Me.txtNavnProduktId)
        Me.gbSokNavn.Controls.Add(Me.lblNavnProduktId)
        Me.gbSokNavn.Controls.Add(Me.cbNavnProduktNavn)
        Me.gbSokNavn.Controls.Add(Me.lblNavnProduktNavn)
        Me.gbSokNavn.Location = New System.Drawing.Point(12, 12)
        Me.gbSokNavn.Name = "gbSokNavn"
        Me.gbSokNavn.Size = New System.Drawing.Size(260, 104)
        Me.gbSokNavn.TabIndex = 0
        Me.gbSokNavn.TabStop = False
        Me.gbSokNavn.Text = "Produktsøk på navn"
        '
        'btnNavnSlett
        '
        Me.btnNavnSlett.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNavnSlett.Location = New System.Drawing.Point(98, 73)
        Me.btnNavnSlett.Name = "btnNavnSlett"
        Me.btnNavnSlett.Size = New System.Drawing.Size(75, 23)
        Me.btnNavnSlett.TabIndex = 6
        Me.btnNavnSlett.Text = "&Slett"
        Me.btnNavnSlett.UseVisualStyleBackColor = True
        '
        'btnNavnEndre
        '
        Me.btnNavnEndre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNavnEndre.Location = New System.Drawing.Point(179, 73)
        Me.btnNavnEndre.Name = "btnNavnEndre"
        Me.btnNavnEndre.Size = New System.Drawing.Size(75, 23)
        Me.btnNavnEndre.TabIndex = 5
        Me.btnNavnEndre.Text = "&Endre"
        Me.btnNavnEndre.UseVisualStyleBackColor = True
        '
        'txtNavnProduktId
        '
        Me.txtNavnProduktId.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNavnProduktId.Enabled = False
        Me.txtNavnProduktId.Location = New System.Drawing.Point(96, 47)
        Me.txtNavnProduktId.Name = "txtNavnProduktId"
        Me.txtNavnProduktId.Size = New System.Drawing.Size(158, 20)
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
        Me.cbNavnProduktNavn.Size = New System.Drawing.Size(158, 21)
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
        'gbSokId
        '
        Me.gbSokId.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbSokId.Controls.Add(Me.btnIdSlett)
        Me.gbSokId.Controls.Add(Me.btnIdEndre)
        Me.gbSokId.Controls.Add(Me.txtIdProduktNavn)
        Me.gbSokId.Controls.Add(Me.lblIdProduktNavn)
        Me.gbSokId.Controls.Add(Me.cbIdProduktId)
        Me.gbSokId.Controls.Add(Me.lblIdProduktid)
        Me.gbSokId.Location = New System.Drawing.Point(12, 140)
        Me.gbSokId.Name = "gbSokId"
        Me.gbSokId.Size = New System.Drawing.Size(260, 102)
        Me.gbSokId.TabIndex = 6
        Me.gbSokId.TabStop = False
        Me.gbSokId.Text = "Produktsøk på id"
        '
        'btnIdSlett
        '
        Me.btnIdSlett.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIdSlett.Location = New System.Drawing.Point(96, 70)
        Me.btnIdSlett.Name = "btnIdSlett"
        Me.btnIdSlett.Size = New System.Drawing.Size(75, 23)
        Me.btnIdSlett.TabIndex = 12
        Me.btnIdSlett.Text = "S&lett"
        Me.btnIdSlett.UseVisualStyleBackColor = True
        '
        'btnIdEndre
        '
        Me.btnIdEndre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIdEndre.Location = New System.Drawing.Point(179, 70)
        Me.btnIdEndre.Name = "btnIdEndre"
        Me.btnIdEndre.Size = New System.Drawing.Size(75, 23)
        Me.btnIdEndre.TabIndex = 11
        Me.btnIdEndre.Text = "E&ndre"
        Me.btnIdEndre.UseVisualStyleBackColor = True
        '
        'txtIdProduktNavn
        '
        Me.txtIdProduktNavn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdProduktNavn.Enabled = False
        Me.txtIdProduktNavn.Location = New System.Drawing.Point(96, 44)
        Me.txtIdProduktNavn.Name = "txtIdProduktNavn"
        Me.txtIdProduktNavn.Size = New System.Drawing.Size(158, 20)
        Me.txtIdProduktNavn.TabIndex = 10
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
        Me.lblIdProduktNavn.TabIndex = 9
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
        Me.cbIdProduktId.Size = New System.Drawing.Size(158, 21)
        Me.cbIdProduktId.TabIndex = 8
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
        Me.lblIdProduktid.TabIndex = 7
        Me.lblIdProduktid.Text = "&Id"
        '
        'frmEndreProdukt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 255)
        Me.Controls.Add(Me.gbSokId)
        Me.Controls.Add(Me.gbSokNavn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmEndreProdukt"
        Me.Text = "Endre produkt"
        Me.gbSokNavn.ResumeLayout(False)
        Me.gbSokNavn.PerformLayout()
        Me.gbSokId.ResumeLayout(False)
        Me.gbSokId.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbSokNavn As System.Windows.Forms.GroupBox
    Friend WithEvents gbSokId As System.Windows.Forms.GroupBox
    Friend WithEvents btnIdEndre As System.Windows.Forms.Button
    Friend WithEvents txtIdProduktNavn As System.Windows.Forms.TextBox
    Friend WithEvents lblIdProduktNavn As System.Windows.Forms.Label
    Friend WithEvents cbIdProduktId As System.Windows.Forms.ComboBox
    Friend WithEvents lblIdProduktid As System.Windows.Forms.Label
    Friend WithEvents cbNavnProduktNavn As System.Windows.Forms.ComboBox
    Friend WithEvents lblNavnProduktNavn As System.Windows.Forms.Label
    Friend WithEvents btnNavnEndre As System.Windows.Forms.Button
    Friend WithEvents txtNavnProduktId As System.Windows.Forms.TextBox
    Friend WithEvents lblNavnProduktId As System.Windows.Forms.Label
    Friend WithEvents btnNavnSlett As System.Windows.Forms.Button
    Friend WithEvents btnIdSlett As System.Windows.Forms.Button
End Class
