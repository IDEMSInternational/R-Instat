﻿' R- Instat
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
Partial Class ucrDistributions
    Inherits instat.ucrCore

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
        Me.lblDistributionType = New System.Windows.Forms.Label()
        Me.ucrInputDistributions = New instat.ucrInputComboBox()
        Me.SuspendLayout()
        '
        'lblDistributionType
        '
        Me.lblDistributionType.AutoSize = True
        Me.lblDistributionType.Location = New System.Drawing.Point(-1, 5)
        Me.lblDistributionType.Name = "lblDistributionType"
        Me.lblDistributionType.Size = New System.Drawing.Size(62, 13)
        Me.lblDistributionType.TabIndex = 0
        Me.lblDistributionType.Tag = "distribution:"
        Me.lblDistributionType.Text = "Distribution:"
        '
        'ucrInputDistributions
        '
        Me.ucrInputDistributions.AddQuotesIfUnrecognised = True
        Me.ucrInputDistributions.IsReadOnly = False
        Me.ucrInputDistributions.Location = New System.Drawing.Point(67, 3)
        Me.ucrInputDistributions.Name = "ucrInputDistributions"
        Me.ucrInputDistributions.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDistributions.TabIndex = 1
        '
        'ucrDistributions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputDistributions)
        Me.Controls.Add(Me.lblDistributionType)
        Me.Name = "ucrDistributions"
        Me.Size = New System.Drawing.Size(208, 27)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDistributionType As Label
    Friend WithEvents ucrInputDistributions As ucrInputComboBox
End Class
