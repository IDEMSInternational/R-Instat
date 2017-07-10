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
Partial Class sdgANOVAOptions
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
        Me.ucrBaseSdg = New instat.ucrButtonsSubdialogue()
        Me.tbpGraphics = New System.Windows.Forms.TabPage()
        Me.grpResiduals = New System.Windows.Forms.GroupBox()
        Me.chkResiduals = New System.Windows.Forms.CheckBox()
        Me.grpMeans = New System.Windows.Forms.GroupBox()
        Me.chkMeans = New System.Windows.Forms.CheckBox()
        Me.chkConfidenceLimits = New System.Windows.Forms.CheckBox()
        Me.lblConfidenceLevel = New System.Windows.Forms.Label()
        Me.nudConfidenceLevel = New System.Windows.Forms.NumericUpDown()
        Me.tbcOptions = New System.Windows.Forms.TabControl()
        Me.chkANOVATable = New System.Windows.Forms.CheckBox()
        Me.chkEstimateValues = New System.Windows.Forms.CheckBox()
        Me.chkMeansAndCounts = New System.Windows.Forms.CheckBox()
        Me.chkStandardErrors = New System.Windows.Forms.CheckBox()
        Me.chkContrasts = New System.Windows.Forms.CheckBox()
        Me.tbpDisplay = New System.Windows.Forms.TabPage()
        Me.tbpGraphics.SuspendLayout()
        Me.grpResiduals.SuspendLayout()
        Me.grpMeans.SuspendLayout()
        CType(Me.nudConfidenceLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcOptions.SuspendLayout()
        Me.tbpDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBaseSdg
        '
        Me.ucrBaseSdg.Location = New System.Drawing.Point(53, 116)
        Me.ucrBaseSdg.Name = "ucrBaseSdg"
        Me.ucrBaseSdg.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSdg.TabIndex = 0
        '
        'tbpGraphics
        '
        Me.tbpGraphics.Controls.Add(Me.grpMeans)
        Me.tbpGraphics.Controls.Add(Me.grpResiduals)
        Me.tbpGraphics.Location = New System.Drawing.Point(4, 22)
        Me.tbpGraphics.Name = "tbpGraphics"
        Me.tbpGraphics.Size = New System.Drawing.Size(192, 74)
        Me.tbpGraphics.TabIndex = 1
        Me.tbpGraphics.Tag = "Graphics"
        Me.tbpGraphics.UseVisualStyleBackColor = True
        '
        'grpResiduals
        '
        Me.grpResiduals.Controls.Add(Me.chkResiduals)
        Me.grpResiduals.Location = New System.Drawing.Point(0, 0)
        Me.grpResiduals.Name = "grpResiduals"
        Me.grpResiduals.Size = New System.Drawing.Size(200, 100)
        Me.grpResiduals.TabIndex = 1
        Me.grpResiduals.TabStop = False
        Me.grpResiduals.Tag = "Residuals"
        '
        'chkResiduals
        '
        Me.chkResiduals.Location = New System.Drawing.Point(0, 0)
        Me.chkResiduals.Name = "chkResiduals"
        Me.chkResiduals.Size = New System.Drawing.Size(104, 24)
        Me.chkResiduals.TabIndex = 0
        Me.chkResiduals.Tag = "Four_in_one"
        Me.chkResiduals.UseVisualStyleBackColor = True
        '
        'grpMeans
        '
        Me.grpMeans.Controls.Add(Me.nudConfidenceLevel)
        Me.grpMeans.Controls.Add(Me.lblConfidenceLevel)
        Me.grpMeans.Controls.Add(Me.chkConfidenceLimits)
        Me.grpMeans.Controls.Add(Me.chkMeans)
        Me.grpMeans.Location = New System.Drawing.Point(0, 0)
        Me.grpMeans.Name = "grpMeans"
        Me.grpMeans.Size = New System.Drawing.Size(200, 100)
        Me.grpMeans.TabIndex = 0
        Me.grpMeans.TabStop = False
        Me.grpMeans.Tag = "Means"
        '
        'chkMeans
        '
        Me.chkMeans.Location = New System.Drawing.Point(0, 0)
        Me.chkMeans.Name = "chkMeans"
        Me.chkMeans.Size = New System.Drawing.Size(104, 24)
        Me.chkMeans.TabIndex = 3
        Me.chkMeans.Tag = "Means"
        Me.chkMeans.UseVisualStyleBackColor = True
        '
        'chkConfidenceLimits
        '
        Me.chkConfidenceLimits.Location = New System.Drawing.Point(0, 0)
        Me.chkConfidenceLimits.Name = "chkConfidenceLimits"
        Me.chkConfidenceLimits.Size = New System.Drawing.Size(104, 24)
        Me.chkConfidenceLimits.TabIndex = 2
        Me.chkConfidenceLimits.Tag = "Confidence_limits"
        Me.chkConfidenceLimits.UseVisualStyleBackColor = True
        '
        'lblConfidenceLevel
        '
        Me.lblConfidenceLevel.Location = New System.Drawing.Point(0, 0)
        Me.lblConfidenceLevel.Name = "lblConfidenceLevel"
        Me.lblConfidenceLevel.Size = New System.Drawing.Size(100, 23)
        Me.lblConfidenceLevel.TabIndex = 1
        Me.lblConfidenceLevel.Tag = "Confidence_level"
        '
        'nudConfidenceLevel
        '
        Me.nudConfidenceLevel.Location = New System.Drawing.Point(0, 0)
        Me.nudConfidenceLevel.Name = "nudConfidenceLevel"
        Me.nudConfidenceLevel.Size = New System.Drawing.Size(120, 20)
        Me.nudConfidenceLevel.TabIndex = 0
        Me.nudConfidenceLevel.Value = New Decimal(New Integer() {95, 0, 0, 0})
        '
        'tbcOptions
        '
        Me.tbcOptions.Controls.Add(Me.tbpDisplay)
        Me.tbcOptions.Controls.Add(Me.tbpGraphics)
        Me.tbcOptions.Location = New System.Drawing.Point(14, 9)
        Me.tbcOptions.Name = "tbcOptions"
        Me.tbcOptions.SelectedIndex = 0
        Me.tbcOptions.Size = New System.Drawing.Size(200, 100)
        Me.tbcOptions.TabIndex = 1
        '
        'chkANOVATable
        '
        Me.chkANOVATable.Location = New System.Drawing.Point(0, 0)
        Me.chkANOVATable.Name = "chkANOVATable"
        Me.chkANOVATable.Size = New System.Drawing.Size(104, 24)
        Me.chkANOVATable.TabIndex = 4
        Me.chkANOVATable.Tag = "ANOVA Table"
        Me.chkANOVATable.UseVisualStyleBackColor = True
        '
        'chkEstimateValues
        '
        Me.chkEstimateValues.Location = New System.Drawing.Point(0, 0)
        Me.chkEstimateValues.Name = "chkEstimateValues"
        Me.chkEstimateValues.Size = New System.Drawing.Size(104, 24)
        Me.chkEstimateValues.TabIndex = 3
        Me.chkEstimateValues.Tag = "P_values"
        Me.chkEstimateValues.UseVisualStyleBackColor = True
        '
        'chkMeansAndCounts
        '
        Me.chkMeansAndCounts.Location = New System.Drawing.Point(0, 0)
        Me.chkMeansAndCounts.Name = "chkMeansAndCounts"
        Me.chkMeansAndCounts.Size = New System.Drawing.Size(104, 24)
        Me.chkMeansAndCounts.TabIndex = 2
        Me.chkMeansAndCounts.Tag = "Means_and_counts"
        Me.chkMeansAndCounts.UseVisualStyleBackColor = True
        '
        'chkStandardErrors
        '
        Me.chkStandardErrors.Location = New System.Drawing.Point(0, 0)
        Me.chkStandardErrors.Name = "chkStandardErrors"
        Me.chkStandardErrors.Size = New System.Drawing.Size(104, 24)
        Me.chkStandardErrors.TabIndex = 1
        Me.chkStandardErrors.Tag = "Standard_errors"
        Me.chkStandardErrors.UseVisualStyleBackColor = True
        '
        'chkContrasts
        '
        Me.chkContrasts.Location = New System.Drawing.Point(0, 0)
        Me.chkContrasts.Name = "chkContrasts"
        Me.chkContrasts.Size = New System.Drawing.Size(104, 24)
        Me.chkContrasts.TabIndex = 0
        Me.chkContrasts.Tag = "Contrasts"
        Me.chkContrasts.UseVisualStyleBackColor = True
        '
        'tbpDisplay
        '
        Me.tbpDisplay.Controls.Add(Me.chkContrasts)
        Me.tbpDisplay.Controls.Add(Me.chkStandardErrors)
        Me.tbpDisplay.Controls.Add(Me.chkMeansAndCounts)
        Me.tbpDisplay.Controls.Add(Me.chkEstimateValues)
        Me.tbpDisplay.Controls.Add(Me.chkANOVATable)
        Me.tbpDisplay.Location = New System.Drawing.Point(4, 22)
        Me.tbpDisplay.Name = "tbpDisplay"
        Me.tbpDisplay.Size = New System.Drawing.Size(192, 74)
        Me.tbpDisplay.TabIndex = 0
        Me.tbpDisplay.Tag = "Display"
        Me.tbpDisplay.UseVisualStyleBackColor = True
        '
        'sdgANOVAOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 155)
        Me.Controls.Add(Me.ucrBaseSdg)
        Me.Controls.Add(Me.tbcOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgANOVAOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "ANOVA_options"
        Me.tbpGraphics.ResumeLayout(False)
        Me.grpResiduals.ResumeLayout(False)
        Me.grpMeans.ResumeLayout(False)
        CType(Me.nudConfidenceLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcOptions.ResumeLayout(False)
        Me.tbpDisplay.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents ucrBaseSdg As ucrButtonsSubdialogue
    Friend WithEvents tbpGraphics As TabPage
    Friend WithEvents grpMeans As GroupBox
    Friend WithEvents nudConfidenceLevel As NumericUpDown
    Friend WithEvents lblConfidenceLevel As Label
    Friend WithEvents chkConfidenceLimits As CheckBox
    Friend WithEvents chkMeans As CheckBox
    Friend WithEvents grpResiduals As GroupBox
    Friend WithEvents chkResiduals As CheckBox
    Friend WithEvents tbcOptions As TabControl
    Friend WithEvents tbpDisplay As TabPage
    Friend WithEvents chkContrasts As CheckBox
    Friend WithEvents chkStandardErrors As CheckBox
    Friend WithEvents chkMeansAndCounts As CheckBox
    Friend WithEvents chkEstimateValues As CheckBox
    Friend WithEvents chkANOVATable As CheckBox
End Class
