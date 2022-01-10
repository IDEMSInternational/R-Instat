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
Partial Class dlgFitModel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblResponseVariable = New System.Windows.Forms.Label()
        Me.cmdModelOptions = New System.Windows.Forms.Button()
        Me.lblModelPreview = New System.Windows.Forms.Label()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.lblExplanatoryModel = New System.Windows.Forms.Label()
        Me.cmdDiv = New System.Windows.Forms.Button()
        Me.grpFirstCalc = New System.Windows.Forms.GroupBox()
        Me.cmdMultiply = New System.Windows.Forms.Button()
        Me.cmdColon = New System.Windows.Forms.Button()
        Me.cmdPlus = New System.Windows.Forms.Button()
        Me.cmdPower = New System.Windows.Forms.Button()
        Me.cmdClosingBracket = New System.Windows.Forms.Button()
        Me.cmdOpeningBracket = New System.Windows.Forms.Button()
        Me.cmdDoubleBracket = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdZero = New System.Windows.Forms.Button()
        Me.cmdMinus = New System.Windows.Forms.Button()
        Me.grpSecondCalc = New System.Windows.Forms.GroupBox()
        Me.cmdCos = New System.Windows.Forms.Button()
        Me.cmdSqrt = New System.Windows.Forms.Button()
        Me.cmdSin = New System.Windows.Forms.Button()
        Me.cmdLog = New System.Windows.Forms.Button()
        Me.cmdTan = New System.Windows.Forms.Button()
        Me.cmdExp = New System.Windows.Forms.Button()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblRVType = New System.Windows.Forms.Label()
        Me.ucrTryModelling = New instat.ucrTry()
        Me.ucrModelName = New instat.ucrSave()
        Me.ucrChkConvertToVariate = New instat.ucrCheck()
        Me.ucrReceiverExpressionFitModel = New instat.ucrReceiverExpression()
        Me.ucrInputModelPreview = New instat.ucrInputTextBox()
        Me.ucrFamily = New instat.ucrDistributions()
        Me.ucrReceiverResponseVar = New instat.ucrReceiverSingle()
        Me.ucrSelectorByDataFrameAddRemoveForFitModel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpFirstCalc.SuspendLayout()
        Me.grpSecondCalc.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblResponseVariable
        '
        Me.lblResponseVariable.AutoSize = True
        Me.lblResponseVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResponseVariable.Location = New System.Drawing.Point(248, 43)
        Me.lblResponseVariable.Name = "lblResponseVariable"
        Me.lblResponseVariable.Size = New System.Drawing.Size(99, 13)
        Me.lblResponseVariable.TabIndex = 1
        Me.lblResponseVariable.Text = "Response Variable:"
        '
        'cmdModelOptions
        '
        Me.cmdModelOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdModelOptions.Location = New System.Drawing.Point(376, 286)
        Me.cmdModelOptions.Name = "cmdModelOptions"
        Me.cmdModelOptions.Size = New System.Drawing.Size(124, 23)
        Me.cmdModelOptions.TabIndex = 14
        Me.cmdModelOptions.Text = "Model Options"
        Me.cmdModelOptions.UseVisualStyleBackColor = True
        '
        'lblModelPreview
        '
        Me.lblModelPreview.AutoSize = True
        Me.lblModelPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblModelPreview.Location = New System.Drawing.Point(7, 291)
        Me.lblModelPreview.Name = "lblModelPreview"
        Me.lblModelPreview.Size = New System.Drawing.Size(80, 13)
        Me.lblModelPreview.TabIndex = 12
        Me.lblModelPreview.Text = "Model Preview:"
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(376, 314)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(124, 23)
        Me.cmdDisplayOptions.TabIndex = 15
        Me.cmdDisplayOptions.Text = "Display Options"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'lblExplanatoryModel
        '
        Me.lblExplanatoryModel.AutoSize = True
        Me.lblExplanatoryModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExplanatoryModel.Location = New System.Drawing.Point(249, 92)
        Me.lblExplanatoryModel.Name = "lblExplanatoryModel"
        Me.lblExplanatoryModel.Size = New System.Drawing.Size(97, 13)
        Me.lblExplanatoryModel.TabIndex = 4
        Me.lblExplanatoryModel.Text = "Explanatory Model:"
        '
        'cmdDiv
        '
        Me.cmdDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdDiv.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDiv.Location = New System.Drawing.Point(97, 10)
        Me.cmdDiv.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDiv.Name = "cmdDiv"
        Me.cmdDiv.Size = New System.Drawing.Size(29, 30)
        Me.cmdDiv.TabIndex = 3
        Me.cmdDiv.Text = "/"
        Me.cmdDiv.UseVisualStyleBackColor = True
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
        Me.grpFirstCalc.Location = New System.Drawing.Point(246, 133)
        Me.grpFirstCalc.Name = "grpFirstCalc"
        Me.grpFirstCalc.Size = New System.Drawing.Size(131, 111)
        Me.grpFirstCalc.TabIndex = 6
        Me.grpFirstCalc.TabStop = False
        '
        'cmdMultiply
        '
        Me.cmdMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdMultiply.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMultiply.Location = New System.Drawing.Point(67, 10)
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
        Me.cmdColon.Location = New System.Drawing.Point(37, 10)
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
        Me.cmdPlus.Location = New System.Drawing.Point(7, 10)
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
        Me.cmdPower.Location = New System.Drawing.Point(97, 41)
        Me.cmdPower.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.Size = New System.Drawing.Size(29, 32)
        Me.cmdPower.TabIndex = 7
        Me.cmdPower.Text = "^"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdClosingBracket
        '
        Me.cmdClosingBracket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdClosingBracket.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClosingBracket.Location = New System.Drawing.Point(67, 41)
        Me.cmdClosingBracket.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdClosingBracket.Name = "cmdClosingBracket"
        Me.cmdClosingBracket.Size = New System.Drawing.Size(29, 32)
        Me.cmdClosingBracket.TabIndex = 6
        Me.cmdClosingBracket.Text = ")"
        Me.cmdClosingBracket.UseVisualStyleBackColor = True
        '
        'cmdOpeningBracket
        '
        Me.cmdOpeningBracket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdOpeningBracket.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOpeningBracket.Location = New System.Drawing.Point(37, 41)
        Me.cmdOpeningBracket.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdOpeningBracket.Name = "cmdOpeningBracket"
        Me.cmdOpeningBracket.Size = New System.Drawing.Size(29, 32)
        Me.cmdOpeningBracket.TabIndex = 5
        Me.cmdOpeningBracket.Text = "("
        Me.cmdOpeningBracket.UseVisualStyleBackColor = True
        '
        'cmdDoubleBracket
        '
        Me.cmdDoubleBracket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdDoubleBracket.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDoubleBracket.Location = New System.Drawing.Point(7, 41)
        Me.cmdDoubleBracket.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDoubleBracket.Name = "cmdDoubleBracket"
        Me.cmdDoubleBracket.Size = New System.Drawing.Size(29, 32)
        Me.cmdDoubleBracket.TabIndex = 4
        Me.cmdDoubleBracket.Text = "( )"
        Me.cmdDoubleBracket.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClear.Location = New System.Drawing.Point(67, 74)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(60, 30)
        Me.cmdClear.TabIndex = 10
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdZero
        '
        Me.cmdZero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!)
        Me.cmdZero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdZero.Location = New System.Drawing.Point(37, 74)
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
        Me.cmdMinus.Location = New System.Drawing.Point(7, 74)
        Me.cmdMinus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.Size = New System.Drawing.Size(29, 30)
        Me.cmdMinus.TabIndex = 8
        Me.cmdMinus.Text = "-"
        Me.cmdMinus.UseVisualStyleBackColor = True
        '
        'grpSecondCalc
        '
        Me.grpSecondCalc.Controls.Add(Me.cmdCos)
        Me.grpSecondCalc.Controls.Add(Me.cmdSqrt)
        Me.grpSecondCalc.Controls.Add(Me.cmdSin)
        Me.grpSecondCalc.Controls.Add(Me.cmdLog)
        Me.grpSecondCalc.Controls.Add(Me.cmdTan)
        Me.grpSecondCalc.Controls.Add(Me.cmdExp)
        Me.grpSecondCalc.Location = New System.Drawing.Point(376, 133)
        Me.grpSecondCalc.Name = "grpSecondCalc"
        Me.grpSecondCalc.Size = New System.Drawing.Size(126, 111)
        Me.grpSecondCalc.TabIndex = 7
        Me.grpSecondCalc.TabStop = False
        '
        'cmdCos
        '
        Me.cmdCos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCos.Location = New System.Drawing.Point(62, 10)
        Me.cmdCos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdCos.Name = "cmdCos"
        Me.cmdCos.Size = New System.Drawing.Size(56, 30)
        Me.cmdCos.TabIndex = 1
        Me.cmdCos.Text = "cos"
        Me.cmdCos.UseVisualStyleBackColor = True
        '
        'cmdSqrt
        '
        Me.cmdSqrt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSqrt.Location = New System.Drawing.Point(5, 10)
        Me.cmdSqrt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSqrt.Name = "cmdSqrt"
        Me.cmdSqrt.Size = New System.Drawing.Size(56, 30)
        Me.cmdSqrt.TabIndex = 0
        Me.cmdSqrt.Text = "sqrt"
        Me.cmdSqrt.UseVisualStyleBackColor = True
        '
        'cmdSin
        '
        Me.cmdSin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSin.Location = New System.Drawing.Point(62, 42)
        Me.cmdSin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSin.Name = "cmdSin"
        Me.cmdSin.Size = New System.Drawing.Size(56, 30)
        Me.cmdSin.TabIndex = 3
        Me.cmdSin.Text = "sin"
        Me.cmdSin.UseVisualStyleBackColor = True
        '
        'cmdLog
        '
        Me.cmdLog.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLog.Location = New System.Drawing.Point(5, 42)
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
        Me.cmdTan.Location = New System.Drawing.Point(62, 74)
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
        Me.cmdExp.Location = New System.Drawing.Point(5, 74)
        Me.cmdExp.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdExp.Name = "cmdExp"
        Me.cmdExp.Size = New System.Drawing.Size(56, 30)
        Me.cmdExp.TabIndex = 4
        Me.cmdExp.Text = "exp"
        Me.cmdExp.UseVisualStyleBackColor = True
        '
        'lblType
        '
        Me.lblType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblType.Location = New System.Drawing.Point(159, 199)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(79, 16)
        Me.lblType.TabIndex = 9
        '
        'lblRVType
        '
        Me.lblRVType.AutoSize = True
        Me.lblRVType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRVType.Location = New System.Drawing.Point(9, 199)
        Me.lblRVType.Name = "lblRVType"
        Me.lblRVType.Size = New System.Drawing.Size(126, 13)
        Me.lblRVType.TabIndex = 8
        Me.lblRVType.Text = "Response Variable Type:"
        '
        'ucrTryModelling
        '
        Me.ucrTryModelling.AutoSize = True
        Me.ucrTryModelling.Location = New System.Drawing.Point(0, 252)
        Me.ucrTryModelling.Name = "ucrTryModelling"
        Me.ucrTryModelling.RunCommandAsMultipleLines = False
        Me.ucrTryModelling.Size = New System.Drawing.Size(480, 30)
        Me.ucrTryModelling.TabIndex = 11
        '
        'ucrModelName
        '
        Me.ucrModelName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrModelName.Location = New System.Drawing.Point(10, 315)
        Me.ucrModelName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrModelName.Name = "ucrModelName"
        Me.ucrModelName.Size = New System.Drawing.Size(302, 24)
        Me.ucrModelName.TabIndex = 16
        '
        'ucrChkConvertToVariate
        '
        Me.ucrChkConvertToVariate.AutoSize = True
        Me.ucrChkConvertToVariate.Checked = False
        Me.ucrChkConvertToVariate.Location = New System.Drawing.Point(382, 58)
        Me.ucrChkConvertToVariate.Name = "ucrChkConvertToVariate"
        Me.ucrChkConvertToVariate.Size = New System.Drawing.Size(120, 23)
        Me.ucrChkConvertToVariate.TabIndex = 3
        '
        'ucrReceiverExpressionFitModel
        '
        Me.ucrReceiverExpressionFitModel.AutoSize = True
        Me.ucrReceiverExpressionFitModel.frmParent = Me
        Me.ucrReceiverExpressionFitModel.Location = New System.Drawing.Point(247, 107)
        Me.ucrReceiverExpressionFitModel.Name = "ucrReceiverExpressionFitModel"
        Me.ucrReceiverExpressionFitModel.Selector = Nothing
        Me.ucrReceiverExpressionFitModel.Size = New System.Drawing.Size(256, 30)
        Me.ucrReceiverExpressionFitModel.strNcFilePath = ""
        Me.ucrReceiverExpressionFitModel.TabIndex = 5
        Me.ucrReceiverExpressionFitModel.ucrSelector = Nothing
        '
        'ucrInputModelPreview
        '
        Me.ucrInputModelPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputModelPreview.AutoSize = True
        Me.ucrInputModelPreview.IsMultiline = False
        Me.ucrInputModelPreview.IsReadOnly = False
        Me.ucrInputModelPreview.Location = New System.Drawing.Point(106, 287)
        Me.ucrInputModelPreview.Name = "ucrInputModelPreview"
        Me.ucrInputModelPreview.Size = New System.Drawing.Size(261, 21)
        Me.ucrInputModelPreview.TabIndex = 13
        '
        'ucrFamily
        '
        Me.ucrFamily.AutoSize = True
        Me.ucrFamily.Location = New System.Drawing.Point(10, 218)
        Me.ucrFamily.Name = "ucrFamily"
        Me.ucrFamily.Size = New System.Drawing.Size(207, 29)
        Me.ucrFamily.TabIndex = 10
        '
        'ucrReceiverResponseVar
        '
        Me.ucrReceiverResponseVar.AutoSize = True
        Me.ucrReceiverResponseVar.frmParent = Me
        Me.ucrReceiverResponseVar.Location = New System.Drawing.Point(247, 58)
        Me.ucrReceiverResponseVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverResponseVar.Name = "ucrReceiverResponseVar"
        Me.ucrReceiverResponseVar.Selector = Nothing
        Me.ucrReceiverResponseVar.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverResponseVar.strNcFilePath = ""
        Me.ucrReceiverResponseVar.TabIndex = 2
        Me.ucrReceiverResponseVar.ucrSelector = Nothing
        '
        'ucrSelectorByDataFrameAddRemoveForFitModel
        '
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.AutoSize = True
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.bDropUnusedFilterLevels = False
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.bShowHiddenColumns = False
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.bUseCurrentFilter = True
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.Name = "ucrSelectorByDataFrameAddRemoveForFitModel"
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 343)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 17
        '
        'dlgFitModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(510, 401)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblRVType)
        Me.Controls.Add(Me.ucrTryModelling)
        Me.Controls.Add(Me.ucrModelName)
        Me.Controls.Add(Me.ucrChkConvertToVariate)
        Me.Controls.Add(Me.grpSecondCalc)
        Me.Controls.Add(Me.grpFirstCalc)
        Me.Controls.Add(Me.ucrReceiverExpressionFitModel)
        Me.Controls.Add(Me.lblExplanatoryModel)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.ucrInputModelPreview)
        Me.Controls.Add(Me.lblModelPreview)
        Me.Controls.Add(Me.ucrFamily)
        Me.Controls.Add(Me.cmdModelOptions)
        Me.Controls.Add(Me.ucrReceiverResponseVar)
        Me.Controls.Add(Me.lblResponseVariable)
        Me.Controls.Add(Me.ucrSelectorByDataFrameAddRemoveForFitModel)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFitModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Fit_Model"
        Me.Text = "Fit Model"
        Me.grpFirstCalc.ResumeLayout(False)
        Me.grpSecondCalc.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorByDataFrameAddRemoveForFitModel As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblResponseVariable As Label
    Friend WithEvents ucrReceiverResponseVar As ucrReceiverSingle
    Friend WithEvents cmdModelOptions As Button
    Friend WithEvents ucrFamily As ucrDistributions
    Friend WithEvents lblModelPreview As Label
    Friend WithEvents ucrInputModelPreview As ucrInputTextBox
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents lblExplanatoryModel As Label
    Friend WithEvents ucrReceiverExpressionFitModel As ucrReceiverExpression
    Friend WithEvents cmdDiv As Button
    Friend WithEvents grpFirstCalc As GroupBox
    Friend WithEvents cmdMultiply As Button
    Friend WithEvents cmdColon As Button
    Friend WithEvents cmdPlus As Button
    Friend WithEvents cmdClosingBracket As Button
    Friend WithEvents cmdOpeningBracket As Button
    Friend WithEvents cmdDoubleBracket As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdZero As Button
    Friend WithEvents cmdMinus As Button
    Friend WithEvents grpSecondCalc As GroupBox
    Friend WithEvents cmdCos As Button
    Friend WithEvents cmdSqrt As Button
    Friend WithEvents cmdSin As Button
    Friend WithEvents cmdLog As Button
    Friend WithEvents cmdTan As Button
    Friend WithEvents cmdExp As Button
    Friend WithEvents cmdPower As Button
    Friend WithEvents ucrChkConvertToVariate As ucrCheck
    Friend WithEvents ucrModelName As ucrSave
    Friend WithEvents ucrTryModelling As ucrTry
    Friend WithEvents lblType As Label
    Friend WithEvents lblRVType As Label
End Class
