<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrRowExpression
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
        Me.btnSet = New System.Windows.Forms.Button()
        Me.UcrInputRowExpression = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'btnSet
        '
        Me.btnSet.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSet.Location = New System.Drawing.Point(148, 2)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(44, 23)
        Me.btnSet.TabIndex = 341
        Me.btnSet.Tag = ""
        Me.btnSet.Text = "Set"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'UcrInputRowExpression
        '
        Me.UcrInputRowExpression.AddQuotesIfUnrecognised = True
        Me.UcrInputRowExpression.AutoSize = True
        Me.UcrInputRowExpression.IsMultiline = False
        Me.UcrInputRowExpression.IsReadOnly = False
        Me.UcrInputRowExpression.Location = New System.Drawing.Point(6, 4)
        Me.UcrInputRowExpression.Name = "UcrInputRowExpression"
        Me.UcrInputRowExpression.Size = New System.Drawing.Size(142, 21)
        Me.UcrInputRowExpression.TabIndex = 340
        '
        'ucrRowExpression
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.UcrInputRowExpression)
        Me.Name = "ucrRowExpression"
        Me.Size = New System.Drawing.Size(193, 26)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSet As Button
    Friend WithEvents UcrInputRowExpression As ucrInputTextBox
End Class
