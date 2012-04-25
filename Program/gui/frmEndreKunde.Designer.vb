<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEndreKunde
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
        Me.cbNavn = New System.Windows.Forms.ComboBox()
        Me.lblNavn = New System.Windows.Forms.Label()
        Me.btnEndre = New System.Windows.Forms.Button()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cbNavn
        '
        Me.cbNavn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbNavn.FormattingEnabled = True
        Me.cbNavn.Location = New System.Drawing.Point(102, 12)
        Me.cbNavn.Name = "cbNavn"
        Me.cbNavn.Size = New System.Drawing.Size(176, 21)
        Me.cbNavn.TabIndex = 1
        '
        'lblNavn
        '
        Me.lblNavn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNavn.AutoSize = True
        Me.lblNavn.Location = New System.Drawing.Point(15, 15)
        Me.lblNavn.Name = "lblNavn"
        Me.lblNavn.Size = New System.Drawing.Size(33, 13)
        Me.lblNavn.TabIndex = 0
        Me.lblNavn.Text = "&Navn"
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
        'lblId
        '
        Me.lblId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(15, 42)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(16, 13)
        Me.lblId.TabIndex = 2
        Me.lblId.Text = "Id"
        '
        'txtId
        '
        Me.txtId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(102, 39)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(176, 20)
        Me.txtId.TabIndex = 3
        '
        'frmEndreKunde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 103)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.cbNavn)
        Me.Controls.Add(Me.lblNavn)
        Me.Controls.Add(Me.btnEndre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmEndreKunde"
        Me.Text = "Endre kunde"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbNavn As System.Windows.Forms.ComboBox
    Friend WithEvents lblNavn As System.Windows.Forms.Label
    Friend WithEvents btnEndre As System.Windows.Forms.Button
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
End Class
