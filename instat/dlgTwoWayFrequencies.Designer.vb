<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTwoWayFrequencies
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorTwoWayFrequencies = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverRowFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverColumnFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrChkFlip = New instat.ucrCheck()
        Me.ucrChkGraph = New instat.ucrCheck()
        Me.ucrChkTable = New instat.ucrCheck()
        Me.ucrChkWeights = New instat.ucrCheck()
        Me.grpFrequenciesBoxes = New System.Windows.Forms.GroupBox()
        Me.lblRowFactor = New System.Windows.Forms.Label()
        Me.lblColumnFactor = New System.Windows.Forms.Label()
        Me.UcrCheck7 = New instat.ucrCheck()
        Me.UcrCheck6 = New instat.ucrCheck()
        Me.UcrCheck5 = New instat.ucrCheck()
        Me.UcrCheck1 = New instat.ucrCheck()
        Me.grpFrequencies = New System.Windows.Forms.GroupBox()
        Me.ucrPnlFrequencies = New instat.UcrPanel()
        Me.rdoRow = New System.Windows.Forms.RadioButton()
        Me.rdoCell = New System.Windows.Forms.RadioButton()
        Me.rdoColumn = New System.Windows.Forms.RadioButton()
        Me.rdoCount = New System.Windows.Forms.RadioButton()
        Me.grpFrequenciesBoxes.SuspendLayout()
        Me.grpFrequencies.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(0, 314)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorTwoWayFrequencies
        '
        Me.ucrSelectorTwoWayFrequencies.bShowHiddenColumns = False
        Me.ucrSelectorTwoWayFrequencies.bUseCurrentFilter = True
        Me.ucrSelectorTwoWayFrequencies.Location = New System.Drawing.Point(12, 9)
        Me.ucrSelectorTwoWayFrequencies.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTwoWayFrequencies.Name = "ucrSelectorTwoWayFrequencies"
        Me.ucrSelectorTwoWayFrequencies.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorTwoWayFrequencies.TabIndex = 1
        '
        'ucrReceiverRowFactor
        '
        Me.ucrReceiverRowFactor.frmParent = Me
        Me.ucrReceiverRowFactor.Location = New System.Drawing.Point(257, 34)
        Me.ucrReceiverRowFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRowFactor.Name = "ucrReceiverRowFactor"
        Me.ucrReceiverRowFactor.Selector = Nothing
        Me.ucrReceiverRowFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRowFactor.TabIndex = 2
        '
        'ucrReceiverColumnFactor
        '
        Me.ucrReceiverColumnFactor.frmParent = Me
        Me.ucrReceiverColumnFactor.Location = New System.Drawing.Point(257, 93)
        Me.ucrReceiverColumnFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnFactor.Name = "ucrReceiverColumnFactor"
        Me.ucrReceiverColumnFactor.Selector = Nothing
        Me.ucrReceiverColumnFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverColumnFactor.TabIndex = 3
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.frmParent = Me
        Me.ucrReceiverWeights.Location = New System.Drawing.Point(125, 203)
        Me.ucrReceiverWeights.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWeights.TabIndex = 4
        '
        'ucrChkFlip
        '
        Me.ucrChkFlip.Checked = False
        Me.ucrChkFlip.Location = New System.Drawing.Point(12, 229)
        Me.ucrChkFlip.Name = "ucrChkFlip"
        Me.ucrChkFlip.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkFlip.TabIndex = 5
        '
        'ucrChkGraph
        '
        Me.ucrChkGraph.Checked = False
        Me.ucrChkGraph.Location = New System.Drawing.Point(12, 281)
        Me.ucrChkGraph.Name = "ucrChkGraph"
        Me.ucrChkGraph.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkGraph.TabIndex = 6
        '
        'ucrChkTable
        '
        Me.ucrChkTable.Checked = False
        Me.ucrChkTable.Location = New System.Drawing.Point(12, 255)
        Me.ucrChkTable.Name = "ucrChkTable"
        Me.ucrChkTable.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkTable.TabIndex = 7
        '
        'ucrChkWeights
        '
        Me.ucrChkWeights.Checked = False
        Me.ucrChkWeights.Location = New System.Drawing.Point(12, 203)
        Me.ucrChkWeights.Name = "ucrChkWeights"
        Me.ucrChkWeights.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkWeights.TabIndex = 8
        '
        'grpFrequenciesBoxes
        '
        Me.grpFrequenciesBoxes.Controls.Add(Me.grpFrequencies)
        Me.grpFrequenciesBoxes.Controls.Add(Me.UcrCheck1)
        Me.grpFrequenciesBoxes.Controls.Add(Me.UcrCheck7)
        Me.grpFrequenciesBoxes.Controls.Add(Me.UcrCheck6)
        Me.grpFrequenciesBoxes.Controls.Add(Me.UcrCheck5)
        Me.grpFrequenciesBoxes.Location = New System.Drawing.Point(257, 123)
        Me.grpFrequenciesBoxes.Name = "grpFrequenciesBoxes"
        Me.grpFrequenciesBoxes.Size = New System.Drawing.Size(153, 126)
        Me.grpFrequenciesBoxes.TabIndex = 12
        Me.grpFrequenciesBoxes.TabStop = False
        Me.grpFrequenciesBoxes.Text = "Frequencies"
        '
        'lblRowFactor
        '
        Me.lblRowFactor.AutoSize = True
        Me.lblRowFactor.Location = New System.Drawing.Point(254, 19)
        Me.lblRowFactor.Name = "lblRowFactor"
        Me.lblRowFactor.Size = New System.Drawing.Size(65, 13)
        Me.lblRowFactor.TabIndex = 13
        Me.lblRowFactor.Text = "Row Factor:"
        '
        'lblColumnFactor
        '
        Me.lblColumnFactor.AutoSize = True
        Me.lblColumnFactor.Location = New System.Drawing.Point(254, 80)
        Me.lblColumnFactor.Name = "lblColumnFactor"
        Me.lblColumnFactor.Size = New System.Drawing.Size(78, 13)
        Me.lblColumnFactor.TabIndex = 14
        Me.lblColumnFactor.Text = "Column Factor:"
        '
        'UcrCheck7
        '
        Me.UcrCheck7.Checked = False
        Me.UcrCheck7.Location = New System.Drawing.Point(7, 22)
        Me.UcrCheck7.Name = "UcrCheck7"
        Me.UcrCheck7.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck7.TabIndex = 14
        '
        'UcrCheck6
        '
        Me.UcrCheck6.Checked = False
        Me.UcrCheck6.Location = New System.Drawing.Point(7, 74)
        Me.UcrCheck6.Name = "UcrCheck6"
        Me.UcrCheck6.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck6.TabIndex = 13
        '
        'UcrCheck5
        '
        Me.UcrCheck5.Checked = False
        Me.UcrCheck5.Location = New System.Drawing.Point(7, 48)
        Me.UcrCheck5.Name = "UcrCheck5"
        Me.UcrCheck5.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck5.TabIndex = 12
        '
        'UcrCheck1
        '
        Me.UcrCheck1.Checked = False
        Me.UcrCheck1.Location = New System.Drawing.Point(6, 100)
        Me.UcrCheck1.Name = "UcrCheck1"
        Me.UcrCheck1.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck1.TabIndex = 15
        '
        'grpFrequencies
        '
        Me.grpFrequencies.Controls.Add(Me.rdoCell)
        Me.grpFrequencies.Controls.Add(Me.rdoRow)
        Me.grpFrequencies.Controls.Add(Me.rdoColumn)
        Me.grpFrequencies.Controls.Add(Me.rdoCount)
        Me.grpFrequencies.Controls.Add(Me.ucrPnlFrequencies)
        Me.grpFrequencies.Location = New System.Drawing.Point(1, 2)
        Me.grpFrequencies.Name = "grpFrequencies"
        Me.grpFrequencies.Size = New System.Drawing.Size(152, 126)
        Me.grpFrequencies.TabIndex = 16
        Me.grpFrequencies.TabStop = False
        Me.grpFrequencies.Text = "Frequencies"
        '
        'ucrPnlFrequencies
        '
        Me.ucrPnlFrequencies.Location = New System.Drawing.Point(5, 17)
        Me.ucrPnlFrequencies.Name = "ucrPnlFrequencies"
        Me.ucrPnlFrequencies.Size = New System.Drawing.Size(141, 96)
        Me.ucrPnlFrequencies.TabIndex = 15
        '
        'rdoRow
        '
        Me.rdoRow.AutoSize = True
        Me.rdoRow.Location = New System.Drawing.Point(11, 43)
        Me.rdoRow.Name = "rdoRow"
        Me.rdoRow.Size = New System.Drawing.Size(55, 17)
        Me.rdoRow.TabIndex = 23
        Me.rdoRow.TabStop = True
        Me.rdoRow.Text = "Row%"
        Me.rdoRow.UseVisualStyleBackColor = True
        '
        'rdoCell
        '
        Me.rdoCell.AutoSize = True
        Me.rdoCell.Location = New System.Drawing.Point(11, 89)
        Me.rdoCell.Name = "rdoCell"
        Me.rdoCell.Size = New System.Drawing.Size(50, 17)
        Me.rdoCell.TabIndex = 22
        Me.rdoCell.TabStop = True
        Me.rdoCell.Text = "Cell%"
        Me.rdoCell.UseVisualStyleBackColor = True
        '
        'rdoColumn
        '
        Me.rdoColumn.AutoSize = True
        Me.rdoColumn.Location = New System.Drawing.Point(11, 66)
        Me.rdoColumn.Name = "rdoColumn"
        Me.rdoColumn.Size = New System.Drawing.Size(68, 17)
        Me.rdoColumn.TabIndex = 21
        Me.rdoColumn.TabStop = True
        Me.rdoColumn.Text = "Column%"
        Me.rdoColumn.UseVisualStyleBackColor = True
        '
        'rdoCount
        '
        Me.rdoCount.AutoSize = True
        Me.rdoCount.Location = New System.Drawing.Point(11, 20)
        Me.rdoCount.Name = "rdoCount"
        Me.rdoCount.Size = New System.Drawing.Size(53, 17)
        Me.rdoCount.TabIndex = 24
        Me.rdoCount.TabStop = True
        Me.rdoCount.Text = "Count"
        Me.rdoCount.UseVisualStyleBackColor = True
        '
        'dlgTwoWayFrequencies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 379)
        Me.Controls.Add(Me.lblColumnFactor)
        Me.Controls.Add(Me.lblRowFactor)
        Me.Controls.Add(Me.grpFrequenciesBoxes)
        Me.Controls.Add(Me.ucrChkWeights)
        Me.Controls.Add(Me.ucrChkTable)
        Me.Controls.Add(Me.ucrChkGraph)
        Me.Controls.Add(Me.ucrChkFlip)
        Me.Controls.Add(Me.ucrReceiverWeights)
        Me.Controls.Add(Me.ucrReceiverColumnFactor)
        Me.Controls.Add(Me.ucrReceiverRowFactor)
        Me.Controls.Add(Me.ucrSelectorTwoWayFrequencies)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTwoWayFrequencies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dlgTwoWayFrequencies"
        Me.grpFrequenciesBoxes.ResumeLayout(False)
        Me.grpFrequencies.ResumeLayout(False)
        Me.grpFrequencies.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorTwoWayFrequencies As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverRowFactor As ucrReceiverSingle
    Friend WithEvents lblColumnFactor As Label
    Friend WithEvents lblRowFactor As Label
    Friend WithEvents grpFrequenciesBoxes As GroupBox
    Friend WithEvents ucrChkWeights As ucrCheck
    Friend WithEvents ucrChkTable As ucrCheck
    Friend WithEvents ucrChkGraph As ucrCheck
    Friend WithEvents ucrChkFlip As ucrCheck
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents ucrReceiverColumnFactor As ucrReceiverSingle
    Friend WithEvents UcrCheck1 As ucrCheck
    Friend WithEvents UcrCheck7 As ucrCheck
    Friend WithEvents UcrCheck6 As ucrCheck
    Friend WithEvents UcrCheck5 As ucrCheck
    Friend WithEvents grpFrequencies As GroupBox
    Friend WithEvents rdoCell As RadioButton
    Friend WithEvents rdoRow As RadioButton
    Friend WithEvents rdoColumn As RadioButton
    Friend WithEvents rdoCount As RadioButton
    Friend WithEvents ucrPnlFrequencies As UcrPanel
End Class
