﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgThreeVariableFrequencies
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
        Me.rdoTable = New System.Windows.Forms.RadioButton()
        Me.rdoGraph = New System.Windows.Forms.RadioButton()
        Me.lblGroupby = New System.Windows.Forms.Label()
        Me.lblColumnfactor = New System.Windows.Forms.Label()
        Me.lblRowfactor = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.rdoColumn = New System.Windows.Forms.RadioButton()
        Me.rdoRow = New System.Windows.Forms.RadioButton()
        Me.rdoCell = New System.Windows.Forms.RadioButton()
        Me.rdoCount = New System.Windows.Forms.RadioButton()
        Me.grpFreqTypeTable = New System.Windows.Forms.GroupBox()
        Me.ucrChkRow = New instat.ucrCheck()
        Me.ucrChkCount = New instat.ucrCheck()
        Me.ucrChkColumn = New instat.ucrCheck()
        Me.ucrChkCell = New instat.ucrCheck()
        Me.lblGroupsby = New System.Windows.Forms.Label()
        Me.grpFreqTypeGraph = New System.Windows.Forms.GroupBox()
        Me.ucrPnlFreqType = New instat.UcrPanel()
        Me.rdoBoth = New System.Windows.Forms.RadioButton()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrReceiverGroupBy2nd = New instat.ucrReceiverSingle()
        Me.ucrReceiverGroupsBy1st = New instat.ucrReceiverSingle()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrChkWeights = New instat.ucrCheck()
        Me.ucrReceiverColumnFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverRowFactor = New instat.ucrReceiverSingle()
        Me.ucrPnlFrequencyDisplay = New instat.UcrPanel()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorThreeVariableFrequencies = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkFlip = New instat.ucrCheck()
        Me.grpFreqTypeTable.SuspendLayout()
        Me.grpFreqTypeGraph.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoTable
        '
        Me.rdoTable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatAppearance.BorderSize = 2
        Me.rdoTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoTable.Location = New System.Drawing.Point(64, 12)
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.Size = New System.Drawing.Size(100, 28)
        Me.rdoTable.TabIndex = 1
        Me.rdoTable.Text = "Table"
        Me.rdoTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTable.UseVisualStyleBackColor = True
        '
        'rdoGraph
        '
        Me.rdoGraph.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoGraph.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGraph.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatAppearance.BorderSize = 2
        Me.rdoGraph.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGraph.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoGraph.Location = New System.Drawing.Point(162, 12)
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.Size = New System.Drawing.Size(100, 28)
        Me.rdoGraph.TabIndex = 2
        Me.rdoGraph.Text = "Graph"
        Me.rdoGraph.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'lblGroupby
        '
        Me.lblGroupby.AutoSize = True
        Me.lblGroupby.Location = New System.Drawing.Point(260, 168)
        Me.lblGroupby.Name = "lblGroupby"
        Me.lblGroupby.Size = New System.Drawing.Size(86, 13)
        Me.lblGroupby.TabIndex = 9
        Me.lblGroupby.Text = "Grouping Factor:"
        '
        'lblColumnfactor
        '
        Me.lblColumnfactor.AutoSize = True
        Me.lblColumnfactor.Location = New System.Drawing.Point(260, 124)
        Me.lblColumnfactor.Name = "lblColumnfactor"
        Me.lblColumnfactor.Size = New System.Drawing.Size(78, 13)
        Me.lblColumnfactor.TabIndex = 7
        Me.lblColumnfactor.Text = "Column Factor:"
        '
        'lblRowfactor
        '
        Me.lblRowfactor.AutoSize = True
        Me.lblRowfactor.Location = New System.Drawing.Point(260, 80)
        Me.lblRowfactor.Name = "lblRowfactor"
        Me.lblRowfactor.Size = New System.Drawing.Size(112, 13)
        Me.lblRowfactor.TabIndex = 5
        Me.lblRowfactor.Text = "Row Variable (Factor):"
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(10, 227)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(121, 23)
        Me.cmdOptions.TabIndex = 15
        Me.cmdOptions.Text = " Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'rdoColumn
        '
        Me.rdoColumn.AutoSize = True
        Me.rdoColumn.Location = New System.Drawing.Point(10, 65)
        Me.rdoColumn.Name = "rdoColumn"
        Me.rdoColumn.Size = New System.Drawing.Size(77, 17)
        Me.rdoColumn.TabIndex = 3
        Me.rdoColumn.TabStop = True
        Me.rdoColumn.Text = "Column (%)"
        Me.rdoColumn.UseVisualStyleBackColor = True
        '
        'rdoRow
        '
        Me.rdoRow.AutoSize = True
        Me.rdoRow.Location = New System.Drawing.Point(10, 42)
        Me.rdoRow.Name = "rdoRow"
        Me.rdoRow.Size = New System.Drawing.Size(64, 17)
        Me.rdoRow.TabIndex = 2
        Me.rdoRow.TabStop = True
        Me.rdoRow.Text = "Row (%)"
        Me.rdoRow.UseVisualStyleBackColor = True
        '
        'rdoCell
        '
        Me.rdoCell.AutoSize = True
        Me.rdoCell.Location = New System.Drawing.Point(10, 88)
        Me.rdoCell.Name = "rdoCell"
        Me.rdoCell.Size = New System.Drawing.Size(59, 17)
        Me.rdoCell.TabIndex = 4
        Me.rdoCell.TabStop = True
        Me.rdoCell.Text = "Cell (%)"
        Me.rdoCell.UseVisualStyleBackColor = True
        '
        'rdoCount
        '
        Me.rdoCount.AutoSize = True
        Me.rdoCount.Location = New System.Drawing.Point(10, 19)
        Me.rdoCount.Name = "rdoCount"
        Me.rdoCount.Size = New System.Drawing.Size(53, 17)
        Me.rdoCount.TabIndex = 1
        Me.rdoCount.TabStop = True
        Me.rdoCount.Text = "Count"
        Me.rdoCount.UseVisualStyleBackColor = True
        '
        'grpFreqTypeTable
        '
        Me.grpFreqTypeTable.Controls.Add(Me.ucrChkRow)
        Me.grpFreqTypeTable.Controls.Add(Me.ucrChkCount)
        Me.grpFreqTypeTable.Controls.Add(Me.ucrChkColumn)
        Me.grpFreqTypeTable.Controls.Add(Me.ucrChkCell)
        Me.grpFreqTypeTable.Location = New System.Drawing.Point(274, 255)
        Me.grpFreqTypeTable.Name = "grpFreqTypeTable"
        Me.grpFreqTypeTable.Size = New System.Drawing.Size(121, 111)
        Me.grpFreqTypeTable.TabIndex = 13
        Me.grpFreqTypeTable.TabStop = False
        Me.grpFreqTypeTable.Text = "Table Frequencies"
        '
        'ucrChkRow
        '
        Me.ucrChkRow.Checked = False
        Me.ucrChkRow.Location = New System.Drawing.Point(10, 42)
        Me.ucrChkRow.Name = "ucrChkRow"
        Me.ucrChkRow.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkRow.TabIndex = 1
        '
        'ucrChkCount
        '
        Me.ucrChkCount.Checked = False
        Me.ucrChkCount.Location = New System.Drawing.Point(10, 19)
        Me.ucrChkCount.Name = "ucrChkCount"
        Me.ucrChkCount.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkCount.TabIndex = 0
        '
        'ucrChkColumn
        '
        Me.ucrChkColumn.Checked = False
        Me.ucrChkColumn.Location = New System.Drawing.Point(10, 65)
        Me.ucrChkColumn.Name = "ucrChkColumn"
        Me.ucrChkColumn.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkColumn.TabIndex = 2
        '
        'ucrChkCell
        '
        Me.ucrChkCell.Checked = False
        Me.ucrChkCell.Location = New System.Drawing.Point(10, 88)
        Me.ucrChkCell.Name = "ucrChkCell"
        Me.ucrChkCell.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkCell.TabIndex = 3
        '
        'lblGroupsby
        '
        Me.lblGroupsby.AutoSize = True
        Me.lblGroupsby.Location = New System.Drawing.Point(260, 212)
        Me.lblGroupsby.Name = "lblGroupsby"
        Me.lblGroupsby.Size = New System.Drawing.Size(134, 13)
        Me.lblGroupsby.TabIndex = 11
        Me.lblGroupsby.Text = "Grouping Factor (Optional):"
        '
        'grpFreqTypeGraph
        '
        Me.grpFreqTypeGraph.Controls.Add(Me.rdoCount)
        Me.grpFreqTypeGraph.Controls.Add(Me.rdoColumn)
        Me.grpFreqTypeGraph.Controls.Add(Me.rdoRow)
        Me.grpFreqTypeGraph.Controls.Add(Me.rdoCell)
        Me.grpFreqTypeGraph.Controls.Add(Me.ucrPnlFreqType)
        Me.grpFreqTypeGraph.Location = New System.Drawing.Point(398, 255)
        Me.grpFreqTypeGraph.Name = "grpFreqTypeGraph"
        Me.grpFreqTypeGraph.Size = New System.Drawing.Size(121, 111)
        Me.grpFreqTypeGraph.TabIndex = 14
        Me.grpFreqTypeGraph.TabStop = False
        Me.grpFreqTypeGraph.Text = "Graph Frequencies"
        '
        'ucrPnlFreqType
        '
        Me.ucrPnlFreqType.Location = New System.Drawing.Point(7, 15)
        Me.ucrPnlFreqType.Name = "ucrPnlFreqType"
        Me.ucrPnlFreqType.Size = New System.Drawing.Size(92, 89)
        Me.ucrPnlFreqType.TabIndex = 0
        '
        'rdoBoth
        '
        Me.rdoBoth.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoBoth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoBoth.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoBoth.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoth.FlatAppearance.BorderSize = 2
        Me.rdoBoth.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoBoth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoBoth.Location = New System.Drawing.Point(260, 12)
        Me.rdoBoth.Name = "rdoBoth"
        Me.rdoBoth.Size = New System.Drawing.Size(100, 28)
        Me.rdoBoth.TabIndex = 3
        Me.rdoBoth.Text = "Both"
        Me.rdoBoth.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdoBoth.UseVisualStyleBackColor = True
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 375)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(255, 20)
        Me.ucrSaveGraph.TabIndex = 20
        '
        'ucrReceiverGroupBy2nd
        '
        Me.ucrReceiverGroupBy2nd.frmParent = Me
        Me.ucrReceiverGroupBy2nd.Location = New System.Drawing.Point(260, 227)
        Me.ucrReceiverGroupBy2nd.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverGroupBy2nd.Name = "ucrReceiverGroupBy2nd"
        Me.ucrReceiverGroupBy2nd.Selector = Nothing
        Me.ucrReceiverGroupBy2nd.Size = New System.Drawing.Size(121, 20)
        Me.ucrReceiverGroupBy2nd.TabIndex = 12
        Me.ucrReceiverGroupBy2nd.ucrSelector = Nothing
        '
        'ucrReceiverGroupsBy1st
        '
        Me.ucrReceiverGroupsBy1st.frmParent = Me
        Me.ucrReceiverGroupsBy1st.Location = New System.Drawing.Point(260, 183)
        Me.ucrReceiverGroupsBy1st.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverGroupsBy1st.Name = "ucrReceiverGroupsBy1st"
        Me.ucrReceiverGroupsBy1st.Selector = Nothing
        Me.ucrReceiverGroupsBy1st.Size = New System.Drawing.Size(121, 20)
        Me.ucrReceiverGroupsBy1st.TabIndex = 10
        Me.ucrReceiverGroupsBy1st.ucrSelector = Nothing
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.frmParent = Me
        Me.ucrReceiverWeights.Location = New System.Drawing.Point(113, 256)
        Me.ucrReceiverWeights.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.Size = New System.Drawing.Size(128, 20)
        Me.ucrReceiverWeights.TabIndex = 17
        Me.ucrReceiverWeights.ucrSelector = Nothing
        '
        'ucrChkWeights
        '
        Me.ucrChkWeights.Checked = False
        Me.ucrChkWeights.Location = New System.Drawing.Point(10, 256)
        Me.ucrChkWeights.Name = "ucrChkWeights"
        Me.ucrChkWeights.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkWeights.TabIndex = 16
        '
        'ucrReceiverColumnFactor
        '
        Me.ucrReceiverColumnFactor.frmParent = Me
        Me.ucrReceiverColumnFactor.Location = New System.Drawing.Point(260, 139)
        Me.ucrReceiverColumnFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnFactor.Name = "ucrReceiverColumnFactor"
        Me.ucrReceiverColumnFactor.Selector = Nothing
        Me.ucrReceiverColumnFactor.Size = New System.Drawing.Size(121, 20)
        Me.ucrReceiverColumnFactor.TabIndex = 8
        Me.ucrReceiverColumnFactor.ucrSelector = Nothing
        '
        'ucrReceiverRowFactor
        '
        Me.ucrReceiverRowFactor.frmParent = Me
        Me.ucrReceiverRowFactor.Location = New System.Drawing.Point(260, 95)
        Me.ucrReceiverRowFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRowFactor.Name = "ucrReceiverRowFactor"
        Me.ucrReceiverRowFactor.Selector = Nothing
        Me.ucrReceiverRowFactor.Size = New System.Drawing.Size(121, 20)
        Me.ucrReceiverRowFactor.TabIndex = 6
        Me.ucrReceiverRowFactor.ucrSelector = Nothing
        '
        'ucrPnlFrequencyDisplay
        '
        Me.ucrPnlFrequencyDisplay.Location = New System.Drawing.Point(10, 11)
        Me.ucrPnlFrequencyDisplay.Name = "ucrPnlFrequencyDisplay"
        Me.ucrPnlFrequencyDisplay.Size = New System.Drawing.Size(492, 29)
        Me.ucrPnlFrequencyDisplay.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 400)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(403, 52)
        Me.ucrBase.TabIndex = 19
        '
        'ucrSelectorThreeVariableFrequencies
        '
        Me.ucrSelectorThreeVariableFrequencies.bShowHiddenColumns = False
        Me.ucrSelectorThreeVariableFrequencies.bUseCurrentFilter = True
        Me.ucrSelectorThreeVariableFrequencies.Location = New System.Drawing.Point(10, 43)
        Me.ucrSelectorThreeVariableFrequencies.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorThreeVariableFrequencies.Name = "ucrSelectorThreeVariableFrequencies"
        Me.ucrSelectorThreeVariableFrequencies.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorThreeVariableFrequencies.TabIndex = 4
        '
        'ucrChkFlip
        '
        Me.ucrChkFlip.Checked = False
        Me.ucrChkFlip.Location = New System.Drawing.Point(10, 282)
        Me.ucrChkFlip.Name = "ucrChkFlip"
        Me.ucrChkFlip.Size = New System.Drawing.Size(183, 20)
        Me.ucrChkFlip.TabIndex = 18
        '
        'dlgThreeVariableFrequencies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 453)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.rdoBoth)
        Me.Controls.Add(Me.ucrReceiverGroupBy2nd)
        Me.Controls.Add(Me.lblGroupsby)
        Me.Controls.Add(Me.grpFreqTypeTable)
        Me.Controls.Add(Me.ucrReceiverGroupsBy1st)
        Me.Controls.Add(Me.ucrReceiverWeights)
        Me.Controls.Add(Me.ucrChkWeights)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblColumnfactor)
        Me.Controls.Add(Me.lblRowfactor)
        Me.Controls.Add(Me.ucrReceiverColumnFactor)
        Me.Controls.Add(Me.ucrReceiverRowFactor)
        Me.Controls.Add(Me.lblGroupby)
        Me.Controls.Add(Me.rdoTable)
        Me.Controls.Add(Me.rdoGraph)
        Me.Controls.Add(Me.ucrPnlFrequencyDisplay)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorThreeVariableFrequencies)
        Me.Controls.Add(Me.ucrChkFlip)
        Me.Controls.Add(Me.grpFreqTypeGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgThreeVariableFrequencies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Three Variable Frequencies"
        Me.grpFreqTypeTable.ResumeLayout(False)
        Me.grpFreqTypeGraph.ResumeLayout(False)
        Me.grpFreqTypeGraph.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorThreeVariableFrequencies As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrPnlFrequencyDisplay As UcrPanel
    Friend WithEvents rdoTable As RadioButton
    Friend WithEvents rdoGraph As RadioButton
    Friend WithEvents lblGroupby As Label
    Friend WithEvents lblColumnfactor As Label
    Friend WithEvents lblRowfactor As Label
    Friend WithEvents ucrReceiverColumnFactor As ucrReceiverSingle
    Friend WithEvents ucrReceiverRowFactor As ucrReceiverSingle
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrChkWeights As ucrCheck
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents ucrChkFlip As ucrCheck
    Friend WithEvents ucrReceiverGroupsBy1st As ucrReceiverSingle
    Friend WithEvents grpFreqTypeTable As GroupBox
    Friend WithEvents rdoCount As RadioButton
    Friend WithEvents rdoCell As RadioButton
    Friend WithEvents rdoRow As RadioButton
    Friend WithEvents rdoColumn As RadioButton
    Friend WithEvents ucrPnlFreqType As UcrPanel
    Friend WithEvents ucrChkRow As ucrCheck
    Friend WithEvents ucrChkCount As ucrCheck
    Friend WithEvents ucrChkColumn As ucrCheck
    Friend WithEvents ucrChkCell As ucrCheck
    Friend WithEvents ucrReceiverGroupBy2nd As ucrReceiverSingle
    Friend WithEvents lblGroupsby As Label
    Friend WithEvents grpFreqTypeGraph As GroupBox
    Friend WithEvents rdoBoth As RadioButton
    Friend WithEvents ucrSaveGraph As ucrSave
End Class
