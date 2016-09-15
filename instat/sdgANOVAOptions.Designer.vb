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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgANOVAOptions))
        Me.tbcOptions = New System.Windows.Forms.TabControl()
        Me.tbpDisplay = New System.Windows.Forms.TabPage()
        Me.chkContrasts = New System.Windows.Forms.CheckBox()
        Me.chkStandardErrors = New System.Windows.Forms.CheckBox()
        Me.chkMeansAndCounts = New System.Windows.Forms.CheckBox()
        Me.chkEstimateValues = New System.Windows.Forms.CheckBox()
        Me.chkANOVATable = New System.Windows.Forms.CheckBox()
        Me.tbpGraphics = New System.Windows.Forms.TabPage()
        Me.grpMeans = New System.Windows.Forms.GroupBox()
        Me.nudConfidenceLevel = New System.Windows.Forms.NumericUpDown()
        Me.lblConfidenceLevel = New System.Windows.Forms.Label()
        Me.chkConfidenceLimits = New System.Windows.Forms.CheckBox()
        Me.chkMeans = New System.Windows.Forms.CheckBox()
        Me.grpResiduals = New System.Windows.Forms.GroupBox()
        Me.chkResiduals = New System.Windows.Forms.CheckBox()
        Me.ucrBaseSdg = New instat.ucrButtonsSubdialogue()
        Me.tbcOptions.SuspendLayout()
        Me.tbpDisplay.SuspendLayout()
        Me.tbpGraphics.SuspendLayout()
        Me.grpMeans.SuspendLayout()
        CType(Me.nudConfidenceLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpResiduals.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcOptions
        '
        Me.tbcOptions.Controls.Add(Me.tbpDisplay)
        Me.tbcOptions.Controls.Add(Me.tbpGraphics)
        resources.ApplyResources(Me.tbcOptions, "tbcOptions")
        Me.tbcOptions.Name = "tbcOptions"
        Me.tbcOptions.SelectedIndex = 0
        '
        'tbpDisplay
        '
        Me.tbpDisplay.Controls.Add(Me.chkContrasts)
        Me.tbpDisplay.Controls.Add(Me.chkStandardErrors)
        Me.tbpDisplay.Controls.Add(Me.chkMeansAndCounts)
        Me.tbpDisplay.Controls.Add(Me.chkEstimateValues)
        Me.tbpDisplay.Controls.Add(Me.chkANOVATable)
        resources.ApplyResources(Me.tbpDisplay, "tbpDisplay")
        Me.tbpDisplay.Name = "tbpDisplay"
        Me.tbpDisplay.Tag = "Display"
        Me.tbpDisplay.UseVisualStyleBackColor = True
        '
        'chkContrasts
        '
        resources.ApplyResources(Me.chkContrasts, "chkContrasts")
        Me.chkContrasts.Name = "chkContrasts"
        Me.chkContrasts.Tag = "Contrasts"
        Me.chkContrasts.UseVisualStyleBackColor = True
        '
        'chkStandardErrors
        '
        resources.ApplyResources(Me.chkStandardErrors, "chkStandardErrors")
        Me.chkStandardErrors.Name = "chkStandardErrors"
        Me.chkStandardErrors.Tag = "Standard_errors"
        Me.chkStandardErrors.UseVisualStyleBackColor = True
        '
        'chkMeansAndCounts
        '
        resources.ApplyResources(Me.chkMeansAndCounts, "chkMeansAndCounts")
        Me.chkMeansAndCounts.Name = "chkMeansAndCounts"
        Me.chkMeansAndCounts.Tag = "Means_and_counts"
        Me.chkMeansAndCounts.UseVisualStyleBackColor = True
        '
        'chkEstimateValues
        '
        resources.ApplyResources(Me.chkEstimateValues, "chkEstimateValues")
        Me.chkEstimateValues.Name = "chkEstimateValues"
        Me.chkEstimateValues.Tag = "P_values"
        Me.chkEstimateValues.UseVisualStyleBackColor = True
        '
        'chkANOVATable
        '
        resources.ApplyResources(Me.chkANOVATable, "chkANOVATable")
        Me.chkANOVATable.Name = "chkANOVATable"
        Me.chkANOVATable.Tag = "ANOVA Table"
        Me.chkANOVATable.UseVisualStyleBackColor = True
        '
        'tbpGraphics
        '
        Me.tbpGraphics.Controls.Add(Me.grpMeans)
        Me.tbpGraphics.Controls.Add(Me.grpResiduals)
        resources.ApplyResources(Me.tbpGraphics, "tbpGraphics")
        Me.tbpGraphics.Name = "tbpGraphics"
        Me.tbpGraphics.Tag = "Graphics"
        Me.tbpGraphics.UseVisualStyleBackColor = True
        '
        'grpMeans
        '
        Me.grpMeans.Controls.Add(Me.nudConfidenceLevel)
        Me.grpMeans.Controls.Add(Me.lblConfidenceLevel)
        Me.grpMeans.Controls.Add(Me.chkConfidenceLimits)
        Me.grpMeans.Controls.Add(Me.chkMeans)
        resources.ApplyResources(Me.grpMeans, "grpMeans")
        Me.grpMeans.Name = "grpMeans"
        Me.grpMeans.TabStop = False
        Me.grpMeans.Tag = "Means"
        '
        'nudConfidenceLevel
        '
        resources.ApplyResources(Me.nudConfidenceLevel, "nudConfidenceLevel")
        Me.nudConfidenceLevel.Name = "nudConfidenceLevel"
        Me.nudConfidenceLevel.Value = New Decimal(New Integer() {95, 0, 0, 0})
        '
        'lblConfidenceLevel
        '
        resources.ApplyResources(Me.lblConfidenceLevel, "lblConfidenceLevel")
        Me.lblConfidenceLevel.Name = "lblConfidenceLevel"
        Me.lblConfidenceLevel.Tag = "Confidence_level"
        '
        'chkConfidenceLimits
        '
        resources.ApplyResources(Me.chkConfidenceLimits, "chkConfidenceLimits")
        Me.chkConfidenceLimits.Name = "chkConfidenceLimits"
        Me.chkConfidenceLimits.Tag = "Confidence_limits"
        Me.chkConfidenceLimits.UseVisualStyleBackColor = True
        '
        'chkMeans
        '
        resources.ApplyResources(Me.chkMeans, "chkMeans")
        Me.chkMeans.Name = "chkMeans"
        Me.chkMeans.Tag = "Means"
        Me.chkMeans.UseVisualStyleBackColor = True
        '
        'grpResiduals
        '
        Me.grpResiduals.Controls.Add(Me.chkResiduals)
        resources.ApplyResources(Me.grpResiduals, "grpResiduals")
        Me.grpResiduals.Name = "grpResiduals"
        Me.grpResiduals.TabStop = False
        Me.grpResiduals.Tag = "Residuals"
        '
        'chkResiduals
        '
        resources.ApplyResources(Me.chkResiduals, "chkResiduals")
        Me.chkResiduals.Name = "chkResiduals"
        Me.chkResiduals.Tag = "Four_in_one"
        Me.chkResiduals.UseVisualStyleBackColor = True
        '
        'ucrBaseSdg
        '
        resources.ApplyResources(Me.ucrBaseSdg, "ucrBaseSdg")
        Me.ucrBaseSdg.Name = "ucrBaseSdg"
        '
        'sdgANOVAOptions
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrBaseSdg)
        Me.Controls.Add(Me.tbcOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgANOVAOptions"
        Me.Tag = "ANOVA_options"
        Me.tbcOptions.ResumeLayout(False)
        Me.tbpDisplay.ResumeLayout(False)
        Me.tbpDisplay.PerformLayout()
        Me.tbpGraphics.ResumeLayout(False)
        Me.grpMeans.ResumeLayout(False)
        Me.grpMeans.PerformLayout()
        CType(Me.nudConfidenceLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpResiduals.ResumeLayout(False)
        Me.grpResiduals.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents tbcOptions As TabControl
    Friend WithEvents tbpDisplay As TabPage
    Friend WithEvents chkMeansAndCounts As CheckBox
    Friend WithEvents chkEstimateValues As CheckBox
    Friend WithEvents chkANOVATable As CheckBox
    Friend WithEvents tbpGraphics As TabPage
    Friend WithEvents chkMeans As CheckBox
    Friend WithEvents chkResiduals As CheckBox
    Friend WithEvents ucrBaseSdg As ucrButtonsSubdialogue
    Friend WithEvents chkContrasts As CheckBox
    Friend WithEvents chkStandardErrors As CheckBox
    Friend WithEvents grpMeans As GroupBox
    Friend WithEvents grpResiduals As GroupBox
    Friend WithEvents nudConfidenceLevel As NumericUpDown
    Friend WithEvents lblConfidenceLevel As Label
    Friend WithEvents chkConfidenceLimits As CheckBox
End Class
