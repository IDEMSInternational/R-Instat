<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgTricotModelOptions
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
        Me.ucrNudNumberIt = New instat.ucrNud()
        Me.ucrNudPenaltyPar = New instat.ucrNud()
        Me.ucrSdgButton = New instat.ucrButtonsSubdialogue()
        Me.ucrInputConvTotal = New instat.ucrInputTextBox()
        Me.ucrChkPenaltyPar = New instat.ucrCheck()
        Me.ucrChkNumberIt = New instat.ucrCheck()
        Me.ucrChkConvTotal = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'ucrNudNumberIt
        '
        Me.ucrNudNumberIt.AutoSize = True
        Me.ucrNudNumberIt.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberIt.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberIt.Location = New System.Drawing.Point(166, 84)
        Me.ucrNudNumberIt.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberIt.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberIt.Name = "ucrNudNumberIt"
        Me.ucrNudNumberIt.Size = New System.Drawing.Size(137, 20)
        Me.ucrNudNumberIt.TabIndex = 6
        Me.ucrNudNumberIt.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudPenaltyPar
        '
        Me.ucrNudPenaltyPar.AutoSize = True
        Me.ucrNudPenaltyPar.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPenaltyPar.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPenaltyPar.Location = New System.Drawing.Point(166, 37)
        Me.ucrNudPenaltyPar.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPenaltyPar.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPenaltyPar.Name = "ucrNudPenaltyPar"
        Me.ucrNudPenaltyPar.Size = New System.Drawing.Size(137, 20)
        Me.ucrNudPenaltyPar.TabIndex = 4
        Me.ucrNudPenaltyPar.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSdgButton
        '
        Me.ucrSdgButton.AutoSize = True
        Me.ucrSdgButton.Location = New System.Drawing.Point(37, 183)
        Me.ucrSdgButton.Name = "ucrSdgButton"
        Me.ucrSdgButton.Size = New System.Drawing.Size(224, 29)
        Me.ucrSdgButton.TabIndex = 0
        '
        'ucrInputConvTotal
        '
        Me.ucrInputConvTotal.AddQuotesIfUnrecognised = True
        Me.ucrInputConvTotal.AutoSize = True
        Me.ucrInputConvTotal.IsMultiline = False
        Me.ucrInputConvTotal.IsReadOnly = False
        Me.ucrInputConvTotal.Location = New System.Drawing.Point(166, 130)
        Me.ucrInputConvTotal.Name = "ucrInputConvTotal"
        Me.ucrInputConvTotal.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputConvTotal.TabIndex = 7
        '
        'ucrChkPenaltyPar
        '
        Me.ucrChkPenaltyPar.AutoSize = True
        Me.ucrChkPenaltyPar.Checked = False
        Me.ucrChkPenaltyPar.Location = New System.Drawing.Point(15, 37)
        Me.ucrChkPenaltyPar.Name = "ucrChkPenaltyPar"
        Me.ucrChkPenaltyPar.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkPenaltyPar.TabIndex = 8
        '
        'ucrChkNumberIt
        '
        Me.ucrChkNumberIt.AutoSize = True
        Me.ucrChkNumberIt.Checked = False
        Me.ucrChkNumberIt.Location = New System.Drawing.Point(15, 84)
        Me.ucrChkNumberIt.Name = "ucrChkNumberIt"
        Me.ucrChkNumberIt.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkNumberIt.TabIndex = 9
        '
        'ucrChkConvTotal
        '
        Me.ucrChkConvTotal.AutoSize = True
        Me.ucrChkConvTotal.Checked = False
        Me.ucrChkConvTotal.Location = New System.Drawing.Point(15, 128)
        Me.ucrChkConvTotal.Name = "ucrChkConvTotal"
        Me.ucrChkConvTotal.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkConvTotal.TabIndex = 10
        '
        'sdgTricotModelOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 237)
        Me.Controls.Add(Me.ucrChkConvTotal)
        Me.Controls.Add(Me.ucrChkNumberIt)
        Me.Controls.Add(Me.ucrChkPenaltyPar)
        Me.Controls.Add(Me.ucrInputConvTotal)
        Me.Controls.Add(Me.ucrNudNumberIt)
        Me.Controls.Add(Me.ucrNudPenaltyPar)
        Me.Controls.Add(Me.ucrSdgButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgTricotModelOptions"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sdgTricotModelOptions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSdgButton As ucrButtonsSubdialogue
    Friend WithEvents ucrNudPenaltyPar As ucrNud
    Friend WithEvents ucrNudNumberIt As ucrNud
    Friend WithEvents ucrInputConvTotal As ucrInputTextBox
    Friend WithEvents ucrChkPenaltyPar As ucrCheck
    Friend WithEvents ucrChkNumberIt As ucrCheck
    Friend WithEvents ucrChkConvTotal As ucrCheck
End Class
