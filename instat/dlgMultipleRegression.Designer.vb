<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMultipleRegression
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
        Me.UcrSelectorAddRemove1 = New instat.ucrSelectorAddRemove()
        Me.UcrButtons1 = New instat.ucrButtons()
        Me.UcrReceiverMultiple1 = New instat.ucrReceiverMultiple()
        Me.UcrReceiverSingle1 = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'UcrSelectorAddRemove1
        '
        Me.UcrSelectorAddRemove1.Location = New System.Drawing.Point(22, 12)
        Me.UcrSelectorAddRemove1.Name = "UcrSelectorAddRemove1"
        Me.UcrSelectorAddRemove1.Size = New System.Drawing.Size(185, 131)
        Me.UcrSelectorAddRemove1.TabIndex = 3
        '
        'UcrButtons1
        '
        Me.UcrButtons1.Location = New System.Drawing.Point(12, 226)
        Me.UcrButtons1.Name = "UcrButtons1"
        Me.UcrButtons1.Size = New System.Drawing.Size(410, 32)
        Me.UcrButtons1.TabIndex = 2
        '
        'UcrReceiverMultiple1
        '
        Me.UcrReceiverMultiple1.Location = New System.Drawing.Point(239, 55)
        Me.UcrReceiverMultiple1.Name = "UcrReceiverMultiple1"
        Me.UcrReceiverMultiple1.Size = New System.Drawing.Size(98, 118)
        Me.UcrReceiverMultiple1.TabIndex = 0
        '
        'UcrReceiverSingle1
        '
        Me.UcrReceiverSingle1.Location = New System.Drawing.Point(239, 22)
        Me.UcrReceiverSingle1.Name = "UcrReceiverSingle1"
        Me.UcrReceiverSingle1.Size = New System.Drawing.Size(106, 26)
        Me.UcrReceiverSingle1.TabIndex = 4
        '
        'dlgMultipleRegression
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 274)
        Me.Controls.Add(Me.UcrReceiverSingle1)
        Me.Controls.Add(Me.UcrSelectorAddRemove1)
        Me.Controls.Add(Me.UcrButtons1)
        Me.Controls.Add(Me.UcrReceiverMultiple1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMultipleRegression"
        Me.Text = "dlgMultipleRegression"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcrReceiverMultiple1 As ucrReceiverMultiple
    Friend WithEvents UcrButtons1 As ucrButtons
    Friend WithEvents UcrSelectorAddRemove1 As ucrSelectorAddRemove
    Friend WithEvents UcrReceiverSingle1 As ucrReceiverSingle
End Class
