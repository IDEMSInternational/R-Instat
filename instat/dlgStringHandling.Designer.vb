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
        Me.ucrChkComments = New instat.ucrCheck()
        Me.ucrChkMultiline = New instat.ucrCheck()
        Me.cmdAddkeyboard = New System.Windows.Forms.Button()
        Me.grpDetectOptions = New System.Windows.Forms.GroupBox()
        Me.rdoEnds = New System.Windows.Forms.RadioButton()
        Me.rdoStarts = New System.Windows.Forms.RadioButton()
        Me.rdoDetects = New System.Windows.Forms.RadioButton()
        Me.ucrChkNegate = New instat.ucrCheck()
        Me.ucrPnlDetectOptions = New instat.UcrPanel()
        Me.grpFindOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkAll = New instat.ucrCheck()
        Me.rdoLocate = New System.Windows.Forms.RadioButton()
        Me.rdoExtract = New System.Windows.Forms.RadioButton()
        Me.rdoCount = New System.Windows.Forms.RadioButton()
        Me.ucrPnlFindOptions = New instat.UcrPanel()
        Me.grpReplaceOptions = New System.Windows.Forms.GroupBox()
        Me.rdoReplaceCell = New System.Windows.Forms.RadioButton()
        Me.rdoReplaceAll = New System.Windows.Forms.RadioButton()
        Me.rdoReplaceFirst = New System.Windows.Forms.RadioButton()
        Me.ucrPnlReplaceOptions = New instat.UcrPanel()
        Me.rdoToNa = New System.Windows.Forms.RadioButton()
        Me.grpVar = New System.Windows.Forms.GroupBox()
        Me.rdoMultiple = New System.Windows.Forms.RadioButton()
        Me.rdoSingle = New System.Windows.Forms.RadioButton()
        Me.ucrPnlColumnSelectOptions = New instat.UcrPanel()
        Me.ucrChkOverWriteColumns = New instat.ucrCheck()
        Me.ucrChkReplaceBy = New instat.ucrCheck()
        Me.ucrChkRemoveAll = New instat.ucrCheck()
        Me.ucrInputReplaceNaBy = New instat.ucrInputTextBox()
        Me.ucrInputBoundary = New instat.ucrInputTextBox()
        Me.ucrChkBoundary = New instat.ucrCheck()
        Me.ucrChkIgnoreCase = New instat.ucrCheck()
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
        Me.grpReplaceOptions.SuspendLayout()
        Me.grpVar.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColumn
        '
        Me.lblColumn.AutoSize = True
        Me.lblColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumn.Location = New System.Drawing.Point(394, 153)
        Me.lblColumn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColumn.Name = "lblColumn"
        Me.lblColumn.Size = New System.Drawing.Size(67, 20)
        Me.lblColumn.TabIndex = 8
        Me.lblColumn.Text = "Column:"
        '
        'lblReplaceBy
        '
        Me.lblReplaceBy.AutoSize = True
        Me.lblReplaceBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblReplaceBy.Location = New System.Drawing.Point(396, 259)
        Me.lblReplaceBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReplaceBy.Name = "lblReplaceBy"
        Me.lblReplaceBy.Size = New System.Drawing.Size(94, 20)
        Me.lblReplaceBy.TabIndex = 12
        Me.lblReplaceBy.Text = "Replace By:"
        '
        'lblPattern
        '
        Me.lblPattern.AutoSize = True
        Me.lblPattern.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPattern.Location = New System.Drawing.Point(394, 206)
        Me.lblPattern.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPattern.Name = "lblPattern"
        Me.lblPattern.Size = New System.Drawing.Size(65, 20)
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
        Me.rdoDetect.Location = New System.Drawing.Point(21, 6)
        Me.rdoDetect.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoDetect.Name = "rdoDetect"
        Me.rdoDetect.Size = New System.Drawing.Size(129, 62)
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
        Me.rdoRemove.Location = New System.Drawing.Point(588, 6)
        Me.rdoRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoRemove.Name = "rdoRemove"
        Me.rdoRemove.Size = New System.Drawing.Size(120, 62)
        Me.rdoRemove.TabIndex = 6
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
        Me.rdoReplaceNa.Location = New System.Drawing.Point(471, 6)
        Me.rdoReplaceNa.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoReplaceNa.Name = "rdoReplaceNa"
        Me.rdoReplaceNa.Size = New System.Drawing.Size(120, 62)
        Me.rdoReplaceNa.TabIndex = 5
        Me.rdoReplaceNa.TabStop = True
        Me.rdoReplaceNa.Text = "From NA"
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
        Me.rdoReplace.Location = New System.Drawing.Point(264, 6)
        Me.rdoReplace.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoReplace.Name = "rdoReplace"
        Me.rdoReplace.Size = New System.Drawing.Size(120, 62)
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
        Me.rdoFind.Location = New System.Drawing.Point(147, 6)
        Me.rdoFind.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoFind.Name = "rdoFind"
        Me.rdoFind.Size = New System.Drawing.Size(120, 62)
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
        Me.grpModifiers.Location = New System.Drawing.Point(15, 346)
        Me.grpModifiers.Margin = New System.Windows.Forms.Padding(4)
        Me.grpModifiers.Name = "grpModifiers"
        Me.grpModifiers.Padding = New System.Windows.Forms.Padding(4)
        Me.grpModifiers.Size = New System.Drawing.Size(272, 116)
        Me.grpModifiers.TabIndex = 34
        Me.grpModifiers.TabStop = False
        Me.grpModifiers.Text = "Modifiers"
        '
        'ucrChkComments
        '
        Me.ucrChkComments.AutoSize = True
        Me.ucrChkComments.Checked = False
        Me.ucrChkComments.Location = New System.Drawing.Point(9, 70)
        Me.ucrChkComments.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkComments.Name = "ucrChkComments"
        Me.ucrChkComments.Size = New System.Drawing.Size(213, 51)
        Me.ucrChkComments.TabIndex = 29
        '
        'ucrChkMultiline
        '
        Me.ucrChkMultiline.AutoSize = True
        Me.ucrChkMultiline.Checked = False
        Me.ucrChkMultiline.Location = New System.Drawing.Point(9, 26)
        Me.ucrChkMultiline.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkMultiline.Name = "ucrChkMultiline"
        Me.ucrChkMultiline.Size = New System.Drawing.Size(213, 51)
        Me.ucrChkMultiline.TabIndex = 28
        '
        'cmdAddkeyboard
        '
        Me.cmdAddkeyboard.Location = New System.Drawing.Point(244, 554)
        Me.cmdAddkeyboard.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAddkeyboard.Name = "cmdAddkeyboard"
        Me.cmdAddkeyboard.Size = New System.Drawing.Size(150, 33)
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
        Me.grpDetectOptions.Location = New System.Drawing.Point(392, 314)
        Me.grpDetectOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDetectOptions.Name = "grpDetectOptions"
        Me.grpDetectOptions.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDetectOptions.Size = New System.Drawing.Size(248, 186)
        Me.grpDetectOptions.TabIndex = 38
        Me.grpDetectOptions.TabStop = False
        Me.grpDetectOptions.Text = "Detect Options"
        '
        'rdoEnds
        '
        Me.rdoEnds.AutoSize = True
        Me.rdoEnds.Location = New System.Drawing.Point(9, 104)
        Me.rdoEnds.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoEnds.Name = "rdoEnds"
        Me.rdoEnds.Size = New System.Drawing.Size(71, 24)
        Me.rdoEnds.TabIndex = 4
        Me.rdoEnds.TabStop = True
        Me.rdoEnds.Text = "Ends"
        Me.rdoEnds.UseVisualStyleBackColor = True
        '
        'rdoStarts
        '
        Me.rdoStarts.AutoSize = True
        Me.rdoStarts.Location = New System.Drawing.Point(9, 68)
        Me.rdoStarts.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoStarts.Name = "rdoStarts"
        Me.rdoStarts.Size = New System.Drawing.Size(77, 24)
        Me.rdoStarts.TabIndex = 3
        Me.rdoStarts.TabStop = True
        Me.rdoStarts.Text = "Starts"
        Me.rdoStarts.UseVisualStyleBackColor = True
        '
        'rdoDetects
        '
        Me.rdoDetects.AutoSize = True
        Me.rdoDetects.Location = New System.Drawing.Point(9, 30)
        Me.rdoDetects.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoDetects.Name = "rdoDetects"
        Me.rdoDetects.Size = New System.Drawing.Size(82, 24)
        Me.rdoDetects.TabIndex = 2
        Me.rdoDetects.TabStop = True
        Me.rdoDetects.Text = "Detect"
        Me.rdoDetects.UseVisualStyleBackColor = True
        '
        'ucrChkNegate
        '
        Me.ucrChkNegate.AutoSize = True
        Me.ucrChkNegate.Checked = False
        Me.ucrChkNegate.Location = New System.Drawing.Point(10, 142)
        Me.ucrChkNegate.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkNegate.Name = "ucrChkNegate"
        Me.ucrChkNegate.Size = New System.Drawing.Size(225, 51)
        Me.ucrChkNegate.TabIndex = 1
        '
        'ucrPnlDetectOptions
        '
        Me.ucrPnlDetectOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDetectOptions.Location = New System.Drawing.Point(4, 24)
        Me.ucrPnlDetectOptions.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlDetectOptions.Name = "ucrPnlDetectOptions"
        Me.ucrPnlDetectOptions.Size = New System.Drawing.Size(234, 112)
        Me.ucrPnlDetectOptions.TabIndex = 0
        '
        'grpFindOptions
        '
        Me.grpFindOptions.Controls.Add(Me.ucrChkAll)
        Me.grpFindOptions.Controls.Add(Me.rdoLocate)
        Me.grpFindOptions.Controls.Add(Me.rdoExtract)
        Me.grpFindOptions.Controls.Add(Me.rdoCount)
        Me.grpFindOptions.Controls.Add(Me.ucrPnlFindOptions)
        Me.grpFindOptions.Location = New System.Drawing.Point(390, 330)
        Me.grpFindOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.grpFindOptions.Name = "grpFindOptions"
        Me.grpFindOptions.Padding = New System.Windows.Forms.Padding(4)
        Me.grpFindOptions.Size = New System.Drawing.Size(256, 183)
        Me.grpFindOptions.TabIndex = 41
        Me.grpFindOptions.TabStop = False
        Me.grpFindOptions.Text = "Find Options"
        '
        'ucrChkAll
        '
        Me.ucrChkAll.AutoSize = True
        Me.ucrChkAll.Checked = False
        Me.ucrChkAll.Location = New System.Drawing.Point(10, 140)
        Me.ucrChkAll.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkAll.Name = "ucrChkAll"
        Me.ucrChkAll.Size = New System.Drawing.Size(220, 51)
        Me.ucrChkAll.TabIndex = 4
        '
        'rdoLocate
        '
        Me.rdoLocate.AutoSize = True
        Me.rdoLocate.Location = New System.Drawing.Point(10, 100)
        Me.rdoLocate.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoLocate.Name = "rdoLocate"
        Me.rdoLocate.Size = New System.Drawing.Size(83, 24)
        Me.rdoLocate.TabIndex = 3
        Me.rdoLocate.TabStop = True
        Me.rdoLocate.Text = "Locate"
        Me.rdoLocate.UseVisualStyleBackColor = True
        '
        'rdoExtract
        '
        Me.rdoExtract.AutoSize = True
        Me.rdoExtract.Location = New System.Drawing.Point(10, 63)
        Me.rdoExtract.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoExtract.Name = "rdoExtract"
        Me.rdoExtract.Size = New System.Drawing.Size(84, 24)
        Me.rdoExtract.TabIndex = 2
        Me.rdoExtract.TabStop = True
        Me.rdoExtract.Text = "Extract"
        Me.rdoExtract.UseVisualStyleBackColor = True
        '
        'rdoCount
        '
        Me.rdoCount.AutoSize = True
        Me.rdoCount.Location = New System.Drawing.Point(10, 28)
        Me.rdoCount.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoCount.Name = "rdoCount"
        Me.rdoCount.Size = New System.Drawing.Size(77, 24)
        Me.rdoCount.TabIndex = 1
        Me.rdoCount.TabStop = True
        Me.rdoCount.Text = "Count"
        Me.rdoCount.UseVisualStyleBackColor = True
        '
        'ucrPnlFindOptions
        '
        Me.ucrPnlFindOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlFindOptions.Location = New System.Drawing.Point(8, 24)
        Me.ucrPnlFindOptions.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlFindOptions.Name = "ucrPnlFindOptions"
        Me.ucrPnlFindOptions.Size = New System.Drawing.Size(238, 112)
        Me.ucrPnlFindOptions.TabIndex = 0
        '
        'grpReplaceOptions
        '
        Me.grpReplaceOptions.Controls.Add(Me.rdoReplaceCell)
        Me.grpReplaceOptions.Controls.Add(Me.rdoReplaceAll)
        Me.grpReplaceOptions.Controls.Add(Me.rdoReplaceFirst)
        Me.grpReplaceOptions.Controls.Add(Me.ucrPnlReplaceOptions)
        Me.grpReplaceOptions.Location = New System.Drawing.Point(392, 335)
        Me.grpReplaceOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.grpReplaceOptions.Name = "grpReplaceOptions"
        Me.grpReplaceOptions.Padding = New System.Windows.Forms.Padding(4)
        Me.grpReplaceOptions.Size = New System.Drawing.Size(237, 150)
        Me.grpReplaceOptions.TabIndex = 42
        Me.grpReplaceOptions.TabStop = False
        Me.grpReplaceOptions.Text = "Replace Options"
        '
        'rdoReplaceCell
        '
        Me.rdoReplaceCell.AutoSize = True
        Me.rdoReplaceCell.Location = New System.Drawing.Point(24, 98)
        Me.rdoReplaceCell.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoReplaceCell.Name = "rdoReplaceCell"
        Me.rdoReplaceCell.Size = New System.Drawing.Size(60, 24)
        Me.rdoReplaceCell.TabIndex = 3
        Me.rdoReplaceCell.TabStop = True
        Me.rdoReplaceCell.Text = "Cell"
        Me.rdoReplaceCell.UseVisualStyleBackColor = True
        '
        'rdoReplaceAll
        '
        Me.rdoReplaceAll.AutoSize = True
        Me.rdoReplaceAll.Location = New System.Drawing.Point(24, 63)
        Me.rdoReplaceAll.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoReplaceAll.Name = "rdoReplaceAll"
        Me.rdoReplaceAll.Size = New System.Drawing.Size(51, 24)
        Me.rdoReplaceAll.TabIndex = 2
        Me.rdoReplaceAll.TabStop = True
        Me.rdoReplaceAll.Text = "All"
        Me.rdoReplaceAll.UseVisualStyleBackColor = True
        '
        'rdoReplaceFirst
        '
        Me.rdoReplaceFirst.AutoSize = True
        Me.rdoReplaceFirst.Location = New System.Drawing.Point(24, 28)
        Me.rdoReplaceFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoReplaceFirst.Name = "rdoReplaceFirst"
        Me.rdoReplaceFirst.Size = New System.Drawing.Size(146, 24)
        Me.rdoReplaceFirst.TabIndex = 1
        Me.rdoReplaceFirst.TabStop = True
        Me.rdoReplaceFirst.Text = "First Occurence"
        Me.rdoReplaceFirst.UseVisualStyleBackColor = True
        '
        'ucrPnlReplaceOptions
        '
        Me.ucrPnlReplaceOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlReplaceOptions.Location = New System.Drawing.Point(9, 24)
        Me.ucrPnlReplaceOptions.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlReplaceOptions.Name = "ucrPnlReplaceOptions"
        Me.ucrPnlReplaceOptions.Size = New System.Drawing.Size(219, 112)
        Me.ucrPnlReplaceOptions.TabIndex = 0
        '
        'rdoToNa
        '
        Me.rdoToNa.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoToNa.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoToNa.FlatAppearance.BorderSize = 2
        Me.rdoToNa.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoToNa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoToNa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoToNa.Location = New System.Drawing.Point(378, 6)
        Me.rdoToNa.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoToNa.Name = "rdoToNa"
        Me.rdoToNa.Size = New System.Drawing.Size(96, 62)
        Me.rdoToNa.TabIndex = 4
        Me.rdoToNa.TabStop = True
        Me.rdoToNa.Text = "To NA"
        Me.rdoToNa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoToNa.UseVisualStyleBackColor = True
        '
        'grpVar
        '
        Me.grpVar.Controls.Add(Me.rdoMultiple)
        Me.grpVar.Controls.Add(Me.rdoSingle)
        Me.grpVar.Controls.Add(Me.ucrPnlColumnSelectOptions)
        Me.grpVar.Location = New System.Drawing.Point(390, 76)
        Me.grpVar.Margin = New System.Windows.Forms.Padding(4)
        Me.grpVar.Name = "grpVar"
        Me.grpVar.Padding = New System.Windows.Forms.Padding(4)
        Me.grpVar.Size = New System.Drawing.Size(314, 64)
        Me.grpVar.TabIndex = 73
        Me.grpVar.TabStop = False
        Me.grpVar.Text = "Variables"
        '
        'rdoMultiple
        '
        Me.rdoMultiple.AutoSize = True
        Me.rdoMultiple.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMultiple.Location = New System.Drawing.Point(145, 25)
        Me.rdoMultiple.Margin = New System.Windows.Forms.Padding(6)
        Me.rdoMultiple.Name = "rdoMultiple"
        Me.rdoMultiple.Size = New System.Drawing.Size(88, 24)
        Me.rdoMultiple.TabIndex = 73
        Me.rdoMultiple.TabStop = True
        Me.rdoMultiple.Text = "Multiple"
        Me.rdoMultiple.UseVisualStyleBackColor = True
        '
        'rdoSingle
        '
        Me.rdoSingle.AutoSize = True
        Me.rdoSingle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSingle.Location = New System.Drawing.Point(15, 27)
        Me.rdoSingle.Margin = New System.Windows.Forms.Padding(6)
        Me.rdoSingle.Name = "rdoSingle"
        Me.rdoSingle.Size = New System.Drawing.Size(78, 24)
        Me.rdoSingle.TabIndex = 72
        Me.rdoSingle.TabStop = True
        Me.rdoSingle.Text = "Single"
        Me.rdoSingle.UseVisualStyleBackColor = True
        '
        'ucrPnlColumnSelectOptions
        '
        Me.ucrPnlColumnSelectOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlColumnSelectOptions.Location = New System.Drawing.Point(12, 16)
        Me.ucrPnlColumnSelectOptions.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrPnlColumnSelectOptions.Name = "ucrPnlColumnSelectOptions"
        Me.ucrPnlColumnSelectOptions.Size = New System.Drawing.Size(291, 42)
        Me.ucrPnlColumnSelectOptions.TabIndex = 71
        '
        'ucrChkOverWriteColumns
        '
        Me.ucrChkOverWriteColumns.AutoSize = True
        Me.ucrChkOverWriteColumns.Checked = False
        Me.ucrChkOverWriteColumns.Location = New System.Drawing.Point(15, 597)
        Me.ucrChkOverWriteColumns.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkOverWriteColumns.Name = "ucrChkOverWriteColumns"
        Me.ucrChkOverWriteColumns.Size = New System.Drawing.Size(181, 34)
        Me.ucrChkOverWriteColumns.TabIndex = 74
        '
        'ucrChkReplaceBy
        '
        Me.ucrChkReplaceBy.AutoSize = True
        Me.ucrChkReplaceBy.Checked = False
        Me.ucrChkReplaceBy.Location = New System.Drawing.Point(392, 212)
        Me.ucrChkReplaceBy.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkReplaceBy.Name = "ucrChkReplaceBy"
        Me.ucrChkReplaceBy.Size = New System.Drawing.Size(126, 34)
        Me.ucrChkReplaceBy.TabIndex = 39
        '
        'ucrChkRemoveAll
        '
        Me.ucrChkRemoveAll.AutoSize = True
        Me.ucrChkRemoveAll.Checked = False
        Me.ucrChkRemoveAll.Location = New System.Drawing.Point(392, 259)
        Me.ucrChkRemoveAll.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkRemoveAll.Name = "ucrChkRemoveAll"
        Me.ucrChkRemoveAll.Size = New System.Drawing.Size(236, 34)
        Me.ucrChkRemoveAll.TabIndex = 41
        '
        'ucrInputReplaceNaBy
        '
        Me.ucrInputReplaceNaBy.AddQuotesIfUnrecognised = True
        Me.ucrInputReplaceNaBy.AutoSize = True
        Me.ucrInputReplaceNaBy.IsMultiline = False
        Me.ucrInputReplaceNaBy.IsReadOnly = False
        Me.ucrInputReplaceNaBy.Location = New System.Drawing.Point(525, 215)
        Me.ucrInputReplaceNaBy.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputReplaceNaBy.Name = "ucrInputReplaceNaBy"
        Me.ucrInputReplaceNaBy.Size = New System.Drawing.Size(128, 32)
        Me.ucrInputReplaceNaBy.TabIndex = 40
        '
        'ucrInputBoundary
        '
        Me.ucrInputBoundary.AddQuotesIfUnrecognised = True
        Me.ucrInputBoundary.AutoSize = True
        Me.ucrInputBoundary.IsMultiline = False
        Me.ucrInputBoundary.IsReadOnly = False
        Me.ucrInputBoundary.Location = New System.Drawing.Point(244, 512)
        Me.ucrInputBoundary.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputBoundary.Name = "ucrInputBoundary"
        Me.ucrInputBoundary.Size = New System.Drawing.Size(126, 32)
        Me.ucrInputBoundary.TabIndex = 37
        '
        'ucrChkBoundary
        '
        Me.ucrChkBoundary.AutoSize = True
        Me.ucrChkBoundary.Checked = False
        Me.ucrChkBoundary.Location = New System.Drawing.Point(15, 512)
        Me.ucrChkBoundary.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkBoundary.Name = "ucrChkBoundary"
        Me.ucrChkBoundary.Size = New System.Drawing.Size(222, 34)
        Me.ucrChkBoundary.TabIndex = 36
        '
        'ucrChkIgnoreCase
        '
        Me.ucrChkIgnoreCase.AutoSize = True
        Me.ucrChkIgnoreCase.Checked = False
        Me.ucrChkIgnoreCase.Location = New System.Drawing.Point(15, 470)
        Me.ucrChkIgnoreCase.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkIgnoreCase.Name = "ucrChkIgnoreCase"
        Me.ucrChkIgnoreCase.Size = New System.Drawing.Size(344, 34)
        Me.ucrChkIgnoreCase.TabIndex = 35
        '
        'ucrSaveStringHandling
        '
        Me.ucrSaveStringHandling.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveStringHandling.Location = New System.Drawing.Point(15, 640)
        Me.ucrSaveStringHandling.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveStringHandling.Name = "ucrSaveStringHandling"
        Me.ucrSaveStringHandling.Size = New System.Drawing.Size(549, 33)
        Me.ucrSaveStringHandling.TabIndex = 19
        '
        'ucrChkIncludeRegularExpressions
        '
        Me.ucrChkIncludeRegularExpressions.AutoSize = True
        Me.ucrChkIncludeRegularExpressions.Checked = False
        Me.ucrChkIncludeRegularExpressions.Location = New System.Drawing.Point(15, 554)
        Me.ucrChkIncludeRegularExpressions.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkIncludeRegularExpressions.Name = "ucrChkIncludeRegularExpressions"
        Me.ucrChkIncludeRegularExpressions.Size = New System.Drawing.Size(222, 34)
        Me.ucrChkIncludeRegularExpressions.TabIndex = 14
        '
        'ucrReceiverStringHandling
        '
        Me.ucrReceiverStringHandling.AutoSize = True
        Me.ucrReceiverStringHandling.frmParent = Me
        Me.ucrReceiverStringHandling.Location = New System.Drawing.Point(392, 173)
        Me.ucrReceiverStringHandling.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStringHandling.Name = "ucrReceiverStringHandling"
        Me.ucrReceiverStringHandling.Selector = Nothing
        Me.ucrReceiverStringHandling.Size = New System.Drawing.Size(237, 30)
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
        Me.ucrInputReplaceBy.Location = New System.Drawing.Point(392, 282)
        Me.ucrInputReplaceBy.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputReplaceBy.Name = "ucrInputReplaceBy"
        Me.ucrInputReplaceBy.Size = New System.Drawing.Size(237, 30)
        Me.ucrInputReplaceBy.TabIndex = 13
        '
        'ucrInputPattern
        '
        Me.ucrInputPattern.AddQuotesIfUnrecognised = True
        Me.ucrInputPattern.AutoSize = True
        Me.ucrInputPattern.IsMultiline = False
        Me.ucrInputPattern.IsReadOnly = False
        Me.ucrInputPattern.Location = New System.Drawing.Point(392, 227)
        Me.ucrInputPattern.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputPattern.Name = "ucrInputPattern"
        Me.ucrInputPattern.Size = New System.Drawing.Size(237, 30)
        Me.ucrInputPattern.TabIndex = 12
        '
        'ucrSelectorStringHandling
        '
        Me.ucrSelectorStringHandling.AutoSize = True
        Me.ucrSelectorStringHandling.bDropUnusedFilterLevels = False
        Me.ucrSelectorStringHandling.bShowHiddenColumns = False
        Me.ucrSelectorStringHandling.bUseCurrentFilter = True
        Me.ucrSelectorStringHandling.Location = New System.Drawing.Point(15, 68)
        Me.ucrSelectorStringHandling.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStringHandling.Name = "ucrSelectorStringHandling"
        Me.ucrSelectorStringHandling.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorStringHandling.TabIndex = 7
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(16, 684)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 20
        '
        'ucrPnlStringHandling
        '
        Me.ucrPnlStringHandling.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlStringHandling.Location = New System.Drawing.Point(15, 2)
        Me.ucrPnlStringHandling.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlStringHandling.Name = "ucrPnlStringHandling"
        Me.ucrPnlStringHandling.Size = New System.Drawing.Size(693, 69)
        Me.ucrPnlStringHandling.TabIndex = 0
        '
        'dlgStringHandling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(722, 769)
        Me.Controls.Add(Me.ucrChkOverWriteColumns)
        Me.Controls.Add(Me.ucrChkReplaceBy)
        Me.Controls.Add(Me.grpVar)
        Me.Controls.Add(Me.lblReplaceBy)
        Me.Controls.Add(Me.rdoToNa)
        Me.Controls.Add(Me.ucrChkRemoveAll)
        Me.Controls.Add(Me.ucrInputReplaceNaBy)
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
        Me.Controls.Add(Me.lblColumn)
        Me.Controls.Add(Me.ucrInputReplaceBy)
        Me.Controls.Add(Me.ucrInputPattern)
        Me.Controls.Add(Me.ucrSelectorStringHandling)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlStringHandling)
        Me.Controls.Add(Me.grpReplaceOptions)
        Me.Controls.Add(Me.grpFindOptions)
        Me.Controls.Add(Me.grpDetectOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
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
        Me.grpReplaceOptions.ResumeLayout(False)
        Me.grpReplaceOptions.PerformLayout()
        Me.grpVar.ResumeLayout(False)
        Me.grpVar.PerformLayout()
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
    Friend WithEvents grpReplaceOptions As GroupBox
    Friend WithEvents rdoReplaceCell As RadioButton
    Friend WithEvents rdoReplaceAll As RadioButton
    Friend WithEvents rdoReplaceFirst As RadioButton
    Friend WithEvents ucrPnlReplaceOptions As UcrPanel
    Friend WithEvents rdoToNa As RadioButton
    Friend WithEvents grpVar As GroupBox
    Friend WithEvents ucrPnlColumnSelectOptions As UcrPanel
    Friend WithEvents rdoSingle As RadioButton
    Friend WithEvents rdoMultiple As RadioButton
    Friend WithEvents ucrChkOverWriteColumns As ucrCheck
End Class
