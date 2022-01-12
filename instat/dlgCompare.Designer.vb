<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgCompare
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
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblSateliteElement = New System.Windows.Forms.Label()
        Me.lblStationElement = New System.Windows.Forms.Label()
        Me.lblWithinYear = New System.Windows.Forms.Label()
        Me.rdoAnomalies = New System.Windows.Forms.RadioButton()
        Me.rdoDifferences = New System.Windows.Forms.RadioButton()
        Me.ucrSaveSecondCol = New instat.ucrSave()
        Me.ucrSaveFirstCol = New instat.ucrSave()
        Me.ucrReceiverWithinYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverStationElement = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverSateliteElement = New instat.ucrReceiverSingle()
        Me.ucrNudMovingAverage = New instat.ucrNud()
        Me.ucrPnlCompare = New instat.UcrPanel()
        Me.ucrChkMovingAverage = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorCompare = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStation.Location = New System.Drawing.Point(259, 190)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 8
        Me.lblStation.Text = "Station:"
        '
        'lblSateliteElement
        '
        Me.lblSateliteElement.AutoSize = True
        Me.lblSateliteElement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSateliteElement.Location = New System.Drawing.Point(259, 84)
        Me.lblSateliteElement.Name = "lblSateliteElement"
        Me.lblSateliteElement.Size = New System.Drawing.Size(86, 13)
        Me.lblSateliteElement.TabIndex = 4
        Me.lblSateliteElement.Text = "Satelite Element:"
        '
        'lblStationElement
        '
        Me.lblStationElement.AutoSize = True
        Me.lblStationElement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStationElement.Location = New System.Drawing.Point(258, 137)
        Me.lblStationElement.Name = "lblStationElement"
        Me.lblStationElement.Size = New System.Drawing.Size(84, 13)
        Me.lblStationElement.TabIndex = 6
        Me.lblStationElement.Text = "Station Element:"
        '
        'lblWithinYear
        '
        Me.lblWithinYear.AutoSize = True
        Me.lblWithinYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWithinYear.Location = New System.Drawing.Point(261, 230)
        Me.lblWithinYear.Name = "lblWithinYear"
        Me.lblWithinYear.Size = New System.Drawing.Size(79, 26)
        Me.lblWithinYear.TabIndex = 10
        Me.lblWithinYear.Text = "Mean for each:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Within Year)"
        '
        'rdoAnomalies
        '
        Me.rdoAnomalies.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoAnomalies.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAnomalies.FlatAppearance.BorderSize = 2
        Me.rdoAnomalies.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAnomalies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoAnomalies.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAnomalies.Location = New System.Drawing.Point(213, 12)
        Me.rdoAnomalies.Name = "rdoAnomalies"
        Me.rdoAnomalies.Size = New System.Drawing.Size(98, 27)
        Me.rdoAnomalies.TabIndex = 2
        Me.rdoAnomalies.TabStop = True
        Me.rdoAnomalies.Text = "Anomalies"
        Me.rdoAnomalies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoAnomalies.UseVisualStyleBackColor = True
        '
        'rdoDifferences
        '
        Me.rdoDifferences.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDifferences.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDifferences.FlatAppearance.BorderSize = 2
        Me.rdoDifferences.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDifferences.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDifferences.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDifferences.Location = New System.Drawing.Point(117, 12)
        Me.rdoDifferences.Name = "rdoDifferences"
        Me.rdoDifferences.Size = New System.Drawing.Size(98, 27)
        Me.rdoDifferences.TabIndex = 1
        Me.rdoDifferences.TabStop = True
        Me.rdoDifferences.Text = "Differences"
        Me.rdoDifferences.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDifferences.UseVisualStyleBackColor = True
        '
        'ucrSaveSecondCol
        '
        Me.ucrSaveSecondCol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveSecondCol.Location = New System.Drawing.Point(10, 343)
        Me.ucrSaveSecondCol.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveSecondCol.Name = "ucrSaveSecondCol"
        Me.ucrSaveSecondCol.Size = New System.Drawing.Size(320, 24)
        Me.ucrSaveSecondCol.TabIndex = 24
        '
        'ucrSaveFirstCol
        '
        Me.ucrSaveFirstCol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveFirstCol.Location = New System.Drawing.Point(10, 312)
        Me.ucrSaveFirstCol.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveFirstCol.Name = "ucrSaveFirstCol"
        Me.ucrSaveFirstCol.Size = New System.Drawing.Size(350, 22)
        Me.ucrSaveFirstCol.TabIndex = 23
        '
        'ucrReceiverWithinYear
        '
        Me.ucrReceiverWithinYear.AutoSize = True
        Me.ucrReceiverWithinYear.frmParent = Me
        Me.ucrReceiverWithinYear.Location = New System.Drawing.Point(261, 259)
        Me.ucrReceiverWithinYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWithinYear.Name = "ucrReceiverWithinYear"
        Me.ucrReceiverWithinYear.Selector = Nothing
        Me.ucrReceiverWithinYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWithinYear.strNcFilePath = ""
        Me.ucrReceiverWithinYear.TabIndex = 11
        Me.ucrReceiverWithinYear.ucrSelector = Nothing
        '
        'ucrReceiverStationElement
        '
        Me.ucrReceiverStationElement.AutoSize = True
        Me.ucrReceiverStationElement.frmParent = Me
        Me.ucrReceiverStationElement.Location = New System.Drawing.Point(261, 153)
        Me.ucrReceiverStationElement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStationElement.Name = "ucrReceiverStationElement"
        Me.ucrReceiverStationElement.Selector = Nothing
        Me.ucrReceiverStationElement.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStationElement.strNcFilePath = ""
        Me.ucrReceiverStationElement.TabIndex = 7
        Me.ucrReceiverStationElement.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(261, 206)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 9
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverSateliteElement
        '
        Me.ucrReceiverSateliteElement.AutoSize = True
        Me.ucrReceiverSateliteElement.frmParent = Me
        Me.ucrReceiverSateliteElement.Location = New System.Drawing.Point(261, 100)
        Me.ucrReceiverSateliteElement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSateliteElement.Name = "ucrReceiverSateliteElement"
        Me.ucrReceiverSateliteElement.Selector = Nothing
        Me.ucrReceiverSateliteElement.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSateliteElement.strNcFilePath = ""
        Me.ucrReceiverSateliteElement.TabIndex = 5
        Me.ucrReceiverSateliteElement.ucrSelector = Nothing
        '
        'ucrNudMovingAverage
        '
        Me.ucrNudMovingAverage.AutoSize = True
        Me.ucrNudMovingAverage.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMovingAverage.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMovingAverage.Location = New System.Drawing.Point(175, 280)
        Me.ucrNudMovingAverage.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMovingAverage.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMovingAverage.Name = "ucrNudMovingAverage"
        Me.ucrNudMovingAverage.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMovingAverage.TabIndex = 13
        Me.ucrNudMovingAverage.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlCompare
        '
        Me.ucrPnlCompare.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlCompare.Location = New System.Drawing.Point(101, 8)
        Me.ucrPnlCompare.Name = "ucrPnlCompare"
        Me.ucrPnlCompare.Size = New System.Drawing.Size(225, 35)
        Me.ucrPnlCompare.TabIndex = 0
        '
        'ucrChkMovingAverage
        '
        Me.ucrChkMovingAverage.AutoSize = True
        Me.ucrChkMovingAverage.Checked = False
        Me.ucrChkMovingAverage.Location = New System.Drawing.Point(10, 280)
        Me.ucrChkMovingAverage.Name = "ucrChkMovingAverage"
        Me.ucrChkMovingAverage.Size = New System.Drawing.Size(144, 23)
        Me.ucrChkMovingAverage.TabIndex = 12
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 373)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 22
        '
        'ucrSelectorCompare
        '
        Me.ucrSelectorCompare.AutoSize = True
        Me.ucrSelectorCompare.bDropUnusedFilterLevels = False
        Me.ucrSelectorCompare.bShowHiddenColumns = False
        Me.ucrSelectorCompare.bUseCurrentFilter = True
        Me.ucrSelectorCompare.Location = New System.Drawing.Point(10, 71)
        Me.ucrSelectorCompare.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCompare.Name = "ucrSelectorCompare"
        Me.ucrSelectorCompare.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorCompare.TabIndex = 3
        '
        'dlgCompare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(415, 427)
        Me.Controls.Add(Me.ucrSaveSecondCol)
        Me.Controls.Add(Me.ucrSaveFirstCol)
        Me.Controls.Add(Me.ucrReceiverWithinYear)
        Me.Controls.Add(Me.ucrReceiverStationElement)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrReceiverSateliteElement)
        Me.Controls.Add(Me.lblStationElement)
        Me.Controls.Add(Me.lblSateliteElement)
        Me.Controls.Add(Me.ucrNudMovingAverage)
        Me.Controls.Add(Me.rdoAnomalies)
        Me.Controls.Add(Me.rdoDifferences)
        Me.Controls.Add(Me.ucrPnlCompare)
        Me.Controls.Add(Me.ucrChkMovingAverage)
        Me.Controls.Add(Me.lblWithinYear)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorCompare)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCompare"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compare Satellite Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorCompare As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblStationElement As Label
    Friend WithEvents lblSateliteElement As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents lblWithinYear As Label
    Friend WithEvents ucrChkMovingAverage As ucrCheck
    Friend WithEvents rdoAnomalies As RadioButton
    Friend WithEvents rdoDifferences As RadioButton
    Friend WithEvents ucrPnlCompare As UcrPanel
    Friend WithEvents ucrNudMovingAverage As ucrNud
    Friend WithEvents ucrReceiverSateliteElement As ucrReceiverSingle
    Friend WithEvents ucrReceiverWithinYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverStationElement As ucrReceiverSingle
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrSaveFirstCol As ucrSave
    Friend WithEvents ucrSaveSecondCol As ucrSave
End Class
