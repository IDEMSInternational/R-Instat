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
        Me.UcrButtonsSubdialogue1.Location = New System.Drawing.Point(66, 143)
        Me.UcrButtonsSubdialogue1.Name = "UcrButtonsSubdialogue1"
        Me.UcrButtonsSubdialogue1.Size = New System.Drawing.Size(142, 30)
        Me.UcrButtonsSubdialogue1.TabIndex = 8
        '
        'ucrNumericByNumeric
        '
        Me.ucrNumericByNumeric.IsReadOnly = False
        Me.ucrNumericByNumeric.Location = New System.Drawing.Point(148, 11)
        Me.ucrNumericByNumeric.Name = "ucrNumericByNumeric"
        Me.ucrNumericByNumeric.Size = New System.Drawing.Size(144, 21)
        Me.ucrNumericByNumeric.TabIndex = 1
        '
        'lblNumericByNumeric
        '
        Me.lblNumericByNumeric.AutoSize = True
        Me.lblNumericByNumeric.Location = New System.Drawing.Point(9, 15)
        Me.lblNumericByNumeric.Name = "lblNumericByNumeric"
        Me.lblNumericByNumeric.Size = New System.Drawing.Size(105, 13)
        Me.lblNumericByNumeric.TabIndex = 0
        Me.lblNumericByNumeric.Tag = "Numeric_by_Numeric:"
        Me.lblNumericByNumeric.Text = "Numeric by Numeric:"
        '
        'lblNumericByCategorical
        '
        Me.lblNumericByCategorical.AutoSize = True
        Me.lblNumericByCategorical.Location = New System.Drawing.Point(9, 47)
        Me.lblNumericByCategorical.Name = "lblNumericByCategorical"
        Me.lblNumericByCategorical.Size = New System.Drawing.Size(119, 13)
        Me.lblNumericByCategorical.TabIndex = 2
        Me.lblNumericByCategorical.Tag = "Numeric_by_Categorical:"
        Me.lblNumericByCategorical.Text = "Numeric by Categorical:"
        '
        'ucrNumericByCategorical
        '
        Me.ucrNumericByCategorical.IsReadOnly = False
        Me.ucrNumericByCategorical.Location = New System.Drawing.Point(148, 43)
        Me.ucrNumericByCategorical.Name = "ucrNumericByCategorical"
        Me.ucrNumericByCategorical.Size = New System.Drawing.Size(144, 21)
        Me.ucrNumericByCategorical.TabIndex = 3
        '
        'lblCategoricalByCategorical
        '
        Me.lblCategoricalByCategorical.AutoSize = True
        Me.lblCategoricalByCategorical.Location = New System.Drawing.Point(9, 111)
        Me.lblCategoricalByCategorical.Name = "lblCategoricalByCategorical"
        Me.lblCategoricalByCategorical.Size = New System.Drawing.Size(133, 13)
        Me.lblCategoricalByCategorical.TabIndex = 6
        Me.lblCategoricalByCategorical.Tag = "Categorical_by_Categorical:"
        Me.lblCategoricalByCategorical.Text = "Categorical by Categorical:"
        '
        'ucrCategoricalByCategorical
        '
        Me.ucrCategoricalByCategorical.IsReadOnly = False
        Me.ucrCategoricalByCategorical.Location = New System.Drawing.Point(148, 107)
        Me.ucrCategoricalByCategorical.Name = "ucrCategoricalByCategorical"
        Me.ucrCategoricalByCategorical.Size = New System.Drawing.Size(144, 21)
        Me.ucrCategoricalByCategorical.TabIndex = 7
        '
        'lblCategoricalByNumeric
        '
        Me.lblCategoricalByNumeric.AutoSize = True
        Me.lblCategoricalByNumeric.Location = New System.Drawing.Point(9, 79)
        Me.lblCategoricalByNumeric.Name = "lblCategoricalByNumeric"
        Me.lblCategoricalByNumeric.Size = New System.Drawing.Size(119, 13)
        Me.lblCategoricalByNumeric.TabIndex = 4
        Me.lblCategoricalByNumeric.Tag = "Categorical_by_Numeric:"
        Me.lblCategoricalByNumeric.Text = "Categorical by Numeric:"
        '
        'ucrCategoricalByNumeric
        '
        Me.ucrCategoricalByNumeric.IsReadOnly = False
        Me.ucrCategoricalByNumeric.Location = New System.Drawing.Point(148, 75)
        Me.ucrCategoricalByNumeric.Name = "ucrCategoricalByNumeric"
        Me.ucrCategoricalByNumeric.Size = New System.Drawing.Size(144, 21)
        Me.ucrCategoricalByNumeric.TabIndex = 5
        '
        'sdgDescribeTwoVarGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 177)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Two Variable Graph"
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
