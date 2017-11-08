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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgInsertColumn))
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
        resources.ApplyResources(Me.lblStartPos, "lblStartPos")
        Me.lblStartPos.Name = "lblStartPos"
        '
        'lblNumberOfRowsToInsert
        '
        resources.ApplyResources(Me.lblNumberOfRowsToInsert, "lblNumberOfRowsToInsert")
        Me.lblNumberOfRowsToInsert.Name = "lblNumberOfRowsToInsert"
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
        resources.ApplyResources(Me.grpInsert, "grpInsert")
        Me.grpInsert.Name = "grpInsert"
        Me.grpInsert.TabStop = False
        '
        'lblColumn
        '
        resources.ApplyResources(Me.lblColumn, "lblColumn")
        Me.lblColumn.Name = "lblColumn"
        '
        'ucrInputBeforeAfter
        '
        Me.ucrInputBeforeAfter.AddQuotesIfUnrecognised = True
        Me.ucrInputBeforeAfter.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputBeforeAfter, "ucrInputBeforeAfter")
        Me.ucrInputBeforeAfter.Name = "ucrInputBeforeAfter"
        '
        'ucrReceiverColumnsToInsert
        '
        Me.ucrReceiverColumnsToInsert.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverColumnsToInsert, "ucrReceiverColumnsToInsert")
        Me.ucrReceiverColumnsToInsert.Name = "ucrReceiverColumnsToInsert"
        Me.ucrReceiverColumnsToInsert.Selector = Nothing
        Me.ucrReceiverColumnsToInsert.strNcFilePath = ""
        Me.ucrReceiverColumnsToInsert.ucrSelector = Nothing
        '
        'rdoBeforeAfter
        '
        resources.ApplyResources(Me.rdoBeforeAfter, "rdoBeforeAfter")
        Me.rdoBeforeAfter.Name = "rdoBeforeAfter"
        Me.rdoBeforeAfter.TabStop = True
        Me.rdoBeforeAfter.UseVisualStyleBackColor = True
        '
        'rdoAtStart
        '
        resources.ApplyResources(Me.rdoAtStart, "rdoAtStart")
        Me.rdoAtStart.Name = "rdoAtStart"
        Me.rdoAtStart.TabStop = True
        Me.rdoAtStart.UseVisualStyleBackColor = True
        '
        'rdoAtEnd
        '
        resources.ApplyResources(Me.rdoAtEnd, "rdoAtEnd")
        Me.rdoAtEnd.Name = "rdoAtEnd"
        Me.rdoAtEnd.TabStop = True
        Me.rdoAtEnd.UseVisualStyleBackColor = True
        '
        'ucrPnlInsertColumns
        '
        resources.ApplyResources(Me.ucrPnlInsertColumns, "ucrPnlInsertColumns")
        Me.ucrPnlInsertColumns.Name = "ucrPnlInsertColumns"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.rdoAfter)
        Me.grpOptions.Controls.Add(Me.rdoBefore)
        Me.grpOptions.Controls.Add(Me.ucrPnlBeforeAfter)
        resources.ApplyResources(Me.grpOptions, "grpOptions")
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.TabStop = False
        '
        'rdoAfter
        '
        resources.ApplyResources(Me.rdoAfter, "rdoAfter")
        Me.rdoAfter.Name = "rdoAfter"
        Me.rdoAfter.TabStop = True
        Me.rdoAfter.UseVisualStyleBackColor = True
        '
        'rdoBefore
        '
        resources.ApplyResources(Me.rdoBefore, "rdoBefore")
        Me.rdoBefore.Name = "rdoBefore"
        Me.rdoBefore.TabStop = True
        Me.rdoBefore.UseVisualStyleBackColor = True
        '
        'ucrPnlBeforeAfter
        '
        resources.ApplyResources(Me.ucrPnlBeforeAfter, "ucrPnlBeforeAfter")
        Me.ucrPnlBeforeAfter.Name = "ucrPnlBeforeAfter"
        '
        'lblNumberOfColumnsToInsert
        '
        resources.ApplyResources(Me.lblNumberOfColumnsToInsert, "lblNumberOfColumnsToInsert")
        Me.lblNumberOfColumnsToInsert.Name = "lblNumberOfColumnsToInsert"
        '
        'lblDefaultValue
        '
        resources.ApplyResources(Me.lblDefaultValue, "lblDefaultValue")
        Me.lblDefaultValue.Name = "lblDefaultValue"
        '
        'rdoInsertColumns
        '
        resources.ApplyResources(Me.rdoInsertColumns, "rdoInsertColumns")
        Me.rdoInsertColumns.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInsertColumns.FlatAppearance.BorderSize = 2
        Me.rdoInsertColumns.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInsertColumns.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoInsertColumns.Name = "rdoInsertColumns"
        Me.rdoInsertColumns.UseVisualStyleBackColor = True
        '
        'rdoInsertRows
        '
        resources.ApplyResources(Me.rdoInsertRows, "rdoInsertRows")
        Me.rdoInsertRows.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInsertRows.FlatAppearance.BorderSize = 2
        Me.rdoInsertRows.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInsertRows.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoInsertRows.Name = "rdoInsertRows"
        Me.rdoInsertRows.UseVisualStyleBackColor = True
        '
        'lblInputColumnPrefix
        '
        resources.ApplyResources(Me.lblInputColumnPrefix, "lblInputColumnPrefix")
        Me.lblInputColumnPrefix.Name = "lblInputColumnPrefix"
        '
        'ucrSelectorInsertColumns
        '
        Me.ucrSelectorInsertColumns.bShowHiddenColumns = False
        Me.ucrSelectorInsertColumns.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorInsertColumns, "ucrSelectorInsertColumns")
        Me.ucrSelectorInsertColumns.Name = "ucrSelectorInsertColumns"
        '
        'ucrInputPrefixForNewColumn
        '
        Me.ucrInputPrefixForNewColumn.AddQuotesIfUnrecognised = True
        Me.ucrInputPrefixForNewColumn.IsMultiline = False
        Me.ucrInputPrefixForNewColumn.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPrefixForNewColumn, "ucrInputPrefixForNewColumn")
        Me.ucrInputPrefixForNewColumn.Name = "ucrInputPrefixForNewColumn"
        '
        'ucrNudNumberOfColumns
        '
        Me.ucrNudNumberOfColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudNumberOfColumns, "ucrNudNumberOfColumns")
        Me.ucrNudNumberOfColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Name = "ucrNudNumberOfColumns"
        Me.ucrNudNumberOfColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlColumnsOrRows
        '
        resources.ApplyResources(Me.ucrPnlColumnsOrRows, "ucrPnlColumnsOrRows")
        Me.ucrPnlColumnsOrRows.Name = "ucrPnlColumnsOrRows"
        '
        'ucrInputDefaultValue
        '
        Me.ucrInputDefaultValue.AddQuotesIfUnrecognised = True
        Me.ucrInputDefaultValue.IsMultiline = False
        Me.ucrInputDefaultValue.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputDefaultValue, "ucrInputDefaultValue")
        Me.ucrInputDefaultValue.Name = "ucrInputDefaultValue"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrNudNumberOfRows
        '
        Me.ucrNudNumberOfRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudNumberOfRows, "ucrNudNumberOfRows")
        Me.ucrNudNumberOfRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberOfRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfRows.Name = "ucrNudNumberOfRows"
        Me.ucrNudNumberOfRows.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudStartRow
        '
        Me.ucrNudStartRow.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudStartRow.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudStartRow, "ucrNudStartRow")
        Me.ucrNudStartRow.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudStartRow.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudStartRow.Name = "ucrNudStartRow"
        Me.ucrNudStartRow.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgInsertColumn
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
