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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgTransform))
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
        resources.ApplyResources(Me.grpCalculatedTransformations, "grpCalculatedTransformations")
        Me.grpCalculatedTransformations.Name = "grpCalculatedTransformations"
        Me.grpCalculatedTransformations.TabStop = False
        Me.grpCalculatedTransformations.Tag = "Calculated_Transformations"
        '
        'grpPercentageTransformations
        '
        Me.grpPercentageTransformations.Controls.Add(Me.lbl01Adjustment)
        Me.grpPercentageTransformations.Controls.Add(Me.rdoProbit)
        Me.grpPercentageTransformations.Controls.Add(Me.lblAdjustment)
        Me.grpPercentageTransformations.Controls.Add(Me.txtAdjustment)
        Me.grpPercentageTransformations.Controls.Add(Me.rdoLogit)
        Me.grpPercentageTransformations.Controls.Add(Me.rdoAngular)
        resources.ApplyResources(Me.grpPercentageTransformations, "grpPercentageTransformations")
        Me.grpPercentageTransformations.Name = "grpPercentageTransformations"
        Me.grpPercentageTransformations.TabStop = False
        '
        'lbl01Adjustment
        '
        resources.ApplyResources(Me.lbl01Adjustment, "lbl01Adjustment")
        Me.lbl01Adjustment.Name = "lbl01Adjustment"
        Me.lbl01Adjustment.Tag = "0_and_1_Adjustment"
        '
        'rdoProbit
        '
        resources.ApplyResources(Me.rdoProbit, "rdoProbit")
        Me.rdoProbit.Name = "rdoProbit"
        Me.rdoProbit.TabStop = True
        Me.rdoProbit.Tag = "Probit"
        Me.rdoProbit.UseVisualStyleBackColor = True
        '
        'lblAdjustment
        '
        resources.ApplyResources(Me.lblAdjustment, "lblAdjustment")
        Me.lblAdjustment.Name = "lblAdjustment"
        Me.lblAdjustment.Tag = "0%_and_100%_Adjustment"
        '
        'txtAdjustment
        '
        resources.ApplyResources(Me.txtAdjustment, "txtAdjustment")
        Me.txtAdjustment.Name = "txtAdjustment"
        '
        'rdoLogit
        '
        resources.ApplyResources(Me.rdoLogit, "rdoLogit")
        Me.rdoLogit.Name = "rdoLogit"
        Me.rdoLogit.TabStop = True
        Me.rdoLogit.Tag = "Logit"
        Me.rdoLogit.UseVisualStyleBackColor = True
        '
        'rdoAngular
        '
        resources.ApplyResources(Me.rdoAngular, "rdoAngular")
        Me.rdoAngular.Name = "rdoAngular"
        Me.rdoAngular.TabStop = True
        Me.rdoAngular.Tag = "Angular"
        Me.rdoAngular.UseVisualStyleBackColor = True
        '
        'chkInverse
        '
        resources.ApplyResources(Me.chkInverse, "chkInverse")
        Me.chkInverse.Name = "chkInverse"
        Me.chkInverse.Tag = "Inverse"
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
        resources.ApplyResources(Me.grpCircularTransformations, "grpCircularTransformations")
        Me.grpCircularTransformations.Name = "grpCircularTransformations"
        Me.grpCircularTransformations.TabStop = False
        '
        'cmbCycleLength
        '
        Me.cmbCycleLength.FormattingEnabled = True
        Me.cmbCycleLength.Items.AddRange(New Object() {resources.GetString("cmbCycleLength.Items"), resources.GetString("cmbCycleLength.Items1"), resources.GetString("cmbCycleLength.Items2"), resources.GetString("cmbCycleLength.Items3")})
        resources.ApplyResources(Me.cmbCycleLength, "cmbCycleLength")
        Me.cmbCycleLength.Name = "cmbCycleLength"
        '
        'lblHarmonic
        '
        resources.ApplyResources(Me.lblHarmonic, "lblHarmonic")
        Me.lblHarmonic.Name = "lblHarmonic"
        Me.lblHarmonic.Tag = "Harmonic"
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'lblCycleLength
        '
        resources.ApplyResources(Me.lblCycleLength, "lblCycleLength")
        Me.lblCycleLength.Name = "lblCycleLength"
        Me.lblCycleLength.Tag = "Cycle_Length"
        '
        'rdoCosine
        '
        resources.ApplyResources(Me.rdoCosine, "rdoCosine")
        Me.rdoCosine.Name = "rdoCosine"
        Me.rdoCosine.TabStop = True
        Me.rdoCosine.Tag = "Cosine"
        Me.rdoCosine.UseVisualStyleBackColor = True
        '
        'rdoSine
        '
        resources.ApplyResources(Me.rdoSine, "rdoSine")
        Me.rdoSine.Name = "rdoSine"
        Me.rdoSine.TabStop = True
        Me.rdoSine.Tag = "Sine"
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
        resources.ApplyResources(Me.grpNonNegativeTransformations, "grpNonNegativeTransformations")
        Me.grpNonNegativeTransformations.Name = "grpNonNegativeTransformations"
        Me.grpNonNegativeTransformations.TabStop = False
        '
        'lblConstant
        '
        resources.ApplyResources(Me.lblConstant, "lblConstant")
        Me.lblConstant.Name = "lblConstant"
        Me.lblConstant.Tag = "Constant"
        '
        'lblPowerValue
        '
        resources.ApplyResources(Me.lblPowerValue, "lblPowerValue")
        Me.lblPowerValue.Name = "lblPowerValue"
        Me.lblPowerValue.Tag = "Power_Value"
        '
        'txtPowerValue
        '
        resources.ApplyResources(Me.txtPowerValue, "txtPowerValue")
        Me.txtPowerValue.Name = "txtPowerValue"
        '
        'lblZeroAdjustment
        '
        resources.ApplyResources(Me.lblZeroAdjustment, "lblZeroAdjustment")
        Me.lblZeroAdjustment.Name = "lblZeroAdjustment"
        Me.lblZeroAdjustment.Tag = "Zero_Adjustment"
        '
        'txtValue
        '
        resources.ApplyResources(Me.txtValue, "txtValue")
        Me.txtValue.Name = "txtValue"
        '
        'rdoPower
        '
        resources.ApplyResources(Me.rdoPower, "rdoPower")
        Me.rdoPower.Name = "rdoPower"
        Me.rdoPower.TabStop = True
        Me.rdoPower.Tag = "Power"
        Me.rdoPower.UseVisualStyleBackColor = True
        '
        'rdoLogBase10
        '
        resources.ApplyResources(Me.rdoLogBase10, "rdoLogBase10")
        Me.rdoLogBase10.Name = "rdoLogBase10"
        Me.rdoLogBase10.TabStop = True
        Me.rdoLogBase10.Tag = "Log_Base_10"
        Me.rdoLogBase10.UseVisualStyleBackColor = True
        '
        'rdoNaturalLog
        '
        resources.ApplyResources(Me.rdoNaturalLog, "rdoNaturalLog")
        Me.rdoNaturalLog.Name = "rdoNaturalLog"
        Me.rdoNaturalLog.TabStop = True
        Me.rdoNaturalLog.Tag = "Natural_Log"
        Me.rdoNaturalLog.UseVisualStyleBackColor = True
        '
        'rdoSquareRoot
        '
        resources.ApplyResources(Me.rdoSquareRoot, "rdoSquareRoot")
        Me.rdoSquareRoot.Name = "rdoSquareRoot"
        Me.rdoSquareRoot.TabStop = True
        Me.rdoSquareRoot.Tag = "Square_root"
        Me.rdoSquareRoot.UseVisualStyleBackColor = True
        '
        'grpTypeofdata
        '
        Me.grpTypeofdata.Controls.Add(Me.rdoProportion)
        Me.grpTypeofdata.Controls.Add(Me.rdoPercentage)
        Me.grpTypeofdata.Controls.Add(Me.rdoCircular)
        Me.grpTypeofdata.Controls.Add(Me.rdoNonNegative)
        resources.ApplyResources(Me.grpTypeofdata, "grpTypeofdata")
        Me.grpTypeofdata.Name = "grpTypeofdata"
        Me.grpTypeofdata.TabStop = False
        Me.grpTypeofdata.Tag = "Type_of_data"
        '
        'rdoProportion
        '
        resources.ApplyResources(Me.rdoProportion, "rdoProportion")
        Me.rdoProportion.Name = "rdoProportion"
        Me.rdoProportion.TabStop = True
        Me.rdoProportion.Tag = "Proportion"
        Me.rdoProportion.UseVisualStyleBackColor = True
        '
        'rdoPercentage
        '
        resources.ApplyResources(Me.rdoPercentage, "rdoPercentage")
        Me.rdoPercentage.Name = "rdoPercentage"
        Me.rdoPercentage.TabStop = True
        Me.rdoPercentage.Tag = "Percentage"
        Me.rdoPercentage.UseVisualStyleBackColor = True
        '
        'rdoCircular
        '
        resources.ApplyResources(Me.rdoCircular, "rdoCircular")
        Me.rdoCircular.Name = "rdoCircular"
        Me.rdoCircular.TabStop = True
        Me.rdoCircular.Tag = "Circular"
        Me.rdoCircular.UseVisualStyleBackColor = True
        '
        'rdoNonNegative
        '
        resources.ApplyResources(Me.rdoNonNegative, "rdoNonNegative")
        Me.rdoNonNegative.Name = "rdoNonNegative"
        Me.rdoNonNegative.TabStop = True
        Me.rdoNonNegative.Tag = "Non_Negative"
        Me.rdoNonNegative.UseVisualStyleBackColor = True
        '
        'grpTransformationType
        '
        Me.grpTransformationType.Controls.Add(Me.rdoOtherTransformations)
        Me.grpTransformationType.Controls.Add(Me.rdoCommonTransformations)
        resources.ApplyResources(Me.grpTransformationType, "grpTransformationType")
        Me.grpTransformationType.Name = "grpTransformationType"
        Me.grpTransformationType.TabStop = False
        '
        'rdoOtherTransformations
        '
        resources.ApplyResources(Me.rdoOtherTransformations, "rdoOtherTransformations")
        Me.rdoOtherTransformations.Name = "rdoOtherTransformations"
        Me.rdoOtherTransformations.TabStop = True
        Me.rdoOtherTransformations.Tag = "Other_Transformations"
        Me.rdoOtherTransformations.UseVisualStyleBackColor = True
        '
        'rdoCommonTransformations
        '
        resources.ApplyResources(Me.rdoCommonTransformations, "rdoCommonTransformations")
        Me.rdoCommonTransformations.Name = "rdoCommonTransformations"
        Me.rdoCommonTransformations.TabStop = True
        Me.rdoCommonTransformations.Tag = "Common_Transformations"
        Me.rdoCommonTransformations.UseVisualStyleBackColor = True
        '
        'lblFrom
        '
        resources.ApplyResources(Me.lblFrom, "lblFrom")
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Tag = "From"
        '
        'lblInto
        '
        resources.ApplyResources(Me.lblInto, "lblInto")
        Me.lblInto.Name = "lblInto"
        Me.lblInto.Tag = "Into"
        '
        'txtInto
        '
        resources.ApplyResources(Me.txtInto, "txtInto")
        Me.txtInto.Name = "txtInto"
        '
        'cmdPreview
        '
        resources.ApplyResources(Me.cmdPreview, "cmdPreview")
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Tag = "Preview"
        Me.cmdPreview.UseVisualStyleBackColor = True
        '
        'cboPreview
        '
        Me.cboPreview.FormattingEnabled = True
        resources.ApplyResources(Me.cboPreview, "cboPreview")
        Me.cboPreview.Name = "cboPreview"
        '
        'grpOtherTransformations
        '
        Me.grpOtherTransformations.Controls.Add(Me.grpLag)
        Me.grpOtherTransformations.Controls.Add(Me.grpTransformationsOther)
        resources.ApplyResources(Me.grpOtherTransformations, "grpOtherTransformations")
        Me.grpOtherTransformations.Name = "grpOtherTransformations"
        Me.grpOtherTransformations.TabStop = False
        Me.grpOtherTransformations.Tag = "Other_Transformations"
        '
        'grpLag
        '
        Me.grpLag.Controls.Add(Me.lblRows)
        Me.grpLag.Controls.Add(Me.nudLag)
        resources.ApplyResources(Me.grpLag, "grpLag")
        Me.grpLag.Name = "grpLag"
        Me.grpLag.TabStop = False
        Me.grpLag.Tag = "Lag"
        '
        'lblRows
        '
        resources.ApplyResources(Me.lblRows, "lblRows")
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Tag = "rows"
        '
        'nudLag
        '
        Me.nudLag.AllowDrop = True
        resources.ApplyResources(Me.nudLag, "nudLag")
        Me.nudLag.Name = "nudLag"
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
        resources.ApplyResources(Me.grpTransformationsOther, "grpTransformationsOther")
        Me.grpTransformationsOther.Name = "grpTransformationsOther"
        Me.grpTransformationsOther.TabStop = False
        '
        'rdoDifference
        '
        resources.ApplyResources(Me.rdoDifference, "rdoDifference")
        Me.rdoDifference.Name = "rdoDifference"
        Me.rdoDifference.TabStop = True
        Me.rdoDifference.Tag = "Difference"
        Me.rdoDifference.UseVisualStyleBackColor = True
        '
        'rdoLag
        '
        resources.ApplyResources(Me.rdoLag, "rdoLag")
        Me.rdoLag.Name = "rdoLag"
        Me.rdoLag.TabStop = True
        Me.rdoLag.Tag = "Lag"
        Me.rdoLag.UseVisualStyleBackColor = True
        '
        'rdoStandardise
        '
        resources.ApplyResources(Me.rdoStandardise, "rdoStandardise")
        Me.rdoStandardise.Name = "rdoStandardise"
        Me.rdoStandardise.TabStop = True
        Me.rdoStandardise.Tag = "Standardise"
        Me.rdoStandardise.UseVisualStyleBackColor = True
        '
        'rdoNormalScore
        '
        resources.ApplyResources(Me.rdoNormalScore, "rdoNormalScore")
        Me.rdoNormalScore.Name = "rdoNormalScore"
        Me.rdoNormalScore.TabStop = True
        Me.rdoNormalScore.Tag = "Normal_Score"
        Me.rdoNormalScore.UseVisualStyleBackColor = True
        '
        'rdoSort
        '
        resources.ApplyResources(Me.rdoSort, "rdoSort")
        Me.rdoSort.Name = "rdoSort"
        Me.rdoSort.TabStop = True
        Me.rdoSort.Tag = "Sort"
        Me.rdoSort.UseVisualStyleBackColor = True
        '
        'rdoRank
        '
        resources.ApplyResources(Me.rdoRank, "rdoRank")
        Me.rdoRank.Name = "rdoRank"
        Me.rdoRank.TabStop = True
        Me.rdoRank.Tag = "Rank"
        Me.rdoRank.UseVisualStyleBackColor = True
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.bShowHiddenColumns = False
        resources.ApplyResources(Me.ucrAddRemove, "ucrAddRemove")
        Me.ucrAddRemove.Name = "ucrAddRemove"
        '
        'ucrReceiverFrom
        '
        Me.ucrReceiverFrom.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFrom, "ucrReceiverFrom")
        Me.ucrReceiverFrom.Name = "ucrReceiverFrom"
        Me.ucrReceiverFrom.Selector = Nothing
        Me.ucrReceiverFrom.strNcFilePath = ""
        Me.ucrReceiverFrom.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgTransform
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Tag = "Transform"
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
