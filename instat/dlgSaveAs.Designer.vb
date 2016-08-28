<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSaveAs
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
        Me.ucrBase = New instat.ucrButtons()
        Me.cmdChooseFile = New System.Windows.Forms.Button()
        Me.lblSaveDataTo = New System.Windows.Forms.Label()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 77)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'cmdChooseFile
        '
        Me.cmdChooseFile.Location = New System.Drawing.Point(413, 22)
        Me.cmdChooseFile.Name = "cmdChooseFile"
        Me.cmdChooseFile.Size = New System.Drawing.Size(91, 20)
        Me.cmdChooseFile.TabIndex = 17
        Me.cmdChooseFile.Text = "Choose File"
        Me.cmdChooseFile.UseVisualStyleBackColor = True
        '
        'lblSaveDataTo
        '
        Me.lblSaveDataTo.AutoSize = True
        Me.lblSaveDataTo.Location = New System.Drawing.Point(6, 25)
        Me.lblSaveDataTo.Name = "lblSaveDataTo"
        Me.lblSaveDataTo.Size = New System.Drawing.Size(77, 13)
        Me.lblSaveDataTo.TabIndex = 18
        Me.lblSaveDataTo.Text = "Save Data To:"
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.IsReadOnly = False
        Me.ucrInputFilePath.Location = New System.Drawing.Point(89, 22)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.Size = New System.Drawing.Size(320, 21)
        Me.ucrInputFilePath.TabIndex = 19
        '
        'txtConfirm
        '
        Me.txtConfirm.Location = New System.Drawing.Point(89, 49)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.ReadOnly = True
        Me.txtConfirm.Size = New System.Drawing.Size(320, 20)
        Me.txtConfirm.TabIndex = 21
        '
        'dlgSaveAs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 132)
        Me.Controls.Add(Me.txtConfirm)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.lblSaveDataTo)
        Me.Controls.Add(Me.cmdChooseFile)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgSaveAs"
        Me.Tag = "Save_As"
        Me.Text = "Save As"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblSaveDataTo As Label
    Friend WithEvents cmdChooseFile As Button
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents txtConfirm As TextBox
End Class
