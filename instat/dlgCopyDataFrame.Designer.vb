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
Partial Class dlgCopyDataFrame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgCopyDataFrame))
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.lblNewName = New System.Windows.Forms.Label()
        Me.ucrChkCopyToClipboard = New instat.ucrCheck()
        Me.ucrInputLabel = New instat.ucrInputTextBox()
        Me.ucrInputNewDataFrameName = New instat.ucrInputTextBox()
        Me.ucrDataFrameCopySheets = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.rdoDataFrameMetadata = New System.Windows.Forms.RadioButton()
        Me.rdoColumnsMetadata = New System.Windows.Forms.RadioButton()
        Me.rdoDataFrame = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblLabel
        '
        resources.ApplyResources(Me.lblLabel, "lblLabel")
        Me.lblLabel.Name = "lblLabel"
        '
        'lblNewName
        '
        resources.ApplyResources(Me.lblNewName, "lblNewName")
        Me.lblNewName.Name = "lblNewName"
        Me.lblNewName.Tag = "New_Name"
        '
        'ucrChkCopyToClipboard
        '
        Me.ucrChkCopyToClipboard.Checked = False
        resources.ApplyResources(Me.ucrChkCopyToClipboard, "ucrChkCopyToClipboard")
        Me.ucrChkCopyToClipboard.Name = "ucrChkCopyToClipboard"
        '
        'ucrInputLabel
        '
        Me.ucrInputLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputLabel.IsMultiline = False
        Me.ucrInputLabel.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLabel, "ucrInputLabel")
        Me.ucrInputLabel.Name = "ucrInputLabel"
        '
        'ucrInputNewDataFrameName
        '
        Me.ucrInputNewDataFrameName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewDataFrameName.IsMultiline = False
        Me.ucrInputNewDataFrameName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputNewDataFrameName, "ucrInputNewDataFrameName")
        Me.ucrInputNewDataFrameName.Name = "ucrInputNewDataFrameName"
        '
        'ucrDataFrameCopySheets
        '
        Me.ucrDataFrameCopySheets.bDropUnusedFilterLevels = False
        Me.ucrDataFrameCopySheets.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrDataFrameCopySheets, "ucrDataFrameCopySheets")
        Me.ucrDataFrameCopySheets.Name = "ucrDataFrameCopySheets"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrPnlOptions
        '
        resources.ApplyResources(Me.ucrPnlOptions, "ucrPnlOptions")
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        '
        'rdoDataFrameMetadata
        '
        resources.ApplyResources(Me.rdoDataFrameMetadata, "rdoDataFrameMetadata")
        Me.rdoDataFrameMetadata.Name = "rdoDataFrameMetadata"
        Me.rdoDataFrameMetadata.TabStop = True
        Me.rdoDataFrameMetadata.UseVisualStyleBackColor = True
        '
        'rdoColumnsMetadata
        '
        resources.ApplyResources(Me.rdoColumnsMetadata, "rdoColumnsMetadata")
        Me.rdoColumnsMetadata.Name = "rdoColumnsMetadata"
        Me.rdoColumnsMetadata.TabStop = True
        Me.rdoColumnsMetadata.UseVisualStyleBackColor = True
        '
        'rdoDataFrame
        '
        resources.ApplyResources(Me.rdoDataFrame, "rdoDataFrame")
        Me.rdoDataFrame.Name = "rdoDataFrame"
        Me.rdoDataFrame.TabStop = True
        Me.rdoDataFrame.UseVisualStyleBackColor = True
        '
        'dlgCopyDataFrame
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rdoDataFrameMetadata)
        Me.Controls.Add(Me.rdoColumnsMetadata)
        Me.Controls.Add(Me.rdoDataFrame)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrChkCopyToClipboard)
        Me.Controls.Add(Me.ucrInputLabel)
        Me.Controls.Add(Me.lblLabel)
        Me.Controls.Add(Me.ucrInputNewDataFrameName)
        Me.Controls.Add(Me.lblNewName)
        Me.Controls.Add(Me.ucrDataFrameCopySheets)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCopyDataFrame"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrameCopySheets As ucrDataFrame
    Friend WithEvents ucrInputLabel As ucrInputTextBox
    Friend WithEvents lblLabel As Label
    Friend WithEvents ucrInputNewDataFrameName As ucrInputTextBox
    Friend WithEvents lblNewName As Label
    Friend WithEvents ucrChkCopyToClipboard As ucrCheck
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents rdoDataFrameMetadata As RadioButton
    Friend WithEvents rdoColumnsMetadata As RadioButton
    Friend WithEvents rdoDataFrame As RadioButton
End Class
