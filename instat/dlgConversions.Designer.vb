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
        Me.rdoCoordinates = New System.Windows.Forms.RadioButton()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.lblDegrees = New System.Windows.Forms.Label()
        Me.lblDirection = New System.Windows.Forms.Label()
        Me.rdoYear = New System.Windows.Forms.RadioButton()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblBaseYear = New System.Windows.Forms.Label()
        Me.ucrNudBaseYear = New instat.ucrNud()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrSaveColumn = New instat.ucrSave()
        Me.ucrInputDirection = New instat.ucrInputComboBox()
        Me.ucrChkVariable = New instat.ucrCheck()
        Me.ucrInputSecond = New instat.ucrInputTextBox()
        Me.ucrReceiverLetters = New instat.ucrReceiverSingle()
        Me.ucrSaveConversions = New instat.ucrSave()
        Me.ucrReceiverDegrees = New instat.ucrReceiverSingle()
        Me.ucrReceiverSeconds = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrPnlConversions = New instat.UcrPanel()
        Me.ucrSelectorConversions = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrNudDecimal = New instat.ucrNud()
        Me.ucrInputToTemperature = New instat.ucrInputComboBox()
        Me.ucrPnlElements = New instat.UcrPanel()
        Me.ucrInputFromPrecipitation = New instat.ucrInputComboBox()
        Me.ucrInputToPrecipitation = New instat.ucrInputComboBox()
        Me.ucrInputToWindSpeed = New instat.ucrInputComboBox()
        Me.ucrInputFromTemperature = New instat.ucrInputComboBox()
        Me.ucrInputFromWindSpeed = New instat.ucrInputComboBox()
        Me.ucrInputMinute = New instat.ucrInputTextBox()
        Me.ucrReceiverMinutes = New instat.ucrReceiverSingle()
        Me.ucrInputLatitude = New instat.ucrInputTextBox()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.ucrPnlLatitude = New instat.UcrPanel()
        Me.ucrInputDegree = New instat.ucrInputTextBox()
        Me.grpLatitude.SuspendLayout()
        Me.grpElements.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoDayLength
        '
        Me.rdoDayLength.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDayLength.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoDayLength.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDayLength.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDayLength.FlatAppearance.BorderSize = 2
        Me.rdoDayLength.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDayLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDayLength.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoDayLength.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDayLength.Location = New System.Drawing.Point(98, 21)
        Me.rdoDayLength.Name = "rdoDayLength"
        Me.rdoDayLength.Size = New System.Drawing.Size(119, 28)
        Me.rdoDayLength.TabIndex = 2
        Me.rdoDayLength.Text = "Day Length"
        Me.rdoDayLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDayLength.UseVisualStyleBackColor = True
        '
        'rdoUnits
        '
        Me.rdoUnits.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoUnits.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoUnits.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoUnits.FlatAppearance.BorderSize = 2
        Me.rdoUnits.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoUnits.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoUnits.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoUnits.Location = New System.Drawing.Point(9, 21)
        Me.rdoUnits.Name = "rdoUnits"
        Me.rdoUnits.Size = New System.Drawing.Size(90, 28)
        Me.rdoUnits.TabIndex = 1
        Me.rdoUnits.Text = "Units"
        Me.rdoUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoUnits.UseVisualStyleBackColor = True
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElement.Location = New System.Drawing.Point(262, 91)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(48, 13)
        Me.lblElement.TabIndex = 4
        Me.lblElement.Text = "Element:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFrom.Location = New System.Drawing.Point(6, 59)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 15
        Me.lblFrom.Text = "From:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTo.Location = New System.Drawing.Point(163, 59)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 17
        Me.lblTo.Text = "To:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(265, 91)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "Date:"
        '
        'rdoColumn
        '
        Me.rdoColumn.AutoSize = True
        Me.rdoColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoColumn.Location = New System.Drawing.Point(7, 61)
        Me.rdoColumn.Name = "rdoColumn"
        Me.rdoColumn.Size = New System.Drawing.Size(63, 17)
        Me.rdoColumn.TabIndex = 28
        Me.rdoColumn.TabStop = True
        Me.rdoColumn.Text = "Column:"
        Me.rdoColumn.UseVisualStyleBackColor = True
        '
        'rdoSingleValue
        '
        Me.rdoSingleValue.AutoSize = True
        Me.rdoSingleValue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSingleValue.Location = New System.Drawing.Point(7, 34)
        Me.rdoSingleValue.Name = "rdoSingleValue"
        Me.rdoSingleValue.Size = New System.Drawing.Size(87, 17)
        Me.rdoSingleValue.TabIndex = 27
        Me.rdoSingleValue.TabStop = True
        Me.rdoSingleValue.Text = "Single Value:"
        Me.rdoSingleValue.UseVisualStyleBackColor = True
        '
        'grpLatitude
        '
        Me.grpLatitude.Controls.Add(Me.ucrInputLatitude)
        Me.grpLatitude.Controls.Add(Me.ucrReceiverLatitude)
        Me.grpLatitude.Controls.Add(Me.rdoColumn)
        Me.grpLatitude.Controls.Add(Me.rdoSingleValue)
        Me.grpLatitude.Controls.Add(Me.ucrPnlLatitude)
        Me.grpLatitude.Location = New System.Drawing.Point(10, 288)
        Me.grpLatitude.Name = "grpLatitude"
        Me.grpLatitude.Size = New System.Drawing.Size(248, 100)
        Me.grpLatitude.TabIndex = 15
        Me.grpLatitude.TabStop = False
        Me.grpLatitude.Text = "Latitude"
        '
        'grpElements
        '
        Me.grpElements.Controls.Add(Me.lblDecimal)
        Me.grpElements.Controls.Add(Me.ucrNudDecimal)
        Me.grpElements.Controls.Add(Me.rdoWindSpeed)
        Me.grpElements.Controls.Add(Me.rdoRain)
        Me.grpElements.Controls.Add(Me.rdoTemperature)
        Me.grpElements.Controls.Add(Me.ucrPnlElements)
        Me.grpElements.Controls.Add(Me.lblFrom)
        Me.grpElements.Controls.Add(Me.ucrInputToPrecipitation)
        Me.grpElements.Controls.Add(Me.lblTo)
        Me.grpElements.Controls.Add(Me.ucrInputToWindSpeed)
        Me.grpElements.Controls.Add(Me.ucrInputToTemperature)
        Me.grpElements.Controls.Add(Me.ucrInputFromPrecipitation)
        Me.grpElements.Controls.Add(Me.ucrInputFromTemperature)
        Me.grpElements.Controls.Add(Me.ucrInputFromWindSpeed)
        Me.grpElements.Location = New System.Drawing.Point(10, 289)
        Me.grpElements.Name = "grpElements"
        Me.grpElements.Size = New System.Drawing.Size(408, 116)
        Me.grpElements.TabIndex = 14
        Me.grpElements.TabStop = False
        Me.grpElements.Text = "Elements"
        '
        'lblDecimal
        '
        Me.lblDecimal.AutoSize = True
        Me.lblDecimal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDecimal.Location = New System.Drawing.Point(309, 78)
        Me.lblDecimal.Name = "lblDecimal"
        Me.lblDecimal.Size = New System.Drawing.Size(45, 13)
        Me.lblDecimal.TabIndex = 1
        Me.lblDecimal.Text = "Decimal"
        '
        'rdoWindSpeed
        '
        Me.rdoWindSpeed.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoWindSpeed.BackColor = System.Drawing.SystemColors.Control
        Me.rdoWindSpeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoWindSpeed.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoWindSpeed.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWindSpeed.FlatAppearance.BorderSize = 2
        Me.rdoWindSpeed.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWindSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoWindSpeed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoWindSpeed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoWindSpeed.Location = New System.Drawing.Point(225, 17)
        Me.rdoWindSpeed.Name = "rdoWindSpeed"
        Me.rdoWindSpeed.Size = New System.Drawing.Size(110, 28)
        Me.rdoWindSpeed.TabIndex = 0
        Me.rdoWindSpeed.Text = "Wind Speed"
        Me.rdoWindSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoWindSpeed.UseVisualStyleBackColor = True
        '
        'rdoRain
        '
        Me.rdoRain.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRain.BackColor = System.Drawing.SystemColors.Control
        Me.rdoRain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoRain.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRain.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRain.FlatAppearance.BorderSize = 2
        Me.rdoRain.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoRain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRain.Location = New System.Drawing.Point(76, 17)
        Me.rdoRain.Name = "rdoRain"
        Me.rdoRain.Size = New System.Drawing.Size(62, 28)
        Me.rdoRain.TabIndex = 15
        Me.rdoRain.Text = "Rain"
        Me.rdoRain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRain.UseVisualStyleBackColor = True
        '
        'rdoTemperature
        '
        Me.rdoTemperature.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTemperature.BackColor = System.Drawing.SystemColors.Control
        Me.rdoTemperature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoTemperature.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTemperature.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTemperature.FlatAppearance.BorderSize = 2
        Me.rdoTemperature.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTemperature.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTemperature.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoTemperature.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTemperature.Location = New System.Drawing.Point(136, 17)
        Me.rdoTemperature.Name = "rdoTemperature"
        Me.rdoTemperature.Size = New System.Drawing.Size(91, 28)
        Me.rdoTemperature.TabIndex = 16
        Me.rdoTemperature.Text = "Temperature"
        Me.rdoTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTemperature.UseVisualStyleBackColor = True
        '
        'rdoCoordinates
        '
        Me.rdoCoordinates.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoCoordinates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoCoordinates.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoCoordinates.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCoordinates.FlatAppearance.BorderSize = 2
        Me.rdoCoordinates.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCoordinates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCoordinates.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoCoordinates.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCoordinates.Location = New System.Drawing.Point(215, 21)
        Me.rdoCoordinates.Name = "rdoCoordinates"
        Me.rdoCoordinates.Size = New System.Drawing.Size(109, 28)
        Me.rdoCoordinates.TabIndex = 3
        Me.rdoCoordinates.Text = "Coordinates"
        Me.rdoCoordinates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoCoordinates.UseVisualStyleBackColor = True
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMinutes.Location = New System.Drawing.Point(263, 136)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(47, 13)
        Me.lblMinutes.TabIndex = 9
        Me.lblMinutes.Text = "Minutes:"
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSeconds.Location = New System.Drawing.Point(262, 179)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(52, 13)
        Me.lblSeconds.TabIndex = 11
        Me.lblSeconds.Text = "Seconds:"
        '
        'lblDegrees
        '
        Me.lblDegrees.AutoSize = True
        Me.lblDegrees.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDegrees.Location = New System.Drawing.Point(262, 93)
        Me.lblDegrees.Name = "lblDegrees"
        Me.lblDegrees.Size = New System.Drawing.Size(50, 13)
        Me.lblDegrees.TabIndex = 7
        Me.lblDegrees.Text = "Degrees:"
        '
        'lblDirection
        '
        Me.lblDirection.AutoSize = True
        Me.lblDirection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDirection.Location = New System.Drawing.Point(265, 223)
        Me.lblDirection.Name = "lblDirection"
        Me.lblDirection.Size = New System.Drawing.Size(52, 13)
        Me.lblDirection.TabIndex = 24
        Me.lblDirection.Text = "Direction:"
        '
        'rdoYear
        '
        Me.rdoYear.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoYear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoYear.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoYear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYear.FlatAppearance.BorderSize = 2
        Me.rdoYear.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoYear.Location = New System.Drawing.Point(323, 21)
        Me.rdoYear.Name = "rdoYear"
        Me.rdoYear.Size = New System.Drawing.Size(101, 28)
        Me.rdoYear.TabIndex = 27
        Me.rdoYear.Text = "Year"
        Me.rdoYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoYear.UseVisualStyleBackColor = True
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYear.Location = New System.Drawing.Point(265, 93)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 29
        Me.lblYear.Text = "Year:"
        '
        'lblBaseYear
        '
        Me.lblBaseYear.AutoSize = True
        Me.lblBaseYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBaseYear.Location = New System.Drawing.Point(265, 136)
        Me.lblBaseYear.Name = "lblBaseYear"
        Me.lblBaseYear.Size = New System.Drawing.Size(59, 13)
        Me.lblBaseYear.TabIndex = 31
        Me.lblBaseYear.Text = "Base Year:"
        '
        'ucrNudBaseYear
        '
        Me.ucrNudBaseYear.AutoSize = True
        Me.ucrNudBaseYear.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBaseYear.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBaseYear.Location = New System.Drawing.Point(265, 152)
        Me.ucrNudBaseYear.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBaseYear.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBaseYear.Name = "ucrNudBaseYear"
        Me.ucrNudBaseYear.Size = New System.Drawing.Size(64, 20)
        Me.ucrNudBaseYear.TabIndex = 30
        Me.ucrNudBaseYear.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(265, 109)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 28
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrSaveColumn
        '
        Me.ucrSaveColumn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveColumn.Location = New System.Drawing.Point(9, 413)
        Me.ucrSaveColumn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveColumn.Name = "ucrSaveColumn"
        Me.ucrSaveColumn.Size = New System.Drawing.Size(320, 22)
        Me.ucrSaveColumn.TabIndex = 25
        '
        'ucrInputDirection
        '
        Me.ucrInputDirection.AddQuotesIfUnrecognised = True
        Me.ucrInputDirection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDirection.GetSetSelectedIndex = -1
        Me.ucrInputDirection.IsReadOnly = False
        Me.ucrInputDirection.Location = New System.Drawing.Point(265, 239)
        Me.ucrInputDirection.Name = "ucrInputDirection"
        Me.ucrInputDirection.Size = New System.Drawing.Size(86, 21)
        Me.ucrInputDirection.TabIndex = 23
        '
        'ucrChkVariable
        '
        Me.ucrChkVariable.AutoSize = True
        Me.ucrChkVariable.Checked = False
        Me.ucrChkVariable.Location = New System.Drawing.Point(265, 69)
        Me.ucrChkVariable.Name = "ucrChkVariable"
        Me.ucrChkVariable.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkVariable.TabIndex = 6
        '
        'ucrInputSecond
        '
        Me.ucrInputSecond.AddQuotesIfUnrecognised = True
        Me.ucrInputSecond.AutoSize = True
        Me.ucrInputSecond.IsMultiline = False
        Me.ucrInputSecond.IsReadOnly = False
        Me.ucrInputSecond.Location = New System.Drawing.Point(265, 195)
        Me.ucrInputSecond.Name = "ucrInputSecond"
        Me.ucrInputSecond.Size = New System.Drawing.Size(120, 20)
        Me.ucrInputSecond.TabIndex = 12
        '
        'ucrReceiverLetters
        '
        Me.ucrReceiverLetters.AutoSize = True
        Me.ucrReceiverLetters.frmParent = Me
        Me.ucrReceiverLetters.Location = New System.Drawing.Point(353, 239)
        Me.ucrReceiverLetters.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLetters.Name = "ucrReceiverLetters"
        Me.ucrReceiverLetters.Selector = Nothing
        Me.ucrReceiverLetters.Size = New System.Drawing.Size(81, 21)
        Me.ucrReceiverLetters.strNcFilePath = ""
        Me.ucrReceiverLetters.TabIndex = 6
        Me.ucrReceiverLetters.ucrSelector = Nothing
        '
        'ucrSaveConversions
        '
        Me.ucrSaveConversions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveConversions.Location = New System.Drawing.Point(9, 413)
        Me.ucrSaveConversions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveConversions.Name = "ucrSaveConversions"
        Me.ucrSaveConversions.Size = New System.Drawing.Size(320, 22)
        Me.ucrSaveConversions.TabIndex = 16
        '
        'ucrReceiverDegrees
        '
        Me.ucrReceiverDegrees.AutoSize = True
        Me.ucrReceiverDegrees.frmParent = Me
        Me.ucrReceiverDegrees.Location = New System.Drawing.Point(265, 109)
        Me.ucrReceiverDegrees.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDegrees.Name = "ucrReceiverDegrees"
        Me.ucrReceiverDegrees.Selector = Nothing
        Me.ucrReceiverDegrees.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDegrees.strNcFilePath = ""
        Me.ucrReceiverDegrees.TabIndex = 9
        Me.ucrReceiverDegrees.ucrSelector = Nothing
        '
        'ucrReceiverSeconds
        '
        Me.ucrReceiverSeconds.AutoSize = True
        Me.ucrReceiverSeconds.frmParent = Me
        Me.ucrReceiverSeconds.Location = New System.Drawing.Point(265, 195)
        Me.ucrReceiverSeconds.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSeconds.Name = "ucrReceiverSeconds"
        Me.ucrReceiverSeconds.Selector = Nothing
        Me.ucrReceiverSeconds.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSeconds.strNcFilePath = ""
        Me.ucrReceiverSeconds.TabIndex = 12
        Me.ucrReceiverSeconds.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(265, 109)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 9
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.AutoSize = True
        Me.ucrReceiverElement.frmParent = Me
        Me.ucrReceiverElement.Location = New System.Drawing.Point(265, 109)
        Me.ucrReceiverElement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.TabIndex = 5
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'ucrPnlConversions
        '
        Me.ucrPnlConversions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlConversions.Location = New System.Drawing.Point(1, 21)
        Me.ucrPnlConversions.Name = "ucrPnlConversions"
        Me.ucrPnlConversions.Size = New System.Drawing.Size(423, 28)
        Me.ucrPnlConversions.TabIndex = 0
        '
        'ucrSelectorConversions
        '
        Me.ucrSelectorConversions.AutoSize = True
        Me.ucrSelectorConversions.bDropUnusedFilterLevels = False
        Me.ucrSelectorConversions.bShowHiddenColumns = False
        Me.ucrSelectorConversions.bUseCurrentFilter = True
        Me.ucrSelectorConversions.Location = New System.Drawing.Point(9, 68)
        Me.ucrSelectorConversions.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorConversions.Name = "ucrSelectorConversions"
        Me.ucrSelectorConversions.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorConversions.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 447)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 17
        '
        'ucrNudDecimal
        '
        Me.ucrNudDecimal.AutoSize = True
        Me.ucrNudDecimal.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimal.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDecimal.Location = New System.Drawing.Point(364, 75)
        Me.ucrNudDecimal.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDecimal.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimal.Name = "ucrNudDecimal"
        Me.ucrNudDecimal.Size = New System.Drawing.Size(39, 20)
        Me.ucrNudDecimal.TabIndex = 2
        Me.ucrNudDecimal.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputToTemperature
        '
        Me.ucrInputToTemperature.AddQuotesIfUnrecognised = True
        Me.ucrInputToTemperature.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputToTemperature.GetSetSelectedIndex = -1
        Me.ucrInputToTemperature.IsReadOnly = False
        Me.ucrInputToTemperature.Location = New System.Drawing.Point(167, 75)
        Me.ucrInputToTemperature.Name = "ucrInputToTemperature"
        Me.ucrInputToTemperature.Size = New System.Drawing.Size(140, 24)
        Me.ucrInputToTemperature.TabIndex = 20
        '
        'ucrPnlElements
        '
        Me.ucrPnlElements.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlElements.Location = New System.Drawing.Point(72, 12)
        Me.ucrPnlElements.Name = "ucrPnlElements"
        Me.ucrPnlElements.Size = New System.Drawing.Size(269, 40)
        Me.ucrPnlElements.TabIndex = 11
        '
        'ucrInputFromPrecipitation
        '
        Me.ucrInputFromPrecipitation.AddQuotesIfUnrecognised = True
        Me.ucrInputFromPrecipitation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFromPrecipitation.GetSetSelectedIndex = -1
        Me.ucrInputFromPrecipitation.IsReadOnly = False
        Me.ucrInputFromPrecipitation.Location = New System.Drawing.Point(9, 75)
        Me.ucrInputFromPrecipitation.Name = "ucrInputFromPrecipitation"
        Me.ucrInputFromPrecipitation.Size = New System.Drawing.Size(152, 24)
        Me.ucrInputFromPrecipitation.TabIndex = 16
        '
        'ucrInputToPrecipitation
        '
        Me.ucrInputToPrecipitation.AddQuotesIfUnrecognised = True
        Me.ucrInputToPrecipitation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputToPrecipitation.GetSetSelectedIndex = -1
        Me.ucrInputToPrecipitation.IsReadOnly = False
        Me.ucrInputToPrecipitation.Location = New System.Drawing.Point(166, 75)
        Me.ucrInputToPrecipitation.Name = "ucrInputToPrecipitation"
        Me.ucrInputToPrecipitation.Size = New System.Drawing.Size(141, 31)
        Me.ucrInputToPrecipitation.TabIndex = 18
        '
        'ucrInputToWindSpeed
        '
        Me.ucrInputToWindSpeed.AddQuotesIfUnrecognised = True
        Me.ucrInputToWindSpeed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputToWindSpeed.GetSetSelectedIndex = -1
        Me.ucrInputToWindSpeed.IsReadOnly = False
        Me.ucrInputToWindSpeed.Location = New System.Drawing.Point(166, 75)
        Me.ucrInputToWindSpeed.Name = "ucrInputToWindSpeed"
        Me.ucrInputToWindSpeed.Size = New System.Drawing.Size(141, 31)
        Me.ucrInputToWindSpeed.TabIndex = 22
        '
        'ucrInputFromTemperature
        '
        Me.ucrInputFromTemperature.AddQuotesIfUnrecognised = True
        Me.ucrInputFromTemperature.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFromTemperature.GetSetSelectedIndex = -1
        Me.ucrInputFromTemperature.IsReadOnly = False
        Me.ucrInputFromTemperature.Location = New System.Drawing.Point(9, 75)
        Me.ucrInputFromTemperature.Name = "ucrInputFromTemperature"
        Me.ucrInputFromTemperature.Size = New System.Drawing.Size(152, 24)
        Me.ucrInputFromTemperature.TabIndex = 19
        '
        'ucrInputFromWindSpeed
        '
        Me.ucrInputFromWindSpeed.AddQuotesIfUnrecognised = True
        Me.ucrInputFromWindSpeed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFromWindSpeed.GetSetSelectedIndex = -1
        Me.ucrInputFromWindSpeed.IsReadOnly = False
        Me.ucrInputFromWindSpeed.Location = New System.Drawing.Point(9, 75)
        Me.ucrInputFromWindSpeed.Name = "ucrInputFromWindSpeed"
        Me.ucrInputFromWindSpeed.Size = New System.Drawing.Size(152, 24)
        Me.ucrInputFromWindSpeed.TabIndex = 21
        '
        'ucrInputMinute
        '
        Me.ucrInputMinute.AddQuotesIfUnrecognised = True
        Me.ucrInputMinute.AutoSize = True
        Me.ucrInputMinute.IsMultiline = False
        Me.ucrInputMinute.IsReadOnly = False
        Me.ucrInputMinute.Location = New System.Drawing.Point(265, 152)
        Me.ucrInputMinute.Name = "ucrInputMinute"
        Me.ucrInputMinute.Size = New System.Drawing.Size(120, 20)
        Me.ucrInputMinute.TabIndex = 10
        '
        'ucrReceiverMinutes
        '
        Me.ucrReceiverMinutes.AutoSize = True
        Me.ucrReceiverMinutes.frmParent = Me
        Me.ucrReceiverMinutes.Location = New System.Drawing.Point(265, 152)
        Me.ucrReceiverMinutes.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMinutes.Name = "ucrReceiverMinutes"
        Me.ucrReceiverMinutes.Selector = Nothing
        Me.ucrReceiverMinutes.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMinutes.strNcFilePath = ""
        Me.ucrReceiverMinutes.TabIndex = 10
        Me.ucrReceiverMinutes.ucrSelector = Nothing
        '
        'ucrInputLatitude
        '
        Me.ucrInputLatitude.AddQuotesIfUnrecognised = True
        Me.ucrInputLatitude.AutoSize = True
        Me.ucrInputLatitude.IsMultiline = False
        Me.ucrInputLatitude.IsReadOnly = False
        Me.ucrInputLatitude.Location = New System.Drawing.Point(100, 34)
        Me.ucrInputLatitude.Name = "ucrInputLatitude"
        Me.ucrInputLatitude.Size = New System.Drawing.Size(67, 21)
        Me.ucrInputLatitude.TabIndex = 27
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.AutoSize = True
        Me.ucrReceiverLatitude.frmParent = Nothing
        Me.ucrReceiverLatitude.Location = New System.Drawing.Point(100, 61)
        Me.ucrReceiverLatitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.Size = New System.Drawing.Size(138, 20)
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.TabIndex = 29
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrPnlLatitude
        '
        Me.ucrPnlLatitude.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlLatitude.Location = New System.Drawing.Point(7, 34)
        Me.ucrPnlLatitude.Name = "ucrPnlLatitude"
        Me.ucrPnlLatitude.Size = New System.Drawing.Size(87, 48)
        Me.ucrPnlLatitude.TabIndex = 26
        '
        'ucrInputDegree
        '
        Me.ucrInputDegree.AddQuotesIfUnrecognised = True
        Me.ucrInputDegree.AutoSize = True
        Me.ucrInputDegree.IsMultiline = False
        Me.ucrInputDegree.IsReadOnly = False
        Me.ucrInputDegree.Location = New System.Drawing.Point(265, 109)
        Me.ucrInputDegree.Name = "ucrInputDegree"
        Me.ucrInputDegree.Size = New System.Drawing.Size(120, 20)
        Me.ucrInputDegree.TabIndex = 8
        '
        'dlgConversions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(436, 503)
        Me.Controls.Add(Me.lblBaseYear)
        Me.Controls.Add(Me.ucrNudBaseYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.rdoYear)
        Me.Controls.Add(Me.ucrSaveColumn)
        Me.Controls.Add(Me.lblDirection)
        Me.Controls.Add(Me.ucrInputDirection)
        Me.Controls.Add(Me.ucrChkVariable)
        Me.Controls.Add(Me.ucrInputSecond)
        Me.Controls.Add(Me.ucrReceiverLetters)
        Me.Controls.Add(Me.ucrSaveConversions)
        Me.Controls.Add(Me.lblDegrees)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.lblMinutes)
        Me.Controls.Add(Me.ucrReceiverDegrees)
        Me.Controls.Add(Me.ucrReceiverSeconds)
        Me.Controls.Add(Me.rdoCoordinates)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.ucrReceiverElement)
        Me.Controls.Add(Me.rdoDayLength)
        Me.Controls.Add(Me.rdoUnits)
        Me.Controls.Add(Me.ucrPnlConversions)
        Me.Controls.Add(Me.ucrSelectorConversions)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpElements)
        Me.Controls.Add(Me.ucrInputMinute)
        Me.Controls.Add(Me.ucrReceiverMinutes)
        Me.Controls.Add(Me.grpLatitude)
        Me.Controls.Add(Me.ucrInputDegree)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgConversions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conversions"
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
    Friend WithEvents rdoCoordinates As RadioButton
    Friend WithEvents lblSeconds As Label
    Friend WithEvents lblMinutes As Label
    Friend WithEvents ucrReceiverDegrees As ucrReceiverSingle
    Friend WithEvents ucrReceiverMinutes As ucrReceiverSingle
    Friend WithEvents ucrReceiverSeconds As ucrReceiverSingle
    Friend WithEvents ucrReceiverLetters As ucrReceiverSingle
    Friend WithEvents lblDegrees As Label
    Friend WithEvents ucrSaveConversions As ucrSave
    Friend WithEvents ucrInputDegree As ucrInputTextBox
    Friend WithEvents ucrInputSecond As ucrInputTextBox
    Friend WithEvents ucrInputMinute As ucrInputTextBox
    Friend WithEvents ucrChkVariable As ucrCheck
    Friend WithEvents lblDirection As Label
    Friend WithEvents ucrInputDirection As ucrInputComboBox
    Friend WithEvents ucrSaveColumn As ucrSave
    Friend WithEvents lblBaseYear As Label
    Friend WithEvents ucrNudBaseYear As ucrNud
    Friend WithEvents lblYear As Label
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents rdoYear As RadioButton
End Class