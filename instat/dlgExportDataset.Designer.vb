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
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.ForeColor = System.Drawing.Color.Green
        Me.lblConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConfirm.Location = New System.Drawing.Point(85, 240)
        Me.lblConfirm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(148, 13)
        Me.lblConfirm.TabIndex = 4
        Me.lblConfirm.Text = "Click Ok to Confirm the Export"
        '
        'lblDataFrames
        '
        Me.lblDataFrames.AutoSize = True
        Me.lblDataFrames.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataFrames.Location = New System.Drawing.Point(8, 10)
        Me.lblDataFrames.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDataFrames.Name = "lblDataFrames"
        Me.lblDataFrames.Size = New System.Drawing.Size(70, 13)
        Me.lblDataFrames.TabIndex = 7
        Me.lblDataFrames.Text = "Data Frames:"
        '
        'lblSelectedDataFrames
        '
        Me.lblSelectedDataFrames.AutoSize = True
        Me.lblSelectedDataFrames.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectedDataFrames.Location = New System.Drawing.Point(240, 10)
        Me.lblSelectedDataFrames.Name = "lblSelectedDataFrames"
        Me.lblSelectedDataFrames.Size = New System.Drawing.Size(115, 13)
        Me.lblSelectedDataFrames.TabIndex = 8
        Me.lblSelectedDataFrames.Text = "Selected Data Frames:"
        '
        'lblFileExtension
        '
        Me.lblFileExtension.AutoSize = True
        Me.lblFileExtension.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFileExtension.Location = New System.Drawing.Point(242, 161)
        Me.lblFileExtension.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFileExtension.Name = "lblFileExtension"
        Me.lblFileExtension.Size = New System.Drawing.Size(86, 13)
        Me.lblFileExtension.TabIndex = 12
        Me.lblFileExtension.Text = "Select File Type:"
        '
        'cboFileType
        '
        Me.cboFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFileType.FormattingEnabled = True
        Me.cboFileType.Items.AddRange(New Object() {".csv", ".xlsx", ".tsv", ".psv", ".feather", ".fwf", ".rds", ".RData", ".json", ".yml", ".dta", ".sav", ".dbf", ".arff", ".R", ".xml", ".html"})
        Me.cboFileType.Location = New System.Drawing.Point(245, 175)
        Me.cboFileType.Name = "cboFileType"
        Me.cboFileType.Size = New System.Drawing.Size(170, 21)
        Me.cboFileType.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 270)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 53)
        Me.ucrBase.TabIndex = 6
        '
        'ucrFilePath
        '
        Me.ucrFilePath.AutoSize = True
        Me.ucrFilePath.DefaultFileSuggestionName = ""
        Me.ucrFilePath.FilePath = ""
        Me.ucrFilePath.FilePathBrowseText = resources.GetString("ucrFilePath.FilePathBrowseText")
        Me.ucrFilePath.FilePathDialogFilter = resources.GetString("ucrFilePath.FilePathDialogFilter")
        Me.ucrFilePath.FilePathDialogTitle = "Export Data File"
        Me.ucrFilePath.FilePathLabel = resources.GetString("ucrFilePath.FilePathLabel")
        Me.ucrFilePath.FolderBrowse = False
        Me.ucrFilePath.Location = New System.Drawing.Point(8, 211)
        Me.ucrFilePath.Name = "ucrFilePath"
        Me.ucrFilePath.SelectedFileFilterIndex = 1
        Me.ucrFilePath.Size = New System.Drawing.Size(1001, 34)
        Me.ucrFilePath.TabIndex = 5
        '
        'ucrSelectorDataFrames
        '
        Me.ucrSelectorDataFrames.AutoSize = True
        Me.ucrSelectorDataFrames.bShowHiddenColumns = False
        Me.ucrSelectorDataFrames.Location = New System.Drawing.Point(10, 28)
        Me.ucrSelectorDataFrames.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDataFrames.Name = "ucrSelectorDataFrames"
        Me.ucrSelectorDataFrames.Size = New System.Drawing.Size(216, 147)
        Me.ucrSelectorDataFrames.TabIndex = 1
        '
        'ucrReceiverMultipleDataFrames
        '
        Me.ucrReceiverMultipleDataFrames.AutoSize = True
        Me.ucrReceiverMultipleDataFrames.frmParent = Me
        Me.ucrReceiverMultipleDataFrames.Location = New System.Drawing.Point(243, 28)
        Me.ucrReceiverMultipleDataFrames.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleDataFrames.Name = "ucrReceiverMultipleDataFrames"
        Me.ucrReceiverMultipleDataFrames.Selector = Nothing
        Me.ucrReceiverMultipleDataFrames.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleDataFrames.strNcFilePath = ""
        Me.ucrReceiverMultipleDataFrames.TabIndex = 2
        Me.ucrReceiverMultipleDataFrames.ucrSelector = Nothing
        '
        'chkSaveAsSingleFile
        '
        Me.chkSaveAsSingleFile.AutoSize = True
        Me.chkSaveAsSingleFile.Checked = True
        Me.chkSaveAsSingleFile.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSaveAsSingleFile.Location = New System.Drawing.Point(243, 133)
        Me.chkSaveAsSingleFile.Name = "chkSaveAsSingleFile"
        Me.chkSaveAsSingleFile.Size = New System.Drawing.Size(111, 17)
        Me.chkSaveAsSingleFile.TabIndex = 13
        Me.chkSaveAsSingleFile.Text = "Save as single file"
        Me.chkSaveAsSingleFile.UseVisualStyleBackColor = True
        '
        'dlgExportDataset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(441, 331)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export Datasets"
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
