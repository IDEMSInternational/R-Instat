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
Partial Class sdgDataOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgDataOptions))
        Me.tbcDataOptions = New System.Windows.Forms.TabControl()
        Me.tbRows = New System.Windows.Forms.TabPage()
        Me.cmdRemoveCurrentFilter = New System.Windows.Forms.Button()
        Me.ucrSelectorFilters = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputFilterPreview = New instat.ucrInputTextBox()
        Me.lblFilterPreview = New System.Windows.Forms.Label()
        Me.grpApplyOptions = New System.Windows.Forms.GroupBox()
        Me.rdoForDialog = New System.Windows.Forms.RadioButton()
        Me.rdoAllDialogs = New System.Windows.Forms.RadioButton()
        Me.cmdDefineNewFilter = New System.Windows.Forms.Button()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.ucrReceiverFilter = New instat.ucrReceiverSingle()
        Me.tbColumns = New System.Windows.Forms.TabPage()
        Me.cmdRemoveCurrentColumnSelection = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoColumnsForThisDialog = New System.Windows.Forms.RadioButton()
        Me.rdoColumnsForAllDialogs = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverSelect = New instat.ucrReceiverSingle()
        Me.lblSelection = New System.Windows.Forms.Label()
        Me.ucrSelectorForSelectColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.cmdDefineNewSelect = New System.Windows.Forms.Button()
        Me.ucrSubDialogueBase = New instat.ucrButtonsSubdialogue()
        Me.tbcDataOptions.SuspendLayout()
        Me.tbRows.SuspendLayout()
        Me.grpApplyOptions.SuspendLayout()
        Me.tbColumns.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcDataOptions
        '
        Me.tbcDataOptions.Controls.Add(Me.tbRows)
        Me.tbcDataOptions.Controls.Add(Me.tbColumns)
        resources.ApplyResources(Me.tbcDataOptions, "tbcDataOptions")
        Me.tbcDataOptions.Name = "tbcDataOptions"
        Me.tbcDataOptions.SelectedIndex = 0
        '
        'tbRows
        '
        Me.tbRows.Controls.Add(Me.cmdRemoveCurrentFilter)
        Me.tbRows.Controls.Add(Me.ucrSelectorFilters)
        Me.tbRows.Controls.Add(Me.ucrInputFilterPreview)
        Me.tbRows.Controls.Add(Me.lblFilterPreview)
        Me.tbRows.Controls.Add(Me.grpApplyOptions)
        Me.tbRows.Controls.Add(Me.cmdDefineNewFilter)
        Me.tbRows.Controls.Add(Me.lblFilter)
        Me.tbRows.Controls.Add(Me.ucrReceiverFilter)
        resources.ApplyResources(Me.tbRows, "tbRows")
        Me.tbRows.Name = "tbRows"
        Me.tbRows.Tag = "Rows"
        Me.tbRows.UseVisualStyleBackColor = True
        '
        'cmdRemoveCurrentFilter
        '
        resources.ApplyResources(Me.cmdRemoveCurrentFilter, "cmdRemoveCurrentFilter")
        Me.cmdRemoveCurrentFilter.Name = "cmdRemoveCurrentFilter"
        Me.cmdRemoveCurrentFilter.Tag = "Define_New_Filter"
        Me.cmdRemoveCurrentFilter.UseVisualStyleBackColor = True
        '
        'ucrSelectorFilters
        '
        Me.ucrSelectorFilters.bDropUnusedFilterLevels = False
        Me.ucrSelectorFilters.bShowHiddenColumns = False
        Me.ucrSelectorFilters.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorFilters, "ucrSelectorFilters")
        Me.ucrSelectorFilters.Name = "ucrSelectorFilters"
        '
        'ucrInputFilterPreview
        '
        Me.ucrInputFilterPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputFilterPreview.IsMultiline = False
        Me.ucrInputFilterPreview.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFilterPreview, "ucrInputFilterPreview")
        Me.ucrInputFilterPreview.Name = "ucrInputFilterPreview"
        '
        'lblFilterPreview
        '
        resources.ApplyResources(Me.lblFilterPreview, "lblFilterPreview")
        Me.lblFilterPreview.Name = "lblFilterPreview"
        '
        'grpApplyOptions
        '
        Me.grpApplyOptions.Controls.Add(Me.rdoForDialog)
        Me.grpApplyOptions.Controls.Add(Me.rdoAllDialogs)
        resources.ApplyResources(Me.grpApplyOptions, "grpApplyOptions")
        Me.grpApplyOptions.Name = "grpApplyOptions"
        Me.grpApplyOptions.TabStop = False
        Me.grpApplyOptions.Tag = "Apply_Options"
        '
        'rdoForDialog
        '
        resources.ApplyResources(Me.rdoForDialog, "rdoForDialog")
        Me.rdoForDialog.Name = "rdoForDialog"
        Me.rdoForDialog.TabStop = True
        Me.rdoForDialog.UseVisualStyleBackColor = True
        '
        'rdoAllDialogs
        '
        resources.ApplyResources(Me.rdoAllDialogs, "rdoAllDialogs")
        Me.rdoAllDialogs.Name = "rdoAllDialogs"
        Me.rdoAllDialogs.TabStop = True
        Me.rdoAllDialogs.UseVisualStyleBackColor = True
        '
        'cmdDefineNewFilter
        '
        resources.ApplyResources(Me.cmdDefineNewFilter, "cmdDefineNewFilter")
        Me.cmdDefineNewFilter.Name = "cmdDefineNewFilter"
        Me.cmdDefineNewFilter.Tag = "Define_New_Filter"
        Me.cmdDefineNewFilter.UseVisualStyleBackColor = True
        '
        'lblFilter
        '
        resources.ApplyResources(Me.lblFilter, "lblFilter")
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Tag = "Filter"
        '
        'ucrReceiverFilter
        '
        Me.ucrReceiverFilter.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverFilter, "ucrReceiverFilter")
        Me.ucrReceiverFilter.Name = "ucrReceiverFilter"
        Me.ucrReceiverFilter.Selector = Nothing
        Me.ucrReceiverFilter.strNcFilePath = ""
        Me.ucrReceiverFilter.ucrSelector = Nothing
        '
        'tbColumns
        '
        Me.tbColumns.Controls.Add(Me.cmdRemoveCurrentColumnSelection)
        Me.tbColumns.Controls.Add(Me.GroupBox1)
        Me.tbColumns.Controls.Add(Me.ucrReceiverSelect)
        Me.tbColumns.Controls.Add(Me.lblSelection)
        Me.tbColumns.Controls.Add(Me.ucrSelectorForSelectColumns)
        Me.tbColumns.Controls.Add(Me.cmdDefineNewSelect)
        resources.ApplyResources(Me.tbColumns, "tbColumns")
        Me.tbColumns.Name = "tbColumns"
        Me.tbColumns.Tag = "Columns"
        Me.tbColumns.UseVisualStyleBackColor = True
        '
        'cmdRemoveCurrentColumnSelection
        '
        resources.ApplyResources(Me.cmdRemoveCurrentColumnSelection, "cmdRemoveCurrentColumnSelection")
        Me.cmdRemoveCurrentColumnSelection.Name = "cmdRemoveCurrentColumnSelection"
        Me.cmdRemoveCurrentColumnSelection.Tag = ""
        Me.cmdRemoveCurrentColumnSelection.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoColumnsForThisDialog)
        Me.GroupBox1.Controls.Add(Me.rdoColumnsForAllDialogs)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "Apply_Options"
        '
        'rdoColumnsForThisDialog
        '
        resources.ApplyResources(Me.rdoColumnsForThisDialog, "rdoColumnsForThisDialog")
        Me.rdoColumnsForThisDialog.Name = "rdoColumnsForThisDialog"
        Me.rdoColumnsForThisDialog.TabStop = True
        Me.rdoColumnsForThisDialog.UseVisualStyleBackColor = True
        '
        'rdoColumnsForAllDialogs
        '
        resources.ApplyResources(Me.rdoColumnsForAllDialogs, "rdoColumnsForAllDialogs")
        Me.rdoColumnsForAllDialogs.Name = "rdoColumnsForAllDialogs"
        Me.rdoColumnsForAllDialogs.TabStop = True
        Me.rdoColumnsForAllDialogs.UseVisualStyleBackColor = True
        '
        'ucrReceiverSelect
        '
        Me.ucrReceiverSelect.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverSelect, "ucrReceiverSelect")
        Me.ucrReceiverSelect.Name = "ucrReceiverSelect"
        Me.ucrReceiverSelect.Selector = Nothing
        Me.ucrReceiverSelect.strNcFilePath = ""
        Me.ucrReceiverSelect.ucrSelector = Nothing
        '
        'lblSelection
        '
        resources.ApplyResources(Me.lblSelection, "lblSelection")
        Me.lblSelection.Name = "lblSelection"
        '
        'ucrSelectorForSelectColumns
        '
        Me.ucrSelectorForSelectColumns.bDropUnusedFilterLevels = False
        Me.ucrSelectorForSelectColumns.bShowHiddenColumns = False
        Me.ucrSelectorForSelectColumns.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForSelectColumns, "ucrSelectorForSelectColumns")
        Me.ucrSelectorForSelectColumns.Name = "ucrSelectorForSelectColumns"
        '
        'cmdDefineNewSelect
        '
        resources.ApplyResources(Me.cmdDefineNewSelect, "cmdDefineNewSelect")
        Me.cmdDefineNewSelect.Name = "cmdDefineNewSelect"
        Me.cmdDefineNewSelect.Tag = ""
        Me.cmdDefineNewSelect.UseVisualStyleBackColor = True
        '
        'ucrSubDialogueBase
        '
        resources.ApplyResources(Me.ucrSubDialogueBase, "ucrSubDialogueBase")
        Me.ucrSubDialogueBase.Name = "ucrSubDialogueBase"
        '
        'sdgDataOptions
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbcDataOptions)
        Me.Controls.Add(Me.ucrSubDialogueBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgDataOptions"
        Me.Tag = "Data_Options"
        Me.tbcDataOptions.ResumeLayout(False)
        Me.tbRows.ResumeLayout(False)
        Me.tbRows.PerformLayout()
        Me.grpApplyOptions.ResumeLayout(False)
        Me.grpApplyOptions.PerformLayout()
        Me.tbColumns.ResumeLayout(False)
        Me.tbColumns.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSubDialogueBase As ucrButtonsSubdialogue
    Friend WithEvents tbcDataOptions As TabControl
    Friend WithEvents tbRows As TabPage
    Friend WithEvents tbColumns As TabPage
    Friend WithEvents cmdDefineNewFilter As Button
    Friend WithEvents lblFilter As Label
    Friend WithEvents ucrReceiverFilter As ucrReceiverSingle
    Friend WithEvents grpApplyOptions As GroupBox
    Friend WithEvents rdoForDialog As RadioButton
    Friend WithEvents rdoAllDialogs As RadioButton
    Friend WithEvents ucrInputFilterPreview As ucrInputTextBox
    Friend WithEvents lblFilterPreview As Label
    Friend WithEvents ucrSelectorFilters As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdRemoveCurrentFilter As Button
    Friend WithEvents ucrReceiverSelect As ucrReceiverSingle
    Friend WithEvents lblSelection As Label
    Friend WithEvents ucrSelectorForSelectColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdDefineNewSelect As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoColumnsForThisDialog As RadioButton
    Friend WithEvents rdoColumnsForAllDialogs As RadioButton
    Friend WithEvents cmdRemoveCurrentColumnSelection As Button
End Class
