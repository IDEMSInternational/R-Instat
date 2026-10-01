<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgCellFormatNumberOptions
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
        Me.ucrChkSuffix = New instat.ucrCheck()
        Me.ucrInputSeperatorMark = New instat.ucrInputTextBox()
        Me.ucrChkSeparatorMark = New instat.ucrCheck()
        Me.ucrChkDropTrailingDecimalMark = New instat.ucrCheck()
        Me.ucrInputDecimalMark = New instat.ucrInputTextBox()
        Me.ucrChkDecimalMark = New instat.ucrCheck()
        Me.ucrChkDropTrailingZeros = New instat.ucrCheck()
        Me.ucrChkSignificantFigures = New instat.ucrCheck()
        Me.ucrChkDecimalPlaces = New instat.ucrCheck()
        Me.ucrNudSignificantFigures = New instat.ucrNud()
        Me.ucrNudDecimalPlaces = New instat.ucrNud()
        Me.ucrSdgBaseButtons = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'ucrChkSuffix
        '
        Me.ucrChkSuffix.AutoSize = True
        Me.ucrChkSuffix.Checked = False
        Me.ucrChkSuffix.Location = New System.Drawing.Point(8, 187)
        Me.ucrChkSuffix.Name = "ucrChkSuffix"
        Me.ucrChkSuffix.Size = New System.Drawing.Size(152, 23)
        Me.ucrChkSuffix.TabIndex = 28
        '
        'ucrInputSeperatorMark
        '
        Me.ucrInputSeperatorMark.AddQuotesIfUnrecognised = True
        Me.ucrInputSeperatorMark.AutoSize = True
        Me.ucrInputSeperatorMark.IsMultiline = False
        Me.ucrInputSeperatorMark.IsReadOnly = False
        Me.ucrInputSeperatorMark.Location = New System.Drawing.Point(166, 96)
        Me.ucrInputSeperatorMark.Name = "ucrInputSeperatorMark"
        Me.ucrInputSeperatorMark.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSeperatorMark.TabIndex = 27
        '
        'ucrChkSeparatorMark
        '
        Me.ucrChkSeparatorMark.AutoSize = True
        Me.ucrChkSeparatorMark.Checked = False
        Me.ucrChkSeparatorMark.Location = New System.Drawing.Point(8, 96)
        Me.ucrChkSeparatorMark.Name = "ucrChkSeparatorMark"
        Me.ucrChkSeparatorMark.Size = New System.Drawing.Size(152, 23)
        Me.ucrChkSeparatorMark.TabIndex = 26
        '
        'ucrChkDropTrailingDecimalMark
        '
        Me.ucrChkDropTrailingDecimalMark.AutoSize = True
        Me.ucrChkDropTrailingDecimalMark.Checked = False
        Me.ucrChkDropTrailingDecimalMark.Location = New System.Drawing.Point(8, 158)
        Me.ucrChkDropTrailingDecimalMark.Name = "ucrChkDropTrailingDecimalMark"
        Me.ucrChkDropTrailingDecimalMark.Size = New System.Drawing.Size(152, 23)
        Me.ucrChkDropTrailingDecimalMark.TabIndex = 25
        '
        'ucrInputDecimalMark
        '
        Me.ucrInputDecimalMark.AddQuotesIfUnrecognised = True
        Me.ucrInputDecimalMark.AutoSize = True
        Me.ucrInputDecimalMark.IsMultiline = False
        Me.ucrInputDecimalMark.IsReadOnly = False
        Me.ucrInputDecimalMark.Location = New System.Drawing.Point(166, 67)
        Me.ucrInputDecimalMark.Name = "ucrInputDecimalMark"
        Me.ucrInputDecimalMark.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDecimalMark.TabIndex = 24
        '
        'ucrChkDecimalMark
        '
        Me.ucrChkDecimalMark.AutoSize = True
        Me.ucrChkDecimalMark.Checked = False
        Me.ucrChkDecimalMark.Location = New System.Drawing.Point(8, 67)
        Me.ucrChkDecimalMark.Name = "ucrChkDecimalMark"
        Me.ucrChkDecimalMark.Size = New System.Drawing.Size(152, 23)
        Me.ucrChkDecimalMark.TabIndex = 23
        '
        'ucrChkDropTrailingZeros
        '
        Me.ucrChkDropTrailingZeros.AutoSize = True
        Me.ucrChkDropTrailingZeros.Checked = False
        Me.ucrChkDropTrailingZeros.Location = New System.Drawing.Point(8, 129)
        Me.ucrChkDropTrailingZeros.Name = "ucrChkDropTrailingZeros"
        Me.ucrChkDropTrailingZeros.Size = New System.Drawing.Size(152, 23)
        Me.ucrChkDropTrailingZeros.TabIndex = 22
        '
        'ucrChkSignificantFigures
        '
        Me.ucrChkSignificantFigures.AutoSize = True
        Me.ucrChkSignificantFigures.Checked = False
        Me.ucrChkSignificantFigures.Location = New System.Drawing.Point(8, 36)
        Me.ucrChkSignificantFigures.Name = "ucrChkSignificantFigures"
        Me.ucrChkSignificantFigures.Size = New System.Drawing.Size(152, 23)
        Me.ucrChkSignificantFigures.TabIndex = 21
        '
        'ucrChkDecimalPlaces
        '
        Me.ucrChkDecimalPlaces.AutoSize = True
        Me.ucrChkDecimalPlaces.Checked = False
        Me.ucrChkDecimalPlaces.Location = New System.Drawing.Point(8, 7)
        Me.ucrChkDecimalPlaces.Name = "ucrChkDecimalPlaces"
        Me.ucrChkDecimalPlaces.Size = New System.Drawing.Size(152, 23)
        Me.ucrChkDecimalPlaces.TabIndex = 20
        '
        'ucrNudSignificantFigures
        '
        Me.ucrNudSignificantFigures.AutoSize = True
        Me.ucrNudSignificantFigures.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSignificantFigures.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSignificantFigures.Location = New System.Drawing.Point(166, 39)
        Me.ucrNudSignificantFigures.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSignificantFigures.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSignificantFigures.Name = "ucrNudSignificantFigures"
        Me.ucrNudSignificantFigures.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSignificantFigures.TabIndex = 19
        Me.ucrNudSignificantFigures.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudDecimalPlaces
        '
        Me.ucrNudDecimalPlaces.AutoSize = True
        Me.ucrNudDecimalPlaces.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Location = New System.Drawing.Point(166, 7)
        Me.ucrNudDecimalPlaces.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDecimalPlaces.Name = "ucrNudDecimalPlaces"
        Me.ucrNudDecimalPlaces.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDecimalPlaces.TabIndex = 18
        Me.ucrNudDecimalPlaces.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSdgBaseButtons
        '
        Me.ucrSdgBaseButtons.AutoSize = True
        Me.ucrSdgBaseButtons.Location = New System.Drawing.Point(43, 223)
        Me.ucrSdgBaseButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrSdgBaseButtons.Name = "ucrSdgBaseButtons"
        Me.ucrSdgBaseButtons.Size = New System.Drawing.Size(224, 30)
        Me.ucrSdgBaseButtons.TabIndex = 342
        '
        'sdgCellFormatNumberOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 263)
        Me.Controls.Add(Me.ucrSdgBaseButtons)
        Me.Controls.Add(Me.ucrChkSuffix)
        Me.Controls.Add(Me.ucrInputSeperatorMark)
        Me.Controls.Add(Me.ucrChkSeparatorMark)
        Me.Controls.Add(Me.ucrChkDropTrailingDecimalMark)
        Me.Controls.Add(Me.ucrInputDecimalMark)
        Me.Controls.Add(Me.ucrChkDecimalMark)
        Me.Controls.Add(Me.ucrChkDropTrailingZeros)
        Me.Controls.Add(Me.ucrChkSignificantFigures)
        Me.Controls.Add(Me.ucrChkDecimalPlaces)
        Me.Controls.Add(Me.ucrNudSignificantFigures)
        Me.Controls.Add(Me.ucrNudDecimalPlaces)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgCellFormatNumberOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cell Format Number Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrChkSuffix As ucrCheck
    Friend WithEvents ucrInputSeperatorMark As ucrInputTextBox
    Friend WithEvents ucrChkSeparatorMark As ucrCheck
    Friend WithEvents ucrChkDropTrailingDecimalMark As ucrCheck
    Friend WithEvents ucrInputDecimalMark As ucrInputTextBox
    Friend WithEvents ucrChkDecimalMark As ucrCheck
    Friend WithEvents ucrChkDropTrailingZeros As ucrCheck
    Friend WithEvents ucrChkSignificantFigures As ucrCheck
    Friend WithEvents ucrChkDecimalPlaces As ucrCheck
    Friend WithEvents ucrNudSignificantFigures As ucrNud
    Friend WithEvents ucrNudDecimalPlaces As ucrNud
    Friend WithEvents ucrSdgBaseButtons As ucrButtonsSubdialogue
End Class
