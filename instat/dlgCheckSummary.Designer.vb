<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgCheckSummary
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
        Me.rdoOutliers = New System.Windows.Forms.RadioButton()
        Me.rdoTable = New System.Windows.Forms.RadioButton()
        Me.rdoTrend = New System.Windows.Forms.RadioButton()
        Me.rdoRecent = New System.Windows.Forms.RadioButton()
        Me.pnlRecent = New System.Windows.Forms.Panel()
        Me.lblYearVariable = New System.Windows.Forms.Label()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.grdRecent = New unvell.ReoGrid.ReoGridControl()
        Me.pnlTrend = New System.Windows.Forms.Panel()
        Me.lblSecondYVar = New System.Windows.Forms.Label()
        Me.ucrReceiverSecondYVar = New instat.ucrReceiverSingle()
        Me.lblYVar = New System.Windows.Forms.Label()
        Me.ucrReceiverYVar = New instat.ucrReceiverSingle()
        Me.ucrInputStation = New instat.ucrInputComboBox()
        Me.ucrReceiverFacetBy = New instat.ucrReceiverSingle()
        Me.lblFacetBy = New System.Windows.Forms.Label()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrReceiverColourBy = New instat.ucrReceiverSingle()
        Me.lblFactorOptional = New System.Windows.Forms.Label()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.AddLineGroupbox = New System.Windows.Forms.GroupBox()
        Me.ucrChkWithSE = New instat.ucrCheck()
        Me.rdoBrokenStick = New System.Windows.Forms.RadioButton()
        Me.rdoFittedLine = New System.Windows.Forms.RadioButton()
        Me.rdoMeanLine = New System.Windows.Forms.RadioButton()
        Me.ucrChkPoints = New instat.ucrCheck()
        Me.ucrSave = New instat.ucrSave()
        Me.ucrChkFirstAndLast = New instat.ucrCheck()
        Me.cmdPlotOptions = New instat.ucrSplitButton()
        Me.ucrSelectorForCheckSummary = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSaveNewColumn = New instat.ucrSave()
        Me.UcrBaseCheckSummary = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.pnlRecent.SuspendLayout()
        Me.pnlTrend.SuspendLayout()
        Me.AddLineGroupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoOutliers
        '
        Me.rdoOutliers.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoOutliers.BackColor = System.Drawing.SystemColors.Control
        Me.rdoOutliers.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOutliers.FlatAppearance.BorderSize = 2
        Me.rdoOutliers.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOutliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoOutliers.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoOutliers.Location = New System.Drawing.Point(281, 23)
        Me.rdoOutliers.Name = "rdoOutliers"
        Me.rdoOutliers.Size = New System.Drawing.Size(80, 28)
        Me.rdoOutliers.TabIndex = 7
        Me.rdoOutliers.TabStop = True
        Me.rdoOutliers.Tag = "Outliers"
        Me.rdoOutliers.Text = "Outliers"
        Me.rdoOutliers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoOutliers.UseVisualStyleBackColor = False
        '
        'rdoTable
        '
        Me.rdoTable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTable.BackColor = System.Drawing.SystemColors.Control
        Me.rdoTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatAppearance.BorderSize = 2
        Me.rdoTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTable.Location = New System.Drawing.Point(360, 23)
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.Size = New System.Drawing.Size(75, 28)
        Me.rdoTable.TabIndex = 8
        Me.rdoTable.TabStop = True
        Me.rdoTable.Tag = "Table"
        Me.rdoTable.Text = "Table"
        Me.rdoTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTable.UseVisualStyleBackColor = False
        '
        'rdoTrend
        '
        Me.rdoTrend.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTrend.BackColor = System.Drawing.SystemColors.Control
        Me.rdoTrend.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTrend.FlatAppearance.BorderSize = 2
        Me.rdoTrend.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTrend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTrend.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTrend.Location = New System.Drawing.Point(213, 23)
        Me.rdoTrend.Name = "rdoTrend"
        Me.rdoTrend.Size = New System.Drawing.Size(68, 28)
        Me.rdoTrend.TabIndex = 6
        Me.rdoTrend.TabStop = True
        Me.rdoTrend.Tag = "Trend"
        Me.rdoTrend.Text = "Trend"
        Me.rdoTrend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTrend.UseVisualStyleBackColor = False
        '
        'rdoRecent
        '
        Me.rdoRecent.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRecent.BackColor = System.Drawing.SystemColors.Control
        Me.rdoRecent.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRecent.FlatAppearance.BorderSize = 2
        Me.rdoRecent.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRecent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRecent.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRecent.Location = New System.Drawing.Point(138, 23)
        Me.rdoRecent.Name = "rdoRecent"
        Me.rdoRecent.Size = New System.Drawing.Size(75, 28)
        Me.rdoRecent.TabIndex = 9
        Me.rdoRecent.TabStop = True
        Me.rdoRecent.Tag = "Recent"
        Me.rdoRecent.Text = "Recent"
        Me.rdoRecent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRecent.UseVisualStyleBackColor = False
        '
        'pnlRecent
        '
        Me.pnlRecent.Controls.Add(Me.lblYearVariable)
        Me.pnlRecent.Controls.Add(Me.ucrReceiverYear)
        Me.pnlRecent.Controls.Add(Me.grdRecent)
        Me.pnlRecent.Location = New System.Drawing.Point(286, 57)
        Me.pnlRecent.Name = "pnlRecent"
        Me.pnlRecent.Size = New System.Drawing.Size(303, 259)
        Me.pnlRecent.TabIndex = 14
        Me.pnlRecent.Visible = False
        '
        'lblYearVariable
        '
        Me.lblYearVariable.AutoSize = True
        Me.lblYearVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYearVariable.Location = New System.Drawing.Point(13, 19)
        Me.lblYearVariable.Name = "lblYearVariable"
        Me.lblYearVariable.Size = New System.Drawing.Size(73, 13)
        Me.lblYearVariable.TabIndex = 8
        Me.lblYearVariable.Text = "Year Variable:"
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(13, 34)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 9
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'grdRecent
        '
        Me.grdRecent.BackColor = System.Drawing.Color.White
        Me.grdRecent.ColumnHeaderContextMenuStrip = Nothing
        Me.grdRecent.LeadHeaderContextMenuStrip = Nothing
        Me.grdRecent.Location = New System.Drawing.Point(16, 69)
        Me.grdRecent.Name = "grdRecent"
        Me.grdRecent.RowHeaderContextMenuStrip = Nothing
        Me.grdRecent.Script = Nothing
        Me.grdRecent.SheetTabContextMenuStrip = Nothing
        Me.grdRecent.SheetTabNewButtonVisible = False
        Me.grdRecent.SheetTabVisible = False
        Me.grdRecent.SheetTabWidth = 60
        Me.grdRecent.ShowScrollEndSpacing = True
        Me.grdRecent.Size = New System.Drawing.Size(265, 184)
        Me.grdRecent.TabIndex = 1
        Me.grdRecent.Text = "ReoGridControl1"
        '
        'pnlTrend
        '
        Me.pnlTrend.Controls.Add(Me.lblSecondYVar)
        Me.pnlTrend.Controls.Add(Me.ucrReceiverSecondYVar)
        Me.pnlTrend.Controls.Add(Me.lblYVar)
        Me.pnlTrend.Controls.Add(Me.ucrReceiverYVar)
        Me.pnlTrend.Controls.Add(Me.ucrInputStation)
        Me.pnlTrend.Controls.Add(Me.ucrReceiverFacetBy)
        Me.pnlTrend.Controls.Add(Me.lblFacetBy)
        Me.pnlTrend.Controls.Add(Me.ucrReceiverX)
        Me.pnlTrend.Controls.Add(Me.ucrReceiverColourBy)
        Me.pnlTrend.Controls.Add(Me.lblFactorOptional)
        Me.pnlTrend.Controls.Add(Me.lblXVariable)
        Me.pnlTrend.Location = New System.Drawing.Point(286, 57)
        Me.pnlTrend.Name = "pnlTrend"
        Me.pnlTrend.Size = New System.Drawing.Size(303, 259)
        Me.pnlTrend.TabIndex = 27
        '
        'lblSecondYVar
        '
        Me.lblSecondYVar.AutoSize = True
        Me.lblSecondYVar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondYVar.Location = New System.Drawing.Point(47, 67)
        Me.lblSecondYVar.Name = "lblSecondYVar"
        Me.lblSecondYVar.Size = New System.Drawing.Size(146, 13)
        Me.lblSecondYVar.TabIndex = 16
        Me.lblSecondYVar.Tag = ""
        Me.lblSecondYVar.Text = "Second Y Variable (Optional):"
        '
        'ucrReceiverSecondYVar
        '
        Me.ucrReceiverSecondYVar.AutoSize = True
        Me.ucrReceiverSecondYVar.frmParent = Me
        Me.ucrReceiverSecondYVar.Location = New System.Drawing.Point(47, 81)
        Me.ucrReceiverSecondYVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondYVar.Name = "ucrReceiverSecondYVar"
        Me.ucrReceiverSecondYVar.Selector = Nothing
        Me.ucrReceiverSecondYVar.Size = New System.Drawing.Size(145, 26)
        Me.ucrReceiverSecondYVar.strNcFilePath = ""
        Me.ucrReceiverSecondYVar.TabIndex = 17
        Me.ucrReceiverSecondYVar.ucrSelector = Nothing
        '
        'lblYVar
        '
        Me.lblYVar.AutoSize = True
        Me.lblYVar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYVar.Location = New System.Drawing.Point(47, 21)
        Me.lblYVar.Name = "lblYVar"
        Me.lblYVar.Size = New System.Drawing.Size(58, 13)
        Me.lblYVar.TabIndex = 14
        Me.lblYVar.Tag = ""
        Me.lblYVar.Text = "Y Variable:"
        '
        'ucrReceiverYVar
        '
        Me.ucrReceiverYVar.AutoSize = True
        Me.ucrReceiverYVar.frmParent = Me
        Me.ucrReceiverYVar.Location = New System.Drawing.Point(47, 35)
        Me.ucrReceiverYVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYVar.Name = "ucrReceiverYVar"
        Me.ucrReceiverYVar.Selector = Nothing
        Me.ucrReceiverYVar.Size = New System.Drawing.Size(145, 26)
        Me.ucrReceiverYVar.strNcFilePath = ""
        Me.ucrReceiverYVar.TabIndex = 15
        Me.ucrReceiverYVar.ucrSelector = Nothing
        '
        'ucrInputStation
        '
        Me.ucrInputStation.AddQuotesIfUnrecognised = True
        Me.ucrInputStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStation.GetSetSelectedIndex = -1
        Me.ucrInputStation.IsReadOnly = False
        Me.ucrInputStation.Location = New System.Drawing.Point(174, 212)
        Me.ucrInputStation.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputStation.Name = "ucrInputStation"
        Me.ucrInputStation.Size = New System.Drawing.Size(82, 21)
        Me.ucrInputStation.TabIndex = 24
        '
        'ucrReceiverFacetBy
        '
        Me.ucrReceiverFacetBy.AutoSize = True
        Me.ucrReceiverFacetBy.frmParent = Me
        Me.ucrReceiverFacetBy.Location = New System.Drawing.Point(47, 212)
        Me.ucrReceiverFacetBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacetBy.Name = "ucrReceiverFacetBy"
        Me.ucrReceiverFacetBy.Selector = Nothing
        Me.ucrReceiverFacetBy.Size = New System.Drawing.Size(125, 26)
        Me.ucrReceiverFacetBy.strNcFilePath = ""
        Me.ucrReceiverFacetBy.TabIndex = 23
        Me.ucrReceiverFacetBy.ucrSelector = Nothing
        '
        'lblFacetBy
        '
        Me.lblFacetBy.AutoSize = True
        Me.lblFacetBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacetBy.Location = New System.Drawing.Point(47, 199)
        Me.lblFacetBy.Name = "lblFacetBy"
        Me.lblFacetBy.Size = New System.Drawing.Size(100, 13)
        Me.lblFacetBy.TabIndex = 22
        Me.lblFacetBy.Tag = ""
        Me.lblFacetBy.Text = "Facet By (Optional):"
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.AutoSize = True
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(47, 124)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(145, 26)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 19
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrReceiverColourBy
        '
        Me.ucrReceiverColourBy.AutoSize = True
        Me.ucrReceiverColourBy.frmParent = Me
        Me.ucrReceiverColourBy.Location = New System.Drawing.Point(47, 169)
        Me.ucrReceiverColourBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColourBy.Name = "ucrReceiverColourBy"
        Me.ucrReceiverColourBy.Selector = Nothing
        Me.ucrReceiverColourBy.Size = New System.Drawing.Size(145, 26)
        Me.ucrReceiverColourBy.strNcFilePath = ""
        Me.ucrReceiverColourBy.TabIndex = 21
        Me.ucrReceiverColourBy.ucrSelector = Nothing
        '
        'lblFactorOptional
        '
        Me.lblFactorOptional.AutoSize = True
        Me.lblFactorOptional.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactorOptional.Location = New System.Drawing.Point(47, 151)
        Me.lblFactorOptional.Name = "lblFactorOptional"
        Me.lblFactorOptional.Size = New System.Drawing.Size(103, 13)
        Me.lblFactorOptional.TabIndex = 20
        Me.lblFactorOptional.Tag = "Factor_Optional:"
        Me.lblFactorOptional.Text = "Colour By (Optional):"
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXVariable.Location = New System.Drawing.Point(47, 109)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(58, 13)
        Me.lblXVariable.TabIndex = 18
        Me.lblXVariable.Tag = "X_Variable:"
        Me.lblXVariable.Text = "X Variable:"
        '
        'AddLineGroupbox
        '
        Me.AddLineGroupbox.Controls.Add(Me.ucrChkWithSE)
        Me.AddLineGroupbox.Controls.Add(Me.rdoBrokenStick)
        Me.AddLineGroupbox.Controls.Add(Me.rdoFittedLine)
        Me.AddLineGroupbox.Controls.Add(Me.rdoMeanLine)
        Me.AddLineGroupbox.Location = New System.Drawing.Point(29, 312)
        Me.AddLineGroupbox.Name = "AddLineGroupbox"
        Me.AddLineGroupbox.Size = New System.Drawing.Size(264, 93)
        Me.AddLineGroupbox.TabIndex = 30
        Me.AddLineGroupbox.TabStop = False
        Me.AddLineGroupbox.Text = "Add Line"
        '
        'ucrChkWithSE
        '
        Me.ucrChkWithSE.AutoSize = True
        Me.ucrChkWithSE.Checked = False
        Me.ucrChkWithSE.Location = New System.Drawing.Point(153, 44)
        Me.ucrChkWithSE.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkWithSE.Name = "ucrChkWithSE"
        Me.ucrChkWithSE.Size = New System.Drawing.Size(111, 23)
        Me.ucrChkWithSE.TabIndex = 21
        '
        'rdoBrokenStick
        '
        Me.rdoBrokenStick.AutoSize = True
        Me.rdoBrokenStick.Location = New System.Drawing.Point(24, 67)
        Me.rdoBrokenStick.Name = "rdoBrokenStick"
        Me.rdoBrokenStick.Size = New System.Drawing.Size(86, 17)
        Me.rdoBrokenStick.TabIndex = 2
        Me.rdoBrokenStick.TabStop = True
        Me.rdoBrokenStick.Text = "Broken Stick"
        Me.rdoBrokenStick.UseVisualStyleBackColor = True
        '
        'rdoFittedLine
        '
        Me.rdoFittedLine.AutoSize = True
        Me.rdoFittedLine.Location = New System.Drawing.Point(24, 44)
        Me.rdoFittedLine.Name = "rdoFittedLine"
        Me.rdoFittedLine.Size = New System.Drawing.Size(74, 17)
        Me.rdoFittedLine.TabIndex = 1
        Me.rdoFittedLine.TabStop = True
        Me.rdoFittedLine.Text = "Fitted Line"
        Me.rdoFittedLine.UseVisualStyleBackColor = True
        '
        'rdoMeanLine
        '
        Me.rdoMeanLine.AutoSize = True
        Me.rdoMeanLine.Location = New System.Drawing.Point(24, 20)
        Me.rdoMeanLine.Name = "rdoMeanLine"
        Me.rdoMeanLine.Size = New System.Drawing.Size(75, 17)
        Me.rdoMeanLine.TabIndex = 0
        Me.rdoMeanLine.TabStop = True
        Me.rdoMeanLine.Text = "Mean Line"
        Me.rdoMeanLine.UseVisualStyleBackColor = True
        '
        'ucrChkPoints
        '
        Me.ucrChkPoints.AutoSize = True
        Me.ucrChkPoints.Checked = False
        Me.ucrChkPoints.Location = New System.Drawing.Point(30, 408)
        Me.ucrChkPoints.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkPoints.Name = "ucrChkPoints"
        Me.ucrChkPoints.Size = New System.Drawing.Size(221, 24)
        Me.ucrChkPoints.TabIndex = 31
        '
        'ucrSave
        '
        Me.ucrSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSave.Location = New System.Drawing.Point(29, 433)
        Me.ucrSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSave.Name = "ucrSave"
        Me.ucrSave.Size = New System.Drawing.Size(320, 24)
        Me.ucrSave.TabIndex = 32
        '
        'ucrChkFirstAndLast
        '
        Me.ucrChkFirstAndLast.AutoSize = True
        Me.ucrChkFirstAndLast.Checked = False
        Me.ucrChkFirstAndLast.Location = New System.Drawing.Point(29, 280)
        Me.ucrChkFirstAndLast.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkFirstAndLast.Name = "ucrChkFirstAndLast"
        Me.ucrChkFirstAndLast.Size = New System.Drawing.Size(221, 23)
        Me.ucrChkFirstAndLast.TabIndex = 29
        '
        'cmdPlotOptions
        '
        Me.cmdPlotOptions.AutoSize = True
        Me.cmdPlotOptions.Location = New System.Drawing.Point(29, 248)
        Me.cmdPlotOptions.Name = "cmdPlotOptions"
        Me.cmdPlotOptions.Size = New System.Drawing.Size(151, 23)
        Me.cmdPlotOptions.TabIndex = 28
        Me.cmdPlotOptions.Tag = "Plot Options"
        Me.cmdPlotOptions.Text = "Plot Options"
        Me.cmdPlotOptions.UseVisualStyleBackColor = True
        '
        'ucrSelectorForCheckSummary
        '
        Me.ucrSelectorForCheckSummary.AutoSize = True
        Me.ucrSelectorForCheckSummary.bDropUnusedFilterLevels = False
        Me.ucrSelectorForCheckSummary.bShowHiddenColumns = False
        Me.ucrSelectorForCheckSummary.bUseCurrentFilter = True
        Me.ucrSelectorForCheckSummary.Location = New System.Drawing.Point(29, 57)
        Me.ucrSelectorForCheckSummary.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForCheckSummary.Name = "ucrSelectorForCheckSummary"
        Me.ucrSelectorForCheckSummary.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForCheckSummary.TabIndex = 26
        '
        'ucrSaveNewColumn
        '
        Me.ucrSaveNewColumn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveNewColumn.Location = New System.Drawing.Point(29, 461)
        Me.ucrSaveNewColumn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveNewColumn.Name = "ucrSaveNewColumn"
        Me.ucrSaveNewColumn.Size = New System.Drawing.Size(389, 22)
        Me.ucrSaveNewColumn.TabIndex = 25
        '
        'UcrBaseCheckSummary
        '
        Me.UcrBaseCheckSummary.AutoSize = True
        Me.UcrBaseCheckSummary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcrBaseCheckSummary.Location = New System.Drawing.Point(29, 495)
        Me.UcrBaseCheckSummary.Name = "UcrBaseCheckSummary"
        Me.UcrBaseCheckSummary.Size = New System.Drawing.Size(408, 52)
        Me.UcrBaseCheckSummary.TabIndex = 24
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(138, 23)
        Me.ucrPnlOptions.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(299, 36)
        Me.ucrPnlOptions.TabIndex = 13
        '
        'dlgCheckSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(589, 558)
        Me.Controls.Add(Me.ucrChkPoints)
        Me.Controls.Add(Me.ucrSave)
        Me.Controls.Add(Me.AddLineGroupbox)
        Me.Controls.Add(Me.ucrChkFirstAndLast)
        Me.Controls.Add(Me.cmdPlotOptions)
        Me.Controls.Add(Me.pnlTrend)
        Me.Controls.Add(Me.ucrSelectorForCheckSummary)
        Me.Controls.Add(Me.ucrSaveNewColumn)
        Me.Controls.Add(Me.UcrBaseCheckSummary)
        Me.Controls.Add(Me.rdoTrend)
        Me.Controls.Add(Me.rdoRecent)
        Me.Controls.Add(Me.rdoOutliers)
        Me.Controls.Add(Me.rdoTable)
        Me.Controls.Add(Me.pnlRecent)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCheckSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check Summary"
        Me.pnlRecent.ResumeLayout(False)
        Me.pnlRecent.PerformLayout()
        Me.pnlTrend.ResumeLayout(False)
        Me.pnlTrend.PerformLayout()
        Me.AddLineGroupbox.ResumeLayout(False)
        Me.AddLineGroupbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdoOutliers As RadioButton
    Friend WithEvents rdoTable As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents rdoTrend As RadioButton
    Friend WithEvents rdoRecent As RadioButton
    Friend WithEvents pnlRecent As Panel
    Friend WithEvents grdRecent As unvell.ReoGrid.ReoGridControl
    Friend WithEvents lblYearVariable As Label
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrSelectorForCheckSummary As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSaveNewColumn As ucrSave
    Friend WithEvents UcrBaseCheckSummary As ucrButtons
    Friend WithEvents pnlTrend As Panel
    Friend WithEvents lblSecondYVar As Label
    Friend WithEvents ucrReceiverSecondYVar As ucrReceiverSingle
    Friend WithEvents lblYVar As Label
    Friend WithEvents ucrReceiverYVar As ucrReceiverSingle
    Friend WithEvents ucrInputStation As ucrInputComboBox
    Friend WithEvents ucrReceiverFacetBy As ucrReceiverSingle
    Friend WithEvents lblFacetBy As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents ucrReceiverColourBy As ucrReceiverSingle
    Friend WithEvents lblFactorOptional As Label
    Friend WithEvents lblXVariable As Label
    Friend WithEvents cmdPlotOptions As ucrSplitButton
    Friend WithEvents ucrChkFirstAndLast As ucrCheck
    Friend WithEvents AddLineGroupbox As GroupBox
    Friend WithEvents rdoBrokenStick As RadioButton
    Friend WithEvents rdoFittedLine As RadioButton
    Friend WithEvents rdoMeanLine As RadioButton
    Friend WithEvents ucrChkPoints As ucrCheck
    Friend WithEvents ucrSave As ucrSave
    Friend WithEvents ucrChkWithSE As ucrCheck
End Class
