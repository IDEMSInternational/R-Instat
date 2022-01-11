<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCalculateTreatmentDifferences
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
        Me.ucrBase = New instat.ucrButtons()
        Me.lblTreatment2 = New System.Windows.Forms.Label()
        Me.lblOption1 = New System.Windows.Forms.Label()
        Me.ucrInputFactorOption2 = New instat.ucrInputFactorLevels()
        Me.ucrInputFactorOption1 = New instat.ucrInputFactorLevels()
        Me.ucrReceiverID = New instat.ucrReceiverSingle()
        Me.lblID = New System.Windows.Forms.Label()
        Me.ucrReceiverOption = New instat.ucrReceiverSingle()
        Me.lblOption = New System.Windows.Forms.Label()
        Me.ucrReceiverMeasurement = New instat.ucrReceiverSingle()
        Me.lblMeasurement = New System.Windows.Forms.Label()
        Me.ucrSelectorDifference = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverContexts = New instat.ucrReceiverMultiple()
        Me.lblContexts = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.ucrInputCategoryColumn = New instat.ucrInputTextBox()
        Me.lblCategoryColumn = New System.Windows.Forms.Label()
        Me.ucrInputDiffName = New instat.ucrInputTextBox()
        Me.lblDiffName = New System.Windows.Forms.Label()
        Me.ucrInputLabels = New instat.ucrInputTextBox()
        Me.lblLabels = New System.Windows.Forms.Label()
        Me.ucrInputBreakPoints = New instat.ucrInputTextBox()
        Me.lblBreakPoints = New System.Windows.Forms.Label()
        Me.ucrChkCalculateDiffCategories = New instat.ucrCheck()
        Me.ucrSaveDataFrame = New instat.ucrSave()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 437)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 0
        '
        'lblTreatment2
        '
        Me.lblTreatment2.AutoSize = True
        Me.lblTreatment2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTreatment2.Location = New System.Drawing.Point(272, 149)
        Me.lblTreatment2.Name = "lblTreatment2"
        Me.lblTreatment2.Size = New System.Drawing.Size(50, 13)
        Me.lblTreatment2.TabIndex = 23
        Me.lblTreatment2.Text = "Option 2:"
        '
        'lblOption1
        '
        Me.lblOption1.AutoSize = True
        Me.lblOption1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOption1.Location = New System.Drawing.Point(272, 107)
        Me.lblOption1.Name = "lblOption1"
        Me.lblOption1.Size = New System.Drawing.Size(50, 13)
        Me.lblOption1.TabIndex = 21
        Me.lblOption1.Text = "Option 1:"
        '
        'ucrInputFactorOption2
        '
        Me.ucrInputFactorOption2.AddQuotesIfUnrecognised = True
        Me.ucrInputFactorOption2.AutoSize = True
        Me.ucrInputFactorOption2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFactorOption2.GetSetSelectedIndex = -1
        Me.ucrInputFactorOption2.IsReadOnly = False
        Me.ucrInputFactorOption2.Location = New System.Drawing.Point(272, 164)
        Me.ucrInputFactorOption2.Name = "ucrInputFactorOption2"
        Me.ucrInputFactorOption2.Size = New System.Drawing.Size(0, 0)
        Me.ucrInputFactorOption2.TabIndex = 24
        '
        'ucrInputFactorOption1
        '
        Me.ucrInputFactorOption1.AddQuotesIfUnrecognised = True
        Me.ucrInputFactorOption1.AutoSize = True
        Me.ucrInputFactorOption1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFactorOption1.GetSetSelectedIndex = -1
        Me.ucrInputFactorOption1.IsReadOnly = False
        Me.ucrInputFactorOption1.Location = New System.Drawing.Point(272, 122)
        Me.ucrInputFactorOption1.Name = "ucrInputFactorOption1"
        Me.ucrInputFactorOption1.Size = New System.Drawing.Size(0, 0)
        Me.ucrInputFactorOption1.TabIndex = 22
        '
        'ucrReceiverID
        '
        Me.ucrReceiverID.AutoSize = True
        Me.ucrReceiverID.frmParent = Me
        Me.ucrReceiverID.Location = New System.Drawing.Point(272, 206)
        Me.ucrReceiverID.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverID.Name = "ucrReceiverID"
        Me.ucrReceiverID.Selector = Nothing
        Me.ucrReceiverID.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverID.strNcFilePath = ""
        Me.ucrReceiverID.TabIndex = 26
        Me.ucrReceiverID.ucrSelector = Nothing
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblID.Location = New System.Drawing.Point(272, 191)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 13)
        Me.lblID.TabIndex = 25
        Me.lblID.Text = "ID:"
        '
        'ucrReceiverOption
        '
        Me.ucrReceiverOption.AutoSize = True
        Me.ucrReceiverOption.frmParent = Me
        Me.ucrReceiverOption.Location = New System.Drawing.Point(272, 81)
        Me.ucrReceiverOption.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverOption.Name = "ucrReceiverOption"
        Me.ucrReceiverOption.Selector = Nothing
        Me.ucrReceiverOption.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverOption.strNcFilePath = ""
        Me.ucrReceiverOption.TabIndex = 20
        Me.ucrReceiverOption.ucrSelector = Nothing
        '
        'lblOption
        '
        Me.lblOption.AutoSize = True
        Me.lblOption.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOption.Location = New System.Drawing.Point(272, 66)
        Me.lblOption.Name = "lblOption"
        Me.lblOption.Size = New System.Drawing.Size(41, 13)
        Me.lblOption.TabIndex = 19
        Me.lblOption.Text = "Option:"
        '
        'ucrReceiverMeasurement
        '
        Me.ucrReceiverMeasurement.AutoSize = True
        Me.ucrReceiverMeasurement.frmParent = Me
        Me.ucrReceiverMeasurement.Location = New System.Drawing.Point(272, 40)
        Me.ucrReceiverMeasurement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeasurement.Name = "ucrReceiverMeasurement"
        Me.ucrReceiverMeasurement.Selector = Nothing
        Me.ucrReceiverMeasurement.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMeasurement.strNcFilePath = ""
        Me.ucrReceiverMeasurement.TabIndex = 18
        Me.ucrReceiverMeasurement.ucrSelector = Nothing
        '
        'lblMeasurement
        '
        Me.lblMeasurement.AutoSize = True
        Me.lblMeasurement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMeasurement.Location = New System.Drawing.Point(272, 25)
        Me.lblMeasurement.Name = "lblMeasurement"
        Me.lblMeasurement.Size = New System.Drawing.Size(74, 13)
        Me.lblMeasurement.TabIndex = 17
        Me.lblMeasurement.Text = "Measurement:"
        '
        'ucrSelectorDifference
        '
        Me.ucrSelectorDifference.AutoSize = True
        Me.ucrSelectorDifference.bDropUnusedFilterLevels = False
        Me.ucrSelectorDifference.bShowHiddenColumns = False
        Me.ucrSelectorDifference.bUseCurrentFilter = True
        Me.ucrSelectorDifference.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorDifference.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDifference.Name = "ucrSelectorDifference"
        Me.ucrSelectorDifference.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorDifference.TabIndex = 16
        '
        'ucrReceiverContexts
        '
        Me.ucrReceiverContexts.AutoSize = True
        Me.ucrReceiverContexts.frmParent = Me
        Me.ucrReceiverContexts.Location = New System.Drawing.Point(272, 255)
        Me.ucrReceiverContexts.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContexts.Name = "ucrReceiverContexts"
        Me.ucrReceiverContexts.Selector = Nothing
        Me.ucrReceiverContexts.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverContexts.strNcFilePath = ""
        Me.ucrReceiverContexts.TabIndex = 28
        Me.ucrReceiverContexts.ucrSelector = Nothing
        '
        'lblContexts
        '
        Me.lblContexts.AutoSize = True
        Me.lblContexts.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblContexts.Location = New System.Drawing.Point(272, 239)
        Me.lblContexts.Name = "lblContexts"
        Me.lblContexts.Size = New System.Drawing.Size(89, 13)
        Me.lblContexts.TabIndex = 29
        Me.lblContexts.Text = "Contexts to carry:"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrInputCategoryColumn)
        Me.grpOptions.Controls.Add(Me.lblCategoryColumn)
        Me.grpOptions.Controls.Add(Me.ucrInputDiffName)
        Me.grpOptions.Controls.Add(Me.lblDiffName)
        Me.grpOptions.Controls.Add(Me.ucrInputLabels)
        Me.grpOptions.Controls.Add(Me.lblLabels)
        Me.grpOptions.Controls.Add(Me.ucrInputBreakPoints)
        Me.grpOptions.Controls.Add(Me.lblBreakPoints)
        Me.grpOptions.Controls.Add(Me.ucrChkCalculateDiffCategories)
        Me.grpOptions.Location = New System.Drawing.Point(12, 197)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(234, 205)
        Me.grpOptions.TabIndex = 30
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'ucrInputCategoryColumn
        '
        Me.ucrInputCategoryColumn.AddQuotesIfUnrecognised = True
        Me.ucrInputCategoryColumn.AutoSize = True
        Me.ucrInputCategoryColumn.IsMultiline = False
        Me.ucrInputCategoryColumn.IsReadOnly = False
        Me.ucrInputCategoryColumn.Location = New System.Drawing.Point(126, 176)
        Me.ucrInputCategoryColumn.Name = "ucrInputCategoryColumn"
        Me.ucrInputCategoryColumn.Size = New System.Drawing.Size(101, 21)
        Me.ucrInputCategoryColumn.TabIndex = 19
        '
        'lblCategoryColumn
        '
        Me.lblCategoryColumn.AutoSize = True
        Me.lblCategoryColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCategoryColumn.Location = New System.Drawing.Point(5, 178)
        Me.lblCategoryColumn.Name = "lblCategoryColumn"
        Me.lblCategoryColumn.Size = New System.Drawing.Size(90, 13)
        Me.lblCategoryColumn.TabIndex = 18
        Me.lblCategoryColumn.Text = "Category Column:"
        '
        'ucrInputDiffName
        '
        Me.ucrInputDiffName.AddQuotesIfUnrecognised = True
        Me.ucrInputDiffName.AutoSize = True
        Me.ucrInputDiffName.IsMultiline = False
        Me.ucrInputDiffName.IsReadOnly = False
        Me.ucrInputDiffName.Location = New System.Drawing.Point(126, 28)
        Me.ucrInputDiffName.Name = "ucrInputDiffName"
        Me.ucrInputDiffName.Size = New System.Drawing.Size(102, 21)
        Me.ucrInputDiffName.TabIndex = 17
        '
        'lblDiffName
        '
        Me.lblDiffName.AutoSize = True
        Me.lblDiffName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDiffName.Location = New System.Drawing.Point(6, 30)
        Me.lblDiffName.Name = "lblDiffName"
        Me.lblDiffName.Size = New System.Drawing.Size(97, 13)
        Me.lblDiffName.TabIndex = 16
        Me.lblDiffName.Text = "Difference Column:"
        '
        'ucrInputLabels
        '
        Me.ucrInputLabels.AddQuotesIfUnrecognised = True
        Me.ucrInputLabels.AutoSize = True
        Me.ucrInputLabels.IsMultiline = False
        Me.ucrInputLabels.IsReadOnly = False
        Me.ucrInputLabels.Location = New System.Drawing.Point(95, 128)
        Me.ucrInputLabels.Name = "ucrInputLabels"
        Me.ucrInputLabels.Size = New System.Drawing.Size(133, 42)
        Me.ucrInputLabels.TabIndex = 15
        '
        'lblLabels
        '
        Me.lblLabels.AutoSize = True
        Me.lblLabels.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLabels.Location = New System.Drawing.Point(6, 130)
        Me.lblLabels.Name = "lblLabels"
        Me.lblLabels.Size = New System.Drawing.Size(41, 13)
        Me.lblLabels.TabIndex = 14
        Me.lblLabels.Text = "Labels:"
        '
        'ucrInputBreakPoints
        '
        Me.ucrInputBreakPoints.AddQuotesIfUnrecognised = True
        Me.ucrInputBreakPoints.AutoSize = True
        Me.ucrInputBreakPoints.IsMultiline = False
        Me.ucrInputBreakPoints.IsReadOnly = False
        Me.ucrInputBreakPoints.Location = New System.Drawing.Point(95, 98)
        Me.ucrInputBreakPoints.Name = "ucrInputBreakPoints"
        Me.ucrInputBreakPoints.Size = New System.Drawing.Size(133, 21)
        Me.ucrInputBreakPoints.TabIndex = 7
        '
        'lblBreakPoints
        '
        Me.lblBreakPoints.AutoSize = True
        Me.lblBreakPoints.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBreakPoints.Location = New System.Drawing.Point(6, 100)
        Me.lblBreakPoints.Name = "lblBreakPoints"
        Me.lblBreakPoints.Size = New System.Drawing.Size(70, 13)
        Me.lblBreakPoints.TabIndex = 6
        Me.lblBreakPoints.Text = "Break Points:"
        '
        'ucrChkCalculateDiffCategories
        '
        Me.ucrChkCalculateDiffCategories.AutoSize = True
        Me.ucrChkCalculateDiffCategories.Checked = False
        Me.ucrChkCalculateDiffCategories.Location = New System.Drawing.Point(6, 70)
        Me.ucrChkCalculateDiffCategories.Name = "ucrChkCalculateDiffCategories"
        Me.ucrChkCalculateDiffCategories.Size = New System.Drawing.Size(221, 23)
        Me.ucrChkCalculateDiffCategories.TabIndex = 13
        '
        'ucrSaveDataFrame
        '
        Me.ucrSaveDataFrame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveDataFrame.Location = New System.Drawing.Point(10, 408)
        Me.ucrSaveDataFrame.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveDataFrame.Name = "ucrSaveDataFrame"
        Me.ucrSaveDataFrame.Size = New System.Drawing.Size(399, 24)
        Me.ucrSaveDataFrame.TabIndex = 31
        '
        'dlgCalculateTreatmentDifferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(426, 491)
        Me.Controls.Add(Me.ucrSaveDataFrame)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.lblContexts)
        Me.Controls.Add(Me.ucrReceiverContexts)
        Me.Controls.Add(Me.lblTreatment2)
        Me.Controls.Add(Me.lblOption1)
        Me.Controls.Add(Me.ucrInputFactorOption2)
        Me.Controls.Add(Me.ucrInputFactorOption1)
        Me.Controls.Add(Me.ucrReceiverID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.ucrReceiverOption)
        Me.Controls.Add(Me.lblOption)
        Me.Controls.Add(Me.ucrReceiverMeasurement)
        Me.Controls.Add(Me.lblMeasurement)
        Me.Controls.Add(Me.ucrSelectorDifference)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCalculateTreatmentDifferences"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculate Difference Between Options "
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblTreatment2 As Label
    Friend WithEvents lblOption1 As Label
    Friend WithEvents ucrInputFactorOption2 As ucrInputFactorLevels
    Friend WithEvents ucrInputFactorOption1 As ucrInputFactorLevels
    Friend WithEvents ucrReceiverID As ucrReceiverSingle
    Friend WithEvents lblID As Label
    Friend WithEvents ucrReceiverOption As ucrReceiverSingle
    Friend WithEvents lblOption As Label
    Friend WithEvents ucrReceiverMeasurement As ucrReceiverSingle
    Friend WithEvents lblMeasurement As Label
    Friend WithEvents ucrSelectorDifference As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblContexts As Label
    Friend WithEvents ucrReceiverContexts As ucrReceiverMultiple
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents ucrInputBreakPoints As ucrInputTextBox
    Friend WithEvents lblBreakPoints As Label
    Friend WithEvents ucrChkCalculateDiffCategories As ucrCheck
    Friend WithEvents ucrInputLabels As ucrInputTextBox
    Friend WithEvents lblLabels As Label
    Friend WithEvents ucrInputDiffName As ucrInputTextBox
    Friend WithEvents lblDiffName As Label
    Friend WithEvents ucrInputCategoryColumn As ucrInputTextBox
    Friend WithEvents lblCategoryColumn As Label
    Friend WithEvents ucrSaveDataFrame As ucrSave
End Class
