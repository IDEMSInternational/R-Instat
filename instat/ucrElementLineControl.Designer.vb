﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.ucrLineColors = New instat.ucrColors()
        Me.ucrChkLineLineEnd = New instat.ucrCheck()
        Me.ucrChkLineSize = New instat.ucrCheck()
        Me.ucrChkLineLineType = New instat.ucrCheck()
        Me.ucrChkLineColour = New instat.ucrCheck()
        Me.ucrInputLineLineEnd = New instat.ucrInputComboBox()
        Me.ucrNudLineSize = New instat.ucrNud()
        Me.ucrInputLineLineType = New instat.ucrInputComboBox()
        Me.grpTickMarks.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTickMarks
        '
        Me.grpTickMarks.Controls.Add(Me.ucrLineColors)
        Me.grpTickMarks.Controls.Add(Me.ucrChkLineLineEnd)
        Me.grpTickMarks.Controls.Add(Me.ucrChkLineSize)
        Me.grpTickMarks.Controls.Add(Me.ucrChkLineLineType)
        Me.grpTickMarks.Controls.Add(Me.ucrChkLineColour)
        Me.grpTickMarks.Controls.Add(Me.ucrInputLineLineEnd)
        Me.grpTickMarks.Controls.Add(Me.ucrNudLineSize)
        Me.grpTickMarks.Controls.Add(Me.ucrInputLineLineType)
        Me.grpTickMarks.Location = New System.Drawing.Point(3, 0)
        Me.grpTickMarks.Name = "grpTickMarks"
        Me.grpTickMarks.Size = New System.Drawing.Size(246, 119)
        Me.grpTickMarks.TabIndex = 41
        Me.grpTickMarks.TabStop = False
        Me.grpTickMarks.Text = "Element Line"
        '
        'ucrLineColors
        '
        Me.ucrLineColors.AddQuotesIfUnrecognised = True
        Me.ucrLineColors.IsReadOnly = False
        Me.ucrLineColors.Location = New System.Drawing.Point(105, 68)
        Me.ucrLineColors.Name = "ucrLineColors"
        Me.ucrLineColors.Size = New System.Drawing.Size(137, 21)
        Me.ucrLineColors.TabIndex = 87
        '
        'ucrChkLineLineEnd
        '
        Me.ucrChkLineLineEnd.Checked = False
        Me.ucrChkLineLineEnd.Location = New System.Drawing.Point(8, 94)
        Me.ucrChkLineLineEnd.Name = "ucrChkLineLineEnd"
        Me.ucrChkLineLineEnd.Size = New System.Drawing.Size(88, 20)
        Me.ucrChkLineLineEnd.TabIndex = 54
        '
        'ucrChkLineSize
        '
        Me.ucrChkLineSize.Checked = False
        Me.ucrChkLineSize.Location = New System.Drawing.Point(8, 19)
        Me.ucrChkLineSize.Name = "ucrChkLineSize"
        Me.ucrChkLineSize.Size = New System.Drawing.Size(88, 20)
        Me.ucrChkLineSize.TabIndex = 53
        '
        'ucrChkLineLineType
        '
        Me.ucrChkLineLineType.Checked = False
        Me.ucrChkLineLineType.Location = New System.Drawing.Point(8, 44)
        Me.ucrChkLineLineType.Name = "ucrChkLineLineType"
        Me.ucrChkLineLineType.Size = New System.Drawing.Size(88, 20)
        Me.ucrChkLineLineType.TabIndex = 52
        '
        'ucrChkLineColour
        '
        Me.ucrChkLineColour.Checked = False
        Me.ucrChkLineColour.Location = New System.Drawing.Point(8, 69)
        Me.ucrChkLineColour.Name = "ucrChkLineColour"
        Me.ucrChkLineColour.Size = New System.Drawing.Size(88, 20)
        Me.ucrChkLineColour.TabIndex = 51
        '
        'ucrInputLineLineEnd
        '
        Me.ucrInputLineLineEnd.AddQuotesIfUnrecognised = True
        Me.ucrInputLineLineEnd.IsReadOnly = False
        Me.ucrInputLineLineEnd.Location = New System.Drawing.Point(105, 93)
        Me.ucrInputLineLineEnd.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputLineLineEnd.Name = "ucrInputLineLineEnd"
        Me.ucrInputLineLineEnd.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLineLineEnd.TabIndex = 32
        '
        'ucrNudLineSize
        '
        Me.ucrNudLineSize.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLineSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLineSize.Location = New System.Drawing.Point(105, 19)
        Me.ucrNudLineSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLineSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLineSize.Name = "ucrNudLineSize"
        Me.ucrNudLineSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLineSize.TabIndex = 30
        Me.ucrNudLineSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputLineLineType
        '
        Me.ucrInputLineLineType.AddQuotesIfUnrecognised = True
        Me.ucrInputLineLineType.IsReadOnly = False
        Me.ucrInputLineLineType.Location = New System.Drawing.Point(105, 43)
        Me.ucrInputLineLineType.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputLineLineType.Name = "ucrInputLineLineType"
        Me.ucrInputLineLineType.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLineLineType.TabIndex = 26
        '
        'ucrElementLineControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpTickMarks)
        Me.Name = "ucrElementLineControl"
        Me.Size = New System.Drawing.Size(255, 123)
        Me.grpTickMarks.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpTickMarks As GroupBox
    Friend WithEvents ucrChkLineLineEnd As ucrCheck
    Friend WithEvents ucrChkLineSize As ucrCheck
    Friend WithEvents ucrChkLineLineType As ucrCheck
    Friend WithEvents ucrChkLineColour As ucrCheck
    Friend WithEvents ucrInputLineLineEnd As ucrInputComboBox
    Friend WithEvents ucrNudLineSize As ucrNud
    Friend WithEvents ucrInputLineLineType As ucrInputComboBox
    Friend WithEvents ucrLineColors As ucrColors
End Class
