<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRatingScales
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
        Me.lblOrderedFactor = New System.Windows.Forms.Label()
        Me.grpSort = New System.Windows.Forms.GroupBox()
        Me.rdoHighDescendingLikert = New System.Windows.Forms.RadioButton()
        Me.rdoLowDescendingLikert = New System.Windows.Forms.RadioButton()
        Me.rdoLowAscendingLikert = New System.Windows.Forms.RadioButton()
        Me.rdoNoneLikert = New System.Windows.Forms.RadioButton()
        Me.rdoHighAscendingLikert = New System.Windows.Forms.RadioButton()
        Me.grpGraphType = New System.Windows.Forms.GroupBox()
        Me.lblNeutralLevel = New System.Windows.Forms.Label()
        Me.rdoStacked = New System.Windows.Forms.RadioButton()
        Me.rdoLikert = New System.Windows.Forms.RadioButton()
        Me.rdoGraph = New System.Windows.Forms.RadioButton()
        Me.rdoTable = New System.Windows.Forms.RadioButton()
        Me.ucrNudNeutralLevel = New instat.ucrNud()
        Me.ucrPnlGraphType = New instat.UcrPanel()
        Me.ucrChkFlip = New instat.ucrCheck()
        Me.ucrPnlSjpLikert = New instat.UcrPanel()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrChkWeights = New instat.ucrCheck()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrReceiverOrderedFactors = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorRatingScale = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlType = New instat.UcrPanel()
        Me.grpSort.SuspendLayout()
        Me.grpGraphType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblOrderedFactor
        '
        Me.lblOrderedFactor.AutoSize = True
        Me.lblOrderedFactor.Location = New System.Drawing.Point(284, 45)
        Me.lblOrderedFactor.Name = "lblOrderedFactor"
        Me.lblOrderedFactor.Size = New System.Drawing.Size(81, 13)
        Me.lblOrderedFactor.TabIndex = 1
        Me.lblOrderedFactor.Text = "Ordered Factor:"
        '
        'grpSort
        '
        Me.grpSort.Controls.Add(Me.rdoHighDescendingLikert)
        Me.grpSort.Controls.Add(Me.rdoLowDescendingLikert)
        Me.grpSort.Controls.Add(Me.rdoLowAscendingLikert)
        Me.grpSort.Controls.Add(Me.rdoNoneLikert)
        Me.grpSort.Controls.Add(Me.rdoHighAscendingLikert)
        Me.grpSort.Controls.Add(Me.ucrPnlSjpLikert)
        Me.grpSort.Location = New System.Drawing.Point(295, 166)
        Me.grpSort.Name = "grpSort"
        Me.grpSort.Size = New System.Drawing.Size(161, 149)
        Me.grpSort.TabIndex = 10
        Me.grpSort.TabStop = False
        Me.grpSort.Text = "Sort"
        '
        'rdoHighDescendingLikert
        '
        Me.rdoHighDescendingLikert.AutoSize = True
        Me.rdoHighDescendingLikert.Location = New System.Drawing.Point(13, 115)
        Me.rdoHighDescendingLikert.Name = "rdoHighDescendingLikert"
        Me.rdoHighDescendingLikert.Size = New System.Drawing.Size(107, 17)
        Me.rdoHighDescendingLikert.TabIndex = 11
        Me.rdoHighDescendingLikert.TabStop = True
        Me.rdoHighDescendingLikert.Text = "High Descending"
        Me.rdoHighDescendingLikert.UseVisualStyleBackColor = True
        '
        'rdoLowDescendingLikert
        '
        Me.rdoLowDescendingLikert.AutoSize = True
        Me.rdoLowDescendingLikert.Location = New System.Drawing.Point(13, 67)
        Me.rdoLowDescendingLikert.Name = "rdoLowDescendingLikert"
        Me.rdoLowDescendingLikert.Size = New System.Drawing.Size(102, 17)
        Me.rdoLowDescendingLikert.TabIndex = 6
        Me.rdoLowDescendingLikert.TabStop = True
        Me.rdoLowDescendingLikert.Text = "LowDescending"
        Me.rdoLowDescendingLikert.UseVisualStyleBackColor = True
        '
        'rdoLowAscendingLikert
        '
        Me.rdoLowAscendingLikert.AutoSize = True
        Me.rdoLowAscendingLikert.Location = New System.Drawing.Point(13, 43)
        Me.rdoLowAscendingLikert.Name = "rdoLowAscendingLikert"
        Me.rdoLowAscendingLikert.Size = New System.Drawing.Size(95, 17)
        Me.rdoLowAscendingLikert.TabIndex = 4
        Me.rdoLowAscendingLikert.TabStop = True
        Me.rdoLowAscendingLikert.Text = "LowAscending"
        Me.rdoLowAscendingLikert.UseVisualStyleBackColor = True
        '
        'rdoNoneLikert
        '
        Me.rdoNoneLikert.AutoSize = True
        Me.rdoNoneLikert.Location = New System.Drawing.Point(13, 19)
        Me.rdoNoneLikert.Name = "rdoNoneLikert"
        Me.rdoNoneLikert.Size = New System.Drawing.Size(51, 17)
        Me.rdoNoneLikert.TabIndex = 1
        Me.rdoNoneLikert.TabStop = True
        Me.rdoNoneLikert.Text = "None"
        Me.rdoNoneLikert.UseVisualStyleBackColor = True
        '
        'rdoHighAscendingLikert
        '
        Me.rdoHighAscendingLikert.AutoSize = True
        Me.rdoHighAscendingLikert.Location = New System.Drawing.Point(13, 91)
        Me.rdoHighAscendingLikert.Name = "rdoHighAscendingLikert"
        Me.rdoHighAscendingLikert.Size = New System.Drawing.Size(100, 17)
        Me.rdoHighAscendingLikert.TabIndex = 8
        Me.rdoHighAscendingLikert.TabStop = True
        Me.rdoHighAscendingLikert.Text = "High Ascending"
        Me.rdoHighAscendingLikert.UseVisualStyleBackColor = True
        '
        'grpGraphType
        '
        Me.grpGraphType.Controls.Add(Me.ucrNudNeutralLevel)
        Me.grpGraphType.Controls.Add(Me.lblNeutralLevel)
        Me.grpGraphType.Controls.Add(Me.rdoStacked)
        Me.grpGraphType.Controls.Add(Me.rdoLikert)
        Me.grpGraphType.Controls.Add(Me.ucrPnlGraphType)
        Me.grpGraphType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpGraphType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGraphType.Location = New System.Drawing.Point(114, 236)
        Me.grpGraphType.Name = "grpGraphType"
        Me.grpGraphType.Size = New System.Drawing.Size(175, 80)
        Me.grpGraphType.TabIndex = 6
        Me.grpGraphType.TabStop = False
        Me.grpGraphType.Tag = "Graph_type"
        Me.grpGraphType.Text = "Graph Type"
        '
        'lblNeutralLevel
        '
        Me.lblNeutralLevel.AutoSize = True
        Me.lblNeutralLevel.Location = New System.Drawing.Point(3, 56)
        Me.lblNeutralLevel.Name = "lblNeutralLevel"
        Me.lblNeutralLevel.Size = New System.Drawing.Size(73, 13)
        Me.lblNeutralLevel.TabIndex = 3
        Me.lblNeutralLevel.Tag = "Neutral_Level"
        Me.lblNeutralLevel.Text = "Neutral Level:"
        '
        'rdoStacked
        '
        Me.rdoStacked.AutoSize = True
        Me.rdoStacked.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rdoStacked.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoStacked.Location = New System.Drawing.Point(78, 21)
        Me.rdoStacked.Name = "rdoStacked"
        Me.rdoStacked.Size = New System.Drawing.Size(71, 18)
        Me.rdoStacked.TabIndex = 2
        Me.rdoStacked.Tag = ""
        Me.rdoStacked.Text = "Stacked"
        Me.rdoStacked.UseVisualStyleBackColor = True
        '
        'rdoLikert
        '
        Me.rdoLikert.AutoSize = True
        Me.rdoLikert.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rdoLikert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLikert.Location = New System.Drawing.Point(12, 20)
        Me.rdoLikert.Name = "rdoLikert"
        Me.rdoLikert.Size = New System.Drawing.Size(57, 18)
        Me.rdoLikert.TabIndex = 1
        Me.rdoLikert.Tag = ""
        Me.rdoLikert.Text = "Likert"
        Me.rdoLikert.UseVisualStyleBackColor = True
        '
        'rdoGraph
        '
        Me.rdoGraph.AutoSize = True
        Me.rdoGraph.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rdoGraph.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoGraph.Location = New System.Drawing.Point(20, 262)
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.Size = New System.Drawing.Size(60, 18)
        Me.rdoGraph.TabIndex = 8
        Me.rdoGraph.Tag = ""
        Me.rdoGraph.Text = "Graph"
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'rdoTable
        '
        Me.rdoTable.AutoSize = True
        Me.rdoTable.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rdoTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoTable.Location = New System.Drawing.Point(20, 283)
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.Size = New System.Drawing.Size(58, 18)
        Me.rdoTable.TabIndex = 9
        Me.rdoTable.Tag = ""
        Me.rdoTable.Text = "Table"
        Me.rdoTable.UseVisualStyleBackColor = True
        '
        'ucrNudNeutralLevel
        '
        Me.ucrNudNeutralLevel.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNeutralLevel.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNeutralLevel.Location = New System.Drawing.Point(78, 52)
        Me.ucrNudNeutralLevel.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNeutralLevel.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNeutralLevel.Name = "ucrNudNeutralLevel"
        Me.ucrNudNeutralLevel.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNeutralLevel.TabIndex = 4
        Me.ucrNudNeutralLevel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlGraphType
        '
        Me.ucrPnlGraphType.Location = New System.Drawing.Point(4, 15)
        Me.ucrPnlGraphType.Name = "ucrPnlGraphType"
        Me.ucrPnlGraphType.Size = New System.Drawing.Size(165, 31)
        Me.ucrPnlGraphType.TabIndex = 0
        '
        'ucrChkFlip
        '
        Me.ucrChkFlip.Checked = False
        Me.ucrChkFlip.Location = New System.Drawing.Point(10, 230)
        Me.ucrChkFlip.Name = "ucrChkFlip"
        Me.ucrChkFlip.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkFlip.TabIndex = 5
        '
        'ucrPnlSjpLikert
        '
        Me.ucrPnlSjpLikert.Location = New System.Drawing.Point(7, 15)
        Me.ucrPnlSjpLikert.Name = "ucrPnlSjpLikert"
        Me.ucrPnlSjpLikert.Size = New System.Drawing.Size(126, 127)
        Me.ucrPnlSjpLikert.TabIndex = 3
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.frmParent = Me
        Me.ucrReceiverWeights.Location = New System.Drawing.Point(114, 204)
        Me.ucrReceiverWeights.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWeights.TabIndex = 4
        '
        'ucrChkWeights
        '
        Me.ucrChkWeights.Checked = False
        Me.ucrChkWeights.Location = New System.Drawing.Point(10, 204)
        Me.ucrChkWeights.Name = "ucrChkWeights"
        Me.ucrChkWeights.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkWeights.TabIndex = 3
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 323)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(258, 24)
        Me.ucrSaveGraph.TabIndex = 11
        '
        'ucrReceiverOrderedFactors
        '
        Me.ucrReceiverOrderedFactors.frmParent = Me
        Me.ucrReceiverOrderedFactors.Location = New System.Drawing.Point(287, 60)
        Me.ucrReceiverOrderedFactors.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverOrderedFactors.Name = "ucrReceiverOrderedFactors"
        Me.ucrReceiverOrderedFactors.Selector = Nothing
        Me.ucrReceiverOrderedFactors.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverOrderedFactors.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 355)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 12
        '
        'ucrSelectorRatingScale
        '
        Me.ucrSelectorRatingScale.bShowHiddenColumns = False
        Me.ucrSelectorRatingScale.bUseCurrentFilter = True
        Me.ucrSelectorRatingScale.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorRatingScale.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorRatingScale.Name = "ucrSelectorRatingScale"
        Me.ucrSelectorRatingScale.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorRatingScale.TabIndex = 0
        '
        'ucrPnlType
        '
        Me.ucrPnlType.Location = New System.Drawing.Point(10, 258)
        Me.ucrPnlType.Name = "ucrPnlType"
        Me.ucrPnlType.Size = New System.Drawing.Size(82, 55)
        Me.ucrPnlType.TabIndex = 7
        '
        'dlgRatingScales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 410)
        Me.Controls.Add(Me.rdoTable)
        Me.Controls.Add(Me.rdoGraph)
        Me.Controls.Add(Me.grpGraphType)
        Me.Controls.Add(Me.ucrChkFlip)
        Me.Controls.Add(Me.grpSort)
        Me.Controls.Add(Me.ucrReceiverWeights)
        Me.Controls.Add(Me.ucrChkWeights)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.lblOrderedFactor)
        Me.Controls.Add(Me.ucrReceiverOrderedFactors)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorRatingScale)
        Me.Controls.Add(Me.ucrPnlType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRatingScales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rating Scales"
        Me.grpSort.ResumeLayout(False)
        Me.grpSort.PerformLayout()
        Me.grpGraphType.ResumeLayout(False)
        Me.grpGraphType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorRatingScale As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverOrderedFactors As ucrReceiverMultiple
    Friend WithEvents lblOrderedFactor As Label
    Friend WithEvents ucrChkWeights As ucrCheck
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents grpSort As GroupBox
    Friend WithEvents ucrChkFlip As ucrCheck
    Friend WithEvents grpGraphType As GroupBox
    Friend WithEvents rdoStacked As RadioButton
    Friend WithEvents rdoLikert As RadioButton
    Friend WithEvents ucrPnlGraphType As UcrPanel
    Friend WithEvents ucrNudNeutralLevel As ucrNud
    Friend WithEvents lblNeutralLevel As Label
    Friend WithEvents rdoHighDescendingLikert As RadioButton
    Friend WithEvents rdoNoneLikert As RadioButton
    Friend WithEvents rdoHighAscendingLikert As RadioButton
    Friend WithEvents rdoLowDescendingLikert As RadioButton
    Friend WithEvents rdoLowAscendingLikert As RadioButton
    Friend WithEvents ucrPnlSjpLikert As UcrPanel
    Friend WithEvents rdoGraph As RadioButton
    Friend WithEvents rdoTable As RadioButton
    Friend WithEvents ucrPnlType As UcrPanel
End Class
