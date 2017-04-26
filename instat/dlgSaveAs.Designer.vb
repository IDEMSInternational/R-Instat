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
        Me.lblSaveDataTo = New System.Windows.Forms.Label()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.cmdChooseFile = New System.Windows.Forms.Button()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 56)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'lblSaveDataTo
        '
        Me.lblSaveDataTo.AutoSize = True
        Me.lblSaveDataTo.Location = New System.Drawing.Point(10, 15)
        Me.lblSaveDataTo.Name = "lblSaveDataTo"
        Me.lblSaveDataTo.Size = New System.Drawing.Size(77, 13)
        Me.lblSaveDataTo.TabIndex = 18
        Me.lblSaveDataTo.Text = "Save Data To:"
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        Me.ucrInputFilePath.Location = New System.Drawing.Point(91, 12)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.Size = New System.Drawing.Size(320, 21)
        Me.ucrInputFilePath.TabIndex = 19
        '
        'cmdChooseFile
        '
        Me.cmdChooseFile.Location = New System.Drawing.Point(415, 12)
        Me.cmdChooseFile.Name = "cmdChooseFile"
        Me.cmdChooseFile.Size = New System.Drawing.Size(65, 21)
        Me.cmdChooseFile.TabIndex = 17
        Me.cmdChooseFile.Text = "Browse..."
        Me.cmdChooseFile.UseVisualStyleBackColor = True
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Location = New System.Drawing.Point(91, 40)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(0, 13)
        Me.lblConfirm.TabIndex = 20
        '
        'dlgSaveAs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 116)
        Me.Controls.Add(Me.lblConfirm)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.lblSaveDataTo)
        Me.Controls.Add(Me.cmdChooseFile)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSaveAs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Save_Data_As"
        Me.Text = "Save  Data As"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblSaveDataTo As Label
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents cmdChooseFile As Button
    Friend WithEvents lblConfirm As Label
End Class
