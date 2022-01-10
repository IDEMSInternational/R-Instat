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
Partial Class dlgExportRObjects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgExportRObjects))
        Me.lblObjects = New System.Windows.Forms.Label()
        Me.ucrFilePath = New instat.ucrFilePath()
        Me.ucrReceiverMultipleObjects = New instat.ucrReceiverMultiple()
        Me.ucrSelectorObjects = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblObjects
        '
        Me.lblObjects.AutoSize = True
        Me.lblObjects.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblObjects.Location = New System.Drawing.Point(263, 45)
        Me.lblObjects.Name = "lblObjects"
        Me.lblObjects.Size = New System.Drawing.Size(91, 13)
        Me.lblObjects.TabIndex = 1
        Me.lblObjects.Text = "Selected Objects:"
        '
        'ucrFilePath
        '
        Me.ucrFilePath.AutoSize = True
        Me.ucrFilePath.DefaultFileSuggestionName = ""
        Me.ucrFilePath.FilePath = ""
        Me.ucrFilePath.FilePathBrowseText = resources.GetString("ucrFilePath.FilePathBrowseText")
        Me.ucrFilePath.FilePathDialogFilter = "Saved R objects (*.RData)|*.RData|Serialized R Objects (*.rds)|*.rds"
        Me.ucrFilePath.FilePathDialogTitle = "Export R Objects"
        Me.ucrFilePath.FilePathLabel = resources.GetString("ucrFilePath.FilePathLabel")
        Me.ucrFilePath.FolderBrowse = False
        Me.ucrFilePath.Location = New System.Drawing.Point(14, 199)
        Me.ucrFilePath.Name = "ucrFilePath"
        Me.ucrFilePath.SelectedFileFilterIndex = 1
        Me.ucrFilePath.Size = New System.Drawing.Size(2384, 58)
        Me.ucrFilePath.TabIndex = 7
        '
        'ucrReceiverMultipleObjects
        '
        Me.ucrReceiverMultipleObjects.AutoSize = True
        Me.ucrReceiverMultipleObjects.frmParent = Me
        Me.ucrReceiverMultipleObjects.Location = New System.Drawing.Point(267, 60)
        Me.ucrReceiverMultipleObjects.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleObjects.Name = "ucrReceiverMultipleObjects"
        Me.ucrReceiverMultipleObjects.Selector = Nothing
        Me.ucrReceiverMultipleObjects.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleObjects.strNcFilePath = ""
        Me.ucrReceiverMultipleObjects.TabIndex = 2
        Me.ucrReceiverMultipleObjects.ucrSelector = Nothing
        '
        'ucrSelectorObjects
        '
        Me.ucrSelectorObjects.AutoSize = True
        Me.ucrSelectorObjects.bDropUnusedFilterLevels = False
        Me.ucrSelectorObjects.bShowHiddenColumns = False
        Me.ucrSelectorObjects.bUseCurrentFilter = True
        Me.ucrSelectorObjects.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorObjects.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorObjects.Name = "ucrSelectorObjects"
        Me.ucrSelectorObjects.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorObjects.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 232)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 6
        '
        'dlgExportRObjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(423, 288)
        Me.Controls.Add(Me.ucrFilePath)
        Me.Controls.Add(Me.lblObjects)
        Me.Controls.Add(Me.ucrReceiverMultipleObjects)
        Me.Controls.Add(Me.ucrSelectorObjects)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportRObjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export R Objects"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorObjects As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverMultipleObjects As ucrReceiverMultiple
    Friend WithEvents lblObjects As Label
    Friend WithEvents ucrFilePath As ucrFilePath
End Class
