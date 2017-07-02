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
Partial Class dlgInsertColumn
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
        Me.lblStartPos = New System.Windows.Forms.Label()
        Me.lblNumberOfRowsToInsert = New System.Windows.Forms.Label()
        Me.grpInsert = New System.Windows.Forms.GroupBox()
        Me.lblColumn = New System.Windows.Forms.Label()
        Me.ucrInputBeforeAfter = New instat.ucrInputComboBox()
        Me.ucrReceiverColumnsToInsert = New instat.ucrReceiverSingle()
        Me.rdoBeforeAfter = New System.Windows.Forms.RadioButton()
        Me.rdoAtStart = New System.Windows.Forms.RadioButton()
        Me.rdoAtEnd = New System.Windows.Forms.RadioButton()
        Me.ucrPnlInsertColumns = New instat.UcrPanel()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.rdoAfter = New System.Windows.Forms.RadioButton()
        Me.rdoBefore = New System.Windows.Forms.RadioButton()
        Me.ucrPnlBeforeAfter = New instat.UcrPanel()
        Me.lblNumberOfColumnsToInsert = New System.Windows.Forms.Label()
        Me.lblDefaultValue = New System.Windows.Forms.Label()
        Me.rdoInsertColumns = New System.Windows.Forms.RadioButton()
        Me.rdoInsertRows = New System.Windows.Forms.RadioButton()
        Me.lblInputColumnPrefix = New System.Windows.Forms.Label()
        Me.ucrSelectorInsertColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputPrefixForNewColumn = New instat.ucrInputTextBox()
        Me.ucrNudNumberOfColumns = New instat.ucrNud()
        Me.ucrPnlColumnsOrRows = New instat.UcrPanel()
        Me.ucrInputDefaultValue = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrNudNumberOfRows = New instat.ucrNud()
        Me.ucrNudStartRow = New instat.ucrNud()
        Me.grpInsert.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStartPos
        '
        Me.lblStartPos.AutoSize = True
        Me.lblStartPos.Location = New System.Drawing.Point(11, 105)
        Me.lblStartPos.Name = "lblStartPos"
        Me.lblStartPos.Size = New System.Drawing.Size(88, 13)
        Me.lblStartPos.TabIndex = 8
        Me.lblStartPos.Text = "Insert at Position:"
        '
        'lblNumberOfRowsToInsert
        '
        Me.lblNumberOfRowsToInsert.AutoSize = True
        Me.lblNumberOfRowsToInsert.Location = New System.Drawing.Point(11, 135)
        Me.lblNumberOfRowsToInsert.Name = "lblNumberOfRowsToInsert"
        Me.lblNumberOfRowsToInsert.Size = New System.Drawing.Size(130, 13)
        Me.lblNumberOfRowsToInsert.TabIndex = 10
        Me.lblNumberOfRowsToInsert.Text = "Number of Rows to Insert:"
        '
        'grpInsert
        '
        Me.grpInsert.Controls.Add(Me.lblColumn)
        Me.grpInsert.Controls.Add(Me.ucrInputBeforeAfter)
        Me.grpInsert.Controls.Add(Me.ucrReceiverColumnsToInsert)
        Me.grpInsert.Controls.Add(Me.rdoBeforeAfter)
        Me.grpInsert.Controls.Add(Me.rdoAtStart)
        Me.grpInsert.Controls.Add(Me.rdoAtEnd)
        Me.grpInsert.Controls.Add(Me.ucrPnlInsertColumns)
        Me.grpInsert.Location = New System.Drawing.Point(235, 85)
        Me.grpInsert.Name = "grpInsert"
        Me.grpInsert.Size = New System.Drawing.Size(286, 122)
        Me.grpInsert.TabIndex = 6
        Me.grpInsert.TabStop = False
        Me.grpInsert.Text = "Insert"
        '
        'lblColumn
        '
        Me.lblColumn.AutoSize = True
        Me.lblColumn.Location = New System.Drawing.Point(152, 73)
        Me.lblColumn.Name = "lblColumn"
        Me.lblColumn.Size = New System.Drawing.Size(45, 13)
        Me.lblColumn.TabIndex = 2
        Me.lblColumn.Text = "Column:"
        '
        'ucrInputBeforeAfter
        '
        Me.ucrInputBeforeAfter.AddQuotesIfUnrecognised = True
        Me.ucrInputBeforeAfter.IsReadOnly = False
        Me.ucrInputBeforeAfter.Location = New System.Drawing.Point(51, 87)
        Me.ucrInputBeforeAfter.Name = "ucrInputBeforeAfter"
        Me.ucrInputBeforeAfter.Size = New System.Drawing.Size(93, 21)
        Me.ucrInputBeforeAfter.TabIndex = 1
        '
        'ucrReceiverColumnsToInsert
        '
        Me.ucrReceiverColumnsToInsert.frmParent = Me
        Me.ucrReceiverColumnsToInsert.Location = New System.Drawing.Point(151, 88)
        Me.ucrReceiverColumnsToInsert.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnsToInsert.Name = "ucrReceiverColumnsToInsert"
        Me.ucrReceiverColumnsToInsert.Selector = Nothing
        Me.ucrReceiverColumnsToInsert.Size = New System.Drawing.Size(116, 20)
        Me.ucrReceiverColumnsToInsert.strNcFilePath = ""
        Me.ucrReceiverColumnsToInsert.TabIndex = 3
        Me.ucrReceiverColumnsToInsert.ucrSelector = Nothing
        '
        'rdoBeforeAfter
        '
        Me.rdoBeforeAfter.AutoSize = True
        Me.rdoBeforeAfter.Location = New System.Drawing.Point(10, 64)
        Me.rdoBeforeAfter.Name = "rdoBeforeAfter"
        Me.rdoBeforeAfter.Size = New System.Drawing.Size(131, 17)
        Me.rdoBeforeAfter.TabIndex = 0
        Me.rdoBeforeAfter.TabStop = True
        Me.rdoBeforeAfter.Text = "Before or After Column"
        Me.rdoBeforeAfter.UseVisualStyleBackColor = True
        '
        'rdoAtStart
        '
        Me.rdoAtStart.AutoSize = True
        Me.rdoAtStart.Location = New System.Drawing.Point(10, 18)
        Me.rdoAtStart.Name = "rdoAtStart"
        Me.rdoAtStart.Size = New System.Drawing.Size(60, 17)
        Me.rdoAtStart.TabIndex = 1
        Me.rdoAtStart.TabStop = True
        Me.rdoAtStart.Text = "At Start"
        Me.rdoAtStart.UseVisualStyleBackColor = True
        '
        'rdoAtEnd
        '
        Me.rdoAtEnd.AutoSize = True
        Me.rdoAtEnd.Location = New System.Drawing.Point(10, 41)
        Me.rdoAtEnd.Name = "rdoAtEnd"
        Me.rdoAtEnd.Size = New System.Drawing.Size(57, 17)
        Me.rdoAtEnd.TabIndex = 2
        Me.rdoAtEnd.TabStop = True
        Me.rdoAtEnd.Text = "At End"
        Me.rdoAtEnd.UseVisualStyleBackColor = True
        '
        'ucrPnlInsertColumns
        '
        Me.ucrPnlInsertColumns.Location = New System.Drawing.Point(3, 17)
        Me.ucrPnlInsertColumns.Name = "ucrPnlInsertColumns"
        Me.ucrPnlInsertColumns.Size = New System.Drawing.Size(277, 101)
        Me.ucrPnlInsertColumns.TabIndex = 5
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.rdoAfter)
        Me.grpOptions.Controls.Add(Me.rdoBefore)
        Me.grpOptions.Controls.Add(Me.ucrPnlBeforeAfter)
        Me.grpOptions.Location = New System.Drawing.Point(235, 85)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(106, 71)
        Me.grpOptions.TabIndex = 7
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'rdoAfter
        '
        Me.rdoAfter.AutoSize = True
        Me.rdoAfter.Location = New System.Drawing.Point(10, 41)
        Me.rdoAfter.Name = "rdoAfter"
        Me.rdoAfter.Size = New System.Drawing.Size(47, 17)
        Me.rdoAfter.TabIndex = 1
        Me.rdoAfter.TabStop = True
        Me.rdoAfter.Text = "After"
        Me.rdoAfter.UseVisualStyleBackColor = True
        '
        'rdoBefore
        '
        Me.rdoBefore.AutoSize = True
        Me.rdoBefore.Location = New System.Drawing.Point(10, 18)
        Me.rdoBefore.Name = "rdoBefore"
        Me.rdoBefore.Size = New System.Drawing.Size(56, 17)
        Me.rdoBefore.TabIndex = 0
        Me.rdoBefore.TabStop = True
        Me.rdoBefore.Text = "Before"
        Me.rdoBefore.UseVisualStyleBackColor = True
        '
        'ucrPnlBeforeAfter
        '
        Me.ucrPnlBeforeAfter.Location = New System.Drawing.Point(3, 16)
        Me.ucrPnlBeforeAfter.Name = "ucrPnlBeforeAfter"
        Me.ucrPnlBeforeAfter.Size = New System.Drawing.Size(86, 49)
        Me.ucrPnlBeforeAfter.TabIndex = 0
        '
        'lblNumberOfColumnsToInsert
        '
        Me.lblNumberOfColumnsToInsert.AutoSize = True
        Me.lblNumberOfColumnsToInsert.Location = New System.Drawing.Point(11, 236)
        Me.lblNumberOfColumnsToInsert.Name = "lblNumberOfColumnsToInsert"
        Me.lblNumberOfColumnsToInsert.Size = New System.Drawing.Size(143, 13)
        Me.lblNumberOfColumnsToInsert.TabIndex = 12
        Me.lblNumberOfColumnsToInsert.Text = "Number of Columns to Insert:"
        '
        'lblDefaultValue
        '
        Me.lblDefaultValue.AutoSize = True
        Me.lblDefaultValue.Location = New System.Drawing.Point(11, 263)
        Me.lblDefaultValue.Name = "lblDefaultValue"
        Me.lblDefaultValue.Size = New System.Drawing.Size(74, 13)
        Me.lblDefaultValue.TabIndex = 14
        Me.lblDefaultValue.Text = "Default Value:"
        '
        'rdoInsertColumns
        '
        Me.rdoInsertColumns.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoInsertColumns.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInsertColumns.FlatAppearance.BorderSize = 2
        Me.rdoInsertColumns.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInsertColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoInsertColumns.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoInsertColumns.Location = New System.Drawing.Point(169, 12)
        Me.rdoInsertColumns.Name = "rdoInsertColumns"
        Me.rdoInsertColumns.Size = New System.Drawing.Size(100, 28)
        Me.rdoInsertColumns.TabIndex = 1
        Me.rdoInsertColumns.Text = "Insert Columns"
        Me.rdoInsertColumns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoInsertColumns.UseVisualStyleBackColor = True
        '
        'rdoInsertRows
        '
        Me.rdoInsertRows.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoInsertRows.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInsertRows.FlatAppearance.BorderSize = 2
        Me.rdoInsertRows.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInsertRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoInsertRows.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoInsertRows.Location = New System.Drawing.Point(267, 12)
        Me.rdoInsertRows.Name = "rdoInsertRows"
        Me.rdoInsertRows.Size = New System.Drawing.Size(100, 28)
        Me.rdoInsertRows.TabIndex = 2
        Me.rdoInsertRows.Text = "Insert Rows"
        Me.rdoInsertRows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoInsertRows.UseVisualStyleBackColor = True
        '
        'lblInputColumnPrefix
        '
        Me.lblInputColumnPrefix.AutoSize = True
        Me.lblInputColumnPrefix.Location = New System.Drawing.Point(11, 289)
        Me.lblInputColumnPrefix.Name = "lblInputColumnPrefix"
        Me.lblInputColumnPrefix.Size = New System.Drawing.Size(144, 13)
        Me.lblInputColumnPrefix.TabIndex = 16
        Me.lblInputColumnPrefix.Text = "Prefix For Inserted Column(s):"
        '
        'ucrSelectorInsertColumns
        '
        Me.ucrSelectorInsertColumns.bShowHiddenColumns = False
        Me.ucrSelectorInsertColumns.bUseCurrentFilter = True
        Me.ucrSelectorInsertColumns.Location = New System.Drawing.Point(11, 50)
        Me.ucrSelectorInsertColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorInsertColumns.Name = "ucrSelectorInsertColumns"
        Me.ucrSelectorInsertColumns.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorInsertColumns.TabIndex = 3
        '
        'ucrInputPrefixForNewColumn
        '
        Me.ucrInputPrefixForNewColumn.AddQuotesIfUnrecognised = True
        Me.ucrInputPrefixForNewColumn.IsMultiline = False
        Me.ucrInputPrefixForNewColumn.IsReadOnly = False
        Me.ucrInputPrefixForNewColumn.Location = New System.Drawing.Point(159, 286)
        Me.ucrInputPrefixForNewColumn.Name = "ucrInputPrefixForNewColumn"
        Me.ucrInputPrefixForNewColumn.Size = New System.Drawing.Size(163, 21)
        Me.ucrInputPrefixForNewColumn.TabIndex = 0
        '
        'ucrNudNumberOfColumns
        '
        Me.ucrNudNumberOfColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Location = New System.Drawing.Point(159, 233)
        Me.ucrNudNumberOfColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Name = "ucrNudNumberOfColumns"
        Me.ucrNudNumberOfColumns.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNumberOfColumns.TabIndex = 13
        Me.ucrNudNumberOfColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlColumnsOrRows
        '
        Me.ucrPnlColumnsOrRows.Location = New System.Drawing.Point(161, 12)
        Me.ucrPnlColumnsOrRows.Name = "ucrPnlColumnsOrRows"
        Me.ucrPnlColumnsOrRows.Size = New System.Drawing.Size(214, 37)
        Me.ucrPnlColumnsOrRows.TabIndex = 0
        '
        'ucrInputDefaultValue
        '
        Me.ucrInputDefaultValue.AddQuotesIfUnrecognised = True
        Me.ucrInputDefaultValue.IsMultiline = False
        Me.ucrInputDefaultValue.IsReadOnly = False
        Me.ucrInputDefaultValue.Location = New System.Drawing.Point(159, 259)
        Me.ucrInputDefaultValue.Name = "ucrInputDefaultValue"
        Me.ucrInputDefaultValue.Size = New System.Drawing.Size(49, 21)
        Me.ucrInputDefaultValue.TabIndex = 15
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 313)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 1
        '
        'ucrNudNumberOfRows
        '
        Me.ucrNudNumberOfRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberOfRows.Location = New System.Drawing.Point(143, 132)
        Me.ucrNudNumberOfRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberOfRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfRows.Name = "ucrNudNumberOfRows"
        Me.ucrNudNumberOfRows.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNumberOfRows.TabIndex = 11
        Me.ucrNudNumberOfRows.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudStartRow
        '
        Me.ucrNudStartRow.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudStartRow.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudStartRow.Location = New System.Drawing.Point(105, 103)
        Me.ucrNudStartRow.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudStartRow.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudStartRow.Name = "ucrNudStartRow"
        Me.ucrNudStartRow.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudStartRow.TabIndex = 9
        Me.ucrNudStartRow.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgInsertColumn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 369)
        Me.Controls.Add(Me.lblInputColumnPrefix)
        Me.Controls.Add(Me.ucrInputPrefixForNewColumn)
        Me.Controls.Add(Me.ucrNudNumberOfColumns)
        Me.Controls.Add(Me.rdoInsertRows)
        Me.Controls.Add(Me.rdoInsertColumns)
        Me.Controls.Add(Me.ucrPnlColumnsOrRows)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.ucrInputDefaultValue)
        Me.Controls.Add(Me.lblDefaultValue)
        Me.Controls.Add(Me.lblNumberOfColumnsToInsert)
        Me.Controls.Add(Me.lblStartPos)
        Me.Controls.Add(Me.lblNumberOfRowsToInsert)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrNudNumberOfRows)
        Me.Controls.Add(Me.ucrNudStartRow)
        Me.Controls.Add(Me.grpInsert)
        Me.Controls.Add(Me.ucrSelectorInsertColumns)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgInsertColumn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert Columns/Rows"
        Me.grpInsert.ResumeLayout(False)
        Me.grpInsert.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStartPos As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblNumberOfRowsToInsert As Label
    Friend WithEvents grpInsert As GroupBox
    Friend WithEvents ucrInputBeforeAfter As ucrInputComboBox
    Friend WithEvents rdoAtStart As RadioButton
    Friend WithEvents rdoAtEnd As RadioButton
    Friend WithEvents ucrReceiverColumnsToInsert As ucrReceiverSingle
    Friend WithEvents lblNumberOfColumnsToInsert As Label
    Friend WithEvents lblDefaultValue As Label
    Friend WithEvents ucrInputDefaultValue As ucrInputTextBox
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents rdoAfter As RadioButton
    Friend WithEvents rdoBefore As RadioButton
    Friend WithEvents rdoInsertColumns As RadioButton
    Friend WithEvents ucrPnlColumnsOrRows As UcrPanel
    Friend WithEvents rdoInsertRows As RadioButton
    Friend WithEvents ucrNudNumberOfColumns As ucrNud
    Friend WithEvents ucrNudStartRow As ucrNud
    Friend WithEvents ucrNudNumberOfRows As ucrNud
    Friend WithEvents ucrPnlBeforeAfter As UcrPanel
    Friend WithEvents ucrPnlInsertColumns As UcrPanel
    Friend WithEvents rdoBeforeAfter As RadioButton
    Friend WithEvents lblInputColumnPrefix As Label
    Friend WithEvents ucrInputPrefixForNewColumn As ucrInputTextBox
    Friend WithEvents lblColumn As Label
    Friend WithEvents ucrSelectorInsertColumns As ucrSelectorByDataFrameAddRemove
End Class
