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
        Me.lblBackupHeader.AutoSize = True
        Me.lblBackupHeader.Location = New System.Drawing.Point(4, 24)
        Me.lblBackupHeader.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBackupHeader.Name = "lblBackupHeader"
        Me.lblBackupHeader.Size = New System.Drawing.Size(92, 13)
        Me.lblBackupHeader.TabIndex = 9
        Me.lblBackupHeader.Text = "Backup versions :"
        '
        'ctrLstViewDataBackups
        '
        Me.ctrLstViewDataBackups.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ctrLstViewColName, Me.ctrLstViewColDate, Me.ctrLstViewSize})
        Me.ctrLstViewDataBackups.HideSelection = False
        Me.ctrLstViewDataBackups.Location = New System.Drawing.Point(4, 41)
        Me.ctrLstViewDataBackups.Margin = New System.Windows.Forms.Padding(2)
        Me.ctrLstViewDataBackups.Name = "ctrLstViewDataBackups"
        Me.ctrLstViewDataBackups.Size = New System.Drawing.Size(277, 113)
        Me.ctrLstViewDataBackups.TabIndex = 8
        Me.ctrLstViewDataBackups.UseCompatibleStateImageBehavior = False
        Me.ctrLstViewDataBackups.View = System.Windows.Forms.View.Details
        '
        'ctrLstViewColName
        '
        Me.ctrLstViewColName.Text = "Name"
        Me.ctrLstViewColName.Width = 158
        '
        'ctrLstViewColDate
        '
        Me.ctrLstViewColDate.Text = "Date modified"
        Me.ctrLstViewColDate.Width = 152
        '
        'ctrLstViewSize
        '
        Me.ctrLstViewSize.Text = "Size"
        Me.ctrLstViewSize.Width = 96
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(223, 155)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(51, 19)
        Me.cmdClose.TabIndex = 7
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        Me.cmdHelp.Location = New System.Drawing.Point(168, 155)
        Me.cmdHelp.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(51, 19)
        Me.cmdHelp.TabIndex = 6
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(113, 155)
        Me.cmdDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(51, 19)
        Me.cmdDelete.TabIndex = 5
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdOpen
        '
        Me.cmdOpen.AutoSize = True
        Me.cmdOpen.Location = New System.Drawing.Point(4, 155)
        Me.cmdOpen.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(51, 23)
        Me.cmdOpen.TabIndex = 3
        Me.cmdOpen.Text = "Open"
        Me.cmdOpen.UseVisualStyleBackColor = True
        '
        'lblBackupMessage
        '
        Me.lblBackupMessage.AutoSize = True
        Me.lblBackupMessage.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblBackupMessage.Location = New System.Drawing.Point(3, 5)
        Me.lblBackupMessage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBackupMessage.Name = "lblBackupMessage"
        Me.lblBackupMessage.Size = New System.Drawing.Size(281, 13)
        Me.lblBackupMessage.TabIndex = 10
        Me.lblBackupMessage.Text = "The backup versions come from periodic system backups."
        '
        'cmdSave
        '
        Me.cmdSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSave.Location = New System.Drawing.Point(59, 155)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(51, 19)
        Me.cmdSave.TabIndex = 11
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'dlgBackupManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(284, 178)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.ctrLstViewDataBackups)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.lblBackupHeader)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.lblBackupMessage)
        Me.Controls.Add(Me.cmdOpen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgBackupManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup Manager"
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
