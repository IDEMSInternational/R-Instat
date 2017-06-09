<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrELementTextControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.grpAxisLabels = New System.Windows.Forms.GroupBox()
        Me.ucrColors = New instat.ucrColors()
        Me.ucrChkColour = New instat.ucrCheck()
        Me.ucrChkFace = New instat.ucrCheck()
        Me.ucrChkFamily = New instat.ucrCheck()
        Me.ucrChkAngle = New instat.ucrCheck()
        Me.ucrChkHjust = New instat.ucrCheck()
        Me.ucrChkVjust = New instat.ucrCheck()
        Me.ucrChkLineHeight = New instat.ucrCheck()
        Me.ucrChkSize = New instat.ucrCheck()
        Me.ucrNudVjust = New instat.ucrNud()
        Me.ucrNudLineHeight = New instat.ucrNud()
        Me.ucrNudAngle = New instat.ucrNud()
        Me.ucrNudHjust = New instat.ucrNud()
        Me.ucrNudsize = New instat.ucrNud()
        Me.ucrInputFace = New instat.ucrInputComboBox()
        Me.ucrInputFamily = New instat.ucrInputComboBox()
        Me.grpAxisLabels.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAxisLabels
        '
        Me.grpAxisLabels.Controls.Add(Me.ucrColors)
        Me.grpAxisLabels.Controls.Add(Me.ucrChkColour)
        Me.grpAxisLabels.Controls.Add(Me.ucrChkFace)
        Me.grpAxisLabels.Controls.Add(Me.ucrChkFamily)
        Me.grpAxisLabels.Controls.Add(Me.ucrChkAngle)
        Me.grpAxisLabels.Controls.Add(Me.ucrChkHjust)
        Me.grpAxisLabels.Controls.Add(Me.ucrChkVjust)
        Me.grpAxisLabels.Controls.Add(Me.ucrChkLineHeight)
        Me.grpAxisLabels.Controls.Add(Me.ucrChkSize)
        Me.grpAxisLabels.Controls.Add(Me.ucrNudVjust)
        Me.grpAxisLabels.Controls.Add(Me.ucrNudLineHeight)
        Me.grpAxisLabels.Controls.Add(Me.ucrNudAngle)
        Me.grpAxisLabels.Controls.Add(Me.ucrNudHjust)
        Me.grpAxisLabels.Controls.Add(Me.ucrNudsize)
        Me.grpAxisLabels.Controls.Add(Me.ucrInputFace)
        Me.grpAxisLabels.Controls.Add(Me.ucrInputFamily)
        Me.grpAxisLabels.Location = New System.Drawing.Point(3, 0)
        Me.grpAxisLabels.Name = "grpAxisLabels"
        Me.grpAxisLabels.Size = New System.Drawing.Size(246, 223)
        Me.grpAxisLabels.TabIndex = 71
        Me.grpAxisLabels.TabStop = False
        Me.grpAxisLabels.Text = "Element Text "
        '
        'ucrColors
        '
        Me.ucrColors.AddQuotesIfUnrecognised = True
        Me.ucrColors.IsReadOnly = False
        Me.ucrColors.Location = New System.Drawing.Point(105, 191)
        Me.ucrColors.Name = "ucrColors"
        Me.ucrColors.Size = New System.Drawing.Size(137, 21)
        Me.ucrColors.TabIndex = 86
        '
        'ucrChkColour
        '
        Me.ucrChkColour.Checked = False
        Me.ucrChkColour.Location = New System.Drawing.Point(8, 192)
        Me.ucrChkColour.Name = "ucrChkColour"
        Me.ucrChkColour.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkColour.TabIndex = 85
        '
        'ucrChkFace
        '
        Me.ucrChkFace.Checked = False
        Me.ucrChkFace.Location = New System.Drawing.Point(8, 167)
        Me.ucrChkFace.Name = "ucrChkFace"
        Me.ucrChkFace.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkFace.TabIndex = 84
        '
        'ucrChkFamily
        '
        Me.ucrChkFamily.Checked = False
        Me.ucrChkFamily.Location = New System.Drawing.Point(8, 142)
        Me.ucrChkFamily.Name = "ucrChkFamily"
        Me.ucrChkFamily.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkFamily.TabIndex = 83
        '
        'ucrChkAngle
        '
        Me.ucrChkAngle.Checked = False
        Me.ucrChkAngle.Location = New System.Drawing.Point(8, 117)
        Me.ucrChkAngle.Name = "ucrChkAngle"
        Me.ucrChkAngle.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkAngle.TabIndex = 82
        '
        'ucrChkHjust
        '
        Me.ucrChkHjust.Checked = False
        Me.ucrChkHjust.Location = New System.Drawing.Point(8, 44)
        Me.ucrChkHjust.Name = "ucrChkHjust"
        Me.ucrChkHjust.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkHjust.TabIndex = 81
        '
        'ucrChkVjust
        '
        Me.ucrChkVjust.Checked = False
        Me.ucrChkVjust.Location = New System.Drawing.Point(8, 69)
        Me.ucrChkVjust.Name = "ucrChkVjust"
        Me.ucrChkVjust.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkVjust.TabIndex = 80
        '
        'ucrChkLineHeight
        '
        Me.ucrChkLineHeight.Checked = False
        Me.ucrChkLineHeight.Location = New System.Drawing.Point(8, 94)
        Me.ucrChkLineHeight.Name = "ucrChkLineHeight"
        Me.ucrChkLineHeight.Size = New System.Drawing.Size(94, 18)
        Me.ucrChkLineHeight.TabIndex = 79
        '
        'ucrChkSize
        '
        Me.ucrChkSize.Checked = False
        Me.ucrChkSize.Location = New System.Drawing.Point(8, 19)
        Me.ucrChkSize.Name = "ucrChkSize"
        Me.ucrChkSize.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkSize.TabIndex = 78
        '
        'ucrNudVjust
        '
        Me.ucrNudVjust.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudVjust.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.ucrNudVjust.Location = New System.Drawing.Point(105, 68)
        Me.ucrNudVjust.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudVjust.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudVjust.Name = "ucrNudVjust"
        Me.ucrNudVjust.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudVjust.TabIndex = 77
        Me.ucrNudVjust.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLineHeight
        '
        Me.ucrNudLineHeight.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLineHeight.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.ucrNudLineHeight.Location = New System.Drawing.Point(105, 92)
        Me.ucrNudLineHeight.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLineHeight.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLineHeight.Name = "ucrNudLineHeight"
        Me.ucrNudLineHeight.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLineHeight.TabIndex = 76
        Me.ucrNudLineHeight.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudAngle
        '
        Me.ucrNudAngle.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAngle.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAngle.Location = New System.Drawing.Point(105, 117)
        Me.ucrNudAngle.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAngle.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAngle.Name = "ucrNudAngle"
        Me.ucrNudAngle.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAngle.TabIndex = 75
        Me.ucrNudAngle.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudHjust
        '
        Me.ucrNudHjust.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHjust.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.ucrNudHjust.Location = New System.Drawing.Point(105, 43)
        Me.ucrNudHjust.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHjust.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHjust.Name = "ucrNudHjust"
        Me.ucrNudHjust.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudHjust.TabIndex = 74
        Me.ucrNudHjust.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudsize
        '
        Me.ucrNudsize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudsize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudsize.Location = New System.Drawing.Point(105, 19)
        Me.ucrNudsize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudsize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudsize.Name = "ucrNudsize"
        Me.ucrNudsize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudsize.TabIndex = 73
        Me.ucrNudsize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputFace
        '
        Me.ucrInputFace.AddQuotesIfUnrecognised = True
        Me.ucrInputFace.IsReadOnly = False
        Me.ucrInputFace.Location = New System.Drawing.Point(105, 166)
        Me.ucrInputFace.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputFace.Name = "ucrInputFace"
        Me.ucrInputFace.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputFace.TabIndex = 71
        '
        'ucrInputFamily
        '
        Me.ucrInputFamily.AddQuotesIfUnrecognised = True
        Me.ucrInputFamily.IsReadOnly = False
        Me.ucrInputFamily.Location = New System.Drawing.Point(105, 141)
        Me.ucrInputFamily.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputFamily.Name = "ucrInputFamily"
        Me.ucrInputFamily.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputFamily.TabIndex = 70
        '
        'ucrThemeAxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpAxisLabels)
        Me.Name = "ucrThemeAxes"
        Me.Size = New System.Drawing.Size(259, 227)
        Me.grpAxisLabels.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpAxisLabels As GroupBox
    Friend WithEvents ucrChkFace As ucrCheck
    Friend WithEvents ucrChkFamily As ucrCheck
    Friend WithEvents ucrChkAngle As ucrCheck
    Friend WithEvents ucrChkHjust As ucrCheck
    Friend WithEvents ucrChkVjust As ucrCheck
    Friend WithEvents ucrChkLineHeight As ucrCheck
    Friend WithEvents ucrChkSize As ucrCheck
    Friend WithEvents ucrNudVjust As ucrNud
    Friend WithEvents ucrNudLineHeight As ucrNud
    Friend WithEvents ucrNudAngle As ucrNud
    Friend WithEvents ucrNudHjust As ucrNud
    Friend WithEvents ucrNudsize As ucrNud
    Friend WithEvents ucrInputFace As ucrInputComboBox
    Friend WithEvents ucrInputFamily As ucrInputComboBox
    Friend WithEvents ucrChkColour As ucrCheck
    Friend WithEvents ucrColors As ucrColors
End Class
