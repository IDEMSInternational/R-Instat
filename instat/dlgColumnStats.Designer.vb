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
Partial Class dlgColumnStats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgColumnStats))
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.lblByFactors = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkStoreResults = New instat.ucrCheck()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrChkPrintOutput = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevels = New instat.ucrCheck()
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.cmdProportionsPercentages = New System.Windows.Forms.Button()
        Me.ucrReceiverByFactor = New instat.ucrReceiverMultiple()
        Me.ucrReceiverSelectedVariables = New instat.ucrReceiverMultiple()
        Me.ucrSelectorForColumnStatistics = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectedVariables
        '
        resources.ApplyResources(Me.lblSelectedVariables, "lblSelectedVariables")
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        '
        'lblByFactors
        '
        resources.ApplyResources(Me.lblByFactors, "lblByFactors")
        Me.lblByFactors.Name = "lblByFactors"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrChkStoreResults)
        Me.grpOptions.Controls.Add(Me.ucrChkOmitMissing)
        Me.grpOptions.Controls.Add(Me.ucrChkPrintOutput)
        Me.grpOptions.Controls.Add(Me.ucrChkDropUnusedLevels)
        resources.ApplyResources(Me.grpOptions, "grpOptions")
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.TabStop = False
        '
        'ucrChkStoreResults
        '
        Me.ucrChkStoreResults.Checked = False
        resources.ApplyResources(Me.ucrChkStoreResults, "ucrChkStoreResults")
        Me.ucrChkStoreResults.Name = "ucrChkStoreResults"
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.Checked = False
        resources.ApplyResources(Me.ucrChkOmitMissing, "ucrChkOmitMissing")
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        '
        'ucrChkPrintOutput
        '
        Me.ucrChkPrintOutput.Checked = False
        resources.ApplyResources(Me.ucrChkPrintOutput, "ucrChkPrintOutput")
        Me.ucrChkPrintOutput.Name = "ucrChkPrintOutput"
        '
        'ucrChkDropUnusedLevels
        '
        Me.ucrChkDropUnusedLevels.Checked = False
        resources.ApplyResources(Me.ucrChkDropUnusedLevels, "ucrChkDropUnusedLevels")
        Me.ucrChkDropUnusedLevels.Name = "ucrChkDropUnusedLevels"
        '
        'cmdSummaries
        '
        resources.ApplyResources(Me.cmdSummaries, "cmdSummaries")
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Tag = "Summaries"
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'cmdProportionsPercentages
        '
        resources.ApplyResources(Me.cmdProportionsPercentages, "cmdProportionsPercentages")
        Me.cmdProportionsPercentages.Name = "cmdProportionsPercentages"
        Me.cmdProportionsPercentages.Tag = "Proportions/Percentages..."
        Me.cmdProportionsPercentages.UseVisualStyleBackColor = True
        '
        'ucrReceiverByFactor
        '
        Me.ucrReceiverByFactor.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverByFactor, "ucrReceiverByFactor")
        Me.ucrReceiverByFactor.Name = "ucrReceiverByFactor"
        Me.ucrReceiverByFactor.Selector = Nothing
        Me.ucrReceiverByFactor.strNcFilePath = ""
        Me.ucrReceiverByFactor.ucrSelector = Nothing
        '
        'ucrReceiverSelectedVariables
        '
        Me.ucrReceiverSelectedVariables.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSelectedVariables, "ucrReceiverSelectedVariables")
        Me.ucrReceiverSelectedVariables.Name = "ucrReceiverSelectedVariables"
        Me.ucrReceiverSelectedVariables.Selector = Nothing
        Me.ucrReceiverSelectedVariables.strNcFilePath = ""
        Me.ucrReceiverSelectedVariables.ucrSelector = Nothing
        '
        'ucrSelectorForColumnStatistics
        '
        Me.ucrSelectorForColumnStatistics.bShowHiddenColumns = False
        Me.ucrSelectorForColumnStatistics.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForColumnStatistics, "ucrSelectorForColumnStatistics")
        Me.ucrSelectorForColumnStatistics.Name = "ucrSelectorForColumnStatistics"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgColumnStats
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdProportionsPercentages)
        Me.Controls.Add(Me.cmdSummaries)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.ucrReceiverByFactor)
        Me.Controls.Add(Me.ucrReceiverSelectedVariables)
        Me.Controls.Add(Me.lblByFactors)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.ucrSelectorForColumnStatistics)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgColumnStats"
        Me.Tag = "Column_Statistics"
        Me.grpOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForColumnStatistics As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents lblByFactors As Label
    Friend WithEvents ucrReceiverSelectedVariables As ucrReceiverMultiple
    Friend WithEvents ucrReceiverByFactor As ucrReceiverMultiple
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents ucrChkStoreResults As ucrCheck
    Friend WithEvents ucrChkOmitMissing As ucrCheck
    Friend WithEvents ucrChkPrintOutput As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevels As ucrCheck
    Friend WithEvents cmdProportionsPercentages As Button
End Class
