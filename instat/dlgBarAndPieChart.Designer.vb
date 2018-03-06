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
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.lblByFactor = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.cmdPieChartOptions = New System.Windows.Forms.Button()
        Me.rdoPieChart = New System.Windows.Forms.RadioButton()
        Me.rdoBarChart = New System.Windows.Forms.RadioButton()
        Me.cmdBarChartOptions = New System.Windows.Forms.Button()
        Me.ucrSaveBar = New instat.ucrSave()
        Me.ucrChkFlipCoordinates = New instat.ucrCheck()
        Me.ucrReceiverByFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirst = New instat.ucrReceiverSingle()
        Me.ucrBarChartSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'lblVariable
        '
        resources.ApplyResources(Me.lblVariable, "lblVariable")
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Tag = "Variable:"
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
        'rdoPieChart
        '
        resources.ApplyResources(Me.rdoPieChart, "rdoPieChart")
        Me.rdoPieChart.BackColor = System.Drawing.SystemColors.Control
        Me.rdoPieChart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPieChart.FlatAppearance.BorderSize = 2
        Me.rdoPieChart.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPieChart.Name = "rdoPieChart"
        Me.rdoPieChart.TabStop = True
        Me.rdoPieChart.Tag = "Pie_Chart"
        Me.rdoPieChart.UseVisualStyleBackColor = False
        '
        'rdoBarChart
        '
        resources.ApplyResources(Me.rdoBarChart, "rdoBarChart")
        Me.rdoBarChart.BackColor = System.Drawing.SystemColors.Control
        Me.rdoBarChart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBarChart.FlatAppearance.BorderSize = 2
        Me.rdoBarChart.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBarChart.Name = "rdoBarChart"
        Me.rdoBarChart.TabStop = True
        Me.rdoBarChart.Tag = "Bar_Chart"
        Me.rdoBarChart.UseVisualStyleBackColor = False
        '
        'cmdBarChartOptions
        '
        resources.ApplyResources(Me.cmdBarChartOptions, "cmdBarChartOptions")
        Me.cmdBarChartOptions.Name = "cmdBarChartOptions"
        Me.cmdBarChartOptions.Tag = "Bar_Chart_Options"
        Me.cmdBarChartOptions.UseVisualStyleBackColor = True
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
        'ucrReceiverFirst
        '
        Me.ucrReceiverFirst.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFirst, "ucrReceiverFirst")
        Me.ucrReceiverFirst.Name = "ucrReceiverFirst"
        Me.ucrReceiverFirst.Selector = Nothing
        Me.ucrReceiverFirst.strNcFilePath = ""
        Me.ucrReceiverFirst.ucrSelector = Nothing
        '
        'ucrBarChartSelector
        '
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
        'dlgBarAndPieChart
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveBar)
        Me.Controls.Add(Me.ucrChkFlipCoordinates)
        Me.Controls.Add(Me.rdoBarChart)
        Me.Controls.Add(Me.rdoPieChart)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblByFactor)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.ucrReceiverByFactor)
        Me.Controls.Add(Me.ucrReceiverFirst)
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
    Friend WithEvents ucrReceiverFirst As ucrReceiverSingle
    Friend WithEvents ucrReceiverByFactor As ucrReceiverSingle
    Friend WithEvents lblVariable As Label
    Friend WithEvents lblByFactor As Label
    Friend WithEvents cmdOptions As Button
    Friend WithEvents cmdPieChartOptions As Button
    Friend WithEvents ucrSaveBar As ucrSave
    Friend WithEvents ucrChkFlipCoordinates As ucrCheck
    Friend WithEvents rdoBarChart As RadioButton
    Friend WithEvents rdoPieChart As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents cmdBarChartOptions As Button
End Class