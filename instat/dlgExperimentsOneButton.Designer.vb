<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgExperimentsOneButton
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.rdoGeneral = New System.Windows.Forms.RadioButton()
        Me.rdoSpecial = New System.Windows.Forms.RadioButton()
        Me.rdoFactorial = New System.Windows.Forms.RadioButton()
        Me.rdorbd = New System.Windows.Forms.RadioButton()
        Me.rdoDiallel = New System.Windows.Forms.RadioButton()
        Me.rdoLxt = New System.Windows.Forms.RadioButton()
        Me.rdoAugmented = New System.Windows.Forms.RadioButton()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.lblRep = New System.Windows.Forms.Label()
        Me.lblFactorA = New System.Windows.Forms.Label()
        Me.lblFactorB = New System.Windows.Forms.Label()
        Me.lblDesign = New System.Windows.Forms.Label()
        Me.lblTreat = New System.Windows.Forms.Label()
        Me.lblBlock = New System.Windows.Forms.Label()
        Me.btnChecks = New System.Windows.Forms.Button()
        Me.ttDesign = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttVariability = New System.Windows.Forms.ToolTip(Me.components)
        Me.rdoPath = New System.Windows.Forms.RadioButton()
        Me.rdoVariability = New System.Windows.Forms.RadioButton()
        Me.rdoDiversity = New System.Windows.Forms.RadioButton()
        Me.rdoStability = New System.Windows.Forms.RadioButton()
        Me.rdoCorrelations = New System.Windows.Forms.RadioButton()
        Me.lblClusters = New System.Windows.Forms.Label()
        Me.lblExplanatory = New System.Windows.Forms.Label()
        Me.lblLocations = New System.Windows.Forms.Label()
        Me.lblSelectionDifferential = New System.Windows.Forms.Label()
        Me.lblMultipleResponses = New System.Windows.Forms.Label()
        Me.rdoGenotypic = New System.Windows.Forms.RadioButton()
        Me.rdoHierarchical = New System.Windows.Forms.RadioButton()
        Me.rdoPhenotypic = New System.Windows.Forms.RadioButton()
        Me.rdoTocher = New System.Windows.Forms.RadioButton()
        Me.grpClusteringMethod = New System.Windows.Forms.GroupBox()
        Me.grpCorrelationType = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverExplanatory = New instat.ucrReceiverMultiple()
        Me.ucrPnlClustering = New instat.UcrPanel()
        Me.ucrNudClusters = New instat.ucrNud()
        Me.ucrReceiverMultipleResponses = New instat.ucrReceiverMultiple()
        Me.ucrPnlCorrelationType = New instat.UcrPanel()
        Me.ucrReceiverLocations = New instat.ucrReceiverSingle()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrBlock = New instat.ucrReceiverSingle()
        Me.UcrBaseExperimentsOneButton = New instat.ucrButtons()
        Me.ucrSave = New instat.ucrSave()
        Me.ucrReceiverResponse = New instat.ucrReceiverSingle()
        Me.ucrRep = New instat.ucrReceiverSingle()
        Me.ucrReceiverFactorA = New instat.ucrReceiverSingle()
        Me.ucrReceiverFactorB = New instat.ucrReceiverSingle()
        Me.ucrChkPlot = New instat.ucrCheck()
        Me.ucrSelectorForRank = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlExperimentsOneButtonOptions = New instat.UcrPanel()
        Me.ucrPnlDesign = New instat.UcrPanel()
        Me.UcrReceiverTreat = New instat.ucrReceiverSingle()
        Me.ucrNudSelectionDifferential = New instat.ucrNud()
        Me.UcrCheckAlphaExperiments = New instat.ucrCheck()
        Me.ucrAlpha = New instat.ucrInputComboBox()
        Me.grpClusteringMethod.SuspendLayout()
        Me.grpCorrelationType.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoGeneral
        '
        Me.rdoGeneral.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGeneral.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGeneral.FlatAppearance.BorderSize = 2
        Me.rdoGeneral.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGeneral.Location = New System.Drawing.Point(84, 15)
        Me.rdoGeneral.Name = "rdoGeneral"
        Me.rdoGeneral.Size = New System.Drawing.Size(161, 34)
        Me.rdoGeneral.TabIndex = 21
        Me.rdoGeneral.TabStop = True
        Me.rdoGeneral.Text = "General"
        Me.rdoGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGeneral.UseVisualStyleBackColor = True
        '
        'rdoSpecial
        '
        Me.rdoSpecial.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSpecial.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSpecial.FlatAppearance.BorderSize = 2
        Me.rdoSpecial.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSpecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSpecial.Location = New System.Drawing.Point(243, 15)
        Me.rdoSpecial.Name = "rdoSpecial"
        Me.rdoSpecial.Size = New System.Drawing.Size(161, 34)
        Me.rdoSpecial.TabIndex = 20
        Me.rdoSpecial.TabStop = True
        Me.rdoSpecial.Text = "Special"
        Me.rdoSpecial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSpecial.UseVisualStyleBackColor = True
        '
        'rdoFactorial
        '
        Me.rdoFactorial.AutoSize = True
        Me.rdoFactorial.Location = New System.Drawing.Point(144, 68)
        Me.rdoFactorial.Name = "rdoFactorial"
        Me.rdoFactorial.Size = New System.Drawing.Size(80, 20)
        Me.rdoFactorial.TabIndex = 70
        Me.rdoFactorial.TabStop = True
        Me.rdoFactorial.Text = "Factorial"
        Me.rdoFactorial.UseVisualStyleBackColor = True
        '
        'rdorbd
        '
        Me.rdorbd.AutoSize = True
        Me.rdorbd.Location = New System.Drawing.Point(84, 68)
        Me.rdorbd.Name = "rdorbd"
        Me.rdorbd.Size = New System.Drawing.Size(48, 20)
        Me.rdorbd.TabIndex = 69
        Me.rdorbd.TabStop = True
        Me.rdorbd.Text = "rbd"
        Me.rdorbd.UseVisualStyleBackColor = True
        '
        'rdoDiallel
        '
        Me.rdoDiallel.AutoSize = True
        Me.rdoDiallel.Location = New System.Drawing.Point(238, 68)
        Me.rdoDiallel.Name = "rdoDiallel"
        Me.rdoDiallel.Size = New System.Drawing.Size(66, 20)
        Me.rdoDiallel.TabIndex = 92
        Me.rdoDiallel.TabStop = True
        Me.rdoDiallel.Text = "Diallel"
        Me.rdoDiallel.UseVisualStyleBackColor = True
        '
        'rdoLxt
        '
        Me.rdoLxt.AutoSize = True
        Me.rdoLxt.Location = New System.Drawing.Point(322, 68)
        Me.rdoLxt.Name = "rdoLxt"
        Me.rdoLxt.Size = New System.Drawing.Size(40, 20)
        Me.rdoLxt.TabIndex = 93
        Me.rdoLxt.TabStop = True
        Me.rdoLxt.Text = "lxt"
        Me.rdoLxt.UseVisualStyleBackColor = True
        '
        'rdoAugmented
        '
        Me.rdoAugmented.AutoSize = True
        Me.rdoAugmented.Location = New System.Drawing.Point(380, 68)
        Me.rdoAugmented.Name = "rdoAugmented"
        Me.rdoAugmented.Size = New System.Drawing.Size(97, 20)
        Me.rdoAugmented.TabIndex = 94
        Me.rdoAugmented.TabStop = True
        Me.rdoAugmented.Text = "Augmented"
        Me.rdoAugmented.UseVisualStyleBackColor = True
        '
        'lblResponse
        '
        Me.lblResponse.Location = New System.Drawing.Point(295, 125)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(100, 20)
        Me.lblResponse.TabIndex = 74
        Me.lblResponse.Text = "Response:"
        Me.lblResponse.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblRep
        '
        Me.lblRep.Location = New System.Drawing.Point(295, 278)
        Me.lblRep.Name = "lblRep"
        Me.lblRep.Size = New System.Drawing.Size(100, 20)
        Me.lblRep.TabIndex = 80
        Me.lblRep.Text = "Rep :"
        Me.lblRep.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblFactorA
        '
        Me.lblFactorA.Location = New System.Drawing.Point(295, 176)
        Me.lblFactorA.Name = "lblFactorA"
        Me.lblFactorA.Size = New System.Drawing.Size(100, 20)
        Me.lblFactorA.TabIndex = 76
        Me.lblFactorA.Text = "Factor A:"
        Me.lblFactorA.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblFactorB
        '
        Me.lblFactorB.Location = New System.Drawing.Point(295, 225)
        Me.lblFactorB.Name = "lblFactorB"
        Me.lblFactorB.Size = New System.Drawing.Size(100, 20)
        Me.lblFactorB.TabIndex = 78
        Me.lblFactorB.Text = "Factor B:"
        Me.lblFactorB.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblDesign
        '
        Me.lblDesign.Location = New System.Drawing.Point(12, 70)
        Me.lblDesign.Name = "lblDesign"
        Me.lblDesign.Size = New System.Drawing.Size(54, 16)
        Me.lblDesign.TabIndex = 84
        Me.lblDesign.Text = "Design:"
        '
        'lblTreat
        '
        Me.lblTreat.Location = New System.Drawing.Point(295, 176)
        Me.lblTreat.Name = "lblTreat"
        Me.lblTreat.Size = New System.Drawing.Size(100, 20)
        Me.lblTreat.TabIndex = 88
        Me.lblTreat.Text = "Treat :"
        Me.lblTreat.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblBlock
        '
        Me.lblBlock.Location = New System.Drawing.Point(295, 227)
        Me.lblBlock.Name = "lblBlock"
        Me.lblBlock.Size = New System.Drawing.Size(100, 20)
        Me.lblBlock.TabIndex = 95
        Me.lblBlock.Text = "Block:"
        Me.lblBlock.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btnChecks
        '
        Me.btnChecks.Location = New System.Drawing.Point(295, 352)
        Me.btnChecks.Name = "btnChecks"
        Me.btnChecks.Size = New System.Drawing.Size(175, 32)
        Me.btnChecks.TabIndex = 84
        Me.btnChecks.Text = "Checks"
        Me.btnChecks.UseVisualStyleBackColor = True
        '
        'rdoPath
        '
        Me.rdoPath.AutoSize = True
        Me.rdoPath.Location = New System.Drawing.Point(160, 68)
        Me.rdoPath.Name = "rdoPath"
        Me.rdoPath.Size = New System.Drawing.Size(55, 20)
        Me.rdoPath.TabIndex = 122
        Me.rdoPath.TabStop = True
        Me.rdoPath.Text = "Path"
        Me.rdoPath.UseVisualStyleBackColor = True
        '
        'rdoVariability
        '
        Me.rdoVariability.AutoSize = True
        Me.rdoVariability.Location = New System.Drawing.Point(310, 68)
        Me.rdoVariability.Name = "rdoVariability"
        Me.rdoVariability.Size = New System.Drawing.Size(87, 20)
        Me.rdoVariability.TabIndex = 123
        Me.rdoVariability.TabStop = True
        Me.rdoVariability.Text = "Variability"
        Me.rdoVariability.UseVisualStyleBackColor = True
        '
        'rdoDiversity
        '
        Me.rdoDiversity.AutoSize = True
        Me.rdoDiversity.Location = New System.Drawing.Point(70, 68)
        Me.rdoDiversity.Name = "rdoDiversity"
        Me.rdoDiversity.Size = New System.Drawing.Size(80, 20)
        Me.rdoDiversity.TabIndex = 124
        Me.rdoDiversity.TabStop = True
        Me.rdoDiversity.Text = "Diversity"
        Me.rdoDiversity.UseVisualStyleBackColor = True
        '
        'rdoStability
        '
        Me.rdoStability.AutoSize = True
        Me.rdoStability.Location = New System.Drawing.Point(225, 68)
        Me.rdoStability.Name = "rdoStability"
        Me.rdoStability.Size = New System.Drawing.Size(75, 20)
        Me.rdoStability.TabIndex = 125
        Me.rdoStability.TabStop = True
        Me.rdoStability.Text = "Stability"
        Me.rdoStability.UseVisualStyleBackColor = True
        '
        'rdoCorrelations
        '
        Me.rdoCorrelations.AutoSize = True
        Me.rdoCorrelations.Location = New System.Drawing.Point(405, 68)
        Me.rdoCorrelations.Name = "rdoCorrelations"
        Me.rdoCorrelations.Size = New System.Drawing.Size(100, 20)
        Me.rdoCorrelations.TabIndex = 126
        Me.rdoCorrelations.TabStop = True
        Me.rdoCorrelations.Text = "Correlations"
        Me.rdoCorrelations.UseVisualStyleBackColor = True
        '
        'lblClusters
        '
        Me.lblClusters.Location = New System.Drawing.Point(53, 90)
        Me.lblClusters.Name = "lblClusters"
        Me.lblClusters.Size = New System.Drawing.Size(60, 20)
        Me.lblClusters.TabIndex = 129
        Me.lblClusters.Text = "Number:"
        '
        'lblExplanatory
        '
        Me.lblExplanatory.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblExplanatory.Location = New System.Drawing.Point(295, 329)
        Me.lblExplanatory.Name = "lblExplanatory"
        Me.lblExplanatory.Size = New System.Drawing.Size(150, 20)
        Me.lblExplanatory.TabIndex = 132
        Me.lblExplanatory.Text = "Explanatory Variables:"
        Me.lblExplanatory.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblLocations
        '
        Me.lblLocations.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblLocations.Location = New System.Drawing.Point(294, 329)
        Me.lblLocations.Name = "lblLocations"
        Me.lblLocations.Size = New System.Drawing.Size(100, 20)
        Me.lblLocations.TabIndex = 133
        Me.lblLocations.Text = "Locations:"
        Me.lblLocations.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblSelectionDifferential
        '
        Me.lblSelectionDifferential.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblSelectionDifferential.Location = New System.Drawing.Point(9, 341)
        Me.lblSelectionDifferential.Name = "lblSelectionDifferential"
        Me.lblSelectionDifferential.Size = New System.Drawing.Size(152, 25)
        Me.lblSelectionDifferential.TabIndex = 135
        Me.lblSelectionDifferential.Text = "Selection Differential:"
        Me.lblSelectionDifferential.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMultipleResponses
        '
        Me.lblMultipleResponses.Location = New System.Drawing.Point(295, 105)
        Me.lblMultipleResponses.Name = "lblMultipleResponses"
        Me.lblMultipleResponses.Size = New System.Drawing.Size(125, 20)
        Me.lblMultipleResponses.TabIndex = 136
        Me.lblMultipleResponses.Text = "Response Variables:"
        '
        'rdoGenotypic
        '
        Me.rdoGenotypic.AutoSize = True
        Me.rdoGenotypic.Checked = True
        Me.rdoGenotypic.Location = New System.Drawing.Point(15, 30)
        Me.rdoGenotypic.Name = "rdoGenotypic"
        Me.rdoGenotypic.Size = New System.Drawing.Size(89, 20)
        Me.rdoGenotypic.TabIndex = 141
        Me.rdoGenotypic.TabStop = True
        Me.rdoGenotypic.Text = "Genotypic"
        Me.rdoGenotypic.UseVisualStyleBackColor = True
        '
        'rdoHierarchical
        '
        Me.rdoHierarchical.AutoSize = True
        Me.rdoHierarchical.Location = New System.Drawing.Point(15, 60)
        Me.rdoHierarchical.Name = "rdoHierarchical"
        Me.rdoHierarchical.Size = New System.Drawing.Size(100, 20)
        Me.rdoHierarchical.TabIndex = 142
        Me.rdoHierarchical.TabStop = True
        Me.rdoHierarchical.Text = "Hierarchical"
        Me.rdoHierarchical.UseVisualStyleBackColor = True
        '
        'rdoPhenotypic
        '
        Me.rdoPhenotypic.AutoSize = True
        Me.rdoPhenotypic.Location = New System.Drawing.Point(15, 60)
        Me.rdoPhenotypic.Name = "rdoPhenotypic"
        Me.rdoPhenotypic.Size = New System.Drawing.Size(95, 20)
        Me.rdoPhenotypic.TabIndex = 143
        Me.rdoPhenotypic.TabStop = True
        Me.rdoPhenotypic.Text = "Phenotypic"
        Me.rdoPhenotypic.UseVisualStyleBackColor = True
        '
        'rdoTocher
        '
        Me.rdoTocher.AutoSize = True
        Me.rdoTocher.Checked = True
        Me.rdoTocher.Location = New System.Drawing.Point(15, 31)
        Me.rdoTocher.Name = "rdoTocher"
        Me.rdoTocher.Size = New System.Drawing.Size(71, 20)
        Me.rdoTocher.TabIndex = 145
        Me.rdoTocher.TabStop = True
        Me.rdoTocher.Text = "Tocher"
        Me.rdoTocher.UseVisualStyleBackColor = True
        '
        'grpClusteringMethod
        '
        Me.grpClusteringMethod.Controls.Add(Me.lblClusters)
        Me.grpClusteringMethod.Controls.Add(Me.rdoTocher)
        Me.grpClusteringMethod.Controls.Add(Me.rdoHierarchical)
        Me.grpClusteringMethod.Controls.Add(Me.ucrPnlClustering)
        Me.grpClusteringMethod.Controls.Add(Me.ucrNudClusters)
        Me.grpClusteringMethod.Location = New System.Drawing.Point(12, 419)
        Me.grpClusteringMethod.Name = "grpClusteringMethod"
        Me.grpClusteringMethod.Size = New System.Drawing.Size(213, 114)
        Me.grpClusteringMethod.TabIndex = 147
        Me.grpClusteringMethod.TabStop = False
        Me.grpClusteringMethod.Text = "Clustering Method"
        '
        'grpCorrelationType
        '
        Me.grpCorrelationType.Controls.Add(Me.rdoGenotypic)
        Me.grpCorrelationType.Controls.Add(Me.rdoPhenotypic)
        Me.grpCorrelationType.Controls.Add(Me.ucrPnlCorrelationType)
        Me.grpCorrelationType.Location = New System.Drawing.Point(11, 419)
        Me.grpCorrelationType.Name = "grpCorrelationType"
        Me.grpCorrelationType.Size = New System.Drawing.Size(213, 114)
        Me.grpCorrelationType.TabIndex = 148
        Me.grpCorrelationType.TabStop = False
        Me.grpCorrelationType.Text = "Correlation Type"
        '
        'ucrReceiverExplanatory
        '
        Me.ucrReceiverExplanatory.AutoSize = True
        Me.ucrReceiverExplanatory.frmParent = Me
        Me.ucrReceiverExplanatory.Location = New System.Drawing.Point(295, 351)
        Me.ucrReceiverExplanatory.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverExplanatory.Name = "ucrReceiverExplanatory"
        Me.ucrReceiverExplanatory.Selector = Nothing
        Me.ucrReceiverExplanatory.Size = New System.Drawing.Size(175, 50)
        Me.ucrReceiverExplanatory.strNcFilePath = ""
        Me.ucrReceiverExplanatory.TabIndex = 138
        Me.ucrReceiverExplanatory.ucrSelector = Nothing
        '
        'ucrPnlClustering
        '
        Me.ucrPnlClustering.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlClustering.Location = New System.Drawing.Point(8, 23)
        Me.ucrPnlClustering.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrPnlClustering.Name = "ucrPnlClustering"
        Me.ucrPnlClustering.Size = New System.Drawing.Size(155, 62)
        Me.ucrPnlClustering.TabIndex = 149
        '
        'ucrNudClusters
        '
        Me.ucrNudClusters.AutoSize = True
        Me.ucrNudClusters.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudClusters.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudClusters.Location = New System.Drawing.Point(123, 86)
        Me.ucrNudClusters.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrNudClusters.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.ucrNudClusters.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudClusters.Name = "ucrNudClusters"
        Me.ucrNudClusters.Size = New System.Drawing.Size(60, 25)
        Me.ucrNudClusters.TabIndex = 128
        Me.ucrNudClusters.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'ucrReceiverMultipleResponses
        '
        Me.ucrReceiverMultipleResponses.AutoSize = True
        Me.ucrReceiverMultipleResponses.frmParent = Me
        Me.ucrReceiverMultipleResponses.Location = New System.Drawing.Point(295, 125)
        Me.ucrReceiverMultipleResponses.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleResponses.Name = "ucrReceiverMultipleResponses"
        Me.ucrReceiverMultipleResponses.Selector = Nothing
        Me.ucrReceiverMultipleResponses.Size = New System.Drawing.Size(175, 50)
        Me.ucrReceiverMultipleResponses.strNcFilePath = ""
        Me.ucrReceiverMultipleResponses.TabIndex = 137
        Me.ucrReceiverMultipleResponses.ucrSelector = Nothing
        '
        'ucrPnlCorrelationType
        '
        Me.ucrPnlCorrelationType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlCorrelationType.Location = New System.Drawing.Point(8, 20)
        Me.ucrPnlCorrelationType.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrPnlCorrelationType.Name = "ucrPnlCorrelationType"
        Me.ucrPnlCorrelationType.Size = New System.Drawing.Size(180, 86)
        Me.ucrPnlCorrelationType.TabIndex = 150
        '
        'ucrReceiverLocations
        '
        Me.ucrReceiverLocations.AutoSize = True
        Me.ucrReceiverLocations.frmParent = Me
        Me.ucrReceiverLocations.Location = New System.Drawing.Point(294, 349)
        Me.ucrReceiverLocations.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLocations.Name = "ucrReceiverLocations"
        Me.ucrReceiverLocations.Selector = Nothing
        Me.ucrReceiverLocations.Size = New System.Drawing.Size(175, 25)
        Me.ucrReceiverLocations.strNcFilePath = ""
        Me.ucrReceiverLocations.TabIndex = 139
        Me.ucrReceiverLocations.ucrSelector = Nothing
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(11, 578)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(485, 30)
        Me.ucrSaveGraph.TabIndex = 110
        '
        'ucrBlock
        '
        Me.ucrBlock.AutoSize = True
        Me.ucrBlock.frmParent = Me
        Me.ucrBlock.Location = New System.Drawing.Point(295, 245)
        Me.ucrBlock.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrBlock.Name = "ucrBlock"
        Me.ucrBlock.Selector = Nothing
        Me.ucrBlock.Size = New System.Drawing.Size(175, 25)
        Me.ucrBlock.strNcFilePath = ""
        Me.ucrBlock.TabIndex = 80
        Me.ucrBlock.ucrSelector = Nothing
        '
        'UcrBaseExperimentsOneButton
        '
        Me.UcrBaseExperimentsOneButton.AutoSize = True
        Me.UcrBaseExperimentsOneButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcrBaseExperimentsOneButton.Location = New System.Drawing.Point(11, 615)
        Me.UcrBaseExperimentsOneButton.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.UcrBaseExperimentsOneButton.Name = "UcrBaseExperimentsOneButton"
        Me.UcrBaseExperimentsOneButton.Size = New System.Drawing.Size(511, 65)
        Me.UcrBaseExperimentsOneButton.TabIndex = 83
        '
        'ucrSave
        '
        Me.ucrSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSave.Location = New System.Drawing.Point(11, 542)
        Me.ucrSave.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSave.Name = "ucrSave"
        Me.ucrSave.Size = New System.Drawing.Size(485, 30)
        Me.ucrSave.TabIndex = 82
        '
        'ucrReceiverResponse
        '
        Me.ucrReceiverResponse.AutoSize = True
        Me.ucrReceiverResponse.frmParent = Me
        Me.ucrReceiverResponse.Location = New System.Drawing.Point(295, 148)
        Me.ucrReceiverResponse.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverResponse.Name = "ucrReceiverResponse"
        Me.ucrReceiverResponse.Selector = Nothing
        Me.ucrReceiverResponse.Size = New System.Drawing.Size(175, 25)
        Me.ucrReceiverResponse.strNcFilePath = ""
        Me.ucrReceiverResponse.TabIndex = 75
        Me.ucrReceiverResponse.ucrSelector = Nothing
        '
        'ucrRep
        '
        Me.ucrRep.AutoSize = True
        Me.ucrRep.frmParent = Me
        Me.ucrRep.Location = New System.Drawing.Point(295, 297)
        Me.ucrRep.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrRep.Name = "ucrRep"
        Me.ucrRep.Selector = Nothing
        Me.ucrRep.Size = New System.Drawing.Size(175, 25)
        Me.ucrRep.strNcFilePath = ""
        Me.ucrRep.TabIndex = 81
        Me.ucrRep.ucrSelector = Nothing
        '
        'ucrReceiverFactorA
        '
        Me.ucrReceiverFactorA.AutoSize = True
        Me.ucrReceiverFactorA.frmParent = Me
        Me.ucrReceiverFactorA.Location = New System.Drawing.Point(295, 195)
        Me.ucrReceiverFactorA.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactorA.Name = "ucrReceiverFactorA"
        Me.ucrReceiverFactorA.Selector = Nothing
        Me.ucrReceiverFactorA.Size = New System.Drawing.Size(175, 25)
        Me.ucrReceiverFactorA.strNcFilePath = ""
        Me.ucrReceiverFactorA.TabIndex = 78
        Me.ucrReceiverFactorA.ucrSelector = Nothing
        '
        'ucrReceiverFactorB
        '
        Me.ucrReceiverFactorB.AutoSize = True
        Me.ucrReceiverFactorB.frmParent = Me
        Me.ucrReceiverFactorB.Location = New System.Drawing.Point(295, 245)
        Me.ucrReceiverFactorB.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactorB.Name = "ucrReceiverFactorB"
        Me.ucrReceiverFactorB.Selector = Nothing
        Me.ucrReceiverFactorB.Size = New System.Drawing.Size(175, 25)
        Me.ucrReceiverFactorB.strNcFilePath = ""
        Me.ucrReceiverFactorB.TabIndex = 79
        Me.ucrReceiverFactorB.ucrSelector = Nothing
        '
        'ucrChkPlot
        '
        Me.ucrChkPlot.AutoSize = True
        Me.ucrChkPlot.Checked = False
        Me.ucrChkPlot.Location = New System.Drawing.Point(11, 382)
        Me.ucrChkPlot.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkPlot.Name = "ucrChkPlot"
        Me.ucrChkPlot.Size = New System.Drawing.Size(150, 29)
        Me.ucrChkPlot.TabIndex = 91
        '
        'ucrSelectorForRank
        '
        Me.ucrSelectorForRank.AutoSize = True
        Me.ucrSelectorForRank.bDropUnusedFilterLevels = False
        Me.ucrSelectorForRank.bShowHiddenColumns = False
        Me.ucrSelectorForRank.bUseCurrentFilter = True
        Me.ucrSelectorForRank.Location = New System.Drawing.Point(11, 101)
        Me.ucrSelectorForRank.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForRank.Name = "ucrSelectorForRank"
        Me.ucrSelectorForRank.Size = New System.Drawing.Size(266, 229)
        Me.ucrSelectorForRank.TabIndex = 71
        '
        'ucrPnlExperimentsOneButtonOptions
        '
        Me.ucrPnlExperimentsOneButtonOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlExperimentsOneButtonOptions.Location = New System.Drawing.Point(15, 5)
        Me.ucrPnlExperimentsOneButtonOptions.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrPnlExperimentsOneButtonOptions.Name = "ucrPnlExperimentsOneButtonOptions"
        Me.ucrPnlExperimentsOneButtonOptions.Size = New System.Drawing.Size(505, 52)
        Me.ucrPnlExperimentsOneButtonOptions.TabIndex = 90
        '
        'ucrPnlDesign
        '
        Me.ucrPnlDesign.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDesign.Location = New System.Drawing.Point(11, 62)
        Me.ucrPnlDesign.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrPnlDesign.Name = "ucrPnlDesign"
        Me.ucrPnlDesign.Size = New System.Drawing.Size(509, 31)
        Me.ucrPnlDesign.TabIndex = 120
        '
        'UcrReceiverTreat
        '
        Me.UcrReceiverTreat.AutoSize = True
        Me.UcrReceiverTreat.frmParent = Me
        Me.UcrReceiverTreat.Location = New System.Drawing.Point(295, 195)
        Me.UcrReceiverTreat.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverTreat.Name = "UcrReceiverTreat"
        Me.UcrReceiverTreat.Selector = Nothing
        Me.UcrReceiverTreat.Size = New System.Drawing.Size(175, 25)
        Me.UcrReceiverTreat.strNcFilePath = ""
        Me.UcrReceiverTreat.TabIndex = 77
        Me.UcrReceiverTreat.ucrSelector = Nothing
        '
        'ucrNudSelectionDifferential
        '
        Me.ucrNudSelectionDifferential.AutoSize = True
        Me.ucrNudSelectionDifferential.DecimalPlaces = New Decimal(New Integer() {3, 0, 0, 0})
        Me.ucrNudSelectionDifferential.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.ucrNudSelectionDifferential.Location = New System.Drawing.Point(187, 341)
        Me.ucrNudSelectionDifferential.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrNudSelectionDifferential.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ucrNudSelectionDifferential.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSelectionDifferential.Name = "ucrNudSelectionDifferential"
        Me.ucrNudSelectionDifferential.Size = New System.Drawing.Size(90, 25)
        Me.ucrNudSelectionDifferential.TabIndex = 134
        Me.ttVariability.SetToolTip(Me.ucrNudSelectionDifferential, "The value 2.063 is the differential for 5% intensity")
        Me.ucrNudSelectionDifferential.Value = New Decimal(New Integer() {2063, 0, 0, 196608})
        '
        'UcrCheckAlphaExperiments
        '
        Me.UcrCheckAlphaExperiments.AutoSize = True
        Me.UcrCheckAlphaExperiments.Checked = False
        Me.UcrCheckAlphaExperiments.Location = New System.Drawing.Point(12, 343)
        Me.UcrCheckAlphaExperiments.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.UcrCheckAlphaExperiments.Name = "UcrCheckAlphaExperiments"
        Me.UcrCheckAlphaExperiments.Size = New System.Drawing.Size(128, 29)
        Me.UcrCheckAlphaExperiments.TabIndex = 121
        '
        'ucrAlpha
        '
        Me.ucrAlpha.AddQuotesIfUnrecognised = True
        Me.ucrAlpha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrAlpha.GetSetSelectedIndex = -1
        Me.ucrAlpha.IsReadOnly = False
        Me.ucrAlpha.Location = New System.Drawing.Point(187, 341)
        Me.ucrAlpha.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrAlpha.Name = "ucrAlpha"
        Me.ucrAlpha.Size = New System.Drawing.Size(90, 25)
        Me.ucrAlpha.TabIndex = 73
        '
        'dlgExperimentsOneButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(535, 686)
        Me.Controls.Add(Me.ucrReceiverExplanatory)
        Me.Controls.Add(Me.lblExplanatory)
        Me.Controls.Add(Me.grpClusteringMethod)
        Me.Controls.Add(Me.ucrReceiverMultipleResponses)
        Me.Controls.Add(Me.lblMultipleResponses)
        Me.Controls.Add(Me.grpCorrelationType)
        Me.Controls.Add(Me.ucrReceiverLocations)
        Me.Controls.Add(Me.lblLocations)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.lblBlock)
        Me.Controls.Add(Me.ucrBlock)
        Me.Controls.Add(Me.rdoDiallel)
        Me.Controls.Add(Me.rdoLxt)
        Me.Controls.Add(Me.rdoAugmented)
        Me.Controls.Add(Me.lblDesign)
        Me.Controls.Add(Me.UcrBaseExperimentsOneButton)
        Me.Controls.Add(Me.ucrSave)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.ucrReceiverResponse)
        Me.Controls.Add(Me.lblRep)
        Me.Controls.Add(Me.ucrRep)
        Me.Controls.Add(Me.lblFactorA)
        Me.Controls.Add(Me.ucrReceiverFactorA)
        Me.Controls.Add(Me.lblFactorB)
        Me.Controls.Add(Me.ucrReceiverFactorB)
        Me.Controls.Add(Me.ucrChkPlot)
        Me.Controls.Add(Me.ucrSelectorForRank)
        Me.Controls.Add(Me.rdoFactorial)
        Me.Controls.Add(Me.rdorbd)
        Me.Controls.Add(Me.rdoGeneral)
        Me.Controls.Add(Me.rdoSpecial)
        Me.Controls.Add(Me.ucrPnlExperimentsOneButtonOptions)
        Me.Controls.Add(Me.ucrPnlDesign)
        Me.Controls.Add(Me.lblTreat)
        Me.Controls.Add(Me.UcrReceiverTreat)
        Me.Controls.Add(Me.rdoCorrelations)
        Me.Controls.Add(Me.rdoStability)
        Me.Controls.Add(Me.rdoDiversity)
        Me.Controls.Add(Me.rdoVariability)
        Me.Controls.Add(Me.rdoPath)
        Me.Controls.Add(Me.ucrNudSelectionDifferential)
        Me.Controls.Add(Me.lblSelectionDifferential)
        Me.Controls.Add(Me.UcrCheckAlphaExperiments)
        Me.Controls.Add(Me.ucrAlpha)
        Me.Controls.Add(Me.btnChecks)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExperimentsOneButton"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Button"
        Me.grpClusteringMethod.ResumeLayout(False)
        Me.grpClusteringMethod.PerformLayout()
        Me.grpCorrelationType.ResumeLayout(False)
        Me.grpCorrelationType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdoGeneral As RadioButton
    Friend WithEvents rdoSpecial As RadioButton
    Friend WithEvents rdoFactorial As RadioButton
    Friend WithEvents rdorbd As RadioButton
    Friend WithEvents rdoDiallel As RadioButton
    Friend WithEvents rdoLxt As RadioButton
    Friend WithEvents rdoAugmented As RadioButton
    Friend WithEvents ucrSelectorForRank As instat.ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrAlpha As instat.ucrInputComboBox
    Friend WithEvents lblResponse As Label
    Friend WithEvents ucrReceiverResponse As instat.ucrReceiverSingle
    Friend WithEvents lblRep As Label
    Friend WithEvents ucrRep As instat.ucrReceiverSingle
    Friend WithEvents lblFactorA As Label
    Friend WithEvents ucrReceiverFactorA As instat.ucrReceiverSingle
    Friend WithEvents lblFactorB As Label
    Friend WithEvents ucrReceiverFactorB As instat.ucrReceiverSingle
    Friend WithEvents lblBlock As Label
    Friend WithEvents ucrBlock As instat.ucrReceiverSingle
    Friend WithEvents btnChecks As Button
    Friend WithEvents ucrChkPlot As instat.ucrCheck
    Friend WithEvents ucrSave As instat.ucrSave
    Friend WithEvents ucrSaveGraph As instat.ucrSave
    Friend WithEvents UcrBaseExperimentsOneButton As instat.ucrButtons
    Friend WithEvents lblDesign As Label
    Friend WithEvents lblTreat As Label
    Friend WithEvents UcrReceiverTreat As instat.ucrReceiverSingle
    Friend WithEvents ucrPnlExperimentsOneButtonOptions As instat.UcrPanel
    Friend WithEvents ucrPnlDesign As instat.UcrPanel
    Friend WithEvents ttDesign As ToolTip
    Friend WithEvents ttVariability As ToolTip
    Friend WithEvents UcrCheckAlphaExperiments As instat.ucrCheck
    Friend WithEvents rdoPath As RadioButton
    Friend WithEvents rdoVariability As RadioButton
    Friend WithEvents rdoDiversity As RadioButton
    Friend WithEvents rdoStability As RadioButton
    Friend WithEvents rdoCorrelations As RadioButton
    Friend WithEvents lblClusters As Label
    Friend WithEvents ucrNudClusters As instat.ucrNud
    Friend WithEvents lblExplanatory As Label
    Friend WithEvents ucrReceiverExplanatory As instat.ucrReceiverMultiple
    Friend WithEvents lblLocations As Label
    Friend WithEvents ucrReceiverLocations As instat.ucrReceiverSingle
    Friend WithEvents lblSelectionDifferential As Label
    Friend WithEvents ucrNudSelectionDifferential As instat.ucrNud
    Friend WithEvents lblMultipleResponses As Label
    Friend WithEvents ucrReceiverMultipleResponses As instat.ucrReceiverMultiple
    Friend WithEvents rdoGenotypic As RadioButton
    Friend WithEvents rdoHierarchical As RadioButton
    Friend WithEvents rdoPhenotypic As RadioButton
    Friend WithEvents rdoTocher As RadioButton
    Friend WithEvents grpClusteringMethod As GroupBox
    Friend WithEvents ucrPnlClustering As instat.UcrPanel
    Friend WithEvents grpCorrelationType As GroupBox
    Friend WithEvents ucrPnlCorrelationType As instat.UcrPanel
End Class