<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCompareModels
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDistributionForCompareModels = New instat.ucrDistributionsWithParameters()
        Me.grpPlotGraphs = New System.Windows.Forms.GroupBox()
        Me.rdoSingle = New System.Windows.Forms.RadioButton()
        Me.rdoCombine = New System.Windows.Forms.RadioButton()
        Me.lblNumberofColumns = New System.Windows.Forms.Label()
        Me.nudNumberofColumns = New System.Windows.Forms.NumericUpDown()
        Me.cmdAddNewDistributions = New System.Windows.Forms.Button()
        Me.grpPlotOptions = New System.Windows.Forms.GroupBox()
        Me.chkDensity = New System.Windows.Forms.CheckBox()
        Me.chkCDF = New System.Windows.Forms.CheckBox()
        Me.chkHistogram = New System.Windows.Forms.CheckBox()
        Me.grpChangeLimits = New System.Windows.Forms.GroupBox()
        Me.lblXlim = New System.Windows.Forms.Label()
        Me.lblYlim = New System.Windows.Forms.Label()
        Me.nudXlimMin = New System.Windows.Forms.NumericUpDown()
        Me.nudYlimMin = New System.Windows.Forms.NumericUpDown()
        Me.nudYlimMax = New System.Windows.Forms.NumericUpDown()
        Me.nudXlimMax = New System.Windows.Forms.NumericUpDown()
        Me.grpPlotGraphs.SuspendLayout()
        CType(Me.nudNumberofColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPlotOptions.SuspendLayout()
        Me.grpChangeLimits.SuspendLayout()
        CType(Me.nudXlimMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudYlimMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudYlimMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudXlimMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 320)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrDistributionForCompareModels
        '
        Me.ucrDistributionForCompareModels.Location = New System.Drawing.Point(13, 13)
        Me.ucrDistributionForCompareModels.Name = "ucrDistributionForCompareModels"
        Me.ucrDistributionForCompareModels.Size = New System.Drawing.Size(221, 194)
        Me.ucrDistributionForCompareModels.TabIndex = 1
        '
        'grpPlotGraphs
        '
        Me.grpPlotGraphs.Controls.Add(Me.nudNumberofColumns)
        Me.grpPlotGraphs.Controls.Add(Me.lblNumberofColumns)
        Me.grpPlotGraphs.Controls.Add(Me.rdoCombine)
        Me.grpPlotGraphs.Controls.Add(Me.rdoSingle)
        Me.grpPlotGraphs.Location = New System.Drawing.Point(14, 202)
        Me.grpPlotGraphs.Name = "grpPlotGraphs"
        Me.grpPlotGraphs.Size = New System.Drawing.Size(238, 73)
        Me.grpPlotGraphs.TabIndex = 2
        Me.grpPlotGraphs.TabStop = False
        Me.grpPlotGraphs.Text = "Plot Graph"
        '
        'rdoSingle
        '
        Me.rdoSingle.AutoSize = True
        Me.rdoSingle.Location = New System.Drawing.Point(7, 20)
        Me.rdoSingle.Name = "rdoSingle"
        Me.rdoSingle.Size = New System.Drawing.Size(54, 17)
        Me.rdoSingle.TabIndex = 0
        Me.rdoSingle.TabStop = True
        Me.rdoSingle.Text = "Single"
        Me.rdoSingle.UseVisualStyleBackColor = True
        '
        'rdoCombine
        '
        Me.rdoCombine.AutoSize = True
        Me.rdoCombine.Location = New System.Drawing.Point(7, 44)
        Me.rdoCombine.Name = "rdoCombine"
        Me.rdoCombine.Size = New System.Drawing.Size(66, 17)
        Me.rdoCombine.TabIndex = 1
        Me.rdoCombine.TabStop = True
        Me.rdoCombine.Text = "Combine"
        Me.rdoCombine.UseVisualStyleBackColor = True
        '
        'lblNumberofColumns
        '
        Me.lblNumberofColumns.AutoSize = True
        Me.lblNumberofColumns.Location = New System.Drawing.Point(79, 46)
        Me.lblNumberofColumns.Name = "lblNumberofColumns"
        Me.lblNumberofColumns.Size = New System.Drawing.Size(99, 13)
        Me.lblNumberofColumns.TabIndex = 2
        Me.lblNumberofColumns.Text = "Number of Columns"
        '
        'nudNumberofColumns
        '
        Me.nudNumberofColumns.Location = New System.Drawing.Point(184, 44)
        Me.nudNumberofColumns.Name = "nudNumberofColumns"
        Me.nudNumberofColumns.Size = New System.Drawing.Size(48, 20)
        Me.nudNumberofColumns.TabIndex = 3
        '
        'cmdAddNewDistributions
        '
        Me.cmdAddNewDistributions.Location = New System.Drawing.Point(13, 282)
        Me.cmdAddNewDistributions.Name = "cmdAddNewDistributions"
        Me.cmdAddNewDistributions.Size = New System.Drawing.Size(128, 23)
        Me.cmdAddNewDistributions.TabIndex = 3
        Me.cmdAddNewDistributions.Text = "Add New Distribution"
        Me.cmdAddNewDistributions.UseVisualStyleBackColor = True
        '
        'grpPlotOptions
        '
        Me.grpPlotOptions.Controls.Add(Me.chkHistogram)
        Me.grpPlotOptions.Controls.Add(Me.chkCDF)
        Me.grpPlotOptions.Controls.Add(Me.chkDensity)
        Me.grpPlotOptions.Location = New System.Drawing.Point(240, 12)
        Me.grpPlotOptions.Name = "grpPlotOptions"
        Me.grpPlotOptions.Size = New System.Drawing.Size(171, 94)
        Me.grpPlotOptions.TabIndex = 4
        Me.grpPlotOptions.TabStop = False
        '
        'chkDensity
        '
        Me.chkDensity.AutoSize = True
        Me.chkDensity.Location = New System.Drawing.Point(7, 20)
        Me.chkDensity.Name = "chkDensity"
        Me.chkDensity.Size = New System.Drawing.Size(61, 17)
        Me.chkDensity.TabIndex = 0
        Me.chkDensity.Text = "Density"
        Me.chkDensity.UseVisualStyleBackColor = True
        '
        'chkCDF
        '
        Me.chkCDF.AutoSize = True
        Me.chkCDF.Location = New System.Drawing.Point(7, 44)
        Me.chkCDF.Name = "chkCDF"
        Me.chkCDF.Size = New System.Drawing.Size(47, 17)
        Me.chkCDF.TabIndex = 1
        Me.chkCDF.Text = "CDF"
        Me.chkCDF.UseVisualStyleBackColor = True
        '
        'chkHistogram
        '
        Me.chkHistogram.AutoSize = True
        Me.chkHistogram.Location = New System.Drawing.Point(7, 68)
        Me.chkHistogram.Name = "chkHistogram"
        Me.chkHistogram.Size = New System.Drawing.Size(73, 17)
        Me.chkHistogram.TabIndex = 2
        Me.chkHistogram.Text = "Histogram"
        Me.chkHistogram.UseVisualStyleBackColor = True
        '
        'grpChangeLimits
        '
        Me.grpChangeLimits.Controls.Add(Me.nudYlimMax)
        Me.grpChangeLimits.Controls.Add(Me.nudXlimMax)
        Me.grpChangeLimits.Controls.Add(Me.nudYlimMin)
        Me.grpChangeLimits.Controls.Add(Me.nudXlimMin)
        Me.grpChangeLimits.Controls.Add(Me.lblYlim)
        Me.grpChangeLimits.Controls.Add(Me.lblXlim)
        Me.grpChangeLimits.Location = New System.Drawing.Point(240, 113)
        Me.grpChangeLimits.Name = "grpChangeLimits"
        Me.grpChangeLimits.Size = New System.Drawing.Size(171, 83)
        Me.grpChangeLimits.TabIndex = 5
        Me.grpChangeLimits.TabStop = False
        Me.grpChangeLimits.Text = "Change Limits"
        '
        'lblXlim
        '
        Me.lblXlim.AutoSize = True
        Me.lblXlim.Location = New System.Drawing.Point(0, 20)
        Me.lblXlim.Name = "lblXlim"
        Me.lblXlim.Size = New System.Drawing.Size(26, 13)
        Me.lblXlim.TabIndex = 0
        Me.lblXlim.Text = "Xlim"
        '
        'lblYlim
        '
        Me.lblYlim.AutoSize = True
        Me.lblYlim.Location = New System.Drawing.Point(0, 46)
        Me.lblYlim.Name = "lblYlim"
        Me.lblYlim.Size = New System.Drawing.Size(26, 13)
        Me.lblYlim.TabIndex = 1
        Me.lblYlim.Text = "Ylim"
        '
        'nudXlimMin
        '
        Me.nudXlimMin.Location = New System.Drawing.Point(52, 20)
        Me.nudXlimMin.Name = "nudXlimMin"
        Me.nudXlimMin.Size = New System.Drawing.Size(44, 20)
        Me.nudXlimMin.TabIndex = 2
        '
        'nudYlimMin
        '
        Me.nudYlimMin.Location = New System.Drawing.Point(51, 44)
        Me.nudYlimMin.Name = "nudYlimMin"
        Me.nudYlimMin.Size = New System.Drawing.Size(45, 20)
        Me.nudYlimMin.TabIndex = 3
        '
        'nudYlimMax
        '
        Me.nudYlimMax.Location = New System.Drawing.Point(107, 44)
        Me.nudYlimMax.Name = "nudYlimMax"
        Me.nudYlimMax.Size = New System.Drawing.Size(45, 20)
        Me.nudYlimMax.TabIndex = 5
        '
        'nudXlimMax
        '
        Me.nudXlimMax.Location = New System.Drawing.Point(108, 20)
        Me.nudXlimMax.Name = "nudXlimMax"
        Me.nudXlimMax.Size = New System.Drawing.Size(44, 20)
        Me.nudXlimMax.TabIndex = 4
        '
        'dlgCompareModels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 384)
        Me.Controls.Add(Me.grpChangeLimits)
        Me.Controls.Add(Me.grpPlotOptions)
        Me.Controls.Add(Me.cmdAddNewDistributions)
        Me.Controls.Add(Me.grpPlotGraphs)
        Me.Controls.Add(Me.ucrDistributionForCompareModels)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCompareModels"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compare Models"
        Me.grpPlotGraphs.ResumeLayout(False)
        Me.grpPlotGraphs.PerformLayout()
        CType(Me.nudNumberofColumns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPlotOptions.ResumeLayout(False)
        Me.grpPlotOptions.PerformLayout()
        Me.grpChangeLimits.ResumeLayout(False)
        Me.grpChangeLimits.PerformLayout()
        CType(Me.nudXlimMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudYlimMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudYlimMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudXlimMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDistributionForCompareModels As ucrDistributionsWithParameters
    Friend WithEvents grpPlotGraphs As GroupBox
    Friend WithEvents nudNumberofColumns As NumericUpDown
    Friend WithEvents lblNumberofColumns As Label
    Friend WithEvents rdoCombine As RadioButton
    Friend WithEvents rdoSingle As RadioButton
    Friend WithEvents cmdAddNewDistributions As Button
    Friend WithEvents grpPlotOptions As GroupBox
    Friend WithEvents chkHistogram As CheckBox
    Friend WithEvents chkCDF As CheckBox
    Friend WithEvents chkDensity As CheckBox
    Friend WithEvents grpChangeLimits As GroupBox
    Friend WithEvents nudYlimMax As NumericUpDown
    Friend WithEvents nudXlimMax As NumericUpDown
    Friend WithEvents nudYlimMin As NumericUpDown
    Friend WithEvents nudXlimMin As NumericUpDown
    Friend WithEvents lblYlim As Label
    Friend WithEvents lblXlim As Label
End Class
