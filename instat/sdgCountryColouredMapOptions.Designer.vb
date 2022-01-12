<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgCountryColouredMapOptions
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
        Me.tbcOptions = New System.Windows.Forms.TabControl()
        Me.tpRegion = New System.Windows.Forms.TabPage()
        Me.rdoOwnCountries = New System.Windows.Forms.RadioButton()
        Me.rdoChooseRegion = New System.Windows.Forms.RadioButton()
        Me.ucrInputCommonRegions = New instat.ucrInputComboBox()
        Me.lblCommonRegions = New System.Windows.Forms.Label()
        Me.lblLat = New System.Windows.Forms.Label()
        Me.lblLongMin = New System.Windows.Forms.Label()
        Me.lblLatMax = New System.Windows.Forms.Label()
        Me.ucrInputLatMax = New instat.ucrInputTextBox()
        Me.lblLongMax = New System.Windows.Forms.Label()
        Me.ucrInputLongMax = New instat.ucrInputTextBox()
        Me.lblLatMin = New System.Windows.Forms.Label()
        Me.ucrInputLatMin = New instat.ucrInputTextBox()
        Me.lblLong = New System.Windows.Forms.Label()
        Me.ucrInputLongMin = New instat.ucrInputTextBox()
        Me.ucrPnlRegionChoice = New instat.UcrPanel()
        Me.tpAdditional = New System.Windows.Forms.TabPage()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.tbcOptions.SuspendLayout()
        Me.tpRegion.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcOptions
        '
        Me.tbcOptions.Controls.Add(Me.tpRegion)
        Me.tbcOptions.Controls.Add(Me.tpAdditional)
        Me.tbcOptions.Location = New System.Drawing.Point(4, 3)
        Me.tbcOptions.Name = "tbcOptions"
        Me.tbcOptions.SelectedIndex = 0
        Me.tbcOptions.Size = New System.Drawing.Size(337, 211)
        Me.tbcOptions.TabIndex = 0
        '
        'tpRegion
        '
        Me.tpRegion.Controls.Add(Me.rdoOwnCountries)
        Me.tpRegion.Controls.Add(Me.rdoChooseRegion)
        Me.tpRegion.Controls.Add(Me.ucrInputCommonRegions)
        Me.tpRegion.Controls.Add(Me.lblCommonRegions)
        Me.tpRegion.Controls.Add(Me.lblLat)
        Me.tpRegion.Controls.Add(Me.lblLongMin)
        Me.tpRegion.Controls.Add(Me.lblLatMax)
        Me.tpRegion.Controls.Add(Me.ucrInputLatMax)
        Me.tpRegion.Controls.Add(Me.lblLongMax)
        Me.tpRegion.Controls.Add(Me.ucrInputLongMax)
        Me.tpRegion.Controls.Add(Me.lblLatMin)
        Me.tpRegion.Controls.Add(Me.ucrInputLatMin)
        Me.tpRegion.Controls.Add(Me.lblLong)
        Me.tpRegion.Controls.Add(Me.ucrInputLongMin)
        Me.tpRegion.Controls.Add(Me.ucrPnlRegionChoice)
        Me.tpRegion.Location = New System.Drawing.Point(4, 22)
        Me.tpRegion.Name = "tpRegion"
        Me.tpRegion.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRegion.Size = New System.Drawing.Size(329, 185)
        Me.tpRegion.TabIndex = 0
        Me.tpRegion.Text = "Choose Region"
        Me.tpRegion.UseVisualStyleBackColor = True
        '
        'rdoOwnCountries
        '
        Me.rdoOwnCountries.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoOwnCountries.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOwnCountries.FlatAppearance.BorderSize = 2
        Me.rdoOwnCountries.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOwnCountries.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoOwnCountries.Location = New System.Drawing.Point(60, 24)
        Me.rdoOwnCountries.Name = "rdoOwnCountries"
        Me.rdoOwnCountries.Size = New System.Drawing.Size(104, 27)
        Me.rdoOwnCountries.TabIndex = 2
        Me.rdoOwnCountries.TabStop = True
        Me.rdoOwnCountries.Text = "Only My Countries"
        Me.rdoOwnCountries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoOwnCountries.UseVisualStyleBackColor = True
        '
        'rdoChooseRegion
        '
        Me.rdoChooseRegion.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoChooseRegion.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoChooseRegion.FlatAppearance.BorderSize = 2
        Me.rdoChooseRegion.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoChooseRegion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoChooseRegion.Location = New System.Drawing.Point(162, 24)
        Me.rdoChooseRegion.Name = "rdoChooseRegion"
        Me.rdoChooseRegion.Size = New System.Drawing.Size(104, 27)
        Me.rdoChooseRegion.TabIndex = 3
        Me.rdoChooseRegion.TabStop = True
        Me.rdoChooseRegion.Text = "Choose Region"
        Me.rdoChooseRegion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoChooseRegion.UseVisualStyleBackColor = True
        '
        'ucrInputCommonRegions
        '
        Me.ucrInputCommonRegions.AddQuotesIfUnrecognised = True
        Me.ucrInputCommonRegions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCommonRegions.GetSetSelectedIndex = -1
        Me.ucrInputCommonRegions.IsReadOnly = False
        Me.ucrInputCommonRegions.Location = New System.Drawing.Point(129, 73)
        Me.ucrInputCommonRegions.Name = "ucrInputCommonRegions"
        Me.ucrInputCommonRegions.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputCommonRegions.TabIndex = 5
        '
        'lblCommonRegions
        '
        Me.lblCommonRegions.AutoSize = True
        Me.lblCommonRegions.Location = New System.Drawing.Point(6, 75)
        Me.lblCommonRegions.Name = "lblCommonRegions"
        Me.lblCommonRegions.Size = New System.Drawing.Size(93, 13)
        Me.lblCommonRegions.TabIndex = 4
        Me.lblCommonRegions.Text = "Common Regions:"
        '
        'lblLat
        '
        Me.lblLat.AutoSize = True
        Me.lblLat.Location = New System.Drawing.Point(6, 144)
        Me.lblLat.Name = "lblLat"
        Me.lblLat.Size = New System.Drawing.Size(48, 13)
        Me.lblLat.TabIndex = 11
        Me.lblLat.Text = "Latitude:"
        '
        'lblLongMin
        '
        Me.lblLongMin.AutoSize = True
        Me.lblLongMin.Location = New System.Drawing.Point(68, 113)
        Me.lblLongMin.Name = "lblLongMin"
        Me.lblLongMin.Size = New System.Drawing.Size(27, 13)
        Me.lblLongMin.TabIndex = 7
        Me.lblLongMin.Text = "Min:"
        '
        'lblLatMax
        '
        Me.lblLatMax.AutoSize = True
        Me.lblLatMax.Location = New System.Drawing.Point(197, 144)
        Me.lblLatMax.Name = "lblLatMax"
        Me.lblLatMax.Size = New System.Drawing.Size(30, 13)
        Me.lblLatMax.TabIndex = 14
        Me.lblLatMax.Text = "Max:"
        '
        'ucrInputLatMax
        '
        Me.ucrInputLatMax.AddQuotesIfUnrecognised = True
        Me.ucrInputLatMax.AutoSize = True
        Me.ucrInputLatMax.IsMultiline = False
        Me.ucrInputLatMax.IsReadOnly = False
        Me.ucrInputLatMax.Location = New System.Drawing.Point(229, 140)
        Me.ucrInputLatMax.Name = "ucrInputLatMax"
        Me.ucrInputLatMax.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputLatMax.TabIndex = 0
        '
        'lblLongMax
        '
        Me.lblLongMax.AutoSize = True
        Me.lblLongMax.Location = New System.Drawing.Point(197, 113)
        Me.lblLongMax.Name = "lblLongMax"
        Me.lblLongMax.Size = New System.Drawing.Size(30, 13)
        Me.lblLongMax.TabIndex = 9
        Me.lblLongMax.Text = "Max:"
        '
        'ucrInputLongMax
        '
        Me.ucrInputLongMax.AddQuotesIfUnrecognised = True
        Me.ucrInputLongMax.AutoSize = True
        Me.ucrInputLongMax.IsMultiline = False
        Me.ucrInputLongMax.IsReadOnly = False
        Me.ucrInputLongMax.Location = New System.Drawing.Point(228, 109)
        Me.ucrInputLongMax.Name = "ucrInputLongMax"
        Me.ucrInputLongMax.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputLongMax.TabIndex = 10
        '
        'lblLatMin
        '
        Me.lblLatMin.AutoSize = True
        Me.lblLatMin.Location = New System.Drawing.Point(68, 144)
        Me.lblLatMin.Name = "lblLatMin"
        Me.lblLatMin.Size = New System.Drawing.Size(27, 13)
        Me.lblLatMin.TabIndex = 12
        Me.lblLatMin.Text = "Min:"
        '
        'ucrInputLatMin
        '
        Me.ucrInputLatMin.AddQuotesIfUnrecognised = True
        Me.ucrInputLatMin.AutoSize = True
        Me.ucrInputLatMin.IsMultiline = False
        Me.ucrInputLatMin.IsReadOnly = False
        Me.ucrInputLatMin.Location = New System.Drawing.Point(98, 140)
        Me.ucrInputLatMin.Name = "ucrInputLatMin"
        Me.ucrInputLatMin.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputLatMin.TabIndex = 13
        '
        'lblLong
        '
        Me.lblLong.AutoSize = True
        Me.lblLong.Location = New System.Drawing.Point(6, 113)
        Me.lblLong.Name = "lblLong"
        Me.lblLong.Size = New System.Drawing.Size(57, 13)
        Me.lblLong.TabIndex = 6
        Me.lblLong.Text = "Longitude:"
        '
        'ucrInputLongMin
        '
        Me.ucrInputLongMin.AddQuotesIfUnrecognised = True
        Me.ucrInputLongMin.AutoSize = True
        Me.ucrInputLongMin.IsMultiline = False
        Me.ucrInputLongMin.IsReadOnly = False
        Me.ucrInputLongMin.Location = New System.Drawing.Point(98, 109)
        Me.ucrInputLongMin.Name = "ucrInputLongMin"
        Me.ucrInputLongMin.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputLongMin.TabIndex = 8
        '
        'ucrPnlRegionChoice
        '
        Me.ucrPnlRegionChoice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlRegionChoice.Location = New System.Drawing.Point(33, 6)
        Me.ucrPnlRegionChoice.Name = "ucrPnlRegionChoice"
        Me.ucrPnlRegionChoice.Size = New System.Drawing.Size(282, 61)
        Me.ucrPnlRegionChoice.TabIndex = 1
        '
        'tpAdditional
        '
        Me.tpAdditional.Location = New System.Drawing.Point(4, 22)
        Me.tpAdditional.Name = "tpAdditional"
        Me.tpAdditional.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAdditional.Size = New System.Drawing.Size(329, 185)
        Me.tpAdditional.TabIndex = 1
        Me.tpAdditional.Text = "Additional Features"
        Me.tpAdditional.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.Location = New System.Drawing.Point(102, 217)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(224, 30)
        Me.ucrBase.TabIndex = 1
        '
        'sdgCountryColouredMapOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(346, 255)
        Me.Controls.Add(Me.tbcOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgCountryColouredMapOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Map Options"
        Me.tbcOptions.ResumeLayout(False)
        Me.tpRegion.ResumeLayout(False)
        Me.tpRegion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents tbcOptions As TabControl
    Friend WithEvents tpRegion As TabPage
    Friend WithEvents ucrPnlRegionChoice As UcrPanel
    Friend WithEvents tpAdditional As TabPage
    Friend WithEvents ucrInputCommonRegions As ucrInputComboBox
    Friend WithEvents lblCommonRegions As Label
    Friend WithEvents lblLat As Label
    Friend WithEvents lblLongMin As Label
    Friend WithEvents lblLatMax As Label
    Friend WithEvents ucrInputLatMax As ucrInputTextBox
    Friend WithEvents lblLongMax As Label
    Friend WithEvents ucrInputLongMax As ucrInputTextBox
    Friend WithEvents lblLatMin As Label
    Friend WithEvents ucrInputLatMin As ucrInputTextBox
    Friend WithEvents lblLong As Label
    Friend WithEvents ucrInputLongMin As ucrInputTextBox
    Friend WithEvents rdoOwnCountries As RadioButton
    Friend WithEvents rdoChooseRegion As RadioButton
End Class
