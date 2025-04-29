<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgTransformations
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
        Me.rdoIDVarietyTraitLevel = New System.Windows.Forms.RadioButton()
        Me.rdoVarietyLevel = New System.Windows.Forms.RadioButton()
        Me.rdoIDLevel = New System.Windows.Forms.RadioButton()
        Me.ucrPnlTransformations = New instat.UcrPanel()
        Me.rdoIDVarietyLevel = New System.Windows.Forms.RadioButton()
        Me.ucrSelectorTricotIDLevel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverIDVariable = New instat.ucrReceiverSingle()
        Me.lblIDVariable = New System.Windows.Forms.Label()
        Me.lblVariety = New System.Windows.Forms.Label()
        Me.ucrReceiverVariety = New instat.ucrReceiverSingle()
        Me.lblTraits = New System.Windows.Forms.Label()
        Me.ucrReceiverTraits1 = New instat.ucrReceiverSingle()
        Me.ucrBaseSdgCorrPlot = New instat.ucrButtonsSubdialogue()
        Me.ucrReceiverTraits2 = New instat.ucrReceiverMultiple()
        Me.lblTraits2 = New System.Windows.Forms.Label()
        Me.ucrInputBadTraits = New instat.ucrInputComboBox()
        Me.ucrInputNAS = New instat.ucrInputComboBox()
        Me.ucrInputGoodTraits = New instat.ucrInputComboBox()
        Me.lblGoodTraits = New System.Windows.Forms.Label()
        Me.lblBadTraits = New System.Windows.Forms.Label()
        Me.lblNAs = New System.Windows.Forms.Label()
        Me.ucrReceiverIDVarietyVar = New instat.ucrReceiverSingle()
        Me.ucrReceiverIDVarietyLevel = New instat.ucrReceiverSingle()
        Me.lblVariety2 = New System.Windows.Forms.Label()
        Me.ucrReceiverTraitID = New instat.ucrReceiverSingle()
        Me.ucrReceiverTraitsVariety = New instat.ucrReceiverSingle()
        Me.lblIDVariable2 = New System.Windows.Forms.Label()
        Me.lblIDVariable3 = New System.Windows.Forms.Label()
        Me.lblVariety3 = New System.Windows.Forms.Label()
        Me.lblTrait2 = New System.Windows.Forms.Label()
        Me.ucrSelectorTricotVarietyLevel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSelectorIDVarietyLevel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSelectorIDVarTraitLevel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'rdoIDVarietyTraitLevel
        '
        Me.rdoIDVarietyTraitLevel.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoIDVarietyTraitLevel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoIDVarietyTraitLevel.FlatAppearance.BorderSize = 2
        Me.rdoIDVarietyTraitLevel.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoIDVarietyTraitLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoIDVarietyTraitLevel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoIDVarietyTraitLevel.Location = New System.Drawing.Point(322, 13)
        Me.rdoIDVarietyTraitLevel.Name = "rdoIDVarietyTraitLevel"
        Me.rdoIDVarietyTraitLevel.Size = New System.Drawing.Size(101, 27)
        Me.rdoIDVarietyTraitLevel.TabIndex = 7
        Me.rdoIDVarietyTraitLevel.TabStop = True
        Me.rdoIDVarietyTraitLevel.Text = "ID-Variety-Trait Level"
        Me.rdoIDVarietyTraitLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoIDVarietyTraitLevel.UseVisualStyleBackColor = True
        '
        'rdoVarietyLevel
        '
        Me.rdoVarietyLevel.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoVarietyLevel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVarietyLevel.FlatAppearance.BorderSize = 2
        Me.rdoVarietyLevel.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVarietyLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoVarietyLevel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoVarietyLevel.Location = New System.Drawing.Point(128, 13)
        Me.rdoVarietyLevel.Name = "rdoVarietyLevel"
        Me.rdoVarietyLevel.Size = New System.Drawing.Size(97, 27)
        Me.rdoVarietyLevel.TabIndex = 6
        Me.rdoVarietyLevel.TabStop = True
        Me.rdoVarietyLevel.Text = "Variety Level"
        Me.rdoVarietyLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoVarietyLevel.UseVisualStyleBackColor = True
        '
        'rdoIDLevel
        '
        Me.rdoIDLevel.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoIDLevel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoIDLevel.FlatAppearance.BorderSize = 2
        Me.rdoIDLevel.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoIDLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoIDLevel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoIDLevel.Location = New System.Drawing.Point(36, 13)
        Me.rdoIDLevel.Name = "rdoIDLevel"
        Me.rdoIDLevel.Size = New System.Drawing.Size(93, 27)
        Me.rdoIDLevel.TabIndex = 5
        Me.rdoIDLevel.TabStop = True
        Me.rdoIDLevel.Text = "ID Level"
        Me.rdoIDLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoIDLevel.UseVisualStyleBackColor = True
        '
        'ucrPnlTransformations
        '
        Me.ucrPnlTransformations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlTransformations.Location = New System.Drawing.Point(26, 12)
        Me.ucrPnlTransformations.Name = "ucrPnlTransformations"
        Me.ucrPnlTransformations.Size = New System.Drawing.Size(410, 35)
        Me.ucrPnlTransformations.TabIndex = 4
        '
        'rdoIDVarietyLevel
        '
        Me.rdoIDVarietyLevel.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoIDVarietyLevel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoIDVarietyLevel.FlatAppearance.BorderSize = 2
        Me.rdoIDVarietyLevel.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoIDVarietyLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoIDVarietyLevel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoIDVarietyLevel.Location = New System.Drawing.Point(225, 13)
        Me.rdoIDVarietyLevel.Name = "rdoIDVarietyLevel"
        Me.rdoIDVarietyLevel.Size = New System.Drawing.Size(97, 27)
        Me.rdoIDVarietyLevel.TabIndex = 8
        Me.rdoIDVarietyLevel.TabStop = True
        Me.rdoIDVarietyLevel.Text = "ID-Variety Level"
        Me.rdoIDVarietyLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoIDVarietyLevel.UseVisualStyleBackColor = True
        '
        'ucrSelectorTricotIDLevel
        '
        Me.ucrSelectorTricotIDLevel.AutoSize = True
        Me.ucrSelectorTricotIDLevel.bDropUnusedFilterLevels = False
        Me.ucrSelectorTricotIDLevel.bShowHiddenColumns = False
        Me.ucrSelectorTricotIDLevel.bUseCurrentFilter = True
        Me.ucrSelectorTricotIDLevel.Location = New System.Drawing.Point(12, 73)
        Me.ucrSelectorTricotIDLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTricotIDLevel.Name = "ucrSelectorTricotIDLevel"
        Me.ucrSelectorTricotIDLevel.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorTricotIDLevel.TabIndex = 9
        '
        'ucrReceiverIDVariable
        '
        Me.ucrReceiverIDVariable.AutoSize = True
        Me.ucrReceiverIDVariable.frmParent = Me
        Me.ucrReceiverIDVariable.Location = New System.Drawing.Point(310, 99)
        Me.ucrReceiverIDVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverIDVariable.Name = "ucrReceiverIDVariable"
        Me.ucrReceiverIDVariable.Selector = Nothing
        Me.ucrReceiverIDVariable.Size = New System.Drawing.Size(113, 20)
        Me.ucrReceiverIDVariable.strNcFilePath = ""
        Me.ucrReceiverIDVariable.TabIndex = 11
        Me.ucrReceiverIDVariable.ucrSelector = Nothing
        '
        'lblIDVariable
        '
        Me.lblIDVariable.AutoSize = True
        Me.lblIDVariable.Location = New System.Drawing.Point(307, 73)
        Me.lblIDVariable.Name = "lblIDVariable"
        Me.lblIDVariable.Size = New System.Drawing.Size(62, 13)
        Me.lblIDVariable.TabIndex = 13
        Me.lblIDVariable.Text = "ID Variable:"
        '
        'lblVariety
        '
        Me.lblVariety.AutoSize = True
        Me.lblVariety.Location = New System.Drawing.Point(307, 73)
        Me.lblVariety.Name = "lblVariety"
        Me.lblVariety.Size = New System.Drawing.Size(42, 13)
        Me.lblVariety.TabIndex = 15
        Me.lblVariety.Text = "Variety:"
        '
        'ucrReceiverVariety
        '
        Me.ucrReceiverVariety.AutoSize = True
        Me.ucrReceiverVariety.frmParent = Me
        Me.ucrReceiverVariety.Location = New System.Drawing.Point(310, 99)
        Me.ucrReceiverVariety.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVariety.Name = "ucrReceiverVariety"
        Me.ucrReceiverVariety.Selector = Nothing
        Me.ucrReceiverVariety.Size = New System.Drawing.Size(113, 20)
        Me.ucrReceiverVariety.strNcFilePath = ""
        Me.ucrReceiverVariety.TabIndex = 14
        Me.ucrReceiverVariety.ucrSelector = Nothing
        '
        'lblTraits
        '
        Me.lblTraits.AutoSize = True
        Me.lblTraits.Location = New System.Drawing.Point(309, 220)
        Me.lblTraits.Name = "lblTraits"
        Me.lblTraits.Size = New System.Drawing.Size(36, 13)
        Me.lblTraits.TabIndex = 17
        Me.lblTraits.Text = "Traits:"
        '
        'ucrReceiverTraits1
        '
        Me.ucrReceiverTraits1.AutoSize = True
        Me.ucrReceiverTraits1.frmParent = Me
        Me.ucrReceiverTraits1.Location = New System.Drawing.Point(311, 238)
        Me.ucrReceiverTraits1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTraits1.Name = "ucrReceiverTraits1"
        Me.ucrReceiverTraits1.Selector = Nothing
        Me.ucrReceiverTraits1.Size = New System.Drawing.Size(113, 20)
        Me.ucrReceiverTraits1.strNcFilePath = ""
        Me.ucrReceiverTraits1.TabIndex = 16
        Me.ucrReceiverTraits1.ucrSelector = Nothing
        '
        'ucrBaseSdgCorrPlot
        '
        Me.ucrBaseSdgCorrPlot.AutoSize = True
        Me.ucrBaseSdgCorrPlot.Location = New System.Drawing.Point(98, 379)
        Me.ucrBaseSdgCorrPlot.Name = "ucrBaseSdgCorrPlot"
        Me.ucrBaseSdgCorrPlot.Size = New System.Drawing.Size(224, 30)
        Me.ucrBaseSdgCorrPlot.TabIndex = 18
        '
        'ucrReceiverTraits2
        '
        Me.ucrReceiverTraits2.AutoSize = True
        Me.ucrReceiverTraits2.frmParent = Me
        Me.ucrReceiverTraits2.Location = New System.Drawing.Point(310, 238)
        Me.ucrReceiverTraits2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTraits2.Name = "ucrReceiverTraits2"
        Me.ucrReceiverTraits2.Selector = Nothing
        Me.ucrReceiverTraits2.Size = New System.Drawing.Size(137, 82)
        Me.ucrReceiverTraits2.strNcFilePath = ""
        Me.ucrReceiverTraits2.TabIndex = 19
        Me.ucrReceiverTraits2.ucrSelector = Nothing
        '
        'lblTraits2
        '
        Me.lblTraits2.AutoSize = True
        Me.lblTraits2.Location = New System.Drawing.Point(307, 243)
        Me.lblTraits2.Name = "lblTraits2"
        Me.lblTraits2.Size = New System.Drawing.Size(36, 13)
        Me.lblTraits2.TabIndex = 20
        Me.lblTraits2.Text = "Traits:"
        '
        'ucrInputBadTraits
        '
        Me.ucrInputBadTraits.AddQuotesIfUnrecognised = True
        Me.ucrInputBadTraits.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputBadTraits.GetSetSelectedIndex = -1
        Me.ucrInputBadTraits.IsReadOnly = False
        Me.ucrInputBadTraits.Location = New System.Drawing.Point(310, 196)
        Me.ucrInputBadTraits.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputBadTraits.Name = "ucrInputBadTraits"
        Me.ucrInputBadTraits.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputBadTraits.TabIndex = 21
        '
        'ucrInputNAS
        '
        Me.ucrInputNAS.AddQuotesIfUnrecognised = True
        Me.ucrInputNAS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputNAS.GetSetSelectedIndex = -1
        Me.ucrInputNAS.IsReadOnly = False
        Me.ucrInputNAS.Location = New System.Drawing.Point(310, 237)
        Me.ucrInputNAS.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputNAS.Name = "ucrInputNAS"
        Me.ucrInputNAS.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputNAS.TabIndex = 22
        '
        'ucrInputGoodTraits
        '
        Me.ucrInputGoodTraits.AddQuotesIfUnrecognised = True
        Me.ucrInputGoodTraits.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputGoodTraits.GetSetSelectedIndex = -1
        Me.ucrInputGoodTraits.IsReadOnly = False
        Me.ucrInputGoodTraits.Location = New System.Drawing.Point(310, 149)
        Me.ucrInputGoodTraits.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputGoodTraits.Name = "ucrInputGoodTraits"
        Me.ucrInputGoodTraits.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputGoodTraits.TabIndex = 23
        '
        'lblGoodTraits
        '
        Me.lblGoodTraits.AutoSize = True
        Me.lblGoodTraits.Location = New System.Drawing.Point(307, 131)
        Me.lblGoodTraits.Name = "lblGoodTraits"
        Me.lblGoodTraits.Size = New System.Drawing.Size(94, 13)
        Me.lblGoodTraits.TabIndex = 24
        Me.lblGoodTraits.Text = "Good Traits Suffix:"
        '
        'lblBadTraits
        '
        Me.lblBadTraits.AutoSize = True
        Me.lblBadTraits.Location = New System.Drawing.Point(308, 179)
        Me.lblBadTraits.Name = "lblBadTraits"
        Me.lblBadTraits.Size = New System.Drawing.Size(87, 13)
        Me.lblBadTraits.TabIndex = 25
        Me.lblBadTraits.Text = "Bad Traits Suffix:"
        '
        'lblNAs
        '
        Me.lblNAs.AutoSize = True
        Me.lblNAs.Location = New System.Drawing.Point(309, 220)
        Me.lblNAs.Name = "lblNAs"
        Me.lblNAs.Size = New System.Drawing.Size(81, 13)
        Me.lblNAs.TabIndex = 26
        Me.lblNAs.Text = "NA denoted by:"
        '
        'ucrReceiverIDVarietyVar
        '
        Me.ucrReceiverIDVarietyVar.AutoSize = True
        Me.ucrReceiverIDVarietyVar.frmParent = Me
        Me.ucrReceiverIDVarietyVar.Location = New System.Drawing.Point(311, 150)
        Me.ucrReceiverIDVarietyVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverIDVarietyVar.Name = "ucrReceiverIDVarietyVar"
        Me.ucrReceiverIDVarietyVar.Selector = Nothing
        Me.ucrReceiverIDVarietyVar.Size = New System.Drawing.Size(113, 20)
        Me.ucrReceiverIDVarietyVar.strNcFilePath = ""
        Me.ucrReceiverIDVarietyVar.TabIndex = 27
        Me.ucrReceiverIDVarietyVar.ucrSelector = Nothing
        '
        'ucrReceiverIDVarietyLevel
        '
        Me.ucrReceiverIDVarietyLevel.AutoSize = True
        Me.ucrReceiverIDVarietyLevel.frmParent = Me
        Me.ucrReceiverIDVarietyLevel.Location = New System.Drawing.Point(310, 99)
        Me.ucrReceiverIDVarietyLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverIDVarietyLevel.Name = "ucrReceiverIDVarietyLevel"
        Me.ucrReceiverIDVarietyLevel.Selector = Nothing
        Me.ucrReceiverIDVarietyLevel.Size = New System.Drawing.Size(113, 20)
        Me.ucrReceiverIDVarietyLevel.strNcFilePath = ""
        Me.ucrReceiverIDVarietyLevel.TabIndex = 28
        Me.ucrReceiverIDVarietyLevel.ucrSelector = Nothing
        '
        'lblVariety2
        '
        Me.lblVariety2.AutoSize = True
        Me.lblVariety2.Location = New System.Drawing.Point(308, 133)
        Me.lblVariety2.Name = "lblVariety2"
        Me.lblVariety2.Size = New System.Drawing.Size(42, 13)
        Me.lblVariety2.TabIndex = 29
        Me.lblVariety2.Text = "Variety:"
        '
        'ucrReceiverTraitID
        '
        Me.ucrReceiverTraitID.AutoSize = True
        Me.ucrReceiverTraitID.frmParent = Me
        Me.ucrReceiverTraitID.Location = New System.Drawing.Point(310, 99)
        Me.ucrReceiverTraitID.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTraitID.Name = "ucrReceiverTraitID"
        Me.ucrReceiverTraitID.Selector = Nothing
        Me.ucrReceiverTraitID.Size = New System.Drawing.Size(113, 20)
        Me.ucrReceiverTraitID.strNcFilePath = ""
        Me.ucrReceiverTraitID.TabIndex = 30
        Me.ucrReceiverTraitID.ucrSelector = Nothing
        '
        'ucrReceiverTraitsVariety
        '
        Me.ucrReceiverTraitsVariety.AutoSize = True
        Me.ucrReceiverTraitsVariety.frmParent = Me
        Me.ucrReceiverTraitsVariety.Location = New System.Drawing.Point(310, 150)
        Me.ucrReceiverTraitsVariety.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTraitsVariety.Name = "ucrReceiverTraitsVariety"
        Me.ucrReceiverTraitsVariety.Selector = Nothing
        Me.ucrReceiverTraitsVariety.Size = New System.Drawing.Size(113, 20)
        Me.ucrReceiverTraitsVariety.strNcFilePath = ""
        Me.ucrReceiverTraitsVariety.TabIndex = 31
        Me.ucrReceiverTraitsVariety.ucrSelector = Nothing
        '
        'lblIDVariable2
        '
        Me.lblIDVariable2.AutoSize = True
        Me.lblIDVariable2.Location = New System.Drawing.Point(307, 77)
        Me.lblIDVariable2.Name = "lblIDVariable2"
        Me.lblIDVariable2.Size = New System.Drawing.Size(62, 13)
        Me.lblIDVariable2.TabIndex = 32
        Me.lblIDVariable2.Text = "ID Variable:"
        '
        'lblIDVariable3
        '
        Me.lblIDVariable3.AutoSize = True
        Me.lblIDVariable3.Location = New System.Drawing.Point(307, 80)
        Me.lblIDVariable3.Name = "lblIDVariable3"
        Me.lblIDVariable3.Size = New System.Drawing.Size(62, 13)
        Me.lblIDVariable3.TabIndex = 33
        Me.lblIDVariable3.Text = "ID Variable:"
        '
        'lblVariety3
        '
        Me.lblVariety3.AutoSize = True
        Me.lblVariety3.Location = New System.Drawing.Point(307, 130)
        Me.lblVariety3.Name = "lblVariety3"
        Me.lblVariety3.Size = New System.Drawing.Size(42, 13)
        Me.lblVariety3.TabIndex = 34
        Me.lblVariety3.Text = "Variety:"
        '
        'lblTrait2
        '
        Me.lblTrait2.AutoSize = True
        Me.lblTrait2.Location = New System.Drawing.Point(307, 220)
        Me.lblTrait2.Name = "lblTrait2"
        Me.lblTrait2.Size = New System.Drawing.Size(36, 13)
        Me.lblTrait2.TabIndex = 35
        Me.lblTrait2.Text = "Traits:"
        '
        'ucrSelectorTricotVarietyLevel
        '
        Me.ucrSelectorTricotVarietyLevel.AutoSize = True
        Me.ucrSelectorTricotVarietyLevel.bDropUnusedFilterLevels = False
        Me.ucrSelectorTricotVarietyLevel.bShowHiddenColumns = False
        Me.ucrSelectorTricotVarietyLevel.bUseCurrentFilter = True
        Me.ucrSelectorTricotVarietyLevel.Location = New System.Drawing.Point(9, 75)
        Me.ucrSelectorTricotVarietyLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTricotVarietyLevel.Name = "ucrSelectorTricotVarietyLevel"
        Me.ucrSelectorTricotVarietyLevel.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorTricotVarietyLevel.TabIndex = 36
        '
        'ucrSelectorIDVarietyLevel
        '
        Me.ucrSelectorIDVarietyLevel.AutoSize = True
        Me.ucrSelectorIDVarietyLevel.bDropUnusedFilterLevels = False
        Me.ucrSelectorIDVarietyLevel.bShowHiddenColumns = False
        Me.ucrSelectorIDVarietyLevel.bUseCurrentFilter = True
        Me.ucrSelectorIDVarietyLevel.Location = New System.Drawing.Point(9, 75)
        Me.ucrSelectorIDVarietyLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorIDVarietyLevel.Name = "ucrSelectorIDVarietyLevel"
        Me.ucrSelectorIDVarietyLevel.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorIDVarietyLevel.TabIndex = 37
        '
        'ucrSelectorIDVarTraitLevel
        '
        Me.ucrSelectorIDVarTraitLevel.AutoSize = True
        Me.ucrSelectorIDVarTraitLevel.bDropUnusedFilterLevels = False
        Me.ucrSelectorIDVarTraitLevel.bShowHiddenColumns = False
        Me.ucrSelectorIDVarTraitLevel.bUseCurrentFilter = True
        Me.ucrSelectorIDVarTraitLevel.Location = New System.Drawing.Point(9, 75)
        Me.ucrSelectorIDVarTraitLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorIDVarTraitLevel.Name = "ucrSelectorIDVarTraitLevel"
        Me.ucrSelectorIDVarTraitLevel.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorIDVarTraitLevel.TabIndex = 38
        '
        'sdgTransformations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 423)
        Me.Controls.Add(Me.ucrSelectorIDVarTraitLevel)
        Me.Controls.Add(Me.ucrSelectorIDVarietyLevel)
        Me.Controls.Add(Me.ucrSelectorTricotVarietyLevel)
        Me.Controls.Add(Me.lblTrait2)
        Me.Controls.Add(Me.lblVariety3)
        Me.Controls.Add(Me.lblIDVariable3)
        Me.Controls.Add(Me.lblIDVariable2)
        Me.Controls.Add(Me.ucrReceiverTraitsVariety)
        Me.Controls.Add(Me.ucrReceiverTraitID)
        Me.Controls.Add(Me.lblVariety2)
        Me.Controls.Add(Me.ucrReceiverIDVarietyLevel)
        Me.Controls.Add(Me.ucrReceiverIDVarietyVar)
        Me.Controls.Add(Me.lblNAs)
        Me.Controls.Add(Me.lblBadTraits)
        Me.Controls.Add(Me.lblGoodTraits)
        Me.Controls.Add(Me.ucrInputGoodTraits)
        Me.Controls.Add(Me.ucrInputNAS)
        Me.Controls.Add(Me.ucrInputBadTraits)
        Me.Controls.Add(Me.lblTraits2)
        Me.Controls.Add(Me.ucrReceiverTraits2)
        Me.Controls.Add(Me.ucrBaseSdgCorrPlot)
        Me.Controls.Add(Me.lblTraits)
        Me.Controls.Add(Me.ucrReceiverTraits1)
        Me.Controls.Add(Me.lblVariety)
        Me.Controls.Add(Me.ucrReceiverVariety)
        Me.Controls.Add(Me.lblIDVariable)
        Me.Controls.Add(Me.ucrReceiverIDVariable)
        Me.Controls.Add(Me.ucrSelectorTricotIDLevel)
        Me.Controls.Add(Me.rdoIDVarietyLevel)
        Me.Controls.Add(Me.rdoIDVarietyTraitLevel)
        Me.Controls.Add(Me.rdoVarietyLevel)
        Me.Controls.Add(Me.rdoIDLevel)
        Me.Controls.Add(Me.ucrPnlTransformations)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "sdgTransformations"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transformations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdoIDVarietyTraitLevel As RadioButton
    Friend WithEvents rdoVarietyLevel As RadioButton
    Friend WithEvents rdoIDLevel As RadioButton
    Friend WithEvents ucrPnlTransformations As UcrPanel
    Friend WithEvents rdoIDVarietyLevel As RadioButton
    Friend WithEvents ucrSelectorTricotIDLevel As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverIDVariable As ucrReceiverSingle
    Friend WithEvents lblTraits As Label
    Friend WithEvents ucrReceiverTraits1 As ucrReceiverSingle
    Friend WithEvents lblVariety As Label
    Friend WithEvents ucrReceiverVariety As ucrReceiverSingle
    Friend WithEvents lblIDVariable As Label
    Friend WithEvents ucrBaseSdgCorrPlot As ucrButtonsSubdialogue
    Friend WithEvents lblTraits2 As Label
    Friend WithEvents ucrReceiverTraits2 As ucrReceiverMultiple
    Friend WithEvents lblNAs As Label
    Friend WithEvents lblBadTraits As Label
    Friend WithEvents lblGoodTraits As Label
    Friend WithEvents ucrInputGoodTraits As ucrInputComboBox
    Friend WithEvents ucrInputNAS As ucrInputComboBox
    Friend WithEvents ucrInputBadTraits As ucrInputComboBox
    Friend WithEvents lblVariety2 As Label
    Friend WithEvents ucrReceiverIDVarietyLevel As ucrReceiverSingle
    Friend WithEvents ucrReceiverIDVarietyVar As ucrReceiverSingle
    Friend WithEvents ucrReceiverTraitsVariety As ucrReceiverSingle
    Friend WithEvents ucrReceiverTraitID As ucrReceiverSingle
    Friend WithEvents lblIDVariable2 As Label
    Friend WithEvents lblIDVariable3 As Label
    Friend WithEvents lblTrait2 As Label
    Friend WithEvents lblVariety3 As Label
    Friend WithEvents ucrSelectorIDVarTraitLevel As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectorIDVarietyLevel As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectorTricotVarietyLevel As ucrSelectorByDataFrameAddRemove
End Class
