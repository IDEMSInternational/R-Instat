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
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.lblEndingDate = New System.Windows.Forms.Label()
        Me.cmdCheckData = New System.Windows.Forms.Button()
        Me.ttCmdCheckData = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrInputType = New instat.ucrInputComboBox()
        Me.ucrReceiverViewVariables = New instat.ucrReceiverMultiple()
        Me.ucrSelectorClimaticDataEntry = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputSelectStation = New instat.ucrInputFactorLevels()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverElements = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrStartDate = New instat.ucrDateTimePicker()
        Me.ucrEndDate = New instat.ucrDateTimePicker()
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
        Me.rdoAdd.Location = New System.Drawing.Point(96, 12)
        Me.rdoAdd.Name = "rdoAdd"
        Me.rdoAdd.Size = New System.Drawing.Size(110, 27)
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
        Me.rdoEdit.Location = New System.Drawing.Point(204, 12)
        Me.rdoEdit.Name = "rdoEdit"
        Me.rdoEdit.Size = New System.Drawing.Size(110, 27)
        Me.rdoEdit.TabIndex = 2
        Me.rdoEdit.Text = "Edit"
        Me.rdoEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoEdit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(264, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Select Station:"
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElement.Location = New System.Drawing.Point(264, 214)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(86, 13)
        Me.lblElement.TabIndex = 12
        Me.lblElement.Text = "Elements to Edit:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(264, 172)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 10
        Me.lblDate.Text = "Date:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStation.Location = New System.Drawing.Point(264, 87)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 6
        Me.lblStation.Text = "Station:"
        '
        'lblStartingDate
        '
        Me.lblStartingDate.AutoSize = True
        Me.lblStartingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblStartingDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStartingDate.Location = New System.Drawing.Point(7, 278)
        Me.lblStartingDate.Name = "lblStartingDate"
        Me.lblStartingDate.Size = New System.Drawing.Size(58, 13)
        Me.lblStartingDate.TabIndex = 16
        Me.lblStartingDate.Tag = ""
        Me.lblStartingDate.Text = "Start Date:"
        '
        'cmdEnterData
        '
        Me.cmdEnterData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEnterData.Location = New System.Drawing.Point(7, 415)
        Me.cmdEnterData.Name = "cmdEnterData"
        Me.cmdEnterData.Size = New System.Drawing.Size(106, 24)
        Me.cmdEnterData.TabIndex = 20
        Me.cmdEnterData.Text = "Enter Data"
        Me.cmdEnterData.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(264, 339)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Variables to View:"
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPeriod.Location = New System.Drawing.Point(141, 52)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(34, 13)
        Me.lblPeriod.TabIndex = 4
        Me.lblPeriod.Text = "Type:"
        '
        'lblEndingDate
        '
        Me.lblEndingDate.AutoSize = True
        Me.lblEndingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblEndingDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEndingDate.Location = New System.Drawing.Point(7, 310)
        Me.lblEndingDate.Name = "lblEndingDate"
        Me.lblEndingDate.Size = New System.Drawing.Size(55, 13)
        Me.lblEndingDate.TabIndex = 18
        Me.lblEndingDate.Tag = ""
        Me.lblEndingDate.Text = "End Date:"
        '
        'cmdCheckData
        '
        Me.cmdCheckData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCheckData.Location = New System.Drawing.Point(137, 415)
        Me.cmdCheckData.Name = "cmdCheckData"
        Me.cmdCheckData.Size = New System.Drawing.Size(72, 24)
        Me.cmdCheckData.TabIndex = 21
        Me.cmdCheckData.Text = "Check Data"
        Me.cmdCheckData.UseVisualStyleBackColor = True
        '
        'ttCmdCheckData
        '
        Me.ttCmdCheckData.AutoPopDelay = 10000
        Me.ttCmdCheckData.InitialDelay = 500
        Me.ttCmdCheckData.ReshowDelay = 100
        '
        'ucrInputType
        '
        Me.ucrInputType.AddQuotesIfUnrecognised = True
        Me.ucrInputType.GetSetSelectedIndex = -1
        Me.ucrInputType.IsReadOnly = False
        Me.ucrInputType.Location = New System.Drawing.Point(184, 49)
        Me.ucrInputType.Name = "ucrInputType"
        Me.ucrInputType.Size = New System.Drawing.Size(85, 21)
        Me.ucrInputType.TabIndex = 5
        '
        'ucrReceiverViewVariables
        '
        Me.ucrReceiverViewVariables.frmParent = Me
        Me.ucrReceiverViewVariables.Location = New System.Drawing.Point(263, 356)
        Me.ucrReceiverViewVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverViewVariables.Name = "ucrReceiverViewVariables"
        Me.ucrReceiverViewVariables.Selector = Nothing
        Me.ucrReceiverViewVariables.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverViewVariables.strNcFilePath = ""
        Me.ucrReceiverViewVariables.TabIndex = 15
        Me.ucrReceiverViewVariables.ucrSelector = Nothing
        '
        'ucrSelectorClimaticDataEntry
        '
        Me.ucrSelectorClimaticDataEntry.bDropUnusedFilterLevels = False
        Me.ucrSelectorClimaticDataEntry.bShowHiddenColumns = False
        Me.ucrSelectorClimaticDataEntry.bUseCurrentFilter = True
        Me.ucrSelectorClimaticDataEntry.Location = New System.Drawing.Point(7, 80)
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
        Me.ucrInputSelectStation.Location = New System.Drawing.Point(263, 144)
        Me.ucrInputSelectStation.Name = "ucrInputSelectStation"
        Me.ucrInputSelectStation.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputSelectStation.TabIndex = 9
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(263, 103)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 7
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(263, 188)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 11
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverElements
        '
        Me.ucrReceiverElements.frmParent = Me
        Me.ucrReceiverElements.Location = New System.Drawing.Point(263, 231)
        Me.ucrReceiverElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElements.Name = "ucrReceiverElements"
        Me.ucrReceiverElements.Selector = Nothing
        Me.ucrReceiverElements.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverElements.strNcFilePath = ""
        Me.ucrReceiverElements.TabIndex = 13
        Me.ucrReceiverElements.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 467)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(404, 52)
        Me.ucrBase.TabIndex = 22
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.Location = New System.Drawing.Point(66, 8)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(278, 35)
        Me.ucrPnlOptions.TabIndex = 26
        '
        'ucrStartDate
        '
        Me.ucrStartDate.DateValue = New Date(2021, 3, 27, 16, 14, 1, 567)
        Me.ucrStartDate.Format = "dd MMM yyyy"
        Me.ucrStartDate.Location = New System.Drawing.Point(74, 276)
        Me.ucrStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrStartDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrStartDate.Name = "ucrStartDate"
        Me.ucrStartDate.Size = New System.Drawing.Size(135, 20)
        Me.ucrStartDate.TabIndex = 27
        '
        'ucrEndDate
        '
        Me.ucrEndDate.DateValue = New Date(2021, 3, 27, 16, 14, 1, 560)
        Me.ucrEndDate.Format = "dd MMM yyyy"
        Me.ucrEndDate.Location = New System.Drawing.Point(74, 307)
        Me.ucrEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrEndDate.Name = "ucrEndDate"
        Me.ucrEndDate.Size = New System.Drawing.Size(135, 20)
        Me.ucrEndDate.TabIndex = 28
        '
        'dlgClimaticDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 520)
        Me.Controls.Add(Me.ucrEndDate)
        Me.Controls.Add(Me.ucrStartDate)
        Me.Controls.Add(Me.cmdCheckData)
        Me.Controls.Add(Me.lblEndingDate)
        Me.Controls.Add(Me.lblPeriod)
        Me.Controls.Add(Me.ucrInputType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ucrReceiverViewVariables)
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
    Friend WithEvents ucrReceiverViewVariables As ucrReceiverMultiple
    Friend WithEvents lblPeriod As Label
    Friend WithEvents ucrInputType As ucrInputComboBox
    Friend WithEvents cmdCheckData As Button
    Friend WithEvents lblEndingDate As Label
    Friend WithEvents ttCmdCheckData As ToolTip
    Friend WithEvents ucrEndDate As ucrDateTimePicker
    Friend WithEvents ucrStartDate As ucrDateTimePicker
End Class
