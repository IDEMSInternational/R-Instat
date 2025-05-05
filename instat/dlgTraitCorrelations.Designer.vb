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
        Me.ucrBase.Location = New System.Drawing.Point(14, 613)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(615, 80)
        Me.ucrBase.TabIndex = 8
        '
        'ucrSelecetorTraits
        '
        Me.ucrSelecetorTraits.AutoSize = True
        Me.ucrSelecetorTraits.bDropUnusedFilterLevels = False
        Me.ucrSelecetorTraits.bShowHiddenColumns = False
        Me.ucrSelecetorTraits.bUseCurrentFilter = True
        Me.ucrSelecetorTraits.Location = New System.Drawing.Point(14, 14)
        Me.ucrSelecetorTraits.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelecetorTraits.Name = "ucrSelecetorTraits"
        Me.ucrSelecetorTraits.Size = New System.Drawing.Size(320, 282)
        Me.ucrSelecetorTraits.TabIndex = 0
        '
        'ucrReceiverTrait
        '
        Me.ucrReceiverTrait.AutoSize = True
        Me.ucrReceiverTrait.frmParent = Me
        Me.ucrReceiverTrait.Location = New System.Drawing.Point(382, 88)
        Me.ucrReceiverTrait.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTrait.Name = "ucrReceiverTrait"
        Me.ucrReceiverTrait.Selector = Nothing
        Me.ucrReceiverTrait.Size = New System.Drawing.Size(180, 37)
        Me.ucrReceiverTrait.strNcFilePath = ""
        Me.ucrReceiverTrait.TabIndex = 2
        Me.ucrReceiverTrait.ucrSelector = Nothing
        '
        'lblTraits
        '
        Me.lblTraits.AutoSize = True
        Me.lblTraits.Location = New System.Drawing.Point(384, 66)
        Me.lblTraits.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTraits.Name = "lblTraits"
        Me.lblTraits.Size = New System.Drawing.Size(96, 20)
        Me.lblTraits.TabIndex = 1
        Me.lblTraits.Text = "Overall Trait:"
        '
        'ucrReceiverTraitsToCompare
        '
        Me.ucrReceiverTraitsToCompare.AutoSize = True
        Me.ucrReceiverTraitsToCompare.frmParent = Me
        Me.ucrReceiverTraitsToCompare.Location = New System.Drawing.Point(382, 159)
        Me.ucrReceiverTraitsToCompare.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTraitsToCompare.Name = "ucrReceiverTraitsToCompare"
        Me.ucrReceiverTraitsToCompare.Selector = Nothing
        Me.ucrReceiverTraitsToCompare.Size = New System.Drawing.Size(180, 154)
        Me.ucrReceiverTraitsToCompare.strNcFilePath = ""
        Me.ucrReceiverTraitsToCompare.TabIndex = 4
        Me.ucrReceiverTraitsToCompare.ucrSelector = Nothing
        '
        'lblTraitsCompare
        '
        Me.lblTraitsCompare.AutoSize = True
        Me.lblTraitsCompare.Location = New System.Drawing.Point(382, 135)
        Me.lblTraitsCompare.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTraitsCompare.Name = "lblTraitsCompare"
        Me.lblTraitsCompare.Size = New System.Drawing.Size(165, 20)
        Me.lblTraitsCompare.TabIndex = 3
        Me.lblTraitsCompare.Text = "Traits To Compare To:"
        '
        'ucrChkLeadingZeros
        '
        Me.ucrChkLeadingZeros.AutoSize = True
        Me.ucrChkLeadingZeros.Checked = False
        Me.ucrChkLeadingZeros.Location = New System.Drawing.Point(11, 84)
        Me.ucrChkLeadingZeros.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkLeadingZeros.Name = "ucrChkLeadingZeros"
        Me.ucrChkLeadingZeros.Size = New System.Drawing.Size(198, 35)
        Me.ucrChkLeadingZeros.TabIndex = 2
        '
        'lblDecimalPlaces
        '
        Me.lblDecimalPlaces.AutoSize = True
        Me.lblDecimalPlaces.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDecimalPlaces.Location = New System.Drawing.Point(8, 42)
        Me.lblDecimalPlaces.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDecimalPlaces.Name = "lblDecimalPlaces"
        Me.lblDecimalPlaces.Size = New System.Drawing.Size(121, 20)
        Me.lblDecimalPlaces.TabIndex = 0
        Me.lblDecimalPlaces.Text = "Decimal Places:"
        '
        'ucrNudDecimalPlaces
        '
        Me.ucrNudDecimalPlaces.AutoSize = True
        Me.ucrNudDecimalPlaces.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Location = New System.Drawing.Point(154, 40)
        Me.ucrNudDecimalPlaces.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudDecimalPlaces.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Name = "ucrNudDecimalPlaces"
        Me.ucrNudDecimalPlaces.Size = New System.Drawing.Size(81, 51)
        Me.ucrNudDecimalPlaces.TabIndex = 1
        Me.ucrNudDecimalPlaces.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'grpDisplayOptions
        '
        Me.grpDisplayOptions.Controls.Add(Me.grpOutput)
        Me.grpDisplayOptions.Controls.Add(Me.lblDecimalPlaces)
        Me.grpDisplayOptions.Controls.Add(Me.ucrChkIncludePValues)
        Me.grpDisplayOptions.Controls.Add(Me.ucrNudDecimalPlaces)
        Me.grpDisplayOptions.Controls.Add(Me.ucrChkLeadingZeros)
        Me.grpDisplayOptions.Location = New System.Drawing.Point(18, 376)
        Me.grpDisplayOptions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpDisplayOptions.Name = "grpDisplayOptions"
        Me.grpDisplayOptions.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpDisplayOptions.Size = New System.Drawing.Size(563, 173)
        Me.grpDisplayOptions.TabIndex = 6
        Me.grpDisplayOptions.TabStop = False
        Me.grpDisplayOptions.Tag = "Display Options"
        Me.grpDisplayOptions.Text = "Display Options"
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.rdoAsDataFrame)
        Me.grpOutput.Controls.Add(Me.rdoAsText)
        Me.grpOutput.Controls.Add(Me.ucrPnlOutput)
        Me.grpOutput.Location = New System.Drawing.Point(315, 29)
        Me.grpOutput.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpOutput.Size = New System.Drawing.Size(235, 115)
        Me.grpOutput.TabIndex = 4
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "Output "
        '
        'rdoAsDataFrame
        '
        Me.rdoAsDataFrame.AutoSize = True
        Me.rdoAsDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAsDataFrame.Location = New System.Drawing.Point(9, 66)
        Me.rdoAsDataFrame.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoAsDataFrame.Name = "rdoAsDataFrame"
        Me.rdoAsDataFrame.Size = New System.Drawing.Size(182, 24)
        Me.rdoAsDataFrame.TabIndex = 1
        Me.rdoAsDataFrame.Text = "Save As Data Frame"
        Me.rdoAsDataFrame.UseVisualStyleBackColor = True
        '
        'rdoAsText
        '
        Me.rdoAsText.AutoSize = True
        Me.rdoAsText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAsText.Location = New System.Drawing.Point(9, 31)
        Me.rdoAsText.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoAsText.Name = "rdoAsText"
        Me.rdoAsText.Size = New System.Drawing.Size(136, 24)
        Me.rdoAsText.TabIndex = 0
        Me.rdoAsText.Text = "Save As Table"
        Me.rdoAsText.UseVisualStyleBackColor = True
        '
        'ucrPnlOutput
        '
        Me.ucrPnlOutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOutput.Location = New System.Drawing.Point(4, 25)
        Me.ucrPnlOutput.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrPnlOutput.Name = "ucrPnlOutput"
        Me.ucrPnlOutput.Size = New System.Drawing.Size(225, 82)
        Me.ucrPnlOutput.TabIndex = 0
        '
        'ucrChkIncludePValues
        '
        Me.ucrChkIncludePValues.AutoSize = True
        Me.ucrChkIncludePValues.Checked = False
        Me.ucrChkIncludePValues.Location = New System.Drawing.Point(11, 128)
        Me.ucrChkIncludePValues.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkIncludePValues.Name = "ucrChkIncludePValues"
        Me.ucrChkIncludePValues.Size = New System.Drawing.Size(224, 35)
        Me.ucrChkIncludePValues.TabIndex = 3
        '
        'ucrChkDisplayOptions
        '
        Me.ucrChkDisplayOptions.AutoSize = True
        Me.ucrChkDisplayOptions.Checked = False
        Me.ucrChkDisplayOptions.Location = New System.Drawing.Point(14, 327)
        Me.ucrChkDisplayOptions.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkDisplayOptions.Name = "ucrChkDisplayOptions"
        Me.ucrChkDisplayOptions.Size = New System.Drawing.Size(288, 35)
        Me.ucrChkDisplayOptions.TabIndex = 5
        '
        'ucrSaveCorrelation
        '
        Me.ucrSaveCorrelation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveCorrelation.Location = New System.Drawing.Point(14, 562)
        Me.ucrSaveCorrelation.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveCorrelation.Name = "ucrSaveCorrelation"
        Me.ucrSaveCorrelation.Size = New System.Drawing.Size(399, 37)
        Me.ucrSaveCorrelation.TabIndex = 7
        '
        'dlgTraitCorrelations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 704)
        Me.Controls.Add(Me.ucrSaveCorrelation)
        Me.Controls.Add(Me.ucrChkDisplayOptions)
        Me.Controls.Add(Me.grpDisplayOptions)
        Me.Controls.Add(Me.lblTraitsCompare)
        Me.Controls.Add(Me.ucrReceiverTraitsToCompare)
        Me.Controls.Add(Me.lblTraits)
        Me.Controls.Add(Me.ucrReceiverTrait)
        Me.Controls.Add(Me.ucrSelecetorTraits)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTraitCorrelations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trait Correlations"
        Me.grpDisplayOptions.ResumeLayout(False)
        Me.grpDisplayOptions.PerformLayout()
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
