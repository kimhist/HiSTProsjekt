<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabasetest
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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.btnSQL = New System.Windows.Forms.Button()
        Me.lstUtskrift = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(12, 34)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(269, 23)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Kun til bruk for å teste mot databasen"
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(49, 91)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(162, 26)
        Me.btnTest.TabIndex = 1
        Me.btnTest.Text = "Test oppkobling"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'btnSQL
        '
        Me.btnSQL.Location = New System.Drawing.Point(49, 140)
        Me.btnSQL.Name = "btnSQL"
        Me.btnSQL.Size = New System.Drawing.Size(161, 25)
        Me.btnSQL.TabIndex = 2
        Me.btnSQL.Text = "SQL TEST"
        Me.btnSQL.UseVisualStyleBackColor = True
        '
        'lstUtskrift
        '
        Me.lstUtskrift.FormattingEnabled = True
        Me.lstUtskrift.Location = New System.Drawing.Point(16, 191)
        Me.lstUtskrift.Name = "lstUtskrift"
        Me.lstUtskrift.Size = New System.Drawing.Size(265, 95)
        Me.lstUtskrift.TabIndex = 3
        '
        'frmDatabasetest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 316)
        Me.Controls.Add(Me.lstUtskrift)
        Me.Controls.Add(Me.btnSQL)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "frmDatabasetest"
        Me.Text = "frmDatabasetest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents btnSQL As System.Windows.Forms.Button
    Friend WithEvents lstUtskrift As System.Windows.Forms.ListBox
End Class
