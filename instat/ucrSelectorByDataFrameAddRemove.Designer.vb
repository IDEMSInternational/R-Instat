<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrSelectorByDataFrameAddRemove
    Inherits instat.ucrSelectorByDataFrame

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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrAvailableDataFrames
        '
        Me.ucrAvailableDataFrames.TabIndex = 0
        '
        'lblVariables
        '
        '
        'lstAvailableVariable
        '
        Me.lstAvailableVariable.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(149, 95)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Tag = "add"
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnOptions
        '
        Me.btnOptions.Location = New System.Drawing.Point(149, 136)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(75, 23)
        Me.btnOptions.TabIndex = 4
        Me.btnOptions.Tag = "options"
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'ucrSelectorByDataFrameAddRemove
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "ucrSelectorByDataFrameAddRemove"
        Me.Size = New System.Drawing.Size(242, 179)
        Me.Controls.SetChildIndex(Me.ucrAvailableDataFrames, 0)
        Me.Controls.SetChildIndex(Me.lstAvailableVariable, 0)
        Me.Controls.SetChildIndex(Me.btnAdd, 0)
        Me.Controls.SetChildIndex(Me.btnOptions, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnOptions As Button
End Class
