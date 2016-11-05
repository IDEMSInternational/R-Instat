<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrDialogDisabled
    Inherits System.Windows.Forms.UserControl

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
        Me.lblDisabled = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDisabled
        '
        Me.lblDisabled.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDisabled.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblDisabled.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisabled.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDisabled.Location = New System.Drawing.Point(0, 0)
        Me.lblDisabled.Name = "lblDisabled"
        Me.lblDisabled.Size = New System.Drawing.Size(241, 51)
        Me.lblDisabled.TabIndex = 0
        Me.lblDisabled.Text = "This dialog is not yet functioning. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It is for viewing only." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "OK cannot be enabl" &
    "ed." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblDisabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucrDialogDisabled
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblDisabled)
        Me.Name = "ucrDialogDisabled"
        Me.Size = New System.Drawing.Size(240, 50)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblDisabled As Label
End Class
