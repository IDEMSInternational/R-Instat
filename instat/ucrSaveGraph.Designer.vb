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
Partial Class ucrSaveGraph
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
        Me.ucrInputGraphName = New instat.ucrInputComboBox()
        Me.chkSaveGraph = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ucrInputGraphName
        '
        Me.ucrInputGraphName.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputGraphName.GetSetSelectedIndex = -1
        Me.ucrInputGraphName.IsReadOnly = False
        Me.ucrInputGraphName.Location = New System.Drawing.Point(146, 3)
        Me.ucrInputGraphName.Name = "ucrInputGraphName"
        Me.ucrInputGraphName.Size = New System.Drawing.Size(151, 29)
        Me.ucrInputGraphName.TabIndex = 0
        '
        'chkSaveGraph
        '
        Me.chkSaveGraph.AutoSize = True
        Me.chkSaveGraph.Location = New System.Drawing.Point(0, 3)
        Me.chkSaveGraph.Name = "chkSaveGraph"
        Me.chkSaveGraph.Size = New System.Drawing.Size(83, 17)
        Me.chkSaveGraph.TabIndex = 1
        Me.chkSaveGraph.Tag = "Save_Graph"
        Me.chkSaveGraph.Text = "Save Graph"
        Me.chkSaveGraph.UseVisualStyleBackColor = True
        '
        'ucrSaveGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.Controls.Add(Me.chkSaveGraph)
        Me.Controls.Add(Me.ucrInputGraphName)
        Me.Name = "ucrSaveGraph"
        Me.Size = New System.Drawing.Size(313, 35)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrInputGraphName As ucrInputComboBox
    Friend WithEvents chkSaveGraph As CheckBox
End Class
