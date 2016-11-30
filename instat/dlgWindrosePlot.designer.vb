<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgWindrosePlot
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.ucrBase = New instat.ucrButtons()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWindroseType = New System.Windows.Forms.Label()
        Me.lblWindThreshold = New System.Windows.Forms.Label()
        Me.txtWindroseType = New System.Windows.Forms.TextBox()
        Me.nudWindThreshold = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudWindThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 171)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 67)
        Me.ucrBase.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data list not implemented"
        '
        'lblWindroseType
        '
        Me.lblWindroseType.AutoSize = True
        Me.lblWindroseType.Location = New System.Drawing.Point(35, 44)
        Me.lblWindroseType.Name = "lblWindroseType"
        Me.lblWindroseType.Size = New System.Drawing.Size(39, 13)
        Me.lblWindroseType.TabIndex = 2
        Me.lblWindroseType.Tag = "Windrose_Type"
        Me.lblWindroseType.Text = "Label2"
        '
        'lblWindThreshold
        '
        Me.lblWindThreshold.AutoSize = True
        Me.lblWindThreshold.Location = New System.Drawing.Point(35, 80)
        Me.lblWindThreshold.Name = "lblWindThreshold"
        Me.lblWindThreshold.Size = New System.Drawing.Size(39, 13)
        Me.lblWindThreshold.TabIndex = 3
        Me.lblWindThreshold.Tag = "Wind_Threshold"
        Me.lblWindThreshold.Text = "Label3"
        '
        'txtWindroseType
        '
        Me.txtWindroseType.Location = New System.Drawing.Point(133, 41)
        Me.txtWindroseType.Name = "txtWindroseType"
        Me.txtWindroseType.Size = New System.Drawing.Size(100, 20)
        Me.txtWindroseType.TabIndex = 4
        '
        'nudWindThreshold
        '
        Me.nudWindThreshold.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudWindThreshold.Location = New System.Drawing.Point(133, 80)
        Me.nudWindThreshold.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudWindThreshold.Name = "nudWindThreshold"
        Me.nudWindThreshold.Size = New System.Drawing.Size(56, 20)
        Me.nudWindThreshold.TabIndex = 5
        '
        'dlgWindrosePlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 242)
        Me.Controls.Add(Me.nudWindThreshold)
        Me.Controls.Add(Me.txtWindroseType)
        Me.Controls.Add(Me.lblWindThreshold)
        Me.Controls.Add(Me.lblWindroseType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgWindrosePlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windrose Plot"
        CType(Me.nudWindThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents Label1 As Label
    Friend WithEvents lblWindroseType As Label
    Friend WithEvents lblWindThreshold As Label
    Friend WithEvents txtWindroseType As TextBox
    Friend WithEvents nudWindThreshold As NumericUpDown
End Class