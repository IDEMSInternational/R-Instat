<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimaticNCMPVariogram
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
        Me.ucrNudNYB = New instat.ucrNud()
        Me.lblNYBR = New System.Windows.Forms.Label()
        Me.ucrNudNYE = New instat.ucrNud()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblSaveFile = New System.Windows.Forms.Label()
        Me.cmdChooseFile = New System.Windows.Forms.Button()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSelectorVariogram = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSaveVariogram = New instat.ucrSave()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNYER
        '
        Me.lblNYER.AutoSize = True
        Me.lblNYER.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNYER.Location = New System.Drawing.Point(2, 59)
        Me.lblNYER.Name = "lblNYER"
        Me.lblNYER.Size = New System.Drawing.Size(152, 13)
        Me.lblNYER.TabIndex = 9
        Me.lblNYER.Text = "End Year for Variogram Period:"
        '
        'cmdStationMetadata
        '
        Me.cmdStationMetadata.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdStationMetadata.Location = New System.Drawing.Point(233, 181)
        Me.cmdStationMetadata.Name = "cmdStationMetadata"
        Me.cmdStationMetadata.Size = New System.Drawing.Size(160, 23)
        Me.cmdStationMetadata.TabIndex = 7
        Me.cmdStationMetadata.Text = "Station Metadata"
        Me.cmdStationMetadata.UseVisualStyleBackColor = True
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrNudNYB)
        Me.grpOptions.Controls.Add(Me.lblNYBR)
        Me.grpOptions.Controls.Add(Me.ucrNudNYE)
        Me.grpOptions.Controls.Add(Me.lblNYER)
        Me.grpOptions.Location = New System.Drawing.Point(10, 196)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(210, 74)
        Me.grpOptions.TabIndex = 8
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'ucrNudNYB
        '
        Me.ucrNudNYB.AutoSize = True
        Me.ucrNudNYB.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYB.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNYB.Location = New System.Drawing.Point(156, 20)
        Me.ucrNudNYB.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNYB.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYB.Name = "ucrNudNYB"
        Me.ucrNudNYB.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNYB.TabIndex = 1
        Me.ucrNudNYB.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNYBR
        '
        Me.lblNYBR.AutoSize = True
        Me.lblNYBR.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNYBR.Location = New System.Drawing.Point(4, 22)
        Me.lblNYBR.Name = "lblNYBR"
        Me.lblNYBR.Size = New System.Drawing.Size(155, 13)
        Me.lblNYBR.TabIndex = 0
        Me.lblNYBR.Text = "Start Year for Variogram Period:"
        '
        'ucrNudNYE
        '
        Me.ucrNudNYE.AutoSize = True
        Me.ucrNudNYE.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYE.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNYE.Location = New System.Drawing.Point(156, 54)
        Me.ucrNudNYE.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNYE.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYE.Name = "ucrNudNYE"
        Me.ucrNudNYE.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNYE.TabIndex = 10
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
        'lblSaveFile
        '
        Me.lblSaveFile.AutoSize = True
        Me.lblSaveFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSaveFile.Location = New System.Drawing.Point(9, 247)
        Me.lblSaveFile.Name = "lblSaveFile"
        Me.lblSaveFile.Size = New System.Drawing.Size(74, 13)
        Me.lblSaveFile.TabIndex = 12
        Me.lblSaveFile.Text = "Save file(s) to:"
        '
        'cmdChooseFile
        '
        Me.cmdChooseFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdChooseFile.Location = New System.Drawing.Point(339, 243)
        Me.cmdChooseFile.Name = "cmdChooseFile"
        Me.cmdChooseFile.Size = New System.Drawing.Size(75, 23)
        Me.cmdChooseFile.TabIndex = 14
        Me.cmdChooseFile.Text = "Browse"
        Me.cmdChooseFile.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 271)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 15
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.AutoSize = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        Me.ucrInputFilePath.Location = New System.Drawing.Point(166, 244)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.Size = New System.Drawing.Size(171, 21)
        Me.ucrInputFilePath.TabIndex = 13
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
        'ucrSelectorVariogram
        '
        Me.ucrSelectorVariogram.AutoSize = True
        Me.ucrSelectorVariogram.bDropUnusedFilterLevels = False
        Me.ucrSelectorVariogram.bShowHiddenColumns = False
        Me.ucrSelectorVariogram.bUseCurrentFilter = True
        Me.ucrSelectorVariogram.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorVariogram.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorVariogram.Name = "ucrSelectorVariogram"
        Me.ucrSelectorVariogram.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorVariogram.TabIndex = 0
        '
        'ucrSaveVariogram
        '
        Me.ucrSaveVariogram.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveVariogram.Location = New System.Drawing.Point(10, 214)
        Me.ucrSaveVariogram.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveVariogram.Name = "ucrSaveVariogram"
        Me.ucrSaveVariogram.Size = New System.Drawing.Size(383, 22)
        Me.ucrSaveVariogram.TabIndex = 16
        '
        'dlgClimaticNCMPVariogram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(420, 326)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.cmdChooseFile)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.lblSaveFile)
        Me.Controls.Add(Me.ucrSaveVariogram)
        Me.Controls.Add(Me.cmdStationMetadata)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrSelectorVariogram)
        Me.Controls.Add(Me.grpOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticNCMPVariogram"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NCMP Variogram"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrNudNYE As ucrNud
    Friend WithEvents lblNYER As Label
    Friend WithEvents cmdStationMetadata As Button
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents ucrNudNYB As ucrNud
    Friend WithEvents lblNYBR As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrSelectorVariogram As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblSaveFile As Label
    Friend WithEvents cmdChooseFile As Button
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSaveVariogram As ucrSave
End Class