
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
        Me.chkResiduals = New System.Windows.Forms.CheckBox()
        Me.chkEigenVectors = New System.Windows.Forms.CheckBox()
        Me.chkScores = New System.Windows.Forms.CheckBox()
        Me.chkEigenValues = New System.Windows.Forms.CheckBox()
        Me.tbGraphics = New System.Windows.Forms.TabPage()
        Me.rdoBarPlot = New System.Windows.Forms.RadioButton()
        Me.rdoIndividualsPlot = New System.Windows.Forms.RadioButton()
        Me.rdoBiplot = New System.Windows.Forms.RadioButton()
        Me.rdoVariablesPlot = New System.Windows.Forms.RadioButton()
        Me.rdoScreePlot = New System.Windows.Forms.RadioButton()
        Me.tbGrapOptions = New System.Windows.Forms.TabControl()
        Me.tbScreePlot = New System.Windows.Forms.TabPage()
        Me.grpGeom = New System.Windows.Forms.GroupBox()
        Me.chkBar = New System.Windows.Forms.CheckBox()
        Me.chkLine = New System.Windows.Forms.CheckBox()
        Me.lblChoice = New System.Windows.Forms.Label()
        Me.cmbChoice = New System.Windows.Forms.ComboBox()
        Me.tbVariables = New System.Windows.Forms.TabPage()
        Me.tbIndividuals = New System.Windows.Forms.TabPage()
        Me.tbBiplot = New System.Windows.Forms.TabPage()
        Me.tbBarPlot = New System.Windows.Forms.TabPage()
        Me.ucrReceiverFactor = New instat.ucrReceiverMultiple()
        Me.ucrSelectorFactor = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblFactorVariable = New System.Windows.Forms.Label()
        Me.tbSave = New System.Windows.Forms.TabPage()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.tbRegOptions.SuspendLayout()
        Me.tbDisplay.SuspendLayout()
        Me.tbGraphics.SuspendLayout()
        Me.tbGrapOptions.SuspendLayout()
        Me.tbScreePlot.SuspendLayout()
        Me.grpGeom.SuspendLayout()
        Me.tbBarPlot.SuspendLayout()
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
        Me.tbRegOptions.Size = New System.Drawing.Size(416, 296)
        Me.tbRegOptions.TabIndex = 0
        '
        'tbDisplay
        '
        Me.tbDisplay.Controls.Add(Me.chkRotation)
        Me.tbDisplay.Controls.Add(Me.chkResiduals)
        Me.tbDisplay.Controls.Add(Me.chkEigenVectors)
        Me.tbDisplay.Controls.Add(Me.chkScores)
        Me.tbDisplay.Controls.Add(Me.chkEigenValues)
        Me.tbDisplay.Location = New System.Drawing.Point(4, 22)
        Me.tbDisplay.Name = "tbDisplay"
        Me.tbDisplay.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDisplay.Size = New System.Drawing.Size(408, 270)
        Me.tbDisplay.TabIndex = 0
        Me.tbDisplay.Tag = "Display"
        Me.tbDisplay.Text = "Display"
        Me.tbDisplay.UseVisualStyleBackColor = True
        '
        'chkRotation
        '
        Me.chkRotation.AutoSize = True
        Me.chkRotation.Location = New System.Drawing.Point(6, 107)
        Me.chkRotation.Name = "chkRotation"
        Me.chkRotation.Size = New System.Drawing.Size(66, 17)
        Me.chkRotation.TabIndex = 4
        Me.chkRotation.Tag = "Rotation"
        Me.chkRotation.Text = "Rotation"
        Me.chkRotation.UseVisualStyleBackColor = True
        '
        'chkResiduals
        '
        Me.chkResiduals.AutoSize = True
        Me.chkResiduals.Location = New System.Drawing.Point(6, 84)
        Me.chkResiduals.Name = "chkResiduals"
        Me.chkResiduals.Size = New System.Drawing.Size(72, 17)
        Me.chkResiduals.TabIndex = 3
        Me.chkResiduals.Tag = "Residuals"
        Me.chkResiduals.Text = "Residuals"
        Me.chkResiduals.UseVisualStyleBackColor = True
        '
        'chkEigenVectors
        '
        Me.chkEigenVectors.AutoSize = True
        Me.chkEigenVectors.Location = New System.Drawing.Point(6, 38)
        Me.chkEigenVectors.Name = "chkEigenVectors"
        Me.chkEigenVectors.Size = New System.Drawing.Size(92, 17)
        Me.chkEigenVectors.TabIndex = 2
        Me.chkEigenVectors.Tag = "Eigen_Vectors"
        Me.chkEigenVectors.Text = "Eigen Vectors"
        Me.chkEigenVectors.UseVisualStyleBackColor = True
        '
        'chkScores
        '
        Me.chkScores.AutoSize = True
        Me.chkScores.Location = New System.Drawing.Point(6, 61)
        Me.chkScores.Name = "chkScores"
        Me.chkScores.Size = New System.Drawing.Size(59, 17)
        Me.chkScores.TabIndex = 1
        Me.chkScores.Tag = "Scores"
        Me.chkScores.Text = "Scores"
        Me.chkScores.UseVisualStyleBackColor = True
        '
        'chkEigenValues
        '
        Me.chkEigenValues.AutoSize = True
        Me.chkEigenValues.Location = New System.Drawing.Point(6, 15)
        Me.chkEigenValues.Name = "chkEigenValues"
        Me.chkEigenValues.Size = New System.Drawing.Size(88, 17)
        Me.chkEigenValues.TabIndex = 0
        Me.chkEigenValues.Tag = "Eigen_Values"
        Me.chkEigenValues.Text = "Eigen Values"
        Me.chkEigenValues.UseVisualStyleBackColor = True
        '
        'tbGraphics
        '
        Me.tbGraphics.Controls.Add(Me.rdoBarPlot)
        Me.tbGraphics.Controls.Add(Me.rdoIndividualsPlot)
        Me.tbGraphics.Controls.Add(Me.rdoBiplot)
        Me.tbGraphics.Controls.Add(Me.rdoVariablesPlot)
        Me.tbGraphics.Controls.Add(Me.rdoScreePlot)
        Me.tbGraphics.Controls.Add(Me.tbGrapOptions)
        Me.tbGraphics.Location = New System.Drawing.Point(4, 22)
        Me.tbGraphics.Name = "tbGraphics"
        Me.tbGraphics.Padding = New System.Windows.Forms.Padding(3)
        Me.tbGraphics.Size = New System.Drawing.Size(408, 270)
        Me.tbGraphics.TabIndex = 1
        Me.tbGraphics.Tag = "Graphics"
        Me.tbGraphics.Text = "Graphics"
        Me.tbGraphics.UseVisualStyleBackColor = True
        '
        'rdoBarPlot
        '
        Me.rdoBarPlot.AutoSize = True
        Me.rdoBarPlot.Location = New System.Drawing.Point(335, 14)
        Me.rdoBarPlot.Name = "rdoBarPlot"
        Me.rdoBarPlot.Size = New System.Drawing.Size(61, 17)
        Me.rdoBarPlot.TabIndex = 12
        Me.rdoBarPlot.TabStop = True
        Me.rdoBarPlot.Tag = "Bar plot"
        Me.rdoBarPlot.Text = "Bar plot"
        Me.rdoBarPlot.UseVisualStyleBackColor = True
        '
        'rdoIndividualsPlot
        '
        Me.rdoIndividualsPlot.AutoSize = True
        Me.rdoIndividualsPlot.Location = New System.Drawing.Point(179, 14)
        Me.rdoIndividualsPlot.Name = "rdoIndividualsPlot"
        Me.rdoIndividualsPlot.Size = New System.Drawing.Size(96, 17)
        Me.rdoIndividualsPlot.TabIndex = 11
        Me.rdoIndividualsPlot.TabStop = True
        Me.rdoIndividualsPlot.Tag = "Individuals_Plot"
        Me.rdoIndividualsPlot.Text = "Individuals Plot"
        Me.rdoIndividualsPlot.UseVisualStyleBackColor = True
        '
        'rdoBiplot
        '
        Me.rdoBiplot.AutoSize = True
        Me.rdoBiplot.Location = New System.Drawing.Point(281, 14)
        Me.rdoBiplot.Name = "rdoBiplot"
        Me.rdoBiplot.Size = New System.Drawing.Size(51, 17)
        Me.rdoBiplot.TabIndex = 10
        Me.rdoBiplot.TabStop = True
        Me.rdoBiplot.Tag = "Biplot"
        Me.rdoBiplot.Text = "Biplot"
        Me.rdoBiplot.UseVisualStyleBackColor = True
        '
        'rdoVariablesPlot
        '
        Me.rdoVariablesPlot.AutoSize = True
        Me.rdoVariablesPlot.Location = New System.Drawing.Point(84, 14)
        Me.rdoVariablesPlot.Name = "rdoVariablesPlot"
        Me.rdoVariablesPlot.Size = New System.Drawing.Size(89, 17)
        Me.rdoVariablesPlot.TabIndex = 9
        Me.rdoVariablesPlot.TabStop = True
        Me.rdoVariablesPlot.Tag = "Variables_Plot"
        Me.rdoVariablesPlot.Text = "Variables Plot"
        Me.rdoVariablesPlot.UseVisualStyleBackColor = True
        '
        'rdoScreePlot
        '
        Me.rdoScreePlot.AutoSize = True
        Me.rdoScreePlot.Location = New System.Drawing.Point(10, 14)
        Me.rdoScreePlot.Name = "rdoScreePlot"
        Me.rdoScreePlot.Size = New System.Drawing.Size(74, 17)
        Me.rdoScreePlot.TabIndex = 8
        Me.rdoScreePlot.TabStop = True
        Me.rdoScreePlot.Tag = "Scree_Plot"
        Me.rdoScreePlot.Text = "Scree Plot"
        Me.rdoScreePlot.UseVisualStyleBackColor = True
        '
        'tbGrapOptions
        '
        Me.tbGrapOptions.Controls.Add(Me.tbScreePlot)
        Me.tbGrapOptions.Controls.Add(Me.tbVariables)
        Me.tbGrapOptions.Controls.Add(Me.tbIndividuals)
        Me.tbGrapOptions.Controls.Add(Me.tbBiplot)
        Me.tbGrapOptions.Controls.Add(Me.tbBarPlot)
        Me.tbGrapOptions.Location = New System.Drawing.Point(8, 37)
        Me.tbGrapOptions.Name = "tbGrapOptions"
        Me.tbGrapOptions.SelectedIndex = 0
        Me.tbGrapOptions.Size = New System.Drawing.Size(394, 224)
        Me.tbGrapOptions.TabIndex = 7
        '
        'tbScreePlot
        '
        Me.tbScreePlot.Controls.Add(Me.grpGeom)
        Me.tbScreePlot.Controls.Add(Me.lblChoice)
        Me.tbScreePlot.Controls.Add(Me.cmbChoice)
        Me.tbScreePlot.Location = New System.Drawing.Point(4, 22)
        Me.tbScreePlot.Name = "tbScreePlot"
        Me.tbScreePlot.Padding = New System.Windows.Forms.Padding(3)
        Me.tbScreePlot.Size = New System.Drawing.Size(386, 198)
        Me.tbScreePlot.TabIndex = 0
        Me.tbScreePlot.Tag = "Scree_Plot"
        Me.tbScreePlot.Text = "Scree Plot"
        Me.tbScreePlot.UseVisualStyleBackColor = True
        '
        'grpGeom
        '
        Me.grpGeom.Controls.Add(Me.chkBar)
        Me.grpGeom.Controls.Add(Me.chkLine)
        Me.grpGeom.Location = New System.Drawing.Point(6, 15)
        Me.grpGeom.Name = "grpGeom"
        Me.grpGeom.Size = New System.Drawing.Size(99, 38)
        Me.grpGeom.TabIndex = 6
        Me.grpGeom.TabStop = False
        Me.grpGeom.Tag = "Geom"
        Me.grpGeom.Text = "Geom"
        '
        'chkBar
        '
        Me.chkBar.AutoSize = True
        Me.chkBar.Location = New System.Drawing.Point(8, 15)
        Me.chkBar.Name = "chkBar"
        Me.chkBar.Size = New System.Drawing.Size(42, 17)
        Me.chkBar.TabIndex = 2
        Me.chkBar.Tag = "Bar"
        Me.chkBar.Text = "Bar"
        Me.chkBar.UseVisualStyleBackColor = True
        '
        'chkLine
        '
        Me.chkLine.AutoSize = True
        Me.chkLine.Location = New System.Drawing.Point(52, 15)
        Me.chkLine.Name = "chkLine"
        Me.chkLine.Size = New System.Drawing.Size(46, 17)
        Me.chkLine.TabIndex = 1
        Me.chkLine.Tag = "Line"
        Me.chkLine.Text = "Line"
        Me.chkLine.UseVisualStyleBackColor = True
        '
        'lblChoice
        '
        Me.lblChoice.AutoSize = True
        Me.lblChoice.Location = New System.Drawing.Point(123, 30)
        Me.lblChoice.Name = "lblChoice"
        Me.lblChoice.Size = New System.Drawing.Size(40, 13)
        Me.lblChoice.TabIndex = 4
        Me.lblChoice.Tag = "Choice"
        Me.lblChoice.Text = "Choice"
        '
        'cmbChoice
        '
        Me.cmbChoice.FormattingEnabled = True
        Me.cmbChoice.Items.AddRange(New Object() {"variance", "eigenvalue"})
        Me.cmbChoice.Location = New System.Drawing.Point(168, 26)
        Me.cmbChoice.Name = "cmbChoice"
        Me.cmbChoice.Size = New System.Drawing.Size(50, 21)
        Me.cmbChoice.TabIndex = 3
        '
        'tbVariables
        '
        Me.tbVariables.Location = New System.Drawing.Point(4, 22)
        Me.tbVariables.Name = "tbVariables"
        Me.tbVariables.Padding = New System.Windows.Forms.Padding(3)
        Me.tbVariables.Size = New System.Drawing.Size(386, 198)
        Me.tbVariables.TabIndex = 1
        Me.tbVariables.Tag = "Variables"
        Me.tbVariables.Text = "Variables"
        Me.tbVariables.UseVisualStyleBackColor = True
        '
        'tbIndividuals
        '
        Me.tbIndividuals.Location = New System.Drawing.Point(4, 22)
        Me.tbIndividuals.Name = "tbIndividuals"
        Me.tbIndividuals.Padding = New System.Windows.Forms.Padding(3)
        Me.tbIndividuals.Size = New System.Drawing.Size(386, 198)
        Me.tbIndividuals.TabIndex = 2
        Me.tbIndividuals.Tag = "Individuals"
        Me.tbIndividuals.Text = "Individuals"
        Me.tbIndividuals.UseVisualStyleBackColor = True
        '
        'tbBiplot
        '
        Me.tbBiplot.Location = New System.Drawing.Point(4, 22)
        Me.tbBiplot.Name = "tbBiplot"
        Me.tbBiplot.Padding = New System.Windows.Forms.Padding(3)
        Me.tbBiplot.Size = New System.Drawing.Size(386, 198)
        Me.tbBiplot.TabIndex = 3
        Me.tbBiplot.Tag = "Biplot"
        Me.tbBiplot.Text = "Biplot"
        Me.tbBiplot.UseVisualStyleBackColor = True
        '
        'tbBarPlot
        '
        Me.tbBarPlot.Controls.Add(Me.ucrReceiverFactor)
        Me.tbBarPlot.Controls.Add(Me.ucrSelectorFactor)
        Me.tbBarPlot.Controls.Add(Me.lblFactorVariable)
        Me.tbBarPlot.Location = New System.Drawing.Point(4, 22)
        Me.tbBarPlot.Name = "tbBarPlot"
        Me.tbBarPlot.Padding = New System.Windows.Forms.Padding(3)
        Me.tbBarPlot.Size = New System.Drawing.Size(386, 198)
        Me.tbBarPlot.TabIndex = 4
        Me.tbBarPlot.Tag = "Bar_Plot"
        Me.tbBarPlot.Text = "Bar Plot"
        Me.tbBarPlot.UseVisualStyleBackColor = True
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(253, 43)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverFactor.TabIndex = 4
        '
        'ucrSelectorFactor
        '
        Me.ucrSelectorFactor.bShowHiddenColumns = False
        Me.ucrSelectorFactor.bUseCurrentFilter = False
        Me.ucrSelectorFactor.Location = New System.Drawing.Point(12, 8)
        Me.ucrSelectorFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFactor.Name = "ucrSelectorFactor"
        Me.ucrSelectorFactor.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorFactor.TabIndex = 3
        '
        'lblFactorVariable
        '
        Me.lblFactorVariable.AutoSize = True
        Me.lblFactorVariable.Location = New System.Drawing.Point(285, 18)
        Me.lblFactorVariable.Name = "lblFactorVariable"
        Me.lblFactorVariable.Size = New System.Drawing.Size(78, 13)
        Me.lblFactorVariable.TabIndex = 2
        Me.lblFactorVariable.Tag = "Factor_Variable"
        Me.lblFactorVariable.Text = "Factor Variable"
        '
        'tbSave
        '
        Me.tbSave.Location = New System.Drawing.Point(4, 22)
        Me.tbSave.Name = "tbSave"
        Me.tbSave.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSave.Size = New System.Drawing.Size(408, 270)
        Me.tbSave.TabIndex = 2
        Me.tbSave.Tag = "Save"
        Me.tbSave.Text = "Save"
        Me.tbSave.UseVisualStyleBackColor = True
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.Location = New System.Drawing.Point(139, 305)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(142, 30)
        Me.ucrSdgButtons.TabIndex = 0
        '
        'sdgPrincipalComponentAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 339)
        Me.Controls.Add(Me.tbRegOptions)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgPrincipalComponentAnalysis"
        Me.Tag = "PCA_Options"
        Me.Text = "PCA Options"
        Me.tbRegOptions.ResumeLayout(False)
        Me.tbDisplay.ResumeLayout(False)
        Me.tbDisplay.PerformLayout()
        Me.tbGraphics.ResumeLayout(False)
        Me.tbGraphics.PerformLayout()
        Me.tbGrapOptions.ResumeLayout(False)
        Me.tbScreePlot.ResumeLayout(False)
        Me.tbScreePlot.PerformLayout()
        Me.grpGeom.ResumeLayout(False)
        Me.grpGeom.PerformLayout()
        Me.tbBarPlot.ResumeLayout(False)
        Me.tbBarPlot.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents tbRegOptions As TabControl
    Friend WithEvents tbDisplay As TabPage
    Friend WithEvents tbGraphics As TabPage
    Friend WithEvents chkEigenValues As CheckBox
    Friend WithEvents chkEigenVectors As CheckBox
    Friend WithEvents chkScores As CheckBox
    Friend WithEvents chkResiduals As CheckBox
    Friend WithEvents tbSave As TabPage
    Friend WithEvents grpGeom As GroupBox
    Friend WithEvents chkBar As CheckBox
    Friend WithEvents chkLine As CheckBox
    Friend WithEvents lblChoice As Label
    Friend WithEvents cmbChoice As ComboBox
    Friend WithEvents rdoIndividualsPlot As RadioButton
    Friend WithEvents rdoBiplot As RadioButton
    Friend WithEvents rdoVariablesPlot As RadioButton
    Friend WithEvents rdoScreePlot As RadioButton
    Friend WithEvents tbGrapOptions As TabControl
    Friend WithEvents tbScreePlot As TabPage
    Friend WithEvents tbVariables As TabPage
    Friend WithEvents tbIndividuals As TabPage
    Friend WithEvents tbBiplot As TabPage
    Friend WithEvents rdoBarPlot As RadioButton
    Friend WithEvents tbBarPlot As TabPage
    Friend WithEvents chkRotation As CheckBox
    Friend WithEvents ucrSelectorFactor As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFactorVariable As Label
    Friend WithEvents ucrReceiverFactor As ucrReceiverMultiple
End Class