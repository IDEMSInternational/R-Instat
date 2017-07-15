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
Partial Class dlgTransform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grpCalculatedTransformations = New System.Windows.Forms.GroupBox()
        Me.grpPercentageTransformations = New System.Windows.Forms.GroupBox()
        Me.lbl01Adjustment = New System.Windows.Forms.Label()
        Me.rdoProbit = New System.Windows.Forms.RadioButton()
        Me.lblAdjustment = New System.Windows.Forms.Label()
        Me.txtAdjustment = New System.Windows.Forms.TextBox()
        Me.rdoLogit = New System.Windows.Forms.RadioButton()
        Me.rdoAngular = New System.Windows.Forms.RadioButton()
        Me.chkInverse = New System.Windows.Forms.CheckBox()
        Me.grpCircularTransformations = New System.Windows.Forms.GroupBox()
        Me.cmbCycleLength = New System.Windows.Forms.ComboBox()
        Me.lblHarmonic = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblCycleLength = New System.Windows.Forms.Label()
        Me.rdoCosine = New System.Windows.Forms.RadioButton()
        Me.rdoSine = New System.Windows.Forms.RadioButton()
        Me.grpNonNegativeTransformations = New System.Windows.Forms.GroupBox()
        Me.lblConstant = New System.Windows.Forms.Label()
        Me.lblPowerValue = New System.Windows.Forms.Label()
        Me.txtPowerValue = New System.Windows.Forms.TextBox()
        Me.lblZeroAdjustment = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.rdoPower = New System.Windows.Forms.RadioButton()
        Me.rdoLogBase10 = New System.Windows.Forms.RadioButton()
        Me.rdoNaturalLog = New System.Windows.Forms.RadioButton()
        Me.rdoSquareRoot = New System.Windows.Forms.RadioButton()
        Me.grpTypeofdata = New System.Windows.Forms.GroupBox()
        Me.rdoProportion = New System.Windows.Forms.RadioButton()
        Me.rdoPercentage = New System.Windows.Forms.RadioButton()
        Me.rdoCircular = New System.Windows.Forms.RadioButton()
        Me.rdoNonNegative = New System.Windows.Forms.RadioButton()
        Me.grpTransformationType = New System.Windows.Forms.GroupBox()
        Me.rdoOtherTransformations = New System.Windows.Forms.RadioButton()
        Me.rdoCommonTransformations = New System.Windows.Forms.RadioButton()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblInto = New System.Windows.Forms.Label()
        Me.txtInto = New System.Windows.Forms.TextBox()
        Me.cmdPreview = New System.Windows.Forms.Button()
        Me.cboPreview = New System.Windows.Forms.ComboBox()
        Me.grpOtherTransformations = New System.Windows.Forms.GroupBox()
        Me.grpLag = New System.Windows.Forms.GroupBox()
        Me.lblRows = New System.Windows.Forms.Label()
        Me.nudLag = New System.Windows.Forms.NumericUpDown()
        Me.grpTransformationsOther = New System.Windows.Forms.GroupBox()
        Me.rdoDifference = New System.Windows.Forms.RadioButton()
        Me.rdoLag = New System.Windows.Forms.RadioButton()
        Me.rdoStandardise = New System.Windows.Forms.RadioButton()
        Me.rdoNormalScore = New System.Windows.Forms.RadioButton()
        Me.rdoSort = New System.Windows.Forms.RadioButton()
        Me.rdoRank = New System.Windows.Forms.RadioButton()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverFrom = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpCalculatedTransformations.SuspendLayout()
        Me.grpPercentageTransformations.SuspendLayout()
        Me.grpCircularTransformations.SuspendLayout()
        Me.grpNonNegativeTransformations.SuspendLayout()
        Me.grpTypeofdata.SuspendLayout()
        Me.grpTransformationType.SuspendLayout()
        Me.grpOtherTransformations.SuspendLayout()
        Me.grpLag.SuspendLayout()
        CType(Me.nudLag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTransformationsOther.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCalculatedTransformations
        '
        Me.grpCalculatedTransformations.Controls.Add(Me.grpPercentageTransformations)
        Me.grpCalculatedTransformations.Controls.Add(Me.chkInverse)
        Me.grpCalculatedTransformations.Controls.Add(Me.grpCircularTransformations)
        Me.grpCalculatedTransformations.Controls.Add(Me.grpNonNegativeTransformations)
        Me.grpCalculatedTransformations.Controls.Add(Me.grpTypeofdata)
        Me.grpCalculatedTransformations.Location = New System.Drawing.Point(10, 183)
        Me.grpCalculatedTransformations.Name = "grpCalculatedTransformations"
        Me.grpCalculatedTransformations.Size = New System.Drawing.Size(292, 198)
        Me.grpCalculatedTransformations.TabIndex = 3
        Me.grpCalculatedTransformations.TabStop = False
        Me.grpCalculatedTransformations.Tag = "Calculated_Transformations"
        Me.grpCalculatedTransformations.Text = "Calculated Transformations"
        '
        'grpPercentageTransformations
        '
        Me.grpPercentageTransformations.Controls.Add(Me.lbl01Adjustment)
        Me.grpPercentageTransformations.Controls.Add(Me.rdoProbit)
        Me.grpPercentageTransformations.Controls.Add(Me.lblAdjustment)
        Me.grpPercentageTransformations.Controls.Add(Me.txtAdjustment)
        Me.grpPercentageTransformations.Controls.Add(Me.rdoLogit)
        Me.grpPercentageTransformations.Controls.Add(Me.rdoAngular)
        Me.grpPercentageTransformations.Location = New System.Drawing.Point(5, 98)
        Me.grpPercentageTransformations.Name = "grpPercentageTransformations"
        Me.grpPercentageTransformations.Size = New System.Drawing.Size(257, 81)
        Me.grpPercentageTransformations.TabIndex = 12
        Me.grpPercentageTransformations.TabStop = False
        '
        'lbl01Adjustment
        '
        Me.lbl01Adjustment.AutoSize = True
        Me.lbl01Adjustment.Location = New System.Drawing.Point(116, 32)
        Me.lbl01Adjustment.Name = "lbl01Adjustment"
        Me.lbl01Adjustment.Size = New System.Drawing.Size(98, 13)
        Me.lbl01Adjustment.TabIndex = 10
        Me.lbl01Adjustment.Tag = "0_and_1_Adjustment"
        Me.lbl01Adjustment.Text = "0 and 1 Adjustment"
        '
        'rdoProbit
        '
        Me.rdoProbit.AutoSize = True
        Me.rdoProbit.Location = New System.Drawing.Point(6, 59)
        Me.rdoProbit.Name = "rdoProbit"
        Me.rdoProbit.Size = New System.Drawing.Size(52, 17)
        Me.rdoProbit.TabIndex = 9
        Me.rdoProbit.TabStop = True
        Me.rdoProbit.Tag = "Probit"
        Me.rdoProbit.Text = "Probit"
        Me.rdoProbit.UseVisualStyleBackColor = True
        '
        'lblAdjustment
        '
        Me.lblAdjustment.AutoSize = True
        Me.lblAdjustment.Location = New System.Drawing.Point(88, 32)
        Me.lblAdjustment.Name = "lblAdjustment"
        Me.lblAdjustment.Size = New System.Drawing.Size(126, 13)
        Me.lblAdjustment.TabIndex = 7
        Me.lblAdjustment.Tag = "0%_and_100%_Adjustment"
        Me.lblAdjustment.Text = "0% and 100% Adjustment"
        '
        'txtAdjustment
        '
        Me.txtAdjustment.Location = New System.Drawing.Point(220, 29)
        Me.txtAdjustment.Name = "txtAdjustment"
        Me.txtAdjustment.Size = New System.Drawing.Size(25, 20)
        Me.txtAdjustment.TabIndex = 6
        Me.txtAdjustment.Text = "0"
        '
        'rdoLogit
        '
        Me.rdoLogit.AutoSize = True
        Me.rdoLogit.Location = New System.Drawing.Point(6, 35)
        Me.rdoLogit.Name = "rdoLogit"
        Me.rdoLogit.Size = New System.Drawing.Size(48, 17)
        Me.rdoLogit.TabIndex = 2
        Me.rdoLogit.TabStop = True
        Me.rdoLogit.Tag = "Logit"
        Me.rdoLogit.Text = "Logit"
        Me.rdoLogit.UseVisualStyleBackColor = True
        '
        'rdoAngular
        '
        Me.rdoAngular.AutoSize = True
        Me.rdoAngular.Location = New System.Drawing.Point(6, 11)
        Me.rdoAngular.Name = "rdoAngular"
        Me.rdoAngular.Size = New System.Drawing.Size(61, 17)
        Me.rdoAngular.TabIndex = 1
        Me.rdoAngular.TabStop = True
        Me.rdoAngular.Tag = "Angular"
        Me.rdoAngular.Text = "Angular"
        Me.rdoAngular.UseVisualStyleBackColor = True
        '
        'chkInverse
        '
        Me.chkInverse.AutoSize = True
        Me.chkInverse.Location = New System.Drawing.Point(6, 175)
        Me.chkInverse.Name = "chkInverse"
        Me.chkInverse.Size = New System.Drawing.Size(61, 17)
        Me.chkInverse.TabIndex = 2
        Me.chkInverse.Tag = "Inverse"
        Me.chkInverse.Text = "Inverse"
        Me.chkInverse.UseVisualStyleBackColor = True
        '
        'grpCircularTransformations
        '
        Me.grpCircularTransformations.Controls.Add(Me.cmbCycleLength)
        Me.grpCircularTransformations.Controls.Add(Me.lblHarmonic)
        Me.grpCircularTransformations.Controls.Add(Me.TextBox1)
        Me.grpCircularTransformations.Controls.Add(Me.lblCycleLength)
        Me.grpCircularTransformations.Controls.Add(Me.rdoCosine)
        Me.grpCircularTransformations.Controls.Add(Me.rdoSine)
        Me.grpCircularTransformations.Location = New System.Drawing.Point(5, 92)
        Me.grpCircularTransformations.Name = "grpCircularTransformations"
        Me.grpCircularTransformations.Size = New System.Drawing.Size(257, 81)
        Me.grpCircularTransformations.TabIndex = 11
        Me.grpCircularTransformations.TabStop = False
        '
        'cmbCycleLength
        '
        Me.cmbCycleLength.FormattingEnabled = True
        Me.cmbCycleLength.Items.AddRange(New Object() {"360", "365", "366", "24"})
        Me.cmbCycleLength.Location = New System.Drawing.Point(225, 19)
        Me.cmbCycleLength.Name = "cmbCycleLength"
        Me.cmbCycleLength.Size = New System.Drawing.Size(26, 21)
        Me.cmbCycleLength.TabIndex = 8
        '
        'lblHarmonic
        '
        Me.lblHarmonic.AutoSize = True
        Me.lblHarmonic.Location = New System.Drawing.Point(152, 55)
        Me.lblHarmonic.Name = "lblHarmonic"
        Me.lblHarmonic.Size = New System.Drawing.Size(52, 13)
        Me.lblHarmonic.TabIndex = 7
        Me.lblHarmonic.Tag = "Harmonic"
        Me.lblHarmonic.Text = "Harmonic"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(225, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(25, 20)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "1"
        '
        'lblCycleLength
        '
        Me.lblCycleLength.AutoSize = True
        Me.lblCycleLength.Location = New System.Drawing.Point(152, 23)
        Me.lblCycleLength.Name = "lblCycleLength"
        Me.lblCycleLength.Size = New System.Drawing.Size(69, 13)
        Me.lblCycleLength.TabIndex = 5
        Me.lblCycleLength.Tag = "Cycle_Length"
        Me.lblCycleLength.Text = "Cycle Length"
        '
        'rdoCosine
        '
        Me.rdoCosine.AutoSize = True
        Me.rdoCosine.Location = New System.Drawing.Point(6, 47)
        Me.rdoCosine.Name = "rdoCosine"
        Me.rdoCosine.Size = New System.Drawing.Size(57, 17)
        Me.rdoCosine.TabIndex = 2
        Me.rdoCosine.TabStop = True
        Me.rdoCosine.Tag = "Cosine"
        Me.rdoCosine.Text = "Cosine"
        Me.rdoCosine.UseVisualStyleBackColor = True
        '
        'rdoSine
        '
        Me.rdoSine.AutoSize = True
        Me.rdoSine.Location = New System.Drawing.Point(6, 19)
        Me.rdoSine.Name = "rdoSine"
        Me.rdoSine.Size = New System.Drawing.Size(46, 17)
        Me.rdoSine.TabIndex = 1
        Me.rdoSine.TabStop = True
        Me.rdoSine.Tag = "Sine"
        Me.rdoSine.Text = "Sine"
        Me.rdoSine.UseVisualStyleBackColor = True
        '
        'grpNonNegativeTransformations
        '
        Me.grpNonNegativeTransformations.Controls.Add(Me.lblConstant)
        Me.grpNonNegativeTransformations.Controls.Add(Me.lblPowerValue)
        Me.grpNonNegativeTransformations.Controls.Add(Me.txtPowerValue)
        Me.grpNonNegativeTransformations.Controls.Add(Me.lblZeroAdjustment)
        Me.grpNonNegativeTransformations.Controls.Add(Me.txtValue)
        Me.grpNonNegativeTransformations.Controls.Add(Me.rdoPower)
        Me.grpNonNegativeTransformations.Controls.Add(Me.rdoLogBase10)
        Me.grpNonNegativeTransformations.Controls.Add(Me.rdoNaturalLog)
        Me.grpNonNegativeTransformations.Controls.Add(Me.rdoSquareRoot)
        Me.grpNonNegativeTransformations.Location = New System.Drawing.Point(6, 90)
        Me.grpNonNegativeTransformations.Name = "grpNonNegativeTransformations"
        Me.grpNonNegativeTransformations.Size = New System.Drawing.Size(257, 81)
        Me.grpNonNegativeTransformations.TabIndex = 1
        Me.grpNonNegativeTransformations.TabStop = False
        '
        'lblConstant
        '
        Me.lblConstant.AutoSize = True
        Me.lblConstant.Location = New System.Drawing.Point(170, 37)
        Me.lblConstant.Name = "lblConstant"
        Me.lblConstant.Size = New System.Drawing.Size(49, 13)
        Me.lblConstant.TabIndex = 8
        Me.lblConstant.Tag = "Constant"
        Me.lblConstant.Text = "Constant"
        '
        'lblPowerValue
        '
        Me.lblPowerValue.AutoSize = True
        Me.lblPowerValue.Location = New System.Drawing.Point(152, 60)
        Me.lblPowerValue.Name = "lblPowerValue"
        Me.lblPowerValue.Size = New System.Drawing.Size(67, 13)
        Me.lblPowerValue.TabIndex = 7
        Me.lblPowerValue.Tag = "Power_Value"
        Me.lblPowerValue.Text = "Power Value"
        '
        'txtPowerValue
        '
        Me.txtPowerValue.Location = New System.Drawing.Point(225, 56)
        Me.txtPowerValue.Name = "txtPowerValue"
        Me.txtPowerValue.Size = New System.Drawing.Size(25, 20)
        Me.txtPowerValue.TabIndex = 6
        Me.txtPowerValue.Text = "1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblZeroAdjustment
        '
        Me.lblZeroAdjustment.AutoSize = True
        Me.lblZeroAdjustment.Location = New System.Drawing.Point(134, 37)
        Me.lblZeroAdjustment.Name = "lblZeroAdjustment"
        Me.lblZeroAdjustment.Size = New System.Drawing.Size(84, 13)
        Me.lblZeroAdjustment.TabIndex = 5
        Me.lblZeroAdjustment.Tag = "Zero_Adjustment"
        Me.lblZeroAdjustment.Text = "Zero Adjustment"
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(225, 33)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(25, 20)
        Me.txtValue.TabIndex = 4
        Me.txtValue.Text = "0"
        '
        'rdoPower
        '
        Me.rdoPower.AutoSize = True
        Me.rdoPower.Location = New System.Drawing.Point(195, 12)
        Me.rdoPower.Name = "rdoPower"
        Me.rdoPower.Size = New System.Drawing.Size(55, 17)
        Me.rdoPower.TabIndex = 3
        Me.rdoPower.TabStop = True
        Me.rdoPower.Tag = "Power"
        Me.rdoPower.Text = "Power"
        Me.rdoPower.UseVisualStyleBackColor = True
        '
        'rdoLogBase10
        '
        Me.rdoLogBase10.AutoSize = True
        Me.rdoLogBase10.Location = New System.Drawing.Point(6, 58)
        Me.rdoLogBase10.Name = "rdoLogBase10"
        Me.rdoLogBase10.Size = New System.Drawing.Size(85, 17)
        Me.rdoLogBase10.TabIndex = 2
        Me.rdoLogBase10.TabStop = True
        Me.rdoLogBase10.Tag = "Log_Base_10"
        Me.rdoLogBase10.Text = "Log Base 10"
        Me.rdoLogBase10.UseVisualStyleBackColor = True
        '
        'rdoNaturalLog
        '
        Me.rdoNaturalLog.AutoSize = True
        Me.rdoNaturalLog.Location = New System.Drawing.Point(6, 36)
        Me.rdoNaturalLog.Name = "rdoNaturalLog"
        Me.rdoNaturalLog.Size = New System.Drawing.Size(80, 17)
        Me.rdoNaturalLog.TabIndex = 1
        Me.rdoNaturalLog.TabStop = True
        Me.rdoNaturalLog.Tag = "Natural_Log"
        Me.rdoNaturalLog.Text = "Natural Log"
        Me.rdoNaturalLog.UseVisualStyleBackColor = True
        '
        'rdoSquareRoot
        '
        Me.rdoSquareRoot.AutoSize = True
        Me.rdoSquareRoot.Location = New System.Drawing.Point(6, 12)
        Me.rdoSquareRoot.Name = "rdoSquareRoot"
        Me.rdoSquareRoot.Size = New System.Drawing.Size(80, 17)
        Me.rdoSquareRoot.TabIndex = 0
        Me.rdoSquareRoot.TabStop = True
        Me.rdoSquareRoot.Tag = "Square_root"
        Me.rdoSquareRoot.Text = "Square root"
        Me.rdoSquareRoot.UseVisualStyleBackColor = True
        '
        'grpTypeofdata
        '
        Me.grpTypeofdata.Controls.Add(Me.rdoProportion)
        Me.grpTypeofdata.Controls.Add(Me.rdoPercentage)
        Me.grpTypeofdata.Controls.Add(Me.rdoCircular)
        Me.grpTypeofdata.Controls.Add(Me.rdoNonNegative)
        Me.grpTypeofdata.Location = New System.Drawing.Point(5, 20)
        Me.grpTypeofdata.Name = "grpTypeofdata"
        Me.grpTypeofdata.Size = New System.Drawing.Size(260, 70)
        Me.grpTypeofdata.TabIndex = 0
        Me.grpTypeofdata.TabStop = False
        Me.grpTypeofdata.Tag = "Type_of_data"
        Me.grpTypeofdata.Text = "Type of data"
        '
        'rdoProportion
        '
        Me.rdoProportion.AutoSize = True
        Me.rdoProportion.Location = New System.Drawing.Point(128, 41)
        Me.rdoProportion.Name = "rdoProportion"
        Me.rdoProportion.Size = New System.Drawing.Size(73, 17)
        Me.rdoProportion.TabIndex = 3
        Me.rdoProportion.TabStop = True
        Me.rdoProportion.Tag = "Proportion"
        Me.rdoProportion.Text = "Proportion"
        Me.rdoProportion.UseVisualStyleBackColor = True
        '
        'rdoPercentage
        '
        Me.rdoPercentage.AutoSize = True
        Me.rdoPercentage.Location = New System.Drawing.Point(128, 17)
        Me.rdoPercentage.Name = "rdoPercentage"
        Me.rdoPercentage.Size = New System.Drawing.Size(80, 17)
        Me.rdoPercentage.TabIndex = 2
        Me.rdoPercentage.TabStop = True
        Me.rdoPercentage.Tag = "Percentage"
        Me.rdoPercentage.Text = "Percentage"
        Me.rdoPercentage.UseVisualStyleBackColor = True
        '
        'rdoCircular
        '
        Me.rdoCircular.AutoSize = True
        Me.rdoCircular.Location = New System.Drawing.Point(7, 41)
        Me.rdoCircular.Name = "rdoCircular"
        Me.rdoCircular.Size = New System.Drawing.Size(60, 17)
        Me.rdoCircular.TabIndex = 1
        Me.rdoCircular.TabStop = True
        Me.rdoCircular.Tag = "Circular"
        Me.rdoCircular.Text = "Circular"
        Me.rdoCircular.UseVisualStyleBackColor = True
        '
        'rdoNonNegative
        '
        Me.rdoNonNegative.AutoSize = True
        Me.rdoNonNegative.Location = New System.Drawing.Point(7, 17)
        Me.rdoNonNegative.Name = "rdoNonNegative"
        Me.rdoNonNegative.Size = New System.Drawing.Size(91, 17)
        Me.rdoNonNegative.TabIndex = 0
        Me.rdoNonNegative.TabStop = True
        Me.rdoNonNegative.Tag = "Non_Negative"
        Me.rdoNonNegative.Text = "Non-Negative"
        Me.rdoNonNegative.UseVisualStyleBackColor = True
        '
        'grpTransformationType
        '
        Me.grpTransformationType.Controls.Add(Me.rdoOtherTransformations)
        Me.grpTransformationType.Controls.Add(Me.rdoCommonTransformations)
        Me.grpTransformationType.Location = New System.Drawing.Point(10, 0)
        Me.grpTransformationType.Name = "grpTransformationType"
        Me.grpTransformationType.Size = New System.Drawing.Size(389, 42)
        Me.grpTransformationType.TabIndex = 4
        Me.grpTransformationType.TabStop = False
        '
        'rdoOtherTransformations
        '
        Me.rdoOtherTransformations.AutoSize = True
        Me.rdoOtherTransformations.Location = New System.Drawing.Point(249, 11)
        Me.rdoOtherTransformations.Name = "rdoOtherTransformations"
        Me.rdoOtherTransformations.Size = New System.Drawing.Size(129, 17)
        Me.rdoOtherTransformations.TabIndex = 1
        Me.rdoOtherTransformations.TabStop = True
        Me.rdoOtherTransformations.Tag = "Other_Transformations"
        Me.rdoOtherTransformations.Text = "Other Transformations"
        Me.rdoOtherTransformations.UseVisualStyleBackColor = True
        '
        'rdoCommonTransformations
        '
        Me.rdoCommonTransformations.AutoSize = True
        Me.rdoCommonTransformations.Location = New System.Drawing.Point(6, 11)
        Me.rdoCommonTransformations.Name = "rdoCommonTransformations"
        Me.rdoCommonTransformations.Size = New System.Drawing.Size(144, 17)
        Me.rdoCommonTransformations.TabIndex = 0
        Me.rdoCommonTransformations.TabStop = True
        Me.rdoCommonTransformations.Tag = "Common_Transformations"
        Me.rdoCommonTransformations.Text = "Common Transformations"
        Me.rdoCommonTransformations.UseVisualStyleBackColor = True
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(255, 65)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblFrom.TabIndex = 5
        Me.lblFrom.Tag = "From"
        Me.lblFrom.Text = "From"
        '
        'lblInto
        '
        Me.lblInto.AutoSize = True
        Me.lblInto.Location = New System.Drawing.Point(255, 102)
        Me.lblInto.Name = "lblInto"
        Me.lblInto.Size = New System.Drawing.Size(25, 13)
        Me.lblInto.TabIndex = 6
        Me.lblInto.Tag = "Into"
        Me.lblInto.Text = "Into"
        '
        'txtInto
        '
        Me.txtInto.Location = New System.Drawing.Point(292, 99)
        Me.txtInto.Name = "txtInto"
        Me.txtInto.Size = New System.Drawing.Size(105, 20)
        Me.txtInto.TabIndex = 7
        '
        'cmdPreview
        '
        Me.cmdPreview.Location = New System.Drawing.Point(10, 392)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(75, 23)
        Me.cmdPreview.TabIndex = 8
        Me.cmdPreview.Tag = "Preview"
        Me.cmdPreview.Text = "Preview"
        Me.cmdPreview.UseVisualStyleBackColor = True
        '
        'cboPreview
        '
        Me.cboPreview.FormattingEnabled = True
        Me.cboPreview.Location = New System.Drawing.Point(95, 394)
        Me.cboPreview.Name = "cboPreview"
        Me.cboPreview.Size = New System.Drawing.Size(280, 21)
        Me.cboPreview.TabIndex = 9
        '
        'grpOtherTransformations
        '
        Me.grpOtherTransformations.Controls.Add(Me.grpLag)
        Me.grpOtherTransformations.Controls.Add(Me.grpTransformationsOther)
        Me.grpOtherTransformations.Location = New System.Drawing.Point(10, 183)
        Me.grpOtherTransformations.Name = "grpOtherTransformations"
        Me.grpOtherTransformations.Size = New System.Drawing.Size(292, 179)
        Me.grpOtherTransformations.TabIndex = 10
        Me.grpOtherTransformations.TabStop = False
        Me.grpOtherTransformations.Tag = "Other_Transformations"
        Me.grpOtherTransformations.Text = "Other Transformations"
        '
        'grpLag
        '
        Me.grpLag.Controls.Add(Me.lblRows)
        Me.grpLag.Controls.Add(Me.nudLag)
        Me.grpLag.Location = New System.Drawing.Point(135, 97)
        Me.grpLag.Name = "grpLag"
        Me.grpLag.Size = New System.Drawing.Size(104, 41)
        Me.grpLag.TabIndex = 12
        Me.grpLag.TabStop = False
        Me.grpLag.Tag = "Lag"
        Me.grpLag.Text = "Lag"
        '
        'lblRows
        '
        Me.lblRows.AutoSize = True
        Me.lblRows.Location = New System.Drawing.Point(67, 23)
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Size = New System.Drawing.Size(35, 13)
        Me.lblRows.TabIndex = 1
        Me.lblRows.Tag = "rows"
        Me.lblRows.Text = "row(s)"
        '
        'nudLag
        '
        Me.nudLag.AllowDrop = True
        Me.nudLag.Location = New System.Drawing.Point(29, 17)
        Me.nudLag.Name = "nudLag"
        Me.nudLag.Size = New System.Drawing.Size(31, 20)
        Me.nudLag.TabIndex = 0
        Me.nudLag.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'grpTransformationsOther
        '
        Me.grpTransformationsOther.Controls.Add(Me.rdoDifference)
        Me.grpTransformationsOther.Controls.Add(Me.rdoLag)
        Me.grpTransformationsOther.Controls.Add(Me.rdoStandardise)
        Me.grpTransformationsOther.Controls.Add(Me.rdoNormalScore)
        Me.grpTransformationsOther.Controls.Add(Me.rdoSort)
        Me.grpTransformationsOther.Controls.Add(Me.rdoRank)
        Me.grpTransformationsOther.Location = New System.Drawing.Point(6, 14)
        Me.grpTransformationsOther.Name = "grpTransformationsOther"
        Me.grpTransformationsOther.Size = New System.Drawing.Size(114, 157)
        Me.grpTransformationsOther.TabIndex = 1
        Me.grpTransformationsOther.TabStop = False
        '
        'rdoDifference
        '
        Me.rdoDifference.AutoSize = True
        Me.rdoDifference.Location = New System.Drawing.Point(6, 135)
        Me.rdoDifference.Name = "rdoDifference"
        Me.rdoDifference.Size = New System.Drawing.Size(74, 17)
        Me.rdoDifference.TabIndex = 5
        Me.rdoDifference.TabStop = True
        Me.rdoDifference.Tag = "Difference"
        Me.rdoDifference.Text = "Difference"
        Me.rdoDifference.UseVisualStyleBackColor = True
        '
        'rdoLag
        '
        Me.rdoLag.AutoSize = True
        Me.rdoLag.Location = New System.Drawing.Point(6, 110)
        Me.rdoLag.Name = "rdoLag"
        Me.rdoLag.Size = New System.Drawing.Size(43, 17)
        Me.rdoLag.TabIndex = 4
        Me.rdoLag.TabStop = True
        Me.rdoLag.Tag = "Lag"
        Me.rdoLag.Text = "Lag"
        Me.rdoLag.UseVisualStyleBackColor = True
        '
        'rdoStandardise
        '
        Me.rdoStandardise.AutoSize = True
        Me.rdoStandardise.Location = New System.Drawing.Point(6, 85)
        Me.rdoStandardise.Name = "rdoStandardise"
        Me.rdoStandardise.Size = New System.Drawing.Size(81, 17)
        Me.rdoStandardise.TabIndex = 3
        Me.rdoStandardise.TabStop = True
        Me.rdoStandardise.Tag = "Standardise"
        Me.rdoStandardise.Text = "Standardise"
        Me.rdoStandardise.UseVisualStyleBackColor = True
        '
        'rdoNormalScore
        '
        Me.rdoNormalScore.AutoSize = True
        Me.rdoNormalScore.Location = New System.Drawing.Point(6, 60)
        Me.rdoNormalScore.Name = "rdoNormalScore"
        Me.rdoNormalScore.Size = New System.Drawing.Size(89, 17)
        Me.rdoNormalScore.TabIndex = 2
        Me.rdoNormalScore.TabStop = True
        Me.rdoNormalScore.Tag = "Normal_Score"
        Me.rdoNormalScore.Text = "Normal Score"
        Me.rdoNormalScore.UseVisualStyleBackColor = True
        '
        'rdoSort
        '
        Me.rdoSort.AutoSize = True
        Me.rdoSort.Location = New System.Drawing.Point(6, 35)
        Me.rdoSort.Name = "rdoSort"
        Me.rdoSort.Size = New System.Drawing.Size(44, 17)
        Me.rdoSort.TabIndex = 1
        Me.rdoSort.TabStop = True
        Me.rdoSort.Tag = "Sort"
        Me.rdoSort.Text = "Sort"
        Me.rdoSort.UseVisualStyleBackColor = True
        '
        'rdoRank
        '
        Me.rdoRank.AutoSize = True
        Me.rdoRank.Location = New System.Drawing.Point(6, 10)
        Me.rdoRank.Name = "rdoRank"
        Me.rdoRank.Size = New System.Drawing.Size(51, 17)
        Me.rdoRank.TabIndex = 0
        Me.rdoRank.TabStop = True
        Me.rdoRank.Tag = "Rank"
        Me.rdoRank.Text = "Rank"
        Me.rdoRank.UseVisualStyleBackColor = True
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(10, 48)
        Me.ucrAddRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(203, 127)
        Me.ucrAddRemove.TabIndex = 2
        '
        'ucrReceiverFrom
        '
        Me.ucrReceiverFrom.Location = New System.Drawing.Point(292, 65)
        Me.ucrReceiverFrom.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFrom.Name = "ucrReceiverFrom"
        Me.ucrReceiverFrom.Selector = Nothing
        Me.ucrReceiverFrom.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverFrom.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 420)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'dlgTransform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 474)
        Me.Controls.Add(Me.grpOtherTransformations)
        Me.Controls.Add(Me.cboPreview)
        Me.Controls.Add(Me.cmdPreview)
        Me.Controls.Add(Me.txtInto)
        Me.Controls.Add(Me.lblInto)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.grpTransformationType)
        Me.Controls.Add(Me.grpCalculatedTransformations)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrReceiverFrom)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgTransform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Transform"
        Me.Text = "Transform"
        Me.grpCalculatedTransformations.ResumeLayout(False)
        Me.grpCalculatedTransformations.PerformLayout()
        Me.grpPercentageTransformations.ResumeLayout(False)
        Me.grpPercentageTransformations.PerformLayout()
        Me.grpCircularTransformations.ResumeLayout(False)
        Me.grpCircularTransformations.PerformLayout()
        Me.grpNonNegativeTransformations.ResumeLayout(False)
        Me.grpNonNegativeTransformations.PerformLayout()
        Me.grpTypeofdata.ResumeLayout(False)
        Me.grpTypeofdata.PerformLayout()
        Me.grpTransformationType.ResumeLayout(False)
        Me.grpTransformationType.PerformLayout()
        Me.grpOtherTransformations.ResumeLayout(False)
        Me.grpLag.ResumeLayout(False)
        Me.grpLag.PerformLayout()
        CType(Me.nudLag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTransformationsOther.ResumeLayout(False)
        Me.grpTransformationsOther.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverFrom As ucrReceiverSingle
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents grpCalculatedTransformations As GroupBox
    Friend WithEvents grpNonNegativeTransformations As GroupBox
    Friend WithEvents rdoPower As RadioButton
    Friend WithEvents rdoLogBase10 As RadioButton
    Friend WithEvents rdoNaturalLog As RadioButton
    Friend WithEvents rdoSquareRoot As RadioButton
    Friend WithEvents grpTypeofdata As GroupBox
    Friend WithEvents rdoProportion As RadioButton
    Friend WithEvents rdoPercentage As RadioButton
    Friend WithEvents rdoCircular As RadioButton
    Friend WithEvents rdoNonNegative As RadioButton
    Friend WithEvents chkInverse As CheckBox
    Friend WithEvents lblZeroAdjustment As Label
    Friend WithEvents txtValue As TextBox
    Friend WithEvents grpTransformationType As GroupBox
    Friend WithEvents rdoOtherTransformations As RadioButton
    Friend WithEvents rdoCommonTransformations As RadioButton
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblInto As Label
    Friend WithEvents txtInto As TextBox
    Friend WithEvents lblPowerValue As Label
    Friend WithEvents txtPowerValue As TextBox
    Friend WithEvents cmdPreview As Button
    Friend WithEvents cboPreview As ComboBox
    Friend WithEvents grpOtherTransformations As GroupBox
    Friend WithEvents grpTransformationsOther As GroupBox
    Friend WithEvents rdoStandardise As RadioButton
    Friend WithEvents rdoNormalScore As RadioButton
    Friend WithEvents rdoSort As RadioButton
    Friend WithEvents rdoRank As RadioButton
    Friend WithEvents rdoDifference As RadioButton
    Friend WithEvents rdoLag As RadioButton
    Friend WithEvents grpLag As GroupBox
    Friend WithEvents lblRows As Label
    Friend WithEvents nudLag As NumericUpDown
    Friend WithEvents lblConstant As Label
    Friend WithEvents grpCircularTransformations As GroupBox
    Friend WithEvents cmbCycleLength As ComboBox
    Friend WithEvents lblHarmonic As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblCycleLength As Label
    Friend WithEvents rdoCosine As RadioButton
    Friend WithEvents rdoSine As RadioButton
    Friend WithEvents grpPercentageTransformations As GroupBox
    Friend WithEvents lblAdjustment As Label
    Friend WithEvents txtAdjustment As TextBox
    Friend WithEvents rdoLogit As RadioButton
    Friend WithEvents rdoAngular As RadioButton
    Friend WithEvents rdoProbit As RadioButton
    Friend WithEvents lbl01Adjustment As Label
End Class
