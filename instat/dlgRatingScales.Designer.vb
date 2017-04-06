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
        Me.rdoHighAscending = New System.Windows.Forms.RadioButton()
        Me.rdoHighDescending = New System.Windows.Forms.RadioButton()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.rdoHighDescendingLikert = New System.Windows.Forms.RadioButton()
        Me.rdoHighAscendingLikert = New System.Windows.Forms.RadioButton()
        Me.rdoLowDescending = New System.Windows.Forms.RadioButton()
        Me.rdoLowAscending = New System.Windows.Forms.RadioButton()
        Me.rdoLowDescendingLikert = New System.Windows.Forms.RadioButton()
        Me.rdoNoneLikert = New System.Windows.Forms.RadioButton()
        Me.rdoLowAscendingLikert = New System.Windows.Forms.RadioButton()
        Me.grpGraphType = New System.Windows.Forms.GroupBox()
        Me.lblNeutralLevel = New System.Windows.Forms.Label()
        Me.rdoStacked = New System.Windows.Forms.RadioButton()
        Me.rdoLikert = New System.Windows.Forms.RadioButton()
        Me.ucrNudNeutralLevel = New instat.ucrNud()
        Me.ucrPnlGraphType = New instat.UcrPanel()
        Me.ucrChkFlip = New instat.ucrCheck()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrChkWeights = New instat.ucrCheck()
        Me.ucrChkFrequencyTable = New instat.ucrCheck()
        Me.ucrChkGraph = New instat.ucrCheck()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrReceiverOrderedFactors = New instat.ucrReceiverMultiple()
        Me.ucrPnlSjtStackFrq = New instat.UcrPanel()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorRatingScale = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlSjpLikert = New instat.UcrPanel()
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
        Me.lblOrderedFactor.TabIndex = 14
        Me.lblOrderedFactor.Text = "Ordered Factor:"
        '
        'grpSort
        '
        Me.grpSort.Controls.Add(Me.rdoHighAscending)
        Me.grpSort.Controls.Add(Me.rdoLowAscending)
        Me.grpSort.Controls.Add(Me.rdoHighDescending)
        Me.grpSort.Controls.Add(Me.rdoLowDescending)
        Me.grpSort.Controls.Add(Me.rdoNone)
        Me.grpSort.Controls.Add(Me.ucrPnlSjtStackFrq)
        Me.grpSort.Location = New System.Drawing.Point(295, 166)
        Me.grpSort.Name = "grpSort"
        Me.grpSort.Size = New System.Drawing.Size(161, 149)
        Me.grpSort.TabIndex = 22
        Me.grpSort.TabStop = False
        Me.grpSort.Text = "Sort"
        '
        'rdoHighAscending
        '
        Me.rdoHighAscending.AutoSize = True
        Me.rdoHighAscending.Location = New System.Drawing.Point(13, 89)
        Me.rdoHighAscending.Name = "rdoHighAscending"
        Me.rdoHighAscending.Size = New System.Drawing.Size(100, 17)
        Me.rdoHighAscending.TabIndex = 29
        Me.rdoHighAscending.TabStop = True
        Me.rdoHighAscending.Text = "High Ascending"
        Me.rdoHighAscending.UseVisualStyleBackColor = True
        '
        'rdoHighDescending
        '
        Me.rdoHighDescending.AutoSize = True
        Me.rdoHighDescending.Location = New System.Drawing.Point(13, 113)
        Me.rdoHighDescending.Name = "rdoHighDescending"
        Me.rdoHighDescending.Size = New System.Drawing.Size(107, 17)
        Me.rdoHighDescending.TabIndex = 30
        Me.rdoHighDescending.TabStop = True
        Me.rdoHighDescending.Text = "High Descending"
        Me.rdoHighDescending.UseVisualStyleBackColor = True
        '
        'rdoNone
        '
        Me.rdoNone.AutoSize = True
        Me.rdoNone.Location = New System.Drawing.Point(13, 17)
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.Size = New System.Drawing.Size(51, 17)
        Me.rdoNone.TabIndex = 44
        Me.rdoNone.TabStop = True
        Me.rdoNone.Text = "None"
        Me.rdoNone.UseVisualStyleBackColor = True
        '
        'rdoHighDescendingLikert
        '
        Me.rdoHighDescendingLikert.AutoSize = True
        Me.rdoHighDescendingLikert.Location = New System.Drawing.Point(562, 274)
        Me.rdoHighDescendingLikert.Name = "rdoHighDescendingLikert"
        Me.rdoHighDescendingLikert.Size = New System.Drawing.Size(107, 17)
        Me.rdoHighDescendingLikert.TabIndex = 36
        Me.rdoHighDescendingLikert.TabStop = True
        Me.rdoHighDescendingLikert.Text = "High Descending"
        Me.rdoHighDescendingLikert.UseVisualStyleBackColor = True
        '
        'rdoHighAscendingLikert
        '
        Me.rdoHighAscendingLikert.AutoSize = True
        Me.rdoHighAscendingLikert.Location = New System.Drawing.Point(562, 250)
        Me.rdoHighAscendingLikert.Name = "rdoHighAscendingLikert"
        Me.rdoHighAscendingLikert.Size = New System.Drawing.Size(100, 17)
        Me.rdoHighAscendingLikert.TabIndex = 41
        Me.rdoHighAscendingLikert.TabStop = True
        Me.rdoHighAscendingLikert.Text = "High Ascending"
        Me.rdoHighAscendingLikert.UseVisualStyleBackColor = True
        '
        'rdoLowDescending
        '
        Me.rdoLowDescending.AutoSize = True
        Me.rdoLowDescending.Location = New System.Drawing.Point(13, 65)
        Me.rdoLowDescending.Name = "rdoLowDescending"
        Me.rdoLowDescending.Size = New System.Drawing.Size(102, 17)
        Me.rdoLowDescending.TabIndex = 28
        Me.rdoLowDescending.TabStop = True
        Me.rdoLowDescending.Text = "LowDescending"
        Me.rdoLowDescending.UseVisualStyleBackColor = True
        '
        'rdoLowAscending
        '
        Me.rdoLowAscending.AutoSize = True
        Me.rdoLowAscending.Location = New System.Drawing.Point(13, 41)
        Me.rdoLowAscending.Name = "rdoLowAscending"
        Me.rdoLowAscending.Size = New System.Drawing.Size(95, 17)
        Me.rdoLowAscending.TabIndex = 27
        Me.rdoLowAscending.TabStop = True
        Me.rdoLowAscending.Text = "LowAscending"
        Me.rdoLowAscending.UseVisualStyleBackColor = True
        '
        'rdoLowDescendingLikert
        '
        Me.rdoLowDescendingLikert.AutoSize = True
        Me.rdoLowDescendingLikert.Location = New System.Drawing.Point(562, 226)
        Me.rdoLowDescendingLikert.Name = "rdoLowDescendingLikert"
        Me.rdoLowDescendingLikert.Size = New System.Drawing.Size(102, 17)
        Me.rdoLowDescendingLikert.TabIndex = 40
        Me.rdoLowDescendingLikert.TabStop = True
        Me.rdoLowDescendingLikert.Text = "LowDescending"
        Me.rdoLowDescendingLikert.UseVisualStyleBackColor = True
        '
        'rdoNoneLikert
        '
        Me.rdoNoneLikert.AutoSize = True
        Me.rdoNoneLikert.Location = New System.Drawing.Point(562, 178)
        Me.rdoNoneLikert.Name = "rdoNoneLikert"
        Me.rdoNoneLikert.Size = New System.Drawing.Size(51, 17)
        Me.rdoNoneLikert.TabIndex = 32
        Me.rdoNoneLikert.TabStop = True
        Me.rdoNoneLikert.Text = "None"
        Me.rdoNoneLikert.UseVisualStyleBackColor = True
        '
        'rdoLowAscendingLikert
        '
        Me.rdoLowAscendingLikert.AutoSize = True
        Me.rdoLowAscendingLikert.Location = New System.Drawing.Point(562, 202)
        Me.rdoLowAscendingLikert.Name = "rdoLowAscendingLikert"
        Me.rdoLowAscendingLikert.Size = New System.Drawing.Size(95, 17)
        Me.rdoLowAscendingLikert.TabIndex = 39
        Me.rdoLowAscendingLikert.TabStop = True
        Me.rdoLowAscendingLikert.Text = "LowAscending"
        Me.rdoLowAscendingLikert.UseVisualStyleBackColor = True
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
        Me.grpGraphType.TabIndex = 24
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
        Me.lblNeutralLevel.TabIndex = 7
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
        Me.rdoStacked.TabIndex = 1
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
        Me.rdoLikert.TabIndex = 0
        Me.rdoLikert.Tag = ""
        Me.rdoLikert.Text = "Likert"
        Me.rdoLikert.UseVisualStyleBackColor = True
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
        Me.ucrNudNeutralLevel.TabIndex = 8
        Me.ucrNudNeutralLevel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlGraphType
        '
        Me.ucrPnlGraphType.Location = New System.Drawing.Point(4, 15)
        Me.ucrPnlGraphType.Name = "ucrPnlGraphType"
        Me.ucrPnlGraphType.Size = New System.Drawing.Size(165, 31)
        Me.ucrPnlGraphType.TabIndex = 2
        '
        'ucrChkFlip
        '
        Me.ucrChkFlip.Checked = False
        Me.ucrChkFlip.Location = New System.Drawing.Point(10, 230)
        Me.ucrChkFlip.Name = "ucrChkFlip"
        Me.ucrChkFlip.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkFlip.TabIndex = 23
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.frmParent = Me
        Me.ucrReceiverWeights.Location = New System.Drawing.Point(114, 204)
        Me.ucrReceiverWeights.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWeights.TabIndex = 21
        '
        'ucrChkWeights
        '
        Me.ucrChkWeights.Checked = False
        Me.ucrChkWeights.Location = New System.Drawing.Point(10, 204)
        Me.ucrChkWeights.Name = "ucrChkWeights"
        Me.ucrChkWeights.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkWeights.TabIndex = 20
        '
        'ucrChkFrequencyTable
        '
        Me.ucrChkFrequencyTable.Checked = False
        Me.ucrChkFrequencyTable.Location = New System.Drawing.Point(10, 282)
        Me.ucrChkFrequencyTable.Name = "ucrChkFrequencyTable"
        Me.ucrChkFrequencyTable.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkFrequencyTable.TabIndex = 19
        '
        'ucrChkGraph
        '
        Me.ucrChkGraph.Checked = False
        Me.ucrChkGraph.Location = New System.Drawing.Point(10, 256)
        Me.ucrChkGraph.Name = "ucrChkGraph"
        Me.ucrChkGraph.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkGraph.TabIndex = 18
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 323)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(258, 24)
        Me.ucrSaveGraph.TabIndex = 15
        '
        'ucrReceiverOrderedFactors
        '
        Me.ucrReceiverOrderedFactors.frmParent = Me
        Me.ucrReceiverOrderedFactors.Location = New System.Drawing.Point(287, 60)
        Me.ucrReceiverOrderedFactors.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverOrderedFactors.Name = "ucrReceiverOrderedFactors"
        Me.ucrReceiverOrderedFactors.Selector = Nothing
        Me.ucrReceiverOrderedFactors.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverOrderedFactors.TabIndex = 13
        '
        'ucrPnlSjtStackFrq
        '
        Me.ucrPnlSjtStackFrq.Location = New System.Drawing.Point(6, 12)
        Me.ucrPnlSjtStackFrq.Name = "ucrPnlSjtStackFrq"
        Me.ucrPnlSjtStackFrq.Size = New System.Drawing.Size(126, 127)
        Me.ucrPnlSjtStackFrq.TabIndex = 44
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
        Me.ucrSelectorRatingScale.TabIndex = 1
        '
        'ucrPnlSjpLikert
        '
        Me.ucrPnlSjpLikert.Location = New System.Drawing.Point(548, 171)
        Me.ucrPnlSjpLikert.Name = "ucrPnlSjpLikert"
        Me.ucrPnlSjpLikert.Size = New System.Drawing.Size(126, 127)
        Me.ucrPnlSjpLikert.TabIndex = 45
        '
        'dlgRatingScales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 410)
        Me.Controls.Add(Me.rdoHighDescendingLikert)
        Me.Controls.Add(Me.rdoLowDescendingLikert)
        Me.Controls.Add(Me.rdoLowAscendingLikert)
        Me.Controls.Add(Me.rdoNoneLikert)
        Me.Controls.Add(Me.grpGraphType)
        Me.Controls.Add(Me.ucrChkFlip)
        Me.Controls.Add(Me.grpSort)
        Me.Controls.Add(Me.ucrReceiverWeights)
        Me.Controls.Add(Me.ucrChkWeights)
        Me.Controls.Add(Me.rdoHighAscendingLikert)
        Me.Controls.Add(Me.ucrChkFrequencyTable)
        Me.Controls.Add(Me.ucrChkGraph)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.lblOrderedFactor)
        Me.Controls.Add(Me.ucrReceiverOrderedFactors)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorRatingScale)
        Me.Controls.Add(Me.ucrPnlSjpLikert)
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
    Friend WithEvents ucrChkFrequencyTable As ucrCheck
    Friend WithEvents ucrChkGraph As ucrCheck
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
    Friend WithEvents rdoHighDescending As RadioButton
    Friend WithEvents rdoHighAscending As RadioButton
    Friend WithEvents rdoLowDescending As RadioButton
    Friend WithEvents rdoLowAscending As RadioButton
    Friend WithEvents rdoHighAscendingLikert As RadioButton
    Friend WithEvents rdoLowDescendingLikert As RadioButton
    Friend WithEvents rdoLowAscendingLikert As RadioButton
    Friend WithEvents rdoNone As RadioButton
    Friend WithEvents ucrPnlSjtStackFrq As UcrPanel
    Friend WithEvents ucrPnlSjpLikert As UcrPanel
End Class
