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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgCalculateTreatmentDifferences))
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
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'lblTreatment2
        '
        resources.ApplyResources(Me.lblTreatment2, "lblTreatment2")
        Me.lblTreatment2.Name = "lblTreatment2"
        '
        'lblOption1
        '
        resources.ApplyResources(Me.lblOption1, "lblOption1")
        Me.lblOption1.Name = "lblOption1"
        '
        'ucrInputFactorOption2
        '
        Me.ucrInputFactorOption2.AddQuotesIfUnrecognised = True
        Me.ucrInputFactorOption2.GetSetSelectedIndex = -1
        Me.ucrInputFactorOption2.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFactorOption2, "ucrInputFactorOption2")
        Me.ucrInputFactorOption2.Name = "ucrInputFactorOption2"
        '
        'ucrInputFactorOption1
        '
        Me.ucrInputFactorOption1.AddQuotesIfUnrecognised = True
        Me.ucrInputFactorOption1.GetSetSelectedIndex = -1
        Me.ucrInputFactorOption1.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFactorOption1, "ucrInputFactorOption1")
        Me.ucrInputFactorOption1.Name = "ucrInputFactorOption1"
        '
        'ucrReceiverID
        '
        Me.ucrReceiverID.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverID, "ucrReceiverID")
        Me.ucrReceiverID.Name = "ucrReceiverID"
        Me.ucrReceiverID.Selector = Nothing
        Me.ucrReceiverID.strNcFilePath = ""
        Me.ucrReceiverID.ucrSelector = Nothing
        '
        'lblID
        '
        resources.ApplyResources(Me.lblID, "lblID")
        Me.lblID.Name = "lblID"
        '
        'ucrReceiverOption
        '
        Me.ucrReceiverOption.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverOption, "ucrReceiverOption")
        Me.ucrReceiverOption.Name = "ucrReceiverOption"
        Me.ucrReceiverOption.Selector = Nothing
        Me.ucrReceiverOption.strNcFilePath = ""
        Me.ucrReceiverOption.ucrSelector = Nothing
        '
        'lblOption
        '
        resources.ApplyResources(Me.lblOption, "lblOption")
        Me.lblOption.Name = "lblOption"
        '
        'ucrReceiverMeasurement
        '
        Me.ucrReceiverMeasurement.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMeasurement, "ucrReceiverMeasurement")
        Me.ucrReceiverMeasurement.Name = "ucrReceiverMeasurement"
        Me.ucrReceiverMeasurement.Selector = Nothing
        Me.ucrReceiverMeasurement.strNcFilePath = ""
        Me.ucrReceiverMeasurement.ucrSelector = Nothing
        '
        'lblMeasurement
        '
        resources.ApplyResources(Me.lblMeasurement, "lblMeasurement")
        Me.lblMeasurement.Name = "lblMeasurement"
        '
        'ucrSelectorDifference
        '
        Me.ucrSelectorDifference.bDropUnusedFilterLevels = False
        Me.ucrSelectorDifference.bShowHiddenColumns = False
        Me.ucrSelectorDifference.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorDifference, "ucrSelectorDifference")
        Me.ucrSelectorDifference.Name = "ucrSelectorDifference"
        '
        'ucrReceiverContexts
        '
        Me.ucrReceiverContexts.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverContexts, "ucrReceiverContexts")
        Me.ucrReceiverContexts.Name = "ucrReceiverContexts"
        Me.ucrReceiverContexts.Selector = Nothing
        Me.ucrReceiverContexts.strNcFilePath = ""
        Me.ucrReceiverContexts.ucrSelector = Nothing
        '
        'lblContexts
        '
        resources.ApplyResources(Me.lblContexts, "lblContexts")
        Me.lblContexts.Name = "lblContexts"
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
        resources.ApplyResources(Me.grpOptions, "grpOptions")
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.TabStop = False
        '
        'ucrInputCategoryColumn
        '
        Me.ucrInputCategoryColumn.AddQuotesIfUnrecognised = True
        Me.ucrInputCategoryColumn.IsMultiline = False
        Me.ucrInputCategoryColumn.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputCategoryColumn, "ucrInputCategoryColumn")
        Me.ucrInputCategoryColumn.Name = "ucrInputCategoryColumn"
        '
        'lblCategoryColumn
        '
        resources.ApplyResources(Me.lblCategoryColumn, "lblCategoryColumn")
        Me.lblCategoryColumn.Name = "lblCategoryColumn"
        '
        'ucrInputDiffName
        '
        Me.ucrInputDiffName.AddQuotesIfUnrecognised = True
        Me.ucrInputDiffName.IsMultiline = False
        Me.ucrInputDiffName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputDiffName, "ucrInputDiffName")
        Me.ucrInputDiffName.Name = "ucrInputDiffName"
        '
        'lblDiffName
        '
        resources.ApplyResources(Me.lblDiffName, "lblDiffName")
        Me.lblDiffName.Name = "lblDiffName"
        '
        'ucrInputLabels
        '
        Me.ucrInputLabels.AddQuotesIfUnrecognised = True
        Me.ucrInputLabels.IsMultiline = False
        Me.ucrInputLabels.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLabels, "ucrInputLabels")
        Me.ucrInputLabels.Name = "ucrInputLabels"
        '
        'lblLabels
        '
        resources.ApplyResources(Me.lblLabels, "lblLabels")
        Me.lblLabels.Name = "lblLabels"
        '
        'ucrInputBreakPoints
        '
        Me.ucrInputBreakPoints.AddQuotesIfUnrecognised = True
        Me.ucrInputBreakPoints.IsMultiline = False
        Me.ucrInputBreakPoints.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputBreakPoints, "ucrInputBreakPoints")
        Me.ucrInputBreakPoints.Name = "ucrInputBreakPoints"
        '
        'lblBreakPoints
        '
        resources.ApplyResources(Me.lblBreakPoints, "lblBreakPoints")
        Me.lblBreakPoints.Name = "lblBreakPoints"
        '
        'ucrChkCalculateDiffCategories
        '
        Me.ucrChkCalculateDiffCategories.Checked = False
        resources.ApplyResources(Me.ucrChkCalculateDiffCategories, "ucrChkCalculateDiffCategories")
        Me.ucrChkCalculateDiffCategories.Name = "ucrChkCalculateDiffCategories"
        '
        'ucrSaveDataFrame
        '
        resources.ApplyResources(Me.ucrSaveDataFrame, "ucrSaveDataFrame")
        Me.ucrSaveDataFrame.Name = "ucrSaveDataFrame"
        '
        'dlgCalculateTreatmentDifferences
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
