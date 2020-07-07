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
        Me.LblVariable = New System.Windows.Forms.Label()
        Me.rdoTest = New System.Windows.Forms.RadioButton()
        Me.rdoGeneralCase = New System.Windows.Forms.RadioButton()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.cmdFittingOptions = New System.Windows.Forms.Button()
        Me.rdoEstimate = New System.Windows.Forms.RadioButton()
        Me.lblTests = New System.Windows.Forms.Label()
        Me.lblEstimate = New System.Windows.Forms.Label()
        Me.lblTrim = New System.Windows.Forms.Label()
        Me.lblMethod = New System.Windows.Forms.Label()
        Me.lblConfidenceLevel = New System.Windows.Forms.Label()
        Me.grpParameters = New System.Windows.Forms.GroupBox()
        Me.lblDifferenceInMean = New System.Windows.Forms.Label()
        Me.ucrNudConfidenceLevel = New instat.ucrNud()
        Me.ucrNudHypothesis = New instat.ucrNud()
        Me.ucrNudTrim = New instat.ucrNud()
        Me.ucrInputMethod = New instat.ucrInputComboBox()
        Me.ucrInputComboEstimate = New instat.ucrInputComboBox()
        Me.ucrInputComboTests = New instat.ucrInputComboBox()
        Me.ucrOmmitMissing = New instat.ucrCheck()
        Me.ucrChkConvertVariate = New instat.ucrCheck()
        Me.ucrPnlGeneralExactCase = New instat.UcrPanel()
        Me.ucrSaveModel = New instat.ucrSave()
        Me.ucrDistributionChoice = New instat.ucrDistributions()
        Me.ucrReceiverVariable = New instat.ucrReceiverSingle()
        Me.ucrSelectorOneVarFitMod = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpParameters.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblVariable
        '
        Me.LblVariable.AutoSize = True
        Me.LblVariable.Location = New System.Drawing.Point(249, 47)
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
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(312, 323)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(92, 23)
        Me.cmdDisplayOptions.TabIndex = 44
        Me.cmdDisplayOptions.Text = "Display Options"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'cmdFittingOptions
        '
        Me.cmdFittingOptions.Location = New System.Drawing.Point(312, 298)
        Me.cmdFittingOptions.Name = "cmdFittingOptions"
        Me.cmdFittingOptions.Size = New System.Drawing.Size(92, 23)
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
        'lblTrim
        '
        Me.lblTrim.AutoSize = True
        Me.lblTrim.Location = New System.Drawing.Point(5, 23)
        Me.lblTrim.Name = "lblTrim"
        Me.lblTrim.Size = New System.Drawing.Size(30, 13)
        Me.lblTrim.TabIndex = 51
        Me.lblTrim.Text = "Trim:"
        '
        'lblMethod
        '
        Me.lblMethod.AutoSize = True
        Me.lblMethod.Location = New System.Drawing.Point(6, 105)
        Me.lblMethod.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMethod.Name = "lblMethod"
        Me.lblMethod.Size = New System.Drawing.Size(46, 13)
        Me.lblMethod.TabIndex = 54
        Me.lblMethod.Text = "Method:"
        '
        'lblConfidenceLevel
        '
        Me.lblConfidenceLevel.AutoSize = True
        Me.lblConfidenceLevel.Location = New System.Drawing.Point(5, 47)
        Me.lblConfidenceLevel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConfidenceLevel.Name = "lblConfidenceLevel"
        Me.lblConfidenceLevel.Size = New System.Drawing.Size(93, 13)
        Me.lblConfidenceLevel.TabIndex = 56
        Me.lblConfidenceLevel.Text = "Confidence Level:"
        '
        'grpParameters
        '
        Me.grpParameters.Controls.Add(Me.lblDifferenceInMean)
        Me.grpParameters.Controls.Add(Me.ucrNudConfidenceLevel)
        Me.grpParameters.Controls.Add(Me.ucrNudHypothesis)
        Me.grpParameters.Controls.Add(Me.ucrNudTrim)
        Me.grpParameters.Controls.Add(Me.lblMethod)
        Me.grpParameters.Controls.Add(Me.lblConfidenceLevel)
        Me.grpParameters.Controls.Add(Me.ucrInputMethod)
        Me.grpParameters.Controls.Add(Me.lblTrim)
        Me.grpParameters.Location = New System.Drawing.Point(263, 122)
        Me.grpParameters.Name = "grpParameters"
        Me.grpParameters.Size = New System.Drawing.Size(183, 137)
        Me.grpParameters.TabIndex = 57
        Me.grpParameters.TabStop = False
        Me.grpParameters.Text = "Parameters"
        '
        'lblDifferenceInMean
        '
        Me.lblDifferenceInMean.AutoSize = True
        Me.lblDifferenceInMean.Location = New System.Drawing.Point(5, 75)
        Me.lblDifferenceInMean.Name = "lblDifferenceInMean"
        Me.lblDifferenceInMean.Size = New System.Drawing.Size(101, 13)
        Me.lblDifferenceInMean.TabIndex = 59
        Me.lblDifferenceInMean.Text = "Difference In Mean:"
        '
        'ucrNudConfidenceLevel
        '
        Me.ucrNudConfidenceLevel.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudConfidenceLevel.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudConfidenceLevel.Location = New System.Drawing.Point(112, 43)
        Me.ucrNudConfidenceLevel.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudConfidenceLevel.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudConfidenceLevel.Name = "ucrNudConfidenceLevel"
        Me.ucrNudConfidenceLevel.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudConfidenceLevel.TabIndex = 58
        Me.ucrNudConfidenceLevel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudHypothesis
        '
        Me.ucrNudHypothesis.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHypothesis.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHypothesis.Location = New System.Drawing.Point(113, 72)
        Me.ucrNudHypothesis.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudHypothesis.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHypothesis.Name = "ucrNudHypothesis"
        Me.ucrNudHypothesis.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudHypothesis.TabIndex = 57
        Me.ucrNudHypothesis.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudTrim
        '
        Me.ucrNudTrim.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTrim.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTrim.Location = New System.Drawing.Point(112, 16)
        Me.ucrNudTrim.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudTrim.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTrim.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTrim.Name = "ucrNudTrim"
        Me.ucrNudTrim.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTrim.TabIndex = 50
        Me.ucrNudTrim.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputMethod
        '
        Me.ucrInputMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputMethod.IsReadOnly = False
        Me.ucrInputMethod.Location = New System.Drawing.Point(81, 100)
        Me.ucrInputMethod.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrInputMethod.Name = "ucrInputMethod"
        Me.ucrInputMethod.Size = New System.Drawing.Size(81, 21)
        Me.ucrInputMethod.TabIndex = 53
        '
        'ucrInputComboEstimate
        '
        Me.ucrInputComboEstimate.AddQuotesIfUnrecognised = True
        Me.ucrInputComboEstimate.IsReadOnly = False
        Me.ucrInputComboEstimate.Location = New System.Drawing.Point(66, 252)
        Me.ucrInputComboEstimate.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrInputComboEstimate.Name = "ucrInputComboEstimate"
        Me.ucrInputComboEstimate.Size = New System.Drawing.Size(92, 21)
        Me.ucrInputComboEstimate.TabIndex = 48
        '
        'ucrInputComboTests
        '
        Me.ucrInputComboTests.AddQuotesIfUnrecognised = True
        Me.ucrInputComboTests.IsReadOnly = False
        Me.ucrInputComboTests.Location = New System.Drawing.Point(45, 252)
        Me.ucrInputComboTests.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrInputComboTests.Name = "ucrInputComboTests"
        Me.ucrInputComboTests.Size = New System.Drawing.Size(92, 21)
        Me.ucrInputComboTests.TabIndex = 46
        '
        'ucrOmmitMissing
        '
        Me.ucrOmmitMissing.Checked = False
        Me.ucrOmmitMissing.Location = New System.Drawing.Point(404, 94)
        Me.ucrOmmitMissing.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrOmmitMissing.Name = "ucrOmmitMissing"
        Me.ucrOmmitMissing.Size = New System.Drawing.Size(120, 20)
        Me.ucrOmmitMissing.TabIndex = 52
        '
        'ucrChkConvertVariate
        '
        Me.ucrChkConvertVariate.Checked = False
        Me.ucrChkConvertVariate.Location = New System.Drawing.Point(242, 94)
        Me.ucrChkConvertVariate.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkConvertVariate.Name = "ucrChkConvertVariate"
        Me.ucrChkConvertVariate.Size = New System.Drawing.Size(156, 20)
        Me.ucrChkConvertVariate.TabIndex = 42
        '
        'ucrPnlGeneralExactCase
        '
        Me.ucrPnlGeneralExactCase.Location = New System.Drawing.Point(34, 7)
        Me.ucrPnlGeneralExactCase.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrPnlGeneralExactCase.Name = "ucrPnlGeneralExactCase"
        Me.ucrPnlGeneralExactCase.Size = New System.Drawing.Size(371, 35)
        Me.ucrPnlGeneralExactCase.TabIndex = 39
        '
        'ucrSaveModel
        '
        Me.ucrSaveModel.Location = New System.Drawing.Point(10, 323)
        Me.ucrSaveModel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveModel.Name = "ucrSaveModel"
        Me.ucrSaveModel.Size = New System.Drawing.Size(277, 24)
        Me.ucrSaveModel.TabIndex = 38
        '
        'ucrDistributionChoice
        '
        Me.ucrDistributionChoice.Location = New System.Drawing.Point(10, 249)
        Me.ucrDistributionChoice.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrDistributionChoice.Name = "ucrDistributionChoice"
        Me.ucrDistributionChoice.Size = New System.Drawing.Size(219, 30)
        Me.ucrDistributionChoice.TabIndex = 11
        '
        'ucrReceiverVariable
        '
        Me.ucrReceiverVariable.frmParent = Me
        Me.ucrReceiverVariable.Location = New System.Drawing.Point(249, 64)
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
        Me.ucrSelectorOneVarFitMod.bDropUnusedFilterLevels = False
        Me.ucrSelectorOneVarFitMod.bShowHiddenColumns = False
        Me.ucrSelectorOneVarFitMod.bUseCurrentFilter = True
        Me.ucrSelectorOneVarFitMod.Location = New System.Drawing.Point(10, 46)
        Me.ucrSelectorOneVarFitMod.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOneVarFitMod.Name = "ucrSelectorOneVarFitMod"
        Me.ucrSelectorOneVarFitMod.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorOneVarFitMod.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 353)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'dlgOneVarFitModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 420)
        Me.Controls.Add(Me.grpParameters)
        Me.Controls.Add(Me.lblEstimate)
        Me.Controls.Add(Me.ucrInputComboEstimate)
        Me.Controls.Add(Me.lblTests)
        Me.Controls.Add(Me.ucrInputComboTests)
        Me.Controls.Add(Me.rdoEstimate)
        Me.Controls.Add(Me.ucrOmmitMissing)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneVarFitModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Variable Fit Model"
        Me.grpParameters.ResumeLayout(False)
        Me.grpParameters.PerformLayout()
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
    Friend WithEvents ucrNudTrim As ucrNud
    Friend WithEvents lblTrim As Label
    Friend WithEvents ucrOmmitMissing As ucrCheck
    Friend WithEvents lblMethod As Label
    Friend WithEvents ucrInputMethod As ucrInputComboBox
    Friend WithEvents lblConfidenceLevel As Label
    Friend WithEvents grpParameters As GroupBox
    Friend WithEvents ucrNudConfidenceLevel As ucrNud
    Friend WithEvents ucrNudHypothesis As ucrNud
    Friend WithEvents lblDifferenceInMean As Label
End Class