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
Partial Class dlgReorderLevels
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
        Me.components = New System.ComponentModel.Container()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.rdoHand = New System.Windows.Forms.RadioButton()
        Me.rdoProperty = New System.Windows.Forms.RadioButton()
        Me.rdoVariable = New System.Windows.Forms.RadioButton()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpMethods = New System.Windows.Forms.GroupBox()
        Me.rdoAlphabetical = New System.Windows.Forms.RadioButton()
        Me.ucrInputOrder = New instat.ucrInputComboBox()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.ucrInputPrefix = New instat.ucrInputTextBox()
        Me.lblPrefix = New System.Windows.Forms.Label()
        Me.rdoAnonymise = New System.Windows.Forms.RadioButton()
        Me.rdoShuffle = New System.Windows.Forms.RadioButton()
        Me.ucrNudShift = New instat.ucrNud()
        Me.rdoShift = New System.Windows.Forms.RadioButton()
        Me.rdoSequence = New System.Windows.Forms.RadioButton()
        Me.rdoFrequency = New System.Windows.Forms.RadioButton()
        Me.rdoAppearance = New System.Windows.Forms.RadioButton()
        Me.rdoReverseLevels = New System.Windows.Forms.RadioButton()
        Me.ucrPnlProperty = New instat.UcrPanel()
        Me.ttMethods = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrReceiverFactorX = New instat.ucrReceiverSingle()
        Me.ucrSaveResults = New instat.ucrSave()
        Me.ucrInputOptions = New instat.ucrInputComboBox()
        Me.ucrChkReverseVariable = New instat.ucrCheck()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverVariable = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReorderFactor = New instat.ucrReorder()
        Me.ucrSelectorFactorLevelsToReorder = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpMethods.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactor.Location = New System.Drawing.Point(236, 75)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(85, 13)
        Me.lblFactor.TabIndex = 5
        Me.lblFactor.Tag = "Factor_Selected:"
        Me.lblFactor.Text = "Factor Selected:"
        '
        'rdoHand
        '
        Me.rdoHand.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoHand.BackColor = System.Drawing.SystemColors.Control
        Me.rdoHand.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHand.FlatAppearance.BorderSize = 2
        Me.rdoHand.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoHand.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHand.Location = New System.Drawing.Point(127, 12)
        Me.rdoHand.Name = "rdoHand"
        Me.rdoHand.Size = New System.Drawing.Size(70, 28)
        Me.rdoHand.TabIndex = 1
        Me.rdoHand.TabStop = True
        Me.rdoHand.Tag = "Hand"
        Me.rdoHand.Text = "Hand"
        Me.rdoHand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoHand.UseVisualStyleBackColor = False
        '
        'rdoProperty
        '
        Me.rdoProperty.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoProperty.BackColor = System.Drawing.SystemColors.Control
        Me.rdoProperty.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoProperty.FlatAppearance.BorderSize = 2
        Me.rdoProperty.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoProperty.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoProperty.Location = New System.Drawing.Point(196, 12)
        Me.rdoProperty.Name = "rdoProperty"
        Me.rdoProperty.Size = New System.Drawing.Size(84, 28)
        Me.rdoProperty.TabIndex = 2
        Me.rdoProperty.TabStop = True
        Me.rdoProperty.Tag = "Property"
        Me.rdoProperty.Text = "Property"
        Me.rdoProperty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoProperty.UseVisualStyleBackColor = False
        '
        'rdoVariable
        '
        Me.rdoVariable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoVariable.BackColor = System.Drawing.SystemColors.Control
        Me.rdoVariable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVariable.FlatAppearance.BorderSize = 2
        Me.rdoVariable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoVariable.Location = New System.Drawing.Point(279, 12)
        Me.rdoVariable.Name = "rdoVariable"
        Me.rdoVariable.Size = New System.Drawing.Size(87, 28)
        Me.rdoVariable.TabIndex = 3
        Me.rdoVariable.TabStop = True
        Me.rdoVariable.Tag = "Variable"
        Me.rdoVariable.Text = "Variable"
        Me.rdoVariable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoVariable.UseVisualStyleBackColor = False
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVariable.Location = New System.Drawing.Point(236, 117)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(48, 13)
        Me.lblVariable.TabIndex = 9
        Me.lblVariable.Tag = "Variable:"
        Me.lblVariable.Text = "Variable:"
        '
        'lblOptions
        '
        Me.lblOptions.AutoSize = True
        Me.lblOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOptions.Location = New System.Drawing.Point(236, 159)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(46, 13)
        Me.lblOptions.TabIndex = 11
        Me.lblOptions.Tag = "Options"
        Me.lblOptions.Text = "Options:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(95, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 16)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "By:"
        '
        'grpMethods
        '
        Me.grpMethods.Controls.Add(Me.rdoAlphabetical)
        Me.grpMethods.Controls.Add(Me.ucrInputOrder)
        Me.grpMethods.Controls.Add(Me.lblOrder)
        Me.grpMethods.Controls.Add(Me.ucrInputPrefix)
        Me.grpMethods.Controls.Add(Me.lblPrefix)
        Me.grpMethods.Controls.Add(Me.rdoAnonymise)
        Me.grpMethods.Controls.Add(Me.rdoShuffle)
        Me.grpMethods.Controls.Add(Me.ucrNudShift)
        Me.grpMethods.Controls.Add(Me.rdoShift)
        Me.grpMethods.Controls.Add(Me.rdoSequence)
        Me.grpMethods.Controls.Add(Me.rdoFrequency)
        Me.grpMethods.Controls.Add(Me.rdoAppearance)
        Me.grpMethods.Controls.Add(Me.rdoReverseLevels)
        Me.grpMethods.Controls.Add(Me.ucrPnlProperty)
        Me.grpMethods.Location = New System.Drawing.Point(235, 117)
        Me.grpMethods.Name = "grpMethods"
        Me.grpMethods.Size = New System.Drawing.Size(225, 216)
        Me.grpMethods.TabIndex = 14
        Me.grpMethods.TabStop = False
        Me.grpMethods.Text = "Methods"
        '
        'rdoAlphabetical
        '
        Me.rdoAlphabetical.AutoSize = True
        Me.rdoAlphabetical.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAlphabetical.Location = New System.Drawing.Point(12, 115)
        Me.rdoAlphabetical.Name = "rdoAlphabetical"
        Me.rdoAlphabetical.Size = New System.Drawing.Size(112, 17)
        Me.rdoAlphabetical.TabIndex = 22
        Me.rdoAlphabetical.Text = "Alphabetical Order"
        Me.rdoAlphabetical.UseVisualStyleBackColor = True
        '
        'ucrInputOrder
        '
        Me.ucrInputOrder.AddQuotesIfUnrecognised = True
        Me.ucrInputOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputOrder.GetSetSelectedIndex = -1
        Me.ucrInputOrder.IsReadOnly = False
        Me.ucrInputOrder.Location = New System.Drawing.Point(137, 68)
        Me.ucrInputOrder.Name = "ucrInputOrder"
        Me.ucrInputOrder.Size = New System.Drawing.Size(81, 21)
        Me.ucrInputOrder.TabIndex = 20
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOrder.Location = New System.Drawing.Point(100, 73)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(36, 13)
        Me.lblOrder.TabIndex = 19
        Me.lblOrder.Text = "Order:"
        '
        'ucrInputPrefix
        '
        Me.ucrInputPrefix.AddQuotesIfUnrecognised = True
        Me.ucrInputPrefix.AutoSize = True
        Me.ucrInputPrefix.IsMultiline = False
        Me.ucrInputPrefix.IsReadOnly = False
        Me.ucrInputPrefix.Location = New System.Drawing.Point(133, 184)
        Me.ucrInputPrefix.Name = "ucrInputPrefix"
        Me.ucrInputPrefix.Size = New System.Drawing.Size(85, 21)
        Me.ucrInputPrefix.TabIndex = 28
        '
        'lblPrefix
        '
        Me.lblPrefix.AutoSize = True
        Me.lblPrefix.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPrefix.Location = New System.Drawing.Point(94, 188)
        Me.lblPrefix.Name = "lblPrefix"
        Me.lblPrefix.Size = New System.Drawing.Size(36, 13)
        Me.lblPrefix.TabIndex = 27
        Me.lblPrefix.Text = "Prefix:"
        '
        'rdoAnonymise
        '
        Me.rdoAnonymise.AutoSize = True
        Me.rdoAnonymise.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAnonymise.Location = New System.Drawing.Point(12, 186)
        Me.rdoAnonymise.Name = "rdoAnonymise"
        Me.rdoAnonymise.Size = New System.Drawing.Size(76, 17)
        Me.rdoAnonymise.TabIndex = 26
        Me.rdoAnonymise.Text = "Anonymise"
        Me.rdoAnonymise.UseVisualStyleBackColor = True
        '
        'rdoShuffle
        '
        Me.rdoShuffle.AutoSize = True
        Me.rdoShuffle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoShuffle.Location = New System.Drawing.Point(12, 163)
        Me.rdoShuffle.Name = "rdoShuffle"
        Me.rdoShuffle.Size = New System.Drawing.Size(58, 17)
        Me.rdoShuffle.TabIndex = 25
        Me.rdoShuffle.Text = "Shuffle"
        Me.rdoShuffle.UseVisualStyleBackColor = True
        '
        'ucrNudShift
        '
        Me.ucrNudShift.AutoSize = True
        Me.ucrNudShift.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShift.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudShift.Location = New System.Drawing.Point(78, 139)
        Me.ucrNudShift.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudShift.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShift.Name = "ucrNudShift"
        Me.ucrNudShift.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudShift.TabIndex = 24
        Me.ucrNudShift.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoShift
        '
        Me.rdoShift.AutoSize = True
        Me.rdoShift.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoShift.Location = New System.Drawing.Point(12, 140)
        Me.rdoShift.Name = "rdoShift"
        Me.rdoShift.Size = New System.Drawing.Size(46, 17)
        Me.rdoShift.TabIndex = 23
        Me.rdoShift.Text = "Shift"
        Me.rdoShift.UseVisualStyleBackColor = True
        '
        'rdoSequence
        '
        Me.rdoSequence.AutoSize = True
        Me.rdoSequence.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSequence.Location = New System.Drawing.Point(11, 93)
        Me.rdoSequence.Name = "rdoSequence"
        Me.rdoSequence.Size = New System.Drawing.Size(74, 17)
        Me.rdoSequence.TabIndex = 21
        Me.rdoSequence.Text = "Sequence"
        Me.rdoSequence.UseVisualStyleBackColor = True
        '
        'rdoFrequency
        '
        Me.rdoFrequency.AutoSize = True
        Me.rdoFrequency.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoFrequency.Location = New System.Drawing.Point(11, 70)
        Me.rdoFrequency.Name = "rdoFrequency"
        Me.rdoFrequency.Size = New System.Drawing.Size(75, 17)
        Me.rdoFrequency.TabIndex = 18
        Me.rdoFrequency.Text = "Frequency"
        Me.rdoFrequency.UseVisualStyleBackColor = True
        '
        'rdoAppearance
        '
        Me.rdoAppearance.AutoSize = True
        Me.rdoAppearance.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAppearance.Location = New System.Drawing.Point(11, 47)
        Me.rdoAppearance.Name = "rdoAppearance"
        Me.rdoAppearance.Size = New System.Drawing.Size(83, 17)
        Me.rdoAppearance.TabIndex = 17
        Me.rdoAppearance.Text = "Appearance"
        Me.rdoAppearance.UseVisualStyleBackColor = True
        '
        'rdoReverseLevels
        '
        Me.rdoReverseLevels.AutoSize = True
        Me.rdoReverseLevels.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoReverseLevels.Location = New System.Drawing.Point(11, 24)
        Me.rdoReverseLevels.Name = "rdoReverseLevels"
        Me.rdoReverseLevels.Size = New System.Drawing.Size(99, 17)
        Me.rdoReverseLevels.TabIndex = 16
        Me.rdoReverseLevels.Text = "Reverse Levels"
        Me.rdoReverseLevels.UseVisualStyleBackColor = True
        '
        'ucrPnlProperty
        '
        Me.ucrPnlProperty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlProperty.Location = New System.Drawing.Point(6, 19)
        Me.ucrPnlProperty.Name = "ucrPnlProperty"
        Me.ucrPnlProperty.Size = New System.Drawing.Size(215, 191)
        Me.ucrPnlProperty.TabIndex = 15
        '
        'ttMethods
        '
        Me.ttMethods.AutoPopDelay = 10000
        Me.ttMethods.InitialDelay = 500
        Me.ttMethods.ReshowDelay = 100
        '
        'ucrReceiverFactorX
        '
        Me.ucrReceiverFactorX.AutoSize = True
        Me.ucrReceiverFactorX.frmParent = Me
        Me.ucrReceiverFactorX.Location = New System.Drawing.Point(238, 92)
        Me.ucrReceiverFactorX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactorX.Name = "ucrReceiverFactorX"
        Me.ucrReceiverFactorX.Selector = Nothing
        Me.ucrReceiverFactorX.Size = New System.Drawing.Size(131, 21)
        Me.ucrReceiverFactorX.strNcFilePath = ""
        Me.ucrReceiverFactorX.TabIndex = 7
        Me.ucrReceiverFactorX.ucrSelector = Nothing
        '
        'ucrSaveResults
        '
        Me.ucrSaveResults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveResults.Location = New System.Drawing.Point(10, 335)
        Me.ucrSaveResults.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveResults.Name = "ucrSaveResults"
        Me.ucrSaveResults.Size = New System.Drawing.Size(269, 22)
        Me.ucrSaveResults.TabIndex = 29
        '
        'ucrInputOptions
        '
        Me.ucrInputOptions.AddQuotesIfUnrecognised = True
        Me.ucrInputOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputOptions.GetSetSelectedIndex = -1
        Me.ucrInputOptions.IsReadOnly = False
        Me.ucrInputOptions.Location = New System.Drawing.Point(236, 174)
        Me.ucrInputOptions.Name = "ucrInputOptions"
        Me.ucrInputOptions.Size = New System.Drawing.Size(109, 21)
        Me.ucrInputOptions.TabIndex = 12
        '
        'ucrChkReverseVariable
        '
        Me.ucrChkReverseVariable.AutoSize = True
        Me.ucrChkReverseVariable.Checked = False
        Me.ucrChkReverseVariable.Location = New System.Drawing.Point(236, 204)
        Me.ucrChkReverseVariable.Name = "ucrChkReverseVariable"
        Me.ucrChkReverseVariable.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkReverseVariable.TabIndex = 13
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(125, 7)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(244, 36)
        Me.ucrPnlOptions.TabIndex = 0
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.AutoSize = True
        Me.ucrReceiverFactor.frmParent = Me
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(238, 92)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(131, 21)
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.TabIndex = 6
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'ucrReceiverVariable
        '
        Me.ucrReceiverVariable.AutoSize = True
        Me.ucrReceiverVariable.frmParent = Me
        Me.ucrReceiverVariable.Location = New System.Drawing.Point(236, 131)
        Me.ucrReceiverVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVariable.Name = "ucrReceiverVariable"
        Me.ucrReceiverVariable.Selector = Nothing
        Me.ucrReceiverVariable.Size = New System.Drawing.Size(134, 26)
        Me.ucrReceiverVariable.strNcFilePath = ""
        Me.ucrReceiverVariable.TabIndex = 10
        Me.ucrReceiverVariable.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 364)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 30
        '
        'ucrReorderFactor
        '
        Me.ucrReorderFactor.Location = New System.Drawing.Point(236, 118)
        Me.ucrReorderFactor.Name = "ucrReorderFactor"
        Me.ucrReorderFactor.Size = New System.Drawing.Size(206, 180)
        Me.ucrReorderFactor.TabIndex = 8
        Me.ucrReorderFactor.ucrDataFrameList = Nothing
        Me.ucrReorderFactor.ucrReceiver = Nothing
        '
        'ucrSelectorFactorLevelsToReorder
        '
        Me.ucrSelectorFactorLevelsToReorder.AutoSize = True
        Me.ucrSelectorFactorLevelsToReorder.bDropUnusedFilterLevels = False
        Me.ucrSelectorFactorLevelsToReorder.bShowHiddenColumns = False
        Me.ucrSelectorFactorLevelsToReorder.bUseCurrentFilter = True
        Me.ucrSelectorFactorLevelsToReorder.Location = New System.Drawing.Point(10, 60)
        Me.ucrSelectorFactorLevelsToReorder.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFactorLevelsToReorder.Name = "ucrSelectorFactorLevelsToReorder"
        Me.ucrSelectorFactorLevelsToReorder.Size = New System.Drawing.Size(242, 193)
        Me.ucrSelectorFactorLevelsToReorder.TabIndex = 4
        '
        'dlgReorderLevels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(472, 419)
        Me.Controls.Add(Me.ucrReceiverFactorX)
        Me.Controls.Add(Me.grpMethods)
        Me.Controls.Add(Me.ucrSaveResults)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblOptions)
        Me.Controls.Add(Me.rdoVariable)
        Me.Controls.Add(Me.rdoHand)
        Me.Controls.Add(Me.ucrInputOptions)
        Me.Controls.Add(Me.rdoProperty)
        Me.Controls.Add(Me.ucrChkReverseVariable)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.ucrReceiverVariable)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReorderFactor)
        Me.Controls.Add(Me.ucrSelectorFactorLevelsToReorder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgReorderLevels"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Reorder_Levels"
        Me.Text = "Reorder Levels"
        Me.grpMethods.ResumeLayout(False)
        Me.grpMethods.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorFactorLevelsToReorder As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrReorderFactor As ucrReorder
    Friend WithEvents rdoVariable As RadioButton
    Friend WithEvents rdoHand As RadioButton
    Friend WithEvents rdoProperty As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents lblVariable As Label
    Friend WithEvents ucrReceiverVariable As ucrReceiverSingle
    Friend WithEvents ucrChkReverseVariable As ucrCheck
    Friend WithEvents lblOptions As Label
    Friend WithEvents ucrInputOptions As ucrInputComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrSaveResults As ucrSave
    Friend WithEvents grpMethods As GroupBox
    Friend WithEvents ucrInputPrefix As ucrInputTextBox
    Friend WithEvents lblPrefix As Label
    Friend WithEvents rdoAnonymise As RadioButton
    Friend WithEvents rdoShuffle As RadioButton
    Friend WithEvents ucrNudShift As ucrNud
    Friend WithEvents rdoShift As RadioButton
    Friend WithEvents rdoSequence As RadioButton
    Friend WithEvents rdoFrequency As RadioButton
    Friend WithEvents rdoAppearance As RadioButton
    Friend WithEvents rdoReverseLevels As RadioButton
    Friend WithEvents ucrPnlProperty As UcrPanel
    Friend WithEvents ttMethods As ToolTip
    Friend WithEvents ucrReceiverFactorX As ucrReceiverSingle
    Friend WithEvents lblOrder As Label
    Friend WithEvents ucrInputOrder As ucrInputComboBox
    Friend WithEvents rdoAlphabetical As RadioButton
End Class
