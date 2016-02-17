<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPlot
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
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.lblYVariable = New System.Windows.Forms.Label()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.ucrReceiverY = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.cmdPlotOptions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.Location = New System.Drawing.Point(267, 60)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(64, 13)
        Me.lblXVariable.TabIndex = 18
        Me.lblXVariable.Tag = "X_Variable"
        Me.lblXVariable.Text = "X  - Variable"
        '
        'lblYVariable
        '
        Me.lblYVariable.AutoSize = True
        Me.lblYVariable.Location = New System.Drawing.Point(267, 15)
        Me.lblYVariable.Name = "lblYVariable"
        Me.lblYVariable.Size = New System.Drawing.Size(72, 13)
        Me.lblYVariable.TabIndex = 17
        Me.lblYVariable.Tag = "Y_Variable"
        Me.lblYVariable.Text = "Y - Variable(s)"
        '
        'lblAvailable
        '
        Me.lblAvailable.AutoSize = True
        Me.lblAvailable.Location = New System.Drawing.Point(27, 15)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(0, 13)
        Me.lblAvailable.TabIndex = 16
        '
        'ucrReceiverY
        '
        Me.ucrReceiverY.Location = New System.Drawing.Point(270, 31)
        Me.ucrReceiverY.Name = "ucrReceiverY"
        Me.ucrReceiverY.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverY.TabIndex = 26
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.Location = New System.Drawing.Point(270, 76)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverX.TabIndex = 25
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(3, 190)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 27
        '
        'ucrPlotSelector
        '
        Me.ucrPlotSelector.Location = New System.Drawing.Point(3, 3)
        Me.ucrPlotSelector.Name = "ucrPlotSelector"
        Me.ucrPlotSelector.Size = New System.Drawing.Size(242, 179)
        Me.ucrPlotSelector.TabIndex = 28
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(273, 109)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdOptions.TabIndex = 29
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'cmdPlotOptions
        '
        Me.cmdPlotOptions.Location = New System.Drawing.Point(273, 139)
        Me.cmdPlotOptions.Name = "cmdPlotOptions"
        Me.cmdPlotOptions.Size = New System.Drawing.Size(103, 23)
        Me.cmdPlotOptions.TabIndex = 30
        Me.cmdPlotOptions.Tag = "Plot_Options"
        Me.cmdPlotOptions.Text = "Plot Options"
        Me.cmdPlotOptions.UseVisualStyleBackColor = True
        '
        'dlgPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 246)
        Me.Controls.Add(Me.cmdPlotOptions)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrPlotSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverY)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.lblYVariable)
        Me.Controls.Add(Me.lblAvailable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Plot"
        Me.Text = "Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblXVariable As Label
    Friend WithEvents lblYVariable As Label
    Friend WithEvents lblAvailable As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents ucrReceiverY As ucrReceiverSingle
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrPlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdOptions As Button
    Friend WithEvents cmdPlotOptions As Button
End Class
