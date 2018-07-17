<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgImportShapeFiles
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
        Me.lblFile = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.cmdLibrary = New System.Windows.Forms.Button()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrSaveDataframeName = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(18, 32)
        Me.lblFile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(38, 20)
        Me.lblFile.TabIndex = 0
        Me.lblFile.Text = "File:"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(494, 28)
        Me.cmdBrowse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(112, 35)
        Me.cmdBrowse.TabIndex = 2
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'cmdLibrary
        '
        Me.cmdLibrary.Location = New System.Drawing.Point(494, 92)
        Me.cmdLibrary.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdLibrary.Name = "cmdLibrary"
        Me.cmdLibrary.Size = New System.Drawing.Size(112, 35)
        Me.cmdLibrary.TabIndex = 4
        Me.cmdLibrary.Text = "From Library"
        Me.cmdLibrary.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(6, 238)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(615, 80)
        Me.ucrBase.TabIndex = 3
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        Me.ucrInputFilePath.Location = New System.Drawing.Point(66, 28)
        Me.ucrInputFilePath.Margin = New System.Windows.Forms.Padding(14, 18, 14, 18)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.Size = New System.Drawing.Size(291, 32)
        Me.ucrInputFilePath.TabIndex = 1
        '
        'ucrSaveDataframeName
        '
        Me.ucrSaveDataframeName.Location = New System.Drawing.Point(22, 185)
        Me.ucrSaveDataframeName.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveDataframeName.Name = "ucrSaveDataframeName"
        Me.ucrSaveDataframeName.Size = New System.Drawing.Size(405, 37)
        Me.ucrSaveDataframeName.TabIndex = 6
        '
        'dlgImportShapeFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 340)
        Me.Controls.Add(Me.ucrSaveDataframeName)
        Me.Controls.Add(Me.cmdLibrary)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.lblFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgImportShapeFiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Shape Files"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFile As Label
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdLibrary As Button
    Friend WithEvents ucrSaveDataframeName As ucrSave
End Class
