<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgBoxPlot
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
        Me.ucrBaseSdgBoxplot = New instat.ucrButtonsSubdialogue()
        Me.chkNotchedBoxplot = New System.Windows.Forms.CheckBox()
        Me.chkVariableWidth = New System.Windows.Forms.CheckBox()
        Me.lblNotchWidth = New System.Windows.Forms.Label()
        Me.nudNotchWidth = New System.Windows.Forms.NumericUpDown()
        Me.chkWhiskerLength = New System.Windows.Forms.CheckBox()
        Me.nudWhiskerLength = New System.Windows.Forms.NumericUpDown()
        Me.chkChangeOutliers = New System.Windows.Forms.CheckBox()
        Me.lblShape = New System.Windows.Forms.Label()
        Me.nudShape = New System.Windows.Forms.NumericUpDown()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.nudSize = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudNotchWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWhiskerLength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudShape, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBaseSdgBoxplot
        '
        Me.ucrBaseSdgBoxplot.Location = New System.Drawing.Point(32, 204)
        Me.ucrBaseSdgBoxplot.Name = "ucrBaseSdgBoxplot"
        Me.ucrBaseSdgBoxplot.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSdgBoxplot.TabIndex = 0
        '
        'chkNotchedBoxplot
        '
        Me.chkNotchedBoxplot.AutoSize = True
        Me.chkNotchedBoxplot.Location = New System.Drawing.Point(12, 72)
        Me.chkNotchedBoxplot.Name = "chkNotchedBoxplot"
        Me.chkNotchedBoxplot.Size = New System.Drawing.Size(104, 17)
        Me.chkNotchedBoxplot.TabIndex = 20
        Me.chkNotchedBoxplot.Tag = "Notched_boxplot"
        Me.chkNotchedBoxplot.Text = "Notched boxplot"
        Me.chkNotchedBoxplot.UseVisualStyleBackColor = True
        '
        'chkVariableWidth
        '
        Me.chkVariableWidth.AutoSize = True
        Me.chkVariableWidth.Location = New System.Drawing.Point(12, 25)
        Me.chkVariableWidth.Name = "chkVariableWidth"
        Me.chkVariableWidth.Size = New System.Drawing.Size(92, 17)
        Me.chkVariableWidth.TabIndex = 18
        Me.chkVariableWidth.Tag = "Variable_width"
        Me.chkVariableWidth.Text = "Variable width"
        Me.chkVariableWidth.UseVisualStyleBackColor = True
        '
        'lblNotchWidth
        '
        Me.lblNotchWidth.AutoSize = True
        Me.lblNotchWidth.Location = New System.Drawing.Point(123, 72)
        Me.lblNotchWidth.Name = "lblNotchWidth"
        Me.lblNotchWidth.Size = New System.Drawing.Size(67, 13)
        Me.lblNotchWidth.TabIndex = 21
        Me.lblNotchWidth.Text = "Notch Width"
        '
        'nudNotchWidth
        '
        Me.nudNotchWidth.DecimalPlaces = 1
        Me.nudNotchWidth.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudNotchWidth.Location = New System.Drawing.Point(208, 69)
        Me.nudNotchWidth.Maximum = New Decimal(New Integer() {9, 0, 0, 65536})
        Me.nudNotchWidth.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudNotchWidth.Name = "nudNotchWidth"
        Me.nudNotchWidth.Size = New System.Drawing.Size(44, 20)
        Me.nudNotchWidth.TabIndex = 22
        Me.nudNotchWidth.Value = New Decimal(New Integer() {5, 0, 0, 65536})
        '
        'chkWhiskerLength
        '
        Me.chkWhiskerLength.AutoSize = True
        Me.chkWhiskerLength.Location = New System.Drawing.Point(13, 108)
        Me.chkWhiskerLength.Name = "chkWhiskerLength"
        Me.chkWhiskerLength.Size = New System.Drawing.Size(101, 17)
        Me.chkWhiskerLength.TabIndex = 23
        Me.chkWhiskerLength.Text = "Whisker Length"
        Me.chkWhiskerLength.UseVisualStyleBackColor = True
        '
        'nudWhiskerLength
        '
        Me.nudWhiskerLength.DecimalPlaces = 1
        Me.nudWhiskerLength.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudWhiskerLength.Location = New System.Drawing.Point(126, 108)
        Me.nudWhiskerLength.Maximum = New Decimal(New Integer() {25, 0, 0, 65536})
        Me.nudWhiskerLength.Minimum = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.nudWhiskerLength.Name = "nudWhiskerLength"
        Me.nudWhiskerLength.Size = New System.Drawing.Size(48, 20)
        Me.nudWhiskerLength.TabIndex = 24
        Me.nudWhiskerLength.Value = New Decimal(New Integer() {15, 0, 0, 65536})
        '
        'chkChangeOutliers
        '
        Me.chkChangeOutliers.AutoSize = True
        Me.chkChangeOutliers.Location = New System.Drawing.Point(13, 141)
        Me.chkChangeOutliers.Name = "chkChangeOutliers"
        Me.chkChangeOutliers.Size = New System.Drawing.Size(101, 17)
        Me.chkChangeOutliers.TabIndex = 25
        Me.chkChangeOutliers.Text = "Change Outliers"
        Me.chkChangeOutliers.UseVisualStyleBackColor = True
        '
        'lblShape
        '
        Me.lblShape.AutoSize = True
        Me.lblShape.Location = New System.Drawing.Point(123, 144)
        Me.lblShape.Name = "lblShape"
        Me.lblShape.Size = New System.Drawing.Size(38, 13)
        Me.lblShape.TabIndex = 21
        Me.lblShape.Text = "Shape"
        '
        'nudShape
        '
        Me.nudShape.Location = New System.Drawing.Point(208, 141)
        Me.nudShape.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.nudShape.Name = "nudShape"
        Me.nudShape.Size = New System.Drawing.Size(44, 20)
        Me.nudShape.TabIndex = 22
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(123, 170)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(27, 13)
        Me.lblSize.TabIndex = 21
        Me.lblSize.Text = "Size"
        '
        'nudSize
        '
        Me.nudSize.DecimalPlaces = 1
        Me.nudSize.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudSize.Location = New System.Drawing.Point(208, 167)
        Me.nudSize.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudSize.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudSize.Name = "nudSize"
        Me.nudSize.Size = New System.Drawing.Size(44, 20)
        Me.nudSize.TabIndex = 22
        Me.nudSize.Value = New Decimal(New Integer() {5, 0, 0, 65536})
        '
        'sdgBoxPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 233)
        Me.Controls.Add(Me.chkChangeOutliers)
        Me.Controls.Add(Me.nudWhiskerLength)
        Me.Controls.Add(Me.chkWhiskerLength)
        Me.Controls.Add(Me.nudSize)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.nudShape)
        Me.Controls.Add(Me.lblShape)
        Me.Controls.Add(Me.nudNotchWidth)
        Me.Controls.Add(Me.lblNotchWidth)
        Me.Controls.Add(Me.chkNotchedBoxplot)
        Me.Controls.Add(Me.chkVariableWidth)
        Me.Controls.Add(Me.ucrBaseSdgBoxplot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgBoxPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "BoxPlot_Options"
        Me.Text = "BoxPlot Options"
        Me.TopMost = True
        CType(Me.nudNotchWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWhiskerLength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudShape, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSdgBoxplot As ucrButtonsSubdialogue
    Friend WithEvents chkNotchedBoxplot As CheckBox
    Friend WithEvents chkVariableWidth As CheckBox
    Friend WithEvents lblNotchWidth As Label
    Friend WithEvents nudNotchWidth As NumericUpDown
    Friend WithEvents chkWhiskerLength As CheckBox
    Friend WithEvents nudWhiskerLength As NumericUpDown
    Friend WithEvents chkChangeOutliers As CheckBox
    Friend WithEvents lblShape As Label
    Friend WithEvents nudShape As NumericUpDown
    Friend WithEvents lblSize As Label
    Friend WithEvents nudSize As NumericUpDown
End Class
