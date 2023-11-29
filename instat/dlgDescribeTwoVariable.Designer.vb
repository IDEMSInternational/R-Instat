﻿' R- Instat
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
Partial Class dlgDescribeTwoVariable
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
        Me.rdoThreeVariable = New System.Windows.Forms.RadioButton()
        Me.cmdFormatTable = New System.Windows.Forms.Button()
        Me.lblThreeVariableSecondFactor = New System.Windows.Forms.Label()
        Me.cmdMissingOptions = New System.Windows.Forms.Button()
        Me.lbSecondVariable = New System.Windows.Forms.Label()
        Me.lblFirstVariable = New System.Windows.Forms.Label()
        Me.grpSummaries = New System.Windows.Forms.GroupBox()
        Me.lblFirstType = New System.Windows.Forms.Label()
        Me.lblSecondBy = New System.Windows.Forms.Label()
        Me.lblThreeVariableCategorical = New System.Windows.Forms.Label()
        Me.lblSummaryName = New System.Windows.Forms.Label()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.lblBy = New System.Windows.Forms.Label()
        Me.lblSecondType = New System.Windows.Forms.Label()
        Me.lblFirstGroupByFactor = New System.Windows.Forms.Label()
        Me.rdoSkim = New System.Windows.Forms.RadioButton()
        Me.lblThirdVariable = New System.Windows.Forms.Label()
        Me.lblSecondGroupByFactor = New System.Windows.Forms.Label()
        Me.rdoTwoVariable = New System.Windows.Forms.RadioButton()
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.lblMarginName = New System.Windows.Forms.Label()
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.ucrChkPercentageProportion = New instat.ucrCheck()
        Me.lblFactorAsPercentage = New System.Windows.Forms.Label()
        Me.ucrReceiverPercentages = New instat.ucrReceiverSingle()
        Me.ucrChkDisplayAsPercentage = New instat.ucrCheck()
        Me.ucrReceiverFirstVars = New instat.ucrReceiverMultiple()
        Me.ucrSaveTable = New instat.ucrSave()
        Me.ucrInputMarginName = New instat.ucrInputTextBox()
        Me.ucrReorderSummary = New instat.ucrReorder()
        Me.ucrChkDisplayMargins = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverThreeVariableThirdVariable = New instat.ucrReceiverSingle()
        Me.ucrReceiverSecondSkimrGroupByFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverSecondTwoVariableFactor = New instat.ucrReceiverSingle()
        Me.ucrSelectorDescribeTwoVar = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlDescribe = New instat.UcrPanel()
        Me.ucrReceiverThreeVariableSecondFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverSkimrGroupByFactor = New instat.ucrReceiverSingle()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrChkSummariesRowCol = New instat.ucrCheck()
        Me.grpSummaries.SuspendLayout()
        Me.grpDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoThreeVariable
        '
        Me.rdoThreeVariable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoThreeVariable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoThreeVariable.FlatAppearance.BorderSize = 2
        Me.rdoThreeVariable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoThreeVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoThreeVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoThreeVariable.Location = New System.Drawing.Point(288, 8)
        Me.rdoThreeVariable.Name = "rdoThreeVariable"
        Me.rdoThreeVariable.Size = New System.Drawing.Size(100, 28)
        Me.rdoThreeVariable.TabIndex = 26
        Me.rdoThreeVariable.Text = "Three Variables"
        Me.rdoThreeVariable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoThreeVariable.UseVisualStyleBackColor = True
        '
        'cmdFormatTable
        '
        Me.cmdFormatTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFormatTable.Location = New System.Drawing.Point(326, 423)
        Me.cmdFormatTable.Name = "cmdFormatTable"
        Me.cmdFormatTable.Size = New System.Drawing.Size(104, 23)
        Me.cmdFormatTable.TabIndex = 44
        Me.cmdFormatTable.Text = "Format Table..."
        Me.cmdFormatTable.UseVisualStyleBackColor = True
        '
        'lblThreeVariableSecondFactor
        '
        Me.lblThreeVariableSecondFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblThreeVariableSecondFactor.Location = New System.Drawing.Point(315, 150)
        Me.lblThreeVariableSecondFactor.Name = "lblThreeVariableSecondFactor"
        Me.lblThreeVariableSecondFactor.Size = New System.Drawing.Size(100, 15)
        Me.lblThreeVariableSecondFactor.TabIndex = 35
        Me.lblThreeVariableSecondFactor.Tag = ""
        Me.lblThreeVariableSecondFactor.Text = "Second Variable :"
        '
        'cmdMissingOptions
        '
        Me.cmdMissingOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMissingOptions.Location = New System.Drawing.Point(167, 296)
        Me.cmdMissingOptions.Name = "cmdMissingOptions"
        Me.cmdMissingOptions.Size = New System.Drawing.Size(105, 23)
        Me.cmdMissingOptions.TabIndex = 46
        Me.cmdMissingOptions.Text = "Missing Options..."
        Me.cmdMissingOptions.UseVisualStyleBackColor = True
        '
        'lbSecondVariable
        '
        Me.lbSecondVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbSecondVariable.Location = New System.Drawing.Point(310, 150)
        Me.lbSecondVariable.Name = "lbSecondVariable"
        Me.lbSecondVariable.Size = New System.Drawing.Size(100, 15)
        Me.lbSecondVariable.TabIndex = 27
        Me.lbSecondVariable.Tag = ""
        Me.lbSecondVariable.Text = "Second Variable:"
        '
        'lblFirstVariable
        '
        Me.lblFirstVariable.AutoSize = True
        Me.lblFirstVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstVariable.Location = New System.Drawing.Point(310, 49)
        Me.lblFirstVariable.Name = "lblFirstVariable"
        Me.lblFirstVariable.Size = New System.Drawing.Size(75, 13)
        Me.lblFirstVariable.TabIndex = 31
        Me.lblFirstVariable.Tag = ""
        Me.lblFirstVariable.Text = "First Variables:"
        '
        'grpSummaries
        '
        Me.grpSummaries.Controls.Add(Me.lblFirstType)
        Me.grpSummaries.Controls.Add(Me.lblSecondBy)
        Me.grpSummaries.Controls.Add(Me.lblThreeVariableCategorical)
        Me.grpSummaries.Controls.Add(Me.lblSummaryName)
        Me.grpSummaries.Controls.Add(Me.lblSummary)
        Me.grpSummaries.Controls.Add(Me.lblBy)
        Me.grpSummaries.Controls.Add(Me.lblSecondType)
        Me.grpSummaries.Location = New System.Drawing.Point(11, 219)
        Me.grpSummaries.Name = "grpSummaries"
        Me.grpSummaries.Size = New System.Drawing.Size(210, 72)
        Me.grpSummaries.TabIndex = 39
        Me.grpSummaries.TabStop = False
        '
        'lblFirstType
        '
        Me.lblFirstType.AutoSize = True
        Me.lblFirstType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstType.Location = New System.Drawing.Point(12, 18)
        Me.lblFirstType.Name = "lblFirstType"
        Me.lblFirstType.Size = New System.Drawing.Size(0, 13)
        Me.lblFirstType.TabIndex = 0
        '
        'lblSecondBy
        '
        Me.lblSecondBy.AutoSize = True
        Me.lblSecondBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondBy.Location = New System.Drawing.Point(180, 16)
        Me.lblSecondBy.Name = "lblSecondBy"
        Me.lblSecondBy.Size = New System.Drawing.Size(18, 13)
        Me.lblSecondBy.TabIndex = 1
        Me.lblSecondBy.Text = "by"
        '
        'lblThreeVariableCategorical
        '
        Me.lblThreeVariableCategorical.AutoSize = True
        Me.lblThreeVariableCategorical.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblThreeVariableCategorical.Location = New System.Drawing.Point(12, 33)
        Me.lblThreeVariableCategorical.Name = "lblThreeVariableCategorical"
        Me.lblThreeVariableCategorical.Size = New System.Drawing.Size(59, 13)
        Me.lblThreeVariableCategorical.TabIndex = 3
        Me.lblThreeVariableCategorical.Text = "categorical"
        '
        'lblSummaryName
        '
        Me.lblSummaryName.AutoSize = True
        Me.lblSummaryName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummaryName.Location = New System.Drawing.Point(70, 51)
        Me.lblSummaryName.Name = "lblSummaryName"
        Me.lblSummaryName.Size = New System.Drawing.Size(0, 13)
        Me.lblSummaryName.TabIndex = 5
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummary.Location = New System.Drawing.Point(12, 51)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(53, 13)
        Me.lblSummary.TabIndex = 4
        Me.lblSummary.Text = "Summary:"
        '
        'lblBy
        '
        Me.lblBy.AutoSize = True
        Me.lblBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBy.Location = New System.Drawing.Point(82, 16)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(18, 13)
        Me.lblBy.TabIndex = 6
        Me.lblBy.Text = "by"
        '
        'lblSecondType
        '
        Me.lblSecondType.AutoSize = True
        Me.lblSecondType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondType.Location = New System.Drawing.Point(106, 18)
        Me.lblSecondType.Name = "lblSecondType"
        Me.lblSecondType.Size = New System.Drawing.Size(0, 13)
        Me.lblSecondType.TabIndex = 0
        '
        'lblFirstGroupByFactor
        '
        Me.lblFirstGroupByFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstGroupByFactor.Location = New System.Drawing.Point(315, 149)
        Me.lblFirstGroupByFactor.Name = "lblFirstGroupByFactor"
        Me.lblFirstGroupByFactor.Size = New System.Drawing.Size(100, 15)
        Me.lblFirstGroupByFactor.TabIndex = 29
        Me.lblFirstGroupByFactor.Tag = ""
        Me.lblFirstGroupByFactor.Text = "Factor (Optional) :"
        '
        'rdoSkim
        '
        Me.rdoSkim.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSkim.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSkim.FlatAppearance.BorderSize = 2
        Me.rdoSkim.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSkim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSkim.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSkim.Location = New System.Drawing.Point(95, 8)
        Me.rdoSkim.Name = "rdoSkim"
        Me.rdoSkim.Size = New System.Drawing.Size(100, 28)
        Me.rdoSkim.TabIndex = 23
        Me.rdoSkim.Text = "Skim"
        Me.rdoSkim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSkim.UseVisualStyleBackColor = True
        '
        'lblThirdVariable
        '
        Me.lblThirdVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblThirdVariable.Location = New System.Drawing.Point(310, 191)
        Me.lblThirdVariable.Name = "lblThirdVariable"
        Me.lblThirdVariable.Size = New System.Drawing.Size(154, 15)
        Me.lblThirdVariable.TabIndex = 37
        Me.lblThirdVariable.Tag = ""
        Me.lblThirdVariable.Text = "Third Variable :"
        '
        'lblSecondGroupByFactor
        '
        Me.lblSecondGroupByFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondGroupByFactor.Location = New System.Drawing.Point(315, 191)
        Me.lblSecondGroupByFactor.Name = "lblSecondGroupByFactor"
        Me.lblSecondGroupByFactor.Size = New System.Drawing.Size(137, 15)
        Me.lblSecondGroupByFactor.TabIndex = 33
        Me.lblSecondGroupByFactor.Tag = ""
        Me.lblSecondGroupByFactor.Text = "Second Factor (Optional) :"
        '
        'rdoTwoVariable
        '
        Me.rdoTwoVariable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTwoVariable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoVariable.FlatAppearance.BorderSize = 2
        Me.rdoTwoVariable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTwoVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTwoVariable.Location = New System.Drawing.Point(191, 8)
        Me.rdoTwoVariable.Name = "rdoTwoVariable"
        Me.rdoTwoVariable.Size = New System.Drawing.Size(100, 28)
        Me.rdoTwoVariable.TabIndex = 24
        Me.rdoTwoVariable.Text = "Two Variables"
        Me.rdoTwoVariable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTwoVariable.UseVisualStyleBackColor = True
        '
        'cmdSummaries
        '
        Me.cmdSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSummaries.Location = New System.Drawing.Point(310, 229)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(120, 23)
        Me.cmdSummaries.TabIndex = 1
        Me.cmdSummaries.Tag = "Summaries"
        Me.cmdSummaries.Text = "Choose Summaries..."
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'lblMarginName
        '
        Me.lblMarginName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMarginName.Location = New System.Drawing.Point(15, 320)
        Me.lblMarginName.Name = "lblMarginName"
        Me.lblMarginName.Size = New System.Drawing.Size(93, 15)
        Me.lblMarginName.TabIndex = 54
        Me.lblMarginName.Tag = ""
        Me.lblMarginName.Text = "Margin Name:"
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.ucrChkPercentageProportion)
        Me.grpDisplay.Controls.Add(Me.lblFactorAsPercentage)
        Me.grpDisplay.Controls.Add(Me.ucrReceiverPercentages)
        Me.grpDisplay.Controls.Add(Me.ucrChkDisplayAsPercentage)
        Me.grpDisplay.Location = New System.Drawing.Point(275, 205)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(194, 115)
        Me.grpDisplay.TabIndex = 56
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Text = "Percentages"
        '
        'ucrChkPercentageProportion
        '
        Me.ucrChkPercentageProportion.AutoSize = True
        Me.ucrChkPercentageProportion.Checked = False
        Me.ucrChkPercentageProportion.Location = New System.Drawing.Point(12, 84)
        Me.ucrChkPercentageProportion.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkPercentageProportion.Name = "ucrChkPercentageProportion"
        Me.ucrChkPercentageProportion.Size = New System.Drawing.Size(143, 34)
        Me.ucrChkPercentageProportion.TabIndex = 57
        '
        'lblFactorAsPercentage
        '
        Me.lblFactorAsPercentage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactorAsPercentage.Location = New System.Drawing.Point(9, 42)
        Me.lblFactorAsPercentage.Name = "lblFactorAsPercentage"
        Me.lblFactorAsPercentage.Size = New System.Drawing.Size(154, 15)
        Me.lblFactorAsPercentage.TabIndex = 56
        Me.lblFactorAsPercentage.Tag = ""
        Me.lblFactorAsPercentage.Text = "Factor as Percentage:"
        '
        'ucrReceiverPercentages
        '
        Me.ucrReceiverPercentages.AutoSize = True
        Me.ucrReceiverPercentages.frmParent = Me
        Me.ucrReceiverPercentages.Location = New System.Drawing.Point(12, 57)
        Me.ucrReceiverPercentages.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPercentages.Name = "ucrReceiverPercentages"
        Me.ucrReceiverPercentages.Selector = Nothing
        Me.ucrReceiverPercentages.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverPercentages.strNcFilePath = ""
        Me.ucrReceiverPercentages.TabIndex = 55
        Me.ucrReceiverPercentages.ucrSelector = Nothing
        '
        'ucrChkDisplayAsPercentage
        '
        Me.ucrChkDisplayAsPercentage.AutoSize = True
        Me.ucrChkDisplayAsPercentage.Checked = False
        Me.ucrChkDisplayAsPercentage.Location = New System.Drawing.Point(12, 17)
        Me.ucrChkDisplayAsPercentage.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkDisplayAsPercentage.Name = "ucrChkDisplayAsPercentage"
        Me.ucrChkDisplayAsPercentage.Size = New System.Drawing.Size(143, 34)
        Me.ucrChkDisplayAsPercentage.TabIndex = 54
        '
        'ucrReceiverFirstVars
        '
        Me.ucrReceiverFirstVars.AutoSize = True
        Me.ucrReceiverFirstVars.frmParent = Me
        Me.ucrReceiverFirstVars.Location = New System.Drawing.Point(310, 64)
        Me.ucrReceiverFirstVars.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstVars.Name = "ucrReceiverFirstVars"
        Me.ucrReceiverFirstVars.Selector = Nothing
        Me.ucrReceiverFirstVars.Size = New System.Drawing.Size(120, 79)
        Me.ucrReceiverFirstVars.strNcFilePath = ""
        Me.ucrReceiverFirstVars.TabIndex = 58
        Me.ucrReceiverFirstVars.ucrSelector = Nothing
        '
        'ucrSaveTable
        '
        Me.ucrSaveTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveTable.Location = New System.Drawing.Point(15, 451)
        Me.ucrSaveTable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveTable.Name = "ucrSaveTable"
        Me.ucrSaveTable.Size = New System.Drawing.Size(399, 24)
        Me.ucrSaveTable.TabIndex = 57
        '
        'ucrInputMarginName
        '
        Me.ucrInputMarginName.AddQuotesIfUnrecognised = True
        Me.ucrInputMarginName.AutoSize = True
        Me.ucrInputMarginName.IsMultiline = False
        Me.ucrInputMarginName.IsReadOnly = False
        Me.ucrInputMarginName.Location = New System.Drawing.Point(114, 318)
        Me.ucrInputMarginName.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputMarginName.Name = "ucrInputMarginName"
        Me.ucrInputMarginName.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputMarginName.TabIndex = 55
        '
        'ucrReorderSummary
        '
        Me.ucrReorderSummary.Location = New System.Drawing.Point(275, 258)
        Me.ucrReorderSummary.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrReorderSummary.Name = "ucrReorderSummary"
        Me.ucrReorderSummary.Size = New System.Drawing.Size(194, 156)
        Me.ucrReorderSummary.TabIndex = 52
        Me.ucrReorderSummary.ucrDataFrameList = Nothing
        Me.ucrReorderSummary.ucrReceiver = Nothing
        '
        'ucrChkDisplayMargins
        '
        Me.ucrChkDisplayMargins.AutoSize = True
        Me.ucrChkDisplayMargins.Checked = False
        Me.ucrChkDisplayMargins.Location = New System.Drawing.Point(17, 296)
        Me.ucrChkDisplayMargins.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkDisplayMargins.Name = "ucrChkDisplayMargins"
        Me.ucrChkDisplayMargins.Size = New System.Drawing.Size(143, 23)
        Me.ucrChkDisplayMargins.TabIndex = 53
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 489)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 43
        '
        'ucrReceiverThreeVariableThirdVariable
        '
        Me.ucrReceiverThreeVariableThirdVariable.AutoSize = True
        Me.ucrReceiverThreeVariableThirdVariable.frmParent = Me
        Me.ucrReceiverThreeVariableThirdVariable.Location = New System.Drawing.Point(310, 204)
        Me.ucrReceiverThreeVariableThirdVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverThreeVariableThirdVariable.Name = "ucrReceiverThreeVariableThirdVariable"
        Me.ucrReceiverThreeVariableThirdVariable.Selector = Nothing
        Me.ucrReceiverThreeVariableThirdVariable.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverThreeVariableThirdVariable.strNcFilePath = ""
        Me.ucrReceiverThreeVariableThirdVariable.TabIndex = 38
        Me.ucrReceiverThreeVariableThirdVariable.ucrSelector = Nothing
        '
        'ucrReceiverSecondSkimrGroupByFactor
        '
        Me.ucrReceiverSecondSkimrGroupByFactor.AutoSize = True
        Me.ucrReceiverSecondSkimrGroupByFactor.frmParent = Me
        Me.ucrReceiverSecondSkimrGroupByFactor.Location = New System.Drawing.Point(310, 204)
        Me.ucrReceiverSecondSkimrGroupByFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondSkimrGroupByFactor.Name = "ucrReceiverSecondSkimrGroupByFactor"
        Me.ucrReceiverSecondSkimrGroupByFactor.Selector = Nothing
        Me.ucrReceiverSecondSkimrGroupByFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSecondSkimrGroupByFactor.strNcFilePath = ""
        Me.ucrReceiverSecondSkimrGroupByFactor.TabIndex = 34
        Me.ucrReceiverSecondSkimrGroupByFactor.ucrSelector = Nothing
        '
        'ucrReceiverSecondTwoVariableFactor
        '
        Me.ucrReceiverSecondTwoVariableFactor.AutoSize = True
        Me.ucrReceiverSecondTwoVariableFactor.frmParent = Me
        Me.ucrReceiverSecondTwoVariableFactor.Location = New System.Drawing.Point(310, 164)
        Me.ucrReceiverSecondTwoVariableFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondTwoVariableFactor.Name = "ucrReceiverSecondTwoVariableFactor"
        Me.ucrReceiverSecondTwoVariableFactor.Selector = Nothing
        Me.ucrReceiverSecondTwoVariableFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSecondTwoVariableFactor.strNcFilePath = ""
        Me.ucrReceiverSecondTwoVariableFactor.TabIndex = 25
        Me.ucrReceiverSecondTwoVariableFactor.ucrSelector = Nothing
        '
        'ucrSelectorDescribeTwoVar
        '
        Me.ucrSelectorDescribeTwoVar.AutoSize = True
        Me.ucrSelectorDescribeTwoVar.bDropUnusedFilterLevels = False
        Me.ucrSelectorDescribeTwoVar.bShowHiddenColumns = False
        Me.ucrSelectorDescribeTwoVar.bUseCurrentFilter = True
        Me.ucrSelectorDescribeTwoVar.Location = New System.Drawing.Point(11, 36)
        Me.ucrSelectorDescribeTwoVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDescribeTwoVar.Name = "ucrSelectorDescribeTwoVar"
        Me.ucrSelectorDescribeTwoVar.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorDescribeTwoVar.TabIndex = 28
        '
        'ucrPnlDescribe
        '
        Me.ucrPnlDescribe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDescribe.Location = New System.Drawing.Point(92, 3)
        Me.ucrPnlDescribe.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrPnlDescribe.Name = "ucrPnlDescribe"
        Me.ucrPnlDescribe.Size = New System.Drawing.Size(317, 34)
        Me.ucrPnlDescribe.TabIndex = 22
        '
        'ucrReceiverThreeVariableSecondFactor
        '
        Me.ucrReceiverThreeVariableSecondFactor.AutoSize = True
        Me.ucrReceiverThreeVariableSecondFactor.frmParent = Me
        Me.ucrReceiverThreeVariableSecondFactor.Location = New System.Drawing.Point(310, 164)
        Me.ucrReceiverThreeVariableSecondFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverThreeVariableSecondFactor.Name = "ucrReceiverThreeVariableSecondFactor"
        Me.ucrReceiverThreeVariableSecondFactor.Selector = Nothing
        Me.ucrReceiverThreeVariableSecondFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverThreeVariableSecondFactor.strNcFilePath = ""
        Me.ucrReceiverThreeVariableSecondFactor.TabIndex = 36
        Me.ucrReceiverThreeVariableSecondFactor.ucrSelector = Nothing
        '
        'ucrReceiverSkimrGroupByFactor
        '
        Me.ucrReceiverSkimrGroupByFactor.AutoSize = True
        Me.ucrReceiverSkimrGroupByFactor.frmParent = Me
        Me.ucrReceiverSkimrGroupByFactor.Location = New System.Drawing.Point(310, 164)
        Me.ucrReceiverSkimrGroupByFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSkimrGroupByFactor.Name = "ucrReceiverSkimrGroupByFactor"
        Me.ucrReceiverSkimrGroupByFactor.Selector = Nothing
        Me.ucrReceiverSkimrGroupByFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSkimrGroupByFactor.strNcFilePath = ""
        Me.ucrReceiverSkimrGroupByFactor.TabIndex = 32
        Me.ucrReceiverSkimrGroupByFactor.ucrSelector = Nothing
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.AutoSize = True
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(17, 296)
        Me.ucrChkOmitMissing.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(143, 23)
        Me.ucrChkOmitMissing.TabIndex = 0
        '
        'ucrChkSummariesRowCol
        '
        Me.ucrChkSummariesRowCol.AutoSize = True
        Me.ucrChkSummariesRowCol.Checked = False
        Me.ucrChkSummariesRowCol.Location = New System.Drawing.Point(15, 337)
        Me.ucrChkSummariesRowCol.Name = "ucrChkSummariesRowCol"
        Me.ucrChkSummariesRowCol.Size = New System.Drawing.Size(180, 23)
        Me.ucrChkSummariesRowCol.TabIndex = 59
        '
        'dlgDescribeTwoVariable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(482, 499)
        Me.Controls.Add(Me.ucrReceiverFirstVars)
        Me.Controls.Add(Me.ucrSaveTable)
        Me.Controls.Add(Me.grpDisplay)
        Me.Controls.Add(Me.ucrInputMarginName)
        Me.Controls.Add(Me.cmdSummaries)
        Me.Controls.Add(Me.ucrReorderSummary)
        Me.Controls.Add(Me.lblMarginName)
        Me.Controls.Add(Me.cmdMissingOptions)
        Me.Controls.Add(Me.ucrChkDisplayMargins)
        Me.Controls.Add(Me.cmdFormatTable)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverThreeVariableThirdVariable)
        Me.Controls.Add(Me.ucrReceiverSecondSkimrGroupByFactor)
        Me.Controls.Add(Me.ucrReceiverSecondTwoVariableFactor)
        Me.Controls.Add(Me.ucrSelectorDescribeTwoVar)
        Me.Controls.Add(Me.lblFirstVariable)
        Me.Controls.Add(Me.grpSummaries)
        Me.Controls.Add(Me.rdoThreeVariable)
        Me.Controls.Add(Me.rdoTwoVariable)
        Me.Controls.Add(Me.rdoSkim)
        Me.Controls.Add(Me.ucrPnlDescribe)
        Me.Controls.Add(Me.ucrReceiverThreeVariableSecondFactor)
        Me.Controls.Add(Me.ucrReceiverSkimrGroupByFactor)
        Me.Controls.Add(Me.lblThirdVariable)
        Me.Controls.Add(Me.lblSecondGroupByFactor)
        Me.Controls.Add(Me.lbSecondVariable)
        Me.Controls.Add(Me.lblFirstGroupByFactor)
        Me.Controls.Add(Me.lblThreeVariableSecondFactor)
        Me.Controls.Add(Me.ucrChkOmitMissing)
        Me.Controls.Add(Me.ucrChkSummariesRowCol)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescribeTwoVariable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Describe_Two_Variable"
        Me.Text = "Describe Two Variables"
        Me.grpSummaries.ResumeLayout(False)
        Me.grpSummaries.PerformLayout()
        Me.grpDisplay.ResumeLayout(False)
        Me.grpDisplay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdFormatTable As Button
    Friend WithEvents lblThreeVariableSecondFactor As Label
    Friend WithEvents ucrReceiverThreeVariableSecondFactor As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverThreeVariableThirdVariable As ucrReceiverSingle
    Friend WithEvents ucrReceiverSecondSkimrGroupByFactor As ucrReceiverSingle
    Friend WithEvents ucrReceiverSkimrGroupByFactor As ucrReceiverSingle
    Friend WithEvents ucrReceiverSecondTwoVariableFactor As ucrReceiverSingle
    Friend WithEvents ucrSelectorDescribeTwoVar As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrChkOmitMissing As ucrCheck
    Friend WithEvents lbSecondVariable As Label
    Friend WithEvents lblFirstVariable As Label
    Friend WithEvents grpSummaries As GroupBox
    Friend WithEvents lblFirstType As Label
    Friend WithEvents lblSecondBy As Label
    Friend WithEvents lblThreeVariableCategorical As Label
    Friend WithEvents lblSummaryName As Label
    Friend WithEvents lblSummary As Label
    Friend WithEvents lblBy As Label
    Friend WithEvents lblSecondType As Label
    Friend WithEvents lblFirstGroupByFactor As Label
    Friend WithEvents lblThirdVariable As Label
    Friend WithEvents lblSecondGroupByFactor As Label
    Friend WithEvents rdoThreeVariable As RadioButton
    Friend WithEvents rdoTwoVariable As RadioButton
    Friend WithEvents rdoSkim As RadioButton
    Friend WithEvents ucrPnlDescribe As UcrPanel
    Friend WithEvents cmdMissingOptions As Button
    Friend WithEvents ucrReorderSummary As ucrReorder
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents ucrInputMarginName As ucrInputTextBox
    Friend WithEvents lblMarginName As Label
    Friend WithEvents ucrChkDisplayMargins As ucrCheck
    Friend WithEvents grpDisplay As GroupBox
    Friend WithEvents ucrChkPercentageProportion As ucrCheck
    Friend WithEvents lblFactorAsPercentage As Label
    Friend WithEvents ucrReceiverPercentages As ucrReceiverSingle
    Friend WithEvents ucrChkDisplayAsPercentage As ucrCheck
    Friend WithEvents ucrSaveTable As ucrSave
    Friend WithEvents ucrReceiverFirstVars As ucrReceiverMultiple
    Friend WithEvents ucrChkSummariesRowCol As ucrCheck
End Class
