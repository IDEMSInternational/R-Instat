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
        Me.lblObjects = New System.Windows.Forms.Label()
        Me.ucrReceiverObjects = New instat.ucrReceiverMultiple()
        Me.ucrSelectorObjects = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputExportFile = New instat.ucrInputTextBox()
        Me.lblExportFile = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblObjects
        '
        Me.lblObjects.AutoSize = True
        Me.lblObjects.Location = New System.Drawing.Point(264, 45)
        Me.lblObjects.Name = "lblObjects"
        Me.lblObjects.Size = New System.Drawing.Size(91, 13)
        Me.lblObjects.TabIndex = 1
        Me.lblObjects.Text = "Selected Objects:"
        '
        'ucrReceiverObjects
        '
        Me.ucrReceiverObjects.frmParent = Me
        Me.ucrReceiverObjects.Location = New System.Drawing.Point(264, 60)
        Me.ucrReceiverObjects.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverObjects.Name = "ucrReceiverObjects"
        Me.ucrReceiverObjects.Selector = Nothing
        Me.ucrReceiverObjects.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverObjects.TabIndex = 2
        Me.ucrReceiverObjects.ucrSelector = Nothing
        '
        'ucrSelectorObjects
        '
        Me.ucrSelectorObjects.bShowHiddenColumns = False
        Me.ucrSelectorObjects.bUseCurrentFilter = True
        Me.ucrSelectorObjects.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorObjects.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorObjects.Name = "ucrSelectorObjects"
        Me.ucrSelectorObjects.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorObjects.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 232)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(398, 52)
        Me.ucrBase.TabIndex = 6
        '
        'ucrInputExportFile
        '
        Me.ucrInputExportFile.AddQuotesIfUnrecognised = True
        Me.ucrInputExportFile.IsMultiline = False
        Me.ucrInputExportFile.IsReadOnly = False
        Me.ucrInputExportFile.Location = New System.Drawing.Point(91, 205)
        Me.ucrInputExportFile.Name = "ucrInputExportFile"
        Me.ucrInputExportFile.Size = New System.Drawing.Size(251, 21)
        Me.ucrInputExportFile.TabIndex = 4
        '
        'lblExportFile
        '
        Me.lblExportFile.AutoSize = True
        Me.lblExportFile.Location = New System.Drawing.Point(10, 207)
        Me.lblExportFile.Name = "lblExportFile"
        Me.lblExportFile.Size = New System.Drawing.Size(59, 13)
        Me.lblExportFile.TabIndex = 3
        Me.lblExportFile.Text = "Export File:"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(346, 203)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(62, 23)
        Me.cmdBrowse.TabIndex = 5
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'dlgExportRObjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 288)
        Me.Controls.Add(Me.ucrInputExportFile)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.lblExportFile)
        Me.Controls.Add(Me.lblObjects)
        Me.Controls.Add(Me.ucrReceiverObjects)
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
    Friend WithEvents ucrReceiverObjects As ucrReceiverMultiple
    Friend WithEvents lblObjects As Label
    Friend WithEvents ucrInputExportFile As ucrInputTextBox
    Friend WithEvents lblExportFile As Label
    Friend WithEvents cmdBrowse As Button
End Class
