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
        Me.lblColumnToUnstack = New System.Windows.Forms.Label()
        Me.lblIDColumns = New System.Windows.Forms.Label()
        Me.ucrIDColumns = New instat.ucrReceiverMultiple()
        Me.ucrColumnToUnstackReceiver = New instat.ucrReceiverSingle()
        Me.ucrFactorToUnstackReceiver = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrNewDFName = New instat.ucrSave()
        Me.ucrChkDropMissingCombinations = New instat.ucrCheck()
        Me.ucrSelectorForUnstack = New instat.ucrSelectorByDataFrameAddRemove()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblFactorToUnstackBy
        '
        resources.ApplyResources(Me.lblFactorToUnstackBy, "lblFactorToUnstackBy")
        Me.lblFactorToUnstackBy.Name = "lblFactorToUnstackBy"
        Me.lblFactorToUnstackBy.Tag = "Factor_to_Unstack_By"
        '
        'lblColumnToUnstack
        '
        resources.ApplyResources(Me.lblColumnToUnstack, "lblColumnToUnstack")
        Me.lblColumnToUnstack.Name = "lblColumnToUnstack"
        Me.lblColumnToUnstack.Tag = "Column_to_Unstack:"
        '
        'lblIDColumns
        '
        resources.ApplyResources(Me.lblIDColumns, "lblIDColumns")
        Me.lblIDColumns.Name = "lblIDColumns"
        Me.lblIDColumns.Tag = "ID_Columns"
        '
        'ucrIDColumns
        '
        Me.ucrIDColumns.frmParent = Me
        resources.ApplyResources(Me.ucrIDColumns, "ucrIDColumns")
        Me.ucrIDColumns.Name = "ucrIDColumns"
        Me.ucrIDColumns.Selector = Nothing
        Me.ucrIDColumns.strNcFilePath = ""
        Me.ucrIDColumns.ucrSelector = Nothing
        '
        'ucrColumnToUnstackReceiver
        '
        Me.ucrColumnToUnstackReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrColumnToUnstackReceiver, "ucrColumnToUnstackReceiver")
        Me.ucrColumnToUnstackReceiver.Name = "ucrColumnToUnstackReceiver"
        Me.ucrColumnToUnstackReceiver.Selector = Nothing
        Me.ucrColumnToUnstackReceiver.strNcFilePath = ""
        Me.ucrColumnToUnstackReceiver.ucrSelector = Nothing
        '
        'ucrFactorToUnstackReceiver
        '
        Me.ucrFactorToUnstackReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrFactorToUnstackReceiver, "ucrFactorToUnstackReceiver")
        Me.ucrFactorToUnstackReceiver.Name = "ucrFactorToUnstackReceiver"
        Me.ucrFactorToUnstackReceiver.Selector = Nothing
        Me.ucrFactorToUnstackReceiver.strNcFilePath = ""
        Me.ucrFactorToUnstackReceiver.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
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
        'ucrSelectorForUnstack
        '
        Me.ucrSelectorForUnstack.bShowHiddenColumns = False
        Me.ucrSelectorForUnstack.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForUnstack, "ucrSelectorForUnstack")
        Me.ucrSelectorForUnstack.Name = "ucrSelectorForUnstack"
        '
        'RadioButton1
        '
        resources.ApplyResources(Me.RadioButton1, "RadioButton1")
        Me.RadioButton1.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadioButton1.FlatAppearance.BorderSize = 2
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        resources.ApplyResources(Me.RadioButton2, "RadioButton2")
        Me.RadioButton2.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadioButton2.FlatAppearance.BorderSize = 2
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        resources.ApplyResources(Me.RadioButton3, "RadioButton3")
        Me.RadioButton3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadioButton3.FlatAppearance.BorderSize = 2
        Me.RadioButton3.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'dlgUnstack
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.ucrNewDFName)
        Me.Controls.Add(Me.ucrChkDropMissingCombinations)
        Me.Controls.Add(Me.ucrIDColumns)
        Me.Controls.Add(Me.ucrColumnToUnstackReceiver)
        Me.Controls.Add(Me.ucrFactorToUnstackReceiver)
        Me.Controls.Add(Me.lblColumnToUnstack)
        Me.Controls.Add(Me.lblFactorToUnstackBy)
        Me.Controls.Add(Me.ucrSelectorForUnstack)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblIDColumns)
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
    Friend WithEvents lblColumnToUnstack As Label
    Friend WithEvents ucrFactorToUnstackReceiver As ucrReceiverSingle
    Friend WithEvents ucrColumnToUnstackReceiver As ucrReceiverSingle
    Friend WithEvents ucrIDColumns As ucrReceiverMultiple
    Friend WithEvents lblIDColumns As Label
    Friend WithEvents ucrNewDFName As ucrSave
    Friend WithEvents ucrChkDropMissingCombinations As ucrCheck
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class