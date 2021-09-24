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
        Me.ucrReceiverEvap = New instat.ucrReceiverSingle()
        Me.ucrInputEvaporation = New instat.ucrInputTextBox()
        Me.ucrChkGroupByYear = New instat.ucrCheck()
        Me.rdoEvapVariable = New System.Windows.Forms.RadioButton()
        Me.rdoEvapValue = New System.Windows.Forms.RadioButton()
        Me.ucrPnlEvap = New instat.UcrPanel()
        Me.ucrInputCumulative = New instat.ucrInputComboBox()
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
        Me.ucrInputSpellLower = New instat.ucrInputTextBox()
        Me.ucrNudSumOver = New instat.ucrNud()
        Me.lblWBCapacity = New System.Windows.Forms.Label()
        Me.ucrNudWBCapacity = New instat.ucrNud()
        Me.ucrInputSum = New instat.ucrInputComboBox()
        Me.ucrNudCountOver = New instat.ucrNud()
        Me.rdoMultSpells = New System.Windows.Forms.RadioButton()
        Me.rdoCumulative = New System.Windows.Forms.RadioButton()
        Me.ucrSaveColumn = New instat.ucrSave()
        Me.ucrPnlTransform = New instat.UcrPanel()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverData = New instat.ucrReceiverSingle()
        Me.ucrSelectorTransform = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpTransform.SuspendLayout()
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
        Me.grpTransform.Controls.Add(Me.ucrReceiverEvap)
        Me.grpTransform.Controls.Add(Me.ucrInputEvaporation)
        Me.grpTransform.Controls.Add(Me.ucrChkGroupByYear)
        Me.grpTransform.Controls.Add(Me.rdoEvapVariable)
        Me.grpTransform.Controls.Add(Me.rdoEvapValue)
        Me.grpTransform.Controls.Add(Me.ucrPnlEvap)
        Me.grpTransform.Controls.Add(Me.ucrInputCumulative)
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
        Me.grpTransform.Controls.Add(Me.ucrInputSpellLower)
        Me.grpTransform.Controls.Add(Me.lblCountOver)
        Me.grpTransform.Controls.Add(Me.ucrNudSumOver)
        Me.grpTransform.Controls.Add(Me.lblWBCapacity)
        Me.grpTransform.Controls.Add(Me.ucrNudWBCapacity)
        Me.grpTransform.Controls.Add(Me.ucrInputSum)
        Me.grpTransform.Controls.Add(Me.lblSumOver)
        Me.grpTransform.Controls.Add(Me.ucrNudCountOver)
        resources.ApplyResources(Me.grpTransform, "grpTransform")
        Me.grpTransform.Name = "grpTransform"
        Me.grpTransform.TabStop = False
        '
        'ucrReceiverEvap
        '
        Me.ucrReceiverEvap.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverEvap, "ucrReceiverEvap")
        Me.ucrReceiverEvap.Name = "ucrReceiverEvap"
        Me.ucrReceiverEvap.Selector = Nothing
        Me.ucrReceiverEvap.strNcFilePath = ""
        Me.ucrReceiverEvap.ucrSelector = Nothing
        '
        'ucrInputEvaporation
        '
        Me.ucrInputEvaporation.AddQuotesIfUnrecognised = True
        Me.ucrInputEvaporation.IsMultiline = False
        Me.ucrInputEvaporation.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputEvaporation, "ucrInputEvaporation")
        Me.ucrInputEvaporation.Name = "ucrInputEvaporation"
        '
        'ucrChkGroupByYear
        '
        Me.ucrChkGroupByYear.Checked = False
        resources.ApplyResources(Me.ucrChkGroupByYear, "ucrChkGroupByYear")
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
        'ucrInputCumulative
        '
        Me.ucrInputCumulative.AddQuotesIfUnrecognised = True
        Me.ucrInputCumulative.GetSetSelectedIndex = -1
        Me.ucrInputCumulative.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputCumulative, "ucrInputCumulative")
        Me.ucrInputCumulative.Name = "ucrInputCumulative"
        '
        'ucrInputCircularPosition
        '
        Me.ucrInputCircularPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputCircularPosition.GetSetSelectedIndex = -1
        Me.ucrInputCircularPosition.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputCircularPosition, "ucrInputCircularPosition")
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
        Me.ucrInputPosition.GetSetSelectedIndex = -1
        Me.ucrInputPosition.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPosition, "ucrInputPosition")
        Me.ucrInputPosition.Name = "ucrInputPosition"
        '
        'ucrChkCircular
        '
        Me.ucrChkCircular.Checked = False
        resources.ApplyResources(Me.ucrChkCircular, "ucrChkCircular")
        Me.ucrChkCircular.Name = "ucrChkCircular"
        '
        'ucrNudMultSpells
        '
        Me.ucrNudMultSpells.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMultSpells.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMultSpells, "ucrNudMultSpells")
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
        Me.ucrInputSpellUpper.IsMultiline = False
        Me.ucrInputSpellUpper.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSpellUpper, "ucrInputSpellUpper")
        Me.ucrInputSpellUpper.Name = "ucrInputSpellUpper"
        '
        'ucrInputCondition
        '
        Me.ucrInputCondition.AddQuotesIfUnrecognised = True
        Me.ucrInputCondition.GetSetSelectedIndex = -1
        Me.ucrInputCondition.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputCondition, "ucrInputCondition")
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
        'ucrInputSpellLower
        '
        Me.ucrInputSpellLower.AddQuotesIfUnrecognised = True
        Me.ucrInputSpellLower.IsMultiline = False
        Me.ucrInputSpellLower.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSpellLower, "ucrInputSpellLower")
        Me.ucrInputSpellLower.Name = "ucrInputSpellLower"
        '
        'ucrNudSumOver
        '
        Me.ucrNudSumOver.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSumOver.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSumOver, "ucrNudSumOver")
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
        Me.ucrNudWBCapacity.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWBCapacity.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudWBCapacity, "ucrNudWBCapacity")
        Me.ucrNudWBCapacity.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWBCapacity.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWBCapacity.Name = "ucrNudWBCapacity"
        Me.ucrNudWBCapacity.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputSum
        '
        Me.ucrInputSum.AddQuotesIfUnrecognised = True
        Me.ucrInputSum.GetSetSelectedIndex = -1
        Me.ucrInputSum.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSum, "ucrInputSum")
        Me.ucrInputSum.Name = "ucrInputSum"
        '
        'ucrNudCountOver
        '
        Me.ucrNudCountOver.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCountOver.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudCountOver, "ucrNudCountOver")
        Me.ucrNudCountOver.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCountOver.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCountOver.Name = "ucrNudCountOver"
        Me.ucrNudCountOver.Value = New Decimal(New Integer() {0, 0, 0, 0})
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
        Me.ucrReceiverDate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDate, "ucrReceiverDate")
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverYear, "ucrReceiverYear")
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverStation, "ucrReceiverStation")
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverData
        '
        Me.ucrReceiverData.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverData, "ucrReceiverData")
        Me.ucrReceiverData.Name = "ucrReceiverData"
        Me.ucrReceiverData.Selector = Nothing
        Me.ucrReceiverData.strNcFilePath = ""
        Me.ucrReceiverData.ucrSelector = Nothing
        '
        'ucrSelectorTransform
        '
        Me.ucrSelectorTransform.bDropUnusedFilterLevels = False
        Me.ucrSelectorTransform.bShowHiddenColumns = False
        Me.ucrSelectorTransform.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorTransform, "ucrSelectorTransform")
        Me.ucrSelectorTransform.Name = "ucrSelectorTransform"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgTransformClimatic
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveColumn)
        Me.Controls.Add(Me.rdoCumulative)
        Me.Controls.Add(Me.rdoMultSpells)
        Me.Controls.Add(Me.grpTransform)
        Me.Controls.Add(Me.rdoWaterBalance)
        Me.Controls.Add(Me.rdoSpell)
        Me.Controls.Add(Me.rdoMoving)
        Me.Controls.Add(Me.rdoCount)
        Me.Controls.Add(Me.ucrPnlTransform)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrReceiverData)
        Me.Controls.Add(Me.ucrSelectorTransform)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTransformClimatic"
        Me.grpTransform.ResumeLayout(False)
        Me.grpTransform.PerformLayout()
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
    Friend WithEvents ucrInputSpellLower As ucrInputTextBox
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
End Class
