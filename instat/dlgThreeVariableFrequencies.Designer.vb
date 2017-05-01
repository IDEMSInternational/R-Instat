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
        Me.lblGroupby = New System.Windows.Forms.Label()
        Me.lblColumnfactor = New System.Windows.Forms.Label()
        Me.lblRowfactor = New System.Windows.Forms.Label()
        Me.ucrReceiverColumnFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverRowFactor = New instat.ucrReceiverSingle()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrChkWeights = New instat.ucrCheck()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrChkFlip = New instat.ucrCheck()
        Me.ucrReceiverGroups = New instat.ucrReceiverSingle()
        Me.ucrPnlFreqType = New instat.UcrPanel()
        Me.rdoColumn = New System.Windows.Forms.RadioButton()
        Me.rdoRow = New System.Windows.Forms.RadioButton()
        Me.rdoCell = New System.Windows.Forms.RadioButton()
        Me.rdoCount = New System.Windows.Forms.RadioButton()
        Me.grpFreqType = New System.Windows.Forms.GroupBox()
        Me.ucrChkRow = New instat.ucrCheck()
        Me.ucrChkCount = New instat.ucrCheck()
        Me.ucrChkColumn = New instat.ucrCheck()
        Me.ucrChkCell = New instat.ucrCheck()
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
        Me.ucrBase.Location = New System.Drawing.Point(10, 338)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(403, 52)
        Me.ucrBase.TabIndex = 15
        '
        'ucrPnlFrequencyDisplay
        '
        Me.ucrPnlFrequencyDisplay.Location = New System.Drawing.Point(10, 9)
        Me.ucrPnlFrequencyDisplay.Name = "ucrPnlFrequencyDisplay"
        Me.ucrPnlFrequencyDisplay.Size = New System.Drawing.Size(384, 29)
        Me.ucrPnlFrequencyDisplay.TabIndex = 0
        '
        'rdoTable
        '
        Me.rdoTable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatAppearance.BorderSize = 2
        Me.rdoTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoTable.Location = New System.Drawing.Point(99, 10)
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
        Me.rdoGraph.Location = New System.Drawing.Point(197, 10)
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
        Me.lblGroupby.Location = New System.Drawing.Point(260, 178)
        Me.lblGroupby.Name = "lblGroupby"
        Me.lblGroupby.Size = New System.Drawing.Size(53, 13)
        Me.lblGroupby.TabIndex = 8
        Me.lblGroupby.Text = "Group by:"
        '
        'lblColumnfactor
        '
        Me.lblColumnfactor.AutoSize = True
        Me.lblColumnfactor.Location = New System.Drawing.Point(260, 129)
        Me.lblColumnfactor.Name = "lblColumnfactor"
        Me.lblColumnfactor.Size = New System.Drawing.Size(78, 13)
        Me.lblColumnfactor.TabIndex = 6
        Me.lblColumnfactor.Text = "Column Factor:"
        '
        'lblRowfactor
        '
        Me.lblRowfactor.AutoSize = True
        Me.lblRowfactor.Location = New System.Drawing.Point(260, 80)
        Me.lblRowfactor.Name = "lblRowfactor"
        Me.lblRowfactor.Size = New System.Drawing.Size(65, 13)
        Me.lblRowfactor.TabIndex = 4
        Me.lblRowfactor.Text = "Row Factor:"
        '
        'ucrReceiverColumnFactor
        '
        Me.ucrReceiverColumnFactor.frmParent = Me
        Me.ucrReceiverColumnFactor.Location = New System.Drawing.Point(260, 144)
        Me.ucrReceiverColumnFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnFactor.Name = "ucrReceiverColumnFactor"
        Me.ucrReceiverColumnFactor.Selector = Nothing
        Me.ucrReceiverColumnFactor.Size = New System.Drawing.Size(121, 20)
        Me.ucrReceiverColumnFactor.TabIndex = 7
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
        Me.ucrReceiverRowFactor.TabIndex = 5
        Me.ucrReceiverRowFactor.ucrSelector = Nothing
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(10, 230)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(83, 23)
        Me.cmdOptions.TabIndex = 10
        Me.cmdOptions.Text = " Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrChkWeights
        '
        Me.ucrChkWeights.Checked = False
        Me.ucrChkWeights.Location = New System.Drawing.Point(10, 259)
        Me.ucrChkWeights.Name = "ucrChkWeights"
        Me.ucrChkWeights.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkWeights.TabIndex = 11
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.frmParent = Me
        Me.ucrReceiverWeights.Location = New System.Drawing.Point(113, 259)
        Me.ucrReceiverWeights.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWeights.TabIndex = 12
        Me.ucrReceiverWeights.ucrSelector = Nothing
        '
        'ucrChkFlip
        '
        Me.ucrChkFlip.Checked = False
        Me.ucrChkFlip.Location = New System.Drawing.Point(10, 285)
        Me.ucrChkFlip.Name = "ucrChkFlip"
        Me.ucrChkFlip.Size = New System.Drawing.Size(183, 20)
        Me.ucrChkFlip.TabIndex = 13
        '
        'ucrReceiverGroups
        '
        Me.ucrReceiverGroups.frmParent = Me
        Me.ucrReceiverGroups.Location = New System.Drawing.Point(260, 193)
        Me.ucrReceiverGroups.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverGroups.Name = "ucrReceiverGroups"
        Me.ucrReceiverGroups.Selector = Nothing
        Me.ucrReceiverGroups.Size = New System.Drawing.Size(121, 20)
        Me.ucrReceiverGroups.TabIndex = 9
        Me.ucrReceiverGroups.ucrSelector = Nothing
        '
        'ucrPnlFreqType
        '
        Me.ucrPnlFreqType.Location = New System.Drawing.Point(6, 19)
        Me.ucrPnlFreqType.Name = "ucrPnlFreqType"
        Me.ucrPnlFreqType.Size = New System.Drawing.Size(103, 89)
        Me.ucrPnlFreqType.TabIndex = 0
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
        'grpFreqType
        '
        Me.grpFreqType.Controls.Add(Me.rdoCount)
        Me.grpFreqType.Controls.Add(Me.rdoCell)
        Me.grpFreqType.Controls.Add(Me.rdoRow)
        Me.grpFreqType.Controls.Add(Me.rdoColumn)
        Me.grpFreqType.Controls.Add(Me.ucrPnlFreqType)
        Me.grpFreqType.Controls.Add(Me.ucrChkRow)
        Me.grpFreqType.Controls.Add(Me.ucrChkCount)
        Me.grpFreqType.Controls.Add(Me.ucrChkColumn)
        Me.grpFreqType.Controls.Add(Me.ucrChkCell)
        Me.grpFreqType.Location = New System.Drawing.Point(260, 221)
        Me.grpFreqType.Name = "grpFreqType"
        Me.grpFreqType.Size = New System.Drawing.Size(121, 111)
        Me.grpFreqType.TabIndex = 14
        Me.grpFreqType.TabStop = False
        Me.grpFreqType.Text = "Frequencies"
        '
        'ucrChkRow
        '
        Me.ucrChkRow.Checked = False
        Me.ucrChkRow.Location = New System.Drawing.Point(10, 42)
        Me.ucrChkRow.Name = "ucrChkRow"
        Me.ucrChkRow.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkRow.TabIndex = 6
        '
        'ucrChkCount
        '
        Me.ucrChkCount.Checked = False
        Me.ucrChkCount.Location = New System.Drawing.Point(10, 19)
        Me.ucrChkCount.Name = "ucrChkCount"
        Me.ucrChkCount.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkCount.TabIndex = 5
        '
        'ucrChkColumn
        '
        Me.ucrChkColumn.Checked = False
        Me.ucrChkColumn.Location = New System.Drawing.Point(10, 65)
        Me.ucrChkColumn.Name = "ucrChkColumn"
        Me.ucrChkColumn.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkColumn.TabIndex = 7
        '
        'ucrChkCell
        '
        Me.ucrChkCell.Checked = False
        Me.ucrChkCell.Location = New System.Drawing.Point(10, 88)
        Me.ucrChkCell.Name = "ucrChkCell"
        Me.ucrChkCell.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkCell.TabIndex = 8
        '
        'dlgThreeVariableFrequencies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 395)
        Me.Controls.Add(Me.grpFreqType)
        Me.Controls.Add(Me.ucrReceiverGroups)
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
    Friend WithEvents lblGroupby As Label
    Friend WithEvents lblColumnfactor As Label
    Friend WithEvents lblRowfactor As Label
    Friend WithEvents ucrReceiverColumnFactor As ucrReceiverSingle
    Friend WithEvents ucrReceiverRowFactor As ucrReceiverSingle
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrChkWeights As ucrCheck
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents ucrChkFlip As ucrCheck
    Friend WithEvents ucrReceiverGroups As ucrReceiverSingle
    Friend WithEvents grpFreqType As GroupBox
    Friend WithEvents rdoCount As RadioButton
    Friend WithEvents rdoCell As RadioButton
    Friend WithEvents rdoRow As RadioButton
    Friend WithEvents rdoColumn As RadioButton
    Friend WithEvents ucrPnlFreqType As UcrPanel
    Friend WithEvents ucrChkRow As ucrCheck
    Friend WithEvents ucrChkCount As ucrCheck
    Friend WithEvents ucrChkColumn As ucrCheck
    Friend WithEvents ucrChkCell As ucrCheck
End Class
