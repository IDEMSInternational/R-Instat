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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgTransposeColumns))
        Me.lblColumnsToTranspose = New System.Windows.Forms.Label()
        Me.ucrReceiverColumsToTranspose = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorTransposeColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrNewDataframe = New instat.ucrSave()
        Me.ucrChkNameNewColumns = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'lblColumnsToTranspose
        '
        resources.ApplyResources(Me.lblColumnsToTranspose, "lblColumnsToTranspose")
        Me.lblColumnsToTranspose.Name = "lblColumnsToTranspose"
        Me.lblColumnsToTranspose.Tag = "Columns_to_Transpose"
        '
        'ucrReceiverColumsToTranspose
        '
        Me.ucrReceiverColumsToTranspose.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverColumsToTranspose, "ucrReceiverColumsToTranspose")
        Me.ucrReceiverColumsToTranspose.Name = "ucrReceiverColumsToTranspose"
        Me.ucrReceiverColumsToTranspose.Selector = Nothing
        Me.ucrReceiverColumsToTranspose.strNcFilePath = ""
        Me.ucrReceiverColumsToTranspose.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorTransposeColumns
        '
        Me.ucrSelectorTransposeColumns.bShowHiddenColumns = False
        Me.ucrSelectorTransposeColumns.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorTransposeColumns, "ucrSelectorTransposeColumns")
        Me.ucrSelectorTransposeColumns.Name = "ucrSelectorTransposeColumns"
        '
        'ucrNewDataframe
        '
        resources.ApplyResources(Me.ucrNewDataframe, "ucrNewDataframe")
        Me.ucrNewDataframe.Name = "ucrNewDataframe"
        '
        'ucrChkNameNewColumns
        '
        Me.ucrChkNameNewColumns.Checked = False
        resources.ApplyResources(Me.ucrChkNameNewColumns, "ucrChkNameNewColumns")
        Me.ucrChkNameNewColumns.Name = "ucrChkNameNewColumns"
        '
        'dlgTransposeColumns
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Tag = "Transpose_Columns"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorTransposeColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverColumsToTranspose As ucrReceiverMultiple
    Friend WithEvents lblColumnsToTranspose As Label
    Friend WithEvents ucrNewDataframe As ucrSave
    Friend WithEvents ucrChkNameNewColumns As ucrCheck
End Class
