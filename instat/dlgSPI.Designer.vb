<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgSPI
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
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.rdoSPEI = New System.Windows.Forms.RadioButton()
        Me.rdoSPI = New System.Windows.Forms.RadioButton()
        Me.ucrPnlIndex = New instat.UcrPanel()
        Me.lblTimeScale = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.grpKernel = New System.Windows.Forms.GroupBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.ucrInputType = New instat.ucrInputComboBox()
        Me.lblShift = New System.Windows.Forms.Label()
        Me.ucrNudKernelShift = New instat.ucrNud()
        Me.ucrSaveModel = New instat.ucrSave()
        Me.ucrSaveIndex = New instat.ucrSave()
        Me.ucrNudTimeScale = New instat.ucrNud()
        Me.ucrChkOmitMissingValues = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSelectorVariable = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpKernel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStation.Location = New System.Drawing.Point(262, 65)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 4
        Me.lblStation.Text = "Station:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYear.Location = New System.Drawing.Point(262, 112)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 6
        Me.lblYear.Text = "Year:"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMonth.Location = New System.Drawing.Point(262, 159)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 13)
        Me.lblMonth.TabIndex = 8
        Me.lblMonth.Text = "Month:"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblData.Location = New System.Drawing.Point(262, 206)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(48, 13)
        Me.lblData.TabIndex = 10
        Me.lblData.Text = "Element:"
        '
        'rdoSPEI
        '
        Me.rdoSPEI.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSPEI.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSPEI.FlatAppearance.BorderSize = 2
        Me.rdoSPEI.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSPEI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSPEI.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSPEI.Location = New System.Drawing.Point(210, 12)
        Me.rdoSPEI.Name = "rdoSPEI"
        Me.rdoSPEI.Size = New System.Drawing.Size(82, 27)
        Me.rdoSPEI.TabIndex = 2
        Me.rdoSPEI.TabStop = True
        Me.rdoSPEI.Text = "SPEI"
        Me.rdoSPEI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSPEI.UseVisualStyleBackColor = True
        '
        'rdoSPI
        '
        Me.rdoSPI.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSPI.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSPI.FlatAppearance.BorderSize = 2
        Me.rdoSPI.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSPI.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSPI.Location = New System.Drawing.Point(130, 12)
        Me.rdoSPI.Name = "rdoSPI"
        Me.rdoSPI.Size = New System.Drawing.Size(82, 27)
        Me.rdoSPI.TabIndex = 1
        Me.rdoSPI.TabStop = True
        Me.rdoSPI.Text = "SPI"
        Me.rdoSPI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSPI.UseVisualStyleBackColor = True
        '
        'ucrPnlIndex
        '
        Me.ucrPnlIndex.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlIndex.Location = New System.Drawing.Point(125, 8)
        Me.ucrPnlIndex.Name = "ucrPnlIndex"
        Me.ucrPnlIndex.Size = New System.Drawing.Size(176, 35)
        Me.ucrPnlIndex.TabIndex = 0
        '
        'lblTimeScale
        '
        Me.lblTimeScale.AutoSize = True
        Me.lblTimeScale.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTimeScale.Location = New System.Drawing.Point(12, 314)
        Me.lblTimeScale.Name = "lblTimeScale"
        Me.lblTimeScale.Size = New System.Drawing.Size(107, 13)
        Me.lblTimeScale.TabIndex = 13
        Me.lblTimeScale.Text = "Time Scale (Months):"
        '
        'grpKernel
        '
        Me.grpKernel.Controls.Add(Me.lblType)
        Me.grpKernel.Controls.Add(Me.ucrInputType)
        Me.grpKernel.Controls.Add(Me.lblShift)
        Me.grpKernel.Controls.Add(Me.ucrNudKernelShift)
        Me.grpKernel.Location = New System.Drawing.Point(10, 233)
        Me.grpKernel.Name = "grpKernel"
        Me.grpKernel.Size = New System.Drawing.Size(210, 73)
        Me.grpKernel.TabIndex = 12
        Me.grpKernel.TabStop = False
        Me.grpKernel.Text = "Kernel"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblType.Location = New System.Drawing.Point(7, 22)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(34, 13)
        Me.lblType.TabIndex = 0
        Me.lblType.Text = "Type:"
        '
        'ucrInputType
        '
        Me.ucrInputType.AddQuotesIfUnrecognised = True
        Me.ucrInputType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputType.GetSetSelectedIndex = -1
        Me.ucrInputType.IsReadOnly = False
        Me.ucrInputType.Location = New System.Drawing.Point(67, 19)
        Me.ucrInputType.Name = "ucrInputType"
        Me.ucrInputType.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputType.TabIndex = 1
        '
        'lblShift
        '
        Me.lblShift.AutoSize = True
        Me.lblShift.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblShift.Location = New System.Drawing.Point(7, 49)
        Me.lblShift.Name = "lblShift"
        Me.lblShift.Size = New System.Drawing.Size(31, 13)
        Me.lblShift.TabIndex = 2
        Me.lblShift.Text = "Shift:"
        '
        'ucrNudKernelShift
        '
        Me.ucrNudKernelShift.AutoSize = True
        Me.ucrNudKernelShift.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudKernelShift.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudKernelShift.Location = New System.Drawing.Point(67, 46)
        Me.ucrNudKernelShift.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.ucrNudKernelShift.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudKernelShift.Name = "ucrNudKernelShift"
        Me.ucrNudKernelShift.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudKernelShift.TabIndex = 3
        Me.ucrNudKernelShift.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSaveModel
        '
        Me.ucrSaveModel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveModel.Location = New System.Drawing.Point(10, 365)
        Me.ucrSaveModel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveModel.Name = "ucrSaveModel"
        Me.ucrSaveModel.Size = New System.Drawing.Size(320, 24)
        Me.ucrSaveModel.TabIndex = 16
        '
        'ucrSaveIndex
        '
        Me.ucrSaveIndex.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveIndex.Location = New System.Drawing.Point(10, 394)
        Me.ucrSaveIndex.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveIndex.Name = "ucrSaveIndex"
        Me.ucrSaveIndex.Size = New System.Drawing.Size(320, 24)
        Me.ucrSaveIndex.TabIndex = 17
        '
        'ucrNudTimeScale
        '
        Me.ucrNudTimeScale.AutoSize = True
        Me.ucrNudTimeScale.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTimeScale.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTimeScale.Location = New System.Drawing.Point(144, 311)
        Me.ucrNudTimeScale.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.ucrNudTimeScale.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTimeScale.Name = "ucrNudTimeScale"
        Me.ucrNudTimeScale.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTimeScale.TabIndex = 14
        Me.ucrNudTimeScale.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ucrChkOmitMissingValues
        '
        Me.ucrChkOmitMissingValues.AutoSize = True
        Me.ucrChkOmitMissingValues.Checked = False
        Me.ucrChkOmitMissingValues.Location = New System.Drawing.Point(10, 337)
        Me.ucrChkOmitMissingValues.Name = "ucrChkOmitMissingValues"
        Me.ucrChkOmitMissingValues.Size = New System.Drawing.Size(256, 23)
        Me.ucrChkOmitMissingValues.TabIndex = 15
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 423)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 18
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.AutoSize = True
        Me.ucrReceiverElement.frmParent = Me
        Me.ucrReceiverElement.Location = New System.Drawing.Point(262, 221)
        Me.ucrReceiverElement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.TabIndex = 11
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.AutoSize = True
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(262, 174)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 9
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(262, 127)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 7
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(262, 80)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 5
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSelectorVariable
        '
        Me.ucrSelectorVariable.AutoSize = True
        Me.ucrSelectorVariable.bDropUnusedFilterLevels = False
        Me.ucrSelectorVariable.bShowHiddenColumns = False
        Me.ucrSelectorVariable.bUseCurrentFilter = True
        Me.ucrSelectorVariable.Location = New System.Drawing.Point(10, 48)
        Me.ucrSelectorVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorVariable.Name = "ucrSelectorVariable"
        Me.ucrSelectorVariable.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorVariable.TabIndex = 3
        '
        'dlgSPI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(412, 478)
        Me.Controls.Add(Me.rdoSPEI)
        Me.Controls.Add(Me.rdoSPI)
        Me.Controls.Add(Me.ucrPnlIndex)
        Me.Controls.Add(Me.ucrSaveModel)
        Me.Controls.Add(Me.ucrSaveIndex)
        Me.Controls.Add(Me.grpKernel)
        Me.Controls.Add(Me.ucrNudTimeScale)
        Me.Controls.Add(Me.ucrChkOmitMissingValues)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblTimeScale)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverElement)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrSelectorVariable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSPI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SPI/SPEI"
        Me.grpKernel.ResumeLayout(False)
        Me.grpKernel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrSelectorVariable As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverElement As ucrReceiverSingle
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblData As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents rdoSPEI As RadioButton
    Friend WithEvents rdoSPI As RadioButton
    Friend WithEvents lblTimeScale As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkOmitMissingValues As ucrCheck
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ucrNudTimeScale As ucrNud
    Friend WithEvents grpKernel As GroupBox
    Friend WithEvents lblShift As Label
    Friend WithEvents ucrNudKernelShift As ucrNud
    Friend WithEvents ucrPnlIndex As UcrPanel
    Friend WithEvents ucrSaveIndex As ucrSave
    Friend WithEvents ucrSaveModel As ucrSave
    Friend WithEvents lblType As Label
    Friend WithEvents ucrInputType As ucrInputComboBox
End Class