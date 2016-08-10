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
        Me.UcrButtonsSubdialogue1 = New instat.ucrButtonsSubdialogue()
        Me.chkN = New System.Windows.Forms.CheckBox()
        Me.chkNMissing = New System.Windows.Forms.CheckBox()
        Me.chkNTotal = New System.Windows.Forms.CheckBox()
        Me.chkMinimum = New System.Windows.Forms.CheckBox()
        Me.chkMaximum = New System.Windows.Forms.CheckBox()
        Me.chkRange = New System.Windows.Forms.CheckBox()
        Me.chkMean = New System.Windows.Forms.CheckBox()
        Me.chkMedian = New System.Windows.Forms.CheckBox()
        Me.chkQuartiles = New System.Windows.Forms.CheckBox()
        Me.chkHigherMoments = New System.Windows.Forms.CheckBox()
        Me.chkSumSquares = New System.Windows.Forms.CheckBox()
        Me.chkMeanDeviation = New System.Windows.Forms.CheckBox()
        Me.chkStdDev = New System.Windows.Forms.CheckBox()
        Me.chkGeometricMean = New System.Windows.Forms.CheckBox()
        Me.ChkCoeffVariations = New System.Windows.Forms.CheckBox()
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
        Me.grpPecents.SuspendLayout()
        Me.grpPrecision.SuspendLayout()
        Me.SuspendLayout()
        '
        'UcrButtonsSubdialogue1
        '
        Me.UcrButtonsSubdialogue1.Location = New System.Drawing.Point(103, 297)
        Me.UcrButtonsSubdialogue1.Name = "UcrButtonsSubdialogue1"
        Me.UcrButtonsSubdialogue1.Size = New System.Drawing.Size(142, 30)
        Me.UcrButtonsSubdialogue1.TabIndex = 0
        '
        'chkN
        '
        Me.chkN.AutoSize = True
        Me.chkN.Location = New System.Drawing.Point(12, 9)
        Me.chkN.Name = "chkN"
        Me.chkN.Size = New System.Drawing.Size(34, 17)
        Me.chkN.TabIndex = 1
        Me.chkN.Tag = "N"
        Me.chkN.Text = "N"
        Me.chkN.UseVisualStyleBackColor = True
        '
        'chkNMissing
        '
        Me.chkNMissing.AutoSize = True
        Me.chkNMissing.Location = New System.Drawing.Point(12, 31)
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
        Me.chkNTotal.Location = New System.Drawing.Point(12, 53)
        Me.chkNTotal.Name = "chkNTotal"
        Me.chkNTotal.Size = New System.Drawing.Size(61, 17)
        Me.chkNTotal.TabIndex = 3
        Me.chkNTotal.Tag = "N_Total"
        Me.chkNTotal.Text = "N Total"
        Me.chkNTotal.UseVisualStyleBackColor = True
        '
        'chkMinimum
        '
        Me.chkMinimum.AutoSize = True
        Me.chkMinimum.Location = New System.Drawing.Point(12, 75)
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
        Me.chkMaximum.Location = New System.Drawing.Point(12, 97)
        Me.chkMaximum.Name = "chkMaximum"
        Me.chkMaximum.Size = New System.Drawing.Size(70, 17)
        Me.chkMaximum.TabIndex = 5
        Me.chkMaximum.Tag = "Maximum"
        Me.chkMaximum.Text = "Maximum"
        Me.chkMaximum.UseVisualStyleBackColor = True
        '
        'chkRange
        '
        Me.chkRange.AutoSize = True
        Me.chkRange.Location = New System.Drawing.Point(12, 119)
        Me.chkRange.Name = "chkRange"
        Me.chkRange.Size = New System.Drawing.Size(58, 17)
        Me.chkRange.TabIndex = 6
        Me.chkRange.Tag = "Range"
        Me.chkRange.Text = "Range"
        Me.chkRange.UseVisualStyleBackColor = True
        '
        'chkMean
        '
        Me.chkMean.AutoSize = True
        Me.chkMean.Location = New System.Drawing.Point(12, 141)
        Me.chkMean.Name = "chkMean"
        Me.chkMean.Size = New System.Drawing.Size(53, 17)
        Me.chkMean.TabIndex = 7
        Me.chkMean.Tag = "Mean"
        Me.chkMean.Text = "Mean"
        Me.chkMean.UseVisualStyleBackColor = True
        '
        'chkMedian
        '
        Me.chkMedian.AutoSize = True
        Me.chkMedian.Location = New System.Drawing.Point(172, 7)
        Me.chkMedian.Name = "chkMedian"
        Me.chkMedian.Size = New System.Drawing.Size(61, 17)
        Me.chkMedian.TabIndex = 8
        Me.chkMedian.Tag = "Median"
        Me.chkMedian.Text = "Median"
        Me.chkMedian.UseVisualStyleBackColor = True
        '
        'chkQuartiles
        '
        Me.chkQuartiles.AutoSize = True
        Me.chkQuartiles.Location = New System.Drawing.Point(172, 31)
        Me.chkQuartiles.Name = "chkQuartiles"
        Me.chkQuartiles.Size = New System.Drawing.Size(67, 17)
        Me.chkQuartiles.TabIndex = 9
        Me.chkQuartiles.Tag = "Quartiles"
        Me.chkQuartiles.Text = "Quartiles"
        Me.chkQuartiles.UseVisualStyleBackColor = True
        '
        'chkHigherMoments
        '
        Me.chkHigherMoments.AutoSize = True
        Me.chkHigherMoments.Location = New System.Drawing.Point(172, 55)
        Me.chkHigherMoments.Name = "chkHigherMoments"
        Me.chkHigherMoments.Size = New System.Drawing.Size(103, 17)
        Me.chkHigherMoments.TabIndex = 10
        Me.chkHigherMoments.Tag = "Higher_Moments"
        Me.chkHigherMoments.Text = "Higher Moments"
        Me.chkHigherMoments.UseVisualStyleBackColor = True
        '
        'chkSumSquares
        '
        Me.chkSumSquares.AutoSize = True
        Me.chkSumSquares.Location = New System.Drawing.Point(172, 79)
        Me.chkSumSquares.Name = "chkSumSquares"
        Me.chkSumSquares.Size = New System.Drawing.Size(99, 17)
        Me.chkSumSquares.TabIndex = 11
        Me.chkSumSquares.Tag = "Sum_of_squares"
        Me.chkSumSquares.Text = "Sum of squares"
        Me.chkSumSquares.UseVisualStyleBackColor = True
        '
        'chkMeanDeviation
        '
        Me.chkMeanDeviation.AutoSize = True
        Me.chkMeanDeviation.Location = New System.Drawing.Point(172, 103)
        Me.chkMeanDeviation.Name = "chkMeanDeviation"
        Me.chkMeanDeviation.Size = New System.Drawing.Size(101, 17)
        Me.chkMeanDeviation.TabIndex = 12
        Me.chkMeanDeviation.Tag = "Mean_Deviation"
        Me.chkMeanDeviation.Text = "Mean Deviation"
        Me.chkMeanDeviation.UseVisualStyleBackColor = True
        '
        'chkStdDev
        '
        Me.chkStdDev.AutoSize = True
        Me.chkStdDev.Location = New System.Drawing.Point(12, 163)
        Me.chkStdDev.Name = "chkStdDev"
        Me.chkStdDev.Size = New System.Drawing.Size(117, 17)
        Me.chkStdDev.TabIndex = 13
        Me.chkStdDev.Tag = "Standard_Deviation"
        Me.chkStdDev.Text = "Standard Deviation"
        Me.chkStdDev.UseVisualStyleBackColor = True
        '
        'chkGeometricMean
        '
        Me.chkGeometricMean.AutoSize = True
        Me.chkGeometricMean.Location = New System.Drawing.Point(172, 127)
        Me.chkGeometricMean.Name = "chkGeometricMean"
        Me.chkGeometricMean.Size = New System.Drawing.Size(104, 17)
        Me.chkGeometricMean.TabIndex = 14
        Me.chkGeometricMean.Tag = "Geometric_Mean"
        Me.chkGeometricMean.Text = "Geometric Mean"
        Me.chkGeometricMean.UseVisualStyleBackColor = True
        '
        'ChkCoeffVariations
        '
        Me.ChkCoeffVariations.AutoSize = True
        Me.ChkCoeffVariations.Location = New System.Drawing.Point(172, 151)
        Me.ChkCoeffVariations.Name = "ChkCoeffVariations"
        Me.ChkCoeffVariations.Size = New System.Drawing.Size(137, 17)
        Me.ChkCoeffVariations.TabIndex = 15
        Me.ChkCoeffVariations.Tag = "Coefficient_of_Variations"
        Me.ChkCoeffVariations.Text = "Coefficient of Variations"
        Me.ChkCoeffVariations.UseVisualStyleBackColor = True
        '
        'grpPecents
        '
        Me.grpPecents.Controls.Add(Me.ucrInputProportions)
        Me.grpPecents.Controls.Add(Me.ucrInputInequality)
        Me.grpPecents.Controls.Add(Me.ucrInputPercentiles)
        Me.grpPecents.Controls.Add(Me.chkPercentiles)
        Me.grpPecents.Controls.Add(Me.chkProportions)
        Me.grpPecents.Controls.Add(Me.chkResults)
        Me.grpPecents.Location = New System.Drawing.Point(11, 185)
        Me.grpPecents.Name = "grpPecents"
        Me.grpPecents.Size = New System.Drawing.Size(185, 109)
        Me.grpPecents.TabIndex = 16
        Me.grpPecents.TabStop = False
        '
        'ucrInputProportions
        '
        Me.ucrInputProportions.IsReadOnly = False
        Me.ucrInputProportions.Location = New System.Drawing.Point(118, 53)
        Me.ucrInputProportions.Name = "ucrInputProportions"
        Me.ucrInputProportions.Size = New System.Drawing.Size(50, 21)
        Me.ucrInputProportions.TabIndex = 23
        '
        'ucrInputInequality
        '
        Me.ucrInputInequality.IsReadOnly = False
        Me.ucrInputInequality.Location = New System.Drawing.Point(85, 53)
        Me.ucrInputInequality.Name = "ucrInputInequality"
        Me.ucrInputInequality.Size = New System.Drawing.Size(28, 21)
        Me.ucrInputInequality.TabIndex = 22
        '
        'ucrInputPercentiles
        '
        Me.ucrInputPercentiles.IsReadOnly = False
        Me.ucrInputPercentiles.Location = New System.Drawing.Point(88, 16)
        Me.ucrInputPercentiles.Name = "ucrInputPercentiles"
        Me.ucrInputPercentiles.Size = New System.Drawing.Size(84, 21)
        Me.ucrInputPercentiles.TabIndex = 21
        '
        'chkPercentiles
        '
        Me.chkPercentiles.AutoSize = True
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
        Me.chkResults.Location = New System.Drawing.Point(75, 84)
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
        Me.grpPrecision.Location = New System.Drawing.Point(198, 185)
        Me.grpPrecision.Name = "grpPrecision"
        Me.grpPrecision.Size = New System.Drawing.Size(161, 109)
        Me.grpPrecision.TabIndex = 17
        Me.grpPrecision.TabStop = False
        '
        'ucrInputUnits
        '
        Me.ucrInputUnits.IsReadOnly = False
        Me.ucrInputUnits.Location = New System.Drawing.Point(43, 70)
        Me.ucrInputUnits.Name = "ucrInputUnits"
        Me.ucrInputUnits.Size = New System.Drawing.Size(43, 21)
        Me.ucrInputUnits.TabIndex = 23
        '
        'ucrInputPrecision
        '
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
        Me.lblUnits.Location = New System.Drawing.Point(6, 73)
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
        Me.rdoSignificantFigures.Location = New System.Drawing.Point(71, 47)
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
        Me.rdoDecimals.Location = New System.Drawing.Point(4, 47)
        Me.rdoDecimals.Name = "rdoDecimals"
        Me.rdoDecimals.Size = New System.Drawing.Size(68, 17)
        Me.rdoDecimals.TabIndex = 0
        Me.rdoDecimals.TabStop = True
        Me.rdoDecimals.Tag = "Decimals"
        Me.rdoDecimals.Text = "Decimals"
        Me.rdoDecimals.UseVisualStyleBackColor = True
        '
        'sdgDescribe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 332)
        Me.Controls.Add(Me.grpPrecision)
        Me.Controls.Add(Me.grpPecents)
        Me.Controls.Add(Me.ChkCoeffVariations)
        Me.Controls.Add(Me.chkGeometricMean)
        Me.Controls.Add(Me.chkMeanDeviation)
        Me.Controls.Add(Me.chkSumSquares)
        Me.Controls.Add(Me.chkHigherMoments)
        Me.Controls.Add(Me.chkQuartiles)
        Me.Controls.Add(Me.chkMedian)
        Me.Controls.Add(Me.chkStdDev)
        Me.Controls.Add(Me.chkMean)
        Me.Controls.Add(Me.chkRange)
        Me.Controls.Add(Me.chkMaximum)
        Me.Controls.Add(Me.chkMinimum)
        Me.Controls.Add(Me.chkNTotal)
        Me.Controls.Add(Me.chkNMissing)
        Me.Controls.Add(Me.chkN)
        Me.Controls.Add(Me.UcrButtonsSubdialogue1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgDescribe"
        Me.Text = "sdgDescribe"
        Me.grpPecents.ResumeLayout(False)
        Me.grpPecents.PerformLayout()
        Me.grpPrecision.ResumeLayout(False)
        Me.grpPrecision.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcrButtonsSubdialogue1 As ucrButtonsSubdialogue
    Friend WithEvents chkN As CheckBox
    Friend WithEvents chkNMissing As CheckBox
    Friend WithEvents chkNTotal As CheckBox
    Friend WithEvents chkMinimum As CheckBox
    Friend WithEvents chkMaximum As CheckBox
    Friend WithEvents chkRange As CheckBox
    Friend WithEvents chkMean As CheckBox
    Friend WithEvents chkMedian As CheckBox
    Friend WithEvents chkQuartiles As CheckBox
    Friend WithEvents chkHigherMoments As CheckBox
    Friend WithEvents chkSumSquares As CheckBox
    Friend WithEvents chkMeanDeviation As CheckBox
    Friend WithEvents chkStdDev As CheckBox
    Friend WithEvents chkGeometricMean As CheckBox
    Friend WithEvents ChkCoeffVariations As CheckBox
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
End Class

