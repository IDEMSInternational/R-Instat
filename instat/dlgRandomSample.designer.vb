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
        Me.chkSetSeed = New System.Windows.Forms.CheckBox()
        Me.ucrSampleSize = New instat.ucrDataFrameLength()
        Me.ucrSelectorRandomSamples = New instat.ucrDataFrame()
        Me.ucrDistWithParameters = New instat.ucrDistributionsWithParameters()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrNudRepeatValues = New instat.ucrNud()
        Me.UcrNud1 = New instat.ucrNud()
        Me.ucrSavePermute = New instat.ucrSave()
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
        'ucrNudRepeatValues
        '
        Me.ucrNudRepeatValues.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRepeatValues.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRepeatValues.Location = New System.Drawing.Point(359, 65)
        Me.ucrNudRepeatValues.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRepeatValues.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRepeatValues.Name = "ucrNudRepeatValues"
        Me.ucrNudRepeatValues.Size = New System.Drawing.Size(50, 23)
        Me.ucrNudRepeatValues.TabIndex = 22
        Me.ucrNudRepeatValues.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrNud1
        '
        Me.UcrNud1.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNud1.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNud1.Location = New System.Drawing.Point(359, 94)
        Me.UcrNud1.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNud1.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNud1.Name = "UcrNud1"
        Me.UcrNud1.Size = New System.Drawing.Size(50, 23)
        Me.UcrNud1.TabIndex = 23
        Me.UcrNud1.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSavePermute
        '
        Me.ucrSavePermute.Location = New System.Drawing.Point(10, 218)
        Me.ucrSavePermute.Name = "ucrSavePermute"
        Me.ucrSavePermute.Size = New System.Drawing.Size(294, 24)
        Me.ucrSavePermute.TabIndex = 24
        '
        'dlgRandomSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 300)
        Me.Controls.Add(Me.ucrSavePermute)
        Me.Controls.Add(Me.UcrNud1)
        Me.Controls.Add(Me.ucrNudRepeatValues)
        Me.Controls.Add(Me.chkSetSeed)
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
    Friend WithEvents chkSetSeed As CheckBox
    Friend WithEvents ucrNudRepeatValues As ucrNud
    Friend WithEvents UcrNud1 As ucrNud
    Friend WithEvents ucrSavePermute As ucrSave
End Class
