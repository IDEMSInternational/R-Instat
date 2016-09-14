<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgCanonicalCorrelationAnalysis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgCanonicalCorrelationAnalysis))
        Me.lblYVariables = New System.Windows.Forms.Label()
        Me.lblXVariables = New System.Windows.Forms.Label()
        Me.cmdCCAOptions = New System.Windows.Forms.Button()
        Me.chkSaveResult = New System.Windows.Forms.CheckBox()
        Me.ucrReceiverXvariables = New instat.ucrReceiverMultiple()
        Me.ucrReceiverYvariables = New instat.ucrReceiverMultiple()
        Me.ucrSelectorCCA = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBaseCCA = New instat.ucrButtons()
        Me.ucrResultName = New instat.ucrInputComboBox()
        Me.SuspendLayout()
        '
        'lblYVariables
        '
        resources.ApplyResources(Me.lblYVariables, "lblYVariables")
        Me.lblYVariables.Name = "lblYVariables"
        Me.lblYVariables.Tag = "Y_Variables"
        '
        'lblXVariables
        '
        resources.ApplyResources(Me.lblXVariables, "lblXVariables")
        Me.lblXVariables.Name = "lblXVariables"
        Me.lblXVariables.Tag = "X_Variables"
        '
        'cmdCCAOptions
        '
        resources.ApplyResources(Me.cmdCCAOptions, "cmdCCAOptions")
        Me.cmdCCAOptions.Name = "cmdCCAOptions"
        Me.cmdCCAOptions.Tag = "CCA_Options..."
        Me.cmdCCAOptions.UseVisualStyleBackColor = True
        '
        'chkSaveResult
        '
        resources.ApplyResources(Me.chkSaveResult, "chkSaveResult")
        Me.chkSaveResult.Name = "chkSaveResult"
        Me.chkSaveResult.Tag = "Save_Result"
        Me.chkSaveResult.UseVisualStyleBackColor = True
        '
        'ucrReceiverXvariables
        '
        resources.ApplyResources(Me.ucrReceiverXvariables, "ucrReceiverXvariables")
        Me.ucrReceiverXvariables.Name = "ucrReceiverXvariables"
        Me.ucrReceiverXvariables.Selector = Nothing
        '
        'ucrReceiverYvariables
        '
        resources.ApplyResources(Me.ucrReceiverYvariables, "ucrReceiverYvariables")
        Me.ucrReceiverYvariables.Name = "ucrReceiverYvariables"
        Me.ucrReceiverYvariables.Selector = Nothing
        '
        'ucrSelectorCCA
        '
        Me.ucrSelectorCCA.bShowHiddenColumns = False
        Me.ucrSelectorCCA.bUseCurrentFilter = False
        resources.ApplyResources(Me.ucrSelectorCCA, "ucrSelectorCCA")
        Me.ucrSelectorCCA.Name = "ucrSelectorCCA"
        '
        'ucrBaseCCA
        '
        resources.ApplyResources(Me.ucrBaseCCA, "ucrBaseCCA")
        Me.ucrBaseCCA.Name = "ucrBaseCCA"
        '
        'ucrResultName
        '
        Me.ucrResultName.IsReadOnly = False
        resources.ApplyResources(Me.ucrResultName, "ucrResultName")
        Me.ucrResultName.Name = "ucrResultName"
        '
        'dlgCanonicalCorrelationAnalysis
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrResultName)
        Me.Controls.Add(Me.chkSaveResult)
        Me.Controls.Add(Me.cmdCCAOptions)
        Me.Controls.Add(Me.lblXVariables)
        Me.Controls.Add(Me.lblYVariables)
        Me.Controls.Add(Me.ucrReceiverXvariables)
        Me.Controls.Add(Me.ucrReceiverYvariables)
        Me.Controls.Add(Me.ucrSelectorCCA)
        Me.Controls.Add(Me.ucrBaseCCA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCanonicalCorrelationAnalysis"
        Me.Tag = "Canonical_Correlation_Analysis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseCCA As ucrButtons
    Friend WithEvents ucrSelectorCCA As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverYvariables As ucrReceiverMultiple
    Friend WithEvents ucrReceiverXvariables As ucrReceiverMultiple
    Friend WithEvents lblYVariables As Label
    Friend WithEvents lblXVariables As Label
    Friend WithEvents cmdCCAOptions As Button
    Friend WithEvents chkSaveResult As CheckBox
    Friend WithEvents ucrResultName As ucrInputComboBox
End Class