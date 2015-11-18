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
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrSingleReceiver1 = New instat.ucrReceiverSingle()
        Me.ucrSingleReceiver2 = New instat.ucrReceiverSingleB()
        Me.ucrSingleReceiver3 = New instat.ucrReceiverSingleB()
        Me.UcrButtons1 = New instat.ucrButtons()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(-1, -1)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(182, 118)
        Me.ucrAddRemove.TabIndex = 0
        '
        'ucrSingleReceiver1
        '
        Me.ucrSingleReceiver1.Location = New System.Drawing.Point(206, 24)
        Me.ucrSingleReceiver1.Name = "ucrSingleReceiver1"
        Me.ucrSingleReceiver1.Size = New System.Drawing.Size(106, 26)
        Me.ucrSingleReceiver1.TabIndex = 1
        '
        'ucrSingleReceiver2
        '
        Me.ucrSingleReceiver2.Location = New System.Drawing.Point(206, 72)
        Me.ucrSingleReceiver2.Name = "ucrSingleReceiver2"
        Me.ucrSingleReceiver2.Size = New System.Drawing.Size(106, 26)
        Me.ucrSingleReceiver2.TabIndex = 2
        '
        'ucrSingleReceiver3
        '
        Me.ucrSingleReceiver3.Location = New System.Drawing.Point(206, 120)
        Me.ucrSingleReceiver3.Name = "ucrSingleReceiver3"
        Me.ucrSingleReceiver3.Size = New System.Drawing.Size(106, 26)
        Me.ucrSingleReceiver3.TabIndex = 3
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
        Me.Controls.Add(Me.ucrSingleReceiver3)
        Me.Controls.Add(Me.ucrSingleReceiver2)
        Me.Controls.Add(Me.ucrSingleReceiver1)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Name = "dlgTwoWayAnova"
        Me.Text = "Non-parametric Two Way Anova"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrSingleReceiver1 As ucrReceiverSingle
    Friend WithEvents ucrSingleReceiver2 As ucrReceiverSingleB
    Friend WithEvents ucrSingleReceiver3 As ucrReceiverSingleB
    Friend WithEvents UcrButtons1 As ucrButtons
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
