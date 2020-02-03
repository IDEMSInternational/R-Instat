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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgMosaicPlot))
        Me.ucrSaveMosaicPlot = New instat.ucrSave()
        Me.ucrChkXAxisLabelAngle = New instat.ucrCheck()
        Me.cmdMosaicPlotOptions = New System.Windows.Forms.Button()
        Me.ucrSelectorMosaicPlot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverX = New instat.ucrReceiverMultiple()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.ucrReceiverFill = New instat.ucrReceiverSingle()
        Me.lblFillColour = New System.Windows.Forms.Label()
        Me.lblConditionFactors = New System.Windows.Forms.Label()
        Me.ucrReceiverConditions = New instat.ucrReceiverMultiple()
        Me.lblWeights = New System.Windows.Forms.Label()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.lblPartitioningType = New System.Windows.Forms.Label()
        Me.ucrInputPartitioning = New instat.ucrInputComboBox()
        Me.ucrNudXAxisLabelsAngle = New instat.ucrNud()
        Me.SuspendLayout()
        '
        'ucrSaveMosaicPlot
        '
        resources.ApplyResources(Me.ucrSaveMosaicPlot, "ucrSaveMosaicPlot")
        Me.ucrSaveMosaicPlot.Name = "ucrSaveMosaicPlot"
        '
        'ucrChkXAxisLabelAngle
        '
        Me.ucrChkXAxisLabelAngle.Checked = False
        resources.ApplyResources(Me.ucrChkXAxisLabelAngle, "ucrChkXAxisLabelAngle")
        Me.ucrChkXAxisLabelAngle.Name = "ucrChkXAxisLabelAngle"
        '
        'cmdMosaicPlotOptions
        '
        resources.ApplyResources(Me.cmdMosaicPlotOptions, "cmdMosaicPlotOptions")
        Me.cmdMosaicPlotOptions.Name = "cmdMosaicPlotOptions"
        Me.cmdMosaicPlotOptions.Tag = ""
        Me.cmdMosaicPlotOptions.UseVisualStyleBackColor = True
        '
        'ucrSelectorMosaicPlot
        '
        Me.ucrSelectorMosaicPlot.bDropUnusedFilterLevels = False
        Me.ucrSelectorMosaicPlot.bShowHiddenColumns = False
        Me.ucrSelectorMosaicPlot.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorMosaicPlot, "ucrSelectorMosaicPlot")
        Me.ucrSelectorMosaicPlot.Name = "ucrSelectorMosaicPlot"
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverX, "ucrReceiverX")
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'lblFactors
        '
        resources.ApplyResources(Me.lblFactors, "lblFactors")
        Me.lblFactors.Name = "lblFactors"
        '
        'ucrReceiverFill
        '
        Me.ucrReceiverFill.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFill, "ucrReceiverFill")
        Me.ucrReceiverFill.Name = "ucrReceiverFill"
        Me.ucrReceiverFill.Selector = Nothing
        Me.ucrReceiverFill.strNcFilePath = ""
        Me.ucrReceiverFill.ucrSelector = Nothing
        '
        'lblFillColour
        '
        resources.ApplyResources(Me.lblFillColour, "lblFillColour")
        Me.lblFillColour.Name = "lblFillColour"
        '
        'lblConditionFactors
        '
        resources.ApplyResources(Me.lblConditionFactors, "lblConditionFactors")
        Me.lblConditionFactors.Name = "lblConditionFactors"
        '
        'ucrReceiverConditions
        '
        Me.ucrReceiverConditions.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverConditions, "ucrReceiverConditions")
        Me.ucrReceiverConditions.Name = "ucrReceiverConditions"
        Me.ucrReceiverConditions.Selector = Nothing
        Me.ucrReceiverConditions.strNcFilePath = ""
        Me.ucrReceiverConditions.ucrSelector = Nothing
        '
        'lblWeights
        '
        resources.ApplyResources(Me.lblWeights, "lblWeights")
        Me.lblWeights.Name = "lblWeights"
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverWeights, "ucrReceiverWeights")
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.strNcFilePath = ""
        Me.ucrReceiverWeights.ucrSelector = Nothing
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.Checked = False
        resources.ApplyResources(Me.ucrChkOmitMissing, "ucrChkOmitMissing")
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        '
        'lblPartitioningType
        '
        resources.ApplyResources(Me.lblPartitioningType, "lblPartitioningType")
        Me.lblPartitioningType.Name = "lblPartitioningType"
        '
        'ucrInputPartitioning
        '
        Me.ucrInputPartitioning.AddQuotesIfUnrecognised = True
        Me.ucrInputPartitioning.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPartitioning, "ucrInputPartitioning")
        Me.ucrInputPartitioning.Name = "ucrInputPartitioning"
        '
        'ucrNudXAxisLabelsAngle
        '
        Me.ucrNudXAxisLabelsAngle.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisLabelsAngle.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudXAxisLabelsAngle, "ucrNudXAxisLabelsAngle")
        Me.ucrNudXAxisLabelsAngle.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXAxisLabelsAngle.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisLabelsAngle.Name = "ucrNudXAxisLabelsAngle"
        Me.ucrNudXAxisLabelsAngle.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgMosaicPlot
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
