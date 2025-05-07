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
        Me.ucrReceiverIDVariable = New instat.ucrReceiverSingle()
        Me.ucrSelectorTricotIDLevel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.tbOptions = New System.Windows.Forms.TabControl()
        Me.tbIDLevel = New System.Windows.Forms.TabPage()
        Me.tbVarietyLevel = New System.Windows.Forms.TabPage()
        Me.tbIDVarietyLevel = New System.Windows.Forms.TabPage()
        Me.tbIDVarietyTraitLevel = New System.Windows.Forms.TabPage()
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
        Me.lblIDVariable.Location = New System.Drawing.Point(357, 59)
        Me.lblIDVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDVariable.Name = "lblIDVariable"
        Me.lblIDVariable.Size = New System.Drawing.Size(92, 20)
        Me.lblIDVariable.TabIndex = 1
        Me.lblIDVariable.Text = "ID Variable:"
        '
        'lblVariety
        '
        Me.lblVariety.AutoSize = True
        Me.lblVariety.Location = New System.Drawing.Point(357, 59)
        Me.lblVariety.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVariety.Name = "lblVariety"
        Me.lblVariety.Size = New System.Drawing.Size(62, 20)
        Me.lblVariety.TabIndex = 1
        Me.lblVariety.Text = "Variety:"
        '
        'lblTraits
        '
        Me.lblTraits.AutoSize = True
        Me.lblTraits.Location = New System.Drawing.Point(355, 206)
        Me.lblTraits.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTraits.Name = "lblTraits"
        Me.lblTraits.Size = New System.Drawing.Size(52, 20)
        Me.lblTraits.TabIndex = 5
        Me.lblTraits.Text = "Traits:"
        '
        'lblTraits2
        '
        Me.lblTraits2.AutoSize = True
        Me.lblTraits2.Location = New System.Drawing.Point(355, 206)
        Me.lblTraits2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTraits2.Name = "lblTraits2"
        Me.lblTraits2.Size = New System.Drawing.Size(52, 20)
        Me.lblTraits2.TabIndex = 5
        Me.lblTraits2.Text = "Traits:"
        '
        'lblGoodTraits
        '
        Me.lblGoodTraits.AutoSize = True
        Me.lblGoodTraits.Location = New System.Drawing.Point(357, 137)
        Me.lblGoodTraits.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGoodTraits.Name = "lblGoodTraits"
        Me.lblGoodTraits.Size = New System.Drawing.Size(140, 20)
        Me.lblGoodTraits.TabIndex = 4
        Me.lblGoodTraits.Text = "Good Traits Suffix:"
        '
        'lblBadTraits
        '
        Me.lblBadTraits.AutoSize = True
        Me.lblBadTraits.Location = New System.Drawing.Point(355, 206)
        Me.lblBadTraits.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBadTraits.Name = "lblBadTraits"
        Me.lblBadTraits.Size = New System.Drawing.Size(129, 20)
        Me.lblBadTraits.TabIndex = 6
        Me.lblBadTraits.Text = "Bad Traits Suffix:"
        '
        'lblNAs
        '
        Me.lblNAs.AutoSize = True
        Me.lblNAs.Location = New System.Drawing.Point(357, 273)
        Me.lblNAs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNAs.Name = "lblNAs"
        Me.lblNAs.Size = New System.Drawing.Size(118, 20)
        Me.lblNAs.TabIndex = 8
        Me.lblNAs.Text = "NA denoted by:"
        '
        'lblVariety2
        '
        Me.lblVariety2.AutoSize = True
        Me.lblVariety2.Location = New System.Drawing.Point(357, 137)
        Me.lblVariety2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVariety2.Name = "lblVariety2"
        Me.lblVariety2.Size = New System.Drawing.Size(62, 20)
        Me.lblVariety2.TabIndex = 3
        Me.lblVariety2.Text = "Variety:"
        '
        'lblIDVariable2
        '
        Me.lblIDVariable2.AutoSize = True
        Me.lblIDVariable2.Location = New System.Drawing.Point(357, 59)
        Me.lblIDVariable2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDVariable2.Name = "lblIDVariable2"
        Me.lblIDVariable2.Size = New System.Drawing.Size(92, 20)
        Me.lblIDVariable2.TabIndex = 1
        Me.lblIDVariable2.Text = "ID Variable:"
        '
        'lblIDVariable3
        '
        Me.lblIDVariable3.AutoSize = True
        Me.lblIDVariable3.Location = New System.Drawing.Point(357, 59)
        Me.lblIDVariable3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDVariable3.Name = "lblIDVariable3"
        Me.lblIDVariable3.Size = New System.Drawing.Size(92, 20)
        Me.lblIDVariable3.TabIndex = 2
        Me.lblIDVariable3.Text = "ID Variable:"
        '
        'lblVariety3
        '
        Me.lblVariety3.AutoSize = True
        Me.lblVariety3.Location = New System.Drawing.Point(357, 137)
        Me.lblVariety3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVariety3.Name = "lblVariety3"
        Me.lblVariety3.Size = New System.Drawing.Size(62, 20)
        Me.lblVariety3.TabIndex = 3
        Me.lblVariety3.Text = "Variety:"
        '
        'ucrSelectorIDVarTraitLevel
        '
        Me.ucrSelectorIDVarTraitLevel.AutoSize = True
        Me.ucrSelectorIDVarTraitLevel.bDropUnusedFilterLevels = False
        Me.ucrSelectorIDVarTraitLevel.bShowHiddenColumns = False
        Me.ucrSelectorIDVarTraitLevel.bUseCurrentFilter = True
        Me.ucrSelectorIDVarTraitLevel.Location = New System.Drawing.Point(18, 19)
        Me.ucrSelectorIDVarTraitLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorIDVarTraitLevel.Name = "ucrSelectorIDVarTraitLevel"
        Me.ucrSelectorIDVarTraitLevel.Size = New System.Drawing.Size(320, 282)
        Me.ucrSelectorIDVarTraitLevel.TabIndex = 0
        '
        'ucrSelectorIDVarietyLevel
        '
        Me.ucrSelectorIDVarietyLevel.AutoSize = True
        Me.ucrSelectorIDVarietyLevel.bDropUnusedFilterLevels = False
        Me.ucrSelectorIDVarietyLevel.bShowHiddenColumns = False
        Me.ucrSelectorIDVarietyLevel.bUseCurrentFilter = True
        Me.ucrSelectorIDVarietyLevel.Location = New System.Drawing.Point(18, 19)
        Me.ucrSelectorIDVarietyLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorIDVarietyLevel.Name = "ucrSelectorIDVarietyLevel"
        Me.ucrSelectorIDVarietyLevel.Size = New System.Drawing.Size(320, 282)
        Me.ucrSelectorIDVarietyLevel.TabIndex = 0
        '
        'ucrSelectorTricotVarietyLevel
        '
        Me.ucrSelectorTricotVarietyLevel.AutoSize = True
        Me.ucrSelectorTricotVarietyLevel.bDropUnusedFilterLevels = False
        Me.ucrSelectorTricotVarietyLevel.bShowHiddenColumns = False
        Me.ucrSelectorTricotVarietyLevel.bUseCurrentFilter = True
        Me.ucrSelectorTricotVarietyLevel.Location = New System.Drawing.Point(18, 19)
        Me.ucrSelectorTricotVarietyLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTricotVarietyLevel.Name = "ucrSelectorTricotVarietyLevel"
        Me.ucrSelectorTricotVarietyLevel.Size = New System.Drawing.Size(320, 282)
        Me.ucrSelectorTricotVarietyLevel.TabIndex = 0
        '
        'ucrReceiverTraitsVariety
        '
        Me.ucrReceiverTraitsVariety.AutoSize = True
        Me.ucrReceiverTraitsVariety.frmParent = Nothing
        Me.ucrReceiverTraitsVariety.Location = New System.Drawing.Point(357, 160)
        Me.ucrReceiverTraitsVariety.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTraitsVariety.Name = "ucrReceiverTraitsVariety"
        Me.ucrReceiverTraitsVariety.Selector = Nothing
        Me.ucrReceiverTraitsVariety.Size = New System.Drawing.Size(170, 31)
        Me.ucrReceiverTraitsVariety.strNcFilePath = ""
        Me.ucrReceiverTraitsVariety.TabIndex = 4
        Me.ucrReceiverTraitsVariety.ucrSelector = Nothing
        '
        'ucrReceiverTraitID
        '
        Me.ucrReceiverTraitID.AutoSize = True
        Me.ucrReceiverTraitID.frmParent = Nothing
        Me.ucrReceiverTraitID.Location = New System.Drawing.Point(359, 81)
        Me.ucrReceiverTraitID.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTraitID.Name = "ucrReceiverTraitID"
        Me.ucrReceiverTraitID.Selector = Nothing
        Me.ucrReceiverTraitID.Size = New System.Drawing.Size(170, 31)
        Me.ucrReceiverTraitID.strNcFilePath = ""
        Me.ucrReceiverTraitID.TabIndex = 2
        Me.ucrReceiverTraitID.ucrSelector = Nothing
        '
        'ucrReceiverIDVarietyLevel
        '
        Me.ucrReceiverIDVarietyLevel.AutoSize = True
        Me.ucrReceiverIDVarietyLevel.frmParent = Nothing
        Me.ucrReceiverIDVarietyLevel.Location = New System.Drawing.Point(359, 81)
        Me.ucrReceiverIDVarietyLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverIDVarietyLevel.Name = "ucrReceiverIDVarietyLevel"
        Me.ucrReceiverIDVarietyLevel.Selector = Nothing
        Me.ucrReceiverIDVarietyLevel.Size = New System.Drawing.Size(170, 31)
        Me.ucrReceiverIDVarietyLevel.strNcFilePath = ""
        Me.ucrReceiverIDVarietyLevel.TabIndex = 2
        Me.ucrReceiverIDVarietyLevel.ucrSelector = Nothing
        '
        'ucrReceiverIDVarietyVar
        '
        Me.ucrReceiverIDVarietyVar.AutoSize = True
        Me.ucrReceiverIDVarietyVar.frmParent = Nothing
        Me.ucrReceiverIDVarietyVar.Location = New System.Drawing.Point(357, 160)
        Me.ucrReceiverIDVarietyVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverIDVarietyVar.Name = "ucrReceiverIDVarietyVar"
        Me.ucrReceiverIDVarietyVar.Selector = Nothing
        Me.ucrReceiverIDVarietyVar.Size = New System.Drawing.Size(170, 31)
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
        Me.ucrInputGoodTraits.Location = New System.Drawing.Point(357, 160)
        Me.ucrInputGoodTraits.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputGoodTraits.Name = "ucrInputGoodTraits"
        Me.ucrInputGoodTraits.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputGoodTraits.TabIndex = 5
        '
        'ucrInputNAS
        '
        Me.ucrInputNAS.AddQuotesIfUnrecognised = True
        Me.ucrInputNAS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputNAS.GetSetSelectedIndex = -1
        Me.ucrInputNAS.IsReadOnly = False
        Me.ucrInputNAS.Location = New System.Drawing.Point(357, 297)
        Me.ucrInputNAS.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputNAS.Name = "ucrInputNAS"
        Me.ucrInputNAS.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputNAS.TabIndex = 0
        '
        'ucrInputBadTraits
        '
        Me.ucrInputBadTraits.AddQuotesIfUnrecognised = True
        Me.ucrInputBadTraits.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputBadTraits.GetSetSelectedIndex = -1
        Me.ucrInputBadTraits.IsReadOnly = False
        Me.ucrInputBadTraits.Location = New System.Drawing.Point(357, 230)
        Me.ucrInputBadTraits.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputBadTraits.Name = "ucrInputBadTraits"
        Me.ucrInputBadTraits.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputBadTraits.TabIndex = 7
        '
        'ucrReceiverTraits2
        '
        Me.ucrReceiverTraits2.AutoSize = True
        Me.ucrReceiverTraits2.frmParent = Nothing
        Me.ucrReceiverTraits2.Location = New System.Drawing.Point(357, 230)
        Me.ucrReceiverTraits2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTraits2.Name = "ucrReceiverTraits2"
        Me.ucrReceiverTraits2.Selector = Nothing
        Me.ucrReceiverTraits2.Size = New System.Drawing.Size(206, 126)
        Me.ucrReceiverTraits2.strNcFilePath = ""
        Me.ucrReceiverTraits2.TabIndex = 6
        Me.ucrReceiverTraits2.ucrSelector = Nothing
        '
        'ucrBaseSdgTransformations
        '
        Me.ucrBaseSdgTransformations.AutoSize = True
        Me.ucrBaseSdgTransformations.Location = New System.Drawing.Point(129, 456)
        Me.ucrBaseSdgTransformations.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBaseSdgTransformations.Name = "ucrBaseSdgTransformations"
        Me.ucrBaseSdgTransformations.Size = New System.Drawing.Size(336, 46)
        Me.ucrBaseSdgTransformations.TabIndex = 1
        '
        'ucrReceiverTraits1
        '
        Me.ucrReceiverTraits1.AutoSize = True
        Me.ucrReceiverTraits1.frmParent = Nothing
        Me.ucrReceiverTraits1.Location = New System.Drawing.Point(357, 230)
        Me.ucrReceiverTraits1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTraits1.Name = "ucrReceiverTraits1"
        Me.ucrReceiverTraits1.Selector = Nothing
        Me.ucrReceiverTraits1.Size = New System.Drawing.Size(170, 31)
        Me.ucrReceiverTraits1.strNcFilePath = ""
        Me.ucrReceiverTraits1.TabIndex = 6
        Me.ucrReceiverTraits1.ucrSelector = Nothing
        '
        'ucrReceiverVariety
        '
        Me.ucrReceiverVariety.AutoSize = True
        Me.ucrReceiverVariety.frmParent = Nothing
        Me.ucrReceiverVariety.Location = New System.Drawing.Point(359, 81)
        Me.ucrReceiverVariety.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVariety.Name = "ucrReceiverVariety"
        Me.ucrReceiverVariety.Selector = Nothing
        Me.ucrReceiverVariety.Size = New System.Drawing.Size(170, 31)
        Me.ucrReceiverVariety.strNcFilePath = ""
        Me.ucrReceiverVariety.TabIndex = 2
        Me.ucrReceiverVariety.ucrSelector = Nothing
        '
        'ucrReceiverIDVariable
        '
        Me.ucrReceiverIDVariable.AutoSize = True
        Me.ucrReceiverIDVariable.frmParent = Nothing
        Me.ucrReceiverIDVariable.Location = New System.Drawing.Point(359, 81)
        Me.ucrReceiverIDVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverIDVariable.Name = "ucrReceiverIDVariable"
        Me.ucrReceiverIDVariable.Selector = Nothing
        Me.ucrReceiverIDVariable.Size = New System.Drawing.Size(170, 31)
        Me.ucrReceiverIDVariable.strNcFilePath = ""
        Me.ucrReceiverIDVariable.TabIndex = 3
        Me.ucrReceiverIDVariable.ucrSelector = Nothing
        '
        'ucrSelectorTricotIDLevel
        '
        Me.ucrSelectorTricotIDLevel.AutoSize = True
        Me.ucrSelectorTricotIDLevel.bDropUnusedFilterLevels = False
        Me.ucrSelectorTricotIDLevel.bShowHiddenColumns = False
        Me.ucrSelectorTricotIDLevel.bUseCurrentFilter = True
        Me.ucrSelectorTricotIDLevel.Location = New System.Drawing.Point(18, 19)
        Me.ucrSelectorTricotIDLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTricotIDLevel.Name = "ucrSelectorTricotIDLevel"
        Me.ucrSelectorTricotIDLevel.Size = New System.Drawing.Size(320, 282)
        Me.ucrSelectorTricotIDLevel.TabIndex = 0
        '
        'tbOptions
        '
        Me.tbOptions.Controls.Add(Me.tbIDLevel)
        Me.tbOptions.Controls.Add(Me.tbVarietyLevel)
        Me.tbOptions.Controls.Add(Me.tbIDVarietyLevel)
        Me.tbOptions.Controls.Add(Me.tbIDVarietyTraitLevel)
        Me.tbOptions.Location = New System.Drawing.Point(12, 12)
        Me.tbOptions.Name = "tbOptions"
        Me.tbOptions.SelectedIndex = 0
        Me.tbOptions.Size = New System.Drawing.Size(593, 435)
        Me.tbOptions.TabIndex = 0
        '
        'tbIDLevel
        '
        Me.tbIDLevel.Controls.Add(Me.ucrInputBadTraits)
        Me.tbIDLevel.Controls.Add(Me.ucrInputNAS)
        Me.tbIDLevel.Controls.Add(Me.lblBadTraits)
        Me.tbIDLevel.Controls.Add(Me.lblNAs)
        Me.tbIDLevel.Controls.Add(Me.lblIDVariable3)
        Me.tbIDLevel.Controls.Add(Me.ucrInputGoodTraits)
        Me.tbIDLevel.Controls.Add(Me.lblGoodTraits)
        Me.tbIDLevel.Controls.Add(Me.ucrSelectorTricotIDLevel)
        Me.tbIDLevel.Controls.Add(Me.ucrReceiverIDVariable)
        Me.tbIDLevel.Location = New System.Drawing.Point(4, 29)
        Me.tbIDLevel.Name = "tbIDLevel"
        Me.tbIDLevel.Padding = New System.Windows.Forms.Padding(3)
        Me.tbIDLevel.Size = New System.Drawing.Size(585, 402)
        Me.tbIDLevel.TabIndex = 0
        Me.tbIDLevel.Text = "ID Level"
        Me.tbIDLevel.UseVisualStyleBackColor = True
        '
        'tbVarietyLevel
        '
        Me.tbVarietyLevel.Controls.Add(Me.ucrSelectorTricotVarietyLevel)
        Me.tbVarietyLevel.Controls.Add(Me.ucrReceiverVariety)
        Me.tbVarietyLevel.Controls.Add(Me.lblVariety)
        Me.tbVarietyLevel.Location = New System.Drawing.Point(4, 29)
        Me.tbVarietyLevel.Name = "tbVarietyLevel"
        Me.tbVarietyLevel.Padding = New System.Windows.Forms.Padding(3)
        Me.tbVarietyLevel.Size = New System.Drawing.Size(585, 402)
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
        Me.tbIDVarietyLevel.Location = New System.Drawing.Point(4, 29)
        Me.tbIDVarietyLevel.Name = "tbIDVarietyLevel"
        Me.tbIDVarietyLevel.Padding = New System.Windows.Forms.Padding(3)
        Me.tbIDVarietyLevel.Size = New System.Drawing.Size(585, 402)
        Me.tbIDVarietyLevel.TabIndex = 2
        Me.tbIDVarietyLevel.Text = "ID-Variety Level"
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
        Me.tbIDVarietyTraitLevel.Location = New System.Drawing.Point(4, 29)
        Me.tbIDVarietyTraitLevel.Name = "tbIDVarietyTraitLevel"
        Me.tbIDVarietyTraitLevel.Padding = New System.Windows.Forms.Padding(3)
        Me.tbIDVarietyTraitLevel.Size = New System.Drawing.Size(585, 402)
        Me.tbIDVarietyTraitLevel.TabIndex = 3
        Me.tbIDVarietyTraitLevel.Text = "ID-Variety-Trait Level"
        Me.tbIDVarietyTraitLevel.UseVisualStyleBackColor = True
        '
        'sdgTransformations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 517)
        Me.Controls.Add(Me.tbOptions)
        Me.Controls.Add(Me.ucrBaseSdgTransformations)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
    Friend WithEvents ucrReceiverIDVariable As ucrReceiverSingle
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
End Class
