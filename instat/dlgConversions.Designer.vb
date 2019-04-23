﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgConversions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgConversions))
        Me.rdoDayLength = New System.Windows.Forms.RadioButton()
        Me.rdoUnits = New System.Windows.Forms.RadioButton()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.rdoColumn = New System.Windows.Forms.RadioButton()
        Me.rdoSingleValue = New System.Windows.Forms.RadioButton()
        Me.grpLatitude = New System.Windows.Forms.GroupBox()
        Me.grpElements = New System.Windows.Forms.GroupBox()
        Me.lblDecimal = New System.Windows.Forms.Label()
        Me.rdoWindSpeed = New System.Windows.Forms.RadioButton()
        Me.rdoRain = New System.Windows.Forms.RadioButton()
        Me.rdoTemperature = New System.Windows.Forms.RadioButton()
        Me.ucrInputLatitude = New instat.ucrInputTextBox()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.ucrPnlLatitude = New instat.UcrPanel()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrSaveConversions = New instat.ucrSave()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrPnlConversions = New instat.UcrPanel()
        Me.ucrSelectorConversions = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrNudDecimal = New instat.ucrNud()
        Me.ucrInputFromTemperature = New instat.ucrInputComboBox()
        Me.ucrInputToWindSpeed = New instat.ucrInputComboBox()
        Me.ucrInputToTemperature = New instat.ucrInputComboBox()
        Me.ucrPnlElements = New instat.UcrPanel()
        Me.ucrInputFromWindSpeed = New instat.ucrInputComboBox()
        Me.ucrInputFromPrecipitation = New instat.ucrInputComboBox()
        Me.ucrInputToPrecipitation = New instat.ucrInputComboBox()
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
        'lblDate
        '
        resources.ApplyResources(Me.lblDate, "lblDate")
        Me.lblDate.Name = "lblDate"
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
        'grpElements
        '
        Me.grpElements.Controls.Add(Me.lblDecimal)
        Me.grpElements.Controls.Add(Me.ucrNudDecimal)
        Me.grpElements.Controls.Add(Me.rdoWindSpeed)
        Me.grpElements.Controls.Add(Me.ucrInputFromTemperature)
        Me.grpElements.Controls.Add(Me.rdoRain)
        Me.grpElements.Controls.Add(Me.ucrInputToWindSpeed)
        Me.grpElements.Controls.Add(Me.rdoTemperature)
        Me.grpElements.Controls.Add(Me.ucrInputToTemperature)
        Me.grpElements.Controls.Add(Me.ucrPnlElements)
        Me.grpElements.Controls.Add(Me.ucrInputFromWindSpeed)
        Me.grpElements.Controls.Add(Me.lblFrom)
        Me.grpElements.Controls.Add(Me.ucrInputFromPrecipitation)
        Me.grpElements.Controls.Add(Me.ucrInputToPrecipitation)
        Me.grpElements.Controls.Add(Me.lblTo)
        resources.ApplyResources(Me.grpElements, "grpElements")
        Me.grpElements.Name = "grpElements"
        Me.grpElements.TabStop = False
        '
        'lblDecimal
        '
        resources.ApplyResources(Me.lblDecimal, "lblDecimal")
        Me.lblDecimal.Name = "lblDecimal"
        '
        'rdoWindSpeed
        '
        resources.ApplyResources(Me.rdoWindSpeed, "rdoWindSpeed")
        Me.rdoWindSpeed.BackColor = System.Drawing.SystemColors.Control
        Me.rdoWindSpeed.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWindSpeed.FlatAppearance.BorderSize = 2
        Me.rdoWindSpeed.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWindSpeed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoWindSpeed.Name = "rdoWindSpeed"
        Me.rdoWindSpeed.UseVisualStyleBackColor = True
        '
        'rdoRain
        '
        resources.ApplyResources(Me.rdoRain, "rdoRain")
        Me.rdoRain.BackColor = System.Drawing.SystemColors.Control
        Me.rdoRain.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRain.FlatAppearance.BorderSize = 2
        Me.rdoRain.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoRain.Name = "rdoRain"
        Me.rdoRain.UseVisualStyleBackColor = True
        '
        'rdoTemperature
        '
        resources.ApplyResources(Me.rdoTemperature, "rdoTemperature")
        Me.rdoTemperature.BackColor = System.Drawing.SystemColors.Control
        Me.rdoTemperature.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTemperature.FlatAppearance.BorderSize = 2
        Me.rdoTemperature.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTemperature.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoTemperature.Name = "rdoTemperature"
        Me.rdoTemperature.UseVisualStyleBackColor = True
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
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDate, "ucrReceiverDate")
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrSaveConversions
        '
        resources.ApplyResources(Me.ucrSaveConversions, "ucrSaveConversions")
        Me.ucrSaveConversions.Name = "ucrSaveConversions"
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
        'ucrPnlElements
        '
        resources.ApplyResources(Me.ucrPnlElements, "ucrPnlElements")
        Me.ucrPnlElements.Name = "ucrPnlElements"
        '
        'ucrInputFromWindSpeed
        '
        Me.ucrInputFromWindSpeed.AddQuotesIfUnrecognised = True
        Me.ucrInputFromWindSpeed.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFromWindSpeed, "ucrInputFromWindSpeed")
        Me.ucrInputFromWindSpeed.Name = "ucrInputFromWindSpeed"
        '
        'ucrInputFromPrecipitation
        '
        Me.ucrInputFromPrecipitation.AddQuotesIfUnrecognised = True
        Me.ucrInputFromPrecipitation.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFromPrecipitation, "ucrInputFromPrecipitation")
        Me.ucrInputFromPrecipitation.Name = "ucrInputFromPrecipitation"
        '
        'ucrInputToPrecipitation
        '
        Me.ucrInputToPrecipitation.AddQuotesIfUnrecognised = True
        Me.ucrInputToPrecipitation.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputToPrecipitation, "ucrInputToPrecipitation")
        Me.ucrInputToPrecipitation.Name = "ucrInputToPrecipitation"
        '
        'dlgConversions
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpLatitude)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrSaveConversions)
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
    Friend WithEvents ucrSaveConversions As ucrSave
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
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
    Friend WithEvents ucrPnlElements As UcrPanel
    Friend WithEvents rdoWindSpeed As RadioButton
    Friend WithEvents rdoRain As RadioButton
    Friend WithEvents rdoTemperature As RadioButton
    Friend WithEvents lblDecimal As Label
    Friend WithEvents ucrNudDecimal As ucrNud
End Class