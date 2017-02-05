<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgWaterBalance
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
        Me.ucrBase = New instat.ucrButtons()
        Me.txtDisplayDayName = New System.Windows.Forms.TextBox()
        Me.txtColumnName = New System.Windows.Forms.TextBox()
        Me.lblDisplayDayName = New System.Windows.Forms.Label()
        Me.lblDecimalPlace = New System.Windows.Forms.Label()
        Me.lblEvaporation = New System.Windows.Forms.Label()
        Me.lblMaximumCapacity = New System.Windows.Forms.Label()
        Me.lblColumnName = New System.Windows.Forms.Label()
        Me.ucrChkMonthAbbreviations = New instat.ucrCheck()
        Me.ucrChkPrintTables = New instat.ucrCheck()
        Me.ucrNudMaxCapacity = New instat.ucrNud()
        Me.ucrNudEvaporation = New instat.ucrNud()
        Me.ucrNudDecimalPlace = New instat.ucrNud()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 219)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 58)
        Me.ucrBase.TabIndex = 0
        '
        'txtDisplayDayName
        '
        Me.txtDisplayDayName.Location = New System.Drawing.Point(113, 48)
        Me.txtDisplayDayName.Name = "txtDisplayDayName"
        Me.txtDisplayDayName.Size = New System.Drawing.Size(118, 20)
        Me.txtDisplayDayName.TabIndex = 4
        Me.txtDisplayDayName.Tag = "Display_Day_Name"
        '
        'txtColumnName
        '
        Me.txtColumnName.Location = New System.Drawing.Point(113, 12)
        Me.txtColumnName.Name = "txtColumnName"
        Me.txtColumnName.Size = New System.Drawing.Size(232, 20)
        Me.txtColumnName.TabIndex = 5
        Me.txtColumnName.Tag = "Column_Name"
        '
        'lblDisplayDayName
        '
        Me.lblDisplayDayName.AutoSize = True
        Me.lblDisplayDayName.Location = New System.Drawing.Point(52, 55)
        Me.lblDisplayDayName.Name = "lblDisplayDayName"
        Me.lblDisplayDayName.Size = New System.Drawing.Size(39, 13)
        Me.lblDisplayDayName.TabIndex = 7
        Me.lblDisplayDayName.Tag = "Display_Day_Name"
        Me.lblDisplayDayName.Text = "Label1"
        '
        'lblDecimalPlace
        '
        Me.lblDecimalPlace.AutoSize = True
        Me.lblDecimalPlace.Location = New System.Drawing.Point(101, 137)
        Me.lblDecimalPlace.Name = "lblDecimalPlace"
        Me.lblDecimalPlace.Size = New System.Drawing.Size(39, 13)
        Me.lblDecimalPlace.TabIndex = 10
        Me.lblDecimalPlace.Tag = "Decimal_Place"
        Me.lblDecimalPlace.Text = "Label4"
        '
        'lblEvaporation
        '
        Me.lblEvaporation.AutoSize = True
        Me.lblEvaporation.Location = New System.Drawing.Point(101, 112)
        Me.lblEvaporation.Name = "lblEvaporation"
        Me.lblEvaporation.Size = New System.Drawing.Size(39, 13)
        Me.lblEvaporation.TabIndex = 11
        Me.lblEvaporation.Tag = "Evaporation"
        Me.lblEvaporation.Text = "Label5"
        '
        'lblMaximumCapacity
        '
        Me.lblMaximumCapacity.AutoSize = True
        Me.lblMaximumCapacity.Location = New System.Drawing.Point(101, 86)
        Me.lblMaximumCapacity.Name = "lblMaximumCapacity"
        Me.lblMaximumCapacity.Size = New System.Drawing.Size(39, 13)
        Me.lblMaximumCapacity.TabIndex = 12
        Me.lblMaximumCapacity.Tag = "Maximum_Capacity"
        Me.lblMaximumCapacity.Text = "Label6"
        '
        'lblColumnName
        '
        Me.lblColumnName.AutoSize = True
        Me.lblColumnName.Location = New System.Drawing.Point(52, 15)
        Me.lblColumnName.Name = "lblColumnName"
        Me.lblColumnName.Size = New System.Drawing.Size(39, 13)
        Me.lblColumnName.TabIndex = 13
        Me.lblColumnName.Tag = "Column_Name"
        Me.lblColumnName.Text = "Label7"
        '
        'ucrChkMonthAbbreviations
        '
        Me.ucrChkMonthAbbreviations.bAddRemoveParameter = True
        Me.ucrChkMonthAbbreviations.bChangeParameterValue = True
        Me.ucrChkMonthAbbreviations.Checked = False
        Me.ucrChkMonthAbbreviations.Location = New System.Drawing.Point(12, 193)
        Me.ucrChkMonthAbbreviations.Name = "ucrChkMonthAbbreviations"
        Me.ucrChkMonthAbbreviations.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMonthAbbreviations.TabIndex = 16
        '
        'ucrChkPrintTables
        '
        Me.ucrChkPrintTables.bAddRemoveParameter = True
        Me.ucrChkPrintTables.bChangeParameterValue = True
        Me.ucrChkPrintTables.Checked = False
        Me.ucrChkPrintTables.Location = New System.Drawing.Point(159, 193)
        Me.ucrChkPrintTables.Name = "ucrChkPrintTables"
        Me.ucrChkPrintTables.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkPrintTables.TabIndex = 17
        '
        'ucrNudMaxCapacity
        '
        Me.ucrNudMaxCapacity.bAddRemoveParameter = True
        Me.ucrNudMaxCapacity.bChangeParameterValue = True
        Me.ucrNudMaxCapacity.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxCapacity.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxCapacity.Location = New System.Drawing.Point(159, 84)
        Me.ucrNudMaxCapacity.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxCapacity.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxCapacity.Name = "ucrNudMaxCapacity"
        Me.ucrNudMaxCapacity.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxCapacity.TabIndex = 18
        Me.ucrNudMaxCapacity.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudEvaporation
        '
        Me.ucrNudEvaporation.bAddRemoveParameter = True
        Me.ucrNudEvaporation.bChangeParameterValue = True
        Me.ucrNudEvaporation.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudEvaporation.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudEvaporation.Location = New System.Drawing.Point(159, 111)
        Me.ucrNudEvaporation.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudEvaporation.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudEvaporation.Name = "ucrNudEvaporation"
        Me.ucrNudEvaporation.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudEvaporation.TabIndex = 19
        Me.ucrNudEvaporation.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDecimalPlace
        '
        Me.ucrNudDecimalPlace.bAddRemoveParameter = True
        Me.ucrNudDecimalPlace.bChangeParameterValue = True
        Me.ucrNudDecimalPlace.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimalPlace.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDecimalPlace.Location = New System.Drawing.Point(159, 137)
        Me.ucrNudDecimalPlace.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDecimalPlace.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimalPlace.Name = "ucrNudDecimalPlace"
        Me.ucrNudDecimalPlace.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDecimalPlace.TabIndex = 20
        Me.ucrNudDecimalPlace.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgWaterBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 277)
        Me.Controls.Add(Me.ucrNudDecimalPlace)
        Me.Controls.Add(Me.ucrNudEvaporation)
        Me.Controls.Add(Me.ucrNudMaxCapacity)
        Me.Controls.Add(Me.ucrChkPrintTables)
        Me.Controls.Add(Me.ucrChkMonthAbbreviations)
        Me.Controls.Add(Me.lblColumnName)
        Me.Controls.Add(Me.lblMaximumCapacity)
        Me.Controls.Add(Me.lblEvaporation)
        Me.Controls.Add(Me.lblDecimalPlace)
        Me.Controls.Add(Me.lblDisplayDayName)
        Me.Controls.Add(Me.txtColumnName)
        Me.Controls.Add(Me.txtDisplayDayName)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgWaterBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Water_Balance"
        Me.Text = "dlgWaterBalance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents txtDisplayDayName As TextBox
    Friend WithEvents txtColumnName As TextBox
    Friend WithEvents lblDisplayDayName As Label
    Friend WithEvents lblDecimalPlace As Label
    Friend WithEvents lblEvaporation As Label
    Friend WithEvents lblMaximumCapacity As Label
    Friend WithEvents lblColumnName As Label
    Friend WithEvents ucrChkMonthAbbreviations As ucrCheck
    Friend WithEvents ucrChkPrintTables As ucrCheck
    Friend WithEvents ucrNudMaxCapacity As ucrNud
    Friend WithEvents ucrNudEvaporation As ucrNud
    Friend WithEvents ucrNudDecimalPlace As ucrNud
End Class
