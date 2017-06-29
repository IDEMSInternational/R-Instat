<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgOneVarUseModFit
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
        Me.tbpBootstrapOptions = New System.Windows.Forms.TabPage()
        Me.ucrChkParametric = New instat.ucrCheck()
        Me.lblNumberOfIterations = New System.Windows.Forms.Label()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.ucrNudIterations = New instat.ucrNud()
        Me.ucrNudCI = New instat.ucrNud()
        Me.tbpQuantiles = New System.Windows.Forms.TabPage()
        Me.ucrInputQuantiles = New instat.ucrInputComboBox()
        Me.ucrNudBy = New instat.ucrNud()
        Me.ucrNudTo = New instat.ucrNud()
        Me.ucrNudFrom = New instat.ucrNud()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.rdoSequence = New System.Windows.Forms.RadioButton()
        Me.rdoInsertValues = New System.Windows.Forms.RadioButton()
        Me.lblBy = New System.Windows.Forms.Label()
        Me.ucrPnlQuantiles = New instat.UcrPanel()
        Me.tbpPlots = New System.Windows.Forms.TabPage()
        Me.rdoNoPlot = New System.Windows.Forms.RadioButton()
        Me.rdoPlotAll = New System.Windows.Forms.RadioButton()
        Me.rdoCDFPlot = New System.Windows.Forms.RadioButton()
        Me.rdoPPPlot = New System.Windows.Forms.RadioButton()
        Me.rdoDensityPlot = New System.Windows.Forms.RadioButton()
        Me.rdoQQPlot = New System.Windows.Forms.RadioButton()
        Me.rdoCIcdf = New System.Windows.Forms.RadioButton()
        Me.ucrPnlPlots = New instat.UcrPanel()
        Me.tbpOneVarUseModFit = New System.Windows.Forms.TabControl()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.tbpBootstrapOptions.SuspendLayout()
        Me.tbpQuantiles.SuspendLayout()
        Me.tbpPlots.SuspendLayout()
        Me.tbpOneVarUseModFit.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpBootstrapOptions
        '
        Me.tbpBootstrapOptions.Controls.Add(Me.ucrChkParametric)
        Me.tbpBootstrapOptions.Controls.Add(Me.lblNumberOfIterations)
        Me.tbpBootstrapOptions.Controls.Add(Me.lblCI)
        Me.tbpBootstrapOptions.Controls.Add(Me.ucrNudIterations)
        Me.tbpBootstrapOptions.Controls.Add(Me.ucrNudCI)
        Me.tbpBootstrapOptions.Location = New System.Drawing.Point(4, 22)
        Me.tbpBootstrapOptions.Name = "tbpBootstrapOptions"
        Me.tbpBootstrapOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpBootstrapOptions.Size = New System.Drawing.Size(241, 179)
        Me.tbpBootstrapOptions.TabIndex = 2
        Me.tbpBootstrapOptions.Text = "Bootstrap Options"
        Me.tbpBootstrapOptions.UseVisualStyleBackColor = True
        '
        'ucrChkParametric
        '
        Me.ucrChkParametric.Checked = False
        Me.ucrChkParametric.Location = New System.Drawing.Point(14, 71)
        Me.ucrChkParametric.Name = "ucrChkParametric"
        Me.ucrChkParametric.Size = New System.Drawing.Size(140, 20)
        Me.ucrChkParametric.TabIndex = 4
        '
        'lblNumberOfIterations
        '
        Me.lblNumberOfIterations.AutoSize = True
        Me.lblNumberOfIterations.Location = New System.Drawing.Point(11, 12)
        Me.lblNumberOfIterations.Name = "lblNumberOfIterations"
        Me.lblNumberOfIterations.Size = New System.Drawing.Size(105, 13)
        Me.lblNumberOfIterations.TabIndex = 0
        Me.lblNumberOfIterations.Text = "Number of Iterations:"
        '
        'lblCI
        '
        Me.lblCI.AutoSize = True
        Me.lblCI.Location = New System.Drawing.Point(11, 39)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(102, 13)
        Me.lblCI.TabIndex = 2
        Me.lblCI.Text = "Confidence Interval:"
        '
        'ucrNudIterations
        '
        Me.ucrNudIterations.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudIterations.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudIterations.Location = New System.Drawing.Point(129, 9)
        Me.ucrNudIterations.Maximum = New Decimal(New Integer() {10001, 0, 0, 0})
        Me.ucrNudIterations.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudIterations.Name = "ucrNudIterations"
        Me.ucrNudIterations.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudIterations.TabIndex = 1
        Me.ucrNudIterations.Value = New Decimal(New Integer() {1001, 0, 0, 0})
        '
        'ucrNudCI
        '
        Me.ucrNudCI.DecimalPlaces = New Decimal(New Integer() {2, 0, 0, 0})
        Me.ucrNudCI.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.ucrNudCI.Location = New System.Drawing.Point(129, 35)
        Me.ucrNudCI.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCI.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCI.Name = "ucrNudCI"
        Me.ucrNudCI.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCI.TabIndex = 3
        Me.ucrNudCI.Value = New Decimal(New Integer() {95, 0, 0, 131072})
        '
        'tbpQuantiles
        '
        Me.tbpQuantiles.Controls.Add(Me.ucrInputQuantiles)
        Me.tbpQuantiles.Controls.Add(Me.ucrNudBy)
        Me.tbpQuantiles.Controls.Add(Me.ucrNudTo)
        Me.tbpQuantiles.Controls.Add(Me.ucrNudFrom)
        Me.tbpQuantiles.Controls.Add(Me.lblFrom)
        Me.tbpQuantiles.Controls.Add(Me.lblTo)
        Me.tbpQuantiles.Controls.Add(Me.rdoSequence)
        Me.tbpQuantiles.Controls.Add(Me.rdoInsertValues)
        Me.tbpQuantiles.Controls.Add(Me.lblBy)
        Me.tbpQuantiles.Controls.Add(Me.ucrPnlQuantiles)
        Me.tbpQuantiles.Location = New System.Drawing.Point(4, 22)
        Me.tbpQuantiles.Name = "tbpQuantiles"
        Me.tbpQuantiles.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpQuantiles.Size = New System.Drawing.Size(241, 179)
        Me.tbpQuantiles.TabIndex = 1
        Me.tbpQuantiles.Text = "Quantiles"
        Me.tbpQuantiles.UseVisualStyleBackColor = True
        '
        'ucrInputQuantiles
        '
        Me.ucrInputQuantiles.AddQuotesIfUnrecognised = True
        Me.ucrInputQuantiles.IsReadOnly = False
        Me.ucrInputQuantiles.Location = New System.Drawing.Point(50, 144)
        Me.ucrInputQuantiles.Name = "ucrInputQuantiles"
        Me.ucrInputQuantiles.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputQuantiles.TabIndex = 9
        '
        'ucrNudBy
        '
        Me.ucrNudBy.DecimalPlaces = New Decimal(New Integer() {3, 0, 0, 0})
        Me.ucrNudBy.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.ucrNudBy.Location = New System.Drawing.Point(79, 91)
        Me.ucrNudBy.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBy.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.ucrNudBy.Name = "ucrNudBy"
        Me.ucrNudBy.Size = New System.Drawing.Size(53, 20)
        Me.ucrNudBy.TabIndex = 7
        Me.ucrNudBy.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'ucrNudTo
        '
        Me.ucrNudTo.DecimalPlaces = New Decimal(New Integer() {2, 0, 0, 0})
        Me.ucrNudTo.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.ucrNudTo.Location = New System.Drawing.Point(79, 65)
        Me.ucrNudTo.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Name = "ucrNudTo"
        Me.ucrNudTo.Size = New System.Drawing.Size(52, 20)
        Me.ucrNudTo.TabIndex = 5
        Me.ucrNudTo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ucrNudFrom
        '
        Me.ucrNudFrom.DecimalPlaces = New Decimal(New Integer() {2, 0, 0, 0})
        Me.ucrNudFrom.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.ucrNudFrom.Location = New System.Drawing.Point(79, 39)
        Me.ucrNudFrom.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Name = "ucrNudFrom"
        Me.ucrNudFrom.Size = New System.Drawing.Size(52, 20)
        Me.ucrNudFrom.TabIndex = 2
        Me.ucrNudFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(18, 41)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 1
        Me.lblFrom.Text = "From:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(18, 67)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 4
        Me.lblTo.Text = "To:"
        '
        'rdoSequence
        '
        Me.rdoSequence.AutoSize = True
        Me.rdoSequence.Location = New System.Drawing.Point(11, 12)
        Me.rdoSequence.Name = "rdoSequence"
        Me.rdoSequence.Size = New System.Drawing.Size(121, 17)
        Me.rdoSequence.TabIndex = 0
        Me.rdoSequence.Text = "Sequence of Values"
        Me.rdoSequence.UseVisualStyleBackColor = True
        '
        'rdoInsertValues
        '
        Me.rdoInsertValues.AutoSize = True
        Me.rdoInsertValues.Location = New System.Drawing.Point(11, 121)
        Me.rdoInsertValues.Name = "rdoInsertValues"
        Me.rdoInsertValues.Size = New System.Drawing.Size(86, 17)
        Me.rdoInsertValues.TabIndex = 8
        Me.rdoInsertValues.Text = "Insert Values"
        Me.rdoInsertValues.UseVisualStyleBackColor = True
        '
        'lblBy
        '
        Me.lblBy.AutoSize = True
        Me.lblBy.Location = New System.Drawing.Point(18, 93)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(22, 13)
        Me.lblBy.TabIndex = 6
        Me.lblBy.Text = "By:"
        '
        'ucrPnlQuantiles
        '
        Me.ucrPnlQuantiles.Location = New System.Drawing.Point(5, 12)
        Me.ucrPnlQuantiles.Name = "ucrPnlQuantiles"
        Me.ucrPnlQuantiles.Size = New System.Drawing.Size(227, 164)
        Me.ucrPnlQuantiles.TabIndex = 3
        '
        'tbpPlots
        '
        Me.tbpPlots.Controls.Add(Me.rdoNoPlot)
        Me.tbpPlots.Controls.Add(Me.rdoPlotAll)
        Me.tbpPlots.Controls.Add(Me.rdoCDFPlot)
        Me.tbpPlots.Controls.Add(Me.rdoPPPlot)
        Me.tbpPlots.Controls.Add(Me.rdoDensityPlot)
        Me.tbpPlots.Controls.Add(Me.rdoQQPlot)
        Me.tbpPlots.Controls.Add(Me.rdoCIcdf)
        Me.tbpPlots.Controls.Add(Me.ucrPnlPlots)
        Me.tbpPlots.Location = New System.Drawing.Point(4, 22)
        Me.tbpPlots.Name = "tbpPlots"
        Me.tbpPlots.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpPlots.Size = New System.Drawing.Size(241, 179)
        Me.tbpPlots.TabIndex = 0
        Me.tbpPlots.Text = "Plots"
        Me.tbpPlots.UseVisualStyleBackColor = True
        '
        'rdoNoPlot
        '
        Me.rdoNoPlot.AutoSize = True
        Me.rdoNoPlot.Location = New System.Drawing.Point(11, 12)
        Me.rdoNoPlot.Name = "rdoNoPlot"
        Me.rdoNoPlot.Size = New System.Drawing.Size(60, 17)
        Me.rdoNoPlot.TabIndex = 0
        Me.rdoNoPlot.Text = "No Plot"
        Me.rdoNoPlot.UseVisualStyleBackColor = True
        '
        'rdoPlotAll
        '
        Me.rdoPlotAll.AutoSize = True
        Me.rdoPlotAll.Location = New System.Drawing.Point(11, 35)
        Me.rdoPlotAll.Name = "rdoPlotAll"
        Me.rdoPlotAll.Size = New System.Drawing.Size(68, 17)
        Me.rdoPlotAll.TabIndex = 1
        Me.rdoPlotAll.Text = "Multi-Plot"
        Me.rdoPlotAll.UseVisualStyleBackColor = True
        '
        'rdoCDFPlot
        '
        Me.rdoCDFPlot.AutoSize = True
        Me.rdoCDFPlot.Location = New System.Drawing.Point(11, 58)
        Me.rdoCDFPlot.Name = "rdoCDFPlot"
        Me.rdoCDFPlot.Size = New System.Drawing.Size(67, 17)
        Me.rdoCDFPlot.TabIndex = 2
        Me.rdoCDFPlot.Text = "CDF Plot"
        Me.rdoCDFPlot.UseVisualStyleBackColor = True
        '
        'rdoPPPlot
        '
        Me.rdoPPPlot.AutoSize = True
        Me.rdoPPPlot.Location = New System.Drawing.Point(11, 127)
        Me.rdoPPPlot.Name = "rdoPPPlot"
        Me.rdoPPPlot.Size = New System.Drawing.Size(60, 17)
        Me.rdoPPPlot.TabIndex = 5
        Me.rdoPPPlot.Text = "PP-Plot"
        Me.rdoPPPlot.UseVisualStyleBackColor = True
        '
        'rdoDensityPlot
        '
        Me.rdoDensityPlot.AutoSize = True
        Me.rdoDensityPlot.Location = New System.Drawing.Point(11, 81)
        Me.rdoDensityPlot.Name = "rdoDensityPlot"
        Me.rdoDensityPlot.Size = New System.Drawing.Size(81, 17)
        Me.rdoDensityPlot.TabIndex = 3
        Me.rdoDensityPlot.Text = "Density Plot"
        Me.rdoDensityPlot.UseVisualStyleBackColor = True
        '
        'rdoQQPlot
        '
        Me.rdoQQPlot.AutoSize = True
        Me.rdoQQPlot.Location = New System.Drawing.Point(11, 104)
        Me.rdoQQPlot.Name = "rdoQQPlot"
        Me.rdoQQPlot.Size = New System.Drawing.Size(62, 17)
        Me.rdoQQPlot.TabIndex = 4
        Me.rdoQQPlot.Text = "QQ-Plot"
        Me.rdoQQPlot.UseVisualStyleBackColor = True
        '
        'rdoCIcdf
        '
        Me.rdoCIcdf.AutoSize = True
        Me.rdoCIcdf.Location = New System.Drawing.Point(11, 150)
        Me.rdoCIcdf.Name = "rdoCIcdf"
        Me.rdoCIcdf.Size = New System.Drawing.Size(189, 17)
        Me.rdoCIcdf.TabIndex = 6
        Me.rdoCIcdf.Text = "CDF Plot with Confidence Intervals"
        Me.rdoCIcdf.UseVisualStyleBackColor = True
        '
        'ucrPnlPlots
        '
        Me.ucrPnlPlots.Location = New System.Drawing.Point(6, 6)
        Me.ucrPnlPlots.Name = "ucrPnlPlots"
        Me.ucrPnlPlots.Size = New System.Drawing.Size(227, 165)
        Me.ucrPnlPlots.TabIndex = 0
        '
        'tbpOneVarUseModFit
        '
        Me.tbpOneVarUseModFit.Controls.Add(Me.tbpPlots)
        Me.tbpOneVarUseModFit.Controls.Add(Me.tbpQuantiles)
        Me.tbpOneVarUseModFit.Controls.Add(Me.tbpBootstrapOptions)
        Me.tbpOneVarUseModFit.Location = New System.Drawing.Point(5, 5)
        Me.tbpOneVarUseModFit.Name = "tbpOneVarUseModFit"
        Me.tbpOneVarUseModFit.SelectedIndex = 0
        Me.tbpOneVarUseModFit.Size = New System.Drawing.Size(249, 205)
        Me.tbpOneVarUseModFit.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(59, 216)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrBase.TabIndex = 0
        '
        'sdgOneVarUseModFit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 255)
        Me.Controls.Add(Me.tbpOneVarUseModFit)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneVarUseModFit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Fit Model and Bootstrap Options"
        Me.tbpBootstrapOptions.ResumeLayout(False)
        Me.tbpBootstrapOptions.PerformLayout()
        Me.tbpQuantiles.ResumeLayout(False)
        Me.tbpQuantiles.PerformLayout()
        Me.tbpPlots.ResumeLayout(False)
        Me.tbpPlots.PerformLayout()
        Me.tbpOneVarUseModFit.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents tbpBootstrapOptions As TabPage
    Friend WithEvents ucrChkParametric As ucrCheck
    Friend WithEvents ucrNudIterations As ucrNud
    Friend WithEvents ucrNudCI As ucrNud
    Friend WithEvents lblNumberOfIterations As Label
    Friend WithEvents lblCI As Label
    Friend WithEvents tbpQuantiles As TabPage
    Friend WithEvents tbpPlots As TabPage
    Friend WithEvents tbpOneVarUseModFit As TabControl
    Friend WithEvents rdoNoPlot As RadioButton
    Friend WithEvents rdoPlotAll As RadioButton
    Friend WithEvents rdoCDFPlot As RadioButton
    Friend WithEvents rdoDensityPlot As RadioButton
    Friend WithEvents rdoCIcdf As RadioButton
    Friend WithEvents rdoQQPlot As RadioButton
    Friend WithEvents rdoPPPlot As RadioButton
    Friend WithEvents ucrPnlPlots As UcrPanel
    Friend WithEvents ucrNudBy As ucrNud
    Friend WithEvents ucrNudTo As ucrNud
    Friend WithEvents ucrNudFrom As ucrNud
    Friend WithEvents rdoSequence As RadioButton
    Friend WithEvents lblBy As Label
    Friend WithEvents rdoInsertValues As RadioButton
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents ucrPnlQuantiles As UcrPanel
    Friend WithEvents ucrInputQuantiles As ucrInputComboBox
End Class
