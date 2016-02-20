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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrYVariableReceiver = New instat.ucrReceiverSingle()
        Me.lblYVariable = New System.Windows.Forms.Label()
        Me.ucrDotPlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.cmdDotPlotOptions = New System.Windows.Forms.Button()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrFactorReceiver = New instat.ucrReceiverSingle()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.ucrSecondfactorReceiver = New instat.ucrReceiverSingle()
        Me.lblSecondFactor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 221)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 56)
        Me.ucrBase.TabIndex = 0
        '
        'ucrYVariableReceiver
        '
        Me.ucrYVariableReceiver.Location = New System.Drawing.Point(287, 29)
        Me.ucrYVariableReceiver.Name = "ucrYVariableReceiver"
        Me.ucrYVariableReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrYVariableReceiver.TabIndex = 4
        '
        'lblYVariable
        '
        Me.lblYVariable.AutoSize = True
        Me.lblYVariable.Location = New System.Drawing.Point(287, 13)
        Me.lblYVariable.Name = "lblYVariable"
        Me.lblYVariable.Size = New System.Drawing.Size(55, 13)
        Me.lblYVariable.TabIndex = 5
        Me.lblYVariable.Tag = "Y_Variable"
        Me.lblYVariable.Text = "Y Variable"
        '
        'ucrDotPlotSelector
        '
        Me.ucrDotPlotSelector.Location = New System.Drawing.Point(6, 5)
        Me.ucrDotPlotSelector.Name = "ucrDotPlotSelector"
        Me.ucrDotPlotSelector.Size = New System.Drawing.Size(242, 179)
        Me.ucrDotPlotSelector.TabIndex = 6
        '
        'cmdDotPlotOptions
        '
        Me.cmdDotPlotOptions.Location = New System.Drawing.Point(13, 191)
        Me.cmdDotPlotOptions.Name = "cmdDotPlotOptions"
        Me.cmdDotPlotOptions.Size = New System.Drawing.Size(110, 23)
        Me.cmdDotPlotOptions.TabIndex = 7
        Me.cmdDotPlotOptions.Tag = "Dot_Plot_Options"
        Me.cmdDotPlotOptions.Text = "Dot Plot Options"
        Me.cmdDotPlotOptions.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(336, 191)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdOptions.TabIndex = 8
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrFactorReceiver
        '
        Me.ucrFactorReceiver.Location = New System.Drawing.Point(287, 74)
        Me.ucrFactorReceiver.Name = "ucrFactorReceiver"
        Me.ucrFactorReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrFactorReceiver.TabIndex = 4
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(287, 58)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(82, 13)
        Me.lblFactor.TabIndex = 5
        Me.lblFactor.Tag = "Factor_Optional"
        Me.lblFactor.Text = "Factor(Optional)"
        '
        'ucrSecondfactorReceiver
        '
        Me.ucrSecondfactorReceiver.Location = New System.Drawing.Point(287, 122)
        Me.ucrSecondfactorReceiver.Name = "ucrSecondfactorReceiver"
        Me.ucrSecondfactorReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrSecondfactorReceiver.TabIndex = 4
        '
        'lblSecondFactor
        '
        Me.lblSecondFactor.AutoSize = True
        Me.lblSecondFactor.Location = New System.Drawing.Point(287, 106)
        Me.lblSecondFactor.Name = "lblSecondFactor"
        Me.lblSecondFactor.Size = New System.Drawing.Size(122, 13)
        Me.lblSecondFactor.TabIndex = 5
        Me.lblSecondFactor.Tag = "Second_Factor_Optional"
        Me.lblSecondFactor.Text = "Second Factor(Optional)"
        '
        'dlgDotPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 285)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.cmdDotPlotOptions)
        Me.Controls.Add(Me.ucrDotPlotSelector)
        Me.Controls.Add(Me.lblSecondFactor)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblYVariable)
        Me.Controls.Add(Me.ucrSecondfactorReceiver)
        Me.Controls.Add(Me.ucrFactorReceiver)
        Me.Controls.Add(Me.ucrYVariableReceiver)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDotPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Dot_Plot"
        Me.Text = "Dot Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrYVariableReceiver As ucrReceiverSingle
    Friend WithEvents lblYVariable As Label
    Friend WithEvents ucrDotPlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdDotPlotOptions As Button
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrSecondfactorReceiver As ucrReceiverSingle
    Friend WithEvents lblSecondFactor As Label
End Class
