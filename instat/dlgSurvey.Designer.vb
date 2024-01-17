<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSurvey
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblFormula = New System.Windows.Forms.Label()
        Me.ucrReceiverMultipleContTable = New instat.ucrReceiverMultiple()
        Me.lblVar1 = New System.Windows.Forms.Label()
        Me.ucrReceiverVar1 = New instat.ucrReceiverSingle()
        Me.ucrChkRatios = New instat.ucrCheck()
        Me.ucrChkContingencyTables = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblSummaryStat = New System.Windows.Forms.Label()
        Me.ucrInputSummaryStat = New instat.ucrInputComboBox()
        Me.ucrChkSummary = New instat.ucrCheck()
        Me.lblInputID = New System.Windows.Forms.Label()
        Me.lblXFormula = New System.Windows.Forms.Label()
        Me.ucrReceiverMultipleVar2 = New instat.ucrReceiverMultiple()
        Me.lblStrata = New System.Windows.Forms.Label()
        Me.rdoClustered = New System.Windows.Forms.RadioButton()
        Me.rdoStratified = New System.Windows.Forms.RadioButton()
        Me.rdoSRS = New System.Windows.Forms.RadioButton()
        Me.lblFPC = New System.Windows.Forms.Label()
        Me.ucrReceiverFPC = New instat.ucrReceiverSingle()
        Me.ucrPnlMethod = New instat.UcrPanel()
        Me.ucrReceiverStrata = New instat.ucrReceiverSingle()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblWeights = New System.Windows.Forms.Label()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrSelectorSurvey = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputId = New instat.ucrInputTextBox()
        Me.ucrReceiverSingleID = New instat.ucrReceiverSingle()
        Me.lblVar1srs = New System.Windows.Forms.Label()
        Me.ucrReceiverVar1srs = New instat.ucrReceiverSingle()
        Me.lblVar2srs = New System.Windows.Forms.Label()
        Me.ucrReceiverVar2srs = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'lblFormula
        '
        Me.lblFormula.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFormula.Location = New System.Drawing.Point(290, 310)
        Me.lblFormula.Name = "lblFormula"
        Me.lblFormula.Size = New System.Drawing.Size(91, 16)
        Me.lblFormula.TabIndex = 67
        Me.lblFormula.Text = "Formula:"
        '
        'ucrReceiverMultipleContTable
        '
        Me.ucrReceiverMultipleContTable.AutoSize = True
        Me.ucrReceiverMultipleContTable.frmParent = Me
        Me.ucrReceiverMultipleContTable.Location = New System.Drawing.Point(293, 326)
        Me.ucrReceiverMultipleContTable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleContTable.Name = "ucrReceiverMultipleContTable"
        Me.ucrReceiverMultipleContTable.Selector = Nothing
        Me.ucrReceiverMultipleContTable.Size = New System.Drawing.Size(123, 50)
        Me.ucrReceiverMultipleContTable.strNcFilePath = ""
        Me.ucrReceiverMultipleContTable.TabIndex = 66
        Me.ucrReceiverMultipleContTable.ucrSelector = Nothing
        '
        'lblVar1
        '
        Me.lblVar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVar1.Location = New System.Drawing.Point(290, 272)
        Me.lblVar1.Name = "lblVar1"
        Me.lblVar1.Size = New System.Drawing.Size(123, 13)
        Me.lblVar1.TabIndex = 65
        Me.lblVar1.Text = "Var1:"
        '
        'ucrReceiverVar1
        '
        Me.ucrReceiverVar1.AutoSize = True
        Me.ucrReceiverVar1.frmParent = Me
        Me.ucrReceiverVar1.Location = New System.Drawing.Point(293, 285)
        Me.ucrReceiverVar1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVar1.Name = "ucrReceiverVar1"
        Me.ucrReceiverVar1.Selector = Nothing
        Me.ucrReceiverVar1.Size = New System.Drawing.Size(123, 20)
        Me.ucrReceiverVar1.strNcFilePath = ""
        Me.ucrReceiverVar1.TabIndex = 64
        Me.ucrReceiverVar1.ucrSelector = Nothing
        '
        'ucrChkRatios
        '
        Me.ucrChkRatios.AutoSize = True
        Me.ucrChkRatios.Checked = False
        Me.ucrChkRatios.Location = New System.Drawing.Point(14, 332)
        Me.ucrChkRatios.Name = "ucrChkRatios"
        Me.ucrChkRatios.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkRatios.TabIndex = 63
        '
        'ucrChkContingencyTables
        '
        Me.ucrChkContingencyTables.AutoSize = True
        Me.ucrChkContingencyTables.Checked = False
        Me.ucrChkContingencyTables.Location = New System.Drawing.Point(14, 361)
        Me.ucrChkContingencyTables.Name = "ucrChkContingencyTables"
        Me.ucrChkContingencyTables.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkContingencyTables.TabIndex = 62
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(14, 401)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 61
        '
        'lblSummaryStat
        '
        Me.lblSummaryStat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummaryStat.Location = New System.Drawing.Point(11, 285)
        Me.lblSummaryStat.Name = "lblSummaryStat"
        Me.lblSummaryStat.Size = New System.Drawing.Size(121, 20)
        Me.lblSummaryStat.TabIndex = 60
        Me.lblSummaryStat.Text = "Summary Statistic:"
        '
        'ucrInputSummaryStat
        '
        Me.ucrInputSummaryStat.AddQuotesIfUnrecognised = True
        Me.ucrInputSummaryStat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSummaryStat.GetSetSelectedIndex = -1
        Me.ucrInputSummaryStat.IsReadOnly = False
        Me.ucrInputSummaryStat.Location = New System.Drawing.Point(14, 305)
        Me.ucrInputSummaryStat.Name = "ucrInputSummaryStat"
        Me.ucrInputSummaryStat.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSummaryStat.TabIndex = 59
        '
        'ucrChkSummary
        '
        Me.ucrChkSummary.AutoSize = True
        Me.ucrChkSummary.Checked = False
        Me.ucrChkSummary.Location = New System.Drawing.Point(14, 261)
        Me.ucrChkSummary.Name = "ucrChkSummary"
        Me.ucrChkSummary.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkSummary.TabIndex = 58
        '
        'lblInputID
        '
        Me.lblInputID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInputID.Location = New System.Drawing.Point(290, 91)
        Me.lblInputID.Name = "lblInputID"
        Me.lblInputID.Size = New System.Drawing.Size(80, 14)
        Me.lblInputID.TabIndex = 56
        Me.lblInputID.Text = "Ids:"
        '
        'lblXFormula
        '
        Me.lblXFormula.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXFormula.Location = New System.Drawing.Point(290, 205)
        Me.lblXFormula.Name = "lblXFormula"
        Me.lblXFormula.Size = New System.Drawing.Size(59, 13)
        Me.lblXFormula.TabIndex = 55
        Me.lblXFormula.Text = "X/Formula:"
        '
        'ucrReceiverMultipleVar2
        '
        Me.ucrReceiverMultipleVar2.AutoSize = True
        Me.ucrReceiverMultipleVar2.frmParent = Me
        Me.ucrReceiverMultipleVar2.Location = New System.Drawing.Point(293, 218)
        Me.ucrReceiverMultipleVar2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleVar2.Name = "ucrReceiverMultipleVar2"
        Me.ucrReceiverMultipleVar2.Selector = Nothing
        Me.ucrReceiverMultipleVar2.Size = New System.Drawing.Size(123, 50)
        Me.ucrReceiverMultipleVar2.strNcFilePath = ""
        Me.ucrReceiverMultipleVar2.TabIndex = 54
        Me.ucrReceiverMultipleVar2.ucrSelector = Nothing
        '
        'lblStrata
        '
        Me.lblStrata.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStrata.Location = New System.Drawing.Point(290, 167)
        Me.lblStrata.Name = "lblStrata"
        Me.lblStrata.Size = New System.Drawing.Size(123, 13)
        Me.lblStrata.TabIndex = 53
        Me.lblStrata.Text = "Strata:"
        '
        'rdoClustered
        '
        Me.rdoClustered.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoClustered.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoClustered.FlatAppearance.BorderSize = 2
        Me.rdoClustered.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoClustered.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoClustered.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoClustered.Location = New System.Drawing.Point(256, 14)
        Me.rdoClustered.Name = "rdoClustered"
        Me.rdoClustered.Size = New System.Drawing.Size(76, 27)
        Me.rdoClustered.TabIndex = 52
        Me.rdoClustered.TabStop = True
        Me.rdoClustered.Text = "Clustered"
        Me.rdoClustered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoClustered.UseVisualStyleBackColor = True
        '
        'rdoStratified
        '
        Me.rdoStratified.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoStratified.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStratified.FlatAppearance.BorderSize = 2
        Me.rdoStratified.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStratified.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoStratified.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoStratified.Location = New System.Drawing.Point(181, 14)
        Me.rdoStratified.Name = "rdoStratified"
        Me.rdoStratified.Size = New System.Drawing.Size(76, 27)
        Me.rdoStratified.TabIndex = 51
        Me.rdoStratified.TabStop = True
        Me.rdoStratified.Text = "Stratified"
        Me.rdoStratified.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoStratified.UseVisualStyleBackColor = True
        '
        'rdoSRS
        '
        Me.rdoSRS.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSRS.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSRS.FlatAppearance.BorderSize = 2
        Me.rdoSRS.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSRS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSRS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSRS.Location = New System.Drawing.Point(117, 14)
        Me.rdoSRS.Name = "rdoSRS"
        Me.rdoSRS.Size = New System.Drawing.Size(65, 27)
        Me.rdoSRS.TabIndex = 50
        Me.rdoSRS.TabStop = True
        Me.rdoSRS.Text = "SRS"
        Me.rdoSRS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSRS.UseVisualStyleBackColor = True
        '
        'lblFPC
        '
        Me.lblFPC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFPC.Location = New System.Drawing.Point(290, 52)
        Me.lblFPC.Name = "lblFPC"
        Me.lblFPC.Size = New System.Drawing.Size(80, 15)
        Me.lblFPC.TabIndex = 43
        Me.lblFPC.Text = "FPC:"
        '
        'ucrReceiverFPC
        '
        Me.ucrReceiverFPC.AutoSize = True
        Me.ucrReceiverFPC.frmParent = Me
        Me.ucrReceiverFPC.Location = New System.Drawing.Point(293, 67)
        Me.ucrReceiverFPC.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFPC.Name = "ucrReceiverFPC"
        Me.ucrReceiverFPC.Selector = Nothing
        Me.ucrReceiverFPC.Size = New System.Drawing.Size(123, 20)
        Me.ucrReceiverFPC.strNcFilePath = ""
        Me.ucrReceiverFPC.TabIndex = 44
        Me.ucrReceiverFPC.ucrSelector = Nothing
        '
        'ucrPnlMethod
        '
        Me.ucrPnlMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMethod.Location = New System.Drawing.Point(111, 14)
        Me.ucrPnlMethod.Name = "ucrPnlMethod"
        Me.ucrPnlMethod.Size = New System.Drawing.Size(310, 37)
        Me.ucrPnlMethod.TabIndex = 41
        '
        'ucrReceiverStrata
        '
        Me.ucrReceiverStrata.AutoSize = True
        Me.ucrReceiverStrata.frmParent = Me
        Me.ucrReceiverStrata.Location = New System.Drawing.Point(293, 181)
        Me.ucrReceiverStrata.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStrata.Name = "ucrReceiverStrata"
        Me.ucrReceiverStrata.Selector = Nothing
        Me.ucrReceiverStrata.Size = New System.Drawing.Size(123, 20)
        Me.ucrReceiverStrata.strNcFilePath = ""
        Me.ucrReceiverStrata.TabIndex = 49
        Me.ucrReceiverStrata.ucrSelector = Nothing
        '
        'lblId
        '
        Me.lblId.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblId.Location = New System.Drawing.Point(297, 89)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(80, 14)
        Me.lblId.TabIndex = 45
        Me.lblId.Text = "Ids:"
        '
        'lblWeights
        '
        Me.lblWeights.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWeights.Location = New System.Drawing.Point(290, 130)
        Me.lblWeights.Name = "lblWeights"
        Me.lblWeights.Size = New System.Drawing.Size(123, 13)
        Me.lblWeights.TabIndex = 47
        Me.lblWeights.Text = "Weights:"
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.AutoSize = True
        Me.ucrReceiverWeights.frmParent = Me
        Me.ucrReceiverWeights.Location = New System.Drawing.Point(293, 144)
        Me.ucrReceiverWeights.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.Size = New System.Drawing.Size(123, 20)
        Me.ucrReceiverWeights.strNcFilePath = ""
        Me.ucrReceiverWeights.TabIndex = 48
        Me.ucrReceiverWeights.ucrSelector = Nothing
        '
        'ucrSelectorSurvey
        '
        Me.ucrSelectorSurvey.AutoSize = True
        Me.ucrSelectorSurvey.bDropUnusedFilterLevels = False
        Me.ucrSelectorSurvey.bShowHiddenColumns = False
        Me.ucrSelectorSurvey.bUseCurrentFilter = True
        Me.ucrSelectorSurvey.Location = New System.Drawing.Point(14, 54)
        Me.ucrSelectorSurvey.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSurvey.Name = "ucrSelectorSurvey"
        Me.ucrSelectorSurvey.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorSurvey.TabIndex = 42
        '
        'ucrInputId
        '
        Me.ucrInputId.AddQuotesIfUnrecognised = True
        Me.ucrInputId.AutoSize = True
        Me.ucrInputId.IsMultiline = False
        Me.ucrInputId.IsReadOnly = False
        Me.ucrInputId.Location = New System.Drawing.Point(292, 105)
        Me.ucrInputId.Name = "ucrInputId"
        Me.ucrInputId.Size = New System.Drawing.Size(123, 21)
        Me.ucrInputId.TabIndex = 57
        '
        'ucrReceiverSingleID
        '
        Me.ucrReceiverSingleID.AutoSize = True
        Me.ucrReceiverSingleID.frmParent = Me
        Me.ucrReceiverSingleID.Location = New System.Drawing.Point(292, 105)
        Me.ucrReceiverSingleID.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingleID.Name = "ucrReceiverSingleID"
        Me.ucrReceiverSingleID.Selector = Nothing
        Me.ucrReceiverSingleID.Size = New System.Drawing.Size(123, 20)
        Me.ucrReceiverSingleID.strNcFilePath = ""
        Me.ucrReceiverSingleID.TabIndex = 46
        Me.ucrReceiverSingleID.ucrSelector = Nothing
        '
        'lblVar1srs
        '
        Me.lblVar1srs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVar1srs.Location = New System.Drawing.Point(423, 131)
        Me.lblVar1srs.Name = "lblVar1srs"
        Me.lblVar1srs.Size = New System.Drawing.Size(123, 13)
        Me.lblVar1srs.TabIndex = 69
        Me.lblVar1srs.Text = "Var1:"
        '
        'ucrReceiverVar1srs
        '
        Me.ucrReceiverVar1srs.AutoSize = True
        Me.ucrReceiverVar1srs.frmParent = Me
        Me.ucrReceiverVar1srs.Location = New System.Drawing.Point(426, 144)
        Me.ucrReceiverVar1srs.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVar1srs.Name = "ucrReceiverVar1srs"
        Me.ucrReceiverVar1srs.Selector = Nothing
        Me.ucrReceiverVar1srs.Size = New System.Drawing.Size(123, 20)
        Me.ucrReceiverVar1srs.strNcFilePath = ""
        Me.ucrReceiverVar1srs.TabIndex = 68
        Me.ucrReceiverVar1srs.ucrSelector = Nothing
        '
        'lblVar2srs
        '
        Me.lblVar2srs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVar2srs.Location = New System.Drawing.Point(423, 168)
        Me.lblVar2srs.Name = "lblVar2srs"
        Me.lblVar2srs.Size = New System.Drawing.Size(123, 13)
        Me.lblVar2srs.TabIndex = 71
        Me.lblVar2srs.Text = "Var2:"
        '
        'ucrReceiverVar2srs
        '
        Me.ucrReceiverVar2srs.AutoSize = True
        Me.ucrReceiverVar2srs.frmParent = Me
        Me.ucrReceiverVar2srs.Location = New System.Drawing.Point(426, 181)
        Me.ucrReceiverVar2srs.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVar2srs.Name = "ucrReceiverVar2srs"
        Me.ucrReceiverVar2srs.Selector = Nothing
        Me.ucrReceiverVar2srs.Size = New System.Drawing.Size(123, 20)
        Me.ucrReceiverVar2srs.strNcFilePath = ""
        Me.ucrReceiverVar2srs.TabIndex = 70
        Me.ucrReceiverVar2srs.ucrSelector = Nothing
        '
        'dlgSurvey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 465)
        Me.Controls.Add(Me.lblVar2srs)
        Me.Controls.Add(Me.ucrReceiverVar2srs)
        Me.Controls.Add(Me.lblVar1srs)
        Me.Controls.Add(Me.ucrReceiverVar1srs)
        Me.Controls.Add(Me.lblFormula)
        Me.Controls.Add(Me.ucrReceiverMultipleContTable)
        Me.Controls.Add(Me.lblVar1)
        Me.Controls.Add(Me.ucrReceiverVar1)
        Me.Controls.Add(Me.ucrChkRatios)
        Me.Controls.Add(Me.ucrChkContingencyTables)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblSummaryStat)
        Me.Controls.Add(Me.ucrInputSummaryStat)
        Me.Controls.Add(Me.ucrChkSummary)
        Me.Controls.Add(Me.lblInputID)
        Me.Controls.Add(Me.lblXFormula)
        Me.Controls.Add(Me.ucrReceiverMultipleVar2)
        Me.Controls.Add(Me.lblStrata)
        Me.Controls.Add(Me.rdoClustered)
        Me.Controls.Add(Me.rdoStratified)
        Me.Controls.Add(Me.rdoSRS)
        Me.Controls.Add(Me.lblFPC)
        Me.Controls.Add(Me.ucrReceiverFPC)
        Me.Controls.Add(Me.ucrPnlMethod)
        Me.Controls.Add(Me.ucrReceiverStrata)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblWeights)
        Me.Controls.Add(Me.ucrReceiverWeights)
        Me.Controls.Add(Me.ucrSelectorSurvey)
        Me.Controls.Add(Me.ucrInputId)
        Me.Controls.Add(Me.ucrReceiverSingleID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSurvey"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Survey"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormula As Label
    Friend WithEvents ucrReceiverMultipleContTable As ucrReceiverMultiple
    Friend WithEvents lblVar1 As Label
    Friend WithEvents ucrReceiverVar1 As ucrReceiverSingle
    Friend WithEvents ucrChkRatios As ucrCheck
    Friend WithEvents ucrChkContingencyTables As ucrCheck
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblSummaryStat As Label
    Friend WithEvents ucrInputSummaryStat As ucrInputComboBox
    Friend WithEvents ucrChkSummary As ucrCheck
    Friend WithEvents lblInputID As Label
    Friend WithEvents lblXFormula As Label
    Friend WithEvents ucrReceiverMultipleVar2 As ucrReceiverMultiple
    Friend WithEvents lblStrata As Label
    Friend WithEvents rdoClustered As RadioButton
    Friend WithEvents rdoStratified As RadioButton
    Friend WithEvents rdoSRS As RadioButton
    Friend WithEvents lblFPC As Label
    Friend WithEvents ucrReceiverFPC As ucrReceiverSingle
    Friend WithEvents ucrPnlMethod As UcrPanel
    Friend WithEvents ucrReceiverStrata As ucrReceiverSingle
    Friend WithEvents lblId As Label
    Friend WithEvents lblWeights As Label
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents ucrSelectorSurvey As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputId As ucrInputTextBox
    Friend WithEvents ucrReceiverSingleID As ucrReceiverSingle
    Friend WithEvents lblVar2srs As Label
    Friend WithEvents ucrReceiverVar2srs As ucrReceiverSingle
    Friend WithEvents lblVar1srs As Label
    Friend WithEvents ucrReceiverVar1srs As ucrReceiverSingle
End Class
