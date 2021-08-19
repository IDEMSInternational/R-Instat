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
Partial Class dlgSummaryTables
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgSummaryTables))
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.lblSigFigs = New System.Windows.Forms.Label()
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.ucrNudColumnFactors = New instat.ucrNud()
        Me.lblColumnFactors = New System.Windows.Forms.Label()
        Me.ucrChkDisplaySummaryVariablesAsRow = New instat.ucrCheck()
        Me.ucrChkDisplayVariablesAsRows = New instat.ucrCheck()
        Me.ucrChkDisplaySummariesAsRow = New instat.ucrCheck()
        Me.ucrNudSigFigs = New instat.ucrNud()
        Me.grpMargin = New System.Windows.Forms.GroupBox()
        Me.rdoBoth = New System.Windows.Forms.RadioButton()
        Me.rdoSummary = New System.Windows.Forms.RadioButton()
        Me.rdoOuter = New System.Windows.Forms.RadioButton()
        Me.ucrPnlMargin = New instat.UcrPanel()
        Me.lblMarginName = New System.Windows.Forms.Label()
        Me.lblVariables = New System.Windows.Forms.Label()
        Me.ucrInputMarginName = New instat.ucrInputTextBox()
        Me.ucrSaveTable = New instat.ucrSave()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrChkStoreResults = New instat.ucrCheck()
        Me.ucrChkDisplayMargins = New instat.ucrCheck()
        Me.ucrChkSummaries = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverSummaryCols = New instat.ucrReceiverMultiple()
        Me.ucrReceiverFactors = New instat.ucrReceiverMultiple()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrChkWeight = New instat.ucrCheck()
        Me.ucrSelectorSummaryTables = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpDisplay.SuspendLayout()
        Me.grpMargin.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFactors
        '
        resources.ApplyResources(Me.lblFactors, "lblFactors")
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Tag = "Factors:"
        '
        'cmdSummaries
        '
        resources.ApplyResources(Me.cmdSummaries, "cmdSummaries")
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'lblSigFigs
        '
        resources.ApplyResources(Me.lblSigFigs, "lblSigFigs")
        Me.lblSigFigs.Name = "lblSigFigs"
        Me.lblSigFigs.Tag = "Significant_Figures:"
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.ucrNudColumnFactors)
        Me.grpDisplay.Controls.Add(Me.lblColumnFactors)
        Me.grpDisplay.Controls.Add(Me.ucrChkDisplaySummaryVariablesAsRow)
        Me.grpDisplay.Controls.Add(Me.ucrChkDisplayVariablesAsRows)
        Me.grpDisplay.Controls.Add(Me.ucrChkDisplaySummariesAsRow)
        Me.grpDisplay.Controls.Add(Me.ucrNudSigFigs)
        Me.grpDisplay.Controls.Add(Me.lblSigFigs)
        resources.ApplyResources(Me.grpDisplay, "grpDisplay")
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.TabStop = False
        '
        'ucrNudColumnFactors
        '
        Me.ucrNudColumnFactors.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColumnFactors.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudColumnFactors, "ucrNudColumnFactors")
        Me.ucrNudColumnFactors.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudColumnFactors.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColumnFactors.Name = "ucrNudColumnFactors"
        Me.ucrNudColumnFactors.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblColumnFactors
        '
        resources.ApplyResources(Me.lblColumnFactors, "lblColumnFactors")
        Me.lblColumnFactors.Name = "lblColumnFactors"
        Me.lblColumnFactors.Tag = ""
        '
        'ucrChkDisplaySummaryVariablesAsRow
        '
        Me.ucrChkDisplaySummaryVariablesAsRow.Checked = False
        resources.ApplyResources(Me.ucrChkDisplaySummaryVariablesAsRow, "ucrChkDisplaySummaryVariablesAsRow")
        Me.ucrChkDisplaySummaryVariablesAsRow.Name = "ucrChkDisplaySummaryVariablesAsRow"
        '
        'ucrChkDisplayVariablesAsRows
        '
        Me.ucrChkDisplayVariablesAsRows.Checked = False
        resources.ApplyResources(Me.ucrChkDisplayVariablesAsRows, "ucrChkDisplayVariablesAsRows")
        Me.ucrChkDisplayVariablesAsRows.Name = "ucrChkDisplayVariablesAsRows"
        '
        'ucrChkDisplaySummariesAsRow
        '
        Me.ucrChkDisplaySummariesAsRow.Checked = False
        resources.ApplyResources(Me.ucrChkDisplaySummariesAsRow, "ucrChkDisplaySummariesAsRow")
        Me.ucrChkDisplaySummariesAsRow.Name = "ucrChkDisplaySummariesAsRow"
        '
        'ucrNudSigFigs
        '
        Me.ucrNudSigFigs.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigFigs.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSigFigs, "ucrNudSigFigs")
        Me.ucrNudSigFigs.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSigFigs.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigFigs.Name = "ucrNudSigFigs"
        Me.ucrNudSigFigs.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'grpMargin
        '
        Me.grpMargin.Controls.Add(Me.rdoBoth)
        Me.grpMargin.Controls.Add(Me.rdoSummary)
        Me.grpMargin.Controls.Add(Me.rdoOuter)
        Me.grpMargin.Controls.Add(Me.ucrPnlMargin)
        resources.ApplyResources(Me.grpMargin, "grpMargin")
        Me.grpMargin.Name = "grpMargin"
        Me.grpMargin.TabStop = False
        '
        'rdoBoth
        '
        resources.ApplyResources(Me.rdoBoth, "rdoBoth")
        Me.rdoBoth.Name = "rdoBoth"
        Me.rdoBoth.TabStop = True
        Me.rdoBoth.UseVisualStyleBackColor = True
        '
        'rdoSummary
        '
        resources.ApplyResources(Me.rdoSummary, "rdoSummary")
        Me.rdoSummary.Name = "rdoSummary"
        Me.rdoSummary.TabStop = True
        Me.rdoSummary.UseVisualStyleBackColor = True
        '
        'rdoOuter
        '
        resources.ApplyResources(Me.rdoOuter, "rdoOuter")
        Me.rdoOuter.Name = "rdoOuter"
        Me.rdoOuter.TabStop = True
        Me.rdoOuter.UseVisualStyleBackColor = True
        '
        'ucrPnlMargin
        '
        resources.ApplyResources(Me.ucrPnlMargin, "ucrPnlMargin")
        Me.ucrPnlMargin.Name = "ucrPnlMargin"
        '
        'lblMarginName
        '
        resources.ApplyResources(Me.lblMarginName, "lblMarginName")
        Me.lblMarginName.Name = "lblMarginName"
        '
        'lblVariables
        '
        resources.ApplyResources(Me.lblVariables, "lblVariables")
        Me.lblVariables.Name = "lblVariables"
        Me.lblVariables.Tag = ""
        '
        'ucrInputMarginName
        '
        Me.ucrInputMarginName.AddQuotesIfUnrecognised = True
        Me.ucrInputMarginName.IsMultiline = False
        Me.ucrInputMarginName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMarginName, "ucrInputMarginName")
        Me.ucrInputMarginName.Name = "ucrInputMarginName"
        '
        'ucrSaveTable
        '
        resources.ApplyResources(Me.ucrSaveTable, "ucrSaveTable")
        Me.ucrSaveTable.Name = "ucrSaveTable"
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.Checked = False
        resources.ApplyResources(Me.ucrChkOmitMissing, "ucrChkOmitMissing")
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        '
        'ucrChkStoreResults
        '
        Me.ucrChkStoreResults.Checked = False
        resources.ApplyResources(Me.ucrChkStoreResults, "ucrChkStoreResults")
        Me.ucrChkStoreResults.Name = "ucrChkStoreResults"
        '
        'ucrChkDisplayMargins
        '
        Me.ucrChkDisplayMargins.Checked = False
        resources.ApplyResources(Me.ucrChkDisplayMargins, "ucrChkDisplayMargins")
        Me.ucrChkDisplayMargins.Name = "ucrChkDisplayMargins"
        '
        'ucrChkSummaries
        '
        Me.ucrChkSummaries.Checked = False
        resources.ApplyResources(Me.ucrChkSummaries, "ucrChkSummaries")
        Me.ucrChkSummaries.Name = "ucrChkSummaries"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReceiverSummaryCols
        '
        Me.ucrReceiverSummaryCols.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSummaryCols, "ucrReceiverSummaryCols")
        Me.ucrReceiverSummaryCols.Name = "ucrReceiverSummaryCols"
        Me.ucrReceiverSummaryCols.Selector = Nothing
        Me.ucrReceiverSummaryCols.strNcFilePath = ""
        Me.ucrReceiverSummaryCols.ucrSelector = Nothing
        '
        'ucrReceiverFactors
        '
        Me.ucrReceiverFactors.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFactors, "ucrReceiverFactors")
        Me.ucrReceiverFactors.Name = "ucrReceiverFactors"
        Me.ucrReceiverFactors.Selector = Nothing
        Me.ucrReceiverFactors.strNcFilePath = ""
        Me.ucrReceiverFactors.ucrSelector = Nothing
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverWeights, "ucrReceiverWeights")
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.strNcFilePath = ""
        Me.ucrReceiverWeights.ucrSelector = Nothing
        '
        'ucrChkWeight
        '
        Me.ucrChkWeight.Checked = False
        resources.ApplyResources(Me.ucrChkWeight, "ucrChkWeight")
        Me.ucrChkWeight.Name = "ucrChkWeight"
        '
        'ucrSelectorSummaryTables
        '
        Me.ucrSelectorSummaryTables.bDropUnusedFilterLevels = False
        Me.ucrSelectorSummaryTables.bShowHiddenColumns = False
        Me.ucrSelectorSummaryTables.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorSummaryTables, "ucrSelectorSummaryTables")
        Me.ucrSelectorSummaryTables.Name = "ucrSelectorSummaryTables"
        '
        'dlgSummaryTables
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblVariables)
        Me.Controls.Add(Me.ucrInputMarginName)
        Me.Controls.Add(Me.lblMarginName)
        Me.Controls.Add(Me.ucrSaveTable)
        Me.Controls.Add(Me.ucrChkOmitMissing)
        Me.Controls.Add(Me.ucrChkStoreResults)
        Me.Controls.Add(Me.cmdSummaries)
        Me.Controls.Add(Me.ucrChkDisplayMargins)
        Me.Controls.Add(Me.grpDisplay)
        Me.Controls.Add(Me.ucrChkSummaries)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverSummaryCols)
        Me.Controls.Add(Me.ucrReceiverFactors)
        Me.Controls.Add(Me.ucrReceiverWeights)
        Me.Controls.Add(Me.ucrChkWeight)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrSelectorSummaryTables)
        Me.Controls.Add(Me.grpMargin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSummaryTables"
        Me.grpDisplay.ResumeLayout(False)
        Me.grpDisplay.PerformLayout()
        Me.grpMargin.ResumeLayout(False)
        Me.grpMargin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorSummaryTables As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFactors As Label
    Friend WithEvents ucrChkWeight As ucrCheck
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents ucrReceiverFactors As ucrReceiverMultiple
    Friend WithEvents ucrReceiverSummaryCols As ucrReceiverMultiple
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkSummaries As ucrCheck
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents ucrChkDisplayMargins As ucrCheck
    Friend WithEvents ucrChkOmitMissing As ucrCheck
    Friend WithEvents ucrChkStoreResults As ucrCheck
    Friend WithEvents ucrSaveTable As ucrSave
    Friend WithEvents grpDisplay As GroupBox
    Friend WithEvents ucrNudSigFigs As ucrNud
    Friend WithEvents lblSigFigs As Label
    Friend WithEvents grpMargin As GroupBox
    Friend WithEvents rdoBoth As RadioButton
    Friend WithEvents rdoSummary As RadioButton
    Friend WithEvents rdoOuter As RadioButton
    Friend WithEvents ucrPnlMargin As UcrPanel
    Friend WithEvents lblMarginName As Label
    Friend WithEvents ucrInputMarginName As ucrInputTextBox
    Friend WithEvents ucrChkDisplaySummaryVariablesAsRow As ucrCheck
    Friend WithEvents ucrChkDisplayVariablesAsRows As ucrCheck
    Friend WithEvents ucrChkDisplaySummariesAsRow As ucrCheck
    Friend WithEvents ucrNudColumnFactors As ucrNud
    Friend WithEvents lblColumnFactors As Label
    Friend WithEvents lblVariables As Label
End Class
