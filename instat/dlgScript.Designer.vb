<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgScript
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
        Me.tbFeatures = New System.Windows.Forms.TabControl()
        Me.tbPageLibrary = New System.Windows.Forms.TabPage()
        Me.ucrCboLibPackage = New instat.ucrInputComboBox()
        Me.lblGetPackage = New System.Windows.Forms.Label()
        Me.tbPageSaveData = New System.Windows.Forms.TabPage()
        Me.lblSaveObjectFormat = New System.Windows.Forms.Label()
        Me.ucrCboSaveOutputObjectFormat = New instat.ucrInputComboBox()
        Me.lblSaveObjectType = New System.Windows.Forms.Label()
        Me.ucrCboSaveOutputObjectType = New instat.ucrInputComboBox()
        Me.rdoSaveOutputObject = New System.Windows.Forms.RadioButton()
        Me.rdoSaveDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoSaveColumn = New System.Windows.Forms.RadioButton()
        Me.ucrSaveData = New instat.ucrSave()
        Me.ucrDataFrameSaveOutputSelect = New instat.ucrDataFrame()
        Me.ucrPnlSaveData = New instat.UcrPanel()
        Me.tbPageGetData = New System.Windows.Forms.TabPage()
        Me.ucrDataFrameGetDF = New instat.ucrDataFrame()
        Me.lblGetObjectType = New System.Windows.Forms.Label()
        Me.ucrCboGetOutputObjectType = New instat.ucrInputComboBox()
        Me.rdoGetOutputObject = New System.Windows.Forms.RadioButton()
        Me.lblGetObject = New System.Windows.Forms.Label()
        Me.ucrReceiverGetObject = New instat.ucrReceiverSingle()
        Me.rdoGetDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoGetColumn = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGetData = New instat.UcrPanel()
        Me.ucrSelectorGetObject = New instat.ucrSelectorByDataFrameAddRemove()
        Me.tbPageFinally = New System.Windows.Forms.TabPage()
        Me.lblRemoveObject = New System.Windows.Forms.Label()
        Me.ucrInputRemoveObjects = New instat.ucrInputTextBox()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.txtScript = New System.Windows.Forms.TextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.tbFeatures.SuspendLayout()
        Me.tbPageLibrary.SuspendLayout()
        Me.tbPageSaveData.SuspendLayout()
        Me.tbPageGetData.SuspendLayout()
        Me.tbPageFinally.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbFeatures
        '
        Me.tbFeatures.Controls.Add(Me.tbPageLibrary)
        Me.tbFeatures.Controls.Add(Me.tbPageSaveData)
        Me.tbFeatures.Controls.Add(Me.tbPageGetData)
        Me.tbFeatures.Controls.Add(Me.tbPageFinally)
        Me.tbFeatures.Location = New System.Drawing.Point(8, 7)
        Me.tbFeatures.Name = "tbFeatures"
        Me.tbFeatures.SelectedIndex = 0
        Me.tbFeatures.Size = New System.Drawing.Size(446, 271)
        Me.tbFeatures.TabIndex = 31
        '
        'tbPageLibrary
        '
        Me.tbPageLibrary.Controls.Add(Me.ucrCboLibPackage)
        Me.tbPageLibrary.Controls.Add(Me.lblGetPackage)
        Me.tbPageLibrary.Location = New System.Drawing.Point(4, 22)
        Me.tbPageLibrary.Name = "tbPageLibrary"
        Me.tbPageLibrary.Size = New System.Drawing.Size(438, 245)
        Me.tbPageLibrary.TabIndex = 4
        Me.tbPageLibrary.Text = "Library"
        Me.tbPageLibrary.UseVisualStyleBackColor = True
        '
        'ucrCboLibPackage
        '
        Me.ucrCboLibPackage.AddQuotesIfUnrecognised = True
        Me.ucrCboLibPackage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboLibPackage.GetSetSelectedIndex = -1
        Me.ucrCboLibPackage.IsReadOnly = False
        Me.ucrCboLibPackage.Location = New System.Drawing.Point(14, 30)
        Me.ucrCboLibPackage.Name = "ucrCboLibPackage"
        Me.ucrCboLibPackage.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboLibPackage.TabIndex = 42
        '
        'lblGetPackage
        '
        Me.lblGetPackage.AutoSize = True
        Me.lblGetPackage.Location = New System.Drawing.Point(11, 14)
        Me.lblGetPackage.Name = "lblGetPackage"
        Me.lblGetPackage.Size = New System.Drawing.Size(73, 13)
        Me.lblGetPackage.TabIndex = 41
        Me.lblGetPackage.Text = "Get Package:"
        '
        'tbPageSaveData
        '
        Me.tbPageSaveData.Controls.Add(Me.lblSaveObjectFormat)
        Me.tbPageSaveData.Controls.Add(Me.ucrCboSaveOutputObjectFormat)
        Me.tbPageSaveData.Controls.Add(Me.lblSaveObjectType)
        Me.tbPageSaveData.Controls.Add(Me.ucrCboSaveOutputObjectType)
        Me.tbPageSaveData.Controls.Add(Me.rdoSaveOutputObject)
        Me.tbPageSaveData.Controls.Add(Me.rdoSaveDataFrame)
        Me.tbPageSaveData.Controls.Add(Me.rdoSaveColumn)
        Me.tbPageSaveData.Controls.Add(Me.ucrSaveData)
        Me.tbPageSaveData.Controls.Add(Me.ucrDataFrameSaveOutputSelect)
        Me.tbPageSaveData.Controls.Add(Me.ucrPnlSaveData)
        Me.tbPageSaveData.Location = New System.Drawing.Point(4, 22)
        Me.tbPageSaveData.Name = "tbPageSaveData"
        Me.tbPageSaveData.Size = New System.Drawing.Size(438, 245)
        Me.tbPageSaveData.TabIndex = 2
        Me.tbPageSaveData.Text = "Save Data"
        Me.tbPageSaveData.UseVisualStyleBackColor = True
        '
        'lblSaveObjectFormat
        '
        Me.lblSaveObjectFormat.AutoSize = True
        Me.lblSaveObjectFormat.Location = New System.Drawing.Point(116, 145)
        Me.lblSaveObjectFormat.Name = "lblSaveObjectFormat"
        Me.lblSaveObjectFormat.Size = New System.Drawing.Size(42, 13)
        Me.lblSaveObjectFormat.TabIndex = 56
        Me.lblSaveObjectFormat.Text = "Format:"
        '
        'ucrCboSaveOutputObjectFormat
        '
        Me.ucrCboSaveOutputObjectFormat.AddQuotesIfUnrecognised = True
        Me.ucrCboSaveOutputObjectFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboSaveOutputObjectFormat.GetSetSelectedIndex = -1
        Me.ucrCboSaveOutputObjectFormat.IsReadOnly = False
        Me.ucrCboSaveOutputObjectFormat.Location = New System.Drawing.Point(117, 160)
        Me.ucrCboSaveOutputObjectFormat.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrCboSaveOutputObjectFormat.Name = "ucrCboSaveOutputObjectFormat"
        Me.ucrCboSaveOutputObjectFormat.Size = New System.Drawing.Size(141, 21)
        Me.ucrCboSaveOutputObjectFormat.TabIndex = 55
        '
        'lblSaveObjectType
        '
        Me.lblSaveObjectType.AutoSize = True
        Me.lblSaveObjectType.Location = New System.Drawing.Point(114, 101)
        Me.lblSaveObjectType.Name = "lblSaveObjectType"
        Me.lblSaveObjectType.Size = New System.Drawing.Size(34, 13)
        Me.lblSaveObjectType.TabIndex = 54
        Me.lblSaveObjectType.Text = "Type:"
        '
        'ucrCboSaveOutputObjectType
        '
        Me.ucrCboSaveOutputObjectType.AddQuotesIfUnrecognised = True
        Me.ucrCboSaveOutputObjectType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboSaveOutputObjectType.GetSetSelectedIndex = -1
        Me.ucrCboSaveOutputObjectType.IsReadOnly = False
        Me.ucrCboSaveOutputObjectType.Location = New System.Drawing.Point(116, 116)
        Me.ucrCboSaveOutputObjectType.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrCboSaveOutputObjectType.Name = "ucrCboSaveOutputObjectType"
        Me.ucrCboSaveOutputObjectType.Size = New System.Drawing.Size(144, 21)
        Me.ucrCboSaveOutputObjectType.TabIndex = 53
        '
        'rdoSaveOutputObject
        '
        Me.rdoSaveOutputObject.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSaveOutputObject.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSaveOutputObject.FlatAppearance.BorderSize = 2
        Me.rdoSaveOutputObject.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSaveOutputObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSaveOutputObject.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSaveOutputObject.Location = New System.Drawing.Point(235, 14)
        Me.rdoSaveOutputObject.Name = "rdoSaveOutputObject"
        Me.rdoSaveOutputObject.Size = New System.Drawing.Size(86, 30)
        Me.rdoSaveOutputObject.TabIndex = 51
        Me.rdoSaveOutputObject.TabStop = True
        Me.rdoSaveOutputObject.Text = "Output Object"
        Me.rdoSaveOutputObject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSaveOutputObject.UseVisualStyleBackColor = True
        '
        'rdoSaveDataFrame
        '
        Me.rdoSaveDataFrame.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSaveDataFrame.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSaveDataFrame.FlatAppearance.BorderSize = 2
        Me.rdoSaveDataFrame.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSaveDataFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSaveDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSaveDataFrame.Location = New System.Drawing.Point(79, 14)
        Me.rdoSaveDataFrame.Name = "rdoSaveDataFrame"
        Me.rdoSaveDataFrame.Size = New System.Drawing.Size(80, 30)
        Me.rdoSaveDataFrame.TabIndex = 49
        Me.rdoSaveDataFrame.TabStop = True
        Me.rdoSaveDataFrame.Text = "Data Frame"
        Me.rdoSaveDataFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSaveDataFrame.UseVisualStyleBackColor = True
        '
        'rdoSaveColumn
        '
        Me.rdoSaveColumn.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSaveColumn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSaveColumn.FlatAppearance.BorderSize = 2
        Me.rdoSaveColumn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSaveColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSaveColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSaveColumn.Location = New System.Drawing.Point(157, 14)
        Me.rdoSaveColumn.Name = "rdoSaveColumn"
        Me.rdoSaveColumn.Size = New System.Drawing.Size(80, 30)
        Me.rdoSaveColumn.TabIndex = 50
        Me.rdoSaveColumn.TabStop = True
        Me.rdoSaveColumn.Text = "Column"
        Me.rdoSaveColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSaveColumn.UseVisualStyleBackColor = True
        '
        'ucrSaveData
        '
        Me.ucrSaveData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveData.Location = New System.Drawing.Point(117, 193)
        Me.ucrSaveData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveData.Name = "ucrSaveData"
        Me.ucrSaveData.Size = New System.Drawing.Size(258, 22)
        Me.ucrSaveData.TabIndex = 35
        '
        'ucrDataFrameSaveOutputSelect
        '
        Me.ucrDataFrameSaveOutputSelect.AutoSize = True
        Me.ucrDataFrameSaveOutputSelect.bDropUnusedFilterLevels = False
        Me.ucrDataFrameSaveOutputSelect.bUseCurrentFilter = True
        Me.ucrDataFrameSaveOutputSelect.Location = New System.Drawing.Point(115, 54)
        Me.ucrDataFrameSaveOutputSelect.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameSaveOutputSelect.Name = "ucrDataFrameSaveOutputSelect"
        Me.ucrDataFrameSaveOutputSelect.Size = New System.Drawing.Size(151, 50)
        Me.ucrDataFrameSaveOutputSelect.TabIndex = 29
        '
        'ucrPnlSaveData
        '
        Me.ucrPnlSaveData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSaveData.Location = New System.Drawing.Point(13, 12)
        Me.ucrPnlSaveData.Name = "ucrPnlSaveData"
        Me.ucrPnlSaveData.Size = New System.Drawing.Size(402, 36)
        Me.ucrPnlSaveData.TabIndex = 47
        '
        'tbPageGetData
        '
        Me.tbPageGetData.Controls.Add(Me.ucrDataFrameGetDF)
        Me.tbPageGetData.Controls.Add(Me.lblGetObjectType)
        Me.tbPageGetData.Controls.Add(Me.ucrCboGetOutputObjectType)
        Me.tbPageGetData.Controls.Add(Me.rdoGetOutputObject)
        Me.tbPageGetData.Controls.Add(Me.lblGetObject)
        Me.tbPageGetData.Controls.Add(Me.ucrReceiverGetObject)
        Me.tbPageGetData.Controls.Add(Me.rdoGetDataFrame)
        Me.tbPageGetData.Controls.Add(Me.rdoGetColumn)
        Me.tbPageGetData.Controls.Add(Me.ucrPnlGetData)
        Me.tbPageGetData.Controls.Add(Me.ucrSelectorGetObject)
        Me.tbPageGetData.Location = New System.Drawing.Point(4, 22)
        Me.tbPageGetData.Name = "tbPageGetData"
        Me.tbPageGetData.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPageGetData.Size = New System.Drawing.Size(438, 245)
        Me.tbPageGetData.TabIndex = 1
        Me.tbPageGetData.Text = "Get Data"
        Me.tbPageGetData.UseVisualStyleBackColor = True
        '
        'ucrDataFrameGetDF
        '
        Me.ucrDataFrameGetDF.AutoSize = True
        Me.ucrDataFrameGetDF.bDropUnusedFilterLevels = False
        Me.ucrDataFrameGetDF.bUseCurrentFilter = True
        Me.ucrDataFrameGetDF.Location = New System.Drawing.Point(10, 55)
        Me.ucrDataFrameGetDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameGetDF.Name = "ucrDataFrameGetDF"
        Me.ucrDataFrameGetDF.Size = New System.Drawing.Size(151, 50)
        Me.ucrDataFrameGetDF.TabIndex = 31
        '
        'lblGetObjectType
        '
        Me.lblGetObjectType.AutoSize = True
        Me.lblGetObjectType.Location = New System.Drawing.Point(238, 57)
        Me.lblGetObjectType.Name = "lblGetObjectType"
        Me.lblGetObjectType.Size = New System.Drawing.Size(34, 13)
        Me.lblGetObjectType.TabIndex = 48
        Me.lblGetObjectType.Text = "Type:"
        '
        'ucrCboGetOutputObjectType
        '
        Me.ucrCboGetOutputObjectType.AddQuotesIfUnrecognised = True
        Me.ucrCboGetOutputObjectType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboGetOutputObjectType.GetSetSelectedIndex = -1
        Me.ucrCboGetOutputObjectType.IsReadOnly = False
        Me.ucrCboGetOutputObjectType.Location = New System.Drawing.Point(240, 72)
        Me.ucrCboGetOutputObjectType.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrCboGetOutputObjectType.Name = "ucrCboGetOutputObjectType"
        Me.ucrCboGetOutputObjectType.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboGetOutputObjectType.TabIndex = 47
        '
        'rdoGetOutputObject
        '
        Me.rdoGetOutputObject.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGetOutputObject.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetOutputObject.FlatAppearance.BorderSize = 2
        Me.rdoGetOutputObject.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetOutputObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGetOutputObject.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGetOutputObject.Location = New System.Drawing.Point(235, 12)
        Me.rdoGetOutputObject.Name = "rdoGetOutputObject"
        Me.rdoGetOutputObject.Size = New System.Drawing.Size(85, 30)
        Me.rdoGetOutputObject.TabIndex = 46
        Me.rdoGetOutputObject.TabStop = True
        Me.rdoGetOutputObject.Text = "Output Object"
        Me.rdoGetOutputObject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGetOutputObject.UseVisualStyleBackColor = True
        '
        'lblGetObject
        '
        Me.lblGetObject.AutoSize = True
        Me.lblGetObject.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGetObject.Location = New System.Drawing.Point(241, 101)
        Me.lblGetObject.Name = "lblGetObject"
        Me.lblGetObject.Size = New System.Drawing.Size(41, 13)
        Me.lblGetObject.TabIndex = 26
        Me.lblGetObject.Text = "Object:"
        '
        'ucrReceiverGetObject
        '
        Me.ucrReceiverGetObject.AutoSize = True
        Me.ucrReceiverGetObject.frmParent = Nothing
        Me.ucrReceiverGetObject.Location = New System.Drawing.Point(239, 117)
        Me.ucrReceiverGetObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverGetObject.Name = "ucrReceiverGetObject"
        Me.ucrReceiverGetObject.Selector = Nothing
        Me.ucrReceiverGetObject.Size = New System.Drawing.Size(158, 20)
        Me.ucrReceiverGetObject.strNcFilePath = ""
        Me.ucrReceiverGetObject.TabIndex = 27
        Me.ucrReceiverGetObject.ucrSelector = Nothing
        '
        'rdoGetDataFrame
        '
        Me.rdoGetDataFrame.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGetDataFrame.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetDataFrame.FlatAppearance.BorderSize = 2
        Me.rdoGetDataFrame.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetDataFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGetDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGetDataFrame.Location = New System.Drawing.Point(79, 12)
        Me.rdoGetDataFrame.Name = "rdoGetDataFrame"
        Me.rdoGetDataFrame.Size = New System.Drawing.Size(80, 30)
        Me.rdoGetDataFrame.TabIndex = 44
        Me.rdoGetDataFrame.TabStop = True
        Me.rdoGetDataFrame.Text = "Data Frame"
        Me.rdoGetDataFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGetDataFrame.UseVisualStyleBackColor = True
        '
        'rdoGetColumn
        '
        Me.rdoGetColumn.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGetColumn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetColumn.FlatAppearance.BorderSize = 2
        Me.rdoGetColumn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGetColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGetColumn.Location = New System.Drawing.Point(157, 12)
        Me.rdoGetColumn.Name = "rdoGetColumn"
        Me.rdoGetColumn.Size = New System.Drawing.Size(80, 30)
        Me.rdoGetColumn.TabIndex = 45
        Me.rdoGetColumn.TabStop = True
        Me.rdoGetColumn.Text = "Column"
        Me.rdoGetColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGetColumn.UseVisualStyleBackColor = True
        '
        'ucrPnlGetData
        '
        Me.ucrPnlGetData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlGetData.Location = New System.Drawing.Point(5, 10)
        Me.ucrPnlGetData.Name = "ucrPnlGetData"
        Me.ucrPnlGetData.Size = New System.Drawing.Size(402, 36)
        Me.ucrPnlGetData.TabIndex = 42
        '
        'ucrSelectorGetObject
        '
        Me.ucrSelectorGetObject.AutoSize = True
        Me.ucrSelectorGetObject.bDropUnusedFilterLevels = False
        Me.ucrSelectorGetObject.bShowHiddenColumns = False
        Me.ucrSelectorGetObject.bUseCurrentFilter = True
        Me.ucrSelectorGetObject.Location = New System.Drawing.Point(9, 54)
        Me.ucrSelectorGetObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorGetObject.Name = "ucrSelectorGetObject"
        Me.ucrSelectorGetObject.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorGetObject.TabIndex = 34
        '
        'tbPageFinally
        '
        Me.tbPageFinally.Controls.Add(Me.lblRemoveObject)
        Me.tbPageFinally.Controls.Add(Me.ucrInputRemoveObjects)
        Me.tbPageFinally.Location = New System.Drawing.Point(4, 22)
        Me.tbPageFinally.Name = "tbPageFinally"
        Me.tbPageFinally.Size = New System.Drawing.Size(438, 245)
        Me.tbPageFinally.TabIndex = 3
        Me.tbPageFinally.Text = "Finally"
        Me.tbPageFinally.UseVisualStyleBackColor = True
        '
        'lblRemoveObject
        '
        Me.lblRemoveObject.AutoSize = True
        Me.lblRemoveObject.Location = New System.Drawing.Point(14, 14)
        Me.lblRemoveObject.Name = "lblRemoveObject"
        Me.lblRemoveObject.Size = New System.Drawing.Size(95, 13)
        Me.lblRemoveObject.TabIndex = 3
        Me.lblRemoveObject.Text = "Remove Object(s):"
        '
        'ucrInputRemoveObjects
        '
        Me.ucrInputRemoveObjects.AddQuotesIfUnrecognised = True
        Me.ucrInputRemoveObjects.AutoSize = True
        Me.ucrInputRemoveObjects.IsMultiline = False
        Me.ucrInputRemoveObjects.IsReadOnly = False
        Me.ucrInputRemoveObjects.Location = New System.Drawing.Point(17, 30)
        Me.ucrInputRemoveObjects.Name = "ucrInputRemoveObjects"
        Me.ucrInputRemoveObjects.Size = New System.Drawing.Size(197, 21)
        Me.ucrInputRemoveObjects.TabIndex = 2
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPreview.Location = New System.Drawing.Point(9, 281)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(48, 13)
        Me.lblPreview.TabIndex = 30
        Me.lblPreview.Text = "Preview:"
        '
        'txtScript
        '
        Me.txtScript.Location = New System.Drawing.Point(5, 299)
        Me.txtScript.Multiline = True
        Me.txtScript.Name = "txtScript"
        Me.txtScript.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtScript.Size = New System.Drawing.Size(445, 96)
        Me.txtScript.TabIndex = 32
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(6, 399)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 16
        '
        'dlgScript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(458, 458)
        Me.Controls.Add(Me.txtScript)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.tbFeatures)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgScript"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Script"
        Me.tbFeatures.ResumeLayout(False)
        Me.tbPageLibrary.ResumeLayout(False)
        Me.tbPageLibrary.PerformLayout()
        Me.tbPageSaveData.ResumeLayout(False)
        Me.tbPageSaveData.PerformLayout()
        Me.tbPageGetData.ResumeLayout(False)
        Me.tbPageGetData.PerformLayout()
        Me.tbPageFinally.ResumeLayout(False)
        Me.tbPageFinally.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrameGetDF As ucrDataFrame
    Friend WithEvents tbFeatures As TabControl
    Friend WithEvents tbPageGetData As TabPage
    Friend WithEvents tbPageSaveData As TabPage
    Friend WithEvents lblPreview As Label
    Friend WithEvents ucrSaveData As ucrSave
    Friend WithEvents tbPageFinally As TabPage
    Friend WithEvents ucrDataFrameSaveOutputSelect As ucrDataFrame
    Friend WithEvents ucrSelectorGetObject As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblGetObject As Label
    Friend WithEvents ucrReceiverGetObject As ucrReceiverSingle
    Friend WithEvents ucrPnlGetData As UcrPanel
    Friend WithEvents rdoGetDataFrame As RadioButton
    Friend WithEvents rdoGetColumn As RadioButton
    Friend WithEvents rdoGetOutputObject As RadioButton
    Friend WithEvents rdoSaveOutputObject As RadioButton
    Friend WithEvents rdoSaveDataFrame As RadioButton
    Friend WithEvents rdoSaveColumn As RadioButton
    Friend WithEvents ucrPnlSaveData As UcrPanel
    Friend WithEvents txtScript As TextBox
    Friend WithEvents lblGetObjectType As Label
    Friend WithEvents ucrCboGetOutputObjectType As ucrInputComboBox
    Friend WithEvents tbPageLibrary As TabPage
    Friend WithEvents ucrCboLibPackage As ucrInputComboBox
    Friend WithEvents lblGetPackage As Label
    Friend WithEvents lblSaveObjectType As Label
    Friend WithEvents ucrCboSaveOutputObjectType As ucrInputComboBox
    Friend WithEvents lblSaveObjectFormat As Label
    Friend WithEvents ucrCboSaveOutputObjectFormat As ucrInputComboBox
    Friend WithEvents lblRemoveObject As Label
    Friend WithEvents ucrInputRemoveObjects As ucrInputTextBox
End Class
