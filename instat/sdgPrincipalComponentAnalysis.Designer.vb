
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgPrincipalComponentAnalysis
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
        Me.tbRegOptions = New System.Windows.Forms.TabControl()
        Me.tbDisplay = New System.Windows.Forms.TabPage()
        Me.chkRotation = New System.Windows.Forms.CheckBox()
        Me.chkResiduals = New System.Windows.Forms.CheckBox()
        Me.chkEigenVectors = New System.Windows.Forms.CheckBox()
        Me.chkScores = New System.Windows.Forms.CheckBox()
        Me.chkEigenValues = New System.Windows.Forms.CheckBox()
        Me.tbGraphics = New System.Windows.Forms.TabPage()
        Me.rdoBarPlot = New System.Windows.Forms.RadioButton()
        Me.rdoIndividualsPlot = New System.Windows.Forms.RadioButton()
        Me.rdoBiplot = New System.Windows.Forms.RadioButton()
        Me.rdoVariablesPlot = New System.Windows.Forms.RadioButton()
        Me.rdoScreePlot = New System.Windows.Forms.RadioButton()
        Me.tbGrapOptions = New System.Windows.Forms.TabControl()
        Me.tbScreePlot = New System.Windows.Forms.TabPage()
        Me.chkPercentageScree = New System.Windows.Forms.CheckBox()
        Me.grpGeomScree = New System.Windows.Forms.GroupBox()
        Me.rdoBothScree = New System.Windows.Forms.RadioButton()
        Me.rdoLineGeom = New System.Windows.Forms.RadioButton()
        Me.rdoBarGeom = New System.Windows.Forms.RadioButton()
        Me.lblChoice = New System.Windows.Forms.Label()
        Me.cboChoice = New System.Windows.Forms.ComboBox()
        Me.tbVariables = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboLabelVar = New System.Windows.Forms.ComboBox()
        Me.nudDim2Var = New System.Windows.Forms.NumericUpDown()
        Me.nudDim1Var = New System.Windows.Forms.NumericUpDown()
        Me.lblDimVar = New System.Windows.Forms.Label()
        Me.grpGeomVar = New System.Windows.Forms.GroupBox()
        Me.rdoBothVar = New System.Windows.Forms.RadioButton()
        Me.rdoTextVar = New System.Windows.Forms.RadioButton()
        Me.rdoArrowVar = New System.Windows.Forms.RadioButton()
        Me.tbIndividuals = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboLabelInd = New System.Windows.Forms.ComboBox()
        Me.nudDim2Ind = New System.Windows.Forms.NumericUpDown()
        Me.nudDim1Ind = New System.Windows.Forms.NumericUpDown()
        Me.grpGeomInd = New System.Windows.Forms.GroupBox()
        Me.rdoBothInd = New System.Windows.Forms.RadioButton()
        Me.rdoTextInd = New System.Windows.Forms.RadioButton()
        Me.rdoPointInd = New System.Windows.Forms.RadioButton()
        Me.lblDimInd = New System.Windows.Forms.Label()
        Me.tbBiplot = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudDim2Bip = New System.Windows.Forms.NumericUpDown()
        Me.cboLabelBip = New System.Windows.Forms.ComboBox()
        Me.nudDim1Bip = New System.Windows.Forms.NumericUpDown()
        Me.grpGeomBip = New System.Windows.Forms.GroupBox()
        Me.rdoBothBip = New System.Windows.Forms.RadioButton()
        Me.rdoTextBip = New System.Windows.Forms.RadioButton()
        Me.rdoPointBip = New System.Windows.Forms.RadioButton()
        Me.lblBipInd = New System.Windows.Forms.Label()
        Me.tbBarPlot = New System.Windows.Forms.TabPage()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.ucrSelectorFactor = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblFactorVariable = New System.Windows.Forms.Label()
        Me.tbSave = New System.Windows.Forms.TabPage()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.tbRegOptions.SuspendLayout()
        Me.tbDisplay.SuspendLayout()
        Me.tbGraphics.SuspendLayout()
        Me.tbGrapOptions.SuspendLayout()
        Me.tbScreePlot.SuspendLayout()
        Me.grpGeomScree.SuspendLayout()
        Me.tbVariables.SuspendLayout()
        CType(Me.nudDim2Var, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDim1Var, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGeomVar.SuspendLayout()
        Me.tbIndividuals.SuspendLayout()
        CType(Me.nudDim2Ind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDim1Ind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGeomInd.SuspendLayout()
        Me.tbBiplot.SuspendLayout()
        CType(Me.nudDim2Bip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDim1Bip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGeomBip.SuspendLayout()
        Me.tbBarPlot.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbRegOptions
        '
        Me.tbRegOptions.Controls.Add(Me.tbDisplay)
        Me.tbRegOptions.Controls.Add(Me.tbGraphics)
        Me.tbRegOptions.Controls.Add(Me.tbSave)
        Me.tbRegOptions.Location = New System.Drawing.Point(2, 3)
        Me.tbRegOptions.Name = "tbRegOptions"
        Me.tbRegOptions.SelectedIndex = 0
        Me.tbRegOptions.Size = New System.Drawing.Size(416, 296)
        Me.tbRegOptions.TabIndex = 0
        '
        'tbDisplay
        '
        Me.tbDisplay.Controls.Add(Me.chkRotation)
        Me.tbDisplay.Controls.Add(Me.chkResiduals)
        Me.tbDisplay.Controls.Add(Me.chkEigenVectors)
        Me.tbDisplay.Controls.Add(Me.chkScores)
        Me.tbDisplay.Controls.Add(Me.chkEigenValues)
        Me.tbDisplay.Location = New System.Drawing.Point(4, 22)
        Me.tbDisplay.Name = "tbDisplay"
        Me.tbDisplay.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDisplay.Size = New System.Drawing.Size(408, 270)
        Me.tbDisplay.TabIndex = 0
        Me.tbDisplay.Tag = "Display"
        Me.tbDisplay.Text = "Display"
        Me.tbDisplay.UseVisualStyleBackColor = True
        '
        'chkRotation
        '
        Me.chkRotation.AutoSize = True
        Me.chkRotation.Location = New System.Drawing.Point(10, 107)
        Me.chkRotation.Name = "chkRotation"
        Me.chkRotation.Size = New System.Drawing.Size(66, 17)
        Me.chkRotation.TabIndex = 4
        Me.chkRotation.Tag = "Rotation"
        Me.chkRotation.Text = "Rotation"
        Me.chkRotation.UseVisualStyleBackColor = True
        '
        'chkResiduals
        '
        Me.chkResiduals.AutoSize = True
        Me.chkResiduals.Location = New System.Drawing.Point(10, 84)
        Me.chkResiduals.Name = "chkResiduals"
        Me.chkResiduals.Size = New System.Drawing.Size(72, 17)
        Me.chkResiduals.TabIndex = 3
        Me.chkResiduals.Tag = "Residuals"
        Me.chkResiduals.Text = "Residuals"
        Me.chkResiduals.UseVisualStyleBackColor = True
        '
        'chkEigenVectors
        '
        Me.chkEigenVectors.AutoSize = True
        Me.chkEigenVectors.Location = New System.Drawing.Point(10, 37)
        Me.chkEigenVectors.Name = "chkEigenVectors"
        Me.chkEigenVectors.Size = New System.Drawing.Size(88, 17)
        Me.chkEigenVectors.TabIndex = 2
        Me.chkEigenVectors.Tag = "Eigen_Vectors"
        Me.chkEigenVectors.Text = "Eigenvectors"
        Me.chkEigenVectors.UseVisualStyleBackColor = True
        '
        'chkScores
        '
        Me.chkScores.AutoSize = True
        Me.chkScores.Location = New System.Drawing.Point(10, 60)
        Me.chkScores.Name = "chkScores"
        Me.chkScores.Size = New System.Drawing.Size(59, 17)
        Me.chkScores.TabIndex = 1
        Me.chkScores.Tag = "Scores"
        Me.chkScores.Text = "Scores"
        Me.chkScores.UseVisualStyleBackColor = True
        '
        'chkEigenValues
        '
        Me.chkEigenValues.AutoSize = True
        Me.chkEigenValues.Location = New System.Drawing.Point(10, 14)
        Me.chkEigenValues.Name = "chkEigenValues"
        Me.chkEigenValues.Size = New System.Drawing.Size(84, 17)
        Me.chkEigenValues.TabIndex = 0
        Me.chkEigenValues.Tag = "Eigen_Values"
        Me.chkEigenValues.Text = "Eigenvalues"
        Me.chkEigenValues.UseVisualStyleBackColor = True
        '
        'tbGraphics
        '
        Me.tbGraphics.Controls.Add(Me.rdoBarPlot)
        Me.tbGraphics.Controls.Add(Me.rdoIndividualsPlot)
        Me.tbGraphics.Controls.Add(Me.rdoBiplot)
        Me.tbGraphics.Controls.Add(Me.rdoVariablesPlot)
        Me.tbGraphics.Controls.Add(Me.rdoScreePlot)
        Me.tbGraphics.Controls.Add(Me.tbGrapOptions)
        Me.tbGraphics.Location = New System.Drawing.Point(4, 22)
        Me.tbGraphics.Name = "tbGraphics"
        Me.tbGraphics.Padding = New System.Windows.Forms.Padding(3)
        Me.tbGraphics.Size = New System.Drawing.Size(408, 270)
        Me.tbGraphics.TabIndex = 1
        Me.tbGraphics.Tag = "Graphics"
        Me.tbGraphics.Text = "Graphics"
        Me.tbGraphics.UseVisualStyleBackColor = True
        '
        'rdoBarPlot
        '
        Me.rdoBarPlot.AutoSize = True
        Me.rdoBarPlot.Location = New System.Drawing.Point(335, 14)
        Me.rdoBarPlot.Name = "rdoBarPlot"
        Me.rdoBarPlot.Size = New System.Drawing.Size(61, 17)
        Me.rdoBarPlot.TabIndex = 12
        Me.rdoBarPlot.TabStop = True
        Me.rdoBarPlot.Tag = "Bar plot"
        Me.rdoBarPlot.Text = "Bar plot"
        Me.rdoBarPlot.UseVisualStyleBackColor = True
        '
        'rdoIndividualsPlot
        '
        Me.rdoIndividualsPlot.AutoSize = True
        Me.rdoIndividualsPlot.Location = New System.Drawing.Point(179, 14)
        Me.rdoIndividualsPlot.Name = "rdoIndividualsPlot"
        Me.rdoIndividualsPlot.Size = New System.Drawing.Size(96, 17)
        Me.rdoIndividualsPlot.TabIndex = 11
        Me.rdoIndividualsPlot.TabStop = True
        Me.rdoIndividualsPlot.Tag = "Individuals_Plot"
        Me.rdoIndividualsPlot.Text = "Individuals Plot"
        Me.rdoIndividualsPlot.UseVisualStyleBackColor = True
        '
        'rdoBiplot
        '
        Me.rdoBiplot.AutoSize = True
        Me.rdoBiplot.Location = New System.Drawing.Point(281, 14)
        Me.rdoBiplot.Name = "rdoBiplot"
        Me.rdoBiplot.Size = New System.Drawing.Size(51, 17)
        Me.rdoBiplot.TabIndex = 10
        Me.rdoBiplot.TabStop = True
        Me.rdoBiplot.Tag = "Biplot"
        Me.rdoBiplot.Text = "Biplot"
        Me.rdoBiplot.UseVisualStyleBackColor = True
        '
        'rdoVariablesPlot
        '
        Me.rdoVariablesPlot.AutoSize = True
        Me.rdoVariablesPlot.Location = New System.Drawing.Point(84, 14)
        Me.rdoVariablesPlot.Name = "rdoVariablesPlot"
        Me.rdoVariablesPlot.Size = New System.Drawing.Size(89, 17)
        Me.rdoVariablesPlot.TabIndex = 9
        Me.rdoVariablesPlot.TabStop = True
        Me.rdoVariablesPlot.Tag = "Variables_Plot"
        Me.rdoVariablesPlot.Text = "Variables Plot"
        Me.rdoVariablesPlot.UseVisualStyleBackColor = True
        '
        'rdoScreePlot
        '
        Me.rdoScreePlot.AutoSize = True
        Me.rdoScreePlot.Location = New System.Drawing.Point(10, 14)
        Me.rdoScreePlot.Name = "rdoScreePlot"
        Me.rdoScreePlot.Size = New System.Drawing.Size(74, 17)
        Me.rdoScreePlot.TabIndex = 8
        Me.rdoScreePlot.TabStop = True
        Me.rdoScreePlot.Tag = "Scree_Plot"
        Me.rdoScreePlot.Text = "Scree Plot"
        Me.rdoScreePlot.UseVisualStyleBackColor = True
        '
        'tbGrapOptions
        '
        Me.tbGrapOptions.Controls.Add(Me.tbScreePlot)
        Me.tbGrapOptions.Controls.Add(Me.tbVariables)
        Me.tbGrapOptions.Controls.Add(Me.tbIndividuals)
        Me.tbGrapOptions.Controls.Add(Me.tbBiplot)
        Me.tbGrapOptions.Controls.Add(Me.tbBarPlot)
        Me.tbGrapOptions.Location = New System.Drawing.Point(8, 37)
        Me.tbGrapOptions.Name = "tbGrapOptions"
        Me.tbGrapOptions.SelectedIndex = 0
        Me.tbGrapOptions.Size = New System.Drawing.Size(394, 224)
        Me.tbGrapOptions.TabIndex = 7
        '
        'tbScreePlot
        '
        Me.tbScreePlot.Controls.Add(Me.chkPercentageScree)
        Me.tbScreePlot.Controls.Add(Me.grpGeomScree)
        Me.tbScreePlot.Controls.Add(Me.lblChoice)
        Me.tbScreePlot.Controls.Add(Me.cboChoice)
        Me.tbScreePlot.Location = New System.Drawing.Point(4, 22)
        Me.tbScreePlot.Name = "tbScreePlot"
        Me.tbScreePlot.Padding = New System.Windows.Forms.Padding(3)
        Me.tbScreePlot.Size = New System.Drawing.Size(386, 198)
        Me.tbScreePlot.TabIndex = 0
        Me.tbScreePlot.Tag = "Scree_Plot"
        Me.tbScreePlot.Text = "Scree Plot"
        Me.tbScreePlot.UseVisualStyleBackColor = True
        '
        'chkPercentageScree
        '
        Me.chkPercentageScree.AutoSize = True
        Me.chkPercentageScree.Location = New System.Drawing.Point(9, 64)
        Me.chkPercentageScree.Name = "chkPercentageScree"
        Me.chkPercentageScree.Size = New System.Drawing.Size(124, 17)
        Me.chkPercentageScree.TabIndex = 15
        Me.chkPercentageScree.Text = "Include Percentages"
        Me.chkPercentageScree.UseVisualStyleBackColor = True
        '
        'grpGeomScree
        '
        Me.grpGeomScree.Controls.Add(Me.rdoBothScree)
        Me.grpGeomScree.Controls.Add(Me.rdoLineGeom)
        Me.grpGeomScree.Controls.Add(Me.rdoBarGeom)
        Me.grpGeomScree.Location = New System.Drawing.Point(6, 16)
        Me.grpGeomScree.Name = "grpGeomScree"
        Me.grpGeomScree.Size = New System.Drawing.Size(197, 38)
        Me.grpGeomScree.TabIndex = 9
        Me.grpGeomScree.TabStop = False
        Me.grpGeomScree.Tag = "Geom"
        Me.grpGeomScree.Text = "Geom"
        '
        'rdoBothScree
        '
        Me.rdoBothScree.AutoSize = True
        Me.rdoBothScree.Location = New System.Drawing.Point(134, 16)
        Me.rdoBothScree.Name = "rdoBothScree"
        Me.rdoBothScree.Size = New System.Drawing.Size(47, 17)
        Me.rdoBothScree.TabIndex = 2
        Me.rdoBothScree.TabStop = True
        Me.rdoBothScree.Text = "Both"
        Me.rdoBothScree.UseVisualStyleBackColor = True
        '
        'rdoLineGeom
        '
        Me.rdoLineGeom.AutoSize = True
        Me.rdoLineGeom.Location = New System.Drawing.Point(69, 16)
        Me.rdoLineGeom.Name = "rdoLineGeom"
        Me.rdoLineGeom.Size = New System.Drawing.Size(45, 17)
        Me.rdoLineGeom.TabIndex = 1
        Me.rdoLineGeom.TabStop = True
        Me.rdoLineGeom.Text = "Line"
        Me.rdoLineGeom.UseVisualStyleBackColor = True
        '
        'rdoBarGeom
        '
        Me.rdoBarGeom.AutoSize = True
        Me.rdoBarGeom.Location = New System.Drawing.Point(3, 16)
        Me.rdoBarGeom.Name = "rdoBarGeom"
        Me.rdoBarGeom.Size = New System.Drawing.Size(41, 17)
        Me.rdoBarGeom.TabIndex = 0
        Me.rdoBarGeom.TabStop = True
        Me.rdoBarGeom.Text = "Bar"
        Me.rdoBarGeom.UseVisualStyleBackColor = True
        '
        'lblChoice
        '
        Me.lblChoice.AutoSize = True
        Me.lblChoice.Location = New System.Drawing.Point(8, 92)
        Me.lblChoice.Name = "lblChoice"
        Me.lblChoice.Size = New System.Drawing.Size(43, 13)
        Me.lblChoice.TabIndex = 8
        Me.lblChoice.Tag = "Choice"
        Me.lblChoice.Text = "Choice:"
        '
        'cboChoice
        '
        Me.cboChoice.FormattingEnabled = True
        Me.cboChoice.Items.AddRange(New Object() {"variance", "eigenvalue"})
        Me.cboChoice.Location = New System.Drawing.Point(53, 89)
        Me.cboChoice.Name = "cboChoice"
        Me.cboChoice.Size = New System.Drawing.Size(150, 21)
        Me.cboChoice.TabIndex = 7
        '
        'tbVariables
        '
        Me.tbVariables.Controls.Add(Me.Label1)
        Me.tbVariables.Controls.Add(Me.cboLabelVar)
        Me.tbVariables.Controls.Add(Me.nudDim2Var)
        Me.tbVariables.Controls.Add(Me.nudDim1Var)
        Me.tbVariables.Controls.Add(Me.lblDimVar)
        Me.tbVariables.Controls.Add(Me.grpGeomVar)
        Me.tbVariables.Location = New System.Drawing.Point(4, 22)
        Me.tbVariables.Name = "tbVariables"
        Me.tbVariables.Padding = New System.Windows.Forms.Padding(3)
        Me.tbVariables.Size = New System.Drawing.Size(386, 198)
        Me.tbVariables.TabIndex = 1
        Me.tbVariables.Tag = "Variables"
        Me.tbVariables.Text = "Variables"
        Me.tbVariables.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Label:"
        '
        'cboLabelVar
        '
        Me.cboLabelVar.FormattingEnabled = True
        Me.cboLabelVar.Items.AddRange(New Object() {"all", "ind.sup", "quali", "quanti.sup", "var", "ind", "none"})
        Me.cboLabelVar.Location = New System.Drawing.Point(53, 89)
        Me.cboLabelVar.Name = "cboLabelVar"
        Me.cboLabelVar.Size = New System.Drawing.Size(150, 21)
        Me.cboLabelVar.TabIndex = 29
        '
        'nudDim2Var
        '
        Me.nudDim2Var.Location = New System.Drawing.Point(161, 63)
        Me.nudDim2Var.Name = "nudDim2Var"
        Me.nudDim2Var.Size = New System.Drawing.Size(41, 20)
        Me.nudDim2Var.TabIndex = 17
        '
        'nudDim1Var
        '
        Me.nudDim1Var.Location = New System.Drawing.Point(110, 63)
        Me.nudDim1Var.Name = "nudDim1Var"
        Me.nudDim1Var.Size = New System.Drawing.Size(41, 20)
        Me.nudDim1Var.TabIndex = 16
        '
        'lblDimVar
        '
        Me.lblDimVar.AutoSize = True
        Me.lblDimVar.Location = New System.Drawing.Point(7, 66)
        Me.lblDimVar.Name = "lblDimVar"
        Me.lblDimVar.Size = New System.Drawing.Size(97, 13)
        Me.lblDimVar.TabIndex = 15
        Me.lblDimVar.Text = "Dimensions to Plot:"
        '
        'grpGeomVar
        '
        Me.grpGeomVar.Controls.Add(Me.rdoBothVar)
        Me.grpGeomVar.Controls.Add(Me.rdoTextVar)
        Me.grpGeomVar.Controls.Add(Me.rdoArrowVar)
        Me.grpGeomVar.Location = New System.Drawing.Point(6, 16)
        Me.grpGeomVar.Name = "grpGeomVar"
        Me.grpGeomVar.Size = New System.Drawing.Size(197, 38)
        Me.grpGeomVar.TabIndex = 13
        Me.grpGeomVar.TabStop = False
        Me.grpGeomVar.Tag = "Geom"
        Me.grpGeomVar.Text = "Geom"
        '
        'rdoBothVar
        '
        Me.rdoBothVar.AutoSize = True
        Me.rdoBothVar.Location = New System.Drawing.Point(134, 16)
        Me.rdoBothVar.Name = "rdoBothVar"
        Me.rdoBothVar.Size = New System.Drawing.Size(47, 17)
        Me.rdoBothVar.TabIndex = 2
        Me.rdoBothVar.TabStop = True
        Me.rdoBothVar.Text = "Both"
        Me.rdoBothVar.UseVisualStyleBackColor = True
        '
        'rdoTextVar
        '
        Me.rdoTextVar.AutoSize = True
        Me.rdoTextVar.Location = New System.Drawing.Point(69, 16)
        Me.rdoTextVar.Name = "rdoTextVar"
        Me.rdoTextVar.Size = New System.Drawing.Size(46, 17)
        Me.rdoTextVar.TabIndex = 1
        Me.rdoTextVar.TabStop = True
        Me.rdoTextVar.Text = "Text"
        Me.rdoTextVar.UseVisualStyleBackColor = True
        '
        'rdoArrowVar
        '
        Me.rdoArrowVar.AutoSize = True
        Me.rdoArrowVar.Location = New System.Drawing.Point(3, 16)
        Me.rdoArrowVar.Name = "rdoArrowVar"
        Me.rdoArrowVar.Size = New System.Drawing.Size(52, 17)
        Me.rdoArrowVar.TabIndex = 0
        Me.rdoArrowVar.TabStop = True
        Me.rdoArrowVar.Text = "Arrow"
        Me.rdoArrowVar.UseVisualStyleBackColor = True
        '
        'tbIndividuals
        '
        Me.tbIndividuals.Controls.Add(Me.Label2)
        Me.tbIndividuals.Controls.Add(Me.cboLabelInd)
        Me.tbIndividuals.Controls.Add(Me.nudDim2Ind)
        Me.tbIndividuals.Controls.Add(Me.nudDim1Ind)
        Me.tbIndividuals.Controls.Add(Me.grpGeomInd)
        Me.tbIndividuals.Controls.Add(Me.lblDimInd)
        Me.tbIndividuals.Location = New System.Drawing.Point(4, 22)
        Me.tbIndividuals.Name = "tbIndividuals"
        Me.tbIndividuals.Padding = New System.Windows.Forms.Padding(3)
        Me.tbIndividuals.Size = New System.Drawing.Size(386, 198)
        Me.tbIndividuals.TabIndex = 2
        Me.tbIndividuals.Tag = "Individuals"
        Me.tbIndividuals.Text = "Individuals"
        Me.tbIndividuals.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Label:"
        '
        'cboLabelInd
        '
        Me.cboLabelInd.FormattingEnabled = True
        Me.cboLabelInd.Items.AddRange(New Object() {"all", "ind.sup", "quali", "quanti.sup", "var", "ind", "none"})
        Me.cboLabelInd.Location = New System.Drawing.Point(53, 89)
        Me.cboLabelInd.Name = "cboLabelInd"
        Me.cboLabelInd.Size = New System.Drawing.Size(150, 21)
        Me.cboLabelInd.TabIndex = 30
        '
        'nudDim2Ind
        '
        Me.nudDim2Ind.Location = New System.Drawing.Point(161, 63)
        Me.nudDim2Ind.Name = "nudDim2Ind"
        Me.nudDim2Ind.Size = New System.Drawing.Size(41, 20)
        Me.nudDim2Ind.TabIndex = 20
        '
        'nudDim1Ind
        '
        Me.nudDim1Ind.Location = New System.Drawing.Point(110, 63)
        Me.nudDim1Ind.Name = "nudDim1Ind"
        Me.nudDim1Ind.Size = New System.Drawing.Size(41, 20)
        Me.nudDim1Ind.TabIndex = 19
        '
        'grpGeomInd
        '
        Me.grpGeomInd.Controls.Add(Me.rdoBothInd)
        Me.grpGeomInd.Controls.Add(Me.rdoTextInd)
        Me.grpGeomInd.Controls.Add(Me.rdoPointInd)
        Me.grpGeomInd.Location = New System.Drawing.Point(6, 16)
        Me.grpGeomInd.Name = "grpGeomInd"
        Me.grpGeomInd.Size = New System.Drawing.Size(197, 38)
        Me.grpGeomInd.TabIndex = 13
        Me.grpGeomInd.TabStop = False
        Me.grpGeomInd.Tag = "Geom"
        Me.grpGeomInd.Text = "Geom"
        '
        'rdoBothInd
        '
        Me.rdoBothInd.AutoSize = True
        Me.rdoBothInd.Location = New System.Drawing.Point(134, 16)
        Me.rdoBothInd.Name = "rdoBothInd"
        Me.rdoBothInd.Size = New System.Drawing.Size(47, 17)
        Me.rdoBothInd.TabIndex = 2
        Me.rdoBothInd.TabStop = True
        Me.rdoBothInd.Text = "Both"
        Me.rdoBothInd.UseVisualStyleBackColor = True
        '
        'rdoTextInd
        '
        Me.rdoTextInd.AutoSize = True
        Me.rdoTextInd.Location = New System.Drawing.Point(69, 16)
        Me.rdoTextInd.Name = "rdoTextInd"
        Me.rdoTextInd.Size = New System.Drawing.Size(46, 17)
        Me.rdoTextInd.TabIndex = 1
        Me.rdoTextInd.TabStop = True
        Me.rdoTextInd.Text = "Text"
        Me.rdoTextInd.UseVisualStyleBackColor = True
        '
        'rdoPointInd
        '
        Me.rdoPointInd.AutoSize = True
        Me.rdoPointInd.Location = New System.Drawing.Point(3, 16)
        Me.rdoPointInd.Name = "rdoPointInd"
        Me.rdoPointInd.Size = New System.Drawing.Size(49, 17)
        Me.rdoPointInd.TabIndex = 0
        Me.rdoPointInd.TabStop = True
        Me.rdoPointInd.Text = "Point"
        Me.rdoPointInd.UseVisualStyleBackColor = True
        '
        'lblDimInd
        '
        Me.lblDimInd.AutoSize = True
        Me.lblDimInd.Location = New System.Drawing.Point(7, 66)
        Me.lblDimInd.Name = "lblDimInd"
        Me.lblDimInd.Size = New System.Drawing.Size(97, 13)
        Me.lblDimInd.TabIndex = 18
        Me.lblDimInd.Text = "Dimensions to Plot:"
        '
        'tbBiplot
        '
        Me.tbBiplot.Controls.Add(Me.Label3)
        Me.tbBiplot.Controls.Add(Me.nudDim2Bip)
        Me.tbBiplot.Controls.Add(Me.cboLabelBip)
        Me.tbBiplot.Controls.Add(Me.nudDim1Bip)
        Me.tbBiplot.Controls.Add(Me.grpGeomBip)
        Me.tbBiplot.Controls.Add(Me.lblBipInd)
        Me.tbBiplot.Location = New System.Drawing.Point(4, 22)
        Me.tbBiplot.Name = "tbBiplot"
        Me.tbBiplot.Padding = New System.Windows.Forms.Padding(3)
        Me.tbBiplot.Size = New System.Drawing.Size(386, 198)
        Me.tbBiplot.TabIndex = 3
        Me.tbBiplot.Tag = "Biplot"
        Me.tbBiplot.Text = "Biplot"
        Me.tbBiplot.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Label:"
        '
        'nudDim2Bip
        '
        Me.nudDim2Bip.Location = New System.Drawing.Point(161, 63)
        Me.nudDim2Bip.Name = "nudDim2Bip"
        Me.nudDim2Bip.Size = New System.Drawing.Size(41, 20)
        Me.nudDim2Bip.TabIndex = 23
        '
        'cboLabelBip
        '
        Me.cboLabelBip.FormattingEnabled = True
        Me.cboLabelBip.Items.AddRange(New Object() {"all", "ind.sup", "quali", "quanti.sup", "var", "ind", "none"})
        Me.cboLabelBip.Location = New System.Drawing.Point(53, 89)
        Me.cboLabelBip.Name = "cboLabelBip"
        Me.cboLabelBip.Size = New System.Drawing.Size(150, 21)
        Me.cboLabelBip.TabIndex = 32
        '
        'nudDim1Bip
        '
        Me.nudDim1Bip.Location = New System.Drawing.Point(110, 63)
        Me.nudDim1Bip.Name = "nudDim1Bip"
        Me.nudDim1Bip.Size = New System.Drawing.Size(41, 20)
        Me.nudDim1Bip.TabIndex = 22
        '
        'grpGeomBip
        '
        Me.grpGeomBip.Controls.Add(Me.rdoBothBip)
        Me.grpGeomBip.Controls.Add(Me.rdoTextBip)
        Me.grpGeomBip.Controls.Add(Me.rdoPointBip)
        Me.grpGeomBip.Location = New System.Drawing.Point(6, 16)
        Me.grpGeomBip.Name = "grpGeomBip"
        Me.grpGeomBip.Size = New System.Drawing.Size(197, 38)
        Me.grpGeomBip.TabIndex = 14
        Me.grpGeomBip.TabStop = False
        Me.grpGeomBip.Tag = "Geom"
        Me.grpGeomBip.Text = "Geom"
        '
        'rdoBothBip
        '
        Me.rdoBothBip.AutoSize = True
        Me.rdoBothBip.Location = New System.Drawing.Point(134, 16)
        Me.rdoBothBip.Name = "rdoBothBip"
        Me.rdoBothBip.Size = New System.Drawing.Size(47, 17)
        Me.rdoBothBip.TabIndex = 2
        Me.rdoBothBip.TabStop = True
        Me.rdoBothBip.Text = "Both"
        Me.rdoBothBip.UseVisualStyleBackColor = True
        '
        'rdoTextBip
        '
        Me.rdoTextBip.AutoSize = True
        Me.rdoTextBip.Location = New System.Drawing.Point(69, 16)
        Me.rdoTextBip.Name = "rdoTextBip"
        Me.rdoTextBip.Size = New System.Drawing.Size(46, 17)
        Me.rdoTextBip.TabIndex = 1
        Me.rdoTextBip.TabStop = True
        Me.rdoTextBip.Text = "Text"
        Me.rdoTextBip.UseVisualStyleBackColor = True
        '
        'rdoPointBip
        '
        Me.rdoPointBip.AutoSize = True
        Me.rdoPointBip.Location = New System.Drawing.Point(3, 16)
        Me.rdoPointBip.Name = "rdoPointBip"
        Me.rdoPointBip.Size = New System.Drawing.Size(49, 17)
        Me.rdoPointBip.TabIndex = 0
        Me.rdoPointBip.TabStop = True
        Me.rdoPointBip.Text = "Point"
        Me.rdoPointBip.UseVisualStyleBackColor = True
        '
        'lblBipInd
        '
        Me.lblBipInd.AutoSize = True
        Me.lblBipInd.Location = New System.Drawing.Point(7, 66)
        Me.lblBipInd.Name = "lblBipInd"
        Me.lblBipInd.Size = New System.Drawing.Size(97, 13)
        Me.lblBipInd.TabIndex = 21
        Me.lblBipInd.Text = "Dimensions to Plot:"
        '
        'tbBarPlot
        '
        Me.tbBarPlot.Controls.Add(Me.ucrReceiverFactor)
        Me.tbBarPlot.Controls.Add(Me.ucrSelectorFactor)
        Me.tbBarPlot.Controls.Add(Me.lblFactorVariable)
        Me.tbBarPlot.Location = New System.Drawing.Point(4, 22)
        Me.tbBarPlot.Name = "tbBarPlot"
        Me.tbBarPlot.Padding = New System.Windows.Forms.Padding(3)
        Me.tbBarPlot.Size = New System.Drawing.Size(386, 198)
        Me.tbBarPlot.TabIndex = 4
        Me.tbBarPlot.Tag = "Bar_Plot"
        Me.tbBarPlot.Text = "Bar Plot"
        Me.tbBarPlot.UseVisualStyleBackColor = True
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(255, 44)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFactor.TabIndex = 5
        '
        'ucrSelectorFactor
        '
        Me.ucrSelectorFactor.bShowHiddenColumns = False
        Me.ucrSelectorFactor.bUseCurrentFilter = True
        Me.ucrSelectorFactor.Location = New System.Drawing.Point(12, 8)
        Me.ucrSelectorFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFactor.Name = "ucrSelectorFactor"
        Me.ucrSelectorFactor.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorFactor.TabIndex = 3
        '
        'lblFactorVariable
        '
        Me.lblFactorVariable.AutoSize = True
        Me.lblFactorVariable.Location = New System.Drawing.Point(252, 27)
        Me.lblFactorVariable.Name = "lblFactorVariable"
        Me.lblFactorVariable.Size = New System.Drawing.Size(81, 13)
        Me.lblFactorVariable.TabIndex = 2
        Me.lblFactorVariable.Tag = "Factor_Variable"
        Me.lblFactorVariable.Text = "Factor Variable:"
        '
        'tbSave
        '
        Me.tbSave.Location = New System.Drawing.Point(4, 22)
        Me.tbSave.Name = "tbSave"
        Me.tbSave.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSave.Size = New System.Drawing.Size(408, 270)
        Me.tbSave.TabIndex = 2
        Me.tbSave.Tag = "Save"
        Me.tbSave.Text = "Save"
        Me.tbSave.UseVisualStyleBackColor = True
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.Location = New System.Drawing.Point(139, 305)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(142, 30)
        Me.ucrSdgButtons.TabIndex = 0
        '
        'sdgPrincipalComponentAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 339)
        Me.Controls.Add(Me.tbRegOptions)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgPrincipalComponentAnalysis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "PCA_Options"
        Me.Text = "PCA Options"
        Me.tbRegOptions.ResumeLayout(False)
        Me.tbDisplay.ResumeLayout(False)
        Me.tbDisplay.PerformLayout()
        Me.tbGraphics.ResumeLayout(False)
        Me.tbGraphics.PerformLayout()
        Me.tbGrapOptions.ResumeLayout(False)
        Me.tbScreePlot.ResumeLayout(False)
        Me.tbScreePlot.PerformLayout()
        Me.grpGeomScree.ResumeLayout(False)
        Me.grpGeomScree.PerformLayout()
        Me.tbVariables.ResumeLayout(False)
        Me.tbVariables.PerformLayout()
        CType(Me.nudDim2Var, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDim1Var, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGeomVar.ResumeLayout(False)
        Me.grpGeomVar.PerformLayout()
        Me.tbIndividuals.ResumeLayout(False)
        Me.tbIndividuals.PerformLayout()
        CType(Me.nudDim2Ind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDim1Ind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGeomInd.ResumeLayout(False)
        Me.grpGeomInd.PerformLayout()
        Me.tbBiplot.ResumeLayout(False)
        Me.tbBiplot.PerformLayout()
        CType(Me.nudDim2Bip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDim1Bip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGeomBip.ResumeLayout(False)
        Me.grpGeomBip.PerformLayout()
        Me.tbBarPlot.ResumeLayout(False)
        Me.tbBarPlot.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents tbRegOptions As TabControl
    Friend WithEvents tbDisplay As TabPage
    Friend WithEvents tbGraphics As TabPage
    Friend WithEvents chkEigenValues As CheckBox
    Friend WithEvents chkEigenVectors As CheckBox
    Friend WithEvents chkScores As CheckBox
    Friend WithEvents chkResiduals As CheckBox
    Friend WithEvents tbSave As TabPage
    Friend WithEvents rdoIndividualsPlot As RadioButton
    Friend WithEvents rdoBiplot As RadioButton
    Friend WithEvents rdoVariablesPlot As RadioButton
    Friend WithEvents rdoScreePlot As RadioButton
    Friend WithEvents tbGrapOptions As TabControl
    Friend WithEvents tbScreePlot As TabPage
    Friend WithEvents tbVariables As TabPage
    Friend WithEvents tbIndividuals As TabPage
    Friend WithEvents tbBiplot As TabPage
    Friend WithEvents rdoBarPlot As RadioButton
    Friend WithEvents tbBarPlot As TabPage
    Friend WithEvents chkRotation As CheckBox
    Friend WithEvents ucrSelectorFactor As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFactorVariable As Label
    Friend WithEvents grpGeomScree As GroupBox
    Friend WithEvents rdoBothScree As RadioButton
    Friend WithEvents rdoLineGeom As RadioButton
    Friend WithEvents rdoBarGeom As RadioButton
    Friend WithEvents lblChoice As Label
    Friend WithEvents cboChoice As ComboBox
    Friend WithEvents grpGeomVar As GroupBox
    Friend WithEvents rdoBothVar As RadioButton
    Friend WithEvents rdoTextVar As RadioButton
    Friend WithEvents rdoArrowVar As RadioButton
    Friend WithEvents grpGeomInd As GroupBox
    Friend WithEvents rdoBothInd As RadioButton
    Friend WithEvents rdoTextInd As RadioButton
    Friend WithEvents rdoPointInd As RadioButton
    Friend WithEvents grpGeomBip As GroupBox
    Friend WithEvents rdoBothBip As RadioButton
    Friend WithEvents rdoTextBip As RadioButton
    Friend WithEvents rdoPointBip As RadioButton
    Friend WithEvents nudDim2Var As NumericUpDown
    Friend WithEvents nudDim1Var As NumericUpDown
    Friend WithEvents lblDimVar As Label
    Friend WithEvents nudDim2Ind As NumericUpDown
    Friend WithEvents nudDim1Ind As NumericUpDown
    Friend WithEvents lblDimInd As Label
    Friend WithEvents nudDim2Bip As NumericUpDown
    Friend WithEvents nudDim1Bip As NumericUpDown
    Friend WithEvents lblBipInd As Label
    Friend WithEvents chkPercentageScree As CheckBox
    Friend WithEvents cboLabelVar As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboLabelInd As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboLabelBip As ComboBox
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
End Class