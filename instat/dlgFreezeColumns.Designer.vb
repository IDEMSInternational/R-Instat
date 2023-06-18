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
Partial Class dlgFreezeColumns
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
        Me.ucrSelectorByDataFrameAddRemoveforFreezeColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverMultipleforFreezeColumns = New instat.ucrReceiverMultiple()
        Me.ucrBaseforFreezeColumns = New instat.ucrButtons()
        Me.lblFreezeColumns = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrSelectorByDataFrameAddRemoveforFreezeColumns
        '
        Me.ucrSelectorByDataFrameAddRemoveforFreezeColumns.AutoSize = True
        Me.ucrSelectorByDataFrameAddRemoveforFreezeColumns.bDropUnusedFilterLevels = False
        Me.ucrSelectorByDataFrameAddRemoveforFreezeColumns.bShowHiddenColumns = False
        Me.ucrSelectorByDataFrameAddRemoveforFreezeColumns.bUseCurrentFilter = True
        Me.ucrSelectorByDataFrameAddRemoveforFreezeColumns.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorByDataFrameAddRemoveforFreezeColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByDataFrameAddRemoveforFreezeColumns.Name = "ucrSelectorByDataFrameAddRemoveforFreezeColumns"
        Me.ucrSelectorByDataFrameAddRemoveforFreezeColumns.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorByDataFrameAddRemoveforFreezeColumns.TabIndex = 0
        '
        'ucrReceiverMultipleforFreezeColumns
        '
        Me.ucrReceiverMultipleforFreezeColumns.AutoSize = True
        Me.ucrReceiverMultipleforFreezeColumns.frmParent = Me
        Me.ucrReceiverMultipleforFreezeColumns.Location = New System.Drawing.Point(259, 60)
        Me.ucrReceiverMultipleforFreezeColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleforFreezeColumns.Name = "ucrReceiverMultipleforFreezeColumns"
        Me.ucrReceiverMultipleforFreezeColumns.Selector = Nothing
        Me.ucrReceiverMultipleforFreezeColumns.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleforFreezeColumns.strNcFilePath = ""
        Me.ucrReceiverMultipleforFreezeColumns.TabIndex = 2
        Me.ucrReceiverMultipleforFreezeColumns.ucrSelector = Nothing
        '
        'ucrBaseforFreezeColumns
        '
        Me.ucrBaseforFreezeColumns.AutoSize = True
        Me.ucrBaseforFreezeColumns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBaseforFreezeColumns.Location = New System.Drawing.Point(10, 211)
        Me.ucrBaseforFreezeColumns.Name = "ucrBaseforFreezeColumns"
        Me.ucrBaseforFreezeColumns.Size = New System.Drawing.Size(405, 52)
        Me.ucrBaseforFreezeColumns.TabIndex = 3
        '
        'lblFreezeColumns
        '
        Me.lblFreezeColumns.AutoSize = True
        Me.lblFreezeColumns.Location = New System.Drawing.Point(262, 41)
        Me.lblFreezeColumns.Name = "lblFreezeColumns"
        Me.lblFreezeColumns.Size = New System.Drawing.Size(85, 13)
        Me.lblFreezeColumns.TabIndex = 1
        Me.lblFreezeColumns.Text = "Freeze Columns:"
        '
        'dlgFreezeColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(418, 271)
        Me.Controls.Add(Me.lblFreezeColumns)
        Me.Controls.Add(Me.ucrBaseforFreezeColumns)
        Me.Controls.Add(Me.ucrReceiverMultipleforFreezeColumns)
        Me.Controls.Add(Me.ucrSelectorByDataFrameAddRemoveforFreezeColumns)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFreezeColumns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Freeze Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorByDataFrameAddRemoveforFreezeColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverMultipleforFreezeColumns As ucrReceiverMultiple
    Friend WithEvents ucrBaseforFreezeColumns As ucrButtons
    Friend WithEvents lblFreezeColumns As Label
End Class
