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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgCanonicalCorrelation))
        Me.ucrChkCoefficients = New instat.ucrCheck()
        Me.ucrChkCanonicalCorrelations = New instat.ucrCheck()
        Me.ucrChkPairwisePlot = New instat.ucrCheck()
        Me.rdoYVariables = New System.Windows.Forms.RadioButton()
        Me.rdoXVariables = New System.Windows.Forms.RadioButton()
        Me.ucrPnlVariables = New instat.UcrPanel()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.grpGraphics = New System.Windows.Forms.GroupBox()
        Me.grpDisplay.SuspendLayout()
        Me.grpGraphics.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrChkCoefficients
        '
        Me.ucrChkCoefficients.Checked = False
        resources.ApplyResources(Me.ucrChkCoefficients, "ucrChkCoefficients")
        Me.ucrChkCoefficients.Name = "ucrChkCoefficients"
        '
        'ucrChkCanonicalCorrelations
        '
        Me.ucrChkCanonicalCorrelations.Checked = False
        resources.ApplyResources(Me.ucrChkCanonicalCorrelations, "ucrChkCanonicalCorrelations")
        Me.ucrChkCanonicalCorrelations.Name = "ucrChkCanonicalCorrelations"
        '
        'ucrChkPairwisePlot
        '
        Me.ucrChkPairwisePlot.Checked = False
        resources.ApplyResources(Me.ucrChkPairwisePlot, "ucrChkPairwisePlot")
        Me.ucrChkPairwisePlot.Name = "ucrChkPairwisePlot"
        '
        'rdoYVariables
        '
        resources.ApplyResources(Me.rdoYVariables, "rdoYVariables")
        Me.rdoYVariables.Name = "rdoYVariables"
        Me.rdoYVariables.Tag = "Y_Variables"
        Me.rdoYVariables.UseVisualStyleBackColor = True
        '
        'rdoXVariables
        '
        resources.ApplyResources(Me.rdoXVariables, "rdoXVariables")
        Me.rdoXVariables.Name = "rdoXVariables"
        Me.rdoXVariables.Tag = "X_Variables"
        Me.rdoXVariables.UseVisualStyleBackColor = True
        '
        'ucrPnlVariables
        '
        resources.ApplyResources(Me.ucrPnlVariables, "ucrPnlVariables")
        Me.ucrPnlVariables.Name = "ucrPnlVariables"
        '
        'ucrSdgButtons
        '
        resources.ApplyResources(Me.ucrSdgButtons, "ucrSdgButtons")
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.ucrChkCoefficients)
        Me.grpDisplay.Controls.Add(Me.ucrChkCanonicalCorrelations)
        resources.ApplyResources(Me.grpDisplay, "grpDisplay")
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.TabStop = False
        '
        'grpGraphics
        '
        Me.grpGraphics.Controls.Add(Me.rdoYVariables)
        Me.grpGraphics.Controls.Add(Me.ucrChkPairwisePlot)
        Me.grpGraphics.Controls.Add(Me.rdoXVariables)
        Me.grpGraphics.Controls.Add(Me.ucrPnlVariables)
        resources.ApplyResources(Me.grpGraphics, "grpGraphics")
        Me.grpGraphics.Name = "grpGraphics"
        Me.grpGraphics.TabStop = False
        '
        'sdgCanonicalCorrelation
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpGraphics)
        Me.Controls.Add(Me.grpDisplay)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgCanonicalCorrelation"
        Me.Tag = "CCA_Options"
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