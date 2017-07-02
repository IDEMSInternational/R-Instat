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
Partial Class sdgOneVarCompareModels
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
        Me.ucrSubBase = New instat.ucrButtonsSubdialogue()
        Me.tbpOneVarCompareModels = New System.Windows.Forms.TabControl()
        Me.tbpFit = New System.Windows.Forms.TabPage()
        Me.ucrSaveDisplayChi = New instat.ucrSave()
        Me.ucrSaveGOF = New instat.ucrSave()
        Me.ucrChkInputChiSquareBreakpoints = New instat.ucrCheck()
        Me.tbpPlot = New System.Windows.Forms.TabPage()
        Me.ucrSavePlots = New instat.ucrSave()
        Me.ucrChkQQ = New instat.ucrCheck()
        Me.ucrChkPP = New instat.ucrCheck()
        Me.ucrChkDensity = New instat.ucrCheck()
        Me.ucrChkCDF = New instat.ucrCheck()
        Me.tbpOneVarCompareModels.SuspendLayout()
        Me.tbpFit.SuspendLayout()
        Me.tbpPlot.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrSubBase
        '
        Me.ucrSubBase.Location = New System.Drawing.Point(76, 186)
        Me.ucrSubBase.Name = "ucrSubBase"
        Me.ucrSubBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrSubBase.TabIndex = 1
        '
        'tbpOneVarCompareModels
        '
        Me.tbpOneVarCompareModels.Controls.Add(Me.tbpFit)
        Me.tbpOneVarCompareModels.Controls.Add(Me.tbpPlot)
        Me.tbpOneVarCompareModels.Location = New System.Drawing.Point(7, 7)
        Me.tbpOneVarCompareModels.Name = "tbpOneVarCompareModels"
        Me.tbpOneVarCompareModels.SelectedIndex = 0
        Me.tbpOneVarCompareModels.Size = New System.Drawing.Size(279, 174)
        Me.tbpOneVarCompareModels.TabIndex = 0
        '
        'tbpFit
        '
        Me.tbpFit.Controls.Add(Me.ucrSaveDisplayChi)
        Me.tbpFit.Controls.Add(Me.ucrSaveGOF)
        Me.tbpFit.Controls.Add(Me.ucrChkInputChiSquareBreakpoints)
        Me.tbpFit.Location = New System.Drawing.Point(4, 22)
        Me.tbpFit.Name = "tbpFit"
        Me.tbpFit.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpFit.Size = New System.Drawing.Size(271, 148)
        Me.tbpFit.TabIndex = 0
        Me.tbpFit.Text = "Fit"
        Me.tbpFit.UseVisualStyleBackColor = True
        '
        'ucrSaveDisplayChi
        '
        Me.ucrSaveDisplayChi.Location = New System.Drawing.Point(10, 36)
        Me.ucrSaveDisplayChi.Name = "ucrSaveDisplayChi"
        Me.ucrSaveDisplayChi.Size = New System.Drawing.Size(260, 24)
        Me.ucrSaveDisplayChi.TabIndex = 1
        '
        'ucrSaveGOF
        '
        Me.ucrSaveGOF.Location = New System.Drawing.Point(10, 10)
        Me.ucrSaveGOF.Name = "ucrSaveGOF"
        Me.ucrSaveGOF.Size = New System.Drawing.Size(255, 24)
        Me.ucrSaveGOF.TabIndex = 0
        '
        'ucrChkInputChiSquareBreakpoints
        '
        Me.ucrChkInputChiSquareBreakpoints.Checked = False
        Me.ucrChkInputChiSquareBreakpoints.Location = New System.Drawing.Point(10, 62)
        Me.ucrChkInputChiSquareBreakpoints.Name = "ucrChkInputChiSquareBreakpoints"
        Me.ucrChkInputChiSquareBreakpoints.Size = New System.Drawing.Size(229, 20)
        Me.ucrChkInputChiSquareBreakpoints.TabIndex = 2
        '
        'tbpPlot
        '
        Me.tbpPlot.Controls.Add(Me.ucrSavePlots)
        Me.tbpPlot.Controls.Add(Me.ucrChkQQ)
        Me.tbpPlot.Controls.Add(Me.ucrChkPP)
        Me.tbpPlot.Controls.Add(Me.ucrChkCDF)
        Me.tbpPlot.Controls.Add(Me.ucrChkDensity)
        Me.tbpPlot.Location = New System.Drawing.Point(4, 22)
        Me.tbpPlot.Name = "tbpPlot"
        Me.tbpPlot.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpPlot.Size = New System.Drawing.Size(292, 162)
        Me.tbpPlot.TabIndex = 1
        Me.tbpPlot.Text = "Plot"
        Me.tbpPlot.UseVisualStyleBackColor = True
        '
        'ucrSavePlots
        '
        Me.ucrSavePlots.Location = New System.Drawing.Point(10, 114)
        Me.ucrSavePlots.Name = "ucrSavePlots"
        Me.ucrSavePlots.Size = New System.Drawing.Size(260, 24)
        Me.ucrSavePlots.TabIndex = 4
        '
        'ucrChkQQ
        '
        Me.ucrChkQQ.Checked = False
        Me.ucrChkQQ.Location = New System.Drawing.Point(10, 88)
        Me.ucrChkQQ.Name = "ucrChkQQ"
        Me.ucrChkQQ.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkQQ.TabIndex = 3
        '
        'ucrChkPP
        '
        Me.ucrChkPP.Checked = False
        Me.ucrChkPP.Location = New System.Drawing.Point(10, 62)
        Me.ucrChkPP.Name = "ucrChkPP"
        Me.ucrChkPP.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkPP.TabIndex = 2
        '
        'ucrChkDensity
        '
        Me.ucrChkDensity.Checked = False
        Me.ucrChkDensity.Location = New System.Drawing.Point(10, 36)
        Me.ucrChkDensity.Name = "ucrChkDensity"
        Me.ucrChkDensity.Size = New System.Drawing.Size(260, 20)
        Me.ucrChkDensity.TabIndex = 1
        '
        'ucrChkCDF
        '
        Me.ucrChkCDF.Checked = False
        Me.ucrChkCDF.Location = New System.Drawing.Point(10, 10)
        Me.ucrChkCDF.Name = "ucrChkCDF"
        Me.ucrChkCDF.Size = New System.Drawing.Size(260, 20)
        Me.ucrChkCDF.TabIndex = 0
        '
        'sdgOneVarCompareModels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 221)
        Me.Controls.Add(Me.tbpOneVarCompareModels)
        Me.Controls.Add(Me.ucrSubBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneVarCompareModels"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Display Options"
        Me.tbpOneVarCompareModels.ResumeLayout(False)
        Me.tbpFit.ResumeLayout(False)
        Me.tbpPlot.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSubBase As ucrButtonsSubdialogue
    Friend WithEvents tbpOneVarCompareModels As TabControl
    Friend WithEvents tbpFit As TabPage
    Friend WithEvents ucrSaveGOF As ucrSave
    Friend WithEvents ucrChkInputChiSquareBreakpoints As ucrCheck
    Friend WithEvents tbpPlot As TabPage
    Friend WithEvents ucrSavePlots As ucrSave
    Friend WithEvents ucrChkQQ As ucrCheck
    Friend WithEvents ucrChkPP As ucrCheck
    Friend WithEvents ucrChkDensity As ucrCheck
    Friend WithEvents ucrChkCDF As ucrCheck
    Friend WithEvents ucrSaveDisplayChi As ucrSave
End Class