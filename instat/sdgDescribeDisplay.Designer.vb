<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgDescribeDisplay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ucrButtonsDescribeDisplay = New instat.ucrButtonsSubdialogue()
        Me.grpFrequenciesOptions = New System.Windows.Forms.GroupBox()
        Me.grpAnovaOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkAddMargins = New instat.ucrCheck()
        Me.ucrChkProportions = New instat.ucrCheck()
        Me.ucrChkPercentages = New instat.ucrCheck()
        Me.ucrChkTranspose = New instat.ucrCheck()
        Me.ucrChkSignifStars = New instat.ucrCheck()
        Me.ucrChkSignifLevel = New instat.ucrCheck()
        Me.ucrChkMeans = New instat.ucrCheck()
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
        'grpFrequenciesOptions
        '
        Me.grpFrequenciesOptions.Controls.Add(Me.ucrChkAddMargins)
        Me.grpFrequenciesOptions.Controls.Add(Me.ucrChkTranspose)
        Me.grpFrequenciesOptions.Controls.Add(Me.ucrChkProportions)
        Me.grpFrequenciesOptions.Controls.Add(Me.ucrChkPercentages)
        Me.grpFrequenciesOptions.Location = New System.Drawing.Point(12, 12)
        Me.grpFrequenciesOptions.Name = "grpFrequenciesOptions"
        Me.grpFrequenciesOptions.Size = New System.Drawing.Size(218, 64)
        Me.grpFrequenciesOptions.TabIndex = 0
        Me.grpFrequenciesOptions.TabStop = False
        Me.grpFrequenciesOptions.Tag = "Frequencies_Options"
        Me.grpFrequenciesOptions.Text = "Frequencies Options"
        '
        'grpAnovaOptions
        '
        Me.grpAnovaOptions.Controls.Add(Me.ucrChkMeans)
        Me.grpAnovaOptions.Controls.Add(Me.ucrChkSignifStars)
        Me.grpAnovaOptions.Controls.Add(Me.ucrChkSignifLevel)
        Me.grpAnovaOptions.Location = New System.Drawing.Point(12, 86)
        Me.grpAnovaOptions.Name = "grpAnovaOptions"
        Me.grpAnovaOptions.Size = New System.Drawing.Size(190, 86)
        Me.grpAnovaOptions.TabIndex = 1
        Me.grpAnovaOptions.TabStop = False
        Me.grpAnovaOptions.Tag = "Anova_Options"
        Me.grpAnovaOptions.Text = "Anova Options"
        '
        'ucrChkAddMargins
        '
        Me.ucrChkAddMargins.Checked = False
        Me.ucrChkAddMargins.Location = New System.Drawing.Point(6, 18)
        Me.ucrChkAddMargins.Name = "ucrChkAddMargins"
        Me.ucrChkAddMargins.Size = New System.Drawing.Size(92, 20)
        Me.ucrChkAddMargins.TabIndex = 3
        '
        'ucrChkProportions
        '
        Me.ucrChkProportions.Checked = False
        Me.ucrChkProportions.Location = New System.Drawing.Point(10, 38)
        Me.ucrChkProportions.Name = "ucrChkProportions"
        Me.ucrChkProportions.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkProportions.TabIndex = 4
        '
        'ucrChkPercentages
        '
        Me.ucrChkPercentages.Checked = False
        Me.ucrChkPercentages.Location = New System.Drawing.Point(115, 38)
        Me.ucrChkPercentages.Name = "ucrChkPercentages"
        Me.ucrChkPercentages.Size = New System.Drawing.Size(89, 20)
        Me.ucrChkPercentages.TabIndex = 5
        '
        'ucrChkTranspose
        '
        Me.ucrChkTranspose.Checked = False
        Me.ucrChkTranspose.Location = New System.Drawing.Point(110, 19)
        Me.ucrChkTranspose.Name = "ucrChkTranspose"
        Me.ucrChkTranspose.Size = New System.Drawing.Size(97, 20)
        Me.ucrChkTranspose.TabIndex = 6
        '
        'ucrChkSignifStars
        '
        Me.ucrChkSignifStars.Checked = False
        Me.ucrChkSignifStars.Location = New System.Drawing.Point(10, 19)
        Me.ucrChkSignifStars.Name = "ucrChkSignifStars"
        Me.ucrChkSignifStars.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSignifStars.TabIndex = 7
        '
        'ucrChkSignifLevel
        '
        Me.ucrChkSignifLevel.Checked = False
        Me.ucrChkSignifLevel.Location = New System.Drawing.Point(9, 39)
        Me.ucrChkSignifLevel.Name = "ucrChkSignifLevel"
        Me.ucrChkSignifLevel.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSignifLevel.TabIndex = 8
        '
        'ucrChkMeans
        '
        Me.ucrChkMeans.Checked = False
        Me.ucrChkMeans.Location = New System.Drawing.Point(6, 60)
        Me.ucrChkMeans.Name = "ucrChkMeans"
        Me.ucrChkMeans.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMeans.TabIndex = 9
        '
        'sdgDescribeDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 213)
        Me.Controls.Add(Me.grpFrequenciesOptions)
        Me.Controls.Add(Me.grpAnovaOptions)
        Me.Controls.Add(Me.ucrButtonsDescribeDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgDescribeDisplay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Describe_Display_Options"
        Me.Text = "Describe Display Options"
        Me.grpFrequenciesOptions.ResumeLayout(False)
        Me.grpAnovaOptions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrButtonsDescribeDisplay As ucrButtonsSubdialogue
    Friend WithEvents grpFrequenciesOptions As GroupBox
    Friend WithEvents grpAnovaOptions As GroupBox
    Friend WithEvents ucrChkAddMargins As ucrCheck
    Friend WithEvents ucrChkProportions As ucrCheck
    Friend WithEvents ucrChkPercentages As ucrCheck
    Friend WithEvents ucrChkTranspose As ucrCheck
    Friend WithEvents ucrChkSignifStars As ucrCheck
    Friend WithEvents ucrChkSignifLevel As ucrCheck
    Friend WithEvents ucrChkMeans As ucrCheck
End Class
