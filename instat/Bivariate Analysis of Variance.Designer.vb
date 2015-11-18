<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgBivariateAnalysisofVariance
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverSingleD = New instat.ucrReceiverSingle()
        Me.ucrReceiverSingleC = New instat.ucrReceiverSingle()
        Me.ucrReceiverSingleB = New instat.ucrReceiverSingleB()
        Me.ucrReceiverSingleA = New instat.ucrReceiverSingle()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(258, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "1st Response Variable"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(258, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "2nd Response Variable"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(258, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Treatment Factor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(258, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Blocking Factor"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(-1, 308)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 9
        '
        'ucrReceiverSingleD
        '
        Me.ucrReceiverSingleD.Location = New System.Drawing.Point(261, 203)
        Me.ucrReceiverSingleD.Name = "ucrReceiverSingleD"
        Me.ucrReceiverSingleD.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverSingleD.TabIndex = 4
        '
        'ucrReceiverSingleC
        '
        Me.ucrReceiverSingleC.Location = New System.Drawing.Point(261, 148)
        Me.ucrReceiverSingleC.Name = "ucrReceiverSingleC"
        Me.ucrReceiverSingleC.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverSingleC.TabIndex = 3
        '
        'ucrReceiverSingleB
        '
        Me.ucrReceiverSingleB.Location = New System.Drawing.Point(261, 103)
        Me.ucrReceiverSingleB.Name = "ucrReceiverSingleB"
        Me.ucrReceiverSingleB.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverSingleB.TabIndex = 2
        '
        'ucrReceiverSingleA
        '
        Me.ucrReceiverSingleA.Location = New System.Drawing.Point(261, 46)
        Me.ucrReceiverSingleA.Name = "ucrReceiverSingleA"
        Me.ucrReceiverSingleA.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverSingleA.TabIndex = 1
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(12, 47)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(182, 118)
        Me.ucrAddRemove.TabIndex = 0
        '
        'dlgBivariateAnalysisofVariance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 338)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrReceiverSingleD)
        Me.Controls.Add(Me.ucrReceiverSingleC)
        Me.Controls.Add(Me.ucrReceiverSingleB)
        Me.Controls.Add(Me.ucrReceiverSingleA)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Name = "dlgBivariateAnalysisofVariance"
        Me.Text = "Bivariate Analysis of Variance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverSingleA As ucrReceiverSingle
    Friend WithEvents ucrReceiverSingleB As ucrReceiverSingleB
    Friend WithEvents ucrReceiverSingleC As ucrReceiverSingle
    Friend WithEvents ucrReceiverSingleD As ucrReceiverSingle
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ucrBase As ucrButtons
End Class
