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
        Me.chkShowEnterArguments.AutoSize = True
        Me.chkShowEnterArguments.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkShowEnterArguments.Location = New System.Drawing.Point(307, 18)
        Me.chkShowEnterArguments.Name = "chkShowEnterArguments"
        Me.chkShowEnterArguments.Size = New System.Drawing.Size(109, 17)
        Me.chkShowEnterArguments.TabIndex = 155
        Me.chkShowEnterArguments.Text = "Show Parameters"
        Me.chkShowEnterArguments.UseVisualStyleBackColor = True
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblData.Location = New System.Drawing.Point(10, 20)
        Me.lblData.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(33, 13)
        Me.lblData.TabIndex = 152
        Me.lblData.Tag = "Data"
        Me.lblData.Text = "Data:"
        '
        'cmdQuotes
        '
        Me.cmdQuotes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQuotes.Location = New System.Drawing.Point(100, 101)
        Me.cmdQuotes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdQuotes.Name = "cmdQuotes"
        Me.cmdQuotes.Size = New System.Drawing.Size(49, 30)
        Me.cmdQuotes.TabIndex = 142
        Me.cmdQuotes.Text = """ """
        Me.cmdQuotes.UseVisualStyleBackColor = True
        '
        'cmdExponential
        '
        Me.cmdExponential.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdExponential.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdExponential.Location = New System.Drawing.Point(52, 101)
        Me.cmdExponential.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdExponential.Name = "cmdExponential"
        Me.cmdExponential.Size = New System.Drawing.Size(49, 30)
        Me.cmdExponential.TabIndex = 143
        Me.cmdExponential.Text = "E"
        Me.cmdExponential.UseVisualStyleBackColor = True
        '
        'cmdConcantenateFunction
        '
        Me.cmdConcantenateFunction.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConcantenateFunction.Location = New System.Drawing.Point(4, 101)
        Me.cmdConcantenateFunction.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdConcantenateFunction.Name = "cmdConcantenateFunction"
        Me.cmdConcantenateFunction.Size = New System.Drawing.Size(49, 30)
        Me.cmdConcantenateFunction.TabIndex = 145
        Me.cmdConcantenateFunction.Text = "c( )"
        Me.cmdConcantenateFunction.UseVisualStyleBackColor = True
        '
        'cmdSequenceFunction
        '
        Me.cmdSequenceFunction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdSequenceFunction.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSequenceFunction.Location = New System.Drawing.Point(4, 72)
        Me.cmdSequenceFunction.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSequenceFunction.Name = "cmdSequenceFunction"
        Me.cmdSequenceFunction.Size = New System.Drawing.Size(49, 30)
        Me.cmdSequenceFunction.TabIndex = 147
        Me.cmdSequenceFunction.Tag = "Del"
        Me.cmdSequenceFunction.Text = "seq"
        Me.cmdSequenceFunction.UseVisualStyleBackColor = True
        '
        'cmdRepelicationFunction
        '
        Me.cmdRepelicationFunction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdRepelicationFunction.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRepelicationFunction.Location = New System.Drawing.Point(4, 43)
        Me.cmdRepelicationFunction.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdRepelicationFunction.Name = "cmdRepelicationFunction"
        Me.cmdRepelicationFunction.Size = New System.Drawing.Size(49, 30)
        Me.cmdRepelicationFunction.TabIndex = 148
        Me.cmdRepelicationFunction.Text = "rep"
        Me.cmdRepelicationFunction.UseVisualStyleBackColor = True
        '
        'cmdLogical
        '
        Me.cmdLogical.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLogical.Location = New System.Drawing.Point(100, 72)
        Me.cmdLogical.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLogical.Name = "cmdLogical"
        Me.cmdLogical.Size = New System.Drawing.Size(49, 30)
        Me.cmdLogical.TabIndex = 149
        Me.cmdLogical.Text = "logical"
        Me.cmdLogical.UseVisualStyleBackColor = True
        '
        'cmdPi
        '
        Me.cmdPi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPi.Location = New System.Drawing.Point(52, 72)
        Me.cmdPi.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPi.Name = "cmdPi"
        Me.cmdPi.Size = New System.Drawing.Size(49, 30)
        Me.cmdPi.TabIndex = 149
        Me.cmdPi.Text = "pi"
        Me.cmdPi.UseVisualStyleBackColor = True
        '
        'cmdLetters2
        '
        Me.cmdLetters2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLetters2.Location = New System.Drawing.Point(52, 14)
        Me.cmdLetters2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLetters2.Name = "cmdLetters2"
        Me.cmdLetters2.Size = New System.Drawing.Size(49, 30)
        Me.cmdLetters2.TabIndex = 152
        Me.cmdLetters2.Text = "letters"
        Me.cmdLetters2.UseVisualStyleBackColor = True
        '
        'cmdMonths
        '
        Me.cmdMonths.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMonths.Location = New System.Drawing.Point(52, 43)
        Me.cmdMonths.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMonths.Name = "cmdMonths"
        Me.cmdMonths.Size = New System.Drawing.Size(49, 30)
        Me.cmdMonths.TabIndex = 151
        Me.cmdMonths.Text = "months "
        Me.cmdMonths.UseVisualStyleBackColor = True
        '
        'cmdColon
        '
        Me.cmdColon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdColon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdColon.Location = New System.Drawing.Point(4, 14)
        Me.cmdColon.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdColon.Name = "cmdColon"
        Me.cmdColon.Size = New System.Drawing.Size(49, 30)
        Me.cmdColon.TabIndex = 151
        Me.cmdColon.Text = "[:]"
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
        Me.grpEnterKeyboard2.Location = New System.Drawing.Point(378, 50)
        Me.grpEnterKeyboard2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpEnterKeyboard2.Name = "grpEnterKeyboard2"
        Me.grpEnterKeyboard2.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpEnterKeyboard2.Size = New System.Drawing.Size(156, 134)
        Me.grpEnterKeyboard2.TabIndex = 159
        Me.grpEnterKeyboard2.TabStop = False
        '
        'cmdText
        '
        Me.cmdText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdText.Location = New System.Drawing.Point(100, 43)
        Me.cmdText.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdText.Name = "cmdText"
        Me.cmdText.Size = New System.Drawing.Size(49, 30)
        Me.cmdText.TabIndex = 155
        Me.cmdText.Text = "text"
        Me.cmdText.UseVisualStyleBackColor = True
        '
        'cmdFactor
        '
        Me.cmdFactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFactor.Location = New System.Drawing.Point(100, 14)
        Me.cmdFactor.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdFactor.Name = "cmdFactor"
        Me.cmdFactor.Size = New System.Drawing.Size(49, 30)
        Me.cmdFactor.TabIndex = 153
        Me.cmdFactor.Text = "factor "
        Me.cmdFactor.UseVisualStyleBackColor = True
        '
        'btnExample
        '
        Me.btnExample.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExample.Location = New System.Drawing.Point(436, 16)
        Me.btnExample.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExample.Name = "btnExample"
        Me.btnExample.Size = New System.Drawing.Size(64, 22)
        Me.btnExample.TabIndex = 161
        Me.btnExample.Text = "Examples"
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
        Me.grpBasic.Location = New System.Drawing.Point(170, 51)
        Me.grpBasic.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpBasic.Name = "grpBasic"
        Me.grpBasic.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpBasic.Size = New System.Drawing.Size(205, 134)
        Me.grpBasic.TabIndex = 180
        Me.grpBasic.TabStop = False
        '
        'cmdClear
        '
        Me.cmdClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClear.Location = New System.Drawing.Point(151, 71)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(49, 60)
        Me.cmdClear.TabIndex = 190
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(3, 100)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 30)
        Me.Button1.TabIndex = 138
        Me.Button1.Text = ","
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdBrackets
        '
        Me.cmdBrackets.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBrackets.Location = New System.Drawing.Point(77, 100)
        Me.cmdBrackets.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdBrackets.Name = "cmdBrackets"
        Me.cmdBrackets.Size = New System.Drawing.Size(38, 30)
        Me.cmdBrackets.TabIndex = 136
        Me.cmdBrackets.Text = "( )"
        Me.cmdBrackets.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        Me.cmdPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdPower.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPower.Location = New System.Drawing.Point(151, 42)
        Me.cmdPower.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.Size = New System.Drawing.Size(49, 30)
        Me.cmdPower.TabIndex = 133
        Me.cmdPower.Text = "^"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdDivide
        '
        Me.cmdDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdDivide.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDivide.Location = New System.Drawing.Point(114, 13)
        Me.cmdDivide.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDivide.Name = "cmdDivide"
        Me.cmdDivide.Size = New System.Drawing.Size(38, 30)
        Me.cmdDivide.TabIndex = 131
        Me.cmdDivide.Text = "/"
        Me.cmdDivide.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        Me.cmdPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdPlus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlus.Location = New System.Drawing.Point(114, 100)
        Me.cmdPlus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.Size = New System.Drawing.Size(38, 30)
        Me.cmdPlus.TabIndex = 130
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdMinus
        '
        Me.cmdMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdMinus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMinus.Location = New System.Drawing.Point(114, 71)
        Me.cmdMinus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.Size = New System.Drawing.Size(38, 30)
        Me.cmdMinus.TabIndex = 129
        Me.cmdMinus.Text = "-"
        Me.cmdMinus.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        Me.cmdMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdMultiply.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMultiply.Location = New System.Drawing.Point(114, 42)
        Me.cmdMultiply.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.Size = New System.Drawing.Size(38, 30)
        Me.cmdMultiply.TabIndex = 128
        Me.cmdMultiply.Text = "*"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(151, 13)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 30)
        Me.Button2.TabIndex = 127
        Me.Button2.Text = "."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmd9
        '
        Me.cmd9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd9.Location = New System.Drawing.Point(77, 13)
        Me.cmd9.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd9.Name = "cmd9"
        Me.cmd9.Size = New System.Drawing.Size(38, 30)
        Me.cmd9.TabIndex = 126
        Me.cmd9.Text = "9"
        Me.cmd9.UseVisualStyleBackColor = True
        '
        'cmd8
        '
        Me.cmd8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd8.Location = New System.Drawing.Point(40, 13)
        Me.cmd8.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd8.Name = "cmd8"
        Me.cmd8.Size = New System.Drawing.Size(38, 30)
        Me.cmd8.TabIndex = 125
        Me.cmd8.Text = "8"
        Me.cmd8.UseVisualStyleBackColor = True
        '
        'cmd7
        '
        Me.cmd7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd7.Location = New System.Drawing.Point(3, 13)
        Me.cmd7.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd7.Name = "cmd7"
        Me.cmd7.Size = New System.Drawing.Size(38, 30)
        Me.cmd7.TabIndex = 124
        Me.cmd7.Text = "7"
        Me.cmd7.UseVisualStyleBackColor = True
        '
        'cmd6
        '
        Me.cmd6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd6.Location = New System.Drawing.Point(77, 42)
        Me.cmd6.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd6.Name = "cmd6"
        Me.cmd6.Size = New System.Drawing.Size(38, 30)
        Me.cmd6.TabIndex = 123
        Me.cmd6.Text = "6"
        Me.cmd6.UseVisualStyleBackColor = True
        '
        'cmd5
        '
        Me.cmd5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd5.Location = New System.Drawing.Point(40, 42)
        Me.cmd5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(38, 30)
        Me.cmd5.TabIndex = 122
        Me.cmd5.Text = "5"
        Me.cmd5.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        Me.cmd4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd4.Location = New System.Drawing.Point(3, 42)
        Me.cmd4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(38, 30)
        Me.cmd4.TabIndex = 121
        Me.cmd4.Text = "4"
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'cmd3
        '
        Me.cmd3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd3.Location = New System.Drawing.Point(77, 71)
        Me.cmd3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(38, 30)
        Me.cmd3.TabIndex = 120
        Me.cmd3.Text = "3"
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        Me.cmd2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd2.Location = New System.Drawing.Point(40, 71)
        Me.cmd2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(38, 30)
        Me.cmd2.TabIndex = 119
        Me.cmd2.Text = "2"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'cmd0
        '
        Me.cmd0.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd0.Location = New System.Drawing.Point(40, 100)
        Me.cmd0.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd0.Name = "cmd0"
        Me.cmd0.Size = New System.Drawing.Size(38, 30)
        Me.cmd0.TabIndex = 118
        Me.cmd0.Text = "0"
        Me.cmd0.UseVisualStyleBackColor = True
        '
        'cmd1
        '
        Me.cmd1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd1.Location = New System.Drawing.Point(3, 71)
        Me.cmd1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(38, 30)
        Me.cmd1.TabIndex = 117
        Me.cmd1.Text = "1"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'ucrSaveEnterResultInto
        '
        Me.ucrSaveEnterResultInto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveEnterResultInto.Location = New System.Drawing.Point(11, 243)
        Me.ucrSaveEnterResultInto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveEnterResultInto.Name = "ucrSaveEnterResultInto"
        Me.ucrSaveEnterResultInto.Size = New System.Drawing.Size(280, 22)
        Me.ucrSaveEnterResultInto.TabIndex = 181
        '
        'ucrTryModelling
        '
        Me.ucrTryModelling.AutoSize = True
        Me.ucrTryModelling.Location = New System.Drawing.Point(3, 202)
        Me.ucrTryModelling.Name = "ucrTryModelling"
        Me.ucrTryModelling.RunCommandAsMultipleLines = False
        Me.ucrTryModelling.Size = New System.Drawing.Size(480, 33)
        Me.ucrTryModelling.TabIndex = 160
        '
        'ucrDataFrameEnter
        '
        Me.ucrDataFrameEnter.AutoSize = True
        Me.ucrDataFrameEnter.bDropUnusedFilterLevels = False
        Me.ucrDataFrameEnter.bUseCurrentFilter = True
        Me.ucrDataFrameEnter.Location = New System.Drawing.Point(11, 55)
        Me.ucrDataFrameEnter.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameEnter.Name = "ucrDataFrameEnter"
        Me.ucrDataFrameEnter.Size = New System.Drawing.Size(151, 43)
        Me.ucrDataFrameEnter.TabIndex = 156
        '
        'ucrReceiverForEnterCalculation
        '
        Me.ucrReceiverForEnterCalculation.AutoSize = True
        Me.ucrReceiverForEnterCalculation.frmParent = Me
        Me.ucrReceiverForEnterCalculation.Location = New System.Drawing.Point(69, 16)
        Me.ucrReceiverForEnterCalculation.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrReceiverForEnterCalculation.Name = "ucrReceiverForEnterCalculation"
        Me.ucrReceiverForEnterCalculation.Selector = Nothing
        Me.ucrReceiverForEnterCalculation.Size = New System.Drawing.Size(229, 28)
        Me.ucrReceiverForEnterCalculation.strNcFilePath = ""
        Me.ucrReceiverForEnterCalculation.TabIndex = 153
        Me.ucrReceiverForEnterCalculation.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(11, 278)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 0
        '
        'dlgEnter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(538, 336)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter"
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
