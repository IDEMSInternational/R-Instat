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
        Me.ucrDistWithParameters = New instat.ucrDistributionsWithParameters()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorRandomSamples = New instat.ucrDataFrame()
        Me.lblSampleSize = New System.Windows.Forms.Label()
        Me.lblNumberofSamples = New System.Windows.Forms.Label()
        Me.ucrSampleSize = New instat.ucrDataFrameLength()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.ucrPrefixNewColumns = New instat.ucrInputTextBox()
        Me.nudNumberOfSamples = New System.Windows.Forms.NumericUpDown()
        Me.nudSeed = New System.Windows.Forms.NumericUpDown()
        Me.chkSetSeed = New System.Windows.Forms.CheckBox()
        CType(Me.nudNumberOfSamples, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrDistWithParameters
        '
        Me.ucrDistWithParameters.Location = New System.Drawing.Point(6, 82)
        Me.ucrDistWithParameters.Name = "ucrDistWithParameters"
        Me.ucrDistWithParameters.Size = New System.Drawing.Size(221, 125)
        Me.ucrDistWithParameters.TabIndex = 7
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(6, 269)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 55)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorRandomSamples
        '
        Me.ucrSelectorRandomSamples.Location = New System.Drawing.Point(12, 12)
        Me.ucrSelectorRandomSamples.Name = "ucrSelectorRandomSamples"
        Me.ucrSelectorRandomSamples.Size = New System.Drawing.Size(127, 41)
        Me.ucrSelectorRandomSamples.TabIndex = 8
        '
        'lblSampleSize
        '
        Me.lblSampleSize.AutoSize = True
        Me.lblSampleSize.Location = New System.Drawing.Point(12, 66)
        Me.lblSampleSize.Name = "lblSampleSize"
        Me.lblSampleSize.Size = New System.Drawing.Size(65, 13)
        Me.lblSampleSize.TabIndex = 10
        Me.lblSampleSize.Tag = "Sample_Size"
        Me.lblSampleSize.Text = "Sample Size"
        '
        'lblNumberofSamples
        '
        Me.lblNumberofSamples.AutoSize = True
        Me.lblNumberofSamples.Location = New System.Drawing.Point(12, 212)
        Me.lblNumberofSamples.Name = "lblNumberofSamples"
        Me.lblNumberofSamples.Size = New System.Drawing.Size(99, 13)
        Me.lblNumberofSamples.TabIndex = 10
        Me.lblNumberofSamples.Tag = "Number_of_Samples"
        Me.lblNumberofSamples.Text = "Number of Samples"
        '
        'ucrSampleSize
        '
        Me.ucrSampleSize.clsDataFrameSelector = Nothing
        Me.ucrSampleSize.Location = New System.Drawing.Point(101, 66)
        Me.ucrSampleSize.Name = "ucrSampleSize"
        Me.ucrSampleSize.Size = New System.Drawing.Size(53, 23)
        Me.ucrSampleSize.TabIndex = 13
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(9, 241)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(119, 13)
        Me.lblNewColumnName.TabIndex = 15
        Me.lblNewColumnName.Tag = "Prefix_For_New_Columns"
        Me.lblNewColumnName.Text = "Prefix For New Columns"
        '
        'ucrPrefixNewColumns
        '
        Me.ucrPrefixNewColumns.Location = New System.Drawing.Point(134, 238)
        Me.ucrPrefixNewColumns.Name = "ucrPrefixNewColumns"
        Me.ucrPrefixNewColumns.Size = New System.Drawing.Size(137, 21)
        Me.ucrPrefixNewColumns.TabIndex = 16
        '
        'nudNumberOfSamples
        '
        Me.nudNumberOfSamples.Location = New System.Drawing.Point(119, 210)
        Me.nudNumberOfSamples.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumberOfSamples.Name = "nudNumberOfSamples"
        Me.nudNumberOfSamples.Size = New System.Drawing.Size(35, 20)
        Me.nudNumberOfSamples.TabIndex = 17
        Me.nudNumberOfSamples.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudSeed
        '
        Me.nudSeed.Location = New System.Drawing.Point(278, 210)
        Me.nudSeed.Name = "nudSeed"
        Me.nudSeed.Size = New System.Drawing.Size(35, 20)
        Me.nudSeed.TabIndex = 18
        '
        'chkSetSeed
        '
        Me.chkSetSeed.AutoSize = True
        Me.chkSetSeed.Location = New System.Drawing.Point(206, 212)
        Me.chkSetSeed.Name = "chkSetSeed"
        Me.chkSetSeed.Size = New System.Drawing.Size(70, 17)
        Me.chkSetSeed.TabIndex = 19
        Me.chkSetSeed.Tag = "Set_Seed"
        Me.chkSetSeed.Text = "Set Seed"
        Me.chkSetSeed.UseVisualStyleBackColor = True
        '
        'dlgRandomSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 327)
        Me.Controls.Add(Me.chkSetSeed)
        Me.Controls.Add(Me.nudSeed)
        Me.Controls.Add(Me.nudNumberOfSamples)
        Me.Controls.Add(Me.ucrPrefixNewColumns)
        Me.Controls.Add(Me.lblNewColumnName)
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
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents ucrPrefixNewColumns As ucrInputTextBox
    Friend WithEvents nudNumberOfSamples As NumericUpDown
    Friend WithEvents nudSeed As NumericUpDown
    Friend WithEvents chkSetSeed As CheckBox
End Class
