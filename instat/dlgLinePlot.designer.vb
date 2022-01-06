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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgLinePlot))
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
        Me.ucrInputFormula = New instat.ucrInputComboBox()
        Me.ucrChkSpan = New instat.ucrCheck()
        Me.ucrChkFormula = New instat.ucrCheck()
        Me.ucrChkAddSE = New instat.ucrCheck()
        Me.ucrNudSpan = New instat.ucrNud()
        Me.ucrInputMethod = New instat.ucrInputComboBox()
        Me.ucrFamilyInput = New instat.ucrInputComboBox()
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
        resources.ApplyResources(Me.lblXVariable, "lblXVariable")
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Tag = "X_Variable:"
        '
        'lblAvailable
        '
        resources.ApplyResources(Me.lblAvailable, "lblAvailable")
        Me.lblAvailable.Name = "lblAvailable"
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'cmdLinePathStepSmoothOptions
        '
        resources.ApplyResources(Me.cmdLinePathStepSmoothOptions, "cmdLinePathStepSmoothOptions")
        Me.cmdLinePathStepSmoothOptions.Name = "cmdLinePathStepSmoothOptions"
        Me.cmdLinePathStepSmoothOptions.Tag = "Line_Options"
        Me.cmdLinePathStepSmoothOptions.UseVisualStyleBackColor = True
        '
        'lblFactorOptional
        '
        resources.ApplyResources(Me.lblFactorOptional, "lblFactorOptional")
        Me.lblFactorOptional.Name = "lblFactorOptional"
        Me.lblFactorOptional.Tag = "Factor_Optional:"
        '
        'lblGroupLine
        '
        resources.ApplyResources(Me.lblGroupLine, "lblGroupLine")
        Me.lblGroupLine.Name = "lblGroupLine"
        '
        'rdoPath
        '
        resources.ApplyResources(Me.rdoPath, "rdoPath")
        Me.rdoPath.Name = "rdoPath"
        Me.rdoPath.TabStop = True
        Me.rdoPath.UseVisualStyleBackColor = True
        '
        'rdoStep
        '
        resources.ApplyResources(Me.rdoStep, "rdoStep")
        Me.rdoStep.Name = "rdoStep"
        Me.rdoStep.TabStop = True
        Me.rdoStep.UseVisualStyleBackColor = True
        '
        'rdoLine
        '
        resources.ApplyResources(Me.rdoLine, "rdoLine")
        Me.rdoLine.BackColor = System.Drawing.SystemColors.Control
        Me.rdoLine.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLine.FlatAppearance.BorderSize = 2
        Me.rdoLine.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLine.Name = "rdoLine"
        Me.rdoLine.TabStop = True
        Me.rdoLine.Tag = "linepathstep"
        Me.rdoLine.UseVisualStyleBackColor = False
        '
        'rdoSmoothing
        '
        resources.ApplyResources(Me.rdoSmoothing, "rdoSmoothing")
        Me.rdoSmoothing.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSmoothing.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSmoothing.FlatAppearance.BorderSize = 2
        Me.rdoSmoothing.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSmoothing.Name = "rdoSmoothing"
        Me.rdoSmoothing.TabStop = True
        Me.rdoSmoothing.Tag = "Smooth"
        Me.rdoSmoothing.UseVisualStyleBackColor = False
        '
        'lblMethod
        '
        resources.ApplyResources(Me.lblMethod, "lblMethod")
        Me.lblMethod.Name = "lblMethod"
        '
        'lblFamily
        '
        resources.ApplyResources(Me.lblFamily, "lblFamily")
        Me.lblFamily.Name = "lblFamily"
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
        resources.ApplyResources(Me.grpSmoothOptions, "grpSmoothOptions")
        Me.grpSmoothOptions.Name = "grpSmoothOptions"
        Me.grpSmoothOptions.TabStop = False
        '
        'rdoSlope
        '
        resources.ApplyResources(Me.rdoSlope, "rdoSlope")
        Me.rdoSlope.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSlope.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSlope.FlatAppearance.BorderSize = 2
        Me.rdoSlope.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSlope.Name = "rdoSlope"
        Me.rdoSlope.TabStop = True
        Me.rdoSlope.Tag = "Slope"
        Me.rdoSlope.UseVisualStyleBackColor = False
        '
        'rdoDumbbell
        '
        resources.ApplyResources(Me.rdoDumbbell, "rdoDumbbell")
        Me.rdoDumbbell.BackColor = System.Drawing.SystemColors.Control
        Me.rdoDumbbell.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDumbbell.FlatAppearance.BorderSize = 2
        Me.rdoDumbbell.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDumbbell.Name = "rdoDumbbell"
        Me.rdoDumbbell.TabStop = True
        Me.rdoDumbbell.Tag = "linepathstep"
        Me.rdoDumbbell.UseVisualStyleBackColor = False
        '
        'lblXEnd
        '
        resources.ApplyResources(Me.lblXEnd, "lblXEnd")
        Me.lblXEnd.Name = "lblXEnd"
        Me.lblXEnd.Tag = "XEnd_Variable:"
        '
        'lblSlopeY
        '
        resources.ApplyResources(Me.lblSlopeY, "lblSlopeY")
        Me.lblSlopeY.Name = "lblSlopeY"
        Me.lblSlopeY.Tag = "Y_Slope_Variable:"
        '
        'lblSlopeX
        '
        resources.ApplyResources(Me.lblSlopeX, "lblSlopeX")
        Me.lblSlopeX.Name = "lblSlopeX"
        Me.lblSlopeX.Tag = "X_Slope_Variable:"
        '
        'lblSlopeColour
        '
        resources.ApplyResources(Me.lblSlopeColour, "lblSlopeColour")
        Me.lblSlopeColour.Name = "lblSlopeColour"
        Me.lblSlopeColour.Tag = "Colour"
        '
        'lblXColour
        '
        resources.ApplyResources(Me.lblXColour, "lblXColour")
        Me.lblXColour.Name = "lblXColour"
        '
        'lblLineSize
        '
        resources.ApplyResources(Me.lblLineSize, "lblLineSize")
        Me.lblLineSize.Name = "lblLineSize"
        '
        'lblXEndSize
        '
        resources.ApplyResources(Me.lblXEndSize, "lblXEndSize")
        Me.lblXEndSize.Name = "lblXEndSize"
        '
        'lblXSize
        '
        resources.ApplyResources(Me.lblXSize, "lblXSize")
        Me.lblXSize.Name = "lblXSize"
        '
        'lblLineColour
        '
        resources.ApplyResources(Me.lblLineColour, "lblLineColour")
        Me.lblLineColour.Name = "lblLineColour"
        '
        'lblXEndColour
        '
        resources.ApplyResources(Me.lblXEndColour, "lblXEndColour")
        Me.lblXEndColour.Name = "lblXEndColour"
        '
        'lblSlopeLabelSize
        '
        resources.ApplyResources(Me.lblSlopeLabelSize, "lblSlopeLabelSize")
        Me.lblSlopeLabelSize.Name = "lblSlopeLabelSize"
        '
        'lblSlopeLabelPadding
        '
        resources.ApplyResources(Me.lblSlopeLabelPadding, "lblSlopeLabelPadding")
        Me.lblSlopeLabelPadding.Name = "lblSlopeLabelPadding"
        '
        'lblSopeTextColour
        '
        resources.ApplyResources(Me.lblSopeTextColour, "lblSopeTextColour")
        Me.lblSopeTextColour.Name = "lblSopeTextColour"
        '
        'lblSlopeTextSize
        '
        resources.ApplyResources(Me.lblSlopeTextSize, "lblSlopeTextSize")
        Me.lblSlopeTextSize.Name = "lblSlopeTextSize"
        '
        'lblSlopeYTextSize
        '
        resources.ApplyResources(Me.lblSlopeYTextSize, "lblSlopeYTextSize")
        Me.lblSlopeYTextSize.Name = "lblSlopeYTextSize"
        '
        'lblSlopeLabelColour
        '
        resources.ApplyResources(Me.lblSlopeLabelColour, "lblSlopeLabelColour")
        Me.lblSlopeLabelColour.Name = "lblSlopeLabelColour"
        '
        'lblSlopeLineColour
        '
        resources.ApplyResources(Me.lblSlopeLineColour, "lblSlopeLineColour")
        Me.lblSlopeLineColour.Name = "lblSlopeLineColour"
        '
        'lblSlopeLineTicknes
        '
        resources.ApplyResources(Me.lblSlopeLineTicknes, "lblSlopeLineTicknes")
        Me.lblSlopeLineTicknes.Name = "lblSlopeLineTicknes"
        '
        'ucrChkSlopeLegend
        '
        Me.ucrChkSlopeLegend.Checked = False
        resources.ApplyResources(Me.ucrChkSlopeLegend, "ucrChkSlopeLegend")
        Me.ucrChkSlopeLegend.Name = "ucrChkSlopeLegend"
        '
        'ucrNudSlopeLabelPadding
        '
        Me.ucrNudSlopeLabelPadding.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSlopeLabelPadding.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSlopeLabelPadding, "ucrNudSlopeLabelPadding")
        Me.ucrNudSlopeLabelPadding.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSlopeLabelPadding.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSlopeLabelPadding.Name = "ucrNudSlopeLabelPadding"
        Me.ucrNudSlopeLabelPadding.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSlopeLineThickness
        '
        Me.ucrNudSlopeLineThickness.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSlopeLineThickness.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSlopeLineThickness, "ucrNudSlopeLineThickness")
        Me.ucrNudSlopeLineThickness.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSlopeLineThickness.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSlopeLineThickness.Name = "ucrNudSlopeLineThickness"
        Me.ucrNudSlopeLineThickness.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputSlopeLineColour
        '
        Me.ucrInputSlopeLineColour.AddQuotesIfUnrecognised = True
        Me.ucrInputSlopeLineColour.GetSetSelectedIndex = -1
        Me.ucrInputSlopeLineColour.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSlopeLineColour, "ucrInputSlopeLineColour")
        Me.ucrInputSlopeLineColour.Name = "ucrInputSlopeLineColour"
        '
        'ucrInputSlopeTextColour
        '
        Me.ucrInputSlopeTextColour.AddQuotesIfUnrecognised = True
        Me.ucrInputSlopeTextColour.GetSetSelectedIndex = -1
        Me.ucrInputSlopeTextColour.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSlopeTextColour, "ucrInputSlopeTextColour")
        Me.ucrInputSlopeTextColour.Name = "ucrInputSlopeTextColour"
        '
        'ucrInputSlopeLabelColour
        '
        Me.ucrInputSlopeLabelColour.AddQuotesIfUnrecognised = True
        Me.ucrInputSlopeLabelColour.GetSetSelectedIndex = -1
        Me.ucrInputSlopeLabelColour.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSlopeLabelColour, "ucrInputSlopeLabelColour")
        Me.ucrInputSlopeLabelColour.Name = "ucrInputSlopeLabelColour"
        '
        'ucrNudSlopeTextSize
        '
        Me.ucrNudSlopeTextSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSlopeTextSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSlopeTextSize, "ucrNudSlopeTextSize")
        Me.ucrNudSlopeTextSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSlopeTextSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSlopeTextSize.Name = "ucrNudSlopeTextSize"
        Me.ucrNudSlopeTextSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSlopeLabelSize
        '
        Me.ucrNudSlopeLabelSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSlopeLabelSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSlopeLabelSize, "ucrNudSlopeLabelSize")
        Me.ucrNudSlopeLabelSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSlopeLabelSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSlopeLabelSize.Name = "ucrNudSlopeLabelSize"
        Me.ucrNudSlopeLabelSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkSlopeLabelOptions
        '
        Me.ucrChkSlopeLabelOptions.Checked = False
        resources.ApplyResources(Me.ucrChkSlopeLabelOptions, "ucrChkSlopeLabelOptions")
        Me.ucrChkSlopeLabelOptions.Name = "ucrChkSlopeLabelOptions"
        '
        'ucrChkSlopeTextOptions
        '
        Me.ucrChkSlopeTextOptions.Checked = False
        resources.ApplyResources(Me.ucrChkSlopeTextOptions, "ucrChkSlopeTextOptions")
        Me.ucrChkSlopeTextOptions.Name = "ucrChkSlopeTextOptions"
        '
        'ucrInputDumbbellLine
        '
        Me.ucrInputDumbbellLine.AddQuotesIfUnrecognised = True
        Me.ucrInputDumbbellLine.GetSetSelectedIndex = -1
        Me.ucrInputDumbbellLine.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputDumbbellLine, "ucrInputDumbbellLine")
        Me.ucrInputDumbbellLine.Name = "ucrInputDumbbellLine"
        '
        'ucrInputDumbbellXEnd
        '
        Me.ucrInputDumbbellXEnd.AddQuotesIfUnrecognised = True
        Me.ucrInputDumbbellXEnd.GetSetSelectedIndex = -1
        Me.ucrInputDumbbellXEnd.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputDumbbellXEnd, "ucrInputDumbbellXEnd")
        Me.ucrInputDumbbellXEnd.Name = "ucrInputDumbbellXEnd"
        '
        'ucrInputDumbbellX
        '
        Me.ucrInputDumbbellX.AddQuotesIfUnrecognised = True
        Me.ucrInputDumbbellX.GetSetSelectedIndex = -1
        Me.ucrInputDumbbellX.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputDumbbellX, "ucrInputDumbbellX")
        Me.ucrInputDumbbellX.Name = "ucrInputDumbbellX"
        '
        'ucrNudDumbbellLine
        '
        Me.ucrNudDumbbellLine.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDumbbellLine.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudDumbbellLine, "ucrNudDumbbellLine")
        Me.ucrNudDumbbellLine.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDumbbellLine.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDumbbellLine.Name = "ucrNudDumbbellLine"
        Me.ucrNudDumbbellLine.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDumbbellXEnd
        '
        Me.ucrNudDumbbellXEnd.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDumbbellXEnd.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudDumbbellXEnd, "ucrNudDumbbellXEnd")
        Me.ucrNudDumbbellXEnd.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDumbbellXEnd.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDumbbellXEnd.Name = "ucrNudDumbbellXEnd"
        Me.ucrNudDumbbellXEnd.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDumbbellX
        '
        Me.ucrNudDumbbellX.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDumbbellX.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudDumbbellX, "ucrNudDumbbellX")
        Me.ucrNudDumbbellX.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDumbbellX.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDumbbellX.Name = "ucrNudDumbbellX"
        Me.ucrNudDumbbellX.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkDumbbellColour
        '
        Me.ucrChkDumbbellColour.Checked = False
        resources.ApplyResources(Me.ucrChkDumbbellColour, "ucrChkDumbbellColour")
        Me.ucrChkDumbbellColour.Name = "ucrChkDumbbellColour"
        '
        'ucrChkDumbbellSize
        '
        Me.ucrChkDumbbellSize.Checked = False
        resources.ApplyResources(Me.ucrChkDumbbellSize, "ucrChkDumbbellSize")
        Me.ucrChkDumbbellSize.Name = "ucrChkDumbbellSize"
        '
        'ucrReceiverGroup
        '
        Me.ucrReceiverGroup.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverGroup, "ucrReceiverGroup")
        Me.ucrReceiverGroup.Name = "ucrReceiverGroup"
        Me.ucrReceiverGroup.Selector = Nothing
        Me.ucrReceiverGroup.strNcFilePath = ""
        Me.ucrReceiverGroup.ucrSelector = Nothing
        '
        'ucrReceiverSlopeY
        '
        Me.ucrReceiverSlopeY.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSlopeY, "ucrReceiverSlopeY")
        Me.ucrReceiverSlopeY.Name = "ucrReceiverSlopeY"
        Me.ucrReceiverSlopeY.Selector = Nothing
        Me.ucrReceiverSlopeY.strNcFilePath = ""
        Me.ucrReceiverSlopeY.ucrSelector = Nothing
        '
        'ucrInputFormula
        '
        Me.ucrInputFormula.AddQuotesIfUnrecognised = True
        Me.ucrInputFormula.GetSetSelectedIndex = -1
        Me.ucrInputFormula.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFormula, "ucrInputFormula")
        Me.ucrInputFormula.Name = "ucrInputFormula"
        '
        'ucrChkSpan
        '
        Me.ucrChkSpan.Checked = False
        resources.ApplyResources(Me.ucrChkSpan, "ucrChkSpan")
        Me.ucrChkSpan.Name = "ucrChkSpan"
        '
        'ucrChkFormula
        '
        Me.ucrChkFormula.Checked = False
        resources.ApplyResources(Me.ucrChkFormula, "ucrChkFormula")
        Me.ucrChkFormula.Name = "ucrChkFormula"
        '
        'ucrChkAddSE
        '
        Me.ucrChkAddSE.Checked = False
        resources.ApplyResources(Me.ucrChkAddSE, "ucrChkAddSE")
        Me.ucrChkAddSE.Name = "ucrChkAddSE"
        '
        'ucrNudSpan
        '
        Me.ucrNudSpan.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSpan.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSpan, "ucrNudSpan")
        Me.ucrNudSpan.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSpan.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSpan.Name = "ucrNudSpan"
        Me.ucrNudSpan.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputMethod
        '
        Me.ucrInputMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputMethod.GetSetSelectedIndex = -1
        Me.ucrInputMethod.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMethod, "ucrInputMethod")
        Me.ucrInputMethod.Name = "ucrInputMethod"
        '
        'ucrFamilyInput
        '
        Me.ucrFamilyInput.AddQuotesIfUnrecognised = True
        Me.ucrFamilyInput.GetSetSelectedIndex = -1
        Me.ucrFamilyInput.IsReadOnly = False
        resources.ApplyResources(Me.ucrFamilyInput, "ucrFamilyInput")
        Me.ucrFamilyInput.Name = "ucrFamilyInput"
        '
        'ucrChkAddLine
        '
        Me.ucrChkAddLine.Checked = False
        resources.ApplyResources(Me.ucrChkAddLine, "ucrChkAddLine")
        Me.ucrChkAddLine.Name = "ucrChkAddLine"
        '
        'ucrChkAddPoints
        '
        Me.ucrChkAddPoints.Checked = False
        resources.ApplyResources(Me.ucrChkAddPoints, "ucrChkAddPoints")
        Me.ucrChkAddPoints.Name = "ucrChkAddPoints"
        '
        'ucrPnlOptions
        '
        resources.ApplyResources(Me.ucrPnlOptions, "ucrPnlOptions")
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        '
        'ucrPnlStepOrPath
        '
        resources.ApplyResources(Me.ucrPnlStepOrPath, "ucrPnlStepOrPath")
        Me.ucrPnlStepOrPath.Name = "ucrPnlStepOrPath"
        '
        'ucrChkPathOrStep
        '
        Me.ucrChkPathOrStep.Checked = False
        resources.ApplyResources(Me.ucrChkPathOrStep, "ucrChkPathOrStep")
        Me.ucrChkPathOrStep.Name = "ucrChkPathOrStep"
        '
        'ucrChkValley
        '
        Me.ucrChkValley.Checked = False
        resources.ApplyResources(Me.ucrChkValley, "ucrChkValley")
        Me.ucrChkValley.Name = "ucrChkValley"
        '
        'ucrChkPeak
        '
        Me.ucrChkPeak.Checked = False
        resources.ApplyResources(Me.ucrChkPeak, "ucrChkPeak")
        Me.ucrChkPeak.Name = "ucrChkPeak"
        '
        'ucrChkWithSE
        '
        Me.ucrChkWithSE.Checked = False
        resources.ApplyResources(Me.ucrChkWithSE, "ucrChkWithSE")
        Me.ucrChkWithSE.Name = "ucrChkWithSE"
        '
        'ucrChkLineofBestFit
        '
        Me.ucrChkLineofBestFit.Checked = False
        resources.ApplyResources(Me.ucrChkLineofBestFit, "ucrChkLineofBestFit")
        Me.ucrChkLineofBestFit.Name = "ucrChkLineofBestFit"
        '
        'ucrSave
        '
        resources.ApplyResources(Me.ucrSave, "ucrSave")
        Me.ucrSave.Name = "ucrSave"
        '
        'ucrVariablesAsFactorForLinePlot
        '
        Me.ucrVariablesAsFactorForLinePlot.frmParent = Me
        resources.ApplyResources(Me.ucrVariablesAsFactorForLinePlot, "ucrVariablesAsFactorForLinePlot")
        Me.ucrVariablesAsFactorForLinePlot.Name = "ucrVariablesAsFactorForLinePlot"
        Me.ucrVariablesAsFactorForLinePlot.Selector = Nothing
        Me.ucrVariablesAsFactorForLinePlot.strNcFilePath = ""
        Me.ucrVariablesAsFactorForLinePlot.ucrSelector = Nothing
        Me.ucrVariablesAsFactorForLinePlot.ucrVariableSelector = Nothing
        '
        'ucrLinePlotSelector
        '
        Me.ucrLinePlotSelector.bDropUnusedFilterLevels = False
        Me.ucrLinePlotSelector.bShowHiddenColumns = False
        Me.ucrLinePlotSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrLinePlotSelector, "ucrLinePlotSelector")
        Me.ucrLinePlotSelector.Name = "ucrLinePlotSelector"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReceiverXEnd
        '
        Me.ucrReceiverXEnd.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverXEnd, "ucrReceiverXEnd")
        Me.ucrReceiverXEnd.Name = "ucrReceiverXEnd"
        Me.ucrReceiverXEnd.Selector = Nothing
        Me.ucrReceiverXEnd.strNcFilePath = ""
        Me.ucrReceiverXEnd.ucrSelector = Nothing
        '
        'ucrReceiverSlopeX
        '
        Me.ucrReceiverSlopeX.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSlopeX, "ucrReceiverSlopeX")
        Me.ucrReceiverSlopeX.Name = "ucrReceiverSlopeX"
        Me.ucrReceiverSlopeX.Selector = Nothing
        Me.ucrReceiverSlopeX.strNcFilePath = ""
        Me.ucrReceiverSlopeX.ucrSelector = Nothing
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverX, "ucrReceiverX")
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrReceiverSlopeColour
        '
        Me.ucrReceiverSlopeColour.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSlopeColour, "ucrReceiverSlopeColour")
        Me.ucrReceiverSlopeColour.Name = "ucrReceiverSlopeColour"
        Me.ucrReceiverSlopeColour.Selector = Nothing
        Me.ucrReceiverSlopeColour.strNcFilePath = ""
        Me.ucrReceiverSlopeColour.ucrSelector = Nothing
        '
        'ucrFactorOptionalReceiver
        '
        Me.ucrFactorOptionalReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrFactorOptionalReceiver, "ucrFactorOptionalReceiver")
        Me.ucrFactorOptionalReceiver.Name = "ucrFactorOptionalReceiver"
        Me.ucrFactorOptionalReceiver.Selector = Nothing
        Me.ucrFactorOptionalReceiver.strNcFilePath = ""
        Me.ucrFactorOptionalReceiver.ucrSelector = Nothing
        '
        'ucrChkSlopeLineOptions
        '
        Me.ucrChkSlopeLineOptions.Checked = False
        resources.ApplyResources(Me.ucrChkSlopeLineOptions, "ucrChkSlopeLineOptions")
        Me.ucrChkSlopeLineOptions.Name = "ucrChkSlopeLineOptions"
        '
        'UcrNudSlopeYTextSize
        '
        Me.UcrNudSlopeYTextSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudSlopeYTextSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.UcrNudSlopeYTextSize, "UcrNudSlopeYTextSize")
        Me.UcrNudSlopeYTextSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudSlopeYTextSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudSlopeYTextSize.Name = "UcrNudSlopeYTextSize"
        Me.UcrNudSlopeYTextSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgLinePlot
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Tag = "Line_Plot"
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
