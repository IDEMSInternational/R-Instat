<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgDisplayDOYofYear
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
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDayDisplay = New System.Windows.Forms.Label()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.lblNAString = New System.Windows.Forms.Label()
        Me.lblFontSize = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblHeaderFontSize = New System.Windows.Forms.Label()
        Me.chkMonthAbbreviations = New System.Windows.Forms.CheckBox()
        Me.chkSaveTable = New System.Windows.Forms.CheckBox()
        Me.chkRowNames = New System.Windows.Forms.CheckBox()
        Me.nudHeight = New System.Windows.Forms.NumericUpDown()
        Me.nudHeaderFontSize = New System.Windows.Forms.NumericUpDown()
        Me.nudFontSize = New System.Windows.Forms.NumericUpDown()
        Me.nudWidth = New System.Windows.Forms.NumericUpDown()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.ucrInputDisplayDaily = New instat.ucrInputTextBox()
        Me.ucrInputFile = New instat.ucrInputTextBox()
        Me.ucrInputMissingValues = New instat.ucrInputTextBox()
        CType(Me.nudHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHeaderFontSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFontSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(37, 205)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(38, 13)
        Me.lblHeight.TabIndex = 6
        Me.lblHeight.Tag = "Height"
        Me.lblHeight.Text = "Height"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(37, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Tag = "Title"
        Me.lblTitle.Text = "Title"
        '
        'lblDayDisplay
        '
        Me.lblDayDisplay.AutoSize = True
        Me.lblDayDisplay.Location = New System.Drawing.Point(37, 47)
        Me.lblDayDisplay.Name = "lblDayDisplay"
        Me.lblDayDisplay.Size = New System.Drawing.Size(63, 13)
        Me.lblDayDisplay.TabIndex = 8
        Me.lblDayDisplay.Tag = "Display_Day"
        Me.lblDayDisplay.Text = "Display Day"
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(37, 74)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(23, 13)
        Me.lblFile.TabIndex = 9
        Me.lblFile.Tag = "File"
        Me.lblFile.Text = "File"
        '
        'lblNAString
        '
        Me.lblNAString.AutoSize = True
        Me.lblNAString.Location = New System.Drawing.Point(37, 101)
        Me.lblNAString.Name = "lblNAString"
        Me.lblNAString.Size = New System.Drawing.Size(77, 13)
        Me.lblNAString.TabIndex = 10
        Me.lblNAString.Tag = "Missing_Values"
        Me.lblNAString.Text = "Missing Values"
        '
        'lblFontSize
        '
        Me.lblFontSize.AutoSize = True
        Me.lblFontSize.Location = New System.Drawing.Point(37, 127)
        Me.lblFontSize.Name = "lblFontSize"
        Me.lblFontSize.Size = New System.Drawing.Size(51, 13)
        Me.lblFontSize.TabIndex = 11
        Me.lblFontSize.Tag = "Font_Size"
        Me.lblFontSize.Text = "Font Size"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(37, 153)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(35, 13)
        Me.lblWidth.TabIndex = 12
        Me.lblWidth.Tag = "Width"
        Me.lblWidth.Text = "Width"
        '
        'lblHeaderFontSize
        '
        Me.lblHeaderFontSize.AutoSize = True
        Me.lblHeaderFontSize.Location = New System.Drawing.Point(37, 179)
        Me.lblHeaderFontSize.Name = "lblHeaderFontSize"
        Me.lblHeaderFontSize.Size = New System.Drawing.Size(89, 13)
        Me.lblHeaderFontSize.TabIndex = 13
        Me.lblHeaderFontSize.Tag = "Header_Font_Size"
        Me.lblHeaderFontSize.Text = "Header Font Size"
        '
        'chkMonthAbbreviations
        '
        Me.chkMonthAbbreviations.AutoSize = True
        Me.chkMonthAbbreviations.Location = New System.Drawing.Point(144, 224)
        Me.chkMonthAbbreviations.Name = "chkMonthAbbreviations"
        Me.chkMonthAbbreviations.Size = New System.Drawing.Size(123, 17)
        Me.chkMonthAbbreviations.TabIndex = 14
        Me.chkMonthAbbreviations.Tag = "Month_Abbreviations"
        Me.chkMonthAbbreviations.Text = "Month Abbreviations"
        Me.chkMonthAbbreviations.UseVisualStyleBackColor = True
        '
        'chkSaveTable
        '
        Me.chkSaveTable.AutoSize = True
        Me.chkSaveTable.Location = New System.Drawing.Point(322, 224)
        Me.chkSaveTable.Name = "chkSaveTable"
        Me.chkSaveTable.Size = New System.Drawing.Size(81, 17)
        Me.chkSaveTable.TabIndex = 15
        Me.chkSaveTable.Tag = "Save_Table"
        Me.chkSaveTable.Text = "Save Table"
        Me.chkSaveTable.UseVisualStyleBackColor = True
        '
        'chkRowNames
        '
        Me.chkRowNames.AutoSize = True
        Me.chkRowNames.Location = New System.Drawing.Point(30, 221)
        Me.chkRowNames.Name = "chkRowNames"
        Me.chkRowNames.Size = New System.Drawing.Size(84, 17)
        Me.chkRowNames.TabIndex = 16
        Me.chkRowNames.Tag = "Row_Names"
        Me.chkRowNames.Text = "Row Names"
        Me.chkRowNames.UseVisualStyleBackColor = True
        '
        'nudHeight
        '
        Me.nudHeight.Location = New System.Drawing.Point(144, 198)
        Me.nudHeight.Name = "nudHeight"
        Me.nudHeight.Size = New System.Drawing.Size(74, 20)
        Me.nudHeight.TabIndex = 17
        '
        'nudHeaderFontSize
        '
        Me.nudHeaderFontSize.Location = New System.Drawing.Point(144, 172)
        Me.nudHeaderFontSize.Name = "nudHeaderFontSize"
        Me.nudHeaderFontSize.Size = New System.Drawing.Size(74, 20)
        Me.nudHeaderFontSize.TabIndex = 18
        '
        'nudFontSize
        '
        Me.nudFontSize.Location = New System.Drawing.Point(144, 120)
        Me.nudFontSize.Name = "nudFontSize"
        Me.nudFontSize.Size = New System.Drawing.Size(74, 20)
        Me.nudFontSize.TabIndex = 19
        '
        'nudWidth
        '
        Me.nudWidth.Location = New System.Drawing.Point(144, 146)
        Me.nudWidth.Name = "nudWidth"
        Me.nudWidth.Size = New System.Drawing.Size(74, 20)
        Me.nudWidth.TabIndex = 20
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 247)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 57)
        Me.ucrBase.TabIndex = 0
        '
        'ucrInputTitle
        '
        Me.ucrInputTitle.IsReadOnly = False
        Me.ucrInputTitle.Location = New System.Drawing.Point(144, 12)
        Me.ucrInputTitle.Name = "ucrInputTitle"
        Me.ucrInputTitle.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputTitle.TabIndex = 21
        '
        'ucrInputDisplayDaily
        '
        Me.ucrInputDisplayDaily.IsReadOnly = False
        Me.ucrInputDisplayDaily.Location = New System.Drawing.Point(144, 39)
        Me.ucrInputDisplayDaily.Name = "ucrInputDisplayDaily"
        Me.ucrInputDisplayDaily.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputDisplayDaily.TabIndex = 22
        '
        'ucrInputFile
        '
        Me.ucrInputFile.IsReadOnly = False
        Me.ucrInputFile.Location = New System.Drawing.Point(144, 66)
        Me.ucrInputFile.Name = "ucrInputFile"
        Me.ucrInputFile.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputFile.TabIndex = 22
        '
        'ucrInputMissingValues
        '
        Me.ucrInputMissingValues.IsReadOnly = False
        Me.ucrInputMissingValues.Location = New System.Drawing.Point(144, 93)
        Me.ucrInputMissingValues.Name = "ucrInputMissingValues"
        Me.ucrInputMissingValues.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputMissingValues.TabIndex = 22
        '
        'dlgDisplayDOYofYear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 307)
        Me.Controls.Add(Me.ucrInputMissingValues)
        Me.Controls.Add(Me.ucrInputFile)
        Me.Controls.Add(Me.ucrInputDisplayDaily)
        Me.Controls.Add(Me.ucrInputTitle)
        Me.Controls.Add(Me.nudWidth)
        Me.Controls.Add(Me.nudFontSize)
        Me.Controls.Add(Me.nudHeaderFontSize)
        Me.Controls.Add(Me.nudHeight)
        Me.Controls.Add(Me.chkRowNames)
        Me.Controls.Add(Me.chkSaveTable)
        Me.Controls.Add(Me.chkMonthAbbreviations)
        Me.Controls.Add(Me.lblHeaderFontSize)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblFontSize)
        Me.Controls.Add(Me.lblNAString)
        Me.Controls.Add(Me.lblFile)
        Me.Controls.Add(Me.lblDayDisplay)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDisplayDOYofYear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Display_DOY_of_Year"
        Me.Text = "Display Day Of Year"
        CType(Me.nudHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHeaderFontSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFontSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDayDisplay As Label
    Friend WithEvents lblFile As Label
    Friend WithEvents lblNAString As Label
    Friend WithEvents lblFontSize As Label
    Friend WithEvents lblWidth As Label
    Friend WithEvents lblHeaderFontSize As Label
    Friend WithEvents chkMonthAbbreviations As CheckBox
    Friend WithEvents chkSaveTable As CheckBox
    Friend WithEvents chkRowNames As CheckBox
    Friend WithEvents nudHeight As NumericUpDown
    Friend WithEvents nudHeaderFontSize As NumericUpDown
    Friend WithEvents nudFontSize As NumericUpDown
    Friend WithEvents nudWidth As NumericUpDown
    Friend WithEvents ucrInputTitle As ucrInputTextBox
    Friend WithEvents ucrInputDisplayDaily As ucrInputTextBox
    Friend WithEvents ucrInputFile As ucrInputTextBox
    Friend WithEvents ucrInputMissingValues As ucrInputTextBox
End Class
