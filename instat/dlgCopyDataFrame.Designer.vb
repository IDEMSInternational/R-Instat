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
        Me.lblLabel.AutoSize = True
        Me.lblLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLabel.Location = New System.Drawing.Point(251, 76)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(94, 13)
        Me.lblLabel.TabIndex = 3
        Me.lblLabel.Text = "Data Frame Label:"
        '
        'lblNewName
        '
        Me.lblNewName.AutoSize = True
        Me.lblNewName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNewName.Location = New System.Drawing.Point(251, 16)
        Me.lblNewName.Name = "lblNewName"
        Me.lblNewName.Size = New System.Drawing.Size(63, 13)
        Me.lblNewName.TabIndex = 1
        Me.lblNewName.Tag = "New_Name"
        Me.lblNewName.Text = "New Name:"
        '
        'ucrChkCopyToClipboard
        '
        Me.ucrChkCopyToClipboard.AutoSize = True
        Me.ucrChkCopyToClipboard.Checked = False
        Me.ucrChkCopyToClipboard.Location = New System.Drawing.Point(10, 76)
        Me.ucrChkCopyToClipboard.Name = "ucrChkCopyToClipboard"
        Me.ucrChkCopyToClipboard.Size = New System.Drawing.Size(207, 23)
        Me.ucrChkCopyToClipboard.TabIndex = 6
        '
        'ucrInputLabel
        '
        Me.ucrInputLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputLabel.AutoSize = True
        Me.ucrInputLabel.IsMultiline = False
        Me.ucrInputLabel.IsReadOnly = False
        Me.ucrInputLabel.Location = New System.Drawing.Point(251, 92)
        Me.ucrInputLabel.Name = "ucrInputLabel"
        Me.ucrInputLabel.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLabel.TabIndex = 4
        '
        'ucrInputNewDataFrameName
        '
        Me.ucrInputNewDataFrameName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewDataFrameName.AutoSize = True
        Me.ucrInputNewDataFrameName.IsMultiline = False
        Me.ucrInputNewDataFrameName.IsReadOnly = False
        Me.ucrInputNewDataFrameName.Location = New System.Drawing.Point(251, 32)
        Me.ucrInputNewDataFrameName.Name = "ucrInputNewDataFrameName"
        Me.ucrInputNewDataFrameName.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputNewDataFrameName.TabIndex = 2
        '
        'ucrDataFrameCopySheets
        '
        Me.ucrDataFrameCopySheets.AutoSize = True
        Me.ucrDataFrameCopySheets.bDropUnusedFilterLevels = False
        Me.ucrDataFrameCopySheets.bUseCurrentFilter = True
        Me.ucrDataFrameCopySheets.Location = New System.Drawing.Point(10, 12)
        Me.ucrDataFrameCopySheets.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameCopySheets.Name = "ucrDataFrameCopySheets"
        Me.ucrDataFrameCopySheets.Size = New System.Drawing.Size(151, 50)
        Me.ucrDataFrameCopySheets.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(11, 192)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 5
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(10, 98)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(235, 77)
        Me.ucrPnlOptions.TabIndex = 10
        '
        'rdoDataFrameMetadata
        '
        Me.rdoDataFrameMetadata.AutoSize = True
        Me.rdoDataFrameMetadata.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDataFrameMetadata.Location = New System.Drawing.Point(32, 148)
        Me.rdoDataFrameMetadata.Name = "rdoDataFrameMetadata"
        Me.rdoDataFrameMetadata.Size = New System.Drawing.Size(124, 17)
        Me.rdoDataFrameMetadata.TabIndex = 15
        Me.rdoDataFrameMetadata.TabStop = True
        Me.rdoDataFrameMetadata.Text = "Data frame metadata"
        Me.rdoDataFrameMetadata.UseVisualStyleBackColor = True
        '
        'rdoColumnsMetadata
        '
        Me.rdoColumnsMetadata.AutoSize = True
        Me.rdoColumnsMetadata.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoColumnsMetadata.Location = New System.Drawing.Point(32, 125)
        Me.rdoColumnsMetadata.Name = "rdoColumnsMetadata"
        Me.rdoColumnsMetadata.Size = New System.Drawing.Size(112, 17)
        Me.rdoColumnsMetadata.TabIndex = 14
        Me.rdoColumnsMetadata.TabStop = True
        Me.rdoColumnsMetadata.Text = "Columns metadata"
        Me.rdoColumnsMetadata.UseVisualStyleBackColor = True
        '
        'rdoDataFrame
        '
        Me.rdoDataFrame.AutoSize = True
        Me.rdoDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDataFrame.Location = New System.Drawing.Point(32, 102)
        Me.rdoDataFrame.Name = "rdoDataFrame"
        Me.rdoDataFrame.Size = New System.Drawing.Size(77, 17)
        Me.rdoDataFrame.TabIndex = 13
        Me.rdoDataFrame.TabStop = True
        Me.rdoDataFrame.Text = "Data frame"
        Me.rdoDataFrame.UseVisualStyleBackColor = True
        '
        'dlgCopyDataFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(424, 254)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Copy Data Frame"
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
