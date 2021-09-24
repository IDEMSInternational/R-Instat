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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgFitModel))
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
        resources.ApplyResources(Me.lblResponseVariable, "lblResponseVariable")
        Me.lblResponseVariable.Name = "lblResponseVariable"
        '
        'cmdModelOptions
        '
        resources.ApplyResources(Me.cmdModelOptions, "cmdModelOptions")
        Me.cmdModelOptions.Name = "cmdModelOptions"
        Me.cmdModelOptions.UseVisualStyleBackColor = True
        '
        'lblModelPreview
        '
        resources.ApplyResources(Me.lblModelPreview, "lblModelPreview")
        Me.lblModelPreview.Name = "lblModelPreview"
        '
        'cmdDisplayOptions
        '
        resources.ApplyResources(Me.cmdDisplayOptions, "cmdDisplayOptions")
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'lblExplanatoryModel
        '
        resources.ApplyResources(Me.lblExplanatoryModel, "lblExplanatoryModel")
        Me.lblExplanatoryModel.Name = "lblExplanatoryModel"
        '
        'cmdDiv
        '
        resources.ApplyResources(Me.cmdDiv, "cmdDiv")
        Me.cmdDiv.Name = "cmdDiv"
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
        'cmdSqrt
        '
        resources.ApplyResources(Me.cmdSqrt, "cmdSqrt")
        Me.cmdSqrt.Name = "cmdSqrt"
        Me.cmdSqrt.UseVisualStyleBackColor = True
        '
        'cmdSin
        '
        resources.ApplyResources(Me.cmdSin, "cmdSin")
        Me.cmdSin.Name = "cmdSin"
        Me.cmdSin.UseVisualStyleBackColor = True
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
        'lblType
        '
        Me.lblType.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.lblType, "lblType")
        Me.lblType.Name = "lblType"
        '
        'lblRVType
        '
        resources.ApplyResources(Me.lblRVType, "lblRVType")
        Me.lblRVType.Name = "lblRVType"
        '
        'ucrTryModelling
        '
        resources.ApplyResources(Me.ucrTryModelling, "ucrTryModelling")
        Me.ucrTryModelling.Name = "ucrTryModelling"
        '
        'ucrModelName
        '
        resources.ApplyResources(Me.ucrModelName, "ucrModelName")
        Me.ucrModelName.Name = "ucrModelName"
        '
        'ucrChkConvertToVariate
        '
        Me.ucrChkConvertToVariate.Checked = False
        resources.ApplyResources(Me.ucrChkConvertToVariate, "ucrChkConvertToVariate")
        Me.ucrChkConvertToVariate.Name = "ucrChkConvertToVariate"
        '
        'ucrReceiverExpressionFitModel
        '
        Me.ucrReceiverExpressionFitModel.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverExpressionFitModel, "ucrReceiverExpressionFitModel")
        Me.ucrReceiverExpressionFitModel.Name = "ucrReceiverExpressionFitModel"
        Me.ucrReceiverExpressionFitModel.Selector = Nothing
        Me.ucrReceiverExpressionFitModel.strNcFilePath = ""
        Me.ucrReceiverExpressionFitModel.ucrSelector = Nothing
        '
        'ucrInputModelPreview
        '
        Me.ucrInputModelPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputModelPreview.IsMultiline = False
        Me.ucrInputModelPreview.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputModelPreview, "ucrInputModelPreview")
        Me.ucrInputModelPreview.Name = "ucrInputModelPreview"
        '
        'ucrFamily
        '
        resources.ApplyResources(Me.ucrFamily, "ucrFamily")
        Me.ucrFamily.Name = "ucrFamily"
        '
        'ucrReceiverResponseVar
        '
        Me.ucrReceiverResponseVar.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverResponseVar, "ucrReceiverResponseVar")
        Me.ucrReceiverResponseVar.Name = "ucrReceiverResponseVar"
        Me.ucrReceiverResponseVar.Selector = Nothing
        Me.ucrReceiverResponseVar.strNcFilePath = ""
        Me.ucrReceiverResponseVar.ucrSelector = Nothing
        '
        'ucrSelectorByDataFrameAddRemoveForFitModel
        '
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.bDropUnusedFilterLevels = False
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.bShowHiddenColumns = False
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorByDataFrameAddRemoveForFitModel, "ucrSelectorByDataFrameAddRemoveForFitModel")
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.Name = "ucrSelectorByDataFrameAddRemoveForFitModel"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgFitModel
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Tag = "Fit_Model"
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
