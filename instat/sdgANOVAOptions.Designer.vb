<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgANOVAOptions
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
        Me.tbcOptions = New System.Windows.Forms.TabControl()
        Me.tbpDisplay = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.chkStandardErrors = New System.Windows.Forms.CheckBox()
        Me.chkTableOfMeans = New System.Windows.Forms.CheckBox()
        Me.chkEstimateValues = New System.Windows.Forms.CheckBox()
        Me.chkANOVATable = New System.Windows.Forms.CheckBox()
        Me.tbpGraphics = New System.Windows.Forms.TabPage()
        Me.grpMeans = New System.Windows.Forms.GroupBox()
        Me.chkMeans = New System.Windows.Forms.CheckBox()
        Me.grpResiduals = New System.Windows.Forms.GroupBox()
        Me.chkResiduals = New System.Windows.Forms.CheckBox()
        Me.ucrBaseSdg = New instat.ucrButtonsSubdialogue()
        Me.chkConfidenceLimits = New System.Windows.Forms.CheckBox()
        Me.lblConfidenceLevel = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.tbcOptions.SuspendLayout()
        Me.tbpDisplay.SuspendLayout()
        Me.tbpGraphics.SuspendLayout()
        Me.grpMeans.SuspendLayout()
        Me.grpResiduals.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcOptions
        '
        Me.tbcOptions.Controls.Add(Me.tbpDisplay)
        Me.tbcOptions.Controls.Add(Me.tbpGraphics)
        Me.tbcOptions.Location = New System.Drawing.Point(-1, -1)
        Me.tbcOptions.Name = "tbcOptions"
        Me.tbcOptions.SelectedIndex = 0
        Me.tbcOptions.Size = New System.Drawing.Size(345, 208)
        Me.tbcOptions.TabIndex = 1
        '
        'tbpDisplay
        '
        Me.tbpDisplay.Controls.Add(Me.CheckBox1)
        Me.tbpDisplay.Controls.Add(Me.chkStandardErrors)
        Me.tbpDisplay.Controls.Add(Me.chkTableOfMeans)
        Me.tbpDisplay.Controls.Add(Me.chkEstimateValues)
        Me.tbpDisplay.Controls.Add(Me.chkANOVATable)
        Me.tbpDisplay.Location = New System.Drawing.Point(4, 22)
        Me.tbpDisplay.Name = "tbpDisplay"
        Me.tbpDisplay.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDisplay.Size = New System.Drawing.Size(323, 162)
        Me.tbpDisplay.TabIndex = 0
        Me.tbpDisplay.Tag = "Display"
        Me.tbpDisplay.Text = "Display"
        Me.tbpDisplay.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(10, 131)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(70, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Tag = "Contrasts"
        Me.CheckBox1.Text = "Contrasts"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'chkStandardErrors
        '
        Me.chkStandardErrors.AutoSize = True
        Me.chkStandardErrors.Location = New System.Drawing.Point(130, 98)
        Me.chkStandardErrors.Name = "chkStandardErrors"
        Me.chkStandardErrors.Size = New System.Drawing.Size(98, 17)
        Me.chkStandardErrors.TabIndex = 6
        Me.chkStandardErrors.Tag = "Standard_errors"
        Me.chkStandardErrors.Text = "Standard errors"
        Me.chkStandardErrors.UseVisualStyleBackColor = True
        '
        'chkTableOfMeans
        '
        Me.chkTableOfMeans.AutoSize = True
        Me.chkTableOfMeans.Location = New System.Drawing.Point(10, 98)
        Me.chkTableOfMeans.Name = "chkTableOfMeans"
        Me.chkTableOfMeans.Size = New System.Drawing.Size(114, 17)
        Me.chkTableOfMeans.TabIndex = 5
        Me.chkTableOfMeans.Tag = "Means_and_counts"
        Me.chkTableOfMeans.Text = "Means and counts"
        Me.chkTableOfMeans.UseVisualStyleBackColor = True
        '
        'chkEstimateValues
        '
        Me.chkEstimateValues.AutoSize = True
        Me.chkEstimateValues.Location = New System.Drawing.Point(10, 59)
        Me.chkEstimateValues.Name = "chkEstimateValues"
        Me.chkEstimateValues.Size = New System.Drawing.Size(67, 17)
        Me.chkEstimateValues.TabIndex = 4
        Me.chkEstimateValues.Tag = "P_values"
        Me.chkEstimateValues.Text = "P values"
        Me.chkEstimateValues.UseVisualStyleBackColor = True
        '
        'chkANOVATable
        '
        Me.chkANOVATable.AutoSize = True
        Me.chkANOVATable.Location = New System.Drawing.Point(10, 20)
        Me.chkANOVATable.Name = "chkANOVATable"
        Me.chkANOVATable.Size = New System.Drawing.Size(93, 17)
        Me.chkANOVATable.TabIndex = 1
        Me.chkANOVATable.Tag = "ANOVA Table"
        Me.chkANOVATable.Text = "ANOVA Table"
        Me.chkANOVATable.UseVisualStyleBackColor = True
        '
        'tbpGraphics
        '
        Me.tbpGraphics.Controls.Add(Me.grpMeans)
        Me.tbpGraphics.Controls.Add(Me.grpResiduals)
        Me.tbpGraphics.Location = New System.Drawing.Point(4, 22)
        Me.tbpGraphics.Name = "tbpGraphics"
        Me.tbpGraphics.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpGraphics.Size = New System.Drawing.Size(337, 182)
        Me.tbpGraphics.TabIndex = 1
        Me.tbpGraphics.Tag = "Graphics"
        Me.tbpGraphics.Text = "Graphics"
        Me.tbpGraphics.UseVisualStyleBackColor = True
        '
        'grpMeans
        '
        Me.grpMeans.Controls.Add(Me.NumericUpDown1)
        Me.grpMeans.Controls.Add(Me.lblConfidenceLevel)
        Me.grpMeans.Controls.Add(Me.chkConfidenceLimits)
        Me.grpMeans.Controls.Add(Me.chkMeans)
        Me.grpMeans.Location = New System.Drawing.Point(9, 78)
        Me.grpMeans.Name = "grpMeans"
        Me.grpMeans.Size = New System.Drawing.Size(288, 87)
        Me.grpMeans.TabIndex = 3
        Me.grpMeans.TabStop = False
        Me.grpMeans.Tag = "Means"
        Me.grpMeans.Text = "Means"
        '
        'chkMeans
        '
        Me.chkMeans.AutoSize = True
        Me.chkMeans.Location = New System.Drawing.Point(5, 19)
        Me.chkMeans.Name = "chkMeans"
        Me.chkMeans.Size = New System.Drawing.Size(58, 17)
        Me.chkMeans.TabIndex = 1
        Me.chkMeans.Tag = "Means"
        Me.chkMeans.Text = "Means"
        Me.chkMeans.UseVisualStyleBackColor = True
        '
        'grpResiduals
        '
        Me.grpResiduals.Controls.Add(Me.chkResiduals)
        Me.grpResiduals.Location = New System.Drawing.Point(9, 6)
        Me.grpResiduals.Name = "grpResiduals"
        Me.grpResiduals.Size = New System.Drawing.Size(288, 66)
        Me.grpResiduals.TabIndex = 2
        Me.grpResiduals.TabStop = False
        Me.grpResiduals.Tag = "Residuals"
        Me.grpResiduals.Text = "Residuals"
        '
        'chkResiduals
        '
        Me.chkResiduals.AutoSize = True
        Me.chkResiduals.Location = New System.Drawing.Point(6, 19)
        Me.chkResiduals.Name = "chkResiduals"
        Me.chkResiduals.Size = New System.Drawing.Size(76, 17)
        Me.chkResiduals.TabIndex = 0
        Me.chkResiduals.Tag = "Four_in_one"
        Me.chkResiduals.Text = "four in one"
        Me.chkResiduals.UseVisualStyleBackColor = True
        '
        'ucrBaseSdg
        '
        Me.ucrBaseSdg.Location = New System.Drawing.Point(65, 213)
        Me.ucrBaseSdg.Name = "ucrBaseSdg"
        Me.ucrBaseSdg.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSdg.TabIndex = 2
        '
        'chkConfidenceLimits
        '
        Me.chkConfidenceLimits.AutoSize = True
        Me.chkConfidenceLimits.Location = New System.Drawing.Point(6, 42)
        Me.chkConfidenceLimits.Name = "chkConfidenceLimits"
        Me.chkConfidenceLimits.Size = New System.Drawing.Size(105, 17)
        Me.chkConfidenceLimits.TabIndex = 2
        Me.chkConfidenceLimits.Tag = "Confidence_limits"
        Me.chkConfidenceLimits.Text = "Confidence limits"
        Me.chkConfidenceLimits.UseVisualStyleBackColor = True
        '
        'lblConfidenceLevel
        '
        Me.lblConfidenceLevel.AutoSize = True
        Me.lblConfidenceLevel.Location = New System.Drawing.Point(50, 68)
        Me.lblConfidenceLevel.Name = "lblConfidenceLevel"
        Me.lblConfidenceLevel.Size = New System.Drawing.Size(86, 13)
        Me.lblConfidenceLevel.TabIndex = 3
        Me.lblConfidenceLevel.Tag = "Confidence_level"
        Me.lblConfidenceLevel.Text = "Confidence level"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(149, 61)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(46, 20)
        Me.NumericUpDown1.TabIndex = 4
        Me.NumericUpDown1.Value = New Decimal(New Integer() {95, 0, 0, 0})
        '
        'sdgANOVAOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 268)
        Me.Controls.Add(Me.ucrBaseSdg)
        Me.Controls.Add(Me.tbcOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgANOVAOptions"
        Me.Tag = "ANOVA_options"
        Me.Text = "ANOVA options"
        Me.tbcOptions.ResumeLayout(False)
        Me.tbpDisplay.ResumeLayout(False)
        Me.tbpDisplay.PerformLayout()
        Me.tbpGraphics.ResumeLayout(False)
        Me.grpMeans.ResumeLayout(False)
        Me.grpMeans.PerformLayout()
        Me.grpResiduals.ResumeLayout(False)
        Me.grpResiduals.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents tbcOptions As TabControl
    Friend WithEvents tbpDisplay As TabPage
    Friend WithEvents chkTableOfMeans As CheckBox
    Friend WithEvents chkEstimateValues As CheckBox
    Friend WithEvents chkANOVATable As CheckBox
    Friend WithEvents tbpGraphics As TabPage
    Friend WithEvents chkMeans As CheckBox
    Friend WithEvents chkResiduals As CheckBox
    Friend WithEvents ucrBaseSdg As ucrButtonsSubdialogue
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents chkStandardErrors As CheckBox
    Friend WithEvents grpMeans As GroupBox
    Friend WithEvents grpResiduals As GroupBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents lblConfidenceLevel As Label
    Friend WithEvents chkConfidenceLimits As CheckBox
End Class
