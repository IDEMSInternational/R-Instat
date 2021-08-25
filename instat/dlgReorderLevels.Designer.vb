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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgReorderLevels))
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.ucrSelectorFactorLevelsToReorder = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReorderFactor = New instat.ucrReorder()
        Me.rdoByHand = New System.Windows.Forms.Button()
        Me.rdoProperty = New System.Windows.Forms.Button()
        Me.rdoVariable = New System.Windows.Forms.Button()
        Me.rdoAs_Is = New instat.ucrRadio()
        Me.rdoApperance = New instat.ucrRadio()
        Me.rdoFrequencyDescending = New instat.ucrRadio()
        Me.rdoSequence = New instat.ucrRadio()
        Me.rdoShift = New instat.ucrRadio()
        Me.rdoAnonymise = New instat.ucrRadio()
        Me.lblPrefix = New System.Windows.Forms.Label()
        Me.ucrInputPrefix = New instat.ucrInputTextBox()
        Me.ucrReverseOrder = New instat.ucrCheck()
        Me.ucrSaveAs = New instat.ucrSave()
        Me.grpProperty = New System.Windows.Forms.GroupBox()
        Me.ucrPanelReorderLvl = New instat.UcrPanel()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.ucrReceiverVariable = New instat.ucrReceiverSingle()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.ucrInputSummmary = New instat.ucrInputComboBox()
        Me.ucrNumber = New instat.ucrNud()
        Me.rdoShuffle = New instat.ucrRadio()
        Me.grpProperty.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFactor
        '
        resources.ApplyResources(Me.lblFactor, "lblFactor")
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Tag = "Factor_Selected:"
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
        'ucrSelectorFactorLevelsToReorder
        '
        Me.ucrSelectorFactorLevelsToReorder.bDropUnusedFilterLevels = False
        Me.ucrSelectorFactorLevelsToReorder.bShowHiddenColumns = False
        Me.ucrSelectorFactorLevelsToReorder.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorFactorLevelsToReorder, "ucrSelectorFactorLevelsToReorder")
        Me.ucrSelectorFactorLevelsToReorder.Name = "ucrSelectorFactorLevelsToReorder"
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
        'rdoByHand
        '
        resources.ApplyResources(Me.rdoByHand, "rdoByHand")
        Me.rdoByHand.Name = "rdoByHand"
        Me.rdoByHand.UseVisualStyleBackColor = True
        '
        'rdoProperty
        '
        resources.ApplyResources(Me.rdoProperty, "rdoProperty")
        Me.rdoProperty.Name = "rdoProperty"
        Me.rdoProperty.UseVisualStyleBackColor = True
        '
        'rdoVariable
        '
        resources.ApplyResources(Me.rdoVariable, "rdoVariable")
        Me.rdoVariable.Name = "rdoVariable"
        Me.rdoVariable.UseVisualStyleBackColor = True
        '
        'rdoAs_Is
        '
        resources.ApplyResources(Me.rdoAs_Is, "rdoAs_Is")
        Me.rdoAs_Is.Name = "rdoAs_Is"
        '
        'rdoApperance
        '
        resources.ApplyResources(Me.rdoApperance, "rdoApperance")
        Me.rdoApperance.Name = "rdoApperance"
        '
        'rdoFrequencyDescending
        '
        resources.ApplyResources(Me.rdoFrequencyDescending, "rdoFrequencyDescending")
        Me.rdoFrequencyDescending.Name = "rdoFrequencyDescending"
        '
        'rdoSequence
        '
        resources.ApplyResources(Me.rdoSequence, "rdoSequence")
        Me.rdoSequence.Name = "rdoSequence"
        '
        'rdoShift
        '
        resources.ApplyResources(Me.rdoShift, "rdoShift")
        Me.rdoShift.Name = "rdoShift"
        '
        'rdoAnonymise
        '
        resources.ApplyResources(Me.rdoAnonymise, "rdoAnonymise")
        Me.rdoAnonymise.Name = "rdoAnonymise"
        '
        'lblPrefix
        '
        resources.ApplyResources(Me.lblPrefix, "lblPrefix")
        Me.lblPrefix.Name = "lblPrefix"
        '
        'ucrInputPrefix
        '
        Me.ucrInputPrefix.AddQuotesIfUnrecognised = True
        Me.ucrInputPrefix.IsMultiline = False
        Me.ucrInputPrefix.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPrefix, "ucrInputPrefix")
        Me.ucrInputPrefix.Name = "ucrInputPrefix"
        '
        'ucrReverseOrder
        '
        Me.ucrReverseOrder.Checked = False
        resources.ApplyResources(Me.ucrReverseOrder, "ucrReverseOrder")
        Me.ucrReverseOrder.Name = "ucrReverseOrder"
        '
        'ucrSaveAs
        '
        resources.ApplyResources(Me.ucrSaveAs, "ucrSaveAs")
        Me.ucrSaveAs.Name = "ucrSaveAs"
        '
        'grpProperty
        '
        Me.grpProperty.Controls.Add(Me.ucrNumber)
        Me.grpProperty.Controls.Add(Me.rdoAs_Is)
        Me.grpProperty.Controls.Add(Me.rdoApperance)
        Me.grpProperty.Controls.Add(Me.rdoFrequencyDescending)
        Me.grpProperty.Controls.Add(Me.rdoSequence)
        Me.grpProperty.Controls.Add(Me.rdoAnonymise)
        Me.grpProperty.Controls.Add(Me.rdoShift)
        Me.grpProperty.Controls.Add(Me.rdoShuffle)
        resources.ApplyResources(Me.grpProperty, "grpProperty")
        Me.grpProperty.Name = "grpProperty"
        Me.grpProperty.TabStop = False
        '
        'ucrPanelReorderLvl
        '
        resources.ApplyResources(Me.ucrPanelReorderLvl, "ucrPanelReorderLvl")
        Me.ucrPanelReorderLvl.Name = "ucrPanelReorderLvl"
        '
        'lblVariable
        '
        resources.ApplyResources(Me.lblVariable, "lblVariable")
        Me.lblVariable.Name = "lblVariable"
        '
        'ucrReceiverVariable
        '
        Me.ucrReceiverVariable.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverVariable, "ucrReceiverVariable")
        Me.ucrReceiverVariable.Name = "ucrReceiverVariable"
        Me.ucrReceiverVariable.Selector = Nothing
        Me.ucrReceiverVariable.strNcFilePath = ""
        Me.ucrReceiverVariable.ucrSelector = Nothing
        '
        'lblSummary
        '
        resources.ApplyResources(Me.lblSummary, "lblSummary")
        Me.lblSummary.Name = "lblSummary"
        '
        'ucrInputSummmary
        '
        Me.ucrInputSummmary.AddQuotesIfUnrecognised = True
        Me.ucrInputSummmary.GetSetSelectedIndex = -1
        Me.ucrInputSummmary.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSummmary, "ucrInputSummmary")
        Me.ucrInputSummmary.Name = "ucrInputSummmary"
        '
        'ucrNumber
        '
        Me.ucrNumber.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNumber.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNumber, "ucrNumber")
        Me.ucrNumber.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNumber.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNumber.Name = "ucrNumber"
        Me.ucrNumber.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoShuffle
        '
        resources.ApplyResources(Me.rdoShuffle, "rdoShuffle")
        Me.rdoShuffle.Name = "rdoShuffle"
        '
        'dlgReorderLevels
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputSummmary)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.ucrReceiverVariable)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.grpProperty)
        Me.Controls.Add(Me.ucrSaveAs)
        Me.Controls.Add(Me.ucrReverseOrder)
        Me.Controls.Add(Me.ucrInputPrefix)
        Me.Controls.Add(Me.ucrReorderFactor)
        Me.Controls.Add(Me.lblPrefix)
        Me.Controls.Add(Me.rdoVariable)
        Me.Controls.Add(Me.rdoProperty)
        Me.Controls.Add(Me.rdoByHand)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorFactorLevelsToReorder)
        Me.Controls.Add(Me.ucrPanelReorderLvl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgReorderLevels"
        Me.Tag = "Reorder_Levels"
        Me.grpProperty.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorFactorLevelsToReorder As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrReorderFactor As ucrReorder
    Friend WithEvents ucrSaveAs As ucrSave
    Friend WithEvents ucrReverseOrder As ucrCheck
    Friend WithEvents ucrInputPrefix As ucrInputTextBox
    Friend WithEvents lblPrefix As Label
    Friend WithEvents rdoAnonymise As ucrRadio
    Friend WithEvents rdoShift As ucrRadio
    Friend WithEvents rdoSequence As ucrRadio
    Friend WithEvents rdoFrequencyDescending As ucrRadio
    Friend WithEvents rdoApperance As ucrRadio
    Friend WithEvents rdoAs_Is As ucrRadio
    Friend WithEvents rdoVariable As Button
    Friend WithEvents rdoProperty As Button
    Friend WithEvents rdoByHand As Button
    Friend WithEvents grpProperty As GroupBox
    Friend WithEvents ucrInputSummmary As ucrInputComboBox
    Friend WithEvents lblSummary As Label
    Friend WithEvents ucrReceiverVariable As ucrReceiverSingle
    Friend WithEvents lblVariable As Label
    Friend WithEvents ucrNumber As ucrNud
    Friend WithEvents rdoShuffle As ucrRadio
    Friend WithEvents ucrPanelReorderLvl As UcrPanel
End Class
