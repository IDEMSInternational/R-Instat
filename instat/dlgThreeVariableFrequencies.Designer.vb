<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ucrSelectorThreeVariableFrequencies = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlFrequencyDisplay = New instat.UcrPanel()
        Me.rdoTable = New System.Windows.Forms.RadioButton()
        Me.rdoGraph = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverGroups = New instat.ucrReceiverSingle()
        Me.lblGroupBy = New System.Windows.Forms.Label()
        Me.lblColumnFactor = New System.Windows.Forms.Label()
        Me.lblRowFactor = New System.Windows.Forms.Label()
        Me.ucrReceiverColumnFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverRowFactor = New instat.ucrReceiverSingle()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrChkWeights = New instat.ucrCheck()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrChkFlip = New instat.ucrCheck()
        Me.grpFreqType = New System.Windows.Forms.GroupBox()
        Me.rdoCount = New System.Windows.Forms.RadioButton()
        Me.rdoCell = New System.Windows.Forms.RadioButton()
        Me.rdoRow = New System.Windows.Forms.RadioButton()
        Me.rdoColumn = New System.Windows.Forms.RadioButton()
        Me.ucrPnlFreqType = New instat.UcrPanel()
        Me.grpFreqType.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrSelectorThreeVariableFrequencies
        '
        Me.ucrSelectorThreeVariableFrequencies.bShowHiddenColumns = False
        Me.ucrSelectorThreeVariableFrequencies.bUseCurrentFilter = True
        Me.ucrSelectorThreeVariableFrequencies.Location = New System.Drawing.Point(10, 45)
        Me.ucrSelectorThreeVariableFrequencies.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorThreeVariableFrequencies.Name = "ucrSelectorThreeVariableFrequencies"
        Me.ucrSelectorThreeVariableFrequencies.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorThreeVariableFrequencies.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 356)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 15
        '
        'ucrPnlFrequencyDisplay
        '
        Me.ucrPnlFrequencyDisplay.Location = New System.Drawing.Point(18, 9)
        Me.ucrPnlFrequencyDisplay.Name = "ucrPnlFrequencyDisplay"
        Me.ucrPnlFrequencyDisplay.Size = New System.Drawing.Size(384, 29)
        Me.ucrPnlFrequencyDisplay.TabIndex = 0
        '
        'rdoTable
        '
        Me.rdoTable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTable.Checked = True
        Me.rdoTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatAppearance.BorderSize = 2
        Me.rdoTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoTable.Location = New System.Drawing.Point(105, 12)
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.Size = New System.Drawing.Size(100, 28)
        Me.rdoTable.TabIndex = 1
        Me.rdoTable.TabStop = True
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
        Me.rdoGraph.Location = New System.Drawing.Point(205, 12)
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.Size = New System.Drawing.Size(100, 28)
        Me.rdoGraph.TabIndex = 2
        Me.rdoGraph.Text = "Graph"
        Me.rdoGraph.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'ucrReceiverGroups
        '
        Me.ucrReceiverGroups.frmParent = Me
        Me.ucrReceiverGroups.Location = New System.Drawing.Point(260, 98)
        Me.ucrReceiverGroups.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverGroups.Name = "ucrReceiverGroups"
        Me.ucrReceiverGroups.Selector = Nothing
        Me.ucrReceiverGroups.Size = New System.Drawing.Size(121, 20)
        Me.ucrReceiverGroups.TabIndex = 5
        Me.ucrReceiverGroups.ucrSelector = Nothing
        '
        'lblGroupBy
        '
        Me.lblGroupBy.AutoSize = True
        Me.lblGroupBy.Location = New System.Drawing.Point(260, 80)
        Me.lblGroupBy.Name = "lblGroupBy"
        Me.lblGroupBy.Size = New System.Drawing.Size(54, 13)
        Me.lblGroupBy.TabIndex = 4
        Me.lblGroupBy.Text = "Group By:"
        '
        'lblColumnFactor
        '
        Me.lblColumnFactor.AutoSize = True
        Me.lblColumnFactor.Location = New System.Drawing.Point(260, 170)
        Me.lblColumnFactor.Name = "lblColumnFactor"
        Me.lblColumnFactor.Size = New System.Drawing.Size(78, 13)
        Me.lblColumnFactor.TabIndex = 8
        Me.lblColumnFactor.Text = "Column Factor:"
        '
        'lblRowFactor
        '
        Me.lblRowFactor.AutoSize = True
        Me.lblRowFactor.Location = New System.Drawing.Point(260, 127)
        Me.lblRowFactor.Name = "lblRowFactor"
        Me.lblRowFactor.Size = New System.Drawing.Size(65, 13)
        Me.lblRowFactor.TabIndex = 6
        Me.lblRowFactor.Text = "Row Factor:"
        '
        'ucrReceiverColumnFactor
        '
        Me.ucrReceiverColumnFactor.frmParent = Me
        Me.ucrReceiverColumnFactor.Location = New System.Drawing.Point(260, 185)
        Me.ucrReceiverColumnFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnFactor.Name = "ucrReceiverColumnFactor"
        Me.ucrReceiverColumnFactor.Selector = Nothing
        Me.ucrReceiverColumnFactor.Size = New System.Drawing.Size(121, 20)
        Me.ucrReceiverColumnFactor.TabIndex = 9
        Me.ucrReceiverColumnFactor.ucrSelector = Nothing
        '
        'ucrReceiverRowFactor
        '
        Me.ucrReceiverRowFactor.frmParent = Me
        Me.ucrReceiverRowFactor.Location = New System.Drawing.Point(260, 142)
        Me.ucrReceiverRowFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRowFactor.Name = "ucrReceiverRowFactor"
        Me.ucrReceiverRowFactor.Selector = Nothing
        Me.ucrReceiverRowFactor.Size = New System.Drawing.Size(121, 20)
        Me.ucrReceiverRowFactor.TabIndex = 7
        Me.ucrReceiverRowFactor.ucrSelector = Nothing
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(10, 230)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(83, 23)
        Me.cmdOptions.TabIndex = 11
        Me.cmdOptions.Text = " Options..."
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrChkWeights
        '
        Me.ucrChkWeights.Checked = False
        Me.ucrChkWeights.Location = New System.Drawing.Point(10, 259)
        Me.ucrChkWeights.Name = "ucrChkWeights"
        Me.ucrChkWeights.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkWeights.TabIndex = 12
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.frmParent = Me
        Me.ucrReceiverWeights.Location = New System.Drawing.Point(113, 259)
        Me.ucrReceiverWeights.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWeights.TabIndex = 13
        Me.ucrReceiverWeights.ucrSelector = Nothing
        '
        'ucrChkFlip
        '
        Me.ucrChkFlip.Checked = False
        Me.ucrChkFlip.Location = New System.Drawing.Point(10, 285)
        Me.ucrChkFlip.Name = "ucrChkFlip"
        Me.ucrChkFlip.Size = New System.Drawing.Size(183, 20)
        Me.ucrChkFlip.TabIndex = 14
        '
        'grpFreqType
        '
        Me.grpFreqType.Controls.Add(Me.rdoCount)
        Me.grpFreqType.Controls.Add(Me.rdoCell)
        Me.grpFreqType.Controls.Add(Me.rdoRow)
        Me.grpFreqType.Controls.Add(Me.rdoColumn)
        Me.grpFreqType.Controls.Add(Me.ucrPnlFreqType)
        Me.grpFreqType.Location = New System.Drawing.Point(260, 208)
        Me.grpFreqType.Name = "grpFreqType"
        Me.grpFreqType.Size = New System.Drawing.Size(121, 125)
        Me.grpFreqType.TabIndex = 10
        Me.grpFreqType.TabStop = False
        Me.grpFreqType.Text = "Frequencies"
        '
        'rdoCount
        '
        Me.rdoCount.AutoSize = True
        Me.rdoCount.Location = New System.Drawing.Point(14, 19)
        Me.rdoCount.Name = "rdoCount"
        Me.rdoCount.Size = New System.Drawing.Size(53, 17)
        Me.rdoCount.TabIndex = 0
        Me.rdoCount.TabStop = True
        Me.rdoCount.Text = "Count"
        Me.rdoCount.UseVisualStyleBackColor = True
        '
        'rdoCell
        '
        Me.rdoCell.AutoSize = True
        Me.rdoCell.Location = New System.Drawing.Point(14, 95)
        Me.rdoCell.Name = "rdoCell"
        Me.rdoCell.Size = New System.Drawing.Size(59, 17)
        Me.rdoCell.TabIndex = 3
        Me.rdoCell.TabStop = True
        Me.rdoCell.Text = "Cell (%)"
        Me.rdoCell.UseVisualStyleBackColor = True
        '
        'rdoRow
        '
        Me.rdoRow.AutoSize = True
        Me.rdoRow.Location = New System.Drawing.Point(14, 43)
        Me.rdoRow.Name = "rdoRow"
        Me.rdoRow.Size = New System.Drawing.Size(64, 17)
        Me.rdoRow.TabIndex = 1
        Me.rdoRow.TabStop = True
        Me.rdoRow.Text = "Row (%)"
        Me.rdoRow.UseVisualStyleBackColor = True
        '
        'rdoColumn
        '
        Me.rdoColumn.AutoSize = True
        Me.rdoColumn.Location = New System.Drawing.Point(14, 69)
        Me.rdoColumn.Name = "rdoColumn"
        Me.rdoColumn.Size = New System.Drawing.Size(77, 17)
        Me.rdoColumn.TabIndex = 2
        Me.rdoColumn.TabStop = True
        Me.rdoColumn.Text = "Column (%)"
        Me.rdoColumn.UseVisualStyleBackColor = True
        '
        'ucrPnlFreqType
        '
        Me.ucrPnlFreqType.Location = New System.Drawing.Point(9, 17)
        Me.ucrPnlFreqType.Name = "ucrPnlFreqType"
        Me.ucrPnlFreqType.Size = New System.Drawing.Size(103, 102)
        Me.ucrPnlFreqType.TabIndex = 4
        '
        'dlgThreeVariableFrequencies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 417)
        Me.Controls.Add(Me.grpFreqType)
        Me.Controls.Add(Me.ucrChkFlip)
        Me.Controls.Add(Me.ucrReceiverWeights)
        Me.Controls.Add(Me.ucrChkWeights)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblColumnFactor)
        Me.Controls.Add(Me.lblRowFactor)
        Me.Controls.Add(Me.ucrReceiverColumnFactor)
        Me.Controls.Add(Me.ucrReceiverRowFactor)
        Me.Controls.Add(Me.lblGroupBy)
        Me.Controls.Add(Me.ucrReceiverGroups)
        Me.Controls.Add(Me.rdoTable)
        Me.Controls.Add(Me.rdoGraph)
        Me.Controls.Add(Me.ucrPnlFrequencyDisplay)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorThreeVariableFrequencies)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgThreeVariableFrequencies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Three Variable Frequencies"
        Me.grpFreqType.ResumeLayout(False)
        Me.grpFreqType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorThreeVariableFrequencies As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrPnlFrequencyDisplay As UcrPanel
    Friend WithEvents rdoTable As RadioButton
    Friend WithEvents rdoGraph As RadioButton
    Friend WithEvents ucrReceiverGroups As ucrReceiverSingle
    Friend WithEvents lblGroupBy As Label
    Friend WithEvents lblColumnFactor As Label
    Friend WithEvents lblRowFactor As Label
    Friend WithEvents ucrReceiverColumnFactor As ucrReceiverSingle
    Friend WithEvents ucrReceiverRowFactor As ucrReceiverSingle
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrChkWeights As ucrCheck
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents ucrChkFlip As ucrCheck
    Friend WithEvents grpFreqType As GroupBox
    Friend WithEvents rdoCount As RadioButton
    Friend WithEvents rdoCell As RadioButton
    Friend WithEvents rdoRow As RadioButton
    Friend WithEvents rdoColumn As RadioButton
    Friend WithEvents ucrPnlFreqType As UcrPanel
End Class
