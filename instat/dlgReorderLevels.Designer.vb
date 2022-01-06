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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgReorderLevels))
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
        resources.ApplyResources(Me.lblFactor, "lblFactor")
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Tag = "Factor_Selected:"
        '
        'rdoHand
        '
        resources.ApplyResources(Me.rdoHand, "rdoHand")
        Me.rdoHand.BackColor = System.Drawing.SystemColors.Control
        Me.rdoHand.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHand.FlatAppearance.BorderSize = 2
        Me.rdoHand.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHand.Name = "rdoHand"
        Me.rdoHand.TabStop = True
        Me.rdoHand.Tag = "Hand"
        Me.rdoHand.UseVisualStyleBackColor = False
        '
        'rdoProperty
        '
        resources.ApplyResources(Me.rdoProperty, "rdoProperty")
        Me.rdoProperty.BackColor = System.Drawing.SystemColors.Control
        Me.rdoProperty.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoProperty.FlatAppearance.BorderSize = 2
        Me.rdoProperty.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoProperty.Name = "rdoProperty"
        Me.rdoProperty.TabStop = True
        Me.rdoProperty.Tag = "Property"
        Me.rdoProperty.UseVisualStyleBackColor = False
        '
        'rdoVariable
        '
        resources.ApplyResources(Me.rdoVariable, "rdoVariable")
        Me.rdoVariable.BackColor = System.Drawing.SystemColors.Control
        Me.rdoVariable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVariable.FlatAppearance.BorderSize = 2
        Me.rdoVariable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVariable.Name = "rdoVariable"
        Me.rdoVariable.TabStop = True
        Me.rdoVariable.Tag = "Variable"
        Me.rdoVariable.UseVisualStyleBackColor = False
        '
        'lblVariable
        '
        resources.ApplyResources(Me.lblVariable, "lblVariable")
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Tag = "Variable:"
        '
        'lblOptions
        '
        resources.ApplyResources(Me.lblOptions, "lblOptions")
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Tag = "Options"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
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
        resources.ApplyResources(Me.grpMethods, "grpMethods")
        Me.grpMethods.Name = "grpMethods"
        Me.grpMethods.TabStop = False
        '
        'rdoAlphabetical
        '
        resources.ApplyResources(Me.rdoAlphabetical, "rdoAlphabetical")
        Me.rdoAlphabetical.Name = "rdoAlphabetical"
        Me.rdoAlphabetical.UseVisualStyleBackColor = True
        '
        'ucrInputOrder
        '
        Me.ucrInputOrder.AddQuotesIfUnrecognised = True
        Me.ucrInputOrder.GetSetSelectedIndex = -1
        Me.ucrInputOrder.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputOrder, "ucrInputOrder")
        Me.ucrInputOrder.Name = "ucrInputOrder"
        '
        'lblOrder
        '
        resources.ApplyResources(Me.lblOrder, "lblOrder")
        Me.lblOrder.Name = "lblOrder"
        '
        'ucrInputPrefix
        '
        Me.ucrInputPrefix.AddQuotesIfUnrecognised = True
        Me.ucrInputPrefix.IsMultiline = False
        Me.ucrInputPrefix.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPrefix, "ucrInputPrefix")
        Me.ucrInputPrefix.Name = "ucrInputPrefix"
        '
        'lblPrefix
        '
        resources.ApplyResources(Me.lblPrefix, "lblPrefix")
        Me.lblPrefix.Name = "lblPrefix"
        '
        'rdoAnonymise
        '
        resources.ApplyResources(Me.rdoAnonymise, "rdoAnonymise")
        Me.rdoAnonymise.Name = "rdoAnonymise"
        Me.rdoAnonymise.UseVisualStyleBackColor = True
        '
        'rdoShuffle
        '
        resources.ApplyResources(Me.rdoShuffle, "rdoShuffle")
        Me.rdoShuffle.Name = "rdoShuffle"
        Me.rdoShuffle.UseVisualStyleBackColor = True
        '
        'ucrNudShift
        '
        Me.ucrNudShift.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShift.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudShift, "ucrNudShift")
        Me.ucrNudShift.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudShift.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShift.Name = "ucrNudShift"
        Me.ucrNudShift.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoShift
        '
        resources.ApplyResources(Me.rdoShift, "rdoShift")
        Me.rdoShift.Name = "rdoShift"
        Me.rdoShift.UseVisualStyleBackColor = True
        '
        'rdoSequence
        '
        resources.ApplyResources(Me.rdoSequence, "rdoSequence")
        Me.rdoSequence.Name = "rdoSequence"
        Me.rdoSequence.UseVisualStyleBackColor = True
        '
        'rdoFrequency
        '
        resources.ApplyResources(Me.rdoFrequency, "rdoFrequency")
        Me.rdoFrequency.Name = "rdoFrequency"
        Me.rdoFrequency.UseVisualStyleBackColor = True
        '
        'rdoAppearance
        '
        resources.ApplyResources(Me.rdoAppearance, "rdoAppearance")
        Me.rdoAppearance.Name = "rdoAppearance"
        Me.rdoAppearance.UseVisualStyleBackColor = True
        '
        'rdoReverseLevels
        '
        resources.ApplyResources(Me.rdoReverseLevels, "rdoReverseLevels")
        Me.rdoReverseLevels.Name = "rdoReverseLevels"
        Me.rdoReverseLevels.UseVisualStyleBackColor = True
        '
        'ucrPnlProperty
        '
        resources.ApplyResources(Me.ucrPnlProperty, "ucrPnlProperty")
        Me.ucrPnlProperty.Name = "ucrPnlProperty"
        '
        'ttMethods
        '
        Me.ttMethods.AutoPopDelay = 10000
        Me.ttMethods.InitialDelay = 500
        Me.ttMethods.ReshowDelay = 100
        '
        'ucrReceiverFactorX
        '
        resources.ApplyResources(Me.ucrReceiverFactorX, "ucrReceiverFactorX")
        Me.ucrReceiverFactorX.frmParent = Me
        Me.ucrReceiverFactorX.Name = "ucrReceiverFactorX"
        Me.ucrReceiverFactorX.Selector = Nothing
        Me.ucrReceiverFactorX.strNcFilePath = ""
        Me.ucrReceiverFactorX.ucrSelector = Nothing
        '
        'ucrSaveResults
        '
        resources.ApplyResources(Me.ucrSaveResults, "ucrSaveResults")
        Me.ucrSaveResults.Name = "ucrSaveResults"
        '
        'ucrInputOptions
        '
        Me.ucrInputOptions.AddQuotesIfUnrecognised = True
        Me.ucrInputOptions.GetSetSelectedIndex = -1
        Me.ucrInputOptions.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputOptions, "ucrInputOptions")
        Me.ucrInputOptions.Name = "ucrInputOptions"
        '
        'ucrChkReverseVariable
        '
        Me.ucrChkReverseVariable.Checked = False
        resources.ApplyResources(Me.ucrChkReverseVariable, "ucrChkReverseVariable")
        Me.ucrChkReverseVariable.Name = "ucrChkReverseVariable"
        '
        'ucrPnlOptions
        '
        resources.ApplyResources(Me.ucrPnlOptions, "ucrPnlOptions")
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        '
        'ucrReceiverFactor
        '
        resources.ApplyResources(Me.ucrReceiverFactor, "ucrReceiverFactor")
        Me.ucrReceiverFactor.frmParent = Me
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'ucrReceiverVariable
        '
        resources.ApplyResources(Me.ucrReceiverVariable, "ucrReceiverVariable")
        Me.ucrReceiverVariable.frmParent = Me
        Me.ucrReceiverVariable.Name = "ucrReceiverVariable"
        Me.ucrReceiverVariable.Selector = Nothing
        Me.ucrReceiverVariable.strNcFilePath = ""
        Me.ucrReceiverVariable.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReorderFactor
        '
        resources.ApplyResources(Me.ucrReorderFactor, "ucrReorderFactor")
        Me.ucrReorderFactor.Name = "ucrReorderFactor"
        Me.ucrReorderFactor.ucrDataFrameList = Nothing
        Me.ucrReorderFactor.ucrReceiver = Nothing
        '
        'ucrSelectorFactorLevelsToReorder
        '
        Me.ucrSelectorFactorLevelsToReorder.bDropUnusedFilterLevels = False
        Me.ucrSelectorFactorLevelsToReorder.bShowHiddenColumns = False
        Me.ucrSelectorFactorLevelsToReorder.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorFactorLevelsToReorder, "ucrSelectorFactorLevelsToReorder")
        Me.ucrSelectorFactorLevelsToReorder.Name = "ucrSelectorFactorLevelsToReorder"
        '
        'dlgReorderLevels
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Tag = "Reorder_Levels"
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
