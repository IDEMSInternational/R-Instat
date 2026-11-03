<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgImportFromEPicsa
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
        Me.ucrPnlImportFromEPicsa = New instat.UcrPanel()
        Me.rdoStationMetadata = New System.Windows.Forms.RadioButton()
        Me.rdoSummaryMetadata = New System.Windows.Forms.RadioButton()
        Me.rdoSummaryData = New System.Windows.Forms.RadioButton()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.btnConnection = New System.Windows.Forms.Button()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrChkSummaryData = New instat.ucrCheck()
        Me.ucrSelectorImportFromEPICSA = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrStationFactorLevels = New instat.ucrFactor()
        Me.ucrChkCropData = New instat.ucrCheck()
        Me.ucrChkDefinitionsData = New instat.ucrCheck()
        Me.ucrChkSpecifyStations = New instat.ucrCheck()
        Me.ucrChkLatestData = New instat.ucrCheck()
        Me.ucrInputDefinitionsID = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'ucrPnlImportFromEPicsa
        '
        Me.ucrPnlImportFromEPicsa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlImportFromEPicsa.Location = New System.Drawing.Point(26, 8)
        Me.ucrPnlImportFromEPicsa.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrPnlImportFromEPicsa.Name = "ucrPnlImportFromEPicsa"
        Me.ucrPnlImportFromEPicsa.Size = New System.Drawing.Size(695, 53)
        Me.ucrPnlImportFromEPicsa.TabIndex = 1
        '
        'rdoStationMetadata
        '
        Me.rdoStationMetadata.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoStationMetadata.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStationMetadata.FlatAppearance.BorderSize = 2
        Me.rdoStationMetadata.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStationMetadata.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoStationMetadata.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoStationMetadata.Location = New System.Drawing.Point(108, 13)
        Me.rdoStationMetadata.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoStationMetadata.Name = "rdoStationMetadata"
        Me.rdoStationMetadata.Size = New System.Drawing.Size(174, 40)
        Me.rdoStationMetadata.TabIndex = 2
        Me.rdoStationMetadata.Text = "Station Metadata"
        Me.rdoStationMetadata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoStationMetadata.UseVisualStyleBackColor = True
        '
        'rdoSummaryMetadata
        '
        Me.rdoSummaryMetadata.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSummaryMetadata.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSummaryMetadata.FlatAppearance.BorderSize = 2
        Me.rdoSummaryMetadata.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSummaryMetadata.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSummaryMetadata.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSummaryMetadata.Location = New System.Drawing.Point(449, 13)
        Me.rdoSummaryMetadata.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoSummaryMetadata.Name = "rdoSummaryMetadata"
        Me.rdoSummaryMetadata.Size = New System.Drawing.Size(174, 40)
        Me.rdoSummaryMetadata.TabIndex = 3
        Me.rdoSummaryMetadata.Text = "Summary Metadata"
        Me.rdoSummaryMetadata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSummaryMetadata.UseVisualStyleBackColor = True
        '
        'rdoSummaryData
        '
        Me.rdoSummaryData.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSummaryData.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSummaryData.FlatAppearance.BorderSize = 2
        Me.rdoSummaryData.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSummaryData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSummaryData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSummaryData.Location = New System.Drawing.Point(278, 13)
        Me.rdoSummaryData.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoSummaryData.Name = "rdoSummaryData"
        Me.rdoSummaryData.Size = New System.Drawing.Size(174, 40)
        Me.rdoSummaryData.TabIndex = 4
        Me.rdoSummaryData.Text = "Summary Data"
        Me.rdoSummaryData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSummaryData.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(26, 678)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 31
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.ForeColor = System.Drawing.Color.Red
        Me.lblConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConnection.Location = New System.Drawing.Point(262, 87)
        Me.lblConnection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(114, 20)
        Me.lblConnection.TabIndex = 35
        Me.lblConnection.Text = "No Connection"
        '
        'btnConnection
        '
        Me.btnConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConnection.Location = New System.Drawing.Point(26, 79)
        Me.btnConnection.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConnection.Name = "btnConnection"
        Me.btnConnection.Size = New System.Drawing.Size(220, 34)
        Me.btnConnection.TabIndex = 34
        Me.btnConnection.Text = "Connect to Database"
        Me.btnConnection.UseVisualStyleBackColor = True
        '
        'lblStation
        '
        Me.lblStation.Location = New System.Drawing.Point(405, 339)
        Me.lblStation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(124, 22)
        Me.lblStation.TabIndex = 36
        Me.lblStation.Text = "Station:"
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(405, 363)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 37
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrChkSummaryData
        '
        Me.ucrChkSummaryData.AutoSize = True
        Me.ucrChkSummaryData.Checked = False
        Me.ucrChkSummaryData.Location = New System.Drawing.Point(26, 126)
        Me.ucrChkSummaryData.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkSummaryData.Name = "ucrChkSummaryData"
        Me.ucrChkSummaryData.Size = New System.Drawing.Size(284, 34)
        Me.ucrChkSummaryData.TabIndex = 38
        '
        'ucrSelectorImportFromEPICSA
        '
        Me.ucrSelectorImportFromEPICSA.AutoSize = True
        Me.ucrSelectorImportFromEPICSA.bDropUnusedFilterLevels = False
        Me.ucrSelectorImportFromEPICSA.bShowHiddenColumns = False
        Me.ucrSelectorImportFromEPICSA.bUseCurrentFilter = True
        Me.ucrSelectorImportFromEPICSA.Location = New System.Drawing.Point(26, 336)
        Me.ucrSelectorImportFromEPICSA.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorImportFromEPICSA.Name = "ucrSelectorImportFromEPICSA"
        Me.ucrSelectorImportFromEPICSA.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorImportFromEPICSA.TabIndex = 39
        '
        'ucrStationFactorLevels
        '
        Me.ucrStationFactorLevels.AutoSize = True
        Me.ucrStationFactorLevels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrStationFactorLevels.Location = New System.Drawing.Point(405, 415)
        Me.ucrStationFactorLevels.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrStationFactorLevels.Name = "ucrStationFactorLevels"
        Me.ucrStationFactorLevels.Size = New System.Drawing.Size(316, 195)
        Me.ucrStationFactorLevels.TabIndex = 40
        '
        'ucrChkCropData
        '
        Me.ucrChkCropData.AutoSize = True
        Me.ucrChkCropData.Checked = False
        Me.ucrChkCropData.Location = New System.Drawing.Point(26, 178)
        Me.ucrChkCropData.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkCropData.Name = "ucrChkCropData"
        Me.ucrChkCropData.Size = New System.Drawing.Size(284, 34)
        Me.ucrChkCropData.TabIndex = 41
        '
        'ucrChkDefinitionsData
        '
        Me.ucrChkDefinitionsData.AutoSize = True
        Me.ucrChkDefinitionsData.Checked = False
        Me.ucrChkDefinitionsData.Location = New System.Drawing.Point(26, 230)
        Me.ucrChkDefinitionsData.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkDefinitionsData.Name = "ucrChkDefinitionsData"
        Me.ucrChkDefinitionsData.Size = New System.Drawing.Size(284, 34)
        Me.ucrChkDefinitionsData.TabIndex = 42
        '
        'ucrChkSpecifyStations
        '
        Me.ucrChkSpecifyStations.AutoSize = True
        Me.ucrChkSpecifyStations.Checked = False
        Me.ucrChkSpecifyStations.Location = New System.Drawing.Point(26, 282)
        Me.ucrChkSpecifyStations.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkSpecifyStations.Name = "ucrChkSpecifyStations"
        Me.ucrChkSpecifyStations.Size = New System.Drawing.Size(284, 34)
        Me.ucrChkSpecifyStations.TabIndex = 43
        '
        'ucrChkLatestData
        '
        Me.ucrChkLatestData.AutoSize = True
        Me.ucrChkLatestData.Checked = False
        Me.ucrChkLatestData.Location = New System.Drawing.Point(26, 629)
        Me.ucrChkLatestData.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkLatestData.Name = "ucrChkLatestData"
        Me.ucrChkLatestData.Size = New System.Drawing.Size(231, 34)
        Me.ucrChkLatestData.TabIndex = 44
        '
        'ucrInputDefinitionsID
        '
        Me.ucrInputDefinitionsID.AddQuotesIfUnrecognised = True
        Me.ucrInputDefinitionsID.AutoSize = True
        Me.ucrInputDefinitionsID.IsMultiline = False
        Me.ucrInputDefinitionsID.IsReadOnly = False
        Me.ucrInputDefinitionsID.Location = New System.Drawing.Point(280, 633)
        Me.ucrInputDefinitionsID.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputDefinitionsID.Name = "ucrInputDefinitionsID"
        Me.ucrInputDefinitionsID.Size = New System.Drawing.Size(441, 32)
        Me.ucrInputDefinitionsID.TabIndex = 45
        '
        'dlgImportFromEPicsa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(738, 762)
        Me.Controls.Add(Me.ucrInputDefinitionsID)
        Me.Controls.Add(Me.ucrChkLatestData)
        Me.Controls.Add(Me.ucrChkSpecifyStations)
        Me.Controls.Add(Me.ucrChkDefinitionsData)
        Me.Controls.Add(Me.ucrChkCropData)
        Me.Controls.Add(Me.ucrStationFactorLevels)
        Me.Controls.Add(Me.ucrSelectorImportFromEPICSA)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrChkSummaryData)
        Me.Controls.Add(Me.lblConnection)
        Me.Controls.Add(Me.btnConnection)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.rdoSummaryData)
        Me.Controls.Add(Me.rdoSummaryMetadata)
        Me.Controls.Add(Me.rdoStationMetadata)
        Me.Controls.Add(Me.ucrPnlImportFromEPicsa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgImportFromEPicsa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import from e-PICSA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrPnlImportFromEPicsa As UcrPanel
    Friend WithEvents rdoStationMetadata As RadioButton
    Friend WithEvents rdoSummaryMetadata As RadioButton
    Friend WithEvents rdoSummaryData As RadioButton
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblConnection As Label
    Friend WithEvents btnConnection As Button
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrChkSummaryData As ucrCheck
    Friend WithEvents ucrSelectorImportFromEPICSA As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrChkSpecifyStations As ucrCheck
    Friend WithEvents ucrChkDefinitionsData As ucrCheck
    Friend WithEvents ucrChkCropData As ucrCheck
    Friend WithEvents ucrStationFactorLevels As ucrFactor
    Friend WithEvents ucrChkLatestData As ucrCheck
    Friend WithEvents ucrInputDefinitionsID As ucrInputTextBox
End Class
