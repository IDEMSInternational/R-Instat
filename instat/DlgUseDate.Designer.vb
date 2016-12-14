<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgUseDate
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
        Me.lblDateVariable = New System.Windows.Forms.Label()
        Me.grpDateFunctions = New System.Windows.Forms.GroupBox()
        Me.grpOthers = New System.Windows.Forms.GroupBox()
        Me.chkPentade = New System.Windows.Forms.CheckBox()
        Me.chkLeapYear = New System.Windows.Forms.CheckBox()
        Me.chkDecade = New System.Windows.Forms.CheckBox()
        Me.grpFullName = New System.Windows.Forms.GroupBox()
        Me.chkWeekdayName = New System.Windows.Forms.CheckBox()
        Me.chkMonthNam = New System.Windows.Forms.CheckBox()
        Me.grpAbbreviation = New System.Windows.Forms.GroupBox()
        Me.chkAbbrWeekDay = New System.Windows.Forms.CheckBox()
        Me.chkAbbrMonthName = New System.Windows.Forms.CheckBox()
        Me.grpValues = New System.Windows.Forms.GroupBox()
        Me.chkYear = New System.Windows.Forms.CheckBox()
        Me.chkMonthValue = New System.Windows.Forms.CheckBox()
        Me.chkDayInMonth = New System.Windows.Forms.CheckBox()
        Me.chkDayInYear = New System.Windows.Forms.CheckBox()
        Me.chkDayYear = New System.Windows.Forms.CheckBox()
        Me.chkWeek = New System.Windows.Forms.CheckBox()
        Me.chkWeekDayVal = New System.Windows.Forms.CheckBox()
        Me.ucrReceiverUseDate = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorUseDate = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpDateFunctions.SuspendLayout()
        Me.grpOthers.SuspendLayout()
        Me.grpFullName.SuspendLayout()
        Me.grpAbbreviation.SuspendLayout()
        Me.grpValues.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDateVariable
        '
        Me.lblDateVariable.AutoSize = True
        Me.lblDateVariable.Location = New System.Drawing.Point(251, 18)
        Me.lblDateVariable.Name = "lblDateVariable"
        Me.lblDateVariable.Size = New System.Drawing.Size(71, 13)
        Me.lblDateVariable.TabIndex = 1
        Me.lblDateVariable.Text = "Date Column:"
        '
        'grpDateFunctions
        '
        Me.grpDateFunctions.Controls.Add(Me.grpOthers)
        Me.grpDateFunctions.Controls.Add(Me.grpFullName)
        Me.grpDateFunctions.Controls.Add(Me.grpAbbreviation)
        Me.grpDateFunctions.Controls.Add(Me.grpValues)
        Me.grpDateFunctions.Location = New System.Drawing.Point(14, 196)
        Me.grpDateFunctions.Name = "grpDateFunctions"
        Me.grpDateFunctions.Size = New System.Drawing.Size(445, 186)
        Me.grpDateFunctions.TabIndex = 3
        Me.grpDateFunctions.TabStop = False
        Me.grpDateFunctions.Text = "Date Functions"
        '
        'grpOthers
        '
        Me.grpOthers.Controls.Add(Me.chkPentade)
        Me.grpOthers.Controls.Add(Me.chkLeapYear)
        Me.grpOthers.Controls.Add(Me.chkDecade)
        Me.grpOthers.Location = New System.Drawing.Point(6, 136)
        Me.grpOthers.Name = "grpOthers"
        Me.grpOthers.Size = New System.Drawing.Size(429, 40)
        Me.grpOthers.TabIndex = 3
        Me.grpOthers.TabStop = False
        Me.grpOthers.Text = "Other Functions"
        '
        'chkPentade
        '
        Me.chkPentade.AutoSize = True
        Me.chkPentade.Location = New System.Drawing.Point(140, 17)
        Me.chkPentade.Name = "chkPentade"
        Me.chkPentade.Size = New System.Drawing.Size(66, 17)
        Me.chkPentade.TabIndex = 1
        Me.chkPentade.Text = "Pentade"
        Me.chkPentade.UseVisualStyleBackColor = True
        '
        'chkLeapYear
        '
        Me.chkLeapYear.AutoSize = True
        Me.chkLeapYear.Location = New System.Drawing.Point(6, 17)
        Me.chkLeapYear.Name = "chkLeapYear"
        Me.chkLeapYear.Size = New System.Drawing.Size(75, 17)
        Me.chkLeapYear.TabIndex = 2
        Me.chkLeapYear.Text = "Leap Year"
        Me.chkLeapYear.UseVisualStyleBackColor = True
        '
        'chkDecade
        '
        Me.chkDecade.AutoSize = True
        Me.chkDecade.Location = New System.Drawing.Point(298, 17)
        Me.chkDecade.Name = "chkDecade"
        Me.chkDecade.Size = New System.Drawing.Size(64, 17)
        Me.chkDecade.TabIndex = 0
        Me.chkDecade.Text = "Decade"
        Me.chkDecade.UseVisualStyleBackColor = True
        '
        'grpFullName
        '
        Me.grpFullName.Controls.Add(Me.chkWeekdayName)
        Me.grpFullName.Controls.Add(Me.chkMonthNam)
        Me.grpFullName.Location = New System.Drawing.Point(329, 19)
        Me.grpFullName.Name = "grpFullName"
        Me.grpFullName.Size = New System.Drawing.Size(106, 111)
        Me.grpFullName.TabIndex = 2
        Me.grpFullName.TabStop = False
        Me.grpFullName.Text = "Full Name"
        '
        'chkWeekdayName
        '
        Me.chkWeekdayName.AutoSize = True
        Me.chkWeekdayName.Location = New System.Drawing.Point(9, 23)
        Me.chkWeekdayName.Name = "chkWeekdayName"
        Me.chkWeekdayName.Size = New System.Drawing.Size(78, 17)
        Me.chkWeekdayName.TabIndex = 0
        Me.chkWeekdayName.Text = " Weekday "
        Me.chkWeekdayName.UseVisualStyleBackColor = True
        '
        'chkMonthNam
        '
        Me.chkMonthNam.AutoSize = True
        Me.chkMonthNam.Location = New System.Drawing.Point(9, 52)
        Me.chkMonthNam.Name = "chkMonthNam"
        Me.chkMonthNam.Size = New System.Drawing.Size(56, 17)
        Me.chkMonthNam.TabIndex = 1
        Me.chkMonthNam.Text = "Month"
        Me.chkMonthNam.UseVisualStyleBackColor = True
        '
        'grpAbbreviation
        '
        Me.grpAbbreviation.Controls.Add(Me.chkAbbrWeekDay)
        Me.grpAbbreviation.Controls.Add(Me.chkAbbrMonthName)
        Me.grpAbbreviation.Location = New System.Drawing.Point(218, 19)
        Me.grpAbbreviation.Name = "grpAbbreviation"
        Me.grpAbbreviation.Size = New System.Drawing.Size(105, 111)
        Me.grpAbbreviation.TabIndex = 1
        Me.grpAbbreviation.TabStop = False
        Me.grpAbbreviation.Text = "Abbreviation"
        '
        'chkAbbrWeekDay
        '
        Me.chkAbbrWeekDay.AutoSize = True
        Me.chkAbbrWeekDay.Location = New System.Drawing.Point(6, 25)
        Me.chkAbbrWeekDay.Name = "chkAbbrWeekDay"
        Me.chkAbbrWeekDay.Size = New System.Drawing.Size(75, 17)
        Me.chkAbbrWeekDay.TabIndex = 0
        Me.chkAbbrWeekDay.Text = " Weekday"
        Me.chkAbbrWeekDay.UseVisualStyleBackColor = True
        '
        'chkAbbrMonthName
        '
        Me.chkAbbrMonthName.AutoSize = True
        Me.chkAbbrMonthName.Location = New System.Drawing.Point(6, 53)
        Me.chkAbbrMonthName.Name = "chkAbbrMonthName"
        Me.chkAbbrMonthName.Size = New System.Drawing.Size(56, 17)
        Me.chkAbbrMonthName.TabIndex = 1
        Me.chkAbbrMonthName.Text = "Month"
        Me.chkAbbrMonthName.UseVisualStyleBackColor = True
        '
        'grpValues
        '
        Me.grpValues.Controls.Add(Me.chkYear)
        Me.grpValues.Controls.Add(Me.chkMonthValue)
        Me.grpValues.Controls.Add(Me.chkDayInMonth)
        Me.grpValues.Controls.Add(Me.chkDayInYear)
        Me.grpValues.Controls.Add(Me.chkDayYear)
        Me.grpValues.Controls.Add(Me.chkWeek)
        Me.grpValues.Controls.Add(Me.chkWeekDayVal)
        Me.grpValues.Location = New System.Drawing.Point(6, 19)
        Me.grpValues.Name = "grpValues"
        Me.grpValues.Size = New System.Drawing.Size(206, 111)
        Me.grpValues.TabIndex = 0
        Me.grpValues.TabStop = False
        Me.grpValues.Text = "Values"
        '
        'chkYear
        '
        Me.chkYear.AutoSize = True
        Me.chkYear.Location = New System.Drawing.Point(6, 19)
        Me.chkYear.Name = "chkYear"
        Me.chkYear.Size = New System.Drawing.Size(48, 17)
        Me.chkYear.TabIndex = 0
        Me.chkYear.Text = "Year"
        Me.chkYear.UseVisualStyleBackColor = True
        '
        'chkMonthValue
        '
        Me.chkMonthValue.AutoSize = True
        Me.chkMonthValue.Location = New System.Drawing.Point(6, 42)
        Me.chkMonthValue.Name = "chkMonthValue"
        Me.chkMonthValue.Size = New System.Drawing.Size(59, 17)
        Me.chkMonthValue.TabIndex = 2
        Me.chkMonthValue.Text = "Month "
        Me.chkMonthValue.UseVisualStyleBackColor = True
        '
        'chkDayInMonth
        '
        Me.chkDayInMonth.AutoSize = True
        Me.chkDayInMonth.Location = New System.Drawing.Point(6, 65)
        Me.chkDayInMonth.Name = "chkDayInMonth"
        Me.chkDayInMonth.Size = New System.Drawing.Size(48, 17)
        Me.chkDayInMonth.TabIndex = 4
        Me.chkDayInMonth.Text = "Day "
        Me.chkDayInMonth.UseVisualStyleBackColor = True
        '
        'chkDayInYear
        '
        Me.chkDayInYear.AutoSize = True
        Me.chkDayInYear.Location = New System.Drawing.Point(96, 42)
        Me.chkDayInYear.Name = "chkDayInYear"
        Me.chkDayInYear.Size = New System.Drawing.Size(79, 17)
        Me.chkDayInYear.TabIndex = 3
        Me.chkDayInYear.Text = "Day in year"
        Me.chkDayInYear.UseVisualStyleBackColor = True
        '
        'chkDayYear
        '
        Me.chkDayYear.AutoSize = True
        Me.chkDayYear.Location = New System.Drawing.Point(96, 65)
        Me.chkDayYear.Name = "chkDayYear"
        Me.chkDayYear.Size = New System.Drawing.Size(108, 17)
        Me.chkDayYear.TabIndex = 5
        Me.chkDayYear.Text = "Day in Year (366)"
        Me.chkDayYear.UseVisualStyleBackColor = True
        '
        'chkWeek
        '
        Me.chkWeek.AutoSize = True
        Me.chkWeek.Location = New System.Drawing.Point(6, 88)
        Me.chkWeek.Name = "chkWeek"
        Me.chkWeek.Size = New System.Drawing.Size(55, 17)
        Me.chkWeek.TabIndex = 6
        Me.chkWeek.Text = "Week"
        Me.chkWeek.UseVisualStyleBackColor = True
        '
        'chkWeekDayVal
        '
        Me.chkWeekDayVal.AutoSize = True
        Me.chkWeekDayVal.Location = New System.Drawing.Point(96, 19)
        Me.chkWeekDayVal.Name = "chkWeekDayVal"
        Me.chkWeekDayVal.Size = New System.Drawing.Size(75, 17)
        Me.chkWeekDayVal.TabIndex = 1
        Me.chkWeekDayVal.Text = "Weekday "
        Me.chkWeekDayVal.UseVisualStyleBackColor = True
        '
        'ucrReceiverUseDate
        '
        Me.ucrReceiverUseDate.Location = New System.Drawing.Point(254, 39)
        Me.ucrReceiverUseDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverUseDate.Name = "ucrReceiverUseDate"
        Me.ucrReceiverUseDate.Selector = Nothing
        Me.ucrReceiverUseDate.Size = New System.Drawing.Size(151, 20)
        Me.ucrReceiverUseDate.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 391)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(407, 52)
        Me.ucrBase.TabIndex = 4
        '
        'ucrSelectorUseDate
        '
        Me.ucrSelectorUseDate.bShowHiddenColumns = False
        Me.ucrSelectorUseDate.bUseCurrentFilter = True
        Me.ucrSelectorUseDate.Location = New System.Drawing.Point(14, 9)
        Me.ucrSelectorUseDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorUseDate.Name = "ucrSelectorUseDate"
        Me.ucrSelectorUseDate.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorUseDate.TabIndex = 0
        '
        'dlgUseDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 448)
        Me.Controls.Add(Me.grpDateFunctions)
        Me.Controls.Add(Me.ucrReceiverUseDate)
        Me.Controls.Add(Me.lblDateVariable)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorUseDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgUseDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Use Date"
        Me.grpDateFunctions.ResumeLayout(False)
        Me.grpOthers.ResumeLayout(False)
        Me.grpOthers.PerformLayout()
        Me.grpFullName.ResumeLayout(False)
        Me.grpFullName.PerformLayout()
        Me.grpAbbreviation.ResumeLayout(False)
        Me.grpAbbreviation.PerformLayout()
        Me.grpValues.ResumeLayout(False)
        Me.grpValues.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorUseDate As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblDateVariable As Label
    Friend WithEvents ucrReceiverUseDate As ucrReceiverSingle
    Friend WithEvents grpDateFunctions As GroupBox
    Friend WithEvents chkLeapYear As CheckBox
    Friend WithEvents chkDecade As CheckBox
    Friend WithEvents chkPentade As CheckBox
    Friend WithEvents chkDayYear As CheckBox
    Friend WithEvents chkMonthValue As CheckBox
    Friend WithEvents chkWeek As CheckBox
    Friend WithEvents chkDayInYear As CheckBox
    Friend WithEvents chkDayInMonth As CheckBox
    Friend WithEvents chkWeekDayVal As CheckBox
    Friend WithEvents chkYear As CheckBox
    Friend WithEvents chkMonthNam As CheckBox
    Friend WithEvents chkAbbrMonthName As CheckBox
    Friend WithEvents chkWeekdayName As CheckBox
    Friend WithEvents chkAbbrWeekDay As CheckBox
    Friend WithEvents grpOthers As GroupBox
    Friend WithEvents grpFullName As GroupBox
    Friend WithEvents grpAbbreviation As GroupBox
    Friend WithEvents grpValues As GroupBox
End Class
