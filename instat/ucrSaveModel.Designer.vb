<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrSaveModel
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
        Me.chkSaveModel = New System.Windows.Forms.CheckBox()
        Me.ucrInputModelName = New instat.ucrInputComboBox()
        Me.SuspendLayout()
        '
        'chkSaveModel
        '
        Me.chkSaveModel.AutoSize = True
        Me.chkSaveModel.Location = New System.Drawing.Point(0, 3)
        Me.chkSaveModel.Name = "chkSaveModel"
        Me.chkSaveModel.Size = New System.Drawing.Size(83, 17)
        Me.chkSaveModel.TabIndex = 1
        Me.chkSaveModel.Tag = "Save_Model"
        Me.chkSaveModel.Text = "Save Model"
        Me.chkSaveModel.UseVisualStyleBackColor = True
        '
        'ucrInputModelName
        '
        Me.ucrInputModelName.Location = New System.Drawing.Point(86, 0)
        Me.ucrInputModelName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInputModelName.Name = "ucrInputModelName"
        Me.ucrInputModelName.Size = New System.Drawing.Size(180, 20)
        Me.ucrInputModelName.TabIndex = 0
        '
        'ucrSaveModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkSaveModel)
        Me.Controls.Add(Me.ucrInputModelName)
        Me.Name = "ucrSaveModel"
        Me.Size = New System.Drawing.Size(265, 20)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkSaveModel As CheckBox
    Friend WithEvents ucrInputModelName As ucrInputComboBox
End Class
