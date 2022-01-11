<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMosaicPlot
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
        Me.cmdMosaicPlotOptions = New System.Windows.Forms.Button()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.lblFillColour = New System.Windows.Forms.Label()
        Me.lblConditionFactors = New System.Windows.Forms.Label()
        Me.lblWeights = New System.Windows.Forms.Label()
        Me.lblPartitioningType = New System.Windows.Forms.Label()
        Me.ucrNudXAxisLabelsAngle = New instat.ucrNud()
        Me.ucrInputPartitioning = New instat.ucrInputComboBox()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrReceiverConditions = New instat.ucrReceiverMultiple()
        Me.ucrReceiverFill = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverMultiple()
        Me.ucrSaveMosaicPlot = New instat.ucrSave()
        Me.ucrChkXAxisLabelAngle = New instat.ucrCheck()
        Me.ucrSelectorMosaicPlot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'cmdMosaicPlotOptions
        '
        Me.cmdMosaicPlotOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMosaicPlotOptions.Location = New System.Drawing.Point(10, 196)
        Me.cmdMosaicPlotOptions.Name = "cmdMosaicPlotOptions"
        Me.cmdMosaicPlotOptions.Size = New System.Drawing.Size(149, 25)
        Me.cmdMosaicPlotOptions.TabIndex = 9
        Me.cmdMosaicPlotOptions.Tag = ""
        Me.cmdMosaicPlotOptions.Text = "Mosaic Options"
        Me.cmdMosaicPlotOptions.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(10, 227)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(149, 25)
        Me.cmdOptions.TabIndex = 10
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactors.Location = New System.Drawing.Point(282, 30)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(45, 13)
        Me.lblFactors.TabIndex = 1
        Me.lblFactors.Text = "Factors:"
        '
        'lblFillColour
        '
        Me.lblFillColour.AutoSize = True
        Me.lblFillColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFillColour.Location = New System.Drawing.Point(282, 160)
        Me.lblFillColour.Name = "lblFillColour"
        Me.lblFillColour.Size = New System.Drawing.Size(103, 13)
        Me.lblFillColour.TabIndex = 3
        Me.lblFillColour.Text = "Fill Colour (Optional):"
        '
        'lblConditionFactors
        '
        Me.lblConditionFactors.AutoSize = True
        Me.lblConditionFactors.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConditionFactors.Location = New System.Drawing.Point(282, 207)
        Me.lblConditionFactors.Name = "lblConditionFactors"
        Me.lblConditionFactors.Size = New System.Drawing.Size(140, 13)
        Me.lblConditionFactors.TabIndex = 5
        Me.lblConditionFactors.Text = "Condition Factors (Optional):"
        '
        'lblWeights
        '
        Me.lblWeights.AutoSize = True
        Me.lblWeights.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWeights.Location = New System.Drawing.Point(282, 336)
        Me.lblWeights.Name = "lblWeights"
        Me.lblWeights.Size = New System.Drawing.Size(97, 13)
        Me.lblWeights.TabIndex = 7
        Me.lblWeights.Text = "Weights (Optional):"
        '
        'lblPartitioningType
        '
        Me.lblPartitioningType.AutoSize = True
        Me.lblPartitioningType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPartitioningType.Location = New System.Drawing.Point(10, 282)
        Me.lblPartitioningType.Name = "lblPartitioningType"
        Me.lblPartitioningType.Size = New System.Drawing.Size(62, 13)
        Me.lblPartitioningType.TabIndex = 11
        Me.lblPartitioningType.Text = "Partitioning:"
        '
        'ucrNudXAxisLabelsAngle
        '
        Me.ucrNudXAxisLabelsAngle.AutoSize = True
        Me.ucrNudXAxisLabelsAngle.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisLabelsAngle.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudXAxisLabelsAngle.Location = New System.Drawing.Point(184, 344)
        Me.ucrNudXAxisLabelsAngle.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXAxisLabelsAngle.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisLabelsAngle.Name = "ucrNudXAxisLabelsAngle"
        Me.ucrNudXAxisLabelsAngle.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudXAxisLabelsAngle.TabIndex = 15
        Me.ucrNudXAxisLabelsAngle.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputPartitioning
        '
        Me.ucrInputPartitioning.AddQuotesIfUnrecognised = True
        Me.ucrInputPartitioning.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPartitioning.GetSetSelectedIndex = -1
        Me.ucrInputPartitioning.IsReadOnly = False
        Me.ucrInputPartitioning.Location = New System.Drawing.Point(97, 282)
        Me.ucrInputPartitioning.Name = "ucrInputPartitioning"
        Me.ucrInputPartitioning.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPartitioning.TabIndex = 12
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.AutoSize = True
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(10, 312)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(224, 23)
        Me.ucrChkOmitMissing.TabIndex = 13
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.AutoSize = True
        Me.ucrReceiverWeights.frmParent = Me
        Me.ucrReceiverWeights.Location = New System.Drawing.Point(285, 352)
        Me.ucrReceiverWeights.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWeights.strNcFilePath = ""
        Me.ucrReceiverWeights.TabIndex = 8
        Me.ucrReceiverWeights.ucrSelector = Nothing
        '
        'ucrReceiverConditions
        '
        Me.ucrReceiverConditions.AutoSize = True
        Me.ucrReceiverConditions.frmParent = Me
        Me.ucrReceiverConditions.Location = New System.Drawing.Point(285, 225)
        Me.ucrReceiverConditions.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverConditions.Name = "ucrReceiverConditions"
        Me.ucrReceiverConditions.Selector = Nothing
        Me.ucrReceiverConditions.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverConditions.strNcFilePath = ""
        Me.ucrReceiverConditions.TabIndex = 6
        Me.ucrReceiverConditions.ucrSelector = Nothing
        '
        'ucrReceiverFill
        '
        Me.ucrReceiverFill.AutoSize = True
        Me.ucrReceiverFill.frmParent = Me
        Me.ucrReceiverFill.Location = New System.Drawing.Point(285, 176)
        Me.ucrReceiverFill.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFill.Name = "ucrReceiverFill"
        Me.ucrReceiverFill.Selector = Nothing
        Me.ucrReceiverFill.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFill.strNcFilePath = ""
        Me.ucrReceiverFill.TabIndex = 4
        Me.ucrReceiverFill.ucrSelector = Nothing
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.AutoSize = True
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(285, 48)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 2
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrSaveMosaicPlot
        '
        Me.ucrSaveMosaicPlot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveMosaicPlot.Location = New System.Drawing.Point(10, 376)
        Me.ucrSaveMosaicPlot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveMosaicPlot.Name = "ucrSaveMosaicPlot"
        Me.ucrSaveMosaicPlot.Size = New System.Drawing.Size(317, 24)
        Me.ucrSaveMosaicPlot.TabIndex = 16
        '
        'ucrChkXAxisLabelAngle
        '
        Me.ucrChkXAxisLabelAngle.AutoSize = True
        Me.ucrChkXAxisLabelAngle.Checked = False
        Me.ucrChkXAxisLabelAngle.Location = New System.Drawing.Point(10, 344)
        Me.ucrChkXAxisLabelAngle.Name = "ucrChkXAxisLabelAngle"
        Me.ucrChkXAxisLabelAngle.Size = New System.Drawing.Size(168, 23)
        Me.ucrChkXAxisLabelAngle.TabIndex = 14
        '
        'ucrSelectorMosaicPlot
        '
        Me.ucrSelectorMosaicPlot.AutoSize = True
        Me.ucrSelectorMosaicPlot.bDropUnusedFilterLevels = False
        Me.ucrSelectorMosaicPlot.bShowHiddenColumns = False
        Me.ucrSelectorMosaicPlot.bUseCurrentFilter = True
        Me.ucrSelectorMosaicPlot.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorMosaicPlot.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorMosaicPlot.Name = "ucrSelectorMosaicPlot"
        Me.ucrSelectorMosaicPlot.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorMosaicPlot.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 411)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 17
        '
        'dlgMosaicPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(452, 478)
        Me.Controls.Add(Me.ucrNudXAxisLabelsAngle)
        Me.Controls.Add(Me.ucrInputPartitioning)
        Me.Controls.Add(Me.lblPartitioningType)
        Me.Controls.Add(Me.ucrChkOmitMissing)
        Me.Controls.Add(Me.lblWeights)
        Me.Controls.Add(Me.ucrReceiverWeights)
        Me.Controls.Add(Me.lblConditionFactors)
        Me.Controls.Add(Me.ucrReceiverConditions)
        Me.Controls.Add(Me.lblFillColour)
        Me.Controls.Add(Me.ucrReceiverFill)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.ucrSaveMosaicPlot)
        Me.Controls.Add(Me.ucrChkXAxisLabelAngle)
        Me.Controls.Add(Me.cmdMosaicPlotOptions)
        Me.Controls.Add(Me.ucrSelectorMosaicPlot)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMosaicPlot"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mosaic Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSaveMosaicPlot As ucrSave
    Friend WithEvents ucrChkXAxisLabelAngle As ucrCheck
    Friend WithEvents cmdMosaicPlotOptions As Button
    Friend WithEvents ucrSelectorMosaicPlot As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverX As ucrReceiverMultiple
    Friend WithEvents lblFactors As Label
    Friend WithEvents ucrReceiverFill As ucrReceiverSingle
    Friend WithEvents lblFillColour As Label
    Friend WithEvents lblConditionFactors As Label
    Friend WithEvents ucrReceiverConditions As ucrReceiverMultiple
    Friend WithEvents lblWeights As Label
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents ucrChkOmitMissing As ucrCheck
    Friend WithEvents lblPartitioningType As Label
    Friend WithEvents ucrInputPartitioning As ucrInputComboBox
    Friend WithEvents ucrNudXAxisLabelsAngle As ucrNud
End Class
