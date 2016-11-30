<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgOneVarUseModBootstrap
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
        Me.chkParametric = New System.Windows.Forms.CheckBox()
        Me.nudCI = New System.Windows.Forms.NumericUpDown()
        Me.nudIterations = New System.Windows.Forms.NumericUpDown()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.UcrButtonsSubdialogue1 = New instat.ucrButtonsSubdialogue()
        Me.lblIterations = New System.Windows.Forms.Label()
        CType(Me.nudCI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIterations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkParametric
        '
        Me.chkParametric.AutoSize = True
        Me.chkParametric.Checked = True
        Me.chkParametric.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkParametric.Location = New System.Drawing.Point(13, 67)
        Me.chkParametric.Name = "chkParametric"
        Me.chkParametric.Size = New System.Drawing.Size(76, 17)
        Me.chkParametric.TabIndex = 4
        Me.chkParametric.Text = "Parametric"
        Me.chkParametric.UseVisualStyleBackColor = True
        '
        'nudCI
        '
        Me.nudCI.DecimalPlaces = 2
        Me.nudCI.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nudCI.Location = New System.Drawing.Point(120, 21)
        Me.nudCI.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCI.Name = "nudCI"
        Me.nudCI.Size = New System.Drawing.Size(54, 20)
        Me.nudCI.TabIndex = 1
        Me.nudCI.Value = New Decimal(New Integer() {95, 0, 0, 131072})
        '
        'nudIterations
        '
        Me.nudIterations.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudIterations.Location = New System.Drawing.Point(120, 43)
        Me.nudIterations.Maximum = New Decimal(New Integer() {10001, 0, 0, 0})
        Me.nudIterations.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudIterations.Name = "nudIterations"
        Me.nudIterations.Size = New System.Drawing.Size(54, 20)
        Me.nudIterations.TabIndex = 3
        Me.nudIterations.Value = New Decimal(New Integer() {1001, 0, 0, 0})
        '
        'lblCI
        '
        Me.lblCI.AutoSize = True
        Me.lblCI.Location = New System.Drawing.Point(10, 23)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(102, 13)
        Me.lblCI.TabIndex = 0
        Me.lblCI.Text = "Confidence Interval:"
        '
        'UcrButtonsSubdialogue1
        '
        Me.UcrButtonsSubdialogue1.Location = New System.Drawing.Point(12, 124)
        Me.UcrButtonsSubdialogue1.Name = "UcrButtonsSubdialogue1"
        Me.UcrButtonsSubdialogue1.Size = New System.Drawing.Size(142, 30)
        Me.UcrButtonsSubdialogue1.TabIndex = 5
        '
        'lblIterations
        '
        Me.lblIterations.AutoSize = True
        Me.lblIterations.Location = New System.Drawing.Point(10, 45)
        Me.lblIterations.Name = "lblIterations"
        Me.lblIterations.Size = New System.Drawing.Size(105, 13)
        Me.lblIterations.TabIndex = 2
        Me.lblIterations.Text = "Number of Iterations:"
        '
        'sdgOneVarUseModBootstrap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 161)
        Me.Controls.Add(Me.lblIterations)
        Me.Controls.Add(Me.UcrButtonsSubdialogue1)
        Me.Controls.Add(Me.lblCI)
        Me.Controls.Add(Me.nudIterations)
        Me.Controls.Add(Me.nudCI)
        Me.Controls.Add(Me.chkParametric)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneVarUseModBootstrap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bootstrap Options"
        CType(Me.nudCI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIterations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkParametric As CheckBox
    Friend WithEvents nudCI As NumericUpDown
    Friend WithEvents nudIterations As NumericUpDown
    Friend WithEvents lblCI As Label
    Friend WithEvents UcrButtonsSubdialogue1 As ucrButtonsSubdialogue
    Friend WithEvents lblIterations As Label
End Class
