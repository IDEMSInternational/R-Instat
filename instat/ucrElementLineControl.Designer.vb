<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrElementLineControl
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
        Me.grpTickMarks = New System.Windows.Forms.GroupBox()
        Me.ucrColors = New instat.ucrColors()
        Me.ucrChkTickLineEnd = New instat.ucrCheck()
        Me.ucrChkTickSize = New instat.ucrCheck()
        Me.ucrChkTickLineType = New instat.ucrCheck()
        Me.ucrChkTickColour = New instat.ucrCheck()
        Me.ucrInpuTicktLineEnd = New instat.ucrInputComboBox()
        Me.ucrNudTickSize = New instat.ucrNud()
        Me.ucrInputTickLineType = New instat.ucrInputComboBox()
        Me.grpTickMarks.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTickMarks
        '
        Me.grpTickMarks.Controls.Add(Me.ucrColors)
        Me.grpTickMarks.Controls.Add(Me.ucrChkTickLineEnd)
        Me.grpTickMarks.Controls.Add(Me.ucrChkTickSize)
        Me.grpTickMarks.Controls.Add(Me.ucrChkTickLineType)
        Me.grpTickMarks.Controls.Add(Me.ucrChkTickColour)
        Me.grpTickMarks.Controls.Add(Me.ucrInpuTicktLineEnd)
        Me.grpTickMarks.Controls.Add(Me.ucrNudTickSize)
        Me.grpTickMarks.Controls.Add(Me.ucrInputTickLineType)
        Me.grpTickMarks.Location = New System.Drawing.Point(2, 1)
        Me.grpTickMarks.Name = "grpTickMarks"
        Me.grpTickMarks.Size = New System.Drawing.Size(247, 119)
        Me.grpTickMarks.TabIndex = 41
        Me.grpTickMarks.TabStop = False
        Me.grpTickMarks.Text = "Element Line"
        '
        'ucrColors
        '
        Me.ucrColors.AddQuotesIfUnrecognised = True
        Me.ucrColors.IsReadOnly = False
        Me.ucrColors.Location = New System.Drawing.Point(100, 66)
        Me.ucrColors.Name = "ucrColors"
        Me.ucrColors.Size = New System.Drawing.Size(137, 21)
        Me.ucrColors.TabIndex = 87
        '
        'ucrChkTickLineEnd
        '
        Me.ucrChkTickLineEnd.Checked = False
        Me.ucrChkTickLineEnd.Location = New System.Drawing.Point(11, 92)
        Me.ucrChkTickLineEnd.Name = "ucrChkTickLineEnd"
        Me.ucrChkTickLineEnd.Size = New System.Drawing.Size(88, 20)
        Me.ucrChkTickLineEnd.TabIndex = 54
        '
        'ucrChkTickSize
        '
        Me.ucrChkTickSize.Checked = False
        Me.ucrChkTickSize.Location = New System.Drawing.Point(11, 20)
        Me.ucrChkTickSize.Name = "ucrChkTickSize"
        Me.ucrChkTickSize.Size = New System.Drawing.Size(88, 20)
        Me.ucrChkTickSize.TabIndex = 53
        '
        'ucrChkTickLineType
        '
        Me.ucrChkTickLineType.Checked = False
        Me.ucrChkTickLineType.Location = New System.Drawing.Point(11, 44)
        Me.ucrChkTickLineType.Name = "ucrChkTickLineType"
        Me.ucrChkTickLineType.Size = New System.Drawing.Size(88, 20)
        Me.ucrChkTickLineType.TabIndex = 52
        '
        'ucrChkTickColour
        '
        Me.ucrChkTickColour.Checked = False
        Me.ucrChkTickColour.Location = New System.Drawing.Point(11, 68)
        Me.ucrChkTickColour.Name = "ucrChkTickColour"
        Me.ucrChkTickColour.Size = New System.Drawing.Size(88, 20)
        Me.ucrChkTickColour.TabIndex = 51
        '
        'ucrInpuTicktLineEnd
        '
        Me.ucrInpuTicktLineEnd.AddQuotesIfUnrecognised = True
        Me.ucrInpuTicktLineEnd.IsReadOnly = False
        Me.ucrInpuTicktLineEnd.Location = New System.Drawing.Point(100, 90)
        Me.ucrInpuTicktLineEnd.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInpuTicktLineEnd.Name = "ucrInpuTicktLineEnd"
        Me.ucrInpuTicktLineEnd.Size = New System.Drawing.Size(137, 21)
        Me.ucrInpuTicktLineEnd.TabIndex = 32
        '
        'ucrNudTickSize
        '
        Me.ucrNudTickSize.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTickSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTickSize.Location = New System.Drawing.Point(100, 19)
        Me.ucrNudTickSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTickSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTickSize.Name = "ucrNudTickSize"
        Me.ucrNudTickSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTickSize.TabIndex = 30
        Me.ucrNudTickSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputTickLineType
        '
        Me.ucrInputTickLineType.AddQuotesIfUnrecognised = True
        Me.ucrInputTickLineType.IsReadOnly = False
        Me.ucrInputTickLineType.Location = New System.Drawing.Point(100, 42)
        Me.ucrInputTickLineType.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputTickLineType.Name = "ucrInputTickLineType"
        Me.ucrInputTickLineType.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputTickLineType.TabIndex = 26
        '
        'ucrTickMarksAndLabels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpTickMarks)
        Me.Name = "ucrTickMarksAndLabels"
        Me.Size = New System.Drawing.Size(255, 123)
        Me.grpTickMarks.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpTickMarks As GroupBox
    Friend WithEvents ucrChkTickLineEnd As ucrCheck
    Friend WithEvents ucrChkTickSize As ucrCheck
    Friend WithEvents ucrChkTickLineType As ucrCheck
    Friend WithEvents ucrChkTickColour As ucrCheck
    Friend WithEvents ucrInpuTicktLineEnd As ucrInputComboBox
    Friend WithEvents ucrNudTickSize As ucrNud
    Friend WithEvents ucrInputTickLineType As ucrInputComboBox
    Friend WithEvents ucrColors As ucrColors
End Class
