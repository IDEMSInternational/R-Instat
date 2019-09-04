<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCircular
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
        Me.UcrButtons1 = New instat.ucrButtons()
        Me.ucrToCircularSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'UcrButtons1
        '
        Me.UcrButtons1.Location = New System.Drawing.Point(86, 373)
        Me.UcrButtons1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UcrButtons1.Name = "UcrButtons1"
        Me.UcrButtons1.Size = New System.Drawing.Size(547, 64)
        Me.UcrButtons1.TabIndex = 0
        '
        'ucrToCircularSelector
        '
        Me.ucrToCircularSelector.bDropUnusedFilterLevels = False
        Me.ucrToCircularSelector.bShowHiddenColumns = False
        Me.ucrToCircularSelector.bUseCurrentFilter = True
        Me.ucrToCircularSelector.Location = New System.Drawing.Point(9, 9)
        Me.ucrToCircularSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrToCircularSelector.Name = "ucrToCircularSelector"
        Me.ucrToCircularSelector.Size = New System.Drawing.Size(280, 222)
        Me.ucrToCircularSelector.TabIndex = 1
        '
        'dlgCircular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ucrToCircularSelector)
        Me.Controls.Add(Me.UcrButtons1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCircular"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Circular"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcrButtons1 As ucrButtons
    Friend WithEvents ucrToCircularSelector As ucrSelectorByDataFrameAddRemove
End Class
