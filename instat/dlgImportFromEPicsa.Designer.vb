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
        Me.rdoDefinitions = New System.Windows.Forms.RadioButton()
        Me.rdoData = New System.Windows.Forms.RadioButton()
        Me.rdoStation = New System.Windows.Forms.RadioButton()
        Me.ucrInputTokenPath = New instat.ucrInputTextBox()
        Me.lblToken = New System.Windows.Forms.Label()
        Me.cmdChooseFile = New System.Windows.Forms.Button()
        Me.ucrInputComboCountry = New instat.ucrInputComboBox()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.ucrInputDefinitionsID = New instat.ucrInputTextBox()
        Me.lblDefinitionsID = New System.Windows.Forms.Label()
        Me.cmdFindFiles = New System.Windows.Forms.Button()
        Me.ucrInputComboFindFiles = New instat.ucrInputComboBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveDefinitions = New instat.ucrSave()
        Me.ucrDataframeSelector = New instat.ucrDataFrame()
        Me.SuspendLayout()
        '
        'ucrPnlImportFromEPicsa
        '
        Me.ucrPnlImportFromEPicsa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlImportFromEPicsa.Location = New System.Drawing.Point(17, 18)
        Me.ucrPnlImportFromEPicsa.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlImportFromEPicsa.Name = "ucrPnlImportFromEPicsa"
        Me.ucrPnlImportFromEPicsa.Size = New System.Drawing.Size(429, 46)
        Me.ucrPnlImportFromEPicsa.TabIndex = 1
        '
        'rdoDefinitions
        '
        Me.rdoDefinitions.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDefinitions.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDefinitions.FlatAppearance.BorderSize = 2
        Me.rdoDefinitions.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDefinitions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDefinitions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDefinitions.Location = New System.Drawing.Point(63, 28)
        Me.rdoDefinitions.Name = "rdoDefinitions"
        Me.rdoDefinitions.Size = New System.Drawing.Size(116, 27)
        Me.rdoDefinitions.TabIndex = 2
        Me.rdoDefinitions.Text = "Definitions"
        Me.rdoDefinitions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDefinitions.UseVisualStyleBackColor = True
        '
        'rdoData
        '
        Me.rdoData.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoData.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoData.FlatAppearance.BorderSize = 2
        Me.rdoData.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoData.Location = New System.Drawing.Point(290, 28)
        Me.rdoData.Name = "rdoData"
        Me.rdoData.Size = New System.Drawing.Size(116, 27)
        Me.rdoData.TabIndex = 3
        Me.rdoData.Text = "Data"
        Me.rdoData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoData.UseVisualStyleBackColor = True
        '
        'rdoStation
        '
        Me.rdoStation.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoStation.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStation.FlatAppearance.BorderSize = 2
        Me.rdoStation.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoStation.Location = New System.Drawing.Point(176, 28)
        Me.rdoStation.Name = "rdoStation"
        Me.rdoStation.Size = New System.Drawing.Size(116, 27)
        Me.rdoStation.TabIndex = 4
        Me.rdoStation.Text = "Stations"
        Me.rdoStation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoStation.UseVisualStyleBackColor = True
        '
        'ucrInputTokenPath
        '
        Me.ucrInputTokenPath.AddQuotesIfUnrecognised = True
        Me.ucrInputTokenPath.AutoSize = True
        Me.ucrInputTokenPath.IsMultiline = False
        Me.ucrInputTokenPath.IsReadOnly = False
        Me.ucrInputTokenPath.Location = New System.Drawing.Point(117, 81)
        Me.ucrInputTokenPath.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputTokenPath.Name = "ucrInputTokenPath"
        Me.ucrInputTokenPath.Size = New System.Drawing.Size(191, 21)
        Me.ucrInputTokenPath.TabIndex = 5
        '
        'lblToken
        '
        Me.lblToken.AutoSize = True
        Me.lblToken.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblToken.Location = New System.Drawing.Point(73, 84)
        Me.lblToken.Name = "lblToken"
        Me.lblToken.Size = New System.Drawing.Size(41, 13)
        Me.lblToken.TabIndex = 6
        Me.lblToken.Text = "Token:"
        '
        'cmdChooseFile
        '
        Me.cmdChooseFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdChooseFile.Location = New System.Drawing.Point(317, 80)
        Me.cmdChooseFile.Name = "cmdChooseFile"
        Me.cmdChooseFile.Size = New System.Drawing.Size(80, 23)
        Me.cmdChooseFile.TabIndex = 7
        Me.cmdChooseFile.Text = "Browse"
        Me.cmdChooseFile.UseVisualStyleBackColor = True
        '
        'ucrInputComboCountry
        '
        Me.ucrInputComboCountry.AddQuotesIfUnrecognised = True
        Me.ucrInputComboCountry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboCountry.GetSetSelectedIndex = -1
        Me.ucrInputComboCountry.IsReadOnly = False
        Me.ucrInputComboCountry.Location = New System.Drawing.Point(79, 166)
        Me.ucrInputComboCountry.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrInputComboCountry.Name = "ucrInputComboCountry"
        Me.ucrInputComboCountry.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputComboCountry.TabIndex = 23
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCountry.Location = New System.Drawing.Point(14, 166)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(46, 13)
        Me.lblCountry.TabIndex = 24
        Me.lblCountry.Text = "Country:"
        '
        'ucrInputDefinitionsID
        '
        Me.ucrInputDefinitionsID.AddQuotesIfUnrecognised = True
        Me.ucrInputDefinitionsID.AutoSize = True
        Me.ucrInputDefinitionsID.IsMultiline = False
        Me.ucrInputDefinitionsID.IsReadOnly = False
        Me.ucrInputDefinitionsID.Location = New System.Drawing.Point(102, 202)
        Me.ucrInputDefinitionsID.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputDefinitionsID.Name = "ucrInputDefinitionsID"
        Me.ucrInputDefinitionsID.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputDefinitionsID.TabIndex = 25
        '
        'lblDefinitionsID
        '
        Me.lblDefinitionsID.AutoSize = True
        Me.lblDefinitionsID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDefinitionsID.Location = New System.Drawing.Point(14, 202)
        Me.lblDefinitionsID.Name = "lblDefinitionsID"
        Me.lblDefinitionsID.Size = New System.Drawing.Size(73, 13)
        Me.lblDefinitionsID.TabIndex = 26
        Me.lblDefinitionsID.Text = "Definitions ID:"
        '
        'cmdFindFiles
        '
        Me.cmdFindFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFindFiles.Location = New System.Drawing.Point(17, 238)
        Me.cmdFindFiles.Name = "cmdFindFiles"
        Me.cmdFindFiles.Size = New System.Drawing.Size(80, 23)
        Me.cmdFindFiles.TabIndex = 27
        Me.cmdFindFiles.Text = "Find Files"
        Me.cmdFindFiles.UseVisualStyleBackColor = True
        '
        'ucrInputComboFindFiles
        '
        Me.ucrInputComboFindFiles.AddQuotesIfUnrecognised = True
        Me.ucrInputComboFindFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboFindFiles.GetSetSelectedIndex = -1
        Me.ucrInputComboFindFiles.IsReadOnly = False
        Me.ucrInputComboFindFiles.Location = New System.Drawing.Point(124, 239)
        Me.ucrInputComboFindFiles.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrInputComboFindFiles.Name = "ucrInputComboFindFiles"
        Me.ucrInputComboFindFiles.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputComboFindFiles.TabIndex = 28
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(17, 325)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 31
        '
        'ucrSaveDefinitions
        '
        Me.ucrSaveDefinitions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveDefinitions.Location = New System.Drawing.Point(17, 284)
        Me.ucrSaveDefinitions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveDefinitions.Name = "ucrSaveDefinitions"
        Me.ucrSaveDefinitions.Size = New System.Drawing.Size(375, 22)
        Me.ucrSaveDefinitions.TabIndex = 32
        '
        'ucrDataframeSelector
        '
        Me.ucrDataframeSelector.AutoSize = True
        Me.ucrDataframeSelector.bDropUnusedFilterLevels = False
        Me.ucrDataframeSelector.bUseCurrentFilter = True
        Me.ucrDataframeSelector.Location = New System.Drawing.Point(17, 110)
        Me.ucrDataframeSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataframeSelector.Name = "ucrDataframeSelector"
        Me.ucrDataframeSelector.Size = New System.Drawing.Size(151, 43)
        Me.ucrDataframeSelector.TabIndex = 33
        '
        'dlgImportFromEPicsa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(464, 388)
        Me.Controls.Add(Me.ucrDataframeSelector)
        Me.Controls.Add(Me.ucrSaveDefinitions)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrInputComboFindFiles)
        Me.Controls.Add(Me.cmdFindFiles)
        Me.Controls.Add(Me.lblDefinitionsID)
        Me.Controls.Add(Me.ucrInputDefinitionsID)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.ucrInputComboCountry)
        Me.Controls.Add(Me.cmdChooseFile)
        Me.Controls.Add(Me.lblToken)
        Me.Controls.Add(Me.ucrInputTokenPath)
        Me.Controls.Add(Me.rdoStation)
        Me.Controls.Add(Me.rdoData)
        Me.Controls.Add(Me.rdoDefinitions)
        Me.Controls.Add(Me.ucrPnlImportFromEPicsa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgImportFromEPicsa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import from e-PICSA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrPnlImportFromEPicsa As UcrPanel
    Friend WithEvents rdoDefinitions As RadioButton
    Friend WithEvents rdoData As RadioButton
    Friend WithEvents rdoStation As RadioButton
    Friend WithEvents ucrInputTokenPath As ucrInputTextBox
    Friend WithEvents lblToken As Label
    Friend WithEvents cmdChooseFile As Button
    Friend WithEvents ucrInputComboCountry As ucrInputComboBox
    Friend WithEvents lblCountry As Label
    Friend WithEvents ucrInputDefinitionsID As ucrInputTextBox
    Friend WithEvents lblDefinitionsID As Label
    Friend WithEvents cmdFindFiles As Button
    Friend WithEvents ucrInputComboFindFiles As ucrInputComboBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSaveDefinitions As ucrSave
    Friend WithEvents ucrDataframeSelector As ucrDataFrame
End Class
