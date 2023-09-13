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
Partial Class dlgGeneralForGraphics
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
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.lblFillOrColor = New System.Windows.Forms.Label()
        Me.cmdFacets = New System.Windows.Forms.Button()
        Me.cmdTheme = New System.Windows.Forms.Button()
        Me.cmdYAxis = New System.Windows.Forms.Button()
        Me.cmdXAxis = New System.Windows.Forms.Button()
        Me.cmdTitles = New System.Windows.Forms.Button()
        Me.lblYVariable = New System.Windows.Forms.Label()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrReceiverY = New instat.ucrReceiverSingle()
        Me.ucrChkFlipCoordinates = New instat.ucrCheck()
        Me.ucrChkLegend = New instat.ucrCheck()
        Me.ucrSave = New instat.ucrSave()
        Me.ucrFillOrColourReceiver = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrGraphicsSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrAdditionalLayers = New instat.ucrAdditionalLayers()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'cmdOptions
        '
        Me.cmdOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOptions.Location = New System.Drawing.Point(6, 401)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(135, 25)
        Me.cmdOptions.TabIndex = 7
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXVariable.Location = New System.Drawing.Point(254, 81)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(58, 13)
        Me.lblXVariable.TabIndex = 3
        Me.lblXVariable.Tag = "X_Variable:"
        Me.lblXVariable.Text = "X Variable:"
        '
        'lblFillOrColor
        '
        Me.lblFillOrColor.AutoSize = True
        Me.lblFillOrColor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFillOrColor.Location = New System.Drawing.Point(254, 122)
        Me.lblFillOrColor.Name = "lblFillOrColor"
        Me.lblFillOrColor.Size = New System.Drawing.Size(57, 13)
        Me.lblFillOrColor.TabIndex = 5
        Me.lblFillOrColor.Tag = "Fill_Colour:"
        Me.lblFillOrColor.Text = "Fill/Colour:"
        '
        'cmdFacets
        '
        Me.cmdFacets.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFacets.Location = New System.Drawing.Point(139, 401)
        Me.cmdFacets.Name = "cmdFacets"
        Me.cmdFacets.Size = New System.Drawing.Size(64, 25)
        Me.cmdFacets.TabIndex = 17
        Me.cmdFacets.Tag = "Facets"
        Me.cmdFacets.Text = "Facets"
        Me.cmdFacets.UseVisualStyleBackColor = True
        '
        'cmdTheme
        '
        Me.cmdTheme.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTheme.Location = New System.Drawing.Point(360, 401)
        Me.cmdTheme.Name = "cmdTheme"
        Me.cmdTheme.Size = New System.Drawing.Size(51, 25)
        Me.cmdTheme.TabIndex = 21
        Me.cmdTheme.Tag = "Theme"
        Me.cmdTheme.Text = "Theme"
        Me.cmdTheme.UseVisualStyleBackColor = True
        '
        'cmdYAxis
        '
        Me.cmdYAxis.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdYAxis.Location = New System.Drawing.Point(306, 401)
        Me.cmdYAxis.Name = "cmdYAxis"
        Me.cmdYAxis.Size = New System.Drawing.Size(56, 25)
        Me.cmdYAxis.TabIndex = 20
        Me.cmdYAxis.Tag = ""
        Me.cmdYAxis.Text = "Y-Axis"
        Me.cmdYAxis.UseVisualStyleBackColor = True
        '
        'cmdXAxis
        '
        Me.cmdXAxis.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdXAxis.Location = New System.Drawing.Point(252, 401)
        Me.cmdXAxis.Name = "cmdXAxis"
        Me.cmdXAxis.Size = New System.Drawing.Size(56, 25)
        Me.cmdXAxis.TabIndex = 19
        Me.cmdXAxis.Tag = ""
        Me.cmdXAxis.Text = "X-Axis"
        Me.cmdXAxis.UseVisualStyleBackColor = True
        '
        'cmdTitles
        '
        Me.cmdTitles.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTitles.Location = New System.Drawing.Point(201, 401)
        Me.cmdTitles.Name = "cmdTitles"
        Me.cmdTitles.Size = New System.Drawing.Size(53, 25)
        Me.cmdTitles.TabIndex = 18
        Me.cmdTitles.Tag = ""
        Me.cmdTitles.Text = "Titles"
        Me.cmdTitles.UseVisualStyleBackColor = True
        '
        'lblYVariable
        '
        Me.lblYVariable.AutoSize = True
        Me.lblYVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYVariable.Location = New System.Drawing.Point(254, 38)
        Me.lblYVariable.Name = "lblYVariable"
        Me.lblYVariable.Size = New System.Drawing.Size(58, 13)
        Me.lblYVariable.TabIndex = 1
        Me.lblYVariable.Tag = "Y_Variable:"
        Me.lblYVariable.Text = "Y Variable:"
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(252, 360)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLegendPosition.TabIndex = 15
        '
        'ucrReceiverY
        '
        Me.ucrReceiverY.AutoSize = True
        Me.ucrReceiverY.frmParent = Me
        Me.ucrReceiverY.Location = New System.Drawing.Point(252, 51)
        Me.ucrReceiverY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverY.Name = "ucrReceiverY"
        Me.ucrReceiverY.Selector = Nothing
        Me.ucrReceiverY.Size = New System.Drawing.Size(125, 20)
        Me.ucrReceiverY.strNcFilePath = ""
        Me.ucrReceiverY.TabIndex = 2
        Me.ucrReceiverY.ucrSelector = Nothing
        '
        'ucrChkFlipCoordinates
        '
        Me.ucrChkFlipCoordinates.AutoSize = True
        Me.ucrChkFlipCoordinates.Checked = False
        Me.ucrChkFlipCoordinates.Location = New System.Drawing.Point(257, 300)
        Me.ucrChkFlipCoordinates.Name = "ucrChkFlipCoordinates"
        Me.ucrChkFlipCoordinates.Size = New System.Drawing.Size(125, 24)
        Me.ucrChkFlipCoordinates.TabIndex = 13
        '
        'ucrChkLegend
        '
        Me.ucrChkLegend.AutoSize = True
        Me.ucrChkLegend.Checked = False
        Me.ucrChkLegend.Location = New System.Drawing.Point(257, 335)
        Me.ucrChkLegend.Name = "ucrChkLegend"
        Me.ucrChkLegend.Size = New System.Drawing.Size(125, 24)
        Me.ucrChkLegend.TabIndex = 14
        '
        'ucrSave
        '
        Me.ucrSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSave.Location = New System.Drawing.Point(6, 434)
        Me.ucrSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSave.Name = "ucrSave"
        Me.ucrSave.Size = New System.Drawing.Size(346, 24)
        Me.ucrSave.TabIndex = 16
        '
        'ucrFillOrColourReceiver
        '
        Me.ucrFillOrColourReceiver.AutoSize = True
        Me.ucrFillOrColourReceiver.frmParent = Me
        Me.ucrFillOrColourReceiver.Location = New System.Drawing.Point(252, 138)
        Me.ucrFillOrColourReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFillOrColourReceiver.Name = "ucrFillOrColourReceiver"
        Me.ucrFillOrColourReceiver.Selector = Nothing
        Me.ucrFillOrColourReceiver.Size = New System.Drawing.Size(125, 25)
        Me.ucrFillOrColourReceiver.strNcFilePath = ""
        Me.ucrFillOrColourReceiver.TabIndex = 6
        Me.ucrFillOrColourReceiver.ucrSelector = Nothing
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.AutoSize = True
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(252, 95)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(125, 27)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 4
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrGraphicsSelector
        '
        Me.ucrGraphicsSelector.AutoSize = True
        Me.ucrGraphicsSelector.bDropUnusedFilterLevels = False
        Me.ucrGraphicsSelector.bShowHiddenColumns = False
        Me.ucrGraphicsSelector.bUseCurrentFilter = True
        Me.ucrGraphicsSelector.Location = New System.Drawing.Point(6, 14)
        Me.ucrGraphicsSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrGraphicsSelector.Name = "ucrGraphicsSelector"
        Me.ucrGraphicsSelector.Size = New System.Drawing.Size(226, 195)
        Me.ucrGraphicsSelector.TabIndex = 0
        '
        'ucrAdditionalLayers
        '
        Me.ucrAdditionalLayers.AutoSize = True
        Me.ucrAdditionalLayers.Location = New System.Drawing.Point(6, 213)
        Me.ucrAdditionalLayers.Name = "ucrAdditionalLayers"
        Me.ucrAdditionalLayers.Size = New System.Drawing.Size(218, 182)
        Me.ucrAdditionalLayers.TabIndex = 8
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(6, 464)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 9
        '
        'dlgGeneralForGraphics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(416, 519)
        Me.Controls.Add(Me.ucrInputLegendPosition)
        Me.Controls.Add(Me.ucrReceiverY)
        Me.Controls.Add(Me.lblYVariable)
        Me.Controls.Add(Me.ucrChkFlipCoordinates)
        Me.Controls.Add(Me.ucrChkLegend)
        Me.Controls.Add(Me.cmdTitles)
        Me.Controls.Add(Me.cmdXAxis)
        Me.Controls.Add(Me.cmdYAxis)
        Me.Controls.Add(Me.cmdTheme)
        Me.Controls.Add(Me.cmdFacets)
        Me.Controls.Add(Me.ucrSave)
        Me.Controls.Add(Me.lblFillOrColor)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.ucrFillOrColourReceiver)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.ucrGraphicsSelector)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrAdditionalLayers)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgGeneralForGraphics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "General "
        Me.Text = "General Graphics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAdditionalLayers As ucrAdditionalLayers
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrGraphicsSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrFillOrColourReceiver As ucrReceiverSingle
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents lblXVariable As Label
    Friend WithEvents lblFillOrColor As Label
    Friend WithEvents ucrSave As ucrSave
    Friend WithEvents cmdTheme As Button
    Friend WithEvents cmdFacets As Button
    Friend WithEvents cmdTitles As Button
    Friend WithEvents cmdXAxis As Button
    Friend WithEvents cmdYAxis As Button
    Friend WithEvents ucrChkLegend As ucrCheck
    Friend WithEvents ucrChkFlipCoordinates As ucrCheck
    Friend WithEvents lblYVariable As Label
    Friend WithEvents ucrReceiverY As ucrReceiverSingle
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
End Class
