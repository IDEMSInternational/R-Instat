<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgThreeVariableModelling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgThreeVariableModelling))
        Me.chkSaveModel = New System.Windows.Forms.CheckBox()
        Me.lblFirstExplanatoryVariable = New System.Windows.Forms.Label()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.lblSecondExplanatoryVariable = New System.Windows.Forms.Label()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.lblModelPreview = New System.Windows.Forms.Label()
        Me.cmdModelOptions = New System.Windows.Forms.Button()
        Me.chkConvertToVariate = New System.Windows.Forms.CheckBox()
        Me.chkFirstFunction = New System.Windows.Forms.CheckBox()
        Me.ucrModelPreview = New instat.ucrInputTextBox()
        Me.ucrFamily = New instat.ucrDistributions()
        Me.ucrSecondExplanatory = New instat.ucrReceiverSingle()
        Me.ucrFirstExplanatory = New instat.ucrReceiverSingle()
        Me.ucrResponse = New instat.ucrReceiverSingle()
        Me.ucrSelectorThreeVariableModelling = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBaseThreeVariableModelling = New instat.ucrButtons()
        Me.chkSecondFunction = New System.Windows.Forms.CheckBox()
        Me.ucrModelName = New instat.ucrInputComboBox()
        Me.ucrModelOperator = New instat.ucrInputComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkResponseFunction = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'chkSaveModel
        '
        resources.ApplyResources(Me.chkSaveModel, "chkSaveModel")
        Me.chkSaveModel.Name = "chkSaveModel"
        Me.chkSaveModel.Tag = "Save_Model"
        Me.chkSaveModel.UseVisualStyleBackColor = True
        '
        'lblFirstExplanatoryVariable
        '
        resources.ApplyResources(Me.lblFirstExplanatoryVariable, "lblFirstExplanatoryVariable")
        Me.lblFirstExplanatoryVariable.Name = "lblFirstExplanatoryVariable"
        Me.lblFirstExplanatoryVariable.Tag = "First_Explanatory_Variable"
        '
        'lblResponse
        '
        resources.ApplyResources(Me.lblResponse, "lblResponse")
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Tag = "Response_Variable"
        '
        'lblSecondExplanatoryVariable
        '
        resources.ApplyResources(Me.lblSecondExplanatoryVariable, "lblSecondExplanatoryVariable")
        Me.lblSecondExplanatoryVariable.Name = "lblSecondExplanatoryVariable"
        Me.lblSecondExplanatoryVariable.Tag = "Second_Explanatory_Variable"
        '
        'cmdDisplayOptions
        '
        resources.ApplyResources(Me.cmdDisplayOptions, "cmdDisplayOptions")
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Tag = "Display_Options"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'lblModelPreview
        '
        resources.ApplyResources(Me.lblModelPreview, "lblModelPreview")
        Me.lblModelPreview.Name = "lblModelPreview"
        Me.lblModelPreview.Tag = "Model_Preview"
        '
        'cmdModelOptions
        '
        resources.ApplyResources(Me.cmdModelOptions, "cmdModelOptions")
        Me.cmdModelOptions.Name = "cmdModelOptions"
        Me.cmdModelOptions.Tag = "Model_Options"
        Me.cmdModelOptions.UseVisualStyleBackColor = True
        '
        'chkConvertToVariate
        '
        resources.ApplyResources(Me.chkConvertToVariate, "chkConvertToVariate")
        Me.chkConvertToVariate.Name = "chkConvertToVariate"
        Me.chkConvertToVariate.Tag = "Convert_to_Variate"
        Me.chkConvertToVariate.UseVisualStyleBackColor = True
        '
        'chkFirstFunction
        '
        resources.ApplyResources(Me.chkFirstFunction, "chkFirstFunction")
        Me.chkFirstFunction.Name = "chkFirstFunction"
        Me.chkFirstFunction.Tag = "Function"
        Me.chkFirstFunction.UseVisualStyleBackColor = True
        '
        'ucrModelPreview
        '
        Me.ucrModelPreview.IsReadOnly = False
        resources.ApplyResources(Me.ucrModelPreview, "ucrModelPreview")
        Me.ucrModelPreview.Name = "ucrModelPreview"
        '
        'ucrFamily
        '
        resources.ApplyResources(Me.ucrFamily, "ucrFamily")
        Me.ucrFamily.Name = "ucrFamily"
        '
        'ucrSecondExplanatory
        '
        resources.ApplyResources(Me.ucrSecondExplanatory, "ucrSecondExplanatory")
        Me.ucrSecondExplanatory.Name = "ucrSecondExplanatory"
        Me.ucrSecondExplanatory.Selector = Nothing
        '
        'ucrFirstExplanatory
        '
        resources.ApplyResources(Me.ucrFirstExplanatory, "ucrFirstExplanatory")
        Me.ucrFirstExplanatory.Name = "ucrFirstExplanatory"
        Me.ucrFirstExplanatory.Selector = Nothing
        '
        'ucrResponse
        '
        resources.ApplyResources(Me.ucrResponse, "ucrResponse")
        Me.ucrResponse.Name = "ucrResponse"
        Me.ucrResponse.Selector = Nothing
        '
        'ucrSelectorThreeVariableModelling
        '
        Me.ucrSelectorThreeVariableModelling.bShowHiddenColumns = False
        Me.ucrSelectorThreeVariableModelling.bUseCurrentFilter = False
        resources.ApplyResources(Me.ucrSelectorThreeVariableModelling, "ucrSelectorThreeVariableModelling")
        Me.ucrSelectorThreeVariableModelling.Name = "ucrSelectorThreeVariableModelling"
        '
        'ucrBaseThreeVariableModelling
        '
        resources.ApplyResources(Me.ucrBaseThreeVariableModelling, "ucrBaseThreeVariableModelling")
        Me.ucrBaseThreeVariableModelling.Name = "ucrBaseThreeVariableModelling"
        '
        'chkSecondFunction
        '
        resources.ApplyResources(Me.chkSecondFunction, "chkSecondFunction")
        Me.chkSecondFunction.Name = "chkSecondFunction"
        Me.chkSecondFunction.Tag = "Function"
        Me.chkSecondFunction.UseVisualStyleBackColor = True
        '
        'ucrModelName
        '
        Me.ucrModelName.IsReadOnly = False
        resources.ApplyResources(Me.ucrModelName, "ucrModelName")
        Me.ucrModelName.Name = "ucrModelName"
        '
        'ucrModelOperator
        '
        Me.ucrModelOperator.IsReadOnly = False
        resources.ApplyResources(Me.ucrModelOperator, "ucrModelOperator")
        Me.ucrModelOperator.Name = "ucrModelOperator"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'chkResponseFunction
        '
        resources.ApplyResources(Me.chkResponseFunction, "chkResponseFunction")
        Me.chkResponseFunction.Name = "chkResponseFunction"
        Me.chkResponseFunction.UseVisualStyleBackColor = True
        '
        'dlgThreeVariableModelling
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkResponseFunction)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrModelOperator)
        Me.Controls.Add(Me.ucrModelName)
        Me.Controls.Add(Me.chkSecondFunction)
        Me.Controls.Add(Me.chkFirstFunction)
        Me.Controls.Add(Me.chkConvertToVariate)
        Me.Controls.Add(Me.cmdModelOptions)
        Me.Controls.Add(Me.lblModelPreview)
        Me.Controls.Add(Me.ucrModelPreview)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.ucrFamily)
        Me.Controls.Add(Me.lblSecondExplanatoryVariable)
        Me.Controls.Add(Me.ucrSecondExplanatory)
        Me.Controls.Add(Me.chkSaveModel)
        Me.Controls.Add(Me.lblFirstExplanatoryVariable)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.ucrFirstExplanatory)
        Me.Controls.Add(Me.ucrResponse)
        Me.Controls.Add(Me.ucrSelectorThreeVariableModelling)
        Me.Controls.Add(Me.ucrBaseThreeVariableModelling)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgThreeVariableModelling"
        Me.Tag = "Three_Variable_Modelling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseThreeVariableModelling As ucrButtons
    Friend WithEvents chkSaveModel As CheckBox
    Friend WithEvents lblFirstExplanatoryVariable As Label
    Friend WithEvents lblResponse As Label
    Friend WithEvents ucrFirstExplanatory As ucrReceiverSingle
    Friend WithEvents ucrResponse As ucrReceiverSingle
    Friend WithEvents ucrSelectorThreeVariableModelling As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblSecondExplanatoryVariable As Label
    Friend WithEvents ucrSecondExplanatory As ucrReceiverSingle
    Friend WithEvents ucrFamily As ucrDistributions
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents ucrModelPreview As ucrInputTextBox
    Friend WithEvents lblModelPreview As Label
    Friend WithEvents cmdModelOptions As Button
    Friend WithEvents chkConvertToVariate As CheckBox
    Friend WithEvents chkFirstFunction As CheckBox
    Friend WithEvents chkSecondFunction As CheckBox
    Friend WithEvents ucrModelName As ucrInputComboBox
    Friend WithEvents ucrModelOperator As ucrInputComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkResponseFunction As CheckBox
End Class
