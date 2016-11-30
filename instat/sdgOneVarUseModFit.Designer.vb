<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgOneVarUseModFit
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
        Me.tbcQuantiles = New System.Windows.Forms.TabControl()
        Me.tbcPlots = New System.Windows.Forms.TabPage()
        Me.rdoCIcdf = New System.Windows.Forms.RadioButton()
        Me.rdoPPPlot = New System.Windows.Forms.RadioButton()
        Me.rdoQQPlot = New System.Windows.Forms.RadioButton()
        Me.rdoDensityPlot = New System.Windows.Forms.RadioButton()
        Me.rdoCDFPlot = New System.Windows.Forms.RadioButton()
        Me.rdoPlotAll = New System.Windows.Forms.RadioButton()
        Me.rdoNoPlot = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ucrInputValues = New instat.ucrMultipleInput()
        Me.lblBy = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.nudBy = New System.Windows.Forms.NumericUpDown()
        Me.nudTo = New System.Windows.Forms.NumericUpDown()
        Me.nudFrom = New System.Windows.Forms.NumericUpDown()
        Me.rdoInsertValues = New System.Windows.Forms.RadioButton()
        Me.rdoSeqValues = New System.Windows.Forms.RadioButton()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.tbcQuantiles.SuspendLayout()
        Me.tbcPlots.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.nudBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcQuantiles
        '
        Me.tbcQuantiles.Controls.Add(Me.tbcPlots)
        Me.tbcQuantiles.Controls.Add(Me.TabPage2)
        Me.tbcQuantiles.Location = New System.Drawing.Point(7, 7)
        Me.tbcQuantiles.Name = "tbcQuantiles"
        Me.tbcQuantiles.SelectedIndex = 0
        Me.tbcQuantiles.Size = New System.Drawing.Size(218, 209)
        Me.tbcQuantiles.TabIndex = 0
        '
        'tbcPlots
        '
        Me.tbcPlots.Controls.Add(Me.rdoCIcdf)
        Me.tbcPlots.Controls.Add(Me.rdoPPPlot)
        Me.tbcPlots.Controls.Add(Me.rdoQQPlot)
        Me.tbcPlots.Controls.Add(Me.rdoDensityPlot)
        Me.tbcPlots.Controls.Add(Me.rdoCDFPlot)
        Me.tbcPlots.Controls.Add(Me.rdoPlotAll)
        Me.tbcPlots.Controls.Add(Me.rdoNoPlot)
        Me.tbcPlots.Location = New System.Drawing.Point(4, 22)
        Me.tbcPlots.Name = "tbcPlots"
        Me.tbcPlots.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcPlots.Size = New System.Drawing.Size(210, 183)
        Me.tbcPlots.TabIndex = 0
        Me.tbcPlots.Text = "Plots"
        Me.tbcPlots.UseVisualStyleBackColor = True
        '
        'rdoCIcdf
        '
        Me.rdoCIcdf.AutoSize = True
        Me.rdoCIcdf.Location = New System.Drawing.Point(8, 158)
        Me.rdoCIcdf.Name = "rdoCIcdf"
        Me.rdoCIcdf.Size = New System.Drawing.Size(189, 17)
        Me.rdoCIcdf.TabIndex = 6
        Me.rdoCIcdf.Text = "CDF Plot with Confidence Intervals"
        Me.rdoCIcdf.UseVisualStyleBackColor = True
        '
        'rdoPPPlot
        '
        Me.rdoPPPlot.AutoSize = True
        Me.rdoPPPlot.Location = New System.Drawing.Point(8, 135)
        Me.rdoPPPlot.Name = "rdoPPPlot"
        Me.rdoPPPlot.Size = New System.Drawing.Size(60, 17)
        Me.rdoPPPlot.TabIndex = 5
        Me.rdoPPPlot.Text = "PP-Plot"
        Me.rdoPPPlot.UseVisualStyleBackColor = True
        '
        'rdoQQPlot
        '
        Me.rdoQQPlot.AutoSize = True
        Me.rdoQQPlot.Location = New System.Drawing.Point(8, 112)
        Me.rdoQQPlot.Name = "rdoQQPlot"
        Me.rdoQQPlot.Size = New System.Drawing.Size(62, 17)
        Me.rdoQQPlot.TabIndex = 4
        Me.rdoQQPlot.Text = "QQ-Plot"
        Me.rdoQQPlot.UseVisualStyleBackColor = True
        '
        'rdoDensityPlot
        '
        Me.rdoDensityPlot.AutoSize = True
        Me.rdoDensityPlot.Location = New System.Drawing.Point(8, 89)
        Me.rdoDensityPlot.Name = "rdoDensityPlot"
        Me.rdoDensityPlot.Size = New System.Drawing.Size(81, 17)
        Me.rdoDensityPlot.TabIndex = 3
        Me.rdoDensityPlot.Text = "Density Plot"
        Me.rdoDensityPlot.UseVisualStyleBackColor = True
        '
        'rdoCDFPlot
        '
        Me.rdoCDFPlot.AutoSize = True
        Me.rdoCDFPlot.Location = New System.Drawing.Point(8, 66)
        Me.rdoCDFPlot.Name = "rdoCDFPlot"
        Me.rdoCDFPlot.Size = New System.Drawing.Size(67, 17)
        Me.rdoCDFPlot.TabIndex = 2
        Me.rdoCDFPlot.Text = "CDF Plot"
        Me.rdoCDFPlot.UseVisualStyleBackColor = True
        '
        'rdoPlotAll
        '
        Me.rdoPlotAll.AutoSize = True
        Me.rdoPlotAll.Location = New System.Drawing.Point(8, 43)
        Me.rdoPlotAll.Name = "rdoPlotAll"
        Me.rdoPlotAll.Size = New System.Drawing.Size(68, 17)
        Me.rdoPlotAll.TabIndex = 1
        Me.rdoPlotAll.Text = "Multi-Plot"
        Me.rdoPlotAll.UseVisualStyleBackColor = True
        '
        'rdoNoPlot
        '
        Me.rdoNoPlot.AutoSize = True
        Me.rdoNoPlot.Checked = True
        Me.rdoNoPlot.Location = New System.Drawing.Point(8, 20)
        Me.rdoNoPlot.Name = "rdoNoPlot"
        Me.rdoNoPlot.Size = New System.Drawing.Size(60, 17)
        Me.rdoNoPlot.TabIndex = 0
        Me.rdoNoPlot.TabStop = True
        Me.rdoNoPlot.Text = "No Plot"
        Me.rdoNoPlot.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ucrInputValues)
        Me.TabPage2.Controls.Add(Me.lblBy)
        Me.TabPage2.Controls.Add(Me.lblTo)
        Me.TabPage2.Controls.Add(Me.lblFrom)
        Me.TabPage2.Controls.Add(Me.nudBy)
        Me.TabPage2.Controls.Add(Me.nudTo)
        Me.TabPage2.Controls.Add(Me.nudFrom)
        Me.TabPage2.Controls.Add(Me.rdoInsertValues)
        Me.TabPage2.Controls.Add(Me.rdoSeqValues)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(210, 183)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Quantiles"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ucrInputValues
        '
        Me.ucrInputValues.Location = New System.Drawing.Point(5, 152)
        Me.ucrInputValues.Name = "ucrInputValues"
        Me.ucrInputValues.Size = New System.Drawing.Size(156, 29)
        Me.ucrInputValues.TabIndex = 8
        '
        'lblBy
        '
        Me.lblBy.AutoSize = True
        Me.lblBy.Location = New System.Drawing.Point(13, 96)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(22, 13)
        Me.lblBy.TabIndex = 5
        Me.lblBy.Text = "By:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(13, 69)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 3
        Me.lblTo.Text = "To:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(13, 44)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 1
        Me.lblFrom.Text = "From:"
        '
        'nudBy
        '
        Me.nudBy.DecimalPlaces = 5
        Me.nudBy.Location = New System.Drawing.Point(94, 93)
        Me.nudBy.Name = "nudBy"
        Me.nudBy.Size = New System.Drawing.Size(48, 20)
        Me.nudBy.TabIndex = 6
        Me.nudBy.Value = New Decimal(New Integer() {25, 0, 0, 131072})
        '
        'nudTo
        '
        Me.nudTo.DecimalPlaces = 5
        Me.nudTo.Location = New System.Drawing.Point(94, 67)
        Me.nudTo.Name = "nudTo"
        Me.nudTo.Size = New System.Drawing.Size(48, 20)
        Me.nudTo.TabIndex = 4
        Me.nudTo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudFrom
        '
        Me.nudFrom.DecimalPlaces = 5
        Me.nudFrom.Location = New System.Drawing.Point(94, 41)
        Me.nudFrom.Name = "nudFrom"
        Me.nudFrom.Size = New System.Drawing.Size(48, 20)
        Me.nudFrom.TabIndex = 2
        '
        'rdoInsertValues
        '
        Me.rdoInsertValues.AutoSize = True
        Me.rdoInsertValues.Location = New System.Drawing.Point(8, 134)
        Me.rdoInsertValues.Name = "rdoInsertValues"
        Me.rdoInsertValues.Size = New System.Drawing.Size(86, 17)
        Me.rdoInsertValues.TabIndex = 7
        Me.rdoInsertValues.Text = "Insert Values"
        Me.rdoInsertValues.UseVisualStyleBackColor = True
        '
        'rdoSeqValues
        '
        Me.rdoSeqValues.AutoSize = True
        Me.rdoSeqValues.Checked = True
        Me.rdoSeqValues.Location = New System.Drawing.Point(8, 20)
        Me.rdoSeqValues.Name = "rdoSeqValues"
        Me.rdoSeqValues.Size = New System.Drawing.Size(121, 17)
        Me.rdoSeqValues.TabIndex = 0
        Me.rdoSeqValues.TabStop = True
        Me.rdoSeqValues.Text = "Sequence of Values"
        Me.rdoSeqValues.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(44, 218)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrBase.TabIndex = 1
        '
        'sdgOneVarUseModFit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(229, 256)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.tbcQuantiles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneVarUseModFit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Fit Model"
        Me.tbcQuantiles.ResumeLayout(False)
        Me.tbcPlots.ResumeLayout(False)
        Me.tbcPlots.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.nudBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents tbcQuantiles As TabControl
    Friend WithEvents tbcPlots As TabPage
    Friend WithEvents rdoPPPlot As RadioButton
    Friend WithEvents rdoQQPlot As RadioButton
    Friend WithEvents rdoDensityPlot As RadioButton
    Friend WithEvents rdoCDFPlot As RadioButton
    Friend WithEvents rdoPlotAll As RadioButton
    Friend WithEvents rdoNoPlot As RadioButton
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents rdoCIcdf As RadioButton
    Friend WithEvents rdoInsertValues As RadioButton
    Friend WithEvents rdoSeqValues As RadioButton
    Friend WithEvents lblBy As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents nudBy As NumericUpDown
    Friend WithEvents nudTo As NumericUpDown
    Friend WithEvents nudFrom As NumericUpDown
    Friend WithEvents ucrInputValues As ucrMultipleInput
End Class
