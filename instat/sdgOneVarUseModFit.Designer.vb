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
Partial Class sdgOneVarUseModFit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgOneVarUseModFit))
        Me.tbpBootstrapOptions = New System.Windows.Forms.TabPage()
        Me.ucrChkParametric = New instat.ucrCheck()
        Me.lblNumberOfIterations = New System.Windows.Forms.Label()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.ucrNudIterations = New instat.ucrNud()
        Me.ucrNudCI = New instat.ucrNud()
        Me.tbpQuantiles = New System.Windows.Forms.TabPage()
        Me.ucrInputQuantiles = New instat.ucrInputComboBox()
        Me.ucrNudBy = New instat.ucrNud()
        Me.ucrNudTo = New instat.ucrNud()
        Me.ucrNudFrom = New instat.ucrNud()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.rdoSequence = New System.Windows.Forms.RadioButton()
        Me.rdoInsertValues = New System.Windows.Forms.RadioButton()
        Me.lblBy = New System.Windows.Forms.Label()
        Me.ucrPnlQuantiles = New instat.UcrPanel()
        Me.tbpPlots = New System.Windows.Forms.TabPage()
        Me.rdoNoPlot = New System.Windows.Forms.RadioButton()
        Me.rdoPlotAll = New System.Windows.Forms.RadioButton()
        Me.rdoCDFPlot = New System.Windows.Forms.RadioButton()
        Me.rdoPPPlot = New System.Windows.Forms.RadioButton()
        Me.rdoDensityPlot = New System.Windows.Forms.RadioButton()
        Me.rdoQQPlot = New System.Windows.Forms.RadioButton()
        Me.rdoCIcdf = New System.Windows.Forms.RadioButton()
        Me.ucrPnlPlots = New instat.UcrPanel()
        Me.tbpOneVarUseModFit = New System.Windows.Forms.TabControl()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.tbpBootstrapOptions.SuspendLayout()
        Me.tbpQuantiles.SuspendLayout()
        Me.tbpPlots.SuspendLayout()
        Me.tbpOneVarUseModFit.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpBootstrapOptions
        '
        Me.tbpBootstrapOptions.Controls.Add(Me.ucrChkParametric)
        Me.tbpBootstrapOptions.Controls.Add(Me.lblNumberOfIterations)
        Me.tbpBootstrapOptions.Controls.Add(Me.lblCI)
        Me.tbpBootstrapOptions.Controls.Add(Me.ucrNudIterations)
        Me.tbpBootstrapOptions.Controls.Add(Me.ucrNudCI)
        resources.ApplyResources(Me.tbpBootstrapOptions, "tbpBootstrapOptions")
        Me.tbpBootstrapOptions.Name = "tbpBootstrapOptions"
        Me.tbpBootstrapOptions.UseVisualStyleBackColor = True
        '
        'ucrChkParametric
        '
        Me.ucrChkParametric.Checked = False
        resources.ApplyResources(Me.ucrChkParametric, "ucrChkParametric")
        Me.ucrChkParametric.Name = "ucrChkParametric"
        '
        'lblNumberOfIterations
        '
        resources.ApplyResources(Me.lblNumberOfIterations, "lblNumberOfIterations")
        Me.lblNumberOfIterations.Name = "lblNumberOfIterations"
        '
        'lblCI
        '
        resources.ApplyResources(Me.lblCI, "lblCI")
        Me.lblCI.Name = "lblCI"
        '
        'ucrNudIterations
        '
        Me.ucrNudIterations.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudIterations.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudIterations, "ucrNudIterations")
        Me.ucrNudIterations.Maximum = New Decimal(New Integer() {10001, 0, 0, 0})
        Me.ucrNudIterations.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudIterations.Name = "ucrNudIterations"
        Me.ucrNudIterations.Value = New Decimal(New Integer() {1001, 0, 0, 0})
        '
        'ucrNudCI
        '
        Me.ucrNudCI.DecimalPlaces = New Decimal(New Integer() {2, 0, 0, 0})
        Me.ucrNudCI.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        resources.ApplyResources(Me.ucrNudCI, "ucrNudCI")
        Me.ucrNudCI.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCI.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCI.Name = "ucrNudCI"
        Me.ucrNudCI.Value = New Decimal(New Integer() {95, 0, 0, 131072})
        '
        'tbpQuantiles
        '
        Me.tbpQuantiles.Controls.Add(Me.ucrInputQuantiles)
        Me.tbpQuantiles.Controls.Add(Me.ucrNudBy)
        Me.tbpQuantiles.Controls.Add(Me.ucrNudTo)
        Me.tbpQuantiles.Controls.Add(Me.ucrNudFrom)
        Me.tbpQuantiles.Controls.Add(Me.lblFrom)
        Me.tbpQuantiles.Controls.Add(Me.lblTo)
        Me.tbpQuantiles.Controls.Add(Me.rdoSequence)
        Me.tbpQuantiles.Controls.Add(Me.rdoInsertValues)
        Me.tbpQuantiles.Controls.Add(Me.lblBy)
        Me.tbpQuantiles.Controls.Add(Me.ucrPnlQuantiles)
        resources.ApplyResources(Me.tbpQuantiles, "tbpQuantiles")
        Me.tbpQuantiles.Name = "tbpQuantiles"
        Me.tbpQuantiles.UseVisualStyleBackColor = True
        '
        'ucrInputQuantiles
        '
        Me.ucrInputQuantiles.AddQuotesIfUnrecognised = True
        Me.ucrInputQuantiles.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputQuantiles, "ucrInputQuantiles")
        Me.ucrInputQuantiles.Name = "ucrInputQuantiles"
        '
        'ucrNudBy
        '
        Me.ucrNudBy.DecimalPlaces = New Decimal(New Integer() {2, 0, 0, 0})
        Me.ucrNudBy.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        resources.ApplyResources(Me.ucrNudBy, "ucrNudBy")
        Me.ucrNudBy.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBy.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.ucrNudBy.Name = "ucrNudBy"
        Me.ucrNudBy.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'ucrNudTo
        '
        Me.ucrNudTo.DecimalPlaces = New Decimal(New Integer() {2, 0, 0, 0})
        Me.ucrNudTo.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        resources.ApplyResources(Me.ucrNudTo, "ucrNudTo")
        Me.ucrNudTo.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Name = "ucrNudTo"
        Me.ucrNudTo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ucrNudFrom
        '
        Me.ucrNudFrom.DecimalPlaces = New Decimal(New Integer() {2, 0, 0, 0})
        Me.ucrNudFrom.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        resources.ApplyResources(Me.ucrNudFrom, "ucrNudFrom")
        Me.ucrNudFrom.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Name = "ucrNudFrom"
        Me.ucrNudFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblFrom
        '
        resources.ApplyResources(Me.lblFrom, "lblFrom")
        Me.lblFrom.Name = "lblFrom"
        '
        'lblTo
        '
        resources.ApplyResources(Me.lblTo, "lblTo")
        Me.lblTo.Name = "lblTo"
        '
        'rdoSequence
        '
        resources.ApplyResources(Me.rdoSequence, "rdoSequence")
        Me.rdoSequence.Name = "rdoSequence"
        Me.rdoSequence.UseVisualStyleBackColor = True
        '
        'rdoInsertValues
        '
        resources.ApplyResources(Me.rdoInsertValues, "rdoInsertValues")
        Me.rdoInsertValues.Name = "rdoInsertValues"
        Me.rdoInsertValues.UseVisualStyleBackColor = True
        '
        'lblBy
        '
        resources.ApplyResources(Me.lblBy, "lblBy")
        Me.lblBy.Name = "lblBy"
        '
        'ucrPnlQuantiles
        '
        resources.ApplyResources(Me.ucrPnlQuantiles, "ucrPnlQuantiles")
        Me.ucrPnlQuantiles.Name = "ucrPnlQuantiles"
        '
        'tbpPlots
        '
        Me.tbpPlots.Controls.Add(Me.rdoNoPlot)
        Me.tbpPlots.Controls.Add(Me.rdoPlotAll)
        Me.tbpPlots.Controls.Add(Me.rdoCDFPlot)
        Me.tbpPlots.Controls.Add(Me.rdoPPPlot)
        Me.tbpPlots.Controls.Add(Me.rdoDensityPlot)
        Me.tbpPlots.Controls.Add(Me.rdoQQPlot)
        Me.tbpPlots.Controls.Add(Me.rdoCIcdf)
        Me.tbpPlots.Controls.Add(Me.ucrPnlPlots)
        resources.ApplyResources(Me.tbpPlots, "tbpPlots")
        Me.tbpPlots.Name = "tbpPlots"
        Me.tbpPlots.UseVisualStyleBackColor = True
        '
        'rdoNoPlot
        '
        resources.ApplyResources(Me.rdoNoPlot, "rdoNoPlot")
        Me.rdoNoPlot.Name = "rdoNoPlot"
        Me.rdoNoPlot.UseVisualStyleBackColor = True
        '
        'rdoPlotAll
        '
        resources.ApplyResources(Me.rdoPlotAll, "rdoPlotAll")
        Me.rdoPlotAll.Name = "rdoPlotAll"
        Me.rdoPlotAll.UseVisualStyleBackColor = True
        '
        'rdoCDFPlot
        '
        resources.ApplyResources(Me.rdoCDFPlot, "rdoCDFPlot")
        Me.rdoCDFPlot.Name = "rdoCDFPlot"
        Me.rdoCDFPlot.UseVisualStyleBackColor = True
        '
        'rdoPPPlot
        '
        resources.ApplyResources(Me.rdoPPPlot, "rdoPPPlot")
        Me.rdoPPPlot.Name = "rdoPPPlot"
        Me.rdoPPPlot.UseVisualStyleBackColor = True
        '
        'rdoDensityPlot
        '
        resources.ApplyResources(Me.rdoDensityPlot, "rdoDensityPlot")
        Me.rdoDensityPlot.Name = "rdoDensityPlot"
        Me.rdoDensityPlot.UseVisualStyleBackColor = True
        '
        'rdoQQPlot
        '
        resources.ApplyResources(Me.rdoQQPlot, "rdoQQPlot")
        Me.rdoQQPlot.Name = "rdoQQPlot"
        Me.rdoQQPlot.UseVisualStyleBackColor = True
        '
        'rdoCIcdf
        '
        resources.ApplyResources(Me.rdoCIcdf, "rdoCIcdf")
        Me.rdoCIcdf.Name = "rdoCIcdf"
        Me.rdoCIcdf.UseVisualStyleBackColor = True
        '
        'ucrPnlPlots
        '
        resources.ApplyResources(Me.ucrPnlPlots, "ucrPnlPlots")
        Me.ucrPnlPlots.Name = "ucrPnlPlots"
        '
        'tbpOneVarUseModFit
        '
        Me.tbpOneVarUseModFit.Controls.Add(Me.tbpPlots)
        Me.tbpOneVarUseModFit.Controls.Add(Me.tbpQuantiles)
        Me.tbpOneVarUseModFit.Controls.Add(Me.tbpBootstrapOptions)
        resources.ApplyResources(Me.tbpOneVarUseModFit, "tbpOneVarUseModFit")
        Me.tbpOneVarUseModFit.Name = "tbpOneVarUseModFit"
        Me.tbpOneVarUseModFit.SelectedIndex = 0
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'sdgOneVarUseModFit
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbpOneVarUseModFit)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneVarUseModFit"
        Me.tbpBootstrapOptions.ResumeLayout(False)
        Me.tbpBootstrapOptions.PerformLayout()
        Me.tbpQuantiles.ResumeLayout(False)
        Me.tbpQuantiles.PerformLayout()
        Me.tbpPlots.ResumeLayout(False)
        Me.tbpPlots.PerformLayout()
        Me.tbpOneVarUseModFit.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents tbpBootstrapOptions As TabPage
    Friend WithEvents ucrChkParametric As ucrCheck
    Friend WithEvents ucrNudIterations As ucrNud
    Friend WithEvents ucrNudCI As ucrNud
    Friend WithEvents lblNumberOfIterations As Label
    Friend WithEvents lblCI As Label
    Friend WithEvents tbpQuantiles As TabPage
    Friend WithEvents tbpPlots As TabPage
    Friend WithEvents tbpOneVarUseModFit As TabControl
    Friend WithEvents rdoNoPlot As RadioButton
    Friend WithEvents rdoPlotAll As RadioButton
    Friend WithEvents rdoCDFPlot As RadioButton
    Friend WithEvents rdoDensityPlot As RadioButton
    Friend WithEvents rdoCIcdf As RadioButton
    Friend WithEvents rdoQQPlot As RadioButton
    Friend WithEvents rdoPPPlot As RadioButton
    Friend WithEvents ucrPnlPlots As UcrPanel
    Friend WithEvents ucrNudBy As ucrNud
    Friend WithEvents ucrNudTo As ucrNud
    Friend WithEvents ucrNudFrom As ucrNud
    Friend WithEvents rdoSequence As RadioButton
    Friend WithEvents lblBy As Label
    Friend WithEvents rdoInsertValues As RadioButton
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents ucrPnlQuantiles As UcrPanel
    Friend WithEvents ucrInputQuantiles As ucrInputComboBox
End Class
