<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgFourVariableModelling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgFourVariableModelling))
        Me.chkFirstFunction = New System.Windows.Forms.CheckBox()
        Me.chkConvertToVariate = New System.Windows.Forms.CheckBox()
        Me.cmdModelOptions = New System.Windows.Forms.Button()
        Me.lblModelPreview = New System.Windows.Forms.Label()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.lblSecondExplanatoryVariable = New System.Windows.Forms.Label()
        Me.chkSaveModel = New System.Windows.Forms.CheckBox()
        Me.lblFirstExplanatoryVariable = New System.Windows.Forms.Label()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.lblThirdExplanatoryVariable = New System.Windows.Forms.Label()
        Me.cboModelOperators1 = New System.Windows.Forms.ComboBox()
        Me.cboModelOperators2 = New System.Windows.Forms.ComboBox()
        Me.lblFirstOperator = New System.Windows.Forms.Label()
        Me.lblSecondOperator = New System.Windows.Forms.Label()
        Me.ucrModelName = New instat.ucrInputComboBox()
        Me.ucrThirdExplanatoryVariable = New instat.ucrReceiverSingle()
        Me.ucrModelPreview = New instat.ucrInputTextBox()
        Me.ucrFamily = New instat.ucrDistributions()
        Me.ucrSecondExplanatoryVariable = New instat.ucrReceiverSingle()
        Me.ucrFirstExplanatory = New instat.ucrReceiverSingle()
        Me.ucrResponse = New instat.ucrReceiverSingle()
        Me.ucrSelectorFourVariableModelling = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBaseFourVariableModelling = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'chkFirstFunction
        '
        resources.ApplyResources(Me.chkFirstFunction, "chkFirstFunction")
        Me.chkFirstFunction.Name = "chkFirstFunction"
        Me.chkFirstFunction.Tag = "Function"
        Me.chkFirstFunction.UseVisualStyleBackColor = True
        '
        'chkConvertToVariate
        '
        resources.ApplyResources(Me.chkConvertToVariate, "chkConvertToVariate")
        Me.chkConvertToVariate.Name = "chkConvertToVariate"
        Me.chkConvertToVariate.Tag = "Convert_to_Variate"
        Me.chkConvertToVariate.UseVisualStyleBackColor = True
        '
        'cmdModelOptions
        '
        resources.ApplyResources(Me.cmdModelOptions, "cmdModelOptions")
        Me.cmdModelOptions.Name = "cmdModelOptions"
        Me.cmdModelOptions.Tag = "Model_Options"
        Me.cmdModelOptions.UseVisualStyleBackColor = True
        '
        'lblModelPreview
        '
        resources.ApplyResources(Me.lblModelPreview, "lblModelPreview")
        Me.lblModelPreview.Name = "lblModelPreview"
        Me.lblModelPreview.Tag = "Model_Preview"
        '
        'cmdDisplayOptions
        '
        resources.ApplyResources(Me.cmdDisplayOptions, "cmdDisplayOptions")
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Tag = "Display_Options"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'lblSecondExplanatoryVariable
        '
        resources.ApplyResources(Me.lblSecondExplanatoryVariable, "lblSecondExplanatoryVariable")
        Me.lblSecondExplanatoryVariable.Name = "lblSecondExplanatoryVariable"
        Me.lblSecondExplanatoryVariable.Tag = "Second_Explanatory_Variable"
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
        'lblThirdExplanatoryVariable
        '
        resources.ApplyResources(Me.lblThirdExplanatoryVariable, "lblThirdExplanatoryVariable")
        Me.lblThirdExplanatoryVariable.Name = "lblThirdExplanatoryVariable"
        Me.lblThirdExplanatoryVariable.Tag = "Third_Explanatory_Variable"
        '
        'cboModelOperators1
        '
        Me.cboModelOperators1.FormattingEnabled = True
        Me.cboModelOperators1.Items.AddRange(New Object() {resources.GetString("cboModelOperators1.Items"), resources.GetString("cboModelOperators1.Items1"), resources.GetString("cboModelOperators1.Items2"), resources.GetString("cboModelOperators1.Items3")})
        resources.ApplyResources(Me.cboModelOperators1, "cboModelOperators1")
        Me.cboModelOperators1.Name = "cboModelOperators1"
        '
        'cboModelOperators2
        '
        Me.cboModelOperators2.FormattingEnabled = True
        Me.cboModelOperators2.Items.AddRange(New Object() {resources.GetString("cboModelOperators2.Items"), resources.GetString("cboModelOperators2.Items1"), resources.GetString("cboModelOperators2.Items2"), resources.GetString("cboModelOperators2.Items3"), resources.GetString("cboModelOperators2.Items4")})
        resources.ApplyResources(Me.cboModelOperators2, "cboModelOperators2")
        Me.cboModelOperators2.Name = "cboModelOperators2"
        '
        'lblFirstOperator
        '
        resources.ApplyResources(Me.lblFirstOperator, "lblFirstOperator")
        Me.lblFirstOperator.Name = "lblFirstOperator"
        Me.lblFirstOperator.Tag = "Operator"
        '
        'lblSecondOperator
        '
        resources.ApplyResources(Me.lblSecondOperator, "lblSecondOperator")
        Me.lblSecondOperator.Name = "lblSecondOperator"
        Me.lblSecondOperator.Tag = "Operator"
        '
        'ucrModelName
        '
        Me.ucrModelName.IsReadOnly = False
        resources.ApplyResources(Me.ucrModelName, "ucrModelName")
        Me.ucrModelName.Name = "ucrModelName"
        '
        'ucrThirdExplanatoryVariable
        '
        resources.ApplyResources(Me.ucrThirdExplanatoryVariable, "ucrThirdExplanatoryVariable")
        Me.ucrThirdExplanatoryVariable.Name = "ucrThirdExplanatoryVariable"
        Me.ucrThirdExplanatoryVariable.Selector = Nothing
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
        'ucrSecondExplanatoryVariable
        '
        resources.ApplyResources(Me.ucrSecondExplanatoryVariable, "ucrSecondExplanatoryVariable")
        Me.ucrSecondExplanatoryVariable.Name = "ucrSecondExplanatoryVariable"
        Me.ucrSecondExplanatoryVariable.Selector = Nothing
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
        'ucrSelectorFourVariableModelling
        '
        Me.ucrSelectorFourVariableModelling.bShowHiddenColumns = False
        Me.ucrSelectorFourVariableModelling.bUseCurrentFilter = False
        resources.ApplyResources(Me.ucrSelectorFourVariableModelling, "ucrSelectorFourVariableModelling")
        Me.ucrSelectorFourVariableModelling.Name = "ucrSelectorFourVariableModelling"
        '
        'ucrBaseFourVariableModelling
        '
        resources.ApplyResources(Me.ucrBaseFourVariableModelling, "ucrBaseFourVariableModelling")
        Me.ucrBaseFourVariableModelling.Name = "ucrBaseFourVariableModelling"
        '
        'dlgFourVariableModelling
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblSecondOperator)
        Me.Controls.Add(Me.lblFirstOperator)
        Me.Controls.Add(Me.cboModelOperators2)
        Me.Controls.Add(Me.cboModelOperators1)
        Me.Controls.Add(Me.ucrModelName)
        Me.Controls.Add(Me.lblThirdExplanatoryVariable)
        Me.Controls.Add(Me.ucrThirdExplanatoryVariable)
        Me.Controls.Add(Me.chkFirstFunction)
        Me.Controls.Add(Me.chkConvertToVariate)
        Me.Controls.Add(Me.cmdModelOptions)
        Me.Controls.Add(Me.lblModelPreview)
        Me.Controls.Add(Me.ucrModelPreview)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.ucrFamily)
        Me.Controls.Add(Me.lblSecondExplanatoryVariable)
        Me.Controls.Add(Me.ucrSecondExplanatoryVariable)
        Me.Controls.Add(Me.chkSaveModel)
        Me.Controls.Add(Me.lblFirstExplanatoryVariable)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.ucrFirstExplanatory)
        Me.Controls.Add(Me.ucrResponse)
        Me.Controls.Add(Me.ucrSelectorFourVariableModelling)
        Me.Controls.Add(Me.ucrBaseFourVariableModelling)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "dlgFourVariableModelling"
        Me.Tag = "Four_Variable_Modelling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseFourVariableModelling As ucrButtons
    Friend WithEvents chkFirstFunction As CheckBox
    Friend WithEvents chkConvertToVariate As CheckBox
    Friend WithEvents cmdModelOptions As Button
    Friend WithEvents lblModelPreview As Label
    Friend WithEvents ucrModelPreview As ucrInputTextBox
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents ucrFamily As ucrDistributions
    Friend WithEvents lblSecondExplanatoryVariable As Label
    Friend WithEvents ucrSecondExplanatoryVariable As ucrReceiverSingle
    Friend WithEvents chkSaveModel As CheckBox
    Friend WithEvents lblFirstExplanatoryVariable As Label
    Friend WithEvents lblResponse As Label
    Friend WithEvents ucrFirstExplanatory As ucrReceiverSingle
    Friend WithEvents ucrResponse As ucrReceiverSingle
    Friend WithEvents ucrSelectorFourVariableModelling As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblThirdExplanatoryVariable As Label
    Friend WithEvents ucrThirdExplanatoryVariable As ucrReceiverSingle
    Friend WithEvents ucrModelName As ucrInputComboBox
    Friend WithEvents cboModelOperators1 As ComboBox
    Friend WithEvents cboModelOperators2 As ComboBox
    Friend WithEvents lblFirstOperator As Label
    Friend WithEvents lblSecondOperator As Label
End Class
