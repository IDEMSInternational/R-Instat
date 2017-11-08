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
Partial Class ucrDistributionsWithParameters
    Inherits instat.ucrDistributions

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrDistributionsWithParameters))
        Me.lblDistributionParameters = New System.Windows.Forms.Label()
        Me.lblParameter1 = New System.Windows.Forms.Label()
        Me.lblParameter2 = New System.Windows.Forms.Label()
        Me.lblParameter3 = New System.Windows.Forms.Label()
        Me.lblParameter4 = New System.Windows.Forms.Label()
        Me.ucrInputParameter1 = New instat.ucrInputTextBox()
        Me.ucrInputParameter2 = New instat.ucrInputTextBox()
        Me.ucrInputParameter3 = New instat.ucrInputTextBox()
        Me.ucrInputParameter4 = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'lblDistributionParameters
        '
        resources.ApplyResources(Me.lblDistributionParameters, "lblDistributionParameters")
        Me.lblDistributionParameters.Name = "lblDistributionParameters"
        Me.lblDistributionParameters.Tag = "distribution_parameters:"
        '
        'lblParameter1
        '
        resources.ApplyResources(Me.lblParameter1, "lblParameter1")
        Me.lblParameter1.Name = "lblParameter1"
        '
        'lblParameter2
        '
        resources.ApplyResources(Me.lblParameter2, "lblParameter2")
        Me.lblParameter2.Name = "lblParameter2"
        '
        'lblParameter3
        '
        resources.ApplyResources(Me.lblParameter3, "lblParameter3")
        Me.lblParameter3.Name = "lblParameter3"
        '
        'lblParameter4
        '
        resources.ApplyResources(Me.lblParameter4, "lblParameter4")
        Me.lblParameter4.Name = "lblParameter4"
        '
        'ucrInputParameter1
        '
        Me.ucrInputParameter1.AddQuotesIfUnrecognised = True
        Me.ucrInputParameter1.IsMultiline = False
        Me.ucrInputParameter1.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputParameter1, "ucrInputParameter1")
        Me.ucrInputParameter1.Name = "ucrInputParameter1"
        '
        'ucrInputParameter2
        '
        Me.ucrInputParameter2.AddQuotesIfUnrecognised = True
        Me.ucrInputParameter2.IsMultiline = False
        Me.ucrInputParameter2.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputParameter2, "ucrInputParameter2")
        Me.ucrInputParameter2.Name = "ucrInputParameter2"
        '
        'ucrInputParameter3
        '
        Me.ucrInputParameter3.AddQuotesIfUnrecognised = True
        Me.ucrInputParameter3.IsMultiline = False
        Me.ucrInputParameter3.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputParameter3, "ucrInputParameter3")
        Me.ucrInputParameter3.Name = "ucrInputParameter3"
        '
        'ucrInputParameter4
        '
        Me.ucrInputParameter4.AddQuotesIfUnrecognised = True
        Me.ucrInputParameter4.IsMultiline = False
        Me.ucrInputParameter4.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputParameter4, "ucrInputParameter4")
        Me.ucrInputParameter4.Name = "ucrInputParameter4"
        '
        'ucrDistributionsWithParameters
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputParameter3)
        Me.Controls.Add(Me.ucrInputParameter4)
        Me.Controls.Add(Me.ucrInputParameter2)
        Me.Controls.Add(Me.ucrInputParameter1)
        Me.Controls.Add(Me.lblParameter4)
        Me.Controls.Add(Me.lblParameter3)
        Me.Controls.Add(Me.lblParameter2)
        Me.Controls.Add(Me.lblParameter1)
        Me.Controls.Add(Me.lblDistributionParameters)
        Me.Name = "ucrDistributionsWithParameters"
        Me.Controls.SetChildIndex(Me.lblDistributionParameters, 0)
        Me.Controls.SetChildIndex(Me.lblParameter1, 0)
        Me.Controls.SetChildIndex(Me.lblParameter2, 0)
        Me.Controls.SetChildIndex(Me.lblParameter3, 0)
        Me.Controls.SetChildIndex(Me.lblParameter4, 0)
        Me.Controls.SetChildIndex(Me.ucrInputParameter1, 0)
        Me.Controls.SetChildIndex(Me.ucrInputParameter2, 0)
        Me.Controls.SetChildIndex(Me.ucrInputParameter4, 0)
        Me.Controls.SetChildIndex(Me.ucrInputParameter3, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDistributionParameters As Label
    Friend WithEvents lblParameter1 As Label
    Friend WithEvents lblParameter2 As Label
    Friend WithEvents lblParameter3 As Label
    Friend WithEvents lblParameter4 As Label
    Friend WithEvents ucrInputParameter1 As ucrInputTextBox
    Friend WithEvents ucrInputParameter2 As ucrInputTextBox
    Friend WithEvents ucrInputParameter3 As ucrInputTextBox
    Friend WithEvents ucrInputParameter4 As ucrInputTextBox
End Class
