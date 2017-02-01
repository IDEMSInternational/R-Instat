<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgCanonicalCorrelation
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
        Me.rdoYVariables = New System.Windows.Forms.RadioButton()
        Me.rdoXVariables = New System.Windows.Forms.RadioButton()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.ucrChkCoefficients = New instat.ucrCheck()
        Me.ucrChkCanonicalCorrelations = New instat.ucrCheck()
        Me.grpGraphics = New System.Windows.Forms.GroupBox()
        Me.ucrChkPairwisePlot = New instat.ucrCheck()
        Me.ucrPnlPairwise = New instat.UcrPanel()
        Me.grpDisplay.SuspendLayout()
        Me.grpGraphics.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoYVariables
        '
        Me.rdoYVariables.AutoSize = True
        Me.rdoYVariables.Location = New System.Drawing.Point(49, 67)
        Me.rdoYVariables.Name = "rdoYVariables"
        Me.rdoYVariables.Size = New System.Drawing.Size(78, 17)
        Me.rdoYVariables.TabIndex = 0
        Me.rdoYVariables.TabStop = True
        Me.rdoYVariables.Tag = "Y_Variables"
        Me.rdoYVariables.Text = "Y Variables"
        Me.rdoYVariables.UseVisualStyleBackColor = True
        '
        'rdoXVariables
        '
        Me.rdoXVariables.AutoSize = True
        Me.rdoXVariables.Location = New System.Drawing.Point(49, 44)
        Me.rdoXVariables.Name = "rdoXVariables"
        Me.rdoXVariables.Size = New System.Drawing.Size(78, 17)
        Me.rdoXVariables.TabIndex = 3
        Me.rdoXVariables.TabStop = True
        Me.rdoXVariables.Tag = "X_Variables"
        Me.rdoXVariables.Text = "X Variables"
        Me.rdoXVariables.UseVisualStyleBackColor = True
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.Location = New System.Drawing.Point(26, 191)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(142, 30)
        Me.ucrSdgButtons.TabIndex = 2
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.ucrChkCoefficients)
        Me.grpDisplay.Controls.Add(Me.ucrChkCanonicalCorrelations)
        Me.grpDisplay.Location = New System.Drawing.Point(12, 10)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(171, 77)
        Me.grpDisplay.TabIndex = 0
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Text = "Display"
        '
        'ucrChkCoefficients
        '
        Me.ucrChkCoefficients.bAddRemoveParameter = True
        Me.ucrChkCoefficients.bChangeParameterValue = True
        Me.ucrChkCoefficients.Checked = False
        Me.ucrChkCoefficients.Location = New System.Drawing.Point(11, 45)
        Me.ucrChkCoefficients.Name = "ucrChkCoefficients"
        Me.ucrChkCoefficients.Size = New System.Drawing.Size(131, 20)
        Me.ucrChkCoefficients.TabIndex = 1
        '
        'ucrChkCanonicalCorrelations
        '
        Me.ucrChkCanonicalCorrelations.bAddRemoveParameter = True
        Me.ucrChkCanonicalCorrelations.bChangeParameterValue = True
        Me.ucrChkCanonicalCorrelations.Checked = False
        Me.ucrChkCanonicalCorrelations.Location = New System.Drawing.Point(11, 19)
        Me.ucrChkCanonicalCorrelations.Name = "ucrChkCanonicalCorrelations"
        Me.ucrChkCanonicalCorrelations.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkCanonicalCorrelations.TabIndex = 0
        '
        'grpGraphics
        '
        Me.grpGraphics.Controls.Add(Me.ucrChkPairwisePlot)
        Me.grpGraphics.Controls.Add(Me.rdoYVariables)
        Me.grpGraphics.Controls.Add(Me.rdoXVariables)
        Me.grpGraphics.Controls.Add(Me.ucrPnlPairwise)
        Me.grpGraphics.Location = New System.Drawing.Point(12, 86)
        Me.grpGraphics.Name = "grpGraphics"
        Me.grpGraphics.Size = New System.Drawing.Size(171, 95)
        Me.grpGraphics.TabIndex = 1
        Me.grpGraphics.TabStop = False
        Me.grpGraphics.Text = "Graphics"
        '
        'ucrChkPairwisePlot
        '
        Me.ucrChkPairwisePlot.bAddRemoveParameter = True
        Me.ucrChkPairwisePlot.bChangeParameterValue = True
        Me.ucrChkPairwisePlot.Checked = False
        Me.ucrChkPairwisePlot.Location = New System.Drawing.Point(19, 23)
        Me.ucrChkPairwisePlot.Name = "ucrChkPairwisePlot"
        Me.ucrChkPairwisePlot.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkPairwisePlot.TabIndex = 2
        '
        'ucrPnlPairwise
        '
        Me.ucrPnlPairwise.bAddRemoveParameter = True
        Me.ucrPnlPairwise.bChangeParameterValue = True
        Me.ucrPnlPairwise.Location = New System.Drawing.Point(14, 19)
        Me.ucrPnlPairwise.Name = "ucrPnlPairwise"
        Me.ucrPnlPairwise.Size = New System.Drawing.Size(128, 70)
        Me.ucrPnlPairwise.TabIndex = 1
        '
        'sdgCanonicalCorrelation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(195, 228)
        Me.Controls.Add(Me.grpGraphics)
        Me.Controls.Add(Me.grpDisplay)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgCanonicalCorrelation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "PCA_Options"
        Me.Text = "PCA Options"
        Me.grpDisplay.ResumeLayout(False)
        Me.grpGraphics.ResumeLayout(False)
        Me.grpGraphics.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents rdoYVariables As RadioButton
    Friend WithEvents rdoXVariables As RadioButton
    Friend WithEvents grpDisplay As GroupBox
    Friend WithEvents ucrChkCoefficients As ucrCheck
    Friend WithEvents ucrChkCanonicalCorrelations As ucrCheck
    Friend WithEvents grpGraphics As GroupBox
    Friend WithEvents ucrChkPairwisePlot As ucrCheck
    Friend WithEvents ucrPnlPairwise As UcrPanel
End Class