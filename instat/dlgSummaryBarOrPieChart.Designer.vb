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
Partial Class dlgSummaryBarOrPieChart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgSummaryBarOrPieChart))
        Me.lblYvariable = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.cmdBarChartOptions = New System.Windows.Forms.Button()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblSecondFactor = New System.Windows.Forms.Label()
        Me.cmdPieChartOptions = New System.Windows.Forms.Button()
        Me.rdoBarChart = New System.Windows.Forms.RadioButton()
        Me.rdoPieChart = New System.Windows.Forms.RadioButton()
        Me.rdoTable = New System.Windows.Forms.RadioButton()
        Me.ucrSaveSummaryBar = New instat.ucrSave()
        Me.ucrReceiverSecondFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverYVariable = New instat.ucrReceiverSingle()
        Me.ucrSummaryBarSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'lblYvariable
        '
        resources.ApplyResources(Me.lblYvariable, "lblYvariable")
        Me.lblYvariable.Name = "lblYvariable"
        Me.lblYvariable.Tag = "Y_Variable:"
        '
        'lblFactor
        '
        resources.ApplyResources(Me.lblFactor, "lblFactor")
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Tag = "Factor:"
        '
        'cmdBarChartOptions
        '
        resources.ApplyResources(Me.cmdBarChartOptions, "cmdBarChartOptions")
        Me.cmdBarChartOptions.Name = "cmdBarChartOptions"
        Me.cmdBarChartOptions.Tag = "Bar_Chart_Options"
        Me.cmdBarChartOptions.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblSecondFactor
        '
        resources.ApplyResources(Me.lblSecondFactor, "lblSecondFactor")
        Me.lblSecondFactor.Name = "lblSecondFactor"
        Me.lblSecondFactor.Tag = "Second+Factor:"
        '
        'cmdPieChartOptions
        '
        resources.ApplyResources(Me.cmdPieChartOptions, "cmdPieChartOptions")
        Me.cmdPieChartOptions.Name = "cmdPieChartOptions"
        Me.cmdPieChartOptions.Tag = "Pie_Chart_Options"
        Me.cmdPieChartOptions.UseVisualStyleBackColor = True
        '
        'rdoBarChart
        '
        resources.ApplyResources(Me.rdoBarChart, "rdoBarChart")
        Me.rdoBarChart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBarChart.FlatAppearance.BorderSize = 2
        Me.rdoBarChart.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBarChart.Name = "rdoBarChart"
        Me.rdoBarChart.TabStop = True
        Me.rdoBarChart.Tag = "Bar_Chart"
        Me.rdoBarChart.UseVisualStyleBackColor = True
        '
        'rdoPieChart
        '
        resources.ApplyResources(Me.rdoPieChart, "rdoPieChart")
        Me.rdoPieChart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPieChart.FlatAppearance.BorderSize = 2
        Me.rdoPieChart.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPieChart.Name = "rdoPieChart"
        Me.rdoPieChart.TabStop = True
        Me.rdoPieChart.UseVisualStyleBackColor = True
        '
        'rdoTable
        '
        resources.ApplyResources(Me.rdoTable, "rdoTable")
        Me.rdoTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatAppearance.BorderSize = 2
        Me.rdoTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.TabStop = True
        Me.rdoTable.UseVisualStyleBackColor = True
        '
        'ucrSaveSummaryBar
        '
        resources.ApplyResources(Me.ucrSaveSummaryBar, "ucrSaveSummaryBar")
        Me.ucrSaveSummaryBar.Name = "ucrSaveSummaryBar"
        '
        'ucrReceiverSecondFactor
        '
        Me.ucrReceiverSecondFactor.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSecondFactor, "ucrReceiverSecondFactor")
        Me.ucrReceiverSecondFactor.Name = "ucrReceiverSecondFactor"
        Me.ucrReceiverSecondFactor.Selector = Nothing
        Me.ucrReceiverSecondFactor.strNcFilePath = ""
        Me.ucrReceiverSecondFactor.ucrSelector = Nothing
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFactor, "ucrReceiverFactor")
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'ucrReceiverYVariable
        '
        Me.ucrReceiverYVariable.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverYVariable, "ucrReceiverYVariable")
        Me.ucrReceiverYVariable.Name = "ucrReceiverYVariable"
        Me.ucrReceiverYVariable.Selector = Nothing
        Me.ucrReceiverYVariable.strNcFilePath = ""
        Me.ucrReceiverYVariable.ucrSelector = Nothing
        '
        'ucrSummaryBarSelector
        '
        Me.ucrSummaryBarSelector.bShowHiddenColumns = False
        Me.ucrSummaryBarSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSummaryBarSelector, "ucrSummaryBarSelector")
        Me.ucrSummaryBarSelector.Name = "ucrSummaryBarSelector"
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
        'dlgSummaryBarOrPieChart
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rdoTable)
        Me.Controls.Add(Me.rdoPieChart)
        Me.Controls.Add(Me.ucrSaveSummaryBar)
        Me.Controls.Add(Me.rdoBarChart)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.cmdPieChartOptions)
        Me.Controls.Add(Me.cmdBarChartOptions)
        Me.Controls.Add(Me.lblSecondFactor)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrReceiverSecondFactor)
        Me.Controls.Add(Me.lblYvariable)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.ucrReceiverYVariable)
        Me.Controls.Add(Me.ucrSummaryBarSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSummaryBarOrPieChart"
        Me.Tag = ""
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSummaryBarSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverYVariable As ucrReceiverSingle
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
    Friend WithEvents lblYvariable As Label
    Friend WithEvents lblFactor As Label
    Friend WithEvents cmdBarChartOptions As Button
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrReceiverSecondFactor As ucrReceiverSingle
    Friend WithEvents lblSecondFactor As Label
    Friend WithEvents cmdPieChartOptions As Button
    Friend WithEvents rdoPieChart As RadioButton
    Friend WithEvents ucrSaveSummaryBar As ucrSave
    Friend WithEvents rdoBarChart As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents rdoTable As RadioButton
End Class
