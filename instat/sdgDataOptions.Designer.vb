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
        Me.tbcDataOptions = New System.Windows.Forms.TabControl()
        Me.tbRows = New System.Windows.Forms.TabPage()
        Me.cmdRemoveCurrentFilter = New System.Windows.Forms.Button()
        Me.ucrInputFilterPreview = New instat.ucrInputTextBox()
        Me.lblFilterPreview = New System.Windows.Forms.Label()
        Me.grpApplyOptions = New System.Windows.Forms.GroupBox()
        Me.rdoForDialog = New System.Windows.Forms.RadioButton()
        Me.rdoAllDialogs = New System.Windows.Forms.RadioButton()
        Me.cmdDefineNewFilter = New System.Windows.Forms.Button()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.ucrReceiverFilter = New instat.ucrReceiverSingle()
        Me.ucrSelectorFilters = New instat.ucrSelectorByDataFrameAddRemove()
        Me.tbColumns = New System.Windows.Forms.TabPage()
        Me.lblSelectPreview = New System.Windows.Forms.Label()
        Me.ucrInputSelectPreview = New instat.ucrInputTextBox()
        Me.cmdRemoveCurrentColumnSelection = New System.Windows.Forms.Button()
        Me.grpColumnsApplyOptions = New System.Windows.Forms.GroupBox()
        Me.rdoColumnsForThisDialog = New System.Windows.Forms.RadioButton()
        Me.rdoColumnsForAllDialogs = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverSelect = New instat.ucrReceiverSingle()
        Me.lblSelection = New System.Windows.Forms.Label()
        Me.cmdDefineNewSelect = New System.Windows.Forms.Button()
        Me.ucrSelectorForSelectColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSubDialogueBase = New instat.ucrButtonsSubdialogue()
        Me.tbcDataOptions.SuspendLayout()
        Me.tbRows.SuspendLayout()
        Me.grpApplyOptions.SuspendLayout()
        Me.tbColumns.SuspendLayout()
        Me.grpColumnsApplyOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcDataOptions
        '
        Me.tbcDataOptions.Controls.Add(Me.tbRows)
        Me.tbcDataOptions.Controls.Add(Me.tbColumns)
        Me.tbcDataOptions.Location = New System.Drawing.Point(9, 2)
        Me.tbcDataOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.tbcDataOptions.Name = "tbcDataOptions"
        Me.tbcDataOptions.SelectedIndex = 0
        Me.tbcDataOptions.Size = New System.Drawing.Size(544, 484)
        Me.tbcDataOptions.TabIndex = 0
        '
        'tbRows
        '
        Me.tbRows.Controls.Add(Me.cmdRemoveCurrentFilter)
        Me.tbRows.Controls.Add(Me.ucrInputFilterPreview)
        Me.tbRows.Controls.Add(Me.lblFilterPreview)
        Me.tbRows.Controls.Add(Me.grpApplyOptions)
        Me.tbRows.Controls.Add(Me.cmdDefineNewFilter)
        Me.tbRows.Controls.Add(Me.lblFilter)
        Me.tbRows.Controls.Add(Me.ucrReceiverFilter)
        Me.tbRows.Controls.Add(Me.ucrSelectorFilters)
        Me.tbRows.Location = New System.Drawing.Point(4, 29)
        Me.tbRows.Margin = New System.Windows.Forms.Padding(4)
        Me.tbRows.Name = "tbRows"
        Me.tbRows.Padding = New System.Windows.Forms.Padding(4)
        Me.tbRows.Size = New System.Drawing.Size(536, 451)
        Me.tbRows.TabIndex = 0
        Me.tbRows.Tag = "Rows"
        Me.tbRows.Text = "Rows"
        Me.tbRows.UseVisualStyleBackColor = True
        '
        'cmdRemoveCurrentFilter
        '
        Me.cmdRemoveCurrentFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRemoveCurrentFilter.Location = New System.Drawing.Point(342, 170)
        Me.cmdRemoveCurrentFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdRemoveCurrentFilter.Name = "cmdRemoveCurrentFilter"
        Me.cmdRemoveCurrentFilter.Size = New System.Drawing.Size(180, 57)
        Me.cmdRemoveCurrentFilter.TabIndex = 4
        Me.cmdRemoveCurrentFilter.Tag = "Define_New_Filter"
        Me.cmdRemoveCurrentFilter.Text = "Remove Current Filter"
        Me.cmdRemoveCurrentFilter.UseVisualStyleBackColor = True
        '
        'ucrInputFilterPreview
        '
        Me.ucrInputFilterPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputFilterPreview.AutoSize = True
        Me.ucrInputFilterPreview.IsMultiline = False
        Me.ucrInputFilterPreview.IsReadOnly = False
        Me.ucrInputFilterPreview.Location = New System.Drawing.Point(192, 314)
        Me.ucrInputFilterPreview.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputFilterPreview.Name = "ucrInputFilterPreview"
        Me.ucrInputFilterPreview.Size = New System.Drawing.Size(330, 32)
        Me.ucrInputFilterPreview.TabIndex = 6
        '
        'lblFilterPreview
        '
        Me.lblFilterPreview.AutoSize = True
        Me.lblFilterPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFilterPreview.Location = New System.Drawing.Point(12, 316)
        Me.lblFilterPreview.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFilterPreview.Name = "lblFilterPreview"
        Me.lblFilterPreview.Size = New System.Drawing.Size(169, 20)
        Me.lblFilterPreview.TabIndex = 5
        Me.lblFilterPreview.Text = "Selected Filter Preview"
        '
        'grpApplyOptions
        '
        Me.grpApplyOptions.Controls.Add(Me.rdoForDialog)
        Me.grpApplyOptions.Controls.Add(Me.rdoAllDialogs)
        Me.grpApplyOptions.Location = New System.Drawing.Point(12, 354)
        Me.grpApplyOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.grpApplyOptions.Name = "grpApplyOptions"
        Me.grpApplyOptions.Padding = New System.Windows.Forms.Padding(4)
        Me.grpApplyOptions.Size = New System.Drawing.Size(510, 87)
        Me.grpApplyOptions.TabIndex = 7
        Me.grpApplyOptions.TabStop = False
        Me.grpApplyOptions.Tag = "Apply_Options"
        Me.grpApplyOptions.Text = "Apply Options"
        '
        'rdoForDialog
        '
        Me.rdoForDialog.AutoSize = True
        Me.rdoForDialog.Enabled = False
        Me.rdoForDialog.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoForDialog.Location = New System.Drawing.Point(15, 52)
        Me.rdoForDialog.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoForDialog.Name = "rdoForDialog"
        Me.rdoForDialog.Size = New System.Drawing.Size(175, 24)
        Me.rdoForDialog.TabIndex = 1
        Me.rdoForDialog.TabStop = True
        Me.rdoForDialog.Text = "For This Dialog Only"
        Me.rdoForDialog.UseVisualStyleBackColor = True
        Me.rdoForDialog.Visible = False
        '
        'rdoAllDialogs
        '
        Me.rdoAllDialogs.AutoSize = True
        Me.rdoAllDialogs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAllDialogs.Location = New System.Drawing.Point(15, 22)
        Me.rdoAllDialogs.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoAllDialogs.Name = "rdoAllDialogs"
        Me.rdoAllDialogs.Size = New System.Drawing.Size(136, 24)
        Me.rdoAllDialogs.TabIndex = 0
        Me.rdoAllDialogs.TabStop = True
        Me.rdoAllDialogs.Text = "For All Dialogs"
        Me.rdoAllDialogs.UseVisualStyleBackColor = True
        '
        'cmdDefineNewFilter
        '
        Me.cmdDefineNewFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDefineNewFilter.Location = New System.Drawing.Point(342, 99)
        Me.cmdDefineNewFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDefineNewFilter.Name = "cmdDefineNewFilter"
        Me.cmdDefineNewFilter.Size = New System.Drawing.Size(180, 62)
        Me.cmdDefineNewFilter.TabIndex = 3
        Me.cmdDefineNewFilter.Tag = "Define_New_Filter"
        Me.cmdDefineNewFilter.Text = "Define New Filter"
        Me.cmdDefineNewFilter.UseVisualStyleBackColor = True
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFilter.Location = New System.Drawing.Point(338, 30)
        Me.lblFilter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(48, 20)
        Me.lblFilter.TabIndex = 1
        Me.lblFilter.Tag = "Filter"
        Me.lblFilter.Text = "Filter:"
        '
        'ucrReceiverFilter
        '
        Me.ucrReceiverFilter.AutoSize = True
        Me.ucrReceiverFilter.frmParent = Nothing
        Me.ucrReceiverFilter.Location = New System.Drawing.Point(342, 52)
        Me.ucrReceiverFilter.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFilter.Name = "ucrReceiverFilter"
        Me.ucrReceiverFilter.Selector = Nothing
        Me.ucrReceiverFilter.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverFilter.strNcFilePath = ""
        Me.ucrReceiverFilter.TabIndex = 2
        Me.ucrReceiverFilter.ucrSelector = Nothing
        '
        'ucrSelectorFilters
        '
        Me.ucrSelectorFilters.AutoSize = True
        Me.ucrSelectorFilters.bDropUnusedFilterLevels = False
        Me.ucrSelectorFilters.bShowHiddenColumns = False
        Me.ucrSelectorFilters.bUseCurrentFilter = True
        Me.ucrSelectorFilters.Location = New System.Drawing.Point(4, 22)
        Me.ucrSelectorFilters.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFilters.Name = "ucrSelectorFilters"
        Me.ucrSelectorFilters.Size = New System.Drawing.Size(477, 411)
        Me.ucrSelectorFilters.TabIndex = 0
        '
        'tbColumns
        '
        Me.tbColumns.Controls.Add(Me.lblSelectPreview)
        Me.tbColumns.Controls.Add(Me.ucrInputSelectPreview)
        Me.tbColumns.Controls.Add(Me.cmdRemoveCurrentColumnSelection)
        Me.tbColumns.Controls.Add(Me.grpColumnsApplyOptions)
        Me.tbColumns.Controls.Add(Me.ucrReceiverSelect)
        Me.tbColumns.Controls.Add(Me.lblSelection)
        Me.tbColumns.Controls.Add(Me.cmdDefineNewSelect)
        Me.tbColumns.Controls.Add(Me.ucrSelectorForSelectColumns)
        Me.tbColumns.Location = New System.Drawing.Point(4, 29)
        Me.tbColumns.Margin = New System.Windows.Forms.Padding(4)
        Me.tbColumns.Name = "tbColumns"
        Me.tbColumns.Padding = New System.Windows.Forms.Padding(4)
        Me.tbColumns.Size = New System.Drawing.Size(536, 451)
        Me.tbColumns.TabIndex = 1
        Me.tbColumns.Tag = "Columns"
        Me.tbColumns.Text = "Columns"
        Me.tbColumns.UseVisualStyleBackColor = True
        '
        'lblSelectPreview
        '
        Me.lblSelectPreview.AutoSize = True
        Me.lblSelectPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectPreview.Location = New System.Drawing.Point(12, 316)
        Me.lblSelectPreview.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectPreview.Name = "lblSelectPreview"
        Me.lblSelectPreview.Size = New System.Drawing.Size(137, 20)
        Me.lblSelectPreview.TabIndex = 10
        Me.lblSelectPreview.Text = "Selection Preview:"
        '
        'ucrInputSelectPreview
        '
        Me.ucrInputSelectPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputSelectPreview.AutoSize = True
        Me.ucrInputSelectPreview.IsMultiline = True
        Me.ucrInputSelectPreview.IsReadOnly = False
        Me.ucrInputSelectPreview.Location = New System.Drawing.Point(151, 314)
        Me.ucrInputSelectPreview.Margin = New System.Windows.Forms.Padding(15)
        Me.ucrInputSelectPreview.Name = "ucrInputSelectPreview"
        Me.ucrInputSelectPreview.Size = New System.Drawing.Size(364, 30)
        Me.ucrInputSelectPreview.TabIndex = 9
        '
        'cmdRemoveCurrentColumnSelection
        '
        Me.cmdRemoveCurrentColumnSelection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRemoveCurrentColumnSelection.Location = New System.Drawing.Point(339, 192)
        Me.cmdRemoveCurrentColumnSelection.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdRemoveCurrentColumnSelection.Name = "cmdRemoveCurrentColumnSelection"
        Me.cmdRemoveCurrentColumnSelection.Size = New System.Drawing.Size(189, 57)
        Me.cmdRemoveCurrentColumnSelection.TabIndex = 4
        Me.cmdRemoveCurrentColumnSelection.Tag = ""
        Me.cmdRemoveCurrentColumnSelection.Text = "Remove Current Selection"
        Me.cmdRemoveCurrentColumnSelection.UseVisualStyleBackColor = True
        '
        'grpColumnsApplyOptions
        '
        Me.grpColumnsApplyOptions.Controls.Add(Me.rdoColumnsForThisDialog)
        Me.grpColumnsApplyOptions.Controls.Add(Me.rdoColumnsForAllDialogs)
        Me.grpColumnsApplyOptions.Location = New System.Drawing.Point(6, 351)
        Me.grpColumnsApplyOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.grpColumnsApplyOptions.Name = "grpColumnsApplyOptions"
        Me.grpColumnsApplyOptions.Padding = New System.Windows.Forms.Padding(4)
        Me.grpColumnsApplyOptions.Size = New System.Drawing.Size(510, 87)
        Me.grpColumnsApplyOptions.TabIndex = 5
        Me.grpColumnsApplyOptions.TabStop = False
        Me.grpColumnsApplyOptions.Tag = "Apply_Options"
        Me.grpColumnsApplyOptions.Text = "Apply Options"
        '
        'rdoColumnsForThisDialog
        '
        Me.rdoColumnsForThisDialog.AutoSize = True
        Me.rdoColumnsForThisDialog.Enabled = False
        Me.rdoColumnsForThisDialog.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoColumnsForThisDialog.Location = New System.Drawing.Point(15, 52)
        Me.rdoColumnsForThisDialog.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoColumnsForThisDialog.Name = "rdoColumnsForThisDialog"
        Me.rdoColumnsForThisDialog.Size = New System.Drawing.Size(175, 24)
        Me.rdoColumnsForThisDialog.TabIndex = 1
        Me.rdoColumnsForThisDialog.TabStop = True
        Me.rdoColumnsForThisDialog.Text = "For This Dialog Only"
        Me.rdoColumnsForThisDialog.UseVisualStyleBackColor = True
        Me.rdoColumnsForThisDialog.Visible = False
        '
        'rdoColumnsForAllDialogs
        '
        Me.rdoColumnsForAllDialogs.AutoSize = True
        Me.rdoColumnsForAllDialogs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoColumnsForAllDialogs.Location = New System.Drawing.Point(15, 22)
        Me.rdoColumnsForAllDialogs.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoColumnsForAllDialogs.Name = "rdoColumnsForAllDialogs"
        Me.rdoColumnsForAllDialogs.Size = New System.Drawing.Size(136, 24)
        Me.rdoColumnsForAllDialogs.TabIndex = 0
        Me.rdoColumnsForAllDialogs.TabStop = True
        Me.rdoColumnsForAllDialogs.Text = "For All Dialogs"
        Me.rdoColumnsForAllDialogs.UseVisualStyleBackColor = True
        '
        'ucrReceiverSelect
        '
        Me.ucrReceiverSelect.AutoSize = True
        Me.ucrReceiverSelect.frmParent = Nothing
        Me.ucrReceiverSelect.Location = New System.Drawing.Point(338, 80)
        Me.ucrReceiverSelect.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelect.Name = "ucrReceiverSelect"
        Me.ucrReceiverSelect.Selector = Nothing
        Me.ucrReceiverSelect.Size = New System.Drawing.Size(190, 30)
        Me.ucrReceiverSelect.strNcFilePath = ""
        Me.ucrReceiverSelect.TabIndex = 2
        Me.ucrReceiverSelect.ucrSelector = Nothing
        '
        'lblSelection
        '
        Me.lblSelection.AutoSize = True
        Me.lblSelection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelection.Location = New System.Drawing.Point(334, 56)
        Me.lblSelection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.Size = New System.Drawing.Size(79, 20)
        Me.lblSelection.TabIndex = 1
        Me.lblSelection.Text = "Selection:"
        '
        'cmdDefineNewSelect
        '
        Me.cmdDefineNewSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDefineNewSelect.Location = New System.Drawing.Point(338, 122)
        Me.cmdDefineNewSelect.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDefineNewSelect.Name = "cmdDefineNewSelect"
        Me.cmdDefineNewSelect.Size = New System.Drawing.Size(190, 62)
        Me.cmdDefineNewSelect.TabIndex = 3
        Me.cmdDefineNewSelect.Tag = ""
        Me.cmdDefineNewSelect.Text = "Define New Selection"
        Me.cmdDefineNewSelect.UseVisualStyleBackColor = True
        '
        'ucrSelectorForSelectColumns
        '
        Me.ucrSelectorForSelectColumns.AutoSize = True
        Me.ucrSelectorForSelectColumns.bDropUnusedFilterLevels = False
        Me.ucrSelectorForSelectColumns.bShowHiddenColumns = False
        Me.ucrSelectorForSelectColumns.bUseCurrentFilter = True
        Me.ucrSelectorForSelectColumns.Location = New System.Drawing.Point(4, 4)
        Me.ucrSelectorForSelectColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForSelectColumns.Name = "ucrSelectorForSelectColumns"
        Me.ucrSelectorForSelectColumns.Size = New System.Drawing.Size(477, 411)
        Me.ucrSelectorForSelectColumns.TabIndex = 0
        '
        'ucrSubDialogueBase
        '
        Me.ucrSubDialogueBase.AutoSize = True
        Me.ucrSubDialogueBase.Location = New System.Drawing.Point(111, 484)
        Me.ucrSubDialogueBase.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrSubDialogueBase.Name = "ucrSubDialogueBase"
        Me.ucrSubDialogueBase.Size = New System.Drawing.Size(336, 45)
        Me.ucrSubDialogueBase.TabIndex = 1
        '
        'sdgDataOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(562, 526)
        Me.Controls.Add(Me.tbcDataOptions)
        Me.Controls.Add(Me.ucrSubDialogueBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgDataOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Data_Options"
        Me.Text = "Data Options"
        Me.tbcDataOptions.ResumeLayout(False)
        Me.tbRows.ResumeLayout(False)
        Me.tbRows.PerformLayout()
        Me.grpApplyOptions.ResumeLayout(False)
        Me.grpApplyOptions.PerformLayout()
        Me.tbColumns.ResumeLayout(False)
        Me.tbColumns.PerformLayout()
        Me.grpColumnsApplyOptions.ResumeLayout(False)
        Me.grpColumnsApplyOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents grpColumnsApplyOptions As GroupBox
    Friend WithEvents rdoColumnsForThisDialog As RadioButton
    Friend WithEvents rdoColumnsForAllDialogs As RadioButton
    Friend WithEvents cmdRemoveCurrentColumnSelection As Button
    Friend WithEvents lblSelectPreview As Label
    Friend WithEvents ucrInputSelectPreview As ucrInputTextBox
End Class
