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
        Me.lblBy = New System.Windows.Forms.Label()
        Me.btnTransformation = New System.Windows.Forms.Button()
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
        Me.lblMultipleMeanComparisonModeltoUse.Location = New System.Drawing.Point(230, 44)
        Me.lblMultipleMeanComparisonModeltoUse.Name = "lblMultipleMeanComparisonModeltoUse"
        Me.lblMultipleMeanComparisonModeltoUse.Size = New System.Drawing.Size(84, 13)
        Me.lblMultipleMeanComparisonModeltoUse.TabIndex = 28
        Me.lblMultipleMeanComparisonModeltoUse.Tag = "Selected_Model:"
        Me.lblMultipleMeanComparisonModeltoUse.Text = "Selected Model:"
        '
        'lblVariabletoUse
        '
        Me.lblVariabletoUse.AutoSize = True
        Me.lblVariabletoUse.Location = New System.Drawing.Point(231, 87)
        Me.lblVariabletoUse.Name = "lblVariabletoUse"
        Me.lblVariabletoUse.Size = New System.Drawing.Size(77, 13)
        Me.lblVariabletoUse.TabIndex = 30
        Me.lblVariabletoUse.Tag = "Label_Variable:"
        Me.lblVariabletoUse.Text = "Label Variable:"
        '
        'lblBy
        '
        Me.lblBy.AutoSize = True
        Me.lblBy.Location = New System.Drawing.Point(231, 130)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(70, 13)
        Me.lblBy.TabIndex = 32
        Me.lblBy.Tag = "By_Optional:"
        Me.lblBy.Text = "By (Optional):"
        '
        'btnTransformation
        '
        Me.btnTransformation.Enabled = False
        Me.btnTransformation.Location = New System.Drawing.Point(230, 180)
        Me.btnTransformation.Name = "btnTransformation"
        Me.btnTransformation.Size = New System.Drawing.Size(120, 25)
        Me.btnTransformation.TabIndex = 34
        Me.btnTransformation.Tag = "Transformation"
        Me.btnTransformation.Text = "Transformation"
        Me.btnTransformation.UseVisualStyleBackColor = True
        '
        'ucrInputComboBoxAdjustment
        '
        Me.ucrInputComboBoxAdjustment.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBoxAdjustment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboBoxAdjustment.GetSetSelectedIndex = -1
        Me.ucrInputComboBoxAdjustment.IsReadOnly = False
        Me.ucrInputComboBoxAdjustment.Location = New System.Drawing.Point(138, 314)
        Me.ucrInputComboBoxAdjustment.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInputComboBoxAdjustment.Name = "ucrInputComboBoxAdjustment"
        Me.ucrInputComboBoxAdjustment.Size = New System.Drawing.Size(84, 22)
        Me.ucrInputComboBoxAdjustment.TabIndex = 44
        '
        'ucrChkAdjustment
        '
        Me.ucrChkAdjustment.AutoSize = True
        Me.ucrChkAdjustment.Checked = False
        Me.ucrChkAdjustment.Location = New System.Drawing.Point(9, 314)
        Me.ucrChkAdjustment.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrChkAdjustment.Name = "ucrChkAdjustment"
        Me.ucrChkAdjustment.Size = New System.Drawing.Size(140, 24)
        Me.ucrChkAdjustment.TabIndex = 43
        '
        'ucrInputComboBoxDescending
        '
        Me.ucrInputComboBoxDescending.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBoxDescending.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboBoxDescending.GetSetSelectedIndex = -1
        Me.ucrInputComboBoxDescending.IsReadOnly = False
        Me.ucrInputComboBoxDescending.Location = New System.Drawing.Point(138, 286)
        Me.ucrInputComboBoxDescending.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInputComboBoxDescending.Name = "ucrInputComboBoxDescending"
        Me.ucrInputComboBoxDescending.Size = New System.Drawing.Size(84, 22)
        Me.ucrInputComboBoxDescending.TabIndex = 42
        '
        'ucrChkDescending
        '
        Me.ucrChkDescending.AutoSize = True
        Me.ucrChkDescending.Checked = False
        Me.ucrChkDescending.Location = New System.Drawing.Point(9, 286)
        Me.ucrChkDescending.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrChkDescending.Name = "ucrChkDescending"
        Me.ucrChkDescending.Size = New System.Drawing.Size(140, 24)
        Me.ucrChkDescending.TabIndex = 41
        '
        'ucrInputComboBoxDisplayLetters
        '
        Me.ucrInputComboBoxDisplayLetters.AddQuotesIfUnrecognised = False
        Me.ucrInputComboBoxDisplayLetters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboBoxDisplayLetters.GetSetSelectedIndex = -1
        Me.ucrInputComboBoxDisplayLetters.IsReadOnly = True
        Me.ucrInputComboBoxDisplayLetters.Location = New System.Drawing.Point(138, 258)
        Me.ucrInputComboBoxDisplayLetters.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInputComboBoxDisplayLetters.Name = "ucrInputComboBoxDisplayLetters"
        Me.ucrInputComboBoxDisplayLetters.Size = New System.Drawing.Size(84, 22)
        Me.ucrInputComboBoxDisplayLetters.TabIndex = 40
        '
        'ucrChkDisplayLetters
        '
        Me.ucrChkDisplayLetters.AutoSize = True
        Me.ucrChkDisplayLetters.Checked = False
        Me.ucrChkDisplayLetters.Location = New System.Drawing.Point(9, 258)
        Me.ucrChkDisplayLetters.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrChkDisplayLetters.Name = "ucrChkDisplayLetters"
        Me.ucrChkDisplayLetters.Size = New System.Drawing.Size(140, 24)
        Me.ucrChkDisplayLetters.TabIndex = 39
        '
        'ucrInputComboBoxConfidenceInterval
        '
        Me.ucrInputComboBoxConfidenceInterval.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBoxConfidenceInterval.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboBoxConfidenceInterval.GetSetSelectedIndex = -1
        Me.ucrInputComboBoxConfidenceInterval.IsReadOnly = False
        Me.ucrInputComboBoxConfidenceInterval.Location = New System.Drawing.Point(138, 230)
        Me.ucrInputComboBoxConfidenceInterval.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInputComboBoxConfidenceInterval.Name = "ucrInputComboBoxConfidenceInterval"
        Me.ucrInputComboBoxConfidenceInterval.Size = New System.Drawing.Size(84, 22)
        Me.ucrInputComboBoxConfidenceInterval.TabIndex = 38
        '
        'ucrChkConfidenceInterval
        '
        Me.ucrChkConfidenceInterval.AutoSize = True
        Me.ucrChkConfidenceInterval.Checked = False
        Me.ucrChkConfidenceInterval.Location = New System.Drawing.Point(9, 230)
        Me.ucrChkConfidenceInterval.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrChkConfidenceInterval.Name = "ucrChkConfidenceInterval"
        Me.ucrChkConfidenceInterval.Size = New System.Drawing.Size(140, 24)
        Me.ucrChkConfidenceInterval.TabIndex = 37
        '
        'ucrInputComboBoxAlpha
        '
        Me.ucrInputComboBoxAlpha.AddQuotesIfUnrecognised = False
        Me.ucrInputComboBoxAlpha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboBoxAlpha.GetSetSelectedIndex = -1
        Me.ucrInputComboBoxAlpha.IsReadOnly = True
        Me.ucrInputComboBoxAlpha.Location = New System.Drawing.Point(138, 202)
        Me.ucrInputComboBoxAlpha.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInputComboBoxAlpha.Name = "ucrInputComboBoxAlpha"
        Me.ucrInputComboBoxAlpha.Size = New System.Drawing.Size(84, 22)
        Me.ucrInputComboBoxAlpha.TabIndex = 36
        '
        'ucrChkAlpha
        '
        Me.ucrChkAlpha.AutoSize = True
        Me.ucrChkAlpha.Checked = False
        Me.ucrChkAlpha.Location = New System.Drawing.Point(9, 202)
        Me.ucrChkAlpha.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrChkAlpha.Name = "ucrChkAlpha"
        Me.ucrChkAlpha.Size = New System.Drawing.Size(80, 24)
        Me.ucrChkAlpha.TabIndex = 35
        '
        'ucrReceiverBy
        '
        Me.ucrReceiverBy.AutoSize = True
        Me.ucrReceiverBy.frmParent = Me
        Me.ucrReceiverBy.Location = New System.Drawing.Point(230, 147)
        Me.ucrReceiverBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverBy.Name = "ucrReceiverBy"
        Me.ucrReceiverBy.Selector = Nothing
        Me.ucrReceiverBy.Size = New System.Drawing.Size(120, 22)
        Me.ucrReceiverBy.strNcFilePath = ""
        Me.ucrReceiverBy.TabIndex = 33
        Me.ucrReceiverBy.ucrSelector = Nothing
        '
        'ucrReceiverLabelVariable
        '
        Me.ucrReceiverLabelVariable.AutoSize = True
        Me.ucrReceiverLabelVariable.frmParent = Me
        Me.ucrReceiverLabelVariable.Location = New System.Drawing.Point(230, 104)
        Me.ucrReceiverLabelVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLabelVariable.Name = "ucrReceiverLabelVariable"
        Me.ucrReceiverLabelVariable.Selector = Nothing
        Me.ucrReceiverLabelVariable.Size = New System.Drawing.Size(120, 22)
        Me.ucrReceiverLabelVariable.strNcFilePath = ""
        Me.ucrReceiverLabelVariable.TabIndex = 31
        Me.ucrReceiverLabelVariable.ucrSelector = Nothing
        '
        'ucrReceiverMultipleMeanComparisonUseModel
        '
        Me.ucrReceiverMultipleMeanComparisonUseModel.AutoSize = True
        Me.ucrReceiverMultipleMeanComparisonUseModel.frmParent = Me
        Me.ucrReceiverMultipleMeanComparisonUseModel.Location = New System.Drawing.Point(230, 61)
        Me.ucrReceiverMultipleMeanComparisonUseModel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleMeanComparisonUseModel.Name = "ucrReceiverMultipleMeanComparisonUseModel"
        Me.ucrReceiverMultipleMeanComparisonUseModel.Selector = Nothing
        Me.ucrReceiverMultipleMeanComparisonUseModel.Size = New System.Drawing.Size(120, 22)
        Me.ucrReceiverMultipleMeanComparisonUseModel.strNcFilePath = ""
        Me.ucrReceiverMultipleMeanComparisonUseModel.TabIndex = 29
        Me.ucrReceiverMultipleMeanComparisonUseModel.ucrSelector = Nothing
        '
        'ucrSaveModelMultipleComparisons
        '
        Me.ucrSaveModelMultipleComparisons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveModelMultipleComparisons.Location = New System.Drawing.Point(9, 351)
        Me.ucrSaveModelMultipleComparisons.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveModelMultipleComparisons.Name = "ucrSaveModelMultipleComparisons"
        Me.ucrSaveModelMultipleComparisons.Size = New System.Drawing.Size(306, 24)
        Me.ucrSaveModelMultipleComparisons.TabIndex = 27
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(6, 383)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 24
        '
        'ucrSelectorModelMultipleComparisons
        '
        Me.ucrSelectorModelMultipleComparisons.AutoSize = True
        Me.ucrSelectorModelMultipleComparisons.bDropUnusedFilterLevels = False
        Me.ucrSelectorModelMultipleComparisons.bShowHiddenColumns = False
        Me.ucrSelectorModelMultipleComparisons.bUseCurrentFilter = True
        Me.ucrSelectorModelMultipleComparisons.Location = New System.Drawing.Point(9, 12)
        Me.ucrSelectorModelMultipleComparisons.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorModelMultipleComparisons.Name = "ucrSelectorModelMultipleComparisons"
        Me.ucrSelectorModelMultipleComparisons.Size = New System.Drawing.Size(213, 184)
        Me.ucrSelectorModelMultipleComparisons.TabIndex = 5
        '
        'dlgModelMultipleComparisons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 439)
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
        Me.Controls.Add(Me.lblBy)
        Me.Controls.Add(Me.lblVariabletoUse)
        Me.Controls.Add(Me.ucrReceiverLabelVariable)
        Me.Controls.Add(Me.lblMultipleMeanComparisonModeltoUse)
        Me.Controls.Add(Me.ucrReceiverMultipleMeanComparisonUseModel)
        Me.Controls.Add(Me.ucrSaveModelMultipleComparisons)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorModelMultipleComparisons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
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
    Friend WithEvents lblBy As Label
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
End Class