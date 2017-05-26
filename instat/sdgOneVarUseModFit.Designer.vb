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
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.tbBootstrapOptions = New System.Windows.Forms.TabPage()
        Me.grpBootStrap = New System.Windows.Forms.GroupBox()
        Me.ucrChkParametric = New instat.ucrCheck()
        Me.ucrNudIterations = New instat.ucrNud()
        Me.ucrNudCI = New instat.ucrNud()
        Me.lblNumberOfIterations = New System.Windows.Forms.Label()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.tbPlots = New System.Windows.Forms.TabPage()
        Me.grpPlots = New System.Windows.Forms.GroupBox()
        Me.rdoNoPlot = New System.Windows.Forms.RadioButton()
        Me.rdoPlotAll = New System.Windows.Forms.RadioButton()
        Me.rdoCDFPlot = New System.Windows.Forms.RadioButton()
        Me.rdoDensityPlot = New System.Windows.Forms.RadioButton()
        Me.rdoCIcdf = New System.Windows.Forms.RadioButton()
        Me.rdoQQPlot = New System.Windows.Forms.RadioButton()
        Me.rdoPPPlot = New System.Windows.Forms.RadioButton()
        Me.ucrPnlPlots = New instat.UcrPanel()
        Me.tbQuantiles = New System.Windows.Forms.TabPage()
        Me.grpQuantiles = New System.Windows.Forms.GroupBox()
        Me.ucrNudBy = New instat.ucrNud()
        Me.ucrNudTo = New instat.ucrNud()
        Me.ucrNudFrom = New instat.ucrNud()
        Me.ucrInputValues = New instat.ucrInputTextBox()
        Me.rdoSequence = New System.Windows.Forms.RadioButton()
        Me.lblBy = New System.Windows.Forms.Label()
        Me.rdoInsertValues = New System.Windows.Forms.RadioButton()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.ucrPnlQuantiles = New instat.UcrPanel()
        Me.tbOneVarUseModFit = New System.Windows.Forms.TabControl()
        Me.tbBootstrapOptions.SuspendLayout()
        Me.grpBootStrap.SuspendLayout()
        Me.tbPlots.SuspendLayout()
        Me.grpPlots.SuspendLayout()
        Me.tbQuantiles.SuspendLayout()
        Me.grpQuantiles.SuspendLayout()
        Me.tbOneVarUseModFit.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(59, 243)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrBase.TabIndex = 1
        '
        'tbBootstrapOptions
        '
        Me.tbBootstrapOptions.Controls.Add(Me.grpBootStrap)
        Me.tbBootstrapOptions.Location = New System.Drawing.Point(4, 22)
        Me.tbBootstrapOptions.Name = "tbBootstrapOptions"
        Me.tbBootstrapOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tbBootstrapOptions.Size = New System.Drawing.Size(263, 210)
        Me.tbBootstrapOptions.TabIndex = 2
        Me.tbBootstrapOptions.Text = "Bootstrap Options"
        Me.tbBootstrapOptions.UseVisualStyleBackColor = True
        '
        'grpBootStrap
        '
        Me.grpBootStrap.Controls.Add(Me.ucrChkParametric)
        Me.grpBootStrap.Controls.Add(Me.ucrNudIterations)
        Me.grpBootStrap.Controls.Add(Me.ucrNudCI)
        Me.grpBootStrap.Controls.Add(Me.lblNumberOfIterations)
        Me.grpBootStrap.Controls.Add(Me.lblCI)
        Me.grpBootStrap.Location = New System.Drawing.Point(5, 9)
        Me.grpBootStrap.Name = "grpBootStrap"
        Me.grpBootStrap.Size = New System.Drawing.Size(236, 123)
        Me.grpBootStrap.TabIndex = 0
        Me.grpBootStrap.TabStop = False
        Me.grpBootStrap.Text = "Bootstrap Options"
        '
        'ucrChkParametric
        '
        Me.ucrChkParametric.Checked = False
        Me.ucrChkParametric.Location = New System.Drawing.Point(24, 80)
        Me.ucrChkParametric.Name = "ucrChkParametric"
        Me.ucrChkParametric.Size = New System.Drawing.Size(140, 20)
        Me.ucrChkParametric.TabIndex = 4
        '
        'ucrNudIterations
        '
        Me.ucrNudIterations.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudIterations.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudIterations.Location = New System.Drawing.Point(132, 54)
        Me.ucrNudIterations.Maximum = New Decimal(New Integer() {10001, 0, 0, 0})
        Me.ucrNudIterations.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudIterations.Name = "ucrNudIterations"
        Me.ucrNudIterations.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudIterations.TabIndex = 3
        Me.ucrNudIterations.Value = New Decimal(New Integer() {1001, 0, 0, 0})
        '
        'ucrNudCI
        '
        Me.ucrNudCI.DecimalPlaces = New Decimal(New Integer() {2, 0, 0, 0})
        Me.ucrNudCI.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.ucrNudCI.Location = New System.Drawing.Point(132, 28)
        Me.ucrNudCI.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCI.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCI.Name = "ucrNudCI"
        Me.ucrNudCI.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCI.TabIndex = 1
        Me.ucrNudCI.Value = New Decimal(New Integer() {95, 0, 0, 131072})
        '
        'lblNumberOfIterations
        '
        Me.lblNumberOfIterations.AutoSize = True
        Me.lblNumberOfIterations.Location = New System.Drawing.Point(22, 58)
        Me.lblNumberOfIterations.Name = "lblNumberOfIterations"
        Me.lblNumberOfIterations.Size = New System.Drawing.Size(105, 13)
        Me.lblNumberOfIterations.TabIndex = 2
        Me.lblNumberOfIterations.Text = "Number of Iterations:"
        '
        'lblCI
        '
        Me.lblCI.AutoSize = True
        Me.lblCI.Location = New System.Drawing.Point(22, 30)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(102, 13)
        Me.lblCI.TabIndex = 0
        Me.lblCI.Text = "Confidence Interval:"
        '
        'tbPlots
        '
        Me.tbPlots.Controls.Add(Me.grpPlots)
        Me.tbPlots.Location = New System.Drawing.Point(4, 22)
        Me.tbPlots.Name = "tbPlots"
        Me.tbPlots.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPlots.Size = New System.Drawing.Size(263, 210)
        Me.tbPlots.TabIndex = 1
        Me.tbPlots.Text = "Plots"
        Me.tbPlots.UseVisualStyleBackColor = True
        '
        'grpPlots
        '
        Me.grpPlots.Controls.Add(Me.rdoNoPlot)
        Me.grpPlots.Controls.Add(Me.rdoPlotAll)
        Me.grpPlots.Controls.Add(Me.rdoCDFPlot)
        Me.grpPlots.Controls.Add(Me.rdoDensityPlot)
        Me.grpPlots.Controls.Add(Me.rdoCIcdf)
        Me.grpPlots.Controls.Add(Me.rdoQQPlot)
        Me.grpPlots.Controls.Add(Me.rdoPPPlot)
        Me.grpPlots.Controls.Add(Me.ucrPnlPlots)
        Me.grpPlots.Location = New System.Drawing.Point(13, 5)
        Me.grpPlots.Name = "grpPlots"
        Me.grpPlots.Size = New System.Drawing.Size(236, 185)
        Me.grpPlots.TabIndex = 0
        Me.grpPlots.TabStop = False
        Me.grpPlots.Text = "Plots"
        '
        'rdoNoPlot
        '
        Me.rdoNoPlot.AutoSize = True
        Me.rdoNoPlot.Checked = True
        Me.rdoNoPlot.Location = New System.Drawing.Point(6, 20)
        Me.rdoNoPlot.Name = "rdoNoPlot"
        Me.rdoNoPlot.Size = New System.Drawing.Size(60, 17)
        Me.rdoNoPlot.TabIndex = 0
        Me.rdoNoPlot.TabStop = True
        Me.rdoNoPlot.Text = "No Plot"
        Me.rdoNoPlot.UseVisualStyleBackColor = True
        '
        'rdoPlotAll
        '
        Me.rdoPlotAll.AutoSize = True
        Me.rdoPlotAll.Location = New System.Drawing.Point(6, 43)
        Me.rdoPlotAll.Name = "rdoPlotAll"
        Me.rdoPlotAll.Size = New System.Drawing.Size(68, 17)
        Me.rdoPlotAll.TabIndex = 1
        Me.rdoPlotAll.Text = "Multi-Plot"
        Me.rdoPlotAll.UseVisualStyleBackColor = True
        '
        'rdoCDFPlot
        '
        Me.rdoCDFPlot.AutoSize = True
        Me.rdoCDFPlot.Location = New System.Drawing.Point(6, 66)
        Me.rdoCDFPlot.Name = "rdoCDFPlot"
        Me.rdoCDFPlot.Size = New System.Drawing.Size(67, 17)
        Me.rdoCDFPlot.TabIndex = 2
        Me.rdoCDFPlot.Text = "CDF Plot"
        Me.rdoCDFPlot.UseVisualStyleBackColor = True
        '
        'rdoDensityPlot
        '
        Me.rdoDensityPlot.AutoSize = True
        Me.rdoDensityPlot.Location = New System.Drawing.Point(6, 89)
        Me.rdoDensityPlot.Name = "rdoDensityPlot"
        Me.rdoDensityPlot.Size = New System.Drawing.Size(81, 17)
        Me.rdoDensityPlot.TabIndex = 3
        Me.rdoDensityPlot.Text = "Density Plot"
        Me.rdoDensityPlot.UseVisualStyleBackColor = True
        '
        'rdoCIcdf
        '
        Me.rdoCIcdf.AutoSize = True
        Me.rdoCIcdf.Location = New System.Drawing.Point(6, 158)
        Me.rdoCIcdf.Name = "rdoCIcdf"
        Me.rdoCIcdf.Size = New System.Drawing.Size(189, 17)
        Me.rdoCIcdf.TabIndex = 6
        Me.rdoCIcdf.Text = "CDF Plot with Confidence Intervals"
        Me.rdoCIcdf.UseVisualStyleBackColor = True
        '
        'rdoQQPlot
        '
        Me.rdoQQPlot.AutoSize = True
        Me.rdoQQPlot.Location = New System.Drawing.Point(6, 112)
        Me.rdoQQPlot.Name = "rdoQQPlot"
        Me.rdoQQPlot.Size = New System.Drawing.Size(62, 17)
        Me.rdoQQPlot.TabIndex = 4
        Me.rdoQQPlot.Text = "QQ-Plot"
        Me.rdoQQPlot.UseVisualStyleBackColor = True
        '
        'rdoPPPlot
        '
        Me.rdoPPPlot.AutoSize = True
        Me.rdoPPPlot.Location = New System.Drawing.Point(6, 135)
        Me.rdoPPPlot.Name = "rdoPPPlot"
        Me.rdoPPPlot.Size = New System.Drawing.Size(60, 17)
        Me.rdoPPPlot.TabIndex = 5
        Me.rdoPPPlot.Text = "PP-Plot"
        Me.rdoPPPlot.UseVisualStyleBackColor = True
        '
        'ucrPnlPlots
        '
        Me.ucrPnlPlots.Location = New System.Drawing.Point(3, 19)
        Me.ucrPnlPlots.Name = "ucrPnlPlots"
        Me.ucrPnlPlots.Size = New System.Drawing.Size(227, 160)
        Me.ucrPnlPlots.TabIndex = 0
        '
        'tbQuantiles
        '
        Me.tbQuantiles.Controls.Add(Me.grpQuantiles)
        Me.tbQuantiles.Location = New System.Drawing.Point(4, 22)
        Me.tbQuantiles.Name = "tbQuantiles"
        Me.tbQuantiles.Padding = New System.Windows.Forms.Padding(3)
        Me.tbQuantiles.Size = New System.Drawing.Size(263, 210)
        Me.tbQuantiles.TabIndex = 0
        Me.tbQuantiles.Text = "Quantiles"
        Me.tbQuantiles.UseVisualStyleBackColor = True
        '
        'grpQuantiles
        '
        Me.grpQuantiles.Controls.Add(Me.ucrNudBy)
        Me.grpQuantiles.Controls.Add(Me.ucrNudTo)
        Me.grpQuantiles.Controls.Add(Me.ucrNudFrom)
        Me.grpQuantiles.Controls.Add(Me.ucrInputValues)
        Me.grpQuantiles.Controls.Add(Me.rdoSequence)
        Me.grpQuantiles.Controls.Add(Me.lblBy)
        Me.grpQuantiles.Controls.Add(Me.rdoInsertValues)
        Me.grpQuantiles.Controls.Add(Me.lblTo)
        Me.grpQuantiles.Controls.Add(Me.lblFrom)
        Me.grpQuantiles.Controls.Add(Me.ucrPnlQuantiles)
        Me.grpQuantiles.Location = New System.Drawing.Point(9, 7)
        Me.grpQuantiles.Name = "grpQuantiles"
        Me.grpQuantiles.Size = New System.Drawing.Size(236, 188)
        Me.grpQuantiles.TabIndex = 0
        Me.grpQuantiles.TabStop = False
        Me.grpQuantiles.Text = "Quantiles"
        '
        'ucrNudBy
        '
        Me.ucrNudBy.DecimalPlaces = New Decimal(New Integer() {2, 0, 0, 0})
        Me.ucrNudBy.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.ucrNudBy.Location = New System.Drawing.Point(75, 100)
        Me.ucrNudBy.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBy.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.ucrNudBy.Name = "ucrNudBy"
        Me.ucrNudBy.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudBy.TabIndex = 8
        Me.ucrNudBy.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'ucrNudTo
        '
        Me.ucrNudTo.DecimalPlaces = New Decimal(New Integer() {2, 0, 0, 0})
        Me.ucrNudTo.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.ucrNudTo.Location = New System.Drawing.Point(75, 75)
        Me.ucrNudTo.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Name = "ucrNudTo"
        Me.ucrNudTo.Size = New System.Drawing.Size(52, 20)
        Me.ucrNudTo.TabIndex = 6
        Me.ucrNudTo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ucrNudFrom
        '
        Me.ucrNudFrom.DecimalPlaces = New Decimal(New Integer() {2, 0, 0, 0})
        Me.ucrNudFrom.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.ucrNudFrom.Location = New System.Drawing.Point(75, 48)
        Me.ucrNudFrom.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Name = "ucrNudFrom"
        Me.ucrNudFrom.Size = New System.Drawing.Size(52, 20)
        Me.ucrNudFrom.TabIndex = 4
        Me.ucrNudFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputValues
        '
        Me.ucrInputValues.AddQuotesIfUnrecognised = True
        Me.ucrInputValues.IsMultiline = False
        Me.ucrInputValues.IsReadOnly = False
        Me.ucrInputValues.Location = New System.Drawing.Point(17, 153)
        Me.ucrInputValues.Name = "ucrInputValues"
        Me.ucrInputValues.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputValues.TabIndex = 0
        '
        'rdoSequence
        '
        Me.rdoSequence.AutoSize = True
        Me.rdoSequence.Checked = True
        Me.rdoSequence.Location = New System.Drawing.Point(6, 20)
        Me.rdoSequence.Name = "rdoSequence"
        Me.rdoSequence.Size = New System.Drawing.Size(121, 17)
        Me.rdoSequence.TabIndex = 2
        Me.rdoSequence.TabStop = True
        Me.rdoSequence.Text = "Sequence of Values"
        Me.rdoSequence.UseVisualStyleBackColor = True
        '
        'lblBy
        '
        Me.lblBy.AutoSize = True
        Me.lblBy.Location = New System.Drawing.Point(14, 102)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(22, 13)
        Me.lblBy.TabIndex = 7
        Me.lblBy.Text = "By:"
        '
        'rdoInsertValues
        '
        Me.rdoInsertValues.AutoSize = True
        Me.rdoInsertValues.Location = New System.Drawing.Point(6, 130)
        Me.rdoInsertValues.Name = "rdoInsertValues"
        Me.rdoInsertValues.Size = New System.Drawing.Size(86, 17)
        Me.rdoInsertValues.TabIndex = 9
        Me.rdoInsertValues.Text = "Insert Values"
        Me.rdoInsertValues.UseVisualStyleBackColor = True
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(14, 75)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 5
        Me.lblTo.Text = "To:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(14, 50)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 3
        Me.lblFrom.Text = "From:"
        '
        'ucrPnlQuantiles
        '
        Me.ucrPnlQuantiles.Location = New System.Drawing.Point(3, 18)
        Me.ucrPnlQuantiles.Name = "ucrPnlQuantiles"
        Me.ucrPnlQuantiles.Size = New System.Drawing.Size(227, 164)
        Me.ucrPnlQuantiles.TabIndex = 1
        '
        'tbOneVarUseModFit
        '
        Me.tbOneVarUseModFit.Controls.Add(Me.tbQuantiles)
        Me.tbOneVarUseModFit.Controls.Add(Me.tbPlots)
        Me.tbOneVarUseModFit.Controls.Add(Me.tbBootstrapOptions)
        Me.tbOneVarUseModFit.Location = New System.Drawing.Point(5, 5)
        Me.tbOneVarUseModFit.Name = "tbOneVarUseModFit"
        Me.tbOneVarUseModFit.SelectedIndex = 0
        Me.tbOneVarUseModFit.Size = New System.Drawing.Size(271, 236)
        Me.tbOneVarUseModFit.TabIndex = 0
        '
        'sdgOneVarUseModFit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 276)
        Me.Controls.Add(Me.tbOneVarUseModFit)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneVarUseModFit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Fit Model and Bootstrap Options"
        Me.tbBootstrapOptions.ResumeLayout(False)
        Me.grpBootStrap.ResumeLayout(False)
        Me.grpBootStrap.PerformLayout()
        Me.tbPlots.ResumeLayout(False)
        Me.grpPlots.ResumeLayout(False)
        Me.grpPlots.PerformLayout()
        Me.tbQuantiles.ResumeLayout(False)
        Me.grpQuantiles.ResumeLayout(False)
        Me.grpQuantiles.PerformLayout()
        Me.tbOneVarUseModFit.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents tbBootstrapOptions As TabPage
    Friend WithEvents grpBootStrap As GroupBox
    Friend WithEvents ucrChkParametric As ucrCheck
    Friend WithEvents ucrNudIterations As ucrNud
    Friend WithEvents ucrNudCI As ucrNud
    Friend WithEvents lblNumberOfIterations As Label
    Friend WithEvents lblCI As Label
    Friend WithEvents tbPlots As TabPage
    Friend WithEvents grpPlots As GroupBox
    Friend WithEvents rdoNoPlot As RadioButton
    Friend WithEvents rdoPlotAll As RadioButton
    Friend WithEvents rdoCDFPlot As RadioButton
    Friend WithEvents rdoDensityPlot As RadioButton
    Friend WithEvents rdoCIcdf As RadioButton
    Friend WithEvents rdoQQPlot As RadioButton
    Friend WithEvents rdoPPPlot As RadioButton
    Friend WithEvents ucrPnlPlots As UcrPanel
    Friend WithEvents tbQuantiles As TabPage
    Friend WithEvents grpQuantiles As GroupBox
    Friend WithEvents ucrNudBy As ucrNud
    Friend WithEvents ucrNudTo As ucrNud
    Friend WithEvents ucrNudFrom As ucrNud
    Friend WithEvents ucrInputValues As ucrInputTextBox
    Friend WithEvents rdoSequence As RadioButton
    Friend WithEvents lblBy As Label
    Friend WithEvents rdoInsertValues As RadioButton
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents ucrPnlQuantiles As UcrPanel
    Friend WithEvents tbOneVarUseModFit As TabControl
End Class
