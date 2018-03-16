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
Partial Class sdgDescribeTwoVarGraph
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgDescribeTwoVarGraph))
        Me.UcrButtonsSubdialogue1 = New instat.ucrButtonsSubdialogue()
        Me.ucrNumericByNumeric = New instat.ucrInputComboBox()
        Me.lblNumericByNumeric = New System.Windows.Forms.Label()
        Me.lblNumericByCategorical = New System.Windows.Forms.Label()
        Me.ucrNumericByCategorical = New instat.ucrInputComboBox()
        Me.lblCategoricalByCategorical = New System.Windows.Forms.Label()
        Me.ucrCategoricalByCategorical = New instat.ucrInputComboBox()
        Me.lblCategoricalByNumeric = New System.Windows.Forms.Label()
        Me.ucrCategoricalByNumeric = New instat.ucrInputComboBox()
        Me.SuspendLayout()
        '
        'UcrButtonsSubdialogue1
        '
        resources.ApplyResources(Me.UcrButtonsSubdialogue1, "UcrButtonsSubdialogue1")
        Me.UcrButtonsSubdialogue1.Name = "UcrButtonsSubdialogue1"
        '
        'ucrNumericByNumeric
        '
        Me.ucrNumericByNumeric.AddQuotesIfUnrecognised = True
        Me.ucrNumericByNumeric.IsReadOnly = False
        resources.ApplyResources(Me.ucrNumericByNumeric, "ucrNumericByNumeric")
        Me.ucrNumericByNumeric.Name = "ucrNumericByNumeric"
        '
        'lblNumericByNumeric
        '
        resources.ApplyResources(Me.lblNumericByNumeric, "lblNumericByNumeric")
        Me.lblNumericByNumeric.Name = "lblNumericByNumeric"
        Me.lblNumericByNumeric.Tag = "Numeric_by_Numeric:"
        '
        'lblNumericByCategorical
        '
        resources.ApplyResources(Me.lblNumericByCategorical, "lblNumericByCategorical")
        Me.lblNumericByCategorical.Name = "lblNumericByCategorical"
        Me.lblNumericByCategorical.Tag = "Numeric_by_Categorical:"
        '
        'ucrNumericByCategorical
        '
        Me.ucrNumericByCategorical.AddQuotesIfUnrecognised = True
        Me.ucrNumericByCategorical.IsReadOnly = False
        resources.ApplyResources(Me.ucrNumericByCategorical, "ucrNumericByCategorical")
        Me.ucrNumericByCategorical.Name = "ucrNumericByCategorical"
        '
        'lblCategoricalByCategorical
        '
        resources.ApplyResources(Me.lblCategoricalByCategorical, "lblCategoricalByCategorical")
        Me.lblCategoricalByCategorical.Name = "lblCategoricalByCategorical"
        Me.lblCategoricalByCategorical.Tag = "Categorical_by_Categorical:"
        '
        'ucrCategoricalByCategorical
        '
        Me.ucrCategoricalByCategorical.AddQuotesIfUnrecognised = True
        Me.ucrCategoricalByCategorical.IsReadOnly = False
        resources.ApplyResources(Me.ucrCategoricalByCategorical, "ucrCategoricalByCategorical")
        Me.ucrCategoricalByCategorical.Name = "ucrCategoricalByCategorical"
        '
        'lblCategoricalByNumeric
        '
        resources.ApplyResources(Me.lblCategoricalByNumeric, "lblCategoricalByNumeric")
        Me.lblCategoricalByNumeric.Name = "lblCategoricalByNumeric"
        Me.lblCategoricalByNumeric.Tag = "Categorical_by_Numeric:"
        '
        'ucrCategoricalByNumeric
        '
        Me.ucrCategoricalByNumeric.AddQuotesIfUnrecognised = True
        Me.ucrCategoricalByNumeric.IsReadOnly = False
        resources.ApplyResources(Me.ucrCategoricalByNumeric, "ucrCategoricalByNumeric")
        Me.ucrCategoricalByNumeric.Name = "ucrCategoricalByNumeric"
        '
        'sdgDescribeTwoVarGraph
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblCategoricalByCategorical)
        Me.Controls.Add(Me.ucrCategoricalByCategorical)
        Me.Controls.Add(Me.lblCategoricalByNumeric)
        Me.Controls.Add(Me.ucrCategoricalByNumeric)
        Me.Controls.Add(Me.lblNumericByCategorical)
        Me.Controls.Add(Me.ucrNumericByCategorical)
        Me.Controls.Add(Me.lblNumericByNumeric)
        Me.Controls.Add(Me.ucrNumericByNumeric)
        Me.Controls.Add(Me.UcrButtonsSubdialogue1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgDescribeTwoVarGraph"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcrButtonsSubdialogue1 As ucrButtonsSubdialogue
    Friend WithEvents ucrNumericByNumeric As ucrInputComboBox
    Friend WithEvents lblNumericByNumeric As Label
    Friend WithEvents lblNumericByCategorical As Label
    Friend WithEvents ucrNumericByCategorical As ucrInputComboBox
    Friend WithEvents lblCategoricalByCategorical As Label
    Friend WithEvents ucrCategoricalByCategorical As ucrInputComboBox
    Friend WithEvents lblCategoricalByNumeric As Label
    Friend WithEvents ucrCategoricalByNumeric As ucrInputComboBox
End Class
