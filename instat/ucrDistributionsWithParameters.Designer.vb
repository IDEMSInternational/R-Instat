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
Partial Class ucrDistributionsWithParameters
    Inherits instat.ucrDistributions

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
        Me.lblDistributionParameters = New System.Windows.Forms.Label()
        Me.lblParameter1 = New System.Windows.Forms.Label()
        Me.lblParameter2 = New System.Windows.Forms.Label()
        Me.lblParameter3 = New System.Windows.Forms.Label()
        Me.lblParameter4 = New System.Windows.Forms.Label()
        Me.ucrInputParameter1 = New instat.ucrInputTextBox()
        Me.ucrInputParameter2 = New instat.ucrInputTextBox()
        Me.ucrInputParameter3 = New instat.ucrInputTextBox()
        Me.ucrInputParameter4 = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'lblDistributionParameters
        '
        Me.lblDistributionParameters.AutoSize = True
        Me.lblDistributionParameters.Location = New System.Drawing.Point(2, 43)
        Me.lblDistributionParameters.Name = "lblDistributionParameters"
        Me.lblDistributionParameters.Size = New System.Drawing.Size(118, 13)
        Me.lblDistributionParameters.TabIndex = 2
        Me.lblDistributionParameters.Tag = "distribution_parameters:"
        Me.lblDistributionParameters.Text = "Distribution Parameters:"
        '
        'lblParameter1
        '
        Me.lblParameter1.AutoSize = True
        Me.lblParameter1.Location = New System.Drawing.Point(9, 72)
        Me.lblParameter1.Name = "lblParameter1"
        Me.lblParameter1.Size = New System.Drawing.Size(0, 13)
        Me.lblParameter1.TabIndex = 3
        '
        'lblParameter2
        '
        Me.lblParameter2.AutoSize = True
        Me.lblParameter2.Location = New System.Drawing.Point(9, 101)
        Me.lblParameter2.Name = "lblParameter2"
        Me.lblParameter2.Size = New System.Drawing.Size(0, 13)
        Me.lblParameter2.TabIndex = 4
        '
        'lblParameter3
        '
        Me.lblParameter3.AutoSize = True
        Me.lblParameter3.Location = New System.Drawing.Point(9, 128)
        Me.lblParameter3.Name = "lblParameter3"
        Me.lblParameter3.Size = New System.Drawing.Size(0, 13)
        Me.lblParameter3.TabIndex = 5
        '
        'lblParameter4
        '
        Me.lblParameter4.AutoSize = True
        Me.lblParameter4.Location = New System.Drawing.Point(9, 155)
        Me.lblParameter4.Name = "lblParameter4"
        Me.lblParameter4.Size = New System.Drawing.Size(0, 13)
        Me.lblParameter4.TabIndex = 9
        '
        'ucrInputParameter1
        '
        Me.ucrInputParameter1.AddQuotesIfUnrecognised = True
        Me.ucrInputParameter1.AutoSize = True
        Me.ucrInputParameter1.IsMultiline = False
        Me.ucrInputParameter1.IsReadOnly = False
        Me.ucrInputParameter1.Location = New System.Drawing.Point(143, 67)
        Me.ucrInputParameter1.Name = "ucrInputParameter1"
        Me.ucrInputParameter1.Size = New System.Drawing.Size(100, 21)
        Me.ucrInputParameter1.TabIndex = 11
        '
        'ucrInputParameter2
        '
        Me.ucrInputParameter2.AddQuotesIfUnrecognised = True
        Me.ucrInputParameter2.AutoSize = True
        Me.ucrInputParameter2.IsMultiline = False
        Me.ucrInputParameter2.IsReadOnly = False
        Me.ucrInputParameter2.Location = New System.Drawing.Point(143, 95)
        Me.ucrInputParameter2.Name = "ucrInputParameter2"
        Me.ucrInputParameter2.Size = New System.Drawing.Size(100, 21)
        Me.ucrInputParameter2.TabIndex = 12
        '
        'ucrInputParameter3
        '
        Me.ucrInputParameter3.AddQuotesIfUnrecognised = True
        Me.ucrInputParameter3.AutoSize = True
        Me.ucrInputParameter3.IsMultiline = False
        Me.ucrInputParameter3.IsReadOnly = False
        Me.ucrInputParameter3.Location = New System.Drawing.Point(143, 122)
        Me.ucrInputParameter3.Name = "ucrInputParameter3"
        Me.ucrInputParameter3.Size = New System.Drawing.Size(100, 21)
        Me.ucrInputParameter3.TabIndex = 14
        '
        'ucrInputParameter4
        '
        Me.ucrInputParameter4.AddQuotesIfUnrecognised = True
        Me.ucrInputParameter4.AutoSize = True
        Me.ucrInputParameter4.IsMultiline = False
        Me.ucrInputParameter4.IsReadOnly = False
        Me.ucrInputParameter4.Location = New System.Drawing.Point(143, 148)
        Me.ucrInputParameter4.Name = "ucrInputParameter4"
        Me.ucrInputParameter4.Size = New System.Drawing.Size(100, 21)
        Me.ucrInputParameter4.TabIndex = 13
        '
        'ucrDistributionsWithParameters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.ucrInputParameter3)
        Me.Controls.Add(Me.ucrInputParameter4)
        Me.Controls.Add(Me.ucrInputParameter2)
        Me.Controls.Add(Me.ucrInputParameter1)
        Me.Controls.Add(Me.lblParameter4)
        Me.Controls.Add(Me.lblParameter3)
        Me.Controls.Add(Me.lblParameter2)
        Me.Controls.Add(Me.lblParameter1)
        Me.Controls.Add(Me.lblDistributionParameters)
        Me.Name = "ucrDistributionsWithParameters"
        Me.Size = New System.Drawing.Size(248, 177)
        Me.Controls.SetChildIndex(Me.lblDistributionParameters, 0)
        Me.Controls.SetChildIndex(Me.lblParameter1, 0)
        Me.Controls.SetChildIndex(Me.lblParameter2, 0)
        Me.Controls.SetChildIndex(Me.lblParameter3, 0)
        Me.Controls.SetChildIndex(Me.lblParameter4, 0)
        Me.Controls.SetChildIndex(Me.ucrInputParameter1, 0)
        Me.Controls.SetChildIndex(Me.ucrInputParameter2, 0)
        Me.Controls.SetChildIndex(Me.ucrInputParameter4, 0)
        Me.Controls.SetChildIndex(Me.ucrInputParameter3, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDistributionParameters As Label
    Friend WithEvents lblParameter1 As Label
    Friend WithEvents lblParameter2 As Label
    Friend WithEvents lblParameter3 As Label
    Friend WithEvents lblParameter4 As Label
    Friend WithEvents ucrInputParameter1 As ucrInputTextBox
    Friend WithEvents ucrInputParameter2 As ucrInputTextBox
    Friend WithEvents ucrInputParameter3 As ucrInputTextBox
    Friend WithEvents ucrInputParameter4 As ucrInputTextBox
End Class
