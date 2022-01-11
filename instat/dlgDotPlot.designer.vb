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
Partial Class dlgDotPlot
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdDotPlotOptions = New System.Windows.Forms.Button()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblOtherAxis = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.grpBinAxis = New System.Windows.Forms.GroupBox()
        Me.rdoYBinAxis = New System.Windows.Forms.RadioButton()
        Me.rdoXBinAxis = New System.Windows.Forms.RadioButton()
        Me.ucrPnlBinAxis = New instat.UcrPanel()
        Me.ucrSaveDotPlot = New instat.ucrSave()
        Me.ucrVariablesAsFactorDotPlot = New instat.ucrVariablesAsFactor()
        Me.ucrDotPlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrOtherAxisReceiver = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpBinAxis.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdDotPlotOptions
        '
        Me.cmdDotPlotOptions.Location = New System.Drawing.Point(10, 198)
        Me.cmdDotPlotOptions.Name = "cmdDotPlotOptions"
        Me.cmdDotPlotOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdDotPlotOptions.TabIndex = 6
        Me.cmdDotPlotOptions.Tag = "Dot_Plot_Options"
        Me.cmdDotPlotOptions.Text = "Dot Plot Options..."
        Me.cmdDotPlotOptions.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(10, 228)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdOptions.TabIndex = 7
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Plot Options..."
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblOtherAxis
        '
        Me.lblOtherAxis.AutoSize = True
        Me.lblOtherAxis.Location = New System.Drawing.Point(255, 198)
        Me.lblOtherAxis.Name = "lblOtherAxis"
        Me.lblOtherAxis.Size = New System.Drawing.Size(106, 13)
        Me.lblOtherAxis.TabIndex = 2
        Me.lblOtherAxis.Tag = "Other_Axis_(optional):"
        Me.lblOtherAxis.Text = "Other Axis (Optional):"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(255, 244)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(88, 13)
        Me.lblFactor.TabIndex = 4
        Me.lblFactor.Tag = "Factor_(optional):"
        Me.lblFactor.Text = "Factor (Optional):"
        '
        'grpBinAxis
        '
        Me.grpBinAxis.Controls.Add(Me.rdoYBinAxis)
        Me.grpBinAxis.Controls.Add(Me.rdoXBinAxis)
        Me.grpBinAxis.Controls.Add(Me.ucrPnlBinAxis)
        Me.grpBinAxis.Location = New System.Drawing.Point(10, 259)
        Me.grpBinAxis.Name = "grpBinAxis"
        Me.grpBinAxis.Size = New System.Drawing.Size(120, 66)
        Me.grpBinAxis.TabIndex = 8
        Me.grpBinAxis.TabStop = False
        Me.grpBinAxis.Tag = "Bin_Axis:"
        Me.grpBinAxis.Text = "Bin Axis:"
        '
        'rdoYBinAxis
        '
        Me.rdoYBinAxis.AutoSize = True
        Me.rdoYBinAxis.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYBinAxis.FlatAppearance.BorderSize = 2
        Me.rdoYBinAxis.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYBinAxis.Location = New System.Drawing.Point(8, 40)
        Me.rdoYBinAxis.Name = "rdoYBinAxis"
        Me.rdoYBinAxis.Size = New System.Drawing.Size(30, 17)
        Me.rdoYBinAxis.TabIndex = 1
        Me.rdoYBinAxis.TabStop = True
        Me.rdoYBinAxis.Text = "y"
        Me.rdoYBinAxis.UseVisualStyleBackColor = True
        '
        'rdoXBinAxis
        '
        Me.rdoXBinAxis.AutoSize = True
        Me.rdoXBinAxis.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoXBinAxis.FlatAppearance.BorderSize = 2
        Me.rdoXBinAxis.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoXBinAxis.Location = New System.Drawing.Point(8, 17)
        Me.rdoXBinAxis.Name = "rdoXBinAxis"
        Me.rdoXBinAxis.Size = New System.Drawing.Size(30, 17)
        Me.rdoXBinAxis.TabIndex = 0
        Me.rdoXBinAxis.TabStop = True
        Me.rdoXBinAxis.Text = "x"
        Me.rdoXBinAxis.UseVisualStyleBackColor = True
        '
        'ucrPnlBinAxis
        '
        Me.ucrPnlBinAxis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlBinAxis.Location = New System.Drawing.Point(6, 16)
        Me.ucrPnlBinAxis.Name = "ucrPnlBinAxis"
        Me.ucrPnlBinAxis.Size = New System.Drawing.Size(55, 44)
        Me.ucrPnlBinAxis.TabIndex = 11
        '
        'ucrSaveDotPlot
        '
        Me.ucrSaveDotPlot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveDotPlot.Location = New System.Drawing.Point(10, 331)
        Me.ucrSaveDotPlot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveDotPlot.Name = "ucrSaveDotPlot"
        Me.ucrSaveDotPlot.Size = New System.Drawing.Size(265, 24)
        Me.ucrSaveDotPlot.TabIndex = 9
        '
        'ucrVariablesAsFactorDotPlot
        '
        Me.ucrVariablesAsFactorDotPlot.AutoSize = True
        Me.ucrVariablesAsFactorDotPlot.frmParent = Me
        Me.ucrVariablesAsFactorDotPlot.Location = New System.Drawing.Point(255, 30)
        Me.ucrVariablesAsFactorDotPlot.Name = "ucrVariablesAsFactorDotPlot"
        Me.ucrVariablesAsFactorDotPlot.Selector = Nothing
        Me.ucrVariablesAsFactorDotPlot.Size = New System.Drawing.Size(125, 133)
        Me.ucrVariablesAsFactorDotPlot.strNcFilePath = ""
        Me.ucrVariablesAsFactorDotPlot.TabIndex = 1
        Me.ucrVariablesAsFactorDotPlot.ucrSelector = Nothing
        Me.ucrVariablesAsFactorDotPlot.ucrVariableSelector = Nothing
        '
        'ucrDotPlotSelector
        '
        Me.ucrDotPlotSelector.AutoSize = True
        Me.ucrDotPlotSelector.bDropUnusedFilterLevels = False
        Me.ucrDotPlotSelector.bShowHiddenColumns = False
        Me.ucrDotPlotSelector.bUseCurrentFilter = True
        Me.ucrDotPlotSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrDotPlotSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDotPlotSelector.Name = "ucrDotPlotSelector"
        Me.ucrDotPlotSelector.Size = New System.Drawing.Size(213, 183)
        Me.ucrDotPlotSelector.TabIndex = 0
        '
        'ucrFactorReceiver
        '
        Me.ucrFactorReceiver.AutoSize = True
        Me.ucrFactorReceiver.frmParent = Me
        Me.ucrFactorReceiver.Location = New System.Drawing.Point(255, 259)
        Me.ucrFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorReceiver.Name = "ucrFactorReceiver"
        Me.ucrFactorReceiver.Selector = Nothing
        Me.ucrFactorReceiver.Size = New System.Drawing.Size(125, 20)
        Me.ucrFactorReceiver.strNcFilePath = ""
        Me.ucrFactorReceiver.TabIndex = 5
        Me.ucrFactorReceiver.ucrSelector = Nothing
        '
        'ucrOtherAxisReceiver
        '
        Me.ucrOtherAxisReceiver.AutoSize = True
        Me.ucrOtherAxisReceiver.frmParent = Me
        Me.ucrOtherAxisReceiver.Location = New System.Drawing.Point(255, 213)
        Me.ucrOtherAxisReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrOtherAxisReceiver.Name = "ucrOtherAxisReceiver"
        Me.ucrOtherAxisReceiver.Selector = Nothing
        Me.ucrOtherAxisReceiver.Size = New System.Drawing.Size(125, 20)
        Me.ucrOtherAxisReceiver.strNcFilePath = ""
        Me.ucrOtherAxisReceiver.TabIndex = 3
        Me.ucrOtherAxisReceiver.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 361)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 10
        '
        'dlgDotPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(415, 419)
        Me.Controls.Add(Me.ucrSaveDotPlot)
        Me.Controls.Add(Me.grpBinAxis)
        Me.Controls.Add(Me.ucrVariablesAsFactorDotPlot)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.cmdDotPlotOptions)
        Me.Controls.Add(Me.ucrDotPlotSelector)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblOtherAxis)
        Me.Controls.Add(Me.ucrFactorReceiver)
        Me.Controls.Add(Me.ucrOtherAxisReceiver)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDotPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Dot_Plot"
        Me.Text = "Dot Plot"
        Me.grpBinAxis.ResumeLayout(False)
        Me.grpBinAxis.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDotPlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdDotPlotOptions As Button
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrOtherAxisReceiver As ucrReceiverSingle
    Friend WithEvents lblOtherAxis As Label
    Friend WithEvents ucrFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrVariablesAsFactorDotPlot As ucrVariablesAsFactor
    Friend WithEvents grpBinAxis As GroupBox
    Friend WithEvents rdoYBinAxis As RadioButton
    Friend WithEvents rdoXBinAxis As RadioButton
    Friend WithEvents ucrSaveDotPlot As ucrSave
    Friend WithEvents ucrPnlBinAxis As UcrPanel
End Class
