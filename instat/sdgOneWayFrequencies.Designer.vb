<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgOneWayFrequencies
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
        Me.lblOmitZero = New System.Windows.Forms.Label()
        Me.ucrInputOmitZero = New instat.ucrInputComboBox()
        Me.ucrChkCountName = New instat.ucrCheck()
        Me.ucrInputCountsName = New instat.ucrInputTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrNudDecimalPlaces = New instat.ucrNud()
        Me.ucrChkHighlightedRows = New instat.ucrCheck()
        Me.ucrChkMedian = New instat.ucrCheck()
        Me.ucrChkShowSummary = New instat.ucrCheck()
        Me.tbGraph = New System.Windows.Forms.TabPage()
        Me.grpGraphOptions = New System.Windows.Forms.GroupBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHjust = New System.Windows.Forms.Label()
        Me.lblVjust = New System.Windows.Forms.Label()
        Me.ucrInputGraphTitle = New instat.ucrInputTextBox()
        Me.ucrInputHorizontalLabels = New instat.ucrInputComboBox()
        Me.ucrInputVerticalLabels = New instat.ucrInputComboBox()
        Me.ucrChkShowMissing = New instat.ucrCheck()
        Me.ucrChkShowPercentage = New instat.ucrCheck()
        Me.ucrChkShowCount = New instat.ucrCheck()
        Me.grpGraphType = New System.Windows.Forms.GroupBox()
        Me.rdoLine = New System.Windows.Forms.RadioButton()
        Me.rdoDot = New System.Windows.Forms.RadioButton()
        Me.rdoBar = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGraphType = New instat.UcrPanel()
        Me.ucrBaseOneWayFrequencies = New instat.ucrButtonsSubdialogue()
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
        Me.tbOneWayFrequencies.Location = New System.Drawing.Point(7, 4)
        Me.tbOneWayFrequencies.Name = "tbOneWayFrequencies"
        Me.tbOneWayFrequencies.SelectedIndex = 0
        Me.tbOneWayFrequencies.Size = New System.Drawing.Size(352, 272)
        Me.tbOneWayFrequencies.TabIndex = 0
        '
        'tbTable
        '
        Me.tbTable.Controls.Add(Me.grpTableOptions)
        Me.tbTable.Location = New System.Drawing.Point(4, 22)
        Me.tbTable.Name = "tbTable"
        Me.tbTable.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTable.Size = New System.Drawing.Size(344, 246)
        Me.tbTable.TabIndex = 0
        Me.tbTable.Text = "Table"
        Me.tbTable.UseVisualStyleBackColor = True
        '
        'grpTableOptions
        '
        Me.grpTableOptions.Controls.Add(Me.lblOmitZero)
        Me.grpTableOptions.Controls.Add(Me.ucrInputOmitZero)
        Me.grpTableOptions.Controls.Add(Me.ucrChkCountName)
        Me.grpTableOptions.Controls.Add(Me.ucrInputCountsName)
        Me.grpTableOptions.Controls.Add(Me.Label1)
        Me.grpTableOptions.Controls.Add(Me.ucrNudDecimalPlaces)
        Me.grpTableOptions.Controls.Add(Me.ucrChkHighlightedRows)
        Me.grpTableOptions.Controls.Add(Me.ucrChkMedian)
        Me.grpTableOptions.Controls.Add(Me.ucrChkShowSummary)
        Me.grpTableOptions.Location = New System.Drawing.Point(6, 7)
        Me.grpTableOptions.Name = "grpTableOptions"
        Me.grpTableOptions.Size = New System.Drawing.Size(327, 177)
        Me.grpTableOptions.TabIndex = 0
        Me.grpTableOptions.TabStop = False
        Me.grpTableOptions.Text = "More Options"
        '
        'lblOmitZero
        '
        Me.lblOmitZero.AutoSize = True
        Me.lblOmitZero.Location = New System.Drawing.Point(9, 121)
        Me.lblOmitZero.Name = "lblOmitZero"
        Me.lblOmitZero.Size = New System.Drawing.Size(145, 13)
        Me.lblOmitZero.TabIndex = 5
        Me.lblOmitZero.Text = "Omit Zero Counts from Table:"
        '
        'ucrInputOmitZero
        '
        Me.ucrInputOmitZero.AddQuotesIfUnrecognised = True
        Me.ucrInputOmitZero.IsReadOnly = False
        Me.ucrInputOmitZero.Location = New System.Drawing.Point(164, 116)
        Me.ucrInputOmitZero.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputOmitZero.Name = "ucrInputOmitZero"
        Me.ucrInputOmitZero.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputOmitZero.TabIndex = 6
        '
        'ucrChkCountName
        '
        Me.ucrChkCountName.Checked = False
        Me.ucrChkCountName.Location = New System.Drawing.Point(12, 93)
        Me.ucrChkCountName.Name = "ucrChkCountName"
        Me.ucrChkCountName.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkCountName.TabIndex = 3
        '
        'ucrInputCountsName
        '
        Me.ucrInputCountsName.AddQuotesIfUnrecognised = True
        Me.ucrInputCountsName.IsMultiline = False
        Me.ucrInputCountsName.IsReadOnly = False
        Me.ucrInputCountsName.Location = New System.Drawing.Point(112, 92)
        Me.ucrInputCountsName.Name = "ucrInputCountsName"
        Me.ucrInputCountsName.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputCountsName.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Decimal Places for Percentages:"
        '
        'ucrNudDecimalPlaces
        '
        Me.ucrNudDecimalPlaces.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Location = New System.Drawing.Point(199, 144)
        Me.ucrNudDecimalPlaces.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Name = "ucrNudDecimalPlaces"
        Me.ucrNudDecimalPlaces.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDecimalPlaces.TabIndex = 8
        Me.ucrNudDecimalPlaces.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkHighlightedRows
        '
        Me.ucrChkHighlightedRows.Checked = False
        Me.ucrChkHighlightedRows.Location = New System.Drawing.Point(12, 43)
        Me.ucrChkHighlightedRows.Name = "ucrChkHighlightedRows"
        Me.ucrChkHighlightedRows.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkHighlightedRows.TabIndex = 1
        '
        'ucrChkMedian
        '
        Me.ucrChkMedian.Checked = False
        Me.ucrChkMedian.Location = New System.Drawing.Point(12, 68)
        Me.ucrChkMedian.Name = "ucrChkMedian"
        Me.ucrChkMedian.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkMedian.TabIndex = 2
        '
        'ucrChkShowSummary
        '
        Me.ucrChkShowSummary.Checked = False
        Me.ucrChkShowSummary.Location = New System.Drawing.Point(12, 18)
        Me.ucrChkShowSummary.Name = "ucrChkShowSummary"
        Me.ucrChkShowSummary.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkShowSummary.TabIndex = 0
        '
        'tbGraph
        '
        Me.tbGraph.Controls.Add(Me.grpGraphOptions)
        Me.tbGraph.Controls.Add(Me.grpGraphType)
        Me.tbGraph.Location = New System.Drawing.Point(4, 22)
        Me.tbGraph.Name = "tbGraph"
        Me.tbGraph.Padding = New System.Windows.Forms.Padding(3)
        Me.tbGraph.Size = New System.Drawing.Size(344, 246)
        Me.tbGraph.TabIndex = 1
        Me.tbGraph.Text = "Graph"
        Me.tbGraph.UseVisualStyleBackColor = True
        '
        'grpGraphOptions
        '
        Me.grpGraphOptions.Controls.Add(Me.lblTitle)
        Me.grpGraphOptions.Controls.Add(Me.lblHjust)
        Me.grpGraphOptions.Controls.Add(Me.lblVjust)
        Me.grpGraphOptions.Controls.Add(Me.ucrInputGraphTitle)
        Me.grpGraphOptions.Controls.Add(Me.ucrInputHorizontalLabels)
        Me.grpGraphOptions.Controls.Add(Me.ucrInputVerticalLabels)
        Me.grpGraphOptions.Controls.Add(Me.ucrChkShowMissing)
        Me.grpGraphOptions.Controls.Add(Me.ucrChkShowPercentage)
        Me.grpGraphOptions.Controls.Add(Me.ucrChkShowCount)
        Me.grpGraphOptions.Location = New System.Drawing.Point(6, 59)
        Me.grpGraphOptions.Name = "grpGraphOptions"
        Me.grpGraphOptions.Size = New System.Drawing.Size(329, 184)
        Me.grpGraphOptions.TabIndex = 1
        Me.grpGraphOptions.TabStop = False
        Me.grpGraphOptions.Text = "Graph Options"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 155)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(62, 13)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "Graph Title:"
        '
        'lblHjust
        '
        Me.lblHjust.AutoSize = True
        Me.lblHjust.Location = New System.Drawing.Point(12, 127)
        Me.lblHjust.Name = "lblHjust"
        Me.lblHjust.Size = New System.Drawing.Size(126, 13)
        Me.lblHjust.TabIndex = 5
        Me.lblHjust.Text = "Horizontal Label Position:"
        '
        'lblVjust
        '
        Me.lblVjust.AutoSize = True
        Me.lblVjust.Location = New System.Drawing.Point(12, 99)
        Me.lblVjust.Name = "lblVjust"
        Me.lblVjust.Size = New System.Drawing.Size(114, 13)
        Me.lblVjust.TabIndex = 3
        Me.lblVjust.Text = "Vertical Label Position:"
        '
        'ucrInputGraphTitle
        '
        Me.ucrInputGraphTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphTitle.IsMultiline = False
        Me.ucrInputGraphTitle.IsReadOnly = False
        Me.ucrInputGraphTitle.Location = New System.Drawing.Point(141, 151)
        Me.ucrInputGraphTitle.Name = "ucrInputGraphTitle"
        Me.ucrInputGraphTitle.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputGraphTitle.TabIndex = 8
        '
        'ucrInputHorizontalLabels
        '
        Me.ucrInputHorizontalLabels.AddQuotesIfUnrecognised = True
        Me.ucrInputHorizontalLabels.IsReadOnly = False
        Me.ucrInputHorizontalLabels.Location = New System.Drawing.Point(141, 123)
        Me.ucrInputHorizontalLabels.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputHorizontalLabels.Name = "ucrInputHorizontalLabels"
        Me.ucrInputHorizontalLabels.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputHorizontalLabels.TabIndex = 6
        '
        'ucrInputVerticalLabels
        '
        Me.ucrInputVerticalLabels.AddQuotesIfUnrecognised = True
        Me.ucrInputVerticalLabels.IsReadOnly = False
        Me.ucrInputVerticalLabels.Location = New System.Drawing.Point(141, 95)
        Me.ucrInputVerticalLabels.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputVerticalLabels.Name = "ucrInputVerticalLabels"
        Me.ucrInputVerticalLabels.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputVerticalLabels.TabIndex = 4
        '
        'ucrChkShowMissing
        '
        Me.ucrChkShowMissing.Checked = False
        Me.ucrChkShowMissing.Location = New System.Drawing.Point(12, 73)
        Me.ucrChkShowMissing.Name = "ucrChkShowMissing"
        Me.ucrChkShowMissing.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkShowMissing.TabIndex = 2
        '
        'ucrChkShowPercentage
        '
        Me.ucrChkShowPercentage.Checked = False
        Me.ucrChkShowPercentage.Location = New System.Drawing.Point(12, 19)
        Me.ucrChkShowPercentage.Name = "ucrChkShowPercentage"
        Me.ucrChkShowPercentage.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkShowPercentage.TabIndex = 0
        '
        'ucrChkShowCount
        '
        Me.ucrChkShowCount.Checked = False
        Me.ucrChkShowCount.Location = New System.Drawing.Point(12, 46)
        Me.ucrChkShowCount.Name = "ucrChkShowCount"
        Me.ucrChkShowCount.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkShowCount.TabIndex = 1
        '
        'grpGraphType
        '
        Me.grpGraphType.Controls.Add(Me.rdoLine)
        Me.grpGraphType.Controls.Add(Me.rdoDot)
        Me.grpGraphType.Controls.Add(Me.rdoBar)
        Me.grpGraphType.Controls.Add(Me.ucrPnlGraphType)
        Me.grpGraphType.Location = New System.Drawing.Point(6, 6)
        Me.grpGraphType.Name = "grpGraphType"
        Me.grpGraphType.Size = New System.Drawing.Size(327, 48)
        Me.grpGraphType.TabIndex = 0
        Me.grpGraphType.TabStop = False
        Me.grpGraphType.Text = "Type of Graph"
        '
        'rdoLine
        '
        Me.rdoLine.AutoSize = True
        Me.rdoLine.Location = New System.Drawing.Point(242, 19)
        Me.rdoLine.Name = "rdoLine"
        Me.rdoLine.Size = New System.Drawing.Size(77, 17)
        Me.rdoLine.TabIndex = 3
        Me.rdoLine.TabStop = True
        Me.rdoLine.Text = "Line Graph"
        Me.rdoLine.UseVisualStyleBackColor = True
        '
        'rdoDot
        '
        Me.rdoDot.AutoSize = True
        Me.rdoDot.Location = New System.Drawing.Point(118, 19)
        Me.rdoDot.Name = "rdoDot"
        Me.rdoDot.Size = New System.Drawing.Size(74, 17)
        Me.rdoDot.TabIndex = 2
        Me.rdoDot.TabStop = True
        Me.rdoDot.Text = "Dot Graph"
        Me.rdoDot.UseVisualStyleBackColor = True
        '
        'rdoBar
        '
        Me.rdoBar.AutoSize = True
        Me.rdoBar.Location = New System.Drawing.Point(6, 19)
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
        Me.ucrPnlGraphType.Size = New System.Drawing.Size(323, 44)
        Me.ucrPnlGraphType.TabIndex = 0
        '
        'ucrBaseOneWayFrequencies
        '
        Me.ucrBaseOneWayFrequencies.Location = New System.Drawing.Point(111, 288)
        Me.ucrBaseOneWayFrequencies.Name = "ucrBaseOneWayFrequencies"
        Me.ucrBaseOneWayFrequencies.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseOneWayFrequencies.TabIndex = 1
        '
        'sdgOneWayFrequencies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 323)
        Me.Controls.Add(Me.tbOneWayFrequencies)
        Me.Controls.Add(Me.ucrBaseOneWayFrequencies)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneWayFrequencies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Way Frequencies Options"
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

    Friend WithEvents ucrBaseOneWayFrequencies As ucrButtonsSubdialogue
    Friend WithEvents tbOneWayFrequencies As TabControl
    Friend WithEvents tbTable As TabPage
    Friend WithEvents grpTableOptions As GroupBox
    Friend WithEvents ucrChkHighlightedRows As ucrCheck
    Friend WithEvents ucrChkMedian As ucrCheck
    Friend WithEvents ucrChkShowSummary As ucrCheck
    Friend WithEvents tbGraph As TabPage
    Friend WithEvents grpGraphOptions As GroupBox
    Friend WithEvents ucrChkShowMissing As ucrCheck
    Friend WithEvents ucrChkShowPercentage As ucrCheck
    Friend WithEvents ucrChkShowCount As ucrCheck
    Friend WithEvents ucrInputHorizontalLabels As ucrInputComboBox
    Friend WithEvents ucrInputVerticalLabels As ucrInputComboBox
    Friend WithEvents ucrInputGraphTitle As ucrInputTextBox
    Friend WithEvents ucrNudDecimalPlaces As ucrNud
    Friend WithEvents grpGraphType As GroupBox
    Friend WithEvents ucrPnlGraphType As UcrPanel
    Friend WithEvents rdoLine As RadioButton
    Friend WithEvents rdoDot As RadioButton
    Friend WithEvents rdoBar As RadioButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblHjust As Label
    Friend WithEvents lblVjust As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrInputCountsName As ucrInputTextBox
    Friend WithEvents ucrChkCountName As ucrCheck
    Friend WithEvents lblOmitZero As Label
    Friend WithEvents ucrInputOmitZero As ucrInputComboBox
End Class
