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
Partial Class sdgLayerOptions
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
        Me.tbcLayers = New System.Windows.Forms.TabControl()
        Me.tbpAesthetics = New System.Windows.Forms.TabPage()
        Me.ucrGeomWithAes = New instat.ucrGeomListWithParameters()
        Me.tbpGeomParameters = New System.Windows.Forms.TabPage()
        Me.ucrLayerParameter = New instat.ucrLayerParameters()
        Me.ucrSdgLayerBase = New instat.ucrButtonsSubdialogue()
        Me.tbcLayers.SuspendLayout()
        Me.tbpAesthetics.SuspendLayout()
        Me.tbpGeomParameters.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcLayers
        '
        Me.tbcLayers.Controls.Add(Me.tbpAesthetics)
        Me.tbcLayers.Controls.Add(Me.tbpGeomParameters)
        Me.tbcLayers.Location = New System.Drawing.Point(13, 13)
        Me.tbcLayers.Name = "tbcLayers"
        Me.tbcLayers.SelectedIndex = 0
        Me.tbcLayers.Size = New System.Drawing.Size(482, 511)
        Me.tbcLayers.TabIndex = 1
        '
        'tbpAesthetics
        '
        Me.tbpAesthetics.Controls.Add(Me.ucrGeomWithAes)
        Me.tbpAesthetics.Location = New System.Drawing.Point(4, 22)
        Me.tbpAesthetics.Name = "tbpAesthetics"
        Me.tbpAesthetics.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpAesthetics.Size = New System.Drawing.Size(474, 485)
        Me.tbpAesthetics.TabIndex = 0
        Me.tbpAesthetics.Text = "Layer Dimensions(Aesthetics)"
        Me.tbpAesthetics.UseVisualStyleBackColor = True
        '
        'ucrGeomWithAes
        '
        Me.ucrGeomWithAes.Location = New System.Drawing.Point(6, 6)
        Me.ucrGeomWithAes.Name = "ucrGeomWithAes"
        Me.ucrGeomWithAes.Size = New System.Drawing.Size(467, 399)
        Me.ucrGeomWithAes.TabIndex = 0
        '
        'tbpGeomParameters
        '
        Me.tbpGeomParameters.Controls.Add(Me.ucrLayerParameter)
        Me.tbpGeomParameters.Location = New System.Drawing.Point(4, 22)
        Me.tbpGeomParameters.Name = "tbpGeomParameters"
        Me.tbpGeomParameters.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpGeomParameters.Size = New System.Drawing.Size(474, 485)
        Me.tbpGeomParameters.TabIndex = 1
        Me.tbpGeomParameters.Text = "Layer Parameters(Geom Parameters)"
        Me.tbpGeomParameters.UseVisualStyleBackColor = True
        '
        'ucrLayerParameter
        '
        Me.ucrLayerParameter.Location = New System.Drawing.Point(3, 3)
        Me.ucrLayerParameter.Name = "ucrLayerParameter"
        Me.ucrLayerParameter.Size = New System.Drawing.Size(308, 476)
        Me.ucrLayerParameter.TabIndex = 0
        Me.ucrLayerParameter.ucrGeomWithAes = Nothing
        '
        'ucrSdgLayerBase
        '
        Me.ucrSdgLayerBase.Location = New System.Drawing.Point(186, 533)
        Me.ucrSdgLayerBase.Name = "ucrSdgLayerBase"
        Me.ucrSdgLayerBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrSdgLayerBase.TabIndex = 0
        '
        'sdgLayerOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 568)
        Me.Controls.Add(Me.tbcLayers)
        Me.Controls.Add(Me.ucrSdgLayerBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgLayerOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Layer Options"
        Me.tbcLayers.ResumeLayout(False)
        Me.tbpAesthetics.ResumeLayout(False)
        Me.tbpGeomParameters.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSdgLayerBase As ucrButtonsSubdialogue
    Friend WithEvents tbcLayers As TabControl
    Friend WithEvents tbpAesthetics As TabPage
    Friend WithEvents tbpGeomParameters As TabPage
    Friend WithEvents ucrGeomWithAes As ucrGeomListWithParameters
    Friend WithEvents ucrLayerParameter As ucrLayerParameters
End Class
