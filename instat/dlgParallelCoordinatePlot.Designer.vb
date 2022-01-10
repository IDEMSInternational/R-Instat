<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgParallelCoordinatePlot
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
        Me.cmdParcoordOptions = New System.Windows.Forms.Button()
        Me.cmdPlotOptions = New System.Windows.Forms.Button()
        Me.lblXVariables = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.lblScale = New System.Windows.Forms.Label()
        Me.lblTransparency = New System.Windows.Forms.Label()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrNudTransparency = New instat.ucrNud()
        Me.ucrChkPoints = New instat.ucrCheck()
        Me.ucrChkBoxplots = New instat.ucrCheck()
        Me.ucrInputScale = New instat.ucrInputComboBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverXVariables = New instat.ucrReceiverMultiple()
        Me.ucrSelectorParallelCoordinatePlot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'cmdParcoordOptions
        '
        Me.cmdParcoordOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdParcoordOptions.Location = New System.Drawing.Point(9, 201)
        Me.cmdParcoordOptions.Name = "cmdParcoordOptions"
        Me.cmdParcoordOptions.Size = New System.Drawing.Size(147, 23)
        Me.cmdParcoordOptions.TabIndex = 5
        Me.cmdParcoordOptions.Text = "Parcoord Options"
        Me.cmdParcoordOptions.UseVisualStyleBackColor = True
        '
        'cmdPlotOptions
        '
        Me.cmdPlotOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlotOptions.Location = New System.Drawing.Point(9, 230)
        Me.cmdPlotOptions.Name = "cmdPlotOptions"
        Me.cmdPlotOptions.Size = New System.Drawing.Size(147, 23)
        Me.cmdPlotOptions.TabIndex = 6
        Me.cmdPlotOptions.Text = "Plot Options"
        Me.cmdPlotOptions.UseVisualStyleBackColor = True
        '
        'lblXVariables
        '
        Me.lblXVariables.AutoSize = True
        Me.lblXVariables.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXVariables.Location = New System.Drawing.Point(270, 44)
        Me.lblXVariables.Name = "lblXVariables"
        Me.lblXVariables.Size = New System.Drawing.Size(63, 13)
        Me.lblXVariables.TabIndex = 1
        Me.lblXVariables.Text = "X Variables:"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactor.Location = New System.Drawing.Point(270, 186)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(88, 13)
        Me.lblFactor.TabIndex = 3
        Me.lblFactor.Text = "Factor (Optional):"
        '
        'lblScale
        '
        Me.lblScale.AutoSize = True
        Me.lblScale.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblScale.Location = New System.Drawing.Point(8, 268)
        Me.lblScale.Name = "lblScale"
        Me.lblScale.Size = New System.Drawing.Size(37, 13)
        Me.lblScale.TabIndex = 7
        Me.lblScale.Text = "Scale:"
        '
        'lblTransparency
        '
        Me.lblTransparency.AutoSize = True
        Me.lblTransparency.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTransparency.Location = New System.Drawing.Point(265, 236)
        Me.lblTransparency.Name = "lblTransparency"
        Me.lblTransparency.Size = New System.Drawing.Size(75, 13)
        Me.lblTransparency.TabIndex = 9
        Me.lblTransparency.Text = "Transparency:"
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(9, 344)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(324, 24)
        Me.ucrSaveGraph.TabIndex = 13
        '
        'ucrNudTransparency
        '
        Me.ucrNudTransparency.AutoSize = True
        Me.ucrNudTransparency.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTransparency.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTransparency.Location = New System.Drawing.Point(343, 233)
        Me.ucrNudTransparency.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTransparency.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTransparency.Name = "ucrNudTransparency"
        Me.ucrNudTransparency.Size = New System.Drawing.Size(52, 20)
        Me.ucrNudTransparency.TabIndex = 10
        Me.ucrNudTransparency.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkPoints
        '
        Me.ucrChkPoints.AutoSize = True
        Me.ucrChkPoints.Checked = False
        Me.ucrChkPoints.Location = New System.Drawing.Point(9, 318)
        Me.ucrChkPoints.Name = "ucrChkPoints"
        Me.ucrChkPoints.Size = New System.Drawing.Size(210, 23)
        Me.ucrChkPoints.TabIndex = 12
        '
        'ucrChkBoxplots
        '
        Me.ucrChkBoxplots.AutoSize = True
        Me.ucrChkBoxplots.Checked = False
        Me.ucrChkBoxplots.Location = New System.Drawing.Point(9, 292)
        Me.ucrChkBoxplots.Name = "ucrChkBoxplots"
        Me.ucrChkBoxplots.Size = New System.Drawing.Size(210, 23)
        Me.ucrChkBoxplots.TabIndex = 11
        '
        'ucrInputScale
        '
        Me.ucrInputScale.AddQuotesIfUnrecognised = True
        Me.ucrInputScale.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputScale.GetSetSelectedIndex = -1
        Me.ucrInputScale.IsReadOnly = False
        Me.ucrInputScale.Location = New System.Drawing.Point(66, 265)
        Me.ucrInputScale.Name = "ucrInputScale"
        Me.ucrInputScale.Size = New System.Drawing.Size(89, 21)
        Me.ucrInputScale.TabIndex = 8
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 370)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 14
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.AutoSize = True
        Me.ucrReceiverFactor.frmParent = Me
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(268, 201)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.TabIndex = 4
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'ucrReceiverXVariables
        '
        Me.ucrReceiverXVariables.AutoSize = True
        Me.ucrReceiverXVariables.frmParent = Me
        Me.ucrReceiverXVariables.Location = New System.Drawing.Point(268, 59)
        Me.ucrReceiverXVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverXVariables.Name = "ucrReceiverXVariables"
        Me.ucrReceiverXVariables.Selector = Nothing
        Me.ucrReceiverXVariables.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverXVariables.strNcFilePath = ""
        Me.ucrReceiverXVariables.TabIndex = 2
        Me.ucrReceiverXVariables.ucrSelector = Nothing
        '
        'ucrSelectorParallelCoordinatePlot
        '
        Me.ucrSelectorParallelCoordinatePlot.AutoSize = True
        Me.ucrSelectorParallelCoordinatePlot.bDropUnusedFilterLevels = False
        Me.ucrSelectorParallelCoordinatePlot.bShowHiddenColumns = False
        Me.ucrSelectorParallelCoordinatePlot.bUseCurrentFilter = True
        Me.ucrSelectorParallelCoordinatePlot.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorParallelCoordinatePlot.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorParallelCoordinatePlot.Name = "ucrSelectorParallelCoordinatePlot"
        Me.ucrSelectorParallelCoordinatePlot.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorParallelCoordinatePlot.TabIndex = 0
        '
        'dlgParallelCoordinatePlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(417, 430)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrNudTransparency)
        Me.Controls.Add(Me.lblTransparency)
        Me.Controls.Add(Me.ucrChkPoints)
        Me.Controls.Add(Me.ucrChkBoxplots)
        Me.Controls.Add(Me.ucrInputScale)
        Me.Controls.Add(Me.lblScale)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.lblXVariables)
        Me.Controls.Add(Me.ucrReceiverXVariables)
        Me.Controls.Add(Me.cmdPlotOptions)
        Me.Controls.Add(Me.cmdParcoordOptions)
        Me.Controls.Add(Me.ucrSelectorParallelCoordinatePlot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgParallelCoordinatePlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parallel Coordinate Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorParallelCoordinatePlot As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdParcoordOptions As Button
    Friend WithEvents cmdPlotOptions As Button
    Friend WithEvents ucrReceiverXVariables As ucrReceiverMultiple
    Friend WithEvents lblScale As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
    Friend WithEvents lblXVariables As Label
    Friend WithEvents ucrInputScale As ucrInputComboBox
    Friend WithEvents lblTransparency As Label
    Friend WithEvents ucrChkPoints As ucrCheck
    Friend WithEvents ucrChkBoxplots As ucrCheck
    Friend WithEvents ucrNudTransparency As ucrNud
    Friend WithEvents ucrSaveGraph As ucrSave
End Class
