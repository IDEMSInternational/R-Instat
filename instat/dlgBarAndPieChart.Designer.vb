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
Partial Class dlgBarAndPieChart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgBarAndPieChart))
        Me.lblByFactor = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.cmdPieChartOptions = New System.Windows.Forms.Button()
        Me.rdoValue = New System.Windows.Forms.RadioButton()
        Me.cmdBarChartOptions = New System.Windows.Forms.Button()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.cmdColumnChartOptions = New System.Windows.Forms.Button()
        Me.rdoFrequency = New System.Windows.Forms.RadioButton()
        Me.lblXvariable = New System.Windows.Forms.Label()
        Me.rdoPie = New System.Windows.Forms.RadioButton()
        Me.rdoDonut = New System.Windows.Forms.RadioButton()
        Me.lblLabelPosition = New System.Windows.Forms.Label()
        Me.lblLabelColour = New System.Windows.Forms.Label()
        Me.ucrInputLabelPosition = New instat.ucrInputComboBox()
        Me.ucrInputLabelColour = New instat.ucrInputComboBox()
        Me.ucrChkAddLabels = New instat.ucrCheck()
        Me.ucrChkPolarCoordinates = New instat.ucrCheck()
        Me.ucrPnlPolar = New instat.UcrPanel()
        Me.ucrChkBacktoback = New instat.ucrCheck()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrVariablesAsFactorForBarChart = New instat.ucrVariablesAsFactor()
        Me.ucrInputBarChartPositions = New instat.ucrInputComboBox()
        Me.ucrSaveBar = New instat.ucrSave()
        Me.ucrChkFlipCoordinates = New instat.ucrCheck()
        Me.ucrReceiverByFactor = New instat.ucrReceiverSingle()
        Me.ucrBarChartSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrInputLabelSize = New instat.ucrInputComboBox()
        Me.lblLabelSize = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblByFactor
        '
        resources.ApplyResources(Me.lblByFactor, "lblByFactor")
        Me.lblByFactor.Name = "lblByFactor"
        Me.lblByFactor.Tag = "By_Factor:"
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Tag = "Plot_Options..."
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'cmdPieChartOptions
        '
        resources.ApplyResources(Me.cmdPieChartOptions, "cmdPieChartOptions")
        Me.cmdPieChartOptions.Name = "cmdPieChartOptions"
        Me.cmdPieChartOptions.Tag = "Pie_Chart_Options"
        Me.cmdPieChartOptions.UseVisualStyleBackColor = True
        '
        'rdoValue
        '
        resources.ApplyResources(Me.rdoValue, "rdoValue")
        Me.rdoValue.BackColor = System.Drawing.SystemColors.Control
        Me.rdoValue.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoValue.FlatAppearance.BorderSize = 2
        Me.rdoValue.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoValue.Name = "rdoValue"
        Me.rdoValue.TabStop = True
        Me.rdoValue.Tag = "Value"
        Me.rdoValue.UseVisualStyleBackColor = False
        '
        'cmdBarChartOptions
        '
        resources.ApplyResources(Me.cmdBarChartOptions, "cmdBarChartOptions")
        Me.cmdBarChartOptions.Name = "cmdBarChartOptions"
        Me.cmdBarChartOptions.Tag = "Bar_Chart_Options"
        Me.cmdBarChartOptions.UseVisualStyleBackColor = True
        '
        'lblPosition
        '
        resources.ApplyResources(Me.lblPosition, "lblPosition")
        Me.lblPosition.Name = "lblPosition"
        '
        'cmdColumnChartOptions
        '
        resources.ApplyResources(Me.cmdColumnChartOptions, "cmdColumnChartOptions")
        Me.cmdColumnChartOptions.Name = "cmdColumnChartOptions"
        Me.cmdColumnChartOptions.Tag = "Column_Chart_Options"
        Me.cmdColumnChartOptions.UseVisualStyleBackColor = True
        '
        'rdoFrequency
        '
        resources.ApplyResources(Me.rdoFrequency, "rdoFrequency")
        Me.rdoFrequency.BackColor = System.Drawing.SystemColors.Control
        Me.rdoFrequency.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFrequency.FlatAppearance.BorderSize = 2
        Me.rdoFrequency.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFrequency.Name = "rdoFrequency"
        Me.rdoFrequency.TabStop = True
        Me.rdoFrequency.Tag = "Frequency"
        Me.rdoFrequency.UseVisualStyleBackColor = False
        '
        'lblXvariable
        '
        resources.ApplyResources(Me.lblXvariable, "lblXvariable")
        Me.lblXvariable.Name = "lblXvariable"
        '
        'rdoPie
        '
        resources.ApplyResources(Me.rdoPie, "rdoPie")
        Me.rdoPie.Name = "rdoPie"
        Me.rdoPie.TabStop = True
        Me.rdoPie.UseVisualStyleBackColor = True
        '
        'rdoDonut
        '
        resources.ApplyResources(Me.rdoDonut, "rdoDonut")
        Me.rdoDonut.Name = "rdoDonut"
        Me.rdoDonut.TabStop = True
        Me.rdoDonut.UseVisualStyleBackColor = True
        '
        'lblLabelPosition
        '
        resources.ApplyResources(Me.lblLabelPosition, "lblLabelPosition")
        Me.lblLabelPosition.Name = "lblLabelPosition"
        '
        'lblLabelColour
        '
        resources.ApplyResources(Me.lblLabelColour, "lblLabelColour")
        Me.lblLabelColour.Name = "lblLabelColour"
        '
        'ucrInputLabelPosition
        '
        Me.ucrInputLabelPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLabelPosition.GetSetSelectedIndex = -1
        Me.ucrInputLabelPosition.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLabelPosition, "ucrInputLabelPosition")
        Me.ucrInputLabelPosition.Name = "ucrInputLabelPosition"
        '
        'ucrInputLabelColour
        '
        Me.ucrInputLabelColour.AddQuotesIfUnrecognised = True
        Me.ucrInputLabelColour.GetSetSelectedIndex = -1
        Me.ucrInputLabelColour.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLabelColour, "ucrInputLabelColour")
        Me.ucrInputLabelColour.Name = "ucrInputLabelColour"
        '
        'ucrChkAddLabels
        '
        Me.ucrChkAddLabels.Checked = False
        resources.ApplyResources(Me.ucrChkAddLabels, "ucrChkAddLabels")
        Me.ucrChkAddLabels.Name = "ucrChkAddLabels"
        '
        'ucrChkPolarCoordinates
        '
        Me.ucrChkPolarCoordinates.Checked = False
        resources.ApplyResources(Me.ucrChkPolarCoordinates, "ucrChkPolarCoordinates")
        Me.ucrChkPolarCoordinates.Name = "ucrChkPolarCoordinates"
        '
        'ucrPnlPolar
        '
        resources.ApplyResources(Me.ucrPnlPolar, "ucrPnlPolar")
        Me.ucrPnlPolar.Name = "ucrPnlPolar"
        '
        'ucrChkBacktoback
        '
        Me.ucrChkBacktoback.Checked = False
        resources.ApplyResources(Me.ucrChkBacktoback, "ucrChkBacktoback")
        Me.ucrChkBacktoback.Name = "ucrChkBacktoback"
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverX, "ucrReceiverX")
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrVariablesAsFactorForBarChart
        '
        Me.ucrVariablesAsFactorForBarChart.frmParent = Me
        resources.ApplyResources(Me.ucrVariablesAsFactorForBarChart, "ucrVariablesAsFactorForBarChart")
        Me.ucrVariablesAsFactorForBarChart.Name = "ucrVariablesAsFactorForBarChart"
        Me.ucrVariablesAsFactorForBarChart.Selector = Nothing
        Me.ucrVariablesAsFactorForBarChart.strNcFilePath = ""
        Me.ucrVariablesAsFactorForBarChart.ucrSelector = Nothing
        Me.ucrVariablesAsFactorForBarChart.ucrVariableSelector = Nothing
        '
        'ucrInputBarChartPositions
        '
        Me.ucrInputBarChartPositions.AddQuotesIfUnrecognised = True
        Me.ucrInputBarChartPositions.GetSetSelectedIndex = -1
        Me.ucrInputBarChartPositions.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputBarChartPositions, "ucrInputBarChartPositions")
        Me.ucrInputBarChartPositions.Name = "ucrInputBarChartPositions"
        '
        'ucrSaveBar
        '
        resources.ApplyResources(Me.ucrSaveBar, "ucrSaveBar")
        Me.ucrSaveBar.Name = "ucrSaveBar"
        '
        'ucrChkFlipCoordinates
        '
        Me.ucrChkFlipCoordinates.Checked = False
        resources.ApplyResources(Me.ucrChkFlipCoordinates, "ucrChkFlipCoordinates")
        Me.ucrChkFlipCoordinates.Name = "ucrChkFlipCoordinates"
        '
        'ucrReceiverByFactor
        '
        Me.ucrReceiverByFactor.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverByFactor, "ucrReceiverByFactor")
        Me.ucrReceiverByFactor.Name = "ucrReceiverByFactor"
        Me.ucrReceiverByFactor.Selector = Nothing
        Me.ucrReceiverByFactor.strNcFilePath = ""
        Me.ucrReceiverByFactor.ucrSelector = Nothing
        '
        'ucrBarChartSelector
        '
        Me.ucrBarChartSelector.bDropUnusedFilterLevels = False
        Me.ucrBarChartSelector.bShowHiddenColumns = False
        Me.ucrBarChartSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrBarChartSelector, "ucrBarChartSelector")
        Me.ucrBarChartSelector.Name = "ucrBarChartSelector"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrPnlOptions
        '
        resources.ApplyResources(Me.ucrPnlOptions, "ucrPnlOptions")
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        '
        'ucrInputLabelSize
        '
        Me.ucrInputLabelSize.AddQuotesIfUnrecognised = True
        Me.ucrInputLabelSize.GetSetSelectedIndex = -1
        Me.ucrInputLabelSize.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLabelSize, "ucrInputLabelSize")
        Me.ucrInputLabelSize.Name = "ucrInputLabelSize"
        '
        'lblLabelSize
        '
        resources.ApplyResources(Me.lblLabelSize, "lblLabelSize")
        Me.lblLabelSize.Name = "lblLabelSize"
        '
        'dlgBarAndPieChart
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblLabelSize)
        Me.Controls.Add(Me.ucrInputLabelSize)
        Me.Controls.Add(Me.lblLabelColour)
        Me.Controls.Add(Me.lblLabelPosition)
        Me.Controls.Add(Me.ucrInputLabelPosition)
        Me.Controls.Add(Me.ucrInputLabelColour)
        Me.Controls.Add(Me.ucrChkAddLabels)
        Me.Controls.Add(Me.rdoDonut)
        Me.Controls.Add(Me.rdoPie)
        Me.Controls.Add(Me.ucrChkPolarCoordinates)
        Me.Controls.Add(Me.ucrPnlPolar)
        Me.Controls.Add(Me.ucrChkBacktoback)
        Me.Controls.Add(Me.lblXvariable)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.ucrVariablesAsFactorForBarChart)
        Me.Controls.Add(Me.rdoFrequency)
        Me.Controls.Add(Me.ucrInputBarChartPositions)
        Me.Controls.Add(Me.cmdColumnChartOptions)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.ucrSaveBar)
        Me.Controls.Add(Me.ucrChkFlipCoordinates)
        Me.Controls.Add(Me.rdoValue)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblByFactor)
        Me.Controls.Add(Me.ucrReceiverByFactor)
        Me.Controls.Add(Me.ucrBarChartSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.cmdBarChartOptions)
        Me.Controls.Add(Me.cmdPieChartOptions)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgBarAndPieChart"
        Me.Tag = "Bar_and_Pie_Chart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrBarChartSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverByFactor As ucrReceiverSingle
    Friend WithEvents lblByFactor As Label
    Friend WithEvents cmdOptions As Button
    Friend WithEvents cmdPieChartOptions As Button
    Friend WithEvents ucrSaveBar As ucrSave
    Friend WithEvents ucrChkFlipCoordinates As ucrCheck
    Friend WithEvents rdoValue As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents cmdBarChartOptions As Button
    Friend WithEvents lblPosition As Label
    Friend WithEvents cmdColumnChartOptions As Button
    Friend WithEvents ucrInputBarChartPositions As ucrInputComboBox
    Friend WithEvents rdoFrequency As RadioButton
    Friend WithEvents ucrVariablesAsFactorForBarChart As ucrVariablesAsFactor
    Friend WithEvents lblXvariable As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents ucrChkBacktoback As ucrCheck
    Friend WithEvents ucrChkPolarCoordinates As ucrCheck
    Friend WithEvents ucrPnlPolar As UcrPanel
    Friend WithEvents rdoDonut As RadioButton
    Friend WithEvents rdoPie As RadioButton
    Friend WithEvents ucrChkAddLabels As ucrCheck
    Friend WithEvents lblLabelColour As Label
    Friend WithEvents lblLabelPosition As Label
    Friend WithEvents ucrInputLabelPosition As ucrInputComboBox
    Friend WithEvents ucrInputLabelColour As ucrInputComboBox
    Friend WithEvents lblLabelSize As Label
    Friend WithEvents ucrInputLabelSize As ucrInputComboBox
End Class