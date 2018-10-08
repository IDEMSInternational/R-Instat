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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgImportShapeFiles))
        Me.lblFile = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.cmdLibrary = New System.Windows.Forms.Button()
        Me.ucrSaveDataframeName = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'lblFile
        '
        resources.ApplyResources(Me.lblFile, "lblFile")
        Me.lblFile.Name = "lblFile"
        '
        'cmdBrowse
        '
        resources.ApplyResources(Me.cmdBrowse, "cmdBrowse")
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'cmdLibrary
        '
        resources.ApplyResources(Me.cmdLibrary, "cmdLibrary")
        Me.cmdLibrary.Name = "cmdLibrary"
        Me.cmdLibrary.UseVisualStyleBackColor = True
        '
        'ucrSaveDataframeName
        '
        resources.ApplyResources(Me.ucrSaveDataframeName, "ucrSaveDataframeName")
        Me.ucrSaveDataframeName.Name = "ucrSaveDataframeName"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFilePath, "ucrInputFilePath")
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        '
        'dlgImportShapeFiles
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
