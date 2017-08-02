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
Partial Class sdgCanonicalCorrelation
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
        Me.rdoYVariables = New System.Windows.Forms.RadioButton()
        Me.rdoXVariables = New System.Windows.Forms.RadioButton()
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.grpGraphics = New System.Windows.Forms.GroupBox()
        Me.ucrChkPairwisePlot = New instat.ucrCheck()
        Me.ucrPnlVariables = New instat.UcrPanel()
        Me.ucrChkCoefficients = New instat.ucrCheck()
        Me.ucrChkCanonicalCorrelations = New instat.ucrCheck()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.grpDisplay.SuspendLayout()
        Me.grpGraphics.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoYVariables
        '
        Me.rdoYVariables.AutoSize = True
        Me.rdoYVariables.Location = New System.Drawing.Point(46, 67)
        Me.rdoYVariables.Name = "rdoYVariables"
        Me.rdoYVariables.Size = New System.Drawing.Size(78, 17)
        Me.rdoYVariables.TabIndex = 3
        Me.rdoYVariables.Tag = "Y_Variables"
        Me.rdoYVariables.Text = "Y Variables"
        Me.rdoYVariables.UseVisualStyleBackColor = True
        '
        'rdoXVariables
        '
        Me.rdoXVariables.AutoSize = True
        Me.rdoXVariables.Location = New System.Drawing.Point(46, 44)
        Me.rdoXVariables.Name = "rdoXVariables"
        Me.rdoXVariables.Size = New System.Drawing.Size(78, 17)
        Me.rdoXVariables.TabIndex = 2
        Me.rdoXVariables.Tag = "X_Variables"
        Me.rdoXVariables.Text = "X Variables"
        Me.rdoXVariables.UseVisualStyleBackColor = True
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.ucrChkCoefficients)
        Me.grpDisplay.Controls.Add(Me.ucrChkCanonicalCorrelations)
        Me.grpDisplay.Location = New System.Drawing.Point(7, 7)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(200, 72)
        Me.grpDisplay.TabIndex = 0
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Text = "Display"
        '
        'grpGraphics
        '
        Me.grpGraphics.Controls.Add(Me.rdoYVariables)
        Me.grpGraphics.Controls.Add(Me.ucrChkPairwisePlot)
        Me.grpGraphics.Controls.Add(Me.rdoXVariables)
        Me.grpGraphics.Controls.Add(Me.ucrPnlVariables)
        Me.grpGraphics.Location = New System.Drawing.Point(7, 85)
        Me.grpGraphics.Name = "grpGraphics"
        Me.grpGraphics.Size = New System.Drawing.Size(200, 100)
        Me.grpGraphics.TabIndex = 1
        Me.grpGraphics.TabStop = False
        Me.grpGraphics.Text = "Graphics"
        '
        'ucrChkPairwisePlot
        '
        Me.ucrChkPairwisePlot.Checked = False
        Me.ucrChkPairwisePlot.Location = New System.Drawing.Point(10, 18)
        Me.ucrChkPairwisePlot.Name = "ucrChkPairwisePlot"
        Me.ucrChkPairwisePlot.Size = New System.Drawing.Size(184, 20)
        Me.ucrChkPairwisePlot.TabIndex = 0
        '
        'ucrPnlVariables
        '
        Me.ucrPnlVariables.Location = New System.Drawing.Point(36, 36)
        Me.ucrPnlVariables.Name = "ucrPnlVariables"
        Me.ucrPnlVariables.Size = New System.Drawing.Size(127, 58)
        Me.ucrPnlVariables.TabIndex = 1
        '
        'ucrChkCoefficients
        '
        Me.ucrChkCoefficients.Checked = False
        Me.ucrChkCoefficients.Location = New System.Drawing.Point(10, 46)
        Me.ucrChkCoefficients.Name = "ucrChkCoefficients"
        Me.ucrChkCoefficients.Size = New System.Drawing.Size(184, 20)
        Me.ucrChkCoefficients.TabIndex = 1
        '
        'ucrChkCanonicalCorrelations
        '
        Me.ucrChkCanonicalCorrelations.Checked = False
        Me.ucrChkCanonicalCorrelations.Location = New System.Drawing.Point(10, 18)
        Me.ucrChkCanonicalCorrelations.Name = "ucrChkCanonicalCorrelations"
        Me.ucrChkCanonicalCorrelations.Size = New System.Drawing.Size(184, 20)
        Me.ucrChkCanonicalCorrelations.TabIndex = 0
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.Location = New System.Drawing.Point(36, 190)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(142, 30)
        Me.ucrSdgButtons.TabIndex = 2
        '
        'sdgCanonicalCorrelation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 224)
        Me.Controls.Add(Me.grpGraphics)
        Me.Controls.Add(Me.grpDisplay)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgCanonicalCorrelation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "CCA_Options"
        Me.Text = "CCA Options"
        Me.grpDisplay.ResumeLayout(False)
        Me.grpGraphics.ResumeLayout(False)
        Me.grpGraphics.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents rdoYVariables As RadioButton
    Friend WithEvents rdoXVariables As RadioButton
    Friend WithEvents ucrChkCoefficients As ucrCheck
    Friend WithEvents ucrChkCanonicalCorrelations As ucrCheck
    Friend WithEvents ucrChkPairwisePlot As ucrCheck
    Friend WithEvents ucrPnlVariables As UcrPanel
    Friend WithEvents grpDisplay As GroupBox
    Friend WithEvents grpGraphics As GroupBox
End Class