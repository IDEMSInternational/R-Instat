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
Partial Class dlgFrequency
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgFrequency))
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblColumnFactors = New System.Windows.Forms.Label()
        Me.lblSigFigs = New System.Windows.Forms.Label()
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.lblFactorsAsPercentage = New System.Windows.Forms.Label()
        Me.lblMarginName = New System.Windows.Forms.Label()
        Me.ucrInputMarginName = New instat.ucrInputTextBox()
        Me.ucrNudColumnFactors = New instat.ucrNud()
        Me.ucrChkDisplaySummariesAsRow = New instat.ucrCheck()
        Me.ucrNudSigFigs = New instat.ucrNud()
        Me.ucrSaveTable = New instat.ucrSave()
        Me.ucrChkDisplayMargins = New instat.ucrCheck()
        Me.ucrChkStoreResults = New instat.ucrCheck()
        Me.ucrReceiverMultiplePercentages = New instat.ucrReceiverMultiple()
        Me.ucrChkPercentageProportion = New instat.ucrCheck()
        Me.ucrChkDisplayAsPercentage = New instat.ucrCheck()
        Me.ucrReceiverFactors = New instat.ucrReceiverMultiple()
        Me.ucrSelectorFrequency = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.UcrCheck1 = New instat.ucrCheck()
        Me.GroupBox1.SuspendLayout()
        Me.grpDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFactors
        '
        resources.ApplyResources(Me.lblFactors, "lblFactors")
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Tag = "Factors:"
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ucrNudColumnFactors)
        Me.GroupBox1.Controls.Add(Me.ucrChkDisplaySummariesAsRow)
        Me.GroupBox1.Controls.Add(Me.lblColumnFactors)
        Me.GroupBox1.Controls.Add(Me.ucrNudSigFigs)
        Me.GroupBox1.Controls.Add(Me.lblSigFigs)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'lblColumnFactors
        '
        resources.ApplyResources(Me.lblColumnFactors, "lblColumnFactors")
        Me.lblColumnFactors.Name = "lblColumnFactors"
        Me.lblColumnFactors.Tag = ""
        '
        'lblSigFigs
        '
        resources.ApplyResources(Me.lblSigFigs, "lblSigFigs")
        Me.lblSigFigs.Name = "lblSigFigs"
        Me.lblSigFigs.Tag = "Significant_Figures:"
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.lblFactorsAsPercentage)
        Me.grpDisplay.Controls.Add(Me.ucrReceiverMultiplePercentages)
        Me.grpDisplay.Controls.Add(Me.ucrChkPercentageProportion)
        Me.grpDisplay.Controls.Add(Me.ucrChkDisplayAsPercentage)
        resources.ApplyResources(Me.grpDisplay, "grpDisplay")
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.TabStop = False
        '
        'lblFactorsAsPercentage
        '
        resources.ApplyResources(Me.lblFactorsAsPercentage, "lblFactorsAsPercentage")
        Me.lblFactorsAsPercentage.Name = "lblFactorsAsPercentage"
        Me.lblFactorsAsPercentage.Tag = "Factors as Percentage:"
        '
        'lblMarginName
        '
        resources.ApplyResources(Me.lblMarginName, "lblMarginName")
        Me.lblMarginName.Name = "lblMarginName"
        '
        'ucrInputMarginName
        '
        Me.ucrInputMarginName.AddQuotesIfUnrecognised = True
        Me.ucrInputMarginName.IsMultiline = False
        Me.ucrInputMarginName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMarginName, "ucrInputMarginName")
        Me.ucrInputMarginName.Name = "ucrInputMarginName"
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
        'ucrSaveTable
        '
        resources.ApplyResources(Me.ucrSaveTable, "ucrSaveTable")
        Me.ucrSaveTable.Name = "ucrSaveTable"
        '
        'ucrChkDisplayMargins
        '
        Me.ucrChkDisplayMargins.Checked = False
        resources.ApplyResources(Me.ucrChkDisplayMargins, "ucrChkDisplayMargins")
        Me.ucrChkDisplayMargins.Name = "ucrChkDisplayMargins"
        '
        'ucrChkStoreResults
        '
        Me.ucrChkStoreResults.Checked = False
        resources.ApplyResources(Me.ucrChkStoreResults, "ucrChkStoreResults")
        Me.ucrChkStoreResults.Name = "ucrChkStoreResults"
        '
        'ucrReceiverMultiplePercentages
        '
        Me.ucrReceiverMultiplePercentages.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverMultiplePercentages, "ucrReceiverMultiplePercentages")
        Me.ucrReceiverMultiplePercentages.Name = "ucrReceiverMultiplePercentages"
        Me.ucrReceiverMultiplePercentages.Selector = Nothing
        Me.ucrReceiverMultiplePercentages.strNcFilePath = ""
        Me.ucrReceiverMultiplePercentages.ucrSelector = Nothing
        '
        'ucrChkPercentageProportion
        '
        Me.ucrChkPercentageProportion.Checked = False
        resources.ApplyResources(Me.ucrChkPercentageProportion, "ucrChkPercentageProportion")
        Me.ucrChkPercentageProportion.Name = "ucrChkPercentageProportion"
        '
        'ucrChkDisplayAsPercentage
        '
        Me.ucrChkDisplayAsPercentage.Checked = False
        resources.ApplyResources(Me.ucrChkDisplayAsPercentage, "ucrChkDisplayAsPercentage")
        Me.ucrChkDisplayAsPercentage.Name = "ucrChkDisplayAsPercentage"
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
        'ucrSelectorFrequency
        '
        Me.ucrSelectorFrequency.bDropUnusedFilterLevels = False
        Me.ucrSelectorFrequency.bShowHiddenColumns = False
        Me.ucrSelectorFrequency.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorFrequency, "ucrSelectorFrequency")
        Me.ucrSelectorFrequency.Name = "ucrSelectorFrequency"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'UcrCheck1
        '
        Me.UcrCheck1.Checked = False
        resources.ApplyResources(Me.UcrCheck1, "UcrCheck1")
        Me.UcrCheck1.Name = "UcrCheck1"
        '
        'dlgFrequency
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputMarginName)
        Me.Controls.Add(Me.lblMarginName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ucrSaveTable)
        Me.Controls.Add(Me.ucrChkDisplayMargins)
        Me.Controls.Add(Me.ucrChkStoreResults)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.grpDisplay)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrReceiverFactors)
        Me.Controls.Add(Me.ucrSelectorFrequency)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFrequency"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpDisplay.ResumeLayout(False)
        Me.grpDisplay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorFrequency As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFactors As ucrReceiverMultiple
    Friend WithEvents lblFactors As Label
    Friend WithEvents ucrChkDisplayMargins As ucrCheck
    Friend WithEvents cmdOptions As Button
    Friend WithEvents UcrCheck1 As ucrCheck
    Friend WithEvents ucrChkStoreResults As ucrCheck
    Friend WithEvents ucrNudSigFigs As ucrNud
    Friend WithEvents ucrSaveTable As ucrSave
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblSigFigs As Label
    Friend WithEvents ucrChkPercentageProportion As ucrCheck
    Friend WithEvents grpDisplay As GroupBox
    Friend WithEvents lblFactorsAsPercentage As Label
    Friend WithEvents ucrReceiverMultiplePercentages As ucrReceiverMultiple
    Friend WithEvents ucrChkDisplayAsPercentage As ucrCheck
    Friend WithEvents ucrInputMarginName As ucrInputTextBox
    Friend WithEvents lblMarginName As Label
    Friend WithEvents ucrChkDisplaySummariesAsRow As ucrCheck
    Friend WithEvents ucrNudColumnFactors As ucrNud
    Friend WithEvents lblColumnFactors As Label
End Class
