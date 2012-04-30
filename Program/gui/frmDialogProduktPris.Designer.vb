<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialogProduktPris
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
        Me.lblPris = New System.Windows.Forms.Label()
        Me.txtPris = New System.Windows.Forms.TextBox()
        Me.lblVarighet = New System.Windows.Forms.Label()
        Me.txtVarighet = New System.Windows.Forms.TextBox()
        Me.btnAvbryt = New System.Windows.Forms.Button()
        Me.btnLagre = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPris
        '
        Me.lblPris.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPris.AutoSize = True
        Me.lblPris.Location = New System.Drawing.Point(15, 15)
        Me.lblPris.Name = "lblPris"
        Me.lblPris.Size = New System.Drawing.Size(24, 13)
        Me.lblPris.TabIndex = 0
        Me.lblPris.Text = "&Pris"
        '
        'txtPris
        '
        Me.txtPris.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPris.Location = New System.Drawing.Point(85, 12)
        Me.txtPris.Name = "txtPris"
        Me.txtPris.Size = New System.Drawing.Size(122, 20)
        Me.txtPris.TabIndex = 1
        '
        'lblVarighet
        '
        Me.lblVarighet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVarighet.AutoSize = True
        Me.lblVarighet.Location = New System.Drawing.Point(15, 41)
        Me.lblVarighet.Name = "lblVarighet"
        Me.lblVarighet.Size = New System.Drawing.Size(46, 13)
        Me.lblVarighet.TabIndex = 2
        Me.lblVarighet.Text = "&Varighet"
        '
        'txtVarighet
        '
        Me.txtVarighet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVarighet.Location = New System.Drawing.Point(85, 38)
        Me.txtVarighet.Name = "txtVarighet"
        Me.txtVarighet.Size = New System.Drawing.Size(122, 20)
        Me.txtVarighet.TabIndex = 3
        '
        'btnAvbryt
        '
        Me.btnAvbryt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAvbryt.Image = Global.Program.My.Resources.Resources.cancel
        Me.btnAvbryt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAvbryt.Location = New System.Drawing.Point(12, 78)
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
        Me.btnLagre.Location = New System.Drawing.Point(155, 78)
        Me.btnLagre.Name = "btnLagre"
        Me.btnLagre.Size = New System.Drawing.Size(64, 23)
        Me.btnLagre.TabIndex = 11
        Me.btnLagre.Text = "&Legg til"
        Me.btnLagre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLagre.UseVisualStyleBackColor = True
        '
        'frmDialogProduktPris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 107)
        Me.Controls.Add(Me.btnAvbryt)
        Me.Controls.Add(Me.btnLagre)
        Me.Controls.Add(Me.txtVarighet)
        Me.Controls.Add(Me.lblVarighet)
        Me.Controls.Add(Me.txtPris)
        Me.Controls.Add(Me.lblPris)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDialogProduktPris"
        Me.Text = "Legg til pris"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPris As System.Windows.Forms.Label
    Friend WithEvents txtPris As System.Windows.Forms.TextBox
    Friend WithEvents lblVarighet As System.Windows.Forms.Label
    Friend WithEvents txtVarighet As System.Windows.Forms.TextBox
    Friend WithEvents btnAvbryt As System.Windows.Forms.Button
    Friend WithEvents btnLagre As System.Windows.Forms.Button
End Class
