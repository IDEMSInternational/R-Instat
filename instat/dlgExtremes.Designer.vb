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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgExtremes))
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
        resources.ApplyResources(Me.cmdSqrt, "cmdSqrt")
        Me.cmdSqrt.Name = "cmdSqrt"
        Me.cmdSqrt.UseVisualStyleBackColor = True
        '
        'cmdLog
        '
        resources.ApplyResources(Me.cmdLog, "cmdLog")
        Me.cmdLog.Name = "cmdLog"
        Me.cmdLog.UseVisualStyleBackColor = True
        '
        'cmdTan
        '
        resources.ApplyResources(Me.cmdTan, "cmdTan")
        Me.cmdTan.Name = "cmdTan"
        Me.cmdTan.UseVisualStyleBackColor = True
        '
        'cmdExp
        '
        resources.ApplyResources(Me.cmdExp, "cmdExp")
        Me.cmdExp.Name = "cmdExp"
        Me.cmdExp.UseVisualStyleBackColor = True
        '
        'lblThreshold
        '
        resources.ApplyResources(Me.lblThreshold, "lblThreshold")
        Me.lblThreshold.Name = "lblThreshold"
        '
        'cmdSin
        '
        resources.ApplyResources(Me.cmdSin, "cmdSin")
        Me.cmdSin.Name = "cmdSin"
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
        resources.ApplyResources(Me.grpSecondCalc, "grpSecondCalc")
        Me.grpSecondCalc.Name = "grpSecondCalc"
        Me.grpSecondCalc.TabStop = False
        '
        'cmdCos
        '
        resources.ApplyResources(Me.cmdCos, "cmdCos")
        Me.cmdCos.Name = "cmdCos"
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
        resources.ApplyResources(Me.grpFirstCalc, "grpFirstCalc")
        Me.grpFirstCalc.Name = "grpFirstCalc"
        Me.grpFirstCalc.TabStop = False
        '
        'cmdMultiply
        '
        resources.ApplyResources(Me.cmdMultiply, "cmdMultiply")
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdColon
        '
        resources.ApplyResources(Me.cmdColon, "cmdColon")
        Me.cmdColon.Name = "cmdColon"
        Me.cmdColon.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        resources.ApplyResources(Me.cmdPlus, "cmdPlus")
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        resources.ApplyResources(Me.cmdPower, "cmdPower")
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdClosingBracket
        '
        resources.ApplyResources(Me.cmdClosingBracket, "cmdClosingBracket")
        Me.cmdClosingBracket.Name = "cmdClosingBracket"
        Me.cmdClosingBracket.UseVisualStyleBackColor = True
        '
        'cmdOpeningBracket
        '
        resources.ApplyResources(Me.cmdOpeningBracket, "cmdOpeningBracket")
        Me.cmdOpeningBracket.Name = "cmdOpeningBracket"
        Me.cmdOpeningBracket.UseVisualStyleBackColor = True
        '
        'cmdDiv
        '
        resources.ApplyResources(Me.cmdDiv, "cmdDiv")
        Me.cmdDiv.Name = "cmdDiv"
        Me.cmdDiv.UseVisualStyleBackColor = True
        '
        'cmdDoubleBracket
        '
        resources.ApplyResources(Me.cmdDoubleBracket, "cmdDoubleBracket")
        Me.cmdDoubleBracket.Name = "cmdDoubleBracket"
        Me.cmdDoubleBracket.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        resources.ApplyResources(Me.cmdClear, "cmdClear")
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdZero
        '
        resources.ApplyResources(Me.cmdZero, "cmdZero")
        Me.cmdZero.Name = "cmdZero"
        Me.cmdZero.UseVisualStyleBackColor = True
        '
        'cmdMinus
        '
        resources.ApplyResources(Me.cmdMinus, "cmdMinus")
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.UseVisualStyleBackColor = True
        '
        'lblFevdType
        '
        resources.ApplyResources(Me.lblFevdType, "lblFevdType")
        Me.lblFevdType.Name = "lblFevdType"
        '
        'cmdDisplayOptions
        '
        resources.ApplyResources(Me.cmdDisplayOptions, "cmdDisplayOptions")
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'cmdFittingOptions
        '
        resources.ApplyResources(Me.cmdFittingOptions, "cmdFittingOptions")
        Me.cmdFittingOptions.Name = "cmdFittingOptions"
        Me.cmdFittingOptions.UseVisualStyleBackColor = True
        '
        'lblDataToFit
        '
        resources.ApplyResources(Me.lblDataToFit, "lblDataToFit")
        Me.lblDataToFit.Name = "lblDataToFit"
        Me.lblDataToFit.Tag = "Data_to_be_fitted"
        '
        'ucrInputThresholdforLocation
        '
        Me.ucrInputThresholdforLocation.AddQuotesIfUnrecognised = True
        Me.ucrInputThresholdforLocation.IsMultiline = False
        Me.ucrInputThresholdforLocation.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputThresholdforLocation, "ucrInputThresholdforLocation")
        Me.ucrInputThresholdforLocation.Name = "ucrInputThresholdforLocation"
        '
        'ucrTryModelling
        '
        resources.ApplyResources(Me.ucrTryModelling, "ucrTryModelling")
        Me.ucrTryModelling.Name = "ucrTryModelling"
        '
        'ucrChkExplanatoryModelForLocationParameter
        '
        Me.ucrChkExplanatoryModelForLocationParameter.Checked = False
        resources.ApplyResources(Me.ucrChkExplanatoryModelForLocationParameter, "ucrChkExplanatoryModelForLocationParameter")
        Me.ucrChkExplanatoryModelForLocationParameter.Name = "ucrChkExplanatoryModelForLocationParameter"
        '
        'ucrReceiverExpressionExplanatoryModelForLocParam
        '
        Me.ucrReceiverExpressionExplanatoryModelForLocParam.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverExpressionExplanatoryModelForLocParam, "ucrReceiverExpressionExplanatoryModelForLocParam")
        Me.ucrReceiverExpressionExplanatoryModelForLocParam.Name = "ucrReceiverExpressionExplanatoryModelForLocParam"
        Me.ucrReceiverExpressionExplanatoryModelForLocParam.Selector = Nothing
        Me.ucrReceiverExpressionExplanatoryModelForLocParam.strNcFilePath = ""
        Me.ucrReceiverExpressionExplanatoryModelForLocParam.ucrSelector = Nothing
        '
        'ucrInputExtremes
        '
        Me.ucrInputExtremes.AddQuotesIfUnrecognised = True
        Me.ucrInputExtremes.GetSetSelectedIndex = -1
        Me.ucrInputExtremes.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputExtremes, "ucrInputExtremes")
        Me.ucrInputExtremes.Name = "ucrInputExtremes"
        '
        'ucrSaveExtremes
        '
        resources.ApplyResources(Me.ucrSaveExtremes, "ucrSaveExtremes")
        Me.ucrSaveExtremes.Name = "ucrSaveExtremes"
        '
        'ucrSelectorExtremes
        '
        Me.ucrSelectorExtremes.bDropUnusedFilterLevels = False
        Me.ucrSelectorExtremes.bShowHiddenColumns = False
        Me.ucrSelectorExtremes.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorExtremes, "ucrSelectorExtremes")
        Me.ucrSelectorExtremes.Name = "ucrSelectorExtremes"
        '
        'ucrReceiverVariable
        '
        Me.ucrReceiverVariable.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverVariable, "ucrReceiverVariable")
        Me.ucrReceiverVariable.Name = "ucrReceiverVariable"
        Me.ucrReceiverVariable.Selector = Nothing
        Me.ucrReceiverVariable.strNcFilePath = ""
        Me.ucrReceiverVariable.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgExtremes
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Tag = "Fit_an_Extreme_distribution"
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
