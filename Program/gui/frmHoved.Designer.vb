﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoved
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHoved))
        Me.msMenu = New System.Windows.Forms.MenuStrip()
        Me.tsmiLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnHoved = New System.Windows.Forms.Panel()
        Me.msMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMenu
        '
        Me.msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiLogout})
        Me.msMenu.Location = New System.Drawing.Point(0, 0)
        Me.msMenu.Name = "msMenu"
        Me.msMenu.Size = New System.Drawing.Size(270, 24)
        Me.msMenu.TabIndex = 0
        Me.msMenu.Text = "Menu"
        '
        'tsmiLogout
        '
        Me.tsmiLogout.Image = CType(resources.GetObject("tsmiLogout.Image"), System.Drawing.Image)
        Me.tsmiLogout.Name = "tsmiLogout"
        Me.tsmiLogout.Size = New System.Drawing.Size(76, 20)
        Me.tsmiLogout.Text = "&Logg ut"
        '
        'pnHoved
        '
        Me.pnHoved.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnHoved.Location = New System.Drawing.Point(0, 24)
        Me.pnHoved.Name = "pnHoved"
        Me.pnHoved.Size = New System.Drawing.Size(270, 317)
        Me.pnHoved.TabIndex = 1
        '
        'frmHoved
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 341)
        Me.Controls.Add(Me.pnHoved)
        Me.Controls.Add(Me.msMenu)
        Me.MainMenuStrip = Me.msMenu
        Me.Name = "frmHoved"
        Me.Text = "AS SportUtleie"
        Me.msMenu.ResumeLayout(False)
        Me.msMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmiLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnHoved As System.Windows.Forms.Panel
End Class
