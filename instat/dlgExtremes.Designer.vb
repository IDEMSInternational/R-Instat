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
Partial Class dlgExtremes
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
        Me.cmdSqrt = New System.Windows.Forms.Button()
        Me.cmdLog = New System.Windows.Forms.Button()
        Me.cmdTan = New System.Windows.Forms.Button()
        Me.cmdExp = New System.Windows.Forms.Button()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.cmdSin = New System.Windows.Forms.Button()
        Me.grpSecondCalc = New System.Windows.Forms.GroupBox()
        Me.cmdCos = New System.Windows.Forms.Button()
        Me.grpFirstCalc = New System.Windows.Forms.GroupBox()
        Me.cmdMultiply = New System.Windows.Forms.Button()
        Me.cmdColon = New System.Windows.Forms.Button()
        Me.cmdPlus = New System.Windows.Forms.Button()
        Me.cmdPower = New System.Windows.Forms.Button()
        Me.cmdClosingBracket = New System.Windows.Forms.Button()
        Me.cmdOpeningBracket = New System.Windows.Forms.Button()
        Me.cmdDiv = New System.Windows.Forms.Button()
        Me.cmdDoubleBracket = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdZero = New System.Windows.Forms.Button()
        Me.cmdMinus = New System.Windows.Forms.Button()
        Me.lblFevdType = New System.Windows.Forms.Label()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.cmdFittingOptions = New System.Windows.Forms.Button()
        Me.lblDataToFit = New System.Windows.Forms.Label()
        Me.ucrInputThresholdforLocation = New instat.ucrInputTextBox()
        Me.ucrTryModelling = New instat.ucrTry()
        Me.ucrChkExplanatoryModelForLocationParameter = New instat.ucrCheck()
        Me.ucrReceiverExpressionExplanatoryModelForLocParam = New instat.ucrReceiverExpression()
        Me.ucrInputExtremes = New instat.ucrInputComboBox()
        Me.ucrSaveExtremes = New instat.ucrSave()
        Me.ucrSelectorExtremes = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverVariable = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpSecondCalc.SuspendLayout()
        Me.grpFirstCalc.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSqrt
        '
        Me.cmdSqrt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSqrt.Location = New System.Drawing.Point(4, 10)
        Me.cmdSqrt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSqrt.Name = "cmdSqrt"
        Me.cmdSqrt.Size = New System.Drawing.Size(56, 30)
        Me.cmdSqrt.TabIndex = 0
        Me.cmdSqrt.Text = "sqrt"
        Me.cmdSqrt.UseVisualStyleBackColor = True
        '
        'cmdLog
        '
        Me.cmdLog.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLog.Location = New System.Drawing.Point(4, 40)
        Me.cmdLog.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLog.Name = "cmdLog"
        Me.cmdLog.Size = New System.Drawing.Size(56, 30)
        Me.cmdLog.TabIndex = 2
        Me.cmdLog.Text = "log"
        Me.cmdLog.UseVisualStyleBackColor = True
        '
        'cmdTan
        '
        Me.cmdTan.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTan.Location = New System.Drawing.Point(60, 70)
        Me.cmdTan.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTan.Name = "cmdTan"
        Me.cmdTan.Size = New System.Drawing.Size(56, 30)
        Me.cmdTan.TabIndex = 5
        Me.cmdTan.Text = "tan"
        Me.cmdTan.UseVisualStyleBackColor = True
        '
        'cmdExp
        '
        Me.cmdExp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdExp.Location = New System.Drawing.Point(4, 70)
        Me.cmdExp.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdExp.Name = "cmdExp"
        Me.cmdExp.Size = New System.Drawing.Size(56, 30)
        Me.cmdExp.TabIndex = 4
        Me.cmdExp.Text = "exp"
        Me.cmdExp.UseVisualStyleBackColor = True
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblThreshold.Location = New System.Drawing.Point(10, 235)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(57, 13)
        Me.lblThreshold.TabIndex = 9
        Me.lblThreshold.Text = "Threshold:"
        '
        'cmdSin
        '
        Me.cmdSin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSin.Location = New System.Drawing.Point(60, 40)
        Me.cmdSin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSin.Name = "cmdSin"
        Me.cmdSin.Size = New System.Drawing.Size(56, 30)
        Me.cmdSin.TabIndex = 3
        Me.cmdSin.Text = "sin"
        Me.cmdSin.UseVisualStyleBackColor = True
        '
        'grpSecondCalc
        '
        Me.grpSecondCalc.Controls.Add(Me.cmdCos)
        Me.grpSecondCalc.Controls.Add(Me.cmdSqrt)
        Me.grpSecondCalc.Controls.Add(Me.cmdSin)
        Me.grpSecondCalc.Controls.Add(Me.cmdLog)
        Me.grpSecondCalc.Controls.Add(Me.cmdTan)
        Me.grpSecondCalc.Controls.Add(Me.cmdExp)
        Me.grpSecondCalc.Location = New System.Drawing.Point(390, 139)
        Me.grpSecondCalc.Name = "grpSecondCalc"
        Me.grpSecondCalc.Size = New System.Drawing.Size(119, 104)
        Me.grpSecondCalc.TabIndex = 6
        Me.grpSecondCalc.TabStop = False
        '
        'cmdCos
        '
        Me.cmdCos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCos.Location = New System.Drawing.Point(60, 10)
        Me.cmdCos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdCos.Name = "cmdCos"
        Me.cmdCos.Size = New System.Drawing.Size(56, 30)
        Me.cmdCos.TabIndex = 1
        Me.cmdCos.Text = "cos"
        Me.cmdCos.UseVisualStyleBackColor = True
        '
        'grpFirstCalc
        '
        Me.grpFirstCalc.Controls.Add(Me.cmdMultiply)
        Me.grpFirstCalc.Controls.Add(Me.cmdColon)
        Me.grpFirstCalc.Controls.Add(Me.cmdPlus)
        Me.grpFirstCalc.Controls.Add(Me.cmdPower)
        Me.grpFirstCalc.Controls.Add(Me.cmdClosingBracket)
        Me.grpFirstCalc.Controls.Add(Me.cmdOpeningBracket)
        Me.grpFirstCalc.Controls.Add(Me.cmdDiv)
        Me.grpFirstCalc.Controls.Add(Me.cmdDoubleBracket)
        Me.grpFirstCalc.Controls.Add(Me.cmdClear)
        Me.grpFirstCalc.Controls.Add(Me.cmdZero)
        Me.grpFirstCalc.Controls.Add(Me.cmdMinus)
        Me.grpFirstCalc.Location = New System.Drawing.Point(258, 139)
        Me.grpFirstCalc.Name = "grpFirstCalc"
        Me.grpFirstCalc.Size = New System.Drawing.Size(127, 104)
        Me.grpFirstCalc.TabIndex = 5
        Me.grpFirstCalc.TabStop = False
        '
        'cmdMultiply
        '
        Me.cmdMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdMultiply.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMultiply.Location = New System.Drawing.Point(64, 10)
        Me.cmdMultiply.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.Size = New System.Drawing.Size(29, 30)
        Me.cmdMultiply.TabIndex = 2
        Me.cmdMultiply.Text = "*"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdColon
        '
        Me.cmdColon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdColon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdColon.Location = New System.Drawing.Point(35, 10)
        Me.cmdColon.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdColon.Name = "cmdColon"
        Me.cmdColon.Size = New System.Drawing.Size(29, 30)
        Me.cmdColon.TabIndex = 1
        Me.cmdColon.Text = ":"
        Me.cmdColon.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        Me.cmdPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdPlus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlus.Location = New System.Drawing.Point(6, 10)
        Me.cmdPlus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.Size = New System.Drawing.Size(29, 30)
        Me.cmdPlus.TabIndex = 0
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        Me.cmdPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdPower.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPower.Location = New System.Drawing.Point(93, 40)
        Me.cmdPower.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.Size = New System.Drawing.Size(29, 30)
        Me.cmdPower.TabIndex = 7
        Me.cmdPower.Text = "^"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdClosingBracket
        '
        Me.cmdClosingBracket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdClosingBracket.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClosingBracket.Location = New System.Drawing.Point(64, 40)
        Me.cmdClosingBracket.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdClosingBracket.Name = "cmdClosingBracket"
        Me.cmdClosingBracket.Size = New System.Drawing.Size(29, 30)
        Me.cmdClosingBracket.TabIndex = 6
        Me.cmdClosingBracket.Text = ")"
        Me.cmdClosingBracket.UseVisualStyleBackColor = True
        '
        'cmdOpeningBracket
        '
        Me.cmdOpeningBracket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdOpeningBracket.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOpeningBracket.Location = New System.Drawing.Point(35, 40)
        Me.cmdOpeningBracket.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdOpeningBracket.Name = "cmdOpeningBracket"
        Me.cmdOpeningBracket.Size = New System.Drawing.Size(29, 30)
        Me.cmdOpeningBracket.TabIndex = 5
        Me.cmdOpeningBracket.Text = "("
        Me.cmdOpeningBracket.UseVisualStyleBackColor = True
        '
        'cmdDiv
        '
        Me.cmdDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdDiv.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDiv.Location = New System.Drawing.Point(93, 10)
        Me.cmdDiv.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDiv.Name = "cmdDiv"
        Me.cmdDiv.Size = New System.Drawing.Size(29, 30)
        Me.cmdDiv.TabIndex = 3
        Me.cmdDiv.Text = "/"
        Me.cmdDiv.UseVisualStyleBackColor = True
        '
        'cmdDoubleBracket
        '
        Me.cmdDoubleBracket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdDoubleBracket.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDoubleBracket.Location = New System.Drawing.Point(6, 40)
        Me.cmdDoubleBracket.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDoubleBracket.Name = "cmdDoubleBracket"
        Me.cmdDoubleBracket.Size = New System.Drawing.Size(29, 30)
        Me.cmdDoubleBracket.TabIndex = 4
        Me.cmdDoubleBracket.Text = "( )"
        Me.cmdDoubleBracket.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClear.Location = New System.Drawing.Point(64, 70)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(58, 30)
        Me.cmdClear.TabIndex = 10
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdZero
        '
        Me.cmdZero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!)
        Me.cmdZero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdZero.Location = New System.Drawing.Point(35, 70)
        Me.cmdZero.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdZero.Name = "cmdZero"
        Me.cmdZero.Size = New System.Drawing.Size(29, 30)
        Me.cmdZero.TabIndex = 9
        Me.cmdZero.Text = "l()"
        Me.cmdZero.UseVisualStyleBackColor = True
        '
        'cmdMinus
        '
        Me.cmdMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdMinus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMinus.Location = New System.Drawing.Point(6, 70)
        Me.cmdMinus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.Size = New System.Drawing.Size(29, 30)
        Me.cmdMinus.TabIndex = 8
        Me.cmdMinus.Text = "-"
        Me.cmdMinus.UseVisualStyleBackColor = True
        '
        'lblFevdType
        '
        Me.lblFevdType.AutoSize = True
        Me.lblFevdType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFevdType.Location = New System.Drawing.Point(10, 207)
        Me.lblFevdType.Name = "lblFevdType"
        Me.lblFevdType.Size = New System.Drawing.Size(62, 13)
        Me.lblFevdType.TabIndex = 7
        Me.lblFevdType.Text = "Distribution:"
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(401, 290)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(108, 23)
        Me.cmdDisplayOptions.TabIndex = 14
        Me.cmdDisplayOptions.Text = "Display Options"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'cmdFittingOptions
        '
        Me.cmdFittingOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFittingOptions.Location = New System.Drawing.Point(401, 261)
        Me.cmdFittingOptions.Name = "cmdFittingOptions"
        Me.cmdFittingOptions.Size = New System.Drawing.Size(108, 23)
        Me.cmdFittingOptions.TabIndex = 12
        Me.cmdFittingOptions.Text = "Fitting Options"
        Me.cmdFittingOptions.UseVisualStyleBackColor = True
        '
        'lblDataToFit
        '
        Me.lblDataToFit.AutoSize = True
        Me.lblDataToFit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataToFit.Location = New System.Drawing.Point(258, 45)
        Me.lblDataToFit.Name = "lblDataToFit"
        Me.lblDataToFit.Size = New System.Drawing.Size(99, 13)
        Me.lblDataToFit.TabIndex = 1
        Me.lblDataToFit.Tag = "Data_to_be_fitted"
        Me.lblDataToFit.Text = "Response Variable:"
        '
        'ucrInputThresholdforLocation
        '
        Me.ucrInputThresholdforLocation.AddQuotesIfUnrecognised = True
        Me.ucrInputThresholdforLocation.AutoSize = True
        Me.ucrInputThresholdforLocation.IsMultiline = False
        Me.ucrInputThresholdforLocation.IsReadOnly = False
        Me.ucrInputThresholdforLocation.Location = New System.Drawing.Point(79, 231)
        Me.ucrInputThresholdforLocation.Name = "ucrInputThresholdforLocation"
        Me.ucrInputThresholdforLocation.Size = New System.Drawing.Size(79, 21)
        Me.ucrInputThresholdforLocation.TabIndex = 10
        '
        'ucrTryModelling
        '
        Me.ucrTryModelling.AutoSize = True
        Me.ucrTryModelling.Location = New System.Drawing.Point(1, 258)
        Me.ucrTryModelling.Name = "ucrTryModelling"
        Me.ucrTryModelling.RunCommandAsMultipleLines = False
        Me.ucrTryModelling.Size = New System.Drawing.Size(389, 33)
        Me.ucrTryModelling.TabIndex = 11
        '
        'ucrChkExplanatoryModelForLocationParameter
        '
        Me.ucrChkExplanatoryModelForLocationParameter.AutoSize = True
        Me.ucrChkExplanatoryModelForLocationParameter.Checked = False
        Me.ucrChkExplanatoryModelForLocationParameter.Location = New System.Drawing.Point(258, 85)
        Me.ucrChkExplanatoryModelForLocationParameter.Name = "ucrChkExplanatoryModelForLocationParameter"
        Me.ucrChkExplanatoryModelForLocationParameter.Size = New System.Drawing.Size(270, 23)
        Me.ucrChkExplanatoryModelForLocationParameter.TabIndex = 3
        '
        'ucrReceiverExpressionExplanatoryModelForLocParam
        '
        Me.ucrReceiverExpressionExplanatoryModelForLocParam.AutoSize = True
        Me.ucrReceiverExpressionExplanatoryModelForLocParam.frmParent = Me
        Me.ucrReceiverExpressionExplanatoryModelForLocParam.Location = New System.Drawing.Point(258, 108)
        Me.ucrReceiverExpressionExplanatoryModelForLocParam.Name = "ucrReceiverExpressionExplanatoryModelForLocParam"
        Me.ucrReceiverExpressionExplanatoryModelForLocParam.Selector = Nothing
        Me.ucrReceiverExpressionExplanatoryModelForLocParam.Size = New System.Drawing.Size(251, 22)
        Me.ucrReceiverExpressionExplanatoryModelForLocParam.strNcFilePath = ""
        Me.ucrReceiverExpressionExplanatoryModelForLocParam.TabIndex = 4
        Me.ucrReceiverExpressionExplanatoryModelForLocParam.ucrSelector = Nothing
        '
        'ucrInputExtremes
        '
        Me.ucrInputExtremes.AddQuotesIfUnrecognised = True
        Me.ucrInputExtremes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputExtremes.GetSetSelectedIndex = -1
        Me.ucrInputExtremes.IsReadOnly = False
        Me.ucrInputExtremes.Location = New System.Drawing.Point(79, 204)
        Me.ucrInputExtremes.Name = "ucrInputExtremes"
        Me.ucrInputExtremes.Size = New System.Drawing.Size(79, 21)
        Me.ucrInputExtremes.TabIndex = 8
        '
        'ucrSaveExtremes
        '
        Me.ucrSaveExtremes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveExtremes.Location = New System.Drawing.Point(10, 292)
        Me.ucrSaveExtremes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveExtremes.Name = "ucrSaveExtremes"
        Me.ucrSaveExtremes.Size = New System.Drawing.Size(320, 22)
        Me.ucrSaveExtremes.TabIndex = 13
        '
        'ucrSelectorExtremes
        '
        Me.ucrSelectorExtremes.AutoSize = True
        Me.ucrSelectorExtremes.bDropUnusedFilterLevels = False
        Me.ucrSelectorExtremes.bShowHiddenColumns = False
        Me.ucrSelectorExtremes.bUseCurrentFilter = True
        Me.ucrSelectorExtremes.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorExtremes.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorExtremes.Name = "ucrSelectorExtremes"
        Me.ucrSelectorExtremes.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorExtremes.TabIndex = 0
        '
        'ucrReceiverVariable
        '
        Me.ucrReceiverVariable.AutoSize = True
        Me.ucrReceiverVariable.frmParent = Me
        Me.ucrReceiverVariable.Location = New System.Drawing.Point(258, 60)
        Me.ucrReceiverVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVariable.Name = "ucrReceiverVariable"
        Me.ucrReceiverVariable.Selector = Nothing
        Me.ucrReceiverVariable.Size = New System.Drawing.Size(127, 22)
        Me.ucrReceiverVariable.strNcFilePath = ""
        Me.ucrReceiverVariable.TabIndex = 2
        Me.ucrReceiverVariable.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 321)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 15
        '
        'dlgExtremes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(533, 378)
        Me.Controls.Add(Me.ucrInputThresholdforLocation)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.ucrTryModelling)
        Me.Controls.Add(Me.grpSecondCalc)
        Me.Controls.Add(Me.grpFirstCalc)
        Me.Controls.Add(Me.ucrChkExplanatoryModelForLocationParameter)
        Me.Controls.Add(Me.ucrReceiverExpressionExplanatoryModelForLocParam)
        Me.Controls.Add(Me.lblFevdType)
        Me.Controls.Add(Me.ucrInputExtremes)
        Me.Controls.Add(Me.ucrSaveExtremes)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.cmdFittingOptions)
        Me.Controls.Add(Me.ucrSelectorExtremes)
        Me.Controls.Add(Me.lblDataToFit)
        Me.Controls.Add(Me.ucrReceiverVariable)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExtremes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Fit_an_Extreme_distribution"
        Me.Text = "Fit an Extreme Distribution"
        Me.grpSecondCalc.ResumeLayout(False)
        Me.grpFirstCalc.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSqrt As Button
    Friend WithEvents cmdLog As Button
    Friend WithEvents cmdTan As Button
    Friend WithEvents cmdExp As Button
    Friend WithEvents ucrInputThresholdforLocation As ucrInputTextBox
    Friend WithEvents lblThreshold As Label
    Friend WithEvents ucrTryModelling As ucrTry
    Friend WithEvents cmdSin As Button
    Friend WithEvents grpSecondCalc As GroupBox
    Friend WithEvents cmdCos As Button
    Friend WithEvents grpFirstCalc As GroupBox
    Friend WithEvents cmdMultiply As Button
    Friend WithEvents cmdColon As Button
    Friend WithEvents cmdPlus As Button
    Friend WithEvents cmdPower As Button
    Friend WithEvents cmdClosingBracket As Button
    Friend WithEvents cmdOpeningBracket As Button
    Friend WithEvents cmdDiv As Button
    Friend WithEvents cmdDoubleBracket As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdZero As Button
    Friend WithEvents cmdMinus As Button
    Friend WithEvents ucrChkExplanatoryModelForLocationParameter As ucrCheck
    Friend WithEvents ucrReceiverExpressionExplanatoryModelForLocParam As ucrReceiverExpression
    Friend WithEvents lblFevdType As Label
    Friend WithEvents ucrInputExtremes As ucrInputComboBox
    Friend WithEvents ucrSaveExtremes As ucrSave
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents cmdFittingOptions As Button
    Friend WithEvents ucrSelectorExtremes As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblDataToFit As Label
    Friend WithEvents ucrReceiverVariable As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
End Class
