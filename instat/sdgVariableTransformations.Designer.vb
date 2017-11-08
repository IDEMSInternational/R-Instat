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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgVariableTransformations))
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
        resources.ApplyResources(Me.ucrButtonsSDGVarTransform, "ucrButtonsSDGVarTransform")
        Me.ucrButtonsSDGVarTransform.Name = "ucrButtonsSDGVarTransform"
        '
        'rdoLogBase10
        '
        resources.ApplyResources(Me.rdoLogBase10, "rdoLogBase10")
        Me.rdoLogBase10.Name = "rdoLogBase10"
        Me.rdoLogBase10.TabStop = True
        Me.rdoLogBase10.Tag = "Log_Base_10"
        Me.rdoLogBase10.UseVisualStyleBackColor = True
        '
        'rdoSquareRoot
        '
        resources.ApplyResources(Me.rdoSquareRoot, "rdoSquareRoot")
        Me.rdoSquareRoot.Name = "rdoSquareRoot"
        Me.rdoSquareRoot.TabStop = True
        Me.rdoSquareRoot.Tag = "Square_root"
        Me.rdoSquareRoot.UseVisualStyleBackColor = True
        '
        'rdoPower
        '
        resources.ApplyResources(Me.rdoPower, "rdoPower")
        Me.rdoPower.Name = "rdoPower"
        Me.rdoPower.TabStop = True
        Me.rdoPower.Tag = "Power"
        Me.rdoPower.UseVisualStyleBackColor = True
        '
        'rdoNaturalLog
        '
        resources.ApplyResources(Me.rdoNaturalLog, "rdoNaturalLog")
        Me.rdoNaturalLog.Name = "rdoNaturalLog"
        Me.rdoNaturalLog.TabStop = True
        Me.rdoNaturalLog.Tag = "Natural_log"
        Me.rdoNaturalLog.UseVisualStyleBackColor = True
        '
        'rdoIdentity
        '
        resources.ApplyResources(Me.rdoIdentity, "rdoIdentity")
        Me.rdoIdentity.Name = "rdoIdentity"
        Me.rdoIdentity.TabStop = True
        Me.rdoIdentity.Tag = "Identity"
        Me.rdoIdentity.UseVisualStyleBackColor = True
        '
        'ucrNudPower
        '
        Me.ucrNudPower.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPower.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudPower, "ucrNudPower")
        Me.ucrNudPower.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPower.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPower.Name = "ucrNudPower"
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
        resources.ApplyResources(Me.grpChooseFunction, "grpChooseFunction")
        Me.grpChooseFunction.Name = "grpChooseFunction"
        Me.grpChooseFunction.TabStop = False
        Me.grpChooseFunction.Tag = "General_Functions"
        '
        'ucrPnlChooseFunction
        '
        resources.ApplyResources(Me.ucrPnlChooseFunction, "ucrPnlChooseFunction")
        Me.ucrPnlChooseFunction.Name = "ucrPnlChooseFunction"
        '
        'lblPreview
        '
        resources.ApplyResources(Me.lblPreview, "lblPreview")
        Me.lblPreview.Name = "lblPreview"
        '
        'ucrInputPreview
        '
        Me.ucrInputPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputPreview.IsMultiline = False
        Me.ucrInputPreview.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPreview, "ucrInputPreview")
        Me.ucrInputPreview.Name = "ucrInputPreview"
        '
        'sdgVariableTransformations
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputPreview)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.ucrButtonsSDGVarTransform)
        Me.Controls.Add(Me.grpChooseFunction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgVariableTransformations"
        Me.Tag = "Variable _Transformations"
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
