<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgDescribe
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
        Me.chkNonMissing = New System.Windows.Forms.CheckBox()
        Me.chkNMissing = New System.Windows.Forms.CheckBox()
        Me.chkNTotal = New System.Windows.Forms.CheckBox()
        Me.chkMode = New System.Windows.Forms.CheckBox()
        Me.grpPecents = New System.Windows.Forms.GroupBox()
        Me.ucrInputProportions = New instat.ucrInputComboBox()
        Me.ucrInputInequality = New instat.ucrInputComboBox()
        Me.ucrInputPercentiles = New instat.ucrInputComboBox()
        Me.chkPercentiles = New System.Windows.Forms.CheckBox()
        Me.chkProportions = New System.Windows.Forms.CheckBox()
        Me.chkResults = New System.Windows.Forms.CheckBox()
        Me.grpPrecision = New System.Windows.Forms.GroupBox()
        Me.ucrInputUnits = New instat.ucrInputComboBox()
        Me.ucrInputPrecision = New instat.ucrInputComboBox()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblPrecision = New System.Windows.Forms.Label()
        Me.rdoSignificantFigures = New System.Windows.Forms.RadioButton()
        Me.rdoDecimals = New System.Windows.Forms.RadioButton()
        Me.grpAllTypes = New System.Windows.Forms.GroupBox()
        Me.tbDescribe = New System.Windows.Forms.TabControl()
        Me.tbAllTypes = New System.Windows.Forms.TabPage()
        Me.tbNotOrderedFactor = New System.Windows.Forms.TabPage()
        Me.grpNotOrderedFactor = New System.Windows.Forms.GroupBox()
        Me.chkMinimum = New System.Windows.Forms.CheckBox()
        Me.chkMaximum = New System.Windows.Forms.CheckBox()
        Me.tbNumeric = New System.Windows.Forms.TabPage()
        Me.grpNumeric = New System.Windows.Forms.GroupBox()
        Me.chkSum = New System.Windows.Forms.CheckBox()
        Me.chkMean = New System.Windows.Forms.CheckBox()
        Me.chkRange = New System.Windows.Forms.CheckBox()
        Me.chkVariance = New System.Windows.Forms.CheckBox()
        Me.chkStdDev = New System.Windows.Forms.CheckBox()
        Me.chkQuartiles = New System.Windows.Forms.CheckBox()
        Me.chkMedian = New System.Windows.Forms.CheckBox()
        Me.tbOthers = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox21 = New System.Windows.Forms.CheckBox()
        Me.CheckBox23 = New System.Windows.Forms.CheckBox()
        Me.CheckBox25 = New System.Windows.Forms.CheckBox()
        Me.chkSumSquares = New System.Windows.Forms.CheckBox()
        Me.chkHigherMoments = New System.Windows.Forms.CheckBox()
        Me.UcrButtonsSubdialogue1 = New instat.ucrButtonsSubdialogue()
        Me.grpPecents.SuspendLayout()
        Me.grpPrecision.SuspendLayout()
        Me.grpAllTypes.SuspendLayout()
        Me.tbDescribe.SuspendLayout()
        Me.tbAllTypes.SuspendLayout()
        Me.tbNotOrderedFactor.SuspendLayout()
        Me.grpNotOrderedFactor.SuspendLayout()
        Me.tbNumeric.SuspendLayout()
        Me.grpNumeric.SuspendLayout()
        Me.tbOthers.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkNonMissing
        '
        Me.chkNonMissing.AutoSize = True
        Me.chkNonMissing.Location = New System.Drawing.Point(13, 14)
        Me.chkNonMissing.Name = "chkNonMissing"
        Me.chkNonMissing.Size = New System.Drawing.Size(95, 17)
        Me.chkNonMissing.TabIndex = 1
        Me.chkNonMissing.Tag = "N_Non_Missing"
        Me.chkNonMissing.Text = "N Non Missing"
        Me.chkNonMissing.UseVisualStyleBackColor = True
        '
        'chkNMissing
        '
        Me.chkNMissing.AutoSize = True
        Me.chkNMissing.Location = New System.Drawing.Point(13, 34)
        Me.chkNMissing.Name = "chkNMissing"
        Me.chkNMissing.Size = New System.Drawing.Size(72, 17)
        Me.chkNMissing.TabIndex = 2
        Me.chkNMissing.Tag = "N_Missing"
        Me.chkNMissing.Text = "N Missing"
        Me.chkNMissing.UseVisualStyleBackColor = True
        '
        'chkNTotal
        '
        Me.chkNTotal.AutoSize = True
        Me.chkNTotal.Location = New System.Drawing.Point(13, 54)
        Me.chkNTotal.Name = "chkNTotal"
        Me.chkNTotal.Size = New System.Drawing.Size(61, 17)
        Me.chkNTotal.TabIndex = 3
        Me.chkNTotal.Tag = "N_Total"
        Me.chkNTotal.Text = "N Total"
        Me.chkNTotal.UseVisualStyleBackColor = True
        '
        'chkMode
        '
        Me.chkMode.AutoSize = True
        Me.chkMode.Location = New System.Drawing.Point(13, 74)
        Me.chkMode.Name = "chkMode"
        Me.chkMode.Size = New System.Drawing.Size(53, 17)
        Me.chkMode.TabIndex = 4
        Me.chkMode.Tag = "Mode"
        Me.chkMode.Text = "Mode"
        Me.chkMode.UseVisualStyleBackColor = True
        '
        'grpPecents
        '
        Me.grpPecents.Controls.Add(Me.ucrInputProportions)
        Me.grpPecents.Controls.Add(Me.ucrInputInequality)
        Me.grpPecents.Controls.Add(Me.ucrInputPercentiles)
        Me.grpPecents.Controls.Add(Me.chkPercentiles)
        Me.grpPecents.Controls.Add(Me.chkProportions)
        Me.grpPecents.Controls.Add(Me.chkResults)
        Me.grpPecents.Enabled = False
        Me.grpPecents.Location = New System.Drawing.Point(9, 88)
        Me.grpPecents.Name = "grpPecents"
        Me.grpPecents.Size = New System.Drawing.Size(267, 88)
        Me.grpPecents.TabIndex = 16
        Me.grpPecents.TabStop = False
        '
        'ucrInputProportions
        '
        Me.ucrInputProportions.Enabled = False
        Me.ucrInputProportions.IsReadOnly = False
        Me.ucrInputProportions.Location = New System.Drawing.Point(118, 53)
        Me.ucrInputProportions.Name = "ucrInputProportions"
        Me.ucrInputProportions.Size = New System.Drawing.Size(50, 21)
        Me.ucrInputProportions.TabIndex = 23
        '
        'ucrInputInequality
        '
        Me.ucrInputInequality.Enabled = False
        Me.ucrInputInequality.IsReadOnly = False
        Me.ucrInputInequality.Location = New System.Drawing.Point(85, 53)
        Me.ucrInputInequality.Name = "ucrInputInequality"
        Me.ucrInputInequality.Size = New System.Drawing.Size(28, 21)
        Me.ucrInputInequality.TabIndex = 22
        '
        'ucrInputPercentiles
        '
        Me.ucrInputPercentiles.Enabled = False
        Me.ucrInputPercentiles.IsReadOnly = False
        Me.ucrInputPercentiles.Location = New System.Drawing.Point(88, 16)
        Me.ucrInputPercentiles.Name = "ucrInputPercentiles"
        Me.ucrInputPercentiles.Size = New System.Drawing.Size(84, 21)
        Me.ucrInputPercentiles.TabIndex = 21
        '
        'chkPercentiles
        '
        Me.chkPercentiles.AutoSize = True
        Me.chkPercentiles.Enabled = False
        Me.chkPercentiles.Location = New System.Drawing.Point(7, 19)
        Me.chkPercentiles.Name = "chkPercentiles"
        Me.chkPercentiles.Size = New System.Drawing.Size(78, 17)
        Me.chkPercentiles.TabIndex = 18
        Me.chkPercentiles.Tag = "Percentiles"
        Me.chkPercentiles.Text = "Percentiles"
        Me.chkPercentiles.UseVisualStyleBackColor = True
        '
        'chkProportions
        '
        Me.chkProportions.AutoSize = True
        Me.chkProportions.Enabled = False
        Me.chkProportions.Location = New System.Drawing.Point(7, 53)
        Me.chkProportions.Name = "chkProportions"
        Me.chkProportions.Size = New System.Drawing.Size(79, 17)
        Me.chkProportions.TabIndex = 19
        Me.chkProportions.Tag = "Proportions"
        Me.chkProportions.Text = "Proportions"
        Me.chkProportions.UseVisualStyleBackColor = True
        '
        'chkResults
        '
        Me.chkResults.AutoSize = True
        Me.chkResults.Enabled = False
        Me.chkResults.Location = New System.Drawing.Point(180, 57)
        Me.chkResults.Name = "chkResults"
        Me.chkResults.Size = New System.Drawing.Size(86, 17)
        Me.chkResults.TabIndex = 20
        Me.chkResults.Tag = "Results_as_%"
        Me.chkResults.Text = "Results as %"
        Me.chkResults.UseVisualStyleBackColor = True
        '
        'grpPrecision
        '
        Me.grpPrecision.Controls.Add(Me.ucrInputUnits)
        Me.grpPrecision.Controls.Add(Me.ucrInputPrecision)
        Me.grpPrecision.Controls.Add(Me.lblUnits)
        Me.grpPrecision.Controls.Add(Me.lblPrecision)
        Me.grpPrecision.Controls.Add(Me.rdoSignificantFigures)
        Me.grpPrecision.Controls.Add(Me.rdoDecimals)
        Me.grpPrecision.Location = New System.Drawing.Point(26, 216)
        Me.grpPrecision.Name = "grpPrecision"
        Me.grpPrecision.Size = New System.Drawing.Size(282, 67)
        Me.grpPrecision.TabIndex = 17
        Me.grpPrecision.TabStop = False
        '
        'ucrInputUnits
        '
        Me.ucrInputUnits.Enabled = False
        Me.ucrInputUnits.IsReadOnly = False
        Me.ucrInputUnits.Location = New System.Drawing.Point(43, 38)
        Me.ucrInputUnits.Name = "ucrInputUnits"
        Me.ucrInputUnits.Size = New System.Drawing.Size(43, 21)
        Me.ucrInputUnits.TabIndex = 23
        '
        'ucrInputPrecision
        '
        Me.ucrInputPrecision.Enabled = False
        Me.ucrInputPrecision.IsReadOnly = False
        Me.ucrInputPrecision.Location = New System.Drawing.Point(60, 15)
        Me.ucrInputPrecision.Name = "ucrInputPrecision"
        Me.ucrInputPrecision.Size = New System.Drawing.Size(58, 21)
        Me.ucrInputPrecision.TabIndex = 22
        '
        'lblUnits
        '
        Me.lblUnits.AccessibleDescription = ""
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Enabled = False
        Me.lblUnits.Location = New System.Drawing.Point(6, 41)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(31, 13)
        Me.lblUnits.TabIndex = 3
        Me.lblUnits.Tag = "Units"
        Me.lblUnits.Text = "Units"
        '
        'lblPrecision
        '
        Me.lblPrecision.AccessibleDescription = "v"
        Me.lblPrecision.AutoSize = True
        Me.lblPrecision.Enabled = False
        Me.lblPrecision.Location = New System.Drawing.Point(6, 16)
        Me.lblPrecision.Name = "lblPrecision"
        Me.lblPrecision.Size = New System.Drawing.Size(50, 13)
        Me.lblPrecision.TabIndex = 2
        Me.lblPrecision.Tag = "Precision"
        Me.lblPrecision.Text = "Precision"
        '
        'rdoSignificantFigures
        '
        Me.rdoSignificantFigures.AutoSize = True
        Me.rdoSignificantFigures.Enabled = False
        Me.rdoSignificantFigures.Location = New System.Drawing.Point(196, 16)
        Me.rdoSignificantFigures.Name = "rdoSignificantFigures"
        Me.rdoSignificantFigures.Size = New System.Drawing.Size(80, 17)
        Me.rdoSignificantFigures.TabIndex = 1
        Me.rdoSignificantFigures.TabStop = True
        Me.rdoSignificantFigures.Tag = "Sig_Figures"
        Me.rdoSignificantFigures.Text = "Sig. Figures"
        Me.rdoSignificantFigures.UseVisualStyleBackColor = True
        '
        'rdoDecimals
        '
        Me.rdoDecimals.AutoSize = True
        Me.rdoDecimals.Enabled = False
        Me.rdoDecimals.Location = New System.Drawing.Point(129, 16)
        Me.rdoDecimals.Name = "rdoDecimals"
        Me.rdoDecimals.Size = New System.Drawing.Size(68, 17)
        Me.rdoDecimals.TabIndex = 0
        Me.rdoDecimals.TabStop = True
        Me.rdoDecimals.Tag = "Decimals"
        Me.rdoDecimals.Text = "Decimals"
        Me.rdoDecimals.UseVisualStyleBackColor = True
        '
        'grpAllTypes
        '
        Me.grpAllTypes.Controls.Add(Me.chkMode)
        Me.grpAllTypes.Controls.Add(Me.chkNonMissing)
        Me.grpAllTypes.Controls.Add(Me.chkNMissing)
        Me.grpAllTypes.Controls.Add(Me.chkNTotal)
        Me.grpAllTypes.Location = New System.Drawing.Point(8, 3)
        Me.grpAllTypes.Name = "grpAllTypes"
        Me.grpAllTypes.Size = New System.Drawing.Size(126, 108)
        Me.grpAllTypes.TabIndex = 18
        Me.grpAllTypes.TabStop = False
        '
        'tbDescribe
        '
        Me.tbDescribe.Controls.Add(Me.tbAllTypes)
        Me.tbDescribe.Controls.Add(Me.tbNotOrderedFactor)
        Me.tbDescribe.Controls.Add(Me.tbNumeric)
        Me.tbDescribe.Controls.Add(Me.tbOthers)
        Me.tbDescribe.Location = New System.Drawing.Point(20, 4)
        Me.tbDescribe.Name = "tbDescribe"
        Me.tbDescribe.SelectedIndex = 0
        Me.tbDescribe.Size = New System.Drawing.Size(296, 209)
        Me.tbDescribe.TabIndex = 19
        '
        'tbAllTypes
        '
        Me.tbAllTypes.Controls.Add(Me.grpAllTypes)
        Me.tbAllTypes.Location = New System.Drawing.Point(4, 22)
        Me.tbAllTypes.Name = "tbAllTypes"
        Me.tbAllTypes.Padding = New System.Windows.Forms.Padding(3)
        Me.tbAllTypes.Size = New System.Drawing.Size(288, 183)
        Me.tbAllTypes.TabIndex = 0
        Me.tbAllTypes.Tag = "All_Types"
        Me.tbAllTypes.Text = "All Types"
        Me.tbAllTypes.UseVisualStyleBackColor = True
        '
        'tbNotOrderedFactor
        '
        Me.tbNotOrderedFactor.Controls.Add(Me.grpNotOrderedFactor)
        Me.tbNotOrderedFactor.Location = New System.Drawing.Point(4, 22)
        Me.tbNotOrderedFactor.Name = "tbNotOrderedFactor"
        Me.tbNotOrderedFactor.Padding = New System.Windows.Forms.Padding(3)
        Me.tbNotOrderedFactor.Size = New System.Drawing.Size(288, 183)
        Me.tbNotOrderedFactor.TabIndex = 1
        Me.tbNotOrderedFactor.Tag = "Not_Ordered_Factor"
        Me.tbNotOrderedFactor.Text = "Not Ordered Factor"
        Me.tbNotOrderedFactor.UseVisualStyleBackColor = True
        '
        'grpNotOrderedFactor
        '
        Me.grpNotOrderedFactor.Controls.Add(Me.chkMinimum)
        Me.grpNotOrderedFactor.Controls.Add(Me.chkMaximum)
        Me.grpNotOrderedFactor.Location = New System.Drawing.Point(8, 2)
        Me.grpNotOrderedFactor.Name = "grpNotOrderedFactor"
        Me.grpNotOrderedFactor.Size = New System.Drawing.Size(112, 78)
        Me.grpNotOrderedFactor.TabIndex = 19
        Me.grpNotOrderedFactor.TabStop = False
        '
        'chkMinimum
        '
        Me.chkMinimum.AutoSize = True
        Me.chkMinimum.Location = New System.Drawing.Point(15, 19)
        Me.chkMinimum.Name = "chkMinimum"
        Me.chkMinimum.Size = New System.Drawing.Size(67, 17)
        Me.chkMinimum.TabIndex = 4
        Me.chkMinimum.Tag = "Minimum"
        Me.chkMinimum.Text = "Minimum"
        Me.chkMinimum.UseVisualStyleBackColor = True
        '
        'chkMaximum
        '
        Me.chkMaximum.AutoSize = True
        Me.chkMaximum.Location = New System.Drawing.Point(15, 42)
        Me.chkMaximum.Name = "chkMaximum"
        Me.chkMaximum.Size = New System.Drawing.Size(70, 17)
        Me.chkMaximum.TabIndex = 5
        Me.chkMaximum.Tag = "Maximum"
        Me.chkMaximum.Text = "Maximum"
        Me.chkMaximum.UseVisualStyleBackColor = True
        '
        'tbNumeric
        '
        Me.tbNumeric.Controls.Add(Me.grpNumeric)
        Me.tbNumeric.Location = New System.Drawing.Point(4, 22)
        Me.tbNumeric.Name = "tbNumeric"
        Me.tbNumeric.Padding = New System.Windows.Forms.Padding(3)
        Me.tbNumeric.Size = New System.Drawing.Size(288, 183)
        Me.tbNumeric.TabIndex = 2
        Me.tbNumeric.Tag = "Numeric"
        Me.tbNumeric.Text = "Numeric"
        Me.tbNumeric.UseVisualStyleBackColor = True
        '
        'grpNumeric
        '
        Me.grpNumeric.Controls.Add(Me.chkSum)
        Me.grpNumeric.Controls.Add(Me.chkMean)
        Me.grpNumeric.Controls.Add(Me.chkRange)
        Me.grpNumeric.Controls.Add(Me.chkVariance)
        Me.grpNumeric.Controls.Add(Me.chkStdDev)
        Me.grpNumeric.Controls.Add(Me.chkQuartiles)
        Me.grpNumeric.Controls.Add(Me.chkMedian)
        Me.grpNumeric.Location = New System.Drawing.Point(7, 3)
        Me.grpNumeric.Name = "grpNumeric"
        Me.grpNumeric.Size = New System.Drawing.Size(136, 165)
        Me.grpNumeric.TabIndex = 19
        Me.grpNumeric.TabStop = False
        '
        'chkSum
        '
        Me.chkSum.AutoSize = True
        Me.chkSum.Location = New System.Drawing.Point(13, 16)
        Me.chkSum.Name = "chkSum"
        Me.chkSum.Size = New System.Drawing.Size(47, 17)
        Me.chkSum.TabIndex = 14
        Me.chkSum.Tag = "Sum"
        Me.chkSum.Text = "Sum"
        Me.chkSum.UseVisualStyleBackColor = True
        '
        'chkMean
        '
        Me.chkMean.AutoSize = True
        Me.chkMean.Location = New System.Drawing.Point(13, 38)
        Me.chkMean.Name = "chkMean"
        Me.chkMean.Size = New System.Drawing.Size(53, 17)
        Me.chkMean.TabIndex = 7
        Me.chkMean.Tag = "Mean"
        Me.chkMean.Text = "Mean"
        Me.chkMean.UseVisualStyleBackColor = True
        '
        'chkRange
        '
        Me.chkRange.AutoSize = True
        Me.chkRange.Location = New System.Drawing.Point(13, 59)
        Me.chkRange.Name = "chkRange"
        Me.chkRange.Size = New System.Drawing.Size(58, 17)
        Me.chkRange.TabIndex = 6
        Me.chkRange.Tag = "Range"
        Me.chkRange.Text = "Range"
        Me.chkRange.UseVisualStyleBackColor = True
        '
        'chkVariance
        '
        Me.chkVariance.AutoSize = True
        Me.chkVariance.Enabled = False
        Me.chkVariance.Location = New System.Drawing.Point(13, 143)
        Me.chkVariance.Name = "chkVariance"
        Me.chkVariance.Size = New System.Drawing.Size(68, 17)
        Me.chkVariance.TabIndex = 10
        Me.chkVariance.Tag = "Variance"
        Me.chkVariance.Text = "Variance"
        Me.chkVariance.UseVisualStyleBackColor = True
        '
        'chkStdDev
        '
        Me.chkStdDev.AutoSize = True
        Me.chkStdDev.Location = New System.Drawing.Point(13, 80)
        Me.chkStdDev.Name = "chkStdDev"
        Me.chkStdDev.Size = New System.Drawing.Size(117, 17)
        Me.chkStdDev.TabIndex = 13
        Me.chkStdDev.Tag = "Standard_Deviation"
        Me.chkStdDev.Text = "Standard Deviation"
        Me.chkStdDev.UseVisualStyleBackColor = True
        '
        'chkQuartiles
        '
        Me.chkQuartiles.AutoSize = True
        Me.chkQuartiles.Enabled = False
        Me.chkQuartiles.Location = New System.Drawing.Point(13, 122)
        Me.chkQuartiles.Name = "chkQuartiles"
        Me.chkQuartiles.Size = New System.Drawing.Size(67, 17)
        Me.chkQuartiles.TabIndex = 9
        Me.chkQuartiles.Tag = "Quartiles"
        Me.chkQuartiles.Text = "Quartiles"
        Me.chkQuartiles.UseVisualStyleBackColor = True
        '
        'chkMedian
        '
        Me.chkMedian.AutoSize = True
        Me.chkMedian.Location = New System.Drawing.Point(13, 101)
        Me.chkMedian.Name = "chkMedian"
        Me.chkMedian.Size = New System.Drawing.Size(61, 17)
        Me.chkMedian.TabIndex = 8
        Me.chkMedian.Tag = "Median"
        Me.chkMedian.Text = "Median"
        Me.chkMedian.UseVisualStyleBackColor = True
        '
        'tbOthers
        '
        Me.tbOthers.Controls.Add(Me.GroupBox3)
        Me.tbOthers.Controls.Add(Me.grpPecents)
        Me.tbOthers.Location = New System.Drawing.Point(4, 22)
        Me.tbOthers.Name = "tbOthers"
        Me.tbOthers.Padding = New System.Windows.Forms.Padding(3)
        Me.tbOthers.Size = New System.Drawing.Size(288, 183)
        Me.tbOthers.TabIndex = 3
        Me.tbOthers.Tag = "Others"
        Me.tbOthers.Text = "Others"
        Me.tbOthers.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox21)
        Me.GroupBox3.Controls.Add(Me.CheckBox23)
        Me.GroupBox3.Controls.Add(Me.CheckBox25)
        Me.GroupBox3.Controls.Add(Me.chkSumSquares)
        Me.GroupBox3.Controls.Add(Me.chkHigherMoments)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(267, 80)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        '
        'CheckBox21
        '
        Me.CheckBox21.AutoSize = True
        Me.CheckBox21.Enabled = False
        Me.CheckBox21.Location = New System.Drawing.Point(127, 43)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(137, 17)
        Me.CheckBox21.TabIndex = 15
        Me.CheckBox21.Tag = "Coefficient_of_Variations"
        Me.CheckBox21.Text = "Coefficient of Variations"
        Me.CheckBox21.UseVisualStyleBackColor = True
        '
        'CheckBox23
        '
        Me.CheckBox23.AutoSize = True
        Me.CheckBox23.Enabled = False
        Me.CheckBox23.Location = New System.Drawing.Point(127, 19)
        Me.CheckBox23.Name = "CheckBox23"
        Me.CheckBox23.Size = New System.Drawing.Size(104, 17)
        Me.CheckBox23.TabIndex = 14
        Me.CheckBox23.Tag = "Geometric_Mean"
        Me.CheckBox23.Text = "Geometric Mean"
        Me.CheckBox23.UseVisualStyleBackColor = True
        '
        'CheckBox25
        '
        Me.CheckBox25.AutoSize = True
        Me.CheckBox25.Enabled = False
        Me.CheckBox25.Location = New System.Drawing.Point(13, 63)
        Me.CheckBox25.Name = "CheckBox25"
        Me.CheckBox25.Size = New System.Drawing.Size(101, 17)
        Me.CheckBox25.TabIndex = 12
        Me.CheckBox25.Tag = "Mean_Deviation"
        Me.CheckBox25.Text = "Mean Deviation"
        Me.CheckBox25.UseVisualStyleBackColor = True
        '
        'chkSumSquares
        '
        Me.chkSumSquares.AutoSize = True
        Me.chkSumSquares.Enabled = False
        Me.chkSumSquares.Location = New System.Drawing.Point(13, 39)
        Me.chkSumSquares.Name = "chkSumSquares"
        Me.chkSumSquares.Size = New System.Drawing.Size(99, 17)
        Me.chkSumSquares.TabIndex = 11
        Me.chkSumSquares.Tag = "Sum_of_squares"
        Me.chkSumSquares.Text = "Sum of squares"
        Me.chkSumSquares.UseVisualStyleBackColor = True
        '
        'chkHigherMoments
        '
        Me.chkHigherMoments.AutoSize = True
        Me.chkHigherMoments.Enabled = False
        Me.chkHigherMoments.Location = New System.Drawing.Point(13, 15)
        Me.chkHigherMoments.Name = "chkHigherMoments"
        Me.chkHigherMoments.Size = New System.Drawing.Size(103, 17)
        Me.chkHigherMoments.TabIndex = 10
        Me.chkHigherMoments.Tag = "Higher_Moments"
        Me.chkHigherMoments.Text = "Higher Moments"
        Me.chkHigherMoments.UseVisualStyleBackColor = True
        '
        'UcrButtonsSubdialogue1
        '
        Me.UcrButtonsSubdialogue1.Location = New System.Drawing.Point(71, 290)
        Me.UcrButtonsSubdialogue1.Name = "UcrButtonsSubdialogue1"
        Me.UcrButtonsSubdialogue1.Size = New System.Drawing.Size(142, 30)
        Me.UcrButtonsSubdialogue1.TabIndex = 0
        '
        'sdgDescribe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 321)
        Me.Controls.Add(Me.tbDescribe)
        Me.Controls.Add(Me.grpPrecision)
        Me.Controls.Add(Me.UcrButtonsSubdialogue1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgDescribe"
        Me.Text = "sdgDescribe"
        Me.grpPecents.ResumeLayout(False)
        Me.grpPecents.PerformLayout()
        Me.grpPrecision.ResumeLayout(False)
        Me.grpPrecision.PerformLayout()
        Me.grpAllTypes.ResumeLayout(False)
        Me.grpAllTypes.PerformLayout()
        Me.tbDescribe.ResumeLayout(False)
        Me.tbAllTypes.ResumeLayout(False)
        Me.tbNotOrderedFactor.ResumeLayout(False)
        Me.grpNotOrderedFactor.ResumeLayout(False)
        Me.grpNotOrderedFactor.PerformLayout()
        Me.tbNumeric.ResumeLayout(False)
        Me.grpNumeric.ResumeLayout(False)
        Me.grpNumeric.PerformLayout()
        Me.tbOthers.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcrButtonsSubdialogue1 As ucrButtonsSubdialogue
    Friend WithEvents chkNonMissing As CheckBox
    Friend WithEvents chkNMissing As CheckBox
    Friend WithEvents chkNTotal As CheckBox
    Friend WithEvents chkMode As CheckBox
    Friend WithEvents grpPecents As GroupBox
    Friend WithEvents grpPrecision As GroupBox
    Friend WithEvents ucrInputProportions As ucrInputComboBox
    Friend WithEvents ucrInputInequality As ucrInputComboBox
    Friend WithEvents ucrInputPercentiles As ucrInputComboBox
    Friend WithEvents chkPercentiles As CheckBox
    Friend WithEvents chkProportions As CheckBox
    Friend WithEvents chkResults As CheckBox
    Friend WithEvents ucrInputUnits As ucrInputComboBox
    Friend WithEvents ucrInputPrecision As ucrInputComboBox
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblPrecision As Label
    Friend WithEvents rdoSignificantFigures As RadioButton
    Friend WithEvents rdoDecimals As RadioButton
    Friend WithEvents grpAllTypes As GroupBox
    Friend WithEvents tbDescribe As TabControl
    Friend WithEvents tbAllTypes As TabPage
    Friend WithEvents tbNotOrderedFactor As TabPage
    Friend WithEvents grpNotOrderedFactor As GroupBox
    Friend WithEvents chkMinimum As CheckBox
    Friend WithEvents chkMaximum As CheckBox
    Friend WithEvents tbNumeric As TabPage
    Friend WithEvents grpNumeric As GroupBox
    Friend WithEvents chkMean As CheckBox
    Friend WithEvents chkRange As CheckBox
    Friend WithEvents chkVariance As CheckBox
    Friend WithEvents chkStdDev As CheckBox
    Friend WithEvents chkQuartiles As CheckBox
    Friend WithEvents chkMedian As CheckBox
    Friend WithEvents tbOthers As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CheckBox21 As CheckBox
    Friend WithEvents CheckBox23 As CheckBox
    Friend WithEvents CheckBox25 As CheckBox
    Friend WithEvents chkSumSquares As CheckBox
    Friend WithEvents chkHigherMoments As CheckBox
    Friend WithEvents chkSum As CheckBox
End Class