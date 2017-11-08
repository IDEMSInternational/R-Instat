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
Partial Class sdgPlots
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgPlots))
        Me.tbpPlotsOptions = New System.Windows.Forms.TabControl()
        Me.tbpFacet = New System.Windows.Forms.TabPage()
        Me.ucrNudNumberofRows = New instat.ucrNud()
        Me.ucrChkNoOfRowsOrColumns = New instat.ucrCheck()
        Me.ucrChkIncludeFacets = New instat.ucrCheck()
        Me.ucrChkFreeSpace = New instat.ucrCheck()
        Me.ucrChkFreeScalesY = New instat.ucrCheck()
        Me.ucrChkFreeScalesX = New instat.ucrCheck()
        Me.ucrChkMargin = New instat.ucrCheck()
        Me.ucrFacetSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.rdoHorizontal = New System.Windows.Forms.RadioButton()
        Me.rdoVertical = New System.Windows.Forms.RadioButton()
        Me.lblFactor2 = New System.Windows.Forms.Label()
        Me.lblFactor1 = New System.Windows.Forms.Label()
        Me.ucr2ndFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucr1stFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrPnlHorizonatalVertical = New instat.UcrPanel()
        Me.tbpLayers = New System.Windows.Forms.TabPage()
        Me.ucrPlotsAdditionalLayers = New instat.ucrAdditionalLayers()
        Me.tbpTitles = New System.Windows.Forms.TabPage()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpLegendTitle = New System.Windows.Forms.GroupBox()
        Me.ucrChkOverwriteLegendTitle = New instat.ucrCheck()
        Me.ucrChkDisplayLegendTitle = New instat.ucrCheck()
        Me.ucrInputLegend = New instat.ucrInputTextBox()
        Me.rdoLegendTitleCustom = New System.Windows.Forms.RadioButton()
        Me.rdoLegendTitleAuto = New System.Windows.Forms.RadioButton()
        Me.ucrPnlLegendTitle = New instat.UcrPanel()
        Me.ucrInputGraphCaption = New instat.ucrInputTextBox()
        Me.ucrInputGraphSubTitle = New instat.ucrInputTextBox()
        Me.ucrInputGraphTitle = New instat.ucrInputTextBox()
        Me.tbpXAxis = New System.Windows.Forms.TabPage()
        Me.ucrXAxis = New instat.ucrAxes()
        Me.tbpYAxis = New System.Windows.Forms.TabPage()
        Me.ucrYAxis = New instat.ucrAxes()
        Me.tbpTheme = New System.Windows.Forms.TabPage()
        Me.urChkSelectTheme = New instat.ucrCheck()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFont = New System.Windows.Forms.Label()
        Me.cmdAllOptions = New System.Windows.Forms.Button()
        Me.ucrInputThemes = New instat.ucrInputComboBox()
        Me.tbpCoordinates = New System.Windows.Forms.TabPage()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.tbpPlotsOptions.SuspendLayout()
        Me.tbpFacet.SuspendLayout()
        Me.tbpLayers.SuspendLayout()
        Me.tbpTitles.SuspendLayout()
        Me.grpLegendTitle.SuspendLayout()
        Me.tbpXAxis.SuspendLayout()
        Me.tbpYAxis.SuspendLayout()
        Me.tbpTheme.SuspendLayout()
        Me.tbpCoordinates.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpPlotsOptions
        '
        Me.tbpPlotsOptions.Controls.Add(Me.tbpFacet)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpLayers)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpTitles)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpXAxis)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpYAxis)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpTheme)
        Me.tbpPlotsOptions.Controls.Add(Me.tbpCoordinates)
        resources.ApplyResources(Me.tbpPlotsOptions, "tbpPlotsOptions")
        Me.tbpPlotsOptions.Name = "tbpPlotsOptions"
        Me.tbpPlotsOptions.SelectedIndex = 0
        '
        'tbpFacet
        '
        Me.tbpFacet.Controls.Add(Me.ucrNudNumberofRows)
        Me.tbpFacet.Controls.Add(Me.ucrChkNoOfRowsOrColumns)
        Me.tbpFacet.Controls.Add(Me.ucrChkIncludeFacets)
        Me.tbpFacet.Controls.Add(Me.ucrChkFreeSpace)
        Me.tbpFacet.Controls.Add(Me.ucrChkFreeScalesY)
        Me.tbpFacet.Controls.Add(Me.ucrChkFreeScalesX)
        Me.tbpFacet.Controls.Add(Me.ucrChkMargin)
        Me.tbpFacet.Controls.Add(Me.ucrFacetSelector)
        Me.tbpFacet.Controls.Add(Me.rdoHorizontal)
        Me.tbpFacet.Controls.Add(Me.rdoVertical)
        Me.tbpFacet.Controls.Add(Me.lblFactor2)
        Me.tbpFacet.Controls.Add(Me.lblFactor1)
        Me.tbpFacet.Controls.Add(Me.ucr2ndFactorReceiver)
        Me.tbpFacet.Controls.Add(Me.ucr1stFactorReceiver)
        Me.tbpFacet.Controls.Add(Me.ucrPnlHorizonatalVertical)
        resources.ApplyResources(Me.tbpFacet, "tbpFacet")
        Me.tbpFacet.Name = "tbpFacet"
        Me.tbpFacet.Tag = "Facet"
        Me.tbpFacet.UseVisualStyleBackColor = True
        '
        'ucrNudNumberofRows
        '
        Me.ucrNudNumberofRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudNumberofRows, "ucrNudNumberofRows")
        Me.ucrNudNumberofRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberofRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofRows.Name = "ucrNudNumberofRows"
        Me.ucrNudNumberofRows.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkNoOfRowsOrColumns
        '
        Me.ucrChkNoOfRowsOrColumns.Checked = False
        resources.ApplyResources(Me.ucrChkNoOfRowsOrColumns, "ucrChkNoOfRowsOrColumns")
        Me.ucrChkNoOfRowsOrColumns.Name = "ucrChkNoOfRowsOrColumns"
        '
        'ucrChkIncludeFacets
        '
        Me.ucrChkIncludeFacets.Checked = False
        resources.ApplyResources(Me.ucrChkIncludeFacets, "ucrChkIncludeFacets")
        Me.ucrChkIncludeFacets.Name = "ucrChkIncludeFacets"
        '
        'ucrChkFreeSpace
        '
        Me.ucrChkFreeSpace.Checked = False
        resources.ApplyResources(Me.ucrChkFreeSpace, "ucrChkFreeSpace")
        Me.ucrChkFreeSpace.Name = "ucrChkFreeSpace"
        '
        'ucrChkFreeScalesY
        '
        Me.ucrChkFreeScalesY.Checked = False
        resources.ApplyResources(Me.ucrChkFreeScalesY, "ucrChkFreeScalesY")
        Me.ucrChkFreeScalesY.Name = "ucrChkFreeScalesY"
        '
        'ucrChkFreeScalesX
        '
        Me.ucrChkFreeScalesX.Checked = False
        resources.ApplyResources(Me.ucrChkFreeScalesX, "ucrChkFreeScalesX")
        Me.ucrChkFreeScalesX.Name = "ucrChkFreeScalesX"
        '
        'ucrChkMargin
        '
        Me.ucrChkMargin.Checked = False
        resources.ApplyResources(Me.ucrChkMargin, "ucrChkMargin")
        Me.ucrChkMargin.Name = "ucrChkMargin"
        '
        'ucrFacetSelector
        '
        Me.ucrFacetSelector.bShowHiddenColumns = False
        Me.ucrFacetSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrFacetSelector, "ucrFacetSelector")
        Me.ucrFacetSelector.Name = "ucrFacetSelector"
        '
        'rdoHorizontal
        '
        resources.ApplyResources(Me.rdoHorizontal, "rdoHorizontal")
        Me.rdoHorizontal.Name = "rdoHorizontal"
        Me.rdoHorizontal.TabStop = True
        Me.rdoHorizontal.Tag = "Horizontal"
        Me.rdoHorizontal.UseVisualStyleBackColor = True
        '
        'rdoVertical
        '
        resources.ApplyResources(Me.rdoVertical, "rdoVertical")
        Me.rdoVertical.Name = "rdoVertical"
        Me.rdoVertical.TabStop = True
        Me.rdoVertical.Tag = "Vertical"
        Me.rdoVertical.UseVisualStyleBackColor = True
        '
        'lblFactor2
        '
        resources.ApplyResources(Me.lblFactor2, "lblFactor2")
        Me.lblFactor2.Name = "lblFactor2"
        '
        'lblFactor1
        '
        resources.ApplyResources(Me.lblFactor1, "lblFactor1")
        Me.lblFactor1.Name = "lblFactor1"
        Me.lblFactor1.Tag = ""
        '
        'ucr2ndFactorReceiver
        '
        Me.ucr2ndFactorReceiver.frmParent = Nothing
        resources.ApplyResources(Me.ucr2ndFactorReceiver, "ucr2ndFactorReceiver")
        Me.ucr2ndFactorReceiver.Name = "ucr2ndFactorReceiver"
        Me.ucr2ndFactorReceiver.Selector = Nothing
        Me.ucr2ndFactorReceiver.strNcFilePath = ""
        Me.ucr2ndFactorReceiver.ucrSelector = Nothing
        '
        'ucr1stFactorReceiver
        '
        Me.ucr1stFactorReceiver.frmParent = Nothing
        resources.ApplyResources(Me.ucr1stFactorReceiver, "ucr1stFactorReceiver")
        Me.ucr1stFactorReceiver.Name = "ucr1stFactorReceiver"
        Me.ucr1stFactorReceiver.Selector = Nothing
        Me.ucr1stFactorReceiver.strNcFilePath = ""
        Me.ucr1stFactorReceiver.ucrSelector = Nothing
        '
        'ucrPnlHorizonatalVertical
        '
        resources.ApplyResources(Me.ucrPnlHorizonatalVertical, "ucrPnlHorizonatalVertical")
        Me.ucrPnlHorizonatalVertical.Name = "ucrPnlHorizonatalVertical"
        '
        'tbpLayers
        '
        Me.tbpLayers.Controls.Add(Me.ucrPlotsAdditionalLayers)
        resources.ApplyResources(Me.tbpLayers, "tbpLayers")
        Me.tbpLayers.Name = "tbpLayers"
        Me.tbpLayers.Tag = "Layers"
        Me.tbpLayers.UseVisualStyleBackColor = True
        '
        'ucrPlotsAdditionalLayers
        '
        resources.ApplyResources(Me.ucrPlotsAdditionalLayers, "ucrPlotsAdditionalLayers")
        Me.ucrPlotsAdditionalLayers.Name = "ucrPlotsAdditionalLayers"
        '
        'tbpTitles
        '
        Me.tbpTitles.Controls.Add(Me.lblCaption)
        Me.tbpTitles.Controls.Add(Me.lblSubTitle)
        Me.tbpTitles.Controls.Add(Me.Label1)
        Me.tbpTitles.Controls.Add(Me.grpLegendTitle)
        Me.tbpTitles.Controls.Add(Me.ucrInputGraphCaption)
        Me.tbpTitles.Controls.Add(Me.ucrInputGraphSubTitle)
        Me.tbpTitles.Controls.Add(Me.ucrInputGraphTitle)
        resources.ApplyResources(Me.tbpTitles, "tbpTitles")
        Me.tbpTitles.Name = "tbpTitles"
        Me.tbpTitles.Tag = "Titles"
        Me.tbpTitles.UseVisualStyleBackColor = True
        '
        'lblCaption
        '
        resources.ApplyResources(Me.lblCaption, "lblCaption")
        Me.lblCaption.Name = "lblCaption"
        '
        'lblSubTitle
        '
        resources.ApplyResources(Me.lblSubTitle, "lblSubTitle")
        Me.lblSubTitle.Name = "lblSubTitle"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'grpLegendTitle
        '
        Me.grpLegendTitle.Controls.Add(Me.ucrChkOverwriteLegendTitle)
        Me.grpLegendTitle.Controls.Add(Me.ucrChkDisplayLegendTitle)
        Me.grpLegendTitle.Controls.Add(Me.ucrInputLegend)
        Me.grpLegendTitle.Controls.Add(Me.rdoLegendTitleCustom)
        Me.grpLegendTitle.Controls.Add(Me.rdoLegendTitleAuto)
        Me.grpLegendTitle.Controls.Add(Me.ucrPnlLegendTitle)
        resources.ApplyResources(Me.grpLegendTitle, "grpLegendTitle")
        Me.grpLegendTitle.Name = "grpLegendTitle"
        Me.grpLegendTitle.TabStop = False
        '
        'ucrChkOverwriteLegendTitle
        '
        Me.ucrChkOverwriteLegendTitle.Checked = False
        resources.ApplyResources(Me.ucrChkOverwriteLegendTitle, "ucrChkOverwriteLegendTitle")
        Me.ucrChkOverwriteLegendTitle.Name = "ucrChkOverwriteLegendTitle"
        '
        'ucrChkDisplayLegendTitle
        '
        Me.ucrChkDisplayLegendTitle.Checked = False
        resources.ApplyResources(Me.ucrChkDisplayLegendTitle, "ucrChkDisplayLegendTitle")
        Me.ucrChkDisplayLegendTitle.Name = "ucrChkDisplayLegendTitle"
        '
        'ucrInputLegend
        '
        Me.ucrInputLegend.AddQuotesIfUnrecognised = True
        Me.ucrInputLegend.IsMultiline = False
        Me.ucrInputLegend.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLegend, "ucrInputLegend")
        Me.ucrInputLegend.Name = "ucrInputLegend"
        '
        'rdoLegendTitleCustom
        '
        resources.ApplyResources(Me.rdoLegendTitleCustom, "rdoLegendTitleCustom")
        Me.rdoLegendTitleCustom.Name = "rdoLegendTitleCustom"
        Me.rdoLegendTitleCustom.TabStop = True
        Me.rdoLegendTitleCustom.UseVisualStyleBackColor = True
        '
        'rdoLegendTitleAuto
        '
        resources.ApplyResources(Me.rdoLegendTitleAuto, "rdoLegendTitleAuto")
        Me.rdoLegendTitleAuto.Name = "rdoLegendTitleAuto"
        Me.rdoLegendTitleAuto.TabStop = True
        Me.rdoLegendTitleAuto.UseVisualStyleBackColor = True
        '
        'ucrPnlLegendTitle
        '
        resources.ApplyResources(Me.ucrPnlLegendTitle, "ucrPnlLegendTitle")
        Me.ucrPnlLegendTitle.Name = "ucrPnlLegendTitle"
        '
        'ucrInputGraphCaption
        '
        Me.ucrInputGraphCaption.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphCaption.IsMultiline = False
        Me.ucrInputGraphCaption.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputGraphCaption, "ucrInputGraphCaption")
        Me.ucrInputGraphCaption.Name = "ucrInputGraphCaption"
        '
        'ucrInputGraphSubTitle
        '
        Me.ucrInputGraphSubTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphSubTitle.IsMultiline = False
        Me.ucrInputGraphSubTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputGraphSubTitle, "ucrInputGraphSubTitle")
        Me.ucrInputGraphSubTitle.Name = "ucrInputGraphSubTitle"
        '
        'ucrInputGraphTitle
        '
        Me.ucrInputGraphTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphTitle.IsMultiline = False
        Me.ucrInputGraphTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputGraphTitle, "ucrInputGraphTitle")
        Me.ucrInputGraphTitle.Name = "ucrInputGraphTitle"
        '
        'tbpXAxis
        '
        Me.tbpXAxis.Controls.Add(Me.ucrXAxis)
        resources.ApplyResources(Me.tbpXAxis, "tbpXAxis")
        Me.tbpXAxis.Name = "tbpXAxis"
        Me.tbpXAxis.UseVisualStyleBackColor = True
        '
        'ucrXAxis
        '
        resources.ApplyResources(Me.ucrXAxis, "ucrXAxis")
        Me.ucrXAxis.Name = "ucrXAxis"
        '
        'tbpYAxis
        '
        Me.tbpYAxis.Controls.Add(Me.ucrYAxis)
        resources.ApplyResources(Me.tbpYAxis, "tbpYAxis")
        Me.tbpYAxis.Name = "tbpYAxis"
        Me.tbpYAxis.UseVisualStyleBackColor = True
        '
        'ucrYAxis
        '
        resources.ApplyResources(Me.ucrYAxis, "ucrYAxis")
        Me.ucrYAxis.Name = "ucrYAxis"
        '
        'tbpTheme
        '
        Me.tbpTheme.Controls.Add(Me.urChkSelectTheme)
        Me.tbpTheme.Controls.Add(Me.GroupBox1)
        Me.tbpTheme.Controls.Add(Me.lblFont)
        Me.tbpTheme.Controls.Add(Me.cmdAllOptions)
        Me.tbpTheme.Controls.Add(Me.ucrInputThemes)
        resources.ApplyResources(Me.tbpTheme, "tbpTheme")
        Me.tbpTheme.Name = "tbpTheme"
        Me.tbpTheme.Tag = "Theme"
        Me.tbpTheme.UseVisualStyleBackColor = True
        '
        'urChkSelectTheme
        '
        Me.urChkSelectTheme.Checked = False
        resources.ApplyResources(Me.urChkSelectTheme, "urChkSelectTheme")
        Me.urChkSelectTheme.Name = "urChkSelectTheme"
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'lblFont
        '
        resources.ApplyResources(Me.lblFont, "lblFont")
        Me.lblFont.Name = "lblFont"
        '
        'cmdAllOptions
        '
        resources.ApplyResources(Me.cmdAllOptions, "cmdAllOptions")
        Me.cmdAllOptions.Name = "cmdAllOptions"
        Me.cmdAllOptions.UseVisualStyleBackColor = True
        '
        'ucrInputThemes
        '
        Me.ucrInputThemes.AddQuotesIfUnrecognised = True
        Me.ucrInputThemes.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputThemes, "ucrInputThemes")
        Me.ucrInputThemes.Name = "ucrInputThemes"
        '
        'tbpCoordinates
        '
        Me.tbpCoordinates.Controls.Add(Me.lblWarning)
        resources.ApplyResources(Me.tbpCoordinates, "tbpCoordinates")
        Me.tbpCoordinates.Name = "tbpCoordinates"
        Me.tbpCoordinates.UseVisualStyleBackColor = True
        '
        'lblWarning
        '
        resources.ApplyResources(Me.lblWarning, "lblWarning")
        Me.lblWarning.Name = "lblWarning"
        '
        'ucrBaseSubdialog
        '
        resources.ApplyResources(Me.ucrBaseSubdialog, "ucrBaseSubdialog")
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        '
        'sdgPlots
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.Controls.Add(Me.tbpPlotsOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgPlots"
        Me.Tag = "Plot_Options"
        Me.TopMost = True
        Me.tbpPlotsOptions.ResumeLayout(False)
        Me.tbpFacet.ResumeLayout(False)
        Me.tbpFacet.PerformLayout()
        Me.tbpLayers.ResumeLayout(False)
        Me.tbpTitles.ResumeLayout(False)
        Me.tbpTitles.PerformLayout()
        Me.grpLegendTitle.ResumeLayout(False)
        Me.grpLegendTitle.PerformLayout()
        Me.tbpXAxis.ResumeLayout(False)
        Me.tbpYAxis.ResumeLayout(False)
        Me.tbpTheme.ResumeLayout(False)
        Me.tbpTheme.PerformLayout()
        Me.tbpCoordinates.ResumeLayout(False)
        Me.tbpCoordinates.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbpPlotsOptions As TabControl
    Friend WithEvents tbpTheme As TabPage
    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents tbpTitles As TabPage
    Friend WithEvents tbpFacet As TabPage
    Friend WithEvents tbpLayers As TabPage
    Friend WithEvents rdoHorizontal As RadioButton
    Friend WithEvents rdoVertical As RadioButton
    Friend WithEvents lblFactor2 As Label
    Friend WithEvents lblFactor1 As Label
    Friend WithEvents ucr2ndFactorReceiver As ucrReceiverSingle
    Friend WithEvents ucr1stFactorReceiver As ucrReceiverSingle
    Friend WithEvents tbpXAxis As TabPage
    Friend WithEvents tbpYAxis As TabPage
    Friend WithEvents ucrInputThemes As ucrInputComboBox
    Friend WithEvents cmdAllOptions As Button
    Friend WithEvents lblFont As Label
    Friend WithEvents ucrPlotsAdditionalLayers As ucrAdditionalLayers
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ucrFacetSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpLegendTitle As GroupBox
    Friend WithEvents rdoLegendTitleCustom As RadioButton
    Friend WithEvents rdoLegendTitleAuto As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrInputGraphTitle As ucrInputTextBox
    Friend WithEvents ucrXAxis As ucrAxes
    Friend WithEvents ucrYAxis As ucrAxes
    Friend WithEvents ucrInputLegend As ucrInputTextBox
    Friend WithEvents tbpCoordinates As TabPage
    Friend WithEvents lblWarning As Label
    Friend WithEvents ucrChkNoOfRowsOrColumns As ucrCheck
    Friend WithEvents ucrChkIncludeFacets As ucrCheck
    Friend WithEvents ucrChkFreeSpace As ucrCheck
    Friend WithEvents ucrChkFreeScalesY As ucrCheck
    Friend WithEvents ucrChkFreeScalesX As ucrCheck
    Friend WithEvents ucrChkMargin As ucrCheck
    Friend WithEvents ucrPnlHorizonatalVertical As UcrPanel
    Friend WithEvents ucrNudNumberofRows As ucrNud
    Friend WithEvents ucrPnlLegendTitle As UcrPanel
    Friend WithEvents ucrChkDisplayLegendTitle As ucrCheck
    Friend WithEvents ucrChkOverwriteLegendTitle As ucrCheck
    Friend WithEvents lblCaption As Label
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents ucrInputGraphCaption As ucrInputTextBox
    Friend WithEvents ucrInputGraphSubTitle As ucrInputTextBox
    Friend WithEvents urChkSelectTheme As ucrCheck
End Class


