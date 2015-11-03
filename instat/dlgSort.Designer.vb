<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgSort
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.UcrDataSelection1 = New instat.ucrDataSelection()
        Me.UcrButtons1 = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'UcrDataSelection1
        '
        Me.UcrDataSelection1.Location = New System.Drawing.Point(1, 1)
        Me.UcrDataSelection1.Name = "UcrDataSelection1"
        Me.UcrDataSelection1.Size = New System.Drawing.Size(366, 122)
        Me.UcrDataSelection1.TabIndex = 1
        '
        'UcrButtons1
        '
        Me.UcrButtons1.Location = New System.Drawing.Point(12, 185)
        Me.UcrButtons1.Name = "UcrButtons1"
        Me.UcrButtons1.Size = New System.Drawing.Size(327, 35)
        Me.UcrButtons1.TabIndex = 0
        '
        'dlgSort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 245)
        Me.Controls.Add(Me.UcrDataSelection1)
        Me.Controls.Add(Me.UcrButtons1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSort"
        Me.Text = "Sort"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcrButtons1 As ucrButtons
    Friend WithEvents UcrDataSelection1 As ucrDataSelection
End Class
