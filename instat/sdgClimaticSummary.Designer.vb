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
        Me.ucrBaseSdgClimaticSummary = New instat.ucrButtonsSubdialogue()
        Me.ucrNudValue = New instat.ucrNud()
        Me.ucrChkPercentages = New instat.ucrCheck()
        Me.ucrInputNumbers = New instat.ucrInputTextBox()
        Me.ucrInputPercentiles = New instat.ucrInputComboBox()
        Me.ucrInputComboOptions = New instat.ucrInputComboBox()
        Me.ucrPnlSummary = New instat.UcrPanel()
        Me.grpSummary = New System.Windows.Forms.GroupBox()
        Me.grpSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoTotals
        '
        Me.rdoTotals.AutoSize = True
        Me.rdoTotals.Location = New System.Drawing.Point(20, 33)
        Me.rdoTotals.Name = "rdoTotals"
        Me.rdoTotals.Size = New System.Drawing.Size(54, 17)
        Me.rdoTotals.TabIndex = 9
        Me.rdoTotals.Tag = "Totals"
        Me.rdoTotals.Text = "Totals"
        Me.rdoTotals.UseVisualStyleBackColor = True
        '
        'rdoCounts
        '
        Me.rdoCounts.AutoSize = True
        Me.rdoCounts.Location = New System.Drawing.Point(263, 33)
        Me.rdoCounts.Name = "rdoCounts"
        Me.rdoCounts.Size = New System.Drawing.Size(58, 17)
        Me.rdoCounts.TabIndex = 10
        Me.rdoCounts.Tag = "Counts"
        Me.rdoCounts.Text = "Counts"
        Me.rdoCounts.UseVisualStyleBackColor = True
        '
        'rdoMissing
        '
        Me.rdoMissing.AutoSize = True
        Me.rdoMissing.Location = New System.Drawing.Point(343, 33)
        Me.rdoMissing.Name = "rdoMissing"
        Me.rdoMissing.Size = New System.Drawing.Size(60, 17)
        Me.rdoMissing.TabIndex = 11
        Me.rdoMissing.Tag = "Missing"
        Me.rdoMissing.Text = "Missing"
        Me.rdoMissing.UseVisualStyleBackColor = True
        '
        'rdoMinima
        '
        Me.rdoMinima.AutoSize = True
        Me.rdoMinima.Location = New System.Drawing.Point(20, 69)
        Me.rdoMinima.Name = "rdoMinima"
        Me.rdoMinima.Size = New System.Drawing.Size(58, 17)
        Me.rdoMinima.TabIndex = 12
        Me.rdoMinima.Tag = "Minima"
        Me.rdoMinima.Text = "Minima"
        Me.rdoMinima.UseVisualStyleBackColor = True
        '
        'rdoMeans
        '
        Me.rdoMeans.AutoSize = True
        Me.rdoMeans.Location = New System.Drawing.Point(97, 33)
        Me.rdoMeans.Name = "rdoMeans"
        Me.rdoMeans.Size = New System.Drawing.Size(57, 17)
        Me.rdoMeans.TabIndex = 13
        Me.rdoMeans.Tag = "Means"
        Me.rdoMeans.Text = "Means"
        Me.rdoMeans.UseVisualStyleBackColor = True
        '
        'rdoPercentiles
        '
        Me.rdoPercentiles.AutoSize = True
        Me.rdoPercentiles.Location = New System.Drawing.Point(341, 69)
        Me.rdoPercentiles.Name = "rdoPercentiles"
        Me.rdoPercentiles.Size = New System.Drawing.Size(77, 17)
        Me.rdoPercentiles.TabIndex = 14
        Me.rdoPercentiles.Tag = "Percentiles"
        Me.rdoPercentiles.Text = "Percentiles"
        Me.rdoPercentiles.UseVisualStyleBackColor = True
        '
        'rdoMedians
        '
        Me.rdoMedians.AutoSize = True
        Me.rdoMedians.Location = New System.Drawing.Point(172, 33)
        Me.rdoMedians.Name = "rdoMedians"
        Me.rdoMedians.Size = New System.Drawing.Size(65, 17)
        Me.rdoMedians.TabIndex = 15
        Me.rdoMedians.Tag = "Medians"
        Me.rdoMedians.Text = "Medians"
        Me.rdoMedians.UseVisualStyleBackColor = True
        '
        'rdoStd
        '
        Me.rdoStd.AutoSize = True
        Me.rdoStd.Location = New System.Drawing.Point(172, 69)
        Me.rdoStd.Name = "rdoStd"
        Me.rdoStd.Size = New System.Drawing.Size(69, 17)
        Me.rdoStd.TabIndex = 16
        Me.rdoStd.Tag = "Std.Devs"
        Me.rdoStd.Text = "Std.Devs"
        Me.rdoStd.UseVisualStyleBackColor = True
        '
        'rdoMaxima
        '
        Me.rdoMaxima.AutoSize = True
        Me.rdoMaxima.Location = New System.Drawing.Point(93, 69)
        Me.rdoMaxima.Name = "rdoMaxima"
        Me.rdoMaxima.Size = New System.Drawing.Size(61, 17)
        Me.rdoMaxima.TabIndex = 17
        Me.rdoMaxima.Tag = "Maxima"
        Me.rdoMaxima.Text = "Maxima"
        Me.rdoMaxima.UseVisualStyleBackColor = True
        '
        'rdoProportions
        '
        Me.rdoProportions.AutoSize = True
        Me.rdoProportions.Location = New System.Drawing.Point(259, 69)
        Me.rdoProportions.Name = "rdoProportions"
        Me.rdoProportions.Size = New System.Drawing.Size(78, 17)
        Me.rdoProportions.TabIndex = 18
        Me.rdoProportions.Tag = "Proportions"
        Me.rdoProportions.Text = "Proportions"
        Me.rdoProportions.UseVisualStyleBackColor = True
        '
        'ucrBaseSdgClimaticSummary
        '
        Me.ucrBaseSdgClimaticSummary.Location = New System.Drawing.Point(132, 185)
        Me.ucrBaseSdgClimaticSummary.Name = "ucrBaseSdgClimaticSummary"
        Me.ucrBaseSdgClimaticSummary.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSdgClimaticSummary.TabIndex = 26
        '
        'ucrNudValue
        '
        Me.ucrNudValue.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudValue.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudValue.Location = New System.Drawing.Point(344, 132)
        Me.ucrNudValue.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudValue.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudValue.Name = "ucrNudValue"
        Me.ucrNudValue.Size = New System.Drawing.Size(62, 21)
        Me.ucrNudValue.TabIndex = 25
        Me.ucrNudValue.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkPercentages
        '
        Me.ucrChkPercentages.Checked = False
        Me.ucrChkPercentages.Location = New System.Drawing.Point(258, 163)
        Me.ucrChkPercentages.Name = "ucrChkPercentages"
        Me.ucrChkPercentages.Size = New System.Drawing.Size(137, 20)
        Me.ucrChkPercentages.TabIndex = 24
        '
        'ucrInputNumbers
        '
        Me.ucrInputNumbers.AddQuotesIfUnrecognised = True
        Me.ucrInputNumbers.IsMultiline = False
        Me.ucrInputNumbers.IsReadOnly = False
        Me.ucrInputNumbers.Location = New System.Drawing.Point(344, 132)
        Me.ucrInputNumbers.Name = "ucrInputNumbers"
        Me.ucrInputNumbers.Size = New System.Drawing.Size(62, 21)
        Me.ucrInputNumbers.TabIndex = 22
        '
        'ucrInputPercentiles
        '
        Me.ucrInputPercentiles.AddQuotesIfUnrecognised = True
        Me.ucrInputPercentiles.IsReadOnly = False
        Me.ucrInputPercentiles.Location = New System.Drawing.Point(258, 132)
        Me.ucrInputPercentiles.Name = "ucrInputPercentiles"
        Me.ucrInputPercentiles.Size = New System.Drawing.Size(118, 21)
        Me.ucrInputPercentiles.TabIndex = 21
        '
        'ucrInputComboOptions
        '
        Me.ucrInputComboOptions.AddQuotesIfUnrecognised = True
        Me.ucrInputComboOptions.IsReadOnly = False
        Me.ucrInputComboOptions.Location = New System.Drawing.Point(258, 132)
        Me.ucrInputComboOptions.Name = "ucrInputComboOptions"
        Me.ucrInputComboOptions.Size = New System.Drawing.Size(51, 21)
        Me.ucrInputComboOptions.TabIndex = 20
        '
        'ucrPnlSummary
        '
        Me.ucrPnlSummary.Location = New System.Drawing.Point(6, 19)
        Me.ucrPnlSummary.Name = "ucrPnlSummary"
        Me.ucrPnlSummary.Size = New System.Drawing.Size(426, 89)
        Me.ucrPnlSummary.TabIndex = 19
        '
        'grpSummary
        '
        Me.grpSummary.Controls.Add(Me.rdoProportions)
        Me.grpSummary.Controls.Add(Me.rdoMissing)
        Me.grpSummary.Controls.Add(Me.rdoCounts)
        Me.grpSummary.Controls.Add(Me.rdoMeans)
        Me.grpSummary.Controls.Add(Me.rdoTotals)
        Me.grpSummary.Controls.Add(Me.rdoMaxima)
        Me.grpSummary.Controls.Add(Me.rdoMinima)
        Me.grpSummary.Controls.Add(Me.rdoPercentiles)
        Me.grpSummary.Controls.Add(Me.rdoStd)
        Me.grpSummary.Controls.Add(Me.rdoMedians)
        Me.grpSummary.Controls.Add(Me.ucrPnlSummary)
        Me.grpSummary.Location = New System.Drawing.Point(12, 12)
        Me.grpSummary.Name = "grpSummary"
        Me.grpSummary.Size = New System.Drawing.Size(455, 114)
        Me.grpSummary.TabIndex = 27
        Me.grpSummary.TabStop = False
        Me.grpSummary.Text = "Summary"
        '
        'sdgClimaticSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 227)
        Me.Controls.Add(Me.ucrBaseSdgClimaticSummary)
        Me.Controls.Add(Me.ucrNudValue)
        Me.Controls.Add(Me.ucrChkPercentages)
        Me.Controls.Add(Me.ucrInputNumbers)
        Me.Controls.Add(Me.ucrInputPercentiles)
        Me.Controls.Add(Me.ucrInputComboOptions)
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
    Friend WithEvents ucrInputPercentiles As ucrInputComboBox
    Friend WithEvents ucrInputNumbers As ucrInputTextBox
    Friend WithEvents ucrChkPercentages As ucrCheck
    Friend WithEvents ucrNudValue As ucrNud
    Friend WithEvents ucrBaseSdgClimaticSummary As ucrButtonsSubdialogue
    Friend WithEvents grpSummary As GroupBox
End Class
