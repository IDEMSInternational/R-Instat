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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgSetupForDataEntry))
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
        resources.ApplyResources(Me.rdoNew, "rdoNew")
        Me.rdoNew.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoNew.FlatAppearance.BorderSize = 2
        Me.rdoNew.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoNew.Name = "rdoNew"
        Me.rdoNew.UseVisualStyleBackColor = True
        '
        'rdoAddFlags
        '
        resources.ApplyResources(Me.rdoAddFlags, "rdoAddFlags")
        Me.rdoAddFlags.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAddFlags.FlatAppearance.BorderSize = 2
        Me.rdoAddFlags.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAddFlags.Name = "rdoAddFlags"
        Me.rdoAddFlags.UseVisualStyleBackColor = True
        '
        'lblStation
        '
        resources.ApplyResources(Me.lblStation, "lblStation")
        Me.lblStation.Name = "lblStation"
        '
        'lblSelectStation
        '
        resources.ApplyResources(Me.lblSelectStation, "lblSelectStation")
        Me.lblSelectStation.Name = "lblSelectStation"
        '
        'lblDateTo
        '
        resources.ApplyResources(Me.lblDateTo, "lblDateTo")
        Me.lblDateTo.Name = "lblDateTo"
        Me.lblDateTo.Tag = ""
        '
        'lblDateFrom
        '
        resources.ApplyResources(Me.lblDateFrom, "lblDateFrom")
        Me.lblDateFrom.Name = "lblDateFrom"
        Me.lblDateFrom.Tag = ""
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
        resources.ApplyResources(Me.grpElements, "grpElements")
        Me.grpElements.Name = "grpElements"
        Me.grpElements.TabStop = False
        '
        'ucrInputSpecify3
        '
        Me.ucrInputSpecify3.AddQuotesIfUnrecognised = True
        Me.ucrInputSpecify3.IsMultiline = False
        Me.ucrInputSpecify3.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSpecify3, "ucrInputSpecify3")
        Me.ucrInputSpecify3.Name = "ucrInputSpecify3"
        '
        'ucrInputSpecify2
        '
        Me.ucrInputSpecify2.AddQuotesIfUnrecognised = True
        Me.ucrInputSpecify2.IsMultiline = False
        Me.ucrInputSpecify2.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSpecify2, "ucrInputSpecify2")
        Me.ucrInputSpecify2.Name = "ucrInputSpecify2"
        '
        'ucrInputSpecify1
        '
        Me.ucrInputSpecify1.AddQuotesIfUnrecognised = True
        Me.ucrInputSpecify1.IsMultiline = False
        Me.ucrInputSpecify1.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSpecify1, "ucrInputSpecify1")
        Me.ucrInputSpecify1.Name = "ucrInputSpecify1"
        '
        'ucrChkWD
        '
        Me.ucrChkWD.Checked = False
        resources.ApplyResources(Me.ucrChkWD, "ucrChkWD")
        Me.ucrChkWD.Name = "ucrChkWD"
        '
        'ucrChkWS
        '
        Me.ucrChkWS.Checked = False
        resources.ApplyResources(Me.ucrChkWS, "ucrChkWS")
        Me.ucrChkWS.Name = "ucrChkWS"
        '
        'ucrChkSunh
        '
        Me.ucrChkSunh.Checked = False
        resources.ApplyResources(Me.ucrChkSunh, "ucrChkSunh")
        Me.ucrChkSunh.Name = "ucrChkSunh"
        '
        'ucrChkSpecify3
        '
        Me.ucrChkSpecify3.Checked = False
        resources.ApplyResources(Me.ucrChkSpecify3, "ucrChkSpecify3")
        Me.ucrChkSpecify3.Name = "ucrChkSpecify3"
        '
        'ucrChkSpecify2
        '
        Me.ucrChkSpecify2.Checked = False
        resources.ApplyResources(Me.ucrChkSpecify2, "ucrChkSpecify2")
        Me.ucrChkSpecify2.Name = "ucrChkSpecify2"
        '
        'ucrChkSpecify1
        '
        Me.ucrChkSpecify1.Checked = False
        resources.ApplyResources(Me.ucrChkSpecify1, "ucrChkSpecify1")
        Me.ucrChkSpecify1.Name = "ucrChkSpecify1"
        '
        'ucrChkTmin
        '
        Me.ucrChkTmin.Checked = False
        resources.ApplyResources(Me.ucrChkTmin, "ucrChkTmin")
        Me.ucrChkTmin.Name = "ucrChkTmin"
        '
        'ucrChkTmax
        '
        Me.ucrChkTmax.Checked = False
        resources.ApplyResources(Me.ucrChkTmax, "ucrChkTmax")
        Me.ucrChkTmax.Name = "ucrChkTmax"
        '
        'ucrChkPrecip
        '
        Me.ucrChkPrecip.Checked = False
        resources.ApplyResources(Me.ucrChkPrecip, "ucrChkPrecip")
        Me.ucrChkPrecip.Name = "ucrChkPrecip"
        '
        'lblAddFlagVariables
        '
        resources.ApplyResources(Me.lblAddFlagVariables, "lblAddFlagVariables")
        Me.lblAddFlagVariables.Name = "lblAddFlagVariables"
        '
        'lblFlagDate
        '
        resources.ApplyResources(Me.lblFlagDate, "lblFlagDate")
        Me.lblFlagDate.Name = "lblFlagDate"
        '
        'ucrReceiverFlagDate
        '
        Me.ucrReceiverFlagDate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFlagDate, "ucrReceiverFlagDate")
        Me.ucrReceiverFlagDate.Name = "ucrReceiverFlagDate"
        Me.ucrReceiverFlagDate.Selector = Nothing
        Me.ucrReceiverFlagDate.strNcFilePath = ""
        Me.ucrReceiverFlagDate.ucrSelector = Nothing
        '
        'ucrReceiverAddFlagVariables
        '
        Me.ucrReceiverAddFlagVariables.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverAddFlagVariables, "ucrReceiverAddFlagVariables")
        Me.ucrReceiverAddFlagVariables.Name = "ucrReceiverAddFlagVariables"
        Me.ucrReceiverAddFlagVariables.Selector = Nothing
        Me.ucrReceiverAddFlagVariables.strNcFilePath = ""
        Me.ucrReceiverAddFlagVariables.ucrSelector = Nothing
        '
        'ucrChkAddFlagVariables
        '
        Me.ucrChkAddFlagVariables.Checked = False
        resources.ApplyResources(Me.ucrChkAddFlagVariables, "ucrChkAddFlagVariables")
        Me.ucrChkAddFlagVariables.Name = "ucrChkAddFlagVariables"
        '
        'ucrDateTo
        '
        Me.ucrDateTo.DateValue = New Date(2021, 3, 27, 16, 14, 1, 560)
        Me.ucrDateTo.Format = "dd MMM yyyy"
        resources.ApplyResources(Me.ucrDateTo, "ucrDateTo")
        Me.ucrDateTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDateTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDateTo.Name = "ucrDateTo"
        '
        'ucrDateFrom
        '
        Me.ucrDateFrom.DateValue = New Date(2021, 3, 27, 16, 14, 1, 567)
        Me.ucrDateFrom.Format = "dd MMM yyyy"
        resources.ApplyResources(Me.ucrDateFrom, "ucrDateFrom")
        Me.ucrDateFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDateFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDateFrom.Name = "ucrDateFrom"
        '
        'ucrInputSelectStation
        '
        Me.ucrInputSelectStation.AddQuotesIfUnrecognised = True
        Me.ucrInputSelectStation.GetSetSelectedIndex = -1
        Me.ucrInputSelectStation.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSelectStation, "ucrInputSelectStation")
        Me.ucrInputSelectStation.Name = "ucrInputSelectStation"
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
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorSetupDataEntry
        '
        Me.ucrSelectorSetupDataEntry.bDropUnusedFilterLevels = False
        Me.ucrSelectorSetupDataEntry.bShowHiddenColumns = False
        Me.ucrSelectorSetupDataEntry.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorSetupDataEntry, "ucrSelectorSetupDataEntry")
        Me.ucrSelectorSetupDataEntry.Name = "ucrSelectorSetupDataEntry"
        '
        'ucrPnlOptions
        '
        resources.ApplyResources(Me.ucrPnlOptions, "ucrPnlOptions")
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        '
        'ucrSaveNewDFName
        '
        resources.ApplyResources(Me.ucrSaveNewDFName, "ucrSaveNewDFName")
        Me.ucrSaveNewDFName.Name = "ucrSaveNewDFName"
        '
        'dlgSetupForDataEntry
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.grpElements.ResumeLayout(False)
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
