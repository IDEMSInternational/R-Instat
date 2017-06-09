<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrElementRectControl
    Inherits instat.ucrCore

    'UserControl overrides dispose to clean up the component list.
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
        Me.grpElementRect = New System.Windows.Forms.GroupBox()
        Me.ucrLegendFill = New instat.ucrColors()
        Me.ucrLegendColors = New instat.ucrColors()
        Me.ucrChkLegendFill = New instat.ucrCheck()
        Me.ucrChkLegendSize = New instat.ucrCheck()
        Me.ucrChkLegendLineType = New instat.ucrCheck()
        Me.ucrChkLegendColour = New instat.ucrCheck()
        Me.ucrNudLegendSize = New instat.ucrNud()
        Me.ucrInputLegendLineType = New instat.ucrInputComboBox()
        Me.grpElementRect.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpElementRect
        '
        Me.grpElementRect.Controls.Add(Me.ucrLegendFill)
        Me.grpElementRect.Controls.Add(Me.ucrLegendColors)
        Me.grpElementRect.Controls.Add(Me.ucrChkLegendFill)
        Me.grpElementRect.Controls.Add(Me.ucrChkLegendSize)
        Me.grpElementRect.Controls.Add(Me.ucrChkLegendLineType)
        Me.grpElementRect.Controls.Add(Me.ucrChkLegendColour)
        Me.grpElementRect.Controls.Add(Me.ucrNudLegendSize)
        Me.grpElementRect.Controls.Add(Me.ucrInputLegendLineType)
        Me.grpElementRect.Location = New System.Drawing.Point(8, 3)
        Me.grpElementRect.Name = "grpElementRect"
        Me.grpElementRect.Size = New System.Drawing.Size(238, 122)
        Me.grpElementRect.TabIndex = 0
        Me.grpElementRect.TabStop = False
        Me.grpElementRect.Text = "ElementRect"
        '
        'ucrLegendFill
        '
        Me.ucrLegendFill.AddQuotesIfUnrecognised = True
        Me.ucrLegendFill.IsReadOnly = False
        Me.ucrLegendFill.Location = New System.Drawing.Point(95, 90)
        Me.ucrLegendFill.Name = "ucrLegendFill"
        Me.ucrLegendFill.Size = New System.Drawing.Size(137, 21)
        Me.ucrLegendFill.TabIndex = 98
        '
        'ucrLegendColors
        '
        Me.ucrLegendColors.AddQuotesIfUnrecognised = True
        Me.ucrLegendColors.IsReadOnly = False
        Me.ucrLegendColors.Location = New System.Drawing.Point(95, 65)
        Me.ucrLegendColors.Name = "ucrLegendColors"
        Me.ucrLegendColors.Size = New System.Drawing.Size(137, 21)
        Me.ucrLegendColors.TabIndex = 95
        '
        'ucrChkLegendFill
        '
        Me.ucrChkLegendFill.Checked = False
        Me.ucrChkLegendFill.Location = New System.Drawing.Point(6, 91)
        Me.ucrChkLegendFill.Name = "ucrChkLegendFill"
        Me.ucrChkLegendFill.Size = New System.Drawing.Size(88, 20)
        Me.ucrChkLegendFill.TabIndex = 94
        '
        'ucrChkLegendSize
        '
        Me.ucrChkLegendSize.Checked = False
        Me.ucrChkLegendSize.Location = New System.Drawing.Point(6, 19)
        Me.ucrChkLegendSize.Name = "ucrChkLegendSize"
        Me.ucrChkLegendSize.Size = New System.Drawing.Size(88, 20)
        Me.ucrChkLegendSize.TabIndex = 93
        '
        'ucrChkLegendLineType
        '
        Me.ucrChkLegendLineType.Checked = False
        Me.ucrChkLegendLineType.Location = New System.Drawing.Point(6, 43)
        Me.ucrChkLegendLineType.Name = "ucrChkLegendLineType"
        Me.ucrChkLegendLineType.Size = New System.Drawing.Size(88, 20)
        Me.ucrChkLegendLineType.TabIndex = 92
        '
        'ucrChkLegendColour
        '
        Me.ucrChkLegendColour.Checked = False
        Me.ucrChkLegendColour.Location = New System.Drawing.Point(6, 67)
        Me.ucrChkLegendColour.Name = "ucrChkLegendColour"
        Me.ucrChkLegendColour.Size = New System.Drawing.Size(88, 20)
        Me.ucrChkLegendColour.TabIndex = 91
        '
        'ucrNudLegendSize
        '
        Me.ucrNudLegendSize.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLegendSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLegendSize.Location = New System.Drawing.Point(95, 18)
        Me.ucrNudLegendSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLegendSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLegendSize.Name = "ucrNudLegendSize"
        Me.ucrNudLegendSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLegendSize.TabIndex = 89
        Me.ucrNudLegendSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputLegendLineType
        '
        Me.ucrInputLegendLineType.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendLineType.IsReadOnly = False
        Me.ucrInputLegendLineType.Location = New System.Drawing.Point(95, 41)
        Me.ucrInputLegendLineType.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputLegendLineType.Name = "ucrInputLegendLineType"
        Me.ucrInputLegendLineType.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLegendLineType.TabIndex = 88
        '
        'ucrElementRectControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpElementRect)
        Me.Name = "ucrElementRectControl"
        Me.Size = New System.Drawing.Size(253, 131)
        Me.grpElementRect.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpElementRect As GroupBox
    Friend WithEvents ucrLegendColors As ucrColors
    Friend WithEvents ucrChkLegendFill As ucrCheck
    Friend WithEvents ucrChkLegendSize As ucrCheck
    Friend WithEvents ucrChkLegendLineType As ucrCheck
    Friend WithEvents ucrChkLegendColour As ucrCheck
    Friend WithEvents ucrNudLegendSize As ucrNud
    Friend WithEvents ucrInputLegendLineType As ucrInputComboBox
    Friend WithEvents ucrLegendFill As ucrColors
End Class
