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
        Me.cmdPlotOptions = New System.Windows.Forms.Button()
        Me.lblScale = New System.Windows.Forms.Label()
        Me.lblNudby = New System.Windows.Forms.Label()
        Me.rdoCumulative = New System.Windows.Forms.RadioButton()
        Me.rdoExceedance = New System.Windows.Forms.RadioButton()
        Me.ucrNudBy = New instat.ucrNud()
        Me.ucrInputComboScales = New instat.ucrInputComboBox()
        Me.ucrPnlOption = New instat.UcrPanel()
        Me.ucrChkIncludePoints = New instat.ucrCheck()
        Me.ucrChkCountsOnYAxis = New instat.ucrCheck()
        Me.ucrSaveCumDist = New instat.ucrSave()
        Me.ucrVariablesAsFactorforCumDist = New instat.ucrVariablesAsFactor()
        Me.ucrFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrCumDistSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblFactors
        '
        resources.ApplyResources(Me.lblFactors, "lblFactors")
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Tag = "Factors_Optional:"
        '
        'cmdPlotOptions
        '
        resources.ApplyResources(Me.cmdPlotOptions, "cmdPlotOptions")
        Me.cmdPlotOptions.Name = "cmdPlotOptions"
        Me.cmdPlotOptions.Tag = "Plot_Options"
        Me.cmdPlotOptions.UseVisualStyleBackColor = True
        '
        'lblScale
        '
        resources.ApplyResources(Me.lblScale, "lblScale")
        Me.lblScale.Name = "lblScale"
        '
        'lblNudby
        '
        resources.ApplyResources(Me.lblNudby, "lblNudby")
        Me.lblNudby.Name = "lblNudby"
        '
        'rdoCumulative
        '
        resources.ApplyResources(Me.rdoCumulative, "rdoCumulative")
        Me.rdoCumulative.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCumulative.FlatAppearance.BorderSize = 2
        Me.rdoCumulative.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCumulative.Name = "rdoCumulative"
        Me.rdoCumulative.TabStop = True
        Me.rdoCumulative.UseVisualStyleBackColor = True
        '
        'rdoExceedance
        '
        resources.ApplyResources(Me.rdoExceedance, "rdoExceedance")
        Me.rdoExceedance.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoExceedance.FlatAppearance.BorderSize = 2
        Me.rdoExceedance.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoExceedance.Name = "rdoExceedance"
        Me.rdoExceedance.TabStop = True
        Me.rdoExceedance.UseVisualStyleBackColor = True
        '
        'ucrNudBy
        '
        Me.ucrNudBy.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBy.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudBy, "ucrNudBy")
        Me.ucrNudBy.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBy.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBy.Name = "ucrNudBy"
        Me.ucrNudBy.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputComboScales
        '
        Me.ucrInputComboScales.AddQuotesIfUnrecognised = True
        Me.ucrInputComboScales.GetSetSelectedIndex = -1
        Me.ucrInputComboScales.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboScales, "ucrInputComboScales")
        Me.ucrInputComboScales.Name = "ucrInputComboScales"
        '
        'ucrPnlOption
        '
        resources.ApplyResources(Me.ucrPnlOption, "ucrPnlOption")
        Me.ucrPnlOption.Name = "ucrPnlOption"
        '
        'ucrChkIncludePoints
        '
        Me.ucrChkIncludePoints.Checked = False
        resources.ApplyResources(Me.ucrChkIncludePoints, "ucrChkIncludePoints")
        Me.ucrChkIncludePoints.Name = "ucrChkIncludePoints"
        '
        'ucrChkCountsOnYAxis
        '
        Me.ucrChkCountsOnYAxis.Checked = False
        resources.ApplyResources(Me.ucrChkCountsOnYAxis, "ucrChkCountsOnYAxis")
        Me.ucrChkCountsOnYAxis.Name = "ucrChkCountsOnYAxis"
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
        Me.ucrCumDistSelector.bDropUnusedFilterLevels = False
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
        'dlgCumulativeDistribution
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rdoExceedance)
        Me.Controls.Add(Me.rdoCumulative)
        Me.Controls.Add(Me.ucrNudBy)
        Me.Controls.Add(Me.lblNudby)
        Me.Controls.Add(Me.ucrInputComboScales)
        Me.Controls.Add(Me.lblScale)
        Me.Controls.Add(Me.ucrPnlOption)
        Me.Controls.Add(Me.ucrChkIncludePoints)
        Me.Controls.Add(Me.ucrChkCountsOnYAxis)
        Me.Controls.Add(Me.ucrSaveCumDist)
        Me.Controls.Add(Me.ucrVariablesAsFactorforCumDist)
        Me.Controls.Add(Me.ucrFactorReceiver)
        Me.Controls.Add(Me.cmdPlotOptions)
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
    Friend WithEvents cmdPlotOptions As Button
    Friend WithEvents ucrFactorReceiver As ucrReceiverSingle
    Friend WithEvents ucrVariablesAsFactorforCumDist As ucrVariablesAsFactor
    Friend WithEvents ucrSaveCumDist As ucrSave
    Friend WithEvents ucrChkIncludePoints As ucrCheck
    Friend WithEvents ucrChkCountsOnYAxis As ucrCheck
    Friend WithEvents ucrPnlOption As UcrPanel
    Friend WithEvents lblScale As Label
    Friend WithEvents ucrInputComboScales As ucrInputComboBox
    Friend WithEvents ucrNudBy As ucrNud
    Friend WithEvents lblNudby As Label
    Friend WithEvents rdoExceedance As RadioButton
    Friend WithEvents rdoCumulative As RadioButton
End Class
