<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgBoxplot
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
        Me.ucrBase = New instat.ucrButtons()
        Me.lblYVarToPlot = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.chkVariableWidth = New System.Windows.Forms.CheckBox()
        Me.chkHorizontalBoxplot = New System.Windows.Forms.CheckBox()
        Me.chkNotchedBoxplot = New System.Windows.Forms.CheckBox()
        Me.ucrByFactorsReceiver = New instat.ucrReceiverSingle()
        Me.lblByFactors = New System.Windows.Forms.Label()
        Me.ucrSelectorBoxPlot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSecondFactorReceiver = New instat.ucrReceiverSingle()
        Me.lblBySecondFactor = New System.Windows.Forms.Label()
        Me.ucrYvariableReceiver = New instat.ucrReceiverSingle()
        Me.cmdBoxPlotOptions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(0, 312)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 51)
        Me.ucrBase.TabIndex = 4
        '
        'lblYVarToPlot
        '
        Me.lblYVarToPlot.AutoSize = True
        Me.lblYVarToPlot.Location = New System.Drawing.Point(271, 58)
        Me.lblYVarToPlot.Name = "lblYVarToPlot"
        Me.lblYVarToPlot.Size = New System.Drawing.Size(91, 13)
        Me.lblYVarToPlot.TabIndex = 11
        Me.lblYVarToPlot.Tag = "Y_variables_to_plot"
        Me.lblYVarToPlot.Text = "Y variables to plot"
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(276, 208)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdOptions.TabIndex = 14
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'chkVariableWidth
        '
        Me.chkVariableWidth.AutoSize = True
        Me.chkVariableWidth.Location = New System.Drawing.Point(12, 228)
        Me.chkVariableWidth.Name = "chkVariableWidth"
        Me.chkVariableWidth.Size = New System.Drawing.Size(92, 17)
        Me.chkVariableWidth.TabIndex = 15
        Me.chkVariableWidth.Tag = "Variable_width"
        Me.chkVariableWidth.Text = "Variable width"
        Me.chkVariableWidth.UseVisualStyleBackColor = True
        '
        'chkHorizontalBoxplot
        '
        Me.chkHorizontalBoxplot.AutoSize = True
        Me.chkHorizontalBoxplot.Location = New System.Drawing.Point(12, 259)
        Me.chkHorizontalBoxplot.Name = "chkHorizontalBoxplot"
        Me.chkHorizontalBoxplot.Size = New System.Drawing.Size(110, 17)
        Me.chkHorizontalBoxplot.TabIndex = 16
        Me.chkHorizontalBoxplot.Tag = "Horizontal_boxplot"
        Me.chkHorizontalBoxplot.Text = "Horizontal boxplot"
        Me.chkHorizontalBoxplot.UseVisualStyleBackColor = True
        '
        'chkNotchedBoxplot
        '
        Me.chkNotchedBoxplot.AutoSize = True
        Me.chkNotchedBoxplot.Location = New System.Drawing.Point(12, 288)
        Me.chkNotchedBoxplot.Name = "chkNotchedBoxplot"
        Me.chkNotchedBoxplot.Size = New System.Drawing.Size(104, 17)
        Me.chkNotchedBoxplot.TabIndex = 17
        Me.chkNotchedBoxplot.Tag = "Notched_boxplot"
        Me.chkNotchedBoxplot.Text = "Notched boxplot"
        Me.chkNotchedBoxplot.UseVisualStyleBackColor = True
        '
        'ucrByFactorsReceiver
        '
        Me.ucrByFactorsReceiver.Location = New System.Drawing.Point(276, 120)
        Me.ucrByFactorsReceiver.Name = "ucrByFactorsReceiver"
        Me.ucrByFactorsReceiver.Size = New System.Drawing.Size(126, 26)
        Me.ucrByFactorsReceiver.TabIndex = 19
        '
        'lblByFactors
        '
        Me.lblByFactors.AutoSize = True
        Me.lblByFactors.Location = New System.Drawing.Point(278, 104)
        Me.lblByFactors.Name = "lblByFactors"
        Me.lblByFactors.Size = New System.Drawing.Size(60, 13)
        Me.lblByFactors.TabIndex = 20
        Me.lblByFactors.Tag = "By_factor_s_"
        Me.lblByFactors.Text = "By factor(s)"
        '
        'ucrSelectorBoxPlot
        '
        Me.ucrSelectorBoxPlot.Location = New System.Drawing.Point(12, 9)
        Me.ucrSelectorBoxPlot.Name = "ucrSelectorBoxPlot"
        Me.ucrSelectorBoxPlot.Size = New System.Drawing.Size(230, 215)
        Me.ucrSelectorBoxPlot.TabIndex = 21
        '
        'ucrSecondFactorReceiver
        '
        Me.ucrSecondFactorReceiver.Location = New System.Drawing.Point(276, 176)
        Me.ucrSecondFactorReceiver.Name = "ucrSecondFactorReceiver"
        Me.ucrSecondFactorReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrSecondFactorReceiver.TabIndex = 22
        '
        'lblBySecondFactor
        '
        Me.lblBySecondFactor.AutoSize = True
        Me.lblBySecondFactor.Location = New System.Drawing.Point(278, 158)
        Me.lblBySecondFactor.Name = "lblBySecondFactor"
        Me.lblBySecondFactor.Size = New System.Drawing.Size(92, 13)
        Me.lblBySecondFactor.TabIndex = 20
        Me.lblBySecondFactor.Tag = "By_Second_Factor"
        Me.lblBySecondFactor.Text = "By Second Factor"
        '
        'ucrYvariableReceiver
        '
        Me.ucrYvariableReceiver.Location = New System.Drawing.Point(276, 75)
        Me.ucrYvariableReceiver.Name = "ucrYvariableReceiver"
        Me.ucrYvariableReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrYvariableReceiver.TabIndex = 23
        '
        'cmdBoxPlotOptions
        '
        Me.cmdBoxPlotOptions.Location = New System.Drawing.Point(276, 238)
        Me.cmdBoxPlotOptions.Name = "cmdBoxPlotOptions"
        Me.cmdBoxPlotOptions.Size = New System.Drawing.Size(104, 23)
        Me.cmdBoxPlotOptions.TabIndex = 24
        Me.cmdBoxPlotOptions.Tag = "BoxPlot_Options"
        Me.cmdBoxPlotOptions.Text = "BoxPlot Options"
        Me.cmdBoxPlotOptions.UseVisualStyleBackColor = True
        '
        'dlgBoxplot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 368)
        Me.Controls.Add(Me.cmdBoxPlotOptions)
        Me.Controls.Add(Me.ucrYvariableReceiver)
        Me.Controls.Add(Me.ucrSecondFactorReceiver)
        Me.Controls.Add(Me.ucrSelectorBoxPlot)
        Me.Controls.Add(Me.lblBySecondFactor)
        Me.Controls.Add(Me.lblByFactors)
        Me.Controls.Add(Me.ucrByFactorsReceiver)
        Me.Controls.Add(Me.chkNotchedBoxplot)
        Me.Controls.Add(Me.chkHorizontalBoxplot)
        Me.Controls.Add(Me.chkVariableWidth)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblYVarToPlot)
        Me.Controls.Add(Me.ucrBase)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgBoxplot"
        Me.ShowIcon = False
        Me.Tag = "Boxplot"
        Me.Text = "Boxplot"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblYVarToPlot As Label
    Friend WithEvents cmdOptions As Button
    Friend WithEvents chkVariableWidth As CheckBox
    Friend WithEvents chkHorizontalBoxplot As CheckBox
    Friend WithEvents chkNotchedBoxplot As CheckBox
    Friend WithEvents ucrByFactorsReceiver As ucrReceiverSingle
    Friend WithEvents lblByFactors As Label
    Friend WithEvents ucrSelectorBoxPlot As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSecondFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblBySecondFactor As Label
    Friend WithEvents ucrYvariableReceiver As ucrReceiverSingle
    Friend WithEvents cmdBoxPlotOptions As Button
End Class
