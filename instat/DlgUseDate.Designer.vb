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
        Me.chkPentad = New System.Windows.Forms.CheckBox()
        Me.chkLeapYear = New System.Windows.Forms.CheckBox()
        Me.chkDekade = New System.Windows.Forms.CheckBox()
        Me.grpFullName = New System.Windows.Forms.GroupBox()
        Me.grpAbbreviation = New System.Windows.Forms.GroupBox()
        Me.grpValues = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverUseDate = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorUseDate = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkYear = New instat.ucrCheck()
        Me.ucrChkMonth = New instat.ucrCheck()
        Me.ucrChkDay = New instat.ucrCheck()
        Me.ucrChkWeek = New instat.ucrCheck()
        Me.ucrChkWeekday = New instat.ucrCheck()
        Me.ucrChkDayInYear = New instat.ucrCheck()
        Me.ucrChkDayYear366 = New instat.ucrCheck()
        Me.ucrChkAbbrWeekday = New instat.ucrCheck()
        Me.ucrChkAbbrMonth = New instat.ucrCheck()
        Me.ucrChkFullWeekday = New instat.ucrCheck()
        Me.ucrChkFullMonth = New instat.ucrCheck()
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
        Me.grpDateFunctions.Size = New System.Drawing.Size(445, 204)
        Me.grpDateFunctions.TabIndex = 3
        Me.grpDateFunctions.TabStop = False
        Me.grpDateFunctions.Text = "Date Functions"
        '
        'grpOthers
        '
        Me.grpOthers.Controls.Add(Me.chkPentad)
        Me.grpOthers.Controls.Add(Me.chkLeapYear)
        Me.grpOthers.Controls.Add(Me.chkDekade)
        Me.grpOthers.Location = New System.Drawing.Point(6, 150)
        Me.grpOthers.Name = "grpOthers"
        Me.grpOthers.Size = New System.Drawing.Size(429, 48)
        Me.grpOthers.TabIndex = 3
        Me.grpOthers.TabStop = False
        Me.grpOthers.Text = "Other Functions"
        '
        'chkPentad
        '
        Me.chkPentad.AutoSize = True
        Me.chkPentad.Location = New System.Drawing.Point(140, 17)
        Me.chkPentad.Name = "chkPentad"
        Me.chkPentad.Size = New System.Drawing.Size(60, 17)
        Me.chkPentad.TabIndex = 1
        Me.chkPentad.Text = "Pentad"
        Me.chkPentad.UseVisualStyleBackColor = True
        '
        'chkLeapYear
        '
        Me.chkLeapYear.AutoSize = True
        Me.chkLeapYear.Location = New System.Drawing.Point(6, 17)
        Me.chkLeapYear.Name = "chkLeapYear"
        Me.chkLeapYear.Size = New System.Drawing.Size(75, 17)
        Me.chkLeapYear.TabIndex = 0
        Me.chkLeapYear.Text = "Leap Year"
        Me.chkLeapYear.UseVisualStyleBackColor = True
        '
        'chkDekade
        '
        Me.chkDekade.AutoSize = True
        Me.chkDekade.Location = New System.Drawing.Point(298, 17)
        Me.chkDekade.Name = "chkDekade"
        Me.chkDekade.Size = New System.Drawing.Size(58, 17)
        Me.chkDekade.TabIndex = 2
        Me.chkDekade.Text = "Dekad"
        Me.chkDekade.UseVisualStyleBackColor = True
        '
        'grpFullName
        '
        Me.grpFullName.Controls.Add(Me.ucrChkFullWeekday)
        Me.grpFullName.Controls.Add(Me.ucrChkFullMonth)
        Me.grpFullName.Location = New System.Drawing.Point(329, 19)
        Me.grpFullName.Name = "grpFullName"
        Me.grpFullName.Size = New System.Drawing.Size(106, 125)
        Me.grpFullName.TabIndex = 2
        Me.grpFullName.TabStop = False
        Me.grpFullName.Text = "Full Name"
        '
        'grpAbbreviation
        '
        Me.grpAbbreviation.Controls.Add(Me.ucrChkAbbrMonth)
        Me.grpAbbreviation.Controls.Add(Me.ucrChkAbbrWeekday)
        Me.grpAbbreviation.Location = New System.Drawing.Point(222, 19)
        Me.grpAbbreviation.Name = "grpAbbreviation"
        Me.grpAbbreviation.Size = New System.Drawing.Size(105, 125)
        Me.grpAbbreviation.TabIndex = 1
        Me.grpAbbreviation.TabStop = False
        Me.grpAbbreviation.Text = "Abbreviation"
        '
        'grpValues
        '
        Me.grpValues.Controls.Add(Me.ucrChkDayYear366)
        Me.grpValues.Controls.Add(Me.ucrChkYear)
        Me.grpValues.Controls.Add(Me.ucrChkDayInYear)
        Me.grpValues.Controls.Add(Me.ucrChkMonth)
        Me.grpValues.Controls.Add(Me.ucrChkDay)
        Me.grpValues.Controls.Add(Me.ucrChkWeekday)
        Me.grpValues.Controls.Add(Me.ucrChkWeek)
        Me.grpValues.Location = New System.Drawing.Point(6, 19)
        Me.grpValues.Name = "grpValues"
        Me.grpValues.Size = New System.Drawing.Size(212, 125)
        Me.grpValues.TabIndex = 0
        Me.grpValues.TabStop = False
        Me.grpValues.Text = "Values"
        '
        'ucrReceiverUseDate
        '
        Me.ucrReceiverUseDate.frmParent = Me
        Me.ucrReceiverUseDate.Location = New System.Drawing.Point(254, 39)
        Me.ucrReceiverUseDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverUseDate.Name = "ucrReceiverUseDate"
        Me.ucrReceiverUseDate.Selector = Nothing
        Me.ucrReceiverUseDate.Size = New System.Drawing.Size(151, 20)
        Me.ucrReceiverUseDate.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 398)
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
        'ucrChkYear
        '
        Me.ucrChkYear.Checked = False
        Me.ucrChkYear.Location = New System.Drawing.Point(6, 17)
        Me.ucrChkYear.Name = "ucrChkYear"
        Me.ucrChkYear.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkYear.TabIndex = 7
        '
        'ucrChkMonth
        '
        Me.ucrChkMonth.Checked = False
        Me.ucrChkMonth.Location = New System.Drawing.Point(6, 43)
        Me.ucrChkMonth.Name = "ucrChkMonth"
        Me.ucrChkMonth.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMonth.TabIndex = 8
        '
        'ucrChkDay
        '
        Me.ucrChkDay.Checked = False
        Me.ucrChkDay.Location = New System.Drawing.Point(6, 69)
        Me.ucrChkDay.Name = "ucrChkDay"
        Me.ucrChkDay.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkDay.TabIndex = 9
        '
        'ucrChkWeek
        '
        Me.ucrChkWeek.Checked = False
        Me.ucrChkWeek.Location = New System.Drawing.Point(6, 95)
        Me.ucrChkWeek.Name = "ucrChkWeek"
        Me.ucrChkWeek.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkWeek.TabIndex = 10
        '
        'ucrChkWeekday
        '
        Me.ucrChkWeekday.Checked = False
        Me.ucrChkWeekday.Location = New System.Drawing.Point(112, 17)
        Me.ucrChkWeekday.Name = "ucrChkWeekday"
        Me.ucrChkWeekday.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkWeekday.TabIndex = 11
        '
        'ucrChkDayInYear
        '
        Me.ucrChkDayInYear.Checked = False
        Me.ucrChkDayInYear.Location = New System.Drawing.Point(112, 43)
        Me.ucrChkDayInYear.Name = "ucrChkDayInYear"
        Me.ucrChkDayInYear.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkDayInYear.TabIndex = 12
        '
        'ucrChkDayYear366
        '
        Me.ucrChkDayYear366.Checked = False
        Me.ucrChkDayYear366.Location = New System.Drawing.Point(112, 69)
        Me.ucrChkDayYear366.Name = "ucrChkDayYear366"
        Me.ucrChkDayYear366.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkDayYear366.TabIndex = 13
        '
        'ucrChkAbbrWeekday
        '
        Me.ucrChkAbbrWeekday.Checked = False
        Me.ucrChkAbbrWeekday.Location = New System.Drawing.Point(5, 17)
        Me.ucrChkAbbrWeekday.Name = "ucrChkAbbrWeekday"
        Me.ucrChkAbbrWeekday.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkAbbrWeekday.TabIndex = 5
        '
        'ucrChkAbbrMonth
        '
        Me.ucrChkAbbrMonth.Checked = False
        Me.ucrChkAbbrMonth.Location = New System.Drawing.Point(5, 43)
        Me.ucrChkAbbrMonth.Name = "ucrChkAbbrMonth"
        Me.ucrChkAbbrMonth.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkAbbrMonth.TabIndex = 6
        '
        'ucrChkFullWeekday
        '
        Me.ucrChkFullWeekday.Checked = False
        Me.ucrChkFullWeekday.Location = New System.Drawing.Point(6, 17)
        Me.ucrChkFullWeekday.Name = "ucrChkFullWeekday"
        Me.ucrChkFullWeekday.Size = New System.Drawing.Size(90, 20)
        Me.ucrChkFullWeekday.TabIndex = 2
        '
        'ucrChkFullMonth
        '
        Me.ucrChkFullMonth.Checked = False
        Me.ucrChkFullMonth.Location = New System.Drawing.Point(6, 43)
        Me.ucrChkFullMonth.Name = "ucrChkFullMonth"
        Me.ucrChkFullMonth.Size = New System.Drawing.Size(90, 20)
        Me.ucrChkFullMonth.TabIndex = 3
        '
        'dlgUseDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 459)
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
        Me.grpAbbreviation.ResumeLayout(False)
        Me.grpValues.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorUseDate As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblDateVariable As Label
    Friend WithEvents ucrReceiverUseDate As ucrReceiverSingle
    Friend WithEvents grpDateFunctions As GroupBox
    Friend WithEvents chkLeapYear As CheckBox
    Friend WithEvents chkDekade As CheckBox
    Friend WithEvents chkPentad As CheckBox
    Friend WithEvents grpOthers As GroupBox
    Friend WithEvents grpFullName As GroupBox
    Friend WithEvents grpAbbreviation As GroupBox
    Friend WithEvents grpValues As GroupBox
    Friend WithEvents ucrChkDayYear366 As ucrCheck
    Friend WithEvents ucrChkDayInYear As ucrCheck
    Friend WithEvents ucrChkWeekday As ucrCheck
    Friend WithEvents ucrChkWeek As ucrCheck
    Friend WithEvents ucrChkDay As ucrCheck
    Friend WithEvents ucrChkMonth As ucrCheck
    Friend WithEvents ucrChkYear As ucrCheck
    Friend WithEvents ucrChkFullWeekday As ucrCheck
    Friend WithEvents ucrChkFullMonth As ucrCheck
    Friend WithEvents ucrChkAbbrMonth As ucrCheck
    Friend WithEvents ucrChkAbbrWeekday As ucrCheck
End Class
