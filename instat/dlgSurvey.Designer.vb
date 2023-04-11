<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgSurvey
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblFPC = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblWeights = New System.Windows.Forms.Label()
        Me.rdoStratified = New System.Windows.Forms.RadioButton()
        Me.rdoSRS = New System.Windows.Forms.RadioButton()
        Me.rdoClustered = New System.Windows.Forms.RadioButton()
        Me.lblStrata = New System.Windows.Forms.Label()
        Me.lblXFormula = New System.Windows.Forms.Label()
        Me.lblInputID = New System.Windows.Forms.Label()
        Me.lblSummaryStat = New System.Windows.Forms.Label()
        Me.ucrChkRatios = New instat.ucrCheck()
        Me.ucrChkContingencyTables = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputSummaryStat = New instat.ucrInputComboBox()
        Me.ucrChkSummary = New instat.ucrCheck()
        Me.ucrReceiverMultipleVar2 = New instat.ucrReceiverMultiple()
        Me.ucrReceiverFPC = New instat.ucrReceiverSingle()
        Me.ucrPnlMethod = New instat.UcrPanel()
        Me.ucrReceiverStrata = New instat.ucrReceiverSingle()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrSelectorSurvey = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputId = New instat.ucrInputTextBox()
        Me.ucrReceiverSingleID = New instat.ucrReceiverSingle()
        Me.lblVar1 = New System.Windows.Forms.Label()
        Me.ucrReceiverVar1 = New instat.ucrReceiverSingle()
        Me.lblFormula = New System.Windows.Forms.Label()
        Me.ucrReceiverMultipleContTable = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'lblFPC
        '
        Me.lblFPC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFPC.Location = New System.Drawing.Point(313, 50)
        Me.lblFPC.Name = "lblFPC"
        Me.lblFPC.Size = New System.Drawing.Size(80, 15)
        Me.lblFPC.TabIndex = 14
        Me.lblFPC.Text = "FPC(Numeric):"
        '
        'lblId
        '
        Me.lblId.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblId.Location = New System.Drawing.Point(313, 87)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(80, 14)
        Me.lblId.TabIndex = 16
        Me.lblId.Text = "Ids(Numeric):"
        '
        'lblWeights
        '
        Me.lblWeights.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWeights.Location = New System.Drawing.Point(313, 122)
        Me.lblWeights.Name = "lblWeights"
        Me.lblWeights.Size = New System.Drawing.Size(123, 13)
        Me.lblWeights.TabIndex = 18
        Me.lblWeights.Text = "Weights(Numeric):"
        '
        'rdoStratified
        '
        Me.rdoStratified.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoStratified.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStratified.FlatAppearance.BorderSize = 2
        Me.rdoStratified.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStratified.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoStratified.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoStratified.Location = New System.Drawing.Point(174, 12)
        Me.rdoStratified.Name = "rdoStratified"
        Me.rdoStratified.Size = New System.Drawing.Size(76, 27)
        Me.rdoStratified.TabIndex = 23
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
        Me.rdoSRS.Location = New System.Drawing.Point(110, 12)
        Me.rdoSRS.Name = "rdoSRS"
        Me.rdoSRS.Size = New System.Drawing.Size(65, 27)
        Me.rdoSRS.TabIndex = 22
        Me.rdoSRS.TabStop = True
        Me.rdoSRS.Text = "SRS"
        Me.rdoSRS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSRS.UseVisualStyleBackColor = True
        '
        'rdoClustered
        '
        Me.rdoClustered.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoClustered.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoClustered.FlatAppearance.BorderSize = 2
        Me.rdoClustered.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoClustered.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoClustered.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoClustered.Location = New System.Drawing.Point(249, 12)
        Me.rdoClustered.Name = "rdoClustered"
        Me.rdoClustered.Size = New System.Drawing.Size(76, 27)
        Me.rdoClustered.TabIndex = 24
        Me.rdoClustered.TabStop = True
        Me.rdoClustered.Text = "Clustered"
        Me.rdoClustered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoClustered.UseVisualStyleBackColor = True
        '
        'lblStrata
        '
        Me.lblStrata.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStrata.Location = New System.Drawing.Point(313, 164)
        Me.lblStrata.Name = "lblStrata"
        Me.lblStrata.Size = New System.Drawing.Size(123, 13)
        Me.lblStrata.TabIndex = 25
        Me.lblStrata.Text = "Strata(Factor):"
        '
        'lblXFormula
        '
        Me.lblXFormula.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXFormula.Location = New System.Drawing.Point(313, 203)
        Me.lblXFormula.Name = "lblXFormula"
        Me.lblXFormula.Size = New System.Drawing.Size(59, 13)
        Me.lblXFormula.TabIndex = 27
        Me.lblXFormula.Text = "X/Formula:"
        '
        'lblInputID
        '
        Me.lblInputID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInputID.Location = New System.Drawing.Point(313, 87)
        Me.lblInputID.Name = "lblInputID"
        Me.lblInputID.Size = New System.Drawing.Size(80, 14)
        Me.lblInputID.TabIndex = 28
        Me.lblInputID.Text = "Ids(Numeric):"
        '
        'lblSummaryStat
        '
        Me.lblSummaryStat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummaryStat.Location = New System.Drawing.Point(4, 283)
        Me.lblSummaryStat.Name = "lblSummaryStat"
        Me.lblSummaryStat.Size = New System.Drawing.Size(121, 20)
        Me.lblSummaryStat.TabIndex = 32
        Me.lblSummaryStat.Text = "Summary Statistic:"
        '
        'ucrChkRatios
        '
        Me.ucrChkRatios.AutoSize = True
        Me.ucrChkRatios.Checked = False
        Me.ucrChkRatios.Location = New System.Drawing.Point(7, 330)
        Me.ucrChkRatios.Name = "ucrChkRatios"
        Me.ucrChkRatios.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkRatios.TabIndex = 36
        '
        'ucrChkContingencyTables
        '
        Me.ucrChkContingencyTables.AutoSize = True
        Me.ucrChkContingencyTables.Checked = False
        Me.ucrChkContingencyTables.Location = New System.Drawing.Point(7, 359)
        Me.ucrChkContingencyTables.Name = "ucrChkContingencyTables"
        Me.ucrChkContingencyTables.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkContingencyTables.TabIndex = 35
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(26, 396)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 34
        '
        'ucrInputSummaryStat
        '
        Me.ucrInputSummaryStat.AddQuotesIfUnrecognised = True
        Me.ucrInputSummaryStat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSummaryStat.GetSetSelectedIndex = -1
        Me.ucrInputSummaryStat.IsReadOnly = False
        Me.ucrInputSummaryStat.Location = New System.Drawing.Point(7, 303)
        Me.ucrInputSummaryStat.Name = "ucrInputSummaryStat"
        Me.ucrInputSummaryStat.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSummaryStat.TabIndex = 31
        '
        'ucrChkSummary
        '
        Me.ucrChkSummary.AutoSize = True
        Me.ucrChkSummary.Checked = False
        Me.ucrChkSummary.Location = New System.Drawing.Point(7, 259)
        Me.ucrChkSummary.Name = "ucrChkSummary"
        Me.ucrChkSummary.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkSummary.TabIndex = 30
        '
        'ucrReceiverMultipleVar2
        '
        Me.ucrReceiverMultipleVar2.AutoSize = True
        Me.ucrReceiverMultipleVar2.frmParent = Me
        Me.ucrReceiverMultipleVar2.Location = New System.Drawing.Point(316, 216)
        Me.ucrReceiverMultipleVar2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleVar2.Name = "ucrReceiverMultipleVar2"
        Me.ucrReceiverMultipleVar2.Selector = Nothing
        Me.ucrReceiverMultipleVar2.Size = New System.Drawing.Size(123, 50)
        Me.ucrReceiverMultipleVar2.strNcFilePath = ""
        Me.ucrReceiverMultipleVar2.TabIndex = 26
        Me.ucrReceiverMultipleVar2.ucrSelector = Nothing
        '
        'ucrReceiverFPC
        '
        Me.ucrReceiverFPC.AutoSize = True
        Me.ucrReceiverFPC.frmParent = Me
        Me.ucrReceiverFPC.Location = New System.Drawing.Point(316, 65)
        Me.ucrReceiverFPC.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFPC.Name = "ucrReceiverFPC"
        Me.ucrReceiverFPC.Selector = Nothing
        Me.ucrReceiverFPC.Size = New System.Drawing.Size(123, 20)
        Me.ucrReceiverFPC.strNcFilePath = ""
        Me.ucrReceiverFPC.TabIndex = 15
        Me.ucrReceiverFPC.ucrSelector = Nothing
        '
        'ucrPnlMethod
        '
        Me.ucrPnlMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMethod.Location = New System.Drawing.Point(104, 12)
        Me.ucrPnlMethod.Name = "ucrPnlMethod"
        Me.ucrPnlMethod.Size = New System.Drawing.Size(310, 37)
        Me.ucrPnlMethod.TabIndex = 12
        '
        'ucrReceiverStrata
        '
        Me.ucrReceiverStrata.AutoSize = True
        Me.ucrReceiverStrata.frmParent = Me
        Me.ucrReceiverStrata.Location = New System.Drawing.Point(316, 177)
        Me.ucrReceiverStrata.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStrata.Name = "ucrReceiverStrata"
        Me.ucrReceiverStrata.Selector = Nothing
        Me.ucrReceiverStrata.Size = New System.Drawing.Size(123, 20)
        Me.ucrReceiverStrata.strNcFilePath = ""
        Me.ucrReceiverStrata.TabIndex = 21
        Me.ucrReceiverStrata.ucrSelector = Nothing
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.AutoSize = True
        Me.ucrReceiverWeights.frmParent = Me
        Me.ucrReceiverWeights.Location = New System.Drawing.Point(316, 135)
        Me.ucrReceiverWeights.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.Size = New System.Drawing.Size(123, 20)
        Me.ucrReceiverWeights.strNcFilePath = ""
        Me.ucrReceiverWeights.TabIndex = 19
        Me.ucrReceiverWeights.ucrSelector = Nothing
        '
        'ucrSelectorSurvey
        '
        Me.ucrSelectorSurvey.AutoSize = True
        Me.ucrSelectorSurvey.bDropUnusedFilterLevels = False
        Me.ucrSelectorSurvey.bShowHiddenColumns = False
        Me.ucrSelectorSurvey.bUseCurrentFilter = True
        Me.ucrSelectorSurvey.Location = New System.Drawing.Point(7, 52)
        Me.ucrSelectorSurvey.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSurvey.Name = "ucrSelectorSurvey"
        Me.ucrSelectorSurvey.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorSurvey.TabIndex = 13
        '
        'ucrInputId
        '
        Me.ucrInputId.AddQuotesIfUnrecognised = True
        Me.ucrInputId.AutoSize = True
        Me.ucrInputId.IsMultiline = False
        Me.ucrInputId.IsReadOnly = False
        Me.ucrInputId.Location = New System.Drawing.Point(316, 101)
        Me.ucrInputId.Name = "ucrInputId"
        Me.ucrInputId.Size = New System.Drawing.Size(123, 21)
        Me.ucrInputId.TabIndex = 29
        '
        'ucrReceiverSingleID
        '
        Me.ucrReceiverSingleID.AutoSize = True
        Me.ucrReceiverSingleID.frmParent = Me
        Me.ucrReceiverSingleID.Location = New System.Drawing.Point(316, 101)
        Me.ucrReceiverSingleID.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingleID.Name = "ucrReceiverSingleID"
        Me.ucrReceiverSingleID.Selector = Nothing
        Me.ucrReceiverSingleID.Size = New System.Drawing.Size(123, 20)
        Me.ucrReceiverSingleID.strNcFilePath = ""
        Me.ucrReceiverSingleID.TabIndex = 17
        Me.ucrReceiverSingleID.ucrSelector = Nothing
        '
        'lblVar1
        '
        Me.lblVar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVar1.Location = New System.Drawing.Point(313, 270)
        Me.lblVar1.Name = "lblVar1"
        Me.lblVar1.Size = New System.Drawing.Size(123, 13)
        Me.lblVar1.TabIndex = 38
        Me.lblVar1.Text = "Var1:"
        '
        'ucrReceiverVar1
        '
        Me.ucrReceiverVar1.AutoSize = True
        Me.ucrReceiverVar1.frmParent = Me
        Me.ucrReceiverVar1.Location = New System.Drawing.Point(316, 283)
        Me.ucrReceiverVar1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVar1.Name = "ucrReceiverVar1"
        Me.ucrReceiverVar1.Selector = Nothing
        Me.ucrReceiverVar1.Size = New System.Drawing.Size(123, 20)
        Me.ucrReceiverVar1.strNcFilePath = ""
        Me.ucrReceiverVar1.TabIndex = 37
        Me.ucrReceiverVar1.ucrSelector = Nothing
        '
        'lblFormula
        '
        Me.lblFormula.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFormula.Location = New System.Drawing.Point(313, 308)
        Me.lblFormula.Name = "lblFormula"
        Me.lblFormula.Size = New System.Drawing.Size(91, 16)
        Me.lblFormula.TabIndex = 40
        Me.lblFormula.Text = "Formula(Factor):"
        '
        'ucrReceiverMultipleContTable
        '
        Me.ucrReceiverMultipleContTable.AutoSize = True
        Me.ucrReceiverMultipleContTable.frmParent = Me
        Me.ucrReceiverMultipleContTable.Location = New System.Drawing.Point(316, 324)
        Me.ucrReceiverMultipleContTable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleContTable.Name = "ucrReceiverMultipleContTable"
        Me.ucrReceiverMultipleContTable.Selector = Nothing
        Me.ucrReceiverMultipleContTable.Size = New System.Drawing.Size(123, 50)
        Me.ucrReceiverMultipleContTable.strNcFilePath = ""
        Me.ucrReceiverMultipleContTable.TabIndex = 39
        Me.ucrReceiverMultipleContTable.ucrSelector = Nothing
        '
        'dlgSurvey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 465)
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

    Friend WithEvents lblFPC As Label
    Friend WithEvents ucrReceiverFPC As ucrReceiverSingle
    Friend WithEvents ucrPnlMethod As UcrPanel
    Friend WithEvents ucrReceiverStrata As ucrReceiverSingle
    Friend WithEvents lblId As Label
    Friend WithEvents ucrReceiverSingleID As ucrReceiverSingle
    Friend WithEvents lblWeights As Label
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents ucrSelectorSurvey As ucrSelectorByDataFrameAddRemove
    Friend WithEvents rdoStratified As RadioButton
    Friend WithEvents rdoSRS As RadioButton
    Friend WithEvents rdoClustered As RadioButton
    Friend WithEvents lblStrata As Label
    Friend WithEvents lblXFormula As Label
    Friend WithEvents ucrReceiverMultipleVar2 As ucrReceiverMultiple
    Friend WithEvents lblInputID As Label
    Friend WithEvents ucrInputId As ucrInputTextBox
    Friend WithEvents ucrChkSummary As ucrCheck
    Friend WithEvents lblSummaryStat As Label
    Friend WithEvents ucrInputSummaryStat As ucrInputComboBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkRatios As ucrCheck
    Friend WithEvents ucrChkContingencyTables As ucrCheck
    Friend WithEvents lblVar1 As Label
    Friend WithEvents ucrReceiverVar1 As ucrReceiverSingle
    Friend WithEvents lblFormula As Label
    Friend WithEvents ucrReceiverMultipleContTable As ucrReceiverMultiple
End Class
