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
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.txtDayDisplay = New System.Windows.Forms.TextBox()
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
        CType(Me.nudHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHeaderFontSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFontSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(144, 36)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(197, 20)
        Me.txtTitle.TabIndex = 1
        Me.txtTitle.Tag = "Title"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(144, 114)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 3
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(144, 88)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(100, 20)
        Me.txtFile.TabIndex = 4
        Me.txtFile.Tag = ""
        '
        'txtDayDisplay
        '
        Me.txtDayDisplay.Location = New System.Drawing.Point(144, 62)
        Me.txtDayDisplay.Name = "txtDayDisplay"
        Me.txtDayDisplay.Size = New System.Drawing.Size(100, 20)
        Me.txtDayDisplay.TabIndex = 5
        Me.txtDayDisplay.Tag = ""
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(37, 266)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(39, 13)
        Me.lblHeight.TabIndex = 6
        Me.lblHeight.Tag = "Height"
        Me.lblHeight.Text = "Label1"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(35, 36)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(39, 13)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Tag = "Title"
        Me.lblTitle.Text = "Label2"
        '
        'lblDayDisplay
        '
        Me.lblDayDisplay.AutoSize = True
        Me.lblDayDisplay.Location = New System.Drawing.Point(35, 65)
        Me.lblDayDisplay.Name = "lblDayDisplay"
        Me.lblDayDisplay.Size = New System.Drawing.Size(39, 13)
        Me.lblDayDisplay.TabIndex = 8
        Me.lblDayDisplay.Tag = "Day_Display"
        Me.lblDayDisplay.Text = "Label3"
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(35, 95)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(39, 13)
        Me.lblFile.TabIndex = 9
        Me.lblFile.Tag = "File"
        Me.lblFile.Text = "Label4"
        '
        'lblNAString
        '
        Me.lblNAString.AutoSize = True
        Me.lblNAString.Location = New System.Drawing.Point(37, 121)
        Me.lblNAString.Name = "lblNAString"
        Me.lblNAString.Size = New System.Drawing.Size(39, 13)
        Me.lblNAString.TabIndex = 10
        Me.lblNAString.Tag = "NA_String"
        Me.lblNAString.Text = "Label5"
        '
        'lblFontSize
        '
        Me.lblFontSize.AutoSize = True
        Me.lblFontSize.Location = New System.Drawing.Point(37, 190)
        Me.lblFontSize.Name = "lblFontSize"
        Me.lblFontSize.Size = New System.Drawing.Size(39, 13)
        Me.lblFontSize.TabIndex = 11
        Me.lblFontSize.Tag = "Font_Size"
        Me.lblFontSize.Text = "Label6"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(37, 216)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(39, 13)
        Me.lblWidth.TabIndex = 12
        Me.lblWidth.Tag = "Width"
        Me.lblWidth.Text = "Label7"
        '
        'lblHeaderFontSize
        '
        Me.lblHeaderFontSize.AutoSize = True
        Me.lblHeaderFontSize.Location = New System.Drawing.Point(35, 242)
        Me.lblHeaderFontSize.Name = "lblHeaderFontSize"
        Me.lblHeaderFontSize.Size = New System.Drawing.Size(39, 13)
        Me.lblHeaderFontSize.TabIndex = 13
        Me.lblHeaderFontSize.Tag = "Header_Font_Size"
        Me.lblHeaderFontSize.Text = "Label8"
        '
        'chkMonthAbbreviations
        '
        Me.chkMonthAbbreviations.AutoSize = True
        Me.chkMonthAbbreviations.Location = New System.Drawing.Point(337, 238)
        Me.chkMonthAbbreviations.Name = "chkMonthAbbreviations"
        Me.chkMonthAbbreviations.Size = New System.Drawing.Size(81, 17)
        Me.chkMonthAbbreviations.TabIndex = 14
        Me.chkMonthAbbreviations.Tag = "Month_Abbreviations"
        Me.chkMonthAbbreviations.Text = "CheckBox1"
        Me.chkMonthAbbreviations.UseVisualStyleBackColor = True
        '
        'chkSaveTable
        '
        Me.chkSaveTable.AutoSize = True
        Me.chkSaveTable.Location = New System.Drawing.Point(461, 191)
        Me.chkSaveTable.Name = "chkSaveTable"
        Me.chkSaveTable.Size = New System.Drawing.Size(81, 17)
        Me.chkSaveTable.TabIndex = 15
        Me.chkSaveTable.Tag = "Save_Table"
        Me.chkSaveTable.Text = "CheckBox2"
        Me.chkSaveTable.UseVisualStyleBackColor = True
        '
        'chkRowNames
        '
        Me.chkRowNames.AutoSize = True
        Me.chkRowNames.Location = New System.Drawing.Point(337, 191)
        Me.chkRowNames.Name = "chkRowNames"
        Me.chkRowNames.Size = New System.Drawing.Size(81, 17)
        Me.chkRowNames.TabIndex = 16
        Me.chkRowNames.Tag = "Row_Names"
        Me.chkRowNames.Text = "CheckBox3"
        Me.chkRowNames.UseVisualStyleBackColor = True
        '
        'nudHeight
        '
        Me.nudHeight.Location = New System.Drawing.Point(144, 266)
        Me.nudHeight.Name = "nudHeight"
        Me.nudHeight.Size = New System.Drawing.Size(74, 20)
        Me.nudHeight.TabIndex = 17
        '
        'nudHeaderFontSize
        '
        Me.nudHeaderFontSize.Location = New System.Drawing.Point(144, 240)
        Me.nudHeaderFontSize.Name = "nudHeaderFontSize"
        Me.nudHeaderFontSize.Size = New System.Drawing.Size(74, 20)
        Me.nudHeaderFontSize.TabIndex = 18
        '
        'nudFontSize
        '
        Me.nudFontSize.Location = New System.Drawing.Point(144, 191)
        Me.nudFontSize.Name = "nudFontSize"
        Me.nudFontSize.Size = New System.Drawing.Size(74, 20)
        Me.nudFontSize.TabIndex = 19
        '
        'nudWidth
        '
        Me.nudWidth.Location = New System.Drawing.Point(144, 214)
        Me.nudWidth.Name = "nudWidth"
        Me.nudWidth.Size = New System.Drawing.Size(74, 20)
        Me.nudWidth.TabIndex = 20
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(82, 330)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'dlgDisplayDOYofYear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 362)
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
        Me.Controls.Add(Me.txtDayDisplay)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.ucrBase)
        Me.Name = "dlgDisplayDOYofYear"
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
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtFile As TextBox
    Friend WithEvents txtDayDisplay As TextBox
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
End Class
