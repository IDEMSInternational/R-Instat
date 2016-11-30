<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgLockUnlock
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
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverLockUnlock = New instat.ucrReceiverMultiple()
        Me.lblSelectedColumns = New System.Windows.Forms.Label()
        Me.rdoLock = New System.Windows.Forms.RadioButton()
        Me.rdoUnlock = New System.Windows.Forms.RadioButton()
        Me.chkReservefree = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ucrBase.Location = New System.Drawing.Point(0, 181)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(443, 79)
        Me.ucrBase.TabIndex = 0
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.bShowHiddenColumns = False
        Me.ucrAddRemove.Location = New System.Drawing.Point(3, 2)
        Me.ucrAddRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(203, 155)
        Me.ucrAddRemove.TabIndex = 1
        '
        'ucrReceiverLockUnlock
        '
        Me.ucrReceiverLockUnlock.Location = New System.Drawing.Point(203, 23)
        Me.ucrReceiverLockUnlock.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLockUnlock.Name = "ucrReceiverLockUnlock"
        Me.ucrReceiverLockUnlock.Selector = Nothing
        Me.ucrReceiverLockUnlock.Size = New System.Drawing.Size(121, 134)
        Me.ucrReceiverLockUnlock.TabIndex = 2
        '
        'lblSelectedColumns
        '
        Me.lblSelectedColumns.AutoSize = True
        Me.lblSelectedColumns.Location = New System.Drawing.Point(200, 9)
        Me.lblSelectedColumns.Name = "lblSelectedColumns"
        Me.lblSelectedColumns.Size = New System.Drawing.Size(95, 13)
        Me.lblSelectedColumns.TabIndex = 3
        Me.lblSelectedColumns.Tag = "Selected_variables"
        Me.lblSelectedColumns.Text = "Selected Variables"
        '
        'rdoLock
        '
        Me.rdoLock.AutoSize = True
        Me.rdoLock.Location = New System.Drawing.Point(326, 26)
        Me.rdoLock.Name = "rdoLock"
        Me.rdoLock.Size = New System.Drawing.Size(49, 17)
        Me.rdoLock.TabIndex = 4
        Me.rdoLock.TabStop = True
        Me.rdoLock.Tag = "Lock"
        Me.rdoLock.Text = "Lock"
        Me.rdoLock.UseVisualStyleBackColor = True
        '
        'rdoUnlock
        '
        Me.rdoUnlock.AutoSize = True
        Me.rdoUnlock.Location = New System.Drawing.Point(326, 58)
        Me.rdoUnlock.Name = "rdoUnlock"
        Me.rdoUnlock.Size = New System.Drawing.Size(59, 17)
        Me.rdoUnlock.TabIndex = 5
        Me.rdoUnlock.TabStop = True
        Me.rdoUnlock.Tag = "Unlock"
        Me.rdoUnlock.Text = "Unlock"
        Me.rdoUnlock.UseVisualStyleBackColor = True
        '
        'chkReservefree
        '
        Me.chkReservefree.AutoSize = True
        Me.chkReservefree.Location = New System.Drawing.Point(326, 93)
        Me.chkReservefree.Name = "chkReservefree"
        Me.chkReservefree.Size = New System.Drawing.Size(119, 17)
        Me.chkReservefree.TabIndex = 6
        Me.chkReservefree.Tag = "Reserve_free_space"
        Me.chkReservefree.Text = "Reserve free space"
        Me.chkReservefree.UseVisualStyleBackColor = True
        '
        'dlgLockUnlock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 260)
        Me.Controls.Add(Me.chkReservefree)
        Me.Controls.Add(Me.rdoUnlock)
        Me.Controls.Add(Me.rdoLock)
        Me.Controls.Add(Me.lblSelectedColumns)
        Me.Controls.Add(Me.ucrReceiverLockUnlock)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgLockUnlock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Lock_and_unlock"
        Me.Text = "Lock and unlock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverLockUnlock As ucrReceiverMultiple
    Friend WithEvents lblSelectedColumns As Label
    Friend WithEvents rdoLock As RadioButton
    Friend WithEvents rdoUnlock As RadioButton
    Friend WithEvents chkReservefree As CheckBox
End Class
