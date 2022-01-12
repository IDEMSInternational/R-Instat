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
        Me.ucrChkLabel = New instat.ucrCheck()
        Me.ucrSaveSummaryBar = New instat.ucrSave()
        Me.ucrReceiverSecondFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverYVariable = New instat.ucrReceiverSingle()
        Me.ucrSummaryBarSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrInputBarChartPosition = New instat.ucrInputComboBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblYvariable
        '
        Me.lblYvariable.AutoSize = True
        Me.lblYvariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYvariable.Location = New System.Drawing.Point(259, 60)
        Me.lblYvariable.Name = "lblYvariable"
        Me.lblYvariable.Size = New System.Drawing.Size(58, 13)
        Me.lblYvariable.TabIndex = 5
        Me.lblYvariable.Tag = "Y_Variable:"
        Me.lblYvariable.Text = "Y Variable:"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactor.Location = New System.Drawing.Point(259, 103)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(40, 13)
        Me.lblFactor.TabIndex = 7
        Me.lblFactor.Tag = "Factor:"
        Me.lblFactor.Text = "Factor:"
        '
        'cmdBarChartOptions
        '
        Me.cmdBarChartOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBarChartOptions.Location = New System.Drawing.Point(10, 228)
        Me.cmdBarChartOptions.Name = "cmdBarChartOptions"
        Me.cmdBarChartOptions.Size = New System.Drawing.Size(149, 23)
        Me.cmdBarChartOptions.TabIndex = 8
        Me.cmdBarChartOptions.Tag = "Bar_Chart_Options"
        Me.cmdBarChartOptions.Text = "Bar Options"
        Me.cmdBarChartOptions.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(10, 257)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(149, 23)
        Me.cmdOptions.TabIndex = 15
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblSecondFactor
        '
        Me.lblSecondFactor.AutoSize = True
        Me.lblSecondFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondFactor.Location = New System.Drawing.Point(259, 146)
        Me.lblSecondFactor.Name = "lblSecondFactor"
        Me.lblSecondFactor.Size = New System.Drawing.Size(80, 13)
        Me.lblSecondFactor.TabIndex = 9
        Me.lblSecondFactor.Tag = "Second+Factor:"
        Me.lblSecondFactor.Text = "Second Factor:"
        '
        'cmdPieChartOptions
        '
        Me.cmdPieChartOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPieChartOptions.Location = New System.Drawing.Point(10, 228)
        Me.cmdPieChartOptions.Name = "cmdPieChartOptions"
        Me.cmdPieChartOptions.Size = New System.Drawing.Size(149, 23)
        Me.cmdPieChartOptions.TabIndex = 14
        Me.cmdPieChartOptions.Tag = "Pie_Chart_Options"
        Me.cmdPieChartOptions.Text = "Pie Options"
        Me.cmdPieChartOptions.UseVisualStyleBackColor = True
        '
        'rdoBarChart
        '
        Me.rdoBarChart.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoBarChart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBarChart.FlatAppearance.BorderSize = 2
        Me.rdoBarChart.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBarChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoBarChart.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBarChart.Location = New System.Drawing.Point(38, 10)
        Me.rdoBarChart.Name = "rdoBarChart"
        Me.rdoBarChart.Size = New System.Drawing.Size(121, 27)
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
        Me.rdoPieChart.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPieChart.Location = New System.Drawing.Point(157, 10)
        Me.rdoPieChart.Name = "rdoPieChart"
        Me.rdoPieChart.Size = New System.Drawing.Size(127, 27)
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
        Me.rdoTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTable.Location = New System.Drawing.Point(280, 10)
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.Size = New System.Drawing.Size(99, 27)
        Me.rdoTable.TabIndex = 3
        Me.rdoTable.TabStop = True
        Me.rdoTable.Text = "Tables"
        Me.rdoTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTable.UseVisualStyleBackColor = True
        '
        'ucrChkLabel
        '
        Me.ucrChkLabel.AutoSize = True
        Me.ucrChkLabel.Checked = False
        Me.ucrChkLabel.Location = New System.Drawing.Point(259, 242)
        Me.ucrChkLabel.Name = "ucrChkLabel"
        Me.ucrChkLabel.Size = New System.Drawing.Size(82, 23)
        Me.ucrChkLabel.TabIndex = 13
        '
        'ucrSaveSummaryBar
        '
        Me.ucrSaveSummaryBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveSummaryBar.Location = New System.Drawing.Point(10, 290)
        Me.ucrSaveSummaryBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveSummaryBar.Name = "ucrSaveSummaryBar"
        Me.ucrSaveSummaryBar.Size = New System.Drawing.Size(329, 24)
        Me.ucrSaveSummaryBar.TabIndex = 16
        '
        'ucrReceiverSecondFactor
        '
        Me.ucrReceiverSecondFactor.AutoSize = True
        Me.ucrReceiverSecondFactor.frmParent = Me
        Me.ucrReceiverSecondFactor.Location = New System.Drawing.Point(259, 161)
        Me.ucrReceiverSecondFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondFactor.Name = "ucrReceiverSecondFactor"
        Me.ucrReceiverSecondFactor.Selector = Nothing
        Me.ucrReceiverSecondFactor.Size = New System.Drawing.Size(120, 21)
        Me.ucrReceiverSecondFactor.strNcFilePath = ""
        Me.ucrReceiverSecondFactor.TabIndex = 10
        Me.ucrReceiverSecondFactor.ucrSelector = Nothing
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.AutoSize = True
        Me.ucrReceiverFactor.frmParent = Me
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(259, 118)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(120, 21)
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.TabIndex = 8
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'ucrReceiverYVariable
        '
        Me.ucrReceiverYVariable.AutoSize = True
        Me.ucrReceiverYVariable.frmParent = Me
        Me.ucrReceiverYVariable.Location = New System.Drawing.Point(259, 75)
        Me.ucrReceiverYVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYVariable.Name = "ucrReceiverYVariable"
        Me.ucrReceiverYVariable.Selector = Nothing
        Me.ucrReceiverYVariable.Size = New System.Drawing.Size(120, 21)
        Me.ucrReceiverYVariable.strNcFilePath = ""
        Me.ucrReceiverYVariable.TabIndex = 6
        Me.ucrReceiverYVariable.ucrSelector = Nothing
        '
        'ucrSummaryBarSelector
        '
        Me.ucrSummaryBarSelector.AutoSize = True
        Me.ucrSummaryBarSelector.bDropUnusedFilterLevels = False
        Me.ucrSummaryBarSelector.bShowHiddenColumns = False
        Me.ucrSummaryBarSelector.bUseCurrentFilter = True
        Me.ucrSummaryBarSelector.Location = New System.Drawing.Point(10, 40)
        Me.ucrSummaryBarSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSummaryBarSelector.Name = "ucrSummaryBarSelector"
        Me.ucrSummaryBarSelector.Size = New System.Drawing.Size(242, 185)
        Me.ucrSummaryBarSelector.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(12, 322)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 17
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(38, 3)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(349, 35)
        Me.ucrPnlOptions.TabIndex = 0
        '
        'ucrInputBarChartPosition
        '
        Me.ucrInputBarChartPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputBarChartPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputBarChartPosition.GetSetSelectedIndex = -1
        Me.ucrInputBarChartPosition.IsReadOnly = False
        Me.ucrInputBarChartPosition.Location = New System.Drawing.Point(259, 210)
        Me.ucrInputBarChartPosition.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputBarChartPosition.Name = "ucrInputBarChartPosition"
        Me.ucrInputBarChartPosition.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputBarChartPosition.TabIndex = 12
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPosition.Location = New System.Drawing.Point(259, 195)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(45, 13)
        Me.lblPosition.TabIndex = 11
        Me.lblPosition.Tag = "Position:"
        Me.lblPosition.Text = "Postion:"
        '
        'dlgSummaryBarOrPieChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(425, 380)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.ucrInputBarChartPosition)
        Me.Controls.Add(Me.ucrChkLabel)
        Me.Controls.Add(Me.rdoTable)
        Me.Controls.Add(Me.rdoPieChart)
        Me.Controls.Add(Me.ucrSaveSummaryBar)
        Me.Controls.Add(Me.rdoBarChart)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblSecondFactor)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrReceiverSecondFactor)
        Me.Controls.Add(Me.lblYvariable)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.ucrReceiverYVariable)
        Me.Controls.Add(Me.ucrSummaryBarSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.cmdBarChartOptions)
        Me.Controls.Add(Me.cmdPieChartOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSummaryBarOrPieChart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Use Summaries"
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
    Friend WithEvents ucrChkLabel As ucrCheck
    Friend WithEvents lblPosition As Label
    Friend WithEvents ucrInputBarChartPosition As ucrInputComboBox
End Class
