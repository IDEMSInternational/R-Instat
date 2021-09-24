<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCompareTreatmentLines
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgCompareTreatmentLines))
        Me.lblMeasurement = New System.Windows.Forms.Label()
        Me.lblOption = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblOption1 = New System.Windows.Forms.Label()
        Me.lblTreatment2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblContext3 = New System.Windows.Forms.Label()
        Me.ucrInputContext3 = New instat.ucrInputComboBox()
        Me.ucrReceiverContext3 = New instat.ucrReceiverSingle()
        Me.lblContext2 = New System.Windows.Forms.Label()
        Me.lblContext1 = New System.Windows.Forms.Label()
        Me.ucrInputContext2 = New instat.ucrInputComboBox()
        Me.ucrReceiverContext2 = New instat.ucrReceiverSingle()
        Me.ucrInputContext1 = New instat.ucrInputComboBox()
        Me.ucrReceiverContext1 = New instat.ucrReceiverSingle()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkIncludeMeanLine = New instat.ucrCheck()
        Me.ucrChkIncludeSmoothLine = New instat.ucrCheck()
        Me.ucrChkBoxplotOnlyComplete = New instat.ucrCheck()
        Me.ucrInputHlineValue = New instat.ucrInputTextBox()
        Me.lblHlineValue = New System.Windows.Forms.Label()
        Me.ucrChkIncludeHline = New instat.ucrCheck()
        Me.lblTransparency = New System.Windows.Forms.Label()
        Me.ucrNudTransparency = New instat.ucrNud()
        Me.ucrChkIncludeBoxplot = New instat.ucrCheck()
        Me.ucrChkColourByDifference = New instat.ucrCheck()
        Me.rdoLines = New System.Windows.Forms.RadioButton()
        Me.rdoPoints = New System.Windows.Forms.RadioButton()
        Me.ucrPnlCompareType = New instat.UcrPanel()
        Me.ucrInputFactorOption2 = New instat.ucrInputFactorLevels()
        Me.ucrInputFactorOption1 = New instat.ucrInputFactorLevels()
        Me.ucrReceiverID = New instat.ucrReceiverSingle()
        Me.ucrReceiverOption = New instat.ucrReceiverSingle()
        Me.ucrReceiverMeasurement = New instat.ucrReceiverSingle()
        Me.ucrSelectorPlot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSavePlot = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.GroupBox1.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMeasurement
        '
        resources.ApplyResources(Me.lblMeasurement, "lblMeasurement")
        Me.lblMeasurement.Name = "lblMeasurement"
        '
        'lblOption
        '
        resources.ApplyResources(Me.lblOption, "lblOption")
        Me.lblOption.Name = "lblOption"
        '
        'lblID
        '
        resources.ApplyResources(Me.lblID, "lblID")
        Me.lblID.Name = "lblID"
        '
        'lblOption1
        '
        resources.ApplyResources(Me.lblOption1, "lblOption1")
        Me.lblOption1.Name = "lblOption1"
        '
        'lblTreatment2
        '
        resources.ApplyResources(Me.lblTreatment2, "lblTreatment2")
        Me.lblTreatment2.Name = "lblTreatment2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblContext3)
        Me.GroupBox1.Controls.Add(Me.ucrInputContext3)
        Me.GroupBox1.Controls.Add(Me.ucrReceiverContext3)
        Me.GroupBox1.Controls.Add(Me.lblContext2)
        Me.GroupBox1.Controls.Add(Me.lblContext1)
        Me.GroupBox1.Controls.Add(Me.ucrInputContext2)
        Me.GroupBox1.Controls.Add(Me.ucrReceiverContext2)
        Me.GroupBox1.Controls.Add(Me.ucrInputContext1)
        Me.GroupBox1.Controls.Add(Me.ucrReceiverContext1)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'lblContext3
        '
        resources.ApplyResources(Me.lblContext3, "lblContext3")
        Me.lblContext3.Name = "lblContext3"
        '
        'ucrInputContext3
        '
        Me.ucrInputContext3.AddQuotesIfUnrecognised = True
        Me.ucrInputContext3.GetSetSelectedIndex = -1
        Me.ucrInputContext3.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputContext3, "ucrInputContext3")
        Me.ucrInputContext3.Name = "ucrInputContext3"
        '
        'ucrReceiverContext3
        '
        Me.ucrReceiverContext3.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverContext3, "ucrReceiverContext3")
        Me.ucrReceiverContext3.Name = "ucrReceiverContext3"
        Me.ucrReceiverContext3.Selector = Nothing
        Me.ucrReceiverContext3.strNcFilePath = ""
        Me.ucrReceiverContext3.ucrSelector = Nothing
        '
        'lblContext2
        '
        resources.ApplyResources(Me.lblContext2, "lblContext2")
        Me.lblContext2.Name = "lblContext2"
        '
        'lblContext1
        '
        resources.ApplyResources(Me.lblContext1, "lblContext1")
        Me.lblContext1.Name = "lblContext1"
        '
        'ucrInputContext2
        '
        Me.ucrInputContext2.AddQuotesIfUnrecognised = True
        Me.ucrInputContext2.GetSetSelectedIndex = -1
        Me.ucrInputContext2.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputContext2, "ucrInputContext2")
        Me.ucrInputContext2.Name = "ucrInputContext2"
        '
        'ucrReceiverContext2
        '
        Me.ucrReceiverContext2.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverContext2, "ucrReceiverContext2")
        Me.ucrReceiverContext2.Name = "ucrReceiverContext2"
        Me.ucrReceiverContext2.Selector = Nothing
        Me.ucrReceiverContext2.strNcFilePath = ""
        Me.ucrReceiverContext2.ucrSelector = Nothing
        '
        'ucrInputContext1
        '
        Me.ucrInputContext1.AddQuotesIfUnrecognised = True
        Me.ucrInputContext1.GetSetSelectedIndex = -1
        Me.ucrInputContext1.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputContext1, "ucrInputContext1")
        Me.ucrInputContext1.Name = "ucrInputContext1"
        '
        'ucrReceiverContext1
        '
        Me.ucrReceiverContext1.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverContext1, "ucrReceiverContext1")
        Me.ucrReceiverContext1.Name = "ucrReceiverContext1"
        Me.ucrReceiverContext1.Selector = Nothing
        Me.ucrReceiverContext1.strNcFilePath = ""
        Me.ucrReceiverContext1.ucrSelector = Nothing
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrChkIncludeMeanLine)
        Me.grpOptions.Controls.Add(Me.ucrChkIncludeSmoothLine)
        Me.grpOptions.Controls.Add(Me.ucrChkBoxplotOnlyComplete)
        Me.grpOptions.Controls.Add(Me.ucrInputHlineValue)
        Me.grpOptions.Controls.Add(Me.lblHlineValue)
        Me.grpOptions.Controls.Add(Me.ucrChkIncludeHline)
        Me.grpOptions.Controls.Add(Me.lblTransparency)
        Me.grpOptions.Controls.Add(Me.ucrNudTransparency)
        Me.grpOptions.Controls.Add(Me.ucrChkIncludeBoxplot)
        Me.grpOptions.Controls.Add(Me.ucrChkColourByDifference)
        resources.ApplyResources(Me.grpOptions, "grpOptions")
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.TabStop = False
        '
        'ucrChkIncludeMeanLine
        '
        Me.ucrChkIncludeMeanLine.Checked = False
        resources.ApplyResources(Me.ucrChkIncludeMeanLine, "ucrChkIncludeMeanLine")
        Me.ucrChkIncludeMeanLine.Name = "ucrChkIncludeMeanLine"
        '
        'ucrChkIncludeSmoothLine
        '
        Me.ucrChkIncludeSmoothLine.Checked = False
        resources.ApplyResources(Me.ucrChkIncludeSmoothLine, "ucrChkIncludeSmoothLine")
        Me.ucrChkIncludeSmoothLine.Name = "ucrChkIncludeSmoothLine"
        '
        'ucrChkBoxplotOnlyComplete
        '
        Me.ucrChkBoxplotOnlyComplete.Checked = False
        resources.ApplyResources(Me.ucrChkBoxplotOnlyComplete, "ucrChkBoxplotOnlyComplete")
        Me.ucrChkBoxplotOnlyComplete.Name = "ucrChkBoxplotOnlyComplete"
        '
        'ucrInputHlineValue
        '
        Me.ucrInputHlineValue.AddQuotesIfUnrecognised = True
        Me.ucrInputHlineValue.IsMultiline = False
        Me.ucrInputHlineValue.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputHlineValue, "ucrInputHlineValue")
        Me.ucrInputHlineValue.Name = "ucrInputHlineValue"
        '
        'lblHlineValue
        '
        resources.ApplyResources(Me.lblHlineValue, "lblHlineValue")
        Me.lblHlineValue.Name = "lblHlineValue"
        '
        'ucrChkIncludeHline
        '
        Me.ucrChkIncludeHline.Checked = False
        resources.ApplyResources(Me.ucrChkIncludeHline, "ucrChkIncludeHline")
        Me.ucrChkIncludeHline.Name = "ucrChkIncludeHline"
        '
        'lblTransparency
        '
        resources.ApplyResources(Me.lblTransparency, "lblTransparency")
        Me.lblTransparency.Name = "lblTransparency"
        '
        'ucrNudTransparency
        '
        Me.ucrNudTransparency.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTransparency.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudTransparency, "ucrNudTransparency")
        Me.ucrNudTransparency.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTransparency.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTransparency.Name = "ucrNudTransparency"
        Me.ucrNudTransparency.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkIncludeBoxplot
        '
        Me.ucrChkIncludeBoxplot.Checked = False
        resources.ApplyResources(Me.ucrChkIncludeBoxplot, "ucrChkIncludeBoxplot")
        Me.ucrChkIncludeBoxplot.Name = "ucrChkIncludeBoxplot"
        '
        'ucrChkColourByDifference
        '
        Me.ucrChkColourByDifference.Checked = False
        resources.ApplyResources(Me.ucrChkColourByDifference, "ucrChkColourByDifference")
        Me.ucrChkColourByDifference.Name = "ucrChkColourByDifference"
        '
        'rdoLines
        '
        resources.ApplyResources(Me.rdoLines, "rdoLines")
        Me.rdoLines.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLines.FlatAppearance.BorderSize = 2
        Me.rdoLines.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLines.Name = "rdoLines"
        Me.rdoLines.UseVisualStyleBackColor = True
        '
        'rdoPoints
        '
        resources.ApplyResources(Me.rdoPoints, "rdoPoints")
        Me.rdoPoints.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPoints.FlatAppearance.BorderSize = 2
        Me.rdoPoints.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPoints.Name = "rdoPoints"
        Me.rdoPoints.UseVisualStyleBackColor = True
        '
        'ucrPnlCompareType
        '
        resources.ApplyResources(Me.ucrPnlCompareType, "ucrPnlCompareType")
        Me.ucrPnlCompareType.Name = "ucrPnlCompareType"
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
        'ucrReceiverOption
        '
        Me.ucrReceiverOption.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverOption, "ucrReceiverOption")
        Me.ucrReceiverOption.Name = "ucrReceiverOption"
        Me.ucrReceiverOption.Selector = Nothing
        Me.ucrReceiverOption.strNcFilePath = ""
        Me.ucrReceiverOption.ucrSelector = Nothing
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
        'ucrSelectorPlot
        '
        Me.ucrSelectorPlot.bDropUnusedFilterLevels = False
        Me.ucrSelectorPlot.bShowHiddenColumns = False
        Me.ucrSelectorPlot.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorPlot, "ucrSelectorPlot")
        Me.ucrSelectorPlot.Name = "ucrSelectorPlot"
        '
        'ucrSavePlot
        '
        resources.ApplyResources(Me.ucrSavePlot, "ucrSavePlot")
        Me.ucrSavePlot.Name = "ucrSavePlot"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgCompareTreatmentLines
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rdoPoints)
        Me.Controls.Add(Me.rdoLines)
        Me.Controls.Add(Me.ucrPnlCompareType)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.GroupBox1)
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
        Me.Controls.Add(Me.ucrSelectorPlot)
        Me.Controls.Add(Me.ucrSavePlot)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCompareTreatmentLines"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSavePlot As ucrSave
    Friend WithEvents ucrSelectorPlot As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblMeasurement As Label
    Friend WithEvents ucrReceiverMeasurement As ucrReceiverSingle
    Friend WithEvents ucrReceiverOption As ucrReceiverSingle
    Friend WithEvents lblOption As Label
    Friend WithEvents ucrReceiverID As ucrReceiverSingle
    Friend WithEvents lblID As Label
    Friend WithEvents lblTreatment2 As Label
    Friend WithEvents lblOption1 As Label
    Friend WithEvents ucrInputFactorOption2 As ucrInputFactorLevels
    Friend WithEvents ucrInputFactorOption1 As ucrInputFactorLevels
    Friend WithEvents ucrChkColourByDifference As ucrCheck
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ucrInputContext2 As ucrInputComboBox
    Friend WithEvents ucrReceiverContext2 As ucrReceiverSingle
    Friend WithEvents ucrInputContext1 As ucrInputComboBox
    Friend WithEvents ucrReceiverContext1 As ucrReceiverSingle
    Friend WithEvents lblContext2 As Label
    Friend WithEvents lblContext1 As Label
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents lblTransparency As Label
    Friend WithEvents ucrNudTransparency As ucrNud
    Friend WithEvents ucrChkIncludeHline As ucrCheck
    Friend WithEvents ucrInputHlineValue As ucrInputTextBox
    Friend WithEvents lblHlineValue As Label
    Friend WithEvents ucrChkBoxplotOnlyComplete As ucrCheck
    Friend WithEvents ucrChkIncludeBoxplot As ucrCheck
    Friend WithEvents lblContext3 As Label
    Friend WithEvents ucrInputContext3 As ucrInputComboBox
    Friend WithEvents ucrReceiverContext3 As ucrReceiverSingle
    Friend WithEvents ucrPnlCompareType As UcrPanel
    Friend WithEvents ucrChkIncludeSmoothLine As ucrCheck
    Friend WithEvents ucrChkIncludeMeanLine As ucrCheck
    Friend WithEvents rdoPoints As RadioButton
    Friend WithEvents rdoLines As RadioButton
End Class
