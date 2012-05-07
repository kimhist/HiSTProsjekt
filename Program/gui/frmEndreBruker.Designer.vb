<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEndreBruker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEndreBruker))
        Me.btnEndre = New System.Windows.Forms.Button()
        Me.lblNavn = New System.Windows.Forms.Label()
        Me.cbNavn = New System.Windows.Forms.ComboBox()
        Me.lblBrukernavn = New System.Windows.Forms.Label()
        Me.txtBrukernavn = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEndre
        '
        Me.btnEndre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEndre.Location = New System.Drawing.Point(203, 67)
        Me.btnEndre.Name = "btnEndre"
        Me.btnEndre.Size = New System.Drawing.Size(75, 23)
        Me.btnEndre.TabIndex = 4
        Me.btnEndre.Text = "&Endre"
        Me.btnEndre.UseVisualStyleBackColor = True
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
        'cbNavn
        '
        Me.cbNavn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbNavn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbNavn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbNavn.FormattingEnabled = True
        Me.cbNavn.Location = New System.Drawing.Point(102, 12)
        Me.cbNavn.Name = "cbNavn"
        Me.cbNavn.Size = New System.Drawing.Size(176, 21)
        Me.cbNavn.TabIndex = 1
        '
        'lblBrukernavn
        '
        Me.lblBrukernavn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBrukernavn.AutoSize = True
        Me.lblBrukernavn.Location = New System.Drawing.Point(15, 42)
        Me.lblBrukernavn.Name = "lblBrukernavn"
        Me.lblBrukernavn.Size = New System.Drawing.Size(62, 13)
        Me.lblBrukernavn.TabIndex = 2
        Me.lblBrukernavn.Text = "Brukernavn"
        '
        'txtBrukernavn
        '
        Me.txtBrukernavn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBrukernavn.Enabled = False
        Me.txtBrukernavn.Location = New System.Drawing.Point(102, 39)
        Me.txtBrukernavn.Name = "txtBrukernavn"
        Me.txtBrukernavn.Size = New System.Drawing.Size(176, 20)
        Me.txtBrukernavn.TabIndex = 3
        '
        'frmEndreBruker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 102)
        Me.Controls.Add(Me.txtBrukernavn)
        Me.Controls.Add(Me.lblBrukernavn)
        Me.Controls.Add(Me.cbNavn)
        Me.Controls.Add(Me.lblNavn)
        Me.Controls.Add(Me.btnEndre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmEndreBruker"
        Me.Text = "Endre bruker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEndre As System.Windows.Forms.Button
    Friend WithEvents lblNavn As System.Windows.Forms.Label
    Friend WithEvents cbNavn As System.Windows.Forms.ComboBox
    Friend WithEvents lblBrukernavn As System.Windows.Forms.Label
    Friend WithEvents txtBrukernavn As System.Windows.Forms.TextBox
End Class
