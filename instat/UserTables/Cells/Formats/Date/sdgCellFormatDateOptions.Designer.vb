<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgCellFormatDateOptions
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
        Me.ucrInputCboDateFormat = New instat.ucrInputComboBox()
        Me.lblDateFormat = New System.Windows.Forms.Label()
        Me.ucrSdgBaseButtons = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'ucrInputCboDateFormat
        '
        Me.ucrInputCboDateFormat.AddQuotesIfUnrecognised = True
        Me.ucrInputCboDateFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCboDateFormat.GetSetSelectedIndex = -1
        Me.ucrInputCboDateFormat.IsReadOnly = False
        Me.ucrInputCboDateFormat.Location = New System.Drawing.Point(12, 25)
        Me.ucrInputCboDateFormat.Name = "ucrInputCboDateFormat"
        Me.ucrInputCboDateFormat.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputCboDateFormat.TabIndex = 0
        '
        'lblDateFormat
        '
        Me.lblDateFormat.AutoSize = True
        Me.lblDateFormat.Location = New System.Drawing.Point(7, 9)
        Me.lblDateFormat.Name = "lblDateFormat"
        Me.lblDateFormat.Size = New System.Drawing.Size(103, 13)
        Me.lblDateFormat.TabIndex = 1
        Me.lblDateFormat.Text = "Specify Date Format"
        '
        'ucrSdgBaseButtons
        '
        Me.ucrSdgBaseButtons.AutoSize = True
        Me.ucrSdgBaseButtons.Location = New System.Drawing.Point(10, 65)
        Me.ucrSdgBaseButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrSdgBaseButtons.Name = "ucrSdgBaseButtons"
        Me.ucrSdgBaseButtons.Size = New System.Drawing.Size(224, 30)
        Me.ucrSdgBaseButtons.TabIndex = 343
        '
        'sdgCellFormatDateOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 103)
        Me.Controls.Add(Me.ucrSdgBaseButtons)
        Me.Controls.Add(Me.lblDateFormat)
        Me.Controls.Add(Me.ucrInputCboDateFormat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgCellFormatDateOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cell Date Format Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrInputCboDateFormat As ucrInputComboBox
    Friend WithEvents lblDateFormat As Label
    Friend WithEvents ucrSdgBaseButtons As ucrButtonsSubdialogue
End Class
