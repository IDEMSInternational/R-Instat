<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgDisplayDaily
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
        Me.chkPrintTables = New System.Windows.Forms.CheckBox()
        Me.chkRemoveNA = New System.Windows.Forms.CheckBox()
        Me.nudDecimalPlaces = New System.Windows.Forms.NumericUpDown()
        Me.nudThreshold = New System.Windows.Forms.NumericUpDown()
        Me.txtSummaryNames = New System.Windows.Forms.TextBox()
        Me.txtDayDisplay = New System.Windows.Forms.TextBox()
        Me.txtVariable = New System.Windows.Forms.TextBox()
        Me.txtMonthSummaries = New System.Windows.Forms.TextBox()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.lblDayDisplay = New System.Windows.Forms.Label()
        Me.lblDecimalPlaces = New System.Windows.Forms.Label()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.lblSummaryNames = New System.Windows.Forms.Label()
        Me.lblMonth_Summaries = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkMonthAbbreviation = New System.Windows.Forms.CheckBox()
        Me.ucrBase = New instat.ucrButtons()
        CType(Me.nudDecimalPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkPrintTables
        '
        Me.chkPrintTables.AutoSize = True
        Me.chkPrintTables.Location = New System.Drawing.Point(194, 220)
        Me.chkPrintTables.Name = "chkPrintTables"
        Me.chkPrintTables.Size = New System.Drawing.Size(81, 17)
        Me.chkPrintTables.TabIndex = 1
        Me.chkPrintTables.Tag = "Print_Tables"
        Me.chkPrintTables.Text = "CheckBox1"
        Me.chkPrintTables.UseVisualStyleBackColor = True
        '
        'chkRemoveNA
        '
        Me.chkRemoveNA.AutoSize = True
        Me.chkRemoveNA.Location = New System.Drawing.Point(346, 220)
        Me.chkRemoveNA.Name = "chkRemoveNA"
        Me.chkRemoveNA.Size = New System.Drawing.Size(81, 17)
        Me.chkRemoveNA.TabIndex = 2
        Me.chkRemoveNA.Tag = "Remove_NA"
        Me.chkRemoveNA.Text = "CheckBox2"
        Me.chkRemoveNA.UseVisualStyleBackColor = True
        '
        'nudDecimalPlaces
        '
        Me.nudDecimalPlaces.Location = New System.Drawing.Point(346, 132)
        Me.nudDecimalPlaces.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudDecimalPlaces.Name = "nudDecimalPlaces"
        Me.nudDecimalPlaces.Size = New System.Drawing.Size(67, 20)
        Me.nudDecimalPlaces.TabIndex = 3
        '
        'nudThreshold
        '
        Me.nudThreshold.Location = New System.Drawing.Point(109, 127)
        Me.nudThreshold.Name = "nudThreshold"
        Me.nudThreshold.Size = New System.Drawing.Size(76, 20)
        Me.nudThreshold.TabIndex = 4
        '
        'txtSummaryNames
        '
        Me.txtSummaryNames.Location = New System.Drawing.Point(109, 170)
        Me.txtSummaryNames.Name = "txtSummaryNames"
        Me.txtSummaryNames.Size = New System.Drawing.Size(100, 20)
        Me.txtSummaryNames.TabIndex = 5
        '
        'txtDayDisplay
        '
        Me.txtDayDisplay.Location = New System.Drawing.Point(194, 91)
        Me.txtDayDisplay.Name = "txtDayDisplay"
        Me.txtDayDisplay.Size = New System.Drawing.Size(100, 20)
        Me.txtDayDisplay.TabIndex = 6
        Me.txtDayDisplay.Tag = ""
        '
        'txtVariable
        '
        Me.txtVariable.Location = New System.Drawing.Point(194, 58)
        Me.txtVariable.Name = "txtVariable"
        Me.txtVariable.Size = New System.Drawing.Size(100, 20)
        Me.txtVariable.TabIndex = 7
        '
        'txtMonthSummaries
        '
        Me.txtMonthSummaries.Location = New System.Drawing.Point(194, 32)
        Me.txtMonthSummaries.Name = "txtMonthSummaries"
        Me.txtMonthSummaries.Size = New System.Drawing.Size(100, 20)
        Me.txtMonthSummaries.TabIndex = 8
        Me.txtMonthSummaries.Tag = ""
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.Location = New System.Drawing.Point(27, 65)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(39, 13)
        Me.lblVariable.TabIndex = 10
        Me.lblVariable.Tag = "Variable"
        Me.lblVariable.Text = "Label1"
        '
        'lblDayDisplay
        '
        Me.lblDayDisplay.AutoSize = True
        Me.lblDayDisplay.Location = New System.Drawing.Point(27, 94)
        Me.lblDayDisplay.Name = "lblDayDisplay"
        Me.lblDayDisplay.Size = New System.Drawing.Size(39, 13)
        Me.lblDayDisplay.TabIndex = 11
        Me.lblDayDisplay.Tag = "Day_Display"
        Me.lblDayDisplay.Text = "Label2"
        '
        'lblDecimalPlaces
        '
        Me.lblDecimalPlaces.AutoSize = True
        Me.lblDecimalPlaces.Location = New System.Drawing.Point(236, 134)
        Me.lblDecimalPlaces.Name = "lblDecimalPlaces"
        Me.lblDecimalPlaces.Size = New System.Drawing.Size(39, 13)
        Me.lblDecimalPlaces.TabIndex = 12
        Me.lblDecimalPlaces.Tag = "Decimal_Places"
        Me.lblDecimalPlaces.Text = "Label3"
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(27, 134)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(39, 13)
        Me.lblThreshold.TabIndex = 13
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Label4"
        '
        'lblSummaryNames
        '
        Me.lblSummaryNames.AutoSize = True
        Me.lblSummaryNames.Location = New System.Drawing.Point(27, 177)
        Me.lblSummaryNames.Name = "lblSummaryNames"
        Me.lblSummaryNames.Size = New System.Drawing.Size(39, 13)
        Me.lblSummaryNames.TabIndex = 14
        Me.lblSummaryNames.Tag = "Summary_Names"
        Me.lblSummaryNames.Text = "Label5"
        '
        'lblMonth_Summaries
        '
        Me.lblMonth_Summaries.AutoSize = True
        Me.lblMonth_Summaries.Location = New System.Drawing.Point(27, 39)
        Me.lblMonth_Summaries.Name = "lblMonth_Summaries"
        Me.lblMonth_Summaries.Size = New System.Drawing.Size(39, 13)
        Me.lblMonth_Summaries.TabIndex = 16
        Me.lblMonth_Summaries.Tag = "Month_Summaries"
        Me.lblMonth_Summaries.Text = "Label7"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Not implememted"
        '
        'chkMonthAbbreviation
        '
        Me.chkMonthAbbreviation.AutoSize = True
        Me.chkMonthAbbreviation.Location = New System.Drawing.Point(30, 220)
        Me.chkMonthAbbreviation.Name = "chkMonthAbbreviation"
        Me.chkMonthAbbreviation.Size = New System.Drawing.Size(81, 17)
        Me.chkMonthAbbreviation.TabIndex = 18
        Me.chkMonthAbbreviation.Tag = "Month_Abbreviation"
        Me.chkMonthAbbreviation.Text = "CheckBox1"
        Me.chkMonthAbbreviation.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(30, 284)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 56)
        Me.ucrBase.TabIndex = 0
        '
        'dlgDisplayDaily
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 352)
        Me.Controls.Add(Me.chkMonthAbbreviation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblMonth_Summaries)
        Me.Controls.Add(Me.lblSummaryNames)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.lblDecimalPlaces)
        Me.Controls.Add(Me.lblDayDisplay)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.txtMonthSummaries)
        Me.Controls.Add(Me.txtVariable)
        Me.Controls.Add(Me.txtDayDisplay)
        Me.Controls.Add(Me.txtSummaryNames)
        Me.Controls.Add(Me.nudThreshold)
        Me.Controls.Add(Me.nudDecimalPlaces)
        Me.Controls.Add(Me.chkRemoveNA)
        Me.Controls.Add(Me.chkPrintTables)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDisplayDaily"
        Me.Tag = "Display_Daily"
        Me.Text = "Display Daily"
        CType(Me.nudDecimalPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkPrintTables As CheckBox
    Friend WithEvents chkRemoveNA As CheckBox
    Friend WithEvents nudDecimalPlaces As NumericUpDown
    Friend WithEvents nudThreshold As NumericUpDown
    Friend WithEvents txtSummaryNames As TextBox
    Friend WithEvents txtDayDisplay As TextBox
    Friend WithEvents txtVariable As TextBox
    Friend WithEvents txtMonthSummaries As TextBox
    Friend WithEvents lblVariable As Label
    Friend WithEvents lblDayDisplay As Label
    Friend WithEvents lblDecimalPlaces As Label
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lblSummaryNames As Label
    Friend WithEvents lblMonth_Summaries As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents chkMonthAbbreviation As CheckBox
End Class
