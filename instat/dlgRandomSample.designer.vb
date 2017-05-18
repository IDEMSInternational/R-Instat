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
        Me.ucrSampleSize = New instat.ucrDataFrameLength()
        Me.ucrSelectorRandomSamples = New instat.ucrDataFrame()
        Me.ucrDistWithParameters = New instat.ucrDistributionsWithParameters()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrNudSetSeed = New instat.ucrNud()
        Me.ucrNudNumberOfSamples = New instat.ucrNud()
        Me.ucrSaveRandomSample = New instat.ucrSave()
        Me.ucrChkSetSeed = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'lblSampleSize
        '
        Me.lblSampleSize.AutoSize = True
        Me.lblSampleSize.Location = New System.Drawing.Point(250, 123)
        Me.lblSampleSize.Name = "lblSampleSize"
        Me.lblSampleSize.Size = New System.Drawing.Size(68, 13)
        Me.lblSampleSize.TabIndex = 10
        Me.lblSampleSize.Tag = "Sample_Size:"
        Me.lblSampleSize.Text = "Sample Size:"
        '
        'lblNumberofSamples
        '
        Me.lblNumberofSamples.AutoSize = True
        Me.lblNumberofSamples.Location = New System.Drawing.Point(250, 97)
        Me.lblNumberofSamples.Name = "lblNumberofSamples"
        Me.lblNumberofSamples.Size = New System.Drawing.Size(102, 13)
        Me.lblNumberofSamples.TabIndex = 10
        Me.lblNumberofSamples.Tag = "Number_of_Samples:"
        Me.lblNumberofSamples.Text = "Number of Samples:"
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
        Me.ucrDistWithParameters.Location = New System.Drawing.Point(10, 65)
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
        'ucrNudSetSeed
        '
        Me.ucrNudSetSeed.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSetSeed.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSetSeed.Location = New System.Drawing.Point(359, 65)
        Me.ucrNudSetSeed.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSetSeed.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSetSeed.Name = "ucrNudSetSeed"
        Me.ucrNudSetSeed.Size = New System.Drawing.Size(50, 23)
        Me.ucrNudSetSeed.TabIndex = 22
        Me.ucrNudSetSeed.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudNumberOfSamples
        '
        Me.ucrNudNumberOfSamples.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfSamples.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberOfSamples.Location = New System.Drawing.Point(359, 94)
        Me.ucrNudNumberOfSamples.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberOfSamples.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfSamples.Name = "ucrNudNumberOfSamples"
        Me.ucrNudNumberOfSamples.Size = New System.Drawing.Size(50, 23)
        Me.ucrNudNumberOfSamples.TabIndex = 23
        Me.ucrNudNumberOfSamples.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSaveRandomSample
        '
        Me.ucrSaveRandomSample.Location = New System.Drawing.Point(10, 218)
        Me.ucrSaveRandomSample.Name = "ucrSaveRandomSample"
        Me.ucrSaveRandomSample.Size = New System.Drawing.Size(294, 24)
        Me.ucrSaveRandomSample.TabIndex = 24
        '
        'ucrChkSetSeed
        '
        Me.ucrChkSetSeed.Checked = False
        Me.ucrChkSetSeed.Location = New System.Drawing.Point(253, 65)
        Me.ucrChkSetSeed.Name = "ucrChkSetSeed"
        Me.ucrChkSetSeed.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSetSeed.TabIndex = 25
        '
        'dlgRandomSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 300)
        Me.Controls.Add(Me.ucrChkSetSeed)
        Me.Controls.Add(Me.ucrSaveRandomSample)
        Me.Controls.Add(Me.ucrNudNumberOfSamples)
        Me.Controls.Add(Me.ucrNudSetSeed)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDistWithParameters As ucrDistributionsWithParameters
    Friend WithEvents ucrSelectorRandomSamples As ucrDataFrame
    Friend WithEvents lblSampleSize As Label
    Friend WithEvents lblNumberofSamples As Label
    Friend WithEvents ucrSampleSize As ucrDataFrameLength
    Friend WithEvents ucrNudSetSeed As ucrNud
    Friend WithEvents ucrNudNumberOfSamples As ucrNud
    Friend WithEvents ucrSaveRandomSample As ucrSave
    Friend WithEvents ucrChkSetSeed As ucrCheck
End Class
