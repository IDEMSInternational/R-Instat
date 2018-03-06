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
Partial Class dlgRandomSubsets
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRandomSubsets))
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.lblSampleSize = New System.Windows.Forms.Label()
        Me.lblNumberOfColumns = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrNewDataFrame = New instat.ucrSave()
        Me.ucrChkWithReplacement = New instat.ucrCheck()
        Me.ucrChkSetSeed = New instat.ucrCheck()
        Me.ucrNudSetSeed = New instat.ucrNud()
        Me.ucrNudNumberOfColumns = New instat.ucrNud()
        Me.ucrNudSampleSize = New instat.ucrNud()
        Me.ucrSelectorRandomSubsets = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverSubsets = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'lblSelected
        '
        resources.ApplyResources(Me.lblSelected, "lblSelected")
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Tag = "Selected_Variable:"
        '
        'lblSampleSize
        '
        resources.ApplyResources(Me.lblSampleSize, "lblSampleSize")
        Me.lblSampleSize.Name = "lblSampleSize"
        Me.lblSampleSize.Tag = "Sample_Size:"
        '
        'lblNumberOfColumns
        '
        resources.ApplyResources(Me.lblNumberOfColumns, "lblNumberOfColumns")
        Me.lblNumberOfColumns.Name = "lblNumberOfColumns"
        Me.lblNumberOfColumns.Tag = "Number_of_Columns:"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrNewDataFrame
        '
        resources.ApplyResources(Me.ucrNewDataFrame, "ucrNewDataFrame")
        Me.ucrNewDataFrame.Name = "ucrNewDataFrame"
        '
        'ucrChkWithReplacement
        '
        Me.ucrChkWithReplacement.Checked = False
        resources.ApplyResources(Me.ucrChkWithReplacement, "ucrChkWithReplacement")
        Me.ucrChkWithReplacement.Name = "ucrChkWithReplacement"
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
        'ucrNudSampleSize
        '
        Me.ucrNudSampleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSampleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSampleSize, "ucrNudSampleSize")
        Me.ucrNudSampleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSampleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSampleSize.Name = "ucrNudSampleSize"
        Me.ucrNudSampleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSelectorRandomSubsets
        '
        Me.ucrSelectorRandomSubsets.bShowHiddenColumns = False
        Me.ucrSelectorRandomSubsets.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorRandomSubsets, "ucrSelectorRandomSubsets")
        Me.ucrSelectorRandomSubsets.Name = "ucrSelectorRandomSubsets"
        '
        'ucrReceiverSubsets
        '
        Me.ucrReceiverSubsets.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSubsets, "ucrReceiverSubsets")
        Me.ucrReceiverSubsets.Name = "ucrReceiverSubsets"
        Me.ucrReceiverSubsets.Selector = Nothing
        Me.ucrReceiverSubsets.strNcFilePath = ""
        Me.ucrReceiverSubsets.ucrSelector = Nothing
        '
        'dlgRandomSubsets
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrReceiverSubsets)
        Me.Controls.Add(Me.ucrChkSetSeed)
        Me.Controls.Add(Me.ucrChkWithReplacement)
        Me.Controls.Add(Me.ucrNudSetSeed)
        Me.Controls.Add(Me.ucrNudNumberOfColumns)
        Me.Controls.Add(Me.ucrNudSampleSize)
        Me.Controls.Add(Me.ucrNewDataFrame)
        Me.Controls.Add(Me.lblNumberOfColumns)
        Me.Controls.Add(Me.lblSampleSize)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrSelectorRandomSubsets)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRandomSubsets"
        Me.Tag = "Random_Subsets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorRandomSubsets As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblSelected As Label
    Friend WithEvents lblSampleSize As Label
    Friend WithEvents lblNumberOfColumns As Label
    Friend WithEvents nudSetSeed As NumericUpDown
    Friend WithEvents ucrNewDataFrame As ucrSave
    Friend WithEvents ucrNudSampleSize As ucrNud
    Friend WithEvents ucrNudNumberOfColumns As ucrNud
    Friend WithEvents ucrChkWithReplacement As ucrCheck
    Friend WithEvents ucrNudSetSeed As ucrNud
    Friend WithEvents ucrChkSetSeed As ucrCheck
    Friend WithEvents ucrReceiverSubsets As ucrReceiverSingle
End Class
