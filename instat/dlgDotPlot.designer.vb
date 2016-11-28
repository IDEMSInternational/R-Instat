<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDotPlot
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
        Me.cmdDotPlotOptions = New System.Windows.Forms.Button()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblOtherAxis = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.ucrVariablesAsFactorDotPlot = New instat.ucrVariablesAsFactor()
        Me.ucrSaveDotPlot = New instat.ucrSaveGraph()
        Me.ucrDotPlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrOtherAxisReceiver = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpBinAxis = New System.Windows.Forms.GroupBox()
        Me.rdoYBinAxis = New System.Windows.Forms.RadioButton()
        Me.rdoXBinAxis = New System.Windows.Forms.RadioButton()
        Me.grpBinAxis.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdDotPlotOptions
        '
        Me.cmdDotPlotOptions.Location = New System.Drawing.Point(10, 200)
        Me.cmdDotPlotOptions.Name = "cmdDotPlotOptions"
        Me.cmdDotPlotOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdDotPlotOptions.TabIndex = 7
        Me.cmdDotPlotOptions.Tag = "Dot_Plot_Options"
        Me.cmdDotPlotOptions.Text = "Dot Plot Options"
        Me.cmdDotPlotOptions.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(10, 231)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdOptions.TabIndex = 8
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblOtherAxis
        '
        Me.lblOtherAxis.AutoSize = True
        Me.lblOtherAxis.Location = New System.Drawing.Point(255, 182)
        Me.lblOtherAxis.Name = "lblOtherAxis"
        Me.lblOtherAxis.Size = New System.Drawing.Size(104, 13)
        Me.lblOtherAxis.TabIndex = 3
        Me.lblOtherAxis.Tag = "Other_Axis_(optional):"
        Me.lblOtherAxis.Text = "Other Axis (optional):"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(255, 229)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(86, 13)
        Me.lblFactor.TabIndex = 5
        Me.lblFactor.Tag = "Factor_(optional):"
        Me.lblFactor.Text = "Factor (optional):"
        '
        'ucrVariablesAsFactorDotPlot
        '
        Me.ucrVariablesAsFactorDotPlot.Location = New System.Drawing.Point(255, 43)
        Me.ucrVariablesAsFactorDotPlot.Name = "ucrVariablesAsFactorDotPlot"
        Me.ucrVariablesAsFactorDotPlot.Size = New System.Drawing.Size(125, 133)
        Me.ucrVariablesAsFactorDotPlot.TabIndex = 11
        Me.ucrVariablesAsFactorDotPlot.ucrVariableSelector = Nothing
        '
        'ucrSaveDotPlot
        '
        Me.ucrSaveDotPlot.Location = New System.Drawing.Point(10, 266)
        Me.ucrSaveDotPlot.Name = "ucrSaveDotPlot"
        Me.ucrSaveDotPlot.Size = New System.Drawing.Size(265, 20)
        Me.ucrSaveDotPlot.TabIndex = 10
        '
        'ucrDotPlotSelector
        '
        Me.ucrDotPlotSelector.bShowHiddenColumns = False
        Me.ucrDotPlotSelector.bUseCurrentFilter = True
        Me.ucrDotPlotSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrDotPlotSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDotPlotSelector.Name = "ucrDotPlotSelector"
        Me.ucrDotPlotSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrDotPlotSelector.TabIndex = 0
        '
        'ucrFactorReceiver
        '
        Me.ucrFactorReceiver.Location = New System.Drawing.Point(255, 243)
        Me.ucrFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorReceiver.Name = "ucrFactorReceiver"
        Me.ucrFactorReceiver.Selector = Nothing
        Me.ucrFactorReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrFactorReceiver.TabIndex = 6
        '
        'ucrOtherAxisReceiver
        '
        Me.ucrOtherAxisReceiver.Location = New System.Drawing.Point(255, 198)
        Me.ucrOtherAxisReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrOtherAxisReceiver.Name = "ucrOtherAxisReceiver"
        Me.ucrOtherAxisReceiver.Selector = Nothing
        Me.ucrOtherAxisReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrOtherAxisReceiver.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 292)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 9
        '
        'grpBinAxis
        '
        Me.grpBinAxis.Controls.Add(Me.rdoYBinAxis)
        Me.grpBinAxis.Controls.Add(Me.rdoXBinAxis)
        Me.grpBinAxis.Location = New System.Drawing.Point(255, 3)
        Me.grpBinAxis.Name = "grpBinAxis"
        Me.grpBinAxis.Size = New System.Drawing.Size(100, 33)
        Me.grpBinAxis.TabIndex = 15
        Me.grpBinAxis.TabStop = False
        Me.grpBinAxis.Tag = "Bin_Axis:"
        Me.grpBinAxis.Text = "Bin Axis:"
        '
        'rdoYBinAxis
        '
        Me.rdoYBinAxis.AutoSize = True
        Me.rdoYBinAxis.Location = New System.Drawing.Point(64, 13)
        Me.rdoYBinAxis.Name = "rdoYBinAxis"
        Me.rdoYBinAxis.Size = New System.Drawing.Size(30, 17)
        Me.rdoYBinAxis.TabIndex = 16
        Me.rdoYBinAxis.TabStop = True
        Me.rdoYBinAxis.Text = "y"
        Me.rdoYBinAxis.UseVisualStyleBackColor = True
        '
        'rdoXBinAxis
        '
        Me.rdoXBinAxis.AutoSize = True
        Me.rdoXBinAxis.Location = New System.Drawing.Point(28, 13)
        Me.rdoXBinAxis.Name = "rdoXBinAxis"
        Me.rdoXBinAxis.Size = New System.Drawing.Size(30, 17)
        Me.rdoXBinAxis.TabIndex = 15
        Me.rdoXBinAxis.TabStop = True
        Me.rdoXBinAxis.Text = "x"
        Me.rdoXBinAxis.UseVisualStyleBackColor = True
        '
        'dlgDotPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 350)
        Me.Controls.Add(Me.grpBinAxis)
        Me.Controls.Add(Me.ucrVariablesAsFactorDotPlot)
        Me.Controls.Add(Me.ucrSaveDotPlot)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.cmdDotPlotOptions)
        Me.Controls.Add(Me.ucrDotPlotSelector)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblOtherAxis)
        Me.Controls.Add(Me.ucrFactorReceiver)
        Me.Controls.Add(Me.ucrOtherAxisReceiver)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDotPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Dot_Plot"
        Me.Text = "Dot Plot"
        Me.grpBinAxis.ResumeLayout(False)
        Me.grpBinAxis.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDotPlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdDotPlotOptions As Button
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrOtherAxisReceiver As ucrReceiverSingle
    Friend WithEvents lblOtherAxis As Label
    Friend WithEvents ucrFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrSaveDotPlot As ucrSaveGraph
    Friend WithEvents ucrVariablesAsFactorDotPlot As ucrVariablesAsFactor
    Friend WithEvents grpBinAxis As GroupBox
    Friend WithEvents rdoYBinAxis As RadioButton
    Friend WithEvents rdoXBinAxis As RadioButton
End Class
