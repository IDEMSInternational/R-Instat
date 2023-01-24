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
Partial Class dlgScatterPlot
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
        Me.components = New System.ComponentModel.Container()
        Me.lblFactorOptional = New System.Windows.Forms.Label()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblSides = New System.Windows.Forms.Label()
        Me.contextMenuStripOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripMenuItemPlotOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemPointOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemRugOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemSmoothOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdOptions = New instat.ucrSplitButton()
        Me.ucrInputSides = New instat.ucrInputComboBox()
        Me.ucrNudSize = New instat.ucrNud()
        Me.ucrChkAddRugPlot = New instat.ucrCheck()
        Me.ucrReceiverLabel = New instat.ucrReceiverSingle()
        Me.ucrChkWithSE = New instat.ucrCheck()
        Me.ucrChkLineofBestFit = New instat.ucrCheck()
        Me.ucrSaveScatterPlot = New instat.ucrSave()
        Me.ucrSelectorForScatter = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrVariablesAsFactorForScatter = New instat.ucrVariablesAsFactor()
        Me.ucrFactorOptionalReceiver = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.contextMenuStripOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFactorOptional
        '
        Me.lblFactorOptional.AutoSize = True
        Me.lblFactorOptional.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactorOptional.Location = New System.Drawing.Point(334, 224)
        Me.lblFactorOptional.Name = "lblFactorOptional"
        Me.lblFactorOptional.Size = New System.Drawing.Size(111, 13)
        Me.lblFactorOptional.TabIndex = 4
        Me.lblFactorOptional.Tag = "By_Variable_Optional:"
        Me.lblFactorOptional.Text = "By Variable (Optional):"
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXVariable.Location = New System.Drawing.Point(334, 175)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(58, 13)
        Me.lblXVariable.TabIndex = 2
        Me.lblXVariable.Tag = "X_Variable:"
        Me.lblXVariable.Text = "X Variable:"
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVariable.Location = New System.Drawing.Point(334, 273)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(125, 13)
        Me.lblVariable.TabIndex = 6
        Me.lblVariable.Text = "Label Variable (Optional):"
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(127, 264)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(30, 13)
        Me.lblSize.TabIndex = 12
        Me.lblSize.Text = "Size:"
        '
        'lblSides
        '
        Me.lblSides.AutoSize = True
        Me.lblSides.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSides.Location = New System.Drawing.Point(205, 264)
        Me.lblSides.Name = "lblSides"
        Me.lblSides.Size = New System.Drawing.Size(36, 13)
        Me.lblSides.TabIndex = 14
        Me.lblSides.Text = "Sides:"
        '
        'contextMenuStripOptions
        '
        Me.contextMenuStripOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemPlotOptions, Me.toolStripMenuItemPointOptions, Me.toolStripMenuItemRugOptions, Me.toolStripMenuItemSmoothOptions})
        Me.contextMenuStripOptions.Name = "contextMenuStripOk"
        Me.contextMenuStripOptions.Size = New System.Drawing.Size(162, 92)
        '
        'toolStripMenuItemPlotOptions
        '
        Me.toolStripMenuItemPlotOptions.Name = "toolStripMenuItemPlotOptions"
        Me.toolStripMenuItemPlotOptions.Size = New System.Drawing.Size(161, 22)
        Me.toolStripMenuItemPlotOptions.Text = "Plot Options"
        '
        'toolStripMenuItemPointOptions
        '
        Me.toolStripMenuItemPointOptions.Name = "toolStripMenuItemPointOptions"
        Me.toolStripMenuItemPointOptions.Size = New System.Drawing.Size(161, 22)
        Me.toolStripMenuItemPointOptions.Text = "Point Options"
        '
        'toolStripMenuItemRugOptions
        '
        Me.toolStripMenuItemRugOptions.Name = "toolStripMenuItemRugOptions"
        Me.toolStripMenuItemRugOptions.Size = New System.Drawing.Size(161, 22)
        Me.toolStripMenuItemRugOptions.Text = "Rug Options"
        '
        'toolStripMenuItemSmoothOptions
        '
        Me.toolStripMenuItemSmoothOptions.Name = "toolStripMenuItemSmoothOptions"
        Me.toolStripMenuItemSmoothOptions.Size = New System.Drawing.Size(161, 22)
        Me.toolStripMenuItemSmoothOptions.Text = "Smooth Options"
        '
        'cmdOptions
        '
        Me.cmdOptions.AutoSize = True
        Me.cmdOptions.ContextMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.Location = New System.Drawing.Point(10, 198)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(149, 23)
        Me.cmdOptions.SplitMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.TabIndex = 8
        Me.cmdOptions.Tag = "Plot Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrInputSides
        '
        Me.ucrInputSides.AddQuotesIfUnrecognised = True
        Me.ucrInputSides.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSides.GetSetSelectedIndex = -1
        Me.ucrInputSides.IsReadOnly = False
        Me.ucrInputSides.Location = New System.Drawing.Point(239, 261)
        Me.ucrInputSides.Name = "ucrInputSides"
        Me.ucrInputSides.Size = New System.Drawing.Size(94, 21)
        Me.ucrInputSides.TabIndex = 15
        '
        'ucrNudSize
        '
        Me.ucrNudSize.AutoSize = True
        Me.ucrNudSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSize.Location = New System.Drawing.Point(157, 262)
        Me.ucrNudSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSize.Name = "ucrNudSize"
        Me.ucrNudSize.Size = New System.Drawing.Size(45, 20)
        Me.ucrNudSize.TabIndex = 13
        Me.ucrNudSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkAddRugPlot
        '
        Me.ucrChkAddRugPlot.AutoSize = True
        Me.ucrChkAddRugPlot.Checked = False
        Me.ucrChkAddRugPlot.Location = New System.Drawing.Point(11, 262)
        Me.ucrChkAddRugPlot.Name = "ucrChkAddRugPlot"
        Me.ucrChkAddRugPlot.Size = New System.Drawing.Size(134, 23)
        Me.ucrChkAddRugPlot.TabIndex = 11
        '
        'ucrReceiverLabel
        '
        Me.ucrReceiverLabel.AutoSize = True
        Me.ucrReceiverLabel.frmParent = Me
        Me.ucrReceiverLabel.Location = New System.Drawing.Point(334, 289)
        Me.ucrReceiverLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLabel.Name = "ucrReceiverLabel"
        Me.ucrReceiverLabel.Selector = Nothing
        Me.ucrReceiverLabel.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverLabel.strNcFilePath = ""
        Me.ucrReceiverLabel.TabIndex = 7
        Me.ucrReceiverLabel.ucrSelector = Nothing
        '
        'ucrChkWithSE
        '
        Me.ucrChkWithSE.AutoSize = True
        Me.ucrChkWithSE.Checked = False
        Me.ucrChkWithSE.Location = New System.Drawing.Point(189, 233)
        Me.ucrChkWithSE.Name = "ucrChkWithSE"
        Me.ucrChkWithSE.Size = New System.Drawing.Size(133, 23)
        Me.ucrChkWithSE.TabIndex = 10
        '
        'ucrChkLineofBestFit
        '
        Me.ucrChkLineofBestFit.AutoSize = True
        Me.ucrChkLineofBestFit.Checked = False
        Me.ucrChkLineofBestFit.Location = New System.Drawing.Point(11, 233)
        Me.ucrChkLineofBestFit.Name = "ucrChkLineofBestFit"
        Me.ucrChkLineofBestFit.Size = New System.Drawing.Size(173, 24)
        Me.ucrChkLineofBestFit.TabIndex = 9
        '
        'ucrSaveScatterPlot
        '
        Me.ucrSaveScatterPlot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveScatterPlot.Location = New System.Drawing.Point(10, 322)
        Me.ucrSaveScatterPlot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveScatterPlot.Name = "ucrSaveScatterPlot"
        Me.ucrSaveScatterPlot.Size = New System.Drawing.Size(312, 24)
        Me.ucrSaveScatterPlot.TabIndex = 16
        '
        'ucrSelectorForScatter
        '
        Me.ucrSelectorForScatter.AutoSize = True
        Me.ucrSelectorForScatter.bDropUnusedFilterLevels = False
        Me.ucrSelectorForScatter.bShowHiddenColumns = False
        Me.ucrSelectorForScatter.bUseCurrentFilter = True
        Me.ucrSelectorForScatter.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForScatter.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForScatter.Name = "ucrSelectorForScatter"
        Me.ucrSelectorForScatter.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForScatter.TabIndex = 0
        '
        'ucrVariablesAsFactorForScatter
        '
        Me.ucrVariablesAsFactorForScatter.AutoSize = True
        Me.ucrVariablesAsFactorForScatter.frmParent = Me
        Me.ucrVariablesAsFactorForScatter.Location = New System.Drawing.Point(334, 30)
        Me.ucrVariablesAsFactorForScatter.Name = "ucrVariablesAsFactorForScatter"
        Me.ucrVariablesAsFactorForScatter.Selector = Nothing
        Me.ucrVariablesAsFactorForScatter.Size = New System.Drawing.Size(125, 136)
        Me.ucrVariablesAsFactorForScatter.strNcFilePath = ""
        Me.ucrVariablesAsFactorForScatter.TabIndex = 1
        Me.ucrVariablesAsFactorForScatter.ucrSelector = Nothing
        Me.ucrVariablesAsFactorForScatter.ucrVariableSelector = Nothing
        '
        'ucrFactorOptionalReceiver
        '
        Me.ucrFactorOptionalReceiver.AutoSize = True
        Me.ucrFactorOptionalReceiver.frmParent = Me
        Me.ucrFactorOptionalReceiver.Location = New System.Drawing.Point(334, 237)
        Me.ucrFactorOptionalReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorOptionalReceiver.Name = "ucrFactorOptionalReceiver"
        Me.ucrFactorOptionalReceiver.Selector = Nothing
        Me.ucrFactorOptionalReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrFactorOptionalReceiver.strNcFilePath = ""
        Me.ucrFactorOptionalReceiver.TabIndex = 5
        Me.ucrFactorOptionalReceiver.ucrSelector = Nothing
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.AutoSize = True
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(334, 188)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 3
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 353)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 17
        '
        'dlgScatterPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(477, 412)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrInputSides)
        Me.Controls.Add(Me.lblSides)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.ucrNudSize)
        Me.Controls.Add(Me.ucrChkAddRugPlot)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.ucrReceiverLabel)
        Me.Controls.Add(Me.ucrChkWithSE)
        Me.Controls.Add(Me.ucrChkLineofBestFit)
        Me.Controls.Add(Me.ucrSaveScatterPlot)
        Me.Controls.Add(Me.ucrSelectorForScatter)
        Me.Controls.Add(Me.ucrVariablesAsFactorForScatter)
        Me.Controls.Add(Me.ucrFactorOptionalReceiver)
        Me.Controls.Add(Me.lblFactorOptional)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgScatterPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Point Plot"
        Me.contextMenuStripOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrFactorOptionalReceiver As ucrReceiverSingle
    Friend WithEvents lblFactorOptional As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents lblXVariable As Label
    Friend WithEvents ucrVariablesAsFactorForScatter As ucrVariablesAsFactor
    Friend WithEvents ucrSelectorForScatter As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSaveScatterPlot As ucrSave
    Friend WithEvents ucrChkLineofBestFit As ucrCheck
    Friend WithEvents ucrChkWithSE As ucrCheck
    Friend WithEvents lblVariable As Label
    Friend WithEvents ucrReceiverLabel As ucrReceiverSingle
    Friend WithEvents ucrChkAddRugPlot As ucrCheck
    Friend WithEvents lblSize As Label
    Friend WithEvents ucrNudSize As ucrNud
    Friend WithEvents lblSides As Label
    Friend WithEvents ucrInputSides As ucrInputComboBox
    Friend WithEvents cmdOptions As ucrSplitButton
    Friend WithEvents contextMenuStripOptions As ContextMenuStrip
    Friend WithEvents toolStripMenuItemPlotOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemPointOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemRugOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemSmoothOptions As ToolStripMenuItem
End Class
