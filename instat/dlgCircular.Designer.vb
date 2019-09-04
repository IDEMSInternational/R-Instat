<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCircular
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
        Me.ucrToCircularSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrToCircularReceiver = New instat.ucrReceiverSingle()
        Me.lblToCircular = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(25, 373)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 0
        '
        'ucrToCircularSelector
        '
        Me.ucrToCircularSelector.bDropUnusedFilterLevels = False
        Me.ucrToCircularSelector.bShowHiddenColumns = False
        Me.ucrToCircularSelector.bUseCurrentFilter = True
        Me.ucrToCircularSelector.Location = New System.Drawing.Point(9, 9)
        Me.ucrToCircularSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrToCircularSelector.Name = "ucrToCircularSelector"
        Me.ucrToCircularSelector.Size = New System.Drawing.Size(280, 222)
        Me.ucrToCircularSelector.TabIndex = 1
        '
        'ucrToCircularReceiver
        '
        Me.ucrToCircularReceiver.frmParent = Me
        Me.ucrToCircularReceiver.Location = New System.Drawing.Point(446, 119)
        Me.ucrToCircularReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrToCircularReceiver.Name = "ucrToCircularReceiver"
        Me.ucrToCircularReceiver.Selector = Nothing
        Me.ucrToCircularReceiver.Size = New System.Drawing.Size(160, 25)
        Me.ucrToCircularReceiver.strNcFilePath = ""
        Me.ucrToCircularReceiver.TabIndex = 2
        Me.ucrToCircularReceiver.ucrSelector = Nothing
        '
        'lblToCircular
        '
        Me.lblToCircular.AutoSize = True
        Me.lblToCircular.Location = New System.Drawing.Point(504, 83)
        Me.lblToCircular.Name = "lblToCircular"
        Me.lblToCircular.Size = New System.Drawing.Size(75, 17)
        Me.lblToCircular.TabIndex = 3
        Me.lblToCircular.Text = "To circular"
        '
        'dlgCircular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 450)
        Me.Controls.Add(Me.lblToCircular)
        Me.Controls.Add(Me.ucrToCircularReceiver)
        Me.Controls.Add(Me.ucrToCircularSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCircular"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Circular"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrToCircularSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrToCircularReceiver As ucrReceiverSingle
    Friend WithEvents lblToCircular As Label
End Class
