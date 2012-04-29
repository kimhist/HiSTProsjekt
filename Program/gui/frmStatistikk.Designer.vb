<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatistikk
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.rdbUke = New System.Windows.Forms.RadioButton()
        Me.rdbMaaned = New System.Windows.Forms.RadioButton()
        Me.rdbAar = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cbValg = New System.Windows.Forms.ComboBox()
        Me.lblVelgStatisikk = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdbUke
        '
        Me.rdbUke.AutoSize = True
        Me.rdbUke.Location = New System.Drawing.Point(343, 296)
        Me.rdbUke.Name = "rdbUke"
        Me.rdbUke.Size = New System.Drawing.Size(45, 17)
        Me.rdbUke.TabIndex = 0
        Me.rdbUke.TabStop = True
        Me.rdbUke.Text = "Uke"
        Me.rdbUke.UseVisualStyleBackColor = True
        '
        'rdbMaaned
        '
        Me.rdbMaaned.AutoCheck = False
        Me.rdbMaaned.AutoSize = True
        Me.rdbMaaned.Location = New System.Drawing.Point(402, 296)
        Me.rdbMaaned.Name = "rdbMaaned"
        Me.rdbMaaned.Size = New System.Drawing.Size(58, 17)
        Me.rdbMaaned.TabIndex = 1
        Me.rdbMaaned.TabStop = True
        Me.rdbMaaned.Text = "Måned"
        Me.rdbMaaned.UseVisualStyleBackColor = True
        '
        'rdbAar
        '
        Me.rdbAar.AutoCheck = False
        Me.rdbAar.AutoSize = True
        Me.rdbAar.Location = New System.Drawing.Point(476, 296)
        Me.rdbAar.Name = "rdbAar"
        Me.rdbAar.Size = New System.Drawing.Size(35, 17)
        Me.rdbAar.TabIndex = 2
        Me.rdbAar.TabStop = True
        Me.rdbAar.Text = "År"
        Me.rdbAar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Chart1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(553, 272)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Statistikk"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(3, 16)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(547, 253)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'cbValg
        '
        Me.cbValg.FormattingEnabled = True
        Me.cbValg.Items.AddRange(New Object() {"Utleie", "Avanse"})
        Me.cbValg.Location = New System.Drawing.Point(128, 290)
        Me.cbValg.Name = "cbValg"
        Me.cbValg.Size = New System.Drawing.Size(121, 21)
        Me.cbValg.TabIndex = 5
        '
        'lblVelgStatisikk
        '
        Me.lblVelgStatisikk.AutoSize = True
        Me.lblVelgStatisikk.Location = New System.Drawing.Point(50, 296)
        Me.lblVelgStatisikk.Name = "lblVelgStatisikk"
        Me.lblVelgStatisikk.Size = New System.Drawing.Size(72, 13)
        Me.lblVelgStatisikk.TabIndex = 6
        Me.lblVelgStatisikk.Text = "Velg statistikk"
        '
        'frmStatistikk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 323)
        Me.Controls.Add(Me.lblVelgStatisikk)
        Me.Controls.Add(Me.cbValg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rdbAar)
        Me.Controls.Add(Me.rdbMaaned)
        Me.Controls.Add(Me.rdbUke)
        Me.Name = "frmStatistikk"
        Me.Text = "Statistikk"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdbUke As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMaaned As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAar As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbValg As System.Windows.Forms.ComboBox
    Friend WithEvents lblVelgStatisikk As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
