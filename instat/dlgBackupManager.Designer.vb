<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgBackupManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgBackupManager))
        Me.lblBackupHeader = New System.Windows.Forms.Label()
        Me.ctrLstViewDataBackups = New System.Windows.Forms.ListView()
        Me.ctrLstViewColName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ctrLstViewColDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ctrLstViewSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdOpen = New System.Windows.Forms.Button()
        Me.lblBackupMessage = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblBackupHeader
        '
        resources.ApplyResources(Me.lblBackupHeader, "lblBackupHeader")
        Me.lblBackupHeader.Name = "lblBackupHeader"
        '
        'ucrLstViewDataBackups
        '
        Me.ctrLstViewDataBackups.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ctrLstViewColName, Me.ctrLstViewColDate, Me.ctrLstViewSize})
        resources.ApplyResources(Me.ctrLstViewDataBackups, "ucrLstViewDataBackups")
        Me.ctrLstViewDataBackups.Name = "ucrLstViewDataBackups"
        Me.ctrLstViewDataBackups.UseCompatibleStateImageBehavior = False
        Me.ctrLstViewDataBackups.View = System.Windows.Forms.View.Details
        '
        'ucrLstViewColName
        '
        resources.ApplyResources(Me.ctrLstViewColName, "ucrLstViewColName")
        '
        'ucrLstViewColDate
        '
        resources.ApplyResources(Me.ctrLstViewColDate, "ucrLstViewColDate")
        '
        'ucrLstViewSize
        '
        resources.ApplyResources(Me.ctrLstViewSize, "ucrLstViewSize")
        '
        'cmdClose
        '
        resources.ApplyResources(Me.cmdClose, "cmdClose")
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        resources.ApplyResources(Me.cmdHelp, "cmdHelp")
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        resources.ApplyResources(Me.cmdDelete, "cmdDelete")
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdOpen
        '
        resources.ApplyResources(Me.cmdOpen, "cmdOpen")
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.UseVisualStyleBackColor = True
        '
        'lblBackupMessage
        '
        resources.ApplyResources(Me.lblBackupMessage, "lblBackupMessage")
        Me.lblBackupMessage.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblBackupMessage.Name = "lblBackupMessage"
        '
        'cmdSave
        '
        resources.ApplyResources(Me.cmdSave, "cmdSave")
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'dlgBackupManager
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.ctrLstViewDataBackups)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.lblBackupHeader)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.lblBackupMessage)
        Me.Controls.Add(Me.cmdOpen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgBackupManager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBackupMessage As Label
    Friend WithEvents lblBackupHeader As Label
    Friend WithEvents ctrLstViewDataBackups As ListView
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdHelp As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdOpen As Button
    Friend WithEvents ctrLstViewColName As ColumnHeader
    Friend WithEvents ctrLstViewColDate As ColumnHeader
    Friend WithEvents ctrLstViewSize As ColumnHeader
    Friend WithEvents cmdSave As Button
End Class
