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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgLayerOptions))
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
        resources.ApplyResources(Me.tbcLayers, "tbcLayers")
        Me.tbcLayers.Name = "tbcLayers"
        Me.tbcLayers.SelectedIndex = 0
        '
        'tbpAesthetics
        '
        Me.tbpAesthetics.Controls.Add(Me.ucrGeomWithAes)
        resources.ApplyResources(Me.tbpAesthetics, "tbpAesthetics")
        Me.tbpAesthetics.Name = "tbpAesthetics"
        Me.tbpAesthetics.UseVisualStyleBackColor = True
        '
        'ucrGeomWithAes
        '
        resources.ApplyResources(Me.ucrGeomWithAes, "ucrGeomWithAes")
        Me.ucrGeomWithAes.Name = "ucrGeomWithAes"
        '
        'tbpGeomParameters
        '
        Me.tbpGeomParameters.Controls.Add(Me.ucrLayerParameter)
        resources.ApplyResources(Me.tbpGeomParameters, "tbpGeomParameters")
        Me.tbpGeomParameters.Name = "tbpGeomParameters"
        Me.tbpGeomParameters.UseVisualStyleBackColor = True
        '
        'ucrLayerParameter
        '
        resources.ApplyResources(Me.ucrLayerParameter, "ucrLayerParameter")
        Me.ucrLayerParameter.Name = "ucrLayerParameter"
        Me.ucrLayerParameter.ucrGeomWithAes = Nothing
        '
        'ucrSdgLayerBase
        '
        resources.ApplyResources(Me.ucrSdgLayerBase, "ucrSdgLayerBase")
        Me.ucrSdgLayerBase.Name = "ucrSdgLayerBase"
        '
        'sdgLayerOptions
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbcLayers)
        Me.Controls.Add(Me.ucrSdgLayerBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgLayerOptions"
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
