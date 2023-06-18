<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgHomogenization
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
        Me.rdoMultiple = New System.Windows.Forms.RadioButton()
        Me.rdoNeighbouring = New System.Windows.Forms.RadioButton()
        Me.lblNeighbouring = New System.Windows.Forms.Label()
        Me.ucrReceiverNeighbour = New instat.ucrReceiverSingle()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrSaveResult = New instat.ucrSave()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrSelectorHomogenization = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.grpMethods.SuspendLayout()
        Me.grpCptOptions.SuspendLayout()
        Me.grpOutputOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElement.Location = New System.Drawing.Point(264, 135)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(48, 13)
        Me.lblElement.TabIndex = 7
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
        Me.grpMethods.TabIndex = 11
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
        Me.rdoCptMean.TabIndex = 6
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
        Me.rdoCptMeanVariance.TabIndex = 5
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
        Me.rdoBuishand.TabIndex = 16
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
        Me.rdoPettitt.TabIndex = 15
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
        Me.rdoSnht.TabIndex = 14
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
        Me.grpCptOptions.TabIndex = 12
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
        Me.ucrInputComboMeanVarDistribution.TabIndex = 14
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
        Me.lblPenaltyValue.TabIndex = 12
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
        Me.lblMinSegLen.TabIndex = 10
        Me.lblMinSegLen.Text = "MinSegLen:"
        '
        'lblQ
        '
        Me.lblQ.AutoSize = True
        Me.lblQ.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQ.Location = New System.Drawing.Point(4, 120)
        Me.lblQ.Name = "lblQ"
        Me.lblQ.Size = New System.Drawing.Size(18, 13)
        Me.lblQ.TabIndex = 9
        Me.lblQ.Text = "Q:"
        '
        'lblPenalty
        '
        Me.lblPenalty.AutoSize = True
        Me.lblPenalty.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPenalty.Location = New System.Drawing.Point(4, 21)
        Me.lblPenalty.Name = "lblPenalty"
        Me.lblPenalty.Size = New System.Drawing.Size(45, 13)
        Me.lblPenalty.TabIndex = 8
        Me.lblPenalty.Text = "Penalty:"
        '
        'lblMethod
        '
        Me.lblMethod.AutoSize = True
        Me.lblMethod.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMethod.Location = New System.Drawing.Point(4, 44)
        Me.lblMethod.Name = "lblMethod"
        Me.lblMethod.Size = New System.Drawing.Size(46, 13)
        Me.lblMethod.TabIndex = 7
        Me.lblMethod.Text = "Method:"
        '
        'lblDistribution
        '
        Me.lblDistribution.AutoSize = True
        Me.lblDistribution.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDistribution.Location = New System.Drawing.Point(4, 69)
        Me.lblDistribution.Name = "lblDistribution"
        Me.lblDistribution.Size = New System.Drawing.Size(62, 13)
        Me.lblDistribution.TabIndex = 6
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
        Me.ucrNudMinSegLen.TabIndex = 4
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
        Me.ucrInputQ.TabIndex = 3
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
        Me.ucrInputComboMethod.TabIndex = 1
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
        Me.ucrInputComboPenalty.TabIndex = 0
        '
        'grpOutputOptions
        '
        Me.grpOutputOptions.Controls.Add(Me.ucrChkPlot)
        Me.grpOutputOptions.Controls.Add(Me.ucrChkSummary)
        Me.grpOutputOptions.Enabled = False
        Me.grpOutputOptions.Location = New System.Drawing.Point(12, 353)
        Me.grpOutputOptions.Name = "grpOutputOptions"
        Me.grpOutputOptions.Size = New System.Drawing.Size(209, 42)
        Me.grpOutputOptions.TabIndex = 13
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
        Me.ucrChkPlot.TabIndex = 1
        '
        'ucrChkSummary
        '
        Me.ucrChkSummary.AutoSize = True
        Me.ucrChkSummary.Checked = False
        Me.ucrChkSummary.Location = New System.Drawing.Point(110, 19)
        Me.ucrChkSummary.Name = "ucrChkSummary"
        Me.ucrChkSummary.Size = New System.Drawing.Size(93, 23)
        Me.ucrChkSummary.TabIndex = 0
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
        Me.rdoSingle.Location = New System.Drawing.Point(62, 27)
        Me.rdoSingle.Name = "rdoSingle"
        Me.rdoSingle.Size = New System.Drawing.Size(101, 28)
        Me.rdoSingle.TabIndex = 1
        Me.rdoSingle.TabStop = True
        Me.rdoSingle.Tag = ""
        Me.rdoSingle.Text = "Single"
        Me.rdoSingle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSingle.UseVisualStyleBackColor = False
        '
        'rdoMultiple
        '
        Me.rdoMultiple.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMultiple.BackColor = System.Drawing.SystemColors.Control
        Me.rdoMultiple.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.FlatAppearance.BorderSize = 2
        Me.rdoMultiple.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMultiple.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMultiple.Location = New System.Drawing.Point(260, 27)
        Me.rdoMultiple.Name = "rdoMultiple"
        Me.rdoMultiple.Size = New System.Drawing.Size(101, 28)
        Me.rdoMultiple.TabIndex = 3
        Me.rdoMultiple.TabStop = True
        Me.rdoMultiple.Tag = ""
        Me.rdoMultiple.Text = "Multiple"
        Me.rdoMultiple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMultiple.UseVisualStyleBackColor = False
        '
        'rdoNeighbouring
        '
        Me.rdoNeighbouring.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoNeighbouring.BackColor = System.Drawing.SystemColors.Control
        Me.rdoNeighbouring.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoNeighbouring.FlatAppearance.BorderSize = 2
        Me.rdoNeighbouring.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoNeighbouring.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoNeighbouring.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNeighbouring.Location = New System.Drawing.Point(161, 27)
        Me.rdoNeighbouring.Name = "rdoNeighbouring"
        Me.rdoNeighbouring.Size = New System.Drawing.Size(101, 28)
        Me.rdoNeighbouring.TabIndex = 2
        Me.rdoNeighbouring.TabStop = True
        Me.rdoNeighbouring.Tag = ""
        Me.rdoNeighbouring.Text = "Neighbouring"
        Me.rdoNeighbouring.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoNeighbouring.UseVisualStyleBackColor = False
        '
        'lblNeighbouring
        '
        Me.lblNeighbouring.AutoSize = True
        Me.lblNeighbouring.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNeighbouring.Location = New System.Drawing.Point(264, 190)
        Me.lblNeighbouring.Name = "lblNeighbouring"
        Me.lblNeighbouring.Size = New System.Drawing.Size(59, 13)
        Me.lblNeighbouring.TabIndex = 9
        Me.lblNeighbouring.Text = "Neighbour:"
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
        Me.ucrReceiverNeighbour.TabIndex = 10
        Me.ucrReceiverNeighbour.ucrSelector = Nothing
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(51, 25)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(321, 30)
        Me.ucrPnlOptions.TabIndex = 0
        '
        'ucrSaveResult
        '
        Me.ucrSaveResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveResult.Enabled = False
        Me.ucrSaveResult.Location = New System.Drawing.Point(12, 413)
        Me.ucrSaveResult.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveResult.Name = "ucrSaveResult"
        Me.ucrSaveResult.Size = New System.Drawing.Size(320, 24)
        Me.ucrSaveResult.TabIndex = 14
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
        Me.ucrReceiverElement.TabIndex = 8
        Me.ucrReceiverElement.ucrSelector = Nothing
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
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(12, 440)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 15
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStation.Location = New System.Drawing.Point(264, 80)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 5
        Me.lblStation.Text = "Station:"
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
        Me.ucrReceiverStation.TabIndex = 6
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'dlgHomogenization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(422, 494)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.lblNeighbouring)
        Me.Controls.Add(Me.ucrReceiverNeighbour)
        Me.Controls.Add(Me.rdoNeighbouring)
        Me.Controls.Add(Me.rdoSingle)
        Me.Controls.Add(Me.rdoMultiple)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrSaveResult)
        Me.Controls.Add(Me.grpOutputOptions)
        Me.Controls.Add(Me.grpCptOptions)
        Me.Controls.Add(Me.grpMethods)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.ucrReceiverElement)
        Me.Controls.Add(Me.ucrSelectorHomogenization)
        Me.Controls.Add(Me.ucrBase)
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
    Friend WithEvents rdoMultiple As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents rdoNeighbouring As RadioButton
    Friend WithEvents lblNeighbouring As Label
    Friend WithEvents ucrReceiverNeighbour As ucrReceiverSingle
    Friend WithEvents ucrInputComboVarDistribution As ucrInputComboBox
    Friend WithEvents ucrInputComboMeanVarDistribution As ucrInputComboBox
    Friend WithEvents rdoSnht As RadioButton
    Friend WithEvents rdoPettitt As RadioButton
    Friend WithEvents rdoBuishand As RadioButton
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
End Class
