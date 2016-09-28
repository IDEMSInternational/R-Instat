<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMakeDate
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
        Me.ucrSeclectorMakeDate = New instat.ucrSelectorByDataFrameAddRemove()
        Me.UcrInputNewColumnName = New instat.ucrInputComboBox()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.rdoSingleColumn = New System.Windows.Forms.RadioButton()
        Me.rdoYearandDayofYear = New System.Windows.Forms.RadioButton()
        Me.rdoYearMonthDay = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverDayTwo = New instat.ucrReceiverSingle()
        Me.lblSingleColumn = New System.Windows.Forms.Label()
        Me.grpTwoColumns = New System.Windows.Forms.GroupBox()
        Me.UcrReceiverSingle4 = New instat.ucrReceiverSingle()
        Me.lblDayofYear = New System.Windows.Forms.Label()
        Me.UcrReceiverSingle = New instat.ucrReceiverSingle()
        Me.grpThreeColumns = New System.Windows.Forms.GroupBox()
        Me.lblDayofMonth = New System.Windows.Forms.Label()
        Me.lblMonthThree = New System.Windows.Forms.Label()
        Me.lblYearThree = New System.Windows.Forms.Label()
        Me.UcrReceiverSingle2 = New instat.ucrReceiverSingle()
        Me.ucrReceiverYearThree = New instat.ucrReceiverSingle()
        Me.ucrReceiverDayThree = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonthThree = New instat.ucrReceiverSingle()
        Me.ucrReceiverYearTwo = New instat.ucrReceiverSingle()
        Me.lblYearTwo = New System.Windows.Forms.Label()
        Me.ucrinputComboBoxMonthTwo = New instat.ucrInputComboBox()
        Me.ucrinputComboBoxYearTwo = New instat.ucrInputComboBox()
        Me.UcrInputComboBoxTearThree = New instat.ucrInputComboBox()
        Me.grpTwoColumns.SuspendLayout()
        Me.grpThreeColumns.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrSeclectorMakeDate
        '
        Me.ucrSeclectorMakeDate.bShowHiddenColumns = False
        Me.ucrSeclectorMakeDate.bUseCurrentFilter = False
        Me.ucrSeclectorMakeDate.Location = New System.Drawing.Point(9, 42)
        Me.ucrSeclectorMakeDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSeclectorMakeDate.Name = "ucrSeclectorMakeDate"
        Me.ucrSeclectorMakeDate.Size = New System.Drawing.Size(210, 180)
        Me.ucrSeclectorMakeDate.TabIndex = 0
        '
        'UcrInputNewColumnName
        '
        Me.UcrInputNewColumnName.IsReadOnly = False
        Me.UcrInputNewColumnName.Location = New System.Drawing.Point(111, 353)
        Me.UcrInputNewColumnName.Name = "UcrInputNewColumnName"
        Me.UcrInputNewColumnName.Size = New System.Drawing.Size(159, 21)
        Me.UcrInputNewColumnName.TabIndex = 3
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(12, 353)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(98, 13)
        Me.lblNewColumnName.TabIndex = 4
        Me.lblNewColumnName.Text = "New Column Name"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 377)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 5
        '
        'rdoSingleColumn
        '
        Me.rdoSingleColumn.AutoSize = True
        Me.rdoSingleColumn.Location = New System.Drawing.Point(9, 12)
        Me.rdoSingleColumn.Name = "rdoSingleColumn"
        Me.rdoSingleColumn.Size = New System.Drawing.Size(92, 17)
        Me.rdoSingleColumn.TabIndex = 6
        Me.rdoSingleColumn.TabStop = True
        Me.rdoSingleColumn.Text = "Single Column"
        Me.rdoSingleColumn.UseVisualStyleBackColor = True
        '
        'rdoYearandDayofYear
        '
        Me.rdoYearandDayofYear.AutoSize = True
        Me.rdoYearandDayofYear.Location = New System.Drawing.Point(112, 12)
        Me.rdoYearandDayofYear.Name = "rdoYearandDayofYear"
        Me.rdoYearandDayofYear.Size = New System.Drawing.Size(127, 17)
        Me.rdoYearandDayofYear.TabIndex = 6
        Me.rdoYearandDayofYear.TabStop = True
        Me.rdoYearandDayofYear.Text = "Year and Day of Year"
        Me.rdoYearandDayofYear.UseVisualStyleBackColor = True
        '
        'rdoYearMonthDay
        '
        Me.rdoYearMonthDay.AutoSize = True
        Me.rdoYearMonthDay.Location = New System.Drawing.Point(244, 12)
        Me.rdoYearMonthDay.Name = "rdoYearMonthDay"
        Me.rdoYearMonthDay.Size = New System.Drawing.Size(114, 17)
        Me.rdoYearMonthDay.TabIndex = 6
        Me.rdoYearMonthDay.TabStop = True
        Me.rdoYearMonthDay.Text = "Year - Month - Day"
        Me.rdoYearMonthDay.UseVisualStyleBackColor = True
        '
        'ucrReceiverDayTwo
        '
        Me.ucrReceiverDayTwo.Location = New System.Drawing.Point(3, 73)
        Me.ucrReceiverDayTwo.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDayTwo.Name = "ucrReceiverDayTwo"
        Me.ucrReceiverDayTwo.Selector = Nothing
        Me.ucrReceiverDayTwo.Size = New System.Drawing.Size(95, 20)
        Me.ucrReceiverDayTwo.TabIndex = 7
        '
        'lblSingleColumn
        '
        Me.lblSingleColumn.AutoSize = True
        Me.lblSingleColumn.Location = New System.Drawing.Point(284, 41)
        Me.lblSingleColumn.Name = "lblSingleColumn"
        Me.lblSingleColumn.Size = New System.Drawing.Size(74, 13)
        Me.lblSingleColumn.TabIndex = 8
        Me.lblSingleColumn.Text = "Single Column"
        '
        'grpTwoColumns
        '
        Me.grpTwoColumns.Controls.Add(Me.ucrinputComboBoxYearTwo)
        Me.grpTwoColumns.Controls.Add(Me.ucrinputComboBoxMonthTwo)
        Me.grpTwoColumns.Controls.Add(Me.UcrReceiverSingle4)
        Me.grpTwoColumns.Controls.Add(Me.lblYearTwo)
        Me.grpTwoColumns.Controls.Add(Me.ucrReceiverYearTwo)
        Me.grpTwoColumns.Controls.Add(Me.lblDayofYear)
        Me.grpTwoColumns.Controls.Add(Me.ucrReceiverDayTwo)
        Me.grpTwoColumns.Location = New System.Drawing.Point(284, 88)
        Me.grpTwoColumns.Name = "grpTwoColumns"
        Me.grpTwoColumns.Size = New System.Drawing.Size(228, 106)
        Me.grpTwoColumns.TabIndex = 9
        Me.grpTwoColumns.TabStop = False
        Me.grpTwoColumns.Text = "Two Columns"
        '
        'UcrReceiverSingle4
        '
        Me.UcrReceiverSingle4.Location = New System.Drawing.Point(0, -40)
        Me.UcrReceiverSingle4.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverSingle4.Name = "UcrReceiverSingle4"
        Me.UcrReceiverSingle4.Selector = Nothing
        Me.UcrReceiverSingle4.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverSingle4.TabIndex = 7
        '
        'lblDayofYear
        '
        Me.lblDayofYear.AutoSize = True
        Me.lblDayofYear.Location = New System.Drawing.Point(4, 57)
        Me.lblDayofYear.Name = "lblDayofYear"
        Me.lblDayofYear.Size = New System.Drawing.Size(63, 13)
        Me.lblDayofYear.TabIndex = 8
        Me.lblDayofYear.Text = "Day of Year"
        '
        'UcrReceiverSingle
        '
        Me.UcrReceiverSingle.Location = New System.Drawing.Point(284, 57)
        Me.UcrReceiverSingle.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverSingle.Name = "UcrReceiverSingle"
        Me.UcrReceiverSingle.Selector = Nothing
        Me.UcrReceiverSingle.Size = New System.Drawing.Size(129, 20)
        Me.UcrReceiverSingle.TabIndex = 7
        '
        'grpThreeColumns
        '
        Me.grpThreeColumns.Controls.Add(Me.UcrInputComboBoxTearThree)
        Me.grpThreeColumns.Controls.Add(Me.lblDayofMonth)
        Me.grpThreeColumns.Controls.Add(Me.lblMonthThree)
        Me.grpThreeColumns.Controls.Add(Me.lblYearThree)
        Me.grpThreeColumns.Controls.Add(Me.UcrReceiverSingle2)
        Me.grpThreeColumns.Controls.Add(Me.ucrReceiverYearThree)
        Me.grpThreeColumns.Controls.Add(Me.ucrReceiverDayThree)
        Me.grpThreeColumns.Controls.Add(Me.ucrReceiverMonthThree)
        Me.grpThreeColumns.Location = New System.Drawing.Point(284, 211)
        Me.grpThreeColumns.Name = "grpThreeColumns"
        Me.grpThreeColumns.Size = New System.Drawing.Size(228, 143)
        Me.grpThreeColumns.TabIndex = 9
        Me.grpThreeColumns.TabStop = False
        Me.grpThreeColumns.Text = "Three Columns"
        '
        'lblDayofMonth
        '
        Me.lblDayofMonth.AutoSize = True
        Me.lblDayofMonth.Location = New System.Drawing.Point(4, 99)
        Me.lblDayofMonth.Name = "lblDayofMonth"
        Me.lblDayofMonth.Size = New System.Drawing.Size(71, 13)
        Me.lblDayofMonth.TabIndex = 8
        Me.lblDayofMonth.Text = "Day of Month"
        '
        'lblMonthThree
        '
        Me.lblMonthThree.AutoSize = True
        Me.lblMonthThree.Location = New System.Drawing.Point(4, 57)
        Me.lblMonthThree.Name = "lblMonthThree"
        Me.lblMonthThree.Size = New System.Drawing.Size(37, 13)
        Me.lblMonthThree.TabIndex = 8
        Me.lblMonthThree.Text = "Month"
        '
        'lblYearThree
        '
        Me.lblYearThree.AutoSize = True
        Me.lblYearThree.Location = New System.Drawing.Point(5, 16)
        Me.lblYearThree.Name = "lblYearThree"
        Me.lblYearThree.Size = New System.Drawing.Size(29, 13)
        Me.lblYearThree.TabIndex = 8
        Me.lblYearThree.Text = "Year"
        '
        'UcrReceiverSingle2
        '
        Me.UcrReceiverSingle2.Location = New System.Drawing.Point(0, -40)
        Me.UcrReceiverSingle2.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverSingle2.Name = "UcrReceiverSingle2"
        Me.UcrReceiverSingle2.Selector = Nothing
        Me.UcrReceiverSingle2.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverSingle2.TabIndex = 7
        '
        'ucrReceiverYearThree
        '
        Me.ucrReceiverYearThree.Location = New System.Drawing.Point(2, 30)
        Me.ucrReceiverYearThree.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYearThree.Name = "ucrReceiverYearThree"
        Me.ucrReceiverYearThree.Selector = Nothing
        Me.ucrReceiverYearThree.Size = New System.Drawing.Size(96, 20)
        Me.ucrReceiverYearThree.TabIndex = 7
        '
        'ucrReceiverDayThree
        '
        Me.ucrReceiverDayThree.Location = New System.Drawing.Point(3, 113)
        Me.ucrReceiverDayThree.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDayThree.Name = "ucrReceiverDayThree"
        Me.ucrReceiverDayThree.Selector = Nothing
        Me.ucrReceiverDayThree.Size = New System.Drawing.Size(95, 20)
        Me.ucrReceiverDayThree.TabIndex = 7
        '
        'ucrReceiverMonthThree
        '
        Me.ucrReceiverMonthThree.Location = New System.Drawing.Point(2, 71)
        Me.ucrReceiverMonthThree.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonthThree.Name = "ucrReceiverMonthThree"
        Me.ucrReceiverMonthThree.Selector = Nothing
        Me.ucrReceiverMonthThree.Size = New System.Drawing.Size(96, 20)
        Me.ucrReceiverMonthThree.TabIndex = 7
        '
        'ucrReceiverYearTwo
        '
        Me.ucrReceiverYearTwo.Location = New System.Drawing.Point(3, 29)
        Me.ucrReceiverYearTwo.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYearTwo.Name = "ucrReceiverYearTwo"
        Me.ucrReceiverYearTwo.Selector = Nothing
        Me.ucrReceiverYearTwo.Size = New System.Drawing.Size(95, 20)
        Me.ucrReceiverYearTwo.TabIndex = 7
        '
        'lblYearTwo
        '
        Me.lblYearTwo.AutoSize = True
        Me.lblYearTwo.Location = New System.Drawing.Point(3, 16)
        Me.lblYearTwo.Name = "lblYearTwo"
        Me.lblYearTwo.Size = New System.Drawing.Size(29, 13)
        Me.lblYearTwo.TabIndex = 8
        Me.lblYearTwo.Text = "Year"
        '
        'ucrinputComboBoxMonthTwo
        '
        Me.ucrinputComboBoxMonthTwo.IsReadOnly = False
        Me.ucrinputComboBoxMonthTwo.Location = New System.Drawing.Point(123, 73)
        Me.ucrinputComboBoxMonthTwo.Name = "ucrinputComboBoxMonthTwo"
        Me.ucrinputComboBoxMonthTwo.Size = New System.Drawing.Size(88, 21)
        Me.ucrinputComboBoxMonthTwo.TabIndex = 10
        '
        'ucrinputComboBoxYearTwo
        '
        Me.ucrinputComboBoxYearTwo.IsReadOnly = False
        Me.ucrinputComboBoxYearTwo.Location = New System.Drawing.Point(123, 28)
        Me.ucrinputComboBoxYearTwo.Name = "ucrinputComboBoxYearTwo"
        Me.ucrinputComboBoxYearTwo.Size = New System.Drawing.Size(88, 21)
        Me.ucrinputComboBoxYearTwo.TabIndex = 10
        '
        'UcrInputComboBoxTearThree
        '
        Me.UcrInputComboBoxTearThree.IsReadOnly = False
        Me.UcrInputComboBoxTearThree.Location = New System.Drawing.Point(123, 29)
        Me.UcrInputComboBoxTearThree.Name = "UcrInputComboBoxTearThree"
        Me.UcrInputComboBoxTearThree.Size = New System.Drawing.Size(88, 21)
        Me.UcrInputComboBoxTearThree.TabIndex = 10
        '
        'dlgMakeDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 435)
        Me.Controls.Add(Me.UcrReceiverSingle)
        Me.Controls.Add(Me.grpThreeColumns)
        Me.Controls.Add(Me.grpTwoColumns)
        Me.Controls.Add(Me.lblSingleColumn)
        Me.Controls.Add(Me.rdoYearMonthDay)
        Me.Controls.Add(Me.rdoYearandDayofYear)
        Me.Controls.Add(Me.rdoSingleColumn)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.UcrInputNewColumnName)
        Me.Controls.Add(Me.ucrSeclectorMakeDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMakeDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Make Date"
        Me.grpTwoColumns.ResumeLayout(False)
        Me.grpTwoColumns.PerformLayout()
        Me.grpThreeColumns.ResumeLayout(False)
        Me.grpThreeColumns.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSeclectorMakeDate As ucrSelectorByDataFrameAddRemove
    Friend WithEvents UcrInputNewColumnName As ucrInputComboBox
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents rdoSingleColumn As RadioButton
    Friend WithEvents rdoYearandDayofYear As RadioButton
    Friend WithEvents rdoYearMonthDay As RadioButton
    Friend WithEvents ucrReceiverDayTwo As ucrReceiverSingle
    Friend WithEvents lblSingleColumn As Label
    Friend WithEvents grpTwoColumns As GroupBox
    Friend WithEvents UcrReceiverSingle4 As ucrReceiverSingle
    Friend WithEvents UcrReceiverSingle As ucrReceiverSingle
    Friend WithEvents grpThreeColumns As GroupBox
    Friend WithEvents UcrReceiverSingle2 As ucrReceiverSingle
    Friend WithEvents ucrReceiverYearThree As ucrReceiverSingle
    Friend WithEvents ucrReceiverDayThree As ucrReceiverSingle
    Friend WithEvents ucrReceiverMonthThree As ucrReceiverSingle
    Friend WithEvents lblDayofMonth As Label
    Friend WithEvents lblMonthThree As Label
    Friend WithEvents lblDayofYear As Label
    Friend WithEvents lblYearThree As Label
    Friend WithEvents lblYearTwo As Label
    Friend WithEvents ucrReceiverYearTwo As ucrReceiverSingle
    Friend WithEvents ucrinputComboBoxYearTwo As ucrInputComboBox
    Friend WithEvents ucrinputComboBoxMonthTwo As ucrInputComboBox
    Friend WithEvents UcrInputComboBoxTearThree As ucrInputComboBox
End Class
