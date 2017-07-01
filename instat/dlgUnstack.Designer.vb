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
        Me.lblColumnToUnstack = New System.Windows.Forms.Label()
        Me.chkDropMissingCombinations = New System.Windows.Forms.CheckBox()
        Me.lblDataFrameForUnstack = New System.Windows.Forms.Label()
        Me.lblIDColumns = New System.Windows.Forms.Label()
        Me.ucrNewDataName = New instat.ucrInputTextBox()
        Me.ucrIDColumns = New instat.ucrReceiverMultiple()
        Me.ucrColumnToUnstackReceiver = New instat.ucrReceiverSingle()
        Me.ucrFactorToUnstackReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelectorForunstack = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblFactorToUnstackBy
        '
        Me.lblFactorToUnstackBy.Location = New System.Drawing.Point(277, 31)
        Me.lblFactorToUnstackBy.Name = "lblFactorToUnstackBy"
        Me.lblFactorToUnstackBy.Size = New System.Drawing.Size(121, 16)
        Me.lblFactorToUnstackBy.TabIndex = 8
        Me.lblFactorToUnstackBy.Tag = "Factor_to_Unstack_By"
        Me.lblFactorToUnstackBy.Text = "Factor to Unstack by:"
        '
        'lblColumnToUnstack
        '
        Me.lblColumnToUnstack.Location = New System.Drawing.Point(278, 79)
        Me.lblColumnToUnstack.Name = "lblColumnToUnstack"
        Me.lblColumnToUnstack.Size = New System.Drawing.Size(119, 23)
        Me.lblColumnToUnstack.TabIndex = 7
        Me.lblColumnToUnstack.Tag = "Column_to_Unstack"
        Me.lblColumnToUnstack.Text = "Column to Unstack by:"
        '
        'chkDropMissingCombinations
        '
        Me.chkDropMissingCombinations.Location = New System.Drawing.Point(10, 199)
        Me.chkDropMissingCombinations.Name = "chkDropMissingCombinations"
        Me.chkDropMissingCombinations.Size = New System.Drawing.Size(210, 24)
        Me.chkDropMissingCombinations.TabIndex = 6
        Me.chkDropMissingCombinations.Tag = "Drop_Missing_Combinations"
        Me.chkDropMissingCombinations.Text = "Drop Missing Combinations"
        Me.chkDropMissingCombinations.UseVisualStyleBackColor = True
        '
        'lblDataFrameForUnstack
        '
        Me.lblDataFrameForUnstack.Location = New System.Drawing.Point(8, 232)
        Me.lblDataFrameForUnstack.Name = "lblDataFrameForUnstack"
        Me.lblDataFrameForUnstack.Size = New System.Drawing.Size(125, 23)
        Me.lblDataFrameForUnstack.TabIndex = 3
        Me.lblDataFrameForUnstack.Tag = "New_Data_Frame_Name"
        Me.lblDataFrameForUnstack.Text = "New Data Frame Name:"
        '
        'lblIDColumns
        '
        Me.lblIDColumns.Location = New System.Drawing.Point(282, 124)
        Me.lblIDColumns.Name = "lblIDColumns"
        Me.lblIDColumns.Size = New System.Drawing.Size(100, 23)
        Me.lblIDColumns.TabIndex = 1
        Me.lblIDColumns.Tag = "ID_Columns"
        Me.lblIDColumns.Text = "ID Columns:"
        '
        'ucrNewDataName
        '
        Me.ucrNewDataName.IsReadOnly = False
        Me.ucrNewDataName.Location = New System.Drawing.Point(131, 229)
        Me.ucrNewDataName.Name = "ucrNewDataName"
        Me.ucrNewDataName.Size = New System.Drawing.Size(137, 21)
        Me.ucrNewDataName.TabIndex = 0
        '
        'ucrIDColumns
        '
        Me.ucrIDColumns.Location = New System.Drawing.Point(281, 140)
        Me.ucrIDColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrIDColumns.Name = "ucrIDColumns"
        Me.ucrIDColumns.Selector = Nothing
        Me.ucrIDColumns.Size = New System.Drawing.Size(120, 110)
        Me.ucrIDColumns.TabIndex = 2
        '
        'ucrColumnToUnstackReceiver
        '
        Me.ucrColumnToUnstackReceiver.Location = New System.Drawing.Point(279, 96)
        Me.ucrColumnToUnstackReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrColumnToUnstackReceiver.Name = "ucrColumnToUnstackReceiver"
        Me.ucrColumnToUnstackReceiver.Selector = Nothing
        Me.ucrColumnToUnstackReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrColumnToUnstackReceiver.TabIndex = 4
        '
        'ucrFactorToUnstackReceiver
        '
        Me.ucrFactorToUnstackReceiver.Location = New System.Drawing.Point(279, 48)
        Me.ucrFactorToUnstackReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorToUnstackReceiver.Name = "ucrFactorToUnstackReceiver"
        Me.ucrFactorToUnstackReceiver.Selector = Nothing
        Me.ucrFactorToUnstackReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrFactorToUnstackReceiver.TabIndex = 5
        '
        'ucrSelectorForunstack
        '
        Me.ucrSelectorForunstack.bShowHiddenColumns = False
        Me.ucrSelectorForunstack.bUseCurrentFilter = True
        Me.ucrSelectorForunstack.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForunstack.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForunstack.Name = "ucrSelectorForunstack"
        Me.ucrSelectorForunstack.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForunstack.TabIndex = 9
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 256)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 10
        '
        'dlgUnstack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 318)
        Me.Controls.Add(Me.ucrNewDataName)
        Me.Controls.Add(Me.ucrIDColumns)
        Me.Controls.Add(Me.lblDataFrameForUnstack)
        Me.Controls.Add(Me.ucrColumnToUnstackReceiver)
        Me.Controls.Add(Me.ucrFactorToUnstackReceiver)
        Me.Controls.Add(Me.chkDropMissingCombinations)
        Me.Controls.Add(Me.lblColumnToUnstack)
        Me.Controls.Add(Me.lblFactorToUnstackBy)
        Me.Controls.Add(Me.ucrSelectorForunstack)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblIDColumns)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgUnstack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Unstack_Columns"
        Me.Text = "Unstack Columns"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForunstack As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFactorToUnstackBy As Label
    Friend WithEvents lblColumnToUnstack As Label
    Friend WithEvents chkDropMissingCombinations As CheckBox
    Friend WithEvents ucrFactorToUnstackReceiver As ucrReceiverSingle
    Friend WithEvents ucrColumnToUnstackReceiver As ucrReceiverSingle
    Friend WithEvents lblDataFrameForUnstack As Label
    Friend WithEvents ucrIDColumns As ucrReceiverMultiple
    Friend WithEvents lblIDColumns As Label
    Friend WithEvents ucrNewDataName As ucrInputTextBox
End Class
