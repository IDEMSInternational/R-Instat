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
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.lblSecondFactor = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.cmdPieChartOptions = New System.Windows.Forms.Button()
        Me.rdoPieChart = New System.Windows.Forms.RadioButton()
        Me.rdoBarChart = New System.Windows.Forms.RadioButton()
        Me.ucrSaveBar = New instat.ucrSave()
        Me.ucrChkFlipCoordinates = New instat.ucrCheck()
        Me.ucrSecondReceiver = New instat.ucrReceiverSingle()
        Me.ucrFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrBarChartSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.cmdBarChartOptions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(255, 76)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(40, 13)
        Me.lblFactor.TabIndex = 4
        Me.lblFactor.Tag = "Factor:"
        Me.lblFactor.Text = "Factor:"
        '
        'lblSecondFactor
        '
        Me.lblSecondFactor.AutoSize = True
        Me.lblSecondFactor.Location = New System.Drawing.Point(255, 126)
        Me.lblSecondFactor.Name = "lblSecondFactor"
        Me.lblSecondFactor.Size = New System.Drawing.Size(128, 13)
        Me.lblSecondFactor.TabIndex = 6
        Me.lblSecondFactor.Tag = "Second_Factor:"
        Me.lblSecondFactor.Text = "Second Factor (Optional):"
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(10, 262)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(121, 25)
        Me.cmdOptions.TabIndex = 10
        Me.cmdOptions.Tag = "Plot_Options..."
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'cmdPieChartOptions
        '
        Me.cmdPieChartOptions.Location = New System.Drawing.Point(10, 231)
        Me.cmdPieChartOptions.Name = "cmdPieChartOptions"
        Me.cmdPieChartOptions.Size = New System.Drawing.Size(121, 25)
        Me.cmdPieChartOptions.TabIndex = 8
        Me.cmdPieChartOptions.Tag = "Pie_Chart_Options"
        Me.cmdPieChartOptions.Text = "Pie Chart Options"
        Me.cmdPieChartOptions.UseVisualStyleBackColor = True
        '
        'rdoPieChart
        '
        Me.rdoPieChart.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPieChart.BackColor = System.Drawing.SystemColors.Control
        Me.rdoPieChart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPieChart.FlatAppearance.BorderSize = 2
        Me.rdoPieChart.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPieChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPieChart.Location = New System.Drawing.Point(215, 12)
        Me.rdoPieChart.Name = "rdoPieChart"
        Me.rdoPieChart.Size = New System.Drawing.Size(100, 28)
        Me.rdoPieChart.TabIndex = 2
        Me.rdoPieChart.TabStop = True
        Me.rdoPieChart.Tag = "Pie_Chart"
        Me.rdoPieChart.Text = "Pie Chart"
        Me.rdoPieChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPieChart.UseVisualStyleBackColor = False
        '
        'rdoBarChart
        '
        Me.rdoBarChart.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoBarChart.BackColor = System.Drawing.SystemColors.Control
        Me.rdoBarChart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBarChart.FlatAppearance.BorderSize = 2
        Me.rdoBarChart.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBarChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoBarChart.Location = New System.Drawing.Point(117, 12)
        Me.rdoBarChart.Name = "rdoBarChart"
        Me.rdoBarChart.Size = New System.Drawing.Size(100, 28)
        Me.rdoBarChart.TabIndex = 1
        Me.rdoBarChart.TabStop = True
        Me.rdoBarChart.Tag = "Bar_Chart"
        Me.rdoBarChart.Text = "Bar Chart"
        Me.rdoBarChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoBarChart.UseVisualStyleBackColor = False
        '
        'ucrSaveBar
        '
        Me.ucrSaveBar.Location = New System.Drawing.Point(10, 319)
        Me.ucrSaveBar.Name = "ucrSaveBar"
        Me.ucrSaveBar.Size = New System.Drawing.Size(313, 24)
        Me.ucrSaveBar.TabIndex = 12
        '
        'ucrChkFlipCoordinates
        '
        Me.ucrChkFlipCoordinates.Checked = False
        Me.ucrChkFlipCoordinates.Location = New System.Drawing.Point(10, 293)
        Me.ucrChkFlipCoordinates.Name = "ucrChkFlipCoordinates"
        Me.ucrChkFlipCoordinates.Size = New System.Drawing.Size(166, 20)
        Me.ucrChkFlipCoordinates.TabIndex = 11
        '
        'ucrSecondReceiver
        '
        Me.ucrSecondReceiver.frmParent = Me
        Me.ucrSecondReceiver.Location = New System.Drawing.Point(255, 141)
        Me.ucrSecondReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSecondReceiver.Name = "ucrSecondReceiver"
        Me.ucrSecondReceiver.Selector = Nothing
        Me.ucrSecondReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrSecondReceiver.strNcFilePath = ""
        Me.ucrSecondReceiver.TabIndex = 7
        Me.ucrSecondReceiver.ucrSelector = Nothing
        '
        'ucrFactorReceiver
        '
        Me.ucrFactorReceiver.frmParent = Me
        Me.ucrFactorReceiver.Location = New System.Drawing.Point(255, 91)
        Me.ucrFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorReceiver.Name = "ucrFactorReceiver"
        Me.ucrFactorReceiver.Selector = Nothing
        Me.ucrFactorReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrFactorReceiver.strNcFilePath = ""
        Me.ucrFactorReceiver.TabIndex = 5
        Me.ucrFactorReceiver.ucrSelector = Nothing
        '
        'ucrBarChartSelector
        '
        Me.ucrBarChartSelector.bShowHiddenColumns = False
        Me.ucrBarChartSelector.bUseCurrentFilter = True
        Me.ucrBarChartSelector.Location = New System.Drawing.Point(10, 41)
        Me.ucrBarChartSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrBarChartSelector.Name = "ucrBarChartSelector"
        Me.ucrBarChartSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrBarChartSelector.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 345)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 13
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.Location = New System.Drawing.Point(107, 6)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(211, 36)
        Me.ucrPnlOptions.TabIndex = 0
        '
        'cmdBarChartOptions
        '
        Me.cmdBarChartOptions.Location = New System.Drawing.Point(10, 231)
        Me.cmdBarChartOptions.Name = "cmdBarChartOptions"
        Me.cmdBarChartOptions.Size = New System.Drawing.Size(121, 25)
        Me.cmdBarChartOptions.TabIndex = 9
        Me.cmdBarChartOptions.Tag = "Bar_Chart_Options"
        Me.cmdBarChartOptions.Text = "Bar Chart Options"
        Me.cmdBarChartOptions.UseVisualStyleBackColor = True
        '
        'dlgBarAndPieChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 404)
        Me.Controls.Add(Me.ucrSaveBar)
        Me.Controls.Add(Me.ucrChkFlipCoordinates)
        Me.Controls.Add(Me.rdoBarChart)
        Me.Controls.Add(Me.rdoPieChart)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblSecondFactor)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrSecondReceiver)
        Me.Controls.Add(Me.ucrFactorReceiver)
        Me.Controls.Add(Me.ucrBarChartSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.cmdBarChartOptions)
        Me.Controls.Add(Me.cmdPieChartOptions)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgBarAndPieChart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Bar_And_Pie_Chart"
        Me.Text = "Bar and Pie Chart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrBarChartSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrFactorReceiver As ucrReceiverSingle
    Friend WithEvents ucrSecondReceiver As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
    Friend WithEvents lblSecondFactor As Label
    Friend WithEvents cmdOptions As Button
    Friend WithEvents cmdPieChartOptions As Button
    Friend WithEvents ucrSaveBar As ucrSave
    Friend WithEvents ucrChkFlipCoordinates As ucrCheck
    Friend WithEvents rdoBarChart As RadioButton
    Friend WithEvents rdoPieChart As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents cmdBarChartOptions As Button
End Class