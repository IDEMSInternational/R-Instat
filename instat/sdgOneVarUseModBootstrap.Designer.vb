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
Partial Class sdgOneVarUseModBootstrap
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
        Me.lblCI = New System.Windows.Forms.Label()
        Me.UcrButtonsSubdialogue1 = New instat.ucrButtonsSubdialogue()
        Me.lblIterations = New System.Windows.Forms.Label()
        Me.ucrNudCI = New instat.ucrNud()
        Me.ucrNudIterations = New instat.ucrNud()
        Me.ucrChkParametric = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'lblCI
        '
        Me.lblCI.AutoSize = True
        Me.lblCI.Location = New System.Drawing.Point(10, 19)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(102, 13)
        Me.lblCI.TabIndex = 0
        Me.lblCI.Text = "Confidence Interval:"
        '
        'UcrButtonsSubdialogue1
        '
        Me.UcrButtonsSubdialogue1.Location = New System.Drawing.Point(21, 95)
        Me.UcrButtonsSubdialogue1.Name = "UcrButtonsSubdialogue1"
        Me.UcrButtonsSubdialogue1.Size = New System.Drawing.Size(142, 30)
        Me.UcrButtonsSubdialogue1.TabIndex = 5
        '
        'lblIterations
        '
        Me.lblIterations.AutoSize = True
        Me.lblIterations.Location = New System.Drawing.Point(10, 47)
        Me.lblIterations.Name = "lblIterations"
        Me.lblIterations.Size = New System.Drawing.Size(105, 13)
        Me.lblIterations.TabIndex = 2
        Me.lblIterations.Text = "Number of Iterations:"
        '
        'ucrNudCI
        '
        Me.ucrNudCI.DecimalPlaces = New Decimal(New Integer() {2, 0, 0, 0})
        Me.ucrNudCI.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.ucrNudCI.Location = New System.Drawing.Point(120, 17)
        Me.ucrNudCI.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCI.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCI.Name = "ucrNudCI"
        Me.ucrNudCI.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCI.TabIndex = 1
        Me.ucrNudCI.Value = New Decimal(New Integer() {95, 0, 0, 131072})
        '
        'ucrNudIterations
        '
        Me.ucrNudIterations.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudIterations.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudIterations.Location = New System.Drawing.Point(120, 43)
        Me.ucrNudIterations.Maximum = New Decimal(New Integer() {10001, 0, 0, 0})
        Me.ucrNudIterations.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudIterations.Name = "ucrNudIterations"
        Me.ucrNudIterations.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudIterations.TabIndex = 3
        Me.ucrNudIterations.Value = New Decimal(New Integer() {1001, 0, 0, 0})
        '
        'ucrChkParametric
        '
        Me.ucrChkParametric.Checked = False
        Me.ucrChkParametric.Location = New System.Drawing.Point(12, 69)
        Me.ucrChkParametric.Name = "ucrChkParametric"
        Me.ucrChkParametric.Size = New System.Drawing.Size(140, 20)
        Me.ucrChkParametric.TabIndex = 4
        '
        'sdgOneVarUseModBootstrap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 131)
        Me.Controls.Add(Me.ucrChkParametric)
        Me.Controls.Add(Me.ucrNudIterations)
        Me.Controls.Add(Me.ucrNudCI)
        Me.Controls.Add(Me.lblIterations)
        Me.Controls.Add(Me.UcrButtonsSubdialogue1)
        Me.Controls.Add(Me.lblCI)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneVarUseModBootstrap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bootstrap Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCI As Label
    Friend WithEvents UcrButtonsSubdialogue1 As ucrButtonsSubdialogue
    Friend WithEvents lblIterations As Label
    Friend WithEvents ucrNudCI As ucrNud
    Friend WithEvents ucrNudIterations As ucrNud
    Friend WithEvents ucrChkParametric As ucrCheck
End Class
