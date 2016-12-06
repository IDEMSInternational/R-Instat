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
        Me.chkSaveDateResultInto = New System.Windows.Forms.CheckBox()
        Me.rdoAbrreviated = New System.Windows.Forms.RadioButton()
        Me.rdoFull = New System.Windows.Forms.RadioButton()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.lblLabelColumns = New System.Windows.Forms.Label()
        Me.lblDateVariable = New System.Windows.Forms.Label()
        Me.grpDateFunctions = New System.Windows.Forms.GroupBox()
        Me.chkWeek = New System.Windows.Forms.CheckBox()
        Me.chkLeapYear = New System.Windows.Forms.CheckBox()
        Me.chkDecade = New System.Windows.Forms.CheckBox()
        Me.chkPentade = New System.Windows.Forms.CheckBox()
        Me.chkDayYear = New System.Windows.Forms.CheckBox()
        Me.chkMonth = New System.Windows.Forms.CheckBox()
        Me.chkDayInYear = New System.Windows.Forms.CheckBox()
        Me.chkDayInMonth = New System.Windows.Forms.CheckBox()
        Me.chkWeekDay = New System.Windows.Forms.CheckBox()
        Me.chkYear = New System.Windows.Forms.CheckBox()
        Me.ucrReceiverUseDate = New instat.ucrReceiverSingle()
        Me.ucrSaveDateResultInto = New instat.ucrInputComboBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorUseDate = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpDateFunctions.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkSaveDateResultInto
        '
        Me.chkSaveDateResultInto.AutoSize = True
        Me.chkSaveDateResultInto.Location = New System.Drawing.Point(14, 301)
        Me.chkSaveDateResultInto.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkSaveDateResultInto.Name = "chkSaveDateResultInto"
        Me.chkSaveDateResultInto.Size = New System.Drawing.Size(104, 17)
        Me.chkSaveDateResultInto.TabIndex = 159
        Me.chkSaveDateResultInto.Text = "Save Result into"
        Me.chkSaveDateResultInto.UseVisualStyleBackColor = True
        '
        'rdoAbrreviated
        '
        Me.rdoAbrreviated.AutoSize = True
        Me.rdoAbrreviated.Location = New System.Drawing.Point(110, 232)
        Me.rdoAbrreviated.Name = "rdoAbrreviated"
        Me.rdoAbrreviated.Size = New System.Drawing.Size(82, 17)
        Me.rdoAbrreviated.TabIndex = 166
        Me.rdoAbrreviated.TabStop = True
        Me.rdoAbrreviated.Text = "Abbreviated"
        Me.rdoAbrreviated.UseVisualStyleBackColor = True
        '
        'rdoFull
        '
        Me.rdoFull.AutoSize = True
        Me.rdoFull.Location = New System.Drawing.Point(110, 258)
        Me.rdoFull.Name = "rdoFull"
        Me.rdoFull.Size = New System.Drawing.Size(41, 17)
        Me.rdoFull.TabIndex = 165
        Me.rdoFull.TabStop = True
        Me.rdoFull.Text = "Full"
        Me.rdoFull.UseVisualStyleBackColor = True
        '
        'rdoNone
        '
        Me.rdoNone.AutoSize = True
        Me.rdoNone.Location = New System.Drawing.Point(110, 204)
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.Size = New System.Drawing.Size(51, 17)
        Me.rdoNone.TabIndex = 164
        Me.rdoNone.TabStop = True
        Me.rdoNone.Text = "None"
        Me.rdoNone.UseVisualStyleBackColor = True
        '
        'lblLabelColumns
        '
        Me.lblLabelColumns.AutoSize = True
        Me.lblLabelColumns.Location = New System.Drawing.Point(12, 232)
        Me.lblLabelColumns.Name = "lblLabelColumns"
        Me.lblLabelColumns.Size = New System.Drawing.Size(76, 13)
        Me.lblLabelColumns.TabIndex = 167
        Me.lblLabelColumns.Text = "Label Columns"
        '
        'lblDateVariable
        '
        Me.lblDateVariable.AutoSize = True
        Me.lblDateVariable.Location = New System.Drawing.Point(251, 18)
        Me.lblDateVariable.Name = "lblDateVariable"
        Me.lblDateVariable.Size = New System.Drawing.Size(68, 13)
        Me.lblDateVariable.TabIndex = 168
        Me.lblDateVariable.Text = "Date Column"
        '
        'grpDateFunctions
        '
        Me.grpDateFunctions.Controls.Add(Me.chkWeek)
        Me.grpDateFunctions.Controls.Add(Me.chkLeapYear)
        Me.grpDateFunctions.Controls.Add(Me.chkDecade)
        Me.grpDateFunctions.Controls.Add(Me.chkPentade)
        Me.grpDateFunctions.Controls.Add(Me.chkDayYear)
        Me.grpDateFunctions.Controls.Add(Me.chkMonth)
        Me.grpDateFunctions.Controls.Add(Me.chkDayInYear)
        Me.grpDateFunctions.Controls.Add(Me.chkDayInMonth)
        Me.grpDateFunctions.Controls.Add(Me.chkWeekDay)
        Me.grpDateFunctions.Controls.Add(Me.chkYear)
        Me.grpDateFunctions.Location = New System.Drawing.Point(254, 78)
        Me.grpDateFunctions.Name = "grpDateFunctions"
        Me.grpDateFunctions.Size = New System.Drawing.Size(185, 210)
        Me.grpDateFunctions.TabIndex = 170
        Me.grpDateFunctions.TabStop = False
        Me.grpDateFunctions.Text = "Date Functions"
        '
        'chkWeek
        '
        Me.chkWeek.AutoSize = True
        Me.chkWeek.Location = New System.Drawing.Point(101, 43)
        Me.chkWeek.Name = "chkWeek"
        Me.chkWeek.Size = New System.Drawing.Size(55, 17)
        Me.chkWeek.TabIndex = 10
        Me.chkWeek.Text = "Week"
        Me.chkWeek.UseVisualStyleBackColor = True
        '
        'chkLeapYear
        '
        Me.chkLeapYear.AutoSize = True
        Me.chkLeapYear.Location = New System.Drawing.Point(7, 138)
        Me.chkLeapYear.Name = "chkLeapYear"
        Me.chkLeapYear.Size = New System.Drawing.Size(75, 17)
        Me.chkLeapYear.TabIndex = 9
        Me.chkLeapYear.Text = "Leap Year"
        Me.chkLeapYear.UseVisualStyleBackColor = True
        '
        'chkDecade
        '
        Me.chkDecade.AutoSize = True
        Me.chkDecade.Location = New System.Drawing.Point(7, 161)
        Me.chkDecade.Name = "chkDecade"
        Me.chkDecade.Size = New System.Drawing.Size(64, 17)
        Me.chkDecade.TabIndex = 8
        Me.chkDecade.Text = "Decade"
        Me.chkDecade.UseVisualStyleBackColor = True
        '
        'chkPentade
        '
        Me.chkPentade.AutoSize = True
        Me.chkPentade.Location = New System.Drawing.Point(7, 184)
        Me.chkPentade.Name = "chkPentade"
        Me.chkPentade.Size = New System.Drawing.Size(66, 17)
        Me.chkPentade.TabIndex = 7
        Me.chkPentade.Text = "Pentade"
        Me.chkPentade.UseVisualStyleBackColor = True
        '
        'chkDayYear
        '
        Me.chkDayYear.AutoSize = True
        Me.chkDayYear.Location = New System.Drawing.Point(7, 115)
        Me.chkDayYear.Name = "chkDayYear"
        Me.chkDayYear.Size = New System.Drawing.Size(108, 17)
        Me.chkDayYear.TabIndex = 6
        Me.chkDayYear.Text = "Day in Year (366)"
        Me.chkDayYear.UseVisualStyleBackColor = True
        '
        'chkMonth
        '
        Me.chkMonth.AutoSize = True
        Me.chkMonth.Location = New System.Drawing.Point(7, 43)
        Me.chkMonth.Name = "chkMonth"
        Me.chkMonth.Size = New System.Drawing.Size(56, 17)
        Me.chkMonth.TabIndex = 5
        Me.chkMonth.Text = "Month"
        Me.chkMonth.UseVisualStyleBackColor = True
        '
        'chkDayInYear
        '
        Me.chkDayInYear.AutoSize = True
        Me.chkDayInYear.Location = New System.Drawing.Point(101, 20)
        Me.chkDayInYear.Name = "chkDayInYear"
        Me.chkDayInYear.Size = New System.Drawing.Size(79, 17)
        Me.chkDayInYear.TabIndex = 3
        Me.chkDayInYear.Text = "Day in year"
        Me.chkDayInYear.UseVisualStyleBackColor = True
        '
        'chkDayInMonth
        '
        Me.chkDayInMonth.AutoSize = True
        Me.chkDayInMonth.Location = New System.Drawing.Point(7, 64)
        Me.chkDayInMonth.Name = "chkDayInMonth"
        Me.chkDayInMonth.Size = New System.Drawing.Size(89, 17)
        Me.chkDayInMonth.TabIndex = 2
        Me.chkDayInMonth.Text = "Day in Month"
        Me.chkDayInMonth.UseVisualStyleBackColor = True
        '
        'chkWeekDay
        '
        Me.chkWeekDay.AutoSize = True
        Me.chkWeekDay.Location = New System.Drawing.Point(101, 66)
        Me.chkWeekDay.Name = "chkWeekDay"
        Me.chkWeekDay.Size = New System.Drawing.Size(72, 17)
        Me.chkWeekDay.TabIndex = 1
        Me.chkWeekDay.Text = "Weekday"
        Me.chkWeekDay.UseVisualStyleBackColor = True
        '
        'chkYear
        '
        Me.chkYear.AutoSize = True
        Me.chkYear.Location = New System.Drawing.Point(7, 20)
        Me.chkYear.Name = "chkYear"
        Me.chkYear.Size = New System.Drawing.Size(48, 17)
        Me.chkYear.TabIndex = 0
        Me.chkYear.Text = "Year"
        Me.chkYear.UseVisualStyleBackColor = True
        '
        'ucrReceiverUseDate
        '
        Me.ucrReceiverUseDate.Location = New System.Drawing.Point(254, 39)
        Me.ucrReceiverUseDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverUseDate.Name = "ucrReceiverUseDate"
        Me.ucrReceiverUseDate.Selector = Nothing
        Me.ucrReceiverUseDate.Size = New System.Drawing.Size(151, 20)
        Me.ucrReceiverUseDate.TabIndex = 169
        '
        'ucrSaveDateResultInto
        '
        Me.ucrSaveDateResultInto.IsReadOnly = False
        Me.ucrSaveDateResultInto.Location = New System.Drawing.Point(125, 298)
        Me.ucrSaveDateResultInto.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrSaveDateResultInto.Name = "ucrSaveDateResultInto"
        Me.ucrSaveDateResultInto.Size = New System.Drawing.Size(280, 22)
        Me.ucrSaveDateResultInto.TabIndex = 160
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(14, 324)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(407, 52)
        Me.ucrBase.TabIndex = 2
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
        Me.ClientSize = New System.Drawing.Size(451, 380)
        Me.Controls.Add(Me.grpDateFunctions)
        Me.Controls.Add(Me.ucrReceiverUseDate)
        Me.Controls.Add(Me.lblDateVariable)
        Me.Controls.Add(Me.lblLabelColumns)
        Me.Controls.Add(Me.ucrSaveDateResultInto)
        Me.Controls.Add(Me.rdoAbrreviated)
        Me.Controls.Add(Me.chkSaveDateResultInto)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.rdoFull)
        Me.Controls.Add(Me.ucrSelectorUseDate)
        Me.Controls.Add(Me.rdoNone)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgUseDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Use date"
        Me.grpDateFunctions.ResumeLayout(False)
        Me.grpDateFunctions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorUseDate As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSaveDateResultInto As ucrInputComboBox
    Friend WithEvents chkSaveDateResultInto As CheckBox
    Friend WithEvents rdoAbrreviated As RadioButton
    Friend WithEvents rdoFull As RadioButton
    Friend WithEvents rdoNone As RadioButton
    Friend WithEvents lblLabelColumns As Label
    Friend WithEvents lblDateVariable As Label
    Friend WithEvents ucrReceiverUseDate As ucrReceiverSingle
    Friend WithEvents grpDateFunctions As GroupBox
    Friend WithEvents chkLeapYear As CheckBox
    Friend WithEvents chkDecade As CheckBox
    Friend WithEvents chkPentade As CheckBox
    Friend WithEvents chkDayYear As CheckBox
    Friend WithEvents chkMonth As CheckBox
    Friend WithEvents chkDayInYear As CheckBox
    Friend WithEvents chkDayInMonth As CheckBox
    Friend WithEvents chkWeekDay As CheckBox
    Friend WithEvents chkYear As CheckBox
    Friend WithEvents chkWeek As CheckBox
End Class
