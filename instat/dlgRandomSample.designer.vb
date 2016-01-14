<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRandomSample
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
        Me.grpSampling = New System.Windows.Forms.GroupBox()
        Me.txtSampleSize = New System.Windows.Forms.TextBox()
        Me.txtNumberofSamples = New System.Windows.Forms.TextBox()
        Me.lblSampleSize = New System.Windows.Forms.Label()
        Me.lblNumberofSamples = New System.Windows.Forms.Label()
        Me.cboSampleType = New System.Windows.Forms.ComboBox()
        Me.lblSampleType = New System.Windows.Forms.Label()
        Me.grpProbabilityDistribution = New System.Windows.Forms.GroupBox()
        Me.txtStDev = New System.Windows.Forms.TextBox()
        Me.txtMean = New System.Windows.Forms.TextBox()
        Me.lblStDev = New System.Windows.Forms.Label()
        Me.lblMean = New System.Windows.Forms.Label()
        Me.lblParameters = New System.Windows.Forms.Label()
        Me.lblDistributionType = New System.Windows.Forms.Label()
        Me.cboDistributionType = New System.Windows.Forms.ComboBox()
        Me.grpSampleDataColumn = New System.Windows.Forms.GroupBox()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.UcrReceiverSingle = New instat.ucrReceiverSingle()
        Me.UcrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.chkPlot = New System.Windows.Forms.CheckBox()
        Me.lblSeed = New System.Windows.Forms.Label()
        Me.txtSeed = New System.Windows.Forms.TextBox()
        Me.grpSampling.SuspendLayout()
        Me.grpProbabilityDistribution.SuspendLayout()
        Me.grpSampleDataColumn.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSampling
        '
        Me.grpSampling.Controls.Add(Me.txtSampleSize)
        Me.grpSampling.Controls.Add(Me.txtNumberofSamples)
        Me.grpSampling.Controls.Add(Me.lblSampleSize)
        Me.grpSampling.Controls.Add(Me.lblNumberofSamples)
        Me.grpSampling.Controls.Add(Me.cboSampleType)
        Me.grpSampling.Controls.Add(Me.lblSampleType)
        Me.grpSampling.Location = New System.Drawing.Point(12, 12)
        Me.grpSampling.Name = "grpSampling"
        Me.grpSampling.Size = New System.Drawing.Size(232, 172)
        Me.grpSampling.TabIndex = 1
        Me.grpSampling.TabStop = False
        Me.grpSampling.Tag = "Sampling"
        Me.grpSampling.Text = "Sampling"
        '
        'txtSampleSize
        '
        Me.txtSampleSize.Location = New System.Drawing.Point(109, 99)
        Me.txtSampleSize.Name = "txtSampleSize"
        Me.txtSampleSize.Size = New System.Drawing.Size(100, 20)
        Me.txtSampleSize.TabIndex = 5
        '
        'txtNumberofSamples
        '
        Me.txtNumberofSamples.Location = New System.Drawing.Point(110, 74)
        Me.txtNumberofSamples.Name = "txtNumberofSamples"
        Me.txtNumberofSamples.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberofSamples.TabIndex = 4
        '
        'lblSampleSize
        '
        Me.lblSampleSize.AutoSize = True
        Me.lblSampleSize.Location = New System.Drawing.Point(6, 106)
        Me.lblSampleSize.Name = "lblSampleSize"
        Me.lblSampleSize.Size = New System.Drawing.Size(65, 13)
        Me.lblSampleSize.TabIndex = 3
        Me.lblSampleSize.Tag = "Sample_Size"
        Me.lblSampleSize.Text = "Sample Size"
        '
        'lblNumberofSamples
        '
        Me.lblNumberofSamples.AutoSize = True
        Me.lblNumberofSamples.Location = New System.Drawing.Point(6, 77)
        Me.lblNumberofSamples.Name = "lblNumberofSamples"
        Me.lblNumberofSamples.Size = New System.Drawing.Size(99, 13)
        Me.lblNumberofSamples.TabIndex = 2
        Me.lblNumberofSamples.Tag = "Number_of_Samples"
        Me.lblNumberofSamples.Text = "Number of Samples"
        '
        'cboSampleType
        '
        Me.cboSampleType.FormattingEnabled = True
        Me.cboSampleType.Items.AddRange(New Object() {"Probability Distribution", "Data column (without replacement)", "Data column (with replacement)", "Permute integers 1 to n"})
        Me.cboSampleType.Location = New System.Drawing.Point(32, 33)
        Me.cboSampleType.Name = "cboSampleType"
        Me.cboSampleType.Size = New System.Drawing.Size(121, 21)
        Me.cboSampleType.TabIndex = 1
        '
        'lblSampleType
        '
        Me.lblSampleType.AutoSize = True
        Me.lblSampleType.Location = New System.Drawing.Point(58, 16)
        Me.lblSampleType.Name = "lblSampleType"
        Me.lblSampleType.Size = New System.Drawing.Size(69, 13)
        Me.lblSampleType.TabIndex = 0
        Me.lblSampleType.Tag = "Sample_Type"
        Me.lblSampleType.Text = "Sample Type"
        '
        'grpProbabilityDistribution
        '
        Me.grpProbabilityDistribution.Controls.Add(Me.txtStDev)
        Me.grpProbabilityDistribution.Controls.Add(Me.txtMean)
        Me.grpProbabilityDistribution.Controls.Add(Me.lblStDev)
        Me.grpProbabilityDistribution.Controls.Add(Me.lblMean)
        Me.grpProbabilityDistribution.Controls.Add(Me.lblParameters)
        Me.grpProbabilityDistribution.Controls.Add(Me.lblDistributionType)
        Me.grpProbabilityDistribution.Controls.Add(Me.cboDistributionType)
        Me.grpProbabilityDistribution.Location = New System.Drawing.Point(8, 188)
        Me.grpProbabilityDistribution.Name = "grpProbabilityDistribution"
        Me.grpProbabilityDistribution.Size = New System.Drawing.Size(236, 151)
        Me.grpProbabilityDistribution.TabIndex = 2
        Me.grpProbabilityDistribution.TabStop = False
        Me.grpProbabilityDistribution.Tag = "Probability_Distribution"
        Me.grpProbabilityDistribution.Text = "Probability Distribution"
        '
        'txtStDev
        '
        Me.txtStDev.Location = New System.Drawing.Point(128, 121)
        Me.txtStDev.Name = "txtStDev"
        Me.txtStDev.Size = New System.Drawing.Size(100, 20)
        Me.txtStDev.TabIndex = 6
        '
        'txtMean
        '
        Me.txtMean.Location = New System.Drawing.Point(128, 95)
        Me.txtMean.Name = "txtMean"
        Me.txtMean.Size = New System.Drawing.Size(100, 20)
        Me.txtMean.TabIndex = 5
        '
        'lblStDev
        '
        Me.lblStDev.AutoSize = True
        Me.lblStDev.Location = New System.Drawing.Point(40, 124)
        Me.lblStDev.Name = "lblStDev"
        Me.lblStDev.Size = New System.Drawing.Size(43, 13)
        Me.lblStDev.TabIndex = 4
        Me.lblStDev.Tag = "St.Dev."
        Me.lblStDev.Text = "St.Dev."
        '
        'lblMean
        '
        Me.lblMean.AutoSize = True
        Me.lblMean.Location = New System.Drawing.Point(40, 102)
        Me.lblMean.Name = "lblMean"
        Me.lblMean.Size = New System.Drawing.Size(34, 13)
        Me.lblMean.TabIndex = 3
        Me.lblMean.Tag = "Mean"
        Me.lblMean.Text = "Mean"
        '
        'lblParameters
        '
        Me.lblParameters.AutoSize = True
        Me.lblParameters.Location = New System.Drawing.Point(40, 58)
        Me.lblParameters.Name = "lblParameters"
        Me.lblParameters.Size = New System.Drawing.Size(60, 13)
        Me.lblParameters.TabIndex = 2
        Me.lblParameters.Tag = "Parameters"
        Me.lblParameters.Text = "Parameters"
        '
        'lblDistributionType
        '
        Me.lblDistributionType.AutoSize = True
        Me.lblDistributionType.Location = New System.Drawing.Point(34, 33)
        Me.lblDistributionType.Name = "lblDistributionType"
        Me.lblDistributionType.Size = New System.Drawing.Size(86, 13)
        Me.lblDistributionType.TabIndex = 1
        Me.lblDistributionType.Tag = "Distribution_Type"
        Me.lblDistributionType.Text = "Distribution Type"
        '
        'cboDistributionType
        '
        Me.cboDistributionType.FormattingEnabled = True
        Me.cboDistributionType.Items.AddRange(New Object() {"Normal", "Geometric", "Exponential", "Extreme Value", "Weibull", "Uniform", "Bernoulli", "Binomial", "Poisson", "Beta", "Chi- Square", "F", "Gamma", "Hypergeometric", "Log-normal", "Multinomial", "Negative Binomial", "Student's t"})
        Me.cboDistributionType.Location = New System.Drawing.Point(126, 30)
        Me.cboDistributionType.Name = "cboDistributionType"
        Me.cboDistributionType.Size = New System.Drawing.Size(102, 21)
        Me.cboDistributionType.TabIndex = 0
        '
        'grpSampleDataColumn
        '
        Me.grpSampleDataColumn.Controls.Add(Me.lblSelectedVariable)
        Me.grpSampleDataColumn.Controls.Add(Me.UcrReceiverSingle)
        Me.grpSampleDataColumn.Controls.Add(Me.UcrAddRemove)
        Me.grpSampleDataColumn.Location = New System.Drawing.Point(250, 12)
        Me.grpSampleDataColumn.Name = "grpSampleDataColumn"
        Me.grpSampleDataColumn.Size = New System.Drawing.Size(333, 172)
        Me.grpSampleDataColumn.TabIndex = 3
        Me.grpSampleDataColumn.TabStop = False
        Me.grpSampleDataColumn.Tag = "Sample_from_data_column"
        Me.grpSampleDataColumn.Text = "Sample from data column"
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.AutoSize = True
        Me.lblSelectedVariable.Location = New System.Drawing.Point(223, 33)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(90, 13)
        Me.lblSelectedVariable.TabIndex = 2
        Me.lblSelectedVariable.Tag = "Selected_Variable"
        Me.lblSelectedVariable.Text = "Selected Variable"
        '
        'UcrReceiverSingle
        '
        Me.UcrReceiverSingle.Location = New System.Drawing.Point(226, 56)
        Me.UcrReceiverSingle.Name = "UcrReceiverSingle"
        Me.UcrReceiverSingle.Size = New System.Drawing.Size(106, 26)
        Me.UcrReceiverSingle.TabIndex = 1
        '
        'UcrAddRemove
        '
        Me.UcrAddRemove.Location = New System.Drawing.Point(8, 30)
        Me.UcrAddRemove.Name = "UcrAddRemove"
        Me.UcrAddRemove.Size = New System.Drawing.Size(201, 136)
        Me.UcrAddRemove.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(38, 346)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'chkPlot
        '
        Me.chkPlot.AutoSize = True
        Me.chkPlot.Location = New System.Drawing.Point(254, 196)
        Me.chkPlot.Name = "chkPlot"
        Me.chkPlot.Size = New System.Drawing.Size(44, 17)
        Me.chkPlot.TabIndex = 4
        Me.chkPlot.Tag = "Plot"
        Me.chkPlot.Text = "Plot"
        Me.chkPlot.UseVisualStyleBackColor = True
        '
        'lblSeed
        '
        Me.lblSeed.AutoSize = True
        Me.lblSeed.Location = New System.Drawing.Point(323, 198)
        Me.lblSeed.Name = "lblSeed"
        Me.lblSeed.Size = New System.Drawing.Size(32, 13)
        Me.lblSeed.TabIndex = 5
        Me.lblSeed.Tag = "Seed"
        Me.lblSeed.Text = "Seed"
        '
        'txtSeed
        '
        Me.txtSeed.Location = New System.Drawing.Point(362, 196)
        Me.txtSeed.Name = "txtSeed"
        Me.txtSeed.Size = New System.Drawing.Size(47, 20)
        Me.txtSeed.TabIndex = 6
        '
        'dlgRandomSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 379)
        Me.Controls.Add(Me.txtSeed)
        Me.Controls.Add(Me.lblSeed)
        Me.Controls.Add(Me.chkPlot)
        Me.Controls.Add(Me.grpSampleDataColumn)
        Me.Controls.Add(Me.grpProbabilityDistribution)
        Me.Controls.Add(Me.grpSampling)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRandomSample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generate Random Sample"
        Me.grpSampling.ResumeLayout(False)
        Me.grpSampling.PerformLayout()
        Me.grpProbabilityDistribution.ResumeLayout(False)
        Me.grpProbabilityDistribution.PerformLayout()
        Me.grpSampleDataColumn.ResumeLayout(False)
        Me.grpSampleDataColumn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpSampling As GroupBox
    Friend WithEvents txtSampleSize As TextBox
    Friend WithEvents txtNumberofSamples As TextBox
    Friend WithEvents lblSampleSize As Label
    Friend WithEvents lblNumberofSamples As Label
    Friend WithEvents cboSampleType As ComboBox
    Friend WithEvents lblSampleType As Label
    Friend WithEvents grpProbabilityDistribution As GroupBox
    Friend WithEvents lblParameters As Label
    Friend WithEvents lblDistributionType As Label
    Friend WithEvents cboDistributionType As ComboBox
    Friend WithEvents txtStDev As TextBox
    Friend WithEvents txtMean As TextBox
    Friend WithEvents lblStDev As Label
    Friend WithEvents lblMean As Label
    Friend WithEvents grpSampleDataColumn As GroupBox
    Friend WithEvents UcrAddRemove As ucrSelectorAddRemove
    Friend WithEvents UcrReceiverSingle As ucrReceiverSingle
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents chkPlot As CheckBox
    Friend WithEvents lblSeed As Label
    Friend WithEvents txtSeed As TextBox
End Class
