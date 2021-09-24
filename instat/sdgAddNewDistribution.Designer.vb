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
Partial Class sdgAddNewDistribution
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgAddNewDistribution))
        Me.ucrBaseSubDialog = New instat.ucrButtonsSubdialogue()
        Me.ucrNewDistributions = New instat.ucrDistributionsWithParameters()
        Me.grpChangeLimits = New System.Windows.Forms.GroupBox()
        Me.nudYlimUpper = New System.Windows.Forms.NumericUpDown()
        Me.nudXlimUpper = New System.Windows.Forms.NumericUpDown()
        Me.nudYlimLower = New System.Windows.Forms.NumericUpDown()
        Me.nudXlimLower = New System.Windows.Forms.NumericUpDown()
        Me.lblYlim = New System.Windows.Forms.Label()
        Me.lblXlim = New System.Windows.Forms.Label()
        Me.grpPlot = New System.Windows.Forms.GroupBox()
        Me.rdoProbability = New System.Windows.Forms.RadioButton()
        Me.rdoDensity = New System.Windows.Forms.RadioButton()
        Me.cmdAddDistribution = New System.Windows.Forms.Button()
        Me.lstAddedDistribution = New System.Windows.Forms.ListBox()
        Me.lblAddedDistribution = New System.Windows.Forms.Label()
        Me.grpChangeLimits.SuspendLayout()
        CType(Me.nudYlimUpper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudXlimUpper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudYlimLower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudXlimLower, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPlot.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBaseSubDialog
        '
        resources.ApplyResources(Me.ucrBaseSubDialog, "ucrBaseSubDialog")
        Me.ucrBaseSubDialog.Name = "ucrBaseSubDialog"
        '
        'ucrNewDistributions
        '
        resources.ApplyResources(Me.ucrNewDistributions, "ucrNewDistributions")
        Me.ucrNewDistributions.Name = "ucrNewDistributions"
        '
        'grpChangeLimits
        '
        Me.grpChangeLimits.Controls.Add(Me.nudYlimUpper)
        Me.grpChangeLimits.Controls.Add(Me.nudXlimUpper)
        Me.grpChangeLimits.Controls.Add(Me.nudYlimLower)
        Me.grpChangeLimits.Controls.Add(Me.nudXlimLower)
        Me.grpChangeLimits.Controls.Add(Me.lblYlim)
        Me.grpChangeLimits.Controls.Add(Me.lblXlim)
        resources.ApplyResources(Me.grpChangeLimits, "grpChangeLimits")
        Me.grpChangeLimits.Name = "grpChangeLimits"
        Me.grpChangeLimits.TabStop = False
        '
        'nudYlimUpper
        '
        resources.ApplyResources(Me.nudYlimUpper, "nudYlimUpper")
        Me.nudYlimUpper.Name = "nudYlimUpper"
        '
        'nudXlimUpper
        '
        resources.ApplyResources(Me.nudXlimUpper, "nudXlimUpper")
        Me.nudXlimUpper.Name = "nudXlimUpper"
        '
        'nudYlimLower
        '
        resources.ApplyResources(Me.nudYlimLower, "nudYlimLower")
        Me.nudYlimLower.Name = "nudYlimLower"
        '
        'nudXlimLower
        '
        resources.ApplyResources(Me.nudXlimLower, "nudXlimLower")
        Me.nudXlimLower.Name = "nudXlimLower"
        '
        'lblYlim
        '
        resources.ApplyResources(Me.lblYlim, "lblYlim")
        Me.lblYlim.Name = "lblYlim"
        '
        'lblXlim
        '
        resources.ApplyResources(Me.lblXlim, "lblXlim")
        Me.lblXlim.Name = "lblXlim"
        '
        'grpPlot
        '
        Me.grpPlot.Controls.Add(Me.rdoProbability)
        Me.grpPlot.Controls.Add(Me.rdoDensity)
        resources.ApplyResources(Me.grpPlot, "grpPlot")
        Me.grpPlot.Name = "grpPlot"
        Me.grpPlot.TabStop = False
        '
        'rdoProbability
        '
        resources.ApplyResources(Me.rdoProbability, "rdoProbability")
        Me.rdoProbability.Name = "rdoProbability"
        Me.rdoProbability.TabStop = True
        Me.rdoProbability.UseVisualStyleBackColor = True
        '
        'rdoDensity
        '
        resources.ApplyResources(Me.rdoDensity, "rdoDensity")
        Me.rdoDensity.Name = "rdoDensity"
        Me.rdoDensity.TabStop = True
        Me.rdoDensity.UseVisualStyleBackColor = True
        '
        'cmdAddDistribution
        '
        resources.ApplyResources(Me.cmdAddDistribution, "cmdAddDistribution")
        Me.cmdAddDistribution.Name = "cmdAddDistribution"
        Me.cmdAddDistribution.UseVisualStyleBackColor = True
        '
        'lstAddedDistribution
        '
        Me.lstAddedDistribution.FormattingEnabled = True
        resources.ApplyResources(Me.lstAddedDistribution, "lstAddedDistribution")
        Me.lstAddedDistribution.Name = "lstAddedDistribution"
        '
        'lblAddedDistribution
        '
        resources.ApplyResources(Me.lblAddedDistribution, "lblAddedDistribution")
        Me.lblAddedDistribution.Name = "lblAddedDistribution"
        '
        'sdgAddNewDistribution
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblAddedDistribution)
        Me.Controls.Add(Me.lstAddedDistribution)
        Me.Controls.Add(Me.cmdAddDistribution)
        Me.Controls.Add(Me.grpPlot)
        Me.Controls.Add(Me.grpChangeLimits)
        Me.Controls.Add(Me.ucrNewDistributions)
        Me.Controls.Add(Me.ucrBaseSubDialog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgAddNewDistribution"
        Me.grpChangeLimits.ResumeLayout(False)
        Me.grpChangeLimits.PerformLayout()
        CType(Me.nudYlimUpper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudXlimUpper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudYlimLower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudXlimLower, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPlot.ResumeLayout(False)
        Me.grpPlot.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSubDialog As ucrButtonsSubdialogue
    Friend WithEvents ucrNewDistributions As ucrDistributionsWithParameters
    Friend WithEvents grpChangeLimits As GroupBox
    Friend WithEvents nudXlimLower As NumericUpDown
    Friend WithEvents lblYlim As Label
    Friend WithEvents lblXlim As Label
    Friend WithEvents nudYlimUpper As NumericUpDown
    Friend WithEvents nudXlimUpper As NumericUpDown
    Friend WithEvents nudYlimLower As NumericUpDown
    Friend WithEvents grpPlot As GroupBox
    Friend WithEvents rdoProbability As RadioButton
    Friend WithEvents rdoDensity As RadioButton
    Friend WithEvents cmdAddDistribution As Button
    Friend WithEvents lstAddedDistribution As ListBox
    Friend WithEvents lblAddedDistribution As Label
End Class
