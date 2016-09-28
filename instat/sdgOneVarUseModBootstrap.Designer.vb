<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgOneVarUseModBootstrap
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
        Me.UcrButtonsSubdialogue1 = New instat.ucrButtonsSubdialogue()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.nudIterations = New System.Windows.Forms.NumericUpDown()
        Me.nudCI = New System.Windows.Forms.NumericUpDown()
        Me.chkParametric = New System.Windows.Forms.CheckBox()
        Me.chkIterations = New System.Windows.Forms.CheckBox()
        CType(Me.nudIterations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UcrButtonsSubdialogue1
        '
        Me.UcrButtonsSubdialogue1.Location = New System.Drawing.Point(7, 118)
        Me.UcrButtonsSubdialogue1.Name = "UcrButtonsSubdialogue1"
        Me.UcrButtonsSubdialogue1.Size = New System.Drawing.Size(142, 30)
        Me.UcrButtonsSubdialogue1.TabIndex = 12
        '
        'lblCI
        '
        Me.lblCI.AutoSize = True
        Me.lblCI.Location = New System.Drawing.Point(24, 18)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(102, 13)
        Me.lblCI.TabIndex = 11
        Me.lblCI.Text = "Confidence Interval:"
        '
        'nudIterations
        '
        Me.nudIterations.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudIterations.Location = New System.Drawing.Point(132, 37)
        Me.nudIterations.Maximum = New Decimal(New Integer() {10001, 0, 0, 0})
        Me.nudIterations.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudIterations.Name = "nudIterations"
        Me.nudIterations.Size = New System.Drawing.Size(54, 20)
        Me.nudIterations.TabIndex = 10
        Me.nudIterations.Value = New Decimal(New Integer() {1001, 0, 0, 0})
        '
        'nudCI
        '
        Me.nudCI.DecimalPlaces = 2
        Me.nudCI.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nudCI.Location = New System.Drawing.Point(132, 15)
        Me.nudCI.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCI.Name = "nudCI"
        Me.nudCI.Size = New System.Drawing.Size(54, 20)
        Me.nudCI.TabIndex = 9
        Me.nudCI.Value = New Decimal(New Integer() {95, 0, 0, 131072})
        '
        'chkParametric
        '
        Me.chkParametric.AutoSize = True
        Me.chkParametric.Checked = True
        Me.chkParametric.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkParametric.Location = New System.Drawing.Point(7, 61)
        Me.chkParametric.Name = "chkParametric"
        Me.chkParametric.Size = New System.Drawing.Size(76, 17)
        Me.chkParametric.TabIndex = 8
        Me.chkParametric.Text = "Parametric"
        Me.chkParametric.UseVisualStyleBackColor = True
        '
        'chkIterations
        '
        Me.chkIterations.AutoSize = True
        Me.chkIterations.Checked = True
        Me.chkIterations.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIterations.Location = New System.Drawing.Point(7, 38)
        Me.chkIterations.Name = "chkIterations"
        Me.chkIterations.Size = New System.Drawing.Size(124, 17)
        Me.chkIterations.TabIndex = 7
        Me.chkIterations.Text = "Number of Iterations:"
        Me.chkIterations.UseVisualStyleBackColor = True
        '
        'sdgOneVarUseModBootstrap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(189, 151)
        Me.Controls.Add(Me.UcrButtonsSubdialogue1)
        Me.Controls.Add(Me.lblCI)
        Me.Controls.Add(Me.nudIterations)
        Me.Controls.Add(Me.nudCI)
        Me.Controls.Add(Me.chkParametric)
        Me.Controls.Add(Me.chkIterations)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneVarUseModBootstrap"
        Me.Text = "Bootstrap Options"
        CType(Me.nudIterations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcrButtonsSubdialogue1 As ucrButtonsSubdialogue
    Friend WithEvents lblCI As Label
    Friend WithEvents nudIterations As NumericUpDown
    Friend WithEvents nudCI As NumericUpDown
    Friend WithEvents chkParametric As CheckBox
    Friend WithEvents chkIterations As CheckBox
End Class
