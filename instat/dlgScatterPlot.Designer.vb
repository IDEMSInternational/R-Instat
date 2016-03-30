<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgScatterPlot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgScatterPlot))
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblFactorOptional = New System.Windows.Forms.Label()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.cmdScatterPlotOptions = New System.Windows.Forms.Button()
        Me.ucrFactorOptionalReceiver = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorScatterPlot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrVariablesAsFactor = New instat.ucrVariablesAsFactor()
        Me.SuspendLayout()
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(12, 189)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(133, 23)
        Me.cmdOptions.TabIndex = 7
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "General Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblFactorOptional
        '
        Me.lblFactorOptional.AutoSize = True
        Me.lblFactorOptional.Location = New System.Drawing.Point(277, 194)
        Me.lblFactorOptional.Name = "lblFactorOptional"
        Me.lblFactorOptional.Size = New System.Drawing.Size(85, 13)
        Me.lblFactorOptional.TabIndex = 5
        Me.lblFactorOptional.Tag = "Factor_Optional"
        Me.lblFactorOptional.Text = "Factor (Optional)"
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.Location = New System.Drawing.Point(273, 148)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(64, 13)
        Me.lblXVariable.TabIndex = 3
        Me.lblXVariable.Tag = "X_Variable"
        Me.lblXVariable.Text = "X  - Variable"
        '
        'cmdScatterPlotOptions
        '
        Me.cmdScatterPlotOptions.Location = New System.Drawing.Point(151, 189)
        Me.cmdScatterPlotOptions.Name = "cmdScatterPlotOptions"
        Me.cmdScatterPlotOptions.Size = New System.Drawing.Size(117, 23)
        Me.cmdScatterPlotOptions.TabIndex = 10
        Me.cmdScatterPlotOptions.Tag = "ScatterPlot_Options"
        Me.cmdScatterPlotOptions.Text = "ScatterPlot Options"
        Me.cmdScatterPlotOptions.UseVisualStyleBackColor = True
        '
        'ucrFactorOptionalReceiver
        '
        Me.ucrFactorOptionalReceiver.Location = New System.Drawing.Point(277, 210)
        Me.ucrFactorOptionalReceiver.Name = "ucrFactorOptionalReceiver"
        Me.ucrFactorOptionalReceiver.Selector = Nothing
        Me.ucrFactorOptionalReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrFactorOptionalReceiver.TabIndex = 6
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.Location = New System.Drawing.Point(274, 164)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverX.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(4, 238)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 8
        '
        'ucrSelectorScatterPlot
        '
        Me.ucrSelectorScatterPlot.Location = New System.Drawing.Point(4, 4)
        Me.ucrSelectorScatterPlot.lstVariablesInReceivers = CType(resources.GetObject("ucrSelectorScatterPlot.lstVariablesInReceivers"), System.Collections.Generic.List(Of String))
        Me.ucrSelectorScatterPlot.Name = "ucrSelectorScatterPlot"
        Me.ucrSelectorScatterPlot.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorScatterPlot.TabIndex = 11
        '
        'ucrVariablesAsFactor
        '
        Me.ucrVariablesAsFactor.Location = New System.Drawing.Point(252, 4)
        Me.ucrVariablesAsFactor.Name = "ucrVariablesAsFactor"
        Me.ucrVariablesAsFactor.Size = New System.Drawing.Size(125, 136)
        Me.ucrVariablesAsFactor.TabIndex = 12
        Me.ucrVariablesAsFactor.ucrVariableSelector = Nothing
        '
        'dlgScatterPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 292)
        Me.Controls.Add(Me.ucrVariablesAsFactor)
        Me.Controls.Add(Me.ucrSelectorScatterPlot)
        Me.Controls.Add(Me.cmdScatterPlotOptions)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrFactorOptionalReceiver)
        Me.Controls.Add(Me.lblFactorOptional)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgScatterPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scatter Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrFactorOptionalReceiver As ucrReceiverSingle
    Friend WithEvents lblFactorOptional As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents lblXVariable As Label
    Friend WithEvents cmdScatterPlotOptions As Button
    Friend WithEvents ucrSelectorScatterPlot As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrVariablesAsFactor As ucrVariablesAsFactor
End Class
