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
        Me.lblMax = New System.Windows.Forms.Label()
        Me.rdoAbbreviate = New System.Windows.Forms.RadioButton()
        Me.rdoPattern = New System.Windows.Forms.RadioButton()
        Me.rdoRenameWith = New System.Windows.Forms.RadioButton()
        Me.grdRenameColumns = New unvell.ReoGrid.ReoGridControl()
        Me.grpPatternOption = New System.Windows.Forms.GroupBox()
        Me.cmdAddkeyboard = New System.Windows.Forms.Button()
        Me.lblReplaceBy = New System.Windows.Forms.Label()
        Me.lblPattern = New System.Windows.Forms.Label()
        Me.ucrChkIncludeRegularExpressions = New instat.ucrCheck()
        Me.ucrInputReplaceBy = New instat.ucrInputTextBox()
        Me.ucrInputPattern = New instat.ucrInputTextBox()
        Me.ucrChkIgnoreCase = New instat.ucrCheck()
        Me.ucrChkIncludeVariable = New instat.ucrCheck()
        Me.ucrReceiverColumns = New instat.ucrReceiverMultiple()
        Me.ucrInputVariableLabel = New instat.ucrInputTextBox()
        Me.ucrReceiverName = New instat.ucrReceiverSingle()
        Me.ucrInputNewName = New instat.ucrInputTextBox()
        Me.ucrSelectVariables = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrChkWithDot = New instat.ucrCheck()
        Me.ucrNudMax = New instat.ucrNud()
        Me.ucrInputCase = New instat.ucrInputComboBox()
        Me.ucrPnlCase = New instat.UcrPanel()
        Me.lblCharacters = New System.Windows.Forms.Label()
        Me.grpOptions.SuspendLayout()
        Me.grpPatternOption.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(317, 112)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 23)
        Me.lblName.TabIndex = 9
        Me.lblName.Tag = "New_Name"
        Me.lblName.Text = "New Name:"
        '
        'lblCurrentName
        '
        Me.lblCurrentName.Location = New System.Drawing.Point(317, 66)
        Me.lblCurrentName.Name = "lblCurrentName"
        Me.lblCurrentName.Size = New System.Drawing.Size(100, 15)
        Me.lblCurrentName.TabIndex = 5
        Me.lblCurrentName.Text = "Current Name:"
        '
        'lblVariableLabel
        '
        Me.lblVariableLabel.AutoSize = True
        Me.lblVariableLabel.Location = New System.Drawing.Point(317, 160)
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
        Me.rdoMultiple.Location = New System.Drawing.Point(255, 12)
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
        Me.rdoSingle.Location = New System.Drawing.Point(145, 12)
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
        Me.lblColumns.Location = New System.Drawing.Point(317, 66)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(55, 15)
        Me.lblColumns.TabIndex = 4
        Me.lblColumns.Text = "Columns:"
        '
        'rdoToLower
        '
        Me.rdoToLower.AutoSize = True
        Me.rdoToLower.Location = New System.Drawing.Point(7, 40)
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
        Me.grpOptions.Controls.Add(Me.lblCharacters)
        Me.grpOptions.Controls.Add(Me.ucrChkWithDot)
        Me.grpOptions.Controls.Add(Me.ucrNudMax)
        Me.grpOptions.Controls.Add(Me.lblMax)
        Me.grpOptions.Controls.Add(Me.rdoAbbreviate)
        Me.grpOptions.Controls.Add(Me.rdoPattern)
        Me.grpOptions.Controls.Add(Me.ucrInputCase)
        Me.grpOptions.Controls.Add(Me.lblCase)
        Me.grpOptions.Controls.Add(Me.rdoMakeCleanNames)
        Me.grpOptions.Controls.Add(Me.rdoToLower)
        Me.grpOptions.Controls.Add(Me.ucrPnlCase)
        Me.grpOptions.Location = New System.Drawing.Point(9, 236)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(315, 114)
        Me.grpOptions.TabIndex = 11
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Rename Options"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(87, 65)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(30, 13)
        Me.lblMax.TabIndex = 24
        Me.lblMax.Text = "Max:"
        '
        'rdoAbbreviate
        '
        Me.rdoAbbreviate.AutoSize = True
        Me.rdoAbbreviate.Location = New System.Drawing.Point(7, 63)
        Me.rdoAbbreviate.Name = "rdoAbbreviate"
        Me.rdoAbbreviate.Size = New System.Drawing.Size(76, 17)
        Me.rdoAbbreviate.TabIndex = 23
        Me.rdoAbbreviate.TabStop = True
        Me.rdoAbbreviate.Text = "Abbreviate"
        Me.rdoAbbreviate.UseVisualStyleBackColor = True
        '
        'rdoPattern
        '
        Me.rdoPattern.AutoSize = True
        Me.rdoPattern.Location = New System.Drawing.Point(7, 86)
        Me.rdoPattern.Name = "rdoPattern"
        Me.rdoPattern.Size = New System.Drawing.Size(59, 17)
        Me.rdoPattern.TabIndex = 22
        Me.rdoPattern.TabStop = True
        Me.rdoPattern.Text = "Pattern"
        Me.rdoPattern.UseVisualStyleBackColor = True
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
        Me.rdoRenameWith.Location = New System.Drawing.Point(365, 12)
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
        Me.grdRenameColumns.Location = New System.Drawing.Point(251, 69)
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
        'grpPatternOption
        '
        Me.grpPatternOption.Controls.Add(Me.cmdAddkeyboard)
        Me.grpPatternOption.Controls.Add(Me.ucrChkIncludeRegularExpressions)
        Me.grpPatternOption.Controls.Add(Me.ucrInputReplaceBy)
        Me.grpPatternOption.Controls.Add(Me.ucrInputPattern)
        Me.grpPatternOption.Controls.Add(Me.ucrChkIgnoreCase)
        Me.grpPatternOption.Controls.Add(Me.lblReplaceBy)
        Me.grpPatternOption.Controls.Add(Me.lblPattern)
        Me.grpPatternOption.Location = New System.Drawing.Point(325, 236)
        Me.grpPatternOption.Name = "grpPatternOption"
        Me.grpPatternOption.Size = New System.Drawing.Size(286, 121)
        Me.grpPatternOption.TabIndex = 19
        Me.grpPatternOption.TabStop = False
        Me.grpPatternOption.Text = "Pattern Options"
        '
        'cmdAddkeyboard
        '
        Me.cmdAddkeyboard.Location = New System.Drawing.Point(182, 89)
        Me.cmdAddkeyboard.Name = "cmdAddkeyboard"
        Me.cmdAddkeyboard.Size = New System.Drawing.Size(100, 23)
        Me.cmdAddkeyboard.TabIndex = 34
        Me.cmdAddkeyboard.Text = "Add Keyboard"
        Me.cmdAddkeyboard.UseVisualStyleBackColor = True
        '
        'lblReplaceBy
        '
        Me.lblReplaceBy.AutoSize = True
        Me.lblReplaceBy.Location = New System.Drawing.Point(7, 46)
        Me.lblReplaceBy.Name = "lblReplaceBy"
        Me.lblReplaceBy.Size = New System.Drawing.Size(62, 13)
        Me.lblReplaceBy.TabIndex = 1
        Me.lblReplaceBy.Text = "Replace By"
        '
        'lblPattern
        '
        Me.lblPattern.AutoSize = True
        Me.lblPattern.Location = New System.Drawing.Point(7, 20)
        Me.lblPattern.Name = "lblPattern"
        Me.lblPattern.Size = New System.Drawing.Size(41, 13)
        Me.lblPattern.TabIndex = 0
        Me.lblPattern.Text = "Pattern"
        '
        'ucrChkIncludeRegularExpressions
        '
        Me.ucrChkIncludeRegularExpressions.AutoSize = True
        Me.ucrChkIncludeRegularExpressions.Checked = False
        Me.ucrChkIncludeRegularExpressions.Location = New System.Drawing.Point(10, 92)
        Me.ucrChkIncludeRegularExpressions.Name = "ucrChkIncludeRegularExpressions"
        Me.ucrChkIncludeRegularExpressions.Size = New System.Drawing.Size(169, 23)
        Me.ucrChkIncludeRegularExpressions.TabIndex = 30
        '
        'ucrInputReplaceBy
        '
        Me.ucrInputReplaceBy.AddQuotesIfUnrecognised = True
        Me.ucrInputReplaceBy.AutoSize = True
        Me.ucrInputReplaceBy.IsMultiline = False
        Me.ucrInputReplaceBy.IsReadOnly = False
        Me.ucrInputReplaceBy.Location = New System.Drawing.Point(78, 43)
        Me.ucrInputReplaceBy.Name = "ucrInputReplaceBy"
        Me.ucrInputReplaceBy.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputReplaceBy.TabIndex = 29
        '
        'ucrInputPattern
        '
        Me.ucrInputPattern.AddQuotesIfUnrecognised = True
        Me.ucrInputPattern.AutoSize = True
        Me.ucrInputPattern.IsMultiline = False
        Me.ucrInputPattern.IsReadOnly = False
        Me.ucrInputPattern.Location = New System.Drawing.Point(78, 16)
        Me.ucrInputPattern.Name = "ucrInputPattern"
        Me.ucrInputPattern.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPattern.TabIndex = 28
        '
        'ucrChkIgnoreCase
        '
        Me.ucrChkIgnoreCase.AutoSize = True
        Me.ucrChkIgnoreCase.Checked = False
        Me.ucrChkIgnoreCase.Location = New System.Drawing.Point(10, 69)
        Me.ucrChkIgnoreCase.Name = "ucrChkIgnoreCase"
        Me.ucrChkIgnoreCase.Size = New System.Drawing.Size(169, 23)
        Me.ucrChkIgnoreCase.TabIndex = 27
        '
        'ucrChkIncludeVariable
        '
        Me.ucrChkIncludeVariable.AutoSize = True
        Me.ucrChkIncludeVariable.Checked = False
        Me.ucrChkIncludeVariable.Location = New System.Drawing.Point(251, 46)
        Me.ucrChkIncludeVariable.Name = "ucrChkIncludeVariable"
        Me.ucrChkIncludeVariable.Size = New System.Drawing.Size(225, 23)
        Me.ucrChkIncludeVariable.TabIndex = 17
        '
        'ucrReceiverColumns
        '
        Me.ucrReceiverColumns.AutoSize = True
        Me.ucrReceiverColumns.frmParent = Me
        Me.ucrReceiverColumns.Location = New System.Drawing.Point(317, 81)
        Me.ucrReceiverColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumns.Name = "ucrReceiverColumns"
        Me.ucrReceiverColumns.Selector = Nothing
        Me.ucrReceiverColumns.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverColumns.strNcFilePath = ""
        Me.ucrReceiverColumns.TabIndex = 8
        Me.ucrReceiverColumns.ucrSelector = Nothing
        '
        'ucrInputVariableLabel
        '
        Me.ucrInputVariableLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputVariableLabel.AutoSize = True
        Me.ucrInputVariableLabel.IsMultiline = False
        Me.ucrInputVariableLabel.IsReadOnly = False
        Me.ucrInputVariableLabel.Location = New System.Drawing.Point(317, 175)
        Me.ucrInputVariableLabel.Name = "ucrInputVariableLabel"
        Me.ucrInputVariableLabel.Size = New System.Drawing.Size(194, 21)
        Me.ucrInputVariableLabel.TabIndex = 7
        '
        'ucrReceiverName
        '
        Me.ucrReceiverName.AutoSize = True
        Me.ucrReceiverName.frmParent = Me
        Me.ucrReceiverName.Location = New System.Drawing.Point(317, 81)
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
        Me.ucrInputNewName.Location = New System.Drawing.Point(317, 128)
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
        Me.ucrBase.Location = New System.Drawing.Point(9, 364)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 12
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(134, 4)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(355, 44)
        Me.ucrPnlOptions.TabIndex = 0
        '
        'ucrChkWithDot
        '
        Me.ucrChkWithDot.AutoSize = True
        Me.ucrChkWithDot.Checked = False
        Me.ucrChkWithDot.Location = New System.Drawing.Point(231, 63)
        Me.ucrChkWithDot.Name = "ucrChkWithDot"
        Me.ucrChkWithDot.Size = New System.Drawing.Size(75, 23)
        Me.ucrChkWithDot.TabIndex = 26
        '
        'ucrNudMax
        '
        Me.ucrNudMax.AutoSize = True
        Me.ucrNudMax.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMax.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMax.Location = New System.Drawing.Point(120, 62)
        Me.ucrNudMax.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMax.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMax.Name = "ucrNudMax"
        Me.ucrNudMax.Size = New System.Drawing.Size(38, 20)
        Me.ucrNudMax.TabIndex = 25
        Me.ucrNudMax.Value = New Decimal(New Integer() {0, 0, 0, 0})
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
        Me.ucrPnlCase.Location = New System.Drawing.Point(4, 13)
        Me.ucrPnlCase.Name = "ucrPnlCase"
        Me.ucrPnlCase.Size = New System.Drawing.Size(305, 95)
        Me.ucrPnlCase.TabIndex = 17
        '
        'lblCharacters
        '
        Me.lblCharacters.AutoSize = True
        Me.lblCharacters.Location = New System.Drawing.Point(162, 65)
        Me.lblCharacters.Name = "lblCharacters"
        Me.lblCharacters.Size = New System.Drawing.Size(57, 13)
        Me.lblCharacters.TabIndex = 27
        Me.lblCharacters.Text = "characters"
        '
        'dlgName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(616, 420)
        Me.Controls.Add(Me.grpPatternOption)
        Me.Controls.Add(Me.grdRenameColumns)
        Me.Controls.Add(Me.ucrChkIncludeVariable)
        Me.Controls.Add(Me.rdoRenameWith)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.ucrReceiverColumns)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgName"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Rename_Data_Column"
        Me.Text = "Rename Columns"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.grpPatternOption.ResumeLayout(False)
        Me.grpPatternOption.PerformLayout()
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
    Friend WithEvents rdoPattern As RadioButton
    Friend WithEvents lblMax As Label
    Friend WithEvents ucrChkWithDot As ucrCheck
    Friend WithEvents ucrNudMax As ucrNud
    Friend WithEvents grpPatternOption As GroupBox
    Friend WithEvents ucrChkIgnoreCase As ucrCheck
    Friend WithEvents lblReplaceBy As Label
    Friend WithEvents lblPattern As Label
    Friend WithEvents ucrChkIncludeRegularExpressions As ucrCheck
    Friend WithEvents ucrInputReplaceBy As ucrInputTextBox
    Friend WithEvents ucrInputPattern As ucrInputTextBox
    Friend WithEvents cmdAddkeyboard As Button
    Friend WithEvents lblCharacters As Label
End Class
