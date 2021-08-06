<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTreemap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgTreemap))
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.rdoPrimary = New System.Windows.Forms.RadioButton()
        Me.rdoSummary = New System.Windows.Forms.RadioButton()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblWeightBy = New System.Windows.Forms.Label()
        Me.lblIdentifier = New System.Windows.Forms.Label()
        Me.lblSymbol = New System.Windows.Forms.Label()
        Me.lblFill = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.lblTextColour = New System.Windows.Forms.Label()
        Me.ucrColourText = New instat.ucrColors()
        Me.lblTileColour = New System.Windows.Forms.Label()
        Me.ucrColourTile = New instat.ucrColors()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.ucrInputSummary = New instat.ucrInputComboBox()
        Me.ucrReceiverFill = New instat.ucrReceiverSingle()
        Me.ucrInputSymbol = New instat.ucrInputTextBox()
        Me.ucrInputLabel = New instat.ucrInputComboBox()
        Me.ucrSaveTreemap = New instat.ucrSave()
        Me.ucrChkIsCurrency = New instat.ucrCheck()
        Me.ucrReceiverWeightBy = New instat.ucrReceiverSingle()
        Me.ucrReceiverIdentifier = New instat.ucrReceiverSingle()
        Me.ucrSelectorTreemap = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlDataType = New instat.UcrPanel()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLabel
        '
        resources.ApplyResources(Me.lblLabel, "lblLabel")
        Me.lblLabel.Name = "lblLabel"
        '
        'rdoPrimary
        '
        resources.ApplyResources(Me.rdoPrimary, "rdoPrimary")
        Me.rdoPrimary.BackColor = System.Drawing.SystemColors.Control
        Me.rdoPrimary.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPrimary.FlatAppearance.BorderSize = 2
        Me.rdoPrimary.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPrimary.Name = "rdoPrimary"
        Me.rdoPrimary.TabStop = True
        Me.rdoPrimary.Tag = ""
        Me.rdoPrimary.UseVisualStyleBackColor = False
        '
        'rdoSummary
        '
        resources.ApplyResources(Me.rdoSummary, "rdoSummary")
        Me.rdoSummary.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSummary.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSummary.FlatAppearance.BorderSize = 2
        Me.rdoSummary.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSummary.Name = "rdoSummary"
        Me.rdoSummary.TabStop = True
        Me.rdoSummary.Tag = "Pie_Chart"
        Me.rdoSummary.UseVisualStyleBackColor = False
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Tag = "Plot_Options..."
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblWeightBy
        '
        resources.ApplyResources(Me.lblWeightBy, "lblWeightBy")
        Me.lblWeightBy.Name = "lblWeightBy"
        Me.lblWeightBy.Tag = ""
        '
        'lblIdentifier
        '
        resources.ApplyResources(Me.lblIdentifier, "lblIdentifier")
        Me.lblIdentifier.Name = "lblIdentifier"
        Me.lblIdentifier.Tag = "Variable:"
        '
        'lblSymbol
        '
        resources.ApplyResources(Me.lblSymbol, "lblSymbol")
        Me.lblSymbol.Name = "lblSymbol"
        '
        'lblFill
        '
        resources.ApplyResources(Me.lblFill, "lblFill")
        Me.lblFill.Name = "lblFill"
        Me.lblFill.Tag = ""
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.lblTextColour)
        Me.grpOptions.Controls.Add(Me.ucrColourText)
        Me.grpOptions.Controls.Add(Me.lblTileColour)
        Me.grpOptions.Controls.Add(Me.ucrColourTile)
        resources.ApplyResources(Me.grpOptions, "grpOptions")
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.TabStop = False
        '
        'lblTextColour
        '
        resources.ApplyResources(Me.lblTextColour, "lblTextColour")
        Me.lblTextColour.Name = "lblTextColour"
        '
        'ucrColourText
        '
        Me.ucrColourText.AddQuotesIfUnrecognised = True
        Me.ucrColourText.GetSetSelectedIndex = -1
        Me.ucrColourText.IsReadOnly = False
        resources.ApplyResources(Me.ucrColourText, "ucrColourText")
        Me.ucrColourText.Name = "ucrColourText"
        '
        'lblTileColour
        '
        resources.ApplyResources(Me.lblTileColour, "lblTileColour")
        Me.lblTileColour.Name = "lblTileColour"
        '
        'ucrColourTile
        '
        Me.ucrColourTile.AddQuotesIfUnrecognised = True
        Me.ucrColourTile.GetSetSelectedIndex = -1
        Me.ucrColourTile.IsReadOnly = False
        resources.ApplyResources(Me.ucrColourTile, "ucrColourTile")
        Me.ucrColourTile.Name = "ucrColourTile"
        '
        'lblSummary
        '
        resources.ApplyResources(Me.lblSummary, "lblSummary")
        Me.lblSummary.Name = "lblSummary"
        '
        'ucrInputSummary
        '
        Me.ucrInputSummary.AddQuotesIfUnrecognised = True
        Me.ucrInputSummary.GetSetSelectedIndex = -1
        Me.ucrInputSummary.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSummary, "ucrInputSummary")
        Me.ucrInputSummary.Name = "ucrInputSummary"
        '
        'ucrReceiverFill
        '
        Me.ucrReceiverFill.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFill, "ucrReceiverFill")
        Me.ucrReceiverFill.Name = "ucrReceiverFill"
        Me.ucrReceiverFill.Selector = Nothing
        Me.ucrReceiverFill.strNcFilePath = ""
        Me.ucrReceiverFill.ucrSelector = Nothing
        '
        'ucrInputSymbol
        '
        Me.ucrInputSymbol.AddQuotesIfUnrecognised = True
        Me.ucrInputSymbol.IsMultiline = False
        Me.ucrInputSymbol.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSymbol, "ucrInputSymbol")
        Me.ucrInputSymbol.Name = "ucrInputSymbol"
        '
        'ucrInputLabel
        '
        Me.ucrInputLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputLabel.GetSetSelectedIndex = -1
        Me.ucrInputLabel.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLabel, "ucrInputLabel")
        Me.ucrInputLabel.Name = "ucrInputLabel"
        '
        'ucrSaveTreemap
        '
        resources.ApplyResources(Me.ucrSaveTreemap, "ucrSaveTreemap")
        Me.ucrSaveTreemap.Name = "ucrSaveTreemap"
        '
        'ucrChkIsCurrency
        '
        Me.ucrChkIsCurrency.Checked = False
        resources.ApplyResources(Me.ucrChkIsCurrency, "ucrChkIsCurrency")
        Me.ucrChkIsCurrency.Name = "ucrChkIsCurrency"
        '
        'ucrReceiverWeightBy
        '
        Me.ucrReceiverWeightBy.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverWeightBy, "ucrReceiverWeightBy")
        Me.ucrReceiverWeightBy.Name = "ucrReceiverWeightBy"
        Me.ucrReceiverWeightBy.Selector = Nothing
        Me.ucrReceiverWeightBy.strNcFilePath = ""
        Me.ucrReceiverWeightBy.ucrSelector = Nothing
        '
        'ucrReceiverIdentifier
        '
        Me.ucrReceiverIdentifier.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverIdentifier, "ucrReceiverIdentifier")
        Me.ucrReceiverIdentifier.Name = "ucrReceiverIdentifier"
        Me.ucrReceiverIdentifier.Selector = Nothing
        Me.ucrReceiverIdentifier.strNcFilePath = ""
        Me.ucrReceiverIdentifier.ucrSelector = Nothing
        '
        'ucrSelectorTreemap
        '
        Me.ucrSelectorTreemap.bDropUnusedFilterLevels = False
        Me.ucrSelectorTreemap.bShowHiddenColumns = False
        Me.ucrSelectorTreemap.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorTreemap, "ucrSelectorTreemap")
        Me.ucrSelectorTreemap.Name = "ucrSelectorTreemap"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrPnlDataType
        '
        resources.ApplyResources(Me.ucrPnlDataType, "ucrPnlDataType")
        Me.ucrPnlDataType.Name = "ucrPnlDataType"
        '
        'dlgTreemap
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputSummary)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.lblFill)
        Me.Controls.Add(Me.ucrReceiverFill)
        Me.Controls.Add(Me.ucrInputSymbol)
        Me.Controls.Add(Me.lblSymbol)
        Me.Controls.Add(Me.lblLabel)
        Me.Controls.Add(Me.ucrInputLabel)
        Me.Controls.Add(Me.ucrSaveTreemap)
        Me.Controls.Add(Me.ucrChkIsCurrency)
        Me.Controls.Add(Me.rdoPrimary)
        Me.Controls.Add(Me.rdoSummary)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblWeightBy)
        Me.Controls.Add(Me.lblIdentifier)
        Me.Controls.Add(Me.ucrReceiverWeightBy)
        Me.Controls.Add(Me.ucrReceiverIdentifier)
        Me.Controls.Add(Me.ucrSelectorTreemap)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlDataType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTreemap"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLabel As Label
    Friend WithEvents ucrInputLabel As ucrInputComboBox
    Friend WithEvents ucrSaveTreemap As ucrSave
    Friend WithEvents ucrChkIsCurrency As ucrCheck
    Friend WithEvents rdoPrimary As RadioButton
    Friend WithEvents rdoSummary As RadioButton
    Friend WithEvents cmdOptions As Button
    Friend WithEvents lblWeightBy As Label
    Friend WithEvents lblIdentifier As Label
    Friend WithEvents ucrReceiverWeightBy As ucrReceiverSingle
    Friend WithEvents ucrReceiverIdentifier As ucrReceiverSingle
    Friend WithEvents ucrSelectorTreemap As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrPnlDataType As UcrPanel
    Friend WithEvents ucrInputSymbol As ucrInputTextBox
    Friend WithEvents lblSymbol As Label
    Friend WithEvents lblFill As Label
    Friend WithEvents ucrReceiverFill As ucrReceiverSingle
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents lblTextColour As Label
    Friend WithEvents ucrColourText As ucrColors
    Friend WithEvents lblTileColour As Label
    Friend WithEvents ucrColourTile As ucrColors
    Friend WithEvents lblSummary As Label
    Friend WithEvents ucrInputSummary As ucrInputComboBox
End Class
