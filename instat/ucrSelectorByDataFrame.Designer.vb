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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrSelectorByDataFrame))
        Me.ucrAvailableDataFrames = New instat.ucrDataFrame()
        Me.SuspendLayout()
        '
        'lstAvailableVariable
        '
        resources.ApplyResources(Me.lstAvailableVariable, "lstAvailableVariable")
        '
        'ucrAvailableDataFrames
        '
        Me.ucrAvailableDataFrames.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrAvailableDataFrames, "ucrAvailableDataFrames")
        Me.ucrAvailableDataFrames.Name = "ucrAvailableDataFrames"
        '
        'ucrSelectorByDataFrame
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrAvailableDataFrames)
        Me.Name = "ucrSelectorByDataFrame"
        Me.Controls.SetChildIndex(Me.lstAvailableVariable, 0)
        Me.Controls.SetChildIndex(Me.ucrAvailableDataFrames, 0)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents ucrAvailableDataFrames As ucrDataFrame
End Class
