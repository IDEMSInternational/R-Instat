<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgGeneralANOVA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgGeneralANOVA))
        Me.rdoAnalysis = New System.Windows.Forms.RadioButton()
        Me.rdoReplicates = New System.Windows.Forms.RadioButton()
        Me.lblYVariable = New System.Windows.Forms.Label()
        Me.lblTreatmentFactor = New System.Windows.Forms.Label()
        Me.lblLayout = New System.Windows.Forms.Label()
        Me.chkSaveModel = New System.Windows.Forms.CheckBox()
        Me.cmdGeneralANOVAOptions = New System.Windows.Forms.Button()
        Me.ucrModelName = New instat.ucrVariableName()
        Me.ucrReceiverYVariable = New instat.ucrReceiverSingle()
        Me.ucrReceiverTreatmentStructure = New instat.ucrReceiverSingle()
        Me.ucrReceiverLayout = New instat.ucrReceiverSingle()
        Me.ucrSelectorGeneralANOVA = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'rdoAnalysis
        '
        resources.ApplyResources(Me.rdoAnalysis, "rdoAnalysis")
        Me.rdoAnalysis.Name = "rdoAnalysis"
        Me.rdoAnalysis.TabStop = True
        Me.rdoAnalysis.Tag = "Analysis"
        Me.rdoAnalysis.UseVisualStyleBackColor = True
        '
        'rdoReplicates
        '
        resources.ApplyResources(Me.rdoReplicates, "rdoReplicates")
        Me.rdoReplicates.Name = "rdoReplicates"
        Me.rdoReplicates.TabStop = True
        Me.rdoReplicates.Tag = "Replicates"
        Me.rdoReplicates.UseVisualStyleBackColor = True
        '
        'lblYVariable
        '
        resources.ApplyResources(Me.lblYVariable, "lblYVariable")
        Me.lblYVariable.Name = "lblYVariable"
        Me.lblYVariable.Tag = "Y_variable"
        '
        'lblTreatmentFactor
        '
        resources.ApplyResources(Me.lblTreatmentFactor, "lblTreatmentFactor")
        Me.lblTreatmentFactor.Name = "lblTreatmentFactor"
        Me.lblTreatmentFactor.Tag = "Treatment_structure"
        '
        'lblLayout
        '
        resources.ApplyResources(Me.lblLayout, "lblLayout")
        Me.lblLayout.Name = "lblLayout"
        Me.lblLayout.Tag = "Layout"
        '
        'chkSaveModel
        '
        resources.ApplyResources(Me.chkSaveModel, "chkSaveModel")
        Me.chkSaveModel.Name = "chkSaveModel"
        Me.chkSaveModel.Tag = "Save_Model"
        Me.chkSaveModel.UseVisualStyleBackColor = True
        '
        'cmdGeneralANOVAOptions
        '
        resources.ApplyResources(Me.cmdGeneralANOVAOptions, "cmdGeneralANOVAOptions")
        Me.cmdGeneralANOVAOptions.Name = "cmdGeneralANOVAOptions"
        Me.cmdGeneralANOVAOptions.Tag = "General_ANOVA_Options..."
        Me.cmdGeneralANOVAOptions.UseVisualStyleBackColor = True
        '
        'ucrModelName
        '
        resources.ApplyResources(Me.ucrModelName, "ucrModelName")
        Me.ucrModelName.Name = "ucrModelName"
        '
        'ucrReceiverYVariable
        '
        resources.ApplyResources(Me.ucrReceiverYVariable, "ucrReceiverYVariable")
        Me.ucrReceiverYVariable.Name = "ucrReceiverYVariable"
        Me.ucrReceiverYVariable.Selector = Nothing
        '
        'ucrReceiverTreatmentStructure
        '
        resources.ApplyResources(Me.ucrReceiverTreatmentStructure, "ucrReceiverTreatmentStructure")
        Me.ucrReceiverTreatmentStructure.Name = "ucrReceiverTreatmentStructure"
        Me.ucrReceiverTreatmentStructure.Selector = Nothing
        '
        'ucrReceiverLayout
        '
        resources.ApplyResources(Me.ucrReceiverLayout, "ucrReceiverLayout")
        Me.ucrReceiverLayout.Name = "ucrReceiverLayout"
        Me.ucrReceiverLayout.Selector = Nothing
        '
        'ucrSelectorGeneralANOVA
        '
        Me.ucrSelectorGeneralANOVA.bShowHiddenColumns = False
        Me.ucrSelectorGeneralANOVA.bUseCurrentFilter = False
        resources.ApplyResources(Me.ucrSelectorGeneralANOVA, "ucrSelectorGeneralANOVA")
        Me.ucrSelectorGeneralANOVA.Name = "ucrSelectorGeneralANOVA"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgGeneralANOVA
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkSaveModel)
        Me.Controls.Add(Me.ucrModelName)
        Me.Controls.Add(Me.cmdGeneralANOVAOptions)
        Me.Controls.Add(Me.lblLayout)
        Me.Controls.Add(Me.lblTreatmentFactor)
        Me.Controls.Add(Me.lblYVariable)
        Me.Controls.Add(Me.ucrReceiverYVariable)
        Me.Controls.Add(Me.ucrReceiverTreatmentStructure)
        Me.Controls.Add(Me.ucrReceiverLayout)
        Me.Controls.Add(Me.ucrSelectorGeneralANOVA)
        Me.Controls.Add(Me.rdoReplicates)
        Me.Controls.Add(Me.rdoAnalysis)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgGeneralANOVA"
        Me.Tag = "General_ANOVA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents rdoAnalysis As RadioButton
    Friend WithEvents rdoReplicates As RadioButton
    Friend WithEvents ucrSelectorGeneralANOVA As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverLayout As ucrReceiverSingle
    Friend WithEvents ucrReceiverTreatmentStructure As ucrReceiverSingle
    Friend WithEvents ucrReceiverYVariable As ucrReceiverSingle
    Friend WithEvents lblYVariable As Label
    Friend WithEvents lblTreatmentFactor As Label
    Friend WithEvents lblLayout As Label
    Friend WithEvents chkSaveModel As CheckBox
    Friend WithEvents ucrModelName As ucrVariableName
    Friend WithEvents cmdGeneralANOVAOptions As Button
End Class
