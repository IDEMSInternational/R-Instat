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
        Me.lblYear.AutoSize = True
        Me.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYear.Location = New System.Drawing.Point(272, 164)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 12
        Me.lblYear.Text = "Year:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(272, 117)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "Date:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStation.Location = New System.Drawing.Point(272, 67)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 6
        Me.lblStation.Text = "Station:"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblData.Location = New System.Drawing.Point(272, 212)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(48, 13)
        Me.lblData.TabIndex = 16
        Me.lblData.Text = "Element:"
        '
        'rdoSpell
        '
        Me.rdoSpell.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSpell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoSpell.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSpell.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSpell.FlatAppearance.BorderSize = 2
        Me.rdoSpell.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSpell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSpell.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoSpell.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSpell.Location = New System.Drawing.Point(283, 15)
        Me.rdoSpell.Name = "rdoSpell"
        Me.rdoSpell.Size = New System.Drawing.Size(64, 28)
        Me.rdoSpell.TabIndex = 3
        Me.rdoSpell.Text = "Spell"
        Me.rdoSpell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSpell.UseVisualStyleBackColor = True
        '
        'rdoMoving
        '
        Me.rdoMoving.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMoving.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoMoving.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMoving.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoMoving.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMoving.FlatAppearance.BorderSize = 2
        Me.rdoMoving.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMoving.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMoving.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoMoving.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMoving.Location = New System.Drawing.Point(194, 15)
        Me.rdoMoving.Name = "rdoMoving"
        Me.rdoMoving.Size = New System.Drawing.Size(91, 28)
        Me.rdoMoving.TabIndex = 2
        Me.rdoMoving.Text = "Moving"
        Me.rdoMoving.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMoving.UseVisualStyleBackColor = True
        '
        'rdoCount
        '
        Me.rdoCount.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoCount.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCount.FlatAppearance.BorderSize = 2
        Me.rdoCount.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoCount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCount.Location = New System.Drawing.Point(105, 15)
        Me.rdoCount.Name = "rdoCount"
        Me.rdoCount.Size = New System.Drawing.Size(91, 28)
        Me.rdoCount.TabIndex = 1
        Me.rdoCount.Text = "Count"
        Me.rdoCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoCount.UseVisualStyleBackColor = True
        '
        'rdoWaterBalance
        '
        Me.rdoWaterBalance.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoWaterBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoWaterBalance.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoWaterBalance.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWaterBalance.FlatAppearance.BorderSize = 2
        Me.rdoWaterBalance.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWaterBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoWaterBalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoWaterBalance.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoWaterBalance.Location = New System.Drawing.Point(434, 15)
        Me.rdoWaterBalance.Name = "rdoWaterBalance"
        Me.rdoWaterBalance.Size = New System.Drawing.Size(117, 28)
        Me.rdoWaterBalance.TabIndex = 4
        Me.rdoWaterBalance.Text = "Water Balance"
        Me.rdoWaterBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoWaterBalance.UseVisualStyleBackColor = True
        '
        'lblSumRows
        '
        Me.lblSumRows.AutoSize = True
        Me.lblSumRows.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSumRows.Location = New System.Drawing.Point(245, 24)
        Me.lblSumRows.Name = "lblSumRows"
        Me.lblSumRows.Size = New System.Drawing.Size(34, 13)
        Me.lblSumRows.TabIndex = 5
        Me.lblSumRows.Tag = "Rows"
        Me.lblSumRows.Text = "Rows"
        '
        'lblSumOver
        '
        Me.lblSumOver.AutoSize = True
        Me.lblSumOver.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSumOver.Location = New System.Drawing.Point(157, 24)
        Me.lblSumOver.Name = "lblSumOver"
        Me.lblSumOver.Size = New System.Drawing.Size(30, 13)
        Me.lblSumOver.TabIndex = 3
        Me.lblSumOver.Tag = "Over"
        Me.lblSumOver.Text = "Over"
        '
        'lblCountOver
        '
        Me.lblCountOver.AutoSize = True
        Me.lblCountOver.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCountOver.Location = New System.Drawing.Point(12, 24)
        Me.lblCountOver.Name = "lblCountOver"
        Me.lblCountOver.Size = New System.Drawing.Size(106, 13)
        Me.lblCountOver.TabIndex = 8
        Me.lblCountOver.Tag = "Rows_to_Count_Over:"
        Me.lblCountOver.Text = "Rows to Count Over:"
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
        Me.grpTransform.Location = New System.Drawing.Point(10, 261)
        Me.grpTransform.Name = "grpTransform"
        Me.grpTransform.Size = New System.Drawing.Size(376, 142)
        Me.grpTransform.TabIndex = 18
        Me.grpTransform.TabStop = False
        Me.grpTransform.Text = "Options"
        '
        'ucrReceiverEvap
        '
        Me.ucrReceiverEvap.AutoSize = True
        Me.ucrReceiverEvap.frmParent = Me
        Me.ucrReceiverEvap.Location = New System.Drawing.Point(155, 79)
        Me.ucrReceiverEvap.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEvap.Name = "ucrReceiverEvap"
        Me.ucrReceiverEvap.Selector = Nothing
        Me.ucrReceiverEvap.Size = New System.Drawing.Size(103, 20)
        Me.ucrReceiverEvap.strNcFilePath = ""
        Me.ucrReceiverEvap.TabIndex = 37
        Me.ucrReceiverEvap.ucrSelector = Nothing
        '
        'ucrInputEvaporation
        '
        Me.ucrInputEvaporation.AddQuotesIfUnrecognised = True
        Me.ucrInputEvaporation.AutoSize = True
        Me.ucrInputEvaporation.IsMultiline = False
        Me.ucrInputEvaporation.IsReadOnly = False
        Me.ucrInputEvaporation.Location = New System.Drawing.Point(155, 53)
        Me.ucrInputEvaporation.Name = "ucrInputEvaporation"
        Me.ucrInputEvaporation.Size = New System.Drawing.Size(103, 21)
        Me.ucrInputEvaporation.TabIndex = 31
        '
        'ucrChkGroupByYear
        '
        Me.ucrChkGroupByYear.AutoSize = True
        Me.ucrChkGroupByYear.Checked = False
        Me.ucrChkGroupByYear.Location = New System.Drawing.Point(24, 112)
        Me.ucrChkGroupByYear.Name = "ucrChkGroupByYear"
        Me.ucrChkGroupByYear.Size = New System.Drawing.Size(174, 23)
        Me.ucrChkGroupByYear.TabIndex = 22
        '
        'rdoEvapVariable
        '
        Me.rdoEvapVariable.AutoSize = True
        Me.rdoEvapVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoEvapVariable.Location = New System.Drawing.Point(87, 82)
        Me.rdoEvapVariable.Name = "rdoEvapVariable"
        Me.rdoEvapVariable.Size = New System.Drawing.Size(66, 17)
        Me.rdoEvapVariable.TabIndex = 36
        Me.rdoEvapVariable.TabStop = True
        Me.rdoEvapVariable.Text = "Variable:"
        Me.rdoEvapVariable.UseVisualStyleBackColor = True
        '
        'rdoEvapValue
        '
        Me.rdoEvapValue.AutoSize = True
        Me.rdoEvapValue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoEvapValue.Location = New System.Drawing.Point(87, 54)
        Me.rdoEvapValue.Name = "rdoEvapValue"
        Me.rdoEvapValue.Size = New System.Drawing.Size(55, 17)
        Me.rdoEvapValue.TabIndex = 35
        Me.rdoEvapValue.TabStop = True
        Me.rdoEvapValue.Text = "Value:"
        Me.rdoEvapValue.UseVisualStyleBackColor = True
        '
        'ucrPnlEvap
        '
        Me.ucrPnlEvap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlEvap.Location = New System.Drawing.Point(86, 43)
        Me.ucrPnlEvap.Name = "ucrPnlEvap"
        Me.ucrPnlEvap.Size = New System.Drawing.Size(63, 57)
        Me.ucrPnlEvap.TabIndex = 29
        '
        'ucrInputCumulative
        '
        Me.ucrInputCumulative.AddQuotesIfUnrecognised = True
        Me.ucrInputCumulative.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCumulative.GetSetSelectedIndex = -1
        Me.ucrInputCumulative.IsReadOnly = False
        Me.ucrInputCumulative.Location = New System.Drawing.Point(24, 21)
        Me.ucrInputCumulative.Name = "ucrInputCumulative"
        Me.ucrInputCumulative.Size = New System.Drawing.Size(112, 21)
        Me.ucrInputCumulative.TabIndex = 26
        '
        'ucrInputCircularPosition
        '
        Me.ucrInputCircularPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputCircularPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCircularPosition.GetSetSelectedIndex = -1
        Me.ucrInputCircularPosition.IsReadOnly = False
        Me.ucrInputCircularPosition.Location = New System.Drawing.Point(199, 55)
        Me.ucrInputCircularPosition.Name = "ucrInputCircularPosition"
        Me.ucrInputCircularPosition.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputCircularPosition.TabIndex = 27
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPosition.Location = New System.Drawing.Point(151, 59)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(47, 13)
        Me.lblPosition.TabIndex = 25
        Me.lblPosition.Text = "Position:"
        '
        'ucrInputPosition
        '
        Me.ucrInputPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPosition.GetSetSelectedIndex = -1
        Me.ucrInputPosition.IsReadOnly = False
        Me.ucrInputPosition.Location = New System.Drawing.Point(199, 55)
        Me.ucrInputPosition.Name = "ucrInputPosition"
        Me.ucrInputPosition.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPosition.TabIndex = 24
        '
        'ucrChkCircular
        '
        Me.ucrChkCircular.AutoSize = True
        Me.ucrChkCircular.Checked = False
        Me.ucrChkCircular.Location = New System.Drawing.Point(24, 58)
        Me.ucrChkCircular.Name = "ucrChkCircular"
        Me.ucrChkCircular.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkCircular.TabIndex = 26
        '
        'ucrNudMultSpells
        '
        Me.ucrNudMultSpells.AutoSize = True
        Me.ucrNudMultSpells.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMultSpells.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMultSpells.Location = New System.Drawing.Point(194, 21)
        Me.ucrNudMultSpells.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMultSpells.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMultSpells.Name = "ucrNudMultSpells"
        Me.ucrNudMultSpells.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMultSpells.TabIndex = 15
        Me.ucrNudMultSpells.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblRowsMultSpells
        '
        Me.lblRowsMultSpells.AutoSize = True
        Me.lblRowsMultSpells.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRowsMultSpells.Location = New System.Drawing.Point(12, 25)
        Me.lblRowsMultSpells.Name = "lblRowsMultSpells"
        Me.lblRowsMultSpells.Size = New System.Drawing.Size(126, 13)
        Me.lblRowsMultSpells.TabIndex = 14
        Me.lblRowsMultSpells.Tag = "Rows_to_Take_Over:"
        Me.lblRowsMultSpells.Text = "Rows to Take Max Over:"
        '
        'ucrInputSpellUpper
        '
        Me.ucrInputSpellUpper.AddQuotesIfUnrecognised = True
        Me.ucrInputSpellUpper.AutoSize = True
        Me.ucrInputSpellUpper.IsMultiline = False
        Me.ucrInputSpellUpper.IsReadOnly = False
        Me.ucrInputSpellUpper.Location = New System.Drawing.Point(285, 50)
        Me.ucrInputSpellUpper.Name = "ucrInputSpellUpper"
        Me.ucrInputSpellUpper.Size = New System.Drawing.Size(49, 21)
        Me.ucrInputSpellUpper.TabIndex = 13
        '
        'ucrInputCondition
        '
        Me.ucrInputCondition.AddQuotesIfUnrecognised = True
        Me.ucrInputCondition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCondition.GetSetSelectedIndex = -1
        Me.ucrInputCondition.IsReadOnly = False
        Me.ucrInputCondition.Location = New System.Drawing.Point(124, 50)
        Me.ucrInputCondition.Name = "ucrInputCondition"
        Me.ucrInputCondition.Size = New System.Drawing.Size(155, 21)
        Me.ucrInputCondition.TabIndex = 12
        '
        'lblCondition
        '
        Me.lblCondition.AutoSize = True
        Me.lblCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCondition.Location = New System.Drawing.Point(12, 53)
        Me.lblCondition.Name = "lblCondition"
        Me.lblCondition.Size = New System.Drawing.Size(54, 13)
        Me.lblCondition.TabIndex = 10
        Me.lblCondition.Tag = "Condition:"
        Me.lblCondition.Text = "Condition:"
        '
        'lblWBEvaporation
        '
        Me.lblWBEvaporation.AutoSize = True
        Me.lblWBEvaporation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWBEvaporation.Location = New System.Drawing.Point(13, 55)
        Me.lblWBEvaporation.Name = "lblWBEvaporation"
        Me.lblWBEvaporation.Size = New System.Drawing.Size(67, 13)
        Me.lblWBEvaporation.TabIndex = 6
        Me.lblWBEvaporation.Tag = "Evaporation"
        Me.lblWBEvaporation.Text = "Evaporation:"
        '
        'ucrInputSpellLower
        '
        Me.ucrInputSpellLower.AddQuotesIfUnrecognised = True
        Me.ucrInputSpellLower.AutoSize = True
        Me.ucrInputSpellLower.IsMultiline = False
        Me.ucrInputSpellLower.IsReadOnly = False
        Me.ucrInputSpellLower.Location = New System.Drawing.Point(69, 50)
        Me.ucrInputSpellLower.Name = "ucrInputSpellLower"
        Me.ucrInputSpellLower.Size = New System.Drawing.Size(49, 21)
        Me.ucrInputSpellLower.TabIndex = 11
        '
        'ucrNudSumOver
        '
        Me.ucrNudSumOver.AutoSize = True
        Me.ucrNudSumOver.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSumOver.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSumOver.Location = New System.Drawing.Point(193, 21)
        Me.ucrNudSumOver.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSumOver.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSumOver.Name = "ucrNudSumOver"
        Me.ucrNudSumOver.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSumOver.TabIndex = 4
        Me.ucrNudSumOver.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblWBCapacity
        '
        Me.lblWBCapacity.AutoSize = True
        Me.lblWBCapacity.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWBCapacity.Location = New System.Drawing.Point(13, 25)
        Me.lblWBCapacity.Name = "lblWBCapacity"
        Me.lblWBCapacity.Size = New System.Drawing.Size(51, 13)
        Me.lblWBCapacity.TabIndex = 1
        Me.lblWBCapacity.Tag = "Capacity"
        Me.lblWBCapacity.Text = "Capacity:"
        '
        'ucrNudWBCapacity
        '
        Me.ucrNudWBCapacity.AutoSize = True
        Me.ucrNudWBCapacity.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWBCapacity.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWBCapacity.Location = New System.Drawing.Point(86, 21)
        Me.ucrNudWBCapacity.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWBCapacity.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWBCapacity.Name = "ucrNudWBCapacity"
        Me.ucrNudWBCapacity.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWBCapacity.TabIndex = 2
        Me.ucrNudWBCapacity.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputSum
        '
        Me.ucrInputSum.AddQuotesIfUnrecognised = True
        Me.ucrInputSum.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSum.GetSetSelectedIndex = -1
        Me.ucrInputSum.IsReadOnly = False
        Me.ucrInputSum.Location = New System.Drawing.Point(24, 21)
        Me.ucrInputSum.Name = "ucrInputSum"
        Me.ucrInputSum.Size = New System.Drawing.Size(112, 21)
        Me.ucrInputSum.TabIndex = 0
        '
        'ucrNudCountOver
        '
        Me.ucrNudCountOver.AutoSize = True
        Me.ucrNudCountOver.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCountOver.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCountOver.Location = New System.Drawing.Point(134, 21)
        Me.ucrNudCountOver.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCountOver.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCountOver.Name = "ucrNudCountOver"
        Me.ucrNudCountOver.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCountOver.TabIndex = 9
        Me.ucrNudCountOver.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoMultSpells
        '
        Me.rdoMultSpells.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMultSpells.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoMultSpells.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMultSpells.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultSpells.FlatAppearance.BorderSize = 2
        Me.rdoMultSpells.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultSpells.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMultSpells.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoMultSpells.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMultSpells.Location = New System.Drawing.Point(345, 15)
        Me.rdoMultSpells.Name = "rdoMultSpells"
        Me.rdoMultSpells.Size = New System.Drawing.Size(91, 28)
        Me.rdoMultSpells.TabIndex = 23
        Me.rdoMultSpells.Text = "Multiple Spells"
        Me.rdoMultSpells.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMultSpells.UseVisualStyleBackColor = True
        '
        'rdoCumulative
        '
        Me.rdoCumulative.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoCumulative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoCumulative.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoCumulative.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCumulative.FlatAppearance.BorderSize = 2
        Me.rdoCumulative.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCumulative.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCumulative.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoCumulative.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCumulative.Location = New System.Drawing.Point(16, 15)
        Me.rdoCumulative.Name = "rdoCumulative"
        Me.rdoCumulative.Size = New System.Drawing.Size(91, 28)
        Me.rdoCumulative.TabIndex = 25
        Me.rdoCumulative.Text = "Cumulative"
        Me.rdoCumulative.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoCumulative.UseVisualStyleBackColor = True
        '
        'ucrSaveColumn
        '
        Me.ucrSaveColumn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveColumn.Location = New System.Drawing.Point(11, 411)
        Me.ucrSaveColumn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveColumn.Name = "ucrSaveColumn"
        Me.ucrSaveColumn.Size = New System.Drawing.Size(335, 21)
        Me.ucrSaveColumn.TabIndex = 20
        '
        'ucrPnlTransform
        '
        Me.ucrPnlTransform.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlTransform.Location = New System.Drawing.Point(12, 9)
        Me.ucrPnlTransform.Name = "ucrPnlTransform"
        Me.ucrPnlTransform.Size = New System.Drawing.Size(543, 49)
        Me.ucrPnlTransform.TabIndex = 0
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(275, 130)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 9
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(275, 177)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 13
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(275, 80)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 7
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverData
        '
        Me.ucrReceiverData.AutoSize = True
        Me.ucrReceiverData.frmParent = Me
        Me.ucrReceiverData.Location = New System.Drawing.Point(275, 225)
        Me.ucrReceiverData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverData.Name = "ucrReceiverData"
        Me.ucrReceiverData.Selector = Nothing
        Me.ucrReceiverData.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverData.strNcFilePath = ""
        Me.ucrReceiverData.TabIndex = 17
        Me.ucrReceiverData.ucrSelector = Nothing
        '
        'ucrSelectorTransform
        '
        Me.ucrSelectorTransform.AutoSize = True
        Me.ucrSelectorTransform.bDropUnusedFilterLevels = False
        Me.ucrSelectorTransform.bShowHiddenColumns = False
        Me.ucrSelectorTransform.bUseCurrentFilter = True
        Me.ucrSelectorTransform.Location = New System.Drawing.Point(10, 61)
        Me.ucrSelectorTransform.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTransform.Name = "ucrSelectorTransform"
        Me.ucrSelectorTransform.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorTransform.TabIndex = 5
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 437)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 21
        '
        'dlgTransformClimatic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(566, 490)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transform"
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
