<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgcolrowname
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcolrowname = New System.Windows.Forms.TextBox()
        Me.cmdClickOk = New System.Windows.Forms.Button()
        Me.btnClickCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'txtcolrowname
        '
        Me.txtcolrowname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcolrowname.Location = New System.Drawing.Point(87, 15)
        Me.txtcolrowname.Name = "txtcolrowname"
        Me.txtcolrowname.Size = New System.Drawing.Size(100, 20)
        Me.txtcolrowname.TabIndex = 1
        '
        'cmdClickOk
        '
        Me.cmdClickOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdClickOk.Location = New System.Drawing.Point(2, 44)
        Me.cmdClickOk.Name = "cmdClickOk"
        Me.cmdClickOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdClickOk.TabIndex = 2
        Me.cmdClickOk.Text = "OK"
        Me.cmdClickOk.UseVisualStyleBackColor = True
        '
        'btnClickCancel
        '
        Me.btnClickCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClickCancel.Location = New System.Drawing.Point(112, 44)
        Me.btnClickCancel.Name = "btnClickCancel"
        Me.btnClickCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnClickCancel.TabIndex = 3
        Me.btnClickCancel.Text = "Cancel"
        Me.btnClickCancel.UseVisualStyleBackColor = True
        '
        'dlgcolrowname
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(199, 71)
        Me.Controls.Add(Me.btnClickCancel)
        Me.Controls.Add(Me.cmdClickOk)
        Me.Controls.Add(Me.txtcolrowname)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgcolrowname"
        Me.Text = "New Name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtcolrowname As TextBox
    Friend WithEvents cmdClickOk As Button
    Friend WithEvents btnClickCancel As Button
End Class
