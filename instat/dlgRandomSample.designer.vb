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
        Me.lblSampleSize = New System.Windows.Forms.Label()
        Me.lblNumberofSamples = New System.Windows.Forms.Label()
        Me.lblPrefixColumnName = New System.Windows.Forms.Label()
        Me.nudNumberOfSamples = New System.Windows.Forms.NumericUpDown()
        Me.nudSeed = New System.Windows.Forms.NumericUpDown()
        Me.chkSetSeed = New System.Windows.Forms.CheckBox()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.ucrNewColumnName = New instat.ucrInputComboBox()
        Me.ucrPrefixNewColumns = New instat.ucrInputTextBox()
        Me.ucrSampleSize = New instat.ucrDataFrameLength()
        Me.ucrSelectorRandomSamples = New instat.ucrDataFrame()
        Me.ucrDistWithParameters = New instat.ucrDistributionsWithParameters()
        Me.ucrBase = New instat.ucrButtons()
        CType(Me.nudNumberOfSamples, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSampleSize
        '
        Me.lblSampleSize.AutoSize = True
        Me.lblSampleSize.Location = New System.Drawing.Point(257, 124)
        Me.lblSampleSize.Name = "lblSampleSize"
        Me.lblSampleSize.Size = New System.Drawing.Size(68, 13)
        Me.lblSampleSize.TabIndex = 10
        Me.lblSampleSize.Tag = "Sample_Size:"
        Me.lblSampleSize.Text = "Sample Size:"
        '
        'lblNumberofSamples
        '
        Me.lblNumberofSamples.AutoSize = True
        Me.lblNumberofSamples.Location = New System.Drawing.Point(257, 98)
        Me.lblNumberofSamples.Name = "lblNumberofSamples"
        Me.lblNumberofSamples.Size = New System.Drawing.Size(102, 13)
        Me.lblNumberofSamples.TabIndex = 10
        Me.lblNumberofSamples.Tag = "Number_of_Samples:"
        Me.lblNumberofSamples.Text = "Number of Samples:"
        '
        'lblPrefixColumnName
        '
        Me.lblPrefixColumnName.AutoSize = True
        Me.lblPrefixColumnName.Location = New System.Drawing.Point(10, 224)
        Me.lblPrefixColumnName.Name = "lblPrefixColumnName"
        Me.lblPrefixColumnName.Size = New System.Drawing.Size(122, 13)
        Me.lblPrefixColumnName.TabIndex = 15
        Me.lblPrefixColumnName.Tag = "Prefix_For_New_Columns"
        Me.lblPrefixColumnName.Text = "Prefix For New Columns:"
        '
        'nudNumberOfSamples
        '
        Me.nudNumberOfSamples.Location = New System.Drawing.Point(359, 94)
        Me.nudNumberOfSamples.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumberOfSamples.Name = "nudNumberOfSamples"
        Me.nudNumberOfSamples.Size = New System.Drawing.Size(35, 20)
        Me.nudNumberOfSamples.TabIndex = 17
        Me.nudNumberOfSamples.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudSeed
        '
        Me.nudSeed.Location = New System.Drawing.Point(359, 68)
        Me.nudSeed.Name = "nudSeed"
        Me.nudSeed.Size = New System.Drawing.Size(35, 20)
        Me.nudSeed.TabIndex = 18
        '
        'chkSetSeed
        '
        Me.chkSetSeed.AutoSize = True
        Me.chkSetSeed.Location = New System.Drawing.Point(257, 69)
        Me.chkSetSeed.Name = "chkSetSeed"
        Me.chkSetSeed.Size = New System.Drawing.Size(70, 17)
        Me.chkSetSeed.TabIndex = 19
        Me.chkSetSeed.Tag = "Set_Seed"
        Me.chkSetSeed.Text = "Set Seed"
        Me.chkSetSeed.UseVisualStyleBackColor = True
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(10, 224)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(101, 13)
        Me.lblNewColumnName.TabIndex = 21
        Me.lblNewColumnName.Tag = "New_Column_Name:"
        Me.lblNewColumnName.Text = "New Column Name:"
        '
        'ucrNewColumnName
        '
        Me.ucrNewColumnName.AddQuotesIfUnrecognised = True
        Me.ucrNewColumnName.IsReadOnly = False
        Me.ucrNewColumnName.Location = New System.Drawing.Point(131, 221)
        Me.ucrNewColumnName.Name = "ucrNewColumnName"
        Me.ucrNewColumnName.Size = New System.Drawing.Size(145, 21)
        Me.ucrNewColumnName.TabIndex = 20
        '
        'ucrPrefixNewColumns
        '
        Me.ucrPrefixNewColumns.AddQuotesIfUnrecognised = True
        Me.ucrPrefixNewColumns.IsMultiline = False
        Me.ucrPrefixNewColumns.IsReadOnly = False
        Me.ucrPrefixNewColumns.Location = New System.Drawing.Point(131, 222)
        Me.ucrPrefixNewColumns.Name = "ucrPrefixNewColumns"
        Me.ucrPrefixNewColumns.Size = New System.Drawing.Size(145, 21)
        Me.ucrPrefixNewColumns.TabIndex = 16
        '
        'ucrSampleSize
        '
        Me.ucrSampleSize.Location = New System.Drawing.Point(344, 120)
        Me.ucrSampleSize.Name = "ucrSampleSize"
        Me.ucrSampleSize.Size = New System.Drawing.Size(55, 23)
        Me.ucrSampleSize.TabIndex = 13
        Me.ucrSampleSize.ucrDataFrameSelector = Nothing
        '
        'ucrSelectorRandomSamples
        '
        Me.ucrSelectorRandomSamples.bUseCurrentFilter = True
        Me.ucrSelectorRandomSamples.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorRandomSamples.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorRandomSamples.Name = "ucrSelectorRandomSamples"
        Me.ucrSelectorRandomSamples.Size = New System.Drawing.Size(120, 40)
        Me.ucrSelectorRandomSamples.TabIndex = 8
        '
        'ucrDistWithParameters
        '
        Me.ucrDistWithParameters.Location = New System.Drawing.Point(10, 55)
        Me.ucrDistWithParameters.Name = "ucrDistWithParameters"
        Me.ucrDistWithParameters.Size = New System.Drawing.Size(221, 156)
        Me.ucrDistWithParameters.TabIndex = 7
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 248)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'dlgRandomSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 300)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.ucrNewColumnName)
        Me.Controls.Add(Me.chkSetSeed)
        Me.Controls.Add(Me.nudSeed)
        Me.Controls.Add(Me.nudNumberOfSamples)
        Me.Controls.Add(Me.ucrPrefixNewColumns)
        Me.Controls.Add(Me.lblPrefixColumnName)
        Me.Controls.Add(Me.ucrSampleSize)
        Me.Controls.Add(Me.lblNumberofSamples)
        Me.Controls.Add(Me.lblSampleSize)
        Me.Controls.Add(Me.ucrSelectorRandomSamples)
        Me.Controls.Add(Me.ucrDistWithParameters)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRandomSample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generate Random Sample"
        CType(Me.nudNumberOfSamples, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDistWithParameters As ucrDistributionsWithParameters
    Friend WithEvents ucrSelectorRandomSamples As ucrDataFrame
    Friend WithEvents lblSampleSize As Label
    Friend WithEvents lblNumberofSamples As Label
    Friend WithEvents ucrSampleSize As ucrDataFrameLength
    Friend WithEvents lblPrefixColumnName As Label
    Friend WithEvents ucrPrefixNewColumns As ucrInputTextBox
    Friend WithEvents nudNumberOfSamples As NumericUpDown
    Friend WithEvents nudSeed As NumericUpDown
    Friend WithEvents chkSetSeed As CheckBox
    Friend WithEvents ucrNewColumnName As ucrInputComboBox
    Friend WithEvents lblNewColumnName As Label
End Class
