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
        Me.ucrReceiverDeleteRows = New instat.ucrReceiverMultiple()
        Me.lstRowsToDelete = New System.Windows.Forms.ListBox()
        Me.lblRowsToDelete = New System.Windows.Forms.Label()
        Me.lblColumnsFromWhichToDeleteTheseRows = New System.Windows.Forms.Label()
        Me.ucrSelectorForDeleteRows = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 277)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(404, 55)
        Me.ucrBase.TabIndex = 5
        '
        'ucrReceiverDeleteRows
        '
        Me.ucrReceiverDeleteRows.Location = New System.Drawing.Point(286, 42)
        Me.ucrReceiverDeleteRows.Name = "ucrReceiverDeleteRows"
        Me.ucrReceiverDeleteRows.Selector = Nothing
        Me.ucrReceiverDeleteRows.Size = New System.Drawing.Size(121, 138)
        Me.ucrReceiverDeleteRows.TabIndex = 2
        '
        'lstRowsToDelete
        '
        Me.lstRowsToDelete.FormattingEnabled = True
        Me.lstRowsToDelete.Location = New System.Drawing.Point(12, 215)
        Me.lstRowsToDelete.Name = "lstRowsToDelete"
        Me.lstRowsToDelete.Size = New System.Drawing.Size(226, 56)
        Me.lstRowsToDelete.TabIndex = 4
        '
        'lblRowsToDelete
        '
        Me.lblRowsToDelete.AutoSize = True
        Me.lblRowsToDelete.Location = New System.Drawing.Point(12, 199)
        Me.lblRowsToDelete.Name = "lblRowsToDelete"
        Me.lblRowsToDelete.Size = New System.Drawing.Size(78, 13)
        Me.lblRowsToDelete.TabIndex = 3
        Me.lblRowsToDelete.Tag = "Rows_to_delete"
        Me.lblRowsToDelete.Text = "Rows to delete"
        '
        'lblColumnsFromWhichToDeleteTheseRows
        '
        Me.lblColumnsFromWhichToDeleteTheseRows.AutoSize = True
        Me.lblColumnsFromWhichToDeleteTheseRows.Location = New System.Drawing.Point(293, 13)
        Me.lblColumnsFromWhichToDeleteTheseRows.Name = "lblColumnsFromWhichToDeleteTheseRows"
        Me.lblColumnsFromWhichToDeleteTheseRows.Size = New System.Drawing.Size(50, 13)
        Me.lblColumnsFromWhichToDeleteTheseRows.TabIndex = 1
        Me.lblColumnsFromWhichToDeleteTheseRows.Text = "Variables"
        '
        'ucrSelectorForDeleteRows
        '
        Me.ucrSelectorForDeleteRows.Location = New System.Drawing.Point(12, 12)
        Me.ucrSelectorForDeleteRows.Name = "ucrSelectorForDeleteRows"
        Me.ucrSelectorForDeleteRows.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorForDeleteRows.TabIndex = 0
        '
        'dlgDeleteRows
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 344)
        Me.Controls.Add(Me.ucrSelectorForDeleteRows)
        Me.Controls.Add(Me.lblColumnsFromWhichToDeleteTheseRows)
        Me.Controls.Add(Me.lblRowsToDelete)
        Me.Controls.Add(Me.lstRowsToDelete)
        Me.Controls.Add(Me.ucrReceiverDeleteRows)
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
    Friend WithEvents ucrReceiverDeleteRows As ucrReceiverMultiple
    Friend WithEvents lstRowsToDelete As ListBox
    Friend WithEvents lblRowsToDelete As Label
    Friend WithEvents lblColumnsFromWhichToDeleteTheseRows As Label
    Friend WithEvents ucrSelectorForDeleteRows As ucrSelectorByDataFrameAddRemove
End Class
