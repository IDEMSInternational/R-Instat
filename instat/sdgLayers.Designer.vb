﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgLayers
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
        Me.tbcLayers = New System.Windows.Forms.TabControl()
        Me.tbpAesthetics = New System.Windows.Forms.TabPage()
        Me.tbpGeomParameters = New System.Windows.Forms.TabPage()
        Me.ucrSdgLayerBase = New instat.ucrButtonsSubdialogue()
        Me.ucrGeomWithAes = New instat.UcrGeomListWithParameters()
        Me.tbcLayers.SuspendLayout()
        Me.tbpAesthetics.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcLayers
        '
        Me.tbcLayers.Controls.Add(Me.tbpAesthetics)
        Me.tbcLayers.Controls.Add(Me.tbpGeomParameters)
        Me.tbcLayers.Location = New System.Drawing.Point(13, 13)
        Me.tbcLayers.Name = "tbcLayers"
        Me.tbcLayers.SelectedIndex = 0
        Me.tbcLayers.Size = New System.Drawing.Size(482, 335)
        Me.tbcLayers.TabIndex = 1
        '
        'tbpAesthetics
        '
        Me.tbpAesthetics.Controls.Add(Me.ucrGeomWithAes)
        Me.tbpAesthetics.Location = New System.Drawing.Point(4, 22)
        Me.tbpAesthetics.Name = "tbpAesthetics"
        Me.tbpAesthetics.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpAesthetics.Size = New System.Drawing.Size(474, 309)
        Me.tbpAesthetics.TabIndex = 0
        Me.tbpAesthetics.Text = "Aesthetics"
        Me.tbpAesthetics.UseVisualStyleBackColor = True
        '
        'tbpGeomParameters
        '
        Me.tbpGeomParameters.Location = New System.Drawing.Point(4, 22)
        Me.tbpGeomParameters.Name = "tbpGeomParameters"
        Me.tbpGeomParameters.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpGeomParameters.Size = New System.Drawing.Size(474, 358)
        Me.tbpGeomParameters.TabIndex = 1
        Me.tbpGeomParameters.Text = "Geom Parameters"
        Me.tbpGeomParameters.UseVisualStyleBackColor = True
        '
        'ucrSdgLayerBase
        '
        Me.ucrSdgLayerBase.Location = New System.Drawing.Point(148, 354)
        Me.ucrSdgLayerBase.Name = "ucrSdgLayerBase"
        Me.ucrSdgLayerBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrSdgLayerBase.TabIndex = 0
        '
        'ucrGeomWithAes
        '
        Me.ucrGeomWithAes.Location = New System.Drawing.Point(6, 6)
        Me.ucrGeomWithAes.Name = "ucrGeomWithAes"
        Me.ucrGeomWithAes.Size = New System.Drawing.Size(467, 286)
        Me.ucrGeomWithAes.TabIndex = 0
        '
        'sdgLayers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 385)
        Me.Controls.Add(Me.tbcLayers)
        Me.Controls.Add(Me.ucrSdgLayerBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgLayers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Layers"
        Me.tbcLayers.ResumeLayout(False)
        Me.tbpAesthetics.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSdgLayerBase As ucrButtonsSubdialogue
    Friend WithEvents tbcLayers As TabControl
    Friend WithEvents tbpAesthetics As TabPage
    Friend WithEvents tbpGeomParameters As TabPage
    Friend WithEvents ucrGeomWithAes As UcrGeomListWithParameters
End Class
