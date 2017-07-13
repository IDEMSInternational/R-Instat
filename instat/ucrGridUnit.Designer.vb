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
Partial Class ucrGridUnit
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.grpUnits = New System.Windows.Forms.GroupBox()
        Me.lblVector = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.ucrInputData = New instat.ucrInputTextBox()
        Me.ucrInputVector = New instat.ucrInputTextBox()
        Me.ucrInputUnits = New instat.ucrInputComboBox()
        Me.ucrChkUnits = New instat.ucrCheck()
        Me.grpUnits.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpUnits
        '
        Me.grpUnits.Controls.Add(Me.lblVector)
        Me.grpUnits.Controls.Add(Me.lblUnits)
        Me.grpUnits.Controls.Add(Me.lblData)
        Me.grpUnits.Controls.Add(Me.ucrInputData)
        Me.grpUnits.Controls.Add(Me.ucrInputVector)
        Me.grpUnits.Controls.Add(Me.ucrInputUnits)
        Me.grpUnits.Controls.Add(Me.ucrChkUnits)
        Me.grpUnits.Location = New System.Drawing.Point(3, 0)
        Me.grpUnits.Name = "grpUnits"
        Me.grpUnits.Size = New System.Drawing.Size(246, 119)
        Me.grpUnits.TabIndex = 0
        Me.grpUnits.TabStop = False
        Me.grpUnits.Text = "Units"
        '
        'lblVector
        '
        Me.lblVector.AutoSize = True
        Me.lblVector.Location = New System.Drawing.Point(18, 47)
        Me.lblVector.Name = "lblVector"
        Me.lblVector.Size = New System.Drawing.Size(74, 13)
        Me.lblVector.TabIndex = 1
        Me.lblVector.Text = "Value(Vector):"
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(18, 71)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(34, 13)
        Me.lblUnits.TabIndex = 3
        Me.lblUnits.Text = "Units:"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(18, 96)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(81, 13)
        Me.lblData.TabIndex = 5
        Me.lblData.Text = "Data (Optional):"
        '
        'ucrInputData
        '
        Me.ucrInputData.AddQuotesIfUnrecognised = True
        Me.ucrInputData.IsMultiline = False
        Me.ucrInputData.IsReadOnly = False
        Me.ucrInputData.Location = New System.Drawing.Point(105, 92)
        Me.ucrInputData.Name = "ucrInputData"
        Me.ucrInputData.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputData.TabIndex = 6
        '
        'ucrInputVector
        '
        Me.ucrInputVector.AddQuotesIfUnrecognised = True
        Me.ucrInputVector.IsMultiline = False
        Me.ucrInputVector.IsReadOnly = False
        Me.ucrInputVector.Location = New System.Drawing.Point(105, 43)
        Me.ucrInputVector.Name = "ucrInputVector"
        Me.ucrInputVector.Size = New System.Drawing.Size(137, 23)
        Me.ucrInputVector.TabIndex = 2
        '
        'ucrInputUnits
        '
        Me.ucrInputUnits.AddQuotesIfUnrecognised = True
        Me.ucrInputUnits.IsReadOnly = False
        Me.ucrInputUnits.Location = New System.Drawing.Point(105, 68)
        Me.ucrInputUnits.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputUnits.Name = "ucrInputUnits"
        Me.ucrInputUnits.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputUnits.TabIndex = 4
        '
        'ucrChkUnits
        '
        Me.ucrChkUnits.Checked = False
        Me.ucrChkUnits.Location = New System.Drawing.Point(8, 19)
        Me.ucrChkUnits.Name = "ucrChkUnits"
        Me.ucrChkUnits.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkUnits.TabIndex = 0
        '
        'ucrGridUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpUnits)
        Me.Name = "ucrGridUnit"
        Me.Size = New System.Drawing.Size(255, 123)
        Me.grpUnits.ResumeLayout(False)
        Me.grpUnits.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpUnits As GroupBox
    Friend WithEvents ucrInputData As ucrInputTextBox
    Friend WithEvents ucrInputVector As ucrInputTextBox
    Friend WithEvents ucrInputUnits As ucrInputComboBox
    Friend WithEvents lblData As Label
    Friend WithEvents ucrChkUnits As ucrCheck
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblVector As Label
End Class
