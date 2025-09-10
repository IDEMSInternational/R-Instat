<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgTransformations
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
        Me.lblIDVariable = New System.Windows.Forms.Label()
        Me.lblVariety = New System.Windows.Forms.Label()
        Me.lblTraits = New System.Windows.Forms.Label()
        Me.lblTraits2 = New System.Windows.Forms.Label()
        Me.lblGoodTraits = New System.Windows.Forms.Label()
        Me.lblBadTraits = New System.Windows.Forms.Label()
        Me.lblNAs = New System.Windows.Forms.Label()
        Me.lblVariety2 = New System.Windows.Forms.Label()
        Me.lblIDVariable2 = New System.Windows.Forms.Label()
        Me.lblIDVariable3 = New System.Windows.Forms.Label()
        Me.lblVariety3 = New System.Windows.Forms.Label()
        Me.ucrSelectorIDVarTraitLevel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSelectorIDVarietyLevel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSelectorTricotVarietyLevel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverTraitsVariety = New instat.ucrReceiverSingle()
        Me.ucrReceiverTraitID = New instat.ucrReceiverSingle()
        Me.ucrReceiverIDVarietyLevel = New instat.ucrReceiverSingle()
        Me.ucrReceiverIDVarietyVar = New instat.ucrReceiverSingle()
        Me.ucrInputGoodTraits = New instat.ucrInputComboBox()
        Me.ucrInputNAS = New instat.ucrInputComboBox()
        Me.ucrInputBadTraits = New instat.ucrInputComboBox()
        Me.ucrReceiverTraits2 = New instat.ucrReceiverMultiple()
        Me.ucrBaseSdgTransformations = New instat.ucrButtonsSubdialogue()
        Me.ucrReceiverTraits1 = New instat.ucrReceiverSingle()
        Me.ucrReceiverVariety = New instat.ucrReceiverSingle()
        Me.ucrSelectorTricotIDLevel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.tbOptions = New System.Windows.Forms.TabControl()
        Me.tbIDLevel = New System.Windows.Forms.TabPage()
        Me.ucrChkSpecifyTraitVariables = New instat.ucrCheck()
        Me.lblTraitVariables = New System.Windows.Forms.Label()
        Me.ucrReceiverTraitVariables = New instat.ucrReceiverMultiple()
        Me.ucrInputRankValues = New instat.ucrInputTextBox()
        Me.ucrChkSpecifyRankValues = New instat.ucrCheck()
        Me.lblReceiverRankValues = New System.Windows.Forms.Label()
        Me.ucrChkSpecifyVariety = New instat.ucrCheck()
        Me.lblReceiverSpecifyVarietyVariables = New System.Windows.Forms.Label()
        Me.ucrReceiverVarietyVariables = New instat.ucrReceiverMultiple()
        Me.ucrChkTraits = New instat.ucrCheck()
        Me.ucrReceiverIDVariable = New instat.ucrReceiverSingle()
        Me.tbVarietyLevel = New System.Windows.Forms.TabPage()
        Me.tbIDVarietyLevel = New System.Windows.Forms.TabPage()
        Me.tbIDVarietyTraitLevel = New System.Windows.Forms.TabPage()
        Me.lblReceiverCarryColumns = New System.Windows.Forms.Label()
        Me.ucrReceiverCarryColumns = New instat.ucrReceiverMultiple()
        Me.ucrChkCarryColumns = New instat.ucrCheck()
        Me.tbOptions.SuspendLayout()
        Me.tbIDLevel.SuspendLayout()
        Me.tbVarietyLevel.SuspendLayout()
        Me.tbIDVarietyLevel.SuspendLayout()
        Me.tbIDVarietyTraitLevel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblIDVariable
        '
        Me.lblIDVariable.AutoSize = True
        Me.lblIDVariable.Location = New System.Drawing.Point(238, 38)
        Me.lblIDVariable.Name = "lblIDVariable"
        Me.lblIDVariable.Size = New System.Drawing.Size(62, 13)
        Me.lblIDVariable.TabIndex = 1
        Me.lblIDVariable.Text = "ID Variable:"
        '
        'lblVariety
        '
        Me.lblVariety.AutoSize = True
        Me.lblVariety.Location = New System.Drawing.Point(238, 38)
        Me.lblVariety.Name = "lblVariety"
        Me.lblVariety.Size = New System.Drawing.Size(42, 13)
        Me.lblVariety.TabIndex = 1
        Me.lblVariety.Text = "Variety:"
        '
        'lblTraits
        '
        Me.lblTraits.AutoSize = True
        Me.lblTraits.Location = New System.Drawing.Point(237, 134)
        Me.lblTraits.Name = "lblTraits"
        Me.lblTraits.Size = New System.Drawing.Size(36, 13)
        Me.lblTraits.TabIndex = 5
        Me.lblTraits.Text = "Traits:"
        '
        'lblTraits2
        '
        Me.lblTraits2.AutoSize = True
        Me.lblTraits2.Location = New System.Drawing.Point(237, 134)
        Me.lblTraits2.Name = "lblTraits2"
        Me.lblTraits2.Size = New System.Drawing.Size(36, 13)
        Me.lblTraits2.TabIndex = 5
        Me.lblTraits2.Text = "Traits:"
        '
        'lblGoodTraits
        '
        Me.lblGoodTraits.AutoSize = True
        Me.lblGoodTraits.Location = New System.Drawing.Point(241, 138)
        Me.lblGoodTraits.Name = "lblGoodTraits"
        Me.lblGoodTraits.Size = New System.Drawing.Size(105, 13)
        Me.lblGoodTraits.TabIndex = 4
        Me.lblGoodTraits.Text = "Positive Traits Suffix:"
        '
        'lblBadTraits
        '
        Me.lblBadTraits.AutoSize = True
        Me.lblBadTraits.Location = New System.Drawing.Point(241, 186)
        Me.lblBadTraits.Name = "lblBadTraits"
        Me.lblBadTraits.Size = New System.Drawing.Size(111, 13)
        Me.lblBadTraits.TabIndex = 6
        Me.lblBadTraits.Text = "Negative Traits Suffix:"
        '
        'lblNAs
        '
        Me.lblNAs.AutoSize = True
        Me.lblNAs.Location = New System.Drawing.Point(238, 89)
        Me.lblNAs.Name = "lblNAs"
        Me.lblNAs.Size = New System.Drawing.Size(81, 13)
        Me.lblNAs.TabIndex = 8
        Me.lblNAs.Text = "NA denoted by:"
        '
        'lblVariety2
        '
        Me.lblVariety2.AutoSize = True
        Me.lblVariety2.Location = New System.Drawing.Point(238, 89)
        Me.lblVariety2.Name = "lblVariety2"
        Me.lblVariety2.Size = New System.Drawing.Size(42, 13)
        Me.lblVariety2.TabIndex = 3
        Me.lblVariety2.Text = "Variety:"
        '
        'lblIDVariable2
        '
        Me.lblIDVariable2.AutoSize = True
        Me.lblIDVariable2.Location = New System.Drawing.Point(238, 38)
        Me.lblIDVariable2.Name = "lblIDVariable2"
        Me.lblIDVariable2.Size = New System.Drawing.Size(62, 13)
        Me.lblIDVariable2.TabIndex = 1
        Me.lblIDVariable2.Text = "ID Variable:"
        '
        'lblIDVariable3
        '
        Me.lblIDVariable3.AutoSize = True
        Me.lblIDVariable3.Location = New System.Drawing.Point(238, 41)
        Me.lblIDVariable3.Name = "lblIDVariable3"
        Me.lblIDVariable3.Size = New System.Drawing.Size(62, 13)
        Me.lblIDVariable3.TabIndex = 2
        Me.lblIDVariable3.Text = "ID Variable:"
        '
        'lblVariety3
        '
        Me.lblVariety3.AutoSize = True
        Me.lblVariety3.Location = New System.Drawing.Point(238, 89)
        Me.lblVariety3.Name = "lblVariety3"
        Me.lblVariety3.Size = New System.Drawing.Size(42, 13)
        Me.lblVariety3.TabIndex = 3
        Me.lblVariety3.Text = "Variety:"
        '
        'ucrSelectorIDVarTraitLevel
        '
        Me.ucrSelectorIDVarTraitLevel.AutoSize = True
        Me.ucrSelectorIDVarTraitLevel.bDropUnusedFilterLevels = False
        Me.ucrSelectorIDVarTraitLevel.bShowHiddenColumns = False
        Me.ucrSelectorIDVarTraitLevel.bUseCurrentFilter = True
        Me.ucrSelectorIDVarTraitLevel.Location = New System.Drawing.Point(12, 12)
        Me.ucrSelectorIDVarTraitLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorIDVarTraitLevel.Name = "ucrSelectorIDVarTraitLevel"
        Me.ucrSelectorIDVarTraitLevel.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorIDVarTraitLevel.TabIndex = 0
        '
        'ucrSelectorIDVarietyLevel
        '
        Me.ucrSelectorIDVarietyLevel.AutoSize = True
        Me.ucrSelectorIDVarietyLevel.bDropUnusedFilterLevels = False
        Me.ucrSelectorIDVarietyLevel.bShowHiddenColumns = False
        Me.ucrSelectorIDVarietyLevel.bUseCurrentFilter = True
        Me.ucrSelectorIDVarietyLevel.Location = New System.Drawing.Point(12, 12)
        Me.ucrSelectorIDVarietyLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorIDVarietyLevel.Name = "ucrSelectorIDVarietyLevel"
        Me.ucrSelectorIDVarietyLevel.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorIDVarietyLevel.TabIndex = 0
        '
        'ucrSelectorTricotVarietyLevel
        '
        Me.ucrSelectorTricotVarietyLevel.AutoSize = True
        Me.ucrSelectorTricotVarietyLevel.bDropUnusedFilterLevels = False
        Me.ucrSelectorTricotVarietyLevel.bShowHiddenColumns = False
        Me.ucrSelectorTricotVarietyLevel.bUseCurrentFilter = True
        Me.ucrSelectorTricotVarietyLevel.Location = New System.Drawing.Point(12, 12)
        Me.ucrSelectorTricotVarietyLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTricotVarietyLevel.Name = "ucrSelectorTricotVarietyLevel"
        Me.ucrSelectorTricotVarietyLevel.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorTricotVarietyLevel.TabIndex = 0
        '
        'ucrReceiverTraitsVariety
        '
        Me.ucrReceiverTraitsVariety.AutoSize = True
        Me.ucrReceiverTraitsVariety.frmParent = Nothing
        Me.ucrReceiverTraitsVariety.Location = New System.Drawing.Point(238, 104)
        Me.ucrReceiverTraitsVariety.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTraitsVariety.Name = "ucrReceiverTraitsVariety"
        Me.ucrReceiverTraitsVariety.Selector = Nothing
        Me.ucrReceiverTraitsVariety.Size = New System.Drawing.Size(113, 20)
        Me.ucrReceiverTraitsVariety.strNcFilePath = ""
        Me.ucrReceiverTraitsVariety.TabIndex = 4
        Me.ucrReceiverTraitsVariety.ucrSelector = Nothing
        '
        'ucrReceiverTraitID
        '
        Me.ucrReceiverTraitID.AutoSize = True
        Me.ucrReceiverTraitID.frmParent = Nothing
        Me.ucrReceiverTraitID.Location = New System.Drawing.Point(239, 53)
        Me.ucrReceiverTraitID.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTraitID.Name = "ucrReceiverTraitID"
        Me.ucrReceiverTraitID.Selector = Nothing
        Me.ucrReceiverTraitID.Size = New System.Drawing.Size(113, 20)
        Me.ucrReceiverTraitID.strNcFilePath = ""
        Me.ucrReceiverTraitID.TabIndex = 2
        Me.ucrReceiverTraitID.ucrSelector = Nothing
        '
        'ucrReceiverIDVarietyLevel
        '
        Me.ucrReceiverIDVarietyLevel.AutoSize = True
        Me.ucrReceiverIDVarietyLevel.frmParent = Nothing
        Me.ucrReceiverIDVarietyLevel.Location = New System.Drawing.Point(239, 53)
        Me.ucrReceiverIDVarietyLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverIDVarietyLevel.Name = "ucrReceiverIDVarietyLevel"
        Me.ucrReceiverIDVarietyLevel.Selector = Nothing
        Me.ucrReceiverIDVarietyLevel.Size = New System.Drawing.Size(113, 20)
        Me.ucrReceiverIDVarietyLevel.strNcFilePath = ""
        Me.ucrReceiverIDVarietyLevel.TabIndex = 2
        Me.ucrReceiverIDVarietyLevel.ucrSelector = Nothing
        '
        'ucrReceiverIDVarietyVar
        '
        Me.ucrReceiverIDVarietyVar.AutoSize = True
        Me.ucrReceiverIDVarietyVar.frmParent = Nothing
        Me.ucrReceiverIDVarietyVar.Location = New System.Drawing.Point(238, 104)
        Me.ucrReceiverIDVarietyVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverIDVarietyVar.Name = "ucrReceiverIDVarietyVar"
        Me.ucrReceiverIDVarietyVar.Selector = Nothing
        Me.ucrReceiverIDVarietyVar.Size = New System.Drawing.Size(113, 20)
        Me.ucrReceiverIDVarietyVar.strNcFilePath = ""
        Me.ucrReceiverIDVarietyVar.TabIndex = 4
        Me.ucrReceiverIDVarietyVar.ucrSelector = Nothing
        '
        'ucrInputGoodTraits
        '
        Me.ucrInputGoodTraits.AddQuotesIfUnrecognised = True
        Me.ucrInputGoodTraits.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputGoodTraits.GetSetSelectedIndex = -1
        Me.ucrInputGoodTraits.IsReadOnly = False
        Me.ucrInputGoodTraits.Location = New System.Drawing.Point(238, 154)
        Me.ucrInputGoodTraits.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputGoodTraits.Name = "ucrInputGoodTraits"
        Me.ucrInputGoodTraits.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputGoodTraits.TabIndex = 5
        '
        'ucrInputNAS
        '
        Me.ucrInputNAS.AddQuotesIfUnrecognised = True
        Me.ucrInputNAS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputNAS.GetSetSelectedIndex = -1
        Me.ucrInputNAS.IsReadOnly = False
        Me.ucrInputNAS.Location = New System.Drawing.Point(238, 105)
        Me.ucrInputNAS.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputNAS.Name = "ucrInputNAS"
        Me.ucrInputNAS.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputNAS.TabIndex = 0
        '
        'ucrInputBadTraits
        '
        Me.ucrInputBadTraits.AddQuotesIfUnrecognised = True
        Me.ucrInputBadTraits.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputBadTraits.GetSetSelectedIndex = -1
        Me.ucrInputBadTraits.IsReadOnly = False
        Me.ucrInputBadTraits.Location = New System.Drawing.Point(238, 202)
        Me.ucrInputBadTraits.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputBadTraits.Name = "ucrInputBadTraits"
        Me.ucrInputBadTraits.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputBadTraits.TabIndex = 7
        '
        'ucrReceiverTraits2
        '
        Me.ucrReceiverTraits2.AutoSize = True
        Me.ucrReceiverTraits2.frmParent = Nothing
        Me.ucrReceiverTraits2.Location = New System.Drawing.Point(238, 149)
        Me.ucrReceiverTraits2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTraits2.Name = "ucrReceiverTraits2"
        Me.ucrReceiverTraits2.Selector = Nothing
        Me.ucrReceiverTraits2.Size = New System.Drawing.Size(137, 82)
        Me.ucrReceiverTraits2.strNcFilePath = ""
        Me.ucrReceiverTraits2.TabIndex = 6
        Me.ucrReceiverTraits2.ucrSelector = Nothing
        '
        'ucrBaseSdgTransformations
        '
        Me.ucrBaseSdgTransformations.AutoSize = True
        Me.ucrBaseSdgTransformations.Location = New System.Drawing.Point(163, 398)
        Me.ucrBaseSdgTransformations.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBaseSdgTransformations.Name = "ucrBaseSdgTransformations"
        Me.ucrBaseSdgTransformations.Size = New System.Drawing.Size(224, 30)
        Me.ucrBaseSdgTransformations.TabIndex = 1
        '
        'ucrReceiverTraits1
        '
        Me.ucrReceiverTraits1.AutoSize = True
        Me.ucrReceiverTraits1.frmParent = Nothing
        Me.ucrReceiverTraits1.Location = New System.Drawing.Point(238, 149)
        Me.ucrReceiverTraits1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTraits1.Name = "ucrReceiverTraits1"
        Me.ucrReceiverTraits1.Selector = Nothing
        Me.ucrReceiverTraits1.Size = New System.Drawing.Size(113, 20)
        Me.ucrReceiverTraits1.strNcFilePath = ""
        Me.ucrReceiverTraits1.TabIndex = 6
        Me.ucrReceiverTraits1.ucrSelector = Nothing
        '
        'ucrReceiverVariety
        '
        Me.ucrReceiverVariety.AutoSize = True
        Me.ucrReceiverVariety.frmParent = Nothing
        Me.ucrReceiverVariety.Location = New System.Drawing.Point(239, 53)
        Me.ucrReceiverVariety.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVariety.Name = "ucrReceiverVariety"
        Me.ucrReceiverVariety.Selector = Nothing
        Me.ucrReceiverVariety.Size = New System.Drawing.Size(113, 20)
        Me.ucrReceiverVariety.strNcFilePath = ""
        Me.ucrReceiverVariety.TabIndex = 2
        Me.ucrReceiverVariety.ucrSelector = Nothing
        '
        'ucrSelectorTricotIDLevel
        '
        Me.ucrSelectorTricotIDLevel.AutoSize = True
        Me.ucrSelectorTricotIDLevel.bDropUnusedFilterLevels = False
        Me.ucrSelectorTricotIDLevel.bShowHiddenColumns = False
        Me.ucrSelectorTricotIDLevel.bUseCurrentFilter = True
        Me.ucrSelectorTricotIDLevel.Location = New System.Drawing.Point(12, 12)
        Me.ucrSelectorTricotIDLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTricotIDLevel.Name = "ucrSelectorTricotIDLevel"
        Me.ucrSelectorTricotIDLevel.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorTricotIDLevel.TabIndex = 0
        '
        'tbOptions
        '
        Me.tbOptions.Controls.Add(Me.tbIDLevel)
        Me.tbOptions.Controls.Add(Me.tbVarietyLevel)
        Me.tbOptions.Controls.Add(Me.tbIDVarietyLevel)
        Me.tbOptions.Controls.Add(Me.tbIDVarietyTraitLevel)
        Me.tbOptions.Location = New System.Drawing.Point(8, 8)
        Me.tbOptions.Margin = New System.Windows.Forms.Padding(2)
        Me.tbOptions.Name = "tbOptions"
        Me.tbOptions.SelectedIndex = 0
        Me.tbOptions.Size = New System.Drawing.Size(573, 382)
        Me.tbOptions.TabIndex = 0
        '
        'tbIDLevel
        '
        Me.tbIDLevel.Controls.Add(Me.ucrChkCarryColumns)
        Me.tbIDLevel.Controls.Add(Me.lblReceiverCarryColumns)
        Me.tbIDLevel.Controls.Add(Me.ucrReceiverCarryColumns)
        Me.tbIDLevel.Controls.Add(Me.ucrChkSpecifyTraitVariables)
        Me.tbIDLevel.Controls.Add(Me.lblTraitVariables)
        Me.tbIDLevel.Controls.Add(Me.ucrReceiverTraitVariables)
        Me.tbIDLevel.Controls.Add(Me.ucrInputRankValues)
        Me.tbIDLevel.Controls.Add(Me.ucrChkSpecifyRankValues)
        Me.tbIDLevel.Controls.Add(Me.lblReceiverRankValues)
        Me.tbIDLevel.Controls.Add(Me.ucrChkSpecifyVariety)
        Me.tbIDLevel.Controls.Add(Me.lblReceiverSpecifyVarietyVariables)
        Me.tbIDLevel.Controls.Add(Me.ucrReceiverVarietyVariables)
        Me.tbIDLevel.Controls.Add(Me.ucrChkTraits)
        Me.tbIDLevel.Controls.Add(Me.ucrReceiverIDVariable)
        Me.tbIDLevel.Controls.Add(Me.ucrInputBadTraits)
        Me.tbIDLevel.Controls.Add(Me.ucrInputNAS)
        Me.tbIDLevel.Controls.Add(Me.lblBadTraits)
        Me.tbIDLevel.Controls.Add(Me.lblNAs)
        Me.tbIDLevel.Controls.Add(Me.lblIDVariable3)
        Me.tbIDLevel.Controls.Add(Me.ucrInputGoodTraits)
        Me.tbIDLevel.Controls.Add(Me.lblGoodTraits)
        Me.tbIDLevel.Controls.Add(Me.ucrSelectorTricotIDLevel)
        Me.tbIDLevel.Location = New System.Drawing.Point(4, 22)
        Me.tbIDLevel.Margin = New System.Windows.Forms.Padding(2)
        Me.tbIDLevel.Name = "tbIDLevel"
        Me.tbIDLevel.Padding = New System.Windows.Forms.Padding(2)
        Me.tbIDLevel.Size = New System.Drawing.Size(565, 356)
        Me.tbIDLevel.TabIndex = 0
        Me.tbIDLevel.Text = "ID Level"
        Me.tbIDLevel.UseVisualStyleBackColor = True
        '
        'ucrChkSpecifyTraitVariables
        '
        Me.ucrChkSpecifyTraitVariables.AutoSize = True
        Me.ucrChkSpecifyTraitVariables.Checked = False
        Me.ucrChkSpecifyTraitVariables.Location = New System.Drawing.Point(12, 297)
        Me.ucrChkSpecifyTraitVariables.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrChkSpecifyTraitVariables.Name = "ucrChkSpecifyTraitVariables"
        Me.ucrChkSpecifyTraitVariables.Size = New System.Drawing.Size(149, 23)
        Me.ucrChkSpecifyTraitVariables.TabIndex = 20
        '
        'lblTraitVariables
        '
        Me.lblTraitVariables.AutoSize = True
        Me.lblTraitVariables.Location = New System.Drawing.Point(394, 99)
        Me.lblTraitVariables.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTraitVariables.Name = "lblTraitVariables"
        Me.lblTraitVariables.Size = New System.Drawing.Size(74, 13)
        Me.lblTraitVariables.TabIndex = 18
        Me.lblTraitVariables.Text = "Trait Variables"
        '
        'ucrReceiverTraitVariables
        '
        Me.ucrReceiverTraitVariables.AutoSize = True
        Me.ucrReceiverTraitVariables.frmParent = Nothing
        Me.ucrReceiverTraitVariables.Location = New System.Drawing.Point(394, 114)
        Me.ucrReceiverTraitVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTraitVariables.Name = "ucrReceiverTraitVariables"
        Me.ucrReceiverTraitVariables.Selector = Nothing
        Me.ucrReceiverTraitVariables.Size = New System.Drawing.Size(157, 101)
        Me.ucrReceiverTraitVariables.strNcFilePath = ""
        Me.ucrReceiverTraitVariables.TabIndex = 19
        Me.ucrReceiverTraitVariables.ucrSelector = Nothing
        '
        'ucrInputRankValues
        '
        Me.ucrInputRankValues.AddQuotesIfUnrecognised = True
        Me.ucrInputRankValues.AutoSize = True
        Me.ucrInputRankValues.IsMultiline = False
        Me.ucrInputRankValues.IsReadOnly = False
        Me.ucrInputRankValues.Location = New System.Drawing.Point(394, 57)
        Me.ucrInputRankValues.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputRankValues.Name = "ucrInputRankValues"
        Me.ucrInputRankValues.Size = New System.Drawing.Size(160, 20)
        Me.ucrInputRankValues.TabIndex = 17
        '
        'ucrChkSpecifyRankValues
        '
        Me.ucrChkSpecifyRankValues.AutoSize = True
        Me.ucrChkSpecifyRankValues.Checked = False
        Me.ucrChkSpecifyRankValues.Location = New System.Drawing.Point(12, 266)
        Me.ucrChkSpecifyRankValues.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrChkSpecifyRankValues.Name = "ucrChkSpecifyRankValues"
        Me.ucrChkSpecifyRankValues.Size = New System.Drawing.Size(149, 23)
        Me.ucrChkSpecifyRankValues.TabIndex = 16
        '
        'lblReceiverRankValues
        '
        Me.lblReceiverRankValues.AutoSize = True
        Me.lblReceiverRankValues.Location = New System.Drawing.Point(394, 41)
        Me.lblReceiverRankValues.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReceiverRankValues.Name = "lblReceiverRankValues"
        Me.lblReceiverRankValues.Size = New System.Drawing.Size(68, 13)
        Me.lblReceiverRankValues.TabIndex = 15
        Me.lblReceiverRankValues.Text = "Rank Values"
        '
        'ucrChkSpecifyVariety
        '
        Me.ucrChkSpecifyVariety.AutoSize = True
        Me.ucrChkSpecifyVariety.Checked = False
        Me.ucrChkSpecifyVariety.Location = New System.Drawing.Point(12, 238)
        Me.ucrChkSpecifyVariety.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrChkSpecifyVariety.Name = "ucrChkSpecifyVariety"
        Me.ucrChkSpecifyVariety.Size = New System.Drawing.Size(149, 23)
        Me.ucrChkSpecifyVariety.TabIndex = 13
        '
        'lblReceiverSpecifyVarietyVariables
        '
        Me.lblReceiverSpecifyVarietyVariables.AutoSize = True
        Me.lblReceiverSpecifyVarietyVariables.Location = New System.Drawing.Point(235, 232)
        Me.lblReceiverSpecifyVarietyVariables.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReceiverSpecifyVarietyVariables.Name = "lblReceiverSpecifyVarietyVariables"
        Me.lblReceiverSpecifyVarietyVariables.Size = New System.Drawing.Size(85, 13)
        Me.lblReceiverSpecifyVarietyVariables.TabIndex = 11
        Me.lblReceiverSpecifyVarietyVariables.Text = "Variety Variables"
        '
        'ucrReceiverVarietyVariables
        '
        Me.ucrReceiverVarietyVariables.AutoSize = True
        Me.ucrReceiverVarietyVariables.frmParent = Nothing
        Me.ucrReceiverVarietyVariables.Location = New System.Drawing.Point(235, 247)
        Me.ucrReceiverVarietyVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVarietyVariables.Name = "ucrReceiverVarietyVariables"
        Me.ucrReceiverVarietyVariables.Selector = Nothing
        Me.ucrReceiverVarietyVariables.Size = New System.Drawing.Size(151, 101)
        Me.ucrReceiverVarietyVariables.strNcFilePath = ""
        Me.ucrReceiverVarietyVariables.TabIndex = 12
        Me.ucrReceiverVarietyVariables.ucrSelector = Nothing
        '
        'ucrChkTraits
        '
        Me.ucrChkTraits.AutoSize = True
        Me.ucrChkTraits.Checked = False
        Me.ucrChkTraits.Location = New System.Drawing.Point(12, 209)
        Me.ucrChkTraits.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrChkTraits.Name = "ucrChkTraits"
        Me.ucrChkTraits.Size = New System.Drawing.Size(149, 23)
        Me.ucrChkTraits.TabIndex = 10
        '
        'ucrReceiverIDVariable
        '
        Me.ucrReceiverIDVariable.AutoSize = True
        Me.ucrReceiverIDVariable.frmParent = Nothing
        Me.ucrReceiverIDVariable.Location = New System.Drawing.Point(238, 57)
        Me.ucrReceiverIDVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverIDVariable.Name = "ucrReceiverIDVariable"
        Me.ucrReceiverIDVariable.Selector = Nothing
        Me.ucrReceiverIDVariable.Size = New System.Drawing.Size(120, 19)
        Me.ucrReceiverIDVariable.strNcFilePath = ""
        Me.ucrReceiverIDVariable.TabIndex = 3
        Me.ucrReceiverIDVariable.ucrSelector = Nothing
        '
        'tbVarietyLevel
        '
        Me.tbVarietyLevel.Controls.Add(Me.ucrSelectorTricotVarietyLevel)
        Me.tbVarietyLevel.Controls.Add(Me.ucrReceiverVariety)
        Me.tbVarietyLevel.Controls.Add(Me.lblVariety)
        Me.tbVarietyLevel.Location = New System.Drawing.Point(4, 22)
        Me.tbVarietyLevel.Margin = New System.Windows.Forms.Padding(2)
        Me.tbVarietyLevel.Name = "tbVarietyLevel"
        Me.tbVarietyLevel.Padding = New System.Windows.Forms.Padding(2)
        Me.tbVarietyLevel.Size = New System.Drawing.Size(565, 356)
        Me.tbVarietyLevel.TabIndex = 1
        Me.tbVarietyLevel.Text = "Variety Level"
        Me.tbVarietyLevel.UseVisualStyleBackColor = True
        '
        'tbIDVarietyLevel
        '
        Me.tbIDVarietyLevel.Controls.Add(Me.ucrSelectorIDVarietyLevel)
        Me.tbIDVarietyLevel.Controls.Add(Me.ucrReceiverIDVarietyLevel)
        Me.tbIDVarietyLevel.Controls.Add(Me.lblVariety2)
        Me.tbIDVarietyLevel.Controls.Add(Me.lblIDVariable)
        Me.tbIDVarietyLevel.Controls.Add(Me.ucrReceiverTraits2)
        Me.tbIDVarietyLevel.Controls.Add(Me.lblTraits)
        Me.tbIDVarietyLevel.Controls.Add(Me.ucrReceiverIDVarietyVar)
        Me.tbIDVarietyLevel.Location = New System.Drawing.Point(4, 22)
        Me.tbIDVarietyLevel.Margin = New System.Windows.Forms.Padding(2)
        Me.tbIDVarietyLevel.Name = "tbIDVarietyLevel"
        Me.tbIDVarietyLevel.Padding = New System.Windows.Forms.Padding(2)
        Me.tbIDVarietyLevel.Size = New System.Drawing.Size(565, 356)
        Me.tbIDVarietyLevel.TabIndex = 2
        Me.tbIDVarietyLevel.Text = "Plot Level"
        Me.tbIDVarietyLevel.UseVisualStyleBackColor = True
        '
        'tbIDVarietyTraitLevel
        '
        Me.tbIDVarietyTraitLevel.Controls.Add(Me.ucrSelectorIDVarTraitLevel)
        Me.tbIDVarietyTraitLevel.Controls.Add(Me.lblVariety3)
        Me.tbIDVarietyTraitLevel.Controls.Add(Me.lblIDVariable2)
        Me.tbIDVarietyTraitLevel.Controls.Add(Me.ucrReceiverTraitsVariety)
        Me.tbIDVarietyTraitLevel.Controls.Add(Me.ucrReceiverTraitID)
        Me.tbIDVarietyTraitLevel.Controls.Add(Me.lblTraits2)
        Me.tbIDVarietyTraitLevel.Controls.Add(Me.ucrReceiverTraits1)
        Me.tbIDVarietyTraitLevel.Location = New System.Drawing.Point(4, 22)
        Me.tbIDVarietyTraitLevel.Margin = New System.Windows.Forms.Padding(2)
        Me.tbIDVarietyTraitLevel.Name = "tbIDVarietyTraitLevel"
        Me.tbIDVarietyTraitLevel.Padding = New System.Windows.Forms.Padding(2)
        Me.tbIDVarietyTraitLevel.Size = New System.Drawing.Size(565, 356)
        Me.tbIDVarietyTraitLevel.TabIndex = 3
        Me.tbIDVarietyTraitLevel.Text = "Plot-Trait Level"
        Me.tbIDVarietyTraitLevel.UseVisualStyleBackColor = True
        '
        'lblReceiverCarryColumns
        '
        Me.lblReceiverCarryColumns.AutoSize = True
        Me.lblReceiverCarryColumns.Location = New System.Drawing.Point(394, 232)
        Me.lblReceiverCarryColumns.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReceiverCarryColumns.Name = "lblReceiverCarryColumns"
        Me.lblReceiverCarryColumns.Size = New System.Drawing.Size(74, 13)
        Me.lblReceiverCarryColumns.TabIndex = 21
        Me.lblReceiverCarryColumns.Text = "Carry Columns"
        '
        'ucrReceiverCarryColumns
        '
        Me.ucrReceiverCarryColumns.AutoSize = True
        Me.ucrReceiverCarryColumns.frmParent = Me
        Me.ucrReceiverCarryColumns.Location = New System.Drawing.Point(394, 247)
        Me.ucrReceiverCarryColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCarryColumns.Name = "ucrReceiverCarryColumns"
        Me.ucrReceiverCarryColumns.Selector = Nothing
        Me.ucrReceiverCarryColumns.Size = New System.Drawing.Size(157, 101)
        Me.ucrReceiverCarryColumns.strNcFilePath = ""
        Me.ucrReceiverCarryColumns.TabIndex = 22
        Me.ucrReceiverCarryColumns.ucrSelector = Nothing
        '
        'ucrChkCarryColumns
        '
        Me.ucrChkCarryColumns.AutoSize = True
        Me.ucrChkCarryColumns.Checked = False
        Me.ucrChkCarryColumns.Location = New System.Drawing.Point(12, 325)
        Me.ucrChkCarryColumns.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrChkCarryColumns.Name = "ucrChkCarryColumns"
        Me.ucrChkCarryColumns.Size = New System.Drawing.Size(149, 23)
        Me.ucrChkCarryColumns.TabIndex = 23
        '
        'sdgTransformations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 439)
        Me.Controls.Add(Me.tbOptions)
        Me.Controls.Add(Me.ucrBaseSdgTransformations)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "sdgTransformations"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transformations"
        Me.tbOptions.ResumeLayout(False)
        Me.tbIDLevel.ResumeLayout(False)
        Me.tbIDLevel.PerformLayout()
        Me.tbVarietyLevel.ResumeLayout(False)
        Me.tbVarietyLevel.PerformLayout()
        Me.tbIDVarietyLevel.ResumeLayout(False)
        Me.tbIDVarietyLevel.PerformLayout()
        Me.tbIDVarietyTraitLevel.ResumeLayout(False)
        Me.tbIDVarietyTraitLevel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrSelectorTricotIDLevel As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblTraits As Label
    Friend WithEvents ucrReceiverTraits1 As ucrReceiverSingle
    Friend WithEvents lblVariety As Label
    Friend WithEvents ucrReceiverVariety As ucrReceiverSingle
    Friend WithEvents lblIDVariable As Label
    Friend WithEvents ucrBaseSdgTransformations As ucrButtonsSubdialogue
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
    Friend WithEvents lblVariety3 As Label
    Friend WithEvents ucrSelectorIDVarTraitLevel As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectorIDVarietyLevel As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectorTricotVarietyLevel As ucrSelectorByDataFrameAddRemove
    Friend WithEvents tbOptions As TabControl
    Friend WithEvents tbIDLevel As TabPage
    Friend WithEvents tbVarietyLevel As TabPage
    Friend WithEvents tbIDVarietyLevel As TabPage
    Friend WithEvents tbIDVarietyTraitLevel As TabPage
    Public Property chkChooseTraitsSuffix As CheckBox
    Friend WithEvents ucrReceiverIDVariable As ucrReceiverSingle
    Friend WithEvents ucrChkTraits As ucrCheck
    Friend WithEvents lblReceiverSpecifyVarietyVariables As Label
    Friend WithEvents ucrReceiverVarietyVariables As ucrReceiverMultiple
    Friend WithEvents ucrChkSpecifyVariety As ucrCheck
    Friend WithEvents ucrChkSpecifyRankValues As ucrCheck
    Friend WithEvents lblReceiverRankValues As Label
    Friend WithEvents ucrInputRankValues As ucrInputTextBox
    Friend WithEvents lblTraitVariables As Label
    Friend WithEvents ucrReceiverTraitVariables As ucrReceiverMultiple
    Friend WithEvents ucrChkSpecifyTraitVariables As ucrCheck
    Friend WithEvents ucrChkCarryColumns As ucrCheck
    Friend WithEvents lblReceiverCarryColumns As Label
    Friend WithEvents ucrReceiverCarryColumns As ucrReceiverMultiple
End Class
