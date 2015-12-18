<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDeleteRows
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
        Me.ucrReceiverDeleteRows = New instat.ucrReceiverMultiple()
        Me.lstRowsToDelete = New System.Windows.Forms.ListBox()
        Me.lblRowsToDelete = New System.Windows.Forms.Label()
        Me.lblColumnsFromWhichToDeleteTheseRows = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 245)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(440, 32)
        Me.ucrBase.TabIndex = 0
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(12, 12)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(203, 127)
        Me.ucrAddRemove.TabIndex = 1
        '
        'ucrReceiverDeleteRows
        '
        Me.ucrReceiverDeleteRows.Location = New System.Drawing.Point(232, 33)
        Me.ucrReceiverDeleteRows.Name = "ucrReceiverDeleteRows"
        Me.ucrReceiverDeleteRows.Size = New System.Drawing.Size(121, 138)
        Me.ucrReceiverDeleteRows.TabIndex = 2
        '
        'lstRowsToDelete
        '
        Me.lstRowsToDelete.FormattingEnabled = True
        Me.lstRowsToDelete.Location = New System.Drawing.Point(12, 183)
        Me.lstRowsToDelete.Name = "lstRowsToDelete"
        Me.lstRowsToDelete.Size = New System.Drawing.Size(226, 56)
        Me.lstRowsToDelete.TabIndex = 3
        '
        'lblRowsToDelete
        '
        Me.lblRowsToDelete.AutoSize = True
        Me.lblRowsToDelete.Location = New System.Drawing.Point(12, 158)
        Me.lblRowsToDelete.Name = "lblRowsToDelete"
        Me.lblRowsToDelete.Size = New System.Drawing.Size(78, 13)
        Me.lblRowsToDelete.TabIndex = 4
        Me.lblRowsToDelete.Tag = "Rows_to_delete"
        Me.lblRowsToDelete.Text = "Rows to delete"
        '
        'lblColumnsFromWhichToDeleteTheseRows
        '
        Me.lblColumnsFromWhichToDeleteTheseRows.AutoSize = True
        Me.lblColumnsFromWhichToDeleteTheseRows.Location = New System.Drawing.Point(229, 12)
        Me.lblColumnsFromWhichToDeleteTheseRows.Name = "lblColumnsFromWhichToDeleteTheseRows"
        Me.lblColumnsFromWhichToDeleteTheseRows.Size = New System.Drawing.Size(39, 13)
        Me.lblColumnsFromWhichToDeleteTheseRows.TabIndex = 5
        Me.lblColumnsFromWhichToDeleteTheseRows.Text = "Label2"
        '
        'dlgDeleteRows
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 289)
        Me.Controls.Add(Me.lblColumnsFromWhichToDeleteTheseRows)
        Me.Controls.Add(Me.lblRowsToDelete)
        Me.Controls.Add(Me.lstRowsToDelete)
        Me.Controls.Add(Me.ucrReceiverDeleteRows)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgDeleteRows"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Delete_rows"
        Me.Text = "Delete rows"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverDeleteRows As ucrReceiverMultiple
    Friend WithEvents lstRowsToDelete As ListBox
    Friend WithEvents lblRowsToDelete As Label
    Friend WithEvents lblColumnsFromWhichToDeleteTheseRows As Label
End Class
