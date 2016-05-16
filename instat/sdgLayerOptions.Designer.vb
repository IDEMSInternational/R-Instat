<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgLayerOptions
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
        Me.tbcLayers = New System.Windows.Forms.TabControl()
        Me.tbpAesthetics = New System.Windows.Forms.TabPage()
        Me.ucrGeomWithAes = New instat.UcrGeomListWithParameters()
        Me.tbpGeomParameters = New System.Windows.Forms.TabPage()
        Me.grpBoxPlot = New System.Windows.Forms.GroupBox()
        Me.chkChangeOutliers = New System.Windows.Forms.CheckBox()
        Me.nudWhiskerLength = New System.Windows.Forms.NumericUpDown()
        Me.chkWhiskerLength = New System.Windows.Forms.CheckBox()
        Me.nudStroke = New System.Windows.Forms.NumericUpDown()
        Me.nudSize = New System.Windows.Forms.NumericUpDown()
        Me.lblStroke = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.nudShape = New System.Windows.Forms.NumericUpDown()
        Me.lblShape = New System.Windows.Forms.Label()
        Me.nudNotchWidth = New System.Windows.Forms.NumericUpDown()
        Me.lblNotchWidth = New System.Windows.Forms.Label()
        Me.chkNotchedBoxplot = New System.Windows.Forms.CheckBox()
        Me.chkVariableWidth = New System.Windows.Forms.CheckBox()
        Me.ucrSdgLayerBase = New instat.ucrButtonsSubdialogue()
        Me.tbcLayers.SuspendLayout()
        Me.tbpAesthetics.SuspendLayout()
        Me.tbpGeomParameters.SuspendLayout()
        Me.grpBoxPlot.SuspendLayout()
        CType(Me.nudWhiskerLength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStroke, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudShape, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNotchWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcLayers
        '
        Me.tbcLayers.Controls.Add(Me.tbpAesthetics)
        Me.tbcLayers.Controls.Add(Me.tbpGeomParameters)
        Me.tbcLayers.Location = New System.Drawing.Point(13, 13)
        Me.tbcLayers.Name = "tbcLayers"
        Me.tbcLayers.SelectedIndex = 0
        Me.tbcLayers.Size = New System.Drawing.Size(482, 335)
        Me.tbcLayers.TabIndex = 1
        '
        'tbpAesthetics
        '
        Me.tbpAesthetics.Controls.Add(Me.ucrGeomWithAes)
        Me.tbpAesthetics.Location = New System.Drawing.Point(4, 22)
        Me.tbpAesthetics.Name = "tbpAesthetics"
        Me.tbpAesthetics.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpAesthetics.Size = New System.Drawing.Size(474, 309)
        Me.tbpAesthetics.TabIndex = 0
        Me.tbpAesthetics.Text = "Layer Dimensions(Aesthetics)"
        Me.tbpAesthetics.UseVisualStyleBackColor = True
        '
        'ucrGeomWithAes
        '
        Me.ucrGeomWithAes.Location = New System.Drawing.Point(6, 6)
        Me.ucrGeomWithAes.Name = "ucrGeomWithAes"
        Me.ucrGeomWithAes.Size = New System.Drawing.Size(467, 286)
        Me.ucrGeomWithAes.TabIndex = 0
        '
        'tbpGeomParameters
        '
        Me.tbpGeomParameters.Controls.Add(Me.grpBoxPlot)
        Me.tbpGeomParameters.Location = New System.Drawing.Point(4, 22)
        Me.tbpGeomParameters.Name = "tbpGeomParameters"
        Me.tbpGeomParameters.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpGeomParameters.Size = New System.Drawing.Size(474, 309)
        Me.tbpGeomParameters.TabIndex = 1
        Me.tbpGeomParameters.Text = "Layer Parameters(Geom Parameters)"
        Me.tbpGeomParameters.UseVisualStyleBackColor = True
        '
        'grpBoxPlot
        '
        Me.grpBoxPlot.Controls.Add(Me.chkChangeOutliers)
        Me.grpBoxPlot.Controls.Add(Me.nudWhiskerLength)
        Me.grpBoxPlot.Controls.Add(Me.chkWhiskerLength)
        Me.grpBoxPlot.Controls.Add(Me.nudStroke)
        Me.grpBoxPlot.Controls.Add(Me.nudSize)
        Me.grpBoxPlot.Controls.Add(Me.lblStroke)
        Me.grpBoxPlot.Controls.Add(Me.lblSize)
        Me.grpBoxPlot.Controls.Add(Me.nudShape)
        Me.grpBoxPlot.Controls.Add(Me.lblShape)
        Me.grpBoxPlot.Controls.Add(Me.nudNotchWidth)
        Me.grpBoxPlot.Controls.Add(Me.lblNotchWidth)
        Me.grpBoxPlot.Controls.Add(Me.chkNotchedBoxplot)
        Me.grpBoxPlot.Controls.Add(Me.chkVariableWidth)
        Me.grpBoxPlot.Location = New System.Drawing.Point(6, 6)
        Me.grpBoxPlot.Name = "grpBoxPlot"
        Me.grpBoxPlot.Size = New System.Drawing.Size(267, 230)
        Me.grpBoxPlot.TabIndex = 0
        Me.grpBoxPlot.TabStop = False
        Me.grpBoxPlot.Text = "BoxPlot Parameters. "
        '
        'chkChangeOutliers
        '
        Me.chkChangeOutliers.AutoSize = True
        Me.chkChangeOutliers.Location = New System.Drawing.Point(7, 135)
        Me.chkChangeOutliers.Name = "chkChangeOutliers"
        Me.chkChangeOutliers.Size = New System.Drawing.Size(101, 17)
        Me.chkChangeOutliers.TabIndex = 36
        Me.chkChangeOutliers.Text = "Change Outliers"
        Me.chkChangeOutliers.UseVisualStyleBackColor = True
        '
        'nudWhiskerLength
        '
        Me.nudWhiskerLength.DecimalPlaces = 1
        Me.nudWhiskerLength.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudWhiskerLength.Location = New System.Drawing.Point(202, 99)
        Me.nudWhiskerLength.Maximum = New Decimal(New Integer() {25, 0, 0, 65536})
        Me.nudWhiskerLength.Minimum = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.nudWhiskerLength.Name = "nudWhiskerLength"
        Me.nudWhiskerLength.Size = New System.Drawing.Size(48, 20)
        Me.nudWhiskerLength.TabIndex = 35
        Me.nudWhiskerLength.Value = New Decimal(New Integer() {15, 0, 0, 65536})
        '
        'chkWhiskerLength
        '
        Me.chkWhiskerLength.AutoSize = True
        Me.chkWhiskerLength.Location = New System.Drawing.Point(7, 102)
        Me.chkWhiskerLength.Name = "chkWhiskerLength"
        Me.chkWhiskerLength.Size = New System.Drawing.Size(101, 17)
        Me.chkWhiskerLength.TabIndex = 34
        Me.chkWhiskerLength.Text = "Whisker Length"
        Me.chkWhiskerLength.UseVisualStyleBackColor = True
        '
        'nudStroke
        '
        Me.nudStroke.DecimalPlaces = 1
        Me.nudStroke.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudStroke.Location = New System.Drawing.Point(202, 190)
        Me.nudStroke.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudStroke.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudStroke.Name = "nudStroke"
        Me.nudStroke.Size = New System.Drawing.Size(44, 20)
        Me.nudStroke.TabIndex = 31
        Me.nudStroke.Value = New Decimal(New Integer() {5, 0, 0, 65536})
        '
        'nudSize
        '
        Me.nudSize.DecimalPlaces = 1
        Me.nudSize.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudSize.Location = New System.Drawing.Point(202, 161)
        Me.nudSize.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudSize.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudSize.Name = "nudSize"
        Me.nudSize.Size = New System.Drawing.Size(44, 20)
        Me.nudSize.TabIndex = 31
        Me.nudSize.Value = New Decimal(New Integer() {5, 0, 0, 65536})
        '
        'lblStroke
        '
        Me.lblStroke.AutoSize = True
        Me.lblStroke.Location = New System.Drawing.Point(117, 193)
        Me.lblStroke.Name = "lblStroke"
        Me.lblStroke.Size = New System.Drawing.Size(38, 13)
        Me.lblStroke.TabIndex = 28
        Me.lblStroke.Text = "Stroke"
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(117, 164)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(27, 13)
        Me.lblSize.TabIndex = 28
        Me.lblSize.Text = "Size"
        '
        'nudShape
        '
        Me.nudShape.Location = New System.Drawing.Point(202, 135)
        Me.nudShape.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.nudShape.Name = "nudShape"
        Me.nudShape.Size = New System.Drawing.Size(44, 20)
        Me.nudShape.TabIndex = 32
        '
        'lblShape
        '
        Me.lblShape.AutoSize = True
        Me.lblShape.Location = New System.Drawing.Point(117, 138)
        Me.lblShape.Name = "lblShape"
        Me.lblShape.Size = New System.Drawing.Size(38, 13)
        Me.lblShape.TabIndex = 29
        Me.lblShape.Text = "Shape"
        '
        'nudNotchWidth
        '
        Me.nudNotchWidth.DecimalPlaces = 1
        Me.nudNotchWidth.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudNotchWidth.Location = New System.Drawing.Point(202, 63)
        Me.nudNotchWidth.Maximum = New Decimal(New Integer() {9, 0, 0, 65536})
        Me.nudNotchWidth.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudNotchWidth.Name = "nudNotchWidth"
        Me.nudNotchWidth.Size = New System.Drawing.Size(44, 20)
        Me.nudNotchWidth.TabIndex = 33
        Me.nudNotchWidth.Value = New Decimal(New Integer() {5, 0, 0, 65536})
        '
        'lblNotchWidth
        '
        Me.lblNotchWidth.AutoSize = True
        Me.lblNotchWidth.Location = New System.Drawing.Point(117, 66)
        Me.lblNotchWidth.Name = "lblNotchWidth"
        Me.lblNotchWidth.Size = New System.Drawing.Size(67, 13)
        Me.lblNotchWidth.TabIndex = 30
        Me.lblNotchWidth.Text = "Notch Width"
        '
        'chkNotchedBoxplot
        '
        Me.chkNotchedBoxplot.AutoSize = True
        Me.chkNotchedBoxplot.Location = New System.Drawing.Point(6, 66)
        Me.chkNotchedBoxplot.Name = "chkNotchedBoxplot"
        Me.chkNotchedBoxplot.Size = New System.Drawing.Size(104, 17)
        Me.chkNotchedBoxplot.TabIndex = 27
        Me.chkNotchedBoxplot.Tag = "Notched_boxplot"
        Me.chkNotchedBoxplot.Text = "Notched boxplot"
        Me.chkNotchedBoxplot.UseVisualStyleBackColor = True
        '
        'chkVariableWidth
        '
        Me.chkVariableWidth.AutoSize = True
        Me.chkVariableWidth.Location = New System.Drawing.Point(6, 19)
        Me.chkVariableWidth.Name = "chkVariableWidth"
        Me.chkVariableWidth.Size = New System.Drawing.Size(92, 17)
        Me.chkVariableWidth.TabIndex = 26
        Me.chkVariableWidth.Tag = "Variable_width"
        Me.chkVariableWidth.Text = "Variable width"
        Me.chkVariableWidth.UseVisualStyleBackColor = True
        '
        'ucrSdgLayerBase
        '
        Me.ucrSdgLayerBase.Location = New System.Drawing.Point(148, 354)
        Me.ucrSdgLayerBase.Name = "ucrSdgLayerBase"
        Me.ucrSdgLayerBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrSdgLayerBase.TabIndex = 0
        '
        'sdgLayerOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 385)
        Me.Controls.Add(Me.tbcLayers)
        Me.Controls.Add(Me.ucrSdgLayerBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgLayerOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Layer Options"
        Me.tbcLayers.ResumeLayout(False)
        Me.tbpAesthetics.ResumeLayout(False)
        Me.tbpGeomParameters.ResumeLayout(False)
        Me.grpBoxPlot.ResumeLayout(False)
        Me.grpBoxPlot.PerformLayout()
        CType(Me.nudWhiskerLength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStroke, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudShape, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNotchWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSdgLayerBase As ucrButtonsSubdialogue
    Friend WithEvents tbcLayers As TabControl
    Friend WithEvents tbpAesthetics As TabPage
    Friend WithEvents tbpGeomParameters As TabPage
    Friend WithEvents ucrGeomWithAes As UcrGeomListWithParameters
    Friend WithEvents grpBoxPlot As GroupBox
    Friend WithEvents chkChangeOutliers As CheckBox
    Friend WithEvents nudWhiskerLength As NumericUpDown
    Friend WithEvents chkWhiskerLength As CheckBox
    Friend WithEvents nudSize As NumericUpDown
    Friend WithEvents lblSize As Label
    Friend WithEvents nudShape As NumericUpDown
    Friend WithEvents lblShape As Label
    Friend WithEvents nudNotchWidth As NumericUpDown
    Friend WithEvents lblNotchWidth As Label
    Friend WithEvents chkNotchedBoxplot As CheckBox
    Friend WithEvents chkVariableWidth As CheckBox
    Friend WithEvents nudStroke As NumericUpDown
    Friend WithEvents lblStroke As Label
End Class
