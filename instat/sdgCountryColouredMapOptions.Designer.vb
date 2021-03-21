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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgCountryColouredMapOptions))
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
        resources.ApplyResources(Me.tbcOptions, "tbcOptions")
        Me.tbcOptions.Name = "tbcOptions"
        Me.tbcOptions.SelectedIndex = 0
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
        resources.ApplyResources(Me.tpRegion, "tpRegion")
        Me.tpRegion.Name = "tpRegion"
        Me.tpRegion.UseVisualStyleBackColor = True
        '
        'rdoOwnCountries
        '
        resources.ApplyResources(Me.rdoOwnCountries, "rdoOwnCountries")
        Me.rdoOwnCountries.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOwnCountries.FlatAppearance.BorderSize = 2
        Me.rdoOwnCountries.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOwnCountries.Name = "rdoOwnCountries"
        Me.rdoOwnCountries.TabStop = True
        Me.rdoOwnCountries.UseVisualStyleBackColor = True
        '
        'rdoChooseRegion
        '
        resources.ApplyResources(Me.rdoChooseRegion, "rdoChooseRegion")
        Me.rdoChooseRegion.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoChooseRegion.FlatAppearance.BorderSize = 2
        Me.rdoChooseRegion.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoChooseRegion.Name = "rdoChooseRegion"
        Me.rdoChooseRegion.TabStop = True
        Me.rdoChooseRegion.UseVisualStyleBackColor = True
        '
        'ucrInputCommonRegions
        '
        Me.ucrInputCommonRegions.AddQuotesIfUnrecognised = True
        Me.ucrInputCommonRegions.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputCommonRegions, "ucrInputCommonRegions")
        Me.ucrInputCommonRegions.Name = "ucrInputCommonRegions"
        '
        'lblCommonRegions
        '
        resources.ApplyResources(Me.lblCommonRegions, "lblCommonRegions")
        Me.lblCommonRegions.Name = "lblCommonRegions"
        '
        'lblLat
        '
        resources.ApplyResources(Me.lblLat, "lblLat")
        Me.lblLat.Name = "lblLat"
        '
        'lblLongMin
        '
        resources.ApplyResources(Me.lblLongMin, "lblLongMin")
        Me.lblLongMin.Name = "lblLongMin"
        '
        'lblLatMax
        '
        resources.ApplyResources(Me.lblLatMax, "lblLatMax")
        Me.lblLatMax.Name = "lblLatMax"
        '
        'ucrInputLatMax
        '
        Me.ucrInputLatMax.AddQuotesIfUnrecognised = True
        Me.ucrInputLatMax.IsMultiline = False
        Me.ucrInputLatMax.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLatMax, "ucrInputLatMax")
        Me.ucrInputLatMax.Name = "ucrInputLatMax"
        '
        'lblLongMax
        '
        resources.ApplyResources(Me.lblLongMax, "lblLongMax")
        Me.lblLongMax.Name = "lblLongMax"
        '
        'ucrInputLongMax
        '
        Me.ucrInputLongMax.AddQuotesIfUnrecognised = True
        Me.ucrInputLongMax.IsMultiline = False
        Me.ucrInputLongMax.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLongMax, "ucrInputLongMax")
        Me.ucrInputLongMax.Name = "ucrInputLongMax"
        '
        'lblLatMin
        '
        resources.ApplyResources(Me.lblLatMin, "lblLatMin")
        Me.lblLatMin.Name = "lblLatMin"
        '
        'ucrInputLatMin
        '
        Me.ucrInputLatMin.AddQuotesIfUnrecognised = True
        Me.ucrInputLatMin.IsMultiline = False
        Me.ucrInputLatMin.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLatMin, "ucrInputLatMin")
        Me.ucrInputLatMin.Name = "ucrInputLatMin"
        '
        'lblLong
        '
        resources.ApplyResources(Me.lblLong, "lblLong")
        Me.lblLong.Name = "lblLong"
        '
        'ucrInputLongMin
        '
        Me.ucrInputLongMin.AddQuotesIfUnrecognised = True
        Me.ucrInputLongMin.IsMultiline = False
        Me.ucrInputLongMin.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLongMin, "ucrInputLongMin")
        Me.ucrInputLongMin.Name = "ucrInputLongMin"
        '
        'ucrPnlRegionChoice
        '
        resources.ApplyResources(Me.ucrPnlRegionChoice, "ucrPnlRegionChoice")
        Me.ucrPnlRegionChoice.Name = "ucrPnlRegionChoice"
        '
        'tpAdditional
        '
        resources.ApplyResources(Me.tpAdditional, "tpAdditional")
        Me.tpAdditional.Name = "tpAdditional"
        Me.tpAdditional.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'sdgCountryColouredMapOptions
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbcOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgCountryColouredMapOptions"
        Me.tbcOptions.ResumeLayout(False)
        Me.tpRegion.ResumeLayout(False)
        Me.tpRegion.PerformLayout()
        Me.ResumeLayout(False)

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
