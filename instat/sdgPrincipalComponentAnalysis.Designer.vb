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
        Me.chkRotation = New System.Windows.Forms.CheckBox()
        Me.chkEigenVectors = New System.Windows.Forms.CheckBox()
        Me.chkEigenValues = New System.Windows.Forms.CheckBox()
        Me.tbGraphics = New System.Windows.Forms.TabPage()
        Me.rdoBarPlot = New System.Windows.Forms.RadioButton()
        Me.rdoIndividualsPlot = New System.Windows.Forms.RadioButton()
        Me.grpScree = New System.Windows.Forms.GroupBox()
        Me.ucrLabel = New instat.ucrInputComboBox()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.lblFactorVariable = New System.Windows.Forms.Label()
        Me.ucrSelectorFactor = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblChoiceScree = New System.Windows.Forms.Label()
        Me.chkPercentageScree = New System.Windows.Forms.CheckBox()
        Me.grpGeom = New System.Windows.Forms.GroupBox()
        Me.rdoBoth = New System.Windows.Forms.RadioButton()
        Me.rdoTwo = New System.Windows.Forms.RadioButton()
        Me.rdoOne = New System.Windows.Forms.RadioButton()
        Me.lblDim = New System.Windows.Forms.Label()
        Me.nudDim1 = New System.Windows.Forms.NumericUpDown()
        Me.nudDim2 = New System.Windows.Forms.NumericUpDown()
        Me.rdoBiplot = New System.Windows.Forms.RadioButton()
        Me.rdoVariablesPlot = New System.Windows.Forms.RadioButton()
        Me.rdoScreePlot = New System.Windows.Forms.RadioButton()
        Me.tbSave = New System.Windows.Forms.TabPage()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.tbRegOptions.SuspendLayout()
        Me.tbDisplay.SuspendLayout()
        Me.tbGraphics.SuspendLayout()
        Me.grpScree.SuspendLayout()
        Me.grpGeom.SuspendLayout()
        CType(Me.nudDim1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDim2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tbDisplay.Controls.Add(Me.chkRotation)
        Me.tbDisplay.Controls.Add(Me.chkEigenVectors)
        Me.tbDisplay.Controls.Add(Me.chkEigenValues)
        Me.tbDisplay.Location = New System.Drawing.Point(4, 22)
        Me.tbDisplay.Name = "tbDisplay"
        Me.tbDisplay.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDisplay.Size = New System.Drawing.Size(382, 354)
        Me.tbDisplay.TabIndex = 0
        Me.tbDisplay.Tag = "Display"
        Me.tbDisplay.Text = "Display"
        Me.tbDisplay.UseVisualStyleBackColor = True
        '
        'chkRotation
        '
        Me.chkRotation.AutoSize = True
        Me.chkRotation.Location = New System.Drawing.Point(10, 60)
        Me.chkRotation.Name = "chkRotation"
        Me.chkRotation.Size = New System.Drawing.Size(66, 17)
        Me.chkRotation.TabIndex = 2
        Me.chkRotation.Tag = "Rotation"
        Me.chkRotation.Text = "Rotation"
        Me.chkRotation.UseVisualStyleBackColor = True
        '
        'chkEigenVectors
        '
        Me.chkEigenVectors.AutoSize = True
        Me.chkEigenVectors.Location = New System.Drawing.Point(10, 37)
        Me.chkEigenVectors.Name = "chkEigenVectors"
        Me.chkEigenVectors.Size = New System.Drawing.Size(88, 17)
        Me.chkEigenVectors.TabIndex = 1
        Me.chkEigenVectors.Tag = "Eigen_Vectors"
        Me.chkEigenVectors.Text = "Eigenvectors"
        Me.chkEigenVectors.UseVisualStyleBackColor = True
        '
        'chkEigenValues
        '
        Me.chkEigenValues.AutoSize = True
        Me.chkEigenValues.Location = New System.Drawing.Point(10, 14)
        Me.chkEigenValues.Name = "chkEigenValues"
        Me.chkEigenValues.Size = New System.Drawing.Size(84, 17)
        Me.chkEigenValues.TabIndex = 0
        Me.chkEigenValues.Tag = "Eigen_Values"
        Me.chkEigenValues.Text = "Eigenvalues"
        Me.chkEigenValues.UseVisualStyleBackColor = True
        '
        'tbGraphics
        '
        Me.tbGraphics.Controls.Add(Me.rdoBarPlot)
        Me.tbGraphics.Controls.Add(Me.rdoIndividualsPlot)
        Me.tbGraphics.Controls.Add(Me.grpScree)
        Me.tbGraphics.Controls.Add(Me.rdoBiplot)
        Me.tbGraphics.Controls.Add(Me.rdoVariablesPlot)
        Me.tbGraphics.Controls.Add(Me.rdoScreePlot)
        Me.tbGraphics.Location = New System.Drawing.Point(4, 22)
        Me.tbGraphics.Name = "tbGraphics"
        Me.tbGraphics.Padding = New System.Windows.Forms.Padding(3)
        Me.tbGraphics.Size = New System.Drawing.Size(382, 354)
        Me.tbGraphics.TabIndex = 1
        Me.tbGraphics.Tag = "Graphics"
        Me.tbGraphics.Text = "Graphics"
        Me.tbGraphics.UseVisualStyleBackColor = True
        '
        'rdoBarPlot
        '
        Me.rdoBarPlot.AutoSize = True
        Me.rdoBarPlot.Location = New System.Drawing.Point(10, 106)
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
        Me.rdoIndividualsPlot.Location = New System.Drawing.Point(10, 60)
        Me.rdoIndividualsPlot.Name = "rdoIndividualsPlot"
        Me.rdoIndividualsPlot.Size = New System.Drawing.Size(96, 17)
        Me.rdoIndividualsPlot.TabIndex = 2
        Me.rdoIndividualsPlot.Tag = "Individuals_Plot"
        Me.rdoIndividualsPlot.Text = "Individuals Plot"
        Me.rdoIndividualsPlot.UseVisualStyleBackColor = True
        '
        'grpScree
        '
        Me.grpScree.Controls.Add(Me.ucrLabel)
        Me.grpScree.Controls.Add(Me.ucrReceiverFactor)
        Me.grpScree.Controls.Add(Me.lblFactorVariable)
        Me.grpScree.Controls.Add(Me.ucrSelectorFactor)
        Me.grpScree.Controls.Add(Me.lblChoiceScree)
        Me.grpScree.Controls.Add(Me.chkPercentageScree)
        Me.grpScree.Controls.Add(Me.grpGeom)
        Me.grpScree.Controls.Add(Me.lblDim)
        Me.grpScree.Controls.Add(Me.nudDim1)
        Me.grpScree.Controls.Add(Me.nudDim2)
        Me.grpScree.Location = New System.Drawing.Point(10, 136)
        Me.grpScree.Name = "grpScree"
        Me.grpScree.Size = New System.Drawing.Size(365, 212)
        Me.grpScree.TabIndex = 34
        Me.grpScree.TabStop = False
        Me.grpScree.Text = "Plot Options"
        '
        'ucrLabel
        '
        Me.ucrLabel.IsReadOnly = False
        Me.ucrLabel.Location = New System.Drawing.Point(55, 101)
        Me.ucrLabel.Name = "ucrLabel"
        Me.ucrLabel.Size = New System.Drawing.Size(137, 21)
        Me.ucrLabel.TabIndex = 18
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(228, 50)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFactor.TabIndex = 5
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
        'ucrSelectorFactor
        '
        Me.ucrSelectorFactor.bShowHiddenColumns = False
        Me.ucrSelectorFactor.bUseCurrentFilter = True
        Me.ucrSelectorFactor.Location = New System.Drawing.Point(10, 16)
        Me.ucrSelectorFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFactor.Name = "ucrSelectorFactor"
        Me.ucrSelectorFactor.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorFactor.TabIndex = 3
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
        'chkPercentageScree
        '
        Me.chkPercentageScree.AutoSize = True
        Me.chkPercentageScree.Location = New System.Drawing.Point(10, 71)
        Me.chkPercentageScree.Name = "chkPercentageScree"
        Me.chkPercentageScree.Size = New System.Drawing.Size(124, 17)
        Me.chkPercentageScree.TabIndex = 15
        Me.chkPercentageScree.Text = "Include Percentages"
        Me.chkPercentageScree.UseVisualStyleBackColor = True
        '
        'grpGeom
        '
        Me.grpGeom.Controls.Add(Me.rdoBoth)
        Me.grpGeom.Controls.Add(Me.rdoTwo)
        Me.grpGeom.Controls.Add(Me.rdoOne)
        Me.grpGeom.Location = New System.Drawing.Point(11, 18)
        Me.grpGeom.Name = "grpGeom"
        Me.grpGeom.Size = New System.Drawing.Size(197, 45)
        Me.grpGeom.TabIndex = 13
        Me.grpGeom.TabStop = False
        Me.grpGeom.Tag = "Geom"
        Me.grpGeom.Text = "Geom"
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
        'lblDim
        '
        Me.lblDim.AutoSize = True
        Me.lblDim.Location = New System.Drawing.Point(7, 73)
        Me.lblDim.Name = "lblDim"
        Me.lblDim.Size = New System.Drawing.Size(97, 13)
        Me.lblDim.TabIndex = 15
        Me.lblDim.Text = "Dimensions to Plot:"
        '
        'nudDim1
        '
        Me.nudDim1.Location = New System.Drawing.Point(110, 70)
        Me.nudDim1.Name = "nudDim1"
        Me.nudDim1.Size = New System.Drawing.Size(41, 20)
        Me.nudDim1.TabIndex = 16
        '
        'nudDim2
        '
        Me.nudDim2.Location = New System.Drawing.Point(165, 70)
        Me.nudDim2.Name = "nudDim2"
        Me.nudDim2.Size = New System.Drawing.Size(41, 20)
        Me.nudDim2.TabIndex = 17
        '
        'rdoBiplot
        '
        Me.rdoBiplot.AutoSize = True
        Me.rdoBiplot.Location = New System.Drawing.Point(10, 83)
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
        Me.rdoVariablesPlot.Location = New System.Drawing.Point(10, 37)
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
        Me.rdoScreePlot.Checked = True
        Me.rdoScreePlot.Location = New System.Drawing.Point(10, 14)
        Me.rdoScreePlot.Name = "rdoScreePlot"
        Me.rdoScreePlot.Size = New System.Drawing.Size(74, 17)
        Me.rdoScreePlot.TabIndex = 0
        Me.rdoScreePlot.TabStop = True
        Me.rdoScreePlot.Tag = "Scree_Plot"
        Me.rdoScreePlot.Text = "Scree Plot"
        Me.rdoScreePlot.UseVisualStyleBackColor = True
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
        'sdgPrincipalComponentAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 412)
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
        Me.tbDisplay.PerformLayout()
        Me.tbGraphics.ResumeLayout(False)
        Me.tbGraphics.PerformLayout()
        Me.grpScree.ResumeLayout(False)
        Me.grpScree.PerformLayout()
        Me.grpGeom.ResumeLayout(False)
        Me.grpGeom.PerformLayout()
        CType(Me.nudDim1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDim2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents tbRegOptions As TabControl
    Friend WithEvents tbDisplay As TabPage
    Friend WithEvents tbGraphics As TabPage
    Friend WithEvents chkEigenValues As CheckBox
    Friend WithEvents chkEigenVectors As CheckBox
    Friend WithEvents tbSave As TabPage
    Friend WithEvents rdoIndividualsPlot As RadioButton
    Friend WithEvents rdoBiplot As RadioButton
    Friend WithEvents rdoVariablesPlot As RadioButton
    Friend WithEvents rdoScreePlot As RadioButton
    Friend WithEvents rdoBarPlot As RadioButton
    Friend WithEvents chkRotation As CheckBox
    Friend WithEvents ucrSelectorFactor As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFactorVariable As Label
    Friend WithEvents lblChoiceScree As Label
    Friend WithEvents grpGeom As GroupBox
    Friend WithEvents rdoBoth As RadioButton
    Friend WithEvents rdoTwo As RadioButton
    Friend WithEvents rdoOne As RadioButton
    Friend WithEvents nudDim2 As NumericUpDown
    Friend WithEvents nudDim1 As NumericUpDown
    Friend WithEvents lblDim As Label
    Friend WithEvents chkPercentageScree As CheckBox
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
    Friend WithEvents grpScree As GroupBox
    Friend WithEvents ucrLabel As ucrInputComboBox
End Class