<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgRugPlot
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
        Me.ucrSaveRugPlot = New instat.ucrSaveGraph()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.cmdRugPlotOptions = New System.Windows.Forms.Button()
        Me.ucrRugPlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrVariablesAsFactorForRugPlot = New instat.ucrVariablesAsFactor()
        Me.ucrFactorOptionalReceiver = New instat.ucrReceiverSingle()
        Me.lblFactorOptional = New System.Windows.Forms.Label()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrSaveRugPlot
        '
        Me.ucrSaveRugPlot.Location = New System.Drawing.Point(10, 264)
        Me.ucrSaveRugPlot.Name = "ucrSaveRugPlot"
        Me.ucrSaveRugPlot.Size = New System.Drawing.Size(265, 20)
        Me.ucrSaveRugPlot.TabIndex = 18
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(10, 233)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdOptions.TabIndex = 16
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'cmdRugPlotOptions
        '
        Me.cmdRugPlotOptions.Location = New System.Drawing.Point(10, 202)
        Me.cmdRugPlotOptions.Name = "cmdRugPlotOptions"
        Me.cmdRugPlotOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdRugPlotOptions.TabIndex = 15
        Me.cmdRugPlotOptions.Tag = "Rug_Plot_Options"
        Me.cmdRugPlotOptions.Text = "Rug Plot Options"
        Me.cmdRugPlotOptions.UseVisualStyleBackColor = True
        '
        'ucrRugPlotSelector
        '
        Me.ucrRugPlotSelector.bShowHiddenColumns = False
        Me.ucrRugPlotSelector.bUseCurrentFilter = True
        Me.ucrRugPlotSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrRugPlotSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrRugPlotSelector.Name = "ucrRugPlotSelector"
        Me.ucrRugPlotSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrRugPlotSelector.TabIndex = 12
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 290)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 17
        '
        'ucrVariablesAsFactorForRugPlot
        '
        Me.ucrVariablesAsFactorForRugPlot.Location = New System.Drawing.Point(273, 31)
        Me.ucrVariablesAsFactorForRugPlot.Name = "ucrVariablesAsFactorForRugPlot"
        Me.ucrVariablesAsFactorForRugPlot.Size = New System.Drawing.Size(125, 136)
        Me.ucrVariablesAsFactorForRugPlot.TabIndex = 19
        Me.ucrVariablesAsFactorForRugPlot.ucrVariableSelector = Nothing
        '
        'ucrFactorOptionalReceiver
        '
        Me.ucrFactorOptionalReceiver.Location = New System.Drawing.Point(273, 238)
        Me.ucrFactorOptionalReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorOptionalReceiver.Name = "ucrFactorOptionalReceiver"
        Me.ucrFactorOptionalReceiver.Selector = Nothing
        Me.ucrFactorOptionalReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrFactorOptionalReceiver.TabIndex = 23
        '
        'lblFactorOptional
        '
        Me.lblFactorOptional.AutoSize = True
        Me.lblFactorOptional.Location = New System.Drawing.Point(276, 224)
        Me.lblFactorOptional.Name = "lblFactorOptional"
        Me.lblFactorOptional.Size = New System.Drawing.Size(111, 13)
        Me.lblFactorOptional.TabIndex = 22
        Me.lblFactorOptional.Tag = "By_Variable_Optional:"
        Me.lblFactorOptional.Text = "By Variable (Optional):"
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.Location = New System.Drawing.Point(273, 197)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverX.TabIndex = 21
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.Location = New System.Drawing.Point(276, 183)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(58, 13)
        Me.lblXVariable.TabIndex = 20
        Me.lblXVariable.Tag = "X_Variable:"
        Me.lblXVariable.Text = "X Variable:"
        '
        'dlgRugPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 349)
        Me.Controls.Add(Me.ucrVariablesAsFactorForRugPlot)
        Me.Controls.Add(Me.ucrFactorOptionalReceiver)
        Me.Controls.Add(Me.lblFactorOptional)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.ucrSaveRugPlot)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.cmdRugPlotOptions)
        Me.Controls.Add(Me.ucrRugPlotSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRugPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rug Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrSaveRugPlot As ucrSaveGraph
    Friend WithEvents cmdOptions As Button
    Friend WithEvents cmdRugPlotOptions As Button
    Friend WithEvents ucrRugPlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrVariablesAsFactorForRugPlot As ucrVariablesAsFactor
    Friend WithEvents ucrFactorOptionalReceiver As ucrReceiverSingle
    Friend WithEvents lblFactorOptional As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents lblXVariable As Label
End Class
