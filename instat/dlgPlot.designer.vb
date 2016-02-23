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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.cmdPointOptions = New System.Windows.Forms.Button()
        Me.lblFactorOptional = New System.Windows.Forms.Label()
        Me.ucrFactorOptionalReceiver = New instat.ucrReceiverSingle()
        Me.chkPoints = New System.Windows.Forms.CheckBox()
        Me.chkLines = New System.Windows.Forms.CheckBox()
        Me.cmdLineOptions = New System.Windows.Forms.Button()
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
        Me.ucrBase.Location = New System.Drawing.Point(3, 252)
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
        Me.cmdOptions.Location = New System.Drawing.Point(288, 213)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdOptions.TabIndex = 29
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'cmdPointOptions
        '
        Me.cmdPointOptions.Location = New System.Drawing.Point(12, 213)
        Me.cmdPointOptions.Name = "cmdPointOptions"
        Me.cmdPointOptions.Size = New System.Drawing.Size(103, 23)
        Me.cmdPointOptions.TabIndex = 30
        Me.cmdPointOptions.Tag = "Point_Options"
        Me.cmdPointOptions.Text = "Point Options"
        Me.cmdPointOptions.UseVisualStyleBackColor = True
        '
        'lblFactorOptional
        '
        Me.lblFactorOptional.AutoSize = True
        Me.lblFactorOptional.Location = New System.Drawing.Point(267, 116)
        Me.lblFactorOptional.Name = "lblFactorOptional"
        Me.lblFactorOptional.Size = New System.Drawing.Size(82, 13)
        Me.lblFactorOptional.TabIndex = 18
        Me.lblFactorOptional.Tag = "Factor_Optional"
        Me.lblFactorOptional.Text = "Factor(Optional)"
        '
        'ucrFactorOptionalReceiver
        '
        Me.ucrFactorOptionalReceiver.Location = New System.Drawing.Point(270, 132)
        Me.ucrFactorOptionalReceiver.Name = "ucrFactorOptionalReceiver"
        Me.ucrFactorOptionalReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrFactorOptionalReceiver.TabIndex = 25
        '
        'chkPoints
        '
        Me.chkPoints.AutoSize = True
        Me.chkPoints.Location = New System.Drawing.Point(13, 189)
        Me.chkPoints.Name = "chkPoints"
        Me.chkPoints.Size = New System.Drawing.Size(55, 17)
        Me.chkPoints.TabIndex = 31
        Me.chkPoints.Tag = "Points"
        Me.chkPoints.Text = "Points"
        Me.chkPoints.UseVisualStyleBackColor = True
        '
        'chkLines
        '
        Me.chkLines.AutoSize = True
        Me.chkLines.Location = New System.Drawing.Point(120, 190)
        Me.chkLines.Name = "chkLines"
        Me.chkLines.Size = New System.Drawing.Size(51, 17)
        Me.chkLines.TabIndex = 31
        Me.chkLines.Tag = "Lines"
        Me.chkLines.Text = "Lines"
        Me.chkLines.UseVisualStyleBackColor = True
        '
        'cmdLineOptions
        '
        Me.cmdLineOptions.Location = New System.Drawing.Point(168, 212)
        Me.cmdLineOptions.Name = "cmdLineOptions"
        Me.cmdLineOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdLineOptions.TabIndex = 32
        Me.cmdLineOptions.Tag = "Line_Options"
        Me.cmdLineOptions.Text = "Line Options"
        Me.cmdLineOptions.UseVisualStyleBackColor = True
        '
        'dlgPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 312)
        Me.Controls.Add(Me.cmdLineOptions)
        Me.Controls.Add(Me.chkLines)
        Me.Controls.Add(Me.chkPoints)
        Me.Controls.Add(Me.cmdPointOptions)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrPlotSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverY)
        Me.Controls.Add(Me.ucrFactorOptionalReceiver)
        Me.Controls.Add(Me.lblFactorOptional)
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
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrPlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdOptions As Button
    Friend WithEvents cmdPointOptions As Button
    Friend WithEvents lblFactorOptional As Label
    Friend WithEvents ucrFactorOptionalReceiver As ucrReceiverSingle
    Friend WithEvents chkPoints As CheckBox
    Friend WithEvents chkLines As CheckBox
    Friend WithEvents cmdLineOptions As Button
End Class
