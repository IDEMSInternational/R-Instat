<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgExperimentsOneButton
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
        Me.components = New System.ComponentModel.Container()
        Me.rdoGeneral = New System.Windows.Forms.RadioButton()
        Me.rdoSpecial = New System.Windows.Forms.RadioButton()
        Me.rdoFactorial = New System.Windows.Forms.RadioButton()
        Me.rdorbd = New System.Windows.Forms.RadioButton()
        Me.rdoDiallel = New System.Windows.Forms.RadioButton()
        Me.rdoLxt = New System.Windows.Forms.RadioButton()
        Me.rdoAugmented = New System.Windows.Forms.RadioButton()
        Me.rdoDiversity = New System.Windows.Forms.RadioButton()
        Me.rdoPath = New System.Windows.Forms.RadioButton()
        Me.rdoStability = New System.Windows.Forms.RadioButton()
        Me.rdoVariability = New System.Windows.Forms.RadioButton()
        Me.rdoCorrelations = New System.Windows.Forms.RadioButton()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.lblRep = New System.Windows.Forms.Label()
        Me.lblFactorA = New System.Windows.Forms.Label()
        Me.lblFactorB = New System.Windows.Forms.Label()
        Me.lblDesign = New System.Windows.Forms.Label()
        Me.lblApha = New System.Windows.Forms.Label()
        Me.lblTreat = New System.Windows.Forms.Label()
        Me.lblBlock = New System.Windows.Forms.Label()
        Me.lblExplanatory = New System.Windows.Forms.Label()
        Me.lblLocations = New System.Windows.Forms.Label()
        Me.lblSelectionDifferential = New System.Windows.Forms.Label()
        Me.grpClusterMethod = New System.Windows.Forms.GroupBox()
        Me.rdoTocher = New System.Windows.Forms.RadioButton()
        Me.rdoHierarchical = New System.Windows.Forms.RadioButton()
        Me.lblNumClusters = New System.Windows.Forms.Label()
        Me.ucrNumClusters = New instat.ucrNud()
        Me.ucrPnlClusterMethod = New instat.UcrPanel()
        Me.grpCorrelationType = New System.Windows.Forms.GroupBox()
        Me.rdoGenotypic = New System.Windows.Forms.RadioButton()
        Me.rdoPhenotypic = New System.Windows.Forms.RadioButton()
        Me.ucrPnlCorrelationType = New instat.UcrPanel()
        Me.UcrBaseExperimentsOneButton = New instat.ucrButtons()
        Me.ucrSave = New instat.ucrSave()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrReceiverResponse = New instat.ucrReceiverSingle()
        Me.ucrReceiverResponseMulti = New instat.ucrReceiverMultiple()
        Me.ucrRep = New instat.ucrReceiverSingle()
        Me.ucrReceiverFactorA = New instat.ucrReceiverSingle()
        Me.ucrReceiverFactorB = New instat.ucrReceiverSingle()
        Me.ucrBlock = New instat.ucrReceiverSingle()
        Me.ucrReceiverExplanatory = New instat.ucrReceiverMultiple()
        Me.ucrReceiverLocations = New instat.ucrReceiverSingle()
        Me.btnChecks = New System.Windows.Forms.Button()
        Me.ucrChkPlot = New instat.ucrCheck()
        Me.ucrAlpha = New instat.ucrInputComboBox()
        Me.ucrSelectionDifferential = New instat.ucrNud()
        Me.ucrSelectorForRank = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlExperimentsOneButtonOptions = New instat.UcrPanel()
        Me.ucrPnlDesign = New instat.UcrPanel()
        Me.UcrReceiverTreat = New instat.ucrReceiverSingle()
        Me.ttDesign = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttVariability = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpClusterMethod.SuspendLayout()
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
        Me.rdoGeneral.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGeneral.Location = New System.Drawing.Point(56, 12)
        Me.rdoGeneral.Name = "rdoGeneral"
        Me.rdoGeneral.Size = New System.Drawing.Size(129, 27)
        Me.rdoGeneral.TabIndex = 21
        Me.rdoGeneral.TabStop = True
        Me.rdoGeneral.Text = "General"
        Me.rdoGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGeneral.UseVisualStyleBackColor = True
        '
        'rdoSpecial
        '
        Me.rdoSpecial.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSpecial.Enabled = False
        Me.rdoSpecial.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSpecial.FlatAppearance.BorderSize = 2
        Me.rdoSpecial.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSpecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSpecial.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSpecial.Location = New System.Drawing.Point(183, 12)
        Me.rdoSpecial.Name = "rdoSpecial"
        Me.rdoSpecial.Size = New System.Drawing.Size(129, 27)
        Me.rdoSpecial.TabIndex = 20
        Me.rdoSpecial.TabStop = True
        Me.rdoSpecial.Text = "Special"
        Me.rdoSpecial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSpecial.UseVisualStyleBackColor = True
        '
        'rdoFactorial
        '
        Me.rdoFactorial.AutoSize = True
        Me.rdoFactorial.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoFactorial.Location = New System.Drawing.Point(115, 54)
        Me.rdoFactorial.Name = "rdoFactorial"
        Me.rdoFactorial.Size = New System.Drawing.Size(65, 17)
        Me.rdoFactorial.TabIndex = 70
        Me.rdoFactorial.TabStop = True
        Me.rdoFactorial.Text = "Factorial"
        Me.rdoFactorial.UseVisualStyleBackColor = True
        '
        'rdorbd
        '
        Me.rdorbd.AutoSize = True
        Me.rdorbd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdorbd.Location = New System.Drawing.Point(67, 54)
        Me.rdorbd.Name = "rdorbd"
        Me.rdorbd.Size = New System.Drawing.Size(40, 17)
        Me.rdorbd.TabIndex = 69
        Me.rdorbd.TabStop = True
        Me.rdorbd.Text = "rbd"
        Me.rdorbd.UseVisualStyleBackColor = True
        '
        'rdoDiallel
        '
        Me.rdoDiallel.AutoSize = True
        Me.rdoDiallel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDiallel.Location = New System.Drawing.Point(190, 54)
        Me.rdoDiallel.Name = "rdoDiallel"
        Me.rdoDiallel.Size = New System.Drawing.Size(53, 17)
        Me.rdoDiallel.TabIndex = 92
        Me.rdoDiallel.TabStop = True
        Me.rdoDiallel.Text = "Diallel"
        Me.rdoDiallel.UseVisualStyleBackColor = True
        '
        'rdoLxt
        '
        Me.rdoLxt.AutoSize = True
        Me.rdoLxt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLxt.Location = New System.Drawing.Point(258, 54)
        Me.rdoLxt.Name = "rdoLxt"
        Me.rdoLxt.Size = New System.Drawing.Size(35, 17)
        Me.rdoLxt.TabIndex = 93
        Me.rdoLxt.TabStop = True
        Me.rdoLxt.Text = "lxt"
        Me.rdoLxt.UseVisualStyleBackColor = True
        '
        'rdoAugmented
        '
        Me.rdoAugmented.AutoSize = True
        Me.rdoAugmented.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAugmented.Location = New System.Drawing.Point(304, 54)
        Me.rdoAugmented.Name = "rdoAugmented"
        Me.rdoAugmented.Size = New System.Drawing.Size(79, 17)
        Me.rdoAugmented.TabIndex = 94
        Me.rdoAugmented.TabStop = True
        Me.rdoAugmented.Text = "Augmented"
        Me.rdoAugmented.UseVisualStyleBackColor = True
        '
        'rdoDiversity
        '
        Me.rdoDiversity.AutoSize = True
        Me.rdoDiversity.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDiversity.Location = New System.Drawing.Point(67, 54)
        Me.rdoDiversity.Name = "rdoDiversity"
        Me.rdoDiversity.Size = New System.Drawing.Size(65, 17)
        Me.rdoDiversity.TabIndex = 100
        Me.rdoDiversity.TabStop = True
        Me.rdoDiversity.Text = "Diversity"
        Me.rdoDiversity.UseVisualStyleBackColor = True
        '
        'rdoPath
        '
        Me.rdoPath.AutoSize = True
        Me.rdoPath.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPath.Location = New System.Drawing.Point(139, 54)
        Me.rdoPath.Name = "rdoPath"
        Me.rdoPath.Size = New System.Drawing.Size(47, 17)
        Me.rdoPath.TabIndex = 101
        Me.rdoPath.TabStop = True
        Me.rdoPath.Text = "Path"
        Me.rdoPath.UseVisualStyleBackColor = True
        '
        'rdoStability
        '
        Me.rdoStability.AutoSize = True
        Me.rdoStability.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoStability.Location = New System.Drawing.Point(190, 54)
        Me.rdoStability.Name = "rdoStability"
        Me.rdoStability.Size = New System.Drawing.Size(61, 17)
        Me.rdoStability.TabIndex = 102
        Me.rdoStability.TabStop = True
        Me.rdoStability.Text = "Stability"
        Me.rdoStability.UseVisualStyleBackColor = True
        '
        'rdoVariability
        '
        Me.rdoVariability.AutoSize = True
        Me.rdoVariability.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoVariability.Location = New System.Drawing.Point(259, 54)
        Me.rdoVariability.Name = "rdoVariability"
        Me.rdoVariability.Size = New System.Drawing.Size(69, 17)
        Me.rdoVariability.TabIndex = 103
        Me.rdoVariability.TabStop = True
        Me.rdoVariability.Text = "Variability"
        Me.rdoVariability.UseVisualStyleBackColor = True
        '
        'rdoCorrelations
        '
        Me.rdoCorrelations.AutoSize = True
        Me.rdoCorrelations.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCorrelations.Location = New System.Drawing.Point(342, 54)
        Me.rdoCorrelations.Name = "rdoCorrelations"
        Me.rdoCorrelations.Size = New System.Drawing.Size(80, 17)
        Me.rdoCorrelations.TabIndex = 104
        Me.rdoCorrelations.TabStop = True
        Me.rdoCorrelations.Text = "Correlations"
        Me.rdoCorrelations.UseVisualStyleBackColor = True
        '
        'lblResponse
        '
        Me.lblResponse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResponse.Location = New System.Drawing.Point(246, 98)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(124, 18)
        Me.lblResponse.TabIndex = 74
        Me.lblResponse.Text = "Response:"
        '
        'lblRep
        '
        Me.lblRep.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRep.Location = New System.Drawing.Point(246, 229)
        Me.lblRep.Name = "lblRep"
        Me.lblRep.Size = New System.Drawing.Size(124, 13)
        Me.lblRep.TabIndex = 80
        Me.lblRep.Text = "Rep :"
        '
        'lblFactorA
        '
        Me.lblFactorA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactorA.Location = New System.Drawing.Point(246, 139)
        Me.lblFactorA.Name = "lblFactorA"
        Me.lblFactorA.Size = New System.Drawing.Size(80, 16)
        Me.lblFactorA.TabIndex = 76
        Me.lblFactorA.Text = "Factor A:"
        '
        'lblFactorB
        '
        Me.lblFactorB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactorB.Location = New System.Drawing.Point(246, 187)
        Me.lblFactorB.Name = "lblFactorB"
        Me.lblFactorB.Size = New System.Drawing.Size(80, 17)
        Me.lblFactorB.TabIndex = 78
        Me.lblFactorB.Text = "Factor B:"
        '
        'lblDesign
        '
        Me.lblDesign.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDesign.Location = New System.Drawing.Point(10, 56)
        Me.lblDesign.Name = "lblDesign"
        Me.lblDesign.Size = New System.Drawing.Size(43, 13)
        Me.lblDesign.TabIndex = 84
        Me.lblDesign.Text = "Design:"
        '
        'lblApha
        '
        Me.lblApha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblApha.Location = New System.Drawing.Point(9, 380)
        Me.lblApha.Name = "lblApha"
        Me.lblApha.Size = New System.Drawing.Size(43, 13)
        Me.lblApha.TabIndex = 85
        Me.lblApha.Text = "Alpha:"
        '
        'lblTreat
        '
        Me.lblTreat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTreat.Location = New System.Drawing.Point(246, 141)
        Me.lblTreat.Name = "lblTreat"
        Me.lblTreat.Size = New System.Drawing.Size(80, 16)
        Me.lblTreat.TabIndex = 88
        Me.lblTreat.Text = "Treat :"
        '
        'lblBlock
        '
        Me.lblBlock.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBlock.Location = New System.Drawing.Point(246, 192)
        Me.lblBlock.Name = "lblBlock"
        Me.lblBlock.Size = New System.Drawing.Size(80, 17)
        Me.lblBlock.TabIndex = 95
        Me.lblBlock.Text = "Block:"
        '
        'lblExplanatory
        '
        Me.lblExplanatory.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExplanatory.Location = New System.Drawing.Point(246, 285)
        Me.lblExplanatory.Name = "lblExplanatory"
        Me.lblExplanatory.Size = New System.Drawing.Size(140, 13)
        Me.lblExplanatory.TabIndex = 105
        Me.lblExplanatory.Text = "Explanatory Variables:"
        '
        'lblLocations
        '
        Me.lblLocations.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLocations.Location = New System.Drawing.Point(246, 285)
        Me.lblLocations.Name = "lblLocations"
        Me.lblLocations.Size = New System.Drawing.Size(124, 13)
        Me.lblLocations.TabIndex = 107
        Me.lblLocations.Text = "Locations:"
        '
        'lblSelectionDifferential
        '
        Me.lblSelectionDifferential.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectionDifferential.Location = New System.Drawing.Point(9, 380)
        Me.lblSelectionDifferential.Name = "lblSelectionDifferential"
        Me.lblSelectionDifferential.Size = New System.Drawing.Size(130, 26)
        Me.lblSelectionDifferential.TabIndex = 109
        Me.lblSelectionDifferential.Text = "Selection Differential:"
        '
        'grpClusterMethod
        '
        Me.grpClusterMethod.Controls.Add(Me.rdoTocher)
        Me.grpClusterMethod.Controls.Add(Me.rdoHierarchical)
        Me.grpClusterMethod.Controls.Add(Me.lblNumClusters)
        Me.grpClusterMethod.Controls.Add(Me.ucrNumClusters)
        Me.grpClusterMethod.Controls.Add(Me.ucrPnlClusterMethod)
        Me.grpClusterMethod.Location = New System.Drawing.Point(9, 285)
        Me.grpClusterMethod.Name = "grpClusterMethod"
        Me.grpClusterMethod.Size = New System.Drawing.Size(213, 90)
        Me.grpClusterMethod.TabIndex = 106
        Me.grpClusterMethod.TabStop = False
        Me.grpClusterMethod.Text = "Clustering Method"
        '
        'rdoTocher
        '
        Me.rdoTocher.AutoSize = True
        Me.rdoTocher.Checked = True
        Me.rdoTocher.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTocher.Location = New System.Drawing.Point(10, 20)
        Me.rdoTocher.Name = "rdoTocher"
        Me.rdoTocher.Size = New System.Drawing.Size(59, 17)
        Me.rdoTocher.TabIndex = 0
        Me.rdoTocher.TabStop = True
        Me.rdoTocher.Text = "Tocher"
        Me.rdoTocher.UseVisualStyleBackColor = True
        '
        'rdoHierarchical
        '
        Me.rdoHierarchical.AutoSize = True
        Me.rdoHierarchical.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHierarchical.Location = New System.Drawing.Point(10, 42)
        Me.rdoHierarchical.Name = "rdoHierarchical"
        Me.rdoHierarchical.Size = New System.Drawing.Size(81, 17)
        Me.rdoHierarchical.TabIndex = 1
        Me.rdoHierarchical.Text = "Hierarchical"
        Me.rdoHierarchical.UseVisualStyleBackColor = True
        '
        'lblNumClusters
        '
        Me.lblNumClusters.AutoSize = True
        Me.lblNumClusters.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumClusters.Location = New System.Drawing.Point(10, 66)
        Me.lblNumClusters.Name = "lblNumClusters"
        Me.lblNumClusters.Size = New System.Drawing.Size(47, 13)
        Me.lblNumClusters.TabIndex = 2
        Me.lblNumClusters.Text = "Number:"
        Me.lblNumClusters.Visible = False
        '
        'ucrNumClusters
        '
        Me.ucrNumClusters.AutoSize = True
        Me.ucrNumClusters.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNumClusters.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNumClusters.Location = New System.Drawing.Point(75, 62)
        Me.ucrNumClusters.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.ucrNumClusters.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNumClusters.Name = "ucrNumClusters"
        Me.ucrNumClusters.Size = New System.Drawing.Size(55, 20)
        Me.ucrNumClusters.TabIndex = 4
        Me.ucrNumClusters.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'ucrPnlClusterMethod
        '
        Me.ucrPnlClusterMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlClusterMethod.Location = New System.Drawing.Point(6, 15)
        Me.ucrPnlClusterMethod.Name = "ucrPnlClusterMethod"
        Me.ucrPnlClusterMethod.Size = New System.Drawing.Size(150, 45)
        Me.ucrPnlClusterMethod.TabIndex = 3
        '
        'grpCorrelationType
        '
        Me.grpCorrelationType.Controls.Add(Me.rdoGenotypic)
        Me.grpCorrelationType.Controls.Add(Me.rdoPhenotypic)
        Me.grpCorrelationType.Controls.Add(Me.ucrPnlCorrelationType)
        Me.grpCorrelationType.Location = New System.Drawing.Point(9, 285)
        Me.grpCorrelationType.Name = "grpCorrelationType"
        Me.grpCorrelationType.Size = New System.Drawing.Size(213, 68)
        Me.grpCorrelationType.TabIndex = 108
        Me.grpCorrelationType.TabStop = False
        Me.grpCorrelationType.Text = "Correlation Type"
        '
        'rdoGenotypic
        '
        Me.rdoGenotypic.AutoSize = True
        Me.rdoGenotypic.Checked = True
        Me.rdoGenotypic.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGenotypic.Location = New System.Drawing.Point(10, 20)
        Me.rdoGenotypic.Name = "rdoGenotypic"
        Me.rdoGenotypic.Size = New System.Drawing.Size(73, 17)
        Me.rdoGenotypic.TabIndex = 0
        Me.rdoGenotypic.TabStop = True
        Me.rdoGenotypic.Text = "Genotypic"
        Me.rdoGenotypic.UseVisualStyleBackColor = True
        '
        'rdoPhenotypic
        '
        Me.rdoPhenotypic.AutoSize = True
        Me.rdoPhenotypic.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPhenotypic.Location = New System.Drawing.Point(10, 42)
        Me.rdoPhenotypic.Name = "rdoPhenotypic"
        Me.rdoPhenotypic.Size = New System.Drawing.Size(78, 17)
        Me.rdoPhenotypic.TabIndex = 1
        Me.rdoPhenotypic.Text = "Phenotypic"
        Me.rdoPhenotypic.UseVisualStyleBackColor = True
        '
        'ucrPnlCorrelationType
        '
        Me.ucrPnlCorrelationType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlCorrelationType.Location = New System.Drawing.Point(6, 15)
        Me.ucrPnlCorrelationType.Name = "ucrPnlCorrelationType"
        Me.ucrPnlCorrelationType.Size = New System.Drawing.Size(150, 45)
        Me.ucrPnlCorrelationType.TabIndex = 2
        '
        'UcrBaseExperimentsOneButton
        '
        Me.UcrBaseExperimentsOneButton.AutoSize = True
        Me.UcrBaseExperimentsOneButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcrBaseExperimentsOneButton.Location = New System.Drawing.Point(9, 460)
        Me.UcrBaseExperimentsOneButton.Margin = New System.Windows.Forms.Padding(4)
        Me.UcrBaseExperimentsOneButton.Name = "UcrBaseExperimentsOneButton"
        Me.UcrBaseExperimentsOneButton.Size = New System.Drawing.Size(408, 52)
        Me.UcrBaseExperimentsOneButton.TabIndex = 83
        '
        'ucrSave
        '
        Me.ucrSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSave.Location = New System.Drawing.Point(9, 412)
        Me.ucrSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSave.Name = "ucrSave"
        Me.ucrSave.Size = New System.Drawing.Size(388, 24)
        Me.ucrSave.TabIndex = 82
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(9, 436)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(388, 24)
        Me.ucrSaveGraph.TabIndex = 110
        '
        'ucrReceiverResponse
        '
        Me.ucrReceiverResponse.AutoSize = True
        Me.ucrReceiverResponse.frmParent = Me
        Me.ucrReceiverResponse.Location = New System.Drawing.Point(246, 119)
        Me.ucrReceiverResponse.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverResponse.Name = "ucrReceiverResponse"
        Me.ucrReceiverResponse.Selector = Nothing
        Me.ucrReceiverResponse.Size = New System.Drawing.Size(140, 20)
        Me.ucrReceiverResponse.strNcFilePath = ""
        Me.ucrReceiverResponse.TabIndex = 75
        Me.ucrReceiverResponse.ucrSelector = Nothing
        '
        'ucrReceiverResponseMulti
        '
        Me.ucrReceiverResponseMulti.AutoSize = True
        Me.ucrReceiverResponseMulti.frmParent = Me
        Me.ucrReceiverResponseMulti.Location = New System.Drawing.Point(246, 119)
        Me.ucrReceiverResponseMulti.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverResponseMulti.Name = "ucrReceiverResponseMulti"
        Me.ucrReceiverResponseMulti.Selector = Nothing
        Me.ucrReceiverResponseMulti.Size = New System.Drawing.Size(140, 60)
        Me.ucrReceiverResponseMulti.strNcFilePath = ""
        Me.ucrReceiverResponseMulti.TabIndex = 76
        Me.ucrReceiverResponseMulti.ucrSelector = Nothing
        '
        'ucrRep
        '
        Me.ucrRep.AutoSize = True
        Me.ucrRep.frmParent = Me
        Me.ucrRep.Location = New System.Drawing.Point(246, 245)
        Me.ucrRep.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrRep.Name = "ucrRep"
        Me.ucrRep.Selector = Nothing
        Me.ucrRep.Size = New System.Drawing.Size(140, 20)
        Me.ucrRep.strNcFilePath = ""
        Me.ucrRep.TabIndex = 81
        Me.ucrRep.ucrSelector = Nothing
        '
        'ucrReceiverFactorA
        '
        Me.ucrReceiverFactorA.AutoSize = True
        Me.ucrReceiverFactorA.frmParent = Me
        Me.ucrReceiverFactorA.Location = New System.Drawing.Point(246, 159)
        Me.ucrReceiverFactorA.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactorA.Name = "ucrReceiverFactorA"
        Me.ucrReceiverFactorA.Selector = Nothing
        Me.ucrReceiverFactorA.Size = New System.Drawing.Size(140, 20)
        Me.ucrReceiverFactorA.strNcFilePath = ""
        Me.ucrReceiverFactorA.TabIndex = 78
        Me.ucrReceiverFactorA.ucrSelector = Nothing
        '
        'ucrReceiverFactorB
        '
        Me.ucrReceiverFactorB.AutoSize = True
        Me.ucrReceiverFactorB.frmParent = Me
        Me.ucrReceiverFactorB.Location = New System.Drawing.Point(246, 207)
        Me.ucrReceiverFactorB.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactorB.Name = "ucrReceiverFactorB"
        Me.ucrReceiverFactorB.Selector = Nothing
        Me.ucrReceiverFactorB.Size = New System.Drawing.Size(140, 20)
        Me.ucrReceiverFactorB.strNcFilePath = ""
        Me.ucrReceiverFactorB.TabIndex = 79
        Me.ucrReceiverFactorB.ucrSelector = Nothing
        '
        'ucrBlock
        '
        Me.ucrBlock.AutoSize = True
        Me.ucrBlock.frmParent = Me
        Me.ucrBlock.Location = New System.Drawing.Point(246, 212)
        Me.ucrBlock.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrBlock.Name = "ucrBlock"
        Me.ucrBlock.Selector = Nothing
        Me.ucrBlock.Size = New System.Drawing.Size(140, 20)
        Me.ucrBlock.strNcFilePath = ""
        Me.ucrBlock.TabIndex = 80
        Me.ucrBlock.ucrSelector = Nothing
        '
        'ucrReceiverExplanatory
        '
        Me.ucrReceiverExplanatory.AutoSize = True
        Me.ucrReceiverExplanatory.frmParent = Me
        Me.ucrReceiverExplanatory.Location = New System.Drawing.Point(246, 301)
        Me.ucrReceiverExplanatory.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverExplanatory.Name = "ucrReceiverExplanatory"
        Me.ucrReceiverExplanatory.Selector = Nothing
        Me.ucrReceiverExplanatory.Size = New System.Drawing.Size(140, 60)
        Me.ucrReceiverExplanatory.strNcFilePath = ""
        Me.ucrReceiverExplanatory.TabIndex = 82
        Me.ucrReceiverExplanatory.ucrSelector = Nothing
        '
        'ucrReceiverLocations
        '
        Me.ucrReceiverLocations.AutoSize = True
        Me.ucrReceiverLocations.frmParent = Me
        Me.ucrReceiverLocations.Location = New System.Drawing.Point(246, 301)
        Me.ucrReceiverLocations.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLocations.Name = "ucrReceiverLocations"
        Me.ucrReceiverLocations.Selector = Nothing
        Me.ucrReceiverLocations.Size = New System.Drawing.Size(140, 20)
        Me.ucrReceiverLocations.strNcFilePath = ""
        Me.ucrReceiverLocations.TabIndex = 83
        Me.ucrReceiverLocations.ucrSelector = Nothing
        '
        'btnChecks
        '
        Me.btnChecks.Location = New System.Drawing.Point(246, 308)
        Me.btnChecks.Margin = New System.Windows.Forms.Padding(5)
        Me.btnChecks.Name = "btnChecks"
        Me.btnChecks.Size = New System.Drawing.Size(140, 26)
        Me.btnChecks.TabIndex = 84
        Me.btnChecks.Text = "Checks"
        Me.btnChecks.UseVisualStyleBackColor = True
        '
        'ucrChkPlot
        '
        Me.ucrChkPlot.AutoSize = True
        Me.ucrChkPlot.Checked = False
        Me.ucrChkPlot.Location = New System.Drawing.Point(9, 355)
        Me.ucrChkPlot.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkPlot.Name = "ucrChkPlot"
        Me.ucrChkPlot.Size = New System.Drawing.Size(120, 23)
        Me.ucrChkPlot.TabIndex = 91
        '
        'ucrAlpha
        '
        Me.ucrAlpha.AddQuotesIfUnrecognised = True
        Me.ucrAlpha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrAlpha.GetSetSelectedIndex = -1
        Me.ucrAlpha.IsReadOnly = False
        Me.ucrAlpha.Location = New System.Drawing.Point(60, 375)
        Me.ucrAlpha.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrAlpha.Name = "ucrAlpha"
        Me.ucrAlpha.Size = New System.Drawing.Size(72, 20)
        Me.ucrAlpha.TabIndex = 73
        '
        'ucrSelectionDifferential
        '
        Me.ucrSelectionDifferential.AutoSize = True
        Me.ucrSelectionDifferential.DecimalPlaces = New Decimal(New Integer() {3, 0, 0, 0})
        Me.ucrSelectionDifferential.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.ucrSelectionDifferential.Location = New System.Drawing.Point(145, 378)
        Me.ucrSelectionDifferential.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ucrSelectionDifferential.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrSelectionDifferential.Name = "ucrSelectionDifferential"
        Me.ucrSelectionDifferential.Size = New System.Drawing.Size(72, 20)
        Me.ucrSelectionDifferential.TabIndex = 110
        Me.ucrSelectionDifferential.Value = New Decimal(New Integer() {2063, 0, 0, 196608})
        '
        'ucrSelectorForRank
        '
        Me.ucrSelectorForRank.AutoSize = True
        Me.ucrSelectorForRank.bDropUnusedFilterLevels = False
        Me.ucrSelectorForRank.bShowHiddenColumns = False
        Me.ucrSelectorForRank.bUseCurrentFilter = True
        Me.ucrSelectorForRank.Location = New System.Drawing.Point(9, 96)
        Me.ucrSelectorForRank.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForRank.Name = "ucrSelectorForRank"
        Me.ucrSelectorForRank.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForRank.TabIndex = 71
        '
        'ucrPnlExperimentsOneButtonOptions
        '
        Me.ucrPnlExperimentsOneButtonOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlExperimentsOneButtonOptions.Location = New System.Drawing.Point(12, 4)
        Me.ucrPnlExperimentsOneButtonOptions.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrPnlExperimentsOneButtonOptions.Name = "ucrPnlExperimentsOneButtonOptions"
        Me.ucrPnlExperimentsOneButtonOptions.Size = New System.Drawing.Size(404, 42)
        Me.ucrPnlExperimentsOneButtonOptions.TabIndex = 90
        '
        'ucrPnlDesign
        '
        Me.ucrPnlDesign.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDesign.Location = New System.Drawing.Point(9, 50)
        Me.ucrPnlDesign.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrPnlDesign.Name = "ucrPnlDesign"
        Me.ucrPnlDesign.Size = New System.Drawing.Size(408, 25)
        Me.ucrPnlDesign.TabIndex = 120
        '
        'UcrReceiverTreat
        '
        Me.UcrReceiverTreat.AutoSize = True
        Me.UcrReceiverTreat.frmParent = Me
        Me.UcrReceiverTreat.Location = New System.Drawing.Point(246, 160)
        Me.UcrReceiverTreat.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverTreat.Name = "UcrReceiverTreat"
        Me.UcrReceiverTreat.Selector = Nothing
        Me.UcrReceiverTreat.Size = New System.Drawing.Size(140, 20)
        Me.UcrReceiverTreat.strNcFilePath = ""
        Me.UcrReceiverTreat.TabIndex = 77
        Me.UcrReceiverTreat.ucrSelector = Nothing
        '
        'dlgExperimentsOneButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(433, 520)
        Me.Controls.Add(Me.lblSelectionDifferential)
        Me.Controls.Add(Me.ucrSelectionDifferential)
        Me.Controls.Add(Me.lblExplanatory)
        Me.Controls.Add(Me.ucrReceiverExplanatory)
        Me.Controls.Add(Me.lblLocations)
        Me.Controls.Add(Me.ucrReceiverLocations)
        Me.Controls.Add(Me.grpClusterMethod)
        Me.Controls.Add(Me.grpCorrelationType)
        Me.Controls.Add(Me.rdoDiversity)
        Me.Controls.Add(Me.rdoPath)
        Me.Controls.Add(Me.rdoStability)
        Me.Controls.Add(Me.rdoVariability)
        Me.Controls.Add(Me.rdoCorrelations)
        Me.Controls.Add(Me.ucrReceiverResponseMulti)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.btnChecks)
        Me.Controls.Add(Me.lblBlock)
        Me.Controls.Add(Me.ucrBlock)
        Me.Controls.Add(Me.rdoDiallel)
        Me.Controls.Add(Me.rdoLxt)
        Me.Controls.Add(Me.rdoAugmented)
        Me.Controls.Add(Me.lblApha)
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
        Me.Controls.Add(Me.ucrAlpha)
        Me.Controls.Add(Me.ucrSelectorForRank)
        Me.Controls.Add(Me.rdoFactorial)
        Me.Controls.Add(Me.rdorbd)
        Me.Controls.Add(Me.rdoGeneral)
        Me.Controls.Add(Me.rdoSpecial)
        Me.Controls.Add(Me.ucrPnlExperimentsOneButtonOptions)
        Me.Controls.Add(Me.ucrPnlDesign)
        Me.Controls.Add(Me.lblTreat)
        Me.Controls.Add(Me.UcrReceiverTreat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExperimentsOneButton"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Button"
        Me.grpClusterMethod.ResumeLayout(False)
        Me.grpClusterMethod.PerformLayout()
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
    Friend WithEvents rdoDiversity As RadioButton
    Friend WithEvents rdoPath As RadioButton
    Friend WithEvents rdoStability As RadioButton
    Friend WithEvents rdoVariability As RadioButton
    Friend WithEvents rdoCorrelations As RadioButton
    Friend WithEvents ucrSelectorForRank As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrAlpha As ucrInputComboBox
    Friend WithEvents lblResponse As Label
    Friend WithEvents ucrReceiverResponse As ucrReceiverSingle
    Friend WithEvents ucrReceiverResponseMulti As ucrReceiverMultiple
    Friend WithEvents lblRep As Label
    Friend WithEvents ucrRep As ucrReceiverSingle
    Friend WithEvents lblFactorA As Label
    Friend WithEvents ucrReceiverFactorA As ucrReceiverSingle
    Friend WithEvents lblFactorB As Label
    Friend WithEvents ucrReceiverFactorB As ucrReceiverSingle
    Friend WithEvents lblBlock As Label
    Friend WithEvents ucrBlock As ucrReceiverSingle
    Friend WithEvents btnChecks As Button
    Friend WithEvents lblExplanatory As Label
    Friend WithEvents ucrReceiverExplanatory As ucrReceiverMultiple
    Friend WithEvents lblLocations As Label
    Friend WithEvents ucrReceiverLocations As ucrReceiverSingle
    Friend WithEvents lblSelectionDifferential As Label
    Friend WithEvents ucrSelectionDifferential As ucrNud
    Friend WithEvents grpClusterMethod As GroupBox
    Friend WithEvents rdoTocher As RadioButton
    Friend WithEvents rdoHierarchical As RadioButton
    Friend WithEvents lblNumClusters As Label
    Friend WithEvents ucrNumClusters As ucrNud
    Friend WithEvents ucrPnlClusterMethod As UcrPanel
    Friend WithEvents grpCorrelationType As GroupBox
    Friend WithEvents rdoGenotypic As RadioButton
    Friend WithEvents rdoPhenotypic As RadioButton
    Friend WithEvents ucrPnlCorrelationType As UcrPanel
    Friend WithEvents ucrChkPlot As ucrCheck
    Friend WithEvents ucrSave As ucrSave
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents UcrBaseExperimentsOneButton As ucrButtons
    Friend WithEvents lblDesign As Label
    Friend WithEvents lblApha As Label
    Friend WithEvents lblTreat As Label
    Friend WithEvents UcrReceiverTreat As ucrReceiverSingle
    Friend WithEvents ucrPnlExperimentsOneButtonOptions As UcrPanel
    Friend WithEvents ucrPnlDesign As UcrPanel
    Friend WithEvents ttDesign As ToolTip
    Friend WithEvents ttVariability As ToolTip
End Class