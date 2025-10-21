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
Partial Class dlgName
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCurrentName = New System.Windows.Forms.Label()
        Me.lblVariableLabel = New System.Windows.Forms.Label()
        Me.rdoMultiple = New System.Windows.Forms.RadioButton()
        Me.rdoSingle = New System.Windows.Forms.RadioButton()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.rdoToLower = New System.Windows.Forms.RadioButton()
        Me.rdoMakeCleanNames = New System.Windows.Forms.RadioButton()
        Me.lblCase = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.rdoReplace = New System.Windows.Forms.RadioButton()
        Me.lblBy = New System.Windows.Forms.Label()
        Me.lblReplace = New System.Windows.Forms.Label()
        Me.ucrInputBy = New instat.ucrInputTextBox()
        Me.ucrInputEdit = New instat.ucrInputComboBox()
        Me.ucrInputReplace = New instat.ucrInputTextBox()
        Me.ucrNudAbbreviate = New instat.ucrNud()
        Me.rdoAbbreviate = New System.Windows.Forms.RadioButton()
        Me.ucrInputCase = New instat.ucrInputComboBox()
        Me.ucrPnlCase = New instat.UcrPanel()
        Me.rdoRenameWith = New System.Windows.Forms.RadioButton()
        Me.grdRenameColumns = New unvell.ReoGrid.ReoGridControl()
        Me.rdoSelectedColumn = New System.Windows.Forms.RadioButton()
        Me.rdoWholeDataFrame = New System.Windows.Forms.RadioButton()
        Me.ucrChkIncludeVariable = New instat.ucrCheck()
        Me.ucrInputVariableLabel = New instat.ucrInputTextBox()
        Me.ucrReceiverName = New instat.ucrReceiverSingle()
        Me.ucrInputNewName = New instat.ucrInputTextBox()
        Me.ucrSelectVariables = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrReceiverColumns = New instat.ucrReceiverMultiple()
        Me.ucrPnlSelectData = New instat.UcrPanel()
        Me.rdoLabels = New System.Windows.Forms.RadioButton()
        Me.cmdAddkeyboard = New System.Windows.Forms.Button()
        Me.ucrChkIncludeRegularExpressions = New instat.ucrCheck()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(251, 114)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 23)
        Me.lblName.TabIndex = 9
        Me.lblName.Tag = "New_Name"
        Me.lblName.Text = "New Name:"
        '
        'lblCurrentName
        '
        Me.lblCurrentName.Location = New System.Drawing.Point(251, 68)
        Me.lblCurrentName.Name = "lblCurrentName"
        Me.lblCurrentName.Size = New System.Drawing.Size(100, 15)
        Me.lblCurrentName.TabIndex = 5
        Me.lblCurrentName.Text = "Current Name:"
        '
        'lblVariableLabel
        '
        Me.lblVariableLabel.AutoSize = True
        Me.lblVariableLabel.Location = New System.Drawing.Point(251, 162)
        Me.lblVariableLabel.Name = "lblVariableLabel"
        Me.lblVariableLabel.Size = New System.Drawing.Size(121, 13)
        Me.lblVariableLabel.TabIndex = 10
        Me.lblVariableLabel.Text = "Column (Variable Label):"
        '
        'rdoMultiple
        '
        Me.rdoMultiple.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMultiple.BackColor = System.Drawing.SystemColors.Control
        Me.rdoMultiple.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.FlatAppearance.BorderSize = 2
        Me.rdoMultiple.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMultiple.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMultiple.Location = New System.Drawing.Point(178, 10)
        Me.rdoMultiple.Name = "rdoMultiple"
        Me.rdoMultiple.Size = New System.Drawing.Size(110, 28)
        Me.rdoMultiple.TabIndex = 2
        Me.rdoMultiple.TabStop = True
        Me.rdoMultiple.Tag = ""
        Me.rdoMultiple.Text = "Multiple"
        Me.rdoMultiple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMultiple.UseVisualStyleBackColor = False
        '
        'rdoSingle
        '
        Me.rdoSingle.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSingle.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSingle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingle.FlatAppearance.BorderSize = 2
        Me.rdoSingle.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSingle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSingle.Location = New System.Drawing.Point(70, 10)
        Me.rdoSingle.Name = "rdoSingle"
        Me.rdoSingle.Size = New System.Drawing.Size(110, 28)
        Me.rdoSingle.TabIndex = 1
        Me.rdoSingle.TabStop = True
        Me.rdoSingle.Tag = ""
        Me.rdoSingle.Text = "Single"
        Me.rdoSingle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSingle.UseVisualStyleBackColor = False
        '
        'lblColumns
        '
        Me.lblColumns.Location = New System.Drawing.Point(251, 106)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(55, 15)
        Me.lblColumns.TabIndex = 4
        Me.lblColumns.Text = "Columns:"
        '
        'rdoToLower
        '
        Me.rdoToLower.AutoSize = True
        Me.rdoToLower.Location = New System.Drawing.Point(7, 41)
        Me.rdoToLower.Name = "rdoToLower"
        Me.rdoToLower.Size = New System.Drawing.Size(70, 17)
        Me.rdoToLower.TabIndex = 12
        Me.rdoToLower.TabStop = True
        Me.rdoToLower.Text = "To Lower"
        Me.rdoToLower.UseVisualStyleBackColor = True
        '
        'rdoMakeCleanNames
        '
        Me.rdoMakeCleanNames.AutoSize = True
        Me.rdoMakeCleanNames.Location = New System.Drawing.Point(7, 17)
        Me.rdoMakeCleanNames.Name = "rdoMakeCleanNames"
        Me.rdoMakeCleanNames.Size = New System.Drawing.Size(88, 17)
        Me.rdoMakeCleanNames.TabIndex = 19
        Me.rdoMakeCleanNames.TabStop = True
        Me.rdoMakeCleanNames.Text = "Clean Names"
        Me.rdoMakeCleanNames.UseVisualStyleBackColor = True
        '
        'lblCase
        '
        Me.lblCase.Location = New System.Drawing.Point(109, 18)
        Me.lblCase.Name = "lblCase"
        Me.lblCase.Size = New System.Drawing.Size(37, 16)
        Me.lblCase.TabIndex = 21
        Me.lblCase.Text = "Case:"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.rdoReplace)
        Me.grpOptions.Controls.Add(Me.lblBy)
        Me.grpOptions.Controls.Add(Me.lblReplace)
        Me.grpOptions.Controls.Add(Me.ucrInputBy)
        Me.grpOptions.Controls.Add(Me.ucrInputEdit)
        Me.grpOptions.Controls.Add(Me.ucrInputReplace)
        Me.grpOptions.Controls.Add(Me.ucrNudAbbreviate)
        Me.grpOptions.Controls.Add(Me.rdoAbbreviate)
        Me.grpOptions.Controls.Add(Me.ucrInputCase)
        Me.grpOptions.Controls.Add(Me.lblCase)
        Me.grpOptions.Controls.Add(Me.rdoMakeCleanNames)
        Me.grpOptions.Controls.Add(Me.rdoToLower)
        Me.grpOptions.Controls.Add(Me.ucrPnlCase)
        Me.grpOptions.Location = New System.Drawing.Point(251, 228)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(269, 184)
        Me.grpOptions.TabIndex = 11
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Rename Options"
        '
        'rdoReplace
        '
        Me.rdoReplace.AutoSize = True
        Me.rdoReplace.Location = New System.Drawing.Point(7, 91)
        Me.rdoReplace.Name = "rdoReplace"
        Me.rdoReplace.Size = New System.Drawing.Size(46, 17)
        Me.rdoReplace.TabIndex = 24
        Me.rdoReplace.TabStop = True
        Me.rdoReplace.Text = "Edit "
        Me.rdoReplace.UseVisualStyleBackColor = True
        '
        'lblBy
        '
        Me.lblBy.AutoSize = True
        Me.lblBy.Location = New System.Drawing.Point(4, 160)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(22, 13)
        Me.lblBy.TabIndex = 29
        Me.lblBy.Text = "By:"
        '
        'lblReplace
        '
        Me.lblReplace.AutoSize = True
        Me.lblReplace.Location = New System.Drawing.Point(4, 129)
        Me.lblReplace.Name = "lblReplace"
        Me.lblReplace.Size = New System.Drawing.Size(50, 13)
        Me.lblReplace.TabIndex = 28
        Me.lblReplace.Text = "Replace:"
        '
        'ucrInputBy
        '
        Me.ucrInputBy.AddQuotesIfUnrecognised = True
        Me.ucrInputBy.AutoSize = True
        Me.ucrInputBy.IsMultiline = False
        Me.ucrInputBy.IsReadOnly = False
        Me.ucrInputBy.Location = New System.Drawing.Point(96, 152)
        Me.ucrInputBy.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputBy.Name = "ucrInputBy"
        Me.ucrInputBy.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputBy.TabIndex = 27
        '
        'ucrInputEdit
        '
        Me.ucrInputEdit.AddQuotesIfUnrecognised = True
        Me.ucrInputEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputEdit.GetSetSelectedIndex = -1
        Me.ucrInputEdit.IsReadOnly = False
        Me.ucrInputEdit.Location = New System.Drawing.Point(96, 91)
        Me.ucrInputEdit.Name = "ucrInputEdit"
        Me.ucrInputEdit.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputEdit.TabIndex = 25
        '
        'ucrInputReplace
        '
        Me.ucrInputReplace.AddQuotesIfUnrecognised = True
        Me.ucrInputReplace.AutoSize = True
        Me.ucrInputReplace.IsMultiline = False
        Me.ucrInputReplace.IsReadOnly = False
        Me.ucrInputReplace.Location = New System.Drawing.Point(96, 123)
        Me.ucrInputReplace.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputReplace.Name = "ucrInputReplace"
        Me.ucrInputReplace.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputReplace.TabIndex = 26
        '
        'ucrNudAbbreviate
        '
        Me.ucrNudAbbreviate.AutoSize = True
        Me.ucrNudAbbreviate.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAbbreviate.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAbbreviate.Location = New System.Drawing.Point(112, 62)
        Me.ucrNudAbbreviate.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAbbreviate.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAbbreviate.Name = "ucrNudAbbreviate"
        Me.ucrNudAbbreviate.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAbbreviate.TabIndex = 23
        Me.ucrNudAbbreviate.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoAbbreviate
        '
        Me.rdoAbbreviate.AutoSize = True
        Me.rdoAbbreviate.Location = New System.Drawing.Point(7, 65)
        Me.rdoAbbreviate.Name = "rdoAbbreviate"
        Me.rdoAbbreviate.Size = New System.Drawing.Size(76, 17)
        Me.rdoAbbreviate.TabIndex = 22
        Me.rdoAbbreviate.TabStop = True
        Me.rdoAbbreviate.Text = "Abbreviate"
        Me.rdoAbbreviate.UseVisualStyleBackColor = True
        '
        'ucrInputCase
        '
        Me.ucrInputCase.AddQuotesIfUnrecognised = True
        Me.ucrInputCase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCase.GetSetSelectedIndex = -1
        Me.ucrInputCase.IsReadOnly = False
        Me.ucrInputCase.Location = New System.Drawing.Point(148, 15)
        Me.ucrInputCase.Name = "ucrInputCase"
        Me.ucrInputCase.Size = New System.Drawing.Size(106, 21)
        Me.ucrInputCase.TabIndex = 20
        '
        'ucrPnlCase
        '
        Me.ucrPnlCase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlCase.Location = New System.Drawing.Point(3, 13)
        Me.ucrPnlCase.Name = "ucrPnlCase"
        Me.ucrPnlCase.Size = New System.Drawing.Size(260, 104)
        Me.ucrPnlCase.TabIndex = 17
        '
        'rdoRenameWith
        '
        Me.rdoRenameWith.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRenameWith.BackColor = System.Drawing.SystemColors.Control
        Me.rdoRenameWith.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRenameWith.FlatAppearance.BorderSize = 2
        Me.rdoRenameWith.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRenameWith.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRenameWith.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRenameWith.Location = New System.Drawing.Point(286, 10)
        Me.rdoRenameWith.Name = "rdoRenameWith"
        Me.rdoRenameWith.Size = New System.Drawing.Size(110, 28)
        Me.rdoRenameWith.TabIndex = 13
        Me.rdoRenameWith.TabStop = True
        Me.rdoRenameWith.Tag = ""
        Me.rdoRenameWith.Text = "Rename With"
        Me.rdoRenameWith.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRenameWith.UseVisualStyleBackColor = False
        '
        'grdRenameColumns
        '
        Me.grdRenameColumns.BackColor = System.Drawing.Color.White
        Me.grdRenameColumns.ColumnHeaderContextMenuStrip = Nothing
        Me.grdRenameColumns.LeadHeaderContextMenuStrip = Nothing
        Me.grdRenameColumns.Location = New System.Drawing.Point(185, 66)
        Me.grdRenameColumns.Name = "grdRenameColumns"
        Me.grdRenameColumns.RowHeaderContextMenuStrip = Nothing
        Me.grdRenameColumns.Script = Nothing
        Me.grdRenameColumns.SheetTabContextMenuStrip = Nothing
        Me.grdRenameColumns.SheetTabNewButtonVisible = True
        Me.grdRenameColumns.SheetTabVisible = True
        Me.grdRenameColumns.SheetTabWidth = 154
        Me.grdRenameColumns.ShowScrollEndSpacing = True
        Me.grdRenameColumns.Size = New System.Drawing.Size(349, 210)
        Me.grdRenameColumns.TabIndex = 18
        Me.grdRenameColumns.Text = "Variables"
        '
        'rdoSelectedColumn
        '
        Me.rdoSelectedColumn.Location = New System.Drawing.Point(389, 62)
        Me.rdoSelectedColumn.Name = "rdoSelectedColumn"
        Me.rdoSelectedColumn.Size = New System.Drawing.Size(189, 24)
        Me.rdoSelectedColumn.TabIndex = 21
        Me.rdoSelectedColumn.TabStop = True
        Me.rdoSelectedColumn.Text = "Selected Variables"
        Me.rdoSelectedColumn.UseVisualStyleBackColor = True
        '
        'rdoWholeDataFrame
        '
        Me.rdoWholeDataFrame.AutoSize = True
        Me.rdoWholeDataFrame.Location = New System.Drawing.Point(260, 66)
        Me.rdoWholeDataFrame.Name = "rdoWholeDataFrame"
        Me.rdoWholeDataFrame.Size = New System.Drawing.Size(80, 17)
        Me.rdoWholeDataFrame.TabIndex = 20
        Me.rdoWholeDataFrame.TabStop = True
        Me.rdoWholeDataFrame.Text = "Data Frame"
        Me.rdoWholeDataFrame.UseVisualStyleBackColor = True
        '
        'ucrChkIncludeVariable
        '
        Me.ucrChkIncludeVariable.AutoSize = True
        Me.ucrChkIncludeVariable.Checked = False
        Me.ucrChkIncludeVariable.Location = New System.Drawing.Point(185, 43)
        Me.ucrChkIncludeVariable.Name = "ucrChkIncludeVariable"
        Me.ucrChkIncludeVariable.Size = New System.Drawing.Size(225, 23)
        Me.ucrChkIncludeVariable.TabIndex = 17
        '
        'ucrInputVariableLabel
        '
        Me.ucrInputVariableLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputVariableLabel.AutoSize = True
        Me.ucrInputVariableLabel.IsMultiline = False
        Me.ucrInputVariableLabel.IsReadOnly = False
        Me.ucrInputVariableLabel.Location = New System.Drawing.Point(251, 177)
        Me.ucrInputVariableLabel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputVariableLabel.Name = "ucrInputVariableLabel"
        Me.ucrInputVariableLabel.Size = New System.Drawing.Size(194, 21)
        Me.ucrInputVariableLabel.TabIndex = 7
        '
        'ucrReceiverName
        '
        Me.ucrReceiverName.AutoSize = True
        Me.ucrReceiverName.frmParent = Me
        Me.ucrReceiverName.Location = New System.Drawing.Point(251, 83)
        Me.ucrReceiverName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverName.Name = "ucrReceiverName"
        Me.ucrReceiverName.Selector = Nothing
        Me.ucrReceiverName.Size = New System.Drawing.Size(148, 21)
        Me.ucrReceiverName.strNcFilePath = ""
        Me.ucrReceiverName.TabIndex = 5
        Me.ucrReceiverName.ucrSelector = Nothing
        '
        'ucrInputNewName
        '
        Me.ucrInputNewName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewName.AutoSize = True
        Me.ucrInputNewName.IsMultiline = False
        Me.ucrInputNewName.IsReadOnly = False
        Me.ucrInputNewName.Location = New System.Drawing.Point(251, 130)
        Me.ucrInputNewName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputNewName.Name = "ucrInputNewName"
        Me.ucrInputNewName.Size = New System.Drawing.Size(148, 21)
        Me.ucrInputNewName.TabIndex = 6
        '
        'ucrSelectVariables
        '
        Me.ucrSelectVariables.AutoSize = True
        Me.ucrSelectVariables.bDropUnusedFilterLevels = False
        Me.ucrSelectVariables.bShowHiddenColumns = False
        Me.ucrSelectVariables.bUseCurrentFilter = True
        Me.ucrSelectVariables.Location = New System.Drawing.Point(9, 50)
        Me.ucrSelectVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectVariables.Name = "ucrSelectVariables"
        Me.ucrSelectVariables.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectVariables.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(30, 476)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 12
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(62, 2)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(448, 44)
        Me.ucrPnlOptions.TabIndex = 0
        '
        'ucrReceiverColumns
        '
        Me.ucrReceiverColumns.AutoSize = True
        Me.ucrReceiverColumns.frmParent = Me
        Me.ucrReceiverColumns.Location = New System.Drawing.Point(251, 121)
        Me.ucrReceiverColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumns.Name = "ucrReceiverColumns"
        Me.ucrReceiverColumns.Selector = Nothing
        Me.ucrReceiverColumns.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverColumns.strNcFilePath = ""
        Me.ucrReceiverColumns.TabIndex = 8
        Me.ucrReceiverColumns.ucrSelector = Nothing
        '
        'ucrPnlSelectData
        '
        Me.ucrPnlSelectData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSelectData.Location = New System.Drawing.Point(218, 52)
        Me.ucrPnlSelectData.Name = "ucrPnlSelectData"
        Me.ucrPnlSelectData.Size = New System.Drawing.Size(315, 51)
        Me.ucrPnlSelectData.TabIndex = 19
        '
        'rdoLabels
        '
        Me.rdoLabels.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoLabels.BackColor = System.Drawing.SystemColors.Control
        Me.rdoLabels.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLabels.FlatAppearance.BorderSize = 2
        Me.rdoLabels.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLabels.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoLabels.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLabels.Location = New System.Drawing.Point(394, 10)
        Me.rdoLabels.Name = "rdoLabels"
        Me.rdoLabels.Size = New System.Drawing.Size(110, 28)
        Me.rdoLabels.TabIndex = 22
        Me.rdoLabels.TabStop = True
        Me.rdoLabels.Tag = ""
        Me.rdoLabels.Text = "Labels With"
        Me.rdoLabels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoLabels.UseVisualStyleBackColor = False
        '
        'cmdAddkeyboard
        '
        Me.cmdAddkeyboard.Location = New System.Drawing.Point(315, 315)
        Me.cmdAddkeyboard.Name = "cmdAddkeyboard"
        Me.cmdAddkeyboard.Size = New System.Drawing.Size(100, 23)
        Me.cmdAddkeyboard.TabIndex = 35
        Me.cmdAddkeyboard.Text = "Add Keyboard"
        Me.cmdAddkeyboard.UseVisualStyleBackColor = True
        '
        'ucrChkIncludeRegularExpressions
        '
        Me.ucrChkIncludeRegularExpressions.AutoSize = True
        Me.ucrChkIncludeRegularExpressions.Checked = False
        Me.ucrChkIncludeRegularExpressions.Location = New System.Drawing.Point(71, 316)
        Me.ucrChkIncludeRegularExpressions.Name = "ucrChkIncludeRegularExpressions"
        Me.ucrChkIncludeRegularExpressions.Size = New System.Drawing.Size(239, 23)
        Me.ucrChkIncludeRegularExpressions.TabIndex = 34
        '
        'dlgName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(561, 540)
        Me.Controls.Add(Me.rdoSelectedColumn)
        Me.Controls.Add(Me.rdoWholeDataFrame)
        Me.Controls.Add(Me.rdoLabels)
        Me.Controls.Add(Me.grdRenameColumns)
        Me.Controls.Add(Me.ucrChkIncludeVariable)
        Me.Controls.Add(Me.rdoRenameWith)
        Me.Controls.Add(Me.rdoSingle)
        Me.Controls.Add(Me.rdoMultiple)
        Me.Controls.Add(Me.ucrInputVariableLabel)
        Me.Controls.Add(Me.lblVariableLabel)
        Me.Controls.Add(Me.ucrReceiverName)
        Me.Controls.Add(Me.ucrInputNewName)
        Me.Controls.Add(Me.lblCurrentName)
        Me.Controls.Add(Me.ucrSelectVariables)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.ucrReceiverColumns)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.ucrPnlSelectData)
        Me.Controls.Add(Me.cmdAddkeyboard)
        Me.Controls.Add(Me.ucrChkIncludeRegularExpressions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgName"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Rename_Data_Column"
        Me.Text = "Rename Columns"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrReceiverName As ucrReceiverSingle
    Friend WithEvents lblName As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectVariables As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblCurrentName As Label
    Friend WithEvents ucrInputNewName As ucrInputTextBox
    Friend WithEvents ucrInputVariableLabel As ucrInputTextBox
    Friend WithEvents lblVariableLabel As Label
    Friend WithEvents rdoSingle As RadioButton
    Friend WithEvents rdoMultiple As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents lblColumns As Label
    Friend WithEvents ucrReceiverColumns As ucrReceiverMultiple
    Friend WithEvents rdoToLower As RadioButton
    Friend WithEvents ucrPnlCase As UcrPanel
    Friend WithEvents rdoMakeCleanNames As RadioButton
    Friend WithEvents ucrInputCase As ucrInputComboBox
    Friend WithEvents lblCase As Label
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents rdoRenameWith As RadioButton
    Friend WithEvents ucrChkIncludeVariable As ucrCheck
    Friend WithEvents grdRenameColumns As unvell.ReoGrid.ReoGridControl
    Friend WithEvents rdoAbbreviate As RadioButton
    Friend WithEvents ucrNudAbbreviate As ucrNud
    Friend WithEvents lblBy As Label
    Friend WithEvents lblReplace As Label
    Friend WithEvents ucrInputBy As ucrInputTextBox
    Friend WithEvents ucrInputReplace As ucrInputTextBox
    Friend WithEvents ucrInputEdit As ucrInputComboBox
    Friend WithEvents rdoReplace As RadioButton
    Friend WithEvents rdoSelectedColumn As RadioButton
    Friend WithEvents rdoWholeDataFrame As RadioButton
    Friend WithEvents ucrPnlSelectData As UcrPanel
    Friend WithEvents rdoLabels As RadioButton
    Friend WithEvents cmdAddkeyboard As Button
    Friend WithEvents ucrChkIncludeRegularExpressions As ucrCheck
End Class
