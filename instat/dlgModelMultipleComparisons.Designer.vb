<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgModelMultipleComparisons
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
        Me.lblMultipleMeanComparisonModeltoUse = New System.Windows.Forms.Label()
        Me.lblVariabletoUse = New System.Windows.Forms.Label()
        Me.btnTransformation = New System.Windows.Forms.Button()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrInputGenerateMultipleComparisonGraphs = New instat.ucrInputComboBox()
        Me.ucrChkGenerateMultipleComparisonPlot = New instat.ucrCheck()
        Me.ucrChkByOptional = New instat.ucrCheck()
        Me.ucrInputComboBoxAdjustment = New instat.ucrInputComboBox()
        Me.ucrChkAdjustment = New instat.ucrCheck()
        Me.ucrInputComboBoxDescending = New instat.ucrInputComboBox()
        Me.ucrChkDescending = New instat.ucrCheck()
        Me.ucrInputComboBoxDisplayLetters = New instat.ucrInputComboBox()
        Me.ucrChkDisplayLetters = New instat.ucrCheck()
        Me.ucrInputComboBoxConfidenceInterval = New instat.ucrInputComboBox()
        Me.ucrChkConfidenceInterval = New instat.ucrCheck()
        Me.ucrInputComboBoxAlpha = New instat.ucrInputComboBox()
        Me.ucrChkAlpha = New instat.ucrCheck()
        Me.ucrReceiverBy = New instat.ucrReceiverSingle()
        Me.ucrReceiverLabelVariable = New instat.ucrReceiverSingle()
        Me.ucrReceiverMultipleMeanComparisonUseModel = New instat.ucrReceiverSingle()
        Me.ucrSaveModelMultipleComparisons = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorModelMultipleComparisons = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblMultipleMeanComparisonModeltoUse
        '
        Me.lblMultipleMeanComparisonModeltoUse.AutoSize = True
        Me.lblMultipleMeanComparisonModeltoUse.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblMultipleMeanComparisonModeltoUse.Location = New System.Drawing.Point(322, 57)
        Me.lblMultipleMeanComparisonModeltoUse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMultipleMeanComparisonModeltoUse.Name = "lblMultipleMeanComparisonModeltoUse"
        Me.lblMultipleMeanComparisonModeltoUse.Size = New System.Drawing.Size(105, 16)
        Me.lblMultipleMeanComparisonModeltoUse.TabIndex = 28
        Me.lblMultipleMeanComparisonModeltoUse.Tag = "Selected_Model:"
        Me.lblMultipleMeanComparisonModeltoUse.Text = "Selected Model:"
        '
        'lblVariabletoUse
        '
        Me.lblVariabletoUse.AutoSize = True
        Me.lblVariabletoUse.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblVariabletoUse.Location = New System.Drawing.Point(323, 111)
        Me.lblVariabletoUse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVariabletoUse.Name = "lblVariabletoUse"
        Me.lblVariabletoUse.Size = New System.Drawing.Size(98, 16)
        Me.lblVariabletoUse.TabIndex = 30
        Me.lblVariabletoUse.Tag = "Label_Variable:"
        Me.lblVariabletoUse.Text = "Label Variable:"
        '
        'btnTransformation
        '
        Me.btnTransformation.Enabled = False
        Me.btnTransformation.Location = New System.Drawing.Point(322, 226)
        Me.btnTransformation.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTransformation.Name = "btnTransformation"
        Me.btnTransformation.Size = New System.Drawing.Size(160, 31)
        Me.btnTransformation.TabIndex = 34
        Me.btnTransformation.Tag = "Transformation"
        Me.btnTransformation.Text = "Transformation"
        Me.btnTransformation.UseVisualStyleBackColor = True
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(12, 494)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(408, 30)
        Me.ucrSaveGraph.TabIndex = 60
        '
        'ucrInputGenerateMultipleComparisonGraphs
        '
        Me.ucrInputGenerateMultipleComparisonGraphs.AddQuotesIfUnrecognised = False
        Me.ucrInputGenerateMultipleComparisonGraphs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputGenerateMultipleComparisonGraphs.GetSetSelectedIndex = -1
        Me.ucrInputGenerateMultipleComparisonGraphs.IsReadOnly = False
        Me.ucrInputGenerateMultipleComparisonGraphs.Location = New System.Drawing.Point(205, 280)
        Me.ucrInputGenerateMultipleComparisonGraphs.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInputGenerateMultipleComparisonGraphs.Name = "ucrInputGenerateMultipleComparisonGraphs"
        Me.ucrInputGenerateMultipleComparisonGraphs.Size = New System.Drawing.Size(112, 27)
        Me.ucrInputGenerateMultipleComparisonGraphs.TabIndex = 47
        '
        'ucrChkGenerateMultipleComparisonPlot
        '
        Me.ucrChkGenerateMultipleComparisonPlot.AutoSize = True
        Me.ucrChkGenerateMultipleComparisonPlot.Checked = False
        Me.ucrChkGenerateMultipleComparisonPlot.Location = New System.Drawing.Point(12, 280)
        Me.ucrChkGenerateMultipleComparisonPlot.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrChkGenerateMultipleComparisonPlot.Name = "ucrChkGenerateMultipleComparisonPlot"
        Me.ucrChkGenerateMultipleComparisonPlot.Size = New System.Drawing.Size(187, 30)
        Me.ucrChkGenerateMultipleComparisonPlot.TabIndex = 46
        '
        'ucrChkByOptional
        '
        Me.ucrChkByOptional.AutoSize = True
        Me.ucrChkByOptional.Checked = False
        Me.ucrChkByOptional.Location = New System.Drawing.Point(322, 164)
        Me.ucrChkByOptional.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrChkByOptional.Name = "ucrChkByOptional"
        Me.ucrChkByOptional.Size = New System.Drawing.Size(105, 29)
        Me.ucrChkByOptional.TabIndex = 45
        '
        'ucrInputComboBoxAdjustment
        '
        Me.ucrInputComboBoxAdjustment.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBoxAdjustment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboBoxAdjustment.GetSetSelectedIndex = -1
        Me.ucrInputComboBoxAdjustment.IsReadOnly = False
        Me.ucrInputComboBoxAdjustment.Location = New System.Drawing.Point(205, 342)
        Me.ucrInputComboBoxAdjustment.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInputComboBoxAdjustment.Name = "ucrInputComboBoxAdjustment"
        Me.ucrInputComboBoxAdjustment.Size = New System.Drawing.Size(112, 27)
        Me.ucrInputComboBoxAdjustment.TabIndex = 44
        '
        'ucrChkAdjustment
        '
        Me.ucrChkAdjustment.AutoSize = True
        Me.ucrChkAdjustment.Checked = False
        Me.ucrChkAdjustment.Location = New System.Drawing.Point(12, 342)
        Me.ucrChkAdjustment.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrChkAdjustment.Name = "ucrChkAdjustment"
        Me.ucrChkAdjustment.Size = New System.Drawing.Size(187, 30)
        Me.ucrChkAdjustment.TabIndex = 43
        '
        'ucrInputComboBoxDescending
        '
        Me.ucrInputComboBoxDescending.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBoxDescending.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboBoxDescending.GetSetSelectedIndex = -1
        Me.ucrInputComboBoxDescending.IsReadOnly = False
        Me.ucrInputComboBoxDescending.Location = New System.Drawing.Point(205, 311)
        Me.ucrInputComboBoxDescending.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInputComboBoxDescending.Name = "ucrInputComboBoxDescending"
        Me.ucrInputComboBoxDescending.Size = New System.Drawing.Size(112, 27)
        Me.ucrInputComboBoxDescending.TabIndex = 42
        '
        'ucrChkDescending
        '
        Me.ucrChkDescending.AutoSize = True
        Me.ucrChkDescending.Checked = False
        Me.ucrChkDescending.Location = New System.Drawing.Point(12, 311)
        Me.ucrChkDescending.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrChkDescending.Name = "ucrChkDescending"
        Me.ucrChkDescending.Size = New System.Drawing.Size(187, 30)
        Me.ucrChkDescending.TabIndex = 41
        '
        'ucrInputComboBoxDisplayLetters
        '
        Me.ucrInputComboBoxDisplayLetters.AddQuotesIfUnrecognised = False
        Me.ucrInputComboBoxDisplayLetters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboBoxDisplayLetters.GetSetSelectedIndex = -1
        Me.ucrInputComboBoxDisplayLetters.IsReadOnly = True
        Me.ucrInputComboBoxDisplayLetters.Location = New System.Drawing.Point(205, 404)
        Me.ucrInputComboBoxDisplayLetters.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInputComboBoxDisplayLetters.Name = "ucrInputComboBoxDisplayLetters"
        Me.ucrInputComboBoxDisplayLetters.Size = New System.Drawing.Size(112, 27)
        Me.ucrInputComboBoxDisplayLetters.TabIndex = 40
        '
        'ucrChkDisplayLetters
        '
        Me.ucrChkDisplayLetters.AutoSize = True
        Me.ucrChkDisplayLetters.Checked = False
        Me.ucrChkDisplayLetters.Location = New System.Drawing.Point(12, 404)
        Me.ucrChkDisplayLetters.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrChkDisplayLetters.Name = "ucrChkDisplayLetters"
        Me.ucrChkDisplayLetters.Size = New System.Drawing.Size(187, 30)
        Me.ucrChkDisplayLetters.TabIndex = 39
        '
        'ucrInputComboBoxConfidenceInterval
        '
        Me.ucrInputComboBoxConfidenceInterval.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBoxConfidenceInterval.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboBoxConfidenceInterval.GetSetSelectedIndex = -1
        Me.ucrInputComboBoxConfidenceInterval.IsReadOnly = False
        Me.ucrInputComboBoxConfidenceInterval.Location = New System.Drawing.Point(205, 373)
        Me.ucrInputComboBoxConfidenceInterval.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInputComboBoxConfidenceInterval.Name = "ucrInputComboBoxConfidenceInterval"
        Me.ucrInputComboBoxConfidenceInterval.Size = New System.Drawing.Size(112, 27)
        Me.ucrInputComboBoxConfidenceInterval.TabIndex = 38
        '
        'ucrChkConfidenceInterval
        '
        Me.ucrChkConfidenceInterval.AutoSize = True
        Me.ucrChkConfidenceInterval.Checked = False
        Me.ucrChkConfidenceInterval.Location = New System.Drawing.Point(12, 373)
        Me.ucrChkConfidenceInterval.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrChkConfidenceInterval.Name = "ucrChkConfidenceInterval"
        Me.ucrChkConfidenceInterval.Size = New System.Drawing.Size(187, 30)
        Me.ucrChkConfidenceInterval.TabIndex = 37
        '
        'ucrInputComboBoxAlpha
        '
        Me.ucrInputComboBoxAlpha.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBoxAlpha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboBoxAlpha.GetSetSelectedIndex = -1
        Me.ucrInputComboBoxAlpha.IsReadOnly = True
        Me.ucrInputComboBoxAlpha.Location = New System.Drawing.Point(205, 249)
        Me.ucrInputComboBoxAlpha.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInputComboBoxAlpha.Name = "ucrInputComboBoxAlpha"
        Me.ucrInputComboBoxAlpha.Size = New System.Drawing.Size(112, 27)
        Me.ucrInputComboBoxAlpha.TabIndex = 36
        '
        'ucrChkAlpha
        '
        Me.ucrChkAlpha.AutoSize = True
        Me.ucrChkAlpha.Checked = False
        Me.ucrChkAlpha.Location = New System.Drawing.Point(12, 249)
        Me.ucrChkAlpha.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrChkAlpha.Name = "ucrChkAlpha"
        Me.ucrChkAlpha.Size = New System.Drawing.Size(187, 30)
        Me.ucrChkAlpha.TabIndex = 35
        '
        'ucrReceiverBy
        '
        Me.ucrReceiverBy.AutoSize = True
        Me.ucrReceiverBy.frmParent = Me
        Me.ucrReceiverBy.Location = New System.Drawing.Point(322, 196)
        Me.ucrReceiverBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverBy.Name = "ucrReceiverBy"
        Me.ucrReceiverBy.Selector = Nothing
        Me.ucrReceiverBy.Size = New System.Drawing.Size(160, 27)
        Me.ucrReceiverBy.strNcFilePath = ""
        Me.ucrReceiverBy.TabIndex = 33
        Me.ucrReceiverBy.ucrSelector = Nothing
        '
        'ucrReceiverLabelVariable
        '
        Me.ucrReceiverLabelVariable.AutoSize = True
        Me.ucrReceiverLabelVariable.frmParent = Me
        Me.ucrReceiverLabelVariable.Location = New System.Drawing.Point(322, 128)
        Me.ucrReceiverLabelVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLabelVariable.Name = "ucrReceiverLabelVariable"
        Me.ucrReceiverLabelVariable.Selector = Nothing
        Me.ucrReceiverLabelVariable.Size = New System.Drawing.Size(160, 27)
        Me.ucrReceiverLabelVariable.strNcFilePath = ""
        Me.ucrReceiverLabelVariable.TabIndex = 31
        Me.ucrReceiverLabelVariable.ucrSelector = Nothing
        '
        'ucrReceiverMultipleMeanComparisonUseModel
        '
        Me.ucrReceiverMultipleMeanComparisonUseModel.AutoSize = True
        Me.ucrReceiverMultipleMeanComparisonUseModel.frmParent = Me
        Me.ucrReceiverMultipleMeanComparisonUseModel.Location = New System.Drawing.Point(322, 75)
        Me.ucrReceiverMultipleMeanComparisonUseModel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleMeanComparisonUseModel.Name = "ucrReceiverMultipleMeanComparisonUseModel"
        Me.ucrReceiverMultipleMeanComparisonUseModel.Selector = Nothing
        Me.ucrReceiverMultipleMeanComparisonUseModel.Size = New System.Drawing.Size(160, 27)
        Me.ucrReceiverMultipleMeanComparisonUseModel.strNcFilePath = ""
        Me.ucrReceiverMultipleMeanComparisonUseModel.TabIndex = 29
        Me.ucrReceiverMultipleMeanComparisonUseModel.ucrSelector = Nothing
        '
        'ucrSaveModelMultipleComparisons
        '
        Me.ucrSaveModelMultipleComparisons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveModelMultipleComparisons.Location = New System.Drawing.Point(12, 458)
        Me.ucrSaveModelMultipleComparisons.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSaveModelMultipleComparisons.Name = "ucrSaveModelMultipleComparisons"
        Me.ucrSaveModelMultipleComparisons.Size = New System.Drawing.Size(408, 30)
        Me.ucrSaveModelMultipleComparisons.TabIndex = 27
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(8, 533)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(511, 65)
        Me.ucrBase.TabIndex = 24
        '
        'ucrSelectorModelMultipleComparisons
        '
        Me.ucrSelectorModelMultipleComparisons.AutoSize = True
        Me.ucrSelectorModelMultipleComparisons.bDropUnusedFilterLevels = False
        Me.ucrSelectorModelMultipleComparisons.bShowHiddenColumns = False
        Me.ucrSelectorModelMultipleComparisons.bUseCurrentFilter = True
        Me.ucrSelectorModelMultipleComparisons.Location = New System.Drawing.Point(12, 15)
        Me.ucrSelectorModelMultipleComparisons.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorModelMultipleComparisons.Name = "ucrSelectorModelMultipleComparisons"
        Me.ucrSelectorModelMultipleComparisons.Size = New System.Drawing.Size(284, 227)
        Me.ucrSelectorModelMultipleComparisons.TabIndex = 5
        '
        'dlgModelMultipleComparisons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 604)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrInputGenerateMultipleComparisonGraphs)
        Me.Controls.Add(Me.ucrChkGenerateMultipleComparisonPlot)
        Me.Controls.Add(Me.ucrChkByOptional)
        Me.Controls.Add(Me.ucrInputComboBoxAdjustment)
        Me.Controls.Add(Me.ucrChkAdjustment)
        Me.Controls.Add(Me.ucrInputComboBoxDescending)
        Me.Controls.Add(Me.ucrChkDescending)
        Me.Controls.Add(Me.ucrInputComboBoxDisplayLetters)
        Me.Controls.Add(Me.ucrChkDisplayLetters)
        Me.Controls.Add(Me.ucrInputComboBoxConfidenceInterval)
        Me.Controls.Add(Me.ucrChkConfidenceInterval)
        Me.Controls.Add(Me.ucrInputComboBoxAlpha)
        Me.Controls.Add(Me.ucrChkAlpha)
        Me.Controls.Add(Me.btnTransformation)
        Me.Controls.Add(Me.ucrReceiverBy)
        Me.Controls.Add(Me.lblVariabletoUse)
        Me.Controls.Add(Me.ucrReceiverLabelVariable)
        Me.Controls.Add(Me.lblMultipleMeanComparisonModeltoUse)
        Me.Controls.Add(Me.ucrReceiverMultipleMeanComparisonUseModel)
        Me.Controls.Add(Me.ucrSaveModelMultipleComparisons)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorModelMultipleComparisons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "dlgModelMultipleComparisons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multiple Comparisons"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorModelMultipleComparisons As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSaveModelMultipleComparisons As ucrSave
    Friend WithEvents lblMultipleMeanComparisonModeltoUse As Label
    Friend WithEvents ucrReceiverMultipleMeanComparisonUseModel As ucrReceiverSingle
    Friend WithEvents lblVariabletoUse As Label
    Friend WithEvents ucrReceiverLabelVariable As ucrReceiverSingle
    Friend WithEvents ucrReceiverBy As ucrReceiverSingle
    Friend WithEvents ucrChkAlpha As ucrCheck
    Friend WithEvents ucrInputComboBoxAlpha As ucrInputComboBox
    Friend WithEvents btnTransformation As Button
    Friend WithEvents ucrChkConfidenceInterval As ucrCheck
    Friend WithEvents ucrInputComboBoxConfidenceInterval As ucrInputComboBox
    Friend WithEvents ucrChkDisplayLetters As ucrCheck
    Friend WithEvents ucrInputComboBoxDisplayLetters As ucrInputComboBox
    Friend WithEvents ucrChkDescending As ucrCheck
    Friend WithEvents ucrInputComboBoxDescending As ucrInputComboBox
    Friend WithEvents ucrChkAdjustment As ucrCheck
    Friend WithEvents ucrInputComboBoxAdjustment As ucrInputComboBox
    Friend WithEvents ucrChkByOptional As ucrCheck
    Friend WithEvents ucrInputGenerateMultipleComparisonGraphs As ucrInputComboBox
    Friend WithEvents ucrChkGenerateMultipleComparisonPlot As ucrCheck
    Friend WithEvents ucrSaveGraph As ucrSave
End Class