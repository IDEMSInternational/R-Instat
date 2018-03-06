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
Partial Class sdgOneVarFitModDisplay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgOneVarFitModDisplay))
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ucrSavePlots = New instat.ucrSave()
        Me.rdoPPPlot = New System.Windows.Forms.RadioButton()
        Me.rdoQQPlot = New System.Windows.Forms.RadioButton()
        Me.rdoDensityPlot = New System.Windows.Forms.RadioButton()
        Me.rdoCDFPlot = New System.Windows.Forms.RadioButton()
        Me.rdoPlotAll = New System.Windows.Forms.RadioButton()
        Me.rdoNoPlot = New System.Windows.Forms.RadioButton()
        Me.ucrPnlPlots = New instat.UcrPanel()
        Me.tbcPlots = New System.Windows.Forms.TabControl()
        Me.tbclikelihood = New System.Windows.Forms.TabPage()
        Me.ucrChkPLotLogLik = New instat.ucrCheck()
        Me.ucrSaveLikelihood = New instat.ucrSave()
        Me.rdoLik = New System.Windows.Forms.RadioButton()
        Me.rdoLoglik = New System.Windows.Forms.RadioButton()
        Me.ucrPnlLikelihood = New instat.UcrPanel()
        Me.TabPage1.SuspendLayout()
        Me.tbcPlots.SuspendLayout()
        Me.tbclikelihood.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ucrSavePlots)
        Me.TabPage1.Controls.Add(Me.rdoPPPlot)
        Me.TabPage1.Controls.Add(Me.rdoQQPlot)
        Me.TabPage1.Controls.Add(Me.rdoDensityPlot)
        Me.TabPage1.Controls.Add(Me.rdoCDFPlot)
        Me.TabPage1.Controls.Add(Me.rdoPlotAll)
        Me.TabPage1.Controls.Add(Me.rdoNoPlot)
        Me.TabPage1.Controls.Add(Me.ucrPnlPlots)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ucrSavePlots
        '
        resources.ApplyResources(Me.ucrSavePlots, "ucrSavePlots")
        Me.ucrSavePlots.Name = "ucrSavePlots"
        '
        'rdoPPPlot
        '
        resources.ApplyResources(Me.rdoPPPlot, "rdoPPPlot")
        Me.rdoPPPlot.Name = "rdoPPPlot"
        Me.rdoPPPlot.UseVisualStyleBackColor = True
        '
        'rdoQQPlot
        '
        resources.ApplyResources(Me.rdoQQPlot, "rdoQQPlot")
        Me.rdoQQPlot.Name = "rdoQQPlot"
        Me.rdoQQPlot.UseVisualStyleBackColor = True
        '
        'rdoDensityPlot
        '
        resources.ApplyResources(Me.rdoDensityPlot, "rdoDensityPlot")
        Me.rdoDensityPlot.Name = "rdoDensityPlot"
        Me.rdoDensityPlot.UseVisualStyleBackColor = True
        '
        'rdoCDFPlot
        '
        resources.ApplyResources(Me.rdoCDFPlot, "rdoCDFPlot")
        Me.rdoCDFPlot.Name = "rdoCDFPlot"
        Me.rdoCDFPlot.UseVisualStyleBackColor = True
        '
        'rdoPlotAll
        '
        resources.ApplyResources(Me.rdoPlotAll, "rdoPlotAll")
        Me.rdoPlotAll.Name = "rdoPlotAll"
        Me.rdoPlotAll.UseVisualStyleBackColor = True
        '
        'rdoNoPlot
        '
        resources.ApplyResources(Me.rdoNoPlot, "rdoNoPlot")
        Me.rdoNoPlot.Name = "rdoNoPlot"
        Me.rdoNoPlot.UseVisualStyleBackColor = True
        '
        'ucrPnlPlots
        '
        resources.ApplyResources(Me.ucrPnlPlots, "ucrPnlPlots")
        Me.ucrPnlPlots.Name = "ucrPnlPlots"
        '
        'tbcPlots
        '
        Me.tbcPlots.Controls.Add(Me.TabPage1)
        Me.tbcPlots.Controls.Add(Me.tbclikelihood)
        resources.ApplyResources(Me.tbcPlots, "tbcPlots")
        Me.tbcPlots.Name = "tbcPlots"
        Me.tbcPlots.SelectedIndex = 0
        '
        'tbclikelihood
        '
        Me.tbclikelihood.Controls.Add(Me.ucrChkPLotLogLik)
        Me.tbclikelihood.Controls.Add(Me.ucrSaveLikelihood)
        Me.tbclikelihood.Controls.Add(Me.rdoLik)
        Me.tbclikelihood.Controls.Add(Me.rdoLoglik)
        Me.tbclikelihood.Controls.Add(Me.ucrPnlLikelihood)
        resources.ApplyResources(Me.tbclikelihood, "tbclikelihood")
        Me.tbclikelihood.Name = "tbclikelihood"
        Me.tbclikelihood.UseVisualStyleBackColor = True
        '
        'ucrChkPLotLogLik
        '
        Me.ucrChkPLotLogLik.Checked = False
        resources.ApplyResources(Me.ucrChkPLotLogLik, "ucrChkPLotLogLik")
        Me.ucrChkPLotLogLik.Name = "ucrChkPLotLogLik"
        '
        'ucrSaveLikelihood
        '
        resources.ApplyResources(Me.ucrSaveLikelihood, "ucrSaveLikelihood")
        Me.ucrSaveLikelihood.Name = "ucrSaveLikelihood"
        '
        'rdoLik
        '
        resources.ApplyResources(Me.rdoLik, "rdoLik")
        Me.rdoLik.Name = "rdoLik"
        Me.rdoLik.UseVisualStyleBackColor = True
        '
        'rdoLoglik
        '
        resources.ApplyResources(Me.rdoLoglik, "rdoLoglik")
        Me.rdoLoglik.Checked = True
        Me.rdoLoglik.Name = "rdoLoglik"
        Me.rdoLoglik.TabStop = True
        Me.rdoLoglik.UseVisualStyleBackColor = True
        '
        'ucrPnlLikelihood
        '
        resources.ApplyResources(Me.ucrPnlLikelihood, "ucrPnlLikelihood")
        Me.ucrPnlLikelihood.Name = "ucrPnlLikelihood"
        '
        'sdgOneVarFitModDisplay
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbcPlots)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneVarFitModDisplay"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.tbcPlots.ResumeLayout(False)
        Me.tbclikelihood.ResumeLayout(False)
        Me.tbclikelihood.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents tbcPlots As TabControl
    Friend WithEvents rdoPPPlot As RadioButton
    Friend WithEvents rdoQQPlot As RadioButton
    Friend WithEvents rdoDensityPlot As RadioButton
    Friend WithEvents rdoCDFPlot As RadioButton
    Friend WithEvents rdoPlotAll As RadioButton
    Friend WithEvents rdoNoPlot As RadioButton
    Friend WithEvents ucrPnlPlots As UcrPanel
    Friend WithEvents tbclikelihood As TabPage
    Friend WithEvents rdoLik As RadioButton
    Friend WithEvents rdoLoglik As RadioButton
    Friend WithEvents ucrPnlLikelihood As UcrPanel
    Friend WithEvents ucrSaveLikelihood As ucrSave
    Friend WithEvents ucrSavePlots As ucrSave
    Friend WithEvents ucrChkPLotLogLik As ucrCheck
End Class
