<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTwoWayAnova
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.UcrSelectorAddRemove1 = New instat.ucrSelectorAddRemove()
        Me.UcrReceiverSingle1 = New instat.ucrReceiverSingle()
        Me.UcrReciverSingleB1 = New instat.ucrReceiverSingleB()
        Me.UcrReciverSingleB2 = New instat.ucrReceiverSingleB()
        Me.UcrButtons1 = New instat.ucrButtons()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UcrSelectorAddRemove1
        '
        Me.UcrSelectorAddRemove1.Location = New System.Drawing.Point(-1, -1)
        Me.UcrSelectorAddRemove1.Name = "UcrSelectorAddRemove1"
        Me.UcrSelectorAddRemove1.Size = New System.Drawing.Size(182, 118)
        Me.UcrSelectorAddRemove1.TabIndex = 0
        '
        'UcrReceiverSingle1
        '
        Me.UcrReceiverSingle1.Location = New System.Drawing.Point(206, 24)
        Me.UcrReceiverSingle1.Name = "UcrReceiverSingle1"
        Me.UcrReceiverSingle1.Size = New System.Drawing.Size(106, 26)
        Me.UcrReceiverSingle1.TabIndex = 1
        '
        'UcrReciverSingleB1
        '
        Me.UcrReciverSingleB1.Location = New System.Drawing.Point(206, 72)
        Me.UcrReciverSingleB1.Name = "UcrReciverSingleB1"
        Me.UcrReciverSingleB1.Size = New System.Drawing.Size(106, 26)
        Me.UcrReciverSingleB1.TabIndex = 2
        '
        'UcrReciverSingleB2
        '
        Me.UcrReciverSingleB2.Location = New System.Drawing.Point(206, 120)
        Me.UcrReciverSingleB2.Name = "UcrReciverSingleB2"
        Me.UcrReciverSingleB2.Size = New System.Drawing.Size(106, 26)
        Me.UcrReciverSingleB2.TabIndex = 3
        '
        'UcrButtons1
        '
        Me.UcrButtons1.Location = New System.Drawing.Point(-1, 234)
        Me.UcrButtons1.Name = "UcrButtons1"
        Me.UcrButtons1.Size = New System.Drawing.Size(410, 32)
        Me.UcrButtons1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Counts"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Row Factor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(217, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Column Factor"
        '
        'dlgTwoWayAnova
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 261)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UcrButtons1)
        Me.Controls.Add(Me.UcrReciverSingleB2)
        Me.Controls.Add(Me.UcrReciverSingleB1)
        Me.Controls.Add(Me.UcrReceiverSingle1)
        Me.Controls.Add(Me.UcrSelectorAddRemove1)
        Me.Name = "dlgTwoWayAnova"
        Me.Text = "dlgTwoWayAnova"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcrSelectorAddRemove1 As ucrSelectorAddRemove
    Friend WithEvents UcrReceiverSingle1 As ucrReceiverSingle
    Friend WithEvents UcrReciverSingleB1 As ucrReceiverSingleB
    Friend WithEvents UcrReciverSingleB2 As ucrReceiverSingleB
    Friend WithEvents UcrButtons1 As ucrButtons
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
