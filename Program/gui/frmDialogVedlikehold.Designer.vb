<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialogVedlikehold
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
        Me.lblMerknader = New System.Windows.Forms.Label()
        Me.cbUtAvDrift = New System.Windows.Forms.CheckBox()
        Me.txtMerknader = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMerknader
        '
        Me.lblMerknader.AutoSize = True
        Me.lblMerknader.Location = New System.Drawing.Point(15, 15)
        Me.lblMerknader.Name = "lblMerknader"
        Me.lblMerknader.Size = New System.Drawing.Size(58, 13)
        Me.lblMerknader.TabIndex = 0
        Me.lblMerknader.Text = "&Merknader"
        '
        'cbUtAvDrift
        '
        Me.cbUtAvDrift.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbUtAvDrift.Location = New System.Drawing.Point(14, 60)
        Me.cbUtAvDrift.Name = "cbUtAvDrift"
        Me.cbUtAvDrift.Size = New System.Drawing.Size(91, 24)
        Me.cbUtAvDrift.TabIndex = 2
        Me.cbUtAvDrift.Text = "Ute av &drift"
        Me.cbUtAvDrift.UseVisualStyleBackColor = True
        '
        'txtMerknader
        '
        Me.txtMerknader.Location = New System.Drawing.Point(90, 12)
        Me.txtMerknader.Multiline = True
        Me.txtMerknader.Name = "txtMerknader"
        Me.txtMerknader.Size = New System.Drawing.Size(174, 42)
        Me.txtMerknader.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.Image = Global.Program.My.Resources.Resources.confirm
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(227, 84)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(45, 23)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "&OK"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'frmDialogVedlikehold
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 119)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtMerknader)
        Me.Controls.Add(Me.cbUtAvDrift)
        Me.Controls.Add(Me.lblMerknader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDialogVedlikehold"
        Me.Text = "Vedlikehold"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMerknader As System.Windows.Forms.Label
    Friend WithEvents cbUtAvDrift As System.Windows.Forms.CheckBox
    Friend WithEvents txtMerknader As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
End Class
