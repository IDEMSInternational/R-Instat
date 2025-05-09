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
        Me.ucrNudPenaltyPar = New instat.ucrNud()
        Me.ucrSdgButton = New instat.ucrButtonsSubdialogue()
        Me.ucrInputConvTotal = New instat.ucrInputTextBox()
        Me.ucrChkPenaltyPar = New instat.ucrCheck()
        Me.ucrChkNumberIt = New instat.ucrCheck()
        Me.ucrChkConvTotal = New instat.ucrCheck()
        Me.ucrInputNumberIt = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'ucrNudPenaltyPar
        '
        Me.ucrNudPenaltyPar.AutoSize = True
        Me.ucrNudPenaltyPar.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPenaltyPar.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPenaltyPar.Location = New System.Drawing.Point(252, 18)
        Me.ucrNudPenaltyPar.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudPenaltyPar.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPenaltyPar.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPenaltyPar.Name = "ucrNudPenaltyPar"
        Me.ucrNudPenaltyPar.Size = New System.Drawing.Size(108, 31)
        Me.ucrNudPenaltyPar.TabIndex = 4
        Me.ucrNudPenaltyPar.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSdgButton
        '
        Me.ucrSdgButton.AutoSize = True
        Me.ucrSdgButton.Location = New System.Drawing.Point(18, 203)
        Me.ucrSdgButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrSdgButton.Name = "ucrSdgButton"
        Me.ucrSdgButton.Size = New System.Drawing.Size(336, 45)
        Me.ucrSdgButton.TabIndex = 0
        '
        'ucrInputConvTotal
        '
        Me.ucrInputConvTotal.AddQuotesIfUnrecognised = True
        Me.ucrInputConvTotal.AutoSize = True
        Me.ucrInputConvTotal.IsMultiline = False
        Me.ucrInputConvTotal.IsReadOnly = False
        Me.ucrInputConvTotal.Location = New System.Drawing.Point(252, 146)
        Me.ucrInputConvTotal.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputConvTotal.Name = "ucrInputConvTotal"
        Me.ucrInputConvTotal.Size = New System.Drawing.Size(108, 32)
        Me.ucrInputConvTotal.TabIndex = 7
        '
        'ucrChkPenaltyPar
        '
        Me.ucrChkPenaltyPar.AutoSize = True
        Me.ucrChkPenaltyPar.Checked = False
        Me.ucrChkPenaltyPar.Location = New System.Drawing.Point(18, 18)
        Me.ucrChkPenaltyPar.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkPenaltyPar.Name = "ucrChkPenaltyPar"
        Me.ucrChkPenaltyPar.Size = New System.Drawing.Size(219, 35)
        Me.ucrChkPenaltyPar.TabIndex = 8
        '
        'ucrChkNumberIt
        '
        Me.ucrChkNumberIt.AutoSize = True
        Me.ucrChkNumberIt.Checked = False
        Me.ucrChkNumberIt.Location = New System.Drawing.Point(18, 83)
        Me.ucrChkNumberIt.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkNumberIt.Name = "ucrChkNumberIt"
        Me.ucrChkNumberIt.Size = New System.Drawing.Size(219, 35)
        Me.ucrChkNumberIt.TabIndex = 9
        '
        'ucrChkConvTotal
        '
        Me.ucrChkConvTotal.AutoSize = True
        Me.ucrChkConvTotal.Checked = False
        Me.ucrChkConvTotal.Location = New System.Drawing.Point(18, 143)
        Me.ucrChkConvTotal.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkConvTotal.Name = "ucrChkConvTotal"
        Me.ucrChkConvTotal.Size = New System.Drawing.Size(219, 35)
        Me.ucrChkConvTotal.TabIndex = 10
        '
        'ucrInputNumberIt
        '
        Me.ucrInputNumberIt.AddQuotesIfUnrecognised = True
        Me.ucrInputNumberIt.AutoSize = True
        Me.ucrInputNumberIt.IsMultiline = False
        Me.ucrInputNumberIt.IsReadOnly = False
        Me.ucrInputNumberIt.Location = New System.Drawing.Point(252, 83)
        Me.ucrInputNumberIt.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputNumberIt.Name = "ucrInputNumberIt"
        Me.ucrInputNumberIt.Size = New System.Drawing.Size(108, 32)
        Me.ucrInputNumberIt.TabIndex = 11
        '
        'sdgTricotModelOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 269)
        Me.Controls.Add(Me.ucrInputNumberIt)
        Me.Controls.Add(Me.ucrChkConvTotal)
        Me.Controls.Add(Me.ucrChkNumberIt)
        Me.Controls.Add(Me.ucrChkPenaltyPar)
        Me.Controls.Add(Me.ucrInputConvTotal)
        Me.Controls.Add(Me.ucrNudPenaltyPar)
        Me.Controls.Add(Me.ucrSdgButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "sdgTricotModelOptions"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Model Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSdgButton As ucrButtonsSubdialogue
    Friend WithEvents ucrNudPenaltyPar As ucrNud
    Friend WithEvents ucrInputConvTotal As ucrInputTextBox
    Friend WithEvents ucrChkPenaltyPar As ucrCheck
    Friend WithEvents ucrChkNumberIt As ucrCheck
    Friend WithEvents ucrChkConvTotal As ucrCheck
    Friend WithEvents ucrInputNumberIt As ucrInputTextBox
End Class
