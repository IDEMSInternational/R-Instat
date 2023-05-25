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
        Me.ucrNudColumnFactors = New instat.ucrNud()
        Me.ucrReceiverPercentages = New instat.ucrReceiverSingle()
        Me.lblFactorsAsPercentage = New System.Windows.Forms.Label()
        Me.ucrChkPercentageProportion = New instat.ucrCheck()
        Me.ucrNudSigFigs = New instat.ucrNud()
        Me.ucrInputMarginName = New instat.ucrInputTextBox()
        Me.lblSigFigs = New System.Windows.Forms.Label()
        Me.ucrChkDisplayMargins = New instat.ucrCheck()
        Me.grpThreeVariablePercentages = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverThreeVariablePercentage = New instat.ucrReceiverSingle()
        Me.lblThreeVariableFactorAsPercentages = New System.Windows.Forms.Label()
        Me.ucrChkThreeVariablePercentageProportion = New instat.ucrCheck()
        Me.ucrChkThreeVariableDisplayAsPercentage = New instat.ucrCheck()
        Me.rdoThreeVariable = New System.Windows.Forms.RadioButton()
        Me.lblColumnFactors = New System.Windows.Forms.Label()
        Me.cmdFormatTable = New System.Windows.Forms.Button()
        Me.lblThreeVariableSecondFactor = New System.Windows.Forms.Label()
        Me.ucrReceiverThreeVariableSecondFactor = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverThreeVariableThirdVariable = New instat.ucrReceiverSingle()
        Me.ucrReceiverSecondSkimrGroupByFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverSkimrGroupByFactor = New instat.ucrReceiverSingle()
        Me.ucrPnlDescribe = New instat.UcrPanel()
        Me.ucrReceiverSecondTwoVariableFactor = New instat.ucrReceiverSingle()
        Me.ucrSelectorDescribeTwoVar = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkDisplayAsPercentage = New instat.ucrCheck()
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.lbSecondVariable = New System.Windows.Forms.Label()
        Me.lblFirstVariable = New System.Windows.Forms.Label()
        Me.grpFrequency = New System.Windows.Forms.GroupBox()
        Me.lblMarginName = New System.Windows.Forms.Label()
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
        Me.grpTwoVariablePercentages = New System.Windows.Forms.GroupBox()
        Me.rdoTwoVariable = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverFirstVars = New instat.ucrReceiverMultiple()
        Me.grpThreeVariablePercentages.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.grpFrequency.SuspendLayout()
        Me.grpSummaries.SuspendLayout()
        Me.grpTwoVariablePercentages.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrNudColumnFactors
        '
        Me.ucrNudColumnFactors.AutoSize = True
        Me.ucrNudColumnFactors.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColumnFactors.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudColumnFactors.Location = New System.Drawing.Point(129, 48)
        Me.ucrNudColumnFactors.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudColumnFactors.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColumnFactors.Name = "ucrNudColumnFactors"
        Me.ucrNudColumnFactors.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudColumnFactors.TabIndex = 6
        Me.ucrNudColumnFactors.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverPercentages
        '
        Me.ucrReceiverPercentages.AutoSize = True
        Me.ucrReceiverPercentages.frmParent = Me
        Me.ucrReceiverPercentages.Location = New System.Drawing.Point(21, 63)
        Me.ucrReceiverPercentages.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPercentages.Name = "ucrReceiverPercentages"
        Me.ucrReceiverPercentages.Selector = Nothing
        Me.ucrReceiverPercentages.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPercentages.strNcFilePath = ""
        Me.ucrReceiverPercentages.TabIndex = 8
        Me.ucrReceiverPercentages.ucrSelector = Nothing
        '
        'lblFactorsAsPercentage
        '
        Me.lblFactorsAsPercentage.AutoSize = True
        Me.lblFactorsAsPercentage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactorsAsPercentage.Location = New System.Drawing.Point(18, 44)
        Me.lblFactorsAsPercentage.Name = "lblFactorsAsPercentage"
        Me.lblFactorsAsPercentage.Size = New System.Drawing.Size(117, 13)
        Me.lblFactorsAsPercentage.TabIndex = 1
        Me.lblFactorsAsPercentage.Tag = "Of Factor (Optional):"
        Me.lblFactorsAsPercentage.Text = "Factors as Percentage:"
        '
        'ucrChkPercentageProportion
        '
        Me.ucrChkPercentageProportion.AutoSize = True
        Me.ucrChkPercentageProportion.Checked = False
        Me.ucrChkPercentageProportion.Location = New System.Drawing.Point(14, 86)
        Me.ucrChkPercentageProportion.Name = "ucrChkPercentageProportion"
        Me.ucrChkPercentageProportion.Size = New System.Drawing.Size(154, 23)
        Me.ucrChkPercentageProportion.TabIndex = 3
        '
        'ucrNudSigFigs
        '
        Me.ucrNudSigFigs.AutoSize = True
        Me.ucrNudSigFigs.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigFigs.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSigFigs.Location = New System.Drawing.Point(129, 22)
        Me.ucrNudSigFigs.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSigFigs.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigFigs.Name = "ucrNudSigFigs"
        Me.ucrNudSigFigs.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSigFigs.TabIndex = 5
        Me.ucrNudSigFigs.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputMarginName
        '
        Me.ucrInputMarginName.AddQuotesIfUnrecognised = True
        Me.ucrInputMarginName.AutoSize = True
        Me.ucrInputMarginName.IsMultiline = False
        Me.ucrInputMarginName.IsReadOnly = False
        Me.ucrInputMarginName.Location = New System.Drawing.Point(53, 98)
        Me.ucrInputMarginName.Name = "ucrInputMarginName"
        Me.ucrInputMarginName.Size = New System.Drawing.Size(74, 21)
        Me.ucrInputMarginName.TabIndex = 4
        '
        'lblSigFigs
        '
        Me.lblSigFigs.AutoSize = True
        Me.lblSigFigs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSigFigs.Location = New System.Drawing.Point(8, 25)
        Me.lblSigFigs.Name = "lblSigFigs"
        Me.lblSigFigs.Size = New System.Drawing.Size(96, 13)
        Me.lblSigFigs.TabIndex = 0
        Me.lblSigFigs.Tag = "Significant_Figures:"
        Me.lblSigFigs.Text = "Significant Figures:"
        '
        'ucrChkDisplayMargins
        '
        Me.ucrChkDisplayMargins.AutoSize = True
        Me.ucrChkDisplayMargins.Checked = False
        Me.ucrChkDisplayMargins.Location = New System.Drawing.Point(9, 74)
        Me.ucrChkDisplayMargins.Name = "ucrChkDisplayMargins"
        Me.ucrChkDisplayMargins.Size = New System.Drawing.Size(149, 23)
        Me.ucrChkDisplayMargins.TabIndex = 2
        '
        'grpThreeVariablePercentages
        '
        Me.grpThreeVariablePercentages.Controls.Add(Me.ucrReceiverThreeVariablePercentage)
        Me.grpThreeVariablePercentages.Controls.Add(Me.lblThreeVariableFactorAsPercentages)
        Me.grpThreeVariablePercentages.Controls.Add(Me.ucrChkThreeVariablePercentageProportion)
        Me.grpThreeVariablePercentages.Controls.Add(Me.ucrChkThreeVariableDisplayAsPercentage)
        Me.grpThreeVariablePercentages.Location = New System.Drawing.Point(232, 247)
        Me.grpThreeVariablePercentages.Name = "grpThreeVariablePercentages"
        Me.grpThreeVariablePercentages.Size = New System.Drawing.Size(174, 114)
        Me.grpThreeVariablePercentages.TabIndex = 41
        Me.grpThreeVariablePercentages.TabStop = False
        Me.grpThreeVariablePercentages.Text = "Percentages"
        '
        'ucrReceiverThreeVariablePercentage
        '
        Me.ucrReceiverThreeVariablePercentage.AutoSize = True
        Me.ucrReceiverThreeVariablePercentage.frmParent = Me
        Me.ucrReceiverThreeVariablePercentage.Location = New System.Drawing.Point(21, 63)
        Me.ucrReceiverThreeVariablePercentage.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverThreeVariablePercentage.Name = "ucrReceiverThreeVariablePercentage"
        Me.ucrReceiverThreeVariablePercentage.Selector = Nothing
        Me.ucrReceiverThreeVariablePercentage.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverThreeVariablePercentage.strNcFilePath = ""
        Me.ucrReceiverThreeVariablePercentage.TabIndex = 3
        Me.ucrReceiverThreeVariablePercentage.ucrSelector = Nothing
        '
        'lblThreeVariableFactorAsPercentages
        '
        Me.lblThreeVariableFactorAsPercentages.AutoSize = True
        Me.lblThreeVariableFactorAsPercentages.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblThreeVariableFactorAsPercentages.Location = New System.Drawing.Point(18, 44)
        Me.lblThreeVariableFactorAsPercentages.Name = "lblThreeVariableFactorAsPercentages"
        Me.lblThreeVariableFactorAsPercentages.Size = New System.Drawing.Size(102, 13)
        Me.lblThreeVariableFactorAsPercentages.TabIndex = 2
        Me.lblThreeVariableFactorAsPercentages.Tag = "Factors as Percentage:"
        Me.lblThreeVariableFactorAsPercentages.Text = "Of Factor (Optional):"
        '
        'ucrChkThreeVariablePercentageProportion
        '
        Me.ucrChkThreeVariablePercentageProportion.AutoSize = True
        Me.ucrChkThreeVariablePercentageProportion.Checked = False
        Me.ucrChkThreeVariablePercentageProportion.Location = New System.Drawing.Point(14, 88)
        Me.ucrChkThreeVariablePercentageProportion.Name = "ucrChkThreeVariablePercentageProportion"
        Me.ucrChkThreeVariablePercentageProportion.Size = New System.Drawing.Size(136, 23)
        Me.ucrChkThreeVariablePercentageProportion.TabIndex = 0
        '
        'ucrChkThreeVariableDisplayAsPercentage
        '
        Me.ucrChkThreeVariableDisplayAsPercentage.AutoSize = True
        Me.ucrChkThreeVariableDisplayAsPercentage.Checked = False
        Me.ucrChkThreeVariableDisplayAsPercentage.Location = New System.Drawing.Point(14, 19)
        Me.ucrChkThreeVariableDisplayAsPercentage.Name = "ucrChkThreeVariableDisplayAsPercentage"
        Me.ucrChkThreeVariableDisplayAsPercentage.Size = New System.Drawing.Size(135, 23)
        Me.ucrChkThreeVariableDisplayAsPercentage.TabIndex = 0
        '
        'rdoThreeVariable
        '
        Me.rdoThreeVariable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoThreeVariable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoThreeVariable.FlatAppearance.BorderSize = 2
        Me.rdoThreeVariable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoThreeVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoThreeVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoThreeVariable.Location = New System.Drawing.Point(235, 8)
        Me.rdoThreeVariable.Name = "rdoThreeVariable"
        Me.rdoThreeVariable.Size = New System.Drawing.Size(100, 28)
        Me.rdoThreeVariable.TabIndex = 26
        Me.rdoThreeVariable.Text = "Three Variables"
        Me.rdoThreeVariable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoThreeVariable.UseVisualStyleBackColor = True
        '
        'lblColumnFactors
        '
        Me.lblColumnFactors.AutoSize = True
        Me.lblColumnFactors.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumnFactors.Location = New System.Drawing.Point(8, 53)
        Me.lblColumnFactors.Name = "lblColumnFactors"
        Me.lblColumnFactors.Size = New System.Drawing.Size(83, 13)
        Me.lblColumnFactors.TabIndex = 1
        Me.lblColumnFactors.Tag = ""
        Me.lblColumnFactors.Text = "Column Factors:"
        '
        'cmdFormatTable
        '
        Me.cmdFormatTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFormatTable.Location = New System.Drawing.Point(272, 407)
        Me.cmdFormatTable.Name = "cmdFormatTable"
        Me.cmdFormatTable.Size = New System.Drawing.Size(104, 23)
        Me.cmdFormatTable.TabIndex = 44
        Me.cmdFormatTable.Text = "Format Table..."
        Me.cmdFormatTable.UseVisualStyleBackColor = True
        '
        'lblThreeVariableSecondFactor
        '
        Me.lblThreeVariableSecondFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblThreeVariableSecondFactor.Location = New System.Drawing.Point(261, 161)
        Me.lblThreeVariableSecondFactor.Name = "lblThreeVariableSecondFactor"
        Me.lblThreeVariableSecondFactor.Size = New System.Drawing.Size(100, 15)
        Me.lblThreeVariableSecondFactor.TabIndex = 35
        Me.lblThreeVariableSecondFactor.Tag = ""
        Me.lblThreeVariableSecondFactor.Text = "Second Variable :"
        '
        'ucrReceiverThreeVariableSecondFactor
        '
        Me.ucrReceiverThreeVariableSecondFactor.AutoSize = True
        Me.ucrReceiverThreeVariableSecondFactor.frmParent = Me
        Me.ucrReceiverThreeVariableSecondFactor.Location = New System.Drawing.Point(264, 176)
        Me.ucrReceiverThreeVariableSecondFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverThreeVariableSecondFactor.Name = "ucrReceiverThreeVariableSecondFactor"
        Me.ucrReceiverThreeVariableSecondFactor.Selector = Nothing
        Me.ucrReceiverThreeVariableSecondFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverThreeVariableSecondFactor.strNcFilePath = ""
        Me.ucrReceiverThreeVariableSecondFactor.TabIndex = 36
        Me.ucrReceiverThreeVariableSecondFactor.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(8, 435)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 43
        '
        'ucrReceiverThreeVariableThirdVariable
        '
        Me.ucrReceiverThreeVariableThirdVariable.AutoSize = True
        Me.ucrReceiverThreeVariableThirdVariable.frmParent = Me
        Me.ucrReceiverThreeVariableThirdVariable.Location = New System.Drawing.Point(265, 219)
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
        Me.ucrReceiverSecondSkimrGroupByFactor.Location = New System.Drawing.Point(265, 219)
        Me.ucrReceiverSecondSkimrGroupByFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondSkimrGroupByFactor.Name = "ucrReceiverSecondSkimrGroupByFactor"
        Me.ucrReceiverSecondSkimrGroupByFactor.Selector = Nothing
        Me.ucrReceiverSecondSkimrGroupByFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSecondSkimrGroupByFactor.strNcFilePath = ""
        Me.ucrReceiverSecondSkimrGroupByFactor.TabIndex = 34
        Me.ucrReceiverSecondSkimrGroupByFactor.ucrSelector = Nothing
        '
        'ucrReceiverSkimrGroupByFactor
        '
        Me.ucrReceiverSkimrGroupByFactor.AutoSize = True
        Me.ucrReceiverSkimrGroupByFactor.frmParent = Me
        Me.ucrReceiverSkimrGroupByFactor.Location = New System.Drawing.Point(264, 176)
        Me.ucrReceiverSkimrGroupByFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSkimrGroupByFactor.Name = "ucrReceiverSkimrGroupByFactor"
        Me.ucrReceiverSkimrGroupByFactor.Selector = Nothing
        Me.ucrReceiverSkimrGroupByFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSkimrGroupByFactor.strNcFilePath = ""
        Me.ucrReceiverSkimrGroupByFactor.TabIndex = 32
        Me.ucrReceiverSkimrGroupByFactor.ucrSelector = Nothing
        '
        'ucrPnlDescribe
        '
        Me.ucrPnlDescribe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDescribe.Location = New System.Drawing.Point(39, 3)
        Me.ucrPnlDescribe.Name = "ucrPnlDescribe"
        Me.ucrPnlDescribe.Size = New System.Drawing.Size(317, 34)
        Me.ucrPnlDescribe.TabIndex = 22
        '
        'ucrReceiverSecondTwoVariableFactor
        '
        Me.ucrReceiverSecondTwoVariableFactor.AutoSize = True
        Me.ucrReceiverSecondTwoVariableFactor.frmParent = Me
        Me.ucrReceiverSecondTwoVariableFactor.Location = New System.Drawing.Point(264, 176)
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
        Me.ucrSelectorDescribeTwoVar.Location = New System.Drawing.Point(3, 36)
        Me.ucrSelectorDescribeTwoVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDescribeTwoVar.Name = "ucrSelectorDescribeTwoVar"
        Me.ucrSelectorDescribeTwoVar.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorDescribeTwoVar.TabIndex = 28
        '
        'ucrChkDisplayAsPercentage
        '
        Me.ucrChkDisplayAsPercentage.AutoSize = True
        Me.ucrChkDisplayAsPercentage.Checked = False
        Me.ucrChkDisplayAsPercentage.Location = New System.Drawing.Point(14, 19)
        Me.ucrChkDisplayAsPercentage.Name = "ucrChkDisplayAsPercentage"
        Me.ucrChkDisplayAsPercentage.Size = New System.Drawing.Size(135, 23)
        Me.ucrChkDisplayAsPercentage.TabIndex = 0
        '
        'cmdSummaries
        '
        Me.cmdSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSummaries.Location = New System.Drawing.Point(6, 45)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(105, 23)
        Me.cmdSummaries.TabIndex = 1
        Me.cmdSummaries.Tag = "Summaries"
        Me.cmdSummaries.Text = "Summaries"
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrChkOmitMissing)
        Me.grpOptions.Controls.Add(Me.cmdSummaries)
        Me.grpOptions.Location = New System.Drawing.Point(249, 247)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(155, 76)
        Me.grpOptions.TabIndex = 40
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.AutoSize = True
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(9, 19)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(143, 23)
        Me.ucrChkOmitMissing.TabIndex = 0
        '
        'lbSecondVariable
        '
        Me.lbSecondVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbSecondVariable.Location = New System.Drawing.Point(261, 161)
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
        Me.lblFirstVariable.Location = New System.Drawing.Point(261, 55)
        Me.lblFirstVariable.Name = "lblFirstVariable"
        Me.lblFirstVariable.Size = New System.Drawing.Size(75, 13)
        Me.lblFirstVariable.TabIndex = 31
        Me.lblFirstVariable.Tag = ""
        Me.lblFirstVariable.Text = "First Variables:"
        '
        'grpFrequency
        '
        Me.grpFrequency.Controls.Add(Me.ucrNudColumnFactors)
        Me.grpFrequency.Controls.Add(Me.lblColumnFactors)
        Me.grpFrequency.Controls.Add(Me.ucrNudSigFigs)
        Me.grpFrequency.Controls.Add(Me.ucrInputMarginName)
        Me.grpFrequency.Controls.Add(Me.lblMarginName)
        Me.grpFrequency.Controls.Add(Me.lblSigFigs)
        Me.grpFrequency.Controls.Add(Me.ucrChkDisplayMargins)
        Me.grpFrequency.Location = New System.Drawing.Point(3, 299)
        Me.grpFrequency.Name = "grpFrequency"
        Me.grpFrequency.Size = New System.Drawing.Size(223, 127)
        Me.grpFrequency.TabIndex = 42
        Me.grpFrequency.TabStop = False
        Me.grpFrequency.Text = "Display"
        '
        'lblMarginName
        '
        Me.lblMarginName.AutoSize = True
        Me.lblMarginName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMarginName.Location = New System.Drawing.Point(11, 101)
        Me.lblMarginName.Name = "lblMarginName"
        Me.lblMarginName.Size = New System.Drawing.Size(41, 13)
        Me.lblMarginName.TabIndex = 3
        Me.lblMarginName.Text = "Name :"
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
        Me.grpSummaries.Location = New System.Drawing.Point(3, 224)
        Me.grpSummaries.Name = "grpSummaries"
        Me.grpSummaries.Size = New System.Drawing.Size(210, 72)
        Me.grpSummaries.TabIndex = 39
        Me.grpSummaries.TabStop = False
        '
        'lblFirstType
        '
        Me.lblFirstType.AutoSize = True
        Me.lblFirstType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstType.Location = New System.Drawing.Point(12, 15)
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
        Me.lblFirstGroupByFactor.Location = New System.Drawing.Point(261, 161)
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
        Me.rdoSkim.Location = New System.Drawing.Point(42, 8)
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
        Me.lblThirdVariable.Location = New System.Drawing.Point(263, 200)
        Me.lblThirdVariable.Name = "lblThirdVariable"
        Me.lblThirdVariable.Size = New System.Drawing.Size(154, 15)
        Me.lblThirdVariable.TabIndex = 37
        Me.lblThirdVariable.Tag = ""
        Me.lblThirdVariable.Text = "Third Variable :"
        '
        'lblSecondGroupByFactor
        '
        Me.lblSecondGroupByFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondGroupByFactor.Location = New System.Drawing.Point(263, 203)
        Me.lblSecondGroupByFactor.Name = "lblSecondGroupByFactor"
        Me.lblSecondGroupByFactor.Size = New System.Drawing.Size(137, 15)
        Me.lblSecondGroupByFactor.TabIndex = 33
        Me.lblSecondGroupByFactor.Tag = ""
        Me.lblSecondGroupByFactor.Text = "Second Factor (Optional) :"
        '
        'grpTwoVariablePercentages
        '
        Me.grpTwoVariablePercentages.Controls.Add(Me.ucrReceiverPercentages)
        Me.grpTwoVariablePercentages.Controls.Add(Me.lblFactorsAsPercentage)
        Me.grpTwoVariablePercentages.Controls.Add(Me.ucrChkPercentageProportion)
        Me.grpTwoVariablePercentages.Controls.Add(Me.ucrChkDisplayAsPercentage)
        Me.grpTwoVariablePercentages.Location = New System.Drawing.Point(232, 247)
        Me.grpTwoVariablePercentages.Name = "grpTwoVariablePercentages"
        Me.grpTwoVariablePercentages.Size = New System.Drawing.Size(174, 120)
        Me.grpTwoVariablePercentages.TabIndex = 45
        Me.grpTwoVariablePercentages.TabStop = False
        Me.grpTwoVariablePercentages.Text = "Percentages"
        '
        'rdoTwoVariable
        '
        Me.rdoTwoVariable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTwoVariable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoVariable.FlatAppearance.BorderSize = 2
        Me.rdoTwoVariable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTwoVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTwoVariable.Location = New System.Drawing.Point(137, 8)
        Me.rdoTwoVariable.Name = "rdoTwoVariable"
        Me.rdoTwoVariable.Size = New System.Drawing.Size(100, 28)
        Me.rdoTwoVariable.TabIndex = 24
        Me.rdoTwoVariable.Text = "Two Variables"
        Me.rdoTwoVariable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTwoVariable.UseVisualStyleBackColor = True
        '
        'ucrReceiverFirstVars
        '
        Me.ucrReceiverFirstVars.AutoSize = True
        Me.ucrReceiverFirstVars.frmParent = Me
        Me.ucrReceiverFirstVars.Location = New System.Drawing.Point(264, 73)
        Me.ucrReceiverFirstVars.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstVars.Name = "ucrReceiverFirstVars"
        Me.ucrReceiverFirstVars.Selector = Nothing
        Me.ucrReceiverFirstVars.Size = New System.Drawing.Size(120, 79)
        Me.ucrReceiverFirstVars.strNcFilePath = ""
        Me.ucrReceiverFirstVars.TabIndex = 30
        Me.ucrReceiverFirstVars.ucrSelector = Nothing
        '
        'dlgDescribeTwoVariable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(419, 491)
        Me.Controls.Add(Me.grpThreeVariablePercentages)
        Me.Controls.Add(Me.cmdFormatTable)
        Me.Controls.Add(Me.lblThreeVariableSecondFactor)
        Me.Controls.Add(Me.ucrReceiverThreeVariableSecondFactor)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverThreeVariableThirdVariable)
        Me.Controls.Add(Me.ucrReceiverSecondSkimrGroupByFactor)
        Me.Controls.Add(Me.ucrReceiverSkimrGroupByFactor)
        Me.Controls.Add(Me.ucrReceiverSecondTwoVariableFactor)
        Me.Controls.Add(Me.ucrSelectorDescribeTwoVar)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.lbSecondVariable)
        Me.Controls.Add(Me.lblFirstVariable)
        Me.Controls.Add(Me.grpFrequency)
        Me.Controls.Add(Me.grpSummaries)
        Me.Controls.Add(Me.lblFirstGroupByFactor)
        Me.Controls.Add(Me.lblThirdVariable)
        Me.Controls.Add(Me.lblSecondGroupByFactor)
        Me.Controls.Add(Me.grpTwoVariablePercentages)
        Me.Controls.Add(Me.ucrReceiverFirstVars)
        Me.Controls.Add(Me.rdoThreeVariable)
        Me.Controls.Add(Me.rdoTwoVariable)
        Me.Controls.Add(Me.rdoSkim)
        Me.Controls.Add(Me.ucrPnlDescribe)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescribeTwoVariable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Describe_Two_Variable"
        Me.Text = "Describe Two Variables"
        Me.grpThreeVariablePercentages.ResumeLayout(False)
        Me.grpThreeVariablePercentages.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.grpFrequency.ResumeLayout(False)
        Me.grpFrequency.PerformLayout()
        Me.grpSummaries.ResumeLayout(False)
        Me.grpSummaries.PerformLayout()
        Me.grpTwoVariablePercentages.ResumeLayout(False)
        Me.grpTwoVariablePercentages.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrNudColumnFactors As ucrNud
    Friend WithEvents ucrReceiverPercentages As ucrReceiverSingle
    Friend WithEvents grpThreeVariablePercentages As GroupBox
    Friend WithEvents ucrReceiverThreeVariablePercentage As ucrReceiverSingle
    Friend WithEvents lblThreeVariableFactorAsPercentages As Label
    Friend WithEvents ucrChkThreeVariablePercentageProportion As ucrCheck
    Friend WithEvents ucrChkThreeVariableDisplayAsPercentage As ucrCheck
    Friend WithEvents cmdFormatTable As Button
    Friend WithEvents lblThreeVariableSecondFactor As Label
    Friend WithEvents ucrReceiverThreeVariableSecondFactor As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverThreeVariableThirdVariable As ucrReceiverSingle
    Friend WithEvents ucrReceiverSecondSkimrGroupByFactor As ucrReceiverSingle
    Friend WithEvents ucrReceiverSkimrGroupByFactor As ucrReceiverSingle
    Friend WithEvents ucrReceiverSecondTwoVariableFactor As ucrReceiverSingle
    Friend WithEvents ucrSelectorDescribeTwoVar As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents ucrChkOmitMissing As ucrCheck
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents lbSecondVariable As Label
    Friend WithEvents lblFirstVariable As Label
    Friend WithEvents grpFrequency As GroupBox
    Friend WithEvents lblColumnFactors As Label
    Friend WithEvents ucrNudSigFigs As ucrNud
    Friend WithEvents ucrInputMarginName As ucrInputTextBox
    Friend WithEvents lblMarginName As Label
    Friend WithEvents lblSigFigs As Label
    Friend WithEvents ucrChkDisplayMargins As ucrCheck
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
    Friend WithEvents grpTwoVariablePercentages As GroupBox
    Friend WithEvents lblFactorsAsPercentage As Label
    Friend WithEvents ucrChkPercentageProportion As ucrCheck
    Friend WithEvents ucrChkDisplayAsPercentage As ucrCheck
    Friend WithEvents ucrReceiverFirstVars As ucrReceiverMultiple
    Friend WithEvents rdoThreeVariable As RadioButton
    Friend WithEvents rdoTwoVariable As RadioButton
    Friend WithEvents rdoSkim As RadioButton
    Friend WithEvents ucrPnlDescribe As UcrPanel
End Class
