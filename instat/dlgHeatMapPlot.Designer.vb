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
Partial Class dlgHeatMapPlot
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
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.cmdTileOptions = New System.Windows.Forms.Button()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.lblFill = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblPointsOptional = New System.Windows.Forms.Label()
        Me.lblPointsSize = New System.Windows.Forms.Label()
        Me.ucrReceiverPoints = New instat.ucrReceiverSingle()
        Me.ucrNudShape = New instat.ucrNud()
        Me.ucrChkColourPalette = New instat.ucrCheck()
        Me.ucrInputColourPalette = New instat.ucrInputComboBox()
        Me.ucrInputSize = New instat.ucrInputComboBox()
        Me.ucrInputColour = New instat.ucrInputComboBox()
        Me.ucrInputPosition = New instat.ucrInputComboBox()
        Me.ucrChkAddLabels = New instat.ucrCheck()
        Me.ucrVariableAsFactorForHeatMap = New instat.ucrVariablesAsFactor()
        Me.ucrReceiverFill = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrHeatMapSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(10, 243)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(147, 25)
        Me.cmdOptions.TabIndex = 11
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'cmdTileOptions
        '
        Me.cmdTileOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTileOptions.Location = New System.Drawing.Point(10, 212)
        Me.cmdTileOptions.Name = "cmdTileOptions"
        Me.cmdTileOptions.Size = New System.Drawing.Size(147, 25)
        Me.cmdTileOptions.TabIndex = 10
        Me.cmdTileOptions.Tag = "Tile_Options"
        Me.cmdTileOptions.Text = "Tile Options"
        Me.cmdTileOptions.UseVisualStyleBackColor = True
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXVariable.Location = New System.Drawing.Point(273, 93)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(58, 13)
        Me.lblXVariable.TabIndex = 2
        Me.lblXVariable.Tag = "X_Variable:"
        Me.lblXVariable.Text = "X Variable:"
        '
        'lblFill
        '
        Me.lblFill.AutoSize = True
        Me.lblFill.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFill.Location = New System.Drawing.Point(273, 138)
        Me.lblFill.Name = "lblFill"
        Me.lblFill.Size = New System.Drawing.Size(22, 13)
        Me.lblFill.TabIndex = 4
        Me.lblFill.Tag = "fill"
        Me.lblFill.Text = "Fill:"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPosition.Location = New System.Drawing.Point(91, 283)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(47, 13)
        Me.lblPosition.TabIndex = 13
        Me.lblPosition.Text = "Position:"
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColour.Location = New System.Drawing.Point(208, 283)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(40, 13)
        Me.lblColour.TabIndex = 15
        Me.lblColour.Text = "Colour:"
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSize.Location = New System.Drawing.Point(314, 283)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(30, 13)
        Me.lblSize.TabIndex = 17
        Me.lblSize.Text = "Size:"
        '
        'lblPointsOptional
        '
        Me.lblPointsOptional.AutoSize = True
        Me.lblPointsOptional.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPointsOptional.Location = New System.Drawing.Point(273, 184)
        Me.lblPointsOptional.Name = "lblPointsOptional"
        Me.lblPointsOptional.Size = New System.Drawing.Size(87, 13)
        Me.lblPointsOptional.TabIndex = 6
        Me.lblPointsOptional.Tag = "Points_Optional"
        Me.lblPointsOptional.Text = "Points (Optional):"
        '
        'lblPointsSize
        '
        Me.lblPointsSize.AutoSize = True
        Me.lblPointsSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPointsSize.Location = New System.Drawing.Point(273, 225)
        Me.lblPointsSize.Name = "lblPointsSize"
        Me.lblPointsSize.Size = New System.Drawing.Size(30, 13)
        Me.lblPointsSize.TabIndex = 8
        Me.lblPointsSize.Text = "Size:"
        '
        'ucrReceiverPoints
        '
        Me.ucrReceiverPoints.AutoSize = True
        Me.ucrReceiverPoints.frmParent = Me
        Me.ucrReceiverPoints.Location = New System.Drawing.Point(273, 199)
        Me.ucrReceiverPoints.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPoints.Name = "ucrReceiverPoints"
        Me.ucrReceiverPoints.Selector = Nothing
        Me.ucrReceiverPoints.Size = New System.Drawing.Size(125, 20)
        Me.ucrReceiverPoints.strNcFilePath = ""
        Me.ucrReceiverPoints.TabIndex = 7
        Me.ucrReceiverPoints.ucrSelector = Nothing
        '
        'ucrNudShape
        '
        Me.ucrNudShape.AutoSize = True
        Me.ucrNudShape.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShape.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudShape.Location = New System.Drawing.Point(306, 221)
        Me.ucrNudShape.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudShape.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShape.Name = "ucrNudShape"
        Me.ucrNudShape.Size = New System.Drawing.Size(38, 20)
        Me.ucrNudShape.TabIndex = 9
        Me.ucrNudShape.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkColourPalette
        '
        Me.ucrChkColourPalette.AutoSize = True
        Me.ucrChkColourPalette.Checked = False
        Me.ucrChkColourPalette.Location = New System.Drawing.Point(10, 309)
        Me.ucrChkColourPalette.Name = "ucrChkColourPalette"
        Me.ucrChkColourPalette.Size = New System.Drawing.Size(128, 23)
        Me.ucrChkColourPalette.TabIndex = 19
        '
        'ucrInputColourPalette
        '
        Me.ucrInputColourPalette.AddQuotesIfUnrecognised = True
        Me.ucrInputColourPalette.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputColourPalette.GetSetSelectedIndex = -1
        Me.ucrInputColourPalette.IsReadOnly = False
        Me.ucrInputColourPalette.Location = New System.Drawing.Point(141, 309)
        Me.ucrInputColourPalette.Name = "ucrInputColourPalette"
        Me.ucrInputColourPalette.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputColourPalette.TabIndex = 20
        '
        'ucrInputSize
        '
        Me.ucrInputSize.AddQuotesIfUnrecognised = True
        Me.ucrInputSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSize.GetSetSelectedIndex = -1
        Me.ucrInputSize.IsReadOnly = False
        Me.ucrInputSize.Location = New System.Drawing.Point(347, 279)
        Me.ucrInputSize.Name = "ucrInputSize"
        Me.ucrInputSize.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputSize.TabIndex = 18
        '
        'ucrInputColour
        '
        Me.ucrInputColour.AddQuotesIfUnrecognised = True
        Me.ucrInputColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputColour.GetSetSelectedIndex = -1
        Me.ucrInputColour.IsReadOnly = False
        Me.ucrInputColour.Location = New System.Drawing.Point(251, 279)
        Me.ucrInputColour.Name = "ucrInputColour"
        Me.ucrInputColour.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputColour.TabIndex = 16
        '
        'ucrInputPosition
        '
        Me.ucrInputPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPosition.GetSetSelectedIndex = -1
        Me.ucrInputPosition.IsReadOnly = False
        Me.ucrInputPosition.Location = New System.Drawing.Point(141, 279)
        Me.ucrInputPosition.Name = "ucrInputPosition"
        Me.ucrInputPosition.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputPosition.TabIndex = 14
        '
        'ucrChkAddLabels
        '
        Me.ucrChkAddLabels.AutoSize = True
        Me.ucrChkAddLabels.Checked = False
        Me.ucrChkAddLabels.Location = New System.Drawing.Point(10, 279)
        Me.ucrChkAddLabels.Name = "ucrChkAddLabels"
        Me.ucrChkAddLabels.Size = New System.Drawing.Size(82, 23)
        Me.ucrChkAddLabels.TabIndex = 12
        '
        'ucrVariableAsFactorForHeatMap
        '
        Me.ucrVariableAsFactorForHeatMap.AutoSize = True
        Me.ucrVariableAsFactorForHeatMap.frmParent = Me
        Me.ucrVariableAsFactorForHeatMap.Location = New System.Drawing.Point(273, 16)
        Me.ucrVariableAsFactorForHeatMap.Name = "ucrVariableAsFactorForHeatMap"
        Me.ucrVariableAsFactorForHeatMap.Selector = Nothing
        Me.ucrVariableAsFactorForHeatMap.Size = New System.Drawing.Size(125, 74)
        Me.ucrVariableAsFactorForHeatMap.strNcFilePath = ""
        Me.ucrVariableAsFactorForHeatMap.TabIndex = 1
        Me.ucrVariableAsFactorForHeatMap.ucrSelector = Nothing
        Me.ucrVariableAsFactorForHeatMap.ucrVariableSelector = Nothing
        '
        'ucrReceiverFill
        '
        Me.ucrReceiverFill.AutoSize = True
        Me.ucrReceiverFill.frmParent = Me
        Me.ucrReceiverFill.Location = New System.Drawing.Point(273, 151)
        Me.ucrReceiverFill.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFill.Name = "ucrReceiverFill"
        Me.ucrReceiverFill.Selector = Nothing
        Me.ucrReceiverFill.Size = New System.Drawing.Size(125, 20)
        Me.ucrReceiverFill.strNcFilePath = ""
        Me.ucrReceiverFill.TabIndex = 5
        Me.ucrReceiverFill.ucrSelector = Nothing
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.AutoSize = True
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(273, 108)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(125, 20)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 3
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 340)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(370, 24)
        Me.ucrSaveGraph.TabIndex = 21
        '
        'ucrHeatMapSelector
        '
        Me.ucrHeatMapSelector.AutoSize = True
        Me.ucrHeatMapSelector.bDropUnusedFilterLevels = False
        Me.ucrHeatMapSelector.bShowHiddenColumns = False
        Me.ucrHeatMapSelector.bUseCurrentFilter = True
        Me.ucrHeatMapSelector.Location = New System.Drawing.Point(8, 22)
        Me.ucrHeatMapSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrHeatMapSelector.Name = "ucrHeatMapSelector"
        Me.ucrHeatMapSelector.Size = New System.Drawing.Size(238, 190)
        Me.ucrHeatMapSelector.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(8, 372)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 22
        '
        'dlgHeatMapPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(420, 426)
        Me.Controls.Add(Me.lblPointsOptional)
        Me.Controls.Add(Me.lblPointsSize)
        Me.Controls.Add(Me.ucrReceiverPoints)
        Me.Controls.Add(Me.ucrNudShape)
        Me.Controls.Add(Me.ucrChkColourPalette)
        Me.Controls.Add(Me.ucrInputColourPalette)
        Me.Controls.Add(Me.ucrInputSize)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.ucrInputColour)
        Me.Controls.Add(Me.lblColour)
        Me.Controls.Add(Me.ucrInputPosition)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.ucrChkAddLabels)
        Me.Controls.Add(Me.ucrVariableAsFactorForHeatMap)
        Me.Controls.Add(Me.lblFill)
        Me.Controls.Add(Me.ucrReceiverFill)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.cmdTileOptions)
        Me.Controls.Add(Me.ucrHeatMapSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgHeatMapPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Heat Map"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOptions As Button
    Friend WithEvents cmdTileOptions As Button
    Friend WithEvents ucrHeatMapSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents lblXVariable As Label
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrVariableAsFactorForHeatMap As ucrVariablesAsFactor
    Friend WithEvents lblFill As Label
    Friend WithEvents ucrReceiverFill As ucrReceiverSingle
    Friend WithEvents ucrChkAddLabels As ucrCheck
    Friend WithEvents lblPosition As Label
    Friend WithEvents ucrInputPosition As ucrInputComboBox
    Friend WithEvents lblColour As Label
    Friend WithEvents ucrInputColour As ucrInputComboBox
    Friend WithEvents ucrInputSize As ucrInputComboBox
    Friend WithEvents lblSize As Label
    Friend WithEvents ucrInputColourPalette As ucrInputComboBox
    Friend WithEvents ucrChkColourPalette As ucrCheck
    Friend WithEvents lblPointsOptional As Label
    Friend WithEvents lblPointsSize As Label
    Friend WithEvents ucrReceiverPoints As ucrReceiverSingle
    Friend WithEvents ucrNudShape As ucrNud
End Class