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
        Me.nudThreshold = New System.Windows.Forms.NumericUpDown()
        Me.nudTotalDays = New System.Windows.Forms.NumericUpDown()
        Me.nudDecimalPlaces = New System.Windows.Forms.NumericUpDown()
        Me.ucrInputColumnName = New instat.ucrInputTextBox()
        Me.ucrInputDisplayDay = New instat.ucrInputTextBox()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTotalDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDecimalPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 191)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 54)
        Me.ucrBase.TabIndex = 0
        '
        'chkMonthList
        '
        Me.chkMonthList.AutoSize = True
        Me.chkMonthList.Location = New System.Drawing.Point(162, 168)
        Me.chkMonthList.Name = "chkMonthList"
        Me.chkMonthList.Size = New System.Drawing.Size(75, 17)
        Me.chkMonthList.TabIndex = 1
        Me.chkMonthList.Tag = "Month_List"
        Me.chkMonthList.Text = "Month List"
        Me.chkMonthList.UseVisualStyleBackColor = True
        '
        'chkRemoveNA
        '
        Me.chkRemoveNA.AutoSize = True
        Me.chkRemoveNA.Location = New System.Drawing.Point(12, 168)
        Me.chkRemoveNA.Name = "chkRemoveNA"
        Me.chkRemoveNA.Size = New System.Drawing.Size(139, 17)
        Me.chkRemoveNA.TabIndex = 2
        Me.chkRemoveNA.Tag = "Remove_Missing_Values"
        Me.chkRemoveNA.Text = "Remove Missing Values"
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
        Me.lblColunmName.Location = New System.Drawing.Point(9, 40)
        Me.lblColunmName.Name = "lblColunmName"
        Me.lblColunmName.Size = New System.Drawing.Size(73, 13)
        Me.lblColunmName.TabIndex = 4
        Me.lblColunmName.Tag = "Colunm_Name"
        Me.lblColunmName.Text = "Column Name"
        '
        'lblDayDisplay
        '
        Me.lblDayDisplay.AutoSize = True
        Me.lblDayDisplay.Location = New System.Drawing.Point(9, 63)
        Me.lblDayDisplay.Name = "lblDayDisplay"
        Me.lblDayDisplay.Size = New System.Drawing.Size(63, 13)
        Me.lblDayDisplay.TabIndex = 5
        Me.lblDayDisplay.Tag = "Display_Day"
        Me.lblDayDisplay.Text = "Display Day"
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(9, 89)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(54, 13)
        Me.lblThreshold.TabIndex = 6
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Threshold"
        '
        'lblTotalDays
        '
        Me.lblTotalDays.AutoSize = True
        Me.lblTotalDays.Location = New System.Drawing.Point(9, 115)
        Me.lblTotalDays.Name = "lblTotalDays"
        Me.lblTotalDays.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalDays.TabIndex = 7
        Me.lblTotalDays.Tag = "Total_Days"
        Me.lblTotalDays.Text = "Total Days"
        '
        'lblDecimalPlaces
        '
        Me.lblDecimalPlaces.AutoSize = True
        Me.lblDecimalPlaces.Location = New System.Drawing.Point(12, 141)
        Me.lblDecimalPlaces.Name = "lblDecimalPlaces"
        Me.lblDecimalPlaces.Size = New System.Drawing.Size(80, 13)
        Me.lblDecimalPlaces.TabIndex = 8
        Me.lblDecimalPlaces.Tag = "Decimal_Places"
        Me.lblDecimalPlaces.Text = "Decimal Places"
        '
        'nudThreshold
        '
        Me.nudThreshold.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudThreshold.Location = New System.Drawing.Point(98, 82)
        Me.nudThreshold.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudThreshold.Name = "nudThreshold"
        Me.nudThreshold.Size = New System.Drawing.Size(76, 20)
        Me.nudThreshold.TabIndex = 11
        '
        'nudTotalDays
        '
        Me.nudTotalDays.Location = New System.Drawing.Point(98, 108)
        Me.nudTotalDays.Name = "nudTotalDays"
        Me.nudTotalDays.Size = New System.Drawing.Size(76, 20)
        Me.nudTotalDays.TabIndex = 12
        '
        'nudDecimalPlaces
        '
        Me.nudDecimalPlaces.Location = New System.Drawing.Point(98, 134)
        Me.nudDecimalPlaces.Name = "nudDecimalPlaces"
        Me.nudDecimalPlaces.Size = New System.Drawing.Size(76, 20)
        Me.nudDecimalPlaces.TabIndex = 13
        '
        'ucrInputColumnName
        '
        Me.ucrInputColumnName.IsReadOnly = False
        Me.ucrInputColumnName.Location = New System.Drawing.Point(88, 32)
        Me.ucrInputColumnName.Name = "ucrInputColumnName"
        Me.ucrInputColumnName.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputColumnName.TabIndex = 14
        '
        'ucrInputDisplayDay
        '
        Me.ucrInputDisplayDay.IsReadOnly = False
        Me.ucrInputDisplayDay.Location = New System.Drawing.Point(88, 55)
        Me.ucrInputDisplayDay.Name = "ucrInputDisplayDay"
        Me.ucrInputDisplayDay.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputDisplayDay.TabIndex = 14
        '
        'dlgDisplayRainRunningTotal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 255)
        Me.Controls.Add(Me.ucrInputDisplayDay)
        Me.Controls.Add(Me.ucrInputColumnName)
        Me.Controls.Add(Me.nudDecimalPlaces)
        Me.Controls.Add(Me.nudTotalDays)
        Me.Controls.Add(Me.nudThreshold)
        Me.Controls.Add(Me.lblDecimalPlaces)
        Me.Controls.Add(Me.lblTotalDays)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.lblDayDisplay)
        Me.Controls.Add(Me.lblColunmName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkRemoveNA)
        Me.Controls.Add(Me.chkMonthList)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDisplayRainRunningTotal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Display_Rain_Running_Total"
        Me.Text = "Display Rain Running Total"
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTotalDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDecimalPlaces, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents nudThreshold As NumericUpDown
    Friend WithEvents nudTotalDays As NumericUpDown
    Friend WithEvents nudDecimalPlaces As NumericUpDown
    Friend WithEvents ucrInputColumnName As ucrInputTextBox
    Friend WithEvents ucrInputDisplayDay As ucrInputTextBox
End Class
