<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimaticDataEntry
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
        Me.rdoAdd = New System.Windows.Forms.RadioButton()
        Me.rdoEdit = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblStartingDate = New System.Windows.Forms.Label()
        Me.cmdEnterData = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEndingDate = New System.Windows.Forms.Label()
        Me.cmdCheckData = New System.Windows.Forms.Button()
        Me.ttCmdCheckData = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrDateTimePickerStartingDate = New System.Windows.Forms.DateTimePicker()
        Me.ucrDateTimePickerEndingDate = New System.Windows.Forms.DateTimePicker()
        Me.ucrInputPeriodOption = New instat.ucrInputComboBox()
        Me.ucrReceiverVariables = New instat.ucrReceiverMultiple()
        Me.ucrSelectorClimaticDataEntry = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputSelectStation = New instat.ucrInputFactorLevels()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverElements = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'rdoAdd
        '
        Me.rdoAdd.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoAdd.Enabled = False
        Me.rdoAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAdd.FlatAppearance.BorderSize = 2
        Me.rdoAdd.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAdd.Location = New System.Drawing.Point(74, 12)
        Me.rdoAdd.Name = "rdoAdd"
        Me.rdoAdd.Size = New System.Drawing.Size(135, 27)
        Me.rdoAdd.TabIndex = 1
        Me.rdoAdd.Text = "Add"
        Me.rdoAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoAdd.UseVisualStyleBackColor = True
        '
        'rdoEdit
        '
        Me.rdoEdit.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoEdit.Enabled = False
        Me.rdoEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEdit.FlatAppearance.BorderSize = 2
        Me.rdoEdit.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoEdit.Location = New System.Drawing.Point(207, 12)
        Me.rdoEdit.Name = "rdoEdit"
        Me.rdoEdit.Size = New System.Drawing.Size(135, 27)
        Me.rdoEdit.TabIndex = 2
        Me.rdoEdit.Text = "Edit"
        Me.rdoEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoEdit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(264, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Select station:"
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElement.Location = New System.Drawing.Point(264, 219)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(91, 13)
        Me.lblElement.TabIndex = 10
        Me.lblElement.Text = "Element(s) to edit:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(264, 177)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "Date:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStation.Location = New System.Drawing.Point(264, 90)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 4
        Me.lblStation.Text = "Station:"
        '
        'lblStartingDate
        '
        Me.lblStartingDate.AutoSize = True
        Me.lblStartingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblStartingDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStartingDate.Location = New System.Drawing.Point(7, 253)
        Me.lblStartingDate.Name = "lblStartingDate"
        Me.lblStartingDate.Size = New System.Drawing.Size(72, 13)
        Me.lblStartingDate.TabIndex = 12
        Me.lblStartingDate.Tag = ""
        Me.lblStartingDate.Text = "Starting Date:"
        '
        'cmdEnterData
        '
        Me.cmdEnterData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEnterData.Location = New System.Drawing.Point(7, 311)
        Me.cmdEnterData.Name = "cmdEnterData"
        Me.cmdEnterData.Size = New System.Drawing.Size(72, 24)
        Me.cmdEnterData.TabIndex = 14
        Me.cmdEnterData.Text = "Enter Data"
        Me.cmdEnterData.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(264, 344)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Variable(s) to View:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(264, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Period option:"
        '
        'lblEndingDate
        '
        Me.lblEndingDate.AutoSize = True
        Me.lblEndingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblEndingDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEndingDate.Location = New System.Drawing.Point(7, 285)
        Me.lblEndingDate.Name = "lblEndingDate"
        Me.lblEndingDate.Size = New System.Drawing.Size(69, 13)
        Me.lblEndingDate.TabIndex = 87
        Me.lblEndingDate.Tag = ""
        Me.lblEndingDate.Text = "Ending Date:"
        '
        'cmdCheckData
        '
        Me.cmdCheckData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCheckData.Location = New System.Drawing.Point(81, 311)
        Me.cmdCheckData.Name = "cmdCheckData"
        Me.cmdCheckData.Size = New System.Drawing.Size(72, 24)
        Me.cmdCheckData.TabIndex = 89
        Me.cmdCheckData.Text = "Check Data"
        Me.cmdCheckData.UseVisualStyleBackColor = True
        '
        'ttCmdCheckData
        '
        Me.ttCmdCheckData.AutoPopDelay = 10000
        Me.ttCmdCheckData.InitialDelay = 500
        Me.ttCmdCheckData.ReshowDelay = 100
        '
        'ucrDateTimePickerStartingDate
        '
        Me.ucrDateTimePickerStartingDate.Location = New System.Drawing.Point(82, 250)
        Me.ucrDateTimePickerStartingDate.Name = "ucrDateTimePickerStartingDate"
        Me.ucrDateTimePickerStartingDate.Size = New System.Drawing.Size(135, 20)
        Me.ucrDateTimePickerStartingDate.TabIndex = 90
        '
        'ucrDateTimePickerEndingDate
        '
        Me.ucrDateTimePickerEndingDate.Location = New System.Drawing.Point(82, 281)
        Me.ucrDateTimePickerEndingDate.Name = "ucrDateTimePickerEndingDate"
        Me.ucrDateTimePickerEndingDate.Size = New System.Drawing.Size(135, 20)
        Me.ucrDateTimePickerEndingDate.TabIndex = 91
        '
        'ucrInputPeriodOption
        '
        Me.ucrInputPeriodOption.AddQuotesIfUnrecognised = True
        Me.ucrInputPeriodOption.GetSetSelectedIndex = -1
        Me.ucrInputPeriodOption.IsReadOnly = False
        Me.ucrInputPeriodOption.Location = New System.Drawing.Point(263, 67)
        Me.ucrInputPeriodOption.Name = "ucrInputPeriodOption"
        Me.ucrInputPeriodOption.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputPeriodOption.TabIndex = 85
        '
        'ucrReceiverVariables
        '
        Me.ucrReceiverVariables.frmParent = Me
        Me.ucrReceiverVariables.Location = New System.Drawing.Point(263, 361)
        Me.ucrReceiverVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVariables.Name = "ucrReceiverVariables"
        Me.ucrReceiverVariables.Selector = Nothing
        Me.ucrReceiverVariables.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverVariables.strNcFilePath = ""
        Me.ucrReceiverVariables.TabIndex = 83
        Me.ucrReceiverVariables.ucrSelector = Nothing
        '
        'ucrSelectorClimaticDataEntry
        '
        Me.ucrSelectorClimaticDataEntry.bDropUnusedFilterLevels = False
        Me.ucrSelectorClimaticDataEntry.bShowHiddenColumns = False
        Me.ucrSelectorClimaticDataEntry.bUseCurrentFilter = True
        Me.ucrSelectorClimaticDataEntry.Location = New System.Drawing.Point(7, 55)
        Me.ucrSelectorClimaticDataEntry.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorClimaticDataEntry.Name = "ucrSelectorClimaticDataEntry"
        Me.ucrSelectorClimaticDataEntry.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorClimaticDataEntry.TabIndex = 3
        '
        'ucrInputSelectStation
        '
        Me.ucrInputSelectStation.AddQuotesIfUnrecognised = True
        Me.ucrInputSelectStation.GetSetSelectedIndex = -1
        Me.ucrInputSelectStation.IsReadOnly = False
        Me.ucrInputSelectStation.Location = New System.Drawing.Point(263, 149)
        Me.ucrInputSelectStation.Name = "ucrInputSelectStation"
        Me.ucrInputSelectStation.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputSelectStation.TabIndex = 7
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(263, 106)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 5
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(263, 193)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 9
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverElements
        '
        Me.ucrReceiverElements.frmParent = Me
        Me.ucrReceiverElements.Location = New System.Drawing.Point(263, 236)
        Me.ucrReceiverElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElements.Name = "ucrReceiverElements"
        Me.ucrReceiverElements.Selector = Nothing
        Me.ucrReceiverElements.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverElements.strNcFilePath = ""
        Me.ucrReceiverElements.TabIndex = 11
        Me.ucrReceiverElements.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 467)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(404, 52)
        Me.ucrBase.TabIndex = 82
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.Location = New System.Drawing.Point(69, 10)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(278, 35)
        Me.ucrPnlOptions.TabIndex = 26
        '
        'dlgClimaticDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 520)
        Me.Controls.Add(Me.ucrDateTimePickerEndingDate)
        Me.Controls.Add(Me.ucrDateTimePickerStartingDate)
        Me.Controls.Add(Me.cmdCheckData)
        Me.Controls.Add(Me.lblEndingDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ucrInputPeriodOption)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ucrReceiverVariables)
        Me.Controls.Add(Me.ucrSelectorClimaticDataEntry)
        Me.Controls.Add(Me.cmdEnterData)
        Me.Controls.Add(Me.ucrInputSelectStation)
        Me.Controls.Add(Me.lblStartingDate)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.ucrReceiverElements)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rdoAdd)
        Me.Controls.Add(Me.rdoEdit)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgClimaticDataEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Daily Data Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdoAdd As RadioButton
    Friend WithEvents rdoEdit As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblElement As Label
    Friend WithEvents ucrReceiverElements As ucrReceiverMultiple
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents lblDate As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents lblStartingDate As Label
    Friend WithEvents ucrInputSelectStation As ucrInputFactorLevels
    Friend WithEvents cmdEnterData As Button
    Friend WithEvents ucrSelectorClimaticDataEntry As ucrSelectorByDataFrameAddRemove
    Friend WithEvents Label2 As Label
    Friend WithEvents ucrReceiverVariables As ucrReceiverMultiple
    Friend WithEvents Label3 As Label
    Friend WithEvents ucrInputPeriodOption As ucrInputComboBox
    Friend WithEvents cmdCheckData As Button
    Friend WithEvents lblEndingDate As Label
    Friend WithEvents ttCmdCheckData As ToolTip
    Friend WithEvents ucrDateTimePickerStartingDate As DateTimePicker
    Friend WithEvents ucrDateTimePickerEndingDate As DateTimePicker
End Class
