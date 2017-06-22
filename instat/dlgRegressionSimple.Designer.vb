﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.cmdModelOptions = New System.Windows.Forms.Button()
        Me.lblModelPreview = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdoKruskalTest = New System.Windows.Forms.RadioButton()
        Me.rdoWilcoxonTest = New System.Windows.Forms.RadioButton()
        Me.ucrNudHypothesis = New instat.ucrNud()
        Me.ucrChkPairedTest = New instat.ucrCheck()
        Me.ucrNudCI = New instat.ucrNud()
        Me.ucrPnlMeansAndVariance = New instat.UcrPanel()
        Me.lblConfidenceInterval = New System.Windows.Forms.Label()
        Me.lblDifferenceInMeans = New System.Windows.Forms.Label()
        Me.ucrChkFunction = New instat.ucrCheck()
        Me.ucrModelPreview = New instat.ucrInputTextBox()
        Me.ucrFamily = New instat.ucrDistributions()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlModelType = New instat.UcrPanel()
        Me.lblHyp1 = New System.Windows.Forms.Label()
        Me.grpParameters = New System.Windows.Forms.GroupBox()
        Me.rdoCompareVariance = New System.Windows.Forms.RadioButton()
        Me.rdoCompareMeans = New System.Windows.Forms.RadioButton()
        Me.rdoTwoSample = New System.Windows.Forms.RadioButton()
        Me.rdoGeneralCase = New System.Windows.Forms.RadioButton()
        Me.ucrChkConvertToVariate = New instat.ucrCheck()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.lblNumeric = New System.Windows.Forms.Label()
        Me.ucrExplanatory = New instat.ucrReceiverSingle()
        Me.ucrResponse = New instat.ucrReceiverSingle()
        Me.ucrSelectorSimpleReg = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblExplanatory = New System.Windows.Forms.Label()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.ucrSaveModels = New instat.ucrSave()
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
        'cmdDisplayOptions
        '
        resources.ApplyResources(Me.cmdDisplayOptions, "cmdDisplayOptions")
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Tag = "Display_Options..."
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'cmdModelOptions
        '
        resources.ApplyResources(Me.cmdModelOptions, "cmdModelOptions")
        Me.cmdModelOptions.Name = "cmdModelOptions"
        Me.cmdModelOptions.Tag = "Model_Options..."
        Me.cmdModelOptions.UseVisualStyleBackColor = True
        '
        'lblModelPreview
        '
        resources.ApplyResources(Me.lblModelPreview, "lblModelPreview")
        Me.lblModelPreview.Name = "lblModelPreview"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'rdoKruskalTest
        '
        resources.ApplyResources(Me.rdoKruskalTest, "rdoKruskalTest")
        Me.rdoKruskalTest.Name = "rdoKruskalTest"
        Me.rdoKruskalTest.TabStop = True
        Me.rdoKruskalTest.UseVisualStyleBackColor = True
        '
        'rdoWilcoxonTest
        '
        resources.ApplyResources(Me.rdoWilcoxonTest, "rdoWilcoxonTest")
        Me.rdoWilcoxonTest.Name = "rdoWilcoxonTest"
        Me.rdoWilcoxonTest.TabStop = True
        Me.rdoWilcoxonTest.UseVisualStyleBackColor = True
        '
        'ucrNudHypothesis
        '
        Me.ucrNudHypothesis.DecimalPlaces = New Decimal(New Integer() {2, 0, 0, 0})
        Me.ucrNudHypothesis.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudHypothesis, "ucrNudHypothesis")
        Me.ucrNudHypothesis.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudHypothesis.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHypothesis.Name = "ucrNudHypothesis"
        Me.ucrNudHypothesis.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkPairedTest
        '
        Me.ucrChkPairedTest.Checked = False
        resources.ApplyResources(Me.ucrChkPairedTest, "ucrChkPairedTest")
        Me.ucrChkPairedTest.Name = "ucrChkPairedTest"
        '
        'ucrNudCI
        '
        Me.ucrNudCI.DecimalPlaces = New Decimal(New Integer() {2, 0, 0, 0})
        Me.ucrNudCI.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudCI, "ucrNudCI")
        Me.ucrNudCI.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCI.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCI.Name = "ucrNudCI"
        Me.ucrNudCI.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlMeansAndVariance
        '
        resources.ApplyResources(Me.ucrPnlMeansAndVariance, "ucrPnlMeansAndVariance")
        Me.ucrPnlMeansAndVariance.Name = "ucrPnlMeansAndVariance"
        '
        'lblConfidenceInterval
        '
        resources.ApplyResources(Me.lblConfidenceInterval, "lblConfidenceInterval")
        Me.lblConfidenceInterval.Name = "lblConfidenceInterval"
        '
        'lblDifferenceInMeans
        '
        resources.ApplyResources(Me.lblDifferenceInMeans, "lblDifferenceInMeans")
        Me.lblDifferenceInMeans.Name = "lblDifferenceInMeans"
        '
        'ucrChkFunction
        '
        Me.ucrChkFunction.Checked = False
        resources.ApplyResources(Me.ucrChkFunction, "ucrChkFunction")
        Me.ucrChkFunction.Name = "ucrChkFunction"
        '
        'ucrModelPreview
        '
        Me.ucrModelPreview.AddQuotesIfUnrecognised = True
        Me.ucrModelPreview.IsMultiline = False
        Me.ucrModelPreview.IsReadOnly = False
        resources.ApplyResources(Me.ucrModelPreview, "ucrModelPreview")
        Me.ucrModelPreview.Name = "ucrModelPreview"
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
        'ucrPnlModelType
        '
        resources.ApplyResources(Me.ucrPnlModelType, "ucrPnlModelType")
        Me.ucrPnlModelType.Name = "ucrPnlModelType"
        '
        'lblHyp1
        '
        resources.ApplyResources(Me.lblHyp1, "lblHyp1")
        Me.lblHyp1.Name = "lblHyp1"
        '
        'grpParameters
        '
        Me.grpParameters.Controls.Add(Me.Label1)
        Me.grpParameters.Controls.Add(Me.rdoKruskalTest)
        Me.grpParameters.Controls.Add(Me.rdoWilcoxonTest)
        Me.grpParameters.Controls.Add(Me.ucrNudHypothesis)
        Me.grpParameters.Controls.Add(Me.ucrChkPairedTest)
        Me.grpParameters.Controls.Add(Me.ucrNudCI)
        Me.grpParameters.Controls.Add(Me.lblConfidenceInterval)
        Me.grpParameters.Controls.Add(Me.lblDifferenceInMeans)
        resources.ApplyResources(Me.grpParameters, "grpParameters")
        Me.grpParameters.Name = "grpParameters"
        Me.grpParameters.TabStop = False
        '
        'rdoCompareVariance
        '
        resources.ApplyResources(Me.rdoCompareVariance, "rdoCompareVariance")
        Me.rdoCompareVariance.Name = "rdoCompareVariance"
        Me.rdoCompareVariance.TabStop = True
        Me.rdoCompareVariance.UseVisualStyleBackColor = True
        '
        'rdoCompareMeans
        '
        resources.ApplyResources(Me.rdoCompareMeans, "rdoCompareMeans")
        Me.rdoCompareMeans.Name = "rdoCompareMeans"
        Me.rdoCompareMeans.TabStop = True
        Me.rdoCompareMeans.UseVisualStyleBackColor = True
        '
        'rdoTwoSample
        '
        resources.ApplyResources(Me.rdoTwoSample, "rdoTwoSample")
        Me.rdoTwoSample.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoSample.FlatAppearance.BorderSize = 2
        Me.rdoTwoSample.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoSample.Name = "rdoTwoSample"
        Me.rdoTwoSample.UseVisualStyleBackColor = True
        '
        'rdoGeneralCase
        '
        resources.ApplyResources(Me.rdoGeneralCase, "rdoGeneralCase")
        Me.rdoGeneralCase.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGeneralCase.FlatAppearance.BorderSize = 2
        Me.rdoGeneralCase.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGeneralCase.Name = "rdoGeneralCase"
        Me.rdoGeneralCase.UseVisualStyleBackColor = True
        '
        'ucrChkConvertToVariate
        '
        Me.ucrChkConvertToVariate.Checked = False
        resources.ApplyResources(Me.ucrChkConvertToVariate, "ucrChkConvertToVariate")
        Me.ucrChkConvertToVariate.Name = "ucrChkConvertToVariate"
        '
        'lblFactor
        '
        resources.ApplyResources(Me.lblFactor, "lblFactor")
        Me.lblFactor.Name = "lblFactor"
        '
        'lblNumeric
        '
        resources.ApplyResources(Me.lblNumeric, "lblNumeric")
        Me.lblNumeric.Name = "lblNumeric"
        '
        'ucrExplanatory
        '
        Me.ucrExplanatory.frmParent = Me
        resources.ApplyResources(Me.ucrExplanatory, "ucrExplanatory")
        Me.ucrExplanatory.Name = "ucrExplanatory"
        Me.ucrExplanatory.Selector = Nothing
        Me.ucrExplanatory.strNcFilePath = ""
        Me.ucrExplanatory.ucrSelector = Nothing
        '
        'ucrResponse
        '
        Me.ucrResponse.frmParent = Me
        resources.ApplyResources(Me.ucrResponse, "ucrResponse")
        Me.ucrResponse.Name = "ucrResponse"
        Me.ucrResponse.Selector = Nothing
        Me.ucrResponse.strNcFilePath = ""
        Me.ucrResponse.ucrSelector = Nothing
        '
        'ucrSelectorSimpleReg
        '
        Me.ucrSelectorSimpleReg.bShowHiddenColumns = False
        Me.ucrSelectorSimpleReg.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorSimpleReg, "ucrSelectorSimpleReg")
        Me.ucrSelectorSimpleReg.Name = "ucrSelectorSimpleReg"
        '
        'lblExplanatory
        '
        resources.ApplyResources(Me.lblExplanatory, "lblExplanatory")
        Me.lblExplanatory.Name = "lblExplanatory"
        Me.lblExplanatory.Tag = "Explanatory_Variable"
        '
        'lblResponse
        '
        resources.ApplyResources(Me.lblResponse, "lblResponse")
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Tag = "Response_Variable"
        '
        'ucrSaveModels
        '
        resources.ApplyResources(Me.ucrSaveModels, "ucrSaveModels")
        Me.ucrSaveModels.Name = "ucrSaveModels"
        '
        'dlgRegressionSimple
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rdoCompareVariance)
        Me.Controls.Add(Me.ucrSaveModels)
        Me.Controls.Add(Me.rdoTwoSample)
        Me.Controls.Add(Me.rdoGeneralCase)
        Me.Controls.Add(Me.ucrChkConvertToVariate)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblNumeric)
        Me.Controls.Add(Me.rdoCompareMeans)
        Me.Controls.Add(Me.lblHyp1)
        Me.Controls.Add(Me.ucrExplanatory)
        Me.Controls.Add(Me.ucrPnlMeansAndVariance)
        Me.Controls.Add(Me.ucrResponse)
        Me.Controls.Add(Me.ucrSelectorSimpleReg)
        Me.Controls.Add(Me.lblExplanatory)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.ucrChkFunction)
        Me.Controls.Add(Me.ucrPnlModelType)
        Me.Controls.Add(Me.grpParameters)
        Me.Controls.Add(Me.ucrModelPreview)
        Me.Controls.Add(Me.lblModelPreview)
        Me.Controls.Add(Me.ucrFamily)
        Me.Controls.Add(Me.cmdModelOptions)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRegressionSimple"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Tag = "Simple_Regression"
        Me.grpParameters.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblResidualMsg As Label
    Friend WithEvents lblDF As Label
    Friend WithEvents txtResidualMsg As TextBox
    Friend WithEvents txtdf As TextBox
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents cmdModelOptions As Button
    Friend WithEvents ucrFamily As ucrDistributions
    Friend WithEvents lblModelPreview As Label
    Friend WithEvents ucrModelPreview As ucrInputTextBox
    Friend WithEvents lblConfidenceInterval As Label
    Friend WithEvents lblDifferenceInMeans As Label
    Friend WithEvents ucrChkPairedTest As ucrCheck
    Friend WithEvents ucrPnlMeansAndVariance As UcrPanel
    Friend WithEvents ucrNudCI As ucrNud
    Friend WithEvents ucrNudHypothesis As ucrNud
    Friend WithEvents ucrChkFunction As ucrCheck
    Friend WithEvents rdoKruskalTest As RadioButton
    Friend WithEvents rdoWilcoxonTest As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrPnlModelType As UcrPanel
    Friend WithEvents grpParameters As GroupBox
    Friend WithEvents lblHyp1 As Label
    Friend WithEvents rdoTwoSample As RadioButton
    Friend WithEvents rdoGeneralCase As RadioButton
    Friend WithEvents ucrChkConvertToVariate As ucrCheck
    Friend WithEvents lblFactor As Label
    Friend WithEvents lblNumeric As Label
    Friend WithEvents ucrExplanatory As ucrReceiverSingle
    Friend WithEvents ucrResponse As ucrReceiverSingle
    Friend WithEvents ucrSelectorSimpleReg As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblExplanatory As Label
    Friend WithEvents lblResponse As Label
    Friend WithEvents rdoCompareMeans As RadioButton
    Friend WithEvents rdoCompareVariance As RadioButton
    Friend WithEvents ucrSaveModels As ucrSave
End Class