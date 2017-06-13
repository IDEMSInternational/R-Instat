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
        Me.tbpTwoWayFrequencies = New System.Windows.Forms.TabControl()
        Me.tbpTable = New System.Windows.Forms.TabPage()
        Me.grpTableOptions = New System.Windows.Forms.GroupBox()
        Me.lblNumberOfDecimals = New System.Windows.Forms.Label()
        Me.ucrNudDecimalPlaces = New instat.ucrNud()
        Me.lblGraphTitle = New System.Windows.Forms.Label()
        Me.ucrInputTableTitle = New instat.ucrInputTextBox()
        Me.ucrChkTotalColumnName = New instat.ucrCheck()
        Me.ucrInputTotalsName = New instat.ucrInputTextBox()
        Me.ucrChkMissingValues = New instat.ucrCheck()
        Me.ucrChkBackgroundColour = New instat.ucrCheck()
        Me.ucrChkShowSummary = New instat.ucrCheck()
        Me.tbpGraph = New System.Windows.Forms.TabPage()
        Me.grpGraphOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkStack = New instat.ucrCheck()
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
        Me.tbpTwoWayFrequencies.SuspendLayout()
        Me.tbpTable.SuspendLayout()
        Me.grpTableOptions.SuspendLayout()
        Me.tbpGraph.SuspendLayout()
        Me.grpGraphOptions.SuspendLayout()
        Me.grpGraphType.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpTwoWayFrequencies
        '
        Me.tbpTwoWayFrequencies.Controls.Add(Me.tbpTable)
        Me.tbpTwoWayFrequencies.Controls.Add(Me.tbpGraph)
        Me.tbpTwoWayFrequencies.Location = New System.Drawing.Point(8, 8)
        Me.tbpTwoWayFrequencies.Name = "tbpTwoWayFrequencies"
        Me.tbpTwoWayFrequencies.SelectedIndex = 0
        Me.tbpTwoWayFrequencies.Size = New System.Drawing.Size(321, 283)
        Me.tbpTwoWayFrequencies.TabIndex = 0
        '
        'tbpTable
        '
        Me.tbpTable.Controls.Add(Me.grpTableOptions)
        Me.tbpTable.Location = New System.Drawing.Point(4, 22)
        Me.tbpTable.Name = "tbpTable"
        Me.tbpTable.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTable.Size = New System.Drawing.Size(313, 257)
        Me.tbpTable.TabIndex = 0
        Me.tbpTable.Text = "Table"
        Me.tbpTable.UseVisualStyleBackColor = True
        '
        'grpTableOptions
        '
        Me.grpTableOptions.Controls.Add(Me.lblNumberOfDecimals)
        Me.grpTableOptions.Controls.Add(Me.ucrNudDecimalPlaces)
        Me.grpTableOptions.Controls.Add(Me.lblGraphTitle)
        Me.grpTableOptions.Controls.Add(Me.ucrInputTableTitle)
        Me.grpTableOptions.Controls.Add(Me.ucrChkTotalColumnName)
        Me.grpTableOptions.Controls.Add(Me.ucrInputTotalsName)
        Me.grpTableOptions.Controls.Add(Me.ucrChkMissingValues)
        Me.grpTableOptions.Controls.Add(Me.ucrChkBackgroundColour)
        Me.grpTableOptions.Controls.Add(Me.ucrChkShowSummary)
        Me.grpTableOptions.Location = New System.Drawing.Point(6, 6)
        Me.grpTableOptions.Name = "grpTableOptions"
        Me.grpTableOptions.Size = New System.Drawing.Size(304, 189)
        Me.grpTableOptions.TabIndex = 0
        Me.grpTableOptions.TabStop = False
        Me.grpTableOptions.Text = "More Options"
        '
        'lblNumberOfDecimals
        '
        Me.lblNumberOfDecimals.AutoSize = True
        Me.lblNumberOfDecimals.Location = New System.Drawing.Point(8, 101)
        Me.lblNumberOfDecimals.Name = "lblNumberOfDecimals"
        Me.lblNumberOfDecimals.Size = New System.Drawing.Size(161, 13)
        Me.lblNumberOfDecimals.TabIndex = 3
        Me.lblNumberOfDecimals.Text = "Decimal Places for Percentages:"
        '
        'ucrNudDecimalPlaces
        '
        Me.ucrNudDecimalPlaces.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Location = New System.Drawing.Point(173, 99)
        Me.ucrNudDecimalPlaces.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Name = "ucrNudDecimalPlaces"
        Me.ucrNudDecimalPlaces.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDecimalPlaces.TabIndex = 4
        Me.ucrNudDecimalPlaces.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblGraphTitle
        '
        Me.lblGraphTitle.AutoSize = True
        Me.lblGraphTitle.Location = New System.Drawing.Point(8, 157)
        Me.lblGraphTitle.Name = "lblGraphTitle"
        Me.lblGraphTitle.Size = New System.Drawing.Size(60, 13)
        Me.lblGraphTitle.TabIndex = 7
        Me.lblGraphTitle.Text = "Table Title:"
        '
        'ucrInputTableTitle
        '
        Me.ucrInputTableTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputTableTitle.IsMultiline = False
        Me.ucrInputTableTitle.IsReadOnly = False
        Me.ucrInputTableTitle.Location = New System.Drawing.Point(106, 153)
        Me.ucrInputTableTitle.Name = "ucrInputTableTitle"
        Me.ucrInputTableTitle.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputTableTitle.TabIndex = 8
        '
        'ucrChkTotalColumnName
        '
        Me.ucrChkTotalColumnName.Checked = False
        Me.ucrChkTotalColumnName.Location = New System.Drawing.Point(10, 126)
        Me.ucrChkTotalColumnName.Name = "ucrChkTotalColumnName"
        Me.ucrChkTotalColumnName.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkTotalColumnName.TabIndex = 5
        '
        'ucrInputTotalsName
        '
        Me.ucrInputTotalsName.AddQuotesIfUnrecognised = True
        Me.ucrInputTotalsName.IsMultiline = False
        Me.ucrInputTotalsName.IsReadOnly = False
        Me.ucrInputTotalsName.Location = New System.Drawing.Point(106, 126)
        Me.ucrInputTotalsName.Name = "ucrInputTotalsName"
        Me.ucrInputTotalsName.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputTotalsName.TabIndex = 6
        '
        'ucrChkMissingValues
        '
        Me.ucrChkMissingValues.Checked = False
        Me.ucrChkMissingValues.Location = New System.Drawing.Point(10, 45)
        Me.ucrChkMissingValues.Name = "ucrChkMissingValues"
        Me.ucrChkMissingValues.Size = New System.Drawing.Size(147, 20)
        Me.ucrChkMissingValues.TabIndex = 1
        '
        'ucrChkBackgroundColour
        '
        Me.ucrChkBackgroundColour.Checked = False
        Me.ucrChkBackgroundColour.Location = New System.Drawing.Point(10, 71)
        Me.ucrChkBackgroundColour.Name = "ucrChkBackgroundColour"
        Me.ucrChkBackgroundColour.Size = New System.Drawing.Size(290, 20)
        Me.ucrChkBackgroundColour.TabIndex = 2
        '
        'ucrChkShowSummary
        '
        Me.ucrChkShowSummary.Checked = False
        Me.ucrChkShowSummary.Location = New System.Drawing.Point(10, 19)
        Me.ucrChkShowSummary.Name = "ucrChkShowSummary"
        Me.ucrChkShowSummary.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkShowSummary.TabIndex = 0
        '
        'tbpGraph
        '
        Me.tbpGraph.Controls.Add(Me.grpGraphOptions)
        Me.tbpGraph.Controls.Add(Me.grpGraphType)
        Me.tbpGraph.Location = New System.Drawing.Point(4, 22)
        Me.tbpGraph.Name = "tbpGraph"
        Me.tbpGraph.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpGraph.Size = New System.Drawing.Size(313, 257)
        Me.tbpGraph.TabIndex = 1
        Me.tbpGraph.Text = "Graph"
        Me.tbpGraph.UseVisualStyleBackColor = True
        '
        'grpGraphOptions
        '
        Me.grpGraphOptions.Controls.Add(Me.ucrChkStack)
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
        Me.grpGraphOptions.Size = New System.Drawing.Size(300, 195)
        Me.grpGraphOptions.TabIndex = 1
        Me.grpGraphOptions.TabStop = False
        Me.grpGraphOptions.Text = "Graph Options"
        '
        'ucrChkStack
        '
        Me.ucrChkStack.Checked = False
        Me.ucrChkStack.Location = New System.Drawing.Point(10, 92)
        Me.ucrChkStack.Name = "ucrChkStack"
        Me.ucrChkStack.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkStack.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(10, 169)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(62, 13)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Graph Title:"
        '
        'lblHjust
        '
        Me.lblHjust.AutoSize = True
        Me.lblHjust.Location = New System.Drawing.Point(10, 143)
        Me.lblHjust.Name = "lblHjust"
        Me.lblHjust.Size = New System.Drawing.Size(126, 13)
        Me.lblHjust.TabIndex = 7
        Me.lblHjust.Text = "Horizontal Label Position:"
        '
        'lblVjust
        '
        Me.lblVjust.AutoSize = True
        Me.lblVjust.Location = New System.Drawing.Point(10, 117)
        Me.lblVjust.Name = "lblVjust"
        Me.lblVjust.Size = New System.Drawing.Size(114, 13)
        Me.lblVjust.TabIndex = 4
        Me.lblVjust.Text = "Vertical Label Position:"
        '
        'ucrInputGraphTitle
        '
        Me.ucrInputGraphTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphTitle.IsMultiline = False
        Me.ucrInputGraphTitle.IsReadOnly = False
        Me.ucrInputGraphTitle.Location = New System.Drawing.Point(140, 165)
        Me.ucrInputGraphTitle.Name = "ucrInputGraphTitle"
        Me.ucrInputGraphTitle.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputGraphTitle.TabIndex = 0
        '
        'ucrInputHorizontalLabels
        '
        Me.ucrInputHorizontalLabels.AddQuotesIfUnrecognised = True
        Me.ucrInputHorizontalLabels.IsReadOnly = False
        Me.ucrInputHorizontalLabels.Location = New System.Drawing.Point(140, 139)
        Me.ucrInputHorizontalLabels.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputHorizontalLabels.Name = "ucrInputHorizontalLabels"
        Me.ucrInputHorizontalLabels.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputHorizontalLabels.TabIndex = 8
        '
        'ucrInputVerticalLabels
        '
        Me.ucrInputVerticalLabels.AddQuotesIfUnrecognised = True
        Me.ucrInputVerticalLabels.IsReadOnly = False
        Me.ucrInputVerticalLabels.Location = New System.Drawing.Point(140, 113)
        Me.ucrInputVerticalLabels.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputVerticalLabels.Name = "ucrInputVerticalLabels"
        Me.ucrInputVerticalLabels.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputVerticalLabels.TabIndex = 6
        '
        'ucrChkShowModelSummary
        '
        Me.ucrChkShowModelSummary.Checked = False
        Me.ucrChkShowModelSummary.Location = New System.Drawing.Point(10, 68)
        Me.ucrChkShowModelSummary.Name = "ucrChkShowModelSummary"
        Me.ucrChkShowModelSummary.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkShowModelSummary.TabIndex = 2
        '
        'ucrChkShowPercentage
        '
        Me.ucrChkShowPercentage.Checked = False
        Me.ucrChkShowPercentage.Location = New System.Drawing.Point(10, 20)
        Me.ucrChkShowPercentage.Name = "ucrChkShowPercentage"
        Me.ucrChkShowPercentage.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkShowPercentage.TabIndex = 0
        '
        'ucrChkShowCount
        '
        Me.ucrChkShowCount.Checked = False
        Me.ucrChkShowCount.Location = New System.Drawing.Point(10, 44)
        Me.ucrChkShowCount.Name = "ucrChkShowCount"
        Me.ucrChkShowCount.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkShowCount.TabIndex = 1
        '
        'grpGraphType
        '
        Me.grpGraphType.Controls.Add(Me.rdoLine)
        Me.grpGraphType.Controls.Add(Me.rdoBar)
        Me.grpGraphType.Controls.Add(Me.ucrPnlGraphType)
        Me.grpGraphType.Location = New System.Drawing.Point(6, 6)
        Me.grpGraphType.Name = "grpGraphType"
        Me.grpGraphType.Size = New System.Drawing.Size(300, 48)
        Me.grpGraphType.TabIndex = 0
        Me.grpGraphType.TabStop = False
        Me.grpGraphType.Text = "Type of Graph"
        '
        'rdoLine
        '
        Me.rdoLine.AutoSize = True
        Me.rdoLine.Location = New System.Drawing.Point(167, 19)
        Me.rdoLine.Name = "rdoLine"
        Me.rdoLine.Size = New System.Drawing.Size(77, 17)
        Me.rdoLine.TabIndex = 2
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
        Me.rdoBar.TabIndex = 1
        Me.rdoBar.TabStop = True
        Me.rdoBar.Text = "Bar Graph"
        Me.rdoBar.UseVisualStyleBackColor = True
        '
        'ucrPnlGraphType
        '
        Me.ucrPnlGraphType.Location = New System.Drawing.Point(6, 7)
        Me.ucrPnlGraphType.Name = "ucrPnlGraphType"
        Me.ucrPnlGraphType.Size = New System.Drawing.Size(288, 35)
        Me.ucrPnlGraphType.TabIndex = 0
        '
        'ucrBaseSubDialogue
        '
        Me.ucrBaseSubDialogue.Location = New System.Drawing.Point(98, 297)
        Me.ucrBaseSubDialogue.Name = "ucrBaseSubDialogue"
        Me.ucrBaseSubDialogue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ucrBaseSubDialogue.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSubDialogue.TabIndex = 0
        '
        'sdgTwoWayFrequencies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 328)
        Me.Controls.Add(Me.tbpTwoWayFrequencies)
        Me.Controls.Add(Me.ucrBaseSubDialogue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgTwoWayFrequencies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frequency Table & Graph Options"
        Me.tbpTwoWayFrequencies.ResumeLayout(False)
        Me.tbpTable.ResumeLayout(False)
        Me.grpTableOptions.ResumeLayout(False)
        Me.grpTableOptions.PerformLayout()
        Me.tbpGraph.ResumeLayout(False)
        Me.grpGraphOptions.ResumeLayout(False)
        Me.grpGraphOptions.PerformLayout()
        Me.grpGraphType.ResumeLayout(False)
        Me.grpGraphType.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ucrBaseSubDialogue As ucrButtonsSubdialogue
    Friend WithEvents tbpTwoWayFrequencies As TabControl
    Friend WithEvents tbpTable As TabPage
    Friend WithEvents grpTableOptions As GroupBox
    Friend WithEvents ucrChkTotalColumnName As ucrCheck
    Friend WithEvents ucrInputTotalsName As ucrInputTextBox
    Friend WithEvents ucrChkMissingValues As ucrCheck
    Friend WithEvents ucrChkBackgroundColour As ucrCheck
    Friend WithEvents ucrChkShowSummary As ucrCheck
    Friend WithEvents tbpGraph As TabPage
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
    Friend WithEvents ucrChkStack As ucrCheck
    Friend WithEvents lblGraphTitle As Label
    Friend WithEvents ucrInputTableTitle As ucrInputTextBox
    Friend WithEvents lblNumberOfDecimals As Label
    Friend WithEvents ucrNudDecimalPlaces As ucrNud
End Class