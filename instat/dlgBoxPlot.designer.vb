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
Partial Class dlgBoxplot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgBoxplot))
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblByFactors = New System.Windows.Forms.Label()
        Me.lblBySecondFactor = New System.Windows.Forms.Label()
        Me.cmdBoxOptions = New System.Windows.Forms.Button()
        Me.rdoBoxplotTufte = New System.Windows.Forms.RadioButton()
        Me.rdoJitter = New System.Windows.Forms.RadioButton()
        Me.rdoViolin = New System.Windows.Forms.RadioButton()
        Me.lblJitter = New System.Windows.Forms.Label()
        Me.lblTransparency = New System.Windows.Forms.Label()
        Me.ucrChkTufte = New instat.ucrCheck()
        Me.ucrInputSummaries = New instat.ucrInputComboBox()
        Me.ucrChkGrouptoConnect = New instat.ucrCheck()
        Me.ucrNudTransparency = New instat.ucrNud()
        Me.ucrNudJitter = New instat.ucrNud()
        Me.ucrChkAddPoints = New instat.ucrCheck()
        Me.ucrChkSwapParameters = New instat.ucrCheck()
        Me.ucrSaveBoxplot = New instat.ucrSave()
        Me.ucrChkHorizontalBoxplot = New instat.ucrCheck()
        Me.ucrChkVarWidth = New instat.ucrCheck()
        Me.ucrVariablesAsFactorForBoxplot = New instat.ucrVariablesAsFactor()
        Me.ucrSecondFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelectorBoxPlot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrByFactorsReceiver = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlPlots = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblByFactors
        '
        resources.ApplyResources(Me.lblByFactors, "lblByFactors")
        Me.lblByFactors.Name = "lblByFactors"
        Me.lblByFactors.Tag = "By_Factor:"
        '
        'lblBySecondFactor
        '
        resources.ApplyResources(Me.lblBySecondFactor, "lblBySecondFactor")
        Me.lblBySecondFactor.Name = "lblBySecondFactor"
        Me.lblBySecondFactor.Tag = "By_Second_Factor:"
        '
        'cmdBoxOptions
        '
        resources.ApplyResources(Me.cmdBoxOptions, "cmdBoxOptions")
        Me.cmdBoxOptions.Name = "cmdBoxOptions"
        Me.cmdBoxOptions.Tag = "Box_Options"
        Me.cmdBoxOptions.UseVisualStyleBackColor = True
        '
        'rdoBoxplotTufte
        '
        resources.ApplyResources(Me.rdoBoxplotTufte, "rdoBoxplotTufte")
        Me.rdoBoxplotTufte.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoxplotTufte.FlatAppearance.BorderSize = 2
        Me.rdoBoxplotTufte.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoxplotTufte.Name = "rdoBoxplotTufte"
        Me.rdoBoxplotTufte.TabStop = True
        Me.rdoBoxplotTufte.UseVisualStyleBackColor = True
        '
        'rdoJitter
        '
        resources.ApplyResources(Me.rdoJitter, "rdoJitter")
        Me.rdoJitter.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoJitter.FlatAppearance.BorderSize = 2
        Me.rdoJitter.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoJitter.Name = "rdoJitter"
        Me.rdoJitter.TabStop = True
        Me.rdoJitter.UseVisualStyleBackColor = True
        '
        'rdoViolin
        '
        resources.ApplyResources(Me.rdoViolin, "rdoViolin")
        Me.rdoViolin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoViolin.FlatAppearance.BorderSize = 2
        Me.rdoViolin.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoViolin.Name = "rdoViolin"
        Me.rdoViolin.TabStop = True
        Me.rdoViolin.UseVisualStyleBackColor = True
        '
        'lblJitter
        '
        resources.ApplyResources(Me.lblJitter, "lblJitter")
        Me.lblJitter.Name = "lblJitter"
        Me.lblJitter.Tag = "By_Factor:"
        '
        'lblTransparency
        '
        resources.ApplyResources(Me.lblTransparency, "lblTransparency")
        Me.lblTransparency.Name = "lblTransparency"
        Me.lblTransparency.Tag = "By_Factor:"
        '
        'ucrChkTufte
        '
        Me.ucrChkTufte.Checked = False
        resources.ApplyResources(Me.ucrChkTufte, "ucrChkTufte")
        Me.ucrChkTufte.Name = "ucrChkTufte"
        '
        'ucrInputSummaries
        '
        Me.ucrInputSummaries.AddQuotesIfUnrecognised = True
        Me.ucrInputSummaries.GetSetSelectedIndex = -1
        Me.ucrInputSummaries.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSummaries, "ucrInputSummaries")
        Me.ucrInputSummaries.Name = "ucrInputSummaries"
        '
        'ucrChkGrouptoConnect
        '
        Me.ucrChkGrouptoConnect.Checked = False
        resources.ApplyResources(Me.ucrChkGrouptoConnect, "ucrChkGrouptoConnect")
        Me.ucrChkGrouptoConnect.Name = "ucrChkGrouptoConnect"
        '
        'ucrNudTransparency
        '
        Me.ucrNudTransparency.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTransparency.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudTransparency, "ucrNudTransparency")
        Me.ucrNudTransparency.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTransparency.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTransparency.Name = "ucrNudTransparency"
        Me.ucrNudTransparency.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudJitter
        '
        Me.ucrNudJitter.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJitter.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudJitter, "ucrNudJitter")
        Me.ucrNudJitter.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudJitter.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJitter.Name = "ucrNudJitter"
        Me.ucrNudJitter.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkAddPoints
        '
        Me.ucrChkAddPoints.Checked = False
        resources.ApplyResources(Me.ucrChkAddPoints, "ucrChkAddPoints")
        Me.ucrChkAddPoints.Name = "ucrChkAddPoints"
        '
        'ucrChkSwapParameters
        '
        Me.ucrChkSwapParameters.Checked = False
        resources.ApplyResources(Me.ucrChkSwapParameters, "ucrChkSwapParameters")
        Me.ucrChkSwapParameters.Name = "ucrChkSwapParameters"
        '
        'ucrSaveBoxplot
        '
        resources.ApplyResources(Me.ucrSaveBoxplot, "ucrSaveBoxplot")
        Me.ucrSaveBoxplot.Name = "ucrSaveBoxplot"
        '
        'ucrChkHorizontalBoxplot
        '
        Me.ucrChkHorizontalBoxplot.Checked = False
        resources.ApplyResources(Me.ucrChkHorizontalBoxplot, "ucrChkHorizontalBoxplot")
        Me.ucrChkHorizontalBoxplot.Name = "ucrChkHorizontalBoxplot"
        '
        'ucrChkVarWidth
        '
        Me.ucrChkVarWidth.Checked = False
        resources.ApplyResources(Me.ucrChkVarWidth, "ucrChkVarWidth")
        Me.ucrChkVarWidth.Name = "ucrChkVarWidth"
        '
        'ucrVariablesAsFactorForBoxplot
        '
        Me.ucrVariablesAsFactorForBoxplot.frmParent = Me
        resources.ApplyResources(Me.ucrVariablesAsFactorForBoxplot, "ucrVariablesAsFactorForBoxplot")
        Me.ucrVariablesAsFactorForBoxplot.Name = "ucrVariablesAsFactorForBoxplot"
        Me.ucrVariablesAsFactorForBoxplot.Selector = Nothing
        Me.ucrVariablesAsFactorForBoxplot.strNcFilePath = ""
        Me.ucrVariablesAsFactorForBoxplot.ucrSelector = Nothing
        Me.ucrVariablesAsFactorForBoxplot.ucrVariableSelector = Nothing
        '
        'ucrSecondFactorReceiver
        '
        Me.ucrSecondFactorReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrSecondFactorReceiver, "ucrSecondFactorReceiver")
        Me.ucrSecondFactorReceiver.Name = "ucrSecondFactorReceiver"
        Me.ucrSecondFactorReceiver.Selector = Nothing
        Me.ucrSecondFactorReceiver.strNcFilePath = ""
        Me.ucrSecondFactorReceiver.ucrSelector = Nothing
        '
        'ucrSelectorBoxPlot
        '
        Me.ucrSelectorBoxPlot.bDropUnusedFilterLevels = False
        Me.ucrSelectorBoxPlot.bShowHiddenColumns = False
        Me.ucrSelectorBoxPlot.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorBoxPlot, "ucrSelectorBoxPlot")
        Me.ucrSelectorBoxPlot.Name = "ucrSelectorBoxPlot"
        '
        'ucrByFactorsReceiver
        '
        Me.ucrByFactorsReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrByFactorsReceiver, "ucrByFactorsReceiver")
        Me.ucrByFactorsReceiver.Name = "ucrByFactorsReceiver"
        Me.ucrByFactorsReceiver.Selector = Nothing
        Me.ucrByFactorsReceiver.strNcFilePath = ""
        Me.ucrByFactorsReceiver.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrPnlPlots
        '
        resources.ApplyResources(Me.ucrPnlPlots, "ucrPnlPlots")
        Me.ucrPnlPlots.Name = "ucrPnlPlots"
        '
        'dlgBoxplot
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkTufte)
        Me.Controls.Add(Me.ucrInputSummaries)
        Me.Controls.Add(Me.ucrChkGrouptoConnect)
        Me.Controls.Add(Me.ucrNudTransparency)
        Me.Controls.Add(Me.lblTransparency)
        Me.Controls.Add(Me.ucrNudJitter)
        Me.Controls.Add(Me.lblJitter)
        Me.Controls.Add(Me.ucrChkAddPoints)
        Me.Controls.Add(Me.ucrChkSwapParameters)
        Me.Controls.Add(Me.ucrSaveBoxplot)
        Me.Controls.Add(Me.ucrChkHorizontalBoxplot)
        Me.Controls.Add(Me.ucrChkVarWidth)
        Me.Controls.Add(Me.rdoViolin)
        Me.Controls.Add(Me.rdoJitter)
        Me.Controls.Add(Me.rdoBoxplotTufte)
        Me.Controls.Add(Me.ucrVariablesAsFactorForBoxplot)
        Me.Controls.Add(Me.cmdBoxOptions)
        Me.Controls.Add(Me.ucrSecondFactorReceiver)
        Me.Controls.Add(Me.ucrSelectorBoxPlot)
        Me.Controls.Add(Me.lblBySecondFactor)
        Me.Controls.Add(Me.lblByFactors)
        Me.Controls.Add(Me.ucrByFactorsReceiver)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlPlots)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgBoxplot"
        Me.ShowIcon = False
        Me.Tag = "Boxplot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrByFactorsReceiver As ucrReceiverSingle
    Friend WithEvents lblByFactors As Label
    Friend WithEvents ucrSelectorBoxPlot As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSecondFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblBySecondFactor As Label
    Friend WithEvents cmdBoxOptions As Button
    Friend WithEvents ucrVariablesAsFactorForBoxplot As ucrVariablesAsFactor
    Friend WithEvents rdoBoxplotTufte As RadioButton
    Friend WithEvents rdoJitter As RadioButton
    Friend WithEvents rdoViolin As RadioButton
    Friend WithEvents ucrSaveBoxplot As ucrSave
    Friend WithEvents ucrChkHorizontalBoxplot As ucrCheck
    Friend WithEvents ucrChkVarWidth As ucrCheck
    Friend WithEvents ucrPnlPlots As UcrPanel
    Friend WithEvents ucrChkSwapParameters As ucrCheck
    Friend WithEvents ucrNudTransparency As ucrNud
    Friend WithEvents lblTransparency As Label
    Friend WithEvents ucrNudJitter As ucrNud
    Friend WithEvents lblJitter As Label
    Friend WithEvents ucrChkAddPoints As ucrCheck
    Friend WithEvents ucrInputSummaries As ucrInputComboBox
    Friend WithEvents ucrChkGrouptoConnect As ucrCheck
    Friend WithEvents ucrChkTufte As ucrCheck
End Class
