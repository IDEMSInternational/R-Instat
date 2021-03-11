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
Partial Class dlgExportRWorkspace
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgExportRWorkspace))
        Me.lblDataFrames = New System.Windows.Forms.Label()
        Me.lblSelectedDataFrames = New System.Windows.Forms.Label()
        Me.ucrSelectorForDataFrames = New instat.ucrSelectorAddRemove()
        Me.ucrChkGraphs = New instat.ucrCheck()
        Me.ucrChkModels = New instat.ucrCheck()
        Me.ucrChkMetadata = New instat.ucrCheck()
        Me.ucrReceiverMultiple = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrFilePath = New instat.ucrFilePath()
        Me.SuspendLayout()
        '
        'lblDataFrames
        '
        resources.ApplyResources(Me.lblDataFrames, "lblDataFrames")
        Me.lblDataFrames.Name = "lblDataFrames"
        '
        'lblSelectedDataFrames
        '
        resources.ApplyResources(Me.lblSelectedDataFrames, "lblSelectedDataFrames")
        Me.lblSelectedDataFrames.Name = "lblSelectedDataFrames"
        '
        'ucrSelectorForDataFrames
        '
        Me.ucrSelectorForDataFrames.bShowHiddenColumns = False
        resources.ApplyResources(Me.ucrSelectorForDataFrames, "ucrSelectorForDataFrames")
        Me.ucrSelectorForDataFrames.Name = "ucrSelectorForDataFrames"
        '
        'ucrChkGraphs
        '
        Me.ucrChkGraphs.Checked = False
        resources.ApplyResources(Me.ucrChkGraphs, "ucrChkGraphs")
        Me.ucrChkGraphs.Name = "ucrChkGraphs"
        '
        'ucrChkModels
        '
        Me.ucrChkModels.Checked = False
        resources.ApplyResources(Me.ucrChkModels, "ucrChkModels")
        Me.ucrChkModels.Name = "ucrChkModels"
        '
        'ucrChkMetadata
        '
        Me.ucrChkMetadata.Checked = False
        resources.ApplyResources(Me.ucrChkMetadata, "ucrChkMetadata")
        Me.ucrChkMetadata.Name = "ucrChkMetadata"
        '
        'ucrReceiverMultiple
        '
        Me.ucrReceiverMultiple.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMultiple, "ucrReceiverMultiple")
        Me.ucrReceiverMultiple.Name = "ucrReceiverMultiple"
        Me.ucrReceiverMultiple.Selector = Nothing
        Me.ucrReceiverMultiple.strNcFilePath = ""
        Me.ucrReceiverMultiple.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrFilePath
        '
        Me.ucrFilePath.DefaultFileSuggestionName = ""
        Me.ucrFilePath.FilePath = ""
        Me.ucrFilePath.FilePathBrowseText = "Browse"
        Me.ucrFilePath.FilePathDialogFilter = "Saved R Objects (*.RData)|*.RData"
        Me.ucrFilePath.FilePathDialogTitle = "Export R Workspace"
        Me.ucrFilePath.FilePathLabel = "Export File:"
        resources.ApplyResources(Me.ucrFilePath, "ucrFilePath")
        Me.ucrFilePath.Name = "ucrFilePath"
        '
        'dlgExportRWorkspace
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrFilePath)
        Me.Controls.Add(Me.lblSelectedDataFrames)
        Me.Controls.Add(Me.lblDataFrames)
        Me.Controls.Add(Me.ucrChkGraphs)
        Me.Controls.Add(Me.ucrChkModels)
        Me.Controls.Add(Me.ucrChkMetadata)
        Me.Controls.Add(Me.ucrReceiverMultiple)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorForDataFrames)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportRWorkspace"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverMultiple As ucrReceiverMultiple
    Friend WithEvents ucrChkGraphs As ucrCheck
    Friend WithEvents ucrChkModels As ucrCheck
    Friend WithEvents ucrChkMetadata As ucrCheck
    Friend WithEvents lblDataFrames As Label
    Friend WithEvents lblSelectedDataFrames As Label
    Friend WithEvents ucrSelectorForDataFrames As ucrSelectorAddRemove
    Friend WithEvents ucrFilePath As ucrFilePath
End Class
