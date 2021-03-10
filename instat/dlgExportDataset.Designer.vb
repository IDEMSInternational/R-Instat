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
Partial Class dlgExportDataset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgExportDataset))
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.lblDataFrames = New System.Windows.Forms.Label()
        Me.lblSelectedDataFrames = New System.Windows.Forms.Label()
        Me.lblFileExtension = New System.Windows.Forms.Label()
        Me.cboFileType = New System.Windows.Forms.ComboBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrFilePath = New instat.ucrFilePath()
        Me.ucrSelectorDataFrames = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverMultipleDataFrames = New instat.ucrReceiverMultiple()
        Me.chkSaveAsSingleFile = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblConfirm
        '
        resources.ApplyResources(Me.lblConfirm, "lblConfirm")
        Me.lblConfirm.ForeColor = System.Drawing.Color.Green
        Me.lblConfirm.Name = "lblConfirm"
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
        'lblFileExtension
        '
        resources.ApplyResources(Me.lblFileExtension, "lblFileExtension")
        Me.lblFileExtension.Name = "lblFileExtension"
        '
        'cboFileType
        '
        Me.cboFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFileType.FormattingEnabled = True
        Me.cboFileType.Items.AddRange(New Object() {resources.GetString("cboFileType.Items"), resources.GetString("cboFileType.Items1"), resources.GetString("cboFileType.Items2"), resources.GetString("cboFileType.Items3"), resources.GetString("cboFileType.Items4"), resources.GetString("cboFileType.Items5"), resources.GetString("cboFileType.Items6"), resources.GetString("cboFileType.Items7"), resources.GetString("cboFileType.Items8"), resources.GetString("cboFileType.Items9"), resources.GetString("cboFileType.Items10"), resources.GetString("cboFileType.Items11"), resources.GetString("cboFileType.Items12"), resources.GetString("cboFileType.Items13"), resources.GetString("cboFileType.Items14"), resources.GetString("cboFileType.Items15"), resources.GetString("cboFileType.Items16")})
        resources.ApplyResources(Me.cboFileType, "cboFileType")
        Me.cboFileType.Name = "cboFileType"
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
        Me.ucrFilePath.FilePathDialogFilter = resources.GetString("ucrFilePath.FilePathDialogFilter")
        Me.ucrFilePath.FilePathDialogTitle = "Export Data File"
        Me.ucrFilePath.FilePathLabel = "Export File(s):"
        Me.ucrFilePath.FolderBrowse = False
        resources.ApplyResources(Me.ucrFilePath, "ucrFilePath")
        Me.ucrFilePath.Name = "ucrFilePath"
        Me.ucrFilePath.SelectedFileFilterIndex = 1
        '
        'ucrSelectorDataFrames
        '
        Me.ucrSelectorDataFrames.bShowHiddenColumns = False
        resources.ApplyResources(Me.ucrSelectorDataFrames, "ucrSelectorDataFrames")
        Me.ucrSelectorDataFrames.Name = "ucrSelectorDataFrames"
        '
        'ucrReceiverMultipleDataFrames
        '
        Me.ucrReceiverMultipleDataFrames.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMultipleDataFrames, "ucrReceiverMultipleDataFrames")
        Me.ucrReceiverMultipleDataFrames.Name = "ucrReceiverMultipleDataFrames"
        Me.ucrReceiverMultipleDataFrames.Selector = Nothing
        Me.ucrReceiverMultipleDataFrames.strNcFilePath = ""
        Me.ucrReceiverMultipleDataFrames.ucrSelector = Nothing
        '
        'chkSaveAsSingleFile
        '
        resources.ApplyResources(Me.chkSaveAsSingleFile, "chkSaveAsSingleFile")
        Me.chkSaveAsSingleFile.Checked = True
        Me.chkSaveAsSingleFile.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSaveAsSingleFile.Name = "chkSaveAsSingleFile"
        Me.chkSaveAsSingleFile.UseVisualStyleBackColor = True
        '
        'dlgExportDataset
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkSaveAsSingleFile)
        Me.Controls.Add(Me.cboFileType)
        Me.Controls.Add(Me.lblFileExtension)
        Me.Controls.Add(Me.ucrReceiverMultipleDataFrames)
        Me.Controls.Add(Me.lblSelectedDataFrames)
        Me.Controls.Add(Me.lblDataFrames)
        Me.Controls.Add(Me.ucrSelectorDataFrames)
        Me.Controls.Add(Me.ucrFilePath)
        Me.Controls.Add(Me.lblConfirm)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportDataset"
        Me.ShowIcon = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblConfirm As Label
    Friend WithEvents ucrFilePath As ucrFilePath
    Friend WithEvents ucrSelectorDataFrames As ucrSelectorAddRemove
    Friend WithEvents lblDataFrames As Label
    Friend WithEvents lblSelectedDataFrames As Label
    Friend WithEvents ucrReceiverMultipleDataFrames As ucrReceiverMultiple
    Friend WithEvents lblFileExtension As Label
    Friend WithEvents cboFileType As ComboBox
    Friend WithEvents chkSaveAsSingleFile As CheckBox
End Class
