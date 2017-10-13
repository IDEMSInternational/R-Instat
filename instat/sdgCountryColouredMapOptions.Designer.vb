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
        Me.lblCommonRegions = New System.Windows.Forms.Label()
        Me.lblLat = New System.Windows.Forms.Label()
        Me.lblLongMin = New System.Windows.Forms.Label()
        Me.lblLatMax = New System.Windows.Forms.Label()
        Me.lblLongMax = New System.Windows.Forms.Label()
        Me.lblLatMin = New System.Windows.Forms.Label()
        Me.lblLong = New System.Windows.Forms.Label()
        Me.rdoChooseRegion = New System.Windows.Forms.RadioButton()
        Me.rdoOwnCountries = New System.Windows.Forms.RadioButton()
        Me.tpAdditional = New System.Windows.Forms.TabPage()
        Me.ucrInputCommonRegions = New instat.ucrInputComboBox()
        Me.ucrInputLatMax = New instat.ucrInputTextBox()
        Me.ucrInputLongMax = New instat.ucrInputTextBox()
        Me.ucrInputLatMin = New instat.ucrInputTextBox()
        Me.ucrInputLongMin = New instat.ucrInputTextBox()
        Me.ucrPnlRegionChoice = New instat.UcrPanel()
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
        Me.tbcOptions.Size = New System.Drawing.Size(437, 388)
        Me.tbcOptions.TabIndex = 1
        '
        'tpRegion
        '
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
        Me.tpRegion.Controls.Add(Me.rdoChooseRegion)
        Me.tpRegion.Controls.Add(Me.rdoOwnCountries)
        Me.tpRegion.Controls.Add(Me.ucrPnlRegionChoice)
        Me.tpRegion.Location = New System.Drawing.Point(4, 22)
        Me.tpRegion.Name = "tpRegion"
        Me.tpRegion.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRegion.Size = New System.Drawing.Size(429, 362)
        Me.tpRegion.TabIndex = 0
        Me.tpRegion.Text = "Choose Region"
        Me.tpRegion.UseVisualStyleBackColor = True
        '
        'lblCommonRegions
        '
        Me.lblCommonRegions.AutoSize = True
        Me.lblCommonRegions.Location = New System.Drawing.Point(6, 73)
        Me.lblCommonRegions.Name = "lblCommonRegions"
        Me.lblCommonRegions.Size = New System.Drawing.Size(93, 13)
        Me.lblCommonRegions.TabIndex = 21
        Me.lblCommonRegions.Text = "Common Regions:"
        '
        'lblLat
        '
        Me.lblLat.AutoSize = True
        Me.lblLat.Location = New System.Drawing.Point(6, 149)
        Me.lblLat.Name = "lblLat"
        Me.lblLat.Size = New System.Drawing.Size(48, 13)
        Me.lblLat.TabIndex = 16
        Me.lblLat.Text = "Latitude:"
        '
        'lblLongMin
        '
        Me.lblLongMin.AutoSize = True
        Me.lblLongMin.Location = New System.Drawing.Point(87, 122)
        Me.lblLongMin.Name = "lblLongMin"
        Me.lblLongMin.Size = New System.Drawing.Size(27, 13)
        Me.lblLongMin.TabIndex = 12
        Me.lblLongMin.Text = "Min:"
        '
        'lblLatMax
        '
        Me.lblLatMax.AutoSize = True
        Me.lblLatMax.Location = New System.Drawing.Point(263, 149)
        Me.lblLatMax.Name = "lblLatMax"
        Me.lblLatMax.Size = New System.Drawing.Size(30, 13)
        Me.lblLatMax.TabIndex = 19
        Me.lblLatMax.Text = "Max:"
        '
        'lblLongMax
        '
        Me.lblLongMax.AutoSize = True
        Me.lblLongMax.Location = New System.Drawing.Point(263, 122)
        Me.lblLongMax.Name = "lblLongMax"
        Me.lblLongMax.Size = New System.Drawing.Size(30, 13)
        Me.lblLongMax.TabIndex = 14
        Me.lblLongMax.Text = "Max:"
        '
        'lblLatMin
        '
        Me.lblLatMin.AutoSize = True
        Me.lblLatMin.Location = New System.Drawing.Point(87, 149)
        Me.lblLatMin.Name = "lblLatMin"
        Me.lblLatMin.Size = New System.Drawing.Size(27, 13)
        Me.lblLatMin.TabIndex = 17
        Me.lblLatMin.Text = "Min:"
        '
        'lblLong
        '
        Me.lblLong.AutoSize = True
        Me.lblLong.Location = New System.Drawing.Point(6, 122)
        Me.lblLong.Name = "lblLong"
        Me.lblLong.Size = New System.Drawing.Size(57, 13)
        Me.lblLong.TabIndex = 11
        Me.lblLong.Text = "Longitude:"
        '
        'rdoChooseRegion
        '
        Me.rdoChooseRegion.AutoSize = True
        Me.rdoChooseRegion.Location = New System.Drawing.Point(214, 17)
        Me.rdoChooseRegion.Name = "rdoChooseRegion"
        Me.rdoChooseRegion.Size = New System.Drawing.Size(98, 17)
        Me.rdoChooseRegion.TabIndex = 2
        Me.rdoChooseRegion.TabStop = True
        Me.rdoChooseRegion.Text = "Choose Region"
        Me.rdoChooseRegion.UseVisualStyleBackColor = True
        '
        'rdoOwnCountries
        '
        Me.rdoOwnCountries.AutoSize = True
        Me.rdoOwnCountries.Location = New System.Drawing.Point(28, 17)
        Me.rdoOwnCountries.Name = "rdoOwnCountries"
        Me.rdoOwnCountries.Size = New System.Drawing.Size(110, 17)
        Me.rdoOwnCountries.TabIndex = 1
        Me.rdoOwnCountries.TabStop = True
        Me.rdoOwnCountries.Text = "Only My Countries"
        Me.rdoOwnCountries.UseVisualStyleBackColor = True
        '
        'tpAdditional
        '
        Me.tpAdditional.Location = New System.Drawing.Point(4, 22)
        Me.tpAdditional.Name = "tpAdditional"
        Me.tpAdditional.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAdditional.Size = New System.Drawing.Size(429, 362)
        Me.tpAdditional.TabIndex = 1
        Me.tpAdditional.Text = "Additional Features"
        Me.tpAdditional.UseVisualStyleBackColor = True
        '
        'ucrInputCommonRegions
        '
        Me.ucrInputCommonRegions.AddQuotesIfUnrecognised = True
        Me.ucrInputCommonRegions.IsReadOnly = False
        Me.ucrInputCommonRegions.Location = New System.Drawing.Point(113, 71)
        Me.ucrInputCommonRegions.Name = "ucrInputCommonRegions"
        Me.ucrInputCommonRegions.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputCommonRegions.TabIndex = 22
        '
        'ucrInputLatMax
        '
        Me.ucrInputLatMax.AddQuotesIfUnrecognised = True
        Me.ucrInputLatMax.IsMultiline = False
        Me.ucrInputLatMax.IsReadOnly = False
        Me.ucrInputLatMax.Location = New System.Drawing.Point(295, 146)
        Me.ucrInputLatMax.Name = "ucrInputLatMax"
        Me.ucrInputLatMax.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputLatMax.TabIndex = 20
        '
        'ucrInputLongMax
        '
        Me.ucrInputLongMax.AddQuotesIfUnrecognised = True
        Me.ucrInputLongMax.IsMultiline = False
        Me.ucrInputLongMax.IsReadOnly = False
        Me.ucrInputLongMax.Location = New System.Drawing.Point(295, 119)
        Me.ucrInputLongMax.Name = "ucrInputLongMax"
        Me.ucrInputLongMax.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputLongMax.TabIndex = 15
        '
        'ucrInputLatMin
        '
        Me.ucrInputLatMin.AddQuotesIfUnrecognised = True
        Me.ucrInputLatMin.IsMultiline = False
        Me.ucrInputLatMin.IsReadOnly = False
        Me.ucrInputLatMin.Location = New System.Drawing.Point(116, 146)
        Me.ucrInputLatMin.Name = "ucrInputLatMin"
        Me.ucrInputLatMin.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputLatMin.TabIndex = 18
        '
        'ucrInputLongMin
        '
        Me.ucrInputLongMin.AddQuotesIfUnrecognised = True
        Me.ucrInputLongMin.IsMultiline = False
        Me.ucrInputLongMin.IsReadOnly = False
        Me.ucrInputLongMin.Location = New System.Drawing.Point(116, 119)
        Me.ucrInputLongMin.Name = "ucrInputLongMin"
        Me.ucrInputLongMin.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputLongMin.TabIndex = 13
        '
        'ucrPnlRegionChoice
        '
        Me.ucrPnlRegionChoice.Location = New System.Drawing.Point(6, 6)
        Me.ucrPnlRegionChoice.Name = "ucrPnlRegionChoice"
        Me.ucrPnlRegionChoice.Size = New System.Drawing.Size(417, 54)
        Me.ucrPnlRegionChoice.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(155, 397)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrBase.TabIndex = 0
        '
        'sdgCountryColouredMapOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 431)
        Me.Controls.Add(Me.tbcOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgCountryColouredMapOptions"
        Me.Text = "Map Options"
        Me.tbcOptions.ResumeLayout(False)
        Me.tpRegion.ResumeLayout(False)
        Me.tpRegion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents tbcOptions As TabControl
    Friend WithEvents tpRegion As TabPage
    Friend WithEvents rdoChooseRegion As RadioButton
    Friend WithEvents rdoOwnCountries As RadioButton
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
End Class
