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
Partial Class dlgTransformClimatic
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgTransformClimatic))
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.rdoSpell = New System.Windows.Forms.RadioButton()
        Me.rdoMoving = New System.Windows.Forms.RadioButton()
        Me.rdoCount = New System.Windows.Forms.RadioButton()
        Me.rdoWaterBalance = New System.Windows.Forms.RadioButton()
        Me.lblSumRows = New System.Windows.Forms.Label()
        Me.lblSumOver = New System.Windows.Forms.Label()
        Me.lblCountOver = New System.Windows.Forms.Label()
        Me.grpTransform = New System.Windows.Forms.GroupBox()
        Me.ucrInputSpellLower = New instat.ucrInputComboBox()
        Me.ucrChkOptions = New instat.ucrCheck()
        Me.ucrReceiverEvap = New instat.ucrReceiverSingle()
        Me.ucrInputEvaporation = New instat.ucrInputTextBox()
        Me.ucrChkGroupByYear = New instat.ucrCheck()
        Me.rdoEvapVariable = New System.Windows.Forms.RadioButton()
        Me.rdoEvapValue = New System.Windows.Forms.RadioButton()
        Me.ucrPnlEvap = New instat.UcrPanel()
        Me.ucrInputCircularPosition = New instat.ucrInputComboBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.ucrInputPosition = New instat.ucrInputComboBox()
        Me.ucrChkCircular = New instat.ucrCheck()
        Me.ucrNudMultSpells = New instat.ucrNud()
        Me.lblRowsMultSpells = New System.Windows.Forms.Label()
        Me.ucrInputSpellUpper = New instat.ucrInputTextBox()
        Me.ucrInputCondition = New instat.ucrInputComboBox()
        Me.lblCondition = New System.Windows.Forms.Label()
        Me.lblWBEvaporation = New System.Windows.Forms.Label()
        Me.ucrNudSumOver = New instat.ucrNud()
        Me.lblWBCapacity = New System.Windows.Forms.Label()
        Me.ucrNudWBCapacity = New instat.ucrNud()
        Me.ucrInputSum = New instat.ucrInputComboBox()
        Me.ucrNudCountOver = New instat.ucrNud()
        Me.ucrInputCumulative = New instat.ucrInputComboBox()
        Me.lblTMin = New System.Windows.Forms.Label()
        Me.grpDegree = New System.Windows.Forms.GroupBox()
        Me.ucrNudLimit = New instat.ucrNud()
        Me.ucrNudMgdd = New instat.ucrNud()
        Me.lblBaselineMgdd = New System.Windows.Forms.Label()
        Me.lblLimit = New System.Windows.Forms.Label()
        Me.rdoModifiedGDD = New System.Windows.Forms.RadioButton()
        Me.lblBaselineGDD = New System.Windows.Forms.Label()
        Me.rdoGrowingDegreeDays = New System.Windows.Forms.RadioButton()
        Me.lblBaselineHDD = New System.Windows.Forms.Label()
        Me.rdoHeatingDegreeDays = New System.Windows.Forms.RadioButton()
        Me.ucrNudGDD = New instat.ucrNud()
        Me.rdoTMean = New System.Windows.Forms.RadioButton()
        Me.ucrNudHDD = New instat.ucrNud()
        Me.rdoDiurnalRange = New System.Windows.Forms.RadioButton()
        Me.ucrPnlDegree = New instat.UcrPanel()
        Me.rdoMultSpells = New System.Windows.Forms.RadioButton()
        Me.rdoCumulative = New System.Windows.Forms.RadioButton()
        Me.rdoDegree = New System.Windows.Forms.RadioButton()
        Me.lblTMax = New System.Windows.Forms.Label()
        Me.lblTMean = New System.Windows.Forms.Label()
        Me.ucrSaveColumn = New instat.ucrSave()
        Me.ucrPnlTransform = New instat.UcrPanel()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSelectorTransform = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverTMin = New instat.ucrReceiverSingle()
        Me.ucrReceiverTMean = New instat.ucrReceiverSingle()
        Me.ucrReceiverTMax = New instat.ucrReceiverSingle()
        Me.ucrReceiverData = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrChkUseMaxMin = New instat.ucrCheck()
        Me.ttRdoRange = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttRdoTMean = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttRdoHdd = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttRdoGdd = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttRdoMgdd = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpTransform.SuspendLayout()
        Me.grpDegree.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblYear
        '
        resources.ApplyResources(Me.lblYear, "lblYear")
        Me.lblYear.Name = "lblYear"
        '
        'lblDate
        '
        resources.ApplyResources(Me.lblDate, "lblDate")
        Me.lblDate.Name = "lblDate"
        '
        'lblStation
        '
        resources.ApplyResources(Me.lblStation, "lblStation")
        Me.lblStation.Name = "lblStation"
        '
        'lblData
        '
        resources.ApplyResources(Me.lblData, "lblData")
        Me.lblData.Name = "lblData"
        '
        'rdoSpell
        '
        resources.ApplyResources(Me.rdoSpell, "rdoSpell")
        Me.rdoSpell.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSpell.FlatAppearance.BorderSize = 2
        Me.rdoSpell.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSpell.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoSpell.Name = "rdoSpell"
        Me.rdoSpell.UseVisualStyleBackColor = True
        '
        'rdoMoving
        '
        resources.ApplyResources(Me.rdoMoving, "rdoMoving")
        Me.rdoMoving.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoMoving.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMoving.FlatAppearance.BorderSize = 2
        Me.rdoMoving.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMoving.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoMoving.Name = "rdoMoving"
        Me.rdoMoving.UseVisualStyleBackColor = True
        '
        'rdoCount
        '
        resources.ApplyResources(Me.rdoCount, "rdoCount")
        Me.rdoCount.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCount.FlatAppearance.BorderSize = 2
        Me.rdoCount.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoCount.Name = "rdoCount"
        Me.rdoCount.UseVisualStyleBackColor = True
        '
        'rdoWaterBalance
        '
        resources.ApplyResources(Me.rdoWaterBalance, "rdoWaterBalance")
        Me.rdoWaterBalance.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWaterBalance.FlatAppearance.BorderSize = 2
        Me.rdoWaterBalance.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWaterBalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoWaterBalance.Name = "rdoWaterBalance"
        Me.rdoWaterBalance.UseVisualStyleBackColor = True
        '
        'lblSumRows
        '
        resources.ApplyResources(Me.lblSumRows, "lblSumRows")
        Me.lblSumRows.Name = "lblSumRows"
        Me.lblSumRows.Tag = "Rows"
        '
        'lblSumOver
        '
        resources.ApplyResources(Me.lblSumOver, "lblSumOver")
        Me.lblSumOver.Name = "lblSumOver"
        Me.lblSumOver.Tag = "Over"
        '
        'lblCountOver
        '
        resources.ApplyResources(Me.lblCountOver, "lblCountOver")
        Me.lblCountOver.Name = "lblCountOver"
        Me.lblCountOver.Tag = "Rows_to_Count_Over:"
        '
        'grpTransform
        '
        Me.grpTransform.Controls.Add(Me.ucrInputSpellLower)
        Me.grpTransform.Controls.Add(Me.ucrChkOptions)
        Me.grpTransform.Controls.Add(Me.ucrReceiverEvap)
        Me.grpTransform.Controls.Add(Me.ucrInputEvaporation)
        Me.grpTransform.Controls.Add(Me.ucrChkGroupByYear)
        Me.grpTransform.Controls.Add(Me.rdoEvapVariable)
        Me.grpTransform.Controls.Add(Me.rdoEvapValue)
        Me.grpTransform.Controls.Add(Me.ucrPnlEvap)
        Me.grpTransform.Controls.Add(Me.ucrInputCircularPosition)
        Me.grpTransform.Controls.Add(Me.lblPosition)
        Me.grpTransform.Controls.Add(Me.ucrInputPosition)
        Me.grpTransform.Controls.Add(Me.ucrChkCircular)
        Me.grpTransform.Controls.Add(Me.ucrNudMultSpells)
        Me.grpTransform.Controls.Add(Me.lblRowsMultSpells)
        Me.grpTransform.Controls.Add(Me.ucrInputSpellUpper)
        Me.grpTransform.Controls.Add(Me.lblSumRows)
        Me.grpTransform.Controls.Add(Me.ucrInputCondition)
        Me.grpTransform.Controls.Add(Me.lblCondition)
        Me.grpTransform.Controls.Add(Me.lblWBEvaporation)
        Me.grpTransform.Controls.Add(Me.lblCountOver)
        Me.grpTransform.Controls.Add(Me.ucrNudSumOver)
        Me.grpTransform.Controls.Add(Me.lblWBCapacity)
        Me.grpTransform.Controls.Add(Me.ucrNudWBCapacity)
        Me.grpTransform.Controls.Add(Me.ucrInputSum)
        Me.grpTransform.Controls.Add(Me.lblSumOver)
        Me.grpTransform.Controls.Add(Me.ucrNudCountOver)
        Me.grpTransform.Controls.Add(Me.ucrInputCumulative)
        resources.ApplyResources(Me.grpTransform, "grpTransform")
        Me.grpTransform.Name = "grpTransform"
        Me.grpTransform.TabStop = False
        '
        'ucrInputSpellLower
        '
        Me.ucrInputSpellLower.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputSpellLower, "ucrInputSpellLower")
        Me.ucrInputSpellLower.GetSetSelectedIndex = -1
        Me.ucrInputSpellLower.IsReadOnly = False
        Me.ucrInputSpellLower.Name = "ucrInputSpellLower"
        '
        'ucrChkOptions
        '
        resources.ApplyResources(Me.ucrChkOptions, "ucrChkOptions")
        Me.ucrChkOptions.Checked = False
        Me.ucrChkOptions.Name = "ucrChkOptions"
        '
        'ucrReceiverEvap
        '
        resources.ApplyResources(Me.ucrReceiverEvap, "ucrReceiverEvap")
        Me.ucrReceiverEvap.frmParent = Me
        Me.ucrReceiverEvap.Name = "ucrReceiverEvap"
        Me.ucrReceiverEvap.Selector = Nothing
        Me.ucrReceiverEvap.strNcFilePath = ""
        Me.ucrReceiverEvap.ucrSelector = Nothing
        '
        'ucrInputEvaporation
        '
        Me.ucrInputEvaporation.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputEvaporation, "ucrInputEvaporation")
        Me.ucrInputEvaporation.IsMultiline = False
        Me.ucrInputEvaporation.IsReadOnly = False
        Me.ucrInputEvaporation.Name = "ucrInputEvaporation"
        '
        'ucrChkGroupByYear
        '
        resources.ApplyResources(Me.ucrChkGroupByYear, "ucrChkGroupByYear")
        Me.ucrChkGroupByYear.Checked = False
        Me.ucrChkGroupByYear.Name = "ucrChkGroupByYear"
        '
        'rdoEvapVariable
        '
        resources.ApplyResources(Me.rdoEvapVariable, "rdoEvapVariable")
        Me.rdoEvapVariable.Name = "rdoEvapVariable"
        Me.rdoEvapVariable.TabStop = True
        Me.rdoEvapVariable.UseVisualStyleBackColor = True
        '
        'rdoEvapValue
        '
        resources.ApplyResources(Me.rdoEvapValue, "rdoEvapValue")
        Me.rdoEvapValue.Name = "rdoEvapValue"
        Me.rdoEvapValue.TabStop = True
        Me.rdoEvapValue.UseVisualStyleBackColor = True
        '
        'ucrPnlEvap
        '
        resources.ApplyResources(Me.ucrPnlEvap, "ucrPnlEvap")
        Me.ucrPnlEvap.Name = "ucrPnlEvap"
        '
        'ucrInputCircularPosition
        '
        Me.ucrInputCircularPosition.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputCircularPosition, "ucrInputCircularPosition")
        Me.ucrInputCircularPosition.GetSetSelectedIndex = -1
        Me.ucrInputCircularPosition.IsReadOnly = False
        Me.ucrInputCircularPosition.Name = "ucrInputCircularPosition"
        '
        'lblPosition
        '
        resources.ApplyResources(Me.lblPosition, "lblPosition")
        Me.lblPosition.Name = "lblPosition"
        '
        'ucrInputPosition
        '
        Me.ucrInputPosition.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputPosition, "ucrInputPosition")
        Me.ucrInputPosition.GetSetSelectedIndex = -1
        Me.ucrInputPosition.IsReadOnly = False
        Me.ucrInputPosition.Name = "ucrInputPosition"
        '
        'ucrChkCircular
        '
        resources.ApplyResources(Me.ucrChkCircular, "ucrChkCircular")
        Me.ucrChkCircular.Checked = False
        Me.ucrChkCircular.Name = "ucrChkCircular"
        '
        'ucrNudMultSpells
        '
        resources.ApplyResources(Me.ucrNudMultSpells, "ucrNudMultSpells")
        Me.ucrNudMultSpells.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMultSpells.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMultSpells.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMultSpells.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMultSpells.Name = "ucrNudMultSpells"
        Me.ucrNudMultSpells.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblRowsMultSpells
        '
        resources.ApplyResources(Me.lblRowsMultSpells, "lblRowsMultSpells")
        Me.lblRowsMultSpells.Name = "lblRowsMultSpells"
        Me.lblRowsMultSpells.Tag = "Rows_to_Take_Over:"
        '
        'ucrInputSpellUpper
        '
        Me.ucrInputSpellUpper.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputSpellUpper, "ucrInputSpellUpper")
        Me.ucrInputSpellUpper.IsMultiline = False
        Me.ucrInputSpellUpper.IsReadOnly = False
        Me.ucrInputSpellUpper.Name = "ucrInputSpellUpper"
        '
        'ucrInputCondition
        '
        Me.ucrInputCondition.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputCondition, "ucrInputCondition")
        Me.ucrInputCondition.GetSetSelectedIndex = -1
        Me.ucrInputCondition.IsReadOnly = False
        Me.ucrInputCondition.Name = "ucrInputCondition"
        '
        'lblCondition
        '
        resources.ApplyResources(Me.lblCondition, "lblCondition")
        Me.lblCondition.Name = "lblCondition"
        Me.lblCondition.Tag = "Condition:"
        '
        'lblWBEvaporation
        '
        resources.ApplyResources(Me.lblWBEvaporation, "lblWBEvaporation")
        Me.lblWBEvaporation.Name = "lblWBEvaporation"
        Me.lblWBEvaporation.Tag = "Evaporation"
        '
        'ucrNudSumOver
        '
        resources.ApplyResources(Me.ucrNudSumOver, "ucrNudSumOver")
        Me.ucrNudSumOver.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSumOver.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSumOver.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSumOver.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSumOver.Name = "ucrNudSumOver"
        Me.ucrNudSumOver.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblWBCapacity
        '
        resources.ApplyResources(Me.lblWBCapacity, "lblWBCapacity")
        Me.lblWBCapacity.Name = "lblWBCapacity"
        Me.lblWBCapacity.Tag = "Capacity"
        '
        'ucrNudWBCapacity
        '
        resources.ApplyResources(Me.ucrNudWBCapacity, "ucrNudWBCapacity")
        Me.ucrNudWBCapacity.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWBCapacity.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWBCapacity.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWBCapacity.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWBCapacity.Name = "ucrNudWBCapacity"
        Me.ucrNudWBCapacity.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputSum
        '
        Me.ucrInputSum.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputSum, "ucrInputSum")
        Me.ucrInputSum.GetSetSelectedIndex = -1
        Me.ucrInputSum.IsReadOnly = False
        Me.ucrInputSum.Name = "ucrInputSum"
        '
        'ucrNudCountOver
        '
        resources.ApplyResources(Me.ucrNudCountOver, "ucrNudCountOver")
        Me.ucrNudCountOver.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCountOver.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCountOver.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCountOver.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCountOver.Name = "ucrNudCountOver"
        Me.ucrNudCountOver.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputCumulative
        '
        Me.ucrInputCumulative.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputCumulative, "ucrInputCumulative")
        Me.ucrInputCumulative.GetSetSelectedIndex = -1
        Me.ucrInputCumulative.IsReadOnly = False
        Me.ucrInputCumulative.Name = "ucrInputCumulative"
        '
        'lblTMin
        '
        resources.ApplyResources(Me.lblTMin, "lblTMin")
        Me.lblTMin.Name = "lblTMin"
        '
        'grpDegree
        '
        Me.grpDegree.Controls.Add(Me.ucrNudLimit)
        Me.grpDegree.Controls.Add(Me.ucrNudMgdd)
        Me.grpDegree.Controls.Add(Me.lblBaselineMgdd)
        Me.grpDegree.Controls.Add(Me.lblLimit)
        Me.grpDegree.Controls.Add(Me.rdoModifiedGDD)
        Me.grpDegree.Controls.Add(Me.lblBaselineGDD)
        Me.grpDegree.Controls.Add(Me.rdoGrowingDegreeDays)
        Me.grpDegree.Controls.Add(Me.lblBaselineHDD)
        Me.grpDegree.Controls.Add(Me.rdoHeatingDegreeDays)
        Me.grpDegree.Controls.Add(Me.ucrNudGDD)
        Me.grpDegree.Controls.Add(Me.rdoTMean)
        Me.grpDegree.Controls.Add(Me.ucrNudHDD)
        Me.grpDegree.Controls.Add(Me.rdoDiurnalRange)
        Me.grpDegree.Controls.Add(Me.ucrPnlDegree)
        resources.ApplyResources(Me.grpDegree, "grpDegree")
        Me.grpDegree.Name = "grpDegree"
        Me.grpDegree.TabStop = False
        '
        'ucrNudLimit
        '
        resources.ApplyResources(Me.ucrNudLimit, "ucrNudLimit")
        Me.ucrNudLimit.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLimit.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLimit.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLimit.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLimit.Name = "ucrNudLimit"
        Me.ucrNudLimit.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMgdd
        '
        resources.ApplyResources(Me.ucrNudMgdd, "ucrNudMgdd")
        Me.ucrNudMgdd.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMgdd.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMgdd.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMgdd.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMgdd.Name = "ucrNudMgdd"
        Me.ucrNudMgdd.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblBaselineMgdd
        '
        resources.ApplyResources(Me.lblBaselineMgdd, "lblBaselineMgdd")
        Me.lblBaselineMgdd.Name = "lblBaselineMgdd"
        Me.lblBaselineMgdd.Tag = "Over"
        '
        'lblLimit
        '
        resources.ApplyResources(Me.lblLimit, "lblLimit")
        Me.lblLimit.Name = "lblLimit"
        Me.lblLimit.Tag = "Over"
        '
        'rdoModifiedGDD
        '
        resources.ApplyResources(Me.rdoModifiedGDD, "rdoModifiedGDD")
        Me.rdoModifiedGDD.Name = "rdoModifiedGDD"
        Me.rdoModifiedGDD.TabStop = True
        Me.rdoModifiedGDD.UseVisualStyleBackColor = True
        '
        'lblBaselineGDD
        '
        resources.ApplyResources(Me.lblBaselineGDD, "lblBaselineGDD")
        Me.lblBaselineGDD.Name = "lblBaselineGDD"
        Me.lblBaselineGDD.Tag = "Over"
        '
        'rdoGrowingDegreeDays
        '
        resources.ApplyResources(Me.rdoGrowingDegreeDays, "rdoGrowingDegreeDays")
        Me.rdoGrowingDegreeDays.Name = "rdoGrowingDegreeDays"
        Me.rdoGrowingDegreeDays.TabStop = True
        Me.rdoGrowingDegreeDays.UseVisualStyleBackColor = True
        '
        'lblBaselineHDD
        '
        resources.ApplyResources(Me.lblBaselineHDD, "lblBaselineHDD")
        Me.lblBaselineHDD.Name = "lblBaselineHDD"
        Me.lblBaselineHDD.Tag = "Over"
        '
        'rdoHeatingDegreeDays
        '
        resources.ApplyResources(Me.rdoHeatingDegreeDays, "rdoHeatingDegreeDays")
        Me.rdoHeatingDegreeDays.Name = "rdoHeatingDegreeDays"
        Me.rdoHeatingDegreeDays.TabStop = True
        Me.rdoHeatingDegreeDays.UseVisualStyleBackColor = True
        '
        'ucrNudGDD
        '
        resources.ApplyResources(Me.ucrNudGDD, "ucrNudGDD")
        Me.ucrNudGDD.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudGDD.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudGDD.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudGDD.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudGDD.Name = "ucrNudGDD"
        Me.ucrNudGDD.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoTMean
        '
        resources.ApplyResources(Me.rdoTMean, "rdoTMean")
        Me.rdoTMean.Name = "rdoTMean"
        Me.rdoTMean.TabStop = True
        Me.rdoTMean.UseVisualStyleBackColor = True
        '
        'ucrNudHDD
        '
        resources.ApplyResources(Me.ucrNudHDD, "ucrNudHDD")
        Me.ucrNudHDD.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHDD.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHDD.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudHDD.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHDD.Name = "ucrNudHDD"
        Me.ucrNudHDD.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoDiurnalRange
        '
        resources.ApplyResources(Me.rdoDiurnalRange, "rdoDiurnalRange")
        Me.rdoDiurnalRange.Name = "rdoDiurnalRange"
        Me.rdoDiurnalRange.TabStop = True
        Me.rdoDiurnalRange.UseVisualStyleBackColor = True
        '
        'ucrPnlDegree
        '
        resources.ApplyResources(Me.ucrPnlDegree, "ucrPnlDegree")
        Me.ucrPnlDegree.Name = "ucrPnlDegree"
        '
        'rdoMultSpells
        '
        resources.ApplyResources(Me.rdoMultSpells, "rdoMultSpells")
        Me.rdoMultSpells.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultSpells.FlatAppearance.BorderSize = 2
        Me.rdoMultSpells.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultSpells.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoMultSpells.Name = "rdoMultSpells"
        Me.rdoMultSpells.UseVisualStyleBackColor = True
        '
        'rdoCumulative
        '
        resources.ApplyResources(Me.rdoCumulative, "rdoCumulative")
        Me.rdoCumulative.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCumulative.FlatAppearance.BorderSize = 2
        Me.rdoCumulative.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCumulative.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoCumulative.Name = "rdoCumulative"
        Me.rdoCumulative.UseVisualStyleBackColor = True
        '
        'rdoDegree
        '
        resources.ApplyResources(Me.rdoDegree, "rdoDegree")
        Me.rdoDegree.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDegree.FlatAppearance.BorderSize = 2
        Me.rdoDegree.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDegree.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoDegree.Name = "rdoDegree"
        Me.rdoDegree.UseVisualStyleBackColor = True
        '
        'lblTMax
        '
        resources.ApplyResources(Me.lblTMax, "lblTMax")
        Me.lblTMax.Name = "lblTMax"
        '
        'lblTMean
        '
        resources.ApplyResources(Me.lblTMean, "lblTMean")
        Me.lblTMean.Name = "lblTMean"
        '
        'ucrSaveColumn
        '
        resources.ApplyResources(Me.ucrSaveColumn, "ucrSaveColumn")
        Me.ucrSaveColumn.Name = "ucrSaveColumn"
        '
        'ucrPnlTransform
        '
        resources.ApplyResources(Me.ucrPnlTransform, "ucrPnlTransform")
        Me.ucrPnlTransform.Name = "ucrPnlTransform"
        '
        'ucrReceiverDate
        '
        resources.ApplyResources(Me.ucrReceiverDate, "ucrReceiverDate")
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        resources.ApplyResources(Me.ucrReceiverStation, "ucrReceiverStation")
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSelectorTransform
        '
        resources.ApplyResources(Me.ucrSelectorTransform, "ucrSelectorTransform")
        Me.ucrSelectorTransform.bDropUnusedFilterLevels = False
        Me.ucrSelectorTransform.bShowHiddenColumns = False
        Me.ucrSelectorTransform.bUseCurrentFilter = True
        Me.ucrSelectorTransform.Name = "ucrSelectorTransform"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReceiverTMin
        '
        resources.ApplyResources(Me.ucrReceiverTMin, "ucrReceiverTMin")
        Me.ucrReceiverTMin.frmParent = Me
        Me.ucrReceiverTMin.Name = "ucrReceiverTMin"
        Me.ucrReceiverTMin.Selector = Nothing
        Me.ucrReceiverTMin.strNcFilePath = ""
        Me.ucrReceiverTMin.ucrSelector = Nothing
        '
        'ucrReceiverTMean
        '
        resources.ApplyResources(Me.ucrReceiverTMean, "ucrReceiverTMean")
        Me.ucrReceiverTMean.frmParent = Me
        Me.ucrReceiverTMean.Name = "ucrReceiverTMean"
        Me.ucrReceiverTMean.Selector = Nothing
        Me.ucrReceiverTMean.strNcFilePath = ""
        Me.ucrReceiverTMean.ucrSelector = Nothing
        '
        'ucrReceiverTMax
        '
        resources.ApplyResources(Me.ucrReceiverTMax, "ucrReceiverTMax")
        Me.ucrReceiverTMax.frmParent = Me
        Me.ucrReceiverTMax.Name = "ucrReceiverTMax"
        Me.ucrReceiverTMax.Selector = Nothing
        Me.ucrReceiverTMax.strNcFilePath = ""
        Me.ucrReceiverTMax.ucrSelector = Nothing
        '
        'ucrReceiverData
        '
        resources.ApplyResources(Me.ucrReceiverData, "ucrReceiverData")
        Me.ucrReceiverData.frmParent = Me
        Me.ucrReceiverData.Name = "ucrReceiverData"
        Me.ucrReceiverData.Selector = Nothing
        Me.ucrReceiverData.strNcFilePath = ""
        Me.ucrReceiverData.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        resources.ApplyResources(Me.ucrReceiverYear, "ucrReceiverYear")
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrChkUseMaxMin
        '
        resources.ApplyResources(Me.ucrChkUseMaxMin, "ucrChkUseMaxMin")
        Me.ucrChkUseMaxMin.Checked = True
        Me.ucrChkUseMaxMin.Name = "ucrChkUseMaxMin"
        '
        'dlgTransformClimatic
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.rdoDegree)
        Me.Controls.Add(Me.ucrSaveColumn)
        Me.Controls.Add(Me.rdoCumulative)
        Me.Controls.Add(Me.rdoMultSpells)
        Me.Controls.Add(Me.rdoWaterBalance)
        Me.Controls.Add(Me.rdoSpell)
        Me.Controls.Add(Me.rdoMoving)
        Me.Controls.Add(Me.rdoCount)
        Me.Controls.Add(Me.ucrPnlTransform)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrSelectorTransform)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverTMin)
        Me.Controls.Add(Me.grpDegree)
        Me.Controls.Add(Me.ucrReceiverTMean)
        Me.Controls.Add(Me.lblTMin)
        Me.Controls.Add(Me.lblTMax)
        Me.Controls.Add(Me.ucrReceiverTMax)
        Me.Controls.Add(Me.ucrReceiverData)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrChkUseMaxMin)
        Me.Controls.Add(Me.lblTMean)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.grpTransform)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTransformClimatic"
        Me.grpTransform.ResumeLayout(False)
        Me.grpTransform.PerformLayout()
        Me.grpDegree.ResumeLayout(False)
        Me.grpDegree.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrSelectorTransform As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblData As Label
    Friend WithEvents ucrReceiverData As ucrReceiverSingle
    Friend WithEvents rdoWaterBalance As RadioButton
    Friend WithEvents rdoSpell As RadioButton
    Friend WithEvents rdoMoving As RadioButton
    Friend WithEvents rdoCount As RadioButton
    Friend WithEvents ucrPnlTransform As UcrPanel
    Friend WithEvents lblSumRows As Label
    Friend WithEvents ucrNudSumOver As ucrNud
    Friend WithEvents lblSumOver As Label
    Friend WithEvents ucrInputSum As ucrInputComboBox
    Friend WithEvents ucrNudCountOver As ucrNud
    Friend WithEvents lblCountOver As Label
    Friend WithEvents lblWBEvaporation As Label
    Friend WithEvents ucrNudWBCapacity As ucrNud
    Friend WithEvents lblWBCapacity As Label
    Friend WithEvents grpTransform As GroupBox
    Friend WithEvents ucrInputSpellUpper As ucrInputTextBox
    Friend WithEvents ucrInputCondition As ucrInputComboBox
    Friend WithEvents lblCondition As Label
    Friend WithEvents rdoMultSpells As RadioButton
    Friend WithEvents ucrChkGroupByYear As ucrCheck
    Friend WithEvents ucrNudMultSpells As ucrNud
    Friend WithEvents lblRowsMultSpells As Label
    Friend WithEvents ucrInputEvaporation As ucrInputTextBox
    Friend WithEvents ucrPnlEvap As UcrPanel
    Friend WithEvents ucrReceiverEvap As ucrReceiverSingle
    Friend WithEvents rdoEvapVariable As RadioButton
    Friend WithEvents rdoEvapValue As RadioButton
    Friend WithEvents lblPosition As Label
    Friend WithEvents ucrInputPosition As ucrInputComboBox
    Friend WithEvents ucrChkCircular As ucrCheck
    Friend WithEvents ucrInputCircularPosition As ucrInputComboBox
    Friend WithEvents rdoCumulative As RadioButton
    Friend WithEvents ucrInputCumulative As ucrInputComboBox
    Friend WithEvents ucrSaveColumn As ucrSave
    Friend WithEvents ucrReceiverTMean As ucrReceiverSingle
    Friend WithEvents lblTMean As Label
    Friend WithEvents ucrReceiverTMin As ucrReceiverSingle
    Friend WithEvents lblTMax As Label
    Friend WithEvents ucrReceiverTMax As ucrReceiverSingle
    Friend WithEvents lblTMin As Label
    Friend WithEvents ucrChkUseMaxMin As ucrCheck
    Friend WithEvents rdoDegree As RadioButton
    Friend WithEvents rdoDiurnalRange As RadioButton
    Friend WithEvents ucrPnlDegree As UcrPanel
    Friend WithEvents rdoModifiedGDD As RadioButton
    Friend WithEvents rdoGrowingDegreeDays As RadioButton
    Friend WithEvents rdoHeatingDegreeDays As RadioButton
    Friend WithEvents rdoTMean As RadioButton
    Friend WithEvents grpDegree As GroupBox
    Friend WithEvents lblBaselineGDD As Label
    Friend WithEvents lblBaselineHDD As Label
    Friend WithEvents ucrNudGDD As ucrNud
    Friend WithEvents ucrNudHDD As ucrNud
    Friend WithEvents lblLimit As Label
    Friend WithEvents ucrChkOptions As ucrCheck
    Friend WithEvents ucrInputSpellLower As ucrInputComboBox
    Friend WithEvents ucrNudMgdd As ucrNud
    Friend WithEvents lblBaselineMgdd As Label
    Friend WithEvents ucrNudLimit As ucrNud
    Friend WithEvents ttRdoRange As ToolTip
    Friend WithEvents ttRdoTMean As ToolTip
    Friend WithEvents ttRdoHdd As ToolTip
    Friend WithEvents ttRdoGdd As ToolTip
    Friend WithEvents ttRdoMgdd As ToolTip
End Class
