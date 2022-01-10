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
Partial Class ucrGeom
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
        Me.lblTypeofLayer = New System.Windows.Forms.Label()
        Me.ucrInputGeoms = New instat.ucrInputComboBox()
        Me.SuspendLayout()
        '
        'lblTypeofLayer
        '
        Me.lblTypeofLayer.AutoSize = True
        Me.lblTypeofLayer.Location = New System.Drawing.Point(4, 4)
        Me.lblTypeofLayer.Name = "lblTypeofLayer"
        Me.lblTypeofLayer.Size = New System.Drawing.Size(112, 13)
        Me.lblTypeofLayer.TabIndex = 1
        Me.lblTypeofLayer.Text = "Type of Layer (Geom):"
        Me.lblTypeofLayer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ucrInputGeoms
        '
        Me.ucrInputGeoms.AddQuotesIfUnrecognised = True
        Me.ucrInputGeoms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputGeoms.GetSetSelectedIndex = -1
        Me.ucrInputGeoms.IsReadOnly = False
        Me.ucrInputGeoms.Location = New System.Drawing.Point(7, 22)
        Me.ucrInputGeoms.Name = "ucrInputGeoms"
        Me.ucrInputGeoms.Size = New System.Drawing.Size(151, 21)
        Me.ucrInputGeoms.TabIndex = 2
        '
        'ucrGeom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.ucrInputGeoms)
        Me.Controls.Add(Me.lblTypeofLayer)
        Me.Name = "ucrGeom"
        Me.Size = New System.Drawing.Size(168, 50)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTypeofLayer As Label
    Friend WithEvents ucrInputGeoms As ucrInputComboBox
End Class
