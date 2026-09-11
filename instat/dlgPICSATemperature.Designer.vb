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
Partial Class dlgPICSATemperature
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorPICSATemperature = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputStation = New instat.ucrInputComboBox()
        Me.ucrReceiverFacetBy = New instat.ucrReceiverSingle()
        Me.lblFacetBy = New System.Windows.Forms.Label()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrReceiverColourBy = New instat.ucrReceiverSingle()
        Me.lblFactorOptional = New System.Windows.Forms.Label()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.ucrChkWithSE = New instat.ucrCheck()
        Me.ucrChkLineofBestFit = New instat.ucrCheck()
        Me.ucrChkPoints = New instat.ucrCheck()
        Me.ucrSave = New instat.ucrSave()
        Me.cmdOptions = New instat.ucrSplitButton()
        Me.contextMenuStripOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PlotOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemLineOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemPointOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdPICSAOptions = New System.Windows.Forms.Button()
        Me.ucrReceiverPICSA = New instat.ucrVariablesAsFactor()
        Me.contextMenuStripOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(13, 391)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorPICSATemperature
        '
        Me.ucrSelectorPICSATemperature.AutoSize = True
        Me.ucrSelectorPICSATemperature.bDropUnusedFilterLevels = False
        Me.ucrSelectorPICSATemperature.bShowHiddenColumns = False
        Me.ucrSelectorPICSATemperature.bUseCurrentFilter = True
        Me.ucrSelectorPICSATemperature.Location = New System.Drawing.Point(4, 26)
        Me.ucrSelectorPICSATemperature.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorPICSATemperature.Name = "ucrSelectorPICSATemperature"
        Me.ucrSelectorPICSATemperature.Size = New System.Drawing.Size(221, 189)
        Me.ucrSelectorPICSATemperature.TabIndex = 2
        '
        'ucrInputStation
        '
        Me.ucrInputStation.AddQuotesIfUnrecognised = True
        Me.ucrInputStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStation.GetSetSelectedIndex = -1
        Me.ucrInputStation.IsReadOnly = False
        Me.ucrInputStation.Location = New System.Drawing.Point(369, 287)
        Me.ucrInputStation.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputStation.Name = "ucrInputStation"
        Me.ucrInputStation.Size = New System.Drawing.Size(82, 21)
        Me.ucrInputStation.TabIndex = 31
        '
        'ucrReceiverFacetBy
        '
        Me.ucrReceiverFacetBy.AutoSize = True
        Me.ucrReceiverFacetBy.frmParent = Me
        Me.ucrReceiverFacetBy.Location = New System.Drawing.Point(242, 287)
        Me.ucrReceiverFacetBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacetBy.Name = "ucrReceiverFacetBy"
        Me.ucrReceiverFacetBy.Selector = Nothing
        Me.ucrReceiverFacetBy.Size = New System.Drawing.Size(125, 26)
        Me.ucrReceiverFacetBy.strNcFilePath = ""
        Me.ucrReceiverFacetBy.TabIndex = 30
        Me.ucrReceiverFacetBy.ucrSelector = Nothing
        '
        'lblFacetBy
        '
        Me.lblFacetBy.AutoSize = True
        Me.lblFacetBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacetBy.Location = New System.Drawing.Point(242, 273)
        Me.lblFacetBy.Name = "lblFacetBy"
        Me.lblFacetBy.Size = New System.Drawing.Size(100, 13)
        Me.lblFacetBy.TabIndex = 29
        Me.lblFacetBy.Tag = ""
        Me.lblFacetBy.Text = "Facet By (Optional):"
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.AutoSize = True
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(242, 199)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(145, 26)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 26
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrReceiverColourBy
        '
        Me.ucrReceiverColourBy.AutoSize = True
        Me.ucrReceiverColourBy.frmParent = Me
        Me.ucrReceiverColourBy.Location = New System.Drawing.Point(242, 244)
        Me.ucrReceiverColourBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColourBy.Name = "ucrReceiverColourBy"
        Me.ucrReceiverColourBy.Selector = Nothing
        Me.ucrReceiverColourBy.Size = New System.Drawing.Size(145, 26)
        Me.ucrReceiverColourBy.strNcFilePath = ""
        Me.ucrReceiverColourBy.TabIndex = 28
        Me.ucrReceiverColourBy.ucrSelector = Nothing
        '
        'lblFactorOptional
        '
        Me.lblFactorOptional.AutoSize = True
        Me.lblFactorOptional.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactorOptional.Location = New System.Drawing.Point(242, 226)
        Me.lblFactorOptional.Name = "lblFactorOptional"
        Me.lblFactorOptional.Size = New System.Drawing.Size(103, 13)
        Me.lblFactorOptional.TabIndex = 27
        Me.lblFactorOptional.Tag = "Factor_Optional:"
        Me.lblFactorOptional.Text = "Colour By (Optional):"
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXVariable.Location = New System.Drawing.Point(242, 184)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(58, 13)
        Me.lblXVariable.TabIndex = 25
        Me.lblXVariable.Tag = "X_Variable:"
        Me.lblXVariable.Text = "X Variable:"
        '
        'ucrChkWithSE
        '
        Me.ucrChkWithSE.AutoSize = True
        Me.ucrChkWithSE.Checked = False
        Me.ucrChkWithSE.Location = New System.Drawing.Point(4, 299)
        Me.ucrChkWithSE.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkWithSE.Name = "ucrChkWithSE"
        Me.ucrChkWithSE.Size = New System.Drawing.Size(221, 23)
        Me.ucrChkWithSE.TabIndex = 33
        '
        'ucrChkLineofBestFit
        '
        Me.ucrChkLineofBestFit.AutoSize = True
        Me.ucrChkLineofBestFit.Checked = False
        Me.ucrChkLineofBestFit.Location = New System.Drawing.Point(4, 265)
        Me.ucrChkLineofBestFit.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkLineofBestFit.Name = "ucrChkLineofBestFit"
        Me.ucrChkLineofBestFit.Size = New System.Drawing.Size(221, 23)
        Me.ucrChkLineofBestFit.TabIndex = 32
        '
        'ucrChkPoints
        '
        Me.ucrChkPoints.AutoSize = True
        Me.ucrChkPoints.Checked = False
        Me.ucrChkPoints.Location = New System.Drawing.Point(4, 324)
        Me.ucrChkPoints.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkPoints.Name = "ucrChkPoints"
        Me.ucrChkPoints.Size = New System.Drawing.Size(221, 24)
        Me.ucrChkPoints.TabIndex = 34
        '
        'ucrSave
        '
        Me.ucrSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSave.Location = New System.Drawing.Point(4, 357)
        Me.ucrSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSave.Name = "ucrSave"
        Me.ucrSave.Size = New System.Drawing.Size(320, 24)
        Me.ucrSave.TabIndex = 35
        '
        'cmdOptions
        '
        Me.cmdOptions.AutoSize = True
        Me.cmdOptions.ContextMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.Location = New System.Drawing.Point(4, 231)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(151, 23)
        Me.cmdOptions.SplitMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.TabIndex = 37
        Me.cmdOptions.Tag = "Plot Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'contextMenuStripOptions
        '
        Me.contextMenuStripOptions.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.contextMenuStripOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlotOptionsToolStripMenuItem, Me.toolStripMenuItemLineOptions, Me.toolStripMenuItemPointOption})
        Me.contextMenuStripOptions.Name = "contextMenuStripOk"
        Me.contextMenuStripOptions.Size = New System.Drawing.Size(148, 70)
        '
        'PlotOptionsToolStripMenuItem
        '
        Me.PlotOptionsToolStripMenuItem.Name = "PlotOptionsToolStripMenuItem"
        Me.PlotOptionsToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.PlotOptionsToolStripMenuItem.Text = "Plot Options"
        '
        'toolStripMenuItemLineOptions
        '
        Me.toolStripMenuItemLineOptions.Name = "toolStripMenuItemLineOptions"
        Me.toolStripMenuItemLineOptions.Size = New System.Drawing.Size(147, 22)
        Me.toolStripMenuItemLineOptions.Text = "Line Options"
        '
        'toolStripMenuItemPointOption
        '
        Me.toolStripMenuItemPointOption.Name = "toolStripMenuItemPointOption"
        Me.toolStripMenuItemPointOption.Size = New System.Drawing.Size(147, 22)
        Me.toolStripMenuItemPointOption.Text = "Point Options"
        '
        'cmdPICSAOptions
        '
        Me.cmdPICSAOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPICSAOptions.Location = New System.Drawing.Point(4, 207)
        Me.cmdPICSAOptions.Name = "cmdPICSAOptions"
        Me.cmdPICSAOptions.Size = New System.Drawing.Size(151, 23)
        Me.cmdPICSAOptions.TabIndex = 36
        Me.cmdPICSAOptions.Tag = ""
        Me.cmdPICSAOptions.Text = "PICSA Options"
        Me.cmdPICSAOptions.UseVisualStyleBackColor = True
        '
        'ucrReceiverPICSA
        '
        Me.ucrReceiverPICSA.AutoSize = True
        Me.ucrReceiverPICSA.frmParent = Me
        Me.ucrReceiverPICSA.Location = New System.Drawing.Point(242, 37)
        Me.ucrReceiverPICSA.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrReceiverPICSA.Name = "ucrReceiverPICSA"
        Me.ucrReceiverPICSA.Selector = Nothing
        Me.ucrReceiverPICSA.Size = New System.Drawing.Size(156, 119)
        Me.ucrReceiverPICSA.strNcFilePath = ""
        Me.ucrReceiverPICSA.TabIndex = 38
        Me.ucrReceiverPICSA.ucrSelector = Nothing
        Me.ucrReceiverPICSA.ucrVariableSelector = Nothing
        '
        'dlgPICSATemperature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(462, 447)
        Me.Controls.Add(Me.ucrReceiverPICSA)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.cmdPICSAOptions)
        Me.Controls.Add(Me.ucrChkWithSE)
        Me.Controls.Add(Me.ucrChkLineofBestFit)
        Me.Controls.Add(Me.ucrChkPoints)
        Me.Controls.Add(Me.ucrSave)
        Me.Controls.Add(Me.ucrInputStation)
        Me.Controls.Add(Me.ucrReceiverFacetBy)
        Me.Controls.Add(Me.lblFacetBy)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.ucrReceiverColourBy)
        Me.Controls.Add(Me.lblFactorOptional)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.ucrSelectorPICSATemperature)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPICSATemperature"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PICSA Temperature"
        Me.contextMenuStripOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorPICSATemperature As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputStation As ucrInputComboBox
    Friend WithEvents ucrReceiverFacetBy As ucrReceiverSingle
    Friend WithEvents lblFacetBy As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents ucrReceiverColourBy As ucrReceiverSingle
    Friend WithEvents lblFactorOptional As Label
    Friend WithEvents lblXVariable As Label
    Friend WithEvents ucrChkWithSE As ucrCheck
    Friend WithEvents ucrChkLineofBestFit As ucrCheck
    Friend WithEvents ucrChkPoints As ucrCheck
    Friend WithEvents ucrSave As ucrSave
    Friend WithEvents cmdOptions As ucrSplitButton
    Friend WithEvents cmdPICSAOptions As Button
    Friend WithEvents contextMenuStripOptions As ContextMenuStrip
    Friend WithEvents PlotOptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemLineOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemPointOption As ToolStripMenuItem
    Friend WithEvents ucrReceiverPICSA As ucrVariablesAsFactor
End Class
