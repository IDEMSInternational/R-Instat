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
        Me.ucrSelectorRatingScale = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverOrderedFactors = New instat.ucrReceiverMultiple()
        Me.lblOrderedFactor = New System.Windows.Forms.Label()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrChkGraph = New instat.ucrCheck()
        Me.ucrChkFrequencyTable = New instat.ucrCheck()
        Me.ucrChkWeights = New instat.ucrCheck()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.grpSort = New System.Windows.Forms.GroupBox()
        Me.ucrChkFlip = New instat.ucrCheck()
        Me.grpGraphType = New System.Windows.Forms.GroupBox()
        Me.ucrNudNeutralLevel = New instat.ucrNud()
        Me.lblNeutralLevel = New System.Windows.Forms.Label()
        Me.rdoStacked = New System.Windows.Forms.RadioButton()
        Me.rdoLikert = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGraphType = New instat.UcrPanel()
        Me.ucrPnlSjtStackFrq = New instat.UcrPanel()
        Me.rdoHighDescending = New System.Windows.Forms.RadioButton()
        Me.rdoHighAscending = New System.Windows.Forms.RadioButton()
        Me.rdoLowDescending = New System.Windows.Forms.RadioButton()
        Me.rdoLowAscending = New System.Windows.Forms.RadioButton()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.ucrPnlSjpStackFrq = New instat.UcrPanel()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.ucrPnlSjpLikert = New instat.UcrPanel()
        Me.grpSort.SuspendLayout()
        Me.grpGraphType.SuspendLayout()
        Me.SuspendLayout()
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
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 355)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 12
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
        'lblOrderedFactor
        '
        Me.lblOrderedFactor.AutoSize = True
        Me.lblOrderedFactor.Location = New System.Drawing.Point(284, 45)
        Me.lblOrderedFactor.Name = "lblOrderedFactor"
        Me.lblOrderedFactor.Size = New System.Drawing.Size(81, 13)
        Me.lblOrderedFactor.TabIndex = 14
        Me.lblOrderedFactor.Text = "Ordered Factor:"
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 323)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(258, 24)
        Me.ucrSaveGraph.TabIndex = 15
        '
        'ucrChkGraph
        '
        Me.ucrChkGraph.Checked = False
        Me.ucrChkGraph.Location = New System.Drawing.Point(10, 256)
        Me.ucrChkGraph.Name = "ucrChkGraph"
        Me.ucrChkGraph.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkGraph.TabIndex = 18
        '
        'ucrChkFrequencyTable
        '
        Me.ucrChkFrequencyTable.Checked = False
        Me.ucrChkFrequencyTable.Location = New System.Drawing.Point(10, 282)
        Me.ucrChkFrequencyTable.Name = "ucrChkFrequencyTable"
        Me.ucrChkFrequencyTable.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkFrequencyTable.TabIndex = 19
        '
        'ucrChkWeights
        '
        Me.ucrChkWeights.Checked = False
        Me.ucrChkWeights.Location = New System.Drawing.Point(10, 204)
        Me.ucrChkWeights.Name = "ucrChkWeights"
        Me.ucrChkWeights.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkWeights.TabIndex = 20
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
        'grpSort
        '
        Me.grpSort.Controls.Add(Me.rdoHighDescending)
        Me.grpSort.Controls.Add(Me.RadioButton1)
        Me.grpSort.Controls.Add(Me.rdoHighAscending)
        Me.grpSort.Controls.Add(Me.RadioButton6)
        Me.grpSort.Controls.Add(Me.rdoLowDescending)
        Me.grpSort.Controls.Add(Me.RadioButton7)
        Me.grpSort.Controls.Add(Me.rdoLowAscending)
        Me.grpSort.Controls.Add(Me.RadioButton8)
        Me.grpSort.Controls.Add(Me.rdoNone)
        Me.grpSort.Controls.Add(Me.RadioButton2)
        Me.grpSort.Controls.Add(Me.ucrPnlSjtStackFrq)
        Me.grpSort.Controls.Add(Me.RadioButton5)
        Me.grpSort.Controls.Add(Me.RadioButton9)
        Me.grpSort.Controls.Add(Me.ucrPnlSjpLikert)
        Me.grpSort.Controls.Add(Me.RadioButton3)
        Me.grpSort.Controls.Add(Me.ucrPnlSjpStackFrq)
        Me.grpSort.Controls.Add(Me.RadioButton4)
        Me.grpSort.Controls.Add(Me.RadioButton10)
        Me.grpSort.Location = New System.Drawing.Point(281, 173)
        Me.grpSort.Name = "grpSort"
        Me.grpSort.Size = New System.Drawing.Size(126, 133)
        Me.grpSort.TabIndex = 22
        Me.grpSort.TabStop = False
        Me.grpSort.Text = "Sort"
        '
        'ucrChkFlip
        '
        Me.ucrChkFlip.Checked = False
        Me.ucrChkFlip.Location = New System.Drawing.Point(10, 230)
        Me.ucrChkFlip.Name = "ucrChkFlip"
        Me.ucrChkFlip.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkFlip.TabIndex = 23
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
        Me.grpGraphType.Location = New System.Drawing.Point(114, 242)
        Me.grpGraphType.Name = "grpGraphType"
        Me.grpGraphType.Size = New System.Drawing.Size(161, 74)
        Me.grpGraphType.TabIndex = 24
        Me.grpGraphType.TabStop = False
        Me.grpGraphType.Tag = "Graph_type"
        Me.grpGraphType.Text = "Graph Type"
        '
        'ucrNudNeutralLevel
        '
        Me.ucrNudNeutralLevel.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNeutralLevel.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNeutralLevel.Location = New System.Drawing.Point(78, 44)
        Me.ucrNudNeutralLevel.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNeutralLevel.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNeutralLevel.Name = "ucrNudNeutralLevel"
        Me.ucrNudNeutralLevel.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNeutralLevel.TabIndex = 8
        Me.ucrNudNeutralLevel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNeutralLevel
        '
        Me.lblNeutralLevel.AutoSize = True
        Me.lblNeutralLevel.Location = New System.Drawing.Point(3, 48)
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
        Me.rdoStacked.Location = New System.Drawing.Point(69, 19)
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
        Me.rdoLikert.Location = New System.Drawing.Point(8, 19)
        Me.rdoLikert.Name = "rdoLikert"
        Me.rdoLikert.Size = New System.Drawing.Size(57, 18)
        Me.rdoLikert.TabIndex = 0
        Me.rdoLikert.Tag = ""
        Me.rdoLikert.Text = "Likert"
        Me.rdoLikert.UseVisualStyleBackColor = True
        '
        'ucrPnlGraphType
        '
        Me.ucrPnlGraphType.Location = New System.Drawing.Point(7, 15)
        Me.ucrPnlGraphType.Name = "ucrPnlGraphType"
        Me.ucrPnlGraphType.Size = New System.Drawing.Size(133, 22)
        Me.ucrPnlGraphType.TabIndex = 2
        '
        'ucrPnlSjtStackFrq
        '
        Me.ucrPnlSjtStackFrq.Location = New System.Drawing.Point(6, 16)
        Me.ucrPnlSjtStackFrq.Name = "ucrPnlSjtStackFrq"
        Me.ucrPnlSjtStackFrq.Size = New System.Drawing.Size(114, 111)
        Me.ucrPnlSjtStackFrq.TabIndex = 25
        '
        'rdoHighDescending
        '
        Me.rdoHighDescending.AutoSize = True
        Me.rdoHighDescending.Location = New System.Drawing.Point(8, 107)
        Me.rdoHighDescending.Name = "rdoHighDescending"
        Me.rdoHighDescending.Size = New System.Drawing.Size(107, 17)
        Me.rdoHighDescending.TabIndex = 30
        Me.rdoHighDescending.TabStop = True
        Me.rdoHighDescending.Text = "High Descending"
        Me.rdoHighDescending.UseVisualStyleBackColor = True
        '
        'rdoHighAscending
        '
        Me.rdoHighAscending.AutoSize = True
        Me.rdoHighAscending.Location = New System.Drawing.Point(8, 85)
        Me.rdoHighAscending.Name = "rdoHighAscending"
        Me.rdoHighAscending.Size = New System.Drawing.Size(100, 17)
        Me.rdoHighAscending.TabIndex = 29
        Me.rdoHighAscending.TabStop = True
        Me.rdoHighAscending.Text = "High Ascending"
        Me.rdoHighAscending.UseVisualStyleBackColor = True
        '
        'rdoLowDescending
        '
        Me.rdoLowDescending.AutoSize = True
        Me.rdoLowDescending.Location = New System.Drawing.Point(8, 63)
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
        Me.rdoLowAscending.Location = New System.Drawing.Point(8, 41)
        Me.rdoLowAscending.Name = "rdoLowAscending"
        Me.rdoLowAscending.Size = New System.Drawing.Size(95, 17)
        Me.rdoLowAscending.TabIndex = 27
        Me.rdoLowAscending.TabStop = True
        Me.rdoLowAscending.Text = "LowAscending"
        Me.rdoLowAscending.UseVisualStyleBackColor = True
        '
        'rdoNone
        '
        Me.rdoNone.AutoSize = True
        Me.rdoNone.Location = New System.Drawing.Point(8, 19)
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.Size = New System.Drawing.Size(51, 17)
        Me.rdoNone.TabIndex = 26
        Me.rdoNone.TabStop = True
        Me.rdoNone.Text = "None"
        Me.rdoNone.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(8, 107)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(107, 17)
        Me.RadioButton1.TabIndex = 36
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "High Descending"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(8, 85)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(100, 17)
        Me.RadioButton2.TabIndex = 35
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "High Ascending"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(8, 63)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(102, 17)
        Me.RadioButton3.TabIndex = 34
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "LowDescending"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(8, 41)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(95, 17)
        Me.RadioButton4.TabIndex = 33
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "LowAscending"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(8, 19)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(51, 17)
        Me.RadioButton5.TabIndex = 32
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "None"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'ucrPnlSjpStackFrq
        '
        Me.ucrPnlSjpStackFrq.Location = New System.Drawing.Point(6, 16)
        Me.ucrPnlSjpStackFrq.Name = "ucrPnlSjpStackFrq"
        Me.ucrPnlSjpStackFrq.Size = New System.Drawing.Size(114, 111)
        Me.ucrPnlSjpStackFrq.TabIndex = 31
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(8, 107)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(107, 17)
        Me.RadioButton6.TabIndex = 42
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "High Descending"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(8, 85)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(100, 17)
        Me.RadioButton7.TabIndex = 41
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "High Ascending"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(8, 63)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(102, 17)
        Me.RadioButton8.TabIndex = 40
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "LowDescending"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(8, 41)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(95, 17)
        Me.RadioButton9.TabIndex = 39
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "LowAscending"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(8, 19)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(51, 17)
        Me.RadioButton10.TabIndex = 38
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "None"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'ucrPnlSjpLikert
        '
        Me.ucrPnlSjpLikert.Location = New System.Drawing.Point(6, 16)
        Me.ucrPnlSjpLikert.Name = "ucrPnlSjpLikert"
        Me.ucrPnlSjpLikert.Size = New System.Drawing.Size(114, 111)
        Me.ucrPnlSjpLikert.TabIndex = 37
        '
        'dlgRatingScales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 410)
        Me.Controls.Add(Me.grpGraphType)
        Me.Controls.Add(Me.ucrChkFlip)
        Me.Controls.Add(Me.grpSort)
        Me.Controls.Add(Me.ucrReceiverWeights)
        Me.Controls.Add(Me.ucrChkWeights)
        Me.Controls.Add(Me.ucrChkFrequencyTable)
        Me.Controls.Add(Me.ucrChkGraph)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.lblOrderedFactor)
        Me.Controls.Add(Me.ucrReceiverOrderedFactors)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorRatingScale)
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
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents ucrPnlSjpStackFrq As UcrPanel
    Friend WithEvents rdoHighDescending As RadioButton
    Friend WithEvents rdoHighAscending As RadioButton
    Friend WithEvents rdoLowDescending As RadioButton
    Friend WithEvents rdoLowAscending As RadioButton
    Friend WithEvents rdoNone As RadioButton
    Friend WithEvents ucrPnlSjtStackFrq As UcrPanel
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents ucrPnlSjpLikert As UcrPanel
    Friend WithEvents RadioButton10 As RadioButton
End Class
