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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgOneWayFrequencies))
        Me.tbpOneWayFrequencies = New System.Windows.Forms.TabControl()
        Me.tbpTable = New System.Windows.Forms.TabPage()
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
        resources.ApplyResources(Me.tbpOneWayFrequencies, "tbpOneWayFrequencies")
        Me.tbpOneWayFrequencies.Name = "tbpOneWayFrequencies"
        Me.tbpOneWayFrequencies.SelectedIndex = 0
        '
        'tbpTable
        '
        Me.tbpTable.Controls.Add(Me.grpTableOptions)
        resources.ApplyResources(Me.tbpTable, "tbpTable")
        Me.tbpTable.Name = "tbpTable"
        Me.tbpTable.UseVisualStyleBackColor = True
        '
        'grpTableOptions
        '
        Me.grpTableOptions.Controls.Add(Me.lblTableTitle)
        Me.grpTableOptions.Controls.Add(Me.ucrInputTitle)
        Me.grpTableOptions.Controls.Add(Me.ucrChkShowStrings)
        resources.ApplyResources(Me.grpTableOptions, "grpTableOptions")
        Me.grpTableOptions.Name = "grpTableOptions"
        Me.grpTableOptions.TabStop = False
        '
        'lblTableTitle
        '
        resources.ApplyResources(Me.lblTableTitle, "lblTableTitle")
        Me.lblTableTitle.Name = "lblTableTitle"
        '
        'ucrInputTitle
        '
        Me.ucrInputTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputTitle.IsMultiline = False
        Me.ucrInputTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTitle, "ucrInputTitle")
        Me.ucrInputTitle.Name = "ucrInputTitle"
        '
        'ucrChkShowStrings
        '
        Me.ucrChkShowStrings.Checked = False
        resources.ApplyResources(Me.ucrChkShowStrings, "ucrChkShowStrings")
        Me.ucrChkShowStrings.Name = "ucrChkShowStrings"
        '
        'tbpGraph
        '
        Me.tbpGraph.Controls.Add(Me.grpGraphOptions)
        Me.tbpGraph.Controls.Add(Me.grpGraphType)
        resources.ApplyResources(Me.tbpGraph, "tbpGraph")
        Me.tbpGraph.Name = "tbpGraph"
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
        resources.ApplyResources(Me.grpGraphOptions, "grpGraphOptions")
        Me.grpGraphOptions.Name = "grpGraphOptions"
        Me.grpGraphOptions.TabStop = False
        '
        'ucrNudSize
        '
        Me.ucrNudSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSize, "ucrNudSize")
        Me.ucrNudSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSize.Name = "ucrNudSize"
        Me.ucrNudSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblSize
        '
        resources.ApplyResources(Me.lblSize, "lblSize")
        Me.lblSize.Name = "lblSize"
        '
        'ucrInputColor
        '
        Me.ucrInputColor.AddQuotesIfUnrecognised = True
        Me.ucrInputColor.GetSetSelectedIndex = -1
        Me.ucrInputColor.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputColor, "ucrInputColor")
        Me.ucrInputColor.Name = "ucrInputColor"
        '
        'lblColor
        '
        resources.ApplyResources(Me.lblColor, "lblColor")
        Me.lblColor.Name = "lblColor"
        '
        'lblTitle
        '
        resources.ApplyResources(Me.lblTitle, "lblTitle")
        Me.lblTitle.Name = "lblTitle"
        '
        'lblHjust
        '
        resources.ApplyResources(Me.lblHjust, "lblHjust")
        Me.lblHjust.Name = "lblHjust"
        '
        'lblVjust
        '
        resources.ApplyResources(Me.lblVjust, "lblVjust")
        Me.lblVjust.Name = "lblVjust"
        '
        'ucrInputGraphTitle
        '
        Me.ucrInputGraphTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphTitle.IsMultiline = False
        Me.ucrInputGraphTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputGraphTitle, "ucrInputGraphTitle")
        Me.ucrInputGraphTitle.Name = "ucrInputGraphTitle"
        '
        'ucrInputHorizontalLabels
        '
        Me.ucrInputHorizontalLabels.AddQuotesIfUnrecognised = True
        Me.ucrInputHorizontalLabels.GetSetSelectedIndex = -1
        Me.ucrInputHorizontalLabels.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputHorizontalLabels, "ucrInputHorizontalLabels")
        Me.ucrInputHorizontalLabels.Name = "ucrInputHorizontalLabels"
        '
        'ucrInputVerticalLabels
        '
        Me.ucrInputVerticalLabels.AddQuotesIfUnrecognised = True
        Me.ucrInputVerticalLabels.GetSetSelectedIndex = -1
        Me.ucrInputVerticalLabels.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputVerticalLabels, "ucrInputVerticalLabels")
        Me.ucrInputVerticalLabels.Name = "ucrInputVerticalLabels"
        '
        'ucrChkShowMissing
        '
        Me.ucrChkShowMissing.Checked = False
        resources.ApplyResources(Me.ucrChkShowMissing, "ucrChkShowMissing")
        Me.ucrChkShowMissing.Name = "ucrChkShowMissing"
        '
        'ucrChkShowPercentage
        '
        Me.ucrChkShowPercentage.Checked = False
        resources.ApplyResources(Me.ucrChkShowPercentage, "ucrChkShowPercentage")
        Me.ucrChkShowPercentage.Name = "ucrChkShowPercentage"
        '
        'ucrChkShowCount
        '
        Me.ucrChkShowCount.Checked = False
        resources.ApplyResources(Me.ucrChkShowCount, "ucrChkShowCount")
        Me.ucrChkShowCount.Name = "ucrChkShowCount"
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
        resources.ApplyResources(Me.grpGraphType, "grpGraphType")
        Me.grpGraphType.Name = "grpGraphType"
        Me.grpGraphType.TabStop = False
        '
        'rdoViolin
        '
        resources.ApplyResources(Me.rdoViolin, "rdoViolin")
        Me.rdoViolin.Name = "rdoViolin"
        Me.rdoViolin.TabStop = True
        Me.rdoViolin.UseVisualStyleBackColor = True
        '
        'rdoHistogram
        '
        resources.ApplyResources(Me.rdoHistogram, "rdoHistogram")
        Me.rdoHistogram.Name = "rdoHistogram"
        Me.rdoHistogram.TabStop = True
        Me.rdoHistogram.UseVisualStyleBackColor = True
        '
        'rdoBoxplot
        '
        resources.ApplyResources(Me.rdoBoxplot, "rdoBoxplot")
        Me.rdoBoxplot.Name = "rdoBoxplot"
        Me.rdoBoxplot.TabStop = True
        Me.rdoBoxplot.UseVisualStyleBackColor = True
        '
        'rdoDensity
        '
        resources.ApplyResources(Me.rdoDensity, "rdoDensity")
        Me.rdoDensity.Name = "rdoDensity"
        Me.rdoDensity.TabStop = True
        Me.rdoDensity.UseVisualStyleBackColor = True
        '
        'rdoLine
        '
        resources.ApplyResources(Me.rdoLine, "rdoLine")
        Me.rdoLine.Name = "rdoLine"
        Me.rdoLine.TabStop = True
        Me.rdoLine.UseVisualStyleBackColor = True
        '
        'rdoDot
        '
        resources.ApplyResources(Me.rdoDot, "rdoDot")
        Me.rdoDot.Name = "rdoDot"
        Me.rdoDot.TabStop = True
        Me.rdoDot.UseVisualStyleBackColor = True
        '
        'rdoBar
        '
        resources.ApplyResources(Me.rdoBar, "rdoBar")
        Me.rdoBar.Name = "rdoBar"
        Me.rdoBar.TabStop = True
        Me.rdoBar.UseVisualStyleBackColor = True
        '
        'ucrPnlGraphType
        '
        resources.ApplyResources(Me.ucrPnlGraphType, "ucrPnlGraphType")
        Me.ucrPnlGraphType.Name = "ucrPnlGraphType"
        '
        'ucrBaseOneWayFrequencies
        '
        resources.ApplyResources(Me.ucrBaseOneWayFrequencies, "ucrBaseOneWayFrequencies")
        Me.ucrBaseOneWayFrequencies.Name = "ucrBaseOneWayFrequencies"
        '
        'sdgOneWayFrequencies
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbpOneWayFrequencies)
        Me.Controls.Add(Me.ucrBaseOneWayFrequencies)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneWayFrequencies"
        Me.tbpOneWayFrequencies.ResumeLayout(False)
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
End Class
