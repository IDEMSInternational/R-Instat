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
        Me.rdoCIcdf = New System.Windows.Forms.RadioButton()
        Me.rdoPPPlot = New System.Windows.Forms.RadioButton()
        Me.rdoQQPlot = New System.Windows.Forms.RadioButton()
        Me.rdoDensityPlot = New System.Windows.Forms.RadioButton()
        Me.rdoCDFPlot = New System.Windows.Forms.RadioButton()
        Me.rdoPlotAll = New System.Windows.Forms.RadioButton()
        Me.rdoNoPlot = New System.Windows.Forms.RadioButton()
        Me.lblBy = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.rdoInsertValues = New System.Windows.Forms.RadioButton()
        Me.rdoSeqValues = New System.Windows.Forms.RadioButton()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.grpPlots = New System.Windows.Forms.GroupBox()
        Me.ucrPnlPlots = New instat.UcrPanel()
        Me.grpQuantiles = New System.Windows.Forms.GroupBox()
        Me.UcrInputValues = New instat.ucrInputTextBox()
        Me.ucrPnlQuantiles = New instat.UcrPanel()
        Me.nudTo = New System.Windows.Forms.NumericUpDown()
        Me.nudBy = New System.Windows.Forms.NumericUpDown()
        Me.nudFrom = New System.Windows.Forms.NumericUpDown()
        Me.grpPlots.SuspendLayout()
        Me.grpQuantiles.SuspendLayout()
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdoCIcdf
        '
        Me.rdoCIcdf.AutoSize = True
        Me.rdoCIcdf.Location = New System.Drawing.Point(6, 158)
        Me.rdoCIcdf.Name = "rdoCIcdf"
        Me.rdoCIcdf.Size = New System.Drawing.Size(189, 17)
        Me.rdoCIcdf.TabIndex = 7
        Me.rdoCIcdf.Text = "CDF Plot with Confidence Intervals"
        Me.rdoCIcdf.UseVisualStyleBackColor = True
        '
        'rdoPPPlot
        '
        Me.rdoPPPlot.AutoSize = True
        Me.rdoPPPlot.Location = New System.Drawing.Point(6, 135)
        Me.rdoPPPlot.Name = "rdoPPPlot"
        Me.rdoPPPlot.Size = New System.Drawing.Size(60, 17)
        Me.rdoPPPlot.TabIndex = 6
        Me.rdoPPPlot.Text = "PP-Plot"
        Me.rdoPPPlot.UseVisualStyleBackColor = True
        '
        'rdoQQPlot
        '
        Me.rdoQQPlot.AutoSize = True
        Me.rdoQQPlot.Location = New System.Drawing.Point(6, 112)
        Me.rdoQQPlot.Name = "rdoQQPlot"
        Me.rdoQQPlot.Size = New System.Drawing.Size(62, 17)
        Me.rdoQQPlot.TabIndex = 5
        Me.rdoQQPlot.Text = "QQ-Plot"
        Me.rdoQQPlot.UseVisualStyleBackColor = True
        '
        'rdoDensityPlot
        '
        Me.rdoDensityPlot.AutoSize = True
        Me.rdoDensityPlot.Location = New System.Drawing.Point(6, 89)
        Me.rdoDensityPlot.Name = "rdoDensityPlot"
        Me.rdoDensityPlot.Size = New System.Drawing.Size(81, 17)
        Me.rdoDensityPlot.TabIndex = 4
        Me.rdoDensityPlot.Text = "Density Plot"
        Me.rdoDensityPlot.UseVisualStyleBackColor = True
        '
        'rdoCDFPlot
        '
        Me.rdoCDFPlot.AutoSize = True
        Me.rdoCDFPlot.Location = New System.Drawing.Point(6, 66)
        Me.rdoCDFPlot.Name = "rdoCDFPlot"
        Me.rdoCDFPlot.Size = New System.Drawing.Size(67, 17)
        Me.rdoCDFPlot.TabIndex = 3
        Me.rdoCDFPlot.Text = "CDF Plot"
        Me.rdoCDFPlot.UseVisualStyleBackColor = True
        '
        'rdoPlotAll
        '
        Me.rdoPlotAll.AutoSize = True
        Me.rdoPlotAll.Location = New System.Drawing.Point(6, 43)
        Me.rdoPlotAll.Name = "rdoPlotAll"
        Me.rdoPlotAll.Size = New System.Drawing.Size(68, 17)
        Me.rdoPlotAll.TabIndex = 2
        Me.rdoPlotAll.Text = "Multi-Plot"
        Me.rdoPlotAll.UseVisualStyleBackColor = True
        '
        'rdoNoPlot
        '
        Me.rdoNoPlot.AutoSize = True
        Me.rdoNoPlot.Checked = True
        Me.rdoNoPlot.Location = New System.Drawing.Point(6, 20)
        Me.rdoNoPlot.Name = "rdoNoPlot"
        Me.rdoNoPlot.Size = New System.Drawing.Size(60, 17)
        Me.rdoNoPlot.TabIndex = 1
        Me.rdoNoPlot.TabStop = True
        Me.rdoNoPlot.Text = "No Plot"
        Me.rdoNoPlot.UseVisualStyleBackColor = True
        '
        'lblBy
        '
        Me.lblBy.AutoSize = True
        Me.lblBy.Location = New System.Drawing.Point(14, 102)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(22, 13)
        Me.lblBy.TabIndex = 6
        Me.lblBy.Text = "By:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(14, 75)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 4
        Me.lblTo.Text = "To:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(14, 50)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 2
        Me.lblFrom.Text = "From:"
        '
        'rdoInsertValues
        '
        Me.rdoInsertValues.AutoSize = True
        Me.rdoInsertValues.Location = New System.Drawing.Point(6, 130)
        Me.rdoInsertValues.Name = "rdoInsertValues"
        Me.rdoInsertValues.Size = New System.Drawing.Size(86, 17)
        Me.rdoInsertValues.TabIndex = 8
        Me.rdoInsertValues.Text = "Insert Values"
        Me.rdoInsertValues.UseVisualStyleBackColor = True
        '
        'rdoSeqValues
        '
        Me.rdoSeqValues.AutoSize = True
        Me.rdoSeqValues.Checked = True
        Me.rdoSeqValues.Location = New System.Drawing.Point(6, 20)
        Me.rdoSeqValues.Name = "rdoSeqValues"
        Me.rdoSeqValues.Size = New System.Drawing.Size(121, 17)
        Me.rdoSeqValues.TabIndex = 1
        Me.rdoSeqValues.TabStop = True
        Me.rdoSeqValues.Text = "Sequence of Values"
        Me.rdoSeqValues.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(56, 390)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrBase.TabIndex = 2
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
        Me.grpPlots.Location = New System.Drawing.Point(9, 6)
        Me.grpPlots.Name = "grpPlots"
        Me.grpPlots.Size = New System.Drawing.Size(236, 185)
        Me.grpPlots.TabIndex = 0
        Me.grpPlots.TabStop = False
        Me.grpPlots.Text = "Plots"
        '
        'ucrPnlPlots
        '
        Me.ucrPnlPlots.Location = New System.Drawing.Point(3, 19)
        Me.ucrPnlPlots.Name = "ucrPnlPlots"
        Me.ucrPnlPlots.Size = New System.Drawing.Size(227, 160)
        Me.ucrPnlPlots.TabIndex = 0
        '
        'grpQuantiles
        '
        Me.grpQuantiles.Controls.Add(Me.nudFrom)
        Me.grpQuantiles.Controls.Add(Me.nudBy)
        Me.grpQuantiles.Controls.Add(Me.nudTo)
        Me.grpQuantiles.Controls.Add(Me.UcrInputValues)
        Me.grpQuantiles.Controls.Add(Me.rdoSeqValues)
        Me.grpQuantiles.Controls.Add(Me.lblBy)
        Me.grpQuantiles.Controls.Add(Me.rdoInsertValues)
        Me.grpQuantiles.Controls.Add(Me.lblTo)
        Me.grpQuantiles.Controls.Add(Me.lblFrom)
        Me.grpQuantiles.Controls.Add(Me.ucrPnlQuantiles)
        Me.grpQuantiles.Location = New System.Drawing.Point(9, 197)
        Me.grpQuantiles.Name = "grpQuantiles"
        Me.grpQuantiles.Size = New System.Drawing.Size(236, 188)
        Me.grpQuantiles.TabIndex = 1
        Me.grpQuantiles.TabStop = False
        Me.grpQuantiles.Text = "Quantiles"
        '
        'UcrInputValues
        '
        Me.UcrInputValues.AddQuotesIfUnrecognised = True
        Me.UcrInputValues.IsMultiline = False
        Me.UcrInputValues.IsReadOnly = False
        Me.UcrInputValues.Location = New System.Drawing.Point(17, 153)
        Me.UcrInputValues.Name = "UcrInputValues"
        Me.UcrInputValues.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputValues.TabIndex = 9
        '
        'ucrPnlQuantiles
        '
        Me.ucrPnlQuantiles.Location = New System.Drawing.Point(3, 18)
        Me.ucrPnlQuantiles.Name = "ucrPnlQuantiles"
        Me.ucrPnlQuantiles.Size = New System.Drawing.Size(227, 164)
        Me.ucrPnlQuantiles.TabIndex = 0
        '
        'nudTo
        '
        Me.nudTo.Location = New System.Drawing.Point(75, 75)
        Me.nudTo.Name = "nudTo"
        Me.nudTo.Size = New System.Drawing.Size(52, 20)
        Me.nudTo.TabIndex = 11
        '
        'nudBy
        '
        Me.nudBy.Location = New System.Drawing.Point(75, 100)
        Me.nudBy.Name = "nudBy"
        Me.nudBy.Size = New System.Drawing.Size(52, 20)
        Me.nudBy.TabIndex = 12
        '
        'nudFrom
        '
        Me.nudFrom.Location = New System.Drawing.Point(75, 48)
        Me.nudFrom.Name = "nudFrom"
        Me.nudFrom.Size = New System.Drawing.Size(52, 20)
        Me.nudFrom.TabIndex = 13
        '
        'sdgOneVarUseModFit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 426)
        Me.Controls.Add(Me.grpPlots)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpQuantiles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneVarUseModFit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Fit Model"
        Me.grpPlots.ResumeLayout(False)
        Me.grpPlots.PerformLayout()
        Me.grpQuantiles.ResumeLayout(False)
        Me.grpQuantiles.PerformLayout()
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents rdoPPPlot As RadioButton
    Friend WithEvents rdoQQPlot As RadioButton
    Friend WithEvents rdoDensityPlot As RadioButton
    Friend WithEvents rdoCDFPlot As RadioButton
    Friend WithEvents rdoPlotAll As RadioButton
    Friend WithEvents rdoNoPlot As RadioButton
    Friend WithEvents rdoCIcdf As RadioButton
    Friend WithEvents rdoInsertValues As RadioButton
    Friend WithEvents rdoSeqValues As RadioButton
    Friend WithEvents lblBy As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents grpPlots As GroupBox
    Friend WithEvents grpQuantiles As GroupBox
    Friend WithEvents UcrInputValues As ucrInputTextBox
    Friend WithEvents ucrPnlPlots As UcrPanel
    Friend WithEvents ucrPnlQuantiles As UcrPanel
    Friend WithEvents nudFrom As NumericUpDown
    Friend WithEvents nudBy As NumericUpDown
    Friend WithEvents nudTo As NumericUpDown
End Class
