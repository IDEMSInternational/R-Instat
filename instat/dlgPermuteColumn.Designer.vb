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
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(238, 45)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(93, 13)
        Me.lblSelected.TabIndex = 1
        Me.lblSelected.Tag = "Selected_Variable:"
        Me.lblSelected.Text = "Selected Variable:"
        '
        'lblNumberOfColumns
        '
        Me.lblNumberOfColumns.AutoSize = True
        Me.lblNumberOfColumns.Location = New System.Drawing.Point(239, 117)
        Me.lblNumberOfColumns.Name = "lblNumberOfColumns"
        Me.lblNumberOfColumns.Size = New System.Drawing.Size(102, 13)
        Me.lblNumberOfColumns.TabIndex = 5
        Me.lblNumberOfColumns.Tag = "Number_of_Colums"
        Me.lblNumberOfColumns.Text = "Number of Columns:"
        '
        'ucrChkSetSeed
        '
        Me.ucrChkSetSeed.AutoSize = True
        Me.ucrChkSetSeed.Checked = False
        Me.ucrChkSetSeed.Location = New System.Drawing.Point(242, 90)
        Me.ucrChkSetSeed.Name = "ucrChkSetSeed"
        Me.ucrChkSetSeed.Size = New System.Drawing.Size(116, 23)
        Me.ucrChkSetSeed.TabIndex = 3
        '
        'ucrNudSetSeed
        '
        Me.ucrNudSetSeed.AutoSize = True
        Me.ucrNudSetSeed.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSetSeed.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSetSeed.Location = New System.Drawing.Point(364, 88)
        Me.ucrNudSetSeed.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSetSeed.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSetSeed.Name = "ucrNudSetSeed"
        Me.ucrNudSetSeed.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSetSeed.TabIndex = 4
        Me.ucrNudSetSeed.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudNumberofColumns
        '
        Me.ucrNudNumberofColumns.AutoSize = True
        Me.ucrNudNumberofColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberofColumns.Location = New System.Drawing.Point(364, 117)
        Me.ucrNudNumberofColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberofColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofColumns.Name = "ucrNudNumberofColumns"
        Me.ucrNudNumberofColumns.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNumberofColumns.TabIndex = 6
        Me.ucrNudNumberofColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSavePermute
        '
        Me.ucrSavePermute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSavePermute.Location = New System.Drawing.Point(10, 196)
        Me.ucrSavePermute.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSavePermute.Name = "ucrSavePermute"
        Me.ucrSavePermute.Size = New System.Drawing.Size(329, 22)
        Me.ucrSavePermute.TabIndex = 7
        '
        'ucrReceiverPermuteRows
        '
        Me.ucrReceiverPermuteRows.AutoSize = True
        Me.ucrReceiverPermuteRows.frmParent = Me
        Me.ucrReceiverPermuteRows.Location = New System.Drawing.Point(242, 60)
        Me.ucrReceiverPermuteRows.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPermuteRows.Name = "ucrReceiverPermuteRows"
        Me.ucrReceiverPermuteRows.Selector = Nothing
        Me.ucrReceiverPermuteRows.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPermuteRows.strNcFilePath = ""
        Me.ucrReceiverPermuteRows.TabIndex = 2
        Me.ucrReceiverPermuteRows.ucrSelector = Nothing
        '
        'ucrPermuteRowsSelector
        '
        Me.ucrPermuteRowsSelector.AutoSize = True
        Me.ucrPermuteRowsSelector.bDropUnusedFilterLevels = False
        Me.ucrPermuteRowsSelector.bShowHiddenColumns = False
        Me.ucrPermuteRowsSelector.bUseCurrentFilter = True
        Me.ucrPermuteRowsSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrPermuteRowsSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrPermuteRowsSelector.Name = "ucrPermuteRowsSelector"
        Me.ucrPermuteRowsSelector.Size = New System.Drawing.Size(213, 183)
        Me.ucrPermuteRowsSelector.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 224)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 8
        '
        'dlgPermuteColumn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(419, 282)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Permute_Column"
        Me.Text = "Permute Column"
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
