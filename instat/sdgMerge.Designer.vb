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
Partial Class sdgMerge
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgMerge))
        Me.ttJoinDetails = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpKeys = New System.Windows.Forms.GroupBox()
        Me.cmdAddPair = New System.Windows.Forms.Button()
        Me.lblFirstKeyMatch = New System.Windows.Forms.Label()
        Me.ucrReceiverSecondDF = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirstDF = New instat.ucrReceiverSingle()
        Me.pnlKeyColumns = New System.Windows.Forms.Panel()
        Me.cmdRemoveAll = New System.Windows.Forms.Button()
        Me.lstKeyColumns = New System.Windows.Forms.ListView()
        Me.lblKeyColumns = New System.Windows.Forms.Label()
        Me.cmdRemoveSelectedPair = New System.Windows.Forms.Button()
        Me.tbcMergeOptions = New System.Windows.Forms.TabControl()
        Me.tpJoinByOptions = New System.Windows.Forms.TabPage()
        Me.rdoChooseColumns = New System.Windows.Forms.RadioButton()
        Me.rdoByAllMatching = New System.Windows.Forms.RadioButton()
        Me.ucrSelectorSecondDF = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSelectorFirstDF = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlMergeByOptions = New instat.UcrPanel()
        Me.tpIncludeColumns = New System.Windows.Forms.TabPage()
        Me.ucrChkMergeWithSubsetSecond = New instat.ucrCheck()
        Me.ucrChkMergeWithSubsetFirst = New instat.ucrCheck()
        Me.lblVariablesToIncludeSecond = New System.Windows.Forms.Label()
        Me.lblVariablesToIncludeFirst = New System.Windows.Forms.Label()
        Me.ucrReceiverSecondSelected = New instat.ucrReceiverMultiple()
        Me.ucrReceiverFirstSelected = New instat.ucrReceiverMultiple()
        Me.ucrSelectorColumnsToIncludeSecond = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSelectorColumnsToIncludeFirst = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSubBase = New instat.ucrButtonsSubdialogue()
        Me.grpKeys.SuspendLayout()
        Me.pnlKeyColumns.SuspendLayout()
        Me.tbcMergeOptions.SuspendLayout()
        Me.tpJoinByOptions.SuspendLayout()
        Me.tpIncludeColumns.SuspendLayout()
        Me.SuspendLayout()
        '
        'ttJoinDetails
        '
        Me.ttJoinDetails.AutoPopDelay = 10000
        Me.ttJoinDetails.InitialDelay = 500
        Me.ttJoinDetails.ReshowDelay = 100
        '
        'grpKeys
        '
        Me.grpKeys.Controls.Add(Me.cmdAddPair)
        Me.grpKeys.Controls.Add(Me.lblFirstKeyMatch)
        Me.grpKeys.Controls.Add(Me.ucrReceiverSecondDF)
        Me.grpKeys.Controls.Add(Me.ucrReceiverFirstDF)
        resources.ApplyResources(Me.grpKeys, "grpKeys")
        Me.grpKeys.Name = "grpKeys"
        Me.grpKeys.TabStop = False
        '
        'cmdAddPair
        '
        resources.ApplyResources(Me.cmdAddPair, "cmdAddPair")
        Me.cmdAddPair.Name = "cmdAddPair"
        Me.cmdAddPair.UseVisualStyleBackColor = True
        '
        'lblFirstKeyMatch
        '
        resources.ApplyResources(Me.lblFirstKeyMatch, "lblFirstKeyMatch")
        Me.lblFirstKeyMatch.Name = "lblFirstKeyMatch"
        '
        'ucrReceiverSecondDF
        '
        Me.ucrReceiverSecondDF.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverSecondDF, "ucrReceiverSecondDF")
        Me.ucrReceiverSecondDF.Name = "ucrReceiverSecondDF"
        Me.ucrReceiverSecondDF.Selector = Nothing
        Me.ucrReceiverSecondDF.strNcFilePath = ""
        Me.ucrReceiverSecondDF.ucrSelector = Nothing
        '
        'ucrReceiverFirstDF
        '
        Me.ucrReceiverFirstDF.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverFirstDF, "ucrReceiverFirstDF")
        Me.ucrReceiverFirstDF.Name = "ucrReceiverFirstDF"
        Me.ucrReceiverFirstDF.Selector = Nothing
        Me.ucrReceiverFirstDF.strNcFilePath = ""
        Me.ucrReceiverFirstDF.ucrSelector = Nothing
        '
        'pnlKeyColumns
        '
        Me.pnlKeyColumns.Controls.Add(Me.cmdRemoveAll)
        Me.pnlKeyColumns.Controls.Add(Me.lstKeyColumns)
        Me.pnlKeyColumns.Controls.Add(Me.lblKeyColumns)
        Me.pnlKeyColumns.Controls.Add(Me.cmdRemoveSelectedPair)
        resources.ApplyResources(Me.pnlKeyColumns, "pnlKeyColumns")
        Me.pnlKeyColumns.Name = "pnlKeyColumns"
        '
        'cmdRemoveAll
        '
        resources.ApplyResources(Me.cmdRemoveAll, "cmdRemoveAll")
        Me.cmdRemoveAll.Name = "cmdRemoveAll"
        Me.cmdRemoveAll.UseVisualStyleBackColor = True
        '
        'lstKeyColumns
        '
        Me.lstKeyColumns.FullRowSelect = True
        resources.ApplyResources(Me.lstKeyColumns, "lstKeyColumns")
        Me.lstKeyColumns.Name = "lstKeyColumns"
        Me.lstKeyColumns.UseCompatibleStateImageBehavior = False
        Me.lstKeyColumns.View = System.Windows.Forms.View.Details
        '
        'lblKeyColumns
        '
        resources.ApplyResources(Me.lblKeyColumns, "lblKeyColumns")
        Me.lblKeyColumns.Name = "lblKeyColumns"
        '
        'cmdRemoveSelectedPair
        '
        resources.ApplyResources(Me.cmdRemoveSelectedPair, "cmdRemoveSelectedPair")
        Me.cmdRemoveSelectedPair.Name = "cmdRemoveSelectedPair"
        Me.cmdRemoveSelectedPair.UseVisualStyleBackColor = True
        '
        'tbcMergeOptions
        '
        Me.tbcMergeOptions.Controls.Add(Me.tpJoinByOptions)
        Me.tbcMergeOptions.Controls.Add(Me.tpIncludeColumns)
        resources.ApplyResources(Me.tbcMergeOptions, "tbcMergeOptions")
        Me.tbcMergeOptions.Name = "tbcMergeOptions"
        Me.tbcMergeOptions.SelectedIndex = 0
        '
        'tpJoinByOptions
        '
        Me.tpJoinByOptions.Controls.Add(Me.rdoChooseColumns)
        Me.tpJoinByOptions.Controls.Add(Me.rdoByAllMatching)
        Me.tpJoinByOptions.Controls.Add(Me.ucrSelectorSecondDF)
        Me.tpJoinByOptions.Controls.Add(Me.ucrSelectorFirstDF)
        Me.tpJoinByOptions.Controls.Add(Me.pnlKeyColumns)
        Me.tpJoinByOptions.Controls.Add(Me.grpKeys)
        Me.tpJoinByOptions.Controls.Add(Me.ucrPnlMergeByOptions)
        resources.ApplyResources(Me.tpJoinByOptions, "tpJoinByOptions")
        Me.tpJoinByOptions.Name = "tpJoinByOptions"
        Me.tpJoinByOptions.UseVisualStyleBackColor = True
        '
        'rdoChooseColumns
        '
        resources.ApplyResources(Me.rdoChooseColumns, "rdoChooseColumns")
        Me.rdoChooseColumns.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoChooseColumns.FlatAppearance.BorderSize = 2
        Me.rdoChooseColumns.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoChooseColumns.Name = "rdoChooseColumns"
        Me.rdoChooseColumns.UseVisualStyleBackColor = True
        '
        'rdoByAllMatching
        '
        resources.ApplyResources(Me.rdoByAllMatching, "rdoByAllMatching")
        Me.rdoByAllMatching.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoByAllMatching.FlatAppearance.BorderSize = 2
        Me.rdoByAllMatching.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoByAllMatching.Name = "rdoByAllMatching"
        Me.rdoByAllMatching.UseVisualStyleBackColor = True
        '
        'ucrSelectorSecondDF
        '
        Me.ucrSelectorSecondDF.bShowHiddenColumns = False
        Me.ucrSelectorSecondDF.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorSecondDF, "ucrSelectorSecondDF")
        Me.ucrSelectorSecondDF.Name = "ucrSelectorSecondDF"
        '
        'ucrSelectorFirstDF
        '
        Me.ucrSelectorFirstDF.bShowHiddenColumns = False
        Me.ucrSelectorFirstDF.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorFirstDF, "ucrSelectorFirstDF")
        Me.ucrSelectorFirstDF.Name = "ucrSelectorFirstDF"
        '
        'ucrPnlMergeByOptions
        '
        resources.ApplyResources(Me.ucrPnlMergeByOptions, "ucrPnlMergeByOptions")
        Me.ucrPnlMergeByOptions.Name = "ucrPnlMergeByOptions"
        '
        'tpIncludeColumns
        '
        Me.tpIncludeColumns.Controls.Add(Me.ucrChkMergeWithSubsetSecond)
        Me.tpIncludeColumns.Controls.Add(Me.ucrChkMergeWithSubsetFirst)
        Me.tpIncludeColumns.Controls.Add(Me.lblVariablesToIncludeSecond)
        Me.tpIncludeColumns.Controls.Add(Me.lblVariablesToIncludeFirst)
        Me.tpIncludeColumns.Controls.Add(Me.ucrReceiverSecondSelected)
        Me.tpIncludeColumns.Controls.Add(Me.ucrReceiverFirstSelected)
        Me.tpIncludeColumns.Controls.Add(Me.ucrSelectorColumnsToIncludeSecond)
        Me.tpIncludeColumns.Controls.Add(Me.ucrSelectorColumnsToIncludeFirst)
        resources.ApplyResources(Me.tpIncludeColumns, "tpIncludeColumns")
        Me.tpIncludeColumns.Name = "tpIncludeColumns"
        Me.tpIncludeColumns.UseVisualStyleBackColor = True
        '
        'ucrChkMergeWithSubsetSecond
        '
        Me.ucrChkMergeWithSubsetSecond.Checked = False
        resources.ApplyResources(Me.ucrChkMergeWithSubsetSecond, "ucrChkMergeWithSubsetSecond")
        Me.ucrChkMergeWithSubsetSecond.Name = "ucrChkMergeWithSubsetSecond"
        '
        'ucrChkMergeWithSubsetFirst
        '
        Me.ucrChkMergeWithSubsetFirst.Checked = False
        resources.ApplyResources(Me.ucrChkMergeWithSubsetFirst, "ucrChkMergeWithSubsetFirst")
        Me.ucrChkMergeWithSubsetFirst.Name = "ucrChkMergeWithSubsetFirst"
        '
        'lblVariablesToIncludeSecond
        '
        resources.ApplyResources(Me.lblVariablesToIncludeSecond, "lblVariablesToIncludeSecond")
        Me.lblVariablesToIncludeSecond.Name = "lblVariablesToIncludeSecond"
        '
        'lblVariablesToIncludeFirst
        '
        resources.ApplyResources(Me.lblVariablesToIncludeFirst, "lblVariablesToIncludeFirst")
        Me.lblVariablesToIncludeFirst.Name = "lblVariablesToIncludeFirst"
        '
        'ucrReceiverSecondSelected
        '
        Me.ucrReceiverSecondSelected.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverSecondSelected, "ucrReceiverSecondSelected")
        Me.ucrReceiverSecondSelected.Name = "ucrReceiverSecondSelected"
        Me.ucrReceiverSecondSelected.Selector = Nothing
        Me.ucrReceiverSecondSelected.strNcFilePath = ""
        Me.ucrReceiverSecondSelected.ucrSelector = Nothing
        '
        'ucrReceiverFirstSelected
        '
        Me.ucrReceiverFirstSelected.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverFirstSelected, "ucrReceiverFirstSelected")
        Me.ucrReceiverFirstSelected.Name = "ucrReceiverFirstSelected"
        Me.ucrReceiverFirstSelected.Selector = Nothing
        Me.ucrReceiverFirstSelected.strNcFilePath = ""
        Me.ucrReceiverFirstSelected.ucrSelector = Nothing
        '
        'ucrSelectorColumnsToIncludeSecond
        '
        Me.ucrSelectorColumnsToIncludeSecond.bShowHiddenColumns = False
        Me.ucrSelectorColumnsToIncludeSecond.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorColumnsToIncludeSecond, "ucrSelectorColumnsToIncludeSecond")
        Me.ucrSelectorColumnsToIncludeSecond.Name = "ucrSelectorColumnsToIncludeSecond"
        '
        'ucrSelectorColumnsToIncludeFirst
        '
        Me.ucrSelectorColumnsToIncludeFirst.bShowHiddenColumns = False
        Me.ucrSelectorColumnsToIncludeFirst.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorColumnsToIncludeFirst, "ucrSelectorColumnsToIncludeFirst")
        Me.ucrSelectorColumnsToIncludeFirst.Name = "ucrSelectorColumnsToIncludeFirst"
        '
        'ucrSubBase
        '
        resources.ApplyResources(Me.ucrSubBase, "ucrSubBase")
        Me.ucrSubBase.Name = "ucrSubBase"
        '
        'sdgMerge
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbcMergeOptions)
        Me.Controls.Add(Me.ucrSubBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgMerge"
        Me.grpKeys.ResumeLayout(False)
        Me.grpKeys.PerformLayout()
        Me.pnlKeyColumns.ResumeLayout(False)
        Me.pnlKeyColumns.PerformLayout()
        Me.tbcMergeOptions.ResumeLayout(False)
        Me.tpJoinByOptions.ResumeLayout(False)
        Me.tpIncludeColumns.ResumeLayout(False)
        Me.tpIncludeColumns.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSubBase As ucrButtonsSubdialogue
    Friend WithEvents ttJoinDetails As ToolTip
    Friend WithEvents ucrSelectorSecondDF As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectorFirstDF As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpKeys As GroupBox
    Friend WithEvents cmdAddPair As Button
    Friend WithEvents lblFirstKeyMatch As Label
    Friend WithEvents ucrReceiverSecondDF As ucrReceiverSingle
    Friend WithEvents tbcMergeOptions As TabControl
    Friend WithEvents tpJoinByOptions As TabPage
    Friend WithEvents pnlKeyColumns As Panel
    Friend WithEvents cmdRemoveAll As Button
    Friend WithEvents lstKeyColumns As ListView
    Friend WithEvents lblKeyColumns As Label
    Friend WithEvents cmdRemoveSelectedPair As Button
    Friend WithEvents tpIncludeColumns As TabPage
    Friend WithEvents ucrReceiverFirstDF As ucrReceiverSingle
    Friend WithEvents ucrPnlMergeByOptions As UcrPanel
    Friend WithEvents lblVariablesToIncludeSecond As Label
    Friend WithEvents lblVariablesToIncludeFirst As Label
    Friend WithEvents ucrReceiverSecondSelected As ucrReceiverMultiple
    Friend WithEvents ucrReceiverFirstSelected As ucrReceiverMultiple
    Friend WithEvents ucrSelectorColumnsToIncludeSecond As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectorColumnsToIncludeFirst As ucrSelectorByDataFrameAddRemove
    Friend WithEvents rdoChooseColumns As RadioButton
    Friend WithEvents rdoByAllMatching As RadioButton
    Friend WithEvents ucrChkMergeWithSubsetSecond As ucrCheck
    Friend WithEvents ucrChkMergeWithSubsetFirst As ucrCheck
End Class
