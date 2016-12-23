<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrSelectorAddRemove
    Inherits instat.ucrSelector

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstAvailableVariable
        '
        Me.lstAvailableVariable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstAvailableVariable.Dock = System.Windows.Forms.DockStyle.None
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(123, 40)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 83
        Me.btnAdd.Tag = "Add"
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.cmdOptions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOptions.Location = New System.Drawing.Point(123, 96)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(75, 34)
        Me.cmdOptions.TabIndex = 84
        Me.cmdOptions.Tag = "Data_Options"
        Me.cmdOptions.Text = "Data Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrSelectorAddRemove
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "ucrSelectorAddRemove"
        Me.Size = New System.Drawing.Size(201, 147)
        Me.Controls.SetChildIndex(Me.lstAvailableVariable, 0)
        Me.Controls.SetChildIndex(Me.btnAdd, 0)
        Me.Controls.SetChildIndex(Me.cmdOptions, 0)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents cmdOptions As Button
End Class
