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
        Me.ucrPnlComparisonType = New instat.UcrPanel()
        Me.rdoMultiple = New System.Windows.Forms.RadioButton()
        Me.rdoPairwise = New System.Windows.Forms.RadioButton()
        Me.rdoReference = New System.Windows.Forms.RadioButton()
        Me.lblMultipleMeanComparisonModeltoUse = New System.Windows.Forms.Label()
        Me.lblVariabletoUse = New System.Windows.Forms.Label()
        Me.btnTransformation = New System.Windows.Forms.Button()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrInputGenerateMultipleComparisonGraphs = New instat.ucrInputComboBox()
        Me.ucrChkGenerateMultipleComparisonPlot = New instat.ucrCheck()
        Me.ucrChkByOptional = New instat.ucrCheck()
        Me.lblReference = New System.Windows.Forms.Label()
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
        Me.ucrReceiverReference = New instat.ucrInputComboBox()
        Me.ucrReceiverLabelVariable = New instat.ucrReceiverSingle()
        Me.ucrReceiverMultipleMeanComparisonUseModel = New instat.ucrReceiverSingle()
        Me.ucrSaveModelMultipleComparisons = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorModelMultipleComparisons = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'ucrPnlComparisonType
        '
        Me.ucrPnlComparisonType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlComparisonType.Location = New System.Drawing.Point(92, 15)
        Me.ucrPnlComparisonType.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrPnlComparisonType.Name = "ucrPnlComparisonType"
        Me.ucrPnlComparisonType.Size = New System.Drawing.Size(340, 72)
        Me.ucrPnlComparisonType.TabIndex = 61
        '
        'rdoMultiple
        '
        Me.rdoMultiple.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMultiple.BackColor = System.Drawing.SystemColors.Control
        Me.rdoMultiple.Checked = True
        Me.rdoMultiple.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.FlatAppearance.BorderSize = 2
        Me.rdoMultiple.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMultiple.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMultiple.Location = New System.Drawing.Point(103, 24)
        Me.rdoMultiple.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoMultiple.Name = "rdoMultiple"
        Me.rdoMultiple.Size = New System.Drawing.Size(109, 55)
        Me.rdoMultiple.TabIndex = 0
        Me.rdoMultiple.TabStop = True
        Me.rdoMultiple.Tag = "Type"
        Me.rdoMultiple.Text = "Multiple"
        Me.rdoMultiple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMultiple.UseVisualStyleBackColor = False
        '
        'rdoPairwise
        '
        Me.rdoPairwise.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPairwise.BackColor = System.Drawing.SystemColors.Control
        Me.rdoPairwise.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPairwise.FlatAppearance.BorderSize = 2
        Me.rdoPairwise.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPairwise.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPairwise.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPairwise.Location = New System.Drawing.Point(204, 24)
        Me.rdoPairwise.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoPairwise.Name = "rdoPairwise"
        Me.rdoPairwise.Size = New System.Drawing.Size(109, 55)
        Me.rdoPairwise.TabIndex = 1
        Me.rdoPairwise.TabStop = True
        Me.rdoPairwise.Tag = "Type"
        Me.rdoPairwise.Text = "Pairwise"
        Me.rdoPairwise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPairwise.UseVisualStyleBackColor = False
        '
        'rdoReference
        '
        Me.rdoReference.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoReference.BackColor = System.Drawing.SystemColors.Control
        Me.rdoReference.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoReference.FlatAppearance.BorderSize = 2
        Me.rdoReference.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoReference.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoReference.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoReference.Location = New System.Drawing.Point(305, 24)
        Me.rdoReference.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoReference.Name = "rdoReference"
        Me.rdoReference.Size = New System.Drawing.Size(109, 55)
        Me.rdoReference.TabIndex = 2
        Me.rdoReference.TabStop = True
        Me.rdoReference.Tag = "Type"
        Me.rdoReference.Text = "Reference"
        Me.rdoReference.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoReference.UseVisualStyleBackColor = False
        '
        'lblMultipleMeanComparisonModeltoUse
        '
        Me.lblMultipleMeanComparisonModeltoUse.AutoSize = True
        Me.lblMultipleMeanComparisonModeltoUse.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblMultipleMeanComparisonModeltoUse.Location = New System.Drawing.Point(322, 117)
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
        Me.lblVariabletoUse.Location = New System.Drawing.Point(323, 171)
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
        Me.btnTransformation.Location = New System.Drawing.Point(322, 339)
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
        Me.ucrSaveGraph.Location = New System.Drawing.Point(12, 554)
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
        Me.ucrInputGenerateMultipleComparisonGraphs.Location = New System.Drawing.Point(205, 340)
        Me.ucrInputGenerateMultipleComparisonGraphs.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInputGenerateMultipleComparisonGraphs.Name = "ucrInputGenerateMultipleComparisonGraphs"
        Me.ucrInputGenerateMultipleComparisonGraphs.Size = New System.Drawing.Size(112, 27)
        Me.ucrInputGenerateMultipleComparisonGraphs.TabIndex = 47
        '
        'ucrChkGenerateMultipleComparisonPlot
        '
        Me.ucrChkGenerateMultipleComparisonPlot.AutoSize = True
        Me.ucrChkGenerateMultipleComparisonPlot.Checked = False
        Me.ucrChkGenerateMultipleComparisonPlot.Location = New System.Drawing.Point(12, 340)
        Me.ucrChkGenerateMultipleComparisonPlot.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrChkGenerateMultipleComparisonPlot.Name = "ucrChkGenerateMultipleComparisonPlot"
        Me.ucrChkGenerateMultipleComparisonPlot.Size = New System.Drawing.Size(187, 30)
        Me.ucrChkGenerateMultipleComparisonPlot.TabIndex = 46
        '
        'ucrChkByOptional
        '
        Me.ucrChkByOptional.AutoSize = True
        Me.ucrChkByOptional.Checked = False
        Me.ucrChkByOptional.Location = New System.Drawing.Point(322, 224)
        Me.ucrChkByOptional.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrChkByOptional.Name = "ucrChkByOptional"
        Me.ucrChkByOptional.Size = New System.Drawing.Size(105, 29)
        Me.ucrChkByOptional.TabIndex = 45
        '
        'lblReference
        '
        Me.lblReference.AutoSize = True
        Me.lblReference.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblReference.Location = New System.Drawing.Point(323, 286)
        Me.lblReference.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReference.Name = "lblReference"
        Me.lblReference.Size = New System.Drawing.Size(109, 16)
        Me.lblReference.TabIndex = 62
        Me.lblReference.Tag = "Reference_Level:"
        Me.lblReference.Text = "Reference Level:"
        '
        'ucrInputComboBoxAdjustment
        '
        Me.ucrInputComboBoxAdjustment.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBoxAdjustment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboBoxAdjustment.GetSetSelectedIndex = -1
        Me.ucrInputComboBoxAdjustment.IsReadOnly = False
        Me.ucrInputComboBoxAdjustment.Location = New System.Drawing.Point(205, 402)
        Me.ucrInputComboBoxAdjustment.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInputComboBoxAdjustment.Name = "ucrInputComboBoxAdjustment"
        Me.ucrInputComboBoxAdjustment.Size = New System.Drawing.Size(112, 27)
        Me.ucrInputComboBoxAdjustment.TabIndex = 44
        '
        'ucrChkAdjustment
        '
        Me.ucrChkAdjustment.AutoSize = True
        Me.ucrChkAdjustment.Checked = False
        Me.ucrChkAdjustment.Location = New System.Drawing.Point(12, 402)
        Me.ucrChkAdjustment.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrChkAdjustment.Name = "ucrChkAdjustment"
        Me.ucrChkAdjustment.Size = New System.Drawing.Size(187, 30)
        Me.ucrChkAdjustment.TabIndex = 43
        '
        'ucrInputComboBoxDescending
        '
        Me.ucrInputComboBoxDescending.AddQuotesIfUnrecognised = False
        Me.ucrInputComboBoxDescending.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboBoxDescending.GetSetSelectedIndex = -1
        Me.ucrInputComboBoxDescending.IsReadOnly = False
        Me.ucrInputComboBoxDescending.Location = New System.Drawing.Point(205, 371)
        Me.ucrInputComboBoxDescending.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInputComboBoxDescending.Name = "ucrInputComboBoxDescending"
        Me.ucrInputComboBoxDescending.Size = New System.Drawing.Size(112, 27)
        Me.ucrInputComboBoxDescending.TabIndex = 42
        '
        'ucrChkDescending
        '
        Me.ucrChkDescending.AutoSize = True
        Me.ucrChkDescending.Checked = False
        Me.ucrChkDescending.Location = New System.Drawing.Point(12, 371)
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
        Me.ucrInputComboBoxDisplayLetters.Location = New System.Drawing.Point(205, 464)
        Me.ucrInputComboBoxDisplayLetters.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInputComboBoxDisplayLetters.Name = "ucrInputComboBoxDisplayLetters"
        Me.ucrInputComboBoxDisplayLetters.Size = New System.Drawing.Size(112, 27)
        Me.ucrInputComboBoxDisplayLetters.TabIndex = 40
        '
        'ucrChkDisplayLetters
        '
        Me.ucrChkDisplayLetters.AutoSize = True
        Me.ucrChkDisplayLetters.Checked = False
        Me.ucrChkDisplayLetters.Location = New System.Drawing.Point(12, 464)
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
        Me.ucrInputComboBoxConfidenceInterval.Location = New System.Drawing.Point(205, 433)
        Me.ucrInputComboBoxConfidenceInterval.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInputComboBoxConfidenceInterval.Name = "ucrInputComboBoxConfidenceInterval"
        Me.ucrInputComboBoxConfidenceInterval.Size = New System.Drawing.Size(112, 27)
        Me.ucrInputComboBoxConfidenceInterval.TabIndex = 38
        '
        'ucrChkConfidenceInterval
        '
        Me.ucrChkConfidenceInterval.AutoSize = True
        Me.ucrChkConfidenceInterval.Checked = False
        Me.ucrChkConfidenceInterval.Location = New System.Drawing.Point(12, 433)
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
        Me.ucrInputComboBoxAlpha.Location = New System.Drawing.Point(205, 309)
        Me.ucrInputComboBoxAlpha.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInputComboBoxAlpha.Name = "ucrInputComboBoxAlpha"
        Me.ucrInputComboBoxAlpha.Size = New System.Drawing.Size(112, 27)
        Me.ucrInputComboBoxAlpha.TabIndex = 36
        '
        'ucrChkAlpha
        '
        Me.ucrChkAlpha.AutoSize = True
        Me.ucrChkAlpha.Checked = False
        Me.ucrChkAlpha.Location = New System.Drawing.Point(12, 309)
        Me.ucrChkAlpha.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrChkAlpha.Name = "ucrChkAlpha"
        Me.ucrChkAlpha.Size = New System.Drawing.Size(187, 30)
        Me.ucrChkAlpha.TabIndex = 35
        '
        'ucrReceiverBy
        '
        Me.ucrReceiverBy.AutoSize = True
        Me.ucrReceiverBy.frmParent = Me
        Me.ucrReceiverBy.Location = New System.Drawing.Point(322, 256)
        Me.ucrReceiverBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverBy.Name = "ucrReceiverBy"
        Me.ucrReceiverBy.Selector = Nothing
        Me.ucrReceiverBy.Size = New System.Drawing.Size(160, 27)
        Me.ucrReceiverBy.strNcFilePath = ""
        Me.ucrReceiverBy.TabIndex = 33
        Me.ucrReceiverBy.ucrSelector = Nothing
        '
        'ucrReceiverReference
        '
        Me.ucrReceiverReference.AddQuotesIfUnrecognised = True
        Me.ucrReceiverReference.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrReceiverReference.GetSetSelectedIndex = -1
        Me.ucrReceiverReference.IsReadOnly = False
        Me.ucrReceiverReference.Location = New System.Drawing.Point(322, 305)
        Me.ucrReceiverReference.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverReference.Name = "ucrReceiverReference"
        Me.ucrReceiverReference.Size = New System.Drawing.Size(160, 27)
        Me.ucrReceiverReference.TabIndex = 63
        '
        'ucrReceiverLabelVariable
        '
        Me.ucrReceiverLabelVariable.AutoSize = True
        Me.ucrReceiverLabelVariable.frmParent = Me
        Me.ucrReceiverLabelVariable.Location = New System.Drawing.Point(322, 188)
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
        Me.ucrReceiverMultipleMeanComparisonUseModel.Location = New System.Drawing.Point(322, 135)
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
        Me.ucrSaveModelMultipleComparisons.Location = New System.Drawing.Point(12, 518)
        Me.ucrSaveModelMultipleComparisons.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSaveModelMultipleComparisons.Name = "ucrSaveModelMultipleComparisons"
        Me.ucrSaveModelMultipleComparisons.Size = New System.Drawing.Size(408, 30)
        Me.ucrSaveModelMultipleComparisons.TabIndex = 27
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(8, 593)
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
        Me.ucrSelectorModelMultipleComparisons.Location = New System.Drawing.Point(12, 75)
        Me.ucrSelectorModelMultipleComparisons.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorModelMultipleComparisons.Name = "ucrSelectorModelMultipleComparisons"
        Me.ucrSelectorModelMultipleComparisons.Size = New System.Drawing.Size(284, 227)
        Me.ucrSelectorModelMultipleComparisons.TabIndex = 5
        '
        'dlgModelMultipleComparisons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 665)
        Me.Controls.Add(Me.rdoMultiple)
        Me.Controls.Add(Me.rdoPairwise)
        Me.Controls.Add(Me.rdoReference)
        Me.Controls.Add(Me.ucrPnlComparisonType)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrInputGenerateMultipleComparisonGraphs)
        Me.Controls.Add(Me.ucrChkGenerateMultipleComparisonPlot)
        Me.Controls.Add(Me.ucrChkByOptional)
        Me.Controls.Add(Me.lblReference)
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
        Me.Controls.Add(Me.ucrReceiverReference)
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
        Me.Text = "Comparisons"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrPnlComparisonType As instat.UcrPanel
    Friend WithEvents rdoMultiple As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPairwise As System.Windows.Forms.RadioButton
    Friend WithEvents rdoReference As System.Windows.Forms.RadioButton
    Friend WithEvents ucrSelectorModelMultipleComparisons As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSaveModelMultipleComparisons As ucrSave
    Friend WithEvents lblMultipleMeanComparisonModeltoUse As Label
    Friend WithEvents ucrReceiverMultipleMeanComparisonUseModel As ucrReceiverSingle
    Friend WithEvents lblVariabletoUse As Label
    Friend WithEvents lblReference As Label
    Friend WithEvents ucrReceiverLabelVariable As ucrReceiverSingle
    Friend WithEvents ucrReceiverBy As ucrReceiverSingle
    Friend WithEvents ucrReceiverReference As instat.ucrInputComboBox
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