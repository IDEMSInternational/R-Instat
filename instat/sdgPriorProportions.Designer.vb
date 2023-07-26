<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgPriorProportions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ucrNudPrioirNull = New instat.ucrInputComboBox()
        Me.lblPrioir = New System.Windows.Forms.Label()
        Me.grpHypothesisPrior = New System.Windows.Forms.GroupBox()
        Me.lblBataA = New System.Windows.Forms.Label()
        Me.grpBetaPriors = New System.Windows.Forms.GroupBox()
        Me.ucrNudBetaPrioirA = New instat.ucrNud()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.ucrNudBetaPrioirB = New instat.ucrNud()
        Me.lblBetaB = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrNudPrioirNull
        '
        Me.ucrNudPrioirNull.AddQuotesIfUnrecognised = True
        Me.ucrNudPrioirNull.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrNudPrioirNull.GetSetSelectedIndex = -1
        Me.ucrNudPrioirNull.IsReadOnly = False
        Me.ucrNudPrioirNull.Location = New System.Drawing.Point(42, 28)
        Me.ucrNudPrioirNull.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudPrioirNull.Name = "ucrNudPrioirNull"
        Me.ucrNudPrioirNull.Size = New System.Drawing.Size(81, 21)
        Me.ucrNudPrioirNull.TabIndex = 90
        '
        'lblPrioir
        '
        Me.lblPrioir.AutoSize = True
        Me.lblPrioir.Location = New System.Drawing.Point(12, 32)
        Me.lblPrioir.Name = "lblPrioir"
        Me.lblPrioir.Size = New System.Drawing.Size(24, 13)
        Me.lblPrioir.TabIndex = 88
        Me.lblPrioir.Text = "H1:"
        '
        'grpHypothesisPrior
        '
        Me.grpHypothesisPrior.Location = New System.Drawing.Point(5, 9)
        Me.grpHypothesisPrior.Name = "grpHypothesisPrior"
        Me.grpHypothesisPrior.Size = New System.Drawing.Size(146, 57)
        Me.grpHypothesisPrior.TabIndex = 89
        Me.grpHypothesisPrior.TabStop = False
        Me.grpHypothesisPrior.Text = "Hypothesis Prior"
        '
        'lblBataA
        '
        Me.lblBataA.AutoSize = True
        Me.lblBataA.Location = New System.Drawing.Point(13, 101)
        Me.lblBataA.Name = "lblBataA"
        Me.lblBataA.Size = New System.Drawing.Size(16, 13)
        Me.lblBataA.TabIndex = 91
        Me.lblBataA.Text = "a:"
        '
        'grpBetaPriors
        '
        Me.grpBetaPriors.Location = New System.Drawing.Point(6, 79)
        Me.grpBetaPriors.Name = "grpBetaPriors"
        Me.grpBetaPriors.Size = New System.Drawing.Size(145, 78)
        Me.grpBetaPriors.TabIndex = 92
        Me.grpBetaPriors.TabStop = False
        Me.grpBetaPriors.Text = "Beta Priors"
        '
        'ucrNudBetaPrioirA
        '
        Me.ucrNudBetaPrioirA.AutoSize = True
        Me.ucrNudBetaPrioirA.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBetaPrioirA.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBetaPrioirA.Location = New System.Drawing.Point(37, 98)
        Me.ucrNudBetaPrioirA.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBetaPrioirA.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBetaPrioirA.Name = "ucrNudBetaPrioirA"
        Me.ucrNudBetaPrioirA.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudBetaPrioirA.TabIndex = 93
        Me.ucrNudBetaPrioirA.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.AutoSize = True
        Me.ucrSdgButtons.Location = New System.Drawing.Point(3, 169)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(224, 30)
        Me.ucrSdgButtons.TabIndex = 94
        '
        'ucrNudBetaPrioirB
        '
        Me.ucrNudBetaPrioirB.AutoSize = True
        Me.ucrNudBetaPrioirB.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBetaPrioirB.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBetaPrioirB.Location = New System.Drawing.Point(37, 126)
        Me.ucrNudBetaPrioirB.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBetaPrioirB.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBetaPrioirB.Name = "ucrNudBetaPrioirB"
        Me.ucrNudBetaPrioirB.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudBetaPrioirB.TabIndex = 95
        Me.ucrNudBetaPrioirB.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblBetaB
        '
        Me.lblBetaB.AutoSize = True
        Me.lblBetaB.Location = New System.Drawing.Point(11, 130)
        Me.lblBetaB.Name = "lblBetaB"
        Me.lblBetaB.Size = New System.Drawing.Size(16, 13)
        Me.lblBetaB.TabIndex = 96
        Me.lblBetaB.Text = "b:"
        '
        'sdgPriorProportions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(228, 216)
        Me.Controls.Add(Me.lblBetaB)
        Me.Controls.Add(Me.ucrNudBetaPrioirB)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.Controls.Add(Me.ucrNudBetaPrioirA)
        Me.Controls.Add(Me.lblBataA)
        Me.Controls.Add(Me.grpBetaPriors)
        Me.Controls.Add(Me.ucrNudPrioirNull)
        Me.Controls.Add(Me.lblPrioir)
        Me.Controls.Add(Me.grpHypothesisPrior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgPriorProportions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Proportions Prioirs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrNudPrioirNull As ucrInputComboBox
    Friend WithEvents lblPrioir As Label
    Friend WithEvents grpHypothesisPrior As GroupBox
    Friend WithEvents lblBataA As Label
    Friend WithEvents grpBetaPriors As GroupBox
    Friend WithEvents ucrNudBetaPrioirA As ucrNud
    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents ucrNudBetaPrioirB As ucrNud
    Friend WithEvents lblBetaB As Label
End Class
