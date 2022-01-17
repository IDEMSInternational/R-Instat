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
        Me.rdoDetect = New System.Windows.Forms.RadioButton()
        Me.rdoRemove = New System.Windows.Forms.RadioButton()
        Me.rdoReplaceNA = New System.Windows.Forms.RadioButton()
        Me.rdoReplace = New System.Windows.Forms.RadioButton()
        Me.rdoFind = New System.Windows.Forms.RadioButton()
        Me.grpModifiers = New System.Windows.Forms.GroupBox()
        Me.cmdAddkeyboard = New System.Windows.Forms.Button()
        Me.ucrInputBoundary = New instat.ucrInputTextBox()
        Me.ucrChkBoundary = New instat.ucrCheck()
        Me.ucrChkIgnoreCase = New instat.ucrCheck()
        Me.ucrChkComments = New instat.ucrCheck()
        Me.ucrChkMultiline = New instat.ucrCheck()
        Me.ucrSaveStringHandling = New instat.ucrSave()
        Me.ucrReceiverForRegexExpression = New instat.ucrReceiverExpression()
        Me.ucrChkIncludeRegularExpressions = New instat.ucrCheck()
        Me.ucrReceiverStringHandling = New instat.ucrReceiverSingle()
        Me.ucrInputReplaceBy = New instat.ucrInputTextBox()
        Me.ucrInputPattern = New instat.ucrInputTextBox()
        Me.ucrSelectorStringHandling = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlStringHandling = New instat.UcrPanel()
        Me.grpDetectOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkNegate = New instat.ucrCheck()
        Me.ucrPnlDetectOptions = New instat.UcrPanel()
        Me.rdoDetects = New System.Windows.Forms.RadioButton()
        Me.rdoStarts = New System.Windows.Forms.RadioButton()
        Me.rdoEnds = New System.Windows.Forms.RadioButton()
        Me.grpModifiers.SuspendLayout()
        Me.grpDetectOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColumn
        '
        Me.lblColumn.AutoSize = True
        Me.lblColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumn.Location = New System.Drawing.Point(263, 65)
        Me.lblColumn.Name = "lblColumn"
        Me.lblColumn.Size = New System.Drawing.Size(45, 13)
        Me.lblColumn.TabIndex = 8
        Me.lblColumn.Text = "Column:"
        '
        'lblReplaceBy
        '
        Me.lblReplaceBy.AutoSize = True
        Me.lblReplaceBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblReplaceBy.Location = New System.Drawing.Point(264, 153)
        Me.lblReplaceBy.Name = "lblReplaceBy"
        Me.lblReplaceBy.Size = New System.Drawing.Size(65, 13)
        Me.lblReplaceBy.TabIndex = 12
        Me.lblReplaceBy.Text = "Replace By:"
        '
        'lblPattern
        '
        Me.lblPattern.AutoSize = True
        Me.lblPattern.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPattern.Location = New System.Drawing.Point(264, 107)
        Me.lblPattern.Name = "lblPattern"
        Me.lblPattern.Size = New System.Drawing.Size(44, 13)
        Me.lblPattern.TabIndex = 10
        Me.lblPattern.Text = "Pattern:"
        '
        'rdoDetect
        '
        Me.rdoDetect.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDetect.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDetect.FlatAppearance.BorderSize = 2
        Me.rdoDetect.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDetect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDetect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDetect.Location = New System.Drawing.Point(18, 4)
        Me.rdoDetect.Name = "rdoDetect"
        Me.rdoDetect.Size = New System.Drawing.Size(86, 41)
        Me.rdoDetect.TabIndex = 1
        Me.rdoDetect.TabStop = True
        Me.rdoDetect.Text = "Detect"
        Me.rdoDetect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDetect.UseVisualStyleBackColor = True
        '
        'rdoRemove
        '
        Me.rdoRemove.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRemove.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRemove.FlatAppearance.BorderSize = 2
        Me.rdoRemove.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRemove.Location = New System.Drawing.Point(336, 4)
        Me.rdoRemove.Name = "rdoRemove"
        Me.rdoRemove.Size = New System.Drawing.Size(80, 41)
        Me.rdoRemove.TabIndex = 5
        Me.rdoRemove.TabStop = True
        Me.rdoRemove.Text = "Remove"
        Me.rdoRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRemove.UseVisualStyleBackColor = True
        '
        'rdoReplaceNA
        '
        Me.rdoReplaceNA.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoReplaceNA.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoReplaceNA.FlatAppearance.BorderSize = 2
        Me.rdoReplaceNA.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoReplaceNA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoReplaceNA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoReplaceNA.Location = New System.Drawing.Point(258, 4)
        Me.rdoReplaceNA.Name = "rdoReplaceNA"
        Me.rdoReplaceNA.Size = New System.Drawing.Size(80, 41)
        Me.rdoReplaceNA.TabIndex = 4
        Me.rdoReplaceNA.TabStop = True
        Me.rdoReplaceNA.Text = "Replace NA"
        Me.rdoReplaceNA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoReplaceNA.UseVisualStyleBackColor = True
        '
        'rdoReplace
        '
        Me.rdoReplace.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoReplace.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoReplace.FlatAppearance.BorderSize = 2
        Me.rdoReplace.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoReplace.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoReplace.Location = New System.Drawing.Point(180, 4)
        Me.rdoReplace.Name = "rdoReplace"
        Me.rdoReplace.Size = New System.Drawing.Size(80, 41)
        Me.rdoReplace.TabIndex = 3
        Me.rdoReplace.TabStop = True
        Me.rdoReplace.Text = "Replace"
        Me.rdoReplace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoReplace.UseVisualStyleBackColor = True
        '
        'rdoFind
        '
        Me.rdoFind.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoFind.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFind.FlatAppearance.BorderSize = 2
        Me.rdoFind.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoFind.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoFind.Location = New System.Drawing.Point(102, 4)
        Me.rdoFind.Name = "rdoFind"
        Me.rdoFind.Size = New System.Drawing.Size(80, 41)
        Me.rdoFind.TabIndex = 2
        Me.rdoFind.TabStop = True
        Me.rdoFind.Text = "Find"
        Me.rdoFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoFind.UseVisualStyleBackColor = True
        '
        'grpModifiers
        '
        Me.grpModifiers.Controls.Add(Me.ucrChkComments)
        Me.grpModifiers.Controls.Add(Me.ucrChkMultiline)
        Me.grpModifiers.Location = New System.Drawing.Point(10, 247)
        Me.grpModifiers.Name = "grpModifiers"
        Me.grpModifiers.Size = New System.Drawing.Size(181, 70)
        Me.grpModifiers.TabIndex = 34
        Me.grpModifiers.TabStop = False
        Me.grpModifiers.Text = "Modifiers"
        '
        'cmdAddkeyboard
        '
        Me.cmdAddkeyboard.Location = New System.Drawing.Point(267, 379)
        Me.cmdAddkeyboard.Name = "cmdAddkeyboard"
        Me.cmdAddkeyboard.Size = New System.Drawing.Size(100, 23)
        Me.cmdAddkeyboard.TabIndex = 33
        Me.cmdAddkeyboard.Text = "Add Keyboard"
        Me.cmdAddkeyboard.UseVisualStyleBackColor = True
        '
        'ucrInputBoundary
        '
        Me.ucrInputBoundary.AddQuotesIfUnrecognised = True
        Me.ucrInputBoundary.AutoSize = True
        Me.ucrInputBoundary.IsMultiline = False
        Me.ucrInputBoundary.IsReadOnly = False
        Me.ucrInputBoundary.Location = New System.Drawing.Point(172, 352)
        Me.ucrInputBoundary.Name = "ucrInputBoundary"
        Me.ucrInputBoundary.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputBoundary.TabIndex = 37
        '
        'ucrChkBoundary
        '
        Me.ucrChkBoundary.AutoSize = True
        Me.ucrChkBoundary.Checked = False
        Me.ucrChkBoundary.Location = New System.Drawing.Point(10, 353)
        Me.ucrChkBoundary.Name = "ucrChkBoundary"
        Me.ucrChkBoundary.Size = New System.Drawing.Size(140, 23)
        Me.ucrChkBoundary.TabIndex = 36
        '
        'ucrChkIgnoreCase
        '
        Me.ucrChkIgnoreCase.AutoSize = True
        Me.ucrChkIgnoreCase.Checked = False
        Me.ucrChkIgnoreCase.Location = New System.Drawing.Point(10, 323)
        Me.ucrChkIgnoreCase.Name = "ucrChkIgnoreCase"
        Me.ucrChkIgnoreCase.Size = New System.Drawing.Size(229, 23)
        Me.ucrChkIgnoreCase.TabIndex = 35
        '
        'ucrChkComments
        '
        Me.ucrChkComments.AutoSize = True
        Me.ucrChkComments.Checked = False
        Me.ucrChkComments.Location = New System.Drawing.Point(6, 41)
        Me.ucrChkComments.Name = "ucrChkComments"
        Me.ucrChkComments.Size = New System.Drawing.Size(142, 23)
        Me.ucrChkComments.TabIndex = 29
        '
        'ucrChkMultiline
        '
        Me.ucrChkMultiline.AutoSize = True
        Me.ucrChkMultiline.Checked = False
        Me.ucrChkMultiline.Location = New System.Drawing.Point(6, 17)
        Me.ucrChkMultiline.Name = "ucrChkMultiline"
        Me.ucrChkMultiline.Size = New System.Drawing.Size(142, 23)
        Me.ucrChkMultiline.TabIndex = 28
        '
        'ucrSaveStringHandling
        '
        Me.ucrSaveStringHandling.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveStringHandling.Location = New System.Drawing.Point(10, 412)
        Me.ucrSaveStringHandling.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveStringHandling.Name = "ucrSaveStringHandling"
        Me.ucrSaveStringHandling.Size = New System.Drawing.Size(366, 22)
        Me.ucrSaveStringHandling.TabIndex = 19
        '
        'ucrReceiverForRegexExpression
        '
        Me.ucrReceiverForRegexExpression.AutoSize = True
        Me.ucrReceiverForRegexExpression.frmParent = Me
        Me.ucrReceiverForRegexExpression.Location = New System.Drawing.Point(261, 124)
        Me.ucrReceiverForRegexExpression.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrReceiverForRegexExpression.Name = "ucrReceiverForRegexExpression"
        Me.ucrReceiverForRegexExpression.Selector = Nothing
        Me.ucrReceiverForRegexExpression.Size = New System.Drawing.Size(158, 28)
        Me.ucrReceiverForRegexExpression.strNcFilePath = ""
        Me.ucrReceiverForRegexExpression.TabIndex = 11
        Me.ucrReceiverForRegexExpression.ucrSelector = Nothing
        '
        'ucrChkIncludeRegularExpressions
        '
        Me.ucrChkIncludeRegularExpressions.AutoSize = True
        Me.ucrChkIncludeRegularExpressions.Checked = False
        Me.ucrChkIncludeRegularExpressions.Location = New System.Drawing.Point(10, 383)
        Me.ucrChkIncludeRegularExpressions.Name = "ucrChkIncludeRegularExpressions"
        Me.ucrChkIncludeRegularExpressions.Size = New System.Drawing.Size(239, 23)
        Me.ucrChkIncludeRegularExpressions.TabIndex = 14
        '
        'ucrReceiverStringHandling
        '
        Me.ucrReceiverStringHandling.AutoSize = True
        Me.ucrReceiverStringHandling.frmParent = Me
        Me.ucrReceiverStringHandling.Location = New System.Drawing.Point(261, 80)
        Me.ucrReceiverStringHandling.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStringHandling.Name = "ucrReceiverStringHandling"
        Me.ucrReceiverStringHandling.Selector = Nothing
        Me.ucrReceiverStringHandling.Size = New System.Drawing.Size(158, 20)
        Me.ucrReceiverStringHandling.strNcFilePath = ""
        Me.ucrReceiverStringHandling.TabIndex = 9
        Me.ucrReceiverStringHandling.ucrSelector = Nothing
        '
        'ucrInputReplaceBy
        '
        Me.ucrInputReplaceBy.AddQuotesIfUnrecognised = True
        Me.ucrInputReplaceBy.AutoSize = True
        Me.ucrInputReplaceBy.IsMultiline = False
        Me.ucrInputReplaceBy.IsReadOnly = False
        Me.ucrInputReplaceBy.Location = New System.Drawing.Point(261, 168)
        Me.ucrInputReplaceBy.Name = "ucrInputReplaceBy"
        Me.ucrInputReplaceBy.Size = New System.Drawing.Size(158, 20)
        Me.ucrInputReplaceBy.TabIndex = 13
        '
        'ucrInputPattern
        '
        Me.ucrInputPattern.AddQuotesIfUnrecognised = True
        Me.ucrInputPattern.AutoSize = True
        Me.ucrInputPattern.IsMultiline = False
        Me.ucrInputPattern.IsReadOnly = False
        Me.ucrInputPattern.Location = New System.Drawing.Point(261, 124)
        Me.ucrInputPattern.Name = "ucrInputPattern"
        Me.ucrInputPattern.Size = New System.Drawing.Size(158, 20)
        Me.ucrInputPattern.TabIndex = 12
        '
        'ucrSelectorStringHandling
        '
        Me.ucrSelectorStringHandling.AutoSize = True
        Me.ucrSelectorStringHandling.bDropUnusedFilterLevels = False
        Me.ucrSelectorStringHandling.bShowHiddenColumns = False
        Me.ucrSelectorStringHandling.bUseCurrentFilter = True
        Me.ucrSelectorStringHandling.Location = New System.Drawing.Point(10, 55)
        Me.ucrSelectorStringHandling.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStringHandling.Name = "ucrSelectorStringHandling"
        Me.ucrSelectorStringHandling.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorStringHandling.TabIndex = 7
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 438)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 20
        '
        'ucrPnlStringHandling
        '
        Me.ucrPnlStringHandling.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlStringHandling.Location = New System.Drawing.Point(13, 1)
        Me.ucrPnlStringHandling.Name = "ucrPnlStringHandling"
        Me.ucrPnlStringHandling.Size = New System.Drawing.Size(409, 46)
        Me.ucrPnlStringHandling.TabIndex = 0
        '
        'grpDetectOptions
        '
        Me.grpDetectOptions.Controls.Add(Me.rdoEnds)
        Me.grpDetectOptions.Controls.Add(Me.rdoStarts)
        Me.grpDetectOptions.Controls.Add(Me.rdoDetects)
        Me.grpDetectOptions.Controls.Add(Me.ucrPnlDetectOptions)
        Me.grpDetectOptions.Controls.Add(Me.ucrChkNegate)
        Me.grpDetectOptions.Location = New System.Drawing.Point(258, 194)
        Me.grpDetectOptions.Name = "grpDetectOptions"
        Me.grpDetectOptions.Size = New System.Drawing.Size(168, 123)
        Me.grpDetectOptions.TabIndex = 38
        Me.grpDetectOptions.TabStop = False
        Me.grpDetectOptions.Text = "Detect Options"
        '
        'ucrChkNegate
        '
        Me.ucrChkNegate.AutoSize = True
        Me.ucrChkNegate.Checked = False
        Me.ucrChkNegate.Location = New System.Drawing.Point(9, 92)
        Me.ucrChkNegate.Name = "ucrChkNegate"
        Me.ucrChkNegate.Size = New System.Drawing.Size(148, 23)
        Me.ucrChkNegate.TabIndex = 0
        '
        'ucrPnlDetectOptions
        '
        Me.ucrPnlDetectOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDetectOptions.Location = New System.Drawing.Point(4, 17)
        Me.ucrPnlDetectOptions.Name = "ucrPnlDetectOptions"
        Me.ucrPnlDetectOptions.Size = New System.Drawing.Size(159, 72)
        Me.ucrPnlDetectOptions.TabIndex = 1
        '
        'rdoDetects
        '
        Me.rdoDetects.AutoSize = True
        Me.rdoDetects.Location = New System.Drawing.Point(9, 17)
        Me.rdoDetects.Name = "rdoDetects"
        Me.rdoDetects.Size = New System.Drawing.Size(57, 17)
        Me.rdoDetects.TabIndex = 2
        Me.rdoDetects.TabStop = True
        Me.rdoDetects.Text = "Detect"
        Me.rdoDetects.UseVisualStyleBackColor = True
        '
        'rdoStarts
        '
        Me.rdoStarts.AutoSize = True
        Me.rdoStarts.Location = New System.Drawing.Point(9, 41)
        Me.rdoStarts.Name = "rdoStarts"
        Me.rdoStarts.Size = New System.Drawing.Size(52, 17)
        Me.rdoStarts.TabIndex = 3
        Me.rdoStarts.TabStop = True
        Me.rdoStarts.Text = "Starts"
        Me.rdoStarts.UseVisualStyleBackColor = True
        '
        'rdoEnds
        '
        Me.rdoEnds.AutoSize = True
        Me.rdoEnds.Location = New System.Drawing.Point(9, 65)
        Me.rdoEnds.Name = "rdoEnds"
        Me.rdoEnds.Size = New System.Drawing.Size(49, 17)
        Me.rdoEnds.TabIndex = 4
        Me.rdoEnds.TabStop = True
        Me.rdoEnds.Text = "Ends"
        Me.rdoEnds.UseVisualStyleBackColor = True
        '
        'dlgStringHandling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(438, 499)
        Me.Controls.Add(Me.grpDetectOptions)
        Me.Controls.Add(Me.ucrInputBoundary)
        Me.Controls.Add(Me.ucrChkBoundary)
        Me.Controls.Add(Me.ucrChkIgnoreCase)
        Me.Controls.Add(Me.grpModifiers)
        Me.Controls.Add(Me.cmdAddkeyboard)
        Me.Controls.Add(Me.ucrSaveStringHandling)
        Me.Controls.Add(Me.ucrReceiverForRegexExpression)
        Me.Controls.Add(Me.ucrChkIncludeRegularExpressions)
        Me.Controls.Add(Me.rdoFind)
        Me.Controls.Add(Me.rdoReplace)
        Me.Controls.Add(Me.rdoReplaceNA)
        Me.Controls.Add(Me.rdoRemove)
        Me.Controls.Add(Me.rdoDetect)
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
        Me.grpModifiers.ResumeLayout(False)
        Me.grpModifiers.PerformLayout()
        Me.grpDetectOptions.ResumeLayout(False)
        Me.grpDetectOptions.PerformLayout()
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
    Friend WithEvents rdoFind As RadioButton
    Friend WithEvents rdoReplace As RadioButton
    Friend WithEvents rdoReplaceNA As RadioButton
    Friend WithEvents rdoRemove As RadioButton
    Friend WithEvents rdoDetect As RadioButton
    Friend WithEvents ucrPnlStringHandling As UcrPanel
    Friend WithEvents ucrChkIncludeRegularExpressions As ucrCheck
    Friend WithEvents ucrReceiverForRegexExpression As ucrReceiverExpression
    Friend WithEvents ucrSaveStringHandling As ucrSave
    Friend WithEvents ucrInputBoundary As ucrInputTextBox
    Friend WithEvents ucrChkBoundary As ucrCheck
    Friend WithEvents ucrChkIgnoreCase As ucrCheck
    Friend WithEvents grpModifiers As GroupBox
    Friend WithEvents ucrChkComments As ucrCheck
    Friend WithEvents ucrChkMultiline As ucrCheck
    Friend WithEvents cmdAddkeyboard As Button
    Friend WithEvents grpDetectOptions As GroupBox
    Friend WithEvents ucrPnlDetectOptions As UcrPanel
    Friend WithEvents ucrChkNegate As ucrCheck
    Friend WithEvents rdoEnds As RadioButton
    Friend WithEvents rdoStarts As RadioButton
    Friend WithEvents rdoDetects As RadioButton
End Class
