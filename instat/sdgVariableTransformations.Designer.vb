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
Partial Class sdgVariableTransformations
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
        Me.ucrButtonsSDGVarTransform = New instat.ucrButtonsSubdialogue()
        Me.rdoLogBase10 = New System.Windows.Forms.RadioButton()
        Me.rdoSquareRoot = New System.Windows.Forms.RadioButton()
        Me.rdoPower = New System.Windows.Forms.RadioButton()
        Me.rdoNaturalLog = New System.Windows.Forms.RadioButton()
        Me.rdoIdentity = New System.Windows.Forms.RadioButton()
        Me.ucrNudPower = New instat.ucrNud()
        Me.grpChooseFunction = New System.Windows.Forms.GroupBox()
        Me.ucrPnlChooseFunction = New instat.UcrPanel()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.ucrInputPreview = New instat.ucrInputTextBox()
        Me.grpChooseFunction.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrButtonsSDGVarTransform
        '
        Me.ucrButtonsSDGVarTransform.Location = New System.Drawing.Point(42, 250)
        Me.ucrButtonsSDGVarTransform.Name = "ucrButtonsSDGVarTransform"
        Me.ucrButtonsSDGVarTransform.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsSDGVarTransform.TabIndex = 2
        '
        'rdoLogBase10
        '
        Me.rdoLogBase10.AutoSize = True
        Me.rdoLogBase10.Location = New System.Drawing.Point(23, 89)
        Me.rdoLogBase10.Name = "rdoLogBase10"
        Me.rdoLogBase10.Size = New System.Drawing.Size(85, 17)
        Me.rdoLogBase10.TabIndex = 13
        Me.rdoLogBase10.TabStop = True
        Me.rdoLogBase10.Tag = "Log_Base_10"
        Me.rdoLogBase10.Text = "Log Base 10"
        Me.rdoLogBase10.UseVisualStyleBackColor = True
        '
        'rdoSquareRoot
        '
        Me.rdoSquareRoot.AutoSize = True
        Me.rdoSquareRoot.Location = New System.Drawing.Point(23, 118)
        Me.rdoSquareRoot.Name = "rdoSquareRoot"
        Me.rdoSquareRoot.Size = New System.Drawing.Size(85, 17)
        Me.rdoSquareRoot.TabIndex = 14
        Me.rdoSquareRoot.TabStop = True
        Me.rdoSquareRoot.Tag = "Square_root"
        Me.rdoSquareRoot.Text = "Square Root"
        Me.rdoSquareRoot.UseVisualStyleBackColor = True
        '
        'rdoPower
        '
        Me.rdoPower.AutoSize = True
        Me.rdoPower.Location = New System.Drawing.Point(23, 147)
        Me.rdoPower.Name = "rdoPower"
        Me.rdoPower.Size = New System.Drawing.Size(58, 17)
        Me.rdoPower.TabIndex = 15
        Me.rdoPower.TabStop = True
        Me.rdoPower.Tag = "Power"
        Me.rdoPower.Text = "Power:"
        Me.rdoPower.UseVisualStyleBackColor = True
        '
        'rdoNaturalLog
        '
        Me.rdoNaturalLog.AutoSize = True
        Me.rdoNaturalLog.Location = New System.Drawing.Point(23, 60)
        Me.rdoNaturalLog.Name = "rdoNaturalLog"
        Me.rdoNaturalLog.Size = New System.Drawing.Size(80, 17)
        Me.rdoNaturalLog.TabIndex = 12
        Me.rdoNaturalLog.TabStop = True
        Me.rdoNaturalLog.Tag = "Natural_log"
        Me.rdoNaturalLog.Text = "Natural Log"
        Me.rdoNaturalLog.UseVisualStyleBackColor = True
        '
        'rdoIdentity
        '
        Me.rdoIdentity.AutoSize = True
        Me.rdoIdentity.Location = New System.Drawing.Point(23, 31)
        Me.rdoIdentity.Name = "rdoIdentity"
        Me.rdoIdentity.Size = New System.Drawing.Size(59, 17)
        Me.rdoIdentity.TabIndex = 17
        Me.rdoIdentity.TabStop = True
        Me.rdoIdentity.Tag = "Identity"
        Me.rdoIdentity.Text = "Identity"
        Me.rdoIdentity.UseVisualStyleBackColor = True
        '
        'ucrNudPower
        '
        Me.ucrNudPower.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPower.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPower.Location = New System.Drawing.Point(87, 147)
        Me.ucrNudPower.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPower.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPower.Name = "ucrNudPower"
        Me.ucrNudPower.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPower.TabIndex = 17
        Me.ucrNudPower.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'grpChooseFunction
        '
        Me.grpChooseFunction.Controls.Add(Me.ucrNudPower)
        Me.grpChooseFunction.Controls.Add(Me.rdoIdentity)
        Me.grpChooseFunction.Controls.Add(Me.rdoNaturalLog)
        Me.grpChooseFunction.Controls.Add(Me.rdoPower)
        Me.grpChooseFunction.Controls.Add(Me.rdoSquareRoot)
        Me.grpChooseFunction.Controls.Add(Me.rdoLogBase10)
        Me.grpChooseFunction.Controls.Add(Me.ucrPnlChooseFunction)
        Me.grpChooseFunction.Location = New System.Drawing.Point(10, 10)
        Me.grpChooseFunction.Name = "grpChooseFunction"
        Me.grpChooseFunction.Size = New System.Drawing.Size(218, 184)
        Me.grpChooseFunction.TabIndex = 1
        Me.grpChooseFunction.TabStop = False
        Me.grpChooseFunction.Tag = "General_Functions"
        Me.grpChooseFunction.Text = "Choose Function"
        '
        'ucrPnlChooseFunction
        '
        Me.ucrPnlChooseFunction.Location = New System.Drawing.Point(6, 19)
        Me.ucrPnlChooseFunction.Name = "ucrPnlChooseFunction"
        Me.ucrPnlChooseFunction.Size = New System.Drawing.Size(168, 159)
        Me.ucrPnlChooseFunction.TabIndex = 3
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.Location = New System.Drawing.Point(12, 216)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(48, 13)
        Me.lblPreview.TabIndex = 3
        Me.lblPreview.Text = "Preview:"
        '
        'ucrInputPreview
        '
        Me.ucrInputPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputPreview.IsMultiline = False
        Me.ucrInputPreview.IsReadOnly = False
        Me.ucrInputPreview.Location = New System.Drawing.Point(66, 213)
        Me.ucrInputPreview.Name = "ucrInputPreview"
        Me.ucrInputPreview.Size = New System.Drawing.Size(158, 21)
        Me.ucrInputPreview.TabIndex = 4
        '
        'sdgVariableTransformations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 284)
        Me.Controls.Add(Me.ucrInputPreview)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.ucrButtonsSDGVarTransform)
        Me.Controls.Add(Me.grpChooseFunction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgVariableTransformations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Variable _Transformations"
        Me.Text = "Variable Transformations"
        Me.grpChooseFunction.ResumeLayout(False)
        Me.grpChooseFunction.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrButtonsSDGVarTransform As ucrButtonsSubdialogue
    Friend WithEvents rdoLogBase10 As RadioButton
    Friend WithEvents rdoSquareRoot As RadioButton
    Friend WithEvents rdoPower As RadioButton
    Friend WithEvents rdoNaturalLog As RadioButton
    Friend WithEvents rdoIdentity As RadioButton
    Friend WithEvents ucrNudPower As ucrNud
    Friend WithEvents grpChooseFunction As GroupBox
    Friend WithEvents ucrPnlChooseFunction As UcrPanel
    Friend WithEvents lblPreview As Label
    Friend WithEvents ucrInputPreview As ucrInputTextBox
End Class
