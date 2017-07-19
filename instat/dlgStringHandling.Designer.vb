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
Partial Class dlgStringHandling
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
        Me.lblColumn = New System.Windows.Forms.Label()
        Me.lblReplaceBy = New System.Windows.Forms.Label()
        Me.lblPattern = New System.Windows.Forms.Label()
        Me.rdoCount = New System.Windows.Forms.RadioButton()
        Me.rdoReplace = New System.Windows.Forms.RadioButton()
        Me.rdoLocate = New System.Windows.Forms.RadioButton()
        Me.rdoExtract = New System.Windows.Forms.RadioButton()
        Me.rdoDetect = New System.Windows.Forms.RadioButton()
        Me.rdoReplaceAll = New System.Windows.Forms.RadioButton()
        Me.grpRegex = New System.Windows.Forms.GroupBox()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdBackSlash = New System.Windows.Forms.Button()
        Me.cmdWBackSlash = New System.Windows.Forms.Button()
        Me.cmdDollarSign = New System.Windows.Forms.Button()
        Me.cmdOpenCloseParenthesis = New System.Windows.Forms.Button()
        Me.cmdBackSlashd = New System.Windows.Forms.Button()
        Me.cmdBackSlashs = New System.Windows.Forms.Button()
        Me.cmdPower = New System.Windows.Forms.Button()
        Me.cmdOpenBracketCaretClosedBracket = New System.Windows.Forms.Button()
        Me.cmdPlus = New System.Windows.Forms.Button()
        Me.cmdBackSlashw = New System.Windows.Forms.Button()
        Me.cmdMultiply = New System.Windows.Forms.Button()
        Me.cmdOpenCloseBrace = New System.Windows.Forms.Button()
        Me.cmdOpenClosedBracket = New System.Windows.Forms.Button()
        Me.cmdSingleQuote = New System.Windows.Forms.Button()
        Me.cmdQuote = New System.Windows.Forms.Button()
        Me.cmdQuestionMark = New System.Windows.Forms.Button()
        Me.cmdDBackSlah = New System.Windows.Forms.Button()
        Me.cmdStar = New System.Windows.Forms.Button()
        Me.cmdBbackSlash = New System.Windows.Forms.Button()
        Me.cmdBackSlashb = New System.Windows.Forms.Button()
        Me.cmdSbackSlash = New System.Windows.Forms.Button()
        Me.cmdOr = New System.Windows.Forms.Button()
        Me.rdoFixed = New System.Windows.Forms.RadioButton()
        Me.rdoRegex = New System.Windows.Forms.RadioButton()
        Me.ucrSaveStringHandling = New instat.ucrSave()
        Me.ucrReceiverForRegexExpression = New instat.ucrReceiverExpression()
        Me.ucrPnlFixedRegex = New instat.UcrPanel()
        Me.ucrChkIncludeRegularExpressions = New instat.ucrCheck()
        Me.ucrReceiverStringHandling = New instat.ucrReceiverSingle()
        Me.ucrInputReplaceBy = New instat.ucrInputTextBox()
        Me.ucrInputPattern = New instat.ucrInputTextBox()
        Me.ucrSelectorStringHandling = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlStringHandling = New instat.UcrPanel()
        Me.grpRegex.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColumn
        '
        Me.lblColumn.AutoSize = True
        Me.lblColumn.Location = New System.Drawing.Point(259, 129)
        Me.lblColumn.Name = "lblColumn"
        Me.lblColumn.Size = New System.Drawing.Size(45, 13)
        Me.lblColumn.TabIndex = 8
        Me.lblColumn.Text = "Column:"
        '
        'lblReplaceBy
        '
        Me.lblReplaceBy.AutoSize = True
        Me.lblReplaceBy.Location = New System.Drawing.Point(259, 218)
        Me.lblReplaceBy.Name = "lblReplaceBy"
        Me.lblReplaceBy.Size = New System.Drawing.Size(65, 13)
        Me.lblReplaceBy.TabIndex = 13
        Me.lblReplaceBy.Text = "Replace By:"
        '
        'lblPattern
        '
        Me.lblPattern.AutoSize = True
        Me.lblPattern.Location = New System.Drawing.Point(259, 170)
        Me.lblPattern.Name = "lblPattern"
        Me.lblPattern.Size = New System.Drawing.Size(44, 13)
        Me.lblPattern.TabIndex = 11
        Me.lblPattern.Text = "Pattern:"
        '
        'rdoCount
        '
        Me.rdoCount.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoCount.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCount.FlatAppearance.BorderSize = 2
        Me.rdoCount.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCount.Location = New System.Drawing.Point(14, 12)
        Me.rdoCount.Name = "rdoCount"
        Me.rdoCount.Size = New System.Drawing.Size(88, 27)
        Me.rdoCount.TabIndex = 1
        Me.rdoCount.TabStop = True
        Me.rdoCount.Text = " Word Count"
        Me.rdoCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoCount.UseVisualStyleBackColor = True
        '
        'rdoReplace
        '
        Me.rdoReplace.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoReplace.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoReplace.FlatAppearance.BorderSize = 2
        Me.rdoReplace.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoReplace.Location = New System.Drawing.Point(277, 12)
        Me.rdoReplace.Name = "rdoReplace"
        Me.rdoReplace.Size = New System.Drawing.Size(61, 27)
        Me.rdoReplace.TabIndex = 5
        Me.rdoReplace.TabStop = True
        Me.rdoReplace.Text = "Replace"
        Me.rdoReplace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoReplace.UseVisualStyleBackColor = True
        '
        'rdoLocate
        '
        Me.rdoLocate.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoLocate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLocate.FlatAppearance.BorderSize = 2
        Me.rdoLocate.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLocate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoLocate.Location = New System.Drawing.Point(218, 12)
        Me.rdoLocate.Name = "rdoLocate"
        Me.rdoLocate.Size = New System.Drawing.Size(61, 27)
        Me.rdoLocate.TabIndex = 4
        Me.rdoLocate.TabStop = True
        Me.rdoLocate.Text = "Locate"
        Me.rdoLocate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoLocate.UseVisualStyleBackColor = True
        '
        'rdoExtract
        '
        Me.rdoExtract.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoExtract.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoExtract.FlatAppearance.BorderSize = 2
        Me.rdoExtract.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoExtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoExtract.Location = New System.Drawing.Point(159, 12)
        Me.rdoExtract.Name = "rdoExtract"
        Me.rdoExtract.Size = New System.Drawing.Size(61, 27)
        Me.rdoExtract.TabIndex = 3
        Me.rdoExtract.TabStop = True
        Me.rdoExtract.Text = "Extract"
        Me.rdoExtract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoExtract.UseVisualStyleBackColor = True
        '
        'rdoDetect
        '
        Me.rdoDetect.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDetect.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDetect.FlatAppearance.BorderSize = 2
        Me.rdoDetect.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDetect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDetect.Location = New System.Drawing.Point(100, 12)
        Me.rdoDetect.Name = "rdoDetect"
        Me.rdoDetect.Size = New System.Drawing.Size(61, 27)
        Me.rdoDetect.TabIndex = 2
        Me.rdoDetect.TabStop = True
        Me.rdoDetect.Text = "Detect"
        Me.rdoDetect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDetect.UseVisualStyleBackColor = True
        '
        'rdoReplaceAll
        '
        Me.rdoReplaceAll.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoReplaceAll.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoReplaceAll.FlatAppearance.BorderSize = 2
        Me.rdoReplaceAll.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoReplaceAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoReplaceAll.Location = New System.Drawing.Point(335, 12)
        Me.rdoReplaceAll.Name = "rdoReplaceAll"
        Me.rdoReplaceAll.Size = New System.Drawing.Size(74, 27)
        Me.rdoReplaceAll.TabIndex = 6
        Me.rdoReplaceAll.TabStop = True
        Me.rdoReplaceAll.Text = "Replace All"
        Me.rdoReplaceAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoReplaceAll.UseVisualStyleBackColor = True
        '
        'grpRegex
        '
        Me.grpRegex.Controls.Add(Me.cmdClear)
        Me.grpRegex.Controls.Add(Me.cmdBackSlash)
        Me.grpRegex.Controls.Add(Me.cmdWBackSlash)
        Me.grpRegex.Controls.Add(Me.cmdDollarSign)
        Me.grpRegex.Controls.Add(Me.cmdOpenCloseParenthesis)
        Me.grpRegex.Controls.Add(Me.cmdBackSlashd)
        Me.grpRegex.Controls.Add(Me.cmdBackSlashs)
        Me.grpRegex.Controls.Add(Me.cmdPower)
        Me.grpRegex.Controls.Add(Me.cmdOpenBracketCaretClosedBracket)
        Me.grpRegex.Controls.Add(Me.cmdPlus)
        Me.grpRegex.Controls.Add(Me.cmdBackSlashw)
        Me.grpRegex.Controls.Add(Me.cmdMultiply)
        Me.grpRegex.Controls.Add(Me.cmdOpenCloseBrace)
        Me.grpRegex.Controls.Add(Me.cmdOpenClosedBracket)
        Me.grpRegex.Controls.Add(Me.cmdSingleQuote)
        Me.grpRegex.Controls.Add(Me.cmdQuote)
        Me.grpRegex.Controls.Add(Me.cmdQuestionMark)
        Me.grpRegex.Controls.Add(Me.cmdDBackSlah)
        Me.grpRegex.Controls.Add(Me.cmdStar)
        Me.grpRegex.Controls.Add(Me.cmdBbackSlash)
        Me.grpRegex.Controls.Add(Me.cmdBackSlashb)
        Me.grpRegex.Controls.Add(Me.cmdSbackSlash)
        Me.grpRegex.Controls.Add(Me.cmdOr)
        Me.grpRegex.Location = New System.Drawing.Point(420, 144)
        Me.grpRegex.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpRegex.Name = "grpRegex"
        Me.grpRegex.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpRegex.Size = New System.Drawing.Size(239, 141)
        Me.grpRegex.TabIndex = 180
        Me.grpRegex.TabStop = False
        Me.grpRegex.Text = "Regex keyboard"
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(198, 75)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(37, 60)
        Me.cmdClear.TabIndex = 145
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdBackSlash
        '
        Me.cmdBackSlash.Location = New System.Drawing.Point(159, 105)
        Me.cmdBackSlash.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdBackSlash.Name = "cmdBackSlash"
        Me.cmdBackSlash.Size = New System.Drawing.Size(38, 30)
        Me.cmdBackSlash.TabIndex = 140
        Me.cmdBackSlash.Text = "\ "
        Me.cmdBackSlash.UseVisualStyleBackColor = True
        '
        'cmdWBackSlash
        '
        Me.cmdWBackSlash.Location = New System.Drawing.Point(159, 75)
        Me.cmdWBackSlash.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdWBackSlash.Name = "cmdWBackSlash"
        Me.cmdWBackSlash.Size = New System.Drawing.Size(38, 30)
        Me.cmdWBackSlash.TabIndex = 139
        Me.cmdWBackSlash.Text = "\ W"
        Me.cmdWBackSlash.UseVisualStyleBackColor = True
        '
        'cmdDollarSign
        '
        Me.cmdDollarSign.Location = New System.Drawing.Point(198, 45)
        Me.cmdDollarSign.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDollarSign.Name = "cmdDollarSign"
        Me.cmdDollarSign.Size = New System.Drawing.Size(38, 30)
        Me.cmdDollarSign.TabIndex = 138
        Me.cmdDollarSign.Text = "$"
        Me.cmdDollarSign.UseVisualStyleBackColor = True
        '
        'cmdOpenCloseParenthesis
        '
        Me.cmdOpenCloseParenthesis.Location = New System.Drawing.Point(198, 15)
        Me.cmdOpenCloseParenthesis.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdOpenCloseParenthesis.Name = "cmdOpenCloseParenthesis"
        Me.cmdOpenCloseParenthesis.Size = New System.Drawing.Size(38, 30)
        Me.cmdOpenCloseParenthesis.TabIndex = 137
        Me.cmdOpenCloseParenthesis.Text = "(  )"
        Me.cmdOpenCloseParenthesis.UseVisualStyleBackColor = True
        '
        'cmdBackSlashd
        '
        Me.cmdBackSlashd.Location = New System.Drawing.Point(81, 105)
        Me.cmdBackSlashd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdBackSlashd.Name = "cmdBackSlashd"
        Me.cmdBackSlashd.Size = New System.Drawing.Size(38, 30)
        Me.cmdBackSlashd.TabIndex = 136
        Me.cmdBackSlashd.Text = "\ d"
        Me.cmdBackSlashd.UseVisualStyleBackColor = True
        '
        'cmdBackSlashs
        '
        Me.cmdBackSlashs.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBackSlashs.Location = New System.Drawing.Point(3, 105)
        Me.cmdBackSlashs.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdBackSlashs.Name = "cmdBackSlashs"
        Me.cmdBackSlashs.Size = New System.Drawing.Size(38, 30)
        Me.cmdBackSlashs.TabIndex = 132
        Me.cmdBackSlashs.Tag = "Del"
        Me.cmdBackSlashs.Text = "\ s"
        Me.cmdBackSlashs.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        Me.cmdPower.Location = New System.Drawing.Point(159, 45)
        Me.cmdPower.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.Size = New System.Drawing.Size(38, 30)
        Me.cmdPower.TabIndex = 133
        Me.cmdPower.Text = "^"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdOpenBracketCaretClosedBracket
        '
        Me.cmdOpenBracketCaretClosedBracket.Location = New System.Drawing.Point(120, 15)
        Me.cmdOpenBracketCaretClosedBracket.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdOpenBracketCaretClosedBracket.Name = "cmdOpenBracketCaretClosedBracket"
        Me.cmdOpenBracketCaretClosedBracket.Size = New System.Drawing.Size(38, 30)
        Me.cmdOpenBracketCaretClosedBracket.TabIndex = 131
        Me.cmdOpenBracketCaretClosedBracket.Text = "[ ^ ]"
        Me.cmdOpenBracketCaretClosedBracket.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        Me.cmdPlus.Location = New System.Drawing.Point(42, 45)
        Me.cmdPlus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.Size = New System.Drawing.Size(38, 30)
        Me.cmdPlus.TabIndex = 130
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdBackSlashw
        '
        Me.cmdBackSlashw.Location = New System.Drawing.Point(120, 75)
        Me.cmdBackSlashw.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdBackSlashw.Name = "cmdBackSlashw"
        Me.cmdBackSlashw.Size = New System.Drawing.Size(38, 30)
        Me.cmdBackSlashw.TabIndex = 129
        Me.cmdBackSlashw.Text = "\ w"
        Me.cmdBackSlashw.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        Me.cmdMultiply.Location = New System.Drawing.Point(120, 45)
        Me.cmdMultiply.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.Size = New System.Drawing.Size(38, 30)
        Me.cmdMultiply.TabIndex = 128
        Me.cmdMultiply.Text = "."
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdOpenCloseBrace
        '
        Me.cmdOpenCloseBrace.Location = New System.Drawing.Point(159, 15)
        Me.cmdOpenCloseBrace.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdOpenCloseBrace.Name = "cmdOpenCloseBrace"
        Me.cmdOpenCloseBrace.Size = New System.Drawing.Size(38, 30)
        Me.cmdOpenCloseBrace.TabIndex = 127
        Me.cmdOpenCloseBrace.Text = "{  }"
        Me.cmdOpenCloseBrace.UseVisualStyleBackColor = True
        '
        'cmdOpenClosedBracket
        '
        Me.cmdOpenClosedBracket.Location = New System.Drawing.Point(81, 15)
        Me.cmdOpenClosedBracket.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdOpenClosedBracket.Name = "cmdOpenClosedBracket"
        Me.cmdOpenClosedBracket.Size = New System.Drawing.Size(38, 30)
        Me.cmdOpenClosedBracket.TabIndex = 126
        Me.cmdOpenClosedBracket.Text = "[  ]"
        Me.cmdOpenClosedBracket.UseVisualStyleBackColor = True
        '
        'cmdSingleQuote
        '
        Me.cmdSingleQuote.Location = New System.Drawing.Point(42, 15)
        Me.cmdSingleQuote.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSingleQuote.Name = "cmdSingleQuote"
        Me.cmdSingleQuote.Size = New System.Drawing.Size(38, 30)
        Me.cmdSingleQuote.TabIndex = 125
        Me.cmdSingleQuote.Text = "' '"
        Me.cmdSingleQuote.UseVisualStyleBackColor = True
        '
        'cmdQuote
        '
        Me.cmdQuote.Location = New System.Drawing.Point(3, 15)
        Me.cmdQuote.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdQuote.Name = "cmdQuote"
        Me.cmdQuote.Size = New System.Drawing.Size(38, 30)
        Me.cmdQuote.TabIndex = 124
        Me.cmdQuote.Text = """ """
        Me.cmdQuote.UseVisualStyleBackColor = True
        '
        'cmdQuestionMark
        '
        Me.cmdQuestionMark.Location = New System.Drawing.Point(81, 45)
        Me.cmdQuestionMark.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdQuestionMark.Name = "cmdQuestionMark"
        Me.cmdQuestionMark.Size = New System.Drawing.Size(38, 30)
        Me.cmdQuestionMark.TabIndex = 123
        Me.cmdQuestionMark.Text = "?"
        Me.cmdQuestionMark.UseVisualStyleBackColor = True
        '
        'cmdDBackSlah
        '
        Me.cmdDBackSlah.Location = New System.Drawing.Point(120, 105)
        Me.cmdDBackSlah.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDBackSlah.Name = "cmdDBackSlah"
        Me.cmdDBackSlah.Size = New System.Drawing.Size(38, 30)
        Me.cmdDBackSlah.TabIndex = 122
        Me.cmdDBackSlah.Text = "\ D"
        Me.cmdDBackSlah.UseVisualStyleBackColor = True
        '
        'cmdStar
        '
        Me.cmdStar.Location = New System.Drawing.Point(3, 45)
        Me.cmdStar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdStar.Name = "cmdStar"
        Me.cmdStar.Size = New System.Drawing.Size(38, 30)
        Me.cmdStar.TabIndex = 121
        Me.cmdStar.Text = "*"
        Me.cmdStar.UseVisualStyleBackColor = True
        '
        'cmdBbackSlash
        '
        Me.cmdBbackSlash.Location = New System.Drawing.Point(81, 75)
        Me.cmdBbackSlash.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdBbackSlash.Name = "cmdBbackSlash"
        Me.cmdBbackSlash.Size = New System.Drawing.Size(38, 30)
        Me.cmdBbackSlash.TabIndex = 120
        Me.cmdBbackSlash.Text = "\ B"
        Me.cmdBbackSlash.UseVisualStyleBackColor = True
        '
        'cmdBackSlashb
        '
        Me.cmdBackSlashb.Location = New System.Drawing.Point(42, 75)
        Me.cmdBackSlashb.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdBackSlashb.Name = "cmdBackSlashb"
        Me.cmdBackSlashb.Size = New System.Drawing.Size(38, 30)
        Me.cmdBackSlashb.TabIndex = 119
        Me.cmdBackSlashb.Text = "\ b"
        Me.cmdBackSlashb.UseVisualStyleBackColor = True
        '
        'cmdSbackSlash
        '
        Me.cmdSbackSlash.Location = New System.Drawing.Point(42, 105)
        Me.cmdSbackSlash.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSbackSlash.Name = "cmdSbackSlash"
        Me.cmdSbackSlash.Size = New System.Drawing.Size(38, 30)
        Me.cmdSbackSlash.TabIndex = 118
        Me.cmdSbackSlash.Text = "\ S"
        Me.cmdSbackSlash.UseVisualStyleBackColor = True
        '
        'cmdOr
        '
        Me.cmdOr.Location = New System.Drawing.Point(3, 75)
        Me.cmdOr.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdOr.Name = "cmdOr"
        Me.cmdOr.Size = New System.Drawing.Size(38, 30)
        Me.cmdOr.TabIndex = 117
        Me.cmdOr.Text = "|,"
        Me.cmdOr.UseVisualStyleBackColor = True
        '
        'rdoFixed
        '
        Me.rdoFixed.AutoSize = True
        Me.rdoFixed.Location = New System.Drawing.Point(262, 96)
        Me.rdoFixed.Name = "rdoFixed"
        Me.rdoFixed.Size = New System.Drawing.Size(50, 17)
        Me.rdoFixed.TabIndex = 183
        Me.rdoFixed.TabStop = True
        Me.rdoFixed.Text = "Fixed"
        Me.rdoFixed.UseVisualStyleBackColor = True
        '
        'rdoRegex
        '
        Me.rdoRegex.AutoSize = True
        Me.rdoRegex.Location = New System.Drawing.Point(318, 96)
        Me.rdoRegex.Name = "rdoRegex"
        Me.rdoRegex.Size = New System.Drawing.Size(56, 17)
        Me.rdoRegex.TabIndex = 184
        Me.rdoRegex.TabStop = True
        Me.rdoRegex.Text = "Regex"
        Me.rdoRegex.UseVisualStyleBackColor = True
        '
        'ucrSaveStringHandling
        '
        Me.ucrSaveStringHandling.Location = New System.Drawing.Point(10, 271)
        Me.ucrSaveStringHandling.Name = "ucrSaveStringHandling"
        Me.ucrSaveStringHandling.Size = New System.Drawing.Size(293, 24)
        Me.ucrSaveStringHandling.TabIndex = 186
        '
        'ucrReceiverForRegexExpression
        '
        Me.ucrReceiverForRegexExpression.frmParent = Me
        Me.ucrReceiverForRegexExpression.Location = New System.Drawing.Point(259, 185)
        Me.ucrReceiverForRegexExpression.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrReceiverForRegexExpression.Name = "ucrReceiverForRegexExpression"
        Me.ucrReceiverForRegexExpression.Selector = Nothing
        Me.ucrReceiverForRegexExpression.Size = New System.Drawing.Size(138, 28)
        Me.ucrReceiverForRegexExpression.strNcFilePath = ""
        Me.ucrReceiverForRegexExpression.TabIndex = 182
        Me.ucrReceiverForRegexExpression.ucrSelector = Nothing
        '
        'ucrPnlFixedRegex
        '
        Me.ucrPnlFixedRegex.Location = New System.Drawing.Point(259, 87)
        Me.ucrPnlFixedRegex.Name = "ucrPnlFixedRegex"
        Me.ucrPnlFixedRegex.Size = New System.Drawing.Size(116, 32)
        Me.ucrPnlFixedRegex.TabIndex = 185
        '
        'ucrChkIncludeRegularExpressions
        '
        Me.ucrChkIncludeRegularExpressions.Checked = False
        Me.ucrChkIncludeRegularExpressions.Location = New System.Drawing.Point(9, 242)
        Me.ucrChkIncludeRegularExpressions.Name = "ucrChkIncludeRegularExpressions"
        Me.ucrChkIncludeRegularExpressions.Size = New System.Drawing.Size(239, 20)
        Me.ucrChkIncludeRegularExpressions.TabIndex = 10
        '
        'ucrReceiverStringHandling
        '
        Me.ucrReceiverStringHandling.frmParent = Me
        Me.ucrReceiverStringHandling.Location = New System.Drawing.Point(259, 144)
        Me.ucrReceiverStringHandling.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStringHandling.Name = "ucrReceiverStringHandling"
        Me.ucrReceiverStringHandling.Selector = Nothing
        Me.ucrReceiverStringHandling.Size = New System.Drawing.Size(138, 20)
        Me.ucrReceiverStringHandling.strNcFilePath = ""
        Me.ucrReceiverStringHandling.TabIndex = 9
        Me.ucrReceiverStringHandling.ucrSelector = Nothing
        '
        'ucrInputReplaceBy
        '
        Me.ucrInputReplaceBy.AddQuotesIfUnrecognised = True
        Me.ucrInputReplaceBy.IsMultiline = False
        Me.ucrInputReplaceBy.IsReadOnly = False
        Me.ucrInputReplaceBy.Location = New System.Drawing.Point(259, 233)
        Me.ucrInputReplaceBy.Name = "ucrInputReplaceBy"
        Me.ucrInputReplaceBy.Size = New System.Drawing.Size(138, 20)
        Me.ucrInputReplaceBy.TabIndex = 14
        '
        'ucrInputPattern
        '
        Me.ucrInputPattern.AddQuotesIfUnrecognised = True
        Me.ucrInputPattern.IsMultiline = False
        Me.ucrInputPattern.IsReadOnly = False
        Me.ucrInputPattern.Location = New System.Drawing.Point(259, 186)
        Me.ucrInputPattern.Name = "ucrInputPattern"
        Me.ucrInputPattern.Size = New System.Drawing.Size(138, 20)
        Me.ucrInputPattern.TabIndex = 12
        '
        'ucrSelectorStringHandling
        '
        Me.ucrSelectorStringHandling.bShowHiddenColumns = False
        Me.ucrSelectorStringHandling.bUseCurrentFilter = True
        Me.ucrSelectorStringHandling.Location = New System.Drawing.Point(9, 55)
        Me.ucrSelectorStringHandling.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStringHandling.Name = "ucrSelectorStringHandling"
        Me.ucrSelectorStringHandling.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorStringHandling.TabIndex = 7
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 301)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(406, 52)
        Me.ucrBase.TabIndex = 16
        '
        'ucrPnlStringHandling
        '
        Me.ucrPnlStringHandling.Location = New System.Drawing.Point(9, 1)
        Me.ucrPnlStringHandling.Name = "ucrPnlStringHandling"
        Me.ucrPnlStringHandling.Size = New System.Drawing.Size(406, 51)
        Me.ucrPnlStringHandling.TabIndex = 0
        '
        'dlgStringHandling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 368)
        Me.Controls.Add(Me.ucrSaveStringHandling)
        Me.Controls.Add(Me.rdoRegex)
        Me.Controls.Add(Me.rdoFixed)
        Me.Controls.Add(Me.ucrReceiverForRegexExpression)
        Me.Controls.Add(Me.ucrPnlFixedRegex)
        Me.Controls.Add(Me.grpRegex)
        Me.Controls.Add(Me.ucrChkIncludeRegularExpressions)
        Me.Controls.Add(Me.rdoReplaceAll)
        Me.Controls.Add(Me.rdoDetect)
        Me.Controls.Add(Me.rdoExtract)
        Me.Controls.Add(Me.rdoLocate)
        Me.Controls.Add(Me.rdoReplace)
        Me.Controls.Add(Me.rdoCount)
        Me.Controls.Add(Me.ucrReceiverStringHandling)
        Me.Controls.Add(Me.lblPattern)
        Me.Controls.Add(Me.lblReplaceBy)
        Me.Controls.Add(Me.lblColumn)
        Me.Controls.Add(Me.ucrInputReplaceBy)
        Me.Controls.Add(Me.ucrInputPattern)
        Me.Controls.Add(Me.ucrSelectorStringHandling)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlStringHandling)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgStringHandling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "String Handling"
        Me.grpRegex.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorStringHandling As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputPattern As ucrInputTextBox
    Friend WithEvents ucrInputReplaceBy As ucrInputTextBox
    Friend WithEvents lblColumn As Label
    Friend WithEvents lblReplaceBy As Label
    Friend WithEvents lblPattern As Label
    Friend WithEvents ucrReceiverStringHandling As ucrReceiverSingle
    Friend WithEvents rdoDetect As RadioButton
    Friend WithEvents rdoExtract As RadioButton
    Friend WithEvents rdoLocate As RadioButton
    Friend WithEvents rdoReplace As RadioButton
    Friend WithEvents rdoCount As RadioButton
    Friend WithEvents ucrPnlStringHandling As UcrPanel
    Friend WithEvents rdoReplaceAll As RadioButton
    Friend WithEvents ucrChkIncludeRegularExpressions As ucrCheck
    Friend WithEvents grpRegex As GroupBox
    Friend WithEvents cmdOpenCloseParenthesis As Button
    Friend WithEvents cmdBackSlashd As Button
    Friend WithEvents cmdBackSlashs As Button
    Friend WithEvents cmdPower As Button
    Friend WithEvents cmdOpenBracketCaretClosedBracket As Button
    Friend WithEvents cmdPlus As Button
    Friend WithEvents cmdBackSlashw As Button
    Friend WithEvents cmdMultiply As Button
    Friend WithEvents cmdOpenCloseBrace As Button
    Friend WithEvents cmdOpenClosedBracket As Button
    Friend WithEvents cmdSingleQuote As Button
    Friend WithEvents cmdQuote As Button
    Friend WithEvents cmdQuestionMark As Button
    Friend WithEvents cmdDBackSlah As Button
    Friend WithEvents cmdStar As Button
    Friend WithEvents cmdBbackSlash As Button
    Friend WithEvents cmdBackSlashb As Button
    Friend WithEvents cmdSbackSlash As Button
    Friend WithEvents cmdOr As Button
    Friend WithEvents cmdDollarSign As Button
    Friend WithEvents cmdWBackSlash As Button
    Friend WithEvents cmdBackSlash As Button
    Friend WithEvents ucrReceiverForRegexExpression As ucrReceiverExpression
    Friend WithEvents cmdClear As Button
    Friend WithEvents rdoRegex As RadioButton
    Friend WithEvents rdoFixed As RadioButton
    Friend WithEvents ucrPnlFixedRegex As UcrPanel
    Friend WithEvents ucrSaveStringHandling As ucrSave
End Class
