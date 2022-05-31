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
Partial Class dlgOneVarFitModel
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
        Me.LblVariable = New System.Windows.Forms.Label()
        Me.rdoTest = New System.Windows.Forms.RadioButton()
        Me.rdoGeneralCase = New System.Windows.Forms.RadioButton()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.cmdFittingOptions = New System.Windows.Forms.Button()
        Me.rdoEstimate = New System.Windows.Forms.RadioButton()
        Me.lblTests = New System.Windows.Forms.Label()
        Me.lblEstimate = New System.Windows.Forms.Label()
        Me.lblMeanCIMethod = New System.Windows.Forms.Label()
        Me.lblNullHypothesis = New System.Windows.Forms.Label()
        Me.lblCIMethods = New System.Windows.Forms.Label()
        Me.lblMethods = New System.Windows.Forms.Label()
        Me.lblMedianCIMethod = New System.Windows.Forms.Label()
        Me.lblVarCI = New System.Windows.Forms.Label()
        Me.lblQuantileCI = New System.Windows.Forms.Label()
        Me.lblSd = New System.Windows.Forms.Label()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.lblQuantile = New System.Windows.Forms.Label()
        Me.lblNullHyp = New System.Windows.Forms.Label()
        Me.lblNulHypothesis = New System.Windows.Forms.Label()
        Me.lblMonteCarlo = New System.Windows.Forms.Label()
        Me.lblQMethod = New System.Windows.Forms.Label()
        Me.lblConfidenceLevel = New System.Windows.Forms.Label()
        Me.tttests = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblSuccess = New System.Windows.Forms.Label()
        Me.ucrInputSuccess = New instat.ucrInputComboBox()
        Me.ucrInputConfidenceInterval = New instat.ucrInputComboBox()
        Me.ucrInputComboQMethod = New instat.ucrInputComboBox()
        Me.ucrInputTextM = New instat.ucrInputTextBox()
        Me.ucrInputNulHypothesis = New instat.ucrInputTextBox()
        Me.ucrInputTxtHypothesis = New instat.ucrInputTextBox()
        Me.ucrNudQuantile = New instat.ucrNud()
        Me.ucrInputComboConfidenceLevel = New instat.ucrInputComboBox()
        Me.ucrInputTxtSd = New instat.ucrInputTextBox()
        Me.ucrInputComboQuantilCI = New instat.ucrInputComboBox()
        Me.ucrInputComboMedianCI = New instat.ucrInputComboBox()
        Me.ucrInputComboVarianceCI = New instat.ucrInputComboBox()
        Me.ucrInputComboMethod = New instat.ucrInputComboBox()
        Me.ucrInputCIMethods = New instat.ucrInputComboBox()
        Me.ucrInputMeanCIMethod = New instat.ucrInputComboBox()
        Me.ucrInputNullHypothesis = New instat.ucrInputTextBox()
        Me.ucrInputComboEstimate = New instat.ucrInputComboBox()
        Me.ucrInputComboTests = New instat.ucrInputComboBox()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrChkConvertVariate = New instat.ucrCheck()
        Me.ucrPnlGeneralExactCase = New instat.UcrPanel()
        Me.ucrSaveModel = New instat.ucrSave()
        Me.ucrDistributionChoice = New instat.ucrDistributions()
        Me.ucrReceiverVariable = New instat.ucrReceiverSingle()
        Me.ucrSelectorOneVarFitMod = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'LblVariable
        '
        Me.LblVariable.AutoSize = True
        Me.LblVariable.Location = New System.Drawing.Point(232, 69)
        Me.LblVariable.Name = "LblVariable"
        Me.LblVariable.Size = New System.Drawing.Size(48, 13)
        Me.LblVariable.TabIndex = 8
        Me.LblVariable.Text = "Variable:"
        '
        'rdoTest
        '
        Me.rdoTest.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTest.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTest.FlatAppearance.BorderSize = 2
        Me.rdoTest.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTest.Location = New System.Drawing.Point(154, 11)
        Me.rdoTest.Name = "rdoTest"
        Me.rdoTest.Size = New System.Drawing.Size(122, 28)
        Me.rdoTest.TabIndex = 41
        Me.rdoTest.Text = "Test"
        Me.rdoTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTest.UseVisualStyleBackColor = True
        '
        'rdoGeneralCase
        '
        Me.rdoGeneralCase.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGeneralCase.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGeneralCase.FlatAppearance.BorderSize = 2
        Me.rdoGeneralCase.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGeneralCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGeneralCase.Location = New System.Drawing.Point(34, 11)
        Me.rdoGeneralCase.Name = "rdoGeneralCase"
        Me.rdoGeneralCase.Size = New System.Drawing.Size(122, 28)
        Me.rdoGeneralCase.TabIndex = 40
        Me.rdoGeneralCase.Text = "General Case"
        Me.rdoGeneralCase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGeneralCase.UseVisualStyleBackColor = True
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(295, 323)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(127, 23)
        Me.cmdDisplayOptions.TabIndex = 44
        Me.cmdDisplayOptions.Text = "Display Options"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'cmdFittingOptions
        '
        Me.cmdFittingOptions.Location = New System.Drawing.Point(295, 298)
        Me.cmdFittingOptions.Name = "cmdFittingOptions"
        Me.cmdFittingOptions.Size = New System.Drawing.Size(127, 23)
        Me.cmdFittingOptions.TabIndex = 43
        Me.cmdFittingOptions.Text = "Fitting Options"
        Me.cmdFittingOptions.UseVisualStyleBackColor = True
        '
        'rdoEstimate
        '
        Me.rdoEstimate.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoEstimate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEstimate.FlatAppearance.BorderSize = 2
        Me.rdoEstimate.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEstimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoEstimate.Location = New System.Drawing.Point(274, 11)
        Me.rdoEstimate.Name = "rdoEstimate"
        Me.rdoEstimate.Size = New System.Drawing.Size(122, 28)
        Me.rdoEstimate.TabIndex = 45
        Me.rdoEstimate.Text = "Estimate"
        Me.rdoEstimate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoEstimate.UseVisualStyleBackColor = True
        '
        'lblTests
        '
        Me.lblTests.AutoSize = True
        Me.lblTests.Location = New System.Drawing.Point(12, 256)
        Me.lblTests.Name = "lblTests"
        Me.lblTests.Size = New System.Drawing.Size(31, 13)
        Me.lblTests.TabIndex = 47
        Me.lblTests.Text = "Test:"
        '
        'lblEstimate
        '
        Me.lblEstimate.AutoSize = True
        Me.lblEstimate.Location = New System.Drawing.Point(12, 256)
        Me.lblEstimate.Name = "lblEstimate"
        Me.lblEstimate.Size = New System.Drawing.Size(50, 13)
        Me.lblEstimate.TabIndex = 49
        Me.lblEstimate.Text = "Estimate:"
        '
        'lblMeanCIMethod
        '
        Me.lblMeanCIMethod.AutoSize = True
        Me.lblMeanCIMethod.Location = New System.Drawing.Point(232, 169)
        Me.lblMeanCIMethod.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMeanCIMethod.Name = "lblMeanCIMethod"
        Me.lblMeanCIMethod.Size = New System.Drawing.Size(46, 13)
        Me.lblMeanCIMethod.TabIndex = 54
        Me.lblMeanCIMethod.Text = "Method:"
        '
        'lblNullHypothesis
        '
        Me.lblNullHypothesis.AutoSize = True
        Me.lblNullHypothesis.Location = New System.Drawing.Point(232, 169)
        Me.lblNullHypothesis.Name = "lblNullHypothesis"
        Me.lblNullHypothesis.Size = New System.Drawing.Size(83, 13)
        Me.lblNullHypothesis.TabIndex = 59
        Me.lblNullHypothesis.Text = "Null Hypothesis:"
        '
        'lblCIMethods
        '
        Me.lblCIMethods.AutoSize = True
        Me.lblCIMethods.Location = New System.Drawing.Point(232, 200)
        Me.lblCIMethods.Name = "lblCIMethods"
        Me.lblCIMethods.Size = New System.Drawing.Size(62, 13)
        Me.lblCIMethods.TabIndex = 62
        Me.lblCIMethods.Text = "C.I.Method:"
        '
        'lblMethods
        '
        Me.lblMethods.AutoSize = True
        Me.lblMethods.Location = New System.Drawing.Point(232, 200)
        Me.lblMethods.Name = "lblMethods"
        Me.lblMethods.Size = New System.Drawing.Size(46, 13)
        Me.lblMethods.TabIndex = 64
        Me.lblMethods.Text = "Method:"
        Me.lblMethods.UseWaitCursor = True
        '
        'lblMedianCIMethod
        '
        Me.lblMedianCIMethod.AutoSize = True
        Me.lblMedianCIMethod.Location = New System.Drawing.Point(232, 169)
        Me.lblMedianCIMethod.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMedianCIMethod.Name = "lblMedianCIMethod"
        Me.lblMedianCIMethod.Size = New System.Drawing.Size(94, 13)
        Me.lblMedianCIMethod.TabIndex = 68
        Me.lblMedianCIMethod.Text = "MedianCI Method:"
        '
        'lblVarCI
        '
        Me.lblVarCI.AutoSize = True
        Me.lblVarCI.Location = New System.Drawing.Point(232, 169)
        Me.lblVarCI.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVarCI.Name = "lblVarCI"
        Me.lblVarCI.Size = New System.Drawing.Size(75, 13)
        Me.lblVarCI.TabIndex = 69
        Me.lblVarCI.Text = "VarCI Method:"
        '
        'lblQuantileCI
        '
        Me.lblQuantileCI.AutoSize = True
        Me.lblQuantileCI.Location = New System.Drawing.Point(232, 169)
        Me.lblQuantileCI.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQuantileCI.Name = "lblQuantileCI"
        Me.lblQuantileCI.Size = New System.Drawing.Size(67, 13)
        Me.lblQuantileCI.TabIndex = 70
        Me.lblQuantileCI.Text = "Bootci.Type:"
        '
        'lblSd
        '
        Me.lblSd.AutoSize = True
        Me.lblSd.Location = New System.Drawing.Point(232, 200)
        Me.lblSd.Name = "lblSd"
        Me.lblSd.Size = New System.Drawing.Size(48, 13)
        Me.lblSd.TabIndex = 72
        Me.lblSd.Text = "Sd_Pop:"
        '
        'lblCI
        '
        Me.lblCI.AutoSize = True
        Me.lblCI.Location = New System.Drawing.Point(232, 143)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(102, 13)
        Me.lblCI.TabIndex = 74
        Me.lblCI.Text = "Confidence Interval:"
        '
        'lblQuantile
        '
        Me.lblQuantile.AutoSize = True
        Me.lblQuantile.Location = New System.Drawing.Point(232, 200)
        Me.lblQuantile.Name = "lblQuantile"
        Me.lblQuantile.Size = New System.Drawing.Size(49, 13)
        Me.lblQuantile.TabIndex = 76
        Me.lblQuantile.Text = "Quantile:"
        '
        'lblNullHyp
        '
        Me.lblNullHyp.AutoSize = True
        Me.lblNullHyp.Location = New System.Drawing.Point(232, 169)
        Me.lblNullHyp.Name = "lblNullHyp"
        Me.lblNullHyp.Size = New System.Drawing.Size(83, 13)
        Me.lblNullHyp.TabIndex = 78
        Me.lblNullHyp.Text = "Null Hypothesis:"
        '
        'lblNulHypothesis
        '
        Me.lblNulHypothesis.AutoSize = True
        Me.lblNulHypothesis.Location = New System.Drawing.Point(232, 169)
        Me.lblNulHypothesis.Name = "lblNulHypothesis"
        Me.lblNulHypothesis.Size = New System.Drawing.Size(83, 13)
        Me.lblNulHypothesis.TabIndex = 80
        Me.lblNulHypothesis.Text = "Null Hypothesis:"
        '
        'lblMonteCarlo
        '
        Me.lblMonteCarlo.AutoSize = True
        Me.lblMonteCarlo.Location = New System.Drawing.Point(232, 169)
        Me.lblMonteCarlo.Name = "lblMonteCarlo"
        Me.lblMonteCarlo.Size = New System.Drawing.Size(67, 13)
        Me.lblMonteCarlo.TabIndex = 82
        Me.lblMonteCarlo.Text = "Monte-Carlo:"
        '
        'lblQMethod
        '
        Me.lblQMethod.AutoSize = True
        Me.lblQMethod.Location = New System.Drawing.Point(232, 229)
        Me.lblQMethod.Name = "lblQMethod"
        Me.lblQMethod.Size = New System.Drawing.Size(60, 13)
        Me.lblQMethod.TabIndex = 84
        Me.lblQMethod.Text = "Q. Method:"
        '
        'lblConfidenceLevel
        '
        Me.lblConfidenceLevel.AutoSize = True
        Me.lblConfidenceLevel.Location = New System.Drawing.Point(232, 143)
        Me.lblConfidenceLevel.Name = "lblConfidenceLevel"
        Me.lblConfidenceLevel.Size = New System.Drawing.Size(93, 13)
        Me.lblConfidenceLevel.TabIndex = 86
        Me.lblConfidenceLevel.Text = "Confidence Level:"
        '
        'lblSuccess
        '
        Me.lblSuccess.AutoSize = True
        Me.lblSuccess.Location = New System.Drawing.Point(232, 229)
        Me.lblSuccess.Name = "lblSuccess"
        Me.lblSuccess.Size = New System.Drawing.Size(51, 13)
        Me.lblSuccess.TabIndex = 87
        Me.lblSuccess.Text = "Success:"
        '
        'ucrInputSuccess
        '
        Me.ucrInputSuccess.AddQuotesIfUnrecognised = True
        Me.ucrInputSuccess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSuccess.GetSetSelectedIndex = -1
        Me.ucrInputSuccess.IsReadOnly = False
        Me.ucrInputSuccess.Location = New System.Drawing.Point(350, 225)
        Me.ucrInputSuccess.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrInputSuccess.Name = "ucrInputSuccess"
        Me.ucrInputSuccess.Size = New System.Drawing.Size(71, 21)
        Me.ucrInputSuccess.TabIndex = 88
        Me.ucrInputSuccess.Visible = False
        '
        'ucrInputConfidenceInterval
        '
        Me.ucrInputConfidenceInterval.AddQuotesIfUnrecognised = True
        Me.ucrInputConfidenceInterval.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputConfidenceInterval.GetSetSelectedIndex = -1
        Me.ucrInputConfidenceInterval.IsReadOnly = False
        Me.ucrInputConfidenceInterval.Location = New System.Drawing.Point(350, 140)
        Me.ucrInputConfidenceInterval.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrInputConfidenceInterval.Name = "ucrInputConfidenceInterval"
        Me.ucrInputConfidenceInterval.Size = New System.Drawing.Size(71, 21)
        Me.ucrInputConfidenceInterval.TabIndex = 85
        '
        'ucrInputComboQMethod
        '
        Me.ucrInputComboQMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputComboQMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboQMethod.GetSetSelectedIndex = -1
        Me.ucrInputComboQMethod.IsReadOnly = False
        Me.ucrInputComboQMethod.Location = New System.Drawing.Point(350, 225)
        Me.ucrInputComboQMethod.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrInputComboQMethod.Name = "ucrInputComboQMethod"
        Me.ucrInputComboQMethod.Size = New System.Drawing.Size(71, 21)
        Me.ucrInputComboQMethod.TabIndex = 83
        '
        'ucrInputTextM
        '
        Me.ucrInputTextM.AddQuotesIfUnrecognised = True
        Me.ucrInputTextM.AutoSize = True
        Me.ucrInputTextM.IsMultiline = False
        Me.ucrInputTextM.IsReadOnly = False
        Me.ucrInputTextM.Location = New System.Drawing.Point(350, 166)
        Me.ucrInputTextM.Name = "ucrInputTextM"
        Me.ucrInputTextM.Size = New System.Drawing.Size(71, 21)
        Me.ucrInputTextM.TabIndex = 81
        '
        'ucrInputNulHypothesis
        '
        Me.ucrInputNulHypothesis.AddQuotesIfUnrecognised = True
        Me.ucrInputNulHypothesis.AutoSize = True
        Me.ucrInputNulHypothesis.IsMultiline = False
        Me.ucrInputNulHypothesis.IsReadOnly = False
        Me.ucrInputNulHypothesis.Location = New System.Drawing.Point(350, 166)
        Me.ucrInputNulHypothesis.Name = "ucrInputNulHypothesis"
        Me.ucrInputNulHypothesis.Size = New System.Drawing.Size(61, 21)
        Me.ucrInputNulHypothesis.TabIndex = 79
        '
        'ucrInputTxtHypothesis
        '
        Me.ucrInputTxtHypothesis.AddQuotesIfUnrecognised = True
        Me.ucrInputTxtHypothesis.AutoSize = True
        Me.ucrInputTxtHypothesis.IsMultiline = False
        Me.ucrInputTxtHypothesis.IsReadOnly = False
        Me.ucrInputTxtHypothesis.Location = New System.Drawing.Point(350, 166)
        Me.ucrInputTxtHypothesis.Name = "ucrInputTxtHypothesis"
        Me.ucrInputTxtHypothesis.Size = New System.Drawing.Size(61, 21)
        Me.ucrInputTxtHypothesis.TabIndex = 77
        '
        'ucrNudQuantile
        '
        Me.ucrNudQuantile.AutoSize = True
        Me.ucrNudQuantile.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudQuantile.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudQuantile.Location = New System.Drawing.Point(350, 195)
        Me.ucrNudQuantile.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudQuantile.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudQuantile.Name = "ucrNudQuantile"
        Me.ucrNudQuantile.Size = New System.Drawing.Size(71, 21)
        Me.ucrNudQuantile.TabIndex = 75
        Me.ucrNudQuantile.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputComboConfidenceLevel
        '
        Me.ucrInputComboConfidenceLevel.AddQuotesIfUnrecognised = True
        Me.ucrInputComboConfidenceLevel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboConfidenceLevel.GetSetSelectedIndex = -1
        Me.ucrInputComboConfidenceLevel.IsReadOnly = False
        Me.ucrInputComboConfidenceLevel.Location = New System.Drawing.Point(351, 140)
        Me.ucrInputComboConfidenceLevel.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrInputComboConfidenceLevel.Name = "ucrInputComboConfidenceLevel"
        Me.ucrInputComboConfidenceLevel.Size = New System.Drawing.Size(71, 21)
        Me.ucrInputComboConfidenceLevel.TabIndex = 73
        '
        'ucrInputTxtSd
        '
        Me.ucrInputTxtSd.AddQuotesIfUnrecognised = True
        Me.ucrInputTxtSd.AutoSize = True
        Me.ucrInputTxtSd.IsMultiline = False
        Me.ucrInputTxtSd.IsReadOnly = False
        Me.ucrInputTxtSd.Location = New System.Drawing.Point(350, 195)
        Me.ucrInputTxtSd.Name = "ucrInputTxtSd"
        Me.ucrInputTxtSd.Size = New System.Drawing.Size(61, 21)
        Me.ucrInputTxtSd.TabIndex = 71
        '
        'ucrInputComboQuantilCI
        '
        Me.ucrInputComboQuantilCI.AddQuotesIfUnrecognised = True
        Me.ucrInputComboQuantilCI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboQuantilCI.GetSetSelectedIndex = -1
        Me.ucrInputComboQuantilCI.IsReadOnly = False
        Me.ucrInputComboQuantilCI.Location = New System.Drawing.Point(350, 166)
        Me.ucrInputComboQuantilCI.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrInputComboQuantilCI.Name = "ucrInputComboQuantilCI"
        Me.ucrInputComboQuantilCI.Size = New System.Drawing.Size(71, 21)
        Me.ucrInputComboQuantilCI.TabIndex = 67
        '
        'ucrInputComboMedianCI
        '
        Me.ucrInputComboMedianCI.AddQuotesIfUnrecognised = True
        Me.ucrInputComboMedianCI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboMedianCI.GetSetSelectedIndex = -1
        Me.ucrInputComboMedianCI.IsReadOnly = False
        Me.ucrInputComboMedianCI.Location = New System.Drawing.Point(350, 166)
        Me.ucrInputComboMedianCI.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrInputComboMedianCI.Name = "ucrInputComboMedianCI"
        Me.ucrInputComboMedianCI.Size = New System.Drawing.Size(71, 21)
        Me.ucrInputComboMedianCI.TabIndex = 66
        '
        'ucrInputComboVarianceCI
        '
        Me.ucrInputComboVarianceCI.AddQuotesIfUnrecognised = True
        Me.ucrInputComboVarianceCI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboVarianceCI.GetSetSelectedIndex = -1
        Me.ucrInputComboVarianceCI.IsReadOnly = False
        Me.ucrInputComboVarianceCI.Location = New System.Drawing.Point(350, 166)
        Me.ucrInputComboVarianceCI.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrInputComboVarianceCI.Name = "ucrInputComboVarianceCI"
        Me.ucrInputComboVarianceCI.Size = New System.Drawing.Size(71, 21)
        Me.ucrInputComboVarianceCI.TabIndex = 65
        '
        'ucrInputComboMethod
        '
        Me.ucrInputComboMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputComboMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboMethod.GetSetSelectedIndex = -1
        Me.ucrInputComboMethod.IsReadOnly = False
        Me.ucrInputComboMethod.Location = New System.Drawing.Point(350, 195)
        Me.ucrInputComboMethod.Name = "ucrInputComboMethod"
        Me.ucrInputComboMethod.Size = New System.Drawing.Size(71, 21)
        Me.ucrInputComboMethod.TabIndex = 63
        '
        'ucrInputCIMethods
        '
        Me.ucrInputCIMethods.AddQuotesIfUnrecognised = True
        Me.ucrInputCIMethods.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCIMethods.GetSetSelectedIndex = -1
        Me.ucrInputCIMethods.IsReadOnly = False
        Me.ucrInputCIMethods.Location = New System.Drawing.Point(350, 195)
        Me.ucrInputCIMethods.Name = "ucrInputCIMethods"
        Me.ucrInputCIMethods.Size = New System.Drawing.Size(71, 21)
        Me.ucrInputCIMethods.TabIndex = 61
        '
        'ucrInputMeanCIMethod
        '
        Me.ucrInputMeanCIMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputMeanCIMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputMeanCIMethod.GetSetSelectedIndex = -1
        Me.ucrInputMeanCIMethod.IsReadOnly = False
        Me.ucrInputMeanCIMethod.Location = New System.Drawing.Point(350, 166)
        Me.ucrInputMeanCIMethod.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrInputMeanCIMethod.Name = "ucrInputMeanCIMethod"
        Me.ucrInputMeanCIMethod.Size = New System.Drawing.Size(71, 21)
        Me.ucrInputMeanCIMethod.TabIndex = 53
        '
        'ucrInputNullHypothesis
        '
        Me.ucrInputNullHypothesis.AddQuotesIfUnrecognised = True
        Me.ucrInputNullHypothesis.AutoSize = True
        Me.ucrInputNullHypothesis.IsMultiline = False
        Me.ucrInputNullHypothesis.IsReadOnly = False
        Me.ucrInputNullHypothesis.Location = New System.Drawing.Point(351, 166)
        Me.ucrInputNullHypothesis.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrInputNullHypothesis.Name = "ucrInputNullHypothesis"
        Me.ucrInputNullHypothesis.Size = New System.Drawing.Size(71, 21)
        Me.ucrInputNullHypothesis.TabIndex = 60
        '
        'ucrInputComboEstimate
        '
        Me.ucrInputComboEstimate.AddQuotesIfUnrecognised = True
        Me.ucrInputComboEstimate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboEstimate.GetSetSelectedIndex = -1
        Me.ucrInputComboEstimate.IsReadOnly = False
        Me.ucrInputComboEstimate.Location = New System.Drawing.Point(128, 252)
        Me.ucrInputComboEstimate.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrInputComboEstimate.Name = "ucrInputComboEstimate"
        Me.ucrInputComboEstimate.Size = New System.Drawing.Size(92, 21)
        Me.ucrInputComboEstimate.TabIndex = 48
        '
        'ucrInputComboTests
        '
        Me.ucrInputComboTests.AddQuotesIfUnrecognised = True
        Me.ucrInputComboTests.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboTests.GetSetSelectedIndex = -1
        Me.ucrInputComboTests.IsReadOnly = False
        Me.ucrInputComboTests.Location = New System.Drawing.Point(128, 252)
        Me.ucrInputComboTests.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrInputComboTests.Name = "ucrInputComboTests"
        Me.ucrInputComboTests.Size = New System.Drawing.Size(92, 21)
        Me.ucrInputComboTests.TabIndex = 46
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.AutoSize = True
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(10, 289)
        Me.ucrChkOmitMissing.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(277, 23)
        Me.ucrChkOmitMissing.TabIndex = 52
        '
        'ucrChkConvertVariate
        '
        Me.ucrChkConvertVariate.AutoSize = True
        Me.ucrChkConvertVariate.Checked = False
        Me.ucrChkConvertVariate.Location = New System.Drawing.Point(235, 110)
        Me.ucrChkConvertVariate.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkConvertVariate.Name = "ucrChkConvertVariate"
        Me.ucrChkConvertVariate.Size = New System.Drawing.Size(187, 23)
        Me.ucrChkConvertVariate.TabIndex = 42
        '
        'ucrPnlGeneralExactCase
        '
        Me.ucrPnlGeneralExactCase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlGeneralExactCase.Location = New System.Drawing.Point(34, 7)
        Me.ucrPnlGeneralExactCase.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrPnlGeneralExactCase.Name = "ucrPnlGeneralExactCase"
        Me.ucrPnlGeneralExactCase.Size = New System.Drawing.Size(371, 35)
        Me.ucrPnlGeneralExactCase.TabIndex = 39
        '
        'ucrSaveModel
        '
        Me.ucrSaveModel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveModel.Location = New System.Drawing.Point(10, 323)
        Me.ucrSaveModel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveModel.Name = "ucrSaveModel"
        Me.ucrSaveModel.Size = New System.Drawing.Size(277, 24)
        Me.ucrSaveModel.TabIndex = 38
        '
        'ucrDistributionChoice
        '
        Me.ucrDistributionChoice.AutoSize = True
        Me.ucrDistributionChoice.Location = New System.Drawing.Point(10, 249)
        Me.ucrDistributionChoice.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrDistributionChoice.Name = "ucrDistributionChoice"
        Me.ucrDistributionChoice.Size = New System.Drawing.Size(219, 30)
        Me.ucrDistributionChoice.TabIndex = 11
        '
        'ucrReceiverVariable
        '
        Me.ucrReceiverVariable.AutoSize = True
        Me.ucrReceiverVariable.frmParent = Me
        Me.ucrReceiverVariable.Location = New System.Drawing.Point(235, 82)
        Me.ucrReceiverVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVariable.Name = "ucrReceiverVariable"
        Me.ucrReceiverVariable.Selector = Nothing
        Me.ucrReceiverVariable.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverVariable.strNcFilePath = ""
        Me.ucrReceiverVariable.TabIndex = 2
        Me.ucrReceiverVariable.ucrSelector = Nothing
        '
        'ucrSelectorOneVarFitMod
        '
        Me.ucrSelectorOneVarFitMod.AutoSize = True
        Me.ucrSelectorOneVarFitMod.bDropUnusedFilterLevels = False
        Me.ucrSelectorOneVarFitMod.bShowHiddenColumns = False
        Me.ucrSelectorOneVarFitMod.bUseCurrentFilter = True
        Me.ucrSelectorOneVarFitMod.Location = New System.Drawing.Point(10, 46)
        Me.ucrSelectorOneVarFitMod.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOneVarFitMod.Name = "ucrSelectorOneVarFitMod"
        Me.ucrSelectorOneVarFitMod.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorOneVarFitMod.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 353)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 0
        '
        'dlgOneVarFitModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(428, 420)
        Me.Controls.Add(Me.ucrInputSuccess)
        Me.Controls.Add(Me.ucrInputConfidenceInterval)
        Me.Controls.Add(Me.ucrInputComboQMethod)
        Me.Controls.Add(Me.ucrInputTextM)
        Me.Controls.Add(Me.ucrInputNulHypothesis)
        Me.Controls.Add(Me.ucrInputTxtHypothesis)
        Me.Controls.Add(Me.ucrNudQuantile)
        Me.Controls.Add(Me.ucrInputComboConfidenceLevel)
        Me.Controls.Add(Me.ucrInputTxtSd)
        Me.Controls.Add(Me.ucrInputComboQuantilCI)
        Me.Controls.Add(Me.ucrInputComboMedianCI)
        Me.Controls.Add(Me.ucrInputComboVarianceCI)
        Me.Controls.Add(Me.ucrInputComboMethod)
        Me.Controls.Add(Me.ucrInputCIMethods)
        Me.Controls.Add(Me.ucrInputMeanCIMethod)
        Me.Controls.Add(Me.ucrInputNullHypothesis)
        Me.Controls.Add(Me.lblEstimate)
        Me.Controls.Add(Me.ucrInputComboEstimate)
        Me.Controls.Add(Me.lblTests)
        Me.Controls.Add(Me.ucrInputComboTests)
        Me.Controls.Add(Me.rdoEstimate)
        Me.Controls.Add(Me.ucrChkOmitMissing)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.ucrChkConvertVariate)
        Me.Controls.Add(Me.rdoTest)
        Me.Controls.Add(Me.cmdFittingOptions)
        Me.Controls.Add(Me.rdoGeneralCase)
        Me.Controls.Add(Me.ucrPnlGeneralExactCase)
        Me.Controls.Add(Me.ucrSaveModel)
        Me.Controls.Add(Me.ucrDistributionChoice)
        Me.Controls.Add(Me.LblVariable)
        Me.Controls.Add(Me.ucrReceiverVariable)
        Me.Controls.Add(Me.ucrSelectorOneVarFitMod)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblCI)
        Me.Controls.Add(Me.lblConfidenceLevel)
        Me.Controls.Add(Me.lblCIMethods)
        Me.Controls.Add(Me.lblQuantile)
        Me.Controls.Add(Me.lblSd)
        Me.Controls.Add(Me.lblMethods)
        Me.Controls.Add(Me.lblQuantileCI)
        Me.Controls.Add(Me.lblVarCI)
        Me.Controls.Add(Me.lblMedianCIMethod)
        Me.Controls.Add(Me.lblMeanCIMethod)
        Me.Controls.Add(Me.lblNullHypothesis)
        Me.Controls.Add(Me.lblMonteCarlo)
        Me.Controls.Add(Me.lblNulHypothesis)
        Me.Controls.Add(Me.lblNullHyp)
        Me.Controls.Add(Me.lblSuccess)
        Me.Controls.Add(Me.lblQMethod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneVarFitModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Variable Fit Model"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorOneVarFitMod As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverVariable As ucrReceiverSingle
    Friend WithEvents LblVariable As Label
    Friend WithEvents ucrDistributionChoice As ucrDistributions
    Friend WithEvents ucrSaveModel As ucrSave
    Friend WithEvents rdoTest As RadioButton
    Friend WithEvents rdoGeneralCase As RadioButton
    Friend WithEvents ucrPnlGeneralExactCase As UcrPanel
    Friend WithEvents ucrChkConvertVariate As ucrCheck
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents cmdFittingOptions As Button
    Friend WithEvents rdoEstimate As RadioButton
    Friend WithEvents ucrInputComboTests As ucrInputComboBox
    Friend WithEvents lblTests As Label
    Friend WithEvents ucrInputComboEstimate As ucrInputComboBox
    Friend WithEvents lblEstimate As Label
    Friend WithEvents ucrChkOmitMissing As ucrCheck
    Friend WithEvents lblMeanCIMethod As Label
    Friend WithEvents ucrInputMeanCIMethod As ucrInputComboBox
    Friend WithEvents ucrInputNullHypothesis As ucrInputTextBox
    Friend WithEvents lblNullHypothesis As Label
    Friend WithEvents lblCIMethods As Label
    Friend WithEvents ucrInputCIMethods As ucrInputComboBox
    Friend WithEvents lblMethods As Label
    Friend WithEvents ucrInputComboMethod As ucrInputComboBox
    Friend WithEvents ucrInputComboMedianCI As ucrInputComboBox
    Friend WithEvents ucrInputComboVarianceCI As ucrInputComboBox
    Friend WithEvents ucrInputComboQuantilCI As ucrInputComboBox
    Friend WithEvents lblQuantileCI As Label
    Friend WithEvents lblVarCI As Label
    Friend WithEvents lblMedianCIMethod As Label
    Friend WithEvents ucrInputTxtSd As ucrInputTextBox
    Friend WithEvents lblSd As Label
    Friend WithEvents ucrInputComboConfidenceLevel As ucrInputComboBox
    Friend WithEvents lblCI As Label
    Friend WithEvents lblQuantile As Label
    Friend WithEvents ucrNudQuantile As ucrNud
    Friend WithEvents lblNullHyp As Label
    Friend WithEvents ucrInputTxtHypothesis As ucrInputTextBox
    Friend WithEvents lblNulHypothesis As Label
    Friend WithEvents ucrInputNulHypothesis As ucrInputTextBox
    Friend WithEvents lblMonteCarlo As Label
    Friend WithEvents ucrInputTextM As ucrInputTextBox
    Friend WithEvents lblQMethod As Label
    Friend WithEvents ucrInputComboQMethod As ucrInputComboBox
    Friend WithEvents lblConfidenceLevel As Label
    Friend WithEvents ucrInputConfidenceInterval As ucrInputComboBox
    Friend WithEvents tttests As ToolTip
    Friend WithEvents ucrInputSuccess As ucrInputComboBox
    Friend WithEvents lblSuccess As Label
End Class