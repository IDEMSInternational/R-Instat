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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgOneVarCompareModels))
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
        Me.ucrChkCDF = New instat.ucrCheck()
        Me.ucrChkDensity = New instat.ucrCheck()
        Me.tbpOneVarCompareModels.SuspendLayout()
        Me.tbpFit.SuspendLayout()
        Me.tbpPlot.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrSubBase
        '
        resources.ApplyResources(Me.ucrSubBase, "ucrSubBase")
        Me.ucrSubBase.Name = "ucrSubBase"
        '
        'tbpOneVarCompareModels
        '
        Me.tbpOneVarCompareModels.Controls.Add(Me.tbpFit)
        Me.tbpOneVarCompareModels.Controls.Add(Me.tbpPlot)
        resources.ApplyResources(Me.tbpOneVarCompareModels, "tbpOneVarCompareModels")
        Me.tbpOneVarCompareModels.Name = "tbpOneVarCompareModels"
        Me.tbpOneVarCompareModels.SelectedIndex = 0
        '
        'tbpFit
        '
        Me.tbpFit.Controls.Add(Me.ucrSaveDisplayChi)
        Me.tbpFit.Controls.Add(Me.ucrSaveGOF)
        Me.tbpFit.Controls.Add(Me.ucrChkInputChiSquareBreakpoints)
        resources.ApplyResources(Me.tbpFit, "tbpFit")
        Me.tbpFit.Name = "tbpFit"
        Me.tbpFit.UseVisualStyleBackColor = True
        '
        'ucrSaveDisplayChi
        '
        resources.ApplyResources(Me.ucrSaveDisplayChi, "ucrSaveDisplayChi")
        Me.ucrSaveDisplayChi.Name = "ucrSaveDisplayChi"
        '
        'ucrSaveGOF
        '
        resources.ApplyResources(Me.ucrSaveGOF, "ucrSaveGOF")
        Me.ucrSaveGOF.Name = "ucrSaveGOF"
        '
        'ucrChkInputChiSquareBreakpoints
        '
        Me.ucrChkInputChiSquareBreakpoints.Checked = False
        resources.ApplyResources(Me.ucrChkInputChiSquareBreakpoints, "ucrChkInputChiSquareBreakpoints")
        Me.ucrChkInputChiSquareBreakpoints.Name = "ucrChkInputChiSquareBreakpoints"
        '
        'tbpPlot
        '
        Me.tbpPlot.Controls.Add(Me.ucrSavePlots)
        Me.tbpPlot.Controls.Add(Me.ucrChkQQ)
        Me.tbpPlot.Controls.Add(Me.ucrChkPP)
        Me.tbpPlot.Controls.Add(Me.ucrChkCDF)
        Me.tbpPlot.Controls.Add(Me.ucrChkDensity)
        resources.ApplyResources(Me.tbpPlot, "tbpPlot")
        Me.tbpPlot.Name = "tbpPlot"
        Me.tbpPlot.UseVisualStyleBackColor = True
        '
        'ucrSavePlots
        '
        resources.ApplyResources(Me.ucrSavePlots, "ucrSavePlots")
        Me.ucrSavePlots.Name = "ucrSavePlots"
        '
        'ucrChkQQ
        '
        Me.ucrChkQQ.Checked = False
        resources.ApplyResources(Me.ucrChkQQ, "ucrChkQQ")
        Me.ucrChkQQ.Name = "ucrChkQQ"
        '
        'ucrChkPP
        '
        Me.ucrChkPP.Checked = False
        resources.ApplyResources(Me.ucrChkPP, "ucrChkPP")
        Me.ucrChkPP.Name = "ucrChkPP"
        '
        'ucrChkCDF
        '
        Me.ucrChkCDF.Checked = False
        resources.ApplyResources(Me.ucrChkCDF, "ucrChkCDF")
        Me.ucrChkCDF.Name = "ucrChkCDF"
        '
        'ucrChkDensity
        '
        Me.ucrChkDensity.Checked = False
        resources.ApplyResources(Me.ucrChkDensity, "ucrChkDensity")
        Me.ucrChkDensity.Name = "ucrChkDensity"
        '
        'sdgOneVarCompareModels
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbpOneVarCompareModels)
        Me.Controls.Add(Me.ucrSubBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneVarCompareModels"
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