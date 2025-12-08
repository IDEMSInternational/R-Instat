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
Partial Class dlgPICSARainfall
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
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.cmdPICSAOptions = New System.Windows.Forms.Button()
        Me.lblFacetBy = New System.Windows.Forms.Label()
        Me.contextMenuStripOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PlotOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemLineOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemPointOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblIncludeStatus = New System.Windows.Forms.Label()
        Me.lblYVar = New System.Windows.Forms.Label()
        Me.lblSecondYVar = New System.Windows.Forms.Label()
        Me.ucrReceiverSecondYVar = New instat.ucrReceiverSingle()
        Me.ucrReceiverForPICSA = New instat.ucrReceiverSingle()
        Me.ucrChkIncludeStatus = New instat.ucrCheck()
        Me.ucrReceiverIncludeStatus = New instat.ucrReceiverSingle()
        Me.ucrChkWithSE = New instat.ucrCheck()
        Me.ucrChkLineofBestFit = New instat.ucrCheck()
        Me.cmdOptions = New instat.ucrSplitButton()
        Me.ucrInputStation = New instat.ucrInputComboBox()
        Me.ucrReceiverFacetBy = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrChkPoints = New instat.ucrCheck()
        Me.ucrSave = New instat.ucrSave()
        Me.ucrSelectorPICSARainfall = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverColourBy = New instat.ucrReceiverSingle()
        Me.contextMenuStripOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFactorOptional
        '
        Me.lblFactorOptional.AutoSize = True
        Me.lblFactorOptional.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactorOptional.Location = New System.Drawing.Point(372, 266)
        Me.lblFactorOptional.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFactorOptional.Name = "lblFactorOptional"
        Me.lblFactorOptional.Size = New System.Drawing.Size(154, 20)
        Me.lblFactorOptional.TabIndex = 9
        Me.lblFactorOptional.Tag = "Factor_Optional:"
        Me.lblFactorOptional.Text = "Colour By (Optional):"
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXVariable.Location = New System.Drawing.Point(372, 203)
        Me.lblXVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(86, 20)
        Me.lblXVariable.TabIndex = 7
        Me.lblXVariable.Tag = "X_Variable:"
        Me.lblXVariable.Text = "X Variable:"
        '
        'lblAvailable
        '
        Me.lblAvailable.AutoSize = True
        Me.lblAvailable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAvailable.Location = New System.Drawing.Point(39, 21)
        Me.lblAvailable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(0, 20)
        Me.lblAvailable.TabIndex = 2
        '
        'cmdPICSAOptions
        '
        Me.cmdPICSAOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPICSAOptions.Location = New System.Drawing.Point(14, 292)
        Me.cmdPICSAOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPICSAOptions.Name = "cmdPICSAOptions"
        Me.cmdPICSAOptions.Size = New System.Drawing.Size(226, 34)
        Me.cmdPICSAOptions.TabIndex = 17
        Me.cmdPICSAOptions.Tag = ""
        Me.cmdPICSAOptions.Text = "PICSA Options"
        Me.cmdPICSAOptions.UseVisualStyleBackColor = True
        '
        'lblFacetBy
        '
        Me.lblFacetBy.AutoSize = True
        Me.lblFacetBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacetBy.Location = New System.Drawing.Point(372, 337)
        Me.lblFacetBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFacetBy.Name = "lblFacetBy"
        Me.lblFacetBy.Size = New System.Drawing.Size(149, 20)
        Me.lblFacetBy.TabIndex = 11
        Me.lblFacetBy.Tag = ""
        Me.lblFacetBy.Text = "Facet By (Optional):"
        '
        'contextMenuStripOptions
        '
        Me.contextMenuStripOptions.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.contextMenuStripOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlotOptionsToolStripMenuItem, Me.toolStripMenuItemLineOptions, Me.toolStripMenuItemPointOption})
        Me.contextMenuStripOptions.Name = "contextMenuStripOk"
        Me.contextMenuStripOptions.Size = New System.Drawing.Size(194, 100)
        '
        'PlotOptionsToolStripMenuItem
        '
        Me.PlotOptionsToolStripMenuItem.Name = "PlotOptionsToolStripMenuItem"
        Me.PlotOptionsToolStripMenuItem.Size = New System.Drawing.Size(193, 32)
        Me.PlotOptionsToolStripMenuItem.Text = "Plot Options"
        '
        'toolStripMenuItemLineOptions
        '
        Me.toolStripMenuItemLineOptions.Name = "toolStripMenuItemLineOptions"
        Me.toolStripMenuItemLineOptions.Size = New System.Drawing.Size(193, 32)
        Me.toolStripMenuItemLineOptions.Text = "Line Options"
        '
        'toolStripMenuItemPointOption
        '
        Me.toolStripMenuItemPointOption.Name = "toolStripMenuItemPointOption"
        Me.toolStripMenuItemPointOption.Size = New System.Drawing.Size(193, 32)
        Me.toolStripMenuItemPointOption.Text = "Point Options"
        '
        'lblIncludeStatus
        '
        Me.lblIncludeStatus.AutoSize = True
        Me.lblIncludeStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblIncludeStatus.Location = New System.Drawing.Point(372, 478)
        Me.lblIncludeStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIncludeStatus.Name = "lblIncludeStatus"
        Me.lblIncludeStatus.Size = New System.Drawing.Size(122, 20)
        Me.lblIncludeStatus.TabIndex = 14
        Me.lblIncludeStatus.Tag = ""
        Me.lblIncludeStatus.Text = "Status Variable:"
        '
        'lblYVar
        '
        Me.lblYVar.AutoSize = True
        Me.lblYVar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYVar.Location = New System.Drawing.Point(372, 71)
        Me.lblYVar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYVar.Name = "lblYVar"
        Me.lblYVar.Size = New System.Drawing.Size(86, 20)
        Me.lblYVar.TabIndex = 3
        Me.lblYVar.Tag = ""
        Me.lblYVar.Text = "Y Variable:"
        '
        'lblSecondYVar
        '
        Me.lblSecondYVar.AutoSize = True
        Me.lblSecondYVar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondYVar.Location = New System.Drawing.Point(372, 140)
        Me.lblSecondYVar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecondYVar.Name = "lblSecondYVar"
        Me.lblSecondYVar.Size = New System.Drawing.Size(218, 20)
        Me.lblSecondYVar.TabIndex = 5
        Me.lblSecondYVar.Tag = ""
        Me.lblSecondYVar.Text = "Second Y Variable (Optional):"
        '
        'ucrReceiverSecondYVar
        '
        Me.ucrReceiverSecondYVar.AutoSize = True
        Me.ucrReceiverSecondYVar.frmParent = Me
        Me.ucrReceiverSecondYVar.Location = New System.Drawing.Point(372, 160)
        Me.ucrReceiverSecondYVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondYVar.Name = "ucrReceiverSecondYVar"
        Me.ucrReceiverSecondYVar.Selector = Nothing
        Me.ucrReceiverSecondYVar.Size = New System.Drawing.Size(218, 39)
        Me.ucrReceiverSecondYVar.strNcFilePath = ""
        Me.ucrReceiverSecondYVar.TabIndex = 6
        Me.ucrReceiverSecondYVar.ucrSelector = Nothing
        '
        'ucrReceiverForPICSA
        '
        Me.ucrReceiverForPICSA.AutoSize = True
        Me.ucrReceiverForPICSA.frmParent = Me
        Me.ucrReceiverForPICSA.Location = New System.Drawing.Point(372, 91)
        Me.ucrReceiverForPICSA.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForPICSA.Name = "ucrReceiverForPICSA"
        Me.ucrReceiverForPICSA.Selector = Nothing
        Me.ucrReceiverForPICSA.Size = New System.Drawing.Size(218, 39)
        Me.ucrReceiverForPICSA.strNcFilePath = ""
        Me.ucrReceiverForPICSA.TabIndex = 4
        Me.ucrReceiverForPICSA.ucrSelector = Nothing
        '
        'ucrChkIncludeStatus
        '
        Me.ucrChkIncludeStatus.AutoSize = True
        Me.ucrChkIncludeStatus.Checked = False
        Me.ucrChkIncludeStatus.Location = New System.Drawing.Point(14, 498)
        Me.ucrChkIncludeStatus.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkIncludeStatus.Name = "ucrChkIncludeStatus"
        Me.ucrChkIncludeStatus.Size = New System.Drawing.Size(281, 36)
        Me.ucrChkIncludeStatus.TabIndex = 15
        '
        'ucrReceiverIncludeStatus
        '
        Me.ucrReceiverIncludeStatus.AutoSize = True
        Me.ucrReceiverIncludeStatus.frmParent = Me
        Me.ucrReceiverIncludeStatus.Location = New System.Drawing.Point(372, 498)
        Me.ucrReceiverIncludeStatus.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverIncludeStatus.Name = "ucrReceiverIncludeStatus"
        Me.ucrReceiverIncludeStatus.Selector = Nothing
        Me.ucrReceiverIncludeStatus.Size = New System.Drawing.Size(218, 38)
        Me.ucrReceiverIncludeStatus.strNcFilePath = ""
        Me.ucrReceiverIncludeStatus.TabIndex = 16
        Me.ucrReceiverIncludeStatus.ucrSelector = Nothing
        '
        'ucrChkWithSE
        '
        Me.ucrChkWithSE.AutoSize = True
        Me.ucrChkWithSE.Checked = False
        Me.ucrChkWithSE.Location = New System.Drawing.Point(14, 422)
        Me.ucrChkWithSE.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkWithSE.Name = "ucrChkWithSE"
        Me.ucrChkWithSE.Size = New System.Drawing.Size(332, 34)
        Me.ucrChkWithSE.TabIndex = 20
        '
        'ucrChkLineofBestFit
        '
        Me.ucrChkLineofBestFit.AutoSize = True
        Me.ucrChkLineofBestFit.Checked = False
        Me.ucrChkLineofBestFit.Location = New System.Drawing.Point(18, 375)
        Me.ucrChkLineofBestFit.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkLineofBestFit.Name = "ucrChkLineofBestFit"
        Me.ucrChkLineofBestFit.Size = New System.Drawing.Size(332, 34)
        Me.ucrChkLineofBestFit.TabIndex = 19
        '
        'cmdOptions
        '
        Me.cmdOptions.AutoSize = True
        Me.cmdOptions.ContextMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.Location = New System.Drawing.Point(14, 328)
        Me.cmdOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(226, 34)
        Me.cmdOptions.SplitMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.TabIndex = 18
        Me.cmdOptions.Tag = "Plot Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrInputStation
        '
        Me.ucrInputStation.AddQuotesIfUnrecognised = True
        Me.ucrInputStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStation.GetSetSelectedIndex = -1
        Me.ucrInputStation.IsReadOnly = False
        Me.ucrInputStation.Location = New System.Drawing.Point(562, 357)
        Me.ucrInputStation.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputStation.Name = "ucrInputStation"
        Me.ucrInputStation.Size = New System.Drawing.Size(123, 32)
        Me.ucrInputStation.TabIndex = 13
        '
        'ucrReceiverFacetBy
        '
        Me.ucrReceiverFacetBy.AutoSize = True
        Me.ucrReceiverFacetBy.frmParent = Me
        Me.ucrReceiverFacetBy.Location = New System.Drawing.Point(372, 357)
        Me.ucrReceiverFacetBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacetBy.Name = "ucrReceiverFacetBy"
        Me.ucrReceiverFacetBy.Selector = Nothing
        Me.ucrReceiverFacetBy.Size = New System.Drawing.Size(188, 39)
        Me.ucrReceiverFacetBy.strNcFilePath = ""
        Me.ucrReceiverFacetBy.TabIndex = 12
        Me.ucrReceiverFacetBy.ucrSelector = Nothing
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.AutoSize = True
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(372, 225)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(218, 39)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 8
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrChkPoints
        '
        Me.ucrChkPoints.AutoSize = True
        Me.ucrChkPoints.Checked = False
        Me.ucrChkPoints.Location = New System.Drawing.Point(14, 544)
        Me.ucrChkPoints.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkPoints.Name = "ucrChkPoints"
        Me.ucrChkPoints.Size = New System.Drawing.Size(332, 36)
        Me.ucrChkPoints.TabIndex = 21
        '
        'ucrSave
        '
        Me.ucrSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSave.Location = New System.Drawing.Point(14, 590)
        Me.ucrSave.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSave.Name = "ucrSave"
        Me.ucrSave.Size = New System.Drawing.Size(480, 36)
        Me.ucrSave.TabIndex = 22
        '
        'ucrSelectorPICSARainfall
        '
        Me.ucrSelectorPICSARainfall.AutoSize = True
        Me.ucrSelectorPICSARainfall.bDropUnusedFilterLevels = False
        Me.ucrSelectorPICSARainfall.bShowHiddenColumns = False
        Me.ucrSelectorPICSARainfall.bUseCurrentFilter = True
        Me.ucrSelectorPICSARainfall.Location = New System.Drawing.Point(14, 14)
        Me.ucrSelectorPICSARainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorPICSARainfall.Name = "ucrSelectorPICSARainfall"
        Me.ucrSelectorPICSARainfall.Size = New System.Drawing.Size(332, 284)
        Me.ucrSelectorPICSARainfall.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(14, 633)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 0
        '
        'ucrReceiverColourBy
        '
        Me.ucrReceiverColourBy.AutoSize = True
        Me.ucrReceiverColourBy.frmParent = Me
        Me.ucrReceiverColourBy.Location = New System.Drawing.Point(372, 293)
        Me.ucrReceiverColourBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColourBy.Name = "ucrReceiverColourBy"
        Me.ucrReceiverColourBy.Selector = Nothing
        Me.ucrReceiverColourBy.Size = New System.Drawing.Size(218, 39)
        Me.ucrReceiverColourBy.strNcFilePath = ""
        Me.ucrReceiverColourBy.TabIndex = 10
        Me.ucrReceiverColourBy.ucrSelector = Nothing
        '
        'dlgPICSARainfall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(694, 724)
        Me.Controls.Add(Me.lblSecondYVar)
        Me.Controls.Add(Me.ucrReceiverSecondYVar)
        Me.Controls.Add(Me.lblYVar)
        Me.Controls.Add(Me.ucrReceiverForPICSA)
        Me.Controls.Add(Me.ucrChkIncludeStatus)
        Me.Controls.Add(Me.ucrReceiverIncludeStatus)
        Me.Controls.Add(Me.lblIncludeStatus)
        Me.Controls.Add(Me.ucrChkWithSE)
        Me.Controls.Add(Me.ucrChkLineofBestFit)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrInputStation)
        Me.Controls.Add(Me.ucrReceiverFacetBy)
        Me.Controls.Add(Me.lblFacetBy)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.ucrChkPoints)
        Me.Controls.Add(Me.ucrSave)
        Me.Controls.Add(Me.cmdPICSAOptions)
        Me.Controls.Add(Me.ucrSelectorPICSARainfall)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverColourBy)
        Me.Controls.Add(Me.lblFactorOptional)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.lblAvailable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPICSARainfall"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PICSA Rainfall Graphs"
        Me.contextMenuStripOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrChkPoints As ucrCheck
    Friend WithEvents ucrSave As ucrSave
    Friend WithEvents ucrSelectorPICSARainfall As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverColourBy As ucrReceiverSingle
    Friend WithEvents lblFactorOptional As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents lblXVariable As Label
    Friend WithEvents lblAvailable As Label
    Friend WithEvents cmdPICSAOptions As Button
    Friend WithEvents ucrReceiverFacetBy As ucrReceiverSingle
    Friend WithEvents lblFacetBy As Label
    Friend WithEvents ucrInputStation As ucrInputComboBox
    Friend WithEvents cmdOptions As ucrSplitButton
    Friend WithEvents contextMenuStripOptions As ContextMenuStrip
    Friend WithEvents PlotOptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemLineOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemPointOption As ToolStripMenuItem
    Friend WithEvents ucrChkWithSE As ucrCheck
    Friend WithEvents ucrChkLineofBestFit As ucrCheck
    Friend WithEvents ucrReceiverIncludeStatus As ucrReceiverSingle
    Friend WithEvents lblIncludeStatus As Label
    Friend WithEvents ucrChkIncludeStatus As ucrCheck
    Friend WithEvents lblYVar As Label
    Friend WithEvents ucrReceiverForPICSA As ucrReceiverSingle
    Friend WithEvents lblSecondYVar As Label
    Friend WithEvents ucrReceiverSecondYVar As ucrReceiverSingle
End Class
