<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgTwoWayFrequencies
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
        Me.lblRowFactor = New System.Windows.Forms.Label()
        Me.lblColumnFactor = New System.Windows.Forms.Label()
        Me.rdoTable = New System.Windows.Forms.RadioButton()
        Me.rdoGraph = New System.Windows.Forms.RadioButton()
        Me.ucrPnlFreqDisplay = New instat.UcrPanel()
        Me.ucrChkWeights = New instat.ucrCheck()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrReceiverColumnFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverRowFactor = New instat.ucrReceiverSingle()
        Me.ucrSelectorTwoWayFrequencies = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpFrequencies = New System.Windows.Forms.GroupBox()
        Me.rdoCount = New System.Windows.Forms.RadioButton()
        Me.rdoCell = New System.Windows.Forms.RadioButton()
        Me.rdoRow = New System.Windows.Forms.RadioButton()
        Me.rdoColumn = New System.Windows.Forms.RadioButton()
        Me.ucrPnlFrequencies = New instat.UcrPanel()
        Me.UcrCheck4 = New instat.ucrCheck()
        Me.grpMarginType = New System.Windows.Forms.GroupBox()
        Me.ucrChkCount = New instat.ucrCheck()
        Me.ucrChkCell = New instat.ucrCheck()
        Me.ucrChkRow = New instat.ucrCheck()
        Me.ucrChkColumn = New instat.ucrCheck()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrChkFlip = New instat.ucrCheck()
        Me.grpFrequencies.SuspendLayout()
        Me.grpMarginType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRowFactor
        '
        Me.lblRowFactor.AutoSize = True
        Me.lblRowFactor.Location = New System.Drawing.Point(254, 45)
        Me.lblRowFactor.Name = "lblRowFactor"
        Me.lblRowFactor.Size = New System.Drawing.Size(65, 13)
        Me.lblRowFactor.TabIndex = 1
        Me.lblRowFactor.Text = "Row Factor:"
        '
        'lblColumnFactor
        '
        Me.lblColumnFactor.AutoSize = True
        Me.lblColumnFactor.Location = New System.Drawing.Point(254, 90)
        Me.lblColumnFactor.Name = "lblColumnFactor"
        Me.lblColumnFactor.Size = New System.Drawing.Size(78, 13)
        Me.lblColumnFactor.TabIndex = 3
        Me.lblColumnFactor.Text = "Column Factor:"
        '
        'rdoTable
        '
        Me.rdoTable.AutoSize = True
        Me.rdoTable.Location = New System.Drawing.Point(12, 227)
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.Size = New System.Drawing.Size(95, 17)
        Me.rdoTable.TabIndex = 16
        Me.rdoTable.TabStop = True
        Me.rdoTable.Text = "Display (Table)"
        Me.rdoTable.UseVisualStyleBackColor = True
        '
        'rdoGraph
        '
        Me.rdoGraph.AutoSize = True
        Me.rdoGraph.Location = New System.Drawing.Point(12, 251)
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.Size = New System.Drawing.Size(97, 17)
        Me.rdoGraph.TabIndex = 17
        Me.rdoGraph.TabStop = True
        Me.rdoGraph.Text = "Display (Graph)"
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'ucrPnlFreqDisplay
        '
        Me.ucrPnlFreqDisplay.Location = New System.Drawing.Point(12, 232)
        Me.ucrPnlFreqDisplay.Name = "ucrPnlFreqDisplay"
        Me.ucrPnlFreqDisplay.Size = New System.Drawing.Size(102, 46)
        Me.ucrPnlFreqDisplay.TabIndex = 19
        '
        'ucrChkWeights
        '
        Me.ucrChkWeights.Checked = False
        Me.ucrChkWeights.Location = New System.Drawing.Point(12, 204)
        Me.ucrChkWeights.Name = "ucrChkWeights"
        Me.ucrChkWeights.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkWeights.TabIndex = 7
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.frmParent = Me
        Me.ucrReceiverWeights.Location = New System.Drawing.Point(114, 203)
        Me.ucrReceiverWeights.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWeights.TabIndex = 8
        '
        'ucrReceiverColumnFactor
        '
        Me.ucrReceiverColumnFactor.frmParent = Me
        Me.ucrReceiverColumnFactor.Location = New System.Drawing.Point(257, 105)
        Me.ucrReceiverColumnFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnFactor.Name = "ucrReceiverColumnFactor"
        Me.ucrReceiverColumnFactor.Selector = Nothing
        Me.ucrReceiverColumnFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverColumnFactor.TabIndex = 4
        '
        'ucrReceiverRowFactor
        '
        Me.ucrReceiverRowFactor.frmParent = Me
        Me.ucrReceiverRowFactor.Location = New System.Drawing.Point(257, 60)
        Me.ucrReceiverRowFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRowFactor.Name = "ucrReceiverRowFactor"
        Me.ucrReceiverRowFactor.Selector = Nothing
        Me.ucrReceiverRowFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRowFactor.TabIndex = 2
        '
        'ucrSelectorTwoWayFrequencies
        '
        Me.ucrSelectorTwoWayFrequencies.bShowHiddenColumns = False
        Me.ucrSelectorTwoWayFrequencies.bUseCurrentFilter = True
        Me.ucrSelectorTwoWayFrequencies.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorTwoWayFrequencies.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTwoWayFrequencies.Name = "ucrSelectorTwoWayFrequencies"
        Me.ucrSelectorTwoWayFrequencies.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorTwoWayFrequencies.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 308)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 12
        '
        'grpFrequencies
        '
        Me.grpFrequencies.Controls.Add(Me.rdoCount)
        Me.grpFrequencies.Controls.Add(Me.rdoCell)
        Me.grpFrequencies.Controls.Add(Me.rdoRow)
        Me.grpFrequencies.Controls.Add(Me.rdoColumn)
        Me.grpFrequencies.Controls.Add(Me.ucrPnlFrequencies)
        Me.grpFrequencies.Controls.Add(Me.UcrCheck4)
        Me.grpFrequencies.Location = New System.Drawing.Point(0, 0)
        Me.grpFrequencies.Name = "grpFrequencies"
        Me.grpFrequencies.Size = New System.Drawing.Size(120, 125)
        Me.grpFrequencies.TabIndex = 32
        Me.grpFrequencies.TabStop = False
        Me.grpFrequencies.Text = "Frequencies"
        '
        'rdoCount
        '
        Me.rdoCount.AutoSize = True
        Me.rdoCount.Location = New System.Drawing.Point(18, 22)
        Me.rdoCount.Name = "rdoCount"
        Me.rdoCount.Size = New System.Drawing.Size(53, 17)
        Me.rdoCount.TabIndex = 16
        Me.rdoCount.TabStop = True
        Me.rdoCount.Text = "Count"
        Me.rdoCount.UseVisualStyleBackColor = True
        '
        'rdoCell
        '
        Me.rdoCell.AutoSize = True
        Me.rdoCell.Location = New System.Drawing.Point(18, 97)
        Me.rdoCell.Name = "rdoCell"
        Me.rdoCell.Size = New System.Drawing.Size(59, 17)
        Me.rdoCell.TabIndex = 2
        Me.rdoCell.TabStop = True
        Me.rdoCell.Text = "Cell (%)"
        Me.rdoCell.UseVisualStyleBackColor = True
        '
        'rdoRow
        '
        Me.rdoRow.AutoSize = True
        Me.rdoRow.Location = New System.Drawing.Point(18, 45)
        Me.rdoRow.Name = "rdoRow"
        Me.rdoRow.Size = New System.Drawing.Size(64, 17)
        Me.rdoRow.TabIndex = 0
        Me.rdoRow.TabStop = True
        Me.rdoRow.Text = "Row (%)"
        Me.rdoRow.UseVisualStyleBackColor = True
        '
        'rdoColumn
        '
        Me.rdoColumn.AutoSize = True
        Me.rdoColumn.Location = New System.Drawing.Point(18, 72)
        Me.rdoColumn.Name = "rdoColumn"
        Me.rdoColumn.Size = New System.Drawing.Size(77, 17)
        Me.rdoColumn.TabIndex = 1
        Me.rdoColumn.TabStop = True
        Me.rdoColumn.Text = "Column (%)"
        Me.rdoColumn.UseVisualStyleBackColor = True
        '
        'ucrPnlFrequencies
        '
        Me.ucrPnlFrequencies.Location = New System.Drawing.Point(5, 17)
        Me.ucrPnlFrequencies.Name = "ucrPnlFrequencies"
        Me.ucrPnlFrequencies.Size = New System.Drawing.Size(109, 102)
        Me.ucrPnlFrequencies.TabIndex = 15
        '
        'UcrCheck4
        '
        Me.UcrCheck4.Checked = False
        Me.UcrCheck4.Location = New System.Drawing.Point(14, 43)
        Me.UcrCheck4.Name = "UcrCheck4"
        Me.UcrCheck4.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck4.TabIndex = 24
        '
        'grpMarginType
        '
        Me.grpMarginType.Controls.Add(Me.grpFrequencies)
        Me.grpMarginType.Controls.Add(Me.ucrChkCount)
        Me.grpMarginType.Controls.Add(Me.ucrChkCell)
        Me.grpMarginType.Controls.Add(Me.ucrChkRow)
        Me.grpMarginType.Controls.Add(Me.ucrChkColumn)
        Me.grpMarginType.Location = New System.Drawing.Point(257, 147)
        Me.grpMarginType.Name = "grpMarginType"
        Me.grpMarginType.Size = New System.Drawing.Size(120, 125)
        Me.grpMarginType.TabIndex = 31
        Me.grpMarginType.TabStop = False
        Me.grpMarginType.Text = "Margin Type"
        '
        'ucrChkCount
        '
        Me.ucrChkCount.Checked = False
        Me.ucrChkCount.Location = New System.Drawing.Point(14, 19)
        Me.ucrChkCount.Name = "ucrChkCount"
        Me.ucrChkCount.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkCount.TabIndex = 27
        '
        'ucrChkCell
        '
        Me.ucrChkCell.Checked = False
        Me.ucrChkCell.Location = New System.Drawing.Point(14, 95)
        Me.ucrChkCell.Name = "ucrChkCell"
        Me.ucrChkCell.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkCell.TabIndex = 26
        '
        'ucrChkRow
        '
        Me.ucrChkRow.Checked = False
        Me.ucrChkRow.Location = New System.Drawing.Point(14, 43)
        Me.ucrChkRow.Name = "ucrChkRow"
        Me.ucrChkRow.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkRow.TabIndex = 24
        '
        'ucrChkColumn
        '
        Me.ucrChkColumn.Checked = False
        Me.ucrChkColumn.Location = New System.Drawing.Point(14, 69)
        Me.ucrChkColumn.Name = "ucrChkColumn"
        Me.ucrChkColumn.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkColumn.TabIndex = 25
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(308, 277)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(69, 23)
        Me.cmdOptions.TabIndex = 32
        Me.cmdOptions.Text = " Options..."
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrChkFlip
        '
        Me.ucrChkFlip.Checked = False
        Me.ucrChkFlip.Location = New System.Drawing.Point(12, 275)
        Me.ucrChkFlip.Name = "ucrChkFlip"
        Me.ucrChkFlip.Size = New System.Drawing.Size(183, 20)
        Me.ucrChkFlip.TabIndex = 33
        '
        'dlgTwoWayFrequencies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 366)
        Me.Controls.Add(Me.ucrChkFlip)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.grpMarginType)
        Me.Controls.Add(Me.rdoTable)
        Me.Controls.Add(Me.rdoGraph)
        Me.Controls.Add(Me.lblColumnFactor)
        Me.Controls.Add(Me.ucrPnlFreqDisplay)
        Me.Controls.Add(Me.lblRowFactor)
        Me.Controls.Add(Me.ucrChkWeights)
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
        Me.Text = "Two Way Frequencies"
        Me.grpFrequencies.ResumeLayout(False)
        Me.grpFrequencies.PerformLayout()
        Me.grpMarginType.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorTwoWayFrequencies As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverRowFactor As ucrReceiverSingle
    Friend WithEvents lblColumnFactor As Label
    Friend WithEvents lblRowFactor As Label
    Friend WithEvents ucrChkWeights As ucrCheck
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents ucrReceiverColumnFactor As ucrReceiverSingle
    Friend WithEvents rdoTable As RadioButton
    Friend WithEvents rdoGraph As RadioButton
    Friend WithEvents ucrPnlFreqDisplay As UcrPanel
    Friend WithEvents grpFrequencies As GroupBox
    Friend WithEvents rdoCount As RadioButton
    Friend WithEvents rdoCell As RadioButton
    Friend WithEvents rdoRow As RadioButton
    Friend WithEvents rdoColumn As RadioButton
    Friend WithEvents ucrPnlFrequencies As UcrPanel
    Friend WithEvents UcrCheck4 As ucrCheck
    Friend WithEvents grpMarginType As GroupBox
    Friend WithEvents ucrChkCount As ucrCheck
    Friend WithEvents ucrChkCell As ucrCheck
    Friend WithEvents ucrChkRow As ucrCheck
    Friend WithEvents ucrChkColumn As ucrCheck
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrChkFlip As ucrCheck
End Class
