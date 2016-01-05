<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgName
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
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrSingle = New instat.ucrReceiverSingle()
        Me.ucrMultiple = New instat.ucrReceiverMultiple()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(4, 12)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(203, 127)
        Me.ucrAddRemove.TabIndex = 0
        '
        'ucrSingle
        '
        Me.ucrSingle.Location = New System.Drawing.Point(213, 12)
        Me.ucrSingle.Name = "ucrSingle"
        Me.ucrSingle.Size = New System.Drawing.Size(106, 26)
        Me.ucrSingle.TabIndex = 1
        '
        'ucrMultiple
        '
        Me.ucrMultiple.Enabled = False
        Me.ucrMultiple.Location = New System.Drawing.Point(213, 14)
        Me.ucrMultiple.Name = "ucrMultiple"
        Me.ucrMultiple.Size = New System.Drawing.Size(121, 128)
        Me.ucrMultiple.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(340, 36)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(341, 12)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 4
        Me.lblName.Tag = "Name"
        Me.lblName.Text = "Name"
        '
        'ucrBase
        '
        Me.ucrBase.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ucrBase.Location = New System.Drawing.Point(0, 150)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(447, 32)
        Me.ucrBase.TabIndex = 5
        '
        'dlgName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 182)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.ucrMultiple)
        Me.Controls.Add(Me.ucrSingle)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgName"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Names_for_the_data_column"
        Me.Text = "Names for data columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrSingle As ucrReceiverSingle
    Friend WithEvents ucrMultiple As ucrReceiverMultiple
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents ucrBase As ucrButtons
End Class
