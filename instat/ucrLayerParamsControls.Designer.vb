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
Partial Class ucrLayerParamsControls
    Inherits instat.ucrCore

    'UserControl overrides dispose to clean up the component list.
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
        Me.ucrReceiverMetadataProperty = New instat.ucrReceiverMetadataProperty()
        Me.ucrChkParamName = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'ucrReceiverMetadataProperty
        '
        Me.ucrReceiverMetadataProperty.AutoSize = True
        Me.ucrReceiverMetadataProperty.Location = New System.Drawing.Point(101, 2)
        Me.ucrReceiverMetadataProperty.Name = "ucrReceiverMetadataProperty"
        Me.ucrReceiverMetadataProperty.Size = New System.Drawing.Size(161, 23)
        Me.ucrReceiverMetadataProperty.TabIndex = 1
        '
        'ucrChkParamName
        '
        Me.ucrChkParamName.AutoSize = True
        Me.ucrChkParamName.Checked = False
        Me.ucrChkParamName.Dock = System.Windows.Forms.DockStyle.Left
        Me.ucrChkParamName.Location = New System.Drawing.Point(0, 0)
        Me.ucrChkParamName.Name = "ucrChkParamName"
        Me.ucrChkParamName.Size = New System.Drawing.Size(100, 28)
        Me.ucrChkParamName.TabIndex = 0
        '
        'ucrLayerParamsControls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.ucrChkParamName)
        Me.Controls.Add(Me.ucrReceiverMetadataProperty)
        Me.Name = "ucrLayerParamsControls"
        Me.Size = New System.Drawing.Size(265, 28)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrReceiverMetadataProperty As ucrReceiverMetadataProperty
    Friend WithEvents ucrChkParamName As ucrCheck
End Class
