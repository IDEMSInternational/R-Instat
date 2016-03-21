<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgStartofRains
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
        Me.lblDataList = New System.Windows.Forms.Label()
        Me.lblEarliest = New System.Windows.Forms.Label()
        Me.nudNumberofRainDays = New System.Windows.Forms.NumericUpDown()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.lblNumberRainDays = New System.Windows.Forms.Label()
        Me.lblTotalRain = New System.Windows.Forms.Label()
        Me.nudTotalRain = New System.Windows.Forms.NumericUpDown()
        Me.chkDrySpell = New System.Windows.Forms.CheckBox()
        Me.nudWithin = New System.Windows.Forms.NumericUpDown()
        Me.lblWithin = New System.Windows.Forms.Label()
        Me.lblDryLength = New System.Windows.Forms.Label()
        Me.nudDryLength = New System.Windows.Forms.NumericUpDown()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblColumnName = New System.Windows.Forms.Label()
        Me.txtColumnName = New System.Windows.Forms.TextBox()
        Me.nudEarliest = New System.Windows.Forms.NumericUpDown()
        Me.nudThreashold = New System.Windows.Forms.NumericUpDown()
        Me.ucrBase = New instat.ucrButtons()
        CType(Me.nudNumberofRainDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTotalRain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWithin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDryLength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEarliest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudThreashold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDataList
        '
        Me.lblDataList.AutoSize = True
        Me.lblDataList.Location = New System.Drawing.Point(36, 35)
        Me.lblDataList.Name = "lblDataList"
        Me.lblDataList.Size = New System.Drawing.Size(106, 13)
        Me.lblDataList.TabIndex = 1
        Me.lblDataList.Tag = "Not_Yet_Implemented"
        Me.lblDataList.Text = "Not Yet Implemented"
        '
        'lblEarliest
        '
        Me.lblEarliest.AutoSize = True
        Me.lblEarliest.Location = New System.Drawing.Point(39, 75)
        Me.lblEarliest.Name = "lblEarliest"
        Me.lblEarliest.Size = New System.Drawing.Size(61, 13)
        Me.lblEarliest.TabIndex = 2
        Me.lblEarliest.Tag = "Earliest_day"
        Me.lblEarliest.Text = "Earliest day"
        '
        'nudNumberofRainDays
        '
        Me.nudNumberofRainDays.Location = New System.Drawing.Point(192, 110)
        Me.nudNumberofRainDays.Name = "nudNumberofRainDays"
        Me.nudNumberofRainDays.Size = New System.Drawing.Size(35, 20)
        Me.nudNumberofRainDays.TabIndex = 4
        Me.nudNumberofRainDays.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(39, 95)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(54, 13)
        Me.lblThreshold.TabIndex = 5
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Threshold"
        '
        'lblNumberRainDays
        '
        Me.lblNumberRainDays.AutoSize = True
        Me.lblNumberRainDays.Location = New System.Drawing.Point(39, 115)
        Me.lblNumberRainDays.Name = "lblNumberRainDays"
        Me.lblNumberRainDays.Size = New System.Drawing.Size(108, 13)
        Me.lblNumberRainDays.TabIndex = 7
        Me.lblNumberRainDays.Tag = "Number_of_Rain_Days"
        Me.lblNumberRainDays.Text = "Number of Rain Days"
        '
        'lblTotalRain
        '
        Me.lblTotalRain.AutoSize = True
        Me.lblTotalRain.Location = New System.Drawing.Point(39, 135)
        Me.lblTotalRain.Name = "lblTotalRain"
        Me.lblTotalRain.Size = New System.Drawing.Size(56, 13)
        Me.lblTotalRain.TabIndex = 8
        Me.lblTotalRain.Tag = "Total_Rain"
        Me.lblTotalRain.Text = "Total Rain"
        '
        'nudTotalRain
        '
        Me.nudTotalRain.Location = New System.Drawing.Point(192, 131)
        Me.nudTotalRain.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudTotalRain.Name = "nudTotalRain"
        Me.nudTotalRain.Size = New System.Drawing.Size(35, 20)
        Me.nudTotalRain.TabIndex = 9
        Me.nudTotalRain.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'chkDrySpell
        '
        Me.chkDrySpell.AutoSize = True
        Me.chkDrySpell.Location = New System.Drawing.Point(12, 163)
        Me.chkDrySpell.Name = "chkDrySpell"
        Me.chkDrySpell.Size = New System.Drawing.Size(68, 17)
        Me.chkDrySpell.TabIndex = 10
        Me.chkDrySpell.Tag = "Dry_Spell"
        Me.chkDrySpell.Text = "Dry Spell"
        Me.chkDrySpell.UseVisualStyleBackColor = True
        '
        'nudWithin
        '
        Me.nudWithin.Location = New System.Drawing.Point(288, 189)
        Me.nudWithin.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudWithin.Name = "nudWithin"
        Me.nudWithin.Size = New System.Drawing.Size(35, 20)
        Me.nudWithin.TabIndex = 14
        Me.nudWithin.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'lblWithin
        '
        Me.lblWithin.AutoSize = True
        Me.lblWithin.Location = New System.Drawing.Point(233, 193)
        Me.lblWithin.Name = "lblWithin"
        Me.lblWithin.Size = New System.Drawing.Size(37, 13)
        Me.lblWithin.TabIndex = 13
        Me.lblWithin.Tag = "Within"
        Me.lblWithin.Text = "Within"
        '
        'lblDryLength
        '
        Me.lblDryLength.AutoSize = True
        Me.lblDryLength.Location = New System.Drawing.Point(39, 193)
        Me.lblDryLength.Name = "lblDryLength"
        Me.lblDryLength.Size = New System.Drawing.Size(97, 13)
        Me.lblDryLength.TabIndex = 12
        Me.lblDryLength.Tag = "Length_of_Dry_Spell"
        Me.lblDryLength.Text = "Length of Dry Spell"
        '
        'nudDryLength
        '
        Me.nudDryLength.Location = New System.Drawing.Point(192, 189)
        Me.nudDryLength.Name = "nudDryLength"
        Me.nudDryLength.Size = New System.Drawing.Size(35, 20)
        Me.nudDryLength.TabIndex = 11
        Me.nudDryLength.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Location = New System.Drawing.Point(329, 193)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(31, 13)
        Me.lblDays.TabIndex = 15
        Me.lblDays.Tag = "Days"
        Me.lblDays.Text = "Days"
        '
        'lblColumnName
        '
        Me.lblColumnName.AutoSize = True
        Me.lblColumnName.Location = New System.Drawing.Point(39, 230)
        Me.lblColumnName.Name = "lblColumnName"
        Me.lblColumnName.Size = New System.Drawing.Size(73, 13)
        Me.lblColumnName.TabIndex = 16
        Me.lblColumnName.Tag = "Column_Name"
        Me.lblColumnName.Text = "Column Name"
        '
        'txtColumnName
        '
        Me.txtColumnName.Location = New System.Drawing.Point(192, 222)
        Me.txtColumnName.Name = "txtColumnName"
        Me.txtColumnName.Size = New System.Drawing.Size(100, 20)
        Me.txtColumnName.TabIndex = 17
        Me.txtColumnName.Tag = "Start_of_Rain"
        '
        'nudEarliest
        '
        Me.nudEarliest.Location = New System.Drawing.Point(192, 68)
        Me.nudEarliest.Maximum = New Decimal(New Integer() {366, 0, 0, 0})
        Me.nudEarliest.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudEarliest.Name = "nudEarliest"
        Me.nudEarliest.Size = New System.Drawing.Size(53, 20)
        Me.nudEarliest.TabIndex = 18
        Me.nudEarliest.Value = New Decimal(New Integer() {92, 0, 0, 0})
        '
        'nudThreashold
        '
        Me.nudThreashold.DecimalPlaces = 2
        Me.nudThreashold.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudThreashold.Location = New System.Drawing.Point(192, 89)
        Me.nudThreashold.Name = "nudThreashold"
        Me.nudThreashold.Size = New System.Drawing.Size(53, 20)
        Me.nudThreashold.TabIndex = 19
        Me.nudThreashold.Value = New Decimal(New Integer() {85, 0, 0, 131072})
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(14, 275)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(409, 52)
        Me.ucrBase.TabIndex = 0
        '
        'dlgStartofRains
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 328)
        Me.Controls.Add(Me.nudThreashold)
        Me.Controls.Add(Me.nudEarliest)
        Me.Controls.Add(Me.txtColumnName)
        Me.Controls.Add(Me.lblColumnName)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.nudWithin)
        Me.Controls.Add(Me.lblWithin)
        Me.Controls.Add(Me.lblDryLength)
        Me.Controls.Add(Me.nudDryLength)
        Me.Controls.Add(Me.chkDrySpell)
        Me.Controls.Add(Me.nudTotalRain)
        Me.Controls.Add(Me.lblTotalRain)
        Me.Controls.Add(Me.lblNumberRainDays)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.nudNumberofRainDays)
        Me.Controls.Add(Me.lblEarliest)
        Me.Controls.Add(Me.lblDataList)
        Me.Controls.Add(Me.ucrBase)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgStartofRains"
        Me.ShowIcon = False
        Me.Text = "Start of Rains"
        CType(Me.nudNumberofRainDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTotalRain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWithin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDryLength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEarliest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudThreashold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblDataList As Label
    Friend WithEvents lblEarliest As Label
    Friend WithEvents nudNumberofRainDays As NumericUpDown
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lblNumberRainDays As Label
    Friend WithEvents lblTotalRain As Label
    Friend WithEvents nudTotalRain As NumericUpDown
    Friend WithEvents chkDrySpell As CheckBox
    Friend WithEvents nudWithin As NumericUpDown
    Friend WithEvents lblWithin As Label
    Friend WithEvents lblDryLength As Label
    Friend WithEvents nudDryLength As NumericUpDown
    Friend WithEvents lblDays As Label
    Friend WithEvents lblColumnName As Label
    Friend WithEvents txtColumnName As TextBox
    Friend WithEvents nudEarliest As NumericUpDown
    Friend WithEvents nudThreashold As NumericUpDown
End Class
