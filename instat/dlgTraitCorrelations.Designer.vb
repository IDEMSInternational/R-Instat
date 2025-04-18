<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTraitCorrelations
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelecetorTraits = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverTrait = New instat.ucrReceiverSingle()
        Me.lblTraits = New System.Windows.Forms.Label()
        Me.ucrReceiverTraitsToCompare = New instat.ucrReceiverMultiple()
        Me.lblTraitsCompare = New System.Windows.Forms.Label()
        Me.ucrChkLeadingZeros = New instat.ucrCheck()
        Me.lblDecimalPlaces = New System.Windows.Forms.Label()
        Me.ucrNudDecimalPlaces = New instat.ucrNud()
        Me.grpDisplayOptions = New System.Windows.Forms.GroupBox()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.rdoAsDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoAsText = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOutput = New instat.UcrPanel()
        Me.ucrChkIncludePValues = New instat.ucrCheck()
        Me.ucrChkDisplayOptions = New instat.ucrCheck()
        Me.ucrSaveCorrelation = New instat.ucrSave()
        Me.grpDisplayOptions.SuspendLayout()
        Me.grpOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(12, 463)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelecetorTraits
        '
        Me.ucrSelecetorTraits.AutoSize = True
        Me.ucrSelecetorTraits.bDropUnusedFilterLevels = False
        Me.ucrSelecetorTraits.bShowHiddenColumns = False
        Me.ucrSelecetorTraits.bUseCurrentFilter = True
        Me.ucrSelecetorTraits.Location = New System.Drawing.Point(12, 27)
        Me.ucrSelecetorTraits.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelecetorTraits.Name = "ucrSelecetorTraits"
        Me.ucrSelecetorTraits.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelecetorTraits.TabIndex = 1
        '
        'ucrReceiverTrait
        '
        Me.ucrReceiverTrait.AutoSize = True
        Me.ucrReceiverTrait.frmParent = Me
        Me.ucrReceiverTrait.Location = New System.Drawing.Point(331, 74)
        Me.ucrReceiverTrait.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTrait.Name = "ucrReceiverTrait"
        Me.ucrReceiverTrait.Selector = Nothing
        Me.ucrReceiverTrait.Size = New System.Drawing.Size(152, 24)
        Me.ucrReceiverTrait.strNcFilePath = ""
        Me.ucrReceiverTrait.TabIndex = 2
        Me.ucrReceiverTrait.ucrSelector = Nothing
        '
        'lblTraits
        '
        Me.lblTraits.AutoSize = True
        Me.lblTraits.Location = New System.Drawing.Point(335, 56)
        Me.lblTraits.Name = "lblTraits"
        Me.lblTraits.Size = New System.Drawing.Size(67, 13)
        Me.lblTraits.TabIndex = 3
        Me.lblTraits.Text = "Overall Trait:"
        '
        'ucrReceiverTraitsToCompare
        '
        Me.ucrReceiverTraitsToCompare.AutoSize = True
        Me.ucrReceiverTraitsToCompare.frmParent = Me
        Me.ucrReceiverTraitsToCompare.Location = New System.Drawing.Point(333, 124)
        Me.ucrReceiverTraitsToCompare.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTraitsToCompare.Name = "ucrReceiverTraitsToCompare"
        Me.ucrReceiverTraitsToCompare.Selector = Nothing
        Me.ucrReceiverTraitsToCompare.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverTraitsToCompare.strNcFilePath = ""
        Me.ucrReceiverTraitsToCompare.TabIndex = 4
        Me.ucrReceiverTraitsToCompare.ucrSelector = Nothing
        '
        'lblTraitsCompare
        '
        Me.lblTraitsCompare.AutoSize = True
        Me.lblTraitsCompare.Location = New System.Drawing.Point(335, 106)
        Me.lblTraitsCompare.Name = "lblTraitsCompare"
        Me.lblTraitsCompare.Size = New System.Drawing.Size(113, 13)
        Me.lblTraitsCompare.TabIndex = 5
        Me.lblTraitsCompare.Text = "Traits To Compare To:"
        '
        'ucrChkLeadingZeros
        '
        Me.ucrChkLeadingZeros.AutoSize = True
        Me.ucrChkLeadingZeros.Checked = False
        Me.ucrChkLeadingZeros.Location = New System.Drawing.Point(22, 329)
        Me.ucrChkLeadingZeros.Name = "ucrChkLeadingZeros"
        Me.ucrChkLeadingZeros.Size = New System.Drawing.Size(132, 23)
        Me.ucrChkLeadingZeros.TabIndex = 29
        '
        'lblDecimalPlaces
        '
        Me.lblDecimalPlaces.AutoSize = True
        Me.lblDecimalPlaces.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDecimalPlaces.Location = New System.Drawing.Point(22, 299)
        Me.lblDecimalPlaces.Name = "lblDecimalPlaces"
        Me.lblDecimalPlaces.Size = New System.Drawing.Size(83, 13)
        Me.lblDecimalPlaces.TabIndex = 25
        Me.lblDecimalPlaces.Text = "Decimal Places:"
        '
        'ucrNudDecimalPlaces
        '
        Me.ucrNudDecimalPlaces.AutoSize = True
        Me.ucrNudDecimalPlaces.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Location = New System.Drawing.Point(145, 295)
        Me.ucrNudDecimalPlaces.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Name = "ucrNudDecimalPlaces"
        Me.ucrNudDecimalPlaces.Size = New System.Drawing.Size(54, 33)
        Me.ucrNudDecimalPlaces.TabIndex = 26
        Me.ucrNudDecimalPlaces.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'grpDisplayOptions
        '
        Me.grpDisplayOptions.Controls.Add(Me.grpOutput)
        Me.grpDisplayOptions.Location = New System.Drawing.Point(14, 276)
        Me.grpDisplayOptions.Name = "grpDisplayOptions"
        Me.grpDisplayOptions.Size = New System.Drawing.Size(426, 121)
        Me.grpDisplayOptions.TabIndex = 24
        Me.grpDisplayOptions.TabStop = False
        Me.grpDisplayOptions.Tag = "Display Options"
        Me.grpDisplayOptions.Text = "Display Options"
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.rdoAsDataFrame)
        Me.grpOutput.Controls.Add(Me.rdoAsText)
        Me.grpOutput.Controls.Add(Me.ucrPnlOutput)
        Me.grpOutput.Location = New System.Drawing.Point(251, 15)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(165, 75)
        Me.grpOutput.TabIndex = 11
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "Output "
        '
        'rdoAsDataFrame
        '
        Me.rdoAsDataFrame.AutoSize = True
        Me.rdoAsDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAsDataFrame.Location = New System.Drawing.Point(6, 43)
        Me.rdoAsDataFrame.Name = "rdoAsDataFrame"
        Me.rdoAsDataFrame.Size = New System.Drawing.Size(123, 17)
        Me.rdoAsDataFrame.TabIndex = 2
        Me.rdoAsDataFrame.Text = "Save As Data Frame"
        Me.rdoAsDataFrame.UseVisualStyleBackColor = True
        '
        'rdoAsText
        '
        Me.rdoAsText.AutoSize = True
        Me.rdoAsText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAsText.Location = New System.Drawing.Point(6, 20)
        Me.rdoAsText.Name = "rdoAsText"
        Me.rdoAsText.Size = New System.Drawing.Size(95, 17)
        Me.rdoAsText.TabIndex = 1
        Me.rdoAsText.Text = "Save As Table"
        Me.rdoAsText.UseVisualStyleBackColor = True
        '
        'ucrPnlOutput
        '
        Me.ucrPnlOutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOutput.Location = New System.Drawing.Point(3, 16)
        Me.ucrPnlOutput.Name = "ucrPnlOutput"
        Me.ucrPnlOutput.Size = New System.Drawing.Size(150, 53)
        Me.ucrPnlOutput.TabIndex = 0
        '
        'ucrChkIncludePValues
        '
        Me.ucrChkIncludePValues.AutoSize = True
        Me.ucrChkIncludePValues.Checked = False
        Me.ucrChkIncludePValues.Location = New System.Drawing.Point(22, 363)
        Me.ucrChkIncludePValues.Name = "ucrChkIncludePValues"
        Me.ucrChkIncludePValues.Size = New System.Drawing.Size(149, 23)
        Me.ucrChkIncludePValues.TabIndex = 30
        '
        'ucrChkDisplayOptions
        '
        Me.ucrChkDisplayOptions.AutoSize = True
        Me.ucrChkDisplayOptions.Checked = False
        Me.ucrChkDisplayOptions.Location = New System.Drawing.Point(15, 244)
        Me.ucrChkDisplayOptions.Name = "ucrChkDisplayOptions"
        Me.ucrChkDisplayOptions.Size = New System.Drawing.Size(192, 23)
        Me.ucrChkDisplayOptions.TabIndex = 34
        '
        'ucrSaveCorrelation
        '
        Me.ucrSaveCorrelation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveCorrelation.Location = New System.Drawing.Point(15, 413)
        Me.ucrSaveCorrelation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveCorrelation.Name = "ucrSaveCorrelation"
        Me.ucrSaveCorrelation.Size = New System.Drawing.Size(266, 24)
        Me.ucrSaveCorrelation.TabIndex = 35
        '
        'dlgTraitCorrelations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 532)
        Me.Controls.Add(Me.ucrSaveCorrelation)
        Me.Controls.Add(Me.ucrChkDisplayOptions)
        Me.Controls.Add(Me.ucrChkIncludePValues)
        Me.Controls.Add(Me.ucrChkLeadingZeros)
        Me.Controls.Add(Me.lblDecimalPlaces)
        Me.Controls.Add(Me.ucrNudDecimalPlaces)
        Me.Controls.Add(Me.grpDisplayOptions)
        Me.Controls.Add(Me.lblTraitsCompare)
        Me.Controls.Add(Me.ucrReceiverTraitsToCompare)
        Me.Controls.Add(Me.lblTraits)
        Me.Controls.Add(Me.ucrReceiverTrait)
        Me.Controls.Add(Me.ucrSelecetorTraits)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTraitCorrelations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trait Correlations"
        Me.grpDisplayOptions.ResumeLayout(False)
        Me.grpOutput.ResumeLayout(False)
        Me.grpOutput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelecetorTraits As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverTrait As ucrReceiverSingle
    Friend WithEvents lblTraitsCompare As Label
    Friend WithEvents ucrReceiverTraitsToCompare As ucrReceiverMultiple
    Friend WithEvents lblTraits As Label
    Friend WithEvents ucrChkIncludePValues As ucrCheck
    Friend WithEvents ucrChkLeadingZeros As ucrCheck
    Friend WithEvents lblDecimalPlaces As Label
    Friend WithEvents ucrNudDecimalPlaces As ucrNud
    Friend WithEvents grpDisplayOptions As GroupBox
    Friend WithEvents grpOutput As GroupBox
    Friend WithEvents rdoAsDataFrame As RadioButton
    Friend WithEvents rdoAsText As RadioButton
    Friend WithEvents ucrPnlOutput As UcrPanel
    Friend WithEvents ucrChkDisplayOptions As ucrCheck
    Friend WithEvents ucrSaveCorrelation As ucrSave
End Class
