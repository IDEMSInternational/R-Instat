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
        Me.lblFactors.AutoSize = True
        Me.lblFactors.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactors.Location = New System.Drawing.Point(275, 220)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(88, 13)
        Me.lblFactors.TabIndex = 5
        Me.lblFactors.Tag = "Factors_Optional:"
        Me.lblFactors.Text = "Factor (Optional):"
        '
        'cmdPlotOptions
        '
        Me.cmdPlotOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlotOptions.Location = New System.Drawing.Point(10, 238)
        Me.cmdPlotOptions.Name = "cmdPlotOptions"
        Me.cmdPlotOptions.Size = New System.Drawing.Size(150, 23)
        Me.cmdPlotOptions.TabIndex = 7
        Me.cmdPlotOptions.Tag = "Plot_Options"
        Me.cmdPlotOptions.Text = "Plot Options"
        Me.cmdPlotOptions.UseVisualStyleBackColor = True
        '
        'lblScale
        '
        Me.lblScale.AutoSize = True
        Me.lblScale.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblScale.Location = New System.Drawing.Point(193, 267)
        Me.lblScale.Name = "lblScale"
        Me.lblScale.Size = New System.Drawing.Size(51, 13)
        Me.lblScale.TabIndex = 11
        Me.lblScale.Text = "Scale by:"
        Me.lblScale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNudby
        '
        Me.lblNudby.AutoSize = True
        Me.lblNudby.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNudby.Location = New System.Drawing.Point(185, 297)
        Me.lblNudby.Name = "lblNudby"
        Me.lblNudby.Size = New System.Drawing.Size(59, 13)
        Me.lblNudby.TabIndex = 13
        Me.lblNudby.Text = "In steps of:"
        Me.lblNudby.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rdoCumulative
        '
        Me.rdoCumulative.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoCumulative.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCumulative.FlatAppearance.BorderSize = 2
        Me.rdoCumulative.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCumulative.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCumulative.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCumulative.Location = New System.Drawing.Point(119, 14)
        Me.rdoCumulative.Name = "rdoCumulative"
        Me.rdoCumulative.Size = New System.Drawing.Size(86, 27)
        Me.rdoCumulative.TabIndex = 1
        Me.rdoCumulative.TabStop = True
        Me.rdoCumulative.Text = "Cumulative"
        Me.rdoCumulative.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoCumulative.UseVisualStyleBackColor = True
        '
        'rdoExceedance
        '
        Me.rdoExceedance.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoExceedance.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoExceedance.FlatAppearance.BorderSize = 2
        Me.rdoExceedance.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoExceedance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoExceedance.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoExceedance.Location = New System.Drawing.Point(203, 14)
        Me.rdoExceedance.Name = "rdoExceedance"
        Me.rdoExceedance.Size = New System.Drawing.Size(86, 27)
        Me.rdoExceedance.TabIndex = 2
        Me.rdoExceedance.TabStop = True
        Me.rdoExceedance.Text = "Exceedance"
        Me.rdoExceedance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoExceedance.UseVisualStyleBackColor = True
        '
        'ucrNudBy
        '
        Me.ucrNudBy.AutoSize = True
        Me.ucrNudBy.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBy.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBy.Location = New System.Drawing.Point(278, 294)
        Me.ucrNudBy.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBy.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBy.Name = "ucrNudBy"
        Me.ucrNudBy.Size = New System.Drawing.Size(56, 20)
        Me.ucrNudBy.TabIndex = 14
        Me.ucrNudBy.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputComboScales
        '
        Me.ucrInputComboScales.AddQuotesIfUnrecognised = True
        Me.ucrInputComboScales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboScales.GetSetSelectedIndex = -1
        Me.ucrInputComboScales.IsReadOnly = False
        Me.ucrInputComboScales.Location = New System.Drawing.Point(278, 264)
        Me.ucrInputComboScales.Name = "ucrInputComboScales"
        Me.ucrInputComboScales.Size = New System.Drawing.Size(120, 26)
        Me.ucrInputComboScales.TabIndex = 12
        '
        'ucrPnlOption
        '
        Me.ucrPnlOption.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucrPnlOption.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOption.Location = New System.Drawing.Point(101, 9)
        Me.ucrPnlOption.Name = "ucrPnlOption"
        Me.ucrPnlOption.Size = New System.Drawing.Size(211, 38)
        Me.ucrPnlOption.TabIndex = 0
        '
        'ucrChkIncludePoints
        '
        Me.ucrChkIncludePoints.AutoSize = True
        Me.ucrChkIncludePoints.Checked = False
        Me.ucrChkIncludePoints.Location = New System.Drawing.Point(10, 300)
        Me.ucrChkIncludePoints.Name = "ucrChkIncludePoints"
        Me.ucrChkIncludePoints.Size = New System.Drawing.Size(152, 23)
        Me.ucrChkIncludePoints.TabIndex = 9
        '
        'ucrChkCountsOnYAxis
        '
        Me.ucrChkCountsOnYAxis.AutoSize = True
        Me.ucrChkCountsOnYAxis.Checked = False
        Me.ucrChkCountsOnYAxis.Location = New System.Drawing.Point(10, 274)
        Me.ucrChkCountsOnYAxis.Name = "ucrChkCountsOnYAxis"
        Me.ucrChkCountsOnYAxis.Size = New System.Drawing.Size(152, 23)
        Me.ucrChkCountsOnYAxis.TabIndex = 8
        '
        'ucrSaveCumDist
        '
        Me.ucrSaveCumDist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveCumDist.Location = New System.Drawing.Point(10, 327)
        Me.ucrSaveCumDist.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveCumDist.Name = "ucrSaveCumDist"
        Me.ucrSaveCumDist.Size = New System.Drawing.Size(320, 24)
        Me.ucrSaveCumDist.TabIndex = 10
        '
        'ucrVariablesAsFactorforCumDist
        '
        Me.ucrVariablesAsFactorforCumDist.AutoSize = True
        Me.ucrVariablesAsFactorforCumDist.frmParent = Me
        Me.ucrVariablesAsFactorforCumDist.Location = New System.Drawing.Point(246, 70)
        Me.ucrVariablesAsFactorforCumDist.Name = "ucrVariablesAsFactorforCumDist"
        Me.ucrVariablesAsFactorforCumDist.Selector = Nothing
        Me.ucrVariablesAsFactorforCumDist.Size = New System.Drawing.Size(125, 136)
        Me.ucrVariablesAsFactorforCumDist.strNcFilePath = ""
        Me.ucrVariablesAsFactorforCumDist.TabIndex = 4
        Me.ucrVariablesAsFactorforCumDist.ucrSelector = Nothing
        Me.ucrVariablesAsFactorforCumDist.ucrVariableSelector = Nothing
        '
        'ucrFactorReceiver
        '
        Me.ucrFactorReceiver.AutoSize = True
        Me.ucrFactorReceiver.frmParent = Me
        Me.ucrFactorReceiver.Location = New System.Drawing.Point(278, 235)
        Me.ucrFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorReceiver.Name = "ucrFactorReceiver"
        Me.ucrFactorReceiver.Selector = Nothing
        Me.ucrFactorReceiver.Size = New System.Drawing.Size(120, 26)
        Me.ucrFactorReceiver.strNcFilePath = ""
        Me.ucrFactorReceiver.TabIndex = 6
        Me.ucrFactorReceiver.ucrSelector = Nothing
        '
        'ucrCumDistSelector
        '
        Me.ucrCumDistSelector.AutoSize = True
        Me.ucrCumDistSelector.bDropUnusedFilterLevels = False
        Me.ucrCumDistSelector.bShowHiddenColumns = False
        Me.ucrCumDistSelector.bUseCurrentFilter = True
        Me.ucrCumDistSelector.Location = New System.Drawing.Point(10, 50)
        Me.ucrCumDistSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrCumDistSelector.Name = "ucrCumDistSelector"
        Me.ucrCumDistSelector.Size = New System.Drawing.Size(213, 183)
        Me.ucrCumDistSelector.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 354)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 15
        '
        'dlgCumulativeDistribution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(415, 410)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Cumulative_Distribution"
        Me.Text = "Cumulative/Exceedance Graph"
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
