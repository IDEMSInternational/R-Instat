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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgPrincipalComponentAnalysis))
        Me.tbRegOptions = New System.Windows.Forms.TabControl()
        Me.tbDisplay = New System.Windows.Forms.TabPage()
        Me.ucrChkRotation = New instat.ucrCheck()
        Me.ucrChkEigenvectors = New instat.ucrCheck()
        Me.ucrChkEigenvalues = New instat.ucrCheck()
        Me.tbGraphics = New System.Windows.Forms.TabPage()
        Me.rdoBarPlot = New System.Windows.Forms.RadioButton()
        Me.rdoIndividualsPlot = New System.Windows.Forms.RadioButton()
        Me.grpScree = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.lblFactorVariable = New System.Windows.Forms.Label()
        Me.ucrSelectorFactor = New instat.ucrSelectorByDataFrameAddRemove()
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
        Me.rdoBiplot = New System.Windows.Forms.RadioButton()
        Me.rdoVariablesPlot = New System.Windows.Forms.RadioButton()
        Me.rdoScreePlot = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGraphics = New instat.UcrPanel()
        Me.tbSave = New System.Windows.Forms.TabPage()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.tbRegOptions.SuspendLayout()
        Me.tbDisplay.SuspendLayout()
        Me.tbGraphics.SuspendLayout()
        Me.grpScree.SuspendLayout()
        Me.grpVariablePlot.SuspendLayout()
        Me.GrpIndividualPlot.SuspendLayout()
        Me.grpGeom.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbRegOptions
        '
        Me.tbRegOptions.Controls.Add(Me.tbDisplay)
        Me.tbRegOptions.Controls.Add(Me.tbGraphics)
        Me.tbRegOptions.Controls.Add(Me.tbSave)
        resources.ApplyResources(Me.tbRegOptions, "tbRegOptions")
        Me.tbRegOptions.Name = "tbRegOptions"
        Me.tbRegOptions.SelectedIndex = 0
        '
        'tbDisplay
        '
        Me.tbDisplay.Controls.Add(Me.ucrChkRotation)
        Me.tbDisplay.Controls.Add(Me.ucrChkEigenvectors)
        Me.tbDisplay.Controls.Add(Me.ucrChkEigenvalues)
        resources.ApplyResources(Me.tbDisplay, "tbDisplay")
        Me.tbDisplay.Name = "tbDisplay"
        Me.tbDisplay.Tag = "Display"
        Me.tbDisplay.UseVisualStyleBackColor = True
        '
        'ucrChkRotation
        '
        Me.ucrChkRotation.Checked = False
        resources.ApplyResources(Me.ucrChkRotation, "ucrChkRotation")
        Me.ucrChkRotation.Name = "ucrChkRotation"
        '
        'ucrChkEigenvectors
        '
        Me.ucrChkEigenvectors.Checked = False
        resources.ApplyResources(Me.ucrChkEigenvectors, "ucrChkEigenvectors")
        Me.ucrChkEigenvectors.Name = "ucrChkEigenvectors"
        '
        'ucrChkEigenvalues
        '
        Me.ucrChkEigenvalues.Checked = False
        resources.ApplyResources(Me.ucrChkEigenvalues, "ucrChkEigenvalues")
        Me.ucrChkEigenvalues.Name = "ucrChkEigenvalues"
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
        resources.ApplyResources(Me.tbGraphics, "tbGraphics")
        Me.tbGraphics.Name = "tbGraphics"
        Me.tbGraphics.Tag = "Graphics"
        Me.tbGraphics.UseVisualStyleBackColor = True
        '
        'rdoBarPlot
        '
        resources.ApplyResources(Me.rdoBarPlot, "rdoBarPlot")
        Me.rdoBarPlot.Name = "rdoBarPlot"
        Me.rdoBarPlot.Tag = "Bar plot"
        Me.rdoBarPlot.UseVisualStyleBackColor = True
        '
        'rdoIndividualsPlot
        '
        resources.ApplyResources(Me.rdoIndividualsPlot, "rdoIndividualsPlot")
        Me.rdoIndividualsPlot.Name = "rdoIndividualsPlot"
        Me.rdoIndividualsPlot.Tag = "Individuals_Plot"
        Me.rdoIndividualsPlot.UseVisualStyleBackColor = True
        '
        'grpScree
        '
        Me.grpScree.Controls.Add(Me.ucrReceiverFactor)
        Me.grpScree.Controls.Add(Me.lblFactorVariable)
        Me.grpScree.Controls.Add(Me.ucrSelectorFactor)
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
        resources.ApplyResources(Me.grpScree, "grpScree")
        Me.grpScree.Name = "grpScree"
        Me.grpScree.TabStop = False
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverFactor, "ucrReceiverFactor")
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'lblFactorVariable
        '
        resources.ApplyResources(Me.lblFactorVariable, "lblFactorVariable")
        Me.lblFactorVariable.Name = "lblFactorVariable"
        Me.lblFactorVariable.Tag = "Factor_Variable"
        '
        'ucrSelectorFactor
        '
        Me.ucrSelectorFactor.bShowHiddenColumns = False
        Me.ucrSelectorFactor.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorFactor, "ucrSelectorFactor")
        Me.ucrSelectorFactor.Name = "ucrSelectorFactor"
        '
        'grpVariablePlot
        '
        Me.grpVariablePlot.Controls.Add(Me.rdoTextVariables)
        Me.grpVariablePlot.Controls.Add(Me.rdoArrow)
        Me.grpVariablePlot.Controls.Add(Me.rdoBothVariables)
        Me.grpVariablePlot.Controls.Add(Me.ucrPnlVariablesPlot)
        resources.ApplyResources(Me.grpVariablePlot, "grpVariablePlot")
        Me.grpVariablePlot.Name = "grpVariablePlot"
        Me.grpVariablePlot.TabStop = False
        '
        'rdoTextVariables
        '
        resources.ApplyResources(Me.rdoTextVariables, "rdoTextVariables")
        Me.rdoTextVariables.Name = "rdoTextVariables"
        Me.rdoTextVariables.TabStop = True
        Me.rdoTextVariables.UseVisualStyleBackColor = True
        '
        'rdoArrow
        '
        resources.ApplyResources(Me.rdoArrow, "rdoArrow")
        Me.rdoArrow.Name = "rdoArrow"
        Me.rdoArrow.TabStop = True
        Me.rdoArrow.UseVisualStyleBackColor = True
        '
        'rdoBothVariables
        '
        resources.ApplyResources(Me.rdoBothVariables, "rdoBothVariables")
        Me.rdoBothVariables.Name = "rdoBothVariables"
        Me.rdoBothVariables.TabStop = True
        Me.rdoBothVariables.UseVisualStyleBackColor = True
        '
        'ucrPnlVariablesPlot
        '
        resources.ApplyResources(Me.ucrPnlVariablesPlot, "ucrPnlVariablesPlot")
        Me.ucrPnlVariablesPlot.Name = "ucrPnlVariablesPlot"
        '
        'lblLabel
        '
        resources.ApplyResources(Me.lblLabel, "lblLabel")
        Me.lblLabel.Name = "lblLabel"
        '
        'GrpIndividualPlot
        '
        Me.GrpIndividualPlot.Controls.Add(Me.rdoTextIndividual)
        Me.GrpIndividualPlot.Controls.Add(Me.rdoPoint)
        Me.GrpIndividualPlot.Controls.Add(Me.rdoBothIndividual)
        Me.GrpIndividualPlot.Controls.Add(Me.ucrPnlIndividualPlot)
        resources.ApplyResources(Me.GrpIndividualPlot, "GrpIndividualPlot")
        Me.GrpIndividualPlot.Name = "GrpIndividualPlot"
        Me.GrpIndividualPlot.TabStop = False
        '
        'rdoTextIndividual
        '
        resources.ApplyResources(Me.rdoTextIndividual, "rdoTextIndividual")
        Me.rdoTextIndividual.Name = "rdoTextIndividual"
        Me.rdoTextIndividual.TabStop = True
        Me.rdoTextIndividual.UseVisualStyleBackColor = True
        '
        'rdoPoint
        '
        resources.ApplyResources(Me.rdoPoint, "rdoPoint")
        Me.rdoPoint.Name = "rdoPoint"
        Me.rdoPoint.TabStop = True
        Me.rdoPoint.UseVisualStyleBackColor = True
        '
        'rdoBothIndividual
        '
        resources.ApplyResources(Me.rdoBothIndividual, "rdoBothIndividual")
        Me.rdoBothIndividual.Name = "rdoBothIndividual"
        Me.rdoBothIndividual.TabStop = True
        Me.rdoBothIndividual.UseVisualStyleBackColor = True
        '
        'ucrPnlIndividualPlot
        '
        resources.ApplyResources(Me.ucrPnlIndividualPlot, "ucrPnlIndividualPlot")
        Me.ucrPnlIndividualPlot.Name = "ucrPnlIndividualPlot"
        '
        'lblChoice
        '
        resources.ApplyResources(Me.lblChoice, "lblChoice")
        Me.lblChoice.Name = "lblChoice"
        '
        'ucrChkIncludePercentage
        '
        Me.ucrChkIncludePercentage.Checked = False
        resources.ApplyResources(Me.ucrChkIncludePercentage, "ucrChkIncludePercentage")
        Me.ucrChkIncludePercentage.Name = "ucrChkIncludePercentage"
        '
        'ucrNudDim2
        '
        Me.ucrNudDim2.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDim2.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudDim2, "ucrNudDim2")
        Me.ucrNudDim2.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDim2.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDim2.Name = "ucrNudDim2"
        Me.ucrNudDim2.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDim1
        '
        Me.ucrNudDim1.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDim1.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudDim1, "ucrNudDim1")
        Me.ucrNudDim1.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDim1.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDim1.Name = "ucrNudDim1"
        Me.ucrNudDim1.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'grpGeom
        '
        Me.grpGeom.Controls.Add(Me.rdoBar)
        Me.grpGeom.Controls.Add(Me.rdoLine)
        Me.grpGeom.Controls.Add(Me.rdoBothScree)
        Me.grpGeom.Controls.Add(Me.ucrPnlScreePlot)
        resources.ApplyResources(Me.grpGeom, "grpGeom")
        Me.grpGeom.Name = "grpGeom"
        Me.grpGeom.TabStop = False
        Me.grpGeom.Tag = "Geom"
        '
        'rdoBar
        '
        resources.ApplyResources(Me.rdoBar, "rdoBar")
        Me.rdoBar.Name = "rdoBar"
        Me.rdoBar.TabStop = True
        Me.rdoBar.UseVisualStyleBackColor = True
        '
        'rdoLine
        '
        resources.ApplyResources(Me.rdoLine, "rdoLine")
        Me.rdoLine.Name = "rdoLine"
        Me.rdoLine.TabStop = True
        Me.rdoLine.UseVisualStyleBackColor = True
        '
        'rdoBothScree
        '
        resources.ApplyResources(Me.rdoBothScree, "rdoBothScree")
        Me.rdoBothScree.Name = "rdoBothScree"
        Me.rdoBothScree.TabStop = True
        Me.rdoBothScree.UseVisualStyleBackColor = True
        '
        'ucrPnlScreePlot
        '
        resources.ApplyResources(Me.ucrPnlScreePlot, "ucrPnlScreePlot")
        Me.ucrPnlScreePlot.Name = "ucrPnlScreePlot"
        '
        'lblChoiceScree
        '
        resources.ApplyResources(Me.lblChoiceScree, "lblChoiceScree")
        Me.lblChoiceScree.Name = "lblChoiceScree"
        Me.lblChoiceScree.Tag = "Choice:"
        '
        'lblDim
        '
        resources.ApplyResources(Me.lblDim, "lblDim")
        Me.lblDim.Name = "lblDim"
        '
        'ucrInputLabel2
        '
        Me.ucrInputLabel2.AddQuotesIfUnrecognised = True
        Me.ucrInputLabel2.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLabel2, "ucrInputLabel2")
        Me.ucrInputLabel2.Name = "ucrInputLabel2"
        '
        'ucrInputLabel1
        '
        Me.ucrInputLabel1.AddQuotesIfUnrecognised = True
        Me.ucrInputLabel1.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLabel1, "ucrInputLabel1")
        Me.ucrInputLabel1.Name = "ucrInputLabel1"
        '
        'rdoBiplot
        '
        resources.ApplyResources(Me.rdoBiplot, "rdoBiplot")
        Me.rdoBiplot.Name = "rdoBiplot"
        Me.rdoBiplot.Tag = "Biplot"
        Me.rdoBiplot.UseVisualStyleBackColor = True
        '
        'rdoVariablesPlot
        '
        resources.ApplyResources(Me.rdoVariablesPlot, "rdoVariablesPlot")
        Me.rdoVariablesPlot.Name = "rdoVariablesPlot"
        Me.rdoVariablesPlot.Tag = "Variables_Plot"
        Me.rdoVariablesPlot.UseVisualStyleBackColor = True
        '
        'rdoScreePlot
        '
        resources.ApplyResources(Me.rdoScreePlot, "rdoScreePlot")
        Me.rdoScreePlot.Name = "rdoScreePlot"
        Me.rdoScreePlot.Tag = "Scree_Plot"
        Me.rdoScreePlot.UseVisualStyleBackColor = True
        '
        'ucrPnlGraphics
        '
        resources.ApplyResources(Me.ucrPnlGraphics, "ucrPnlGraphics")
        Me.ucrPnlGraphics.Name = "ucrPnlGraphics"
        '
        'tbSave
        '
        resources.ApplyResources(Me.tbSave, "tbSave")
        Me.tbSave.Name = "tbSave"
        Me.tbSave.Tag = "Save"
        Me.tbSave.UseVisualStyleBackColor = True
        '
        'ucrSdgButtons
        '
        resources.ApplyResources(Me.ucrSdgButtons, "ucrSdgButtons")
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        '
        'sdgPrincipalComponentAnalysis
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbRegOptions)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgPrincipalComponentAnalysis"
        Me.Tag = "PCA_Options"
        Me.tbRegOptions.ResumeLayout(False)
        Me.tbDisplay.ResumeLayout(False)
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents tbRegOptions As TabControl
    Friend WithEvents tbDisplay As TabPage
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
    Friend WithEvents ucrChkRotation As ucrCheck
    Friend WithEvents ucrChkEigenvectors As ucrCheck
    Friend WithEvents ucrChkEigenvalues As ucrCheck
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
End Class