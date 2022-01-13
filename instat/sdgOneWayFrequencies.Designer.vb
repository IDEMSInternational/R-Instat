' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

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
        Me.tbpOneWayFrequencies = New System.Windows.Forms.TabControl()
        Me.tbpTable = New System.Windows.Forms.TabPage()
        Me.grpShowMissingFrequencies = New System.Windows.Forms.GroupBox()
        Me.rdoShowMissingAuto = New System.Windows.Forms.RadioButton()
        Me.rdoShowMissingFalse = New System.Windows.Forms.RadioButton()
        Me.rdoShowMissingTrue = New System.Windows.Forms.RadioButton()
        Me.ucrPnlShowMissingFreq = New instat.UcrPanel()
        Me.grpTableOptions = New System.Windows.Forms.GroupBox()
        Me.lblTableTitle = New System.Windows.Forms.Label()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.ucrChkShowStrings = New instat.ucrCheck()
        Me.tbpGraph = New System.Windows.Forms.TabPage()
        Me.grpGraphOptions = New System.Windows.Forms.GroupBox()
        Me.ucrNudSize = New instat.ucrNud()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.ucrInputColor = New instat.ucrInputComboBox()
        Me.lblColor = New System.Windows.Forms.Label()
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
        Me.rdoViolin = New System.Windows.Forms.RadioButton()
        Me.rdoHistogram = New System.Windows.Forms.RadioButton()
        Me.rdoBoxplot = New System.Windows.Forms.RadioButton()
        Me.rdoDensity = New System.Windows.Forms.RadioButton()
        Me.rdoLine = New System.Windows.Forms.RadioButton()
        Me.rdoDot = New System.Windows.Forms.RadioButton()
        Me.rdoBar = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGraphType = New instat.UcrPanel()
        Me.ucrBaseOneWayFrequencies = New instat.ucrButtonsSubdialogue()
        Me.tbpOneWayFrequencies.SuspendLayout()
        Me.tbpTable.SuspendLayout()
        Me.grpShowMissingFrequencies.SuspendLayout()
        Me.grpTableOptions.SuspendLayout()
        Me.tbpGraph.SuspendLayout()
        Me.grpGraphOptions.SuspendLayout()
        Me.grpGraphType.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpOneWayFrequencies
        '
        Me.tbpOneWayFrequencies.Controls.Add(Me.tbpTable)
        Me.tbpOneWayFrequencies.Controls.Add(Me.tbpGraph)
        Me.tbpOneWayFrequencies.Location = New System.Drawing.Point(7, 4)
        Me.tbpOneWayFrequencies.Name = "tbpOneWayFrequencies"
        Me.tbpOneWayFrequencies.SelectedIndex = 0
        Me.tbpOneWayFrequencies.Size = New System.Drawing.Size(352, 272)
        Me.tbpOneWayFrequencies.TabIndex = 0
        '
        'tbpTable
        '
        Me.tbpTable.Controls.Add(Me.grpShowMissingFrequencies)
        Me.tbpTable.Controls.Add(Me.grpTableOptions)
        Me.tbpTable.Location = New System.Drawing.Point(4, 22)
        Me.tbpTable.Name = "tbpTable"
        Me.tbpTable.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTable.Size = New System.Drawing.Size(344, 246)
        Me.tbpTable.TabIndex = 0
        Me.tbpTable.Text = "Table"
        Me.tbpTable.UseVisualStyleBackColor = True
        '
        'grpShowMissingFrequencies
        '
        Me.grpShowMissingFrequencies.Controls.Add(Me.rdoShowMissingAuto)
        Me.grpShowMissingFrequencies.Controls.Add(Me.rdoShowMissingFalse)
        Me.grpShowMissingFrequencies.Controls.Add(Me.rdoShowMissingTrue)
        Me.grpShowMissingFrequencies.Controls.Add(Me.ucrPnlShowMissingFreq)
        Me.grpShowMissingFrequencies.Location = New System.Drawing.Point(3, 98)
        Me.grpShowMissingFrequencies.Name = "grpShowMissingFrequencies"
        Me.grpShowMissingFrequencies.Size = New System.Drawing.Size(234, 97)
        Me.grpShowMissingFrequencies.TabIndex = 1
        Me.grpShowMissingFrequencies.TabStop = False
        Me.grpShowMissingFrequencies.Text = "Show Missing Frequencies"
        '
        'rdoShowMissingAuto
        '
        Me.rdoShowMissingAuto.AutoSize = True
        Me.rdoShowMissingAuto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoShowMissingAuto.Location = New System.Drawing.Point(7, 70)
        Me.rdoShowMissingAuto.Name = "rdoShowMissingAuto"
        Me.rdoShowMissingAuto.Size = New System.Drawing.Size(47, 17)
        Me.rdoShowMissingAuto.TabIndex = 4
        Me.rdoShowMissingAuto.TabStop = True
        Me.rdoShowMissingAuto.Text = "Auto"
        Me.rdoShowMissingAuto.UseVisualStyleBackColor = True
        '
        'rdoShowMissingFalse
        '
        Me.rdoShowMissingFalse.AutoSize = True
        Me.rdoShowMissingFalse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoShowMissingFalse.Location = New System.Drawing.Point(7, 45)
        Me.rdoShowMissingFalse.Name = "rdoShowMissingFalse"
        Me.rdoShowMissingFalse.Size = New System.Drawing.Size(50, 17)
        Me.rdoShowMissingFalse.TabIndex = 3
        Me.rdoShowMissingFalse.TabStop = True
        Me.rdoShowMissingFalse.Text = "False"
        Me.rdoShowMissingFalse.UseVisualStyleBackColor = True
        '
        'rdoShowMissingTrue
        '
        Me.rdoShowMissingTrue.AutoSize = True
        Me.rdoShowMissingTrue.Location = New System.Drawing.Point(6, 20)
        Me.rdoShowMissingTrue.Name = "rdoShowMissingTrue"
        Me.rdoShowMissingTrue.Size = New System.Drawing.Size(47, 17)
        Me.rdoShowMissingTrue.TabIndex = 2
        Me.rdoShowMissingTrue.TabStop = True
        Me.rdoShowMissingTrue.Text = "True"
        Me.rdoShowMissingTrue.UseVisualStyleBackColor = True
        '
        'ucrPnlShowMissingFreq
        '
        Me.ucrPnlShowMissingFreq.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlShowMissingFreq.Location = New System.Drawing.Point(6, 19)
        Me.ucrPnlShowMissingFreq.Name = "ucrPnlShowMissingFreq"
        Me.ucrPnlShowMissingFreq.Size = New System.Drawing.Size(187, 68)
        Me.ucrPnlShowMissingFreq.TabIndex = 2
        '
        'grpTableOptions
        '
        Me.grpTableOptions.Controls.Add(Me.lblTableTitle)
        Me.grpTableOptions.Controls.Add(Me.ucrInputTitle)
        Me.grpTableOptions.Controls.Add(Me.ucrChkShowStrings)
        Me.grpTableOptions.Location = New System.Drawing.Point(3, 6)
        Me.grpTableOptions.Name = "grpTableOptions"
        Me.grpTableOptions.Size = New System.Drawing.Size(236, 92)
        Me.grpTableOptions.TabIndex = 0
        Me.grpTableOptions.TabStop = False
        Me.grpTableOptions.Text = "More Options"
        '
        'lblTableTitle
        '
        Me.lblTableTitle.AutoSize = True
        Me.lblTableTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTableTitle.Location = New System.Drawing.Point(12, 57)
        Me.lblTableTitle.Name = "lblTableTitle"
        Me.lblTableTitle.Size = New System.Drawing.Size(60, 13)
        Me.lblTableTitle.TabIndex = 1
        Me.lblTableTitle.Text = "Table Title:"
        '
        'ucrInputTitle
        '
        Me.ucrInputTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputTitle.AutoSize = True
        Me.ucrInputTitle.IsMultiline = False
        Me.ucrInputTitle.IsReadOnly = False
        Me.ucrInputTitle.Location = New System.Drawing.Point(97, 60)
        Me.ucrInputTitle.Name = "ucrInputTitle"
        Me.ucrInputTitle.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputTitle.TabIndex = 2
        '
        'ucrChkShowStrings
        '
        Me.ucrChkShowStrings.AutoSize = True
        Me.ucrChkShowStrings.Checked = False
        Me.ucrChkShowStrings.Location = New System.Drawing.Point(12, 22)
        Me.ucrChkShowStrings.Name = "ucrChkShowStrings"
        Me.ucrChkShowStrings.Size = New System.Drawing.Size(201, 23)
        Me.ucrChkShowStrings.TabIndex = 0
        '
        'tbpGraph
        '
        Me.tbpGraph.Controls.Add(Me.grpGraphOptions)
        Me.tbpGraph.Controls.Add(Me.grpGraphType)
        Me.tbpGraph.Location = New System.Drawing.Point(4, 22)
        Me.tbpGraph.Name = "tbpGraph"
        Me.tbpGraph.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpGraph.Size = New System.Drawing.Size(344, 246)
        Me.tbpGraph.TabIndex = 1
        Me.tbpGraph.Text = "Graph"
        Me.tbpGraph.UseVisualStyleBackColor = True
        '
        'grpGraphOptions
        '
        Me.grpGraphOptions.Controls.Add(Me.ucrNudSize)
        Me.grpGraphOptions.Controls.Add(Me.lblSize)
        Me.grpGraphOptions.Controls.Add(Me.ucrInputColor)
        Me.grpGraphOptions.Controls.Add(Me.lblColor)
        Me.grpGraphOptions.Controls.Add(Me.lblTitle)
        Me.grpGraphOptions.Controls.Add(Me.lblHjust)
        Me.grpGraphOptions.Controls.Add(Me.lblVjust)
        Me.grpGraphOptions.Controls.Add(Me.ucrInputGraphTitle)
        Me.grpGraphOptions.Controls.Add(Me.ucrInputHorizontalLabels)
        Me.grpGraphOptions.Controls.Add(Me.ucrInputVerticalLabels)
        Me.grpGraphOptions.Controls.Add(Me.ucrChkShowMissing)
        Me.grpGraphOptions.Controls.Add(Me.ucrChkShowPercentage)
        Me.grpGraphOptions.Controls.Add(Me.ucrChkShowCount)
        Me.grpGraphOptions.Location = New System.Drawing.Point(6, 95)
        Me.grpGraphOptions.Name = "grpGraphOptions"
        Me.grpGraphOptions.Size = New System.Drawing.Size(329, 146)
        Me.grpGraphOptions.TabIndex = 1
        Me.grpGraphOptions.TabStop = False
        Me.grpGraphOptions.Text = "Graph Options"
        '
        'ucrNudSize
        '
        Me.ucrNudSize.AutoSize = True
        Me.ucrNudSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSize.Location = New System.Drawing.Point(246, 46)
        Me.ucrNudSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSize.Name = "ucrNudSize"
        Me.ucrNudSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSize.TabIndex = 12
        Me.ucrNudSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSize.Location = New System.Drawing.Point(188, 53)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(30, 13)
        Me.lblSize.TabIndex = 11
        Me.lblSize.Text = "Size:"
        '
        'ucrInputColor
        '
        Me.ucrInputColor.AddQuotesIfUnrecognised = True
        Me.ucrInputColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputColor.GetSetSelectedIndex = -1
        Me.ucrInputColor.IsReadOnly = False
        Me.ucrInputColor.Location = New System.Drawing.Point(246, 19)
        Me.ucrInputColor.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputColor.Name = "ucrInputColor"
        Me.ucrInputColor.Size = New System.Drawing.Size(77, 21)
        Me.ucrInputColor.TabIndex = 10
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColor.Location = New System.Drawing.Point(188, 23)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(34, 13)
        Me.lblColor.TabIndex = 9
        Me.lblColor.Text = "Color:"
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
        Me.ucrInputGraphTitle.AutoSize = True
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
        Me.ucrInputHorizontalLabels.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputHorizontalLabels.GetSetSelectedIndex = -1
        Me.ucrInputHorizontalLabels.IsReadOnly = False
        Me.ucrInputHorizontalLabels.Location = New System.Drawing.Point(180, 125)
        Me.ucrInputHorizontalLabels.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputHorizontalLabels.Name = "ucrInputHorizontalLabels"
        Me.ucrInputHorizontalLabels.Size = New System.Drawing.Size(81, 21)
        Me.ucrInputHorizontalLabels.TabIndex = 6
        '
        'ucrInputVerticalLabels
        '
        Me.ucrInputVerticalLabels.AddQuotesIfUnrecognised = True
        Me.ucrInputVerticalLabels.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputVerticalLabels.GetSetSelectedIndex = -1
        Me.ucrInputVerticalLabels.IsReadOnly = False
        Me.ucrInputVerticalLabels.Location = New System.Drawing.Point(180, 99)
        Me.ucrInputVerticalLabels.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputVerticalLabels.Name = "ucrInputVerticalLabels"
        Me.ucrInputVerticalLabels.Size = New System.Drawing.Size(81, 21)
        Me.ucrInputVerticalLabels.TabIndex = 4
        '
        'ucrChkShowMissing
        '
        Me.ucrChkShowMissing.AutoSize = True
        Me.ucrChkShowMissing.Checked = False
        Me.ucrChkShowMissing.Location = New System.Drawing.Point(12, 73)
        Me.ucrChkShowMissing.Name = "ucrChkShowMissing"
        Me.ucrChkShowMissing.Size = New System.Drawing.Size(170, 23)
        Me.ucrChkShowMissing.TabIndex = 2
        '
        'ucrChkShowPercentage
        '
        Me.ucrChkShowPercentage.AutoSize = True
        Me.ucrChkShowPercentage.Checked = False
        Me.ucrChkShowPercentage.Location = New System.Drawing.Point(12, 19)
        Me.ucrChkShowPercentage.Name = "ucrChkShowPercentage"
        Me.ucrChkShowPercentage.Size = New System.Drawing.Size(170, 23)
        Me.ucrChkShowPercentage.TabIndex = 0
        '
        'ucrChkShowCount
        '
        Me.ucrChkShowCount.AutoSize = True
        Me.ucrChkShowCount.Checked = False
        Me.ucrChkShowCount.Location = New System.Drawing.Point(12, 46)
        Me.ucrChkShowCount.Name = "ucrChkShowCount"
        Me.ucrChkShowCount.Size = New System.Drawing.Size(170, 23)
        Me.ucrChkShowCount.TabIndex = 1
        '
        'grpGraphType
        '
        Me.grpGraphType.Controls.Add(Me.rdoViolin)
        Me.grpGraphType.Controls.Add(Me.rdoHistogram)
        Me.grpGraphType.Controls.Add(Me.rdoBoxplot)
        Me.grpGraphType.Controls.Add(Me.rdoDensity)
        Me.grpGraphType.Controls.Add(Me.rdoLine)
        Me.grpGraphType.Controls.Add(Me.rdoDot)
        Me.grpGraphType.Controls.Add(Me.rdoBar)
        Me.grpGraphType.Controls.Add(Me.ucrPnlGraphType)
        Me.grpGraphType.Location = New System.Drawing.Point(6, 6)
        Me.grpGraphType.Name = "grpGraphType"
        Me.grpGraphType.Size = New System.Drawing.Size(329, 146)
        Me.grpGraphType.TabIndex = 0
        Me.grpGraphType.TabStop = False
        Me.grpGraphType.Text = "Type of Graph"
        '
        'rdoViolin
        '
        Me.rdoViolin.AutoSize = True
        Me.rdoViolin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoViolin.Location = New System.Drawing.Point(6, 60)
        Me.rdoViolin.Name = "rdoViolin"
        Me.rdoViolin.Size = New System.Drawing.Size(50, 17)
        Me.rdoViolin.TabIndex = 7
        Me.rdoViolin.TabStop = True
        Me.rdoViolin.Text = "Violin"
        Me.rdoViolin.UseVisualStyleBackColor = True
        '
        'rdoHistogram
        '
        Me.rdoHistogram.AutoSize = True
        Me.rdoHistogram.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHistogram.Location = New System.Drawing.Point(6, 40)
        Me.rdoHistogram.Name = "rdoHistogram"
        Me.rdoHistogram.Size = New System.Drawing.Size(72, 17)
        Me.rdoHistogram.TabIndex = 6
        Me.rdoHistogram.TabStop = True
        Me.rdoHistogram.Text = "Histogram"
        Me.rdoHistogram.UseVisualStyleBackColor = True
        '
        'rdoBoxplot
        '
        Me.rdoBoxplot.AutoSize = True
        Me.rdoBoxplot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBoxplot.Location = New System.Drawing.Point(213, 42)
        Me.rdoBoxplot.Name = "rdoBoxplot"
        Me.rdoBoxplot.Size = New System.Drawing.Size(60, 17)
        Me.rdoBoxplot.TabIndex = 5
        Me.rdoBoxplot.TabStop = True
        Me.rdoBoxplot.Text = "Boxplot"
        Me.rdoBoxplot.UseVisualStyleBackColor = True
        '
        'rdoDensity
        '
        Me.rdoDensity.AutoSize = True
        Me.rdoDensity.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDensity.Location = New System.Drawing.Point(118, 42)
        Me.rdoDensity.Name = "rdoDensity"
        Me.rdoDensity.Size = New System.Drawing.Size(60, 17)
        Me.rdoDensity.TabIndex = 4
        Me.rdoDensity.TabStop = True
        Me.rdoDensity.Text = "Density"
        Me.rdoDensity.UseVisualStyleBackColor = True
        '
        'rdoLine
        '
        Me.rdoLine.AutoSize = True
        Me.rdoLine.Location = New System.Drawing.Point(213, 19)
        Me.rdoLine.Name = "rdoLine"
        Me.rdoLine.Size = New System.Drawing.Size(48, 17)
        Me.rdoLine.TabIndex = 3
        Me.rdoLine.TabStop = True
        Me.rdoLine.Text = "Line "
        Me.rdoLine.UseVisualStyleBackColor = True
        '
        'rdoDot
        '
        Me.rdoDot.AutoSize = True
        Me.rdoDot.Location = New System.Drawing.Point(118, 19)
        Me.rdoDot.Name = "rdoDot"
        Me.rdoDot.Size = New System.Drawing.Size(45, 17)
        Me.rdoDot.TabIndex = 2
        Me.rdoDot.TabStop = True
        Me.rdoDot.Text = "Dot "
        Me.rdoDot.UseVisualStyleBackColor = True
        '
        'rdoBar
        '
        Me.rdoBar.AutoSize = True
        Me.rdoBar.Location = New System.Drawing.Point(6, 19)
        Me.rdoBar.Name = "rdoBar"
        Me.rdoBar.Size = New System.Drawing.Size(41, 17)
        Me.rdoBar.TabIndex = 1
        Me.rdoBar.TabStop = True
        Me.rdoBar.Text = "Bar"
        Me.rdoBar.UseVisualStyleBackColor = True
        '
        'ucrPnlGraphType
        '
        Me.ucrPnlGraphType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlGraphType.Location = New System.Drawing.Point(6, 19)
        Me.ucrPnlGraphType.Name = "ucrPnlGraphType"
        Me.ucrPnlGraphType.Size = New System.Drawing.Size(315, 58)
        Me.ucrPnlGraphType.TabIndex = 0
        '
        'ucrBaseOneWayFrequencies
        '
        Me.ucrBaseOneWayFrequencies.AutoSize = True
        Me.ucrBaseOneWayFrequencies.Location = New System.Drawing.Point(105, 292)
        Me.ucrBaseOneWayFrequencies.Name = "ucrBaseOneWayFrequencies"
        Me.ucrBaseOneWayFrequencies.Size = New System.Drawing.Size(224, 30)
        Me.ucrBaseOneWayFrequencies.TabIndex = 1
        '
        'sdgOneWayFrequencies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(365, 323)
        Me.Controls.Add(Me.tbpOneWayFrequencies)
        Me.Controls.Add(Me.ucrBaseOneWayFrequencies)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneWayFrequencies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frequencies Options"
        Me.tbpOneWayFrequencies.ResumeLayout(False)
        Me.tbpTable.ResumeLayout(False)
        Me.grpShowMissingFrequencies.ResumeLayout(False)
        Me.grpShowMissingFrequencies.PerformLayout()
        Me.grpTableOptions.ResumeLayout(False)
        Me.grpTableOptions.PerformLayout()
        Me.tbpGraph.ResumeLayout(False)
        Me.grpGraphOptions.ResumeLayout(False)
        Me.grpGraphOptions.PerformLayout()
        Me.grpGraphType.ResumeLayout(False)
        Me.grpGraphType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseOneWayFrequencies As ucrButtonsSubdialogue
    Friend WithEvents tbpOneWayFrequencies As TabControl
    Friend WithEvents tbpTable As TabPage
    Friend WithEvents grpTableOptions As GroupBox
    Friend WithEvents ucrChkShowStrings As ucrCheck
    Friend WithEvents tbpGraph As TabPage
    Friend WithEvents grpGraphOptions As GroupBox
    Friend WithEvents ucrChkShowMissing As ucrCheck
    Friend WithEvents ucrChkShowPercentage As ucrCheck
    Friend WithEvents ucrChkShowCount As ucrCheck
    Friend WithEvents ucrInputHorizontalLabels As ucrInputComboBox
    Friend WithEvents ucrInputVerticalLabels As ucrInputComboBox
    Friend WithEvents ucrInputGraphTitle As ucrInputTextBox
    Friend WithEvents grpGraphType As GroupBox
    Friend WithEvents ucrPnlGraphType As UcrPanel
    Friend WithEvents rdoLine As RadioButton
    Friend WithEvents rdoDot As RadioButton
    Friend WithEvents rdoBar As RadioButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblHjust As Label
    Friend WithEvents lblVjust As Label
    Friend WithEvents ucrInputTitle As ucrInputTextBox
    Friend WithEvents lblTableTitle As Label
    Friend WithEvents rdoHistogram As RadioButton
    Friend WithEvents rdoBoxplot As RadioButton
    Friend WithEvents rdoDensity As RadioButton
    Friend WithEvents rdoViolin As RadioButton
    Friend WithEvents ucrInputColor As ucrInputComboBox
    Friend WithEvents lblColor As Label
    Friend WithEvents lblSize As Label
    Friend WithEvents ucrNudSize As ucrNud
    Friend WithEvents grpShowMissingFrequencies As GroupBox
    Friend WithEvents rdoShowMissingAuto As RadioButton
    Friend WithEvents rdoShowMissingFalse As RadioButton
    Friend WithEvents rdoShowMissingTrue As RadioButton
    Friend WithEvents ucrPnlShowMissingFreq As UcrPanel
End Class
