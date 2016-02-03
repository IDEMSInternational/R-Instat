<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgExtremeEvents
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
        Me.txtColumNameExtremeEvent = New System.Windows.Forms.TextBox()
        Me.txtColumnNameEventDay = New System.Windows.Forms.TextBox()
        Me.lblColumnNameExtremeEvent = New System.Windows.Forms.Label()
        Me.lblColumNameEventDay = New System.Windows.Forms.Label()
        Me.chkRemoveNA = New System.Windows.Forms.CheckBox()
        Me.chkExtremeMax = New System.Windows.Forms.CheckBox()
        Me.chkExtremeMin = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.nudTotalDays = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown7 = New System.Windows.Forms.NumericUpDown()
        Me.nudThreshold = New System.Windows.Forms.NumericUpDown()
        Me.nudEndDay = New System.Windows.Forms.NumericUpDown()
        Me.nudStartDay = New System.Windows.Forms.NumericUpDown()
        Me.lblStartDay = New System.Windows.Forms.Label()
        Me.lblTotalDays = New System.Windows.Forms.Label()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.lblEndDay = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkThresholdValue = New System.Windows.Forms.CheckBox()
        Me.ucrBase = New instat.ucrButtons()
        CType(Me.nudTotalDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEndDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStartDay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtColumNameExtremeEvent
        '
        Me.txtColumNameExtremeEvent.Location = New System.Drawing.Point(83, 56)
        Me.txtColumNameExtremeEvent.Name = "txtColumNameExtremeEvent"
        Me.txtColumNameExtremeEvent.Size = New System.Drawing.Size(267, 20)
        Me.txtColumNameExtremeEvent.TabIndex = 0
        Me.txtColumNameExtremeEvent.Tag = "Column_Name_Extreme_Event"
        '
        'txtColumnNameEventDay
        '
        Me.txtColumnNameEventDay.Location = New System.Drawing.Point(83, 102)
        Me.txtColumnNameEventDay.Name = "txtColumnNameEventDay"
        Me.txtColumnNameEventDay.Size = New System.Drawing.Size(267, 20)
        Me.txtColumnNameEventDay.TabIndex = 1
        Me.txtColumnNameEventDay.Tag = "Column_Name_Event_Day"
        '
        'lblColumnNameExtremeEvent
        '
        Me.lblColumnNameExtremeEvent.AutoSize = True
        Me.lblColumnNameExtremeEvent.Location = New System.Drawing.Point(26, 59)
        Me.lblColumnNameExtremeEvent.Name = "lblColumnNameExtremeEvent"
        Me.lblColumnNameExtremeEvent.Size = New System.Drawing.Size(39, 13)
        Me.lblColumnNameExtremeEvent.TabIndex = 2
        Me.lblColumnNameExtremeEvent.Tag = "Column_Name_Extreme_Event"
        Me.lblColumnNameExtremeEvent.Text = "Label1"
        '
        'lblColumNameEventDay
        '
        Me.lblColumNameEventDay.AutoSize = True
        Me.lblColumNameEventDay.Location = New System.Drawing.Point(26, 109)
        Me.lblColumNameEventDay.Name = "lblColumNameEventDay"
        Me.lblColumNameEventDay.Size = New System.Drawing.Size(39, 13)
        Me.lblColumNameEventDay.TabIndex = 3
        Me.lblColumNameEventDay.Tag = "Column_Name_Event_Day"
        Me.lblColumNameEventDay.Text = "Label2"
        '
        'chkRemoveNA
        '
        Me.chkRemoveNA.AutoSize = True
        Me.chkRemoveNA.Location = New System.Drawing.Point(232, 254)
        Me.chkRemoveNA.Name = "chkRemoveNA"
        Me.chkRemoveNA.Size = New System.Drawing.Size(81, 17)
        Me.chkRemoveNA.TabIndex = 10
        Me.chkRemoveNA.Tag = "Remove_NA"
        Me.chkRemoveNA.Text = "CheckBox1"
        Me.chkRemoveNA.UseVisualStyleBackColor = True
        '
        'chkExtremeMax
        '
        Me.chkExtremeMax.AutoSize = True
        Me.chkExtremeMax.Location = New System.Drawing.Point(83, 200)
        Me.chkExtremeMax.Name = "chkExtremeMax"
        Me.chkExtremeMax.Size = New System.Drawing.Size(81, 17)
        Me.chkExtremeMax.TabIndex = 11
        Me.chkExtremeMax.Tag = "Extreme_Maximum"
        Me.chkExtremeMax.Text = "CheckBox2"
        Me.chkExtremeMax.UseVisualStyleBackColor = True
        '
        'chkExtremeMin
        '
        Me.chkExtremeMin.AutoSize = True
        Me.chkExtremeMin.Location = New System.Drawing.Point(232, 200)
        Me.chkExtremeMin.Name = "chkExtremeMin"
        Me.chkExtremeMin.Size = New System.Drawing.Size(81, 17)
        Me.chkExtremeMin.TabIndex = 12
        Me.chkExtremeMin.Tag = "Extreme_Minimum"
        Me.chkExtremeMin.Text = "CheckBox3"
        Me.chkExtremeMin.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(390, 200)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox4.TabIndex = 13
        Me.CheckBox4.Text = "CheckBox4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'nudTotalDays
        '
        Me.nudTotalDays.Location = New System.Drawing.Point(390, 145)
        Me.nudTotalDays.Name = "nudTotalDays"
        Me.nudTotalDays.Size = New System.Drawing.Size(55, 20)
        Me.nudTotalDays.TabIndex = 5
        Me.nudTotalDays.Tag = "Total_Days"
        '
        'NumericUpDown7
        '
        Me.NumericUpDown7.Location = New System.Drawing.Point(83, 253)
        Me.NumericUpDown7.Name = "NumericUpDown7"
        Me.NumericUpDown7.Size = New System.Drawing.Size(55, 20)
        Me.NumericUpDown7.TabIndex = 6
        '
        'nudThreshold
        '
        Me.nudThreshold.Location = New System.Drawing.Point(236, 309)
        Me.nudThreshold.Name = "nudThreshold"
        Me.nudThreshold.Size = New System.Drawing.Size(55, 20)
        Me.nudThreshold.TabIndex = 7
        Me.nudThreshold.Tag = "Threshold"
        '
        'nudEndDay
        '
        Me.nudEndDay.Location = New System.Drawing.Point(232, 143)
        Me.nudEndDay.Maximum = New Decimal(New Integer() {366, 0, 0, 0})
        Me.nudEndDay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudEndDay.Name = "nudEndDay"
        Me.nudEndDay.Size = New System.Drawing.Size(55, 20)
        Me.nudEndDay.TabIndex = 8
        Me.nudEndDay.Tag = "End_Day"
        Me.nudEndDay.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudStartDay
        '
        Me.nudStartDay.Location = New System.Drawing.Point(83, 143)
        Me.nudStartDay.Maximum = New Decimal(New Integer() {366, 0, 0, 0})
        Me.nudStartDay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudStartDay.Name = "nudStartDay"
        Me.nudStartDay.Size = New System.Drawing.Size(55, 20)
        Me.nudStartDay.TabIndex = 9
        Me.nudStartDay.Tag = "Start_Day"
        Me.nudStartDay.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblStartDay
        '
        Me.lblStartDay.AutoSize = True
        Me.lblStartDay.Location = New System.Drawing.Point(26, 145)
        Me.lblStartDay.Name = "lblStartDay"
        Me.lblStartDay.Size = New System.Drawing.Size(39, 13)
        Me.lblStartDay.TabIndex = 14
        Me.lblStartDay.Tag = "Start_Day"
        Me.lblStartDay.Text = "Label1"
        '
        'lblTotalDays
        '
        Me.lblTotalDays.AutoSize = True
        Me.lblTotalDays.Location = New System.Drawing.Point(345, 145)
        Me.lblTotalDays.Name = "lblTotalDays"
        Me.lblTotalDays.Size = New System.Drawing.Size(39, 13)
        Me.lblTotalDays.TabIndex = 15
        Me.lblTotalDays.Tag = "Total_Days"
        Me.lblTotalDays.Text = "Label3"
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(177, 313)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(39, 13)
        Me.lblThreshold.TabIndex = 16
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Label4"
        '
        'lblEndDay
        '
        Me.lblEndDay.AutoSize = True
        Me.lblEndDay.Location = New System.Drawing.Point(177, 145)
        Me.lblEndDay.Name = "lblEndDay"
        Me.lblEndDay.Size = New System.Drawing.Size(39, 13)
        Me.lblEndDay.TabIndex = 17
        Me.lblEndDay.Tag = "End_Day"
        Me.lblEndDay.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Label6"
        '
        'chkThresholdValue
        '
        Me.chkThresholdValue.AutoSize = True
        Me.chkThresholdValue.Location = New System.Drawing.Point(83, 312)
        Me.chkThresholdValue.Name = "chkThresholdValue"
        Me.chkThresholdValue.Size = New System.Drawing.Size(81, 17)
        Me.chkThresholdValue.TabIndex = 19
        Me.chkThresholdValue.Tag = "Threshold"
        Me.chkThresholdValue.Text = "CheckBox1"
        Me.chkThresholdValue.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(61, 362)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 4
        '
        'dlgExtremeEvents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 415)
        Me.Controls.Add(Me.chkThresholdValue)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblEndDay)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.lblTotalDays)
        Me.Controls.Add(Me.lblStartDay)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.chkExtremeMin)
        Me.Controls.Add(Me.chkExtremeMax)
        Me.Controls.Add(Me.chkRemoveNA)
        Me.Controls.Add(Me.nudStartDay)
        Me.Controls.Add(Me.nudEndDay)
        Me.Controls.Add(Me.nudThreshold)
        Me.Controls.Add(Me.NumericUpDown7)
        Me.Controls.Add(Me.nudTotalDays)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblColumNameEventDay)
        Me.Controls.Add(Me.lblColumnNameExtremeEvent)
        Me.Controls.Add(Me.txtColumnNameEventDay)
        Me.Controls.Add(Me.txtColumNameExtremeEvent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExtremeEvents"
        Me.Tag = "Extreme_Events"
        Me.Text = "Extreme Events"
        CType(Me.nudTotalDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEndDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStartDay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtColumNameExtremeEvent As TextBox
    Friend WithEvents txtColumnNameEventDay As TextBox
    Friend WithEvents lblColumnNameExtremeEvent As Label
    Friend WithEvents lblColumNameEventDay As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkRemoveNA As CheckBox
    Friend WithEvents chkExtremeMax As CheckBox
    Friend WithEvents chkExtremeMin As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents nudTotalDays As NumericUpDown
    Friend WithEvents NumericUpDown7 As NumericUpDown
    Friend WithEvents nudThreshold As NumericUpDown
    Friend WithEvents nudEndDay As NumericUpDown
    Friend WithEvents nudStartDay As NumericUpDown
    Friend WithEvents lblStartDay As Label
    Friend WithEvents lblTotalDays As Label
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lblEndDay As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents chkThresholdValue As CheckBox
End Class
