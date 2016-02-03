<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDisplayRainRunningTotal
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
        Me.chkMonthList = New System.Windows.Forms.CheckBox()
        Me.chkRemoveNA = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblColunmName = New System.Windows.Forms.Label()
        Me.lblDayDisplay = New System.Windows.Forms.Label()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.lblTotalDays = New System.Windows.Forms.Label()
        Me.lblDecimalPlaces = New System.Windows.Forms.Label()
        Me.txtDayDisplay = New System.Windows.Forms.TextBox()
        Me.txtColunmName = New System.Windows.Forms.TextBox()
        Me.nudThreshold = New System.Windows.Forms.NumericUpDown()
        Me.nudTotalDays = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTotalDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(68, 251)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'chkMonthList
        '
        Me.chkMonthList.AutoSize = True
        Me.chkMonthList.Location = New System.Drawing.Point(356, 196)
        Me.chkMonthList.Name = "chkMonthList"
        Me.chkMonthList.Size = New System.Drawing.Size(81, 17)
        Me.chkMonthList.TabIndex = 1
        Me.chkMonthList.Tag = "Month_List"
        Me.chkMonthList.Text = "CheckBox1"
        Me.chkMonthList.UseVisualStyleBackColor = True
        '
        'chkRemoveNA
        '
        Me.chkRemoveNA.AutoSize = True
        Me.chkRemoveNA.Location = New System.Drawing.Point(356, 157)
        Me.chkRemoveNA.Name = "chkRemoveNA"
        Me.chkRemoveNA.Size = New System.Drawing.Size(81, 17)
        Me.chkRemoveNA.TabIndex = 2
        Me.chkRemoveNA.Tag = "Remove_NA"
        Me.chkRemoveNA.Text = "CheckBox2"
        Me.chkRemoveNA.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Data list not implemented"
        '
        'lblColunmName
        '
        Me.lblColunmName.AutoSize = True
        Me.lblColunmName.Location = New System.Drawing.Point(65, 37)
        Me.lblColunmName.Name = "lblColunmName"
        Me.lblColunmName.Size = New System.Drawing.Size(39, 13)
        Me.lblColunmName.TabIndex = 4
        Me.lblColunmName.Tag = "Colunm_Name"
        Me.lblColunmName.Text = "Label2"
        '
        'lblDayDisplay
        '
        Me.lblDayDisplay.AutoSize = True
        Me.lblDayDisplay.Location = New System.Drawing.Point(65, 63)
        Me.lblDayDisplay.Name = "lblDayDisplay"
        Me.lblDayDisplay.Size = New System.Drawing.Size(39, 13)
        Me.lblDayDisplay.TabIndex = 5
        Me.lblDayDisplay.Tag = "Day_Display"
        Me.lblDayDisplay.Text = "Label3"
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(65, 89)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(39, 13)
        Me.lblThreshold.TabIndex = 6
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Label4"
        '
        'lblTotalDays
        '
        Me.lblTotalDays.AutoSize = True
        Me.lblTotalDays.Location = New System.Drawing.Point(65, 111)
        Me.lblTotalDays.Name = "lblTotalDays"
        Me.lblTotalDays.Size = New System.Drawing.Size(39, 13)
        Me.lblTotalDays.TabIndex = 7
        Me.lblTotalDays.Tag = "Total_Days"
        Me.lblTotalDays.Text = "Label5"
        '
        'lblDecimalPlaces
        '
        Me.lblDecimalPlaces.AutoSize = True
        Me.lblDecimalPlaces.Location = New System.Drawing.Point(65, 142)
        Me.lblDecimalPlaces.Name = "lblDecimalPlaces"
        Me.lblDecimalPlaces.Size = New System.Drawing.Size(39, 13)
        Me.lblDecimalPlaces.TabIndex = 8
        Me.lblDecimalPlaces.Tag = "Decimal_Places"
        Me.lblDecimalPlaces.Text = "Label6"
        '
        'txtDayDisplay
        '
        Me.txtDayDisplay.Location = New System.Drawing.Point(164, 63)
        Me.txtDayDisplay.Name = "txtDayDisplay"
        Me.txtDayDisplay.Size = New System.Drawing.Size(100, 20)
        Me.txtDayDisplay.TabIndex = 9
        Me.txtDayDisplay.Tag = ""
        '
        'txtColunmName
        '
        Me.txtColunmName.Location = New System.Drawing.Point(164, 37)
        Me.txtColunmName.Name = "txtColunmName"
        Me.txtColunmName.Size = New System.Drawing.Size(100, 20)
        Me.txtColunmName.TabIndex = 10
        Me.txtColunmName.Tag = ""
        '
        'nudThreshold
        '
        Me.nudThreshold.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudThreshold.Location = New System.Drawing.Point(164, 89)
        Me.nudThreshold.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudThreshold.Name = "nudThreshold"
        Me.nudThreshold.Size = New System.Drawing.Size(76, 20)
        Me.nudThreshold.TabIndex = 11
        '
        'nudTotalDays
        '
        Me.nudTotalDays.Location = New System.Drawing.Point(164, 109)
        Me.nudTotalDays.Name = "nudTotalDays"
        Me.nudTotalDays.Size = New System.Drawing.Size(76, 20)
        Me.nudTotalDays.TabIndex = 12
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(164, 135)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(76, 20)
        Me.NumericUpDown3.TabIndex = 13
        '
        'dlgDisplayRainRunningTotal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 286)
        Me.Controls.Add(Me.NumericUpDown3)
        Me.Controls.Add(Me.nudTotalDays)
        Me.Controls.Add(Me.nudThreshold)
        Me.Controls.Add(Me.txtColunmName)
        Me.Controls.Add(Me.txtDayDisplay)
        Me.Controls.Add(Me.lblDecimalPlaces)
        Me.Controls.Add(Me.lblTotalDays)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.lblDayDisplay)
        Me.Controls.Add(Me.lblColunmName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkRemoveNA)
        Me.Controls.Add(Me.chkMonthList)
        Me.Controls.Add(Me.ucrBase)
        Me.Name = "dlgDisplayRainRunningTotal"
        Me.Tag = "Display_Rain_Running_Total"
        Me.Text = "Display Rain Running Total"
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTotalDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkMonthList As CheckBox
    Friend WithEvents chkRemoveNA As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblColunmName As Label
    Friend WithEvents lblDayDisplay As Label
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lblTotalDays As Label
    Friend WithEvents lblDecimalPlaces As Label
    Friend WithEvents txtDayDisplay As TextBox
    Friend WithEvents txtColunmName As TextBox
    Friend WithEvents nudThreshold As NumericUpDown
    Friend WithEvents nudTotalDays As NumericUpDown
    Friend WithEvents NumericUpDown3 As NumericUpDown
End Class
