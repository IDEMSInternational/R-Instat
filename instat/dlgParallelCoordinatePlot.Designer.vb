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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgParallelCoordinatePlot))
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
        resources.ApplyResources(Me.cmdParcoordOptions, "cmdParcoordOptions")
        Me.cmdParcoordOptions.Name = "cmdParcoordOptions"
        Me.cmdParcoordOptions.UseVisualStyleBackColor = True
        '
        'cmdPlotOptions
        '
        resources.ApplyResources(Me.cmdPlotOptions, "cmdPlotOptions")
        Me.cmdPlotOptions.Name = "cmdPlotOptions"
        Me.cmdPlotOptions.UseVisualStyleBackColor = True
        '
        'lblXVariables
        '
        resources.ApplyResources(Me.lblXVariables, "lblXVariables")
        Me.lblXVariables.Name = "lblXVariables"
        '
        'lblFactor
        '
        resources.ApplyResources(Me.lblFactor, "lblFactor")
        Me.lblFactor.Name = "lblFactor"
        '
        'lblScale
        '
        resources.ApplyResources(Me.lblScale, "lblScale")
        Me.lblScale.Name = "lblScale"
        '
        'lblTransparency
        '
        resources.ApplyResources(Me.lblTransparency, "lblTransparency")
        Me.lblTransparency.Name = "lblTransparency"
        '
        'ucrSaveGraph
        '
        resources.ApplyResources(Me.ucrSaveGraph, "ucrSaveGraph")
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        '
        'ucrNudTransparency
        '
        Me.ucrNudTransparency.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTransparency.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudTransparency, "ucrNudTransparency")
        Me.ucrNudTransparency.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTransparency.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTransparency.Name = "ucrNudTransparency"
        Me.ucrNudTransparency.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkPoints
        '
        Me.ucrChkPoints.Checked = False
        resources.ApplyResources(Me.ucrChkPoints, "ucrChkPoints")
        Me.ucrChkPoints.Name = "ucrChkPoints"
        '
        'ucrChkBoxplots
        '
        Me.ucrChkBoxplots.Checked = False
        resources.ApplyResources(Me.ucrChkBoxplots, "ucrChkBoxplots")
        Me.ucrChkBoxplots.Name = "ucrChkBoxplots"
        '
        'ucrInputScale
        '
        Me.ucrInputScale.AddQuotesIfUnrecognised = True
        Me.ucrInputScale.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputScale, "ucrInputScale")
        Me.ucrInputScale.Name = "ucrInputScale"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFactor, "ucrReceiverFactor")
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'ucrReceiverXVariables
        '
        Me.ucrReceiverXVariables.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverXVariables, "ucrReceiverXVariables")
        Me.ucrReceiverXVariables.Name = "ucrReceiverXVariables"
        Me.ucrReceiverXVariables.Selector = Nothing
        Me.ucrReceiverXVariables.strNcFilePath = ""
        Me.ucrReceiverXVariables.ucrSelector = Nothing
        '
        'ucrSelectorParallelCoordinatePlot
        '
        Me.ucrSelectorParallelCoordinatePlot.bDropUnusedFilterLevels = False
        Me.ucrSelectorParallelCoordinatePlot.bShowHiddenColumns = False
        Me.ucrSelectorParallelCoordinatePlot.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorParallelCoordinatePlot, "ucrSelectorParallelCoordinatePlot")
        Me.ucrSelectorParallelCoordinatePlot.Name = "ucrSelectorParallelCoordinatePlot"
        '
        'dlgParallelCoordinatePlot
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
