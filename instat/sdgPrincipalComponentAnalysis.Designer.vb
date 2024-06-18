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
Partial Class sdgPrincipalComponentAnalysis
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
        Me.tbRegOptions = New System.Windows.Forms.TabControl()
        Me.tbGraphics = New System.Windows.Forms.TabPage()
        Me.rdoBarPlot = New System.Windows.Forms.RadioButton()
        Me.rdoIndividualsPlot = New System.Windows.Forms.RadioButton()
        Me.grpScree = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.lblFactorVariable = New System.Windows.Forms.Label()
        Me.grpVariablePlot = New System.Windows.Forms.GroupBox()
        Me.rdoTextVariables = New System.Windows.Forms.RadioButton()
        Me.rdoArrow = New System.Windows.Forms.RadioButton()
        Me.rdoBothVariables = New System.Windows.Forms.RadioButton()
        Me.ucrPnlVariablesPlot = New instat.UcrPanel()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.GrpIndividualPlot = New System.Windows.Forms.GroupBox()
        Me.rdoTextIndividual = New System.Windows.Forms.RadioButton()
        Me.rdoPoint = New System.Windows.Forms.RadioButton()
        Me.rdoBothIndividual = New System.Windows.Forms.RadioButton()
        Me.ucrPnlIndividualPlot = New instat.UcrPanel()
        Me.lblChoice = New System.Windows.Forms.Label()
        Me.ucrChkIncludePercentage = New instat.ucrCheck()
        Me.ucrNudDim2 = New instat.ucrNud()
        Me.ucrNudDim1 = New instat.ucrNud()
        Me.grpGeom = New System.Windows.Forms.GroupBox()
        Me.rdoBar = New System.Windows.Forms.RadioButton()
        Me.rdoLine = New System.Windows.Forms.RadioButton()
        Me.rdoBothScree = New System.Windows.Forms.RadioButton()
        Me.ucrPnlScreePlot = New instat.UcrPanel()
        Me.lblChoiceScree = New System.Windows.Forms.Label()
        Me.lblDim = New System.Windows.Forms.Label()
        Me.ucrInputLabel2 = New instat.ucrInputComboBox()
        Me.ucrInputLabel1 = New instat.ucrInputComboBox()
        Me.ucrSelectorFactor = New instat.ucrSelectorByDataFrameAddRemove()
        Me.rdoBiplot = New System.Windows.Forms.RadioButton()
        Me.rdoVariablesPlot = New System.Windows.Forms.RadioButton()
        Me.rdoScreePlot = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGraphics = New instat.UcrPanel()
        Me.tbSave = New System.Windows.Forms.TabPage()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.tbRegOptions.SuspendLayout()
        Me.tbGraphics.SuspendLayout()
        Me.grpScree.SuspendLayout()
        Me.grpVariablePlot.SuspendLayout()
        Me.GrpIndividualPlot.SuspendLayout()
        Me.grpGeom.SuspendLayout()
        Me.tbSave.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbRegOptions
        '
        Me.tbRegOptions.Controls.Add(Me.tbGraphics)
        Me.tbRegOptions.Controls.Add(Me.tbSave)
        Me.tbRegOptions.Location = New System.Drawing.Point(9, 10)
        Me.tbRegOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.tbRegOptions.Name = "tbRegOptions"
        Me.tbRegOptions.SelectedIndex = 0
        Me.tbRegOptions.Size = New System.Drawing.Size(616, 558)
        Me.tbRegOptions.TabIndex = 0
        '
        'tbGraphics
        '
        Me.tbGraphics.Controls.Add(Me.rdoBarPlot)
        Me.tbGraphics.Controls.Add(Me.rdoIndividualsPlot)
        Me.tbGraphics.Controls.Add(Me.grpScree)
        Me.tbGraphics.Controls.Add(Me.rdoBiplot)
        Me.tbGraphics.Controls.Add(Me.rdoVariablesPlot)
        Me.tbGraphics.Controls.Add(Me.rdoScreePlot)
        Me.tbGraphics.Controls.Add(Me.ucrPnlGraphics)
        Me.tbGraphics.Location = New System.Drawing.Point(4, 29)
        Me.tbGraphics.Margin = New System.Windows.Forms.Padding(4)
        Me.tbGraphics.Name = "tbGraphics"
        Me.tbGraphics.Padding = New System.Windows.Forms.Padding(4)
        Me.tbGraphics.Size = New System.Drawing.Size(608, 525)
        Me.tbGraphics.TabIndex = 1
        Me.tbGraphics.Tag = "Graphics"
        Me.tbGraphics.Text = "Graphics"
        Me.tbGraphics.UseVisualStyleBackColor = True
        '
        'rdoBarPlot
        '
        Me.rdoBarPlot.AutoSize = True
        Me.rdoBarPlot.Location = New System.Drawing.Point(15, 159)
        Me.rdoBarPlot.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoBarPlot.Name = "rdoBarPlot"
        Me.rdoBarPlot.Size = New System.Drawing.Size(89, 24)
        Me.rdoBarPlot.TabIndex = 5
        Me.rdoBarPlot.Tag = "Bar plot"
        Me.rdoBarPlot.Text = "Bar plot"
        Me.rdoBarPlot.UseVisualStyleBackColor = True
        '
        'rdoIndividualsPlot
        '
        Me.rdoIndividualsPlot.AutoSize = True
        Me.rdoIndividualsPlot.Location = New System.Drawing.Point(15, 90)
        Me.rdoIndividualsPlot.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoIndividualsPlot.Name = "rdoIndividualsPlot"
        Me.rdoIndividualsPlot.Size = New System.Drawing.Size(139, 24)
        Me.rdoIndividualsPlot.TabIndex = 3
        Me.rdoIndividualsPlot.Tag = "Individuals_Plot"
        Me.rdoIndividualsPlot.Text = "Individuals Plot"
        Me.rdoIndividualsPlot.UseVisualStyleBackColor = True
        '
        'grpScree
        '
        Me.grpScree.Controls.Add(Me.ucrReceiverFactor)
        Me.grpScree.Controls.Add(Me.lblFactorVariable)
        Me.grpScree.Controls.Add(Me.grpVariablePlot)
        Me.grpScree.Controls.Add(Me.lblLabel)
        Me.grpScree.Controls.Add(Me.GrpIndividualPlot)
        Me.grpScree.Controls.Add(Me.lblChoice)
        Me.grpScree.Controls.Add(Me.ucrChkIncludePercentage)
        Me.grpScree.Controls.Add(Me.ucrNudDim2)
        Me.grpScree.Controls.Add(Me.ucrNudDim1)
        Me.grpScree.Controls.Add(Me.grpGeom)
        Me.grpScree.Controls.Add(Me.lblChoiceScree)
        Me.grpScree.Controls.Add(Me.lblDim)
        Me.grpScree.Controls.Add(Me.ucrInputLabel2)
        Me.grpScree.Controls.Add(Me.ucrInputLabel1)
        Me.grpScree.Controls.Add(Me.ucrSelectorFactor)
        Me.grpScree.Location = New System.Drawing.Point(12, 196)
        Me.grpScree.Margin = New System.Windows.Forms.Padding(4)
        Me.grpScree.Name = "grpScree"
        Me.grpScree.Padding = New System.Windows.Forms.Padding(4)
        Me.grpScree.Size = New System.Drawing.Size(580, 312)
        Me.grpScree.TabIndex = 0
        Me.grpScree.TabStop = False
        Me.grpScree.Text = "Plot Options"
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.AutoSize = True
        Me.ucrReceiverFactor.frmParent = Nothing
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(350, 104)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.TabIndex = 4
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'lblFactorVariable
        '
        Me.lblFactorVariable.AutoSize = True
        Me.lblFactorVariable.Location = New System.Drawing.Point(348, 81)
        Me.lblFactorVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFactorVariable.Name = "lblFactorVariable"
        Me.lblFactorVariable.Size = New System.Drawing.Size(121, 20)
        Me.lblFactorVariable.TabIndex = 5
        Me.lblFactorVariable.Tag = "Factor_Variable"
        Me.lblFactorVariable.Text = "Factor Variable:"
        '
        'grpVariablePlot
        '
        Me.grpVariablePlot.Controls.Add(Me.rdoTextVariables)
        Me.grpVariablePlot.Controls.Add(Me.rdoArrow)
        Me.grpVariablePlot.Controls.Add(Me.rdoBothVariables)
        Me.grpVariablePlot.Controls.Add(Me.ucrPnlVariablesPlot)
        Me.grpVariablePlot.Location = New System.Drawing.Point(9, 28)
        Me.grpVariablePlot.Margin = New System.Windows.Forms.Padding(4)
        Me.grpVariablePlot.Name = "grpVariablePlot"
        Me.grpVariablePlot.Padding = New System.Windows.Forms.Padding(4)
        Me.grpVariablePlot.Size = New System.Drawing.Size(207, 140)
        Me.grpVariablePlot.TabIndex = 2
        Me.grpVariablePlot.TabStop = False
        Me.grpVariablePlot.Text = "Geom"
        '
        'rdoTextVariables
        '
        Me.rdoTextVariables.AutoSize = True
        Me.rdoTextVariables.Location = New System.Drawing.Point(21, 63)
        Me.rdoTextVariables.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoTextVariables.Name = "rdoTextVariables"
        Me.rdoTextVariables.Size = New System.Drawing.Size(64, 24)
        Me.rdoTextVariables.TabIndex = 2
        Me.rdoTextVariables.TabStop = True
        Me.rdoTextVariables.Text = "Text"
        Me.rdoTextVariables.UseVisualStyleBackColor = True
        '
        'rdoArrow
        '
        Me.rdoArrow.AutoSize = True
        Me.rdoArrow.Location = New System.Drawing.Point(21, 28)
        Me.rdoArrow.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoArrow.Name = "rdoArrow"
        Me.rdoArrow.Size = New System.Drawing.Size(75, 24)
        Me.rdoArrow.TabIndex = 1
        Me.rdoArrow.TabStop = True
        Me.rdoArrow.Text = "Arrow"
        Me.rdoArrow.UseVisualStyleBackColor = True
        '
        'rdoBothVariables
        '
        Me.rdoBothVariables.AutoSize = True
        Me.rdoBothVariables.Location = New System.Drawing.Point(21, 98)
        Me.rdoBothVariables.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoBothVariables.Name = "rdoBothVariables"
        Me.rdoBothVariables.Size = New System.Drawing.Size(68, 24)
        Me.rdoBothVariables.TabIndex = 3
        Me.rdoBothVariables.TabStop = True
        Me.rdoBothVariables.Text = "Both"
        Me.rdoBothVariables.UseVisualStyleBackColor = True
        '
        'ucrPnlVariablesPlot
        '
        Me.ucrPnlVariablesPlot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlVariablesPlot.Location = New System.Drawing.Point(10, 26)
        Me.ucrPnlVariablesPlot.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlVariablesPlot.Name = "ucrPnlVariablesPlot"
        Me.ucrPnlVariablesPlot.Size = New System.Drawing.Size(154, 105)
        Me.ucrPnlVariablesPlot.TabIndex = 0
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.Location = New System.Drawing.Point(9, 231)
        Me.lblLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(52, 20)
        Me.lblLabel.TabIndex = 13
        Me.lblLabel.Text = "Label:"
        '
        'GrpIndividualPlot
        '
        Me.GrpIndividualPlot.Controls.Add(Me.rdoTextIndividual)
        Me.GrpIndividualPlot.Controls.Add(Me.rdoPoint)
        Me.GrpIndividualPlot.Controls.Add(Me.rdoBothIndividual)
        Me.GrpIndividualPlot.Controls.Add(Me.ucrPnlIndividualPlot)
        Me.GrpIndividualPlot.Location = New System.Drawing.Point(9, 28)
        Me.GrpIndividualPlot.Margin = New System.Windows.Forms.Padding(4)
        Me.GrpIndividualPlot.Name = "GrpIndividualPlot"
        Me.GrpIndividualPlot.Padding = New System.Windows.Forms.Padding(4)
        Me.GrpIndividualPlot.Size = New System.Drawing.Size(207, 140)
        Me.GrpIndividualPlot.TabIndex = 1
        Me.GrpIndividualPlot.TabStop = False
        Me.GrpIndividualPlot.Text = "Geom"
        '
        'rdoTextIndividual
        '
        Me.rdoTextIndividual.AutoSize = True
        Me.rdoTextIndividual.Location = New System.Drawing.Point(21, 63)
        Me.rdoTextIndividual.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoTextIndividual.Name = "rdoTextIndividual"
        Me.rdoTextIndividual.Size = New System.Drawing.Size(64, 24)
        Me.rdoTextIndividual.TabIndex = 2
        Me.rdoTextIndividual.TabStop = True
        Me.rdoTextIndividual.Text = "Text"
        Me.rdoTextIndividual.UseVisualStyleBackColor = True
        '
        'rdoPoint
        '
        Me.rdoPoint.AutoSize = True
        Me.rdoPoint.Location = New System.Drawing.Point(21, 28)
        Me.rdoPoint.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoPoint.Name = "rdoPoint"
        Me.rdoPoint.Size = New System.Drawing.Size(70, 24)
        Me.rdoPoint.TabIndex = 1
        Me.rdoPoint.TabStop = True
        Me.rdoPoint.Text = "Point"
        Me.rdoPoint.UseVisualStyleBackColor = True
        '
        'rdoBothIndividual
        '
        Me.rdoBothIndividual.AutoSize = True
        Me.rdoBothIndividual.Location = New System.Drawing.Point(21, 98)
        Me.rdoBothIndividual.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoBothIndividual.Name = "rdoBothIndividual"
        Me.rdoBothIndividual.Size = New System.Drawing.Size(68, 24)
        Me.rdoBothIndividual.TabIndex = 3
        Me.rdoBothIndividual.TabStop = True
        Me.rdoBothIndividual.Text = "Both"
        Me.rdoBothIndividual.UseVisualStyleBackColor = True
        '
        'ucrPnlIndividualPlot
        '
        Me.ucrPnlIndividualPlot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlIndividualPlot.Location = New System.Drawing.Point(14, 27)
        Me.ucrPnlIndividualPlot.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlIndividualPlot.Name = "ucrPnlIndividualPlot"
        Me.ucrPnlIndividualPlot.Size = New System.Drawing.Size(132, 104)
        Me.ucrPnlIndividualPlot.TabIndex = 0
        '
        'lblChoice
        '
        Me.lblChoice.AutoSize = True
        Me.lblChoice.Location = New System.Drawing.Point(9, 231)
        Me.lblChoice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblChoice.Name = "lblChoice"
        Me.lblChoice.Size = New System.Drawing.Size(62, 20)
        Me.lblChoice.TabIndex = 11
        Me.lblChoice.Text = "Choice:"
        '
        'ucrChkIncludePercentage
        '
        Me.ucrChkIncludePercentage.AutoSize = True
        Me.ucrChkIncludePercentage.Checked = False
        Me.ucrChkIncludePercentage.Location = New System.Drawing.Point(9, 183)
        Me.ucrChkIncludePercentage.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkIncludePercentage.Name = "ucrChkIncludePercentage"
        Me.ucrChkIncludePercentage.Size = New System.Drawing.Size(237, 34)
        Me.ucrChkIncludePercentage.TabIndex = 6
        '
        'ucrNudDim2
        '
        Me.ucrNudDim2.AutoSize = True
        Me.ucrNudDim2.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDim2.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDim2.Location = New System.Drawing.Point(352, 183)
        Me.ucrNudDim2.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudDim2.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDim2.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDim2.Name = "ucrNudDim2"
        Me.ucrNudDim2.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudDim2.TabIndex = 10
        Me.ucrNudDim2.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDim1
        '
        Me.ucrNudDim1.AutoSize = True
        Me.ucrNudDim1.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDim1.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDim1.Location = New System.Drawing.Point(255, 183)
        Me.ucrNudDim1.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudDim1.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDim1.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDim1.Name = "ucrNudDim1"
        Me.ucrNudDim1.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudDim1.TabIndex = 8
        Me.ucrNudDim1.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'grpGeom
        '
        Me.grpGeom.Controls.Add(Me.rdoBar)
        Me.grpGeom.Controls.Add(Me.rdoLine)
        Me.grpGeom.Controls.Add(Me.rdoBothScree)
        Me.grpGeom.Controls.Add(Me.ucrPnlScreePlot)
        Me.grpGeom.Location = New System.Drawing.Point(9, 28)
        Me.grpGeom.Margin = New System.Windows.Forms.Padding(4)
        Me.grpGeom.Name = "grpGeom"
        Me.grpGeom.Padding = New System.Windows.Forms.Padding(4)
        Me.grpGeom.Size = New System.Drawing.Size(207, 140)
        Me.grpGeom.TabIndex = 0
        Me.grpGeom.TabStop = False
        Me.grpGeom.Tag = "Geom"
        Me.grpGeom.Text = "Geom"
        '
        'rdoBar
        '
        Me.rdoBar.AutoSize = True
        Me.rdoBar.Location = New System.Drawing.Point(21, 28)
        Me.rdoBar.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoBar.Name = "rdoBar"
        Me.rdoBar.Size = New System.Drawing.Size(59, 24)
        Me.rdoBar.TabIndex = 1
        Me.rdoBar.TabStop = True
        Me.rdoBar.Text = "Bar"
        Me.rdoBar.UseVisualStyleBackColor = True
        '
        'rdoLine
        '
        Me.rdoLine.AutoSize = True
        Me.rdoLine.Location = New System.Drawing.Point(21, 63)
        Me.rdoLine.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoLine.Name = "rdoLine"
        Me.rdoLine.Size = New System.Drawing.Size(64, 24)
        Me.rdoLine.TabIndex = 2
        Me.rdoLine.TabStop = True
        Me.rdoLine.Text = "Line"
        Me.rdoLine.UseVisualStyleBackColor = True
        '
        'rdoBothScree
        '
        Me.rdoBothScree.AutoSize = True
        Me.rdoBothScree.Location = New System.Drawing.Point(21, 98)
        Me.rdoBothScree.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoBothScree.Name = "rdoBothScree"
        Me.rdoBothScree.Size = New System.Drawing.Size(68, 24)
        Me.rdoBothScree.TabIndex = 3
        Me.rdoBothScree.TabStop = True
        Me.rdoBothScree.Text = "Both"
        Me.rdoBothScree.UseVisualStyleBackColor = True
        '
        'ucrPnlScreePlot
        '
        Me.ucrPnlScreePlot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlScreePlot.Location = New System.Drawing.Point(9, 28)
        Me.ucrPnlScreePlot.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlScreePlot.Name = "ucrPnlScreePlot"
        Me.ucrPnlScreePlot.Size = New System.Drawing.Size(126, 94)
        Me.ucrPnlScreePlot.TabIndex = 0
        '
        'lblChoiceScree
        '
        Me.lblChoiceScree.AutoSize = True
        Me.lblChoiceScree.Location = New System.Drawing.Point(20, 194)
        Me.lblChoiceScree.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblChoiceScree.Name = "lblChoiceScree"
        Me.lblChoiceScree.Size = New System.Drawing.Size(0, 20)
        Me.lblChoiceScree.TabIndex = 8
        Me.lblChoiceScree.Tag = "Choice:"
        '
        'lblDim
        '
        Me.lblDim.AutoSize = True
        Me.lblDim.Location = New System.Drawing.Point(9, 188)
        Me.lblDim.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDim.Name = "lblDim"
        Me.lblDim.Size = New System.Drawing.Size(145, 20)
        Me.lblDim.TabIndex = 7
        Me.lblDim.Text = "Dimensions to Plot:"
        '
        'ucrInputLabel2
        '
        Me.ucrInputLabel2.AddQuotesIfUnrecognised = True
        Me.ucrInputLabel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLabel2.GetSetSelectedIndex = -1
        Me.ucrInputLabel2.IsReadOnly = False
        Me.ucrInputLabel2.Location = New System.Drawing.Point(124, 222)
        Me.ucrInputLabel2.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputLabel2.Name = "ucrInputLabel2"
        Me.ucrInputLabel2.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputLabel2.TabIndex = 14
        '
        'ucrInputLabel1
        '
        Me.ucrInputLabel1.AddQuotesIfUnrecognised = True
        Me.ucrInputLabel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLabel1.GetSetSelectedIndex = -1
        Me.ucrInputLabel1.IsReadOnly = False
        Me.ucrInputLabel1.Location = New System.Drawing.Point(124, 222)
        Me.ucrInputLabel1.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputLabel1.Name = "ucrInputLabel1"
        Me.ucrInputLabel1.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputLabel1.TabIndex = 12
        '
        'ucrSelectorFactor
        '
        Me.ucrSelectorFactor.AutoSize = True
        Me.ucrSelectorFactor.bDropUnusedFilterLevels = False
        Me.ucrSelectorFactor.bShowHiddenColumns = False
        Me.ucrSelectorFactor.bUseCurrentFilter = True
        Me.ucrSelectorFactor.Location = New System.Drawing.Point(8, 28)
        Me.ucrSelectorFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFactor.Name = "ucrSelectorFactor"
        Me.ucrSelectorFactor.Size = New System.Drawing.Size(480, 411)
        Me.ucrSelectorFactor.TabIndex = 3
        '
        'rdoBiplot
        '
        Me.rdoBiplot.AutoSize = True
        Me.rdoBiplot.Location = New System.Drawing.Point(15, 124)
        Me.rdoBiplot.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoBiplot.Name = "rdoBiplot"
        Me.rdoBiplot.Size = New System.Drawing.Size(74, 24)
        Me.rdoBiplot.TabIndex = 4
        Me.rdoBiplot.Tag = "Biplot"
        Me.rdoBiplot.Text = "Biplot"
        Me.rdoBiplot.UseVisualStyleBackColor = True
        '
        'rdoVariablesPlot
        '
        Me.rdoVariablesPlot.AutoSize = True
        Me.rdoVariablesPlot.Location = New System.Drawing.Point(15, 56)
        Me.rdoVariablesPlot.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoVariablesPlot.Name = "rdoVariablesPlot"
        Me.rdoVariablesPlot.Size = New System.Drawing.Size(131, 24)
        Me.rdoVariablesPlot.TabIndex = 2
        Me.rdoVariablesPlot.Tag = "Variables_Plot"
        Me.rdoVariablesPlot.Text = "Variables Plot"
        Me.rdoVariablesPlot.UseVisualStyleBackColor = True
        '
        'rdoScreePlot
        '
        Me.rdoScreePlot.AutoSize = True
        Me.rdoScreePlot.Location = New System.Drawing.Point(15, 21)
        Me.rdoScreePlot.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoScreePlot.Name = "rdoScreePlot"
        Me.rdoScreePlot.Size = New System.Drawing.Size(107, 24)
        Me.rdoScreePlot.TabIndex = 1
        Me.rdoScreePlot.Tag = "Scree_Plot"
        Me.rdoScreePlot.Text = "Scree Plot"
        Me.rdoScreePlot.UseVisualStyleBackColor = True
        '
        'ucrPnlGraphics
        '
        Me.ucrPnlGraphics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlGraphics.Location = New System.Drawing.Point(9, 21)
        Me.ucrPnlGraphics.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlGraphics.Name = "ucrPnlGraphics"
        Me.ucrPnlGraphics.Size = New System.Drawing.Size(584, 180)
        Me.ucrPnlGraphics.TabIndex = 0
        '
        'tbSave
        '
        Me.tbSave.Controls.Add(Me.ucrSaveGraph)
        Me.tbSave.Location = New System.Drawing.Point(4, 29)
        Me.tbSave.Margin = New System.Windows.Forms.Padding(4)
        Me.tbSave.Name = "tbSave"
        Me.tbSave.Padding = New System.Windows.Forms.Padding(4)
        Me.tbSave.Size = New System.Drawing.Size(608, 525)
        Me.tbSave.TabIndex = 2
        Me.tbSave.Tag = "Save"
        Me.tbSave.Text = "Save"
        Me.tbSave.UseVisualStyleBackColor = True
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(8, 16)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(519, 36)
        Me.ucrSaveGraph.TabIndex = 15
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.AutoSize = True
        Me.ucrSdgButtons.Location = New System.Drawing.Point(146, 578)
        Me.ucrSdgButtons.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(336, 45)
        Me.ucrSdgButtons.TabIndex = 1
        '
        'sdgPrincipalComponentAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(633, 628)
        Me.Controls.Add(Me.tbRegOptions)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgPrincipalComponentAnalysis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "PCA_Options"
        Me.Text = "PCA Options"
        Me.tbRegOptions.ResumeLayout(False)
        Me.tbGraphics.ResumeLayout(False)
        Me.tbGraphics.PerformLayout()
        Me.grpScree.ResumeLayout(False)
        Me.grpScree.PerformLayout()
        Me.grpVariablePlot.ResumeLayout(False)
        Me.grpVariablePlot.PerformLayout()
        Me.GrpIndividualPlot.ResumeLayout(False)
        Me.GrpIndividualPlot.PerformLayout()
        Me.grpGeom.ResumeLayout(False)
        Me.grpGeom.PerformLayout()
        Me.tbSave.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents tbRegOptions As TabControl
    Friend WithEvents tbGraphics As TabPage
    Friend WithEvents tbSave As TabPage
    Friend WithEvents rdoIndividualsPlot As RadioButton
    Friend WithEvents rdoBiplot As RadioButton
    Friend WithEvents rdoVariablesPlot As RadioButton
    Friend WithEvents rdoScreePlot As RadioButton
    Friend WithEvents rdoBarPlot As RadioButton
    Friend WithEvents ucrSelectorFactor As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFactorVariable As Label
    Friend WithEvents lblChoiceScree As Label
    Friend WithEvents grpGeom As GroupBox
    Friend WithEvents rdoBothScree As RadioButton
    Friend WithEvents rdoLine As RadioButton
    Friend WithEvents rdoBar As RadioButton
    Friend WithEvents lblDim As Label
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
    Friend WithEvents grpScree As GroupBox
    Friend WithEvents ucrInputLabel1 As ucrInputComboBox
    Friend WithEvents ucrNudDim2 As ucrNud
    Friend WithEvents ucrNudDim1 As ucrNud
    Friend WithEvents ucrPnlScreePlot As UcrPanel
    Friend WithEvents ucrPnlGraphics As UcrPanel
    Friend WithEvents ucrChkIncludePercentage As ucrCheck
    Friend WithEvents ucrInputLabel2 As ucrInputComboBox
    Friend WithEvents lblLabel As Label
    Friend WithEvents lblChoice As Label
    Friend WithEvents rdoBothVariables As RadioButton
    Friend WithEvents rdoTextVariables As RadioButton
    Friend WithEvents rdoArrow As RadioButton
    Friend WithEvents ucrPnlVariablesPlot As UcrPanel
    Friend WithEvents rdoBothIndividual As RadioButton
    Friend WithEvents rdoTextIndividual As RadioButton
    Friend WithEvents rdoPoint As RadioButton
    Friend WithEvents ucrPnlIndividualPlot As UcrPanel
    Friend WithEvents grpVariablePlot As GroupBox
    Friend WithEvents GrpIndividualPlot As GroupBox
    Friend WithEvents ucrSaveGraph As ucrSave
End Class