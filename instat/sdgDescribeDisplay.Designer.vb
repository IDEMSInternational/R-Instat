' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgDescribeDisplay))
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
        resources.ApplyResources(Me.ucrButtonsDescribeDisplay, "ucrButtonsDescribeDisplay")
        Me.ucrButtonsDescribeDisplay.Name = "ucrButtonsDescribeDisplay"
        '
        'grpFrequenciesOptions
        '
        Me.grpFrequenciesOptions.Controls.Add(Me.ucrChkAddMargins)
        Me.grpFrequenciesOptions.Controls.Add(Me.ucrChkTranspose)
        Me.grpFrequenciesOptions.Controls.Add(Me.ucrChkProportions)
        Me.grpFrequenciesOptions.Controls.Add(Me.ucrChkPercentages)
        resources.ApplyResources(Me.grpFrequenciesOptions, "grpFrequenciesOptions")
        Me.grpFrequenciesOptions.Name = "grpFrequenciesOptions"
        Me.grpFrequenciesOptions.TabStop = False
        Me.grpFrequenciesOptions.Tag = "Frequencies_Options"
        '
        'ucrChkAddMargins
        '
        Me.ucrChkAddMargins.Checked = False
        resources.ApplyResources(Me.ucrChkAddMargins, "ucrChkAddMargins")
        Me.ucrChkAddMargins.Name = "ucrChkAddMargins"
        '
        'ucrChkTranspose
        '
        Me.ucrChkTranspose.Checked = False
        resources.ApplyResources(Me.ucrChkTranspose, "ucrChkTranspose")
        Me.ucrChkTranspose.Name = "ucrChkTranspose"
        '
        'ucrChkProportions
        '
        Me.ucrChkProportions.Checked = False
        resources.ApplyResources(Me.ucrChkProportions, "ucrChkProportions")
        Me.ucrChkProportions.Name = "ucrChkProportions"
        '
        'ucrChkPercentages
        '
        Me.ucrChkPercentages.Checked = False
        resources.ApplyResources(Me.ucrChkPercentages, "ucrChkPercentages")
        Me.ucrChkPercentages.Name = "ucrChkPercentages"
        '
        'grpAnovaOptions
        '
        Me.grpAnovaOptions.Controls.Add(Me.ucrChkMeans)
        Me.grpAnovaOptions.Controls.Add(Me.ucrChkSignifStars)
        Me.grpAnovaOptions.Controls.Add(Me.ucrChkSignifLevel)
        resources.ApplyResources(Me.grpAnovaOptions, "grpAnovaOptions")
        Me.grpAnovaOptions.Name = "grpAnovaOptions"
        Me.grpAnovaOptions.TabStop = False
        Me.grpAnovaOptions.Tag = "Anova_Options"
        '
        'ucrChkMeans
        '
        Me.ucrChkMeans.Checked = False
        resources.ApplyResources(Me.ucrChkMeans, "ucrChkMeans")
        Me.ucrChkMeans.Name = "ucrChkMeans"
        '
        'ucrChkSignifStars
        '
        Me.ucrChkSignifStars.Checked = False
        resources.ApplyResources(Me.ucrChkSignifStars, "ucrChkSignifStars")
        Me.ucrChkSignifStars.Name = "ucrChkSignifStars"
        '
        'ucrChkSignifLevel
        '
        Me.ucrChkSignifLevel.Checked = False
        resources.ApplyResources(Me.ucrChkSignifLevel, "ucrChkSignifLevel")
        Me.ucrChkSignifLevel.Name = "ucrChkSignifLevel"
        '
        'sdgDescribeDisplay
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpFrequenciesOptions)
        Me.Controls.Add(Me.grpAnovaOptions)
        Me.Controls.Add(Me.ucrButtonsDescribeDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgDescribeDisplay"
        Me.Tag = "Describe_Display_Options"
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
