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
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(252, 45)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(93, 13)
        Me.lblSelected.TabIndex = 1
        Me.lblSelected.Tag = "Selected_Variable:"
        Me.lblSelected.Text = "Selected Variable:"
        '
        'lblSampleSize
        '
        Me.lblSampleSize.AutoSize = True
        Me.lblSampleSize.Location = New System.Drawing.Point(252, 93)
        Me.lblSampleSize.Name = "lblSampleSize"
        Me.lblSampleSize.Size = New System.Drawing.Size(68, 13)
        Me.lblSampleSize.TabIndex = 3
        Me.lblSampleSize.Tag = "Sample_Size:"
        Me.lblSampleSize.Text = "Sample Size:"
        '
        'lblNumberOfColumns
        '
        Me.lblNumberOfColumns.AutoSize = True
        Me.lblNumberOfColumns.Location = New System.Drawing.Point(252, 119)
        Me.lblNumberOfColumns.Name = "lblNumberOfColumns"
        Me.lblNumberOfColumns.Size = New System.Drawing.Size(102, 13)
        Me.lblNumberOfColumns.TabIndex = 5
        Me.lblNumberOfColumns.Tag = "Number_of_Columns:"
        Me.lblNumberOfColumns.Text = "Number of Columns:"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 224)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 11
        '
        'ucrNewDataFrame
        '
        Me.ucrNewDataFrame.Location = New System.Drawing.Point(10, 198)
        Me.ucrNewDataFrame.Name = "ucrNewDataFrame"
        Me.ucrNewDataFrame.Size = New System.Drawing.Size(285, 24)
        Me.ucrNewDataFrame.TabIndex = 10
        '
        'ucrChkWithReplacement
        '
        Me.ucrChkWithReplacement.Checked = False
        Me.ucrChkWithReplacement.Location = New System.Drawing.Point(252, 167)
        Me.ucrChkWithReplacement.Name = "ucrChkWithReplacement"
        Me.ucrChkWithReplacement.Size = New System.Drawing.Size(171, 20)
        Me.ucrChkWithReplacement.TabIndex = 9
        '
        'ucrChkSetSeed
        '
        Me.ucrChkSetSeed.Checked = False
        Me.ucrChkSetSeed.Location = New System.Drawing.Point(252, 141)
        Me.ucrChkSetSeed.Name = "ucrChkSetSeed"
        Me.ucrChkSetSeed.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSetSeed.TabIndex = 7
        '
        'ucrNudSetSeed
        '
        Me.ucrNudSetSeed.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSetSeed.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSetSeed.Location = New System.Drawing.Point(363, 141)
        Me.ucrNudSetSeed.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSetSeed.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSetSeed.Name = "ucrNudSetSeed"
        Me.ucrNudSetSeed.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSetSeed.TabIndex = 8
        Me.ucrNudSetSeed.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudNumberOfColumns
        '
        Me.ucrNudNumberOfColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Location = New System.Drawing.Point(363, 115)
        Me.ucrNudNumberOfColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Name = "ucrNudNumberOfColumns"
        Me.ucrNudNumberOfColumns.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNumberOfColumns.TabIndex = 6
        Me.ucrNudNumberOfColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSampleSize
        '
        Me.ucrNudSampleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSampleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSampleSize.Location = New System.Drawing.Point(363, 89)
        Me.ucrNudSampleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSampleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSampleSize.Name = "ucrNudSampleSize"
        Me.ucrNudSampleSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSampleSize.TabIndex = 4
        Me.ucrNudSampleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSelectorRandomSubsets
        '
        Me.ucrSelectorRandomSubsets.bShowHiddenColumns = False
        Me.ucrSelectorRandomSubsets.bUseCurrentFilter = True
        Me.ucrSelectorRandomSubsets.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorRandomSubsets.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorRandomSubsets.Name = "ucrSelectorRandomSubsets"
        Me.ucrSelectorRandomSubsets.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorRandomSubsets.TabIndex = 0
        '
        'ucrReceiverSubsets
        '
        Me.ucrReceiverSubsets.frmParent = Me
        Me.ucrReceiverSubsets.Location = New System.Drawing.Point(252, 60)
        Me.ucrReceiverSubsets.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSubsets.Name = "ucrReceiverSubsets"
        Me.ucrReceiverSubsets.Selector = Nothing
        Me.ucrReceiverSubsets.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSubsets.TabIndex = 2
        Me.ucrReceiverSubsets.ucrSelector = Nothing
        '
        'dlgRandomSubsets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 282)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Random_Subsets"
        Me.Text = "Random Subsets"
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
