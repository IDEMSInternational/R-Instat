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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgTwoWayFrequencies))
        Me.tbpTwoWayFrequencies = New System.Windows.Forms.TabControl()
        Me.tbpTable = New System.Windows.Forms.TabPage()
        Me.grpTableOptions = New System.Windows.Forms.GroupBox()
        Me.lblNumberOfDecimals = New System.Windows.Forms.Label()
        Me.lblGraphTitle = New System.Windows.Forms.Label()
        Me.tbpGraph = New System.Windows.Forms.TabPage()
        Me.grpGraphOptions = New System.Windows.Forms.GroupBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHjust = New System.Windows.Forms.Label()
        Me.lblVjust = New System.Windows.Forms.Label()
        Me.grpGraphType = New System.Windows.Forms.GroupBox()
        Me.rdoLineGraph = New System.Windows.Forms.RadioButton()
        Me.rdoViolinPlot = New System.Windows.Forms.RadioButton()
        Me.rdoBoxPlot = New System.Windows.Forms.RadioButton()
        Me.rdoDot = New System.Windows.Forms.RadioButton()
        Me.rdoBar = New System.Windows.Forms.RadioButton()
        Me.ucrNudDecimalPlaces = New instat.ucrNud()
        Me.ucrInputTableTitle = New instat.ucrInputTextBox()
        Me.ucrChkTotalColumnName = New instat.ucrCheck()
        Me.ucrInputTotalsName = New instat.ucrInputTextBox()
        Me.ucrChkMissingValues = New instat.ucrCheck()
        Me.ucrChkBackgroundColour = New instat.ucrCheck()
        Me.ucrChkShowSummary = New instat.ucrCheck()
        Me.ucrChkStack = New instat.ucrCheck()
        Me.ucrInputGraphTitle = New instat.ucrInputTextBox()
        Me.ucrInputHorizontalLabels = New instat.ucrInputComboBox()
        Me.ucrInputVerticalLabels = New instat.ucrInputComboBox()
        Me.ucrChkShowModelSummary = New instat.ucrCheck()
        Me.ucrChkShowPercentage = New instat.ucrCheck()
        Me.ucrChkShowCount = New instat.ucrCheck()
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
        resources.ApplyResources(Me.tbpTwoWayFrequencies, "tbpTwoWayFrequencies")
        Me.tbpTwoWayFrequencies.Name = "tbpTwoWayFrequencies"
        Me.tbpTwoWayFrequencies.SelectedIndex = 0
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
        Me.grpTableOptions.Controls.Add(Me.lblNumberOfDecimals)
        Me.grpTableOptions.Controls.Add(Me.ucrNudDecimalPlaces)
        Me.grpTableOptions.Controls.Add(Me.lblGraphTitle)
        Me.grpTableOptions.Controls.Add(Me.ucrInputTableTitle)
        Me.grpTableOptions.Controls.Add(Me.ucrChkTotalColumnName)
        Me.grpTableOptions.Controls.Add(Me.ucrInputTotalsName)
        Me.grpTableOptions.Controls.Add(Me.ucrChkMissingValues)
        Me.grpTableOptions.Controls.Add(Me.ucrChkBackgroundColour)
        Me.grpTableOptions.Controls.Add(Me.ucrChkShowSummary)
        resources.ApplyResources(Me.grpTableOptions, "grpTableOptions")
        Me.grpTableOptions.Name = "grpTableOptions"
        Me.grpTableOptions.TabStop = False
        '
        'lblNumberOfDecimals
        '
        resources.ApplyResources(Me.lblNumberOfDecimals, "lblNumberOfDecimals")
        Me.lblNumberOfDecimals.Name = "lblNumberOfDecimals"
        '
        'lblGraphTitle
        '
        resources.ApplyResources(Me.lblGraphTitle, "lblGraphTitle")
        Me.lblGraphTitle.Name = "lblGraphTitle"
        '
        'tbpGraph
        '
        Me.tbpGraph.Controls.Add(Me.grpGraphOptions)
        Me.tbpGraph.Controls.Add(Me.rdoViolinPlot)
        Me.tbpGraph.Controls.Add(Me.grpGraphType)
        resources.ApplyResources(Me.tbpGraph, "tbpGraph")
        Me.tbpGraph.Name = "tbpGraph"
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
        resources.ApplyResources(Me.grpGraphOptions, "grpGraphOptions")
        Me.grpGraphOptions.Name = "grpGraphOptions"
        Me.grpGraphOptions.TabStop = False
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
        'grpGraphType
        '
        Me.grpGraphType.Controls.Add(Me.rdoLineGraph)
        Me.grpGraphType.Controls.Add(Me.rdoBoxPlot)
        Me.grpGraphType.Controls.Add(Me.rdoDot)
        Me.grpGraphType.Controls.Add(Me.rdoBar)
        Me.grpGraphType.Controls.Add(Me.ucrPnlGraphType)
        resources.ApplyResources(Me.grpGraphType, "grpGraphType")
        Me.grpGraphType.Name = "grpGraphType"
        Me.grpGraphType.TabStop = False
        '
        'rdoLineGraph
        '
        resources.ApplyResources(Me.rdoLineGraph, "rdoLineGraph")
        Me.rdoLineGraph.Name = "rdoLineGraph"
        Me.rdoLineGraph.TabStop = True
        Me.rdoLineGraph.UseVisualStyleBackColor = True
        '
        'rdoViolinPlot
        '
        resources.ApplyResources(Me.rdoViolinPlot, "rdoViolinPlot")
        Me.rdoViolinPlot.Name = "rdoViolinPlot"
        Me.rdoViolinPlot.TabStop = True
        Me.rdoViolinPlot.UseVisualStyleBackColor = True
        '
        'rdoBoxPlot
        '
        resources.ApplyResources(Me.rdoBoxPlot, "rdoBoxPlot")
        Me.rdoBoxPlot.Name = "rdoBoxPlot"
        Me.rdoBoxPlot.TabStop = True
        Me.rdoBoxPlot.UseVisualStyleBackColor = True
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
        'ucrNudDecimalPlaces
        '
        resources.ApplyResources(Me.ucrNudDecimalPlaces, "ucrNudDecimalPlaces")
        Me.ucrNudDecimalPlaces.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Name = "ucrNudDecimalPlaces"
        Me.ucrNudDecimalPlaces.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputTableTitle
        '
        Me.ucrInputTableTitle.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputTableTitle, "ucrInputTableTitle")
        Me.ucrInputTableTitle.IsMultiline = False
        Me.ucrInputTableTitle.IsReadOnly = False
        Me.ucrInputTableTitle.Name = "ucrInputTableTitle"
        '
        'ucrChkTotalColumnName
        '
        resources.ApplyResources(Me.ucrChkTotalColumnName, "ucrChkTotalColumnName")
        Me.ucrChkTotalColumnName.Checked = False
        Me.ucrChkTotalColumnName.Name = "ucrChkTotalColumnName"
        '
        'ucrInputTotalsName
        '
        Me.ucrInputTotalsName.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputTotalsName, "ucrInputTotalsName")
        Me.ucrInputTotalsName.IsMultiline = False
        Me.ucrInputTotalsName.IsReadOnly = False
        Me.ucrInputTotalsName.Name = "ucrInputTotalsName"
        '
        'ucrChkMissingValues
        '
        resources.ApplyResources(Me.ucrChkMissingValues, "ucrChkMissingValues")
        Me.ucrChkMissingValues.Checked = False
        Me.ucrChkMissingValues.Name = "ucrChkMissingValues"
        '
        'ucrChkBackgroundColour
        '
        resources.ApplyResources(Me.ucrChkBackgroundColour, "ucrChkBackgroundColour")
        Me.ucrChkBackgroundColour.Checked = False
        Me.ucrChkBackgroundColour.Name = "ucrChkBackgroundColour"
        '
        'ucrChkShowSummary
        '
        resources.ApplyResources(Me.ucrChkShowSummary, "ucrChkShowSummary")
        Me.ucrChkShowSummary.Checked = False
        Me.ucrChkShowSummary.Name = "ucrChkShowSummary"
        '
        'ucrChkStack
        '
        resources.ApplyResources(Me.ucrChkStack, "ucrChkStack")
        Me.ucrChkStack.Checked = False
        Me.ucrChkStack.Name = "ucrChkStack"
        '
        'ucrInputGraphTitle
        '
        Me.ucrInputGraphTitle.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputGraphTitle, "ucrInputGraphTitle")
        Me.ucrInputGraphTitle.IsMultiline = False
        Me.ucrInputGraphTitle.IsReadOnly = False
        Me.ucrInputGraphTitle.Name = "ucrInputGraphTitle"
        '
        'ucrInputHorizontalLabels
        '
        Me.ucrInputHorizontalLabels.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputHorizontalLabels, "ucrInputHorizontalLabels")
        Me.ucrInputHorizontalLabels.GetSetSelectedIndex = -1
        Me.ucrInputHorizontalLabels.IsReadOnly = False
        Me.ucrInputHorizontalLabels.Name = "ucrInputHorizontalLabels"
        '
        'ucrInputVerticalLabels
        '
        Me.ucrInputVerticalLabels.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputVerticalLabels, "ucrInputVerticalLabels")
        Me.ucrInputVerticalLabels.GetSetSelectedIndex = -1
        Me.ucrInputVerticalLabels.IsReadOnly = False
        Me.ucrInputVerticalLabels.Name = "ucrInputVerticalLabels"
        '
        'ucrChkShowModelSummary
        '
        resources.ApplyResources(Me.ucrChkShowModelSummary, "ucrChkShowModelSummary")
        Me.ucrChkShowModelSummary.Checked = False
        Me.ucrChkShowModelSummary.Name = "ucrChkShowModelSummary"
        '
        'ucrChkShowPercentage
        '
        resources.ApplyResources(Me.ucrChkShowPercentage, "ucrChkShowPercentage")
        Me.ucrChkShowPercentage.Checked = False
        Me.ucrChkShowPercentage.Name = "ucrChkShowPercentage"
        '
        'ucrChkShowCount
        '
        resources.ApplyResources(Me.ucrChkShowCount, "ucrChkShowCount")
        Me.ucrChkShowCount.Checked = False
        Me.ucrChkShowCount.Name = "ucrChkShowCount"
        '
        'ucrPnlGraphType
        '
        resources.ApplyResources(Me.ucrPnlGraphType, "ucrPnlGraphType")
        Me.ucrPnlGraphType.Name = "ucrPnlGraphType"
        '
        'ucrBaseSubDialogue
        '
        resources.ApplyResources(Me.ucrBaseSubDialogue, "ucrBaseSubDialogue")
        Me.ucrBaseSubDialogue.Name = "ucrBaseSubDialogue"
        '
        'sdgTwoWayFrequencies
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.tbpTwoWayFrequencies)
        Me.Controls.Add(Me.ucrBaseSubDialogue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgTwoWayFrequencies"
        Me.tbpTwoWayFrequencies.ResumeLayout(False)
        Me.tbpTable.ResumeLayout(False)
        Me.grpTableOptions.ResumeLayout(False)
        Me.grpTableOptions.PerformLayout()
        Me.tbpGraph.ResumeLayout(False)
        Me.tbpGraph.PerformLayout()
        Me.grpGraphOptions.ResumeLayout(False)
        Me.grpGraphOptions.PerformLayout()
        Me.grpGraphType.ResumeLayout(False)
        Me.grpGraphType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents rdoDot As RadioButton
    Friend WithEvents rdoBar As RadioButton
    Friend WithEvents ucrPnlGraphType As UcrPanel
    Friend WithEvents ucrChkStack As ucrCheck
    Friend WithEvents lblGraphTitle As Label
    Friend WithEvents ucrInputTableTitle As ucrInputTextBox
    Friend WithEvents lblNumberOfDecimals As Label
    Friend WithEvents ucrNudDecimalPlaces As ucrNud
    Friend WithEvents rdoBoxPlot As RadioButton
    Friend WithEvents rdoViolinPlot As RadioButton
    Friend WithEvents rdoLineGraph As RadioButton
End Class