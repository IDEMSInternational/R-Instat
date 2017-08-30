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
        Me.lblYvariable.AutoSize = True
        Me.lblYvariable.Location = New System.Drawing.Point(253, 75)
        Me.lblYvariable.Name = "lblYvariable"
        Me.lblYvariable.Size = New System.Drawing.Size(58, 13)
        Me.lblYvariable.TabIndex = 5
        Me.lblYvariable.Tag = "Y_Variable:"
        Me.lblYvariable.Text = "Y Variable:"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(253, 121)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(40, 13)
        Me.lblFactor.TabIndex = 7
        Me.lblFactor.Tag = "Factor:"
        Me.lblFactor.Text = "Factor:"
        '
        'cmdBarChartOptions
        '
        Me.cmdBarChartOptions.Location = New System.Drawing.Point(10, 228)
        Me.cmdBarChartOptions.Name = "cmdBarChartOptions"
        Me.cmdBarChartOptions.Size = New System.Drawing.Size(121, 23)
        Me.cmdBarChartOptions.TabIndex = 8
        Me.cmdBarChartOptions.Tag = "Bar_Chart_Options"
        Me.cmdBarChartOptions.Text = "Bar Chart Options"
        Me.cmdBarChartOptions.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(10, 257)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(121, 23)
        Me.cmdOptions.TabIndex = 12
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblSecondFactor
        '
        Me.lblSecondFactor.AutoSize = True
        Me.lblSecondFactor.Location = New System.Drawing.Point(253, 168)
        Me.lblSecondFactor.Name = "lblSecondFactor"
        Me.lblSecondFactor.Size = New System.Drawing.Size(80, 13)
        Me.lblSecondFactor.TabIndex = 9
        Me.lblSecondFactor.Tag = "Second+Factor:"
        Me.lblSecondFactor.Text = "Second Factor:"
        '
        'cmdPieChartOptions
        '
        Me.cmdPieChartOptions.Location = New System.Drawing.Point(10, 228)
        Me.cmdPieChartOptions.Name = "cmdPieChartOptions"
        Me.cmdPieChartOptions.Size = New System.Drawing.Size(121, 23)
        Me.cmdPieChartOptions.TabIndex = 11
        Me.cmdPieChartOptions.Tag = "Pie_Chart_Options"
        Me.cmdPieChartOptions.Text = "Pie Chart Options"
        Me.cmdPieChartOptions.UseVisualStyleBackColor = True
        '
        'rdoBarChart
        '
        Me.rdoBarChart.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoBarChart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBarChart.FlatAppearance.BorderSize = 2
        Me.rdoBarChart.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBarChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoBarChart.Location = New System.Drawing.Point(67, 10)
        Me.rdoBarChart.Name = "rdoBarChart"
        Me.rdoBarChart.Size = New System.Drawing.Size(100, 27)
        Me.rdoBarChart.TabIndex = 1
        Me.rdoBarChart.TabStop = True
        Me.rdoBarChart.Tag = "Bar_Chart"
        Me.rdoBarChart.Text = "Bar Chart"
        Me.rdoBarChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoBarChart.UseVisualStyleBackColor = True
        '
        'rdoPieChart
        '
        Me.rdoPieChart.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPieChart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPieChart.FlatAppearance.BorderSize = 2
        Me.rdoPieChart.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPieChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPieChart.Location = New System.Drawing.Point(165, 10)
        Me.rdoPieChart.Name = "rdoPieChart"
        Me.rdoPieChart.Size = New System.Drawing.Size(100, 27)
        Me.rdoPieChart.TabIndex = 2
        Me.rdoPieChart.TabStop = True
        Me.rdoPieChart.Text = "Pie Chart"
        Me.rdoPieChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPieChart.UseVisualStyleBackColor = True
        '
        'rdoTable
        '
        Me.rdoTable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTable.Enabled = False
        Me.rdoTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatAppearance.BorderSize = 2
        Me.rdoTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTable.Location = New System.Drawing.Point(261, 10)
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.Size = New System.Drawing.Size(100, 27)
        Me.rdoTable.TabIndex = 3
        Me.rdoTable.TabStop = True
        Me.rdoTable.Text = "Tables"
        Me.rdoTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTable.UseVisualStyleBackColor = True
        '
        'ucrSaveSummaryBar
        '
        Me.ucrSaveSummaryBar.Location = New System.Drawing.Point(10, 288)
        Me.ucrSaveSummaryBar.Name = "ucrSaveSummaryBar"
        Me.ucrSaveSummaryBar.Size = New System.Drawing.Size(255, 24)
        Me.ucrSaveSummaryBar.TabIndex = 13
        '
        'ucrReceiverSecondFactor
        '
        Me.ucrReceiverSecondFactor.frmParent = Me
        Me.ucrReceiverSecondFactor.Location = New System.Drawing.Point(252, 183)
        Me.ucrReceiverSecondFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondFactor.Name = "ucrReceiverSecondFactor"
        Me.ucrReceiverSecondFactor.Selector = Nothing
        Me.ucrReceiverSecondFactor.Size = New System.Drawing.Size(120, 26)
        Me.ucrReceiverSecondFactor.strNcFilePath = ""
        Me.ucrReceiverSecondFactor.TabIndex = 10
        Me.ucrReceiverSecondFactor.ucrSelector = Nothing
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.frmParent = Me
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(252, 136)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.TabIndex = 8
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'ucrReceiverYVariable
        '
        Me.ucrReceiverYVariable.frmParent = Me
        Me.ucrReceiverYVariable.Location = New System.Drawing.Point(252, 90)
        Me.ucrReceiverYVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYVariable.Name = "ucrReceiverYVariable"
        Me.ucrReceiverYVariable.Selector = Nothing
        Me.ucrReceiverYVariable.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYVariable.strNcFilePath = ""
        Me.ucrReceiverYVariable.TabIndex = 6
        Me.ucrReceiverYVariable.ucrSelector = Nothing
        '
        'ucrSummaryBarSelector
        '
        Me.ucrSummaryBarSelector.bShowHiddenColumns = False
        Me.ucrSummaryBarSelector.bUseCurrentFilter = True
        Me.ucrSummaryBarSelector.Location = New System.Drawing.Point(10, 40)
        Me.ucrSummaryBarSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSummaryBarSelector.Name = "ucrSummaryBarSelector"
        Me.ucrSummaryBarSelector.Size = New System.Drawing.Size(242, 192)
        Me.ucrSummaryBarSelector.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 316)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 14
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.Location = New System.Drawing.Point(54, 3)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(307, 35)
        Me.ucrPnlOptions.TabIndex = 0
        '
        'dlgSummaryBarOrPieChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 371)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Bar_or_Pie_Chart_From_Summary"
        Me.Text = "Bar or Pie Chart From Summary"
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
