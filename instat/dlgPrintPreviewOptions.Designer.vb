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
        Me.pnlEditor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlEditor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlEditor.Controls.Add(Me.chkGridLines)
        Me.pnlEditor.Controls.Add(Me.cmdPrtSheet)
        Me.pnlEditor.Controls.Add(Me.cmdPrevSheet)
        Me.pnlEditor.Location = New System.Drawing.Point(2, 4)
        Me.pnlEditor.Name = "pnlEditor"
        Me.pnlEditor.Size = New System.Drawing.Size(160, 128)
        Me.pnlEditor.TabIndex = 0
        '
        'chkGridLines
        '
        Me.chkGridLines.AutoSize = True
        Me.chkGridLines.Location = New System.Drawing.Point(3, 48)
        Me.chkGridLines.Name = "chkGridLines"
        Me.chkGridLines.Size = New System.Drawing.Size(97, 17)
        Me.chkGridLines.TabIndex = 2
        Me.chkGridLines.Text = "Show grid lines"
        Me.chkGridLines.UseVisualStyleBackColor = True
        '
        'cmdPrtSheet
        '
        Me.cmdPrtSheet.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdPrtSheet.Location = New System.Drawing.Point(0, 80)
        Me.cmdPrtSheet.Name = "cmdPrtSheet"
        Me.cmdPrtSheet.Size = New System.Drawing.Size(156, 44)
        Me.cmdPrtSheet.TabIndex = 1
        Me.cmdPrtSheet.Text = "Print Current Sheet"
        Me.cmdPrtSheet.UseVisualStyleBackColor = True
        '
        'cmdPrevSheet
        '
        Me.cmdPrevSheet.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdPrevSheet.Location = New System.Drawing.Point(0, 0)
        Me.cmdPrevSheet.Name = "cmdPrevSheet"
        Me.cmdPrevSheet.Size = New System.Drawing.Size(156, 42)
        Me.cmdPrevSheet.TabIndex = 0
        Me.cmdPrevSheet.Text = "Preview Current Sheet"
        Me.cmdPrevSheet.UseVisualStyleBackColor = True
        '
        'pnlLog
        '
        Me.pnlLog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlLog.Controls.Add(Me.cmdPrtLog)
        Me.pnlLog.Controls.Add(Me.cmdPrevLog)
        Me.pnlLog.Location = New System.Drawing.Point(168, 4)
        Me.pnlLog.Name = "pnlLog"
        Me.pnlLog.Size = New System.Drawing.Size(160, 92)
        Me.pnlLog.TabIndex = 1
        '
        'cmdPrtLog
        '
        Me.cmdPrtLog.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdPrtLog.Location = New System.Drawing.Point(0, 44)
        Me.cmdPrtLog.Name = "cmdPrtLog"
        Me.cmdPrtLog.Size = New System.Drawing.Size(156, 44)
        Me.cmdPrtLog.TabIndex = 1
        Me.cmdPrtLog.Text = "Print Log"
        Me.cmdPrtLog.UseVisualStyleBackColor = True
        '
        'cmdPrevLog
        '
        Me.cmdPrevLog.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdPrevLog.Location = New System.Drawing.Point(0, 0)
        Me.cmdPrevLog.Name = "cmdPrevLog"
        Me.cmdPrevLog.Size = New System.Drawing.Size(156, 42)
        Me.cmdPrevLog.TabIndex = 0
        Me.cmdPrevLog.Text = "Preview Log"
        Me.cmdPrevLog.UseVisualStyleBackColor = True
        '
        'pnlOutput
        '
        Me.pnlOutput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlOutput.Controls.Add(Me.cmdPrtOutput)
        Me.pnlOutput.Controls.Add(Me.cmdPrevOutput)
        Me.pnlOutput.Location = New System.Drawing.Point(332, 6)
        Me.pnlOutput.Name = "pnlOutput"
        Me.pnlOutput.Size = New System.Drawing.Size(160, 92)
        Me.pnlOutput.TabIndex = 2
        '
        'cmdPrtOutput
        '
        Me.cmdPrtOutput.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdPrtOutput.Location = New System.Drawing.Point(0, 44)
        Me.cmdPrtOutput.Name = "cmdPrtOutput"
        Me.cmdPrtOutput.Size = New System.Drawing.Size(156, 44)
        Me.cmdPrtOutput.TabIndex = 1
        Me.cmdPrtOutput.Text = "Print Output"
        Me.cmdPrtOutput.UseVisualStyleBackColor = True
        '
        'cmdPrevOutput
        '
        Me.cmdPrevOutput.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdPrevOutput.Location = New System.Drawing.Point(0, 0)
        Me.cmdPrevOutput.Name = "cmdPrevOutput"
        Me.cmdPrevOutput.Size = New System.Drawing.Size(156, 42)
        Me.cmdPrevOutput.TabIndex = 0
        Me.cmdPrevOutput.Text = "Preview Output"
        Me.cmdPrevOutput.UseVisualStyleBackColor = True
        '
        'cmdExitPreview
        '
        Me.cmdExitPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExitPreview.Location = New System.Drawing.Point(168, 99)
        Me.cmdExitPreview.Name = "cmdExitPreview"
        Me.cmdExitPreview.Size = New System.Drawing.Size(160, 32)
        Me.cmdExitPreview.TabIndex = 3
        Me.cmdExitPreview.Text = "Exit Preview and Print"
        Me.cmdExitPreview.UseVisualStyleBackColor = True
        '
        'dlgPrintPreviewOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 144)
        Me.Controls.Add(Me.cmdExitPreview)
        Me.Controls.Add(Me.pnlOutput)
        Me.Controls.Add(Me.pnlLog)
        Me.Controls.Add(Me.pnlEditor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPrintPreviewOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print and Preview Options"
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
