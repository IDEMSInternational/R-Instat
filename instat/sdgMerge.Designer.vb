<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgMerge
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
        Me.components = New System.ComponentModel.Container()
        Me.ttJoinDetails = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpKeys = New System.Windows.Forms.GroupBox()
        Me.cmdAddPair = New System.Windows.Forms.Button()
        Me.lblFirstKeyMatch = New System.Windows.Forms.Label()
        Me.ucrReceiverSecondDF = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirstDF = New instat.ucrReceiverSingle()
        Me.pnlKeyColumns = New System.Windows.Forms.Panel()
        Me.cmdRemoveAll = New System.Windows.Forms.Button()
        Me.lstKeyColumns = New System.Windows.Forms.ListView()
        Me.lblKeyColumns = New System.Windows.Forms.Label()
        Me.cmdRemoveSelectedPair = New System.Windows.Forms.Button()
        Me.tbcMergeOptions = New System.Windows.Forms.TabControl()
        Me.tpJoinByOptions = New System.Windows.Forms.TabPage()
        Me.rdoChooseColumns = New System.Windows.Forms.RadioButton()
        Me.rdoByAllMatching = New System.Windows.Forms.RadioButton()
        Me.ucrSelectorSecondDF = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSelectorFirstDF = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlMergeByOptions = New instat.UcrPanel()
        Me.tpIncludeColumns = New System.Windows.Forms.TabPage()
        Me.ucrChkMergeWithSubsetSecond = New instat.ucrCheck()
        Me.ucrChkMergeWithSubsetFirst = New instat.ucrCheck()
        Me.lblVariablesToIncludeSecond = New System.Windows.Forms.Label()
        Me.lblVariablesToIncludeFirst = New System.Windows.Forms.Label()
        Me.ucrReceiverSecondSelected = New instat.ucrReceiverMultiple()
        Me.ucrReceiverFirstSelected = New instat.ucrReceiverMultiple()
        Me.ucrSelectorColumnsToIncludeSecond = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSelectorColumnsToIncludeFirst = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSubBase = New instat.ucrButtonsSubdialogue()
        Me.grpKeys.SuspendLayout()
        Me.pnlKeyColumns.SuspendLayout()
        Me.tbcMergeOptions.SuspendLayout()
        Me.tpJoinByOptions.SuspendLayout()
        Me.tpIncludeColumns.SuspendLayout()
        Me.SuspendLayout()
        '
        'ttJoinDetails
        '
        Me.ttJoinDetails.AutoPopDelay = 10000
        Me.ttJoinDetails.InitialDelay = 500
        Me.ttJoinDetails.ReshowDelay = 100
        '
        'grpKeys
        '
        Me.grpKeys.Controls.Add(Me.cmdAddPair)
        Me.grpKeys.Controls.Add(Me.lblFirstKeyMatch)
        Me.grpKeys.Controls.Add(Me.ucrReceiverSecondDF)
        Me.grpKeys.Controls.Add(Me.ucrReceiverFirstDF)
        Me.grpKeys.Location = New System.Drawing.Point(5, 243)
        Me.grpKeys.Name = "grpKeys"
        Me.grpKeys.Size = New System.Drawing.Size(335, 76)
        Me.grpKeys.TabIndex = 5
        Me.grpKeys.TabStop = False
        Me.grpKeys.Text = "Key Columns"
        '
        'cmdAddPair
        '
        Me.cmdAddPair.Location = New System.Drawing.Point(4, 46)
        Me.cmdAddPair.Name = "cmdAddPair"
        Me.cmdAddPair.Size = New System.Drawing.Size(118, 23)
        Me.cmdAddPair.TabIndex = 3
        Me.cmdAddPair.Text = "Add Pair"
        Me.cmdAddPair.UseVisualStyleBackColor = True
        '
        'lblFirstKeyMatch
        '
        Me.lblFirstKeyMatch.AutoSize = True
        Me.lblFirstKeyMatch.Location = New System.Drawing.Point(128, 22)
        Me.lblFirstKeyMatch.Name = "lblFirstKeyMatch"
        Me.lblFirstKeyMatch.Size = New System.Drawing.Size(74, 13)
        Me.lblFirstKeyMatch.TabIndex = 1
        Me.lblFirstKeyMatch.Text = "Matched With"
        '
        'ucrReceiverSecondDF
        '
        Me.ucrReceiverSecondDF.frmParent = Nothing
        Me.ucrReceiverSecondDF.Location = New System.Drawing.Point(205, 20)
        Me.ucrReceiverSecondDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondDF.Name = "ucrReceiverSecondDF"
        Me.ucrReceiverSecondDF.Selector = Nothing
        Me.ucrReceiverSecondDF.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSecondDF.strNcFilePath = ""
        Me.ucrReceiverSecondDF.TabIndex = 2
        Me.ucrReceiverSecondDF.ucrSelector = Nothing
        '
        'ucrReceiverFirstDF
        '
        Me.ucrReceiverFirstDF.frmParent = Nothing
        Me.ucrReceiverFirstDF.Location = New System.Drawing.Point(4, 20)
        Me.ucrReceiverFirstDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstDF.Name = "ucrReceiverFirstDF"
        Me.ucrReceiverFirstDF.Selector = Nothing
        Me.ucrReceiverFirstDF.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFirstDF.strNcFilePath = ""
        Me.ucrReceiverFirstDF.TabIndex = 0
        Me.ucrReceiverFirstDF.ucrSelector = Nothing
        '
        'pnlKeyColumns
        '
        Me.pnlKeyColumns.Controls.Add(Me.cmdRemoveAll)
        Me.pnlKeyColumns.Controls.Add(Me.lstKeyColumns)
        Me.pnlKeyColumns.Controls.Add(Me.lblKeyColumns)
        Me.pnlKeyColumns.Controls.Add(Me.cmdRemoveSelectedPair)
        Me.pnlKeyColumns.Location = New System.Drawing.Point(435, 65)
        Me.pnlKeyColumns.Name = "pnlKeyColumns"
        Me.pnlKeyColumns.Size = New System.Drawing.Size(194, 256)
        Me.pnlKeyColumns.TabIndex = 6
        '
        'cmdRemoveAll
        '
        Me.cmdRemoveAll.Location = New System.Drawing.Point(6, 223)
        Me.cmdRemoveAll.Name = "cmdRemoveAll"
        Me.cmdRemoveAll.Size = New System.Drawing.Size(130, 23)
        Me.cmdRemoveAll.TabIndex = 0
        Me.cmdRemoveAll.Text = "Remove All Pairs"
        Me.cmdRemoveAll.UseVisualStyleBackColor = True
        '
        'lstKeyColumns
        '
        Me.lstKeyColumns.FullRowSelect = True
        Me.lstKeyColumns.Location = New System.Drawing.Point(6, 21)
        Me.lstKeyColumns.Name = "lstKeyColumns"
        Me.lstKeyColumns.Size = New System.Drawing.Size(185, 167)
        Me.lstKeyColumns.TabIndex = 2
        Me.lstKeyColumns.UseCompatibleStateImageBehavior = False
        Me.lstKeyColumns.View = System.Windows.Forms.View.Details
        '
        'lblKeyColumns
        '
        Me.lblKeyColumns.AutoSize = True
        Me.lblKeyColumns.Location = New System.Drawing.Point(3, 5)
        Me.lblKeyColumns.Name = "lblKeyColumns"
        Me.lblKeyColumns.Size = New System.Drawing.Size(68, 13)
        Me.lblKeyColumns.TabIndex = 0
        Me.lblKeyColumns.Text = "Key Columns"
        '
        'cmdRemoveSelectedPair
        '
        Me.cmdRemoveSelectedPair.Location = New System.Drawing.Point(6, 194)
        Me.cmdRemoveSelectedPair.Name = "cmdRemoveSelectedPair"
        Me.cmdRemoveSelectedPair.Size = New System.Drawing.Size(130, 23)
        Me.cmdRemoveSelectedPair.TabIndex = 3
        Me.cmdRemoveSelectedPair.Text = "Remove Selected Pair"
        Me.cmdRemoveSelectedPair.UseVisualStyleBackColor = True
        '
        'tbcMergeOptions
        '
        Me.tbcMergeOptions.Controls.Add(Me.tpJoinByOptions)
        Me.tbcMergeOptions.Controls.Add(Me.tpIncludeColumns)
        Me.tbcMergeOptions.Location = New System.Drawing.Point(8, 8)
        Me.tbcMergeOptions.Name = "tbcMergeOptions"
        Me.tbcMergeOptions.SelectedIndex = 0
        Me.tbcMergeOptions.Size = New System.Drawing.Size(656, 393)
        Me.tbcMergeOptions.TabIndex = 0
        '
        'tpJoinByOptions
        '
        Me.tpJoinByOptions.Controls.Add(Me.rdoChooseColumns)
        Me.tpJoinByOptions.Controls.Add(Me.rdoByAllMatching)
        Me.tpJoinByOptions.Controls.Add(Me.ucrSelectorSecondDF)
        Me.tpJoinByOptions.Controls.Add(Me.ucrSelectorFirstDF)
        Me.tpJoinByOptions.Controls.Add(Me.pnlKeyColumns)
        Me.tpJoinByOptions.Controls.Add(Me.grpKeys)
        Me.tpJoinByOptions.Controls.Add(Me.ucrPnlMergeByOptions)
        Me.tpJoinByOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpJoinByOptions.Name = "tpJoinByOptions"
        Me.tpJoinByOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpJoinByOptions.Size = New System.Drawing.Size(648, 367)
        Me.tpJoinByOptions.TabIndex = 0
        Me.tpJoinByOptions.Text = "Joining Columns"
        Me.tpJoinByOptions.UseVisualStyleBackColor = True
        '
        'rdoChooseColumns
        '
        Me.rdoChooseColumns.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoChooseColumns.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoChooseColumns.FlatAppearance.BorderSize = 2
        Me.rdoChooseColumns.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoChooseColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoChooseColumns.Location = New System.Drawing.Point(316, 15)
        Me.rdoChooseColumns.Name = "rdoChooseColumns"
        Me.rdoChooseColumns.Size = New System.Drawing.Size(224, 28)
        Me.rdoChooseColumns.TabIndex = 2
        Me.rdoChooseColumns.Text = "Choose which columns to merge by"
        Me.rdoChooseColumns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoChooseColumns.UseVisualStyleBackColor = True
        '
        'rdoByAllMatching
        '
        Me.rdoByAllMatching.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoByAllMatching.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoByAllMatching.FlatAppearance.BorderSize = 2
        Me.rdoByAllMatching.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoByAllMatching.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoByAllMatching.Location = New System.Drawing.Point(94, 15)
        Me.rdoByAllMatching.Name = "rdoByAllMatching"
        Me.rdoByAllMatching.Size = New System.Drawing.Size(224, 28)
        Me.rdoByAllMatching.TabIndex = 1
        Me.rdoByAllMatching.Text = "Merge by all columns with the same name"
        Me.rdoByAllMatching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoByAllMatching.UseVisualStyleBackColor = True
        '
        'ucrSelectorSecondDF
        '
        Me.ucrSelectorSecondDF.bShowHiddenColumns = False
        Me.ucrSelectorSecondDF.bUseCurrentFilter = True
        Me.ucrSelectorSecondDF.Location = New System.Drawing.Point(222, 57)
        Me.ucrSelectorSecondDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSecondDF.Name = "ucrSelectorSecondDF"
        Me.ucrSelectorSecondDF.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorSecondDF.TabIndex = 4
        '
        'ucrSelectorFirstDF
        '
        Me.ucrSelectorFirstDF.bShowHiddenColumns = False
        Me.ucrSelectorFirstDF.bUseCurrentFilter = True
        Me.ucrSelectorFirstDF.Location = New System.Drawing.Point(6, 57)
        Me.ucrSelectorFirstDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFirstDF.Name = "ucrSelectorFirstDF"
        Me.ucrSelectorFirstDF.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorFirstDF.TabIndex = 3
        '
        'ucrPnlMergeByOptions
        '
        Me.ucrPnlMergeByOptions.Location = New System.Drawing.Point(90, 13)
        Me.ucrPnlMergeByOptions.Name = "ucrPnlMergeByOptions"
        Me.ucrPnlMergeByOptions.Size = New System.Drawing.Size(460, 42)
        Me.ucrPnlMergeByOptions.TabIndex = 0
        '
        'tpIncludeColumns
        '
        Me.tpIncludeColumns.Controls.Add(Me.ucrChkMergeWithSubsetSecond)
        Me.tpIncludeColumns.Controls.Add(Me.ucrChkMergeWithSubsetFirst)
        Me.tpIncludeColumns.Controls.Add(Me.lblVariablesToIncludeSecond)
        Me.tpIncludeColumns.Controls.Add(Me.lblVariablesToIncludeFirst)
        Me.tpIncludeColumns.Controls.Add(Me.ucrReceiverSecondSelected)
        Me.tpIncludeColumns.Controls.Add(Me.ucrReceiverFirstSelected)
        Me.tpIncludeColumns.Controls.Add(Me.ucrSelectorColumnsToIncludeSecond)
        Me.tpIncludeColumns.Controls.Add(Me.ucrSelectorColumnsToIncludeFirst)
        Me.tpIncludeColumns.Location = New System.Drawing.Point(4, 22)
        Me.tpIncludeColumns.Name = "tpIncludeColumns"
        Me.tpIncludeColumns.Padding = New System.Windows.Forms.Padding(3)
        Me.tpIncludeColumns.Size = New System.Drawing.Size(648, 367)
        Me.tpIncludeColumns.TabIndex = 1
        Me.tpIncludeColumns.Text = "Columns to Include"
        Me.tpIncludeColumns.UseVisualStyleBackColor = True
        '
        'ucrChkMergeWithSubsetSecond
        '
        Me.ucrChkMergeWithSubsetSecond.Checked = False
        Me.ucrChkMergeWithSubsetSecond.Location = New System.Drawing.Point(252, 10)
        Me.ucrChkMergeWithSubsetSecond.Name = "ucrChkMergeWithSubsetSecond"
        Me.ucrChkMergeWithSubsetSecond.Size = New System.Drawing.Size(210, 20)
        Me.ucrChkMergeWithSubsetSecond.TabIndex = 4
        '
        'ucrChkMergeWithSubsetFirst
        '
        Me.ucrChkMergeWithSubsetFirst.Checked = False
        Me.ucrChkMergeWithSubsetFirst.Location = New System.Drawing.Point(10, 10)
        Me.ucrChkMergeWithSubsetFirst.Name = "ucrChkMergeWithSubsetFirst"
        Me.ucrChkMergeWithSubsetFirst.Size = New System.Drawing.Size(206, 20)
        Me.ucrChkMergeWithSubsetFirst.TabIndex = 0
        '
        'lblVariablesToIncludeSecond
        '
        Me.lblVariablesToIncludeSecond.AutoSize = True
        Me.lblVariablesToIncludeSecond.Location = New System.Drawing.Point(249, 223)
        Me.lblVariablesToIncludeSecond.Name = "lblVariablesToIncludeSecond"
        Me.lblVariablesToIncludeSecond.Size = New System.Drawing.Size(107, 13)
        Me.lblVariablesToIncludeSecond.TabIndex = 6
        Me.lblVariablesToIncludeSecond.Text = "Variables To Include:"
        '
        'lblVariablesToIncludeFirst
        '
        Me.lblVariablesToIncludeFirst.AutoSize = True
        Me.lblVariablesToIncludeFirst.Location = New System.Drawing.Point(10, 223)
        Me.lblVariablesToIncludeFirst.Name = "lblVariablesToIncludeFirst"
        Me.lblVariablesToIncludeFirst.Size = New System.Drawing.Size(102, 13)
        Me.lblVariablesToIncludeFirst.TabIndex = 2
        Me.lblVariablesToIncludeFirst.Text = "Variable To Include:"
        '
        'ucrReceiverSecondSelected
        '
        Me.ucrReceiverSecondSelected.frmParent = Nothing
        Me.ucrReceiverSecondSelected.Location = New System.Drawing.Point(252, 238)
        Me.ucrReceiverSecondSelected.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondSelected.Name = "ucrReceiverSecondSelected"
        Me.ucrReceiverSecondSelected.Selector = Nothing
        Me.ucrReceiverSecondSelected.Size = New System.Drawing.Size(120, 119)
        Me.ucrReceiverSecondSelected.strNcFilePath = ""
        Me.ucrReceiverSecondSelected.TabIndex = 7
        Me.ucrReceiverSecondSelected.ucrSelector = Nothing
        '
        'ucrReceiverFirstSelected
        '
        Me.ucrReceiverFirstSelected.frmParent = Nothing
        Me.ucrReceiverFirstSelected.Location = New System.Drawing.Point(10, 238)
        Me.ucrReceiverFirstSelected.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstSelected.Name = "ucrReceiverFirstSelected"
        Me.ucrReceiverFirstSelected.Selector = Nothing
        Me.ucrReceiverFirstSelected.Size = New System.Drawing.Size(120, 119)
        Me.ucrReceiverFirstSelected.strNcFilePath = ""
        Me.ucrReceiverFirstSelected.TabIndex = 3
        Me.ucrReceiverFirstSelected.ucrSelector = Nothing
        '
        'ucrSelectorColumnsToIncludeSecond
        '
        Me.ucrSelectorColumnsToIncludeSecond.bShowHiddenColumns = False
        Me.ucrSelectorColumnsToIncludeSecond.bUseCurrentFilter = True
        Me.ucrSelectorColumnsToIncludeSecond.Location = New System.Drawing.Point(252, 34)
        Me.ucrSelectorColumnsToIncludeSecond.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorColumnsToIncludeSecond.Name = "ucrSelectorColumnsToIncludeSecond"
        Me.ucrSelectorColumnsToIncludeSecond.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorColumnsToIncludeSecond.TabIndex = 5
        '
        'ucrSelectorColumnsToIncludeFirst
        '
        Me.ucrSelectorColumnsToIncludeFirst.bShowHiddenColumns = False
        Me.ucrSelectorColumnsToIncludeFirst.bUseCurrentFilter = True
        Me.ucrSelectorColumnsToIncludeFirst.Location = New System.Drawing.Point(10, 34)
        Me.ucrSelectorColumnsToIncludeFirst.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorColumnsToIncludeFirst.Name = "ucrSelectorColumnsToIncludeFirst"
        Me.ucrSelectorColumnsToIncludeFirst.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorColumnsToIncludeFirst.TabIndex = 1
        '
        'ucrSubBase
        '
        Me.ucrSubBase.Location = New System.Drawing.Point(264, 407)
        Me.ucrSubBase.Name = "ucrSubBase"
        Me.ucrSubBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrSubBase.TabIndex = 0
        '
        'sdgMerge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 439)
        Me.Controls.Add(Me.tbcMergeOptions)
        Me.Controls.Add(Me.ucrSubBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgMerge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Merge Options"
        Me.grpKeys.ResumeLayout(False)
        Me.grpKeys.PerformLayout()
        Me.pnlKeyColumns.ResumeLayout(False)
        Me.pnlKeyColumns.PerformLayout()
        Me.tbcMergeOptions.ResumeLayout(False)
        Me.tpJoinByOptions.ResumeLayout(False)
        Me.tpIncludeColumns.ResumeLayout(False)
        Me.tpIncludeColumns.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSubBase As ucrButtonsSubdialogue
    Friend WithEvents ttJoinDetails As ToolTip
    Friend WithEvents ucrSelectorSecondDF As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectorFirstDF As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpKeys As GroupBox
    Friend WithEvents cmdAddPair As Button
    Friend WithEvents lblFirstKeyMatch As Label
    Friend WithEvents ucrReceiverSecondDF As ucrReceiverSingle
    Friend WithEvents tbcMergeOptions As TabControl
    Friend WithEvents tpJoinByOptions As TabPage
    Friend WithEvents pnlKeyColumns As Panel
    Friend WithEvents cmdRemoveAll As Button
    Friend WithEvents lstKeyColumns As ListView
    Friend WithEvents lblKeyColumns As Label
    Friend WithEvents cmdRemoveSelectedPair As Button
    Friend WithEvents tpIncludeColumns As TabPage
    Friend WithEvents ucrReceiverFirstDF As ucrReceiverSingle
    Friend WithEvents ucrPnlMergeByOptions As UcrPanel
    Friend WithEvents lblVariablesToIncludeSecond As Label
    Friend WithEvents lblVariablesToIncludeFirst As Label
    Friend WithEvents ucrReceiverSecondSelected As ucrReceiverMultiple
    Friend WithEvents ucrReceiverFirstSelected As ucrReceiverMultiple
    Friend WithEvents ucrSelectorColumnsToIncludeSecond As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectorColumnsToIncludeFirst As ucrSelectorByDataFrameAddRemove
    Friend WithEvents rdoChooseColumns As RadioButton
    Friend WithEvents rdoByAllMatching As RadioButton
    Friend WithEvents ucrChkMergeWithSubsetSecond As ucrCheck
    Friend WithEvents ucrChkMergeWithSubsetFirst As ucrCheck
End Class
