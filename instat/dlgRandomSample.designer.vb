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
        Me.grpSampleDataColumn = New System.Windows.Forms.GroupBox()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.ucrReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelector = New instat.ucrSelectorAddRemove()
        Me.chkPlot = New System.Windows.Forms.CheckBox()
        Me.lblSeed = New System.Windows.Forms.Label()
        Me.txtSeed = New System.Windows.Forms.TextBox()
        Me.ucrDistWithParameters = New instat.ucrDistributionsWithParameters()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpSampling.SuspendLayout()
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
        'grpSampleDataColumn
        '
        Me.grpSampleDataColumn.Controls.Add(Me.lblSelectedVariable)
        Me.grpSampleDataColumn.Controls.Add(Me.ucrReceiver)
        Me.grpSampleDataColumn.Controls.Add(Me.ucrSelector)
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
        'ucrReceiver
        '
        Me.ucrReceiver.Location = New System.Drawing.Point(226, 56)
        Me.ucrReceiver.Name = "ucrReceiver"
        Me.ucrReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiver.TabIndex = 1
        '
        'ucrSelector
        '
        Me.ucrSelector.Location = New System.Drawing.Point(8, 30)
        Me.ucrSelector.Name = "ucrSelector"
        Me.ucrSelector.Size = New System.Drawing.Size(201, 136)
        Me.ucrSelector.TabIndex = 0
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
        'ucrDistWithParameters
        '
        Me.ucrDistWithParameters.Location = New System.Drawing.Point(12, 190)
        Me.ucrDistWithParameters.Name = "ucrDistWithParameters"
        Me.ucrDistWithParameters.Size = New System.Drawing.Size(221, 156)
        Me.ucrDistWithParameters.TabIndex = 7
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(85, 345)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 55)
        Me.ucrBase.TabIndex = 0
        '
        'dlgRandomSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 405)
        Me.Controls.Add(Me.ucrDistWithParameters)
        Me.Controls.Add(Me.txtSeed)
        Me.Controls.Add(Me.lblSeed)
        Me.Controls.Add(Me.chkPlot)
        Me.Controls.Add(Me.grpSampleDataColumn)
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
    Friend WithEvents grpSampleDataColumn As GroupBox
    Friend WithEvents ucrSelector As ucrSelectorAddRemove
    Friend WithEvents ucrReceiver As ucrReceiverSingle
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents chkPlot As CheckBox
    Friend WithEvents lblSeed As Label
    Friend WithEvents txtSeed As TextBox
    Friend WithEvents ucrDistWithParameters As ucrDistributionsWithParameters
End Class
