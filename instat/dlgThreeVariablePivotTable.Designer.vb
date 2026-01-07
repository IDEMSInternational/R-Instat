<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgThreeVariablePivotTable
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
        Me.components = New System.ComponentModel.Container()
        Me.lblInitialColumnFactor = New System.Windows.Forms.Label()
        Me.lblInitialRowFactor = New System.Windows.Forms.Label()
        Me.ttSelectedVariable = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblTableChart = New System.Windows.Forms.Label()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.ucrChkNumericVariable = New instat.ucrCheck()
        Me.ucrInputSummary = New instat.ucrInputComboBox()
        Me.ucrInputTableChart = New instat.ucrInputComboBox()
        Me.ucrReceiverInitialRowFactors = New instat.ucrReceiverMultiple()
        Me.ucrReceiverAdditionalRowFactor = New instat.ucrReceiverSingle()
        Me.ucrSavePivot = New instat.ucrSave()
        Me.ucrChkIncludeSubTotals = New instat.ucrCheck()
        Me.ucrReceiverSelectedVariable = New instat.ucrReceiverMultiple()
        Me.ucrChkSelectedVariable = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorPivot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ttFactorLevels = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrReceiverInitialColumnFactor = New instat.ucrReceiverMultiple()
        Me.ucrChkFactorsOrder = New instat.ucrCheck()
        Me.rdoDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoMultiple = New System.Windows.Forms.RadioButton()
        Me.rdoSingle = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrReceiverMultipleAddRows = New instat.ucrReceiverMultiple()
        Me.lblVariables = New System.Windows.Forms.Label()
        Me.ucrNudPositionVarCols = New instat.ucrNud()
        Me.rdoRows = New System.Windows.Forms.RadioButton()
        Me.rdoColumns = New System.Windows.Forms.RadioButton()
        Me.ucrNudPositionVarRows = New instat.ucrNud()
        Me.ucrPnlVariables = New instat.UcrPanel()
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'lblInitialColumnFactor
        '
        Me.lblInitialColumnFactor.AutoSize = True
        Me.lblInitialColumnFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInitialColumnFactor.Location = New System.Drawing.Point(244, 169)
        Me.lblInitialColumnFactor.Name = "lblInitialColumnFactor"
        Me.lblInitialColumnFactor.Size = New System.Drawing.Size(119, 13)
        Me.lblInitialColumnFactor.TabIndex = 54
        Me.lblInitialColumnFactor.Tag = "Initial Column Factor:"
        Me.lblInitialColumnFactor.Text = "Initial Column Factor(s): "
        '
        'lblInitialRowFactor
        '
        Me.lblInitialRowFactor.AutoSize = True
        Me.lblInitialRowFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInitialRowFactor.Location = New System.Drawing.Point(244, 67)
        Me.lblInitialRowFactor.Name = "lblInitialRowFactor"
        Me.lblInitialRowFactor.Size = New System.Drawing.Size(106, 13)
        Me.lblInitialRowFactor.TabIndex = 52
        Me.lblInitialRowFactor.Tag = "Initial Row Factor:"
        Me.lblInitialRowFactor.Text = "Initial Row Factor(s) :"
        '
        'lblTableChart
        '
        Me.lblTableChart.AutoSize = True
        Me.lblTableChart.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTableChart.Location = New System.Drawing.Point(9, 269)
        Me.lblTableChart.Name = "lblTableChart"
        Me.lblTableChart.Size = New System.Drawing.Size(73, 13)
        Me.lblTableChart.TabIndex = 63
        Me.lblTableChart.Text = "Table/Chart  :"
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummary.Location = New System.Drawing.Point(9, 301)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(59, 13)
        Me.lblSummary.TabIndex = 65
        Me.lblSummary.Text = "Summary : "
        '
        'ucrChkNumericVariable
        '
        Me.ucrChkNumericVariable.AutoSize = True
        Me.ucrChkNumericVariable.Checked = False
        Me.ucrChkNumericVariable.Location = New System.Drawing.Point(244, 269)
        Me.ucrChkNumericVariable.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkNumericVariable.Name = "ucrChkNumericVariable"
        Me.ucrChkNumericVariable.Size = New System.Drawing.Size(170, 23)
        Me.ucrChkNumericVariable.TabIndex = 67
        '
        'ucrInputSummary
        '
        Me.ucrInputSummary.AddQuotesIfUnrecognised = True
        Me.ucrInputSummary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSummary.GetSetSelectedIndex = -1
        Me.ucrInputSummary.IsReadOnly = False
        Me.ucrInputSummary.Location = New System.Drawing.Point(116, 301)
        Me.ucrInputSummary.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputSummary.Name = "ucrInputSummary"
        Me.ucrInputSummary.Size = New System.Drawing.Size(104, 21)
        Me.ucrInputSummary.TabIndex = 66
        '
        'ucrInputTableChart
        '
        Me.ucrInputTableChart.AddQuotesIfUnrecognised = True
        Me.ucrInputTableChart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputTableChart.GetSetSelectedIndex = -1
        Me.ucrInputTableChart.IsReadOnly = False
        Me.ucrInputTableChart.Location = New System.Drawing.Point(116, 264)
        Me.ucrInputTableChart.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputTableChart.Name = "ucrInputTableChart"
        Me.ucrInputTableChart.Size = New System.Drawing.Size(104, 21)
        Me.ucrInputTableChart.TabIndex = 64
        '
        'ucrReceiverInitialRowFactors
        '
        Me.ucrReceiverInitialRowFactors.AutoSize = True
        Me.ucrReceiverInitialRowFactors.frmParent = Me
        Me.ucrReceiverInitialRowFactors.Location = New System.Drawing.Point(244, 82)
        Me.ucrReceiverInitialRowFactors.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverInitialRowFactors.Name = "ucrReceiverInitialRowFactors"
        Me.ucrReceiverInitialRowFactors.Selector = Nothing
        Me.ucrReceiverInitialRowFactors.Size = New System.Drawing.Size(120, 77)
        Me.ucrReceiverInitialRowFactors.strNcFilePath = ""
        Me.ucrReceiverInitialRowFactors.TabIndex = 62
        Me.ucrReceiverInitialRowFactors.ucrSelector = Nothing
        '
        'ucrReceiverAdditionalRowFactor
        '
        Me.ucrReceiverAdditionalRowFactor.AutoSize = True
        Me.ucrReceiverAdditionalRowFactor.frmParent = Me
        Me.ucrReceiverAdditionalRowFactor.Location = New System.Drawing.Point(244, 297)
        Me.ucrReceiverAdditionalRowFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAdditionalRowFactor.Name = "ucrReceiverAdditionalRowFactor"
        Me.ucrReceiverAdditionalRowFactor.Selector = Nothing
        Me.ucrReceiverAdditionalRowFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverAdditionalRowFactor.strNcFilePath = ""
        Me.ucrReceiverAdditionalRowFactor.TabIndex = 61
        Me.ucrReceiverAdditionalRowFactor.ucrSelector = Nothing
        '
        'ucrSavePivot
        '
        Me.ucrSavePivot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSavePivot.Location = New System.Drawing.Point(9, 480)
        Me.ucrSavePivot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSavePivot.Name = "ucrSavePivot"
        Me.ucrSavePivot.Size = New System.Drawing.Size(382, 23)
        Me.ucrSavePivot.TabIndex = 59
        '
        'ucrChkIncludeSubTotals
        '
        Me.ucrChkIncludeSubTotals.AutoSize = True
        Me.ucrChkIncludeSubTotals.Checked = False
        Me.ucrChkIncludeSubTotals.Location = New System.Drawing.Point(9, 234)
        Me.ucrChkIncludeSubTotals.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkIncludeSubTotals.Name = "ucrChkIncludeSubTotals"
        Me.ucrChkIncludeSubTotals.Size = New System.Drawing.Size(167, 23)
        Me.ucrChkIncludeSubTotals.TabIndex = 58
        '
        'ucrReceiverSelectedVariable
        '
        Me.ucrReceiverSelectedVariable.AutoSize = True
        Me.ucrReceiverSelectedVariable.frmParent = Me
        Me.ucrReceiverSelectedVariable.Location = New System.Drawing.Point(244, 404)
        Me.ucrReceiverSelectedVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelectedVariable.Name = "ucrReceiverSelectedVariable"
        Me.ucrReceiverSelectedVariable.Selector = Nothing
        Me.ucrReceiverSelectedVariable.Size = New System.Drawing.Size(120, 71)
        Me.ucrReceiverSelectedVariable.strNcFilePath = ""
        Me.ucrReceiverSelectedVariable.TabIndex = 57
        Me.ucrReceiverSelectedVariable.ucrSelector = Nothing
        '
        'ucrChkSelectedVariable
        '
        Me.ucrChkSelectedVariable.AutoSize = True
        Me.ucrChkSelectedVariable.Checked = False
        Me.ucrChkSelectedVariable.Location = New System.Drawing.Point(244, 377)
        Me.ucrChkSelectedVariable.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkSelectedVariable.Name = "ucrChkSelectedVariable"
        Me.ucrChkSelectedVariable.Size = New System.Drawing.Size(135, 23)
        Me.ucrChkSelectedVariable.TabIndex = 56
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 510)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 51
        '
        'ucrSelectorPivot
        '
        Me.ucrSelectorPivot.AutoSize = True
        Me.ucrSelectorPivot.bDropUnusedFilterLevels = False
        Me.ucrSelectorPivot.bShowHiddenColumns = False
        Me.ucrSelectorPivot.bUseCurrentFilter = True
        Me.ucrSelectorPivot.Location = New System.Drawing.Point(9, 45)
        Me.ucrSelectorPivot.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorPivot.Name = "ucrSelectorPivot"
        Me.ucrSelectorPivot.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorPivot.TabIndex = 50
        '
        'ucrReceiverInitialColumnFactor
        '
        Me.ucrReceiverInitialColumnFactor.AutoSize = True
        Me.ucrReceiverInitialColumnFactor.frmParent = Me
        Me.ucrReceiverInitialColumnFactor.Location = New System.Drawing.Point(244, 185)
        Me.ucrReceiverInitialColumnFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverInitialColumnFactor.Name = "ucrReceiverInitialColumnFactor"
        Me.ucrReceiverInitialColumnFactor.Selector = Nothing
        Me.ucrReceiverInitialColumnFactor.Size = New System.Drawing.Size(120, 77)
        Me.ucrReceiverInitialColumnFactor.strNcFilePath = ""
        Me.ucrReceiverInitialColumnFactor.TabIndex = 68
        Me.ucrReceiverInitialColumnFactor.ucrSelector = Nothing
        '
        'ucrChkFactorsOrder
        '
        Me.ucrChkFactorsOrder.AutoSize = True
        Me.ucrChkFactorsOrder.Checked = False
        Me.ucrChkFactorsOrder.Location = New System.Drawing.Point(12, 338)
        Me.ucrChkFactorsOrder.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkFactorsOrder.Name = "ucrChkFactorsOrder"
        Me.ucrChkFactorsOrder.Size = New System.Drawing.Size(135, 23)
        Me.ucrChkFactorsOrder.TabIndex = 69
        '
        'rdoDataFrame
        '
        Me.rdoDataFrame.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDataFrame.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataFrame.FlatAppearance.BorderSize = 2
        Me.rdoDataFrame.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDataFrame.Location = New System.Drawing.Point(271, 5)
        Me.rdoDataFrame.Name = "rdoDataFrame"
        Me.rdoDataFrame.Size = New System.Drawing.Size(120, 27)
        Me.rdoDataFrame.TabIndex = 73
        Me.rdoDataFrame.TabStop = True
        Me.rdoDataFrame.Text = "DataFrame"
        Me.rdoDataFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDataFrame.UseVisualStyleBackColor = True
        '
        'rdoMultiple
        '
        Me.rdoMultiple.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMultiple.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.FlatAppearance.BorderSize = 2
        Me.rdoMultiple.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMultiple.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMultiple.Location = New System.Drawing.Point(144, 5)
        Me.rdoMultiple.Name = "rdoMultiple"
        Me.rdoMultiple.Size = New System.Drawing.Size(129, 27)
        Me.rdoMultiple.TabIndex = 72
        Me.rdoMultiple.TabStop = True
        Me.rdoMultiple.Text = "Multiple"
        Me.rdoMultiple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMultiple.UseVisualStyleBackColor = True
        '
        'rdoSingle
        '
        Me.rdoSingle.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSingle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingle.FlatAppearance.BorderSize = 2
        Me.rdoSingle.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSingle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSingle.Location = New System.Drawing.Point(22, 5)
        Me.rdoSingle.Name = "rdoSingle"
        Me.rdoSingle.Size = New System.Drawing.Size(124, 27)
        Me.rdoSingle.TabIndex = 71
        Me.rdoSingle.TabStop = True
        Me.rdoSingle.Text = "Single"
        Me.rdoSingle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSingle.UseVisualStyleBackColor = True
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(9, 3)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(396, 35)
        Me.ucrPnlOptions.TabIndex = 70
        '
        'ucrReceiverMultipleAddRows
        '
        Me.ucrReceiverMultipleAddRows.AutoSize = True
        Me.ucrReceiverMultipleAddRows.frmParent = Me
        Me.ucrReceiverMultipleAddRows.Location = New System.Drawing.Point(244, 292)
        Me.ucrReceiverMultipleAddRows.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleAddRows.Name = "ucrReceiverMultipleAddRows"
        Me.ucrReceiverMultipleAddRows.Selector = Nothing
        Me.ucrReceiverMultipleAddRows.Size = New System.Drawing.Size(120, 77)
        Me.ucrReceiverMultipleAddRows.strNcFilePath = ""
        Me.ucrReceiverMultipleAddRows.TabIndex = 74
        Me.ucrReceiverMultipleAddRows.ucrSelector = Nothing
        '
        'lblVariables
        '
        Me.lblVariables.AutoSize = True
        Me.lblVariables.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVariables.Location = New System.Drawing.Point(247, 274)
        Me.lblVariables.Name = "lblVariables"
        Me.lblVariables.Size = New System.Drawing.Size(53, 13)
        Me.lblVariables.TabIndex = 75
        Me.lblVariables.Tag = "Initial Row Factor:"
        Me.lblVariables.Text = "Variables:"
        '
        'ucrNudPositionVarCols
        '
        Me.ucrNudPositionVarCols.AutoSize = True
        Me.ucrNudPositionVarCols.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPositionVarCols.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPositionVarCols.Location = New System.Drawing.Point(124, 425)
        Me.ucrNudPositionVarCols.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudPositionVarCols.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPositionVarCols.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPositionVarCols.Name = "ucrNudPositionVarCols"
        Me.ucrNudPositionVarCols.Size = New System.Drawing.Size(49, 20)
        Me.ucrNudPositionVarCols.TabIndex = 76
        Me.ucrNudPositionVarCols.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoRows
        '
        Me.rdoRows.AutoSize = True
        Me.rdoRows.Location = New System.Drawing.Point(23, 396)
        Me.rdoRows.Name = "rdoRows"
        Me.rdoRows.Size = New System.Drawing.Size(58, 17)
        Me.rdoRows.TabIndex = 78
        Me.rdoRows.TabStop = True
        Me.rdoRows.Text = " Rows:"
        Me.rdoRows.UseVisualStyleBackColor = True
        '
        'rdoColumns
        '
        Me.rdoColumns.AutoSize = True
        Me.rdoColumns.Location = New System.Drawing.Point(23, 427)
        Me.rdoColumns.Name = "rdoColumns"
        Me.rdoColumns.Size = New System.Drawing.Size(71, 17)
        Me.rdoColumns.TabIndex = 79
        Me.rdoColumns.TabStop = True
        Me.rdoColumns.Text = " Columns:"
        Me.rdoColumns.UseVisualStyleBackColor = True
        '
        'ucrNudPositionVarRows
        '
        Me.ucrNudPositionVarRows.AutoSize = True
        Me.ucrNudPositionVarRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPositionVarRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPositionVarRows.Location = New System.Drawing.Point(124, 395)
        Me.ucrNudPositionVarRows.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudPositionVarRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPositionVarRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPositionVarRows.Name = "ucrNudPositionVarRows"
        Me.ucrNudPositionVarRows.Size = New System.Drawing.Size(49, 20)
        Me.ucrNudPositionVarRows.TabIndex = 80
        Me.ucrNudPositionVarRows.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlVariables
        '
        Me.ucrPnlVariables.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlVariables.Location = New System.Drawing.Point(12, 396)
        Me.ucrPnlVariables.Name = "ucrPnlVariables"
        Me.ucrPnlVariables.Size = New System.Drawing.Size(108, 48)
        Me.ucrPnlVariables.TabIndex = 81
        '
        'grpDisplay
        '
        Me.grpDisplay.Location = New System.Drawing.Point(9, 375)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(167, 87)
        Me.grpDisplay.TabIndex = 82
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Text = "Position of Variables"
        '
        'dlgThreeVariablePivotTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(417, 567)
        Me.Controls.Add(Me.rdoRows)
        Me.Controls.Add(Me.rdoColumns)
        Me.Controls.Add(Me.ucrNudPositionVarRows)
        Me.Controls.Add(Me.ucrNudPositionVarCols)
        Me.Controls.Add(Me.rdoDataFrame)
        Me.Controls.Add(Me.rdoMultiple)
        Me.Controls.Add(Me.rdoSingle)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrChkFactorsOrder)
        Me.Controls.Add(Me.ucrReceiverInitialColumnFactor)
        Me.Controls.Add(Me.ucrInputSummary)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.ucrInputTableChart)
        Me.Controls.Add(Me.lblTableChart)
        Me.Controls.Add(Me.ucrReceiverInitialRowFactors)
        Me.Controls.Add(Me.lblInitialColumnFactor)
        Me.Controls.Add(Me.lblInitialRowFactor)
        Me.Controls.Add(Me.ucrReceiverAdditionalRowFactor)
        Me.Controls.Add(Me.ucrSavePivot)
        Me.Controls.Add(Me.ucrChkIncludeSubTotals)
        Me.Controls.Add(Me.ucrReceiverSelectedVariable)
        Me.Controls.Add(Me.ucrChkSelectedVariable)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorPivot)
        Me.Controls.Add(Me.ucrReceiverMultipleAddRows)
        Me.Controls.Add(Me.ucrChkNumericVariable)
        Me.Controls.Add(Me.lblVariables)
        Me.Controls.Add(Me.ucrPnlVariables)
        Me.Controls.Add(Me.grpDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgThreeVariablePivotTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pivot Table"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInitialColumnFactor As Label
    Friend WithEvents lblInitialRowFactor As Label
    Friend WithEvents ttSelectedVariable As ToolTip
    Friend WithEvents ucrReceiverAdditionalRowFactor As ucrReceiverSingle
    Friend WithEvents ucrSavePivot As ucrSave
    Friend WithEvents ucrChkIncludeSubTotals As ucrCheck
    Friend WithEvents ucrReceiverSelectedVariable As ucrReceiverMultiple
    Friend WithEvents ucrChkSelectedVariable As ucrCheck
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorPivot As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverInitialRowFactors As ucrReceiverMultiple
    Friend WithEvents ucrInputTableChart As ucrInputComboBox
    Friend WithEvents lblTableChart As Label
    Friend WithEvents ucrInputSummary As ucrInputComboBox
    Friend WithEvents lblSummary As Label
    Friend WithEvents ucrChkNumericVariable As ucrCheck
    Friend WithEvents ttFactorLevels As ToolTip
    Friend WithEvents ucrReceiverInitialColumnFactor As ucrReceiverMultiple
    Friend WithEvents ucrChkFactorsOrder As ucrCheck
    Friend WithEvents rdoDataFrame As RadioButton
    Friend WithEvents rdoMultiple As RadioButton
    Friend WithEvents rdoSingle As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents ucrReceiverMultipleAddRows As ucrReceiverMultiple
    Friend WithEvents lblVariables As Label
    Friend WithEvents ucrNudPositionVarCols As ucrNud
    Friend WithEvents rdoColumns As RadioButton
    Friend WithEvents rdoRows As RadioButton
    Friend WithEvents ucrNudPositionVarRows As ucrNud
    Friend WithEvents ucrPnlVariables As UcrPanel
    Friend WithEvents grpDisplay As GroupBox
End Class