<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgTidyDailyData
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
        Me.lblColumnPer = New System.Windows.Forms.Label()
        Me.rdoDay = New System.Windows.Forms.RadioButton()
        Me.rdoMonth = New System.Windows.Forms.RadioButton()
        Me.rdoYear = New System.Windows.Forms.RadioButton()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDayofMonth = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblElementName = New System.Windows.Forms.Label()
        Me.lblColumnstoStack = New System.Windows.Forms.Label()
        Me.lblMultipleElement = New System.Windows.Forms.Label()
        Me.grpElements = New System.Windows.Forms.GroupBox()
        Me.ucrChkUnstackElements = New instat.ucrCheck()
        Me.lblOr = New System.Windows.Forms.Label()
        Me.ucrTextBoxElementName = New instat.ucrInputTextBox()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkIgnoreInvalid = New instat.ucrCheck()
        Me.ucrChkSilent = New instat.ucrCheck()
        Me.lblNewDataFrameName = New System.Windows.Forms.Label()
        Me.ttReshapeType = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblNColumns = New System.Windows.Forms.Label()
        Me.ucrInputNewDataFrame = New instat.ucrInputTextBox()
        Me.ucrReceiverMultipleStack = New instat.ucrReceiverMultiple()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverDayofMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrPnlReshapeClimaticData = New instat.UcrPanel()
        Me.ucrSelectorTidyDailyData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpElements.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColumnPer
        '
        Me.lblColumnPer.AutoSize = True
        Me.lblColumnPer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumnPer.Location = New System.Drawing.Point(33, 10)
        Me.lblColumnPer.Name = "lblColumnPer"
        Me.lblColumnPer.Size = New System.Drawing.Size(0, 13)
        Me.lblColumnPer.TabIndex = 2
        '
        'rdoDay
        '
        Me.rdoDay.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDay.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDay.FlatAppearance.BorderSize = 2
        Me.rdoDay.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDay.Location = New System.Drawing.Point(262, 17)
        Me.rdoDay.Name = "rdoDay"
        Me.rdoDay.Size = New System.Drawing.Size(145, 27)
        Me.rdoDay.TabIndex = 3
        Me.rdoDay.TabStop = True
        Me.rdoDay.Text = "Day Columns (31/62)"
        Me.rdoDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDay.UseVisualStyleBackColor = True
        '
        'rdoMonth
        '
        Me.rdoMonth.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMonth.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMonth.FlatAppearance.BorderSize = 2
        Me.rdoMonth.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMonth.Location = New System.Drawing.Point(141, 17)
        Me.rdoMonth.Name = "rdoMonth"
        Me.rdoMonth.Size = New System.Drawing.Size(123, 27)
        Me.rdoMonth.TabIndex = 2
        Me.rdoMonth.TabStop = True
        Me.rdoMonth.Text = "Colonnes de mois (12)"
        Me.rdoMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMonth.UseVisualStyleBackColor = True
        '
        'rdoYear
        '
        Me.rdoYear.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoYear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYear.FlatAppearance.BorderSize = 2
        Me.rdoYear.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoYear.Location = New System.Drawing.Point(7, 17)
        Me.rdoYear.Name = "rdoYear"
        Me.rdoYear.Size = New System.Drawing.Size(136, 27)
        Me.rdoYear.TabIndex = 1
        Me.rdoYear.TabStop = True
        Me.rdoYear.Text = "Year Columns"
        Me.rdoYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoYear.UseVisualStyleBackColor = True
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMonth.Location = New System.Drawing.Point(277, 239)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 13)
        Me.lblMonth.TabIndex = 9
        Me.lblMonth.Text = "Month:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYear.Location = New System.Drawing.Point(277, 191)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 7
        Me.lblYear.Text = "Year:"
        '
        'lblDayofMonth
        '
        Me.lblDayofMonth.AutoSize = True
        Me.lblDayofMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDayofMonth.Location = New System.Drawing.Point(277, 239)
        Me.lblDayofMonth.Name = "lblDayofMonth"
        Me.lblDayofMonth.Size = New System.Drawing.Size(76, 13)
        Me.lblDayofMonth.TabIndex = 11
        Me.lblDayofMonth.Text = "Day Of Month:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStation.Location = New System.Drawing.Point(277, 288)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 13
        Me.lblStation.Text = "Station:"
        '
        'lblElementName
        '
        Me.lblElementName.AutoSize = True
        Me.lblElementName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElementName.Location = New System.Drawing.Point(10, 16)
        Me.lblElementName.Name = "lblElementName"
        Me.lblElementName.Size = New System.Drawing.Size(79, 13)
        Me.lblElementName.TabIndex = 16
        Me.lblElementName.Text = "Element Name:"
        '
        'lblColumnstoStack
        '
        Me.lblColumnstoStack.AutoSize = True
        Me.lblColumnstoStack.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumnstoStack.Location = New System.Drawing.Point(277, 61)
        Me.lblColumnstoStack.Name = "lblColumnstoStack"
        Me.lblColumnstoStack.Size = New System.Drawing.Size(75, 13)
        Me.lblColumnstoStack.TabIndex = 5
        Me.lblColumnstoStack.Text = "Year Columns:"
        '
        'lblMultipleElement
        '
        Me.lblMultipleElement.AutoSize = True
        Me.lblMultipleElement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMultipleElement.Location = New System.Drawing.Point(10, 83)
        Me.lblMultipleElement.Name = "lblMultipleElement"
        Me.lblMultipleElement.Size = New System.Drawing.Size(53, 13)
        Me.lblMultipleElement.TabIndex = 19
        Me.lblMultipleElement.Text = "Elements:"
        '
        'grpElements
        '
        Me.grpElements.Controls.Add(Me.ucrChkUnstackElements)
        Me.grpElements.Controls.Add(Me.lblOr)
        Me.grpElements.Controls.Add(Me.lblElementName)
        Me.grpElements.Controls.Add(Me.ucrTextBoxElementName)
        Me.grpElements.Controls.Add(Me.lblMultipleElement)
        Me.grpElements.Controls.Add(Me.ucrReceiverElement)
        Me.grpElements.Location = New System.Drawing.Point(271, 337)
        Me.grpElements.Name = "grpElements"
        Me.grpElements.Size = New System.Drawing.Size(140, 152)
        Me.grpElements.TabIndex = 15
        Me.grpElements.TabStop = False
        '
        'ucrChkUnstackElements
        '
        Me.ucrChkUnstackElements.AutoSize = True
        Me.ucrChkUnstackElements.Checked = False
        Me.ucrChkUnstackElements.Location = New System.Drawing.Point(13, 126)
        Me.ucrChkUnstackElements.Name = "ucrChkUnstackElements"
        Me.ucrChkUnstackElements.Size = New System.Drawing.Size(120, 23)
        Me.ucrChkUnstackElements.TabIndex = 21
        '
        'lblOr
        '
        Me.lblOr.AutoSize = True
        Me.lblOr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOr.Location = New System.Drawing.Point(6, 62)
        Me.lblOr.Name = "lblOr"
        Me.lblOr.Size = New System.Drawing.Size(18, 13)
        Me.lblOr.TabIndex = 18
        Me.lblOr.Text = "Or"
        '
        'ucrTextBoxElementName
        '
        Me.ucrTextBoxElementName.AddQuotesIfUnrecognised = True
        Me.ucrTextBoxElementName.AutoSize = True
        Me.ucrTextBoxElementName.IsMultiline = False
        Me.ucrTextBoxElementName.IsReadOnly = False
        Me.ucrTextBoxElementName.Location = New System.Drawing.Point(13, 32)
        Me.ucrTextBoxElementName.Name = "ucrTextBoxElementName"
        Me.ucrTextBoxElementName.Size = New System.Drawing.Size(120, 21)
        Me.ucrTextBoxElementName.TabIndex = 17
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.AutoSize = True
        Me.ucrReceiverElement.frmParent = Me
        Me.ucrReceiverElement.Location = New System.Drawing.Point(13, 98)
        Me.ucrReceiverElement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.TabIndex = 20
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrChkIgnoreInvalid)
        Me.grpOptions.Controls.Add(Me.ucrChkSilent)
        Me.grpOptions.Location = New System.Drawing.Point(2, 270)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(265, 83)
        Me.grpOptions.TabIndex = 21
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'ucrChkIgnoreInvalid
        '
        Me.ucrChkIgnoreInvalid.AutoSize = True
        Me.ucrChkIgnoreInvalid.Checked = False
        Me.ucrChkIgnoreInvalid.Location = New System.Drawing.Point(5, 19)
        Me.ucrChkIgnoreInvalid.Name = "ucrChkIgnoreInvalid"
        Me.ucrChkIgnoreInvalid.Size = New System.Drawing.Size(249, 23)
        Me.ucrChkIgnoreInvalid.TabIndex = 22
        '
        'ucrChkSilent
        '
        Me.ucrChkSilent.AutoSize = True
        Me.ucrChkSilent.Checked = False
        Me.ucrChkSilent.Location = New System.Drawing.Point(5, 53)
        Me.ucrChkSilent.Name = "ucrChkSilent"
        Me.ucrChkSilent.Size = New System.Drawing.Size(255, 23)
        Me.ucrChkSilent.TabIndex = 23
        '
        'lblNewDataFrameName
        '
        Me.lblNewDataFrameName.AutoSize = True
        Me.lblNewDataFrameName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNewDataFrameName.Location = New System.Drawing.Point(7, 498)
        Me.lblNewDataFrameName.Name = "lblNewDataFrameName"
        Me.lblNewDataFrameName.Size = New System.Drawing.Size(121, 13)
        Me.lblNewDataFrameName.TabIndex = 27
        Me.lblNewDataFrameName.Text = "New Data Frame Name:"
        '
        'lblNColumns
        '
        Me.lblNColumns.AutoSize = True
        Me.lblNColumns.ForeColor = System.Drawing.Color.Red
        Me.lblNColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNColumns.Location = New System.Drawing.Point(385, 61)
        Me.lblNColumns.Name = "lblNColumns"
        Me.lblNColumns.Size = New System.Drawing.Size(0, 13)
        Me.lblNColumns.TabIndex = 28
        '
        'ucrInputNewDataFrame
        '
        Me.ucrInputNewDataFrame.AddQuotesIfUnrecognised = True
        Me.ucrInputNewDataFrame.AutoSize = True
        Me.ucrInputNewDataFrame.IsMultiline = False
        Me.ucrInputNewDataFrame.IsReadOnly = False
        Me.ucrInputNewDataFrame.Location = New System.Drawing.Point(214, 495)
        Me.ucrInputNewDataFrame.Name = "ucrInputNewDataFrame"
        Me.ucrInputNewDataFrame.Size = New System.Drawing.Size(183, 21)
        Me.ucrInputNewDataFrame.TabIndex = 26
        '
        'ucrReceiverMultipleStack
        '
        Me.ucrReceiverMultipleStack.AutoSize = True
        Me.ucrReceiverMultipleStack.frmParent = Me
        Me.ucrReceiverMultipleStack.Location = New System.Drawing.Point(280, 79)
        Me.ucrReceiverMultipleStack.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleStack.Name = "ucrReceiverMultipleStack"
        Me.ucrReceiverMultipleStack.Selector = Nothing
        Me.ucrReceiverMultipleStack.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleStack.strNcFilePath = ""
        Me.ucrReceiverMultipleStack.TabIndex = 6
        Me.ucrReceiverMultipleStack.ucrSelector = Nothing
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.AutoSize = True
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(280, 257)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 10
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrReceiverDayofMonth
        '
        Me.ucrReceiverDayofMonth.AutoSize = True
        Me.ucrReceiverDayofMonth.frmParent = Me
        Me.ucrReceiverDayofMonth.Location = New System.Drawing.Point(280, 257)
        Me.ucrReceiverDayofMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDayofMonth.Name = "ucrReceiverDayofMonth"
        Me.ucrReceiverDayofMonth.Selector = Nothing
        Me.ucrReceiverDayofMonth.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDayofMonth.strNcFilePath = ""
        Me.ucrReceiverDayofMonth.TabIndex = 12
        Me.ucrReceiverDayofMonth.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(280, 209)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 8
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrPnlReshapeClimaticData
        '
        Me.ucrPnlReshapeClimaticData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlReshapeClimaticData.Location = New System.Drawing.Point(2, 13)
        Me.ucrPnlReshapeClimaticData.Name = "ucrPnlReshapeClimaticData"
        Me.ucrPnlReshapeClimaticData.Size = New System.Drawing.Size(411, 35)
        Me.ucrPnlReshapeClimaticData.TabIndex = 0
        '
        'ucrSelectorTidyDailyData
        '
        Me.ucrSelectorTidyDailyData.AutoSize = True
        Me.ucrSelectorTidyDailyData.bDropUnusedFilterLevels = False
        Me.ucrSelectorTidyDailyData.bShowHiddenColumns = False
        Me.ucrSelectorTidyDailyData.bUseCurrentFilter = True
        Me.ucrSelectorTidyDailyData.Location = New System.Drawing.Point(5, 66)
        Me.ucrSelectorTidyDailyData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTidyDailyData.Name = "ucrSelectorTidyDailyData"
        Me.ucrSelectorTidyDailyData.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorTidyDailyData.TabIndex = 4
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(280, 306)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 14
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(5, 524)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 25
        '
        'dlgTidyDailyData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(415, 578)
        Me.Controls.Add(Me.lblNColumns)
        Me.Controls.Add(Me.lblNewDataFrameName)
        Me.Controls.Add(Me.ucrInputNewDataFrame)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.grpElements)
        Me.Controls.Add(Me.lblColumnstoStack)
        Me.Controls.Add(Me.ucrReceiverMultipleStack)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.ucrReceiverDayofMonth)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDayofMonth)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.rdoDay)
        Me.Controls.Add(Me.rdoMonth)
        Me.Controls.Add(Me.rdoYear)
        Me.Controls.Add(Me.ucrPnlReshapeClimaticData)
        Me.Controls.Add(Me.lblColumnPer)
        Me.Controls.Add(Me.ucrSelectorTidyDailyData)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTidyDailyData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tidy Daily Data"
        Me.grpElements.ResumeLayout(False)
        Me.grpElements.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorTidyDailyData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblColumnPer As Label
    Friend WithEvents rdoDay As RadioButton
    Friend WithEvents rdoMonth As RadioButton
    Friend WithEvents rdoYear As RadioButton
    Friend WithEvents ucrPnlReshapeClimaticData As UcrPanel
    Friend WithEvents lblMonth As Label
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents lblDayofMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverDayofMonth As ucrReceiverSingle
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents lblMultipleElement As Label
    Friend WithEvents lblColumnstoStack As Label
    Friend WithEvents lblElementName As Label
    Friend WithEvents ucrReceiverElement As ucrReceiverSingle
    Friend WithEvents ucrReceiverMultipleStack As ucrReceiverMultiple
    Friend WithEvents ucrTextBoxElementName As ucrInputTextBox
    Friend WithEvents ucrChkIgnoreInvalid As ucrCheck
    Friend WithEvents ucrChkSilent As ucrCheck
    Friend WithEvents grpElements As GroupBox
    Friend WithEvents lblOr As Label
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents lblNewDataFrameName As Label
    Friend WithEvents ucrInputNewDataFrame As ucrInputTextBox
    Friend WithEvents ttReshapeType As ToolTip
    Friend WithEvents ucrChkUnstackElements As ucrCheck
    Friend WithEvents lblNColumns As Label
End Class
