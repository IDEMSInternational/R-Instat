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
Partial Class ucrSelectorByDataFrame
    Inherits instat.ucrSelector

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
        Me.ucrAvailableDataFrames = New instat.ucrDataFrame()
        Me.SuspendLayout()
        '
        'lstAvailableVariable
        '
        Me.lstAvailableVariable.Dock = System.Windows.Forms.DockStyle.None
        Me.lstAvailableVariable.Location = New System.Drawing.Point(0, 50)
        Me.lstAvailableVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.lstAvailableVariable.Size = New System.Drawing.Size(148, 130)
        '
        'ucrAvailableDataFrames
        '
        Me.ucrAvailableDataFrames.bUseCurrentFilter = True
        Me.ucrAvailableDataFrames.Location = New System.Drawing.Point(0, 0)
        Me.ucrAvailableDataFrames.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAvailableDataFrames.Name = "ucrAvailableDataFrames"
        Me.ucrAvailableDataFrames.Size = New System.Drawing.Size(148, 50)
        Me.ucrAvailableDataFrames.TabIndex = 84
        '
        'ucrSelectorByDataFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrAvailableDataFrames)
        Me.Name = "ucrSelectorByDataFrame"
        Me.Size = New System.Drawing.Size(148, 180)
        Me.Controls.SetChildIndex(Me.lstAvailableVariable, 0)
        Me.Controls.SetChildIndex(Me.ucrAvailableDataFrames, 0)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents ucrAvailableDataFrames As ucrDataFrame
End Class
