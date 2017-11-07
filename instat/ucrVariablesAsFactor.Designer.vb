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
Partial Class ucrVariablesAsFactor
    Inherits instat.ucrReceiver

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrVariablesAsFactor))
        Me.ucrMultipleVariables = New instat.ucrReceiverMultiple()
        Me.ucrSingleVariable = New instat.ucrReceiverSingle()
        Me.cmdVariables = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrMultipleVariables
        '
        Me.ucrMultipleVariables.frmParent = Nothing
        resources.ApplyResources(Me.ucrMultipleVariables, "ucrMultipleVariables")
        Me.ucrMultipleVariables.Name = "ucrMultipleVariables"
        Me.ucrMultipleVariables.Selector = Nothing
        Me.ucrMultipleVariables.strNcFilePath = ""
        Me.ucrMultipleVariables.ucrSelector = Nothing
        '
        'ucrSingleVariable
        '
        Me.ucrSingleVariable.frmParent = Nothing
        resources.ApplyResources(Me.ucrSingleVariable, "ucrSingleVariable")
        Me.ucrSingleVariable.Name = "ucrSingleVariable"
        Me.ucrSingleVariable.Selector = Nothing
        Me.ucrSingleVariable.strNcFilePath = ""
        Me.ucrSingleVariable.ucrSelector = Nothing
        '
        'cmdVariables
        '
        resources.ApplyResources(Me.cmdVariables, "cmdVariables")
        Me.cmdVariables.Name = "cmdVariables"
        Me.cmdVariables.Tag = "Single_Variable"
        Me.cmdVariables.UseVisualStyleBackColor = True
        '
        'ucrVariablesAsFactor
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdVariables)
        Me.Controls.Add(Me.ucrSingleVariable)
        Me.Controls.Add(Me.ucrMultipleVariables)
        Me.Name = "ucrVariablesAsFactor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ucrMultipleVariables As ucrReceiverMultiple
    Friend WithEvents ucrSingleVariable As ucrReceiverSingle
    Friend WithEvents cmdVariables As Button
End Class
