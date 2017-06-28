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
        Me.cmdModelOptions = New System.Windows.Forms.Button()
        Me.lblModelPreview = New System.Windows.Forms.Label()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.lblSecondExplanatoryVariable = New System.Windows.Forms.Label()
        Me.lblFirstExplanatoryVariable = New System.Windows.Forms.Label()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.lblThirdExplanatoryVariable = New System.Windows.Forms.Label()
        Me.ucrThirdExplanatoryVariable = New instat.ucrReceiverSingle()
        Me.ucrModelPreview = New instat.ucrInputTextBox()
        Me.ucrFamily = New instat.ucrDistributions()
        Me.ucrSecondExplanatoryVariable = New instat.ucrReceiverSingle()
        Me.ucrFirstExplanatory = New instat.ucrReceiverSingle()
        Me.ucrResponse = New instat.ucrReceiverSingle()
        Me.ucrSelectorFourVariableModelling = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBaseFourVariableModelling = New instat.ucrButtons()
        Me.ucrInputModelOperators1 = New instat.ucrInputComboBox()
        Me.ucrInputModelOperators2 = New instat.ucrInputComboBox()
        Me.lblSecondOperator = New System.Windows.Forms.Label()
        Me.lblFirstOperator = New System.Windows.Forms.Label()
        Me.ucrCheckConvertToVariate = New instat.ucrCheck()
        Me.ucrChkFunction = New instat.ucrCheck()
        Me.ucrSaveModel = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'cmdModelOptions
        '
        Me.cmdModelOptions.Location = New System.Drawing.Point(309, 281)
        Me.cmdModelOptions.Name = "cmdModelOptions"
        Me.cmdModelOptions.Size = New System.Drawing.Size(106, 23)
        Me.cmdModelOptions.TabIndex = 30
        Me.cmdModelOptions.Tag = "Model_Options"
        Me.cmdModelOptions.Text = "Model Options..."
        Me.cmdModelOptions.UseVisualStyleBackColor = True
        '
        'lblModelPreview
        '
        Me.lblModelPreview.AutoSize = True
        Me.lblModelPreview.Location = New System.Drawing.Point(9, 285)
        Me.lblModelPreview.Name = "lblModelPreview"
        Me.lblModelPreview.Size = New System.Drawing.Size(80, 13)
        Me.lblModelPreview.TabIndex = 27
        Me.lblModelPreview.Tag = "Model_Preview:"
        Me.lblModelPreview.Text = "Model Preview:"
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(309, 310)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(106, 23)
        Me.cmdDisplayOptions.TabIndex = 33
        Me.cmdDisplayOptions.Tag = "Display_Options"
        Me.cmdDisplayOptions.Text = "Display Options..."
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'lblSecondExplanatoryVariable
        '
        Me.lblSecondExplanatoryVariable.AutoSize = True
        Me.lblSecondExplanatoryVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondExplanatoryVariable.Location = New System.Drawing.Point(266, 158)
        Me.lblSecondExplanatoryVariable.Name = "lblSecondExplanatoryVariable"
        Me.lblSecondExplanatoryVariable.Size = New System.Drawing.Size(146, 13)
        Me.lblSecondExplanatoryVariable.TabIndex = 25
        Me.lblSecondExplanatoryVariable.Tag = "Second_Explanatory_Variable:"
        Me.lblSecondExplanatoryVariable.Text = "Second Explanatory Variable:"
        '
        'lblFirstExplanatoryVariable
        '
        Me.lblFirstExplanatoryVariable.AutoSize = True
        Me.lblFirstExplanatoryVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstExplanatoryVariable.Location = New System.Drawing.Point(266, 83)
        Me.lblFirstExplanatoryVariable.Name = "lblFirstExplanatoryVariable"
        Me.lblFirstExplanatoryVariable.Size = New System.Drawing.Size(128, 13)
        Me.lblFirstExplanatoryVariable.TabIndex = 21
        Me.lblFirstExplanatoryVariable.Tag = "First_Explanatory_Variable:"
        Me.lblFirstExplanatoryVariable.Text = "First Explanatory Variable:"
        '
        'lblResponse
        '
        Me.lblResponse.AutoSize = True
        Me.lblResponse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResponse.Location = New System.Drawing.Point(266, 29)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(99, 13)
        Me.lblResponse.TabIndex = 18
        Me.lblResponse.Tag = "Response_Variable:"
        Me.lblResponse.Text = "Response Variable:"
        '
        'lblThirdExplanatoryVariable
        '
        Me.lblThirdExplanatoryVariable.AutoSize = True
        Me.lblThirdExplanatoryVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblThirdExplanatoryVariable.Location = New System.Drawing.Point(266, 233)
        Me.lblThirdExplanatoryVariable.Name = "lblThirdExplanatoryVariable"
        Me.lblThirdExplanatoryVariable.Size = New System.Drawing.Size(133, 13)
        Me.lblThirdExplanatoryVariable.TabIndex = 34
        Me.lblThirdExplanatoryVariable.Tag = "Third_Explanatory_Variable:"
        Me.lblThirdExplanatoryVariable.Text = "Third Explanatory Variable:"
        '
        'ucrThirdExplanatoryVariable
        '
        Me.ucrThirdExplanatoryVariable.frmParent = Me
        Me.ucrThirdExplanatoryVariable.Location = New System.Drawing.Point(266, 250)
        Me.ucrThirdExplanatoryVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrThirdExplanatoryVariable.Name = "ucrThirdExplanatoryVariable"
        Me.ucrThirdExplanatoryVariable.Selector = Nothing
        Me.ucrThirdExplanatoryVariable.Size = New System.Drawing.Size(128, 26)
        Me.ucrThirdExplanatoryVariable.strNcFilePath = ""
        Me.ucrThirdExplanatoryVariable.TabIndex = 35
        Me.ucrThirdExplanatoryVariable.ucrSelector = Nothing
        '
        'ucrModelPreview
        '
        Me.ucrModelPreview.AddQuotesIfUnrecognised = True
        Me.ucrModelPreview.IsMultiline = False
        Me.ucrModelPreview.IsReadOnly = False
        Me.ucrModelPreview.Location = New System.Drawing.Point(91, 281)
        Me.ucrModelPreview.Name = "ucrModelPreview"
        Me.ucrModelPreview.Size = New System.Drawing.Size(203, 21)
        Me.ucrModelPreview.TabIndex = 28
        '
        'ucrFamily
        '
        Me.ucrFamily.Location = New System.Drawing.Point(10, 193)
        Me.ucrFamily.Name = "ucrFamily"
        Me.ucrFamily.Size = New System.Drawing.Size(225, 35)
        Me.ucrFamily.TabIndex = 29
        '
        'ucrSecondExplanatoryVariable
        '
        Me.ucrSecondExplanatoryVariable.frmParent = Me
        Me.ucrSecondExplanatoryVariable.Location = New System.Drawing.Point(266, 175)
        Me.ucrSecondExplanatoryVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSecondExplanatoryVariable.Name = "ucrSecondExplanatoryVariable"
        Me.ucrSecondExplanatoryVariable.Selector = Nothing
        Me.ucrSecondExplanatoryVariable.Size = New System.Drawing.Size(128, 27)
        Me.ucrSecondExplanatoryVariable.strNcFilePath = ""
        Me.ucrSecondExplanatoryVariable.TabIndex = 26
        Me.ucrSecondExplanatoryVariable.ucrSelector = Nothing
        '
        'ucrFirstExplanatory
        '
        Me.ucrFirstExplanatory.frmParent = Me
        Me.ucrFirstExplanatory.Location = New System.Drawing.Point(266, 99)
        Me.ucrFirstExplanatory.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFirstExplanatory.Name = "ucrFirstExplanatory"
        Me.ucrFirstExplanatory.Selector = Nothing
        Me.ucrFirstExplanatory.Size = New System.Drawing.Size(128, 23)
        Me.ucrFirstExplanatory.strNcFilePath = ""
        Me.ucrFirstExplanatory.TabIndex = 22
        Me.ucrFirstExplanatory.ucrSelector = Nothing
        '
        'ucrResponse
        '
        Me.ucrResponse.frmParent = Me
        Me.ucrResponse.Location = New System.Drawing.Point(266, 44)
        Me.ucrResponse.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrResponse.Name = "ucrResponse"
        Me.ucrResponse.Selector = Nothing
        Me.ucrResponse.Size = New System.Drawing.Size(128, 22)
        Me.ucrResponse.strNcFilePath = ""
        Me.ucrResponse.TabIndex = 19
        Me.ucrResponse.ucrSelector = Nothing
        '
        'ucrSelectorFourVariableModelling
        '
        Me.ucrSelectorFourVariableModelling.bShowHiddenColumns = False
        Me.ucrSelectorFourVariableModelling.bUseCurrentFilter = True
        Me.ucrSelectorFourVariableModelling.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorFourVariableModelling.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFourVariableModelling.Name = "ucrSelectorFourVariableModelling"
        Me.ucrSelectorFourVariableModelling.Size = New System.Drawing.Size(225, 208)
        Me.ucrSelectorFourVariableModelling.TabIndex = 17
        '
        'ucrBaseFourVariableModelling
        '
        Me.ucrBaseFourVariableModelling.Location = New System.Drawing.Point(10, 338)
        Me.ucrBaseFourVariableModelling.Name = "ucrBaseFourVariableModelling"
        Me.ucrBaseFourVariableModelling.Size = New System.Drawing.Size(405, 52)
        Me.ucrBaseFourVariableModelling.TabIndex = 0
        '
        'ucrInputModelOperators1
        '
        Me.ucrInputModelOperators1.AddQuotesIfUnrecognised = True
        Me.ucrInputModelOperators1.IsReadOnly = False
        Me.ucrInputModelOperators1.Location = New System.Drawing.Point(355, 124)
        Me.ucrInputModelOperators1.Name = "ucrInputModelOperators1"
        Me.ucrInputModelOperators1.Size = New System.Drawing.Size(39, 21)
        Me.ucrInputModelOperators1.TabIndex = 42
        '
        'ucrInputModelOperators2
        '
        Me.ucrInputModelOperators2.AddQuotesIfUnrecognised = True
        Me.ucrInputModelOperators2.IsReadOnly = False
        Me.ucrInputModelOperators2.Location = New System.Drawing.Point(355, 201)
        Me.ucrInputModelOperators2.Name = "ucrInputModelOperators2"
        Me.ucrInputModelOperators2.Size = New System.Drawing.Size(39, 21)
        Me.ucrInputModelOperators2.TabIndex = 43
        '
        'lblSecondOperator
        '
        Me.lblSecondOperator.AutoSize = True
        Me.lblSecondOperator.Location = New System.Drawing.Point(292, 205)
        Me.lblSecondOperator.Name = "lblSecondOperator"
        Me.lblSecondOperator.Size = New System.Drawing.Size(51, 13)
        Me.lblSecondOperator.TabIndex = 41
        Me.lblSecondOperator.Tag = "Operator:"
        Me.lblSecondOperator.Text = "Operator:"
        '
        'lblFirstOperator
        '
        Me.lblFirstOperator.AutoSize = True
        Me.lblFirstOperator.Location = New System.Drawing.Point(292, 127)
        Me.lblFirstOperator.Name = "lblFirstOperator"
        Me.lblFirstOperator.Size = New System.Drawing.Size(51, 13)
        Me.lblFirstOperator.TabIndex = 40
        Me.lblFirstOperator.Tag = "Operator:"
        Me.lblFirstOperator.Text = "Operator:"
        '
        'ucrCheckConvertToVariate
        '
        Me.ucrCheckConvertToVariate.Checked = False
        Me.ucrCheckConvertToVariate.Location = New System.Drawing.Point(417, 45)
        Me.ucrCheckConvertToVariate.Name = "ucrCheckConvertToVariate"
        Me.ucrCheckConvertToVariate.Size = New System.Drawing.Size(100, 20)
        Me.ucrCheckConvertToVariate.TabIndex = 44
        '
        'ucrChkFunction
        '
        Me.ucrChkFunction.Checked = False
        Me.ucrChkFunction.Location = New System.Drawing.Point(417, 83)
        Me.ucrChkFunction.Name = "ucrChkFunction"
        Me.ucrChkFunction.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkFunction.TabIndex = 45
        '
        'ucrSaveModel
        '
        Me.ucrSaveModel.Location = New System.Drawing.Point(12, 308)
        Me.ucrSaveModel.Name = "ucrSaveModel"
        Me.ucrSaveModel.Size = New System.Drawing.Size(293, 24)
        Me.ucrSaveModel.TabIndex = 46
        '
        'dlgFourVariableModelling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 398)
        Me.Controls.Add(Me.ucrSaveModel)
        Me.Controls.Add(Me.ucrChkFunction)
        Me.Controls.Add(Me.ucrCheckConvertToVariate)
        Me.Controls.Add(Me.ucrInputModelOperators2)
        Me.Controls.Add(Me.ucrInputModelOperators1)
        Me.Controls.Add(Me.lblSecondOperator)
        Me.Controls.Add(Me.lblFirstOperator)
        Me.Controls.Add(Me.lblThirdExplanatoryVariable)
        Me.Controls.Add(Me.ucrThirdExplanatoryVariable)
        Me.Controls.Add(Me.cmdModelOptions)
        Me.Controls.Add(Me.lblModelPreview)
        Me.Controls.Add(Me.ucrModelPreview)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.ucrFamily)
        Me.Controls.Add(Me.lblSecondExplanatoryVariable)
        Me.Controls.Add(Me.ucrSecondExplanatoryVariable)
        Me.Controls.Add(Me.lblFirstExplanatoryVariable)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.ucrFirstExplanatory)
        Me.Controls.Add(Me.ucrResponse)
        Me.Controls.Add(Me.ucrSelectorFourVariableModelling)
        Me.Controls.Add(Me.ucrBaseFourVariableModelling)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFourVariableModelling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Four_Variable_Modelling"
        Me.Text = "Four Variable Modelling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseFourVariableModelling As ucrButtons
    Friend WithEvents cmdModelOptions As Button
    Friend WithEvents lblModelPreview As Label
    Friend WithEvents ucrModelPreview As ucrInputTextBox
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents ucrFamily As ucrDistributions
    Friend WithEvents lblSecondExplanatoryVariable As Label
    Friend WithEvents ucrSecondExplanatoryVariable As ucrReceiverSingle
    Friend WithEvents lblFirstExplanatoryVariable As Label
    Friend WithEvents lblResponse As Label
    Friend WithEvents ucrFirstExplanatory As ucrReceiverSingle
    Friend WithEvents ucrResponse As ucrReceiverSingle
    Friend WithEvents ucrSelectorFourVariableModelling As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblThirdExplanatoryVariable As Label
    Friend WithEvents ucrThirdExplanatoryVariable As ucrReceiverSingle
    Friend WithEvents ucrInputModelOperators1 As ucrInputComboBox
    Friend WithEvents ucrInputModelOperators2 As ucrInputComboBox
    Friend WithEvents ucrSaveModel As ucrSave
    Friend WithEvents ucrChkFunction As ucrCheck
    Friend WithEvents ucrCheckConvertToVariate As ucrCheck
    Friend WithEvents lblSecondOperator As Label
    Friend WithEvents lblFirstOperator As Label
End Class
