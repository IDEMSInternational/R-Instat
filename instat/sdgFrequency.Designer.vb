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
Partial Class sdgFrequency
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
        Me.ucrBaseSubDialog = New instat.ucrButtonsSubdialogue()
        Me.ucrPnlDisplayType = New instat.UcrPanel()
        Me.rdoHorizontally = New System.Windows.Forms.RadioButton()
        Me.rdoVertically = New System.Windows.Forms.RadioButton()
        Me.rdoSeparateTables = New System.Windows.Forms.RadioButton()
        Me.ucrchkMargins = New instat.ucrCheck()
        Me.ucrchkDisplay = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'ucrBaseSubDialog
        '
        Me.ucrBaseSubDialog.Location = New System.Drawing.Point(62, 178)
        Me.ucrBaseSubDialog.Name = "ucrBaseSubDialog"
        Me.ucrBaseSubDialog.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSubDialog.TabIndex = 7
        '
        'ucrPnlDisplayType
        '
        Me.ucrPnlDisplayType.Location = New System.Drawing.Point(163, 61)
        Me.ucrPnlDisplayType.Name = "ucrPnlDisplayType"
        Me.ucrPnlDisplayType.Size = New System.Drawing.Size(114, 90)
        Me.ucrPnlDisplayType.TabIndex = 53
        '
        'rdoHorizontally
        '
        Me.rdoHorizontally.AutoSize = True
        Me.rdoHorizontally.Location = New System.Drawing.Point(170, 113)
        Me.rdoHorizontally.Name = "rdoHorizontally"
        Me.rdoHorizontally.Size = New System.Drawing.Size(79, 17)
        Me.rdoHorizontally.TabIndex = 63
        Me.rdoHorizontally.TabStop = True
        Me.rdoHorizontally.Text = "Horizontally"
        Me.rdoHorizontally.UseVisualStyleBackColor = True
        '
        'rdoVertically
        '
        Me.rdoVertically.AutoSize = True
        Me.rdoVertically.Location = New System.Drawing.Point(170, 89)
        Me.rdoVertically.Name = "rdoVertically"
        Me.rdoVertically.Size = New System.Drawing.Size(67, 17)
        Me.rdoVertically.TabIndex = 62
        Me.rdoVertically.TabStop = True
        Me.rdoVertically.Text = "Vertically"
        Me.rdoVertically.UseVisualStyleBackColor = True
        '
        'rdoSeparateTables
        '
        Me.rdoSeparateTables.AutoSize = True
        Me.rdoSeparateTables.Location = New System.Drawing.Point(170, 65)
        Me.rdoSeparateTables.Name = "rdoSeparateTables"
        Me.rdoSeparateTables.Size = New System.Drawing.Size(103, 17)
        Me.rdoSeparateTables.TabIndex = 61
        Me.rdoSeparateTables.TabStop = True
        Me.rdoSeparateTables.Text = "Separate Tables"
        Me.rdoSeparateTables.UseVisualStyleBackColor = True
        '
        'ucrchkMargins
        '
        Me.ucrchkMargins.Checked = False
        Me.ucrchkMargins.Location = New System.Drawing.Point(12, 89)
        Me.ucrchkMargins.Name = "ucrchkMargins"
        Me.ucrchkMargins.Size = New System.Drawing.Size(131, 20)
        Me.ucrchkMargins.TabIndex = 65
        '
        'ucrchkDisplay
        '
        Me.ucrchkDisplay.Checked = False
        Me.ucrchkDisplay.Location = New System.Drawing.Point(12, 63)
        Me.ucrchkDisplay.Name = "ucrchkDisplay"
        Me.ucrchkDisplay.Size = New System.Drawing.Size(131, 20)
        Me.ucrchkDisplay.TabIndex = 64
        '
        'sdgFrequency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 208)
        Me.Controls.Add(Me.ucrchkMargins)
        Me.Controls.Add(Me.ucrchkDisplay)
        Me.Controls.Add(Me.rdoHorizontally)
        Me.Controls.Add(Me.rdoVertically)
        Me.Controls.Add(Me.rdoSeparateTables)
        Me.Controls.Add(Me.ucrBaseSubDialog)
        Me.Controls.Add(Me.ucrPnlDisplayType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgFrequency"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frequency"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSubDialog As ucrButtonsSubdialogue
    Friend WithEvents ucrPnlDisplayType As UcrPanel
    Friend WithEvents rdoHorizontally As RadioButton
    Friend WithEvents rdoVertically As RadioButton
    Friend WithEvents rdoSeparateTables As RadioButton
    Friend WithEvents ucrchkMargins As ucrCheck
    Friend WithEvents ucrchkDisplay As ucrCheck
End Class
