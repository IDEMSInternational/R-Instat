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
        Me.lblDataFrames.AutoSize = True
        Me.lblDataFrames.Location = New System.Drawing.Point(7, 13)
        Me.lblDataFrames.Name = "lblDataFrames"
        Me.lblDataFrames.Size = New System.Drawing.Size(76, 13)
        Me.lblDataFrames.TabIndex = 0
        Me.lblDataFrames.Text = "Data Frame(s):"
        '
        'lblSelectedDataFrames
        '
        Me.lblSelectedDataFrames.AutoSize = True
        Me.lblSelectedDataFrames.Location = New System.Drawing.Point(247, 44)
        Me.lblSelectedDataFrames.Name = "lblSelectedDataFrames"
        Me.lblSelectedDataFrames.Size = New System.Drawing.Size(115, 13)
        Me.lblSelectedDataFrames.TabIndex = 2
        Me.lblSelectedDataFrames.Text = "Selected Data Frames:"
        '
        'ucrSelectorForDataFrames
        '
        Me.ucrSelectorForDataFrames.AutoSize = True
        Me.ucrSelectorForDataFrames.bShowHiddenColumns = False
        Me.ucrSelectorForDataFrames.Location = New System.Drawing.Point(10, 30)
        Me.ucrSelectorForDataFrames.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForDataFrames.Name = "ucrSelectorForDataFrames"
        Me.ucrSelectorForDataFrames.Size = New System.Drawing.Size(213, 147)
        Me.ucrSelectorForDataFrames.TabIndex = 1
        '
        'ucrChkGraphs
        '
        Me.ucrChkGraphs.AutoSize = True
        Me.ucrChkGraphs.Checked = False
        Me.ucrChkGraphs.Location = New System.Drawing.Point(10, 193)
        Me.ucrChkGraphs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrChkGraphs.Name = "ucrChkGraphs"
        Me.ucrChkGraphs.Size = New System.Drawing.Size(193, 23)
        Me.ucrChkGraphs.TabIndex = 5
        '
        'ucrChkModels
        '
        Me.ucrChkModels.AutoSize = True
        Me.ucrChkModels.Checked = False
        Me.ucrChkModels.Location = New System.Drawing.Point(10, 219)
        Me.ucrChkModels.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrChkModels.Name = "ucrChkModels"
        Me.ucrChkModels.Size = New System.Drawing.Size(128, 23)
        Me.ucrChkModels.TabIndex = 6
        '
        'ucrChkMetadata
        '
        Me.ucrChkMetadata.AutoSize = True
        Me.ucrChkMetadata.Checked = False
        Me.ucrChkMetadata.Location = New System.Drawing.Point(10, 167)
        Me.ucrChkMetadata.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrChkMetadata.Name = "ucrChkMetadata"
        Me.ucrChkMetadata.Size = New System.Drawing.Size(145, 23)
        Me.ucrChkMetadata.TabIndex = 4
        '
        'ucrReceiverMultiple
        '
        Me.ucrReceiverMultiple.AutoSize = True
        Me.ucrReceiverMultiple.frmParent = Me
        Me.ucrReceiverMultiple.Location = New System.Drawing.Point(250, 60)
        Me.ucrReceiverMultiple.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultiple.Name = "ucrReceiverMultiple"
        Me.ucrReceiverMultiple.Selector = Nothing
        Me.ucrReceiverMultiple.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultiple.strNcFilePath = ""
        Me.ucrReceiverMultiple.TabIndex = 3
        Me.ucrReceiverMultiple.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 278)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(404, 52)
        Me.ucrBase.TabIndex = 10
        '
        'ucrFilePath
        '
        Me.ucrFilePath.AutoSize = True
        Me.ucrFilePath.DefaultFileSuggestionName = ""
        Me.ucrFilePath.FilePath = ""
        Me.ucrFilePath.FilePathBrowseText = resources.GetString("ucrFilePath.FilePathBrowseText")
        Me.ucrFilePath.FilePathDialogFilter = "Saved R Objects (*.RData)|*.RData"
        Me.ucrFilePath.FilePathDialogTitle = "Export R Workspace"
        Me.ucrFilePath.FilePathLabel = resources.GetString("ucrFilePath.FilePathLabel")
        Me.ucrFilePath.FolderBrowse = False
        Me.ucrFilePath.Location = New System.Drawing.Point(14, 245)
        Me.ucrFilePath.Name = "ucrFilePath"
        Me.ucrFilePath.SelectedFileFilterIndex = 1
        Me.ucrFilePath.Size = New System.Drawing.Size(2384, 58)
        Me.ucrFilePath.TabIndex = 11
        '
        'dlgExportRWorkspace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(417, 335)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export R Workspace"
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
