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
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.lblExport = New System.Windows.Forms.Label()
        Me.lblDataFrames = New System.Windows.Forms.Label()
        Me.lblSelectedDataFrames = New System.Windows.Forms.Label()
        Me.ucrSelectorForDataFrames = New instat.ucrSelectorAddRemove()
        Me.ucrInputExportFile = New instat.ucrInputTextBox()
        Me.ucrChkGraphs = New instat.ucrCheck()
        Me.ucrChkModels = New instat.ucrCheck()
        Me.ucrChkMetadata = New instat.ucrCheck()
        Me.ucrReceiverMultiple = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(346, 249)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(62, 23)
        Me.cmdBrowse.TabIndex = 9
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'lblExport
        '
        Me.lblExport.AutoSize = True
        Me.lblExport.Location = New System.Drawing.Point(10, 255)
        Me.lblExport.Name = "lblExport"
        Me.lblExport.Size = New System.Drawing.Size(59, 13)
        Me.lblExport.TabIndex = 7
        Me.lblExport.Text = "Export File:"
        '
        'lblDataFrames
        '
        Me.lblDataFrames.AutoSize = True
        Me.lblDataFrames.Location = New System.Drawing.Point(10, 13)
        Me.lblDataFrames.Name = "lblDataFrames"
        Me.lblDataFrames.Size = New System.Drawing.Size(76, 13)
        Me.lblDataFrames.TabIndex = 0
        Me.lblDataFrames.Text = "Data Frame(s):"
        '
        'lblSelectedDataFrames
        '
        Me.lblSelectedDataFrames.AutoSize = True
        Me.lblSelectedDataFrames.Location = New System.Drawing.Point(247, 45)
        Me.lblSelectedDataFrames.Name = "lblSelectedDataFrames"
        Me.lblSelectedDataFrames.Size = New System.Drawing.Size(115, 13)
        Me.lblSelectedDataFrames.TabIndex = 2
        Me.lblSelectedDataFrames.Text = "Selected Data Frames:"
        '
        'ucrSelectorForDataFrames
        '
        Me.ucrSelectorForDataFrames.bShowHiddenColumns = False
        Me.ucrSelectorForDataFrames.Location = New System.Drawing.Point(10, 30)
        Me.ucrSelectorForDataFrames.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForDataFrames.Name = "ucrSelectorForDataFrames"
        Me.ucrSelectorForDataFrames.Size = New System.Drawing.Size(201, 147)
        Me.ucrSelectorForDataFrames.TabIndex = 1
        '
        'ucrInputExportFile
        '
        Me.ucrInputExportFile.AddQuotesIfUnrecognised = True
        Me.ucrInputExportFile.IsMultiline = False
        Me.ucrInputExportFile.IsReadOnly = False
        Me.ucrInputExportFile.Location = New System.Drawing.Point(91, 251)
        Me.ucrInputExportFile.Name = "ucrInputExportFile"
        Me.ucrInputExportFile.Size = New System.Drawing.Size(249, 21)
        Me.ucrInputExportFile.TabIndex = 8
        '
        'ucrChkGraphs
        '
        Me.ucrChkGraphs.Checked = False
        Me.ucrChkGraphs.Location = New System.Drawing.Point(10, 199)
        Me.ucrChkGraphs.Name = "ucrChkGraphs"
        Me.ucrChkGraphs.Size = New System.Drawing.Size(119, 20)
        Me.ucrChkGraphs.TabIndex = 5
        '
        'ucrChkModels
        '
        Me.ucrChkModels.Checked = False
        Me.ucrChkModels.Location = New System.Drawing.Point(10, 225)
        Me.ucrChkModels.Name = "ucrChkModels"
        Me.ucrChkModels.Size = New System.Drawing.Size(128, 20)
        Me.ucrChkModels.TabIndex = 6
        '
        'ucrChkMetadata
        '
        Me.ucrChkMetadata.Checked = False
        Me.ucrChkMetadata.Location = New System.Drawing.Point(10, 173)
        Me.ucrChkMetadata.Name = "ucrChkMetadata"
        Me.ucrChkMetadata.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkMetadata.TabIndex = 4
        '
        'ucrReceiverMultiple
        '
        Me.ucrReceiverMultiple.frmParent = Me
        Me.ucrReceiverMultiple.Location = New System.Drawing.Point(247, 60)
        Me.ucrReceiverMultiple.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultiple.Name = "ucrReceiverMultiple"
        Me.ucrReceiverMultiple.Selector = Nothing
        Me.ucrReceiverMultiple.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultiple.TabIndex = 3
        Me.ucrReceiverMultiple.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 281)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(398, 52)
        Me.ucrBase.TabIndex = 10
        '
        'dlgExportRWorkspace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 338)
        Me.Controls.Add(Me.lblSelectedDataFrames)
        Me.Controls.Add(Me.lblDataFrames)
        Me.Controls.Add(Me.ucrInputExportFile)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.lblExport)
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
    Friend WithEvents ucrInputExportFile As ucrInputTextBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents lblExport As Label
    Friend WithEvents lblDataFrames As Label
    Friend WithEvents lblSelectedDataFrames As Label
    Friend WithEvents ucrSelectorForDataFrames As ucrSelectorAddRemove
End Class
