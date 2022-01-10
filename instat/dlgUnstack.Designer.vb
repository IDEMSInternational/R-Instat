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
Partial Class dlgUnstack
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
        Me.lblFactorToUnstackBy = New System.Windows.Forms.Label()
        Me.lblCarryColumns = New System.Windows.Forms.Label()
        Me.rdoSingle = New System.Windows.Forms.RadioButton()
        Me.rdoMultiple = New System.Windows.Forms.RadioButton()
        Me.rdoRestoreHierarchy = New System.Windows.Forms.RadioButton()
        Me.lblMultipleColumns = New System.Windows.Forms.Label()
        Me.ucrNewDFName = New instat.ucrSave()
        Me.ucrChkDropMissingCombinations = New instat.ucrCheck()
        Me.ucrReceiverCarryColumns = New instat.ucrReceiverMultiple()
        Me.ucrReceiverFactorToUnstackby = New instat.ucrReceiverSingle()
        Me.ucrSelectorForUnstack = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlUnstackCol = New instat.UcrPanel()
        Me.ucrMultipleColumnsReceiver = New instat.ucrReceiverMultiple()
        Me.ucrReceiverColumnToUnstack = New instat.ucrReceiverSingle()
        Me.lblColumnToUnstack = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFactorToUnstackBy
        '
        Me.lblFactorToUnstackBy.AutoSize = True
        Me.lblFactorToUnstackBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactorToUnstackBy.Location = New System.Drawing.Point(272, 63)
        Me.lblFactorToUnstackBy.Name = "lblFactorToUnstackBy"
        Me.lblFactorToUnstackBy.Size = New System.Drawing.Size(109, 13)
        Me.lblFactorToUnstackBy.TabIndex = 5
        Me.lblFactorToUnstackBy.Tag = "Factor_to_Unstack_By"
        Me.lblFactorToUnstackBy.Text = "Factor to Unstack by:"
        '
        'lblCarryColumns
        '
        Me.lblCarryColumns.AutoSize = True
        Me.lblCarryColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCarryColumns.Location = New System.Drawing.Point(269, 154)
        Me.lblCarryColumns.Name = "lblCarryColumns"
        Me.lblCarryColumns.Size = New System.Drawing.Size(77, 13)
        Me.lblCarryColumns.TabIndex = 9
        Me.lblCarryColumns.Tag = "ID_Columns"
        Me.lblCarryColumns.Text = "Carry Columns:"
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
        Me.rdoSingle.Location = New System.Drawing.Point(47, 13)
        Me.rdoSingle.Name = "rdoSingle"
        Me.rdoSingle.Size = New System.Drawing.Size(100, 28)
        Me.rdoSingle.TabIndex = 1
        Me.rdoSingle.TabStop = True
        Me.rdoSingle.Text = "Single"
        Me.rdoSingle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSingle.UseVisualStyleBackColor = False
        '
        'rdoMultiple
        '
        Me.rdoMultiple.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMultiple.BackColor = System.Drawing.SystemColors.Control
        Me.rdoMultiple.Enabled = False
        Me.rdoMultiple.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.FlatAppearance.BorderSize = 2
        Me.rdoMultiple.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMultiple.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMultiple.Location = New System.Drawing.Point(145, 13)
        Me.rdoMultiple.Name = "rdoMultiple"
        Me.rdoMultiple.Size = New System.Drawing.Size(100, 28)
        Me.rdoMultiple.TabIndex = 2
        Me.rdoMultiple.TabStop = True
        Me.rdoMultiple.Text = "Multiple"
        Me.rdoMultiple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMultiple.UseVisualStyleBackColor = False
        '
        'rdoRestoreHierarchy
        '
        Me.rdoRestoreHierarchy.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRestoreHierarchy.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRestoreHierarchy.FlatAppearance.BorderSize = 2
        Me.rdoRestoreHierarchy.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRestoreHierarchy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRestoreHierarchy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRestoreHierarchy.Location = New System.Drawing.Point(243, 13)
        Me.rdoRestoreHierarchy.Name = "rdoRestoreHierarchy"
        Me.rdoRestoreHierarchy.Size = New System.Drawing.Size(126, 28)
        Me.rdoRestoreHierarchy.TabIndex = 3
        Me.rdoRestoreHierarchy.TabStop = True
        Me.rdoRestoreHierarchy.Text = "Restore Hierarchy"
        Me.rdoRestoreHierarchy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRestoreHierarchy.UseVisualStyleBackColor = True
        '
        'lblMultipleColumns
        '
        Me.lblMultipleColumns.AutoSize = True
        Me.lblMultipleColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMultipleColumns.Location = New System.Drawing.Point(272, 156)
        Me.lblMultipleColumns.Name = "lblMultipleColumns"
        Me.lblMultipleColumns.Size = New System.Drawing.Size(105, 13)
        Me.lblMultipleColumns.TabIndex = 10
        Me.lblMultipleColumns.Text = "Columns to Unstack:"
        '
        'ucrNewDFName
        '
        Me.ucrNewDFName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrNewDFName.Location = New System.Drawing.Point(10, 282)
        Me.ucrNewDFName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNewDFName.Name = "ucrNewDFName"
        Me.ucrNewDFName.Size = New System.Drawing.Size(266, 24)
        Me.ucrNewDFName.TabIndex = 14
        '
        'ucrChkDropMissingCombinations
        '
        Me.ucrChkDropMissingCombinations.AutoSize = True
        Me.ucrChkDropMissingCombinations.Checked = False
        Me.ucrChkDropMissingCombinations.Location = New System.Drawing.Point(10, 256)
        Me.ucrChkDropMissingCombinations.Name = "ucrChkDropMissingCombinations"
        Me.ucrChkDropMissingCombinations.Size = New System.Drawing.Size(235, 23)
        Me.ucrChkDropMissingCombinations.TabIndex = 13
        '
        'ucrReceiverCarryColumns
        '
        Me.ucrReceiverCarryColumns.AutoSize = True
        Me.ucrReceiverCarryColumns.frmParent = Me
        Me.ucrReceiverCarryColumns.Location = New System.Drawing.Point(272, 169)
        Me.ucrReceiverCarryColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCarryColumns.Name = "ucrReceiverCarryColumns"
        Me.ucrReceiverCarryColumns.Selector = Nothing
        Me.ucrReceiverCarryColumns.Size = New System.Drawing.Size(120, 104)
        Me.ucrReceiverCarryColumns.strNcFilePath = ""
        Me.ucrReceiverCarryColumns.TabIndex = 12
        Me.ucrReceiverCarryColumns.ucrSelector = Nothing
        '
        'ucrReceiverFactorToUnstackby
        '
        Me.ucrReceiverFactorToUnstackby.AutoSize = True
        Me.ucrReceiverFactorToUnstackby.frmParent = Me
        Me.ucrReceiverFactorToUnstackby.Location = New System.Drawing.Point(272, 78)
        Me.ucrReceiverFactorToUnstackby.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactorToUnstackby.Name = "ucrReceiverFactorToUnstackby"
        Me.ucrReceiverFactorToUnstackby.Selector = Nothing
        Me.ucrReceiverFactorToUnstackby.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFactorToUnstackby.strNcFilePath = ""
        Me.ucrReceiverFactorToUnstackby.TabIndex = 6
        Me.ucrReceiverFactorToUnstackby.ucrSelector = Nothing
        '
        'ucrSelectorForUnstack
        '
        Me.ucrSelectorForUnstack.AutoSize = True
        Me.ucrSelectorForUnstack.bDropUnusedFilterLevels = False
        Me.ucrSelectorForUnstack.bShowHiddenColumns = False
        Me.ucrSelectorForUnstack.bUseCurrentFilter = True
        Me.ucrSelectorForUnstack.Location = New System.Drawing.Point(9, 59)
        Me.ucrSelectorForUnstack.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForUnstack.Name = "ucrSelectorForUnstack"
        Me.ucrSelectorForUnstack.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForUnstack.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(7, 316)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 15
        '
        'ucrPnlUnstackCol
        '
        Me.ucrPnlUnstackCol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlUnstackCol.Location = New System.Drawing.Point(40, 5)
        Me.ucrPnlUnstackCol.Name = "ucrPnlUnstackCol"
        Me.ucrPnlUnstackCol.Size = New System.Drawing.Size(337, 52)
        Me.ucrPnlUnstackCol.TabIndex = 0
        '
        'ucrMultipleColumnsReceiver
        '
        Me.ucrMultipleColumnsReceiver.AutoSize = True
        Me.ucrMultipleColumnsReceiver.frmParent = Me
        Me.ucrMultipleColumnsReceiver.Location = New System.Drawing.Point(271, 169)
        Me.ucrMultipleColumnsReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrMultipleColumnsReceiver.Name = "ucrMultipleColumnsReceiver"
        Me.ucrMultipleColumnsReceiver.Selector = Nothing
        Me.ucrMultipleColumnsReceiver.Size = New System.Drawing.Size(120, 100)
        Me.ucrMultipleColumnsReceiver.strNcFilePath = ""
        Me.ucrMultipleColumnsReceiver.TabIndex = 11
        Me.ucrMultipleColumnsReceiver.ucrSelector = Nothing
        '
        'ucrReceiverColumnToUnstack
        '
        Me.ucrReceiverColumnToUnstack.AutoSize = True
        Me.ucrReceiverColumnToUnstack.frmParent = Me
        Me.ucrReceiverColumnToUnstack.Location = New System.Drawing.Point(272, 125)
        Me.ucrReceiverColumnToUnstack.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnToUnstack.Name = "ucrReceiverColumnToUnstack"
        Me.ucrReceiverColumnToUnstack.Selector = Nothing
        Me.ucrReceiverColumnToUnstack.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverColumnToUnstack.strNcFilePath = ""
        Me.ucrReceiverColumnToUnstack.TabIndex = 8
        Me.ucrReceiverColumnToUnstack.ucrSelector = Nothing
        '
        'lblColumnToUnstack
        '
        Me.lblColumnToUnstack.AutoSize = True
        Me.lblColumnToUnstack.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumnToUnstack.Location = New System.Drawing.Point(272, 110)
        Me.lblColumnToUnstack.Name = "lblColumnToUnstack"
        Me.lblColumnToUnstack.Size = New System.Drawing.Size(100, 13)
        Me.lblColumnToUnstack.TabIndex = 7
        Me.lblColumnToUnstack.Tag = "Column_to_Unstack:"
        Me.lblColumnToUnstack.Text = "Column to Unstack:"
        '
        'dlgUnstack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(414, 370)
        Me.Controls.Add(Me.ucrReceiverColumnToUnstack)
        Me.Controls.Add(Me.lblColumnToUnstack)
        Me.Controls.Add(Me.rdoRestoreHierarchy)
        Me.Controls.Add(Me.rdoMultiple)
        Me.Controls.Add(Me.rdoSingle)
        Me.Controls.Add(Me.ucrNewDFName)
        Me.Controls.Add(Me.ucrChkDropMissingCombinations)
        Me.Controls.Add(Me.ucrReceiverCarryColumns)
        Me.Controls.Add(Me.ucrReceiverFactorToUnstackby)
        Me.Controls.Add(Me.lblFactorToUnstackBy)
        Me.Controls.Add(Me.ucrSelectorForUnstack)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblCarryColumns)
        Me.Controls.Add(Me.ucrPnlUnstackCol)
        Me.Controls.Add(Me.lblMultipleColumns)
        Me.Controls.Add(Me.ucrMultipleColumnsReceiver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgUnstack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Unstack_Columns"
        Me.Text = "Unstack (Pivot Wider)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForUnstack As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFactorToUnstackBy As Label
    Friend WithEvents ucrReceiverFactorToUnstackby As ucrReceiverSingle
    Friend WithEvents ucrReceiverCarryColumns As ucrReceiverMultiple
    Friend WithEvents lblCarryColumns As Label
    Friend WithEvents ucrNewDFName As ucrSave
    Friend WithEvents ucrChkDropMissingCombinations As ucrCheck
    Friend WithEvents rdoRestoreHierarchy As RadioButton
    Friend WithEvents rdoMultiple As RadioButton
    Friend WithEvents rdoSingle As RadioButton
    Friend WithEvents lblMultipleColumns As Label
    Friend WithEvents ucrMultipleColumnsReceiver As ucrReceiverMultiple
    Friend WithEvents ucrPnlUnstackCol As UcrPanel
    Friend WithEvents ucrReceiverColumnToUnstack As ucrReceiverSingle
    Friend WithEvents lblColumnToUnstack As Label
End Class