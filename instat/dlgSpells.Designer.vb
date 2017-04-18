<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgSpells
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
        Me.lblRainfall = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDOY = New System.Windows.Forms.Label()
        Me.ucrReceiverDayOfYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverRainfall = New instat.ucrReceiverSingle()
        Me.ucrSelectorForSpells = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.chkConditionRain = New System.Windows.Forms.CheckBox()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.nudTo = New System.Windows.Forms.NumericUpDown()
        Me.nudFrom = New System.Windows.Forms.NumericUpDown()
        Me.nudConditionLeft = New System.Windows.Forms.NumericUpDown()
        Me.NudConditionRight = New System.Windows.Forms.NumericUpDown()
        Me.ucrInputCondition = New instat.ucrInputComboBox()
        Me.grpRainParameters = New System.Windows.Forms.GroupBox()
        Me.ucrSaveSpells = New instat.ucrSave()
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudConditionLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudConditionRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRainParameters.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRainfall
        '
        Me.lblRainfall.AutoSize = True
        Me.lblRainfall.Location = New System.Drawing.Point(246, 70)
        Me.lblRainfall.Name = "lblRainfall"
        Me.lblRainfall.Size = New System.Drawing.Size(70, 13)
        Me.lblRainfall.TabIndex = 3
        Me.lblRainfall.Text = "Rain Column:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(247, 28)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(248, 113)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 5
        Me.lblYear.Text = "Year:"
        '
        'lblDOY
        '
        Me.lblDOY.AutoSize = True
        Me.lblDOY.Location = New System.Drawing.Point(247, 154)
        Me.lblDOY.Name = "lblDOY"
        Me.lblDOY.Size = New System.Drawing.Size(66, 13)
        Me.lblDOY.TabIndex = 7
        Me.lblDOY.Text = "Day of Year:"
        '
        'ucrReceiverDayOfYear
        '
        Me.ucrReceiverDayOfYear.frmParent = Me
        Me.ucrReceiverDayOfYear.Location = New System.Drawing.Point(246, 169)
        Me.ucrReceiverDayOfYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDayOfYear.Name = "ucrReceiverDayOfYear"
        Me.ucrReceiverDayOfYear.Selector = Nothing
        Me.ucrReceiverDayOfYear.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDayOfYear.TabIndex = 12
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(246, 127)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverYear.TabIndex = 6
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(246, 43)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDate.TabIndex = 2
        '
        'ucrReceiverRainfall
        '
        Me.ucrReceiverRainfall.frmParent = Me
        Me.ucrReceiverRainfall.Location = New System.Drawing.Point(246, 85)
        Me.ucrReceiverRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainfall.Name = "ucrReceiverRainfall"
        Me.ucrReceiverRainfall.Selector = Nothing
        Me.ucrReceiverRainfall.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverRainfall.TabIndex = 4
        '
        'ucrSelectorForSpells
        '
        Me.ucrSelectorForSpells.bShowHiddenColumns = False
        Me.ucrSelectorForSpells.bUseCurrentFilter = True
        Me.ucrSelectorForSpells.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorForSpells.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForSpells.Name = "ucrSelectorForSpells"
        Me.ucrSelectorForSpells.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForSpells.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 318)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 11
        '
        'chkConditionRain
        '
        Me.chkConditionRain.AutoSize = True
        Me.chkConditionRain.Location = New System.Drawing.Point(9, 272)
        Me.chkConditionRain.Name = "chkConditionRain"
        Me.chkConditionRain.Size = New System.Drawing.Size(193, 17)
        Me.chkConditionRain.TabIndex = 13
        Me.chkConditionRain.Text = "Conditional on Rain at Start of Spell"
        Me.chkConditionRain.UseVisualStyleBackColor = True
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(186, 16)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(45, 13)
        Me.lblTo.TabIndex = 4
        Me.lblTo.Tag = ""
        Me.lblTo.Text = "To Day:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(6, 16)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(55, 13)
        Me.lblFrom.TabIndex = 2
        Me.lblFrom.Text = "From Day:"
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(6, 47)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(54, 13)
        Me.lblThreshold.TabIndex = 0
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Condition:"
        '
        'nudTo
        '
        Me.nudTo.Location = New System.Drawing.Point(237, 14)
        Me.nudTo.Maximum = New Decimal(New Integer() {366, 0, 0, 0})
        Me.nudTo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudTo.Name = "nudTo"
        Me.nudTo.Size = New System.Drawing.Size(53, 20)
        Me.nudTo.TabIndex = 8
        Me.nudTo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudFrom
        '
        Me.nudFrom.Location = New System.Drawing.Point(67, 14)
        Me.nudFrom.Maximum = New Decimal(New Integer() {366, 0, 0, 0})
        Me.nudFrom.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudFrom.Name = "nudFrom"
        Me.nudFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.nudFrom.Size = New System.Drawing.Size(53, 20)
        Me.nudFrom.TabIndex = 7
        Me.nudFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudFrom.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.nudFrom.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudConditionLeft
        '
        Me.nudConditionLeft.DecimalPlaces = 2
        Me.nudConditionLeft.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudConditionLeft.Location = New System.Drawing.Point(67, 45)
        Me.nudConditionLeft.Name = "nudConditionLeft"
        Me.nudConditionLeft.Size = New System.Drawing.Size(53, 20)
        Me.nudConditionLeft.TabIndex = 6
        '
        'NudConditionRight
        '
        Me.NudConditionRight.DecimalPlaces = 2
        Me.NudConditionRight.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NudConditionRight.Location = New System.Drawing.Point(237, 45)
        Me.NudConditionRight.Name = "NudConditionRight"
        Me.NudConditionRight.Size = New System.Drawing.Size(53, 20)
        Me.NudConditionRight.TabIndex = 9
        Me.NudConditionRight.Value = New Decimal(New Integer() {85, 0, 0, 131072})
        '
        'ucrInputCondition
        '
        Me.ucrInputCondition.AddQuotesIfUnrecognised = True
        Me.ucrInputCondition.IsReadOnly = False
        Me.ucrInputCondition.Location = New System.Drawing.Point(131, 44)
        Me.ucrInputCondition.Name = "ucrInputCondition"
        Me.ucrInputCondition.Size = New System.Drawing.Size(97, 21)
        Me.ucrInputCondition.TabIndex = 10
        '
        'grpRainParameters
        '
        Me.grpRainParameters.Controls.Add(Me.ucrInputCondition)
        Me.grpRainParameters.Controls.Add(Me.NudConditionRight)
        Me.grpRainParameters.Controls.Add(Me.nudConditionLeft)
        Me.grpRainParameters.Controls.Add(Me.nudFrom)
        Me.grpRainParameters.Controls.Add(Me.nudTo)
        Me.grpRainParameters.Controls.Add(Me.lblThreshold)
        Me.grpRainParameters.Controls.Add(Me.lblFrom)
        Me.grpRainParameters.Controls.Add(Me.lblTo)
        Me.grpRainParameters.Location = New System.Drawing.Point(9, 192)
        Me.grpRainParameters.Name = "grpRainParameters"
        Me.grpRainParameters.Size = New System.Drawing.Size(380, 74)
        Me.grpRainParameters.TabIndex = 9
        Me.grpRainParameters.TabStop = False
        '
        'ucrSaveSpells
        '
        Me.ucrSaveSpells.Location = New System.Drawing.Point(9, 295)
        Me.ucrSaveSpells.Name = "ucrSaveSpells"
        Me.ucrSaveSpells.Size = New System.Drawing.Size(290, 24)
        Me.ucrSaveSpells.TabIndex = 14
        '
        'dlgSpells
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 375)
        Me.Controls.Add(Me.ucrSaveSpells)
        Me.Controls.Add(Me.chkConditionRain)
        Me.Controls.Add(Me.ucrReceiverDayOfYear)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.lblDOY)
        Me.Controls.Add(Me.grpRainParameters)
        Me.Controls.Add(Me.lblRainfall)
        Me.Controls.Add(Me.ucrReceiverRainfall)
        Me.Controls.Add(Me.ucrSelectorForSpells)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSpells"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spells"
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudConditionLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudConditionRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRainParameters.ResumeLayout(False)
        Me.grpRainParameters.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForSpells As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverRainfall As ucrReceiverSingle
    Friend WithEvents lblRainfall As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDOY As Label
    Friend WithEvents ucrReceiverDayOfYear As ucrReceiverSingle
    Friend WithEvents chkConditionRain As CheckBox
    Friend WithEvents grpRainParameters As GroupBox
    Friend WithEvents ucrInputCondition As ucrInputComboBox
    Friend WithEvents NudConditionRight As NumericUpDown
    Friend WithEvents nudConditionLeft As NumericUpDown
    Friend WithEvents nudFrom As NumericUpDown
    Friend WithEvents nudTo As NumericUpDown
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents ucrSaveSpells As ucrSave
End Class
