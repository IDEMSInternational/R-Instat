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
        Me.lblNewColName = New System.Windows.Forms.Label()
        Me.lblCountOver = New System.Windows.Forms.Label()
        Me.grpTransform = New System.Windows.Forms.GroupBox()
        Me.ucrInputSpellUpper = New instat.ucrInputTextBox()
        Me.ucrInputCondition = New instat.ucrInputComboBox()
        Me.ucrInputEvaporation = New instat.ucrInputTextBox()
        Me.lblCondition = New System.Windows.Forms.Label()
        Me.lblWBEvaporation = New System.Windows.Forms.Label()
        Me.ucrInputSpellLower = New instat.ucrInputTextBox()
        Me.ucrNudSumOver = New instat.ucrNud()
        Me.lblWBCapacity = New System.Windows.Forms.Label()
        Me.ucrNudWBCapacity = New instat.ucrNud()
        Me.ucrInputSum = New instat.ucrInputComboBox()
        Me.ucrNudCountOver = New instat.ucrNud()
        Me.ucrInputColName = New instat.ucrInputTextBox()
        Me.ucrPnlTransform = New instat.UcrPanel()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverData = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorTransform = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpTransform.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(242, 172)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 12
        Me.lblYear.Text = "Year:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(242, 129)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "Date:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(242, 86)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 6
        Me.lblStation.Text = "Station:"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(242, 215)
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
        Me.rdoSpell.Location = New System.Drawing.Point(207, 10)
        Me.rdoSpell.Name = "rdoSpell"
        Me.rdoSpell.Size = New System.Drawing.Size(91, 28)
        Me.rdoSpell.TabIndex = 3
        Me.rdoSpell.Text = "Spell"
        Me.rdoSpell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSpell.UseVisualStyleBackColor = True
        '
        'rdoMoving
        '
        Me.rdoMoving.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMoving.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.rdoMoving.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMoving.FlatAppearance.BorderSize = 2
        Me.rdoMoving.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMoving.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMoving.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoMoving.Location = New System.Drawing.Point(118, 10)
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
        Me.rdoCount.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoCount.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCount.FlatAppearance.BorderSize = 2
        Me.rdoCount.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoCount.Location = New System.Drawing.Point(29, 10)
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
        Me.rdoWaterBalance.Location = New System.Drawing.Point(296, 10)
        Me.rdoWaterBalance.Name = "rdoWaterBalance"
        Me.rdoWaterBalance.Size = New System.Drawing.Size(91, 28)
        Me.rdoWaterBalance.TabIndex = 4
        Me.rdoWaterBalance.Text = "Water Balance"
        Me.rdoWaterBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoWaterBalance.UseVisualStyleBackColor = True
        '
        'lblSumRows
        '
        Me.lblSumRows.AutoSize = True
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
        Me.lblSumOver.Location = New System.Drawing.Point(157, 24)
        Me.lblSumOver.Name = "lblSumOver"
        Me.lblSumOver.Size = New System.Drawing.Size(30, 13)
        Me.lblSumOver.TabIndex = 3
        Me.lblSumOver.Tag = "Over"
        Me.lblSumOver.Text = "Over"
        '
        'lblNewColName
        '
        Me.lblNewColName.AutoSize = True
        Me.lblNewColName.Location = New System.Drawing.Point(6, 352)
        Me.lblNewColName.Name = "lblNewColName"
        Me.lblNewColName.Size = New System.Drawing.Size(101, 13)
        Me.lblNewColName.TabIndex = 19
        Me.lblNewColName.Tag = "New Column Name:"
        Me.lblNewColName.Text = "New Column Name:"
        '
        'lblCountOver
        '
        Me.lblCountOver.AutoSize = True
        Me.lblCountOver.Location = New System.Drawing.Point(12, 24)
        Me.lblCountOver.Name = "lblCountOver"
        Me.lblCountOver.Size = New System.Drawing.Size(106, 13)
        Me.lblCountOver.TabIndex = 8
        Me.lblCountOver.Tag = "Rows_to_Count_Over:"
        Me.lblCountOver.Text = "Rows to Count Over:"
        '
        'grpTransform
        '
        Me.grpTransform.Controls.Add(Me.ucrInputSpellUpper)
        Me.grpTransform.Controls.Add(Me.lblSumRows)
        Me.grpTransform.Controls.Add(Me.ucrInputCondition)
        Me.grpTransform.Controls.Add(Me.ucrInputEvaporation)
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
        Me.grpTransform.Location = New System.Drawing.Point(9, 262)
        Me.grpTransform.Name = "grpTransform"
        Me.grpTransform.Size = New System.Drawing.Size(376, 82)
        Me.grpTransform.TabIndex = 18
        Me.grpTransform.TabStop = False
        Me.grpTransform.Text = "Options"
        '
        'ucrInputSpellUpper
        '
        Me.ucrInputSpellUpper.AddQuotesIfUnrecognised = True
        Me.ucrInputSpellUpper.IsMultiline = False
        Me.ucrInputSpellUpper.IsReadOnly = False
        Me.ucrInputSpellUpper.Location = New System.Drawing.Point(296, 46)
        Me.ucrInputSpellUpper.Name = "ucrInputSpellUpper"
        Me.ucrInputSpellUpper.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputSpellUpper.TabIndex = 13
        '
        'ucrInputCondition
        '
        Me.ucrInputCondition.AddQuotesIfUnrecognised = True
        Me.ucrInputCondition.IsReadOnly = False
        Me.ucrInputCondition.Location = New System.Drawing.Point(135, 46)
        Me.ucrInputCondition.Name = "ucrInputCondition"
        Me.ucrInputCondition.Size = New System.Drawing.Size(155, 21)
        Me.ucrInputCondition.TabIndex = 12
        '
        'ucrInputEvaporation
        '
        Me.ucrInputEvaporation.AddQuotesIfUnrecognised = True
        Me.ucrInputEvaporation.IsMultiline = False
        Me.ucrInputEvaporation.IsReadOnly = False
        Me.ucrInputEvaporation.Location = New System.Drawing.Point(86, 47)
        Me.ucrInputEvaporation.Name = "ucrInputEvaporation"
        Me.ucrInputEvaporation.Size = New System.Drawing.Size(98, 21)
        Me.ucrInputEvaporation.TabIndex = 7
        '
        'lblCondition
        '
        Me.lblCondition.AutoSize = True
        Me.lblCondition.Location = New System.Drawing.Point(12, 50)
        Me.lblCondition.Name = "lblCondition"
        Me.lblCondition.Size = New System.Drawing.Size(54, 13)
        Me.lblCondition.TabIndex = 10
        Me.lblCondition.Tag = "Condition:"
        Me.lblCondition.Text = "Condition:"
        '
        'lblWBEvaporation
        '
        Me.lblWBEvaporation.AutoSize = True
        Me.lblWBEvaporation.Location = New System.Drawing.Point(13, 50)
        Me.lblWBEvaporation.Name = "lblWBEvaporation"
        Me.lblWBEvaporation.Size = New System.Drawing.Size(67, 13)
        Me.lblWBEvaporation.TabIndex = 6
        Me.lblWBEvaporation.Tag = "Evaporation"
        Me.lblWBEvaporation.Text = "Evaporation:"
        '
        'ucrInputSpellLower
        '
        Me.ucrInputSpellLower.AddQuotesIfUnrecognised = True
        Me.ucrInputSpellLower.IsMultiline = False
        Me.ucrInputSpellLower.IsReadOnly = False
        Me.ucrInputSpellLower.Location = New System.Drawing.Point(69, 47)
        Me.ucrInputSpellLower.Name = "ucrInputSpellLower"
        Me.ucrInputSpellLower.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputSpellLower.TabIndex = 11
        '
        'ucrNudSumOver
        '
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
        Me.lblWBCapacity.Location = New System.Drawing.Point(13, 25)
        Me.lblWBCapacity.Name = "lblWBCapacity"
        Me.lblWBCapacity.Size = New System.Drawing.Size(51, 13)
        Me.lblWBCapacity.TabIndex = 1
        Me.lblWBCapacity.Tag = "Capacity"
        Me.lblWBCapacity.Text = "Capacity:"
        '
        'ucrNudWBCapacity
        '
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
        Me.ucrInputSum.IsReadOnly = False
        Me.ucrInputSum.Location = New System.Drawing.Point(24, 21)
        Me.ucrInputSum.Name = "ucrInputSum"
        Me.ucrInputSum.Size = New System.Drawing.Size(112, 21)
        Me.ucrInputSum.TabIndex = 0
        '
        'ucrNudCountOver
        '
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
        'ucrInputColName
        '
        Me.ucrInputColName.AddQuotesIfUnrecognised = True
        Me.ucrInputColName.IsMultiline = False
        Me.ucrInputColName.IsReadOnly = False
        Me.ucrInputColName.Location = New System.Drawing.Point(112, 349)
        Me.ucrInputColName.Name = "ucrInputColName"
        Me.ucrInputColName.Size = New System.Drawing.Size(181, 21)
        Me.ucrInputColName.TabIndex = 20
        '
        'ucrPnlTransform
        '
        Me.ucrPnlTransform.Location = New System.Drawing.Point(8, 9)
        Me.ucrPnlTransform.Name = "ucrPnlTransform"
        Me.ucrPnlTransform.Size = New System.Drawing.Size(409, 29)
        Me.ucrPnlTransform.TabIndex = 0
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(242, 101)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 7
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(242, 187)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 13
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(242, 144)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 9
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverData
        '
        Me.ucrReceiverData.frmParent = Me
        Me.ucrReceiverData.Location = New System.Drawing.Point(242, 230)
        Me.ucrReceiverData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverData.Name = "ucrReceiverData"
        Me.ucrReceiverData.Selector = Nothing
        Me.ucrReceiverData.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverData.strNcFilePath = ""
        Me.ucrReceiverData.TabIndex = 17
        Me.ucrReceiverData.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 376)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(402, 52)
        Me.ucrBase.TabIndex = 21
        '
        'ucrSelectorTransform
        '
        Me.ucrSelectorTransform.bShowHiddenColumns = False
        Me.ucrSelectorTransform.bUseCurrentFilter = True
        Me.ucrSelectorTransform.Location = New System.Drawing.Point(9, 51)
        Me.ucrSelectorTransform.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTransform.Name = "ucrSelectorTransform"
        Me.ucrSelectorTransform.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorTransform.TabIndex = 5
        '
        'dlgTransformClimatic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 434)
        Me.Controls.Add(Me.grpTransform)
        Me.Controls.Add(Me.lblNewColName)
        Me.Controls.Add(Me.ucrInputColName)
        Me.Controls.Add(Me.rdoWaterBalance)
        Me.Controls.Add(Me.rdoSpell)
        Me.Controls.Add(Me.rdoMoving)
        Me.Controls.Add(Me.rdoCount)
        Me.Controls.Add(Me.ucrPnlTransform)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrSelectorTransform)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.ucrReceiverData)
        Me.Controls.Add(Me.ucrBase)
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
    Friend WithEvents ucrInputColName As ucrInputTextBox
    Friend WithEvents lblNewColName As Label
    Friend WithEvents ucrNudCountOver As ucrNud
    Friend WithEvents lblCountOver As Label
    Friend WithEvents ucrInputEvaporation As ucrInputTextBox
    Friend WithEvents lblWBEvaporation As Label
    Friend WithEvents ucrNudWBCapacity As ucrNud
    Friend WithEvents lblWBCapacity As Label
    Friend WithEvents grpTransform As GroupBox
    Friend WithEvents ucrInputSpellLower As ucrInputTextBox
    Friend WithEvents ucrInputSpellUpper As ucrInputTextBox
    Friend WithEvents ucrInputCondition As ucrInputComboBox
    Friend WithEvents lblCondition As Label
End Class
