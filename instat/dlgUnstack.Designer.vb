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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgUnstack))
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
        resources.ApplyResources(Me.lblFactorToUnstackBy, "lblFactorToUnstackBy")
        Me.lblFactorToUnstackBy.Name = "lblFactorToUnstackBy"
        Me.lblFactorToUnstackBy.Tag = "Factor_to_Unstack_By"
        '
        'lblCarryColumns
        '
        resources.ApplyResources(Me.lblCarryColumns, "lblCarryColumns")
        Me.lblCarryColumns.Name = "lblCarryColumns"
        Me.lblCarryColumns.Tag = "ID_Columns"
        '
        'rdoSingle
        '
        resources.ApplyResources(Me.rdoSingle, "rdoSingle")
        Me.rdoSingle.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSingle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingle.FlatAppearance.BorderSize = 2
        Me.rdoSingle.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingle.Name = "rdoSingle"
        Me.rdoSingle.TabStop = True
        Me.rdoSingle.UseVisualStyleBackColor = False
        '
        'rdoMultiple
        '
        resources.ApplyResources(Me.rdoMultiple, "rdoMultiple")
        Me.rdoMultiple.BackColor = System.Drawing.SystemColors.Control
        Me.rdoMultiple.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.FlatAppearance.BorderSize = 2
        Me.rdoMultiple.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.Name = "rdoMultiple"
        Me.rdoMultiple.TabStop = True
        Me.rdoMultiple.UseVisualStyleBackColor = False
        '
        'rdoRestoreHierarchy
        '
        resources.ApplyResources(Me.rdoRestoreHierarchy, "rdoRestoreHierarchy")
        Me.rdoRestoreHierarchy.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRestoreHierarchy.FlatAppearance.BorderSize = 2
        Me.rdoRestoreHierarchy.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRestoreHierarchy.Name = "rdoRestoreHierarchy"
        Me.rdoRestoreHierarchy.TabStop = True
        Me.rdoRestoreHierarchy.UseVisualStyleBackColor = True
        '
        'lblMultipleColumns
        '
        resources.ApplyResources(Me.lblMultipleColumns, "lblMultipleColumns")
        Me.lblMultipleColumns.Name = "lblMultipleColumns"
        '
        'ucrNewDFName
        '
        resources.ApplyResources(Me.ucrNewDFName, "ucrNewDFName")
        Me.ucrNewDFName.Name = "ucrNewDFName"
        '
        'ucrChkDropMissingCombinations
        '
        Me.ucrChkDropMissingCombinations.Checked = False
        resources.ApplyResources(Me.ucrChkDropMissingCombinations, "ucrChkDropMissingCombinations")
        Me.ucrChkDropMissingCombinations.Name = "ucrChkDropMissingCombinations"
        '
        'ucrReceiverCarryColumns
        '
        Me.ucrReceiverCarryColumns.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverCarryColumns, "ucrReceiverCarryColumns")
        Me.ucrReceiverCarryColumns.Name = "ucrReceiverCarryColumns"
        Me.ucrReceiverCarryColumns.Selector = Nothing
        Me.ucrReceiverCarryColumns.strNcFilePath = ""
        Me.ucrReceiverCarryColumns.ucrSelector = Nothing
        '
        'ucrReceiverFactorToUnstackby
        '
        Me.ucrReceiverFactorToUnstackby.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFactorToUnstackby, "ucrReceiverFactorToUnstackby")
        Me.ucrReceiverFactorToUnstackby.Name = "ucrReceiverFactorToUnstackby"
        Me.ucrReceiverFactorToUnstackby.Selector = Nothing
        Me.ucrReceiverFactorToUnstackby.strNcFilePath = ""
        Me.ucrReceiverFactorToUnstackby.ucrSelector = Nothing
        '
        'ucrSelectorForUnstack
        '
        Me.ucrSelectorForUnstack.bDropUnusedFilterLevels = False
        Me.ucrSelectorForUnstack.bShowHiddenColumns = False
        Me.ucrSelectorForUnstack.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForUnstack, "ucrSelectorForUnstack")
        Me.ucrSelectorForUnstack.Name = "ucrSelectorForUnstack"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrPnlUnstackCol
        '
        resources.ApplyResources(Me.ucrPnlUnstackCol, "ucrPnlUnstackCol")
        Me.ucrPnlUnstackCol.Name = "ucrPnlUnstackCol"
        '
        'ucrMultipleColumnsReceiver
        '
        Me.ucrMultipleColumnsReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrMultipleColumnsReceiver, "ucrMultipleColumnsReceiver")
        Me.ucrMultipleColumnsReceiver.Name = "ucrMultipleColumnsReceiver"
        Me.ucrMultipleColumnsReceiver.Selector = Nothing
        Me.ucrMultipleColumnsReceiver.strNcFilePath = ""
        Me.ucrMultipleColumnsReceiver.ucrSelector = Nothing
        '
        'ucrReceiverColumnToUnstack
        '
        Me.ucrReceiverColumnToUnstack.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverColumnToUnstack, "ucrReceiverColumnToUnstack")
        Me.ucrReceiverColumnToUnstack.Name = "ucrReceiverColumnToUnstack"
        Me.ucrReceiverColumnToUnstack.Selector = Nothing
        Me.ucrReceiverColumnToUnstack.strNcFilePath = ""
        Me.ucrReceiverColumnToUnstack.ucrSelector = Nothing
        '
        'lblColumnToUnstack
        '
        resources.ApplyResources(Me.lblColumnToUnstack, "lblColumnToUnstack")
        Me.lblColumnToUnstack.Name = "lblColumnToUnstack"
        Me.lblColumnToUnstack.Tag = "Column_to_Unstack:"
        '
        'dlgUnstack
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Tag = "Unstack_Columns"
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