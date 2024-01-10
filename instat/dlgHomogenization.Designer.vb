<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgHomogenization
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
        Me.components = New System.ComponentModel.Container()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.grpMethods = New System.Windows.Forms.GroupBox()
        Me.rdoCptMean = New System.Windows.Forms.RadioButton()
        Me.rdoCptMeanVariance = New System.Windows.Forms.RadioButton()
        Me.rdoCptVariance = New System.Windows.Forms.RadioButton()
        Me.rdoBuishand = New System.Windows.Forms.RadioButton()
        Me.rdoPettitt = New System.Windows.Forms.RadioButton()
        Me.rdoSnht = New System.Windows.Forms.RadioButton()
        Me.ucrPnlMethods = New instat.UcrPanel()
        Me.grpCptOptions = New System.Windows.Forms.GroupBox()
        Me.ucrInputComboMeanVarDistribution = New instat.ucrInputComboBox()
        Me.ucrInputComboVarDistribution = New instat.ucrInputComboBox()
        Me.lblPenaltyValue = New System.Windows.Forms.Label()
        Me.ucrInputPenValue = New instat.ucrInputTextBox()
        Me.lblMinSegLen = New System.Windows.Forms.Label()
        Me.lblQ = New System.Windows.Forms.Label()
        Me.lblPenalty = New System.Windows.Forms.Label()
        Me.lblMethod = New System.Windows.Forms.Label()
        Me.lblDistribution = New System.Windows.Forms.Label()
        Me.ucrNudMinSegLen = New instat.ucrNud()
        Me.ucrInputQ = New instat.ucrInputTextBox()
        Me.ucrInputComboMeanDistribution = New instat.ucrInputComboBox()
        Me.ucrInputComboMethod = New instat.ucrInputComboBox()
        Me.ucrInputComboPenalty = New instat.ucrInputComboBox()
        Me.grpOutputOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkPlot = New instat.ucrCheck()
        Me.ucrChkSummary = New instat.ucrCheck()
        Me.ttOptions = New System.Windows.Forms.ToolTip(Me.components)
        Me.rdoSingle = New System.Windows.Forms.RadioButton()
        Me.lblNeighbouring = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.rdoPrepare = New System.Windows.Forms.RadioButton()
        Me.grpStationFile = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverElavation = New instat.ucrReceiverSingle()
        Me.lblLongtude = New System.Windows.Forms.Label()
        Me.lblStationName = New System.Windows.Forms.Label()
        Me.lblStationID = New System.Windows.Forms.Label()
        Me.lblElavation = New System.Windows.Forms.Label()
        Me.ucrReceiverStationId = New instat.ucrReceiverSingle()
        Me.ucrReceiverStationName = New instat.ucrReceiverSingle()
        Me.ucrReceiverLongtitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.ucrSelectorStationFile = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpDataFile = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverDataFiles = New instat.ucrReceiverMultiple()
        Me.lblDataFiles = New System.Windows.Forms.Label()
        Me.ucrSelectorDataFiles = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblClimaticVariable = New System.Windows.Forms.Label()
        Me.lblFinalYear = New System.Windows.Forms.Label()
        Me.lblInitialYear = New System.Windows.Forms.Label()
        Me.ucrInputFinalYear = New instat.ucrInputTextBox()
        Me.ucrInputInitialYear = New instat.ucrInputTextBox()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSelectorHomogenization = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputClimateVariables = New instat.ucrInputTextBox()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrSaveResult = New instat.ucrSave()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverNeighbour = New instat.ucrReceiverSingle()
        Me.rdoHomogenization = New System.Windows.Forms.RadioButton()
        Me.rdoMonthlyTotals = New System.Windows.Forms.RadioButton()
        Me.rdoQualityControl = New System.Windows.Forms.RadioButton()
        Me.grpMethods.SuspendLayout()
        Me.grpCptOptions.SuspendLayout()
        Me.grpOutputOptions.SuspendLayout()
        Me.grpStationFile.SuspendLayout()
        Me.grpDataFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElement.Location = New System.Drawing.Point(264, 135)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(48, 13)
        Me.lblElement.TabIndex = 6
        Me.lblElement.Text = "Element:"
        '
        'grpMethods
        '
        Me.grpMethods.Controls.Add(Me.rdoCptMean)
        Me.grpMethods.Controls.Add(Me.rdoCptMeanVariance)
        Me.grpMethods.Controls.Add(Me.rdoCptVariance)
        Me.grpMethods.Controls.Add(Me.rdoBuishand)
        Me.grpMethods.Controls.Add(Me.rdoPettitt)
        Me.grpMethods.Controls.Add(Me.rdoSnht)
        Me.grpMethods.Controls.Add(Me.ucrPnlMethods)
        Me.grpMethods.Location = New System.Drawing.Point(12, 243)
        Me.grpMethods.Name = "grpMethods"
        Me.grpMethods.Size = New System.Drawing.Size(209, 104)
        Me.grpMethods.TabIndex = 10
        Me.grpMethods.TabStop = False
        Me.grpMethods.Text = "Methods"
        '
        'rdoCptMean
        '
        Me.rdoCptMean.AutoSize = True
        Me.rdoCptMean.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCptMean.Location = New System.Drawing.Point(87, 23)
        Me.rdoCptMean.Name = "rdoCptMean"
        Me.rdoCptMean.Size = New System.Drawing.Size(52, 17)
        Me.rdoCptMean.TabIndex = 3
        Me.rdoCptMean.Text = "Mean"
        Me.rdoCptMean.UseVisualStyleBackColor = True
        '
        'rdoCptMeanVariance
        '
        Me.rdoCptMeanVariance.AutoSize = True
        Me.rdoCptMeanVariance.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCptMeanVariance.Location = New System.Drawing.Point(87, 69)
        Me.rdoCptMeanVariance.Name = "rdoCptMeanVariance"
        Me.rdoCptMeanVariance.Size = New System.Drawing.Size(118, 17)
        Me.rdoCptMeanVariance.TabIndex = 6
        Me.rdoCptMeanVariance.Text = "Mean and Variance"
        Me.rdoCptMeanVariance.UseVisualStyleBackColor = True
        '
        'rdoCptVariance
        '
        Me.rdoCptVariance.AutoSize = True
        Me.rdoCptVariance.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCptVariance.Location = New System.Drawing.Point(87, 46)
        Me.rdoCptVariance.Name = "rdoCptVariance"
        Me.rdoCptVariance.Size = New System.Drawing.Size(67, 17)
        Me.rdoCptVariance.TabIndex = 4
        Me.rdoCptVariance.Text = "Variance"
        Me.rdoCptVariance.UseVisualStyleBackColor = True
        '
        'rdoBuishand
        '
        Me.rdoBuishand.AutoSize = True
        Me.rdoBuishand.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBuishand.Location = New System.Drawing.Point(9, 69)
        Me.rdoBuishand.Name = "rdoBuishand"
        Me.rdoBuishand.Size = New System.Drawing.Size(69, 17)
        Me.rdoBuishand.TabIndex = 5
        Me.rdoBuishand.Text = "Buishand"
        Me.rdoBuishand.UseVisualStyleBackColor = True
        '
        'rdoPettitt
        '
        Me.rdoPettitt.AutoSize = True
        Me.rdoPettitt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPettitt.Location = New System.Drawing.Point(9, 46)
        Me.rdoPettitt.Name = "rdoPettitt"
        Me.rdoPettitt.Size = New System.Drawing.Size(52, 17)
        Me.rdoPettitt.TabIndex = 2
        Me.rdoPettitt.Text = "Pettitt"
        Me.rdoPettitt.UseVisualStyleBackColor = True
        '
        'rdoSnht
        '
        Me.rdoSnht.AutoSize = True
        Me.rdoSnht.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSnht.Location = New System.Drawing.Point(9, 23)
        Me.rdoSnht.Name = "rdoSnht"
        Me.rdoSnht.Size = New System.Drawing.Size(55, 17)
        Me.rdoSnht.TabIndex = 1
        Me.rdoSnht.Text = "SNHT"
        Me.rdoSnht.UseVisualStyleBackColor = True
        '
        'ucrPnlMethods
        '
        Me.ucrPnlMethods.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMethods.Location = New System.Drawing.Point(6, 17)
        Me.ucrPnlMethods.Name = "ucrPnlMethods"
        Me.ucrPnlMethods.Size = New System.Drawing.Size(197, 68)
        Me.ucrPnlMethods.TabIndex = 0
        '
        'grpCptOptions
        '
        Me.grpCptOptions.Controls.Add(Me.ucrInputComboMeanVarDistribution)
        Me.grpCptOptions.Controls.Add(Me.ucrInputComboVarDistribution)
        Me.grpCptOptions.Controls.Add(Me.lblPenaltyValue)
        Me.grpCptOptions.Controls.Add(Me.ucrInputPenValue)
        Me.grpCptOptions.Controls.Add(Me.lblMinSegLen)
        Me.grpCptOptions.Controls.Add(Me.lblQ)
        Me.grpCptOptions.Controls.Add(Me.lblPenalty)
        Me.grpCptOptions.Controls.Add(Me.lblMethod)
        Me.grpCptOptions.Controls.Add(Me.lblDistribution)
        Me.grpCptOptions.Controls.Add(Me.ucrNudMinSegLen)
        Me.grpCptOptions.Controls.Add(Me.ucrInputQ)
        Me.grpCptOptions.Controls.Add(Me.ucrInputComboMeanDistribution)
        Me.grpCptOptions.Controls.Add(Me.ucrInputComboMethod)
        Me.grpCptOptions.Controls.Add(Me.ucrInputComboPenalty)
        Me.grpCptOptions.Location = New System.Drawing.Point(227, 243)
        Me.grpCptOptions.Name = "grpCptOptions"
        Me.grpCptOptions.Size = New System.Drawing.Size(179, 170)
        Me.grpCptOptions.TabIndex = 14
        Me.grpCptOptions.TabStop = False
        Me.grpCptOptions.Text = "Change Point Options"
        '
        'ucrInputComboMeanVarDistribution
        '
        Me.ucrInputComboMeanVarDistribution.AddQuotesIfUnrecognised = True
        Me.ucrInputComboMeanVarDistribution.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboMeanVarDistribution.GetSetSelectedIndex = -1
        Me.ucrInputComboMeanVarDistribution.IsReadOnly = False
        Me.ucrInputComboMeanVarDistribution.Location = New System.Drawing.Point(68, 67)
        Me.ucrInputComboMeanVarDistribution.Name = "ucrInputComboMeanVarDistribution"
        Me.ucrInputComboMeanVarDistribution.Size = New System.Drawing.Size(64, 21)
        Me.ucrInputComboMeanVarDistribution.TabIndex = 8
        '
        'ucrInputComboVarDistribution
        '
        Me.ucrInputComboVarDistribution.AddQuotesIfUnrecognised = True
        Me.ucrInputComboVarDistribution.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboVarDistribution.GetSetSelectedIndex = -1
        Me.ucrInputComboVarDistribution.IsReadOnly = False
        Me.ucrInputComboVarDistribution.Location = New System.Drawing.Point(68, 67)
        Me.ucrInputComboVarDistribution.Name = "ucrInputComboVarDistribution"
        Me.ucrInputComboVarDistribution.Size = New System.Drawing.Size(64, 21)
        Me.ucrInputComboVarDistribution.TabIndex = 15
        '
        'lblPenaltyValue
        '
        Me.lblPenaltyValue.AutoSize = True
        Me.lblPenaltyValue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPenaltyValue.Location = New System.Drawing.Point(4, 142)
        Me.lblPenaltyValue.Name = "lblPenaltyValue"
        Me.lblPenaltyValue.Size = New System.Drawing.Size(59, 13)
        Me.lblPenaltyValue.TabIndex = 5
        Me.lblPenaltyValue.Text = "Pen.Value:"
        '
        'ucrInputPenValue
        '
        Me.ucrInputPenValue.AddQuotesIfUnrecognised = True
        Me.ucrInputPenValue.AutoSize = True
        Me.ucrInputPenValue.IsMultiline = False
        Me.ucrInputPenValue.IsReadOnly = False
        Me.ucrInputPenValue.Location = New System.Drawing.Point(68, 138)
        Me.ucrInputPenValue.Name = "ucrInputPenValue"
        Me.ucrInputPenValue.Size = New System.Drawing.Size(55, 21)
        Me.ucrInputPenValue.TabIndex = 11
        '
        'lblMinSegLen
        '
        Me.lblMinSegLen.AutoSize = True
        Me.lblMinSegLen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMinSegLen.Location = New System.Drawing.Point(4, 95)
        Me.lblMinSegLen.Name = "lblMinSegLen"
        Me.lblMinSegLen.Size = New System.Drawing.Size(64, 13)
        Me.lblMinSegLen.TabIndex = 3
        Me.lblMinSegLen.Text = "MinSegLen:"
        '
        'lblQ
        '
        Me.lblQ.AutoSize = True
        Me.lblQ.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQ.Location = New System.Drawing.Point(4, 120)
        Me.lblQ.Name = "lblQ"
        Me.lblQ.Size = New System.Drawing.Size(18, 13)
        Me.lblQ.TabIndex = 4
        Me.lblQ.Text = "Q:"
        '
        'lblPenalty
        '
        Me.lblPenalty.AutoSize = True
        Me.lblPenalty.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPenalty.Location = New System.Drawing.Point(4, 21)
        Me.lblPenalty.Name = "lblPenalty"
        Me.lblPenalty.Size = New System.Drawing.Size(45, 13)
        Me.lblPenalty.TabIndex = 0
        Me.lblPenalty.Text = "Penalty:"
        '
        'lblMethod
        '
        Me.lblMethod.AutoSize = True
        Me.lblMethod.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMethod.Location = New System.Drawing.Point(4, 44)
        Me.lblMethod.Name = "lblMethod"
        Me.lblMethod.Size = New System.Drawing.Size(46, 13)
        Me.lblMethod.TabIndex = 1
        Me.lblMethod.Text = "Method:"
        '
        'lblDistribution
        '
        Me.lblDistribution.AutoSize = True
        Me.lblDistribution.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDistribution.Location = New System.Drawing.Point(4, 69)
        Me.lblDistribution.Name = "lblDistribution"
        Me.lblDistribution.Size = New System.Drawing.Size(62, 13)
        Me.lblDistribution.TabIndex = 2
        Me.lblDistribution.Text = "Distribution:"
        '
        'ucrNudMinSegLen
        '
        Me.ucrNudMinSegLen.AutoSize = True
        Me.ucrNudMinSegLen.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinSegLen.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinSegLen.Location = New System.Drawing.Point(68, 91)
        Me.ucrNudMinSegLen.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinSegLen.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinSegLen.Name = "ucrNudMinSegLen"
        Me.ucrNudMinSegLen.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMinSegLen.TabIndex = 9
        Me.ucrNudMinSegLen.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputQ
        '
        Me.ucrInputQ.AddQuotesIfUnrecognised = True
        Me.ucrInputQ.AutoSize = True
        Me.ucrInputQ.IsMultiline = False
        Me.ucrInputQ.IsReadOnly = False
        Me.ucrInputQ.Location = New System.Drawing.Point(68, 114)
        Me.ucrInputQ.Name = "ucrInputQ"
        Me.ucrInputQ.Size = New System.Drawing.Size(55, 21)
        Me.ucrInputQ.TabIndex = 10
        '
        'ucrInputComboMeanDistribution
        '
        Me.ucrInputComboMeanDistribution.AddQuotesIfUnrecognised = True
        Me.ucrInputComboMeanDistribution.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboMeanDistribution.GetSetSelectedIndex = -1
        Me.ucrInputComboMeanDistribution.IsReadOnly = False
        Me.ucrInputComboMeanDistribution.Location = New System.Drawing.Point(68, 67)
        Me.ucrInputComboMeanDistribution.Name = "ucrInputComboMeanDistribution"
        Me.ucrInputComboMeanDistribution.Size = New System.Drawing.Size(64, 21)
        Me.ucrInputComboMeanDistribution.TabIndex = 2
        '
        'ucrInputComboMethod
        '
        Me.ucrInputComboMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputComboMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboMethod.GetSetSelectedIndex = -1
        Me.ucrInputComboMethod.IsReadOnly = False
        Me.ucrInputComboMethod.Location = New System.Drawing.Point(68, 43)
        Me.ucrInputComboMethod.Name = "ucrInputComboMethod"
        Me.ucrInputComboMethod.Size = New System.Drawing.Size(64, 21)
        Me.ucrInputComboMethod.TabIndex = 7
        '
        'ucrInputComboPenalty
        '
        Me.ucrInputComboPenalty.AddQuotesIfUnrecognised = True
        Me.ucrInputComboPenalty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboPenalty.GetSetSelectedIndex = -1
        Me.ucrInputComboPenalty.IsReadOnly = False
        Me.ucrInputComboPenalty.Location = New System.Drawing.Point(68, 19)
        Me.ucrInputComboPenalty.Name = "ucrInputComboPenalty"
        Me.ucrInputComboPenalty.Size = New System.Drawing.Size(64, 21)
        Me.ucrInputComboPenalty.TabIndex = 6
        '
        'grpOutputOptions
        '
        Me.grpOutputOptions.Controls.Add(Me.ucrChkPlot)
        Me.grpOutputOptions.Controls.Add(Me.ucrChkSummary)
        Me.grpOutputOptions.Enabled = False
        Me.grpOutputOptions.Location = New System.Drawing.Point(12, 353)
        Me.grpOutputOptions.Name = "grpOutputOptions"
        Me.grpOutputOptions.Size = New System.Drawing.Size(209, 42)
        Me.grpOutputOptions.TabIndex = 12
        Me.grpOutputOptions.TabStop = False
        Me.grpOutputOptions.Text = "Output Options"
        '
        'ucrChkPlot
        '
        Me.ucrChkPlot.AutoSize = True
        Me.ucrChkPlot.Checked = False
        Me.ucrChkPlot.Location = New System.Drawing.Point(10, 19)
        Me.ucrChkPlot.Name = "ucrChkPlot"
        Me.ucrChkPlot.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkPlot.TabIndex = 0
        '
        'ucrChkSummary
        '
        Me.ucrChkSummary.AutoSize = True
        Me.ucrChkSummary.Checked = False
        Me.ucrChkSummary.Location = New System.Drawing.Point(110, 19)
        Me.ucrChkSummary.Name = "ucrChkSummary"
        Me.ucrChkSummary.Size = New System.Drawing.Size(93, 23)
        Me.ucrChkSummary.TabIndex = 1
        '
        'rdoSingle
        '
        Me.rdoSingle.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSingle.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSingle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingle.FlatAppearance.BorderSize = 2
        Me.rdoSingle.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSingle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSingle.Location = New System.Drawing.Point(12, 9)
        Me.rdoSingle.Name = "rdoSingle"
        Me.rdoSingle.Size = New System.Drawing.Size(78, 28)
        Me.rdoSingle.TabIndex = 1
        Me.rdoSingle.TabStop = True
        Me.rdoSingle.Tag = ""
        Me.rdoSingle.Text = "Single"
        Me.rdoSingle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSingle.UseVisualStyleBackColor = False
        '
        'lblNeighbouring
        '
        Me.lblNeighbouring.AutoSize = True
        Me.lblNeighbouring.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNeighbouring.Location = New System.Drawing.Point(264, 190)
        Me.lblNeighbouring.Name = "lblNeighbouring"
        Me.lblNeighbouring.Size = New System.Drawing.Size(59, 13)
        Me.lblNeighbouring.TabIndex = 8
        Me.lblNeighbouring.Text = "Neighbour:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStation.Location = New System.Drawing.Point(264, 80)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 4
        Me.lblStation.Text = "Station:"
        '
        'rdoPrepare
        '
        Me.rdoPrepare.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPrepare.BackColor = System.Drawing.SystemColors.Control
        Me.rdoPrepare.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPrepare.FlatAppearance.BorderSize = 2
        Me.rdoPrepare.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPrepare.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPrepare.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPrepare.Location = New System.Drawing.Point(88, 9)
        Me.rdoPrepare.Name = "rdoPrepare"
        Me.rdoPrepare.Size = New System.Drawing.Size(63, 28)
        Me.rdoPrepare.TabIndex = 2
        Me.rdoPrepare.TabStop = True
        Me.rdoPrepare.Tag = ""
        Me.rdoPrepare.Text = "Prepare"
        Me.rdoPrepare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPrepare.UseVisualStyleBackColor = False
        '
        'grpStationFile
        '
        Me.grpStationFile.Controls.Add(Me.ucrReceiverElavation)
        Me.grpStationFile.Controls.Add(Me.lblLongtude)
        Me.grpStationFile.Controls.Add(Me.lblStationName)
        Me.grpStationFile.Controls.Add(Me.lblStationID)
        Me.grpStationFile.Controls.Add(Me.lblElavation)
        Me.grpStationFile.Controls.Add(Me.ucrReceiverStationId)
        Me.grpStationFile.Controls.Add(Me.ucrReceiverStationName)
        Me.grpStationFile.Controls.Add(Me.ucrReceiverLongtitude)
        Me.grpStationFile.Controls.Add(Me.ucrReceiverLatitude)
        Me.grpStationFile.Controls.Add(Me.lblLatitude)
        Me.grpStationFile.Controls.Add(Me.ucrSelectorStationFile)
        Me.grpStationFile.Location = New System.Drawing.Point(11, 260)
        Me.grpStationFile.Name = "grpStationFile"
        Me.grpStationFile.Size = New System.Drawing.Size(397, 201)
        Me.grpStationFile.TabIndex = 11
        Me.grpStationFile.TabStop = False
        Me.grpStationFile.Text = "StationFile"
        '
        'ucrReceiverElavation
        '
        Me.ucrReceiverElavation.AutoSize = True
        Me.ucrReceiverElavation.frmParent = Me
        Me.ucrReceiverElavation.Location = New System.Drawing.Point(272, 105)
        Me.ucrReceiverElavation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElavation.Name = "ucrReceiverElavation"
        Me.ucrReceiverElavation.Selector = Nothing
        Me.ucrReceiverElavation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverElavation.strNcFilePath = ""
        Me.ucrReceiverElavation.TabIndex = 6
        Me.ucrReceiverElavation.ucrSelector = Nothing
        '
        'lblLongtude
        '
        Me.lblLongtude.AutoSize = True
        Me.lblLongtude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLongtude.Location = New System.Drawing.Point(274, 51)
        Me.lblLongtude.Name = "lblLongtude"
        Me.lblLongtude.Size = New System.Drawing.Size(57, 13)
        Me.lblLongtude.TabIndex = 3
        Me.lblLongtude.Text = "Longitude:"
        '
        'lblStationName
        '
        Me.lblStationName.AutoSize = True
        Me.lblStationName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStationName.Location = New System.Drawing.Point(274, 125)
        Me.lblStationName.Name = "lblStationName"
        Me.lblStationName.Size = New System.Drawing.Size(74, 13)
        Me.lblStationName.TabIndex = 7
        Me.lblStationName.Text = "Station Name:"
        '
        'lblStationID
        '
        Me.lblStationID.AutoSize = True
        Me.lblStationID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStationID.Location = New System.Drawing.Point(274, 161)
        Me.lblStationID.Name = "lblStationID"
        Me.lblStationID.Size = New System.Drawing.Size(55, 13)
        Me.lblStationID.TabIndex = 9
        Me.lblStationID.Text = "Station Id:"
        '
        'lblElavation
        '
        Me.lblElavation.AutoSize = True
        Me.lblElavation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElavation.Location = New System.Drawing.Point(274, 90)
        Me.lblElavation.Name = "lblElavation"
        Me.lblElavation.Size = New System.Drawing.Size(54, 13)
        Me.lblElavation.TabIndex = 5
        Me.lblElavation.Text = "Elavation:"
        '
        'ucrReceiverStationId
        '
        Me.ucrReceiverStationId.AutoSize = True
        Me.ucrReceiverStationId.frmParent = Me
        Me.ucrReceiverStationId.Location = New System.Drawing.Point(272, 175)
        Me.ucrReceiverStationId.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStationId.Name = "ucrReceiverStationId"
        Me.ucrReceiverStationId.Selector = Nothing
        Me.ucrReceiverStationId.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStationId.strNcFilePath = ""
        Me.ucrReceiverStationId.TabIndex = 10
        Me.ucrReceiverStationId.ucrSelector = Nothing
        '
        'ucrReceiverStationName
        '
        Me.ucrReceiverStationName.AutoSize = True
        Me.ucrReceiverStationName.frmParent = Me
        Me.ucrReceiverStationName.Location = New System.Drawing.Point(272, 140)
        Me.ucrReceiverStationName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStationName.Name = "ucrReceiverStationName"
        Me.ucrReceiverStationName.Selector = Nothing
        Me.ucrReceiverStationName.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStationName.strNcFilePath = ""
        Me.ucrReceiverStationName.TabIndex = 8
        Me.ucrReceiverStationName.ucrSelector = Nothing
        '
        'ucrReceiverLongtitude
        '
        Me.ucrReceiverLongtitude.AutoSize = True
        Me.ucrReceiverLongtitude.frmParent = Me
        Me.ucrReceiverLongtitude.Location = New System.Drawing.Point(272, 68)
        Me.ucrReceiverLongtitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongtitude.Name = "ucrReceiverLongtitude"
        Me.ucrReceiverLongtitude.Selector = Nothing
        Me.ucrReceiverLongtitude.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverLongtitude.strNcFilePath = ""
        Me.ucrReceiverLongtitude.TabIndex = 4
        Me.ucrReceiverLongtitude.ucrSelector = Nothing
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.AutoSize = True
        Me.ucrReceiverLatitude.frmParent = Me
        Me.ucrReceiverLatitude.Location = New System.Drawing.Point(272, 25)
        Me.ucrReceiverLatitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.TabIndex = 2
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'lblLatitude
        '
        Me.lblLatitude.AutoSize = True
        Me.lblLatitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLatitude.Location = New System.Drawing.Point(274, 10)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(48, 13)
        Me.lblLatitude.TabIndex = 1
        Me.lblLatitude.Text = "Latitude:"
        '
        'ucrSelectorStationFile
        '
        Me.ucrSelectorStationFile.AutoSize = True
        Me.ucrSelectorStationFile.bDropUnusedFilterLevels = False
        Me.ucrSelectorStationFile.bShowHiddenColumns = False
        Me.ucrSelectorStationFile.bUseCurrentFilter = True
        Me.ucrSelectorStationFile.Location = New System.Drawing.Point(6, 16)
        Me.ucrSelectorStationFile.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStationFile.Name = "ucrSelectorStationFile"
        Me.ucrSelectorStationFile.Size = New System.Drawing.Size(213, 185)
        Me.ucrSelectorStationFile.TabIndex = 0
        '
        'grpDataFile
        '
        Me.grpDataFile.Controls.Add(Me.ucrReceiverDataFiles)
        Me.grpDataFile.Controls.Add(Me.lblDataFiles)
        Me.grpDataFile.Controls.Add(Me.ucrSelectorDataFiles)
        Me.grpDataFile.Location = New System.Drawing.Point(12, 59)
        Me.grpDataFile.Name = "grpDataFile"
        Me.grpDataFile.Size = New System.Drawing.Size(397, 201)
        Me.grpDataFile.TabIndex = 3
        Me.grpDataFile.TabStop = False
        Me.grpDataFile.Text = "Data File"
        '
        'ucrReceiverDataFiles
        '
        Me.ucrReceiverDataFiles.AutoSize = True
        Me.ucrReceiverDataFiles.frmParent = Me
        Me.ucrReceiverDataFiles.Location = New System.Drawing.Point(265, 38)
        Me.ucrReceiverDataFiles.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDataFiles.Name = "ucrReceiverDataFiles"
        Me.ucrReceiverDataFiles.Selector = Nothing
        Me.ucrReceiverDataFiles.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverDataFiles.strNcFilePath = ""
        Me.ucrReceiverDataFiles.TabIndex = 2
        Me.ucrReceiverDataFiles.ucrSelector = Nothing
        '
        'lblDataFiles
        '
        Me.lblDataFiles.AutoSize = True
        Me.lblDataFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataFiles.Location = New System.Drawing.Point(269, 19)
        Me.lblDataFiles.Name = "lblDataFiles"
        Me.lblDataFiles.Size = New System.Drawing.Size(76, 13)
        Me.lblDataFiles.TabIndex = 1
        Me.lblDataFiles.Text = "Data Columns:"
        '
        'ucrSelectorDataFiles
        '
        Me.ucrSelectorDataFiles.AutoSize = True
        Me.ucrSelectorDataFiles.bDropUnusedFilterLevels = False
        Me.ucrSelectorDataFiles.bShowHiddenColumns = False
        Me.ucrSelectorDataFiles.bUseCurrentFilter = True
        Me.ucrSelectorDataFiles.Location = New System.Drawing.Point(6, 16)
        Me.ucrSelectorDataFiles.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDataFiles.Name = "ucrSelectorDataFiles"
        Me.ucrSelectorDataFiles.Size = New System.Drawing.Size(213, 185)
        Me.ucrSelectorDataFiles.TabIndex = 0
        '
        'lblClimaticVariable
        '
        Me.lblClimaticVariable.AutoSize = True
        Me.lblClimaticVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblClimaticVariable.Location = New System.Drawing.Point(195, 468)
        Me.lblClimaticVariable.Name = "lblClimaticVariable"
        Me.lblClimaticVariable.Size = New System.Drawing.Size(87, 13)
        Me.lblClimaticVariable.TabIndex = 19
        Me.lblClimaticVariable.Text = "Climatic Variable:"
        '
        'lblFinalYear
        '
        Me.lblFinalYear.AutoSize = True
        Me.lblFinalYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFinalYear.Location = New System.Drawing.Point(15, 488)
        Me.lblFinalYear.Name = "lblFinalYear"
        Me.lblFinalYear.Size = New System.Drawing.Size(57, 13)
        Me.lblFinalYear.TabIndex = 17
        Me.lblFinalYear.Text = "Final Year:"
        '
        'lblInitialYear
        '
        Me.lblInitialYear.AutoSize = True
        Me.lblInitialYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInitialYear.Location = New System.Drawing.Point(15, 465)
        Me.lblInitialYear.Name = "lblInitialYear"
        Me.lblInitialYear.Size = New System.Drawing.Size(59, 13)
        Me.lblInitialYear.TabIndex = 15
        Me.lblInitialYear.Text = "Initial Year:"
        '
        'ucrInputFinalYear
        '
        Me.ucrInputFinalYear.AddQuotesIfUnrecognised = True
        Me.ucrInputFinalYear.AutoSize = True
        Me.ucrInputFinalYear.IsMultiline = False
        Me.ucrInputFinalYear.IsReadOnly = False
        Me.ucrInputFinalYear.Location = New System.Drawing.Point(77, 484)
        Me.ucrInputFinalYear.Name = "ucrInputFinalYear"
        Me.ucrInputFinalYear.Size = New System.Drawing.Size(89, 21)
        Me.ucrInputFinalYear.TabIndex = 18
        '
        'ucrInputInitialYear
        '
        Me.ucrInputInitialYear.AddQuotesIfUnrecognised = True
        Me.ucrInputInitialYear.AutoSize = True
        Me.ucrInputInitialYear.IsMultiline = False
        Me.ucrInputInitialYear.IsReadOnly = False
        Me.ucrInputInitialYear.Location = New System.Drawing.Point(77, 461)
        Me.ucrInputInitialYear.Name = "ucrInputInitialYear"
        Me.ucrInputInitialYear.Size = New System.Drawing.Size(89, 21)
        Me.ucrInputInitialYear.TabIndex = 16
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(266, 96)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 5
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSelectorHomogenization
        '
        Me.ucrSelectorHomogenization.AutoSize = True
        Me.ucrSelectorHomogenization.bDropUnusedFilterLevels = False
        Me.ucrSelectorHomogenization.bShowHiddenColumns = False
        Me.ucrSelectorHomogenization.bUseCurrentFilter = True
        Me.ucrSelectorHomogenization.Location = New System.Drawing.Point(12, 58)
        Me.ucrSelectorHomogenization.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorHomogenization.Name = "ucrSelectorHomogenization"
        Me.ucrSelectorHomogenization.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorHomogenization.TabIndex = 4
        '
        'ucrInputClimateVariables
        '
        Me.ucrInputClimateVariables.AddQuotesIfUnrecognised = True
        Me.ucrInputClimateVariables.AutoSize = True
        Me.ucrInputClimateVariables.IsMultiline = False
        Me.ucrInputClimateVariables.IsReadOnly = False
        Me.ucrInputClimateVariables.Location = New System.Drawing.Point(284, 464)
        Me.ucrInputClimateVariables.Name = "ucrInputClimateVariables"
        Me.ucrInputClimateVariables.Size = New System.Drawing.Size(125, 21)
        Me.ucrInputClimateVariables.TabIndex = 20
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(12, 2)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(408, 51)
        Me.ucrPnlOptions.TabIndex = 0
        '
        'ucrSaveResult
        '
        Me.ucrSaveResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveResult.Enabled = False
        Me.ucrSaveResult.Location = New System.Drawing.Point(12, 426)
        Me.ucrSaveResult.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveResult.Name = "ucrSaveResult"
        Me.ucrSaveResult.Size = New System.Drawing.Size(320, 24)
        Me.ucrSaveResult.TabIndex = 13
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.AutoSize = True
        Me.ucrReceiverElement.frmParent = Me
        Me.ucrReceiverElement.Location = New System.Drawing.Point(266, 151)
        Me.ucrReceiverElement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.TabIndex = 7
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(12, 515)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 21
        '
        'ucrReceiverNeighbour
        '
        Me.ucrReceiverNeighbour.AutoSize = True
        Me.ucrReceiverNeighbour.frmParent = Me
        Me.ucrReceiverNeighbour.Location = New System.Drawing.Point(266, 206)
        Me.ucrReceiverNeighbour.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverNeighbour.Name = "ucrReceiverNeighbour"
        Me.ucrReceiverNeighbour.Selector = Nothing
        Me.ucrReceiverNeighbour.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverNeighbour.strNcFilePath = ""
        Me.ucrReceiverNeighbour.TabIndex = 9
        Me.ucrReceiverNeighbour.ucrSelector = Nothing
        '
        'rdoHomogenization
        '
        Me.rdoHomogenization.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoHomogenization.BackColor = System.Drawing.SystemColors.Control
        Me.rdoHomogenization.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHomogenization.FlatAppearance.BorderSize = 2
        Me.rdoHomogenization.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHomogenization.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoHomogenization.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHomogenization.Location = New System.Drawing.Point(319, 9)
        Me.rdoHomogenization.Name = "rdoHomogenization"
        Me.rdoHomogenization.Size = New System.Drawing.Size(101, 28)
        Me.rdoHomogenization.TabIndex = 23
        Me.rdoHomogenization.TabStop = True
        Me.rdoHomogenization.Tag = ""
        Me.rdoHomogenization.Text = "Homogenization"
        Me.rdoHomogenization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoHomogenization.UseVisualStyleBackColor = False
        '
        'rdoMonthlyTotals
        '
        Me.rdoMonthlyTotals.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMonthlyTotals.BackColor = System.Drawing.SystemColors.Control
        Me.rdoMonthlyTotals.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMonthlyTotals.FlatAppearance.BorderSize = 2
        Me.rdoMonthlyTotals.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMonthlyTotals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMonthlyTotals.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMonthlyTotals.Location = New System.Drawing.Point(233, 9)
        Me.rdoMonthlyTotals.Name = "rdoMonthlyTotals"
        Me.rdoMonthlyTotals.Size = New System.Drawing.Size(91, 28)
        Me.rdoMonthlyTotals.TabIndex = 24
        Me.rdoMonthlyTotals.TabStop = True
        Me.rdoMonthlyTotals.Tag = ""
        Me.rdoMonthlyTotals.Text = "Monthly Totals "
        Me.rdoMonthlyTotals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMonthlyTotals.UseVisualStyleBackColor = False
        '
        'rdoQualityControl
        '
        Me.rdoQualityControl.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoQualityControl.BackColor = System.Drawing.SystemColors.Control
        Me.rdoQualityControl.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoQualityControl.FlatAppearance.BorderSize = 2
        Me.rdoQualityControl.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoQualityControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoQualityControl.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoQualityControl.Location = New System.Drawing.Point(148, 9)
        Me.rdoQualityControl.Name = "rdoQualityControl"
        Me.rdoQualityControl.Size = New System.Drawing.Size(87, 28)
        Me.rdoQualityControl.TabIndex = 25
        Me.rdoQualityControl.TabStop = True
        Me.rdoQualityControl.Tag = ""
        Me.rdoQualityControl.Text = "Quality Control"
        Me.rdoQualityControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoQualityControl.UseVisualStyleBackColor = False
        '
        'dlgHomogenization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(422, 570)
        Me.Controls.Add(Me.rdoQualityControl)
        Me.Controls.Add(Me.rdoMonthlyTotals)
        Me.Controls.Add(Me.rdoHomogenization)
        Me.Controls.Add(Me.grpStationFile)
        Me.Controls.Add(Me.grpDataFile)
        Me.Controls.Add(Me.ucrInputFinalYear)
        Me.Controls.Add(Me.ucrInputInitialYear)
        Me.Controls.Add(Me.lblInitialYear)
        Me.Controls.Add(Me.lblFinalYear)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrSelectorHomogenization)
        Me.Controls.Add(Me.lblClimaticVariable)
        Me.Controls.Add(Me.ucrInputClimateVariables)
        Me.Controls.Add(Me.rdoPrepare)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.lblNeighbouring)
        Me.Controls.Add(Me.rdoSingle)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrSaveResult)
        Me.Controls.Add(Me.grpOutputOptions)
        Me.Controls.Add(Me.grpCptOptions)
        Me.Controls.Add(Me.grpMethods)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.ucrReceiverElement)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverNeighbour)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgHomogenization"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Homogenization (Change Point)"
        Me.grpMethods.ResumeLayout(False)
        Me.grpMethods.PerformLayout()
        Me.grpCptOptions.ResumeLayout(False)
        Me.grpCptOptions.PerformLayout()
        Me.grpOutputOptions.ResumeLayout(False)
        Me.grpOutputOptions.PerformLayout()
        Me.grpStationFile.ResumeLayout(False)
        Me.grpStationFile.PerformLayout()
        Me.grpDataFile.ResumeLayout(False)
        Me.grpDataFile.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorHomogenization As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverElement As ucrReceiverSingle
    Friend WithEvents lblElement As Label
    Friend WithEvents grpCptOptions As GroupBox
    Friend WithEvents grpMethods As GroupBox
    Friend WithEvents ucrPnlMethods As UcrPanel
    Friend WithEvents rdoCptMean As RadioButton
    Friend WithEvents rdoCptMeanVariance As RadioButton
    Friend WithEvents rdoCptVariance As RadioButton
    Friend WithEvents grpOutputOptions As GroupBox
    Friend WithEvents ucrChkPlot As ucrCheck
    Friend WithEvents ucrChkSummary As ucrCheck
    Friend WithEvents ucrNudMinSegLen As ucrNud
    Friend WithEvents ucrInputQ As ucrInputTextBox
    Friend WithEvents ucrInputComboMeanDistribution As ucrInputComboBox
    Friend WithEvents ucrInputComboMethod As ucrInputComboBox
    Friend WithEvents ucrInputComboPenalty As ucrInputComboBox
    Friend WithEvents lblPenalty As Label
    Friend WithEvents lblMethod As Label
    Friend WithEvents lblDistribution As Label
    Friend WithEvents lblMinSegLen As Label
    Friend WithEvents lblQ As Label
    Friend WithEvents ucrSaveResult As ucrSave
    Friend WithEvents ttOptions As ToolTip
    Friend WithEvents lblPenaltyValue As Label
    Friend WithEvents ucrInputPenValue As ucrInputTextBox
    Friend WithEvents rdoSingle As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents lblNeighbouring As Label
    Friend WithEvents ucrReceiverNeighbour As ucrReceiverSingle
    Friend WithEvents ucrInputComboVarDistribution As ucrInputComboBox
    Friend WithEvents ucrInputComboMeanVarDistribution As ucrInputComboBox
    Friend WithEvents rdoSnht As RadioButton
    Friend WithEvents rdoPettitt As RadioButton
    Friend WithEvents rdoBuishand As RadioButton
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents rdoPrepare As RadioButton
    Friend WithEvents lblClimaticVariable As Label
    Friend WithEvents ucrInputClimateVariables As ucrInputTextBox
    Friend WithEvents grpDataFile As GroupBox
    Friend WithEvents ucrReceiverDataFiles As ucrReceiverMultiple
    Friend WithEvents lblDataFiles As Label
    Friend WithEvents ucrSelectorDataFiles As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpStationFile As GroupBox
    Friend WithEvents lblLatitude As Label
    Friend WithEvents ucrSelectorStationFile As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputFinalYear As ucrInputTextBox
    Friend WithEvents ucrInputInitialYear As ucrInputTextBox
    Friend WithEvents lblInitialYear As Label
    Friend WithEvents lblFinalYear As Label
    Friend WithEvents ucrReceiverStationId As ucrReceiverSingle
    Friend WithEvents ucrReceiverStationName As ucrReceiverSingle
    Friend WithEvents ucrReceiverLongtitude As ucrReceiverSingle
    Friend WithEvents ucrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents ucrReceiverElavation As ucrReceiverSingle
    Friend WithEvents lblLongtude As Label
    Friend WithEvents lblStationName As Label
    Friend WithEvents lblStationID As Label
    Friend WithEvents lblElavation As Label
    Friend WithEvents rdoQualityControl As RadioButton
    Friend WithEvents rdoMonthlyTotals As RadioButton
    Friend WithEvents rdoHomogenization As RadioButton
End Class
