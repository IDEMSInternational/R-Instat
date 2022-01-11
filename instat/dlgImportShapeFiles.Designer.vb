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
        Me.ucrChkSplitGeometry = New instat.ucrCheck()
        Me.ucrSaveDataframeName = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFile.Location = New System.Drawing.Point(7, 23)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(26, 13)
        Me.lblFile.TabIndex = 0
        Me.lblFile.Text = "File:"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBrowse.Location = New System.Drawing.Point(291, 18)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(122, 23)
        Me.cmdBrowse.TabIndex = 2
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'cmdLibrary
        '
        Me.cmdLibrary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLibrary.Location = New System.Drawing.Point(291, 60)
        Me.cmdLibrary.Name = "cmdLibrary"
        Me.cmdLibrary.Size = New System.Drawing.Size(122, 23)
        Me.cmdLibrary.TabIndex = 3
        Me.cmdLibrary.Text = "From Library"
        Me.cmdLibrary.UseVisualStyleBackColor = True
        '
        'ucrChkSplitGeometry
        '
        Me.ucrChkSplitGeometry.AutoSize = True
        Me.ucrChkSplitGeometry.Checked = False
        Me.ucrChkSplitGeometry.Location = New System.Drawing.Point(7, 89)
        Me.ucrChkSplitGeometry.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrChkSplitGeometry.Name = "ucrChkSplitGeometry"
        Me.ucrChkSplitGeometry.Size = New System.Drawing.Size(150, 23)
        Me.ucrChkSplitGeometry.TabIndex = 5
        '
        'ucrSaveDataframeName
        '
        Me.ucrSaveDataframeName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveDataframeName.Location = New System.Drawing.Point(7, 60)
        Me.ucrSaveDataframeName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveDataframeName.Name = "ucrSaveDataframeName"
        Me.ucrSaveDataframeName.Size = New System.Drawing.Size(270, 24)
        Me.ucrSaveDataframeName.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(7, 120)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 6
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.AutoSize = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        Me.ucrInputFilePath.Location = New System.Drawing.Point(49, 18)
        Me.ucrInputFilePath.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.Size = New System.Drawing.Size(239, 23)
        Me.ucrInputFilePath.TabIndex = 1
        '
        'dlgImportShapeFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(419, 174)
        Me.Controls.Add(Me.ucrChkSplitGeometry)
        Me.Controls.Add(Me.ucrSaveDataframeName)
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
        Me.Text = "Import Shapefiles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFile As Label
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdLibrary As Button
    Friend WithEvents ucrSaveDataframeName As ucrSave
    Friend WithEvents ucrChkSplitGeometry As ucrCheck
End Class
