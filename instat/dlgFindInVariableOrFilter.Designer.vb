﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFindInVariableOrFilter
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
        Me.lblMatching = New System.Windows.Forms.Label()
        Me.cmdAddkeyboard = New System.Windows.Forms.Button()
        Me.ucrChkIncludeRegularExpressions = New instat.ucrCheck()
        Me.ucrChkIgnoreCase = New instat.ucrCheck()
        Me.ucrInputPattern = New instat.ucrInputComboBox()
        Me.grpSelect = New System.Windows.Forms.GroupBox()
        Me.rdoRow = New System.Windows.Forms.RadioButton()
        Me.rdoCell = New System.Windows.Forms.RadioButton()
        Me.ucrPnlSelect = New instat.UcrPanel()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.cmdFindNext = New System.Windows.Forms.Button()
        Me.rdoVariable = New System.Windows.Forms.RadioButton()
        Me.rdoInFilter = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrSelectorFind = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverVariable = New instat.ucrReceiverSingle()
        Me.lblPattern = New System.Windows.Forms.Label()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.ucrReceiverFilter = New instat.ucrReceiverSingle()
        Me.grpSelect.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMatching
        '
        Me.lblMatching.AutoSize = True
        Me.lblMatching.Location = New System.Drawing.Point(362, 280)
        Me.lblMatching.Name = "lblMatching"
        Me.lblMatching.Size = New System.Drawing.Size(57, 20)
        Me.lblMatching.TabIndex = 69
        Me.lblMatching.Text = "Label1"
        '
        'cmdAddkeyboard
        '
        Me.cmdAddkeyboard.Location = New System.Drawing.Point(388, 394)
        Me.cmdAddkeyboard.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAddkeyboard.Name = "cmdAddkeyboard"
        Me.cmdAddkeyboard.Size = New System.Drawing.Size(150, 34)
        Me.cmdAddkeyboard.TabIndex = 68
        Me.cmdAddkeyboard.Text = "Add Keyboard"
        Me.cmdAddkeyboard.UseVisualStyleBackColor = True
        '
        'ucrChkIncludeRegularExpressions
        '
        Me.ucrChkIncludeRegularExpressions.AutoSize = True
        Me.ucrChkIncludeRegularExpressions.Checked = False
        Me.ucrChkIncludeRegularExpressions.Location = New System.Drawing.Point(10, 394)
        Me.ucrChkIncludeRegularExpressions.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkIncludeRegularExpressions.Name = "ucrChkIncludeRegularExpressions"
        Me.ucrChkIncludeRegularExpressions.Size = New System.Drawing.Size(358, 34)
        Me.ucrChkIncludeRegularExpressions.TabIndex = 67
        '
        'ucrChkIgnoreCase
        '
        Me.ucrChkIgnoreCase.AutoSize = True
        Me.ucrChkIgnoreCase.Checked = False
        Me.ucrChkIgnoreCase.Location = New System.Drawing.Point(10, 345)
        Me.ucrChkIgnoreCase.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkIgnoreCase.Name = "ucrChkIgnoreCase"
        Me.ucrChkIgnoreCase.Size = New System.Drawing.Size(196, 34)
        Me.ucrChkIgnoreCase.TabIndex = 66
        '
        'ucrInputPattern
        '
        Me.ucrInputPattern.AddQuotesIfUnrecognised = True
        Me.ucrInputPattern.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPattern.GetSetSelectedIndex = -1
        Me.ucrInputPattern.IsReadOnly = False
        Me.ucrInputPattern.Location = New System.Drawing.Point(414, 158)
        Me.ucrInputPattern.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputPattern.Name = "ucrInputPattern"
        Me.ucrInputPattern.Size = New System.Drawing.Size(191, 32)
        Me.ucrInputPattern.TabIndex = 65
        '
        'grpSelect
        '
        Me.grpSelect.Controls.Add(Me.rdoRow)
        Me.grpSelect.Controls.Add(Me.rdoCell)
        Me.grpSelect.Controls.Add(Me.ucrPnlSelect)
        Me.grpSelect.Location = New System.Drawing.Point(414, 200)
        Me.grpSelect.Name = "grpSelect"
        Me.grpSelect.Size = New System.Drawing.Size(200, 73)
        Me.grpSelect.TabIndex = 64
        Me.grpSelect.TabStop = False
        Me.grpSelect.Text = "Selecting Option"
        '
        'rdoRow
        '
        Me.rdoRow.AutoSize = True
        Me.rdoRow.Location = New System.Drawing.Point(114, 32)
        Me.rdoRow.Name = "rdoRow"
        Me.rdoRow.Size = New System.Drawing.Size(66, 24)
        Me.rdoRow.TabIndex = 2
        Me.rdoRow.TabStop = True
        Me.rdoRow.Text = "Row"
        Me.rdoRow.UseVisualStyleBackColor = True
        '
        'rdoCell
        '
        Me.rdoCell.AutoSize = True
        Me.rdoCell.Location = New System.Drawing.Point(15, 32)
        Me.rdoCell.Name = "rdoCell"
        Me.rdoCell.Size = New System.Drawing.Size(60, 24)
        Me.rdoCell.TabIndex = 1
        Me.rdoCell.TabStop = True
        Me.rdoCell.Text = "Cell"
        Me.rdoCell.UseVisualStyleBackColor = True
        '
        'ucrPnlSelect
        '
        Me.ucrPnlSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSelect.Location = New System.Drawing.Point(9, 20)
        Me.ucrPnlSelect.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrPnlSelect.Name = "ucrPnlSelect"
        Me.ucrPnlSelect.Size = New System.Drawing.Size(182, 47)
        Me.ucrPnlSelect.TabIndex = 0
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(414, 138)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(48, 20)
        Me.lblFilter.TabIndex = 63
        Me.lblFilter.Text = "Filter:"
        '
        'cmdFindNext
        '
        Me.cmdFindNext.Location = New System.Drawing.Point(414, 346)
        Me.cmdFindNext.Name = "cmdFindNext"
        Me.cmdFindNext.Size = New System.Drawing.Size(180, 36)
        Me.cmdFindNext.TabIndex = 61
        Me.cmdFindNext.Text = "Find Next"
        Me.cmdFindNext.UseVisualStyleBackColor = True
        Me.cmdFindNext.Visible = False
        '
        'rdoVariable
        '
        Me.rdoVariable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoVariable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoVariable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVariable.FlatAppearance.BorderSize = 2
        Me.rdoVariable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoVariable.Location = New System.Drawing.Point(107, 14)
        Me.rdoVariable.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoVariable.Name = "rdoVariable"
        Me.rdoVariable.Size = New System.Drawing.Size(202, 40)
        Me.rdoVariable.TabIndex = 54
        Me.rdoVariable.Text = "Variable"
        Me.rdoVariable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoVariable.UseVisualStyleBackColor = True
        '
        'rdoInFilter
        '
        Me.rdoInFilter.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoInFilter.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInFilter.FlatAppearance.BorderSize = 2
        Me.rdoInFilter.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoInFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoInFilter.Location = New System.Drawing.Point(306, 14)
        Me.rdoInFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoInFilter.Name = "rdoInFilter"
        Me.rdoInFilter.Size = New System.Drawing.Size(202, 40)
        Me.rdoInFilter.TabIndex = 55
        Me.rdoInFilter.Text = "In Filter"
        Me.rdoInFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoInFilter.UseVisualStyleBackColor = True
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(99, 12)
        Me.ucrPnlOptions.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(417, 52)
        Me.ucrPnlOptions.TabIndex = 53
        '
        'ucrSelectorFind
        '
        Me.ucrSelectorFind.AutoSize = True
        Me.ucrSelectorFind.bDropUnusedFilterLevels = False
        Me.ucrSelectorFind.bShowHiddenColumns = False
        Me.ucrSelectorFind.bUseCurrentFilter = True
        Me.ucrSelectorFind.Location = New System.Drawing.Point(10, 65)
        Me.ucrSelectorFind.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFind.Name = "ucrSelectorFind"
        Me.ucrSelectorFind.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorFind.TabIndex = 56
        '
        'ucrReceiverVariable
        '
        Me.ucrReceiverVariable.AutoSize = True
        Me.ucrReceiverVariable.frmParent = Me
        Me.ucrReceiverVariable.Location = New System.Drawing.Point(414, 101)
        Me.ucrReceiverVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVariable.Name = "ucrReceiverVariable"
        Me.ucrReceiverVariable.Selector = Nothing
        Me.ucrReceiverVariable.Size = New System.Drawing.Size(191, 30)
        Me.ucrReceiverVariable.strNcFilePath = ""
        Me.ucrReceiverVariable.TabIndex = 58
        Me.ucrReceiverVariable.ucrSelector = Nothing
        '
        'lblPattern
        '
        Me.lblPattern.AutoSize = True
        Me.lblPattern.Location = New System.Drawing.Point(414, 138)
        Me.lblPattern.Name = "lblPattern"
        Me.lblPattern.Size = New System.Drawing.Size(65, 20)
        Me.lblPattern.TabIndex = 59
        Me.lblPattern.Text = "Pattern:"
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.Location = New System.Drawing.Point(414, 78)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(71, 20)
        Me.lblVariable.TabIndex = 57
        Me.lblVariable.Text = "Variable:"
        '
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(414, 306)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(180, 36)
        Me.cmdFind.TabIndex = 60
        Me.cmdFind.Text = "Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'ucrReceiverFilter
        '
        Me.ucrReceiverFilter.AutoSize = True
        Me.ucrReceiverFilter.frmParent = Me
        Me.ucrReceiverFilter.Location = New System.Drawing.Point(414, 160)
        Me.ucrReceiverFilter.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFilter.Name = "ucrReceiverFilter"
        Me.ucrReceiverFilter.Selector = Nothing
        Me.ucrReceiverFilter.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverFilter.strNcFilePath = ""
        Me.ucrReceiverFilter.TabIndex = 62
        Me.ucrReceiverFilter.ucrSelector = Nothing
        '
        'dlgFindInVariableOrFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(625, 440)
        Me.Controls.Add(Me.lblMatching)
        Me.Controls.Add(Me.cmdAddkeyboard)
        Me.Controls.Add(Me.ucrChkIncludeRegularExpressions)
        Me.Controls.Add(Me.ucrChkIgnoreCase)
        Me.Controls.Add(Me.ucrInputPattern)
        Me.Controls.Add(Me.grpSelect)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.cmdFindNext)
        Me.Controls.Add(Me.rdoVariable)
        Me.Controls.Add(Me.rdoInFilter)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrSelectorFind)
        Me.Controls.Add(Me.ucrReceiverVariable)
        Me.Controls.Add(Me.lblPattern)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.ucrReceiverFilter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgFindInVariableOrFilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find In Variable Or Filter"
        Me.grpSelect.ResumeLayout(False)
        Me.grpSelect.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMatching As Label
    Friend WithEvents cmdAddkeyboard As Button
    Friend WithEvents ucrChkIncludeRegularExpressions As ucrCheck
    Friend WithEvents ucrChkIgnoreCase As ucrCheck
    Friend WithEvents ucrInputPattern As ucrInputComboBox
    Friend WithEvents grpSelect As GroupBox
    Friend WithEvents rdoRow As RadioButton
    Friend WithEvents rdoCell As RadioButton
    Friend WithEvents ucrPnlSelect As UcrPanel
    Friend WithEvents lblFilter As Label
    Friend WithEvents cmdFindNext As Button
    Friend WithEvents rdoVariable As RadioButton
    Friend WithEvents rdoInFilter As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents ucrSelectorFind As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverVariable As ucrReceiverSingle
    Friend WithEvents lblPattern As Label
    Friend WithEvents lblVariable As Label
    Friend WithEvents cmdFind As Button
    Friend WithEvents ucrReceiverFilter As ucrReceiverSingle
End Class
