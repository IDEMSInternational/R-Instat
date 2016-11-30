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
        Me.nudEvaporation = New System.Windows.Forms.NumericUpDown()
        Me.nudMaximumCapacity = New System.Windows.Forms.NumericUpDown()
        Me.nudDecimalPlace = New System.Windows.Forms.NumericUpDown()
        Me.txtDisplayDayName = New System.Windows.Forms.TextBox()
        Me.txtColumnName = New System.Windows.Forms.TextBox()
        Me.lblDisplayDayName = New System.Windows.Forms.Label()
        Me.lblDecimalPlace = New System.Windows.Forms.Label()
        Me.lblEvaporation = New System.Windows.Forms.Label()
        Me.lblMaximumCapacity = New System.Windows.Forms.Label()
        Me.lblColumnName = New System.Windows.Forms.Label()
        Me.chkPrintTable = New System.Windows.Forms.CheckBox()
        Me.chkMonthAbbreviations = New System.Windows.Forms.CheckBox()
        CType(Me.nudEvaporation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMaximumCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDecimalPlace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(55, 245)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'nudEvaporation
        '
        Me.nudEvaporation.Location = New System.Drawing.Point(171, 104)
        Me.nudEvaporation.Name = "nudEvaporation"
        Me.nudEvaporation.Size = New System.Drawing.Size(60, 20)
        Me.nudEvaporation.TabIndex = 1
        Me.nudEvaporation.Tag = "Evaporation"
        '
        'nudMaximumCapacity
        '
        Me.nudMaximumCapacity.Location = New System.Drawing.Point(171, 78)
        Me.nudMaximumCapacity.Name = "nudMaximumCapacity"
        Me.nudMaximumCapacity.Size = New System.Drawing.Size(60, 20)
        Me.nudMaximumCapacity.TabIndex = 2
        Me.nudMaximumCapacity.Tag = "Maximum_Capacity"
        '
        'nudDecimalPlace
        '
        Me.nudDecimalPlace.Location = New System.Drawing.Point(171, 130)
        Me.nudDecimalPlace.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudDecimalPlace.Name = "nudDecimalPlace"
        Me.nudDecimalPlace.Size = New System.Drawing.Size(60, 20)
        Me.nudDecimalPlace.TabIndex = 3
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
        'chkPrintTable
        '
        Me.chkPrintTable.AutoSize = True
        Me.chkPrintTable.Location = New System.Drawing.Point(324, 194)
        Me.chkPrintTable.Name = "chkPrintTable"
        Me.chkPrintTable.Size = New System.Drawing.Size(81, 17)
        Me.chkPrintTable.TabIndex = 14
        Me.chkPrintTable.Tag = "Print_Table"
        Me.chkPrintTable.Text = "CheckBox1"
        Me.chkPrintTable.UseVisualStyleBackColor = True
        '
        'chkMonthAbbreviations
        '
        Me.chkMonthAbbreviations.AutoSize = True
        Me.chkMonthAbbreviations.Location = New System.Drawing.Point(113, 194)
        Me.chkMonthAbbreviations.Name = "chkMonthAbbreviations"
        Me.chkMonthAbbreviations.Size = New System.Drawing.Size(81, 17)
        Me.chkMonthAbbreviations.TabIndex = 15
        Me.chkMonthAbbreviations.Tag = "Month_Abbreviations"
        Me.chkMonthAbbreviations.Text = "CheckBox1"
        Me.chkMonthAbbreviations.UseVisualStyleBackColor = True
        '
        'dlgWaterBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 277)
        Me.Controls.Add(Me.chkMonthAbbreviations)
        Me.Controls.Add(Me.chkPrintTable)
        Me.Controls.Add(Me.lblColumnName)
        Me.Controls.Add(Me.lblMaximumCapacity)
        Me.Controls.Add(Me.lblEvaporation)
        Me.Controls.Add(Me.lblDecimalPlace)
        Me.Controls.Add(Me.lblDisplayDayName)
        Me.Controls.Add(Me.txtColumnName)
        Me.Controls.Add(Me.txtDisplayDayName)
        Me.Controls.Add(Me.nudDecimalPlace)
        Me.Controls.Add(Me.nudMaximumCapacity)
        Me.Controls.Add(Me.nudEvaporation)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgWaterBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Water_Balance"
        Me.Text = "dlgWaterBalance"
        CType(Me.nudEvaporation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMaximumCapacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDecimalPlace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents nudEvaporation As NumericUpDown
    Friend WithEvents nudMaximumCapacity As NumericUpDown
    Friend WithEvents nudDecimalPlace As NumericUpDown
    Friend WithEvents txtDisplayDayName As TextBox
    Friend WithEvents txtColumnName As TextBox
    Friend WithEvents lblDisplayDayName As Label
    Friend WithEvents lblDecimalPlace As Label
    Friend WithEvents lblEvaporation As Label
    Friend WithEvents lblMaximumCapacity As Label
    Friend WithEvents lblColumnName As Label
    Friend WithEvents chkPrintTable As CheckBox
    Friend WithEvents chkMonthAbbreviations As CheckBox
End Class
