<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgClimaticSummary
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
        Me.rdoTotals = New System.Windows.Forms.RadioButton()
        Me.rdoCounts = New System.Windows.Forms.RadioButton()
        Me.rdoMissing = New System.Windows.Forms.RadioButton()
        Me.rdoMinima = New System.Windows.Forms.RadioButton()
        Me.rdoMeans = New System.Windows.Forms.RadioButton()
        Me.rdoPercentiles = New System.Windows.Forms.RadioButton()
        Me.rdoMedians = New System.Windows.Forms.RadioButton()
        Me.rdoStd = New System.Windows.Forms.RadioButton()
        Me.rdoMaxima = New System.Windows.Forms.RadioButton()
        Me.rdoProportions = New System.Windows.Forms.RadioButton()
        Me.grpSummary = New System.Windows.Forms.GroupBox()
        Me.ucrNudPercentile = New instat.ucrNud()
        Me.ucrChkPercentages = New instat.ucrCheck()
        Me.ucrInputNumbers = New instat.ucrInputTextBox()
        Me.ucrInputComboOptions = New instat.ucrInputComboBox()
        Me.ucrPnlSummary = New instat.UcrPanel()
        Me.ucrBaseSdgClimaticSummary = New instat.ucrButtonsSubdialogue()
        Me.grpSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoTotals
        '
        Me.rdoTotals.AutoSize = True
        Me.rdoTotals.Location = New System.Drawing.Point(114, 95)
        Me.rdoTotals.Name = "rdoTotals"
        Me.rdoTotals.Size = New System.Drawing.Size(49, 17)
        Me.rdoTotals.TabIndex = 10
        Me.rdoTotals.Tag = "Totals"
        Me.rdoTotals.Text = "Total"
        Me.rdoTotals.UseVisualStyleBackColor = True
        '
        'rdoCounts
        '
        Me.rdoCounts.AutoSize = True
        Me.rdoCounts.Location = New System.Drawing.Point(14, 24)
        Me.rdoCounts.Name = "rdoCounts"
        Me.rdoCounts.Size = New System.Drawing.Size(53, 17)
        Me.rdoCounts.TabIndex = 2
        Me.rdoCounts.Tag = "Counts"
        Me.rdoCounts.Text = "Count"
        Me.rdoCounts.UseVisualStyleBackColor = True
        '
        'rdoMissing
        '
        Me.rdoMissing.AutoSize = True
        Me.rdoMissing.Location = New System.Drawing.Point(114, 24)
        Me.rdoMissing.Name = "rdoMissing"
        Me.rdoMissing.Size = New System.Drawing.Size(60, 17)
        Me.rdoMissing.TabIndex = 7
        Me.rdoMissing.Tag = "Missing"
        Me.rdoMissing.Text = "Missing"
        Me.rdoMissing.UseVisualStyleBackColor = True
        '
        'rdoMinima
        '
        Me.rdoMinima.AutoSize = True
        Me.rdoMinima.Location = New System.Drawing.Point(14, 47)
        Me.rdoMinima.Name = "rdoMinima"
        Me.rdoMinima.Size = New System.Drawing.Size(66, 17)
        Me.rdoMinima.TabIndex = 3
        Me.rdoMinima.Tag = "Minima"
        Me.rdoMinima.Text = "Minimum"
        Me.rdoMinima.UseVisualStyleBackColor = True
        '
        'rdoMeans
        '
        Me.rdoMeans.AutoSize = True
        Me.rdoMeans.Location = New System.Drawing.Point(14, 70)
        Me.rdoMeans.Name = "rdoMeans"
        Me.rdoMeans.Size = New System.Drawing.Size(52, 17)
        Me.rdoMeans.TabIndex = 4
        Me.rdoMeans.Tag = "Means"
        Me.rdoMeans.Text = "Mean"
        Me.rdoMeans.UseVisualStyleBackColor = True
        '
        'rdoPercentiles
        '
        Me.rdoPercentiles.AutoSize = True
        Me.rdoPercentiles.Location = New System.Drawing.Point(114, 118)
        Me.rdoPercentiles.Name = "rdoPercentiles"
        Me.rdoPercentiles.Size = New System.Drawing.Size(77, 17)
        Me.rdoPercentiles.TabIndex = 11
        Me.rdoPercentiles.Tag = "Percentiles"
        Me.rdoPercentiles.Text = "Percentiles"
        Me.rdoPercentiles.UseVisualStyleBackColor = True
        '
        'rdoMedians
        '
        Me.rdoMedians.AutoSize = True
        Me.rdoMedians.Location = New System.Drawing.Point(14, 93)
        Me.rdoMedians.Name = "rdoMedians"
        Me.rdoMedians.Size = New System.Drawing.Size(60, 17)
        Me.rdoMedians.TabIndex = 5
        Me.rdoMedians.Tag = "Medians"
        Me.rdoMedians.Text = "Median"
        Me.rdoMedians.UseVisualStyleBackColor = True
        '
        'rdoStd
        '
        Me.rdoStd.AutoSize = True
        Me.rdoStd.Location = New System.Drawing.Point(114, 72)
        Me.rdoStd.Name = "rdoStd"
        Me.rdoStd.Size = New System.Drawing.Size(116, 17)
        Me.rdoStd.TabIndex = 9
        Me.rdoStd.Tag = "Std.Devs"
        Me.rdoStd.Text = "Standard Deviation"
        Me.rdoStd.UseVisualStyleBackColor = True
        '
        'rdoMaxima
        '
        Me.rdoMaxima.AutoSize = True
        Me.rdoMaxima.Location = New System.Drawing.Point(114, 47)
        Me.rdoMaxima.Name = "rdoMaxima"
        Me.rdoMaxima.Size = New System.Drawing.Size(69, 17)
        Me.rdoMaxima.TabIndex = 8
        Me.rdoMaxima.Tag = "Maxima"
        Me.rdoMaxima.Text = "Maximum"
        Me.rdoMaxima.UseVisualStyleBackColor = True
        '
        'rdoProportions
        '
        Me.rdoProportions.AutoSize = True
        Me.rdoProportions.Location = New System.Drawing.Point(14, 118)
        Me.rdoProportions.Name = "rdoProportions"
        Me.rdoProportions.Size = New System.Drawing.Size(73, 17)
        Me.rdoProportions.TabIndex = 6
        Me.rdoProportions.Tag = "Proportions"
        Me.rdoProportions.Text = "Proportion"
        Me.rdoProportions.UseVisualStyleBackColor = True
        '
        'grpSummary
        '
        Me.grpSummary.Controls.Add(Me.ucrNudPercentile)
        Me.grpSummary.Controls.Add(Me.ucrChkPercentages)
        Me.grpSummary.Controls.Add(Me.rdoTotals)
        Me.grpSummary.Controls.Add(Me.rdoPercentiles)
        Me.grpSummary.Controls.Add(Me.ucrInputNumbers)
        Me.grpSummary.Controls.Add(Me.rdoProportions)
        Me.grpSummary.Controls.Add(Me.ucrInputComboOptions)
        Me.grpSummary.Controls.Add(Me.rdoCounts)
        Me.grpSummary.Controls.Add(Me.rdoMissing)
        Me.grpSummary.Controls.Add(Me.rdoMinima)
        Me.grpSummary.Controls.Add(Me.rdoStd)
        Me.grpSummary.Controls.Add(Me.rdoMeans)
        Me.grpSummary.Controls.Add(Me.rdoMedians)
        Me.grpSummary.Controls.Add(Me.rdoMaxima)
        Me.grpSummary.Controls.Add(Me.ucrPnlSummary)
        Me.grpSummary.Location = New System.Drawing.Point(8, 8)
        Me.grpSummary.Name = "grpSummary"
        Me.grpSummary.Size = New System.Drawing.Size(251, 199)
        Me.grpSummary.TabIndex = 0
        Me.grpSummary.TabStop = False
        Me.grpSummary.Text = "Summary"
        '
        'ucrNudPercentile
        '
        Me.ucrNudPercentile.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPercentile.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPercentile.Location = New System.Drawing.Point(191, 118)
        Me.ucrNudPercentile.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPercentile.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPercentile.Name = "ucrNudPercentile"
        Me.ucrNudPercentile.Size = New System.Drawing.Size(54, 21)
        Me.ucrNudPercentile.TabIndex = 12
        Me.ucrNudPercentile.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkPercentages
        '
        Me.ucrChkPercentages.Checked = False
        Me.ucrChkPercentages.Location = New System.Drawing.Point(14, 141)
        Me.ucrChkPercentages.Name = "ucrChkPercentages"
        Me.ucrChkPercentages.Size = New System.Drawing.Size(98, 20)
        Me.ucrChkPercentages.TabIndex = 13
        '
        'ucrInputNumbers
        '
        Me.ucrInputNumbers.AddQuotesIfUnrecognised = True
        Me.ucrInputNumbers.IsMultiline = False
        Me.ucrInputNumbers.IsReadOnly = False
        Me.ucrInputNumbers.Location = New System.Drawing.Point(114, 167)
        Me.ucrInputNumbers.Name = "ucrInputNumbers"
        Me.ucrInputNumbers.Size = New System.Drawing.Size(101, 21)
        Me.ucrInputNumbers.TabIndex = 0
        '
        'ucrInputComboOptions
        '
        Me.ucrInputComboOptions.AddQuotesIfUnrecognised = True
        Me.ucrInputComboOptions.IsReadOnly = False
        Me.ucrInputComboOptions.Location = New System.Drawing.Point(20, 167)
        Me.ucrInputComboOptions.Name = "ucrInputComboOptions"
        Me.ucrInputComboOptions.Size = New System.Drawing.Size(74, 21)
        Me.ucrInputComboOptions.TabIndex = 14
        '
        'ucrPnlSummary
        '
        Me.ucrPnlSummary.Location = New System.Drawing.Point(5, 15)
        Me.ucrPnlSummary.Name = "ucrPnlSummary"
        Me.ucrPnlSummary.Size = New System.Drawing.Size(237, 178)
        Me.ucrPnlSummary.TabIndex = 1
        '
        'ucrBaseSdgClimaticSummary
        '
        Me.ucrBaseSdgClimaticSummary.Location = New System.Drawing.Point(49, 213)
        Me.ucrBaseSdgClimaticSummary.Name = "ucrBaseSdgClimaticSummary"
        Me.ucrBaseSdgClimaticSummary.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSdgClimaticSummary.TabIndex = 1
        '
        'sdgClimaticSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 261)
        Me.Controls.Add(Me.ucrBaseSdgClimaticSummary)
        Me.Controls.Add(Me.grpSummary)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgClimaticSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Climatic Summary"
        Me.grpSummary.ResumeLayout(False)
        Me.grpSummary.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rdoTotals As RadioButton
    Friend WithEvents rdoCounts As RadioButton
    Friend WithEvents rdoMissing As RadioButton
    Friend WithEvents rdoMinima As RadioButton
    Friend WithEvents rdoMeans As RadioButton
    Friend WithEvents rdoPercentiles As RadioButton
    Friend WithEvents rdoMedians As RadioButton
    Friend WithEvents rdoStd As RadioButton
    Friend WithEvents rdoMaxima As RadioButton
    Friend WithEvents rdoProportions As RadioButton
    Friend WithEvents ucrPnlSummary As UcrPanel
    Friend WithEvents ucrInputComboOptions As ucrInputComboBox
    Friend WithEvents ucrInputNumbers As ucrInputTextBox
    Friend WithEvents ucrChkPercentages As ucrCheck
    Friend WithEvents ucrBaseSdgClimaticSummary As ucrButtonsSubdialogue
    Friend WithEvents grpSummary As GroupBox
    Friend WithEvents ucrNudPercentile As ucrNud
End Class
