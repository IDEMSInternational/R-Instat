﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.ucrChkAddMargins = New instat.ucrCheck()
        Me.ucrChkTranspose = New instat.ucrCheck()
        Me.ucrChkProportions = New instat.ucrCheck()
        Me.ucrChkPercentages = New instat.ucrCheck()
        Me.grpAnovaOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkMeans = New instat.ucrCheck()
        Me.ucrChkSignifStars = New instat.ucrCheck()
        Me.ucrChkSignifLevel = New instat.ucrCheck()
        Me.grpFrequenciesOptions.SuspendLayout()
        Me.grpAnovaOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrButtonsDescribeDisplay
        '
        Me.ucrButtonsDescribeDisplay.Location = New System.Drawing.Point(55, 186)
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
        Me.grpFrequenciesOptions.Location = New System.Drawing.Point(10, 10)
        Me.grpFrequenciesOptions.Name = "grpFrequenciesOptions"
        Me.grpFrequenciesOptions.Size = New System.Drawing.Size(243, 68)
        Me.grpFrequenciesOptions.TabIndex = 0
        Me.grpFrequenciesOptions.TabStop = False
        Me.grpFrequenciesOptions.Tag = "Frequencies_Options"
        Me.grpFrequenciesOptions.Text = "Frequencies Options"
        '
        'ucrChkAddMargins
        '
        Me.ucrChkAddMargins.Checked = False
        Me.ucrChkAddMargins.Location = New System.Drawing.Point(10, 18)
        Me.ucrChkAddMargins.Name = "ucrChkAddMargins"
        Me.ucrChkAddMargins.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkAddMargins.TabIndex = 0
        '
        'ucrChkTranspose
        '
        Me.ucrChkTranspose.Checked = False
        Me.ucrChkTranspose.Location = New System.Drawing.Point(127, 18)
        Me.ucrChkTranspose.Name = "ucrChkTranspose"
        Me.ucrChkTranspose.Size = New System.Drawing.Size(97, 20)
        Me.ucrChkTranspose.TabIndex = 1
        '
        'ucrChkProportions
        '
        Me.ucrChkProportions.Checked = False
        Me.ucrChkProportions.Location = New System.Drawing.Point(10, 40)
        Me.ucrChkProportions.Name = "ucrChkProportions"
        Me.ucrChkProportions.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkProportions.TabIndex = 2
        '
        'ucrChkPercentages
        '
        Me.ucrChkPercentages.Checked = False
        Me.ucrChkPercentages.Location = New System.Drawing.Point(127, 40)
        Me.ucrChkPercentages.Name = "ucrChkPercentages"
        Me.ucrChkPercentages.Size = New System.Drawing.Size(97, 20)
        Me.ucrChkPercentages.TabIndex = 3
        '
        'grpAnovaOptions
        '
        Me.grpAnovaOptions.Controls.Add(Me.ucrChkMeans)
        Me.grpAnovaOptions.Controls.Add(Me.ucrChkSignifStars)
        Me.grpAnovaOptions.Controls.Add(Me.ucrChkSignifLevel)
        Me.grpAnovaOptions.Location = New System.Drawing.Point(10, 84)
        Me.grpAnovaOptions.Name = "grpAnovaOptions"
        Me.grpAnovaOptions.Size = New System.Drawing.Size(243, 91)
        Me.grpAnovaOptions.TabIndex = 1
        Me.grpAnovaOptions.TabStop = False
        Me.grpAnovaOptions.Tag = "Anova_Options"
        Me.grpAnovaOptions.Text = "Anova Options"
        '
        'ucrChkMeans
        '
        Me.ucrChkMeans.Checked = False
        Me.ucrChkMeans.Location = New System.Drawing.Point(10, 65)
        Me.ucrChkMeans.Name = "ucrChkMeans"
        Me.ucrChkMeans.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMeans.TabIndex = 2
        '
        'ucrChkSignifStars
        '
        Me.ucrChkSignifStars.Checked = False
        Me.ucrChkSignifStars.Location = New System.Drawing.Point(10, 19)
        Me.ucrChkSignifStars.Name = "ucrChkSignifStars"
        Me.ucrChkSignifStars.Size = New System.Drawing.Size(143, 20)
        Me.ucrChkSignifStars.TabIndex = 0
        '
        'ucrChkSignifLevel
        '
        Me.ucrChkSignifLevel.Checked = False
        Me.ucrChkSignifLevel.Location = New System.Drawing.Point(10, 42)
        Me.ucrChkSignifLevel.Name = "ucrChkSignifLevel"
        Me.ucrChkSignifLevel.Size = New System.Drawing.Size(143, 20)
        Me.ucrChkSignifLevel.TabIndex = 1
        '
        'sdgDescribeDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 222)
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
