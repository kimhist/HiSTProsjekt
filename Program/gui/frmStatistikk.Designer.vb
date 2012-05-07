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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatistikk))
        Me.tcStatistics = New System.Windows.Forms.TabControl()
        Me.tpProsentfordeling = New System.Windows.Forms.TabPage()
        Me.dtpTil = New System.Windows.Forms.DateTimePicker()
        Me.lblTil = New System.Windows.Forms.Label()
        Me.lblFra = New System.Windows.Forms.Label()
        Me.dtpFra = New System.Windows.Forms.DateTimePicker()
        Me.chProsentfordeling = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.msMenu = New System.Windows.Forms.MenuStrip()
        Me.tpAvanse = New System.Windows.Forms.TabPage()
        Me.chAvanse = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tcStatistics.SuspendLayout()
        Me.tpProsentfordeling.SuspendLayout()
        CType(Me.chProsentfordeling, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAvanse.SuspendLayout()
        CType(Me.chAvanse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcStatistics
        '
        Me.tcStatistics.Controls.Add(Me.tpProsentfordeling)
        Me.tcStatistics.Controls.Add(Me.tpAvanse)
        Me.tcStatistics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcStatistics.Location = New System.Drawing.Point(0, 0)
        Me.tcStatistics.Name = "tcStatistics"
        Me.tcStatistics.SelectedIndex = 0
        Me.tcStatistics.Size = New System.Drawing.Size(577, 323)
        Me.tcStatistics.TabIndex = 0
        '
        'tpProsentfordeling
        '
        Me.tpProsentfordeling.Controls.Add(Me.dtpTil)
        Me.tpProsentfordeling.Controls.Add(Me.lblTil)
        Me.tpProsentfordeling.Controls.Add(Me.lblFra)
        Me.tpProsentfordeling.Controls.Add(Me.dtpFra)
        Me.tpProsentfordeling.Controls.Add(Me.chProsentfordeling)
        Me.tpProsentfordeling.Controls.Add(Me.msMenu)
        Me.tpProsentfordeling.Location = New System.Drawing.Point(4, 22)
        Me.tpProsentfordeling.Name = "tpProsentfordeling"
        Me.tpProsentfordeling.Padding = New System.Windows.Forms.Padding(3)
        Me.tpProsentfordeling.Size = New System.Drawing.Size(569, 297)
        Me.tpProsentfordeling.TabIndex = 0
        Me.tpProsentfordeling.Text = "Prosentfordeling av produkt"
        Me.tpProsentfordeling.UseVisualStyleBackColor = True
        '
        'dtpTil
        '
        Me.dtpTil.CustomFormat = "yyyy-MM-dd"
        Me.dtpTil.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTil.Location = New System.Drawing.Point(261, 3)
        Me.dtpTil.Name = "dtpTil"
        Me.dtpTil.Size = New System.Drawing.Size(137, 20)
        Me.dtpTil.TabIndex = 5
        '
        'lblTil
        '
        Me.lblTil.AutoSize = True
        Me.lblTil.Location = New System.Drawing.Point(222, 6)
        Me.lblTil.Name = "lblTil"
        Me.lblTil.Size = New System.Drawing.Size(18, 13)
        Me.lblTil.TabIndex = 4
        Me.lblTil.Text = "Til"
        '
        'lblFra
        '
        Me.lblFra.AutoSize = True
        Me.lblFra.Location = New System.Drawing.Point(3, 6)
        Me.lblFra.Name = "lblFra"
        Me.lblFra.Size = New System.Drawing.Size(58, 13)
        Me.lblFra.TabIndex = 3
        Me.lblFra.Text = "Periode fra"
        '
        'dtpFra
        '
        Me.dtpFra.CustomFormat = "yyyy-MM-dd"
        Me.dtpFra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFra.Location = New System.Drawing.Point(67, 3)
        Me.dtpFra.Name = "dtpFra"
        Me.dtpFra.Size = New System.Drawing.Size(135, 20)
        Me.dtpFra.TabIndex = 2
        '
        'chProsentfordeling
        '
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Name = "ChartArea2"
        Me.chProsentfordeling.ChartAreas.Add(ChartArea1)
        Me.chProsentfordeling.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.chProsentfordeling.Legends.Add(Legend1)
        Me.chProsentfordeling.Location = New System.Drawing.Point(3, 27)
        Me.chProsentfordeling.Name = "chProsentfordeling"
        Me.chProsentfordeling.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.ChartArea = "ChartArea2"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.CustomProperties = "PieDrawingStyle=SoftEdge"
        Series1.Legend = "Legend1"
        Series1.Name = "BarChart"
        Me.chProsentfordeling.Series.Add(Series1)
        Me.chProsentfordeling.Size = New System.Drawing.Size(563, 267)
        Me.chProsentfordeling.TabIndex = 0
        Me.chProsentfordeling.Text = "Chart1"
        '
        'msMenu
        '
        Me.msMenu.Location = New System.Drawing.Point(3, 3)
        Me.msMenu.Name = "msMenu"
        Me.msMenu.Size = New System.Drawing.Size(563, 24)
        Me.msMenu.TabIndex = 1
        Me.msMenu.Text = "MenuStrip1"
        '
        'tpAvanse
        '
        Me.tpAvanse.Controls.Add(Me.chAvanse)
        Me.tpAvanse.Location = New System.Drawing.Point(4, 22)
        Me.tpAvanse.Name = "tpAvanse"
        Me.tpAvanse.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAvanse.Size = New System.Drawing.Size(569, 297)
        Me.tpAvanse.TabIndex = 1
        Me.tpAvanse.Text = "Selger avanse"
        Me.tpAvanse.UseVisualStyleBackColor = True
        '
        'chAvanse
        '
        ChartArea2.AxisX.MajorGrid.Enabled = False
        ChartArea2.Name = "ChartArea1"
        Me.chAvanse.ChartAreas.Add(ChartArea2)
        Me.chAvanse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chAvanse.Location = New System.Drawing.Point(3, 3)
        Me.chAvanse.Name = "chAvanse"
        Me.chAvanse.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series2.ChartArea = "ChartArea1"
        Series2.CustomProperties = "DrawingStyle=LightToDark"
        Series2.Name = "Series1"
        Series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[String]
        Me.chAvanse.Series.Add(Series2)
        Me.chAvanse.Size = New System.Drawing.Size(563, 291)
        Me.chAvanse.TabIndex = 0
        Me.chAvanse.Text = "Chart1"
        '
        'frmStatistikk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 323)
        Me.Controls.Add(Me.tcStatistics)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msMenu
        Me.Name = "frmStatistikk"
        Me.Text = "Statistikk"
        Me.tcStatistics.ResumeLayout(False)
        Me.tpProsentfordeling.ResumeLayout(False)
        Me.tpProsentfordeling.PerformLayout()
        CType(Me.chProsentfordeling, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpAvanse.ResumeLayout(False)
        CType(Me.chAvanse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcStatistics As System.Windows.Forms.TabControl
    Friend WithEvents tpProsentfordeling As System.Windows.Forms.TabPage
    Friend WithEvents tpAvanse As System.Windows.Forms.TabPage
    Friend WithEvents chProsentfordeling As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents dtpFra As System.Windows.Forms.DateTimePicker
    Friend WithEvents msMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents dtpTil As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTil As System.Windows.Forms.Label
    Friend WithEvents lblFra As System.Windows.Forms.Label
    Friend WithEvents chAvanse As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
