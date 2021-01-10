﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgConditionalQuantilePlot
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrConditionalQuantilePlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverObservations = New instat.ucrReceiverSingle()
        Me.lblObservations = New System.Windows.Forms.Label()
        Me.lblPredictions = New System.Windows.Forms.Label()
        Me.ucrReceiverPredictions = New instat.ucrReceiverSingle()
        Me.cmdPlotOptions = New System.Windows.Forms.Button()
        Me.ucrNudMinBin = New instat.ucrNud()
        Me.ucrNudBin = New instat.ucrNud()
        Me.ucrChkMinBin = New instat.ucrCheck()
        Me.ucrChkBin = New instat.ucrCheck()
        Me.ucrSavePlot = New instat.ucrSave()
        Me.lblType = New System.Windows.Forms.Label()
        Me.ucrReceiverMultipleFacet = New instat.ucrReceiverMultiple()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrChkLegendPosition = New instat.ucrCheck()
        Me.ucrNudKeyColumns = New instat.ucrNud()
        Me.ucrChkKeyColumns = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 366)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrConditionalQuantilePlotSelector
        '
        Me.ucrConditionalQuantilePlotSelector.bDropUnusedFilterLevels = False
        Me.ucrConditionalQuantilePlotSelector.bShowHiddenColumns = False
        Me.ucrConditionalQuantilePlotSelector.bUseCurrentFilter = True
        Me.ucrConditionalQuantilePlotSelector.Location = New System.Drawing.Point(9, 19)
        Me.ucrConditionalQuantilePlotSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrConditionalQuantilePlotSelector.Name = "ucrConditionalQuantilePlotSelector"
        Me.ucrConditionalQuantilePlotSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrConditionalQuantilePlotSelector.TabIndex = 4
        '
        'ucrReceiverObservations
        '
        Me.ucrReceiverObservations.frmParent = Me
        Me.ucrReceiverObservations.Location = New System.Drawing.Point(265, 68)
        Me.ucrReceiverObservations.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverObservations.Name = "ucrReceiverObservations"
        Me.ucrReceiverObservations.Selector = Nothing
        Me.ucrReceiverObservations.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverObservations.strNcFilePath = ""
        Me.ucrReceiverObservations.TabIndex = 62
        Me.ucrReceiverObservations.ucrSelector = Nothing
        '
        'lblObservations
        '
        Me.lblObservations.AutoSize = True
        Me.lblObservations.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblObservations.Location = New System.Drawing.Point(267, 50)
        Me.lblObservations.Name = "lblObservations"
        Me.lblObservations.Size = New System.Drawing.Size(72, 13)
        Me.lblObservations.TabIndex = 63
        Me.lblObservations.Text = "Observations:"
        '
        'lblPredictions
        '
        Me.lblPredictions.AutoSize = True
        Me.lblPredictions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPredictions.Location = New System.Drawing.Point(267, 112)
        Me.lblPredictions.Name = "lblPredictions"
        Me.lblPredictions.Size = New System.Drawing.Size(62, 13)
        Me.lblPredictions.TabIndex = 64
        Me.lblPredictions.Text = "Predictions:"
        '
        'ucrReceiverPredictions
        '
        Me.ucrReceiverPredictions.frmParent = Me
        Me.ucrReceiverPredictions.Location = New System.Drawing.Point(265, 131)
        Me.ucrReceiverPredictions.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPredictions.Name = "ucrReceiverPredictions"
        Me.ucrReceiverPredictions.Selector = Nothing
        Me.ucrReceiverPredictions.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPredictions.strNcFilePath = ""
        Me.ucrReceiverPredictions.TabIndex = 65
        Me.ucrReceiverPredictions.ucrSelector = Nothing
        '
        'cmdPlotOptions
        '
        Me.cmdPlotOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlotOptions.Location = New System.Drawing.Point(9, 211)
        Me.cmdPlotOptions.Name = "cmdPlotOptions"
        Me.cmdPlotOptions.Size = New System.Drawing.Size(121, 23)
        Me.cmdPlotOptions.TabIndex = 66
        Me.cmdPlotOptions.Text = "Plot Options"
        Me.cmdPlotOptions.UseVisualStyleBackColor = True
        '
        'ucrNudMinBin
        '
        Me.ucrNudMinBin.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinBin.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinBin.Location = New System.Drawing.Point(158, 243)
        Me.ucrNudMinBin.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinBin.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinBin.Name = "ucrNudMinBin"
        Me.ucrNudMinBin.Size = New System.Drawing.Size(40, 20)
        Me.ucrNudMinBin.TabIndex = 70
        Me.ucrNudMinBin.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudBin
        '
        Me.ucrNudBin.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBin.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBin.Location = New System.Drawing.Point(54, 243)
        Me.ucrNudBin.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBin.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBin.Name = "ucrNudBin"
        Me.ucrNudBin.Size = New System.Drawing.Size(40, 20)
        Me.ucrNudBin.TabIndex = 68
        Me.ucrNudBin.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkMinBin
        '
        Me.ucrChkMinBin.Checked = False
        Me.ucrChkMinBin.Location = New System.Drawing.Point(100, 245)
        Me.ucrChkMinBin.Name = "ucrChkMinBin"
        Me.ucrChkMinBin.Size = New System.Drawing.Size(77, 17)
        Me.ucrChkMinBin.TabIndex = 69
        '
        'ucrChkBin
        '
        Me.ucrChkBin.Checked = False
        Me.ucrChkBin.Location = New System.Drawing.Point(9, 245)
        Me.ucrChkBin.Name = "ucrChkBin"
        Me.ucrChkBin.Size = New System.Drawing.Size(72, 17)
        Me.ucrChkBin.TabIndex = 68
        '
        'ucrSavePlot
        '
        Me.ucrSavePlot.Location = New System.Drawing.Point(9, 337)
        Me.ucrSavePlot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSavePlot.Name = "ucrSavePlot"
        Me.ucrSavePlot.Size = New System.Drawing.Size(251, 29)
        Me.ucrSavePlot.TabIndex = 72
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblType.Location = New System.Drawing.Point(267, 176)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(100, 13)
        Me.lblType.TabIndex = 66
        Me.lblType.Text = "Facet By (Optional):"
        '
        'ucrReceiverMultipleFacet
        '
        Me.ucrReceiverMultipleFacet.frmParent = Me
        Me.ucrReceiverMultipleFacet.Location = New System.Drawing.Point(265, 196)
        Me.ucrReceiverMultipleFacet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleFacet.Name = "ucrReceiverMultipleFacet"
        Me.ucrReceiverMultipleFacet.Selector = Nothing
        Me.ucrReceiverMultipleFacet.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleFacet.strNcFilePath = ""
        Me.ucrReceiverMultipleFacet.TabIndex = 73
        Me.ucrReceiverMultipleFacet.ucrSelector = Nothing
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(108, 278)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(98, 21)
        Me.ucrInputLegendPosition.TabIndex = 75
        '
        'ucrChkLegendPosition
        '
        Me.ucrChkLegendPosition.Checked = False
        Me.ucrChkLegendPosition.Location = New System.Drawing.Point(9, 281)
        Me.ucrChkLegendPosition.Name = "ucrChkLegendPosition"
        Me.ucrChkLegendPosition.Size = New System.Drawing.Size(85, 17)
        Me.ucrChkLegendPosition.TabIndex = 74
        '
        'ucrNudKeyColumns
        '
        Me.ucrNudKeyColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudKeyColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudKeyColumns.Location = New System.Drawing.Point(108, 307)
        Me.ucrNudKeyColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudKeyColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudKeyColumns.Name = "ucrNudKeyColumns"
        Me.ucrNudKeyColumns.Size = New System.Drawing.Size(40, 20)
        Me.ucrNudKeyColumns.TabIndex = 76
        Me.ucrNudKeyColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkKeyColumns
        '
        Me.ucrChkKeyColumns.Checked = False
        Me.ucrChkKeyColumns.Location = New System.Drawing.Point(9, 310)
        Me.ucrChkKeyColumns.Name = "ucrChkKeyColumns"
        Me.ucrChkKeyColumns.Size = New System.Drawing.Size(85, 17)
        Me.ucrChkKeyColumns.TabIndex = 77
        '
        'dlgConditionalQuantilePlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 418)
        Me.Controls.Add(Me.ucrChkKeyColumns)
        Me.Controls.Add(Me.ucrNudKeyColumns)
        Me.Controls.Add(Me.ucrInputLegendPosition)
        Me.Controls.Add(Me.ucrChkLegendPosition)
        Me.Controls.Add(Me.ucrReceiverMultipleFacet)
        Me.Controls.Add(Me.ucrSavePlot)
        Me.Controls.Add(Me.ucrNudMinBin)
        Me.Controls.Add(Me.ucrNudBin)
        Me.Controls.Add(Me.cmdPlotOptions)
        Me.Controls.Add(Me.ucrChkMinBin)
        Me.Controls.Add(Me.ucrChkBin)
        Me.Controls.Add(Me.lblPredictions)
        Me.Controls.Add(Me.ucrReceiverPredictions)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.ucrReceiverObservations)
        Me.Controls.Add(Me.lblObservations)
        Me.Controls.Add(Me.ucrConditionalQuantilePlotSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgConditionalQuantilePlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conditional Quantile Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrConditionalQuantilePlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverObservations As ucrReceiverSingle
    Friend WithEvents lblObservations As Label
    Friend WithEvents lblPredictions As Label
    Friend WithEvents ucrReceiverPredictions As ucrReceiverSingle
    Friend WithEvents cmdPlotOptions As Button
    Friend WithEvents ucrChkMinBin As ucrCheck
    Friend WithEvents ucrNudMinBin As ucrNud
    Friend WithEvents ucrNudBin As ucrNud
    Friend WithEvents ucrChkBin As ucrCheck
    Friend WithEvents ucrSavePlot As ucrSave
    Friend WithEvents lblType As Label
    Friend WithEvents ucrReceiverMultipleFacet As ucrReceiverMultiple
    Friend WithEvents ucrChkKeyColumns As ucrCheck
    Friend WithEvents ucrNudKeyColumns As ucrNud
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents ucrChkLegendPosition As ucrCheck
End Class
