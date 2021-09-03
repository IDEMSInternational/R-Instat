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
Partial Class dlgStack
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgStack))
        Me.lblColumnsTostack = New System.Windows.Forms.Label()
        Me.lblStackDataInto = New System.Windows.Forms.Label()
        Me.lblFactorInto = New System.Windows.Forms.Label()
        Me.lblSets = New System.Windows.Forms.Label()
        Me.ucrNudNoSets = New instat.ucrNud()
        Me.ucrChkStackMultipleSets = New instat.ucrCheck()
        Me.ucrSaveNewDataName = New instat.ucrSave()
        Me.ucrChkCarryColumns = New instat.ucrCheck()
        Me.ucrStackDataInto = New instat.ucrInputTextBox()
        Me.ucrFactorInto = New instat.ucrInputTextBox()
        Me.ucrColumnsToCarryReceiver = New instat.ucrReceiverMultiple()
        Me.ucrSelectorStack = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverColumnsToBeStack = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'lblColumnsTostack
        '
        resources.ApplyResources(Me.lblColumnsTostack, "lblColumnsTostack")
        Me.lblColumnsTostack.Name = "lblColumnsTostack"
        Me.lblColumnsTostack.Tag = "Columns_to_Stack:"
        '
        'lblStackDataInto
        '
        resources.ApplyResources(Me.lblStackDataInto, "lblStackDataInto")
        Me.lblStackDataInto.Name = "lblStackDataInto"
        Me.lblStackDataInto.Tag = "Stack_Data_Into"
        '
        'lblFactorInto
        '
        resources.ApplyResources(Me.lblFactorInto, "lblFactorInto")
        Me.lblFactorInto.Name = "lblFactorInto"
        Me.lblFactorInto.Tag = "Factor_Into"
        '
        'lblSets
        '
        resources.ApplyResources(Me.lblSets, "lblSets")
        Me.lblSets.Name = "lblSets"
        '
        'ucrNudNoSets
        '
        Me.ucrNudNoSets.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoSets.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudNoSets, "ucrNudNoSets")
        Me.ucrNudNoSets.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNoSets.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoSets.Name = "ucrNudNoSets"
        Me.ucrNudNoSets.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkStackMultipleSets
        '
        Me.ucrChkStackMultipleSets.Checked = False
        resources.ApplyResources(Me.ucrChkStackMultipleSets, "ucrChkStackMultipleSets")
        Me.ucrChkStackMultipleSets.Name = "ucrChkStackMultipleSets"
        '
        'ucrSaveNewDataName
        '
        resources.ApplyResources(Me.ucrSaveNewDataName, "ucrSaveNewDataName")
        Me.ucrSaveNewDataName.Name = "ucrSaveNewDataName"
        '
        'ucrChkCarryColumns
        '
        Me.ucrChkCarryColumns.Checked = False
        resources.ApplyResources(Me.ucrChkCarryColumns, "ucrChkCarryColumns")
        Me.ucrChkCarryColumns.Name = "ucrChkCarryColumns"
        '
        'ucrStackDataInto
        '
        Me.ucrStackDataInto.AddQuotesIfUnrecognised = True
        Me.ucrStackDataInto.IsMultiline = False
        Me.ucrStackDataInto.IsReadOnly = False
        resources.ApplyResources(Me.ucrStackDataInto, "ucrStackDataInto")
        Me.ucrStackDataInto.Name = "ucrStackDataInto"
        '
        'ucrFactorInto
        '
        Me.ucrFactorInto.AddQuotesIfUnrecognised = True
        Me.ucrFactorInto.IsMultiline = False
        Me.ucrFactorInto.IsReadOnly = False
        resources.ApplyResources(Me.ucrFactorInto, "ucrFactorInto")
        Me.ucrFactorInto.Name = "ucrFactorInto"
        '
        'ucrColumnsToCarryReceiver
        '
        Me.ucrColumnsToCarryReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrColumnsToCarryReceiver, "ucrColumnsToCarryReceiver")
        Me.ucrColumnsToCarryReceiver.Name = "ucrColumnsToCarryReceiver"
        Me.ucrColumnsToCarryReceiver.Selector = Nothing
        Me.ucrColumnsToCarryReceiver.strNcFilePath = ""
        Me.ucrColumnsToCarryReceiver.ucrSelector = Nothing
        '
        'ucrSelectorStack
        '
        Me.ucrSelectorStack.bDropUnusedFilterLevels = False
        Me.ucrSelectorStack.bShowHiddenColumns = False
        Me.ucrSelectorStack.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorStack, "ucrSelectorStack")
        Me.ucrSelectorStack.Name = "ucrSelectorStack"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReceiverColumnsToBeStack
        '
        Me.ucrReceiverColumnsToBeStack.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverColumnsToBeStack, "ucrReceiverColumnsToBeStack")
        Me.ucrReceiverColumnsToBeStack.Name = "ucrReceiverColumnsToBeStack"
        Me.ucrReceiverColumnsToBeStack.Selector = Nothing
        Me.ucrReceiverColumnsToBeStack.strNcFilePath = ""
        Me.ucrReceiverColumnsToBeStack.ucrSelector = Nothing
        '
        'dlgStack
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblSets)
        Me.Controls.Add(Me.ucrNudNoSets)
        Me.Controls.Add(Me.ucrChkStackMultipleSets)
        Me.Controls.Add(Me.ucrChkCarryColumns)
        Me.Controls.Add(Me.ucrStackDataInto)
        Me.Controls.Add(Me.ucrFactorInto)
        Me.Controls.Add(Me.ucrColumnsToCarryReceiver)
        Me.Controls.Add(Me.ucrSelectorStack)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblFactorInto)
        Me.Controls.Add(Me.lblStackDataInto)
        Me.Controls.Add(Me.lblColumnsTostack)
        Me.Controls.Add(Me.ucrReceiverColumnsToBeStack)
        Me.Controls.Add(Me.ucrSaveNewDataName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgStack"
        Me.Tag = "Stack_join_columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrReceiverColumnsToBeStack As ucrReceiverMultiple
    Friend WithEvents lblColumnsTostack As Label
    Friend WithEvents lblStackDataInto As Label
    Friend WithEvents lblFactorInto As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorStack As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrColumnsToCarryReceiver As ucrReceiverMultiple
    Friend WithEvents ucrFactorInto As ucrInputTextBox
    Friend WithEvents ucrStackDataInto As ucrInputTextBox
    Friend WithEvents ucrChkCarryColumns As ucrCheck
    Friend WithEvents ucrSaveNewDataName As ucrSave
    Friend WithEvents ucrNudNoSets As ucrNud
    Friend WithEvents ucrChkStackMultipleSets As ucrCheck
    Friend WithEvents lblSets As Label
End Class
