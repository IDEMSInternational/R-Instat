<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgClimaticDataEntry
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
        Me.rdoDaily = New System.Windows.Forms.RadioButton()
        Me.rdoMonthly = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblStartingDate = New System.Windows.Forms.Label()
        Me.ReoGridControl1 = New unvell.ReoGrid.ReoGridControl()
        Me.ucrDateTimePickerFrom = New instat.ucrDateTimePicker()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverElements = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverLevel = New instat.ucrReceiverSingle()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrSelectorClimaticDataEntry = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'rdoDaily
        '
        Me.rdoDaily.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDaily.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoDaily.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDaily.FlatAppearance.BorderSize = 2
        Me.rdoDaily.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDaily.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDaily.Location = New System.Drawing.Point(74, 12)
        Me.rdoDaily.Name = "rdoDaily"
        Me.rdoDaily.Size = New System.Drawing.Size(135, 27)
        Me.rdoDaily.TabIndex = 25
        Me.rdoDaily.Text = "Daily"
        Me.rdoDaily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDaily.UseVisualStyleBackColor = True
        '
        'rdoMonthly
        '
        Me.rdoMonthly.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMonthly.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMonthly.FlatAppearance.BorderSize = 2
        Me.rdoMonthly.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMonthly.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMonthly.Location = New System.Drawing.Point(207, 12)
        Me.rdoMonthly.Name = "rdoMonthly"
        Me.rdoMonthly.Size = New System.Drawing.Size(135, 27)
        Me.rdoMonthly.TabIndex = 24
        Me.rdoMonthly.Text = "Monthly"
        Me.rdoMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMonthly.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(264, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Level:"
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElement.Location = New System.Drawing.Point(264, 182)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(59, 13)
        Me.lblElement.TabIndex = 8
        Me.lblElement.Text = "Element(s):"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(264, 140)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "Date:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStation.Location = New System.Drawing.Point(264, 53)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 1
        Me.lblStation.Text = "Station:"
        '
        'lblStartingDate
        '
        Me.lblStartingDate.AutoSize = True
        Me.lblStartingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblStartingDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStartingDate.Location = New System.Drawing.Point(434, 48)
        Me.lblStartingDate.Name = "lblStartingDate"
        Me.lblStartingDate.Size = New System.Drawing.Size(72, 13)
        Me.lblStartingDate.TabIndex = 10
        Me.lblStartingDate.Tag = ""
        Me.lblStartingDate.Text = "Starting Date:"
        '
        'ReoGridControl1
        '
        Me.ReoGridControl1.BackColor = System.Drawing.Color.White
        Me.ReoGridControl1.ColumnHeaderContextMenuStrip = Nothing
        Me.ReoGridControl1.LeadHeaderContextMenuStrip = Nothing
        Me.ReoGridControl1.Location = New System.Drawing.Point(408, 95)
        Me.ReoGridControl1.Name = "ReoGridControl1"
        Me.ReoGridControl1.RowHeaderContextMenuStrip = Nothing
        Me.ReoGridControl1.Script = Nothing
        Me.ReoGridControl1.SheetTabContextMenuStrip = Nothing
        Me.ReoGridControl1.SheetTabNewButtonVisible = True
        Me.ReoGridControl1.SheetTabVisible = True
        Me.ReoGridControl1.SheetTabWidth = 60
        Me.ReoGridControl1.ShowScrollEndSpacing = True
        Me.ReoGridControl1.Size = New System.Drawing.Size(381, 152)
        Me.ReoGridControl1.TabIndex = 83
        Me.ReoGridControl1.Text = "ReoGridControl1"
        '
        'ucrDateTimePickerFrom
        '
        Me.ucrDateTimePickerFrom.Location = New System.Drawing.Point(509, 45)
        Me.ucrDateTimePickerFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDateTimePickerFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDateTimePickerFrom.Name = "ucrDateTimePickerFrom"
        Me.ucrDateTimePickerFrom.Size = New System.Drawing.Size(153, 20)
        Me.ucrDateTimePickerFrom.TabIndex = 11
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(263, 69)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 2
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(263, 156)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 7
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverElements
        '
        Me.ucrReceiverElements.frmParent = Me
        Me.ucrReceiverElements.Location = New System.Drawing.Point(263, 199)
        Me.ucrReceiverElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElements.Name = "ucrReceiverElements"
        Me.ucrReceiverElements.Selector = Nothing
        Me.ucrReceiverElements.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverElements.strNcFilePath = ""
        Me.ucrReceiverElements.TabIndex = 9
        Me.ucrReceiverElements.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(4, 306)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(404, 52)
        Me.ucrBase.TabIndex = 82
        '
        'ucrReceiverLevel
        '
        Me.ucrReceiverLevel.frmParent = Me
        Me.ucrReceiverLevel.Location = New System.Drawing.Point(263, 112)
        Me.ucrReceiverLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLevel.Name = "ucrReceiverLevel"
        Me.ucrReceiverLevel.Selector = Nothing
        Me.ucrReceiverLevel.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverLevel.strNcFilePath = ""
        Me.ucrReceiverLevel.TabIndex = 4
        Me.ucrReceiverLevel.ucrSelector = Nothing
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.Location = New System.Drawing.Point(69, 10)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(278, 35)
        Me.ucrPnlOptions.TabIndex = 26
        '
        'ucrSelectorClimaticDataEntry
        '
        Me.ucrSelectorClimaticDataEntry.bDropUnusedFilterLevels = False
        Me.ucrSelectorClimaticDataEntry.bShowHiddenColumns = False
        Me.ucrSelectorClimaticDataEntry.bUseCurrentFilter = True
        Me.ucrSelectorClimaticDataEntry.Location = New System.Drawing.Point(4, 57)
        Me.ucrSelectorClimaticDataEntry.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorClimaticDataEntry.Name = "ucrSelectorClimaticDataEntry"
        Me.ucrSelectorClimaticDataEntry.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorClimaticDataEntry.TabIndex = 0
        '
        'dlgClimaticDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 360)
        Me.Controls.Add(Me.ReoGridControl1)
        Me.Controls.Add(Me.ucrDateTimePickerFrom)
        Me.Controls.Add(Me.lblStartingDate)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.ucrReceiverElements)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrReceiverLevel)
        Me.Controls.Add(Me.rdoDaily)
        Me.Controls.Add(Me.rdoMonthly)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrSelectorClimaticDataEntry)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgClimaticDataEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Climatic Data Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorClimaticDataEntry As ucrSelectorByDataFrameAddRemove
    Friend WithEvents rdoDaily As RadioButton
    Friend WithEvents rdoMonthly As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrReceiverLevel As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblElement As Label
    Friend WithEvents ucrReceiverElements As ucrReceiverMultiple
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents lblDate As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrDateTimePickerFrom As ucrDateTimePicker
    Friend WithEvents lblStartingDate As Label
    Friend WithEvents ReoGridControl1 As unvell.ReoGrid.ReoGridControl
End Class
