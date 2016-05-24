
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
        Me.chkResiduals = New System.Windows.Forms.CheckBox()
        Me.chkEigenVectors = New System.Windows.Forms.CheckBox()
        Me.chkScores = New System.Windows.Forms.CheckBox()
        Me.chkEigenValues = New System.Windows.Forms.CheckBox()
        Me.tbGraphics = New System.Windows.Forms.TabPage()
        Me.grpGeom = New System.Windows.Forms.GroupBox()
        Me.chkBar = New System.Windows.Forms.CheckBox()
        Me.chkLine = New System.Windows.Forms.CheckBox()
        Me.lblChoice = New System.Windows.Forms.Label()
        Me.cmbChoice = New System.Windows.Forms.ComboBox()
        Me.chkScreePlot = New System.Windows.Forms.CheckBox()
        Me.tbSave = New System.Windows.Forms.TabPage()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.tbRegOptions.SuspendLayout()
        Me.tbDisplay.SuspendLayout()
        Me.tbGraphics.SuspendLayout()
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
        Me.tbRegOptions.Size = New System.Drawing.Size(254, 193)
        Me.tbRegOptions.TabIndex = 0
        '
        'tbDisplay
        '
        Me.tbDisplay.Controls.Add(Me.chkResiduals)
        Me.tbDisplay.Controls.Add(Me.chkEigenVectors)
        Me.tbDisplay.Controls.Add(Me.chkScores)
        Me.tbDisplay.Controls.Add(Me.chkEigenValues)
        Me.tbDisplay.Location = New System.Drawing.Point(4, 22)
        Me.tbDisplay.Name = "tbDisplay"
        Me.tbDisplay.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDisplay.Size = New System.Drawing.Size(246, 167)
        Me.tbDisplay.TabIndex = 0
        Me.tbDisplay.Tag = "Display"
        Me.tbDisplay.Text = "Display"
        Me.tbDisplay.UseVisualStyleBackColor = True
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
        Me.tbGraphics.Controls.Add(Me.grpGeom)
        Me.tbGraphics.Controls.Add(Me.lblChoice)
        Me.tbGraphics.Controls.Add(Me.cmbChoice)
        Me.tbGraphics.Controls.Add(Me.chkScreePlot)
        Me.tbGraphics.Location = New System.Drawing.Point(4, 22)
        Me.tbGraphics.Name = "tbGraphics"
        Me.tbGraphics.Padding = New System.Windows.Forms.Padding(3)
        Me.tbGraphics.Size = New System.Drawing.Size(246, 167)
        Me.tbGraphics.TabIndex = 1
        Me.tbGraphics.Tag = "Graphics"
        Me.tbGraphics.Text = "Graphics"
        Me.tbGraphics.UseVisualStyleBackColor = True
        '
        'grpGeom
        '
        Me.grpGeom.Controls.Add(Me.chkBar)
        Me.grpGeom.Controls.Add(Me.chkLine)
        Me.grpGeom.Location = New System.Drawing.Point(35, 31)
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
        Me.lblChoice.Location = New System.Drawing.Point(145, 44)
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
        Me.cmbChoice.Location = New System.Drawing.Point(190, 40)
        Me.cmbChoice.Name = "cmbChoice"
        Me.cmbChoice.Size = New System.Drawing.Size(50, 21)
        Me.cmbChoice.TabIndex = 3
        '
        'chkScreePlot
        '
        Me.chkScreePlot.AutoSize = True
        Me.chkScreePlot.Location = New System.Drawing.Point(10, 15)
        Me.chkScreePlot.Name = "chkScreePlot"
        Me.chkScreePlot.Size = New System.Drawing.Size(75, 17)
        Me.chkScreePlot.TabIndex = 0
        Me.chkScreePlot.Tag = "Scree_Plot"
        Me.chkScreePlot.Text = "Scree Plot"
        Me.chkScreePlot.UseVisualStyleBackColor = True
        '
        'tbSave
        '
        Me.tbSave.Location = New System.Drawing.Point(4, 22)
        Me.tbSave.Name = "tbSave"
        Me.tbSave.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSave.Size = New System.Drawing.Size(246, 167)
        Me.tbSave.TabIndex = 2
        Me.tbSave.Tag = "Save"
        Me.tbSave.Text = "Save"
        Me.tbSave.UseVisualStyleBackColor = True
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.Location = New System.Drawing.Point(41, 201)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(142, 30)
        Me.ucrSdgButtons.TabIndex = 0
        '
        'sdgPrincipalComponentAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 233)
        Me.Controls.Add(Me.tbRegOptions)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgPrincipalComponentAnalysis"
        Me.Tag = "PCA_Options"
        Me.Text = "PCA Options"
        Me.tbRegOptions.ResumeLayout(False)
        Me.tbDisplay.ResumeLayout(False)
        Me.tbDisplay.PerformLayout()
        Me.tbGraphics.ResumeLayout(False)
        Me.tbGraphics.PerformLayout()
        Me.grpGeom.ResumeLayout(False)
        Me.grpGeom.PerformLayout()
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
    Friend WithEvents chkScreePlot As CheckBox
    Friend WithEvents grpGeom As GroupBox
    Friend WithEvents chkBar As CheckBox
    Friend WithEvents chkLine As CheckBox
    Friend WithEvents lblChoice As Label
    Friend WithEvents cmbChoice As ComboBox
End Class