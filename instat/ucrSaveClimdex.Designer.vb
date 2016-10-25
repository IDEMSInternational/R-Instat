<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrSaveClimdex
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ucrInputClimdexName = New instat.ucrInputComboBox()
        Me.chkSaveClimdex = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ucrInputClimdexName
        '
        Me.ucrInputClimdexName.IsReadOnly = False
        Me.ucrInputClimdexName.Location = New System.Drawing.Point(86, 0)
        Me.ucrInputClimdexName.Name = "ucrInputClimdexName"
        Me.ucrInputClimdexName.Size = New System.Drawing.Size(180, 20)
        Me.ucrInputClimdexName.TabIndex = 0
        '
        'chkSaveClimdex
        '
        Me.chkSaveClimdex.AutoSize = True
        Me.chkSaveClimdex.Location = New System.Drawing.Point(0, 3)
        Me.chkSaveClimdex.Name = "chkSaveClimdex"
        Me.chkSaveClimdex.Size = New System.Drawing.Size(90, 17)
        Me.chkSaveClimdex.TabIndex = 1
        Me.chkSaveClimdex.Tag = "Save_Climdex"
        Me.chkSaveClimdex.Text = "Save Climdex"
        Me.chkSaveClimdex.UseVisualStyleBackColor = True
        '
        'ucrSaveClimdex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkSaveClimdex)
        Me.Controls.Add(Me.ucrInputClimdexName)
        Me.Name = "ucrSaveClimdex"
        Me.Size = New System.Drawing.Size(265, 20)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrInputClimdexName As ucrInputComboBox
    Friend WithEvents chkSaveClimdex As CheckBox
End Class
