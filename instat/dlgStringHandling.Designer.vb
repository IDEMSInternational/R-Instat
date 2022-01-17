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
        Me.ucrSaveStringHandling = New instat.ucrSave()
        Me.ucrReceiverForRegexExpression = New instat.ucrReceiverExpression()
        Me.ucrChkIncludeRegularExpressions = New instat.ucrCheck()
        Me.ucrReceiverStringHandling = New instat.ucrReceiverSingle()
        Me.ucrInputReplaceBy = New instat.ucrInputTextBox()
        Me.ucrInputPattern = New instat.ucrInputTextBox()
        Me.ucrSelectorStringHandling = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlStringHandling = New instat.UcrPanel()
        Me.ucrInputBoundary = New instat.ucrInputTextBox()
        Me.ucrChkBoundary = New instat.ucrCheck()
        Me.ucrChkIgnoreCase = New instat.ucrCheck()
        Me.grpModifiers = New System.Windows.Forms.GroupBox()
        Me.ucrChkComments = New instat.ucrCheck()
        Me.ucrChkMultiline = New instat.ucrCheck()
        Me.cmdAddkeyboard = New System.Windows.Forms.Button()
        Me.grpModifiers.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColumn
        '
        Me.lblColumn.AutoSize = True
        Me.lblColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumn.Location = New System.Drawing.Point(263, 55)
        Me.lblColumn.Name = "lblColumn"
        Me.lblColumn.Size = New System.Drawing.Size(45, 13)
        Me.lblColumn.TabIndex = 8
        Me.lblColumn.Text = "Column:"
        '
        'lblReplaceBy
        '
        Me.lblReplaceBy.AutoSize = True
        Me.lblReplaceBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblReplaceBy.Location = New System.Drawing.Point(264, 143)
        Me.lblReplaceBy.Name = "lblReplaceBy"
        Me.lblReplaceBy.Size = New System.Drawing.Size(65, 13)
        Me.lblReplaceBy.TabIndex = 12
        Me.lblReplaceBy.Text = "Replace By:"
        '
        'lblPattern
        '
        Me.lblPattern.AutoSize = True
        Me.lblPattern.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPattern.Location = New System.Drawing.Point(264, 97)
        Me.lblPattern.Name = "lblPattern"
        Me.lblPattern.Size = New System.Drawing.Size(44, 13)
        Me.lblPattern.TabIndex = 10
        Me.lblPattern.Text = "Pattern:"
        '
        'rdoCount
        '
        Me.rdoCount.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoCount.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCount.FlatAppearance.BorderSize = 2
        Me.rdoCount.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCount.Location = New System.Drawing.Point(10, 4)
        Me.rdoCount.Name = "rdoCount"
        Me.rdoCount.Size = New System.Drawing.Size(86, 41)
        Me.rdoCount.TabIndex = 1
        Me.rdoCount.TabStop = True
        Me.rdoCount.Text = "Count"
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
        Me.rdoReplace.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoReplace.Location = New System.Drawing.Point(328, 4)
        Me.rdoReplace.Name = "rdoReplace"
        Me.rdoReplace.Size = New System.Drawing.Size(80, 41)
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
        Me.rdoLocate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLocate.Location = New System.Drawing.Point(250, 4)
        Me.rdoLocate.Name = "rdoLocate"
        Me.rdoLocate.Size = New System.Drawing.Size(80, 41)
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
        Me.rdoExtract.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoExtract.Location = New System.Drawing.Point(172, 4)
        Me.rdoExtract.Name = "rdoExtract"
        Me.rdoExtract.Size = New System.Drawing.Size(80, 41)
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
        Me.rdoDetect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDetect.Location = New System.Drawing.Point(94, 4)
        Me.rdoDetect.Name = "rdoDetect"
        Me.rdoDetect.Size = New System.Drawing.Size(80, 41)
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
        Me.rdoReplaceAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoReplaceAll.Location = New System.Drawing.Point(404, 4)
        Me.rdoReplaceAll.Name = "rdoReplaceAll"
        Me.rdoReplaceAll.Size = New System.Drawing.Size(85, 41)
        Me.rdoReplaceAll.TabIndex = 6
        Me.rdoReplaceAll.TabStop = True
        Me.rdoReplaceAll.Text = "Replace All"
        Me.rdoReplaceAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoReplaceAll.UseVisualStyleBackColor = True
        '
        'ucrSaveStringHandling
        '
        Me.ucrSaveStringHandling.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveStringHandling.Location = New System.Drawing.Point(10, 327)
        Me.ucrSaveStringHandling.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveStringHandling.Name = "ucrSaveStringHandling"
        Me.ucrSaveStringHandling.Size = New System.Drawing.Size(366, 22)
        Me.ucrSaveStringHandling.TabIndex = 19
        '
        'ucrReceiverForRegexExpression
        '
        Me.ucrReceiverForRegexExpression.AutoSize = True
        Me.ucrReceiverForRegexExpression.frmParent = Me
        Me.ucrReceiverForRegexExpression.Location = New System.Drawing.Point(261, 114)
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
        Me.ucrChkIncludeRegularExpressions.Location = New System.Drawing.Point(10, 298)
        Me.ucrChkIncludeRegularExpressions.Name = "ucrChkIncludeRegularExpressions"
        Me.ucrChkIncludeRegularExpressions.Size = New System.Drawing.Size(239, 23)
        Me.ucrChkIncludeRegularExpressions.TabIndex = 14
        '
        'ucrReceiverStringHandling
        '
        Me.ucrReceiverStringHandling.AutoSize = True
        Me.ucrReceiverStringHandling.frmParent = Me
        Me.ucrReceiverStringHandling.Location = New System.Drawing.Point(261, 70)
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
        Me.ucrInputReplaceBy.Location = New System.Drawing.Point(261, 158)
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
        Me.ucrInputPattern.Location = New System.Drawing.Point(261, 114)
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
        Me.ucrSelectorStringHandling.Location = New System.Drawing.Point(10, 45)
        Me.ucrSelectorStringHandling.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStringHandling.Name = "ucrSelectorStringHandling"
        Me.ucrSelectorStringHandling.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorStringHandling.TabIndex = 7
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 353)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 20
        '
        'ucrPnlStringHandling
        '
        Me.ucrPnlStringHandling.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlStringHandling.Location = New System.Drawing.Point(10, 1)
        Me.ucrPnlStringHandling.Name = "ucrPnlStringHandling"
        Me.ucrPnlStringHandling.Size = New System.Drawing.Size(532, 46)
        Me.ucrPnlStringHandling.TabIndex = 0
        '
        'ucrInputBoundary
        '
        Me.ucrInputBoundary.AddQuotesIfUnrecognised = True
        Me.ucrInputBoundary.AutoSize = True
        Me.ucrInputBoundary.IsMultiline = False
        Me.ucrInputBoundary.IsReadOnly = False
        Me.ucrInputBoundary.Location = New System.Drawing.Point(172, 267)
        Me.ucrInputBoundary.Name = "ucrInputBoundary"
        Me.ucrInputBoundary.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputBoundary.TabIndex = 37
        '
        'ucrChkBoundary
        '
        Me.ucrChkBoundary.AutoSize = True
        Me.ucrChkBoundary.Checked = False
        Me.ucrChkBoundary.Location = New System.Drawing.Point(10, 268)
        Me.ucrChkBoundary.Name = "ucrChkBoundary"
        Me.ucrChkBoundary.Size = New System.Drawing.Size(140, 23)
        Me.ucrChkBoundary.TabIndex = 36
        '
        'ucrChkIgnoreCase
        '
        Me.ucrChkIgnoreCase.AutoSize = True
        Me.ucrChkIgnoreCase.Checked = False
        Me.ucrChkIgnoreCase.Location = New System.Drawing.Point(10, 238)
        Me.ucrChkIgnoreCase.Name = "ucrChkIgnoreCase"
        Me.ucrChkIgnoreCase.Size = New System.Drawing.Size(229, 23)
        Me.ucrChkIgnoreCase.TabIndex = 35
        '
        'grpModifiers
        '
        Me.grpModifiers.Controls.Add(Me.ucrChkComments)
        Me.grpModifiers.Controls.Add(Me.ucrChkMultiline)
        Me.grpModifiers.Location = New System.Drawing.Point(261, 184)
        Me.grpModifiers.Name = "grpModifiers"
        Me.grpModifiers.Size = New System.Drawing.Size(181, 77)
        Me.grpModifiers.TabIndex = 34
        Me.grpModifiers.TabStop = False
        Me.grpModifiers.Text = "Modifiers"
        '
        'ucrChkComments
        '
        Me.ucrChkComments.AutoSize = True
        Me.ucrChkComments.Checked = False
        Me.ucrChkComments.Location = New System.Drawing.Point(6, 47)
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
        'cmdAddkeyboard
        '
        Me.cmdAddkeyboard.Location = New System.Drawing.Point(267, 294)
        Me.cmdAddkeyboard.Name = "cmdAddkeyboard"
        Me.cmdAddkeyboard.Size = New System.Drawing.Size(100, 23)
        Me.cmdAddkeyboard.TabIndex = 33
        Me.cmdAddkeyboard.Text = "Add Keyboard"
        Me.cmdAddkeyboard.UseVisualStyleBackColor = True
        '
        'dlgStringHandling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(673, 411)
        Me.Controls.Add(Me.ucrInputBoundary)
        Me.Controls.Add(Me.ucrChkBoundary)
        Me.Controls.Add(Me.ucrChkIgnoreCase)
        Me.Controls.Add(Me.grpModifiers)
        Me.Controls.Add(Me.cmdAddkeyboard)
        Me.Controls.Add(Me.ucrSaveStringHandling)
        Me.Controls.Add(Me.ucrReceiverForRegexExpression)
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
        Me.grpModifiers.ResumeLayout(False)
        Me.grpModifiers.PerformLayout()
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
    Friend WithEvents ucrReceiverForRegexExpression As ucrReceiverExpression
    Friend WithEvents ucrSaveStringHandling As ucrSave
    Friend WithEvents ucrInputBoundary As ucrInputTextBox
    Friend WithEvents ucrChkBoundary As ucrCheck
    Friend WithEvents ucrChkIgnoreCase As ucrCheck
    Friend WithEvents grpModifiers As GroupBox
    Friend WithEvents ucrChkComments As ucrCheck
    Friend WithEvents ucrChkMultiline As ucrCheck
    Friend WithEvents cmdAddkeyboard As Button
End Class
