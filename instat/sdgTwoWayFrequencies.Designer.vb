<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgTwoWayFrequencies
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
        Me.tbOneWayFrequencies = New System.Windows.Forms.TabControl()
        Me.tbTable = New System.Windows.Forms.TabPage()
        Me.grpTableOptions = New System.Windows.Forms.GroupBox()
        Me.lblNumberOfDecimals = New System.Windows.Forms.Label()
        Me.ucrNudDecimalPlaces = New instat.ucrNud()
        Me.lblGraphTitle = New System.Windows.Forms.Label()
        Me.ucrInputTableTitle = New instat.ucrInputTextBox()
        Me.ucrChkTotalColumnName = New instat.ucrCheck()
        Me.ucrInputCountsName = New instat.ucrInputTextBox()
        Me.ucrChkMissingValues = New instat.ucrCheck()
        Me.ucrChkBackgroundColour = New instat.ucrCheck()
        Me.ucrChkShowSummary = New instat.ucrCheck()
        Me.tbGraph = New System.Windows.Forms.TabPage()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.grpGraphOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkStack = New instat.ucrCheck()
        Me.ucrChkShowValues = New instat.ucrCheck()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHjust = New System.Windows.Forms.Label()
        Me.lblVjust = New System.Windows.Forms.Label()
        Me.ucrInputGraphTitle = New instat.ucrInputTextBox()
        Me.ucrInputHorizontalLabels = New instat.ucrInputComboBox()
        Me.ucrInputVerticalLabels = New instat.ucrInputComboBox()
        Me.ucrChkShowModelSummary = New instat.ucrCheck()
        Me.ucrChkShowPercentage = New instat.ucrCheck()
        Me.ucrChkShowCount = New instat.ucrCheck()
        Me.grpGraphType = New System.Windows.Forms.GroupBox()
        Me.rdoLine = New System.Windows.Forms.RadioButton()
        Me.rdoBar = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGraphType = New instat.UcrPanel()
        Me.ucrBaseSubDialogue = New instat.ucrButtonsSubdialogue()
        Me.tbOneWayFrequencies.SuspendLayout()
        Me.tbTable.SuspendLayout()
        Me.grpTableOptions.SuspendLayout()
        Me.tbGraph.SuspendLayout()
        Me.grpGraphOptions.SuspendLayout()
        Me.grpGraphType.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbOneWayFrequencies
        '
        Me.tbOneWayFrequencies.Controls.Add(Me.tbTable)
        Me.tbOneWayFrequencies.Controls.Add(Me.tbGraph)
        Me.tbOneWayFrequencies.Location = New System.Drawing.Point(12, 12)
        Me.tbOneWayFrequencies.Name = "tbOneWayFrequencies"
        Me.tbOneWayFrequencies.SelectedIndex = 0
        Me.tbOneWayFrequencies.Size = New System.Drawing.Size(321, 335)
        Me.tbOneWayFrequencies.TabIndex = 4
        '
        'tbTable
        '
        Me.tbTable.Controls.Add(Me.grpTableOptions)
        Me.tbTable.Location = New System.Drawing.Point(4, 22)
        Me.tbTable.Name = "tbTable"
        Me.tbTable.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTable.Size = New System.Drawing.Size(313, 309)
        Me.tbTable.TabIndex = 0
        Me.tbTable.Text = "Table"
        Me.tbTable.UseVisualStyleBackColor = True
        '
        'grpTableOptions
        '
        Me.grpTableOptions.Controls.Add(Me.lblNumberOfDecimals)
        Me.grpTableOptions.Controls.Add(Me.ucrNudDecimalPlaces)
        Me.grpTableOptions.Controls.Add(Me.lblGraphTitle)
        Me.grpTableOptions.Controls.Add(Me.ucrInputTableTitle)
        Me.grpTableOptions.Controls.Add(Me.ucrChkTotalColumnName)
        Me.grpTableOptions.Controls.Add(Me.ucrInputCountsName)
        Me.grpTableOptions.Controls.Add(Me.ucrChkMissingValues)
        Me.grpTableOptions.Controls.Add(Me.ucrChkBackgroundColour)
        Me.grpTableOptions.Controls.Add(Me.ucrChkShowSummary)
        Me.grpTableOptions.Location = New System.Drawing.Point(6, 7)
        Me.grpTableOptions.Name = "grpTableOptions"
        Me.grpTableOptions.Size = New System.Drawing.Size(304, 177)
        Me.grpTableOptions.TabIndex = 21
        Me.grpTableOptions.TabStop = False
        Me.grpTableOptions.Text = "More Options"
        '
        'lblNumberOfDecimals
        '
        Me.lblNumberOfDecimals.AutoSize = True
        Me.lblNumberOfDecimals.Location = New System.Drawing.Point(3, 85)
        Me.lblNumberOfDecimals.Name = "lblNumberOfDecimals"
        Me.lblNumberOfDecimals.Size = New System.Drawing.Size(159, 13)
        Me.lblNumberOfDecimals.TabIndex = 64
        Me.lblNumberOfDecimals.Text = "Decimal places for percentages:"
        '
        'ucrNudDecimalPlaces
        '
        Me.ucrNudDecimalPlaces.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Location = New System.Drawing.Point(170, 84)
        Me.ucrNudDecimalPlaces.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Name = "ucrNudDecimalPlaces"
        Me.ucrNudDecimalPlaces.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDecimalPlaces.TabIndex = 63
        Me.ucrNudDecimalPlaces.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblGraphTitle
        '
        Me.lblGraphTitle.AutoSize = True
        Me.lblGraphTitle.Location = New System.Drawing.Point(3, 133)
        Me.lblGraphTitle.Name = "lblGraphTitle"
        Me.lblGraphTitle.Size = New System.Drawing.Size(62, 13)
        Me.lblGraphTitle.TabIndex = 62
        Me.lblGraphTitle.Text = "Graph Title:"
        '
        'ucrInputTableTitle
        '
        Me.ucrInputTableTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputTableTitle.IsMultiline = False
        Me.ucrInputTableTitle.IsReadOnly = False
        Me.ucrInputTableTitle.Location = New System.Drawing.Point(127, 133)
        Me.ucrInputTableTitle.Name = "ucrInputTableTitle"
        Me.ucrInputTableTitle.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputTableTitle.TabIndex = 61
        '
        'ucrChkTotalColumnName
        '
        Me.ucrChkTotalColumnName.Checked = False
        Me.ucrChkTotalColumnName.Location = New System.Drawing.Point(6, 107)
        Me.ucrChkTotalColumnName.Name = "ucrChkTotalColumnName"
        Me.ucrChkTotalColumnName.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkTotalColumnName.TabIndex = 60
        '
        'ucrInputCountsName
        '
        Me.ucrInputCountsName.AddQuotesIfUnrecognised = True
        Me.ucrInputCountsName.IsMultiline = False
        Me.ucrInputCountsName.IsReadOnly = False
        Me.ucrInputCountsName.Location = New System.Drawing.Point(127, 106)
        Me.ucrInputCountsName.Name = "ucrInputCountsName"
        Me.ucrInputCountsName.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputCountsName.TabIndex = 59
        '
        'ucrChkMissingValues
        '
        Me.ucrChkMissingValues.Checked = False
        Me.ucrChkMissingValues.Location = New System.Drawing.Point(6, 41)
        Me.ucrChkMissingValues.Name = "ucrChkMissingValues"
        Me.ucrChkMissingValues.Size = New System.Drawing.Size(147, 20)
        Me.ucrChkMissingValues.TabIndex = 23
        '
        'ucrChkBackgroundColour
        '
        Me.ucrChkBackgroundColour.Checked = False
        Me.ucrChkBackgroundColour.Location = New System.Drawing.Point(6, 63)
        Me.ucrChkBackgroundColour.Name = "ucrChkBackgroundColour"
        Me.ucrChkBackgroundColour.Size = New System.Drawing.Size(290, 20)
        Me.ucrChkBackgroundColour.TabIndex = 22
        '
        'ucrChkShowSummary
        '
        Me.ucrChkShowSummary.Checked = False
        Me.ucrChkShowSummary.Location = New System.Drawing.Point(6, 19)
        Me.ucrChkShowSummary.Name = "ucrChkShowSummary"
        Me.ucrChkShowSummary.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkShowSummary.TabIndex = 19
        '
        'tbGraph
        '
        Me.tbGraph.Controls.Add(Me.ucrSaveGraph)
        Me.tbGraph.Controls.Add(Me.grpGraphOptions)
        Me.tbGraph.Controls.Add(Me.grpGraphType)
        Me.tbGraph.Location = New System.Drawing.Point(4, 22)
        Me.tbGraph.Name = "tbGraph"
        Me.tbGraph.Padding = New System.Windows.Forms.Padding(3)
        Me.tbGraph.Size = New System.Drawing.Size(313, 309)
        Me.tbGraph.TabIndex = 1
        Me.tbGraph.Text = "Graph"
        Me.tbGraph.UseVisualStyleBackColor = True
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(18, 278)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(288, 24)
        Me.ucrSaveGraph.TabIndex = 39
        '
        'grpGraphOptions
        '
        Me.grpGraphOptions.Controls.Add(Me.ucrChkStack)
        Me.grpGraphOptions.Controls.Add(Me.ucrChkShowValues)
        Me.grpGraphOptions.Controls.Add(Me.lblTitle)
        Me.grpGraphOptions.Controls.Add(Me.lblHjust)
        Me.grpGraphOptions.Controls.Add(Me.lblVjust)
        Me.grpGraphOptions.Controls.Add(Me.ucrInputGraphTitle)
        Me.grpGraphOptions.Controls.Add(Me.ucrInputHorizontalLabels)
        Me.grpGraphOptions.Controls.Add(Me.ucrInputVerticalLabels)
        Me.grpGraphOptions.Controls.Add(Me.ucrChkShowModelSummary)
        Me.grpGraphOptions.Controls.Add(Me.ucrChkShowPercentage)
        Me.grpGraphOptions.Controls.Add(Me.ucrChkShowCount)
        Me.grpGraphOptions.Location = New System.Drawing.Point(6, 59)
        Me.grpGraphOptions.Name = "grpGraphOptions"
        Me.grpGraphOptions.Size = New System.Drawing.Size(300, 213)
        Me.grpGraphOptions.TabIndex = 37
        Me.grpGraphOptions.TabStop = False
        Me.grpGraphOptions.Text = "Graph Options"
        '
        'ucrChkStack
        '
        Me.ucrChkStack.Checked = False
        Me.ucrChkStack.Location = New System.Drawing.Point(12, 115)
        Me.ucrChkStack.Name = "ucrChkStack"
        Me.ucrChkStack.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkStack.TabIndex = 61
        '
        'ucrChkShowValues
        '
        Me.ucrChkShowValues.Checked = False
        Me.ucrChkShowValues.Location = New System.Drawing.Point(12, 19)
        Me.ucrChkShowValues.Name = "ucrChkShowValues"
        Me.ucrChkShowValues.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkShowValues.TabIndex = 60
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(9, 190)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(62, 13)
        Me.lblTitle.TabIndex = 58
        Me.lblTitle.Text = "Graph Title:"
        '
        'lblHjust
        '
        Me.lblHjust.AutoSize = True
        Me.lblHjust.Location = New System.Drawing.Point(9, 163)
        Me.lblHjust.Name = "lblHjust"
        Me.lblHjust.Size = New System.Drawing.Size(126, 13)
        Me.lblHjust.TabIndex = 57
        Me.lblHjust.Text = "Horizontal Label Position:"
        '
        'lblVjust
        '
        Me.lblVjust.AutoSize = True
        Me.lblVjust.Location = New System.Drawing.Point(9, 138)
        Me.lblVjust.Name = "lblVjust"
        Me.lblVjust.Size = New System.Drawing.Size(114, 13)
        Me.lblVjust.TabIndex = 55
        Me.lblVjust.Text = "Vertical Label Position:"
        '
        'ucrInputGraphTitle
        '
        Me.ucrInputGraphTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphTitle.IsMultiline = False
        Me.ucrInputGraphTitle.IsReadOnly = False
        Me.ucrInputGraphTitle.Location = New System.Drawing.Point(141, 188)
        Me.ucrInputGraphTitle.Name = "ucrInputGraphTitle"
        Me.ucrInputGraphTitle.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputGraphTitle.TabIndex = 54
        '
        'ucrInputHorizontalLabels
        '
        Me.ucrInputHorizontalLabels.AddQuotesIfUnrecognised = True
        Me.ucrInputHorizontalLabels.IsReadOnly = False
        Me.ucrInputHorizontalLabels.Location = New System.Drawing.Point(141, 161)
        Me.ucrInputHorizontalLabels.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputHorizontalLabels.Name = "ucrInputHorizontalLabels"
        Me.ucrInputHorizontalLabels.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputHorizontalLabels.TabIndex = 51
        '
        'ucrInputVerticalLabels
        '
        Me.ucrInputVerticalLabels.AddQuotesIfUnrecognised = True
        Me.ucrInputVerticalLabels.IsReadOnly = False
        Me.ucrInputVerticalLabels.Location = New System.Drawing.Point(141, 136)
        Me.ucrInputVerticalLabels.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputVerticalLabels.Name = "ucrInputVerticalLabels"
        Me.ucrInputVerticalLabels.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputVerticalLabels.TabIndex = 50
        '
        'ucrChkShowModelSummary
        '
        Me.ucrChkShowModelSummary.Checked = False
        Me.ucrChkShowModelSummary.Location = New System.Drawing.Point(12, 91)
        Me.ucrChkShowModelSummary.Name = "ucrChkShowModelSummary"
        Me.ucrChkShowModelSummary.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkShowModelSummary.TabIndex = 28
        '
        'ucrChkShowPercentage
        '
        Me.ucrChkShowPercentage.Checked = False
        Me.ucrChkShowPercentage.Location = New System.Drawing.Point(12, 43)
        Me.ucrChkShowPercentage.Name = "ucrChkShowPercentage"
        Me.ucrChkShowPercentage.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkShowPercentage.TabIndex = 20
        '
        'ucrChkShowCount
        '
        Me.ucrChkShowCount.Checked = False
        Me.ucrChkShowCount.Location = New System.Drawing.Point(12, 67)
        Me.ucrChkShowCount.Name = "ucrChkShowCount"
        Me.ucrChkShowCount.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkShowCount.TabIndex = 18
        '
        'grpGraphType
        '
        Me.grpGraphType.Controls.Add(Me.rdoLine)
        Me.grpGraphType.Controls.Add(Me.rdoBar)
        Me.grpGraphType.Controls.Add(Me.ucrPnlGraphType)
        Me.grpGraphType.Location = New System.Drawing.Point(6, 6)
        Me.grpGraphType.Name = "grpGraphType"
        Me.grpGraphType.Size = New System.Drawing.Size(300, 48)
        Me.grpGraphType.TabIndex = 33
        Me.grpGraphType.TabStop = False
        Me.grpGraphType.Text = "Type of Graph"
        '
        'rdoLine
        '
        Me.rdoLine.AutoSize = True
        Me.rdoLine.Location = New System.Drawing.Point(163, 19)
        Me.rdoLine.Name = "rdoLine"
        Me.rdoLine.Size = New System.Drawing.Size(77, 17)
        Me.rdoLine.TabIndex = 7
        Me.rdoLine.TabStop = True
        Me.rdoLine.Text = "Line Graph"
        Me.rdoLine.UseVisualStyleBackColor = True
        '
        'rdoBar
        '
        Me.rdoBar.AutoSize = True
        Me.rdoBar.Location = New System.Drawing.Point(12, 19)
        Me.rdoBar.Name = "rdoBar"
        Me.rdoBar.Size = New System.Drawing.Size(73, 17)
        Me.rdoBar.TabIndex = 5
        Me.rdoBar.TabStop = True
        Me.rdoBar.Text = "Bar Graph"
        Me.rdoBar.UseVisualStyleBackColor = True
        '
        'ucrPnlGraphType
        '
        Me.ucrPnlGraphType.Location = New System.Drawing.Point(6, 7)
        Me.ucrPnlGraphType.Name = "ucrPnlGraphType"
        Me.ucrPnlGraphType.Size = New System.Drawing.Size(288, 35)
        Me.ucrPnlGraphType.TabIndex = 4
        '
        'ucrBaseSubDialogue
        '
        Me.ucrBaseSubDialogue.Location = New System.Drawing.Point(89, 355)
        Me.ucrBaseSubDialogue.Name = "ucrBaseSubDialogue"
        Me.ucrBaseSubDialogue.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSubDialogue.TabIndex = 3
        '
        'sdgTwoWayFrequencies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 393)
        Me.Controls.Add(Me.tbOneWayFrequencies)
        Me.Controls.Add(Me.ucrBaseSubDialogue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgTwoWayFrequencies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Two Way Frequencies Options"
        Me.tbOneWayFrequencies.ResumeLayout(False)
        Me.tbTable.ResumeLayout(False)
        Me.grpTableOptions.ResumeLayout(False)
        Me.grpTableOptions.PerformLayout()
        Me.tbGraph.ResumeLayout(False)
        Me.grpGraphOptions.ResumeLayout(False)
        Me.grpGraphOptions.PerformLayout()
        Me.grpGraphType.ResumeLayout(False)
        Me.grpGraphType.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ucrBaseSubDialogue As ucrButtonsSubdialogue
    Friend WithEvents tbOneWayFrequencies As TabControl
    Friend WithEvents tbTable As TabPage
    Friend WithEvents grpTableOptions As GroupBox
    Friend WithEvents ucrChkTotalColumnName As ucrCheck
    Friend WithEvents ucrInputCountsName As ucrInputTextBox
    Friend WithEvents ucrChkMissingValues As ucrCheck
    Friend WithEvents ucrChkBackgroundColour As ucrCheck
    Friend WithEvents ucrChkShowSummary As ucrCheck
    Friend WithEvents tbGraph As TabPage
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents grpGraphOptions As GroupBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblHjust As Label
    Friend WithEvents lblVjust As Label
    Friend WithEvents ucrInputGraphTitle As ucrInputTextBox
    Friend WithEvents ucrInputHorizontalLabels As ucrInputComboBox
    Friend WithEvents ucrInputVerticalLabels As ucrInputComboBox
    Friend WithEvents ucrChkShowModelSummary As ucrCheck
    Friend WithEvents ucrChkShowPercentage As ucrCheck
    Friend WithEvents ucrChkShowCount As ucrCheck
    Friend WithEvents grpGraphType As GroupBox
    Friend WithEvents rdoLine As RadioButton
    Friend WithEvents rdoBar As RadioButton
    Friend WithEvents ucrPnlGraphType As UcrPanel
    Friend WithEvents ucrChkShowValues As ucrCheck
    Friend WithEvents ucrChkStack As ucrCheck
    Friend WithEvents lblGraphTitle As Label
    Friend WithEvents ucrInputTableTitle As ucrInputTextBox
    Friend WithEvents lblNumberOfDecimals As Label
    Friend WithEvents ucrNudDecimalPlaces As ucrNud
End Class
