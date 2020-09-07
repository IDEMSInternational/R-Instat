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
        resources.ApplyResources(Me.lblObjects, "lblObjects")
        Me.lblObjects.Name = "lblObjects"
        '
        'ucrFilePath
        '
        Me.ucrFilePath.DefaultFileSuggestionName = ""
        Me.ucrFilePath.FilePath = ""
        Me.ucrFilePath.FilePathBrowseText = "Browse"
        Me.ucrFilePath.FilePathDialogFilter = "Saved R objects (*.RData)|*.RData|Serialized R Objects (*.rds)|*.rds"
        Me.ucrFilePath.FilePathDialogTitle = "Export R Objects"
        Me.ucrFilePath.FilePathLabel = "Export File:"
        resources.ApplyResources(Me.ucrFilePath, "ucrFilePath")
        Me.ucrFilePath.Name = "ucrFilePath"
        '
        'ucrReceiverMultipleObjects
        '
        Me.ucrReceiverMultipleObjects.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMultipleObjects, "ucrReceiverMultipleObjects")
        Me.ucrReceiverMultipleObjects.Name = "ucrReceiverMultipleObjects"
        Me.ucrReceiverMultipleObjects.Selector = Nothing
        Me.ucrReceiverMultipleObjects.strNcFilePath = ""
        Me.ucrReceiverMultipleObjects.ucrSelector = Nothing
        '
        'ucrSelectorObjects
        '
        Me.ucrSelectorObjects.bDropUnusedFilterLevels = False
        Me.ucrSelectorObjects.bShowHiddenColumns = False
        Me.ucrSelectorObjects.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorObjects, "ucrSelectorObjects")
        Me.ucrSelectorObjects.Name = "ucrSelectorObjects"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgExportRObjects
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrFilePath)
        Me.Controls.Add(Me.lblObjects)
        Me.Controls.Add(Me.ucrReceiverMultipleObjects)
        Me.Controls.Add(Me.ucrSelectorObjects)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportRObjects"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorObjects As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverMultipleObjects As ucrReceiverMultiple
    Friend WithEvents lblObjects As Label
    Friend WithEvents ucrFilePath As ucrFilePath
End Class
