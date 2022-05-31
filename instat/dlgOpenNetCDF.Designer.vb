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
Partial Class dlgOpenNetCDF
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
        Me.cmdBrowseFile = New System.Windows.Forms.Button()
        Me.lblFileFolderPath = New System.Windows.Forms.Label()
        Me.lblDataFramePrefix = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.cmdDetails = New System.Windows.Forms.Button()
        Me.rdoShort = New System.Windows.Forms.RadioButton()
        Me.rdoMedium = New System.Windows.Forms.RadioButton()
        Me.rdoLong = New System.Windows.Forms.RadioButton()
        Me.cmdFromLibrary = New System.Windows.Forms.Button()
        Me.cmdBrowseFolder = New System.Windows.Forms.Button()
        Me.lblNFiles = New System.Windows.Forms.Label()
        Me.lblFilesFound = New System.Windows.Forms.Label()
        Me.ucrInputFileDetails = New instat.ucrInputTextBox()
        Me.ucrInputPath = New instat.ucrInputTextBox()
        Me.ucrInputDataName = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlFileDetails = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'cmdBrowseFile
        '
        Me.cmdBrowseFile.Location = New System.Drawing.Point(320, 19)
        Me.cmdBrowseFile.Name = "cmdBrowseFile"
        Me.cmdBrowseFile.Size = New System.Drawing.Size(120, 23)
        Me.cmdBrowseFile.TabIndex = 2
        Me.cmdBrowseFile.Tag = ""
        Me.cmdBrowseFile.Text = "Browse File"
        Me.cmdBrowseFile.UseVisualStyleBackColor = True
        '
        'lblFileFolderPath
        '
        Me.lblFileFolderPath.AutoSize = True
        Me.lblFileFolderPath.Location = New System.Drawing.Point(5, 24)
        Me.lblFileFolderPath.Name = "lblFileFolderPath"
        Me.lblFileFolderPath.Size = New System.Drawing.Size(32, 13)
        Me.lblFileFolderPath.TabIndex = 0
        Me.lblFileFolderPath.Text = "Path:"
        '
        'lblDataFramePrefix
        '
        Me.lblDataFramePrefix.AutoSize = True
        Me.lblDataFramePrefix.Location = New System.Drawing.Point(5, 137)
        Me.lblDataFramePrefix.Name = "lblDataFramePrefix"
        Me.lblDataFramePrefix.Size = New System.Drawing.Size(114, 13)
        Me.lblDataFramePrefix.TabIndex = 10
        Me.lblDataFramePrefix.Tag = "Prefix_for_Data_Frames:"
        Me.lblDataFramePrefix.Text = "Prefix for Data Frames:"
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(337, 131)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(72, 23)
        Me.cmdOptions.TabIndex = 12
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'cmdDetails
        '
        Me.cmdDetails.Location = New System.Drawing.Point(320, 102)
        Me.cmdDetails.Name = "cmdDetails"
        Me.cmdDetails.Size = New System.Drawing.Size(120, 23)
        Me.cmdDetails.TabIndex = 4
        Me.cmdDetails.Tag = "Show_Details"
        Me.cmdDetails.Text = "Show Details >>"
        Me.cmdDetails.UseVisualStyleBackColor = True
        '
        'rdoShort
        '
        Me.rdoShort.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoShort.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoShort.FlatAppearance.BorderSize = 2
        Me.rdoShort.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoShort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoShort.Location = New System.Drawing.Point(531, 11)
        Me.rdoShort.Name = "rdoShort"
        Me.rdoShort.Size = New System.Drawing.Size(76, 27)
        Me.rdoShort.TabIndex = 6
        Me.rdoShort.TabStop = True
        Me.rdoShort.Text = "Short"
        Me.rdoShort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoShort.UseVisualStyleBackColor = True
        '
        'rdoMedium
        '
        Me.rdoMedium.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMedium.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMedium.FlatAppearance.BorderSize = 2
        Me.rdoMedium.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMedium.Location = New System.Drawing.Point(613, 11)
        Me.rdoMedium.Name = "rdoMedium"
        Me.rdoMedium.Size = New System.Drawing.Size(76, 27)
        Me.rdoMedium.TabIndex = 7
        Me.rdoMedium.TabStop = True
        Me.rdoMedium.Text = "Medium"
        Me.rdoMedium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMedium.UseVisualStyleBackColor = True
        '
        'rdoLong
        '
        Me.rdoLong.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoLong.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLong.FlatAppearance.BorderSize = 2
        Me.rdoLong.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLong.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoLong.Location = New System.Drawing.Point(695, 10)
        Me.rdoLong.Name = "rdoLong"
        Me.rdoLong.Size = New System.Drawing.Size(76, 27)
        Me.rdoLong.TabIndex = 8
        Me.rdoLong.TabStop = True
        Me.rdoLong.Text = "Long"
        Me.rdoLong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoLong.UseVisualStyleBackColor = True
        '
        'cmdFromLibrary
        '
        Me.cmdFromLibrary.Location = New System.Drawing.Point(320, 73)
        Me.cmdFromLibrary.Name = "cmdFromLibrary"
        Me.cmdFromLibrary.Size = New System.Drawing.Size(120, 23)
        Me.cmdFromLibrary.TabIndex = 3
        Me.cmdFromLibrary.Tag = "Browse"
        Me.cmdFromLibrary.Text = "From Library"
        Me.cmdFromLibrary.UseVisualStyleBackColor = True
        '
        'cmdBrowseFolder
        '
        Me.cmdBrowseFolder.Location = New System.Drawing.Point(320, 46)
        Me.cmdBrowseFolder.Name = "cmdBrowseFolder"
        Me.cmdBrowseFolder.Size = New System.Drawing.Size(120, 23)
        Me.cmdBrowseFolder.TabIndex = 14
        Me.cmdBrowseFolder.Tag = ""
        Me.cmdBrowseFolder.Text = "Browse Folder"
        Me.cmdBrowseFolder.UseVisualStyleBackColor = True
        '
        'lblNFiles
        '
        Me.lblNFiles.AutoSize = True
        Me.lblNFiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNFiles.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblNFiles.Location = New System.Drawing.Point(43, 51)
        Me.lblNFiles.Name = "lblNFiles"
        Me.lblNFiles.Size = New System.Drawing.Size(0, 13)
        Me.lblNFiles.TabIndex = 15
        '
        'lblFilesFound
        '
        Me.lblFilesFound.AutoSize = True
        Me.lblFilesFound.Location = New System.Drawing.Point(83, 51)
        Me.lblFilesFound.Name = "lblFilesFound"
        Me.lblFilesFound.Size = New System.Drawing.Size(116, 13)
        Me.lblFilesFound.TabIndex = 16
        Me.lblFilesFound.Text = ".nc files found to import"
        '
        'ucrInputFileDetails
        '
        Me.ucrInputFileDetails.AddQuotesIfUnrecognised = True
        Me.ucrInputFileDetails.AutoSize = True
        Me.ucrInputFileDetails.IsMultiline = True
        Me.ucrInputFileDetails.IsReadOnly = True
        Me.ucrInputFileDetails.Location = New System.Drawing.Point(489, 47)
        Me.ucrInputFileDetails.Name = "ucrInputFileDetails"
        Me.ucrInputFileDetails.Size = New System.Drawing.Size(320, 159)
        Me.ucrInputFileDetails.TabIndex = 9
        '
        'ucrInputPath
        '
        Me.ucrInputPath.AddQuotesIfUnrecognised = True
        Me.ucrInputPath.AutoSize = True
        Me.ucrInputPath.IsMultiline = False
        Me.ucrInputPath.IsReadOnly = False
        Me.ucrInputPath.Location = New System.Drawing.Point(58, 20)
        Me.ucrInputPath.Name = "ucrInputPath"
        Me.ucrInputPath.Size = New System.Drawing.Size(256, 21)
        Me.ucrInputPath.TabIndex = 1
        '
        'ucrInputDataName
        '
        Me.ucrInputDataName.AddQuotesIfUnrecognised = True
        Me.ucrInputDataName.AutoSize = True
        Me.ucrInputDataName.IsMultiline = False
        Me.ucrInputDataName.IsReadOnly = False
        Me.ucrInputDataName.Location = New System.Drawing.Point(187, 133)
        Me.ucrInputDataName.Name = "ucrInputDataName"
        Me.ucrInputDataName.Size = New System.Drawing.Size(149, 21)
        Me.ucrInputDataName.TabIndex = 11
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(5, 161)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 13
        '
        'ucrPnlFileDetails
        '
        Me.ucrPnlFileDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlFileDetails.Location = New System.Drawing.Point(547, 11)
        Me.ucrPnlFileDetails.Name = "ucrPnlFileDetails"
        Me.ucrPnlFileDetails.Size = New System.Drawing.Size(254, 30)
        Me.ucrPnlFileDetails.TabIndex = 0
        Me.ucrPnlFileDetails.TabStop = False
        '
        'dlgOpenNetCDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(821, 217)
        Me.Controls.Add(Me.lblFilesFound)
        Me.Controls.Add(Me.lblNFiles)
        Me.Controls.Add(Me.cmdBrowseFolder)
        Me.Controls.Add(Me.cmdFromLibrary)
        Me.Controls.Add(Me.rdoLong)
        Me.Controls.Add(Me.rdoMedium)
        Me.Controls.Add(Me.rdoShort)
        Me.Controls.Add(Me.ucrInputFileDetails)
        Me.Controls.Add(Me.cmdDetails)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrInputPath)
        Me.Controls.Add(Me.ucrInputDataName)
        Me.Controls.Add(Me.cmdBrowseFile)
        Me.Controls.Add(Me.lblFileFolderPath)
        Me.Controls.Add(Me.lblDataFramePrefix)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlFileDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOpenNetCDF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import NetCDF File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInputPath As ucrInputTextBox
    Friend WithEvents ucrInputDataName As ucrInputTextBox
    Friend WithEvents cmdBrowseFile As Button
    Friend WithEvents lblFileFolderPath As Label
    Friend WithEvents lblDataFramePrefix As Label
    Friend WithEvents cmdOptions As Button
    Friend WithEvents cmdDetails As Button
    Friend WithEvents ucrInputFileDetails As ucrInputTextBox
    Friend WithEvents rdoShort As RadioButton
    Friend WithEvents rdoMedium As RadioButton
    Friend WithEvents rdoLong As RadioButton
    Friend WithEvents ucrPnlFileDetails As UcrPanel
    Friend WithEvents cmdFromLibrary As Button
    Friend WithEvents cmdBrowseFolder As Button
    Friend WithEvents lblNFiles As Label
    Friend WithEvents lblFilesFound As Label
End Class

