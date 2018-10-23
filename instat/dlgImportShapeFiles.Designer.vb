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
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.ucrBase = New instat.ucrButtons()
        Me.cmdLibrary = New System.Windows.Forms.Button()
        Me.ucrInputDataName = New instat.ucrInputTextBox()
        Me.lblDataFramePrefix = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(12, 21)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(26, 13)
        Me.lblFile.TabIndex = 0
        Me.lblFile.Text = "File:"
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        Me.ucrInputFilePath.Location = New System.Drawing.Point(44, 18)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.Size = New System.Drawing.Size(194, 21)
        Me.ucrInputFilePath.TabIndex = 1
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(329, 18)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(75, 23)
        Me.cmdBrowse.TabIndex = 2
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(4, 155)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 3
        '
        'cmdLibrary
        '
        Me.cmdLibrary.Location = New System.Drawing.Point(329, 60)
        Me.cmdLibrary.Name = "cmdLibrary"
        Me.cmdLibrary.Size = New System.Drawing.Size(75, 23)
        Me.cmdLibrary.TabIndex = 4
        Me.cmdLibrary.Text = "From Library"
        Me.cmdLibrary.UseVisualStyleBackColor = True
        '
        'ucrInputDataName
        '
        Me.ucrInputDataName.AddQuotesIfUnrecognised = True
        Me.ucrInputDataName.IsMultiline = False
        Me.ucrInputDataName.IsReadOnly = False
        Me.ucrInputDataName.Location = New System.Drawing.Point(133, 128)
        Me.ucrInputDataName.Name = "ucrInputDataName"
        Me.ucrInputDataName.Size = New System.Drawing.Size(188, 21)
        Me.ucrInputDataName.TabIndex = 9
        '
        'lblDataFramePrefix
        '
        Me.lblDataFramePrefix.AutoSize = True
        Me.lblDataFramePrefix.Location = New System.Drawing.Point(5, 131)
        Me.lblDataFramePrefix.Name = "lblDataFramePrefix"
        Me.lblDataFramePrefix.Size = New System.Drawing.Size(114, 13)
        Me.lblDataFramePrefix.TabIndex = 8
        Me.lblDataFramePrefix.Tag = "Prefix_for_Data_Frames:"
        Me.lblDataFramePrefix.Text = "Prefix for Data Frames:"
        '
        'dlgImportShapeFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 221)
        Me.Controls.Add(Me.ucrInputDataName)
        Me.Controls.Add(Me.lblDataFramePrefix)
        Me.Controls.Add(Me.cmdLibrary)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.lblFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
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
    Friend WithEvents ucrInputDataName As ucrInputTextBox
    Friend WithEvents lblDataFramePrefix As Label
End Class
