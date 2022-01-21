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
        Me.ucrInputVariableName = New instat.ucrInputTextBox()
        Me.ucrReceiverMakeNames = New instat.ucrReceiverSingle()
        Me.ucrChkKeepNames = New instat.ucrCheck()
        Me.ucrChkNameNewColumns = New instat.ucrCheck()
        Me.ucrNewDataframe = New instat.ucrSave()
        Me.ucrReceiverColumsToTranspose = New instat.ucrReceiverMultiple()
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
        Me.lblVariableNames.Location = New System.Drawing.Point(263, 171)
        Me.lblVariableNames.Name = "lblVariableNames"
        Me.lblVariableNames.Size = New System.Drawing.Size(84, 13)
        Me.lblVariableNames.TabIndex = 8
        Me.lblVariableNames.Text = "Variable Names:"
        '
        'ucrInputVariableName
        '
        Me.ucrInputVariableName.AddQuotesIfUnrecognised = True
        Me.ucrInputVariableName.AutoSize = True
        Me.ucrInputVariableName.IsMultiline = False
        Me.ucrInputVariableName.IsReadOnly = False
        Me.ucrInputVariableName.Location = New System.Drawing.Point(105, 217)
        Me.ucrInputVariableName.Name = "ucrInputVariableName"
        Me.ucrInputVariableName.Size = New System.Drawing.Size(101, 23)
        Me.ucrInputVariableName.TabIndex = 9
        '
        'ucrReceiverMakeNames
        '
        Me.ucrReceiverMakeNames.AutoSize = True
        Me.ucrReceiverMakeNames.frmParent = Me
        Me.ucrReceiverMakeNames.Location = New System.Drawing.Point(263, 187)
        Me.ucrReceiverMakeNames.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMakeNames.Name = "ucrReceiverMakeNames"
        Me.ucrReceiverMakeNames.Selector = Nothing
        Me.ucrReceiverMakeNames.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMakeNames.strNcFilePath = ""
        Me.ucrReceiverMakeNames.TabIndex = 7
        Me.ucrReceiverMakeNames.ucrSelector = Nothing
        '
        'ucrChkKeepNames
        '
        Me.ucrChkKeepNames.AutoSize = True
        Me.ucrChkKeepNames.Checked = False
        Me.ucrChkKeepNames.Location = New System.Drawing.Point(10, 217)
        Me.ucrChkKeepNames.Name = "ucrChkKeepNames"
        Me.ucrChkKeepNames.Size = New System.Drawing.Size(89, 23)
        Me.ucrChkKeepNames.TabIndex = 6
        '
        'ucrChkNameNewColumns
        '
        Me.ucrChkNameNewColumns.AutoSize = True
        Me.ucrChkNameNewColumns.Checked = False
        Me.ucrChkNameNewColumns.Location = New System.Drawing.Point(10, 197)
        Me.ucrChkNameNewColumns.Name = "ucrChkNameNewColumns"
        Me.ucrChkNameNewColumns.Size = New System.Drawing.Size(213, 23)
        Me.ucrChkNameNewColumns.TabIndex = 3
        '
        'ucrNewDataframe
        '
        Me.ucrNewDataframe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrNewDataframe.Location = New System.Drawing.Point(10, 240)
        Me.ucrNewDataframe.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNewDataframe.Name = "ucrNewDataframe"
        Me.ucrNewDataframe.Size = New System.Drawing.Size(360, 24)
        Me.ucrNewDataframe.TabIndex = 4
        '
        'ucrReceiverColumsToTranspose
        '
        Me.ucrReceiverColumsToTranspose.AutoSize = True
        Me.ucrReceiverColumsToTranspose.frmParent = Me
        Me.ucrReceiverColumsToTranspose.Location = New System.Drawing.Point(263, 60)
        Me.ucrReceiverColumsToTranspose.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumsToTranspose.Name = "ucrReceiverColumsToTranspose"
        Me.ucrReceiverColumsToTranspose.Selector = Nothing
        Me.ucrReceiverColumsToTranspose.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverColumsToTranspose.strNcFilePath = ""
        Me.ucrReceiverColumsToTranspose.TabIndex = 2
        Me.ucrReceiverColumsToTranspose.ucrSelector = Nothing
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
        Me.ucrBase.Location = New System.Drawing.Point(10, 267)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 5
        '
        'dlgTransposeColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(417, 334)
        Me.Controls.Add(Me.ucrInputVariableName)
        Me.Controls.Add(Me.lblVariableNames)
        Me.Controls.Add(Me.ucrReceiverMakeNames)
        Me.Controls.Add(Me.ucrChkKeepNames)
        Me.Controls.Add(Me.ucrChkNameNewColumns)
        Me.Controls.Add(Me.ucrNewDataframe)
        Me.Controls.Add(Me.ucrReceiverColumsToTranspose)
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
    Friend WithEvents ucrReceiverColumsToTranspose As ucrReceiverMultiple
    Friend WithEvents lblColumnsToTranspose As Label
    Friend WithEvents ucrNewDataframe As ucrSave
    Friend WithEvents ucrChkNameNewColumns As ucrCheck
    Friend WithEvents lblVariableNames As Label
    Friend WithEvents ucrReceiverMakeNames As ucrReceiverSingle
    Friend WithEvents ucrChkKeepNames As ucrCheck
    Friend WithEvents ucrInputVariableName As ucrInputTextBox
End Class
