<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgRegressionSimple
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRegressionSimple))
        Me.lblResidualMsg = New System.Windows.Forms.Label()
        Me.lblDF = New System.Windows.Forms.Label()
        Me.txtResidualMsg = New System.Windows.Forms.TextBox()
        Me.txtdf = New System.Windows.Forms.TextBox()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.lblExplanatory = New System.Windows.Forms.Label()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.chkSaveModel = New System.Windows.Forms.CheckBox()
        Me.cmdModelOptions = New System.Windows.Forms.Button()
        Me.chkFunction = New System.Windows.Forms.CheckBox()
        Me.chkConvertToVariate = New System.Windows.Forms.CheckBox()
        Me.lblModelPreview = New System.Windows.Forms.Label()
        Me.chkPaired = New System.Windows.Forms.CheckBox()
        Me.rdoGeneral = New System.Windows.Forms.RadioButton()
        Me.rdoSpecific = New System.Windows.Forms.RadioButton()
        Me.lblNumeric = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.nudCI = New System.Windows.Forms.NumericUpDown()
        Me.nudHypothesis = New System.Windows.Forms.NumericUpDown()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.lblHyp1 = New System.Windows.Forms.Label()
        Me.grpParameters = New System.Windows.Forms.GroupBox()
        Me.lblLevel1 = New System.Windows.Forms.Label()
        Me.lblLevel2 = New System.Windows.Forms.Label()
        Me.ucrLevel2 = New instat.ucrInputComboBox()
        Me.ucrLevel1 = New instat.ucrInputComboBox()
        Me.rdoCompareMeans = New System.Windows.Forms.RadioButton()
        Me.rdoCompareVar = New System.Windows.Forms.RadioButton()
        Me.ucrModelPreview = New instat.ucrInputTextBox()
        Me.ucrExplanatory = New instat.ucrReceiverSingle()
        Me.ucrResponse = New instat.ucrReceiverSingle()
        Me.ucrModelName = New instat.ucrInputComboBox()
        Me.ucrSelectorSimpleReg = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrFamily = New instat.ucrDistributions()
        Me.ucrBase = New instat.ucrButtons()
        CType(Me.nudCI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHypothesis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpParameters.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblResidualMsg
        '
        resources.ApplyResources(Me.lblResidualMsg, "lblResidualMsg")
        Me.lblResidualMsg.Name = "lblResidualMsg"
        Me.lblResidualMsg.Tag = "Residual_Msg"
        '
        'lblDF
        '
        resources.ApplyResources(Me.lblDF, "lblDF")
        Me.lblDF.Name = "lblDF"
        Me.lblDF.Tag = "Degrees_of_freedom"
        '
        'txtResidualMsg
        '
        resources.ApplyResources(Me.txtResidualMsg, "txtResidualMsg")
        Me.txtResidualMsg.Name = "txtResidualMsg"
        '
        'txtdf
        '
        resources.ApplyResources(Me.txtdf, "txtdf")
        Me.txtdf.Name = "txtdf"
        '
        'lblResponse
        '
        resources.ApplyResources(Me.lblResponse, "lblResponse")
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Tag = "Response_Variable"
        '
        'lblExplanatory
        '
        resources.ApplyResources(Me.lblExplanatory, "lblExplanatory")
        Me.lblExplanatory.Name = "lblExplanatory"
        Me.lblExplanatory.Tag = "Explanatory_Variable"
        '
        'cmdDisplayOptions
        '
        resources.ApplyResources(Me.cmdDisplayOptions, "cmdDisplayOptions")
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Tag = "Display_Options..."
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'chkSaveModel
        '
        resources.ApplyResources(Me.chkSaveModel, "chkSaveModel")
        Me.chkSaveModel.Name = "chkSaveModel"
        Me.chkSaveModel.Tag = "Save_Model"
        Me.chkSaveModel.UseVisualStyleBackColor = True
        '
        'cmdModelOptions
        '
        resources.ApplyResources(Me.cmdModelOptions, "cmdModelOptions")
        Me.cmdModelOptions.Name = "cmdModelOptions"
        Me.cmdModelOptions.Tag = "Model_Options..."
        Me.cmdModelOptions.UseVisualStyleBackColor = True
        '
        'chkFunction
        '
        resources.ApplyResources(Me.chkFunction, "chkFunction")
        Me.chkFunction.Name = "chkFunction"
        Me.chkFunction.Tag = "Function"
        Me.chkFunction.UseVisualStyleBackColor = True
        '
        'chkConvertToVariate
        '
        resources.ApplyResources(Me.chkConvertToVariate, "chkConvertToVariate")
        Me.chkConvertToVariate.Name = "chkConvertToVariate"
        Me.chkConvertToVariate.UseVisualStyleBackColor = True
        '
        'lblModelPreview
        '
        resources.ApplyResources(Me.lblModelPreview, "lblModelPreview")
        Me.lblModelPreview.Name = "lblModelPreview"
        '
        'chkPaired
        '
        resources.ApplyResources(Me.chkPaired, "chkPaired")
        Me.chkPaired.Name = "chkPaired"
        Me.chkPaired.UseVisualStyleBackColor = True
        '
        'rdoGeneral
        '
        resources.ApplyResources(Me.rdoGeneral, "rdoGeneral")
        Me.rdoGeneral.Name = "rdoGeneral"
        Me.rdoGeneral.TabStop = True
        Me.rdoGeneral.UseVisualStyleBackColor = True
        '
        'rdoSpecific
        '
        resources.ApplyResources(Me.rdoSpecific, "rdoSpecific")
        Me.rdoSpecific.Name = "rdoSpecific"
        Me.rdoSpecific.TabStop = True
        Me.rdoSpecific.UseVisualStyleBackColor = True
        '
        'lblNumeric
        '
        resources.ApplyResources(Me.lblNumeric, "lblNumeric")
        Me.lblNumeric.Name = "lblNumeric"
        '
        'lblFactor
        '
        resources.ApplyResources(Me.lblFactor, "lblFactor")
        Me.lblFactor.Name = "lblFactor"
        '
        'nudCI
        '
        resources.ApplyResources(Me.nudCI, "nudCI")
        Me.nudCI.Name = "nudCI"
        '
        'nudHypothesis
        '
        resources.ApplyResources(Me.nudHypothesis, "nudHypothesis")
        Me.nudHypothesis.Name = "nudHypothesis"
        '
        'lblCI
        '
        resources.ApplyResources(Me.lblCI, "lblCI")
        Me.lblCI.Name = "lblCI"
        '
        'lblHyp1
        '
        resources.ApplyResources(Me.lblHyp1, "lblHyp1")
        Me.lblHyp1.Name = "lblHyp1"
        '
        'grpParameters
        '
        Me.grpParameters.Controls.Add(Me.lblLevel1)
        Me.grpParameters.Controls.Add(Me.lblLevel2)
        Me.grpParameters.Controls.Add(Me.ucrLevel2)
        Me.grpParameters.Controls.Add(Me.ucrLevel1)
        Me.grpParameters.Controls.Add(Me.rdoCompareMeans)
        Me.grpParameters.Controls.Add(Me.rdoCompareVar)
        Me.grpParameters.Controls.Add(Me.lblCI)
        Me.grpParameters.Controls.Add(Me.nudCI)
        Me.grpParameters.Controls.Add(Me.nudHypothesis)
        Me.grpParameters.Controls.Add(Me.chkPaired)
        Me.grpParameters.Controls.Add(Me.lblHyp1)
        resources.ApplyResources(Me.grpParameters, "grpParameters")
        Me.grpParameters.Name = "grpParameters"
        Me.grpParameters.TabStop = False
        '
        'lblLevel1
        '
        resources.ApplyResources(Me.lblLevel1, "lblLevel1")
        Me.lblLevel1.Name = "lblLevel1"
        '
        'lblLevel2
        '
        resources.ApplyResources(Me.lblLevel2, "lblLevel2")
        Me.lblLevel2.Name = "lblLevel2"
        '
        'ucrLevel2
        '
        Me.ucrLevel2.IsReadOnly = False
        resources.ApplyResources(Me.ucrLevel2, "ucrLevel2")
        Me.ucrLevel2.Name = "ucrLevel2"
        '
        'ucrLevel1
        '
        Me.ucrLevel1.IsReadOnly = False
        resources.ApplyResources(Me.ucrLevel1, "ucrLevel1")
        Me.ucrLevel1.Name = "ucrLevel1"
        '
        'rdoCompareMeans
        '
        resources.ApplyResources(Me.rdoCompareMeans, "rdoCompareMeans")
        Me.rdoCompareMeans.Name = "rdoCompareMeans"
        Me.rdoCompareMeans.TabStop = True
        Me.rdoCompareMeans.UseVisualStyleBackColor = True
        '
        'rdoCompareVar
        '
        resources.ApplyResources(Me.rdoCompareVar, "rdoCompareVar")
        Me.rdoCompareVar.Name = "rdoCompareVar"
        Me.rdoCompareVar.TabStop = True
        Me.rdoCompareVar.UseVisualStyleBackColor = True
        '
        'ucrModelPreview
        '
        Me.ucrModelPreview.IsReadOnly = False
        resources.ApplyResources(Me.ucrModelPreview, "ucrModelPreview")
        Me.ucrModelPreview.Name = "ucrModelPreview"
        '
        'ucrExplanatory
        '
        resources.ApplyResources(Me.ucrExplanatory, "ucrExplanatory")
        Me.ucrExplanatory.Name = "ucrExplanatory"
        Me.ucrExplanatory.Selector = Nothing
        '
        'ucrResponse
        '
        resources.ApplyResources(Me.ucrResponse, "ucrResponse")
        Me.ucrResponse.Name = "ucrResponse"
        Me.ucrResponse.Selector = Nothing
        '
        'ucrModelName
        '
        Me.ucrModelName.IsReadOnly = False
        resources.ApplyResources(Me.ucrModelName, "ucrModelName")
        Me.ucrModelName.Name = "ucrModelName"
        '
        'ucrSelectorSimpleReg
        '
        Me.ucrSelectorSimpleReg.bShowHiddenColumns = False
        Me.ucrSelectorSimpleReg.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorSimpleReg, "ucrSelectorSimpleReg")
        Me.ucrSelectorSimpleReg.Name = "ucrSelectorSimpleReg"
        '
        'ucrFamily
        '
        resources.ApplyResources(Me.ucrFamily, "ucrFamily")
        Me.ucrFamily.Name = "ucrFamily"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgRegressionSimple
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpParameters)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblNumeric)
        Me.Controls.Add(Me.rdoSpecific)
        Me.Controls.Add(Me.rdoGeneral)
        Me.Controls.Add(Me.ucrModelPreview)
        Me.Controls.Add(Me.ucrExplanatory)
        Me.Controls.Add(Me.ucrResponse)
        Me.Controls.Add(Me.lblModelPreview)
        Me.Controls.Add(Me.chkConvertToVariate)
        Me.Controls.Add(Me.ucrModelName)
        Me.Controls.Add(Me.ucrSelectorSimpleReg)
        Me.Controls.Add(Me.ucrFamily)
        Me.Controls.Add(Me.chkFunction)
        Me.Controls.Add(Me.cmdModelOptions)
        Me.Controls.Add(Me.chkSaveModel)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.lblExplanatory)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRegressionSimple"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Tag = "Simple_Regression"
        CType(Me.nudCI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHypothesis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpParameters.ResumeLayout(False)
        Me.grpParameters.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblResidualMsg As Label
    Friend WithEvents lblDF As Label
    Friend WithEvents txtResidualMsg As TextBox
    Friend WithEvents txtdf As TextBox

    Friend WithEvents lblResponse As Label
    Friend WithEvents lblExplanatory As Label
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents chkSaveModel As CheckBox
    Friend WithEvents cmdModelOptions As Button
    Friend WithEvents chkFunction As CheckBox
    Friend WithEvents ucrFamily As ucrDistributions
    Friend WithEvents ucrSelectorSimpleReg As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrModelName As ucrInputComboBox
    Friend WithEvents chkConvertToVariate As CheckBox
    Friend WithEvents lblModelPreview As Label
    Friend WithEvents ucrResponse As ucrReceiverSingle
    Friend WithEvents ucrExplanatory As ucrReceiverSingle
    Friend WithEvents ucrModelPreview As ucrInputTextBox
    Friend WithEvents chkPaired As CheckBox
    Friend WithEvents rdoGeneral As RadioButton
    Friend WithEvents rdoSpecific As RadioButton
    Friend WithEvents lblNumeric As Label
    Friend WithEvents lblFactor As Label
    Friend WithEvents nudCI As NumericUpDown
    Friend WithEvents nudHypothesis As NumericUpDown
    Friend WithEvents lblCI As Label
    Friend WithEvents lblHyp1 As Label
    Friend WithEvents grpParameters As GroupBox
    Friend WithEvents rdoCompareMeans As RadioButton
    Friend WithEvents rdoCompareVar As RadioButton
    Friend WithEvents lblLevel1 As Label
    Friend WithEvents lblLevel2 As Label
    Friend WithEvents ucrLevel2 As ucrInputComboBox
    Friend WithEvents ucrLevel1 As ucrInputComboBox
End Class