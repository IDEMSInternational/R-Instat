<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimaticNCMPRegionAverage
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
        Me.lblNYER = New System.Windows.Forms.Label()
        Me.cmdStationMetadata = New System.Windows.Forms.Button()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.ucrInputResolution = New instat.ucrInputComboBox()
        Me.ucrInputUNCode = New instat.ucrInputTextBox()
        Me.ucrChkOutputGridSquareData = New instat.ucrCheck()
        Me.lblRes = New System.Windows.Forms.Label()
        Me.lblUNCode = New System.Windows.Forms.Label()
        Me.ucrNudNYE = New instat.ucrNud()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorForA3 = New instat.ucrDataFrame()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSelectorForA2 = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNYER
        '
        Me.lblNYER.AutoSize = True
        Me.lblNYER.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNYER.Location = New System.Drawing.Point(5, 21)
        Me.lblNYER.Name = "lblNYER"
        Me.lblNYER.Size = New System.Drawing.Size(152, 13)
        Me.lblNYER.TabIndex = 2
        Me.lblNYER.Text = "End Year for Variogram Period:"
        '
        'cmdStationMetadata
        '
        Me.cmdStationMetadata.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdStationMetadata.Location = New System.Drawing.Point(254, 181)
        Me.cmdStationMetadata.Name = "cmdStationMetadata"
        Me.cmdStationMetadata.Size = New System.Drawing.Size(120, 23)
        Me.cmdStationMetadata.TabIndex = 7
        Me.cmdStationMetadata.Text = "Station Metadata"
        Me.cmdStationMetadata.UseVisualStyleBackColor = True
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrInputResolution)
        Me.grpOptions.Controls.Add(Me.ucrInputUNCode)
        Me.grpOptions.Controls.Add(Me.ucrChkOutputGridSquareData)
        Me.grpOptions.Controls.Add(Me.lblRes)
        Me.grpOptions.Controls.Add(Me.lblUNCode)
        Me.grpOptions.Controls.Add(Me.ucrNudNYE)
        Me.grpOptions.Controls.Add(Me.lblNYER)
        Me.grpOptions.Location = New System.Drawing.Point(162, 216)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(286, 124)
        Me.grpOptions.TabIndex = 9
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'ucrInputResolution
        '
        Me.ucrInputResolution.AddQuotesIfUnrecognised = True
        Me.ucrInputResolution.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputResolution.GetSetSelectedIndex = -1
        Me.ucrInputResolution.IsReadOnly = False
        Me.ucrInputResolution.Location = New System.Drawing.Point(158, 71)
        Me.ucrInputResolution.Name = "ucrInputResolution"
        Me.ucrInputResolution.Size = New System.Drawing.Size(122, 21)
        Me.ucrInputResolution.TabIndex = 7
        '
        'ucrInputUNCode
        '
        Me.ucrInputUNCode.AddQuotesIfUnrecognised = True
        Me.ucrInputUNCode.AutoSize = True
        Me.ucrInputUNCode.IsMultiline = False
        Me.ucrInputUNCode.IsReadOnly = False
        Me.ucrInputUNCode.Location = New System.Drawing.Point(158, 44)
        Me.ucrInputUNCode.Name = "ucrInputUNCode"
        Me.ucrInputUNCode.Size = New System.Drawing.Size(122, 21)
        Me.ucrInputUNCode.TabIndex = 5
        '
        'ucrChkOutputGridSquareData
        '
        Me.ucrChkOutputGridSquareData.AutoSize = True
        Me.ucrChkOutputGridSquareData.Checked = False
        Me.ucrChkOutputGridSquareData.Location = New System.Drawing.Point(8, 98)
        Me.ucrChkOutputGridSquareData.Name = "ucrChkOutputGridSquareData"
        Me.ucrChkOutputGridSquareData.Size = New System.Drawing.Size(276, 23)
        Me.ucrChkOutputGridSquareData.TabIndex = 8
        '
        'lblRes
        '
        Me.lblRes.AutoSize = True
        Me.lblRes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRes.Location = New System.Drawing.Point(5, 74)
        Me.lblRes.Name = "lblRes"
        Me.lblRes.Size = New System.Drawing.Size(60, 13)
        Me.lblRes.TabIndex = 6
        Me.lblRes.Text = "Resolution:"
        '
        'lblUNCode
        '
        Me.lblUNCode.AutoSize = True
        Me.lblUNCode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUNCode.Location = New System.Drawing.Point(5, 47)
        Me.lblUNCode.Name = "lblUNCode"
        Me.lblUNCode.Size = New System.Drawing.Size(54, 13)
        Me.lblUNCode.TabIndex = 4
        Me.lblUNCode.Text = "UN Code:"
        '
        'ucrNudNYE
        '
        Me.ucrNudNYE.AutoSize = True
        Me.ucrNudNYE.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYE.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNYE.Location = New System.Drawing.Point(230, 18)
        Me.ucrNudNYE.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNYE.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYE.Name = "ucrNudNYE"
        Me.ucrNudNYE.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNYE.TabIndex = 3
        Me.ucrNudNYE.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStation.Location = New System.Drawing.Point(253, 45)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 1
        Me.lblStation.Text = "Station:"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMonth.Location = New System.Drawing.Point(253, 133)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 13)
        Me.lblMonth.TabIndex = 5
        Me.lblMonth.Text = "Month:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYear.Location = New System.Drawing.Point(253, 89)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 3
        Me.lblYear.Text = "Year:"
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 346)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 12
        '
        'ucrSelectorForA3
        '
        Me.ucrSelectorForA3.AutoSize = True
        Me.ucrSelectorForA3.bDropUnusedFilterLevels = False
        Me.ucrSelectorForA3.bUseCurrentFilter = True
        Me.ucrSelectorForA3.Location = New System.Drawing.Point(10, 204)
        Me.ucrSelectorForA3.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForA3.Name = "ucrSelectorForA3"
        Me.ucrSelectorForA3.Size = New System.Drawing.Size(151, 50)
        Me.ucrSelectorForA3.TabIndex = 8
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.AutoSize = True
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(254, 148)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 6
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(254, 104)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 4
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(254, 60)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 2
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSelectorForA2
        '
        Me.ucrSelectorForA2.AutoSize = True
        Me.ucrSelectorForA2.bDropUnusedFilterLevels = False
        Me.ucrSelectorForA2.bShowHiddenColumns = False
        Me.ucrSelectorForA2.bUseCurrentFilter = True
        Me.ucrSelectorForA2.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForA2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForA2.Name = "ucrSelectorForA2"
        Me.ucrSelectorForA2.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForA2.TabIndex = 0
        '
        'dlgClimaticNCMPRegionAverage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(453, 403)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorForA3)
        Me.Controls.Add(Me.cmdStationMetadata)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrSelectorForA2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticNCMPRegionAverage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NCMP Region Average"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrNudNYE As ucrNud
    Friend WithEvents lblNYER As Label
    Friend WithEvents cmdStationMetadata As Button
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents ucrChkOutputGridSquareData As ucrCheck
    Friend WithEvents lblRes As Label
    Friend WithEvents lblUNCode As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents ucrSelectorForA3 As ucrDataFrame
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrSelectorForA2 As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputResolution As ucrInputComboBox
    Friend WithEvents ucrInputUNCode As ucrInputTextBox
    Friend WithEvents ucrBase As ucrButtons
End Class