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
Partial Class dlgTransposeColumns
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
        Me.lblColumnsToTranspose = New System.Windows.Forms.Label()
        Me.lblVariableNames = New System.Windows.Forms.Label()
        Me.ucrInputDisplayVariableNames = New instat.ucrInputTextBox()
        Me.ucrChkDisplayVariableNames = New instat.ucrCheck()
        Me.ucrReceiverVariableNames = New instat.ucrReceiverSingle()
        Me.ucrChkNameNewColumns = New instat.ucrCheck()
        Me.ucrNewDataframe = New instat.ucrSave()
        Me.ucrReceiverColumnsToTranspose = New instat.ucrReceiverMultiple()
        Me.ucrSelectorTransposeColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblColumnsToTranspose
        '
        Me.lblColumnsToTranspose.Location = New System.Drawing.Point(263, 45)
        Me.lblColumnsToTranspose.Name = "lblColumnsToTranspose"
        Me.lblColumnsToTranspose.Size = New System.Drawing.Size(133, 14)
        Me.lblColumnsToTranspose.TabIndex = 1
        Me.lblColumnsToTranspose.Tag = "Columns_to_Transpose"
        Me.lblColumnsToTranspose.Text = "Columns to Transpose:"
        '
        'lblVariableNames
        '
        Me.lblVariableNames.AutoSize = True
        Me.lblVariableNames.Location = New System.Drawing.Point(261, 174)
        Me.lblVariableNames.Name = "lblVariableNames"
        Me.lblVariableNames.Size = New System.Drawing.Size(116, 13)
        Me.lblVariableNames.TabIndex = 3
        Me.lblVariableNames.Text = "New Names (Optional):"
        '
        'ucrInputDisplayVariableNames
        '
        Me.ucrInputDisplayVariableNames.AddQuotesIfUnrecognised = True
        Me.ucrInputDisplayVariableNames.AutoSize = True
        Me.ucrInputDisplayVariableNames.IsMultiline = False
        Me.ucrInputDisplayVariableNames.IsReadOnly = False
        Me.ucrInputDisplayVariableNames.Location = New System.Drawing.Point(138, 235)
        Me.ucrInputDisplayVariableNames.Name = "ucrInputDisplayVariableNames"
        Me.ucrInputDisplayVariableNames.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputDisplayVariableNames.TabIndex = 7
        '
        'ucrChkDisplayVariableNames
        '
        Me.ucrChkDisplayVariableNames.AutoSize = True
        Me.ucrChkDisplayVariableNames.Checked = False
        Me.ucrChkDisplayVariableNames.Location = New System.Drawing.Point(10, 233)
        Me.ucrChkDisplayVariableNames.Name = "ucrChkDisplayVariableNames"
        Me.ucrChkDisplayVariableNames.Size = New System.Drawing.Size(125, 23)
        Me.ucrChkDisplayVariableNames.TabIndex = 6
        '
        'ucrReceiverVariableNames
        '
        Me.ucrReceiverVariableNames.AutoSize = True
        Me.ucrReceiverVariableNames.frmParent = Me
        Me.ucrReceiverVariableNames.Location = New System.Drawing.Point(263, 190)
        Me.ucrReceiverVariableNames.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVariableNames.Name = "ucrReceiverVariableNames"
        Me.ucrReceiverVariableNames.Selector = Nothing
        Me.ucrReceiverVariableNames.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverVariableNames.strNcFilePath = ""
        Me.ucrReceiverVariableNames.TabIndex = 4
        Me.ucrReceiverVariableNames.ucrSelector = Nothing
        '
        'ucrChkNameNewColumns
        '
        Me.ucrChkNameNewColumns.AutoSize = True
        Me.ucrChkNameNewColumns.Checked = False
        Me.ucrChkNameNewColumns.Location = New System.Drawing.Point(10, 208)
        Me.ucrChkNameNewColumns.Name = "ucrChkNameNewColumns"
        Me.ucrChkNameNewColumns.Size = New System.Drawing.Size(210, 23)
        Me.ucrChkNameNewColumns.TabIndex = 5
        '
        'ucrNewDataframe
        '
        Me.ucrNewDataframe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrNewDataframe.Location = New System.Drawing.Point(10, 263)
        Me.ucrNewDataframe.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNewDataframe.Name = "ucrNewDataframe"
        Me.ucrNewDataframe.Size = New System.Drawing.Size(360, 24)
        Me.ucrNewDataframe.TabIndex = 8
        '
        'ucrReceiverColumnsToTranspose
        '
        Me.ucrReceiverColumnsToTranspose.AutoSize = True
        Me.ucrReceiverColumnsToTranspose.frmParent = Me
        Me.ucrReceiverColumnsToTranspose.Location = New System.Drawing.Point(263, 60)
        Me.ucrReceiverColumnsToTranspose.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnsToTranspose.Name = "ucrReceiverColumnsToTranspose"
        Me.ucrReceiverColumnsToTranspose.Selector = Nothing
        Me.ucrReceiverColumnsToTranspose.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverColumnsToTranspose.strNcFilePath = ""
        Me.ucrReceiverColumnsToTranspose.TabIndex = 2
        Me.ucrReceiverColumnsToTranspose.ucrSelector = Nothing
        '
        'ucrSelectorTransposeColumns
        '
        Me.ucrSelectorTransposeColumns.AutoSize = True
        Me.ucrSelectorTransposeColumns.bDropUnusedFilterLevels = False
        Me.ucrSelectorTransposeColumns.bShowHiddenColumns = False
        Me.ucrSelectorTransposeColumns.bUseCurrentFilter = True
        Me.ucrSelectorTransposeColumns.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorTransposeColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTransposeColumns.Name = "ucrSelectorTransposeColumns"
        Me.ucrSelectorTransposeColumns.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorTransposeColumns.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 289)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 9
        '
        'dlgTransposeColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(417, 343)
        Me.Controls.Add(Me.ucrInputDisplayVariableNames)
        Me.Controls.Add(Me.ucrChkDisplayVariableNames)
        Me.Controls.Add(Me.lblVariableNames)
        Me.Controls.Add(Me.ucrReceiverVariableNames)
        Me.Controls.Add(Me.ucrChkNameNewColumns)
        Me.Controls.Add(Me.ucrNewDataframe)
        Me.Controls.Add(Me.ucrReceiverColumnsToTranspose)
        Me.Controls.Add(Me.ucrSelectorTransposeColumns)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblColumnsToTranspose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTransposeColumns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Transpose_Columns"
        Me.Text = "Transpose Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorTransposeColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverColumnsToTranspose As ucrReceiverMultiple
    Friend WithEvents lblColumnsToTranspose As Label
    Friend WithEvents ucrNewDataframe As ucrSave
    Friend WithEvents ucrChkNameNewColumns As ucrCheck
    Friend WithEvents lblVariableNames As Label
    Friend WithEvents ucrReceiverVariableNames As ucrReceiverSingle
    Friend WithEvents ucrChkDisplayVariableNames As ucrCheck
    Friend WithEvents ucrInputDisplayVariableNames As ucrInputTextBox
End Class
