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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbGraph = New System.Windows.Forms.TabPage()
        Me.grpGraphOptions = New System.Windows.Forms.GroupBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHjust = New System.Windows.Forms.Label()
        Me.lblVjust = New System.Windows.Forms.Label()
        Me.grpGraphType = New System.Windows.Forms.GroupBox()
        Me.rdoLine = New System.Windows.Forms.RadioButton()
        Me.rdoDot = New System.Windows.Forms.RadioButton()
        Me.rdoBar = New System.Windows.Forms.RadioButton()
        Me.ucrNudDecimalPlaces = New instat.ucrNud()
        Me.ucrChkOmitZero = New instat.ucrCheck()
        Me.ucrChkHighlightedRows = New instat.ucrCheck()
        Me.ucrChkMedian = New instat.ucrCheck()
        Me.ucrChkShowSummary = New instat.ucrCheck()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrInputGraphTitle = New instat.ucrInputTextBox()
        Me.ucrInputHorizontalLabels = New instat.ucrInputComboBox()
        Me.ucrInputVerticalLabels = New instat.ucrInputComboBox()
        Me.ucrChkShowMissing = New instat.ucrCheck()
        Me.ucrChkShowPercentage = New instat.ucrCheck()
        Me.ucrChkShowCount = New instat.ucrCheck()
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
        Me.tbOneWayFrequencies.Size = New System.Drawing.Size(352, 308)
        Me.tbOneWayFrequencies.TabIndex = 1
        '
        'tbTable
        '
        Me.tbTable.Controls.Add(Me.grpTableOptions)
        Me.tbTable.Location = New System.Drawing.Point(4, 22)
        Me.tbTable.Name = "tbTable"
        Me.tbTable.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTable.Size = New System.Drawing.Size(344, 282)
        Me.tbTable.TabIndex = 0
        Me.tbTable.Text = "Table"
        Me.tbTable.UseVisualStyleBackColor = True
        '
        'grpTableOptions
        '
        Me.grpTableOptions.Controls.Add(Me.Label1)
        Me.grpTableOptions.Controls.Add(Me.ucrNudDecimalPlaces)
        Me.grpTableOptions.Controls.Add(Me.ucrChkOmitZero)
        Me.grpTableOptions.Controls.Add(Me.ucrChkHighlightedRows)
        Me.grpTableOptions.Controls.Add(Me.ucrChkMedian)
        Me.grpTableOptions.Controls.Add(Me.ucrChkShowSummary)
        Me.grpTableOptions.Location = New System.Drawing.Point(17, 6)
        Me.grpTableOptions.Name = "grpTableOptions"
        Me.grpTableOptions.Size = New System.Drawing.Size(345, 151)
        Me.grpTableOptions.TabIndex = 21
        Me.grpTableOptions.TabStop = False
        Me.grpTableOptions.Text = "More Options"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Decimal places for percentages:"
        '
        'tbGraph
        '
        Me.tbGraph.Controls.Add(Me.ucrSaveGraph)
        Me.tbGraph.Controls.Add(Me.grpGraphOptions)
        Me.tbGraph.Controls.Add(Me.grpGraphType)
        Me.tbGraph.Location = New System.Drawing.Point(4, 22)
        Me.tbGraph.Name = "tbGraph"
        Me.tbGraph.Padding = New System.Windows.Forms.Padding(3)
        Me.tbGraph.Size = New System.Drawing.Size(344, 282)
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
        Me.grpGraphOptions.TabIndex = 37
        Me.grpGraphOptions.TabStop = False
        Me.grpGraphOptions.Text = "Graph Options"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(13, 154)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(62, 13)
        Me.lblTitle.TabIndex = 58
        Me.lblTitle.Text = "Graph Title:"
        '
        'lblHjust
        '
        Me.lblHjust.AutoSize = True
        Me.lblHjust.Location = New System.Drawing.Point(13, 131)
        Me.lblHjust.Name = "lblHjust"
        Me.lblHjust.Size = New System.Drawing.Size(126, 13)
        Me.lblHjust.TabIndex = 57
        Me.lblHjust.Text = "Horizontal Label Position:"
        '
        'lblVjust
        '
        Me.lblVjust.AutoSize = True
        Me.lblVjust.Location = New System.Drawing.Point(13, 103)
        Me.lblVjust.Name = "lblVjust"
        Me.lblVjust.Size = New System.Drawing.Size(114, 13)
        Me.lblVjust.TabIndex = 55
        Me.lblVjust.Text = "Vertical Label Position:"
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
        Me.grpGraphType.TabIndex = 33
        Me.grpGraphType.TabStop = False
        Me.grpGraphType.Text = "Type of Graph"
        '
        'rdoLine
        '
        Me.rdoLine.AutoSize = True
        Me.rdoLine.Location = New System.Drawing.Point(242, 19)
        Me.rdoLine.Name = "rdoLine"
        Me.rdoLine.Size = New System.Drawing.Size(77, 17)
        Me.rdoLine.TabIndex = 7
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
        Me.rdoDot.TabIndex = 6
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
        Me.rdoBar.TabIndex = 5
        Me.rdoBar.TabStop = True
        Me.rdoBar.Text = "Bar Graph"
        Me.rdoBar.UseVisualStyleBackColor = True
        '
        'ucrNudDecimalPlaces
        '
        Me.ucrNudDecimalPlaces.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Location = New System.Drawing.Point(179, 114)
        Me.ucrNudDecimalPlaces.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Name = "ucrNudDecimalPlaces"
        Me.ucrNudDecimalPlaces.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDecimalPlaces.TabIndex = 50
        Me.ucrNudDecimalPlaces.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkOmitZero
        '
        Me.ucrChkOmitZero.Checked = False
        Me.ucrChkOmitZero.Location = New System.Drawing.Point(8, 88)
        Me.ucrChkOmitZero.Name = "ucrChkOmitZero"
        Me.ucrChkOmitZero.Size = New System.Drawing.Size(262, 20)
        Me.ucrChkOmitZero.TabIndex = 23
        '
        'ucrChkHighlightedRows
        '
        Me.ucrChkHighlightedRows.Checked = False
        Me.ucrChkHighlightedRows.Location = New System.Drawing.Point(8, 42)
        Me.ucrChkHighlightedRows.Name = "ucrChkHighlightedRows"
        Me.ucrChkHighlightedRows.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkHighlightedRows.TabIndex = 22
        '
        'ucrChkMedian
        '
        Me.ucrChkMedian.Checked = False
        Me.ucrChkMedian.Location = New System.Drawing.Point(8, 66)
        Me.ucrChkMedian.Name = "ucrChkMedian"
        Me.ucrChkMedian.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkMedian.TabIndex = 21
        '
        'ucrChkShowSummary
        '
        Me.ucrChkShowSummary.Checked = False
        Me.ucrChkShowSummary.Location = New System.Drawing.Point(8, 18)
        Me.ucrChkShowSummary.Name = "ucrChkShowSummary"
        Me.ucrChkShowSummary.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkShowSummary.TabIndex = 19
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(19, 252)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(294, 24)
        Me.ucrSaveGraph.TabIndex = 39
        '
        'ucrInputGraphTitle
        '
        Me.ucrInputGraphTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphTitle.IsMultiline = False
        Me.ucrInputGraphTitle.IsReadOnly = False
        Me.ucrInputGraphTitle.Location = New System.Drawing.Point(165, 155)
        Me.ucrInputGraphTitle.Name = "ucrInputGraphTitle"
        Me.ucrInputGraphTitle.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputGraphTitle.TabIndex = 54
        '
        'ucrInputHorizontalLabels
        '
        Me.ucrInputHorizontalLabels.AddQuotesIfUnrecognised = True
        Me.ucrInputHorizontalLabels.IsReadOnly = False
        Me.ucrInputHorizontalLabels.Location = New System.Drawing.Point(165, 125)
        Me.ucrInputHorizontalLabels.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputHorizontalLabels.Name = "ucrInputHorizontalLabels"
        Me.ucrInputHorizontalLabels.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputHorizontalLabels.TabIndex = 51
        '
        'ucrInputVerticalLabels
        '
        Me.ucrInputVerticalLabels.AddQuotesIfUnrecognised = True
        Me.ucrInputVerticalLabels.IsReadOnly = False
        Me.ucrInputVerticalLabels.Location = New System.Drawing.Point(165, 99)
        Me.ucrInputVerticalLabels.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputVerticalLabels.Name = "ucrInputVerticalLabels"
        Me.ucrInputVerticalLabels.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputVerticalLabels.TabIndex = 50
        '
        'ucrChkShowMissing
        '
        Me.ucrChkShowMissing.Checked = False
        Me.ucrChkShowMissing.Location = New System.Drawing.Point(13, 75)
        Me.ucrChkShowMissing.Name = "ucrChkShowMissing"
        Me.ucrChkShowMissing.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkShowMissing.TabIndex = 28
        '
        'ucrChkShowPercentage
        '
        Me.ucrChkShowPercentage.Checked = False
        Me.ucrChkShowPercentage.Location = New System.Drawing.Point(13, 19)
        Me.ucrChkShowPercentage.Name = "ucrChkShowPercentage"
        Me.ucrChkShowPercentage.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkShowPercentage.TabIndex = 20
        '
        'ucrChkShowCount
        '
        Me.ucrChkShowCount.Checked = False
        Me.ucrChkShowCount.Location = New System.Drawing.Point(13, 47)
        Me.ucrChkShowCount.Name = "ucrChkShowCount"
        Me.ucrChkShowCount.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkShowCount.TabIndex = 18
        '
        'ucrPnlGraphType
        '
        Me.ucrPnlGraphType.Location = New System.Drawing.Point(6, 7)
        Me.ucrPnlGraphType.Name = "ucrPnlGraphType"
        Me.ucrPnlGraphType.Size = New System.Drawing.Size(323, 44)
        Me.ucrPnlGraphType.TabIndex = 4
        '
        'ucrBaseSubDialogue
        '
        Me.ucrBaseSubDialogue.Location = New System.Drawing.Point(93, 325)
        Me.ucrBaseSubDialogue.Name = "ucrBaseSubDialogue"
        Me.ucrBaseSubDialogue.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSubDialogue.TabIndex = 0
        '
        'sdgOneWayFrequencies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 368)
        Me.Controls.Add(Me.tbOneWayFrequencies)
        Me.Controls.Add(Me.ucrBaseSubDialogue)
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

    Friend WithEvents ucrBaseSubDialogue As ucrButtonsSubdialogue
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
    Friend WithEvents ucrChkOmitZero As ucrCheck
    Friend WithEvents ucrNudDecimalPlaces As ucrNud
    Friend WithEvents grpGraphType As GroupBox
    Friend WithEvents ucrPnlGraphType As UcrPanel
    Friend WithEvents rdoLine As RadioButton
    Friend WithEvents rdoDot As RadioButton
    Friend WithEvents rdoBar As RadioButton
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblHjust As Label
    Friend WithEvents lblVjust As Label
    Friend WithEvents Label1 As Label
End Class
