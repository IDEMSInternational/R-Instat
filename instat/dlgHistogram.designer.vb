<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgHistogram
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
        Me.UcrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrSingleReceiver = New instat.ucrReceiverSingle()
        Me.UcrBase = New instat.ucrButtons()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtHistogramTitle = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'UcrAddRemove
        '
        Me.UcrAddRemove.Location = New System.Drawing.Point(12, 12)
        Me.UcrAddRemove.Name = "UcrAddRemove"
        Me.UcrAddRemove.Size = New System.Drawing.Size(186, 129)
        Me.UcrAddRemove.TabIndex = 1
        '
        'ucrSingleReceiver
        '
        Me.ucrSingleReceiver.Location = New System.Drawing.Point(204, 33)
        Me.ucrSingleReceiver.Name = "ucrSingleReceiver"
        Me.ucrSingleReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrSingleReceiver.TabIndex = 2
        '
        'UcrBase
        '
        Me.UcrBase.Location = New System.Drawing.Point(12, 155)
        Me.UcrBase.Name = "UcrBase"
        Me.UcrBase.Size = New System.Drawing.Size(410, 32)
        Me.UcrBase.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(205, 66)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(107, 13)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Tag = "Title"
        Me.lblTitle.Text = "Title of the Histogram"
        '
        'txtHistogramTitle
        '
        Me.txtHistogramTitle.Location = New System.Drawing.Point(208, 82)
        Me.txtHistogramTitle.Name = "txtHistogramTitle"
        Me.txtHistogramTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtHistogramTitle.TabIndex = 5
        '
        'dlgHistogram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 188)
        Me.Controls.Add(Me.txtHistogramTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.UcrBase)
        Me.Controls.Add(Me.ucrSingleReceiver)
        Me.Controls.Add(Me.UcrAddRemove)
        Me.Name = "dlgHistogram"
        Me.Text = "dlgHistogram"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrSingleReceiver As ucrReceiverSingle
    Friend WithEvents UcrBase As ucrButtons
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtHistogramTitle As TextBox
End Class
