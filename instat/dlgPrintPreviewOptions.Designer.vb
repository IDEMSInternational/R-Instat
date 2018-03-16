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
Partial Class dlgPrintPreviewOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgPrintPreviewOptions))
        Me.pnlEditor = New System.Windows.Forms.Panel()
        Me.chkGridLines = New System.Windows.Forms.CheckBox()
        Me.cmdPrtSheet = New System.Windows.Forms.Button()
        Me.cmdPrevSheet = New System.Windows.Forms.Button()
        Me.pnlLog = New System.Windows.Forms.Panel()
        Me.cmdPrtLog = New System.Windows.Forms.Button()
        Me.cmdPrevLog = New System.Windows.Forms.Button()
        Me.pnlOutput = New System.Windows.Forms.Panel()
        Me.cmdPrtOutput = New System.Windows.Forms.Button()
        Me.cmdPrevOutput = New System.Windows.Forms.Button()
        Me.cmdExitPreview = New System.Windows.Forms.Button()
        Me.pnlEditor.SuspendLayout()
        Me.pnlLog.SuspendLayout()
        Me.pnlOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlEditor
        '
        resources.ApplyResources(Me.pnlEditor, "pnlEditor")
        Me.pnlEditor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlEditor.Controls.Add(Me.chkGridLines)
        Me.pnlEditor.Controls.Add(Me.cmdPrtSheet)
        Me.pnlEditor.Controls.Add(Me.cmdPrevSheet)
        Me.pnlEditor.Name = "pnlEditor"
        '
        'chkGridLines
        '
        resources.ApplyResources(Me.chkGridLines, "chkGridLines")
        Me.chkGridLines.Name = "chkGridLines"
        Me.chkGridLines.UseVisualStyleBackColor = True
        '
        'cmdPrtSheet
        '
        resources.ApplyResources(Me.cmdPrtSheet, "cmdPrtSheet")
        Me.cmdPrtSheet.Name = "cmdPrtSheet"
        Me.cmdPrtSheet.UseVisualStyleBackColor = True
        '
        'cmdPrevSheet
        '
        resources.ApplyResources(Me.cmdPrevSheet, "cmdPrevSheet")
        Me.cmdPrevSheet.Name = "cmdPrevSheet"
        Me.cmdPrevSheet.UseVisualStyleBackColor = True
        '
        'pnlLog
        '
        resources.ApplyResources(Me.pnlLog, "pnlLog")
        Me.pnlLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlLog.Controls.Add(Me.cmdPrtLog)
        Me.pnlLog.Controls.Add(Me.cmdPrevLog)
        Me.pnlLog.Name = "pnlLog"
        '
        'cmdPrtLog
        '
        resources.ApplyResources(Me.cmdPrtLog, "cmdPrtLog")
        Me.cmdPrtLog.Name = "cmdPrtLog"
        Me.cmdPrtLog.UseVisualStyleBackColor = True
        '
        'cmdPrevLog
        '
        resources.ApplyResources(Me.cmdPrevLog, "cmdPrevLog")
        Me.cmdPrevLog.Name = "cmdPrevLog"
        Me.cmdPrevLog.UseVisualStyleBackColor = True
        '
        'pnlOutput
        '
        resources.ApplyResources(Me.pnlOutput, "pnlOutput")
        Me.pnlOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlOutput.Controls.Add(Me.cmdPrtOutput)
        Me.pnlOutput.Controls.Add(Me.cmdPrevOutput)
        Me.pnlOutput.Name = "pnlOutput"
        '
        'cmdPrtOutput
        '
        resources.ApplyResources(Me.cmdPrtOutput, "cmdPrtOutput")
        Me.cmdPrtOutput.Name = "cmdPrtOutput"
        Me.cmdPrtOutput.UseVisualStyleBackColor = True
        '
        'cmdPrevOutput
        '
        resources.ApplyResources(Me.cmdPrevOutput, "cmdPrevOutput")
        Me.cmdPrevOutput.Name = "cmdPrevOutput"
        Me.cmdPrevOutput.UseVisualStyleBackColor = True
        '
        'cmdExitPreview
        '
        resources.ApplyResources(Me.cmdExitPreview, "cmdExitPreview")
        Me.cmdExitPreview.Name = "cmdExitPreview"
        Me.cmdExitPreview.UseVisualStyleBackColor = True
        '
        'dlgPrintPreviewOptions
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdExitPreview)
        Me.Controls.Add(Me.pnlOutput)
        Me.Controls.Add(Me.pnlLog)
        Me.Controls.Add(Me.pnlEditor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPrintPreviewOptions"
        Me.pnlEditor.ResumeLayout(False)
        Me.pnlEditor.PerformLayout()
        Me.pnlLog.ResumeLayout(False)
        Me.pnlOutput.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlEditor As Panel
    Friend WithEvents cmdPrtSheet As Button
    Friend WithEvents cmdPrevSheet As Button
    Friend WithEvents pnlLog As Panel
    Friend WithEvents cmdPrtLog As Button
    Friend WithEvents cmdPrevLog As Button
    Friend WithEvents pnlOutput As Panel
    Friend WithEvents cmdPrtOutput As Button
    Friend WithEvents cmdPrevOutput As Button
    Friend WithEvents cmdExitPreview As Button
    Friend WithEvents chkGridLines As CheckBox
End Class
