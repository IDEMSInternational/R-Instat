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
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblDecimal = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.rdoColumn = New System.Windows.Forms.RadioButton()
        Me.rdoSingleValue = New System.Windows.Forms.RadioButton()
        Me.grpLatitude = New System.Windows.Forms.GroupBox()
        Me.rdoRain = New System.Windows.Forms.RadioButton()
        Me.rdoWindSpeed = New System.Windows.Forms.RadioButton()
        Me.rdoTemperature = New System.Windows.Forms.RadioButton()
        Me.grpElements = New System.Windows.Forms.GroupBox()
        Me.ucrInputLatitude = New instat.ucrInputTextBox()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.ucrPnlLatitude = New instat.UcrPanel()
        Me.ucrInputFromTemperature = New instat.ucrInputComboBox()
        Me.ucrInputToWindSpeed = New instat.ucrInputComboBox()
        Me.ucrInputToTemperature = New instat.ucrInputComboBox()
        Me.ucrInputFromWindSpeed = New instat.ucrInputComboBox()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrNudDecimal = New instat.ucrNud()
        Me.ucrSaveConversions = New instat.ucrSave()
        Me.ucrInputToPrecipitation = New instat.ucrInputComboBox()
        Me.ucrInputFromPrecipitation = New instat.ucrInputComboBox()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrPnlConversions = New instat.UcrPanel()
        Me.ucrSelectorConversions = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlElements = New instat.UcrPanel()
        Me.grpLatitude.SuspendLayout()
        Me.grpElements.SuspendLayout()
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
        'rdoColumn
        '
        resources.ApplyResources(Me.rdoColumn, "rdoColumn")
        Me.rdoColumn.Name = "rdoColumn"
        Me.rdoColumn.TabStop = True
        Me.rdoColumn.UseVisualStyleBackColor = True
        '
        'rdoSingleValue
        '
        resources.ApplyResources(Me.rdoSingleValue, "rdoSingleValue")
        Me.rdoSingleValue.Name = "rdoSingleValue"
        Me.rdoSingleValue.TabStop = True
        Me.rdoSingleValue.UseVisualStyleBackColor = True
        '
        'grpLatitude
        '
        Me.grpLatitude.Controls.Add(Me.ucrInputLatitude)
        Me.grpLatitude.Controls.Add(Me.ucrReceiverLatitude)
        Me.grpLatitude.Controls.Add(Me.rdoColumn)
        Me.grpLatitude.Controls.Add(Me.rdoSingleValue)
        Me.grpLatitude.Controls.Add(Me.ucrPnlLatitude)
        resources.ApplyResources(Me.grpLatitude, "grpLatitude")
        Me.grpLatitude.Name = "grpLatitude"
        Me.grpLatitude.TabStop = False
        '
        'rdoRain
        '
        resources.ApplyResources(Me.rdoRain, "rdoRain")
        Me.rdoRain.Name = "rdoRain"
        Me.rdoRain.TabStop = True
        Me.rdoRain.UseVisualStyleBackColor = True
        '
        'rdoWindSpeed
        '
        resources.ApplyResources(Me.rdoWindSpeed, "rdoWindSpeed")
        Me.rdoWindSpeed.Name = "rdoWindSpeed"
        Me.rdoWindSpeed.TabStop = True
        Me.rdoWindSpeed.UseVisualStyleBackColor = True
        '
        'rdoTemperature
        '
        resources.ApplyResources(Me.rdoTemperature, "rdoTemperature")
        Me.rdoTemperature.Name = "rdoTemperature"
        Me.rdoTemperature.TabStop = True
        Me.rdoTemperature.UseVisualStyleBackColor = True
        '
        'grpElements
        '
        Me.grpElements.Controls.Add(Me.rdoWindSpeed)
        Me.grpElements.Controls.Add(Me.rdoRain)
        Me.grpElements.Controls.Add(Me.rdoTemperature)
        Me.grpElements.Controls.Add(Me.ucrPnlElements)
        resources.ApplyResources(Me.grpElements, "grpElements")
        Me.grpElements.Name = "grpElements"
        Me.grpElements.TabStop = False
        '
        'ucrInputLatitude
        '
        Me.ucrInputLatitude.AddQuotesIfUnrecognised = True
        Me.ucrInputLatitude.IsMultiline = False
        Me.ucrInputLatitude.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLatitude, "ucrInputLatitude")
        Me.ucrInputLatitude.Name = "ucrInputLatitude"
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverLatitude, "ucrReceiverLatitude")
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrPnlLatitude
        '
        resources.ApplyResources(Me.ucrPnlLatitude, "ucrPnlLatitude")
        Me.ucrPnlLatitude.Name = "ucrPnlLatitude"
        '
        'ucrInputFromTemperature
        '
        Me.ucrInputFromTemperature.AddQuotesIfUnrecognised = True
        Me.ucrInputFromTemperature.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFromTemperature, "ucrInputFromTemperature")
        Me.ucrInputFromTemperature.Name = "ucrInputFromTemperature"
        '
        'ucrInputToWindSpeed
        '
        Me.ucrInputToWindSpeed.AddQuotesIfUnrecognised = True
        Me.ucrInputToWindSpeed.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputToWindSpeed, "ucrInputToWindSpeed")
        Me.ucrInputToWindSpeed.Name = "ucrInputToWindSpeed"
        '
        'ucrInputToTemperature
        '
        Me.ucrInputToTemperature.AddQuotesIfUnrecognised = True
        Me.ucrInputToTemperature.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputToTemperature, "ucrInputToTemperature")
        Me.ucrInputToTemperature.Name = "ucrInputToTemperature"
        '
        'ucrInputFromWindSpeed
        '
        Me.ucrInputFromWindSpeed.AddQuotesIfUnrecognised = True
        Me.ucrInputFromWindSpeed.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFromWindSpeed, "ucrInputFromWindSpeed")
        Me.ucrInputFromWindSpeed.Name = "ucrInputFromWindSpeed"
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
        'ucrInputToPrecipitation
        '
        Me.ucrInputToPrecipitation.AddQuotesIfUnrecognised = True
        Me.ucrInputToPrecipitation.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputToPrecipitation, "ucrInputToPrecipitation")
        Me.ucrInputToPrecipitation.Name = "ucrInputToPrecipitation"
        '
        'ucrInputFromPrecipitation
        '
        Me.ucrInputFromPrecipitation.AddQuotesIfUnrecognised = True
        Me.ucrInputFromPrecipitation.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFromPrecipitation, "ucrInputFromPrecipitation")
        Me.ucrInputFromPrecipitation.Name = "ucrInputFromPrecipitation"
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
        'ucrPnlElements
        '
        resources.ApplyResources(Me.ucrPnlElements, "ucrPnlElements")
        Me.ucrPnlElements.Name = "ucrPnlElements"
        '
        'dlgConversions
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpLatitude)
        Me.Controls.Add(Me.ucrInputFromTemperature)
        Me.Controls.Add(Me.ucrInputToWindSpeed)
        Me.Controls.Add(Me.ucrInputToTemperature)
        Me.Controls.Add(Me.ucrInputFromWindSpeed)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.lblDecimal)
        Me.Controls.Add(Me.ucrNudDecimal)
        Me.Controls.Add(Me.ucrSaveConversions)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.ucrInputToPrecipitation)
        Me.Controls.Add(Me.ucrInputFromPrecipitation)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.ucrReceiverElement)
        Me.Controls.Add(Me.rdoDayLength)
        Me.Controls.Add(Me.rdoUnits)
        Me.Controls.Add(Me.ucrPnlConversions)
        Me.Controls.Add(Me.ucrSelectorConversions)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpElements)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgConversions"
        Me.grpLatitude.ResumeLayout(False)
        Me.grpLatitude.PerformLayout()
        Me.grpElements.ResumeLayout(False)
        Me.grpElements.PerformLayout()
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
    Friend WithEvents ucrInputToPrecipitation As ucrInputComboBox
    Friend WithEvents ucrInputFromPrecipitation As ucrInputComboBox
    Friend WithEvents lblDecimal As Label
    Friend WithEvents ucrNudDecimal As ucrNud
    Friend WithEvents ucrSaveConversions As ucrSave
    Friend WithEvents lblDate As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents rdoColumn As RadioButton
    Friend WithEvents rdoSingleValue As RadioButton
    Friend WithEvents ucrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents ucrInputLatitude As ucrInputTextBox
    Friend WithEvents ucrPnlLatitude As UcrPanel
    Friend WithEvents ucrInputFromTemperature As ucrInputComboBox
    Friend WithEvents ucrInputToWindSpeed As ucrInputComboBox
    Friend WithEvents ucrInputToTemperature As ucrInputComboBox
    Friend WithEvents ucrInputFromWindSpeed As ucrInputComboBox
    Friend WithEvents grpLatitude As GroupBox
    Friend WithEvents grpElements As GroupBox
    Friend WithEvents rdoWindSpeed As RadioButton
    Friend WithEvents rdoRain As RadioButton
    Friend WithEvents rdoTemperature As RadioButton
    Friend WithEvents ucrPnlElements As UcrPanel
End Class
