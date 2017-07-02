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
Partial Class dlgOutputforCDT
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
        Me.ucrBase = New instat.ucrButtons()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFilename = New System.Windows.Forms.Label()
        Me.lblInterestedVariables = New System.Windows.Forms.Label()
        Me.ucrInputFileName = New instat.ucrInputTextBox()
        Me.ucrInputInterestedVariables = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 83)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 56)
        Me.ucrBase.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data list not implemented"
        '
        'lblFilename
        '
        Me.lblFilename.AutoSize = True
        Me.lblFilename.Location = New System.Drawing.Point(21, 37)
        Me.lblFilename.Name = "lblFilename"
        Me.lblFilename.Size = New System.Drawing.Size(54, 13)
        Me.lblFilename.TabIndex = 2
        Me.lblFilename.Tag = "Filename"
        Me.lblFilename.Text = "File Name"
        '
        'lblInterestedVariables
        '
        Me.lblInterestedVariables.AutoSize = True
        Me.lblInterestedVariables.Location = New System.Drawing.Point(12, 64)
        Me.lblInterestedVariables.Name = "lblInterestedVariables"
        Me.lblInterestedVariables.Size = New System.Drawing.Size(100, 13)
        Me.lblInterestedVariables.TabIndex = 3
        Me.lblInterestedVariables.Tag = "Interested_Variables"
        Me.lblInterestedVariables.Text = "Interested Variables"
        '
        'ucrInputFileName
        '
        Me.ucrInputFileName.Location = New System.Drawing.Point(133, 25)
        Me.ucrInputFileName.Name = "ucrInputFileName"
        Me.ucrInputFileName.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputFileName.TabIndex = 6
        '
        'ucrInputInterestedVariables
        '
        Me.ucrInputInterestedVariables.Location = New System.Drawing.Point(133, 56)
        Me.ucrInputInterestedVariables.Name = "ucrInputInterestedVariables"
        Me.ucrInputInterestedVariables.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputInterestedVariables.TabIndex = 6
        '
        'dlgOutputforCDT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 147)
        Me.Controls.Add(Me.ucrInputInterestedVariables)
        Me.Controls.Add(Me.ucrInputFileName)
        Me.Controls.Add(Me.lblInterestedVariables)
        Me.Controls.Add(Me.lblFilename)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOutputforCDT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Output_for_CDT"
        Me.Text = "Output for CDT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFilename As Label
    Friend WithEvents lblInterestedVariables As Label
    Friend WithEvents ucrInputFileName As ucrInputTextBox
    Friend WithEvents ucrInputInterestedVariables As ucrInputTextBox
End Class
