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
Partial Class dlgPermuteColumn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgPermuteColumn))
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.lblNumberOfColumns = New System.Windows.Forms.Label()
        Me.ucrChkSetSeed = New instat.ucrCheck()
        Me.ucrNudSetSeed = New instat.ucrNud()
        Me.ucrNudNumberofColumns = New instat.ucrNud()
        Me.ucrSavePermute = New instat.ucrSave()
        Me.ucrReceiverPermuteRows = New instat.ucrReceiverSingle()
        Me.ucrPermuteRowsSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblSelected
        '
        resources.ApplyResources(Me.lblSelected, "lblSelected")
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Tag = "Selected_Variable:"
        '
        'lblNumberOfColumns
        '
        resources.ApplyResources(Me.lblNumberOfColumns, "lblNumberOfColumns")
        Me.lblNumberOfColumns.Name = "lblNumberOfColumns"
        Me.lblNumberOfColumns.Tag = "Number_of_Colums"
        '
        'ucrChkSetSeed
        '
        Me.ucrChkSetSeed.Checked = False
        resources.ApplyResources(Me.ucrChkSetSeed, "ucrChkSetSeed")
        Me.ucrChkSetSeed.Name = "ucrChkSetSeed"
        '
        'ucrNudSetSeed
        '
        Me.ucrNudSetSeed.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSetSeed.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSetSeed, "ucrNudSetSeed")
        Me.ucrNudSetSeed.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSetSeed.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSetSeed.Name = "ucrNudSetSeed"
        Me.ucrNudSetSeed.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudNumberofColumns
        '
        Me.ucrNudNumberofColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudNumberofColumns, "ucrNudNumberofColumns")
        Me.ucrNudNumberofColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberofColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofColumns.Name = "ucrNudNumberofColumns"
        Me.ucrNudNumberofColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSavePermute
        '
        resources.ApplyResources(Me.ucrSavePermute, "ucrSavePermute")
        Me.ucrSavePermute.Name = "ucrSavePermute"
        '
        'ucrReceiverPermuteRows
        '
        Me.ucrReceiverPermuteRows.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverPermuteRows, "ucrReceiverPermuteRows")
        Me.ucrReceiverPermuteRows.Name = "ucrReceiverPermuteRows"
        Me.ucrReceiverPermuteRows.Selector = Nothing
        Me.ucrReceiverPermuteRows.strNcFilePath = ""
        Me.ucrReceiverPermuteRows.ucrSelector = Nothing
        '
        'ucrPermuteRowsSelector
        '
        Me.ucrPermuteRowsSelector.bShowHiddenColumns = False
        Me.ucrPermuteRowsSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrPermuteRowsSelector, "ucrPermuteRowsSelector")
        Me.ucrPermuteRowsSelector.Name = "ucrPermuteRowsSelector"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgPermuteColumn
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkSetSeed)
        Me.Controls.Add(Me.ucrNudSetSeed)
        Me.Controls.Add(Me.ucrNudNumberofColumns)
        Me.Controls.Add(Me.ucrSavePermute)
        Me.Controls.Add(Me.lblNumberOfColumns)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrReceiverPermuteRows)
        Me.Controls.Add(Me.ucrPermuteRowsSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPermuteColumn"
        Me.Tag = "Permute_Column"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrPermuteRowsSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverPermuteRows As ucrReceiverSingle
    Friend WithEvents lblSelected As Label
    Friend WithEvents lblNumberOfColumns As Label
    Friend WithEvents ucrSavePermute As ucrSave
    Friend WithEvents ucrNudNumberofColumns As ucrNud
    Friend WithEvents ucrNudSetSeed As ucrNud
    Friend WithEvents ucrChkSetSeed As ucrCheck
End Class
