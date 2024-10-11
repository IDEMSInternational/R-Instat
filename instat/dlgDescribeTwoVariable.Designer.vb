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
        Me.rdoOCol = New System.Windows.Forms.RadioButton()
        Me.rdoOCell = New System.Windows.Forms.RadioButton()
        Me.rdoORow = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverThreeVariableThirdVariable = New instat.ucrReceiverSingle()
        Me.ucrReceiverPercentages = New instat.ucrReceiverSingle()
        Me.ucrpnlPercent = New instat.UcrPanel()
        Me.ucrReceiverThreeVariableSecondFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverSecondTwoVariableFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirstVars = New instat.ucrReceiverMultiple()
        Me.ucrSaveTable = New instat.ucrSave()
        Me.ucrReceiverColumns = New instat.ucrReceiverMultiple()
        Me.ucrChkDisplayAsPercentage = New instat.ucrCheck()
        Me.ucrInputMarginName = New instat.ucrInputTextBox()
        Me.ucrReorderSummary = New instat.ucrReorder()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverSecondSkimrGroupByFactor = New instat.ucrReceiverSingle()
        Me.ucrSelectorDescribeTwoVar = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlDescribe = New instat.UcrPanel()
        Me.ucrReceiverSkimrGroupByFactor = New instat.ucrReceiverSingle()
        Me.ucrChkDisplayMargins = New instat.ucrCheck()
        Me.ucrChkSummariesRowCol = New instat.ucrCheck()
        Me.ucrChkLevSig = New instat.ucrCheck()
        Me.ucrChkTotal = New instat.ucrCheck()
        Me.ucrChkMeans = New instat.ucrCheck()
        Me.ucrChkCorrelations = New instat.ucrCheck()
        Me.ucrChkSwapXYVar = New instat.ucrCheck()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
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
        Me.rdoThreeVariable.Location = New System.Drawing.Point(432, 12)
        Me.rdoThreeVariable.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoThreeVariable.Name = "rdoThreeVariable"
        Me.rdoThreeVariable.Size = New System.Drawing.Size(150, 42)
        Me.rdoThreeVariable.TabIndex = 3
        Me.rdoThreeVariable.Text = "Three Variables"
        Me.rdoThreeVariable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoThreeVariable.UseVisualStyleBackColor = True
        '
        'cmdFormatTable
        '
        Me.cmdFormatTable.Enabled = False
        Me.cmdFormatTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFormatTable.Location = New System.Drawing.Point(489, 645)
        Me.cmdFormatTable.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdFormatTable.Name = "cmdFormatTable"
        Me.cmdFormatTable.Size = New System.Drawing.Size(156, 34)
        Me.cmdFormatTable.TabIndex = 23
        Me.cmdFormatTable.Text = "Format Table..."
        Me.cmdFormatTable.UseVisualStyleBackColor = True
        '
        'lblThreeVariableSecondFactor
        '
        Me.lblThreeVariableSecondFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblThreeVariableSecondFactor.Location = New System.Drawing.Point(472, 225)
        Me.lblThreeVariableSecondFactor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblThreeVariableSecondFactor.Name = "lblThreeVariableSecondFactor"
        Me.lblThreeVariableSecondFactor.Size = New System.Drawing.Size(150, 22)
        Me.lblThreeVariableSecondFactor.TabIndex = 10
        Me.lblThreeVariableSecondFactor.Tag = ""
        Me.lblThreeVariableSecondFactor.Text = "Second Variable :"
        '
        'cmdMissingOptions
        '
        Me.cmdMissingOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMissingOptions.Location = New System.Drawing.Point(538, 440)
        Me.cmdMissingOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdMissingOptions.Name = "cmdMissingOptions"
        Me.cmdMissingOptions.Size = New System.Drawing.Size(158, 34)
        Me.cmdMissingOptions.TabIndex = 21
        Me.cmdMissingOptions.Text = "Missing Options..."
        Me.cmdMissingOptions.UseVisualStyleBackColor = True
        '
        'lbSecondVariable
        '
        Me.lbSecondVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbSecondVariable.Location = New System.Drawing.Point(465, 225)
        Me.lbSecondVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbSecondVariable.Name = "lbSecondVariable"
        Me.lbSecondVariable.Size = New System.Drawing.Size(150, 22)
        Me.lbSecondVariable.TabIndex = 9
        Me.lbSecondVariable.Tag = ""
        Me.lbSecondVariable.Text = "Second Variable:"
        '
        'lblFirstVariable
        '
        Me.lblFirstVariable.AutoSize = True
        Me.lblFirstVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstVariable.Location = New System.Drawing.Point(465, 74)
        Me.lblFirstVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstVariable.Name = "lblFirstVariable"
        Me.lblFirstVariable.Size = New System.Drawing.Size(114, 20)
        Me.lblFirstVariable.TabIndex = 5
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
        Me.grpSummaries.Location = New System.Drawing.Point(16, 328)
        Me.grpSummaries.Margin = New System.Windows.Forms.Padding(4)
        Me.grpSummaries.Name = "grpSummaries"
        Me.grpSummaries.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSummaries.Size = New System.Drawing.Size(315, 108)
        Me.grpSummaries.TabIndex = 17
        Me.grpSummaries.TabStop = False
        '
        'lblFirstType
        '
        Me.lblFirstType.AutoSize = True
        Me.lblFirstType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstType.Location = New System.Drawing.Point(18, 27)
        Me.lblFirstType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstType.Name = "lblFirstType"
        Me.lblFirstType.Size = New System.Drawing.Size(0, 20)
        Me.lblFirstType.TabIndex = 0
        '
        'lblSecondBy
        '
        Me.lblSecondBy.AutoSize = True
        Me.lblSecondBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondBy.Location = New System.Drawing.Point(270, 24)
        Me.lblSecondBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecondBy.Name = "lblSecondBy"
        Me.lblSecondBy.Size = New System.Drawing.Size(25, 20)
        Me.lblSecondBy.TabIndex = 6
        Me.lblSecondBy.Text = "by"
        '
        'lblThreeVariableCategorical
        '
        Me.lblThreeVariableCategorical.AutoSize = True
        Me.lblThreeVariableCategorical.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblThreeVariableCategorical.Location = New System.Drawing.Point(18, 50)
        Me.lblThreeVariableCategorical.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblThreeVariableCategorical.Name = "lblThreeVariableCategorical"
        Me.lblThreeVariableCategorical.Size = New System.Drawing.Size(86, 20)
        Me.lblThreeVariableCategorical.TabIndex = 1
        Me.lblThreeVariableCategorical.Text = "categorical"
        '
        'lblSummaryName
        '
        Me.lblSummaryName.AutoSize = True
        Me.lblSummaryName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummaryName.Location = New System.Drawing.Point(105, 76)
        Me.lblSummaryName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSummaryName.Name = "lblSummaryName"
        Me.lblSummaryName.Size = New System.Drawing.Size(0, 20)
        Me.lblSummaryName.TabIndex = 3
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummary.Location = New System.Drawing.Point(18, 76)
        Me.lblSummary.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(80, 20)
        Me.lblSummary.TabIndex = 2
        Me.lblSummary.Text = "Summary:"
        '
        'lblBy
        '
        Me.lblBy.AutoSize = True
        Me.lblBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBy.Location = New System.Drawing.Point(123, 24)
        Me.lblBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(25, 20)
        Me.lblBy.TabIndex = 4
        Me.lblBy.Text = "by"
        '
        'lblSecondType
        '
        Me.lblSecondType.AutoSize = True
        Me.lblSecondType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondType.Location = New System.Drawing.Point(159, 27)
        Me.lblSecondType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecondType.Name = "lblSecondType"
        Me.lblSecondType.Size = New System.Drawing.Size(0, 20)
        Me.lblSecondType.TabIndex = 5
        '
        'lblFirstGroupByFactor
        '
        Me.lblFirstGroupByFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstGroupByFactor.Location = New System.Drawing.Point(472, 224)
        Me.lblFirstGroupByFactor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstGroupByFactor.Name = "lblFirstGroupByFactor"
        Me.lblFirstGroupByFactor.Size = New System.Drawing.Size(150, 22)
        Me.lblFirstGroupByFactor.TabIndex = 7
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
        Me.rdoSkim.Location = New System.Drawing.Point(142, 12)
        Me.rdoSkim.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoSkim.Name = "rdoSkim"
        Me.rdoSkim.Size = New System.Drawing.Size(150, 42)
        Me.rdoSkim.TabIndex = 1
        Me.rdoSkim.Text = "Skim"
        Me.rdoSkim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSkim.UseVisualStyleBackColor = True
        '
        'lblThirdVariable
        '
        Me.lblThirdVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblThirdVariable.Location = New System.Drawing.Point(465, 286)
        Me.lblThirdVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblThirdVariable.Name = "lblThirdVariable"
        Me.lblThirdVariable.Size = New System.Drawing.Size(231, 22)
        Me.lblThirdVariable.TabIndex = 13
        Me.lblThirdVariable.Tag = ""
        Me.lblThirdVariable.Text = "Third Variable :"
        '
        'lblSecondGroupByFactor
        '
        Me.lblSecondGroupByFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondGroupByFactor.Location = New System.Drawing.Point(472, 286)
        Me.lblSecondGroupByFactor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecondGroupByFactor.Name = "lblSecondGroupByFactor"
        Me.lblSecondGroupByFactor.Size = New System.Drawing.Size(206, 22)
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
        Me.rdoTwoVariable.Location = New System.Drawing.Point(286, 12)
        Me.rdoTwoVariable.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoTwoVariable.Name = "rdoTwoVariable"
        Me.rdoTwoVariable.Size = New System.Drawing.Size(150, 42)
        Me.rdoTwoVariable.TabIndex = 2
        Me.rdoTwoVariable.Text = "Two Variables"
        Me.rdoTwoVariable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTwoVariable.UseVisualStyleBackColor = True
        '
        'cmdSummaries
        '
        Me.cmdSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSummaries.Location = New System.Drawing.Point(465, 372)
        Me.cmdSummaries.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(180, 34)
        Me.cmdSummaries.TabIndex = 1
        Me.cmdSummaries.Tag = "Summaries"
        Me.cmdSummaries.Text = "Choose Summaries..."
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'lblMarginName
        '
        Me.lblMarginName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMarginName.Location = New System.Drawing.Point(22, 480)
        Me.lblMarginName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMarginName.Name = "lblMarginName"
        Me.lblMarginName.Size = New System.Drawing.Size(140, 22)
        Me.lblMarginName.TabIndex = 19
        Me.lblMarginName.Tag = ""
        Me.lblMarginName.Text = "Margin Name:"
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.ucrReceiverColumns)
        Me.grpDisplay.Controls.Add(Me.ucrChkDisplayAsPercentage)
        Me.grpDisplay.Location = New System.Drawing.Point(414, 278)
        Me.grpDisplay.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDisplay.Size = New System.Drawing.Size(291, 219)
        Me.grpDisplay.TabIndex = 15
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Text = "Percentages"
        '
        'rdoOCol
        '
        Me.rdoOCol.AutoSize = True
        Me.rdoOCol.Location = New System.Drawing.Point(432, 336)
        Me.rdoOCol.Name = "rdoOCol"
        Me.rdoOCol.Size = New System.Drawing.Size(81, 24)
        Me.rdoOCol.TabIndex = 40
        Me.rdoOCol.TabStop = True
        Me.rdoOCol.Text = "Col(%)"
        Me.rdoOCol.UseVisualStyleBackColor = True
        '
        'rdoOCell
        '
        Me.rdoOCell.AutoSize = True
        Me.rdoOCell.Location = New System.Drawing.Point(612, 334)
        Me.rdoOCell.Name = "rdoOCell"
        Me.rdoOCell.Size = New System.Drawing.Size(84, 24)
        Me.rdoOCell.TabIndex = 41
        Me.rdoOCell.TabStop = True
        Me.rdoOCell.Text = "Cell(%)"
        Me.rdoOCell.UseVisualStyleBackColor = True
        '
        'rdoORow
        '
        Me.rdoORow.AutoSize = True
        Me.rdoORow.Location = New System.Drawing.Point(518, 336)
        Me.rdoORow.Name = "rdoORow"
        Me.rdoORow.Size = New System.Drawing.Size(90, 24)
        Me.rdoORow.TabIndex = 42
        Me.rdoORow.TabStop = True
        Me.rdoORow.Text = "Row(%)"
        Me.rdoORow.UseVisualStyleBackColor = True
        '
        'ucrReceiverThreeVariableThirdVariable
        '
        Me.ucrReceiverThreeVariableThirdVariable.AutoSize = True
        Me.ucrReceiverThreeVariableThirdVariable.frmParent = Me
        Me.ucrReceiverThreeVariableThirdVariable.Location = New System.Drawing.Point(465, 314)
        Me.ucrReceiverThreeVariableThirdVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverThreeVariableThirdVariable.Name = "ucrReceiverThreeVariableThirdVariable"
        Me.ucrReceiverThreeVariableThirdVariable.Selector = Nothing
        Me.ucrReceiverThreeVariableThirdVariable.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverThreeVariableThirdVariable.strNcFilePath = ""
        Me.ucrReceiverThreeVariableThirdVariable.TabIndex = 14
        Me.ucrReceiverThreeVariableThirdVariable.ucrSelector = Nothing
        '
        'ucrReceiverPercentages
        '
        Me.ucrReceiverPercentages.AutoSize = True
        Me.ucrReceiverPercentages.frmParent = Me
        Me.ucrReceiverPercentages.Location = New System.Drawing.Point(430, 369)
        Me.ucrReceiverPercentages.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPercentages.Name = "ucrReceiverPercentages"
        Me.ucrReceiverPercentages.Selector = Nothing
        Me.ucrReceiverPercentages.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverPercentages.strNcFilePath = ""
        Me.ucrReceiverPercentages.TabIndex = 39
        Me.ucrReceiverPercentages.ucrSelector = Nothing
        '
        'ucrpnlPercent
        '
        Me.ucrpnlPercent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrpnlPercent.Location = New System.Drawing.Point(424, 332)
        Me.ucrpnlPercent.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrpnlPercent.Name = "ucrpnlPercent"
        Me.ucrpnlPercent.Size = New System.Drawing.Size(270, 38)
        Me.ucrpnlPercent.TabIndex = 43
        '
        'ucrReceiverThreeVariableSecondFactor
        '
        Me.ucrReceiverThreeVariableSecondFactor.AutoSize = True
        Me.ucrReceiverThreeVariableSecondFactor.frmParent = Me
        Me.ucrReceiverThreeVariableSecondFactor.Location = New System.Drawing.Point(465, 246)
        Me.ucrReceiverThreeVariableSecondFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverThreeVariableSecondFactor.Name = "ucrReceiverThreeVariableSecondFactor"
        Me.ucrReceiverThreeVariableSecondFactor.Selector = Nothing
        Me.ucrReceiverThreeVariableSecondFactor.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverThreeVariableSecondFactor.strNcFilePath = ""
        Me.ucrReceiverThreeVariableSecondFactor.TabIndex = 12
        Me.ucrReceiverThreeVariableSecondFactor.ucrSelector = Nothing
        '
        'ucrReceiverSecondTwoVariableFactor
        '
        Me.ucrReceiverSecondTwoVariableFactor.AutoSize = True
        Me.ucrReceiverSecondTwoVariableFactor.frmParent = Me
        Me.ucrReceiverSecondTwoVariableFactor.Location = New System.Drawing.Point(465, 246)
        Me.ucrReceiverSecondTwoVariableFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondTwoVariableFactor.Name = "ucrReceiverSecondTwoVariableFactor"
        Me.ucrReceiverSecondTwoVariableFactor.Selector = Nothing
        Me.ucrReceiverSecondTwoVariableFactor.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverSecondTwoVariableFactor.strNcFilePath = ""
        Me.ucrReceiverSecondTwoVariableFactor.TabIndex = 1
        Me.ucrReceiverSecondTwoVariableFactor.ucrSelector = Nothing
        '
        'ucrReceiverFirstVars
        '
        Me.ucrReceiverFirstVars.AutoSize = True
        Me.ucrReceiverFirstVars.frmParent = Me
        Me.ucrReceiverFirstVars.Location = New System.Drawing.Point(465, 96)
        Me.ucrReceiverFirstVars.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstVars.Name = "ucrReceiverFirstVars"
        Me.ucrReceiverFirstVars.Selector = Nothing
        Me.ucrReceiverFirstVars.Size = New System.Drawing.Size(180, 118)
        Me.ucrReceiverFirstVars.strNcFilePath = ""
        Me.ucrReceiverFirstVars.TabIndex = 6
        Me.ucrReceiverFirstVars.ucrSelector = Nothing
        '
        'ucrSaveTable
        '
        Me.ucrSaveTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveTable.Location = New System.Drawing.Point(22, 676)
        Me.ucrSaveTable.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveTable.Name = "ucrSaveTable"
        Me.ucrSaveTable.Size = New System.Drawing.Size(459, 36)
        Me.ucrSaveTable.TabIndex = 24
        '
        'ucrReceiverColumns
        '
        Me.ucrReceiverColumns.AutoSize = True
        Me.ucrReceiverColumns.frmParent = Nothing
        Me.ucrReceiverColumns.Location = New System.Drawing.Point(20, 92)
        Me.ucrReceiverColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumns.Name = "ucrReceiverColumns"
        Me.ucrReceiverColumns.Selector = Nothing
        Me.ucrReceiverColumns.Size = New System.Drawing.Size(180, 122)
        Me.ucrReceiverColumns.strNcFilePath = ""
        Me.ucrReceiverColumns.TabIndex = 55
        Me.ucrReceiverColumns.ucrSelector = Nothing
        '
        'ucrChkDisplayAsPercentage
        '
        Me.ucrChkDisplayAsPercentage.AutoSize = True
        Me.ucrChkDisplayAsPercentage.Checked = False
        Me.ucrChkDisplayAsPercentage.Location = New System.Drawing.Point(14, 22)
        Me.ucrChkDisplayAsPercentage.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkDisplayAsPercentage.Name = "ucrChkDisplayAsPercentage"
        Me.ucrChkDisplayAsPercentage.Size = New System.Drawing.Size(171, 51)
        Me.ucrChkDisplayAsPercentage.TabIndex = 54
        '
        'ucrInputMarginName
        '
        Me.ucrInputMarginName.AddQuotesIfUnrecognised = True
        Me.ucrInputMarginName.AutoSize = True
        Me.ucrInputMarginName.IsMultiline = False
        Me.ucrInputMarginName.IsReadOnly = False
        Me.ucrInputMarginName.Location = New System.Drawing.Point(171, 477)
        Me.ucrInputMarginName.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputMarginName.Name = "ucrInputMarginName"
        Me.ucrInputMarginName.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputMarginName.TabIndex = 22
        '
        'ucrReorderSummary
        '
        Me.ucrReorderSummary.Location = New System.Drawing.Point(412, 409)
        Me.ucrReorderSummary.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrReorderSummary.Name = "ucrReorderSummary"
        Me.ucrReorderSummary.Size = New System.Drawing.Size(291, 234)
        Me.ucrReorderSummary.TabIndex = 16
        Me.ucrReorderSummary.ucrDataFrameList = Nothing
        Me.ucrReorderSummary.ucrReceiver = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(22, 734)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 25
        '
        'ucrReceiverSecondSkimrGroupByFactor
        '
        Me.ucrReceiverSecondSkimrGroupByFactor.AutoSize = True
        Me.ucrReceiverSecondSkimrGroupByFactor.frmParent = Me
        Me.ucrReceiverSecondSkimrGroupByFactor.Location = New System.Drawing.Point(465, 306)
        Me.ucrReceiverSecondSkimrGroupByFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondSkimrGroupByFactor.Name = "ucrReceiverSecondSkimrGroupByFactor"
        Me.ucrReceiverSecondSkimrGroupByFactor.Selector = Nothing
        Me.ucrReceiverSecondSkimrGroupByFactor.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverSecondSkimrGroupByFactor.strNcFilePath = ""
        Me.ucrReceiverSecondSkimrGroupByFactor.TabIndex = 34
        Me.ucrReceiverSecondSkimrGroupByFactor.ucrSelector = Nothing
        '
        'ucrSelectorDescribeTwoVar
        '
        Me.ucrSelectorDescribeTwoVar.AutoSize = True
        Me.ucrSelectorDescribeTwoVar.bDropUnusedFilterLevels = False
        Me.ucrSelectorDescribeTwoVar.bShowHiddenColumns = False
        Me.ucrSelectorDescribeTwoVar.bUseCurrentFilter = True
        Me.ucrSelectorDescribeTwoVar.Location = New System.Drawing.Point(16, 54)
        Me.ucrSelectorDescribeTwoVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDescribeTwoVar.Name = "ucrSelectorDescribeTwoVar"
        Me.ucrSelectorDescribeTwoVar.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorDescribeTwoVar.TabIndex = 4
        '
        'ucrPnlDescribe
        '
        Me.ucrPnlDescribe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDescribe.Location = New System.Drawing.Point(138, 4)
        Me.ucrPnlDescribe.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlDescribe.Name = "ucrPnlDescribe"
        Me.ucrPnlDescribe.Size = New System.Drawing.Size(476, 51)
        Me.ucrPnlDescribe.TabIndex = 0
        '
        'ucrReceiverSkimrGroupByFactor
        '
        Me.ucrReceiverSkimrGroupByFactor.AutoSize = True
        Me.ucrReceiverSkimrGroupByFactor.frmParent = Me
        Me.ucrReceiverSkimrGroupByFactor.Location = New System.Drawing.Point(465, 246)
        Me.ucrReceiverSkimrGroupByFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSkimrGroupByFactor.Name = "ucrReceiverSkimrGroupByFactor"
        Me.ucrReceiverSkimrGroupByFactor.Selector = Nothing
        Me.ucrReceiverSkimrGroupByFactor.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverSkimrGroupByFactor.strNcFilePath = ""
        Me.ucrReceiverSkimrGroupByFactor.TabIndex = 2
        Me.ucrReceiverSkimrGroupByFactor.ucrSelector = Nothing
        '
        'ucrChkDisplayMargins
        '
        Me.ucrChkDisplayMargins.AutoSize = True
        Me.ucrChkDisplayMargins.Checked = False
        Me.ucrChkDisplayMargins.Location = New System.Drawing.Point(26, 444)
        Me.ucrChkDisplayMargins.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkDisplayMargins.Name = "ucrChkDisplayMargins"
        Me.ucrChkDisplayMargins.Size = New System.Drawing.Size(214, 34)
        Me.ucrChkDisplayMargins.TabIndex = 18
        '
        'ucrChkSummariesRowCol
        '
        Me.ucrChkSummariesRowCol.AutoSize = True
        Me.ucrChkSummariesRowCol.Checked = False
        Me.ucrChkSummariesRowCol.Location = New System.Drawing.Point(22, 507)
        Me.ucrChkSummariesRowCol.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkSummariesRowCol.Name = "ucrChkSummariesRowCol"
        Me.ucrChkSummariesRowCol.Size = New System.Drawing.Size(270, 34)
        Me.ucrChkSummariesRowCol.TabIndex = 20
        '
        'ucrChkLevSig
        '
        Me.ucrChkLevSig.AutoSize = True
        Me.ucrChkLevSig.Checked = False
        Me.ucrChkLevSig.Location = New System.Drawing.Point(596, 279)
        Me.ucrChkLevSig.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkLevSig.Name = "ucrChkLevSig"
        Me.ucrChkLevSig.Size = New System.Drawing.Size(129, 34)
        Me.ucrChkLevSig.TabIndex = 38
        '
        'ucrChkTotal
        '
        Me.ucrChkTotal.AutoSize = True
        Me.ucrChkTotal.Checked = False
        Me.ucrChkTotal.Location = New System.Drawing.Point(465, 279)
        Me.ucrChkTotal.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkTotal.Name = "ucrChkTotal"
        Me.ucrChkTotal.Size = New System.Drawing.Size(146, 34)
        Me.ucrChkTotal.TabIndex = 44
        '
        'ucrChkMeans
        '
        Me.ucrChkMeans.AutoSize = True
        Me.ucrChkMeans.Checked = False
        Me.ucrChkMeans.Location = New System.Drawing.Point(465, 312)
        Me.ucrChkMeans.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkMeans.Name = "ucrChkMeans"
        Me.ucrChkMeans.Size = New System.Drawing.Size(146, 34)
        Me.ucrChkMeans.TabIndex = 37
        '
        'ucrChkCorrelations
        '
        Me.ucrChkCorrelations.AutoSize = True
        Me.ucrChkCorrelations.Checked = False
        Me.ucrChkCorrelations.Location = New System.Drawing.Point(465, 381)
        Me.ucrChkCorrelations.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkCorrelations.Name = "ucrChkCorrelations"
        Me.ucrChkCorrelations.Size = New System.Drawing.Size(224, 34)
        Me.ucrChkCorrelations.TabIndex = 35
        '
        'ucrChkSwapXYVar
        '
        Me.ucrChkSwapXYVar.AutoSize = True
        Me.ucrChkSwapXYVar.Checked = False
        Me.ucrChkSwapXYVar.Location = New System.Drawing.Point(465, 347)
        Me.ucrChkSwapXYVar.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkSwapXYVar.Name = "ucrChkSwapXYVar"
        Me.ucrChkSwapXYVar.Size = New System.Drawing.Size(236, 34)
        Me.ucrChkSwapXYVar.TabIndex = 36
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.AutoSize = True
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(465, 416)
        Me.ucrChkOmitMissing.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(214, 34)
        Me.ucrChkOmitMissing.TabIndex = 0
        '
        'dlgDescribeTwoVariable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(723, 700)
        Me.Controls.Add(Me.cmdSummaries)
        Me.Controls.Add(Me.ucrReceiverThreeVariableThirdVariable)
        Me.Controls.Add(Me.ucrReceiverPercentages)
        Me.Controls.Add(Me.rdoORow)
        Me.Controls.Add(Me.rdoOCell)
        Me.Controls.Add(Me.rdoOCol)
        Me.Controls.Add(Me.ucrpnlPercent)
        Me.Controls.Add(Me.ucrReceiverThreeVariableSecondFactor)
        Me.Controls.Add(Me.ucrReceiverSecondTwoVariableFactor)
        Me.Controls.Add(Me.ucrReceiverFirstVars)
        Me.Controls.Add(Me.ucrSaveTable)
        Me.Controls.Add(Me.grpDisplay)
        Me.Controls.Add(Me.ucrInputMarginName)
        Me.Controls.Add(Me.ucrReorderSummary)
        Me.Controls.Add(Me.lblMarginName)
        Me.Controls.Add(Me.cmdFormatTable)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverSecondSkimrGroupByFactor)
        Me.Controls.Add(Me.ucrSelectorDescribeTwoVar)
        Me.Controls.Add(Me.lblFirstVariable)
        Me.Controls.Add(Me.grpSummaries)
        Me.Controls.Add(Me.rdoThreeVariable)
        Me.Controls.Add(Me.rdoTwoVariable)
        Me.Controls.Add(Me.rdoSkim)
        Me.Controls.Add(Me.ucrPnlDescribe)
        Me.Controls.Add(Me.ucrReceiverSkimrGroupByFactor)
        Me.Controls.Add(Me.lblSecondGroupByFactor)
        Me.Controls.Add(Me.lbSecondVariable)
        Me.Controls.Add(Me.lblFirstGroupByFactor)
        Me.Controls.Add(Me.lblThreeVariableSecondFactor)
        Me.Controls.Add(Me.ucrChkDisplayMargins)
        Me.Controls.Add(Me.cmdMissingOptions)
        Me.Controls.Add(Me.ucrChkSummariesRowCol)
        Me.Controls.Add(Me.lblThirdVariable)
        Me.Controls.Add(Me.ucrChkLevSig)
        Me.Controls.Add(Me.ucrChkTotal)
        Me.Controls.Add(Me.ucrChkCorrelations)
        Me.Controls.Add(Me.ucrChkSwapXYVar)
        Me.Controls.Add(Me.ucrChkMeans)
        Me.Controls.Add(Me.ucrChkOmitMissing)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents ucrChkDisplayAsPercentage As ucrCheck
    Friend WithEvents ucrSaveTable As ucrSave
    Friend WithEvents ucrReceiverFirstVars As ucrReceiverMultiple
    Friend WithEvents ucrChkSummariesRowCol As ucrCheck
    Friend WithEvents ucrChkCorrelations As ucrCheck
    Friend WithEvents ucrChkSwapXYVar As ucrCheck
    Friend WithEvents ucrChkMeans As ucrCheck
    Friend WithEvents ucrChkLevSig As ucrCheck
    Friend WithEvents ucrReceiverPercentages As ucrReceiverSingle
    Friend WithEvents rdoORow As RadioButton
    Friend WithEvents rdoOCell As RadioButton
    Friend WithEvents rdoOCol As RadioButton
    Friend WithEvents ucrpnlPercent As UcrPanel
    Friend WithEvents ucrReceiverColumns As ucrReceiverMultiple
    Friend WithEvents ucrChkTotal As ucrCheck
End Class
