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
Partial Class ucrFilter
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrFilter))
        Me.lblSelectLevels = New System.Windows.Forms.Label()
        Me.cmdAddCondition = New System.Windows.Forms.Button()
        Me.cmdToggleSelectAll = New System.Windows.Forms.Button()
        Me.lstFilters = New System.Windows.Forms.ListView()
        Me.lblFilterPreview = New System.Windows.Forms.Label()
        Me.lblFilterBy = New System.Windows.Forms.Label()
        Me.cmdClearConditions = New System.Windows.Forms.Button()
        Me.mcdEditCondition = New System.Windows.Forms.Button()
        Me.cmdRemoveCondition = New System.Windows.Forms.Button()
        Me.lblNewFilterName = New System.Windows.Forms.Label()
        Me.grpNumeric = New System.Windows.Forms.GroupBox()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdComma = New System.Windows.Forms.Button()
        Me.cmdBrackets = New System.Windows.Forms.Button()
        Me.cmdPower = New System.Windows.Forms.Button()
        Me.cmdDivide = New System.Windows.Forms.Button()
        Me.cmdPlus = New System.Windows.Forms.Button()
        Me.cmdMinus = New System.Windows.Forms.Button()
        Me.cmdMultiply = New System.Windows.Forms.Button()
        Me.cmdDot = New System.Windows.Forms.Button()
        Me.cmd9 = New System.Windows.Forms.Button()
        Me.cmd8 = New System.Windows.Forms.Button()
        Me.cmd7 = New System.Windows.Forms.Button()
        Me.cmd6 = New System.Windows.Forms.Button()
        Me.cmd5 = New System.Windows.Forms.Button()
        Me.cmd4 = New System.Windows.Forms.Button()
        Me.cmd3 = New System.Windows.Forms.Button()
        Me.cmd2 = New System.Windows.Forms.Button()
        Me.cmd0 = New System.Windows.Forms.Button()
        Me.cmd1 = New System.Windows.Forms.Button()
        Me.ucrReceiverExpression = New instat.ucrReceiverExpression()
        Me.ucrLogicalCombobox = New instat.ucrInputComboBox()
        Me.ucrDatePicker = New instat.ucrDateTimePicker()
        Me.ucrInputFilterName = New instat.ucrInputComboBox()
        Me.ucrFilterPreview = New instat.ucrInputTextBox()
        Me.ucrFilterOperation = New instat.ucrInputComboBox()
        Me.ucrFactorLevels = New instat.ucrFactor()
        Me.ucrFilterByReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelectorForFitler = New instat.ucrSelectorByDataFrameAddRemove()
        Me.cmdCombineWithAndOr = New System.Windows.Forms.Button()
        Me.ttpCombineWithAndOr = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpNumeric.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectLevels
        '
        resources.ApplyResources(Me.lblSelectLevels, "lblSelectLevels")
        Me.lblSelectLevels.Name = "lblSelectLevels"
        '
        'cmdAddCondition
        '
        resources.ApplyResources(Me.cmdAddCondition, "cmdAddCondition")
        Me.cmdAddCondition.Name = "cmdAddCondition"
        Me.cmdAddCondition.Tag = "Add_Condition"
        Me.cmdAddCondition.UseVisualStyleBackColor = True
        '
        'cmdToggleSelectAll
        '
        resources.ApplyResources(Me.cmdToggleSelectAll, "cmdToggleSelectAll")
        Me.cmdToggleSelectAll.Name = "cmdToggleSelectAll"
        Me.cmdToggleSelectAll.UseVisualStyleBackColor = True
        '
        'lstFilters
        '
        Me.lstFilters.HideSelection = False
        resources.ApplyResources(Me.lstFilters, "lstFilters")
        Me.lstFilters.Name = "lstFilters"
        Me.lstFilters.UseCompatibleStateImageBehavior = False
        Me.lstFilters.View = System.Windows.Forms.View.Details
        '
        'lblFilterPreview
        '
        resources.ApplyResources(Me.lblFilterPreview, "lblFilterPreview")
        Me.lblFilterPreview.Name = "lblFilterPreview"
        '
        'lblFilterBy
        '
        resources.ApplyResources(Me.lblFilterBy, "lblFilterBy")
        Me.lblFilterBy.Name = "lblFilterBy"
        '
        'cmdClearConditions
        '
        resources.ApplyResources(Me.cmdClearConditions, "cmdClearConditions")
        Me.cmdClearConditions.Name = "cmdClearConditions"
        Me.cmdClearConditions.Tag = "Clear_Conditions"
        Me.cmdClearConditions.UseVisualStyleBackColor = True
        '
        'mcdEditCondition
        '
        resources.ApplyResources(Me.mcdEditCondition, "mcdEditCondition")
        Me.mcdEditCondition.Name = "mcdEditCondition"
        Me.mcdEditCondition.Tag = "Edit_Condition"
        Me.mcdEditCondition.UseVisualStyleBackColor = True
        '
        'cmdRemoveCondition
        '
        resources.ApplyResources(Me.cmdRemoveCondition, "cmdRemoveCondition")
        Me.cmdRemoveCondition.Name = "cmdRemoveCondition"
        Me.cmdRemoveCondition.Tag = "Remove_Condition"
        Me.cmdRemoveCondition.UseVisualStyleBackColor = True
        '
        'lblNewFilterName
        '
        resources.ApplyResources(Me.lblNewFilterName, "lblNewFilterName")
        Me.lblNewFilterName.Name = "lblNewFilterName"
        '
        'grpNumeric
        '
        Me.grpNumeric.Controls.Add(Me.cmdClear)
        Me.grpNumeric.Controls.Add(Me.cmdComma)
        Me.grpNumeric.Controls.Add(Me.cmdBrackets)
        Me.grpNumeric.Controls.Add(Me.cmdPower)
        Me.grpNumeric.Controls.Add(Me.cmdDivide)
        Me.grpNumeric.Controls.Add(Me.cmdPlus)
        Me.grpNumeric.Controls.Add(Me.cmdMinus)
        Me.grpNumeric.Controls.Add(Me.cmdMultiply)
        Me.grpNumeric.Controls.Add(Me.cmdDot)
        Me.grpNumeric.Controls.Add(Me.cmd9)
        Me.grpNumeric.Controls.Add(Me.cmd8)
        Me.grpNumeric.Controls.Add(Me.cmd7)
        Me.grpNumeric.Controls.Add(Me.cmd6)
        Me.grpNumeric.Controls.Add(Me.cmd5)
        Me.grpNumeric.Controls.Add(Me.cmd4)
        Me.grpNumeric.Controls.Add(Me.cmd3)
        Me.grpNumeric.Controls.Add(Me.cmd2)
        Me.grpNumeric.Controls.Add(Me.cmd0)
        Me.grpNumeric.Controls.Add(Me.cmd1)
        resources.ApplyResources(Me.grpNumeric, "grpNumeric")
        Me.grpNumeric.Name = "grpNumeric"
        Me.grpNumeric.TabStop = False
        '
        'cmdClear
        '
        resources.ApplyResources(Me.cmdClear, "cmdClear")
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdComma
        '
        resources.ApplyResources(Me.cmdComma, "cmdComma")
        Me.cmdComma.Name = "cmdComma"
        Me.cmdComma.UseVisualStyleBackColor = True
        '
        'cmdBrackets
        '
        resources.ApplyResources(Me.cmdBrackets, "cmdBrackets")
        Me.cmdBrackets.Name = "cmdBrackets"
        Me.cmdBrackets.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        resources.ApplyResources(Me.cmdPower, "cmdPower")
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdDivide
        '
        resources.ApplyResources(Me.cmdDivide, "cmdDivide")
        Me.cmdDivide.Name = "cmdDivide"
        Me.cmdDivide.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        resources.ApplyResources(Me.cmdPlus, "cmdPlus")
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdMinus
        '
        resources.ApplyResources(Me.cmdMinus, "cmdMinus")
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        resources.ApplyResources(Me.cmdMultiply, "cmdMultiply")
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdDot
        '
        resources.ApplyResources(Me.cmdDot, "cmdDot")
        Me.cmdDot.Name = "cmdDot"
        Me.cmdDot.UseVisualStyleBackColor = True
        '
        'cmd9
        '
        resources.ApplyResources(Me.cmd9, "cmd9")
        Me.cmd9.Name = "cmd9"
        Me.cmd9.UseVisualStyleBackColor = True
        '
        'cmd8
        '
        resources.ApplyResources(Me.cmd8, "cmd8")
        Me.cmd8.Name = "cmd8"
        Me.cmd8.UseVisualStyleBackColor = True
        '
        'cmd7
        '
        resources.ApplyResources(Me.cmd7, "cmd7")
        Me.cmd7.Name = "cmd7"
        Me.cmd7.UseVisualStyleBackColor = True
        '
        'cmd6
        '
        resources.ApplyResources(Me.cmd6, "cmd6")
        Me.cmd6.Name = "cmd6"
        Me.cmd6.UseVisualStyleBackColor = True
        '
        'cmd5
        '
        resources.ApplyResources(Me.cmd5, "cmd5")
        Me.cmd5.Name = "cmd5"
        Me.cmd5.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        resources.ApplyResources(Me.cmd4, "cmd4")
        Me.cmd4.Name = "cmd4"
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'cmd3
        '
        resources.ApplyResources(Me.cmd3, "cmd3")
        Me.cmd3.Name = "cmd3"
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        resources.ApplyResources(Me.cmd2, "cmd2")
        Me.cmd2.Name = "cmd2"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'cmd0
        '
        resources.ApplyResources(Me.cmd0, "cmd0")
        Me.cmd0.Name = "cmd0"
        Me.cmd0.UseVisualStyleBackColor = True
        '
        'cmd1
        '
        resources.ApplyResources(Me.cmd1, "cmd1")
        Me.cmd1.Name = "cmd1"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'ucrReceiverExpression
        '
        Me.ucrReceiverExpression.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverExpression, "ucrReceiverExpression")
        Me.ucrReceiverExpression.Name = "ucrReceiverExpression"
        Me.ucrReceiverExpression.Selector = Nothing
        Me.ucrReceiverExpression.strNcFilePath = ""
        Me.ucrReceiverExpression.ucrSelector = Nothing
        '
        'ucrLogicalCombobox
        '
        Me.ucrLogicalCombobox.AddQuotesIfUnrecognised = True
        Me.ucrLogicalCombobox.GetSetSelectedIndex = -1
        Me.ucrLogicalCombobox.IsReadOnly = False
        resources.ApplyResources(Me.ucrLogicalCombobox, "ucrLogicalCombobox")
        Me.ucrLogicalCombobox.Name = "ucrLogicalCombobox"
        '
        'ucrDatePicker
        '
        resources.ApplyResources(Me.ucrDatePicker, "ucrDatePicker")
        Me.ucrDatePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDatePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDatePicker.Name = "ucrDatePicker"
        '
        'ucrInputFilterName
        '
        Me.ucrInputFilterName.AddQuotesIfUnrecognised = True
        Me.ucrInputFilterName.GetSetSelectedIndex = -1
        Me.ucrInputFilterName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFilterName, "ucrInputFilterName")
        Me.ucrInputFilterName.Name = "ucrInputFilterName"
        '
        'ucrFilterPreview
        '
        Me.ucrFilterPreview.AddQuotesIfUnrecognised = True
        Me.ucrFilterPreview.IsMultiline = False
        Me.ucrFilterPreview.IsReadOnly = False
        resources.ApplyResources(Me.ucrFilterPreview, "ucrFilterPreview")
        Me.ucrFilterPreview.Name = "ucrFilterPreview"
        '
        'ucrFilterOperation
        '
        Me.ucrFilterOperation.AddQuotesIfUnrecognised = True
        Me.ucrFilterOperation.GetSetSelectedIndex = -1
        Me.ucrFilterOperation.IsReadOnly = False
        resources.ApplyResources(Me.ucrFilterOperation, "ucrFilterOperation")
        Me.ucrFilterOperation.Name = "ucrFilterOperation"
        '
        'ucrFactorLevels
        '
        resources.ApplyResources(Me.ucrFactorLevels, "ucrFactorLevels")
        Me.ucrFactorLevels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrFactorLevels.clsReceiver = Nothing
        Me.ucrFactorLevels.Name = "ucrFactorLevels"
        Me.ucrFactorLevels.shtCurrSheet = Nothing
        Me.ucrFactorLevels.ucrChkLevels = Nothing
        '
        'ucrFilterByReceiver
        '
        Me.ucrFilterByReceiver.frmParent = Nothing
        resources.ApplyResources(Me.ucrFilterByReceiver, "ucrFilterByReceiver")
        Me.ucrFilterByReceiver.Name = "ucrFilterByReceiver"
        Me.ucrFilterByReceiver.Selector = Nothing
        Me.ucrFilterByReceiver.strNcFilePath = ""
        Me.ucrFilterByReceiver.ucrSelector = Nothing
        '
        'ucrSelectorForFitler
        '
        Me.ucrSelectorForFitler.bDropUnusedFilterLevels = False
        Me.ucrSelectorForFitler.bShowHiddenColumns = False
        Me.ucrSelectorForFitler.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForFitler, "ucrSelectorForFitler")
        Me.ucrSelectorForFitler.Name = "ucrSelectorForFitler"
        '
        'cmdCombineWithAndOr
        '
        resources.ApplyResources(Me.cmdCombineWithAndOr, "cmdCombineWithAndOr")
        Me.cmdCombineWithAndOr.Name = "cmdCombineWithAndOr"
        Me.cmdCombineWithAndOr.Tag = "Clear_Conditions"
        Me.cmdCombineWithAndOr.UseVisualStyleBackColor = True
        '
        'ucrFilter
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdCombineWithAndOr)
        Me.Controls.Add(Me.ucrReceiverExpression)
        Me.Controls.Add(Me.grpNumeric)
        Me.Controls.Add(Me.ucrLogicalCombobox)
        Me.Controls.Add(Me.ucrDatePicker)
        Me.Controls.Add(Me.ucrInputFilterName)
        Me.Controls.Add(Me.lblNewFilterName)
        Me.Controls.Add(Me.cmdRemoveCondition)
        Me.Controls.Add(Me.mcdEditCondition)
        Me.Controls.Add(Me.cmdClearConditions)
        Me.Controls.Add(Me.lblFilterBy)
        Me.Controls.Add(Me.ucrFilterPreview)
        Me.Controls.Add(Me.lblFilterPreview)
        Me.Controls.Add(Me.lstFilters)
        Me.Controls.Add(Me.cmdToggleSelectAll)
        Me.Controls.Add(Me.ucrFilterOperation)
        Me.Controls.Add(Me.cmdAddCondition)
        Me.Controls.Add(Me.lblSelectLevels)
        Me.Controls.Add(Me.ucrFactorLevels)
        Me.Controls.Add(Me.ucrFilterByReceiver)
        Me.Controls.Add(Me.ucrSelectorForFitler)
        Me.Name = "ucrFilter"
        Me.grpNumeric.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorForFitler As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrFilterByReceiver As ucrReceiverSingle
    Friend WithEvents ucrFactorLevels As ucrFactor
    Friend WithEvents lblSelectLevels As Label
    Friend WithEvents cmdAddCondition As Button
    Friend WithEvents ucrFilterOperation As ucrInputComboBox
    Friend WithEvents cmdToggleSelectAll As Button
    Friend WithEvents lstFilters As ListView
    Friend WithEvents lblFilterPreview As Label
    Friend WithEvents ucrFilterPreview As ucrInputTextBox
    Friend WithEvents lblFilterBy As Label
    Friend WithEvents cmdClearConditions As Button
    Friend WithEvents mcdEditCondition As Button
    Friend WithEvents cmdRemoveCondition As Button
    Friend WithEvents lblNewFilterName As Label
    Friend WithEvents ucrInputFilterName As ucrInputComboBox
    Friend WithEvents ucrDatePicker As ucrDateTimePicker
    Friend WithEvents ucrLogicalCombobox As ucrInputComboBox
    Friend WithEvents grpNumeric As GroupBox
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdComma As Button
    Friend WithEvents cmdBrackets As Button
    Friend WithEvents cmdPower As Button
    Friend WithEvents cmdDivide As Button
    Friend WithEvents cmdPlus As Button
    Friend WithEvents cmdMinus As Button
    Friend WithEvents cmdMultiply As Button
    Friend WithEvents cmdDot As Button
    Friend WithEvents cmd9 As Button
    Friend WithEvents cmd8 As Button
    Friend WithEvents cmd7 As Button
    Friend WithEvents cmd6 As Button
    Friend WithEvents cmd5 As Button
    Friend WithEvents cmd4 As Button
    Friend WithEvents cmd3 As Button
    Friend WithEvents cmd2 As Button
    Friend WithEvents cmd0 As Button
    Friend WithEvents cmd1 As Button
    Friend WithEvents ucrReceiverExpression As ucrReceiverExpression
    Friend WithEvents cmdCombineWithAndOr As Button
    Friend WithEvents ttpCombineWithAndOr As ToolTip
End Class
