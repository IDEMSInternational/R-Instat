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
        Me.ucrPnlSummary = New instat.UcrPanel()
        Me.ucrInputOptions = New instat.ucrInputComboBox()
        Me.ucrInputPercentiles = New instat.ucrInputComboBox()
        Me.ucrInputNumbers = New instat.ucrInputTextBox()
        Me.ucrInputProportions = New instat.ucrInputComboBox()
        Me.ucrChkPercentages = New instat.ucrCheck()
        Me.ucrNudValue = New instat.ucrNud()
        Me.ucrBaseSdgClimaticSummary = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'rdoTotals
        '
        Me.rdoTotals.AutoSize = True
        Me.rdoTotals.Location = New System.Drawing.Point(23, 22)
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
        Me.rdoCounts.Location = New System.Drawing.Point(23, 58)
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
        Me.rdoMissing.Location = New System.Drawing.Point(97, 22)
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
        Me.rdoMinima.Location = New System.Drawing.Point(99, 58)
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
        Me.rdoMeans.Location = New System.Drawing.Point(183, 22)
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
        Me.rdoPercentiles.Location = New System.Drawing.Point(345, 58)
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
        Me.rdoMedians.Location = New System.Drawing.Point(183, 58)
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
        Me.rdoStd.Location = New System.Drawing.Point(263, 58)
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
        Me.rdoMaxima.Location = New System.Drawing.Point(263, 22)
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
        Me.rdoProportions.Location = New System.Drawing.Point(344, 22)
        Me.rdoProportions.Name = "rdoProportions"
        Me.rdoProportions.Size = New System.Drawing.Size(78, 17)
        Me.rdoProportions.TabIndex = 18
        Me.rdoProportions.Tag = "Proportions"
        Me.rdoProportions.Text = "Proportions"
        Me.rdoProportions.UseVisualStyleBackColor = True
        '
        'ucrPnlSummary
        '
        Me.ucrPnlSummary.Location = New System.Drawing.Point(12, 12)
        Me.ucrPnlSummary.Name = "ucrPnlSummary"
        Me.ucrPnlSummary.Size = New System.Drawing.Size(410, 83)
        Me.ucrPnlSummary.TabIndex = 19
        '
        'ucrInputOptions
        '
        Me.ucrInputOptions.AddQuotesIfUnrecognised = True
        Me.ucrInputOptions.IsReadOnly = False
        Me.ucrInputOptions.Location = New System.Drawing.Point(26, 115)
        Me.ucrInputOptions.Name = "ucrInputOptions"
        Me.ucrInputOptions.Size = New System.Drawing.Size(51, 21)
        Me.ucrInputOptions.TabIndex = 20
        '
        'ucrInputPercentiles
        '
        Me.ucrInputPercentiles.AddQuotesIfUnrecognised = True
        Me.ucrInputPercentiles.IsReadOnly = False
        Me.ucrInputPercentiles.Location = New System.Drawing.Point(111, 115)
        Me.ucrInputPercentiles.Name = "ucrInputPercentiles"
        Me.ucrInputPercentiles.Size = New System.Drawing.Size(118, 21)
        Me.ucrInputPercentiles.TabIndex = 21
        '
        'ucrInputNumbers
        '
        Me.ucrInputNumbers.AddQuotesIfUnrecognised = True
        Me.ucrInputNumbers.IsMultiline = False
        Me.ucrInputNumbers.IsReadOnly = False
        Me.ucrInputNumbers.Location = New System.Drawing.Point(326, 115)
        Me.ucrInputNumbers.Name = "ucrInputNumbers"
        Me.ucrInputNumbers.Size = New System.Drawing.Size(62, 21)
        Me.ucrInputNumbers.TabIndex = 22
        '
        'ucrInputProportions
        '
        Me.ucrInputProportions.AddQuotesIfUnrecognised = True
        Me.ucrInputProportions.IsReadOnly = False
        Me.ucrInputProportions.Location = New System.Drawing.Point(258, 115)
        Me.ucrInputProportions.Name = "ucrInputProportions"
        Me.ucrInputProportions.Size = New System.Drawing.Size(62, 21)
        Me.ucrInputProportions.TabIndex = 23
        '
        'ucrChkPercentages
        '
        Me.ucrChkPercentages.Checked = False
        Me.ucrChkPercentages.Location = New System.Drawing.Point(258, 151)
        Me.ucrChkPercentages.Name = "ucrChkPercentages"
        Me.ucrChkPercentages.Size = New System.Drawing.Size(137, 20)
        Me.ucrChkPercentages.TabIndex = 24
        '
        'ucrNudValue
        '
        Me.ucrNudValue.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudValue.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudValue.Location = New System.Drawing.Point(27, 142)
        Me.ucrNudValue.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudValue.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudValue.Name = "ucrNudValue"
        Me.ucrNudValue.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudValue.TabIndex = 25
        Me.ucrNudValue.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrBaseSdgClimaticSummary
        '
        Me.ucrBaseSdgClimaticSummary.Location = New System.Drawing.Point(132, 185)
        Me.ucrBaseSdgClimaticSummary.Name = "ucrBaseSdgClimaticSummary"
        Me.ucrBaseSdgClimaticSummary.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSdgClimaticSummary.TabIndex = 26
        '
        'sdgClimaticSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 227)
        Me.Controls.Add(Me.ucrBaseSdgClimaticSummary)
        Me.Controls.Add(Me.ucrNudValue)
        Me.Controls.Add(Me.ucrChkPercentages)
        Me.Controls.Add(Me.ucrInputProportions)
        Me.Controls.Add(Me.ucrInputNumbers)
        Me.Controls.Add(Me.ucrInputPercentiles)
        Me.Controls.Add(Me.ucrInputOptions)
        Me.Controls.Add(Me.rdoProportions)
        Me.Controls.Add(Me.rdoMaxima)
        Me.Controls.Add(Me.rdoStd)
        Me.Controls.Add(Me.rdoMedians)
        Me.Controls.Add(Me.rdoPercentiles)
        Me.Controls.Add(Me.rdoMeans)
        Me.Controls.Add(Me.rdoMinima)
        Me.Controls.Add(Me.rdoMissing)
        Me.Controls.Add(Me.rdoCounts)
        Me.Controls.Add(Me.rdoTotals)
        Me.Controls.Add(Me.ucrPnlSummary)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgClimaticSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Climatic Summary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents ucrInputOptions As ucrInputComboBox
    Friend WithEvents ucrInputPercentiles As ucrInputComboBox
    Friend WithEvents ucrInputNumbers As ucrInputTextBox
    Friend WithEvents ucrInputProportions As ucrInputComboBox
    Friend WithEvents ucrChkPercentages As ucrCheck
    Friend WithEvents ucrNudValue As ucrNud
    Friend WithEvents ucrBaseSdgClimaticSummary As ucrButtonsSubdialogue
End Class
