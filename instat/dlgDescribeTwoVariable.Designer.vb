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
        Me.grpColumnFactor = New System.Windows.Forms.GroupBox()
        Me.rdoVariableFactor = New System.Windows.Forms.RadioButton()
        Me.rdoSummaryVariable = New System.Windows.Forms.RadioButton()
        Me.rdoNoColumnFactor = New System.Windows.Forms.RadioButton()
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
        Me.lblFactorAsPercentage = New System.Windows.Forms.Label()
        Me.ucrSaveTable = New instat.ucrSave()
        Me.ucrChkPercentageProportion = New instat.ucrCheck()
        Me.ucrReceiverPercentages = New instat.ucrReceiverSingle()
        Me.ucrChkDisplayAsPercentage = New instat.ucrCheck()
        Me.ucrInputMarginName = New instat.ucrInputTextBox()
        Me.ucrReorderSummary = New instat.ucrReorder()
        Me.ucrChkDisplayMargins = New instat.ucrCheck()
        Me.ucrReceiverColumnFactor = New instat.ucrReceiverSingle()
        Me.ucrPnlColumnFactor = New instat.UcrPanel()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverThreeVariableThirdVariable = New instat.ucrReceiverSingle()
        Me.ucrReceiverSecondSkimrGroupByFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverSecondTwoVariableFactor = New instat.ucrReceiverSingle()
        Me.ucrSelectorDescribeTwoVar = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverFirstVars = New instat.ucrReceiverMultiple()
        Me.ucrPnlDescribe = New instat.UcrPanel()
        Me.ucrReceiverThreeVariableSecondFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverSkimrGroupByFactor = New instat.ucrReceiverSingle()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.grpColumnFactor.SuspendLayout()
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
        Me.rdoThreeVariable.TabIndex = 26
        Me.rdoThreeVariable.Text = "Three Variables"
        Me.rdoThreeVariable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoThreeVariable.UseVisualStyleBackColor = True
        '
        'cmdFormatTable
        '
        Me.cmdFormatTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFormatTable.Location = New System.Drawing.Point(489, 634)
        Me.cmdFormatTable.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdFormatTable.Name = "cmdFormatTable"
        Me.cmdFormatTable.Size = New System.Drawing.Size(156, 34)
        Me.cmdFormatTable.TabIndex = 44
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
        Me.lblThreeVariableSecondFactor.TabIndex = 35
        Me.lblThreeVariableSecondFactor.Tag = ""
        Me.lblThreeVariableSecondFactor.Text = "Second Variable :"
        '
        'cmdMissingOptions
        '
        Me.cmdMissingOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMissingOptions.Location = New System.Drawing.Point(250, 444)
        Me.cmdMissingOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdMissingOptions.Name = "cmdMissingOptions"
        Me.cmdMissingOptions.Size = New System.Drawing.Size(158, 34)
        Me.cmdMissingOptions.TabIndex = 46
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
        Me.lbSecondVariable.TabIndex = 27
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
        Me.lblFirstVariable.TabIndex = 31
        Me.lblFirstVariable.Tag = ""
        Me.lblFirstVariable.Text = "First Variables:"
        '
        'grpColumnFactor
        '
        Me.grpColumnFactor.Controls.Add(Me.ucrReceiverColumnFactor)
        Me.grpColumnFactor.Controls.Add(Me.rdoVariableFactor)
        Me.grpColumnFactor.Controls.Add(Me.rdoSummaryVariable)
        Me.grpColumnFactor.Controls.Add(Me.rdoNoColumnFactor)
        Me.grpColumnFactor.Controls.Add(Me.ucrPnlColumnFactor)
        Me.grpColumnFactor.Location = New System.Drawing.Point(21, 504)
        Me.grpColumnFactor.Margin = New System.Windows.Forms.Padding(4)
        Me.grpColumnFactor.Name = "grpColumnFactor"
        Me.grpColumnFactor.Padding = New System.Windows.Forms.Padding(4)
        Me.grpColumnFactor.Size = New System.Drawing.Size(382, 146)
        Me.grpColumnFactor.TabIndex = 51
        Me.grpColumnFactor.TabStop = False
        Me.grpColumnFactor.Text = "Columns"
        '
        'rdoVariableFactor
        '
        Me.rdoVariableFactor.AutoSize = True
        Me.rdoVariableFactor.Location = New System.Drawing.Point(22, 68)
        Me.rdoVariableFactor.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoVariableFactor.Name = "rdoVariableFactor"
        Me.rdoVariableFactor.Size = New System.Drawing.Size(142, 24)
        Me.rdoVariableFactor.TabIndex = 51
        Me.rdoVariableFactor.TabStop = True
        Me.rdoVariableFactor.Text = "Variable Factor"
        Me.rdoVariableFactor.UseVisualStyleBackColor = True
        '
        'rdoSummaryVariable
        '
        Me.rdoSummaryVariable.AutoSize = True
        Me.rdoSummaryVariable.Location = New System.Drawing.Point(22, 34)
        Me.rdoSummaryVariable.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoSummaryVariable.Name = "rdoSummaryVariable"
        Me.rdoSummaryVariable.Size = New System.Drawing.Size(163, 24)
        Me.rdoSummaryVariable.TabIndex = 47
        Me.rdoSummaryVariable.TabStop = True
        Me.rdoSummaryVariable.Text = "Summary Variable"
        Me.rdoSummaryVariable.UseVisualStyleBackColor = True
        '
        'rdoNoColumnFactor
        '
        Me.rdoNoColumnFactor.AutoSize = True
        Me.rdoNoColumnFactor.Location = New System.Drawing.Point(22, 99)
        Me.rdoNoColumnFactor.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoNoColumnFactor.Name = "rdoNoColumnFactor"
        Me.rdoNoColumnFactor.Size = New System.Drawing.Size(162, 24)
        Me.rdoNoColumnFactor.TabIndex = 50
        Me.rdoNoColumnFactor.TabStop = True
        Me.rdoNoColumnFactor.Text = "No Column Factor"
        Me.rdoNoColumnFactor.UseVisualStyleBackColor = True
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
        Me.grpSummaries.Location = New System.Drawing.Point(17, 328)
        Me.grpSummaries.Margin = New System.Windows.Forms.Padding(4)
        Me.grpSummaries.Name = "grpSummaries"
        Me.grpSummaries.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSummaries.Size = New System.Drawing.Size(315, 108)
        Me.grpSummaries.TabIndex = 39
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
        Me.lblSecondBy.TabIndex = 1
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
        Me.lblThreeVariableCategorical.TabIndex = 3
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
        Me.lblSummaryName.TabIndex = 5
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummary.Location = New System.Drawing.Point(18, 76)
        Me.lblSummary.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(80, 20)
        Me.lblSummary.TabIndex = 4
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
        Me.lblBy.TabIndex = 6
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
        Me.lblSecondType.TabIndex = 0
        '
        'lblFirstGroupByFactor
        '
        Me.lblFirstGroupByFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstGroupByFactor.Location = New System.Drawing.Point(472, 224)
        Me.lblFirstGroupByFactor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstGroupByFactor.Name = "lblFirstGroupByFactor"
        Me.lblFirstGroupByFactor.Size = New System.Drawing.Size(150, 22)
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
        Me.rdoSkim.Location = New System.Drawing.Point(143, 12)
        Me.rdoSkim.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoSkim.Name = "rdoSkim"
        Me.rdoSkim.Size = New System.Drawing.Size(150, 42)
        Me.rdoSkim.TabIndex = 23
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
        Me.lblThirdVariable.TabIndex = 37
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
        Me.rdoTwoVariable.TabIndex = 24
        Me.rdoTwoVariable.Text = "Two Variables"
        Me.rdoTwoVariable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTwoVariable.UseVisualStyleBackColor = True
        '
        'cmdSummaries
        '
        Me.cmdSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSummaries.Location = New System.Drawing.Point(465, 344)
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
        Me.grpDisplay.Location = New System.Drawing.Point(412, 308)
        Me.grpDisplay.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDisplay.Size = New System.Drawing.Size(291, 172)
        Me.grpDisplay.TabIndex = 56
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Text = "Percentages"
        '
        'lblFactorAsPercentage
        '
        Me.lblFactorAsPercentage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactorAsPercentage.Location = New System.Drawing.Point(14, 63)
        Me.lblFactorAsPercentage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFactorAsPercentage.Name = "lblFactorAsPercentage"
        Me.lblFactorAsPercentage.Size = New System.Drawing.Size(231, 22)
        Me.lblFactorAsPercentage.TabIndex = 56
        Me.lblFactorAsPercentage.Tag = ""
        Me.lblFactorAsPercentage.Text = "Factor as Percentage:"
        '
        'ucrSaveTable
        '
        Me.ucrSaveTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveTable.Location = New System.Drawing.Point(23, 676)
        Me.ucrSaveTable.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveTable.Name = "ucrSaveTable"
        Me.ucrSaveTable.Size = New System.Drawing.Size(598, 36)
        Me.ucrSaveTable.TabIndex = 57
        '
        'ucrChkPercentageProportion
        '
        Me.ucrChkPercentageProportion.AutoSize = True
        Me.ucrChkPercentageProportion.Checked = False
        Me.ucrChkPercentageProportion.Location = New System.Drawing.Point(18, 126)
        Me.ucrChkPercentageProportion.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkPercentageProportion.Name = "ucrChkPercentageProportion"
        Me.ucrChkPercentageProportion.Size = New System.Drawing.Size(214, 51)
        Me.ucrChkPercentageProportion.TabIndex = 57
        '
        'ucrReceiverPercentages
        '
        Me.ucrReceiverPercentages.AutoSize = True
        Me.ucrReceiverPercentages.frmParent = Nothing
        Me.ucrReceiverPercentages.Location = New System.Drawing.Point(18, 86)
        Me.ucrReceiverPercentages.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPercentages.Name = "ucrReceiverPercentages"
        Me.ucrReceiverPercentages.Selector = Nothing
        Me.ucrReceiverPercentages.Size = New System.Drawing.Size(214, 30)
        Me.ucrReceiverPercentages.strNcFilePath = ""
        Me.ucrReceiverPercentages.TabIndex = 55
        Me.ucrReceiverPercentages.ucrSelector = Nothing
        '
        'ucrChkDisplayAsPercentage
        '
        Me.ucrChkDisplayAsPercentage.AutoSize = True
        Me.ucrChkDisplayAsPercentage.Checked = False
        Me.ucrChkDisplayAsPercentage.Location = New System.Drawing.Point(18, 26)
        Me.ucrChkDisplayAsPercentage.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkDisplayAsPercentage.Name = "ucrChkDisplayAsPercentage"
        Me.ucrChkDisplayAsPercentage.Size = New System.Drawing.Size(214, 51)
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
        Me.ucrInputMarginName.TabIndex = 55
        '
        'ucrReorderSummary
        '
        Me.ucrReorderSummary.Location = New System.Drawing.Point(412, 387)
        Me.ucrReorderSummary.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrReorderSummary.Name = "ucrReorderSummary"
        Me.ucrReorderSummary.Size = New System.Drawing.Size(291, 234)
        Me.ucrReorderSummary.TabIndex = 52
        Me.ucrReorderSummary.ucrDataFrameList = Nothing
        Me.ucrReorderSummary.ucrReceiver = Nothing
        '
        'ucrChkDisplayMargins
        '
        Me.ucrChkDisplayMargins.AutoSize = True
        Me.ucrChkDisplayMargins.Checked = False
        Me.ucrChkDisplayMargins.Location = New System.Drawing.Point(25, 444)
        Me.ucrChkDisplayMargins.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkDisplayMargins.Name = "ucrChkDisplayMargins"
        Me.ucrChkDisplayMargins.Size = New System.Drawing.Size(214, 34)
        Me.ucrChkDisplayMargins.TabIndex = 53
        '
        'ucrReceiverColumnFactor
        '
        Me.ucrReceiverColumnFactor.AutoSize = True
        Me.ucrReceiverColumnFactor.frmParent = Nothing
        Me.ucrReceiverColumnFactor.Location = New System.Drawing.Point(198, 64)
        Me.ucrReceiverColumnFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnFactor.Name = "ucrReceiverColumnFactor"
        Me.ucrReceiverColumnFactor.Selector = Nothing
        Me.ucrReceiverColumnFactor.Size = New System.Drawing.Size(178, 30)
        Me.ucrReceiverColumnFactor.strNcFilePath = ""
        Me.ucrReceiverColumnFactor.TabIndex = 52
        Me.ucrReceiverColumnFactor.ucrSelector = Nothing
        '
        'ucrPnlColumnFactor
        '
        Me.ucrPnlColumnFactor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlColumnFactor.Location = New System.Drawing.Point(9, 27)
        Me.ucrPnlColumnFactor.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlColumnFactor.Name = "ucrPnlColumnFactor"
        Me.ucrPnlColumnFactor.Size = New System.Drawing.Size(184, 108)
        Me.ucrPnlColumnFactor.TabIndex = 48
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(23, 734)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 43
        '
        'ucrReceiverThreeVariableThirdVariable
        '
        Me.ucrReceiverThreeVariableThirdVariable.AutoSize = True
        Me.ucrReceiverThreeVariableThirdVariable.frmParent = Me
        Me.ucrReceiverThreeVariableThirdVariable.Location = New System.Drawing.Point(465, 306)
        Me.ucrReceiverThreeVariableThirdVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverThreeVariableThirdVariable.Name = "ucrReceiverThreeVariableThirdVariable"
        Me.ucrReceiverThreeVariableThirdVariable.Selector = Nothing
        Me.ucrReceiverThreeVariableThirdVariable.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverThreeVariableThirdVariable.strNcFilePath = ""
        Me.ucrReceiverThreeVariableThirdVariable.TabIndex = 38
        Me.ucrReceiverThreeVariableThirdVariable.ucrSelector = Nothing
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
        Me.ucrReceiverSecondTwoVariableFactor.TabIndex = 25
        Me.ucrReceiverSecondTwoVariableFactor.ucrSelector = Nothing
        '
        'ucrSelectorDescribeTwoVar
        '
        Me.ucrSelectorDescribeTwoVar.AutoSize = True
        Me.ucrSelectorDescribeTwoVar.bDropUnusedFilterLevels = False
        Me.ucrSelectorDescribeTwoVar.bShowHiddenColumns = False
        Me.ucrSelectorDescribeTwoVar.bUseCurrentFilter = True
        Me.ucrSelectorDescribeTwoVar.Location = New System.Drawing.Point(17, 54)
        Me.ucrSelectorDescribeTwoVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDescribeTwoVar.Name = "ucrSelectorDescribeTwoVar"
        Me.ucrSelectorDescribeTwoVar.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorDescribeTwoVar.TabIndex = 28
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
        Me.ucrReceiverFirstVars.TabIndex = 30
        Me.ucrReceiverFirstVars.ucrSelector = Nothing
        '
        'ucrPnlDescribe
        '
        Me.ucrPnlDescribe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDescribe.Location = New System.Drawing.Point(138, 4)
        Me.ucrPnlDescribe.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlDescribe.Name = "ucrPnlDescribe"
        Me.ucrPnlDescribe.Size = New System.Drawing.Size(476, 51)
        Me.ucrPnlDescribe.TabIndex = 22
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
        Me.ucrReceiverThreeVariableSecondFactor.TabIndex = 36
        Me.ucrReceiverThreeVariableSecondFactor.ucrSelector = Nothing
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
        Me.ucrReceiverSkimrGroupByFactor.TabIndex = 32
        Me.ucrReceiverSkimrGroupByFactor.ucrSelector = Nothing
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.AutoSize = True
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(25, 444)
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
        Me.ClientSize = New System.Drawing.Size(723, 822)
        Me.Controls.Add(Me.ucrSaveTable)
        Me.Controls.Add(Me.grpDisplay)
        Me.Controls.Add(Me.ucrInputMarginName)
        Me.Controls.Add(Me.cmdSummaries)
        Me.Controls.Add(Me.ucrReorderSummary)
        Me.Controls.Add(Me.lblMarginName)
        Me.Controls.Add(Me.cmdMissingOptions)
        Me.Controls.Add(Me.ucrChkDisplayMargins)
        Me.Controls.Add(Me.grpColumnFactor)
        Me.Controls.Add(Me.cmdFormatTable)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverThreeVariableThirdVariable)
        Me.Controls.Add(Me.ucrReceiverSecondSkimrGroupByFactor)
        Me.Controls.Add(Me.ucrReceiverSecondTwoVariableFactor)
        Me.Controls.Add(Me.ucrSelectorDescribeTwoVar)
        Me.Controls.Add(Me.lblFirstVariable)
        Me.Controls.Add(Me.grpSummaries)
        Me.Controls.Add(Me.ucrReceiverFirstVars)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescribeTwoVariable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Describe_Two_Variable"
        Me.Text = "Describe Two Variables"
        Me.grpColumnFactor.ResumeLayout(False)
        Me.grpColumnFactor.PerformLayout()
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
    Friend WithEvents ucrReceiverFirstVars As ucrReceiverMultiple
    Friend WithEvents rdoThreeVariable As RadioButton
    Friend WithEvents rdoTwoVariable As RadioButton
    Friend WithEvents rdoSkim As RadioButton
    Friend WithEvents ucrPnlDescribe As UcrPanel
    Friend WithEvents cmdMissingOptions As Button
    Friend WithEvents rdoNoColumnFactor As RadioButton
    Friend WithEvents rdoSummaryVariable As RadioButton
    Friend WithEvents ucrPnlColumnFactor As UcrPanel
    Friend WithEvents grpColumnFactor As GroupBox
    Friend WithEvents ucrReorderSummary As ucrReorder
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents rdoVariableFactor As RadioButton
    Friend WithEvents ucrReceiverColumnFactor As ucrReceiverSingle
    Friend WithEvents ucrInputMarginName As ucrInputTextBox
    Friend WithEvents lblMarginName As Label
    Friend WithEvents ucrChkDisplayMargins As ucrCheck
    Friend WithEvents grpDisplay As GroupBox
    Friend WithEvents ucrChkPercentageProportion As ucrCheck
    Friend WithEvents lblFactorAsPercentage As Label
    Friend WithEvents ucrReceiverPercentages As ucrReceiverSingle
    Friend WithEvents ucrChkDisplayAsPercentage As ucrCheck
    Friend WithEvents ucrSaveTable As ucrSave
End Class
