<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimaticNCMPTrendGraphs
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
        Me.cmdStationMetadata = New System.Windows.Forms.Button()
        Me.lblYearA2 = New System.Windows.Forms.Label()
        Me.lblMonthA2 = New System.Windows.Forms.Label()
        Me.lblYearA4 = New System.Windows.Forms.Label()
        Me.lblMonthA4 = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.lblSaveFile = New System.Windows.Forms.Label()
        Me.cmdChooseFile = New System.Windows.Forms.Button()
        Me.lblNYER = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.lblNYE = New System.Windows.Forms.Label()
        Me.ucrNudNYBA = New instat.ucrNud()
        Me.ucrNudNYE = New instat.ucrNud()
        Me.ucrNudNYB = New instat.ucrNud()
        Me.lblNYBR = New System.Windows.Forms.Label()
        Me.lblNYB = New System.Windows.Forms.Label()
        Me.ucrNudNYEA = New instat.ucrNud()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonthA4 = New instat.ucrReceiverSingle()
        Me.ucrReceiverYearA4 = New instat.ucrReceiverSingle()
        Me.ucrSelectorForA4 = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverMonthA2 = New instat.ucrReceiverSingle()
        Me.ucrReceiverYearA2 = New instat.ucrReceiverSingle()
        Me.ucrSelectorForA2 = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdStationMetadata
        '
        Me.cmdStationMetadata.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdStationMetadata.Location = New System.Drawing.Point(309, 164)
        Me.cmdStationMetadata.Name = "cmdStationMetadata"
        Me.cmdStationMetadata.Size = New System.Drawing.Size(120, 23)
        Me.cmdStationMetadata.TabIndex = 7
        Me.cmdStationMetadata.Text = "Station Metadata"
        Me.cmdStationMetadata.UseVisualStyleBackColor = True
        '
        'lblYearA2
        '
        Me.lblYearA2.AutoSize = True
        Me.lblYearA2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYearA2.Location = New System.Drawing.Point(307, 67)
        Me.lblYearA2.Name = "lblYearA2"
        Me.lblYearA2.Size = New System.Drawing.Size(32, 13)
        Me.lblYearA2.TabIndex = 3
        Me.lblYearA2.Text = "Year:"
        '
        'lblMonthA2
        '
        Me.lblMonthA2.AutoSize = True
        Me.lblMonthA2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMonthA2.Location = New System.Drawing.Point(307, 111)
        Me.lblMonthA2.Name = "lblMonthA2"
        Me.lblMonthA2.Size = New System.Drawing.Size(40, 13)
        Me.lblMonthA2.TabIndex = 5
        Me.lblMonthA2.Text = "Month:"
        '
        'lblYearA4
        '
        Me.lblYearA4.AutoSize = True
        Me.lblYearA4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYearA4.Location = New System.Drawing.Point(307, 230)
        Me.lblYearA4.Name = "lblYearA4"
        Me.lblYearA4.Size = New System.Drawing.Size(32, 13)
        Me.lblYearA4.TabIndex = 10
        Me.lblYearA4.Text = "Year:"
        '
        'lblMonthA4
        '
        Me.lblMonthA4.AutoSize = True
        Me.lblMonthA4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMonthA4.Location = New System.Drawing.Point(307, 274)
        Me.lblMonthA4.Name = "lblMonthA4"
        Me.lblMonthA4.Size = New System.Drawing.Size(40, 13)
        Me.lblMonthA4.TabIndex = 12
        Me.lblMonthA4.Text = "Month:"
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLine.Location = New System.Drawing.Point(44, 190)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(445, 13)
        Me.lblLine.TabIndex = 8
        Me.lblLine.Text = "_________________________________________________________________________"
        '
        'lblSaveFile
        '
        Me.lblSaveFile.AutoSize = True
        Me.lblSaveFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSaveFile.Location = New System.Drawing.Point(7, 401)
        Me.lblSaveFile.Name = "lblSaveFile"
        Me.lblSaveFile.Size = New System.Drawing.Size(74, 13)
        Me.lblSaveFile.TabIndex = 16
        Me.lblSaveFile.Text = "Save file(s) to:"
        '
        'cmdChooseFile
        '
        Me.cmdChooseFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdChooseFile.Location = New System.Drawing.Point(402, 397)
        Me.cmdChooseFile.Name = "cmdChooseFile"
        Me.cmdChooseFile.Size = New System.Drawing.Size(75, 23)
        Me.cmdChooseFile.TabIndex = 18
        Me.cmdChooseFile.Text = "Browse"
        Me.cmdChooseFile.UseVisualStyleBackColor = True
        '
        'lblNYER
        '
        Me.lblNYER.AutoSize = True
        Me.lblNYER.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNYER.Location = New System.Drawing.Point(4, 43)
        Me.lblNYER.Name = "lblNYER"
        Me.lblNYER.Size = New System.Drawing.Size(149, 13)
        Me.lblNYER.TabIndex = 2
        Me.lblNYER.Text = "End Year for Region Average:"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.lblNYE)
        Me.grpOptions.Controls.Add(Me.ucrNudNYBA)
        Me.grpOptions.Controls.Add(Me.ucrNudNYE)
        Me.grpOptions.Controls.Add(Me.ucrNudNYB)
        Me.grpOptions.Controls.Add(Me.lblNYBR)
        Me.grpOptions.Controls.Add(Me.lblNYB)
        Me.grpOptions.Controls.Add(Me.ucrNudNYEA)
        Me.grpOptions.Controls.Add(Me.lblNYER)
        Me.grpOptions.Location = New System.Drawing.Point(227, 312)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(286, 66)
        Me.grpOptions.TabIndex = 14
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'lblNYE
        '
        Me.lblNYE.AutoSize = True
        Me.lblNYE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNYE.Location = New System.Drawing.Point(4, 96)
        Me.lblNYE.Name = "lblNYE"
        Me.lblNYE.Size = New System.Drawing.Size(136, 13)
        Me.lblNYE.TabIndex = 6
        Me.lblNYE.Text = "End Year for Station Trend:"
        '
        'ucrNudNYBA
        '
        Me.ucrNudNYBA.AutoSize = True
        Me.ucrNudNYBA.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYBA.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNYBA.Location = New System.Drawing.Point(228, 14)
        Me.ucrNudNYBA.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNYBA.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYBA.Name = "ucrNudNYBA"
        Me.ucrNudNYBA.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNYBA.TabIndex = 1
        Me.ucrNudNYBA.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudNYE
        '
        Me.ucrNudNYE.AutoSize = True
        Me.ucrNudNYE.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYE.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNYE.Location = New System.Drawing.Point(156, 93)
        Me.ucrNudNYE.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNYE.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYE.Name = "ucrNudNYE"
        Me.ucrNudNYE.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNYE.TabIndex = 7
        Me.ucrNudNYE.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudNYB
        '
        Me.ucrNudNYB.AutoSize = True
        Me.ucrNudNYB.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYB.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNYB.Location = New System.Drawing.Point(156, 67)
        Me.ucrNudNYB.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNYB.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYB.Name = "ucrNudNYB"
        Me.ucrNudNYB.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNYB.TabIndex = 5
        Me.ucrNudNYB.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNYBR
        '
        Me.lblNYBR.AutoSize = True
        Me.lblNYBR.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNYBR.Location = New System.Drawing.Point(4, 16)
        Me.lblNYBR.Name = "lblNYBR"
        Me.lblNYBR.Size = New System.Drawing.Size(152, 13)
        Me.lblNYBR.TabIndex = 0
        Me.lblNYBR.Text = "Start Year for Region Average:"
        '
        'lblNYB
        '
        Me.lblNYB.AutoSize = True
        Me.lblNYB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNYB.Location = New System.Drawing.Point(3, 70)
        Me.lblNYB.Name = "lblNYB"
        Me.lblNYB.Size = New System.Drawing.Size(139, 13)
        Me.lblNYB.TabIndex = 4
        Me.lblNYB.Text = "Start Year for Station Trend:"
        '
        'ucrNudNYEA
        '
        Me.ucrNudNYEA.AutoSize = True
        Me.ucrNudNYEA.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYEA.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNYEA.Location = New System.Drawing.Point(228, 40)
        Me.ucrNudNYEA.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNYEA.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYEA.Name = "ucrNudNYEA"
        Me.ucrNudNYEA.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNYEA.TabIndex = 3
        Me.ucrNudNYEA.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStation.Location = New System.Drawing.Point(307, 25)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 1
        Me.lblStation.Text = "Station:"
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.AutoSize = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        Me.ucrInputFilePath.Location = New System.Drawing.Point(162, 398)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.Size = New System.Drawing.Size(237, 21)
        Me.ucrInputFilePath.TabIndex = 17
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 426)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 19
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(308, 40)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 2
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverMonthA4
        '
        Me.ucrReceiverMonthA4.AutoSize = True
        Me.ucrReceiverMonthA4.frmParent = Me
        Me.ucrReceiverMonthA4.Location = New System.Drawing.Point(308, 289)
        Me.ucrReceiverMonthA4.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonthA4.Name = "ucrReceiverMonthA4"
        Me.ucrReceiverMonthA4.Selector = Nothing
        Me.ucrReceiverMonthA4.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMonthA4.strNcFilePath = ""
        Me.ucrReceiverMonthA4.TabIndex = 13
        Me.ucrReceiverMonthA4.ucrSelector = Nothing
        '
        'ucrReceiverYearA4
        '
        Me.ucrReceiverYearA4.AutoSize = True
        Me.ucrReceiverYearA4.frmParent = Me
        Me.ucrReceiverYearA4.Location = New System.Drawing.Point(308, 245)
        Me.ucrReceiverYearA4.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYearA4.Name = "ucrReceiverYearA4"
        Me.ucrReceiverYearA4.Selector = Nothing
        Me.ucrReceiverYearA4.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYearA4.strNcFilePath = ""
        Me.ucrReceiverYearA4.TabIndex = 11
        Me.ucrReceiverYearA4.ucrSelector = Nothing
        '
        'ucrSelectorForA4
        '
        Me.ucrSelectorForA4.AutoSize = True
        Me.ucrSelectorForA4.bDropUnusedFilterLevels = False
        Me.ucrSelectorForA4.bShowHiddenColumns = False
        Me.ucrSelectorForA4.bUseCurrentFilter = True
        Me.ucrSelectorForA4.Location = New System.Drawing.Point(9, 206)
        Me.ucrSelectorForA4.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForA4.Name = "ucrSelectorForA4"
        Me.ucrSelectorForA4.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForA4.TabIndex = 9
        '
        'ucrReceiverMonthA2
        '
        Me.ucrReceiverMonthA2.AutoSize = True
        Me.ucrReceiverMonthA2.frmParent = Me
        Me.ucrReceiverMonthA2.Location = New System.Drawing.Point(308, 126)
        Me.ucrReceiverMonthA2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonthA2.Name = "ucrReceiverMonthA2"
        Me.ucrReceiverMonthA2.Selector = Nothing
        Me.ucrReceiverMonthA2.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMonthA2.strNcFilePath = ""
        Me.ucrReceiverMonthA2.TabIndex = 6
        Me.ucrReceiverMonthA2.ucrSelector = Nothing
        '
        'ucrReceiverYearA2
        '
        Me.ucrReceiverYearA2.AutoSize = True
        Me.ucrReceiverYearA2.frmParent = Me
        Me.ucrReceiverYearA2.Location = New System.Drawing.Point(308, 82)
        Me.ucrReceiverYearA2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYearA2.Name = "ucrReceiverYearA2"
        Me.ucrReceiverYearA2.Selector = Nothing
        Me.ucrReceiverYearA2.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYearA2.strNcFilePath = ""
        Me.ucrReceiverYearA2.TabIndex = 4
        Me.ucrReceiverYearA2.ucrSelector = Nothing
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
        'dlgClimaticNCMPTrendGraphs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(517, 483)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.cmdChooseFile)
        Me.Controls.Add(Me.lblSaveFile)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.lblLine)
        Me.Controls.Add(Me.lblYearA4)
        Me.Controls.Add(Me.ucrReceiverMonthA4)
        Me.Controls.Add(Me.lblMonthA4)
        Me.Controls.Add(Me.ucrReceiverYearA4)
        Me.Controls.Add(Me.ucrSelectorForA4)
        Me.Controls.Add(Me.cmdStationMetadata)
        Me.Controls.Add(Me.lblYearA2)
        Me.Controls.Add(Me.ucrReceiverMonthA2)
        Me.Controls.Add(Me.lblMonthA2)
        Me.Controls.Add(Me.ucrReceiverYearA2)
        Me.Controls.Add(Me.ucrSelectorForA2)
        Me.Controls.Add(Me.grpOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticNCMPTrendGraphs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NCMP Trend Graphs"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdStationMetadata As Button
    Friend WithEvents lblYearA2 As Label
    Friend WithEvents ucrReceiverMonthA2 As ucrReceiverSingle
    Friend WithEvents lblMonthA2 As Label
    Friend WithEvents ucrReceiverYearA2 As ucrReceiverSingle
    Friend WithEvents ucrSelectorForA2 As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblYearA4 As Label
    Friend WithEvents ucrReceiverMonthA4 As ucrReceiverSingle
    Friend WithEvents lblMonthA4 As Label
    Friend WithEvents ucrReceiverYearA4 As ucrReceiverSingle
    Friend WithEvents ucrSelectorForA4 As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblLine As Label
    Friend WithEvents lblSaveFile As Label
    Friend WithEvents cmdChooseFile As Button
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents lblNYER As Label
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents lblNYE As Label
    Friend WithEvents ucrNudNYBA As ucrNud
    Friend WithEvents ucrNudNYE As ucrNud
    Friend WithEvents ucrNudNYB As ucrNud
    Friend WithEvents lblNYBR As Label
    Friend WithEvents lblNYB As Label
    Friend WithEvents ucrNudNYEA As ucrNud
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
End Class