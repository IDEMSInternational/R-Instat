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
Partial Class ucrVariablesAsFactor
    Inherits instat.ucrReceiver

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
        Me.ucrMultipleVariables = New instat.ucrReceiverMultiple()
        Me.ucrSingleVariable = New instat.ucrReceiverSingle()
        Me.cmdVariables = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrMultipleVariables
        '
        Me.ucrMultipleVariables.Location = New System.Drawing.Point(0, 30)
        Me.ucrMultipleVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrMultipleVariables.Name = "ucrMultipleVariables"
        Me.ucrMultipleVariables.Selector = Nothing
        Me.ucrMultipleVariables.Size = New System.Drawing.Size(120, 100)
        Me.ucrMultipleVariables.TabIndex = 1
        '
        'ucrSingleVariable
        '
        Me.ucrSingleVariable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ucrSingleVariable.Location = New System.Drawing.Point(0, 30)
        Me.ucrSingleVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSingleVariable.Name = "ucrSingleVariable"
        Me.ucrSingleVariable.Selector = Nothing
        Me.ucrSingleVariable.Size = New System.Drawing.Size(120, 20)
        Me.ucrSingleVariable.TabIndex = 2
        '
        'cmdVariables
        '
        Me.cmdVariables.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdVariables.Location = New System.Drawing.Point(0, 0)
        Me.cmdVariables.Name = "cmdVariables"
        Me.cmdVariables.Size = New System.Drawing.Size(120, 27)
        Me.cmdVariables.TabIndex = 3
        Me.cmdVariables.Tag = "Single_Variable"
        Me.cmdVariables.Text = "Single Variable"
        Me.cmdVariables.UseVisualStyleBackColor = True
        '
        'ucrVariablesAsFactor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdVariables)
        Me.Controls.Add(Me.ucrSingleVariable)
        Me.Controls.Add(Me.ucrMultipleVariables)
        Me.Name = "ucrVariablesAsFactor"
        Me.Size = New System.Drawing.Size(120, 130)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ucrMultipleVariables As ucrReceiverMultiple
    Friend WithEvents ucrSingleVariable As ucrReceiverSingle
    Friend WithEvents cmdVariables As Button
End Class
