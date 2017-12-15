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
Partial Class dlgCumulativeDistribution
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgCumulativeDistribution))
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.cmdLineOptions = New System.Windows.Forms.Button()
        Me.cmdPlotOptions = New System.Windows.Forms.Button()
        Me.ucrChkExceedancePlots = New instat.ucrCheck()
        Me.ucrSaveCumDist = New instat.ucrSave()
        Me.ucrVariablesAsFactorforCumDist = New instat.ucrVariablesAsFactor()
        Me.ucrFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrCumDistSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkCountsOnYAxis = New instat.ucrCheck()
        Me.ucrChkIncludePoints = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'lblFactors
        '
        resources.ApplyResources(Me.lblFactors, "lblFactors")
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Tag = "Factors_Optional:"
        '
        'cmdLineOptions
        '
        resources.ApplyResources(Me.cmdLineOptions, "cmdLineOptions")
        Me.cmdLineOptions.Name = "cmdLineOptions"
        Me.cmdLineOptions.Tag = "Line_Options"
        Me.cmdLineOptions.UseVisualStyleBackColor = True
        '
        'cmdPlotOptions
        '
        resources.ApplyResources(Me.cmdPlotOptions, "cmdPlotOptions")
        Me.cmdPlotOptions.Name = "cmdPlotOptions"
        Me.cmdPlotOptions.Tag = "Plot_Options"
        Me.cmdPlotOptions.UseVisualStyleBackColor = True
        '
        'ucrChkExceedancePlots
        '
        Me.ucrChkExceedancePlots.Checked = False
        resources.ApplyResources(Me.ucrChkExceedancePlots, "ucrChkExceedancePlots")
        Me.ucrChkExceedancePlots.Name = "ucrChkExceedancePlots"
        '
        'ucrSaveCumDist
        '
        resources.ApplyResources(Me.ucrSaveCumDist, "ucrSaveCumDist")
        Me.ucrSaveCumDist.Name = "ucrSaveCumDist"
        '
        'ucrVariablesAsFactorforCumDist
        '
        Me.ucrVariablesAsFactorforCumDist.frmParent = Me
        resources.ApplyResources(Me.ucrVariablesAsFactorforCumDist, "ucrVariablesAsFactorforCumDist")
        Me.ucrVariablesAsFactorforCumDist.Name = "ucrVariablesAsFactorforCumDist"
        Me.ucrVariablesAsFactorforCumDist.Selector = Nothing
        Me.ucrVariablesAsFactorforCumDist.strNcFilePath = ""
        Me.ucrVariablesAsFactorforCumDist.ucrSelector = Nothing
        Me.ucrVariablesAsFactorforCumDist.ucrVariableSelector = Nothing
        '
        'ucrFactorReceiver
        '
        Me.ucrFactorReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrFactorReceiver, "ucrFactorReceiver")
        Me.ucrFactorReceiver.Name = "ucrFactorReceiver"
        Me.ucrFactorReceiver.Selector = Nothing
        Me.ucrFactorReceiver.strNcFilePath = ""
        Me.ucrFactorReceiver.ucrSelector = Nothing
        '
        'ucrCumDistSelector
        '
        Me.ucrCumDistSelector.bShowHiddenColumns = False
        Me.ucrCumDistSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrCumDistSelector, "ucrCumDistSelector")
        Me.ucrCumDistSelector.Name = "ucrCumDistSelector"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrChkCountsOnYAxis
        '
        Me.ucrChkCountsOnYAxis.Checked = False
        resources.ApplyResources(Me.ucrChkCountsOnYAxis, "ucrChkCountsOnYAxis")
        Me.ucrChkCountsOnYAxis.Name = "ucrChkCountsOnYAxis"
        '
        'ucrChkIncludePoints
        '
        Me.ucrChkIncludePoints.Checked = False
        resources.ApplyResources(Me.ucrChkIncludePoints, "ucrChkIncludePoints")
        Me.ucrChkIncludePoints.Name = "ucrChkIncludePoints"
        '
        'dlgCumulativeDistribution
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkIncludePoints)
        Me.Controls.Add(Me.ucrChkCountsOnYAxis)
        Me.Controls.Add(Me.ucrChkExceedancePlots)
        Me.Controls.Add(Me.ucrSaveCumDist)
        Me.Controls.Add(Me.ucrVariablesAsFactorforCumDist)
        Me.Controls.Add(Me.ucrFactorReceiver)
        Me.Controls.Add(Me.cmdPlotOptions)
        Me.Controls.Add(Me.cmdLineOptions)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrCumDistSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCumulativeDistribution"
        Me.Tag = "Cumulative_Distribution"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrCumDistSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFactors As Label
    Friend WithEvents cmdLineOptions As Button
    Friend WithEvents cmdPlotOptions As Button
    Friend WithEvents ucrFactorReceiver As ucrReceiverSingle
    Friend WithEvents ucrVariablesAsFactorforCumDist As ucrVariablesAsFactor
    Friend WithEvents ucrSaveCumDist As ucrSave
    Friend WithEvents ucrChkExceedancePlots As ucrCheck
    Friend WithEvents ucrChkIncludePoints As ucrCheck
    Friend WithEvents ucrChkCountsOnYAxis As ucrCheck
End Class
