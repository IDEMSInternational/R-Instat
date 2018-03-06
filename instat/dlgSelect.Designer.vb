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
Partial Class dlgSelect
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
        Me.ucrBase = New instat.ucrButtons()
        Me.grpSelectCriteria = New System.Windows.Forms.GroupBox()
        Me.rdoSelectbyfactor = New System.Windows.Forms.RadioButton()
        Me.rdoSelectbycondition = New System.Windows.Forms.RadioButton()
        Me.txtInto = New System.Windows.Forms.TextBox()
        Me.lblInto = New System.Windows.Forms.Label()
        Me.UcrSelectorAddRemove1 = New instat.ucrSelectorAddRemove()
        Me.UcrReceiverMultiple1 = New instat.ucrReceiverMultiple()
        Me.chkTranspose = New System.Windows.Forms.CheckBox()
        Me.chkAppend = New System.Windows.Forms.CheckBox()
        Me.grpCondition = New System.Windows.Forms.GroupBox()
        Me.chkShowCalculator = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.grpFactor = New System.Windows.Forms.GroupBox()
        Me.txtFactorLevels = New System.Windows.Forms.TextBox()
        Me.lblFactorLevels = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.cmbFactors = New System.Windows.Forms.ComboBox()
        Me.grpSelectCriteria.SuspendLayout()
        Me.grpCondition.SuspendLayout()
        Me.grpFactor.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 229)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 58)
        Me.ucrBase.TabIndex = 0
        '
        'grpSelectCriteria
        '
        Me.grpSelectCriteria.Controls.Add(Me.rdoSelectbyfactor)
        Me.grpSelectCriteria.Controls.Add(Me.rdoSelectbycondition)
        Me.grpSelectCriteria.Location = New System.Drawing.Point(12, 2)
        Me.grpSelectCriteria.Name = "grpSelectCriteria"
        Me.grpSelectCriteria.Size = New System.Drawing.Size(406, 32)
        Me.grpSelectCriteria.TabIndex = 5
        Me.grpSelectCriteria.TabStop = False
        '
        'rdoSelectbyfactor
        '
        Me.rdoSelectbyfactor.AutoSize = True
        Me.rdoSelectbyfactor.Location = New System.Drawing.Point(249, 11)
        Me.rdoSelectbyfactor.Name = "rdoSelectbyfactor"
        Me.rdoSelectbyfactor.Size = New System.Drawing.Size(133, 17)
        Me.rdoSelectbyfactor.TabIndex = 1
        Me.rdoSelectbyfactor.TabStop = True
        Me.rdoSelectbyfactor.Tag = "Select_by_factor_values"
        Me.rdoSelectbyfactor.Text = "Select by factor values"
        Me.rdoSelectbyfactor.UseVisualStyleBackColor = True
        '
        'rdoSelectbycondition
        '
        Me.rdoSelectbycondition.AutoSize = True
        Me.rdoSelectbycondition.Location = New System.Drawing.Point(6, 11)
        Me.rdoSelectbycondition.Name = "rdoSelectbycondition"
        Me.rdoSelectbycondition.Size = New System.Drawing.Size(115, 17)
        Me.rdoSelectbycondition.TabIndex = 0
        Me.rdoSelectbycondition.TabStop = True
        Me.rdoSelectbycondition.Tag = "Select_by_condition"
        Me.rdoSelectbycondition.Text = "Select by condition"
        Me.rdoSelectbycondition.UseVisualStyleBackColor = True
        '
        'txtInto
        '
        Me.txtInto.Location = New System.Drawing.Point(327, 56)
        Me.txtInto.Name = "txtInto"
        Me.txtInto.Size = New System.Drawing.Size(95, 20)
        Me.txtInto.TabIndex = 9
        '
        'lblInto
        '
        Me.lblInto.AutoSize = True
        Me.lblInto.Location = New System.Drawing.Point(358, 40)
        Me.lblInto.Name = "lblInto"
        Me.lblInto.Size = New System.Drawing.Size(25, 13)
        Me.lblInto.TabIndex = 8
        Me.lblInto.Tag = "Into"
        Me.lblInto.Text = "Into"
        '
        'UcrSelectorAddRemove1
        '
        Me.UcrSelectorAddRemove1.Location = New System.Drawing.Point(1, 40)
        Me.UcrSelectorAddRemove1.Name = "UcrSelectorAddRemove1"
        Me.UcrSelectorAddRemove1.Size = New System.Drawing.Size(203, 127)
        Me.UcrSelectorAddRemove1.TabIndex = 10
        '
        'UcrReceiverMultiple1
        '
        Me.UcrReceiverMultiple1.Location = New System.Drawing.Point(200, 40)
        Me.UcrReceiverMultiple1.Name = "UcrReceiverMultiple1"
        Me.UcrReceiverMultiple1.Size = New System.Drawing.Size(121, 128)
        Me.UcrReceiverMultiple1.TabIndex = 11
        '
        'chkTranspose
        '
        Me.chkTranspose.AutoSize = True
        Me.chkTranspose.Location = New System.Drawing.Point(328, 83)
        Me.chkTranspose.Name = "chkTranspose"
        Me.chkTranspose.Size = New System.Drawing.Size(76, 17)
        Me.chkTranspose.TabIndex = 12
        Me.chkTranspose.Tag = "Transpose"
        Me.chkTranspose.Text = "Transpose"
        Me.chkTranspose.UseVisualStyleBackColor = True
        '
        'chkAppend
        '
        Me.chkAppend.AutoSize = True
        Me.chkAppend.Location = New System.Drawing.Point(328, 107)
        Me.chkAppend.Name = "chkAppend"
        Me.chkAppend.Size = New System.Drawing.Size(63, 17)
        Me.chkAppend.TabIndex = 13
        Me.chkAppend.Tag = "Append"
        Me.chkAppend.Text = "Append"
        Me.chkAppend.UseVisualStyleBackColor = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.Add(Me.chkShowCalculator)
        Me.grpCondition.Controls.Add(Me.ComboBox1)
        Me.grpCondition.Location = New System.Drawing.Point(27, 174)
        Me.grpCondition.Name = "grpCondition"
        Me.grpCondition.Size = New System.Drawing.Size(356, 49)
        Me.grpCondition.TabIndex = 14
        Me.grpCondition.TabStop = False
        Me.grpCondition.Tag = "Condition_for_Selection"
        Me.grpCondition.Text = "Condition for Selection"
        '
        'chkShowCalculator
        '
        Me.chkShowCalculator.AutoSize = True
        Me.chkShowCalculator.Location = New System.Drawing.Point(216, 19)
        Me.chkShowCalculator.Name = "chkShowCalculator"
        Me.chkShowCalculator.Size = New System.Drawing.Size(103, 17)
        Me.chkShowCalculator.TabIndex = 1
        Me.chkShowCalculator.Tag = "Show_Calculator"
        Me.chkShowCalculator.Text = "Show Calculator"
        Me.chkShowCalculator.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(16, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'grpFactor
        '
        Me.grpFactor.Controls.Add(Me.txtFactorLevels)
        Me.grpFactor.Controls.Add(Me.lblFactorLevels)
        Me.grpFactor.Controls.Add(Me.lblFactor)
        Me.grpFactor.Controls.Add(Me.cmbFactors)
        Me.grpFactor.Location = New System.Drawing.Point(18, 174)
        Me.grpFactor.Name = "grpFactor"
        Me.grpFactor.Size = New System.Drawing.Size(354, 52)
        Me.grpFactor.TabIndex = 15
        Me.grpFactor.TabStop = False
        Me.grpFactor.Tag = "Factor_Values_for_Selection"
        Me.grpFactor.Text = "Factor Values for Selection"
        '
        'txtFactorLevels
        '
        Me.txtFactorLevels.Location = New System.Drawing.Point(224, 19)
        Me.txtFactorLevels.Name = "txtFactorLevels"
        Me.txtFactorLevels.Size = New System.Drawing.Size(100, 20)
        Me.txtFactorLevels.TabIndex = 4
        '
        'lblFactorLevels
        '
        Me.lblFactorLevels.AutoSize = True
        Me.lblFactorLevels.Location = New System.Drawing.Point(173, 15)
        Me.lblFactorLevels.Name = "lblFactorLevels"
        Me.lblFactorLevels.Size = New System.Drawing.Size(43, 26)
        Me.lblFactorLevels.TabIndex = 3
        Me.lblFactorLevels.Tag = "Factor_Levels"
        Me.lblFactorLevels.Text = "Factor  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Levels"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(6, 23)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(37, 13)
        Me.lblFactor.TabIndex = 2
        Me.lblFactor.Tag = "Factor"
        Me.lblFactor.Text = "Factor"
        '
        'cmbFactors
        '
        Me.cmbFactors.FormattingEnabled = True
        Me.cmbFactors.Location = New System.Drawing.Point(49, 20)
        Me.cmbFactors.Name = "cmbFactors"
        Me.cmbFactors.Size = New System.Drawing.Size(85, 21)
        Me.cmbFactors.TabIndex = 0
        '
        'dlgSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 286)
        Me.Controls.Add(Me.grpFactor)
        Me.Controls.Add(Me.grpCondition)
        Me.Controls.Add(Me.chkAppend)
        Me.Controls.Add(Me.chkTranspose)
        Me.Controls.Add(Me.UcrReceiverMultiple1)
        Me.Controls.Add(Me.UcrSelectorAddRemove1)
        Me.Controls.Add(Me.txtInto)
        Me.Controls.Add(Me.lblInto)
        Me.Controls.Add(Me.grpSelectCriteria)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Select"
        Me.Text = "Select"
        Me.grpSelectCriteria.ResumeLayout(False)
        Me.grpSelectCriteria.PerformLayout()
        Me.grpCondition.ResumeLayout(False)
        Me.grpCondition.PerformLayout()
        Me.grpFactor.ResumeLayout(False)
        Me.grpFactor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpSelectCriteria As GroupBox
    Friend WithEvents rdoSelectbyfactor As RadioButton
    Friend WithEvents rdoSelectbycondition As RadioButton
    Friend WithEvents txtInto As TextBox
    Friend WithEvents lblInto As Label
    Friend WithEvents UcrSelectorAddRemove1 As ucrSelectorAddRemove
    Friend WithEvents UcrReceiverMultiple1 As ucrReceiverMultiple
    Friend WithEvents chkTranspose As CheckBox
    Friend WithEvents chkAppend As CheckBox
    Friend WithEvents grpCondition As GroupBox
    Friend WithEvents grpFactor As GroupBox
    Friend WithEvents txtFactorLevels As TextBox
    Friend WithEvents lblFactorLevels As Label
    Friend WithEvents lblFactor As Label
    Friend WithEvents cmbFactors As ComboBox
    Friend WithEvents chkShowCalculator As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
