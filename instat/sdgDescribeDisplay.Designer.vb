<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgDescribeDisplay
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
        Me.ucrButtonsDescribeDisplay = New instat.ucrButtonsSubdialogue()
        Me.chkSignifLevel = New System.Windows.Forms.CheckBox()
        Me.chkTranspose = New System.Windows.Forms.CheckBox()
        Me.chkProportions = New System.Windows.Forms.CheckBox()
        Me.chkAddMargins = New System.Windows.Forms.CheckBox()
        Me.grpFrequenciesOptions = New System.Windows.Forms.GroupBox()
        Me.chkPercentages = New System.Windows.Forms.CheckBox()
        Me.grpAnovaOptions = New System.Windows.Forms.GroupBox()
        Me.chkSignifStars = New System.Windows.Forms.CheckBox()
        Me.chkMeans = New System.Windows.Forms.CheckBox()
        Me.grpFrequenciesOptions.SuspendLayout()
        Me.grpAnovaOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrButtonsDescribeDisplay
        '
        Me.ucrButtonsDescribeDisplay.Location = New System.Drawing.Point(32, 178)
        Me.ucrButtonsDescribeDisplay.Name = "ucrButtonsDescribeDisplay"
        Me.ucrButtonsDescribeDisplay.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsDescribeDisplay.TabIndex = 2
        '
        'chkSignifLevel
        '
        Me.chkSignifLevel.AutoSize = True
        Me.chkSignifLevel.Location = New System.Drawing.Point(8, 40)
        Me.chkSignifLevel.Name = "chkSignifLevel"
        Me.chkSignifLevel.Size = New System.Drawing.Size(113, 17)
        Me.chkSignifLevel.TabIndex = 1
        Me.chkSignifLevel.Tag = "Significance_Level"
        Me.chkSignifLevel.Text = "Significance Level"
        Me.chkSignifLevel.UseVisualStyleBackColor = True
        '
        'chkTranspose
        '
        Me.chkTranspose.AutoSize = True
        Me.chkTranspose.Location = New System.Drawing.Point(99, 21)
        Me.chkTranspose.Name = "chkTranspose"
        Me.chkTranspose.Size = New System.Drawing.Size(76, 17)
        Me.chkTranspose.TabIndex = 5
        Me.chkTranspose.Tag = "Transpose"
        Me.chkTranspose.Text = "Transpose"
        Me.chkTranspose.UseVisualStyleBackColor = True
        '
        'chkProportions
        '
        Me.chkProportions.AutoSize = True
        Me.chkProportions.Location = New System.Drawing.Point(8, 44)
        Me.chkProportions.Name = "chkProportions"
        Me.chkProportions.Size = New System.Drawing.Size(79, 17)
        Me.chkProportions.TabIndex = 2
        Me.chkProportions.Tag = "Proportions"
        Me.chkProportions.Text = "Proportions"
        Me.chkProportions.UseVisualStyleBackColor = True
        '
        'chkAddMargins
        '
        Me.chkAddMargins.AutoSize = True
        Me.chkAddMargins.Location = New System.Drawing.Point(8, 21)
        Me.chkAddMargins.Name = "chkAddMargins"
        Me.chkAddMargins.Size = New System.Drawing.Size(85, 17)
        Me.chkAddMargins.TabIndex = 3
        Me.chkAddMargins.Tag = "Add_Margins"
        Me.chkAddMargins.Text = "Add Margins"
        Me.chkAddMargins.UseVisualStyleBackColor = True
        '
        'grpFrequenciesOptions
        '
        Me.grpFrequenciesOptions.Controls.Add(Me.chkTranspose)
        Me.grpFrequenciesOptions.Controls.Add(Me.chkPercentages)
        Me.grpFrequenciesOptions.Controls.Add(Me.chkProportions)
        Me.grpFrequenciesOptions.Controls.Add(Me.chkAddMargins)
        Me.grpFrequenciesOptions.Location = New System.Drawing.Point(7, 3)
        Me.grpFrequenciesOptions.Name = "grpFrequenciesOptions"
        Me.grpFrequenciesOptions.Size = New System.Drawing.Size(190, 73)
        Me.grpFrequenciesOptions.TabIndex = 112
        Me.grpFrequenciesOptions.TabStop = False
        Me.grpFrequenciesOptions.Tag = "Frequencies_Options"
        Me.grpFrequenciesOptions.Text = "Frequencies Options"
        '
        'chkPercentages
        '
        Me.chkPercentages.AutoSize = True
        Me.chkPercentages.Location = New System.Drawing.Point(99, 44)
        Me.chkPercentages.Name = "chkPercentages"
        Me.chkPercentages.Size = New System.Drawing.Size(86, 17)
        Me.chkPercentages.TabIndex = 4
        Me.chkPercentages.Tag = "Percentages"
        Me.chkPercentages.Text = "Percentages"
        Me.chkPercentages.UseVisualStyleBackColor = True
        '
        'grpAnovaOptions
        '
        Me.grpAnovaOptions.Controls.Add(Me.chkMeans)
        Me.grpAnovaOptions.Controls.Add(Me.chkSignifLevel)
        Me.grpAnovaOptions.Controls.Add(Me.chkSignifStars)
        Me.grpAnovaOptions.Location = New System.Drawing.Point(7, 86)
        Me.grpAnovaOptions.Name = "grpAnovaOptions"
        Me.grpAnovaOptions.Size = New System.Drawing.Size(157, 86)
        Me.grpAnovaOptions.TabIndex = 111
        Me.grpAnovaOptions.TabStop = False
        Me.grpAnovaOptions.Tag = "Anova_Options"
        Me.grpAnovaOptions.Text = "Anova Options"
        '
        'chkSignifStars
        '
        Me.chkSignifStars.AutoSize = True
        Me.chkSignifStars.Location = New System.Drawing.Point(8, 20)
        Me.chkSignifStars.Name = "chkSignifStars"
        Me.chkSignifStars.Size = New System.Drawing.Size(111, 17)
        Me.chkSignifStars.TabIndex = 0
        Me.chkSignifStars.Tag = "Significance_Stars"
        Me.chkSignifStars.Text = "Significance Stars"
        Me.chkSignifStars.UseVisualStyleBackColor = True
        '
        'chkMeans
        '
        Me.chkMeans.AutoSize = True
        Me.chkMeans.Location = New System.Drawing.Point(8, 61)
        Me.chkMeans.Name = "chkMeans"
        Me.chkMeans.Size = New System.Drawing.Size(58, 17)
        Me.chkMeans.TabIndex = 2
        Me.chkMeans.Tag = "Means"
        Me.chkMeans.Text = "Means"
        Me.chkMeans.UseVisualStyleBackColor = True
        '
        'sdgDescribeDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 213)
        Me.Controls.Add(Me.grpFrequenciesOptions)
        Me.Controls.Add(Me.grpAnovaOptions)
        Me.Controls.Add(Me.ucrButtonsDescribeDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgDescribeDisplay"
        Me.Tag = "Describe_Display_Options"
        Me.Text = "Describe Display Options"
        Me.grpFrequenciesOptions.ResumeLayout(False)
        Me.grpFrequenciesOptions.PerformLayout()
        Me.grpAnovaOptions.ResumeLayout(False)
        Me.grpAnovaOptions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrButtonsDescribeDisplay As ucrButtonsSubdialogue
    Friend WithEvents chkSignifLevel As CheckBox
    Friend WithEvents chkTranspose As CheckBox
    Friend WithEvents chkProportions As CheckBox
    Friend WithEvents chkAddMargins As CheckBox
    Friend WithEvents grpFrequenciesOptions As GroupBox
    Friend WithEvents chkPercentages As CheckBox
    Friend WithEvents grpAnovaOptions As GroupBox
    Friend WithEvents chkSignifStars As CheckBox
    Friend WithEvents chkMeans As CheckBox
End Class
