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
Partial Class dlgTransform
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
        Me.components = New System.ComponentModel.Container()
        Me.lblSelectColumns = New System.Windows.Forms.Label()
        Me.grpTies = New System.Windows.Forms.GroupBox()
        Me.rdoRandom = New System.Windows.Forms.RadioButton()
        Me.rdoFirst = New System.Windows.Forms.RadioButton()
        Me.rdoMaximum = New System.Windows.Forms.RadioButton()
        Me.rdoMinimum = New System.Windows.Forms.RadioButton()
        Me.rdoAverage = New System.Windows.Forms.RadioButton()
        Me.ucrPnlTies = New instat.UcrPanel()
        Me.grpMissingValues = New System.Windows.Forms.GroupBox()
        Me.rdoLast = New System.Windows.Forms.RadioButton()
        Me.rdoFirstMissingValues = New System.Windows.Forms.RadioButton()
        Me.rdoKeptAsMissing = New System.Windows.Forms.RadioButton()
        Me.ucrPnlMissingValues = New instat.UcrPanel()
        Me.rdoRoundOf = New System.Windows.Forms.RadioButton()
        Me.rdoSignificantDigits = New System.Windows.Forms.RadioButton()
        Me.rdoStandardize = New System.Windows.Forms.RadioButton()
        Me.rdoDifference = New System.Windows.Forms.RadioButton()
        Me.rdoLead = New System.Windows.Forms.RadioButton()
        Me.rdoLag = New System.Windows.Forms.RadioButton()
        Me.grpNumericOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkOmitNA = New instat.ucrCheck()
        Me.ucrNudLagPosition = New instat.ucrNud()
        Me.lblLagPosition = New System.Windows.Forms.Label()
        Me.lblRoundofDigits = New System.Windows.Forms.Label()
        Me.ucrNudRoundOfDigits = New instat.ucrNud()
        Me.ucrNudDiffLag = New instat.ucrNud()
        Me.ucrNudLagLeadPosition = New instat.ucrNud()
        Me.ucrNudSignifDigits = New instat.ucrNud()
        Me.lblDiffLag = New System.Windows.Forms.Label()
        Me.lblDigits = New System.Windows.Forms.Label()
        Me.lblLagLeadPosition = New System.Windows.Forms.Label()
        Me.ucrPnlNumericOptions = New instat.UcrPanel()
        Me.grpNonNegative = New System.Windows.Forms.GroupBox()
        Me.ucrInputPower = New instat.ucrInputComboBox()
        Me.rdoPower = New System.Windows.Forms.RadioButton()
        Me.ucrInputConstant = New instat.ucrInputComboBox()
        Me.rdoSquareRoot = New System.Windows.Forms.RadioButton()
        Me.rdoNaturalLog = New System.Windows.Forms.RadioButton()
        Me.rdoLogToBase10 = New System.Windows.Forms.RadioButton()
        Me.ucrChkAddConstant = New instat.ucrCheck()
        Me.ucrPnlNonNegative = New instat.UcrPanel()
        Me.rdoNumeric = New System.Windows.Forms.RadioButton()
        Me.rdoNonNegative = New System.Windows.Forms.RadioButton()
        Me.rdoRank = New System.Windows.Forms.RadioButton()
        Me.rdoSort = New System.Windows.Forms.RadioButton()
        Me.rdoScale = New System.Windows.Forms.RadioButton()
        Me.ttEditPreview = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdUpdatePreview = New System.Windows.Forms.Button()
        Me.ucrChkEditPreview = New instat.ucrCheck()
        Me.ucrChkPreview = New instat.ucrCheck()
        Me.ucrInputPreview = New instat.ucrInputTextBox()
        Me.ucrInputAdd = New instat.ucrInputComboBox()
        Me.ucrInputDivide = New instat.ucrInputComboBox()
        Me.ucrInputMultiply = New instat.ucrInputComboBox()
        Me.ucrInputSubtract = New instat.ucrInputComboBox()
        Me.ucrChkAdd = New instat.ucrCheck()
        Me.ucrChkDivide = New instat.ucrCheck()
        Me.ucrChkMultiply = New instat.ucrCheck()
        Me.ucrChkSubtract = New instat.ucrCheck()
        Me.ucrPnlTransformOptions = New instat.UcrPanel()
        Me.ucrSaveNew = New instat.ucrSave()
        Me.ucrReceiverRank = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorForRank = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkMissingLast = New instat.ucrCheck()
        Me.ucrChkDecreasing = New instat.ucrCheck()
        Me.grpTies.SuspendLayout()
        Me.grpMissingValues.SuspendLayout()
        Me.grpNumericOptions.SuspendLayout()
        Me.grpNonNegative.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectColumns
        '
        Me.lblSelectColumns.AutoSize = True
        Me.lblSelectColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectColumns.Location = New System.Drawing.Point(246, 84)
        Me.lblSelectColumns.Name = "lblSelectColumns"
        Me.lblSelectColumns.Size = New System.Drawing.Size(45, 13)
        Me.lblSelectColumns.TabIndex = 7
        Me.lblSelectColumns.Tag = ""
        Me.lblSelectColumns.Text = "Column:"
        '
        'grpTies
        '
        Me.grpTies.Controls.Add(Me.rdoRandom)
        Me.grpTies.Controls.Add(Me.rdoFirst)
        Me.grpTies.Controls.Add(Me.rdoMaximum)
        Me.grpTies.Controls.Add(Me.rdoMinimum)
        Me.grpTies.Controls.Add(Me.rdoAverage)
        Me.grpTies.Controls.Add(Me.ucrPnlTies)
        Me.grpTies.Location = New System.Drawing.Point(238, 128)
        Me.grpTies.Name = "grpTies"
        Me.grpTies.Size = New System.Drawing.Size(120, 135)
        Me.grpTies.TabIndex = 3
        Me.grpTies.TabStop = False
        Me.grpTies.Tag = "Ties"
        Me.grpTies.Text = "Ties"
        '
        'rdoRandom
        '
        Me.rdoRandom.AutoSize = True
        Me.rdoRandom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRandom.Location = New System.Drawing.Point(13, 111)
        Me.rdoRandom.Name = "rdoRandom"
        Me.rdoRandom.Size = New System.Drawing.Size(65, 17)
        Me.rdoRandom.TabIndex = 5
        Me.rdoRandom.TabStop = True
        Me.rdoRandom.Tag = "Random"
        Me.rdoRandom.Text = "Random"
        Me.rdoRandom.UseVisualStyleBackColor = True
        '
        'rdoFirst
        '
        Me.rdoFirst.AutoSize = True
        Me.rdoFirst.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoFirst.Location = New System.Drawing.Point(13, 88)
        Me.rdoFirst.Name = "rdoFirst"
        Me.rdoFirst.Size = New System.Drawing.Size(44, 17)
        Me.rdoFirst.TabIndex = 4
        Me.rdoFirst.TabStop = True
        Me.rdoFirst.Tag = "First"
        Me.rdoFirst.Text = "First"
        Me.rdoFirst.UseVisualStyleBackColor = True
        '
        'rdoMaximum
        '
        Me.rdoMaximum.AutoSize = True
        Me.rdoMaximum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMaximum.Location = New System.Drawing.Point(13, 65)
        Me.rdoMaximum.Name = "rdoMaximum"
        Me.rdoMaximum.Size = New System.Drawing.Size(69, 17)
        Me.rdoMaximum.TabIndex = 3
        Me.rdoMaximum.TabStop = True
        Me.rdoMaximum.Tag = "Maximum"
        Me.rdoMaximum.Text = "Maximum"
        Me.rdoMaximum.UseVisualStyleBackColor = True
        '
        'rdoMinimum
        '
        Me.rdoMinimum.AutoSize = True
        Me.rdoMinimum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMinimum.Location = New System.Drawing.Point(13, 42)
        Me.rdoMinimum.Name = "rdoMinimum"
        Me.rdoMinimum.Size = New System.Drawing.Size(66, 17)
        Me.rdoMinimum.TabIndex = 2
        Me.rdoMinimum.TabStop = True
        Me.rdoMinimum.Tag = "Minimum"
        Me.rdoMinimum.Text = "Minimum"
        Me.rdoMinimum.UseVisualStyleBackColor = True
        '
        'rdoAverage
        '
        Me.rdoAverage.AutoSize = True
        Me.rdoAverage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAverage.Location = New System.Drawing.Point(13, 19)
        Me.rdoAverage.Name = "rdoAverage"
        Me.rdoAverage.Size = New System.Drawing.Size(65, 17)
        Me.rdoAverage.TabIndex = 1
        Me.rdoAverage.TabStop = True
        Me.rdoAverage.Tag = "Average"
        Me.rdoAverage.Text = "Average"
        Me.rdoAverage.UseVisualStyleBackColor = True
        '
        'ucrPnlTies
        '
        Me.ucrPnlTies.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlTies.Location = New System.Drawing.Point(7, 14)
        Me.ucrPnlTies.Name = "ucrPnlTies"
        Me.ucrPnlTies.Size = New System.Drawing.Size(96, 114)
        Me.ucrPnlTies.TabIndex = 0
        '
        'grpMissingValues
        '
        Me.grpMissingValues.Controls.Add(Me.rdoLast)
        Me.grpMissingValues.Controls.Add(Me.rdoFirstMissingValues)
        Me.grpMissingValues.Controls.Add(Me.rdoKeptAsMissing)
        Me.grpMissingValues.Controls.Add(Me.ucrPnlMissingValues)
        Me.grpMissingValues.Location = New System.Drawing.Point(10, 251)
        Me.grpMissingValues.Name = "grpMissingValues"
        Me.grpMissingValues.Size = New System.Drawing.Size(210, 85)
        Me.grpMissingValues.TabIndex = 12
        Me.grpMissingValues.TabStop = False
        Me.grpMissingValues.Tag = "Misssing_Values"
        Me.grpMissingValues.Text = "Missing Values"
        '
        'rdoLast
        '
        Me.rdoLast.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLast.Location = New System.Drawing.Point(12, 64)
        Me.rdoLast.Name = "rdoLast"
        Me.rdoLast.Size = New System.Drawing.Size(96, 17)
        Me.rdoLast.TabIndex = 3
        Me.rdoLast.TabStop = True
        Me.rdoLast.Tag = "Last"
        Me.rdoLast.Text = "Last"
        Me.rdoLast.UseVisualStyleBackColor = True
        '
        'rdoFirstMissingValues
        '
        Me.rdoFirstMissingValues.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoFirstMissingValues.Location = New System.Drawing.Point(12, 41)
        Me.rdoFirstMissingValues.Name = "rdoFirstMissingValues"
        Me.rdoFirstMissingValues.Size = New System.Drawing.Size(110, 17)
        Me.rdoFirstMissingValues.TabIndex = 2
        Me.rdoFirstMissingValues.TabStop = True
        Me.rdoFirstMissingValues.Tag = "First"
        Me.rdoFirstMissingValues.Text = "First"
        Me.rdoFirstMissingValues.UseVisualStyleBackColor = True
        '
        'rdoKeptAsMissing
        '
        Me.rdoKeptAsMissing.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoKeptAsMissing.Location = New System.Drawing.Point(12, 18)
        Me.rdoKeptAsMissing.Name = "rdoKeptAsMissing"
        Me.rdoKeptAsMissing.Size = New System.Drawing.Size(126, 17)
        Me.rdoKeptAsMissing.TabIndex = 1
        Me.rdoKeptAsMissing.TabStop = True
        Me.rdoKeptAsMissing.Tag = "Kept_as_missing"
        Me.rdoKeptAsMissing.Text = "Keep as Missing"
        Me.rdoKeptAsMissing.UseVisualStyleBackColor = True
        '
        'ucrPnlMissingValues
        '
        Me.ucrPnlMissingValues.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMissingValues.Location = New System.Drawing.Point(6, 18)
        Me.ucrPnlMissingValues.Name = "ucrPnlMissingValues"
        Me.ucrPnlMissingValues.Size = New System.Drawing.Size(143, 64)
        Me.ucrPnlMissingValues.TabIndex = 0
        '
        'rdoRoundOf
        '
        Me.rdoRoundOf.AutoSize = True
        Me.rdoRoundOf.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRoundOf.Location = New System.Drawing.Point(11, 19)
        Me.rdoRoundOf.Name = "rdoRoundOf"
        Me.rdoRoundOf.Size = New System.Drawing.Size(57, 17)
        Me.rdoRoundOf.TabIndex = 14
        Me.rdoRoundOf.TabStop = True
        Me.rdoRoundOf.Text = "Round"
        Me.rdoRoundOf.UseVisualStyleBackColor = True
        '
        'rdoSignificantDigits
        '
        Me.rdoSignificantDigits.AutoSize = True
        Me.rdoSignificantDigits.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSignificantDigits.Location = New System.Drawing.Point(11, 47)
        Me.rdoSignificantDigits.Name = "rdoSignificantDigits"
        Me.rdoSignificantDigits.Size = New System.Drawing.Size(68, 17)
        Me.rdoSignificantDigits.TabIndex = 15
        Me.rdoSignificantDigits.TabStop = True
        Me.rdoSignificantDigits.Text = "Signif Fig"
        Me.rdoSignificantDigits.UseVisualStyleBackColor = True
        '
        'rdoStandardize
        '
        Me.rdoStandardize.AutoSize = True
        Me.rdoStandardize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoStandardize.Location = New System.Drawing.Point(11, 75)
        Me.rdoStandardize.Name = "rdoStandardize"
        Me.rdoStandardize.Size = New System.Drawing.Size(81, 17)
        Me.rdoStandardize.TabIndex = 17
        Me.rdoStandardize.TabStop = True
        Me.rdoStandardize.Text = "Standardize"
        Me.rdoStandardize.UseVisualStyleBackColor = True
        '
        'rdoDifference
        '
        Me.rdoDifference.AutoSize = True
        Me.rdoDifference.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDifference.Location = New System.Drawing.Point(11, 159)
        Me.rdoDifference.Name = "rdoDifference"
        Me.rdoDifference.Size = New System.Drawing.Size(74, 17)
        Me.rdoDifference.TabIndex = 18
        Me.rdoDifference.TabStop = True
        Me.rdoDifference.Text = "Difference"
        Me.rdoDifference.UseVisualStyleBackColor = True
        '
        'rdoLead
        '
        Me.rdoLead.AutoSize = True
        Me.rdoLead.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLead.Location = New System.Drawing.Point(11, 131)
        Me.rdoLead.Name = "rdoLead"
        Me.rdoLead.Size = New System.Drawing.Size(49, 17)
        Me.rdoLead.TabIndex = 19
        Me.rdoLead.TabStop = True
        Me.rdoLead.Text = "Lead"
        Me.rdoLead.UseVisualStyleBackColor = True
        '
        'rdoLag
        '
        Me.rdoLag.AutoSize = True
        Me.rdoLag.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLag.Location = New System.Drawing.Point(11, 103)
        Me.rdoLag.Name = "rdoLag"
        Me.rdoLag.Size = New System.Drawing.Size(43, 17)
        Me.rdoLag.TabIndex = 20
        Me.rdoLag.TabStop = True
        Me.rdoLag.Text = "Lag"
        Me.rdoLag.UseVisualStyleBackColor = True
        '
        'grpNumericOptions
        '
        Me.grpNumericOptions.Controls.Add(Me.ucrChkOmitNA)
        Me.grpNumericOptions.Controls.Add(Me.rdoDifference)
        Me.grpNumericOptions.Controls.Add(Me.ucrNudLagPosition)
        Me.grpNumericOptions.Controls.Add(Me.lblLagPosition)
        Me.grpNumericOptions.Controls.Add(Me.rdoLead)
        Me.grpNumericOptions.Controls.Add(Me.rdoLag)
        Me.grpNumericOptions.Controls.Add(Me.rdoSignificantDigits)
        Me.grpNumericOptions.Controls.Add(Me.rdoRoundOf)
        Me.grpNumericOptions.Controls.Add(Me.rdoStandardize)
        Me.grpNumericOptions.Controls.Add(Me.lblRoundofDigits)
        Me.grpNumericOptions.Controls.Add(Me.ucrNudRoundOfDigits)
        Me.grpNumericOptions.Controls.Add(Me.ucrNudDiffLag)
        Me.grpNumericOptions.Controls.Add(Me.ucrNudLagLeadPosition)
        Me.grpNumericOptions.Controls.Add(Me.ucrNudSignifDigits)
        Me.grpNumericOptions.Controls.Add(Me.lblDiffLag)
        Me.grpNumericOptions.Controls.Add(Me.lblDigits)
        Me.grpNumericOptions.Controls.Add(Me.lblLagLeadPosition)
        Me.grpNumericOptions.Controls.Add(Me.ucrPnlNumericOptions)
        Me.grpNumericOptions.Location = New System.Drawing.Point(233, 128)
        Me.grpNumericOptions.Name = "grpNumericOptions"
        Me.grpNumericOptions.Size = New System.Drawing.Size(200, 199)
        Me.grpNumericOptions.TabIndex = 11
        Me.grpNumericOptions.TabStop = False
        Me.grpNumericOptions.Text = "Options"
        '
        'ucrChkOmitNA
        '
        Me.ucrChkOmitNA.AutoSize = True
        Me.ucrChkOmitNA.Checked = False
        Me.ucrChkOmitNA.Location = New System.Drawing.Point(109, 75)
        Me.ucrChkOmitNA.Name = "ucrChkOmitNA"
        Me.ucrChkOmitNA.Size = New System.Drawing.Size(75, 23)
        Me.ucrChkOmitNA.TabIndex = 33
        '
        'ucrNudLagPosition
        '
        Me.ucrNudLagPosition.AutoSize = True
        Me.ucrNudLagPosition.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLagPosition.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLagPosition.Location = New System.Drawing.Point(138, 101)
        Me.ucrNudLagPosition.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLagPosition.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLagPosition.Name = "ucrNudLagPosition"
        Me.ucrNudLagPosition.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLagPosition.TabIndex = 25
        Me.ucrNudLagPosition.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblLagPosition
        '
        Me.lblLagPosition.AutoSize = True
        Me.lblLagPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLagPosition.Location = New System.Drawing.Point(83, 105)
        Me.lblLagPosition.Name = "lblLagPosition"
        Me.lblLagPosition.Size = New System.Drawing.Size(52, 13)
        Me.lblLagPosition.TabIndex = 24
        Me.lblLagPosition.Text = "Positions:"
        '
        'lblRoundofDigits
        '
        Me.lblRoundofDigits.AutoSize = True
        Me.lblRoundofDigits.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRoundofDigits.Location = New System.Drawing.Point(82, 21)
        Me.lblRoundofDigits.Name = "lblRoundofDigits"
        Me.lblRoundofDigits.Size = New System.Drawing.Size(53, 13)
        Me.lblRoundofDigits.TabIndex = 23
        Me.lblRoundofDigits.Text = "Decimals:"
        '
        'ucrNudRoundOfDigits
        '
        Me.ucrNudRoundOfDigits.AutoSize = True
        Me.ucrNudRoundOfDigits.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRoundOfDigits.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRoundOfDigits.Location = New System.Drawing.Point(138, 17)
        Me.ucrNudRoundOfDigits.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRoundOfDigits.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRoundOfDigits.Name = "ucrNudRoundOfDigits"
        Me.ucrNudRoundOfDigits.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudRoundOfDigits.TabIndex = 22
        Me.ucrNudRoundOfDigits.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDiffLag
        '
        Me.ucrNudDiffLag.AutoSize = True
        Me.ucrNudDiffLag.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDiffLag.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDiffLag.Location = New System.Drawing.Point(138, 157)
        Me.ucrNudDiffLag.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDiffLag.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDiffLag.Name = "ucrNudDiffLag"
        Me.ucrNudDiffLag.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDiffLag.TabIndex = 19
        Me.ucrNudDiffLag.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLagLeadPosition
        '
        Me.ucrNudLagLeadPosition.AutoSize = True
        Me.ucrNudLagLeadPosition.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLagLeadPosition.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLagLeadPosition.Location = New System.Drawing.Point(138, 129)
        Me.ucrNudLagLeadPosition.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLagLeadPosition.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLagLeadPosition.Name = "ucrNudLagLeadPosition"
        Me.ucrNudLagLeadPosition.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLagLeadPosition.TabIndex = 16
        Me.ucrNudLagLeadPosition.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSignifDigits
        '
        Me.ucrNudSignifDigits.AutoSize = True
        Me.ucrNudSignifDigits.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSignifDigits.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSignifDigits.Location = New System.Drawing.Point(138, 45)
        Me.ucrNudSignifDigits.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSignifDigits.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSignifDigits.Name = "ucrNudSignifDigits"
        Me.ucrNudSignifDigits.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSignifDigits.TabIndex = 14
        Me.ucrNudSignifDigits.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblDiffLag
        '
        Me.lblDiffLag.AutoSize = True
        Me.lblDiffLag.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDiffLag.Location = New System.Drawing.Point(107, 161)
        Me.lblDiffLag.Name = "lblDiffLag"
        Me.lblDiffLag.Size = New System.Drawing.Size(28, 13)
        Me.lblDiffLag.TabIndex = 18
        Me.lblDiffLag.Text = "Lag:"
        '
        'lblDigits
        '
        Me.lblDigits.AutoSize = True
        Me.lblDigits.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDigits.Location = New System.Drawing.Point(99, 48)
        Me.lblDigits.Name = "lblDigits"
        Me.lblDigits.Size = New System.Drawing.Size(36, 13)
        Me.lblDigits.TabIndex = 15
        Me.lblDigits.Text = "Digits:"
        '
        'lblLagLeadPosition
        '
        Me.lblLagLeadPosition.AutoSize = True
        Me.lblLagLeadPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLagLeadPosition.Location = New System.Drawing.Point(83, 133)
        Me.lblLagLeadPosition.Name = "lblLagLeadPosition"
        Me.lblLagLeadPosition.Size = New System.Drawing.Size(52, 13)
        Me.lblLagLeadPosition.TabIndex = 17
        Me.lblLagLeadPosition.Text = "Positions:"
        '
        'ucrPnlNumericOptions
        '
        Me.ucrPnlNumericOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlNumericOptions.Location = New System.Drawing.Point(6, 19)
        Me.ucrPnlNumericOptions.Name = "ucrPnlNumericOptions"
        Me.ucrPnlNumericOptions.Size = New System.Drawing.Size(79, 174)
        Me.ucrPnlNumericOptions.TabIndex = 0
        '
        'grpNonNegative
        '
        Me.grpNonNegative.Controls.Add(Me.ucrInputPower)
        Me.grpNonNegative.Controls.Add(Me.rdoPower)
        Me.grpNonNegative.Controls.Add(Me.ucrInputConstant)
        Me.grpNonNegative.Controls.Add(Me.rdoSquareRoot)
        Me.grpNonNegative.Controls.Add(Me.rdoNaturalLog)
        Me.grpNonNegative.Controls.Add(Me.rdoLogToBase10)
        Me.grpNonNegative.Controls.Add(Me.ucrChkAddConstant)
        Me.grpNonNegative.Controls.Add(Me.ucrPnlNonNegative)
        Me.grpNonNegative.Location = New System.Drawing.Point(238, 128)
        Me.grpNonNegative.Name = "grpNonNegative"
        Me.grpNonNegative.Size = New System.Drawing.Size(195, 149)
        Me.grpNonNegative.TabIndex = 9
        Me.grpNonNegative.TabStop = False
        Me.grpNonNegative.Text = "Options"
        '
        'ucrInputPower
        '
        Me.ucrInputPower.AddQuotesIfUnrecognised = True
        Me.ucrInputPower.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPower.GetSetSelectedIndex = -1
        Me.ucrInputPower.IsReadOnly = False
        Me.ucrInputPower.Location = New System.Drawing.Point(126, 86)
        Me.ucrInputPower.Name = "ucrInputPower"
        Me.ucrInputPower.Size = New System.Drawing.Size(57, 21)
        Me.ucrInputPower.TabIndex = 29
        '
        'rdoPower
        '
        Me.rdoPower.AutoSize = True
        Me.rdoPower.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPower.Location = New System.Drawing.Point(12, 88)
        Me.rdoPower.Name = "rdoPower"
        Me.rdoPower.Size = New System.Drawing.Size(55, 17)
        Me.rdoPower.TabIndex = 18
        Me.rdoPower.TabStop = True
        Me.rdoPower.Text = "Power"
        Me.rdoPower.UseVisualStyleBackColor = True
        '
        'ucrInputConstant
        '
        Me.ucrInputConstant.AddQuotesIfUnrecognised = True
        Me.ucrInputConstant.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputConstant.GetSetSelectedIndex = -1
        Me.ucrInputConstant.IsReadOnly = False
        Me.ucrInputConstant.Location = New System.Drawing.Point(126, 114)
        Me.ucrInputConstant.Name = "ucrInputConstant"
        Me.ucrInputConstant.Size = New System.Drawing.Size(58, 21)
        Me.ucrInputConstant.TabIndex = 34
        '
        'rdoSquareRoot
        '
        Me.rdoSquareRoot.AutoSize = True
        Me.rdoSquareRoot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSquareRoot.Location = New System.Drawing.Point(13, 21)
        Me.rdoSquareRoot.Name = "rdoSquareRoot"
        Me.rdoSquareRoot.Size = New System.Drawing.Size(85, 17)
        Me.rdoSquareRoot.TabIndex = 15
        Me.rdoSquareRoot.TabStop = True
        Me.rdoSquareRoot.Text = "Square Root"
        Me.rdoSquareRoot.UseVisualStyleBackColor = True
        '
        'rdoNaturalLog
        '
        Me.rdoNaturalLog.AutoSize = True
        Me.rdoNaturalLog.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNaturalLog.Location = New System.Drawing.Point(12, 43)
        Me.rdoNaturalLog.Name = "rdoNaturalLog"
        Me.rdoNaturalLog.Size = New System.Drawing.Size(86, 17)
        Me.rdoNaturalLog.TabIndex = 16
        Me.rdoNaturalLog.TabStop = True
        Me.rdoNaturalLog.Text = "Log (Natural)"
        Me.rdoNaturalLog.UseVisualStyleBackColor = True
        '
        'rdoLogToBase10
        '
        Me.rdoLogToBase10.AutoSize = True
        Me.rdoLogToBase10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLogToBase10.Location = New System.Drawing.Point(12, 65)
        Me.rdoLogToBase10.Name = "rdoLogToBase10"
        Me.rdoLogToBase10.Size = New System.Drawing.Size(91, 17)
        Me.rdoLogToBase10.TabIndex = 17
        Me.rdoLogToBase10.TabStop = True
        Me.rdoLogToBase10.Text = "Log (Base 10)"
        Me.rdoLogToBase10.UseVisualStyleBackColor = True
        '
        'ucrChkAddConstant
        '
        Me.ucrChkAddConstant.AutoSize = True
        Me.ucrChkAddConstant.Checked = False
        Me.ucrChkAddConstant.Location = New System.Drawing.Point(13, 116)
        Me.ucrChkAddConstant.Name = "ucrChkAddConstant"
        Me.ucrChkAddConstant.Size = New System.Drawing.Size(107, 23)
        Me.ucrChkAddConstant.TabIndex = 30
        '
        'ucrPnlNonNegative
        '
        Me.ucrPnlNonNegative.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlNonNegative.Location = New System.Drawing.Point(6, 14)
        Me.ucrPnlNonNegative.Name = "ucrPnlNonNegative"
        Me.ucrPnlNonNegative.Size = New System.Drawing.Size(92, 100)
        Me.ucrPnlNonNegative.TabIndex = 19
        '
        'rdoNumeric
        '
        Me.rdoNumeric.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoNumeric.BackColor = System.Drawing.SystemColors.Control
        Me.rdoNumeric.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoNumeric.FlatAppearance.BorderSize = 2
        Me.rdoNumeric.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoNumeric.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoNumeric.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNumeric.Location = New System.Drawing.Point(13, 13)
        Me.rdoNumeric.Name = "rdoNumeric"
        Me.rdoNumeric.Size = New System.Drawing.Size(82, 28)
        Me.rdoNumeric.TabIndex = 1
        Me.rdoNumeric.TabStop = True
        Me.rdoNumeric.Tag = "Frequency"
        Me.rdoNumeric.Text = "Numeric"
        Me.rdoNumeric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoNumeric.UseVisualStyleBackColor = False
        '
        'rdoNonNegative
        '
        Me.rdoNonNegative.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoNonNegative.BackColor = System.Drawing.SystemColors.Control
        Me.rdoNonNegative.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoNonNegative.FlatAppearance.BorderSize = 2
        Me.rdoNonNegative.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoNonNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoNonNegative.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNonNegative.Location = New System.Drawing.Point(94, 13)
        Me.rdoNonNegative.Name = "rdoNonNegative"
        Me.rdoNonNegative.Size = New System.Drawing.Size(85, 28)
        Me.rdoNonNegative.TabIndex = 2
        Me.rdoNonNegative.TabStop = True
        Me.rdoNonNegative.Tag = "Frequency"
        Me.rdoNonNegative.Text = "Non-Negative"
        Me.rdoNonNegative.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoNonNegative.UseVisualStyleBackColor = False
        '
        'rdoRank
        '
        Me.rdoRank.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRank.BackColor = System.Drawing.SystemColors.Control
        Me.rdoRank.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRank.FlatAppearance.BorderSize = 2
        Me.rdoRank.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRank.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRank.Location = New System.Drawing.Point(178, 13)
        Me.rdoRank.Name = "rdoRank"
        Me.rdoRank.Size = New System.Drawing.Size(82, 28)
        Me.rdoRank.TabIndex = 3
        Me.rdoRank.TabStop = True
        Me.rdoRank.Tag = "Frequency"
        Me.rdoRank.Text = "Rank"
        Me.rdoRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRank.UseVisualStyleBackColor = False
        '
        'rdoSort
        '
        Me.rdoSort.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSort.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSort.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSort.FlatAppearance.BorderSize = 2
        Me.rdoSort.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSort.Location = New System.Drawing.Point(259, 13)
        Me.rdoSort.Name = "rdoSort"
        Me.rdoSort.Size = New System.Drawing.Size(82, 28)
        Me.rdoSort.TabIndex = 4
        Me.rdoSort.TabStop = True
        Me.rdoSort.Tag = "Frequency"
        Me.rdoSort.Text = "Sort"
        Me.rdoSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSort.UseVisualStyleBackColor = False
        '
        'rdoScale
        '
        Me.rdoScale.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoScale.BackColor = System.Drawing.SystemColors.Control
        Me.rdoScale.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoScale.FlatAppearance.BorderSize = 2
        Me.rdoScale.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoScale.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoScale.Location = New System.Drawing.Point(340, 13)
        Me.rdoScale.Name = "rdoScale"
        Me.rdoScale.Size = New System.Drawing.Size(82, 28)
        Me.rdoScale.TabIndex = 5
        Me.rdoScale.TabStop = True
        Me.rdoScale.Tag = "Frequency"
        Me.rdoScale.Text = "Scale"
        Me.rdoScale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoScale.UseVisualStyleBackColor = False
        '
        'cmdUpdatePreview
        '
        Me.cmdUpdatePreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdUpdatePreview.Location = New System.Drawing.Point(283, 340)
        Me.cmdUpdatePreview.Name = "cmdUpdatePreview"
        Me.cmdUpdatePreview.Size = New System.Drawing.Size(75, 23)
        Me.cmdUpdatePreview.TabIndex = 34
        Me.cmdUpdatePreview.Text = "Update"
        Me.cmdUpdatePreview.UseVisualStyleBackColor = True
        '
        'ucrChkEditPreview
        '
        Me.ucrChkEditPreview.AutoSize = True
        Me.ucrChkEditPreview.Checked = False
        Me.ucrChkEditPreview.Location = New System.Drawing.Point(363, 343)
        Me.ucrChkEditPreview.Name = "ucrChkEditPreview"
        Me.ucrChkEditPreview.Size = New System.Drawing.Size(66, 23)
        Me.ucrChkEditPreview.TabIndex = 33
        '
        'ucrChkPreview
        '
        Me.ucrChkPreview.AutoSize = True
        Me.ucrChkPreview.Checked = False
        Me.ucrChkPreview.Location = New System.Drawing.Point(11, 343)
        Me.ucrChkPreview.Name = "ucrChkPreview"
        Me.ucrChkPreview.Size = New System.Drawing.Size(69, 23)
        Me.ucrChkPreview.TabIndex = 32
        '
        'ucrInputPreview
        '
        Me.ucrInputPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputPreview.AutoSize = True
        Me.ucrInputPreview.IsMultiline = False
        Me.ucrInputPreview.IsReadOnly = True
        Me.ucrInputPreview.Location = New System.Drawing.Point(82, 342)
        Me.ucrInputPreview.Name = "ucrInputPreview"
        Me.ucrInputPreview.Size = New System.Drawing.Size(199, 21)
        Me.ucrInputPreview.TabIndex = 14
        '
        'ucrInputAdd
        '
        Me.ucrInputAdd.AddQuotesIfUnrecognised = True
        Me.ucrInputAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputAdd.GetSetSelectedIndex = -1
        Me.ucrInputAdd.IsReadOnly = False
        Me.ucrInputAdd.Location = New System.Drawing.Point(329, 207)
        Me.ucrInputAdd.Name = "ucrInputAdd"
        Me.ucrInputAdd.Size = New System.Drawing.Size(75, 21)
        Me.ucrInputAdd.TabIndex = 28
        '
        'ucrInputDivide
        '
        Me.ucrInputDivide.AddQuotesIfUnrecognised = True
        Me.ucrInputDivide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDivide.GetSetSelectedIndex = -1
        Me.ucrInputDivide.IsReadOnly = False
        Me.ucrInputDivide.Location = New System.Drawing.Point(329, 180)
        Me.ucrInputDivide.Name = "ucrInputDivide"
        Me.ucrInputDivide.Size = New System.Drawing.Size(75, 21)
        Me.ucrInputDivide.TabIndex = 27
        '
        'ucrInputMultiply
        '
        Me.ucrInputMultiply.AddQuotesIfUnrecognised = True
        Me.ucrInputMultiply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputMultiply.GetSetSelectedIndex = -1
        Me.ucrInputMultiply.IsReadOnly = False
        Me.ucrInputMultiply.Location = New System.Drawing.Point(329, 153)
        Me.ucrInputMultiply.Name = "ucrInputMultiply"
        Me.ucrInputMultiply.Size = New System.Drawing.Size(75, 21)
        Me.ucrInputMultiply.TabIndex = 26
        '
        'ucrInputSubtract
        '
        Me.ucrInputSubtract.AddQuotesIfUnrecognised = True
        Me.ucrInputSubtract.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSubtract.GetSetSelectedIndex = -1
        Me.ucrInputSubtract.IsReadOnly = False
        Me.ucrInputSubtract.Location = New System.Drawing.Point(329, 126)
        Me.ucrInputSubtract.Name = "ucrInputSubtract"
        Me.ucrInputSubtract.Size = New System.Drawing.Size(75, 21)
        Me.ucrInputSubtract.TabIndex = 25
        '
        'ucrChkAdd
        '
        Me.ucrChkAdd.AutoSize = True
        Me.ucrChkAdd.Checked = False
        Me.ucrChkAdd.Location = New System.Drawing.Point(244, 206)
        Me.ucrChkAdd.Name = "ucrChkAdd"
        Me.ucrChkAdd.Size = New System.Drawing.Size(79, 23)
        Me.ucrChkAdd.TabIndex = 24
        '
        'ucrChkDivide
        '
        Me.ucrChkDivide.AutoSize = True
        Me.ucrChkDivide.Checked = False
        Me.ucrChkDivide.Location = New System.Drawing.Point(244, 180)
        Me.ucrChkDivide.Name = "ucrChkDivide"
        Me.ucrChkDivide.Size = New System.Drawing.Size(79, 23)
        Me.ucrChkDivide.TabIndex = 23
        '
        'ucrChkMultiply
        '
        Me.ucrChkMultiply.AutoSize = True
        Me.ucrChkMultiply.Checked = False
        Me.ucrChkMultiply.Location = New System.Drawing.Point(244, 154)
        Me.ucrChkMultiply.Name = "ucrChkMultiply"
        Me.ucrChkMultiply.Size = New System.Drawing.Size(79, 23)
        Me.ucrChkMultiply.TabIndex = 22
        '
        'ucrChkSubtract
        '
        Me.ucrChkSubtract.AutoSize = True
        Me.ucrChkSubtract.Checked = False
        Me.ucrChkSubtract.Location = New System.Drawing.Point(244, 128)
        Me.ucrChkSubtract.Name = "ucrChkSubtract"
        Me.ucrChkSubtract.Size = New System.Drawing.Size(79, 23)
        Me.ucrChkSubtract.TabIndex = 21
        '
        'ucrPnlTransformOptions
        '
        Me.ucrPnlTransformOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlTransformOptions.Location = New System.Drawing.Point(10, 8)
        Me.ucrPnlTransformOptions.Name = "ucrPnlTransformOptions"
        Me.ucrPnlTransformOptions.Size = New System.Drawing.Size(423, 45)
        Me.ucrPnlTransformOptions.TabIndex = 0
        '
        'ucrSaveNew
        '
        Me.ucrSaveNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveNew.Location = New System.Drawing.Point(10, 368)
        Me.ucrSaveNew.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveNew.Name = "ucrSaveNew"
        Me.ucrSaveNew.Size = New System.Drawing.Size(271, 22)
        Me.ucrSaveNew.TabIndex = 15
        '
        'ucrReceiverRank
        '
        Me.ucrReceiverRank.AutoSize = True
        Me.ucrReceiverRank.frmParent = Me
        Me.ucrReceiverRank.Location = New System.Drawing.Point(244, 100)
        Me.ucrReceiverRank.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRank.Name = "ucrReceiverRank"
        Me.ucrReceiverRank.Selector = Nothing
        Me.ucrReceiverRank.Size = New System.Drawing.Size(145, 20)
        Me.ucrReceiverRank.strNcFilePath = ""
        Me.ucrReceiverRank.TabIndex = 8
        Me.ucrReceiverRank.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 392)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 16
        '
        'ucrSelectorForRank
        '
        Me.ucrSelectorForRank.AutoSize = True
        Me.ucrSelectorForRank.bDropUnusedFilterLevels = False
        Me.ucrSelectorForRank.bShowHiddenColumns = False
        Me.ucrSelectorForRank.bUseCurrentFilter = True
        Me.ucrSelectorForRank.Location = New System.Drawing.Point(10, 68)
        Me.ucrSelectorForRank.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForRank.Name = "ucrSelectorForRank"
        Me.ucrSelectorForRank.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForRank.TabIndex = 6
        '
        'ucrChkMissingLast
        '
        Me.ucrChkMissingLast.AutoSize = True
        Me.ucrChkMissingLast.Checked = False
        Me.ucrChkMissingLast.Location = New System.Drawing.Point(244, 154)
        Me.ucrChkMissingLast.Name = "ucrChkMissingLast"
        Me.ucrChkMissingLast.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkMissingLast.TabIndex = 13
        '
        'ucrChkDecreasing
        '
        Me.ucrChkDecreasing.AutoSize = True
        Me.ucrChkDecreasing.Checked = False
        Me.ucrChkDecreasing.Location = New System.Drawing.Point(244, 128)
        Me.ucrChkDecreasing.Name = "ucrChkDecreasing"
        Me.ucrChkDecreasing.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkDecreasing.TabIndex = 12
        '
        'dlgTransform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(440, 445)
        Me.Controls.Add(Me.cmdUpdatePreview)
        Me.Controls.Add(Me.grpNonNegative)
        Me.Controls.Add(Me.ucrChkEditPreview)
        Me.Controls.Add(Me.ucrChkPreview)
        Me.Controls.Add(Me.ucrInputPreview)
        Me.Controls.Add(Me.ucrInputAdd)
        Me.Controls.Add(Me.ucrInputDivide)
        Me.Controls.Add(Me.ucrInputMultiply)
        Me.Controls.Add(Me.ucrInputSubtract)
        Me.Controls.Add(Me.ucrChkAdd)
        Me.Controls.Add(Me.ucrChkDivide)
        Me.Controls.Add(Me.ucrChkMultiply)
        Me.Controls.Add(Me.ucrChkSubtract)
        Me.Controls.Add(Me.rdoScale)
        Me.Controls.Add(Me.rdoSort)
        Me.Controls.Add(Me.rdoRank)
        Me.Controls.Add(Me.rdoNonNegative)
        Me.Controls.Add(Me.rdoNumeric)
        Me.Controls.Add(Me.grpMissingValues)
        Me.Controls.Add(Me.ucrPnlTransformOptions)
        Me.Controls.Add(Me.ucrSaveNew)
        Me.Controls.Add(Me.lblSelectColumns)
        Me.Controls.Add(Me.ucrReceiverRank)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorForRank)
        Me.Controls.Add(Me.ucrChkMissingLast)
        Me.Controls.Add(Me.ucrChkDecreasing)
        Me.Controls.Add(Me.grpNumericOptions)
        Me.Controls.Add(Me.grpTies)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTransform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Transform"
        Me.Text = "Transform"
        Me.grpTies.ResumeLayout(False)
        Me.grpTies.PerformLayout()
        Me.grpMissingValues.ResumeLayout(False)
        Me.grpNumericOptions.ResumeLayout(False)
        Me.grpNumericOptions.PerformLayout()
        Me.grpNonNegative.ResumeLayout(False)
        Me.grpNonNegative.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverRank As ucrReceiverSingle
    Friend WithEvents lblSelectColumns As Label
    Friend WithEvents grpMissingValues As GroupBox
    Friend WithEvents rdoKeptAsMissing As RadioButton
    Friend WithEvents rdoLast As RadioButton
    Friend WithEvents rdoFirstMissingValues As RadioButton
    Friend WithEvents ucrSelectorForRank As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpTies As GroupBox
    Friend WithEvents rdoRandom As RadioButton
    Friend WithEvents rdoFirst As RadioButton
    Friend WithEvents rdoMaximum As RadioButton
    Friend WithEvents rdoMinimum As RadioButton
    Friend WithEvents rdoAverage As RadioButton
    Friend WithEvents ucrPnlTies As UcrPanel
    Friend WithEvents ucrPnlMissingValues As UcrPanel
    Friend WithEvents ucrSaveNew As ucrSave
    Friend WithEvents ucrPnlTransformOptions As UcrPanel
    Friend WithEvents ucrChkMissingLast As ucrCheck
    Friend WithEvents ucrChkDecreasing As ucrCheck
    Friend WithEvents rdoSignificantDigits As RadioButton
    Friend WithEvents rdoRoundOf As RadioButton
    Friend WithEvents ucrPnlNumericOptions As UcrPanel
    Friend WithEvents grpNumericOptions As GroupBox
    Friend WithEvents rdoLead As RadioButton
    Friend WithEvents rdoDifference As RadioButton
    Friend WithEvents rdoLag As RadioButton
    Friend WithEvents rdoStandardize As RadioButton
    Friend WithEvents lblDigits As Label
    Friend WithEvents ucrNudSignifDigits As ucrNud
    Friend WithEvents lblLagLeadPosition As Label
    Friend WithEvents ucrNudLagLeadPosition As ucrNud
    Friend WithEvents ucrNudDiffLag As ucrNud
    Friend WithEvents lblDiffLag As Label
    Friend WithEvents lblRoundofDigits As Label
    Friend WithEvents ucrNudRoundOfDigits As ucrNud
    Friend WithEvents rdoNonNegative As RadioButton
    Friend WithEvents rdoNumeric As RadioButton
    Friend WithEvents rdoSort As RadioButton
    Friend WithEvents rdoRank As RadioButton
    Friend WithEvents ucrNudLagPosition As ucrNud
    Friend WithEvents lblLagPosition As Label
    Friend WithEvents grpNonNegative As GroupBox
    Friend WithEvents rdoPower As RadioButton
    Friend WithEvents rdoSquareRoot As RadioButton
    Friend WithEvents rdoNaturalLog As RadioButton
    Friend WithEvents rdoLogToBase10 As RadioButton
    Friend WithEvents ucrPnlNonNegative As UcrPanel
    Friend WithEvents rdoScale As RadioButton
    Friend WithEvents ucrChkAdd As ucrCheck
    Friend WithEvents ucrChkDivide As ucrCheck
    Friend WithEvents ucrChkMultiply As ucrCheck
    Friend WithEvents ucrChkSubtract As ucrCheck
    Friend WithEvents ucrInputAdd As ucrInputComboBox
    Friend WithEvents ucrInputDivide As ucrInputComboBox
    Friend WithEvents ucrInputMultiply As ucrInputComboBox
    Friend WithEvents ucrInputSubtract As ucrInputComboBox
    Friend WithEvents ucrChkAddConstant As ucrCheck
    Friend WithEvents ucrInputPreview As ucrInputTextBox
    Friend WithEvents ucrChkPreview As ucrCheck
    Friend WithEvents ucrChkOmitNA As ucrCheck
    Friend WithEvents ucrChkEditPreview As ucrCheck
    Friend WithEvents ttEditPreview As ToolTip
    Friend WithEvents ucrInputConstant As ucrInputComboBox
    Friend WithEvents ucrInputPower As ucrInputComboBox
    Friend WithEvents cmdUpdatePreview As Button
End Class
