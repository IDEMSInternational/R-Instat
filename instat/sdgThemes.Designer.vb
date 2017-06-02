<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgThemes
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
        Me.ucrBaseSubdialogue = New instat.ucrButtonsSubdialogue()
        Me.tbXaxis = New System.Windows.Forms.TabControl()
        Me.tbAxis = New System.Windows.Forms.TabPage()
        Me.grpTableOptions = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblLineEnd = New System.Windows.Forms.Label()
        Me.ucrInputLineEnd = New instat.ucrInputComboBox()
        Me.lblSizeSegment = New System.Windows.Forms.Label()
        Me.ucrNudSizeSegment = New instat.ucrNud()
        Me.lblColourSegment = New System.Windows.Forms.Label()
        Me.ucrInputColourSegment = New instat.ucrInputComboBox()
        Me.lblLineType = New System.Windows.Forms.Label()
        Me.ucrInputLineType = New instat.ucrInputComboBox()
        Me.grpThemetext = New System.Windows.Forms.GroupBox()
        Me.lblVjust = New System.Windows.Forms.Label()
        Me.ucrNudVjust = New instat.ucrNud()
        Me.lblLineHeight = New System.Windows.Forms.Label()
        Me.ucrNudLineHeight = New instat.ucrNud()
        Me.lblAngle = New System.Windows.Forms.Label()
        Me.ucrNudAngle = New instat.ucrNud()
        Me.lblHjust = New System.Windows.Forms.Label()
        Me.ucrNudHjust = New instat.ucrNud()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.ucrNudsize = New instat.ucrNud()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ucrInputColour = New instat.ucrInputComboBox()
        Me.lblFace = New System.Windows.Forms.Label()
        Me.ucrInputFace = New instat.ucrInputComboBox()
        Me.lblFamily = New System.Windows.Forms.Label()
        Me.ucrInputFamily = New instat.ucrInputComboBox()
        Me.tbYaxis = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UcrNud1 = New instat.ucrNud()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UcrNud2 = New instat.ucrNud()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UcrNud3 = New instat.ucrNud()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UcrNud4 = New instat.ucrNud()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UcrNud5 = New instat.ucrNud()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UcrInputComboBox1 = New instat.ucrInputComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.UcrInputComboBox2 = New instat.ucrInputComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UcrInputComboBox3 = New instat.ucrInputComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.UcrInputComboBox4 = New instat.ucrInputComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.UcrNud6 = New instat.ucrNud()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.UcrInputComboBox5 = New instat.ucrInputComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.UcrInputComboBox6 = New instat.ucrInputComboBox()
        Me.tbXaxis.SuspendLayout()
        Me.tbAxis.SuspendLayout()
        Me.grpTableOptions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpThemetext.SuspendLayout()
        Me.tbYaxis.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBaseSubdialogue
        '
        Me.ucrBaseSubdialogue.Location = New System.Drawing.Point(157, 441)
        Me.ucrBaseSubdialogue.Name = "ucrBaseSubdialogue"
        Me.ucrBaseSubdialogue.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSubdialogue.TabIndex = 0
        '
        'tbXaxis
        '
        Me.tbXaxis.Controls.Add(Me.tbAxis)
        Me.tbXaxis.Controls.Add(Me.tbYaxis)
        Me.tbXaxis.Location = New System.Drawing.Point(4, 8)
        Me.tbXaxis.Name = "tbXaxis"
        Me.tbXaxis.SelectedIndex = 0
        Me.tbXaxis.Size = New System.Drawing.Size(506, 421)
        Me.tbXaxis.TabIndex = 1
        '
        'tbAxis
        '
        Me.tbAxis.Controls.Add(Me.grpTableOptions)
        Me.tbAxis.Location = New System.Drawing.Point(4, 22)
        Me.tbAxis.Name = "tbAxis"
        Me.tbAxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tbAxis.Size = New System.Drawing.Size(498, 395)
        Me.tbAxis.TabIndex = 0
        Me.tbAxis.Text = "X-axis"
        Me.tbAxis.UseVisualStyleBackColor = True
        '
        'grpTableOptions
        '
        Me.grpTableOptions.Controls.Add(Me.GroupBox1)
        Me.grpTableOptions.Controls.Add(Me.grpThemetext)
        Me.grpTableOptions.Location = New System.Drawing.Point(-1, 3)
        Me.grpTableOptions.Name = "grpTableOptions"
        Me.grpTableOptions.Size = New System.Drawing.Size(492, 397)
        Me.grpTableOptions.TabIndex = 0
        Me.grpTableOptions.TabStop = False
        Me.grpTableOptions.Text = "More Options"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblLineEnd)
        Me.GroupBox1.Controls.Add(Me.ucrInputLineEnd)
        Me.GroupBox1.Controls.Add(Me.lblSizeSegment)
        Me.GroupBox1.Controls.Add(Me.ucrNudSizeSegment)
        Me.GroupBox1.Controls.Add(Me.lblColourSegment)
        Me.GroupBox1.Controls.Add(Me.ucrInputColourSegment)
        Me.GroupBox1.Controls.Add(Me.lblLineType)
        Me.GroupBox1.Controls.Add(Me.ucrInputLineType)
        Me.GroupBox1.Location = New System.Drawing.Point(251, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 154)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "tick marks along axes"
        '
        'lblLineEnd
        '
        Me.lblLineEnd.AutoSize = True
        Me.lblLineEnd.Location = New System.Drawing.Point(12, 108)
        Me.lblLineEnd.Name = "lblLineEnd"
        Me.lblLineEnd.Size = New System.Drawing.Size(52, 13)
        Me.lblLineEnd.TabIndex = 31
        Me.lblLineEnd.Text = "Line End:"
        '
        'ucrInputLineEnd
        '
        Me.ucrInputLineEnd.AddQuotesIfUnrecognised = True
        Me.ucrInputLineEnd.IsReadOnly = False
        Me.ucrInputLineEnd.Location = New System.Drawing.Point(72, 100)
        Me.ucrInputLineEnd.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputLineEnd.Name = "ucrInputLineEnd"
        Me.ucrInputLineEnd.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLineEnd.TabIndex = 32
        '
        'lblSizeSegment
        '
        Me.lblSizeSegment.AutoSize = True
        Me.lblSizeSegment.Location = New System.Drawing.Point(13, 22)
        Me.lblSizeSegment.Name = "lblSizeSegment"
        Me.lblSizeSegment.Size = New System.Drawing.Size(30, 13)
        Me.lblSizeSegment.TabIndex = 29
        Me.lblSizeSegment.Text = "Size:"
        '
        'ucrNudSizeSegment
        '
        Me.ucrNudSizeSegment.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSizeSegment.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSizeSegment.Location = New System.Drawing.Point(94, 17)
        Me.ucrNudSizeSegment.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSizeSegment.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSizeSegment.Name = "ucrNudSizeSegment"
        Me.ucrNudSizeSegment.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSizeSegment.TabIndex = 30
        Me.ucrNudSizeSegment.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblColourSegment
        '
        Me.lblColourSegment.AutoSize = True
        Me.lblColourSegment.Location = New System.Drawing.Point(12, 76)
        Me.lblColourSegment.Name = "lblColourSegment"
        Me.lblColourSegment.Size = New System.Drawing.Size(40, 13)
        Me.lblColourSegment.TabIndex = 27
        Me.lblColourSegment.Text = "Colour:"
        '
        'ucrInputColourSegment
        '
        Me.ucrInputColourSegment.AddQuotesIfUnrecognised = True
        Me.ucrInputColourSegment.IsReadOnly = False
        Me.ucrInputColourSegment.Location = New System.Drawing.Point(72, 68)
        Me.ucrInputColourSegment.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputColourSegment.Name = "ucrInputColourSegment"
        Me.ucrInputColourSegment.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputColourSegment.TabIndex = 28
        '
        'lblLineType
        '
        Me.lblLineType.AutoSize = True
        Me.lblLineType.Location = New System.Drawing.Point(12, 47)
        Me.lblLineType.Name = "lblLineType"
        Me.lblLineType.Size = New System.Drawing.Size(57, 13)
        Me.lblLineType.TabIndex = 25
        Me.lblLineType.Text = "Line Type:"
        '
        'ucrInputLineType
        '
        Me.ucrInputLineType.AddQuotesIfUnrecognised = True
        Me.ucrInputLineType.IsReadOnly = False
        Me.ucrInputLineType.Location = New System.Drawing.Point(72, 40)
        Me.ucrInputLineType.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputLineType.Name = "ucrInputLineType"
        Me.ucrInputLineType.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLineType.TabIndex = 26
        '
        'grpThemetext
        '
        Me.grpThemetext.Controls.Add(Me.lblVjust)
        Me.grpThemetext.Controls.Add(Me.ucrNudVjust)
        Me.grpThemetext.Controls.Add(Me.lblLineHeight)
        Me.grpThemetext.Controls.Add(Me.ucrNudLineHeight)
        Me.grpThemetext.Controls.Add(Me.lblAngle)
        Me.grpThemetext.Controls.Add(Me.ucrNudAngle)
        Me.grpThemetext.Controls.Add(Me.lblHjust)
        Me.grpThemetext.Controls.Add(Me.ucrNudHjust)
        Me.grpThemetext.Controls.Add(Me.lblSize)
        Me.grpThemetext.Controls.Add(Me.ucrNudsize)
        Me.grpThemetext.Controls.Add(Me.Label2)
        Me.grpThemetext.Controls.Add(Me.ucrInputColour)
        Me.grpThemetext.Controls.Add(Me.lblFace)
        Me.grpThemetext.Controls.Add(Me.ucrInputFace)
        Me.grpThemetext.Controls.Add(Me.lblFamily)
        Me.grpThemetext.Controls.Add(Me.ucrInputFamily)
        Me.grpThemetext.Location = New System.Drawing.Point(15, 19)
        Me.grpThemetext.Name = "grpThemetext"
        Me.grpThemetext.Size = New System.Drawing.Size(230, 245)
        Me.grpThemetext.TabIndex = 23
        Me.grpThemetext.TabStop = False
        Me.grpThemetext.Text = "X axis label"
        '
        'lblVjust
        '
        Me.lblVjust.AutoSize = True
        Me.lblVjust.Location = New System.Drawing.Point(13, 77)
        Me.lblVjust.Name = "lblVjust"
        Me.lblVjust.Size = New System.Drawing.Size(33, 13)
        Me.lblVjust.TabIndex = 37
        Me.lblVjust.Text = "Vjust:"
        '
        'ucrNudVjust
        '
        Me.ucrNudVjust.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudVjust.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.ucrNudVjust.Location = New System.Drawing.Point(94, 76)
        Me.ucrNudVjust.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudVjust.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudVjust.Name = "ucrNudVjust"
        Me.ucrNudVjust.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudVjust.TabIndex = 38
        Me.ucrNudVjust.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblLineHeight
        '
        Me.lblLineHeight.AutoSize = True
        Me.lblLineHeight.Location = New System.Drawing.Point(13, 105)
        Me.lblLineHeight.Name = "lblLineHeight"
        Me.lblLineHeight.Size = New System.Drawing.Size(64, 13)
        Me.lblLineHeight.TabIndex = 35
        Me.lblLineHeight.Text = "Line Height:"
        '
        'ucrNudLineHeight
        '
        Me.ucrNudLineHeight.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLineHeight.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.ucrNudLineHeight.Location = New System.Drawing.Point(94, 106)
        Me.ucrNudLineHeight.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLineHeight.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLineHeight.Name = "ucrNudLineHeight"
        Me.ucrNudLineHeight.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLineHeight.TabIndex = 36
        Me.ucrNudLineHeight.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblAngle
        '
        Me.lblAngle.AutoSize = True
        Me.lblAngle.Location = New System.Drawing.Point(13, 133)
        Me.lblAngle.Name = "lblAngle"
        Me.lblAngle.Size = New System.Drawing.Size(37, 13)
        Me.lblAngle.TabIndex = 33
        Me.lblAngle.Text = "Angle:"
        '
        'ucrNudAngle
        '
        Me.ucrNudAngle.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAngle.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAngle.Location = New System.Drawing.Point(94, 136)
        Me.ucrNudAngle.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAngle.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAngle.Name = "ucrNudAngle"
        Me.ucrNudAngle.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAngle.TabIndex = 34
        Me.ucrNudAngle.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblHjust
        '
        Me.lblHjust.AutoSize = True
        Me.lblHjust.Location = New System.Drawing.Point(13, 49)
        Me.lblHjust.Name = "lblHjust"
        Me.lblHjust.Size = New System.Drawing.Size(34, 13)
        Me.lblHjust.TabIndex = 31
        Me.lblHjust.Text = "Hjust:"
        '
        'ucrNudHjust
        '
        Me.ucrNudHjust.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHjust.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.ucrNudHjust.Location = New System.Drawing.Point(94, 46)
        Me.ucrNudHjust.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHjust.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHjust.Name = "ucrNudHjust"
        Me.ucrNudHjust.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudHjust.TabIndex = 32
        Me.ucrNudHjust.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(13, 21)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(30, 13)
        Me.lblSize.TabIndex = 29
        Me.lblSize.Text = "Size:"
        '
        'ucrNudsize
        '
        Me.ucrNudsize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudsize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudsize.Location = New System.Drawing.Point(94, 16)
        Me.ucrNudsize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudsize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudsize.Name = "ucrNudsize"
        Me.ucrNudsize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudsize.TabIndex = 30
        Me.ucrNudsize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Colour:"
        '
        'ucrInputColour
        '
        Me.ucrInputColour.AddQuotesIfUnrecognised = True
        Me.ucrInputColour.IsReadOnly = False
        Me.ucrInputColour.Location = New System.Drawing.Point(73, 217)
        Me.ucrInputColour.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputColour.Name = "ucrInputColour"
        Me.ucrInputColour.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputColour.TabIndex = 28
        '
        'lblFace
        '
        Me.lblFace.AutoSize = True
        Me.lblFace.Location = New System.Drawing.Point(13, 196)
        Me.lblFace.Name = "lblFace"
        Me.lblFace.Size = New System.Drawing.Size(34, 13)
        Me.lblFace.TabIndex = 25
        Me.lblFace.Text = "Face:"
        '
        'ucrInputFace
        '
        Me.ucrInputFace.AddQuotesIfUnrecognised = True
        Me.ucrInputFace.IsReadOnly = False
        Me.ucrInputFace.Location = New System.Drawing.Point(73, 189)
        Me.ucrInputFace.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputFace.Name = "ucrInputFace"
        Me.ucrInputFace.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputFace.TabIndex = 26
        '
        'lblFamily
        '
        Me.lblFamily.AutoSize = True
        Me.lblFamily.Location = New System.Drawing.Point(13, 166)
        Me.lblFamily.Name = "lblFamily"
        Me.lblFamily.Size = New System.Drawing.Size(39, 13)
        Me.lblFamily.TabIndex = 23
        Me.lblFamily.Text = "Family:"
        '
        'ucrInputFamily
        '
        Me.ucrInputFamily.AddQuotesIfUnrecognised = True
        Me.ucrInputFamily.IsReadOnly = False
        Me.ucrInputFamily.Location = New System.Drawing.Point(73, 162)
        Me.ucrInputFamily.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputFamily.Name = "ucrInputFamily"
        Me.ucrInputFamily.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputFamily.TabIndex = 24
        '
        'tbYaxis
        '
        Me.tbYaxis.Controls.Add(Me.GroupBox3)
        Me.tbYaxis.Controls.Add(Me.GroupBox2)
        Me.tbYaxis.Location = New System.Drawing.Point(4, 22)
        Me.tbYaxis.Name = "tbYaxis"
        Me.tbYaxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tbYaxis.Size = New System.Drawing.Size(498, 395)
        Me.tbYaxis.TabIndex = 1
        Me.tbYaxis.Text = "Y-axis"
        Me.tbYaxis.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.UcrNud1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.UcrNud2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.UcrNud3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.UcrNud4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.UcrNud5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.UcrInputComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.UcrInputComboBox2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.UcrInputComboBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(230, 245)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Y axis label"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Vjust:"
        '
        'UcrNud1
        '
        Me.UcrNud1.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNud1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.UcrNud1.Location = New System.Drawing.Point(94, 76)
        Me.UcrNud1.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNud1.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNud1.Name = "UcrNud1"
        Me.UcrNud1.Size = New System.Drawing.Size(50, 20)
        Me.UcrNud1.TabIndex = 38
        Me.UcrNud1.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Line Height:"
        '
        'UcrNud2
        '
        Me.UcrNud2.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNud2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.UcrNud2.Location = New System.Drawing.Point(94, 106)
        Me.UcrNud2.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNud2.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNud2.Name = "UcrNud2"
        Me.UcrNud2.Size = New System.Drawing.Size(50, 20)
        Me.UcrNud2.TabIndex = 36
        Me.UcrNud2.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Angle:"
        '
        'UcrNud3
        '
        Me.UcrNud3.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNud3.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNud3.Location = New System.Drawing.Point(94, 136)
        Me.UcrNud3.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNud3.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNud3.Name = "UcrNud3"
        Me.UcrNud3.Size = New System.Drawing.Size(50, 20)
        Me.UcrNud3.TabIndex = 34
        Me.UcrNud3.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Hjust:"
        '
        'UcrNud4
        '
        Me.UcrNud4.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNud4.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.UcrNud4.Location = New System.Drawing.Point(94, 46)
        Me.UcrNud4.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNud4.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNud4.Name = "UcrNud4"
        Me.UcrNud4.Size = New System.Drawing.Size(50, 20)
        Me.UcrNud4.TabIndex = 32
        Me.UcrNud4.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Size:"
        '
        'UcrNud5
        '
        Me.UcrNud5.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNud5.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNud5.Location = New System.Drawing.Point(94, 16)
        Me.UcrNud5.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNud5.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNud5.Name = "UcrNud5"
        Me.UcrNud5.Size = New System.Drawing.Size(50, 20)
        Me.UcrNud5.TabIndex = 30
        Me.UcrNud5.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Colour:"
        '
        'UcrInputComboBox1
        '
        Me.UcrInputComboBox1.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox1.IsReadOnly = False
        Me.UcrInputComboBox1.Location = New System.Drawing.Point(73, 217)
        Me.UcrInputComboBox1.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.UcrInputComboBox1.Name = "UcrInputComboBox1"
        Me.UcrInputComboBox1.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox1.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Face:"
        '
        'UcrInputComboBox2
        '
        Me.UcrInputComboBox2.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox2.IsReadOnly = False
        Me.UcrInputComboBox2.Location = New System.Drawing.Point(73, 189)
        Me.UcrInputComboBox2.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.UcrInputComboBox2.Name = "UcrInputComboBox2"
        Me.UcrInputComboBox2.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox2.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Family:"
        '
        'UcrInputComboBox3
        '
        Me.UcrInputComboBox3.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox3.IsReadOnly = False
        Me.UcrInputComboBox3.Location = New System.Drawing.Point(73, 162)
        Me.UcrInputComboBox3.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.UcrInputComboBox3.Name = "UcrInputComboBox3"
        Me.UcrInputComboBox3.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox3.TabIndex = 24
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.UcrInputComboBox4)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.UcrNud6)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.UcrInputComboBox5)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.UcrInputComboBox6)
        Me.GroupBox3.Location = New System.Drawing.Point(252, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(230, 154)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "tick marks along axes"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Line End:"
        '
        'UcrInputComboBox4
        '
        Me.UcrInputComboBox4.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox4.IsReadOnly = False
        Me.UcrInputComboBox4.Location = New System.Drawing.Point(72, 100)
        Me.UcrInputComboBox4.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.UcrInputComboBox4.Name = "UcrInputComboBox4"
        Me.UcrInputComboBox4.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox4.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Size:"
        '
        'UcrNud6
        '
        Me.UcrNud6.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNud6.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNud6.Location = New System.Drawing.Point(94, 17)
        Me.UcrNud6.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNud6.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNud6.Name = "UcrNud6"
        Me.UcrNud6.Size = New System.Drawing.Size(50, 20)
        Me.UcrNud6.TabIndex = 30
        Me.UcrNud6.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Colour:"
        '
        'UcrInputComboBox5
        '
        Me.UcrInputComboBox5.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox5.IsReadOnly = False
        Me.UcrInputComboBox5.Location = New System.Drawing.Point(72, 68)
        Me.UcrInputComboBox5.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.UcrInputComboBox5.Name = "UcrInputComboBox5"
        Me.UcrInputComboBox5.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox5.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Line Type:"
        '
        'UcrInputComboBox6
        '
        Me.UcrInputComboBox6.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox6.IsReadOnly = False
        Me.UcrInputComboBox6.Location = New System.Drawing.Point(72, 40)
        Me.UcrInputComboBox6.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.UcrInputComboBox6.Name = "UcrInputComboBox6"
        Me.UcrInputComboBox6.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox6.TabIndex = 26
        '
        'sdgThemes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 472)
        Me.Controls.Add(Me.tbXaxis)
        Me.Controls.Add(Me.ucrBaseSubdialogue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgThemes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Themes"
        Me.tbXaxis.ResumeLayout(False)
        Me.tbAxis.ResumeLayout(False)
        Me.grpTableOptions.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpThemetext.ResumeLayout(False)
        Me.grpThemetext.PerformLayout()
        Me.tbYaxis.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBaseSubdialogue As ucrButtonsSubdialogue
    Friend WithEvents tbXaxis As TabControl
    Friend WithEvents tbAxis As TabPage
    Friend WithEvents grpTableOptions As GroupBox
    Friend WithEvents tbYaxis As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblSizeSegment As Label
    Friend WithEvents ucrNudSizeSegment As ucrNud
    Friend WithEvents lblColourSegment As Label
    Friend WithEvents ucrInputColourSegment As ucrInputComboBox
    Friend WithEvents lblLineType As Label
    Friend WithEvents ucrInputLineType As ucrInputComboBox
    Friend WithEvents grpThemetext As GroupBox
    Friend WithEvents lblVjust As Label
    Friend WithEvents ucrNudVjust As ucrNud
    Friend WithEvents lblLineHeight As Label
    Friend WithEvents ucrNudLineHeight As ucrNud
    Friend WithEvents lblAngle As Label
    Friend WithEvents ucrNudAngle As ucrNud
    Friend WithEvents lblHjust As Label
    Friend WithEvents ucrNudHjust As ucrNud
    Friend WithEvents lblSize As Label
    Friend WithEvents ucrNudsize As ucrNud
    Friend WithEvents Label2 As Label
    Friend WithEvents ucrInputColour As ucrInputComboBox
    Friend WithEvents lblFace As Label
    Friend WithEvents ucrInputFace As ucrInputComboBox
    Friend WithEvents lblFamily As Label
    Friend WithEvents ucrInputFamily As ucrInputComboBox
    Friend WithEvents lblLineEnd As Label
    Friend WithEvents ucrInputLineEnd As ucrInputComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents UcrNud1 As ucrNud
    Friend WithEvents Label3 As Label
    Friend WithEvents UcrNud2 As ucrNud
    Friend WithEvents Label4 As Label
    Friend WithEvents UcrNud3 As ucrNud
    Friend WithEvents Label5 As Label
    Friend WithEvents UcrNud4 As ucrNud
    Friend WithEvents Label6 As Label
    Friend WithEvents UcrNud5 As ucrNud
    Friend WithEvents Label7 As Label
    Friend WithEvents UcrInputComboBox1 As ucrInputComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents UcrInputComboBox2 As ucrInputComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents UcrInputComboBox3 As ucrInputComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents UcrInputComboBox4 As ucrInputComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents UcrNud6 As ucrNud
    Friend WithEvents Label12 As Label
    Friend WithEvents UcrInputComboBox5 As ucrInputComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents UcrInputComboBox6 As ucrInputComboBox
End Class
