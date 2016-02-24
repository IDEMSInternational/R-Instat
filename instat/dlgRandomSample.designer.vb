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
        Me.lblSeed = New System.Windows.Forms.Label()
        Me.txtSeed = New System.Windows.Forms.TextBox()
        Me.ucrDistWithParameters = New instat.ucrDistributionsWithParameters()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFrameSelector = New instat.ucrDataFrame()
        Me.ucrNewColumnNameSelector = New instat.ucrNewColumnName()
        Me.lblSampleSize = New System.Windows.Forms.Label()
        Me.lblNumberofSamples = New System.Windows.Forms.Label()
        Me.txtNumberofSamples = New System.Windows.Forms.TextBox()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrSampleSize = New instat.ucrDataFrameLength()
        Me.SuspendLayout()
        '
        'lblSeed
        '
        Me.lblSeed.AutoSize = True
        Me.lblSeed.Location = New System.Drawing.Point(276, 269)
        Me.lblSeed.Name = "lblSeed"
        Me.lblSeed.Size = New System.Drawing.Size(32, 13)
        Me.lblSeed.TabIndex = 5
        Me.lblSeed.Tag = "Seed"
        Me.lblSeed.Text = "Seed"
        '
        'txtSeed
        '
        Me.txtSeed.Location = New System.Drawing.Point(315, 262)
        Me.txtSeed.Name = "txtSeed"
        Me.txtSeed.Size = New System.Drawing.Size(47, 20)
        Me.txtSeed.TabIndex = 6
        '
        'ucrDistWithParameters
        '
        Me.ucrDistWithParameters.Location = New System.Drawing.Point(6, 45)
        Me.ucrDistWithParameters.Name = "ucrDistWithParameters"
        Me.ucrDistWithParameters.Size = New System.Drawing.Size(221, 156)
        Me.ucrDistWithParameters.TabIndex = 7
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 286)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 55)
        Me.ucrBase.TabIndex = 0
        '
        'ucrDataFrameSelector
        '
        Me.ucrDataFrameSelector.Location = New System.Drawing.Point(3, 2)
        Me.ucrDataFrameSelector.Name = "ucrDataFrameSelector"
        Me.ucrDataFrameSelector.Size = New System.Drawing.Size(127, 41)
        Me.ucrDataFrameSelector.TabIndex = 8
        '
        'ucrNewColumnNameSelector
        '
        Me.ucrNewColumnNameSelector.Location = New System.Drawing.Point(3, 226)
        Me.ucrNewColumnNameSelector.Name = "ucrNewColumnNameSelector"
        Me.ucrNewColumnNameSelector.Size = New System.Drawing.Size(376, 35)
        Me.ucrNewColumnNameSelector.TabIndex = 9
        Me.ucrNewColumnNameSelector.ucrDataFrameSelector = Nothing
        '
        'lblSampleSize
        '
        Me.lblSampleSize.AutoSize = True
        Me.lblSampleSize.Location = New System.Drawing.Point(171, 3)
        Me.lblSampleSize.Name = "lblSampleSize"
        Me.lblSampleSize.Size = New System.Drawing.Size(65, 13)
        Me.lblSampleSize.TabIndex = 10
        Me.lblSampleSize.Tag = "Sample_Size"
        Me.lblSampleSize.Text = "Sample Size"
        '
        'lblNumberofSamples
        '
        Me.lblNumberofSamples.AutoSize = True
        Me.lblNumberofSamples.Location = New System.Drawing.Point(288, 3)
        Me.lblNumberofSamples.Name = "lblNumberofSamples"
        Me.lblNumberofSamples.Size = New System.Drawing.Size(99, 13)
        Me.lblNumberofSamples.TabIndex = 10
        Me.lblNumberofSamples.Tag = "Number_of_Samples"
        Me.lblNumberofSamples.Text = "Number of Samples"
        '
        'txtNumberofSamples
        '
        Me.txtNumberofSamples.Location = New System.Drawing.Point(291, 19)
        Me.txtNumberofSamples.Name = "txtNumberofSamples"
        Me.txtNumberofSamples.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberofSamples.TabIndex = 11
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(331, 197)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdOptions.TabIndex = 12
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrSampleSize
        '
        Me.ucrSampleSize.clsDataFrameSelector = Nothing
        Me.ucrSampleSize.Location = New System.Drawing.Point(174, 19)
        Me.ucrSampleSize.Name = "ucrSampleSize"
        Me.ucrSampleSize.Size = New System.Drawing.Size(53, 23)
        Me.ucrSampleSize.TabIndex = 13
        '
        'dlgRandomSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 342)
        Me.Controls.Add(Me.ucrSampleSize)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.txtNumberofSamples)
        Me.Controls.Add(Me.lblNumberofSamples)
        Me.Controls.Add(Me.lblSampleSize)
        Me.Controls.Add(Me.ucrNewColumnNameSelector)
        Me.Controls.Add(Me.ucrDataFrameSelector)
        Me.Controls.Add(Me.ucrDistWithParameters)
        Me.Controls.Add(Me.txtSeed)
        Me.Controls.Add(Me.lblSeed)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRandomSample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generate Random Sample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblSeed As Label
    Friend WithEvents txtSeed As TextBox
    Friend WithEvents ucrDistWithParameters As ucrDistributionsWithParameters
    Friend WithEvents ucrDataFrameSelector As ucrDataFrame
    Friend WithEvents ucrNewColumnNameSelector As ucrNewColumnName
    Friend WithEvents lblSampleSize As Label
    Friend WithEvents lblNumberofSamples As Label
    Friend WithEvents txtNumberofSamples As TextBox
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrSampleSize As ucrDataFrameLength
End Class
