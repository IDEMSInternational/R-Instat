<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgCellFormatTextOptions
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
        Me.rdoEmail = New System.Windows.Forms.RadioButton()
        Me.ucrInputFormatExpression = New instat.ucrInputTextBox()
        Me.rdoCustom = New System.Windows.Forms.RadioButton()
        Me.rdoUnits = New System.Windows.Forms.RadioButton()
        Me.ucrCellFormatEmail = New instat.ucrCellFormatEmail()
        Me.ucrSdgBaseButtons = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'rdoEmail
        '
        Me.rdoEmail.AutoSize = True
        Me.rdoEmail.Location = New System.Drawing.Point(5, 76)
        Me.rdoEmail.Name = "rdoEmail"
        Me.rdoEmail.Size = New System.Drawing.Size(65, 17)
        Me.rdoEmail.TabIndex = 339
        Me.rdoEmail.TabStop = True
        Me.rdoEmail.Text = "As Email"
        Me.rdoEmail.UseVisualStyleBackColor = True
        '
        'ucrInputFormatExpression
        '
        Me.ucrInputFormatExpression.AddQuotesIfUnrecognised = True
        Me.ucrInputFormatExpression.AutoSize = True
        Me.ucrInputFormatExpression.IsMultiline = False
        Me.ucrInputFormatExpression.IsReadOnly = False
        Me.ucrInputFormatExpression.Location = New System.Drawing.Point(123, 8)
        Me.ucrInputFormatExpression.Name = "ucrInputFormatExpression"
        Me.ucrInputFormatExpression.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputFormatExpression.TabIndex = 338
        '
        'rdoCustom
        '
        Me.rdoCustom.AutoSize = True
        Me.rdoCustom.Location = New System.Drawing.Point(6, 8)
        Me.rdoCustom.Name = "rdoCustom"
        Me.rdoCustom.Size = New System.Drawing.Size(95, 17)
        Me.rdoCustom.TabIndex = 337
        Me.rdoCustom.TabStop = True
        Me.rdoCustom.Text = "Custom Format"
        Me.rdoCustom.UseVisualStyleBackColor = True
        '
        'rdoUnits
        '
        Me.rdoUnits.AutoSize = True
        Me.rdoUnits.Location = New System.Drawing.Point(6, 42)
        Me.rdoUnits.Name = "rdoUnits"
        Me.rdoUnits.Size = New System.Drawing.Size(64, 17)
        Me.rdoUnits.TabIndex = 336
        Me.rdoUnits.TabStop = True
        Me.rdoUnits.Text = "As Units"
        Me.rdoUnits.UseVisualStyleBackColor = True
        '
        'ucrCellFormatEmail
        '
        Me.ucrCellFormatEmail.Location = New System.Drawing.Point(123, 76)
        Me.ucrCellFormatEmail.Name = "ucrCellFormatEmail"
        Me.ucrCellFormatEmail.Size = New System.Drawing.Size(190, 154)
        Me.ucrCellFormatEmail.TabIndex = 340
        '
        'ucrSdgBaseButtons
        '
        Me.ucrSdgBaseButtons.AutoSize = True
        Me.ucrSdgBaseButtons.Location = New System.Drawing.Point(52, 237)
        Me.ucrSdgBaseButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrSdgBaseButtons.Name = "ucrSdgBaseButtons"
        Me.ucrSdgBaseButtons.Size = New System.Drawing.Size(224, 30)
        Me.ucrSdgBaseButtons.TabIndex = 341
        '
        'sdgCellFormatTextOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 271)
        Me.Controls.Add(Me.ucrSdgBaseButtons)
        Me.Controls.Add(Me.rdoEmail)
        Me.Controls.Add(Me.ucrInputFormatExpression)
        Me.Controls.Add(Me.rdoCustom)
        Me.Controls.Add(Me.rdoUnits)
        Me.Controls.Add(Me.ucrCellFormatEmail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgCellFormatTextOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cell Text Format Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdoEmail As RadioButton
    Friend WithEvents ucrInputFormatExpression As ucrInputTextBox
    Friend WithEvents rdoCustom As RadioButton
    Friend WithEvents rdoUnits As RadioButton
    Friend WithEvents ucrCellFormatEmail As ucrCellFormatEmail
    Friend WithEvents ucrSdgBaseButtons As ucrButtonsSubdialogue
End Class
