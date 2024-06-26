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
        Me.ucrReceiverForEnterCalculation = New instat.ucrReceiverExpression()
        Me.ucrBase = New instat.ucrButtons()
        Me.cmdRHelp = New instat.ucrSplitButton()
        Me.ContextMenuStripBase = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuBase = New System.Windows.Forms.ToolStripMenuItem()
        Me.ucrSelectorEnter = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkStoreScalar = New instat.ucrCheck()
        Me.checkScalars = New System.Windows.Forms.CheckBox()
        Me.grpEnterKeyboard2.SuspendLayout()
        Me.grpBasic.SuspendLayout()
        Me.ContextMenuStripBase.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkShowEnterArguments
        '
        Me.chkShowEnterArguments.AutoSize = True
        Me.chkShowEnterArguments.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkShowEnterArguments.Location = New System.Drawing.Point(460, 27)
        Me.chkShowEnterArguments.Margin = New System.Windows.Forms.Padding(4)
        Me.chkShowEnterArguments.Name = "chkShowEnterArguments"
        Me.chkShowEnterArguments.Size = New System.Drawing.Size(161, 24)
        Me.chkShowEnterArguments.TabIndex = 155
        Me.chkShowEnterArguments.Text = "Show Parameters"
        Me.chkShowEnterArguments.UseVisualStyleBackColor = True
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblData.Location = New System.Drawing.Point(15, 30)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(48, 20)
        Me.lblData.TabIndex = 152
        Me.lblData.Tag = "Data"
        Me.lblData.Text = "Data:"
        '
        'cmdQuotes
        '
        Me.cmdQuotes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQuotes.Location = New System.Drawing.Point(150, 152)
        Me.cmdQuotes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdQuotes.Name = "cmdQuotes"
        Me.cmdQuotes.Size = New System.Drawing.Size(74, 45)
        Me.cmdQuotes.TabIndex = 142
        Me.cmdQuotes.Text = """ """
        Me.cmdQuotes.UseVisualStyleBackColor = True
        '
        'cmdExponential
        '
        Me.cmdExponential.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdExponential.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdExponential.Location = New System.Drawing.Point(78, 152)
        Me.cmdExponential.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdExponential.Name = "cmdExponential"
        Me.cmdExponential.Size = New System.Drawing.Size(74, 45)
        Me.cmdExponential.TabIndex = 143
        Me.cmdExponential.Text = "E"
        Me.cmdExponential.UseVisualStyleBackColor = True
        '
        'cmdConcantenateFunction
        '
        Me.cmdConcantenateFunction.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConcantenateFunction.Location = New System.Drawing.Point(6, 152)
        Me.cmdConcantenateFunction.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdConcantenateFunction.Name = "cmdConcantenateFunction"
        Me.cmdConcantenateFunction.Size = New System.Drawing.Size(74, 45)
        Me.cmdConcantenateFunction.TabIndex = 145
        Me.cmdConcantenateFunction.Text = "c( )"
        Me.cmdConcantenateFunction.UseVisualStyleBackColor = True
        '
        'cmdSequenceFunction
        '
        Me.cmdSequenceFunction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdSequenceFunction.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSequenceFunction.Location = New System.Drawing.Point(6, 108)
        Me.cmdSequenceFunction.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSequenceFunction.Name = "cmdSequenceFunction"
        Me.cmdSequenceFunction.Size = New System.Drawing.Size(74, 45)
        Me.cmdSequenceFunction.TabIndex = 147
        Me.cmdSequenceFunction.Tag = "Del"
        Me.cmdSequenceFunction.Text = "seq"
        Me.cmdSequenceFunction.UseVisualStyleBackColor = True
        '
        'cmdRepelicationFunction
        '
        Me.cmdRepelicationFunction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdRepelicationFunction.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRepelicationFunction.Location = New System.Drawing.Point(6, 64)
        Me.cmdRepelicationFunction.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdRepelicationFunction.Name = "cmdRepelicationFunction"
        Me.cmdRepelicationFunction.Size = New System.Drawing.Size(74, 45)
        Me.cmdRepelicationFunction.TabIndex = 148
        Me.cmdRepelicationFunction.Text = "rep"
        Me.cmdRepelicationFunction.UseVisualStyleBackColor = True
        '
        'cmdLogical
        '
        Me.cmdLogical.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLogical.Location = New System.Drawing.Point(150, 108)
        Me.cmdLogical.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdLogical.Name = "cmdLogical"
        Me.cmdLogical.Size = New System.Drawing.Size(74, 45)
        Me.cmdLogical.TabIndex = 149
        Me.cmdLogical.Text = "logical"
        Me.cmdLogical.UseVisualStyleBackColor = True
        '
        'cmdPi
        '
        Me.cmdPi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPi.Location = New System.Drawing.Point(78, 108)
        Me.cmdPi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPi.Name = "cmdPi"
        Me.cmdPi.Size = New System.Drawing.Size(74, 45)
        Me.cmdPi.TabIndex = 149
        Me.cmdPi.Text = "pi"
        Me.cmdPi.UseVisualStyleBackColor = True
        '
        'cmdLetters2
        '
        Me.cmdLetters2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLetters2.Location = New System.Drawing.Point(78, 21)
        Me.cmdLetters2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdLetters2.Name = "cmdLetters2"
        Me.cmdLetters2.Size = New System.Drawing.Size(74, 45)
        Me.cmdLetters2.TabIndex = 152
        Me.cmdLetters2.Text = "letters"
        Me.cmdLetters2.UseVisualStyleBackColor = True
        '
        'cmdMonths
        '
        Me.cmdMonths.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMonths.Location = New System.Drawing.Point(78, 64)
        Me.cmdMonths.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdMonths.Name = "cmdMonths"
        Me.cmdMonths.Size = New System.Drawing.Size(74, 45)
        Me.cmdMonths.TabIndex = 151
        Me.cmdMonths.Text = "months "
        Me.cmdMonths.UseVisualStyleBackColor = True
        '
        'cmdColon
        '
        Me.cmdColon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdColon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdColon.Location = New System.Drawing.Point(6, 21)
        Me.cmdColon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdColon.Name = "cmdColon"
        Me.cmdColon.Size = New System.Drawing.Size(74, 45)
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
        Me.grpEnterKeyboard2.Location = New System.Drawing.Point(662, 75)
        Me.grpEnterKeyboard2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpEnterKeyboard2.Name = "grpEnterKeyboard2"
        Me.grpEnterKeyboard2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpEnterKeyboard2.Size = New System.Drawing.Size(234, 201)
        Me.grpEnterKeyboard2.TabIndex = 159
        Me.grpEnterKeyboard2.TabStop = False
        '
        'cmdText
        '
        Me.cmdText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdText.Location = New System.Drawing.Point(150, 64)
        Me.cmdText.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdText.Name = "cmdText"
        Me.cmdText.Size = New System.Drawing.Size(74, 45)
        Me.cmdText.TabIndex = 155
        Me.cmdText.Text = "text"
        Me.cmdText.UseVisualStyleBackColor = True
        '
        'cmdFactor
        '
        Me.cmdFactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFactor.Location = New System.Drawing.Point(150, 21)
        Me.cmdFactor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdFactor.Name = "cmdFactor"
        Me.cmdFactor.Size = New System.Drawing.Size(74, 45)
        Me.cmdFactor.TabIndex = 153
        Me.cmdFactor.Text = "factor "
        Me.cmdFactor.UseVisualStyleBackColor = True
        '
        'btnExample
        '
        Me.btnExample.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExample.Location = New System.Drawing.Point(654, 24)
        Me.btnExample.Name = "btnExample"
        Me.btnExample.Size = New System.Drawing.Size(96, 33)
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
        Me.grpBasic.Location = New System.Drawing.Point(350, 76)
        Me.grpBasic.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpBasic.Name = "grpBasic"
        Me.grpBasic.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpBasic.Size = New System.Drawing.Size(308, 201)
        Me.grpBasic.TabIndex = 180
        Me.grpBasic.TabStop = False
        '
        'cmdClear
        '
        Me.cmdClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClear.Location = New System.Drawing.Point(226, 106)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(74, 90)
        Me.cmdClear.TabIndex = 190
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(4, 150)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 45)
        Me.Button1.TabIndex = 138
        Me.Button1.Text = ","
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdBrackets
        '
        Me.cmdBrackets.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBrackets.Location = New System.Drawing.Point(116, 150)
        Me.cmdBrackets.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdBrackets.Name = "cmdBrackets"
        Me.cmdBrackets.Size = New System.Drawing.Size(57, 45)
        Me.cmdBrackets.TabIndex = 136
        Me.cmdBrackets.Text = "( )"
        Me.cmdBrackets.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        Me.cmdPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdPower.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPower.Location = New System.Drawing.Point(226, 63)
        Me.cmdPower.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.Size = New System.Drawing.Size(74, 45)
        Me.cmdPower.TabIndex = 133
        Me.cmdPower.Text = "^"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdDivide
        '
        Me.cmdDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdDivide.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDivide.Location = New System.Drawing.Point(171, 20)
        Me.cmdDivide.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDivide.Name = "cmdDivide"
        Me.cmdDivide.Size = New System.Drawing.Size(57, 45)
        Me.cmdDivide.TabIndex = 131
        Me.cmdDivide.Text = "/"
        Me.cmdDivide.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        Me.cmdPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdPlus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlus.Location = New System.Drawing.Point(171, 150)
        Me.cmdPlus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.Size = New System.Drawing.Size(57, 45)
        Me.cmdPlus.TabIndex = 130
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdMinus
        '
        Me.cmdMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdMinus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMinus.Location = New System.Drawing.Point(171, 106)
        Me.cmdMinus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.Size = New System.Drawing.Size(57, 45)
        Me.cmdMinus.TabIndex = 129
        Me.cmdMinus.Text = "-"
        Me.cmdMinus.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        Me.cmdMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdMultiply.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMultiply.Location = New System.Drawing.Point(171, 63)
        Me.cmdMultiply.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.Size = New System.Drawing.Size(57, 45)
        Me.cmdMultiply.TabIndex = 128
        Me.cmdMultiply.Text = "*"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(226, 20)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 45)
        Me.Button2.TabIndex = 127
        Me.Button2.Text = "."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmd9
        '
        Me.cmd9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd9.Location = New System.Drawing.Point(116, 20)
        Me.cmd9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd9.Name = "cmd9"
        Me.cmd9.Size = New System.Drawing.Size(57, 45)
        Me.cmd9.TabIndex = 126
        Me.cmd9.Text = "9"
        Me.cmd9.UseVisualStyleBackColor = True
        '
        'cmd8
        '
        Me.cmd8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd8.Location = New System.Drawing.Point(60, 20)
        Me.cmd8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd8.Name = "cmd8"
        Me.cmd8.Size = New System.Drawing.Size(57, 45)
        Me.cmd8.TabIndex = 125
        Me.cmd8.Text = "8"
        Me.cmd8.UseVisualStyleBackColor = True
        '
        'cmd7
        '
        Me.cmd7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd7.Location = New System.Drawing.Point(4, 20)
        Me.cmd7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd7.Name = "cmd7"
        Me.cmd7.Size = New System.Drawing.Size(57, 45)
        Me.cmd7.TabIndex = 124
        Me.cmd7.Text = "7"
        Me.cmd7.UseVisualStyleBackColor = True
        '
        'cmd6
        '
        Me.cmd6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd6.Location = New System.Drawing.Point(116, 63)
        Me.cmd6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd6.Name = "cmd6"
        Me.cmd6.Size = New System.Drawing.Size(57, 45)
        Me.cmd6.TabIndex = 123
        Me.cmd6.Text = "6"
        Me.cmd6.UseVisualStyleBackColor = True
        '
        'cmd5
        '
        Me.cmd5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd5.Location = New System.Drawing.Point(60, 63)
        Me.cmd5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(57, 45)
        Me.cmd5.TabIndex = 122
        Me.cmd5.Text = "5"
        Me.cmd5.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        Me.cmd4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd4.Location = New System.Drawing.Point(4, 63)
        Me.cmd4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(57, 45)
        Me.cmd4.TabIndex = 121
        Me.cmd4.Text = "4"
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'cmd3
        '
        Me.cmd3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd3.Location = New System.Drawing.Point(116, 106)
        Me.cmd3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(57, 45)
        Me.cmd3.TabIndex = 120
        Me.cmd3.Text = "3"
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        Me.cmd2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd2.Location = New System.Drawing.Point(60, 106)
        Me.cmd2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(57, 45)
        Me.cmd2.TabIndex = 119
        Me.cmd2.Text = "2"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'cmd0
        '
        Me.cmd0.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd0.Location = New System.Drawing.Point(60, 150)
        Me.cmd0.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd0.Name = "cmd0"
        Me.cmd0.Size = New System.Drawing.Size(57, 45)
        Me.cmd0.TabIndex = 118
        Me.cmd0.Text = "0"
        Me.cmd0.UseVisualStyleBackColor = True
        '
        'cmd1
        '
        Me.cmd1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd1.Location = New System.Drawing.Point(4, 106)
        Me.cmd1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(57, 45)
        Me.cmd1.TabIndex = 117
        Me.cmd1.Text = "1"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'ucrSaveEnterResultInto
        '
        Me.ucrSaveEnterResultInto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveEnterResultInto.Location = New System.Drawing.Point(19, 390)
        Me.ucrSaveEnterResultInto.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveEnterResultInto.Name = "ucrSaveEnterResultInto"
        Me.ucrSaveEnterResultInto.Size = New System.Drawing.Size(511, 33)
        Me.ucrSaveEnterResultInto.TabIndex = 181
        '
        'ucrTryModelling
        '
        Me.ucrTryModelling.AutoSize = True
        Me.ucrTryModelling.Location = New System.Drawing.Point(19, 340)
        Me.ucrTryModelling.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrTryModelling.Name = "ucrTryModelling"
        Me.ucrTryModelling.RunCommandAsMultipleLines = False
        Me.ucrTryModelling.Size = New System.Drawing.Size(720, 55)
        Me.ucrTryModelling.TabIndex = 160
        '
        'ucrReceiverForEnterCalculation
        '
        Me.ucrReceiverForEnterCalculation.AutoSize = True
        Me.ucrReceiverForEnterCalculation.frmParent = Me
        Me.ucrReceiverForEnterCalculation.Location = New System.Drawing.Point(104, 24)
        Me.ucrReceiverForEnterCalculation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ucrReceiverForEnterCalculation.Name = "ucrReceiverForEnterCalculation"
        Me.ucrReceiverForEnterCalculation.Selector = Nothing
        Me.ucrReceiverForEnterCalculation.Size = New System.Drawing.Size(344, 42)
        Me.ucrReceiverForEnterCalculation.strNcFilePath = ""
        Me.ucrReceiverForEnterCalculation.TabIndex = 153
        Me.ucrReceiverForEnterCalculation.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(19, 468)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 0
        '
        'cmdRHelp
        '
        Me.cmdRHelp.AutoSize = True
        Me.cmdRHelp.ContextMenuStrip = Me.ContextMenuStripBase
        Me.cmdRHelp.Location = New System.Drawing.Point(789, 280)
        Me.cmdRHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdRHelp.Name = "cmdRHelp"
        Me.cmdRHelp.Size = New System.Drawing.Size(102, 34)
        Me.cmdRHelp.SplitMenuStrip = Me.ContextMenuStripBase
        Me.cmdRHelp.TabIndex = 213
        Me.cmdRHelp.Text = "R Help"
        Me.cmdRHelp.UseVisualStyleBackColor = True
        '
        'ContextMenuStripBase
        '
        Me.ContextMenuStripBase.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStripBase.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuBase})
        Me.ContextMenuStripBase.Name = "ContextMenuStrip1"
        Me.ContextMenuStripBase.Size = New System.Drawing.Size(122, 36)
        '
        'ToolStripMenuBase
        '
        Me.ToolStripMenuBase.Name = "ToolStripMenuBase"
        Me.ToolStripMenuBase.Size = New System.Drawing.Size(121, 32)
        Me.ToolStripMenuBase.Text = "base"
        '
        'ucrSelectorEnter
        '
        Me.ucrSelectorEnter.AutoSize = True
        Me.ucrSelectorEnter.bDropUnusedFilterLevels = False
        Me.ucrSelectorEnter.bShowHiddenColumns = False
        Me.ucrSelectorEnter.bUseCurrentFilter = True
        Me.ucrSelectorEnter.Location = New System.Drawing.Point(19, 62)
        Me.ucrSelectorEnter.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorEnter.Name = "ucrSelectorEnter"
        Me.ucrSelectorEnter.Size = New System.Drawing.Size(318, 274)
        Me.ucrSelectorEnter.TabIndex = 214
        '
        'ucrChkStoreScalar
        '
        Me.ucrChkStoreScalar.AutoSize = True
        Me.ucrChkStoreScalar.Checked = False
        Me.ucrChkStoreScalar.Location = New System.Drawing.Point(19, 426)
        Me.ucrChkStoreScalar.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkStoreScalar.Name = "ucrChkStoreScalar"
        Me.ucrChkStoreScalar.Size = New System.Drawing.Size(199, 34)
        Me.ucrChkStoreScalar.TabIndex = 215
        '
        'checkScalars
        '
        Me.checkScalars.AutoSize = True
        Me.checkScalars.Location = New System.Drawing.Point(350, 289)
        Me.checkScalars.Name = "checkScalars"
        Me.checkScalars.Size = New System.Drawing.Size(88, 24)
        Me.checkScalars.TabIndex = 216
        Me.checkScalars.Text = "Scalars"
        Me.checkScalars.UseVisualStyleBackColor = True
        '
        'dlgEnter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(910, 553)
        Me.Controls.Add(Me.checkScalars)
        Me.Controls.Add(Me.ucrChkStoreScalar)
        Me.Controls.Add(Me.ucrSelectorEnter)
        Me.Controls.Add(Me.cmdRHelp)
        Me.Controls.Add(Me.ucrSaveEnterResultInto)
        Me.Controls.Add(Me.grpBasic)
        Me.Controls.Add(Me.btnExample)
        Me.Controls.Add(Me.ucrTryModelling)
        Me.Controls.Add(Me.grpEnterKeyboard2)
        Me.Controls.Add(Me.chkShowEnterArguments)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.ucrReceiverForEnterCalculation)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgEnter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter"
        Me.grpEnterKeyboard2.ResumeLayout(False)
        Me.grpBasic.ResumeLayout(False)
        Me.ContextMenuStripBase.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkShowEnterArguments As CheckBox
    Friend WithEvents lblData As Label
    Friend WithEvents ucrReceiverForEnterCalculation As ucrReceiverExpression
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
    Friend WithEvents cmdRHelp As ucrSplitButton
    Friend WithEvents ContextMenuStripBase As ContextMenuStrip
    Friend WithEvents ToolStripMenuBase As ToolStripMenuItem
    Friend WithEvents ucrSelectorEnter As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrChkStoreScalar As ucrCheck
    Friend WithEvents checkScalars As CheckBox
End Class
