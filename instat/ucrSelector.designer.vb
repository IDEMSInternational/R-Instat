<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrSelector
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
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblAvailableVariables = New System.Windows.Forms.Label()
        Me.lstAvailableVariable = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(102, 75)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 84
        Me.btnRemove.Tag = "Remove"
        Me.btnRemove.Text = "Remove "
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(102, 37)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 83
        Me.btnAdd.Tag = "Add"
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblAvailableVariables
        '
        Me.lblAvailableVariables.AutoSize = True
        Me.lblAvailableVariables.Location = New System.Drawing.Point(5, 2)
        Me.lblAvailableVariables.Name = "lblAvailableVariables"
        Me.lblAvailableVariables.Size = New System.Drawing.Size(102, 13)
        Me.lblAvailableVariables.TabIndex = 82
        Me.lblAvailableVariables.Tag = "Available_Variables "
        Me.lblAvailableVariables.Text = "Available  Variables "
        '
        'lstAvailableVariable
        '
        Me.lstAvailableVariable.FormattingEnabled = True
        Me.lstAvailableVariable.Location = New System.Drawing.Point(12, 22)
        Me.lstAvailableVariable.Name = "lstAvailableVariable"
        Me.lstAvailableVariable.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstAvailableVariable.Size = New System.Drawing.Size(84, 95)
        Me.lstAvailableVariable.Sorted = True
        Me.lstAvailableVariable.TabIndex = 81
        Me.lstAvailableVariable.Tag = ""
        '
        'ucrSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblAvailableVariables)
        Me.Controls.Add(Me.lstAvailableVariable)
        Me.Name = "ucrSelector"
        Me.Size = New System.Drawing.Size(178, 123)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblAvailableVariables As Label
    Friend WithEvents lstAvailableVariable As ListBox
End Class
