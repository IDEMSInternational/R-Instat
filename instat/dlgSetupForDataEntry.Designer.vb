<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSetupForDataEntry
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.rdoNew = New System.Windows.Forms.RadioButton()
        Me.rdoAddFlags = New System.Windows.Forms.RadioButton()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblSelectStation = New System.Windows.Forms.Label()
        Me.lblDateTo = New System.Windows.Forms.Label()
        Me.lblDateFrom = New System.Windows.Forms.Label()
        Me.grpElements = New System.Windows.Forms.GroupBox()
        Me.ucrInputSpecify3 = New instat.ucrInputTextBox()
        Me.ucrInputSpecify2 = New instat.ucrInputTextBox()
        Me.ucrInputSpecify1 = New instat.ucrInputTextBox()
        Me.ucrChkWD = New instat.ucrCheck()
        Me.ucrChkWS = New instat.ucrCheck()
        Me.ucrChkSunh = New instat.ucrCheck()
        Me.ucrChkSpecify3 = New instat.ucrCheck()
        Me.ucrChkSpecify2 = New instat.ucrCheck()
        Me.ucrChkSpecify1 = New instat.ucrCheck()
        Me.ucrChkTmin = New instat.ucrCheck()
        Me.ucrChkTmax = New instat.ucrCheck()
        Me.ucrChkPrecip = New instat.ucrCheck()
        Me.lblAddFlagVariables = New System.Windows.Forms.Label()
        Me.lblFlagDate = New System.Windows.Forms.Label()
        Me.ucrReceiverFlagDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverAddFlagVariables = New instat.ucrReceiverMultiple()
        Me.ucrChkAddFlagVariables = New instat.ucrCheck()
        Me.ucrDateTo = New instat.ucrDateTimePicker()
        Me.ucrDateFrom = New instat.ucrDateTimePicker()
        Me.ucrInputSelectStation = New instat.ucrInputFactorLevels()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorSetupDataEntry = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrSaveNewDFName = New instat.ucrSave()
        Me.grpElements.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoNew
        '
        Me.rdoNew.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoNew.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoNew.FlatAppearance.BorderSize = 2
        Me.rdoNew.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoNew.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNew.Location = New System.Drawing.Point(95, 12)
        Me.rdoNew.Name = "rdoNew"
        Me.rdoNew.Size = New System.Drawing.Size(110, 27)
        Me.rdoNew.TabIndex = 1
        Me.rdoNew.Text = "New"
        Me.rdoNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoNew.UseVisualStyleBackColor = True
        '
        'rdoAddFlags
        '
        Me.rdoAddFlags.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoAddFlags.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAddFlags.FlatAppearance.BorderSize = 2
        Me.rdoAddFlags.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAddFlags.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoAddFlags.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAddFlags.Location = New System.Drawing.Point(203, 12)
        Me.rdoAddFlags.Name = "rdoAddFlags"
        Me.rdoAddFlags.Size = New System.Drawing.Size(110, 27)
        Me.rdoAddFlags.TabIndex = 2
        Me.rdoAddFlags.Text = "Add Flags"
        Me.rdoAddFlags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoAddFlags.UseVisualStyleBackColor = True
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStation.Location = New System.Drawing.Point(262, 55)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 4
        Me.lblStation.Text = "Station:"
        '
        'lblSelectStation
        '
        Me.lblSelectStation.AutoSize = True
        Me.lblSelectStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectStation.Location = New System.Drawing.Point(262, 96)
        Me.lblSelectStation.Name = "lblSelectStation"
        Me.lblSelectStation.Size = New System.Drawing.Size(76, 13)
        Me.lblSelectStation.TabIndex = 4
        Me.lblSelectStation.Text = "Select Station:"
        '
        'lblDateTo
        '
        Me.lblDateTo.AutoSize = True
        Me.lblDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblDateTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDateTo.Location = New System.Drawing.Point(262, 176)
        Me.lblDateTo.Name = "lblDateTo"
        Me.lblDateTo.Size = New System.Drawing.Size(49, 13)
        Me.lblDateTo.TabIndex = 11
        Me.lblDateTo.Tag = ""
        Me.lblDateTo.Text = "Date To:"
        '
        'lblDateFrom
        '
        Me.lblDateFrom.AutoSize = True
        Me.lblDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblDateFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDateFrom.Location = New System.Drawing.Point(262, 137)
        Me.lblDateFrom.Name = "lblDateFrom"
        Me.lblDateFrom.Size = New System.Drawing.Size(59, 13)
        Me.lblDateFrom.TabIndex = 9
        Me.lblDateFrom.Tag = ""
        Me.lblDateFrom.Text = "Date From:"
        '
        'grpElements
        '
        Me.grpElements.Controls.Add(Me.ucrInputSpecify3)
        Me.grpElements.Controls.Add(Me.ucrInputSpecify2)
        Me.grpElements.Controls.Add(Me.ucrInputSpecify1)
        Me.grpElements.Controls.Add(Me.ucrChkWD)
        Me.grpElements.Controls.Add(Me.ucrChkWS)
        Me.grpElements.Controls.Add(Me.ucrChkSunh)
        Me.grpElements.Controls.Add(Me.ucrChkSpecify3)
        Me.grpElements.Controls.Add(Me.ucrChkSpecify2)
        Me.grpElements.Controls.Add(Me.ucrChkSpecify1)
        Me.grpElements.Controls.Add(Me.ucrChkTmin)
        Me.grpElements.Controls.Add(Me.ucrChkTmax)
        Me.grpElements.Controls.Add(Me.ucrChkPrecip)
        Me.grpElements.Location = New System.Drawing.Point(4, 248)
        Me.grpElements.Name = "grpElements"
        Me.grpElements.Size = New System.Drawing.Size(381, 95)
        Me.grpElements.TabIndex = 15
        Me.grpElements.TabStop = False
        Me.grpElements.Text = "Elements:"
        '
        'ucrInputSpecify3
        '
        Me.ucrInputSpecify3.AddQuotesIfUnrecognised = True
        Me.ucrInputSpecify3.AutoSize = True
        Me.ucrInputSpecify3.IsMultiline = False
        Me.ucrInputSpecify3.IsReadOnly = False
        Me.ucrInputSpecify3.Location = New System.Drawing.Point(262, 70)
        Me.ucrInputSpecify3.Name = "ucrInputSpecify3"
        Me.ucrInputSpecify3.Size = New System.Drawing.Size(107, 21)
        Me.ucrInputSpecify3.TabIndex = 19
        '
        'ucrInputSpecify2
        '
        Me.ucrInputSpecify2.AddQuotesIfUnrecognised = True
        Me.ucrInputSpecify2.AutoSize = True
        Me.ucrInputSpecify2.IsMultiline = False
        Me.ucrInputSpecify2.IsReadOnly = False
        Me.ucrInputSpecify2.Location = New System.Drawing.Point(262, 44)
        Me.ucrInputSpecify2.Name = "ucrInputSpecify2"
        Me.ucrInputSpecify2.Size = New System.Drawing.Size(107, 21)
        Me.ucrInputSpecify2.TabIndex = 17
        '
        'ucrInputSpecify1
        '
        Me.ucrInputSpecify1.AddQuotesIfUnrecognised = True
        Me.ucrInputSpecify1.AutoSize = True
        Me.ucrInputSpecify1.IsMultiline = False
        Me.ucrInputSpecify1.IsReadOnly = False
        Me.ucrInputSpecify1.Location = New System.Drawing.Point(262, 18)
        Me.ucrInputSpecify1.Name = "ucrInputSpecify1"
        Me.ucrInputSpecify1.Size = New System.Drawing.Size(107, 21)
        Me.ucrInputSpecify1.TabIndex = 15
        '
        'ucrChkWD
        '
        Me.ucrChkWD.AutoSize = True
        Me.ucrChkWD.Checked = False
        Me.ucrChkWD.Location = New System.Drawing.Point(94, 72)
        Me.ucrChkWD.Name = "ucrChkWD"
        Me.ucrChkWD.Size = New System.Drawing.Size(82, 23)
        Me.ucrChkWD.TabIndex = 13
        '
        'ucrChkWS
        '
        Me.ucrChkWS.AutoSize = True
        Me.ucrChkWS.Checked = False
        Me.ucrChkWS.Location = New System.Drawing.Point(94, 46)
        Me.ucrChkWS.Name = "ucrChkWS"
        Me.ucrChkWS.Size = New System.Drawing.Size(82, 23)
        Me.ucrChkWS.TabIndex = 12
        '
        'ucrChkSunh
        '
        Me.ucrChkSunh.AutoSize = True
        Me.ucrChkSunh.Checked = False
        Me.ucrChkSunh.Location = New System.Drawing.Point(94, 20)
        Me.ucrChkSunh.Name = "ucrChkSunh"
        Me.ucrChkSunh.Size = New System.Drawing.Size(82, 23)
        Me.ucrChkSunh.TabIndex = 11
        '
        'ucrChkSpecify3
        '
        Me.ucrChkSpecify3.AutoSize = True
        Me.ucrChkSpecify3.Checked = False
        Me.ucrChkSpecify3.Location = New System.Drawing.Point(181, 72)
        Me.ucrChkSpecify3.Name = "ucrChkSpecify3"
        Me.ucrChkSpecify3.Size = New System.Drawing.Size(89, 23)
        Me.ucrChkSpecify3.TabIndex = 18
        '
        'ucrChkSpecify2
        '
        Me.ucrChkSpecify2.AutoSize = True
        Me.ucrChkSpecify2.Checked = False
        Me.ucrChkSpecify2.Location = New System.Drawing.Point(181, 46)
        Me.ucrChkSpecify2.Name = "ucrChkSpecify2"
        Me.ucrChkSpecify2.Size = New System.Drawing.Size(89, 23)
        Me.ucrChkSpecify2.TabIndex = 16
        '
        'ucrChkSpecify1
        '
        Me.ucrChkSpecify1.AutoSize = True
        Me.ucrChkSpecify1.Checked = False
        Me.ucrChkSpecify1.Location = New System.Drawing.Point(181, 20)
        Me.ucrChkSpecify1.Name = "ucrChkSpecify1"
        Me.ucrChkSpecify1.Size = New System.Drawing.Size(89, 23)
        Me.ucrChkSpecify1.TabIndex = 14
        '
        'ucrChkTmin
        '
        Me.ucrChkTmin.AutoSize = True
        Me.ucrChkTmin.Checked = False
        Me.ucrChkTmin.Location = New System.Drawing.Point(7, 72)
        Me.ucrChkTmin.Name = "ucrChkTmin"
        Me.ucrChkTmin.Size = New System.Drawing.Size(81, 23)
        Me.ucrChkTmin.TabIndex = 10
        '
        'ucrChkTmax
        '
        Me.ucrChkTmax.AutoSize = True
        Me.ucrChkTmax.Checked = False
        Me.ucrChkTmax.Location = New System.Drawing.Point(7, 46)
        Me.ucrChkTmax.Name = "ucrChkTmax"
        Me.ucrChkTmax.Size = New System.Drawing.Size(81, 23)
        Me.ucrChkTmax.TabIndex = 9
        '
        'ucrChkPrecip
        '
        Me.ucrChkPrecip.AutoSize = True
        Me.ucrChkPrecip.Checked = False
        Me.ucrChkPrecip.Location = New System.Drawing.Point(7, 20)
        Me.ucrChkPrecip.Name = "ucrChkPrecip"
        Me.ucrChkPrecip.Size = New System.Drawing.Size(81, 23)
        Me.ucrChkPrecip.TabIndex = 8
        '
        'lblAddFlagVariables
        '
        Me.lblAddFlagVariables.AutoSize = True
        Me.lblAddFlagVariables.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAddFlagVariables.Location = New System.Drawing.Point(262, 137)
        Me.lblAddFlagVariables.Name = "lblAddFlagVariables"
        Me.lblAddFlagVariables.Size = New System.Drawing.Size(76, 13)
        Me.lblAddFlagVariables.TabIndex = 8
        Me.lblAddFlagVariables.Text = "Flag Variables:"
        '
        'lblFlagDate
        '
        Me.lblFlagDate.AutoSize = True
        Me.lblFlagDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFlagDate.Location = New System.Drawing.Point(262, 95)
        Me.lblFlagDate.Name = "lblFlagDate"
        Me.lblFlagDate.Size = New System.Drawing.Size(33, 13)
        Me.lblFlagDate.TabIndex = 6
        Me.lblFlagDate.Text = "Date:"
        '
        'ucrReceiverFlagDate
        '
        Me.ucrReceiverFlagDate.AutoSize = True
        Me.ucrReceiverFlagDate.frmParent = Me
        Me.ucrReceiverFlagDate.Location = New System.Drawing.Point(261, 111)
        Me.ucrReceiverFlagDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFlagDate.Name = "ucrReceiverFlagDate"
        Me.ucrReceiverFlagDate.Selector = Nothing
        Me.ucrReceiverFlagDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFlagDate.strNcFilePath = ""
        Me.ucrReceiverFlagDate.TabIndex = 7
        Me.ucrReceiverFlagDate.ucrSelector = Nothing
        '
        'ucrReceiverAddFlagVariables
        '
        Me.ucrReceiverAddFlagVariables.AutoSize = True
        Me.ucrReceiverAddFlagVariables.frmParent = Me
        Me.ucrReceiverAddFlagVariables.Location = New System.Drawing.Point(261, 154)
        Me.ucrReceiverAddFlagVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAddFlagVariables.Name = "ucrReceiverAddFlagVariables"
        Me.ucrReceiverAddFlagVariables.Selector = Nothing
        Me.ucrReceiverAddFlagVariables.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverAddFlagVariables.strNcFilePath = ""
        Me.ucrReceiverAddFlagVariables.TabIndex = 9
        Me.ucrReceiverAddFlagVariables.ucrSelector = Nothing
        '
        'ucrChkAddFlagVariables
        '
        Me.ucrChkAddFlagVariables.AutoSize = True
        Me.ucrChkAddFlagVariables.Checked = False
        Me.ucrChkAddFlagVariables.Location = New System.Drawing.Point(4, 349)
        Me.ucrChkAddFlagVariables.Name = "ucrChkAddFlagVariables"
        Me.ucrChkAddFlagVariables.Size = New System.Drawing.Size(177, 23)
        Me.ucrChkAddFlagVariables.TabIndex = 16
        '
        'ucrDateTo
        '
        Me.ucrDateTo.AutoSize = True
        Me.ucrDateTo.DateValue = New Date(2021, 3, 27, 16, 14, 1, 560)
        Me.ucrDateTo.Format = "dd MMM yyyy"
        Me.ucrDateTo.Location = New System.Drawing.Point(261, 191)
        Me.ucrDateTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDateTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDateTo.Name = "ucrDateTo"
        Me.ucrDateTo.Size = New System.Drawing.Size(135, 20)
        Me.ucrDateTo.TabIndex = 12
        '
        'ucrDateFrom
        '
        Me.ucrDateFrom.AutoSize = True
        Me.ucrDateFrom.DateValue = New Date(2021, 3, 27, 16, 14, 1, 567)
        Me.ucrDateFrom.Format = "dd MMM yyyy"
        Me.ucrDateFrom.Location = New System.Drawing.Point(261, 151)
        Me.ucrDateFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDateFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDateFrom.Name = "ucrDateFrom"
        Me.ucrDateFrom.Size = New System.Drawing.Size(135, 20)
        Me.ucrDateFrom.TabIndex = 10
        '
        'ucrInputSelectStation
        '
        Me.ucrInputSelectStation.AddQuotesIfUnrecognised = True
        Me.ucrInputSelectStation.AutoSize = True
        Me.ucrInputSelectStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSelectStation.GetSetSelectedIndex = -1
        Me.ucrInputSelectStation.IsReadOnly = False
        Me.ucrInputSelectStation.Location = New System.Drawing.Point(261, 112)
        Me.ucrInputSelectStation.Name = "ucrInputSelectStation"
        Me.ucrInputSelectStation.Size = New System.Drawing.Size(0, 0)
        Me.ucrInputSelectStation.TabIndex = 5
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(261, 71)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 5
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(4, 406)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 18
        '
        'ucrSelectorSetupDataEntry
        '
        Me.ucrSelectorSetupDataEntry.AutoSize = True
        Me.ucrSelectorSetupDataEntry.bDropUnusedFilterLevels = False
        Me.ucrSelectorSetupDataEntry.bShowHiddenColumns = False
        Me.ucrSelectorSetupDataEntry.bUseCurrentFilter = True
        Me.ucrSelectorSetupDataEntry.Location = New System.Drawing.Point(4, 49)
        Me.ucrSelectorSetupDataEntry.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSetupDataEntry.Name = "ucrSelectorSetupDataEntry"
        Me.ucrSelectorSetupDataEntry.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorSetupDataEntry.TabIndex = 3
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(70, 8)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(278, 35)
        Me.ucrPnlOptions.TabIndex = 0
        '
        'ucrSaveNewDFName
        '
        Me.ucrSaveNewDFName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveNewDFName.Location = New System.Drawing.Point(4, 375)
        Me.ucrSaveNewDFName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveNewDFName.Name = "ucrSaveNewDFName"
        Me.ucrSaveNewDFName.Size = New System.Drawing.Size(300, 24)
        Me.ucrSaveNewDFName.TabIndex = 17
        '
        'dlgSetupForDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(408, 459)
        Me.Controls.Add(Me.ucrReceiverFlagDate)
        Me.Controls.Add(Me.lblFlagDate)
        Me.Controls.Add(Me.lblAddFlagVariables)
        Me.Controls.Add(Me.ucrSaveNewDFName)
        Me.Controls.Add(Me.ucrChkAddFlagVariables)
        Me.Controls.Add(Me.grpElements)
        Me.Controls.Add(Me.ucrDateTo)
        Me.Controls.Add(Me.ucrDateFrom)
        Me.Controls.Add(Me.lblDateTo)
        Me.Controls.Add(Me.lblDateFrom)
        Me.Controls.Add(Me.ucrInputSelectStation)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.lblSelectStation)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorSetupDataEntry)
        Me.Controls.Add(Me.rdoNew)
        Me.Controls.Add(Me.rdoAddFlags)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrReceiverAddFlagVariables)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSetupForDataEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setup For Data Entry"
        Me.grpElements.ResumeLayout(False)
        Me.grpElements.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdoNew As RadioButton
    Friend WithEvents rdoAddFlags As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents ucrSelectorSetupDataEntry As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInputSelectStation As ucrInputFactorLevels
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents lblSelectStation As Label
    Friend WithEvents ucrChkAddFlagVariables As ucrCheck
    Friend WithEvents grpElements As GroupBox
    Friend WithEvents ucrInputSpecify3 As ucrInputTextBox
    Friend WithEvents ucrInputSpecify2 As ucrInputTextBox
    Friend WithEvents ucrInputSpecify1 As ucrInputTextBox
    Friend WithEvents ucrChkWD As ucrCheck
    Friend WithEvents ucrChkWS As ucrCheck
    Friend WithEvents ucrChkSunh As ucrCheck
    Friend WithEvents ucrChkSpecify3 As ucrCheck
    Friend WithEvents ucrChkSpecify2 As ucrCheck
    Friend WithEvents ucrChkSpecify1 As ucrCheck
    Friend WithEvents ucrChkTmin As ucrCheck
    Friend WithEvents ucrChkTmax As ucrCheck
    Friend WithEvents ucrChkPrecip As ucrCheck
    Friend WithEvents ucrDateTo As ucrDateTimePicker
    Friend WithEvents ucrDateFrom As ucrDateTimePicker
    Friend WithEvents lblDateTo As Label
    Friend WithEvents lblDateFrom As Label
    Friend WithEvents lblAddFlagVariables As Label
    Friend WithEvents ucrReceiverAddFlagVariables As ucrReceiverMultiple
    Friend WithEvents ucrReceiverFlagDate As ucrReceiverSingle
    Friend WithEvents lblFlagDate As Label
    Friend WithEvents ucrSaveNewDFName As ucrSave

End Class
