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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgHomogenization))
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
        resources.ApplyResources(Me.lblElement, "lblElement")
        Me.lblElement.Name = "lblElement"
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
        resources.ApplyResources(Me.grpMethods, "grpMethods")
        Me.grpMethods.Name = "grpMethods"
        Me.grpMethods.TabStop = False
        '
        'rdoCptMean
        '
        resources.ApplyResources(Me.rdoCptMean, "rdoCptMean")
        Me.rdoCptMean.Name = "rdoCptMean"
        Me.rdoCptMean.UseVisualStyleBackColor = True
        '
        'rdoCptMeanVariance
        '
        resources.ApplyResources(Me.rdoCptMeanVariance, "rdoCptMeanVariance")
        Me.rdoCptMeanVariance.Name = "rdoCptMeanVariance"
        Me.rdoCptMeanVariance.UseVisualStyleBackColor = True
        '
        'rdoCptVariance
        '
        resources.ApplyResources(Me.rdoCptVariance, "rdoCptVariance")
        Me.rdoCptVariance.Name = "rdoCptVariance"
        Me.rdoCptVariance.UseVisualStyleBackColor = True
        '
        'rdoBuishand
        '
        resources.ApplyResources(Me.rdoBuishand, "rdoBuishand")
        Me.rdoBuishand.Name = "rdoBuishand"
        Me.rdoBuishand.UseVisualStyleBackColor = True
        '
        'rdoPettitt
        '
        resources.ApplyResources(Me.rdoPettitt, "rdoPettitt")
        Me.rdoPettitt.Name = "rdoPettitt"
        Me.rdoPettitt.UseVisualStyleBackColor = True
        '
        'rdoSnht
        '
        resources.ApplyResources(Me.rdoSnht, "rdoSnht")
        Me.rdoSnht.Name = "rdoSnht"
        Me.rdoSnht.UseVisualStyleBackColor = True
        '
        'ucrPnlMethods
        '
        resources.ApplyResources(Me.ucrPnlMethods, "ucrPnlMethods")
        Me.ucrPnlMethods.Name = "ucrPnlMethods"
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
        resources.ApplyResources(Me.grpCptOptions, "grpCptOptions")
        Me.grpCptOptions.Name = "grpCptOptions"
        Me.grpCptOptions.TabStop = False
        '
        'ucrInputComboMeanVarDistribution
        '
        Me.ucrInputComboMeanVarDistribution.AddQuotesIfUnrecognised = True
        Me.ucrInputComboMeanVarDistribution.GetSetSelectedIndex = -1
        Me.ucrInputComboMeanVarDistribution.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboMeanVarDistribution, "ucrInputComboMeanVarDistribution")
        Me.ucrInputComboMeanVarDistribution.Name = "ucrInputComboMeanVarDistribution"
        '
        'ucrInputComboVarDistribution
        '
        Me.ucrInputComboVarDistribution.AddQuotesIfUnrecognised = True
        Me.ucrInputComboVarDistribution.GetSetSelectedIndex = -1
        Me.ucrInputComboVarDistribution.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboVarDistribution, "ucrInputComboVarDistribution")
        Me.ucrInputComboVarDistribution.Name = "ucrInputComboVarDistribution"
        '
        'lblPenaltyValue
        '
        resources.ApplyResources(Me.lblPenaltyValue, "lblPenaltyValue")
        Me.lblPenaltyValue.Name = "lblPenaltyValue"
        '
        'ucrInputPenValue
        '
        Me.ucrInputPenValue.AddQuotesIfUnrecognised = True
        Me.ucrInputPenValue.IsMultiline = False
        Me.ucrInputPenValue.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPenValue, "ucrInputPenValue")
        Me.ucrInputPenValue.Name = "ucrInputPenValue"
        '
        'lblMinSegLen
        '
        resources.ApplyResources(Me.lblMinSegLen, "lblMinSegLen")
        Me.lblMinSegLen.Name = "lblMinSegLen"
        '
        'lblQ
        '
        resources.ApplyResources(Me.lblQ, "lblQ")
        Me.lblQ.Name = "lblQ"
        '
        'lblPenalty
        '
        resources.ApplyResources(Me.lblPenalty, "lblPenalty")
        Me.lblPenalty.Name = "lblPenalty"
        '
        'lblMethod
        '
        resources.ApplyResources(Me.lblMethod, "lblMethod")
        Me.lblMethod.Name = "lblMethod"
        '
        'lblDistribution
        '
        resources.ApplyResources(Me.lblDistribution, "lblDistribution")
        Me.lblDistribution.Name = "lblDistribution"
        '
        'ucrNudMinSegLen
        '
        Me.ucrNudMinSegLen.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinSegLen.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMinSegLen, "ucrNudMinSegLen")
        Me.ucrNudMinSegLen.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinSegLen.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinSegLen.Name = "ucrNudMinSegLen"
        Me.ucrNudMinSegLen.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputQ
        '
        Me.ucrInputQ.AddQuotesIfUnrecognised = True
        Me.ucrInputQ.IsMultiline = False
        Me.ucrInputQ.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputQ, "ucrInputQ")
        Me.ucrInputQ.Name = "ucrInputQ"
        '
        'ucrInputComboMeanDistribution
        '
        Me.ucrInputComboMeanDistribution.AddQuotesIfUnrecognised = True
        Me.ucrInputComboMeanDistribution.GetSetSelectedIndex = -1
        Me.ucrInputComboMeanDistribution.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboMeanDistribution, "ucrInputComboMeanDistribution")
        Me.ucrInputComboMeanDistribution.Name = "ucrInputComboMeanDistribution"
        '
        'ucrInputComboMethod
        '
        Me.ucrInputComboMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputComboMethod.GetSetSelectedIndex = -1
        Me.ucrInputComboMethod.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboMethod, "ucrInputComboMethod")
        Me.ucrInputComboMethod.Name = "ucrInputComboMethod"
        '
        'ucrInputComboPenalty
        '
        Me.ucrInputComboPenalty.AddQuotesIfUnrecognised = True
        Me.ucrInputComboPenalty.GetSetSelectedIndex = -1
        Me.ucrInputComboPenalty.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboPenalty, "ucrInputComboPenalty")
        Me.ucrInputComboPenalty.Name = "ucrInputComboPenalty"
        '
        'grpOutputOptions
        '
        Me.grpOutputOptions.Controls.Add(Me.ucrChkPlot)
        Me.grpOutputOptions.Controls.Add(Me.ucrChkSummary)
        resources.ApplyResources(Me.grpOutputOptions, "grpOutputOptions")
        Me.grpOutputOptions.Name = "grpOutputOptions"
        Me.grpOutputOptions.TabStop = False
        '
        'ucrChkPlot
        '
        Me.ucrChkPlot.Checked = False
        resources.ApplyResources(Me.ucrChkPlot, "ucrChkPlot")
        Me.ucrChkPlot.Name = "ucrChkPlot"
        '
        'ucrChkSummary
        '
        Me.ucrChkSummary.Checked = False
        resources.ApplyResources(Me.ucrChkSummary, "ucrChkSummary")
        Me.ucrChkSummary.Name = "ucrChkSummary"
        '
        'rdoSingle
        '
        resources.ApplyResources(Me.rdoSingle, "rdoSingle")
        Me.rdoSingle.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSingle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingle.FlatAppearance.BorderSize = 2
        Me.rdoSingle.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingle.Name = "rdoSingle"
        Me.rdoSingle.TabStop = True
        Me.rdoSingle.Tag = ""
        Me.rdoSingle.UseVisualStyleBackColor = False
        '
        'rdoMultiple
        '
        resources.ApplyResources(Me.rdoMultiple, "rdoMultiple")
        Me.rdoMultiple.BackColor = System.Drawing.SystemColors.Control
        Me.rdoMultiple.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.FlatAppearance.BorderSize = 2
        Me.rdoMultiple.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.Name = "rdoMultiple"
        Me.rdoMultiple.TabStop = True
        Me.rdoMultiple.Tag = ""
        Me.rdoMultiple.UseVisualStyleBackColor = False
        '
        'rdoNeighbouring
        '
        resources.ApplyResources(Me.rdoNeighbouring, "rdoNeighbouring")
        Me.rdoNeighbouring.BackColor = System.Drawing.SystemColors.Control
        Me.rdoNeighbouring.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoNeighbouring.FlatAppearance.BorderSize = 2
        Me.rdoNeighbouring.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoNeighbouring.Name = "rdoNeighbouring"
        Me.rdoNeighbouring.TabStop = True
        Me.rdoNeighbouring.Tag = ""
        Me.rdoNeighbouring.UseVisualStyleBackColor = False
        '
        'lblNeighbouring
        '
        resources.ApplyResources(Me.lblNeighbouring, "lblNeighbouring")
        Me.lblNeighbouring.Name = "lblNeighbouring"
        '
        'ucrReceiverNeighbour
        '
        Me.ucrReceiverNeighbour.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverNeighbour, "ucrReceiverNeighbour")
        Me.ucrReceiverNeighbour.Name = "ucrReceiverNeighbour"
        Me.ucrReceiverNeighbour.Selector = Nothing
        Me.ucrReceiverNeighbour.strNcFilePath = ""
        Me.ucrReceiverNeighbour.ucrSelector = Nothing
        '
        'ucrPnlOptions
        '
        resources.ApplyResources(Me.ucrPnlOptions, "ucrPnlOptions")
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        '
        'ucrSaveResult
        '
        resources.ApplyResources(Me.ucrSaveResult, "ucrSaveResult")
        Me.ucrSaveResult.Name = "ucrSaveResult"
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverElement, "ucrReceiverElement")
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'ucrSelectorHomogenization
        '
        Me.ucrSelectorHomogenization.bDropUnusedFilterLevels = False
        Me.ucrSelectorHomogenization.bShowHiddenColumns = False
        Me.ucrSelectorHomogenization.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorHomogenization, "ucrSelectorHomogenization")
        Me.ucrSelectorHomogenization.Name = "ucrSelectorHomogenization"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'lblStation
        '
        resources.ApplyResources(Me.lblStation, "lblStation")
        Me.lblStation.Name = "lblStation"
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverStation, "ucrReceiverStation")
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'dlgHomogenization
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.grpMethods.ResumeLayout(False)
        Me.grpMethods.PerformLayout()
        Me.grpCptOptions.ResumeLayout(False)
        Me.grpCptOptions.PerformLayout()
        Me.grpOutputOptions.ResumeLayout(False)
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
