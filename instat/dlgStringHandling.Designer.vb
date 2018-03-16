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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgStringHandling))
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
        resources.ApplyResources(Me.lblColumn, "lblColumn")
        Me.lblColumn.Name = "lblColumn"
        '
        'lblReplaceBy
        '
        resources.ApplyResources(Me.lblReplaceBy, "lblReplaceBy")
        Me.lblReplaceBy.Name = "lblReplaceBy"
        '
        'lblPattern
        '
        resources.ApplyResources(Me.lblPattern, "lblPattern")
        Me.lblPattern.Name = "lblPattern"
        '
        'rdoCount
        '
        resources.ApplyResources(Me.rdoCount, "rdoCount")
        Me.rdoCount.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCount.FlatAppearance.BorderSize = 2
        Me.rdoCount.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCount.Name = "rdoCount"
        Me.rdoCount.TabStop = True
        Me.rdoCount.UseVisualStyleBackColor = True
        '
        'rdoReplace
        '
        resources.ApplyResources(Me.rdoReplace, "rdoReplace")
        Me.rdoReplace.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoReplace.FlatAppearance.BorderSize = 2
        Me.rdoReplace.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoReplace.Name = "rdoReplace"
        Me.rdoReplace.TabStop = True
        Me.rdoReplace.UseVisualStyleBackColor = True
        '
        'rdoLocate
        '
        resources.ApplyResources(Me.rdoLocate, "rdoLocate")
        Me.rdoLocate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLocate.FlatAppearance.BorderSize = 2
        Me.rdoLocate.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLocate.Name = "rdoLocate"
        Me.rdoLocate.TabStop = True
        Me.rdoLocate.UseVisualStyleBackColor = True
        '
        'rdoExtract
        '
        resources.ApplyResources(Me.rdoExtract, "rdoExtract")
        Me.rdoExtract.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoExtract.FlatAppearance.BorderSize = 2
        Me.rdoExtract.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoExtract.Name = "rdoExtract"
        Me.rdoExtract.TabStop = True
        Me.rdoExtract.UseVisualStyleBackColor = True
        '
        'rdoDetect
        '
        resources.ApplyResources(Me.rdoDetect, "rdoDetect")
        Me.rdoDetect.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDetect.FlatAppearance.BorderSize = 2
        Me.rdoDetect.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDetect.Name = "rdoDetect"
        Me.rdoDetect.TabStop = True
        Me.rdoDetect.UseVisualStyleBackColor = True
        '
        'rdoReplaceAll
        '
        resources.ApplyResources(Me.rdoReplaceAll, "rdoReplaceAll")
        Me.rdoReplaceAll.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoReplaceAll.FlatAppearance.BorderSize = 2
        Me.rdoReplaceAll.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoReplaceAll.Name = "rdoReplaceAll"
        Me.rdoReplaceAll.TabStop = True
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
        resources.ApplyResources(Me.grpRegex, "grpRegex")
        Me.grpRegex.Name = "grpRegex"
        Me.grpRegex.TabStop = False
        '
        'cmdClear
        '
        resources.ApplyResources(Me.cmdClear, "cmdClear")
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdBackSlash
        '
        resources.ApplyResources(Me.cmdBackSlash, "cmdBackSlash")
        Me.cmdBackSlash.Name = "cmdBackSlash"
        Me.cmdBackSlash.UseVisualStyleBackColor = True
        '
        'cmdWBackSlash
        '
        resources.ApplyResources(Me.cmdWBackSlash, "cmdWBackSlash")
        Me.cmdWBackSlash.Name = "cmdWBackSlash"
        Me.cmdWBackSlash.UseVisualStyleBackColor = True
        '
        'cmdDollarSign
        '
        resources.ApplyResources(Me.cmdDollarSign, "cmdDollarSign")
        Me.cmdDollarSign.Name = "cmdDollarSign"
        Me.cmdDollarSign.UseVisualStyleBackColor = True
        '
        'cmdOpenCloseParenthesis
        '
        resources.ApplyResources(Me.cmdOpenCloseParenthesis, "cmdOpenCloseParenthesis")
        Me.cmdOpenCloseParenthesis.Name = "cmdOpenCloseParenthesis"
        Me.cmdOpenCloseParenthesis.UseVisualStyleBackColor = True
        '
        'cmdBackSlashd
        '
        resources.ApplyResources(Me.cmdBackSlashd, "cmdBackSlashd")
        Me.cmdBackSlashd.Name = "cmdBackSlashd"
        Me.cmdBackSlashd.UseVisualStyleBackColor = True
        '
        'cmdBackSlashs
        '
        resources.ApplyResources(Me.cmdBackSlashs, "cmdBackSlashs")
        Me.cmdBackSlashs.Name = "cmdBackSlashs"
        Me.cmdBackSlashs.Tag = "Del"
        Me.cmdBackSlashs.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        resources.ApplyResources(Me.cmdPower, "cmdPower")
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdOpenBracketCaretClosedBracket
        '
        resources.ApplyResources(Me.cmdOpenBracketCaretClosedBracket, "cmdOpenBracketCaretClosedBracket")
        Me.cmdOpenBracketCaretClosedBracket.Name = "cmdOpenBracketCaretClosedBracket"
        Me.cmdOpenBracketCaretClosedBracket.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        resources.ApplyResources(Me.cmdPlus, "cmdPlus")
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdBackSlashw
        '
        resources.ApplyResources(Me.cmdBackSlashw, "cmdBackSlashw")
        Me.cmdBackSlashw.Name = "cmdBackSlashw"
        Me.cmdBackSlashw.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        resources.ApplyResources(Me.cmdMultiply, "cmdMultiply")
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdOpenCloseBrace
        '
        resources.ApplyResources(Me.cmdOpenCloseBrace, "cmdOpenCloseBrace")
        Me.cmdOpenCloseBrace.Name = "cmdOpenCloseBrace"
        Me.cmdOpenCloseBrace.UseVisualStyleBackColor = True
        '
        'cmdOpenClosedBracket
        '
        resources.ApplyResources(Me.cmdOpenClosedBracket, "cmdOpenClosedBracket")
        Me.cmdOpenClosedBracket.Name = "cmdOpenClosedBracket"
        Me.cmdOpenClosedBracket.UseVisualStyleBackColor = True
        '
        'cmdSingleQuote
        '
        resources.ApplyResources(Me.cmdSingleQuote, "cmdSingleQuote")
        Me.cmdSingleQuote.Name = "cmdSingleQuote"
        Me.cmdSingleQuote.UseVisualStyleBackColor = True
        '
        'cmdQuote
        '
        resources.ApplyResources(Me.cmdQuote, "cmdQuote")
        Me.cmdQuote.Name = "cmdQuote"
        Me.cmdQuote.UseVisualStyleBackColor = True
        '
        'cmdQuestionMark
        '
        resources.ApplyResources(Me.cmdQuestionMark, "cmdQuestionMark")
        Me.cmdQuestionMark.Name = "cmdQuestionMark"
        Me.cmdQuestionMark.UseVisualStyleBackColor = True
        '
        'cmdDBackSlah
        '
        resources.ApplyResources(Me.cmdDBackSlah, "cmdDBackSlah")
        Me.cmdDBackSlah.Name = "cmdDBackSlah"
        Me.cmdDBackSlah.UseVisualStyleBackColor = True
        '
        'cmdStar
        '
        resources.ApplyResources(Me.cmdStar, "cmdStar")
        Me.cmdStar.Name = "cmdStar"
        Me.cmdStar.UseVisualStyleBackColor = True
        '
        'cmdBbackSlash
        '
        resources.ApplyResources(Me.cmdBbackSlash, "cmdBbackSlash")
        Me.cmdBbackSlash.Name = "cmdBbackSlash"
        Me.cmdBbackSlash.UseVisualStyleBackColor = True
        '
        'cmdBackSlashb
        '
        resources.ApplyResources(Me.cmdBackSlashb, "cmdBackSlashb")
        Me.cmdBackSlashb.Name = "cmdBackSlashb"
        Me.cmdBackSlashb.UseVisualStyleBackColor = True
        '
        'cmdSbackSlash
        '
        resources.ApplyResources(Me.cmdSbackSlash, "cmdSbackSlash")
        Me.cmdSbackSlash.Name = "cmdSbackSlash"
        Me.cmdSbackSlash.UseVisualStyleBackColor = True
        '
        'cmdOr
        '
        resources.ApplyResources(Me.cmdOr, "cmdOr")
        Me.cmdOr.Name = "cmdOr"
        Me.cmdOr.UseVisualStyleBackColor = True
        '
        'rdoFixed
        '
        resources.ApplyResources(Me.rdoFixed, "rdoFixed")
        Me.rdoFixed.Name = "rdoFixed"
        Me.rdoFixed.TabStop = True
        Me.rdoFixed.UseVisualStyleBackColor = True
        '
        'rdoRegex
        '
        resources.ApplyResources(Me.rdoRegex, "rdoRegex")
        Me.rdoRegex.Name = "rdoRegex"
        Me.rdoRegex.TabStop = True
        Me.rdoRegex.UseVisualStyleBackColor = True
        '
        'ucrSaveStringHandling
        '
        resources.ApplyResources(Me.ucrSaveStringHandling, "ucrSaveStringHandling")
        Me.ucrSaveStringHandling.Name = "ucrSaveStringHandling"
        '
        'ucrReceiverForRegexExpression
        '
        Me.ucrReceiverForRegexExpression.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverForRegexExpression, "ucrReceiverForRegexExpression")
        Me.ucrReceiverForRegexExpression.Name = "ucrReceiverForRegexExpression"
        Me.ucrReceiverForRegexExpression.Selector = Nothing
        Me.ucrReceiverForRegexExpression.strNcFilePath = ""
        Me.ucrReceiverForRegexExpression.ucrSelector = Nothing
        '
        'ucrPnlFixedRegex
        '
        resources.ApplyResources(Me.ucrPnlFixedRegex, "ucrPnlFixedRegex")
        Me.ucrPnlFixedRegex.Name = "ucrPnlFixedRegex"
        '
        'ucrChkIncludeRegularExpressions
        '
        Me.ucrChkIncludeRegularExpressions.Checked = False
        resources.ApplyResources(Me.ucrChkIncludeRegularExpressions, "ucrChkIncludeRegularExpressions")
        Me.ucrChkIncludeRegularExpressions.Name = "ucrChkIncludeRegularExpressions"
        '
        'ucrReceiverStringHandling
        '
        Me.ucrReceiverStringHandling.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverStringHandling, "ucrReceiverStringHandling")
        Me.ucrReceiverStringHandling.Name = "ucrReceiverStringHandling"
        Me.ucrReceiverStringHandling.Selector = Nothing
        Me.ucrReceiverStringHandling.strNcFilePath = ""
        Me.ucrReceiverStringHandling.ucrSelector = Nothing
        '
        'ucrInputReplaceBy
        '
        Me.ucrInputReplaceBy.AddQuotesIfUnrecognised = True
        Me.ucrInputReplaceBy.IsMultiline = False
        Me.ucrInputReplaceBy.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputReplaceBy, "ucrInputReplaceBy")
        Me.ucrInputReplaceBy.Name = "ucrInputReplaceBy"
        '
        'ucrInputPattern
        '
        Me.ucrInputPattern.AddQuotesIfUnrecognised = True
        Me.ucrInputPattern.IsMultiline = False
        Me.ucrInputPattern.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPattern, "ucrInputPattern")
        Me.ucrInputPattern.Name = "ucrInputPattern"
        '
        'ucrSelectorStringHandling
        '
        Me.ucrSelectorStringHandling.bShowHiddenColumns = False
        Me.ucrSelectorStringHandling.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorStringHandling, "ucrSelectorStringHandling")
        Me.ucrSelectorStringHandling.Name = "ucrSelectorStringHandling"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrPnlStringHandling
        '
        resources.ApplyResources(Me.ucrPnlStringHandling, "ucrPnlStringHandling")
        Me.ucrPnlStringHandling.Name = "ucrPnlStringHandling"
        '
        'dlgStringHandling
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
