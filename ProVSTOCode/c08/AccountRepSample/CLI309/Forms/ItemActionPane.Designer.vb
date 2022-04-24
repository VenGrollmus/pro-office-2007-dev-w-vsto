<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemActionPane
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
    Dim Corners1 As Telerik.Charting.Styles.Corners = New Telerik.Charting.Styles.Corners
    Dim ChartMargins1 As Telerik.Charting.Styles.ChartMargins = New Telerik.Charting.Styles.ChartMargins
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ItemActionPane))
    Dim Corners2 As Telerik.Charting.Styles.Corners = New Telerik.Charting.Styles.Corners
    Dim ChartMargins2 As Telerik.Charting.Styles.ChartMargins = New Telerik.Charting.Styles.ChartMargins
    Dim Corners3 As Telerik.Charting.Styles.Corners = New Telerik.Charting.Styles.Corners
    Dim ChartMargins3 As Telerik.Charting.Styles.ChartMargins = New Telerik.Charting.Styles.ChartMargins
    Dim ChartSeries1 As Telerik.Charting.ChartSeries = New Telerik.Charting.ChartSeries
    Me.KryptonHeader1 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
    Me.dgOpps = New System.Windows.Forms.DataGridView
    Me.OppsChart = New Telerik.WinControls.UI.RadChart
    CType(Me.KryptonHeader1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dgOpps, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.OppsChart, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'KryptonHeader1
    '
    Me.KryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top
    Me.KryptonHeader1.Location = New System.Drawing.Point(0, 0)
    Me.KryptonHeader1.Name = "KryptonHeader1"
    Me.KryptonHeader1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem
    Me.KryptonHeader1.Size = New System.Drawing.Size(340, 28)
    Me.KryptonHeader1.TabIndex = 0
    Me.KryptonHeader1.Text = "Related Opportunites"
    Me.KryptonHeader1.Values.Description = ""
    Me.KryptonHeader1.Values.Heading = "Related Opportunites"
    Me.KryptonHeader1.Values.Image = Nothing
    '
    'dgOpps
    '
    Me.dgOpps.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.dgOpps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgOpps.Location = New System.Drawing.Point(4, 35)
    Me.dgOpps.Name = "dgOpps"
    Me.dgOpps.Size = New System.Drawing.Size(334, 150)
    Me.dgOpps.TabIndex = 1
    '
    'OppsChart
    '
    Me.OppsChart.Appearance.Border.Color = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
    Me.OppsChart.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.Gradient
    Me.OppsChart.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(234, Byte), Integer))
    Me.OppsChart.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(137, Byte), Integer))
    Me.OppsChart.ChartTitle.Appearance.Border.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Corners1.BottomLeft = Telerik.Charting.Styles.CornerType.Round
    Corners1.BottomRight = Telerik.Charting.Styles.CornerType.Round
    Corners1.TopLeft = Telerik.Charting.Styles.CornerType.Round
    Corners1.TopRight = Telerik.Charting.Styles.CornerType.Round
    Me.OppsChart.ChartTitle.Appearance.Corners = Corners1
    ChartMargins1.Bottom = CType(resources.GetObject("ChartMargins1.Bottom"), Telerik.Charting.Styles.Unit)
    ChartMargins1.Left = CType(resources.GetObject("ChartMargins1.Left"), Telerik.Charting.Styles.Unit)
    ChartMargins1.Right = CType(resources.GetObject("ChartMargins1.Right"), Telerik.Charting.Styles.Unit)
    ChartMargins1.Top = CType(resources.GetObject("ChartMargins1.Top"), Telerik.Charting.Styles.Unit)
    Me.OppsChart.ChartTitle.Appearance.Dimensions.Margins = ChartMargins1
    Me.OppsChart.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(144, Byte), Integer))
    Me.OppsChart.ChartTitle.Appearance.Position.AlignedPosition = Telerik.Charting.Styles.AlignedPositions.Top
    Me.OppsChart.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.White
    Me.OppsChart.ChartTitle.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold)
    Me.OppsChart.ChartTitle.TextBlock.Text = "Opps by Status"
    Me.OppsChart.IntelligentLabelsEnabled = True
    Me.OppsChart.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Corners2.BottomLeft = Telerik.Charting.Styles.CornerType.Round
    Corners2.BottomRight = Telerik.Charting.Styles.CornerType.Round
    Corners2.TopLeft = Telerik.Charting.Styles.CornerType.Round
    Corners2.TopRight = Telerik.Charting.Styles.CornerType.Round
    Me.OppsChart.Legend.Appearance.Corners = Corners2
    ChartMargins2.Right = CType(resources.GetObject("ChartMargins2.Right"), Telerik.Charting.Styles.Unit)
    ChartMargins2.Top = CType(resources.GetObject("ChartMargins2.Top"), Telerik.Charting.Styles.Unit)
    Me.OppsChart.Legend.Appearance.Dimensions.Margins = ChartMargins2
    Me.OppsChart.Legend.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(144, Byte), Integer))
    Me.OppsChart.Legend.Appearance.Visible = False
    Me.OppsChart.Legend.Visible = False
    Me.OppsChart.Location = New System.Drawing.Point(3, 195)
    Me.OppsChart.Name = "OppsChart"
    Me.OppsChart.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(93, Byte), Integer))
    Corners3.BottomLeft = Telerik.Charting.Styles.CornerType.Round
    Corners3.BottomRight = Telerik.Charting.Styles.CornerType.Round
    Corners3.RoundSize = 6
    Corners3.TopLeft = Telerik.Charting.Styles.CornerType.Round
    Corners3.TopRight = Telerik.Charting.Styles.CornerType.Round
    Me.OppsChart.PlotArea.Appearance.Corners = Corners3
    ChartMargins3.Bottom = CType(resources.GetObject("ChartMargins3.Bottom"), Telerik.Charting.Styles.Unit)
    ChartMargins3.Left = CType(resources.GetObject("ChartMargins3.Left"), Telerik.Charting.Styles.Unit)
    ChartMargins3.Right = CType(resources.GetObject("ChartMargins3.Right"), Telerik.Charting.Styles.Unit)
    ChartMargins3.Top = CType(resources.GetObject("ChartMargins3.Top"), Telerik.Charting.Styles.Unit)
    Me.OppsChart.PlotArea.Appearance.Dimensions.Margins = ChartMargins3
    Me.OppsChart.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
    Me.OppsChart.PlotArea.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(186, Byte), Integer))
    Me.OppsChart.PlotArea.Appearance.SeriesPalette = "Gradient"
    Me.OppsChart.PlotArea.EmptySeriesMessage.TextBlock.Text = "No Data for Current Item"
    Me.OppsChart.PlotArea.IntelligentLabelsEnabled = True
    Me.OppsChart.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.DimGray
    Me.OppsChart.PlotArea.XAxis.Appearance.MajorGridLines.Visible = False
    Me.OppsChart.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.Black
    Me.OppsChart.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.Black
    Me.OppsChart.PlotArea.XAxis.AxisLabel.Appearance.RotationAngle = 270.0!
    Me.OppsChart.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
    Me.OppsChart.PlotArea.XAxis.MinValue = 1
    Me.OppsChart.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.Black
    Me.OppsChart.PlotArea.YAxis.Appearance.MinorGridLines.Visible = False
    Me.OppsChart.PlotArea.YAxis.Appearance.MinorTick.Visible = False
    Me.OppsChart.PlotArea.YAxis.Appearance.Visible = Telerik.Charting.Styles.ChartAxisVisibility.[False]
    Me.OppsChart.PlotArea.YAxis.AxisLabel.Appearance.RotationAngle = 0.0!
    Me.OppsChart.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
    Me.OppsChart.PlotArea.YAxis.MaxValue = 100
    Me.OppsChart.PlotArea.YAxis.Step = 10
    Me.OppsChart.PlotArea.YAxis.Visible = Telerik.Charting.Styles.ChartAxisVisibility.[False]
    Me.OppsChart.PlotArea.YAxis2.AxisLabel.Appearance.RotationAngle = 0.0!
    Me.OppsChart.PlotArea.YAxis2.AxisLabel.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
    ChartSeries1.Appearance.Border.Color = System.Drawing.Color.Black
    ChartSeries1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(178, Byte), Integer))
    ChartSeries1.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(7, Byte), Integer))
    ChartSeries1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.Black
    ChartSeries1.Name = "Status"
    Me.OppsChart.Series.AddRange(New Telerik.Charting.ChartSeries() {ChartSeries1})
    Me.OppsChart.SeriesOrientation = Telerik.Charting.ChartSeriesOrientation.Horizontal
    Me.OppsChart.SeriesPalette = "Gradient"
    Me.OppsChart.Size = New System.Drawing.Size(334, 267)
    Me.OppsChart.Skin = "Gradient"
    Me.OppsChart.TabIndex = 2
    '
    'ItemActionPane
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.OppsChart)
    Me.Controls.Add(Me.dgOpps)
    Me.Controls.Add(Me.KryptonHeader1)
    Me.Name = "ItemActionPane"
    Me.Size = New System.Drawing.Size(340, 462)
    CType(Me.KryptonHeader1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dgOpps, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.OppsChart, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents KryptonHeader1 As ComponentFactory.Krypton.Toolkit.KryptonHeader
  Friend WithEvents dgOpps As System.Windows.Forms.DataGridView
  Friend WithEvents OppsChart As Telerik.WinControls.UI.RadChart

End Class
