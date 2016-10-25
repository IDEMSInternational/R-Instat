<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgClimdexIndices
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
        Me.ucrButtonsClimdexIndices = New instat.ucrButtonsSubdialogue()
        Me.chkFrostDays = New System.Windows.Forms.CheckBox()
        Me.chkTropicalNights = New System.Windows.Forms.CheckBox()
        Me.chkIcingDays = New System.Windows.Forms.CheckBox()
        Me.chkSummerDays = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ucrButtonsClimdexIndices
        '
        Me.ucrButtonsClimdexIndices.Location = New System.Drawing.Point(117, 231)
        Me.ucrButtonsClimdexIndices.Name = "ucrButtonsClimdexIndices"
        Me.ucrButtonsClimdexIndices.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsClimdexIndices.TabIndex = 0
        '
        'chkFrostDays
        '
        Me.chkFrostDays.AutoSize = True
        Me.chkFrostDays.Location = New System.Drawing.Point(27, 27)
        Me.chkFrostDays.Name = "chkFrostDays"
        Me.chkFrostDays.Size = New System.Drawing.Size(76, 17)
        Me.chkFrostDays.TabIndex = 1
        Me.chkFrostDays.Tag = "Frost_Days"
        Me.chkFrostDays.Text = "Frost Days"
        Me.chkFrostDays.UseVisualStyleBackColor = True
        '
        'chkTropicalNights
        '
        Me.chkTropicalNights.AutoSize = True
        Me.chkTropicalNights.Location = New System.Drawing.Point(248, 97)
        Me.chkTropicalNights.Name = "chkTropicalNights"
        Me.chkTropicalNights.Size = New System.Drawing.Size(97, 17)
        Me.chkTropicalNights.TabIndex = 2
        Me.chkTropicalNights.Tag = "Tropical_Nights"
        Me.chkTropicalNights.Text = "Tropical Nights"
        Me.chkTropicalNights.UseVisualStyleBackColor = True
        '
        'chkIcingDays
        '
        Me.chkIcingDays.AutoSize = True
        Me.chkIcingDays.Location = New System.Drawing.Point(27, 97)
        Me.chkIcingDays.Name = "chkIcingDays"
        Me.chkIcingDays.Size = New System.Drawing.Size(76, 17)
        Me.chkIcingDays.TabIndex = 3
        Me.chkIcingDays.Tag = "Icing_Days"
        Me.chkIcingDays.Text = "Icing Days"
        Me.chkIcingDays.UseVisualStyleBackColor = True
        '
        'chkSummerDays
        '
        Me.chkSummerDays.AutoSize = True
        Me.chkSummerDays.Location = New System.Drawing.Point(248, 36)
        Me.chkSummerDays.Name = "chkSummerDays"
        Me.chkSummerDays.Size = New System.Drawing.Size(91, 17)
        Me.chkSummerDays.TabIndex = 4
        Me.chkSummerDays.Tag = "Summer_Days"
        Me.chkSummerDays.Text = "Summer Days"
        Me.chkSummerDays.UseVisualStyleBackColor = True
        '
        'sdgClimdexIndices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 261)
        Me.Controls.Add(Me.chkSummerDays)
        Me.Controls.Add(Me.chkIcingDays)
        Me.Controls.Add(Me.chkTropicalNights)
        Me.Controls.Add(Me.chkFrostDays)
        Me.Controls.Add(Me.ucrButtonsClimdexIndices)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgClimdexIndices"
        Me.Tag = "Climdex_Indices"
        Me.Text = "Climdex Indices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrButtonsClimdexIndices As ucrButtonsSubdialogue
    Friend WithEvents chkFrostDays As CheckBox
    Friend WithEvents chkTropicalNights As CheckBox
    Friend WithEvents chkIcingDays As CheckBox
    Friend WithEvents chkSummerDays As CheckBox
End Class
