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
Partial Class dlgEnter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgEnter))
        Me.chkShowEnterArguments = New System.Windows.Forms.CheckBox()
        Me.lblData = New System.Windows.Forms.Label()
        Me.cmdQuotes = New System.Windows.Forms.Button()
        Me.cmdExponential = New System.Windows.Forms.Button()
        Me.cmdConcantenateFunction = New System.Windows.Forms.Button()
        Me.cmdSequenceFunction = New System.Windows.Forms.Button()
        Me.cmdRepelicationFunction = New System.Windows.Forms.Button()
        Me.cmdLogical = New System.Windows.Forms.Button()
        Me.cmdPi = New System.Windows.Forms.Button()
        Me.cmdLetters2 = New System.Windows.Forms.Button()
        Me.cmdMonths = New System.Windows.Forms.Button()
        Me.cmdColon = New System.Windows.Forms.Button()
        Me.grpEnterKeyboard2 = New System.Windows.Forms.GroupBox()
        Me.cmdText = New System.Windows.Forms.Button()
        Me.cmdFactor = New System.Windows.Forms.Button()
        Me.btnExample = New System.Windows.Forms.Button()
        Me.grpBasic = New System.Windows.Forms.GroupBox()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdBrackets = New System.Windows.Forms.Button()
        Me.cmdPower = New System.Windows.Forms.Button()
        Me.cmdDivide = New System.Windows.Forms.Button()
        Me.cmdPlus = New System.Windows.Forms.Button()
        Me.cmdMinus = New System.Windows.Forms.Button()
        Me.cmdMultiply = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmd9 = New System.Windows.Forms.Button()
        Me.cmd8 = New System.Windows.Forms.Button()
        Me.cmd7 = New System.Windows.Forms.Button()
        Me.cmd6 = New System.Windows.Forms.Button()
        Me.cmd5 = New System.Windows.Forms.Button()
        Me.cmd4 = New System.Windows.Forms.Button()
        Me.cmd3 = New System.Windows.Forms.Button()
        Me.cmd2 = New System.Windows.Forms.Button()
        Me.cmd0 = New System.Windows.Forms.Button()
        Me.cmd1 = New System.Windows.Forms.Button()
        Me.ttEnter = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrSaveEnterResultInto = New instat.ucrSave()
        Me.ucrTryModelling = New instat.ucrTry()
        Me.ucrDataFrameEnter = New instat.ucrDataFrame()
        Me.ucrReceiverForEnterCalculation = New instat.ucrReceiverExpression()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpEnterKeyboard2.SuspendLayout()
        Me.grpBasic.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkShowEnterArguments
        '
        resources.ApplyResources(Me.chkShowEnterArguments, "chkShowEnterArguments")
        Me.chkShowEnterArguments.Name = "chkShowEnterArguments"
        Me.chkShowEnterArguments.UseVisualStyleBackColor = True
        '
        'lblData
        '
        resources.ApplyResources(Me.lblData, "lblData")
        Me.lblData.Name = "lblData"
        Me.lblData.Tag = "Data"
        '
        'cmdQuotes
        '
        resources.ApplyResources(Me.cmdQuotes, "cmdQuotes")
        Me.cmdQuotes.Name = "cmdQuotes"
        Me.cmdQuotes.UseVisualStyleBackColor = True
        '
        'cmdExponential
        '
        resources.ApplyResources(Me.cmdExponential, "cmdExponential")
        Me.cmdExponential.Name = "cmdExponential"
        Me.cmdExponential.UseVisualStyleBackColor = True
        '
        'cmdConcantenateFunction
        '
        resources.ApplyResources(Me.cmdConcantenateFunction, "cmdConcantenateFunction")
        Me.cmdConcantenateFunction.Name = "cmdConcantenateFunction"
        Me.cmdConcantenateFunction.UseVisualStyleBackColor = True
        '
        'cmdSequenceFunction
        '
        resources.ApplyResources(Me.cmdSequenceFunction, "cmdSequenceFunction")
        Me.cmdSequenceFunction.Name = "cmdSequenceFunction"
        Me.cmdSequenceFunction.Tag = "Del"
        Me.cmdSequenceFunction.UseVisualStyleBackColor = True
        '
        'cmdRepelicationFunction
        '
        resources.ApplyResources(Me.cmdRepelicationFunction, "cmdRepelicationFunction")
        Me.cmdRepelicationFunction.Name = "cmdRepelicationFunction"
        Me.cmdRepelicationFunction.UseVisualStyleBackColor = True
        '
        'cmdLogical
        '
        resources.ApplyResources(Me.cmdLogical, "cmdLogical")
        Me.cmdLogical.Name = "cmdLogical"
        Me.cmdLogical.UseVisualStyleBackColor = True
        '
        'cmdPi
        '
        resources.ApplyResources(Me.cmdPi, "cmdPi")
        Me.cmdPi.Name = "cmdPi"
        Me.cmdPi.UseVisualStyleBackColor = True
        '
        'cmdLetters2
        '
        resources.ApplyResources(Me.cmdLetters2, "cmdLetters2")
        Me.cmdLetters2.Name = "cmdLetters2"
        Me.cmdLetters2.UseVisualStyleBackColor = True
        '
        'cmdMonths
        '
        resources.ApplyResources(Me.cmdMonths, "cmdMonths")
        Me.cmdMonths.Name = "cmdMonths"
        Me.cmdMonths.UseVisualStyleBackColor = True
        '
        'cmdColon
        '
        resources.ApplyResources(Me.cmdColon, "cmdColon")
        Me.cmdColon.Name = "cmdColon"
        Me.cmdColon.UseVisualStyleBackColor = True
        '
        'grpEnterKeyboard2
        '
        Me.grpEnterKeyboard2.Controls.Add(Me.cmdText)
        Me.grpEnterKeyboard2.Controls.Add(Me.cmdFactor)
        Me.grpEnterKeyboard2.Controls.Add(Me.cmdColon)
        Me.grpEnterKeyboard2.Controls.Add(Me.cmdMonths)
        Me.grpEnterKeyboard2.Controls.Add(Me.cmdLetters2)
        Me.grpEnterKeyboard2.Controls.Add(Me.cmdPi)
        Me.grpEnterKeyboard2.Controls.Add(Me.cmdLogical)
        Me.grpEnterKeyboard2.Controls.Add(Me.cmdRepelicationFunction)
        Me.grpEnterKeyboard2.Controls.Add(Me.cmdSequenceFunction)
        Me.grpEnterKeyboard2.Controls.Add(Me.cmdConcantenateFunction)
        Me.grpEnterKeyboard2.Controls.Add(Me.cmdExponential)
        Me.grpEnterKeyboard2.Controls.Add(Me.cmdQuotes)
        resources.ApplyResources(Me.grpEnterKeyboard2, "grpEnterKeyboard2")
        Me.grpEnterKeyboard2.Name = "grpEnterKeyboard2"
        Me.grpEnterKeyboard2.TabStop = False
        '
        'cmdText
        '
        resources.ApplyResources(Me.cmdText, "cmdText")
        Me.cmdText.Name = "cmdText"
        Me.cmdText.UseVisualStyleBackColor = True
        '
        'cmdFactor
        '
        resources.ApplyResources(Me.cmdFactor, "cmdFactor")
        Me.cmdFactor.Name = "cmdFactor"
        Me.cmdFactor.UseVisualStyleBackColor = True
        '
        'btnExample
        '
        resources.ApplyResources(Me.btnExample, "btnExample")
        Me.btnExample.Name = "btnExample"
        Me.btnExample.UseVisualStyleBackColor = True
        '
        'grpBasic
        '
        Me.grpBasic.Controls.Add(Me.cmdClear)
        Me.grpBasic.Controls.Add(Me.Button1)
        Me.grpBasic.Controls.Add(Me.cmdBrackets)
        Me.grpBasic.Controls.Add(Me.cmdPower)
        Me.grpBasic.Controls.Add(Me.cmdDivide)
        Me.grpBasic.Controls.Add(Me.cmdPlus)
        Me.grpBasic.Controls.Add(Me.cmdMinus)
        Me.grpBasic.Controls.Add(Me.cmdMultiply)
        Me.grpBasic.Controls.Add(Me.Button2)
        Me.grpBasic.Controls.Add(Me.cmd9)
        Me.grpBasic.Controls.Add(Me.cmd8)
        Me.grpBasic.Controls.Add(Me.cmd7)
        Me.grpBasic.Controls.Add(Me.cmd6)
        Me.grpBasic.Controls.Add(Me.cmd5)
        Me.grpBasic.Controls.Add(Me.cmd4)
        Me.grpBasic.Controls.Add(Me.cmd3)
        Me.grpBasic.Controls.Add(Me.cmd2)
        Me.grpBasic.Controls.Add(Me.cmd0)
        Me.grpBasic.Controls.Add(Me.cmd1)
        resources.ApplyResources(Me.grpBasic, "grpBasic")
        Me.grpBasic.Name = "grpBasic"
        Me.grpBasic.TabStop = False
        '
        'cmdClear
        '
        resources.ApplyResources(Me.cmdClear, "cmdClear")
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdBrackets
        '
        resources.ApplyResources(Me.cmdBrackets, "cmdBrackets")
        Me.cmdBrackets.Name = "cmdBrackets"
        Me.cmdBrackets.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        resources.ApplyResources(Me.cmdPower, "cmdPower")
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdDivide
        '
        resources.ApplyResources(Me.cmdDivide, "cmdDivide")
        Me.cmdDivide.Name = "cmdDivide"
        Me.cmdDivide.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        resources.ApplyResources(Me.cmdPlus, "cmdPlus")
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdMinus
        '
        resources.ApplyResources(Me.cmdMinus, "cmdMinus")
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        resources.ApplyResources(Me.cmdMultiply, "cmdMultiply")
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmd9
        '
        resources.ApplyResources(Me.cmd9, "cmd9")
        Me.cmd9.Name = "cmd9"
        Me.cmd9.UseVisualStyleBackColor = True
        '
        'cmd8
        '
        resources.ApplyResources(Me.cmd8, "cmd8")
        Me.cmd8.Name = "cmd8"
        Me.cmd8.UseVisualStyleBackColor = True
        '
        'cmd7
        '
        resources.ApplyResources(Me.cmd7, "cmd7")
        Me.cmd7.Name = "cmd7"
        Me.cmd7.UseVisualStyleBackColor = True
        '
        'cmd6
        '
        resources.ApplyResources(Me.cmd6, "cmd6")
        Me.cmd6.Name = "cmd6"
        Me.cmd6.UseVisualStyleBackColor = True
        '
        'cmd5
        '
        resources.ApplyResources(Me.cmd5, "cmd5")
        Me.cmd5.Name = "cmd5"
        Me.cmd5.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        resources.ApplyResources(Me.cmd4, "cmd4")
        Me.cmd4.Name = "cmd4"
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'cmd3
        '
        resources.ApplyResources(Me.cmd3, "cmd3")
        Me.cmd3.Name = "cmd3"
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        resources.ApplyResources(Me.cmd2, "cmd2")
        Me.cmd2.Name = "cmd2"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'cmd0
        '
        resources.ApplyResources(Me.cmd0, "cmd0")
        Me.cmd0.Name = "cmd0"
        Me.cmd0.UseVisualStyleBackColor = True
        '
        'cmd1
        '
        resources.ApplyResources(Me.cmd1, "cmd1")
        Me.cmd1.Name = "cmd1"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'ucrSaveEnterResultInto
        '
        resources.ApplyResources(Me.ucrSaveEnterResultInto, "ucrSaveEnterResultInto")
        Me.ucrSaveEnterResultInto.Name = "ucrSaveEnterResultInto"
        '
        'ucrTryModelling
        '
        resources.ApplyResources(Me.ucrTryModelling, "ucrTryModelling")
        Me.ucrTryModelling.Name = "ucrTryModelling"
        '
        'ucrDataFrameEnter
        '
        Me.ucrDataFrameEnter.bDropUnusedFilterLevels = False
        Me.ucrDataFrameEnter.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrDataFrameEnter, "ucrDataFrameEnter")
        Me.ucrDataFrameEnter.Name = "ucrDataFrameEnter"
        '
        'ucrReceiverForEnterCalculation
        '
        Me.ucrReceiverForEnterCalculation.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverForEnterCalculation, "ucrReceiverForEnterCalculation")
        Me.ucrReceiverForEnterCalculation.Name = "ucrReceiverForEnterCalculation"
        Me.ucrReceiverForEnterCalculation.Selector = Nothing
        Me.ucrReceiverForEnterCalculation.strNcFilePath = ""
        Me.ucrReceiverForEnterCalculation.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgEnter
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveEnterResultInto)
        Me.Controls.Add(Me.grpBasic)
        Me.Controls.Add(Me.btnExample)
        Me.Controls.Add(Me.ucrTryModelling)
        Me.Controls.Add(Me.grpEnterKeyboard2)
        Me.Controls.Add(Me.ucrDataFrameEnter)
        Me.Controls.Add(Me.chkShowEnterArguments)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.ucrReceiverForEnterCalculation)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgEnter"
        Me.grpEnterKeyboard2.ResumeLayout(False)
        Me.grpBasic.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkShowEnterArguments As CheckBox
    Friend WithEvents lblData As Label
    Friend WithEvents ucrReceiverForEnterCalculation As ucrReceiverExpression
    Friend WithEvents ucrDataFrameEnter As ucrDataFrame
    Friend WithEvents cmdQuotes As Button
    Friend WithEvents cmdExponential As Button
    Friend WithEvents cmdConcantenateFunction As Button
    Friend WithEvents cmdSequenceFunction As Button
    Friend WithEvents cmdRepelicationFunction As Button
    Friend WithEvents cmdLogical As Button
    Friend WithEvents cmdPi As Button
    Friend WithEvents cmdLetters2 As Button
    Friend WithEvents cmdMonths As Button
    Friend WithEvents cmdColon As Button
    Friend WithEvents grpEnterKeyboard2 As GroupBox
    Friend WithEvents ucrTryModelling As ucrTry
    Friend WithEvents btnExample As Button
    Friend WithEvents grpBasic As GroupBox
    Friend WithEvents cmdClear As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cmdBrackets As Button
    Friend WithEvents cmdPower As Button
    Friend WithEvents cmdDivide As Button
    Friend WithEvents cmdPlus As Button
    Friend WithEvents cmdMinus As Button
    Friend WithEvents cmdMultiply As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cmd9 As Button
    Friend WithEvents cmd8 As Button
    Friend WithEvents cmd7 As Button
    Friend WithEvents cmd6 As Button
    Friend WithEvents cmd5 As Button
    Friend WithEvents cmd4 As Button
    Friend WithEvents cmd3 As Button
    Friend WithEvents cmd2 As Button
    Friend WithEvents cmd0 As Button
    Friend WithEvents cmd1 As Button
    Friend WithEvents cmdFactor As Button
    Friend WithEvents cmdText As Button
    Friend WithEvents ucrSaveEnterResultInto As ucrSave
    Friend WithEvents ttEnter As ToolTip
End Class
