<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgBoxPlot
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
        Me.lblTittle = New System.Windows.Forms.Label()
        Me.txtTittle = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'UcrDataSelection1
        '
        Me.UcrDataSelection1.Location = New System.Drawing.Point(40, 3)
        Me.UcrDataSelection1.Name = "UcrDataSelection1"
        Me.UcrDataSelection1.Size = New System.Drawing.Size(297, 122)
        Me.UcrDataSelection1.TabIndex = 1
        Me.UcrDataSelection1.UseWaitCursor = True
        '
        'UcrButtons1
        '
        Me.UcrButtons1.Location = New System.Drawing.Point(12, 166)
        Me.UcrButtons1.Name = "UcrButtons1"
        Me.UcrButtons1.Size = New System.Drawing.Size(404, 32)
        Me.UcrButtons1.TabIndex = 0
        Me.UcrButtons1.UseWaitCursor = True
        '
        'lblTittle
        '
        Me.lblTittle.AutoSize = True
        Me.lblTittle.Location = New System.Drawing.Point(23, 147)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(30, 13)
        Me.lblTittle.TabIndex = 2
        Me.lblTittle.Tag = "Tittle"
        Me.lblTittle.Text = "Tittle"
        Me.lblTittle.UseWaitCursor = True
        '
        'txtTittle
        '
        Me.txtTittle.Location = New System.Drawing.Point(85, 140)
        Me.txtTittle.Name = "txtTittle"
        Me.txtTittle.Size = New System.Drawing.Size(208, 20)
        Me.txtTittle.TabIndex = 3
        Me.txtTittle.UseWaitCursor = True
        '
        'dlgBoxPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 205)
        Me.Controls.Add(Me.txtTittle)
        Me.Controls.Add(Me.lblTittle)
        Me.Controls.Add(Me.UcrDataSelection1)
        Me.Controls.Add(Me.UcrButtons1)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgBoxPlot"
        Me.ShowIcon = False
        Me.Text = "Boxplot"
        Me.TopMost = True
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcrButtons1 As ucrButtons
    Friend WithEvents UcrDataSelection1 As ucrDataSelection
    Friend WithEvents lblTittle As Label
    Friend WithEvents txtTittle As TextBox
End Class
