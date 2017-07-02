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
        Me.ucrBase.Location = New System.Drawing.Point(12, 227)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrBase.TabIndex = 1
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
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(288, 185)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Plots"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ucrSavePlots
        '
        Me.ucrSavePlots.Location = New System.Drawing.Point(3, 155)
        Me.ucrSavePlots.Name = "ucrSavePlots"
        Me.ucrSavePlots.Size = New System.Drawing.Size(248, 24)
        Me.ucrSavePlots.TabIndex = 13
        '
        'rdoPPPlot
        '
        Me.rdoPPPlot.AutoSize = True
        Me.rdoPPPlot.Location = New System.Drawing.Point(8, 121)
        Me.rdoPPPlot.Name = "rdoPPPlot"
        Me.rdoPPPlot.Size = New System.Drawing.Size(60, 17)
        Me.rdoPPPlot.TabIndex = 12
        Me.rdoPPPlot.Text = "PP-Plot"
        Me.rdoPPPlot.UseVisualStyleBackColor = True
        '
        'rdoQQPlot
        '
        Me.rdoQQPlot.AutoSize = True
        Me.rdoQQPlot.Location = New System.Drawing.Point(8, 98)
        Me.rdoQQPlot.Name = "rdoQQPlot"
        Me.rdoQQPlot.Size = New System.Drawing.Size(62, 17)
        Me.rdoQQPlot.TabIndex = 11
        Me.rdoQQPlot.Text = "QQ-Plot"
        Me.rdoQQPlot.UseVisualStyleBackColor = True
        '
        'rdoDensityPlot
        '
        Me.rdoDensityPlot.AutoSize = True
        Me.rdoDensityPlot.Location = New System.Drawing.Point(8, 75)
        Me.rdoDensityPlot.Name = "rdoDensityPlot"
        Me.rdoDensityPlot.Size = New System.Drawing.Size(81, 17)
        Me.rdoDensityPlot.TabIndex = 10
        Me.rdoDensityPlot.Text = "Density Plot"
        Me.rdoDensityPlot.UseVisualStyleBackColor = True
        '
        'rdoCDFPlot
        '
        Me.rdoCDFPlot.AutoSize = True
        Me.rdoCDFPlot.Location = New System.Drawing.Point(8, 52)
        Me.rdoCDFPlot.Name = "rdoCDFPlot"
        Me.rdoCDFPlot.Size = New System.Drawing.Size(67, 17)
        Me.rdoCDFPlot.TabIndex = 9
        Me.rdoCDFPlot.Text = "CDF Plot"
        Me.rdoCDFPlot.UseVisualStyleBackColor = True
        '
        'rdoPlotAll
        '
        Me.rdoPlotAll.AutoSize = True
        Me.rdoPlotAll.Location = New System.Drawing.Point(8, 29)
        Me.rdoPlotAll.Name = "rdoPlotAll"
        Me.rdoPlotAll.Size = New System.Drawing.Size(68, 17)
        Me.rdoPlotAll.TabIndex = 8
        Me.rdoPlotAll.Text = "Multi-Plot"
        Me.rdoPlotAll.UseVisualStyleBackColor = True
        '
        'rdoNoPlot
        '
        Me.rdoNoPlot.AutoSize = True
        Me.rdoNoPlot.Location = New System.Drawing.Point(8, 6)
        Me.rdoNoPlot.Name = "rdoNoPlot"
        Me.rdoNoPlot.Size = New System.Drawing.Size(60, 17)
        Me.rdoNoPlot.TabIndex = 7
        Me.rdoNoPlot.Text = "No Plot"
        Me.rdoNoPlot.UseVisualStyleBackColor = True
        '
        'ucrPnlPlots
        '
        Me.ucrPnlPlots.Location = New System.Drawing.Point(3, 3)
        Me.ucrPnlPlots.Name = "ucrPnlPlots"
        Me.ucrPnlPlots.Size = New System.Drawing.Size(236, 149)
        Me.ucrPnlPlots.TabIndex = 6
        '
        'tbcPlots
        '
        Me.tbcPlots.Controls.Add(Me.TabPage1)
        Me.tbcPlots.Controls.Add(Me.tbclikelihood)
        Me.tbcPlots.Location = New System.Drawing.Point(12, 10)
        Me.tbcPlots.Name = "tbcPlots"
        Me.tbcPlots.SelectedIndex = 0
        Me.tbcPlots.Size = New System.Drawing.Size(296, 211)
        Me.tbcPlots.TabIndex = 0
        '
        'tbclikelihood
        '
        Me.tbclikelihood.Controls.Add(Me.ucrChkPLotLogLik)
        Me.tbclikelihood.Controls.Add(Me.ucrSaveLikelihood)
        Me.tbclikelihood.Controls.Add(Me.rdoLik)
        Me.tbclikelihood.Controls.Add(Me.rdoLoglik)
        Me.tbclikelihood.Controls.Add(Me.ucrPnlLikelihood)
        Me.tbclikelihood.Location = New System.Drawing.Point(4, 22)
        Me.tbclikelihood.Name = "tbclikelihood"
        Me.tbclikelihood.Padding = New System.Windows.Forms.Padding(3)
        Me.tbclikelihood.Size = New System.Drawing.Size(288, 185)
        Me.tbclikelihood.TabIndex = 1
        Me.tbclikelihood.Text = "Likelihood"
        Me.tbclikelihood.UseVisualStyleBackColor = True
        '
        'ucrChkPLotLogLik
        '
        Me.ucrChkPLotLogLik.Checked = False
        Me.ucrChkPLotLogLik.Location = New System.Drawing.Point(6, 11)
        Me.ucrChkPLotLogLik.Name = "ucrChkPLotLogLik"
        Me.ucrChkPLotLogLik.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkPLotLogLik.TabIndex = 12
        '
        'ucrSaveLikelihood
        '
        Me.ucrSaveLikelihood.Location = New System.Drawing.Point(8, 151)
        Me.ucrSaveLikelihood.Name = "ucrSaveLikelihood"
        Me.ucrSaveLikelihood.Size = New System.Drawing.Size(248, 24)
        Me.ucrSaveLikelihood.TabIndex = 11
        '
        'rdoLik
        '
        Me.rdoLik.AutoSize = True
        Me.rdoLik.Location = New System.Drawing.Point(10, 60)
        Me.rdoLik.Name = "rdoLik"
        Me.rdoLik.Size = New System.Drawing.Size(94, 17)
        Me.rdoLik.TabIndex = 9
        Me.rdoLik.Text = "Plot Likelihood"
        Me.rdoLik.UseVisualStyleBackColor = True
        '
        'rdoLoglik
        '
        Me.rdoLoglik.AutoSize = True
        Me.rdoLoglik.Checked = True
        Me.rdoLoglik.Location = New System.Drawing.Point(10, 37)
        Me.rdoLoglik.Name = "rdoLoglik"
        Me.rdoLoglik.Size = New System.Drawing.Size(115, 17)
        Me.rdoLoglik.TabIndex = 8
        Me.rdoLoglik.TabStop = True
        Me.rdoLoglik.Text = "Plot Log-Likelihood"
        Me.rdoLoglik.UseVisualStyleBackColor = True
        '
        'ucrPnlLikelihood
        '
        Me.ucrPnlLikelihood.Location = New System.Drawing.Point(3, 37)
        Me.ucrPnlLikelihood.Name = "ucrPnlLikelihood"
        Me.ucrPnlLikelihood.Size = New System.Drawing.Size(122, 40)
        Me.ucrPnlLikelihood.TabIndex = 7
        '
        'sdgOneVarFitModDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 263)
        Me.Controls.Add(Me.tbcPlots)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneVarFitModDisplay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Display Options"
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
