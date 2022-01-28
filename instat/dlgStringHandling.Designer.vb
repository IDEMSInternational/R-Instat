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
        Me.rdoReplaceNa = New System.Windows.Forms.RadioButton()
        Me.rdoReplace = New System.Windows.Forms.RadioButton()
        Me.rdoFind = New System.Windows.Forms.RadioButton()
        Me.grpModifiers = New System.Windows.Forms.GroupBox()
        Me.cmdAddkeyboard = New System.Windows.Forms.Button()
        Me.grpDetectOptions = New System.Windows.Forms.GroupBox()
        Me.grpFindOptions = New System.Windows.Forms.GroupBox()
        Me.rdoLocate = New System.Windows.Forms.RadioButton()
        Me.rdoExtract = New System.Windows.Forms.RadioButton()
        Me.rdoCount = New System.Windows.Forms.RadioButton()
        Me.rdoEnds = New System.Windows.Forms.RadioButton()
        Me.rdoStarts = New System.Windows.Forms.RadioButton()
        Me.rdoDetects = New System.Windows.Forms.RadioButton()
        Me.ucrChkAll = New instat.ucrCheck()
        Me.ucrPnlFindOptions = New instat.UcrPanel()
        Me.ucrChkReplaceAll = New instat.ucrCheck()
        Me.ucrChkRemoveAll = New instat.ucrCheck()
        Me.ucrInputReplaceNaBy = New instat.ucrInputTextBox()
        Me.ucrChkReplaceBy = New instat.ucrCheck()
        Me.ucrChkNegate = New instat.ucrCheck()
        Me.ucrPnlDetectOptions = New instat.UcrPanel()
        Me.ucrInputBoundary = New instat.ucrInputTextBox()
        Me.ucrChkBoundary = New instat.ucrCheck()
        Me.ucrChkIgnoreCase = New instat.ucrCheck()
        Me.ucrChkComments = New instat.ucrCheck()
        Me.ucrChkMultiline = New instat.ucrCheck()
        Me.ucrSaveStringHandling = New instat.ucrSave()
        Me.ucrChkIncludeRegularExpressions = New instat.ucrCheck()
        Me.ucrReceiverStringHandling = New instat.ucrReceiverSingle()
        Me.ucrInputReplaceBy = New instat.ucrInputTextBox()
        Me.ucrInputPattern = New instat.ucrInputTextBox()
        Me.ucrSelectorStringHandling = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlStringHandling = New instat.UcrPanel()
        Me.grpModifiers.SuspendLayout()
        Me.grpDetectOptions.SuspendLayout()
        Me.grpFindOptions.SuspendLayout()
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
        Me.lblPattern.Location = New System.Drawing.Point(263, 97)
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
        Me.rdoDetect.Location = New System.Drawing.Point(20, 4)
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
        Me.rdoRemove.Location = New System.Drawing.Point(338, 4)
        Me.rdoRemove.Name = "rdoRemove"
        Me.rdoRemove.Size = New System.Drawing.Size(80, 41)
        Me.rdoRemove.TabIndex = 5
        Me.rdoRemove.TabStop = True
        Me.rdoRemove.Text = "Remove"
        Me.rdoRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRemove.UseVisualStyleBackColor = True
        '
        'rdoReplaceNa
        '
        Me.rdoReplaceNa.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoReplaceNa.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoReplaceNa.FlatAppearance.BorderSize = 2
        Me.rdoReplaceNa.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoReplaceNa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoReplaceNa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoReplaceNa.Location = New System.Drawing.Point(260, 4)
        Me.rdoReplaceNa.Name = "rdoReplaceNa"
        Me.rdoReplaceNa.Size = New System.Drawing.Size(80, 41)
        Me.rdoReplaceNa.TabIndex = 4
        Me.rdoReplaceNa.TabStop = True
        Me.rdoReplaceNa.Text = "Replace NA"
        Me.rdoReplaceNa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoReplaceNa.UseVisualStyleBackColor = True
        '
        'rdoReplace
        '
        Me.rdoReplace.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoReplace.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoReplace.FlatAppearance.BorderSize = 2
        Me.rdoReplace.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoReplace.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoReplace.Location = New System.Drawing.Point(182, 4)
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
        Me.rdoFind.Location = New System.Drawing.Point(104, 4)
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
        Me.grpModifiers.Location = New System.Drawing.Point(10, 231)
        Me.grpModifiers.Name = "grpModifiers"
        Me.grpModifiers.Size = New System.Drawing.Size(181, 77)
        Me.grpModifiers.TabIndex = 34
        Me.grpModifiers.TabStop = False
        Me.grpModifiers.Text = "Modifiers"
        '
        'cmdAddkeyboard
        '
        Me.cmdAddkeyboard.Location = New System.Drawing.Point(267, 373)
        Me.cmdAddkeyboard.Name = "cmdAddkeyboard"
        Me.cmdAddkeyboard.Size = New System.Drawing.Size(100, 23)
        Me.cmdAddkeyboard.TabIndex = 33
        Me.cmdAddkeyboard.Text = "Add Keyboard"
        Me.cmdAddkeyboard.UseVisualStyleBackColor = True
        '
        'grpDetectOptions
        '
        Me.grpDetectOptions.Controls.Add(Me.rdoEnds)
        Me.grpDetectOptions.Controls.Add(Me.rdoStarts)
        Me.grpDetectOptions.Controls.Add(Me.rdoDetects)
        Me.grpDetectOptions.Controls.Add(Me.ucrChkNegate)
        Me.grpDetectOptions.Controls.Add(Me.ucrPnlDetectOptions)
        Me.grpDetectOptions.Location = New System.Drawing.Point(261, 193)
        Me.grpDetectOptions.Name = "grpDetectOptions"
        Me.grpDetectOptions.Size = New System.Drawing.Size(165, 124)
        Me.grpDetectOptions.TabIndex = 38
        Me.grpDetectOptions.TabStop = False
        Me.grpDetectOptions.Text = "Detect Options"
        '
        'grpFindOptions
        '
        Me.grpFindOptions.Controls.Add(Me.ucrChkAll)
        Me.grpFindOptions.Controls.Add(Me.rdoLocate)
        Me.grpFindOptions.Controls.Add(Me.rdoExtract)
        Me.grpFindOptions.Controls.Add(Me.rdoCount)
        Me.grpFindOptions.Controls.Add(Me.ucrPnlFindOptions)
        Me.grpFindOptions.Location = New System.Drawing.Point(260, 209)
        Me.grpFindOptions.Name = "grpFindOptions"
        Me.grpFindOptions.Size = New System.Drawing.Size(171, 122)
        Me.grpFindOptions.TabIndex = 41
        Me.grpFindOptions.TabStop = False
        Me.grpFindOptions.Text = "Find Options"
        '
        'rdoLocate
        '
        Me.rdoLocate.AutoSize = True
        Me.rdoLocate.Location = New System.Drawing.Point(7, 67)
        Me.rdoLocate.Name = "rdoLocate"
        Me.rdoLocate.Size = New System.Drawing.Size(58, 17)
        Me.rdoLocate.TabIndex = 3
        Me.rdoLocate.TabStop = True
        Me.rdoLocate.Text = "Locate"
        Me.rdoLocate.UseVisualStyleBackColor = True
        '
        'rdoExtract
        '
        Me.rdoExtract.AutoSize = True
        Me.rdoExtract.Location = New System.Drawing.Point(7, 42)
        Me.rdoExtract.Name = "rdoExtract"
        Me.rdoExtract.Size = New System.Drawing.Size(58, 17)
        Me.rdoExtract.TabIndex = 2
        Me.rdoExtract.TabStop = True
        Me.rdoExtract.Text = "Extract"
        Me.rdoExtract.UseVisualStyleBackColor = True
        '
        'rdoCount
        '
        Me.rdoCount.AutoSize = True
        Me.rdoCount.Location = New System.Drawing.Point(7, 19)
        Me.rdoCount.Name = "rdoCount"
        Me.rdoCount.Size = New System.Drawing.Size(53, 17)
        Me.rdoCount.TabIndex = 1
        Me.rdoCount.TabStop = True
        Me.rdoCount.Text = "Count"
        Me.rdoCount.UseVisualStyleBackColor = True
        '
        'rdoEnds
        '
        Me.rdoEnds.AutoSize = True
        Me.rdoEnds.Location = New System.Drawing.Point(6, 69)
        Me.rdoEnds.Name = "rdoEnds"
        Me.rdoEnds.Size = New System.Drawing.Size(49, 17)
        Me.rdoEnds.TabIndex = 4
        Me.rdoEnds.TabStop = True
        Me.rdoEnds.Text = "Ends"
        Me.rdoEnds.UseVisualStyleBackColor = True
        '
        'rdoStarts
        '
        Me.rdoStarts.AutoSize = True
        Me.rdoStarts.Location = New System.Drawing.Point(6, 45)
        Me.rdoStarts.Name = "rdoStarts"
        Me.rdoStarts.Size = New System.Drawing.Size(52, 17)
        Me.rdoStarts.TabIndex = 3
        Me.rdoStarts.TabStop = True
        Me.rdoStarts.Text = "Starts"
        Me.rdoStarts.UseVisualStyleBackColor = True
        '
        'rdoDetects
        '
        Me.rdoDetects.AutoSize = True
        Me.rdoDetects.Location = New System.Drawing.Point(6, 20)
        Me.rdoDetects.Name = "rdoDetects"
        Me.rdoDetects.Size = New System.Drawing.Size(57, 17)
        Me.rdoDetects.TabIndex = 2
        Me.rdoDetects.TabStop = True
        Me.rdoDetects.Text = "Detect"
        Me.rdoDetects.UseVisualStyleBackColor = True
        '
        'ucrChkAll
        '
        Me.ucrChkAll.AutoSize = True
        Me.ucrChkAll.Checked = False
        Me.ucrChkAll.Location = New System.Drawing.Point(7, 93)
        Me.ucrChkAll.Name = "ucrChkAll"
        Me.ucrChkAll.Size = New System.Drawing.Size(147, 23)
        Me.ucrChkAll.TabIndex = 4
        '
        'ucrPnlFindOptions
        '
        Me.ucrPnlFindOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlFindOptions.Location = New System.Drawing.Point(5, 16)
        Me.ucrPnlFindOptions.Name = "ucrPnlFindOptions"
        Me.ucrPnlFindOptions.Size = New System.Drawing.Size(159, 75)
        Me.ucrPnlFindOptions.TabIndex = 0
        '
        'ucrChkReplaceAll
        '
        Me.ucrChkReplaceAll.AutoSize = True
        Me.ucrChkReplaceAll.Checked = False
        Me.ucrChkReplaceAll.Location = New System.Drawing.Point(261, 186)
        Me.ucrChkReplaceAll.Name = "ucrChkReplaceAll"
        Me.ucrChkReplaceAll.Size = New System.Drawing.Size(165, 23)
        Me.ucrChkReplaceAll.TabIndex = 42
        '
        'ucrChkRemoveAll
        '
        Me.ucrChkRemoveAll.AutoSize = True
        Me.ucrChkRemoveAll.Checked = False
        Me.ucrChkRemoveAll.Location = New System.Drawing.Point(261, 145)
        Me.ucrChkRemoveAll.Name = "ucrChkRemoveAll"
        Me.ucrChkRemoveAll.Size = New System.Drawing.Size(157, 23)
        Me.ucrChkRemoveAll.TabIndex = 41
        '
        'ucrInputReplaceNaBy
        '
        Me.ucrInputReplaceNaBy.AddQuotesIfUnrecognised = True
        Me.ucrInputReplaceNaBy.AutoSize = True
        Me.ucrInputReplaceNaBy.IsMultiline = False
        Me.ucrInputReplaceNaBy.IsReadOnly = False
        Me.ucrInputReplaceNaBy.Location = New System.Drawing.Point(350, 103)
        Me.ucrInputReplaceNaBy.Name = "ucrInputReplaceNaBy"
        Me.ucrInputReplaceNaBy.Size = New System.Drawing.Size(85, 21)
        Me.ucrInputReplaceNaBy.TabIndex = 40
        '
        'ucrChkReplaceBy
        '
        Me.ucrChkReplaceBy.AutoSize = True
        Me.ucrChkReplaceBy.Checked = False
        Me.ucrChkReplaceBy.Location = New System.Drawing.Point(261, 103)
        Me.ucrChkReplaceBy.Name = "ucrChkReplaceBy"
        Me.ucrChkReplaceBy.Size = New System.Drawing.Size(84, 23)
        Me.ucrChkReplaceBy.TabIndex = 39
        '
        'ucrChkNegate
        '
        Me.ucrChkNegate.AutoSize = True
        Me.ucrChkNegate.Checked = False
        Me.ucrChkNegate.Location = New System.Drawing.Point(7, 95)
        Me.ucrChkNegate.Name = "ucrChkNegate"
        Me.ucrChkNegate.Size = New System.Drawing.Size(150, 23)
        Me.ucrChkNegate.TabIndex = 1
        '
        'ucrPnlDetectOptions
        '
        Me.ucrPnlDetectOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDetectOptions.Location = New System.Drawing.Point(3, 16)
        Me.ucrPnlDetectOptions.Name = "ucrPnlDetectOptions"
        Me.ucrPnlDetectOptions.Size = New System.Drawing.Size(156, 75)
        Me.ucrPnlDetectOptions.TabIndex = 0
        '
        'ucrInputBoundary
        '
        Me.ucrInputBoundary.AddQuotesIfUnrecognised = True
        Me.ucrInputBoundary.AutoSize = True
        Me.ucrInputBoundary.IsMultiline = False
        Me.ucrInputBoundary.IsReadOnly = False
        Me.ucrInputBoundary.Location = New System.Drawing.Point(172, 342)
        Me.ucrInputBoundary.Name = "ucrInputBoundary"
        Me.ucrInputBoundary.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputBoundary.TabIndex = 37
        '
        'ucrChkBoundary
        '
        Me.ucrChkBoundary.AutoSize = True
        Me.ucrChkBoundary.Checked = False
        Me.ucrChkBoundary.Location = New System.Drawing.Point(10, 343)
        Me.ucrChkBoundary.Name = "ucrChkBoundary"
        Me.ucrChkBoundary.Size = New System.Drawing.Size(140, 23)
        Me.ucrChkBoundary.TabIndex = 36
        '
        'ucrChkIgnoreCase
        '
        Me.ucrChkIgnoreCase.AutoSize = True
        Me.ucrChkIgnoreCase.Checked = False
        Me.ucrChkIgnoreCase.Location = New System.Drawing.Point(10, 313)
        Me.ucrChkIgnoreCase.Name = "ucrChkIgnoreCase"
        Me.ucrChkIgnoreCase.Size = New System.Drawing.Size(229, 23)
        Me.ucrChkIgnoreCase.TabIndex = 35
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
        'ucrSaveStringHandling
        '
        Me.ucrSaveStringHandling.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveStringHandling.Location = New System.Drawing.Point(10, 402)
        Me.ucrSaveStringHandling.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveStringHandling.Name = "ucrSaveStringHandling"
        Me.ucrSaveStringHandling.Size = New System.Drawing.Size(366, 22)
        Me.ucrSaveStringHandling.TabIndex = 19
        '
        'ucrChkIncludeRegularExpressions
        '
        Me.ucrChkIncludeRegularExpressions.AutoSize = True
        Me.ucrChkIncludeRegularExpressions.Checked = False
        Me.ucrChkIncludeRegularExpressions.Location = New System.Drawing.Point(10, 373)
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
        Me.ucrBase.Location = New System.Drawing.Point(10, 428)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 20
        '
        'ucrPnlStringHandling
        '
        Me.ucrPnlStringHandling.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlStringHandling.Location = New System.Drawing.Point(16, 1)
        Me.ucrPnlStringHandling.Name = "ucrPnlStringHandling"
        Me.ucrPnlStringHandling.Size = New System.Drawing.Size(409, 46)
        Me.ucrPnlStringHandling.TabIndex = 0
        '
        'dlgStringHandling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(438, 483)
        Me.Controls.Add(Me.grpFindOptions)
        Me.Controls.Add(Me.ucrChkReplaceAll)
        Me.Controls.Add(Me.ucrChkRemoveAll)
        Me.Controls.Add(Me.ucrInputReplaceNaBy)
        Me.Controls.Add(Me.ucrChkReplaceBy)
        Me.Controls.Add(Me.grpDetectOptions)
        Me.Controls.Add(Me.ucrInputBoundary)
        Me.Controls.Add(Me.ucrChkBoundary)
        Me.Controls.Add(Me.ucrChkIgnoreCase)
        Me.Controls.Add(Me.grpModifiers)
        Me.Controls.Add(Me.cmdAddkeyboard)
        Me.Controls.Add(Me.ucrSaveStringHandling)
        Me.Controls.Add(Me.ucrChkIncludeRegularExpressions)
        Me.Controls.Add(Me.rdoFind)
        Me.Controls.Add(Me.rdoReplace)
        Me.Controls.Add(Me.rdoReplaceNa)
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
        Me.Text = "Find/Replace"
        Me.grpModifiers.ResumeLayout(False)
        Me.grpModifiers.PerformLayout()
        Me.grpDetectOptions.ResumeLayout(False)
        Me.grpDetectOptions.PerformLayout()
        Me.grpFindOptions.ResumeLayout(False)
        Me.grpFindOptions.PerformLayout()
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
    Friend WithEvents rdoReplaceNa As RadioButton
    Friend WithEvents rdoRemove As RadioButton
    Friend WithEvents rdoDetect As RadioButton
    Friend WithEvents ucrPnlStringHandling As UcrPanel
    Friend WithEvents ucrChkIncludeRegularExpressions As ucrCheck
    Friend WithEvents ucrSaveStringHandling As ucrSave
    Friend WithEvents ucrInputBoundary As ucrInputTextBox
    Friend WithEvents ucrChkBoundary As ucrCheck
    Friend WithEvents ucrChkIgnoreCase As ucrCheck
    Friend WithEvents grpModifiers As GroupBox
    Friend WithEvents ucrChkComments As ucrCheck
    Friend WithEvents ucrChkMultiline As ucrCheck
    Friend WithEvents cmdAddkeyboard As Button
    Friend WithEvents grpDetectOptions As GroupBox
    Friend WithEvents rdoEnds As RadioButton
    Friend WithEvents rdoStarts As RadioButton
    Friend WithEvents rdoDetects As RadioButton
    Friend WithEvents ucrChkNegate As ucrCheck
    Friend WithEvents ucrPnlDetectOptions As UcrPanel
    Friend WithEvents ucrInputReplaceNaBy As ucrInputTextBox
    Friend WithEvents ucrChkReplaceBy As ucrCheck
    Friend WithEvents grpFindOptions As GroupBox
    Friend WithEvents ucrPnlFindOptions As UcrPanel
    Friend WithEvents ucrChkAll As ucrCheck
    Friend WithEvents rdoLocate As RadioButton
    Friend WithEvents rdoExtract As RadioButton
    Friend WithEvents rdoCount As RadioButton
    Friend WithEvents ucrChkRemoveAll As ucrCheck
    Friend WithEvents ucrChkReplaceAll As ucrCheck
End Class
