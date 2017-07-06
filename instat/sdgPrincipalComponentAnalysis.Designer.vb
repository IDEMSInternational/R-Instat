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
        Me.tbDisplay = New System.Windows.Forms.TabPage()
        Me.ucrChkRotation = New instat.ucrCheck()
        Me.ucrChkEigenvectors = New instat.ucrCheck()
        Me.ucrChkEigenvalues = New instat.ucrCheck()
        Me.tbGraphics = New System.Windows.Forms.TabPage()
        Me.rdoNoPlot = New System.Windows.Forms.RadioButton()
        Me.rdoBarPlot = New System.Windows.Forms.RadioButton()
        Me.rdoIndividualsPlot = New System.Windows.Forms.RadioButton()
        Me.grpScree = New System.Windows.Forms.GroupBox()
        Me.ucrChkIncludePercentage = New instat.ucrCheck()
        Me.ucrNudDim2 = New instat.ucrNud()
        Me.ucrNudDim = New instat.ucrNud()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.lblFactorVariable = New System.Windows.Forms.Label()
        Me.lblChoiceScree = New System.Windows.Forms.Label()
        Me.grpGeom = New System.Windows.Forms.GroupBox()
        Me.ucrSelectorFactor = New instat.ucrSelectorByDataFrameAddRemove()
        Me.rdoBoth = New System.Windows.Forms.RadioButton()
        Me.rdoTwo = New System.Windows.Forms.RadioButton()
        Me.rdoOne = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGeom = New instat.UcrPanel()
        Me.lblDim = New System.Windows.Forms.Label()
        Me.ucrInputLabel2 = New instat.ucrInputComboBox()
        Me.ucrInputLabel1 = New instat.ucrInputComboBox()
        Me.rdoBiplot = New System.Windows.Forms.RadioButton()
        Me.rdoVariablesPlot = New System.Windows.Forms.RadioButton()
        Me.rdoScreePlot = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGraphics = New instat.UcrPanel()
        Me.tbSave = New System.Windows.Forms.TabPage()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.lblGeom = New System.Windows.Forms.Label()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.tbRegOptions.SuspendLayout()
        Me.tbDisplay.SuspendLayout()
        Me.tbGraphics.SuspendLayout()
        Me.grpScree.SuspendLayout()
        Me.grpGeom.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbRegOptions
        '
        Me.tbRegOptions.Controls.Add(Me.tbDisplay)
        Me.tbRegOptions.Controls.Add(Me.tbGraphics)
        Me.tbRegOptions.Controls.Add(Me.tbSave)
        Me.tbRegOptions.Location = New System.Drawing.Point(2, 3)
        Me.tbRegOptions.Name = "tbRegOptions"
        Me.tbRegOptions.SelectedIndex = 0
        Me.tbRegOptions.Size = New System.Drawing.Size(390, 380)
        Me.tbRegOptions.TabIndex = 0
        '
        'tbDisplay
        '
        Me.tbDisplay.Controls.Add(Me.ucrChkRotation)
        Me.tbDisplay.Controls.Add(Me.ucrChkEigenvectors)
        Me.tbDisplay.Controls.Add(Me.ucrChkEigenvalues)
        Me.tbDisplay.Location = New System.Drawing.Point(4, 22)
        Me.tbDisplay.Name = "tbDisplay"
        Me.tbDisplay.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDisplay.Size = New System.Drawing.Size(382, 354)
        Me.tbDisplay.TabIndex = 0
        Me.tbDisplay.Tag = "Display"
        Me.tbDisplay.Text = "Display"
        Me.tbDisplay.UseVisualStyleBackColor = True
        '
        'ucrChkRotation
        '
        Me.ucrChkRotation.Checked = False
        Me.ucrChkRotation.Location = New System.Drawing.Point(18, 67)
        Me.ucrChkRotation.Name = "ucrChkRotation"
        Me.ucrChkRotation.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkRotation.TabIndex = 5
        '
        'ucrChkEigenvectors
        '
        Me.ucrChkEigenvectors.Checked = False
        Me.ucrChkEigenvectors.Location = New System.Drawing.Point(18, 41)
        Me.ucrChkEigenvectors.Name = "ucrChkEigenvectors"
        Me.ucrChkEigenvectors.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkEigenvectors.TabIndex = 4
        '
        'ucrChkEigenvalues
        '
        Me.ucrChkEigenvalues.Checked = False
        Me.ucrChkEigenvalues.Location = New System.Drawing.Point(18, 15)
        Me.ucrChkEigenvalues.Name = "ucrChkEigenvalues"
        Me.ucrChkEigenvalues.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkEigenvalues.TabIndex = 3
        '
        'tbGraphics
        '
        Me.tbGraphics.Controls.Add(Me.ucrSelectorFactor)
        Me.tbGraphics.Controls.Add(Me.rdoNoPlot)
        Me.tbGraphics.Controls.Add(Me.rdoBarPlot)
        Me.tbGraphics.Controls.Add(Me.rdoIndividualsPlot)
        Me.tbGraphics.Controls.Add(Me.grpScree)
        Me.tbGraphics.Controls.Add(Me.rdoBiplot)
        Me.tbGraphics.Controls.Add(Me.rdoVariablesPlot)
        Me.tbGraphics.Controls.Add(Me.rdoScreePlot)
        Me.tbGraphics.Controls.Add(Me.ucrPnlGraphics)
        Me.tbGraphics.Location = New System.Drawing.Point(4, 22)
        Me.tbGraphics.Name = "tbGraphics"
        Me.tbGraphics.Padding = New System.Windows.Forms.Padding(3)
        Me.tbGraphics.Size = New System.Drawing.Size(382, 354)
        Me.tbGraphics.TabIndex = 1
        Me.tbGraphics.Tag = "Graphics"
        Me.tbGraphics.Text = "Graphics"
        Me.tbGraphics.UseVisualStyleBackColor = True
        '
        'rdoNoPlot
        '
        Me.rdoNoPlot.AutoSize = True
        Me.rdoNoPlot.Location = New System.Drawing.Point(10, 14)
        Me.rdoNoPlot.Name = "rdoNoPlot"
        Me.rdoNoPlot.Size = New System.Drawing.Size(60, 17)
        Me.rdoNoPlot.TabIndex = 35
        Me.rdoNoPlot.Tag = "Scree_Plot"
        Me.rdoNoPlot.Text = "No Plot"
        Me.rdoNoPlot.UseVisualStyleBackColor = True
        '
        'rdoBarPlot
        '
        Me.rdoBarPlot.AutoSize = True
        Me.rdoBarPlot.Location = New System.Drawing.Point(10, 132)
        Me.rdoBarPlot.Name = "rdoBarPlot"
        Me.rdoBarPlot.Size = New System.Drawing.Size(61, 17)
        Me.rdoBarPlot.TabIndex = 5
        Me.rdoBarPlot.Tag = "Bar plot"
        Me.rdoBarPlot.Text = "Bar plot"
        Me.rdoBarPlot.UseVisualStyleBackColor = True
        '
        'rdoIndividualsPlot
        '
        Me.rdoIndividualsPlot.AutoSize = True
        Me.rdoIndividualsPlot.Location = New System.Drawing.Point(10, 86)
        Me.rdoIndividualsPlot.Name = "rdoIndividualsPlot"
        Me.rdoIndividualsPlot.Size = New System.Drawing.Size(96, 17)
        Me.rdoIndividualsPlot.TabIndex = 2
        Me.rdoIndividualsPlot.Tag = "Individuals_Plot"
        Me.rdoIndividualsPlot.Text = "Individuals Plot"
        Me.rdoIndividualsPlot.UseVisualStyleBackColor = True
        '
        'grpScree
        '
        Me.grpScree.Controls.Add(Me.lblLabel)
        Me.grpScree.Controls.Add(Me.lblGeom)
        Me.grpScree.Controls.Add(Me.ucrChkIncludePercentage)
        Me.grpScree.Controls.Add(Me.ucrNudDim2)
        Me.grpScree.Controls.Add(Me.ucrNudDim)
        Me.grpScree.Controls.Add(Me.ucrReceiverFactor)
        Me.grpScree.Controls.Add(Me.lblFactorVariable)
        Me.grpScree.Controls.Add(Me.lblChoiceScree)
        Me.grpScree.Controls.Add(Me.grpGeom)
        Me.grpScree.Controls.Add(Me.lblDim)
        Me.grpScree.Controls.Add(Me.ucrInputLabel2)
        Me.grpScree.Controls.Add(Me.ucrInputLabel1)
        Me.grpScree.Location = New System.Drawing.Point(10, 156)
        Me.grpScree.Name = "grpScree"
        Me.grpScree.Size = New System.Drawing.Size(365, 192)
        Me.grpScree.TabIndex = 34
        Me.grpScree.TabStop = False
        Me.grpScree.Text = "Plot Options"
        '
        'ucrChkIncludePercentage
        '
        Me.ucrChkIncludePercentage.Checked = False
        Me.ucrChkIncludePercentage.Location = New System.Drawing.Point(11, 70)
        Me.ucrChkIncludePercentage.Name = "ucrChkIncludePercentage"
        Me.ucrChkIncludePercentage.Size = New System.Drawing.Size(138, 20)
        Me.ucrChkIncludePercentage.TabIndex = 21
        '
        'ucrNudDim2
        '
        Me.ucrNudDim2.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDim2.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDim2.Location = New System.Drawing.Point(175, 70)
        Me.ucrNudDim2.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDim2.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDim2.Name = "ucrNudDim2"
        Me.ucrNudDim2.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDim2.TabIndex = 20
        Me.ucrNudDim2.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDim
        '
        Me.ucrNudDim.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDim.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDim.Location = New System.Drawing.Point(110, 70)
        Me.ucrNudDim.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDim.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDim.Name = "ucrNudDim"
        Me.ucrNudDim.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDim.TabIndex = 19
        Me.ucrNudDim.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.frmParent = Nothing
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(228, 50)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.TabIndex = 5
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'lblFactorVariable
        '
        Me.lblFactorVariable.AutoSize = True
        Me.lblFactorVariable.Location = New System.Drawing.Point(227, 35)
        Me.lblFactorVariable.Name = "lblFactorVariable"
        Me.lblFactorVariable.Size = New System.Drawing.Size(81, 13)
        Me.lblFactorVariable.TabIndex = 2
        Me.lblFactorVariable.Tag = "Factor_Variable"
        Me.lblFactorVariable.Text = "Factor Variable:"
        '
        'lblChoiceScree
        '
        Me.lblChoiceScree.AutoSize = True
        Me.lblChoiceScree.Location = New System.Drawing.Point(11, 106)
        Me.lblChoiceScree.Name = "lblChoiceScree"
        Me.lblChoiceScree.Size = New System.Drawing.Size(0, 13)
        Me.lblChoiceScree.TabIndex = 8
        Me.lblChoiceScree.Tag = "Choice:"
        '
        'grpGeom
        '
        Me.grpGeom.Controls.Add(Me.rdoBoth)
        Me.grpGeom.Controls.Add(Me.rdoTwo)
        Me.grpGeom.Controls.Add(Me.rdoOne)
        Me.grpGeom.Controls.Add(Me.ucrPnlGeom)
        Me.grpGeom.Location = New System.Drawing.Point(11, 18)
        Me.grpGeom.Name = "grpGeom"
        Me.grpGeom.Size = New System.Drawing.Size(197, 45)
        Me.grpGeom.TabIndex = 13
        Me.grpGeom.TabStop = False
        Me.grpGeom.Tag = "Geom"
        Me.grpGeom.Text = "Geom"
        '
        'ucrSelectorFactor
        '
        Me.ucrSelectorFactor.bShowHiddenColumns = False
        Me.ucrSelectorFactor.bUseCurrentFilter = True
        Me.ucrSelectorFactor.Location = New System.Drawing.Point(185, 38)
        Me.ucrSelectorFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFactor.Name = "ucrSelectorFactor"
        Me.ucrSelectorFactor.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorFactor.TabIndex = 3
        '
        'rdoBoth
        '
        Me.rdoBoth.AutoSize = True
        Me.rdoBoth.Location = New System.Drawing.Point(142, 17)
        Me.rdoBoth.Name = "rdoBoth"
        Me.rdoBoth.Size = New System.Drawing.Size(47, 17)
        Me.rdoBoth.TabIndex = 2
        Me.rdoBoth.TabStop = True
        Me.rdoBoth.Text = "Both"
        Me.rdoBoth.UseVisualStyleBackColor = True
        '
        'rdoTwo
        '
        Me.rdoTwo.AutoSize = True
        Me.rdoTwo.Location = New System.Drawing.Point(74, 17)
        Me.rdoTwo.Name = "rdoTwo"
        Me.rdoTwo.Size = New System.Drawing.Size(14, 13)
        Me.rdoTwo.TabIndex = 1
        Me.rdoTwo.TabStop = True
        Me.rdoTwo.UseVisualStyleBackColor = True
        '
        'rdoOne
        '
        Me.rdoOne.AutoSize = True
        Me.rdoOne.Location = New System.Drawing.Point(8, 17)
        Me.rdoOne.Name = "rdoOne"
        Me.rdoOne.Size = New System.Drawing.Size(14, 13)
        Me.rdoOne.TabIndex = 0
        Me.rdoOne.TabStop = True
        Me.rdoOne.UseVisualStyleBackColor = True
        '
        'ucrPnlGeom
        '
        Me.ucrPnlGeom.Location = New System.Drawing.Point(4, 17)
        Me.ucrPnlGeom.Name = "ucrPnlGeom"
        Me.ucrPnlGeom.Size = New System.Drawing.Size(191, 22)
        Me.ucrPnlGeom.TabIndex = 3
        '
        'lblDim
        '
        Me.lblDim.AutoSize = True
        Me.lblDim.Location = New System.Drawing.Point(7, 73)
        Me.lblDim.Name = "lblDim"
        Me.lblDim.Size = New System.Drawing.Size(97, 13)
        Me.lblDim.TabIndex = 15
        Me.lblDim.Text = "Dimensions to Plot:"
        '
        'ucrInputLabel2
        '
        Me.ucrInputLabel2.AddQuotesIfUnrecognised = True
        Me.ucrInputLabel2.IsReadOnly = False
        Me.ucrInputLabel2.Location = New System.Drawing.Point(55, 101)
        Me.ucrInputLabel2.Name = "ucrInputLabel2"
        Me.ucrInputLabel2.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLabel2.TabIndex = 22
        '
        'ucrInputLabel1
        '
        Me.ucrInputLabel1.AddQuotesIfUnrecognised = True
        Me.ucrInputLabel1.IsReadOnly = False
        Me.ucrInputLabel1.Location = New System.Drawing.Point(55, 101)
        Me.ucrInputLabel1.Name = "ucrInputLabel1"
        Me.ucrInputLabel1.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLabel1.TabIndex = 18
        '
        'rdoBiplot
        '
        Me.rdoBiplot.AutoSize = True
        Me.rdoBiplot.Location = New System.Drawing.Point(10, 109)
        Me.rdoBiplot.Name = "rdoBiplot"
        Me.rdoBiplot.Size = New System.Drawing.Size(51, 17)
        Me.rdoBiplot.TabIndex = 3
        Me.rdoBiplot.Tag = "Biplot"
        Me.rdoBiplot.Text = "Biplot"
        Me.rdoBiplot.UseVisualStyleBackColor = True
        '
        'rdoVariablesPlot
        '
        Me.rdoVariablesPlot.AutoSize = True
        Me.rdoVariablesPlot.Location = New System.Drawing.Point(10, 63)
        Me.rdoVariablesPlot.Name = "rdoVariablesPlot"
        Me.rdoVariablesPlot.Size = New System.Drawing.Size(89, 17)
        Me.rdoVariablesPlot.TabIndex = 1
        Me.rdoVariablesPlot.Tag = "Variables_Plot"
        Me.rdoVariablesPlot.Text = "Variables Plot"
        Me.rdoVariablesPlot.UseVisualStyleBackColor = True
        '
        'rdoScreePlot
        '
        Me.rdoScreePlot.AutoSize = True
        Me.rdoScreePlot.Location = New System.Drawing.Point(10, 38)
        Me.rdoScreePlot.Name = "rdoScreePlot"
        Me.rdoScreePlot.Size = New System.Drawing.Size(74, 17)
        Me.rdoScreePlot.TabIndex = 0
        Me.rdoScreePlot.Tag = "Scree_Plot"
        Me.rdoScreePlot.Text = "Scree Plot"
        Me.rdoScreePlot.UseVisualStyleBackColor = True
        '
        'ucrPnlGraphics
        '
        Me.ucrPnlGraphics.Location = New System.Drawing.Point(6, 6)
        Me.ucrPnlGraphics.Name = "ucrPnlGraphics"
        Me.ucrPnlGraphics.Size = New System.Drawing.Size(207, 144)
        Me.ucrPnlGraphics.TabIndex = 4
        '
        'tbSave
        '
        Me.tbSave.Location = New System.Drawing.Point(4, 22)
        Me.tbSave.Name = "tbSave"
        Me.tbSave.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSave.Size = New System.Drawing.Size(382, 354)
        Me.tbSave.TabIndex = 2
        Me.tbSave.Tag = "Save"
        Me.tbSave.Text = "Save"
        Me.tbSave.UseVisualStyleBackColor = True
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.Location = New System.Drawing.Point(116, 385)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(142, 30)
        Me.ucrSdgButtons.TabIndex = 1
        '
        'lblGeom
        '
        Me.lblGeom.AutoSize = True
        Me.lblGeom.Location = New System.Drawing.Point(12, 106)
        Me.lblGeom.Name = "lblGeom"
        Me.lblGeom.Size = New System.Drawing.Size(38, 13)
        Me.lblGeom.TabIndex = 23
        Me.lblGeom.Text = "Geom:"
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.Location = New System.Drawing.Point(10, 106)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(36, 13)
        Me.lblLabel.TabIndex = 24
        Me.lblLabel.Text = "Label:"
        '
        'sdgPrincipalComponentAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 412)
        Me.Controls.Add(Me.tbRegOptions)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgPrincipalComponentAnalysis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "PCA_Options"
        Me.Text = "PCA Options"
        Me.tbRegOptions.ResumeLayout(False)
        Me.tbDisplay.ResumeLayout(False)
        Me.tbGraphics.ResumeLayout(False)
        Me.tbGraphics.PerformLayout()
        Me.grpScree.ResumeLayout(False)
        Me.grpScree.PerformLayout()
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
    Friend WithEvents rdoBoth As RadioButton
    Friend WithEvents rdoTwo As RadioButton
    Friend WithEvents rdoOne As RadioButton
    Friend WithEvents lblDim As Label
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
    Friend WithEvents grpScree As GroupBox
    Friend WithEvents ucrInputLabel1 As ucrInputComboBox
    Friend WithEvents ucrChkRotation As ucrCheck
    Friend WithEvents ucrChkEigenvectors As ucrCheck
    Friend WithEvents ucrChkEigenvalues As ucrCheck
    Friend WithEvents ucrNudDim2 As ucrNud
    Friend WithEvents ucrNudDim As ucrNud
    Friend WithEvents ucrPnlGeom As UcrPanel
    Friend WithEvents ucrPnlGraphics As UcrPanel
    Friend WithEvents ucrChkIncludePercentage As ucrCheck
    Friend WithEvents rdoNoPlot As RadioButton
    Friend WithEvents ucrInputLabel2 As ucrInputComboBox
    Friend WithEvents lblLabel As Label
    Friend WithEvents lblGeom As Label
End Class