<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgConversions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgConversions))
        Me.rdoDayLength = New System.Windows.Forms.RadioButton()
        Me.rdoUnits = New System.Windows.Forms.RadioButton()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblElementName = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblDecimal = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.rdoVariable = New System.Windows.Forms.RadioButton()
        Me.rdoValue = New System.Windows.Forms.RadioButton()
        Me.lblDecimalValue = New System.Windows.Forms.Label()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.ucrInputLatitude = New instat.ucrInputTextBox()
        Me.ucrPnlLatitude = New instat.UcrPanel()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrNudDecimal = New instat.ucrNud()
        Me.ucrSaveConversions = New instat.ucrSave()
        Me.ucrInputTo = New instat.ucrInputComboBox()
        Me.ucrInputFrom = New instat.ucrInputComboBox()
        Me.ucrInputElement = New instat.ucrInputComboBox()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrPnlConversions = New instat.UcrPanel()
        Me.ucrSelectorConversions = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'rdoDayLength
        '
        resources.ApplyResources(Me.rdoDayLength, "rdoDayLength")
        Me.rdoDayLength.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDayLength.FlatAppearance.BorderSize = 2
        Me.rdoDayLength.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDayLength.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoDayLength.Name = "rdoDayLength"
        Me.rdoDayLength.UseVisualStyleBackColor = True
        '
        'rdoUnits
        '
        resources.ApplyResources(Me.rdoUnits, "rdoUnits")
        Me.rdoUnits.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoUnits.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoUnits.FlatAppearance.BorderSize = 2
        Me.rdoUnits.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoUnits.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoUnits.Name = "rdoUnits"
        Me.rdoUnits.UseVisualStyleBackColor = True
        '
        'lblElement
        '
        resources.ApplyResources(Me.lblElement, "lblElement")
        Me.lblElement.Name = "lblElement"
        '
        'lblElementName
        '
        resources.ApplyResources(Me.lblElementName, "lblElementName")
        Me.lblElementName.Name = "lblElementName"
        '
        'lblFrom
        '
        resources.ApplyResources(Me.lblFrom, "lblFrom")
        Me.lblFrom.Name = "lblFrom"
        '
        'lblTo
        '
        resources.ApplyResources(Me.lblTo, "lblTo")
        Me.lblTo.Name = "lblTo"
        '
        'lblDecimal
        '
        resources.ApplyResources(Me.lblDecimal, "lblDecimal")
        Me.lblDecimal.Name = "lblDecimal"
        '
        'lblDate
        '
        resources.ApplyResources(Me.lblDate, "lblDate")
        Me.lblDate.Name = "lblDate"
        '
        'lblStation
        '
        resources.ApplyResources(Me.lblStation, "lblStation")
        Me.lblStation.Name = "lblStation"
        '
        'rdoVariable
        '
        resources.ApplyResources(Me.rdoVariable, "rdoVariable")
        Me.rdoVariable.Name = "rdoVariable"
        Me.rdoVariable.TabStop = True
        Me.rdoVariable.UseVisualStyleBackColor = True
        '
        'rdoValue
        '
        resources.ApplyResources(Me.rdoValue, "rdoValue")
        Me.rdoValue.Name = "rdoValue"
        Me.rdoValue.TabStop = True
        Me.rdoValue.UseVisualStyleBackColor = True
        '
        'lblDecimalValue
        '
        resources.ApplyResources(Me.lblDecimalValue, "lblDecimalValue")
        Me.lblDecimalValue.Name = "lblDecimalValue"
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverLatitude, "ucrReceiverLatitude")
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrInputLatitude
        '
        Me.ucrInputLatitude.AddQuotesIfUnrecognised = True
        Me.ucrInputLatitude.IsMultiline = False
        Me.ucrInputLatitude.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLatitude, "ucrInputLatitude")
        Me.ucrInputLatitude.Name = "ucrInputLatitude"
        '
        'ucrPnlLatitude
        '
        resources.ApplyResources(Me.ucrPnlLatitude, "ucrPnlLatitude")
        Me.ucrPnlLatitude.Name = "ucrPnlLatitude"
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDate, "ucrReceiverDate")
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.ucrSelector = Nothing
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
        'ucrNudDecimal
        '
        Me.ucrNudDecimal.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimal.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudDecimal, "ucrNudDecimal")
        Me.ucrNudDecimal.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDecimal.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimal.Name = "ucrNudDecimal"
        Me.ucrNudDecimal.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSaveConversions
        '
        resources.ApplyResources(Me.ucrSaveConversions, "ucrSaveConversions")
        Me.ucrSaveConversions.Name = "ucrSaveConversions"
        '
        'ucrInputTo
        '
        Me.ucrInputTo.AddQuotesIfUnrecognised = True
        Me.ucrInputTo.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTo, "ucrInputTo")
        Me.ucrInputTo.Name = "ucrInputTo"
        '
        'ucrInputFrom
        '
        Me.ucrInputFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputFrom.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFrom, "ucrInputFrom")
        Me.ucrInputFrom.Name = "ucrInputFrom"
        '
        'ucrInputElement
        '
        Me.ucrInputElement.AddQuotesIfUnrecognised = True
        Me.ucrInputElement.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputElement, "ucrInputElement")
        Me.ucrInputElement.Name = "ucrInputElement"
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
        'ucrPnlConversions
        '
        resources.ApplyResources(Me.ucrPnlConversions, "ucrPnlConversions")
        Me.ucrPnlConversions.Name = "ucrPnlConversions"
        '
        'ucrSelectorConversions
        '
        Me.ucrSelectorConversions.bDropUnusedFilterLevels = False
        Me.ucrSelectorConversions.bShowHiddenColumns = False
        Me.ucrSelectorConversions.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorConversions, "ucrSelectorConversions")
        Me.ucrSelectorConversions.Name = "ucrSelectorConversions"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgConversions
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblDecimalValue)
        Me.Controls.Add(Me.rdoVariable)
        Me.Controls.Add(Me.rdoValue)
        Me.Controls.Add(Me.ucrReceiverLatitude)
        Me.Controls.Add(Me.ucrInputLatitude)
        Me.Controls.Add(Me.ucrPnlLatitude)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.lblDecimal)
        Me.Controls.Add(Me.ucrNudDecimal)
        Me.Controls.Add(Me.ucrSaveConversions)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.lblElementName)
        Me.Controls.Add(Me.ucrInputTo)
        Me.Controls.Add(Me.ucrInputFrom)
        Me.Controls.Add(Me.ucrInputElement)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.ucrReceiverElement)
        Me.Controls.Add(Me.rdoDayLength)
        Me.Controls.Add(Me.rdoUnits)
        Me.Controls.Add(Me.ucrPnlConversions)
        Me.Controls.Add(Me.ucrSelectorConversions)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgConversions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorConversions As ucrSelectorByDataFrameAddRemove
    Friend WithEvents rdoDayLength As RadioButton
    Friend WithEvents rdoUnits As RadioButton
    Friend WithEvents ucrPnlConversions As UcrPanel
    Friend WithEvents ucrReceiverElement As ucrReceiverSingle
    Friend WithEvents lblElement As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblElementName As Label
    Friend WithEvents ucrInputTo As ucrInputComboBox
    Friend WithEvents ucrInputFrom As ucrInputComboBox
    Friend WithEvents ucrInputElement As ucrInputComboBox
    Friend WithEvents lblDecimal As Label
    Friend WithEvents ucrNudDecimal As ucrNud
    Friend WithEvents ucrSaveConversions As ucrSave
    Friend WithEvents lblDate As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents rdoVariable As RadioButton
    Friend WithEvents rdoValue As RadioButton
    Friend WithEvents ucrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents ucrInputLatitude As ucrInputTextBox
    Friend WithEvents ucrPnlLatitude As UcrPanel
    Friend WithEvents lblDecimalValue As Label
End Class
