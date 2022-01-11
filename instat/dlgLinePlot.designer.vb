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
Partial Class dlgLinePlot
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
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.cmdLinePathStepSmoothOptions = New System.Windows.Forms.Button()
        Me.lblFactorOptional = New System.Windows.Forms.Label()
        Me.lblGroupLine = New System.Windows.Forms.Label()
        Me.rdoPath = New System.Windows.Forms.RadioButton()
        Me.rdoStep = New System.Windows.Forms.RadioButton()
        Me.rdoLine = New System.Windows.Forms.RadioButton()
        Me.rdoSmoothing = New System.Windows.Forms.RadioButton()
        Me.lblMethod = New System.Windows.Forms.Label()
        Me.lblFamily = New System.Windows.Forms.Label()
        Me.grpSmoothOptions = New System.Windows.Forms.GroupBox()
        Me.ucrInputFormula = New instat.ucrInputComboBox()
        Me.ucrChkSpan = New instat.ucrCheck()
        Me.ucrChkFormula = New instat.ucrCheck()
        Me.ucrChkAddSE = New instat.ucrCheck()
        Me.ucrNudSpan = New instat.ucrNud()
        Me.ucrFamilyInput = New instat.ucrInputComboBox()
        Me.ucrInputMethod = New instat.ucrInputComboBox()
        Me.rdoSlope = New System.Windows.Forms.RadioButton()
        Me.rdoDumbbell = New System.Windows.Forms.RadioButton()
        Me.lblXEnd = New System.Windows.Forms.Label()
        Me.lblSlopeY = New System.Windows.Forms.Label()
        Me.lblSlopeX = New System.Windows.Forms.Label()
        Me.lblSlopeColour = New System.Windows.Forms.Label()
        Me.lblXColour = New System.Windows.Forms.Label()
        Me.lblLineSize = New System.Windows.Forms.Label()
        Me.lblXEndSize = New System.Windows.Forms.Label()
        Me.lblXSize = New System.Windows.Forms.Label()
        Me.lblLineColour = New System.Windows.Forms.Label()
        Me.lblXEndColour = New System.Windows.Forms.Label()
        Me.lblSlopeLabelSize = New System.Windows.Forms.Label()
        Me.lblSlopeLabelPadding = New System.Windows.Forms.Label()
        Me.lblSopeTextColour = New System.Windows.Forms.Label()
        Me.lblSlopeTextSize = New System.Windows.Forms.Label()
        Me.lblSlopeYTextSize = New System.Windows.Forms.Label()
        Me.lblSlopeLabelColour = New System.Windows.Forms.Label()
        Me.lblSlopeLineColour = New System.Windows.Forms.Label()
        Me.lblSlopeLineTicknes = New System.Windows.Forms.Label()
        Me.ucrChkSlopeLegend = New instat.ucrCheck()
        Me.ucrNudSlopeLabelPadding = New instat.ucrNud()
        Me.ucrNudSlopeLineThickness = New instat.ucrNud()
        Me.ucrInputSlopeLineColour = New instat.ucrInputComboBox()
        Me.ucrInputSlopeTextColour = New instat.ucrInputComboBox()
        Me.ucrInputSlopeLabelColour = New instat.ucrInputComboBox()
        Me.ucrNudSlopeTextSize = New instat.ucrNud()
        Me.ucrNudSlopeLabelSize = New instat.ucrNud()
        Me.ucrChkSlopeLabelOptions = New instat.ucrCheck()
        Me.ucrChkSlopeTextOptions = New instat.ucrCheck()
        Me.ucrInputDumbbellLine = New instat.ucrInputComboBox()
        Me.ucrInputDumbbellXEnd = New instat.ucrInputComboBox()
        Me.ucrInputDumbbellX = New instat.ucrInputComboBox()
        Me.ucrNudDumbbellLine = New instat.ucrNud()
        Me.ucrNudDumbbellXEnd = New instat.ucrNud()
        Me.ucrNudDumbbellX = New instat.ucrNud()
        Me.ucrChkDumbbellColour = New instat.ucrCheck()
        Me.ucrChkDumbbellSize = New instat.ucrCheck()
        Me.ucrReceiverGroup = New instat.ucrReceiverSingle()
        Me.ucrReceiverSlopeY = New instat.ucrReceiverSingle()
        Me.ucrChkAddLine = New instat.ucrCheck()
        Me.ucrChkAddPoints = New instat.ucrCheck()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrPnlStepOrPath = New instat.UcrPanel()
        Me.ucrChkPathOrStep = New instat.ucrCheck()
        Me.ucrChkValley = New instat.ucrCheck()
        Me.ucrChkPeak = New instat.ucrCheck()
        Me.ucrChkWithSE = New instat.ucrCheck()
        Me.ucrChkLineofBestFit = New instat.ucrCheck()
        Me.ucrSave = New instat.ucrSave()
        Me.ucrVariablesAsFactorForLinePlot = New instat.ucrVariablesAsFactor()
        Me.ucrLinePlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverXEnd = New instat.ucrReceiverSingle()
        Me.ucrReceiverSlopeX = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrReceiverSlopeColour = New instat.ucrReceiverSingle()
        Me.ucrFactorOptionalReceiver = New instat.ucrReceiverSingle()
        Me.ucrChkSlopeLineOptions = New instat.ucrCheck()
        Me.UcrNudSlopeYTextSize = New instat.ucrNud()
        Me.grpSmoothOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXVariable.Location = New System.Drawing.Point(249, 229)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(58, 13)
        Me.lblXVariable.TabIndex = 13
        Me.lblXVariable.Tag = "X_Variable:"
        Me.lblXVariable.Text = "X Variable:"
        '
        'lblAvailable
        '
        Me.lblAvailable.AutoSize = True
        Me.lblAvailable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAvailable.Location = New System.Drawing.Point(27, 15)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(0, 13)
        Me.lblAvailable.TabIndex = 1
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(10, 282)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(148, 23)
        Me.cmdOptions.TabIndex = 22
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'cmdLinePathStepSmoothOptions
        '
        Me.cmdLinePathStepSmoothOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLinePathStepSmoothOptions.Location = New System.Drawing.Point(9, 251)
        Me.cmdLinePathStepSmoothOptions.Name = "cmdLinePathStepSmoothOptions"
        Me.cmdLinePathStepSmoothOptions.Size = New System.Drawing.Size(148, 23)
        Me.cmdLinePathStepSmoothOptions.TabIndex = 21
        Me.cmdLinePathStepSmoothOptions.Tag = "Line_Options"
        Me.cmdLinePathStepSmoothOptions.Text = "Line Options"
        Me.cmdLinePathStepSmoothOptions.UseVisualStyleBackColor = True
        '
        'lblFactorOptional
        '
        Me.lblFactorOptional.AutoSize = True
        Me.lblFactorOptional.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactorOptional.Location = New System.Drawing.Point(249, 273)
        Me.lblFactorOptional.Name = "lblFactorOptional"
        Me.lblFactorOptional.Size = New System.Drawing.Size(88, 13)
        Me.lblFactorOptional.TabIndex = 15
        Me.lblFactorOptional.Tag = "Factor_Optional:"
        Me.lblFactorOptional.Text = "Factor (Optional):"
        '
        'lblGroupLine
        '
        Me.lblGroupLine.AutoSize = True
        Me.lblGroupLine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroupLine.Location = New System.Drawing.Point(249, 314)
        Me.lblGroupLine.Name = "lblGroupLine"
        Me.lblGroupLine.Size = New System.Drawing.Size(39, 13)
        Me.lblGroupLine.TabIndex = 19
        Me.lblGroupLine.Text = "Group:"
        '
        'rdoPath
        '
        Me.rdoPath.AutoSize = True
        Me.rdoPath.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPath.Location = New System.Drawing.Point(154, 417)
        Me.rdoPath.Name = "rdoPath"
        Me.rdoPath.Size = New System.Drawing.Size(47, 17)
        Me.rdoPath.TabIndex = 29
        Me.rdoPath.TabStop = True
        Me.rdoPath.Text = "Path"
        Me.rdoPath.UseVisualStyleBackColor = True
        '
        'rdoStep
        '
        Me.rdoStep.AutoSize = True
        Me.rdoStep.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoStep.Location = New System.Drawing.Point(215, 417)
        Me.rdoStep.Name = "rdoStep"
        Me.rdoStep.Size = New System.Drawing.Size(47, 17)
        Me.rdoStep.TabIndex = 30
        Me.rdoStep.TabStop = True
        Me.rdoStep.Text = "Step"
        Me.rdoStep.UseVisualStyleBackColor = True
        '
        'rdoLine
        '
        Me.rdoLine.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoLine.BackColor = System.Drawing.SystemColors.Control
        Me.rdoLine.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLine.FlatAppearance.BorderSize = 2
        Me.rdoLine.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoLine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLine.Location = New System.Drawing.Point(37, 15)
        Me.rdoLine.Name = "rdoLine"
        Me.rdoLine.Size = New System.Drawing.Size(84, 28)
        Me.rdoLine.TabIndex = 2
        Me.rdoLine.TabStop = True
        Me.rdoLine.Tag = "linepathstep"
        Me.rdoLine.Text = "Line"
        Me.rdoLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoLine.UseVisualStyleBackColor = False
        '
        'rdoSmoothing
        '
        Me.rdoSmoothing.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSmoothing.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSmoothing.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSmoothing.FlatAppearance.BorderSize = 2
        Me.rdoSmoothing.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSmoothing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSmoothing.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSmoothing.Location = New System.Drawing.Point(119, 15)
        Me.rdoSmoothing.Name = "rdoSmoothing"
        Me.rdoSmoothing.Size = New System.Drawing.Size(84, 28)
        Me.rdoSmoothing.TabIndex = 3
        Me.rdoSmoothing.TabStop = True
        Me.rdoSmoothing.Tag = "Smooth"
        Me.rdoSmoothing.Text = "Smooth"
        Me.rdoSmoothing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSmoothing.UseVisualStyleBackColor = False
        '
        'lblMethod
        '
        Me.lblMethod.AutoSize = True
        Me.lblMethod.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMethod.Location = New System.Drawing.Point(2, 23)
        Me.lblMethod.Name = "lblMethod"
        Me.lblMethod.Size = New System.Drawing.Size(46, 13)
        Me.lblMethod.TabIndex = 0
        Me.lblMethod.Text = "Method:"
        '
        'lblFamily
        '
        Me.lblFamily.AutoSize = True
        Me.lblFamily.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFamily.Location = New System.Drawing.Point(167, 23)
        Me.lblFamily.Name = "lblFamily"
        Me.lblFamily.Size = New System.Drawing.Size(39, 13)
        Me.lblFamily.TabIndex = 2
        Me.lblFamily.Text = "Family:"
        '
        'grpSmoothOptions
        '
        Me.grpSmoothOptions.Controls.Add(Me.ucrInputFormula)
        Me.grpSmoothOptions.Controls.Add(Me.ucrChkSpan)
        Me.grpSmoothOptions.Controls.Add(Me.ucrChkFormula)
        Me.grpSmoothOptions.Controls.Add(Me.ucrChkAddSE)
        Me.grpSmoothOptions.Controls.Add(Me.ucrNudSpan)
        Me.grpSmoothOptions.Controls.Add(Me.lblFamily)
        Me.grpSmoothOptions.Controls.Add(Me.ucrFamilyInput)
        Me.grpSmoothOptions.Controls.Add(Me.ucrInputMethod)
        Me.grpSmoothOptions.Controls.Add(Me.lblMethod)
        Me.grpSmoothOptions.Location = New System.Drawing.Point(8, 360)
        Me.grpSmoothOptions.Name = "grpSmoothOptions"
        Me.grpSmoothOptions.Size = New System.Drawing.Size(402, 77)
        Me.grpSmoothOptions.TabIndex = 25
        Me.grpSmoothOptions.TabStop = False
        Me.grpSmoothOptions.Text = "Smooth Options"
        '
        'ucrInputFormula
        '
        Me.ucrInputFormula.AddQuotesIfUnrecognised = True
        Me.ucrInputFormula.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFormula.GetSetSelectedIndex = -1
        Me.ucrInputFormula.IsReadOnly = False
        Me.ucrInputFormula.Location = New System.Drawing.Point(73, 46)
        Me.ucrInputFormula.Name = "ucrInputFormula"
        Me.ucrInputFormula.Size = New System.Drawing.Size(110, 23)
        Me.ucrInputFormula.TabIndex = 7
        '
        'ucrChkSpan
        '
        Me.ucrChkSpan.AutoSize = True
        Me.ucrChkSpan.Checked = False
        Me.ucrChkSpan.Location = New System.Drawing.Point(185, 20)
        Me.ucrChkSpan.Name = "ucrChkSpan"
        Me.ucrChkSpan.Size = New System.Drawing.Size(54, 23)
        Me.ucrChkSpan.TabIndex = 3
        '
        'ucrChkFormula
        '
        Me.ucrChkFormula.AutoSize = True
        Me.ucrChkFormula.Checked = False
        Me.ucrChkFormula.Location = New System.Drawing.Point(5, 49)
        Me.ucrChkFormula.Name = "ucrChkFormula"
        Me.ucrChkFormula.Size = New System.Drawing.Size(66, 23)
        Me.ucrChkFormula.TabIndex = 6
        '
        'ucrChkAddSE
        '
        Me.ucrChkAddSE.AutoSize = True
        Me.ucrChkAddSE.Checked = False
        Me.ucrChkAddSE.Location = New System.Drawing.Point(183, 49)
        Me.ucrChkAddSE.Name = "ucrChkAddSE"
        Me.ucrChkAddSE.Size = New System.Drawing.Size(75, 23)
        Me.ucrChkAddSE.TabIndex = 8
        '
        'ucrNudSpan
        '
        Me.ucrNudSpan.AutoSize = True
        Me.ucrNudSpan.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSpan.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSpan.Location = New System.Drawing.Point(239, 20)
        Me.ucrNudSpan.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSpan.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSpan.Name = "ucrNudSpan"
        Me.ucrNudSpan.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSpan.TabIndex = 5
        Me.ucrNudSpan.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrFamilyInput
        '
        Me.ucrFamilyInput.AddQuotesIfUnrecognised = True
        Me.ucrFamilyInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrFamilyInput.GetSetSelectedIndex = -1
        Me.ucrFamilyInput.IsReadOnly = False
        Me.ucrFamilyInput.Location = New System.Drawing.Point(210, 20)
        Me.ucrFamilyInput.Name = "ucrFamilyInput"
        Me.ucrFamilyInput.Size = New System.Drawing.Size(110, 24)
        Me.ucrFamilyInput.TabIndex = 4
        '
        'ucrInputMethod
        '
        Me.ucrInputMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputMethod.GetSetSelectedIndex = -1
        Me.ucrInputMethod.IsReadOnly = False
        Me.ucrInputMethod.Location = New System.Drawing.Point(52, 20)
        Me.ucrInputMethod.Name = "ucrInputMethod"
        Me.ucrInputMethod.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputMethod.TabIndex = 1
        '
        'rdoSlope
        '
        Me.rdoSlope.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSlope.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSlope.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSlope.FlatAppearance.BorderSize = 2
        Me.rdoSlope.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSlope.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSlope.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSlope.Location = New System.Drawing.Point(283, 15)
        Me.rdoSlope.Name = "rdoSlope"
        Me.rdoSlope.Size = New System.Drawing.Size(84, 28)
        Me.rdoSlope.TabIndex = 5
        Me.rdoSlope.TabStop = True
        Me.rdoSlope.Tag = "Slope"
        Me.rdoSlope.Text = "Slope"
        Me.rdoSlope.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSlope.UseVisualStyleBackColor = False
        '
        'rdoDumbbell
        '
        Me.rdoDumbbell.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDumbbell.BackColor = System.Drawing.SystemColors.Control
        Me.rdoDumbbell.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDumbbell.FlatAppearance.BorderSize = 2
        Me.rdoDumbbell.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDumbbell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDumbbell.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDumbbell.Location = New System.Drawing.Point(201, 15)
        Me.rdoDumbbell.Name = "rdoDumbbell"
        Me.rdoDumbbell.Size = New System.Drawing.Size(84, 28)
        Me.rdoDumbbell.TabIndex = 4
        Me.rdoDumbbell.TabStop = True
        Me.rdoDumbbell.Tag = "linepathstep"
        Me.rdoDumbbell.Text = "Dumbbell"
        Me.rdoDumbbell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDumbbell.UseVisualStyleBackColor = False
        '
        'lblXEnd
        '
        Me.lblXEnd.AutoSize = True
        Me.lblXEnd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXEnd.Location = New System.Drawing.Point(252, 275)
        Me.lblXEnd.Name = "lblXEnd"
        Me.lblXEnd.Size = New System.Drawing.Size(80, 13)
        Me.lblXEnd.TabIndex = 16
        Me.lblXEnd.Tag = "XEnd_Variable:"
        Me.lblXEnd.Text = "X End Variable:"
        '
        'lblSlopeY
        '
        Me.lblSlopeY.AutoSize = True
        Me.lblSlopeY.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSlopeY.Location = New System.Drawing.Point(249, 94)
        Me.lblSlopeY.Name = "lblSlopeY"
        Me.lblSlopeY.Size = New System.Drawing.Size(58, 13)
        Me.lblSlopeY.TabIndex = 9
        Me.lblSlopeY.Tag = "Y_Slope_Variable:"
        Me.lblSlopeY.Text = "Y Variable:"
        '
        'lblSlopeX
        '
        Me.lblSlopeX.AutoSize = True
        Me.lblSlopeX.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSlopeX.Location = New System.Drawing.Point(247, 229)
        Me.lblSlopeX.Name = "lblSlopeX"
        Me.lblSlopeX.Size = New System.Drawing.Size(58, 13)
        Me.lblSlopeX.TabIndex = 11
        Me.lblSlopeX.Tag = "X_Slope_Variable:"
        Me.lblSlopeX.Text = "X Variable:"
        '
        'lblSlopeColour
        '
        Me.lblSlopeColour.AutoSize = True
        Me.lblSlopeColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSlopeColour.Location = New System.Drawing.Point(250, 273)
        Me.lblSlopeColour.Name = "lblSlopeColour"
        Me.lblSlopeColour.Size = New System.Drawing.Size(40, 13)
        Me.lblSlopeColour.TabIndex = 42
        Me.lblSlopeColour.Tag = "Colour"
        Me.lblSlopeColour.Text = "Colour:"
        '
        'lblXColour
        '
        Me.lblXColour.AutoSize = True
        Me.lblXColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXColour.Location = New System.Drawing.Point(93, 322)
        Me.lblXColour.Name = "lblXColour"
        Me.lblXColour.Size = New System.Drawing.Size(17, 13)
        Me.lblXColour.TabIndex = 9
        Me.lblXColour.Text = "X:"
        '
        'lblLineSize
        '
        Me.lblLineSize.AutoSize = True
        Me.lblLineSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineSize.Location = New System.Drawing.Point(308, 358)
        Me.lblLineSize.Name = "lblLineSize"
        Me.lblLineSize.Size = New System.Drawing.Size(30, 13)
        Me.lblLineSize.TabIndex = 50
        Me.lblLineSize.Text = "Line:"
        '
        'lblXEndSize
        '
        Me.lblXEndSize.AutoSize = True
        Me.lblXEndSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXEndSize.Location = New System.Drawing.Point(188, 355)
        Me.lblXEndSize.Name = "lblXEndSize"
        Me.lblXEndSize.Size = New System.Drawing.Size(39, 13)
        Me.lblXEndSize.TabIndex = 51
        Me.lblXEndSize.Text = "X End:"
        '
        'lblXSize
        '
        Me.lblXSize.AutoSize = True
        Me.lblXSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXSize.Location = New System.Drawing.Point(94, 358)
        Me.lblXSize.Name = "lblXSize"
        Me.lblXSize.Size = New System.Drawing.Size(17, 13)
        Me.lblXSize.TabIndex = 52
        Me.lblXSize.Text = "X:"
        '
        'lblLineColour
        '
        Me.lblLineColour.AutoSize = True
        Me.lblLineColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLineColour.Location = New System.Drawing.Point(308, 322)
        Me.lblLineColour.Name = "lblLineColour"
        Me.lblLineColour.Size = New System.Drawing.Size(30, 13)
        Me.lblLineColour.TabIndex = 53
        Me.lblLineColour.Text = "Line:"
        '
        'lblXEndColour
        '
        Me.lblXEndColour.AutoSize = True
        Me.lblXEndColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXEndColour.Location = New System.Drawing.Point(189, 322)
        Me.lblXEndColour.Name = "lblXEndColour"
        Me.lblXEndColour.Size = New System.Drawing.Size(39, 13)
        Me.lblXEndColour.TabIndex = 54
        Me.lblXEndColour.Text = "X End:"
        '
        'lblSlopeLabelSize
        '
        Me.lblSlopeLabelSize.AutoSize = True
        Me.lblSlopeLabelSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSlopeLabelSize.Location = New System.Drawing.Point(216, 321)
        Me.lblSlopeLabelSize.Name = "lblSlopeLabelSize"
        Me.lblSlopeLabelSize.Size = New System.Drawing.Size(30, 13)
        Me.lblSlopeLabelSize.TabIndex = 68
        Me.lblSlopeLabelSize.Text = "Size:"
        '
        'lblSlopeLabelPadding
        '
        Me.lblSlopeLabelPadding.AutoSize = True
        Me.lblSlopeLabelPadding.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSlopeLabelPadding.Location = New System.Drawing.Point(296, 321)
        Me.lblSlopeLabelPadding.Name = "lblSlopeLabelPadding"
        Me.lblSlopeLabelPadding.Size = New System.Drawing.Size(49, 13)
        Me.lblSlopeLabelPadding.TabIndex = 67
        Me.lblSlopeLabelPadding.Text = "Padding:"
        '
        'lblSopeTextColour
        '
        Me.lblSopeTextColour.AutoSize = True
        Me.lblSopeTextColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSopeTextColour.Location = New System.Drawing.Point(91, 352)
        Me.lblSopeTextColour.Name = "lblSopeTextColour"
        Me.lblSopeTextColour.Size = New System.Drawing.Size(40, 13)
        Me.lblSopeTextColour.TabIndex = 66
        Me.lblSopeTextColour.Text = "Colour:"
        '
        'lblSlopeTextSize
        '
        Me.lblSlopeTextSize.AutoSize = True
        Me.lblSlopeTextSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSlopeTextSize.Location = New System.Drawing.Point(213, 351)
        Me.lblSlopeTextSize.Name = "lblSlopeTextSize"
        Me.lblSlopeTextSize.Size = New System.Drawing.Size(30, 13)
        Me.lblSlopeTextSize.TabIndex = 65
        Me.lblSlopeTextSize.Text = "Size:"
        '
        'lblSlopeYTextSize
        '
        Me.lblSlopeYTextSize.AutoSize = True
        Me.lblSlopeYTextSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSlopeYTextSize.Location = New System.Drawing.Point(286, 354)
        Me.lblSlopeYTextSize.Name = "lblSlopeYTextSize"
        Me.lblSlopeYTextSize.Size = New System.Drawing.Size(61, 13)
        Me.lblSlopeYTextSize.TabIndex = 64
        Me.lblSlopeYTextSize.Text = "Y TextSize:"
        '
        'lblSlopeLabelColour
        '
        Me.lblSlopeLabelColour.AutoSize = True
        Me.lblSlopeLabelColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSlopeLabelColour.Location = New System.Drawing.Point(92, 324)
        Me.lblSlopeLabelColour.Name = "lblSlopeLabelColour"
        Me.lblSlopeLabelColour.Size = New System.Drawing.Size(40, 13)
        Me.lblSlopeLabelColour.TabIndex = 55
        Me.lblSlopeLabelColour.Text = "Colour:"
        '
        'lblSlopeLineColour
        '
        Me.lblSlopeLineColour.AutoSize = True
        Me.lblSlopeLineColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSlopeLineColour.Location = New System.Drawing.Point(93, 380)
        Me.lblSlopeLineColour.Name = "lblSlopeLineColour"
        Me.lblSlopeLineColour.Size = New System.Drawing.Size(40, 13)
        Me.lblSlopeLineColour.TabIndex = 70
        Me.lblSlopeLineColour.Text = "Colour:"
        '
        'lblSlopeLineTicknes
        '
        Me.lblSlopeLineTicknes.AutoSize = True
        Me.lblSlopeLineTicknes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSlopeLineTicknes.Location = New System.Drawing.Point(191, 381)
        Me.lblSlopeLineTicknes.Name = "lblSlopeLineTicknes"
        Me.lblSlopeLineTicknes.Size = New System.Drawing.Size(54, 13)
        Me.lblSlopeLineTicknes.TabIndex = 72
        Me.lblSlopeLineTicknes.Text = "Thicknes:"
        '
        'ucrChkSlopeLegend
        '
        Me.ucrChkSlopeLegend.AutoSize = True
        Me.ucrChkSlopeLegend.Checked = False
        Me.ucrChkSlopeLegend.Location = New System.Drawing.Point(9, 292)
        Me.ucrChkSlopeLegend.Name = "ucrChkSlopeLegend"
        Me.ucrChkSlopeLegend.Size = New System.Drawing.Size(80, 24)
        Me.ucrChkSlopeLegend.TabIndex = 74
        '
        'ucrNudSlopeLabelPadding
        '
        Me.ucrNudSlopeLabelPadding.AutoSize = True
        Me.ucrNudSlopeLabelPadding.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSlopeLabelPadding.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSlopeLabelPadding.Location = New System.Drawing.Point(347, 319)
        Me.ucrNudSlopeLabelPadding.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSlopeLabelPadding.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSlopeLabelPadding.Name = "ucrNudSlopeLabelPadding"
        Me.ucrNudSlopeLabelPadding.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSlopeLabelPadding.TabIndex = 73
        Me.ucrNudSlopeLabelPadding.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSlopeLineThickness
        '
        Me.ucrNudSlopeLineThickness.AutoSize = True
        Me.ucrNudSlopeLineThickness.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSlopeLineThickness.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSlopeLineThickness.Location = New System.Drawing.Point(246, 381)
        Me.ucrNudSlopeLineThickness.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSlopeLineThickness.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSlopeLineThickness.Name = "ucrNudSlopeLineThickness"
        Me.ucrNudSlopeLineThickness.Size = New System.Drawing.Size(44, 20)
        Me.ucrNudSlopeLineThickness.TabIndex = 71
        Me.ucrNudSlopeLineThickness.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputSlopeLineColour
        '
        Me.ucrInputSlopeLineColour.AddQuotesIfUnrecognised = True
        Me.ucrInputSlopeLineColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSlopeLineColour.GetSetSelectedIndex = -1
        Me.ucrInputSlopeLineColour.IsReadOnly = False
        Me.ucrInputSlopeLineColour.Location = New System.Drawing.Point(134, 377)
        Me.ucrInputSlopeLineColour.Name = "ucrInputSlopeLineColour"
        Me.ucrInputSlopeLineColour.Size = New System.Drawing.Size(55, 21)
        Me.ucrInputSlopeLineColour.TabIndex = 63
        '
        'ucrInputSlopeTextColour
        '
        Me.ucrInputSlopeTextColour.AddQuotesIfUnrecognised = True
        Me.ucrInputSlopeTextColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSlopeTextColour.GetSetSelectedIndex = -1
        Me.ucrInputSlopeTextColour.IsReadOnly = False
        Me.ucrInputSlopeTextColour.Location = New System.Drawing.Point(134, 348)
        Me.ucrInputSlopeTextColour.Name = "ucrInputSlopeTextColour"
        Me.ucrInputSlopeTextColour.Size = New System.Drawing.Size(55, 21)
        Me.ucrInputSlopeTextColour.TabIndex = 62
        '
        'ucrInputSlopeLabelColour
        '
        Me.ucrInputSlopeLabelColour.AddQuotesIfUnrecognised = True
        Me.ucrInputSlopeLabelColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSlopeLabelColour.GetSetSelectedIndex = -1
        Me.ucrInputSlopeLabelColour.IsReadOnly = False
        Me.ucrInputSlopeLabelColour.Location = New System.Drawing.Point(134, 319)
        Me.ucrInputSlopeLabelColour.Name = "ucrInputSlopeLabelColour"
        Me.ucrInputSlopeLabelColour.Size = New System.Drawing.Size(55, 21)
        Me.ucrInputSlopeLabelColour.TabIndex = 56
        '
        'ucrNudSlopeTextSize
        '
        Me.ucrNudSlopeTextSize.AutoSize = True
        Me.ucrNudSlopeTextSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSlopeTextSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSlopeTextSize.Location = New System.Drawing.Point(247, 350)
        Me.ucrNudSlopeTextSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSlopeTextSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSlopeTextSize.Name = "ucrNudSlopeTextSize"
        Me.ucrNudSlopeTextSize.Size = New System.Drawing.Size(43, 20)
        Me.ucrNudSlopeTextSize.TabIndex = 60
        Me.ucrNudSlopeTextSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSlopeLabelSize
        '
        Me.ucrNudSlopeLabelSize.AutoSize = True
        Me.ucrNudSlopeLabelSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSlopeLabelSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSlopeLabelSize.Location = New System.Drawing.Point(246, 319)
        Me.ucrNudSlopeLabelSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSlopeLabelSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSlopeLabelSize.Name = "ucrNudSlopeLabelSize"
        Me.ucrNudSlopeLabelSize.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudSlopeLabelSize.TabIndex = 57
        Me.ucrNudSlopeLabelSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkSlopeLabelOptions
        '
        Me.ucrChkSlopeLabelOptions.AutoSize = True
        Me.ucrChkSlopeLabelOptions.Checked = False
        Me.ucrChkSlopeLabelOptions.Location = New System.Drawing.Point(10, 322)
        Me.ucrChkSlopeLabelOptions.Name = "ucrChkSlopeLabelOptions"
        Me.ucrChkSlopeLabelOptions.Size = New System.Drawing.Size(80, 24)
        Me.ucrChkSlopeLabelOptions.TabIndex = 59
        '
        'ucrChkSlopeTextOptions
        '
        Me.ucrChkSlopeTextOptions.AutoSize = True
        Me.ucrChkSlopeTextOptions.Checked = False
        Me.ucrChkSlopeTextOptions.Location = New System.Drawing.Point(10, 352)
        Me.ucrChkSlopeTextOptions.Name = "ucrChkSlopeTextOptions"
        Me.ucrChkSlopeTextOptions.Size = New System.Drawing.Size(80, 24)
        Me.ucrChkSlopeTextOptions.TabIndex = 58
        '
        'ucrInputDumbbellLine
        '
        Me.ucrInputDumbbellLine.AddQuotesIfUnrecognised = True
        Me.ucrInputDumbbellLine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDumbbellLine.GetSetSelectedIndex = -1
        Me.ucrInputDumbbellLine.IsReadOnly = False
        Me.ucrInputDumbbellLine.Location = New System.Drawing.Point(341, 318)
        Me.ucrInputDumbbellLine.Name = "ucrInputDumbbellLine"
        Me.ucrInputDumbbellLine.Size = New System.Drawing.Size(50, 21)
        Me.ucrInputDumbbellLine.TabIndex = 49
        '
        'ucrInputDumbbellXEnd
        '
        Me.ucrInputDumbbellXEnd.AddQuotesIfUnrecognised = True
        Me.ucrInputDumbbellXEnd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDumbbellXEnd.GetSetSelectedIndex = -1
        Me.ucrInputDumbbellXEnd.IsReadOnly = False
        Me.ucrInputDumbbellXEnd.Location = New System.Drawing.Point(229, 318)
        Me.ucrInputDumbbellXEnd.Name = "ucrInputDumbbellXEnd"
        Me.ucrInputDumbbellXEnd.Size = New System.Drawing.Size(59, 21)
        Me.ucrInputDumbbellXEnd.TabIndex = 48
        '
        'ucrInputDumbbellX
        '
        Me.ucrInputDumbbellX.AddQuotesIfUnrecognised = True
        Me.ucrInputDumbbellX.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDumbbellX.GetSetSelectedIndex = -1
        Me.ucrInputDumbbellX.IsReadOnly = False
        Me.ucrInputDumbbellX.Location = New System.Drawing.Point(112, 320)
        Me.ucrInputDumbbellX.Name = "ucrInputDumbbellX"
        Me.ucrInputDumbbellX.Size = New System.Drawing.Size(55, 21)
        Me.ucrInputDumbbellX.TabIndex = 9
        '
        'ucrNudDumbbellLine
        '
        Me.ucrNudDumbbellLine.AutoSize = True
        Me.ucrNudDumbbellLine.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDumbbellLine.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDumbbellLine.Location = New System.Drawing.Point(341, 350)
        Me.ucrNudDumbbellLine.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDumbbellLine.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDumbbellLine.Name = "ucrNudDumbbellLine"
        Me.ucrNudDumbbellLine.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDumbbellLine.TabIndex = 47
        Me.ucrNudDumbbellLine.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDumbbellXEnd
        '
        Me.ucrNudDumbbellXEnd.AutoSize = True
        Me.ucrNudDumbbellXEnd.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDumbbellXEnd.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDumbbellXEnd.Location = New System.Drawing.Point(229, 351)
        Me.ucrNudDumbbellXEnd.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDumbbellXEnd.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDumbbellXEnd.Name = "ucrNudDumbbellXEnd"
        Me.ucrNudDumbbellXEnd.Size = New System.Drawing.Size(59, 20)
        Me.ucrNudDumbbellXEnd.TabIndex = 46
        Me.ucrNudDumbbellXEnd.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDumbbellX
        '
        Me.ucrNudDumbbellX.AutoSize = True
        Me.ucrNudDumbbellX.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDumbbellX.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDumbbellX.Location = New System.Drawing.Point(112, 351)
        Me.ucrNudDumbbellX.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDumbbellX.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDumbbellX.Name = "ucrNudDumbbellX"
        Me.ucrNudDumbbellX.Size = New System.Drawing.Size(55, 20)
        Me.ucrNudDumbbellX.TabIndex = 9
        Me.ucrNudDumbbellX.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkDumbbellColour
        '
        Me.ucrChkDumbbellColour.AutoSize = True
        Me.ucrChkDumbbellColour.Checked = False
        Me.ucrChkDumbbellColour.Location = New System.Drawing.Point(9, 322)
        Me.ucrChkDumbbellColour.Name = "ucrChkDumbbellColour"
        Me.ucrChkDumbbellColour.Size = New System.Drawing.Size(80, 24)
        Me.ucrChkDumbbellColour.TabIndex = 45
        '
        'ucrChkDumbbellSize
        '
        Me.ucrChkDumbbellSize.AutoSize = True
        Me.ucrChkDumbbellSize.Checked = False
        Me.ucrChkDumbbellSize.Location = New System.Drawing.Point(9, 353)
        Me.ucrChkDumbbellSize.Name = "ucrChkDumbbellSize"
        Me.ucrChkDumbbellSize.Size = New System.Drawing.Size(80, 24)
        Me.ucrChkDumbbellSize.TabIndex = 44
        '
        'ucrReceiverGroup
        '
        Me.ucrReceiverGroup.AutoSize = True
        Me.ucrReceiverGroup.frmParent = Me
        Me.ucrReceiverGroup.Location = New System.Drawing.Point(249, 327)
        Me.ucrReceiverGroup.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverGroup.Name = "ucrReceiverGroup"
        Me.ucrReceiverGroup.Selector = Nothing
        Me.ucrReceiverGroup.Size = New System.Drawing.Size(125, 20)
        Me.ucrReceiverGroup.strNcFilePath = ""
        Me.ucrReceiverGroup.TabIndex = 20
        Me.ucrReceiverGroup.ucrSelector = Nothing
        '
        'ucrReceiverSlopeY
        '
        Me.ucrReceiverSlopeY.AutoSize = True
        Me.ucrReceiverSlopeY.frmParent = Me
        Me.ucrReceiverSlopeY.Location = New System.Drawing.Point(249, 107)
        Me.ucrReceiverSlopeY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSlopeY.Name = "ucrReceiverSlopeY"
        Me.ucrReceiverSlopeY.Selector = Nothing
        Me.ucrReceiverSlopeY.Size = New System.Drawing.Size(125, 26)
        Me.ucrReceiverSlopeY.strNcFilePath = ""
        Me.ucrReceiverSlopeY.TabIndex = 10
        Me.ucrReceiverSlopeY.ucrSelector = Nothing
        '
        'ucrChkAddLine
        '
        Me.ucrChkAddLine.AutoSize = True
        Me.ucrChkAddLine.Checked = False
        Me.ucrChkAddLine.Location = New System.Drawing.Point(90, 337)
        Me.ucrChkAddLine.Name = "ucrChkAddLine"
        Me.ucrChkAddLine.Size = New System.Drawing.Size(77, 24)
        Me.ucrChkAddLine.TabIndex = 24
        '
        'ucrChkAddPoints
        '
        Me.ucrChkAddPoints.AutoSize = True
        Me.ucrChkAddPoints.Checked = False
        Me.ucrChkAddPoints.Location = New System.Drawing.Point(9, 337)
        Me.ucrChkAddPoints.Name = "ucrChkAddPoints"
        Me.ucrChkAddPoints.Size = New System.Drawing.Size(80, 24)
        Me.ucrChkAddPoints.TabIndex = 23
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(30, 7)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(363, 44)
        Me.ucrPnlOptions.TabIndex = 0
        '
        'ucrPnlStepOrPath
        '
        Me.ucrPnlStepOrPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlStepOrPath.Location = New System.Drawing.Point(150, 411)
        Me.ucrPnlStepOrPath.Name = "ucrPnlStepOrPath"
        Me.ucrPnlStepOrPath.Size = New System.Drawing.Size(148, 29)
        Me.ucrPnlStepOrPath.TabIndex = 28
        '
        'ucrChkPathOrStep
        '
        Me.ucrChkPathOrStep.AutoSize = True
        Me.ucrChkPathOrStep.Checked = False
        Me.ucrChkPathOrStep.Location = New System.Drawing.Point(9, 415)
        Me.ucrChkPathOrStep.Name = "ucrChkPathOrStep"
        Me.ucrChkPathOrStep.Size = New System.Drawing.Size(148, 23)
        Me.ucrChkPathOrStep.TabIndex = 32
        '
        'ucrChkValley
        '
        Me.ucrChkValley.AutoSize = True
        Me.ucrChkValley.Checked = False
        Me.ucrChkValley.Location = New System.Drawing.Point(161, 385)
        Me.ucrChkValley.Name = "ucrChkValley"
        Me.ucrChkValley.Size = New System.Drawing.Size(146, 23)
        Me.ucrChkValley.TabIndex = 27
        '
        'ucrChkPeak
        '
        Me.ucrChkPeak.AutoSize = True
        Me.ucrChkPeak.Checked = False
        Me.ucrChkPeak.Location = New System.Drawing.Point(9, 389)
        Me.ucrChkPeak.Name = "ucrChkPeak"
        Me.ucrChkPeak.Size = New System.Drawing.Size(149, 23)
        Me.ucrChkPeak.TabIndex = 33
        '
        'ucrChkWithSE
        '
        Me.ucrChkWithSE.AutoSize = True
        Me.ucrChkWithSE.Checked = False
        Me.ucrChkWithSE.Location = New System.Drawing.Point(161, 367)
        Me.ucrChkWithSE.Name = "ucrChkWithSE"
        Me.ucrChkWithSE.Size = New System.Drawing.Size(72, 23)
        Me.ucrChkWithSE.TabIndex = 26
        '
        'ucrChkLineofBestFit
        '
        Me.ucrChkLineofBestFit.AutoSize = True
        Me.ucrChkLineofBestFit.Checked = False
        Me.ucrChkLineofBestFit.Location = New System.Drawing.Point(9, 363)
        Me.ucrChkLineofBestFit.Name = "ucrChkLineofBestFit"
        Me.ucrChkLineofBestFit.Size = New System.Drawing.Size(149, 24)
        Me.ucrChkLineofBestFit.TabIndex = 34
        '
        'ucrSave
        '
        Me.ucrSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSave.Location = New System.Drawing.Point(9, 442)
        Me.ucrSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSave.Name = "ucrSave"
        Me.ucrSave.Size = New System.Drawing.Size(346, 24)
        Me.ucrSave.TabIndex = 31
        '
        'ucrVariablesAsFactorForLinePlot
        '
        Me.ucrVariablesAsFactorForLinePlot.AutoSize = True
        Me.ucrVariablesAsFactorForLinePlot.frmParent = Me
        Me.ucrVariablesAsFactorForLinePlot.Location = New System.Drawing.Point(249, 79)
        Me.ucrVariablesAsFactorForLinePlot.Name = "ucrVariablesAsFactorForLinePlot"
        Me.ucrVariablesAsFactorForLinePlot.Selector = Nothing
        Me.ucrVariablesAsFactorForLinePlot.Size = New System.Drawing.Size(125, 136)
        Me.ucrVariablesAsFactorForLinePlot.strNcFilePath = ""
        Me.ucrVariablesAsFactorForLinePlot.TabIndex = 8
        Me.ucrVariablesAsFactorForLinePlot.ucrSelector = Nothing
        Me.ucrVariablesAsFactorForLinePlot.ucrVariableSelector = Nothing
        '
        'ucrLinePlotSelector
        '
        Me.ucrLinePlotSelector.AutoSize = True
        Me.ucrLinePlotSelector.bDropUnusedFilterLevels = False
        Me.ucrLinePlotSelector.bShowHiddenColumns = False
        Me.ucrLinePlotSelector.bUseCurrentFilter = True
        Me.ucrLinePlotSelector.Location = New System.Drawing.Point(10, 59)
        Me.ucrLinePlotSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrLinePlotSelector.Name = "ucrLinePlotSelector"
        Me.ucrLinePlotSelector.Size = New System.Drawing.Size(226, 195)
        Me.ucrLinePlotSelector.TabIndex = 6
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 467)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrReceiverXEnd
        '
        Me.ucrReceiverXEnd.AutoSize = True
        Me.ucrReceiverXEnd.frmParent = Me
        Me.ucrReceiverXEnd.Location = New System.Drawing.Point(246, 288)
        Me.ucrReceiverXEnd.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverXEnd.Name = "ucrReceiverXEnd"
        Me.ucrReceiverXEnd.Selector = Nothing
        Me.ucrReceiverXEnd.Size = New System.Drawing.Size(129, 20)
        Me.ucrReceiverXEnd.strNcFilePath = ""
        Me.ucrReceiverXEnd.TabIndex = 75
        Me.ucrReceiverXEnd.ucrSelector = Nothing
        '
        'ucrReceiverSlopeX
        '
        Me.ucrReceiverSlopeX.AutoSize = True
        Me.ucrReceiverSlopeX.frmParent = Me
        Me.ucrReceiverSlopeX.Location = New System.Drawing.Point(247, 242)
        Me.ucrReceiverSlopeX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSlopeX.Name = "ucrReceiverSlopeX"
        Me.ucrReceiverSlopeX.Selector = Nothing
        Me.ucrReceiverSlopeX.Size = New System.Drawing.Size(128, 26)
        Me.ucrReceiverSlopeX.strNcFilePath = ""
        Me.ucrReceiverSlopeX.TabIndex = 12
        Me.ucrReceiverSlopeX.ucrSelector = Nothing
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.AutoSize = True
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(249, 242)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(125, 26)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 14
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrReceiverSlopeColour
        '
        Me.ucrReceiverSlopeColour.AutoSize = True
        Me.ucrReceiverSlopeColour.frmParent = Me
        Me.ucrReceiverSlopeColour.Location = New System.Drawing.Point(249, 288)
        Me.ucrReceiverSlopeColour.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSlopeColour.Name = "ucrReceiverSlopeColour"
        Me.ucrReceiverSlopeColour.Selector = Nothing
        Me.ucrReceiverSlopeColour.Size = New System.Drawing.Size(125, 26)
        Me.ucrReceiverSlopeColour.strNcFilePath = ""
        Me.ucrReceiverSlopeColour.TabIndex = 43
        Me.ucrReceiverSlopeColour.ucrSelector = Nothing
        '
        'ucrFactorOptionalReceiver
        '
        Me.ucrFactorOptionalReceiver.AutoSize = True
        Me.ucrFactorOptionalReceiver.frmParent = Me
        Me.ucrFactorOptionalReceiver.Location = New System.Drawing.Point(249, 288)
        Me.ucrFactorOptionalReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorOptionalReceiver.Name = "ucrFactorOptionalReceiver"
        Me.ucrFactorOptionalReceiver.Selector = Nothing
        Me.ucrFactorOptionalReceiver.Size = New System.Drawing.Size(125, 26)
        Me.ucrFactorOptionalReceiver.strNcFilePath = ""
        Me.ucrFactorOptionalReceiver.TabIndex = 18
        Me.ucrFactorOptionalReceiver.ucrSelector = Nothing
        '
        'ucrChkSlopeLineOptions
        '
        Me.ucrChkSlopeLineOptions.AutoSize = True
        Me.ucrChkSlopeLineOptions.Checked = False
        Me.ucrChkSlopeLineOptions.Location = New System.Drawing.Point(10, 382)
        Me.ucrChkSlopeLineOptions.Name = "ucrChkSlopeLineOptions"
        Me.ucrChkSlopeLineOptions.Size = New System.Drawing.Size(80, 24)
        Me.ucrChkSlopeLineOptions.TabIndex = 69
        '
        'UcrNudSlopeYTextSize
        '
        Me.UcrNudSlopeYTextSize.AutoSize = True
        Me.UcrNudSlopeYTextSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudSlopeYTextSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNudSlopeYTextSize.Location = New System.Drawing.Point(347, 350)
        Me.UcrNudSlopeYTextSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudSlopeYTextSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudSlopeYTextSize.Name = "UcrNudSlopeYTextSize"
        Me.UcrNudSlopeYTextSize.Size = New System.Drawing.Size(50, 20)
        Me.UcrNudSlopeYTextSize.TabIndex = 61
        Me.UcrNudSlopeYTextSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgLinePlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(423, 523)
        Me.Controls.Add(Me.ucrChkSlopeLegend)
        Me.Controls.Add(Me.ucrNudSlopeLabelPadding)
        Me.Controls.Add(Me.lblSlopeLineTicknes)
        Me.Controls.Add(Me.ucrNudSlopeLineThickness)
        Me.Controls.Add(Me.lblSlopeLineColour)
        Me.Controls.Add(Me.lblSlopeLabelSize)
        Me.Controls.Add(Me.lblSlopeLabelPadding)
        Me.Controls.Add(Me.lblSopeTextColour)
        Me.Controls.Add(Me.lblSlopeTextSize)
        Me.Controls.Add(Me.lblSlopeLabelColour)
        Me.Controls.Add(Me.ucrInputSlopeLineColour)
        Me.Controls.Add(Me.ucrInputSlopeTextColour)
        Me.Controls.Add(Me.ucrInputSlopeLabelColour)
        Me.Controls.Add(Me.ucrNudSlopeTextSize)
        Me.Controls.Add(Me.ucrNudSlopeLabelSize)
        Me.Controls.Add(Me.lblXEndColour)
        Me.Controls.Add(Me.lblLineColour)
        Me.Controls.Add(Me.lblXSize)
        Me.Controls.Add(Me.lblXEndSize)
        Me.Controls.Add(Me.lblLineSize)
        Me.Controls.Add(Me.lblXColour)
        Me.Controls.Add(Me.ucrInputDumbbellLine)
        Me.Controls.Add(Me.ucrInputDumbbellXEnd)
        Me.Controls.Add(Me.ucrInputDumbbellX)
        Me.Controls.Add(Me.ucrNudDumbbellLine)
        Me.Controls.Add(Me.ucrNudDumbbellXEnd)
        Me.Controls.Add(Me.ucrNudDumbbellX)
        Me.Controls.Add(Me.ucrChkDumbbellSize)
        Me.Controls.Add(Me.ucrReceiverGroup)
        Me.Controls.Add(Me.lblSlopeColour)
        Me.Controls.Add(Me.lblSlopeX)
        Me.Controls.Add(Me.ucrReceiverSlopeY)
        Me.Controls.Add(Me.lblSlopeY)
        Me.Controls.Add(Me.rdoSlope)
        Me.Controls.Add(Me.rdoDumbbell)
        Me.Controls.Add(Me.grpSmoothOptions)
        Me.Controls.Add(Me.ucrChkAddLine)
        Me.Controls.Add(Me.rdoSmoothing)
        Me.Controls.Add(Me.rdoLine)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.rdoStep)
        Me.Controls.Add(Me.rdoPath)
        Me.Controls.Add(Me.ucrPnlStepOrPath)
        Me.Controls.Add(Me.ucrChkPathOrStep)
        Me.Controls.Add(Me.lblGroupLine)
        Me.Controls.Add(Me.ucrChkValley)
        Me.Controls.Add(Me.ucrChkPeak)
        Me.Controls.Add(Me.ucrChkWithSE)
        Me.Controls.Add(Me.ucrChkLineofBestFit)
        Me.Controls.Add(Me.ucrSave)
        Me.Controls.Add(Me.ucrVariablesAsFactorForLinePlot)
        Me.Controls.Add(Me.cmdLinePathStepSmoothOptions)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrLinePlotSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblFactorOptional)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.lblAvailable)
        Me.Controls.Add(Me.lblXEnd)
        Me.Controls.Add(Me.ucrReceiverXEnd)
        Me.Controls.Add(Me.ucrReceiverSlopeX)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.ucrReceiverSlopeColour)
        Me.Controls.Add(Me.ucrFactorOptionalReceiver)
        Me.Controls.Add(Me.ucrChkSlopeLineOptions)
        Me.Controls.Add(Me.UcrNudSlopeYTextSize)
        Me.Controls.Add(Me.ucrChkDumbbellColour)
        Me.Controls.Add(Me.ucrChkAddPoints)
        Me.Controls.Add(Me.lblSlopeYTextSize)
        Me.Controls.Add(Me.ucrChkSlopeLabelOptions)
        Me.Controls.Add(Me.ucrChkSlopeTextOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgLinePlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Line_Plot"
        Me.Text = "Line"
        Me.grpSmoothOptions.ResumeLayout(False)
        Me.grpSmoothOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblXVariable As Label
    Friend WithEvents lblAvailable As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrLinePlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdOptions As Button
    Friend WithEvents cmdLinePathStepSmoothOptions As Button
    Friend WithEvents lblFactorOptional As Label
    Friend WithEvents ucrFactorOptionalReceiver As ucrReceiverSingle
    Friend WithEvents ucrVariablesAsFactorForLinePlot As ucrVariablesAsFactor
    Friend WithEvents ucrChkAddPoints As ucrCheck
    Friend WithEvents ucrSave As ucrSave
    Friend WithEvents ucrChkLineofBestFit As ucrCheck
    Friend WithEvents ucrChkWithSE As ucrCheck
    Friend WithEvents ucrReceiverGroup As ucrReceiverSingle
    Friend WithEvents ucrChkValley As ucrCheck
    Friend WithEvents ucrChkPeak As ucrCheck
    Friend WithEvents lblGroupLine As Label
    Friend WithEvents ucrChkPathOrStep As ucrCheck
    Friend WithEvents ucrPnlStepOrPath As UcrPanel
    Friend WithEvents rdoStep As RadioButton
    Friend WithEvents rdoPath As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents rdoSmoothing As RadioButton
    Friend WithEvents rdoLine As RadioButton
    Friend WithEvents ucrChkAddLine As ucrCheck
    Friend WithEvents ucrChkAddSE As ucrCheck
    Friend WithEvents lblMethod As Label
    Friend WithEvents ucrInputMethod As ucrInputComboBox
    Friend WithEvents ucrNudSpan As ucrNud
    Friend WithEvents ucrFamilyInput As ucrInputComboBox
    Friend WithEvents lblFamily As Label
    Friend WithEvents ucrInputFormula As ucrInputComboBox
    Friend WithEvents ucrChkFormula As ucrCheck
    Friend WithEvents ucrChkSpan As ucrCheck
    Friend WithEvents grpSmoothOptions As GroupBox
    Friend WithEvents rdoSlope As RadioButton
    Friend WithEvents rdoDumbbell As RadioButton
    Friend WithEvents lblXEnd As Label
    Friend WithEvents ucrReceiverXEnd As ucrReceiverSingle
    Friend WithEvents ucrReceiverSlopeX As ucrReceiverSingle
    Friend WithEvents lblSlopeX As Label
    Friend WithEvents ucrReceiverSlopeY As ucrReceiverSingle
    Friend WithEvents lblSlopeY As Label
    Friend WithEvents lblSlopeColour As Label
    Friend WithEvents ucrReceiverSlopeColour As ucrReceiverSingle
    Friend WithEvents lblXEndColour As Label
    Friend WithEvents lblLineColour As Label
    Friend WithEvents lblXSize As Label
    Friend WithEvents lblXEndSize As Label
    Friend WithEvents lblLineSize As Label
    Friend WithEvents lblXColour As Label
    Friend WithEvents ucrInputDumbbellLine As ucrInputComboBox
    Friend WithEvents ucrInputDumbbellXEnd As ucrInputComboBox
    Friend WithEvents ucrInputDumbbellX As ucrInputComboBox
    Friend WithEvents ucrNudDumbbellLine As ucrNud
    Friend WithEvents ucrNudDumbbellXEnd As ucrNud
    Friend WithEvents ucrNudDumbbellX As ucrNud
    Friend WithEvents ucrChkDumbbellColour As ucrCheck
    Friend WithEvents ucrChkDumbbellSize As ucrCheck
    Friend WithEvents ucrChkSlopeLegend As ucrCheck
    Friend WithEvents ucrNudSlopeLabelPadding As ucrNud
    Friend WithEvents lblSlopeLineTicknes As Label
    Friend WithEvents ucrNudSlopeLineThickness As ucrNud
    Friend WithEvents lblSlopeLineColour As Label
    Friend WithEvents ucrChkSlopeLineOptions As ucrCheck
    Friend WithEvents lblSlopeLabelSize As Label
    Friend WithEvents lblSlopeLabelPadding As Label
    Friend WithEvents lblSopeTextColour As Label
    Friend WithEvents lblSlopeTextSize As Label
    Friend WithEvents lblSlopeYTextSize As Label
    Friend WithEvents lblSlopeLabelColour As Label
    Friend WithEvents ucrInputSlopeLineColour As ucrInputComboBox
    Friend WithEvents ucrInputSlopeTextColour As ucrInputComboBox
    Friend WithEvents ucrInputSlopeLabelColour As ucrInputComboBox
    Friend WithEvents UcrNudSlopeYTextSize As ucrNud
    Friend WithEvents ucrNudSlopeTextSize As ucrNud
    Friend WithEvents ucrNudSlopeLabelSize As ucrNud
    Friend WithEvents ucrChkSlopeLabelOptions As ucrCheck
    Friend WithEvents ucrChkSlopeTextOptions As ucrCheck
End Class
