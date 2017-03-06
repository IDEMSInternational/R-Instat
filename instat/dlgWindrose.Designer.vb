<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgWindrose
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
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.ucrFillReceiver = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindDirection = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindSpeed = New instat.ucrReceiverSingle()
        Me.ucrSaveWindRose = New instat.ucrSaveGraph()
        Me.ucrWindRoseSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.Location = New System.Drawing.Point(256, 40)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(69, 13)
        Me.lblXVariable.TabIndex = 1
        Me.lblXVariable.Text = "Wind Speed:"
        '
        'lblYVariable
        '
        Me.lblYVariable.AutoSize = True
        Me.lblYVariable.Location = New System.Drawing.Point(257, 91)
        Me.lblYVariable.Name = "lblYVariable"
        Me.lblYVariable.Size = New System.Drawing.Size(80, 13)
        Me.lblYVariable.TabIndex = 3
        Me.lblYVariable.Text = "Wind Direction:"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Enabled = False
        Me.lblFactor.Location = New System.Drawing.Point(258, 142)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(40, 13)
        Me.lblFactor.TabIndex = 5
        Me.lblFactor.Text = "Factor:"
        '
        'ucrFillReceiver
        '
        Me.ucrFillReceiver.Enabled = False
        Me.ucrFillReceiver.frmParent = Me
        Me.ucrFillReceiver.Location = New System.Drawing.Point(255, 157)
        Me.ucrFillReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFillReceiver.Name = "ucrFillReceiver"
        Me.ucrFillReceiver.Selector = Nothing
        Me.ucrFillReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrFillReceiver.TabIndex = 6
        '
        'ucrReceiverWindDirection
        '
        Me.ucrReceiverWindDirection.frmParent = Me
        Me.ucrReceiverWindDirection.Location = New System.Drawing.Point(255, 106)
        Me.ucrReceiverWindDirection.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindDirection.Name = "ucrReceiverWindDirection"
        Me.ucrReceiverWindDirection.Selector = Nothing
        Me.ucrReceiverWindDirection.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindDirection.TabIndex = 4
        '
        'ucrReceiverWindSpeed
        '
        Me.ucrReceiverWindSpeed.frmParent = Me
        Me.ucrReceiverWindSpeed.Location = New System.Drawing.Point(255, 55)
        Me.ucrReceiverWindSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindSpeed.Name = "ucrReceiverWindSpeed"
        Me.ucrReceiverWindSpeed.Selector = Nothing
        Me.ucrReceiverWindSpeed.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindSpeed.TabIndex = 2
        '
        'ucrSaveWindRose
        '
        Me.ucrSaveWindRose.Location = New System.Drawing.Point(10, 200)
        Me.ucrSaveWindRose.Name = "ucrSaveWindRose"
        Me.ucrSaveWindRose.Size = New System.Drawing.Size(265, 20)
        Me.ucrSaveWindRose.TabIndex = 7
        '
        'ucrWindRoseSelector
        '
        Me.ucrWindRoseSelector.bShowHiddenColumns = False
        Me.ucrWindRoseSelector.bUseCurrentFilter = True
        Me.ucrWindRoseSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrWindRoseSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrWindRoseSelector.Name = "ucrWindRoseSelector"
        Me.ucrWindRoseSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrWindRoseSelector.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 226)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 8
        '
        'dlgWindrose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 287)
        Me.Controls.Add(Me.ucrFillReceiver)
        Me.Controls.Add(Me.ucrReceiverWindDirection)
        Me.Controls.Add(Me.ucrReceiverWindSpeed)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblYVariable)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.ucrSaveWindRose)
        Me.Controls.Add(Me.ucrWindRoseSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgWindrose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wind Rose"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrWindRoseSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSaveWindRose As ucrSaveGraph
    Friend WithEvents lblXVariable As Label
    Friend WithEvents ucrReceiverWindSpeed As ucrReceiverSingle
    Friend WithEvents lblYVariable As Label
    Friend WithEvents ucrReceiverWindDirection As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrFillReceiver As ucrReceiverSingle
End Class
