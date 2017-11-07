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
Partial Class ucrGridUnit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrGridUnit))
        Me.grpUnits = New System.Windows.Forms.GroupBox()
        Me.lblVector = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.ucrInputData = New instat.ucrInputTextBox()
        Me.ucrInputVector = New instat.ucrInputTextBox()
        Me.ucrInputUnits = New instat.ucrInputComboBox()
        Me.ucrChkUnits = New instat.ucrCheck()
        Me.grpUnits.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpUnits
        '
        Me.grpUnits.Controls.Add(Me.lblVector)
        Me.grpUnits.Controls.Add(Me.lblUnits)
        Me.grpUnits.Controls.Add(Me.lblData)
        Me.grpUnits.Controls.Add(Me.ucrInputData)
        Me.grpUnits.Controls.Add(Me.ucrInputVector)
        Me.grpUnits.Controls.Add(Me.ucrInputUnits)
        Me.grpUnits.Controls.Add(Me.ucrChkUnits)
        resources.ApplyResources(Me.grpUnits, "grpUnits")
        Me.grpUnits.Name = "grpUnits"
        Me.grpUnits.TabStop = False
        '
        'lblVector
        '
        resources.ApplyResources(Me.lblVector, "lblVector")
        Me.lblVector.Name = "lblVector"
        '
        'lblUnits
        '
        resources.ApplyResources(Me.lblUnits, "lblUnits")
        Me.lblUnits.Name = "lblUnits"
        '
        'lblData
        '
        resources.ApplyResources(Me.lblData, "lblData")
        Me.lblData.Name = "lblData"
        '
        'ucrInputData
        '
        Me.ucrInputData.AddQuotesIfUnrecognised = True
        Me.ucrInputData.IsMultiline = False
        Me.ucrInputData.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputData, "ucrInputData")
        Me.ucrInputData.Name = "ucrInputData"
        '
        'ucrInputVector
        '
        Me.ucrInputVector.AddQuotesIfUnrecognised = True
        Me.ucrInputVector.IsMultiline = False
        Me.ucrInputVector.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputVector, "ucrInputVector")
        Me.ucrInputVector.Name = "ucrInputVector"
        '
        'ucrInputUnits
        '
        Me.ucrInputUnits.AddQuotesIfUnrecognised = True
        Me.ucrInputUnits.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputUnits, "ucrInputUnits")
        Me.ucrInputUnits.Name = "ucrInputUnits"
        '
        'ucrChkUnits
        '
        Me.ucrChkUnits.Checked = False
        resources.ApplyResources(Me.ucrChkUnits, "ucrChkUnits")
        Me.ucrChkUnits.Name = "ucrChkUnits"
        '
        'ucrGridUnit
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpUnits)
        Me.Name = "ucrGridUnit"
        Me.grpUnits.ResumeLayout(False)
        Me.grpUnits.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpUnits As GroupBox
    Friend WithEvents ucrInputData As ucrInputTextBox
    Friend WithEvents ucrInputVector As ucrInputTextBox
    Friend WithEvents ucrInputUnits As ucrInputComboBox
    Friend WithEvents lblData As Label
    Friend WithEvents ucrChkUnits As ucrCheck
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblVector As Label
End Class
