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
Partial Class dlgSelect
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
        Me.grpApplyOptions = New System.Windows.Forms.GroupBox()
        Me.rdoApplySave = New System.Windows.Forms.RadioButton()
        Me.rdoApplyAsSubset = New System.Windows.Forms.RadioButton()
        Me.rdoApplyAsSelect = New System.Windows.Forms.RadioButton()
        Me.ucrPnlApplyOptions = New instat.UcrPanel()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkDialogue = New instat.ucrCheck()
        Me.ucrChkMetaData = New instat.ucrCheck()
        Me.ucrChkDataframe = New instat.ucrCheck()
        Me.lblSelection = New System.Windows.Forms.Label()
        Me.cmdDefineNewSelect = New System.Windows.Forms.Button()
        Me.lblSelectionPreview = New System.Windows.Forms.Label()
        Me.lblNewDataFrameName = New System.Windows.Forms.Label()
        Me.ucrInputNewDataFrameName = New instat.ucrInputComboBox()
        Me.ucrInputSelectPreview = New instat.ucrInputTextBox()
        Me.ucrReceiverSelect = New instat.ucrReceiverSingle()
        Me.ucrSelectorForSelectColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpApplyOptions.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpApplyOptions
        '
        Me.grpApplyOptions.Controls.Add(Me.rdoApplySave)
        Me.grpApplyOptions.Controls.Add(Me.rdoApplyAsSubset)
        Me.grpApplyOptions.Controls.Add(Me.rdoApplyAsSelect)
        Me.grpApplyOptions.Controls.Add(Me.ucrPnlApplyOptions)
        Me.grpApplyOptions.Location = New System.Drawing.Point(15, 309)
        Me.grpApplyOptions.Name = "grpApplyOptions"
        Me.grpApplyOptions.Size = New System.Drawing.Size(321, 152)
        Me.grpApplyOptions.TabIndex = 4
        Me.grpApplyOptions.TabStop = False
        Me.grpApplyOptions.Text = "Apply"
        '
        'rdoApplySave
        '
        Me.rdoApplySave.AutoSize = True
        Me.rdoApplySave.Location = New System.Drawing.Point(10, 105)
        Me.rdoApplySave.Name = "rdoApplySave"
        Me.rdoApplySave.Size = New System.Drawing.Size(122, 24)
        Me.rdoApplySave.TabIndex = 3
        Me.rdoApplySave.TabStop = True
        Me.rdoApplySave.Text = "Store Select"
        Me.rdoApplySave.UseVisualStyleBackColor = True
        '
        'rdoApplyAsSubset
        '
        Me.rdoApplyAsSubset.AutoSize = True
        Me.rdoApplyAsSubset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoApplyAsSubset.Location = New System.Drawing.Point(10, 70)
        Me.rdoApplyAsSubset.Name = "rdoApplyAsSubset"
        Me.rdoApplyAsSubset.Size = New System.Drawing.Size(108, 24)
        Me.rdoApplyAsSubset.TabIndex = 1
        Me.rdoApplyAsSubset.TabStop = True
        Me.rdoApplyAsSubset.Text = "As Subset"
        Me.rdoApplyAsSubset.UseVisualStyleBackColor = True
        '
        'rdoApplyAsSelect
        '
        Me.rdoApplyAsSelect.AutoSize = True
        Me.rdoApplyAsSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoApplyAsSelect.Location = New System.Drawing.Point(10, 36)
        Me.rdoApplyAsSelect.Name = "rdoApplyAsSelect"
        Me.rdoApplyAsSelect.Size = New System.Drawing.Size(186, 24)
        Me.rdoApplyAsSelect.TabIndex = 0
        Me.rdoApplyAsSelect.TabStop = True
        Me.rdoApplyAsSelect.Text = "As Selected Columns"
        Me.rdoApplyAsSelect.UseVisualStyleBackColor = True
        '
        'ucrPnlApplyOptions
        '
        Me.ucrPnlApplyOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlApplyOptions.Location = New System.Drawing.Point(6, 26)
        Me.ucrPnlApplyOptions.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrPnlApplyOptions.Name = "ucrPnlApplyOptions"
        Me.ucrPnlApplyOptions.Size = New System.Drawing.Size(290, 114)
        Me.ucrPnlApplyOptions.TabIndex = 2
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrChkDialogue)
        Me.grpOptions.Controls.Add(Me.ucrChkMetaData)
        Me.grpOptions.Controls.Add(Me.ucrChkDataframe)
        Me.grpOptions.Location = New System.Drawing.Point(344, 309)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(290, 152)
        Me.grpOptions.TabIndex = 3
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Apply To:"
        '
        'ucrChkDialogue
        '
        Me.ucrChkDialogue.AutoSize = True
        Me.ucrChkDialogue.Checked = False
        Me.ucrChkDialogue.Location = New System.Drawing.Point(15, 105)
        Me.ucrChkDialogue.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkDialogue.Name = "ucrChkDialogue"
        Me.ucrChkDialogue.Size = New System.Drawing.Size(266, 51)
        Me.ucrChkDialogue.TabIndex = 2
        '
        'ucrChkMetaData
        '
        Me.ucrChkMetaData.AutoSize = True
        Me.ucrChkMetaData.Checked = False
        Me.ucrChkMetaData.Location = New System.Drawing.Point(15, 63)
        Me.ucrChkMetaData.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkMetaData.Name = "ucrChkMetaData"
        Me.ucrChkMetaData.Size = New System.Drawing.Size(266, 51)
        Me.ucrChkMetaData.TabIndex = 1
        '
        'ucrChkDataframe
        '
        Me.ucrChkDataframe.AutoSize = True
        Me.ucrChkDataframe.Checked = False
        Me.ucrChkDataframe.Location = New System.Drawing.Point(15, 27)
        Me.ucrChkDataframe.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkDataframe.Name = "ucrChkDataframe"
        Me.ucrChkDataframe.Size = New System.Drawing.Size(266, 51)
        Me.ucrChkDataframe.TabIndex = 0
        '
        'lblSelection
        '
        Me.lblSelection.AutoSize = True
        Me.lblSelection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelection.Location = New System.Drawing.Point(375, 81)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.Size = New System.Drawing.Size(79, 20)
        Me.lblSelection.TabIndex = 1
        Me.lblSelection.Text = "Selection:"
        '
        'cmdDefineNewSelect
        '
        Me.cmdDefineNewSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDefineNewSelect.Location = New System.Drawing.Point(375, 147)
        Me.cmdDefineNewSelect.Name = "cmdDefineNewSelect"
        Me.cmdDefineNewSelect.Size = New System.Drawing.Size(237, 45)
        Me.cmdDefineNewSelect.TabIndex = 3
        Me.cmdDefineNewSelect.Tag = ""
        Me.cmdDefineNewSelect.Text = "Define New Selection"
        Me.cmdDefineNewSelect.UseVisualStyleBackColor = True
        '
        'lblSelectionPreview
        '
        Me.lblSelectionPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectionPreview.Location = New System.Drawing.Point(15, 560)
        Me.lblSelectionPreview.Name = "lblSelectionPreview"
        Me.lblSelectionPreview.Size = New System.Drawing.Size(213, 33)
        Me.lblSelectionPreview.TabIndex = 7
        Me.lblSelectionPreview.Text = "Selection Preview:"
        '
        'lblNewDataFrameName
        '
        Me.lblNewDataFrameName.AutoSize = True
        Me.lblNewDataFrameName.Location = New System.Drawing.Point(33, 513)
        Me.lblNewDataFrameName.Name = "lblNewDataFrameName"
        Me.lblNewDataFrameName.Size = New System.Drawing.Size(179, 20)
        Me.lblNewDataFrameName.TabIndex = 5
        Me.lblNewDataFrameName.Text = "New Data Frame Name:"
        '
        'ucrInputNewDataFrameName
        '
        Me.ucrInputNewDataFrameName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewDataFrameName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputNewDataFrameName.GetSetSelectedIndex = -1
        Me.ucrInputNewDataFrameName.IsReadOnly = False
        Me.ucrInputNewDataFrameName.Location = New System.Drawing.Point(219, 507)
        Me.ucrInputNewDataFrameName.Margin = New System.Windows.Forms.Padding(15, 15, 15, 15)
        Me.ucrInputNewDataFrameName.Name = "ucrInputNewDataFrameName"
        Me.ucrInputNewDataFrameName.Size = New System.Drawing.Size(207, 33)
        Me.ucrInputNewDataFrameName.TabIndex = 6
        '
        'ucrInputSelectPreview
        '
        Me.ucrInputSelectPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputSelectPreview.AutoSize = True
        Me.ucrInputSelectPreview.IsMultiline = True
        Me.ucrInputSelectPreview.IsReadOnly = False
        Me.ucrInputSelectPreview.Location = New System.Drawing.Point(240, 546)
        Me.ucrInputSelectPreview.Margin = New System.Windows.Forms.Padding(15, 15, 15, 15)
        Me.ucrInputSelectPreview.Name = "ucrInputSelectPreview"
        Me.ucrInputSelectPreview.Size = New System.Drawing.Size(381, 63)
        Me.ucrInputSelectPreview.TabIndex = 8
        '
        'ucrReceiverSelect
        '
        Me.ucrReceiverSelect.AutoSize = True
        Me.ucrReceiverSelect.frmParent = Me
        Me.ucrReceiverSelect.Location = New System.Drawing.Point(375, 105)
        Me.ucrReceiverSelect.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelect.Name = "ucrReceiverSelect"
        Me.ucrReceiverSelect.Selector = Nothing
        Me.ucrReceiverSelect.Size = New System.Drawing.Size(234, 30)
        Me.ucrReceiverSelect.strNcFilePath = ""
        Me.ucrReceiverSelect.TabIndex = 2
        Me.ucrReceiverSelect.ucrSelector = Nothing
        '
        'ucrSelectorForSelectColumns
        '
        Me.ucrSelectorForSelectColumns.AutoSize = True
        Me.ucrSelectorForSelectColumns.bDropUnusedFilterLevels = False
        Me.ucrSelectorForSelectColumns.bShowHiddenColumns = False
        Me.ucrSelectorForSelectColumns.bUseCurrentFilter = True
        Me.ucrSelectorForSelectColumns.Location = New System.Drawing.Point(15, 30)
        Me.ucrSelectorForSelectColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForSelectColumns.Name = "ucrSelectorForSelectColumns"
        Me.ucrSelectorForSelectColumns.Size = New System.Drawing.Size(321, 274)
        Me.ucrSelectorForSelectColumns.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 620)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 9
        '
        'dlgSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(645, 705)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.ucrInputNewDataFrameName)
        Me.Controls.Add(Me.lblNewDataFrameName)
        Me.Controls.Add(Me.lblSelectionPreview)
        Me.Controls.Add(Me.ucrInputSelectPreview)
        Me.Controls.Add(Me.ucrReceiverSelect)
        Me.Controls.Add(Me.lblSelection)
        Me.Controls.Add(Me.ucrSelectorForSelectColumns)
        Me.Controls.Add(Me.cmdDefineNewSelect)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpApplyOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Select"
        Me.Text = "Column Selection"
        Me.grpApplyOptions.ResumeLayout(False)
        Me.grpApplyOptions.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpApplyOptions As GroupBox
    Friend WithEvents rdoApplyAsSubset As RadioButton
    Friend WithEvents rdoApplyAsSelect As RadioButton
    Friend WithEvents ucrInputSelectPreview As ucrInputTextBox
    Friend WithEvents ucrReceiverSelect As ucrReceiverSingle
    Friend WithEvents lblSelection As Label
    Friend WithEvents ucrSelectorForSelectColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdDefineNewSelect As Button
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblSelectionPreview As Label
    Friend WithEvents ucrPnlApplyOptions As UcrPanel
    Friend WithEvents ucrInputNewDataFrameName As ucrInputComboBox
    Friend WithEvents lblNewDataFrameName As Label
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents ucrChkDialogue As ucrCheck
    Friend WithEvents ucrChkMetaData As ucrCheck
    Friend WithEvents ucrChkDataframe As ucrCheck
    Friend WithEvents rdoApplySave As RadioButton
End Class
